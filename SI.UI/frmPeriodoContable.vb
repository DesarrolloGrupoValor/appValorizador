Public Class frmPeriodoContable

    Private Sub frmPeriodoContableS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SI.PL.clsFuncion.Obtener_ParametrosCombo(cboEmpresa, SI.UT.clsUT_Dominio.domTABLA_DE_EMPRESA, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
    End Sub

    Private Sub cboEmpresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEmpresa.SelectedIndexChanged
        ' Cargamos periodos para empresa
        cargarPeriodos()
    End Sub

    Private Sub cargarPeriodos()
        If cboEmpresa.SelectedIndex > 0 Then
            ' obtenemos periodos registrados para empresa
            Dim oBC_PeriodoRO As New SI.BC.clsBC_PeriodoRO
            Dim dt As DataTable = oBC_PeriodoRO.GetPeriodoByEmpresa(cboEmpresa.SelectedValue.ToString)
            cboPeriodo.DataSource = dt
            cboPeriodo.DisplayMember = "Vch_periodoDescription"
            cboPeriodo.ValueMember = "Vch_periodo"

            ' obtenemos periodos disponibles para empresa (tope año actual)
            lstPeriodosDisponibles.Items.Clear()
            Dim dtTemp As DataTable = dt.DefaultView.ToTable(True, New String() {"Anio"})
            For i = 0 To dtTemp.Rows.Count - 1
                For j = 1 To 12
                    Dim periodoDisponible As String = dtTemp.Rows.Item(i).Item("Anio") & "-" & Microsoft.VisualBasic.Right("0" & (13 - j).ToString, 2)
                    If cboPeriodo.FindStringExact(periodoDisponible) = -1 Then
                        lstPeriodosDisponibles.Items.Add(periodoDisponible)
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub cboPeriodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriodo.SelectedIndexChanged
        If Not cboPeriodo.SelectedIndex = -1 Then
            ' Obtenemos Fecha declaracion y estado (Abierto,Cerrado) del periodo seleccionado
            Dim selectedIndex = cboPeriodo.SelectedIndex
            Dim fechaDeclaracion = CType(cboPeriodo.DataSource, DataTable).Rows.Item(selectedIndex).Item("Dt_fechaDeclara").ToString
            If fechaDeclaracion = String.Empty Then
                dtpFechaDeclaracion.Checked = False
            Else
                dtpFechaDeclaracion.Checked = True
                dtpFechaDeclaracion.Text = fechaDeclaracion
            End If

            chkEstadoPeriodo.Checked = IIf(CType(cboPeriodo.DataSource, DataTable).Rows.Item(selectedIndex).Item("Int_flagDeclara") = 1, True, False)

        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Actualizamos seleccion actual de periodo
        Dim oBC_PeriodoRO As New SI.BC.clsBC_PeriodoTX
        oBC_PeriodoRO.UpdatePeriodoByEmpresa(cboEmpresa.SelectedValue.ToString, _
                                            cboPeriodo.SelectedValue.ToString, _
                                            IIf(dtpFechaDeclaracion.Checked = True, dtpFechaDeclaracion.Text, ""), _
                                            IIf(chkEstadoPeriodo.Checked = True, 1, 0))

        ' Insertamos periodos segun la seleccion en la lista de periodos disponibles
        If Not lstPeriodosDisponibles.SelectedItems.Count = 0 Then
            For i = 0 To lstPeriodosDisponibles.SelectedItems.Count - 1
                oBC_PeriodoRO.InsertPeriodoByEmpresa(cboEmpresa.SelectedValue.ToString, _
                                                     lstPeriodosDisponibles.SelectedItems(i).ToString.Replace("-", ""), _
                                                     "", _
                                                     0)
            Next
        End If

        ' Recargamos periodos para empresa
        cargarPeriodos()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Recargamos periodos para empresa
        cargarPeriodos()
    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click

        Dim oBC_PeriodoRO As New SI.BC.clsBC_PeriodoTX

        ' Validacion, no se puede cerrar un periodo que contenga rumas pendientes de lotizar
        If chkEstadoPeriodo.Checked And
            oBC_PeriodoRO.ValidarRumasPendientesLotizar(cboEmpresa.SelectedValue.ToString, cboPeriodo.SelectedValue.ToString) Then
            MsgBox("No puede cerrar el periodo dado que contiene rumas pendientes de lotizar.", MsgBoxStyle.Information, "Valorizador Comercial de Minerales")
            chkEstadoPeriodo.Checked = False
            Exit Sub
        End If

        ' Actualizamos seleccion actual de periodo
        oBC_PeriodoRO.UpdatePeriodoByEmpresa(cboEmpresa.SelectedValue.ToString, _
                                            cboPeriodo.SelectedValue.ToString, _
                                            IIf(dtpFechaDeclaracion.Checked = True, dtpFechaDeclaracion.Text, ""), _
                                            IIf(chkEstadoPeriodo.Checked = True, 1, 0))

        ' Insertamos periodos segun la seleccion en la lista de periodos disponibles
        If Not lstPeriodosDisponibles.SelectedItems.Count = 0 Then
            For i = 0 To lstPeriodosDisponibles.SelectedItems.Count - 1
                oBC_PeriodoRO.InsertPeriodoByEmpresa(cboEmpresa.SelectedValue.ToString, _
                                                     lstPeriodosDisponibles.SelectedItems(i).ToString.Replace("-", ""), _
                                                     "", _
                                                     0)
            Next
        End If

        ' Recargamos periodos para empresa
        cargarPeriodos()
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Dispose()
    End Sub

    Private Sub tsbRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRefrescar.Click
        ' Recargamos periodos para empresa
        cargarPeriodos()
    End Sub
End Class