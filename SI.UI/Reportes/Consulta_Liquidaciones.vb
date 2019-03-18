Imports SI.BC
Imports SI.UT
Imports SI.BE
Imports SI.PL.clsFuncion

Public Class Consulta_Liquidaciones
    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    Dim dvwRegistros As DataView
    Private Function Validar(Optional ByVal sTipoValidacion As String = "")

        Dim strmensaje As String = ""
        Try

           
            If cboPeriodo.SelectedIndex < 1 Then
                strmensaje = strmensaje & "Debe seleccionar periodo"
            End If

            If CboPeriodoDestino.SelectedIndex < 1 Then
                strmensaje = strmensaje & "Debe seleccionar periodo Destino"
            End If

            If CboPeriodoDestino.SelectedValue < cboPeriodo.SelectedValue Then
                strmensaje = strmensaje & "Periodo Destino no puede ser menor a Periodo Inicial"

            End If

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try

        If strmensaje.Length > 0 Then
            MsgBox(strmensaje, MsgBoxStyle.Critical, "Valorizador de Minerales")
            Return False
        End If
        Return True
    End Function

    Private Sub ObtenerPeriodos()
        Dim dsPeriodo As DataSet
        Dim oBC_PeriodoRO As New clsBC_PeriodoRO
        dsPeriodo = oBC_PeriodoRO.ObtenerPeriodo()

        cboPeriodo.DataSource = dsPeriodo.Tables(0)
        cboPeriodo.DisplayMember = "periodo"
        cboPeriodo.ValueMember = "periodoId"

        dsPeriodo = oBC_PeriodoRO.ObtenerPeriodo()
        CboPeriodoDestino.DataSource = dsPeriodo.Tables(0)
        CboPeriodoDestino.DisplayMember = "periodo"
        CboPeriodoDestino.ValueMember = "periodoId"

    End Sub

    Private Sub Consulta_Liquidaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        Try
            ObtenerPeriodos()
            ' Obtener_ParametrosCombo(cboEmpresa, clsUT_Dominio.domTABLA_DE_EMPRESA, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try

        
    End Sub

    Private Sub ObtenerRegistros(ByVal periodo As String, ByVal periodoDestino As String)
        Try
            Dim dsregistros As DataSet
            Dim oContratoRO As New clsBC_ContratoLoteRO

            oContratoRO.oBEContratoLote.periodo_origen = periodo 'Year(dtpPeriodo.Value) & IIf(Month(dtpPeriodo.Value).ToString.Length > 1, "", "0") & Month(dtpPeriodo.Value)
            oContratoRO.oBEContratoLote.periodo_destino = periodoDestino

            dsregistros = oContratoRO.LeerListaToDSConsultaLiquidaciones
            dvwRegistros = New DataView(dsregistros.Tables(0))
            fxgrdExtraccionBd.DataSource = dvwRegistros

            'fxgrdExtraccionBd.Cols("TMS").Format = "N4"
            'fxgrdExtraccionBd.Cols("CU Precio Aplicable").Format = "N4"
            'fxgrdExtraccionBd.Cols("CU Contenido ").Format = "N4"
            'fxgrdExtraccionBd.Cols("PB Precio Aplicable").Format = "N4"
            'fxgrdExtraccionBd.Cols("PB Contenido ").Format = "N4"
            'fxgrdExtraccionBd.Cols("ZN Precio Aplicable").Format = "N4"
            'fxgrdExtraccionBd.Cols("ZN Contenido ").Format = "N4"
            'fxgrdExtraccionBd.Cols("AG Precio Aplicable").Format = "N4"
            'fxgrdExtraccionBd.Cols("AG Contenido ").Format = "N4"
            'fxgrdExtraccionBd.Cols("AU Precio Aplicable").Format = "N4"
            'fxgrdExtraccionBd.Cols("AU Contenido ").Format = "N4"

            'fxgrdExtraccionBd.Cols("Estado").Width = 50
            'fxgrdExtraccionBd.Cols("Tipo").Width = 80
            'fxgrdExtraccionBd.Cols("producto").Width = 80
            'fxgrdExtraccionBd.Cols("cuota").Width = 80
            'fxgrdExtraccionBd.Cols("Proveedor/Cliente").Width = 250
            'fxgrdExtraccionBd.Cols("CU Mercado").Width = 130
            'fxgrdExtraccionBd.Cols("PB Mercado").Width = 130
            'fxgrdExtraccionBd.Cols("ZN Mercado").Width = 130
            'fxgrdExtraccionBd.Cols("AG Mercado").Width = 130
            'fxgrdExtraccionBd.Cols("AU Mercado").Width = 130

            'fxgrdExtraccionBd.Cols("CU QP").Width = 50
            'fxgrdExtraccionBd.Cols("PB QP").Width = 50
            'fxgrdExtraccionBd.Cols("ZN QP").Width = 50
            'fxgrdExtraccionBd.Cols("AG QP").Width = 50
            'fxgrdExtraccionBd.Cols("AU QP").Width = 50

            'fxgrdExtraccionBd.Cols("CU QPInicial").Width = 80
            'fxgrdExtraccionBd.Cols("PB QPInicial").Width = 80
            'fxgrdExtraccionBd.Cols("ZN QPInicial").Width = 80
            'fxgrdExtraccionBd.Cols("AG QPInicial").Width = 80
            'fxgrdExtraccionBd.Cols("AU QPInicial").Width = 80

            'fxgrdExtraccionBd.Cols("CU QPFinal").Width = 80
            'fxgrdExtraccionBd.Cols("PB QPFinal").Width = 80
            'fxgrdExtraccionBd.Cols("ZN QPFinal").Width = 80
            'fxgrdExtraccionBd.Cols("AG QPFinal").Width = 80
            'fxgrdExtraccionBd.Cols("AU QPFinal").Width = 80

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsMantenimiento_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

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

    Private Sub TsbConsultar_Click(sender As System.Object, e As System.EventArgs) Handles TsbConsultar.Click
        Try
            If Validar(String.Empty) Then
                ObtenerRegistros(cboPeriodo.SelectedValue.ToString, cboPeriodoDestino.SelectedValue.ToString)
                MsgBox("Finalización satisfactoria de la obtención de la información. Período: " & cboPeriodo.SelectedValue & " - " & cboPeriodoDestino.SelectedValue, MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub
End Class