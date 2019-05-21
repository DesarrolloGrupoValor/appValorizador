Imports SI.BC
Imports SI.UT
Imports SI.BE
Imports SI.PL.clsFuncion

Public Class ExtraccionVcm
    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    Public pTipo_Extraccion As String

    Dim dvwRegistros As DataView

    Private Sub ExtraccionBd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        If pTipo_Extraccion = "P" Then
            lblTitulo.Text = "Reporte: Extracción de VCM - Compras"
        ElseIf pTipo_Extraccion = "S" Then
            lblTitulo.Text = "Reporte: Extracción de VCM - Ventas"
        ElseIf pTipo_Extraccion = "B" Then
            lblTitulo.Text = "Reporte: Extracción de VCM - Despacho"
        End If


        ObtenerRegistros()
    End Sub

    Private Sub ObtenerRegistros()
        Try
            Dim dsregistros As New DataSet
            Dim oContratoRO As New clsBC_ContratoLoteRO

            If pTipo_Extraccion = "P" Then
                If Rb_Extraccion.Checked Then dsregistros = oContratoRO.LeerListaToDSExtraccionVCM
                If Rb_SaldoBlend.Checked Then dsregistros = oContratoRO.LeerListaToDSSaldoBlend


            ElseIf pTipo_Extraccion = "S" Then
                dsregistros = oContratoRO.LeerListaToDSExtraccionVCM_Venta
            ElseIf pTipo_Extraccion = "B" Then
                dsregistros = oContratoRO.LeerListaToDSExtraccionVCM_Despacho
            End If

            dvwRegistros = New DataView(dsregistros.Tables(0))
            fxgrdExtraccionVCM.DataSource = dvwRegistros
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        SaveFileDialog1.Filter = "Hojas de Excel|*.xls"
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName.Length > 0 Then
            'fxgrdExtraccionVCM.SaveExcel(SaveFileDialog1.FileName,, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
            fxgrdExtraccionVCM.SaveExcel(SaveFileDialog1.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
        End If

        Dim exeName As String = "explorer.exe"
        Dim params As String = SaveFileDialog1.FileName
        Dim processInfo As New ProcessStartInfo(exeName, params)
        Process.Start(processInfo)

    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        '    ObtenerRegistros()
        Me.Dispose()

    End Sub

    Private Sub tsbConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsultar.Click
        ObtenerRegistros()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub
End Class