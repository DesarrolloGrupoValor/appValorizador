<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreciosDiarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreciosDiarios))
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.tsbExportarDiario = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbAnular = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCargaMasiva = New System.Windows.Forms.ToolStripButton()
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
        Me.sfdSaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.tcPreciosDiarios = New System.Windows.Forms.TabControl()
        Me.tpRegistro = New System.Windows.Forms.TabPage()
        Me.gbDatos = New CUGroupBox()
        Me.txtfm = New System.Windows.Forms.TextBox()
        Me.txtum = New System.Windows.Forms.TextBox()
        Me.txtfc = New System.Windows.Forms.TextBox()
        Me.txtuc = New System.Windows.Forms.TextBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIdPrecioDiario = New CUTextbox()
        Me.txtCalculado1 = New CUTextbox()
        Me.txtPrecio_oficial = New CUTextbox()
        Me.txtPrecio1 = New CUTextbox()
        Me.txtCalculado4 = New CUTextbox()
        Me.txtCalculado3 = New CUTextbox()
        Me.txtPrecio4 = New CUTextbox()
        Me.txtCalculado2 = New CUTextbox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPrecio3 = New CUTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPrecio2 = New CUTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cboElemento = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Código = New System.Windows.Forms.Label()
        Me.gpoContratos = New CUGroupBox()
        Me.dgxPrecio_Diario = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CuGroupBox1 = New CUGroupBox()
        Me.fdxPreciosMensuales = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.txtcorrelativoliquidacion = New CUTextbox()
        Me.txtCorrelativo = New CUTextbox()
        Me.ofdCargaExcel = New System.Windows.Forms.OpenFileDialog()
        Me.tsbExportarMensual = New System.Windows.Forms.ToolStripButton()
        Me.tsMenu.SuspendLayout()
        Me.msMenu.SuspendLayout()
        Me.tcPreciosDiarios.SuspendLayout()
        Me.tpRegistro.SuspendLayout()
        Me.gbDatos.SuspendLayout()
        Me.gpoContratos.SuspendLayout()
        CType(Me.dgxPrecio_Diario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.CuGroupBox1.SuspendLayout()
        CType(Me.fdxPreciosMensuales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenu
        '
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbRefrescar, Me.tsbExportarDiario, Me.tsbExportarMensual, Me.ToolStripSeparator4, Me.tsbNuevo, Me.tsbGuardar, Me.tsbAnular, Me.ToolStripSeparator3, Me.tsbCargaMasiva, Me.ToolStripSeparator1, Me.tsbSalir})
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
        'tsbExportarDiario
        '
        Me.tsbExportarDiario.Image = CType(resources.GetObject("tsbExportarDiario.Image"), System.Drawing.Image)
        Me.tsbExportarDiario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportarDiario.Name = "tsbExportarDiario"
        Me.tsbExportarDiario.Size = New System.Drawing.Size(120, 36)
        Me.tsbExportarDiario.Text = "Exportar Diario"
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
        'tsbGuardar
        '
        Me.tsbGuardar.Image = Global.My.Resources.Resources.guardar
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(85, 36)
        Me.tsbGuardar.Text = "Guardar"
        '
        'tsbAnular
        '
        Me.tsbAnular.Image = Global.My.Resources.Resources.eliminar
        Me.tsbAnular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAnular.Name = "tsbAnular"
        Me.tsbAnular.Size = New System.Drawing.Size(78, 36)
        Me.tsbAnular.Text = "Anular"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'tsbCargaMasiva
        '
        Me.tsbCargaMasiva.Image = Global.My.Resources.Resources.liquidacion
        Me.tsbCargaMasiva.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCargaMasiva.Name = "tsbCargaMasiva"
        Me.tsbCargaMasiva.Size = New System.Drawing.Size(114, 36)
        Me.tsbCargaMasiva.Text = "Carga Masiva"
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
        Me.msMenu.Size = New System.Drawing.Size(1098, 24)
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
        'sfdSaveFileDialog
        '
        Me.sfdSaveFileDialog.FileName = "Precios"
        '
        'tcPreciosDiarios
        '
        Me.tcPreciosDiarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcPreciosDiarios.Controls.Add(Me.tpRegistro)
        Me.tcPreciosDiarios.Controls.Add(Me.TabPage1)
        Me.tcPreciosDiarios.Location = New System.Drawing.Point(0, 42)
        Me.tcPreciosDiarios.Name = "tcPreciosDiarios"
        Me.tcPreciosDiarios.SelectedIndex = 0
        Me.tcPreciosDiarios.Size = New System.Drawing.Size(1095, 398)
        Me.tcPreciosDiarios.TabIndex = 30
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
        Me.tpRegistro.Text = "Registro Datos Diarios"
        '
        'gbDatos
        '
        Me.gbDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbDatos.BorderColor = System.Drawing.Color.Black
        Me.gbDatos.Controls.Add(Me.txtfm)
        Me.gbDatos.Controls.Add(Me.txtum)
        Me.gbDatos.Controls.Add(Me.txtfc)
        Me.gbDatos.Controls.Add(Me.txtuc)
        Me.gbDatos.Controls.Add(Me.CheckBox8)
        Me.gbDatos.Controls.Add(Me.CheckBox7)
        Me.gbDatos.Controls.Add(Me.CheckBox4)
        Me.gbDatos.Controls.Add(Me.CheckBox6)
        Me.gbDatos.Controls.Add(Me.CheckBox3)
        Me.gbDatos.Controls.Add(Me.CheckBox5)
        Me.gbDatos.Controls.Add(Me.CheckBox2)
        Me.gbDatos.Controls.Add(Me.CheckBox1)
        Me.gbDatos.Controls.Add(Me.Label4)
        Me.gbDatos.Controls.Add(Me.txtIdPrecioDiario)
        Me.gbDatos.Controls.Add(Me.txtCalculado1)
        Me.gbDatos.Controls.Add(Me.txtPrecio_oficial)
        Me.gbDatos.Controls.Add(Me.txtPrecio1)
        Me.gbDatos.Controls.Add(Me.txtCalculado4)
        Me.gbDatos.Controls.Add(Me.txtCalculado3)
        Me.gbDatos.Controls.Add(Me.txtPrecio4)
        Me.gbDatos.Controls.Add(Me.txtCalculado2)
        Me.gbDatos.Controls.Add(Me.Label17)
        Me.gbDatos.Controls.Add(Me.txtPrecio3)
        Me.gbDatos.Controls.Add(Me.Label11)
        Me.gbDatos.Controls.Add(Me.Label16)
        Me.gbDatos.Controls.Add(Me.txtPrecio2)
        Me.gbDatos.Controls.Add(Me.Label10)
        Me.gbDatos.Controls.Add(Me.Label13)
        Me.gbDatos.Controls.Add(Me.Label9)
        Me.gbDatos.Controls.Add(Me.Label12)
        Me.gbDatos.Controls.Add(Me.Label7)
        Me.gbDatos.Controls.Add(Me.Label5)
        Me.gbDatos.Controls.Add(Me.Label8)
        Me.gbDatos.Controls.Add(Me.Label6)
        Me.gbDatos.Controls.Add(Me.Label3)
        Me.gbDatos.Controls.Add(Me.Label2)
        Me.gbDatos.Controls.Add(Me.dtpFecha)
        Me.gbDatos.Controls.Add(Me.cboElemento)
        Me.gbDatos.Controls.Add(Me.Label1)
        Me.gbDatos.Controls.Add(Me.Código)
        Me.gbDatos.Location = New System.Drawing.Point(11, 7)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(1074, 128)
        Me.gbDatos.TabIndex = 25
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Datos Generales"
        '
        'txtfm
        '
        Me.txtfm.Location = New System.Drawing.Point(918, 99)
        Me.txtfm.Name = "txtfm"
        Me.txtfm.ReadOnly = True
        Me.txtfm.Size = New System.Drawing.Size(150, 20)
        Me.txtfm.TabIndex = 0
        '
        'txtum
        '
        Me.txtum.Location = New System.Drawing.Point(920, 73)
        Me.txtum.Name = "txtum"
        Me.txtum.ReadOnly = True
        Me.txtum.Size = New System.Drawing.Size(150, 20)
        Me.txtum.TabIndex = 0
        '
        'txtfc
        '
        Me.txtfc.Location = New System.Drawing.Point(918, 47)
        Me.txtfc.Name = "txtfc"
        Me.txtfc.ReadOnly = True
        Me.txtfc.Size = New System.Drawing.Size(150, 20)
        Me.txtfc.TabIndex = 0
        '
        'txtuc
        '
        Me.txtuc.Location = New System.Drawing.Point(918, 19)
        Me.txtuc.Name = "txtuc"
        Me.txtuc.ReadOnly = True
        Me.txtuc.Size = New System.Drawing.Size(150, 20)
        Me.txtuc.TabIndex = 0
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Enabled = False
        Me.CheckBox8.Location = New System.Drawing.Point(744, 98)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox8.TabIndex = 0
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Enabled = False
        Me.CheckBox7.Location = New System.Drawing.Point(744, 72)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox7.TabIndex = 0
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Enabled = False
        Me.CheckBox4.Location = New System.Drawing.Point(453, 100)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox4.TabIndex = 0
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Enabled = False
        Me.CheckBox6.Location = New System.Drawing.Point(744, 49)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox6.TabIndex = 0
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Enabled = False
        Me.CheckBox3.Location = New System.Drawing.Point(453, 73)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox3.TabIndex = 0
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Enabled = False
        Me.CheckBox5.Location = New System.Drawing.Point(744, 23)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox5.TabIndex = 0
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.Location = New System.Drawing.Point(453, 51)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 0
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(453, 25)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(244, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Precio 3 (purchase)"
        '
        'txtIdPrecioDiario
        '
        Me.txtIdPrecioDiario.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtIdPrecioDiario.Location = New System.Drawing.Point(96, 27)
        Me.txtIdPrecioDiario.MandatoryColor = System.Drawing.Color.Empty
        Me.txtIdPrecioDiario.MandatoryField = False
        Me.txtIdPrecioDiario.MaxLength = 10
        Me.txtIdPrecioDiario.Name = "txtIdPrecioDiario"
        Me.txtIdPrecioDiario.ReadOnly = True
        Me.txtIdPrecioDiario.Size = New System.Drawing.Size(100, 20)
        Me.txtIdPrecioDiario.TabIndex = 0
        Me.txtIdPrecioDiario.Text = "0"
        Me.txtIdPrecioDiario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIdPrecioDiario.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtIdPrecioDiario.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtIdPrecioDiario.VCM_CustomInputTypeString = Nothing
        Me.txtIdPrecioDiario.VCM_CustomOmmitString = Nothing
        Me.txtIdPrecioDiario.VCM_EnterFocus = True
        Me.txtIdPrecioDiario.VCM_IsValidated = False
        Me.txtIdPrecioDiario.VCM_MensajeFoco = Nothing
        Me.txtIdPrecioDiario.VCM_MuestraMensajeFoco = False
        Me.txtIdPrecioDiario.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.TresDecimales
        Me.txtIdPrecioDiario.VCM_RegularExpression = Nothing
        Me.txtIdPrecioDiario.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtIdPrecioDiario.VCM_ShowMessage = True
        Me.txtIdPrecioDiario.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'txtCalculado1
        '
        Me.txtCalculado1.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtCalculado1.Location = New System.Drawing.Point(638, 21)
        Me.txtCalculado1.MandatoryColor = System.Drawing.Color.Empty
        Me.txtCalculado1.MandatoryField = False
        Me.txtCalculado1.MaxLength = 10
        Me.txtCalculado1.Name = "txtCalculado1"
        Me.txtCalculado1.ReadOnly = True
        Me.txtCalculado1.Size = New System.Drawing.Size(100, 20)
        Me.txtCalculado1.TabIndex = 0
        Me.txtCalculado1.Text = "0"
        Me.txtCalculado1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalculado1.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtCalculado1.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtCalculado1.VCM_CustomInputTypeString = Nothing
        Me.txtCalculado1.VCM_CustomOmmitString = Nothing
        Me.txtCalculado1.VCM_EnterFocus = True
        Me.txtCalculado1.VCM_IsValidated = False
        Me.txtCalculado1.VCM_MensajeFoco = Nothing
        Me.txtCalculado1.VCM_MuestraMensajeFoco = False
        Me.txtCalculado1.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.TresDecimales
        Me.txtCalculado1.VCM_RegularExpression = Nothing
        Me.txtCalculado1.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtCalculado1.VCM_ShowMessage = True
        Me.txtCalculado1.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'txtPrecio_oficial
        '
        Me.txtPrecio_oficial.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtPrecio_oficial.Location = New System.Drawing.Point(96, 103)
        Me.txtPrecio_oficial.MandatoryColor = System.Drawing.Color.Empty
        Me.txtPrecio_oficial.MandatoryField = False
        Me.txtPrecio_oficial.MaxLength = 10
        Me.txtPrecio_oficial.Name = "txtPrecio_oficial"
        Me.txtPrecio_oficial.ReadOnly = True
        Me.txtPrecio_oficial.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio_oficial.TabIndex = 3
        Me.txtPrecio_oficial.Text = "0"
        Me.txtPrecio_oficial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPrecio_oficial.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtPrecio_oficial.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtPrecio_oficial.VCM_CustomInputTypeString = Nothing
        Me.txtPrecio_oficial.VCM_CustomOmmitString = Nothing
        Me.txtPrecio_oficial.VCM_EnterFocus = True
        Me.txtPrecio_oficial.VCM_IsValidated = False
        Me.txtPrecio_oficial.VCM_MensajeFoco = Nothing
        Me.txtPrecio_oficial.VCM_MuestraMensajeFoco = False
        Me.txtPrecio_oficial.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.TresDecimales
        Me.txtPrecio_oficial.VCM_RegularExpression = Nothing
        Me.txtPrecio_oficial.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtPrecio_oficial.VCM_ShowMessage = True
        Me.txtPrecio_oficial.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'txtPrecio1
        '
        Me.txtPrecio1.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtPrecio1.Location = New System.Drawing.Point(346, 24)
        Me.txtPrecio1.MandatoryColor = System.Drawing.Color.Empty
        Me.txtPrecio1.MandatoryField = False
        Me.txtPrecio1.MaxLength = 10
        Me.txtPrecio1.Name = "txtPrecio1"
        Me.txtPrecio1.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio1.TabIndex = 3
        Me.txtPrecio1.Text = "0"
        Me.txtPrecio1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPrecio1.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtPrecio1.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtPrecio1.VCM_CustomInputTypeString = Nothing
        Me.txtPrecio1.VCM_CustomOmmitString = Nothing
        Me.txtPrecio1.VCM_EnterFocus = True
        Me.txtPrecio1.VCM_IsValidated = False
        Me.txtPrecio1.VCM_MensajeFoco = Nothing
        Me.txtPrecio1.VCM_MuestraMensajeFoco = False
        Me.txtPrecio1.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.TresDecimales
        Me.txtPrecio1.VCM_RegularExpression = Nothing
        Me.txtPrecio1.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtPrecio1.VCM_ShowMessage = True
        Me.txtPrecio1.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'txtCalculado4
        '
        Me.txtCalculado4.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtCalculado4.Location = New System.Drawing.Point(638, 99)
        Me.txtCalculado4.MandatoryColor = System.Drawing.Color.Empty
        Me.txtCalculado4.MandatoryField = False
        Me.txtCalculado4.MaxLength = 10
        Me.txtCalculado4.Name = "txtCalculado4"
        Me.txtCalculado4.ReadOnly = True
        Me.txtCalculado4.Size = New System.Drawing.Size(100, 20)
        Me.txtCalculado4.TabIndex = 0
        Me.txtCalculado4.Text = "0"
        Me.txtCalculado4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalculado4.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtCalculado4.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtCalculado4.VCM_CustomInputTypeString = Nothing
        Me.txtCalculado4.VCM_CustomOmmitString = Nothing
        Me.txtCalculado4.VCM_EnterFocus = True
        Me.txtCalculado4.VCM_IsValidated = False
        Me.txtCalculado4.VCM_MensajeFoco = Nothing
        Me.txtCalculado4.VCM_MuestraMensajeFoco = False
        Me.txtCalculado4.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.TresDecimales
        Me.txtCalculado4.VCM_RegularExpression = Nothing
        Me.txtCalculado4.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtCalculado4.VCM_ShowMessage = True
        Me.txtCalculado4.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'txtCalculado3
        '
        Me.txtCalculado3.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtCalculado3.Location = New System.Drawing.Point(638, 73)
        Me.txtCalculado3.MandatoryColor = System.Drawing.Color.Empty
        Me.txtCalculado3.MandatoryField = False
        Me.txtCalculado3.MaxLength = 10
        Me.txtCalculado3.Name = "txtCalculado3"
        Me.txtCalculado3.ReadOnly = True
        Me.txtCalculado3.Size = New System.Drawing.Size(100, 20)
        Me.txtCalculado3.TabIndex = 0
        Me.txtCalculado3.Text = "0"
        Me.txtCalculado3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalculado3.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtCalculado3.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtCalculado3.VCM_CustomInputTypeString = Nothing
        Me.txtCalculado3.VCM_CustomOmmitString = Nothing
        Me.txtCalculado3.VCM_EnterFocus = True
        Me.txtCalculado3.VCM_IsValidated = False
        Me.txtCalculado3.VCM_MensajeFoco = Nothing
        Me.txtCalculado3.VCM_MuestraMensajeFoco = False
        Me.txtCalculado3.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.TresDecimales
        Me.txtCalculado3.VCM_RegularExpression = Nothing
        Me.txtCalculado3.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtCalculado3.VCM_ShowMessage = True
        Me.txtCalculado3.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'txtPrecio4
        '
        Me.txtPrecio4.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtPrecio4.Location = New System.Drawing.Point(346, 98)
        Me.txtPrecio4.MandatoryColor = System.Drawing.Color.Empty
        Me.txtPrecio4.MandatoryField = False
        Me.txtPrecio4.MaxLength = 10
        Me.txtPrecio4.Name = "txtPrecio4"
        Me.txtPrecio4.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio4.TabIndex = 6
        Me.txtPrecio4.Text = "0"
        Me.txtPrecio4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPrecio4.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtPrecio4.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtPrecio4.VCM_CustomInputTypeString = Nothing
        Me.txtPrecio4.VCM_CustomOmmitString = Nothing
        Me.txtPrecio4.VCM_EnterFocus = True
        Me.txtPrecio4.VCM_IsValidated = False
        Me.txtPrecio4.VCM_MensajeFoco = Nothing
        Me.txtPrecio4.VCM_MuestraMensajeFoco = False
        Me.txtPrecio4.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.TresDecimales
        Me.txtPrecio4.VCM_RegularExpression = Nothing
        Me.txtPrecio4.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtPrecio4.VCM_ShowMessage = True
        Me.txtPrecio4.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'txtCalculado2
        '
        Me.txtCalculado2.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtCalculado2.Location = New System.Drawing.Point(638, 47)
        Me.txtCalculado2.MandatoryColor = System.Drawing.Color.Empty
        Me.txtCalculado2.MandatoryField = False
        Me.txtCalculado2.MaxLength = 10
        Me.txtCalculado2.Name = "txtCalculado2"
        Me.txtCalculado2.ReadOnly = True
        Me.txtCalculado2.Size = New System.Drawing.Size(100, 20)
        Me.txtCalculado2.TabIndex = 0
        Me.txtCalculado2.Text = "0"
        Me.txtCalculado2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalculado2.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtCalculado2.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtCalculado2.VCM_CustomInputTypeString = Nothing
        Me.txtCalculado2.VCM_CustomOmmitString = Nothing
        Me.txtCalculado2.VCM_EnterFocus = True
        Me.txtCalculado2.VCM_IsValidated = False
        Me.txtCalculado2.VCM_MensajeFoco = Nothing
        Me.txtCalculado2.VCM_MuestraMensajeFoco = False
        Me.txtCalculado2.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.TresDecimales
        Me.txtCalculado2.VCM_RegularExpression = Nothing
        Me.txtCalculado2.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtCalculado2.VCM_ShowMessage = True
        Me.txtCalculado2.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(795, 101)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 13)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Fecha Modificación"
        '
        'txtPrecio3
        '
        Me.txtPrecio3.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtPrecio3.Location = New System.Drawing.Point(346, 72)
        Me.txtPrecio3.MandatoryColor = System.Drawing.Color.Empty
        Me.txtPrecio3.MandatoryField = False
        Me.txtPrecio3.MaxLength = 10
        Me.txtPrecio3.Name = "txtPrecio3"
        Me.txtPrecio3.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio3.TabIndex = 5
        Me.txtPrecio3.Text = "0"
        Me.txtPrecio3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPrecio3.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtPrecio3.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtPrecio3.VCM_CustomInputTypeString = Nothing
        Me.txtPrecio3.VCM_CustomOmmitString = Nothing
        Me.txtPrecio3.VCM_EnterFocus = True
        Me.txtPrecio3.VCM_IsValidated = False
        Me.txtPrecio3.VCM_MensajeFoco = Nothing
        Me.txtPrecio3.VCM_MuestraMensajeFoco = False
        Me.txtPrecio3.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.TresDecimales
        Me.txtPrecio3.VCM_RegularExpression = Nothing
        Me.txtPrecio3.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtPrecio3.VCM_ShowMessage = True
        Me.txtPrecio3.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(527, 103)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Calcula 4 (Dif)"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(795, 75)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Usuario Modificación"
        '
        'txtPrecio2
        '
        Me.txtPrecio2.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtPrecio2.Location = New System.Drawing.Point(346, 48)
        Me.txtPrecio2.MandatoryColor = System.Drawing.Color.Empty
        Me.txtPrecio2.MandatoryField = False
        Me.txtPrecio2.MaxLength = 10
        Me.txtPrecio2.Name = "txtPrecio2"
        Me.txtPrecio2.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio2.TabIndex = 4
        Me.txtPrecio2.Text = "0"
        Me.txtPrecio2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPrecio2.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtPrecio2.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtPrecio2.VCM_CustomInputTypeString = Nothing
        Me.txtPrecio2.VCM_CustomOmmitString = Nothing
        Me.txtPrecio2.VCM_EnterFocus = True
        Me.txtPrecio2.VCM_IsValidated = False
        Me.txtPrecio2.VCM_MensajeFoco = Nothing
        Me.txtPrecio2.VCM_MuestraMensajeFoco = False
        Me.txtPrecio2.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.TresDecimales
        Me.txtPrecio2.VCM_RegularExpression = Nothing
        Me.txtPrecio2.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtPrecio2.VCM_ShowMessage = True
        Me.txtPrecio2.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(527, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Calcula 3 (4lme+b)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(795, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Usuario Creación"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(527, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Calcula 1 (4lme)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(795, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Fecha Creación"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(244, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Precio 4 (sale)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Precio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(527, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Calcula 2 (4lme-mxS)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(244, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Precio 1 (purchase)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(244, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Precio 2 (settl.)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(96, 78)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(100, 20)
        Me.dtpFecha.TabIndex = 2
        '
        'cboElemento
        '
        Me.cboElemento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboElemento.FormattingEnabled = True
        Me.cboElemento.Location = New System.Drawing.Point(96, 51)
        Me.cboElemento.Name = "cboElemento"
        Me.cboElemento.Size = New System.Drawing.Size(100, 21)
        Me.cboElemento.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Elemento"
        '
        'Código
        '
        Me.Código.AutoSize = True
        Me.Código.Location = New System.Drawing.Point(31, 29)
        Me.Código.Name = "Código"
        Me.Código.Size = New System.Drawing.Size(40, 13)
        Me.Código.TabIndex = 1
        Me.Código.Text = "Código"
        '
        'gpoContratos
        '
        Me.gpoContratos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoContratos.BackColor = System.Drawing.Color.Transparent
        Me.gpoContratos.BorderColor = System.Drawing.Color.Black
        Me.gpoContratos.Controls.Add(Me.dgxPrecio_Diario)
        Me.gpoContratos.Location = New System.Drawing.Point(10, 141)
        Me.gpoContratos.Name = "gpoContratos"
        Me.gpoContratos.Size = New System.Drawing.Size(1070, 228)
        Me.gpoContratos.TabIndex = 28
        Me.gpoContratos.TabStop = False
        Me.gpoContratos.Text = "Detalle"
        '
        'dgxPrecio_Diario
        '
        Me.dgxPrecio_Diario.AllowEditing = False
        Me.dgxPrecio_Diario.AllowFiltering = True
        Me.dgxPrecio_Diario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgxPrecio_Diario.ColumnInfo = resources.GetString("dgxPrecio_Diario.ColumnInfo")
        Me.dgxPrecio_Diario.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw
        Me.dgxPrecio_Diario.Location = New System.Drawing.Point(10, 19)
        Me.dgxPrecio_Diario.Name = "dgxPrecio_Diario"
        Me.dgxPrecio_Diario.Rows.DefaultSize = 19
        Me.dgxPrecio_Diario.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.dgxPrecio_Diario.Size = New System.Drawing.Size(1054, 203)
        Me.dgxPrecio_Diario.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CuGroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1087, 372)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Precios Mensuales"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CuGroupBox1
        '
        Me.CuGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CuGroupBox1.BackColor = System.Drawing.Color.LemonChiffon
        Me.CuGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.CuGroupBox1.Controls.Add(Me.fdxPreciosMensuales)
        Me.CuGroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.CuGroupBox1.Name = "CuGroupBox1"
        Me.CuGroupBox1.Size = New System.Drawing.Size(1070, 364)
        Me.CuGroupBox1.TabIndex = 29
        Me.CuGroupBox1.TabStop = False
        Me.CuGroupBox1.Text = "Detalle"
        '
        'fdxPreciosMensuales
        '
        Me.fdxPreciosMensuales.AllowEditing = False
        Me.fdxPreciosMensuales.AllowFiltering = True
        Me.fdxPreciosMensuales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fdxPreciosMensuales.ColumnInfo = resources.GetString("fdxPreciosMensuales.ColumnInfo")
        Me.fdxPreciosMensuales.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw
        Me.fdxPreciosMensuales.Location = New System.Drawing.Point(10, 19)
        Me.fdxPreciosMensuales.Name = "fdxPreciosMensuales"
        Me.fdxPreciosMensuales.Rows.DefaultSize = 19
        Me.fdxPreciosMensuales.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fdxPreciosMensuales.Size = New System.Drawing.Size(1054, 339)
        Me.fdxPreciosMensuales.TabIndex = 0
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
        'ofdCargaExcel
        '
        Me.ofdCargaExcel.FileName = "OpenFileDialog1"
        '
        'tsbExportarMensual
        '
        Me.tsbExportarMensual.Image = CType(resources.GetObject("tsbExportarMensual.Image"), System.Drawing.Image)
        Me.tsbExportarMensual.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportarMensual.Name = "tsbExportarMensual"
        Me.tsbExportarMensual.Size = New System.Drawing.Size(134, 36)
        Me.tsbExportarMensual.Text = "Exportar Mensual"
        '
        'frmPreciosDiarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1098, 443)
        Me.Controls.Add(Me.tcPreciosDiarios)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.msMenu)
        Me.Controls.Add(Me.txtcorrelativoliquidacion)
        Me.Controls.Add(Me.txtCorrelativo)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.KeyPreview = True
        Me.Name = "frmPreciosDiarios"
        Me.Text = "Precios Diarios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.msMenu.ResumeLayout(False)
        Me.msMenu.PerformLayout()
        Me.tcPreciosDiarios.ResumeLayout(False)
        Me.tpRegistro.ResumeLayout(False)
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.gpoContratos.ResumeLayout(False)
        CType(Me.dgxPrecio_Diario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.CuGroupBox1.ResumeLayout(False)
        CType(Me.fdxPreciosMensuales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContratoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmGuardar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Código As System.Windows.Forms.Label
    Friend WithEvents msMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents txtcorrelativoliquidacion As CUTextbox
    Friend WithEvents txtCorrelativo As CUTextbox
    Friend WithEvents gbDatos As CUGroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboElemento As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCalculado1 As CUTextbox
    Friend WithEvents txtPrecio1 As CUTextbox
    Friend WithEvents txtCalculado3 As CUTextbox
    Friend WithEvents txtCalculado2 As CUTextbox
    Friend WithEvents txtPrecio3 As CUTextbox
    Friend WithEvents txtPrecio2 As CUTextbox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gpoContratos As CUGroupBox
    Friend WithEvents tsbExportarDiario As System.Windows.Forms.ToolStripButton
    Friend WithEvents sfdSaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents tcPreciosDiarios As System.Windows.Forms.TabControl
    Friend WithEvents tpRegistro As System.Windows.Forms.TabPage
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAnular As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtIdPrecioDiario As CUTextbox
    Friend WithEvents txtCalculado4 As CUTextbox
    Friend WithEvents txtPrecio4 As CUTextbox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dgxPrecio_Diario As New C1.Win.C1FlexGrid.C1FlexGrid()
    Friend WithEvents txtfm As System.Windows.Forms.TextBox
    Friend WithEvents txtum As System.Windows.Forms.TextBox
    Friend WithEvents txtfc As System.Windows.Forms.TextBox
    Friend WithEvents txtuc As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents CuGroupBox1 As CUGroupBox
    Friend WithEvents fdxPreciosMensuales As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtPrecio_oficial As CUTextbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tsbCargaMasiva As System.Windows.Forms.ToolStripButton
    Friend WithEvents ofdCargaExcel As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbExportarMensual As System.Windows.Forms.ToolStripButton
End Class
