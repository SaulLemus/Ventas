<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RvCli_det
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
        Me.CrystalReportViewerx = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrystalReportViewerx
        '
        Me.CrystalReportViewerx.ActiveViewIndex = -1
        Me.CrystalReportViewerx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewerx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewerx.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewerx.Name = "CrystalReportViewerx"
        Me.CrystalReportViewerx.SelectionFormula = ""
        Me.CrystalReportViewerx.Size = New System.Drawing.Size(721, 482)
        Me.CrystalReportViewerx.TabIndex = 0
        Me.CrystalReportViewerx.ViewTimeSelectionFormula = ""
        '
        'frm_RvCli_det
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 482)
        Me.Controls.Add(Me.CrystalReportViewerx)
        Me.Name = "frm_RvCli_det"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_RvCli1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewerx As CrystalDecisions.Windows.Forms.CrystalReportViewer
    'Friend WithEvents RPT_con_ven_cliDet1 As Ventas.RPT_con_ven_cliDet
    'Friend WithEvents RPT_con_ven_cli1 As Ventas.RPT_con_ven_cli
End Class
