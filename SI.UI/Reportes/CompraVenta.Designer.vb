<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompraVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CompraVenta))
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.gpoContratos = New CUGroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpPeriodo = New System.Windows.Forms.DateTimePicker()
        Me.CuGroupBox2 = New CUGroupBox()
        Me.tsMantenimiento = New System.Windows.Forms.ToolStrip()
        Me.tsbExportarExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.CuGroupBox1 = New CUGroupBox()
        Me.fxgrdExtraccionBd = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.gpoContratos.SuspendLayout()
        Me.CuGroupBox2.SuspendLayout()
        Me.tsMantenimiento.SuspendLayout()
        Me.CuGroupBox1.SuspendLayout()
        CType(Me.fxgrdExtraccionBd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpoContratos
        '
        Me.gpoContratos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoContratos.BackColor = System.Drawing.Color.LemonChiffon
        Me.gpoContratos.BorderColor = System.Drawing.Color.Black
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(219, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Periodo:"
        '
        'dtpPeriodo
        '
        Me.dtpPeriodo.CustomFormat = "yyyy-MM"
        Me.dtpPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPeriodo.Location = New System.Drawing.Point(271, 114)
        Me.dtpPeriodo.Name = "dtpPeriodo"
        Me.dtpPeriodo.Size = New System.Drawing.Size(86, 20)
        Me.dtpPeriodo.TabIndex = 18
        '
        'CuGroupBox2
        '
        Me.CuGroupBox2.BorderColor = System.Drawing.Color.Black
        Me.CuGroupBox2.Controls.Add(Me.tsMantenimiento)
        Me.CuGroupBox2.Location = New System.Drawing.Point(199, 21)
        Me.CuGroupBox2.Name = "CuGroupBox2"
        Me.CuGroupBox2.Size = New System.Drawing.Size(874, 63)
        Me.CuGroupBox2.TabIndex = 17
        Me.CuGroupBox2.TabStop = False
        '
        'tsMantenimiento
        '
        Me.tsMantenimiento.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExportarExcel, Me.ToolStripSeparator7, Me.tsbSalir})
        Me.tsMantenimiento.Location = New System.Drawing.Point(3, 16)
        Me.tsMantenimiento.Name = "tsMantenimiento"
        Me.tsMantenimiento.Size = New System.Drawing.Size(868, 39)
        Me.tsMantenimiento.TabIndex = 23
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
        Me.CuGroupBox1.Size = New System.Drawing.Size(850, 285)
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
        Me.fxgrdExtraccionBd.Size = New System.Drawing.Size(838, 260)
        Me.fxgrdExtraccionBd.TabIndex = 0
        '
        'CompraVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 411)
        Me.Controls.Add(Me.gpoContratos)
        Me.Name = "CompraVenta"
        Me.Text = "Compras destinadas a Ventas"
        Me.gpoContratos.ResumeLayout(False)
        Me.gpoContratos.PerformLayout()
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
End Class
