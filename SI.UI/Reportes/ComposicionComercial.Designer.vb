<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComposicionComercial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComposicionComercial))
        Me.gpoContratos = New CUGroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.CuGroupBox2 = New CUGroupBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.tsMantenimiento = New System.Windows.Forms.ToolStrip()
        Me.tsbExportarExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.CuGroupBox1 = New CUGroupBox()
        Me.fxgrdExtraccionBd = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rptReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.gpoContratos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.CuGroupBox2.SuspendLayout()
        Me.tsMantenimiento.SuspendLayout()
        Me.CuGroupBox1.SuspendLayout()
        CType(Me.fxgrdExtraccionBd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpoContratos
        '
        Me.gpoContratos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoContratos.BackColor = System.Drawing.Color.Transparent
        Me.gpoContratos.BorderColor = System.Drawing.Color.Black
        Me.gpoContratos.Controls.Add(Me.GroupBox1)
        Me.gpoContratos.Controls.Add(Me.GroupBox2)
        Me.gpoContratos.Controls.Add(Me.CuGroupBox2)
        Me.gpoContratos.Controls.Add(Me.CuGroupBox1)
        Me.gpoContratos.Location = New System.Drawing.Point(-201, -37)
        Me.gpoContratos.Name = "gpoContratos"
        Me.gpoContratos.Size = New System.Drawing.Size(1091, 367)
        Me.gpoContratos.TabIndex = 16
        Me.gpoContratos.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.WebBrowser1)
        Me.GroupBox2.Location = New System.Drawing.Point(206, 156)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(678, 112)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 16)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(672, 93)
        Me.WebBrowser1.TabIndex = 0
        '
        'CuGroupBox2
        '
        Me.CuGroupBox2.BorderColor = System.Drawing.Color.Black
        Me.CuGroupBox2.Controls.Add(Me.lblTitulo)
        Me.CuGroupBox2.Controls.Add(Me.tsMantenimiento)
        Me.CuGroupBox2.Location = New System.Drawing.Point(199, 22)
        Me.CuGroupBox2.Name = "CuGroupBox2"
        Me.CuGroupBox2.Size = New System.Drawing.Size(686, 63)
        Me.CuGroupBox2.TabIndex = 17
        Me.CuGroupBox2.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(288, 23)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(213, 17)
        Me.lblTitulo.TabIndex = 25
        Me.lblTitulo.Text = "Reporte: Composición Comercial"
        '
        'tsMantenimiento
        '
        Me.tsMantenimiento.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExportarExcel, Me.ToolStripSeparator7, Me.tsbSalir})
        Me.tsMantenimiento.Location = New System.Drawing.Point(3, 16)
        Me.tsMantenimiento.Name = "tsMantenimiento"
        Me.tsMantenimiento.Size = New System.Drawing.Size(680, 39)
        Me.tsMantenimiento.TabIndex = 23
        Me.tsMantenimiento.Text = "ToolStrip1"
        '
        'tsbExportarExcel
        '
        Me.tsbExportarExcel.Image = CType(resources.GetObject("tsbExportarExcel.Image"), System.Drawing.Image)
        Me.tsbExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportarExcel.Name = "tsbExportarExcel"
        Me.tsbExportarExcel.Size = New System.Drawing.Size(124, 36)
        Me.tsbExportarExcel.Text = "Exportar a Excel"
        Me.tsbExportarExcel.Visible = False
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
        Me.CuGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CuGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.CuGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.CuGroupBox1.Controls.Add(Me.fxgrdExtraccionBd)
        Me.CuGroupBox1.Location = New System.Drawing.Point(213, 125)
        Me.CuGroupBox1.Name = "CuGroupBox1"
        Me.CuGroupBox1.Size = New System.Drawing.Size(664, 175)
        Me.CuGroupBox1.TabIndex = 16
        Me.CuGroupBox1.TabStop = False
        '
        'fxgrdExtraccionBd
        '
        Me.fxgrdExtraccionBd.AllowEditing = False
        Me.fxgrdExtraccionBd.AllowFiltering = True
        Me.fxgrdExtraccionBd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fxgrdExtraccionBd.ColumnInfo = "10,1,0,0,0,95,Columns:0{AllowFiltering:ByValue;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{AllowFiltering:ByValue;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fxgrdExtraccionBd.Location = New System.Drawing.Point(6, 19)
        Me.fxgrdExtraccionBd.Name = "fxgrdExtraccionBd"
        Me.fxgrdExtraccionBd.Rows.Count = 2
        Me.fxgrdExtraccionBd.Rows.DefaultSize = 19
        Me.fxgrdExtraccionBd.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.fxgrdExtraccionBd.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fxgrdExtraccionBd.Size = New System.Drawing.Size(652, 150)
        Me.fxgrdExtraccionBd.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.rptReportViewer)
        Me.GroupBox1.Location = New System.Drawing.Point(204, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(678, 240)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'rptReportViewer
        '
        Me.rptReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptReportViewer.Location = New System.Drawing.Point(3, 16)
        Me.rptReportViewer.Name = "rptReportViewer"
        Me.rptReportViewer.Size = New System.Drawing.Size(672, 221)
        Me.rptReportViewer.TabIndex = 0
        '
        'ComposicionComercial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(688, 293)
        Me.Controls.Add(Me.gpoContratos)
        Me.Name = "ComposicionComercial"
        Me.Text = "Composicion Comercial"
        Me.gpoContratos.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.CuGroupBox2.ResumeLayout(False)
        Me.CuGroupBox2.PerformLayout()
        Me.tsMantenimiento.ResumeLayout(False)
        Me.tsMantenimiento.PerformLayout()
        Me.CuGroupBox1.ResumeLayout(False)
        CType(Me.fxgrdExtraccionBd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpoContratos As CUGroupBox
    Friend WithEvents CuGroupBox1 As CUGroupBox
    Friend WithEvents fxgrdExtraccionBd As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents CuGroupBox2 As CUGroupBox
    Friend WithEvents tsMantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rptReportViewer As Microsoft.Reporting.WinForms.ReportViewer
End Class
