<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DocumentosVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DocumentosVenta))
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tsbConsulta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbExportarExcel = New System.Windows.Forms.ToolStripButton()
        Me.sfDialog = New System.Windows.Forms.SaveFileDialog()
        Me.gpoContratos = New CUGroupBox()
        Me.fxgrdDocumentosVenta = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.txtcorrelativoliquidacion = New CUTextbox()
        Me.txtCorrelativo = New CUTextbox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.tsMenu.SuspendLayout()
        Me.gpoContratos.SuspendLayout()
        CType(Me.fxgrdDocumentosVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 23)
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
        'tsbConsulta
        '
        Me.tsbConsulta.Image = Global.My.Resources.Resources.consultar
        Me.tsbConsulta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConsulta.Name = "tsbConsulta"
        Me.tsbConsulta.Size = New System.Drawing.Size(94, 36)
        Me.tsbConsulta.Text = "Consultar"
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
        'tsMenu
        '
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbConsulta, Me.tsbExportarExcel, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(1098, 39)
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
        'gpoContratos
        '
        Me.gpoContratos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoContratos.BackColor = System.Drawing.Color.Transparent
        Me.gpoContratos.BorderColor = System.Drawing.Color.Black
        Me.gpoContratos.Controls.Add(Me.fxgrdDocumentosVenta)
        Me.gpoContratos.Location = New System.Drawing.Point(12, 42)
        Me.gpoContratos.Name = "gpoContratos"
        Me.gpoContratos.Size = New System.Drawing.Size(1074, 389)
        Me.gpoContratos.TabIndex = 28
        Me.gpoContratos.TabStop = False
        Me.gpoContratos.Text = "Detalle"
        '
        'fxgrdDocumentosVenta
        '
        Me.fxgrdDocumentosVenta.AllowEditing = False
        Me.fxgrdDocumentosVenta.AllowFiltering = True
        Me.fxgrdDocumentosVenta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fxgrdDocumentosVenta.ColumnInfo = resources.GetString("fxgrdDocumentosVenta.ColumnInfo")
        Me.fxgrdDocumentosVenta.Location = New System.Drawing.Point(6, 19)
        Me.fxgrdDocumentosVenta.Name = "fxgrdDocumentosVenta"
        Me.fxgrdDocumentosVenta.Rows.Count = 13
        Me.fxgrdDocumentosVenta.Rows.DefaultSize = 19
        Me.fxgrdDocumentosVenta.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fxgrdDocumentosVenta.Size = New System.Drawing.Size(1062, 364)
        Me.fxgrdDocumentosVenta.TabIndex = 0
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
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(476, 12)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(207, 17)
        Me.lblTitulo.TabIndex = 29
        Me.lblTitulo.Text = "Reporte: Documentos de Venta"
        '
        'DocumentosVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1098, 443)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.gpoContratos)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.txtcorrelativoliquidacion)
        Me.Controls.Add(Me.txtCorrelativo)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.KeyPreview = True
        Me.Name = "DocumentosVenta"
        Me.Text = "Documentos de Lotes de Venta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.gpoContratos.ResumeLayout(False)
        CType(Me.fxgrdDocumentosVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtcorrelativoliquidacion As CUTextbox
    Friend WithEvents txtCorrelativo As CUTextbox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents gpoContratos As CUGroupBox
    Friend WithEvents fxgrdDocumentosVenta As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents tsbConsulta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents sfDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
End Class
