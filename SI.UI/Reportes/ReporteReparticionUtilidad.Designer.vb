<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteReparticionUtilidad
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
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.CuGroupBox1 = New CUGroupBox()
        Me.Lbltitulo = New System.Windows.Forms.Label()
        Me.TsMatriz = New System.Windows.Forms.ToolStrip()
        Me.TsbConsultar = New System.Windows.Forms.ToolStripButton()
        Me.TsbExportarExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.gpoMatriz = New CUGroupBox()
        Me.CuGroupBox2 = New CUGroupBox()
        Me.fxgrdComprasVentas = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox()
        Me.cboEmpresa = New System.Windows.Forms.ComboBox()
        Me.CuGroupBox1.SuspendLayout()
        Me.TsMatriz.SuspendLayout()
        Me.gpoMatriz.SuspendLayout()
        Me.CuGroupBox2.SuspendLayout()
        CType(Me.fxgrdComprasVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CuGroupBox1
        '
        Me.CuGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CuGroupBox1.BackColor = System.Drawing.Color.LemonChiffon
        Me.CuGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.CuGroupBox1.Controls.Add(Me.Lbltitulo)
        Me.CuGroupBox1.Controls.Add(Me.TsMatriz)
        Me.CuGroupBox1.Location = New System.Drawing.Point(-1, -14)
        Me.CuGroupBox1.Name = "CuGroupBox1"
        Me.CuGroupBox1.Size = New System.Drawing.Size(1075, 63)
        Me.CuGroupBox1.TabIndex = 17
        Me.CuGroupBox1.TabStop = False
        '
        'Lbltitulo
        '
        Me.Lbltitulo.AutoSize = True
        Me.Lbltitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitulo.Location = New System.Drawing.Point(569, 23)
        Me.Lbltitulo.Name = "Lbltitulo"
        Me.Lbltitulo.Size = New System.Drawing.Size(204, 16)
        Me.Lbltitulo.TabIndex = 1
        Me.Lbltitulo.Text = "Reporte : Distribución de Utilidad"
        '
        'TsMatriz
        '
        Me.TsMatriz.BackColor = System.Drawing.SystemColors.Control
        Me.TsMatriz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TsMatriz.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.TsMatriz.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsbConsultar, Me.TsbExportarExcel, Me.ToolStripSeparator2, Me.TsbSalir})
        Me.TsMatriz.Location = New System.Drawing.Point(3, 16)
        Me.TsMatriz.Name = "TsMatriz"
        Me.TsMatriz.Size = New System.Drawing.Size(1069, 44)
        Me.TsMatriz.Stretch = True
        Me.TsMatriz.TabIndex = 23
        Me.TsMatriz.Text = "ToolStrip1"
        '
        'TsbConsultar
        '
        Me.TsbConsultar.Image = Global.My.Resources.Resources.consultar
        Me.TsbConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbConsultar.Name = "TsbConsultar"
        Me.TsbConsultar.Size = New System.Drawing.Size(94, 41)
        Me.TsbConsultar.Text = "Consultar"
        '
        'TsbExportarExcel
        '
        Me.TsbExportarExcel.Image = Global.My.Resources.Resources.asociar_1
        Me.TsbExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbExportarExcel.Name = "TsbExportarExcel"
        Me.TsbExportarExcel.Size = New System.Drawing.Size(124, 41)
        Me.TsbExportarExcel.Text = "Exportar a Excel"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 44)
        '
        'TsbSalir
        '
        Me.TsbSalir.Image = Global.My.Resources.Resources.salir
        Me.TsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbSalir.Name = "TsbSalir"
        Me.TsbSalir.Size = New System.Drawing.Size(65, 41)
        Me.TsbSalir.Text = "Salir"
        '
        'gpoMatriz
        '
        Me.gpoMatriz.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoMatriz.BackColor = System.Drawing.Color.LemonChiffon
        Me.gpoMatriz.BorderColor = System.Drawing.Color.Black
        Me.gpoMatriz.Controls.Add(Me.CuGroupBox2)
        Me.gpoMatriz.Controls.Add(Me.Label2)
        Me.gpoMatriz.Controls.Add(Me.Label1)
        Me.gpoMatriz.Controls.Add(Me.cboPeriodo)
        Me.gpoMatriz.Controls.Add(Me.cboEmpresa)
        Me.gpoMatriz.Location = New System.Drawing.Point(-18, -36)
        Me.gpoMatriz.Name = "gpoMatriz"
        Me.gpoMatriz.Size = New System.Drawing.Size(1208, 600)
        Me.gpoMatriz.TabIndex = 1
        Me.gpoMatriz.TabStop = False
        Me.gpoMatriz.Text = "CuGroupBox3"
        '
        'CuGroupBox2
        '
        Me.CuGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CuGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.CuGroupBox2.BorderColor = System.Drawing.Color.Black
        Me.CuGroupBox2.Controls.Add(Me.fxgrdComprasVentas)
        Me.CuGroupBox2.Location = New System.Drawing.Point(20, 140)
        Me.CuGroupBox2.Name = "CuGroupBox2"
        Me.CuGroupBox2.Size = New System.Drawing.Size(1062, 408)
        Me.CuGroupBox2.TabIndex = 24
        Me.CuGroupBox2.TabStop = False
        '
        'fxgrdComprasVentas
        '
        Me.fxgrdComprasVentas.AllowEditing = False
        Me.fxgrdComprasVentas.AllowFiltering = True
        Me.fxgrdComprasVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fxgrdComprasVentas.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.fxgrdComprasVentas.Location = New System.Drawing.Point(10, 19)
        Me.fxgrdComprasVentas.Name = "fxgrdComprasVentas"
        Me.fxgrdComprasVentas.Rows.DefaultSize = 19
        Me.fxgrdComprasVentas.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.fxgrdComprasVentas.Size = New System.Drawing.Size(1037, 383)
        Me.fxgrdComprasVentas.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(271, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Periodo :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Empresa :"
        '
        'cboPeriodo
        '
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.Location = New System.Drawing.Point(335, 98)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(121, 21)
        Me.cboPeriodo.TabIndex = 26
        '
        'cboEmpresa
        '
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.Location = New System.Drawing.Point(90, 98)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(121, 21)
        Me.cboEmpresa.TabIndex = 25
        '
        'ReporteReparticionUtilidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 524)
        Me.Controls.Add(Me.CuGroupBox1)
        Me.Controls.Add(Me.gpoMatriz)
        Me.Name = "ReporteReparticionUtilidad"
        Me.Text = "Reporte Distribución de Utilidad"
        Me.CuGroupBox1.ResumeLayout(False)
        Me.CuGroupBox1.PerformLayout()
        Me.TsMatriz.ResumeLayout(False)
        Me.TsMatriz.PerformLayout()
        Me.gpoMatriz.ResumeLayout(False)
        Me.gpoMatriz.PerformLayout()
        Me.CuGroupBox2.ResumeLayout(False)
        CType(Me.fxgrdComprasVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TsMatriz As System.Windows.Forms.ToolStrip
    Friend WithEvents Lbltitulo As System.Windows.Forms.Label
    Friend WithEvents TsbConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TsbExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents CuGroupBox1 As CUGroupBox
    Friend WithEvents CuGroupBox2 As CUGroupBox
    Friend WithEvents fxgrdComprasVentas As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents gpoMatriz As CUGroupBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cboEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
