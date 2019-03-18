<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calcularLote
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(calcularLote))
        Me.pgbLote1 = New System.Windows.Forms.ProgressBar()
        Me.lblLote1 = New System.Windows.Forms.Label()
        Me.pgbLote2 = New System.Windows.Forms.ProgressBar()
        Me.lblLote2 = New System.Windows.Forms.Label()
        Me.pgbLote3 = New System.Windows.Forms.ProgressBar()
        Me.lblLote3 = New System.Windows.Forms.Label()
        Me.pgbLote4 = New System.Windows.Forms.ProgressBar()
        Me.lblLote4 = New System.Windows.Forms.Label()
        Me.pgbLote5 = New System.Windows.Forms.ProgressBar()
        Me.lblLote5 = New System.Windows.Forms.Label()
        Me.pgbLote6 = New System.Windows.Forms.ProgressBar()
        Me.lblLote6 = New System.Windows.Forms.Label()
        Me.gbt = New System.Windows.Forms.GroupBox()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsmProcesar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.gbt.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pgbLote1
        '
        Me.pgbLote1.Location = New System.Drawing.Point(133, 27)
        Me.pgbLote1.Name = "pgbLote1"
        Me.pgbLote1.Size = New System.Drawing.Size(153, 23)
        Me.pgbLote1.TabIndex = 0
        '
        'lblLote1
        '
        Me.lblLote1.AutoSize = True
        Me.lblLote1.Location = New System.Drawing.Point(9, 27)
        Me.lblLote1.Name = "lblLote1"
        Me.lblLote1.Size = New System.Drawing.Size(101, 13)
        Me.lblLote1.TabIndex = 2
        Me.lblLote1.Text = "Calculando Lotes ..."
        '
        'pgbLote2
        '
        Me.pgbLote2.Location = New System.Drawing.Point(133, 56)
        Me.pgbLote2.Name = "pgbLote2"
        Me.pgbLote2.Size = New System.Drawing.Size(153, 23)
        Me.pgbLote2.TabIndex = 0
        Me.pgbLote2.Visible = False
        '
        'lblLote2
        '
        Me.lblLote2.AutoSize = True
        Me.lblLote2.Location = New System.Drawing.Point(9, 56)
        Me.lblLote2.Name = "lblLote2"
        Me.lblLote2.Size = New System.Drawing.Size(69, 13)
        Me.lblLote2.TabIndex = 2
        Me.lblLote2.Text = "Calculando 2"
        Me.lblLote2.Visible = False
        '
        'pgbLote3
        '
        Me.pgbLote3.Location = New System.Drawing.Point(133, 85)
        Me.pgbLote3.Name = "pgbLote3"
        Me.pgbLote3.Size = New System.Drawing.Size(153, 23)
        Me.pgbLote3.TabIndex = 0
        Me.pgbLote3.Visible = False
        '
        'lblLote3
        '
        Me.lblLote3.AutoSize = True
        Me.lblLote3.Location = New System.Drawing.Point(9, 85)
        Me.lblLote3.Name = "lblLote3"
        Me.lblLote3.Size = New System.Drawing.Size(69, 13)
        Me.lblLote3.TabIndex = 2
        Me.lblLote3.Text = "Calculando 3"
        Me.lblLote3.Visible = False
        '
        'pgbLote4
        '
        Me.pgbLote4.Location = New System.Drawing.Point(133, 114)
        Me.pgbLote4.Name = "pgbLote4"
        Me.pgbLote4.Size = New System.Drawing.Size(153, 23)
        Me.pgbLote4.TabIndex = 0
        Me.pgbLote4.Visible = False
        '
        'lblLote4
        '
        Me.lblLote4.AutoSize = True
        Me.lblLote4.Location = New System.Drawing.Point(9, 114)
        Me.lblLote4.Name = "lblLote4"
        Me.lblLote4.Size = New System.Drawing.Size(69, 13)
        Me.lblLote4.TabIndex = 2
        Me.lblLote4.Text = "Calculando 4"
        Me.lblLote4.Visible = False
        '
        'pgbLote5
        '
        Me.pgbLote5.Location = New System.Drawing.Point(133, 143)
        Me.pgbLote5.Name = "pgbLote5"
        Me.pgbLote5.Size = New System.Drawing.Size(153, 23)
        Me.pgbLote5.TabIndex = 0
        Me.pgbLote5.Visible = False
        '
        'lblLote5
        '
        Me.lblLote5.AutoSize = True
        Me.lblLote5.Location = New System.Drawing.Point(9, 143)
        Me.lblLote5.Name = "lblLote5"
        Me.lblLote5.Size = New System.Drawing.Size(69, 13)
        Me.lblLote5.TabIndex = 2
        Me.lblLote5.Text = "Calculando 5"
        Me.lblLote5.Visible = False
        '
        'pgbLote6
        '
        Me.pgbLote6.Location = New System.Drawing.Point(133, 172)
        Me.pgbLote6.Name = "pgbLote6"
        Me.pgbLote6.Size = New System.Drawing.Size(153, 23)
        Me.pgbLote6.TabIndex = 0
        Me.pgbLote6.Visible = False
        '
        'lblLote6
        '
        Me.lblLote6.AutoSize = True
        Me.lblLote6.Location = New System.Drawing.Point(9, 172)
        Me.lblLote6.Name = "lblLote6"
        Me.lblLote6.Size = New System.Drawing.Size(69, 13)
        Me.lblLote6.TabIndex = 2
        Me.lblLote6.Text = "Calculando 6"
        Me.lblLote6.Visible = False
        '
        'gbt
        '
        Me.gbt.Controls.Add(Me.pgbLote1)
        Me.gbt.Controls.Add(Me.pgbLote2)
        Me.gbt.Controls.Add(Me.pgbLote3)
        Me.gbt.Controls.Add(Me.pgbLote4)
        Me.gbt.Controls.Add(Me.pgbLote5)
        Me.gbt.Controls.Add(Me.pgbLote6)
        Me.gbt.Controls.Add(Me.lblLote1)
        Me.gbt.Controls.Add(Me.lblLote2)
        Me.gbt.Controls.Add(Me.lblLote3)
        Me.gbt.Controls.Add(Me.lblLote4)
        Me.gbt.Controls.Add(Me.lblLote5)
        Me.gbt.Controls.Add(Me.lblMensaje)
        Me.gbt.Controls.Add(Me.lblLote6)
        Me.gbt.Location = New System.Drawing.Point(8, 46)
        Me.gbt.Name = "gbt"
        Me.gbt.Size = New System.Drawing.Size(300, 233)
        Me.gbt.TabIndex = 4
        Me.gbt.TabStop = False
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Location = New System.Drawing.Point(19, 206)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(252, 15)
        Me.lblMensaje.TabIndex = 2
        Me.lblMensaje.Text = "La carga se realizo satisfactoriamente"
        Me.lblMensaje.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmProcesar, Me.tsbSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(315, 39)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsmProcesar
        '
        Me.tsmProcesar.Image = Global.My.Resources.Resources.aprobar
        Me.tsmProcesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmProcesar.Name = "tsmProcesar"
        Me.tsmProcesar.Size = New System.Drawing.Size(91, 36)
        Me.tsmProcesar.Text = "Procesar "
        '
        'tsbSalir
        '
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(65, 36)
        Me.tsbSalir.Text = "Salir"
        '
        'calcularLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(315, 291)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.gbt)
        Me.Name = "calcularLote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga Lotes"
        Me.gbt.ResumeLayout(False)
        Me.gbt.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pgbLote1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblLote1 As System.Windows.Forms.Label
    Friend WithEvents pgbLote2 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblLote2 As System.Windows.Forms.Label
    Friend WithEvents pgbLote3 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblLote3 As System.Windows.Forms.Label
    Friend WithEvents pgbLote4 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblLote4 As System.Windows.Forms.Label
    Friend WithEvents pgbLote5 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblLote5 As System.Windows.Forms.Label
    Friend WithEvents pgbLote6 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblLote6 As System.Windows.Forms.Label
    Friend WithEvents gbt As System.Windows.Forms.GroupBox
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsmProcesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
End Class
