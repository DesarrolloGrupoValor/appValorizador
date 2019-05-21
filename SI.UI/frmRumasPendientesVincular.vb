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

Public Class frmRumasPendientesVincular

    Private oMensajeError As mensajeError = New mensajeError

    Private Sub frmRumasPendientesVincular_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ConfiguraForm(Me)
        cargarGrilla()
    End Sub


    Private Sub tsbConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsulta.Click
        cargarGrilla()

    End Sub

    Private Sub cargarGrilla()
        Dim oBC_ContratoLoteRO As New clsBC_ContratoLoteRO
        fxgrdGestionComercial.AutoGenerateColumns = False
        fxgrdGestionComercial.DataSource = oBC_ContratoLoteRO.LeerListaToDSRumasPendientesVincular.Tables(0)


        txtCantidad.Text = FormatNumber(fxgrdGestionComercial.Rows.Count, 2)

    End Sub

    Private Sub Exportar()
        Try
            'sfdSaveFileDialog.Filter = "Hojas de Excel|*.xls"
            'sfdSaveFileDialog.FileName = cboMes.Text & "_" & cboAnio.Text & "_" & cboEmpresa.Text

            'If sfdSaveFileDialog.ShowDialog = DialogResult.OK Then
            '    fxgrdGestionComercialExport.SaveExcel(sfdSaveFileDialog.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)

            '    Dim processInfo As New ProcessStartInfo("explorer.exe", sfdSaveFileDialog.FileName)
            '    Process.Start(processInfo)
            'End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Dispose()
    End Sub
End Class