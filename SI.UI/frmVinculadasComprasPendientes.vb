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

Public Class frmVinculadasComprasPendientes

    Private oMensajeError As mensajeError = New mensajeError
    Private nGestionComercial As Integer

    Private Sub frmGestionComercial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ConfiguraForm(Me)

        ObtenerRegistros()
    End Sub

    Private Sub ObtenerRegistros()

        Dim loclsBC_LiquidacionRO As New clsBC_LiquidacionRO
        fxgLotesPendientes.DataSource = loclsBC_LiquidacionRO.fnSelDTComposicionVinculada("")
        'fxgLotesPendientes.AutoGenerateColumns = True
    End Sub



End Class