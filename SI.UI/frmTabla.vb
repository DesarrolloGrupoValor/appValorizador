'Modified:
'@01 20141009 BAL01 Validacion para usuarios con permisos de modificar ValidacionCTB

Imports SI.BC
Imports SI.PL.clsFuncion
Imports SI.PL.clsProcedimientos
Imports SI.PL.clsEnumerado
Imports SI.PL.clsGeneral
Imports SI.UT
Imports System.Data
Imports System.Drawing.Drawing2D
Imports SI.BE

Public Class frmTabla
    Private oTablaDetRO As New clsBC_TablaDetRO
    Private dvwDatos As DataView
    Private lblnEditando As Boolean
    Private lblnNuevo As Boolean
    Private strTitulo1 As String
    Private strTitulo2 As String
    Private strTitulo3 As String
    Private strTitulo4 As String
    Private strTitulo5 As String
    Private strTitulo6 As String
    Private strTitulo7 As String
    Private strTitulo8 As String
    Private strTitulo9 As String
    Private strTitulo10 As String
    Private strTitulo11 As String
    Private strTitulo12 As String
    Private strTitulo13 As String
    Private strTitulo14 As String
    Private strTitulo15 As String
    Private strTitulo16 As String
    Private strTitulo17 As String
    Private strTitulo18 As String
    Private strTitulo19 As String
    Private strTitulo20 As String
    Private strTitulo21 As String
    Private strTitulo22 As String
    Private strTitulo23 As String
    Private strTitulo24 As String
    Private strTitulo25 As String
    Private strTitulo26 As String
    Private strTitulo27 As String
    Private strTitulo28 As String
    Private strTitulo29 As String
    Private strTitulo30 As String
    Private strTitulo31 As String
    Private strTitulo32 As String
    Private strTitulo33 As String
    Private strTitulo34 As String
    Private strTitulo35 As String
    Private strTitulo36 As String
    Private strTitulo37 As String
    Private strTitulo38 As String
    Private strTitulo39 As String
    Private strTitulo40 As String
    Private strTitulo41 As String
    Private strTitulo42 As String
    Private strTitulo43 As String
    Private strTitulo44 As String
    Private strTitulo45 As String
    Private strTitulo46 As String
    Private strTitulo47 As String
    Private strTitulo48 As String
    Private strTitulo49 As String
    Private strTitulo50 As String
    Private strTitulo51 As String

    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    Private Sub frmTabla_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        'Dim dsdatos As DataSet
        'Dim dvwDatos As DataView
        'dsdatos = oUsuarioRO.LeerListaToDSusuario
        'dvwDatos = New DataView(dsdatos.Tables(0))
        'tdbgMantenimiento.DataSource = dvwDatos
        Try
            ConfiguraForm(Me)

            CargarParametros()

            txt1.MaxLength = 200
            txt2.MaxLength = 200
            txt3.MaxLength = 200
            txt4.MaxLength = 200
            txt5.MaxLength = 200
            txt6.MaxLength = 200
            txt7.MaxLength = 200
            txt8.MaxLength = 200
            txt9.MaxLength = 200
            txt10.MaxLength = 200
            txt11.MaxLength = 200
            txt12.MaxLength = 200
            txt13.MaxLength = 200
            txt14.MaxLength = 200
            txt15.MaxLength = 200
            txt16.MaxLength = 200
            txt17.MaxLength = 200
            txt18.MaxLength = 200
            txt19.MaxLength = 200
            txt20.MaxLength = 200
            txt1.Width = 300
            txt2.Width = 300
            txt3.Width = 300
            txt4.Width = 300
            txt5.Width = 300
            txt6.Width = 300
            txt7.Width = 300
            txt8.Width = 300
            txt9.Width = 300
            txt10.Width = 300
            txt11.Width = 300
            txt12.Width = 300
            txt13.Width = 300
            txt14.Width = 300
            txt15.Width = 300
            txt16.Width = 300
            txt17.Width = 300
            txt18.Width = 300
            txt19.Width = 300
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub
    Private Sub CargarParametros()
        '@01    D01
        'Obtener_RegistrosCombo(cboTabla, "tbTabla", "tablaId", "descri", "tablaId", enumPrimerValorCombo.Seleccione, "codigoVisible", "True")

        '@01    AINI
        If Not oTablaDetRO.ValidarUsuarioToValidacionCTB(pBEUsuario.tablaDetId) Then
            Obtener_RegistrosComboToValidacionCTB(cboTabla, "tbTabla", "tablaId", "descri", "tablaId", enumPrimerValorCombo.Seleccione, "codigoVisible", "True")
        Else
            Obtener_RegistrosCombo(cboTabla, "tbTabla", "tablaId", "descri", "tablaId", enumPrimerValorCombo.Seleccione, "codigoVisible", "True")
        End If
        '01 AFIN
    End Sub

    Private Sub cboTabla_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTabla.SelectedIndexChanged
        Try
            If cboTabla.SelectedValue.GetType.Name = "String" Then
                oTablaDetRO.oBETablaDet.tablaId = cboTabla.SelectedValue
            Else
                oTablaDetRO.oBETablaDet.tablaId = CType(cboTabla.SelectedValue, SI.BE.clsBE_General).Id_Retorna
            End If
            'oTablaDetRO.oBETablaDet.tablaId = CType(cboTabla.SelectedValue, SI.BE.clsBE_General).Id_Retorna





            dvwDatos = New DataView(oTablaDetRO.LeerListaToDSTablaDet.Tables(0))


            ' ''SOLO DEBE VISUALIZARSE LOS PAGABLES
            If cboTabla.Text = "PrecioMercado" Or cboTabla.Text = "PrecioQP" Then
                'dvwDatos.RowFilter = "tablaDetId in ('CU','AG','AU','PB','ZN')"
                dvwDatos.Sort = "campo0 DESC"
            End If



            fxgrdMantenimiento.DataSource = dvwDatos
            ColumnasID(fxgrdMantenimiento)
            ColumnasCodigo(fxgrdMantenimiento)
            FormatearGrilla()

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case keyData
            Case Keys.Escape
                If Not lblnEditando Then
                    Me.Dispose()
                Else
                    btnCancelar_Click(Nothing, Nothing)
                End If
            Case Keys.Control + Keys.G
                If lblnEditando Then
                    btnGuardar_Click(Nothing, Nothing)
                End If
        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)

    End Function
    Private Sub FormatearGrilla()
        Try
            oTablaDetRO.oBETablaDet.tablaId = "Titulos"
            oTablaDetRO.oBETablaDet.tablaDetId = CType(cboTabla.SelectedItem, clsBE_General).Codigo_Retorna
            oTablaDetRO.LeerTablaDet()
            fxgrdMantenimiento.Cols("campo0").Visible = False
            fxgrdMantenimiento.Cols("campo1").Visible = False
            fxgrdMantenimiento.Cols("campo2").Visible = False
            fxgrdMantenimiento.Cols("campo3").Visible = False
            fxgrdMantenimiento.Cols("campo4").Visible = False
            fxgrdMantenimiento.Cols("campo5").Visible = False
            fxgrdMantenimiento.Cols("campo6").Visible = False
            fxgrdMantenimiento.Cols("campo7").Visible = False
            fxgrdMantenimiento.Cols("campo8").Visible = False
            fxgrdMantenimiento.Cols("campo9").Visible = False
            fxgrdMantenimiento.Cols("campo10").Visible = False
            fxgrdMantenimiento.Cols("campo11").Visible = False
            fxgrdMantenimiento.Cols("campo12").Visible = False
            fxgrdMantenimiento.Cols("campo13").Visible = False
            fxgrdMantenimiento.Cols("campo14").Visible = False
            fxgrdMantenimiento.Cols("campo15").Visible = False
            fxgrdMantenimiento.Cols("campo16").Visible = False
            fxgrdMantenimiento.Cols("campo17").Visible = False
            fxgrdMantenimiento.Cols("campo18").Visible = False
            fxgrdMantenimiento.Cols("campo19").Visible = False
            fxgrdMantenimiento.Cols("campo20").Visible = False
            fxgrdMantenimiento.Cols("campo21").Visible = False
            fxgrdMantenimiento.Cols("campo22").Visible = False
            fxgrdMantenimiento.Cols("campo23").Visible = False
            fxgrdMantenimiento.Cols("campo24").Visible = False
            fxgrdMantenimiento.Cols("campo25").Visible = False
            fxgrdMantenimiento.Cols("campo26").Visible = False
            fxgrdMantenimiento.Cols("campo27").Visible = False
            fxgrdMantenimiento.Cols("campo28").Visible = False
            fxgrdMantenimiento.Cols("campo29").Visible = False
            fxgrdMantenimiento.Cols("campo30").Visible = False
            fxgrdMantenimiento.Cols("campo31").Visible = False
            fxgrdMantenimiento.Cols("campo32").Visible = False
            fxgrdMantenimiento.Cols("campo33").Visible = False
            fxgrdMantenimiento.Cols("campo34").Visible = False
            fxgrdMantenimiento.Cols("campo35").Visible = False
            fxgrdMantenimiento.Cols("campo36").Visible = False
            fxgrdMantenimiento.Cols("campo37").Visible = False
            fxgrdMantenimiento.Cols("campo38").Visible = False
            fxgrdMantenimiento.Cols("campo39").Visible = False
            fxgrdMantenimiento.Cols("campo40").Visible = False
            fxgrdMantenimiento.Cols("campo41").Visible = False
            fxgrdMantenimiento.Cols("campo42").Visible = False
            fxgrdMantenimiento.Cols("campo43").Visible = False
            fxgrdMantenimiento.Cols("campo44").Visible = False
            fxgrdMantenimiento.Cols("campo45").Visible = False
            fxgrdMantenimiento.Cols("campo46").Visible = False
            fxgrdMantenimiento.Cols("campo47").Visible = False
            fxgrdMantenimiento.Cols("campo48").Visible = False
            fxgrdMantenimiento.Cols("campo49").Visible = False
            fxgrdMantenimiento.Cols("campo50").Visible = False
            fxgrdMantenimiento.Cols("campo51").Visible = False


            If oTablaDetRO.oBETablaDet.campo0 <> "" Then
                With oTablaDetRO.oBETablaDet
                    If .campo0 <> "" Then fxgrdMantenimiento.Cols("campo0").Visible = True : fxgrdMantenimiento.Cols("campo0").Caption = .campo0
                    If .campo1 <> "" Then fxgrdMantenimiento.Cols("campo1").Visible = True : fxgrdMantenimiento.Cols("campo1").Caption = .campo1
                    If .campo2 <> "" Then fxgrdMantenimiento.Cols("campo2").Visible = True : fxgrdMantenimiento.Cols("campo2").Caption = .campo2
                    If .campo3 <> "" Then fxgrdMantenimiento.Cols("campo3").Visible = True : fxgrdMantenimiento.Cols("campo3").Caption = .campo3
                    If .campo4 <> "" Then fxgrdMantenimiento.Cols("campo4").Visible = True : fxgrdMantenimiento.Cols("campo4").Caption = .campo4
                    If .campo5 <> "" Then fxgrdMantenimiento.Cols("campo5").Visible = True : fxgrdMantenimiento.Cols("campo5").Caption = .campo5
                    If .campo6 <> "" Then fxgrdMantenimiento.Cols("campo6").Visible = True : fxgrdMantenimiento.Cols("campo6").Caption = .campo6
                    If .campo7 <> "" Then fxgrdMantenimiento.Cols("campo7").Visible = True : fxgrdMantenimiento.Cols("campo7").Caption = .campo7
                    If .campo8 <> "" Then fxgrdMantenimiento.Cols("campo8").Visible = True : fxgrdMantenimiento.Cols("campo8").Caption = .campo8
                    If .campo9 <> "" Then fxgrdMantenimiento.Cols("campo9").Visible = True : fxgrdMantenimiento.Cols("campo9").Caption = .campo9
                    If .campo10 <> "" Then fxgrdMantenimiento.Cols("campo10").Visible = True : fxgrdMantenimiento.Cols("campo10").Caption = .campo10
                    If .campo11 <> "" Then fxgrdMantenimiento.Cols("campo11").Visible = True : fxgrdMantenimiento.Cols("campo11").Caption = .campo11
                    If .campo12 <> "" Then fxgrdMantenimiento.Cols("campo12").Visible = True : fxgrdMantenimiento.Cols("campo12").Caption = .campo12
                    If .campo13 <> "" Then fxgrdMantenimiento.Cols("campo13").Visible = True : fxgrdMantenimiento.Cols("campo13").Caption = .campo13
                    If .campo14 <> "" Then fxgrdMantenimiento.Cols("campo14").Visible = True : fxgrdMantenimiento.Cols("campo14").Caption = .campo14
                    If .campo15 <> "" Then fxgrdMantenimiento.Cols("campo15").Visible = True : fxgrdMantenimiento.Cols("campo15").Caption = .campo15
                    If .campo16 <> "" Then fxgrdMantenimiento.Cols("campo16").Visible = True : fxgrdMantenimiento.Cols("campo16").Caption = .campo16
                    If .campo17 <> "" Then fxgrdMantenimiento.Cols("campo17").Visible = True : fxgrdMantenimiento.Cols("campo17").Caption = .campo17
                    If .campo18 <> "" Then fxgrdMantenimiento.Cols("campo18").Visible = True : fxgrdMantenimiento.Cols("campo18").Caption = .campo18
                    If .campo19 <> "" Then fxgrdMantenimiento.Cols("campo19").Visible = True : fxgrdMantenimiento.Cols("campo19").Caption = .campo19
                    If .campo20 <> "" Then fxgrdMantenimiento.Cols("campo20").Visible = True : fxgrdMantenimiento.Cols("campo20").Caption = .campo20
                    If .campo21 <> "" Then fxgrdMantenimiento.Cols("campo21").Visible = True : fxgrdMantenimiento.Cols("campo21").Caption = .campo21
                    If .campo22 <> "" Then fxgrdMantenimiento.Cols("campo22").Visible = True : fxgrdMantenimiento.Cols("campo22").Caption = .campo22
                    If .campo23 <> "" Then fxgrdMantenimiento.Cols("campo23").Visible = True : fxgrdMantenimiento.Cols("campo23").Caption = .campo23
                    If .campo24 <> "" Then fxgrdMantenimiento.Cols("campo24").Visible = True : fxgrdMantenimiento.Cols("campo24").Caption = .campo24
                    If .campo25 <> "" Then fxgrdMantenimiento.Cols("campo25").Visible = True : fxgrdMantenimiento.Cols("campo25").Caption = .campo25
                    If .campo26 <> "" Then fxgrdMantenimiento.Cols("campo26").Visible = True : fxgrdMantenimiento.Cols("campo26").Caption = .campo26
                    If .campo27 <> "" Then fxgrdMantenimiento.Cols("campo27").Visible = True : fxgrdMantenimiento.Cols("campo27").Caption = .campo27
                    If .campo28 <> "" Then fxgrdMantenimiento.Cols("campo28").Visible = True : fxgrdMantenimiento.Cols("campo28").Caption = .campo28
                    If .campo29 <> "" Then fxgrdMantenimiento.Cols("campo29").Visible = True : fxgrdMantenimiento.Cols("campo29").Caption = .campo29
                    If .campo30 <> "" Then fxgrdMantenimiento.Cols("campo30").Visible = True : fxgrdMantenimiento.Cols("campo30").Caption = .campo30
                    If .campo31 <> "" Then fxgrdMantenimiento.Cols("campo31").Visible = True : fxgrdMantenimiento.Cols("campo31").Caption = .campo31
                    If .campo32 <> "" Then fxgrdMantenimiento.Cols("campo32").Visible = True : fxgrdMantenimiento.Cols("campo32").Caption = .campo32
                    If .campo33 <> "" Then fxgrdMantenimiento.Cols("campo33").Visible = True : fxgrdMantenimiento.Cols("campo33").Caption = .campo33
                    If .campo34 <> "" Then fxgrdMantenimiento.Cols("campo34").Visible = True : fxgrdMantenimiento.Cols("campo34").Caption = .campo34
                    If .campo35 <> "" Then fxgrdMantenimiento.Cols("campo35").Visible = True : fxgrdMantenimiento.Cols("campo35").Caption = .campo35
                    If .campo36 <> "" Then fxgrdMantenimiento.Cols("campo36").Visible = True : fxgrdMantenimiento.Cols("campo36").Caption = .campo36
                    If .campo37 <> "" Then fxgrdMantenimiento.Cols("campo37").Visible = True : fxgrdMantenimiento.Cols("campo37").Caption = .campo37
                    If .campo38 <> "" Then fxgrdMantenimiento.Cols("campo38").Visible = True : fxgrdMantenimiento.Cols("campo38").Caption = .campo38
                    If .campo39 <> "" Then fxgrdMantenimiento.Cols("campo39").Visible = True : fxgrdMantenimiento.Cols("campo39").Caption = .campo39
                    If .campo40 <> "" Then fxgrdMantenimiento.Cols("campo40").Visible = True : fxgrdMantenimiento.Cols("campo40").Caption = .campo40
                    If .campo41 <> "" Then fxgrdMantenimiento.Cols("campo41").Visible = True : fxgrdMantenimiento.Cols("campo41").Caption = .campo41
                    If .campo42 <> "" Then fxgrdMantenimiento.Cols("campo42").Visible = True : fxgrdMantenimiento.Cols("campo42").Caption = .campo42
                    If .campo43 <> "" Then fxgrdMantenimiento.Cols("campo43").Visible = True : fxgrdMantenimiento.Cols("campo43").Caption = .campo43
                    If .campo44 <> "" Then fxgrdMantenimiento.Cols("campo44").Visible = True : fxgrdMantenimiento.Cols("campo44").Caption = .campo44
                    If .campo45 <> "" Then fxgrdMantenimiento.Cols("campo45").Visible = True : fxgrdMantenimiento.Cols("campo45").Caption = .campo45
                    If .campo46 <> "" Then fxgrdMantenimiento.Cols("campo46").Visible = True : fxgrdMantenimiento.Cols("campo46").Caption = .campo46
                    If .campo47 <> "" Then fxgrdMantenimiento.Cols("campo47").Visible = True : fxgrdMantenimiento.Cols("campo47").Caption = .campo47
                    If .campo48 <> "" Then fxgrdMantenimiento.Cols("campo48").Visible = True : fxgrdMantenimiento.Cols("campo48").Caption = .campo48
                    If .campo49 <> "" Then fxgrdMantenimiento.Cols("campo49").Visible = True : fxgrdMantenimiento.Cols("campo49").Caption = .campo49
                    If .campo50 <> "" Then fxgrdMantenimiento.Cols("campo50").Visible = True : fxgrdMantenimiento.Cols("campo50").Caption = .campo50
                    If .campo51 <> "" Then fxgrdMantenimiento.Cols("campo51").Visible = True : fxgrdMantenimiento.Cols("campo51").Caption = .campo51


                End With


            End If
            ResizeWidthFlexGrid()
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Private Sub ResizeWidthFlexGrid()
        Try
            fxgrdMantenimiento.Cols("descri").Caption = "Descripción"
            fxgrdMantenimiento.Cols("descri").Width = 200
            If cboTabla.SelectedIndex > 0 Then
                Select Case (cboTabla.SelectedValue)
                    Case "Clase"
                        'fxgrdMantenimiento.Cols("descri").Width = 150
                        fxgrdMantenimiento.Cols("campo0").Width = 80
                    Case "Deposito"
                        fxgrdMantenimiento.Cols("campo0").Width = 80
                    Case "Empresa"
                        'fxgrdMantenimiento.Cols("descri").Width = 150
                        fxgrdMantenimiento.Cols("campo0").Width = 300
                        fxgrdMantenimiento.Cols("campo1").Width = 80
                        fxgrdMantenimiento.Cols("campo2").Width = 80
                        fxgrdMantenimiento.Cols("campo3").Width = 300
                        fxgrdMantenimiento.Cols("campo4").Width = 100
                        fxgrdMantenimiento.Cols("campo5").Width = 80
                        fxgrdMantenimiento.Cols("campo6").Width = 80
                        fxgrdMantenimiento.Cols("campo6").Caption = "Ini. Operación"
                    Case "Metal"
                        fxgrdMantenimiento.Cols("descri").Width = 100
                        fxgrdMantenimiento.Cols("campo0").Width = 70
                        fxgrdMantenimiento.Cols("campo1").Width = 70
                        fxgrdMantenimiento.Cols("campo2").Width = 70
                        fxgrdMantenimiento.Cols("campo3").Width = 70
                        fxgrdMantenimiento.Cols("campo4").Width = 70
                        fxgrdMantenimiento.Cols("campo5").Width = 70
                        fxgrdMantenimiento.Cols("campo6").Width = 70
                        fxgrdMantenimiento.Cols("campo7").Width = 70
                        fxgrdMantenimiento.Cols("campo8").Width = 70
                        fxgrdMantenimiento.Cols("campo9").Width = 70
                        fxgrdMantenimiento.Cols("campo10").Width = 70
                        fxgrdMantenimiento.Cols("campo11").Width = 70
                        fxgrdMantenimiento.Cols("campo12").Width = 70
                        fxgrdMantenimiento.Cols("campo13").Width = 70
                        fxgrdMantenimiento.Cols("campo14").Width = 70
                        fxgrdMantenimiento.Cols("campo15").Width = 70
                        fxgrdMantenimiento.Cols("campo16").Width = 70
                        fxgrdMantenimiento.Cols("campo17").Width = 70
                        fxgrdMantenimiento.Cols("campo18").Width = 70
                        fxgrdMantenimiento.Cols("campo19").Width = 70
                        fxgrdMantenimiento.Cols("campo20").Width = 70

                        fxgrdMantenimiento.Cols("campo4").TextAlign = 7
                        fxgrdMantenimiento.Cols("campo6").TextAlign = 7
                        fxgrdMantenimiento.Cols("campo7").TextAlign = 7
                        fxgrdMantenimiento.Cols("campo8").TextAlign = 7
                        fxgrdMantenimiento.Cols("campo9").TextAlign = 7
                        fxgrdMantenimiento.Cols("campo4").TextAlign = 7
                        fxgrdMantenimiento.Cols("campo10").TextAlign = 7
                        fxgrdMantenimiento.Cols("campo12").TextAlign = 7
                        fxgrdMantenimiento.Cols("campo17").TextAlign = 7
                        fxgrdMantenimiento.Cols("campo18").TextAlign = 7
                        fxgrdMantenimiento.Cols("campo19").TextAlign = 7
                        fxgrdMantenimiento.Cols("campo20").TextAlign = 7

                    Case "PrecioMaestro"
                        fxgrdMantenimiento.Cols("campo0").Width = 70

                        fxgrdMantenimiento.Cols("campo0").TextAlign = 7

                    Case "PrecioMercado", "PrecioQP"
                        fxgrdMantenimiento.Cols("campo1").Width = 70
                        fxgrdMantenimiento.Cols("campo2").Width = 70
                        fxgrdMantenimiento.Cols("campo3").Width = 70
                        fxgrdMantenimiento.Cols("campo4").Width = 70
                        fxgrdMantenimiento.Cols("campo5").Width = 70

                        fxgrdMantenimiento.Cols("campo1").TextAlign = 7
                        fxgrdMantenimiento.Cols("campo2").TextAlign = 7
                        fxgrdMantenimiento.Cols("campo3").TextAlign = 7
                        fxgrdMantenimiento.Cols("campo4").TextAlign = 7
                        fxgrdMantenimiento.Cols("campo5").TextAlign = 7

                    Case "Socio"
                        fxgrdMantenimiento.Cols("descri").Width = 300
                        fxgrdMantenimiento.Cols("campo0").Width = 300
                        fxgrdMantenimiento.Cols("campo1").Width = 80
                        fxgrdMantenimiento.Cols("campo2").Width = 300
                        fxgrdMantenimiento.Cols("campo3").Width = 450
                        fxgrdMantenimiento.Cols("campo4").Width = 150
                        fxgrdMantenimiento.Cols("campo5").Width = 200
                End Select
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try

    End Sub


    Private Sub EditandoRegistro()
        Try

            txtDescripcion.Enabled = True
            txt1.Enabled = True
            txt2.Enabled = True

            lblnEditando = Not lblnEditando
            tsMantenimiento.Enabled = Not lblnEditando
            msMantenimiento.Enabled = Not lblnEditando
            tbcEditar.Visible = lblnEditando
            gpoTabla.Enabled = Not lblnEditando
            fxgrdMantenimiento.Enabled = Not lblnEditando
            oTablaDetRO.oBETablaDet.tablaId = "Titulos"
            oTablaDetRO.oBETablaDet.tablaDetId = cboTabla.SelectedValue
            oTablaDetRO.LeerTablaDet()
            lbl1.Visible = False : txt1.Visible = False
            lbl2.Visible = False : txt2.Visible = False
            lbl3.Visible = False : txt3.Visible = False
            lbl4.Visible = False : txt4.Visible = False
            lbl5.Visible = False : txt5.Visible = False
            lbl6.Visible = False : txt6.Visible = False
            lbl7.Visible = False : txt7.Visible = False
            lbl8.Visible = False : txt8.Visible = False
            lbl9.Visible = False : txt9.Visible = False
            lbl10.Visible = False : txt10.Visible = False
            lbl11.Visible = False : txt11.Visible = False
            lbl12.Visible = False : txt12.Visible = False
            lbl13.Visible = False : txt13.Visible = False
            lbl14.Visible = False : txt14.Visible = False
            lbl15.Visible = False : txt15.Visible = False
            lbl16.Visible = False : txt16.Visible = False
            lbl17.Visible = False : txt17.Visible = False
            lbl18.Visible = False : txt18.Visible = False
            lbl19.Visible = False : txt19.Visible = False
            lbl20.Visible = False : txt20.Visible = False
            lbl21.Visible = False : txt21.Visible = False
            lbl22.Visible = False : Txt22.Visible = False
            lbl23.Visible = False : txt23.Visible = False
            lbl24.Visible = False : Txt24.Visible = False
            lbl25.Visible = False : Txt25.Visible = False
            lbl26.Visible = False : Txt26.Visible = False
            Lbl27.Visible = False : Txt27.Visible = False
            Lbl28.Visible = False : txt28.Visible = False
            lbl29.Visible = False : Txt29.Visible = False
            Lbl30.Visible = False : Txt30.Visible = False
            Lbl31.Visible = False : Txt31.Visible = False
            lbl32.Visible = False : Txt32.Visible = False
            Lbl33.Visible = False : Txt33.Visible = False
            Lbl34.Visible = False : txt34.Visible = False
            Lbl35.Visible = False : txt35.Visible = False
            lbl36.Visible = False : Txt36.Visible = False
            lbl37.Visible = False : txt37.Visible = False
            lbl38.Visible = False : txt38.Visible = False
            lbl39.Visible = False : txt39.Visible = False
            lbl40.Visible = False : txt40.Visible = False
            lbl41.Visible = False : Txt41.Visible = False
            lbl42.Visible = False : txt42.Visible = False
            lbl43.Visible = False : txt43.Visible = False
            lbl44.Visible = False : txt44.Visible = False
            lbl45.Visible = False : txt45.Visible = False
            lbl46.Visible = False : txt46.Visible = False
            lbl47.Visible = False : txt47.Visible = False
            lbl48.Visible = False : txt48.Visible = False
            lbl49.Visible = False : Txt49.Visible = False
            lbl50.Visible = False : Txt50.Visible = False
            lbl51.Visible = False : txt51.Visible = False
            lblPen.Visible = False

            txt2.PasswordChar = ""
            If oTablaDetRO.oBETablaDet.campo0 <> "" Then
                With oTablaDetRO.oBETablaDet
                    If .campo0 <> "" Then lbl1.Text = .campo0 : fxgrdMantenimiento.Cols("campo0").Visible = True : lbl1.Visible = True : txt1.Visible = True : strTitulo1 = .campo0
                    If .campo1 <> "" Then lbl2.Text = .campo1 : lbl2.Visible = True : txt2.Visible = True : strTitulo2 = .campo1
                    If cboTabla.SelectedValue = "Usuario" Then txt2.PasswordChar = "*"
                    If .campo2 <> "" Then lbl3.Text = .campo2 : lbl3.Visible = True : txt3.Visible = True : strTitulo3 = .campo2
                    If .campo3 <> "" Then lbl4.Text = .campo3 : lbl4.Visible = True : txt4.Visible = True : strTitulo4 = .campo3
                    If .campo4 <> "" Then lbl5.Text = .campo4 : lbl5.Visible = True : txt5.Visible = True : strTitulo5 = .campo4
                    If .campo5 <> "" Then lbl6.Text = .campo5 : lbl6.Visible = True : txt6.Visible = True : strTitulo6 = .campo5
                    If .campo6 <> "" Then lbl7.Text = .campo6 : lbl7.Visible = True : txt7.Visible = True : strTitulo7 = .campo6
                    If .campo7 <> "" Then lbl8.Text = .campo7 : lbl8.Visible = True : txt8.Visible = True : strTitulo8 = .campo7
                    If .campo8 <> "" Then lbl9.Text = .campo8 : lbl9.Visible = True : txt9.Visible = True : strTitulo9 = .campo8
                    If .campo9 <> "" Then lbl10.Text = .campo9 : lbl10.Visible = True : txt10.Visible = True : strTitulo10 = .campo9
                    If .campo10 <> "" Then lbl11.Text = .campo10 : lbl11.Visible = True : txt11.Visible = True : strTitulo11 = .campo10
                    If .campo11 <> "" Then lbl12.Text = .campo11 : lbl12.Visible = True : txt12.Visible = True : strTitulo12 = .campo11
                    If .campo12 <> "" Then lbl13.Text = .campo12 : lbl13.Visible = True : txt13.Visible = True : strTitulo13 = .campo12
                    If .campo13 <> "" Then lbl14.Text = .campo13 : lbl14.Visible = True : txt14.Visible = True : strTitulo14 = .campo13
                    If .campo14 <> "" Then lbl15.Text = .campo14 : lbl15.Visible = True : txt15.Visible = True : strTitulo15 = .campo14
                    If .campo15 <> "" Then lbl16.Text = .campo15 : lbl16.Visible = True : txt16.Visible = True : strTitulo16 = .campo15
                    If .campo16 <> "" Then lbl17.Text = .campo16 : lbl17.Visible = True : txt17.Visible = True : strTitulo17 = .campo16
                    If .campo17 <> "" Then lbl18.Text = .campo17 : lbl18.Visible = True : txt18.Visible = True : strTitulo18 = .campo17
                    If .campo18 <> "" Then lbl19.Text = .campo18 : lbl19.Visible = True : txt19.Visible = True : strTitulo19 = .campo18
                    If .campo19 <> "" Then lbl20.Text = .campo19 : lbl20.Visible = True : txt20.Visible = True : strTitulo20 = .campo19
                    If .campo21 <> "" Then lbl21.Text = .campo21 : lbl21.Visible = True : txt21.Visible = True : strTitulo21 = .campo21
                    If .campo22 <> "" Then lbl22.Text = .campo22 : lbl22.Visible = True : Txt22.Visible = True : strTitulo22 = .campo22 : lblEsc.Visible = True : lblEsc.Text = "Escaladores"
                    If .campo23 <> "" Then lbl23.Text = .campo23 : lbl23.Visible = True : txt23.Visible = True : strTitulo23 = .campo23
                    If .campo24 <> "" Then lbl24.Text = .campo24 : lbl24.Visible = True : Txt24.Visible = True : strTitulo24 = .campo24
                    If .campo25 <> "" Then lbl25.Text = .campo25 : lbl25.Visible = True : Txt25.Visible = True : strTitulo25 = .campo25
                    If .campo26 <> "" Then lbl26.Text = .campo26 : lbl26.Visible = True : Txt26.Visible = True : strTitulo26 = .campo26
                    If .campo27 <> "" Then Lbl27.Text = .campo27 : Lbl27.Visible = True : Txt27.Visible = True : strTitulo27 = .campo27
                    If .campo28 <> "" Then Lbl28.Text = .campo28 : Lbl28.Visible = True : txt28.Visible = True : strTitulo28 = .campo28 : lblPen.Visible = True : lblPen.Text = "Penalidades"
                    If .campo29 <> "" Then lbl29.Text = .campo29 : lbl29.Visible = True : Txt29.Visible = True : strTitulo29 = .campo29
                    If .campo30 <> "" Then Lbl30.Text = .campo30 : Lbl30.Visible = True : Txt30.Visible = True : strTitulo30 = .campo30
                    If .campo31 <> "" Then Lbl31.Text = .campo31 : Lbl31.Visible = True : Txt31.Visible = True : strTitulo31 = .campo31
                    If .campo32 <> "" Then lbl32.Text = .campo32 : lbl32.Visible = True : Txt32.Visible = True : strTitulo32 = .campo32
                    If .campo33 <> "" Then Lbl33.Text = .campo33 : Lbl33.Visible = True : Txt33.Visible = True : strTitulo33 = .campo33
                    If .campo34 <> "" Then Lbl34.Text = .campo34 : Lbl34.Visible = True : txt34.Visible = True : strTitulo34 = .campo34
                    If .campo35 <> "" Then Lbl35.Text = .campo35 : Lbl35.Visible = True : txt35.Visible = True : strTitulo35 = .campo35
                    If .campo36 <> "" Then lbl36.Text = .campo36 : lbl36.Visible = True : Txt36.Visible = True : strTitulo36 = .campo36
                    If .campo37 <> "" Then lbl37.Text = .campo37 : lbl37.Visible = True : txt37.Visible = True : strTitulo37 = .campo37
                    If .campo38 <> "" Then lbl38.Text = .campo38 : lbl38.Visible = True : txt38.Visible = True : strTitulo38 = .campo38
                    If .campo39 <> "" Then lbl39.Text = .campo39 : lbl39.Visible = True : txt39.Visible = True : strTitulo39 = .campo39
                    If .campo40 <> "" Then lbl40.Text = .campo40 : lbl40.Visible = True : txt40.Visible = True : strTitulo40 = .campo40
                    If .campo41 <> "" Then lbl41.Text = .campo41 : lbl41.Visible = True : Txt41.Visible = True : strTitulo41 = .campo41
                    If .campo42 <> "" Then lbl42.Text = .campo42 : lbl42.Visible = True : txt42.Visible = True : strTitulo42 = .campo42
                    If .campo43 <> "" Then lbl43.Text = .campo43 : lbl43.Visible = True : txt43.Visible = True : strTitulo43 = .campo43
                    If .campo44 <> "" Then lbl44.Text = .campo44 : lbl44.Visible = True : txt44.Visible = True : strTitulo44 = .campo44
                    If .campo45 <> "" Then lbl45.Text = .campo45 : lbl45.Visible = True : txt45.Visible = True : strTitulo45 = .campo45
                    If .campo46 <> "" Then lbl46.Text = .campo46 : lbl46.Visible = True : txt46.Visible = True : strTitulo46 = .campo46
                    If .campo47 <> "" Then lbl47.Text = .campo47 : lbl47.Visible = True : txt47.Visible = True : strTitulo47 = .campo47
                    If .campo48 <> "" Then lbl48.Text = .campo48 : lbl48.Visible = True : txt48.Visible = True : strTitulo48 = .campo48
                    If .campo49 <> "" Then lbl49.Text = .campo49 : lbl49.Visible = True : Txt49.Visible = True : strTitulo49 = .campo49
                    If .campo50 <> "" Then lbl50.Text = .campo50 : lbl50.Visible = True : Txt50.Visible = True : strTitulo50 = .campo50
                    If .campo51 <> "" Then lbl51.Text = .campo51 : lbl51.Visible = True : txt51.Visible = True : strTitulo51 = .campo51



                End With
            End If
            If lblnEditando Then
                If lblnNuevo Then
                    txtCodigo.Enabled = False
                    txtDescripcion.Enabled = True
                    txtDescripcion.Focus()


                    Select Case cboTabla.SelectedValue
                        Case "PrecioMercado", "PrecioQP"
                            Dim sPeriodo As String = fxgrdMantenimiento.Rows(1)(4).ToString
                            Dim dPeriodo As Date = "01/" + sPeriodo.Substring(4, 2) + "/" + sPeriodo.Substring(0, 4)
                            'dPeriodo = "01/11/2012"
                            dPeriodo = dPeriodo.AddMonths(1)

                            Dim sp As String() = dPeriodo.ToLongDateString.Split(" ")
                            txtDescripcion.Text = sp(3).ToUpper + " " + sp(5)
                            txt1.Text = dPeriodo.Year().ToString() + ("0" + (dPeriodo.Month).ToString()).Substring(("0" + (dPeriodo.Month).ToString()).Length - 2, 2)
                    End Select
                Else
                    Dim drow As C1.Win.C1FlexGrid.Row = fxgrdMantenimiento.Rows(fxgrdMantenimiento.RowSel)
                    ' fxgrdMantenimiento.Rows(fxgrdMantenimiento.RowSel).Item("tabladetid")
                    txtCodigo.Text = fxgrdMantenimiento.Rows(fxgrdMantenimiento.RowSel).Item("tabladetid")
                    txtDescripcion.Text = drow.Item("descri").ToString
                    txt1.Text = drow.Item("campo0").ToString
                    txt2.Text = drow.Item("campo1").ToString
                    txt3.Text = drow.Item("campo2").ToString
                    txt4.Text = drow.Item("campo3").ToString
                    txt5.Text = drow.Item("campo4").ToString
                    txt6.Text = drow.Item("campo5").ToString
                    txt7.Text = drow.Item("campo6").ToString
                    txt8.Text = drow.Item("campo7").ToString
                    txt9.Text = drow.Item("campo8").ToString
                    txt10.Text = drow.Item("campo9").ToString
                    txt11.Text = drow.Item("campo10").ToString
                    txt12.Text = drow.Item("campo11").ToString
                    txt13.Text = drow.Item("campo12").ToString
                    txt14.Text = drow.Item("campo13").ToString
                    txt15.Text = drow.Item("campo14").ToString
                    txt16.Text = drow.Item("campo15").ToString
                    txt17.Text = drow.Item("campo16").ToString
                    txt18.Text = drow.Item("campo17").ToString
                    txt19.Text = drow.Item("campo18").ToString
                    txt20.Text = drow.Item("campo19").ToString
                    txt21.Text = drow.Item("campo21").ToString
                    Txt22.Text = drow.Item("campo22").ToString
                    txt23.Text = drow.Item("campo23").ToString
                    Txt24.Text = drow.Item("campo24").ToString
                    Txt25.Text = drow.Item("campo25").ToString
                    Txt26.Text = drow.Item("campo26").ToString
                    Txt27.Text = drow.Item("campo27").ToString
                    txt28.Text = drow.Item("campo28").ToString
                    Txt29.Text = drow.Item("campo29").ToString
                    Txt30.Text = drow.Item("campo30").ToString
                    Txt31.Text = drow.Item("campo31").ToString
                    Txt32.Text = drow.Item("campo32").ToString
                    Txt33.Text = drow.Item("campo33").ToString
                    txt34.Text = drow.Item("campo34").ToString
                    txt35.Text = drow.Item("campo35").ToString
                    Txt36.Text = drow.Item("campo36").ToString
                    txt37.Text = drow.Item("campo37").ToString
                    txt38.Text = drow.Item("campo38").ToString
                    txt39.Text = drow.Item("campo39").ToString
                    txt40.Text = drow.Item("campo40").ToString
                    Txt41.Text = drow.Item("campo41").ToString
                    txt42.Text = drow.Item("campo42").ToString
                    txt43.Text = drow.Item("campo43").ToString
                    txt44.Text = drow.Item("campo44").ToString
                    txt45.Text = drow.Item("campo45").ToString
                    txt46.Text = drow.Item("campo46").ToString
                    txt47.Text = drow.Item("campo47").ToString
                    txt48.Text = drow.Item("campo48").ToString
                    Txt49.Text = drow.Item("campo49").ToString
                    Txt50.Text = drow.Item("campo50").ToString
                    txt51.Text = drow.Item("campo51").ToString

                    txtCodigo.Enabled = False
                    txtDescripcion.Enabled = True
                    txtDescripcion.Focus()
                End If


            End If




            Select Case cboTabla.SelectedValue
                Case "PrecioMaestro"
                    txtDescripcion.Enabled = False
                    txt2.Enabled = False
                Case "PrecioMercado", "PrecioQP"
                    txtDescripcion.Enabled = False
                    txt1.Enabled = False
            End Select


            Select Case cboTabla.SelectedValue
                Case "Metal"
                    txt5.TextAlign = HorizontalAlignment.Right
                    txt7.TextAlign = HorizontalAlignment.Right
                    txt8.TextAlign = HorizontalAlignment.Right
                    txt9.TextAlign = HorizontalAlignment.Right
                    txt10.TextAlign = HorizontalAlignment.Right
                    txt11.TextAlign = HorizontalAlignment.Right
                    txt13.TextAlign = HorizontalAlignment.Right

                    ' ''txt0.Visible = False
                    ''txt1.Visible = False
                    ''txt2.Visible = False
                    ''txt3.Visible = False

                    ''txt6.Visible = False
                    ''txt7.Visible = False
                    ''txt8.Visible = False
                    ''txt9.Visible = False
                    ''txt10.Visible = False
                    ''txt11.Visible = False
                    ''txt12.Visible = False
                    ''txt13.Visible = False
                    ''txt14.Visible = False
                    ''txt15.Visible = False
                    ''txt16.Visible = False
                    ''txt17.Visible = False
                    ''txt18.Visible = False
                    ''txt19.Visible = False
                    ''txt20.Visible = False


                    'Dim drow As C1.Win.C1FlexGrid.Row = fxgrdMantenimiento.Rows(fxgrdMantenimiento.RowSel)
                    'txt5.Text = Convert.ToDouble(drow.Item("campo4")).ToString("###,###.00")
                    'txt7.Text = Convert.ToDouble(drow.Item("campo6")).ToString("###,###.00")
                    'txt8.Text = Convert.ToDouble(drow.Item("campo7")).ToString("###,###.00")
                    'txt9.Text = Convert.ToDouble(drow.Item("campo8")).ToString("###,###.00")
                    'txt10.Text = Convert.ToDouble(drow.Item("campo9")).ToString("###,###.00")
                    'txt11.Text = Convert.ToDouble(drow.Item("campo10")).ToString("###,###.00")
                    'txt13.Text = Convert.ToDouble(drow.Item("campo12")).ToString("###,###.00")
            End Select

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try

    End Sub
    Private Sub OperacionRegistro(ByVal operacion As enumTipoOperacion)
        Try
            lblnNuevo = False
            Select Case operacion
                Case enumTipoOperacion.Nuevo
                    txtCodigo.Text = ""
                    txtDescripcion.Text = ""
                    txt1.Text = ""
                    txt2.Text = ""
                    txt3.Text = ""
                    txt4.Text = ""
                    txt5.Text = ""
                    txt6.Text = ""
                    txt7.Text = ""
                    txt8.Text = ""
                    txt11.Text = ""
                    txt12.Text = ""
                    txt13.Text = ""
                    txt14.Text = ""
                    txt15.Text = ""
                    txt16.Text = ""
                    txt17.Text = ""
                    txt18.Text = ""
                    txt19.Text = ""
                    txt20.Text = ""
                    lblnNuevo = True
                    EditandoRegistro()
                Case enumTipoOperacion.Modificar

                    EditandoRegistro()
                Case enumTipoOperacion.Grabar
                    EditandoRegistro()
                Case enumTipoOperacion.Eliminar

                Case enumTipoOperacion.Cancelar
                    EditandoRegistro()
            End Select
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNuevo.Click, tsmNuevo.Click
        OperacionRegistro(enumTipoOperacion.Nuevo)

    End Sub

    Private Sub tsbModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModificar.Click, tsmModificar.Click
        OperacionRegistro(enumTipoOperacion.Modificar)

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click, tsmGuardar.Click
        Try
            'If RegistroExiste(cboTabla.SelectedValue, txtCodigo.Text) Then
            '    MsgBox("Codigo ya existe, verifique porfavor.")
            '    Exit Sub
            'End If

            If cboTabla.SelectedValue = "Socio" Then
                'Valida que el socio no exista
                'cols 5 = RUC
                'cols 2 = tablaDetId
                If (fxgrdMantenimiento.FindRow(txt2.Text, 1, 5, True) > 0) And (fxgrdMantenimiento.FindRow(txt2.Text, 1, 5, True) <> fxgrdMantenimiento.FindRow(txtCodigo.Text, 1, 2, False)) Then
                    MsgBox("Socio ya ha sido registrado, verifique porfavor.")
                    Exit Sub
                End If


                If validarRuc(txt2.Text) = False Then
                    MsgBox("Ruc invalido, verifique porfavor.")
                    Exit Sub
                End If

            End If

            If MsgBox("Esta seguro de guardar el registro", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then
                If Not ValidaRegistro() Then Exit Sub
                If lblnNuevo Then

                End If
                If GrabarRegistro() Then
                    MsgBox("Registro Guardado correctamente.")
                    cboTabla_SelectedIndexChanged(Nothing, e)
                    OperacionRegistro(enumTipoOperacion.Grabar)
                Else
                    MsgBox("Hubo errores al actualizar/insertar el registro.")
                End If
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click, tsmCancelar.Click
        OperacionRegistro(enumTipoOperacion.Cancelar)

    End Sub
    Private Function ValidaRegistro()
        Try
            Dim strmensaje As String = ""

            'If String.IsNullOrEmpty(txtCodigo.Text) Then
            '    strmensaje = strmensaje & "* Ingrese Codigo" & vbCrLf
            '    resaltarobjecto(txtCodigo)
            'End If
            If String.IsNullOrEmpty(txtDescripcion.Text) Then
                strmensaje = strmensaje & "* Ingrese Descripcion" & vbCrLf
                resaltarobjecto(txtDescripcion)
            End If
            If strmensaje.Length > 0 Then
                MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Valorizador de Minerales")
                Return False
            End If
            Return True
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
            Return False
        End Try
    End Function
    Private Function GrabarRegistro()
        Try
            Dim oTablaDetTX As New clsBC_TablaDetTX
            With oTablaDetTX.oBETablaDet
                .tablaId = cboTabla.SelectedValue
                .tablaDetId = txtCodigo.Text
                .descri = txtDescripcion.Text
                .campo0 = txt1.Text
                .campo1 = txt2.Text
                .campo2 = txt3.Text
                .campo3 = txt4.Text
                .campo4 = txt5.Text
                .campo5 = txt6.Text
                .campo6 = txt7.Text
                .campo7 = txt8.Text
                .campo8 = txt9.Text
                .campo9 = txt10.Text
                .campo10 = txt11.Text
                .campo11 = txt12.Text
                .campo12 = txt13.Text
                .campo13 = txt14.Text
                .campo14 = txt15.Text
                .campo15 = txt16.Text
                .campo16 = txt17.Text
                .campo17 = txt18.Text
                .campo18 = txt19.Text
                .campo19 = txt20.Text
                .campo21 = txt21.Text
                .campo22 = Txt22.Text
                .campo23 = txt23.Text
                .campo24 = Txt24.Text
                .campo25 = Txt25.Text
                .campo26 = Txt26.Text
                .campo27 = Txt27.Text
                .campo28 = txt28.Text
                .campo29 = Txt29.Text
                .campo30 = Txt30.Text
                .campo31 = Txt31.Text
                .campo32 = Txt32.Text
                .campo33 = Txt33.Text
                .campo34 = txt34.Text
                .campo35 = txt35.Text
                .campo36 = Txt36.Text
                .campo37 = txt37.Text
                .campo38 = txt38.Text
                .campo39 = txt39.Text
                .campo40 = txt40.Text
                .campo41 = Txt41.Text
                .campo42 = txt42.Text
                .campo43 = txt43.Text
                .campo44 = txt44.Text
                .campo45 = txt45.Text
                .campo46 = txt46.Text
                .campo47 = txt47.Text
                .campo48 = txt48.Text
                .campo49 = Txt49.Text
                .campo50 = Txt50.Text
                .campo51 = txt51.Text

                .codigoEstado = TABLA_DE_ESTADOS.ACTIVO.Value
                '.indicador = True
                .uc = pBEUsuario.tablaDetId
                .um = pBEUsuario.tablaDetId
                oTablaDetTX.LstTablaDet.Add(oTablaDetTX.oBETablaDet)
            End With
            If lblnNuevo Then
                Return oTablaDetTX.InsertarTablaDet()
            Else
                Return oTablaDetTX.ModificarTablaDet()
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
            Return False
        End Try
    End Function
    Private Function RegistroExiste(ByVal tablaid As String, ByVal tabladetid As String)
        Try
            Dim oTablaDetRO As New clsBC_TablaDetRO
            With oTablaDetRO.oBETablaDet
                .tablaId = tablaid
                .tablaDetId = tabladetid
            End With
            oTablaDetRO.LeerTablaDet()
            If String.IsNullOrEmpty(oTablaDetRO.oBETablaDet.descri) Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
            Return False
        End Try
    End Function

    Private Sub frmTabla_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim BaseRectangle As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)

        Dim Gradient_Brush As New LinearGradientBrush(BaseRectangle, SI.PL.clsGeneral.ColorForm, Color.White, LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(Gradient_Brush, BaseRectangle)
    End Sub

    Private Sub tsmSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmSalir.Click, tsbSalir.Click
        Me.Dispose()
    End Sub

    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click
        Dim oTablaDetTX As New clsBC_TablaDetTX
        If fxgrdMantenimiento.Rows.Count > 0 Then
            If MsgBox("Esta seguro de eliminar el Registro Seleccionado", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then
                With (oTablaDetTX.oBETablaDet)
                    .tablaId = cboTabla.SelectedValue
                    .tablaDetId = fxgrdMantenimiento.Rows(fxgrdMantenimiento.RowSel).Item("tabladetid")
                    ' tdbgMantenimiento.Splits(0).Rows.
                    oTablaDetTX.LstTablaDet.Add(oTablaDetTX.oBETablaDet)
                End With

                oTablaDetTX.EliminarTablaDet()
                cboTabla_SelectedIndexChanged(Nothing, e)
            End If
        End If
    End Sub
    Private Shared Sub resaltarobjecto(ByVal txt As TextBox)
        If txt.BackColor <> Color.Orange Then
            txt.BackColor = Color.Khaki
        Else
            txt.BackColor = Color.White
        End If
    End Sub
    Private Shared Sub resaltarobjecto(ByVal cbo As ComboBox)
        If cbo.BackColor <> Color.Orange Then
            cbo.BackColor = Color.Khaki
        Else
            cbo.BackColor = Color.White
        End If
    End Sub
    Private Shared Sub resaltarobjecto(ByVal nupd As NumericUpDown)
        If nupd.BackColor <> Color.Orange Then
            nupd.BackColor = Color.Khaki
        Else
            nupd.BackColor = Color.White
        End If
    End Sub


    Private Sub fxgrdMantenimiento_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fxgrdMantenimiento.DoubleClick
        OperacionRegistro(enumTipoOperacion.Modificar)
    End Sub










    Public Shared Function validarRuc(ByVal ruc As String) As Boolean
        If VAL_RUC(ruc) = False Then
            Return False
        End If

        Return True
    End Function

    'Ejm:
    'RUC = 10254824220
    'FACTOR = 5432765432
    'Se separa los 10 primeros digitos de la izquierda y se hace un calculo inividual
    '1 * 5 =5
    '0 * 4 = 0
    '2 * 3 = 6
    '5 * 2 = 10
    '4 * 7 = 28
    '8 * 6 = 48
    '2 * 5 = 10
    '4 * 4 = 16
    '2 * 3 = 6
    '2 * 2 = 4

    'Se suma el resultado de todas las multiplicaciones
    'SUMA = 133
    'Se calcula el residuo de la division por 11
    '133/ 11 = 1
    'RESIDUO = 1
    'Se resta 11 menos el residuo
    '11 - 1
    'RESTA = 10

    'digito de chequeo = RESTA
    'si resta = 10 entonces digito de cheque = 0
    'si resta = 11 entonces digito de cheque = 1

    'RUC 10254824220 es valido por que su digito numero 11 es 0 y el digito de chekeo es 0.
    Private Shared Function LeftC(ByVal str As String, ByVal Length As Integer) As String
        Dim LenT As Integer = str.Length

        If LenT <= Length Then
            Return str
        Else
            Return str.Substring(0, Length)
        End If
    End Function


    Private Shared Function RightC(ByVal str As String, ByVal Length As Integer) As String
        Dim LenT As Integer = str.Length
        If LenT <= Length Then
            Return str
        Else
            Return str.Substring(LenT - Length)
        End If

    End Function

    Private Shared Function VAL_RUC(ByVal ruc As String) As Boolean
        Dim FACTOR() As Integer = {5, 4, 3, 2, 7, 6, 5, 4, 3, 2}
        Dim suma As Integer = 0

        'ERROR SI NO ES NUMERO
        If Not IsNumeric(ruc) Then
            Return False
        End If

        'ERROR SI NO CUMPLE LOS 11 DIGITOS
        If ruc.Length <> 11 Then
            Return False
        End If

        'ERROR SI NO TIENE LOS 2 PRIMEROS DIGITOS
        '10 persona natural.
        '20 persona juridica.
        '17 o 15 extranjeros

        Dim VAL_DIGIT() As String = {"20", "17", "15", "10"}
        Dim DIGIT As String = LeftC(ruc, 2)

        Array.Sort(VAL_DIGIT)
        If Array.BinarySearch((VAL_DIGIT), DIGIT) < 0 Then
            Return False
        End If

        For I = 0 To ruc.Length - 2
            suma += Integer.Parse(ruc.Substring(I, 1)) * FACTOR(I)
        Next

        Dim residuo As Integer = suma Mod 11
        Dim resta As Integer = 11 - residuo
        Dim digChk As Integer

        If resta = 10 Then
            digChk = 0
        ElseIf resta = 11 Then
            digChk = 1
        Else
            digChk = resta
        End If

        If digChk = RightC(ruc, 1) Then
            Return True
        Else
            Return False
        End If

    End Function


End Class

