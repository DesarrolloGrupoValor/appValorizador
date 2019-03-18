Imports SI.BC
Imports SI.UT
Imports SI.BE
Imports SI.PL.clsFuncion
Imports System.Configuration
Imports SI.PL.clsGeneral

Imports SI.PL
Imports Microsoft.Reporting.WinForms

Public Class ComposicionContable
    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    Dim dvwRegistros As DataView

    Private Sub ExtraccionBd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ObtenerRegistros("", "")
    End Sub

    Private Sub ObtenerRegistros(ByVal empresa As String, ByVal periodo As String)
        Try
            ''Dim dsregistros As DataSet
            ''Dim oContratoRO As New clsBC_ContratoLoteRO
            ''oContratoRO.oBEContratoLote.codigoTabla = "" 'empresa
            ''oContratoRO.oBEContratoLote.comentarios = "" 'Year(periodo) & IIf(Month(periodo).ToString.Length > 1, "", "0") & Month(periodo)
            ''dsregistros = oContratoRO.LeerListaToDSComposicionContable
            ''dvwRegistros = New DataView(dsregistros.Tables(0))
            ''fxgrdExtraccionBd.DataSource = dvwRegistros

            ''Dim lsPagina As String = ConfigurationManager.AppSettings.Get("Urlreportes").ToString()
            ''Dim sParametros As String = "&usuario=" & pBEUsuario.descri & "&empresa=&periodo="
            ''Dim psurl As String = lsPagina + "ReportViewer.aspx?%2fVCM%2fCOMERCIAL%2f" & "Comercial_ComposicionContable" & "&rs:Command=Render" & sParametros


            ''Dim suri As New System.Uri(psurl)
            ''Dim authHeader As String = "Authorization: Basic " + Convert.ToBase64String(System.Text.UnicodeEncoding.ASCII.GetBytes("enproyec\valorizador" + ":" + "Password$")) + System.Environment.NewLine
            ''WebBrowser1.Navigate(suri.ToString, Nothing, Nothing, authHeader)


            Dim rpUsuario As New ReportParameter()
            rpUsuario.Name = "usuario"
            rpUsuario.Values.Add(pBEUsuario.descri)

            Dim rpPeriodo As New ReportParameter()
            rpPeriodo.Name = "periodo"
            rpPeriodo.Values.Add(periodo)

            'Set the report parameters for the report
            Dim parameters() As ReportParameter = {rpUsuario, rpPeriodo}

            Dim oProcedimientos As New clsProcedimientos
            oProcedimientos.ConfigurationReporting("Comercial_ComposicionContable", rptReportViewer, parameters)
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsMantenimiento_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        Try
            SaveFileDialog1.Filter = "Hojas de Excel|*.xls"
            SaveFileDialog1.ShowDialog()
            If SaveFileDialog1.FileName.Length > 0 Then
                fxgrdExtraccionBd.SaveExcel(SaveFileDialog1.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        '    ObtenerRegistros()
        Me.Dispose()

    End Sub
End Class