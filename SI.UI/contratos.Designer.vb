﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class contratos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(contratos))
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ContratoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmCopiar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmRefrescar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsMantenimiento = New System.Windows.Forms.ToolStrip()
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbModificar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCopiar = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbContratoLoteP = New System.Windows.Forms.ToolStripButton()
        Me.tsbContratoLoteS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbLimpiarFiltro = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gpoFacturacion = New CUGroupBox()
        Me.nupdPorcPago = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.gpoPagable = New CUGroupBox()
        Me.dgvPagables = New System.Windows.Forms.DataGridView()
        Me.Elem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ley = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTipo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Ded = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvMerc = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dgvQP = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.gpoPenalizable = New CUGroupBox()
        Me.dgvPenalizable = New System.Windows.Forms.DataGridView()
        Me.ElemP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeyP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Min = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Max = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gpoParticipacion = New CUGroupBox()
        Me.nupdPorcentaje = New System.Windows.Forms.NumericUpDown()
        Me.txtbasepart = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gpoContratos = New CUGroupBox()
        Me.cboTipoContrato = New System.Windows.Forms.ComboBox()
        Me.cboProducto = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.fxgrdContrato = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.gpoTerminos = New CUGroupBox()
        Me.nupdMerma = New System.Windows.Forms.NumericUpDown()
        Me.txtctamensmax = New System.Windows.Forms.TextBox()
        Me.txtctamensmin = New System.Windows.Forms.TextBox()
        Me.txtctaanualmax = New System.Windows.Forms.TextBox()
        Me.txtctaanualmin = New System.Windows.Forms.TextBox()
        Me.txtMaquila = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gpoEscalador = New CUGroupBox()
        Me.txtbasemenos2 = New System.Windows.Forms.TextBox()
        Me.txtbasemas2 = New System.Windows.Forms.TextBox()
        Me.txtbasemenos1 = New System.Windows.Forms.TextBox()
        Me.txtbase2 = New System.Windows.Forms.TextBox()
        Me.txtbasemas1 = New System.Windows.Forms.TextBox()
        Me.txtbase1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CuGroupBox1 = New CUGroupBox()
        Me.cboDeposito = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtMaquila2 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtMerma = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.tsMantenimiento.SuspendLayout()
        Me.gpoFacturacion.SuspendLayout()
        CType(Me.nupdPorcPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoPagable.SuspendLayout()
        CType(Me.dgvPagables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoPenalizable.SuspendLayout()
        CType(Me.dgvPenalizable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoParticipacion.SuspendLayout()
        CType(Me.nupdPorcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoContratos.SuspendLayout()
        CType(Me.fxgrdContrato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoTerminos.SuspendLayout()
        CType(Me.nupdMerma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoEscalador.SuspendLayout()
        Me.CuGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContratoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1028, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'ContratoToolStripMenuItem
        '
        Me.ContratoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmNuevo, Me.ToolStripSeparator1, Me.tsmModificar, Me.tsmEliminar, Me.ToolStripSeparator2, Me.tsmCopiar, Me.tsmRefrescar, Me.ToolStripSeparator6, Me.tsmSalir})
        Me.ContratoToolStripMenuItem.Name = "ContratoToolStripMenuItem"
        Me.ContratoToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ContratoToolStripMenuItem.Text = "Contrato"
        '
        'tsmNuevo
        '
        Me.tsmNuevo.Image = CType(resources.GetObject("tsmNuevo.Image"), System.Drawing.Image)
        Me.tsmNuevo.Name = "tsmNuevo"
        Me.tsmNuevo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.tsmNuevo.Size = New System.Drawing.Size(157, 22)
        Me.tsmNuevo.Text = "Nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(154, 6)
        '
        'tsmModificar
        '
        Me.tsmModificar.Image = CType(resources.GetObject("tsmModificar.Image"), System.Drawing.Image)
        Me.tsmModificar.Name = "tsmModificar"
        Me.tsmModificar.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.tsmModificar.Size = New System.Drawing.Size(157, 22)
        Me.tsmModificar.Text = "Modificar"
        '
        'tsmEliminar
        '
        Me.tsmEliminar.Name = "tsmEliminar"
        Me.tsmEliminar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.tsmEliminar.Size = New System.Drawing.Size(157, 22)
        Me.tsmEliminar.Text = "Eliminar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(154, 6)
        '
        'tsmCopiar
        '
        Me.tsmCopiar.Name = "tsmCopiar"
        Me.tsmCopiar.Size = New System.Drawing.Size(157, 22)
        Me.tsmCopiar.Text = "Copiar"
        '
        'tsmRefrescar
        '
        Me.tsmRefrescar.Name = "tsmRefrescar"
        Me.tsmRefrescar.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.tsmRefrescar.Size = New System.Drawing.Size(157, 22)
        Me.tsmRefrescar.Text = "Refrescar"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(154, 6)
        '
        'tsmSalir
        '
        Me.tsmSalir.Image = CType(resources.GetObject("tsmSalir.Image"), System.Drawing.Image)
        Me.tsmSalir.Name = "tsmSalir"
        Me.tsmSalir.Size = New System.Drawing.Size(157, 22)
        Me.tsmSalir.Text = "Salir"
        '
        'tsMantenimiento
        '
        Me.tsMantenimiento.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNuevo, Me.ToolStripSeparator4, Me.tsbModificar, Me.tsbEliminar, Me.ToolStripSeparator3, Me.tsbCopiar, Me.tsbRefrescar, Me.ToolStripSeparator5, Me.tsbContratoLoteP, Me.tsbContratoLoteS, Me.ToolStripSeparator7, Me.tsbLimpiarFiltro, Me.ToolStripSeparator8, Me.tsbSalir})
        Me.tsMantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.tsMantenimiento.Name = "tsMantenimiento"
        Me.tsMantenimiento.Size = New System.Drawing.Size(1028, 39)
        Me.tsMantenimiento.TabIndex = 1
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'tsbModificar
        '
        Me.tsbModificar.Image = CType(resources.GetObject("tsbModificar.Image"), System.Drawing.Image)
        Me.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModificar.Name = "tsbModificar"
        Me.tsbModificar.Size = New System.Drawing.Size(73, 36)
        Me.tsbModificar.Text = "Editar"
        '
        'tsbEliminar
        '
        Me.tsbEliminar.Image = CType(resources.GetObject("tsbEliminar.Image"), System.Drawing.Image)
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(78, 36)
        Me.tsbEliminar.Text = "Anular"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'tsbCopiar
        '
        Me.tsbCopiar.Image = CType(resources.GetObject("tsbCopiar.Image"), System.Drawing.Image)
        Me.tsbCopiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCopiar.Name = "tsbCopiar"
        Me.tsbCopiar.Size = New System.Drawing.Size(78, 36)
        Me.tsbCopiar.Text = "Copiar"
        '
        'tsbRefrescar
        '
        Me.tsbRefrescar.Image = CType(resources.GetObject("tsbRefrescar.Image"), System.Drawing.Image)
        Me.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRefrescar.Name = "tsbRefrescar"
        Me.tsbRefrescar.Size = New System.Drawing.Size(91, 36)
        Me.tsbRefrescar.Text = "Refrescar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 39)
        '
        'tsbContratoLoteP
        '
        Me.tsbContratoLoteP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbContratoLoteP.Image = CType(resources.GetObject("tsbContratoLoteP.Image"), System.Drawing.Image)
        Me.tsbContratoLoteP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbContratoLoteP.Name = "tsbContratoLoteP"
        Me.tsbContratoLoteP.Size = New System.Drawing.Size(36, 36)
        Me.tsbContratoLoteP.Text = "Generar Lote P"
        '
        'tsbContratoLoteS
        '
        Me.tsbContratoLoteS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbContratoLoteS.Image = CType(resources.GetObject("tsbContratoLoteS.Image"), System.Drawing.Image)
        Me.tsbContratoLoteS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbContratoLoteS.Name = "tsbContratoLoteS"
        Me.tsbContratoLoteS.Size = New System.Drawing.Size(36, 36)
        Me.tsbContratoLoteS.Text = "Generar Lote S"
        Me.tsbContratoLoteS.Visible = False
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 39)
        '
        'tsbLimpiarFiltro
        '
        Me.tsbLimpiarFiltro.Image = Global.My.Resources.Resources.quitarFiltro
        Me.tsbLimpiarFiltro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLimpiarFiltro.Name = "tsbLimpiarFiltro"
        Me.tsbLimpiarFiltro.Size = New System.Drawing.Size(113, 36)
        Me.tsbLimpiarFiltro.Text = "Limpiar Filtro"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 39)
        '
        'tsbSalir
        '
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(65, 36)
        Me.tsbSalir.Text = "Salir"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(963, 434)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(64, 63)
        Me.Panel1.TabIndex = 7
        '
        'gpoFacturacion
        '
        Me.gpoFacturacion.BackColor = System.Drawing.Color.Transparent
        Me.gpoFacturacion.BorderColor = System.Drawing.Color.Black
        Me.gpoFacturacion.Controls.Add(Me.nupdPorcPago)
        Me.gpoFacturacion.Controls.Add(Me.Label13)
        Me.gpoFacturacion.Enabled = False
        Me.gpoFacturacion.Location = New System.Drawing.Point(865, 432)
        Me.gpoFacturacion.Name = "gpoFacturacion"
        Me.gpoFacturacion.Size = New System.Drawing.Size(92, 65)
        Me.gpoFacturacion.TabIndex = 6
        Me.gpoFacturacion.TabStop = False
        Me.gpoFacturacion.Text = "Facturacion"
        '
        'nupdPorcPago
        '
        Me.nupdPorcPago.Location = New System.Drawing.Point(9, 36)
        Me.nupdPorcPago.Name = "nupdPorcPago"
        Me.nupdPorcPago.Size = New System.Drawing.Size(66, 20)
        Me.nupdPorcPago.TabIndex = 1
        Me.nupdPorcPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "% de Pago"
        '
        'gpoPagable
        '
        Me.gpoPagable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoPagable.BackColor = System.Drawing.Color.Transparent
        Me.gpoPagable.BorderColor = System.Drawing.Color.Black
        Me.gpoPagable.Controls.Add(Me.dgvPagables)
        Me.gpoPagable.Location = New System.Drawing.Point(177, 501)
        Me.gpoPagable.Name = "gpoPagable"
        Me.gpoPagable.Size = New System.Drawing.Size(375, 125)
        Me.gpoPagable.TabIndex = 8
        Me.gpoPagable.TabStop = False
        Me.gpoPagable.Text = "Pagables"
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
        Me.dgvPagables.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Elem, Me.Ley, Me.Pag, Me.dgvTipo, Me.Ded, Me.RC, Me.Prot, Me.dgvMerc, Me.dgvQP})
        Me.dgvPagables.Location = New System.Drawing.Point(6, 19)
        Me.dgvPagables.Name = "dgvPagables"
        Me.dgvPagables.ReadOnly = True
        Me.dgvPagables.RowHeadersWidth = 25
        Me.dgvPagables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPagables.Size = New System.Drawing.Size(363, 100)
        Me.dgvPagables.TabIndex = 21
        '
        'Elem
        '
        Me.Elem.DataPropertyName = "codigoElemento"
        Me.Elem.HeaderText = "Elem"
        Me.Elem.Name = "Elem"
        Me.Elem.ReadOnly = True
        Me.Elem.Width = 50
        '
        'Ley
        '
        Me.Ley.DataPropertyName = "leyPagable"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N4"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Ley.DefaultCellStyle = DataGridViewCellStyle1
        Me.Ley.HeaderText = "Ley"
        Me.Ley.Name = "Ley"
        Me.Ley.ReadOnly = True
        Me.Ley.Visible = False
        Me.Ley.Width = 70
        '
        'Pag
        '
        Me.Pag.DataPropertyName = "pagable"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N4"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Pag.DefaultCellStyle = DataGridViewCellStyle2
        Me.Pag.HeaderText = "Pag"
        Me.Pag.Name = "Pag"
        Me.Pag.ReadOnly = True
        Me.Pag.Width = 70
        '
        'dgvTipo
        '
        Me.dgvTipo.DataPropertyName = "codigoDeduccion"
        Me.dgvTipo.HeaderText = "Tipo"
        Me.dgvTipo.Name = "dgvTipo"
        Me.dgvTipo.ReadOnly = True
        Me.dgvTipo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgvTipo.Width = 80
        '
        'Ded
        '
        Me.Ded.DataPropertyName = "deduccion"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N4"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Ded.DefaultCellStyle = DataGridViewCellStyle3
        Me.Ded.HeaderText = "Ded"
        Me.Ded.Name = "Ded"
        Me.Ded.ReadOnly = True
        Me.Ded.Width = 70
        '
        'RC
        '
        Me.RC.DataPropertyName = "refinacion"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N4"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.RC.DefaultCellStyle = DataGridViewCellStyle4
        Me.RC.HeaderText = "RC"
        Me.RC.Name = "RC"
        Me.RC.ReadOnly = True
        Me.RC.Width = 70
        '
        'Prot
        '
        Me.Prot.DataPropertyName = "proteccion"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N4"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Prot.DefaultCellStyle = DataGridViewCellStyle5
        Me.Prot.HeaderText = "Prot"
        Me.Prot.Name = "Prot"
        Me.Prot.ReadOnly = True
        Me.Prot.Width = 70
        '
        'dgvMerc
        '
        Me.dgvMerc.DataPropertyName = "codigoMercado"
        Me.dgvMerc.HeaderText = "Merc"
        Me.dgvMerc.Name = "dgvMerc"
        Me.dgvMerc.ReadOnly = True
        Me.dgvMerc.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMerc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgvMerc.Width = 160
        '
        'dgvQP
        '
        Me.dgvQP.DataPropertyName = "codigoQp"
        Me.dgvQP.HeaderText = "QP"
        Me.dgvQP.Name = "dgvQP"
        Me.dgvQP.ReadOnly = True
        Me.dgvQP.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvQP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgvQP.Width = 80
        '
        'gpoPenalizable
        '
        Me.gpoPenalizable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoPenalizable.BackColor = System.Drawing.Color.Transparent
        Me.gpoPenalizable.BorderColor = System.Drawing.Color.Black
        Me.gpoPenalizable.Controls.Add(Me.dgvPenalizable)
        Me.gpoPenalizable.Location = New System.Drawing.Point(558, 501)
        Me.gpoPenalizable.Name = "gpoPenalizable"
        Me.gpoPenalizable.Size = New System.Drawing.Size(464, 125)
        Me.gpoPenalizable.TabIndex = 9
        Me.gpoPenalizable.TabStop = False
        Me.gpoPenalizable.Text = "Penalizables"
        '
        'dgvPenalizable
        '
        Me.dgvPenalizable.AllowUserToAddRows = False
        Me.dgvPenalizable.AllowUserToDeleteRows = False
        Me.dgvPenalizable.AllowUserToResizeColumns = False
        Me.dgvPenalizable.AllowUserToResizeRows = False
        Me.dgvPenalizable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPenalizable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ElemP, Me.LeyP, Me.Min, Me.Max, Me.Unid, Me.Pen})
        Me.dgvPenalizable.Location = New System.Drawing.Point(6, 19)
        Me.dgvPenalizable.Name = "dgvPenalizable"
        Me.dgvPenalizable.ReadOnly = True
        Me.dgvPenalizable.RowHeadersWidth = 25
        Me.dgvPenalizable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPenalizable.Size = New System.Drawing.Size(452, 94)
        Me.dgvPenalizable.TabIndex = 11
        '
        'ElemP
        '
        Me.ElemP.DataPropertyName = "codigoElemento"
        Me.ElemP.HeaderText = "Elem"
        Me.ElemP.Name = "ElemP"
        Me.ElemP.ReadOnly = True
        Me.ElemP.Width = 50
        '
        'LeyP
        '
        Me.LeyP.DataPropertyName = "leyPenalizable"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N4"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.LeyP.DefaultCellStyle = DataGridViewCellStyle6
        Me.LeyP.HeaderText = "Ley"
        Me.LeyP.Name = "LeyP"
        Me.LeyP.ReadOnly = True
        Me.LeyP.Width = 70
        '
        'Min
        '
        Me.Min.DataPropertyName = "minimo"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N4"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Min.DefaultCellStyle = DataGridViewCellStyle7
        Me.Min.HeaderText = "Min"
        Me.Min.Name = "Min"
        Me.Min.ReadOnly = True
        Me.Min.Width = 70
        '
        'Max
        '
        Me.Max.DataPropertyName = "maximo"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N4"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Max.DefaultCellStyle = DataGridViewCellStyle8
        Me.Max.HeaderText = "Max"
        Me.Max.Name = "Max"
        Me.Max.ReadOnly = True
        Me.Max.Width = 70
        '
        'Unid
        '
        Me.Unid.DataPropertyName = "unidadPenalizable"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N4"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.Unid.DefaultCellStyle = DataGridViewCellStyle9
        Me.Unid.HeaderText = "Unid"
        Me.Unid.Name = "Unid"
        Me.Unid.ReadOnly = True
        Me.Unid.Width = 70
        '
        'Pen
        '
        Me.Pen.DataPropertyName = "penalidad"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N4"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.Pen.DefaultCellStyle = DataGridViewCellStyle10
        Me.Pen.HeaderText = "Pen"
        Me.Pen.Name = "Pen"
        Me.Pen.ReadOnly = True
        Me.Pen.Width = 70
        '
        'gpoParticipacion
        '
        Me.gpoParticipacion.BackColor = System.Drawing.Color.Transparent
        Me.gpoParticipacion.BorderColor = System.Drawing.Color.Black
        Me.gpoParticipacion.Controls.Add(Me.nupdPorcentaje)
        Me.gpoParticipacion.Controls.Add(Me.txtbasepart)
        Me.gpoParticipacion.Controls.Add(Me.Label12)
        Me.gpoParticipacion.Controls.Add(Me.Label11)
        Me.gpoParticipacion.Enabled = False
        Me.gpoParticipacion.Location = New System.Drawing.Point(715, 432)
        Me.gpoParticipacion.Name = "gpoParticipacion"
        Me.gpoParticipacion.Size = New System.Drawing.Size(144, 65)
        Me.gpoParticipacion.TabIndex = 5
        Me.gpoParticipacion.TabStop = False
        Me.gpoParticipacion.Text = "Participacion de Precio"
        '
        'nupdPorcentaje
        '
        Me.nupdPorcentaje.Location = New System.Drawing.Point(80, 37)
        Me.nupdPorcentaje.Name = "nupdPorcentaje"
        Me.nupdPorcentaje.Size = New System.Drawing.Size(50, 20)
        Me.nupdPorcentaje.TabIndex = 3
        Me.nupdPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtbasepart
        '
        Me.txtbasepart.Location = New System.Drawing.Point(80, 14)
        Me.txtbasepart.MaxLength = 10
        Me.txtbasepart.Name = "txtbasepart"
        Me.txtbasepart.Size = New System.Drawing.Size(50, 20)
        Me.txtbasepart.TabIndex = 1
        Me.txtbasepart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Porcentaje  %"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Base"
        '
        'gpoContratos
        '
        Me.gpoContratos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoContratos.BackColor = System.Drawing.Color.Transparent
        Me.gpoContratos.BorderColor = System.Drawing.Color.Black
        Me.gpoContratos.Controls.Add(Me.cboTipoContrato)
        Me.gpoContratos.Controls.Add(Me.cboProducto)
        Me.gpoContratos.Controls.Add(Me.Label15)
        Me.gpoContratos.Controls.Add(Me.Label14)
        Me.gpoContratos.Controls.Add(Me.fxgrdContrato)
        Me.gpoContratos.Location = New System.Drawing.Point(0, 42)
        Me.gpoContratos.Name = "gpoContratos"
        Me.gpoContratos.Size = New System.Drawing.Size(1016, 455)
        Me.gpoContratos.TabIndex = 2
        Me.gpoContratos.TabStop = False
        Me.gpoContratos.Text = "Detalle de Contrato"
        '
        'cboTipoContrato
        '
        Me.cboTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoContrato.FormattingEnabled = True
        Me.cboTipoContrato.Location = New System.Drawing.Point(101, 19)
        Me.cboTipoContrato.Name = "cboTipoContrato"
        Me.cboTipoContrato.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoContrato.TabIndex = 7
        '
        'cboProducto
        '
        Me.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProducto.FormattingEnabled = True
        Me.cboProducto.Location = New System.Drawing.Point(326, 19)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Size = New System.Drawing.Size(121, 21)
        Me.cboProducto.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Tipo de Contrato"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(260, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Producto"
        '
        'fxgrdContrato
        '
        Me.fxgrdContrato.AllowEditing = False
        Me.fxgrdContrato.AllowFiltering = True
        Me.fxgrdContrato.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fxgrdContrato.ColumnInfo = resources.GetString("fxgrdContrato.ColumnInfo")
        Me.fxgrdContrato.Location = New System.Drawing.Point(6, 46)
        Me.fxgrdContrato.Name = "fxgrdContrato"
        Me.fxgrdContrato.Rows.Count = 2
        Me.fxgrdContrato.Rows.DefaultSize = 19
        Me.fxgrdContrato.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.fxgrdContrato.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fxgrdContrato.Size = New System.Drawing.Size(1004, 403)
        Me.fxgrdContrato.TabIndex = 0
        '
        'gpoTerminos
        '
        Me.gpoTerminos.BackColor = System.Drawing.Color.Transparent
        Me.gpoTerminos.BorderColor = System.Drawing.Color.Black
        Me.gpoTerminos.Controls.Add(Me.nupdMerma)
        Me.gpoTerminos.Controls.Add(Me.txtctamensmax)
        Me.gpoTerminos.Controls.Add(Me.txtctamensmin)
        Me.gpoTerminos.Controls.Add(Me.txtctaanualmax)
        Me.gpoTerminos.Controls.Add(Me.txtctaanualmin)
        Me.gpoTerminos.Controls.Add(Me.txtMaquila)
        Me.gpoTerminos.Controls.Add(Me.Label8)
        Me.gpoTerminos.Controls.Add(Me.Label1)
        Me.gpoTerminos.Controls.Add(Me.Label2)
        Me.gpoTerminos.Controls.Add(Me.Label6)
        Me.gpoTerminos.Controls.Add(Me.Label4)
        Me.gpoTerminos.Controls.Add(Me.Label5)
        Me.gpoTerminos.Controls.Add(Me.Label3)
        Me.gpoTerminos.Controls.Add(Me.Label7)
        Me.gpoTerminos.Enabled = False
        Me.gpoTerminos.Location = New System.Drawing.Point(6, 432)
        Me.gpoTerminos.Name = "gpoTerminos"
        Me.gpoTerminos.Size = New System.Drawing.Size(465, 65)
        Me.gpoTerminos.TabIndex = 3
        Me.gpoTerminos.TabStop = False
        Me.gpoTerminos.Text = "Terminos"
        '
        'nupdMerma
        '
        Me.nupdMerma.Location = New System.Drawing.Point(392, 11)
        Me.nupdMerma.Name = "nupdMerma"
        Me.nupdMerma.Size = New System.Drawing.Size(67, 20)
        Me.nupdMerma.TabIndex = 6
        Me.nupdMerma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtctamensmax
        '
        Me.txtctamensmax.Location = New System.Drawing.Point(256, 37)
        Me.txtctamensmax.MaxLength = 10
        Me.txtctamensmax.Name = "txtctamensmax"
        Me.txtctamensmax.Size = New System.Drawing.Size(51, 20)
        Me.txtctamensmax.TabIndex = 11
        Me.txtctamensmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtctamensmin
        '
        Me.txtctamensmin.Location = New System.Drawing.Point(153, 37)
        Me.txtctamensmin.MaxLength = 10
        Me.txtctamensmin.Name = "txtctamensmin"
        Me.txtctamensmin.Size = New System.Drawing.Size(51, 20)
        Me.txtctamensmin.TabIndex = 9
        Me.txtctamensmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtctaanualmax
        '
        Me.txtctaanualmax.Location = New System.Drawing.Point(256, 11)
        Me.txtctaanualmax.MaxLength = 10
        Me.txtctaanualmax.Name = "txtctaanualmax"
        Me.txtctaanualmax.Size = New System.Drawing.Size(51, 20)
        Me.txtctaanualmax.TabIndex = 4
        Me.txtctaanualmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtctaanualmin
        '
        Me.txtctaanualmin.Location = New System.Drawing.Point(153, 11)
        Me.txtctaanualmin.MaxLength = 10
        Me.txtctaanualmin.Name = "txtctaanualmin"
        Me.txtctaanualmin.Size = New System.Drawing.Size(51, 20)
        Me.txtctaanualmin.TabIndex = 2
        Me.txtctaanualmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMaquila
        '
        Me.txtMaquila.Location = New System.Drawing.Point(392, 38)
        Me.txtMaquila.MaxLength = 10
        Me.txtMaquila.Name = "txtMaquila"
        Me.txtMaquila.Size = New System.Drawing.Size(67, 20)
        Me.txtMaquila.TabIndex = 13
        Me.txtMaquila.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(318, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "TC USD/TM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(318, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Merma %"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cuota Mensual TM"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(226, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Max"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(127, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Min"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(226, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Max"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(127, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Min"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Cuota Anual TM"
        '
        'gpoEscalador
        '
        Me.gpoEscalador.BackColor = System.Drawing.Color.Transparent
        Me.gpoEscalador.BorderColor = System.Drawing.Color.Black
        Me.gpoEscalador.Controls.Add(Me.txtbasemenos2)
        Me.gpoEscalador.Controls.Add(Me.txtbasemas2)
        Me.gpoEscalador.Controls.Add(Me.txtbasemenos1)
        Me.gpoEscalador.Controls.Add(Me.txtbase2)
        Me.gpoEscalador.Controls.Add(Me.txtbasemas1)
        Me.gpoEscalador.Controls.Add(Me.txtbase1)
        Me.gpoEscalador.Controls.Add(Me.Label10)
        Me.gpoEscalador.Controls.Add(Me.Label9)
        Me.gpoEscalador.Enabled = False
        Me.gpoEscalador.Location = New System.Drawing.Point(477, 432)
        Me.gpoEscalador.Name = "gpoEscalador"
        Me.gpoEscalador.Size = New System.Drawing.Size(232, 65)
        Me.gpoEscalador.TabIndex = 4
        Me.gpoEscalador.TabStop = False
        Me.gpoEscalador.Text = "Escalador +1 -1"
        '
        'txtbasemenos2
        '
        Me.txtbasemenos2.Location = New System.Drawing.Point(170, 36)
        Me.txtbasemenos2.MaxLength = 10
        Me.txtbasemenos2.Name = "txtbasemenos2"
        Me.txtbasemenos2.Size = New System.Drawing.Size(51, 20)
        Me.txtbasemenos2.TabIndex = 7
        Me.txtbasemenos2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtbasemas2
        '
        Me.txtbasemas2.Location = New System.Drawing.Point(113, 36)
        Me.txtbasemas2.MaxLength = 10
        Me.txtbasemas2.Name = "txtbasemas2"
        Me.txtbasemas2.Size = New System.Drawing.Size(51, 20)
        Me.txtbasemas2.TabIndex = 6
        Me.txtbasemas2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtbasemenos1
        '
        Me.txtbasemenos1.Location = New System.Drawing.Point(170, 13)
        Me.txtbasemenos1.MaxLength = 10
        Me.txtbasemenos1.Name = "txtbasemenos1"
        Me.txtbasemenos1.Size = New System.Drawing.Size(51, 20)
        Me.txtbasemenos1.TabIndex = 3
        Me.txtbasemenos1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtbase2
        '
        Me.txtbase2.Location = New System.Drawing.Point(56, 36)
        Me.txtbase2.MaxLength = 10
        Me.txtbase2.Name = "txtbase2"
        Me.txtbase2.Size = New System.Drawing.Size(51, 20)
        Me.txtbase2.TabIndex = 5
        Me.txtbase2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtbasemas1
        '
        Me.txtbasemas1.Location = New System.Drawing.Point(113, 13)
        Me.txtbasemas1.MaxLength = 10
        Me.txtbasemas1.Name = "txtbasemas1"
        Me.txtbasemas1.Size = New System.Drawing.Size(51, 20)
        Me.txtbasemas1.TabIndex = 2
        Me.txtbasemas1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtbase1
        '
        Me.txtbase1.Location = New System.Drawing.Point(56, 13)
        Me.txtbase1.MaxLength = 10
        Me.txtbase1.Name = "txtbase1"
        Me.txtbase1.Size = New System.Drawing.Size(51, 20)
        Me.txtbase1.TabIndex = 1
        Me.txtbase1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Base"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Base"
        '
        'CuGroupBox1
        '
        Me.CuGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.CuGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.CuGroupBox1.Controls.Add(Me.cboDeposito)
        Me.CuGroupBox1.Controls.Add(Me.Label18)
        Me.CuGroupBox1.Controls.Add(Me.txtMaquila2)
        Me.CuGroupBox1.Controls.Add(Me.Label17)
        Me.CuGroupBox1.Controls.Add(Me.txtMerma)
        Me.CuGroupBox1.Controls.Add(Me.Label16)
        Me.CuGroupBox1.Location = New System.Drawing.Point(7, 501)
        Me.CuGroupBox1.Name = "CuGroupBox1"
        Me.CuGroupBox1.Size = New System.Drawing.Size(164, 113)
        Me.CuGroupBox1.TabIndex = 22
        Me.CuGroupBox1.TabStop = False
        Me.CuGroupBox1.Text = "Términos"
        '
        'cboDeposito
        '
        Me.cboDeposito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDeposito.Enabled = False
        Me.cboDeposito.FormattingEnabled = True
        Me.cboDeposito.Location = New System.Drawing.Point(6, 87)
        Me.cboDeposito.Name = "cboDeposito"
        Me.cboDeposito.Size = New System.Drawing.Size(152, 21)
        Me.cboDeposito.TabIndex = 16
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(11, 71)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 13)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Deposito"
        '
        'txtMaquila2
        '
        Me.txtMaquila2.Enabled = False
        Me.txtMaquila2.Location = New System.Drawing.Point(65, 23)
        Me.txtMaquila2.MaxLength = 10
        Me.txtMaquila2.Name = "txtMaquila2"
        Me.txtMaquila2.Size = New System.Drawing.Size(67, 20)
        Me.txtMaquila2.TabIndex = 15
        Me.txtMaquila2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(11, 23)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 13)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Maquila"
        '
        'txtMerma
        '
        Me.txtMerma.Enabled = False
        Me.txtMerma.Location = New System.Drawing.Point(65, 49)
        Me.txtMerma.MaxLength = 10
        Me.txtMerma.Name = "txtMerma"
        Me.txtMerma.Size = New System.Drawing.Size(67, 20)
        Me.txtMerma.TabIndex = 15
        Me.txtMerma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(11, 49)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 13)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Merma"
        '
        'contratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1028, 626)
        Me.Controls.Add(Me.gpoContratos)
        Me.Controls.Add(Me.CuGroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gpoFacturacion)
        Me.Controls.Add(Me.gpoPagable)
        Me.Controls.Add(Me.gpoPenalizable)
        Me.Controls.Add(Me.gpoParticipacion)
        Me.Controls.Add(Me.gpoTerminos)
        Me.Controls.Add(Me.gpoEscalador)
        Me.Controls.Add(Me.tsMantenimiento)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "contratos"
        Me.Text = "Mantenimiento de Contratos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tsMantenimiento.ResumeLayout(False)
        Me.tsMantenimiento.PerformLayout()
        Me.gpoFacturacion.ResumeLayout(False)
        Me.gpoFacturacion.PerformLayout()
        CType(Me.nupdPorcPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoPagable.ResumeLayout(False)
        CType(Me.dgvPagables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoPenalizable.ResumeLayout(False)
        CType(Me.dgvPenalizable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoParticipacion.ResumeLayout(False)
        Me.gpoParticipacion.PerformLayout()
        CType(Me.nupdPorcentaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoContratos.ResumeLayout(False)
        Me.gpoContratos.PerformLayout()
        CType(Me.fxgrdContrato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoTerminos.ResumeLayout(False)
        Me.gpoTerminos.PerformLayout()
        CType(Me.nupdMerma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoEscalador.ResumeLayout(False)
        Me.gpoEscalador.PerformLayout()
        Me.CuGroupBox1.ResumeLayout(False)
        Me.CuGroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents tsMantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContratoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gpoContratos As CUGroupBox ' System.Windows.Forms.GroupBox
    Friend WithEvents gpoPenalizable As CUGroupBox 'System.Windows.Forms.GroupBox
    Friend WithEvents gpoPagable As CUGroupBox 'System.Windows.Forms.GroupBox
    Friend WithEvents tsmNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents fxgrdContrato As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents tsbCopiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents gpoFacturacion As CUGroupBox 'System.Windows.Forms.GroupBox
    Friend WithEvents nupdPorcPago As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents gpoParticipacion As CUGroupBox 'System.Windows.Forms.GroupBox
    Friend WithEvents nupdPorcentaje As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtbasepart As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents gpoEscalador As CUGroupBox 'System.Windows.Forms.GroupBox
    Friend WithEvents txtbasemenos2 As System.Windows.Forms.TextBox
    Friend WithEvents txtbasemas2 As System.Windows.Forms.TextBox
    Friend WithEvents txtbasemenos1 As System.Windows.Forms.TextBox
    Friend WithEvents txtbase2 As System.Windows.Forms.TextBox
    Friend WithEvents txtbasemas1 As System.Windows.Forms.TextBox
    Friend WithEvents txtbase1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents nupdMerma As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtctamensmax As System.Windows.Forms.TextBox
    Friend WithEvents txtctamensmin As System.Windows.Forms.TextBox
    Friend WithEvents txtctaanualmax As System.Windows.Forms.TextBox
    Friend WithEvents txtctaanualmin As System.Windows.Forms.TextBox
    Friend WithEvents txtMaquila As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tsmCopiar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmRefrescar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsmEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents gpoTerminos As CUGroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tsbContratoLoteP As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbContratoLoteS As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dgvPagables As System.Windows.Forms.DataGridView
    Friend WithEvents dgvPenalizable As System.Windows.Forms.DataGridView
    Friend WithEvents cboTipoContrato As System.Windows.Forms.ComboBox
    Friend WithEvents cboProducto As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ElemP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LeyP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Min As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Max As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tsbLimpiarFiltro As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CuGroupBox1 As CUGroupBox
    Friend WithEvents cboDeposito As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtMaquila2 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtMerma As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Elem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ley As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pag As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvTipo As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Ded As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvMerc As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dgvQP As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
