<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerificarVsConcar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVerificarVsConcar))
        Me.fxgrdContabilidad = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tsMantenimiento = New System.Windows.Forms.ToolStrip()
        Me.tsbExportarExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.fxgrdContabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'fxgrdContabilidad
        '
        Me.fxgrdContabilidad.AllowEditing = False
        Me.fxgrdContabilidad.AllowFiltering = True
        Me.fxgrdContabilidad.ColumnInfo = "10,1,0,0,0,95,Columns:0{AllowFiltering:ByValue;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{AllowFiltering:ByValue;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fxgrdContabilidad.Location = New System.Drawing.Point(12, 42)
        Me.fxgrdContabilidad.Name = "fxgrdContabilidad"
        Me.fxgrdContabilidad.Rows.Count = 2
        Me.fxgrdContabilidad.Rows.DefaultSize = 19
        Me.fxgrdContabilidad.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.fxgrdContabilidad.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fxgrdContabilidad.Size = New System.Drawing.Size(684, 393)
        Me.fxgrdContabilidad.TabIndex = 1
        '
        'tsMantenimiento
        '
        Me.tsMantenimiento.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExportarExcel, Me.ToolStripSeparator7, Me.tsbSalir})
        Me.tsMantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.tsMantenimiento.Name = "tsMantenimiento"
        Me.tsMantenimiento.Size = New System.Drawing.Size(708, 39)
        Me.tsMantenimiento.TabIndex = 24
        Me.tsMantenimiento.Text = "ToolStrip1"
        '
        'tsbExportarExcel
        '
        Me.tsbExportarExcel.Image = CType(resources.GetObject("tsbExportarExcel.Image"), System.Drawing.Image)
        Me.tsbExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportarExcel.Name = "tsbExportarExcel"
        Me.tsbExportarExcel.Size = New System.Drawing.Size(124, 36)
        Me.tsbExportarExcel.Text = "Exportar a Excel"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 39)
        '
        'tsbSalir
        '
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(65, 36)
        Me.tsbSalir.Text = "Salir"
        '
        'frmVerificarVsConcar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 447)
        Me.Controls.Add(Me.tsMantenimiento)
        Me.Controls.Add(Me.fxgrdContabilidad)
        Me.Name = "frmVerificarVsConcar"
        Me.Text = "Asientos cotables - VCM vs CONCAR"
        CType(Me.fxgrdContabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMantenimiento.ResumeLayout(False)
        Me.tsMantenimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fxgrdContabilidad As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents tsMantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
