Imports SI.BE
Imports SI.BC
Imports SI.PL.clsGeneral
Imports System.Drawing.Drawing2D

Imports System.Net
Imports System

Imports System.Configuration.ConfigurationManager

Public Class Login
    Private oGeneralRO As New clsBC_GeneralRO
    Private Function Validar() As Boolean
        Dim strMensaje As String = ""
        If txtUsuario.Text.Length = 0 Then
            strMensaje = "Ingrese Codigo de Usuario " & vbCrLf
        End If
        If txtPassword.Text.Length = 0 Then
            strMensaje = strMensaje & vbCrLf & "Ingrese Contraseña de Usuario " & vbCrLf
        End If
        If strMensaje.Length > 0 Then
            MsgBox(strMensaje, MsgBoxStyle.Critical, "Mensaje de Validacion")
            Return False
        End If
        Return True
    End Function
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Validar() Then
            With oGeneralRO
                .oBETablaDet.tablaDetId = txtUsuario.Text
                '.oBETablaDet.tablaDetId = "0000000001"
                .oBETablaDet.campo0 = txtPassword.Text
            End With
            pBEUsuario = oGeneralRO.Validar_Usuario()

            If pBEUsuario.descri <> "" Then
                Dim frm As New MDIParent
                Me.Hide()
                frm.Show()



                ' ''Auditoria
                ''Dim oBC_AuditoriaC = New clsBC_AuditoriaCTX
                ''Dim oBE_AuditoriaC As clsBE_AuditoriaC = New clsBE_AuditoriaC



                ''oBE_AuditoriaC.IdModulo = 1
                ''oBE_AuditoriaC.IdUsuario = pBEUsuario.tablaDetId

                ''oBE_AuditoriaC.UsuarioWin = Environment.UserName.ToString()
                ''oBE_AuditoriaC.UsuarioIp = Dns.GetHostByName(Environment.MachineName).AddressList(0).ToString()

                ''oBC_AuditoriaC.LstAuditoriaC.Add(oBE_AuditoriaC)
                ''pBEUsuario.IdAuditoria = oBC_AuditoriaC.InsertarAuditoriaC()
                ' ''pBEUsuario.IdAuditoria = 1

            Else
                MsgBox("Datos no válidos, verifique porfavor!!")
            End If
        End If



    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim sServer As String = AppSettings("SQLConexion").Split(";")(0).Split("=")(1)

        AutoCompletarUsuarios()
        'SI.PL.clsGeneral.pstrVersion = "Version : " & My.Application.Info.Version.ToString & " Server : " & sServer

        Dim fBuild As New System.IO.FileInfo(Environment.CurrentDirectory + "\VCM.exe")
        Dim dFechaBuild As String = fBuild.LastWriteTime


        SI.PL.clsGeneral.pstrVersion = "Version : " & dFechaBuild & "   Server : " & sServer

        lblVersion.Text = SI.PL.clsGeneral.pstrVersion ' "Version : " & My.Application.Info.Version.ToString
    End Sub
    Private Sub AutoCompletarUsuarios()
        Dim srcAutoCompleta As New AutoCompleteStringCollection
        Dim dsUsuarios As DataSet
        Dim oTablaDetRO As New clsBC_TablaDetRO
        Dim odwvUsuario As DataView
        oTablaDetRO.oBETablaDet.tablaId = "Usuario"
        dsUsuarios = oTablaDetRO.LeerListaToDSTablaDet
        odwvUsuario = New DataView(dsUsuarios.Tables(0))
        For Each Row As DataRow In odwvUsuario.Table.Select
            With srcAutoCompleta
                ''.Add(Row("tabladetID").ToString)
                .Add(Row("campo0").ToString)
            End With
        Next
        txtUsuario.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtUsuario.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtUsuario.AutoCompleteCustomSource = srcAutoCompleta
    End Sub

    Private Sub txtUsuario_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If keyData = Keys.Enter Then
            If txtUsuario.Focused And txtUsuario.Text <> "" Then
                txtPassword.Focus()
            ElseIf txtUsuario.Text = "" Then
                txtUsuario.Focus()
            End If
            If txtPassword.Focused And txtPassword.Text <> "" Then
                btnAceptar.Focus()
            ElseIf txtPassword.Text = "" Then
                txtPassword.Focus()
            End If
            If btnAceptar.Focused Then
                btnAceptar_Click(Nothing, Nothing)
            End If
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Private Sub txtUsuario_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtUsuario.Validating
        'If Me.txtUsuario.Text.Length = 0 Then
        '    Me.errAcceso.BlinkStyle = ErrorBlinkStyle.NeverBlink
        '    errAcceso.SetError(Me.txtUsuario, "Debe ingresar el usuario.")
        'Else
        '    errAcceso.SetError(Me.txtUsuario, "")
        'End If
    End Sub

    Private Sub Login_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim BaseRectangle As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)

        Dim Gradient_Brush As New LinearGradientBrush(BaseRectangle, Me.BackColor, Color.LemonChiffon, LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(Gradient_Brush, BaseRectangle)
    End Sub
End Class
