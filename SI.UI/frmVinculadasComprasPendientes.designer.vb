<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVinculadasComprasPendientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVinculadasComprasPendientes))
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbExportarExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ContratoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmGuardar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.msMenu = New System.Windows.Forms.MenuStrip()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.pdPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.pdPrintDialog = New System.Windows.Forms.PrintDialog()
        Me.sfdSaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.CuGroupBox1 = New CUGroupBox()
        Me.fxgLotesPendientes = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.txtcorrelativoliquidacion = New CUTextbox()
        Me.txtCorrelativo = New CUTextbox()
        Me.tsMenu.SuspendLayout()
        Me.msMenu.SuspendLayout()
        Me.CuGroupBox1.SuspendLayout()
        CType(Me.fxgLotesPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenu
        '
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExportarExcel, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(1087, 39)
        Me.tsMenu.TabIndex = 18
        Me.tsMenu.Text = "ToolStrip1"
        '
        'tsbExportarExcel
        '
        Me.tsbExportarExcel.Image = CType(resources.GetObject("tsbExportarExcel.Image"), System.Drawing.Image)
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
        'tsbSalir
        '
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(65, 36)
        Me.tsbSalir.Text = "Salir"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 23)
        '
        'ContratoToolStripMenuItem
        '
        Me.ContratoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmGuardar, Me.ToolStripSeparator2, Me.tsmSalir})
        Me.ContratoToolStripMenuItem.Name = "ContratoToolStripMenuItem"
        Me.ContratoToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.ContratoToolStripMenuItem.Text = "Lote"
        '
        'tsmGuardar
        '
        Me.tsmGuardar.Image = CType(resources.GetObject("tsmGuardar.Image"), System.Drawing.Image)
        Me.tsmGuardar.Name = "tsmGuardar"
        Me.tsmGuardar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.tsmGuardar.Size = New System.Drawing.Size(158, 22)
        Me.tsmGuardar.Text = "Guardar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(155, 6)
        '
        'tsmSalir
        '
        Me.tsmSalir.Name = "tsmSalir"
        Me.tsmSalir.Size = New System.Drawing.Size(158, 22)
        Me.tsmSalir.Text = "Salir"
        '
        'msMenu
        '
        Me.msMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContratoToolStripMenuItem})
        Me.msMenu.Location = New System.Drawing.Point(0, 0)
        Me.msMenu.Name = "msMenu"
        Me.msMenu.Size = New System.Drawing.Size(1362, 24)
        Me.msMenu.TabIndex = 17
        Me.msMenu.Text = "MenuStrip1"
        Me.msMenu.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(904, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Liquidacion"
        Me.Label15.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(724, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 13)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Lote"
        Me.Label14.Visible = False
        '
        'pdPrintDialog
        '
        Me.pdPrintDialog.UseEXDialog = True
        '
        'CuGroupBox1
        '
        Me.CuGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CuGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.CuGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.CuGroupBox1.Controls.Add(Me.fxgLotesPendientes)
        Me.CuGroupBox1.Location = New System.Drawing.Point(12, 42)
        Me.CuGroupBox1.Name = "CuGroupBox1"
        Me.CuGroupBox1.Size = New System.Drawing.Size(1063, 434)
        Me.CuGroupBox1.TabIndex = 23
        Me.CuGroupBox1.TabStop = False
        '
        'fxgLotesPendientes
        '
        Me.fxgLotesPendientes.AllowEditing = False
        Me.fxgLotesPendientes.AllowFiltering = True
        Me.fxgLotesPendientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fxgLotesPendientes.AutoGenerateColumns = False
        Me.fxgLotesPendientes.ColumnInfo = resources.GetString("fxgLotesPendientes.ColumnInfo")
        Me.fxgLotesPendientes.Location = New System.Drawing.Point(6, 19)
        Me.fxgLotesPendientes.Name = "fxgLotesPendientes"
        Me.fxgLotesPendientes.Rows.Count = 2
        Me.fxgLotesPendientes.Rows.DefaultSize = 19
        Me.fxgLotesPendientes.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.fxgLotesPendientes.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fxgLotesPendientes.Size = New System.Drawing.Size(1051, 409)
        Me.fxgLotesPendientes.TabIndex = 1
        '
        'txtcorrelativoliquidacion
        '
        Me.txtcorrelativoliquidacion.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtcorrelativoliquidacion.Enabled = False
        Me.txtcorrelativoliquidacion.Location = New System.Drawing.Point(967, 12)
        Me.txtcorrelativoliquidacion.MandatoryColor = System.Drawing.Color.Empty
        Me.txtcorrelativoliquidacion.MandatoryField = False
        Me.txtcorrelativoliquidacion.Name = "txtcorrelativoliquidacion"
        Me.txtcorrelativoliquidacion.Size = New System.Drawing.Size(120, 20)
        Me.txtcorrelativoliquidacion.TabIndex = 22
        Me.txtcorrelativoliquidacion.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtcorrelativoliquidacion.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtcorrelativoliquidacion.VCM_CustomInputTypeString = Nothing
        Me.txtcorrelativoliquidacion.VCM_CustomOmmitString = Nothing
        Me.txtcorrelativoliquidacion.VCM_EnterFocus = True
        Me.txtcorrelativoliquidacion.VCM_IsValidated = False
        Me.txtcorrelativoliquidacion.VCM_MensajeFoco = Nothing
        Me.txtcorrelativoliquidacion.VCM_MuestraMensajeFoco = False
        Me.txtcorrelativoliquidacion.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtcorrelativoliquidacion.VCM_RegularExpression = Nothing
        Me.txtcorrelativoliquidacion.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtcorrelativoliquidacion.VCM_ShowMessage = True
        Me.txtcorrelativoliquidacion.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroEntero
        Me.txtcorrelativoliquidacion.Visible = False
        '
        'txtCorrelativo
        '
        Me.txtCorrelativo.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtCorrelativo.Enabled = False
        Me.txtCorrelativo.Location = New System.Drawing.Point(778, 12)
        Me.txtCorrelativo.MandatoryColor = System.Drawing.Color.Empty
        Me.txtCorrelativo.MandatoryField = False
        Me.txtCorrelativo.Name = "txtCorrelativo"
        Me.txtCorrelativo.Size = New System.Drawing.Size(120, 20)
        Me.txtCorrelativo.TabIndex = 20
        Me.txtCorrelativo.Text = "0"
        Me.txtCorrelativo.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtCorrelativo.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtCorrelativo.VCM_CustomInputTypeString = Nothing
        Me.txtCorrelativo.VCM_CustomOmmitString = Nothing
        Me.txtCorrelativo.VCM_EnterFocus = True
        Me.txtCorrelativo.VCM_IsValidated = True
        Me.txtCorrelativo.VCM_MensajeFoco = Nothing
        Me.txtCorrelativo.VCM_MuestraMensajeFoco = False
        Me.txtCorrelativo.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtCorrelativo.VCM_RegularExpression = Nothing
        Me.txtCorrelativo.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtCorrelativo.VCM_ShowMessage = True
        Me.txtCorrelativo.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        Me.txtCorrelativo.Visible = False
        '
        'frmVinculadasComprasPendientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1087, 488)
        Me.Controls.Add(Me.CuGroupBox1)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.msMenu)
        Me.Controls.Add(Me.txtcorrelativoliquidacion)
        Me.Controls.Add(Me.txtCorrelativo)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.KeyPreview = True
        Me.Name = "frmVinculadasComprasPendientes"
        Me.Text = "Vinculadas con Lotes de Compras Pendiente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.msMenu.ResumeLayout(False)
        Me.msMenu.PerformLayout()
        Me.CuGroupBox1.ResumeLayout(False)
        CType(Me.fxgLotesPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContratoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmGuardar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents txtcorrelativoliquidacion As CUTextbox
    Friend WithEvents txtCorrelativo As CUTextbox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents pdPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents pdPrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents tsbExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents sfdSaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents CuGroupBox1 As CUGroupBox
    Friend WithEvents fxgLotesPendientes As C1.Win.C1FlexGrid.C1FlexGrid
End Class
