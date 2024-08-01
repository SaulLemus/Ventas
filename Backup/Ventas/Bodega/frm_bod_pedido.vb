

Imports System.Data
Imports System.Data.SqlClient

Public Class frm_bod_pedido

    Dim cpedido As New pedido
    Dim ccliente As New Cliente
    Dim clista As New Lista
    Dim carticulo As New articulo
    Dim cvendedor As New vendedor

    Dim tipodoc As String = "PEDCLI"

    Dim modo As Byte = 0 '1,nuevo   3,Anular

    Dim datos_validos As Boolean = False
    Dim orden_doc As Integer = 0
    Dim gtotal As Decimal = 0.0
    Dim almacen As Integer

    Dim correlativo As Integer = 0

    Private Sub frm_bod_pedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicializa()
    End Sub

    Private Sub inicializa()
        modo = 0
        limpia_campos()
        botones_inicio()
        deshabilita_campos()
    End Sub

    Private Sub limpia_campos()
        txt_orden.Text = ""
        txt_numero.Text = ""
        txt_codigo.Text = ""
        txt_direccion.Text = ""
        txt_nombre.Text = ""
        txt_nit.Text = ""
        dtp_documento.Value = Now
        dtp_vence.Value = Now
        dtg_movimientos.Rows.Clear()
        txt_obs.Text = ""
        txt_ttsiniva.Text = ""
        txt_iva.Text = ""
        txt_total.Text = ""
        txt_estado.Text = ""
    End Sub

    Private Sub botones_inicio()
        modo = 0
        ' botones al iniciar el formulario o despues de grabar, eliminar, buscar, o movimientos
        btn_nuevo.Enabled = True
        btn_grabar.Enabled = False
        btn_cancelar.Enabled = True
        btn_buscar.Enabled = True
        btn_anular.Enabled = False
    End Sub

    Private Sub botones_agregar()
        modo = 1
        ' botones al agregar 
        btn_nuevo.Enabled = False
        btn_grabar.Enabled = True
        btn_cancelar.Enabled = True
        btn_buscar.Enabled = True
        btn_anular.Enabled = False
    End Sub

    Private Sub botones_editable()
        btn_nuevo.Enabled = True
        btn_grabar.Enabled = False
        btn_buscar.Enabled = True
        btn_anular.Enabled = False
    End Sub

    Private Sub habilita_campos()
        txt_numero.Enabled = False
        txt_codigo.Enabled = True
        txt_nombre.Enabled = True
        txt_nit.Enabled = True
        txt_direccion.Enabled = True
        dtp_documento.Enabled = True
        dtp_vence.Enabled = True
        dtg_movimientos.ReadOnly = False
        txt_obs.Enabled = True
    End Sub

    Private Sub deshabilita_campos()
        txt_numero.Enabled = False
        txt_codigo.Enabled = False
        txt_nombre.Enabled = False
        txt_nit.Enabled = False
        txt_direccion.Enabled = False
        dtp_documento.Enabled = False
        dtp_vence.Enabled = False
        dtg_movimientos.ReadOnly = True
        txt_obs.Enabled = False
        txt_ttsiniva.Enabled = False
        txt_iva.Enabled = False
        txt_total.Enabled = False
    End Sub

    Private Sub busca_correlativo()
        cpedido.correlativo_siguiente(tipodoc, str_cnn)
        If cpedido.Aerror = False Then
            If cpedido.Aexiste Then
                correlativo = cpedido.Acorrelativo
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
        Dim orden_pedido As Integer = 0


        Dim fechastr1 As String = ""
        Dim fechastr2 As String = ""
        Dim fechastr3 As String = ""

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

        orden_pedido = Val(txt_orden.Text)
        If orden_pedido <> 0 Then
            cpedido.cierra(orden_pedido, str_cnn)
        End If
    End Sub

    Private Sub muestra_datos()
        Dim vendedor As Integer = 0
        Dim estadochr As String = ""
        Dim despachable As Boolean = True
        cpedido.busca(orden_doc, str_cnn)
        If cpedido.Aexiste = True Then
            'vendedor = cpedido.acodigovnd
            'cvendedor.buscar(vendedor, str_cnn)
            txt_orden.Text = orden_doc
            txt_numero.Text = cpedido.Anumerdoc
            txt_codigo.Text = cpedido.acodigo
            txt_nombre.Text = cpedido.anombrecp
            txt_nit.Text = cpedido.Anit
            txt_direccion.Text = cpedido.Adireccion
            txt_obs.Text = cpedido.Aobs
            dtp_documento.Value = cpedido.afechadoc
            dtp_vence.Value = cpedido.Afechaven
            txt_vendedor.Text = cpedido.acodigovnd
            If cpedido.Aestado = "A" Then
                estadochr = "Activo"
            Else
                despachable = False
            End If
            txt_estado.Text = estadochr
            If despachable = True Then
                botones_agregar()
                configura_grid()
                busca_integracion()
            Else
                MessageBox.Show("El pedido no puede ser procesado por bodega por no estar en estado Activo", "Pedido para despacho", MessageBoxButtons.OK, MessageBoxIcon.Information)
                inicializa()
            End If
        End If
    End Sub

    Private Sub configura_grid()
        dtg_movimientos.ReadOnly = False
        dtg_movimientos.Columns(0).ReadOnly = True
        dtg_movimientos.Columns(1).ReadOnly = True
        dtg_movimientos.Columns(2).ReadOnly = True
        dtg_movimientos.Columns(3).ReadOnly = True
        dtg_movimientos.Columns(4).ReadOnly = True
        dtg_movimientos.Columns(5).ReadOnly = True
        dtg_movimientos.Columns(6).ReadOnly = True
        dtg_movimientos.Columns(7).ReadOnly = True
        dtg_movimientos.Columns(8).ReadOnly = True
        dtg_movimientos.Columns(9).ReadOnly = True
        dtg_movimientos.Columns(10).ReadOnly = True
        dtg_movimientos.Columns(11).ReadOnly = False
    End Sub

    Private Sub busca_integracion()
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
            'dtg_movimientos.Rows.Clear()
            While myReader.Read()
                dtg_movimientos.Rows.Add(myReader.GetValue(0), myReader.GetValue(1), myReader.GetValue(2), myReader.GetValue(3), myReader.GetValue(4), myReader.GetValue(5) _
                                         , myReader.GetValue(6), myReader.GetValue(7), myReader.GetValue(8), myReader.GetValue(9), 1, myReader.GetValue(4))

            End While
            'comboproveedor.SelectedIndex = -1
        Else
            dtg_movimientos.Rows.Clear()
        End If
        myReader.Close()
        myconn.Close()
    End Sub


    Private Sub dtg_movimientos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtg_movimientos.CellEndEdit
        With dtg_movimientos
            If .CurrentCell.ColumnIndex = 0 Then
                If .CurrentCell.Value = "*" Then
                    Dim busca_articulo As New frm_bus_articulo
                    busca_articulo.codigo = ""
                    busca_articulo.ShowDialog()
                    If busca_articulo.codigo <> "" Then
                        carticulo.buscar(busca_articulo.codigo, str_cnn)
                        If carticulo.Aexiste = True Then
                            llena_fila()
                        End If
                    End If
                End If
            End If
            If .CurrentCell.ColumnIndex = 4 Or .CurrentCell.ColumnIndex = 5 Then
                .CurrentRow.Cells(6).Value = Math.Round((.CurrentRow.Cells(4).Value * .CurrentRow.Cells(5).Value), 2)
                'calcula_total()
                'txt_total.Text = Format(total, "N2")
            End If
            calcula()
        End With
    End Sub


    Private Sub btn_grabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_grabar.Click
        datos_validos = False
        verifica_grabacion()
        If datos_validos = True Then
            graba_datos()
            inicializa()
        End If
    End Sub


    Private Sub btn_buscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        inicializa()
        Dim consulta As New frm_bus_pedidocli
        consulta.orden = 0
        consulta.factura = False
        consulta.ShowDialog()
        If consulta.orden > 0 Then
            orden_doc = consulta.orden
            muestra_datos()
            modo = 1 ' Modo para poder cerrar el pedido
        End If
    End Sub


End Class