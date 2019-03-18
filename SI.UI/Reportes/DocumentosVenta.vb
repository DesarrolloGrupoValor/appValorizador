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

Public Class DocumentosVenta

    Private oMensajeError As mensajeError = New mensajeError

    Private Sub DocumentosVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ConfiguraForm(Me)
        cargarGrilla()
    End Sub


    Private Sub tsbConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsulta.Click
        cargarGrilla()

    End Sub

    Private Sub cargarGrilla()
        Dim oBC_ContratoLoteRO As New clsBC_ContratoLoteRO

        fxgrdDocumentosVenta.AutoGenerateColumns = False
        fxgrdDocumentosVenta.DataSource = oBC_ContratoLoteRO.LeerListaToDSDocumentosVenta.Tables(0)


    End Sub


    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Dispose()
    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        Try
            sfDialog.Filter = "Hojas de Excel|*.xls"
            'sfDialog.FileName = cboMes.Text & "_" & cboAnio.Text & "_" & cboEmpresa.Text

            If sfDialog.ShowDialog = DialogResult.OK Then
                fxgrdDocumentosVenta.SaveExcel(sfDialog.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)

                Dim processInfo As New ProcessStartInfo("explorer.exe", sfDialog.FileName)
                Process.Start(processInfo)
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub
End Class