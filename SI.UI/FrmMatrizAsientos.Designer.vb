<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMatrizAsientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMatrizAsientos))
        Me.TsMatriz = New System.Windows.Forms.ToolStrip()
        Me.tsbExportarExcel = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripSplitButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.fxgrdMatriz = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.TsMatriz.SuspendLayout()
        CType(Me.fxgrdMatriz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TsMatriz
        '
        Me.TsMatriz.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.TsMatriz.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExportarExcel, Me.tsbSalir})
        Me.TsMatriz.Location = New System.Drawing.Point(0, 0)
        Me.TsMatriz.Name = "TsMatriz"
        Me.TsMatriz.Size = New System.Drawing.Size(969, 39)
        Me.TsMatriz.TabIndex = 24
        Me.TsMatriz.Text = "ToolStrip1"
        '
        'tsbExportarExcel
        '
        Me.tsbExportarExcel.Image = CType(resources.GetObject("tsbExportarExcel.Image"), System.Drawing.Image)
        Me.tsbExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportarExcel.Name = "tsbExportarExcel"
        Me.tsbExportarExcel.Size = New System.Drawing.Size(124, 36)
        Me.tsbExportarExcel.Text = "Exportar a Excel"
        '
        'tsbSalir
        '
        Me.tsbSalir.Image = Global.My.Resources.Resources.salir
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(77, 36)
        Me.tsbSalir.Text = "Salir"
        '
        'fxgrdMatriz
        '
        Me.fxgrdMatriz.AllowEditing = False
        Me.fxgrdMatriz.AllowFiltering = True
        Me.fxgrdMatriz.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fxgrdMatriz.ColumnInfo = resources.GetString("fxgrdMatriz.ColumnInfo")
        Me.fxgrdMatriz.Location = New System.Drawing.Point(12, 42)
        Me.fxgrdMatriz.Name = "fxgrdMatriz"
        Me.fxgrdMatriz.Rows.DefaultSize = 19
        Me.fxgrdMatriz.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.fxgrdMatriz.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fxgrdMatriz.Size = New System.Drawing.Size(945, 436)
        Me.fxgrdMatriz.StyleInfo = resources.GetString("fxgrdMatriz.StyleInfo")
        Me.fxgrdMatriz.TabIndex = 25
        '
        'FrmMatrizAsientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 490)
        Me.Controls.Add(Me.fxgrdMatriz)
        Me.Controls.Add(Me.TsMatriz)
        Me.Name = "FrmMatrizAsientos"
        Me.Text = "Matriz de Validación de Asientos"
        Me.TsMatriz.ResumeLayout(False)
        Me.TsMatriz.PerformLayout()
        CType(Me.fxgrdMatriz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TsMatriz As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExportarExcel As System.Windows.Forms.ToolStripButton


    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents C1FlexDataTree1 As C1FlexDataTree
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents fxgrdMatriz As C1.Win.C1FlexGrid.C1FlexGrid
End Class
