<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocumentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocumentos))
        Me.gpoFiltro = New System.Windows.Forms.GroupBox()
        Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.lblTipoDocumento = New System.Windows.Forms.Label()
        Me.dtpFECHA_DOC = New System.Windows.Forms.DateTimePicker()
        Me.txtBENEFICIARIO = New System.Windows.Forms.TextBox()
        Me.txtBENEFICIARIO_ID = New System.Windows.Forms.TextBox()
        Me.txtNRO_DOC_EXTERNO = New System.Windows.Forms.TextBox()
        Me.lblBeneficiario = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAdjunto = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbAdjuntar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
        Me.tsbAceptar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.lblReg = New System.Windows.Forms.Label()
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
        Me.ofdAdjuntar = New System.Windows.Forms.OpenFileDialog()
        Me.gpoFiltro.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpoFiltro
        '
        Me.gpoFiltro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoFiltro.Controls.Add(Me.cboTipoDocumento)
        Me.gpoFiltro.Controls.Add(Me.lblTipoDocumento)
        Me.gpoFiltro.Controls.Add(Me.dtpFECHA_DOC)
        Me.gpoFiltro.Controls.Add(Me.txtBENEFICIARIO)
        Me.gpoFiltro.Controls.Add(Me.txtBENEFICIARIO_ID)
        Me.gpoFiltro.Controls.Add(Me.txtNRO_DOC_EXTERNO)
        Me.gpoFiltro.Controls.Add(Me.lblBeneficiario)
        Me.gpoFiltro.Controls.Add(Me.Label4)
        Me.gpoFiltro.Controls.Add(Me.Label2)
        Me.gpoFiltro.Controls.Add(Me.txtTipo)
        Me.gpoFiltro.Controls.Add(Me.Label1)
        Me.gpoFiltro.Location = New System.Drawing.Point(12, 9)
        Me.gpoFiltro.Name = "gpoFiltro"
        Me.gpoFiltro.Size = New System.Drawing.Size(491, 161)
        Me.gpoFiltro.TabIndex = 4
        Me.gpoFiltro.TabStop = False
        Me.gpoFiltro.Text = "Datos Generales"
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.FormattingEnabled = True
        Me.cboTipoDocumento.Location = New System.Drawing.Point(374, 25)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(100, 21)
        Me.cboTipoDocumento.TabIndex = 5
        Me.cboTipoDocumento.Visible = False
        '
        'lblTipoDocumento
        '
        Me.lblTipoDocumento.AutoSize = True
        Me.lblTipoDocumento.Location = New System.Drawing.Point(278, 29)
        Me.lblTipoDocumento.Name = "lblTipoDocumento"
        Me.lblTipoDocumento.Size = New System.Drawing.Size(54, 13)
        Me.lblTipoDocumento.TabIndex = 4
        Me.lblTipoDocumento.Text = "Tipo Doc."
        Me.lblTipoDocumento.Visible = False
        '
        'dtpFECHA_DOC
        '
        Me.dtpFECHA_DOC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFECHA_DOC.Location = New System.Drawing.Point(374, 52)
        Me.dtpFECHA_DOC.Name = "dtpFECHA_DOC"
        Me.dtpFECHA_DOC.Size = New System.Drawing.Size(100, 20)
        Me.dtpFECHA_DOC.TabIndex = 2
        Me.dtpFECHA_DOC.Value = New Date(2013, 9, 12, 0, 0, 0, 0)
        '
        'txtBENEFICIARIO
        '
        Me.txtBENEFICIARIO.Enabled = False
        Me.txtBENEFICIARIO.Location = New System.Drawing.Point(224, 78)
        Me.txtBENEFICIARIO.Name = "txtBENEFICIARIO"
        Me.txtBENEFICIARIO.Size = New System.Drawing.Size(250, 20)
        Me.txtBENEFICIARIO.TabIndex = 0
        Me.txtBENEFICIARIO.Visible = False
        '
        'txtBENEFICIARIO_ID
        '
        Me.txtBENEFICIARIO_ID.Location = New System.Drawing.Point(118, 78)
        Me.txtBENEFICIARIO_ID.Name = "txtBENEFICIARIO_ID"
        Me.txtBENEFICIARIO_ID.ReadOnly = True
        Me.txtBENEFICIARIO_ID.Size = New System.Drawing.Size(100, 20)
        Me.txtBENEFICIARIO_ID.TabIndex = 3
        Me.txtBENEFICIARIO_ID.Visible = False
        '
        'txtNRO_DOC_EXTERNO
        '
        Me.txtNRO_DOC_EXTERNO.Location = New System.Drawing.Point(118, 52)
        Me.txtNRO_DOC_EXTERNO.Name = "txtNRO_DOC_EXTERNO"
        Me.txtNRO_DOC_EXTERNO.Size = New System.Drawing.Size(150, 20)
        Me.txtNRO_DOC_EXTERNO.TabIndex = 1
        '
        'lblBeneficiario
        '
        Me.lblBeneficiario.AutoSize = True
        Me.lblBeneficiario.Location = New System.Drawing.Point(10, 81)
        Me.lblBeneficiario.Name = "lblBeneficiario"
        Me.lblBeneficiario.Size = New System.Drawing.Size(48, 13)
        Me.lblBeneficiario.TabIndex = 0
        Me.lblBeneficiario.Text = "Empresa"
        Me.lblBeneficiario.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(278, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Fecha Documento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Numero Documento"
        '
        'txtTipo
        '
        Me.txtTipo.Enabled = False
        Me.txtTipo.Location = New System.Drawing.Point(118, 26)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(150, 20)
        Me.txtTipo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo Adjunto"
        '
        'txtAdjunto
        '
        Me.txtAdjunto.Location = New System.Drawing.Point(363, 21)
        Me.txtAdjunto.Name = "txtAdjunto"
        Me.txtAdjunto.Size = New System.Drawing.Size(114, 20)
        Me.txtAdjunto.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtAdjunto)
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(491, 59)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAdjuntar, Me.ToolStripSeparator6, Me.tsbLimpiar, Me.tsbAceptar, Me.ToolStripSeparator7, Me.tsbCancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(485, 35)
        Me.ToolStrip1.TabIndex = 20
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbAdjuntar
        '
        Me.tsbAdjuntar.Image = CType(resources.GetObject("tsbAdjuntar.Image"), System.Drawing.Image)
        Me.tsbAdjuntar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAdjuntar.Name = "tsbAdjuntar"
        Me.tsbAdjuntar.Size = New System.Drawing.Size(85, 32)
        Me.tsbAdjuntar.Text = "Adjuntar"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 35)
        '
        'tsbLimpiar
        '
        Me.tsbLimpiar.Image = Global.My.Resources.Resources.quitarFiltro
        Me.tsbLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLimpiar.Name = "tsbLimpiar"
        Me.tsbLimpiar.Size = New System.Drawing.Size(79, 32)
        Me.tsbLimpiar.Text = "Limpiar"
        '
        'tsbAceptar
        '
        Me.tsbAceptar.Image = Global.My.Resources.Resources.aprobar
        Me.tsbAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAceptar.Name = "tsbAceptar"
        Me.tsbAceptar.Size = New System.Drawing.Size(80, 32)
        Me.tsbAceptar.Text = "Aceptar"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 35)
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Image = Global.My.Resources.Resources.eliminar
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(85, 32)
        Me.tsbCancelar.Text = "Cancelar"
        '
        'lblReg
        '
        Me.lblReg.AutoSize = True
        Me.lblReg.Location = New System.Drawing.Point(9, 454)
        Me.lblReg.Name = "lblReg"
        Me.lblReg.Size = New System.Drawing.Size(0, 13)
        Me.lblReg.TabIndex = 0
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
        'ofdAdjuntar
        '
        Me.ofdAdjuntar.FileName = "OpenFileDialog1"
        '
        'frmDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(515, 182)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblReg)
        Me.Controls.Add(Me.gpoFiltro)
        Me.KeyPreview = True
        Me.Name = "frmDocumentos"
        Me.Text = "Documentos"
        Me.gpoFiltro.ResumeLayout(False)
        Me.gpoFiltro.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gpoFiltro As System.Windows.Forms.GroupBox
    Friend WithEvents lblReg As System.Windows.Forms.Label
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
    Friend WithEvents ofdAdjuntar As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtNRO_DOC_EXTERNO As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFECHA_DOC As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAdjuntar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtAdjunto As System.Windows.Forms.TextBox
    Friend WithEvents txtBENEFICIARIO As System.Windows.Forms.TextBox
    Friend WithEvents txtBENEFICIARIO_ID As System.Windows.Forms.TextBox
    Friend WithEvents lblBeneficiario As System.Windows.Forms.Label
    Friend WithEvents tsbLimpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoDocumento As System.Windows.Forms.Label
End Class
