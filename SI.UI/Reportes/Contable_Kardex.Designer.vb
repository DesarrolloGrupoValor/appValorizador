﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contable_Kardex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contable_Kardex))
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.gpoContratos = New CUGroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbAnterior = New System.Windows.Forms.RadioButton()
        Me.rbNuevo = New System.Windows.Forms.RadioButton()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox()
        Me.cboEmpresa = New System.Windows.Forms.ComboBox()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CuGroupBox2 = New CUGroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tsMantenimiento = New System.Windows.Forms.ToolStrip()
        Me.tsbConsular = New System.Windows.Forms.ToolStripButton()
        Me.tsbExportarExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.CuGroupBox1 = New CUGroupBox()
        Me.fxgrdContabilidad = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.gpoContratos.SuspendLayout()
        Me.CuGroupBox2.SuspendLayout()
        Me.tsMantenimiento.SuspendLayout()
        Me.CuGroupBox1.SuspendLayout()
        CType(Me.fxgrdContabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpoContratos
        '
        Me.gpoContratos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoContratos.BackColor = System.Drawing.Color.LemonChiffon
        Me.gpoContratos.BorderColor = System.Drawing.Color.Black
        Me.gpoContratos.Controls.Add(Me.Label3)
        Me.gpoContratos.Controls.Add(Me.rbAnterior)
        Me.gpoContratos.Controls.Add(Me.rbNuevo)
        Me.gpoContratos.Controls.Add(Me.cboPeriodo)
        Me.gpoContratos.Controls.Add(Me.cboEmpresa)
        Me.gpoContratos.Controls.Add(Me.lblEmpresa)
        Me.gpoContratos.Controls.Add(Me.Label1)
        Me.gpoContratos.Controls.Add(Me.CuGroupBox2)
        Me.gpoContratos.Controls.Add(Me.CuGroupBox1)
        Me.gpoContratos.Location = New System.Drawing.Point(-201, -38)
        Me.gpoContratos.Name = "gpoContratos"
        Me.gpoContratos.Size = New System.Drawing.Size(1479, 598)
        Me.gpoContratos.TabIndex = 16
        Me.gpoContratos.TabStop = False
        Me.gpoContratos.Text = "Kardex Valorizado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(747, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Seleccione tipo de Kardex: "
        '
        'rbAnterior
        '
        Me.rbAnterior.AutoSize = True
        Me.rbAnterior.Location = New System.Drawing.Point(962, 92)
        Me.rbAnterior.Name = "rbAnterior"
        Me.rbAnterior.Size = New System.Drawing.Size(61, 17)
        Me.rbAnterior.TabIndex = 23
        Me.rbAnterior.Text = "Anterior"
        Me.rbAnterior.UseVisualStyleBackColor = True
        '
        'rbNuevo
        '
        Me.rbNuevo.AutoSize = True
        Me.rbNuevo.Checked = True
        Me.rbNuevo.Location = New System.Drawing.Point(890, 92)
        Me.rbNuevo.Name = "rbNuevo"
        Me.rbNuevo.Size = New System.Drawing.Size(57, 17)
        Me.rbNuevo.TabIndex = 22
        Me.rbNuevo.TabStop = True
        Me.rbNuevo.Text = "Nuevo"
        Me.rbNuevo.UseVisualStyleBackColor = True
        '
        'cboPeriodo
        '
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.Location = New System.Drawing.Point(544, 92)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(121, 21)
        Me.cboPeriodo.TabIndex = 21
        '
        'cboEmpresa
        '
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.Location = New System.Drawing.Point(269, 90)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(121, 21)
        Me.cboEmpresa.TabIndex = 20
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Location = New System.Drawing.Point(212, 93)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(51, 13)
        Me.lblEmpresa.TabIndex = 19
        Me.lblEmpresa.Text = "Empresa:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(480, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Periodo:"
        '
        'CuGroupBox2
        '
        Me.CuGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CuGroupBox2.BorderColor = System.Drawing.Color.Black
        Me.CuGroupBox2.Controls.Add(Me.Label2)
        Me.CuGroupBox2.Controls.Add(Me.tsMantenimiento)
        Me.CuGroupBox2.Location = New System.Drawing.Point(198, 23)
        Me.CuGroupBox2.Name = "CuGroupBox2"
        Me.CuGroupBox2.Size = New System.Drawing.Size(1079, 63)
        Me.CuGroupBox2.TabIndex = 17
        Me.CuGroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(622, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 17)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Reporte - Kardex Valorizado"
        '
        'tsMantenimiento
        '
        Me.tsMantenimiento.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbConsular, Me.tsbExportarExcel, Me.ToolStripSeparator7, Me.tsbSalir})
        Me.tsMantenimiento.Location = New System.Drawing.Point(3, 16)
        Me.tsMantenimiento.Name = "tsMantenimiento"
        Me.tsMantenimiento.Size = New System.Drawing.Size(1073, 39)
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
        Me.CuGroupBox1.Controls.Add(Me.fxgrdContabilidad)
        Me.CuGroupBox1.Location = New System.Drawing.Point(213, 119)
        Me.CuGroupBox1.Name = "CuGroupBox1"
        Me.CuGroupBox1.Size = New System.Drawing.Size(1052, 431)
        Me.CuGroupBox1.TabIndex = 16
        Me.CuGroupBox1.TabStop = False
        '
        'fxgrdContabilidad
        '
        Me.fxgrdContabilidad.AllowEditing = False
        Me.fxgrdContabilidad.AllowFiltering = True
        Me.fxgrdContabilidad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fxgrdContabilidad.ColumnInfo = resources.GetString("fxgrdContabilidad.ColumnInfo")
        Me.fxgrdContabilidad.Location = New System.Drawing.Point(6, 19)
        Me.fxgrdContabilidad.Name = "fxgrdContabilidad"
        Me.fxgrdContabilidad.Rows.Count = 2
        Me.fxgrdContabilidad.Rows.DefaultSize = 19
        Me.fxgrdContabilidad.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.fxgrdContabilidad.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fxgrdContabilidad.Size = New System.Drawing.Size(1040, 406)
        Me.fxgrdContabilidad.TabIndex = 1
        '
        'Contable_Kardex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 524)
        Me.Controls.Add(Me.gpoContratos)
        Me.Name = "Contable_Kardex"
        Me.Text = "Kardex Valorizado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gpoContratos.ResumeLayout(False)
        Me.gpoContratos.PerformLayout()
        Me.CuGroupBox2.ResumeLayout(False)
        Me.CuGroupBox2.PerformLayout()
        Me.tsMantenimiento.ResumeLayout(False)
        Me.tsMantenimiento.PerformLayout()
        Me.CuGroupBox1.ResumeLayout(False)
        CType(Me.fxgrdContabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpoContratos As CUGroupBox
    Friend WithEvents CuGroupBox1 As CUGroupBox
    Friend WithEvents CuGroupBox2 As CUGroupBox
    Friend WithEvents tsMantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tsbConsular As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fxgrdContabilidad As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbAnterior As System.Windows.Forms.RadioButton
    Friend WithEvents rbNuevo As System.Windows.Forms.RadioButton
End Class
