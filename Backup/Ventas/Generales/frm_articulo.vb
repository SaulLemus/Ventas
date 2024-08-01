Imports System.Data
Imports System.Data.SqlClient

Public Class frm_articulo


    Dim carticulo As New articulo

    Dim datos_validos As Boolean = False
    Dim modo As Byte = 0 ' 0 inicio, 1 agregando
    Dim str_codigo As String
    Dim orden As Integer = 0
    Dim sql_tmp As String

    Private Sub frm_articulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicializa()
    End Sub

    Private Sub inicializa()
        limpia_campos()
        botones_inicio()
        deshabilita_campos()
    End Sub

    Private Sub limpia_campos()
        Me.Text = "Articulos"
        txt_orden.Text = ""
        txt_codigo.Text = ""
        txt_nombre.Text = ""
        txt_PrecioUcompra.Text = ""
        txt_costo.Text = ""
        txt_exiMin.Text = ""
        txt_exiMax.Text = ""
        txt_unidades.Text = ""
        'dtg_movimientos.Rows.Clear()
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
        Me.Text = "Agregando articulo"
        modo = 1
        ' botones al agregar 
        btn_nuevo.Enabled = False
        btn_modifica.Enabled = False
        btn_grabar.Enabled = True
        btn_eliminar.Enabled = False
        btn_cancelar.Enabled = True
        btn_buscar.Enabled = True
    End Sub

    Private Sub habilita_campos()
        txt_codigo.Enabled = True
        txt_nombre.Enabled = True
        txt_PrecioUcompra.Enabled = True
        txt_costo.Enabled = True
        txt_exiMin.Enabled = True
        txt_exiMax.Enabled = True
        txt_unidades.Enabled = True
    End Sub

    Private Sub deshabilita_campos()
        txt_codigo.Enabled = False
        txt_nombre.Enabled = False
        txt_PrecioUcompra.Enabled = False
        txt_costo.Enabled = False
        txt_exiMin.Enabled = False
        txt_exiMax.Enabled = False
        txt_unidades.Enabled = False
    End Sub



    Private Sub actualiza_datos()
        Dim eximin As Decimal
        Dim eximax As Decimal
        Dim unidades As Integer

        eximin = Math.Round(Val(txt_exiMin.Text), 2)
        eximax = Math.Round(Val(txt_exiMax.Text), 2)
        unidades = Val(txt_unidades.Text)

        carticulo.modifica(txt_codigo.Text, _
                                       txt_nombre.Text, _
                                       eximin, _
                                       eximax, _
                                       unidades, _
                                       str_cnn _
                                       )
    End Sub

    Private Sub valida_datos()
        datos_validos = False
        If txt_codigo.Text <> "" Then
            carticulo.buscar(txt_codigo.Text, str_cnn)
            If carticulo.Aexiste = False Then
                datos_validos = True
            Else
                MessageBox.Show("Ya existe codigo de articulo ", "Error al intentar grabar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_codigo.Text = ""
                txt_codigo.Focus()
            End If
        Else
            MessageBox.Show("Debe especifica un codigo de articulo valido", "Error al intentar grabar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_codigo.Text = ""
            txt_codigo.Focus()
        End If
    End Sub

    Private Sub graba_datos()
        Dim PrecioUcompra As Decimal
        Dim precio_costo As Decimal
        Dim existencia As Decimal
        Dim eximin As Decimal
        Dim eximax As Decimal
        Dim unidades As Decimal
        Dim orden_articulo As Integer = 0

        ' convertir a numerico y grabar los valores 
        PrecioUcompra = Math.Round(Val(txt_PrecioUcompra.Text), 2)
        eximin = Math.Round(Val(txt_exiMin.Text), 2)
        eximax = Math.Round(Val(txt_exiMax.Text), 2)
        unidades = Val(txt_unidades.Text)

        carticulo.nuevo(txt_codigo.Text, _
                                       txt_nombre.Text, _
                                       PrecioUcompra, _
                                       precio_costo, _
                                       existencia, _
                                       eximin, _
                                       eximax, _
                                       unidades, _
                                       str_cnn _
                                       )
        If carticulo.Aerror = False Then
            carticulo.buscar(txt_codigo.Text, str_cnn)
            crea_art_en_almacenes()
        End If

    End Sub


    Private Sub crea_art_en_almacenes()
        Dim myconn As New SqlConnection(str_cnn)
        Dim txt_sql As String = "select orden from tbl_almacen"
        myconn.Open()
        Dim myCmd As New SqlCommand(txt_sql, myconn)
        Dim myReader As SqlDataReader
        myReader = myCmd.ExecuteReader()
        If myReader.HasRows Then
            While myReader.Read()
                carticulo.buscar(txt_codigo.Text, str_cnn)
                If carticulo.Aexiste = True Then
                    orden = carticulo.Aorden
                    carticulo.buscar_almacenX(myReader.Item(0), orden, str_cnn)
                    If carticulo.Aexiste = False Then
                        carticulo.agrega_almacenX(myReader.Item(0), orden, str_cnn)
                    End If
                Else
                    MessageBox.Show("Error buscando articulo para agregar a almacenes", "Buscando articulo para almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End While
            'comboproveedor.SelectedIndex = -1
        End If
        myReader.Close()
        myconn.Close()
    End Sub


    Private Sub elimina_registro()
        carticulo.elimina(orden, str_cnn)
    End Sub


    Private Sub muestra_datos()
        txt_orden.Text = carticulo.Aorden
        orden = carticulo.Aorden
        txt_codigo.Text = str_codigo
        txt_nombre.Text = carticulo.Adescripcion
        txt_PrecioUcompra.Text = carticulo.Aprecio_ult_compra
        txt_costo.Text = carticulo.Aprecio_costo
        txt_exiMin.Text = carticulo.Aeximin
        txt_exiMax.Text = carticulo.Aeximax
        txt_unidades.Text = carticulo.Aunidades
        'busca_movimientos()
    End Sub

    Private Sub botones_editable()
        btn_nuevo.Enabled = True
        btn_modifica.Enabled = True
        btn_grabar.Enabled = False
        btn_eliminar.Enabled = True
        btn_buscar.Enabled = True
    End Sub


    Private Sub btn_modifica_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_modifica.Click
        habilita_campos()
        botones_agregar()
        Me.Text = "Modificando articulo"
        modo = 2
        txt_codigo.Enabled = False
        txt_nombre.Focus()
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
            inicializa()
        End If
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Dim respuesta As Byte
        datos_validos = True
        verifica_eliminacion()
        If datos_validos = True Then
            respuesta = MessageBox.Show("Confirma eliminacion de articulo, no podra recuperarlo", "Eliminacion de articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If respuesta = vbYes Then
                elimina_registro()
                limpia_campos()
                deshabilita_campos()
                botones_inicio()
                MessageBox.Show("Se ELIMINO articulo ", "Eliminacion de articulo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No se eimino articulo ", "Eliminacion de articulo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub


    Private Sub verifica_eliminacion()
        carticulo.movimiento_busca(Val(txt_orden.Text), str_cnn)
        If carticulo.Aexiste = True Then
            MessageBox.Show("El articulo ya tiene movimientos no se puede eliminar", "ERROR: Eliminando registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            datos_validos = False
        End If
    End Sub

    Private Sub btn_buscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        'llama ventana de busqueda de articulos
        limpia_campos()
        deshabilita_campos()
        botones_inicio()
        datos_validos = True
        str_codigo = ""
        Dim consulta As New frm_bus_articulo
        consulta.codigo = ""
        consulta.ShowDialog()
        datos_validos = consulta.resultado
        ' si no trae datos datos_validos  = false
        If datos_validos = True Then
            carticulo.buscar(consulta.codigo, str_cnn)
            If carticulo.Aexiste = True Then
                str_codigo = consulta.codigo
                muestra_datos()
                Me.Text = "Articulo: '" & str_codigo & "'"
                modo = 2 'editable
                botones_editable()
            End If
        End If
    End Sub


    Private Sub btn_cancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        limpia_campos()
        deshabilita_campos()
        botones_inicio()
        inicializa()
    End Sub


    Private Sub txt_codigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_codigo.LostFocus
        If modo = 1 Then
            If txt_codigo.Text <> "" Then
                carticulo.buscar(txt_codigo.Text, str_cnn)
                If carticulo.Aexiste = True Then
                    MessageBox.Show("Ya existe codigo de articulo", "ERROR:Ingresando codigo de articulo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt_codigo.Text = ""
                    txt_codigo.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        ' nuevo registro
        limpia_campos()
        habilita_campos()
        botones_agregar()
        txt_codigo.Focus()
    End Sub
End Class