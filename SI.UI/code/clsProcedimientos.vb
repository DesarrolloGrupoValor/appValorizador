Imports SI.PL.clsEnumerado
Imports SI.BC
Imports SI.UT.clsUT_Enumerado
Imports SI.BE
Imports System.Collections.Generic

Imports Microsoft.Reporting.WinForms
Imports System.Configuration

Imports System.IO
Imports Microsoft.Office.Interop

Namespace SI.PL
    Public Class clsProcedimientos

        Private oMensajeError As mensajeError = New mensajeError

        Public pContratoLiquidacion As String
        Public pAbrilArchivo As Boolean = True

        Public Shared Sub OrdenDatagridview(ByVal dgvDatos As DataGridView, ByVal blnSortMode As DataGridViewColumnSortMode)
            For Each col As DataGridViewColumn In dgvDatos.Columns
                If col.Visible Then
                    col.SortMode = blnSortMode
                End If
            Next
        End Sub
        Public Shared Sub valida_caracterSQL(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
            If (e.KeyChar = "'"c) Or (e.KeyChar = "%"c) Then
                'If sender.Text.Trim() = "" Then
                e.Handled = True
                'End If
            End If
            ' End If
        End Sub
        Public Shared Sub MostrarFormulario(ByVal formulario As enumTipoFormulario, Optional ByVal nomParametro As String = "", Optional ByVal valParametro As String = "", Optional ByVal modal As Boolean = False)
            '' Dim lFormulario As Form
            'Select Case modal
            '    Case True

            '    Case False

            'End Select
            'Select Case formulario
            '    Case enumTipoFormulario.Contrato
            '        Dim lFormulario As New contratos
            '        lFormulario.Owner = Principal
            '        lFormulario.ShowInTaskbar = True
            '        lFormulario.StartPosition = FormStartPosition.CenterParent
            '        If modal Then
            '            lFormulario.ShowDialog()
            '        Else
            '            lFormulario.Show()
            '        End If
            '        'lFormulario = New frm_acceso
            '    Case enumTipoFormulario.CopiarContrato
            '        Dim lFormulario As New editcontrato
            '        lFormulario.Owner = Principal
            '        lFormulario.ShowInTaskbar = True
            '        lFormulario.pblnCopia = True
            '        lFormulario.StartPosition = FormStartPosition.CenterParent
            '        lFormulario.pstrCorrelativo = valParametro
            '        If modal Then
            '            lFormulario.ShowDialog()
            '        Else
            '            lFormulario.Show()
            '        End If
            '    Case enumTipoFormulario.EditarContrato
            '        Dim lFormulario As New editcontrato
            '        lFormulario.Owner = Principal
            '        lFormulario.ShowInTaskbar = True
            '        lFormulario.StartPosition = FormStartPosition.CenterParent
            '        lFormulario.pstrCorrelativo = valParametro
            '        If modal Then
            '            lFormulario.ShowDialog()
            '        Else
            '            lFormulario.Show()
            '        End If
            '    Case enumTipoFormulario.NuevoContrato
            '        Dim lFormulario As New editcontrato
            '        lFormulario.Owner = Principal
            '        lFormulario.pblnNuevo = True
            '        lFormulario.ShowInTaskbar = True
            '        lFormulario.StartPosition = FormStartPosition.CenterParent
            '        If modal Then
            '            lFormulario.ShowDialog()
            '        Else
            '            lFormulario.Show()
            '        End If
            '    Case enumTipoFormulario.Configuracion
            '        Dim lFormulario As New configuracion
            '        lFormulario.Owner = Principal
            '        lFormulario.ShowInTaskbar = False
            '        lFormulario.StartPosition = FormStartPosition.CenterParent
            '        If modal Then
            '            lFormulario.ShowDialog()
            '        Else
            '            lFormulario.Show()
            '        End If
            '    Case enumTipoFormulario.TablaDetalle
            '        Dim lFormulario As New frmTabla
            '        lFormulario.Owner = Principal
            '        lFormulario.ShowInTaskbar = true
            '        lFormulario.StartPosition = FormStartPosition.CenterParent
            '        If modal Then
            '            lFormulario.ShowDialog()
            '        Else
            '            lFormulario.Show()
            '        End If
            'End Select


        End Sub
        Public Shared Sub MostrarFormularioAyuda( _
                ByVal lFormAyuda As EnumFormAyuda, _
                ByRef oGeneral As clsBC_GeneralRO, _
                Optional ByVal blnMultiSelect As Boolean = False, _
                Optional ByVal vParametros As Hashtable = Nothing, _
                Optional ByVal vstrWhere As String = "", Optional ByVal strFiltroMovimiento As String = "B,D,P,S,V")
            Dim lFormulario As New frmAyuda
            lFormulario.pFormAyuda = lFormAyuda
            lFormulario.pblnMultiSelect = blnMultiSelect
            lFormulario.StartPosition = FormStartPosition.CenterParent
            lFormulario.Owner = MDIParent
            Select Case lFormAyuda
                Case EnumFormAyuda.Socio
                    lFormulario.pstrNomFormulario = "Cliente/Proveedor"
                    lFormulario.pstrTituloCodigo = "RUC"
                Case EnumFormAyuda.Contratos
                    lFormulario.pstrTituloCodigo = "Contrato"
                    lFormulario.pstrTituloDescripcion = "Cliente/Proveedor"
                    lFormulario.pstrFiltroMovimiento = strFiltroMovimiento



                Case EnumFormAyuda.Adelanto
                    lFormulario.pstrTituloCodigo = "Item"
                    lFormulario.pstrTituloDescripcion = "Monto"
                    lFormulario.pstrFiltroMovimiento = strFiltroMovimiento
                    lFormulario.pstrNomFormulario = "Asociación de Adelanto"



                Case EnumFormAyuda.Beneficiario
                    lFormulario.pstrTituloCodigo = "Item"
                    lFormulario.pstrTituloDescripcion = "Monto"
                    lFormulario.pstrFiltroMovimiento = strFiltroMovimiento
                    lFormulario.pstrNomFormulario = "Asociación de Adelanto"


                Case EnumFormAyuda.Anexo_Banco
                    lFormulario.pstrTituloCodigo = "Item"
                    lFormulario.pstrTituloDescripcion = "Monto"
                    lFormulario.pstrFiltroMovimiento = strFiltroMovimiento
                    lFormulario.pstrNomFormulario = "Anexo de Banco"


                Case EnumFormAyuda.OtrasCuentasXCobrar
                    lFormulario.pstrTituloCodigo = "Item"
                    lFormulario.pstrTituloDescripcion = "Monto"
                    lFormulario.pstrFiltroMovimiento = strFiltroMovimiento
                    lFormulario.pstrNomFormulario = "Otras Cuentas por Cobrar"

                Case EnumFormAyuda.PrestamosCChica
                    lFormulario.pstrTituloCodigo = "Item"
                    lFormulario.pstrTituloDescripcion = "Monto"
                    lFormulario.pstrFiltroMovimiento = strFiltroMovimiento
                    lFormulario.pstrNomFormulario = "Préstamos de Caja Chica"

                Case EnumFormAyuda.PrestamosComer
                    lFormulario.pstrTituloCodigo = "Item"
                    lFormulario.pstrTituloDescripcion = "Monto"
                    lFormulario.pstrFiltroMovimiento = strFiltroMovimiento
                    lFormulario.pstrNomFormulario = "Préstamos de Comercial"

                Case Else
                    lFormulario.pstrTituloCodigo = "Codigo"
            End Select
            If Not (vParametros Is Nothing) Then
                If vParametros.Count > 0 Then
                    lFormulario.pParametros = vParametros
                End If
            End If
            lFormulario.pstrWhere = vstrWhere
            lFormulario.ShowDialog()
            oGeneral = lFormulario.oGeneral
            lFormulario.Close()
        End Sub
        Public Shared Sub MostrarFormularioLiquidacion(ByVal strCorrelativo As String)
            Dim lFormulario As New liquidacion

            lFormulario.StartPosition = FormStartPosition.CenterParent
            lFormulario.Owner = MDIParent

            lFormulario.pstrCorrelativo = strCorrelativo
            lFormulario.ShowDialog()

            lFormulario.Close()
        End Sub

        Public Shared Sub MostrarFormularioAsociacion(ByVal lFormulario As frmIntermedia, ByVal strCorrelativo As String, ByVal strCorrelativoLiquidacion As String, ByVal strCorrelativoLiquidacionTm As String, ByVal merma As Double, ByRef dtLiquidacion As DataTable, Optional ByVal tipo_movimiento As String = "", Optional ByVal tipo_producto As String = "", Optional ByVal socio As String = "", Optional ByVal empresa As String = "", Optional ByVal deposito As String = "", Optional ByVal loteOrigen As String = "", Optional ByVal codigoClase As String = "", Optional ByVal categoria As String = "")
            'Dim lFormulario As New frmIntermedia

            lFormulario.StartPosition = FormStartPosition.CenterParent
            lFormulario.Owner = MDIParent
            lFormulario.pstrSocio = socio
            lFormulario.pstrEmpresa = empresa
            lFormulario.pstrDeposito = deposito
            lFormulario.pLoteOrigen = loteOrigen

            lFormulario.pstrCodigoClase = codigoClase

            lFormulario.pstrCategoria = categoria

            lFormulario.pstrTipoMovimiento = tipo_movimiento
            lFormulario.pstrTipoProducto = tipo_producto
            lFormulario.pdblMerma = merma
            lFormulario.pdtLiquidacion = dtLiquidacion
            lFormulario.pstrCorrelativo = strCorrelativo
            lFormulario.pstrCorrelativoLiquidacion = strCorrelativoLiquidacion
            lFormulario.pstrCorrelativoLiquidacionTm = strCorrelativoLiquidacionTm
            lFormulario.ShowDialog()

            lFormulario.Close()
        End Sub
        Public Shared Sub OcultarColumnas(ByVal fxGrid As C1.Win.C1TrueDBGrid.C1TrueDBGrid, ByVal intCol As String, Optional ByVal ocultar As Boolean = False)
            For Each col As C1.Win.C1TrueDBGrid.C1DataColumn In fxGrid.Columns
                Dim dc As C1.Win.C1TrueDBGrid.C1DisplayColumn
                dc = fxGrid.Splits(0).DisplayColumns.Item(col.Caption)
                If ocultar Then
                    If InStr(intCol, dc.ToString, CompareMethod.Text) <= 0 Then
                        dc.Visible = False
                    End If
                Else
                    If InStr(intCol, dc.ToString, CompareMethod.Text) > 0 Then
                        dc.Visible = False
                    End If

                End If

                'Dim dc As C1.Win.C1TrueDBGrid.C1DisplayColumn
                'If (Left(col.Caption.ToLower, 2) = "id") Or (Right(col.Caption.ToLower, 2) = "id") Or InStr(col.Caption.ToLower, "estado") > 0 Or InStr(col.Caption, "uc") > 0 Or InStr(col.Caption, "um") > 0 Or InStr(col.Caption, "fc") > 0 Or InStr(col.Caption, "fm") > 0 Or InStr(col.Caption.ToLower, "calculo") > 0 Then
                '    dc = fxGrid.Splits(0).DisplayColumns.Item(col.Caption)
                '    dc.Visible = False
                'End If
            Next
        End Sub
        Private Shared Function BuscarColumna(ByVal cols As List(Of String), ByVal columna As String) As Boolean
            For Each val As String In cols
                If val.ToLower = columna.ToLower Then
                    Return True
                End If
            Next
            Return False
        End Function
        Public Shared Sub EditarColumnasModificables(ByVal dgvMantenimiento As DataGridView, ByVal columnas As String, Optional ByVal inverso As Boolean = False, Optional ByVal columnasocultar As String = "")
            Try
                Dim dwgFondoFilaEdicion As Color = Drawing.Color.White
                Dim dwgFondoFilaLectura As Color = Drawing.Color.FromArgb(204, 204, 204)
                Dim arrColumnas() As String = columnas.Split(",")
                Dim valColumnas As List(Of String) = arrColumnas.ToList()
                Dim arrColumnasOcultar() As String = columnasocultar.Split(",")
                Dim valColumnasOcultar As List(Of String) = arrColumnasOcultar.ToList()
                dgvMantenimiento.Focus()
                dgvMantenimiento.ReadOnly = False
                For Each SelectedCol As DataGridViewColumn In dgvMantenimiento.Columns
                    If BuscarColumna(valColumnasOcultar, SelectedCol.Name.ToString) Then
                        SelectedCol.Visible = False
                    Else
                        If inverso Then
                            If BuscarColumna(valColumnas, SelectedCol.Name.ToString) Then
                                SelectedCol.ReadOnly = True
                                SelectedCol.DefaultCellStyle.BackColor = dwgFondoFilaLectura 'Color.White
                            Else
                                SelectedCol.ReadOnly = False
                                SelectedCol.DefaultCellStyle.BackColor = dwgFondoFilaEdicion
                            End If
                        Else
                            If BuscarColumna(valColumnas, SelectedCol.Name.ToString) Then
                                SelectedCol.ReadOnly = False
                                SelectedCol.DefaultCellStyle.BackColor = dwgFondoFilaEdicion 'Color.White
                            Else
                                SelectedCol.ReadOnly = True
                                SelectedCol.DefaultCellStyle.BackColor = dwgFondoFilaLectura
                            End If
                        End If
                    End If

                Next
                'For Each SelectedRow As DataGridViewRow In dgvMantenimiento.Rows
                '    For Each SelectedCol As DataGridViewColumn In SelectedRow.DataGridView.Columns

                '    Next
                '    Exit For
                'Next
            Catch ex As Exception
                MessageBox.Show("Error", ex.Message)
            End Try
        End Sub



        Public Function ConfigurationReporting(ByVal sReportName As String, ByVal oReportViewer As ReportViewer, ByVal oReportParameter() As ReportParameter, Optional ByVal sFilePath As String = "", Optional ByVal sContratoLiquidacion As String = "")
            Try
                Dim lsPagina As String = ConfigurationManager.AppSettings.Get("Urlreportes").ToString()

                Dim sUser As String = ConfigurationManager.AppSettings.Get("user").ToString()
                Dim sPassword As String = ConfigurationManager.AppSettings.Get("password").ToString()
                Dim sDomain As String = ConfigurationManager.AppSettings.Get("domain").ToString()

                'lsPagina = "http://desarrollo/ReportServer/"
                'lsPagina = "http://mincorp001/ReportServer/"

                'Set the processing mode for the ReportViewer to Remote
                oReportViewer.ProcessingMode = ProcessingMode.Remote
                oReportViewer.ServerReport.ReportServerCredentials.NetworkCredentials = New System.Net.NetworkCredential(sUser, sPassword, sDomain)

                Dim serverReport As ServerReport
                serverReport = oReportViewer.ServerReport

                'Set the report server URL and report path
                serverReport.ReportServerUrl = New Uri(lsPagina)
                serverReport.ReportPath = "/vcm/comercial/" & sReportName '& "&rs:command=render&rs:format=PDF" ' & lsCadena
                'serverReport.ReportPath = "/vcm/" & pTipo ' & lsCadena


                'Dim parameters() As ReportParameter = {rpContratoLoteId, rpLiquidacionId, rpUserNombre}
                serverReport.SetParameters(oReportParameter)
                'serverReport.Refresh()


                oReportViewer.ShowParameterPrompts = False

                oReportViewer.ZoomMode = ZoomMode.PageWidth
                oReportViewer.RefreshReport()


                ''Dim result As Byte() = Nothing
                ''result = serverReport.Render("pdf")
                ''Try
                ''    Dim stream As FileStream = File.Create("C:\Valorizador\samplereport.pdf", result.Length)
                ''    Console.WriteLine("File created.")
                ''    stream.Write(result, 0, result.Length)
                ''    Console.WriteLine("Result written to the file.")
                ''    stream.Close()

                ''Catch e As Exception
                ''    Console.WriteLine(e.Message)
                ''End Try


                If sFilePath <> "" Then
                    'Obtiene el PDF
                    Dim bytes As Byte()
                    bytes = oReportViewer.ServerReport.Render("PDF", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

                    ''elimina el PDF
                    'If File.Exists(sContratoLiquidacion) Then

                    'sFilePath = "F:\Informations\VCM\DOCUMENTOS_ESTADO_LIQUIDACION\VINCULADAS\" + sFilePath
                    If File.Exists(sFilePath) Then
                        File.Delete(sFilePath)
                    End If


                    If sContratoLiquidacion <> "" Then
                     sFilePath = sFilePath & "\" & sContratoLiquidacion 

                    End If

                    'sFilePath = sFilePath & "\" & sContratoLiquidacion '-----*********************ESTADO LIQUIDACION
                    'sFilePath = sFilePath & "\" & sContratoLiquidacion '-----*********************ESTADO LIQUIDACION

                    ''Crea el PDF
                    Dim fs As New FileStream(sFilePath, FileMode.Create, System.IO.FileAccess.ReadWrite)
                    fs.Write(bytes, 0, bytes.Length)
                    fs.Close()


                    If sContratoLiquidacion = "" And pAbrilArchivo = True Then
                        Dim processInfo As New ProcessStartInfo("explorer.exe", sFilePath)
                        Process.Start(processInfo)
                    End If

                End If


                'Me.Dispose()
                'Me.Close()


            Catch ex As Exception
                oMensajeError.txtMensaje.Text = ex.ToString()
                oMensajeError.ShowDialog()
            End Try

            Return oReportViewer
        End Function


        'Llama el reporting, enviando la ruta para guardar el archivo
        Public Function ConfigurationReportingSaveAs(ByVal sReportName As String, ByVal oReportViewer As ReportViewer, ByVal oReportParameter() As ReportParameter, Optional ByVal sFilePath As String = "", Optional ByVal sfdSaveFileDialog As SaveFileDialog = Nothing)
            Try
                Dim lsPagina As String = ConfigurationManager.AppSettings.Get("Urlreportes").ToString()

                Dim sUser As String = ConfigurationManager.AppSettings.Get("user").ToString()
                Dim sPassword As String = ConfigurationManager.AppSettings.Get("password").ToString()
                Dim sDomain As String = ConfigurationManager.AppSettings.Get("domain").ToString()


                'Set the processing mode for the ReportViewer to Remote
                oReportViewer.ProcessingMode = ProcessingMode.Remote
                oReportViewer.ServerReport.ReportServerCredentials.NetworkCredentials = New System.Net.NetworkCredential(sUser, sPassword, sDomain)

                Dim serverReport As ServerReport
                serverReport = oReportViewer.ServerReport

                'Set the report server URL and report path
                serverReport.ReportServerUrl = New Uri(lsPagina)
                serverReport.ReportPath = "/vcm/comercial/" & sReportName '& "&rs:command=render&rs:format=PDF" ' & lsCadena

                serverReport.SetParameters(oReportParameter)
                'serverReport.Refresh()


                oReportViewer.ZoomMode = ZoomMode.PageWidth
                oReportViewer.RefreshReport()


                If sFilePath <> "" Then
                    'Obtiene el PDF
                    Dim bytes As Byte()
                    bytes = oReportViewer.ServerReport.Render("PDF", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

                    'elimina el PDF
                    'File.Delete(sFilePath)

                    sfdSaveFileDialog.InitialDirectory = sFilePath
                    sfdSaveFileDialog.Filter = "Archivo PDF|*.pdf|All files (*.*)|*.*"
                    If sfdSaveFileDialog.ShowDialog = DialogResult.OK Then
                        sFilePath = sfdSaveFileDialog.FileName

                        'Crea el PDF
                        Dim fs As New FileStream(sFilePath, FileMode.Create)
                        fs.Write(bytes, 0, bytes.Length)
                        fs.Close()

                        Dim processInfo As New ProcessStartInfo("explorer.exe", sFilePath)
                        Process.Start(processInfo)
                    End If

                   
                End If


                'Me.Dispose()
                'Me.Close()


            Catch ex As Exception
                oMensajeError.txtMensaje.Text = ex.ToString()
                oMensajeError.ShowDialog()
            End Try

            Return oReportViewer
        End Function


        Public Shared Sub EnvioCorreo(ByVal sDestinatario As String, ByVal sAsunto As String, ByVal sContenido As String)
            Dim m_OutLook As Outlook.Application
            Dim objMail As Outlook.MailItem

            m_OutLook = New Outlook.Application
            objMail = m_OutLook.CreateItem(Outlook.OlItemType.olMailItem)
            objMail.To = sDestinatario
            objMail.Subject = sAsunto
            objMail.Body = sContenido
            objMail.Send()
        End Sub

    End Class

End Namespace
