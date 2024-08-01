<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cons_ventas_gen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cons_ventas_gen))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rd_detalle = New System.Windows.Forms.RadioButton
        Me.rd_resumen = New System.Windows.Forms.RadioButton
        Me.btn_imprimir = New System.Windows.Forms.Button
        Me.btn_actualiza = New System.Windows.Forms.Button
        Me.dtg_ventas = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dtp_al = New System.Windows.Forms.DateTimePicker
        Me.dtp_del = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.col_factura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Col_fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_total = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox3.SuspendLayout()
        CType(Me.dtg_ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rd_detalle)
        Me.GroupBox3.Controls.Add(Me.rd_resumen)
        Me.GroupBox3.Location = New System.Drawing.Point(231, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(190, 40)
        Me.GroupBox3.TabIndex = 237
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Presentacion"
        Me.GroupBox3.Visible = False
        '
        'rd_detalle
        '
        Me.rd_detalle.AutoSize = True
        Me.rd_detalle.Location = New System.Drawing.Point(116, 17)
        Me.rd_detalle.Name = "rd_detalle"
        Me.rd_detalle.Size = New System.Drawing.Size(58, 17)
        Me.rd_detalle.TabIndex = 1
        Me.rd_detalle.TabStop = True
        Me.rd_detalle.Text = "Detalle"
        Me.rd_detalle.UseVisualStyleBackColor = True
        '
        'rd_resumen
        '
        Me.rd_resumen.AutoSize = True
        Me.rd_resumen.Location = New System.Drawing.Point(18, 17)
        Me.rd_resumen.Name = "rd_resumen"
        Me.rd_resumen.Size = New System.Drawing.Size(70, 17)
        Me.rd_resumen.TabIndex = 0
        Me.rd_resumen.TabStop = True
        Me.rd_resumen.Text = "Resumen"
        Me.rd_resumen.UseVisualStyleBackColor = True
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.Location = New System.Drawing.Point(703, 30)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(63, 51)
        Me.btn_imprimir.TabIndex = 236
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_imprimir.UseVisualStyleBackColor = True
        '
        'btn_actualiza
        '
        Me.btn_actualiza.Location = New System.Drawing.Point(530, 49)
        Me.btn_actualiza.Name = "btn_actualiza"
        Me.btn_actualiza.Size = New System.Drawing.Size(145, 23)
        Me.btn_actualiza.TabIndex = 235
        Me.btn_actualiza.Text = "Actualizar"
        Me.btn_actualiza.UseVisualStyleBackColor = True
        '
        'dtg_ventas
        '
        Me.dtg_ventas.AllowUserToAddRows = False
        Me.dtg_ventas.AllowUserToDeleteRows = False
        Me.dtg_ventas.AllowUserToResizeColumns = False
        Me.dtg_ventas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtg_ventas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_ventas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtg_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_ventas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_factura, Me.Col_fecha, Me.col_codigo, Me.col_cliente, Me.col_total})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtg_ventas.DefaultCellStyle = DataGridViewCellStyle5
        Me.dtg_ventas.Location = New System.Drawing.Point(8, 86)
        Me.dtg_ventas.Name = "dtg_ventas"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_ventas.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dtg_ventas.Size = New System.Drawing.Size(810, 438)
        Me.dtg_ventas.TabIndex = 234
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtp_al)
        Me.GroupBox2.Controls.Add(Me.dtp_del)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(206, 63)
        Me.GroupBox2.TabIndex = 233
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fechas"
        '
        'dtp_al
        '
        Me.dtp_al.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_al.Location = New System.Drawing.Point(69, 40)
        Me.dtp_al.Name = "dtp_al"
        Me.dtp_al.Size = New System.Drawing.Size(106, 20)
        Me.dtp_al.TabIndex = 3
        '
        'dtp_del
        '
        Me.dtp_del.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_del.Location = New System.Drawing.Point(69, 14)
        Me.dtp_del.Name = "dtp_del"
        Me.dtp_del.Size = New System.Drawing.Size(106, 20)
        Me.dtp_del.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "al:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "De:"
        '
        'col_factura
        '
        Me.col_factura.HeaderText = "Documento"
        Me.col_factura.Name = "col_factura"
        Me.col_factura.ReadOnly = True
        '
        'Col_fecha
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Col_fecha.DefaultCellStyle = DataGridViewCellStyle3
        Me.Col_fecha.HeaderText = "Fecha"
        Me.Col_fecha.Name = "Col_fecha"
        Me.Col_fecha.ReadOnly = True
        '
        'col_codigo
        '
        Me.col_codigo.HeaderText = "Codigo"
        Me.col_codigo.Name = "col_codigo"
        Me.col_codigo.ReadOnly = True
        '
        'col_cliente
        '
        Me.col_cliente.HeaderText = "Cliente"
        Me.col_cliente.Name = "col_cliente"
        Me.col_cliente.ReadOnly = True
        Me.col_cliente.Width = 270
        '
        'col_total
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.col_total.DefaultCellStyle = DataGridViewCellStyle4
        Me.col_total.HeaderText = "Total"
        Me.col_total.Name = "col_total"
        Me.col_total.ReadOnly = True
        '
        'frm_cons_ventas_gen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 537)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.btn_actualiza)
        Me.Controls.Add(Me.dtg_ventas)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_cons_ventas_gen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de ventas General"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dtg_ventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rd_detalle As System.Windows.Forms.RadioButton
    Friend WithEvents rd_resumen As System.Windows.Forms.RadioButton
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents btn_actualiza As System.Windows.Forms.Button
    Friend WithEvents dtg_ventas As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_al As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_del As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents col_factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_total As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
