Imports SI.PL.clsFuncion
Imports SI.PL.clsGeneral
Imports SI.PL.clsProcedimientos
Imports SI.UT
Imports SI.BC
Imports System.Data
Imports System.Drawing.Drawing2D
Imports SI.BE
Imports SI.UT.clsUT_Enumerado
Imports System.Configuration

Imports Microsoft.Reporting.WinForms

Public Class frmRumasPendientes

    Private oMensajeError As mensajeError = New mensajeError

    Private Sub frmRumasPendientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ConfiguraForm(Me)
        cargarGrilla()
    End Sub


    Private Sub tsbConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsulta.Click
        cargarGrilla()

    End Sub

    Private Sub cargarGrilla()
        Dim oBC_ContratoLoteRO As New clsBC_ContratoLoteRO
        fxgrdRumasPendientes.AutoGenerateColumns = False
        fxgrdRumasPendientes.DataSource = oBC_ContratoLoteRO.LeerListaToDSRumasPendientesLotizar.Tables(0)


        txtCantidad.Text = FormatNumber(fxgrdRumasPendientes.Rows.Count, 2)

    End Sub


    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Dispose()
    End Sub

    Private Sub fxgrdRumasPendientes_AfterFilter(ByVal sender As Object, ByVal e As System.EventArgs) Handles fxgrdRumasPendientes.AfterFilter

        Dim nCantidadPendientes As Integer = 0
        For i = 0 To fxgrdRumasPendientes.Rows.Count - 1
            If fxgrdRumasPendientes.Rows(i).IsVisible Then
                nCantidadPendientes += 1
            End If
        Next

        txtCantidad.Text = FormatNumber(nCantidadPendientes, 2)
    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        Try
            sfDialog.Filter = "Hojas de Excel|*.xls"
            'sfDialog.FileName = cboMes.Text & "_" & cboAnio.Text & "_" & cboEmpresa.Text

            If sfDialog.ShowDialog = DialogResult.OK Then
                fxgrdRumasPendientes.SaveExcel(sfDialog.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)

                Dim processInfo As New ProcessStartInfo("explorer.exe", sfDialog.FileName)
                Process.Start(processInfo)
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub
End Class