Imports SI.UT
Imports SI.UT.clsUT_Enumerado
Imports SI.PL.clsProcedimientos
Imports SI.PL.clsFuncion
Imports SI.BC
Imports SI.BE
Imports System.Text
Public Class frmListaDocumentos

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

    Public pstrIDTIPODOC_DIG As String

    Public LstDIG_INDICE As New List(Of clsBE_TB_DIG_INDICE)


    Public sEMPRESA As String
    Public sPROVEEDOR As String


    Public sRuta_Parametro As String

    Public sRuta_Origen As String
    Public bRetorna As Boolean = False

    Public pContratoLoteId As String
    Public pLiquidacionId As String

#End Region

#Region "Propiedades"

#End Region

#Region "Eventos de Formulario"

    ''Private Sub frmAyuda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    ''    Select Case e.KeyCode
    ''        Case Keys.Enter
    ''            btnAceptar_Click(sender, e)
    ''        Case Keys.Down
    ''            If dgvMantenimiento.Focused = False Then
    ''                dgvMantenimiento.Focus()
    ''                SendKeys.Send("{Down}")
    ''            End If
    ''    End Select

    ''End Sub

    Private Sub frmAyuda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'FormatearPantalla()
        'CargarDatos()

        LstDIG_INDICE.Clear()

        obtenerRegistros()
    End Sub

    Private Sub obtenerRegistros()
        'Dim sIDTIPODOC_DIG As String = "fact"

        Dim oBC_TB_DIG_INDICERO As New clsBC_TB_DIG_INDICERO
        oBC_TB_DIG_INDICERO.LeerListaToDSTB_DIG_INDICE_Sel_ASO(pstrIDTIPODOC_DIG, sEMPRESA, sPROVEEDOR, pContratoLoteId, pLiquidacionId)
        dgvDIG_INDICERO.DataSource = oBC_TB_DIG_INDICERO.oDSTB_DIG_INDICE.Tables(0)


        lblReg.Text = "Registros : " & dgvDIG_INDICERO.Rows.Count
    End Sub

#End Region

#Region "Eventos de Controles"
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If dgvDIG_INDICERO.SelectedRows.Count > 0 Then
            RetornarRegistros()
        Else
            MsgBox("No se seleccionó ningun registro")
        End If
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        valida_caracterSQL(sender, e)
    End Sub
    ''Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
    ''    Try
    ''        Dim vCadenaFiltro As String = ""
    ''        Dim colFiltroCodigo As String = "codigo"
    ''        Dim colFiltroDescripcion As String = "descripcion"


    ''        pstrFiltro = ""
    ''        Select Case pFormAyuda
    ''            Case EnumFormAyuda.EstadoGeneral
    ''                Listar_Parametros(dgvMantenimiento, pstrDominio.ToString)
    ''            Case EnumFormAyuda.Calidad
    ''                Listar_Parametros(dgvMantenimiento, clsUT_Dominio.domTABLA_DE_CALIDAD)
    ''            Case EnumFormAyuda.Trader
    ''                Listar_Parametros(dgvMantenimiento, "TRADER")

    ''            Case EnumFormAyuda.Administrador
    ''                Listar_Parametros(dgvMantenimiento, "administrador")

    ''            Case EnumFormAyuda.Socio
    ''                'Listar_Parametros(dgvMantenimiento, clsUT_Dominio.domTABLA_DE_SOCIO, , "campo1")
    ''                Listar_ParametrosEN(dgvMantenimiento, clsUT_Dominio.domTABLA_DE_SOCIO, , "IDPERSONA")
    ''                colFiltroCodigo = "IDPERSONA"
    ''                'colFiltroCodigo = "ruc"
    ''                Me.Text = "Listado de " & pstrNomFormulario
    ''            Case EnumFormAyuda.Empresa
    ''                Listar_Parametros(dgvMantenimiento, clsUT_Dominio.domTABLA_DE_EMPRESA)
    ''            Case EnumFormAyuda.Contratos
    ''                Listar_RegistrosContrato(dgvMantenimiento, "tbcontratolote", "contrato", "contratoLoteId", "contrato", "codigoTabla", "CON")
    ''                colFiltroCodigo = "id"


    ''            Case EnumFormAyuda.VentaVinculada
    ''                colFiltroCodigo = "contratoLoteId"
    ''                colFiltroDescripcion = "LoteVenta"
    ''                Listar_ParametrosEN(dgvMantenimiento, clsUT_Dominio.domVentaVinculada, pParametros("contratoVinculada"), "Item")

    ''            Case EnumFormAyuda.Adelanto
    ''                Listar_ParametrosEN(dgvMantenimiento, clsUT_Dominio.domFINANCIANDO_PRELIQ, , "Item")
    ''                'Listar_RegistrosContrato(dgvMantenimiento, "tbcontratolote", "contrato", "contratoLoteId", "contrato", "codigoTabla", "CON")
    ''                colFiltroCodigo = "Item"
    ''                colFiltroDescripcion = "NUM_COMPR_LIQ"
    ''        End Select



    ''        Select Case cboFiltro.SelectedIndex
    ''            Case 0
    ''                pstrFiltro = Replace(txtBuscar.Text, "'", "''", 1, txtBuscar.Text.Length)
    ''                vCadenaFiltro = colFiltroCodigo & " like '%" & pstrFiltro & "%'"
    ''            Case 1
    ''                pstrFiltro = Replace(txtBuscar.Text, "'", "''", 1, txtBuscar.Text.Length)
    ''                vCadenaFiltro = colFiltroDescripcion & " like '%" & pstrFiltro & "%'"
    ''        End Select
    ''        oDvwAyuda.RowFilter = vCadenaFiltro
    ''        dgvMantenimiento.DataSource = oDvwAyuda
    ''        dgvMantenimiento.Update()
    ''    Catch ex As Exception
    ''        oMensajeError.txtMensaje.Text = ex.ToString()
    ''        oMensajeError.ShowDialog()
    ''    End Try

    ''End Sub
    Private Sub dgvMantenimiento_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If e.RowIndex <> "-1" Then
            If dgvDIG_INDICERO.SelectedRows.Count = 1 Then
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
    ''Private Sub FormatearPantalla()
    ''    dgvMantenimiento.MultiSelect = pblnMultiSelect
    ''    dgvMantenimiento.Columns(0).HeaderText = pstrTituloCodigo
    ''    dgvMantenimiento.Columns(1).HeaderText = pstrTituloDescripcion
    ''    If CBool(pParametros("blnPartidas")) Then
    ''        Dim pFont As New Font("Courier New", 8.25)
    ''        dgvMantenimiento.Font = pFont
    ''    End If
    ''End Sub
    ''Private Sub CargarDatos()
    ''    Dim blnPersonalizado As Boolean = False
    ''    Dim dgcStyle As DataGridViewCellStyle

    ''    dgvMantenimiento.Columns(2).Visible = False

    ''    cboFiltro.Items.Clear()
    ''    Select Case pFormAyuda
    ''        Case EnumFormAyuda.EstadoGeneral
    ''            cboFiltro.Items.Add("Código")
    ''            cboFiltro.Items.Add("Descripción")
    ''            Listar_Parametros(dgvMantenimiento, pstrDominio.ToString)
    ''            Me.Text = "Listado " & pstrDominio.ToString
    ''        Case EnumFormAyuda.Calidad
    ''            cboFiltro.Items.Add("Código")
    ''            cboFiltro.Items.Add("Descripción")
    ''            Listar_Parametros(dgvMantenimiento, clsUT_Dominio.domTABLA_DE_CALIDAD)
    ''            Me.Text = "Listado de Calidades"
    ''        Case EnumFormAyuda.Trader
    ''            cboFiltro.Items.Add("Código")
    ''            cboFiltro.Items.Add("Descripción")
    ''            Listar_Parametros(dgvMantenimiento, "Trader")
    ''            Me.Text = "Listado de Trader"

    ''        Case EnumFormAyuda.Administrador
    ''            cboFiltro.Items.Add("Código")
    ''            cboFiltro.Items.Add("Descripción")
    ''            Listar_Parametros(dgvMantenimiento, "Administrador")
    ''            Me.Text = "Listado de Administrador"

    ''        Case EnumFormAyuda.Socio
    ''            ''cboFiltro.Items.Add("RUC")
    ''            ''cboFiltro.Items.Add("Descripción")
    ''            ''Listar_Parametros(dgvMantenimiento, clsUT_Dominio.domTABLA_DE_SOCIO, , "campo1")
    ''            cboFiltro.Items.Add("RUC")
    ''            cboFiltro.Items.Add("Descripción")
    ''            Listar_ParametrosEN(dgvMantenimiento, clsUT_Dominio.domTABLA_DE_SOCIO, , "IDPERSONA")
    ''            ''Dim oBC_PUB_PERSONASRO As New clsBC_PUB_PERSONASRO
    ''            ''oBC_PUB_PERSONASRO.LeerListaPUB_PERSONAS("AYUDA")
    ''            ''dgvMantenimiento.AutoGenerateColumns = False
    ''            ''dgvMantenimiento.DataSource = oBC_PUB_PERSONASRO.LstPUB_PERSONAS

    ''            ''dgvMantenimiento.Columns.Item(0).DataPropertyName = "IDPERSONA"
    ''            ''dgvMantenimiento.Columns.Item(1).DataPropertyName = "RAZON_SOCIAL"
    ''            ' ''dgvMantenimiento.Columns.Item(2).DataPropertyName = "ID"
    ''            ' ''dgvMantenimiento.Columns.Item(3).DataPropertyName = "ID"


    ''            Me.Text = "Listado de " & pstrNomFormulario
    ''        Case EnumFormAyuda.Empresa
    ''            cboFiltro.Items.Add("Código")
    ''            cboFiltro.Items.Add("Descripción")
    ''            Listar_Parametros(dgvMantenimiento, clsUT_Dominio.domTABLA_DE_EMPRESA)
    ''            Me.Text = "Listado de Empresa"
    ''        Case EnumFormAyuda.Contratos
    ''            cboFiltro.Items.Add("Código")
    ''            cboFiltro.Items.Add("Descripción")
    ''            'Listar_Registros(dgvMantenimiento, "tbcontratolote", "contratoLoteId", "codigoClase", "contrato", "codigoTabla", "CON")
    ''            'Listar_Registros(dgvMantenimiento, "tbcontratolote", "contratoLoteId", "contrato", "contrato", "codigoTabla", "CON")
    ''            'Listar_RegistrosContrato(dgvMantenimiento, "vcontratolote", "contrato", "contratoLoteId", "contrato", "", "")
    ''            'Listar_RegistrosContrato(dgvMantenimiento, "vcontratolote", "contrato", "contratoLoteId", "contrato", "codigoTabla", "CON")
    ''            Listar_RegistrosContrato(dgvMantenimiento, "tbcontratolote", "contratoloteid", "dbo.uf_tabladet_desc ('Socio',codigoSocio)", "contrato", "codigoTabla", "CON", , , pstrFiltroMovimiento)
    ''            Me.Text = "Listado de Contratos"
    ''            dgvMantenimiento.Columns(2).Visible = True




    ''        Case EnumFormAyuda.VentaVinculada
    ''            cboFiltro.Items.Add("Código")
    ''            cboFiltro.Items.Add("Descripción")
    ''            Me.Text = "Listado de Ventas"
    ''            Listar_ParametrosEN(dgvMantenimiento, clsUT_Dominio.domVentaVinculada, , pParametros("contratoVinculada")) '"Item")

    ''            'dgvMantenimiento.Columns(0).Visible = False
    ''            dgvMantenimiento.Columns(2).Visible = True
    ''            'dgvMantenimiento.Columns(4).Visible = True


    ''        Case EnumFormAyuda.Adelanto
    ''            cboFiltro.Items.Add("Item")
    ''            cboFiltro.Items.Add("Nro Comprobante")

    ''            Listar_ParametrosEN(dgvMantenimiento, clsUT_Dominio.domFINANCIANDO_PRELIQ, , "Item")
    ''            Me.Text = "Listado de " & pstrNomFormulario

    ''            'Item
    ''            dgvMantenimiento.Columns(0).Width = 30

    ''            'Monto
    ''            dgcStyle = New DataGridViewCellStyle
    ''            dgcStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    ''            dgcStyle.Format = "N2"

    ''            dgvMantenimiento.Columns(1).Width = 150
    ''            dgvMantenimiento.Columns(1).DefaultCellStyle = dgcStyle 'DataGridViewCellStyle("{NullValue = 0, Format() = N2, Alignment = MiddleRight}")


    ''            'Nro Comprobante
    ''            dgvMantenimiento.Columns(2).Width = 150
    ''            dgvMantenimiento.Columns(2).HeaderText = "Nro Comprobante"
    ''            dgvMantenimiento.Columns(2).Visible = True

    ''            dgcStyle = New DataGridViewCellStyle
    ''            'dgcStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    ''            'dgvMantenimiento.Columns(2).DefaultCellStyle = dgcStyle

    ''            'Fecha registro
    ''            dgcStyle = New DataGridViewCellStyle
    ''            dgcStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    ''            dgvMantenimiento.Columns(4).Width = 100
    ''            dgvMantenimiento.Columns(4).HeaderText = "Fecha Registro"
    ''            dgvMantenimiento.Columns(4).Visible = True
    ''            dgvMantenimiento.Columns(4).DefaultCellStyle = dgcStyle






    ''        Case EnumFormAyuda.Beneficiario
    ''            cboFiltro.Items.Add("Codigo")
    ''            cboFiltro.Items.Add("Beneficiario")

    ''            Listar_ParametrosEN(dgvMantenimiento, clsUT_Dominio.domTB_BENEFICIARIO_CCHICA, , pParametros("empresa"))
    ''            Me.Text = "Listado de " & pstrNomFormulario


    ''        Case EnumFormAyuda.Anexo_Banco
    ''            cboFiltro.Items.Add("Banco")
    ''            cboFiltro.Items.Add("Cuenta")

    ''            Listar_ParametrosEN(dgvMantenimiento, clsUT_Dominio.domANEXOS_BANCO, , , pParametros("empresa"), pParametros("anexo"))
    ''            Me.Text = "Listado de " & pstrNomFormulario

    ''            dgvMantenimiento.Columns(2).Visible = True
    ''            'dgvMantenimiento.Columns(4).Visible = True

    ''            dgvMantenimiento.Columns(0).Width = 100
    ''            dgvMantenimiento.Columns(1).Width = 100

    ''            dgvMantenimiento.Columns(0).HeaderText = "Banco"
    ''            dgvMantenimiento.Columns(1).HeaderText = "Moneda"
    ''            dgvMantenimiento.Columns(2).HeaderText = "Cuenta"

    ''        Case EnumFormAyuda.OtrasCuentasXCobrar
    ''            cboFiltro.Items.Add("Item")
    ''            cboFiltro.Items.Add("Nro Comprobante")

    ''            Listar_ParametrosEN(dgvMantenimiento, clsUT_Dominio.domOTRAS_CUENTAS_X_COBRAR, , , pParametros("proveedor"))
    ''            Me.Text = "Listado de " & pstrNomFormulario

    ''            dgvMantenimiento.Columns(2).Visible = True
    ''            dgvMantenimiento.Columns(3).Visible = True
    ''            dgvMantenimiento.Columns(4).Visible = True
    ''            dgvMantenimiento.Columns(5).Visible = True
    ''            dgvMantenimiento.Columns(6).Visible = False

    ''            dgvMantenimiento.Columns(1).Width = 30
    ''            dgvMantenimiento.Columns(2).Width = 80
    ''            dgvMantenimiento.Columns(3).Width = 30
    ''            dgvMantenimiento.Columns(4).Width = 80
    ''            dgvMantenimiento.Columns(5).Width = 250

    ''            dgvMantenimiento.Columns(0).HeaderText = "Empresa"
    ''            dgvMantenimiento.Columns(1).HeaderText = "Td"
    ''            dgvMantenimiento.Columns(2).HeaderText = "Doc"
    ''            dgvMantenimiento.Columns(3).HeaderText = "Mon"
    ''            dgvMantenimiento.Columns(4).HeaderText = "Saldo"
    ''            dgvMantenimiento.Columns(5).HeaderText = "Observaciones"



    ''    End Select



    ''    cboFiltro.SelectedIndex = 1

    ''    If blnPersonalizado Then
    ''        oDvwAyuda = New DataView(dgvMantenimiento.DataSource)
    ''    Else
    ''        oDvwAyuda = dgvMantenimiento.DataSource
    ''    End If

    ''    lblReg.Text = "Registros : " & dgvMantenimiento.Rows.Count
    ''End Sub

    Private Sub RetornarRegistros()
        oGeneral.LstGeneral.Clear()

        LstDIG_INDICE.Clear()


        'Dim LstDIG_INDICE As New List(Of clsBE_TB_DIG_INDICE)
        Dim oTB_DIG_INDICE As clsBE_TB_DIG_INDICE


        For Each rowDIG_INDICERO As DataGridViewRow In dgvDIG_INDICERO.SelectedRows
            oTB_DIG_INDICE = New clsBE_TB_DIG_INDICE

            'oTB_DIG_INDICE.IDITEM = CInt(rowDIG_INDICERO.Cells("IDITEM").Value)
            oTB_DIG_INDICE.ARCHIVO = rowDIG_INDICERO.Cells("ARCHIVO").Value

            oTB_DIG_INDICE.EMPRESA = rowDIG_INDICERO.Cells("EMPRESA").Value
            oTB_DIG_INDICE.IDTIPODOC_DIG = rowDIG_INDICERO.Cells("IDTIPODOC_DIG").Value
            oTB_DIG_INDICE.PROVEEDOR = rowDIG_INDICERO.Cells("PROVEEDOR").Value
            oTB_DIG_INDICE.CONTRATO = rowDIG_INDICERO.Cells("CONTRATO").Value.ToString
            oTB_DIG_INDICE.LOTE = rowDIG_INDICERO.Cells("LOTE").Value.ToString
            oTB_DIG_INDICE.NRO_DOC_INTERNO = rowDIG_INDICERO.Cells("NRO_DOC_INTERNO").Value.ToString
            oTB_DIG_INDICE.NRO_DOC_EXTERNO = rowDIG_INDICERO.Cells("NRO_DOC_EXTERNO").Value.ToString
            'oTB_DIG_INDICE.FECHA_DOC = rowDIG_INDICERO.Cells("FECHA_DOC").Value

            If IsDBNull(rowDIG_INDICERO.Cells("FECHA_DOC").Value) Then
                oTB_DIG_INDICE.FECHA_DOC = "01/01/1990"
            Else
                oTB_DIG_INDICE.FECHA_DOC = rowDIG_INDICERO.Cells("FECHA_DOC").Value
            End If

            oTB_DIG_INDICE.RUMA = rowDIG_INDICERO.Cells("RUMA").Value.ToString
            oTB_DIG_INDICE.BENEFICIARIO = rowDIG_INDICERO.Cells("BENEFICIARIO").Value.ToString
            oTB_DIG_INDICE.REFERENCIA1 = rowDIG_INDICERO.Cells("REFERENCIA1").Value.ToString
            'oTB_DIG_INDICE.ARCHIVO = rowDIG_INDICERO.Cells("ARCHIVO").Value
            oTB_DIG_INDICE.IDFLUJO = "VCM"
            'oTB_DIG_INDICE.CONTRATO_LIQ = rowDIG_INDICERO.Cells("CONTRATO_LIQ").Value
            'oTB_DIG_INDICE.LOTE_LIQ = rowDIG_INDICERO.Cells("LOTE_LIQ").Value
            'oTB_DIG_INDICE.LIQUIDACION = rowDIG_INDICERO.Cells("LIQUIDACION").Value

            'oTB_DIG_INDICE.ContratoLoteId = rowDIG_INDICERO.Cells("ContratoLoteId").Value
            'oTB_DIG_INDICE.LiquidacionId = rowDIG_INDICERO.Cells("LiquidacionId").Value
            oTB_DIG_INDICE.IDITEM_ORIGEN = CInt(rowDIG_INDICERO.Cells("IDITEM").Value) 'rowDIG_INDICERO.Cells("IDITEM_ORIGEN").Value
            oTB_DIG_INDICE.ESTADO = 2

            'oTB_DIG_INDICE.RUTA = rowDIG_INDICERO.Cells("RUTA").Value
            'oTB_DIG_INDICE.RUTA_ORIGEN = sRuta_Origen + "\" + rowDIG_INDICERO.Cells("ARCHIVO").Value

            If rowDIG_INDICERO.Cells("IDFLUJO").Value.ToString.TrimEnd = "MLC" Then
                oTB_DIG_INDICE.RUTA_ORIGEN = sRuta_Parametro + "\" + rowDIG_INDICERO.Cells("RUTA").Value + rowDIG_INDICERO.Cells("ARCHIVO").Value
            Else
                oTB_DIG_INDICE.RUTA_ORIGEN = sRuta_Parametro + "\" + rowDIG_INDICERO.Cells("RUTA").Value + "\" + rowDIG_INDICERO.Cells("ARCHIVO").Value
            End If



            'rowDIG_INDICERO.Cells("EMPRESA").Value.ToString & _
            '                                     "/" & _
            '                                         rowDIG_INDICERO.Cells("PROVEEDOR").Value.ToString


            'oTB_DIG_INDICE.RUTA = rowDIG_INDICERO.Cells("RUC_EMPRESA").Value & _
            '                      "/" & _
            '                      rowDIG_INDICERO.Cells("PROVEEDOR").Value

            LstDIG_INDICE.Add(oTB_DIG_INDICE)
        Next


        ''For i = 0 To fgxDIG_INDICERO.Rows.Count - 1
        ''    If fgxDIG_INDICERO.Rows(i).Selected Then
        ''        oTB_DIG_INDICE = New clsBE_TB_DIG_INDICE

        ''        oTB_DIG_INDICE.IDITEM = CInt(fgxDIG_INDICERO.Rows(i)("IDITEM").ToString)
        ''        oTB_DIG_INDICE.ARCHIVO = fgxDIG_INDICERO.Rows(i)("ARCHIVO").ToString

        ''        oTB_DIG_INDICE.RUTA = fgxDIG_INDICERO.Rows(i)("EMPRESA").ToString & _
        ''                              "/" & _
        ''                              fgxDIG_INDICERO.Rows(i)("PROVEEDOR").ToString

        ''        LstDIG_INDICE.Add(oTB_DIG_INDICE)
        ''    End If
        ''Next

        bRetorna = True
        Me.Close()
    End Sub

#End Region


    Private Sub gpoDetalle_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gpoDetalle.Enter

    End Sub
End Class