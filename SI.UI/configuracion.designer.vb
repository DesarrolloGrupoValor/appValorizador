<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class configuracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(configuracion))
        Me.msMantenimiento = New System.Windows.Forms.MenuStrip()
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsMantenimiento = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.gpoConfigura = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.msMantenimiento.SuspendLayout()
        Me.tsMantenimiento.SuspendLayout()
        Me.gpoConfigura.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMantenimiento
        '
        Me.msMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguracionToolStripMenuItem})
        Me.msMantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.msMantenimiento.Name = "msMantenimiento"
        Me.msMantenimiento.Size = New System.Drawing.Size(456, 24)
        Me.msMantenimiento.TabIndex = 0
        Me.msMantenimiento.Text = "MenuStrip1"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.ConfiguracionToolStripMenuItem.Text = "Configuracion"
        '
        'tsMantenimiento
        '
        Me.tsMantenimiento.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsMantenimiento.Location = New System.Drawing.Point(0, 24)
        Me.tsMantenimiento.Name = "tsMantenimiento"
        Me.tsMantenimiento.Size = New System.Drawing.Size(456, 39)
        Me.tsMantenimiento.TabIndex = 1
        Me.tsMantenimiento.Text = "ToolStrip1"
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
        'tsbSalir
        '
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(36, 36)
        Me.tsbSalir.Text = "Salir"
        '
        'gpoConfigura
        '
        Me.gpoConfigura.Controls.Add(Me.Label1)
        Me.gpoConfigura.Controls.Add(Me.lblColor)
        Me.gpoConfigura.Location = New System.Drawing.Point(12, 66)
        Me.gpoConfigura.Name = "gpoConfigura"
        Me.gpoConfigura.Size = New System.Drawing.Size(440, 55)
        Me.gpoConfigura.TabIndex = 2
        Me.gpoConfigura.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Color de Fondo Formularios"
        '
        'lblColor
        '
        Me.lblColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblColor.Location = New System.Drawing.Point(180, 16)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(100, 23)
        Me.lblColor.TabIndex = 4
        '
        'configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 133)
        Me.ControlBox = False
        Me.Controls.Add(Me.gpoConfigura)
        Me.Controls.Add(Me.tsMantenimiento)
        Me.Controls.Add(Me.msMantenimiento)
        Me.MainMenuStrip = Me.msMantenimiento
        Me.Name = "configuracion"
        Me.Text = "configuracion"
        Me.msMantenimiento.ResumeLayout(False)
        Me.msMantenimiento.PerformLayout()
        Me.tsMantenimiento.ResumeLayout(False)
        Me.tsMantenimiento.PerformLayout()
        Me.gpoConfigura.ResumeLayout(False)
        Me.gpoConfigura.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msMantenimiento As System.Windows.Forms.MenuStrip
    Friend WithEvents tsMantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents ConfiguracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents gpoConfigura As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblColor As System.Windows.Forms.Label
End Class
