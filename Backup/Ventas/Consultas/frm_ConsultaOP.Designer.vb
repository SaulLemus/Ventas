<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConsultaOP
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rd_inventario = New System.Windows.Forms.RadioButton
        Me.rd_documentos = New System.Windows.Forms.RadioButton
        Me.rd_maestros = New System.Windows.Forms.RadioButton
        Me.rd_todo = New System.Windows.Forms.RadioButton
        Me.dtg_log = New System.Windows.Forms.DataGridView
        Me.cmb_usuario = New System.Windows.Forms.ComboBox
        Me.btn_actualizar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtp_del = New System.Windows.Forms.DateTimePicker
        Me.dtp_al = New System.Windows.Forms.DateTimePicker
        Me.cmb_orden_usr = New System.Windows.Forms.ComboBox
        Me.Col_Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_urin = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_equipo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_modulo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_registro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtg_log, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        Me.Label1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rd_inventario)
        Me.GroupBox1.Controls.Add(Me.rd_documentos)
        Me.GroupBox1.Controls.Add(Me.rd_maestros)
        Me.GroupBox1.Controls.Add(Me.rd_todo)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 54)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de registro"
        '
        'rd_inventario
        '
        Me.rd_inventario.AutoSize = True
        Me.rd_inventario.Location = New System.Drawing.Point(324, 26)
        Me.rd_inventario.Name = "rd_inventario"
        Me.rd_inventario.Size = New System.Drawing.Size(72, 17)
        Me.rd_inventario.TabIndex = 3
        Me.rd_inventario.TabStop = True
        Me.rd_inventario.Text = "Inventario"
        Me.rd_inventario.UseVisualStyleBackColor = True
        '
        'rd_documentos
        '
        Me.rd_documentos.AutoSize = True
        Me.rd_documentos.Location = New System.Drawing.Point(217, 26)
        Me.rd_documentos.Name = "rd_documentos"
        Me.rd_documentos.Size = New System.Drawing.Size(85, 17)
        Me.rd_documentos.TabIndex = 2
        Me.rd_documentos.TabStop = True
        Me.rd_documentos.Text = "Documentos"
        Me.rd_documentos.UseVisualStyleBackColor = True
        '
        'rd_maestros
        '
        Me.rd_maestros.AutoSize = True
        Me.rd_maestros.Location = New System.Drawing.Point(133, 26)
        Me.rd_maestros.Name = "rd_maestros"
        Me.rd_maestros.Size = New System.Drawing.Size(68, 17)
        Me.rd_maestros.TabIndex = 1
        Me.rd_maestros.TabStop = True
        Me.rd_maestros.Text = "Maestros"
        Me.rd_maestros.UseVisualStyleBackColor = True
        '
        'rd_todo
        '
        Me.rd_todo.AutoSize = True
        Me.rd_todo.Location = New System.Drawing.Point(36, 26)
        Me.rd_todo.Name = "rd_todo"
        Me.rd_todo.Size = New System.Drawing.Size(55, 17)
        Me.rd_todo.TabIndex = 0
        Me.rd_todo.TabStop = True
        Me.rd_todo.Text = "Todos"
        Me.rd_todo.UseVisualStyleBackColor = True
        '
        'dtg_log
        '
        Me.dtg_log.AllowUserToAddRows = False
        Me.dtg_log.AllowUserToDeleteRows = False
        Me.dtg_log.AllowUserToOrderColumns = True
        Me.dtg_log.AllowUserToResizeColumns = False
        Me.dtg_log.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtg_log.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtg_log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_log.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_Usuario, Me.col_urin, Me.Col_nombre, Me.col_equipo, Me.col_modulo, Me.col_fecha, Me.col_registro})
        Me.dtg_log.Location = New System.Drawing.Point(12, 164)
        Me.dtg_log.Name = "dtg_log"
        Me.dtg_log.Size = New System.Drawing.Size(1211, 451)
        Me.dtg_log.TabIndex = 2
        '
        'cmb_usuario
        '
        Me.cmb_usuario.FormattingEnabled = True
        Me.cmb_usuario.Location = New System.Drawing.Point(77, 40)
        Me.cmb_usuario.Name = "cmb_usuario"
        Me.cmb_usuario.Size = New System.Drawing.Size(224, 21)
        Me.cmb_usuario.TabIndex = 3
        Me.cmb_usuario.Visible = False
        '
        'btn_actualizar
        '
        Me.btn_actualizar.Location = New System.Drawing.Point(510, 123)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(184, 24)
        Me.btn_actualizar.TabIndex = 4
        Me.btn_actualizar.Text = "Actualizar"
        Me.btn_actualizar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(397, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha del:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(619, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha al:"
        '
        'dtp_del
        '
        Me.dtp_del.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_del.Location = New System.Drawing.Point(456, 46)
        Me.dtp_del.MaxDate = New Date(2058, 12, 31, 0, 0, 0, 0)
        Me.dtp_del.MinDate = New Date(2018, 1, 1, 0, 0, 0, 0)
        Me.dtp_del.Name = "dtp_del"
        Me.dtp_del.Size = New System.Drawing.Size(109, 20)
        Me.dtp_del.TabIndex = 7
        Me.dtp_del.Value = New Date(2018, 10, 15, 0, 0, 0, 0)
        '
        'dtp_al
        '
        Me.dtp_al.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_al.Location = New System.Drawing.Point(676, 46)
        Me.dtp_al.MaxDate = New Date(2058, 12, 31, 0, 0, 0, 0)
        Me.dtp_al.MinDate = New Date(2018, 1, 1, 0, 0, 0, 0)
        Me.dtp_al.Name = "dtp_al"
        Me.dtp_al.Size = New System.Drawing.Size(109, 20)
        Me.dtp_al.TabIndex = 8
        Me.dtp_al.Value = New Date(2018, 10, 15, 0, 0, 0, 0)
        '
        'cmb_orden_usr
        '
        Me.cmb_orden_usr.FormattingEnabled = True
        Me.cmb_orden_usr.Location = New System.Drawing.Point(307, 41)
        Me.cmb_orden_usr.Name = "cmb_orden_usr"
        Me.cmb_orden_usr.Size = New System.Drawing.Size(45, 21)
        Me.cmb_orden_usr.TabIndex = 9
        Me.cmb_orden_usr.Visible = False
        '
        'Col_Usuario
        '
        Me.Col_Usuario.HeaderText = "Usuario Sistema"
        Me.Col_Usuario.MaxInputLength = 25
        Me.Col_Usuario.Name = "Col_Usuario"
        Me.Col_Usuario.ReadOnly = True
        '
        'col_urin
        '
        Me.col_urin.HeaderText = "Usuario Windows"
        Me.col_urin.MaxInputLength = 25
        Me.col_urin.Name = "col_urin"
        Me.col_urin.ReadOnly = True
        '
        'Col_nombre
        '
        Me.Col_nombre.HeaderText = "Nombre"
        Me.Col_nombre.MaxInputLength = 50
        Me.Col_nombre.Name = "Col_nombre"
        Me.Col_nombre.ReadOnly = True
        Me.Col_nombre.Width = 200
        '
        'col_equipo
        '
        Me.col_equipo.HeaderText = "Equipo"
        Me.col_equipo.MaxInputLength = 25
        Me.col_equipo.Name = "col_equipo"
        Me.col_equipo.ReadOnly = True
        Me.col_equipo.Width = 110
        '
        'col_modulo
        '
        Me.col_modulo.HeaderText = "Modulo"
        Me.col_modulo.MaxInputLength = 50
        Me.col_modulo.Name = "col_modulo"
        Me.col_modulo.ReadOnly = True
        Me.col_modulo.Width = 115
        '
        'col_fecha
        '
        Me.col_fecha.HeaderText = "Fecha"
        Me.col_fecha.MaxInputLength = 25
        Me.col_fecha.Name = "col_fecha"
        Me.col_fecha.ReadOnly = True
        Me.col_fecha.Width = 150
        '
        'col_registro
        '
        Me.col_registro.HeaderText = "Registro"
        Me.col_registro.MaxInputLength = 20
        Me.col_registro.Name = "col_registro"
        Me.col_registro.ReadOnly = True
        Me.col_registro.Width = 375
        '
        'frm_ConsultaOP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1237, 624)
        Me.Controls.Add(Me.cmb_orden_usr)
        Me.Controls.Add(Me.dtp_al)
        Me.Controls.Add(Me.dtp_del)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_actualizar)
        Me.Controls.Add(Me.cmb_usuario)
        Me.Controls.Add(Me.dtg_log)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_ConsultaOP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de operaciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtg_log, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rd_inventario As System.Windows.Forms.RadioButton
    Friend WithEvents rd_documentos As System.Windows.Forms.RadioButton
    Friend WithEvents rd_maestros As System.Windows.Forms.RadioButton
    Friend WithEvents rd_todo As System.Windows.Forms.RadioButton
    Friend WithEvents dtg_log As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_usuario As System.Windows.Forms.ComboBox
    Friend WithEvents btn_actualizar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_del As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_al As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_orden_usr As System.Windows.Forms.ComboBox
    Friend WithEvents Col_Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_urin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_equipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_modulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_registro As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
