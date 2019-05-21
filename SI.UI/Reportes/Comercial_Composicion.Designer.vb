<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Comercial_Composicion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Comercial_Composicion))
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.gpoContratos = New CUGroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Rb_Amb = New System.Windows.Forms.RadioButton()
        Me.Rb_Ter = New System.Windows.Forms.RadioButton()
        Me.Rb_Vin = New System.Windows.Forms.RadioButton()
        Me.CbSabana = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.fxgrdComposicionVCM = New C1FlexDataTree()
        Me.rptReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.cboPeriodo2 = New System.Windows.Forms.ComboBox()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpPeriodo = New System.Windows.Forms.DateTimePicker()
        Me.CuGroupBox2 = New CUGroupBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.tsMantenimiento = New System.Windows.Forms.ToolStrip()
        Me.tsbConsular = New System.Windows.Forms.ToolStripButton()
        Me.tsbExportarExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.CuGroupBox1 = New CUGroupBox()
        Me.fxgrdExtraccionBd = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.gpoContratos.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.fxgrdComposicionVCM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.CuGroupBox2.SuspendLayout()
        Me.tsMantenimiento.SuspendLayout()
        Me.CuGroupBox1.SuspendLayout()
        CType(Me.fxgrdExtraccionBd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SaveFileDialog1
        '
        '
        'gpoContratos
        '
        Me.gpoContratos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoContratos.BackColor = System.Drawing.Color.LemonChiffon
        Me.gpoContratos.BorderColor = System.Drawing.Color.Black
        Me.gpoContratos.Controls.Add(Me.GroupBox3)
        Me.gpoContratos.Controls.Add(Me.CbSabana)
        Me.gpoContratos.Controls.Add(Me.GroupBox1)
        Me.gpoContratos.Controls.Add(Me.GroupBox2)
        Me.gpoContratos.Controls.Add(Me.cboPeriodo2)
        Me.gpoContratos.Controls.Add(Me.cboPeriodo)
        Me.gpoContratos.Controls.Add(Me.Label1)
        Me.gpoContratos.Controls.Add(Me.dtpPeriodo)
        Me.gpoContratos.Controls.Add(Me.CuGroupBox2)
        Me.gpoContratos.Controls.Add(Me.CuGroupBox1)
        Me.gpoContratos.Location = New System.Drawing.Point(-201, -37)
        Me.gpoContratos.Name = "gpoContratos"
        Me.gpoContratos.Size = New System.Drawing.Size(1277, 485)
        Me.gpoContratos.TabIndex = 16
        Me.gpoContratos.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Rb_Amb)
        Me.GroupBox3.Controls.Add(Me.Rb_Ter)
        Me.GroupBox3.Controls.Add(Me.Rb_Vin)
        Me.GroupBox3.Location = New System.Drawing.Point(561, 86)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(268, 36)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filtrar Por"
        '
        'Rb_Amb
        '
        Me.Rb_Amb.AutoSize = True
        Me.Rb_Amb.Checked = True
        Me.Rb_Amb.Location = New System.Drawing.Point(179, 14)
        Me.Rb_Amb.Name = "Rb_Amb"
        Me.Rb_Amb.Size = New System.Drawing.Size(57, 17)
        Me.Rb_Amb.TabIndex = 2
        Me.Rb_Amb.TabStop = True
        Me.Rb_Amb.Text = "Ambos"
        Me.Rb_Amb.UseVisualStyleBackColor = True
        '
        'Rb_Ter
        '
        Me.Rb_Ter.AutoSize = True
        Me.Rb_Ter.Location = New System.Drawing.Point(106, 15)
        Me.Rb_Ter.Name = "Rb_Ter"
        Me.Rb_Ter.Size = New System.Drawing.Size(67, 17)
        Me.Rb_Ter.TabIndex = 1
        Me.Rb_Ter.Text = "Terceros"
        Me.Rb_Ter.UseVisualStyleBackColor = True
        '
        'Rb_Vin
        '
        Me.Rb_Vin.AutoSize = True
        Me.Rb_Vin.Location = New System.Drawing.Point(23, 15)
        Me.Rb_Vin.Name = "Rb_Vin"
        Me.Rb_Vin.Size = New System.Drawing.Size(77, 17)
        Me.Rb_Vin.TabIndex = 0
        Me.Rb_Vin.Text = "Vinculadas"
        Me.Rb_Vin.UseVisualStyleBackColor = True
        '
        'CbSabana
        '
        Me.CbSabana.AutoSize = True
        Me.CbSabana.Location = New System.Drawing.Point(861, 99)
        Me.CbSabana.Name = "CbSabana"
        Me.CbSabana.Size = New System.Drawing.Size(87, 17)
        Me.CbSabana.TabIndex = 26
        Me.CbSabana.Text = "Tipo Sábana"
        Me.CbSabana.UseVisualStyleBackColor = True
        Me.CbSabana.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.fxgrdComposicionVCM)
        Me.GroupBox1.Controls.Add(Me.rptReportViewer)
        Me.GroupBox1.Location = New System.Drawing.Point(206, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(857, 324)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'fxgrdComposicionVCM
        '
        Me.fxgrdComposicionVCM.ColumnInfo = "10,1,0,0,0,95,Columns:0{Width:38;Style:""ImageAlign:RightCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fxgrdComposicionVCM.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw
        Me.fxgrdComposicionVCM.Location = New System.Drawing.Point(6, 33)
        Me.fxgrdComposicionVCM.Name = "fxgrdComposicionVCM"
        Me.fxgrdComposicionVCM.Rows.DefaultSize = 19
        Me.fxgrdComposicionVCM.Size = New System.Drawing.Size(845, 285)
        Me.fxgrdComposicionVCM.TabIndex = 1
        '
        'rptReportViewer
        '
        Me.rptReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptReportViewer.Location = New System.Drawing.Point(3, 16)
        Me.rptReportViewer.Name = "rptReportViewer"
        Me.rptReportViewer.Size = New System.Drawing.Size(851, 305)
        Me.rptReportViewer.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.WebBrowser1)
        Me.GroupBox2.Location = New System.Drawing.Point(213, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(850, 198)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 16)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(844, 179)
        Me.WebBrowser1.TabIndex = 0
        '
        'cboPeriodo2
        '
        Me.cboPeriodo2.FormattingEnabled = True
        Me.cboPeriodo2.Location = New System.Drawing.Point(416, 91)
        Me.cboPeriodo2.Name = "cboPeriodo2"
        Me.cboPeriodo2.Size = New System.Drawing.Size(121, 21)
        Me.cboPeriodo2.TabIndex = 21
        '
        'cboPeriodo
        '
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.Location = New System.Drawing.Point(273, 91)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(121, 21)
        Me.cboPeriodo.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(216, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Periodo:"
        '
        'dtpPeriodo
        '
        Me.dtpPeriodo.CustomFormat = "yyyy-MM"
        Me.dtpPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPeriodo.Location = New System.Drawing.Point(971, 94)
        Me.dtpPeriodo.Name = "dtpPeriodo"
        Me.dtpPeriodo.Size = New System.Drawing.Size(86, 20)
        Me.dtpPeriodo.TabIndex = 18
        Me.dtpPeriodo.Visible = False
        '
        'CuGroupBox2
        '
        Me.CuGroupBox2.BorderColor = System.Drawing.Color.Black
        Me.CuGroupBox2.Controls.Add(Me.lblTitulo)
        Me.CuGroupBox2.Controls.Add(Me.tsMantenimiento)
        Me.CuGroupBox2.Location = New System.Drawing.Point(199, 22)
        Me.CuGroupBox2.Name = "CuGroupBox2"
        Me.CuGroupBox2.Size = New System.Drawing.Size(874, 63)
        Me.CuGroupBox2.TabIndex = 17
        Me.CuGroupBox2.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(382, 23)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(261, 17)
        Me.lblTitulo.TabIndex = 25
        Me.lblTitulo.Text = "Reporte: Resumen Resultado Comercial"
        '
        'tsMantenimiento
        '
        Me.tsMantenimiento.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbConsular, Me.tsbExportarExcel, Me.ToolStripSeparator7, Me.tsbSalir})
        Me.tsMantenimiento.Location = New System.Drawing.Point(3, 16)
        Me.tsMantenimiento.Name = "tsMantenimiento"
        Me.tsMantenimiento.Size = New System.Drawing.Size(868, 39)
        Me.tsMantenimiento.TabIndex = 23
        Me.tsMantenimiento.Text = "ToolStrip1"
        '
        'tsbConsular
        '
        Me.tsbConsular.Image = CType(resources.GetObject("tsbConsular.Image"), System.Drawing.Image)
        Me.tsbConsular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConsular.Name = "tsbConsular"
        Me.tsbConsular.Size = New System.Drawing.Size(94, 36)
        Me.tsbConsular.Text = "Consultar"
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
        Me.CuGroupBox1.Location = New System.Drawing.Point(213, 151)
        Me.CuGroupBox1.Name = "CuGroupBox1"
        Me.CuGroupBox1.Size = New System.Drawing.Size(850, 252)
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
        Me.fxgrdExtraccionBd.Size = New System.Drawing.Size(838, 227)
        Me.fxgrdExtraccionBd.TabIndex = 0
        '
        'Comercial_Composicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 411)
        Me.Controls.Add(Me.gpoContratos)
        Me.Name = "Comercial_Composicion"
        Me.Text = "Comercial_Resultado"
        Me.gpoContratos.ResumeLayout(False)
        Me.gpoContratos.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.fxgrdComposicionVCM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.CuGroupBox2.ResumeLayout(False)
        Me.CuGroupBox2.PerformLayout()
        Me.tsMantenimiento.ResumeLayout(False)
        Me.tsMantenimiento.PerformLayout()
        Me.CuGroupBox1.ResumeLayout(False)
        CType(Me.fxgrdExtraccionBd, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpPeriodo As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rptReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tsbConsular As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboPeriodo2 As System.Windows.Forms.ComboBox
    Friend WithEvents CbSabana As System.Windows.Forms.CheckBox
    Friend WithEvents fxgrdComposicionVCM As C1FlexDataTree
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Rb_Amb As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_Ter As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_Vin As System.Windows.Forms.RadioButton
End Class
