Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports System.Data


Public Class CUTextbox
    Inherits TextBox

    Private Sub CUTextbox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Me.SelectAll()
    End Sub

    Private Sub CUTextbox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Me.SelectAll()
    End Sub

    Private Sub CUTextbox_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.SelectAll()
    End Sub
#Region "Enumeraciones"
    <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
    Public Enum TIPO_CONFIGURACION
        AlfaNumerico = 0
        SoloAlfabeto = 1
        Moneda = 2
        Personalizado = 3
        NumeroDecimal = 4
        CorreoElectronico = 5
        NumeroEntero = 6
        Normal = 7
        NumeroTelefono = 8
        NumeroSerial = 9
        Apellidos = 10
        Unidad = 11
        SoloLectura = 12
        CodigoAlfaNumerico = 13
        SoloLetrasNumeros = 14
        ConNegativo = 15
    End Enum
    <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
    Public Enum AUTOFORMATO_CONFIGURACION
        None = 0
        LowerCase = 1
        UpperCase = 2
        TitleCase = 3
    End Enum
    <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
    Public Enum PRECISION_CONFIGURACION
        SinDecimal = 0
        UnDecimal = 1
        DosDecimales = 2
        TresDecimales = 3
        CuatroDecimales = 4
        CincoDecimales = 5
        SeisDecimales = 6
    End Enum
#End Region

#Region "Declaraciones "
    Private _mInputType As TIPO_CONFIGURACION = TIPO_CONFIGURACION.Normal
    Private _mPrecision As PRECISION_CONFIGURACION = PRECISION_CONFIGURACION.CuatroDecimales
    Private _mAutoFormatStyle As AUTOFORMATO_CONFIGURACION = AUTOFORMATO_CONFIGURACION.None
    Private _mEnterFocusColor As Color
    Private _mLeaveFocusColor As Color
    Private _mCustomTypeString As String
    Private _mCustomTypeStringOmmit As String
    Private _mMandatoryField As Boolean = False
    Private _mMandatoryColor As Color
    Private _mRegularExpression As String
    Private _mRegularExpressionErrMsg As String
    Private _mShowMsg As Boolean = True
    Private _mIsValidated As Boolean = False
    Private _mEnterFocus As Boolean = True
    Private _mstrSimbolos As String = "';:._ª\!|@·#$~&()=?¿^/*-+"
    Private _mstrCodigo As String = ";:._ª\!|@·#$~&()=?¿^/-+"
    Private _mstrLetrasNumeros As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890"
    Private _mstrMensajeFoco As String
    Private _mblnMensajeFoco As Boolean = False
    Private _objToolTip As ToolTip = New ToolTip
#End Region

#Region " Events"
    Public Event OnValidationError(ByVal _ErrorMsg As String)
#End Region

#Region " Propiedades"
    <System.ComponentModel.Category("VCM Property")> _
    <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)> _
    <System.ComponentModel.Description("Mensaje en barra de estado al recibir el Foco")> _
    Public Property VCM_MensajeFoco() As String
        Get
            Return _mstrMensajeFoco
        End Get
        Set(ByVal value As String)
            _mstrMensajeFoco = value
        End Set
    End Property

    <System.ComponentModel.Category("VCM Property")> _
    <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)> _
    <System.ComponentModel.Description("Mostrar o no mensaje al recibir el Foco")> _
    Public Property VCM_MuestraMensajeFoco() As Boolean
        Get
            Return _mblnMensajeFoco
        End Get
        Set(ByVal value As Boolean)
            _mblnMensajeFoco = value
        End Set
    End Property
    ''' <summary>Set or Gets TextBox Input Types as TIPO_CONFIGURACION</summary>
    <System.ComponentModel.Category("VCM Property")> _
    <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)> _
    <System.ComponentModel.Description("Asignar u Obtener Tipo de Ingreso al TextBox ")> _
    Public Property VCM_TipoIngreso() As TIPO_CONFIGURACION
        Get
            Return _mInputType
        End Get
        Set(ByVal value As TIPO_CONFIGURACION)
            _mInputType = value
        End Set
    End Property
    ''' <summary>Set or Get the color of the control when it receives focus</summary>
    <System.ComponentModel.Category("VCM Property")> _
    <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)> _
    <System.ComponentModel.Description("Asignar u Obtener el Color del control cuando recibe el foco")> _
    Public Property VCM_ColorRecibirFoco() As Color
        Get
            Return _mEnterFocusColor
        End Get
        Set(ByVal Value As Color)
            _mEnterFocusColor = Value
        End Set
    End Property
    ''' <summary>Set or Get the color of the control when it lost focus</summary>
    <System.ComponentModel.Category("VCM Property")> _
    <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)> _
    <System.ComponentModel.Description("Asignar u Obtener el Color del Control cuando pierde el foco")> _
    Public Property VCM_ColorPerderFoco() As Color
        Get
            Return _mLeaveFocusColor
        End Get
        Set(ByVal Value As Color)
            _mLeaveFocusColor = Value
        End Set
    End Property
    ''' <summary>Set or Get custom control's Custom Input Type string format</summary>
    <System.ComponentModel.Category("VCM Property")> _
    <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)> _
    <System.ComponentModel.Description("Asignar u Obtener el Formato de Cadena Personalizada")> _
    Public Property VCM_CustomInputTypeString() As String
        Get
            Return _mCustomTypeString
        End Get
        Set(ByVal Value As String)
            _mCustomTypeString = Value
        End Set
    End Property
    ''' <summary>Set or Get custom control's Custom Input Type string format</summary>
    <System.ComponentModel.Category("VCM Property")> _
    <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)> _
    <System.ComponentModel.Description("Omitir el Ingreso de estos caractéres")> _
    Public Property VCM_CustomOmmitString() As String
        Get
            Return _mCustomTypeStringOmmit
        End Get
        Set(ByVal Value As String)
            _mCustomTypeStringOmmit = Value
        End Set
    End Property
    ''' <summary>Set or Get control Auto Format Style</summary>
    <System.ComponentModel.Category("VCM Property")> _
    <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)> _
    <System.ComponentModel.Description("Asignar u Obtener el AutoFormato del Control")> _
    Property AutoFormat() As AUTOFORMATO_CONFIGURACION
        Get
            Return _mAutoFormatStyle
        End Get
        Set(ByVal Value As AUTOFORMATO_CONFIGURACION)
            _mAutoFormatStyle = Value
        End Set
    End Property
    ''' <summary>Set or Get controls mandatory status</summary>
    <System.ComponentModel.Category("VCM Property")> _
    <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)> _
    <System.ComponentModel.Description("Set or Get controls mandatory status")> _
    Public Property MandatoryField() As Boolean
        Get
            Return _mMandatoryField
        End Get
        Set(ByVal Value As Boolean)
            _mMandatoryField = Value
        End Set
    End Property
    ''' <summary>Set or Get the color of the control when the mandatory field is empty</summary>
    <System.ComponentModel.Category("VCM Property")> _
    <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)> _
    <System.ComponentModel.Description("Set or Get the color of the control when the mandatory field is empty")> _
    Public Property MandatoryColor() As Color
        Get
            Return _mMandatoryColor
        End Get
        Set(ByVal Value As Color)
            _mMandatoryColor = Value
        End Set
    End Property
    ''' <summary>Set or Get Number of decimal places</summary>
    <System.ComponentModel.Category("VCM Property")> _
    <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)> _
    <System.ComponentModel.Description("Setear Precision Decimal")> _
    Public Property VCM_NumeroPrecision() As PRECISION_CONFIGURACION
        Get
            Return _mPrecision
        End Get
        Set(ByVal value As PRECISION_CONFIGURACION)
            _mPrecision = value
        End Set
    End Property
    ''' <summary>Set or Get Regular Expression for Custom Validation</summary>
    <System.ComponentModel.Category("VCM Property")> _
    <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)> _
    <System.ComponentModel.Description("Asignar Expresion Regular")> _
    Public Property VCM_RegularExpression() As String
        Get
            Return _mRegularExpression
        End Get
        Set(ByVal value As String)
            _mRegularExpression = value
        End Set
    End Property
    ''' <summary>Set or Get Regular Expression Validation Custom Error Message</summary>
    <System.ComponentModel.Category("VCM Property")> _
    <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)> _
    <System.ComponentModel.Description("Mensaje de Validacion de Error en RegularExpression")> _
    Public Property VCM_RegularExpressionErrorMessage() As String
        Get
            Return _mRegularExpressionErrMsg
        End Get
        Set(ByVal value As String)
            _mRegularExpressionErrMsg = value
        End Set
    End Property
    ''' <summary>Set or Get automatic validation error display status</summary>
    <System.ComponentModel.Category("VCM Property")> _
    <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)> _
    <System.ComponentModel.Description("Mostrar u Ocultar Mensaje de Error")> _
    Public Property VCM_ShowMessage() As Boolean
        Get
            Return _mShowMsg
        End Get
        Set(ByVal Value As Boolean)
            _mShowMsg = Value
        End Set
    End Property
    ''' <summary>Set or Get controls validation status</summary>
    <System.ComponentModel.Category("VCM Property")> _
    <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)> _
    <System.ComponentModel.Description("Estado de Validacion")> _
    Public Property VCM_IsValidated() As Boolean
        Get
            Return _mIsValidated
        End Get
        Set(ByVal Value As Boolean)
            _mIsValidated = Value
        End Set
    End Property
    ''' <summary>Set or Get controls validation status</summary>
    <System.ComponentModel.Category("VCM Property")> _
    <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)> _
    <System.ComponentModel.Description("Enviar Key TAB al presionar Enter")> _
    Public Property VCM_EnterFocus() As Boolean
        Get
            Return _mEnterFocus
        End Get
        Set(ByVal Value As Boolean)
            _mEnterFocus = Value
        End Set
    End Property
#End Region

    '#Region " Metodos"
    '    ''' <summary>Calls to Show Controls Messages..</summary>
    '    <System.ComponentModel.Category("VCM Property")> _
    '    <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)> _
    '    <System.ComponentModel.Description("Llamar Mensajes de Control")> _
    '    Public Sub PopupBalloon(ByVal _Message As String, Optional ByVal _TipIcon As ToolTipIcon = ToolTipIcon.Info, Optional ByVal _TipTitle As String = "Input Validation Error..!!")
    '        Dim _ToolTip As New ToolTip
    '        _ToolTip.IsBalloon = True
    '        _ToolTip.ToolTipTitle = _TipTitle
    '        _ToolTip.ToolTipIcon = _TipIcon
    '        _ToolTip.UseAnimation = True
    '        _ToolTip.UseFading = True
    '        _ToolTip.SetToolTip(Me, _Message)
    '        _ToolTip.Show(_Message, Me, 2)
    '    End Sub
    '#End Region

    '#Region " Eventos de Controles"
    '    Private Sub SpoTextBox_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleCreated
    '        If _mblnMensajeFoco Then
    '            _objToolTip.SetToolTip(Me, _mstrMensajeFoco)
    '            _objToolTip.Active = False
    '            _objToolTip.ShowAlways = True
    '            _objToolTip.Active = True

    '            ' _objToolTip.
    '        End If
    '    End Sub
    '    ''' <summary>
    '    ''' Ocurre cuando el control obtiene el foco
    '    ''' </summary>
    '    ''' <param name="sender"></param>
    '    ''' <param name="e"></param>
    '    ''' <remarks></remarks>
    '    Private Sub OnTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
    '        Me.SelectAll()
    '    End Sub
    '    Private Sub OnTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
    '        'Me.SelectAll()
    '        'If Me.SelectionStart = Me.Text.Length Then
    '        '    SendKeys.Send("{END}")
    '        'End If
    '    End Sub
    '    Private Sub OnTextBox_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
    '        Me.SelectAll()
    '    End Sub
    '    Private Sub OnTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
    '        Dim lngDivisor As Long
    '        If String.IsNullOrEmpty(Me.Text) Then
    '            Select Case _mInputType
    '                Case TIPO_CONFIGURACION.NumeroEntero
    '                    Me.Text = 0
    '                Case TIPO_CONFIGURACION.NumeroDecimal
    '                    Me.Text = 0.0
    '            End Select
    '        Else
    '            Select Case _mInputType
    '                Case TIPO_CONFIGURACION.NumeroDecimal
    '                    'If Mid(Me.Text, 1, 1) = "." Then
    '                    '    lngDivisor = "1" & Replicate(0, Me.Text.Length - 1)
    '                    '    If Me.Text = "." Then
    '                    '        Me.Text = 0.0
    '                    '    Else

    '                    '        Me.Text = Int(Mid(Me.Text, 2, Me.Text.Length - 1)) / lngDivisor
    '                    '    End If

    '                    'End If
    '            End Select
    '        End If
    '        Me.DeselectAll()
    '    End Sub

    '    Public Function Replicate(ByVal cExpression As String, ByVal nTimes As Long) As String
    '        Dim i As Long, cResExpression As String = ""
    '        For i = 1 To nTimes
    '            cResExpression = cResExpression & cExpression
    '        Next i
    '        Replicate = cResExpression
    '    End Function
    '    Private Sub OnTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
    '        Me.BackColor = Me._mEnterFocusColor
    '    End Sub
    '    'Private Sub OnTextBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
    '    '    If ((Me.MandatoryField = True) And (CType(sender, TextBox).Text = String.Empty)) Then
    '    '        Me.BackColor = Me._mMandatoryColor
    '    '        _mIsValidated = False
    '    '    Else
    '    '        Me.BackColor = Me._mLeaveFocusColor
    '    '        _mIsValidated = True
    '    '    End If
    '    '    If ((IsNumeric(CType(sender, TextBox).Text) = True) And ((_mInputType = TIPO_CONFIGURACION.Moneda) Or (_mInputType = TIPO_CONFIGURACION.NumeroDecimal))) Then
    '    '        CType(sender, TextBox).Text = CDbl(CType(sender, TextBox).Text)
    '    '        'Select Case _mPrecision
    '    '        '    Case PRECISION_CONFIGURACION.UnDecimal

    '    '        '        CType(sender, TextBox).Text = Microsoft.VisualBasic.FormatNumber(CType(sender, TextBox).Text, 1)
    '    '        '    Case PRECISION_CONFIGURACION.DosDecimales
    '    '        '        CType(sender, TextBox).Text = Microsoft.VisualBasic.FormatNumber(CType(sender, TextBox).Text, 2)
    '    '        '    Case PRECISION_CONFIGURACION.TresDecimales
    '    '        '        CType(sender, TextBox).Text = Microsoft.VisualBasic.FormatNumber(CType(sender, TextBox).Text, 3)
    '    '        '    Case PRECISION_CONFIGURACION.CuatroDecimales
    '    '        '        CType(sender, TextBox).Text = Microsoft.VisualBasic.FormatNumber(CType(sender, TextBox).Text, 4)
    '    '        '    Case PRECISION_CONFIGURACION.CincoDecimales
    '    '        '        CType(sender, TextBox).Text = Microsoft.VisualBasic.FormatNumber(CType(sender, TextBox).Text, 5)
    '    '        '    Case PRECISION_CONFIGURACION.SeisDecimales
    '    '        '        CType(sender, TextBox).Text = Microsoft.VisualBasic.FormatNumber(CType(sender, TextBox).Text, 6)
    '    '        '    Case PRECISION_CONFIGURACION.SinDecimal
    '    '        '        CType(sender, TextBox).Text = Microsoft.VisualBasic.FormatNumber(CType(sender, TextBox).Text, 0)
    '    '        'End Select
    '    '    End If
    '    '    Select Case _mInputType
    '    '        Case TIPO_CONFIGURACION.SoloAlfabeto, TIPO_CONFIGURACION.AlfaNumerico, TIPO_CONFIGURACION.Personalizado, TIPO_CONFIGURACION.Normal, TIPO_CONFIGURACION.NumeroSerial
    '    '            Select Case _mAutoFormatStyle
    '    '                Case AUTOFORMATO_CONFIGURACION.UpperCase
    '    '                    CType(sender, TextBox).Text = CType(sender, TextBox).Text.ToUpper
    '    '                Case AUTOFORMATO_CONFIGURACION.LowerCase
    '    '                    CType(sender, TextBox).Text = CType(sender, TextBox).Text.ToLower
    '    '                Case AUTOFORMATO_CONFIGURACION.TitleCase
    '    '                    CType(sender, TextBox).Text = Microsoft.VisualBasic.StrConv(CType(sender, TextBox).Text, VbStrConv.ProperCase)
    '    '                Case AUTOFORMATO_CONFIGURACION.None
    '    '                    'DO NOTHING
    '    '            End Select
    '    '        Case Else
    '    '            'DO NOTHING
    '    '    End Select

    '    'End Sub
    Private Sub clsTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) And _mEnterFocus Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
         Select _mInputType
            Case TIPO_CONFIGURACION.NumeroEntero
                If ((Char.IsDigit(e.KeyChar) = False) And (Char.IsControl(e.KeyChar) <> True)) Then
                    e.Handled = True
                End If
            Case TIPO_CONFIGURACION.NumeroDecimal
                If ((Char.IsDigit(e.KeyChar) = False) And (Char.IsControl(e.KeyChar) <> True) And (e.KeyChar <> "."c)) Then
                    e.Handled = True
                End If
                If ((CType(sender, TextBox).Text.Contains("."c) = True) And (e.KeyChar = "."c)) Then
                    e.Handled = True
                End If
                'If ((CType(sender, TextBox).Text = String.Empty)) Then
                '    e.Handled = True
                'End If
            Case TIPO_CONFIGURACION.SoloAlfabeto
                Me.Text.Replace("'", "")
                If InStr(Me._mCustomTypeStringOmmit, e.KeyChar.ToString, CompareMethod.Binary) = 0 Then
                    e.Handled = False
                End If
                If ((Char.IsLetter(e.KeyChar) = False) And ((e.KeyChar <> Chr(32))) And (Char.IsControl(e.KeyChar) <> True)) Then
                    e.Handled = True
                End If
            Case TIPO_CONFIGURACION.Apellidos
                If ((Char.IsLetter(e.KeyChar) = False) And ((e.KeyChar <> Chr(32))) And (Char.IsControl(e.KeyChar) <> True) And (e.KeyChar <> "-"c)) Then
                    e.Handled = True
                End If
            Case TIPO_CONFIGURACION.SoloLectura
                'If ((Char.IsLetter(e.KeyChar) = False) And ((e.KeyChar <> Chr(32))) And (Char.IsControl(e.KeyChar) <> True) And (e.KeyChar <> "-"c)) Then
                e.Handled = True
                'End If
                'If ((CType(sender, TextBox).Text.Contains("-"c) = True) And (e.KeyChar = "-"c)) Then
                '    e.Handled = True
                'End If
            Case TIPO_CONFIGURACION.Unidad
                If ((Char.IsLetterOrDigit(e.KeyChar) = False) And (Char.IsControl(e.KeyChar) <> True) And (e.KeyChar <> "-"c) And (e.KeyChar <> "%"c)) Then
                    e.Handled = True
                End If
            Case TIPO_CONFIGURACION.AlfaNumerico
                If ( _
                (Char.IsLetterOrDigit(e.KeyChar) = False) _
                And ((e.KeyChar <> Chr(32))) _
                And (Char.IsControl(e.KeyChar) <> True) _
                And InStr(_mstrSimbolos, e.KeyChar, CompareMethod.Text) = 0) Then
                    e.Handled = True
                End If
            Case TIPO_CONFIGURACION.SoloLetrasNumeros
                If (InStr(_mstrLetrasNumeros, e.KeyChar, CompareMethod.Text) = 0) Then
                    If e.KeyChar = ChrW(Keys.Back) Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            Case TIPO_CONFIGURACION.CodigoAlfaNumerico
                If ( _
                (Char.IsLetterOrDigit(e.KeyChar) = False) _
                And ((e.KeyChar <> Chr(32))) _
                And (Char.IsControl(e.KeyChar) <> True) _
                And InStr(_mstrCodigo, e.KeyChar, CompareMethod.Text) = 0) Then
                    e.Handled = True
                End If
            Case TIPO_CONFIGURACION.Moneda
                If ((Char.IsDigit(e.KeyChar) = False) And (e.KeyChar <> "."c) And (e.KeyChar <> "+"c) And (e.KeyChar <> "-"c) And (Char.IsControl(e.KeyChar) <> True)) Then
                    e.Handled = True
                End If
                If ((CType(sender, TextBox).Text.Contains("."c) = True) And (e.KeyChar = "."c)) Then
                    e.Handled = True
                End If
                If ((CType(sender, TextBox).Text.Contains("-"c) = True) And (e.KeyChar = "-"c)) Then
                    e.Handled = True
                End If
                If ((CType(sender, TextBox).Text.Contains("+"c) = True) And (e.KeyChar = "+"c)) Then
                    e.Handled = True
                End If
                If ((CType(sender, TextBox).Text = String.Empty) And (e.KeyChar = "."c)) Then
                    e.Handled = True
                End If
                If ((e.KeyChar = "."c) And (CType(sender, TextBox).Text.Length = 1) And ((CType(sender, TextBox).Text = "+") Or (CType(sender, TextBox).Text = "-"))) Then
                    e.Handled = True
                End If
                If ((CType(sender, TextBox).Text <> String.Empty) And (e.KeyChar = "+"c)) Then
                    e.Handled = True
                End If
                If ((CType(sender, TextBox).Text <> String.Empty) And (e.KeyChar = "-"c)) Then
                    e.Handled = True
                End If
            Case TIPO_CONFIGURACION.NumeroTelefono
                If ((Char.IsDigit(e.KeyChar) = False) And (e.KeyChar <> "-"c) And (e.KeyChar <> "("c) And (e.KeyChar <> ")"c) And (e.KeyChar <> "+"c) And (Char.IsWhiteSpace(e.KeyChar) = False) And (Char.IsControl(e.KeyChar) <> True)) Then
                    e.Handled = True
                End If
                If ((CType(sender, TextBox).Text.Contains("("c) = True) And (e.KeyChar = "("c)) Then
                    e.Handled = True
                End If
                If ((CType(sender, TextBox).Text.Contains(")"c) = True) And (e.KeyChar = ")"c)) Then
                    e.Handled = True
                End If
                If ((CType(sender, TextBox).Text.Contains("+"c) = True) And (e.KeyChar = "+"c)) Then
                    e.Handled = True
                End If
            Case TIPO_CONFIGURACION.ConNegativo
                If ((Char.IsDigit(e.KeyChar) = False) And (e.KeyChar <> "-"c) And (Char.IsControl(e.KeyChar) <> True) And (e.KeyChar <> "."c)) Then
                    e.Handled = True
                End If
                If ((CType(sender, TextBox).Text.Contains("."c) = True) And (e.KeyChar = "."c)) Then
                    e.Handled = True
                End If
                'If ((CType(sender, TextBox).Text.Count > 0) And (e.KeyChar = "-"c)) Then
                '    e.Handled = True
                'End If
                'If ((CType(sender, TextBox).Text.Contains("-"c) = True) And (e.KeyChar = "-"c)) Then
                '    e.Handled = True
                'End If
            Case TIPO_CONFIGURACION.Normal
                'DO NOTHING
            Case TIPO_CONFIGURACION.CorreoElectronico
                If ((CType(sender, TextBox).Text.Contains("@"c) = True) And (e.KeyChar = "@"c)) Then
                    e.Handled = True
                End If
            Case TIPO_CONFIGURACION.NumeroSerial
                If ((Char.IsLetterOrDigit(e.KeyChar) = False) And (e.KeyChar <> "-"c) And (Char.IsWhiteSpace(e.KeyChar) = False) And (Char.IsControl(e.KeyChar) <> True)) Then
                    e.Handled = True
                End If
            Case TIPO_CONFIGURACION.Personalizado
                If ((InStr(Me._mCustomTypeString, e.KeyChar.ToString, CompareMethod.Binary) = 0) And (Char.IsControl(e.KeyChar) <> True)) Then
                    e.Handled = True
                End If


        End Select
      
    End Sub
    '    ''' <summary>
    '    ''' Se dispara cuando el usuario presiona una tecla sobre el control
    '    ''' Valida de acuerdo a la propiedad TipoDeIngreso los caracteres válidos
    '    ''' </summary>
    '    ''' <param name="sender"></param>
    '    ''' <param name="e"></param>
    '    ''' <remarks></remarks>
    '    Private Sub OnTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
    '        If e.KeyChar = ChrW(Keys.Enter) And _mEnterFocus Then
    '            e.Handled = True
    '            SendKeys.Send("{TAB}")
    '        End If
    '        Select Case _mInputType
    '            Case TIPO_CONFIGURACION.NumeroEntero
    '                If ((Char.IsDigit(e.KeyChar) = False) And (Char.IsControl(e.KeyChar) <> True)) Then
    '                    e.Handled = True
    '                End If
    '            Case TIPO_CONFIGURACION.NumeroDecimal
    '                If ((Char.IsDigit(e.KeyChar) = False) And (Char.IsControl(e.KeyChar) <> True) And (e.KeyChar <> ","c)) Then
    '                    e.Handled = True
    '                End If
    '                If ((CType(sender, TextBox).Text.Contains(","c) = True) And (e.KeyChar = ","c)) Then
    '                    e.Handled = True
    '                End If
    '                If ((CType(sender, TextBox).Text = String.Empty)) Then
    '                    e.Handled = True
    '                End If
    '                'If Me.Text.Length > 1 And Me.SelectionStart > InStr(Me.Text, ".", CompareMethod.Text) Then
    '                '    If InStr(Me.Text, ".", CompareMethod.Text) > 0 Then
    '                '        If Mid(Me.Text, InStr(Me.Text, ".", CompareMethod.Text), Me.Text.Length - InStr(Me.Text, ".", CompareMethod.Text)).Length >= _mPrecision Then
    '                '            e.Handled = True
    '                '        End If
    '                '    End If
    '                'End If
    '            Case TIPO_CONFIGURACION.SoloAlfabeto
    '                Me.Text.Replace("'", "")
    '                If InStr(Me._mCustomTypeStringOmmit, e.KeyChar.ToString, CompareMethod.Binary) = 0 Then
    '                    e.Handled = False
    '                End If
    '                If ((Char.IsLetter(e.KeyChar) = False) And ((e.KeyChar <> Chr(32))) And (Char.IsControl(e.KeyChar) <> True)) Then
    '                    e.Handled = True
    '                End If
    '            Case TIPO_CONFIGURACION.Apellidos
    '                If ((Char.IsLetter(e.KeyChar) = False) And ((e.KeyChar <> Chr(32))) And (Char.IsControl(e.KeyChar) <> True) And (e.KeyChar <> "-"c)) Then
    '                    e.Handled = True
    '                End If
    '            Case TIPO_CONFIGURACION.SoloLectura
    '                'If ((Char.IsLetter(e.KeyChar) = False) And ((e.KeyChar <> Chr(32))) And (Char.IsControl(e.KeyChar) <> True) And (e.KeyChar <> "-"c)) Then
    '                e.Handled = True
    '                'End If
    '                'If ((CType(sender, TextBox).Text.Contains("-"c) = True) And (e.KeyChar = "-"c)) Then
    '                '    e.Handled = True
    '                'End If
    '            Case TIPO_CONFIGURACION.Unidad
    '                If ((Char.IsLetterOrDigit(e.KeyChar) = False) And (Char.IsControl(e.KeyChar) <> True) And (e.KeyChar <> "-"c) And (e.KeyChar <> "%"c)) Then
    '                    e.Handled = True
    '                End If
    '            Case TIPO_CONFIGURACION.AlfaNumerico
    '                If ( _
    '                (Char.IsLetterOrDigit(e.KeyChar) = False) _
    '                And ((e.KeyChar <> Chr(32))) _
    '                And (Char.IsControl(e.KeyChar) <> True) _
    '                And InStr(_mstrSimbolos, e.KeyChar, CompareMethod.Text) = 0) Then
    '                    e.Handled = True
    '                End If
    '            Case TIPO_CONFIGURACION.SoloLetrasNumeros
    '                If (InStr(_mstrLetrasNumeros, e.KeyChar, CompareMethod.Text) = 0) Then
    '                    If e.KeyChar = ChrW(Keys.Back) Then
    '                        e.Handled = False
    '                    Else
    '                        e.Handled = True
    '                    End If
    '                End If
    '            Case TIPO_CONFIGURACION.CodigoAlfaNumerico
    '                If ( _
    '                (Char.IsLetterOrDigit(e.KeyChar) = False) _
    '                And ((e.KeyChar <> Chr(32))) _
    '                And (Char.IsControl(e.KeyChar) <> True) _
    '                And InStr(_mstrCodigo, e.KeyChar, CompareMethod.Text) = 0) Then
    '                    e.Handled = True
    '                End If
    '            Case TIPO_CONFIGURACION.Moneda
    '                If ((Char.IsDigit(e.KeyChar) = False) And (e.KeyChar <> "."c) And (e.KeyChar <> "+"c) And (e.KeyChar <> "-"c) And (Char.IsControl(e.KeyChar) <> True)) Then
    '                    e.Handled = True
    '                End If
    '                If ((CType(sender, TextBox).Text.Contains("."c) = True) And (e.KeyChar = "."c)) Then
    '                    e.Handled = True
    '                End If
    '                If ((CType(sender, TextBox).Text.Contains("-"c) = True) And (e.KeyChar = "-"c)) Then
    '                    e.Handled = True
    '                End If
    '                If ((CType(sender, TextBox).Text.Contains("+"c) = True) And (e.KeyChar = "+"c)) Then
    '                    e.Handled = True
    '                End If
    '                If ((CType(sender, TextBox).Text = String.Empty) And (e.KeyChar = "."c)) Then
    '                    e.Handled = True
    '                End If
    '                If ((e.KeyChar = "."c) And (CType(sender, TextBox).Text.Length = 1) And ((CType(sender, TextBox).Text = "+") Or (CType(sender, TextBox).Text = "-"))) Then
    '                    e.Handled = True
    '                End If
    '                If ((CType(sender, TextBox).Text <> String.Empty) And (e.KeyChar = "+"c)) Then
    '                    e.Handled = True
    '                End If
    '                If ((CType(sender, TextBox).Text <> String.Empty) And (e.KeyChar = "-"c)) Then
    '                    e.Handled = True
    '                End If
    '            Case TIPO_CONFIGURACION.NumeroTelefono
    '                If ((Char.IsDigit(e.KeyChar) = False) And (e.KeyChar <> "-"c) And (e.KeyChar <> "("c) And (e.KeyChar <> ")"c) And (e.KeyChar <> "+"c) And (Char.IsWhiteSpace(e.KeyChar) = False) And (Char.IsControl(e.KeyChar) <> True)) Then
    '                    e.Handled = True
    '                End If
    '                If ((CType(sender, TextBox).Text.Contains("("c) = True) And (e.KeyChar = "("c)) Then
    '                    e.Handled = True
    '                End If
    '                If ((CType(sender, TextBox).Text.Contains(")"c) = True) And (e.KeyChar = ")"c)) Then
    '                    e.Handled = True
    '                End If
    '                If ((CType(sender, TextBox).Text.Contains("+"c) = True) And (e.KeyChar = "+"c)) Then
    '                    e.Handled = True
    '                End If
    '            Case TIPO_CONFIGURACION.Normal
    '                'DO NOTHING
    '            Case TIPO_CONFIGURACION.CorreoElectronico
    '                If ((CType(sender, TextBox).Text.Contains("@"c) = True) And (e.KeyChar = "@"c)) Then
    '                    e.Handled = True
    '                End If
    '            Case TIPO_CONFIGURACION.NumeroSerial
    '                If ((Char.IsLetterOrDigit(e.KeyChar) = False) And (e.KeyChar <> "-"c) And (Char.IsWhiteSpace(e.KeyChar) = False) And (Char.IsControl(e.KeyChar) <> True)) Then
    '                    e.Handled = True
    '                End If
    '            Case TIPO_CONFIGURACION.Personalizado
    '                If ((InStr(Me._mCustomTypeString, e.KeyChar.ToString, CompareMethod.Binary) = 0) And (Char.IsControl(e.KeyChar) <> True)) Then
    '                    e.Handled = True
    '                End If


    '        End Select
    '    End Sub
    '    Public Function GetDistinctValues(ByVal dtable As DataTable, ByVal colName As String) As Object()
    '        Dim hTable As New Hashtable
    '        For Each drow As DataRow In dtable.Rows
    '            If Not hTable.ContainsKey(drow(colName)) Then
    '                hTable.Add(drow(colName), String.Empty)
    '            End If
    '        Next
    '        Dim objArray As Object() = New Object(hTable.Keys.Count - 1) {}
    '        hTable.Keys.CopyTo(objArray, 0)

    '        Return objArray
    '    End Function

    '#End Region
    '    Private Sub SpoTextBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
    '        If _mblnMensajeFoco Then
    '            _objToolTip.Active = True
    '        End If
    '    End Sub
End Class