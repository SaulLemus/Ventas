
' Cliente objeto 1

Imports System.Data
Imports System.Data.SqlClient

Public Class frm_cliente

    Dim ccliente As New Cliente
    Dim clista As New Lista
    Dim Clog As New log

    Dim msglog As String = ""
    Dim objeto As Integer = 1

    Dim modo As Byte = 0  '0 estado inicial, '1 agregando,  2 modificando  3 consultando  4 eliminando

    Dim datos_validos As Boolean = False

    Dim codigo As String = ""
    Dim orden As Integer = 0
    Dim orden_lista As Integer = 0


    Private Sub frm_cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicializa()
    End Sub

    Private Sub inicializa()
        modo = 0
        limpia_campos()
        botones_inicio()
        deshabilita_campos()
    End Sub

    Private Sub limpia_campos()
        Me.Text = "Clientes"
        txt_orden.Text = ""
        txt_codigo.Text = ""
        txt_nombre.Text = ""
        txt_nit.Text = ""
        txt_direccion.Text = ""
        txt_telefono.Text = ""
        txt_correo.Text = ""
        txt_saldo.Text = ""
        txt_listado.Text = ""
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
        Me.Text = "Agregando cliente"
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
        txt_listado.Enabled = False
        btn_lista.Enabled = True
    End Sub

    Private Sub deshabilita_campos()
        txt_codigo.Enabled = False
        txt_nombre.Enabled = False
        txt_direccion.Enabled = False
        txt_telefono.Enabled = False
        txt_nit.Enabled = False
        txt_correo.Enabled = False
        txt_saldo.Enabled = False
        txt_listado.Enabled = False
        btn_lista.Enabled = True
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        ' nuevo registro
        limpia_campos()
        habilita_campos()
        botones_agregar()
        txt_codigo.Focus()
    End Sub



    Private Sub btn_grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_grabar.Click
        Dim ultimo As Integer = 0
        If modo = 1 Then
            valida_datos()
            If datos_validos = True Then
                graba_datos()
                If ccliente.Aerror = False Then
                    ccliente.ultimo(txt_codigo.Text, str_cnn)
                    msglog = "Grabado cliente: " & txt_codigo.Text
                    ultimo = ccliente.Aultimo
                Else
                    msglog = "ERROR Grabando cliente: " & txt_codigo.Text & ": '" & ccliente.AMsgError & "'"
                    ultimo = ccliente.Aultimo
                End If
                Clog.registrar(objeto, ultimo, msglog, str_cnn)
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

    Private Sub valida_datos()
        datos_validos = False
        If txt_codigo.Text <> "" Then
            ccliente.buscar(txt_codigo.Text, str_cnn)
            If ccliente.Aexiste = False Then
                datos_validos = True
            Else
                MessageBox.Show("Ya existe codigo de cliente ", "Error al intentar grabar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_codigo.Text = ""
                txt_codigo.Focus()
                datos_validos = False
            End If
            If txt_listado.Text = "" Then
                MessageBox.Show("Debe especifica una lista de precios", "Error al intentar grabar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'txt_codigo.Text = ""
                txt_codigo.Focus()
                datos_validos = False
            End If
        Else
            MessageBox.Show("Debe especifica un codigo de cliente valido", "Error al intentar grabar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_codigo.Text = ""
            txt_codigo.Focus()
            datos_validos = False
        End If
    End Sub

    Private Sub graba_datos()
        ccliente.nuevo(txt_codigo.Text, _
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
        ccliente.modifica(txt_codigo.Text, _
                                       txt_nombre.Text, _
                                       txt_direccion.Text, _
                                       txt_telefono.Text, _
                                       txt_nit.Text, _
                                       txt_correo.Text, _
                                       orden_lista, _
                                       str_cnn _
                                       )
    End Sub

    Private Sub txt_codigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_codigo.LostFocus
        If modo = 1 Then
            ccliente.buscar(Trim(txt_codigo.Text), str_cnn)
            If ccliente.Aexiste = True Then
                MessageBox.Show("Ya existe un cliente con ese codigo", "Verificando codigo de cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_codigo.Text = ""
                txt_codigo.Focus()
            End If
        End If
    End Sub


    Private Sub btn_modifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modifica.Click
        habilita_campos()
        botones_agregar()
        Me.Text = "Modificando Cliente"
        modo = 2
        txt_codigo.Enabled = False
        txt_nombre.Focus()
    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        'llama ventana de busqueda de articulos
        limpia_campos()
        deshabilita_campos()
        botones_inicio()
        datos_validos = True
        codigo = ""
        Dim consulta As New frm_bus_cliente
        consulta.codigo = ""
        consulta.ShowDialog()
        datos_validos = consulta.resultado
        ' si no trae datos datos_validos  = false
        If datos_validos = True Then
            ccliente.buscar(consulta.codigo, str_cnn)
            If ccliente.Aexiste = True Then
                codigo = consulta.codigo
                muestra_datos()
                Me.Text = "Cliente: " & codigo & " " & ccliente.Anombre
                modo = 2 'editable
                botones_editable()
            End If
        End If
    End Sub

    Private Sub muestra_datos()
        txt_orden.Text = ccliente.Aorden
        orden = ccliente.Aorden
        txt_codigo.Text = codigo
        txt_nombre.Text = ccliente.Anombre
        txt_direccion.Text = ccliente.Adireccion
        txt_telefono.Text = ccliente.Atelefono
        txt_nit.Text = ccliente.Anit
        txt_correo.Text = ccliente.Acorreo
        txt_saldo.Text = ccliente.Asaldo
        busca_orden_lista()
        txt_listado.Text = ccliente.Adescripcion
        'busca_movimientos()
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Dim respuesta As Byte
        datos_validos = True
        verifica_eliminacion()
        If datos_validos = True Then
            respuesta = MessageBox.Show("Confirma eliminacion de cliente, no podra recuperarlo", "Eliminacion de cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If respuesta = vbYes Then
                elimina_registro()
                limpia_campos()
                deshabilita_campos()
                botones_inicio()
                MessageBox.Show("Se ELIMINO cliente ", "Eliminacion de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No se elimino cliente ", "Eliminacion de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub verifica_eliminacion()
        ccliente.buscar_cc(txt_codigo.Text, str_cnn)
        If ccliente.Aexiste = True Then
            MessageBox.Show("El cliente ya tiene movimientos no se puede eliminar", "ERROR: Eliminando registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            datos_validos = False
        End If
    End Sub

    Private Sub elimina_registro()
        ccliente.elimina(orden, str_cnn)
    End Sub


    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        inicializa()
    End Sub


    Private Sub busca_orden_lista()
        ccliente.buscar(txt_codigo.Text, str_cnn)
        clista.buscar_orden(ccliente.Alista, str_cnn)
        orden_lista = clista.Aorden
    End Sub


    Private Sub btn_lista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_lista.Click
        orden_lista = 0
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
                clista.buscar(codigo, str_cnn)
                orden_lista = clista.Aorden
                txt_listado.Text = clista.Adescripcion
            End If
        End If
    End Sub


End Class