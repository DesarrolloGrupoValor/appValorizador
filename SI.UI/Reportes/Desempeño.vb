Imports SI.BC
Imports SI.UT
Imports SI.BE
Imports SI.PL.clsFuncion
Imports SI.PL.clsGeneral
Imports System.Configuration

Imports SI.PL.clsEnumerado

Public Class Desempeño
    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    Dim dvwRegistros As DataView

    Private Sub Desempeño_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Try
            ObtenerRegistros("", "")

            Obtener_ParametrosCombo(cboClase, clsUT_Dominio.domTABLA_DE_CLASES, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            Obtener_ParametrosCombo(cboProducto, clsUT_Dominio.domTABLA_DE_PRODUCTOS, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            Obtener_ParametrosCombo(cboEmpresa, clsUT_Dominio.domTABLA_DE_EMPRESA, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            'ObtenerReporte()
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub ObtenerRegistros(ByVal empresa As String, ByVal periodo As String)
        Try
            Dim dsregistros As DataSet
            Dim oContratoRO As New clsBC_ContratoLoteRO
            oContratoRO.oBEContratoLote.codigoTabla = "" 'empresa
            oContratoRO.oBEContratoLote.comentarios = "" 'Year(periodo) & IIf(Month(periodo).ToString.Length > 1, "", "0") & Month(periodo)
            dsregistros = oContratoRO.LeerListaToDSDesempeño
            dvwRegistros = New DataView(dsregistros.Tables(0))
            fxgrdExtraccionBd.DataSource = dvwRegistros
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsMantenimiento_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        SaveFileDialog1.Filter = "Hojas de Excel|*.xls"
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName.Length > 0 Then
            fxgrdExtraccionBd.SaveExcel(SaveFileDialog1.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
        End If
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        '    ObtenerRegistros()
        Me.Dispose()

    End Sub

    Private Sub tsbConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsultar.Click

        ObtenerReporte()
    End Sub


    Private Sub ObtenerReporte()
        Try
            Dim lsPagina As String = ConfigurationManager.AppSettings.Get("Urlreportes").ToString()

            Dim sParametros As String = "&usuario=" & pBEUsuario.descri & "&codigoEmpresa=" & cboEmpresa.Text & "&codigoSocio=" & txtProveedor.Text & "&contrato=" & txtContrato.Text & "&codigoProducto=" & cboProducto.Text
            Dim psurl As String = lsPagina + "ReportViewer.aspx?%2fVCM%2fCOMERCIAL%2f" & "Comercial_Desempeño" & "&rs:Command=Render" & sParametros

            Dim suri As New System.Uri(psurl)
            Dim authHeader As String = "Authorization: Basic " + Convert.ToBase64String(System.Text.UnicodeEncoding.ASCII.GetBytes("enproyec\valorizador" + ":" + "Password$")) + System.Environment.NewLine
            WebBrowser1.Navigate(suri.ToString, Nothing, Nothing, authHeader)
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Public Shared Sub Obtener_ParametrosCombo(ByVal oCombo As ComboBox, ByVal strTabla As String, _
Optional ByVal lPrimerValor As enumPrimerValorCombo = enumPrimerValorCombo.Seleccione, _
Optional ByVal vintTipo As enumTipoComboGrilla = enumTipoComboGrilla.IdDescripcion)
        Try
            Dim oGeneral As New clsBC_GeneralRO
            Dim strPrimerValor As String = ""
            Select Case lPrimerValor
                Case enumPrimerValorCombo.Seleccione
                    strPrimerValor = "[Todos]"
                Case enumPrimerValorCombo.Todos
                    'strPrimerValor = "[Todos]"
                    strPrimerValor = ""
            End Select
            With oGeneral.oBEGeneral
                oGeneral.oBEGeneral.NomTabla = strTabla
                oGeneral.oBEGeneral.PrimerValor = strPrimerValor
                oGeneral.LstGeneral.Clear()
                oGeneral.Obtener_Parametros()
                oCombo.Items.Clear()
                oCombo.Items.Clear()
                oCombo.Items.Add(New ListViewItem(strPrimerValor, ""))
                If Not oGeneral Is Nothing Then
                    If vintTipo = enumTipoComboGrilla.IdDescripcion Then
                        oCombo.DataSource = oGeneral.LstGeneral
                        oCombo.DisplayMember = "Descripcion_Retorna"
                        oCombo.ValueMember = "Id_Retorna"
                        'For i As Integer = 0 To oGeneral.LstGeneral.Count - 1

                        '    oCombo.Items.Add(New ListViewItem(oGeneral.LstGeneral(i).Descripcion_Retorna, oGeneral.LstGeneral(i).Id_Retorna))
                        'Next
                        ' lCombo.SelectedIndex = 0
                    ElseIf vintTipo = enumTipoComboGrilla.IdCodigo Then
                        'For i As Integer = 0 To oGeneral.LstGeneral.Count - 1
                        '    oCombo.Items.Add(New ListViewItem(oGeneral.LstGeneral(i).Codigo_Retorna, oGeneral.LstGeneral(i).Id_Retorna))
                        'Next
                        oCombo.DataSource = oGeneral.LstGeneral
                        oCombo.DisplayMember = "Codigo_Retorna"
                        oCombo.ValueMember = "Id_Retorna"
                    ElseIf vintTipo = enumTipoComboGrilla.IDCodigoDescripcion Or vintTipo = enumTipoComboGrilla.IDDescripcionCodigo Then
                        'For i As Integer = 0 To oGeneral.LstGeneral.Count - 1
                        '    oCombo.Items.Add(New ListViewItem(oGeneral.LstGeneral(i).CodigoDescripcion_Retorna, oGeneral.LstGeneral(i).Id_Retorna))
                        'Next
                        oCombo.DataSource = oGeneral.LstGeneral
                        oCombo.DisplayMember = "CodigoDescripcion_Retorna"
                        oCombo.ValueMember = "Id_Retorna"
                    End If
                End If
            End With
        Catch ex As Exception
           
        End Try
    End Sub
 
End Class