<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_bus_lista
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
        Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_descipcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_codigo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
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
        Me.dtg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_codigo, Me.col_descipcion, Me.col_tipo})
        Me.dtg.Location = New System.Drawing.Point(9, 42)
        Me.dtg.Name = "dtg"
        Me.dtg.Size = New System.Drawing.Size(638, 465)
        Me.dtg.TabIndex = 19
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
        'col_tipo
        '
        Me.col_tipo.HeaderText = "Tipo"
        Me.col_tipo.MaxInputLength = 15
        Me.col_tipo.Name = "col_tipo"
        Me.col_tipo.ReadOnly = True
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(256, 13)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(292, 20)
        Me.txt_nombre.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Descripcion:"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(57, 12)
        Me.txt_codigo.MaxLength = 15
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(99, 20)
        Me.txt_codigo.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Codigo:"
        '
        'frm_bus_lista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 521)
        Me.Controls.Add(Me.dtg)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_bus_lista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda listas de precios"
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtg As System.Windows.Forms.DataGridView
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents col_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_descipcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_tipo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
