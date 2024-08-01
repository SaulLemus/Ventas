
Imports System.Data
Imports System.Data.SqlClient


Public Class frm_listaprecio

    Dim clista As New Lista
    Dim modo As Byte = 0  '0 estado inicial, '1 agregando,  2 modificando  3 consultando  4 eliminando
    Dim datos_validos As Boolean = False

    Dim codigo As String = ""
    Dim orden As Integer = 0

    Private Sub frm_listaprecio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicializa()
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        ' nuevo registro
        limpia_campos()
        habilita_campos()
        botones_agregar()
        txt_codigo.Focus()
    End Sub

    Private Sub inicializa()
        modo = 0
        limpia_campos()
        botones_inicio()
        deshabilita_campos()
    End Sub

    Private Sub limpia_campos()
        Me.Text = "listas"
        txt_orden.Text = ""
        txt_codigo.Text = ""
        txt_descripcion.Text = ""
        txt_porcentaje.Text = ""
        rd_porcentaje.Checked = True
        rd_valor.Checked = False
        dtg_detallelista.Rows.Clear()
    End Sub

    Private Sub botones_inicio()
        modo = 0
        ' botones al iniciar el formulario o despues de grabar, eliminar, buscar, o movimientos
        btn_nuevo.Enabled = True
        btn_modifica.Enabled = False
        btn_grabar.Enabled = False
        btn_eliminar.Enabled = False
        btn_cancelar.Enabled = False
        btn_buscar.Enabled = True
    End Sub

    Private Sub botones_agregar()
        Me.Text = "Agregando lista"
        modo = 1
        ' botones al agregar 
        btn_nuevo.Enabled = False
        btn_modifica.Enabled = False
        btn_grabar.Enabled = True
        btn_eliminar.Enabled = False
        btn_cancelar.Enabled = True
        btn_buscar.Enabled = True
    End Sub

    Private Sub botones_editable()
        btn_nuevo.Enabled = True
        btn_modifica.Enabled = True
        btn_grabar.Enabled = False
        btn_eliminar.Enabled = True
        btn_buscar.Enabled = True
    End Sub

    Private Sub habilita_campos()
        txt_codigo.Enabled = True
        txt_descripcion.Enabled = True
        rd_porcentaje.Enabled = True
        rd_valor.Enabled = True
        txt_porcentaje.Enabled = True
    End Sub

    Private Sub deshabilita_campos()
        txt_codigo.Enabled = False
        txt_descripcion.Enabled = False
        rd_porcentaje.Enabled = False
        rd_valor.Enabled = False
        txt_porcentaje.Enabled = False
    End Sub

    Private Sub valida_datos()
        datos_validos = False
        If txt_codigo.Text <> "" Then
            clista.buscar(txt_codigo.Text, str_cnn)
            If clista.Aexiste = False Then
                datos_validos = True
            Else
                MessageBox.Show("Ya existe codigo de lista ", "Error al intentar grabar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_codigo.Text = ""
                txt_codigo.Focus()
            End If
        Else
            MessageBox.Show("Debe especifica un codigo de lista valido", "Error al intentar grabar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_codigo.Text = ""
            txt_codigo.Focus()
        End If
    End Sub

    Private Sub verifica_datos()
        datos_validos = True
        If txt_codigo.Text <> "" Then
            datos_validos = True
        Else
            datos_validos = False
            MessageBox.Show("Codigo de lista invalido", "Verificando datos a grabar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If rd_porcentaje.Checked = True And Val(txt_porcentaje.Text) <= 0.0 Then
            datos_validos = False
            MessageBox.Show("Valor de porcentaje sobre el costo no es valido", "Verificando datos a grabar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If datos_validos = True Then
            graba_datos()
            inicializa()
        End If
    End Sub

    Private Sub graba_datos()
        Dim tipo As String = "val"
        Dim por As Decimal = 0.0
        If txt_porcentaje.Enabled = True Then
            tipo = "por"
            por = Val(txt_porcentaje.Text)
        End If
        If modo = 1 Then
            clista.nuevo(txt_codigo.Text, _
                         txt_descripcion.Text, _
                         tipo, _
                         por, _
                         str_cnn)
        Else
            If modo = 2 Then
                actualiza_datos()
            End If
        End If
    End Sub


    Private Sub actualiza_datos()
        Dim tipo As String = "val"
        Dim por As Decimal = 0.0
        If txt_porcentaje.Enabled = True Then
            tipo = "por"
            por = Val(txt_porcentaje.Text)
        End If
        clista.modifica(txt_codigo.Text, _
                                       txt_descripcion.Text, _
                                       tipo, _
                                       por, _
                                       str_cnn _
                                       )
    End Sub

    Private Sub muestra_datos()
        Dim tipo As String = clista.Atipo
        Dim por As Decimal = clista.Apor
        If tipo = "por" Then
            rd_porcentaje.Checked = True
            txt_porcentaje.Text = por
            rd_porcentaje.Checked = True
        Else
            rd_valor.Checked = True
            txt_porcentaje.Text = ""
        End If
        txt_orden.Text = clista.Aorden
        orden = clista.Aorden
        txt_codigo.Text = codigo
        txt_descripcion.Text = clista.Adescripcion
        'busca_movimientos()
    End Sub


    Private Sub verifica_eliminacion()
        'clista.buscar_cc(txt_codigo.Text, str_cnn)
        'If clista.Aexiste = True Then
        '    MessageBox.Show("El lista ya tiene movimientos no se puede eliminar", "ERROR: Eliminando registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    datos_validos = False
        'End If
    End Sub

    Private Sub elimina_registro()
        clista.elimina(orden, str_cnn)
    End Sub

    Private Sub txt_codigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_codigo.LostFocus
        If modo = 1 Then
            clista.buscar(Trim(txt_codigo.Text), str_cnn)
            If clista.Aexiste = True Then
                MessageBox.Show("Ya existe un lista con ese lista", "Verificando codigo de lista", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_codigo.Text = ""
                txt_codigo.Focus()
            End If
        End If
    End Sub

    Private Sub btn_modifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modifica.Click
        habilita_campos()
        botones_agregar()
        Me.Text = "Modificando lista"
        modo = 2
        txt_codigo.Enabled = False
        txt_descripcion.Focus()
    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        'llama ventana de busqueda de articulos
        limpia_campos()
        deshabilita_campos()
        botones_inicio()
        datos_validos = True
        codigo = ""
        Dim consulta As New frm_bus_lista
        consulta.codigo = ""
        consulta.ShowDialog()
        datos_validos = consulta.resultado
        ' si no trae datos datos_validos  = false
        If datos_validos = True Then
            clista.buscar(consulta.codigo, str_cnn)
            If clista.Aexiste = True Then
                codigo = consulta.codigo
                muestra_datos()
                Me.Text = "Lista: " & codigo & " " & clista.Adescripcion
                modo = 2 'editable
                botones_editable()
            End If
        End If
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Dim respuesta As Byte
        datos_validos = True
        verifica_eliminacion()
        If datos_validos = True Then
            respuesta = MessageBox.Show("Confirma eliminacion de lista, no podra recuperarlo", "Eliminacion de lista", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If respuesta = vbYes Then
                elimina_registro()
                limpia_campos()
                deshabilita_campos()
                botones_inicio()
                MessageBox.Show("Se ELIMINO lista ", "Eliminacion de lista", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No se elimino lista ", "Eliminacion de lista", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        inicializa()
    End Sub

    Private Sub btn_grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_grabar.Click
        verifica_datos()
    End Sub

End Class