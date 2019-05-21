Imports SI.UT
Imports SI.UT.clsUT_Enumerado
Imports SI.PL.clsProcedimientos
Imports SI.PL.clsFuncion
Imports SI.BC
Imports SI.BE
Imports System.Text
Public Class frmDocumentos

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

    Public sCodigoDocumento As String
    Public pstrEmpresa As String
    Public oTB_DIG_INDICE As clsBE_TB_DIG_INDICE

    Public bRetorna As Boolean = False

#End Region

#Region "Propiedades"

#End Region

#Region "Eventos de Formulario"

   

    Private Sub frmAyuda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'FormatearPantalla()
        'CargarDatos()
        'OrdenDatagridview(dgvMantenimiento, DataGridViewColumnSortMode.NotSortable)


        Obtener_ParametrosCombo(cboTipoDocumento, clsUT_Dominio.domTABLA_DE_DOCUMENTOS, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)

        If sCodigoDocumento = "0000000005" Then
            lblBeneficiario.Visible = True
            txtBENEFICIARIO.Visible = True
            txtBENEFICIARIO_ID.Visible = True

        End If
        If sCodigoDocumento = "0000000002" Then
            lblTipoDocumento.Visible = True
            cboTipoDocumento.Visible = True
        End If


        If sCodigoDocumento = "0000000006" Then
            'lblTipoDocumento.Visible = True
            'cboTipoDocumento.Visible = True
        End If


        If sCodigoDocumento = "0000000011" Then
            lblTipoDocumento.Visible = True
            cboTipoDocumento.Visible = True

            lblBeneficiario.Visible = True
            txtBENEFICIARIO.Visible = True
            txtBENEFICIARIO_ID.Visible = True

        End If

        dtpFECHA_DOC.Value = Now

    End Sub

#End Region

#Region "Eventos de Controles"
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

   

#End Region

#Region "Rutinas Locales"
   

#End Region


    'Private Sub gpoDetalle_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub

    'Private Sub tsbAdjuntar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAdjuntar.Click
    '    Dim sArchivoOrigen As String

    '    'valida tipo de documento
    '    If tsbCboTipoAdjunto.ComboBox.SelectedIndex = 0 Then
    '        MsgBox("Debe seleccionar el tipo de documento ha adjuntar", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
    '    Else

    '        If ofdAdjuntar.ShowDialog = DialogResult.OK Then
    '            sArchivoOrigen = ofdAdjuntar.FileName

    '            AgregarAdjunto(sArchivoOrigen)

    '            'tsbCboTipoAdjunto.ComboBox.SelectedIndex = 0
    '        End If

    '    End If
    'End Sub

    Private Sub tsbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAceptar.Click
        Dim sValidacion As String = obligatorios()

        If sValidacion = "" Then

            oTB_DIG_INDICE = New clsBE_TB_DIG_INDICE


            Dim nExtension As Integer = txtAdjunto.Text.LastIndexOf(".")
            Dim sExtension As String = txtAdjunto.Text.Substring(nExtension, txtAdjunto.Text.Length - nExtension)
            Dim sArchivo As String = txtNRO_DOC_EXTERNO.Text

            If cboTipoDocumento.SelectedIndex > 0 Then
                sArchivo = cboTipoDocumento.SelectedValue + "-" + sArchivo
            End If

            oTB_DIG_INDICE.ARCHIVO = sArchivo + sExtension
            'oTB_DIG_INDICE.EMPRESA = rowDIG_INDICERO.Cells("RUC_EMPRESA").Value
            'oTB_DIG_INDICE.IDTIPODOC_DIG = rowDIG_INDICERO.Cells("IDTIPODOC_DIG").Value
            'oTB_DIG_INDICE.PROVEEDOR = rowDIG_INDICERO.Cells("PROVEEDOR").Value
            'oTB_DIG_INDICE.CONTRATO = rowDIG_INDICERO.Cells("CONTRATO").Value.ToString
            'oTB_DIG_INDICE.LOTE = rowDIG_INDICERO.Cells("LOTE").Value.ToString
            'oTB_DIG_INDICE.NRO_DOC_INTERNO = rowDIG_INDICERO.Cells("NRO_DOC_INTERNO").Value.ToString
            oTB_DIG_INDICE.NRO_DOC_EXTERNO = sArchivo
            oTB_DIG_INDICE.FECHA_DOC = dtpFECHA_DOC.Value
            'oTB_DIG_INDICE.RUMA = rowDIG_INDICERO.Cells("RUMA").Value.ToString
            oTB_DIG_INDICE.BENEFICIARIO = txtBENEFICIARIO_ID.Text
            'oTB_DIG_INDICE.REFERENCIA1 = rowDIG_INDICERO.Cells("REFERENCIA1").Value.ToString
            oTB_DIG_INDICE.IDFLUJO = "VCM"
            'oTB_DIG_INDICE.CONTRATO_LIQ = rowDIG_INDICERO.Cells("CONTRATO_LIQ").Value
            'oTB_DIG_INDICE.LOTE_LIQ = rowDIG_INDICERO.Cells("LOTE_LIQ").Value
            'oTB_DIG_INDICE.LIQUIDACION = rowDIG_INDICERO.Cells("LIQUIDACION").Value

            'oTB_DIG_INDICE.ContratoLoteId = rowDIG_INDICERO.Cells("ContratoLoteId").Value
            'oTB_DIG_INDICE.LiquidacionId = rowDIG_INDICERO.Cells("LiquidacionId").Value
            oTB_DIG_INDICE.IDITEM_ORIGEN = 0
            oTB_DIG_INDICE.ESTADO = 2


            oTB_DIG_INDICE.RUTA_ORIGEN = txtAdjunto.Text

            bRetorna = True
            Me.Close()
        Else
            MsgBox(sValidacion, MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
        End If

    End Sub

    Private Sub tsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        Limpiar()
        Me.Dispose()
    End Sub


   

    Private Sub tsbAdjuntar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAdjuntar.Click

        If ofdAdjuntar.ShowDialog = DialogResult.OK Then
            'sArchivoOrigen = ofdAdjuntar.FileName
            'AgregarAdjunto(sArchivoOrigen)
            'tsbCboTipoAdjunto.ComboBox.SelectedIndex = 0

            txtAdjunto.Text = ofdAdjuntar.FileName

        End If

    End Sub

    Private Sub txtBENEFICIARIO_ID_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBENEFICIARIO_ID.Click
        obtenerBeneficiario()
    End Sub


    Private Sub obtenerBeneficiario()
        Dim parametro As New Hashtable

        oGeneral = New clsBC_GeneralRO
        parametro = New Hashtable
        oGeneral.LstGeneral.Clear()
        ''parametro.Add("beneficiario", txtEmpresa.Text)
        parametro.Add("empresa", pstrEmpresa)
        MostrarFormularioAyuda(EnumFormAyuda.Beneficiario, oGeneral, False, parametro)

        If oGeneral.oBEGeneral.NomCampo1 IsNot Nothing And oGeneral.oBEGeneral.NomCampo2 IsNot Nothing Then
            txtBENEFICIARIO_ID.Text = oGeneral.oBEGeneral.NomCampo1
            txtBENEFICIARIO.Text = oGeneral.oBEGeneral.NomCampo2            
        End If
    End Sub

    Private Sub tsbLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLimpiar.Click
        Limpiar()
    End Sub

    Private Sub Limpiar()
        txtBENEFICIARIO_ID.Text = ""
        txtBENEFICIARIO.Text = ""
        dtpFECHA_DOC.Text = Now
        txtNRO_DOC_EXTERNO.Text = ""

        txtAdjunto.Text = ""

        cboTipoDocumento.SelectedIndex = 0
    End Sub

    Private Function obligatorios() As String

        Dim sTexto As String = ""

        If cboTipoDocumento.Visible = True And cboTipoDocumento.SelectedIndex = 0 Then
            sTexto += "Debe seleccionar tipo de documento" + Chr(10)
        End If

        If txtNRO_DOC_EXTERNO.Visible = True And txtNRO_DOC_EXTERNO.Text = "" Then
            sTexto += "Debe ingresar Nro de documento " + Chr(10)
        End If

        If txtBENEFICIARIO_ID.Visible = True And txtBENEFICIARIO_ID.Text = "" Then
            sTexto += "Debe seleccionar Beneficiario " + Chr(10)
        End If

        If txtAdjunto.Text = "" Then
            sTexto += "Debe seleccionar archivo a adjuntar" + Chr(10)
        End If

        Return sTexto

    End Function

End Class