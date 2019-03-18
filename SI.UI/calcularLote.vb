Imports SI.BC

Public Class calcularLote

    Public Property sTipoCalculo As String
    Private sTipo As String

    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    Private Sub calcularLote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            'If sTipoCalculo = "M" Then
            '    sTipo = "Mezclas"

            '    lblLote2.Visible = True
            '    lblLote2.Text = "Calculando Mezclas ..."
            '    pgbLote2.Visible = True

            'lblLote3.Visible = True
            'lblLote3.Text = "Calculando Vinculadas..."
            'pgbLote3.Visible = True

            'lblLote4.Visible = True
            'lblLote4.Text = "Calculando Mezclas ..."
            'pgbLote4.Visible = True

            'lblLote5.Visible = True
            'lblLote5.Text = "Calculando Lotes..."
            'pgbLote5.Visible = True

            'ElseIf sTipoCalculo = "V" Then
            '    sTipo = "Vinculada"

            '    lblLote2.Visible = True
            '    lblLote2.Text = "Calculando Vinculadas..."
            '    pgbLote2.Visible = True

            '    lblLote3.Visible = True
            '    lblLote3.Text = "Calculando Mezclas ..."
            '    pgbLote3.Visible = True

            '    lblLote4.Visible = True
            '    lblLote4.Text = "Calculando Vinculadas..."
            '    pgbLote4.Visible = True

            '    lblLote5.Visible = True
            '    lblLote5.Text = "Calculando Mezclas ..."
            '    pgbLote5.Visible = True

            '    lblLote6.Visible = True
            '    lblLote6.Text = "Calculando Lotes..."
            '    pgbLote6.Visible = True
            'End If

            lblLote2.Visible = True
            lblLote2.Text = "Calculando Mezclas ..."
            pgbLote2.Visible = True

            lblLote3.Visible = True
            lblLote3.Text = "Calculando Lotes..."
            pgbLote3.Visible = True

            lblLote4.Visible = True
            lblLote4.Text = "Calculando Mezclas ..."
            pgbLote4.Visible = True

            lblLote5.Visible = True
            lblLote5.Text = "Calculando Lotes..."
            pgbLote5.Visible = True


            gbt.Text = "Calcular " & sTipo
            tsmProcesar.ToolTipText = "Calcular " & sTipo
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub proceso()
        Try
            Dim loclsBC_LiquidacionRO As New clsBC_LiquidacionRO
            pgbLote1.Value = 50
            loclsBC_LiquidacionRO.fnCalculaLote()
            pgbLote1.Value = 100

            ''If sTipoCalculo = "M" Then
            ''    pgbLote2.Value = 60
            ''    loclsBC_LiquidacionRO.fnCalculaMezcla()
            ''    pgbLote2.Value = 100

            ''    pgbLote3.Value = 50
            ''    loclsBC_LiquidacionRO.fnCalculaVinculada()
            ''    pgbLote3.Value = 100

            ''    pgbLote4.Value = 40
            ''    loclsBC_LiquidacionRO.fnCalculaMezcla()
            ''    pgbLote4.Value = 100

            ''    pgbLote5.Value = 30
            ''    loclsBC_LiquidacionRO.fnCalculaLote()
            ''    pgbLote5.Value = 100

            ''ElseIf sTipoCalculo = "V" Then
            ''    pgbLote2.Value = 60
            ''    loclsBC_LiquidacionRO.fnCalculaVinculada()
            ''    pgbLote2.Value = 100

            ''    pgbLote3.Value = 50
            ''    loclsBC_LiquidacionRO.fnCalculaMezcla()
            ''    pgbLote3.Value = 100

            ''    pgbLote4.Value = 40
            ''    loclsBC_LiquidacionRO.fnCalculaVinculada()
            ''    pgbLote4.Value = 100

            ''    pgbLote5.Value = 30
            ''    loclsBC_LiquidacionRO.fnCalculaMezcla()
            ''    pgbLote5.Value = 100

            ''    pgbLote6.Value = 20
            ''    loclsBC_LiquidacionRO.fnCalculaLote()
            ''    pgbLote6.Value = 100
            ''End If


            pgbLote2.Value = 60
            loclsBC_LiquidacionRO.fnCalculaMezcla()
            pgbLote2.Value = 100

            pgbLote3.Value = 70
            loclsBC_LiquidacionRO.fnCalculaLote()
            pgbLote3.Value = 100

            pgbLote4.Value = 80
            loclsBC_LiquidacionRO.fnCalculaMezcla()
            pgbLote4.Value = 100

            pgbLote5.Value = 90
            loclsBC_LiquidacionRO.fnCalculaLote()
            pgbLote5.Value = 100

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub




    Private Sub tsmProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmProcesar.Click

        If MsgBox("Esta seguro de cargar " & sTipo, MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then
            proceso()

            lblMensaje.Visible = True
        End If
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Dispose()
    End Sub
End Class