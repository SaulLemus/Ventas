<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_con_salman
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_con_salman))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btn_imprimir = New System.Windows.Forms.Button
        Me.btn_actualiza = New System.Windows.Forms.Button
        Me.dtg_kardex = New System.Windows.Forms.DataGridView
        Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_tipodoc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colNumero = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txt_ref2 = New System.Windows.Forms.TextBox
        Me.txt_ref1 = New System.Windows.Forms.TextBox
        Me.lbl_ref2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbl_ref1 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.dtg_kardex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.Location = New System.Drawing.Point(712, 55)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(63, 51)
        Me.btn_imprimir.TabIndex = 252
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_imprimir.UseVisualStyleBackColor = True
        Me.btn_imprimir.Visible = False
        '
        'btn_actualiza
        '
        Me.btn_actualiza.Location = New System.Drawing.Point(116, 83)
        Me.btn_actualiza.Name = "btn_actualiza"
        Me.btn_actualiza.Size = New System.Drawing.Size(95, 23)
        Me.btn_actualiza.TabIndex = 251
        Me.btn_actualiza.Text = "Actualizar"
        Me.btn_actualiza.UseVisualStyleBackColor = True
        '
        'dtg_kardex
        '
        Me.dtg_kardex.AllowUserToAddRows = False
        Me.dtg_kardex.AllowUserToDeleteRows = False
        Me.dtg_kardex.AllowUserToResizeColumns = False
        Me.dtg_kardex.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_kardex.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dtg_kardex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_kardex.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_codigo, Me.col_descripcion, Me.col_tipodoc, Me.colNumero, Me.col_fecha, Me.col_cantidad})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtg_kardex.DefaultCellStyle = DataGridViewCellStyle7
        Me.dtg_kardex.Location = New System.Drawing.Point(9, 120)
        Me.dtg_kardex.Name = "dtg_kardex"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_kardex.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dtg_kardex.Size = New System.Drawing.Size(911, 362)
        Me.dtg_kardex.TabIndex = 250
        '
        'col_codigo
        '
        Me.col_codigo.Frozen = True
        Me.col_codigo.HeaderText = "Codigo"
        Me.col_codigo.Name = "col_codigo"
        Me.col_codigo.ReadOnly = True
        Me.col_codigo.Width = 150
        '
        'col_descripcion
        '
        Me.col_descripcion.HeaderText = "Descripcion"
        Me.col_descripcion.Name = "col_descripcion"
        Me.col_descripcion.ReadOnly = True
        Me.col_descripcion.Width = 300
        '
        'col_tipodoc
        '
        Me.col_tipodoc.HeaderText = "TipoDoc"
        Me.col_tipodoc.Name = "col_tipodoc"
        Me.col_tipodoc.ReadOnly = True
        Me.col_tipodoc.Width = 75
        '
        'colNumero
        '
        Me.colNumero.HeaderText = "Numero"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.ReadOnly = True
        '
        'col_fecha
        '
        DataGridViewCellStyle6.Format = "G"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.col_fecha.DefaultCellStyle = DataGridViewCellStyle6
        Me.col_fecha.HeaderText = "Fecha"
        Me.col_fecha.Name = "col_fecha"
        Me.col_fecha.ReadOnly = True
        Me.col_fecha.Width = 150
        '
        'col_cantidad
        '
        Me.col_cantidad.HeaderText = "Cantidad"
        Me.col_cantidad.Name = "col_cantidad"
        Me.col_cantidad.ReadOnly = True
        Me.col_cantidad.Width = 75
        '
        'txt_ref2
        '
        Me.txt_ref2.Location = New System.Drawing.Point(116, 42)
        Me.txt_ref2.Name = "txt_ref2"
        Me.txt_ref2.Size = New System.Drawing.Size(99, 20)
        Me.txt_ref2.TabIndex = 249
        Me.txt_ref2.Visible = False
        '
        'txt_ref1
        '
        Me.txt_ref1.Location = New System.Drawing.Point(116, 8)
        Me.txt_ref1.Name = "txt_ref1"
        Me.txt_ref1.Size = New System.Drawing.Size(100, 20)
        Me.txt_ref1.TabIndex = 248
        '
        'lbl_ref2
        '
        Me.lbl_ref2.Location = New System.Drawing.Point(220, 42)
        Me.lbl_ref2.Name = "lbl_ref2"
        Me.lbl_ref2.Size = New System.Drawing.Size(492, 23)
        Me.lbl_ref2.TabIndex = 247
        Me.lbl_ref2.Text = "."
        Me.lbl_ref2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 246
        Me.Label3.Text = "Articulo al:"
        Me.Label3.Visible = False
        '
        'lbl_ref1
        '
        Me.lbl_ref1.Location = New System.Drawing.Point(220, 7)
        Me.lbl_ref1.Name = "lbl_ref1"
        Me.lbl_ref1.Size = New System.Drawing.Size(494, 23)
        Me.lbl_ref1.TabIndex = 245
        Me.lbl_ref1.Text = "."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 244
        Me.Label1.Text = "Articulo del:"
        '
        'frm_con_salman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 489)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.btn_actualiza)
        Me.Controls.Add(Me.dtg_kardex)
        Me.Controls.Add(Me.txt_ref2)
        Me.Controls.Add(Me.txt_ref1)
        Me.Controls.Add(Me.lbl_ref2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_ref1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_con_salman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta salidas manuales"
        CType(Me.dtg_kardex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents btn_actualiza As System.Windows.Forms.Button
    Friend WithEvents dtg_kardex As System.Windows.Forms.DataGridView
    Friend WithEvents col_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_tipodoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_ref2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_ref1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ref2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_ref1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
