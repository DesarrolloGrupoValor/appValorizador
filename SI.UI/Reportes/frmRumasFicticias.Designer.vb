<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRumasFicticias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRumasFicticias))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbConsulta = New System.Windows.Forms.ToolStripButton()
        Me.tsbExportarExcel = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gpoContratos = New CUGroupBox()
        Me.fxgRumasFicticias = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.sfDialog = New System.Windows.Forms.SaveFileDialog()
        Me.ToolStrip1.SuspendLayout()
        Me.gpoContratos.SuspendLayout()
        CType(Me.fxgRumasFicticias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbConsulta, Me.tsbExportarExcel, Me.tsbSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1098, 39)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbConsulta
        '
        Me.tsbConsulta.Image = Global.My.Resources.Resources.consultar
        Me.tsbConsulta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConsulta.Name = "tsbConsulta"
        Me.tsbConsulta.Size = New System.Drawing.Size(94, 36)
        Me.tsbConsulta.Text = "Consultar"
        '
        'tsbExportarExcel
        '
        Me.tsbExportarExcel.Image = Global.My.Resources.Resources.asociar_
        Me.tsbExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportarExcel.Name = "tsbExportarExcel"
        Me.tsbExportarExcel.Size = New System.Drawing.Size(124, 36)
        Me.tsbExportarExcel.Text = "Exportar a Excel"
        '
        'tsbSalir
        '
        Me.tsbSalir.Image = Global.My.Resources.Resources.salir
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(65, 36)
        Me.tsbSalir.Text = "Salir"
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.SystemColors.Control
        Me.txtCantidad.Location = New System.Drawing.Point(139, 51)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(65, 20)
        Me.txtCantidad.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cantidad de Registros"
        '
        'gpoContratos
        '
        Me.gpoContratos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoContratos.BackColor = System.Drawing.Color.Transparent
        Me.gpoContratos.BorderColor = System.Drawing.Color.Black
        Me.gpoContratos.Controls.Add(Me.fxgRumasFicticias)
        Me.gpoContratos.Location = New System.Drawing.Point(12, 77)
        Me.gpoContratos.Name = "gpoContratos"
        Me.gpoContratos.Size = New System.Drawing.Size(1074, 357)
        Me.gpoContratos.TabIndex = 28
        Me.gpoContratos.TabStop = False
        Me.gpoContratos.Text = "Detalle"
        '
        'fxgRumasFicticias
        '
        Me.fxgRumasFicticias.AllowEditing = False
        Me.fxgRumasFicticias.AllowFiltering = True
        Me.fxgRumasFicticias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fxgRumasFicticias.ColumnInfo = resources.GetString("fxgRumasFicticias.ColumnInfo")
        Me.fxgRumasFicticias.Location = New System.Drawing.Point(6, 18)
        Me.fxgRumasFicticias.Name = "fxgRumasFicticias"
        Me.fxgRumasFicticias.Rows.Count = 2
        Me.fxgRumasFicticias.Rows.DefaultSize = 19
        Me.fxgRumasFicticias.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fxgRumasFicticias.Size = New System.Drawing.Size(1062, 332)
        Me.fxgRumasFicticias.TabIndex = 2
        '
        'frmRumasFicticias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1098, 443)
        Me.Controls.Add(Me.gpoContratos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmRumasFicticias"
        Me.Text = "Rumas Ficticias"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gpoContratos.ResumeLayout(False)
        CType(Me.fxgRumasFicticias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbConsulta As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gpoContratos As CUGroupBox
    Friend WithEvents fxgRumasFicticias As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents sfDialog As System.Windows.Forms.SaveFileDialog
End Class
