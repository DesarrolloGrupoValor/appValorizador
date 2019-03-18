<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class liquidacion
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
        Me.gpocontrato = New CUGroupBox()
        Me.txtNeto = New CUTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtImporte = New CUTextbox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtEmision = New CUTextbox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNumero = New CUTextbox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAjuste = New CUTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotal = New CUTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtImp = New CUTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtValor = New CUTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPunit = New CUTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMaqu = New CUTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPen = New CUTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPag = New CUTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigo = New CUTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboDoc = New System.Windows.Forms.ComboBox()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.gpocontrato.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpocontrato
        '
        Me.gpocontrato.BackColor = System.Drawing.Color.Transparent
        Me.gpocontrato.BorderColor = System.Drawing.Color.Black
        Me.gpocontrato.Controls.Add(Me.txtNeto)
        Me.gpocontrato.Controls.Add(Me.Label11)
        Me.gpocontrato.Controls.Add(Me.txtImporte)
        Me.gpocontrato.Controls.Add(Me.Label16)
        Me.gpocontrato.Controls.Add(Me.txtEmision)
        Me.gpocontrato.Controls.Add(Me.Label15)
        Me.gpocontrato.Controls.Add(Me.txtNumero)
        Me.gpocontrato.Controls.Add(Me.Label14)
        Me.gpocontrato.Controls.Add(Me.txtAjuste)
        Me.gpocontrato.Controls.Add(Me.Label10)
        Me.gpocontrato.Controls.Add(Me.txtTotal)
        Me.gpocontrato.Controls.Add(Me.Label9)
        Me.gpocontrato.Controls.Add(Me.txtImp)
        Me.gpocontrato.Controls.Add(Me.Label8)
        Me.gpocontrato.Controls.Add(Me.txtValor)
        Me.gpocontrato.Controls.Add(Me.Label7)
        Me.gpocontrato.Controls.Add(Me.txtPunit)
        Me.gpocontrato.Controls.Add(Me.Label6)
        Me.gpocontrato.Controls.Add(Me.txtMaqu)
        Me.gpocontrato.Controls.Add(Me.Label5)
        Me.gpocontrato.Controls.Add(Me.txtPen)
        Me.gpocontrato.Controls.Add(Me.Label4)
        Me.gpocontrato.Controls.Add(Me.txtPag)
        Me.gpocontrato.Controls.Add(Me.Label3)
        Me.gpocontrato.Controls.Add(Me.txtCodigo)
        Me.gpocontrato.Controls.Add(Me.Label2)
        Me.gpocontrato.Controls.Add(Me.Label13)
        Me.gpocontrato.Controls.Add(Me.Label1)
        Me.gpocontrato.Controls.Add(Me.cboDoc)
        Me.gpocontrato.Controls.Add(Me.cboTipo)
        Me.gpocontrato.Location = New System.Drawing.Point(12, 8)
        Me.gpocontrato.Name = "gpocontrato"
        Me.gpocontrato.Size = New System.Drawing.Size(481, 241)
        Me.gpocontrato.TabIndex = 7
        Me.gpocontrato.TabStop = False
        '
        'txtNeto
        '
        Me.txtNeto.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtNeto.Location = New System.Drawing.Point(400, 74)
        Me.txtNeto.MandatoryColor = System.Drawing.Color.Empty
        Me.txtNeto.MandatoryField = False
        Me.txtNeto.MaxLength = 10
        Me.txtNeto.Name = "txtNeto"
        Me.txtNeto.Size = New System.Drawing.Size(75, 20)
        Me.txtNeto.TabIndex = 1
        Me.txtNeto.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtNeto.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtNeto.VCM_CustomInputTypeString = Nothing
        Me.txtNeto.VCM_CustomOmmitString = Nothing
        Me.txtNeto.VCM_EnterFocus = True
        Me.txtNeto.VCM_IsValidated = False
        Me.txtNeto.VCM_MensajeFoco = Nothing
        Me.txtNeto.VCM_MuestraMensajeFoco = False
        Me.txtNeto.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtNeto.VCM_RegularExpression = Nothing
        Me.txtNeto.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtNeto.VCM_ShowMessage = True
        Me.txtNeto.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroEntero
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(341, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Neto"
        '
        'txtImporte
        '
        Me.txtImporte.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtImporte.Location = New System.Drawing.Point(400, 212)
        Me.txtImporte.MandatoryColor = System.Drawing.Color.Empty
        Me.txtImporte.MandatoryField = False
        Me.txtImporte.MaxLength = 10
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(75, 20)
        Me.txtImporte.TabIndex = 1
        Me.txtImporte.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtImporte.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtImporte.VCM_CustomInputTypeString = Nothing
        Me.txtImporte.VCM_CustomOmmitString = Nothing
        Me.txtImporte.VCM_EnterFocus = True
        Me.txtImporte.VCM_IsValidated = False
        Me.txtImporte.VCM_MensajeFoco = Nothing
        Me.txtImporte.VCM_MuestraMensajeFoco = False
        Me.txtImporte.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtImporte.VCM_RegularExpression = Nothing
        Me.txtImporte.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtImporte.VCM_ShowMessage = True
        Me.txtImporte.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroEntero
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(341, 212)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Importe"
        '
        'txtEmision
        '
        Me.txtEmision.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtEmision.Location = New System.Drawing.Point(400, 185)
        Me.txtEmision.MandatoryColor = System.Drawing.Color.Empty
        Me.txtEmision.MandatoryField = False
        Me.txtEmision.MaxLength = 10
        Me.txtEmision.Name = "txtEmision"
        Me.txtEmision.Size = New System.Drawing.Size(75, 20)
        Me.txtEmision.TabIndex = 1
        Me.txtEmision.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtEmision.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtEmision.VCM_CustomInputTypeString = Nothing
        Me.txtEmision.VCM_CustomOmmitString = Nothing
        Me.txtEmision.VCM_EnterFocus = True
        Me.txtEmision.VCM_IsValidated = False
        Me.txtEmision.VCM_MensajeFoco = Nothing
        Me.txtEmision.VCM_MuestraMensajeFoco = False
        Me.txtEmision.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtEmision.VCM_RegularExpression = Nothing
        Me.txtEmision.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtEmision.VCM_ShowMessage = True
        Me.txtEmision.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroEntero
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(341, 185)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Emision"
        '
        'txtNumero
        '
        Me.txtNumero.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtNumero.Location = New System.Drawing.Point(257, 183)
        Me.txtNumero.MandatoryColor = System.Drawing.Color.Empty
        Me.txtNumero.MandatoryField = False
        Me.txtNumero.MaxLength = 10
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(75, 20)
        Me.txtNumero.TabIndex = 1
        Me.txtNumero.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtNumero.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtNumero.VCM_CustomInputTypeString = Nothing
        Me.txtNumero.VCM_CustomOmmitString = Nothing
        Me.txtNumero.VCM_EnterFocus = True
        Me.txtNumero.VCM_IsValidated = False
        Me.txtNumero.VCM_MensajeFoco = Nothing
        Me.txtNumero.VCM_MuestraMensajeFoco = False
        Me.txtNumero.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtNumero.VCM_RegularExpression = Nothing
        Me.txtNumero.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtNumero.VCM_ShowMessage = True
        Me.txtNumero.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroEntero
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(198, 183)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Numero"
        '
        'txtAjuste
        '
        Me.txtAjuste.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtAjuste.Location = New System.Drawing.Point(257, 156)
        Me.txtAjuste.MandatoryColor = System.Drawing.Color.Empty
        Me.txtAjuste.MandatoryField = False
        Me.txtAjuste.MaxLength = 10
        Me.txtAjuste.Name = "txtAjuste"
        Me.txtAjuste.Size = New System.Drawing.Size(75, 20)
        Me.txtAjuste.TabIndex = 1
        Me.txtAjuste.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtAjuste.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtAjuste.VCM_CustomInputTypeString = Nothing
        Me.txtAjuste.VCM_CustomOmmitString = Nothing
        Me.txtAjuste.VCM_EnterFocus = True
        Me.txtAjuste.VCM_IsValidated = False
        Me.txtAjuste.VCM_MensajeFoco = Nothing
        Me.txtAjuste.VCM_MuestraMensajeFoco = False
        Me.txtAjuste.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtAjuste.VCM_RegularExpression = Nothing
        Me.txtAjuste.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtAjuste.VCM_ShowMessage = True
        Me.txtAjuste.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroEntero
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(198, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Ajuste"
        '
        'txtTotal
        '
        Me.txtTotal.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtTotal.Location = New System.Drawing.Point(257, 130)
        Me.txtTotal.MandatoryColor = System.Drawing.Color.Empty
        Me.txtTotal.MandatoryField = False
        Me.txtTotal.MaxLength = 10
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(75, 20)
        Me.txtTotal.TabIndex = 1
        Me.txtTotal.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtTotal.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtTotal.VCM_CustomInputTypeString = Nothing
        Me.txtTotal.VCM_CustomOmmitString = Nothing
        Me.txtTotal.VCM_EnterFocus = True
        Me.txtTotal.VCM_IsValidated = False
        Me.txtTotal.VCM_MensajeFoco = Nothing
        Me.txtTotal.VCM_MuestraMensajeFoco = False
        Me.txtTotal.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtTotal.VCM_RegularExpression = Nothing
        Me.txtTotal.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtTotal.VCM_ShowMessage = True
        Me.txtTotal.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroEntero
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(198, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Total"
        '
        'txtImp
        '
        Me.txtImp.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtImp.Location = New System.Drawing.Point(257, 100)
        Me.txtImp.MandatoryColor = System.Drawing.Color.Empty
        Me.txtImp.MandatoryField = False
        Me.txtImp.MaxLength = 10
        Me.txtImp.Name = "txtImp"
        Me.txtImp.Size = New System.Drawing.Size(75, 20)
        Me.txtImp.TabIndex = 1
        Me.txtImp.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtImp.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtImp.VCM_CustomInputTypeString = Nothing
        Me.txtImp.VCM_CustomOmmitString = Nothing
        Me.txtImp.VCM_EnterFocus = True
        Me.txtImp.VCM_IsValidated = False
        Me.txtImp.VCM_MensajeFoco = Nothing
        Me.txtImp.VCM_MuestraMensajeFoco = False
        Me.txtImp.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtImp.VCM_RegularExpression = Nothing
        Me.txtImp.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtImp.VCM_ShowMessage = True
        Me.txtImp.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroEntero
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(198, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Imp"
        '
        'txtValor
        '
        Me.txtValor.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtValor.Location = New System.Drawing.Point(257, 74)
        Me.txtValor.MandatoryColor = System.Drawing.Color.Empty
        Me.txtValor.MandatoryField = False
        Me.txtValor.MaxLength = 10
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(75, 20)
        Me.txtValor.TabIndex = 1
        Me.txtValor.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtValor.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtValor.VCM_CustomInputTypeString = Nothing
        Me.txtValor.VCM_CustomOmmitString = Nothing
        Me.txtValor.VCM_EnterFocus = True
        Me.txtValor.VCM_IsValidated = False
        Me.txtValor.VCM_MensajeFoco = Nothing
        Me.txtValor.VCM_MuestraMensajeFoco = False
        Me.txtValor.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtValor.VCM_RegularExpression = Nothing
        Me.txtValor.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtValor.VCM_ShowMessage = True
        Me.txtValor.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroEntero
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(198, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Valor"
        '
        'txtPunit
        '
        Me.txtPunit.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtPunit.Location = New System.Drawing.Point(83, 156)
        Me.txtPunit.MandatoryColor = System.Drawing.Color.Empty
        Me.txtPunit.MandatoryField = False
        Me.txtPunit.MaxLength = 10
        Me.txtPunit.Name = "txtPunit"
        Me.txtPunit.Size = New System.Drawing.Size(75, 20)
        Me.txtPunit.TabIndex = 1
        Me.txtPunit.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtPunit.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtPunit.VCM_CustomInputTypeString = Nothing
        Me.txtPunit.VCM_CustomOmmitString = Nothing
        Me.txtPunit.VCM_EnterFocus = True
        Me.txtPunit.VCM_IsValidated = False
        Me.txtPunit.VCM_MensajeFoco = Nothing
        Me.txtPunit.VCM_MuestraMensajeFoco = False
        Me.txtPunit.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtPunit.VCM_RegularExpression = Nothing
        Me.txtPunit.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtPunit.VCM_ShowMessage = True
        Me.txtPunit.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroEntero
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "P.Unit"
        '
        'txtMaqu
        '
        Me.txtMaqu.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtMaqu.Location = New System.Drawing.Point(83, 130)
        Me.txtMaqu.MandatoryColor = System.Drawing.Color.Empty
        Me.txtMaqu.MandatoryField = False
        Me.txtMaqu.MaxLength = 10
        Me.txtMaqu.Name = "txtMaqu"
        Me.txtMaqu.Size = New System.Drawing.Size(75, 20)
        Me.txtMaqu.TabIndex = 1
        Me.txtMaqu.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtMaqu.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtMaqu.VCM_CustomInputTypeString = Nothing
        Me.txtMaqu.VCM_CustomOmmitString = Nothing
        Me.txtMaqu.VCM_EnterFocus = True
        Me.txtMaqu.VCM_IsValidated = False
        Me.txtMaqu.VCM_MensajeFoco = Nothing
        Me.txtMaqu.VCM_MuestraMensajeFoco = False
        Me.txtMaqu.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtMaqu.VCM_RegularExpression = Nothing
        Me.txtMaqu.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtMaqu.VCM_ShowMessage = True
        Me.txtMaqu.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroEntero
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Maqu"
        '
        'txtPen
        '
        Me.txtPen.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtPen.Location = New System.Drawing.Point(83, 103)
        Me.txtPen.MandatoryColor = System.Drawing.Color.Empty
        Me.txtPen.MandatoryField = False
        Me.txtPen.MaxLength = 10
        Me.txtPen.Name = "txtPen"
        Me.txtPen.Size = New System.Drawing.Size(75, 20)
        Me.txtPen.TabIndex = 1
        Me.txtPen.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtPen.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtPen.VCM_CustomInputTypeString = Nothing
        Me.txtPen.VCM_CustomOmmitString = Nothing
        Me.txtPen.VCM_EnterFocus = True
        Me.txtPen.VCM_IsValidated = False
        Me.txtPen.VCM_MensajeFoco = Nothing
        Me.txtPen.VCM_MuestraMensajeFoco = False
        Me.txtPen.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtPen.VCM_RegularExpression = Nothing
        Me.txtPen.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtPen.VCM_ShowMessage = True
        Me.txtPen.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroEntero
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Pen"
        '
        'txtPag
        '
        Me.txtPag.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtPag.Location = New System.Drawing.Point(83, 77)
        Me.txtPag.MandatoryColor = System.Drawing.Color.Empty
        Me.txtPag.MandatoryField = False
        Me.txtPag.MaxLength = 10
        Me.txtPag.Name = "txtPag"
        Me.txtPag.Size = New System.Drawing.Size(75, 20)
        Me.txtPag.TabIndex = 1
        Me.txtPag.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtPag.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtPag.VCM_CustomInputTypeString = Nothing
        Me.txtPag.VCM_CustomOmmitString = Nothing
        Me.txtPag.VCM_EnterFocus = True
        Me.txtPag.VCM_IsValidated = False
        Me.txtPag.VCM_MensajeFoco = Nothing
        Me.txtPag.VCM_MuestraMensajeFoco = False
        Me.txtPag.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtPag.VCM_RegularExpression = Nothing
        Me.txtPag.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtPag.VCM_ShowMessage = True
        Me.txtPag.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroEntero
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Pag"
        '
        'txtCodigo
        '
        Me.txtCodigo.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtCodigo.Location = New System.Drawing.Point(83, 14)
        Me.txtCodigo.MandatoryColor = System.Drawing.Color.Empty
        Me.txtCodigo.MandatoryField = False
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(75, 20)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtCodigo.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtCodigo.VCM_CustomInputTypeString = Nothing
        Me.txtCodigo.VCM_CustomOmmitString = Nothing
        Me.txtCodigo.VCM_EnterFocus = True
        Me.txtCodigo.VCM_IsValidated = False
        Me.txtCodigo.VCM_MensajeFoco = Nothing
        Me.txtCodigo.VCM_MuestraMensajeFoco = False
        Me.txtCodigo.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtCodigo.VCM_RegularExpression = Nothing
        Me.txtCodigo.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtCodigo.VCM_ShowMessage = True
        Me.txtCodigo.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroEntero
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Codigo"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 185)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Documento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo"
        '
        'cboDoc
        '
        Me.cboDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDoc.FormattingEnabled = True
        Me.cboDoc.Items.AddRange(New Object() {"Provisional", "Final"})
        Me.cboDoc.Location = New System.Drawing.Point(83, 182)
        Me.cboDoc.Name = "cboDoc"
        Me.cboDoc.Size = New System.Drawing.Size(85, 21)
        Me.cboDoc.TabIndex = 0
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"Provisional", "Final"})
        Me.cboTipo.Location = New System.Drawing.Point(83, 41)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(85, 21)
        Me.cboTipo.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(418, 255)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(328, 255)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 8
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'liquidacion
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(497, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.gpocontrato)
        Me.Name = "liquidacion"
        Me.Text = "Liquidacion"
        Me.gpocontrato.ResumeLayout(False)
        Me.gpocontrato.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpocontrato As CUGroupBox
    Friend WithEvents txtCodigo As CUTextbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtNeto As CUTextbox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtImporte As CUTextbox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtEmision As CUTextbox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As CUTextbox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtAjuste As CUTextbox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As CUTextbox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtImp As CUTextbox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtValor As CUTextbox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPunit As CUTextbox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMaqu As CUTextbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPen As CUTextbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPag As CUTextbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboDoc As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
End Class
