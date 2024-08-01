

Imports System.Data
Imports System.Data.SqlClient

Public Class frm_almacen

    Dim calmacen As New almacen
    Dim modo As Byte = 0  '0 estado inicial, '1 agregando,  2 modificando  3 consultando  4 eliminando
    Dim datos_validos As Boolean = False

    Dim codigo As String = ""
    Dim orden As Integer = 0

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
        Me.Text = "almacens"
        txt_orden.Text = ""
        txt_codigo.Text = ""
        txt_descripcion.Text = ""
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
        Me.Text = "Agregando almacen"
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
    End Sub

    Private Sub deshabilita_campos()
        txt_codigo.Enabled = False
        txt_descripcion.Enabled = False
    End Sub

    Private Sub valida_datos()
        datos_validos = False
        If txt_codigo.Text <> "" Then
            calmacen.buscar(txt_codigo.Text, str_cnn)
            If calmacen.Aexiste = False Then
                datos_validos = True
            Else
                MessageBox.Show("Ya existe codigo de almacen ", "Error al intentar grabar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_codigo.Text = ""
                txt_codigo.Focus()
            End If
        Else
            MessageBox.Show("Debe especifica un codigo de almacen valido", "Error al intentar grabar", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            MessageBox.Show("Codigo de almacen invalido", "Verificando datos a grabar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If datos_validos = True Then
            graba_datos()
            inicializa()
        End If
    End Sub

    Private Sub graba_datos()
        Dim tipo As String = "val"
        Dim por As Decimal = 0.0
        If modo = 1 Then
            calmacen.nuevo(txt_codigo.Text, _
                         txt_descripcion.Text, _
                         str_cnn)
            If calmacen.Aerror = False Then
                llena_almacendet()
            End If
        Else
            If modo = 2 Then
                actualiza_datos()
            End If
        End If
    End Sub


    Private Sub llena_almacendet()
        Dim myconn As New SqlConnection(str_cnn)
        Dim ordenart As Integer = 0
        Dim txt_sql As String = " select orden from tbl_articulo order by orden "
        orden = 0
        calmacen.busca_ultimo(orden, str_cnn)
        If calmacen.Aerror = False Then
            If orden = 0 Then
                orden = 1
            End If
            myconn.Open()
            Dim myCmd As New SqlCommand(txt_sql, myconn)
            Dim myReader As SqlDataReader
            myReader = myCmd.ExecuteReader()
            If myReader.HasRows Then
                While myReader.Read()
                    ordenart = myReader.Item(0)
                    calmacen.inserta_detalle(orden, ordenart, str_cnn)
                End While
                'comboproveedor.SelectedIndex = -1
            End If
            myReader.Close()
            myconn.Close()
        End If
    End Sub

    Private Sub actualiza_datos()
        Dim tipo As String = "val"
        Dim por As Decimal = 0.0
        calmacen.modifica(txt_codigo.Text, _
                                       txt_descripcion.Text, _
                                       str_cnn _
                                       )
    End Sub

    Private Sub muestra_datos()
        txt_orden.Text = calmacen.Aorden
        orden = calmacen.Aorden
        txt_codigo.Text = codigo
        txt_descripcion.Text = calmacen.Adescripcion
        'busca_movimientos()
    End Sub


    Private Sub verifica_eliminacion()
        calmacen.buscar_uso(Val(txt_orden.Text), str_cnn)
        If calmacen.Aexiste = True Then
            MessageBox.Show("El almacen ya fue utilizado no se puede eliminar", "ERROR: Eliminando registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            datos_validos = False
        End If
    End Sub

    Private Sub elimina_registro()
        calmacen.elimina(orden, str_cnn)
    End Sub

    Private Sub txt_codigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_codigo.LostFocus
        If modo = 1 Then
            calmacen.buscar(Trim(txt_codigo.Text), str_cnn)
            If calmacen.Aexiste = True Then
                MessageBox.Show("Ya existe un almacen con ese almacen", "Verificando codigo de almacen", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_codigo.Text = ""
                txt_codigo.Focus()
            End If
        End If
    End Sub

    Private Sub btn_modifica_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_modifica.Click
        habilita_campos()
        botones_agregar()
        Me.Text = "Modificando almacen"
        modo = 2
        txt_codigo.Enabled = False
        txt_descripcion.Focus()
    End Sub


    Private Sub btn_buscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        'llama ventana de busqueda de articulos
        limpia_campos()
        deshabilita_campos()
        botones_inicio()
        datos_validos = True
        codigo = ""
        Dim consulta As New frm_bus_almacen
        consulta.codigo = ""
        consulta.ShowDialog()
        datos_validos = consulta.resultado
        ' si no trae datos datos_validos  = false
        If datos_validos = True Then
            calmacen.buscar(consulta.codigo, str_cnn)
            If calmacen.Aexiste = True Then
                codigo = consulta.codigo
                muestra_datos()
                Me.Text = "almacen: " & codigo & " " & calmacen.Adescripcion
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
            respuesta = MessageBox.Show("Confirma eliminacion de almacen, no podra recuperarlo", "Eliminacion de almacen", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If respuesta = vbYes Then
                elimina_registro()
                limpia_campos()
                deshabilita_campos()
                botones_inicio()
                MessageBox.Show("Se ELIMINO almacen ", "Eliminacion de almacen", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No se elimino almacen ", "Eliminacion de almacen", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        inicializa()
    End Sub

    Private Sub btn_grabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_grabar.Click
        verifica_datos()
    End Sub


    Private Sub frm_almacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicializa()
    End Sub

End Class