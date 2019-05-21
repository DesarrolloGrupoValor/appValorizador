<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLotesValorizadosLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLotesValorizadosLog))
        Me.tsMantenimiento = New System.Windows.Forms.ToolStrip()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.CuGroupBox1 = New CUGroupBox()
        Me.fxgLotesValorizadosTmLog = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.gpoContratos = New CUGroupBox()
        Me.fxgLotesValorizadosLog = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tsMantenimiento.SuspendLayout()
        Me.CuGroupBox1.SuspendLayout()
        CType(Me.fxgLotesValorizadosTmLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoContratos.SuspendLayout()
        CType(Me.fxgLotesValorizadosLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMantenimiento
        '
        Me.tsMantenimiento.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbRefrescar, Me.ToolStripSeparator7, Me.tsbSalir})
        Me.tsMantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.tsMantenimiento.Name = "tsMantenimiento"
        Me.tsMantenimiento.Size = New System.Drawing.Size(1158, 39)
        Me.tsMantenimiento.TabIndex = 21
        Me.tsMantenimiento.Text = "ToolStrip1"
        '
        'tsbRefrescar
        '
        Me.tsbRefrescar.Image = CType(resources.GetObject("tsbRefrescar.Image"), System.Drawing.Image)
        Me.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRefrescar.Name = "tsbRefrescar"
        Me.tsbRefrescar.Size = New System.Drawing.Size(91, 36)
        Me.tsbRefrescar.Text = "Refrescar"
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
        'CuGroupBox1
        '
        Me.CuGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CuGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.CuGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.CuGroupBox1.Controls.Add(Me.fxgLotesValorizadosTmLog)
        Me.CuGroupBox1.Location = New System.Drawing.Point(12, 361)
        Me.CuGroupBox1.Name = "CuGroupBox1"
        Me.CuGroupBox1.Size = New System.Drawing.Size(1134, 181)
        Me.CuGroupBox1.TabIndex = 13
        Me.CuGroupBox1.TabStop = False
        Me.CuGroupBox1.Text = "Lotes ValorizadosTM Log"
        '
        'fxgLotesValorizadosTmLog
        '
        Me.fxgLotesValorizadosTmLog.AllowEditing = False
        Me.fxgLotesValorizadosTmLog.AllowFiltering = True
        Me.fxgLotesValorizadosTmLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fxgLotesValorizadosTmLog.ColumnInfo = resources.GetString("fxgLotesValorizadosTmLog.ColumnInfo")
        Me.fxgLotesValorizadosTmLog.Location = New System.Drawing.Point(6, 19)
        Me.fxgLotesValorizadosTmLog.Name = "fxgLotesValorizadosTmLog"
        Me.fxgLotesValorizadosTmLog.Rows.Count = 2
        Me.fxgLotesValorizadosTmLog.Rows.DefaultSize = 19
        Me.fxgLotesValorizadosTmLog.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fxgLotesValorizadosTmLog.Size = New System.Drawing.Size(1122, 156)
        Me.fxgLotesValorizadosTmLog.TabIndex = 0
        '
        'gpoContratos
        '
        Me.gpoContratos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoContratos.BackColor = System.Drawing.Color.Transparent
        Me.gpoContratos.BorderColor = System.Drawing.Color.Black
        Me.gpoContratos.Controls.Add(Me.fxgLotesValorizadosLog)
        Me.gpoContratos.Location = New System.Drawing.Point(12, 42)
        Me.gpoContratos.Name = "gpoContratos"
        Me.gpoContratos.Size = New System.Drawing.Size(1134, 363)
        Me.gpoContratos.TabIndex = 13
        Me.gpoContratos.TabStop = False
        Me.gpoContratos.Text = "Lotes Valorizados Log"
        '
        'fxgLotesValorizadosLog
        '
        Me.fxgLotesValorizadosLog.AllowEditing = False
        Me.fxgLotesValorizadosLog.AllowFiltering = True
        Me.fxgLotesValorizadosLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fxgLotesValorizadosLog.ColumnInfo = resources.GetString("fxgLotesValorizadosLog.ColumnInfo")
        Me.fxgLotesValorizadosLog.Location = New System.Drawing.Point(6, 19)
        Me.fxgLotesValorizadosLog.Name = "fxgLotesValorizadosLog"
        Me.fxgLotesValorizadosLog.Rows.Count = 2
        Me.fxgLotesValorizadosLog.Rows.DefaultSize = 19
        Me.fxgLotesValorizadosLog.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fxgLotesValorizadosLog.Size = New System.Drawing.Size(1122, 338)
        Me.fxgLotesValorizadosLog.TabIndex = 0
        '
        'frmLotesValorizadosLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1158, 554)
        Me.Controls.Add(Me.tsMantenimiento)
        Me.Controls.Add(Me.CuGroupBox1)
        Me.Controls.Add(Me.gpoContratos)
        Me.Name = "frmLotesValorizadosLog"
        Me.Text = "Lotes Valorizados Log"
        Me.tsMantenimiento.ResumeLayout(False)
        Me.tsMantenimiento.PerformLayout()
        Me.CuGroupBox1.ResumeLayout(False)
        CType(Me.fxgLotesValorizadosTmLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoContratos.ResumeLayout(False)
        CType(Me.fxgLotesValorizadosLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gpoContratos As CUGroupBox
    Friend WithEvents fxgLotesValorizadosLog As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents CuGroupBox1 As CUGroupBox
    Friend WithEvents fxgLotesValorizadosTmLog As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents tsMantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
End Class
