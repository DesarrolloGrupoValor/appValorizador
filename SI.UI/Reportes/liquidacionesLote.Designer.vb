<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LiquidacionesLote
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
        Me.Ts_LiquidacionesLot = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbExportarExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.CuGroupBox1 = New CUGroupBox()
        Me.gpoLiquidacionesLote = New CUGroupBox()
        Me.CuGroupBox2 = New CUGroupBox()
        Me.fxgrdLiquidaciones = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.TbxPeriodo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Ts_LiquidacionesLot.SuspendLayout()
        Me.CuGroupBox1.SuspendLayout()
        Me.gpoLiquidacionesLote.SuspendLayout()
        Me.CuGroupBox2.SuspendLayout()
        CType(Me.fxgrdLiquidaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ts_LiquidacionesLot
        '
        Me.Ts_LiquidacionesLot.BackColor = System.Drawing.SystemColors.Control
        Me.Ts_LiquidacionesLot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Ts_LiquidacionesLot.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.Ts_LiquidacionesLot.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator2, Me.tsbExportarExcel, Me.ToolStripSeparator1, Me.TsbSalir})
        Me.Ts_LiquidacionesLot.Location = New System.Drawing.Point(3, 5)
        Me.Ts_LiquidacionesLot.Name = "Ts_LiquidacionesLot"
        Me.Ts_LiquidacionesLot.Size = New System.Drawing.Size(912, 39)
        Me.Ts_LiquidacionesLot.TabIndex = 23
        Me.Ts_LiquidacionesLot.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.My.Resources.Resources.consultar
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(94, 36)
        Me.ToolStripButton1.Text = "Consultar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'tsbExportarExcel
        '
        Me.tsbExportarExcel.Image = Global.My.Resources.Resources.asociar_1
        Me.tsbExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportarExcel.Name = "tsbExportarExcel"
        Me.tsbExportarExcel.Size = New System.Drawing.Size(124, 36)
        Me.tsbExportarExcel.Text = "Exportar a Excel"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'TsbSalir
        '
        Me.TsbSalir.Image = Global.My.Resources.Resources.salir
        Me.TsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbSalir.Name = "TsbSalir"
        Me.TsbSalir.Size = New System.Drawing.Size(65, 36)
        Me.TsbSalir.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(408, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Reporte - Liquidaciones por Lote      "
        '
        'CuGroupBox1
        '
        Me.CuGroupBox1.BackColor = System.Drawing.Color.LemonChiffon
        Me.CuGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.CuGroupBox1.Controls.Add(Me.Ts_LiquidacionesLot)
        Me.CuGroupBox1.Location = New System.Drawing.Point(-4, 0)
        Me.CuGroupBox1.Name = "CuGroupBox1"
        Me.CuGroupBox1.Size = New System.Drawing.Size(918, 47)
        Me.CuGroupBox1.TabIndex = 25
        Me.CuGroupBox1.TabStop = False
        Me.CuGroupBox1.Text = "CuGroupBox1"
        '
        'gpoLiquidacionesLote
        '
        Me.gpoLiquidacionesLote.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoLiquidacionesLote.BackColor = System.Drawing.Color.LemonChiffon
        Me.gpoLiquidacionesLote.BorderColor = System.Drawing.Color.Black
        Me.gpoLiquidacionesLote.Controls.Add(Me.CuGroupBox2)
        Me.gpoLiquidacionesLote.Controls.Add(Me.TbxPeriodo)
        Me.gpoLiquidacionesLote.Controls.Add(Me.Label2)
        Me.gpoLiquidacionesLote.Location = New System.Drawing.Point(-201, -38)
        Me.gpoLiquidacionesLote.Name = "gpoLiquidacionesLote"
        Me.gpoLiquidacionesLote.Size = New System.Drawing.Size(1177, 491)
        Me.gpoLiquidacionesLote.TabIndex = 16
        Me.gpoLiquidacionesLote.TabStop = False
        Me.gpoLiquidacionesLote.Text = "CuGroupBox2"
        '
        'CuGroupBox2
        '
        Me.CuGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CuGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.CuGroupBox2.BorderColor = System.Drawing.Color.Black
        Me.CuGroupBox2.Controls.Add(Me.fxgrdLiquidaciones)
        Me.CuGroupBox2.Location = New System.Drawing.Point(213, 120)
        Me.CuGroupBox2.Name = "CuGroupBox2"
        Me.CuGroupBox2.Size = New System.Drawing.Size(753, 360)
        Me.CuGroupBox2.TabIndex = 2
        Me.CuGroupBox2.TabStop = False
        '
        'fxgrdLiquidaciones
        '
        Me.fxgrdLiquidaciones.AllowEditing = False
        Me.fxgrdLiquidaciones.AllowFiltering = True
        Me.fxgrdLiquidaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fxgrdLiquidaciones.ColumnInfo = "10,1,0,0,0,95,Columns:"
        Me.fxgrdLiquidaciones.Location = New System.Drawing.Point(6, 13)
        Me.fxgrdLiquidaciones.Name = "fxgrdLiquidaciones"
        Me.fxgrdLiquidaciones.Rows.DefaultSize = 19
        Me.fxgrdLiquidaciones.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.fxgrdLiquidaciones.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fxgrdLiquidaciones.Size = New System.Drawing.Size(738, 298)
        Me.fxgrdLiquidaciones.TabIndex = 0
        '
        'TbxPeriodo
        '
        Me.TbxPeriodo.Location = New System.Drawing.Point(261, 95)
        Me.TbxPeriodo.Name = "TbxPeriodo"
        Me.TbxPeriodo.Size = New System.Drawing.Size(56, 20)
        Me.TbxPeriodo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(223, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Año :"
        '
        'LiquidacionesLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 448)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CuGroupBox1)
        Me.Controls.Add(Me.gpoLiquidacionesLote)
        Me.Name = "LiquidacionesLote"
        Me.Text = "liquidacionesLote"
        Me.Ts_LiquidacionesLot.ResumeLayout(False)
        Me.Ts_LiquidacionesLot.PerformLayout()
        Me.CuGroupBox1.ResumeLayout(False)
        Me.CuGroupBox1.PerformLayout()
        Me.gpoLiquidacionesLote.ResumeLayout(False)
        Me.gpoLiquidacionesLote.PerformLayout()
        Me.CuGroupBox2.ResumeLayout(False)
        CType(Me.fxgrdLiquidaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ts_LiquidacionesLot As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents TsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub
    Friend WithEvents CuGroupBox1 As CUGroupBox
    Friend WithEvents gpoLiquidacionesLote As CUGroupBox
    Friend WithEvents TbxPeriodo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CuGroupBox2 As CUGroupBox
    Friend WithEvents fxgrdLiquidaciones As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator


End Class
