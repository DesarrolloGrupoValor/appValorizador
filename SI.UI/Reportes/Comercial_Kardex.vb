Imports SI.BC
Imports SI.UT
Imports SI.BE
Imports SI.PL.clsFuncion
Imports SI.PL.clsGeneral

Imports SI.PL

Imports System.Configuration
Imports Microsoft.Reporting.WinForms

Public Class Comercial_Kardex
    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    Dim dvwRegistros As DataView

    Private Sub ExtraccionBd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.Dock = DockStyle.Fill
        Me.WindowState = FormWindowState.Maximized


        'ObtenerRegistros("", "")
        ObtenerPeriodos()
        'Me.rptReportViewer.RefreshReport()
        'Me.rptReportViewer.RefreshReport()
    End Sub

    Private Sub ObtenerRegistros(ByVal empresa As String, ByVal periodo As String)
        Try
            'Dim dsregistros As DataSet
            'Dim oContratoRO As New clsBC_ContratoLoteRO
            'oContratoRO.oBEContratoLote.codigoTabla = "" 'empresa
            'oContratoRO.oBEContratoLote.comentarios = Year(dtpPeriodo.Value) & IIf(Month(dtpPeriodo.Value).ToString.Length > 1, "", "0") & Month(dtpPeriodo.Value)
            'dsregistros = oContratoRO.LeerListaToDSComercial_Kardex
            'dvwRegistros = New DataView(dsregistros.Tables(0))
            'fxgrdExtraccionBd.DataSource = dvwRegistros

            'Dim lsPagina As String = ConfigurationManager.AppSettings.Get("Urlreportes").ToString()
            'Dim sParametros As String = "&usuario=" & pBEUsuario.descri & "&periodo=" & periodo
            'Dim psurl As String = lsPagina + "ReportViewer.aspx?%2fVCM%2fCOMERCIAL%2f" & "Comercial_Kardex" & "&rs:Command=Render" & sParametros


            'Dim suri As New System.Uri(psurl)
            ''Dim authHeader As String = "Authorization: Basic " + Convert.ToBase64String(System.Text.UnicodeEncoding.ASCII.GetBytes("enproyec\valorizador" + ":" + "Password$")) + System.Environment.NewLine
            'Dim authHeader As String = "Authorization: Basic " + Convert.ToBase64String(System.Text.UnicodeEncoding.ASCII.GetBytes("enproyec\valorizador" + ":" + "Password$")) + System.Environment.NewLine
            'WebBrowser1.Navigate(suri.ToString, Nothing, Nothing, authHeader)



            Dim rpUsuario As New ReportParameter()
            rpUsuario.Name = "usuario"
            rpUsuario.Values.Add(pBEUsuario.descri)

            Dim rpPeriodo As New ReportParameter()
            rpPeriodo.Name = "periodo"
            rpPeriodo.Values.Add(periodo)

            'Set the report parameters for the report
            Dim parameters() As ReportParameter = {rpUsuario, rpPeriodo}

            Dim oProcedimientos As New clsProcedimientos
            oProcedimientos.ConfigurationReporting("Comercial_Kardex", rptReportViewer, parameters)

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

    Private Sub gpoContratos_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gpoContratos.Enter

    End Sub

    Private Sub dtpPeriodo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpPeriodo.ValueChanged
        ObtenerRegistros("", "")
    End Sub


    Private Sub cboPeriodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriodo.SelectedIndexChanged
        If cboPeriodo.SelectedIndex > 0 Then
            ObtenerRegistros("", cboPeriodo.SelectedValue)
        End If
    End Sub

    Private Sub ObtenerPeriodos()
        Try
            Dim dsPeriodo As DataSet
            Dim oBC_PeriodoRO As New clsBC_PeriodoRO
            dsPeriodo = oBC_PeriodoRO.ObtenerPeriodo()

            cboPeriodo.DataSource = dsPeriodo.Tables(0)
            cboPeriodo.DisplayMember = "periodo"
            cboPeriodo.ValueMember = "periodoId"
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub
End Class