<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class plancuentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(plancuentas))
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.tsMantenimiento = New System.Windows.Forms.ToolStrip()
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbModificar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.gpoDetalle = New System.Windows.Forms.GroupBox()
        Me.dgvMantenimiento = New System.Windows.Forms.DataGridView()
        Me.tbEditar = New System.Windows.Forms.TabPage()
        Me.txt0 = New System.Windows.Forms.TextBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.tsmSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmCancelar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbcEditar = New System.Windows.Forms.TabControl()
        Me.tsmGuardar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.msMantenimiento = New System.Windows.Forms.MenuStrip()
        Me.txtDescripcion = New CUTextbox()
        Me.tabladetid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.campo0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.campo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Campo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsMantenimiento.SuspendLayout()
        Me.gpoDetalle.SuspendLayout()
        CType(Me.dgvMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbEditar.SuspendLayout()
        Me.tbcEditar.SuspendLayout()
        Me.msMantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(93, 69)
        Me.txt2.MaxLength = 10
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(120, 20)
        Me.txt2.TabIndex = 3
        Me.txt2.Visible = False
        '
        'tsMantenimiento
        '
        Me.tsMantenimiento.BackColor = System.Drawing.SystemColors.Control
        Me.tsMantenimiento.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNuevo, Me.ToolStripSeparator3, Me.tsbModificar, Me.tsbEliminar, Me.ToolStripSeparator4, Me.tsbSalir})
        Me.tsMantenimiento.Location = New System.Drawing.Point(0, 24)
        Me.tsMantenimiento.Name = "tsMantenimiento"
        Me.tsMantenimiento.Size = New System.Drawing.Size(734, 39)
        Me.tsMantenimiento.TabIndex = 6
        Me.tsMantenimiento.Text = "ToolStrip1"
        '
        'tsbNuevo
        '
        Me.tsbNuevo.Image = CType(resources.GetObject("tsbNuevo.Image"), System.Drawing.Image)
        Me.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(74, 36)
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
        Me.tsbModificar.Size = New System.Drawing.Size(86, 36)
        Me.tsbModificar.Text = "Modificar"
        '
        'tsbEliminar
        '
        Me.tsbEliminar.Image = CType(resources.GetObject("tsbEliminar.Image"), System.Drawing.Image)
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(79, 36)
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
        Me.tsbSalir.Size = New System.Drawing.Size(63, 36)
        Me.tsbSalir.Text = "Salir"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(216, 3)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(120, 20)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.Visible = False
        '
        'gpoDetalle
        '
        Me.gpoDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoDetalle.BackColor = System.Drawing.Color.Transparent
        Me.gpoDetalle.Controls.Add(Me.dgvMantenimiento)
        Me.gpoDetalle.Location = New System.Drawing.Point(4, 66)
        Me.gpoDetalle.Name = "gpoDetalle"
        Me.gpoDetalle.Size = New System.Drawing.Size(722, 379)
        Me.gpoDetalle.TabIndex = 8
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
        Me.dgvMantenimiento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tabladetid, Me.campo0, Me.descri, Me.campo1, Me.Campo2})
        Me.dgvMantenimiento.Location = New System.Drawing.Point(6, 13)
        Me.dgvMantenimiento.Name = "dgvMantenimiento"
        Me.dgvMantenimiento.Size = New System.Drawing.Size(710, 360)
        Me.dgvMantenimiento.TabIndex = 0
        '
        'tbEditar
        '
        Me.tbEditar.Controls.Add(Me.txt0)
        Me.tbEditar.Controls.Add(Me.txt2)
        Me.tbEditar.Controls.Add(Me.txtCodigo)
        Me.tbEditar.Controls.Add(Me.txt1)
        Me.tbEditar.Controls.Add(Me.txtDescripcion)
        Me.tbEditar.Controls.Add(Me.Label3)
        Me.tbEditar.Controls.Add(Me.lbl2)
        Me.tbEditar.Controls.Add(Me.lbl1)
        Me.tbEditar.Controls.Add(Me.Label2)
        Me.tbEditar.Controls.Add(Me.btnCancelar)
        Me.tbEditar.Controls.Add(Me.btnGuardar)
        Me.tbEditar.Location = New System.Drawing.Point(4, 22)
        Me.tbEditar.Name = "tbEditar"
        Me.tbEditar.Padding = New System.Windows.Forms.Padding(3)
        Me.tbEditar.Size = New System.Drawing.Size(524, 317)
        Me.tbEditar.TabIndex = 0
        Me.tbEditar.Text = "Editando Registro"
        Me.tbEditar.UseVisualStyleBackColor = True
        '
        'txt0
        '
        Me.txt0.Location = New System.Drawing.Point(93, 3)
        Me.txt0.MaxLength = 10
        Me.txt0.Name = "txt0"
        Me.txt0.Size = New System.Drawing.Size(120, 20)
        Me.txt0.TabIndex = 0
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(93, 47)
        Me.txt1.MaxLength = 10
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(120, 20)
        Me.txt1.TabIndex = 2
        Me.txt1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripcion"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(13, 76)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(70, 13)
        Me.lbl2.TabIndex = 8
        Me.lbl2.Text = "Contrapartida"
        Me.lbl2.Visible = False
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(13, 54)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(43, 13)
        Me.lbl1.TabIndex = 4
        Me.lbl1.Text = "Destino"
        Me.lbl1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cuenta"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(417, 273)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(102, 38)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(278, 273)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(94, 41)
        Me.btnGuardar.TabIndex = 22
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'tsmSalir
        '
        Me.tsmSalir.Image = CType(resources.GetObject("tsmSalir.Image"), System.Drawing.Image)
        Me.tsmSalir.Name = "tsmSalir"
        Me.tsmSalir.Size = New System.Drawing.Size(163, 22)
        Me.tsmSalir.Text = "Salir"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(160, 6)
        '
        'tsmCancelar
        '
        Me.tsmCancelar.Enabled = False
        Me.tsmCancelar.Image = CType(resources.GetObject("tsmCancelar.Image"), System.Drawing.Image)
        Me.tsmCancelar.Name = "tsmCancelar"
        Me.tsmCancelar.Size = New System.Drawing.Size(163, 22)
        Me.tsmCancelar.Text = "Cancelar"
        '
        'tbcEditar
        '
        Me.tbcEditar.Controls.Add(Me.tbEditar)
        Me.tbcEditar.Location = New System.Drawing.Point(184, 88)
        Me.tbcEditar.Name = "tbcEditar"
        Me.tbcEditar.SelectedIndex = 0
        Me.tbcEditar.Size = New System.Drawing.Size(532, 343)
        Me.tbcEditar.TabIndex = 5
        Me.tbcEditar.Visible = False
        '
        'tsmGuardar
        '
        Me.tsmGuardar.Enabled = False
        Me.tsmGuardar.Image = CType(resources.GetObject("tsmGuardar.Image"), System.Drawing.Image)
        Me.tsmGuardar.Name = "tsmGuardar"
        Me.tsmGuardar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.tsmGuardar.Size = New System.Drawing.Size(163, 22)
        Me.tsmGuardar.Text = "Guardar"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmNuevo, Me.tsmModificar, Me.tsmEliminar, Me.ToolStripSeparator1, Me.tsmGuardar, Me.tsmCancelar, Me.ToolStripSeparator5, Me.tsmSalir})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'tsmNuevo
        '
        Me.tsmNuevo.Image = CType(resources.GetObject("tsmNuevo.Image"), System.Drawing.Image)
        Me.tsmNuevo.Name = "tsmNuevo"
        Me.tsmNuevo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.tsmNuevo.Size = New System.Drawing.Size(163, 22)
        Me.tsmNuevo.Text = "Nuevo"
        '
        'tsmModificar
        '
        Me.tsmModificar.Image = CType(resources.GetObject("tsmModificar.Image"), System.Drawing.Image)
        Me.tsmModificar.Name = "tsmModificar"
        Me.tsmModificar.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.tsmModificar.Size = New System.Drawing.Size(163, 22)
        Me.tsmModificar.Text = "Modificar"
        '
        'tsmEliminar
        '
        Me.tsmEliminar.Image = CType(resources.GetObject("tsmEliminar.Image"), System.Drawing.Image)
        Me.tsmEliminar.Name = "tsmEliminar"
        Me.tsmEliminar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.tsmEliminar.Size = New System.Drawing.Size(163, 22)
        Me.tsmEliminar.Text = "Eliminar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(160, 6)
        '
        'msMantenimiento
        '
        Me.msMantenimiento.BackColor = System.Drawing.SystemColors.Control
        Me.msMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoToolStripMenuItem})
        Me.msMantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.msMantenimiento.Name = "msMantenimiento"
        Me.msMantenimiento.Size = New System.Drawing.Size(734, 24)
        Me.msMantenimiento.TabIndex = 4
        Me.msMantenimiento.Text = "MenuStrip1"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtDescripcion.Location = New System.Drawing.Point(93, 25)
        Me.txtDescripcion.MandatoryColor = System.Drawing.Color.Empty
        Me.txtDescripcion.MandatoryField = False
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(407, 20)
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
        '
        'tabladetid
        '
        Me.tabladetid.DataPropertyName = "tabladetid"
        Me.tabladetid.HeaderText = "tabladetid"
        Me.tabladetid.Name = "tabladetid"
        Me.tabladetid.Visible = False
        '
        'campo0
        '
        Me.campo0.DataPropertyName = "campo0"
        Me.campo0.HeaderText = "Cuenta"
        Me.campo0.Name = "campo0"
        '
        'descri
        '
        Me.descri.DataPropertyName = "descri"
        Me.descri.HeaderText = "Descripcion"
        Me.descri.Name = "descri"
        Me.descri.Width = 200
        '
        'campo1
        '
        Me.campo1.DataPropertyName = "campo1"
        Me.campo1.HeaderText = "Destino"
        Me.campo1.Name = "campo1"
        '
        'Campo2
        '
        Me.Campo2.DataPropertyName = "Campo2"
        Me.Campo2.HeaderText = "Contrapartida"
        Me.Campo2.Name = "Campo2"
        '
        'plancuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 447)
        Me.Controls.Add(Me.tsMantenimiento)
        Me.Controls.Add(Me.tbcEditar)
        Me.Controls.Add(Me.msMantenimiento)
        Me.Controls.Add(Me.gpoDetalle)
        Me.KeyPreview = True
        Me.Name = "plancuentas"
        Me.Text = "Mantenimiento de Plan de Cuentas"
        Me.tsMantenimiento.ResumeLayout(False)
        Me.tsMantenimiento.PerformLayout()
        Me.gpoDetalle.ResumeLayout(False)
        CType(Me.dgvMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbEditar.ResumeLayout(False)
        Me.tbEditar.PerformLayout()
        Me.tbcEditar.ResumeLayout(False)
        Me.msMantenimiento.ResumeLayout(False)
        Me.msMantenimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents tsMantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents gpoDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents tbEditar As System.Windows.Forms.TabPage
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As CUTextbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents tsmSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmCancelar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbcEditar As System.Windows.Forms.TabControl
    Friend WithEvents tsmGuardar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents msMantenimiento As System.Windows.Forms.MenuStrip
    Friend WithEvents dgvMantenimiento As System.Windows.Forms.DataGridView
    Friend WithEvents txt0 As System.Windows.Forms.TextBox
    Friend WithEvents tabladetid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents campo0 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descri As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents campo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Campo2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
