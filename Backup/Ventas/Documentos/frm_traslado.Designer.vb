<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_traslado
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_orden = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_codigo = New System.Windows.Forms.TextBox
        Me.txt_descripcion = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_almOrig = New System.Windows.Forms.TextBox
        Me.txt_nomorig = New System.Windows.Forms.TextBox
        Me.txt_nomdest = New System.Windows.Forms.TextBox
        Me.txt_almdes = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_cantidad = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_grabar = New System.Windows.Forms.Button
        Me.btn_nuevo = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_exiorig = New System.Windows.Forms.TextBox
        Me.txt_exidest = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Traslado de mercaderia entre almacenes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(511, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Orden:"
        '
        'txt_orden
        '
        Me.txt_orden.Location = New System.Drawing.Point(556, 21)
        Me.txt_orden.Name = "txt_orden"
        Me.txt_orden.ReadOnly = True
        Me.txt_orden.Size = New System.Drawing.Size(95, 20)
        Me.txt_orden.TabIndex = 0
        Me.txt_orden.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Articulo:"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(77, 129)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(125, 20)
        Me.txt_codigo.TabIndex = 5
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(220, 129)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(419, 20)
        Me.txt_descripcion.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Almacen origen:"
        '
        'txt_almOrig
        '
        Me.txt_almOrig.Location = New System.Drawing.Point(106, 173)
        Me.txt_almOrig.Name = "txt_almOrig"
        Me.txt_almOrig.Size = New System.Drawing.Size(100, 20)
        Me.txt_almOrig.TabIndex = 7
        '
        'txt_nomorig
        '
        Me.txt_nomorig.Location = New System.Drawing.Point(216, 173)
        Me.txt_nomorig.Name = "txt_nomorig"
        Me.txt_nomorig.Size = New System.Drawing.Size(395, 20)
        Me.txt_nomorig.TabIndex = 8
        '
        'txt_nomdest
        '
        Me.txt_nomdest.Location = New System.Drawing.Point(216, 208)
        Me.txt_nomdest.Name = "txt_nomdest"
        Me.txt_nomdest.Size = New System.Drawing.Size(395, 20)
        Me.txt_nomdest.TabIndex = 11
        '
        'txt_almdes
        '
        Me.txt_almdes.Location = New System.Drawing.Point(106, 208)
        Me.txt_almdes.Name = "txt_almdes"
        Me.txt_almdes.Size = New System.Drawing.Size(100, 20)
        Me.txt_almdes.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Almacen destino:"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(539, 264)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(100, 20)
        Me.txt_cantidad.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(404, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cantidad a trasladar:"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(234, 69)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(99, 36)
        Me.btn_cancelar.TabIndex = 3
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_grabar
        '
        Me.btn_grabar.Location = New System.Drawing.Point(129, 69)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(99, 36)
        Me.btn_grabar.TabIndex = 2
        Me.btn_grabar.Text = "Grabar"
        Me.btn_grabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(24, 69)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(99, 36)
        Me.btn_nuevo.TabIndex = 1
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 285
        Me.Label7.Text = "Fecha:"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Enabled = False
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(77, 263)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(101, 20)
        Me.dtp_fecha.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(658, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 287
        Me.Label8.Text = "Existencia"
        '
        'txt_exiorig
        '
        Me.txt_exiorig.Location = New System.Drawing.Point(617, 172)
        Me.txt_exiorig.Name = "txt_exiorig"
        Me.txt_exiorig.ReadOnly = True
        Me.txt_exiorig.Size = New System.Drawing.Size(100, 20)
        Me.txt_exiorig.TabIndex = 9
        Me.txt_exiorig.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_exidest
        '
        Me.txt_exidest.Location = New System.Drawing.Point(617, 208)
        Me.txt_exidest.Name = "txt_exidest"
        Me.txt_exidest.ReadOnly = True
        Me.txt_exidest.Size = New System.Drawing.Size(100, 20)
        Me.txt_exidest.TabIndex = 12
        Me.txt_exidest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frm_traslado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 348)
        Me.Controls.Add(Me.txt_exidest)
        Me.Controls.Add(Me.txt_exiorig)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_grabar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_nomdest)
        Me.Controls.Add(Me.txt_almdes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_nomorig)
        Me.Controls.Add(Me.txt_almOrig)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_orden)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_traslado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Traslado de almacen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_orden As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_almOrig As System.Windows.Forms.TextBox
    Friend WithEvents txt_nomorig As System.Windows.Forms.TextBox
    Friend WithEvents txt_nomdest As System.Windows.Forms.TextBox
    Friend WithEvents txt_almdes As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_grabar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_exiorig As System.Windows.Forms.TextBox
    Friend WithEvents txt_exidest As System.Windows.Forms.TextBox
End Class
