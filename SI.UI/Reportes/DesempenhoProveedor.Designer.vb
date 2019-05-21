<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DesempenhoProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DesempenhoProveedor))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbcomprador = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProfit = New CUTextbox()
        Me.txtperiodofin = New CUTextbox()
        Me.txtperiodoini = New CUTextbox()
        Me.C1FlexDataTree1 = New C1FlexDataTree()
        Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbcalidad = New System.Windows.Forms.ComboBox()
        CType(Me.C1FlexDataTree1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1029, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbTipo
        '
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(53, 23)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipo.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "TIPO"
        '
        'cmbcomprador
        '
        Me.cmbcomprador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcomprador.FormattingEnabled = True
        Me.cmbcomprador.Location = New System.Drawing.Point(293, 21)
        Me.cmbcomprador.Name = "cmbcomprador"
        Me.cmbcomprador.Size = New System.Drawing.Size(121, 21)
        Me.cmbcomprador.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(210, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "COMPRADOR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "PERIODO INICIAL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(292, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "PERIODO FINAL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(737, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "PROFIT"
        '
        'txtProfit
        '
        Me.txtProfit.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtProfit.Location = New System.Drawing.Point(789, 59)
        Me.txtProfit.MandatoryColor = System.Drawing.Color.Empty
        Me.txtProfit.MandatoryField = False
        Me.txtProfit.MaxLength = 6
        Me.txtProfit.Name = "txtProfit"
        Me.txtProfit.Size = New System.Drawing.Size(120, 20)
        Me.txtProfit.TabIndex = 33
        Me.txtProfit.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtProfit.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtProfit.VCM_CustomInputTypeString = Nothing
        Me.txtProfit.VCM_CustomOmmitString = Nothing
        Me.txtProfit.VCM_EnterFocus = True
        Me.txtProfit.VCM_IsValidated = True
        Me.txtProfit.VCM_MensajeFoco = Nothing
        Me.txtProfit.VCM_MuestraMensajeFoco = False
        Me.txtProfit.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtProfit.VCM_RegularExpression = Nothing
        Me.txtProfit.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtProfit.VCM_ShowMessage = True
        Me.txtProfit.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'txtperiodofin
        '
        Me.txtperiodofin.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtperiodofin.Location = New System.Drawing.Point(394, 59)
        Me.txtperiodofin.MandatoryColor = System.Drawing.Color.Empty
        Me.txtperiodofin.MandatoryField = False
        Me.txtperiodofin.MaxLength = 6
        Me.txtperiodofin.Name = "txtperiodofin"
        Me.txtperiodofin.Size = New System.Drawing.Size(120, 20)
        Me.txtperiodofin.TabIndex = 30
        Me.txtperiodofin.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtperiodofin.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtperiodofin.VCM_CustomInputTypeString = Nothing
        Me.txtperiodofin.VCM_CustomOmmitString = Nothing
        Me.txtperiodofin.VCM_EnterFocus = True
        Me.txtperiodofin.VCM_IsValidated = True
        Me.txtperiodofin.VCM_MensajeFoco = Nothing
        Me.txtperiodofin.VCM_MuestraMensajeFoco = False
        Me.txtperiodofin.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtperiodofin.VCM_RegularExpression = Nothing
        Me.txtperiodofin.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtperiodofin.VCM_ShowMessage = True
        Me.txtperiodofin.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'txtperiodoini
        '
        Me.txtperiodoini.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtperiodoini.Location = New System.Drawing.Point(157, 59)
        Me.txtperiodoini.MandatoryColor = System.Drawing.Color.Empty
        Me.txtperiodoini.MandatoryField = False
        Me.txtperiodoini.MaxLength = 6
        Me.txtperiodoini.Name = "txtperiodoini"
        Me.txtperiodoini.Size = New System.Drawing.Size(120, 20)
        Me.txtperiodoini.TabIndex = 21
        Me.txtperiodoini.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtperiodoini.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtperiodoini.VCM_CustomInputTypeString = Nothing
        Me.txtperiodoini.VCM_CustomOmmitString = Nothing
        Me.txtperiodoini.VCM_EnterFocus = True
        Me.txtperiodoini.VCM_IsValidated = True
        Me.txtperiodoini.VCM_MensajeFoco = Nothing
        Me.txtperiodoini.VCM_MuestraMensajeFoco = False
        Me.txtperiodoini.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtperiodoini.VCM_RegularExpression = Nothing
        Me.txtperiodoini.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtperiodoini.VCM_ShowMessage = True
        Me.txtperiodoini.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'C1FlexDataTree1
        '
        Me.C1FlexDataTree1.ColumnInfo = "10,1,0,0,0,95,Columns:0{Width:38;Style:""ImageAlign:RightCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.C1FlexDataTree1.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw
        Me.C1FlexDataTree1.Location = New System.Drawing.Point(12, 95)
        Me.C1FlexDataTree1.Name = "C1FlexDataTree1"
        Me.C1FlexDataTree1.Rows.DefaultSize = 19
        Me.C1FlexDataTree1.Size = New System.Drawing.Size(1143, 259)
        Me.C1FlexDataTree1.TabIndex = 0
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(13, 360)
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75.0R
        Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(1142, 133)
        Me.C1TrueDBGrid1.TabIndex = 34
        Me.C1TrueDBGrid1.Text = "C1TrueDBGrid1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(446, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "CALIDAD"
        '
        'cmbcalidad
        '
        Me.cmbcalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcalidad.FormattingEnabled = True
        Me.cmbcalidad.Location = New System.Drawing.Point(518, 23)
        Me.cmbcalidad.Name = "cmbcalidad"
        Me.cmbcalidad.Size = New System.Drawing.Size(151, 21)
        Me.cmbcalidad.TabIndex = 36
        '
        'DesempenhoProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1167, 501)
        Me.Controls.Add(Me.cmbcalidad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.C1TrueDBGrid1)
        Me.Controls.Add(Me.txtProfit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtperiodofin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbcomprador)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtperiodoini)
        Me.Controls.Add(Me.C1FlexDataTree1)
        Me.Name = "DesempenhoProveedor"
        Me.Text = "Desempeño Proveedor"
        CType(Me.C1FlexDataTree1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1FlexDataTree1 As C1FlexDataTree
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbcomprador As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtperiodoini As CUTextbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtperiodofin As CUTextbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtProfit As CUTextbox
    Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbcalidad As System.Windows.Forms.ComboBox
End Class
