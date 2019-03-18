<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerarQPs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenerarQPs))
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.gpoContratos = New CUGroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbGenerar = New System.Windows.Forms.ToolStripButton()
        Me.tsbExportar = New System.Windows.Forms.ToolStripButton()
        Me.tsbExportarDetalle = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalirGenerar = New System.Windows.Forms.ToolStripButton()
        Me.tcControl = New System.Windows.Forms.TabControl()
        Me.tpLista = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.fgxGenerarQPDetalle = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.CuGroupBox3 = New CUGroupBox()
        Me.fgxGenerarQP = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tpGenerar = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.fgxGenerarQPDetalleN = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.CuGroupBox1 = New CUGroupBox()
        Me.fgxGenerarQP_N = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gpoContratos.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.tcControl.SuspendLayout()
        Me.tpLista.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.fgxGenerarQPDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CuGroupBox3.SuspendLayout()
        CType(Me.fgxGenerarQP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpGenerar.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.fgxGenerarQPDetalleN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CuGroupBox1.SuspendLayout()
        CType(Me.fgxGenerarQP_N, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpoContratos
        '
        Me.gpoContratos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoContratos.BackColor = System.Drawing.Color.LemonChiffon
        Me.gpoContratos.BorderColor = System.Drawing.Color.Black
        Me.gpoContratos.Controls.Add(Me.GroupBox3)
        Me.gpoContratos.Controls.Add(Me.tcControl)
        Me.gpoContratos.Location = New System.Drawing.Point(-201, -37)
        Me.gpoContratos.Name = "gpoContratos"
        Me.gpoContratos.Size = New System.Drawing.Size(1765, 638)
        Me.gpoContratos.TabIndex = 16
        Me.gpoContratos.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ToolStrip2)
        Me.GroupBox3.Location = New System.Drawing.Point(196, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1365, 57)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbRefrescar, Me.ToolStripSeparator4, Me.tsbGenerar, Me.tsbExportar, Me.tsbExportarDetalle, Me.ToolStripSeparator3, Me.tsbSalirGenerar})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1359, 39)
        Me.ToolStrip2.TabIndex = 25
        Me.ToolStrip2.Text = "ToolStrip1"
        '
        'tsbRefrescar
        '
        Me.tsbRefrescar.Image = CType(resources.GetObject("tsbRefrescar.Image"), System.Drawing.Image)
        Me.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRefrescar.Name = "tsbRefrescar"
        Me.tsbRefrescar.Size = New System.Drawing.Size(91, 36)
        Me.tsbRefrescar.Text = "Refrescar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'tsbGenerar
        '
        Me.tsbGenerar.Image = Global.My.Resources.Resources.adelantos
        Me.tsbGenerar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGenerar.Name = "tsbGenerar"
        Me.tsbGenerar.Size = New System.Drawing.Size(84, 36)
        Me.tsbGenerar.Text = "Generar"
        '
        'tsbExportar
        '
        Me.tsbExportar.Image = CType(resources.GetObject("tsbExportar.Image"), System.Drawing.Image)
        Me.tsbExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportar.Name = "tsbExportar"
        Me.tsbExportar.Size = New System.Drawing.Size(124, 36)
        Me.tsbExportar.Text = "Exportar a Excel"
        '
        'tsbExportarDetalle
        '
        Me.tsbExportarDetalle.Image = CType(resources.GetObject("tsbExportarDetalle.Image"), System.Drawing.Image)
        Me.tsbExportarDetalle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportarDetalle.Name = "tsbExportarDetalle"
        Me.tsbExportarDetalle.Size = New System.Drawing.Size(163, 36)
        Me.tsbExportarDetalle.Text = "Exportar Detalle a Excel"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'tsbSalirGenerar
        '
        Me.tsbSalirGenerar.Image = CType(resources.GetObject("tsbSalirGenerar.Image"), System.Drawing.Image)
        Me.tsbSalirGenerar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalirGenerar.Name = "tsbSalirGenerar"
        Me.tsbSalirGenerar.Size = New System.Drawing.Size(65, 36)
        Me.tsbSalirGenerar.Text = "Salir"
        '
        'tcControl
        '
        Me.tcControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcControl.Controls.Add(Me.tpLista)
        Me.tcControl.Controls.Add(Me.tpGenerar)
        Me.tcControl.Location = New System.Drawing.Point(202, 85)
        Me.tcControl.Name = "tcControl"
        Me.tcControl.SelectedIndex = 0
        Me.tcControl.Size = New System.Drawing.Size(1359, 514)
        Me.tcControl.TabIndex = 25
        '
        'tpLista
        '
        Me.tpLista.BackColor = System.Drawing.Color.LemonChiffon
        Me.tpLista.Controls.Add(Me.GroupBox1)
        Me.tpLista.Controls.Add(Me.CuGroupBox3)
        Me.tpLista.Location = New System.Drawing.Point(4, 22)
        Me.tpLista.Name = "tpLista"
        Me.tpLista.Padding = New System.Windows.Forms.Padding(3)
        Me.tpLista.Size = New System.Drawing.Size(1351, 488)
        Me.tpLista.TabIndex = 0
        Me.tpLista.Text = "Lista"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.fgxGenerarQPDetalle)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 292)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1340, 189)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle"
        '
        'fgxGenerarQPDetalle
        '
        Me.fgxGenerarQPDetalle.AllowEditing = False
        Me.fgxGenerarQPDetalle.AllowFiltering = True
        Me.fgxGenerarQPDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgxGenerarQPDetalle.AutoGenerateColumns = False
        Me.fgxGenerarQPDetalle.ColumnInfo = resources.GetString("fgxGenerarQPDetalle.ColumnInfo")
        Me.fgxGenerarQPDetalle.Location = New System.Drawing.Point(3, 15)
        Me.fgxGenerarQPDetalle.Name = "fgxGenerarQPDetalle"
        Me.fgxGenerarQPDetalle.Rows.Count = 2
        Me.fgxGenerarQPDetalle.Rows.DefaultSize = 19
        Me.fgxGenerarQPDetalle.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.fgxGenerarQPDetalle.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fgxGenerarQPDetalle.Size = New System.Drawing.Size(1331, 164)
        Me.fgxGenerarQPDetalle.TabIndex = 25
        '
        'CuGroupBox3
        '
        Me.CuGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.CuGroupBox3.BorderColor = System.Drawing.Color.Transparent
        Me.CuGroupBox3.Controls.Add(Me.fgxGenerarQP)
        Me.CuGroupBox3.Location = New System.Drawing.Point(4, 7)
        Me.CuGroupBox3.Name = "CuGroupBox3"
        Me.CuGroupBox3.Size = New System.Drawing.Size(1337, 279)
        Me.CuGroupBox3.TabIndex = 17
        Me.CuGroupBox3.TabStop = False
        '
        'fgxGenerarQP
        '
        Me.fgxGenerarQP.AllowEditing = False
        Me.fgxGenerarQP.AllowFiltering = True
        Me.fgxGenerarQP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgxGenerarQP.AutoGenerateColumns = False
        Me.fgxGenerarQP.ColumnInfo = resources.GetString("fgxGenerarQP.ColumnInfo")
        Me.fgxGenerarQP.Location = New System.Drawing.Point(3, 14)
        Me.fgxGenerarQP.Name = "fgxGenerarQP"
        Me.fgxGenerarQP.Rows.Count = 2
        Me.fgxGenerarQP.Rows.DefaultSize = 19
        Me.fgxGenerarQP.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.fgxGenerarQP.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fgxGenerarQP.Size = New System.Drawing.Size(1332, 254)
        Me.fgxGenerarQP.TabIndex = 0
        '
        'tpGenerar
        '
        Me.tpGenerar.BackColor = System.Drawing.Color.LemonChiffon
        Me.tpGenerar.Controls.Add(Me.GroupBox2)
        Me.tpGenerar.Controls.Add(Me.CuGroupBox1)
        Me.tpGenerar.Controls.Add(Me.cboPeriodo)
        Me.tpGenerar.Controls.Add(Me.Label1)
        Me.tpGenerar.Location = New System.Drawing.Point(4, 22)
        Me.tpGenerar.Name = "tpGenerar"
        Me.tpGenerar.Padding = New System.Windows.Forms.Padding(3)
        Me.tpGenerar.Size = New System.Drawing.Size(1351, 488)
        Me.tpGenerar.TabIndex = 1
        Me.tpGenerar.Text = "Generar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.fgxGenerarQPDetalleN)
        Me.GroupBox2.Location = New System.Drawing.Point(941, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(405, 454)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle"
        '
        'fgxGenerarQPDetalleN
        '
        Me.fgxGenerarQPDetalleN.AllowEditing = False
        Me.fgxGenerarQPDetalleN.AllowFiltering = True
        Me.fgxGenerarQPDetalleN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.fgxGenerarQPDetalleN.AutoGenerateColumns = False
        Me.fgxGenerarQPDetalleN.ColumnInfo = resources.GetString("fgxGenerarQPDetalleN.ColumnInfo")
        Me.fgxGenerarQPDetalleN.Location = New System.Drawing.Point(3, 15)
        Me.fgxGenerarQPDetalleN.Name = "fgxGenerarQPDetalleN"
        Me.fgxGenerarQPDetalleN.Rows.Count = 2
        Me.fgxGenerarQPDetalleN.Rows.DefaultSize = 19
        Me.fgxGenerarQPDetalleN.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.fgxGenerarQPDetalleN.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fgxGenerarQPDetalleN.Size = New System.Drawing.Size(400, 429)
        Me.fgxGenerarQPDetalleN.TabIndex = 25
        '
        'CuGroupBox1
        '
        Me.CuGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CuGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.CuGroupBox1.BorderColor = System.Drawing.Color.Transparent
        Me.CuGroupBox1.Controls.Add(Me.fgxGenerarQP_N)
        Me.CuGroupBox1.Location = New System.Drawing.Point(3, 29)
        Me.CuGroupBox1.Name = "CuGroupBox1"
        Me.CuGroupBox1.Size = New System.Drawing.Size(935, 453)
        Me.CuGroupBox1.TabIndex = 27
        Me.CuGroupBox1.TabStop = False
        '
        'fgxGenerarQP_N
        '
        Me.fgxGenerarQP_N.AllowEditing = False
        Me.fgxGenerarQP_N.AllowFiltering = True
        Me.fgxGenerarQP_N.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgxGenerarQP_N.AutoGenerateColumns = False
        Me.fgxGenerarQP_N.ColumnInfo = resources.GetString("fgxGenerarQP_N.ColumnInfo")
        Me.fgxGenerarQP_N.Location = New System.Drawing.Point(3, 14)
        Me.fgxGenerarQP_N.Name = "fgxGenerarQP_N"
        Me.fgxGenerarQP_N.Rows.Count = 2
        Me.fgxGenerarQP_N.Rows.DefaultSize = 19
        Me.fgxGenerarQP_N.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.fgxGenerarQP_N.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fgxGenerarQP_N.Size = New System.Drawing.Size(930, 428)
        Me.fgxGenerarQP_N.TabIndex = 0
        '
        'cboPeriodo
        '
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.Location = New System.Drawing.Point(60, 6)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(121, 21)
        Me.cboPeriodo.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Periodo:"
        '
        'GenerarQPs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1362, 564)
        Me.Controls.Add(Me.gpoContratos)
        Me.Name = "GenerarQPs"
        Me.Text = "Generar QPs"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gpoContratos.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.tcControl.ResumeLayout(False)
        Me.tpLista.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.fgxGenerarQPDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CuGroupBox3.ResumeLayout(False)
        CType(Me.fgxGenerarQP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpGenerar.ResumeLayout(False)
        Me.tpGenerar.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.fgxGenerarQPDetalleN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CuGroupBox1.ResumeLayout(False)
        CType(Me.fgxGenerarQP_N, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpoContratos As CUGroupBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents tcControl As System.Windows.Forms.TabControl
    Friend WithEvents tpLista As System.Windows.Forms.TabPage
    Friend WithEvents tpGenerar As System.Windows.Forms.TabPage
    Friend WithEvents CuGroupBox3 As CUGroupBox
    Friend WithEvents fgxGenerarQP As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents tsbGenerar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbExportarDetalle As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalirGenerar As System.Windows.Forms.ToolStripButton
    Friend WithEvents fgxGenerarQPDetalle As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents fgxGenerarQPDetalleN As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents CuGroupBox1 As CUGroupBox
    Friend WithEvents fgxGenerarQP_N As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbExportar As System.Windows.Forms.ToolStripButton
End Class
