

Imports System.Data
Imports System.Data.SqlClient


Public Class frm_ingresoalm

    Dim calmacen As New almacen
    Dim carticulo As New articulo
    Dim ctraslado As New traslado

    Dim modo As Byte = 0  '0 estado inicial, '1 agregando,  2 modificando  3 consultando  4 eliminando
    Dim datos_validos As Boolean = False

    Dim orden As Integer = 0 ' Orden del registro de traslado
    Dim ordenart As Integer = 0
    Dim ordenalmacen As String = 0
    Dim codalmacen As String = ""
    Dim existencia As Integer = 0
    Dim existenciaorig As Integer = 0
    Dim procesa As Boolean = False
    Dim ordalmorig As Integer = 0
    Dim ordalmdest As Integer = 0

    Dim clog As New log
    Dim objeto As Integer = 51

    Dim msglog As String = ""

    Private Sub frm_ingresoalm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicializa()
    End Sub

    Private Sub inicializa()
        modo = 0
        limpia_campos()
        botones_inicio()
        deshabilita_campos()
    End Sub

    Private Sub limpia_campos()
        Me.Text = "ingreso de almacen"
        txt_orden.Text = ""
        txt_codigo.Text = ""
        txt_descripcion.Text = ""
        txt_almdes.Text = ""
        txt_nomdest.Text = ""
        txt_cantidad.Text = ""
        txt_exidest.Text = ""
        dtp_fecha.Value = Now
    End Sub

    Private Sub botones_inicio()
        modo = 0
        ' botones al iniciar el formulario o despues de grabar, eliminar, buscar, o movimientos
        btn_nuevo.Enabled = True
        btn_grabar.Enabled = False
        btn_cancelar.Enabled = False
        'btn_buscar.Enabled = True
    End Sub

    Private Sub botones_agregar()
        Me.Text = "Agregando ingreso de almacen"
        modo = 1
        ' botones al agregar 
        btn_nuevo.Enabled = False
        btn_grabar.Enabled = True
        btn_cancelar.Enabled = True
        'btn_buscar.Enabled = True
    End Sub

    Private Sub botones_editable()
        btn_nuevo.Enabled = True
        btn_grabar.Enabled = False
        'btn_buscar.Enabled = True
    End Sub

    Private Sub habilita_campos()
        txt_codigo.Enabled = True
        txt_descripcion.Enabled = True
        txt_almdes.Enabled = True
        txt_nomdest.Enabled = False
        txt_cantidad.Enabled = True
    End Sub

    Private Sub deshabilita_campos()
        txt_codigo.Enabled = False
        txt_descripcion.Enabled = False
        txt_almdes.Enabled = False
        txt_nomdest.Enabled = False
        txt_cantidad.Enabled = False
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


    Private Sub muestra_datos()
        txt_orden.Text = calmacen.Aorden
        orden = calmacen.Aorden
        'txt_codigo.Text = codigo
        txt_descripcion.Text = calmacen.Adescripcion
        'busca_movimientos()
    End Sub

    Private Sub verifica_datos()
        datos_validos = True
        If txt_codigo.Text <> "" Then
            If txt_almdes.Text <> "" Then
                If txt_cantidad.Text <> "" Then
                    datos_validos = True
                Else
                    MessageBox.Show("Cantidad a ingresar no es valida", "Verificando cantidad", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Almacen destino no es valido", "Verificando almacen destino", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Codigo de articulo invalido", "Verificando codigo de articulo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If datos_validos = True Then
            graba_datos()
            inicializa()
        End If
    End Sub

    Private Sub graba_datos()
        If modo = 1 Then
            MessageBox.Show("Confirma grabacion de ingreso de mercaderia", "Grabando ingreso de mercaderia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If vbYes Then
                ctraslado.agrega_ingreso(ordenart, ordalmdest, Val(txt_cantidad.Text), str_cnn)
                If ctraslado.Aerror = False Then
                    ' suma existencia al destino
                    ctraslado.act_existencia(ordenart, ordalmdest, Val(txt_cantidad.Text), True, str_cnn)
                    ctraslado.buscar_ultimo_ingman(ordenart, ordalmdest, str_cnn)
                    msglog = "Grabado ingreso manual: " & ctraslado.Aultimo & " articulo: " & txt_codigo.Text & " Almacen destino: " & txt_almdes.Text
                    clog.registrar(objeto, ctraslado.Aultimo, msglog, str_cnn)
                End If
            End If
        End If
    End Sub


    Private Sub busca_almacen()
        Dim consulta As New frm_bus_almacen
        consulta.codigo = ""
        consulta.resultado = False
        consulta.conexistencia = True
        consulta.ordenart = ordenart
        consulta.existencia = 0
        consulta.ShowDialog()
        If consulta.resultado = True Then
            procesa = True
            existencia = consulta.existencia
            codalmacen = consulta.codigo
            ordenalmacen = consulta.ordenalm
        End If
    End Sub


    Private Sub btn_grabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_grabar.Click
        verifica_datos()
    End Sub


    Private Sub btn_cancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        inicializa()
    End Sub


    Private Sub txt_codigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_codigo.LostFocus
        If modo = 1 Then
            If txt_codigo.Text = "*" Then
                Dim busca_articulo As New frm_bus_articulo
                busca_articulo.codigo = ""
                busca_articulo.ShowDialog()
                If busca_articulo.codigo <> "" Then
                    ordenart = 0
                    carticulo.buscar(busca_articulo.codigo, str_cnn)
                    If carticulo.Aexiste = True Then
                        ordenart = carticulo.Aorden
                        txt_codigo.Text = carticulo.Acodigo
                        txt_descripcion.Text = carticulo.Adescripcion
                    End If
                End If
            Else
                If txt_codigo.Text <> "" Then
                    ordenart = 0
                    carticulo.buscar(txt_codigo.Text, str_cnn)
                    If carticulo.Aexiste = True Then
                        ordenart = carticulo.Aorden
                        txt_codigo.Text = carticulo.Acodigo
                        txt_descripcion.Text = carticulo.Adescripcion
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub txt_almdes_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_almdes.LostFocus
        If modo = 1 Then
            If txt_almdes.Text = "*" Then
                busca_almacen()
                If procesa = True Then
                    calmacen.buscar(codalmacen, str_cnn)
                    If calmacen.Aexiste = True Then
                        ordalmdest = calmacen.Aorden
                        txt_almdes.Text = codalmacen
                        txt_nomdest.Text = calmacen.Adescripcion
                        carticulo.buscar_existencia(ordenart, ordenalmacen, str_cnn)
                        If carticulo.Aexiste = True Then
                            txt_exidest.Text = carticulo.Aexistencia
                        End If
                        txt_cantidad.Focus()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txt_cantidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_cantidad.LostFocus
        If txt_cantidad.Text <> "" Then
            If Val(txt_cantidad.Text) = 0 Then
                MessageBox.Show("No puede ingresar 0 unidades", "Indicando cantidad a ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_cantidad.Text = ""
                txt_cantidad.Focus()
            End If
        End If
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        ' nuevo registro
        modo = 1
        limpia_campos()
        habilita_campos()
        botones_agregar()
        txt_codigo.Focus()
    End Sub


End Class