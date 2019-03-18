<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDescuentos2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDescuentos2))
        Me.msMantenimiento = New System.Windows.Forms.MenuStrip()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmGuardar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsMantenimiento = New System.Windows.Forms.ToolStrip()
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.txtCarta = New System.Windows.Forms.TextBox()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New CUTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboDescuento = New System.Windows.Forms.ComboBox()
        Me.msMantenimiento.SuspendLayout()
        Me.tsMantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMantenimiento
        '
        Me.msMantenimiento.BackColor = System.Drawing.SystemColors.Control
        Me.msMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoToolStripMenuItem})
        Me.msMantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.msMantenimiento.Name = "msMantenimiento"
        Me.msMantenimiento.Size = New System.Drawing.Size(428, 24)
        Me.msMantenimiento.TabIndex = 1
        Me.msMantenimiento.Text = "MenuStrip1"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmGuardar, Me.ToolStripSeparator5, Me.tsmSalir})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'tsmGuardar
        '
        Me.tsmGuardar.Image = CType(resources.GetObject("tsmGuardar.Image"), System.Drawing.Image)
        Me.tsmGuardar.Name = "tsmGuardar"
        Me.tsmGuardar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.tsmGuardar.Size = New System.Drawing.Size(158, 22)
        Me.tsmGuardar.Text = "Guardar"
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
        'tsMantenimiento
        '
        Me.tsMantenimiento.BackColor = System.Drawing.SystemColors.Control
        Me.tsMantenimiento.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNuevo, Me.ToolStripSeparator3, Me.tsbSalir})
        Me.tsMantenimiento.Location = New System.Drawing.Point(0, 24)
        Me.tsMantenimiento.Name = "tsMantenimiento"
        Me.tsMantenimiento.Size = New System.Drawing.Size(428, 39)
        Me.tsMantenimiento.TabIndex = 2
        Me.tsMantenimiento.Text = "ToolStrip1"
        '
        'tsbNuevo
        '
        Me.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbNuevo.Image = CType(resources.GetObject("tsbNuevo.Image"), System.Drawing.Image)
        Me.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(36, 36)
        Me.tsbNuevo.Text = "Nuevo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
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
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(104, 192)
        Me.txtObs.MaxLength = 250
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(310, 50)
        Me.txtObs.TabIndex = 20
        '
        'txtCarta
        '
        Me.txtCarta.Location = New System.Drawing.Point(104, 165)
        Me.txtCarta.MaxLength = 50
        Me.txtCarta.Name = "txtCarta"
        Me.txtCarta.Size = New System.Drawing.Size(310, 20)
        Me.txtCarta.TabIndex = 19
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(104, 136)
        Me.txtImporte.MaxLength = 30
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(120, 20)
        Me.txtImporte.TabIndex = 17
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtDescripcion.Location = New System.Drawing.Point(104, 101)
        Me.txtDescripcion.MandatoryColor = System.Drawing.Color.Empty
        Me.txtDescripcion.MandatoryField = False
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(310, 20)
        Me.txtDescripcion.TabIndex = 15
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
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Descripcion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Observaciones"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Carta Instruccion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Importe"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Codigo"
        '
        'cboDescuento
        '
        Me.cboDescuento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDescuento.FormattingEnabled = True
        Me.cboDescuento.Location = New System.Drawing.Point(103, 74)
        Me.cboDescuento.Name = "cboDescuento"
        Me.cboDescuento.Size = New System.Drawing.Size(201, 21)
        Me.cboDescuento.TabIndex = 23
        '
        'frmDescuentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 245)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboDescuento)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.txtCarta)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tsMantenimiento)
        Me.Controls.Add(Me.msMantenimiento)
        Me.Name = "frmDescuentos"
        Me.Text = "Descuentos"
        Me.msMantenimiento.ResumeLayout(False)
        Me.msMantenimiento.PerformLayout()
        Me.tsMantenimiento.ResumeLayout(False)
        Me.tsMantenimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msMantenimiento As System.Windows.Forms.MenuStrip
    Friend WithEvents MantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmGuardar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsMantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents txtCarta As System.Windows.Forms.TextBox
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As CUTextbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboDescuento As System.Windows.Forms.ComboBox
End Class
