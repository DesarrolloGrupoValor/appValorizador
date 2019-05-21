Imports System.Security.Principal
Imports System.Net
Imports Microsoft.Reporting.WinForms

Imports System.Configuration
Imports SI.PL

Imports SI.BC
Imports SI.BE

Public Class Visor

    Private oMensajeError As mensajeError = New mensajeError

    Public psurl As String
    Public pTipo As String

    Public pContratoLoteId As String
    Public pLiquidacionId As String
    Public pUserNombre As String

    Public pContratoLiquidacion As String

    Private Sub Visor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        ' ''ReportViewer1.Width = 800
        ' ''ReportViewer1.Height = 600
        ''ReportViewer1.ProcessingMode = ProcessingMode.Remote

        ' ''Dim irsc As IReportServerCredentials = New CustomReportCredentials("administrator", "MYpassworw", "domena")
        ' ''ReportViewer1.ServerReport.ReportServerCredentials = irsc
        ''ReportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials = New System.Net.NetworkCredential("enproyec\valorizador", "Password$")
        ''ReportViewer1.ServerReport.ReportServerUrl = New Uri("http://mincorp001/ReportServer/")
        ''ReportViewer1.ServerReport.ReportPath = "/vcm/comercial/liquidacion"
        ''ReportViewer1.ServerReport.Refresh()
        ' ''rptViewer.ServerReport.ReportServerCredentials = New ReportServerCredentials("username", "pwd", "domain")
        ''Me.ReportViewer1.RefreshReport()

        Try

            Dim rpContratoLoteId As New ReportParameter()
            rpContratoLoteId.Name = "contratoLoteId"
            rpContratoLoteId.Values.Add(pContratoLoteId)

            Dim rpLiquidacionId As New ReportParameter()
            rpLiquidacionId.Name = "liquidacionId"
            rpLiquidacionId.Values.Add(pLiquidacionId)

            Dim rpUserNombre As New ReportParameter()
            rpUserNombre.Name = "UserNombre"
            rpUserNombre.Values.Add(pUserNombre)

            'Set the report parameters for the report
            Dim parameters() As ReportParameter = {rpContratoLoteId, rpLiquidacionId, rpUserNombre}


            Dim oProcedimientos As New clsProcedimientos
            oProcedimientos.ConfigurationReporting(pTipo, rptReportViewer, parameters, CrearDirectorios(pContratoLiquidacion), pContratoLiquidacion)
            'oProcedimientos.ConfigurationReporting(pTipo, rptReportViewer, parameters, "", pContratoLiquidacion)



            ' ''Dim lsPagina As String = ConfigurationManager.AppSettings.Get("Urlreportes").ToString()

            ' ''Dim sUser As String = ConfigurationManager.AppSettings.Get("user").ToString()
            ' ''Dim sPassword As String = ConfigurationManager.AppSettings.Get("password").ToString()
            ' ''Dim sDomain As String = ConfigurationManager.AppSettings.Get("domain").ToString()

            '' ''lsPagina = "http://desarrollo/ReportServer/"
            '' ''lsPagina = "http://mincorp001/ReportServer/"

            '' ''Set the processing mode for the ReportViewer to Remote
            ' ''ReportViewer1.ProcessingMode = ProcessingMode.Remote
            ' ''ReportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials = New System.Net.NetworkCredential(sUser, sPassword, sDomain)

            ' ''Dim serverReport As ServerReport
            ' ''serverReport = ReportViewer1.ServerReport

            '' ''Set the report server URL and report path
            ' ''serverReport.ReportServerUrl = New Uri(lsPagina)
            ' ''serverReport.ReportPath = "/vcm/comercial/" & pTipo ' & lsCadena
            '' ''serverReport.ReportPath = "/vcm/" & pTipo ' & lsCadena

            ' ''Dim rpContratoLoteId As New ReportParameter()
            ' ''rpContratoLoteId.Name = "contratoLoteId"
            ' ''rpContratoLoteId.Values.Add(pContratoLoteId)

            ' ''Dim rpLiquidacionId As New ReportParameter()
            ' ''rpLiquidacionId.Name = "liquidacionId"
            ' ''rpLiquidacionId.Values.Add(pLiquidacionId)

            ' ''Dim rpUserNombre As New ReportParameter()
            ' ''rpUserNombre.Name = "UserNombre"
            ' ''rpUserNombre.Values.Add(pUserNombre)

            '' ''Set the report parameters for the report
            ' ''Dim parameters() As ReportParameter = {rpContratoLoteId, rpLiquidacionId, rpUserNombre}
            ' ''serverReport.SetParameters(parameters)
            '' ''serverReport.Refresh()

            ' ''ReportViewer1.ZoomMode = ZoomMode.PageWidth

            ' ''ReportViewer1.RefreshReport()


        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub



    Private Function CrearDirectorios(ByVal sContratoLoteId As String)

        If Not sContratoLoteId Is Nothing Then

            Dim oBC_ContratoLoteRO As New clsBC_ContratoLoteRO
            oBC_ContratoLoteRO.oBEContratoLote = New clsBE_ContratoLote
            oBC_ContratoLoteRO.oBEContratoLote.contratoLoteId = pContratoLoteId
            oBC_ContratoLoteRO.LeerContratoLote()

            Dim sRucEmpresa As String = oBC_ContratoLoteRO.oBEContratoLote.rucEmpresa
            Dim sRucSocio As String = oBC_ContratoLoteRO.oBEContratoLote.codigoSocio
            Dim sParametroRuta As String
            Dim sContrato As String = RTrim(oBC_ContratoLoteRO.oBEContratoLote.codigoMovimiento) + RTrim(oBC_ContratoLoteRO.oBEContratoLote.contrato)
            Dim sLote As String = RTrim(oBC_ContratoLoteRO.oBEContratoLote.lote).Replace("/", "-")


            'Parametros de ruta de guardar archivos
            Dim oTablaDetRO = New clsBC_TablaDetRO
            oTablaDetRO.oBETablaDet.tablaId = "EL_Ruta"
            oTablaDetRO.oBETablaDet.tablaDetId = "0000000001"
            oTablaDetRO.oBETablaDet.campo0 = RTrim(oBC_ContratoLoteRO.oBEContratoLote.codigoMovimiento)
            oTablaDetRO.LeerListaToDSTablaDetCondicion()
            'sParametroRuta = oTablaDetRO.oBETablaDet.descri.ToString()
            sParametroRuta = oTablaDetRO.oDSTablaDet.Tables(0).Rows(0)("descri").ToString()


            Dim sRutaRucEmpresa As String = sParametroRuta + "\" + sRucEmpresa
            Dim sRutaRucSocio As String = sRutaRucEmpresa + "\" + sRucSocio
            Dim sRutaContrato As String = sRutaRucSocio + "\" + sContrato
            Dim sRutaLote As String = sRutaContrato + "\" + sContrato + "-" + sLote


            If System.IO.Directory.Exists(sRutaRucEmpresa) Then
                If System.IO.Directory.Exists(sRutaRucSocio) Then
                    If System.IO.Directory.Exists(sRutaContrato) Then
                        If System.IO.Directory.Exists(sRutaLote) Then
                        Else
                            System.IO.Directory.CreateDirectory(sRutaLote)
                        End If
                    Else
                        System.IO.Directory.CreateDirectory(sRutaContrato)
                        System.IO.Directory.CreateDirectory(sRutaLote)
                    End If
                Else
                    'System.IO.Directory.CreateDirectory(sRutaRucEmpresa)
                    System.IO.Directory.CreateDirectory(sRutaRucSocio)
                    System.IO.Directory.CreateDirectory(sRutaContrato)
                    System.IO.Directory.CreateDirectory(sRutaLote)
                End If
            Else
                System.IO.Directory.CreateDirectory(sRutaRucEmpresa)
                System.IO.Directory.CreateDirectory(sRutaRucSocio)
                System.IO.Directory.CreateDirectory(sRutaContrato)
                System.IO.Directory.CreateDirectory(sRutaLote)
            End If

            Return sRutaLote
        Else
            Return ""
        End If

        ''Return ""
    End Function

End Class

'Public Class ReportServerCredentials
'    Implements IReportServerCredentials
'    Private _userName As String
'    Private _password As String
'    Private _domain As String

'    Public Sub New(ByVal userName As String, ByVal password As String, ByVal domain As String)
'        _userName = userName
'        _password = password
'        _domain = domain
'    End Sub

'    Public ReadOnly Property ImpersonationUser() As WindowsIdentity
'        Get
'            ' Use default identity.
'            Return Nothing
'        End Get
'    End Property

'    Public ReadOnly Property NetworkCredentials() As ICredentials
'        Get
'            ' Use default identity.
'            Return New NetworkCredential(_userName, _password, _domain)
'        End Get
'    End Property

'    Public Function GetFormsCredentials(ByRef authCookie As Cookie, ByRef user As String, ByRef password As String, ByRef authority As String) As Boolean
'        ' Do not use forms credentials to authenticate.
'        authCookie = Nothing
'        user = InlineAssignHelper(password, InlineAssignHelper(authority, Nothing))
'        Return False
'    End Function
'    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
'        target = value
'        Return value
'    End Function
'End Class