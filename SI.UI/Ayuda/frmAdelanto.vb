Imports SI.UT
Imports SI.UT.clsUT_Enumerado
Imports SI.PL.clsProcedimientos
Imports SI.PL.clsFuncion
Imports SI.BC
Imports SI.BE
Imports System.Text

Imports SI.PL.clsGeneral

Public Class Adelanto

    Private drowPagable As DataRow
    Private dtPagable As DataTable
    Private dvwPagable As DataView

    Private sCodigoDscto As String = "ADELANTO"


    Private dFinanciando_Ajuste_CIGV As Double = 0.01

#Region "Variables Privadas"
    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    Private oDvwAyuda As New DataView
    Private FontCourier As New Font("Courier New", 8.25)
    Private stylecodpartida As New DataGridViewCellStyle()
#End Region

#Region "Variables Publicas"

    Private dIGV As Double
    Private bModificacion As Boolean = False

    Public pstrNomFormulario As String
    Public pFormAyuda As EnumFormAyuda
    Public oGeneral As New clsBC_GeneralRO
    Public pblnMultiSelect As Boolean
    Public pstrTituloCodigo As String = "Codigo"
    Public pstrTituloDescripcion As String = "Descripcion"
    Public pParametros As New Hashtable
    Public pstrWhere As String = ""
    Public pstrFiltro As String
    Public pstrDominio As clsUT_Dominio
    Public pstrFiltroMovimiento As String

    Public Property contratoLoteId() As String
    Public Property liquidacionId() As String

    Public Property contrato() As String
    Public Property lote() As String
    Public Property proveedor() As String
    Public Property proveedor_nombre() As String
    Public Property empresa_grupo() As String

    Public Property oBE_FINANCIANDO_PRELIQ As New clsBE_FINANCIANDO_PRELIQ
    Public LstFINANCIANDO_PRELIQ_INSERT As New List(Of clsBE_FINANCIANDO_PRELIQ)


    Public Property bAsociar As Boolean = False


    Dim dAPLICA_SIGV As Double
    Dim dAPLICA_CIGV As Double

    Dim nRowIndex As Integer = -1



    Dim bSeleccion As Boolean = False

#End Region

#Region "Propiedades"

#End Region

#Region "Eventos de Formulario"


    Private Sub frmAyuda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        'Obtener el IGV
        Dim oBC_TablaDetRO As New clsBC_TablaDetRO
        Dim oBE_TablaDet As New clsBE_TablaDet
        oBE_TablaDet.tablaId = "impuesto"
        oBE_TablaDet.tablaDetId = "IGV"
        oBC_TablaDetRO.oBETablaDet = oBE_TablaDet
        oBC_TablaDetRO.LeerTablaDet()
        dIGV = Double.Parse(oBC_TablaDetRO.oBETablaDet.descri.ToString)


        'dgvFINANCIANDO_PRELIQ.AutoGenerateColumns = True

        'CargarDatos()
        cargarParametros()
        cargarFiltros()

        cboEstado.SelectedIndex = 2
    End Sub

#End Region

#Region "Eventos de Controles"
    


    Private Sub cargarParametros()
        Obtener_ParametrosGridViewQuitar(cbotablaDetId, clsUT_Dominio.domTABLA_DE_AJUSTES, SI.PL.clsEnumerado.enumPrimerValorCombo.Ninguno, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion, "ADELANTO")

    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        valida_caracterSQL(sender, e)
    End Sub


#End Region

#Region "Rutinas Locales"

    Private Sub CargarDatos()

        If cbxPendientes.Checked Then
            Dim blnPersonalizado As Boolean = False

            Dim oBC_FINANCIANDO_PRELIQRO As New clsBC_FINANCIANDO_PRELIQRO

            Dim dsAyuda As New DataSet
            oBC_FINANCIANDO_PRELIQRO.oBEFINANCIANDO_PRELIQ = oBE_FINANCIANDO_PRELIQ
            oBC_FINANCIANDO_PRELIQRO.oBEFINANCIANDO_PRELIQ.stablaDetId = empresa_grupo
            oBC_FINANCIANDO_PRELIQRO.oBEFINANCIANDO_PRELIQ.estado_fin = cboEstado.SelectedValue


            'pendientes
            If cbxPendientes.Checked Then
                oBC_FINANCIANDO_PRELIQRO.LeerListaToDSFINANCIANDO()
                'aplicados
            ElseIf cbxAplicados.Checked Then
                oBC_FINANCIANDO_PRELIQRO.LeerListaToDSAplicados()
                'ctas por cobrar
                'ElseIf cbxCtasXCobrar.Checked Then
                '    oBC_FINANCIANDO_PRELIQRO.LeerListaToDSFINANCIANDO()
            End If

            dsAyuda = oBC_FINANCIANDO_PRELIQRO.oDSFINANCIANDO_PRELIQ

            fxgFinanciando.DataSource = dsAyuda.Tables(0)


            If dsAyuda.Tables(0).Rows.Count > 0 Then
                'If fxgFinanciando.Rows.Count > 0 Then

                ''SUMA DE TOTALES
                'Dim newCustomersRow As DataRow = dsAyuda.Tables(0).NewRow()
                'newCustomersRow("NRO_OP") = "TOTAL"
                'newCustomersRow("SALDO_SIGV") = dsAyuda.Tables(0).Compute("SUM(SALDO_SIGV)", "")
                'newCustomersRow("SALDO_CIGV") = dsAyuda.Tables(0).Compute("SUM(SALDO_CIGV)", "")
                'newCustomersRow("APLICA_SIGV") = dsAyuda.Tables(0).Compute("SUM(APLICA_SIGV)", "")
                'newCustomersRow("APLICA_CIGV") = dsAyuda.Tables(0).Compute("SUM(APLICA_CIGV)", "")
                'dsAyuda.Tables(0).Rows.Add(newCustomersRow)



                'SUMA DE TOTALES

                txtSaldo_sigv.Text = FormatNumber(dsAyuda.Tables(0).Compute("SUM(SALDO_SIGV)", ""), 2)
                txtSaldo_cigv.Text = FormatNumber(dsAyuda.Tables(0).Compute("SUM(SALDO_CIGV)", ""), 2)
                txtAplica_sigv.Text = FormatNumber(dsAyuda.Tables(0).Compute("SUM(APLICA_SIGV)", ""), 2)
                txtAplica_cigv.Text = FormatNumber(dsAyuda.Tables(0).Compute("SUM(APLICA_CIGV)", ""), 2)


                'newCustomersRow("APLICA_CIGV") = "<font color='Red'>"
                dgvFinanciamiento.AutoGenerateColumns = False
                dgvFinanciamiento.DataSource = dsAyuda.Tables(0)


                '' '' Filtrado de estados
                ''Dim sEstado As String
                ''sEstado = cboEstado.SelectedValue
                ''If sEstado <> "" Then
                ''    sEstado = "Estado_Fin = '" & sEstado & "' and "
                ''End If

                ''FILTRO CON CONDICION
                Dim sCondicion1 As String = ""
                If txtCondicion1.Text <> "" And cboFiltro1.SelectedIndex > 0 Then
                    sCondicion1 = " and " & cboFiltro1.SelectedValue & " like '%" & txtCondicion1.Text & "%'"
                End If
                dsAyuda.Tables(0).DefaultView.RowFilter = "NRO_OP ='TOTAL' OR (NRO_DOC like '%" & txtContrato.Text & "%' and RUMA like '%" & txtRuma.Text & "%' and calidad like '%" & txtCalidad.Text & "%' " & sCondicion1 & ")"







                ' and " & cboFiltro1.SelectedValue & " like '" & txtCondicion1.Text & "'"

                ''dgvFinanciamiento.AutoGenerateColumns = False
                ''dgvFinanciamiento.DataSource = dsAyuda.Tables(0)


                'dgvFinanciamiento.Rows(dgvFinanciamiento.Rows.Count - 1).Cells("NRO_OP").Style.BackColor = Color.LightGray
                'dgvFinanciamiento.Rows(dgvFinanciamiento.Rows.Count - 1).Cells("MONEDA").Style.BackColor = Color.LightGray
                'dgvFinanciamiento.Rows(dgvFinanciamiento.Rows.Count - 1).Cells("SALDO_SIGV").Style.BackColor = Color.LightGray
                'dgvFinanciamiento.Rows(dgvFinanciamiento.Rows.Count - 1).Cells("SALDO_CIGV").Style.BackColor = Color.LightGray
                'dgvFinanciamiento.Rows(dgvFinanciamiento.Rows.Count - 1).Cells("APLICA_SIGV").Style.BackColor = Color.LightGray
                'dgvFinanciamiento.Rows(dgvFinanciamiento.Rows.Count - 1).Cells("APLICA_CIGV").Style.BackColor = Color.LightGray

                'dgvFinanciamiento.Rows(dgvFinanciamiento.Rows.Count - 1).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)

                EditarColumnasModificables(dgvFinanciamiento, "cbxAplicar,APLICA_SIGV,APLICA_CIGV")
                ''dgvFinanciamiento.Rows(dgvFinanciamiento.Rows.Count - 1).ReadOnly = True
                ''dgvFinanciamiento.Rows(dgvFinanciamiento.Rows.Count - 1).DefaultCellStyle.BackColor = Drawing.Color.FromArgb(204, 204, 204)
                'lblReg.Text = "Registros : " & dgvFINANCIANDO_PRELIQ.Rows.Count

            End If
        End If

    End Sub



#End Region


    Private Sub dgvFinanciamiento_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFinanciamiento.CellValueChanged

        If Not dgvFinanciamiento.CurrentRow Is Nothing Then
            If nRowIndex <> dgvFinanciamiento.CurrentRow.Index Then
                dAPLICA_SIGV = 0
                dAPLICA_CIGV = 0
            End If
        End If

        ''If bModificacion = False Then
        Select Case dgvFinanciamiento.Columns(e.ColumnIndex).Name
            Case "SALDO_CIGV"

            Case "APLICA_CIGV"
                If dgvFinanciamiento.CurrentRow.Cells("APLICA_CIGV").Value.ToString <> "" Then
                    If dgvFinanciamiento.CurrentRow.Cells("APLICA_CIGV").Value <> dAPLICA_CIGV Then
                        nRowIndex = dgvFinanciamiento.CurrentRow.Index
                        dAPLICA_SIGV = Math.Round(dgvFinanciamiento.CurrentRow.Cells("APLICA_CIGV").Value / (1 + dIGV / 100), 4)
                        'OK
                        'dAPLICA_SIGV = dgvFinanciamiento.CurrentRow.Cells("APLICA_CIGV").Value - dgvFinanciamiento.CurrentRow.Cells("APLICA_CIGV").Value * dIGV / 100
                        dgvFinanciamiento.CurrentRow.Cells("APLICA_SIGV").Value = dAPLICA_SIGV
                        'dgvFinanciamiento.CurrentRow.Cells("APLICA_CIGV").Value = FormatNumber(dgvFinanciamiento.CurrentRow.Cells("APLICA_CIGV").Value, 2)
                    End If
                Else
                    dgvFinanciamiento.CurrentRow.Cells("APLICA_CIGV").Value = 0
                End If

            Case "APLICA_SIGV"
                If dgvFinanciamiento.CurrentRow.Cells("APLICA_SIGV").Value.ToString <> "" Then
                    If dgvFinanciamiento.CurrentRow.Cells("APLICA_SIGV").Value <> dAPLICA_SIGV Then
                        nRowIndex = dgvFinanciamiento.CurrentRow.Index
                        dAPLICA_CIGV = dgvFinanciamiento.CurrentRow.Cells("APLICA_SIGV").Value + dgvFinanciamiento.CurrentRow.Cells("APLICA_SIGV").Value * dIGV / 100
                        dgvFinanciamiento.CurrentRow.Cells("APLICA_CIGV").Value = dAPLICA_CIGV
                        'dgvFinanciamiento.CurrentRow.Cells("APLICA_SIGV").Value = FormatNumber(dgvFinanciamiento.CurrentRow.Cells("APLICA_SIGV").Value, 2)
                    End If
                Else
                    dgvFinanciamiento.CurrentRow.Cells("APLICA_SIGV").Value = 0
                End If
        End Select
        ''End If
        If Not dgvFinanciamiento.CurrentRow Is Nothing Then
            nRowIndex = dgvFinanciamiento.CurrentRow.Index
        End If
    End Sub



    Private Sub dgvPreAplicacion_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvPreAplicacion.DataError
        MsgBox("Por favor ..... Verificar la información ingresada.", MsgBoxStyle.OkOnly, "Valorizador de Minerales")
    End Sub



    Private Sub dgvPreAplicacion_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPreAplicacion.CellValueChanged

        ''If Not dgvPreAplicacion.CurrentRow Is Nothing Then
        ''    If nRowIndex <> dgvPreAplicacion.CurrentRow.Index Then
        ''        dAPLICA_SIGV = 0
        ''        dAPLICA_CIGV = 0

        ''    End If
        ''End If

        Select Case dgvPreAplicacion.Columns(e.ColumnIndex).Name

            Case "cbxDiferidoSi"
                If dgvPreAplicacion.CurrentRow.Cells("cbxDiferidoSi").Value Then
                    'nRowIndex = dgvFinanciamiento.CurrentRow.Index
                    'dAPLICA_SIGV = dgvFinanciamiento.CurrentRow.Cells("APLICA_CIGV").Value - dgvFinanciamiento.CurrentRow.Cells("APLICA_CIGV").Value * dIGV / 100
                    'dgvFinanciamiento.CurrentRow.Cells("APLICA_SIGV").Value = dAPLICA_SIGV
                    ''dgvFinanciamiento.CurrentRow.Cells("APLICA_CIGV").Value = FormatNumber(dgvFinanciamiento.CurrentRow.Cells("APLICA_CIGV").Value, 2)
                    dgvPreAplicacion.CurrentRow.Cells("cbxDiferidoNo").Value = False
                End If

            Case "cbxDiferidoNo"
                If dgvPreAplicacion.CurrentRow.Cells("cbxDiferidoNo").Value Then
                    'nRowIndex = dgvFinanciamiento.CurrentRow.Index
                    'dAPLICA_CIGV = dgvFinanciamiento.CurrentRow.Cells("APLICA_SIGV").Value + dgvFinanciamiento.CurrentRow.Cells("APLICA_SIGV").Value * dIGV / 100
                    'dgvFinanciamiento.CurrentRow.Cells("APLICA_CIGV").Value = dAPLICA_CIGV
                    ''dgvFinanciamiento.CurrentRow.Cells("APLICA_SIGV").Value = FormatNumber(dgvFinanciamiento.CurrentRow.Cells("APLICA_SIGV").Value, 2)
                    dgvPreAplicacion.CurrentRow.Cells("cbxDiferidoSi").Value = False
                End If

            Case "AjusteCIGV"
                If dgvPreAplicacion.CurrentRow.Cells("AjusteCIGV").Value IsNot Nothing Then
                    If dgvPreAplicacion.CurrentRow.Cells("AjusteCIGV").Value.ToString <> "" And dgvPreAplicacion.CurrentRow.Cells("AjusteCIGV").Value.ToString <> "." And dgvPreAplicacion.CurrentRow.Cells("AjusteCIGV").Value.ToString <> "-" Then
                        Dim dS_APLICA_CIGV As Double = dgvPreAplicacion.CurrentRow.Cells("S_ORIGINAL_CIGV").Value
                        'Dim dS_APLICA_SIGV As Double = dgvPreAplicacion.CurrentRow.Cells("S_APLICA_SIGV").Value
                        Dim dAjusteCIGV As Double = dgvPreAplicacion.CurrentRow.Cells("AjusteCIGV").Value 'IIf(dgvPreAplicacion.CurrentRow.Cells("AjusteCIGV").Value = ".", 0, dgvPreAplicacion.CurrentRow.Cells("AjusteCIGV").Value)

                        If dAjusteCIGV > dFinanciando_Ajuste_CIGV Or dAjusteCIGV < dFinanciando_Ajuste_CIGV * -1 Then
                            dgvPreAplicacion.CurrentRow.Cells("S_APLICA_CIGV").Value = dS_APLICA_CIGV
                            'dgvPreAplicacion.CurrentRow.Cells("S_APLICA_SIGV").Value = dS_APLICA_SIGV

                            dgvPreAplicacion.CurrentRow.Cells("AjusteCIGV").Value = 0

                            MsgBox("Solo puede realizar ajuste hasta + " + dFinanciando_Ajuste_CIGV.ToString + " ó -" + dFinanciando_Ajuste_CIGV.ToString, MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
                        Else
                            dgvPreAplicacion.CurrentRow.Cells("S_APLICA_CIGV").Value = dS_APLICA_CIGV + dAjusteCIGV
                            'dgvPreAplicacion.CurrentRow.Cells("S_APLICA_SIGV").Value = dS_APLICA_SIGV + dAjusteCIGV / 1.18
                        End If
                    End If
                End If



        End Select


        If Not dgvPreAplicacion.CurrentRow Is Nothing Then
            nRowIndex = dgvPreAplicacion.CurrentRow.Index
        End If
    End Sub

    Sub dgvPreAplicacion_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dgvPreAplicacion.CurrentCellDirtyStateChanged
        If dgvPreAplicacion.IsCurrentCellDirty Then
            dgvPreAplicacion.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Sub dgvFinanciamiento_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dgvFinanciamiento.CurrentCellDirtyStateChanged
        If dgvFinanciamiento.IsCurrentCellDirty Then
            dgvFinanciamiento.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub


    Private Sub cargarFiltros()

        Dim lstBE_General As New List(Of clsBE_General)
        Dim oBE_General As clsBE_General

        oBE_General = New clsBE_General
        oBE_General.NomCampo1 = ""
        oBE_General.NomCampo2 = "[Seleccione]"
        lstBE_General.Add(oBE_General)

        oBE_General = New clsBE_General
        oBE_General.NomCampo1 = "ID_TAD"
        oBE_General.NomCampo2 = "Td"
        lstBE_General.Add(oBE_General)

        oBE_General = New clsBE_General
        oBE_General.NomCampo1 = "NUM_COMPR"
        oBE_General.NomCampo2 = "Doc"
        lstBE_General.Add(oBE_General)

        oBE_General = New clsBE_General
        oBE_General.NomCampo1 = "FCH_PROGPAGO"
        oBE_General.NomCampo2 = "Fch OP"
        lstBE_General.Add(oBE_General)

        cboFiltro1.DataSource = lstBE_General
        cboFiltro1.ValueMember = "NomCampo1"
        cboFiltro1.DisplayMember = "NomCampo2"

    End Sub

    Private Sub tsbAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAplicar.Click
        'Dim lst As New List(Of clsBE_FINANCIANDO_PRELIQ)

        Dim oBC_FINANCIANDO_PRELIQRO As New clsBC_FINANCIANDO_PRELIQRO
        Dim oBE_FINANCIANDO_PRELIQ As New clsBE_FINANCIANDO_PRELIQ

        dgvPreAplicacion.AutoGenerateColumns = False

        Dim scondicion_empresa As String = ""
        Dim scondicion_nro_op As String = ""
        Dim scondicion_tipo_op As String = ""
        Dim scondicion_tipo_compr As String = ""
        Dim scondicion_num_compr As String = ""
        Dim scondicion_seq As String = ""

        'lst.Clear()

        Dim oDataGridViewCheckBoxColumn As New DataGridViewCheckBoxCell


        For Each row In dgvFinanciamiento.Rows
            'oDataGridViewCheckBoxColumn = CType(row.cells("cbxAplicar"), DataGridViewCheckBoxCell)

            ''oDataGridViewCheckBoxColumn.Value

            If CBool(row.Cells("cbxAplicar").value) Then
                oBE_FINANCIANDO_PRELIQ = New clsBE_FINANCIANDO_PRELIQ
                'o.NUM_COMPR_LIQ = dgvFinanciamiento.Item("COMPROBANTE", i).Value.ToString

                scondicion_empresa = scondicion_empresa & "'" & row.Cells("empresa").Value.ToString & "',"
                scondicion_nro_op = scondicion_nro_op & "'" & row.Cells("NRO_OP").Value.ToString & "',"
                scondicion_tipo_op = scondicion_tipo_op & "'" & row.Cells("TIPO_OP").Value.ToString & "',"
                scondicion_tipo_compr = scondicion_tipo_compr & "'" & row.Cells("TIPO_COMPR").Value.ToString & "',"
                scondicion_num_compr = scondicion_num_compr & "'" & row.Cells("num_compr").Value.ToString & "',"
                scondicion_seq = scondicion_seq & "'" & row.Cells("seq").value.ToString & "',"

                bSeleccion = True
            End If
        Next

        If bSeleccion Then

            'OBTENER FINANCIANDO
            oBE_FINANCIANDO_PRELIQ.scondicion_empresa = scondicion_empresa.Substring(0, scondicion_empresa.Length - 1)
            oBE_FINANCIANDO_PRELIQ.scondicion_nro_op = scondicion_nro_op.Substring(0, scondicion_nro_op.Length - 1)
            oBE_FINANCIANDO_PRELIQ.scondicion_tipo_op = scondicion_tipo_op.Substring(0, scondicion_tipo_op.Length - 1)
            oBE_FINANCIANDO_PRELIQ.scondicion_tipo_compr = scondicion_tipo_compr.Substring(0, scondicion_tipo_compr.Length - 1)
            oBE_FINANCIANDO_PRELIQ.scondicion_num_compr = scondicion_num_compr.Substring(0, scondicion_num_compr.Length - 1)
            oBE_FINANCIANDO_PRELIQ.scondicion_seq = scondicion_seq.Substring(0, scondicion_seq.Length - 1)

            oBC_FINANCIANDO_PRELIQRO.oBEFINANCIANDO_PRELIQ = oBE_FINANCIANDO_PRELIQ
            oBC_FINANCIANDO_PRELIQRO.LeerListaToDSFINANCIANDO_SELECCION()
            Dim DS As DataSet = oBC_FINANCIANDO_PRELIQRO.oDSFINANCIANDO_PRELIQ


            For i = 0 To dgvFinanciamiento.Rows.Count - 1


                If ((dgvFinanciamiento.Item(0, i).Value) Or (dgvFinanciamiento.Item(0, i).Value = True)) Then
                    oBE_FINANCIANDO_PRELIQ = New clsBE_FINANCIANDO_PRELIQ

                    For j = 0 To DS.Tables(0).Rows.Count - 1
                        If DS.Tables(0).Rows(j)("empresa").ToString() = dgvFinanciamiento.Item("empresa", i).Value.ToString And DS.Tables(0).Rows(j)("NRO_OP").ToString() = dgvFinanciamiento.Item("NRO_OP", i).Value.ToString And DS.Tables(0).Rows(j)("TIPO_OP").ToString() = dgvFinanciamiento.Item("TIPO_OP", i).Value.ToString And DS.Tables(0).Rows(j)("TIPO_COMPR").ToString() = dgvFinanciamiento.Item("TIPO_COMPR", i).Value.ToString And DS.Tables(0).Rows(j)("num_compr").ToString() = dgvFinanciamiento.Item("num_compr", i).Value.ToString And DS.Tables(0).Rows(j)("seq").ToString() = dgvFinanciamiento.Item("seq", i).Value.ToString Then

                            If (dgvFinanciamiento.Item("SALDO_CIGV", i).Value < dgvFinanciamiento.Item("APLICA_CIGV", i).Value) Or _
                                (dgvFinanciamiento.Item("SALDO_SIGV", i).Value < dgvFinanciamiento.Item("APLICA_SIGV", i).Value) Then
                                MsgBox("El monto aplicado no puede ser mayor al saldo disponible - OP: " + dgvFinanciamiento.Item("NRO_OP", i).Value.ToString, MsgBoxStyle.Critical, "Valorizador Comercial de Minerales")
                                Exit Sub
                            End If

                            If dgvFinanciamiento.Item("tablaDetId", i).Value.ToString <> empresa_grupo Then
                                'descuento de caja
                                InsertarDescuento("DESCUENTO", "Caja " & dgvFinanciamiento.Item("tipo_compr", i).Value.ToString & RTrim(dgvFinanciamiento.Item("num_compr", i).Value.ToString), dgvFinanciamiento.Item("APLICA_CIGV", i).Value.ToString, , , dgvFinanciamiento.Item("tipo_compr", i).Value.ToString, RTrim(dgvFinanciamiento.Item("num_compr", i).Value.ToString))
                                'InsertarDescuento("ADELANTO", "Caja " & dgvFinanciamiento.Item("tipo_compr", i).Value.ToString & RTrim(dgvFinanciamiento.Item("num_compr", i).Value.ToString), dgvFinanciamiento.Item("APLICA_CIGV", i).Value.ToString, , , dgvFinanciamiento.Item("tipo_compr", i).Value.ToString, RTrim(dgvFinanciamiento.Item("num_compr", i).Value.ToString))
                            Else
                                'adelanto
                                'DS.Tables(0).Rows(j)("SALDO") = dgvFinanciamiento.Item("MONTO_SALDO_US", i).Value - dgvFinanciamiento.Item("APLICA_SIGV", i).Value
                                DS.Tables(0).Rows(j)("APLICA_SIGV") = dgvFinanciamiento.Item("APLICA_SIGV", i).Value.ToString
                                DS.Tables(0).Rows(j)("APLICA_CIGV") = dgvFinanciamiento.Item("APLICA_CIGV", i).Value.ToString
                                DS.Tables(0).Rows(j)("ORIGINAL_APLICA_CIGV") = dgvFinanciamiento.Item("APLICA_CIGV", i).Value.ToString

                                DS.Tables(0).Rows(j)("SALDO_SIGV") = dgvFinanciamiento.Item("SALDO_SIGV", i).Value - dgvFinanciamiento.Item("APLICA_SIGV", i).Value
                                DS.Tables(0).Rows(j)("SALDO_CIGV") = dgvFinanciamiento.Item("SALDO_CIGV", i).Value - dgvFinanciamiento.Item("APLICA_CIGV", i).Value

                            End If

                        End If
                    Next

                End If
            Next

            DS.Tables(0).DefaultView.RowFilter = "tablaDetId ='" & empresa_grupo & "'" ' OR (NRO_DOC like '%" & txtContrato.Text & "%' and RUMA like '%" & txtRuma.Text & "%'" & sCondicion1 & ")"


            ''Dim newCustomersRow As DataRow = DS.Tables(0).NewRow()
            ''newCustomersRow("NRO_OP") = "TOTAL"
            ''newCustomersRow("SALDO_SIGV") = DS.Tables(0).Compute("SUM(SALDO_SIGV)", "")
            ''newCustomersRow("SALDO_CIGV") = DS.Tables(0).Compute("SUM(SALDO_CIGV)", "")

            ''newCustomersRow("APLICA_SIGV") = DS.Tables(0).Compute("SUM(APLICA_SIGV)", "")
            ''newCustomersRow("APLICA_CIGV") = DS.Tables(0).Compute("SUM(APLICA_CIGV)", "")

            ''newCustomersRow("tablaDetId") = empresa_grupo 'DS.Tables(0).Compute("SUM(APLICA_CIGV)", "")


            txtPreSaldo_sigv.Text = FormatNumber(DS.Tables(0).Compute("SUM(SALDO_SIGV)", ""), 2)
            txtPreSaldo_cigv.Text = FormatNumber(DS.Tables(0).Compute("SUM(SALDO_CIGV)", ""), 2)

            txtPreAplica_sigv.Text = FormatNumber(DS.Tables(0).Compute("SUM(APLICA_SIGV)", ""), 2)
            txtPreAplica_cigv.Text = FormatNumber(DS.Tables(0).Compute("SUM(APLICA_CIGV)", ""), 2)




            'DS.Tables(0).Rows.Add(newCustomersRow)
            dgvPreAplicacion.DataSource = DS.Tables(0)



            'If dgvPreAplicacion.Rows.Count > 0 Then
            '    dgvPreAplicacion.Rows(dgvPreAplicacion.Rows.Count - 1).Cells("S_NRO_OP").Style.BackColor = Color.LightGray
            '    dgvPreAplicacion.Rows(dgvPreAplicacion.Rows.Count - 1).Cells("S_SALDO_SIGV").Style.BackColor = Color.LightGray
            '    dgvPreAplicacion.Rows(dgvPreAplicacion.Rows.Count - 1).Cells("S_SALDO_CIGV").Style.BackColor = Color.LightGray
            '    dgvPreAplicacion.Rows(dgvPreAplicacion.Rows.Count - 1).Cells("S_APLICA_SIGV").Style.BackColor = Color.LightGray
            '    dgvPreAplicacion.Rows(dgvPreAplicacion.Rows.Count - 1).Cells("S_APLICA_CIGV").Style.BackColor = Color.LightGray
            'End If


            'dgvPreAplicacion.Rows(dgvPreAplicacion.Rows.Count - 1).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
            EditarColumnasModificables(dgvPreAplicacion, "cbxDiferidoSi,cbxDiferidoNo,AjusteCIGV")


        Else
            MessageBox.Show("Debe seleccionar")
        End If

    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        For i = 0 To dgvDESCUENTOS_LIQ.RowCount - 1
            If dgvDESCUENTOS_LIQ.Item("cbotablaDetId", i).Value = "" Then
                MsgBox("Debe seleccionar el tipo de descuento", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
                Exit Sub
            End If

            If dgvDESCUENTOS_LIQ.Item("txtBeneficiarioId", i).Value = "" Then
                MsgBox("Debe ingresar el Beneficiario", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
                Exit Sub
            End If

            ' ''If dgvDESCUENTOS_LIQ.Item("cbotablaDetId", i).Value = "DESCUENTO" Then
            ''If dgvDESCUENTOS_LIQ.Item("txtDescripcion", i).Value = "" Then
            ''    MsgBox("Debe ingresar la descripción", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
            ''    Exit Sub
            ''End If
            ' ''End If
        Next


        '************************************************************
        Dim sMensaje As String = ""
        For i = 0 To dgvPreAplicacion.RowCount - 1

            Dim dS_APLICA_CIGV As Double = dgvPreAplicacion.Rows(i).Cells("S_APLICA_CIGV").Value
            Dim nS_APLICA_CIGV As Integer = dgvPreAplicacion.Rows(i).Cells("S_APLICA_CIGV").Value
            Dim dAjuste_CIGV As Double = 0.01

            If ((dS_APLICA_CIGV - nS_APLICA_CIGV >= dAjuste_CIGV) Or (dS_APLICA_CIGV - nS_APLICA_CIGV <= dAjuste_CIGV * -1)) And (dgvPreAplicacion.Rows(i).Cells("AjusteCIGV").Value = Nothing Or dgvPreAplicacion.Rows(i).Cells("AjusteCIGV").Value = 0) Then

                sMensaje += "Nro Doc. : " + dgvPreAplicacion.Rows(i).Cells("S_NUM_COMPR").Value + " - Ajuste: " + FormatNumber((dS_APLICA_CIGV - nS_APLICA_CIGV), 2).ToString + Chr(10)

            End If
        Next

        If sMensaje = "" Then
            GuardarFinanciamiento()
        Else
            If MsgBox("Esta seguro que no desea colocarle ajuste " + Chr(10) + sMensaje, MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then
                'MsgBox("Si", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
                GuardarFinanciamiento()
            Else
                'MsgBox("No", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
                Exit Sub
            End If
        End If


        'Exit Sub
        '************************************************************

    End Sub


    Private Sub GuardarFinanciamiento()


        If bSeleccion Or dgvFinanciamiento.RowCount = 0 Then


            '**********************************************************************
            'valida se se ha seleccionado diferido o no
            For i = 0 To dgvPreAplicacion.RowCount - 1
                If (dgvPreAplicacion.Item("cbxDiferidoSi", i).Value Is Nothing And dgvPreAplicacion.Item("cbxDiferidoNo", i).Value Is Nothing) Or (dgvPreAplicacion.Item("cbxDiferidoSi", i).Value = False And dgvPreAplicacion.Item("cbxDiferidoNo", i).Value = False) Then

                    MsgBox("No se ha seleccionado SI es DIFERIDO o NO", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
                    Exit Sub
                End If
            Next
            '**********************************************************************











            '**********************************************************************
            'Busca si existe en reclasificacion
            Dim oBC_TB_RECLASIFICARO As New clsBC_TB_RECLASIFICARO
            ' ''Dim oBE_TB_RECLASIFICA As New clsBE_TB_RECLASIFICA
            Dim dsTB_RECLASIFICA As DataSet
            ''oBC_TB_RECLASIFICARO.oBETB_RECLASIFICA = New clsBE_TB_RECLASIFICA
            ''oBC_TB_RECLASIFICARO.oBETB_RECLASIFICA.RUC = ""
            ''oBC_TB_RECLASIFICARO.oBETB_RECLASIFICA.FACT = ""
            ''oBC_TB_RECLASIFICARO.oBETB_RECLASIFICA.FACTURA = ""
            ''oBC_TB_RECLASIFICARO.LeerListaToDSTB_RECLASIFICA()
            ''dsTB_RECLASIFICA = oBC_TB_RECLASIFICARO.oDSTB_RECLASIFICA


            Dim sumaMontoAplicar As Double = 0
            For i = 0 To dgvPreAplicacion.RowCount - 1
                If dgvPreAplicacion.Item("S_NRO_DOC", i).Value <> contrato And dgvPreAplicacion.Item("S_NRO_OP", i).Value <> "000000" Then
                    'If dgvPreAplicacion.Item("S_NRO_DOC", i).Value Is Nothing And dgvPreAplicacion.Item("cbxDiferidoNo", i).Value Is Nothing Then

                    If dgvPreAplicacion.Item("cbxDiferidoSi", i).Value Then
                        oBC_TB_RECLASIFICARO.oBETB_RECLASIFICA = New clsBE_TB_RECLASIFICA
                        oBC_TB_RECLASIFICARO.oBETB_RECLASIFICA.RUC = dgvPreAplicacion.Item("S_proveedor", i).Value.ToString.TrimEnd
                        oBC_TB_RECLASIFICARO.oBETB_RECLASIFICA.FACT = dgvPreAplicacion.Item("S_tipo_compr", i).Value
                        oBC_TB_RECLASIFICARO.oBETB_RECLASIFICA.FACTURA = dgvPreAplicacion.Item("S_num_compr", i).Value.ToString.TrimEnd
                        oBC_TB_RECLASIFICARO.oBETB_RECLASIFICA.FLG_RECLASIFICA = 2
                        oBC_TB_RECLASIFICARO.LeerListaToDSTB_RECLASIFICA()
                        dsTB_RECLASIFICA = oBC_TB_RECLASIFICARO.oDSTB_RECLASIFICA


                        If dsTB_RECLASIFICA.Tables(0).Rows.Count > 0 Then
                            MsgBox("No se puede enviar a reclasificado por que ya se encuentra registrado. " & dgvPreAplicacion.Item("S_NRO_DOC", i).Value, MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
                            Exit Sub
                        End If
                    End If

                    sumaMontoAplicar = sumaMontoAplicar + CDbl(dgvPreAplicacion.Item("S_APLICA_SIGV", i).Value)
                End If
            Next

            '**********************************************************************

            Dim oBE_FINANCIANDO_PRELIQ As New clsBE_FINANCIANDO_PRELIQ
            Dim oBC_FINANCIANDO_PRELIQTX As New clsBC_FINANCIANDO_PRELIQTX

            'valorizador
            Dim oLiquidacionDsctoTX As New clsBC_LiquidacionDsctoTX


            Dim scbcSi As String

            'tabla temporal para generacion del PDF
            Dim oBC_t_financiando_seleccionRO As New clsBC_t_financiando_seleccionRO
            Dim oBC_t_financiando_seleccionTX As New clsBC_t_financiando_seleccionTX
            Dim oBE_t_financiando_seleccion As New clsBE_t_financiando_seleccion

            Dim oFINANCIANDO_PRELIQ As New clsBC_FINANCIANDO_PRELIQRO
            Dim nItem As Integer '= oFINANCIANDO_PRELIQ.Obtener_Correlativo
            If txtItem.Text = 0 Then
                nItem = oFINANCIANDO_PRELIQ.Obtener_Correlativo
            Else
                nItem = txtItem.Text
            End If

            Dim oBC_TB_RECLASIFICATX = New clsBC_TB_RECLASIFICATX
            oBC_FINANCIANDO_PRELIQTX.LstFINANCIANDO_PRELIQ_INSERT.Clear()

            For i = 0 To dgvPreAplicacion.RowCount - 1
                oBC_FINANCIANDO_PRELIQTX.NuevaEntidad()

                With oBC_FINANCIANDO_PRELIQTX.oBEFINANCIANDO_PRELIQ
                    .Item = nItem
                    .estado_fin = "L" ' dgvFinanciamiento.Item("ESTADO_FIN", i).Value
                    .flg_aplica = "C" 'dgvFinanciamiento.Item("", i).Value

                    If dgvPreAplicacion.Item("cbxDiferidoSi", i).Value Then
                        scbcSi = "S"
                    Else
                        scbcSi = "N"
                    End If
                    .flg_diferido = scbcSi

                    .empresa = dgvPreAplicacion.Item("S_EMPRESA", i).Value
                    .NRO_OP = dgvPreAplicacion.Item("S_nro_op", i).Value
                    .tipo_op = dgvPreAplicacion.Item("S_tipo_op", i).Value
                    .TIPO_COMPR = dgvPreAplicacion.Item("S_TIPO_COMPR", i).Value
                    .num_compr = dgvPreAplicacion.Item("S_num_compr", i).Value
                    .seq = dgvPreAplicacion.Item("S_seq", i).Value

                    ''?????????????????
                    .tipo_compr_liq = dgvPreAplicacion.Item("S_tipo_compr_liq", i).Value
                    .NUM_COMPR_LIQ = "" 'txtNum_compr_liq.Text ' dgvPreAplicacion.Item("S_num_compr_liq", i).Value

                    .usuario_liq = pBEUsuario.campo3
                    .monto_Liq = dgvPreAplicacion.Item("S_APLICA_SIGV", i).Value

                    'KMN 29/04/2013
                    .monto_Liq_CIGV = dgvPreAplicacion.Item("S_APLICA_CIGV", i).Value
                    .monto_tot_liq = sumaMontoAplicar

                    .cod_lote = contrato
                    .LOTE_COM = lote
                    .proveedor_liq = proveedor
                    .estado_liq = "T"
                    .RUMA = dgvPreAplicacion.Item("s_ruma", i).Value
                    .sContratoLoteId = contratoLoteId

                    oBC_FINANCIANDO_PRELIQTX.LstFINANCIANDO_PRELIQ_INSERT.Add(oBC_FINANCIANDO_PRELIQTX.oBEFINANCIANDO_PRELIQ)

                    '**************************************************************
                    'tabla temporal
                    oBC_t_financiando_seleccionTX.NuevaEntidad()
                    With oBC_t_financiando_seleccionTX.oBEt_financiando_seleccion
                        'oBE_t_financiando_seleccion = New clsBE_t_financiando_seleccion
                        .item = nItem
                        .diferido = scbcSi
                        .empresa = dgvPreAplicacion.Item("S_DES_EMPRESA", i).Value
                        .td = "" 'dgvPreAplicacion.Item("S_TIPO_COMPR", i).Value
                        .nro_doc = "" 'dgvPreAplicacion.Item("S_nro_COMPR", i).Value
                        .nro_caja = "" 'dgvPreAplicacion.Item("S_caja", i).Value
                        .nro_op = dgvPreAplicacion.Item("s_nro_op", i).Value
                        .fch_op = dgvPreAplicacion.Item("s_fch_progpago", i).Value
                        .lote = dgvPreAplicacion.Item("s_nro_doc", i).Value
                        .ruma = dgvPreAplicacion.Item("s_ruma", i).Value.ToString
                        .tad = dgvPreAplicacion.Item("s_id_tad", i).Value
                        .calidad = dgvPreAplicacion.Item("s_calidad", i).Value
                        .us_aplica_sigv = dgvPreAplicacion.Item("S_APLICA_SIGV", i).Value
                        .us_aplica_cigv = dgvPreAplicacion.Item("S_APLICA_CIGV", i).Value
                        .saldo_us = dgvPreAplicacion.Item("s_SALDO_SIGV", i).Value

                        .nro_cierre = 0
                        .proveedor = proveedor_nombre
                        .lote_vcm = contrato & "/" & lote
                        '.item = item
                    End With
                    'oBC_t_financiando_seleccionTX.oBEt_financiando_seleccion = oBE_t_financiando_seleccion
                    oBC_t_financiando_seleccionTX.Lstt_financiando_seleccion_INSERT.Add(oBC_t_financiando_seleccionTX.oBEt_financiando_seleccion)
                    'oBC_t_financiando_seleccionTX.t_financiando_seleccion_INSERT()

                    '**************************************************************
                    'oBC_FINANCIANDO_PRELIQTX.financiando_preliq_INSERT()
                    'item = oBC_FINANCIANDO_PRELIQTX.oBEFINANCIANDO_PRELIQ.Item

                    'reclasifica
                    If scbcSi = "S" Then
                        oBC_TB_RECLASIFICATX.NuevaEntidad()
                        oBC_TB_RECLASIFICATX.oBETB_RECLASIFICA = New clsBE_TB_RECLASIFICA

                        oBC_TB_RECLASIFICATX.oBETB_RECLASIFICA.ID_ITEM = nItem

                        oBC_TB_RECLASIFICATX.oBETB_RECLASIFICA.EMPRESA = dgvPreAplicacion.Item("S_EMPRESA", i).Value
                        oBC_TB_RECLASIFICATX.oBETB_RECLASIFICA.RUC = dgvPreAplicacion.Item("s_PROVEEDOR", i).Value
                        oBC_TB_RECLASIFICATX.oBETB_RECLASIFICA.PROVEEDOR = dgvPreAplicacion.Item("s_PROV_ABREV", i).Value
                        'oBC_TB_RECLASIFICATX.oBETB_RECLASIFICA.DOCUM = dgvPreAplicacion.Item("s_DOCUM", i).Value
                        oBC_TB_RECLASIFICATX.oBETB_RECLASIFICA.FECHA1 = dgvPreAplicacion.Item("S_FCH_PROGPAGO", i).Value
                        oBC_TB_RECLASIFICATX.oBETB_RECLASIFICA.FECHA2 = dgvPreAplicacion.Item("S_FCH_PROGPAGO", i).Value
                        oBC_TB_RECLASIFICATX.oBETB_RECLASIFICA.LOTEREF = "Aplica"
                        oBC_TB_RECLASIFICATX.oBETB_RECLASIFICA.MONEDA = dgvPreAplicacion.Item("s_MONEDA", i).Value
                        oBC_TB_RECLASIFICATX.oBETB_RECLASIFICA.DOLAR = dgvPreAplicacion.Item("S_APLICA_SIGV", i).Value

                        oBC_TB_RECLASIFICATX.oBETB_RECLASIFICA.FACT = dgvPreAplicacion.Item("S_TIPO_COMPR", i).Value
                        oBC_TB_RECLASIFICATX.oBETB_RECLASIFICA.FACTURA = dgvPreAplicacion.Item("S_NUM_COMPR", i).Value

                        oBC_TB_RECLASIFICATX.oBETB_RECLASIFICA.FLG_RECLASIFICA = 2
                        oBC_TB_RECLASIFICATX.oBETB_RECLASIFICA.USER_RECLA = pBEUsuario.campo3 'pBEUsuario.tablaDetId ' dgvPreAplicacion.Item("s_USER_RECLA", i).Value
                        oBC_TB_RECLASIFICATX.oBETB_RECLASIFICA.FECHA_RECLA = "01/01/1900" 'dgvPreAplicacion.Item("s_FECHA_RECLA", i).Value

                        oBC_TB_RECLASIFICATX.oBETB_RECLASIFICA.ITEM = nItem
                        'oBC_TB_RECLASIFICATX.oBETB_RECLASIFICA.FACT_LIQUIDA = dgvPreAplicacion.Item("s_FACT_LIQUIDA", i).Value
                        oBC_TB_RECLASIFICATX.LstTB_RECLASIFICA_INSERT.Add(oBC_TB_RECLASIFICATX.oBETB_RECLASIFICA)

                    End If

                End With







                ' ''************************************************************************************************************************************************
                ''oLiquidacionDsctoTX.NuevaEntidad()
                ''With oLiquidacionDsctoTX.oBELiquidacionDscto
                ''    .contratoLoteId = contratoLoteId

                ''    .liquidacionId = liquidacionId
                ''    '.liquidacionDsctoId = Obtener_Correlativo("tbLiquidacionDscto", "liquidacionDsctoId", "contratoloteid", pstrCorrelativo, "liquidacionId", pstrCorrelativoLiquidacion)
                ''    .codigoDscto = sCodigoDscto '"ADELANTO"
                ''    '.descri = "Doc: " & RTrim(row.num_compr) & "  -  OP:" & row.NRO_OP
                ''    '.importe = row.monto_Liq_CIGV
                ''    .descri = "Doc: " & RTrim(dgvPreAplicacion.Item("S_num_compr", i).Value) & "  -  OP:" & dgvPreAplicacion.Item("S_nro_op", i).Value
                ''    .importe = dgvPreAplicacion.Item("S_APLICA_CIGV", i).Value
                ''    .codigoEstado = TABLA_DE_ESTADOS.ACTIVO.Value
                ''    .uc = pBEUsuario.tablaDetId
                ''    .um = pBEUsuario.tablaDetId
                ''    .nro = nItem 'row.Item  'row.NRO_DOC
                ''    .observa = ""


                ''    .EMPRESA = dgvPreAplicacion.Item("S_EMPRESA", i).Value
                ''    .NRO_OP = dgvPreAplicacion.Item("S_nro_op", i).Value
                ''    .TIPO_OP = dgvPreAplicacion.Item("S_tipo_op", i).Value
                ''    .TIPO_COMPR = dgvPreAplicacion.Item("S_TIPO_COMPR", i).Value
                ''    .NUM_COMPR = dgvPreAplicacion.Item("S_num_compr", i).Value
                ''    .SEQ = dgvPreAplicacion.Item("S_seq", i).Value
                ''    .PROVEEDOR = proveedor


                ''    .liquidacionDsctoId = ""
                ''    oLiquidacionDsctoTX.LstLiquidacionDsctoIns.Add(oLiquidacionDsctoTX.oBELiquidacionDscto)

                ''End With
                ' ''************************************************************************************************************************************************


            Next

            oBC_TB_RECLASIFICATX.TB_RECLASIFICA_INSERT()
            ''se guarda la pre-aplicacion
            oBC_FINANCIANDO_PRELIQTX.financiando_preliq_INSERT()
            ''oLiquidacionDsctoTX.InsertarDscto()

            'LstFINANCIANDO_PRELIQ_INSERT = oBC_FINANCIANDO_PRELIQTX.LstFINANCIANDO_PRELIQ_INSERT


            '************************************************************************************************************************************************
            '************************************************************************************************************************************************
            ''Dim item As Integer
            ''Dim oLiquidacionDsctoTX As New clsBC_LiquidacionDsctoTX
            ' '' ''For Each row As DataGridViewRow In dgvAjustes.Rows
            ''For Each row In oBC_FINANCIANDO_PRELIQTX.LstFINANCIANDO_PRELIQ_INSERT
            ''    oBE_FINANCIANDO_PRELIQ = row
            ''    item = row.Item

            ''    oLiquidacionDsctoTX.NuevaEntidad()
            ''    With oLiquidacionDsctoTX.oBELiquidacionDscto
            ''        .contratoLoteId = contratoLoteId

            ''        .liquidacionId = liquidacionId
            ''        '.liquidacionDsctoId = Obtener_Correlativo("tbLiquidacionDscto", "liquidacionDsctoId", "contratoloteid", pstrCorrelativo, "liquidacionId", pstrCorrelativoLiquidacion)
            ''        .codigoDscto = sCodigoDscto '"ADELANTO"
            ''        .descri = "Doc: " & RTrim(row.num_compr) & "  -  OP:" & row.NRO_OP
            ''        .importe = row.monto_Liq_CIGV
            ''        .codigoEstado = TABLA_DE_ESTADOS.ACTIVO.Value
            ''        .uc = pBEUsuario.tablaDetId
            ''        .um = pBEUsuario.tablaDetId
            ''        .nro = nItem 'row.Item  'row.NRO_DOC
            ''        .observa = ""

            ''        .liquidacionDsctoId = ""
            ''        oLiquidacionDsctoTX.LstLiquidacionDsctoIns.Add(oLiquidacionDsctoTX.oBELiquidacionDscto)

            ''    End With
            ''Next

            '' ''se guardan las preaplicacion en el VCM
            ''oLiquidacionDsctoTX.InsertarDscto()
            '************************************************************************************************************************************************
            '************************************************************************************************************************************************


            ''========================================================================================
            ''inserta los descuentos
            oLiquidacionDsctoTX = New clsBC_LiquidacionDsctoTX

            Dim sec As Integer = 0
            Dim oBC_TB_DESCUENTOS_LIQTX As New clsBC_TB_DESCUENTOS_LIQTX
            For i = 0 To dgvDESCUENTOS_LIQ.RowCount - 1
                sec = sec + 1
                oBC_TB_DESCUENTOS_LIQTX.NuevaEntidad()

                With oBC_TB_DESCUENTOS_LIQTX.oBETB_DESCUENTOS_LIQ
                    .ITEM = nItem 'item 'dgvPreAplicacion.Item("S_EMPRESA", i).Value
                    .SEC = sec 'dgvPreAplicacion.Item("S_EMPRESA", i).Value
                    .BENEFICIARIO = dgvDESCUENTOS_LIQ.Item("txtBeneficiarioId", i).Value
                    .BANCO = dgvDESCUENTOS_LIQ.Item("txtBanco", i).Value
                    .CUENTA_BCO = dgvDESCUENTOS_LIQ.Item("txtCUENTABCO", i).Value
                    .TIPO = dgvDESCUENTOS_LIQ.Item("cbotablaDetId", i).Value
                    .DESCRIPCION = dgvDESCUENTOS_LIQ.Item("txtDescripcion", i).Value
                    .IMPORTE = dgvDESCUENTOS_LIQ.Item("txtImporte", i).Value

                    .TIPO_COMPR = dgvDESCUENTOS_LIQ.Item("D_TIPO_COMPR", i).Value
                    .NUM_COMPR = dgvDESCUENTOS_LIQ.Item("D_NUM_COMPR", i).Value

                    .LINEA_CLI = dgvDESCUENTOS_LIQ.Item("LINEA_CLI", i).Value
                    .CUENTA_PROV = dgvDESCUENTOS_LIQ.Item("CUENTA_PROV", i).Value

                    .contratoLoteId = contratoLoteId
                    .usuario_liq = pBEUsuario.campo3 'pBEUsuario.tablaDetId


                End With
                oBC_TB_DESCUENTOS_LIQTX.LstTB_DESCUENTOS_LIQ_INSERT.Add(oBC_TB_DESCUENTOS_LIQTX.oBETB_DESCUENTOS_LIQ)


                ''oLiquidacionDsctoTX.NuevaEntidad()
                ''With oLiquidacionDsctoTX.oBELiquidacionDscto
                ''    .contratoLoteId = contratoLoteId

                ''    .liquidacionId = liquidacionId
                ''    '.liquidacionDsctoId = Obtener_Correlativo("tbLiquidacionDscto", "liquidacionDsctoId", "contratoloteid", pstrCorrelativo, "liquidacionId", pstrCorrelativoLiquidacion)
                ''    .codigoDscto = dgvDESCUENTOS_LIQ.Item("cbotablaDetId", i).Value
                ''    .descri = dgvDESCUENTOS_LIQ.Item("txtDescripcion", i).Value 'row.DESCRIPCION '"Doc: " & RTrim(row.num_compr) & "  -  OP:" & row.NRO_OP
                ''    .importe = dgvDESCUENTOS_LIQ.Item("txtImporte", i).Value 'row.IMPORTE
                ''    .codigoEstado = TABLA_DE_ESTADOS.ACTIVO.Value
                ''    .uc = pBEUsuario.tablaDetId
                ''    .um = pBEUsuario.tablaDetId
                ''    .nro = nItem 'row.ITEM  'row.NRO_DOC
                ''    .observa = ""

                ''    .liquidacionDsctoId = ""
                ''    oLiquidacionDsctoTX.LstLiquidacionDsctoIns.Add(oLiquidacionDsctoTX.oBELiquidacionDscto)

                ''End With


            Next
            oBC_TB_DESCUENTOS_LIQTX.TB_DESCUENTOS_LIQ_INSERT()

            oLiquidacionDsctoTX.InsertarDscto()


            ''oLiquidacionDsctoTX = New clsBC_LiquidacionDsctoTX
            ''Dim item As Integer
            ''Dim oBE_TB_DESCUENTOS_LIQ As New clsBE_TB_DESCUENTOS_LIQ
            ''For Each row In oBC_TB_DESCUENTOS_LIQTX.LstTB_DESCUENTOS_LIQ_INSERT
            ''    oBE_TB_DESCUENTOS_LIQ = row
            ''    item = row.ITEM

            ''    oLiquidacionDsctoTX.NuevaEntidad()
            ''    With oLiquidacionDsctoTX.oBELiquidacionDscto
            ''        .contratoLoteId = contratoLoteId

            ''        .liquidacionId = liquidacionId
            ''        '.liquidacionDsctoId = Obtener_Correlativo("tbLiquidacionDscto", "liquidacionDsctoId", "contratoloteid", pstrCorrelativo, "liquidacionId", pstrCorrelativoLiquidacion)
            ''        .codigoDscto = row.TIPO
            ''        .descri = row.DESCRIPCION '"Doc: " & RTrim(row.num_compr) & "  -  OP:" & row.NRO_OP
            ''        .importe = row.IMPORTE
            ''        .codigoEstado = TABLA_DE_ESTADOS.ACTIVO.Value
            ''        .uc = pBEUsuario.tablaDetId
            ''        .um = pBEUsuario.tablaDetId
            ''        .nro = nItem 'row.ITEM  'row.NRO_DOC
            ''        .observa = ""

            ''        .liquidacionDsctoId = ""
            ''        oLiquidacionDsctoTX.LstLiquidacionDsctoIns.Add(oLiquidacionDsctoTX.oBELiquidacionDscto)

            ''    End With
            ''Next
            '' ''guarda los descuentos en los preaplicacion en el VCM
            ''oLiquidacionDsctoTX.InsertarDscto()
            ''========================================================================================


            bAsociar = True

            ' ''Inserta el cierre
            ''Dim oBC_TB_CIERRE_DOCTX As New clsBC_TB_CIERRE_DOCTX
            ''oBC_TB_CIERRE_DOCTX.oBETB_CIERRE_DOC.Item_cierre = 0
            ''oBC_TB_CIERRE_DOCTX.oBETB_CIERRE_DOC.Archivo = 0 & "_LIQ" & contrato & "-" & lote & "_" & proveedor_nombre & ".pdf"
            ''oBC_TB_CIERRE_DOCTX.oBETB_CIERRE_DOC.Ruta = "LIQ" & contrato & "-" & lote & "_" & proveedor_nombre & ".pdf"
            ''oBC_TB_CIERRE_DOCTX.LstTB_CIERRE_DOC_INSERT.Add(oBC_TB_CIERRE_DOCTX.oBETB_CIERRE_DOC)
            ''oBC_TB_CIERRE_DOCTX.TB_CIERRE_DOC_INSERT()



            'Me.Close()

        Else

            If dgvDESCUENTOS_LIQ.RowCount > 0 Then

                Dim oLiquidacionDsctoTX As New clsBC_LiquidacionDsctoTX
                Dim nItem As Integer = txtItem.Text

                Dim oFINANCIANDO_PRELIQ As New clsBC_FINANCIANDO_PRELIQRO
                'Dim nItem As Integer '= oFINANCIANDO_PRELIQ.Obtener_Correlativo
                If txtItem.Text = 0 Then
                    nItem = oFINANCIANDO_PRELIQ.Obtener_Correlativo
                    txtItem.Text = nItem
                End If

                ''inserta los descuentos
                Dim sec As Integer = 0
                Dim oBC_TB_DESCUENTOS_LIQTX As New clsBC_TB_DESCUENTOS_LIQTX
                For i = 0 To dgvDESCUENTOS_LIQ.RowCount - 1
                    sec = sec + 1
                    oBC_TB_DESCUENTOS_LIQTX.NuevaEntidad()

                    With oBC_TB_DESCUENTOS_LIQTX.oBETB_DESCUENTOS_LIQ
                        .ITEM = nItem 'item 'dgvPreAplicacion.Item("S_EMPRESA", i).Value
                        .SEC = sec 'dgvPreAplicacion.Item("S_EMPRESA", i).Value
                        .BENEFICIARIO = dgvDESCUENTOS_LIQ.Item("txtBeneficiarioId", i).Value
                        .BANCO = dgvDESCUENTOS_LIQ.Item("txtBanco", i).Value
                        .CUENTA_BCO = dgvDESCUENTOS_LIQ.Item("txtCUENTABCO", i).Value
                        .TIPO = dgvDESCUENTOS_LIQ.Item("cbotablaDetId", i).Value
                        .DESCRIPCION = dgvDESCUENTOS_LIQ.Item("txtDescripcion", i).Value
                        .IMPORTE = dgvDESCUENTOS_LIQ.Item("txtImporte", i).Value

                        .TIPO_COMPR = dgvDESCUENTOS_LIQ.Item("D_TIPO_COMPR", i).Value
                        .NUM_COMPR = dgvDESCUENTOS_LIQ.Item("D_NUM_COMPR", i).Value


                        .LINEA_CLI = dgvDESCUENTOS_LIQ.Item("LINEA_CLI", i).Value
                        .CUENTA_PROV = dgvDESCUENTOS_LIQ.Item("CUENTA_PROV", i).Value

                        .contratoLoteId = contratoLoteId
                        .usuario_liq = pBEUsuario.campo3 'pBEUsuario.tablaDetId

                    End With
                    oBC_TB_DESCUENTOS_LIQTX.LstTB_DESCUENTOS_LIQ_INSERT.Add(oBC_TB_DESCUENTOS_LIQTX.oBETB_DESCUENTOS_LIQ)
                Next
                oBC_TB_DESCUENTOS_LIQTX.TB_DESCUENTOS_LIQ_INSERT()


                ''oLiquidacionDsctoTX = New clsBC_LiquidacionDsctoTX
                ''Dim oBE_TB_DESCUENTOS_LIQ As New clsBE_TB_DESCUENTOS_LIQ
                ''For Each row In oBC_TB_DESCUENTOS_LIQTX.LstTB_DESCUENTOS_LIQ_INSERT
                ''    oBE_TB_DESCUENTOS_LIQ = row
                ''    nItem = row.ITEM

                ''    oLiquidacionDsctoTX.NuevaEntidad()
                ''    With oLiquidacionDsctoTX.oBELiquidacionDscto
                ''        .contratoLoteId = contratoLoteId

                ''        .liquidacionId = liquidacionId
                ''        '.liquidacionDsctoId = Obtener_Correlativo("tbLiquidacionDscto", "liquidacionDsctoId", "contratoloteid", pstrCorrelativo, "liquidacionId", pstrCorrelativoLiquidacion)
                ''        .codigoDscto = row.TIPO
                ''        .descri = row.DESCRIPCION '"Doc: " & RTrim(row.num_compr) & "  -  OP:" & row.NRO_OP
                ''        .importe = row.IMPORTE
                ''        .codigoEstado = TABLA_DE_ESTADOS.ACTIVO.Value
                ''        .uc = pBEUsuario.tablaDetId
                ''        .um = pBEUsuario.tablaDetId
                ''        .nro = nItem 'row.ITEM  'row.NRO_DOC
                ''        .observa = ""

                ''        .liquidacionDsctoId = ""
                ''        oLiquidacionDsctoTX.LstLiquidacionDsctoIns.Add(oLiquidacionDsctoTX.oBELiquidacionDscto)

                ''    End With
                ''Next
                '' ''guarda los descuentos en los preaplicacion en el VCM
                ''oLiquidacionDsctoTX.InsertarDscto()

                bAsociar = True
            Else
                bAsociar = False

            End If

            'MessageBox.Show("No ha seleccionado")


        End If
        Me.Close()

    End Sub




    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub tsbFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbFiltrar.Click
        'cargarFiltros()
        If cbxPendientes.Checked Then
            CargarDatos()
        End If

        If cbxAplicados.Checked Then
            CargarDatosCtasXCobrar()
        End If
    End Sub


    Private Sub tsbLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLimpiar.Click
        txtContrato.Text = ""
        txtRuma.Text = ""

        txtCalidad.Text = ""

        txtCondicion1.Text = ""

        cboFiltro1.SelectedIndex = 0

        tsbFiltrar_Click(sender, e)

        dgvPreAplicacion.DataSource = Nothing
        dgvDESCUENTOS_LIQ.DataSource = Nothing

        bSeleccion = False
        bAsociar = False

    End Sub

    Private Sub cbxAplicaTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxAplicaTodos.CheckedChanged
        Dim bTodos As Boolean = cbxAplicaTodos.Checked
        If dgvFinanciamiento.Rows.Count > 0 Then


            For i = 0 To dgvFinanciamiento.Rows.Count - 1
                dgvFinanciamiento.Rows(i).Cells("cbxAplicar").Value = bTodos
            Next
        End If
    End Sub

    Private Sub cbxDiferidoSiTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxDiferidoSiTodos.CheckedChanged
        Dim bTodos As Boolean = cbxDiferidoSiTodos.Checked
        Dim bTodos2 As Boolean = IIf(bTodos, False, True)

        If dgvPreAplicacion.Rows.Count > 0 Then
            For i = 0 To dgvPreAplicacion.Rows.Count - 2
                dgvPreAplicacion.Rows(i).Cells("cbxDiferidoSi").Value = bTodos
                dgvPreAplicacion.Rows(i).Cells("cbxDiferidoNo").Value = bTodos2
            Next
        End If

        cbxDiferidoNoTodos.Checked = bTodos2
    End Sub

    Private Sub cbxDiferidoNoTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxDiferidoNoTodos.CheckedChanged
        Dim bTodos As Boolean = cbxDiferidoNoTodos.Checked
        Dim bTodos2 As Boolean = IIf(bTodos, False, True)

        If dgvPreAplicacion.Rows.Count > 0 Then
            For i = 0 To dgvPreAplicacion.Rows.Count - 1
                dgvPreAplicacion.Rows(i).Cells("cbxDiferidoNo").Value = bTodos
                dgvPreAplicacion.Rows(i).Cells("cbxDiferidoSi").Value = bTodos2
            Next
        End If

        cbxDiferidoSiTodos.Checked = bTodos2
    End Sub

    Private Sub txtContrato_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContrato.KeyPress, txtRuma.KeyPress, txtCondicion1.KeyPress, txtCalidad.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            tsbFiltrar_Click(sender, e)
        End If
    End Sub


    Private Sub cbxPendientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxPendientes.CheckedChanged, cbxAplicados.CheckedChanged, cbxCtasXCobrar.CheckedChanged

        Dim oBE_General As New clsBE_General
        Dim list As New ArrayList()

        cboEstado.Visible = True

        If cbxPendientes.Checked Then
            dgvCtasxCobrar.Visible = False
            dgvFinanciamiento.Visible = True
            'PENDIENTES
            'cboEstado.Items.Add(New ListViewItem("En Proceso", "R"))
            'cboEstado.Items.Add(New ListViewItem("Abiertos", "P"))
            'cboEstado.Items.Add(New ListViewItem("Todos", ""))

            oBE_General = New clsBE_General
            oBE_General.NomCampo1 = "En Proceso"
            oBE_General.NomCampo2 = "R"
            list.Add(oBE_General)

            oBE_General = New clsBE_General
            oBE_General.NomCampo1 = "Abiertos"
            oBE_General.NomCampo2 = "P"
            list.Add(oBE_General)

            oBE_General = New clsBE_General
            oBE_General.NomCampo1 = "Todos"
            oBE_General.NomCampo2 = ""
            list.Add(oBE_General)

            cboEstado.DataSource = list

            cboEstado.DisplayMember = "NomCampo1"
            cboEstado.ValueMember = "NomCampo2"

            If cboEstado.Items.Count > 0 Then
                cboEstado.SelectedIndex = 2
            End If
        End If

        If cbxAplicados.Checked Then

            CargarDatosCtasXCobrar()
            dgvFinanciamiento.Visible = False
            dgvCtasxCobrar.Visible = True

            'APLICADOS
            'cboEstado.Items.Clear()
            'cboEstado.Items.Add(New ListViewItem("Pre-Aplicados", "L"))
            'cboEstado.Items.Add(New ListViewItem("Aplicados", "A"))
            'cboEstado.Items.Add(New ListViewItem("Cerrados", "C"))
            'cboEstado.Items.Add(New ListViewItem("Todos", ""))

            oBE_General = New clsBE_General
            oBE_General.NomCampo1 = "Pre-Aplicados"
            oBE_General.NomCampo2 = "L"
            list.Add(oBE_General)

            oBE_General = New clsBE_General
            oBE_General.NomCampo1 = "Aplicados"
            oBE_General.NomCampo2 = "A"
            list.Add(oBE_General)

            oBE_General = New clsBE_General
            oBE_General.NomCampo1 = "Cerrados"
            oBE_General.NomCampo2 = "C"
            list.Add(oBE_General)

            oBE_General = New clsBE_General
            oBE_General.NomCampo1 = "Todos"
            oBE_General.NomCampo2 = ""
            list.Add(oBE_General)

            cboEstado.DataSource = list

            cboEstado.DisplayMember = "NomCampo1"
            cboEstado.ValueMember = "NomCampo2"

            'cboEstado.SelectedIndex = 2

        End If

        If cbxCtasXCobrar.Checked Then
            cboEstado.Visible = False

            CargarDatosCtasXCobrar()
            dgvFinanciamiento.Visible = False
            dgvCtasxCobrar.Visible = True

            ''CTAS X COBRAR
            ''cboEstado.Items.Clear()
            ''cboEstado.Items.Add(New ListViewItem("En Proceso", "R"))
            ''cboEstado.Items.Add(New ListViewItem("Abiertos", "P"))
            ''cboEstado.Items.Add(New ListViewItem("Todos", ""))

            'oBE_General = New clsBE_General
            'oBE_General.NomCampo1 = "En Proceso"
            'oBE_General.NomCampo2 = "R"
            'list.Add(oBE_General)

            'oBE_General = New clsBE_General
            'oBE_General.NomCampo1 = "Abiertos"
            'oBE_General.NomCampo2 = "P"
            'list.Add(oBE_General)

            'oBE_General = New clsBE_General
            'oBE_General.NomCampo1 = "Todos"
            'oBE_General.NomCampo2 = ""
            'list.Add(oBE_General)
        End If


    End Sub

    Private Sub cboEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEstado.SelectedIndexChanged

        If cbxPendientes.Checked Then
            CargarDatos()
        ElseIf cbxAplicados.Checked Then
            CargarDatosAplicados()
        ElseIf cbxCtasXCobrar.Checked Then
            CargarDatosCtasXCobrar()
        End If

    End Sub


    Private Sub CargarDatosCtasXCobrar()

        Dim oBC_FINANCIANDO_PRELIQRO As New clsBC_FINANCIANDO_PRELIQRO

        Dim dsAyuda As New DataSet
        oBC_FINANCIANDO_PRELIQRO.oBEFINANCIANDO_PRELIQ = oBE_FINANCIANDO_PRELIQ
        oBC_FINANCIANDO_PRELIQRO.LeerListaToDSFINANCIANDO_CLI()
        dsAyuda = oBC_FINANCIANDO_PRELIQRO.oDSFINANCIANDO_PRELIQ

        dgvCtasxCobrar.DataSource = dsAyuda.Tables(0)

    End Sub

    Private Sub CargarDatosAplicados()

        Dim oBC_FINANCIANDO_PRELIQRO As New clsBC_FINANCIANDO_PRELIQRO

        Dim dsAyuda As New DataSet
        oBC_FINANCIANDO_PRELIQRO.oBEFINANCIANDO_PRELIQ = oBE_FINANCIANDO_PRELIQ
        'oBC_FINANCIANDO_PRELIQRO.LeerListaToDSAplicados()
        oBC_FINANCIANDO_PRELIQRO.LeerListaFINANCIANDO_PRELIQ()
        dsAyuda = oBC_FINANCIANDO_PRELIQRO.oDSFINANCIANDO_PRELIQ

        dgvCtasxCobrar.DataSource = dsAyuda.Tables(0)

    End Sub

    Private Sub btnAgregarDscto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDscto.Click
        If MsgBox("Esta seguro que es un DESCUENTO A TERCERO y no una cuenta por cobrar", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then
            InsertarDescuento("DESCUENTO", "Descuento a Tercero")
        End If
    End Sub


    Private Sub dgvDESCUENTOS_LIQ_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDESCUENTOS_LIQ.CellValueChanged
        'cbotablaDetId
        'Mientras no existe la data, cuando es planta se colocaráminex
        If dgvDESCUENTOS_LIQ.Columns(e.ColumnIndex).Name = "cbotablaDetId" Then
            If dgvDESCUENTOS_LIQ.CurrentRow.Cells(e.ColumnIndex).EditedFormattedValue = "PLANTA" Then
                dgvDESCUENTOS_LIQ.CurrentRow.Cells("txtBeneficiarioId").Value = "20517031624" 'oGeneral.oBEGeneral.NomCampo1
                dgvDESCUENTOS_LIQ.CurrentRow.Cells("txtBeneficiarioDesc").Value = "MINERIA Y EXPORTACIONE SAC" 'oGeneral.oBEGeneral.NomCampo2

                dgvDESCUENTOS_LIQ.CurrentRow.Cells("txtBanco").Value = "BCP"
                dgvDESCUENTOS_LIQ.CurrentRow.Cells("txtMoneda").Value = "US"
                dgvDESCUENTOS_LIQ.CurrentRow.Cells("txtCuentaBco").Value = "193-1733432-1-23      "
            End If

        End If
    End Sub

    Private Sub dgvDESCUENTOS_LIQ_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvDESCUENTOS_LIQ.CellMouseClick

        Try
            If e.ColumnIndex >= 0 Then
                Dim oGeneral As New clsBC_GeneralRO
                Dim parametro As New Hashtable


                ' ''cbotablaDetId
                ' ''Mientras no existe la data, cuando es planta se colocaráminex
                ''If dgvDESCUENTOS_LIQ.Columns(e.ColumnIndex).Name = "cbotablaDetId" Then
                ''    If dgvDESCUENTOS_LIQ.CurrentRow.Cells(e.ColumnIndex).EditedFormattedValue = "PLANTA" Then
                ''        dgvDESCUENTOS_LIQ.CurrentRow.Cells("txtBeneficiarioId").Value = "20517031624" 'oGeneral.oBEGeneral.NomCampo1
                ''        dgvDESCUENTOS_LIQ.CurrentRow.Cells("txtBeneficiarioDesc").Value = "MINERIA Y EXPORTACIONE SAC" 'oGeneral.oBEGeneral.NomCampo2

                ''        dgvDESCUENTOS_LIQ.CurrentRow.Cells("txtBanco").Value = "BCP"
                ''        dgvDESCUENTOS_LIQ.CurrentRow.Cells("txtMoneda").Value = "US"
                ''        dgvDESCUENTOS_LIQ.CurrentRow.Cells("txtCuentaBco").Value = "193-1733432-1-23      "
                ''    End If

                ''End If

                If dgvDESCUENTOS_LIQ.Columns(e.ColumnIndex).Name = "txtBeneficiarioId" Or dgvDESCUENTOS_LIQ.Columns(e.ColumnIndex).Name = "txtBeneficiarioDesc" Then
                    oGeneral = New clsBC_GeneralRO
                    parametro = New Hashtable
                    oGeneral.LstGeneral.Clear()
                    ''parametro.Add("beneficiario", txtEmpresa.Text)
                    parametro.Add("empresa", empresa_grupo)
                    MostrarFormularioAyuda(EnumFormAyuda.Beneficiario, oGeneral, False, parametro)

                    If oGeneral.oBEGeneral.NomCampo1 IsNot Nothing And oGeneral.oBEGeneral.NomCampo2 IsNot Nothing Then
                        dgvDESCUENTOS_LIQ.CurrentRow.Cells("txtBeneficiarioId").Value = oGeneral.oBEGeneral.NomCampo1
                        dgvDESCUENTOS_LIQ.CurrentRow.Cells("txtBeneficiarioDesc").Value = oGeneral.oBEGeneral.NomCampo2
                        'BuscarenComboBox(beneficiario, oGeneral.oBEGeneral.NomCampo1)
                        dgvDESCUENTOS_LIQ.CurrentRow.Cells("txtBanco").Value = ""
                        dgvDESCUENTOS_LIQ.CurrentRow.Cells("txtMoneda").Value = ""
                        dgvDESCUENTOS_LIQ.CurrentRow.Cells("txtCuentaBco").Value = ""
                    End If

                End If

                If dgvDESCUENTOS_LIQ.Columns(e.ColumnIndex).Name = "txtBanco" Or dgvDESCUENTOS_LIQ.Columns(e.ColumnIndex).Name = "txtMoneda" Or dgvDESCUENTOS_LIQ.Columns(e.ColumnIndex).Name = "txtCuentaBco" Then
                    oGeneral = New clsBC_GeneralRO
                    parametro = New Hashtable

                    oGeneral.LstGeneral.Clear()
                    ''parametro.Add("beneficiario", txtEmpresa.Text)
                    parametro.Add("empresa", empresa_grupo)
                    parametro.Add("anexo", dgvDESCUENTOS_LIQ.CurrentRow.Cells("txtBeneficiarioId").Value)
                    MostrarFormularioAyuda(EnumFormAyuda.Anexo_Banco, oGeneral, False, parametro)

                    If oGeneral.oBEGeneral.NomCampo1 IsNot Nothing Then
                        dgvDESCUENTOS_LIQ.CurrentRow.Cells("txtBanco").Value = oGeneral.oBEGeneral.NomCampo1
                        dgvDESCUENTOS_LIQ.CurrentRow.Cells("txtMoneda").Value = oGeneral.oBEGeneral.NomCampo2
                        dgvDESCUENTOS_LIQ.CurrentRow.Cells("txtCuentaBco").Value = oGeneral.oBEGeneral.NomCampo3
                    End If

                End If
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try

    End Sub


    Private Sub btnEliminarDscto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarDscto.Click
        Dim drowP As DataRow

        If dgvDESCUENTOS_LIQ.CurrentCell IsNot Nothing Then
            drowP = BuscarenDatatable(dvwPagable.Table, "orden", dgvDESCUENTOS_LIQ.Rows(dgvDESCUENTOS_LIQ.CurrentCell.RowIndex).Cells("orden").Value)
            drowP.Delete()
        End If

    End Sub

    Private Sub InsertarDescuento(Optional ByVal codigo As String = "", Optional ByVal descripcion As String = "", Optional ByVal importe As String = "0", Optional ByVal beneficiarioId As String = "", Optional ByVal beneficiario As String = "", Optional ByVal sTIPO_COMPR As String = "", Optional ByVal sNUM_COMPR As String = "", Optional ByVal nLINEA_CLI As Integer = 0, Optional ByVal sCUENTA_PROV As String = "")
        Try

            If dtPagable Is Nothing Then
                Dim oTB_DESCUENTOS_LIQRO As New clsBC_TB_DESCUENTOS_LIQRO
                dtPagable = oTB_DESCUENTOS_LIQRO.DefineTablaTB_DESCUENTOS_LIQ  ' GenericListToDataTable(oPagableTX.LstValorizadorPagableIns) 'oValorizadorPagableRO.DefinirTablaValorizadorPagable

                dvwPagable = New DataView(dtPagable)
                dgvDESCUENTOS_LIQ.AutoGenerateColumns = False
                dgvDESCUENTOS_LIQ.DataSource = dvwPagable
            End If
            drowPagable = dtPagable.NewRow

            Dim nOrden As Integer = 0
            If dgvDESCUENTOS_LIQ.RowCount > 0 Then
                nOrden = dgvDESCUENTOS_LIQ.Rows(dgvDESCUENTOS_LIQ.RowCount - 1).Cells("orden").Value
            End If

            drowPagable("orden") = nOrden + 1
            drowPagable("tablaDetId") = codigo 'oTablaDetRO.oBETablaDet.tablaDetId
            drowPagable("txtDescripcion") = descripcion ' oTablaDetRO.oBETablaDet.campo14
            drowPagable("Importe") = importe

            drowPagable("BENEFICIARIO") = beneficiarioId  ' oTablaDetRO.oBETablaDet.campo14
            drowPagable("BENEFICIARIO_DESC") = beneficiario

            drowPagable("TIPO_COMPR") = sTIPO_COMPR  ' oTablaDetRO.oBETablaDet.campo14
            drowPagable("NUM_COMPR") = sNUM_COMPR


            drowPagable("LINEA_CLI") = nLINEA_CLI   ' oTablaDetRO.oBETablaDet.campo14
            drowPagable("CUENTA_PROV") = sCUENTA_PROV



            ''drowPagable("orden") = nOrden + 1
            ''drowPagable("tablaDetId") = codigo 'oTablaDetRO.oBETablaDet.tablaDetId
            ''drowPagable("txtDescripcion") = descripcion ' oTablaDetRO.oBETablaDet.campo14
            ''drowPagable("Importe") = importe

            ''drowPagable("BENEFICIARIO") = beneficiarioId  ' oTablaDetRO.oBETablaDet.campo14
            ''drowPagable("BENEFICIARIO_DESC") = beneficiario

            ''drowPagable("TIPO_COMPR") = sTIPO_COMPR  ' oTablaDetRO.oBETablaDet.campo14
            ''drowPagable("NUM_COMPR") = sNUM_COMPR


            dtPagable.Rows.Add(drowPagable)

            ''dgvDESCUENTOS_LIQ.Item("txtBeneficiarioId", ).Value = oGeneral.oBEGeneral.NomCampo1
            ''dgvDESCUENTOS_LIQ.CurrentRow.Cells("txtBeneficiarioDesc").Value = oGeneral.oBEGeneral.NomCampo2

            EditarColumnasModificables(dgvDESCUENTOS_LIQ, "txtDescripcion,txtImporte,ded,rc,prot,precio,dgvMerc,dgvQP,dgvqpAjuste,qpinicio,qpfinal,FinLey,FinPrecio")
            ''EditarColumnasModificables(dgvDESCUENTOS_LIQ, "cbotablaDetId,txtDescripcion,txtImporte,ded,rc,prot,precio,dgvMerc,dgvQP,dgvqpAjuste,qpinicio,qpfinal,FinLey,FinPrecio")

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Private Sub btnOtrasCtasDscto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtrasCtasDscto.Click
        Dim oGeneral As New clsBC_GeneralRO
        Dim parametro As New Hashtable
        oGeneral = New clsBC_GeneralRO
        parametro = New Hashtable

        oGeneral.LstGeneral.Clear()
        ''parametro.Add("beneficiario", txtEmpresa.Text)
        parametro.Add("proveedor", proveedor)

        MostrarFormularioAyuda(EnumFormAyuda.OtrasCuentasXCobrar, oGeneral, False, parametro)

        If oGeneral.oBEGeneral.NomCampo5 IsNot Nothing And oGeneral.oBEGeneral.NomCampo6 IsNot Nothing Then
            'InsertarDescuento("DESCUENTO", oGeneral.oBEGeneral.NomCampo6, oGeneral.oBEGeneral.NomCampo5, oGeneral.oBEGeneral.NomCampo7, oGeneral.oBEGeneral.NomCampo1, oGeneral.oBEGeneral.NomCampo2, oGeneral.oBEGeneral.NomCampo3)
            InsertarDescuento(oGeneral.oBEGeneral.NomCampo8, oGeneral.oBEGeneral.NomCampo6, oGeneral.oBEGeneral.NomCampo5, oGeneral.oBEGeneral.NomCampo7, oGeneral.oBEGeneral.NomCampo1, oGeneral.oBEGeneral.NomCampo2, oGeneral.oBEGeneral.NomCampo3, oGeneral.oBEGeneral.NomCampo9, oGeneral.oBEGeneral.NomCampo10)
        End If


        'dgvDESCUENTOS_LIQ.CurrentRow.Cells("txtMoneda").Value = oGeneral.oBEGeneral.NomCampo2
        'dgvDESCUENTOS_LIQ.CurrentRow.Cells("txtCuentaBco").Value = oGeneral.oBEGeneral.NomCampo3
    End Sub


   
    Private Sub btnPrestamosCChica_Click(sender As System.Object, e As System.EventArgs) Handles btnPrestamosCChica.Click
        Dim oGeneral As New clsBC_GeneralRO
        Dim parametro As New Hashtable
        oGeneral = New clsBC_GeneralRO
        parametro = New Hashtable

        oGeneral.LstGeneral.Clear()
        ''parametro.Add("beneficiario", txtEmpresa.Text)
        parametro.Add("proveedor", proveedor)

        MostrarFormularioAyuda(EnumFormAyuda.PrestamosCChica, oGeneral, False, parametro)

        

    End Sub

    Private Sub PrestamosComercial_Click(sender As System.Object, e As System.EventArgs) Handles PrestamosComercial.Click

        Dim oGeneral As New clsBC_GeneralRO
        Dim parametro As New Hashtable
        oGeneral = New clsBC_GeneralRO
        parametro = New Hashtable

        oGeneral.LstGeneral.Clear()
        ''parametro.Add("beneficiario", txtEmpresa.Text)
        parametro.Add("proveedor", proveedor)
        parametro.Add("empresa", empresa_grupo)

        MostrarFormularioAyuda(EnumFormAyuda.PrestamosComer, oGeneral, False, parametro)

        If oGeneral.oBEGeneral.NomCampo5 IsNot Nothing And oGeneral.oBEGeneral.NomCampo3 IsNot Nothing Then
            'InsertarDescuento("DESCUENTO", oGeneral.oBEGeneral.NomCampo6, oGeneral.oBEGeneral.NomCampo5, oGeneral.oBEGeneral.NomCampo7, oGeneral.oBEGeneral.NomCampo1, oGeneral.oBEGeneral.NomCampo2, oGeneral.oBEGeneral.NomCampo3)
            InsertarDescuento(oGeneral.oBEGeneral.NomCampo7, oGeneral.oBEGeneral.NomCampo10, oGeneral.oBEGeneral.NomCampo5, oGeneral.oBEGeneral.ValCampo1, oGeneral.oBEGeneral.NomCampo2, oGeneral.oBEGeneral.NomCampo9, oGeneral.oBEGeneral.NomCampo3, oGeneral.oBEGeneral.NomCampo5, oGeneral.oBEGeneral.NomCampo8)
        End If

    End Sub
End Class