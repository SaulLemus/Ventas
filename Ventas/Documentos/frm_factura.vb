



Imports System.Data
Imports System.Data.SqlClient

Public Class frm_factura

    Dim cfacturacion As New factura
    Dim ccliente As New Cliente
    Dim clista As New Lista
    Dim carticulo As New articulo
    Dim cvendedor As New vendedor
    Dim cpedido As New pedido
    Dim clog As New log
    Dim objeto As Integer = 32

    Dim msglog As String = ""


    Dim tipodoc As String = "FACCLI"

    Dim modo As Byte = 0

    Dim datos_validos As Boolean = False
    Dim orden_doc As Integer = 0
    Dim gtotal As Decimal = 0.0
    Dim ordenart As Integer
    Dim almacen As Integer
    Dim error_gen As Boolean = False
    Dim importado As Byte = 0

    Dim correlativo As Integer = 0

    Private Sub frm_factura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicializa()
    End Sub

    Private Sub inicializa()
        modo = 0
        importado = 0
        limpia_campos()
        botones_inicio()
        deshabilita_campos()
    End Sub

    Private Sub limpia_campos()
        txt_orden.Text = ""
        txt_numero.Text = ""
        txt_codigo.Text = ""
        txt_nombre.Text = ""
        txt_direccion.Text = ""
        txt_nit.Text = ""
        dtp_documento.Value = Now
        dtp_vence.Value = Now
        rd_tipo_A.Checked = True
        rd_tipo_B.Checked = False
        dtg_movimientos.Rows.Clear()
        txt_obs.Text = ""
        txt_ttsiniva.Text = ""
        txt_iva.Text = ""
        txt_total.Text = ""
    End Sub

    Private Sub botones_inicio()
        modo = 0
        ' botones al iniciar el formulario o despues de grabar, eliminar, buscar, o movimientos
        btn_nuevo.Enabled = True
        btn_grabar.Enabled = False
        btn_cancelar.Enabled = True
        btn_buscar.Enabled = True
    End Sub

    Private Sub botones_agregar()
        Me.Text = "Agregando factura"
        modo = 1
        ' botones al agregar 
        btn_nuevo.Enabled = False
        btn_grabar.Enabled = True
        btn_cancelar.Enabled = True
        btn_buscar.Enabled = True
    End Sub

    Private Sub botones_editable()
        btn_nuevo.Enabled = True
        btn_grabar.Enabled = False
        btn_buscar.Enabled = True
    End Sub

    Private Sub habilita_campos()
        txt_numero.Enabled = False
        txt_codigo.Enabled = True
        txt_nombre.Enabled = True
        txt_nit.Enabled = True
        dtp_documento.Enabled = True
        dtp_vence.Enabled = True
        dtg_movimientos.ReadOnly = True
        txt_obs.Enabled = True
    End Sub

    Private Sub deshabilita_campos()
        txt_numero.Enabled = False
        txt_codigo.Enabled = False
        txt_nombre.Enabled = False
        txt_nit.Enabled = False
        dtp_documento.Enabled = False
        dtp_vence.Enabled = False
        dtg_movimientos.ReadOnly = False
        txt_obs.Enabled = False
        txt_ttsiniva.Enabled = False
        txt_iva.Enabled = False
        txt_total.Enabled = False
    End Sub

    Private Sub busca_correlativo()
        cfacturacion.correlativo_siguiente(tipodoc, str_cnn)
        If cfacturacion.Aerror = False Then
            If cfacturacion.Aexiste Then
                correlativo = cfacturacion.Acorrelativo
                txt_numero.Text = correlativo
                txt_codigo.Focus()
            End If
        Else
            inicializa()
        End If
    End Sub

    Private Sub llena_fila()
        'Dim a As Decimal
        'Dim b As Decimal
        'Dim c As Decimal
        'Dim d As Decimal
        'Dim impuesto As Decimal

        With dtg_movimientos
            carticulo.buscar_almacen1(carticulo.Aorden, str_cnn)
            .CurrentRow.Cells(0).Value = carticulo.Acodigo
            .CurrentRow.Cells(1).Value = carticulo.Adescripcion
            .CurrentRow.Cells(9).Value = 1
            .CurrentRow.Cells(10).Value = carticulo.Aunidades
            If carticulo.Aexiste = True Then
                .CurrentRow.Cells(2).Value = carticulo.Aexistencia
            End If
            .CurrentRow.Cells(3).Value = carticulo.Aprecio_costo
            ccliente.buscar(txt_codigo.Text, str_cnn)
            clista.buscar_orden(ccliente.Alista, str_cnn)
            'If clista.Aexiste Then
            '    a = carticulo.Aprecio_costo
            '    b = clista.Apor
            '    d = (clista.Apor / 100)
            '    c = (carticulo.Aprecio_costo * (clista.Apor / 100))
            '    'impuesto = ((carticulo.Aprecio_costo + (carticulo.Aprecio_costo * (clista.Apor / 100))) * MDL_impuesto) - ((carticulo.Aprecio_costo + (carticulo.Aprecio_costo * (clista.Apor / 100))))
            '    .CurrentRow.Cells(5).Value = (carticulo.Aprecio_costo + (carticulo.Aprecio_costo * (clista.Apor / 100))) * MDL_impuesto
            '    .CurrentRow.Cells(7).Value = impuesto
            'End If
        End With
    End Sub

    Private Sub calcula()
        gtotal = 0
        With dtg_movimientos
            If .RowCount > 0 Then
                Dim a As Integer = 0
                Dim acumulado As Decimal = 0.0
                Dim impuesto As Decimal = 0.0
                For a = 0 To .RowCount - 1
                    acumulado = acumulado + .Rows(a).Cells(6).Value
                    impuesto = impuesto + .Rows(a).Cells(6).Value
                Next
                txt_iva.Text = Format(impuesto, "N2")
                txt_total.Text = Format(acumulado, "N2")
                gtotal = acumulado
            End If
        End With
    End Sub

    Private Sub verifica_grabacion()
        If txt_numero.Text <> 0 Then
            If txt_codigo.Text <> "" Then
                If dtg_movimientos.RowCount > 0 Then
                    calcula()
                    If gtotal > 0 Then
                        datos_validos = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub graba_datos()
        Dim a As Integer = 0
        Dim numero As String = Val(txt_numero.Text)
        Dim codigo As String = txt_codigo.Text
        Dim ordencp As Integer = 0
        Dim nombre As String = txt_nombre.Text
        Dim nit As String = txt_nit.Text
        Dim direccion As String = txt_direccion.Text
        Dim vendedor As Integer = 0
        Dim total As Decimal = Math.Round(gtotal, 2)
        Dim fechadoc As Date = dtp_documento.Value
        Dim fechaven As Date = dtp_vence.Value
        Dim obs As String = txt_obs.Text
        Dim orden_articulo As Integer = 0
        Dim descripcion As String = ""
        Dim costo As Decimal = 0.0
        Dim existencia As Decimal = 0.0
        Dim cantidad As Decimal = 0.0
        Dim impuesto As Decimal = 0.0
        Dim totallinea As Decimal = 0.0
        Dim precio As Decimal = 0.0
        Dim tipofac As String = "A"


        Dim fechastr1 As String = ""
        Dim fechastr2 As String = ""
        Dim fechastr3 As String = ""

        If rd_tipo_A.Checked Then
            tipofac = "A"
        End If
        If rd_tipo_B.Checked Then
            tipofac = "B"
        End If
        If txt_vendedor.Text <> "" Then
            cvendedor.buscar(txt_vendedor.Text, str_cnn)
            If cvendedor.Aexiste = True Then
                vendedor = cvendedor.Aorden
            End If
        End If

        ccliente.buscar(codigo, str_cnn)
        If ccliente.Aexiste = True Then
            ordencp = ccliente.Aorden
        End If

        fechastr1 = fecha_string(dtp_documento.Value)
        fechastr2 = fecha_string(dtp_vence.Value)

        error_gen = False

        cfacturacion.nuevo(numero, _
                          ordencp, _
                          nombre, _
                          direccion, _
                          nit, _
                          ".", _
                          fechastr1, _
                          fechastr2, _
                          vendedor, _
                          0.0, _
                          0.0, _
                          0.0, _
                          0.0, _
                          total, _
                          obs, _
                          tipofac, _
                          str_cnn)
        If cfacturacion.Aerror = False Then
            cfacturacion.buscar_ultima(ordencp, str_cnn)
            cfacturacion.actualiza_correlativo("FACCLI", str_cnn)
            If cfacturacion.Aerror = False And cfacturacion.Aexiste = True Then
                With dtg_movimientos
                    For a = 0 To .RowCount - 1
                        If .Rows(a).Cells(6).Value <> 0.0 Then
                            carticulo.buscar(.Rows(a).Cells(0).Value, str_cnn)
                            orden_articulo = carticulo.Aorden
                            descripcion = .Rows(a).Cells(1).Value
                            costo = .Rows(a).Cells(3).Value
                            existencia = .Rows(a).Cells(2).Value
                            cantidad = .Rows(a).Cells(4).Value
                            precio = .Rows(a).Cells(5).Value
                            impuesto = 0.0
                            almacen = .Rows(a).Cells(9).Value
                            totallinea = .Rows(a).Cells(6).Value
                            cfacturacion.nuevo_detalle(cfacturacion.Aultima, orden_articulo, descripcion, almacen, costo, existencia, cantidad, impuesto, totallinea, precio, str_cnn)
                            ' ** Para esta version Chung Lin la descarga de inventario se hace en el pedido
                            'If cfacturacion.Aerror = False Then
                            '    cfacturacion.actualiza_existencia(orden_articulo, cantidad, almacen, str_cnn)
                            'End If
                        End If
                    Next
                End With
                If importado = 1 Then
                    'orden_doc
                    cpedido.marca_facturado(orden_doc, str_cnn)
                End If
            Else
                error_gen = False
            End If

        Else
            error_gen = True
        End If
    End Sub

    Private Sub muestra_datos()
        Dim vendedor As Integer = 0
        Dim txtestado As String = ""
        cfacturacion.busca(orden_doc, str_cnn)
        If cfacturacion.Aexiste = True Then
            'vendedor = cfacturacion.acodigovnd
            'cvendedor.buscar(vendedor, str_cnn)
            txt_orden.Text = orden_doc
            txt_numero.Text = cfacturacion.Anumerdoc
            If cfacturacion.Aestado = "A" Then
                txtestado = "Activa"
            End If
            If cfacturacion.Aestado = "N" Then
                txtestado = "Anulada"
            End If
            txt_estado.Text = txtestado
            txt_codigo.Text = cfacturacion.acodigo
            txt_nombre.Text = cfacturacion.anombrecp
            txt_nit.Text = cfacturacion.Anit
            txt_direccion.Text = cfacturacion.Adireccion
            txt_obs.Text = cfacturacion.Aobs
            dtp_documento.Value = cfacturacion.afechadoc
            dtp_vence.Value = cfacturacion.Afechaven
            txt_vendedor.Text = cfacturacion.acodigovnd

            busca_integracion()
        End If
    End Sub

    Private Sub busca_integracion()
        Dim myconn As New SqlConnection(str_cnn)
        Dim txt_sql = "select  a.codigo," _
                    & "d.descripcion," _
                    & "d.existencia," _
                    & "d.costo_unitario," _
                    & "d.cantidad," _
                    & "d.precio_venta," _
                    & "d.total_linea " _
                    & " from tbl_cli_factura_det d inner join tbl_articulo a on a.orden = d.orden_articulo " _
                    & " where orden_doc =" & orden_doc
        myconn.Open()
        Dim myCmd As New SqlCommand(txt_sql, myconn)
        Dim myReader As SqlDataReader
        myReader = myCmd.ExecuteReader()
        If myReader.HasRows Then
            dtg_movimientos.Rows.Clear()
            While myReader.Read()
                dtg_movimientos.Rows.Add(myReader.GetValue(0), myReader.GetValue(1), myReader.GetValue(2), myReader.GetValue(3), myReader.GetValue(4), myReader.GetValue(5) _
                                         , myReader.GetValue(6))
            End While
            'comboproveedor.SelectedIndex = -1
        Else
            dtg_movimientos.Rows.Clear()
        End If
        myReader.Close()
        myconn.Close()
    End Sub



    Private Sub btn_nuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        limpia_campos()
        habilita_campos()
        botones_agregar()
        modo = 1
        busca_correlativo()
    End Sub


    Private Sub txt_codigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_codigo.LostFocus
        If modo = 1 Then
            If txt_codigo.Text = "*" Then
                Dim consulta As New frm_bus_cliente
                consulta.codigo = ""
                consulta.resultado = False
                consulta.ShowDialog()
                If consulta.resultado = True Then
                    ccliente.buscar(consulta.codigo, str_cnn)
                    txt_codigo.Text = consulta.codigo
                    txt_nombre.Text = ccliente.Anombre
                    txt_direccion.Text = ccliente.Adireccion
                    txt_nit.Text = ccliente.Anit
                Else
                    txt_codigo.Text = ""
                    txt_nombre.Text = ""
                    txt_direccion.Text = ""
                    txt_nit.Text = 0
                    txt_codigo.Focus()
                End If
            Else
                If txt_codigo.Text <> "" Then
                    ccliente.buscar(txt_codigo.Text, str_cnn)
                    If ccliente.Aexiste = True Then
                        txt_nombre.Text = ccliente.Anombre
                        txt_direccion.Text = ccliente.Adescripcion
                        txt_nit.Text = ccliente.Anit
                        txt_obs.Focus()
                    Else
                        MessageBox.Show("Codigo de cliente no es valido", "Buscando codigo de cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txt_codigo.Focus()
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub dtg_movimientos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtg_movimientos.CellEndEdit
        With dtg_movimientos
            If .CurrentCell.ColumnIndex = 0 Then
                dtg_movimientos.CurrentRow.Cells(9).Value = 1
                If .CurrentCell.Value = "*" Then
                    Dim busca_articulo As New frm_bus_articulo
                    busca_articulo.codigo = ""
                    busca_articulo.ShowDialog()
                    If busca_articulo.codigo <> "" Then
                        ordenart = 0
                        carticulo.buscar(busca_articulo.codigo, str_cnn)
                        If carticulo.Aexiste = True Then
                            ordenart = carticulo.Aorden
                            llena_fila()
                        End If
                    End If
                Else
                    If .CurrentRow.Cells(0).Value <> "" Then
                        carticulo.buscar(.CurrentRow.Cells(0).Value, str_cnn)
                        If carticulo.Aexiste = True Then
                            llena_fila()
                        End If
                    End If
                End If
            End If
            If .CurrentCell.ColumnIndex = 4 Or .CurrentCell.ColumnIndex = 5 Then
                .CurrentRow.Cells(6).Value = Math.Round((.CurrentRow.Cells(4).Value * .CurrentRow.Cells(5).Value), 2)
                If .CurrentRow.Cells(4).Value < .CurrentRow.Cells(10).Value Then
                    Dim msgerr As String = "El minimo de venta debe ser igual o mayor a "
                    msgerr = msgerr & .CurrentRow.Cells(10).Value
                    .CurrentRow.Cells(4).Value = 0
                    MessageBox.Show(msgerr, "Validando cantidad minima de venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                'calcula_total()
                'txt_total.Text = Format(total, "N2")
            End If
            If .CurrentCell.ColumnIndex = 8 Then
                If .CurrentCell.Value = "*" Then
                    busca_existencia_alm()
                    'dtg_movimientos.CurrentCell = dtg_movimientos.Rows(fila).Cells(4)
                End If
            End If
            calcula()
        End With
    End Sub

    Private Sub busca_existencia_alm()
        If modo = 1 Then
            Dim consulta As New frm_bus_almacen
            consulta.codigo = ""
            consulta.resultado = False
            consulta.conexistencia = True
            consulta.ordenart = ordenart
            consulta.existencia = 0
            consulta.ShowDialog()
            If consulta.resultado = True Then
                dtg_movimientos.CurrentRow.Cells(2).Value = consulta.existencia
                dtg_movimientos.CurrentRow.Cells(8).Value = consulta.codigo
                dtg_movimientos.CurrentRow.Cells(9).Value = consulta.ordenalm
            End If
        End If
    End Sub


    Private Sub btn_grabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_grabar.Click
        Dim ultimo As Integer = 0
        datos_validos = False
        verifica_grabacion()
        If datos_validos = True Then
            graba_datos()
            If error_gen = False Then
                ' Registro de log
                If cpedido.Aerror = False Then
                    ' enviar numero de orden del cliente
                    'ccliente.buscar(ccliente.Aorden, str_cnn)
                    cfacturacion.buscar_ultima(ccliente.Aorden, str_cnn)
                    ultimo = cfacturacion.Aultima
                    msglog = "Grabado factura: " & Val(txt_numero.Text) & " cli: " & txt_codigo.Text
                Else
                    msglog = "ERROR Grabando factura: " & Val(txt_numero.Text) & ", " & txt_codigo.Text & ": '" & ccliente.AMsgError & "'"
                End If
                clog.registrar(objeto, ultimo, msglog, str_cnn)
                ' Registro de log
                MessageBox.Show("Asegure que la impresora tenga papel correcto y que este lista", "Impimir factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
                imprimir_factura()
            End If
            inicializa()
        End If
    End Sub


    Private Sub txt_vendedor_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_vendedor.LostFocus
        If modo = 1 Then
            If txt_vendedor.Text = "*" Then
                Dim consulta As New frm_bus_vendedor
                consulta.codigo = ""
                consulta.resultado = False
                consulta.ShowDialog()
                If consulta.resultado = True Then
                    ccliente.buscar(consulta.codigo, str_cnn)
                    txt_vendedor.Text = consulta.codigo
                Else
                    txt_vendedor.Text = ""
                    txt_vendedor.Focus()
                End If
            Else
                If txt_vendedor.Text <> "" Then
                    cvendedor.buscar(txt_vendedor.Text, str_cnn)
                    If cvendedor.Aexiste = True Then
                        txt_vendedor.Text = cvendedor.Acodigo
                        txt_obs.Focus()
                    Else
                        MessageBox.Show("Codigo de cliente no es valido", "Buscando codigo de cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txt_codigo.Focus()
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub btn_buscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        Dim consulta As New frm_bus_factura
        consulta.orden = 0
        consulta.ShowDialog()
        If consulta.orden > 0 Then
            orden_doc = consulta.orden
            muestra_datos()
        End If
    End Sub


    Private Sub btn_importar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_importar.Click
        ' Importacion de pedido completado
        importado = 1 'fue importado, si se llega a facturar que actualice el estado del pedido a importado = 1 Si para que no se pueda importar de nuevo
        botones_agregar()
        Dim consulta As New frm_bus_pedidocli
        consulta.orden = 0
        consulta.factura = False 'lo habilite para que salga la opcion de todos en busqueda
        consulta.ShowDialog()
        If consulta.orden > 0 Then
            orden_doc = consulta.orden
            muestra_datos_pedido()
        End If
    End Sub

    Private Sub muestra_datos_pedido()
        Dim vendedor As Integer = 0
        Dim estadochr As String = ""
        cpedido.busca(orden_doc, str_cnn)
        If cpedido.Aexiste = True Then
            ' no son validos los ya facturados o los anulados
            Dim e As String = cpedido.Aestado
            If cpedido.Afacturado = 0 And cpedido.Aestado <> "N" Then
                'vendedor = cpedido.acodigovnd
                'cvendedor.buscar(vendedor, str_cnn)
                'txt_orden.Text = orden_doc
                busca_correlativo()
                'txt_numero.Text = cfacturacion.Anumerdoc
                txt_codigo.Text = cpedido.acodigo
                txt_nombre.Text = cpedido.anombrecp
                txt_nit.Text = cpedido.Anit
                txt_direccion.Text = cpedido.Adireccion
                txt_obs.Text = cpedido.Aobs
                dtp_documento.Value = Now
                dtp_vence.Value = cpedido.Afechaven
                txt_vendedor.Text = cpedido.acodigovnd
                If cpedido.Aestado = "A" Then
                    estadochr = "Activo"
                Else
                    If cpedido.Aestado = "N" Then
                        estadochr = "Anulado"
                    Else
                        If cpedido.Aestado = "C" Then
                            estadochr = "Cerrado" 'Cuando ya es despachado
                        End If
                    End If
                End If
                'txt_estado.Text = estadochr
                busca_integracion_pedido()
            Else
                If cpedido.Afacturado = 1 Then
                    MessageBox.Show("Pedido ya fue utilizado con otra factura no puede reutilizarse", "Importando pedido", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                If cpedido.Aestado = "N" Then
                    MessageBox.Show("Pedido ya fue ANULADO no puede utilizarse", "Importando pedido", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                inicializa()
            End If
        End If
    End Sub

    Private Sub busca_integracion_pedido()
        Dim myconn As New SqlConnection(str_cnn)

        Dim txt_sql = "select a.codigo," _
                    & "d.descripcion," _
                    & "d.existencia," _
                    & "d.costo_unitario," _
                    & "d.cantidad," _
                    & "d.precio_venta," _
                    & "d.total_linea, " _
                    & "d.impuesto, " _
                    & "c.codigo, " _
                    & "d.orden_almacen " _
                    & " from tbl_cli_pedido_det d inner join tbl_articulo a on a.orden = d.orden_articulo " _
                    & "                           inner join tbl_almacen c on c.orden = d.orden_almacen " _
                    & " where orden_doc =" & orden_doc
        myconn.Open()
        Dim myCmd As New SqlCommand(txt_sql, myconn)
        Dim myReader As SqlDataReader
        myReader = myCmd.ExecuteReader()
        If myReader.HasRows Then
            If cpedido.Aestado = "A" Or cpedido.Aestado = "C" Then
                'btn_anular.Enabled = True
                modo = 3
            End If
            dtg_movimientos.Rows.Clear()
            While myReader.Read()
                dtg_movimientos.Rows.Add(myReader.GetValue(0), myReader.GetValue(1), myReader.GetValue(2), myReader.GetValue(3), myReader.GetValue(4), myReader.GetValue(5), _
                                          myReader.GetValue(6), myReader.GetValue(7), myReader.GetValue(8), myReader.GetValue(9))
            End While
            'comboproveedor.SelectedIndex = -1
        Else
            dtg_movimientos.Rows.Clear()
        End If
        myReader.Close()
        myconn.Close()
    End Sub


    Private Sub imprimir_factura()
        Dim reporte As New frm_rpt_factura
        If modo = 2 Then
            reporte.orden = Val(txt_orden.Text)
        Else
            cfacturacion.buscar_ultima(ccliente.Aorden, str_cnn)
            reporte.orden = cfacturacion.Aultima
        End If
        reporte.formula = "{tbl_cli_factura.orden} = " & reporte.orden
        reporte.Show()
    End Sub



    Private Sub btn_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.Click
        modo = 2
        imprimir_factura()
    End Sub


    'Private Sub btn_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.Click
    '    imprimir_factura()
    'End Sub



    Private Sub btn_anular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_anular.Click
        Dim ultimo As Integer = 0
        modo = 3
        If modo = 3 Then 'Anular
            If txt_estado.Text <> "Anulado" And txt_estado.Text <> "Cerrado" Then
                MessageBox.Show("Desea anular el factura ", "Anulacion de factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If vbYes Then
                    anula_factura()
                    '
                    If cpedido.Aerror = False Then
                        msglog = "Anulando factura: " & txt_numero.Text & " cliente: " & txt_codigo.Text
                    Else
                        msglog = "ERROR Anulando factura: " & txt_numero.Text & " cliente : " & txt_codigo.Text
                    End If
                    ultimo = Val(txt_orden.Text)
                    clog.registrar(objeto, ultimo, msglog, str_cnn)
                    '
                    inicializa()
                End If
            Else
                If txt_estado.Text = "Anulado" Then
                    MessageBox.Show("Esta factura ya fue anulada", "Anulando factura", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                inicializa()
            End If
        End If
    End Sub


    Private Sub anula_factura()
        Dim a As Integer = 0
        Dim codigo As String = txt_codigo.Text
        Dim orden_articulo As Integer = 0
        Dim orden_factura As Integer = Val(txt_orden.Text)
        Dim cantidad As Integer = 0

        cfacturacion.anula(orden_factura, str_cnn)
        'If cfacturacion.Aerror = False Then
        '    imprimir_factura()
        'End If
    End Sub


End Class