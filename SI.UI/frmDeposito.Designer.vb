<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeposito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeposito))
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
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gpoContratos = New CUGroupBox()
        Me.fxgrdCOM_DEPOSITOS = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.gpoFacturacion = New CUGroupBox()
        Me.nupdPorcPago = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.gpoParticipacion = New CUGroupBox()
        Me.nupdPorcentaje = New System.Windows.Forms.NumericUpDown()
        Me.txtbasepart = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
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
        Me.Label14 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.tsMantenimiento.SuspendLayout()
        Me.gpoContratos.SuspendLayout()
        CType(Me.fxgrdCOM_DEPOSITOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoFacturacion.SuspendLayout()
        CType(Me.nupdPorcPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoParticipacion.SuspendLayout()
        CType(Me.nupdPorcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoTerminos.SuspendLayout()
        CType(Me.nupdMerma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoEscalador.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContratoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1039, 24)
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
        Me.tsMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbSalir})
        Me.tsMantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.tsMantenimiento.Name = "tsMantenimiento"
        Me.tsMantenimiento.Size = New System.Drawing.Size(836, 39)
        Me.tsMantenimiento.TabIndex = 1
        Me.tsMantenimiento.Text = "ToolStrip1"
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
        'gpoContratos
        '
        Me.gpoContratos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoContratos.BackColor = System.Drawing.Color.Transparent
        Me.gpoContratos.BorderColor = System.Drawing.Color.Black
        Me.gpoContratos.Controls.Add(Me.fxgrdCOM_DEPOSITOS)
        Me.gpoContratos.Location = New System.Drawing.Point(8, 42)
        Me.gpoContratos.Name = "gpoContratos"
        Me.gpoContratos.Size = New System.Drawing.Size(816, 364)
        Me.gpoContratos.TabIndex = 2
        Me.gpoContratos.TabStop = False
        '
        'fxgrdCOM_DEPOSITOS
        '
        Me.fxgrdCOM_DEPOSITOS.AllowEditing = False
        Me.fxgrdCOM_DEPOSITOS.AllowFiltering = True
        Me.fxgrdCOM_DEPOSITOS.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fxgrdCOM_DEPOSITOS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fxgrdCOM_DEPOSITOS.AutoGenerateColumns = False
        Me.fxgrdCOM_DEPOSITOS.ColumnInfo = resources.GetString("fxgrdCOM_DEPOSITOS.ColumnInfo")
        Me.fxgrdCOM_DEPOSITOS.Location = New System.Drawing.Point(6, 10)
        Me.fxgrdCOM_DEPOSITOS.Name = "fxgrdCOM_DEPOSITOS"
        Me.fxgrdCOM_DEPOSITOS.Rows.Count = 2
        Me.fxgrdCOM_DEPOSITOS.Rows.DefaultSize = 19
        Me.fxgrdCOM_DEPOSITOS.Rows.GlyphRow = 0
        Me.fxgrdCOM_DEPOSITOS.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.fxgrdCOM_DEPOSITOS.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fxgrdCOM_DEPOSITOS.Size = New System.Drawing.Size(801, 349)
        Me.fxgrdCOM_DEPOSITOS.TabIndex = 0
        Me.fxgrdCOM_DEPOSITOS.Tree.Column = 0
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
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(297, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(233, 17)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Consulta de Depósito por Localidad"
        '
        'frmDeposito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(836, 415)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.gpoContratos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gpoFacturacion)
        Me.Controls.Add(Me.gpoParticipacion)
        Me.Controls.Add(Me.gpoTerminos)
        Me.Controls.Add(Me.gpoEscalador)
        Me.Controls.Add(Me.tsMantenimiento)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmDeposito"
        Me.Text = "Consulta Deposito"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tsMantenimiento.ResumeLayout(False)
        Me.tsMantenimiento.PerformLayout()
        Me.gpoContratos.ResumeLayout(False)
        CType(Me.fxgrdCOM_DEPOSITOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoFacturacion.ResumeLayout(False)
        Me.gpoFacturacion.PerformLayout()
        CType(Me.nupdPorcPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoParticipacion.ResumeLayout(False)
        Me.gpoParticipacion.PerformLayout()
        CType(Me.nupdPorcentaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoTerminos.ResumeLayout(False)
        Me.gpoTerminos.PerformLayout()
        CType(Me.nupdMerma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoEscalador.ResumeLayout(False)
        Me.gpoEscalador.PerformLayout()
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
    'System.Windows.Forms.GroupBox
    'System.Windows.Forms.GroupBox
    Friend WithEvents tsmNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fxgrdCOM_DEPOSITOS As C1.Win.C1FlexGrid.C1FlexGrid
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
    Friend WithEvents tsmEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gpoTerminos As CUGroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
