<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_bus_pedidocli
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
        Me.dtg = New System.Windows.Forms.DataGridView
        Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_descipcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_cotizacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cl_monto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_orden = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_estado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_codigo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.rd_pendientes = New System.Windows.Forms.RadioButton
        Me.rd_todos = New System.Windows.Forms.RadioButton
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
        Me.dtg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_codigo, Me.col_descipcion, Me.col_cotizacion, Me.col_fecha, Me.cl_monto, Me.col_orden, Me.col_estado})
        Me.dtg.Location = New System.Drawing.Point(16, 37)
        Me.dtg.Name = "dtg"
        Me.dtg.Size = New System.Drawing.Size(815, 465)
        Me.dtg.TabIndex = 24
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
        Me.col_descipcion.HeaderText = "Nombre"
        Me.col_descipcion.MaxInputLength = 100
        Me.col_descipcion.Name = "col_descipcion"
        Me.col_descipcion.ReadOnly = True
        Me.col_descipcion.Width = 250
        '
        'col_cotizacion
        '
        Me.col_cotizacion.HeaderText = "Pedido"
        Me.col_cotizacion.Name = "col_cotizacion"
        Me.col_cotizacion.ReadOnly = True
        '
        'col_fecha
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.col_fecha.DefaultCellStyle = DataGridViewCellStyle1
        Me.col_fecha.HeaderText = "Fecha"
        Me.col_fecha.Name = "col_fecha"
        Me.col_fecha.ReadOnly = True
        '
        'cl_monto
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.cl_monto.DefaultCellStyle = DataGridViewCellStyle2
        Me.cl_monto.HeaderText = "Monto"
        Me.cl_monto.Name = "cl_monto"
        Me.cl_monto.ReadOnly = True
        '
        'col_orden
        '
        Me.col_orden.HeaderText = "Orden"
        Me.col_orden.Name = "col_orden"
        Me.col_orden.ReadOnly = True
        Me.col_orden.Visible = False
        '
        'col_estado
        '
        Me.col_estado.HeaderText = "Estado"
        Me.col_estado.Name = "col_estado"
        Me.col_estado.ReadOnly = True
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(223, 7)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(309, 20)
        Me.txt_nombre.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(175, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Nombre:"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(59, 7)
        Me.txt_codigo.MaxLength = 15
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(99, 20)
        Me.txt_codigo.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Cliente:"
        '
        'rd_pendientes
        '
        Me.rd_pendientes.AutoSize = True
        Me.rd_pendientes.Location = New System.Drawing.Point(555, 7)
        Me.rd_pendientes.Name = "rd_pendientes"
        Me.rd_pendientes.Size = New System.Drawing.Size(78, 17)
        Me.rd_pendientes.TabIndex = 25
        Me.rd_pendientes.TabStop = True
        Me.rd_pendientes.Text = "Pendientes"
        Me.rd_pendientes.UseVisualStyleBackColor = True
        '
        'rd_todos
        '
        Me.rd_todos.AutoSize = True
        Me.rd_todos.Location = New System.Drawing.Point(651, 7)
        Me.rd_todos.Name = "rd_todos"
        Me.rd_todos.Size = New System.Drawing.Size(55, 17)
        Me.rd_todos.TabIndex = 26
        Me.rd_todos.TabStop = True
        Me.rd_todos.Text = "Todos"
        Me.rd_todos.UseVisualStyleBackColor = True
        '
        'frm_bus_pedidocli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 509)
        Me.Controls.Add(Me.rd_todos)
        Me.Controls.Add(Me.rd_pendientes)
        Me.Controls.Add(Me.dtg)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_bus_pedidocli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busca pedido cliente"
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtg As System.Windows.Forms.DataGridView
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rd_pendientes As System.Windows.Forms.RadioButton
    Friend WithEvents rd_todos As System.Windows.Forms.RadioButton
    Friend WithEvents col_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_descipcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cotizacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cl_monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_orden As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_estado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
