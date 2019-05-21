Imports System.Data
Imports SI.BC
Imports SI.UT
Imports SI.PL.clsProcedimientos
Imports SI.PL.clsGeneral
Imports SI.PL.clsFuncion
Imports System.Drawing.Drawing2D

Public Class frmDeposito
    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    Private blnCarga As Boolean
    Private dataTableCOM_DEPOSITOS As DataTable
    Private dvwCOM_DEPOSITOS As DataView
    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click, tsmSalir.Click
        Me.Dispose()
    End Sub

    Private Sub frmDeposito_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            ConfiguraForm(Me)

            ObtenerRegistros()

            Me.WindowState = FormWindowState.Maximized
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub ObtenerRegistros()
        Try

            Dim oCOM_DEPOSITOSRO As New clsBC_COM_DEPOSITOSRO

            dataTableCOM_DEPOSITOS = oCOM_DEPOSITOSRO.LeerListaToDSCOM_DEPOSITOS.Tables(0)
            dvwCOM_DEPOSITOS = New DataView(dataTableCOM_DEPOSITOS)


            fxgrdCOM_DEPOSITOS.DataSource = dvwCOM_DEPOSITOS
            fxgrdCOM_DEPOSITOS.Sort(C1.Win.C1FlexGrid.SortFlags.Ascending, 1)


        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

   
End Class
