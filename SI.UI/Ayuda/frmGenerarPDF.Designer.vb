<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerarPDF
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rptReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.sfdSaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'rptReportViewer
        '
        Me.rptReportViewer.Location = New System.Drawing.Point(12, 12)
        Me.rptReportViewer.Name = "rptReportViewer"
        Me.rptReportViewer.Size = New System.Drawing.Size(260, 246)
        Me.rptReportViewer.TabIndex = 0
        '
        'frmGenerarPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.rptReportViewer)
        Me.Name = "frmGenerarPDF"
        Me.Text = "frmGenerarPDF"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rptReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sfdSaveFileDialog As System.Windows.Forms.SaveFileDialog
End Class
