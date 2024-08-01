<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cons_ventas_cli
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cons_ventas_cli))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btn_actualiza = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dtp_al = New System.Windows.Forms.DateTimePicker
        Me.dtp_del = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbl_ref2 = New System.Windows.Forms.Label
        Me.lbl_ref1 = New System.Windows.Forms.Label
        Me.txt_ref2 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_ref1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtg_ventas = New System.Windows.Forms.DataGridView
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rd_detalle = New System.Windows.Forms.RadioButton
        Me.rd_resumen = New System.Windows.Forms.RadioButton
        Me.btn_imprimir = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.col_vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_factura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Col_fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_total = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtg_ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_actualiza
        '
        Me.btn_actualiza.Location = New System.Drawing.Point(388, 138)
        Me.btn_actualiza.Name = "btn_actualiza"
        Me.btn_actualiza.Size = New System.Drawing.Size(145, 23)
        Me.btn_actualiza.TabIndex = 7
        Me.btn_actualiza.Text = "Actualizar"
        Me.btn_actualiza.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtp_al)
        Me.GroupBox2.Controls.Add(Me.dtp_del)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(370, 44)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fechas"
        '
        'dtp_al
        '
        Me.dtp_al.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_al.Location = New System.Drawing.Point(224, 14)
        Me.dtp_al.Name = "dtp_al"
        Me.dtp_al.Size = New System.Drawing.Size(118, 20)
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
        Me.Label2.Location = New System.Drawing.Point(202, 18)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lbl_ref2)
        Me.GroupBox1.Controls.Add(Me.lbl_ref1)
        Me.GroupBox1.Controls.Add(Me.txt_ref2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_ref1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(811, 94)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de consulta"
        '
        'lbl_ref2
        '
        Me.lbl_ref2.Location = New System.Drawing.Point(243, 51)
        Me.lbl_ref2.Name = "lbl_ref2"
        Me.lbl_ref2.Size = New System.Drawing.Size(451, 23)
        Me.lbl_ref2.TabIndex = 9
        Me.lbl_ref2.Text = "."
        '
        'lbl_ref1
        '
        Me.lbl_ref1.Location = New System.Drawing.Point(245, 21)
        Me.lbl_ref1.Name = "lbl_ref1"
        Me.lbl_ref1.Size = New System.Drawing.Size(451, 23)
        Me.lbl_ref1.TabIndex = 8
        Me.lbl_ref1.Text = "."
        '
        'txt_ref2
        '
        Me.txt_ref2.Location = New System.Drawing.Point(138, 54)
        Me.txt_ref2.Name = "txt_ref2"
        Me.txt_ref2.Size = New System.Drawing.Size(99, 20)
        Me.txt_ref2.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Referencia"
        '
        'txt_ref1
        '
        Me.txt_ref1.Location = New System.Drawing.Point(138, 21)
        Me.txt_ref1.Name = "txt_ref1"
        Me.txt_ref1.Size = New System.Drawing.Size(100, 20)
        Me.txt_ref1.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(265, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Al:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(115, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "del:"
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
        Me.dtg_ventas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_vendedor, Me.col_factura, Me.Col_fecha, Me.col_codigo, Me.col_cliente, Me.col_total})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtg_ventas.DefaultCellStyle = DataGridViewCellStyle5
        Me.dtg_ventas.Location = New System.Drawing.Point(13, 180)
        Me.dtg_ventas.Name = "dtg_ventas"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_ventas.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dtg_ventas.Size = New System.Drawing.Size(809, 412)
        Me.dtg_ventas.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rd_detalle)
        Me.GroupBox3.Controls.Add(Me.rd_resumen)
        Me.GroupBox3.Location = New System.Drawing.Point(554, 122)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(190, 40)
        Me.GroupBox3.TabIndex = 236
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Presentacion"
        '
        'rd_detalle
        '
        Me.rd_detalle.AutoSize = True
        Me.rd_detalle.Location = New System.Drawing.Point(112, 17)
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
        Me.btn_imprimir.Location = New System.Drawing.Point(757, 117)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(63, 51)
        Me.btn_imprimir.TabIndex = 235
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_imprimir.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Referencia"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(115, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "al:"
        '
        'col_vendedor
        '
        Me.col_vendedor.HeaderText = "Cliente"
        Me.col_vendedor.Name = "col_vendedor"
        Me.col_vendedor.ReadOnly = True
        Me.col_vendedor.Visible = False
        Me.col_vendedor.Width = 125
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
        Me.col_cliente.Width = 250
        '
        'col_total
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col_total.DefaultCellStyle = DataGridViewCellStyle4
        Me.col_total.HeaderText = "Total"
        Me.col_total.Name = "col_total"
        Me.col_total.ReadOnly = True
        '
        'frm_cons_ventas_cli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 619)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.dtg_ventas)
        Me.Controls.Add(Me.btn_actualiza)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_cons_ventas_cli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de ventas por cliente"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtg_ventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_actualiza As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_al As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_del As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_ref2 As System.Windows.Forms.Label
    Friend WithEvents lbl_ref1 As System.Windows.Forms.Label
    Friend WithEvents txt_ref2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_ref1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtg_ventas As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rd_detalle As System.Windows.Forms.RadioButton
    Friend WithEvents rd_resumen As System.Windows.Forms.RadioButton
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents col_vendedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_total As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
