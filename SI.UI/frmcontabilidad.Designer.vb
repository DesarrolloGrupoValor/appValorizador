<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcontabilidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcontabilidad))
        Me.tsMantenimiento = New System.Windows.Forms.ToolStrip()
        Me.tsbProcesar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbExportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbGenerarPreLiq = New System.Windows.Forms.ToolStripButton()
        Me.tssbValidaciones = New System.Windows.Forms.ToolStripSplitButton()
        Me.tsmValida1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmValida2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmValida3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmValida4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmValida5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.cboEmpresa = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblperiodo = New System.Windows.Forms.Label()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.sfDialog = New System.Windows.Forms.SaveFileDialog()
        Me.cboTipoContrato = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox()
        Me.btnEliminarAsientoPeriodo = New System.Windows.Forms.Button()
        Me.btnVerificarCONCAR = New System.Windows.Forms.Button()
        Me.Clbclases = New System.Windows.Forms.CheckedListBox()
        Me.gpoContratos = New CUGroupBox()
        Me.fxgrdContabilidad = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tsMantenimiento.SuspendLayout()
        Me.gpoContratos.SuspendLayout()
        CType(Me.fxgrdContabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMantenimiento
        '
        Me.tsMantenimiento.BackColor = System.Drawing.Color.LemonChiffon
        Me.tsMantenimiento.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbProcesar, Me.ToolStripSeparator3, Me.tsbExportar, Me.ToolStripSeparator4, Me.tsbGenerarPreLiq, Me.tssbValidaciones, Me.tsbSalir})
        Me.tsMantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.tsMantenimiento.Name = "tsMantenimiento"
        Me.tsMantenimiento.Size = New System.Drawing.Size(1161, 39)
        Me.tsMantenimiento.TabIndex = 14
        Me.tsMantenimiento.Text = "ToolStrip1"
        '
        'tsbProcesar
        '
        Me.tsbProcesar.Enabled = False
        Me.tsbProcesar.Image = CType(resources.GetObject("tsbProcesar.Image"), System.Drawing.Image)
        Me.tsbProcesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbProcesar.Name = "tsbProcesar"
        Me.tsbProcesar.Size = New System.Drawing.Size(88, 36)
        Me.tsbProcesar.Text = "Procesar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'tsbExportar
        '
        Me.tsbExportar.Enabled = False
        Me.tsbExportar.Image = CType(resources.GetObject("tsbExportar.Image"), System.Drawing.Image)
        Me.tsbExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportar.Name = "tsbExportar"
        Me.tsbExportar.Size = New System.Drawing.Size(86, 36)
        Me.tsbExportar.Text = "Exportar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'tsbGenerarPreLiq
        '
        Me.tsbGenerarPreLiq.Image = Global.My.Resources.Resources.procesar
        Me.tsbGenerarPreLiq.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGenerarPreLiq.Name = "tsbGenerarPreLiq"
        Me.tsbGenerarPreLiq.Size = New System.Drawing.Size(182, 36)
        Me.tsbGenerarPreLiq.Text = "Generar Pre-Liquidaciones"
        '
        'tssbValidaciones
        '
        Me.tssbValidaciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmValida1, Me.tsmValida2, Me.tsmValida3, Me.tsmValida4, Me.tsmValida5})
        Me.tssbValidaciones.Image = Global.My.Resources.Resources.aprobar
        Me.tssbValidaciones.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssbValidaciones.Name = "tssbValidaciones"
        Me.tssbValidaciones.Size = New System.Drawing.Size(120, 36)
        Me.tssbValidaciones.Text = "Validaciones"
        '
        'tsmValida1
        '
        Me.tsmValida1.Image = Global.My.Resources.Resources.nuevo
        Me.tsmValida1.Name = "tsmValida1"
        Me.tsmValida1.Size = New System.Drawing.Size(253, 38)
        Me.tsmValida1.Text = "1. Rumas Pendientes de Lotizar"
        '
        'tsmValida2
        '
        Me.tsmValida2.Image = Global.My.Resources.Resources.nuevo
        Me.tsmValida2.Name = "tsmValida2"
        Me.tsmValida2.Size = New System.Drawing.Size(253, 38)
        Me.tsmValida2.Text = "2. Valida Ventas TMH"
        '
        'tsmValida3
        '
        Me.tsmValida3.Image = Global.My.Resources.Resources.nuevo
        Me.tsmValida3.Name = "tsmValida3"
        Me.tsmValida3.Size = New System.Drawing.Size(253, 38)
        Me.tsmValida3.Text = "3. Cuadre Mezclas"
        '
        'tsmValida4
        '
        Me.tsmValida4.Image = Global.My.Resources.Resources.nuevo
        Me.tsmValida4.Name = "tsmValida4"
        Me.tsmValida4.Size = New System.Drawing.Size(253, 38)
        Me.tsmValida4.Text = "4. Valida Saldo Final"
        '
        'tsmValida5
        '
        Me.tsmValida5.Image = Global.My.Resources.Resources.nuevo
        Me.tsmValida5.Name = "tsmValida5"
        Me.tsmValida5.Size = New System.Drawing.Size(253, 38)
        Me.tsmValida5.Text = "5. Mayorización de Asientos"
        '
        'tsbSalir
        '
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(65, 36)
        Me.tsbSalir.Text = "Salir"
        '
        'cboEmpresa
        '
        Me.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.Location = New System.Drawing.Point(81, 46)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(127, 21)
        Me.cboEmpresa.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Empresa"
        '
        'lblperiodo
        '
        Me.lblperiodo.AutoSize = True
        Me.lblperiodo.Location = New System.Drawing.Point(457, 49)
        Me.lblperiodo.Name = "lblperiodo"
        Me.lblperiodo.Size = New System.Drawing.Size(49, 13)
        Me.lblperiodo.TabIndex = 18
        Me.lblperiodo.Text = "Periodo :"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(647, 44)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltrar.TabIndex = 20
        Me.btnFiltrar.Text = "Previo"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'cboTipoContrato
        '
        Me.cboTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoContrato.FormattingEnabled = True
        Me.cboTipoContrato.Location = New System.Drawing.Point(316, 46)
        Me.cboTipoContrato.Name = "cboTipoContrato"
        Me.cboTipoContrato.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoContrato.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(229, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Tipo de Asiento"
        '
        'cboPeriodo
        '
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.Location = New System.Drawing.Point(512, 46)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(121, 21)
        Me.cboPeriodo.TabIndex = 24
        '
        'btnEliminarAsientoPeriodo
        '
        Me.btnEliminarAsientoPeriodo.Location = New System.Drawing.Point(728, 44)
        Me.btnEliminarAsientoPeriodo.Name = "btnEliminarAsientoPeriodo"
        Me.btnEliminarAsientoPeriodo.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarAsientoPeriodo.TabIndex = 25
        Me.btnEliminarAsientoPeriodo.Text = "Eliminar"
        Me.btnEliminarAsientoPeriodo.UseVisualStyleBackColor = True
        '
        'btnVerificarCONCAR
        '
        Me.btnVerificarCONCAR.Location = New System.Drawing.Point(809, 44)
        Me.btnVerificarCONCAR.Name = "btnVerificarCONCAR"
        Me.btnVerificarCONCAR.Size = New System.Drawing.Size(158, 23)
        Me.btnVerificarCONCAR.TabIndex = 26
        Me.btnVerificarCONCAR.Text = "Verificar cambios vs CONCAR"
        Me.btnVerificarCONCAR.UseVisualStyleBackColor = True
        '
        'Clbclases
        '
        Me.Clbclases.CheckOnClick = True
        Me.Clbclases.FormattingEnabled = True
        Me.Clbclases.Location = New System.Drawing.Point(971, 14)
        Me.Clbclases.Name = "Clbclases"
        Me.Clbclases.ScrollAlwaysVisible = True
        Me.Clbclases.Size = New System.Drawing.Size(186, 64)
        Me.Clbclases.TabIndex = 27
        '
        'gpoContratos
        '
        Me.gpoContratos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoContratos.BackColor = System.Drawing.Color.Transparent
        Me.gpoContratos.BorderColor = System.Drawing.Color.Black
        Me.gpoContratos.Controls.Add(Me.fxgrdContabilidad)
        Me.gpoContratos.Location = New System.Drawing.Point(8, 85)
        Me.gpoContratos.Name = "gpoContratos"
        Me.gpoContratos.Size = New System.Drawing.Size(1153, 347)
        Me.gpoContratos.TabIndex = 15
        Me.gpoContratos.TabStop = False
        '
        'fxgrdContabilidad
        '
        Me.fxgrdContabilidad.AllowEditing = False
        Me.fxgrdContabilidad.AllowFiltering = True
        Me.fxgrdContabilidad.ColumnInfo = "10,1,0,0,0,95,Columns:0{AllowFiltering:ByValue;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{AllowFiltering:ByValue;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fxgrdContabilidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fxgrdContabilidad.Location = New System.Drawing.Point(3, 16)
        Me.fxgrdContabilidad.Name = "fxgrdContabilidad"
        Me.fxgrdContabilidad.Rows.Count = 2
        Me.fxgrdContabilidad.Rows.DefaultSize = 19
        Me.fxgrdContabilidad.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.fxgrdContabilidad.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fxgrdContabilidad.Size = New System.Drawing.Size(1147, 328)
        Me.fxgrdContabilidad.TabIndex = 0
        '
        'frmcontabilidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1161, 436)
        Me.Controls.Add(Me.Clbclases)
        Me.Controls.Add(Me.btnVerificarCONCAR)
        Me.Controls.Add(Me.btnEliminarAsientoPeriodo)
        Me.Controls.Add(Me.cboPeriodo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboTipoContrato)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.lblperiodo)
        Me.Controls.Add(Me.cboEmpresa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.gpoContratos)
        Me.Controls.Add(Me.tsMantenimiento)
        Me.Name = "frmcontabilidad"
        Me.Text = "Asientos Contables"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tsMantenimiento.ResumeLayout(False)
        Me.tsMantenimiento.PerformLayout()
        Me.gpoContratos.ResumeLayout(False)
        CType(Me.fxgrdContabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbProcesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents gpoContratos As CUGroupBox
    Friend WithEvents fxgrdContabilidad As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents cboEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblperiodo As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents sfDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cboTipoContrato As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents tsbGenerarPreLiq As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminarAsientoPeriodo As System.Windows.Forms.Button
    Friend WithEvents btnVerificarCONCAR As System.Windows.Forms.Button
    Friend WithEvents Clbclases As System.Windows.Forms.CheckedListBox
    Friend WithEvents tssbValidaciones As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tsmValida2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmValida3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmValida4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmValida5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmValida1 As System.Windows.Forms.ToolStripMenuItem
End Class
