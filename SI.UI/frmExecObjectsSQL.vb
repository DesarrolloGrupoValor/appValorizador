Imports SI.BC
Imports SI.PL.clsFuncion
Imports SI.PL.clsProcedimientos
Imports SI.PL.clsEnumerado
Imports SI.PL.clsGeneral
Imports SI.UT
Imports System.Data
Imports System.Drawing.Drawing2D
Imports SI.BE

Public Class frmExecObjectsSQL
    Private oTablaDetRO As New clsBC_TablaDetRO
    Private dvwDatos As DataView
    Private lblnEditando As Boolean
    Private lblnNuevo As Boolean
    Private strTitulo1 As String
    Private strTitulo2 As String
    Private strTitulo3 As String
    Private strTitulo4 As String
    Private strTitulo5 As String
    Private strTitulo6 As String
    Private strTitulo7 As String
    Private strTitulo8 As String
    Private strTitulo9 As String
    Private strTitulo10 As String
    Private strTitulo11 As String
    Private strTitulo12 As String
    Private strTitulo13 As String
    Private strTitulo14 As String
    Private strTitulo15 As String
    Private strTitulo16 As String
    Private strTitulo17 As String
    Private strTitulo18 As String
    Private strTitulo19 As String
    Private strTitulo20 As String

    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    Private Sub frmTabla_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        'Dim dsdatos As DataSet
        'Dim dvwDatos As DataView
        'dsdatos = oUsuarioRO.LeerListaToDSusuario
        'dvwDatos = New DataView(dsdatos.Tables(0))
        'tdbgMantenimiento.DataSource = dvwDatos
        Try
            ConfiguraForm(Me)
            CargarParametros()



           
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub
    Private Sub CargarParametros()
        'Obtener_RegistrosCombo(cboTablaDet, "tbTabla", "tablaId", "descri", "tablaId", enumPrimerValorCombo.Seleccione, "codigoVisible", "True")

        Obtener_ParametrosCombo(cboTablaDet, "SQLObjects", SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)

    End Sub

    Private Sub tsmSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Dispose()
    End Sub


    Private Sub tsbFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbFiltrar.Click
        Dim oBC_TablaDetRO As New clsBC_TablaDetRO
        oBC_TablaDetRO.oBETablaDet = New clsBE_TablaDet
        oBC_TablaDetRO.oBETablaDet.tablaDetId = cboTablaDet.SelectedValue
        oBC_TablaDetRO.LeerListaToDSTablaDetObjects()
        fxgrdMantenimiento.DataSource = oBC_TablaDetRO.LeerListaToDSTablaDetObjects.Tables(0)

    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        Try
            sfDialog.Filter = "Hojas de Excel|*.xls"
            sfDialog.ShowDialog()
            If sfDialog.FileName.Length > 0 Then
                fxgrdMantenimiento.SaveExcel(sfDialog.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

End Class

