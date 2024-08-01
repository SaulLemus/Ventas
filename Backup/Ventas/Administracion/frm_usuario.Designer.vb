<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_usuario
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
        Me.chk_activo = New System.Windows.Forms.CheckBox
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.btn_eliminar = New System.Windows.Forms.Button
        Me.btn_grabar = New System.Windows.Forms.Button
        Me.btn_modifica = New System.Windows.Forms.Button
        Me.btn_nuevo = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rd_facturador = New System.Windows.Forms.RadioButton
        Me.rd_bodega = New System.Windows.Forms.RadioButton
        Me.rd_ventas = New System.Windows.Forms.RadioButton
        Me.rd_admin = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_clave1 = New System.Windows.Forms.TextBox
        Me.txt_clave = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.txt_codigo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_orden = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.rd_produccion = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chk_activo
        '
        Me.chk_activo.AutoSize = True
        Me.chk_activo.Location = New System.Drawing.Point(618, 119)
        Me.chk_activo.Name = "chk_activo"
        Me.chk_activo.Size = New System.Drawing.Size(56, 17)
        Me.chk_activo.TabIndex = 146
        Me.chk_activo.Text = "Activo"
        Me.chk_activo.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(328, 45)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(99, 36)
        Me.btn_cancelar.TabIndex = 133
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(429, 45)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(99, 36)
        Me.btn_buscar.TabIndex = 134
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(544, 45)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(99, 36)
        Me.btn_eliminar.TabIndex = 132
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_eliminar.UseVisualStyleBackColor = True
        Me.btn_eliminar.Visible = False
        '
        'btn_grabar
        '
        Me.btn_grabar.Location = New System.Drawing.Point(226, 44)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(99, 36)
        Me.btn_grabar.TabIndex = 131
        Me.btn_grabar.Text = "Grabar"
        Me.btn_grabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'btn_modifica
        '
        Me.btn_modifica.Location = New System.Drawing.Point(126, 44)
        Me.btn_modifica.Name = "btn_modifica"
        Me.btn_modifica.Size = New System.Drawing.Size(99, 36)
        Me.btn_modifica.TabIndex = 130
        Me.btn_modifica.Text = "Modificar"
        Me.btn_modifica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_modifica.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(26, 44)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(99, 36)
        Me.btn_nuevo.TabIndex = 129
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rd_produccion)
        Me.GroupBox1.Controls.Add(Me.rd_facturador)
        Me.GroupBox1.Controls.Add(Me.rd_bodega)
        Me.GroupBox1.Controls.Add(Me.rd_ventas)
        Me.GroupBox1.Controls.Add(Me.rd_admin)
        Me.GroupBox1.Location = New System.Drawing.Point(155, 185)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 48)
        Me.GroupBox1.TabIndex = 145
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Perfil de usuario"
        '
        'rd_facturador
        '
        Me.rd_facturador.AutoSize = True
        Me.rd_facturador.Location = New System.Drawing.Point(299, 21)
        Me.rd_facturador.Name = "rd_facturador"
        Me.rd_facturador.Size = New System.Drawing.Size(76, 17)
        Me.rd_facturador.TabIndex = 14
        Me.rd_facturador.TabStop = True
        Me.rd_facturador.Text = "Facturador"
        Me.rd_facturador.UseVisualStyleBackColor = True
        '
        'rd_bodega
        '
        Me.rd_bodega.AutoSize = True
        Me.rd_bodega.Location = New System.Drawing.Point(209, 22)
        Me.rd_bodega.Name = "rd_bodega"
        Me.rd_bodega.Size = New System.Drawing.Size(62, 17)
        Me.rd_bodega.TabIndex = 13
        Me.rd_bodega.TabStop = True
        Me.rd_bodega.Text = "Bodega"
        Me.rd_bodega.UseVisualStyleBackColor = True
        '
        'rd_ventas
        '
        Me.rd_ventas.AutoSize = True
        Me.rd_ventas.Location = New System.Drawing.Point(131, 21)
        Me.rd_ventas.Name = "rd_ventas"
        Me.rd_ventas.Size = New System.Drawing.Size(58, 17)
        Me.rd_ventas.TabIndex = 12
        Me.rd_ventas.TabStop = True
        Me.rd_ventas.Text = "Ventas"
        Me.rd_ventas.UseVisualStyleBackColor = True
        '
        'rd_admin
        '
        Me.rd_admin.AutoSize = True
        Me.rd_admin.Location = New System.Drawing.Point(15, 21)
        Me.rd_admin.Name = "rd_admin"
        Me.rd_admin.Size = New System.Drawing.Size(88, 17)
        Me.rd_admin.TabIndex = 11
        Me.rd_admin.TabStop = True
        Me.rd_admin.Text = "Administrador"
        Me.rd_admin.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(256, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "Confirmar:"
        '
        'txt_clave1
        '
        Me.txt_clave1.Location = New System.Drawing.Point(313, 150)
        Me.txt_clave1.MaxLength = 15
        Me.txt_clave1.Name = "txt_clave1"
        Me.txt_clave1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_clave1.Size = New System.Drawing.Size(97, 20)
        Me.txt_clave1.TabIndex = 138
        '
        'txt_clave
        '
        Me.txt_clave.Location = New System.Drawing.Point(152, 150)
        Me.txt_clave.MaxLength = 15
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_clave.Size = New System.Drawing.Size(97, 20)
        Me.txt_clave.TabIndex = 137
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(112, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "Clave:"
        '
        'txt_nombre
        '
        Me.txt_nombre.BackColor = System.Drawing.Color.Honeydew
        Me.txt_nombre.Location = New System.Drawing.Point(153, 122)
        Me.txt_nombre.MaxLength = 50
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(348, 20)
        Me.txt_nombre.TabIndex = 136
        '
        'txt_codigo
        '
        Me.txt_codigo.BackColor = System.Drawing.Color.Honeydew
        Me.txt_codigo.Location = New System.Drawing.Point(153, 90)
        Me.txt_codigo.MaxLength = 10
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(76, 20)
        Me.txt_codigo.TabIndex = 135
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(103, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "Usuario:"
        '
        'txt_orden
        '
        Me.txt_orden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_orden.Location = New System.Drawing.Point(659, 17)
        Me.txt_orden.Name = "txt_orden"
        Me.txt_orden.ReadOnly = True
        Me.txt_orden.Size = New System.Drawing.Size(92, 21)
        Me.txt_orden.TabIndex = 140
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(613, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 19)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Orden:"
        '
        'rd_produccion
        '
        Me.rd_produccion.AutoSize = True
        Me.rd_produccion.Location = New System.Drawing.Point(389, 22)
        Me.rd_produccion.Name = "rd_produccion"
        Me.rd_produccion.Size = New System.Drawing.Size(79, 17)
        Me.rd_produccion.TabIndex = 15
        Me.rd_produccion.TabStop = True
        Me.rd_produccion.Text = "Produccion"
        Me.rd_produccion.UseVisualStyleBackColor = True
        '
        'frm_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(785, 328)
        Me.Controls.Add(Me.chk_activo)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_grabar)
        Me.Controls.Add(Me.btn_modifica)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_clave1)
        Me.Controls.Add(Me.txt_clave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_orden)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administracion de usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chk_activo As System.Windows.Forms.CheckBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_grabar As System.Windows.Forms.Button
    Friend WithEvents btn_modifica As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rd_facturador As System.Windows.Forms.RadioButton
    Friend WithEvents rd_bodega As System.Windows.Forms.RadioButton
    Friend WithEvents rd_ventas As System.Windows.Forms.RadioButton
    Friend WithEvents rd_admin As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_clave1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_clave As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_orden As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rd_produccion As System.Windows.Forms.RadioButton
End Class
