<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class configasientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(configasientos))
        Me.tsmGuardar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbcEditar = New System.Windows.Forms.TabControl()
        Me.tbEditar = New System.Windows.Forms.TabPage()
        Me.txt11 = New System.Windows.Forms.TextBox()
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.txt10 = New System.Windows.Forms.TextBox()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.txt9 = New System.Windows.Forms.TextBox()
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.txt8 = New System.Windows.Forms.TextBox()
        Me.lbl8 = New System.Windows.Forms.Label()
        Me.txt7 = New System.Windows.Forms.TextBox()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.cboProducto = New System.Windows.Forms.ComboBox()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.txt6 = New System.Windows.Forms.TextBox()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New CUTextbox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmCancelar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.msMantenimiento = New System.Windows.Forms.MenuStrip()
        Me.gpoDetalle = New System.Windows.Forms.GroupBox()
        Me.dgvMantenimiento = New System.Windows.Forms.DataGridView()
        Me.tsMantenimiento = New System.Windows.Forms.ToolStrip()
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbModificar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.lbl12 = New System.Windows.Forms.Label()
        Me.txt12 = New System.Windows.Forms.TextBox()
        Me.dgvProducto = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dgvTipo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Campo0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Campo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Campo3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Campo4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Campo5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Campo6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Campo7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Campo8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Campo9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.campo10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.campo11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.campo12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabladetid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbcEditar.SuspendLayout()
        Me.tbEditar.SuspendLayout()
        Me.msMantenimiento.SuspendLayout()
        Me.gpoDetalle.SuspendLayout()
        CType(Me.dgvMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsmGuardar
        '
        Me.tsmGuardar.Enabled = False
        Me.tsmGuardar.Image = CType(resources.GetObject("tsmGuardar.Image"), System.Drawing.Image)
        Me.tsmGuardar.Name = "tsmGuardar"
        Me.tsmGuardar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.tsmGuardar.Size = New System.Drawing.Size(158, 22)
        Me.tsmGuardar.Text = "Guardar"
        '
        'tbcEditar
        '
        Me.tbcEditar.Controls.Add(Me.tbEditar)
        Me.tbcEditar.Location = New System.Drawing.Point(200, 200)
        Me.tbcEditar.Name = "tbcEditar"
        Me.tbcEditar.SelectedIndex = 0
        Me.tbcEditar.Size = New System.Drawing.Size(532, 367)
        Me.tbcEditar.TabIndex = 10
        Me.tbcEditar.Visible = False
        '
        'tbEditar
        '
        Me.tbEditar.Controls.Add(Me.txt12)
        Me.tbEditar.Controls.Add(Me.lbl12)
        Me.tbEditar.Controls.Add(Me.txt11)
        Me.tbEditar.Controls.Add(Me.lbl11)
        Me.tbEditar.Controls.Add(Me.txt10)
        Me.tbEditar.Controls.Add(Me.lbl10)
        Me.tbEditar.Controls.Add(Me.txt9)
        Me.tbEditar.Controls.Add(Me.lbl9)
        Me.tbEditar.Controls.Add(Me.txt8)
        Me.tbEditar.Controls.Add(Me.lbl8)
        Me.tbEditar.Controls.Add(Me.txt7)
        Me.tbEditar.Controls.Add(Me.lbl7)
        Me.tbEditar.Controls.Add(Me.cboProducto)
        Me.tbEditar.Controls.Add(Me.cboTipo)
        Me.tbEditar.Controls.Add(Me.txt6)
        Me.tbEditar.Controls.Add(Me.txt5)
        Me.tbEditar.Controls.Add(Me.txt4)
        Me.tbEditar.Controls.Add(Me.txt3)
        Me.tbEditar.Controls.Add(Me.lbl6)
        Me.tbEditar.Controls.Add(Me.txtCodigo)
        Me.tbEditar.Controls.Add(Me.lbl5)
        Me.tbEditar.Controls.Add(Me.lbl4)
        Me.tbEditar.Controls.Add(Me.txtDescripcion)
        Me.tbEditar.Controls.Add(Me.lbl3)
        Me.tbEditar.Controls.Add(Me.lbl2)
        Me.tbEditar.Controls.Add(Me.lbl1)
        Me.tbEditar.Controls.Add(Me.btnCancelar)
        Me.tbEditar.Controls.Add(Me.btnGuardar)
        Me.tbEditar.Location = New System.Drawing.Point(4, 22)
        Me.tbEditar.Name = "tbEditar"
        Me.tbEditar.Padding = New System.Windows.Forms.Padding(3)
        Me.tbEditar.Size = New System.Drawing.Size(524, 341)
        Me.tbEditar.TabIndex = 0
        Me.tbEditar.Text = "Editando Registro"
        Me.tbEditar.UseVisualStyleBackColor = True
        '
        'txt11
        '
        Me.txt11.Location = New System.Drawing.Point(380, 173)
        Me.txt11.MaxLength = 10
        Me.txt11.Name = "txt11"
        Me.txt11.Size = New System.Drawing.Size(120, 20)
        Me.txt11.TabIndex = 32
        '
        'lbl11
        '
        Me.lbl11.AutoSize = True
        Me.lbl11.Location = New System.Drawing.Point(284, 180)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(70, 13)
        Me.lbl11.TabIndex = 33
        Me.lbl11.Text = "Contrapartida"
        '
        'txt10
        '
        Me.txt10.Location = New System.Drawing.Point(380, 147)
        Me.txt10.MaxLength = 10
        Me.txt10.Name = "txt10"
        Me.txt10.Size = New System.Drawing.Size(120, 20)
        Me.txt10.TabIndex = 30
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        Me.lbl10.Location = New System.Drawing.Point(284, 154)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(70, 13)
        Me.lbl10.TabIndex = 31
        Me.lbl10.Text = "Contrapartida"
        '
        'txt9
        '
        Me.txt9.Location = New System.Drawing.Point(380, 121)
        Me.txt9.MaxLength = 10
        Me.txt9.Name = "txt9"
        Me.txt9.Size = New System.Drawing.Size(120, 20)
        Me.txt9.TabIndex = 30
        '
        'lbl9
        '
        Me.lbl9.AutoSize = True
        Me.lbl9.Location = New System.Drawing.Point(284, 128)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(70, 13)
        Me.lbl9.TabIndex = 31
        Me.lbl9.Text = "Contrapartida"
        '
        'txt8
        '
        Me.txt8.Location = New System.Drawing.Point(380, 95)
        Me.txt8.MaxLength = 10
        Me.txt8.Name = "txt8"
        Me.txt8.Size = New System.Drawing.Size(120, 20)
        Me.txt8.TabIndex = 28
        '
        'lbl8
        '
        Me.lbl8.AutoSize = True
        Me.lbl8.Location = New System.Drawing.Point(284, 102)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(70, 13)
        Me.lbl8.TabIndex = 29
        Me.lbl8.Text = "Contrapartida"
        '
        'txt7
        '
        Me.txt7.Location = New System.Drawing.Point(112, 199)
        Me.txt7.MaxLength = 10
        Me.txt7.Name = "txt7"
        Me.txt7.Size = New System.Drawing.Size(120, 20)
        Me.txt7.TabIndex = 26
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.Location = New System.Drawing.Point(13, 206)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(70, 13)
        Me.lbl7.TabIndex = 27
        Me.lbl7.Text = "Contrapartida"
        '
        'cboProducto
        '
        Me.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProducto.FormattingEnabled = True
        Me.cboProducto.Location = New System.Drawing.Point(112, 73)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Size = New System.Drawing.Size(120, 21)
        Me.cboProducto.TabIndex = 25
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(112, 46)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(120, 21)
        Me.cboTipo.TabIndex = 24
        '
        'txt6
        '
        Me.txt6.Location = New System.Drawing.Point(112, 173)
        Me.txt6.MaxLength = 10
        Me.txt6.Name = "txt6"
        Me.txt6.Size = New System.Drawing.Size(120, 20)
        Me.txt6.TabIndex = 4
        '
        'txt5
        '
        Me.txt5.Location = New System.Drawing.Point(112, 147)
        Me.txt5.MaxLength = 10
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(120, 20)
        Me.txt5.TabIndex = 4
        '
        'txt4
        '
        Me.txt4.Location = New System.Drawing.Point(112, 121)
        Me.txt4.MaxLength = 10
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(120, 20)
        Me.txt4.TabIndex = 4
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(112, 95)
        Me.txt3.MaxLength = 10
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(120, 20)
        Me.txt3.TabIndex = 4
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Location = New System.Drawing.Point(13, 180)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(70, 13)
        Me.lbl6.TabIndex = 8
        Me.lbl6.Text = "Contrapartida"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(112, 3)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(120, 20)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.Visible = False
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Location = New System.Drawing.Point(13, 154)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(70, 13)
        Me.lbl5.TabIndex = 8
        Me.lbl5.Text = "Contrapartida"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(13, 128)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(70, 13)
        Me.lbl4.TabIndex = 8
        Me.lbl4.Text = "Contrapartida"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtDescripcion.Location = New System.Drawing.Point(112, 25)
        Me.txtDescripcion.MandatoryColor = System.Drawing.Color.Empty
        Me.txtDescripcion.MandatoryField = False
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(388, 20)
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtDescripcion.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtDescripcion.VCM_CustomInputTypeString = Nothing
        Me.txtDescripcion.VCM_CustomOmmitString = Nothing
        Me.txtDescripcion.VCM_EnterFocus = True
        Me.txtDescripcion.VCM_IsValidated = False
        Me.txtDescripcion.VCM_MensajeFoco = Nothing
        Me.txtDescripcion.VCM_MuestraMensajeFoco = False
        Me.txtDescripcion.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtDescripcion.VCM_RegularExpression = Nothing
        Me.txtDescripcion.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtDescripcion.VCM_ShowMessage = True
        Me.txtDescripcion.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.AlfaNumerico
        Me.txtDescripcion.Visible = False
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(13, 102)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(70, 13)
        Me.lbl3.TabIndex = 8
        Me.lbl3.Text = "Contrapartida"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(13, 76)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(70, 13)
        Me.lbl2.TabIndex = 8
        Me.lbl2.Text = "Contrapartida"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(13, 54)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(43, 13)
        Me.lbl1.TabIndex = 4
        Me.lbl1.Text = "Destino"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(398, 244)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(102, 38)
        Me.btnCancelar.TabIndex = 23
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(287, 244)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(94, 41)
        Me.btnGuardar.TabIndex = 22
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmNuevo, Me.tsmModificar, Me.tsmEliminar, Me.ToolStripSeparator1, Me.tsmGuardar, Me.tsmCancelar, Me.ToolStripSeparator5, Me.tsmSalir})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'tsmNuevo
        '
        Me.tsmNuevo.Image = CType(resources.GetObject("tsmNuevo.Image"), System.Drawing.Image)
        Me.tsmNuevo.Name = "tsmNuevo"
        Me.tsmNuevo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.tsmNuevo.Size = New System.Drawing.Size(158, 22)
        Me.tsmNuevo.Text = "Nuevo"
        '
        'tsmModificar
        '
        Me.tsmModificar.Image = CType(resources.GetObject("tsmModificar.Image"), System.Drawing.Image)
        Me.tsmModificar.Name = "tsmModificar"
        Me.tsmModificar.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.tsmModificar.Size = New System.Drawing.Size(158, 22)
        Me.tsmModificar.Text = "Modificar"
        '
        'tsmEliminar
        '
        Me.tsmEliminar.Image = CType(resources.GetObject("tsmEliminar.Image"), System.Drawing.Image)
        Me.tsmEliminar.Name = "tsmEliminar"
        Me.tsmEliminar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.tsmEliminar.Size = New System.Drawing.Size(158, 22)
        Me.tsmEliminar.Text = "Eliminar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(155, 6)
        '
        'tsmCancelar
        '
        Me.tsmCancelar.Enabled = False
        Me.tsmCancelar.Image = CType(resources.GetObject("tsmCancelar.Image"), System.Drawing.Image)
        Me.tsmCancelar.Name = "tsmCancelar"
        Me.tsmCancelar.Size = New System.Drawing.Size(158, 22)
        Me.tsmCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(155, 6)
        '
        'tsmSalir
        '
        Me.tsmSalir.Image = CType(resources.GetObject("tsmSalir.Image"), System.Drawing.Image)
        Me.tsmSalir.Name = "tsmSalir"
        Me.tsmSalir.Size = New System.Drawing.Size(158, 22)
        Me.tsmSalir.Text = "Salir"
        '
        'msMantenimiento
        '
        Me.msMantenimiento.BackColor = System.Drawing.SystemColors.Control
        Me.msMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoToolStripMenuItem})
        Me.msMantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.msMantenimiento.Name = "msMantenimiento"
        Me.msMantenimiento.Size = New System.Drawing.Size(734, 24)
        Me.msMantenimiento.TabIndex = 9
        Me.msMantenimiento.Text = "MenuStrip1"
        '
        'gpoDetalle
        '
        Me.gpoDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoDetalle.BackColor = System.Drawing.Color.Transparent
        Me.gpoDetalle.Controls.Add(Me.dgvMantenimiento)
        Me.gpoDetalle.Location = New System.Drawing.Point(4, 67)
        Me.gpoDetalle.Name = "gpoDetalle"
        Me.gpoDetalle.Size = New System.Drawing.Size(722, 379)
        Me.gpoDetalle.TabIndex = 12
        Me.gpoDetalle.TabStop = False
        '
        'dgvMantenimiento
        '
        Me.dgvMantenimiento.AllowUserToAddRows = False
        Me.dgvMantenimiento.AllowUserToDeleteRows = False
        Me.dgvMantenimiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMantenimiento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvProducto, Me.dgvTipo, Me.Campo0, Me.Campo2, Me.Campo3, Me.Campo4, Me.Campo5, Me.Campo6, Me.Campo7, Me.Campo8, Me.Campo9, Me.campo10, Me.campo11, Me.campo12, Me.tabladetid})
        Me.dgvMantenimiento.Location = New System.Drawing.Point(6, 13)
        Me.dgvMantenimiento.Name = "dgvMantenimiento"
        Me.dgvMantenimiento.Size = New System.Drawing.Size(710, 360)
        Me.dgvMantenimiento.TabIndex = 0
        '
        'tsMantenimiento
        '
        Me.tsMantenimiento.BackColor = System.Drawing.SystemColors.Control
        Me.tsMantenimiento.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNuevo, Me.ToolStripSeparator3, Me.tsbModificar, Me.tsbEliminar, Me.ToolStripSeparator4, Me.tsbSalir})
        Me.tsMantenimiento.Location = New System.Drawing.Point(0, 24)
        Me.tsMantenimiento.Name = "tsMantenimiento"
        Me.tsMantenimiento.Size = New System.Drawing.Size(734, 39)
        Me.tsMantenimiento.TabIndex = 13
        Me.tsMantenimiento.Text = "ToolStrip1"
        '
        'tsbNuevo
        '
        Me.tsbNuevo.Image = CType(resources.GetObject("tsbNuevo.Image"), System.Drawing.Image)
        Me.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(78, 36)
        Me.tsbNuevo.Text = "Nuevo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'tsbModificar
        '
        Me.tsbModificar.Image = CType(resources.GetObject("tsbModificar.Image"), System.Drawing.Image)
        Me.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModificar.Name = "tsbModificar"
        Me.tsbModificar.Size = New System.Drawing.Size(94, 36)
        Me.tsbModificar.Text = "Modificar"
        '
        'tsbEliminar
        '
        Me.tsbEliminar.Image = CType(resources.GetObject("tsbEliminar.Image"), System.Drawing.Image)
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(86, 36)
        Me.tsbEliminar.Text = "Eliminar"
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
        'lbl12
        '
        Me.lbl12.AutoSize = True
        Me.lbl12.Location = New System.Drawing.Point(284, 206)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.Size = New System.Drawing.Size(70, 13)
        Me.lbl12.TabIndex = 33
        Me.lbl12.Text = "Contrapartida"
        '
        'txt12
        '
        Me.txt12.Location = New System.Drawing.Point(380, 199)
        Me.txt12.MaxLength = 10
        Me.txt12.Name = "txt12"
        Me.txt12.Size = New System.Drawing.Size(120, 20)
        Me.txt12.TabIndex = 32
        '
        'dgvProducto
        '
        Me.dgvProducto.DataPropertyName = "Campo1"
        Me.dgvProducto.HeaderText = "Producto"
        Me.dgvProducto.Name = "dgvProducto"
        '
        'dgvTipo
        '
        Me.dgvTipo.DataPropertyName = "Campo0"
        Me.dgvTipo.HeaderText = "Clase"
        Me.dgvTipo.Name = "dgvTipo"
        '
        'Campo0
        '
        Me.Campo0.DataPropertyName = "Campo1"
        Me.Campo0.HeaderText = "Tipo"
        Me.Campo0.Name = "Campo0"
        Me.Campo0.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Campo0.Visible = False
        '
        'Campo2
        '
        Me.Campo2.DataPropertyName = "Campo2"
        Me.Campo2.HeaderText = "Producto"
        Me.Campo2.Name = "Campo2"
        Me.Campo2.Visible = False
        '
        'Campo3
        '
        Me.Campo3.DataPropertyName = "Campo3"
        Me.Campo3.HeaderText = "Mercaderia"
        Me.Campo3.Name = "Campo3"
        '
        'Campo4
        '
        Me.Campo4.DataPropertyName = "Campo4"
        Me.Campo4.HeaderText = "Compra"
        Me.Campo4.Name = "Campo4"
        '
        'Campo5
        '
        Me.Campo5.DataPropertyName = "Campo5"
        Me.Campo5.HeaderText = "Variacion"
        Me.Campo5.Name = "Campo5"
        '
        'Campo6
        '
        Me.Campo6.DataPropertyName = "Campo6"
        Me.Campo6.HeaderText = "Impuesto"
        Me.Campo6.Name = "Campo6"
        '
        'Campo7
        '
        Me.Campo7.DataPropertyName = "Campo7"
        Me.Campo7.HeaderText = "Pasivo"
        Me.Campo7.Name = "Campo7"
        '
        'Campo8
        '
        Me.Campo8.DataPropertyName = "Campo8"
        Me.Campo8.HeaderText = "Costo"
        Me.Campo8.Name = "Campo8"
        '
        'Campo9
        '
        Me.Campo9.DataPropertyName = "Campo9"
        Me.Campo9.HeaderText = "Doc No Emitido"
        Me.Campo9.Name = "Campo9"
        '
        'campo10
        '
        Me.campo10.DataPropertyName = "campo10"
        Me.campo10.HeaderText = "Mezcla"
        Me.campo10.Name = "campo10"
        '
        'campo11
        '
        Me.campo11.DataPropertyName = "campo11"
        Me.campo11.HeaderText = "Vinculada"
        Me.campo11.Name = "campo11"
        '
        'campo12
        '
        Me.campo12.DataPropertyName = "campo12"
        Me.campo12.HeaderText = "Transfer"
        Me.campo12.Name = "campo12"
        '
        'tabladetid
        '
        Me.tabladetid.DataPropertyName = "tabladetid"
        Me.tabladetid.HeaderText = "tabladetid"
        Me.tabladetid.Name = "tabladetid"
        Me.tabladetid.Visible = False
        '
        'configasientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 447)
        Me.Controls.Add(Me.tsMantenimiento)
        Me.Controls.Add(Me.tbcEditar)
        Me.Controls.Add(Me.msMantenimiento)
        Me.Controls.Add(Me.gpoDetalle)
        Me.Name = "configasientos"
        Me.Text = "Configurador de Cuentas"
        Me.tbcEditar.ResumeLayout(False)
        Me.tbEditar.ResumeLayout(False)
        Me.tbEditar.PerformLayout()
        Me.msMantenimiento.ResumeLayout(False)
        Me.msMantenimiento.PerformLayout()
        Me.gpoDetalle.ResumeLayout(False)
        CType(Me.dgvMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMantenimiento.ResumeLayout(False)
        Me.tsMantenimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsmGuardar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbcEditar As System.Windows.Forms.TabControl
    Friend WithEvents tbEditar As System.Windows.Forms.TabPage
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As CUTextbox
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents MantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmCancelar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msMantenimiento As System.Windows.Forms.MenuStrip
    Friend WithEvents gpoDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents dgvMantenimiento As System.Windows.Forms.DataGridView
    Friend WithEvents tsMantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents txt6 As System.Windows.Forms.TextBox
    Friend WithEvents txt5 As System.Windows.Forms.TextBox
    Friend WithEvents txt4 As System.Windows.Forms.TextBox
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents cboProducto As System.Windows.Forms.ComboBox
    Friend WithEvents txt9 As System.Windows.Forms.TextBox
    Friend WithEvents lbl9 As System.Windows.Forms.Label
    Friend WithEvents txt8 As System.Windows.Forms.TextBox
    Friend WithEvents lbl8 As System.Windows.Forms.Label
    Friend WithEvents txt7 As System.Windows.Forms.TextBox
    Friend WithEvents lbl7 As System.Windows.Forms.Label
    Friend WithEvents txt10 As System.Windows.Forms.TextBox
    Friend WithEvents lbl10 As System.Windows.Forms.Label
    Friend WithEvents txt11 As System.Windows.Forms.TextBox
    Friend WithEvents lbl11 As System.Windows.Forms.Label
    Friend WithEvents txt12 As System.Windows.Forms.TextBox
    Friend WithEvents lbl12 As System.Windows.Forms.Label
    Friend WithEvents dgvProducto As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dgvTipo As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Campo0 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Campo2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Campo3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Campo4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Campo5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Campo6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Campo7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Campo8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Campo9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents campo10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents campo11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents campo12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tabladetid As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
