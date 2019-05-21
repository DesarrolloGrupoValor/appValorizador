Imports SI.BC
Imports SI.UT
Imports SI.BE
Imports SI.PL.clsFuncion

Public Class MatrizMezcla
    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    Public pTipo_Extraccion As String

    Dim dvwRegistros As DataView

    Public pEmpresa As String = ""
    Public pPeriodo As String = ""

    Private Sub MatrizMezcla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.WindowState = FormWindowState.Maximized
        Lbltitulo.Text = "Reporte: Matriz Costo Mezcla"

        Try
            ObtenerPeriodos()
            Obtener_ParametrosCombo(cboEmpresa, clsUT_Dominio.domTABLA_DE_EMPRESA, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)

            If pEmpresa <> "" Then
                cboEmpresa.SelectedValue = pEmpresa
            End If

            If pPeriodo <> "" Then
                cboPeriodo.SelectedValue = pPeriodo
            End If

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try



    End Sub

    Private Sub ObtenerPeriodos()
        Dim dsPeriodo As DataSet
        Dim oBC_PeriodoRO As New clsBC_PeriodoRO
        dsPeriodo = oBC_PeriodoRO.ObtenerPeriodo()

        cboPeriodo.DataSource = dsPeriodo.Tables(0)
        cboPeriodo.DisplayMember = "periodo"
        cboPeriodo.ValueMember = "periodoId"
    End Sub


    Private Sub ObtenerRegistros(ByVal empresa As String, ByVal periodo As String)
        Try
            Dim dsregistros As New DataSet
            Dim oContratoRO As New clsBC_ContratoLoteRO

            oContratoRO.oBEContratoLote.codigoEmpresa = empresa 'cboEmpresa.SelectedValue
            oContratoRO.oBEContratoLote.comentarios = periodo 'Year(dtpPeriodo.Value) & IIf(Month(dtpPeriodo.Value).ToString.Length > 1, "", "0") & Month(dtpPeriodo.Value)

            dsregistros = oContratoRO.LeerListaToDSMatriz_Mezcla

            dvwRegistros = New DataView(dsregistros.Tables(0))
            fxgrdMatriz.AutoGenerateColumns = True
            fxgrdMatriz.DataSource = dvwRegistros

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbExportarExcel.Click
        SaveFileDialog1.Filter = "Hojas de Excel|*.xls"
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName.Length > 0 Then
            'fxgrdExtraccionVCM.SaveExcel(SaveFileDialog1.FileName,, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
            fxgrdMatriz.SaveExcel(SaveFileDialog1.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
        End If

        Dim exeName As String = "explorer.exe"
        Dim params As String = SaveFileDialog1.FileName
        Dim processInfo As New ProcessStartInfo(exeName, params)
        Process.Start(processInfo)

    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbSalir.Click
        '    ObtenerRegistros()
        Me.Dispose()

    End Sub

    Private Sub tsbConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbConsultar.Click

        Try
            If cboEmpresa.SelectedIndex < 1 Then
                MsgBox("Debe seleccionar empresa", MsgBoxStyle.OkOnly, "Valorizador de Minerales")
                Return
            End If

            If cboPeriodo.SelectedIndex < 1 Then
                MsgBox("Debe seleccionar periodo", MsgBoxStyle.OkOnly, "Valorizador de Minerales")
                Return
            End If
            ObtenerRegistros(cboEmpresa.SelectedValue, cboPeriodo.SelectedValue)
            MsgBox("Finalización satisfactoria de la obtención de la información. Período: " & cboPeriodo.SelectedValue, MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try

    End Sub


End Class