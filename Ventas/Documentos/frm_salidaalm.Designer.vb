<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_salidaalm
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_grabar = New System.Windows.Forms.Button
        Me.btn_nuevo = New System.Windows.Forms.Button
        Me.txt_cantidad = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_descripcion = New System.Windows.Forms.TextBox
        Me.txt_codigo = New System.Windows.Forms.TextBox
        Me.txt_orden = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_exiorig = New System.Windows.Forms.TextBox
        Me.txt_nomorig = New System.Windows.Forms.TextBox
        Me.txt_almOrig = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 327
        Me.Label3.Text = "Articulo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 326
        Me.Label7.Text = "Fecha:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(682, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 325
        Me.Label8.Text = "Existencia"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Enabled = False
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(95, 276)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(101, 20)
        Me.dtp_fecha.TabIndex = 323
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(254, 82)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(99, 36)
        Me.btn_cancelar.TabIndex = 315
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_grabar
        '
        Me.btn_grabar.Location = New System.Drawing.Point(149, 82)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(99, 36)
        Me.btn_grabar.TabIndex = 314
        Me.btn_grabar.Text = "Grabar"
        Me.btn_grabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(44, 82)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(99, 36)
        Me.btn_nuevo.TabIndex = 312
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(559, 245)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(100, 20)
        Me.txt_cantidad.TabIndex = 324
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(448, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 16)
        Me.Label6.TabIndex = 322
        Me.Label6.Text = "Cantidad salida:"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(242, 142)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(419, 20)
        Me.txt_descripcion.TabIndex = 317
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(99, 142)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(125, 20)
        Me.txt_codigo.TabIndex = 316
        '
        'txt_orden
        '
        Me.txt_orden.Location = New System.Drawing.Point(576, 34)
        Me.txt_orden.Name = "txt_orden"
        Me.txt_orden.ReadOnly = True
        Me.txt_orden.Size = New System.Drawing.Size(95, 20)
        Me.txt_orden.TabIndex = 310
        Me.txt_orden.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(531, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 313
        Me.Label2.Text = "Orden:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 20)
        Me.Label1.TabIndex = 311
        Me.Label1.Text = "Salida de mercaderia a almacen"
        '
        'txt_exiorig
        '
        Me.txt_exiorig.Location = New System.Drawing.Point(632, 190)
        Me.txt_exiorig.Name = "txt_exiorig"
        Me.txt_exiorig.ReadOnly = True
        Me.txt_exiorig.Size = New System.Drawing.Size(100, 20)
        Me.txt_exiorig.TabIndex = 331
        Me.txt_exiorig.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_nomorig
        '
        Me.txt_nomorig.Location = New System.Drawing.Point(231, 191)
        Me.txt_nomorig.Name = "txt_nomorig"
        Me.txt_nomorig.Size = New System.Drawing.Size(395, 20)
        Me.txt_nomorig.TabIndex = 330
        '
        'txt_almOrig
        '
        Me.txt_almOrig.Location = New System.Drawing.Point(121, 191)
        Me.txt_almOrig.Name = "txt_almOrig"
        Me.txt_almOrig.Size = New System.Drawing.Size(100, 20)
        Me.txt_almOrig.TabIndex = 329
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 328
        Me.Label4.Text = "Almacen origen:"
        '
        'frm_salidaalm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 328)
        Me.Controls.Add(Me.txt_exiorig)
        Me.Controls.Add(Me.txt_nomorig)
        Me.Controls.Add(Me.txt_almOrig)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_grabar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.txt_orden)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_salidaalm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salida de almacen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_grabar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents txt_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents txt_orden As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_exiorig As System.Windows.Forms.TextBox
    Friend WithEvents txt_nomorig As System.Windows.Forms.TextBox
    Friend WithEvents txt_almOrig As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
