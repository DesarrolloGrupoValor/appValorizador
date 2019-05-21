<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstadisticaVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EstadisticaVenta))
        Me.gpoContratos = New CUGroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rbTMNS = New System.Windows.Forms.RadioButton()
        Me.rbTMH = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboMesDestino = New System.Windows.Forms.ComboBox()
        Me.cboMesOrigen = New System.Windows.Forms.ComboBox()
        Me.cboAnioDestino = New System.Windows.Forms.ComboBox()
        Me.cboAnioOrigen = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboMesFin2 = New System.Windows.Forms.ComboBox()
        Me.cboMesInicio2 = New System.Windows.Forms.ComboBox()
        Me.btnXanio = New System.Windows.Forms.Button()
        Me.cboAnio = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnComparativo = New System.Windows.Forms.Button()
        Me.cboMesFin1 = New System.Windows.Forms.ComboBox()
        Me.cboMesInicio1 = New System.Windows.Forms.ComboBox()
        Me.cboAnioFin = New System.Windows.Forms.ComboBox()
        Me.cboAnioInicio = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rptReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CuGroupBox2 = New CUGroupBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.tsMantenimiento = New System.Windows.Forms.ToolStrip()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.gpoContratos.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.CuGroupBox2.SuspendLayout()
        Me.tsMantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpoContratos
        '
        Me.gpoContratos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoContratos.BackColor = System.Drawing.Color.LemonChiffon
        Me.gpoContratos.BorderColor = System.Drawing.Color.Black
        Me.gpoContratos.Controls.Add(Me.GroupBox5)
        Me.gpoContratos.Controls.Add(Me.GroupBox4)
        Me.gpoContratos.Controls.Add(Me.GroupBox2)
        Me.gpoContratos.Controls.Add(Me.GroupBox3)
        Me.gpoContratos.Controls.Add(Me.GroupBox1)
        Me.gpoContratos.Controls.Add(Me.CuGroupBox2)
        Me.gpoContratos.Location = New System.Drawing.Point(-201, -37)
        Me.gpoContratos.Name = "gpoContratos"
        Me.gpoContratos.Size = New System.Drawing.Size(1675, 485)
        Me.gpoContratos.TabIndex = 16
        Me.gpoContratos.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rbTMNS)
        Me.GroupBox5.Controls.Add(Me.rbTMH)
        Me.GroupBox5.Location = New System.Drawing.Point(206, 91)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(77, 78)
        Me.GroupBox5.TabIndex = 28
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Seleccionar"
        '
        'rbTMNS
        '
        Me.rbTMNS.AutoSize = True
        Me.rbTMNS.Location = New System.Drawing.Point(7, 44)
        Me.rbTMNS.Name = "rbTMNS"
        Me.rbTMNS.Size = New System.Drawing.Size(51, 17)
        Me.rbTMNS.TabIndex = 1
        Me.rbTMNS.Text = "Tmns"
        Me.rbTMNS.UseVisualStyleBackColor = True
        '
        'rbTMH
        '
        Me.rbTMH.AutoSize = True
        Me.rbTMH.Checked = True
        Me.rbTMH.Location = New System.Drawing.Point(7, 19)
        Me.rbTMH.Name = "rbTMH"
        Me.rbTMH.Size = New System.Drawing.Size(46, 17)
        Me.rbTMH.TabIndex = 0
        Me.rbTMH.TabStop = True
        Me.rbTMH.Text = "Tmh"
        Me.rbTMH.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.cboMesDestino)
        Me.GroupBox4.Controls.Add(Me.cboMesOrigen)
        Me.GroupBox4.Controls.Add(Me.cboAnioDestino)
        Me.GroupBox4.Controls.Add(Me.cboAnioOrigen)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.btnExcel)
        Me.GroupBox4.Controls.Add(Me.btnProcesar)
        Me.GroupBox4.Location = New System.Drawing.Point(1107, 91)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(439, 78)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "3. Reporte Ventas Consolidado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Seleccione rango de meses"
        '
        'cboMesDestino
        '
        Me.cboMesDestino.FormattingEnabled = True
        Me.cboMesDestino.Location = New System.Drawing.Point(246, 46)
        Me.cboMesDestino.Name = "cboMesDestino"
        Me.cboMesDestino.Size = New System.Drawing.Size(90, 21)
        Me.cboMesDestino.TabIndex = 28
        '
        'cboMesOrigen
        '
        Me.cboMesOrigen.FormattingEnabled = True
        Me.cboMesOrigen.Location = New System.Drawing.Point(150, 48)
        Me.cboMesOrigen.Name = "cboMesOrigen"
        Me.cboMesOrigen.Size = New System.Drawing.Size(90, 21)
        Me.cboMesOrigen.TabIndex = 30
        '
        'cboAnioDestino
        '
        Me.cboAnioDestino.FormattingEnabled = True
        Me.cboAnioDestino.Location = New System.Drawing.Point(246, 21)
        Me.cboAnioDestino.Name = "cboAnioDestino"
        Me.cboAnioDestino.Size = New System.Drawing.Size(90, 21)
        Me.cboAnioDestino.TabIndex = 27
        '
        'cboAnioOrigen
        '
        Me.cboAnioOrigen.FormattingEnabled = True
        Me.cboAnioOrigen.Location = New System.Drawing.Point(150, 21)
        Me.cboAnioOrigen.Name = "cboAnioOrigen"
        Me.cboAnioOrigen.Size = New System.Drawing.Size(90, 21)
        Me.cboAnioOrigen.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Seleccione rango de años"
        '
        'btnExcel
        '
        Me.btnExcel.BackgroundImage = Global.My.Resources.Resources.consultar
        Me.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExcel.Location = New System.Drawing.Point(342, 40)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(90, 30)
        Me.btnExcel.TabIndex = 23
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnProcesar
        '
        Me.btnProcesar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnProcesar.Image = Global.My.Resources.Resources.procesar
        Me.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProcesar.Location = New System.Drawing.Point(342, 9)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(90, 30)
        Me.btnProcesar.TabIndex = 23
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cboMesFin2)
        Me.GroupBox2.Controls.Add(Me.cboMesInicio2)
        Me.GroupBox2.Controls.Add(Me.btnXanio)
        Me.GroupBox2.Controls.Add(Me.cboAnio)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(693, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(408, 78)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "2. Reporte de Ventas por Año"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Seleccione rango de meses"
        '
        'cboMesFin2
        '
        Me.cboMesFin2.FormattingEnabled = True
        Me.cboMesFin2.Location = New System.Drawing.Point(246, 44)
        Me.cboMesFin2.Name = "cboMesFin2"
        Me.cboMesFin2.Size = New System.Drawing.Size(90, 21)
        Me.cboMesFin2.TabIndex = 25
        '
        'cboMesInicio2
        '
        Me.cboMesInicio2.FormattingEnabled = True
        Me.cboMesInicio2.Location = New System.Drawing.Point(150, 44)
        Me.cboMesInicio2.Name = "cboMesInicio2"
        Me.cboMesInicio2.Size = New System.Drawing.Size(90, 21)
        Me.cboMesInicio2.TabIndex = 26
        '
        'btnXanio
        '
        Me.btnXanio.BackgroundImage = Global.My.Resources.Resources.consultar
        Me.btnXanio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnXanio.Location = New System.Drawing.Point(342, 17)
        Me.btnXanio.Name = "btnXanio"
        Me.btnXanio.Size = New System.Drawing.Size(60, 50)
        Me.btnXanio.TabIndex = 23
        Me.btnXanio.UseVisualStyleBackColor = True
        '
        'cboAnio
        '
        Me.cboAnio.FormattingEnabled = True
        Me.cboAnio.Location = New System.Drawing.Point(150, 17)
        Me.cboAnio.Name = "cboAnio"
        Me.cboAnio.Size = New System.Drawing.Size(90, 21)
        Me.cboAnio.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Seleccione año"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.btnComparativo)
        Me.GroupBox3.Controls.Add(Me.cboMesFin1)
        Me.GroupBox3.Controls.Add(Me.cboMesInicio1)
        Me.GroupBox3.Controls.Add(Me.cboAnioFin)
        Me.GroupBox3.Controls.Add(Me.cboAnioInicio)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(289, 91)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 78)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "1. Reporte de Ventas comparativos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Seleccione rango de meses"
        '
        'btnComparativo
        '
        Me.btnComparativo.BackgroundImage = Global.My.Resources.Resources.consultar
        Me.btnComparativo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnComparativo.Location = New System.Drawing.Point(338, 19)
        Me.btnComparativo.Name = "btnComparativo"
        Me.btnComparativo.Size = New System.Drawing.Size(60, 50)
        Me.btnComparativo.TabIndex = 23
        Me.btnComparativo.UseVisualStyleBackColor = True
        '
        'cboMesFin1
        '
        Me.cboMesFin1.FormattingEnabled = True
        Me.cboMesFin1.Location = New System.Drawing.Point(242, 46)
        Me.cboMesFin1.Name = "cboMesFin1"
        Me.cboMesFin1.Size = New System.Drawing.Size(90, 21)
        Me.cboMesFin1.TabIndex = 23
        '
        'cboMesInicio1
        '
        Me.cboMesInicio1.FormattingEnabled = True
        Me.cboMesInicio1.Location = New System.Drawing.Point(146, 46)
        Me.cboMesInicio1.Name = "cboMesInicio1"
        Me.cboMesInicio1.Size = New System.Drawing.Size(90, 21)
        Me.cboMesInicio1.TabIndex = 24
        '
        'cboAnioFin
        '
        Me.cboAnioFin.FormattingEnabled = True
        Me.cboAnioFin.Location = New System.Drawing.Point(242, 19)
        Me.cboAnioFin.Name = "cboAnioFin"
        Me.cboAnioFin.Size = New System.Drawing.Size(90, 21)
        Me.cboAnioFin.TabIndex = 23
        '
        'cboAnioInicio
        '
        Me.cboAnioInicio.FormattingEnabled = True
        Me.cboAnioInicio.Location = New System.Drawing.Point(146, 19)
        Me.cboAnioInicio.Name = "cboAnioInicio"
        Me.cboAnioInicio.Size = New System.Drawing.Size(90, 21)
        Me.cboAnioInicio.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Seleccione rango de años"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.rptReportViewer)
        Me.GroupBox1.Location = New System.Drawing.Point(206, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1262, 275)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'rptReportViewer
        '
        Me.rptReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptReportViewer.Location = New System.Drawing.Point(3, 16)
        Me.rptReportViewer.Name = "rptReportViewer"
        Me.rptReportViewer.Size = New System.Drawing.Size(1256, 256)
        Me.rptReportViewer.TabIndex = 0
        '
        'CuGroupBox2
        '
        Me.CuGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CuGroupBox2.BorderColor = System.Drawing.Color.Black
        Me.CuGroupBox2.Controls.Add(Me.lblTitulo)
        Me.CuGroupBox2.Controls.Add(Me.tsMantenimiento)
        Me.CuGroupBox2.Location = New System.Drawing.Point(199, 22)
        Me.CuGroupBox2.Name = "CuGroupBox2"
        Me.CuGroupBox2.Size = New System.Drawing.Size(1272, 63)
        Me.CuGroupBox2.TabIndex = 17
        Me.CuGroupBox2.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(382, 23)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(223, 17)
        Me.lblTitulo.TabIndex = 25
        Me.lblTitulo.Text = "Reporte: Estadísticas Comerciales"
        '
        'tsMantenimiento
        '
        Me.tsMantenimiento.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbSalir})
        Me.tsMantenimiento.Location = New System.Drawing.Point(3, 16)
        Me.tsMantenimiento.Name = "tsMantenimiento"
        Me.tsMantenimiento.Size = New System.Drawing.Size(1266, 39)
        Me.tsMantenimiento.TabIndex = 23
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
        'EstadisticaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 411)
        Me.Controls.Add(Me.gpoContratos)
        Me.Name = "EstadisticaVenta"
        Me.Text = "Estadísticas Comerciales"
        Me.gpoContratos.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.CuGroupBox2.ResumeLayout(False)
        Me.CuGroupBox2.PerformLayout()
        Me.tsMantenimiento.ResumeLayout(False)
        Me.tsMantenimiento.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpoContratos As CUGroupBox
    Friend WithEvents CuGroupBox2 As CUGroupBox
    Friend WithEvents tsMantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rptReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboAnio As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboAnioFin As System.Windows.Forms.ComboBox
    Friend WithEvents cboAnioInicio As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnXanio As System.Windows.Forms.Button
    Friend WithEvents btnComparativo As System.Windows.Forms.Button
    Friend WithEvents cboMesFin2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboMesInicio2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboMesFin1 As System.Windows.Forms.ComboBox
    Friend WithEvents cboMesInicio1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboMesDestino As System.Windows.Forms.ComboBox
    Friend WithEvents cboMesOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents cboAnioDestino As System.Windows.Forms.ComboBox
    Friend WithEvents cboAnioOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTMNS As System.Windows.Forms.RadioButton
    Friend WithEvents rbTMH As System.Windows.Forms.RadioButton
End Class
