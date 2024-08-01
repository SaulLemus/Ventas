<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_bus_almacen
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
        Me.dtg = New System.Windows.Forms.DataGridView
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.lbl_descripcion = New System.Windows.Forms.Label
        Me.txt_codigo = New System.Windows.Forms.TextBox
        Me.lbl_codigo = New System.Windows.Forms.Label
        Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_descipcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_existencia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_orden = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtg
        '
        Me.dtg.AllowUserToAddRows = False
        Me.dtg.AllowUserToDeleteRows = False
        Me.dtg.AllowUserToResizeColumns = False
        Me.dtg.AllowUserToResizeRows = False
        Me.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_codigo, Me.col_descipcion, Me.col_existencia, Me.col_orden})
        Me.dtg.Location = New System.Drawing.Point(5, 38)
        Me.dtg.Name = "dtg"
        Me.dtg.Size = New System.Drawing.Size(640, 465)
        Me.dtg.TabIndex = 24
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(252, 9)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(292, 20)
        Me.txt_nombre.TabIndex = 23
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(188, 12)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(66, 13)
        Me.lbl_descripcion.TabIndex = 22
        Me.lbl_descripcion.Text = "Descripcion:"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(53, 8)
        Me.txt_codigo.MaxLength = 15
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(99, 20)
        Me.txt_codigo.TabIndex = 21
        '
        'lbl_codigo
        '
        Me.lbl_codigo.AutoSize = True
        Me.lbl_codigo.Location = New System.Drawing.Point(8, 12)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(43, 13)
        Me.lbl_codigo.TabIndex = 20
        Me.lbl_codigo.Text = "Codigo:"
        '
        'col_codigo
        '
        Me.col_codigo.HeaderText = "Codigo"
        Me.col_codigo.MaxInputLength = 15
        Me.col_codigo.Name = "col_codigo"
        Me.col_codigo.ReadOnly = True
        '
        'col_descipcion
        '
        Me.col_descipcion.HeaderText = "Descripcion"
        Me.col_descipcion.MaxInputLength = 100
        Me.col_descipcion.Name = "col_descipcion"
        Me.col_descipcion.ReadOnly = True
        Me.col_descipcion.Width = 375
        '
        'col_existencia
        '
        Me.col_existencia.HeaderText = "Existencia"
        Me.col_existencia.MaxInputLength = 10
        Me.col_existencia.Name = "col_existencia"
        Me.col_existencia.ReadOnly = True
        Me.col_existencia.Visible = False
        '
        'col_orden
        '
        Me.col_orden.HeaderText = "Orden"
        Me.col_orden.Name = "col_orden"
        Me.col_orden.ReadOnly = True
        Me.col_orden.Visible = False
        '
        'frm_bus_almacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 511)
        Me.Controls.Add(Me.dtg)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lbl_descripcion)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.lbl_codigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_bus_almacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de almacen"
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtg As System.Windows.Forms.DataGridView
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_descripcion As System.Windows.Forms.Label
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_codigo As System.Windows.Forms.Label
    Friend WithEvents col_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_descipcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_existencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_orden As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
