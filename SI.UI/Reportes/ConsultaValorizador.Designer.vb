<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaValorizador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaValorizador))
        Me.fxgrdReporteLista = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tsMantenimiento = New System.Windows.Forms.ToolStrip()
        Me.tsbExportarExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.fxgrdReporteLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'fxgrdReporteLista
        '
        Me.fxgrdReporteLista.AllowEditing = False
        Me.fxgrdReporteLista.AllowFiltering = True
        Me.fxgrdReporteLista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fxgrdReporteLista.ColumnInfo = "10,1,0,0,0,95,Columns:"
        Me.fxgrdReporteLista.Location = New System.Drawing.Point(12, 51)
        Me.fxgrdReporteLista.Name = "fxgrdReporteLista"
        Me.fxgrdReporteLista.Rows.DefaultSize = 19
        Me.fxgrdReporteLista.Size = New System.Drawing.Size(650, 368)
        Me.fxgrdReporteLista.TabIndex = 0
        '
        'tsMantenimiento
        '
        Me.tsMantenimiento.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExportarExcel, Me.ToolStripSeparator7, Me.tsbSalir})
        Me.tsMantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.tsMantenimiento.Name = "tsMantenimiento"
        Me.tsMantenimiento.Size = New System.Drawing.Size(674, 39)
        Me.tsMantenimiento.TabIndex = 24
        Me.tsMantenimiento.Text = "ToolStrip1"
        '
        'tsbExportarExcel
        '
        Me.tsbExportarExcel.Image = CType(resources.GetObject("tsbExportarExcel.Image"), System.Drawing.Image)
        Me.tsbExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportarExcel.Name = "tsbExportarExcel"
        Me.tsbExportarExcel.Size = New System.Drawing.Size(122, 36)
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
        Me.tsbSalir.Size = New System.Drawing.Size(63, 36)
        Me.tsbSalir.Text = "Salir"
        '
        'ConsultaValorizador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(674, 459)
        Me.Controls.Add(Me.tsMantenimiento)
        Me.Controls.Add(Me.fxgrdReporteLista)
        Me.Name = "ConsultaValorizador"
        Me.Text = "ReporteLista"
        CType(Me.fxgrdReporteLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMantenimiento.ResumeLayout(False)
        Me.tsMantenimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fxgrdReporteLista As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents tsMantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
