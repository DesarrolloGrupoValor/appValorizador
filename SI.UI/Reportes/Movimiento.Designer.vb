﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Movimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Movimiento))
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.gpoContratos = New CUGroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblIdentifica0 = New System.Windows.Forms.Label()
        Me.CboPeriodoDestino = New System.Windows.Forms.ComboBox()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox()
        Me.cboEmpresa = New System.Windows.Forms.ComboBox()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpPeriodo = New System.Windows.Forms.DateTimePicker()
        Me.CuGroupBox2 = New CUGroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tsMantenimiento = New System.Windows.Forms.ToolStrip()
        Me.tsbConsular = New System.Windows.Forms.ToolStripButton()
        Me.tsbExportarExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssbValidaciones = New System.Windows.Forms.ToolStripSplitButton()
        Me.tsmValida2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmValida3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmValida4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmValida5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.CuGroupBox1 = New CUGroupBox()
        Me.fxgrdExtraccionBd = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tsmValida1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.gpoContratos.SuspendLayout()
        Me.CuGroupBox2.SuspendLayout()
        Me.tsMantenimiento.SuspendLayout()
        Me.CuGroupBox1.SuspendLayout()
        CType(Me.fxgrdExtraccionBd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpoContratos
        '
        Me.gpoContratos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoContratos.BackColor = System.Drawing.Color.LemonChiffon
        Me.gpoContratos.BorderColor = System.Drawing.Color.Black
        Me.gpoContratos.Controls.Add(Me.Label4)
        Me.gpoContratos.Controls.Add(Me.lblIdentifica0)
        Me.gpoContratos.Controls.Add(Me.CboPeriodoDestino)
        Me.gpoContratos.Controls.Add(Me.cboPeriodo)
        Me.gpoContratos.Controls.Add(Me.cboEmpresa)
        Me.gpoContratos.Controls.Add(Me.lblEmpresa)
        Me.gpoContratos.Controls.Add(Me.Label1)
        Me.gpoContratos.Controls.Add(Me.dtpPeriodo)
        Me.gpoContratos.Controls.Add(Me.CuGroupBox2)
        Me.gpoContratos.Controls.Add(Me.CuGroupBox1)
        Me.gpoContratos.Location = New System.Drawing.Point(-201, -38)
        Me.gpoContratos.Name = "gpoContratos"
        Me.gpoContratos.Size = New System.Drawing.Size(1479, 598)
        Me.gpoContratos.TabIndex = 16
        Me.gpoContratos.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(884, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Identifica TMH >= 0 y Valor compras = 0"
        '
        'lblIdentifica0
        '
        Me.lblIdentifica0.AutoSize = True
        Me.lblIdentifica0.BackColor = System.Drawing.Color.Red
        Me.lblIdentifica0.Location = New System.Drawing.Point(844, 97)
        Me.lblIdentifica0.Name = "lblIdentifica0"
        Me.lblIdentifica0.Size = New System.Drawing.Size(31, 13)
        Me.lblIdentifica0.TabIndex = 23
        Me.lblIdentifica0.Text = "        "
        '
        'CboPeriodoDestino
        '
        Me.CboPeriodoDestino.FormattingEnabled = True
        Me.CboPeriodoDestino.Location = New System.Drawing.Point(684, 94)
        Me.CboPeriodoDestino.Name = "CboPeriodoDestino"
        Me.CboPeriodoDestino.Size = New System.Drawing.Size(121, 21)
        Me.CboPeriodoDestino.TabIndex = 22
        '
        'cboPeriodo
        '
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.Location = New System.Drawing.Point(546, 94)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(121, 21)
        Me.cboPeriodo.TabIndex = 21
        '
        'cboEmpresa
        '
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.Location = New System.Drawing.Point(271, 92)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(121, 21)
        Me.cboEmpresa.TabIndex = 20
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Location = New System.Drawing.Point(214, 95)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(51, 13)
        Me.lblEmpresa.TabIndex = 19
        Me.lblEmpresa.Text = "Empresa:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(482, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Periodo:"
        '
        'dtpPeriodo
        '
        Me.dtpPeriodo.CustomFormat = "yyyy-MM"
        Me.dtpPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPeriodo.Location = New System.Drawing.Point(1094, 50)
        Me.dtpPeriodo.Name = "dtpPeriodo"
        Me.dtpPeriodo.Size = New System.Drawing.Size(86, 20)
        Me.dtpPeriodo.TabIndex = 18
        Me.dtpPeriodo.Visible = False
        '
        'CuGroupBox2
        '
        Me.CuGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CuGroupBox2.BorderColor = System.Drawing.Color.Black
        Me.CuGroupBox2.Controls.Add(Me.Label2)
        Me.CuGroupBox2.Controls.Add(Me.tsMantenimiento)
        Me.CuGroupBox2.Location = New System.Drawing.Point(199, 23)
        Me.CuGroupBox2.Name = "CuGroupBox2"
        Me.CuGroupBox2.Size = New System.Drawing.Size(1077, 63)
        Me.CuGroupBox2.TabIndex = 17
        Me.CuGroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(634, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 17)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Reporte - Movimientos del Mes"
        '
        'tsMantenimiento
        '
        Me.tsMantenimiento.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbConsular, Me.tsbExportarExcel, Me.ToolStripSeparator1, Me.tssbValidaciones, Me.ToolStripSeparator7, Me.tsbSalir})
        Me.tsMantenimiento.Location = New System.Drawing.Point(3, 16)
        Me.tsMantenimiento.Name = "tsMantenimiento"
        Me.tsMantenimiento.Size = New System.Drawing.Size(1071, 39)
        Me.tsMantenimiento.TabIndex = 23
        Me.tsMantenimiento.Text = "ToolStrip1"
        '
        'tsbConsular
        '
        Me.tsbConsular.Image = CType(resources.GetObject("tsbConsular.Image"), System.Drawing.Image)
        Me.tsbConsular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConsular.Name = "tsbConsular"
        Me.tsbConsular.Size = New System.Drawing.Size(94, 36)
        Me.tsbConsular.Text = "Consultar"
        '
        'tsbExportarExcel
        '
        Me.tsbExportarExcel.Image = CType(resources.GetObject("tsbExportarExcel.Image"), System.Drawing.Image)
        Me.tsbExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportarExcel.Name = "tsbExportarExcel"
        Me.tsbExportarExcel.Size = New System.Drawing.Size(124, 36)
        Me.tsbExportarExcel.Text = "Exportar a Excel"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
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
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 39)
        '
        'tsbSalir
        '
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(65, 36)
        Me.tsbSalir.Text = "Salir"
        '
        'CuGroupBox1
        '
        Me.CuGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CuGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.CuGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.CuGroupBox1.Controls.Add(Me.fxgrdExtraccionBd)
        Me.CuGroupBox1.Location = New System.Drawing.Point(213, 121)
        Me.CuGroupBox1.Name = "CuGroupBox1"
        Me.CuGroupBox1.Size = New System.Drawing.Size(1052, 429)
        Me.CuGroupBox1.TabIndex = 16
        Me.CuGroupBox1.TabStop = False
        '
        'fxgrdExtraccionBd
        '
        Me.fxgrdExtraccionBd.AllowEditing = False
        Me.fxgrdExtraccionBd.AllowFiltering = True
        Me.fxgrdExtraccionBd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fxgrdExtraccionBd.ColumnInfo = resources.GetString("fxgrdExtraccionBd.ColumnInfo")
        Me.fxgrdExtraccionBd.Location = New System.Drawing.Point(6, 19)
        Me.fxgrdExtraccionBd.Name = "fxgrdExtraccionBd"
        Me.fxgrdExtraccionBd.Rows.Count = 2
        Me.fxgrdExtraccionBd.Rows.DefaultSize = 19
        Me.fxgrdExtraccionBd.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.fxgrdExtraccionBd.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fxgrdExtraccionBd.Size = New System.Drawing.Size(1040, 410)
        Me.fxgrdExtraccionBd.TabIndex = 0
        '
        'tsmValida1
        '
        Me.tsmValida1.Image = Global.My.Resources.Resources.nuevo
        Me.tsmValida1.Name = "tsmValida1"
        Me.tsmValida1.Size = New System.Drawing.Size(253, 38)
        Me.tsmValida1.Text = "1. Rumas Pendientes de Lotizar"
        '
        'Movimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 524)
        Me.Controls.Add(Me.gpoContratos)
        Me.Name = "Movimiento"
        Me.Text = "Movimiento del Mes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gpoContratos.ResumeLayout(False)
        Me.gpoContratos.PerformLayout()
        Me.CuGroupBox2.ResumeLayout(False)
        Me.CuGroupBox2.PerformLayout()
        Me.tsMantenimiento.ResumeLayout(False)
        Me.tsMantenimiento.PerformLayout()
        Me.CuGroupBox1.ResumeLayout(False)
        CType(Me.fxgrdExtraccionBd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpoContratos As CUGroupBox
    Friend WithEvents CuGroupBox1 As CUGroupBox
    Friend WithEvents fxgrdExtraccionBd As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents CuGroupBox2 As CUGroupBox
    Friend WithEvents tsMantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpPeriodo As System.Windows.Forms.DateTimePicker
    Friend WithEvents tsbConsular As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CboPeriodoDestino As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblIdentifica0 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tssbValidaciones As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tsmValida2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmValida3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmValida4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmValida5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmValida1 As System.Windows.Forms.ToolStripMenuItem
End Class
