Imports SI.PL.clsFuncion
Imports SI.UT
Imports SI.BC

Public Class liquidacion
    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    Public pstrCorrelativo As String
    Private pstrCorrelativoLiquidacion As String
    Private oLiquidacionTX As New clsBC_LiquidacionTX

    Private Sub liquidacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            pstrCorrelativoLiquidacion = Obtener_Correlativo("tbLiquidacion", "liquidacionID", "contratoloteid", pstrCorrelativo)
            txtCodigo.Text = pstrCorrelativoLiquidacion
            CargarParametros()
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub CargarParametros()
        Try
            Obtener_ParametrosCombo(cboDoc, clsUT_Dominio.domTABLA_DE_DOCUMENTOS, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    'Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    '    If MsgBox("Esta seguro de Generar la Liquidacion", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then
    '        Grabarliquidacion()
    '    End If

    'End Sub
    ' Private Function Grabarliquidacion()

    'With oLiquidacionTX.oBELiquidacion
    '    .contratoLoteId = pstrCorrelativo
    '    .liquidacionId = pstrCorrelativoLiquidacion
    '.porcentajeMerma = nupdMerma.Value
    '.pp = nupdPorcentaje.Value
    '.porcentajePago = nupdPorcPago.Value
    '.basepp = txtbasepart.Text
    '.base1 = txtbase1.Text
    '.base2 = txtbase2.Text
    '.escaladorMas1 = txtbasemas1.Text
    '.escaladorMas2 = txtbasemas2.Text
    '.escaladorMenos1 = txtbasemenos1.Text
    '.escaladorMenos2 = txtbasemenos2.Text
    '.maquila = txtMaquila.Text
    '.codigoIncoterm = cboIncoterm.SelectedValue
    '.codigoDeposito = cboDeposito.SelectedValue
    '.tasaInteres = txttasa.Text
    '.tasaTiempo = txttiempo.Text
    '.tasaMoratoria = txttasamora.Text
    '.codigoTasa = cboModo.SelectedValue
    '.
    'REVISAR
    '.codigoContacto = cboContacto.SelectedValue
    '.procedencia = txtprocedencia.Text
    '''''.cuota = dtCuota.Value
    ' .codigoEstado = TABLA_DE_ESTADOS.ACTIVO.Value
    '    .uc = pBEUsuario.tablaDetId
    '    .um = pBEUsuario.tablaDetId
    '    oLiquidacionTX.LstLiquidacion.Add(oLiquidacionTX.oBELiquidacion)
    'End With
    'If pblnNuevo Or pblnCopia Then
    '    Return oLiquidacionTX.InsertarLiquidacion
    'Else
    '    Return oLiquidacionTX.ModificarLiquidacion
    'End If
    ' End Function
End Class