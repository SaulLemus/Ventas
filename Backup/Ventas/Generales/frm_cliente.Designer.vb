﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cliente))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txt_nit = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_correo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_telefono = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_direccion = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.btn_imprimir = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.btn_eliminar = New System.Windows.Forms.Button
        Me.btn_grabar = New System.Windows.Forms.Button
        Me.btn_modifica = New System.Windows.Forms.Button
        Me.btn_nuevo = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.txt_saldo = New System.Windows.Forms.TextBox
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.txt_codigo = New System.Windows.Forms.TextBox
        Me.txt_orden = New System.Windows.Forms.TextBox
        Me.dtg_movimientos = New System.Windows.Forms.DataGridView
        Me.Col_fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_entrada = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_salida = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_razonMov = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_listado = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.btn_lista = New System.Windows.Forms.Button
        CType(Me.dtg_movimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_nit
        '
        Me.txt_nit.BackColor = System.Drawing.Color.White
        Me.txt_nit.Location = New System.Drawing.Point(94, 169)
        Me.txt_nit.MaxLength = 50
        Me.txt_nit.Name = "txt_nit"
        Me.txt_nit.Size = New System.Drawing.Size(100, 20)
        Me.txt_nit.TabIndex = 122
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(66, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 146
        Me.Label7.Text = "Nit:"
        '
        'txt_correo
        '
        Me.txt_correo.BackColor = System.Drawing.Color.White
        Me.txt_correo.Location = New System.Drawing.Point(94, 193)
        Me.txt_correo.MaxLength = 50
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(222, 20)
        Me.txt_correo.TabIndex = 123
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 145
        Me.Label5.Text = "E-Mail:"
        '
        'txt_telefono
        '
        Me.txt_telefono.BackColor = System.Drawing.Color.White
        Me.txt_telefono.Location = New System.Drawing.Point(94, 143)
        Me.txt_telefono.MaxLength = 50
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(222, 20)
        Me.txt_telefono.TabIndex = 121
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 144
        Me.Label4.Text = "Telefono:"
        '
        'txt_direccion
        '
        Me.txt_direccion.BackColor = System.Drawing.Color.White
        Me.txt_direccion.Location = New System.Drawing.Point(94, 119)
        Me.txt_direccion.MaxLength = 100
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(503, 20)
        Me.txt_direccion.TabIndex = 120
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 143
        Me.Label6.Text = "Direccion:"
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.Location = New System.Drawing.Point(634, 266)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(65, 51)
        Me.btn_imprimir.TabIndex = 126
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_imprimir.UseVisualStyleBackColor = True
        Me.btn_imprimir.Visible = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(457, 16)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(99, 36)
        Me.btn_cancelar.TabIndex = 131
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(558, 16)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(99, 36)
        Me.btn_buscar.TabIndex = 132
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(355, 16)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(99, 36)
        Me.btn_eliminar.TabIndex = 130
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_grabar
        '
        Me.btn_grabar.Location = New System.Drawing.Point(255, 16)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(99, 36)
        Me.btn_grabar.TabIndex = 129
        Me.btn_grabar.Text = "Grabar"
        Me.btn_grabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'btn_modifica
        '
        Me.btn_modifica.Location = New System.Drawing.Point(155, 16)
        Me.btn_modifica.Name = "btn_modifica"
        Me.btn_modifica.Size = New System.Drawing.Size(99, 36)
        Me.btn_modifica.TabIndex = 128
        Me.btn_modifica.Text = "Modificar"
        Me.btn_modifica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_modifica.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(55, 16)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(99, 36)
        Me.btn_nuevo.TabIndex = 127
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(91, 255)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(197, 20)
        Me.Label14.TabIndex = 142
        Me.Label14.Text = "Listado de movimientos"
        '
        'txt_saldo
        '
        Me.txt_saldo.BackColor = System.Drawing.Color.White
        Me.txt_saldo.Location = New System.Drawing.Point(94, 219)
        Me.txt_saldo.MaxLength = 12
        Me.txt_saldo.Name = "txt_saldo"
        Me.txt_saldo.ReadOnly = True
        Me.txt_saldo.Size = New System.Drawing.Size(100, 20)
        Me.txt_saldo.TabIndex = 124
        Me.txt_saldo.TabStop = False
        Me.txt_saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_saldo.Visible = False
        '
        'txt_nombre
        '
        Me.txt_nombre.BackColor = System.Drawing.Color.White
        Me.txt_nombre.Location = New System.Drawing.Point(95, 92)
        Me.txt_nombre.MaxLength = 100
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(502, 20)
        Me.txt_nombre.TabIndex = 119
        '
        'txt_codigo
        '
        Me.txt_codigo.BackColor = System.Drawing.Color.White
        Me.txt_codigo.Location = New System.Drawing.Point(96, 66)
        Me.txt_codigo.MaxLength = 15
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(100, 20)
        Me.txt_codigo.TabIndex = 118
        '
        'txt_orden
        '
        Me.txt_orden.BackColor = System.Drawing.Color.SkyBlue
        Me.txt_orden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_orden.Location = New System.Drawing.Point(651, 61)
        Me.txt_orden.MaxLength = 7
        Me.txt_orden.Name = "txt_orden"
        Me.txt_orden.ReadOnly = True
        Me.txt_orden.Size = New System.Drawing.Size(67, 22)
        Me.txt_orden.TabIndex = 141
        '
        'dtg_movimientos
        '
        Me.dtg_movimientos.AllowUserToAddRows = False
        Me.dtg_movimientos.AllowUserToDeleteRows = False
        Me.dtg_movimientos.AllowUserToResizeColumns = False
        Me.dtg_movimientos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtg_movimientos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtg_movimientos.BackgroundColor = System.Drawing.Color.White
        Me.dtg_movimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_movimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_fecha, Me.col_entrada, Me.col_salida, Me.col_razonMov})
        Me.dtg_movimientos.Location = New System.Drawing.Point(83, 266)
        Me.dtg_movimientos.Name = "dtg_movimientos"
        Me.dtg_movimientos.RowHeadersWidth = 25
        Me.dtg_movimientos.Size = New System.Drawing.Size(545, 67)
        Me.dtg_movimientos.TabIndex = 125
        Me.dtg_movimientos.Visible = False
        '
        'Col_fecha
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Col_fecha.DefaultCellStyle = DataGridViewCellStyle2
        Me.Col_fecha.HeaderText = "Fecha"
        Me.Col_fecha.MaxInputLength = 25
        Me.Col_fecha.Name = "Col_fecha"
        Me.Col_fecha.ReadOnly = True
        Me.Col_fecha.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'col_entrada
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.col_entrada.DefaultCellStyle = DataGridViewCellStyle3
        Me.col_entrada.HeaderText = "Cargo"
        Me.col_entrada.MaxInputLength = 15
        Me.col_entrada.Name = "col_entrada"
        Me.col_entrada.ReadOnly = True
        Me.col_entrada.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'col_salida
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.col_salida.DefaultCellStyle = DataGridViewCellStyle4
        Me.col_salida.HeaderText = "Abono"
        Me.col_salida.MaxInputLength = 15
        Me.col_salida.Name = "col_salida"
        Me.col_salida.ReadOnly = True
        Me.col_salida.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'col_razonMov
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col_razonMov.DefaultCellStyle = DataGridViewCellStyle5
        Me.col_razonMov.HeaderText = "Tipo Mov"
        Me.col_razonMov.MaxInputLength = 100
        Me.col_razonMov.Name = "col_razonMov"
        Me.col_razonMov.ReadOnly = True
        Me.col_razonMov.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(54, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 140
        Me.Label8.Text = "Saldo:"
        Me.Label8.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 138
        Me.Label2.Text = "Codigo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(610, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "Orden:"
        '
        'txt_listado
        '
        Me.txt_listado.BackColor = System.Drawing.Color.White
        Me.txt_listado.Location = New System.Drawing.Point(415, 227)
        Me.txt_listado.MaxLength = 12
        Me.txt_listado.Name = "txt_listado"
        Me.txt_listado.ReadOnly = True
        Me.txt_listado.Size = New System.Drawing.Size(177, 20)
        Me.txt_listado.TabIndex = 147
        Me.txt_listado.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(317, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 13)
        Me.Label9.TabIndex = 148
        Me.Label9.Text = "Listado de precios:"
        '
        'btn_lista
        '
        Me.btn_lista.Location = New System.Drawing.Point(602, 226)
        Me.btn_lista.Name = "btn_lista"
        Me.btn_lista.Size = New System.Drawing.Size(26, 23)
        Me.btn_lista.TabIndex = 149
        Me.btn_lista.Text = "..."
        Me.btn_lista.UseVisualStyleBackColor = True
        '
        'frm_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 355)
        Me.Controls.Add(Me.btn_lista)
        Me.Controls.Add(Me.txt_listado)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_nit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_correo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_grabar)
        Me.Controls.Add(Me.btn_modifica)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_saldo)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.txt_orden)
        Me.Controls.Add(Me.dtg_movimientos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de clientes"
        CType(Me.dtg_movimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_nit As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_correo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_grabar As System.Windows.Forms.Button
    Friend WithEvents btn_modifica As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_saldo As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents txt_orden As System.Windows.Forms.TextBox
    Friend WithEvents dtg_movimientos As System.Windows.Forms.DataGridView
    Friend WithEvents Col_fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_entrada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_salida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_razonMov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_listado As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_lista As System.Windows.Forms.Button
End Class
