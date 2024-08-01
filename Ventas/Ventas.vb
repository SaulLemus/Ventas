Public Class Ventas
    Dim clogin As New usuario
    Dim cusuario As New usuario


    Private Sub Ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim login As New frm_login
        Dim intento As Byte = 0
        Dim titulo As String = ""
        MenuStrip1.Visible = False
        For intento = 1 To 3
            login.txt_usuario.Text = ""
            login.txt_clave.Text = ""
            login.ShowDialog()
            If login.acceso = True Then
                datos_sesion(titulo)
                txt_usrgen.Text = login.txt_usuario.Text
                cusuario.buscar(login.txt_usuario.Text, str_cnn)
                txt_perfil.Text = cusuario.Aperfil
                intento = 3
                MenuStrip1.Visible = True
                Me.Text = titulo
                carga_perfil()
            End If
        Next
        If login.acceso = False Then
            salida()
        End If
    End Sub


    Private Sub carga_perfil()
        If txt_perfil.Text = "Ventas" Then
            perfil_Ventas()
        Else
            If txt_perfil.Text = "Bodega" Then
                perfil_bodega()
            Else
                If txt_perfil.Text = "Facturador" Then
                    perfil_facturador()
                Else
                    If txt_perfil.Text = "Produccion" Then
                        perfil_produccion()
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub perfil_Ventas()
        GenUsuario.Visible = False
        GenProveedores.Visible = False
        GenArticulos.Visible = False
        GenListaPrecios.Visible = False
        GenAlmacenes.Visible = False
        GenVendedores.Visible = False
        VtasFacturasDeClientes.Visible = False
        VtasDevolucionDeClientes.Visible = False
        MNUCompras.Visible = False
        MNUInventario.Visible = True
        Tls_Traslado.Visible = False
        ConsultaDeExistenciasToolStripMenuItem.Visible = True
        IngresoDeMercaderiaToolStripMenuItem.Visible = False
        SalidasDeMercaderiaToolStripMenuItem.Visible = False
        MNUDespacho.Visible = False
        MNUConsultas.Visible = False
    End Sub


    Private Sub perfil_bodega()
        MNUGenerales.Visible = False
        GenUsuario.Visible = False
        GenProveedores.Visible = False
        GenArticulos.Visible = False
        GenListaPrecios.Visible = False
        GenAlmacenes.Visible = False
        GenVendedores.Visible = False
        MNUVentas.Visible = False
        VtasFacturasDeClientes.Visible = False
        VtasDevolucionDeClientes.Visible = False
        MNUCompras.Visible = True
        PedidoAProveedorToolStripMenuItem.Visible = False
        IngresoProveedorToolStripMenuItem.Visible = True
        FacturasToolStripMenuItem.Visible = False
        MNUInventario.Visible = False
        MNUDespacho.Visible = True
        MNUConsultas.Visible = False
    End Sub

    Private Sub perfil_facturador()
        MNUGenerales.Visible = True
        GenUsuario.Visible = False
        GenProveedores.Visible = False
        GenArticulos.Visible = True
        GenListaPrecios.Visible = False
        GenAlmacenes.Visible = False
        GenVendedores.Visible = False
        MNUCompras.Visible = False
        MNUInventario.Visible = True
        Tls_Traslado.Visible = False
        ConsultaDeExistenciasToolStripMenuItem.Visible = True
        IngresoDeMercaderiaToolStripMenuItem.Visible = False
        SalidasDeMercaderiaToolStripMenuItem.Visible = False
        MNUDespacho.Visible = True
        MNUConsultas.Visible = False
    End Sub

    Private Sub perfil_produccion()
        MNUGenerales.Visible = True
        GenUsuario.Visible = False
        GenClientes.Visible = False
        GenProveedores.Visible = False
        GenArticulos.Visible = True
        GenListaPrecios.Visible = False
        GenAlmacenes.Visible = False
        GenVendedores.Visible = False
        MNUVentas.Visible = False
        VtasFacturasDeClientes.Visible = False
        VtasDevolucionDeClientes.Visible = False
        MNUCompras.Visible = True
        PedidoAProveedorToolStripMenuItem.Visible = False
        IngresoProveedorToolStripMenuItem.Visible = True
        FacturasToolStripMenuItem.Visible = False
        MNUInventario.Visible = True
        MNUDespacho.Visible = True
        MNUConsultas.Visible = False
    End Sub

    Private Function datos_sesion(ByRef stridgen As String)
        identificar(stridgen)
        Return ""
    End Function


    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ventana As New frm_cliente
        ventana.MdiParent = Me
        ventana.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_listaprecio.Show()
    End Sub

    Private Sub ArticulosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_articulo.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_proveedor.Show()
    End Sub

    Private Sub AlmacenesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_almacen.Show()
    End Sub

    Private Sub VendedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_vendedor.Show()
    End Sub

    Private Sub CotizacionAClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim documento As New frm_cotcli
        documento.MdiParent = Me
        documento.Show()
    End Sub

    Private Sub PedidoDeClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim documento As New frm_pedido
        documento.MdiParent = Me
        documento.Show()
    End Sub

    Private Sub FacturasDeClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim documento As New frm_factura
        documento.MdiParent = Me
        documento.Show()
    End Sub

    Private Sub DevolucionDeClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim documento As New frm_devcli
        documento.MdiParent = Me
        documento.Show()
    End Sub

    Private Sub PedidoAProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim documento As New frm_pedidoprv
        documento.MdiParent = Me
        documento.Show()
    End Sub

    Private Sub IngresoProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim documento As New frm_ingprv
        documento.MdiParent = Me
        documento.Show()
    End Sub

    Private Sub FacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim documento As New frm_facprv
        documento.MdiParent = Me
        documento.Show()
    End Sub

    Private Sub ConsultaDeExistenciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim documento As New frm_cons_existencia
        documento.MdiParent = Me
        documento.Show()
    End Sub


    Private Sub Tls_Traslado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim documento As New frm_traslado
        documento.MdiParent = Me
        documento.Show()
    End Sub

    Private Sub IngresoDeMercaderiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim documento As New frm_ingresoalm
        documento.MdiParent = Me
        documento.Show()
    End Sub

    Private Sub SalidasDeMercaderiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim documento As New frm_salidaalm
        documento.MdiParent = Me
        documento.Show()
    End Sub

    Private Sub DespachoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim documento As New frm_bod_pedido ' Despacho delpedido, recoleccion y cierre
        documento.MdiParent = Me
        documento.Show()
    End Sub


    Private Sub UsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim documento As New frm_usuario ' usuarios
        documento.MdiParent = Me
        documento.Show()
    End Sub

    Private Sub salida()
        Me.Close()
    End Sub

    Private Sub MNUDespacho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNUDespacho.Click
        'Dim documento As New frm_bod_pedido ' Despacho delpedido, recoleccion y cierre
        'documento.MdiParent = Me
        'documento.Show()
        frm_bod_pedido.Show()
    End Sub


    Private Sub GenUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenUsuario.Click
        Dim documento As New frm_usuario ' usuarios
        documento.MdiParent = Me
        documento.Show()
    End Sub

    Private Sub GenClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenClientes.Click
        Dim ventana As New frm_cliente
        ventana.MdiParent = Me
        ventana.Show()
    End Sub

    Private Sub GenProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenProveedores.Click
        frm_proveedor.Show()
    End Sub

    Private Sub GenArticulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenArticulos.Click
        frm_articulo.Show()
    End Sub

    Private Sub GenListaPrecios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenListaPrecios.Click
        frm_listaprecio.Show()
    End Sub

    Private Sub GenAlmacenes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenAlmacenes.Click
        frm_almacen.Show()
    End Sub

    Private Sub GenVendedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenVendedores.Click
        frm_vendedor.Show()
    End Sub

    Private Sub CotizacionAClienteToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CotizacionAClienteToolStripMenuItem.Click
        'Dim documento As New frm_cotcli
        'documento.MdiParent = Me
        'documento.Show()
        frm_cotcli.Show()
    End Sub

    Private Sub PedidoDeClienteToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PedidoDeClienteToolStripMenuItem.Click
        'Dim documento As New frm_pedido
        'documento.MdiParent = Me
        'documento.Show()
        frm_pedido.Show()
    End Sub

    Private Sub VtasFacturasDeClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VtasFacturasDeClientes.Click
        'Dim documento As New frm_factura
        'documento.MdiParent = Me
        'documento.Show()
        'frm_login.ActiveForm.Activate()
        frm_factura.Show()
    End Sub

    Private Sub VtasDevolucionDeClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VtasDevolucionDeClientes.Click
        'Dim documento As New frm_devcli
        'documento.MdiParent = Me
        'documento.Show()
        frm_devcli.Show()
    End Sub

    Private Sub PedidoAProveedorToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PedidoAProveedorToolStripMenuItem.Click
        Dim documento As New frm_pedidoprv
        documento.MdiParent = Me
        documento.Show()
    End Sub

    Private Sub IngresoProveedorToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresoProveedorToolStripMenuItem.Click
        Dim documento As New frm_ingprv
        'documento.MdiParent = Me
        'documento.Show()
        frm_ingprv.Show()
    End Sub

    Private Sub FacturasToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturasToolStripMenuItem.Click
        'Dim documento As New frm_facprv
        'documento.MdiParent = Me
        'documento.Show()
        frm_facprv.Show()
    End Sub

    Private Sub Tls_Traslado_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tls_Traslado.Click
        Dim documento As New frm_traslado
        documento.MdiParent = Me
        documento.Show()
    End Sub

    Private Sub ConsultaDeExistenciasToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeExistenciasToolStripMenuItem.Click
        Dim documento As New frm_cons_existencia
        documento.MdiParent = Me
        documento.Show()
    End Sub

    Private Sub IngresoDeMercaderiaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresoDeMercaderiaToolStripMenuItem.Click
        Dim documento As New frm_ingresoalm
        documento.MdiParent = Me
        documento.Show()
    End Sub

    Private Sub SalidasDeMercaderiaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalidasDeMercaderiaToolStripMenuItem.Click
        Dim documento As New frm_salidaalm
        documento.MdiParent = Me
        documento.Show()
    End Sub

    Private Sub VentasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasToolStripMenuItem1.Click
        frm_cons_ventas_vnd.ShowDialog()
    End Sub

    Private Sub SalidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalidaToolStripMenuItem.Click
        salida()
    End Sub

    Private Sub VentasPorClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasPorClienteToolStripMenuItem.Click
        frm_cons_ventas_cli.ShowDialog()
    End Sub

    Private Sub VentasPorArticuloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasPorArticuloToolStripMenuItem.Click
        frm_cons_ventas_art.ShowDialog()
    End Sub

    Private Sub KardexToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KardexToolStripMenuItem.Click
        frm_cons_kardex.ShowDialog()
    End Sub

    Private Sub VentasGeneralesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasGeneralesToolStripMenuItem.Click
        frm_cons_ventas_gen.ShowDialog()
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprasToolStripMenuItem.Click
        frm_cons_compras_prv.ShowDialog()
    End Sub

    Private Sub IngresosManualesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresosManualesToolStripMenuItem.Click
        frm_con_ingman.ShowDialog()
    End Sub

    Private Sub SalidasManualesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalidasManualesToolStripMenuItem.Click
        frm_con_salman.ShowDialog()
    End Sub

    Private Sub RegistroOperacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroOperacionesToolStripMenuItem.Click
        frm_ConsultaOP.ShowDialog()
    End Sub
End Class

