
Imports SI.PL.clsFuncion
Imports SI.PL.clsGeneral

Public Class FrmMatrizAsientos

    Public empresaID As String
    Public periodo As String
    Public periodo_destino As String
    Public anio As String
    Dim dvwRegistros As DataView

    Public pTipoFormulario As String
    'Public pCodigoEmpresa As String
    'Public pUsuario As String

    Private oMensajeError As mensajeError = New mensajeError

    Private Sub frmMatrizAsientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            ConfiguraForm(Me)

            If pTipoFormulario = "MATRIZ_ASIENTOS" Then
                Me.Text = "5. Matriz de Validación de Asientos"

                obtenerRegistro_MatrizAsientos()
            ElseIf pTipoFormulario = "DIF_TMH_VENTAS" Then
                Me.Text = "2. Reporte - Diferencia de tonelaje Concar vs VCM (Ventas)"
                obtenerRegistro_DiferenciaTMH()
            End If

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub obtenerRegistro_DiferenciaTMH()

        Dim oContratoRO As New SI.BC.clsBC_ContratoLoteRO
        oContratoRO.oBEContratoLote.codigoTabla = "" 'empresa
        oContratoRO.oBEContratoLote.periodo_origen = periodo '  'Year(dtpPeriodo.Value) & IIf(Month(dtpPeriodo.Value).ToString.Length > 1, "", "0") & Month(dtpPeriodo.Value)
        oContratoRO.oBEContratoLote.periodo_destino = periodo_destino
        oContratoRO.oBEContratoLote.codigoEmpresa = empresaID
        oContratoRO.oBEContratoLote.um = pBEUsuario.tablaDetId

        Dim dsregistros As DataSet = oContratoRO.LeerListaToDSContable_DiferenciaTMHVenta
        dvwRegistros = New DataView(dsregistros.Tables(0))
        fxgrdMatriz.DataSource = dvwRegistros

        For nContador As Integer = 1 To fxgrdMatriz.Cols.Count - 1
            'fxgrdMatriz.Cols(nContador).Format = "N2"
            fxgrdMatriz.Cols(nContador).Width = 100
            fxgrdMatriz.Cols(nContador).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter

            'If nContador = 11 Or nContador = 12 Then
            '    'fxgrdMatriz.Cols(nContador).Width = 85
            '    fxgrdMatriz.Cols(nContador).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
            'End If

            If nContador >= 2 And nContador <= 4 Then
                fxgrdMatriz.Cols(nContador).Visible = False
            End If

            If nContador >= 6 And nContador <= 12 Then
                fxgrdMatriz.Cols(nContador).Format = "N2"
                fxgrdMatriz.Cols(nContador).Width = 120
                fxgrdMatriz.Cols(nContador).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
            End If
        Next

        'NEGRITA EL TOTAL DE LA DIFERENCIA
        Dim rs As C1.Win.C1FlexGrid.CellStyle
        rs = fxgrdMatriz.Styles.Add("bold")
        rs.Font = New Font(DefaultFont, FontStyle.Bold)
        fxgrdMatriz.Rows(fxgrdMatriz.Rows.Count - 1).Style = rs

    End Sub

    Private Sub obtenerRegistro_MatrizAsientos()
        Try
            Dim oGeneralRO As New SI.BC.clsBC_GeneralRO()
            With oGeneralRO.oBEGeneral
                .ValCampo1 = empresaID
                .ValCampo2 = periodo
                .ValCampo3 = anio

            End With

            Dim ds As DataSet = oGeneralRO.Obtener_RegistrosToMatrizDS

            If ds Is Nothing Then
                MsgBox("No hay registros para mostrar.", MsgBoxStyle.Information, "Valorizador de Minerales")
                Me.Dispose()
            Else
                dvwRegistros = New DataView(ds.Tables(0))
                fxgrdMatriz.AutoGenerateColumns = True
                fxgrdMatriz.DataSource = dvwRegistros
                ' fxgrdMatriz.DataSource = ds.Tables(0)
            End If

            For Each col As C1.Win.C1FlexGrid.Column In fxgrdMatriz.Cols
                col.Format = "N2"
            Next
            fxgrdMatriz.Cols(1).Width = 120
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        SaveFileDialog1.Filter = "Hojas de Excel|*.xls"
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName.Length > 0 Then
            fxgrdMatriz.SaveExcel(SaveFileDialog1.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
        End If
    End Sub


End Class