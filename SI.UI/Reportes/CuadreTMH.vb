Imports SI.BC
Imports SI.UT
Imports SI.BE
Imports SI.PL.clsFuncion

Public Class CuadreTMH
    'control de errores
    Private oMensajeError As mensajeError = New mensajeError
    Public pTipoFormulario As String

    Dim dvwRegistros As DataView

    Private Sub CuadreTMH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ObtenerPeriodos()
        If pTipoFormulario = "CUADRE_TMH" Then
            lblTitulo.Text = "Reporte - Cuadre de TMH"

        ElseIf pTipoFormulario = "DIF_TMH_VENTAS" Then
            lblTitulo.Text = "Reporte - Diferencia de tonelaje Concar vs VCM (Ventas)"
        End If
        Me.Text = lblTitulo.Text
    End Sub

    Private Sub ObtenerRegistros(ByVal empresa As String, ByVal periodo As String)
        Try
            Dim dsregistros As DataSet
            Dim oContratoRO As New clsBC_ContratoLoteRO
            oContratoRO.oBEContratoLote.codigoTabla = "" 'empresa
            oContratoRO.oBEContratoLote.comentarios = periodo '  'Year(dtpPeriodo.Value) & IIf(Month(dtpPeriodo.Value).ToString.Length > 1, "", "0") & Month(dtpPeriodo.Value)
            'oContratoRO.oBEContratoLote.codigoEmpresa = periodo
            'oContratoRO.oBEContratoLote.um = 

            If pTipoFormulario = "CUADRE_TMH" Then
                dsregistros = oContratoRO.LeerListaToDSContable_CuadreTMH
                dvwRegistros = New DataView(dsregistros.Tables(0))
                fxgrdExtraccionBd.DataSource = dvwRegistros


                For nContador As Integer = 2 To 11
                    fxgrdExtraccionBd.Cols(nContador).Format = "N2"
                    fxgrdExtraccionBd.Cols(nContador).Width = 108
                Next
            ElseIf pTipoFormulario = "DIF_TMH_VENTAS" Then
                dsregistros = oContratoRO.LeerListaToDSContable_DiferenciaTMHVenta
                dvwRegistros = New DataView(dsregistros.Tables(0))
                fxgrdExtraccionBd.DataSource = dvwRegistros


                For nContador As Integer = 1 To fxgrdExtraccionBd.Cols.Count - 1
                    fxgrdExtraccionBd.Cols(nContador).Format = "N2"
                    fxgrdExtraccionBd.Cols(nContador).Width = 110
                    fxgrdExtraccionBd.Cols(nContador).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter

                    If nContador = 2 Or nContador = 4 Then
                        fxgrdExtraccionBd.Cols(nContador).Width = 85
                        fxgrdExtraccionBd.Cols(nContador).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter
                    End If

                    If nContador = 1 Or nContador = 3 Then
                        fxgrdExtraccionBd.Cols(nContador).Visible = False
                    End If

                    If nContador >= 5 And nContador <= 11 Then
                        fxgrdExtraccionBd.Cols(nContador).Format = "N2"
                        'fxgrdExtraccionBd.Cols(nContador).Width = 100
                        fxgrdExtraccionBd.Cols(nContador).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
                    End If
                Next

            End If

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        Try
            SaveFileDialog1.Filter = "Hojas de Excel|*.xls"
            SaveFileDialog1.ShowDialog()
            If SaveFileDialog1.FileName.Length > 0 Then
                fxgrdExtraccionBd.SaveExcel(SaveFileDialog1.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        '    ObtenerRegistros()
        Me.Dispose()

    End Sub

    'Private Sub dtpPeriodo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpPeriodo.ValueChanged
    '    ObtenerRegistros("", "")
    'End Sub

    Private Sub cboPeriodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriodo.SelectedIndexChanged
        'If cboPeriodo.SelectedIndex > 0 Then
        '    ObtenerRegistros("", cboPeriodo.SelectedValue)
        'End If
    End Sub

    Private Sub ObtenerPeriodos()
        Try
            Dim dsPeriodo As DataSet
            Dim oBC_PeriodoRO As New clsBC_PeriodoRO
            dsPeriodo = oBC_PeriodoRO.ObtenerPeriodo()

            cboPeriodo.DataSource = dsPeriodo.Tables(0)
            cboPeriodo.DisplayMember = "periodo"
            cboPeriodo.ValueMember = "periodoId"
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbConsular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsular.Click
        If cboPeriodo.SelectedIndex > 0 Then           
            ObtenerRegistros("", cboPeriodo.SelectedValue)

            MsgBox("Finalización satisfactoria de la obtención de la información. Período: " & cboPeriodo.SelectedValue, MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")

        End If
    End Sub

End Class