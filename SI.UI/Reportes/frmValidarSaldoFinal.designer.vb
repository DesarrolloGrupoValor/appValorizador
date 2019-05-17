<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmValidarSaldoFinal
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmValidarSaldoFinal))
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvSaldoFinal = New System.Windows.Forms.DataGridView()
        Me.calidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precinto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ruma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tmh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fec_ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ticket = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TsMantenimiento = New System.Windows.Forms.ToolStrip()
        Me.tsbPegar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCargar = New System.Windows.Forms.ToolStripButton()
        Me.TsbConsultar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsbExportarExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.dgvValidarSaldoFinal = New System.Windows.Forms.DataGridView()
        Me.empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lote_origen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ruma_origen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_c_precinto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tmh_sf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvtxtPrecinto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvtxtObs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.sfDialog = New System.Windows.Forms.SaveFileDialog()
        CType(Me.dgvSaldoFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TsMantenimiento.SuspendLayout()
        CType(Me.dgvValidarSaldoFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSaldoFinal
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSaldoFinal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSaldoFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSaldoFinal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.calidad, Me.precinto, Me.ruma, Me.clase, Me.tmh, Me.fec_ingreso, Me.ticket})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSaldoFinal.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvSaldoFinal.Location = New System.Drawing.Point(6, 53)
        Me.dgvSaldoFinal.Name = "dgvSaldoFinal"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSaldoFinal.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvSaldoFinal.RowHeadersWidth = 20
        Me.dgvSaldoFinal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSaldoFinal.Size = New System.Drawing.Size(616, 390)
        Me.dgvSaldoFinal.TabIndex = 0
        '
        'calidad
        '
        Me.calidad.HeaderText = "Calidad"
        Me.calidad.Name = "calidad"
        Me.calidad.Width = 120
        '
        'precinto
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.precinto.DefaultCellStyle = DataGridViewCellStyle2
        Me.precinto.HeaderText = "Precinto"
        Me.precinto.Name = "precinto"
        Me.precinto.Width = 60
        '
        'ruma
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ruma.DefaultCellStyle = DataGridViewCellStyle3
        Me.ruma.HeaderText = "Ruma"
        Me.ruma.Name = "ruma"
        Me.ruma.Width = 80
        '
        'clase
        '
        Me.clase.HeaderText = "Clase"
        Me.clase.Name = "clase"
        Me.clase.Width = 50
        '
        'tmh
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.tmh.DefaultCellStyle = DataGridViewCellStyle4
        Me.tmh.HeaderText = "TMH"
        Me.tmh.Name = "tmh"
        Me.tmh.Width = 60
        '
        'fec_ingreso
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.fec_ingreso.DefaultCellStyle = DataGridViewCellStyle5
        Me.fec_ingreso.HeaderText = "F.Ingreso"
        Me.fec_ingreso.Name = "fec_ingreso"
        Me.fec_ingreso.Width = 85
        '
        'ticket
        '
        Me.ticket.HeaderText = "Ticket"
        Me.ticket.Name = "ticket"
        Me.ticket.Width = 120
        '
        'TsMantenimiento
        '
        Me.TsMantenimiento.BackColor = System.Drawing.SystemColors.Control
        Me.TsMantenimiento.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.TsMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbPegar, Me.tsbCargar, Me.TsbConsultar, Me.tsbEliminar, Me.tsbLimpiar, Me.ToolStripSeparator1, Me.TsbExportarExcel, Me.ToolStripSeparator2, Me.TsbSalir})
        Me.TsMantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.TsMantenimiento.Name = "TsMantenimiento"
        Me.TsMantenimiento.Size = New System.Drawing.Size(1354, 39)
        Me.TsMantenimiento.Stretch = True
        Me.TsMantenimiento.TabIndex = 24
        Me.TsMantenimiento.Text = "ToolStrip1"
        '
        'tsbPegar
        '
        Me.tsbPegar.Image = CType(resources.GetObject("tsbPegar.Image"), System.Drawing.Image)
        Me.tsbPegar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPegar.Name = "tsbPegar"
        Me.tsbPegar.Size = New System.Drawing.Size(133, 36)
        Me.tsbPegar.Text = "Pegar Saldo Final"
        '
        'tsbCargar
        '
        Me.tsbCargar.Image = Global.My.Resources.Resources.Folder
        Me.tsbCargar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCargar.Name = "tsbCargar"
        Me.tsbCargar.Size = New System.Drawing.Size(111, 36)
        Me.tsbCargar.Text = "Cargar Datos"
        '
        'TsbConsultar
        '
        Me.TsbConsultar.Image = Global.My.Resources.Resources.consultar
        Me.TsbConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbConsultar.Name = "TsbConsultar"
        Me.TsbConsultar.Size = New System.Drawing.Size(94, 36)
        Me.TsbConsultar.Text = "Consultar"
        '
        'tsbEliminar
        '
        Me.tsbEliminar.Image = CType(resources.GetObject("tsbEliminar.Image"), System.Drawing.Image)
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(105, 36)
        Me.tsbEliminar.Text = "Eliminar fila"
        '
        'tsbLimpiar
        '
        Me.tsbLimpiar.Image = Global.My.Resources.Resources.quitarFiltro
        Me.tsbLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLimpiar.Name = "tsbLimpiar"
        Me.tsbLimpiar.Size = New System.Drawing.Size(116, 36)
        Me.tsbLimpiar.Text = "Limpiar Datos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'TsbExportarExcel
        '
        Me.TsbExportarExcel.Image = Global.My.Resources.Resources.asociar_1
        Me.TsbExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbExportarExcel.Name = "TsbExportarExcel"
        Me.TsbExportarExcel.Size = New System.Drawing.Size(124, 36)
        Me.TsbExportarExcel.Text = "Exportar a Excel"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'TsbSalir
        '
        Me.TsbSalir.Image = Global.My.Resources.Resources.salir
        Me.TsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbSalir.Name = "TsbSalir"
        Me.TsbSalir.Size = New System.Drawing.Size(65, 36)
        Me.TsbSalir.Text = "Salir"
        '
        'dgvValidarSaldoFinal
        '
        Me.dgvValidarSaldoFinal.AllowUserToAddRows = False
        Me.dgvValidarSaldoFinal.AllowUserToDeleteRows = False
        Me.dgvValidarSaldoFinal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvValidarSaldoFinal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvValidarSaldoFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvValidarSaldoFinal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.empresa, Me.lote_origen, Me.ruma_origen, Me.c_c_precinto, Me.tmh_sf, Me.Column1, Me.DataGridViewTextBoxColumn1, Me.dgvtxtPrecinto, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.dgvtxtObs, Me.Dif})
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvValidarSaldoFinal.DefaultCellStyle = DataGridViewCellStyle17
        Me.dgvValidarSaldoFinal.Location = New System.Drawing.Point(6, 53)
        Me.dgvValidarSaldoFinal.Name = "dgvValidarSaldoFinal"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvValidarSaldoFinal.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.dgvValidarSaldoFinal.RowHeadersWidth = 20
        Me.dgvValidarSaldoFinal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvValidarSaldoFinal.Size = New System.Drawing.Size(680, 390)
        Me.dgvValidarSaldoFinal.TabIndex = 1
        '
        'empresa
        '
        Me.empresa.DataPropertyName = "EMPRESA"
        Me.empresa.HeaderText = "Empresa"
        Me.empresa.Name = "empresa"
        Me.empresa.Width = 70
        '
        'lote_origen
        '
        Me.lote_origen.DataPropertyName = "LOTE_ORIGEN"
        Me.lote_origen.HeaderText = "Lote Origen"
        Me.lote_origen.Name = "lote_origen"
        Me.lote_origen.Visible = False
        '
        'ruma_origen
        '
        Me.ruma_origen.DataPropertyName = "RUMA_ORIGEN"
        Me.ruma_origen.HeaderText = "Ruma Origen"
        Me.ruma_origen.Name = "ruma_origen"
        Me.ruma_origen.Width = 90
        '
        'c_c_precinto
        '
        Me.c_c_precinto.DataPropertyName = "C_C_PRECINTO"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.c_c_precinto.DefaultCellStyle = DataGridViewCellStyle9
        Me.c_c_precinto.HeaderText = "Precinto"
        Me.c_c_precinto.Name = "c_c_precinto"
        Me.c_c_precinto.Width = 65
        '
        'tmh_sf
        '
        Me.tmh_sf.DataPropertyName = "TMH_SF"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        Me.tmh_sf.DefaultCellStyle = DataGridViewCellStyle10
        Me.tmh_sf.HeaderText = "Tmh SF"
        Me.tmh_sf.Name = "tmh_sf"
        Me.tmh_sf.Width = 80
        '
        'Column1
        '
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Silver
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle11
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 15
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "calidad"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Calidad"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'dgvtxtPrecinto
        '
        Me.dgvtxtPrecinto.DataPropertyName = "precinto"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvtxtPrecinto.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvtxtPrecinto.HeaderText = "Preciento"
        Me.dgvtxtPrecinto.Name = "dgvtxtPrecinto"
        Me.dgvtxtPrecinto.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ruma"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Ruma"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "clase"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Clase"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "tmh"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tmh"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "fec_ingreso"
        DataGridViewCellStyle14.Format = "d"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn6.HeaderText = "F.Ingreso"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ticket"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Ticket"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'dgvtxtObs
        '
        Me.dgvtxtObs.DataPropertyName = "OBS"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvtxtObs.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvtxtObs.HeaderText = "Observ."
        Me.dgvtxtObs.Name = "dgvtxtObs"
        Me.dgvtxtObs.Width = 50
        '
        'Dif
        '
        Me.Dif.DataPropertyName = "DIF"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "N2"
        Me.Dif.DefaultCellStyle = DataGridViewCellStyle16
        Me.Dif.HeaderText = "Diferencia"
        Me.Dif.Name = "Dif"
        Me.Dif.Width = 80
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cboPeriodo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dgvSaldoFinal)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(629, 449)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Saldo Losa"
        '
        'cboPeriodo
        '
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.Location = New System.Drawing.Point(78, 19)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(121, 21)
        Me.cboPeriodo.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Periodo:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.dgvValidarSaldoFinal)
        Me.GroupBox2.Location = New System.Drawing.Point(656, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(694, 449)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado Saldo Final"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(467, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Saldo en Losa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Movimiento"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(347, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(320, 3)
        Me.Panel2.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(27, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(305, 3)
        Me.Panel1.TabIndex = 4
        '
        'frmValidarSaldoFinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 503)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TsMantenimiento)
        Me.Name = "frmValidarSaldoFinal"
        Me.Text = "4. Validar Saldo Final"
        CType(Me.dgvSaldoFinal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TsMantenimiento.ResumeLayout(False)
        Me.TsMantenimiento.PerformLayout()
        CType(Me.dgvValidarSaldoFinal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSaldoFinal As System.Windows.Forms.DataGridView
    Friend WithEvents TsMantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents TsbConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TsbExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbPegar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbLimpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvValidarSaldoFinal As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents sfDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents empresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lote_origen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ruma_origen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_c_precinto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tmh_sf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvtxtPrecinto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvtxtObs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dif As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents calidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precinto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ruma As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clase As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tmh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fec_ingreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ticket As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tsbCargar As System.Windows.Forms.ToolStripButton
End Class
