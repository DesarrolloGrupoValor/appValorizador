Imports SI.PL.clsFuncion
Imports SI.PL.clsProcedimientos
Imports SI.PL.clsGeneral
Imports SI.UT
Imports SI.BC
Imports System.Data
Imports System.Drawing.Drawing2D
Imports SI.BE
Imports SI.UT.clsUT_Enumerado
Imports System.Configuration

Public Class ConsultaValorizador

    Dim dvwRegistros As DataView


    Private Sub ConsultaValorizador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim loclsBC_LiquidacionRO As New clsBC_LiquidacionRO

        'Dim dtold As New DataTable
        'dtold = loclsBC_LiquidacionRO.fnSelDTLiquidacionAll()
        'C1FlexGrid1.DataSource = dtold

        ObtenerRegistros("", "")

    End Sub

    Private Sub ObtenerRegistros(ByVal empresa As String, ByVal periodo As String)

        Dim dsregistros As DataSet
        Dim oContratoRO As New clsBC_ContratoLoteRO
        oContratoRO.oBEContratoLote.codigoTabla = "" 'empresa
        oContratoRO.oBEContratoLote.comentarios = "" 'Year(periodo) & IIf(Month(periodo).ToString.Length > 1, "", "0") & Month(periodo)
        dsregistros = oContratoRO.LeerListaToDSReporteLista
        dvwRegistros = New DataView(dsregistros.Tables(0))
        fxgrdReporteLista.DataSource = dvwRegistros

        For Each col As C1.Win.C1FlexGrid.Column In fxgrdReporteLista.Cols

            col.Format = "N3"

        Next

    End Sub


    Private Sub C1FlexGrid1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fxgrdReporteLista.KeyDown
        Select Case e.KeyCode
            Case Keys.C
                If e.Modifiers = Keys.Control Then
                    System.Windows.Forms.Clipboard.SetText(fxgrdReporteLista.Clip)

                End If
        End Select
    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        SaveFileDialog1.Filter = "Hojas de Excel|*.xls"
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName.Length > 0 Then
            fxgrdReporteLista.SaveExcel(SaveFileDialog1.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
        End If
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        '    ObtenerRegistros()
        Me.Dispose()

    End Sub

End Class