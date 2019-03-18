<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editcontrato
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editcontrato))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAsociarTM = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.msMenu = New System.Windows.Forms.MenuStrip()
        Me.ContratoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmGuardar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbcTerminos = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtComentarios = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.gpoterminos = New CUGroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtVigenciaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtVigenciaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtctamensmax = New CUTextbox()
        Me.txtctamensmin = New CUTextbox()
        Me.txtctaanualmax = New CUTextbox()
        Me.txtctaanualmin = New CUTextbox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.CuGroupBox1 = New CUGroupBox()
        Me.txtMaquila = New CUTextbox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblDeposito = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.nupdMerma = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboDeposito = New System.Windows.Forms.ComboBox()
        Me.cboIncoterm = New System.Windows.Forms.ComboBox()
        Me.gpoescalador = New CUGroupBox()
        Me.txtbasemenos2 = New CUTextbox()
        Me.txtbasemas2 = New CUTextbox()
        Me.txtbasemenos1 = New CUTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtbase2 = New CUTextbox()
        Me.txtbasemas1 = New CUTextbox()
        Me.txtbase1 = New CUTextbox()
        Me.gpoparticipacion = New CUGroupBox()
        Me.nupdPorcentaje = New System.Windows.Forms.NumericUpDown()
        Me.txtbasepart = New CUTextbox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gpopagable = New CUGroupBox()
        Me.dgvPagables = New System.Windows.Forms.DataGridView()
        Me.Elem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ley = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeyMin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeyMax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.undfactor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.undpag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTipo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Ded = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.undded = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.undrc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.undprot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvMerc = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dgvAjuste = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dgvQP = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.liquidacionPagable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.finley = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.finprecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregarPag = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsCboPagable = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbEliminarPag = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.gpopenalizable = New CUGroupBox()
        Me.dgvPenalizable = New System.Windows.Forms.DataGridView()
        Me.ElemP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeyP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Min = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Max = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.undfactorp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.undpen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.liquidacionPenalizableId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregarPen = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsCboPenalizable = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbEliminarPen = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.CuGroupBox4 = New CUGroupBox()
        Me.ContMenos = New CUTextbox()
        Me.ContMas = New CUTextbox()
        Me.BaseCont = New CUTextbox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.RcBasemenos = New CUTextbox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.RcBasemas = New CUTextbox()
        Me.RcBase = New CUTextbox()
        Me.gbPeriodo = New CUGroupBox()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox()
        Me.lblfechaliq = New System.Windows.Forms.Label()
        Me.lblperiodo = New System.Windows.Forms.Label()
        Me.CuGroupBox3 = New CUGroupBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtContacto = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.CuGroupBox2 = New CUGroupBox()
        Me.txtprocedencia = New CUTextbox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.gpofacturacion = New CUGroupBox()
        Me.nupdPorcPago = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New CUGroupBox()
        Me.txttasamora = New CUTextbox()
        Me.txttiempo = New CUTextbox()
        Me.txttasa = New CUTextbox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.cboModo = New System.Windows.Forms.ComboBox()
        Me.CuGroupBox5 = New CUGroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.cboTrader = New System.Windows.Forms.ComboBox()
        Me.txtcorrelativoliquidacion = New CUTextbox()
        Me.txtCorrelativo = New CUTextbox()
        Me.gpocompania = New CUGroupBox()
        Me.txtref1 = New CUTextbox()
        Me.btncalidad = New System.Windows.Forms.Button()
        Me.cboCalidad = New System.Windows.Forms.ComboBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.btnsocio = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboSocio = New System.Windows.Forms.ComboBox()
        Me.cboEmpresa = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gpomercaderia = New CUGroupBox()
        Me.cboProducto = New System.Windows.Forms.ComboBox()
        Me.cboClase = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gpocontrato = New CUGroupBox()
        Me.txtNumero = New CUTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbotipoc = New System.Windows.Forms.ComboBox()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.tsMenu.SuspendLayout()
        Me.msMenu.SuspendLayout()
        Me.tbcTerminos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gpoterminos.SuspendLayout()
        Me.CuGroupBox1.SuspendLayout()
        CType(Me.nupdMerma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoescalador.SuspendLayout()
        Me.gpoparticipacion.SuspendLayout()
        CType(Me.nupdPorcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpopagable.SuspendLayout()
        CType(Me.dgvPagables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.gpopenalizable.SuspendLayout()
        CType(Me.dgvPenalizable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.CuGroupBox4.SuspendLayout()
        Me.gbPeriodo.SuspendLayout()
        Me.CuGroupBox3.SuspendLayout()
        Me.CuGroupBox2.SuspendLayout()
        Me.gpofacturacion.SuspendLayout()
        CType(Me.nupdPorcPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.CuGroupBox5.SuspendLayout()
        Me.gpocompania.SuspendLayout()
        Me.gpomercaderia.SuspendLayout()
        Me.gpocontrato.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMenu
        '
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar, Me.ToolStripSeparator1, Me.tsbAsociarTM, Me.ToolStripSeparator7, Me.tsbSalir, Me.ToolStripButton1})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(1362, 39)
        Me.tsMenu.TabIndex = 1
        Me.tsMenu.Text = "ToolStrip1"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGuardar.Image = CType(resources.GetObject("tsbGuardar.Image"), System.Drawing.Image)
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(36, 36)
        Me.tsbGuardar.Text = "Guardar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'tsbAsociarTM
        '
        Me.tsbAsociarTM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAsociarTM.Image = CType(resources.GetObject("tsbAsociarTM.Image"), System.Drawing.Image)
        Me.tsbAsociarTM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAsociarTM.Name = "tsbAsociarTM"
        Me.tsbAsociarTM.Size = New System.Drawing.Size(36, 36)
        Me.tsbAsociarTM.Text = "Asociar TM"
        Me.tsbAsociarTM.Visible = False
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 39)
        '
        'tsbSalir
        '
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(36, 36)
        Me.tsbSalir.Text = "Salir"
        '
        'msMenu
        '
        Me.msMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContratoToolStripMenuItem})
        Me.msMenu.Location = New System.Drawing.Point(0, 0)
        Me.msMenu.Name = "msMenu"
        Me.msMenu.Size = New System.Drawing.Size(1087, 24)
        Me.msMenu.TabIndex = 0
        Me.msMenu.Text = "MenuStrip1"
        Me.msMenu.Visible = False
        '
        'ContratoToolStripMenuItem
        '
        Me.ContratoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmGuardar, Me.ToolStripSeparator2, Me.tsmSalir})
        Me.ContratoToolStripMenuItem.Name = "ContratoToolStripMenuItem"
        Me.ContratoToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ContratoToolStripMenuItem.Text = "Contrato"
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
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(716, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Contrato"
        Me.Label14.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(895, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Liquidacion"
        Me.Label15.Visible = False
        '
        'tbcTerminos
        '
        Me.tbcTerminos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbcTerminos.Controls.Add(Me.TabPage1)
        Me.tbcTerminos.Controls.Add(Me.TabPage2)
        Me.tbcTerminos.HotTrack = True
        Me.tbcTerminos.Location = New System.Drawing.Point(6, 113)
        Me.tbcTerminos.Name = "tbcTerminos"
        Me.tbcTerminos.SelectedIndex = 0
        Me.tbcTerminos.Size = New System.Drawing.Size(1356, 476)
        Me.tbcTerminos.TabIndex = 16
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LemonChiffon
        Me.TabPage1.Controls.Add(Me.gpoterminos)
        Me.TabPage1.Controls.Add(Me.CuGroupBox1)
        Me.TabPage1.Controls.Add(Me.gpoescalador)
        Me.TabPage1.Controls.Add(Me.gpoparticipacion)
        Me.TabPage1.Controls.Add(Me.gpopagable)
        Me.TabPage1.Controls.Add(Me.gpopenalizable)
        Me.TabPage1.Controls.Add(Me.CuGroupBox4)
        Me.TabPage1.Controls.Add(Me.gbPeriodo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1348, 450)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Terminos : Financiamiento"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LemonChiffon
        Me.TabPage2.Controls.Add(Me.txtComentarios)
        Me.TabPage2.Controls.Add(Me.Label45)
        Me.TabPage2.Controls.Add(Me.CuGroupBox3)
        Me.TabPage2.Controls.Add(Me.CuGroupBox2)
        Me.TabPage2.Controls.Add(Me.gpofacturacion)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1348, 450)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Terminos : Informacion Adicional"
        '
        'txtComentarios
        '
        Me.txtComentarios.Location = New System.Drawing.Point(6, 115)
        Me.txtComentarios.MaxLength = 200
        Me.txtComentarios.Multiline = True
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.Size = New System.Drawing.Size(1050, 151)
        Me.txtComentarios.TabIndex = 14
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(11, 85)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(120, 13)
        Me.Label45.TabIndex = 0
        Me.Label45.Text = "Comentarios de Adenda"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'gpoterminos
        '
        Me.gpoterminos.BackColor = System.Drawing.Color.Transparent
        Me.gpoterminos.BorderColor = System.Drawing.Color.Black
        Me.gpoterminos.Controls.Add(Me.Label17)
        Me.gpoterminos.Controls.Add(Me.dtVigenciaFin)
        Me.gpoterminos.Controls.Add(Me.dtVigenciaInicio)
        Me.gpoterminos.Controls.Add(Me.Label21)
        Me.gpoterminos.Controls.Add(Me.Label23)
        Me.gpoterminos.Controls.Add(Me.txtctamensmax)
        Me.gpoterminos.Controls.Add(Me.txtctamensmin)
        Me.gpoterminos.Controls.Add(Me.txtctaanualmax)
        Me.gpoterminos.Controls.Add(Me.txtctaanualmin)
        Me.gpoterminos.Controls.Add(Me.Label30)
        Me.gpoterminos.Controls.Add(Me.Label31)
        Me.gpoterminos.Controls.Add(Me.Label32)
        Me.gpoterminos.Controls.Add(Me.Label33)
        Me.gpoterminos.Controls.Add(Me.Label34)
        Me.gpoterminos.Controls.Add(Me.Label35)
        Me.gpoterminos.Location = New System.Drawing.Point(6, 6)
        Me.gpoterminos.Name = "gpoterminos"
        Me.gpoterminos.Size = New System.Drawing.Size(383, 65)
        Me.gpoterminos.TabIndex = 0
        Me.gpoterminos.TabStop = False
        Me.gpoterminos.Text = "Terminos"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(266, 5)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 13)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Vigencia de Contrato"
        '
        'dtVigenciaFin
        '
        Me.dtVigenciaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtVigenciaFin.Location = New System.Drawing.Point(288, 38)
        Me.dtVigenciaFin.Name = "dtVigenciaFin"
        Me.dtVigenciaFin.Size = New System.Drawing.Size(89, 20)
        Me.dtVigenciaFin.TabIndex = 21
        '
        'dtVigenciaInicio
        '
        Me.dtVigenciaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtVigenciaInicio.Location = New System.Drawing.Point(288, 18)
        Me.dtVigenciaInicio.Name = "dtVigenciaInicio"
        Me.dtVigenciaInicio.Size = New System.Drawing.Size(89, 20)
        Me.dtVigenciaInicio.TabIndex = 20
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(255, 39)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(21, 13)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Fin"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(255, 19)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(32, 13)
        Me.Label23.TabIndex = 19
        Me.Label23.Text = "Inicio"
        '
        'txtctamensmax
        '
        Me.txtctamensmax.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtctamensmax.Location = New System.Drawing.Point(199, 40)
        Me.txtctamensmax.MandatoryColor = System.Drawing.Color.Empty
        Me.txtctamensmax.MandatoryField = False
        Me.txtctamensmax.MaxLength = 10
        Me.txtctamensmax.Name = "txtctamensmax"
        Me.txtctamensmax.Size = New System.Drawing.Size(51, 20)
        Me.txtctamensmax.TabIndex = 18
        Me.txtctamensmax.Text = "0"
        Me.txtctamensmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtctamensmax.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtctamensmax.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtctamensmax.VCM_CustomInputTypeString = Nothing
        Me.txtctamensmax.VCM_CustomOmmitString = Nothing
        Me.txtctamensmax.VCM_EnterFocus = True
        Me.txtctamensmax.VCM_IsValidated = False
        Me.txtctamensmax.VCM_MensajeFoco = Nothing
        Me.txtctamensmax.VCM_MuestraMensajeFoco = False
        Me.txtctamensmax.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtctamensmax.VCM_RegularExpression = Nothing
        Me.txtctamensmax.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtctamensmax.VCM_ShowMessage = True
        Me.txtctamensmax.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'txtctamensmin
        '
        Me.txtctamensmin.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtctamensmin.Location = New System.Drawing.Point(125, 40)
        Me.txtctamensmin.MandatoryColor = System.Drawing.Color.Empty
        Me.txtctamensmin.MandatoryField = False
        Me.txtctamensmin.MaxLength = 10
        Me.txtctamensmin.Name = "txtctamensmin"
        Me.txtctamensmin.Size = New System.Drawing.Size(51, 20)
        Me.txtctamensmin.TabIndex = 4
        Me.txtctamensmin.Text = "0"
        Me.txtctamensmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtctamensmin.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtctamensmin.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtctamensmin.VCM_CustomInputTypeString = Nothing
        Me.txtctamensmin.VCM_CustomOmmitString = Nothing
        Me.txtctamensmin.VCM_EnterFocus = True
        Me.txtctamensmin.VCM_IsValidated = False
        Me.txtctamensmin.VCM_MensajeFoco = Nothing
        Me.txtctamensmin.VCM_MuestraMensajeFoco = False
        Me.txtctamensmin.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtctamensmin.VCM_RegularExpression = Nothing
        Me.txtctamensmin.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtctamensmin.VCM_ShowMessage = True
        Me.txtctamensmin.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'txtctaanualmax
        '
        Me.txtctaanualmax.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtctaanualmax.Location = New System.Drawing.Point(199, 18)
        Me.txtctaanualmax.MandatoryColor = System.Drawing.Color.Empty
        Me.txtctaanualmax.MandatoryField = False
        Me.txtctaanualmax.MaxLength = 10
        Me.txtctaanualmax.Name = "txtctaanualmax"
        Me.txtctaanualmax.Size = New System.Drawing.Size(51, 20)
        Me.txtctaanualmax.TabIndex = 1
        Me.txtctaanualmax.Text = "0"
        Me.txtctaanualmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtctaanualmax.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtctaanualmax.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtctaanualmax.VCM_CustomInputTypeString = Nothing
        Me.txtctaanualmax.VCM_CustomOmmitString = Nothing
        Me.txtctaanualmax.VCM_EnterFocus = True
        Me.txtctaanualmax.VCM_IsValidated = False
        Me.txtctaanualmax.VCM_MensajeFoco = Nothing
        Me.txtctaanualmax.VCM_MuestraMensajeFoco = False
        Me.txtctaanualmax.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtctaanualmax.VCM_RegularExpression = Nothing
        Me.txtctaanualmax.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtctaanualmax.VCM_ShowMessage = True
        Me.txtctaanualmax.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'txtctaanualmin
        '
        Me.txtctaanualmin.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtctaanualmin.Location = New System.Drawing.Point(125, 18)
        Me.txtctaanualmin.MandatoryColor = System.Drawing.Color.Empty
        Me.txtctaanualmin.MandatoryField = False
        Me.txtctaanualmin.MaxLength = 10
        Me.txtctaanualmin.Name = "txtctaanualmin"
        Me.txtctaanualmin.Size = New System.Drawing.Size(51, 20)
        Me.txtctaanualmin.TabIndex = 0
        Me.txtctaanualmin.Text = "0"
        Me.txtctaanualmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtctaanualmin.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtctaanualmin.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtctaanualmin.VCM_CustomInputTypeString = Nothing
        Me.txtctaanualmin.VCM_CustomOmmitString = Nothing
        Me.txtctaanualmin.VCM_EnterFocus = True
        Me.txtctaanualmin.VCM_IsValidated = False
        Me.txtctaanualmin.VCM_MensajeFoco = Nothing
        Me.txtctaanualmin.VCM_MuestraMensajeFoco = False
        Me.txtctaanualmin.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtctaanualmin.VCM_RegularExpression = Nothing
        Me.txtctaanualmin.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtctaanualmin.VCM_ShowMessage = True
        Me.txtctaanualmin.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(2, 43)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(97, 13)
        Me.Label30.TabIndex = 11
        Me.Label30.Text = "Cuota Mensual TM"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(173, 44)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(27, 13)
        Me.Label31.TabIndex = 13
        Me.Label31.Text = "Max"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(101, 42)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(24, 13)
        Me.Label32.TabIndex = 10
        Me.Label32.Text = "Min"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(173, 22)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(27, 13)
        Me.Label33.TabIndex = 6
        Me.Label33.Text = "Max"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(101, 22)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(24, 13)
        Me.Label34.TabIndex = 5
        Me.Label34.Text = "Min"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(2, 23)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(84, 13)
        Me.Label35.TabIndex = 7
        Me.Label35.Text = "Cuota Anual TM"
        '
        'CuGroupBox1
        '
        Me.CuGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.CuGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.CuGroupBox1.Controls.Add(Me.txtMaquila)
        Me.CuGroupBox1.Controls.Add(Me.Label29)
        Me.CuGroupBox1.Controls.Add(Me.lblDeposito)
        Me.CuGroupBox1.Controls.Add(Me.Label22)
        Me.CuGroupBox1.Controls.Add(Me.nupdMerma)
        Me.CuGroupBox1.Controls.Add(Me.Label7)
        Me.CuGroupBox1.Controls.Add(Me.cboDeposito)
        Me.CuGroupBox1.Controls.Add(Me.cboIncoterm)
        Me.CuGroupBox1.Location = New System.Drawing.Point(392, 6)
        Me.CuGroupBox1.Name = "CuGroupBox1"
        Me.CuGroupBox1.Size = New System.Drawing.Size(279, 65)
        Me.CuGroupBox1.TabIndex = 1
        Me.CuGroupBox1.TabStop = False
        '
        'txtMaquila
        '
        Me.txtMaquila.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtMaquila.Location = New System.Drawing.Point(211, 7)
        Me.txtMaquila.MandatoryColor = System.Drawing.Color.Empty
        Me.txtMaquila.MandatoryField = False
        Me.txtMaquila.MaxLength = 10
        Me.txtMaquila.Name = "txtMaquila"
        Me.txtMaquila.Size = New System.Drawing.Size(61, 20)
        Me.txtMaquila.TabIndex = 22
        Me.txtMaquila.Text = "0"
        Me.txtMaquila.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMaquila.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtMaquila.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtMaquila.VCM_CustomInputTypeString = Nothing
        Me.txtMaquila.VCM_CustomOmmitString = Nothing
        Me.txtMaquila.VCM_EnterFocus = True
        Me.txtMaquila.VCM_IsValidated = False
        Me.txtMaquila.VCM_MensajeFoco = Nothing
        Me.txtMaquila.VCM_MuestraMensajeFoco = False
        Me.txtMaquila.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtMaquila.VCM_RegularExpression = Nothing
        Me.txtMaquila.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtMaquila.VCM_ShowMessage = True
        Me.txtMaquila.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(132, 9)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(68, 13)
        Me.Label29.TabIndex = 25
        Me.Label29.Text = "TC USD/TM"
        '
        'lblDeposito
        '
        Me.lblDeposito.AutoSize = True
        Me.lblDeposito.Location = New System.Drawing.Point(132, 25)
        Me.lblDeposito.Name = "lblDeposito"
        Me.lblDeposito.Size = New System.Drawing.Size(49, 13)
        Me.lblDeposito.TabIndex = 24
        Me.lblDeposito.Text = "Deposito"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(2, 43)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 13)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "Incoterm"
        '
        'nupdMerma
        '
        Me.nupdMerma.DecimalPlaces = 2
        Me.nupdMerma.Location = New System.Drawing.Point(52, 7)
        Me.nupdMerma.Name = "nupdMerma"
        Me.nupdMerma.Size = New System.Drawing.Size(61, 20)
        Me.nupdMerma.TabIndex = 18
        Me.nupdMerma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nupdMerma.ThousandsSeparator = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Merma %"
        '
        'cboDeposito
        '
        Me.cboDeposito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDeposito.FormattingEnabled = True
        Me.cboDeposito.Location = New System.Drawing.Point(131, 39)
        Me.cboDeposito.Name = "cboDeposito"
        Me.cboDeposito.Size = New System.Drawing.Size(144, 21)
        Me.cboDeposito.TabIndex = 23
        '
        'cboIncoterm
        '
        Me.cboIncoterm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIncoterm.FormattingEnabled = True
        Me.cboIncoterm.Location = New System.Drawing.Point(52, 38)
        Me.cboIncoterm.Name = "cboIncoterm"
        Me.cboIncoterm.Size = New System.Drawing.Size(72, 21)
        Me.cboIncoterm.TabIndex = 19
        '
        'gpoescalador
        '
        Me.gpoescalador.BackColor = System.Drawing.Color.Transparent
        Me.gpoescalador.BorderColor = System.Drawing.Color.Black
        Me.gpoescalador.Controls.Add(Me.txtbasemenos2)
        Me.gpoescalador.Controls.Add(Me.txtbasemas2)
        Me.gpoescalador.Controls.Add(Me.txtbasemenos1)
        Me.gpoescalador.Controls.Add(Me.Label10)
        Me.gpoescalador.Controls.Add(Me.Label9)
        Me.gpoescalador.Controls.Add(Me.txtbase2)
        Me.gpoescalador.Controls.Add(Me.txtbasemas1)
        Me.gpoescalador.Controls.Add(Me.txtbase1)
        Me.gpoescalador.Location = New System.Drawing.Point(673, 6)
        Me.gpoescalador.Name = "gpoescalador"
        Me.gpoescalador.Size = New System.Drawing.Size(221, 65)
        Me.gpoescalador.TabIndex = 2
        Me.gpoescalador.TabStop = False
        Me.gpoescalador.Text = "Escalador +1 -1"
        '
        'txtbasemenos2
        '
        Me.txtbasemenos2.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtbasemenos2.Location = New System.Drawing.Point(180, 38)
        Me.txtbasemenos2.MandatoryColor = System.Drawing.Color.Empty
        Me.txtbasemenos2.MandatoryField = False
        Me.txtbasemenos2.MaxLength = 10
        Me.txtbasemenos2.Name = "txtbasemenos2"
        Me.txtbasemenos2.Size = New System.Drawing.Size(35, 20)
        Me.txtbasemenos2.TabIndex = 5
        Me.txtbasemenos2.Text = "0"
        Me.txtbasemenos2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtbasemenos2.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtbasemenos2.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtbasemenos2.VCM_CustomInputTypeString = Nothing
        Me.txtbasemenos2.VCM_CustomOmmitString = Nothing
        Me.txtbasemenos2.VCM_EnterFocus = True
        Me.txtbasemenos2.VCM_IsValidated = False
        Me.txtbasemenos2.VCM_MensajeFoco = Nothing
        Me.txtbasemenos2.VCM_MuestraMensajeFoco = False
        Me.txtbasemenos2.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtbasemenos2.VCM_RegularExpression = Nothing
        Me.txtbasemenos2.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtbasemenos2.VCM_ShowMessage = True
        Me.txtbasemenos2.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        Me.txtbasemenos2.Visible = False
        '
        'txtbasemas2
        '
        Me.txtbasemas2.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtbasemas2.Location = New System.Drawing.Point(137, 38)
        Me.txtbasemas2.MandatoryColor = System.Drawing.Color.Empty
        Me.txtbasemas2.MandatoryField = False
        Me.txtbasemas2.MaxLength = 10
        Me.txtbasemas2.Name = "txtbasemas2"
        Me.txtbasemas2.Size = New System.Drawing.Size(37, 20)
        Me.txtbasemas2.TabIndex = 4
        Me.txtbasemas2.Text = "0"
        Me.txtbasemas2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtbasemas2.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtbasemas2.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtbasemas2.VCM_CustomInputTypeString = Nothing
        Me.txtbasemas2.VCM_CustomOmmitString = Nothing
        Me.txtbasemas2.VCM_EnterFocus = True
        Me.txtbasemas2.VCM_IsValidated = False
        Me.txtbasemas2.VCM_MensajeFoco = Nothing
        Me.txtbasemas2.VCM_MuestraMensajeFoco = False
        Me.txtbasemas2.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtbasemas2.VCM_RegularExpression = Nothing
        Me.txtbasemas2.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtbasemas2.VCM_ShowMessage = True
        Me.txtbasemas2.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'txtbasemenos1
        '
        Me.txtbasemenos1.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtbasemenos1.Location = New System.Drawing.Point(180, 13)
        Me.txtbasemenos1.MandatoryColor = System.Drawing.Color.Empty
        Me.txtbasemenos1.MandatoryField = False
        Me.txtbasemenos1.MaxLength = 10
        Me.txtbasemenos1.Name = "txtbasemenos1"
        Me.txtbasemenos1.Size = New System.Drawing.Size(35, 20)
        Me.txtbasemenos1.TabIndex = 2
        Me.txtbasemenos1.Text = "0"
        Me.txtbasemenos1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtbasemenos1.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtbasemenos1.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtbasemenos1.VCM_CustomInputTypeString = Nothing
        Me.txtbasemenos1.VCM_CustomOmmitString = Nothing
        Me.txtbasemenos1.VCM_EnterFocus = True
        Me.txtbasemenos1.VCM_IsValidated = False
        Me.txtbasemenos1.VCM_MensajeFoco = Nothing
        Me.txtbasemenos1.VCM_MuestraMensajeFoco = False
        Me.txtbasemenos1.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtbasemenos1.VCM_RegularExpression = Nothing
        Me.txtbasemenos1.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtbasemenos1.VCM_ShowMessage = True
        Me.txtbasemenos1.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Base (USD/TM)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(2, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Base (USD/TM)"
        '
        'txtbase2
        '
        Me.txtbase2.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtbase2.Location = New System.Drawing.Point(90, 36)
        Me.txtbase2.MandatoryColor = System.Drawing.Color.Empty
        Me.txtbase2.MandatoryField = False
        Me.txtbase2.MaxLength = 10
        Me.txtbase2.Name = "txtbase2"
        Me.txtbase2.Size = New System.Drawing.Size(38, 20)
        Me.txtbase2.TabIndex = 3
        Me.txtbase2.Text = "0"
        Me.txtbase2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtbase2.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtbase2.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtbase2.VCM_CustomInputTypeString = Nothing
        Me.txtbase2.VCM_CustomOmmitString = Nothing
        Me.txtbase2.VCM_EnterFocus = True
        Me.txtbase2.VCM_IsValidated = False
        Me.txtbase2.VCM_MensajeFoco = Nothing
        Me.txtbase2.VCM_MuestraMensajeFoco = False
        Me.txtbase2.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtbase2.VCM_RegularExpression = Nothing
        Me.txtbase2.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtbase2.VCM_ShowMessage = True
        Me.txtbase2.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'txtbasemas1
        '
        Me.txtbasemas1.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtbasemas1.Location = New System.Drawing.Point(137, 13)
        Me.txtbasemas1.MandatoryColor = System.Drawing.Color.Empty
        Me.txtbasemas1.MandatoryField = False
        Me.txtbasemas1.MaxLength = 10
        Me.txtbasemas1.Name = "txtbasemas1"
        Me.txtbasemas1.Size = New System.Drawing.Size(37, 20)
        Me.txtbasemas1.TabIndex = 1
        Me.txtbasemas1.Text = "0"
        Me.txtbasemas1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtbasemas1.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtbasemas1.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtbasemas1.VCM_CustomInputTypeString = Nothing
        Me.txtbasemas1.VCM_CustomOmmitString = Nothing
        Me.txtbasemas1.VCM_EnterFocus = True
        Me.txtbasemas1.VCM_IsValidated = False
        Me.txtbasemas1.VCM_MensajeFoco = Nothing
        Me.txtbasemas1.VCM_MuestraMensajeFoco = False
        Me.txtbasemas1.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtbasemas1.VCM_RegularExpression = Nothing
        Me.txtbasemas1.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtbasemas1.VCM_ShowMessage = True
        Me.txtbasemas1.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'txtbase1
        '
        Me.txtbase1.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtbase1.Location = New System.Drawing.Point(90, 14)
        Me.txtbase1.MandatoryColor = System.Drawing.Color.Empty
        Me.txtbase1.MandatoryField = False
        Me.txtbase1.MaxLength = 10
        Me.txtbase1.Name = "txtbase1"
        Me.txtbase1.Size = New System.Drawing.Size(41, 20)
        Me.txtbase1.TabIndex = 0
        Me.txtbase1.Text = "0"
        Me.txtbase1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtbase1.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtbase1.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtbase1.VCM_CustomInputTypeString = Nothing
        Me.txtbase1.VCM_CustomOmmitString = Nothing
        Me.txtbase1.VCM_EnterFocus = True
        Me.txtbase1.VCM_IsValidated = False
        Me.txtbase1.VCM_MensajeFoco = Nothing
        Me.txtbase1.VCM_MuestraMensajeFoco = False
        Me.txtbase1.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtbase1.VCM_RegularExpression = Nothing
        Me.txtbase1.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtbase1.VCM_ShowMessage = True
        Me.txtbase1.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'gpoparticipacion
        '
        Me.gpoparticipacion.BackColor = System.Drawing.Color.Transparent
        Me.gpoparticipacion.BorderColor = System.Drawing.Color.Black
        Me.gpoparticipacion.Controls.Add(Me.nupdPorcentaje)
        Me.gpoparticipacion.Controls.Add(Me.txtbasepart)
        Me.gpoparticipacion.Controls.Add(Me.Label12)
        Me.gpoparticipacion.Controls.Add(Me.Label11)
        Me.gpoparticipacion.Location = New System.Drawing.Point(896, 6)
        Me.gpoparticipacion.Name = "gpoparticipacion"
        Me.gpoparticipacion.Size = New System.Drawing.Size(159, 65)
        Me.gpoparticipacion.TabIndex = 3
        Me.gpoparticipacion.TabStop = False
        Me.gpoparticipacion.Text = "Participacion de Precio"
        '
        'nupdPorcentaje
        '
        Me.nupdPorcentaje.DecimalPlaces = 2
        Me.nupdPorcentaje.Location = New System.Drawing.Point(87, 40)
        Me.nupdPorcentaje.Name = "nupdPorcentaje"
        Me.nupdPorcentaje.Size = New System.Drawing.Size(63, 20)
        Me.nupdPorcentaje.TabIndex = 1
        Me.nupdPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtbasepart
        '
        Me.txtbasepart.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtbasepart.Location = New System.Drawing.Point(87, 17)
        Me.txtbasepart.MandatoryColor = System.Drawing.Color.Empty
        Me.txtbasepart.MandatoryField = False
        Me.txtbasepart.MaxLength = 10
        Me.txtbasepart.Name = "txtbasepart"
        Me.txtbasepart.Size = New System.Drawing.Size(63, 20)
        Me.txtbasepart.TabIndex = 0
        Me.txtbasepart.Text = "0"
        Me.txtbasepart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtbasepart.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtbasepart.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtbasepart.VCM_CustomInputTypeString = Nothing
        Me.txtbasepart.VCM_CustomOmmitString = Nothing
        Me.txtbasepart.VCM_EnterFocus = True
        Me.txtbasepart.VCM_IsValidated = False
        Me.txtbasepart.VCM_MensajeFoco = Nothing
        Me.txtbasepart.VCM_MuestraMensajeFoco = False
        Me.txtbasepart.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtbasepart.VCM_RegularExpression = Nothing
        Me.txtbasepart.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtbasepart.VCM_ShowMessage = True
        Me.txtbasepart.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "%"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Base (USD/TM)"
        '
        'gpopagable
        '
        Me.gpopagable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpopagable.BackColor = System.Drawing.Color.Transparent
        Me.gpopagable.BorderColor = System.Drawing.Color.Black
        Me.gpopagable.Controls.Add(Me.dgvPagables)
        Me.gpopagable.Controls.Add(Me.ToolStrip3)
        Me.gpopagable.Location = New System.Drawing.Point(6, 72)
        Me.gpopagable.Name = "gpopagable"
        Me.gpopagable.Size = New System.Drawing.Size(896, 372)
        Me.gpopagable.TabIndex = 4
        Me.gpopagable.TabStop = False
        Me.gpopagable.Text = "Pagables"
        '
        'dgvPagables
        '
        Me.dgvPagables.AllowUserToAddRows = False
        Me.dgvPagables.AllowUserToDeleteRows = False
        Me.dgvPagables.AllowUserToResizeColumns = False
        Me.dgvPagables.AllowUserToResizeRows = False
        Me.dgvPagables.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPagables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPagables.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Elem, Me.Ley, Me.LeyMin, Me.LeyMax, Me.undfactor, Me.Pag, Me.undpag, Me.dgvTipo, Me.Ded, Me.undded, Me.RC, Me.undrc, Me.Prot, Me.undprot, Me.dgvMerc, Me.dgvAjuste, Me.dgvQP, Me.liquidacionPagable, Me.finley, Me.finprecio})
        Me.dgvPagables.Location = New System.Drawing.Point(6, 50)
        Me.dgvPagables.Name = "dgvPagables"
        Me.dgvPagables.RowHeadersWidth = 25
        Me.dgvPagables.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvPagables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvPagables.Size = New System.Drawing.Size(887, 319)
        Me.dgvPagables.TabIndex = 0
        '
        'Elem
        '
        Me.Elem.DataPropertyName = "codigoElemento"
        Me.Elem.HeaderText = "Elem"
        Me.Elem.Name = "Elem"
        Me.Elem.Width = 50
        '
        'Ley
        '
        Me.Ley.DataPropertyName = "leyPagable"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.Ley.DefaultCellStyle = DataGridViewCellStyle1
        Me.Ley.HeaderText = "Ley"
        Me.Ley.MaxInputLength = 5
        Me.Ley.Name = "Ley"
        Me.Ley.Width = 50
        '
        'LeyMin
        '
        Me.LeyMin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LeyMin.DataPropertyName = "LeyMin"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N3"
        DataGridViewCellStyle2.NullValue = "0"
        Me.LeyMin.DefaultCellStyle = DataGridViewCellStyle2
        Me.LeyMin.HeaderText = "Min"
        Me.LeyMin.Name = "LeyMin"
        Me.LeyMin.Width = 49
        '
        'LeyMax
        '
        Me.LeyMax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LeyMax.DataPropertyName = "LeyMax"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N3"
        DataGridViewCellStyle3.NullValue = "0"
        Me.LeyMax.DefaultCellStyle = DataGridViewCellStyle3
        Me.LeyMax.HeaderText = "Max"
        Me.LeyMax.Name = "LeyMax"
        Me.LeyMax.Width = 52
        '
        'undfactor
        '
        Me.undfactor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.undfactor.DataPropertyName = "undfactor"
        Me.undfactor.HeaderText = "und"
        Me.undfactor.Name = "undfactor"
        Me.undfactor.Width = 50
        '
        'Pag
        '
        Me.Pag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Pag.DataPropertyName = "pagable"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.Pag.DefaultCellStyle = DataGridViewCellStyle4
        Me.Pag.HeaderText = "Pag"
        Me.Pag.MaxInputLength = 5
        Me.Pag.Name = "Pag"
        Me.Pag.Width = 51
        '
        'undpag
        '
        Me.undpag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.undpag.DataPropertyName = "undpag"
        Me.undpag.HeaderText = "und"
        Me.undpag.Name = "undpag"
        Me.undpag.Width = 50
        '
        'dgvTipo
        '
        Me.dgvTipo.DataPropertyName = "codigoDeduccion"
        Me.dgvTipo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.dgvTipo.HeaderText = "Tipo"
        Me.dgvTipo.Name = "dgvTipo"
        Me.dgvTipo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgvTipo.Width = 60
        '
        'Ded
        '
        Me.Ded.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Ded.DataPropertyName = "deduccion"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.Ded.DefaultCellStyle = DataGridViewCellStyle5
        Me.Ded.HeaderText = "Ded"
        Me.Ded.MaxInputLength = 5
        Me.Ded.Name = "Ded"
        Me.Ded.Width = 52
        '
        'undded
        '
        Me.undded.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.undded.DataPropertyName = "undded"
        Me.undded.HeaderText = "und"
        Me.undded.Name = "undded"
        Me.undded.Width = 50
        '
        'RC
        '
        Me.RC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RC.DataPropertyName = "refinacion"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N3"
        DataGridViewCellStyle6.NullValue = "0"
        Me.RC.DefaultCellStyle = DataGridViewCellStyle6
        Me.RC.HeaderText = "RC"
        Me.RC.MaxInputLength = 6
        Me.RC.Name = "RC"
        Me.RC.Width = 47
        '
        'undrc
        '
        Me.undrc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.undrc.DataPropertyName = "undrc"
        Me.undrc.HeaderText = "und"
        Me.undrc.Name = "undrc"
        Me.undrc.Width = 50
        '
        'Prot
        '
        Me.Prot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Prot.DataPropertyName = "proteccion"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = "0"
        Me.Prot.DefaultCellStyle = DataGridViewCellStyle7
        Me.Prot.HeaderText = "Prot"
        Me.Prot.MaxInputLength = 5
        Me.Prot.Name = "Prot"
        Me.Prot.Width = 51
        '
        'undprot
        '
        Me.undprot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.undprot.DataPropertyName = "undprot"
        Me.undprot.HeaderText = "und"
        Me.undprot.Name = "undprot"
        Me.undprot.Width = 50
        '
        'dgvMerc
        '
        Me.dgvMerc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvMerc.DataPropertyName = "codigoMercado"
        Me.dgvMerc.HeaderText = "Merc"
        Me.dgvMerc.Name = "dgvMerc"
        Me.dgvMerc.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMerc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgvMerc.Width = 145
        '
        'dgvAjuste
        '
        Me.dgvAjuste.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvAjuste.DataPropertyName = "codigoqpajuste"
        Me.dgvAjuste.HeaderText = "Ajuste"
        Me.dgvAjuste.Name = "dgvAjuste"
        Me.dgvAjuste.Width = 80
        '
        'dgvQP
        '
        Me.dgvQP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvQP.DataPropertyName = "codigoQp"
        Me.dgvQP.HeaderText = "QP"
        Me.dgvQP.Name = "dgvQP"
        Me.dgvQP.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvQP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgvQP.Width = 70
        '
        'liquidacionPagable
        '
        Me.liquidacionPagable.DataPropertyName = "liquidacionPagable"
        Me.liquidacionPagable.HeaderText = "liquidacionPagable"
        Me.liquidacionPagable.Name = "liquidacionPagable"
        Me.liquidacionPagable.Visible = False
        '
        'finley
        '
        Me.finley.DataPropertyName = "indley"
        Me.finley.HeaderText = "indley"
        Me.finley.Name = "finley"
        Me.finley.Visible = False
        '
        'finprecio
        '
        Me.finprecio.DataPropertyName = "indpre"
        Me.finprecio.HeaderText = "indpre"
        Me.finprecio.Name = "finprecio"
        Me.finprecio.Visible = False
        '
        'ToolStrip3
        '
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregarPag, Me.ToolStripSeparator8, Me.tsCboPagable, Me.ToolStripSeparator3, Me.tsbEliminarPag, Me.ToolStripSeparator4})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(890, 31)
        Me.ToolStrip3.TabIndex = 0
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'tsbAgregarPag
        '
        Me.tsbAgregarPag.Image = CType(resources.GetObject("tsbAgregarPag.Image"), System.Drawing.Image)
        Me.tsbAgregarPag.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregarPag.Name = "tsbAgregarPag"
        Me.tsbAgregarPag.Size = New System.Drawing.Size(122, 28)
        Me.tsbAgregarPag.Text = "Agregar Pagable"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 31)
        '
        'tsCboPagable
        '
        Me.tsCboPagable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tsCboPagable.Name = "tsCboPagable"
        Me.tsCboPagable.Size = New System.Drawing.Size(121, 31)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 31)
        '
        'tsbEliminarPag
        '
        Me.tsbEliminarPag.Image = CType(resources.GetObject("tsbEliminarPag.Image"), System.Drawing.Image)
        Me.tsbEliminarPag.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminarPag.Name = "tsbEliminarPag"
        Me.tsbEliminarPag.Size = New System.Drawing.Size(123, 28)
        Me.tsbEliminarPag.Text = "Eliminar Pagable"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 31)
        '
        'gpopenalizable
        '
        Me.gpopenalizable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpopenalizable.BackColor = System.Drawing.Color.Transparent
        Me.gpopenalizable.BorderColor = System.Drawing.Color.Black
        Me.gpopenalizable.Controls.Add(Me.dgvPenalizable)
        Me.gpopenalizable.Controls.Add(Me.ToolStrip2)
        Me.gpopenalizable.Location = New System.Drawing.Point(908, 72)
        Me.gpopenalizable.Name = "gpopenalizable"
        Me.gpopenalizable.Size = New System.Drawing.Size(436, 372)
        Me.gpopenalizable.TabIndex = 5
        Me.gpopenalizable.TabStop = False
        Me.gpopenalizable.Text = "Penalizables"
        '
        'dgvPenalizable
        '
        Me.dgvPenalizable.AllowUserToAddRows = False
        Me.dgvPenalizable.AllowUserToDeleteRows = False
        Me.dgvPenalizable.AllowUserToResizeColumns = False
        Me.dgvPenalizable.AllowUserToResizeRows = False
        Me.dgvPenalizable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPenalizable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPenalizable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ElemP, Me.LeyP, Me.Min, Me.Max, Me.undfactorp, Me.Unid, Me.Pen, Me.undpen, Me.liquidacionPenalizableId})
        Me.dgvPenalizable.Location = New System.Drawing.Point(6, 50)
        Me.dgvPenalizable.Name = "dgvPenalizable"
        Me.dgvPenalizable.RowHeadersWidth = 25
        Me.dgvPenalizable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvPenalizable.Size = New System.Drawing.Size(429, 316)
        Me.dgvPenalizable.TabIndex = 0
        '
        'ElemP
        '
        Me.ElemP.DataPropertyName = "codigoElemento"
        Me.ElemP.HeaderText = "Elem"
        Me.ElemP.Name = "ElemP"
        Me.ElemP.Width = 50
        '
        'LeyP
        '
        Me.LeyP.DataPropertyName = "leyPenalizable"
        Me.LeyP.HeaderText = "Ley"
        Me.LeyP.MaxInputLength = 5
        Me.LeyP.Name = "LeyP"
        Me.LeyP.Width = 50
        '
        'Min
        '
        Me.Min.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Min.DataPropertyName = "minimo"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N3"
        DataGridViewCellStyle8.NullValue = "0"
        Me.Min.DefaultCellStyle = DataGridViewCellStyle8
        Me.Min.HeaderText = "Min"
        Me.Min.MaxInputLength = 10
        Me.Min.Name = "Min"
        Me.Min.Width = 49
        '
        'Max
        '
        Me.Max.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Max.DataPropertyName = "maximo"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N3"
        DataGridViewCellStyle9.NullValue = "0"
        Me.Max.DefaultCellStyle = DataGridViewCellStyle9
        Me.Max.HeaderText = "Max"
        Me.Max.MaxInputLength = 10
        Me.Max.Name = "Max"
        Me.Max.Width = 52
        '
        'undfactorp
        '
        Me.undfactorp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.undfactorp.DataPropertyName = "undfactorp"
        Me.undfactorp.HeaderText = "und"
        Me.undfactorp.Name = "undfactorp"
        Me.undfactorp.Width = 50
        '
        'Unid
        '
        Me.Unid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Unid.DataPropertyName = "unidadPenalizable"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = "0"
        Me.Unid.DefaultCellStyle = DataGridViewCellStyle10
        Me.Unid.HeaderText = "Unid"
        Me.Unid.MaxInputLength = 10
        Me.Unid.Name = "Unid"
        Me.Unid.Width = 54
        '
        'Pen
        '
        Me.Pen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Pen.DataPropertyName = "penalidad"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = "0"
        Me.Pen.DefaultCellStyle = DataGridViewCellStyle11
        Me.Pen.HeaderText = "Pen"
        Me.Pen.MaxInputLength = 10
        Me.Pen.Name = "Pen"
        Me.Pen.Width = 51
        '
        'undpen
        '
        Me.undpen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.undpen.DataPropertyName = "undpen"
        Me.undpen.HeaderText = "und"
        Me.undpen.Name = "undpen"
        Me.undpen.Width = 50
        '
        'liquidacionPenalizableId
        '
        Me.liquidacionPenalizableId.DataPropertyName = "liquidacionPenalizableId"
        Me.liquidacionPenalizableId.HeaderText = "liquidacionPenalizableId"
        Me.liquidacionPenalizableId.Name = "liquidacionPenalizableId"
        Me.liquidacionPenalizableId.Visible = False
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregarPen, Me.ToolStripSeparator9, Me.tsCboPenalizable, Me.ToolStripSeparator5, Me.tsbEliminarPen, Me.ToolStripSeparator6})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(430, 31)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbAgregarPen
        '
        Me.tsbAgregarPen.Image = CType(resources.GetObject("tsbAgregarPen.Image"), System.Drawing.Image)
        Me.tsbAgregarPen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregarPen.Name = "tsbAgregarPen"
        Me.tsbAgregarPen.Size = New System.Drawing.Size(139, 28)
        Me.tsbAgregarPen.Text = "Agregar Penalizable"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 31)
        '
        'tsCboPenalizable
        '
        Me.tsCboPenalizable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tsCboPenalizable.Name = "tsCboPenalizable"
        Me.tsCboPenalizable.Size = New System.Drawing.Size(121, 31)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 31)
        '
        'tsbEliminarPen
        '
        Me.tsbEliminarPen.Image = CType(resources.GetObject("tsbEliminarPen.Image"), System.Drawing.Image)
        Me.tsbEliminarPen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminarPen.Name = "tsbEliminarPen"
        Me.tsbEliminarPen.Size = New System.Drawing.Size(140, 28)
        Me.tsbEliminarPen.Text = "Eliminar Penalizable"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 31)
        '
        'CuGroupBox4
        '
        Me.CuGroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.CuGroupBox4.BorderColor = System.Drawing.Color.Black
        Me.CuGroupBox4.Controls.Add(Me.ContMenos)
        Me.CuGroupBox4.Controls.Add(Me.ContMas)
        Me.CuGroupBox4.Controls.Add(Me.BaseCont)
        Me.CuGroupBox4.Controls.Add(Me.Label19)
        Me.CuGroupBox4.Controls.Add(Me.RcBasemenos)
        Me.CuGroupBox4.Controls.Add(Me.Label18)
        Me.CuGroupBox4.Controls.Add(Me.RcBasemas)
        Me.CuGroupBox4.Controls.Add(Me.RcBase)
        Me.CuGroupBox4.Location = New System.Drawing.Point(1193, 6)
        Me.CuGroupBox4.Name = "CuGroupBox4"
        Me.CuGroupBox4.Size = New System.Drawing.Size(151, 64)
        Me.CuGroupBox4.TabIndex = 10
        Me.CuGroupBox4.TabStop = False
        Me.CuGroupBox4.Text = "Escalador RC"
        '
        'ContMenos
        '
        Me.ContMenos.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.ContMenos.Location = New System.Drawing.Point(122, 41)
        Me.ContMenos.MandatoryColor = System.Drawing.Color.Empty
        Me.ContMenos.MandatoryField = False
        Me.ContMenos.Name = "ContMenos"
        Me.ContMenos.Size = New System.Drawing.Size(27, 20)
        Me.ContMenos.TabIndex = 13
        Me.ContMenos.Text = "0"
        Me.ContMenos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ContMenos.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.ContMenos.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.ContMenos.VCM_CustomInputTypeString = Nothing
        Me.ContMenos.VCM_CustomOmmitString = Nothing
        Me.ContMenos.VCM_EnterFocus = True
        Me.ContMenos.VCM_IsValidated = False
        Me.ContMenos.VCM_MensajeFoco = Nothing
        Me.ContMenos.VCM_MuestraMensajeFoco = False
        Me.ContMenos.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.ContMenos.VCM_RegularExpression = Nothing
        Me.ContMenos.VCM_RegularExpressionErrorMessage = Nothing
        Me.ContMenos.VCM_ShowMessage = True
        Me.ContMenos.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.Normal
        '
        'ContMas
        '
        Me.ContMas.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.ContMas.Location = New System.Drawing.Point(94, 41)
        Me.ContMas.MandatoryColor = System.Drawing.Color.Empty
        Me.ContMas.MandatoryField = False
        Me.ContMas.Name = "ContMas"
        Me.ContMas.Size = New System.Drawing.Size(27, 20)
        Me.ContMas.TabIndex = 12
        Me.ContMas.Text = "0"
        Me.ContMas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ContMas.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.ContMas.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.ContMas.VCM_CustomInputTypeString = Nothing
        Me.ContMas.VCM_CustomOmmitString = Nothing
        Me.ContMas.VCM_EnterFocus = True
        Me.ContMas.VCM_IsValidated = False
        Me.ContMas.VCM_MensajeFoco = Nothing
        Me.ContMas.VCM_MuestraMensajeFoco = False
        Me.ContMas.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.ContMas.VCM_RegularExpression = Nothing
        Me.ContMas.VCM_RegularExpressionErrorMessage = Nothing
        Me.ContMas.VCM_ShowMessage = True
        Me.ContMas.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.Normal
        '
        'BaseCont
        '
        Me.BaseCont.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.BaseCont.Location = New System.Drawing.Point(55, 41)
        Me.BaseCont.MandatoryColor = System.Drawing.Color.Empty
        Me.BaseCont.MandatoryField = False
        Me.BaseCont.Name = "BaseCont"
        Me.BaseCont.Size = New System.Drawing.Size(33, 20)
        Me.BaseCont.TabIndex = 11
        Me.BaseCont.Text = "0"
        Me.BaseCont.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BaseCont.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.BaseCont.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.BaseCont.VCM_CustomInputTypeString = Nothing
        Me.BaseCont.VCM_CustomOmmitString = Nothing
        Me.BaseCont.VCM_EnterFocus = True
        Me.BaseCont.VCM_IsValidated = False
        Me.BaseCont.VCM_MensajeFoco = Nothing
        Me.BaseCont.VCM_MuestraMensajeFoco = False
        Me.BaseCont.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.BaseCont.VCM_RegularExpression = Nothing
        Me.BaseCont.VCM_RegularExpressionErrorMessage = Nothing
        Me.BaseCont.VCM_ShowMessage = True
        Me.BaseCont.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.Normal
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(-1, 44)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 13)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "Base Cont."
        '
        'RcBasemenos
        '
        Me.RcBasemenos.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.RcBasemenos.Location = New System.Drawing.Point(122, 15)
        Me.RcBasemenos.MandatoryColor = System.Drawing.Color.Empty
        Me.RcBasemenos.MandatoryField = False
        Me.RcBasemenos.Name = "RcBasemenos"
        Me.RcBasemenos.Size = New System.Drawing.Size(27, 20)
        Me.RcBasemenos.TabIndex = 7
        Me.RcBasemenos.Text = "0"
        Me.RcBasemenos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RcBasemenos.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.RcBasemenos.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.RcBasemenos.VCM_CustomInputTypeString = Nothing
        Me.RcBasemenos.VCM_CustomOmmitString = Nothing
        Me.RcBasemenos.VCM_EnterFocus = True
        Me.RcBasemenos.VCM_IsValidated = False
        Me.RcBasemenos.VCM_MensajeFoco = Nothing
        Me.RcBasemenos.VCM_MuestraMensajeFoco = False
        Me.RcBasemenos.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.RcBasemenos.VCM_RegularExpression = Nothing
        Me.RcBasemenos.VCM_RegularExpressionErrorMessage = Nothing
        Me.RcBasemenos.VCM_ShowMessage = True
        Me.RcBasemenos.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.Normal
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(-1, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Base USD"
        '
        'RcBasemas
        '
        Me.RcBasemas.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.RcBasemas.Location = New System.Drawing.Point(94, 15)
        Me.RcBasemas.MandatoryColor = System.Drawing.Color.Empty
        Me.RcBasemas.MandatoryField = False
        Me.RcBasemas.Name = "RcBasemas"
        Me.RcBasemas.Size = New System.Drawing.Size(27, 20)
        Me.RcBasemas.TabIndex = 8
        Me.RcBasemas.Text = "0"
        Me.RcBasemas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RcBasemas.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.RcBasemas.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.RcBasemas.VCM_CustomInputTypeString = Nothing
        Me.RcBasemas.VCM_CustomOmmitString = Nothing
        Me.RcBasemas.VCM_EnterFocus = True
        Me.RcBasemas.VCM_IsValidated = False
        Me.RcBasemas.VCM_MensajeFoco = Nothing
        Me.RcBasemas.VCM_MuestraMensajeFoco = False
        Me.RcBasemas.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.RcBasemas.VCM_RegularExpression = Nothing
        Me.RcBasemas.VCM_RegularExpressionErrorMessage = Nothing
        Me.RcBasemas.VCM_ShowMessage = True
        Me.RcBasemas.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.Normal
        '
        'RcBase
        '
        Me.RcBase.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.RcBase.Location = New System.Drawing.Point(55, 15)
        Me.RcBase.MandatoryColor = System.Drawing.Color.Empty
        Me.RcBase.MandatoryField = False
        Me.RcBase.Name = "RcBase"
        Me.RcBase.Size = New System.Drawing.Size(33, 20)
        Me.RcBase.TabIndex = 9
        Me.RcBase.Text = "0"
        Me.RcBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RcBase.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.RcBase.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.RcBase.VCM_CustomInputTypeString = Nothing
        Me.RcBase.VCM_CustomOmmitString = Nothing
        Me.RcBase.VCM_EnterFocus = True
        Me.RcBase.VCM_IsValidated = False
        Me.RcBase.VCM_MensajeFoco = Nothing
        Me.RcBase.VCM_MuestraMensajeFoco = False
        Me.RcBase.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.RcBase.VCM_RegularExpression = Nothing
        Me.RcBase.VCM_RegularExpressionErrorMessage = Nothing
        Me.RcBase.VCM_ShowMessage = True
        Me.RcBase.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.Normal
        '
        'gbPeriodo
        '
        Me.gbPeriodo.BackColor = System.Drawing.Color.Transparent
        Me.gbPeriodo.BorderColor = System.Drawing.Color.Black
        Me.gbPeriodo.Controls.Add(Me.cboCategoria)
        Me.gbPeriodo.Controls.Add(Me.Label63)
        Me.gbPeriodo.Controls.Add(Me.cboPeriodo)
        Me.gbPeriodo.Controls.Add(Me.lblfechaliq)
        Me.gbPeriodo.Controls.Add(Me.lblperiodo)
        Me.gbPeriodo.Location = New System.Drawing.Point(1057, 6)
        Me.gbPeriodo.Name = "gbPeriodo"
        Me.gbPeriodo.Size = New System.Drawing.Size(135, 65)
        Me.gbPeriodo.TabIndex = 6
        Me.gbPeriodo.TabStop = False
        '
        'cboCategoria
        '
        Me.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(57, 9)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(71, 21)
        Me.cboCategoria.TabIndex = 23
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(4, 15)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(54, 13)
        Me.Label63.TabIndex = 24
        Me.Label63.Text = "Categoría"
        '
        'cboPeriodo
        '
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.Location = New System.Drawing.Point(58, 40)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(70, 21)
        Me.cboPeriodo.TabIndex = 22
        '
        'lblfechaliq
        '
        Me.lblfechaliq.AutoSize = True
        Me.lblfechaliq.Location = New System.Drawing.Point(13, 10)
        Me.lblfechaliq.Name = "lblfechaliq"
        Me.lblfechaliq.Size = New System.Drawing.Size(0, 13)
        Me.lblfechaliq.TabIndex = 0
        '
        'lblperiodo
        '
        Me.lblperiodo.AutoSize = True
        Me.lblperiodo.Location = New System.Drawing.Point(7, 47)
        Me.lblperiodo.Name = "lblperiodo"
        Me.lblperiodo.Size = New System.Drawing.Size(49, 13)
        Me.lblperiodo.TabIndex = 0
        Me.lblperiodo.Text = "Periodo :"
        '
        'CuGroupBox3
        '
        Me.CuGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.CuGroupBox3.BorderColor = System.Drawing.Color.Black
        Me.CuGroupBox3.Controls.Add(Me.txtCorreo)
        Me.CuGroupBox3.Controls.Add(Me.txtTelefono)
        Me.CuGroupBox3.Controls.Add(Me.txtContacto)
        Me.CuGroupBox3.Controls.Add(Me.Label16)
        Me.CuGroupBox3.Controls.Add(Me.Label8)
        Me.CuGroupBox3.Controls.Add(Me.Label24)
        Me.CuGroupBox3.Location = New System.Drawing.Point(756, 6)
        Me.CuGroupBox3.Name = "CuGroupBox3"
        Me.CuGroupBox3.Size = New System.Drawing.Size(300, 92)
        Me.CuGroupBox3.TabIndex = 3
        Me.CuGroupBox3.TabStop = False
        Me.CuGroupBox3.Text = "Contacto"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(92, 53)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.ReadOnly = True
        Me.txtCorreo.Size = New System.Drawing.Size(209, 20)
        Me.txtCorreo.TabIndex = 0
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(91, 31)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.ReadOnly = True
        Me.txtTelefono.Size = New System.Drawing.Size(209, 20)
        Me.txtTelefono.TabIndex = 0
        '
        'txtContacto
        '
        Me.txtContacto.Location = New System.Drawing.Point(91, 9)
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.ReadOnly = True
        Me.txtContacto.Size = New System.Drawing.Size(209, 20)
        Me.txtContacto.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(29, 60)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Correo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Telefono"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(29, 12)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(44, 13)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Nombre"
        '
        'CuGroupBox2
        '
        Me.CuGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.CuGroupBox2.BorderColor = System.Drawing.Color.Black
        Me.CuGroupBox2.Controls.Add(Me.txtprocedencia)
        Me.CuGroupBox2.Controls.Add(Me.Label42)
        Me.CuGroupBox2.Location = New System.Drawing.Point(327, 6)
        Me.CuGroupBox2.Name = "CuGroupBox2"
        Me.CuGroupBox2.Size = New System.Drawing.Size(423, 65)
        Me.CuGroupBox2.TabIndex = 2
        Me.CuGroupBox2.TabStop = False
        Me.CuGroupBox2.Text = "Mercaderias"
        '
        'txtprocedencia
        '
        Me.txtprocedencia.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtprocedencia.Location = New System.Drawing.Point(9, 39)
        Me.txtprocedencia.MandatoryColor = System.Drawing.Color.Empty
        Me.txtprocedencia.MandatoryField = False
        Me.txtprocedencia.MaxLength = 200
        Me.txtprocedencia.Name = "txtprocedencia"
        Me.txtprocedencia.Size = New System.Drawing.Size(408, 20)
        Me.txtprocedencia.TabIndex = 0
        Me.txtprocedencia.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtprocedencia.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtprocedencia.VCM_CustomInputTypeString = Nothing
        Me.txtprocedencia.VCM_CustomOmmitString = Nothing
        Me.txtprocedencia.VCM_EnterFocus = True
        Me.txtprocedencia.VCM_IsValidated = False
        Me.txtprocedencia.VCM_MensajeFoco = Nothing
        Me.txtprocedencia.VCM_MuestraMensajeFoco = False
        Me.txtprocedencia.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtprocedencia.VCM_RegularExpression = Nothing
        Me.txtprocedencia.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtprocedencia.VCM_ShowMessage = True
        Me.txtprocedencia.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.AlfaNumerico
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(6, 16)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(67, 13)
        Me.Label42.TabIndex = 0
        Me.Label42.Text = "Procedencia"
        '
        'gpofacturacion
        '
        Me.gpofacturacion.BackColor = System.Drawing.Color.Transparent
        Me.gpofacturacion.BorderColor = System.Drawing.Color.Black
        Me.gpofacturacion.Controls.Add(Me.nupdPorcPago)
        Me.gpofacturacion.Controls.Add(Me.Label13)
        Me.gpofacturacion.Location = New System.Drawing.Point(6, 6)
        Me.gpofacturacion.Name = "gpofacturacion"
        Me.gpofacturacion.Size = New System.Drawing.Size(80, 65)
        Me.gpofacturacion.TabIndex = 0
        Me.gpofacturacion.TabStop = False
        Me.gpofacturacion.Text = "Facturacion"
        '
        'nupdPorcPago
        '
        Me.nupdPorcPago.DecimalPlaces = 2
        Me.nupdPorcPago.Location = New System.Drawing.Point(6, 36)
        Me.nupdPorcPago.Name = "nupdPorcPago"
        Me.nupdPorcPago.Size = New System.Drawing.Size(66, 20)
        Me.nupdPorcPago.TabIndex = 0
        Me.nupdPorcPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "% de Pago"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BorderColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.txttasamora)
        Me.GroupBox1.Controls.Add(Me.txttiempo)
        Me.GroupBox1.Controls.Add(Me.txttasa)
        Me.GroupBox1.Controls.Add(Me.Label41)
        Me.GroupBox1.Controls.Add(Me.Label38)
        Me.GroupBox1.Controls.Add(Me.Label40)
        Me.GroupBox1.Controls.Add(Me.Label39)
        Me.GroupBox1.Controls.Add(Me.cboModo)
        Me.GroupBox1.Location = New System.Drawing.Point(92, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 65)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Financiamiento"
        '
        'txttasamora
        '
        Me.txttasamora.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txttasamora.Location = New System.Drawing.Point(160, 16)
        Me.txttasamora.MandatoryColor = System.Drawing.Color.Empty
        Me.txttasamora.MandatoryField = False
        Me.txttasamora.MaxLength = 10
        Me.txttasamora.Name = "txttasamora"
        Me.txttasamora.Size = New System.Drawing.Size(63, 20)
        Me.txttasamora.TabIndex = 1
        Me.txttasamora.Text = "0"
        Me.txttasamora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txttasamora.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txttasamora.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txttasamora.VCM_CustomInputTypeString = Nothing
        Me.txttasamora.VCM_CustomOmmitString = Nothing
        Me.txttasamora.VCM_EnterFocus = True
        Me.txttasamora.VCM_IsValidated = False
        Me.txttasamora.VCM_MensajeFoco = Nothing
        Me.txttasamora.VCM_MuestraMensajeFoco = False
        Me.txttasamora.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txttasamora.VCM_RegularExpression = Nothing
        Me.txttasamora.VCM_RegularExpressionErrorMessage = Nothing
        Me.txttasamora.VCM_ShowMessage = True
        Me.txttasamora.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'txttiempo
        '
        Me.txttiempo.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txttiempo.Location = New System.Drawing.Point(54, 39)
        Me.txttiempo.MandatoryColor = System.Drawing.Color.Empty
        Me.txttiempo.MandatoryField = False
        Me.txttiempo.MaxLength = 10
        Me.txttiempo.Name = "txttiempo"
        Me.txttiempo.Size = New System.Drawing.Size(38, 20)
        Me.txttiempo.TabIndex = 2
        Me.txttiempo.Text = "0"
        Me.txttiempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txttiempo.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txttiempo.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txttiempo.VCM_CustomInputTypeString = Nothing
        Me.txttiempo.VCM_CustomOmmitString = Nothing
        Me.txttiempo.VCM_EnterFocus = True
        Me.txttiempo.VCM_IsValidated = False
        Me.txttiempo.VCM_MensajeFoco = Nothing
        Me.txttiempo.VCM_MuestraMensajeFoco = False
        Me.txttiempo.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txttiempo.VCM_RegularExpression = Nothing
        Me.txttiempo.VCM_RegularExpressionErrorMessage = Nothing
        Me.txttiempo.VCM_ShowMessage = True
        Me.txttiempo.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'txttasa
        '
        Me.txttasa.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txttasa.Location = New System.Drawing.Point(54, 14)
        Me.txttasa.MandatoryColor = System.Drawing.Color.Empty
        Me.txttasa.MandatoryField = False
        Me.txttasa.MaxLength = 10
        Me.txttasa.Name = "txttasa"
        Me.txttasa.Size = New System.Drawing.Size(38, 20)
        Me.txttasa.TabIndex = 0
        Me.txttasa.Text = "0"
        Me.txttasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txttasa.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txttasa.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txttasa.VCM_CustomInputTypeString = Nothing
        Me.txttasa.VCM_CustomOmmitString = Nothing
        Me.txttasa.VCM_EnterFocus = True
        Me.txttasa.VCM_IsValidated = False
        Me.txttasa.VCM_MensajeFoco = Nothing
        Me.txttasa.VCM_MuestraMensajeFoco = False
        Me.txttasa.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txttasa.VCM_RegularExpression = Nothing
        Me.txttasa.VCM_RegularExpressionErrorMessage = Nothing
        Me.txttasa.VCM_ShowMessage = True
        Me.txttasa.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(96, 43)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(34, 13)
        Me.Label41.TabIndex = 6
        Me.Label41.Text = "Modo"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(6, 43)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(42, 13)
        Me.Label38.TabIndex = 4
        Me.Label38.Text = "Tiempo"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(96, 21)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(58, 13)
        Me.Label40.TabIndex = 2
        Me.Label40.Text = "Tasa Mora"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(6, 21)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(31, 13)
        Me.Label39.TabIndex = 0
        Me.Label39.Text = "Tasa"
        '
        'cboModo
        '
        Me.cboModo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboModo.FormattingEnabled = True
        Me.cboModo.Location = New System.Drawing.Point(149, 39)
        Me.cboModo.Name = "cboModo"
        Me.cboModo.Size = New System.Drawing.Size(74, 21)
        Me.cboModo.TabIndex = 3
        '
        'CuGroupBox5
        '
        Me.CuGroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.CuGroupBox5.BorderColor = System.Drawing.Color.Black
        Me.CuGroupBox5.Controls.Add(Me.Button1)
        Me.CuGroupBox5.Controls.Add(Me.Label46)
        Me.CuGroupBox5.Controls.Add(Me.cboTrader)
        Me.CuGroupBox5.Location = New System.Drawing.Point(965, 42)
        Me.CuGroupBox5.Name = "CuGroupBox5"
        Me.CuGroupBox5.Size = New System.Drawing.Size(111, 65)
        Me.CuGroupBox5.TabIndex = 13
        Me.CuGroupBox5.TabStop = False
        Me.CuGroupBox5.Text = "Negociacion"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(88, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(17, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(6, 16)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(38, 13)
        Me.Label46.TabIndex = 0
        Me.Label46.Text = "Trader"
        '
        'cboTrader
        '
        Me.cboTrader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboTrader.Enabled = False
        Me.cboTrader.FormattingEnabled = True
        Me.cboTrader.Location = New System.Drawing.Point(9, 39)
        Me.cboTrader.Name = "cboTrader"
        Me.cboTrader.Size = New System.Drawing.Size(76, 21)
        Me.cboTrader.TabIndex = 0
        '
        'txtcorrelativoliquidacion
        '
        Me.txtcorrelativoliquidacion.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtcorrelativoliquidacion.Enabled = False
        Me.txtcorrelativoliquidacion.Location = New System.Drawing.Point(958, 6)
        Me.txtcorrelativoliquidacion.MandatoryColor = System.Drawing.Color.Empty
        Me.txtcorrelativoliquidacion.MandatoryField = False
        Me.txtcorrelativoliquidacion.Name = "txtcorrelativoliquidacion"
        Me.txtcorrelativoliquidacion.Size = New System.Drawing.Size(120, 20)
        Me.txtcorrelativoliquidacion.TabIndex = 5
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
        Me.txtCorrelativo.Location = New System.Drawing.Point(769, 6)
        Me.txtCorrelativo.MandatoryColor = System.Drawing.Color.Empty
        Me.txtCorrelativo.MandatoryField = False
        Me.txtCorrelativo.Name = "txtCorrelativo"
        Me.txtCorrelativo.Size = New System.Drawing.Size(120, 20)
        Me.txtCorrelativo.TabIndex = 3
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
        'gpocompania
        '
        Me.gpocompania.BackColor = System.Drawing.Color.Transparent
        Me.gpocompania.BorderColor = System.Drawing.Color.Black
        Me.gpocompania.Controls.Add(Me.txtref1)
        Me.gpocompania.Controls.Add(Me.btncalidad)
        Me.gpocompania.Controls.Add(Me.cboCalidad)
        Me.gpocompania.Controls.Add(Me.Label43)
        Me.gpocompania.Controls.Add(Me.btnsocio)
        Me.gpocompania.Controls.Add(Me.Label6)
        Me.gpocompania.Controls.Add(Me.cboSocio)
        Me.gpocompania.Controls.Add(Me.cboEmpresa)
        Me.gpocompania.Controls.Add(Me.Label5)
        Me.gpocompania.Location = New System.Drawing.Point(460, 42)
        Me.gpocompania.Name = "gpocompania"
        Me.gpocompania.Size = New System.Drawing.Size(499, 65)
        Me.gpocompania.TabIndex = 8
        Me.gpocompania.TabStop = False
        Me.gpocompania.Text = "Compañia"
        '
        'txtref1
        '
        Me.txtref1.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtref1.Location = New System.Drawing.Point(345, 36)
        Me.txtref1.MandatoryColor = System.Drawing.Color.Empty
        Me.txtref1.MandatoryField = False
        Me.txtref1.MaxLength = 50
        Me.txtref1.Name = "txtref1"
        Me.txtref1.Size = New System.Drawing.Size(145, 20)
        Me.txtref1.TabIndex = 10
        Me.txtref1.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtref1.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtref1.VCM_CustomInputTypeString = "1234567890 -abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Me.txtref1.VCM_CustomOmmitString = Nothing
        Me.txtref1.VCM_EnterFocus = True
        Me.txtref1.VCM_IsValidated = False
        Me.txtref1.VCM_MensajeFoco = Nothing
        Me.txtref1.VCM_MuestraMensajeFoco = False
        Me.txtref1.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.SinDecimal
        Me.txtref1.VCM_RegularExpression = Nothing
        Me.txtref1.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtref1.VCM_ShowMessage = True
        Me.txtref1.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.Personalizado
        '
        'btncalidad
        '
        Me.btncalidad.Location = New System.Drawing.Point(455, 6)
        Me.btncalidad.Name = "btncalidad"
        Me.btncalidad.Size = New System.Drawing.Size(35, 23)
        Me.btncalidad.TabIndex = 9
        Me.btncalidad.Text = "..."
        Me.btncalidad.UseVisualStyleBackColor = True
        Me.btncalidad.Visible = False
        '
        'cboCalidad
        '
        Me.cboCalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboCalidad.Enabled = False
        Me.cboCalidad.FormattingEnabled = True
        Me.cboCalidad.Location = New System.Drawing.Point(406, 8)
        Me.cboCalidad.Name = "cboCalidad"
        Me.cboCalidad.Size = New System.Drawing.Size(43, 21)
        Me.cboCalidad.TabIndex = 7
        Me.cboCalidad.Visible = False
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(342, 19)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(42, 13)
        Me.Label43.TabIndex = 8
        Me.Label43.Text = "Calidad"
        '
        'btnsocio
        '
        Me.btnsocio.Location = New System.Drawing.Point(304, 36)
        Me.btnsocio.Name = "btnsocio"
        Me.btnsocio.Size = New System.Drawing.Size(35, 23)
        Me.btnsocio.TabIndex = 2
        Me.btnsocio.Text = "..."
        Me.btnsocio.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(146, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cliente/Proveedor"
        '
        'cboSocio
        '
        Me.cboSocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboSocio.Enabled = False
        Me.cboSocio.FormattingEnabled = True
        Me.cboSocio.Location = New System.Drawing.Point(149, 38)
        Me.cboSocio.Name = "cboSocio"
        Me.cboSocio.Size = New System.Drawing.Size(152, 21)
        Me.cboSocio.TabIndex = 1
        '
        'cboEmpresa
        '
        Me.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.Location = New System.Drawing.Point(12, 38)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(132, 21)
        Me.cboEmpresa.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Empresa"
        '
        'gpomercaderia
        '
        Me.gpomercaderia.BackColor = System.Drawing.Color.Transparent
        Me.gpomercaderia.BorderColor = System.Drawing.Color.Black
        Me.gpomercaderia.Controls.Add(Me.cboProducto)
        Me.gpomercaderia.Controls.Add(Me.cboClase)
        Me.gpomercaderia.Controls.Add(Me.Label4)
        Me.gpomercaderia.Controls.Add(Me.Label3)
        Me.gpomercaderia.Location = New System.Drawing.Point(204, 42)
        Me.gpomercaderia.Name = "gpomercaderia"
        Me.gpomercaderia.Size = New System.Drawing.Size(250, 65)
        Me.gpomercaderia.TabIndex = 7
        Me.gpomercaderia.TabStop = False
        Me.gpomercaderia.Text = "Mercaderias"
        '
        'cboProducto
        '
        Me.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProducto.FormattingEnabled = True
        Me.cboProducto.Location = New System.Drawing.Point(12, 39)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Size = New System.Drawing.Size(98, 21)
        Me.cboProducto.TabIndex = 0
        '
        'cboClase
        '
        Me.cboClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClase.FormattingEnabled = True
        Me.cboClase.Location = New System.Drawing.Point(116, 38)
        Me.cboClase.Name = "cboClase"
        Me.cboClase.Size = New System.Drawing.Size(128, 21)
        Me.cboClase.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(113, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Clase"
        '
        'gpocontrato
        '
        Me.gpocontrato.BackColor = System.Drawing.Color.Transparent
        Me.gpocontrato.BorderColor = System.Drawing.Color.Black
        Me.gpocontrato.Controls.Add(Me.txtNumero)
        Me.gpocontrato.Controls.Add(Me.Label2)
        Me.gpocontrato.Controls.Add(Me.Label1)
        Me.gpocontrato.Controls.Add(Me.cbotipoc)
        Me.gpocontrato.Controls.Add(Me.cboTipo)
        Me.gpocontrato.Location = New System.Drawing.Point(6, 42)
        Me.gpocontrato.Name = "gpocontrato"
        Me.gpocontrato.Size = New System.Drawing.Size(192, 65)
        Me.gpocontrato.TabIndex = 6
        Me.gpocontrato.TabStop = False
        Me.gpocontrato.Text = "Contrato"
        '
        'txtNumero
        '
        Me.txtNumero.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtNumero.Location = New System.Drawing.Point(125, 37)
        Me.txtNumero.MandatoryColor = System.Drawing.Color.Empty
        Me.txtNumero.MandatoryField = False
        Me.txtNumero.MaxLength = 10
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(56, 20)
        Me.txtNumero.TabIndex = 1
        Me.txtNumero.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtNumero.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtNumero.VCM_CustomInputTypeString = "1234567890-ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Me.txtNumero.VCM_CustomOmmitString = Nothing
        Me.txtNumero.VCM_EnterFocus = True
        Me.txtNumero.VCM_IsValidated = False
        Me.txtNumero.VCM_MensajeFoco = Nothing
        Me.txtNumero.VCM_MuestraMensajeFoco = False
        Me.txtNumero.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.SinDecimal
        Me.txtNumero.VCM_RegularExpression = Nothing
        Me.txtNumero.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtNumero.VCM_ShowMessage = True
        Me.txtNumero.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.Personalizado
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo"
        '
        'cbotipoc
        '
        Me.cbotipoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbotipoc.Enabled = False
        Me.cbotipoc.FormattingEnabled = True
        Me.cbotipoc.Location = New System.Drawing.Point(95, 37)
        Me.cbotipoc.Name = "cbotipoc"
        Me.cbotipoc.Size = New System.Drawing.Size(24, 21)
        Me.cbotipoc.TabIndex = 0
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(4, 37)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(85, 21)
        Me.cboTipo.TabIndex = 0
        '
        'editcontrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1362, 594)
        Me.Controls.Add(Me.tbcTerminos)
        Me.Controls.Add(Me.CuGroupBox5)
        Me.Controls.Add(Me.txtcorrelativoliquidacion)
        Me.Controls.Add(Me.txtCorrelativo)
        Me.Controls.Add(Me.gpocompania)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.gpomercaderia)
        Me.Controls.Add(Me.gpocontrato)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.msMenu)
        Me.KeyPreview = True
        Me.Name = "editcontrato"
        Me.ShowInTaskbar = False
        Me.Text = "Edicion de Contrato"
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.msMenu.ResumeLayout(False)
        Me.msMenu.PerformLayout()
        Me.tbcTerminos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.gpoterminos.ResumeLayout(False)
        Me.gpoterminos.PerformLayout()
        Me.CuGroupBox1.ResumeLayout(False)
        Me.CuGroupBox1.PerformLayout()
        CType(Me.nupdMerma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoescalador.ResumeLayout(False)
        Me.gpoescalador.PerformLayout()
        Me.gpoparticipacion.ResumeLayout(False)
        Me.gpoparticipacion.PerformLayout()
        CType(Me.nupdPorcentaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpopagable.ResumeLayout(False)
        Me.gpopagable.PerformLayout()
        CType(Me.dgvPagables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.gpopenalizable.ResumeLayout(False)
        Me.gpopenalizable.PerformLayout()
        CType(Me.dgvPenalizable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.CuGroupBox4.ResumeLayout(False)
        Me.CuGroupBox4.PerformLayout()
        Me.gbPeriodo.ResumeLayout(False)
        Me.gbPeriodo.PerformLayout()
        Me.CuGroupBox3.ResumeLayout(False)
        Me.CuGroupBox3.PerformLayout()
        Me.CuGroupBox2.ResumeLayout(False)
        Me.CuGroupBox2.PerformLayout()
        Me.gpofacturacion.ResumeLayout(False)
        Me.gpofacturacion.PerformLayout()
        CType(Me.nupdPorcPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.CuGroupBox5.ResumeLayout(False)
        Me.CuGroupBox5.PerformLayout()
        Me.gpocompania.ResumeLayout(False)
        Me.gpocompania.PerformLayout()
        Me.gpomercaderia.ResumeLayout(False)
        Me.gpomercaderia.PerformLayout()
        Me.gpocontrato.ResumeLayout(False)
        Me.gpocontrato.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents msMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents ContratoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmGuardar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gpocontrato As CUGroupBox
    Friend WithEvents txtNumero As CUTextbox 'System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents gpomercaderia As CUGroupBox
    Friend WithEvents cboProducto As System.Windows.Forms.ComboBox
    Friend WithEvents cboClase As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gpocompania As CUGroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gpoterminos As CUGroupBox
    'System.Windows.Forms.TextBox
    Friend WithEvents gpopagable As CUGroupBox
    Friend WithEvents gpopenalizable As CUGroupBox
    Friend WithEvents gpoescalador As CUGroupBox
    Friend WithEvents gpoparticipacion As CUGroupBox
    Friend WithEvents txtbasemenos2 As CUTextbox 'System.Windows.Forms.TextBox
    Friend WithEvents txtbasemas2 As CUTextbox 'System.Windows.Forms.TextBox
    Friend WithEvents txtbasemenos1 As CUTextbox 'System.Windows.Forms.TextBox
    Friend WithEvents txtbase2 As CUTextbox 'System.Windows.Forms.TextBox
    Friend WithEvents txtbasemas1 As CUTextbox 'System.Windows.Forms.TextBox
    Friend WithEvents txtbase1 As CUTextbox 'System.Windows.Forms.TextBox
    Friend WithEvents nupdPorcentaje As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtbasepart As CUTextbox 'System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents gpofacturacion As CUGroupBox
    Friend WithEvents nupdPorcPago As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCorrelativo As CUTextbox 'System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAgregarPen As System.Windows.Forms.ToolStripButton
    'System.Windows.Forms.TextBox
    'System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbEliminarPen As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAgregarPag As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbEliminarPag As System.Windows.Forms.ToolStripButton
    'System.Windows.Forms.TextBox
    'System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtcorrelativoliquidacion As CUTextbox 'System.Windows.Forms.TextBox
    'System.Windows.Forms.TextBox
    Friend WithEvents txtctamensmin As CUTextbox 'System.Windows.Forms.TextBox
    Friend WithEvents txtctaanualmax As CUTextbox 'System.Windows.Forms.TextBox
    Friend WithEvents txtctaanualmin As CUTextbox 'System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    'System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox1 As CUGroupBox
    Friend WithEvents txttasamora As CUTextbox
    Friend WithEvents txttiempo As CUTextbox
    Friend WithEvents txttasa As CUTextbox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents cboModo As System.Windows.Forms.ComboBox
    Friend WithEvents tbcTerminos As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents CuGroupBox1 As CUGroupBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents CuGroupBox3 As CUGroupBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents CuGroupBox2 As CUGroupBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents CuGroupBox5 As CUGroupBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents cboTrader As System.Windows.Forms.ComboBox
    Friend WithEvents txtComentarios As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents txtprocedencia As CUTextbox
    Friend WithEvents tsbAsociarTM As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dgvPagables As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsCboPagable As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsCboPenalizable As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents dgvPenalizable As System.Windows.Forms.DataGridView
    Friend WithEvents cboSocio As System.Windows.Forms.ComboBox
    Friend WithEvents txtContacto As System.Windows.Forms.TextBox
    Friend WithEvents btnsocio As System.Windows.Forms.Button
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboCalidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents ElemP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LeyP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Min As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Max As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents undfactorp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents undpen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents liquidacionPenalizableId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btncalidad As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtctamensmax As CUTextbox
    Friend WithEvents cbotipoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dtVigenciaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtVigenciaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents lblDeposito As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents nupdMerma As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtMaquila As CUTextbox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboDeposito As System.Windows.Forms.ComboBox
    Friend WithEvents cboIncoterm As System.Windows.Forms.ComboBox
    Friend WithEvents txtref1 As CUTextbox
    Friend WithEvents Elem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ley As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LeyMin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LeyMax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents undfactor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pag As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents undpag As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvTipo As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Ded As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents undded As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents undrc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents undprot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvMerc As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dgvAjuste As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dgvQP As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents liquidacionPagable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents finley As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents finprecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gbPeriodo As CUGroupBox
    Friend WithEvents lblfechaliq As System.Windows.Forms.Label
    Friend WithEvents lblperiodo As System.Windows.Forms.Label
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents cboCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents RcBasemenos As CUTextbox
    Friend WithEvents CuGroupBox4 As CUGroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents RcBasemas As CUTextbox
    Friend WithEvents RcBase As CUTextbox
    Friend WithEvents BaseCont As CUTextbox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ContMenos As CUTextbox
    Friend WithEvents ContMas As CUTextbox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
