<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ingresoalm
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
        Me.txt_exidest = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_grabar = New System.Windows.Forms.Button
        Me.btn_nuevo = New System.Windows.Forms.Button
        Me.txt_cantidad = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_nomdest = New System.Windows.Forms.TextBox
        Me.txt_almdes = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_descripcion = New System.Windows.Forms.TextBox
        Me.txt_codigo = New System.Windows.Forms.TextBox
        Me.txt_orden = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txt_exidest
        '
        Me.txt_exidest.Location = New System.Drawing.Point(618, 177)
        Me.txt_exidest.Name = "txt_exidest"
        Me.txt_exidest.ReadOnly = True
        Me.txt_exidest.Size = New System.Drawing.Size(100, 20)
        Me.txt_exidest.TabIndex = 303
        Me.txt_exidest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(663, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 307
        Me.Label8.Text = "Existencia"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Enabled = False
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(76, 264)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(101, 20)
        Me.dtp_fecha.TabIndex = 305
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(235, 70)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(99, 36)
        Me.btn_cancelar.TabIndex = 293
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_grabar
        '
        Me.btn_grabar.Location = New System.Drawing.Point(130, 70)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(99, 36)
        Me.btn_grabar.TabIndex = 292
        Me.btn_grabar.Text = "Grabar"
        Me.btn_grabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(25, 70)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(99, 36)
        Me.btn_nuevo.TabIndex = 290
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(540, 233)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(100, 20)
        Me.txt_cantidad.TabIndex = 306
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(405, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 16)
        Me.Label6.TabIndex = 304
        Me.Label6.Text = "Cantidad a trasladar:"
        '
        'txt_nomdest
        '
        Me.txt_nomdest.Location = New System.Drawing.Point(217, 177)
        Me.txt_nomdest.Name = "txt_nomdest"
        Me.txt_nomdest.Size = New System.Drawing.Size(395, 20)
        Me.txt_nomdest.TabIndex = 302
        '
        'txt_almdes
        '
        Me.txt_almdes.Location = New System.Drawing.Point(107, 177)
        Me.txt_almdes.Name = "txt_almdes"
        Me.txt_almdes.Size = New System.Drawing.Size(100, 20)
        Me.txt_almdes.TabIndex = 301
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 300
        Me.Label5.Text = "Almacen destino:"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(223, 130)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(419, 20)
        Me.txt_descripcion.TabIndex = 296
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(80, 130)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(125, 20)
        Me.txt_codigo.TabIndex = 294
        '
        'txt_orden
        '
        Me.txt_orden.Location = New System.Drawing.Point(557, 22)
        Me.txt_orden.Name = "txt_orden"
        Me.txt_orden.ReadOnly = True
        Me.txt_orden.Size = New System.Drawing.Size(95, 20)
        Me.txt_orden.TabIndex = 288
        Me.txt_orden.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(512, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 291
        Me.Label2.Text = "Orden:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 20)
        Me.Label1.TabIndex = 289
        Me.Label1.Text = "Ingreso de mercaderia a almacen"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 308
        Me.Label7.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 309
        Me.Label3.Text = "Articulo:"
        '
        'frm_ingresoalm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 338)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_exidest)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_grabar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_nomdest)
        Me.Controls.Add(Me.txt_almdes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.txt_orden)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_ingresoalm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de mercaderia a almacen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_exidest As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_grabar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents txt_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_nomdest As System.Windows.Forms.TextBox
    Friend WithEvents txt_almdes As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents txt_orden As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
