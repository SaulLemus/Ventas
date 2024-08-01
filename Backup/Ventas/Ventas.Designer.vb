<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_perfil = New System.Windows.Forms.TextBox
        Me.txt_usrgen = New System.Windows.Forms.TextBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MNUGenerales = New System.Windows.Forms.ToolStripMenuItem
        Me.GenUsuario = New System.Windows.Forms.ToolStripMenuItem
        Me.GenClientes = New System.Windows.Forms.ToolStripMenuItem
        Me.GenProveedores = New System.Windows.Forms.ToolStripMenuItem
        Me.GenArticulos = New System.Windows.Forms.ToolStripMenuItem
        Me.GenListaPrecios = New System.Windows.Forms.ToolStripMenuItem
        Me.GenAlmacenes = New System.Windows.Forms.ToolStripMenuItem
        Me.GenVendedores = New System.Windows.Forms.ToolStripMenuItem
        Me.MNUVentas = New System.Windows.Forms.ToolStripMenuItem
        Me.CotizacionAClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PedidoDeClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VtasFacturasDeClientes = New System.Windows.Forms.ToolStripMenuItem
        Me.VtasDevolucionDeClientes = New System.Windows.Forms.ToolStripMenuItem
        Me.MNUCompras = New System.Windows.Forms.ToolStripMenuItem
        Me.PedidoAProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IngresoProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MNUInventario = New System.Windows.Forms.ToolStripMenuItem
        Me.Tls_Traslado = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultaDeExistenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IngresoDeMercaderiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalidasDeMercaderiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MNUDespacho = New System.Windows.Forms.ToolStripMenuItem
        Me.MNUConsultas = New System.Windows.Forms.ToolStripMenuItem
        Me.VentasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.VentasPorClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VentasPorArticuloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KardexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VentasGeneralesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IngresosManualesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalidasManualesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegistroOperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListadoDePedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_perfil
        '
        Me.txt_perfil.Enabled = False
        Me.txt_perfil.Location = New System.Drawing.Point(33, 69)
        Me.txt_perfil.Name = "txt_perfil"
        Me.txt_perfil.Size = New System.Drawing.Size(100, 20)
        Me.txt_perfil.TabIndex = 6
        Me.txt_perfil.Visible = False
        '
        'txt_usrgen
        '
        Me.txt_usrgen.Enabled = False
        Me.txt_usrgen.Location = New System.Drawing.Point(33, 43)
        Me.txt_usrgen.Name = "txt_usrgen"
        Me.txt_usrgen.Size = New System.Drawing.Size(100, 20)
        Me.txt_usrgen.TabIndex = 5
        Me.txt_usrgen.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNUGenerales, Me.MNUVentas, Me.MNUCompras, Me.MNUInventario, Me.MNUDespacho, Me.MNUConsultas, Me.SalidaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(983, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "Menu principal"
        '
        'MNUGenerales
        '
        Me.MNUGenerales.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenUsuario, Me.GenClientes, Me.GenProveedores, Me.GenArticulos, Me.GenListaPrecios, Me.GenAlmacenes, Me.GenVendedores})
        Me.MNUGenerales.Name = "MNUGenerales"
        Me.MNUGenerales.Size = New System.Drawing.Size(70, 20)
        Me.MNUGenerales.Text = "Generales"
        '
        'GenUsuario
        '
        Me.GenUsuario.Name = "GenUsuario"
        Me.GenUsuario.Size = New System.Drawing.Size(160, 22)
        Me.GenUsuario.Text = "Usuario"
        '
        'GenClientes
        '
        Me.GenClientes.Name = "GenClientes"
        Me.GenClientes.Size = New System.Drawing.Size(160, 22)
        Me.GenClientes.Text = "Clientes"
        '
        'GenProveedores
        '
        Me.GenProveedores.Name = "GenProveedores"
        Me.GenProveedores.Size = New System.Drawing.Size(160, 22)
        Me.GenProveedores.Text = "Proveedores"
        '
        'GenArticulos
        '
        Me.GenArticulos.Name = "GenArticulos"
        Me.GenArticulos.Size = New System.Drawing.Size(160, 22)
        Me.GenArticulos.Text = "Articulos"
        '
        'GenListaPrecios
        '
        Me.GenListaPrecios.Name = "GenListaPrecios"
        Me.GenListaPrecios.Size = New System.Drawing.Size(160, 22)
        Me.GenListaPrecios.Text = "Listas de precios"
        '
        'GenAlmacenes
        '
        Me.GenAlmacenes.Name = "GenAlmacenes"
        Me.GenAlmacenes.Size = New System.Drawing.Size(160, 22)
        Me.GenAlmacenes.Text = "Almacenes"
        '
        'GenVendedores
        '
        Me.GenVendedores.Name = "GenVendedores"
        Me.GenVendedores.Size = New System.Drawing.Size(160, 22)
        Me.GenVendedores.Text = "Vendedores"
        '
        'MNUVentas
        '
        Me.MNUVentas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CotizacionAClienteToolStripMenuItem, Me.PedidoDeClienteToolStripMenuItem, Me.VtasFacturasDeClientes, Me.VtasDevolucionDeClientes})
        Me.MNUVentas.Name = "MNUVentas"
        Me.MNUVentas.Size = New System.Drawing.Size(54, 20)
        Me.MNUVentas.Text = "Ventas"
        '
        'CotizacionAClienteToolStripMenuItem
        '
        Me.CotizacionAClienteToolStripMenuItem.Name = "CotizacionAClienteToolStripMenuItem"
        Me.CotizacionAClienteToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.CotizacionAClienteToolStripMenuItem.Text = "Cotizacion a cliente"
        Me.CotizacionAClienteToolStripMenuItem.Visible = False
        '
        'PedidoDeClienteToolStripMenuItem
        '
        Me.PedidoDeClienteToolStripMenuItem.Name = "PedidoDeClienteToolStripMenuItem"
        Me.PedidoDeClienteToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.PedidoDeClienteToolStripMenuItem.Text = "Pedido de cliente"
        '
        'VtasFacturasDeClientes
        '
        Me.VtasFacturasDeClientes.Name = "VtasFacturasDeClientes"
        Me.VtasFacturasDeClientes.Size = New System.Drawing.Size(193, 22)
        Me.VtasFacturasDeClientes.Text = "Facturas de clientes"
        '
        'VtasDevolucionDeClientes
        '
        Me.VtasDevolucionDeClientes.Name = "VtasDevolucionDeClientes"
        Me.VtasDevolucionDeClientes.Size = New System.Drawing.Size(193, 22)
        Me.VtasDevolucionDeClientes.Text = "Devolucion de clientes"
        Me.VtasDevolucionDeClientes.Visible = False
        '
        'MNUCompras
        '
        Me.MNUCompras.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PedidoAProveedorToolStripMenuItem, Me.IngresoProveedorToolStripMenuItem, Me.FacturasToolStripMenuItem})
        Me.MNUCompras.Name = "MNUCompras"
        Me.MNUCompras.Size = New System.Drawing.Size(67, 20)
        Me.MNUCompras.Text = "Compras"
        '
        'PedidoAProveedorToolStripMenuItem
        '
        Me.PedidoAProveedorToolStripMenuItem.Name = "PedidoAProveedorToolStripMenuItem"
        Me.PedidoAProveedorToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.PedidoAProveedorToolStripMenuItem.Text = "Pedido a proveedor"
        Me.PedidoAProveedorToolStripMenuItem.Visible = False
        '
        'IngresoProveedorToolStripMenuItem
        '
        Me.IngresoProveedorToolStripMenuItem.Name = "IngresoProveedorToolStripMenuItem"
        Me.IngresoProveedorToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.IngresoProveedorToolStripMenuItem.Text = "Ingreso proveedor"
        '
        'FacturasToolStripMenuItem
        '
        Me.FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        Me.FacturasToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.FacturasToolStripMenuItem.Text = "Facturas"
        Me.FacturasToolStripMenuItem.Visible = False
        '
        'MNUInventario
        '
        Me.MNUInventario.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tls_Traslado, Me.ConsultaDeExistenciasToolStripMenuItem, Me.IngresoDeMercaderiaToolStripMenuItem, Me.SalidasDeMercaderiaToolStripMenuItem})
        Me.MNUInventario.Name = "MNUInventario"
        Me.MNUInventario.Size = New System.Drawing.Size(72, 20)
        Me.MNUInventario.Text = "Inventario"
        '
        'Tls_Traslado
        '
        Me.Tls_Traslado.Name = "Tls_Traslado"
        Me.Tls_Traslado.Size = New System.Drawing.Size(196, 22)
        Me.Tls_Traslado.Text = "Traslado de almacen"
        '
        'ConsultaDeExistenciasToolStripMenuItem
        '
        Me.ConsultaDeExistenciasToolStripMenuItem.Name = "ConsultaDeExistenciasToolStripMenuItem"
        Me.ConsultaDeExistenciasToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ConsultaDeExistenciasToolStripMenuItem.Text = "Consulta de existencias"
        '
        'IngresoDeMercaderiaToolStripMenuItem
        '
        Me.IngresoDeMercaderiaToolStripMenuItem.Name = "IngresoDeMercaderiaToolStripMenuItem"
        Me.IngresoDeMercaderiaToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.IngresoDeMercaderiaToolStripMenuItem.Text = "Ingreso de mercaderia"
        '
        'SalidasDeMercaderiaToolStripMenuItem
        '
        Me.SalidasDeMercaderiaToolStripMenuItem.Name = "SalidasDeMercaderiaToolStripMenuItem"
        Me.SalidasDeMercaderiaToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.SalidasDeMercaderiaToolStripMenuItem.Text = "Salidas de mercaderia"
        '
        'MNUDespacho
        '
        Me.MNUDespacho.Name = "MNUDespacho"
        Me.MNUDespacho.Size = New System.Drawing.Size(71, 20)
        Me.MNUDespacho.Text = "Despacho"
        '
        'MNUConsultas
        '
        Me.MNUConsultas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem1, Me.VentasPorClienteToolStripMenuItem, Me.VentasPorArticuloToolStripMenuItem, Me.KardexToolStripMenuItem, Me.VentasGeneralesToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.IngresosManualesToolStripMenuItem, Me.SalidasManualesToolStripMenuItem, Me.RegistroOperacionesToolStripMenuItem, Me.ListadoDePedidosToolStripMenuItem})
        Me.MNUConsultas.Name = "MNUConsultas"
        Me.MNUConsultas.Size = New System.Drawing.Size(71, 20)
        Me.MNUConsultas.Text = "Consultas"
        '
        'VentasToolStripMenuItem1
        '
        Me.VentasToolStripMenuItem1.Name = "VentasToolStripMenuItem1"
        Me.VentasToolStripMenuItem1.Size = New System.Drawing.Size(200, 22)
        Me.VentasToolStripMenuItem1.Text = "Ventas por vendedor"
        '
        'VentasPorClienteToolStripMenuItem
        '
        Me.VentasPorClienteToolStripMenuItem.Name = "VentasPorClienteToolStripMenuItem"
        Me.VentasPorClienteToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.VentasPorClienteToolStripMenuItem.Text = "Ventas Por Cliente"
        '
        'VentasPorArticuloToolStripMenuItem
        '
        Me.VentasPorArticuloToolStripMenuItem.Name = "VentasPorArticuloToolStripMenuItem"
        Me.VentasPorArticuloToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.VentasPorArticuloToolStripMenuItem.Text = "Ventas Por Articulo"
        '
        'KardexToolStripMenuItem
        '
        Me.KardexToolStripMenuItem.Name = "KardexToolStripMenuItem"
        Me.KardexToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.KardexToolStripMenuItem.Text = "Kardex"
        '
        'VentasGeneralesToolStripMenuItem
        '
        Me.VentasGeneralesToolStripMenuItem.Name = "VentasGeneralesToolStripMenuItem"
        Me.VentasGeneralesToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.VentasGeneralesToolStripMenuItem.Text = "Ventas generales"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ComprasToolStripMenuItem.Text = "Compras por proveedor"
        '
        'IngresosManualesToolStripMenuItem
        '
        Me.IngresosManualesToolStripMenuItem.Name = "IngresosManualesToolStripMenuItem"
        Me.IngresosManualesToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.IngresosManualesToolStripMenuItem.Text = "Ingresos manuales"
        '
        'SalidasManualesToolStripMenuItem
        '
        Me.SalidasManualesToolStripMenuItem.Name = "SalidasManualesToolStripMenuItem"
        Me.SalidasManualesToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.SalidasManualesToolStripMenuItem.Text = "Salidas manuales"
        '
        'RegistroOperacionesToolStripMenuItem
        '
        Me.RegistroOperacionesToolStripMenuItem.Name = "RegistroOperacionesToolStripMenuItem"
        Me.RegistroOperacionesToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.RegistroOperacionesToolStripMenuItem.Text = "Registro operaciones"
        '
        'SalidaToolStripMenuItem
        '
        Me.SalidaToolStripMenuItem.Name = "SalidaToolStripMenuItem"
        Me.SalidaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.SalidaToolStripMenuItem.Text = "Salida"
        '
        'ListadoDePedidosToolStripMenuItem
        '
        Me.ListadoDePedidosToolStripMenuItem.Name = "ListadoDePedidosToolStripMenuItem"
        Me.ListadoDePedidosToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ListadoDePedidosToolStripMenuItem.Text = "Pedidos"
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 470)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txt_perfil)
        Me.Controls.Add(Me.txt_usrgen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IsMdiContainer = True
        Me.Name = "Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_perfil As System.Windows.Forms.TextBox
    Friend WithEvents txt_usrgen As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MNUGenerales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenUsuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenProveedores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenArticulos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenListaPrecios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenAlmacenes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenVendedores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNUVentas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CotizacionAClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PedidoDeClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VtasFacturasDeClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VtasDevolucionDeClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNUCompras As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PedidoAProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresoProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNUInventario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tls_Traslado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaDeExistenciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresoDeMercaderiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalidasDeMercaderiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNUDespacho As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNUConsultas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalidaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasPorClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasPorArticuloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KardexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasGeneralesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresosManualesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalidasManualesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroOperacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoDePedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
