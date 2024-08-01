<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cotcli
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cotcli))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txt_nit = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.btn_imprimir = New System.Windows.Forms.Button
        Me.txt_total = New System.Windows.Forms.TextBox
        Me.dtp_vence = New System.Windows.Forms.DateTimePicker
        Me.dtp_documento = New System.Windows.Forms.DateTimePicker
        Me.txt_direccion = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.txt_codigo = New System.Windows.Forms.TextBox
        Me.txt_numero = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.lbl_fpago = New System.Windows.Forms.Label
        Me.lbl_requerida = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_grabar = New System.Windows.Forms.Button
        Me.btn_nuevo = New System.Windows.Forms.Button
        Me.dtg_movimientos = New System.Windows.Forms.DataGridView
        Me.txt_obs = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_orden = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbl_titulo = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_ttsiniva = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_iva = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_vendedor = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_exi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_costo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_precio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_almacen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_ordenalm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_unidadesempaque = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dtg_movimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_nit
        '
        Me.txt_nit.BackColor = System.Drawing.Color.White
        Me.txt_nit.Location = New System.Drawing.Point(776, 147)
        Me.txt_nit.Name = "txt_nit"
        Me.txt_nit.Size = New System.Drawing.Size(107, 20)
        Me.txt_nit.TabIndex = 174
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label9.Location = New System.Drawing.Point(747, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 16)
        Me.Label9.TabIndex = 194
        Me.Label9.Text = "Nit:"
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.Location = New System.Drawing.Point(799, 210)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(63, 51)
        Me.btn_imprimir.TabIndex = 193
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_imprimir.UseVisualStyleBackColor = True
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.Color.White
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(780, 591)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(113, 22)
        Me.txt_total.TabIndex = 180
        Me.txt_total.TabStop = False
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtp_vence
        '
        Me.dtp_vence.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_vence.Location = New System.Drawing.Point(775, 104)
        Me.dtp_vence.Name = "dtp_vence"
        Me.dtp_vence.Size = New System.Drawing.Size(88, 20)
        Me.dtp_vence.TabIndex = 177
        '
        'dtp_documento
        '
        Me.dtp_documento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_documento.Location = New System.Drawing.Point(775, 79)
        Me.dtp_documento.Name = "dtp_documento"
        Me.dtp_documento.Size = New System.Drawing.Size(88, 20)
        Me.dtp_documento.TabIndex = 176
        '
        'txt_direccion
        '
        Me.txt_direccion.BackColor = System.Drawing.Color.White
        Me.txt_direccion.Location = New System.Drawing.Point(66, 175)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(675, 20)
        Me.txt_direccion.TabIndex = 175
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(0, 176)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 16)
        Me.Label14.TabIndex = 190
        Me.Label14.Text = "Direccion:"
        '
        'txt_nombre
        '
        Me.txt_nombre.BackColor = System.Drawing.Color.White
        Me.txt_nombre.Location = New System.Drawing.Point(262, 148)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(479, 20)
        Me.txt_nombre.TabIndex = 173
        '
        'txt_codigo
        '
        Me.txt_codigo.BackColor = System.Drawing.Color.White
        Me.txt_codigo.Location = New System.Drawing.Point(66, 149)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(100, 20)
        Me.txt_codigo.TabIndex = 172
        '
        'txt_numero
        '
        Me.txt_numero.BackColor = System.Drawing.Color.White
        Me.txt_numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero.Location = New System.Drawing.Point(69, 121)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(80, 21)
        Me.txt_numero.TabIndex = 171
        Me.txt_numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(731, 594)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 16)
        Me.Label13.TabIndex = 189
        Me.Label13.Text = "Total:"
        '
        'lbl_fpago
        '
        Me.lbl_fpago.AutoSize = True
        Me.lbl_fpago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fpago.Location = New System.Drawing.Point(649, 104)
        Me.lbl_fpago.Name = "lbl_fpago"
        Me.lbl_fpago.Size = New System.Drawing.Size(124, 16)
        Me.lbl_fpago.TabIndex = 187
        Me.lbl_fpago.Text = "Fecha vencimiento:"
        '
        'lbl_requerida
        '
        Me.lbl_requerida.AutoSize = True
        Me.lbl_requerida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_requerida.Location = New System.Drawing.Point(655, 81)
        Me.lbl_requerida.Name = "lbl_requerida"
        Me.lbl_requerida.Size = New System.Drawing.Size(119, 16)
        Me.lbl_requerida.TabIndex = 186
        Me.lbl_requerida.Text = "Fecha documento:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(199, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 16)
        Me.Label8.TabIndex = 185
        Me.Label8.Text = "Nombre:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 184
        Me.Label7.Text = "Codigo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 16)
        Me.Label6.TabIndex = 183
        Me.Label6.Text = "Numero:"
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(330, 71)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(99, 36)
        Me.btn_buscar.TabIndex = 167
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(225, 71)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(99, 36)
        Me.btn_cancelar.TabIndex = 166
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_grabar
        '
        Me.btn_grabar.Location = New System.Drawing.Point(120, 71)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(99, 36)
        Me.btn_grabar.TabIndex = 163
        Me.btn_grabar.Text = "Grabar"
        Me.btn_grabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(15, 71)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(99, 36)
        Me.btn_nuevo.TabIndex = 161
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'dtg_movimientos
        '
        Me.dtg_movimientos.AllowUserToResizeColumns = False
        Me.dtg_movimientos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtg_movimientos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtg_movimientos.BackgroundColor = System.Drawing.Color.DeepSkyBlue
        Me.dtg_movimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_movimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_codigo, Me.Descripcion, Me.col_exi, Me.col_costo, Me.col_Cantidad, Me.col_precio, Me.col_subtotal, Me.col_impuesto, Me.col_almacen, Me.col_ordenalm, Me.col_unidadesempaque})
        Me.dtg_movimientos.Location = New System.Drawing.Point(19, 291)
        Me.dtg_movimientos.Name = "dtg_movimientos"
        Me.dtg_movimientos.Size = New System.Drawing.Size(896, 288)
        Me.dtg_movimientos.TabIndex = 181
        '
        'txt_obs
        '
        Me.txt_obs.BackColor = System.Drawing.Color.White
        Me.txt_obs.Location = New System.Drawing.Point(116, 212)
        Me.txt_obs.MaxLength = 150
        Me.txt_obs.Multiline = True
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(603, 49)
        Me.txt_obs.TabIndex = 179
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 16)
        Me.Label5.TabIndex = 169
        Me.Label5.Text = "Observaciones:"
        '
        'txt_orden
        '
        Me.txt_orden.BackColor = System.Drawing.Color.SkyBlue
        Me.txt_orden.Location = New System.Drawing.Point(799, 30)
        Me.txt_orden.Name = "txt_orden"
        Me.txt_orden.ReadOnly = True
        Me.txt_orden.Size = New System.Drawing.Size(100, 20)
        Me.txt_orden.TabIndex = 191
        Me.txt_orden.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 165
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.ForeColor = System.Drawing.Color.Red
        Me.lbl_titulo.Location = New System.Drawing.Point(8, 18)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(314, 37)
        Me.lbl_titulo.TabIndex = 164
        Me.lbl_titulo.Text = "Cotizacion a cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(674, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 16)
        Me.Label1.TabIndex = 162
        Me.Label1.Text = "Orden documento:"
        '
        'txt_ttsiniva
        '
        Me.txt_ttsiniva.BackColor = System.Drawing.Color.White
        Me.txt_ttsiniva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ttsiniva.Location = New System.Drawing.Point(365, 594)
        Me.txt_ttsiniva.Name = "txt_ttsiniva"
        Me.txt_ttsiniva.Size = New System.Drawing.Size(113, 22)
        Me.txt_ttsiniva.TabIndex = 200
        Me.txt_ttsiniva.TabStop = False
        Me.txt_ttsiniva.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(224, 597)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 16)
        Me.Label2.TabIndex = 201
        Me.Label2.Text = "Total sin impuesto:"
        Me.Label2.Visible = False
        '
        'txt_iva
        '
        Me.txt_iva.BackColor = System.Drawing.Color.White
        Me.txt_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_iva.Location = New System.Drawing.Point(594, 591)
        Me.txt_iva.Name = "txt_iva"
        Me.txt_iva.Size = New System.Drawing.Size(113, 22)
        Me.txt_iva.TabIndex = 202
        Me.txt_iva.TabStop = False
        Me.txt_iva.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(516, 594)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 16)
        Me.Label11.TabIndex = 203
        Me.Label11.Text = "Impuesto:"
        Me.Label11.Visible = False
        '
        'txt_vendedor
        '
        Me.txt_vendedor.BackColor = System.Drawing.Color.White
        Me.txt_vendedor.Location = New System.Drawing.Point(98, 267)
        Me.txt_vendedor.Name = "txt_vendedor"
        Me.txt_vendedor.Size = New System.Drawing.Size(100, 20)
        Me.txt_vendedor.TabIndex = 204
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 205
        Me.Label4.Text = "Vendedor:"
        '
        'col_codigo
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.NullValue = Nothing
        Me.col_codigo.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_codigo.HeaderText = "Codigo"
        Me.col_codigo.MaxInputLength = 15
        Me.col_codigo.Name = "col_codigo"
        Me.col_codigo.Width = 125
        '
        'Descripcion
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion.DefaultCellStyle = DataGridViewCellStyle3
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.MaxInputLength = 100
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 300
        '
        'col_exi
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_exi.DefaultCellStyle = DataGridViewCellStyle4
        Me.col_exi.HeaderText = "Existencia"
        Me.col_exi.MaxInputLength = 6
        Me.col_exi.Name = "col_exi"
        Me.col_exi.ReadOnly = True
        Me.col_exi.Width = 65
        '
        'col_costo
        '
        Me.col_costo.HeaderText = "Costo"
        Me.col_costo.MaxInputLength = 12
        Me.col_costo.Name = "col_costo"
        Me.col_costo.ReadOnly = True
        Me.col_costo.Visible = False
        Me.col_costo.Width = 75
        '
        'col_Cantidad
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Format = "N4"
        DataGridViewCellStyle5.NullValue = "0"
        Me.col_Cantidad.DefaultCellStyle = DataGridViewCellStyle5
        Me.col_Cantidad.HeaderText = "Cantidad"
        Me.col_Cantidad.MaxInputLength = 12
        Me.col_Cantidad.Name = "col_Cantidad"
        Me.col_Cantidad.Width = 70
        '
        'col_precio
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.Format = "N4"
        DataGridViewCellStyle6.NullValue = "0.0"
        Me.col_precio.DefaultCellStyle = DataGridViewCellStyle6
        Me.col_precio.HeaderText = "Precio"
        Me.col_precio.MaxInputLength = 12
        Me.col_precio.Name = "col_precio"
        '
        'col_subtotal
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.col_subtotal.DefaultCellStyle = DataGridViewCellStyle7
        Me.col_subtotal.HeaderText = "Subtotal"
        Me.col_subtotal.MaxInputLength = 12
        Me.col_subtotal.Name = "col_subtotal"
        Me.col_subtotal.ReadOnly = True
        '
        'col_impuesto
        '
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.col_impuesto.DefaultCellStyle = DataGridViewCellStyle8
        Me.col_impuesto.HeaderText = "Impuesto"
        Me.col_impuesto.Name = "col_impuesto"
        Me.col_impuesto.ReadOnly = True
        Me.col_impuesto.Visible = False
        '
        'col_almacen
        '
        Me.col_almacen.HeaderText = "Almacen"
        Me.col_almacen.MaxInputLength = 5
        Me.col_almacen.Name = "col_almacen"
        Me.col_almacen.Visible = False
        Me.col_almacen.Width = 75
        '
        'col_ordenalm
        '
        Me.col_ordenalm.HeaderText = "OrdenAlmacen"
        Me.col_ordenalm.Name = "col_ordenalm"
        Me.col_ordenalm.ReadOnly = True
        Me.col_ordenalm.Visible = False
        '
        'col_unidadesempaque
        '
        Me.col_unidadesempaque.HeaderText = "Unidades"
        Me.col_unidadesempaque.Name = "col_unidadesempaque"
        Me.col_unidadesempaque.ReadOnly = True
        Me.col_unidadesempaque.Visible = False
        '
        'frm_cotcli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 639)
        Me.Controls.Add(Me.txt_vendedor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_iva)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_ttsiniva)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nit)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.dtp_vence)
        Me.Controls.Add(Me.dtp_documento)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.txt_numero)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lbl_fpago)
        Me.Controls.Add(Me.lbl_requerida)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_grabar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.dtg_movimientos)
        Me.Controls.Add(Me.txt_obs)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_orden)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_cotcli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cotizacion de cliente"
        CType(Me.dtg_movimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_nit As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents dtp_vence As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_documento As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents txt_numero As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbl_fpago As System.Windows.Forms.Label
    Friend WithEvents lbl_requerida As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_grabar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents dtg_movimientos As System.Windows.Forms.DataGridView
    Friend WithEvents txt_obs As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_orden As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ttsiniva As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_iva As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_vendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents col_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_exi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_impuesto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_almacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_ordenalm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_unidadesempaque As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
