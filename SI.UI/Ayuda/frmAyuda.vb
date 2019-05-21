Imports SI.UT
Imports SI.UT.clsUT_Enumerado
Imports SI.PL.clsProcedimientos
Imports SI.PL.clsFuncion
Imports SI.BC
Imports System.Text
Public Class frmAyuda

#Region "Variables Privadas"
    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    Private oDvwAyuda As New DataView
    Private FontCourier As New Font("Courier New", 8.25)
    Private stylecodpartida As New DataGridViewCellStyle()
#End Region

#Region "Variables Publicas"
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
#End Region

#Region "Propiedades"

#End Region

#Region "Eventos de Formulario"

    Private Sub frmAyuda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btnAceptar_Click(sender, e)
            Case Keys.Down
                If dgvMantenimiento.Focused = False Then
                    dgvMantenimiento.Focus()
                    SendKeys.Send("{Down}")
                End If
        End Select

    End Sub

    Private Sub frmAyuda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        FormatearPantalla()
        CargarDatos()
        OrdenDatagridview(dgvMantenimiento, DataGridViewColumnSortMode.NotSortable)
    End Sub

#End Region

#Region "Eventos de Controles"
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If dgvMantenimiento.SelectedRows.Count > 0 Then
            RetornarRegistros()
        Else
            MsgBox("No se seleccionó ningun registro")
        End If
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        valida_caracterSQL(sender, e)
    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Try
            Dim vCadenaFiltro As String = ""
            Dim colFiltroCodigo As String = "codigo"
            Dim colFiltroDescripcion As String = "descripcion"

            'oDvwAyuda.RowFilter = ""

            pstrFiltro = ""
            Select Case pFormAyuda
                Case EnumFormAyuda.EstadoGeneral
                    Listar_Parametros(dgvMantenimiento, pstrDominio.ToString)
                Case EnumFormAyuda.Calidad
                    Listar_Parametros(dgvMantenimiento, clsUT_Dominio.domTABLA_DE_CALIDAD)
                Case EnumFormAyuda.Trader
                    Listar_Parametros(dgvMantenimiento, "TRADER")

                Case EnumFormAyuda.Administrador
                    Listar_Parametros(dgvMantenimiento, "administrador")

                Case EnumFormAyuda.Socio
                    'Listar_Parametros(dgvMantenimiento, clsUT_Dominio.domTABLA_DE_SOCIO, , "campo1")
                    Listar_ParametrosEN(dgvMantenimiento, clsUT_Dominio.domTABLA_DE_SOCIO, , "IDPERSONA")
                    colFiltroCodigo = "IDPERSONA"
                    'colFiltroCodigo = "ruc"
                    Me.Text = "Listado de " & pstrNomFormulario
                Case EnumFormAyuda.Empresa
                    Listar_Parametros(dgvMantenimiento, clsUT_Dominio.domTABLA_DE_EMPRESA)
                Case EnumFormAyuda.Contratos
                    'Listar_RegistrosContrato(dgvMantenimiento, "tbcontratolote", "contrato", "contratoLoteId", "contrato", "codigoTabla", "CON")
                    Listar_RegistrosContrato(dgvMantenimiento, "tbcontratolote", "contratoloteid", "dbo.uf_tabladet_desc ('Socio',codigoSocio)", "contrato", "codigoTabla", "CON", , , pstrFiltroMovimiento)
                    colFiltroCodigo = "id"


                Case EnumFormAyuda.VentaVinculada
                    colFiltroCodigo = "contratoLoteId"
                    colFiltroDescripcion = "LoteVenta"
                    Listar_ParametrosEN(dgvMantenimiento, clsUT_Dominio.domVentaVinculada, pParametros("contratoVinculada"), "Item")

                Case EnumFormAyuda.Adelanto
                    Listar_ParametrosEN(dgvMantenimiento, clsUT_Dominio.domFINANCIANDO_PRELIQ, , "Item")
                    'Listar_RegistrosContrato(dgvMantenimiento, "tbcontratolote", "contrato", "contratoLoteId", "contrato", "codigoTabla", "CON")
                    colFiltroCodigo = "Item"
                    colFiltroDescripcion = "NUM_COMPR_LIQ"

                Case EnumFormAyuda.OtrasCuentasXCobrar
                    Listar_ParametrosEN(dgvMantenimiento, clsUT_Dominio.domOTRAS_CUENTAS_X_COBRAR, , "Item")
                    'Listar_RegistrosContrato(dgvMantenimiento, "tbcontratolote", "contrato", "contratoLoteId", "contrato", "codigoTabla", "CON")
                    If cboFiltro.SelectedIndex = 1 Then
                        colFiltroCodigo = "Item"
                        colFiltroDescripcion = "NRO_DOC"
                    End If
                    If cboFiltro.SelectedIndex = 2 Then
                        colFiltroCodigo = "Monto"
                        colFiltroDescripcion = "Convert(SALDO,'System.String')"
                    End If
                Case EnumFormAyuda.PrestamosCChica
                    Listar_ParametrosEN(dgvMantenimiento, clsUT_Dominio.domPRESTAMOSCCHICA, , "Item")
                    'Listar_RegistrosContrato(dgvMantenimiento, "tbcontratolote", "contrato", "contratoLoteId", "contrato", "codigoTabla", "CON")
                    colFiltroCodigo = "Item"
                    colFiltroDescripcion = "NRO_DOC"
            End Select


            Select Case cboFiltro.SelectedIndex
                Case 0
                    pstrFiltro = Replace(txtBuscar.Text, "'", "''", 1, txtBuscar.Text.Length)
                    vCadenaFiltro = colFiltroCodigo & " like '%" & pstrFiltro & "%'"

                    If pFormAyuda = EnumFormAyuda.Contratos And pstrFiltroMovimiento = "P" Then
                        vCadenaFiltro = vCadenaFiltro & " AND codigoMovimiento IN ('" & pstrFiltroMovimiento & "')  and id not in ('PP302','PP001','PP002','PP003','PP004','PP005','PP006','PP007','PP010','PP031')"
                    End If
                Case 1
                    pstrFiltro = Replace(txtBuscar.Text, "'", "''", 1, txtBuscar.Text.Length)
                    vCadenaFiltro = colFiltroDescripcion & " like '%" & pstrFiltro & "%'"

                    If pFormAyuda = EnumFormAyuda.Contratos And pstrFiltroMovimiento = "P" Then
                        vCadenaFiltro = vCadenaFiltro & " AND codigoMovimiento IN ('" & pstrFiltroMovimiento & "')  and id not in ('PP302','PP001','PP002','PP003','PP004','PP005','PP006','PP007','PP010','PP031')"
                    End If
                Case 2
                    pstrFiltro = Replace(txtBuscar.Text, "'", "''", 1, txtBuscar.Text.Length)
                    vCadenaFiltro = colFiltroDescripcion & " like '" & pstrFiltro & "%'"

            End Select

            ''If pstrFiltroMovimiento <> "" Then
            ''    oDvwAyuda.RowFilter = vCadenaFiltro & " and id not in ('PP302','PP001','PP002','PP003','PP004','PP005','PP006','PP007','PP010','PP031') "
            ''Else
            ''    oDvwAyuda.RowFilter = vCadenaFiltro
            ''End If

            oDvwAyuda.RowFilter = vCadenaFiltro
            dgvMantenimiento.DataSource = oDvwAyuda
            dgvMantenimiento.Update()
            fxdAyuda.DataSource = oDvwAyuda

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try

    End Sub
    Private Sub dgvMantenimiento_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMantenimiento.CellDoubleClick
        If e.RowIndex <> "-1" Then
            If dgvMantenimiento.SelectedRows.Count = 1 Then
                RetornarRegistros()
            Else
                MsgBox("No se selecciono ningun registro")
            End If
        End If
    End Sub
    Private Sub cboFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFiltro.SelectedIndexChanged
        txtBuscar.Text = ""
    End Sub
#End Region

#Region "Rutinas Locales"
    Private Sub FormatearPantalla()
        dgvMantenimiento.MultiSelect = pblnMultiSelect
        dgvMantenimiento.Columns(0).HeaderText = pstrTituloCodigo
        dgvMantenimiento.Columns(1).HeaderText = pstrTituloDescripcion
        If CBool(pParametros("blnPartidas")) Then
            Dim pFont As New Font("Courier New", 8.25)
            dgvMantenimiento.Font = pFont
        End If
    End Sub
    Private Sub CargarDatos()
        Dim blnPersonalizado As Boolean = False
        Dim dgcStyle As DataGridViewCellStyle

        dgvMantenimiento.Columns(2).Visible = False
        fxdAyuda.Visible = False


        cboFiltro.Items.Clear()
        Select Case pFormAyuda
            Case EnumFormAyuda.EstadoGeneral
                cboFiltro.Items.Add("Código")
                cboFiltro.Items.Add("Descripción")
                Listar_Parametros(dgvMantenimiento, pstrDominio.ToString)
                Me.Text = "Listado " & pstrDominio.ToString
            Case EnumFormAyuda.Calidad
                cboFiltro.Items.Add("Código")
                cboFiltro.Items.Add("Descripción")
                Listar_Parametros(dgvMantenimiento, clsUT_Dominio.domTABLA_DE_CALIDAD)
                Me.Text = "Listado de Calidades"
            Case EnumFormAyuda.Trader
                cboFiltro.Items.Add("Código")
                cboFiltro.Items.Add("Descripción")
                Listar_Parametros(dgvMantenimiento, "Trader")
                Me.Text = "Listado de Trader"

            Case EnumFormAyuda.Administrador
                cboFiltro.Items.Add("Código")
                cboFiltro.Items.Add("Descripción")
                Listar_Parametros(dgvMantenimiento, "Administrador")
                Me.Text = "Listado de Administrador"

            Case EnumFormAyuda.Socio
                ''cboFiltro.Items.Add("RUC")
                ''cboFiltro.Items.Add("Descripción")
                ''Listar_Parametros(dgvMantenimiento, clsUT_Dominio.domTABLA_DE_SOCIO, , "campo1")
                cboFiltro.Items.Add("RUC")
                cboFiltro.Items.Add("Descripción")
                Listar_ParametrosEN(dgvMantenimiento, clsUT_Dominio.domTABLA_DE_SOCIO, , "IDPERSONA")
                ''Dim oBC_PUB_PERSONASRO As New clsBC_PUB_PERSONASRO
                ''oBC_PUB_PERSONASRO.LeerListaPUB_PERSONAS("AYUDA")
                ''dgvMantenimiento.AutoGenerateColumns = False
                ''dgvMantenimiento.DataSource = oBC_PUB_PERSONASRO.LstPUB_PERSONAS

                ''dgvMantenimiento.Columns.Item(0).DataPropertyName = "IDPERSONA"
                ''dgvMantenimiento.Columns.Item(1).DataPropertyName = "RAZON_SOCIAL"
                ' ''dgvMantenimiento.Columns.Item(2).DataPropertyName = "ID"
                ' ''dgvMantenimiento.Columns.Item(3).DataPropertyName = "ID"


                Me.Text = "Listado de " & pstrNomFormulario
            Case EnumFormAyuda.Empresa
                cboFiltro.Items.Add("Código")
                cboFiltro.Items.Add("Descripción")
                Listar_Parametros(dgvMantenimiento, clsUT_Dominio.domTABLA_DE_EMPRESA)
                Me.Text = "Listado de Empresa"
            Case EnumFormAyuda.Contratos
                cboFiltro.Items.Add("Código")
                cboFiltro.Items.Add("Descripción")
                'Listar_Registros(dgvMantenimiento, "tbcontratolote", "contratoLoteId", "codigoClase", "contrato", "codigoTabla", "CON")
                'Listar_Registros(dgvMantenimiento, "tbcontratolote", "contratoLoteId", "contrato", "contrato", "codigoTabla", "CON")
                'Listar_RegistrosContrato(dgvMantenimiento, "vcontratolote", "contrato", "contratoLoteId", "contrato", "", "")
                'Listar_RegistrosContrato(dgvMantenimiento, "vcontratolote", "contrato", "contratoLoteId", "contrato", "codigoTabla", "CON")
                Listar_RegistrosContrato(dgvMantenimiento, "tbcontratolote", "contratoloteid", "dbo.uf_tabladet_desc ('Socio',codigoSocio)", "contrato", "codigoTabla", "CON", , , pstrFiltroMovimiento)
                Me.Text = "Listado de Contratos"
                dgvMantenimiento.Columns(2).Visible = True




            Case EnumFormAyuda.VentaVinculada
                cboFiltro.Items.Add("Código")
                cboFiltro.Items.Add("Descripción")
                Me.Text = "Listado de Ventas"
                Listar_ParametrosEN(dgvMantenimiento, clsUT_Dominio.domVentaVinculada, , pParametros("contratoVinculada")) '"Item")

                'dgvMantenimiento.Columns(0).Visible = False
                dgvMantenimiento.Columns(2).Visible = True
                'dgvMantenimiento.Columns(4).Visible = True


            Case EnumFormAyuda.Adelanto
                cboFiltro.Items.Add("Item")
                cboFiltro.Items.Add("Nro Comprobante")

                Listar_ParametrosEN(dgvMantenimiento, clsUT_Dominio.domFINANCIANDO_PRELIQ, , "Item")
                Me.Text = "Listado de " & pstrNomFormulario

                'Item
                dgvMantenimiento.Columns(0).Width = 30

                'Monto
                dgcStyle = New DataGridViewCellStyle
                dgcStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgcStyle.Format = "N2"

                dgvMantenimiento.Columns(1).Width = 150
                dgvMantenimiento.Columns(1).DefaultCellStyle = dgcStyle 'DataGridViewCellStyle("{NullValue = 0, Format() = N2, Alignment = MiddleRight}")


                'Nro Comprobante
                dgvMantenimiento.Columns(2).Width = 150
                dgvMantenimiento.Columns(2).HeaderText = "Nro Comprobante"
                dgvMantenimiento.Columns(2).Visible = True

                dgcStyle = New DataGridViewCellStyle
                'dgcStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                'dgvMantenimiento.Columns(2).DefaultCellStyle = dgcStyle

                'Fecha registro
                dgcStyle = New DataGridViewCellStyle
                dgcStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                dgvMantenimiento.Columns(4).Width = 100
                dgvMantenimiento.Columns(4).HeaderText = "Fecha Registro"
                dgvMantenimiento.Columns(4).Visible = True
                dgvMantenimiento.Columns(4).DefaultCellStyle = dgcStyle






            Case EnumFormAyuda.Beneficiario
                cboFiltro.Items.Add("Codigo")
                cboFiltro.Items.Add("Beneficiario")

                Listar_ParametrosEN(dgvMantenimiento, clsUT_Dominio.domTB_BENEFICIARIO_CCHICA, , pParametros("empresa"))
                Me.Text = "Listado de " & pstrNomFormulario


            Case EnumFormAyuda.Anexo_Banco
                cboFiltro.Items.Add("Banco")
                cboFiltro.Items.Add("Cuenta")

                Listar_ParametrosEN(dgvMantenimiento, clsUT_Dominio.domANEXOS_BANCO, , , pParametros("empresa"), pParametros("anexo"))
                Me.Text = "Listado de " & pstrNomFormulario

                dgvMantenimiento.Columns(2).Visible = True
                'dgvMantenimiento.Columns(4).Visible = True

                dgvMantenimiento.Columns(0).Width = 100
                dgvMantenimiento.Columns(1).Width = 100

                dgvMantenimiento.Columns(0).HeaderText = "Banco"
                dgvMantenimiento.Columns(1).HeaderText = "Moneda"
                dgvMantenimiento.Columns(2).HeaderText = "Cuenta"

            Case EnumFormAyuda.OtrasCuentasXCobrar
                cboFiltro.Items.Add("Item")
                cboFiltro.Items.Add("Nro Comprobante")
                cboFiltro.Items.Add("Monto")

                Listar_ParametrosEN(dgvMantenimiento, clsUT_Dominio.domOTRAS_CUENTAS_X_COBRAR, , , pParametros("proveedor"))
                Me.Text = "Listado de " & pstrNomFormulario

                dgvMantenimiento.Columns(2).Visible = True
                dgvMantenimiento.Columns(3).Visible = True
                dgvMantenimiento.Columns(4).Visible = True
                dgvMantenimiento.Columns(5).Visible = True
                dgvMantenimiento.Columns(6).Visible = True
                dgvMantenimiento.Columns(8).Visible = True
                dgvMantenimiento.Columns(9).Visible = True
                dgvMantenimiento.Columns(10).Visible = False
                dgvMantenimiento.Columns(11).Visible = False
                '' dgvMantenimiento.Columns(12).Visible = True
                'dgvMantenimiento.Columns(7).Visible = True

                dgvMantenimiento.Columns(1).Width = 30
                dgvMantenimiento.Columns(2).Width = 80
                dgvMantenimiento.Columns(3).Width = 30
                dgvMantenimiento.Columns(4).Width = 80
                dgvMantenimiento.Columns(5).Width = 200
                dgvMantenimiento.Columns(8).Width = 50
                dgvMantenimiento.Columns(9).Width = 250

                dgvMantenimiento.Columns(0).HeaderText = "Empresa"
                dgvMantenimiento.Columns(1).HeaderText = "Td"
                dgvMantenimiento.Columns(2).HeaderText = "Doc"
                dgvMantenimiento.Columns(3).HeaderText = "Mon"
                dgvMantenimiento.Columns(4).HeaderText = "Saldo"
                dgvMantenimiento.Columns(5).HeaderText = "Observaciones"
                dgvMantenimiento.Columns(6).HeaderText = "Fecha Doc."
                dgvMantenimiento.Columns(8).HeaderText = "Contrato"
                dgvMantenimiento.Columns(9).HeaderText = "Calidad"

                dgvMantenimiento.Columns(10).HeaderText = "LINEA_CLI"
                dgvMantenimiento.Columns(11).HeaderText = "CUENTA_PROV"
                '' dgvMantenimiento.Columns(12).HeaderText = "Fecha Doc."
                ''cboFiltro.Items.Add("Item")
                ''cboFiltro.Items.Add("Nro Comprobante")

                ''Listar_ParametrosEN(dgvMantenimiento, clsUT_Dominio.domOTRAS_CUENTAS_X_COBRAR, , , pParametros("proveedor"))
                ''Me.Text = "Listado de " & pstrNomFormulario

                ''dgvMantenimiento.Columns(2).Visible = True
                ''dgvMantenimiento.Columns(3).Visible = True
                ''dgvMantenimiento.Columns(4).Visible = True
                ''dgvMantenimiento.Columns(5).Visible = True
                ''dgvMantenimiento.Columns(6).Visible = False

                ' ''dgvMantenimiento.Columns(7).Visible = True

                ''dgvMantenimiento.Columns(1).Width = 30
                ''dgvMantenimiento.Columns(2).Width = 80
                ''dgvMantenimiento.Columns(3).Width = 30
                ''dgvMantenimiento.Columns(4).Width = 80
                ''dgvMantenimiento.Columns(5).Width = 250

                ''dgvMantenimiento.Columns(0).HeaderText = "Empresa"
                ''dgvMantenimiento.Columns(1).HeaderText = "Td"
                ''dgvMantenimiento.Columns(2).HeaderText = "Doc"
                ''dgvMantenimiento.Columns(3).HeaderText = "Mon"
                ''dgvMantenimiento.Columns(4).HeaderText = "Saldo"
                ''dgvMantenimiento.Columns(5).HeaderText = "Observaciones"

            Case EnumFormAyuda.PrestamosCChica
                cboFiltro.Items.Add("Item")
                cboFiltro.Items.Add("Nro Comprobante")

                Me.Text = "Listado de " & pstrNomFormulario
                ' para el otro tipo de dataview
                fxdAyuda.Visible = True
                dgvMantenimiento.Visible = False
                Dim dvwRegistros As DataView
                Dim dsregistros As DataSet
                Dim oContratoRO As New clsBC_FINANCIANDO_CLIRO

                oContratoRO.oBEFINANCIANDO_CLI.proveedor = pParametros("proveedor")

                dsregistros = oContratoRO.LeerListaToDSPRESTAMO_CCH()
                dvwRegistros = New DataView(dsregistros.Tables(0))

                fxdAyuda.DataSource = dvwRegistros

                fxdAyuda.Cols(1).Width = 80
                fxdAyuda.Cols(2).Width = 50
                fxdAyuda.Cols(3).Width = 50
                fxdAyuda.Cols(4).Width = 50
                fxdAyuda.Cols(5).Width = 80
                fxdAyuda.Cols(6).Width = 250
                fxdAyuda.Cols(7).Width = 50
                fxdAyuda.Cols(8).Width = 250
                fxdAyuda.Cols(9).Width = 100
                fxdAyuda.Cols(10).Width = 50

                fxdAyuda.Cols(1).Caption = "Empresa"
                fxdAyuda.Cols(2).Caption = "Td"
                fxdAyuda.Cols(3).Caption = "Doc"
                fxdAyuda.Cols(4).Caption = "Mon"
                fxdAyuda.Cols(5).Caption = "Saldo"
                fxdAyuda.Cols(6).Caption = "Observaciones"
                fxdAyuda.Cols(7).Caption = "Contrato"
                fxdAyuda.Cols(8).Caption = "Calidad"
                fxdAyuda.Cols(9).Caption = "Fecha"
                fxdAyuda.Cols(10).Caption = "Ruc"

                fxdAyuda.Cols(11).Visible = False
                fxdAyuda.Cols(12).Visible = False
                fxdAyuda.Cols(13).Visible = False
                ' Fin para otro Dataview

            Case EnumFormAyuda.PrestamosComer
                cboFiltro.Items.Add("Item")
                cboFiltro.Items.Add("Nro Comprobante")
                dgvMantenimiento.Visible = True

                Listar_ParametrosEN(dgvMantenimiento, clsUT_Dominio.domPRESTAMOSCOMER, , , pParametros("proveedor"), pParametros("empresa"))
                Me.Text = "Listado de " & pstrNomFormulario
                ' para el otro tipo de dataview

                dgvMantenimiento.Columns(2).Visible = True
                dgvMantenimiento.Columns(3).Visible = True
                dgvMantenimiento.Columns(4).Visible = True
                dgvMantenimiento.Columns(5).Visible = True
                dgvMantenimiento.Columns(6).Visible = True
                dgvMantenimiento.Columns(7).Visible = True
                dgvMantenimiento.Columns(8).Visible = True

                dgvMantenimiento.Columns(0).Width = 80
                dgvMantenimiento.Columns(1).Width = 150
                dgvMantenimiento.Columns(2).Width = 150
                dgvMantenimiento.Columns(3).Width = 50
                dgvMantenimiento.Columns(4).Width = 150
                dgvMantenimiento.Columns(5).Width = 100
                dgvMantenimiento.Columns(6).Width = 100
                dgvMantenimiento.Columns(7).Width = 100
                dgvMantenimiento.Columns(8).Width = 80

                dgcStyle = New DataGridViewCellStyle
                dgcStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgcStyle.Format = "N2"

                dgvMantenimiento.Columns(4).DefaultCellStyle = dgcStyle 'DataGridViewCellStyle("{NullValue = 0, Format() = N2, Alignment = MiddleRight}")


                dgvMantenimiento.Columns(0).HeaderText = "Fecha"
                dgvMantenimiento.Columns(1).HeaderText = "Empresa"
                dgvMantenimiento.Columns(2).HeaderText = "Nro.Documento"
                dgvMantenimiento.Columns(3).HeaderText = "Moneda"
                dgvMantenimiento.Columns(4).HeaderText = "Saldo"
                dgvMantenimiento.Columns(5).HeaderText = "Tipo Egreso"
                dgvMantenimiento.Columns(6).HeaderText = "Descuento"
                dgvMantenimiento.Columns(7).HeaderText = "Prestamo"
                dgvMantenimiento.Columns(8).HeaderText = "Ruc Empresa"


        End Select



        cboFiltro.SelectedIndex = 1

        If blnPersonalizado Then
            oDvwAyuda = New DataView(dgvMantenimiento.DataSource)
        Else
            oDvwAyuda = dgvMantenimiento.DataSource
        End If

        lblReg.Text = "Registros : " & dgvMantenimiento.Rows.Count
    End Sub

    Private Sub RetornarRegistros()
        oGeneral.LstGeneral.Clear()
        For Each SelectedRow As DataGridViewRow In dgvMantenimiento.SelectedRows
            oGeneral.NuevaEntidad()
            With oGeneral.oBEGeneral
                .NomCampo1 = SelectedRow.DataGridView.Rows(SelectedRow.Index).Cells(0).Value
                .NomCampo2 = SelectedRow.DataGridView.Rows(SelectedRow.Index).Cells(1).Value
                .NomCampo3 = SelectedRow.DataGridView.Rows(SelectedRow.Index).Cells(2).Value
                .NomCampo4 = SelectedRow.DataGridView.Rows(SelectedRow.Index).Cells(3).Value
                .NomCampo5 = SelectedRow.DataGridView.Rows(SelectedRow.Index).Cells(4).Value
                .NomCampo6 = SelectedRow.DataGridView.Rows(SelectedRow.Index).Cells(5).Value

                .NomCampo7 = SelectedRow.DataGridView.Rows(SelectedRow.Index).Cells(6).Value

                If SelectedRow.DataGridView.Rows(SelectedRow.Index).Cells(7).Value Is Nothing Then
                    .NomCampo8 = ""
                ElseIf SelectedRow.DataGridView.Rows(SelectedRow.Index).Cells(7).Value.ToString = "" Then
                    .NomCampo8 = ""
                Else
                    .NomCampo8 = SelectedRow.DataGridView.Rows(SelectedRow.Index).Cells(7).Value
                End If

                If SelectedRow.DataGridView.Rows(SelectedRow.Index).Cells(8).Value Is Nothing Then
                    .ValCampo1 = ""
                ElseIf SelectedRow.DataGridView.Rows(SelectedRow.Index).Cells(8).Value.ToString = "" Then
                    .ValCampo1 = ""
                Else
                    .ValCampo1 = SelectedRow.DataGridView.Rows(SelectedRow.Index).Cells(8).Value
                End If



                If SelectedRow.DataGridView.Rows(SelectedRow.Index).Cells(10).Value Is Nothing Then
                    .NomCampo9 = ""
                ElseIf SelectedRow.DataGridView.Rows(SelectedRow.Index).Cells(10).Value.ToString = "" Then
                    .NomCampo9 = ""
                Else
                    .NomCampo9 = SelectedRow.DataGridView.Rows(SelectedRow.Index).Cells(10).Value
                End If

                If SelectedRow.DataGridView.Rows(SelectedRow.Index).Cells(11).Value Is Nothing Then
                    .NomCampo10 = ""
                ElseIf SelectedRow.DataGridView.Rows(SelectedRow.Index).Cells(11).Value.ToString = "" Then
                    .NomCampo10 = ""
                Else
                    .NomCampo10 = SelectedRow.DataGridView.Rows(SelectedRow.Index).Cells(11).Value
                End If

            End With
            oGeneral.LstGeneral.Add(oGeneral.oBEGeneral)
        Next
        Me.Close()
    End Sub

#End Region



    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            SaveFileDialog1.Filter = "Hojas de Excel|*.xls"
            SaveFileDialog1.ShowDialog()
            If SaveFileDialog1.FileName.Length > 0 Then
                fxdAyuda.SaveExcel(SaveFileDialog1.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try

    End Sub
End Class