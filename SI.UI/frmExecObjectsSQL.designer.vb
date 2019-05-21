<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExecObjectsSQL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExecObjectsSQL))
        Me.tsMantenimiento = New System.Windows.Forms.ToolStrip()
        Me.tsbFiltrar = New System.Windows.Forms.ToolStripButton()
        Me.tsbExportarExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.gpoTabla = New System.Windows.Forms.GroupBox()
        Me.cboTablaDet = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gpoDetalle = New System.Windows.Forms.GroupBox()
        Me.fxgrdMantenimiento = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.sfDialog = New System.Windows.Forms.SaveFileDialog()
        Me.tsMantenimiento.SuspendLayout()
        Me.gpoTabla.SuspendLayout()
        Me.gpoDetalle.SuspendLayout()
        CType(Me.fxgrdMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMantenimiento
        '
        Me.tsMantenimiento.BackColor = System.Drawing.SystemColors.Control
        Me.tsMantenimiento.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbFiltrar, Me.tsbExportarExcel, Me.ToolStripSeparator4, Me.tsbSalir})
        Me.tsMantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.tsMantenimiento.Name = "tsMantenimiento"
        Me.tsMantenimiento.Size = New System.Drawing.Size(931, 39)
        Me.tsMantenimiento.TabIndex = 1
        Me.tsMantenimiento.Text = "ToolStrip1"
        '
        'tsbFiltrar
        '
        Me.tsbFiltrar.Image = Global.My.Resources.Resources.consultar
        Me.tsbFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbFiltrar.Name = "tsbFiltrar"
        Me.tsbFiltrar.Size = New System.Drawing.Size(88, 36)
        Me.tsbFiltrar.Text = "Procesar"
        '
        'tsbExportarExcel
        '
        Me.tsbExportarExcel.Image = CType(resources.GetObject("tsbExportarExcel.Image"), System.Drawing.Image)
        Me.tsbExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportarExcel.Name = "tsbExportarExcel"
        Me.tsbExportarExcel.Size = New System.Drawing.Size(124, 36)
        Me.tsbExportarExcel.Text = "Exportar a Excel"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'tsbSalir
        '
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(65, 36)
        Me.tsbSalir.Text = "Salir"
        '
        'gpoTabla
        '
        Me.gpoTabla.BackColor = System.Drawing.Color.Transparent
        Me.gpoTabla.Controls.Add(Me.cboTablaDet)
        Me.gpoTabla.Controls.Add(Me.Label1)
        Me.gpoTabla.Location = New System.Drawing.Point(8, 34)
        Me.gpoTabla.Name = "gpoTabla"
        Me.gpoTabla.Size = New System.Drawing.Size(535, 49)
        Me.gpoTabla.TabIndex = 2
        Me.gpoTabla.TabStop = False
        '
        'cboTablaDet
        '
        Me.cboTablaDet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTablaDet.FormattingEnabled = True
        Me.cboTablaDet.Location = New System.Drawing.Point(144, 17)
        Me.cboTablaDet.Name = "cboTablaDet"
        Me.cboTablaDet.Size = New System.Drawing.Size(376, 21)
        Me.cboTablaDet.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione Tabla"
        '
        'gpoDetalle
        '
        Me.gpoDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoDetalle.BackColor = System.Drawing.Color.Transparent
        Me.gpoDetalle.Controls.Add(Me.fxgrdMantenimiento)
        Me.gpoDetalle.Location = New System.Drawing.Point(6, 89)
        Me.gpoDetalle.Name = "gpoDetalle"
        Me.gpoDetalle.Size = New System.Drawing.Size(917, 405)
        Me.gpoDetalle.TabIndex = 3
        Me.gpoDetalle.TabStop = False
        '
        'fxgrdMantenimiento
        '
        Me.fxgrdMantenimiento.AllowEditing = False
        Me.fxgrdMantenimiento.AllowFiltering = True
        Me.fxgrdMantenimiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fxgrdMantenimiento.ColumnInfo = "10,1,0,0,0,95,Columns:0{AllowFiltering:ByValue;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{AllowFiltering:ByValue;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fxgrdMantenimiento.Location = New System.Drawing.Point(6, 10)
        Me.fxgrdMantenimiento.Name = "fxgrdMantenimiento"
        Me.fxgrdMantenimiento.Rows.Count = 2
        Me.fxgrdMantenimiento.Rows.DefaultSize = 19
        Me.fxgrdMantenimiento.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fxgrdMantenimiento.Size = New System.Drawing.Size(905, 389)
        Me.fxgrdMantenimiento.TabIndex = 0
        '
        'frmExecObjectsSQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(931, 498)
        Me.Controls.Add(Me.gpoTabla)
        Me.Controls.Add(Me.tsMantenimiento)
        Me.Controls.Add(Me.gpoDetalle)
        Me.KeyPreview = True
        Me.Name = "frmExecObjectsSQL"
        Me.Text = "Ejecutar Objetos Base de Datos"
        Me.tsMantenimiento.ResumeLayout(False)
        Me.tsMantenimiento.PerformLayout()
        Me.gpoTabla.ResumeLayout(False)
        Me.gpoTabla.PerformLayout()
        Me.gpoDetalle.ResumeLayout(False)
        CType(Me.fxgrdMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents gpoTabla As System.Windows.Forms.GroupBox
    Friend WithEvents cboTablaDet As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gpoDetalle As System.Windows.Forms.GroupBox
    'System.Windows.Forms.TextBox
    'System.Windows.Forms.TextBox
    Friend WithEvents fxgrdMantenimiento As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents tsbExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbFiltrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents sfDialog As System.Windows.Forms.SaveFileDialog

End Class
