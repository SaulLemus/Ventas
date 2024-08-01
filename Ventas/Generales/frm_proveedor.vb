
Imports System.Data
Imports System.Data.SqlClient

Public Class frm_proveedor
    Dim cproveedor As New proveedor
    Dim clista As New Lista


    Dim modo As Byte = 0  '0 estado inicial, '1 agregando,  2 modificando  3 consultando  4 eliminando

    Dim datos_validos As Boolean = False

    Dim codigo As String = ""
    Dim orden As Integer = 0
    Dim orden_lista As Integer = 0

    Private Sub frm_proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicializa()
    End Sub

    Private Sub inicializa()
        modo = 0
        limpia_campos()
        botones_inicio()
        deshabilita_campos()
    End Sub

    Private Sub limpia_campos()
        Me.Text = "proveedors"
        txt_orden.Text = ""
        txt_codigo.Text = ""
        txt_nombre.Text = ""
        txt_direccion.Text = ""
        txt_telefono.Text = ""
        txt_nit.Text = ""
        txt_correo.Text = ""
        txt_saldo.Text = ""
        dtg_movimientos.Rows.Clear()
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
        Me.Text = "Agregando proveedor"
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
        txt_nombre.Enabled = True
        txt_direccion.Enabled = True
        txt_telefono.Enabled = True
        txt_nit.Enabled = True
        txt_correo.Enabled = True
        txt_saldo.Enabled = True
    End Sub

    Private Sub deshabilita_campos()
        txt_codigo.Enabled = False
        txt_nombre.Enabled = False
        txt_direccion.Enabled = False
        txt_telefono.Enabled = False
        txt_nit.Enabled = False
        txt_correo.Enabled = False
        txt_saldo.Enabled = False
    End Sub

    Private Sub valida_datos()
        datos_validos = False
        If txt_codigo.Text <> "" Then
            cproveedor.buscar(txt_codigo.Text, str_cnn)
            If cproveedor.Aexiste = False Then
                datos_validos = True
            Else
                MessageBox.Show("Ya existe codigo de proveedor ", "Error al intentar grabar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_codigo.Text = ""
                txt_codigo.Focus()
                datos_validos = False
            End If

        Else
            MessageBox.Show("Debe especifica un codigo de proveedor valido", "Error al intentar grabar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_codigo.Text = ""
            txt_codigo.Focus()
            datos_validos = False
        End If
    End Sub

    Private Sub graba_datos()
        cproveedor.nuevo(txt_codigo.Text, _
                                       txt_nombre.Text, _
                                       txt_direccion.Text, _
                                       txt_telefono.Text, _
                                       txt_nit.Text, _
                                       txt_correo.Text, _
                                       orden_lista, _
                                       Val(txt_saldo.Text), _
                                        str_cnn _
                                       )
    End Sub


    Private Sub actualiza_datos()
        cproveedor.modifica(txt_codigo.Text, _
                                       txt_nombre.Text, _
                                       txt_direccion.Text, _
                                       txt_telefono.Text, _
                                       txt_nit.Text, _
                                       txt_correo.Text, _
                                       str_cnn _
                                       )
    End Sub
    Private Sub muestra_datos()
        txt_orden.Text = cproveedor.Aorden
        orden = cproveedor.Aorden
        txt_codigo.Text = codigo
        txt_nombre.Text = cproveedor.Anombre
        txt_direccion.Text = cproveedor.Adireccion
        txt_telefono.Text = cproveedor.Atelefono
        txt_nit.Text = cproveedor.Anit
        txt_correo.Text = cproveedor.Acorreo
        txt_saldo.Text = cproveedor.Asaldo
        'busca_movimientos()
    End Sub

    Private Sub verifica_eliminacion()
        cproveedor.buscar_cc(txt_codigo.Text, str_cnn)
        If cproveedor.Aexiste = True Then
            MessageBox.Show("El proveedor ya tiene movimientos no se puede eliminar", "ERROR: Eliminando registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            datos_validos = False
        End If
    End Sub

    Private Sub elimina_registro()
        cproveedor.elimina(orden, str_cnn)
    End Sub


    Private Sub btn_nuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        ' nuevo registro
        limpia_campos()
        habilita_campos()
        botones_agregar()
        txt_codigo.Focus()
    End Sub

    Private Sub btn_grabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_grabar.Click
        If modo = 1 Then
            valida_datos()
            If datos_validos = True Then
                graba_datos()
                deshabilita_campos()
                limpia_campos()
                botones_inicio()
            End If
        End If
        If modo = 2 Then
            actualiza_datos()
            deshabilita_campos()
            limpia_campos()
            botones_inicio()
        End If
    End Sub

    Private Sub txt_codigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_codigo.LostFocus
        If modo = 1 Then
            cproveedor.buscar(Trim(txt_codigo.Text), str_cnn)
            If cproveedor.Aexiste = True Then
                MessageBox.Show("Ya existe un proveedor con ese codigo", "Verificando codigo de proveedor", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_codigo.Text = ""
                txt_codigo.Focus()
            End If
        End If
    End Sub

    Private Sub btn_modifica_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_modifica.Click
        habilita_campos()
        botones_agregar()
        Me.Text = "Modificando proveedor"
        modo = 2
        txt_codigo.Enabled = False
        txt_nombre.Focus()
    End Sub


    Private Sub btn_buscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        'llama ventana de busqueda de articulos
        limpia_campos()
        deshabilita_campos()
        botones_inicio()
        datos_validos = True
        codigo = ""
        Dim consulta As New frm_bus_proveedor
        consulta.codigo = ""
        consulta.ShowDialog()
        datos_validos = consulta.resultado
        ' si no trae datos datos_validos  = false
        If datos_validos = True Then
            cproveedor.buscar(consulta.codigo, str_cnn)
            If cproveedor.Aexiste = True Then
                codigo = consulta.codigo
                muestra_datos()
                Me.Text = "proveedor: " & codigo & " " & cproveedor.Anombre
                modo = 2 'editable
                botones_editable()
            End If
        End If
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Dim respuesta As Byte
        datos_validos = True
        verifica_eliminacion()
        If datos_validos = True Then
            respuesta = MessageBox.Show("Confirma eliminacion de proveedor, no podra recuperarlo", "Eliminacion de proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If respuesta = vbYes Then
                elimina_registro()
                limpia_campos()
                deshabilita_campos()
                botones_inicio()
                MessageBox.Show("Se ELIMINO proveedor ", "Eliminacion de proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No se elimino proveedor ", "Eliminacion de proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub



    Private Sub btn_cancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        inicializa()
    End Sub


End Class