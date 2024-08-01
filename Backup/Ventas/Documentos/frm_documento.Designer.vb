<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_documento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_documento))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txt_estado = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.btn_pagar = New System.Windows.Forms.Button
        Me.btn_importar = New System.Windows.Forms.Button
        Me.txt_nit = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmb_tipoCorrelativo = New System.Windows.Forms.ComboBox
        Me.cmb_numero_sig = New System.Windows.Forms.ComboBox
        Me.btn_imprimir = New System.Windows.Forms.Button
        Me.txt_total = New System.Windows.Forms.TextBox
        Me.cmb_tipoPedido = New System.Windows.Forms.ComboBox
        Me.dtp_pago = New System.Windows.Forms.DateTimePicker
        Me.dtp_requerida = New System.Windows.Forms.DateTimePicker
        Me.txt_direccion = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.txt_codigo = New System.Windows.Forms.TextBox
        Me.cmb_serie = New System.Windows.Forms.ComboBox
        Me.txt_numero = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.lbl_ttrans = New System.Windows.Forms.Label
        Me.lbl_fpago = New System.Windows.Forms.Label
        Me.lbl_requerida = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_grabar = New System.Windows.Forms.Button
        Me.btn_nuevo = New System.Windows.Forms.Button
        Me.txt_obs = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker
        Me.txt_orden = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbl_titulo = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_anular = New System.Windows.Forms.Button
        Me.col_subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_precio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_diferencia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_entregada = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_costo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_exi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dtg_movimientos = New System.Windows.Forms.DataGridView
        CType(Me.dtg_movimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_estado
        '
        Me.txt_estado.BackColor = System.Drawing.Color.White
        Me.txt_estado.Location = New System.Drawing.Point(804, 55)
        Me.txt_estado.Name = "txt_estado"
        Me.txt_estado.ReadOnly = True
        Me.txt_estado.Size = New System.Drawing.Size(94, 20)
        Me.txt_estado.TabIndex = 159
        Me.txt_estado.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(758, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 158
        Me.Label10.Text = "Estado:"
        '
        'btn_pagar
        '
        Me.btn_pagar.Location = New System.Drawing.Point(545, 58)
        Me.btn_pagar.Name = "btn_pagar"
        Me.btn_pagar.Size = New System.Drawing.Size(99, 36)
        Me.btn_pagar.TabIndex = 157
        Me.btn_pagar.Text = "Pagar"
        Me.btn_pagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_pagar.UseVisualStyleBackColor = True
        Me.btn_pagar.Visible = False
        '
        'btn_importar
        '
        Me.btn_importar.Location = New System.Drawing.Point(440, 58)
        Me.btn_importar.Name = "btn_importar"
        Me.btn_importar.Size = New System.Drawing.Size(99, 36)
        Me.btn_importar.TabIndex = 156
        Me.btn_importar.Text = "Importar"
        Me.btn_importar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_importar.UseVisualStyleBackColor = True
        Me.btn_importar.Visible = False
        '
        'txt_nit
        '
        Me.txt_nit.BackColor = System.Drawing.Color.White
        Me.txt_nit.Location = New System.Drawing.Point(781, 133)
        Me.txt_nit.Name = "txt_nit"
        Me.txt_nit.Size = New System.Drawing.Size(107, 20)
        Me.txt_nit.TabIndex = 130
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label9.Location = New System.Drawing.Point(752, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 16)
        Me.Label9.TabIndex = 155
        Me.Label9.Text = "Nit:"
        '
        'cmb_tipoCorrelativo
        '
        Me.cmb_tipoCorrelativo.FormattingEnabled = True
        Me.cmb_tipoCorrelativo.Location = New System.Drawing.Point(104, 597)
        Me.cmb_tipoCorrelativo.Name = "cmb_tipoCorrelativo"
        Me.cmb_tipoCorrelativo.Size = New System.Drawing.Size(65, 21)
        Me.cmb_tipoCorrelativo.TabIndex = 154
        Me.cmb_tipoCorrelativo.Visible = False
        '
        'cmb_numero_sig
        '
        Me.cmb_numero_sig.FormattingEnabled = True
        Me.cmb_numero_sig.Location = New System.Drawing.Point(24, 597)
        Me.cmb_numero_sig.Name = "cmb_numero_sig"
        Me.cmb_numero_sig.Size = New System.Drawing.Size(74, 21)
        Me.cmb_numero_sig.TabIndex = 153
        Me.cmb_numero_sig.Visible = False
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.Location = New System.Drawing.Point(804, 78)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(63, 51)
        Me.btn_imprimir.TabIndex = 152
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_imprimir.UseVisualStyleBackColor = True
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.Color.White
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(794, 193)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(113, 22)
        Me.txt_total.TabIndex = 137
        Me.txt_total.TabStop = False
        '
        'cmb_tipoPedido
        '
        Me.cmb_tipoPedido.BackColor = System.Drawing.Color.White
        Me.cmb_tipoPedido.FormattingEnabled = True
        Me.cmb_tipoPedido.Location = New System.Drawing.Point(630, 191)
        Me.cmb_tipoPedido.Name = "cmb_tipoPedido"
        Me.cmb_tipoPedido.Size = New System.Drawing.Size(114, 21)
        Me.cmb_tipoPedido.TabIndex = 134
        '
        'dtp_pago
        '
        Me.dtp_pago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_pago.Location = New System.Drawing.Point(135, 213)
        Me.dtp_pago.Name = "dtp_pago"
        Me.dtp_pago.Size = New System.Drawing.Size(88, 20)
        Me.dtp_pago.TabIndex = 133
        '
        'dtp_requerida
        '
        Me.dtp_requerida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_requerida.Location = New System.Drawing.Point(135, 188)
        Me.dtp_requerida.Name = "dtp_requerida"
        Me.dtp_requerida.Size = New System.Drawing.Size(88, 20)
        Me.dtp_requerida.TabIndex = 132
        '
        'txt_direccion
        '
        Me.txt_direccion.BackColor = System.Drawing.Color.White
        Me.txt_direccion.Location = New System.Drawing.Point(71, 161)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(675, 20)
        Me.txt_direccion.TabIndex = 131
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(5, 162)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 16)
        Me.Label14.TabIndex = 149
        Me.Label14.Text = "Direccion:"
        '
        'txt_nombre
        '
        Me.txt_nombre.BackColor = System.Drawing.Color.White
        Me.txt_nombre.Location = New System.Drawing.Point(267, 134)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(479, 20)
        Me.txt_nombre.TabIndex = 129
        '
        'txt_codigo
        '
        Me.txt_codigo.BackColor = System.Drawing.Color.White
        Me.txt_codigo.Location = New System.Drawing.Point(71, 135)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(100, 20)
        Me.txt_codigo.TabIndex = 128
        '
        'cmb_serie
        '
        Me.cmb_serie.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmb_serie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_serie.FormattingEnabled = True
        Me.cmb_serie.Location = New System.Drawing.Point(335, 99)
        Me.cmb_serie.Name = "cmb_serie"
        Me.cmb_serie.Size = New System.Drawing.Size(68, 21)
        Me.cmb_serie.TabIndex = 126
        Me.cmb_serie.Visible = False
        '
        'txt_numero
        '
        Me.txt_numero.BackColor = System.Drawing.Color.White
        Me.txt_numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero.Location = New System.Drawing.Point(74, 107)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(80, 21)
        Me.txt_numero.TabIndex = 127
        Me.txt_numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(745, 196)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 16)
        Me.Label13.TabIndex = 148
        Me.Label13.Text = "Total:"
        '
        'lbl_ttrans
        '
        Me.lbl_ttrans.AutoSize = True
        Me.lbl_ttrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ttrans.Location = New System.Drawing.Point(536, 193)
        Me.lbl_ttrans.Name = "lbl_ttrans"
        Me.lbl_ttrans.Size = New System.Drawing.Size(85, 16)
        Me.lbl_ttrans.TabIndex = 147
        Me.lbl_ttrans.Text = "Tipo pedido:"
        '
        'lbl_fpago
        '
        Me.lbl_fpago.AutoSize = True
        Me.lbl_fpago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fpago.Location = New System.Drawing.Point(9, 213)
        Me.lbl_fpago.Name = "lbl_fpago"
        Me.lbl_fpago.Size = New System.Drawing.Size(124, 16)
        Me.lbl_fpago.TabIndex = 146
        Me.lbl_fpago.Text = "Fecha vencimiento:"
        '
        'lbl_requerida
        '
        Me.lbl_requerida.AutoSize = True
        Me.lbl_requerida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_requerida.Location = New System.Drawing.Point(15, 190)
        Me.lbl_requerida.Name = "lbl_requerida"
        Me.lbl_requerida.Size = New System.Drawing.Size(119, 16)
        Me.lbl_requerida.TabIndex = 145
        Me.lbl_requerida.Text = "Fecha documento:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(204, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 16)
        Me.Label8.TabIndex = 144
        Me.Label8.Text = "Nombre:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 143
        Me.Label7.Text = "Codigo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 16)
        Me.Label6.TabIndex = 142
        Me.Label6.Text = "Numero:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(291, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "Serie:"
        Me.Label2.Visible = False
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(335, 57)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(99, 36)
        Me.btn_buscar.TabIndex = 123
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(230, 57)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(99, 36)
        Me.btn_cancelar.TabIndex = 122
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_grabar
        '
        Me.btn_grabar.Location = New System.Drawing.Point(125, 57)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(99, 36)
        Me.btn_grabar.TabIndex = 119
        Me.btn_grabar.Text = "Grabar"
        Me.btn_grabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(20, 57)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(99, 36)
        Me.btn_nuevo.TabIndex = 117
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'txt_obs
        '
        Me.txt_obs.BackColor = System.Drawing.Color.White
        Me.txt_obs.Location = New System.Drawing.Point(121, 265)
        Me.txt_obs.MaxLength = 300
        Me.txt_obs.Multiline = True
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(603, 49)
        Me.txt_obs.TabIndex = 135
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 16)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "Observaciones:"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Enabled = False
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(134, 237)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(90, 20)
        Me.dtp_fecha.TabIndex = 151
        Me.dtp_fecha.TabStop = False
        '
        'txt_orden
        '
        Me.txt_orden.BackColor = System.Drawing.Color.SkyBlue
        Me.txt_orden.Location = New System.Drawing.Point(804, 16)
        Me.txt_orden.Name = "txt_orden"
        Me.txt_orden.ReadOnly = True
        Me.txt_orden.Size = New System.Drawing.Size(100, 20)
        Me.txt_orden.TabIndex = 150
        Me.txt_orden.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 16)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "Fecha entrega:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 121
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.ForeColor = System.Drawing.Color.Red
        Me.lbl_titulo.Location = New System.Drawing.Point(13, 4)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(291, 37)
        Me.lbl_titulo.TabIndex = 120
        Me.lbl_titulo.Text = "uso del formulario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(679, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 16)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "No. de movimiento:"
        '
        'btn_anular
        '
        Me.btn_anular.Location = New System.Drawing.Point(649, 59)
        Me.btn_anular.Name = "btn_anular"
        Me.btn_anular.Size = New System.Drawing.Size(99, 36)
        Me.btn_anular.TabIndex = 160
        Me.btn_anular.Text = "Anular"
        Me.btn_anular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_anular.UseVisualStyleBackColor = True
        Me.btn_anular.Visible = False
        '
        'col_subtotal
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.col_subtotal.DefaultCellStyle = DataGridViewCellStyle1
        Me.col_subtotal.HeaderText = "Subtotal"
        Me.col_subtotal.MaxInputLength = 12
        Me.col_subtotal.Name = "col_subtotal"
        Me.col_subtotal.ReadOnly = True
        Me.col_subtotal.Width = 75
        '
        'col_precio
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.0"
        Me.col_precio.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_precio.HeaderText = "Precio"
        Me.col_precio.MaxInputLength = 12
        Me.col_precio.Name = "col_precio"
        Me.col_precio.Width = 70
        '
        'col_diferencia
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.col_diferencia.DefaultCellStyle = DataGridViewCellStyle3
        Me.col_diferencia.HeaderText = "Dif."
        Me.col_diferencia.Name = "col_diferencia"
        Me.col_diferencia.Width = 60
        '
        'col_entregada
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.col_entregada.DefaultCellStyle = DataGridViewCellStyle4
        Me.col_entregada.HeaderText = "Entregado"
        Me.col_entregada.MaxInputLength = 12
        Me.col_entregada.Name = "col_entregada"
        Me.col_entregada.Width = 70
        '
        'col_Cantidad
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.col_Cantidad.DefaultCellStyle = DataGridViewCellStyle5
        Me.col_Cantidad.HeaderText = "Cantidad"
        Me.col_Cantidad.MaxInputLength = 12
        Me.col_Cantidad.Name = "col_Cantidad"
        Me.col_Cantidad.Width = 70
        '
        'col_costo
        '
        Me.col_costo.HeaderText = "Costo"
        Me.col_costo.MaxInputLength = 12
        Me.col_costo.Name = "col_costo"
        Me.col_costo.ReadOnly = True
        Me.col_costo.Width = 75
        '
        'col_exi
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_exi.DefaultCellStyle = DataGridViewCellStyle6
        Me.col_exi.HeaderText = "Existencia"
        Me.col_exi.MaxInputLength = 6
        Me.col_exi.Name = "col_exi"
        Me.col_exi.ReadOnly = True
        Me.col_exi.Width = 65
        '
        'Descripcion
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion.DefaultCellStyle = DataGridViewCellStyle7
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.MaxInputLength = 100
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Width = 300
        '
        'col_codigo
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_codigo.DefaultCellStyle = DataGridViewCellStyle8
        Me.col_codigo.HeaderText = "Codigo"
        Me.col_codigo.MaxInputLength = 15
        Me.col_codigo.Name = "col_codigo"
        Me.col_codigo.Width = 75
        '
        'dtg_movimientos
        '
        Me.dtg_movimientos.AllowUserToResizeColumns = False
        Me.dtg_movimientos.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtg_movimientos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dtg_movimientos.BackgroundColor = System.Drawing.Color.DeepSkyBlue
        Me.dtg_movimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_movimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_codigo, Me.Descripcion, Me.col_exi, Me.col_costo, Me.col_Cantidad, Me.col_entregada, Me.col_diferencia, Me.col_precio, Me.col_subtotal})
        Me.dtg_movimientos.Location = New System.Drawing.Point(24, 326)
        Me.dtg_movimientos.Name = "dtg_movimientos"
        Me.dtg_movimientos.Size = New System.Drawing.Size(875, 265)
        Me.dtg_movimientos.TabIndex = 140
        '
        'frm_documento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 633)
        Me.Controls.Add(Me.btn_anular)
        Me.Controls.Add(Me.txt_estado)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_pagar)
        Me.Controls.Add(Me.btn_importar)
        Me.Controls.Add(Me.txt_nit)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmb_tipoCorrelativo)
        Me.Controls.Add(Me.cmb_numero_sig)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.cmb_tipoPedido)
        Me.Controls.Add(Me.dtp_pago)
        Me.Controls.Add(Me.dtp_requerida)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.cmb_serie)
        Me.Controls.Add(Me.txt_numero)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lbl_ttrans)
        Me.Controls.Add(Me.lbl_fpago)
        Me.Controls.Add(Me.lbl_requerida)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_grabar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.dtg_movimientos)
        Me.Controls.Add(Me.txt_obs)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.txt_orden)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_documento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de documento"
        CType(Me.dtg_movimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_estado As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btn_pagar As System.Windows.Forms.Button
    Friend WithEvents btn_importar As System.Windows.Forms.Button
    Friend WithEvents txt_nit As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipoCorrelativo As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_numero_sig As System.Windows.Forms.ComboBox
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents cmb_tipoPedido As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_pago As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_requerida As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents cmb_serie As System.Windows.Forms.ComboBox
    Friend WithEvents txt_numero As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbl_ttrans As System.Windows.Forms.Label
    Friend WithEvents lbl_fpago As System.Windows.Forms.Label
    Friend WithEvents lbl_requerida As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_grabar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents txt_obs As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_orden As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_anular As System.Windows.Forms.Button
    Friend WithEvents col_subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_diferencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_entregada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_exi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtg_movimientos As System.Windows.Forms.DataGridView
End Class
