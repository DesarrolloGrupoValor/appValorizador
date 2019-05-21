<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionComercial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionComercial))
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.tsbAnular = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tsbConsulta = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbGenerarFactura = New System.Windows.Forms.ToolStripButton()
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
        Me.tcGestionComercial = New System.Windows.Forms.TabControl()
        Me.tpLista = New System.Windows.Forms.TabPage()
        Me.fgxGestionComercial_Registro_Sel = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tpRegistro = New System.Windows.Forms.TabPage()
        Me.gbDatos = New CUGroupBox()
        Me.txtIgv = New CUTextbox()
        Me.txtValorNeto = New CUTextbox()
        Me.txtTMH = New CUTextbox()
        Me.txtValorTotal = New CUTextbox()
        Me.txtvalorIGV = New CUTextbox()
        Me.txtTMNS = New CUTextbox()
        Me.txtTMS = New CUTextbox()
        Me.txtComision = New CUTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumeroDocumento = New System.Windows.Forms.TextBox()
        Me.dtpFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.cboAnio = New System.Windows.Forms.ComboBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboEmpresa = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboEmisor = New System.Windows.Forms.ComboBox()
        Me.lblempresa = New System.Windows.Forms.Label()
        Me.gpoContratos = New CUGroupBox()
        Me.fxgrdGestionComercial = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.txtcorrelativoliquidacion = New CUTextbox()
        Me.txtCorrelativo = New CUTextbox()
        Me.tsMenu.SuspendLayout()
        Me.msMenu.SuspendLayout()
        Me.tcGestionComercial.SuspendLayout()
        Me.tpLista.SuspendLayout()
        CType(Me.fgxGestionComercial_Registro_Sel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpRegistro.SuspendLayout()
        Me.gbDatos.SuspendLayout()
        Me.gpoContratos.SuspendLayout()
        CType(Me.fxgrdGestionComercial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenu
        '
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbRefrescar, Me.tsbAnular, Me.ToolStripSeparator4, Me.tsbNuevo, Me.tsbConsulta, Me.tsbGuardar, Me.tsbGenerarFactura, Me.tsbExportarExcel, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(1098, 39)
        Me.tsMenu.TabIndex = 18
        Me.tsMenu.Text = "ToolStrip1"
        '
        'tsbRefrescar
        '
        Me.tsbRefrescar.Image = Global.My.Resources.Resources.refrescar
        Me.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRefrescar.Name = "tsbRefrescar"
        Me.tsbRefrescar.Size = New System.Drawing.Size(91, 36)
        Me.tsbRefrescar.Text = "Refrescar"
        '
        'tsbAnular
        '
        Me.tsbAnular.Image = Global.My.Resources.Resources.eliminar
        Me.tsbAnular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAnular.Name = "tsbAnular"
        Me.tsbAnular.Size = New System.Drawing.Size(78, 36)
        Me.tsbAnular.Text = "Anular"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'tsbNuevo
        '
        Me.tsbNuevo.Image = Global.My.Resources.Resources.nuevo
        Me.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(78, 36)
        Me.tsbNuevo.Text = "Nuevo"
        '
        'tsbConsulta
        '
        Me.tsbConsulta.Image = Global.My.Resources.Resources.consultar
        Me.tsbConsulta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConsulta.Name = "tsbConsulta"
        Me.tsbConsulta.Size = New System.Drawing.Size(94, 36)
        Me.tsbConsulta.Text = "Consultar"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Image = Global.My.Resources.Resources.guardar
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(85, 36)
        Me.tsbGuardar.Text = "Guardar"
        '
        'tsbGenerarFactura
        '
        Me.tsbGenerarFactura.Image = Global.My.Resources.Resources.adelantos
        Me.tsbGenerarFactura.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGenerarFactura.Name = "tsbGenerarFactura"
        Me.tsbGenerarFactura.Size = New System.Drawing.Size(126, 36)
        Me.tsbGenerarFactura.Text = "Generar Factura"
        Me.tsbGenerarFactura.Visible = False
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
        'pdPrintDocument
        '
        '
        'pdPrintDialog
        '
        Me.pdPrintDialog.UseEXDialog = True
        '
        'tcGestionComercial
        '
        Me.tcGestionComercial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcGestionComercial.Controls.Add(Me.tpLista)
        Me.tcGestionComercial.Controls.Add(Me.tpRegistro)
        Me.tcGestionComercial.Location = New System.Drawing.Point(0, 42)
        Me.tcGestionComercial.Name = "tcGestionComercial"
        Me.tcGestionComercial.SelectedIndex = 0
        Me.tcGestionComercial.Size = New System.Drawing.Size(1095, 398)
        Me.tcGestionComercial.TabIndex = 30
        '
        'tpLista
        '
        Me.tpLista.BackColor = System.Drawing.Color.LemonChiffon
        Me.tpLista.Controls.Add(Me.fgxGestionComercial_Registro_Sel)
        Me.tpLista.Location = New System.Drawing.Point(4, 22)
        Me.tpLista.Name = "tpLista"
        Me.tpLista.Padding = New System.Windows.Forms.Padding(3)
        Me.tpLista.Size = New System.Drawing.Size(1087, 372)
        Me.tpLista.TabIndex = 1
        Me.tpLista.Text = "Lista"
        '
        'fgxGestionComercial_Registro_Sel
        '
        Me.fgxGestionComercial_Registro_Sel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgxGestionComercial_Registro_Sel.AutoGenerateColumns = False
        Me.fgxGestionComercial_Registro_Sel.ColumnInfo = resources.GetString("fgxGestionComercial_Registro_Sel.ColumnInfo")
        Me.fgxGestionComercial_Registro_Sel.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw
        Me.fgxGestionComercial_Registro_Sel.Location = New System.Drawing.Point(6, 16)
        Me.fgxGestionComercial_Registro_Sel.Name = "fgxGestionComercial_Registro_Sel"
        Me.fgxGestionComercial_Registro_Sel.Rows.DefaultSize = 19
        Me.fgxGestionComercial_Registro_Sel.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fgxGestionComercial_Registro_Sel.Size = New System.Drawing.Size(1075, 350)
        Me.fgxGestionComercial_Registro_Sel.TabIndex = 30
        '
        'tpRegistro
        '
        Me.tpRegistro.BackColor = System.Drawing.Color.LemonChiffon
        Me.tpRegistro.Controls.Add(Me.gbDatos)
        Me.tpRegistro.Controls.Add(Me.gpoContratos)
        Me.tpRegistro.Location = New System.Drawing.Point(4, 22)
        Me.tpRegistro.Name = "tpRegistro"
        Me.tpRegistro.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRegistro.Size = New System.Drawing.Size(1087, 372)
        Me.tpRegistro.TabIndex = 0
        Me.tpRegistro.Text = "Registro Datos"
        '
        'gbDatos
        '
        Me.gbDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbDatos.BorderColor = System.Drawing.Color.Black
        Me.gbDatos.Controls.Add(Me.txtIgv)
        Me.gbDatos.Controls.Add(Me.txtValorNeto)
        Me.gbDatos.Controls.Add(Me.txtTMH)
        Me.gbDatos.Controls.Add(Me.txtValorTotal)
        Me.gbDatos.Controls.Add(Me.txtvalorIGV)
        Me.gbDatos.Controls.Add(Me.txtTMNS)
        Me.gbDatos.Controls.Add(Me.txtTMS)
        Me.gbDatos.Controls.Add(Me.txtComision)
        Me.gbDatos.Controls.Add(Me.Label10)
        Me.gbDatos.Controls.Add(Me.Label36)
        Me.gbDatos.Controls.Add(Me.Label9)
        Me.gbDatos.Controls.Add(Me.Label7)
        Me.gbDatos.Controls.Add(Me.Label8)
        Me.gbDatos.Controls.Add(Me.Label6)
        Me.gbDatos.Controls.Add(Me.Label3)
        Me.gbDatos.Controls.Add(Me.Label20)
        Me.gbDatos.Controls.Add(Me.Label43)
        Me.gbDatos.Controls.Add(Me.Label4)
        Me.gbDatos.Controls.Add(Me.Label2)
        Me.gbDatos.Controls.Add(Me.txtNumeroDocumento)
        Me.gbDatos.Controls.Add(Me.dtpFechaEmision)
        Me.gbDatos.Controls.Add(Me.cboAnio)
        Me.gbDatos.Controls.Add(Me.cboMes)
        Me.gbDatos.Controls.Add(Me.cboTipoDocumento)
        Me.gbDatos.Controls.Add(Me.Label5)
        Me.gbDatos.Controls.Add(Me.cboEmpresa)
        Me.gbDatos.Controls.Add(Me.Label1)
        Me.gbDatos.Controls.Add(Me.cboEmisor)
        Me.gbDatos.Controls.Add(Me.lblempresa)
        Me.gbDatos.Location = New System.Drawing.Point(11, 7)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(1074, 102)
        Me.gbDatos.TabIndex = 25
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Datos Generales"
        '
        'txtIgv
        '
        Me.txtIgv.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtIgv.Location = New System.Drawing.Point(622, 71)
        Me.txtIgv.MandatoryColor = System.Drawing.Color.Empty
        Me.txtIgv.MandatoryField = False
        Me.txtIgv.MaxLength = 10
        Me.txtIgv.Name = "txtIgv"
        Me.txtIgv.ReadOnly = True
        Me.txtIgv.Size = New System.Drawing.Size(67, 20)
        Me.txtIgv.TabIndex = 6
        Me.txtIgv.Text = "0"
        Me.txtIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIgv.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtIgv.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtIgv.VCM_CustomInputTypeString = Nothing
        Me.txtIgv.VCM_CustomOmmitString = Nothing
        Me.txtIgv.VCM_EnterFocus = True
        Me.txtIgv.VCM_IsValidated = False
        Me.txtIgv.VCM_MensajeFoco = Nothing
        Me.txtIgv.VCM_MuestraMensajeFoco = False
        Me.txtIgv.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.TresDecimales
        Me.txtIgv.VCM_RegularExpression = Nothing
        Me.txtIgv.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtIgv.VCM_ShowMessage = True
        Me.txtIgv.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'txtValorNeto
        '
        Me.txtValorNeto.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtValorNeto.Location = New System.Drawing.Point(957, 19)
        Me.txtValorNeto.MandatoryColor = System.Drawing.Color.Empty
        Me.txtValorNeto.MandatoryField = False
        Me.txtValorNeto.MaxLength = 10
        Me.txtValorNeto.Name = "txtValorNeto"
        Me.txtValorNeto.ReadOnly = True
        Me.txtValorNeto.Size = New System.Drawing.Size(100, 20)
        Me.txtValorNeto.TabIndex = 5
        Me.txtValorNeto.Text = "0"
        Me.txtValorNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorNeto.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtValorNeto.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtValorNeto.VCM_CustomInputTypeString = Nothing
        Me.txtValorNeto.VCM_CustomOmmitString = Nothing
        Me.txtValorNeto.VCM_EnterFocus = True
        Me.txtValorNeto.VCM_IsValidated = False
        Me.txtValorNeto.VCM_MensajeFoco = Nothing
        Me.txtValorNeto.VCM_MuestraMensajeFoco = False
        Me.txtValorNeto.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.TresDecimales
        Me.txtValorNeto.VCM_RegularExpression = Nothing
        Me.txtValorNeto.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtValorNeto.VCM_ShowMessage = True
        Me.txtValorNeto.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'txtTMH
        '
        Me.txtTMH.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtTMH.Location = New System.Drawing.Point(774, 19)
        Me.txtTMH.MandatoryColor = System.Drawing.Color.Empty
        Me.txtTMH.MandatoryField = False
        Me.txtTMH.MaxLength = 10
        Me.txtTMH.Name = "txtTMH"
        Me.txtTMH.ReadOnly = True
        Me.txtTMH.Size = New System.Drawing.Size(100, 20)
        Me.txtTMH.TabIndex = 5
        Me.txtTMH.Text = "0"
        Me.txtTMH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTMH.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtTMH.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtTMH.VCM_CustomInputTypeString = Nothing
        Me.txtTMH.VCM_CustomOmmitString = Nothing
        Me.txtTMH.VCM_EnterFocus = True
        Me.txtTMH.VCM_IsValidated = False
        Me.txtTMH.VCM_MensajeFoco = Nothing
        Me.txtTMH.VCM_MuestraMensajeFoco = False
        Me.txtTMH.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.TresDecimales
        Me.txtTMH.VCM_RegularExpression = Nothing
        Me.txtTMH.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtTMH.VCM_ShowMessage = True
        Me.txtTMH.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'txtValorTotal
        '
        Me.txtValorTotal.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtValorTotal.Location = New System.Drawing.Point(957, 71)
        Me.txtValorTotal.MandatoryColor = System.Drawing.Color.Empty
        Me.txtValorTotal.MandatoryField = False
        Me.txtValorTotal.MaxLength = 10
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.ReadOnly = True
        Me.txtValorTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtValorTotal.TabIndex = 5
        Me.txtValorTotal.Text = "0"
        Me.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorTotal.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtValorTotal.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtValorTotal.VCM_CustomInputTypeString = Nothing
        Me.txtValorTotal.VCM_CustomOmmitString = Nothing
        Me.txtValorTotal.VCM_EnterFocus = True
        Me.txtValorTotal.VCM_IsValidated = False
        Me.txtValorTotal.VCM_MensajeFoco = Nothing
        Me.txtValorTotal.VCM_MuestraMensajeFoco = False
        Me.txtValorTotal.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.TresDecimales
        Me.txtValorTotal.VCM_RegularExpression = Nothing
        Me.txtValorTotal.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtValorTotal.VCM_ShowMessage = True
        Me.txtValorTotal.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'txtvalorIGV
        '
        Me.txtvalorIGV.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtvalorIGV.Location = New System.Drawing.Point(957, 45)
        Me.txtvalorIGV.MandatoryColor = System.Drawing.Color.Empty
        Me.txtvalorIGV.MandatoryField = False
        Me.txtvalorIGV.MaxLength = 10
        Me.txtvalorIGV.Name = "txtvalorIGV"
        Me.txtvalorIGV.ReadOnly = True
        Me.txtvalorIGV.Size = New System.Drawing.Size(100, 20)
        Me.txtvalorIGV.TabIndex = 5
        Me.txtvalorIGV.Text = "0"
        Me.txtvalorIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtvalorIGV.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtvalorIGV.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtvalorIGV.VCM_CustomInputTypeString = Nothing
        Me.txtvalorIGV.VCM_CustomOmmitString = Nothing
        Me.txtvalorIGV.VCM_EnterFocus = True
        Me.txtvalorIGV.VCM_IsValidated = False
        Me.txtvalorIGV.VCM_MensajeFoco = Nothing
        Me.txtvalorIGV.VCM_MuestraMensajeFoco = False
        Me.txtvalorIGV.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.TresDecimales
        Me.txtvalorIGV.VCM_RegularExpression = Nothing
        Me.txtvalorIGV.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtvalorIGV.VCM_ShowMessage = True
        Me.txtvalorIGV.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'txtTMNS
        '
        Me.txtTMNS.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtTMNS.Location = New System.Drawing.Point(774, 67)
        Me.txtTMNS.MandatoryColor = System.Drawing.Color.Empty
        Me.txtTMNS.MandatoryField = False
        Me.txtTMNS.MaxLength = 10
        Me.txtTMNS.Name = "txtTMNS"
        Me.txtTMNS.ReadOnly = True
        Me.txtTMNS.Size = New System.Drawing.Size(100, 20)
        Me.txtTMNS.TabIndex = 5
        Me.txtTMNS.Text = "0"
        Me.txtTMNS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTMNS.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtTMNS.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtTMNS.VCM_CustomInputTypeString = Nothing
        Me.txtTMNS.VCM_CustomOmmitString = Nothing
        Me.txtTMNS.VCM_EnterFocus = True
        Me.txtTMNS.VCM_IsValidated = False
        Me.txtTMNS.VCM_MensajeFoco = Nothing
        Me.txtTMNS.VCM_MuestraMensajeFoco = False
        Me.txtTMNS.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.TresDecimales
        Me.txtTMNS.VCM_RegularExpression = Nothing
        Me.txtTMNS.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtTMNS.VCM_ShowMessage = True
        Me.txtTMNS.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'txtTMS
        '
        Me.txtTMS.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtTMS.Location = New System.Drawing.Point(774, 43)
        Me.txtTMS.MandatoryColor = System.Drawing.Color.Empty
        Me.txtTMS.MandatoryField = False
        Me.txtTMS.MaxLength = 10
        Me.txtTMS.Name = "txtTMS"
        Me.txtTMS.ReadOnly = True
        Me.txtTMS.Size = New System.Drawing.Size(100, 20)
        Me.txtTMS.TabIndex = 5
        Me.txtTMS.Text = "0"
        Me.txtTMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTMS.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtTMS.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtTMS.VCM_CustomInputTypeString = Nothing
        Me.txtTMS.VCM_CustomOmmitString = Nothing
        Me.txtTMS.VCM_EnterFocus = True
        Me.txtTMS.VCM_IsValidated = False
        Me.txtTMS.VCM_MensajeFoco = Nothing
        Me.txtTMS.VCM_MuestraMensajeFoco = False
        Me.txtTMS.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.TresDecimales
        Me.txtTMS.VCM_RegularExpression = Nothing
        Me.txtTMS.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtTMS.VCM_ShowMessage = True
        Me.txtTMS.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'txtComision
        '
        Me.txtComision.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtComision.Location = New System.Drawing.Point(562, 71)
        Me.txtComision.MandatoryColor = System.Drawing.Color.Empty
        Me.txtComision.MandatoryField = False
        Me.txtComision.MaxLength = 10
        Me.txtComision.Name = "txtComision"
        Me.txtComision.Size = New System.Drawing.Size(54, 20)
        Me.txtComision.TabIndex = 5
        Me.txtComision.Text = "0"
        Me.txtComision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtComision.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtComision.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtComision.VCM_CustomInputTypeString = Nothing
        Me.txtComision.VCM_CustomOmmitString = Nothing
        Me.txtComision.VCM_EnterFocus = True
        Me.txtComision.VCM_IsValidated = False
        Me.txtComision.VCM_MensajeFoco = Nothing
        Me.txtComision.VCM_MuestraMensajeFoco = False
        Me.txtComision.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.TresDecimales
        Me.txtComision.VCM_RegularExpression = Nothing
        Me.txtComision.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtComision.VCM_ShowMessage = True
        Me.txtComision.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(892, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Valor Total"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(500, 48)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(26, 13)
        Me.Label36.TabIndex = 4
        Me.Label36.Text = "Año"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(892, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Valor Neto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(723, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "TMNS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(892, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Valor IGV"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(723, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "TMH"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(723, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "TMS"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(500, 27)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(27, 13)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Mes"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(500, 74)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(49, 13)
        Me.Label43.TabIndex = 4
        Me.Label43.Text = "Comisión"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(211, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Numero Documento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha Emisión"
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(333, 68)
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(127, 20)
        Me.txtNumeroDocumento.TabIndex = 3
        '
        'dtpFechaEmision
        '
        Me.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEmision.Location = New System.Drawing.Point(333, 21)
        Me.dtpFechaEmision.Name = "dtpFechaEmision"
        Me.dtpFechaEmision.Size = New System.Drawing.Size(127, 20)
        Me.dtpFechaEmision.TabIndex = 2
        '
        'cboAnio
        '
        Me.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAnio.FormattingEnabled = True
        Me.cboAnio.Location = New System.Drawing.Point(562, 45)
        Me.cboAnio.Name = "cboAnio"
        Me.cboAnio.Size = New System.Drawing.Size(127, 21)
        Me.cboAnio.TabIndex = 0
        '
        'cboMes
        '
        Me.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.Location = New System.Drawing.Point(562, 18)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(127, 21)
        Me.cboMes.TabIndex = 0
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDocumento.FormattingEnabled = True
        Me.cboTipoDocumento.Location = New System.Drawing.Point(333, 44)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(127, 21)
        Me.cboTipoDocumento.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Tipo de Documento"
        '
        'cboEmpresa
        '
        Me.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.Location = New System.Drawing.Point(60, 53)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(127, 21)
        Me.cboEmpresa.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Empresa"
        '
        'cboEmisor
        '
        Me.cboEmisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmisor.FormattingEnabled = True
        Me.cboEmisor.Location = New System.Drawing.Point(60, 24)
        Me.cboEmisor.Name = "cboEmisor"
        Me.cboEmisor.Size = New System.Drawing.Size(127, 21)
        Me.cboEmisor.TabIndex = 0
        '
        'lblempresa
        '
        Me.lblempresa.AutoSize = True
        Me.lblempresa.Location = New System.Drawing.Point(6, 27)
        Me.lblempresa.Name = "lblempresa"
        Me.lblempresa.Size = New System.Drawing.Size(38, 13)
        Me.lblempresa.TabIndex = 1
        Me.lblempresa.Text = "Emisor"
        '
        'gpoContratos
        '
        Me.gpoContratos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoContratos.BackColor = System.Drawing.Color.Transparent
        Me.gpoContratos.BorderColor = System.Drawing.Color.Black
        Me.gpoContratos.Controls.Add(Me.fxgrdGestionComercial)
        Me.gpoContratos.Location = New System.Drawing.Point(10, 118)
        Me.gpoContratos.Name = "gpoContratos"
        Me.gpoContratos.Size = New System.Drawing.Size(1070, 251)
        Me.gpoContratos.TabIndex = 28
        Me.gpoContratos.TabStop = False
        Me.gpoContratos.Text = "Detalle"
        '
        'fxgrdGestionComercial
        '
        Me.fxgrdGestionComercial.AllowEditing = False
        Me.fxgrdGestionComercial.AllowFiltering = True
        Me.fxgrdGestionComercial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fxgrdGestionComercial.AutoGenerateColumns = False
        Me.fxgrdGestionComercial.ColumnInfo = resources.GetString("fxgrdGestionComercial.ColumnInfo")
        Me.fxgrdGestionComercial.Location = New System.Drawing.Point(6, 19)
        Me.fxgrdGestionComercial.Name = "fxgrdGestionComercial"
        Me.fxgrdGestionComercial.Rows.Count = 2
        Me.fxgrdGestionComercial.Rows.DefaultSize = 19
        Me.fxgrdGestionComercial.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fxgrdGestionComercial.Size = New System.Drawing.Size(1058, 226)
        Me.fxgrdGestionComercial.TabIndex = 0
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
        'frmGestionComercial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1098, 443)
        Me.Controls.Add(Me.tcGestionComercial)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.msMenu)
        Me.Controls.Add(Me.txtcorrelativoliquidacion)
        Me.Controls.Add(Me.txtCorrelativo)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.KeyPreview = True
        Me.Name = "frmGestionComercial"
        Me.Text = "Gestión Comercial"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.msMenu.ResumeLayout(False)
        Me.msMenu.PerformLayout()
        Me.tcGestionComercial.ResumeLayout(False)
        Me.tpLista.ResumeLayout(False)
        CType(Me.fgxGestionComercial_Registro_Sel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpRegistro.ResumeLayout(False)
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.gpoContratos.ResumeLayout(False)
        CType(Me.fxgrdGestionComercial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContratoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmGuardar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblempresa As System.Windows.Forms.Label
    Friend WithEvents msMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents cboEmisor As System.Windows.Forms.ComboBox
    Friend WithEvents txtcorrelativoliquidacion As CUTextbox
    Friend WithEvents txtCorrelativo As CUTextbox
    Friend WithEvents gbDatos As CUGroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtComision As CUTextbox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumento As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboAnio As System.Windows.Forms.ComboBox
    Friend WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents cboTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tsbConsulta As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGenerarFactura As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtValorNeto As CUTextbox
    Friend WithEvents txtTMH As CUTextbox
    Friend WithEvents txtValorTotal As CUTextbox
    Friend WithEvents txtvalorIGV As CUTextbox
    Friend WithEvents txtTMNS As CUTextbox
    Friend WithEvents txtTMS As CUTextbox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gpoContratos As CUGroupBox
    Friend WithEvents fxgrdGestionComercial As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents pdPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents pdPrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents txtIgv As CUTextbox
    Friend WithEvents tsbExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents sfdSaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents tcGestionComercial As System.Windows.Forms.TabControl
    Friend WithEvents tpLista As System.Windows.Forms.TabPage
    Friend WithEvents tpRegistro As System.Windows.Forms.TabPage
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents fgxGestionComercial_Registro_Sel As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents tsbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAnular As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
End Class
