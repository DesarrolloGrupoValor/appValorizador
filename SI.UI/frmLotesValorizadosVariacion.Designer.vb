<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLotesValorizadosVariacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLotesValorizadosVariacion))
        Me.tsMantenimiento = New System.Windows.Forms.ToolStrip()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.tbLotesValorizados = New System.Windows.Forms.TabControl()
        Me.tpVariacion = New System.Windows.Forms.TabPage()
        Me.tpDetalleLog = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.tsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.gpoContratos = New CUGroupBox()
        Me.fxgLotesValorizadosVaricion = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.CuGroupBox2 = New CUGroupBox()
        Me.fxgLotesValorizadosTmLog = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.CuGroupBox1 = New CUGroupBox()
        Me.fxgLotesValorizadosLog = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tsMantenimiento.SuspendLayout()
        Me.tbLotesValorizados.SuspendLayout()
        Me.tpVariacion.SuspendLayout()
        Me.tpDetalleLog.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gpoContratos.SuspendLayout()
        CType(Me.fxgLotesValorizadosVaricion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CuGroupBox2.SuspendLayout()
        CType(Me.fxgLotesValorizadosTmLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CuGroupBox1.SuspendLayout()
        CType(Me.fxgLotesValorizadosLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMantenimiento
        '
        Me.tsMantenimiento.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbEditar, Me.tsbRefrescar, Me.ToolStripSeparator7, Me.tsbSalir})
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
        'tbLotesValorizados
        '
        Me.tbLotesValorizados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbLotesValorizados.Controls.Add(Me.tpVariacion)
        Me.tbLotesValorizados.Controls.Add(Me.tpDetalleLog)
        Me.tbLotesValorizados.Location = New System.Drawing.Point(0, 38)
        Me.tbLotesValorizados.Name = "tbLotesValorizados"
        Me.tbLotesValorizados.SelectedIndex = 0
        Me.tbLotesValorizados.Size = New System.Drawing.Size(1158, 595)
        Me.tbLotesValorizados.TabIndex = 22
        '
        'tpVariacion
        '
        Me.tpVariacion.BackColor = System.Drawing.Color.LemonChiffon
        Me.tpVariacion.Controls.Add(Me.gpoContratos)
        Me.tpVariacion.Location = New System.Drawing.Point(4, 22)
        Me.tpVariacion.Name = "tpVariacion"
        Me.tpVariacion.Padding = New System.Windows.Forms.Padding(3)
        Me.tpVariacion.Size = New System.Drawing.Size(1150, 569)
        Me.tpVariacion.TabIndex = 0
        Me.tpVariacion.Text = "Variaciones"
        '
        'tpDetalleLog
        '
        Me.tpDetalleLog.BackColor = System.Drawing.Color.LemonChiffon
        Me.tpDetalleLog.Controls.Add(Me.CuGroupBox2)
        Me.tpDetalleLog.Controls.Add(Me.CuGroupBox1)
        Me.tpDetalleLog.Location = New System.Drawing.Point(4, 22)
        Me.tpDetalleLog.Name = "tpDetalleLog"
        Me.tpDetalleLog.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDetalleLog.Size = New System.Drawing.Size(1150, 569)
        Me.tpDetalleLog.TabIndex = 1
        Me.tpDetalleLog.Text = "Detalle Log"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpFin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpInicio)
        Me.GroupBox1.Location = New System.Drawing.Point(287, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 54)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(229, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Final"
        '
        'dtpFin
        '
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(300, 20)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(100, 20)
        Me.dtpFin.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha Inicio"
        '
        'dtpInicio
        '
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(89, 20)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(100, 20)
        Me.dtpInicio.TabIndex = 0
        '
        'tsbEditar
        '
        Me.tsbEditar.Image = CType(resources.GetObject("tsbEditar.Image"), System.Drawing.Image)
        Me.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditar.Name = "tsbEditar"
        Me.tsbEditar.Size = New System.Drawing.Size(73, 36)
        Me.tsbEditar.Text = "Editar"
        '
        'gpoContratos
        '
        Me.gpoContratos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoContratos.BackColor = System.Drawing.Color.LemonChiffon
        Me.gpoContratos.BorderColor = System.Drawing.Color.Black
        Me.gpoContratos.Controls.Add(Me.fxgLotesValorizadosVaricion)
        Me.gpoContratos.Location = New System.Drawing.Point(6, 8)
        Me.gpoContratos.Name = "gpoContratos"
        Me.gpoContratos.Size = New System.Drawing.Size(1136, 553)
        Me.gpoContratos.TabIndex = 13
        Me.gpoContratos.TabStop = False
        '
        'fxgLotesValorizadosVaricion
        '
        Me.fxgLotesValorizadosVaricion.AllowEditing = False
        Me.fxgLotesValorizadosVaricion.AllowFiltering = True
        Me.fxgLotesValorizadosVaricion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fxgLotesValorizadosVaricion.ColumnInfo = resources.GetString("fxgLotesValorizadosVaricion.ColumnInfo")
        Me.fxgLotesValorizadosVaricion.Location = New System.Drawing.Point(6, 19)
        Me.fxgLotesValorizadosVaricion.Name = "fxgLotesValorizadosVaricion"
        Me.fxgLotesValorizadosVaricion.Rows.Count = 2
        Me.fxgLotesValorizadosVaricion.Rows.DefaultSize = 19
        Me.fxgLotesValorizadosVaricion.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fxgLotesValorizadosVaricion.Size = New System.Drawing.Size(1124, 528)
        Me.fxgLotesValorizadosVaricion.TabIndex = 0
        '
        'CuGroupBox2
        '
        Me.CuGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CuGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.CuGroupBox2.BorderColor = System.Drawing.Color.Black
        Me.CuGroupBox2.Controls.Add(Me.fxgLotesValorizadosTmLog)
        Me.CuGroupBox2.Location = New System.Drawing.Point(6, 356)
        Me.CuGroupBox2.Name = "CuGroupBox2"
        Me.CuGroupBox2.Size = New System.Drawing.Size(1134, 201)
        Me.CuGroupBox2.TabIndex = 15
        Me.CuGroupBox2.TabStop = False
        Me.CuGroupBox2.Text = "Lotes ValorizadosTM Log"
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
        Me.fxgLotesValorizadosTmLog.Size = New System.Drawing.Size(1122, 176)
        Me.fxgLotesValorizadosTmLog.TabIndex = 0
        '
        'CuGroupBox1
        '
        Me.CuGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CuGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.CuGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.CuGroupBox1.Controls.Add(Me.fxgLotesValorizadosLog)
        Me.CuGroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.CuGroupBox1.Name = "CuGroupBox1"
        Me.CuGroupBox1.Size = New System.Drawing.Size(1134, 328)
        Me.CuGroupBox1.TabIndex = 14
        Me.CuGroupBox1.TabStop = False
        Me.CuGroupBox1.Text = "Lotes Valorizados Log"
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
        Me.fxgLotesValorizadosLog.Size = New System.Drawing.Size(1122, 303)
        Me.fxgLotesValorizadosLog.TabIndex = 0
        '
        'frmLotesValorizadosVariacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1158, 633)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tbLotesValorizados)
        Me.Controls.Add(Me.tsMantenimiento)
        Me.Name = "frmLotesValorizadosVariacion"
        Me.Text = "Lotes Valorizados Con Variaciones"
        Me.tsMantenimiento.ResumeLayout(False)
        Me.tsMantenimiento.PerformLayout()
        Me.tbLotesValorizados.ResumeLayout(False)
        Me.tpVariacion.ResumeLayout(False)
        Me.tpDetalleLog.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gpoContratos.ResumeLayout(False)
        CType(Me.fxgLotesValorizadosVaricion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CuGroupBox2.ResumeLayout(False)
        CType(Me.fxgLotesValorizadosTmLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CuGroupBox1.ResumeLayout(False)
        CType(Me.fxgLotesValorizadosLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gpoContratos As CUGroupBox
    Friend WithEvents fxgLotesValorizadosVaricion As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents tsMantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbLotesValorizados As System.Windows.Forms.TabControl
    Friend WithEvents tpVariacion As System.Windows.Forms.TabPage
    Friend WithEvents tpDetalleLog As System.Windows.Forms.TabPage
    Friend WithEvents CuGroupBox1 As CUGroupBox
    Friend WithEvents fxgLotesValorizadosLog As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents CuGroupBox2 As CUGroupBox
    Friend WithEvents fxgLotesValorizadosTmLog As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents tsbEditar As System.Windows.Forms.ToolStripButton
End Class
