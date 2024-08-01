<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_articulo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_articulo))
        Me.btn_imprimir = New System.Windows.Forms.Button
        Me.txt_exiMax = New System.Windows.Forms.TextBox
        Me.txt_exiMin = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.btn_eliminar = New System.Windows.Forms.Button
        Me.btn_grabar = New System.Windows.Forms.Button
        Me.btn_modifica = New System.Windows.Forms.Button
        Me.btn_nuevo = New System.Windows.Forms.Button
        Me.txt_costo = New System.Windows.Forms.TextBox
        Me.txt_PrecioUcompra = New System.Windows.Forms.TextBox
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.txt_codigo = New System.Windows.Forms.TextBox
        Me.txt_orden = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_unidades = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.Location = New System.Drawing.Point(738, 107)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(65, 51)
        Me.btn_imprimir.TabIndex = 108
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_imprimir.UseVisualStyleBackColor = True
        Me.btn_imprimir.Visible = False
        '
        'txt_exiMax
        '
        Me.txt_exiMax.BackColor = System.Drawing.Color.White
        Me.txt_exiMax.Location = New System.Drawing.Point(159, 202)
        Me.txt_exiMax.MaxLength = 12
        Me.txt_exiMax.Name = "txt_exiMax"
        Me.txt_exiMax.Size = New System.Drawing.Size(100, 20)
        Me.txt_exiMax.TabIndex = 91
        Me.txt_exiMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_exiMin
        '
        Me.txt_exiMin.BackColor = System.Drawing.Color.White
        Me.txt_exiMin.Location = New System.Drawing.Point(159, 176)
        Me.txt_exiMin.MaxLength = 12
        Me.txt_exiMin.Name = "txt_exiMin"
        Me.txt_exiMin.Size = New System.Drawing.Size(100, 20)
        Me.txt_exiMin.TabIndex = 90
        Me.txt_exiMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "Existencia maxima:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Existencia minima:"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(467, 15)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(99, 36)
        Me.btn_cancelar.TabIndex = 105
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(568, 15)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(99, 36)
        Me.btn_buscar.TabIndex = 100
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(365, 15)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(99, 36)
        Me.btn_eliminar.TabIndex = 99
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_grabar
        '
        Me.btn_grabar.Location = New System.Drawing.Point(265, 15)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(99, 36)
        Me.btn_grabar.TabIndex = 98
        Me.btn_grabar.Text = "Grabar"
        Me.btn_grabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'btn_modifica
        '
        Me.btn_modifica.Location = New System.Drawing.Point(165, 15)
        Me.btn_modifica.Name = "btn_modifica"
        Me.btn_modifica.Size = New System.Drawing.Size(99, 36)
        Me.btn_modifica.TabIndex = 97
        Me.btn_modifica.Text = "Modificar"
        Me.btn_modifica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_modifica.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(65, 15)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(99, 36)
        Me.btn_nuevo.TabIndex = 95
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'txt_costo
        '
        Me.txt_costo.BackColor = System.Drawing.Color.White
        Me.txt_costo.Location = New System.Drawing.Point(160, 150)
        Me.txt_costo.MaxLength = 12
        Me.txt_costo.Name = "txt_costo"
        Me.txt_costo.ReadOnly = True
        Me.txt_costo.Size = New System.Drawing.Size(100, 20)
        Me.txt_costo.TabIndex = 88
        Me.txt_costo.TabStop = False
        Me.txt_costo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_PrecioUcompra
        '
        Me.txt_PrecioUcompra.BackColor = System.Drawing.Color.White
        Me.txt_PrecioUcompra.Location = New System.Drawing.Point(159, 123)
        Me.txt_PrecioUcompra.MaxLength = 12
        Me.txt_PrecioUcompra.Name = "txt_PrecioUcompra"
        Me.txt_PrecioUcompra.ReadOnly = True
        Me.txt_PrecioUcompra.Size = New System.Drawing.Size(100, 20)
        Me.txt_PrecioUcompra.TabIndex = 87
        Me.txt_PrecioUcompra.TabStop = False
        Me.txt_PrecioUcompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_nombre
        '
        Me.txt_nombre.BackColor = System.Drawing.Color.White
        Me.txt_nombre.Location = New System.Drawing.Point(160, 93)
        Me.txt_nombre.MaxLength = 100
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(502, 20)
        Me.txt_nombre.TabIndex = 86
        '
        'txt_codigo
        '
        Me.txt_codigo.BackColor = System.Drawing.Color.White
        Me.txt_codigo.Location = New System.Drawing.Point(161, 67)
        Me.txt_codigo.MaxLength = 15
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(100, 20)
        Me.txt_codigo.TabIndex = 85
        '
        'txt_orden
        '
        Me.txt_orden.BackColor = System.Drawing.Color.SkyBlue
        Me.txt_orden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_orden.Location = New System.Drawing.Point(751, 62)
        Me.txt_orden.MaxLength = 7
        Me.txt_orden.Name = "txt_orden"
        Me.txt_orden.ReadOnly = True
        Me.txt_orden.Size = New System.Drawing.Size(67, 22)
        Me.txt_orden.TabIndex = 84
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(83, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Precio costo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(48, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 13)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Precio ultima compra:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(90, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Descripcion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(113, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Codigo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(710, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Orden:"
        '
        'txt_unidades
        '
        Me.txt_unidades.BackColor = System.Drawing.Color.White
        Me.txt_unidades.Location = New System.Drawing.Point(159, 233)
        Me.txt_unidades.MaxLength = 12
        Me.txt_unidades.Name = "txt_unidades"
        Me.txt_unidades.Size = New System.Drawing.Size(100, 20)
        Me.txt_unidades.TabIndex = 109
        Me.txt_unidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 13)
        Me.Label6.TabIndex = 110
        Me.Label6.Text = "Unidades de empaque:"
        '
        'frm_articulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 277)
        Me.Controls.Add(Me.txt_unidades)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.txt_exiMax)
        Me.Controls.Add(Me.txt_exiMin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_grabar)
        Me.Controls.Add(Me.btn_modifica)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.txt_costo)
        Me.Controls.Add(Me.txt_PrecioUcompra)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.txt_orden)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_articulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Articulo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents txt_exiMax As System.Windows.Forms.TextBox
    Friend WithEvents txt_exiMin As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_grabar As System.Windows.Forms.Button
    Friend WithEvents btn_modifica As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents txt_costo As System.Windows.Forms.TextBox
    Friend WithEvents txt_PrecioUcompra As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents txt_orden As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_unidades As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
