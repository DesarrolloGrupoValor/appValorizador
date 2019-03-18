Imports Microsoft.Reporting.WinForms

Imports SI.BC
Imports SI.BE
Imports SI.PL

Public Class frmGenerarPDF


    Public pParametros As ReportParameter()
    Public pNombreReporte As String
    Public pRutaGenerarPDF As String

    Public bSaveFile As Boolean
    Public pAbrilArchivo As Boolean

    Private Sub frmGenerarPDF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'Dim rpContratoLoteId As New ReportParameter()
        'rpContratoLoteId.Name = "contratoLoteId"
        'rpContratoLoteId.Values.Add(pContratoLoteId)

        'Dim rpLiquidacionId As New ReportParameter()
        'rpLiquidacionId.Name = "liquidacionId"
        'rpLiquidacionId.Values.Add(pLiquidacionId)

        'Dim rpUserNombre As New ReportParameter()
        'rpUserNombre.Name = "UserNombre"
        'rpUserNombre.Values.Add(pUserNombre)

        ''Set the report parameters for the report
        'Dim parameters() As ReportParameter = {rpContratoLoteId, rpLiquidacionId, rpUserNombre}


        Dim oProcedimientos As New clsProcedimientos

        If bSaveFile Then
            oProcedimientos.ConfigurationReportingSaveAs(pNombreReporte, rptReportViewer, pParametros, pRutaGenerarPDF, sfdSaveFileDialog)
        Else
            oProcedimientos.pAbrilArchivo = pAbrilArchivo
            oProcedimientos.ConfigurationReporting(pNombreReporte, rptReportViewer, pParametros, pRutaGenerarPDF)
        End If


        Me.Close()

    End Sub


    ''Private Function CrearDirectorios(ByVal sContratoLoteId As String)

    ''    If Not sContratoLoteId Is Nothing Then

    ''        Dim oBC_ContratoLoteRO As New clsBC_ContratoLoteRO
    ''        oBC_ContratoLoteRO.oBEContratoLote = New clsBE_ContratoLote
    ''        oBC_ContratoLoteRO.oBEContratoLote.contratoLoteId = sContratoLoteId
    ''        oBC_ContratoLoteRO.LeerContratoLote()

    ''        Dim sRucEmpresa As String = oBC_ContratoLoteRO.oBEContratoLote.rucEmpresa
    ''        Dim sRucSocio As String = oBC_ContratoLoteRO.oBEContratoLote.codigoSocio
    ''        Dim sParametroRuta As String
    ''        Dim sContrato As String = RTrim(oBC_ContratoLoteRO.oBEContratoLote.codigoMovimiento) + RTrim(oBC_ContratoLoteRO.oBEContratoLote.contrato)
    ''        Dim sLote As String = RTrim(oBC_ContratoLoteRO.oBEContratoLote.lote).Replace("/", "-")


    ''        'Parametros de ruta de guardar archivos
    ''        Dim oTablaDetRO = New clsBC_TablaDetRO
    ''        oTablaDetRO.oBETablaDet.tablaId = "EL_Ruta"
    ''        oTablaDetRO.oBETablaDet.tablaDetId = "0000000001"
    ''        oTablaDetRO.oBETablaDet.campo0 = RTrim(oBC_ContratoLoteRO.oBEContratoLote.codigoMovimiento)
    ''        oTablaDetRO.LeerListaToDSTablaDetCondicion()
    ''        'sParametroRuta = oTablaDetRO.oBETablaDet.descri.ToString()
    ''        sParametroRuta = oTablaDetRO.oDSTablaDet.Tables(0).Rows(0)("descri").ToString()


    ''        Dim sRutaRucEmpresa As String = sParametroRuta + "\" + sRucEmpresa
    ''        Dim sRutaRucSocio As String = sRutaRucEmpresa + "\" + sRucSocio
    ''        Dim sRutaContrato As String = sRutaRucSocio + "\" + sContrato
    ''        Dim sRutaLote As String = sRutaContrato + "\" + sContrato + "-" + sLote


    ''        If System.IO.Directory.Exists(sRutaRucEmpresa) Then
    ''            If System.IO.Directory.Exists(sRutaRucSocio) Then
    ''                If System.IO.Directory.Exists(sRutaContrato) Then
    ''                    If System.IO.Directory.Exists(sRutaLote) Then
    ''                    Else
    ''                        System.IO.Directory.CreateDirectory(sRutaLote)
    ''                    End If
    ''                Else
    ''                    System.IO.Directory.CreateDirectory(sRutaContrato)
    ''                    System.IO.Directory.CreateDirectory(sRutaLote)
    ''                End If
    ''            Else
    ''                'System.IO.Directory.CreateDirectory(sRutaRucEmpresa)
    ''                System.IO.Directory.CreateDirectory(sRutaRucSocio)
    ''                System.IO.Directory.CreateDirectory(sRutaContrato)
    ''                System.IO.Directory.CreateDirectory(sRutaLote)
    ''            End If
    ''        Else
    ''            System.IO.Directory.CreateDirectory(sRutaRucEmpresa)
    ''            System.IO.Directory.CreateDirectory(sRutaRucSocio)
    ''            System.IO.Directory.CreateDirectory(sRutaContrato)
    ''            System.IO.Directory.CreateDirectory(sRutaLote)
    ''        End If

    ''        Return sRutaLote
    ''    Else
    ''        Return ""
    ''    End If

    ''    ''Return ""
    ''End Function
End Class