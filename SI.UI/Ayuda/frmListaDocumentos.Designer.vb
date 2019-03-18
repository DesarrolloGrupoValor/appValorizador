<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaDocumentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaDocumentos))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboFiltro = New System.Windows.Forms.ComboBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.gpoFiltro = New System.Windows.Forms.GroupBox()
        Me.gpoDetalle = New System.Windows.Forms.GroupBox()
        Me.dgvDIG_INDICERO = New System.Windows.Forms.DataGridView()
        Me.lblReg = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ContenidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÍndiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AcercadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeshacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RehacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SeleccionartodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarcomoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VistapreviadeimpresiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IDITEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTIPODOC_DIG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRO_DOC_INTERNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRO_DOC_EXTERNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RUMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BENEFICIARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFERENCIA1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARCHIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DES_TIPODOC_DIG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RUTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_DOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDFLUJO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DES_IDFLUJO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTRATO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPRESA_RS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPRESA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROVEEDOR_RS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROVEEDOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTRATO_LIQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOTE_LIQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LIQUIDACION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PC_CREADOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_CREA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PC_ULT_MODIF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_ULT_MODIF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContratoLoteId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LiquidacionId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDITEM_ORIGEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADO_DESC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gpoFiltro.SuspendLayout()
        Me.gpoDetalle.SuspendLayout()
        CType(Me.dgvDIG_INDICERO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filtro por"
        '
        'cboFiltro
        '
        Me.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFiltro.FormattingEnabled = True
        Me.cboFiltro.Location = New System.Drawing.Point(60, 13)
        Me.cboFiltro.Name = "cboFiltro"
        Me.cboFiltro.Size = New System.Drawing.Size(121, 21)
        Me.cboFiltro.TabIndex = 1
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(187, 13)
        Me.txtBuscar.MaxLength = 20
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(280, 20)
        Me.txtBuscar.TabIndex = 2
        '
        'gpoFiltro
        '
        Me.gpoFiltro.Controls.Add(Me.Label1)
        Me.gpoFiltro.Controls.Add(Me.cboFiltro)
        Me.gpoFiltro.Controls.Add(Me.txtBuscar)
        Me.gpoFiltro.Location = New System.Drawing.Point(2, 3)
        Me.gpoFiltro.Name = "gpoFiltro"
        Me.gpoFiltro.Size = New System.Drawing.Size(649, 48)
        Me.gpoFiltro.TabIndex = 4
        Me.gpoFiltro.TabStop = False
        '
        'gpoDetalle
        '
        Me.gpoDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoDetalle.Controls.Add(Me.dgvDIG_INDICERO)
        Me.gpoDetalle.Location = New System.Drawing.Point(2, 57)
        Me.gpoDetalle.Name = "gpoDetalle"
        Me.gpoDetalle.Size = New System.Drawing.Size(996, 381)
        Me.gpoDetalle.TabIndex = 5
        Me.gpoDetalle.TabStop = False
        Me.gpoDetalle.Text = "Detalle"
        '
        'dgvDIG_INDICERO
        '
        Me.dgvDIG_INDICERO.AllowUserToAddRows = False
        Me.dgvDIG_INDICERO.AllowUserToDeleteRows = False
        Me.dgvDIG_INDICERO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDIG_INDICERO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDIG_INDICERO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDITEM, Me.IDTIPODOC_DIG, Me.NRO_DOC_INTERNO, Me.NRO_DOC_EXTERNO, Me.RUMA, Me.BENEFICIARIO, Me.REFERENCIA1, Me.ARCHIVO, Me.DES_TIPODOC_DIG, Me.RUTA, Me.FECHA_DOC, Me.IDFLUJO, Me.DES_IDFLUJO, Me.CONTRATO, Me.LOTE, Me.EMPRESA_RS, Me.EMPRESA, Me.PROVEEDOR_RS, Me.PROVEEDOR, Me.CONTRATO_LIQ, Me.LOTE_LIQ, Me.LIQUIDACION, Me.PC_CREADOR, Me.FECHA_CREA, Me.PC_ULT_MODIF, Me.FECHA_ULT_MODIF, Me.ContratoLoteId, Me.LiquidacionId, Me.IDITEM_ORIGEN, Me.ESTADO_DESC})
        Me.dgvDIG_INDICERO.Location = New System.Drawing.Point(10, 19)
        Me.dgvDIG_INDICERO.Name = "dgvDIG_INDICERO"
        Me.dgvDIG_INDICERO.ReadOnly = True
        Me.dgvDIG_INDICERO.RowHeadersWidth = 10
        Me.dgvDIG_INDICERO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDIG_INDICERO.Size = New System.Drawing.Size(980, 356)
        Me.dgvDIG_INDICERO.TabIndex = 0
        '
        'lblReg
        '
        Me.lblReg.AutoSize = True
        Me.lblReg.Location = New System.Drawing.Point(9, 454)
        Me.lblReg.Name = "lblReg"
        Me.lblReg.Size = New System.Drawing.Size(0, 13)
        Me.lblReg.TabIndex = 0
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(469, 444)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(576, 444)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(60, 13)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'ContenidoToolStripMenuItem
        '
        Me.ContenidoToolStripMenuItem.Name = "ContenidoToolStripMenuItem"
        Me.ContenidoToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.ContenidoToolStripMenuItem.Text = "&Contenido"
        '
        'ÍndiceToolStripMenuItem
        '
        Me.ÍndiceToolStripMenuItem.Name = "ÍndiceToolStripMenuItem"
        Me.ÍndiceToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.ÍndiceToolStripMenuItem.Text = "Índic&e"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.BuscarToolStripMenuItem.Text = "&Buscar"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 6)
        '
        'AcercadeToolStripMenuItem
        '
        Me.AcercadeToolStripMenuItem.Name = "AcercadeToolStripMenuItem"
        Me.AcercadeToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.AcercadeToolStripMenuItem.Text = "&Acerca de..."
        '
        'PersonalizarToolStripMenuItem
        '
        Me.PersonalizarToolStripMenuItem.Name = "PersonalizarToolStripMenuItem"
        Me.PersonalizarToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.PersonalizarToolStripMenuItem.Text = "&Personalizar"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.OpcionesToolStripMenuItem.Text = "&Opciones"
        '
        'DeshacerToolStripMenuItem
        '
        Me.DeshacerToolStripMenuItem.Name = "DeshacerToolStripMenuItem"
        Me.DeshacerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.DeshacerToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.DeshacerToolStripMenuItem.Text = "&Deshacer"
        '
        'RehacerToolStripMenuItem
        '
        Me.RehacerToolStripMenuItem.Name = "RehacerToolStripMenuItem"
        Me.RehacerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RehacerToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.RehacerToolStripMenuItem.Text = "&Rehacer"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 6)
        '
        'CortarToolStripMenuItem
        '
        Me.CortarToolStripMenuItem.Image = CType(resources.GetObject("CortarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CortarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        Me.CortarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CortarToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.CortarToolStripMenuItem.Text = "Cor&tar"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Image = CType(resources.GetObject("CopiarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopiarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.CopiarToolStripMenuItem.Text = "&Copiar"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Image = CType(resources.GetObject("PegarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PegarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.PegarToolStripMenuItem.Text = "&Pegar"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(6, 6)
        '
        'SeleccionartodoToolStripMenuItem
        '
        Me.SeleccionartodoToolStripMenuItem.Name = "SeleccionartodoToolStripMenuItem"
        Me.SeleccionartodoToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.SeleccionartodoToolStripMenuItem.Text = "&Seleccionar todo"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Image = CType(resources.GetObject("NuevoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NuevoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.NuevoToolStripMenuItem.Text = "&Nuevo"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Image = CType(resources.GetObject("AbrirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AbrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.AbrirToolStripMenuItem.Text = "&Abrir"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 6)
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Image = CType(resources.GetObject("GuardarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GuardarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.GuardarToolStripMenuItem.Text = "&Guardar"
        '
        'GuardarcomoToolStripMenuItem
        '
        Me.GuardarcomoToolStripMenuItem.Name = "GuardarcomoToolStripMenuItem"
        Me.GuardarcomoToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.GuardarcomoToolStripMenuItem.Text = "G&uardar como"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Image = CType(resources.GetObject("ImprimirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImprimirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.ImprimirToolStripMenuItem.Text = "&Imprimir"
        '
        'VistapreviadeimpresiónToolStripMenuItem
        '
        Me.VistapreviadeimpresiónToolStripMenuItem.Image = CType(resources.GetObject("VistapreviadeimpresiónToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VistapreviadeimpresiónToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.VistapreviadeimpresiónToolStripMenuItem.Name = "VistapreviadeimpresiónToolStripMenuItem"
        Me.VistapreviadeimpresiónToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.VistapreviadeimpresiónToolStripMenuItem.Text = "&Vista previa de impresión"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'IDITEM
        '
        Me.IDITEM.DataPropertyName = "IDITEM"
        Me.IDITEM.HeaderText = "IDITEM"
        Me.IDITEM.Name = "IDITEM"
        Me.IDITEM.ReadOnly = True
        Me.IDITEM.Visible = False
        '
        'IDTIPODOC_DIG
        '
        Me.IDTIPODOC_DIG.DataPropertyName = "IDTIPODOC_DIG"
        Me.IDTIPODOC_DIG.HeaderText = "IDTIPODOC_DIG"
        Me.IDTIPODOC_DIG.Name = "IDTIPODOC_DIG"
        Me.IDTIPODOC_DIG.ReadOnly = True
        Me.IDTIPODOC_DIG.Visible = False
        '
        'NRO_DOC_INTERNO
        '
        Me.NRO_DOC_INTERNO.DataPropertyName = "NRO_DOC_INTERNO"
        Me.NRO_DOC_INTERNO.HeaderText = "N° Interno"
        Me.NRO_DOC_INTERNO.Name = "NRO_DOC_INTERNO"
        Me.NRO_DOC_INTERNO.ReadOnly = True
        '
        'NRO_DOC_EXTERNO
        '
        Me.NRO_DOC_EXTERNO.DataPropertyName = "NRO_DOC_EXTERNO"
        Me.NRO_DOC_EXTERNO.HeaderText = "N° Externo"
        Me.NRO_DOC_EXTERNO.Name = "NRO_DOC_EXTERNO"
        Me.NRO_DOC_EXTERNO.ReadOnly = True
        '
        'RUMA
        '
        Me.RUMA.DataPropertyName = "RUMA"
        Me.RUMA.HeaderText = "Ruma"
        Me.RUMA.Name = "RUMA"
        Me.RUMA.ReadOnly = True
        '
        'BENEFICIARIO
        '
        Me.BENEFICIARIO.DataPropertyName = "BENEFICIARIO"
        Me.BENEFICIARIO.HeaderText = "Beneficiario"
        Me.BENEFICIARIO.Name = "BENEFICIARIO"
        Me.BENEFICIARIO.ReadOnly = True
        '
        'REFERENCIA1
        '
        Me.REFERENCIA1.DataPropertyName = "REFERENCIA1"
        Me.REFERENCIA1.HeaderText = "Referencia 1"
        Me.REFERENCIA1.Name = "REFERENCIA1"
        Me.REFERENCIA1.ReadOnly = True
        '
        'ARCHIVO
        '
        Me.ARCHIVO.DataPropertyName = "ARCHIVO"
        Me.ARCHIVO.HeaderText = "Archivo"
        Me.ARCHIVO.Name = "ARCHIVO"
        Me.ARCHIVO.ReadOnly = True
        Me.ARCHIVO.Width = 350
        '
        'DES_TIPODOC_DIG
        '
        Me.DES_TIPODOC_DIG.DataPropertyName = "DES_TIPODOC_DIG"
        Me.DES_TIPODOC_DIG.HeaderText = "Tipo"
        Me.DES_TIPODOC_DIG.Name = "DES_TIPODOC_DIG"
        Me.DES_TIPODOC_DIG.ReadOnly = True
        '
        'RUTA
        '
        Me.RUTA.DataPropertyName = "RUTA"
        Me.RUTA.HeaderText = "RUTA"
        Me.RUTA.Name = "RUTA"
        Me.RUTA.ReadOnly = True
        Me.RUTA.Visible = False
        '
        'FECHA_DOC
        '
        Me.FECHA_DOC.DataPropertyName = "FECHA_DOC"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.FECHA_DOC.DefaultCellStyle = DataGridViewCellStyle2
        Me.FECHA_DOC.HeaderText = "Fec. Doc."
        Me.FECHA_DOC.Name = "FECHA_DOC"
        Me.FECHA_DOC.ReadOnly = True
        Me.FECHA_DOC.Width = 80
        '
        'IDFLUJO
        '
        Me.IDFLUJO.DataPropertyName = "IDFLUJO"
        Me.IDFLUJO.HeaderText = "IDFLUJO"
        Me.IDFLUJO.Name = "IDFLUJO"
        Me.IDFLUJO.ReadOnly = True
        Me.IDFLUJO.Visible = False
        '
        'DES_IDFLUJO
        '
        Me.DES_IDFLUJO.DataPropertyName = "DES_IDFLUJO"
        Me.DES_IDFLUJO.HeaderText = "Flujo"
        Me.DES_IDFLUJO.Name = "DES_IDFLUJO"
        Me.DES_IDFLUJO.ReadOnly = True
        '
        'CONTRATO
        '
        Me.CONTRATO.DataPropertyName = "CONTRATO"
        Me.CONTRATO.HeaderText = "Contrato"
        Me.CONTRATO.Name = "CONTRATO"
        Me.CONTRATO.ReadOnly = True
        Me.CONTRATO.Width = 50
        '
        'LOTE
        '
        Me.LOTE.DataPropertyName = "LOTE"
        Me.LOTE.HeaderText = "Lote"
        Me.LOTE.Name = "LOTE"
        Me.LOTE.ReadOnly = True
        Me.LOTE.Width = 80
        '
        'EMPRESA_RS
        '
        Me.EMPRESA_RS.DataPropertyName = "EMPRESA_RS"
        Me.EMPRESA_RS.HeaderText = "Empresa"
        Me.EMPRESA_RS.Name = "EMPRESA_RS"
        Me.EMPRESA_RS.ReadOnly = True
        '
        'EMPRESA
        '
        Me.EMPRESA.DataPropertyName = "EMPRESA"
        Me.EMPRESA.HeaderText = "EMPRESA"
        Me.EMPRESA.Name = "EMPRESA"
        Me.EMPRESA.ReadOnly = True
        Me.EMPRESA.Visible = False
        '
        'PROVEEDOR_RS
        '
        Me.PROVEEDOR_RS.DataPropertyName = "PROVEEDOR_RS"
        Me.PROVEEDOR_RS.HeaderText = "Proveedor"
        Me.PROVEEDOR_RS.Name = "PROVEEDOR_RS"
        Me.PROVEEDOR_RS.ReadOnly = True
        Me.PROVEEDOR_RS.Width = 200
        '
        'PROVEEDOR
        '
        Me.PROVEEDOR.DataPropertyName = "PROVEEDOR"
        Me.PROVEEDOR.HeaderText = "PROVEEDOR"
        Me.PROVEEDOR.Name = "PROVEEDOR"
        Me.PROVEEDOR.ReadOnly = True
        Me.PROVEEDOR.Visible = False
        Me.PROVEEDOR.Width = 200
        '
        'CONTRATO_LIQ
        '
        Me.CONTRATO_LIQ.DataPropertyName = "CONTRATO_LIQ"
        Me.CONTRATO_LIQ.HeaderText = "Contrato Liq"
        Me.CONTRATO_LIQ.Name = "CONTRATO_LIQ"
        Me.CONTRATO_LIQ.ReadOnly = True
        '
        'LOTE_LIQ
        '
        Me.LOTE_LIQ.DataPropertyName = "LOTE_LIQ"
        Me.LOTE_LIQ.HeaderText = "Lote Liq"
        Me.LOTE_LIQ.Name = "LOTE_LIQ"
        Me.LOTE_LIQ.ReadOnly = True
        '
        'LIQUIDACION
        '
        Me.LIQUIDACION.DataPropertyName = "LIQUIDACION"
        Me.LIQUIDACION.HeaderText = "Liquidacion"
        Me.LIQUIDACION.Name = "LIQUIDACION"
        Me.LIQUIDACION.ReadOnly = True
        '
        'PC_CREADOR
        '
        Me.PC_CREADOR.DataPropertyName = "PC_CREADOR"
        Me.PC_CREADOR.HeaderText = "PC_CREADOR"
        Me.PC_CREADOR.Name = "PC_CREADOR"
        Me.PC_CREADOR.ReadOnly = True
        Me.PC_CREADOR.Visible = False
        '
        'FECHA_CREA
        '
        Me.FECHA_CREA.DataPropertyName = "FECHA_CREA"
        Me.FECHA_CREA.HeaderText = "FECHA_CREA"
        Me.FECHA_CREA.Name = "FECHA_CREA"
        Me.FECHA_CREA.ReadOnly = True
        Me.FECHA_CREA.Visible = False
        '
        'PC_ULT_MODIF
        '
        Me.PC_ULT_MODIF.DataPropertyName = "PC_ULT_MODIF"
        Me.PC_ULT_MODIF.HeaderText = "PC_ULT_MODIF"
        Me.PC_ULT_MODIF.Name = "PC_ULT_MODIF"
        Me.PC_ULT_MODIF.ReadOnly = True
        Me.PC_ULT_MODIF.Visible = False
        '
        'FECHA_ULT_MODIF
        '
        Me.FECHA_ULT_MODIF.DataPropertyName = "FECHA_ULT_MODIF"
        Me.FECHA_ULT_MODIF.HeaderText = "FECHA_ULT_MODIF"
        Me.FECHA_ULT_MODIF.Name = "FECHA_ULT_MODIF"
        Me.FECHA_ULT_MODIF.ReadOnly = True
        Me.FECHA_ULT_MODIF.Visible = False
        '
        'ContratoLoteId
        '
        Me.ContratoLoteId.DataPropertyName = "ContratoLoteId"
        Me.ContratoLoteId.HeaderText = "ContratoLoteId"
        Me.ContratoLoteId.Name = "ContratoLoteId"
        Me.ContratoLoteId.ReadOnly = True
        Me.ContratoLoteId.Visible = False
        '
        'LiquidacionId
        '
        Me.LiquidacionId.DataPropertyName = "LiquidacionId"
        Me.LiquidacionId.HeaderText = "LiquidacionId"
        Me.LiquidacionId.Name = "LiquidacionId"
        Me.LiquidacionId.ReadOnly = True
        Me.LiquidacionId.Visible = False
        '
        'IDITEM_ORIGEN
        '
        Me.IDITEM_ORIGEN.DataPropertyName = "IDITEM_ORIGEN"
        Me.IDITEM_ORIGEN.HeaderText = "IDITEM_ORIGEN"
        Me.IDITEM_ORIGEN.Name = "IDITEM_ORIGEN"
        Me.IDITEM_ORIGEN.ReadOnly = True
        Me.IDITEM_ORIGEN.Visible = False
        '
        'ESTADO_DESC
        '
        Me.ESTADO_DESC.DataPropertyName = "ESTADO_DESC"
        Me.ESTADO_DESC.HeaderText = "Estado"
        Me.ESTADO_DESC.Name = "ESTADO_DESC"
        Me.ESTADO_DESC.ReadOnly = True
        '
        'frmListaDocumentos
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(1006, 471)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblReg)
        Me.Controls.Add(Me.gpoDetalle)
        Me.Controls.Add(Me.gpoFiltro)
        Me.KeyPreview = True
        Me.Name = "frmListaDocumentos"
        Me.Text = "Lista Documentos"
        Me.gpoFiltro.ResumeLayout(False)
        Me.gpoFiltro.PerformLayout()
        Me.gpoDetalle.ResumeLayout(False)
        CType(Me.dgvDIG_INDICERO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents gpoFiltro As System.Windows.Forms.GroupBox
    Friend WithEvents gpoDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents lblReg As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ContenidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÍndiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AcercadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonalizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeshacerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RehacerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CortarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SeleccionartodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarcomoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VistapreviadeimpresiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvDIG_INDICERO As System.Windows.Forms.DataGridView
    Friend WithEvents IDITEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDTIPODOC_DIG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRO_DOC_INTERNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRO_DOC_EXTERNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RUMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BENEFICIARIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFERENCIA1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ARCHIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DES_TIPODOC_DIG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RUTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA_DOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDFLUJO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DES_IDFLUJO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONTRATO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LOTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPRESA_RS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPRESA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROVEEDOR_RS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROVEEDOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONTRATO_LIQ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LOTE_LIQ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LIQUIDACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PC_CREADOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA_CREA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PC_ULT_MODIF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA_ULT_MODIF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContratoLoteId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LiquidacionId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDITEM_ORIGEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTADO_DESC As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
