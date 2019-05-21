'Modified:
'@01 20141009 BAL01 Validacion para usuarios con permisos de modificar ValidacionCTB

Imports SI.PL.clsEnumerado
Imports SI.BC
Imports System.Data
Imports System.Reflection
Imports SI.BE
Imports SI.PL.clsCombo
Namespace SI.PL
    Public Class clsFuncion
        Public Shared Function ObtenerCorrelativoPagable(ByVal contratoloteid As String, ByVal liquidacionid As String)
            Dim oPagableRO As New clsBC_ValorizadorPagableRO
            With oPagableRO.oBEValorizadorPagable
                '.liquidacionTmId = liquidaciontmid
                .liquidacionId = liquidacionid
                .contratoLoteId = contratoloteid
            End With
            oPagableRO.LeerPagableCorrelativo()
            Return oPagableRO.oBEValorizadorPagable.liquidacionPagable
        End Function
        Public Shared Function ObtenerCorrelativoPenalizable(ByVal contratoloteid As String, ByVal liquidacionid As String)
            Dim oPenalizableRO As New clsBC_ValorizadorPenalizableRO
            With oPenalizableRO.oBEValorizadorPenalizable
                ' .liquidacionTmId = liquidaciontmid
                .liquidacionId = liquidacionid
                .contratoLoteId = contratoloteid
            End With
            oPenalizableRO.LeerPenalizableCorrelativo()
            Return oPenalizableRO.oBEValorizadorPenalizable.liquidacionPenalizableId
        End Function
        Public Shared Sub ConfiguraForm(ByVal frm As Form)
            Dim fnt As Font
            fnt = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            frm.BackColor = Color.LemonChiffon
            For Each ctrl As Control In frm.Controls
                If TypeOf ctrl Is CUGroupBox Then
                    CType(ctrl, CUGroupBox).BorderColor = Color.MediumBlue
                End If
                If TypeOf ctrl Is GroupBox Then
                    For Each ctrl2 In ctrl.Controls
                        If TypeOf ctrl2 Is TextBox Or TypeOf ctrl2 Is ComboBox Or TypeOf ctrl2 Is NumericUpDown Then
                            ctrl2.Font = fnt
                        End If

                    Next
                End If
                If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Or TypeOf ctrl Is NumericUpDown Then
                    ctrl.Font = fnt
                End If

                If TypeOf ctrl Is ToolStrip Then
                    ctrl.BackColor = Color.LemonChiffon
                End If


            Next
        End Sub
        Public Shared Function BuscarenDatatable(ByVal dt As DataTable, ByVal nomcolumna As String, ByVal valcolumna As String) As DataRow
            For Each drow As DataRow In dt.Rows
                If drow.RowState <> DataRowState.Deleted Then
                    If drow.Item(nomcolumna).ToString = valcolumna Then
                        Return drow
                    End If
                End If

            Next
            Return Nothing

        End Function
        Public Shared Sub BuscarenComboBox(ByVal comboSeleccionar As ComboBox, ByVal valorBuscar As String)
            Dim nItem As Integer
            For nItem = 0 To comboSeleccionar.Items.Count - 1
                If comboSeleccionar.Items(nItem).GetType.Name = "clsBE_General" Then
                    If CType(comboSeleccionar.Items(nItem), clsBE_General).Codigo_Retorna = valorBuscar Then
                        comboSeleccionar.SelectedIndex = nItem
                        Exit Sub
                    End If
                Else
                    If comboSeleccionar.Items(nItem) = valorBuscar Then
                        comboSeleccionar.SelectedIndex = nItem
                        Exit Sub
                    End If
                End If

            Next
        End Sub
        Public Shared Sub ColumnasCodigo(ByVal fxGrid As C1.Win.C1FlexGrid.C1FlexGrid)
            For Each col As C1.Win.C1FlexGrid.Column In fxGrid.Cols
                If InStr(col.Caption, "codigo") > 0 Then
                    col.Caption = col.Caption.Replace("codigo", "")
                End If
            Next
        End Sub
        Public Shared Sub ColumnasCodigo(ByVal fxGrid As C1.Win.C1TrueDBGrid.C1TrueDBGrid)

            For Each col As C1.Win.C1TrueDBGrid.C1DataColumn In fxGrid.Columns

                If InStr(col.Caption, "codigo") > 0 Then
                    col.Caption = col.Caption.Replace("codigo", "")
                End If
            Next
        End Sub
        Public Shared Sub ColumnasID(ByVal fxGrid As C1.Win.C1FlexGrid.C1FlexGrid)
            For Each col As C1.Win.C1FlexGrid.Column In fxGrid.Cols
                If (Left(col.Caption.ToLower, 2) = "id") Or (Right(col.Caption.ToLower, 2) = "id") Or InStr(col.Caption.ToLower, "estado") > 0 Or (Left(col.Caption.ToLower, 2) = "uc") Or (Left(col.Caption.ToLower, 2) = "um") Or (Left(col.Caption.ToLower, 2) = "fc") Or (Left(col.Caption.ToLower, 2) = "fm") Or InStr(col.Caption.ToLower, "calculo") > 0 Or InStr(col.Caption.ToLower, "codigo") > 0 Then
                    col.Visible = False
                End If
            Next
        End Sub
        Public Shared Sub ColumnasID(ByVal fxGrid As C1.Win.C1TrueDBGrid.C1TrueDBGrid)
            For Each col As C1.Win.C1TrueDBGrid.C1DataColumn In fxGrid.Columns
                Dim dc As C1.Win.C1TrueDBGrid.C1DisplayColumn
                If (Left(col.Caption.ToLower, 2) = "id") Or (Right(col.Caption.ToLower, 2) = "id") Or InStr(col.Caption.ToLower, "estado") > 0 Or (Left(col.Caption.ToLower, 2) = "uc") Or (Left(col.Caption.ToLower, 2) = "um") Or (Left(col.Caption.ToLower, 2) = "fc") Or (Left(col.Caption.ToLower, 2) = "fm") Or InStr(col.Caption.ToLower, "calculo") > 0 Or InStr(col.Caption.ToLower, "codigo") > 0 Then
                    dc = fxGrid.Splits(0).DisplayColumns.Item(col.Caption)
                    dc.Visible = False
                End If
            Next
        End Sub
        Public Shared Sub Listar_Parametros(ByVal lDataGridView As DataGridView, ByVal lintTipoParametro As String, Optional ByVal lPrimerValor As enumPrimerValorCombo = enumPrimerValorCombo.Ninguno, Optional ByVal lcampocodigo As String = "codigo")
            Dim oGeneral As New clsBC_GeneralRO
            Dim oDvwGeneral As DataView
            Dim strPrimerValor As String = ""
            Select Case lPrimerValor
                Case enumPrimerValorCombo.Seleccione
                    strPrimerValor = "[Seleccione]"
                Case enumPrimerValorCombo.Todos
                    strPrimerValor = "[Todos]"
            End Select
            With oGeneral.oBEGeneral
                oGeneral.oBEGeneral.NomTabla = lintTipoParametro
                oGeneral.oBEGeneral.PrimerValor = strPrimerValor
                oGeneral.LstGeneral.Clear()
                If Not oGeneral Is Nothing Then
                    Dim dsAyuda As New DataSet
                    dsAyuda = oGeneral.Obtener_ParametrosDS
                    oDvwGeneral = New DataView(dsAyuda.Tables(0))
                    lDataGridView.AutoGenerateColumns = False
                    lDataGridView.DataSource = oDvwGeneral
                    lDataGridView.Enabled = True
                    With lDataGridView
                        .Columns.Item(0).DataPropertyName = lcampocodigo
                        .Columns.Item(1).DataPropertyName = "descripcion"
                        .Columns.Item(2).DataPropertyName = "ID"
                        .Columns.Item(3).DataPropertyName = "ID"
                    End With
                End If
            End With
        End Sub






        Public Shared Sub Listar_ParametrosEN(ByVal lDataGridView As DataGridView, ByVal lintTipoParametro As String, Optional ByVal lPrimerValor As enumPrimerValorCombo = enumPrimerValorCombo.Ninguno, Optional ByVal lcampocodigo As String = "codigo", Optional ByVal sParametro1 As String = "", Optional ByVal sParametro2 As String = "")
            Dim oGeneral

            Dim oDvwGeneral As DataView
            Dim strPrimerValor As String = ""

            Select Case lPrimerValor
                Case enumPrimerValorCombo.Seleccione
                    strPrimerValor = "[Seleccione]"
                Case enumPrimerValorCombo.Todos
                    strPrimerValor = "[Todos]"
            End Select

            Select Case lintTipoParametro

                Case "Socio"
                    oGeneral = New clsBC_PUB_PERSONASRO

                    With oGeneral.oBEPUB_PERSONAS
                        'oGeneral.oBEGeneral.NomTabla = lintTipoParametro
                        'oGeneral.oBEGeneral.PrimerValor = strPrimerValor
                        oGeneral.LstPUB_PERSONAS.Clear()
                        If Not oGeneral Is Nothing Then
                            Dim dsAyuda As New DataSet
                            dsAyuda = oGeneral.LeerListaToDSPUB_PERSONAS
                            oDvwGeneral = New DataView(dsAyuda.Tables(0))
                            lDataGridView.AutoGenerateColumns = False
                            lDataGridView.DataSource = oDvwGeneral
                            lDataGridView.Enabled = True
                            With lDataGridView
                                .Columns.Item(0).DataPropertyName = lcampocodigo
                                .Columns.Item(1).DataPropertyName = "RAZON_SOCIAL"
                                .Columns.Item(2).DataPropertyName = lcampocodigo
                                .Columns.Item(3).DataPropertyName = lcampocodigo
                                .Columns.Item(4).DataPropertyName = lcampocodigo
                            End With
                        End If
                    End With

                Case "Adelanto"
                    oGeneral = New clsBC_FINANCIANDO_PRELIQRO
                    With oGeneral.oBEFINANCIANDO_PRELIQ
                        'oGeneral.LstBEFINANCIANDO_PRELIQ.Clear()
                        If Not oGeneral Is Nothing Then
                            Dim dsAyuda As New DataSet
                            oGeneral.oBEFINANCIANDO_PRELIQ.contrato = "P2447"
                            oGeneral.oBEFINANCIANDO_PRELIQ.lote = "002"
                            oGeneral.LeerListaFINANCIANDO_PRELIQ()
                            dsAyuda = oGeneral.oDSFINANCIANDO_PRELIQ
                            oDvwGeneral = New DataView(dsAyuda.Tables(0))
                            lDataGridView.AutoGenerateColumns = False
                            lDataGridView.DataSource = oDvwGeneral
                            lDataGridView.Enabled = True
                            With lDataGridView
                                .Columns.Item(0).DataPropertyName = lcampocodigo
                                .Columns.Item(1).DataPropertyName = "MONTO_LIQ"
                                .Columns.Item(2).DataPropertyName = "NUM_COMPR_LIQ"
                                .Columns.Item(3).DataPropertyName = lcampocodigo
                                .Columns.Item(4).DataPropertyName = "FECHA_REG"
                            End With
                        End If
                    End With





                Case "VentaVinculada"
                    oGeneral = New clsBC_ContratoLoteRO

                    With oGeneral.oBEContratoLote
                        'oGeneral.oBEGeneral.NomTabla = lintTipoParametro
                        'oGeneral.oBEGeneral.PrimerValor = strPrimerValor


                        oGeneral.oBEContratoLote.contrato = lcampocodigo
                        oGeneral.LstContratoLote.Clear()
                        If Not oGeneral Is Nothing Then
                            Dim dsAyuda As New DataSet
                            dsAyuda = oGeneral.LeerListaToDSContratoLote_Vinculada
                            oDvwGeneral = New DataView(dsAyuda.Tables(0))
                            lDataGridView.AutoGenerateColumns = False
                            lDataGridView.DataSource = oDvwGeneral
                            lDataGridView.Enabled = True
                            With lDataGridView
                                .Columns.Item(0).DataPropertyName = "ContratoLoteId"
                                .Columns.Item(1).DataPropertyName = "LoteVenta" '"RAZON_SOCIAL"
                                .Columns.Item(2).DataPropertyName = "ContratoVinculada"
                                .Columns.Item(3).DataPropertyName = lcampocodigo
                                .Columns.Item(4).DataPropertyName = lcampocodigo
                            End With
                        End If
                    End With











                Case "Beneficiario"
                    oGeneral = New clsBC_TB_BENEFICIARIO_CCHICARO
                    With oGeneral.oBETB_BENEFICIARIO_CCHICA

                        If Not oGeneral Is Nothing Then
                            Dim dsAyuda As New DataSet
                            oGeneral.oBETB_BENEFICIARIO_CCHICA.EMPRESA = lcampocodigo

                            oGeneral.LeerListaToDSTB_BENEFICIARIO_CCHICA()
                            dsAyuda = oGeneral.oDSTB_BENEFICIARIO_CCHICA
                            oDvwGeneral = New DataView(dsAyuda.Tables(0))
                            lDataGridView.AutoGenerateColumns = False
                            lDataGridView.DataSource = oDvwGeneral
                            lDataGridView.Enabled = True
                            With lDataGridView
                                .Columns.Item(0).DataPropertyName = "BENEFICIARIO"
                                .Columns.Item(1).DataPropertyName = "DESCRIPCION_BENEF"
                                '.Columns.Item(2).DataPropertyName = "NUM_COMPR_LIQ"
                                '.Columns.Item(3).DataPropertyName = lcampocodigo
                                '.Columns.Item(4).DataPropertyName = "FECHA_REG"
                            End With
                        End If
                    End With


                Case "Anexo_Banco"
                    oGeneral = New clsBC_ANEXOS_BANCORO
                    With oGeneral.oBEANEXOS_BANCO

                        If Not oGeneral Is Nothing Then
                            Dim dsAyuda As New DataSet
                            oGeneral.oBEANEXOS_BANCO.EMPRESA = sParametro1
                            oGeneral.oBEANEXOS_BANCO.ANEXO = sParametro2


                            oGeneral.LeerListaToDSANEXOS_BANCO()
                            dsAyuda = oGeneral.oDSANEXOS_BANCO

                            oDvwGeneral = New DataView(dsAyuda.Tables(0))
                            lDataGridView.AutoGenerateColumns = False
                            lDataGridView.DataSource = oDvwGeneral
                            lDataGridView.Enabled = True
                            With lDataGridView
                                .Columns.Item(0).DataPropertyName = "BANCO"
                                .Columns.Item(1).DataPropertyName = "MONEDA"
                                .Columns.Item(2).DataPropertyName = "CUENTA_BCO"
                                .Columns.Item(3).DataPropertyName = "BANCO_DESC"
                                '.Columns.Item(4).DataPropertyName = "FECHA_REG"
                            End With
                        End If
                    End With




                Case "OtrasCuentasXCobrar"
                    oGeneral = New clsBC_FINANCIANDO_CLIRO
                    With oGeneral.oBEFINANCIANDO_CLI

                        If Not oGeneral Is Nothing Then
                            Dim dsAyuda As New DataSet
                            oGeneral.oBEFINANCIANDO_CLI.proveedor = sParametro1

                            oGeneral.LeerListaToDSFINANCIANDO_CLI()
                            dsAyuda = oGeneral.oDSFINANCIANDO_CLI

                            oDvwGeneral = New DataView(dsAyuda.Tables(0))
                            lDataGridView.AutoGenerateColumns = False
                            lDataGridView.DataSource = oDvwGeneral
                            lDataGridView.Enabled = True
                            With lDataGridView
                                .Columns.Item(0).DataPropertyName = "abreviado"
                                .Columns.Item(1).DataPropertyName = "TIPO_DOC"
                                .Columns.Item(2).DataPropertyName = "NRO_DOC"
                                .Columns.Item(3).DataPropertyName = "MONEDA"
                                .Columns.Item(4).DataPropertyName = "SALDO"
                                .Columns.Item(5).DataPropertyName = "OBSERVACIONES"
                                ' .Columns.Item(6).DataPropertyName = "ruc"
                                .Columns.Item(6).DataPropertyName = "fch_doc"
                                .Columns.Item(7).DataPropertyName = "DESCUENTO"
                                .Columns.Item(8).DataPropertyName = "C_CONTRATO"
                                .Columns.Item(9).DataPropertyName = "RAZON_SOCIAL"
                                .Columns.Item(10).DataPropertyName = "LINEA_CLI"
                                .Columns.Item(11).DataPropertyName = "CUENTA_PROV"
                                '.Columns.Item(12).DataPropertyName = "FCH_DOC"

                            End With
                        End If
                    End With


                Case "PrestamosCchica"
                    oGeneral = New clsBC_FINANCIANDO_CLIRO
                    With oGeneral.oBEFINANCIANDO_CLI

                        If Not oGeneral Is Nothing Then
                            Dim dsAyuda As New DataSet
                            oGeneral.oBEFINANCIANDO_CLI.proveedor = sParametro1

                            oGeneral.LeerListaToDSPRESTAMO_CCH()
                            dsAyuda = oGeneral.oDSPRESTAMO_CCH

                            oDvwGeneral = New DataView(dsAyuda.Tables(0))
                            lDataGridView.AutoGenerateColumns = False
                            lDataGridView.DataSource = oDvwGeneral
                            lDataGridView.Enabled = True
                            With lDataGridView
                                .Columns.Item(0).DataPropertyName = "abreviado"
                                .Columns.Item(1).DataPropertyName = "TIPO_DOC"
                                .Columns.Item(2).DataPropertyName = "NRO_DOC"
                                .Columns.Item(3).DataPropertyName = "MONEDA"
                                .Columns.Item(4).DataPropertyName = "SALDO"
                                .Columns.Item(5).DataPropertyName = "OBSERVACIONES"
                                .Columns.Item(6).DataPropertyName = "ruc"
                                .Columns.Item(7).DataPropertyName = "DESCUENTO"
                                .Columns.Item(8).DataPropertyName = "C_CONTRATO"
                                .Columns.Item(9).DataPropertyName = "RAZON_SOCIAL"
                                .Columns.Item(10).DataPropertyName = "LINEA_CLI"
                                .Columns.Item(11).DataPropertyName = "CUENTA_PROV"
                            End With
                        End If
                    End With


                Case "PrestamosComer"
                    oGeneral = New clsBC_FINANCIANDO_CLIRO
                    With oGeneral.oBEFINANCIANDO_CLI

                        If Not oGeneral Is Nothing Then
                            Dim dsAyuda As New DataSet
                            oGeneral.oBEFINANCIANDO_CLI.proveedor = sParametro1
                            oGeneral.oBEFINANCIANDO_CLI.empresa = sParametro2

                            oGeneral.LeerListaToDSPRESTAMO_COM()
                            dsAyuda = oGeneral.oDSPRESTAMO_COM

                            oDvwGeneral = New DataView(dsAyuda.Tables(0))
                            lDataGridView.AutoGenerateColumns = False
                            lDataGridView.DataSource = oDvwGeneral
                            lDataGridView.Enabled = True
                            With lDataGridView
                                .Columns.Item(0).DataPropertyName = "fecha"
                                .Columns.Item(1).DataPropertyName = "empresa"
                                .Columns.Item(2).DataPropertyName = "c_n_doc"
                                .Columns.Item(3).DataPropertyName = "moneda"
                                .Columns.Item(4).DataPropertyName = "n_i_saldo"
                                .Columns.Item(5).DataPropertyName = "tipo_egreso"
                                .Columns.Item(6).DataPropertyName = "descuento"
                                .Columns.Item(7).DataPropertyName = "c_c_control_prestamos"
                                .Columns.Item(8).DataPropertyName = "ruc_empresa"
                                .Columns.Item(9).DataPropertyName = "ruc_proveedor"
                                .Columns.Item(10).DataPropertyName = "tipo_documento"
                                .Columns.Item(11).DataPropertyName = "descripcion"

                            End With
                        End If
                    End With

            End Select



        End Sub



        Public Shared Sub Listar_Registros(ByVal lDataGridView As DataGridView, _
    ByVal strTabla As String, ByVal strCampoCodigo As String, _
    ByVal strCampoDescripcion As String, _
Optional ByVal strCampoID As String = "", Optional ByVal strCampoCondicion As String = "", _
Optional ByVal strValorCondicion As String = "", _
Optional ByVal strCampoConcatRevison As String = "", _
Optional ByVal strCampoConcatVersion As String = "")
            Dim oGeneral As New clsBC_GeneralRO

            With oGeneral.oBEGeneral
                oGeneral.oBEGeneral.NomTabla = strTabla
                oGeneral.oBEGeneral.Codigo_Retorna = strCampoCodigo
                oGeneral.oBEGeneral.Descripcion_Retorna = strCampoDescripcion
                oGeneral.oBEGeneral.Id_Retorna = strCampoID
                oGeneral.oBEGeneral.NomCampo1 = strCampoCondicion
                oGeneral.oBEGeneral.ValCampo1 = strValorCondicion
                oGeneral.LstGeneral.Clear()
                If Not oGeneral Is Nothing Then
                    Dim oDvwGeneral As DataView
                    Dim dsAyuda As New DataSet
                    dsAyuda = oGeneral.Obtener_RegistrosDS
                    oDvwGeneral = New DataView(dsAyuda.Tables(0))
                    lDataGridView.AutoGenerateColumns = False
                    lDataGridView.DataSource = oDvwGeneral
                    lDataGridView.Enabled = True
                    With lDataGridView
                        .Columns.Item(0).DataPropertyName = "id"
                        .Columns.Item(1).DataPropertyName = "codigoDescripcion"
                        .Columns.Item(2).DataPropertyName = "codigo"


                    End With

                End If
            End With
        End Sub
        Public Shared Sub Listar_RegistrosContrato(ByVal lDataGridView As DataGridView, _
    ByVal strTabla As String, ByVal strCampoCodigo As String, _
    ByVal strCampoDescripcion As String, _
Optional ByVal strCampoID As String = "", Optional ByVal strCampoCondicion As String = "", _
Optional ByVal strValorCondicion As String = "", _
Optional ByVal strCampoConcatRevison As String = "", _
Optional ByVal strCampoConcatVersion As String = "", Optional ByVal strFiltro As String = "B,D,P,S,V")

            Dim oGeneral As New clsBC_GeneralRO

            With oGeneral.oBEGeneral
                oGeneral.oBEGeneral.NomTabla = strTabla
                oGeneral.oBEGeneral.Codigo_Retorna = strCampoCodigo '
                oGeneral.oBEGeneral.Descripcion_Retorna = strCampoDescripcion '
                oGeneral.oBEGeneral.Id_Retorna = strCampoID
                oGeneral.oBEGeneral.NomCampo1 = strCampoCondicion
                oGeneral.oBEGeneral.ValCampo1 = strValorCondicion
                oGeneral.LstGeneral.Clear()
                If Not oGeneral Is Nothing Then
                    Dim oDvwGeneral As DataView
                    Dim dsAyuda As New DataSet
                    dsAyuda = oGeneral.Obtener_RegistrosDS
                    oDvwGeneral = New DataView(dsAyuda.Tables(0))
                    Dim strArray As String()
                    Dim strFiltroArray As String = ""
                    strArray = strFiltro.Split(",")
                    For i = 0 To strArray.Length - 1
                        If i < strArray.Length - 1 Then
                            strFiltroArray += "'" & strArray(i) & "',"
                        Else
                            strFiltroArray += "'" & strArray(i) & "'"
                        End If

                    Next
                    oDvwGeneral.RowFilter = "codigoMovimiento IN (" & strFiltroArray & ")" & "  and id not in ('PP302','PP001','PP002','PP003','PP004','PP005','PP006','PP007','PP010','PP031')"





                    lDataGridView.AutoGenerateColumns = False
                    lDataGridView.DataSource = oDvwGeneral
                    lDataGridView.Enabled = True
                    With lDataGridView
                        .Columns.Item(0).DataPropertyName = "id"
                        .Columns.Item(1).DataPropertyName = "Descripcion"
                        .Columns.Item(2).DataPropertyName = "Referencia"
                        .Columns.Item(3).DataPropertyName = "codigo"
                        .Columns.Item(4).DataPropertyName = "ultimo"


                    End With

                End If
            End With
        End Sub
        Public Shared Sub ObtenerTipoMovimientoCombo(ByVal oCombo As ComboBox, Optional ByVal filtro As String = "B,D,P,S,V")
            Dim oTablaDetRO As New clsBC_TablaDetRO
            Dim dsDatos As New DataSet
            Dim dvwDatos As DataView
            With oTablaDetRO.oBETablaDet
                .tablaId = "Movimiento"
            End With
            dsDatos = oTablaDetRO.LeerListaToDSTablaDet()
            dvwDatos = New DataView(dsDatos.Tables(0))
            oCombo.DataSource = dvwDatos
            oCombo.DisplayMember = "tabladetid"
            oCombo.ValueMember = "tabladetid"
            'For Each drow As DataRow In dvwDatos.Table.Rows
            '    If InStr(filtro, drow.Item(1), CompareMethod.Text) > 0 Then
            '        oCombo.Items.Add(drow.Item(1))
            '    End If
            'Next
            oCombo.SelectedIndex = 0

        End Sub
        Public Shared Sub Obtener_ParametrosCombo(ByVal oCombo As ComboBox, ByVal strTabla As String, _
Optional ByVal lPrimerValor As enumPrimerValorCombo = enumPrimerValorCombo.Seleccione, _
Optional ByVal vintTipo As enumTipoComboGrilla = enumTipoComboGrilla.IdDescripcion)
            Dim oGeneral As New clsBC_GeneralRO
            Dim strPrimerValor As String = ""
            Select Case lPrimerValor
                Case enumPrimerValorCombo.Seleccione
                    strPrimerValor = "[Seleccione]"
                Case enumPrimerValorCombo.Todos
                    strPrimerValor = "[Todos]"
            End Select
            With oGeneral.oBEGeneral
                oGeneral.oBEGeneral.NomTabla = strTabla
                oGeneral.oBEGeneral.PrimerValor = strPrimerValor
                oGeneral.LstGeneral.Clear()
                oGeneral.Obtener_Parametros()
                oCombo.Items.Clear()
                oCombo.Items.Clear()
                oCombo.Items.Add(New ListViewItem(strPrimerValor, ""))
                If Not oGeneral Is Nothing Then
                    If vintTipo = enumTipoComboGrilla.IdDescripcion Then
                        oCombo.DataSource = oGeneral.LstGeneral
                        oCombo.DisplayMember = "Descripcion_Retorna"
                        oCombo.ValueMember = "Id_Retorna"
                        'For i As Integer = 0 To oGeneral.LstGeneral.Count - 1

                        '    oCombo.Items.Add(New ListViewItem(oGeneral.LstGeneral(i).Descripcion_Retorna, oGeneral.LstGeneral(i).Id_Retorna))
                        'Next
                        ' lCombo.SelectedIndex = 0
                    ElseIf vintTipo = enumTipoComboGrilla.IdCodigo Then
                        'For i As Integer = 0 To oGeneral.LstGeneral.Count - 1
                        '    oCombo.Items.Add(New ListViewItem(oGeneral.LstGeneral(i).Codigo_Retorna, oGeneral.LstGeneral(i).Id_Retorna))
                        'Next
                        oCombo.DataSource = oGeneral.LstGeneral
                        oCombo.DisplayMember = "Codigo_Retorna"
                        oCombo.ValueMember = "Id_Retorna"
                    ElseIf vintTipo = enumTipoComboGrilla.IDCodigoDescripcion Or vintTipo = enumTipoComboGrilla.IDDescripcionCodigo Then
                        'For i As Integer = 0 To oGeneral.LstGeneral.Count - 1
                        '    oCombo.Items.Add(New ListViewItem(oGeneral.LstGeneral(i).CodigoDescripcion_Retorna, oGeneral.LstGeneral(i).Id_Retorna))
                        'Next
                        oCombo.DataSource = oGeneral.LstGeneral
                        oCombo.DisplayMember = "CodigoDescripcion_Retorna"
                        oCombo.ValueMember = "Id_Retorna"
                    End If
                End If
            End With
        End Sub


        Public Shared Sub Obtener_ParametrosCheckcombo(ByVal oChecklistb As CheckedListBox, ByVal strTabla As String, _
    Optional ByVal lPrimerValor As enumPrimerValorCombo = enumPrimerValorCombo.Seleccione, _
    Optional ByVal vintTipo As enumTipoComboGrilla = enumTipoComboGrilla.IdDescripcion)
            Dim oGeneral As New clsBC_GeneralRO
            Dim strPrimerValor As String = ""
            Select Case lPrimerValor
                Case enumPrimerValorCombo.Seleccione
                    strPrimerValor = "[Seleccione]"
                Case enumPrimerValorCombo.Todos
                    strPrimerValor = "[Todos]"
            End Select
            With oGeneral.oBEGeneral
                oGeneral.oBEGeneral.NomTabla = strTabla
                oGeneral.oBEGeneral.PrimerValor = strPrimerValor
                oGeneral.LstGeneral.Clear()
                oGeneral.Obtener_Parametros()
                oChecklistb.Items.Clear()
                oChecklistb.Items.Clear()
                oChecklistb.Items.Add(New ListViewItem(strPrimerValor, ""))
                If Not oGeneral Is Nothing Then
                    If vintTipo = enumTipoComboGrilla.IdDescripcion Then
                        oChecklistb.DataSource = oGeneral.LstGeneral
                        oChecklistb.DisplayMember = "Descripcion_Retorna"
                        oChecklistb.ValueMember = "Id_Retorna"
                        'For i As Integer = 0 To oGeneral.LstGeneral.Count - 1

                        '    oCombo.Items.Add(New ListViewItem(oGeneral.LstGeneral(i).Descripcion_Retorna, oGeneral.LstGeneral(i).Id_Retorna))
                        'Next
                        ' lCombo.SelectedIndex = 0
                    ElseIf vintTipo = enumTipoComboGrilla.IdCodigo Then
                        'For i As Integer = 0 To oGeneral.LstGeneral.Count - 1
                        '    oCombo.Items.Add(New ListViewItem(oGeneral.LstGeneral(i).Codigo_Retorna, oGeneral.LstGeneral(i).Id_Retorna))
                        'Next
                        oChecklistb.DataSource = oGeneral.LstGeneral
                        oChecklistb.DisplayMember = "Codigo_Retorna"
                        oChecklistb.ValueMember = "Id_Retorna"
                    ElseIf vintTipo = enumTipoComboGrilla.IDCodigoDescripcion Or vintTipo = enumTipoComboGrilla.IDDescripcionCodigo Then
                        'For i As Integer = 0 To oGeneral.LstGeneral.Count - 1
                        '    oCombo.Items.Add(New ListViewItem(oGeneral.LstGeneral(i).CodigoDescripcion_Retorna, oGeneral.LstGeneral(i).Id_Retorna))
                        'Next
                        oChecklistb.DataSource = oGeneral.LstGeneral
                        oChecklistb.DisplayMember = "CodigoDescripcion_Retorna"
                        oChecklistb.ValueMember = "Id_Retorna"

                        For i As Integer = 0 To oGeneral.LstGeneral.Count - 1
                            oChecklistb.SetItemChecked(i, True)
                        Next

                    End If
                End If
            End With
        End Sub

        Public Shared Sub Obtener_ParametrosComboSP(ByVal oCombo As ComboBox, ByVal strTabla As Object)
            Dim oBC_TablaDetRO As New clsBC_TablaDetRO

            Select Case strTabla
                Case "MES"
                    oBC_TablaDetRO.LeerListaToDSMes()
                    oCombo.DataSource = oBC_TablaDetRO.oDSTablaDet.Tables(0)

                    oCombo.DisplayMember = "DESCRIPCION"
                    oCombo.ValueMember = "CODIGO"

                Case "ANIO"
                    oBC_TablaDetRO.LeerListaToDSAnio()
                    oCombo.DataSource = oBC_TablaDetRO.oDSTablaDet.Tables(0)

                    oCombo.DisplayMember = "DESCRIPCION"
                    oCombo.ValueMember = "CODIGO"
            End Select
        End Sub


        'Metodos para cargar los combos de enproyecDB
        Public Shared Sub Obtener_ParametrosComboEN(ByVal oCombo As ComboBox, ByVal strTabla As Object)
            Dim oBC_COM_DEPOSITOSRO As New clsBC_COM_DEPOSITOSRO
            Dim oBC_PUB_PERSONASRO As New clsBC_PUB_PERSONASRO

            Dim oBC_TB_LOCALIDADRO As New clsBC_TB_LOCALIDADRO

            'Dim strPrimerValor As String = ""
            'Select Case lPrimerValor
            '    Case enumPrimerValorCombo.Seleccione
            '        strPrimerValor = "[Seleccione]"
            '    Case enumPrimerValorCombo.Todos
            '        strPrimerValor = "[Todos]"
            'End Select

            Select Case strTabla
                Case "COM_DEPOSITOS"

                    oBC_COM_DEPOSITOSRO.LeerListaCOM_DEPOSITOS()
                    oCombo.DataSource = oBC_COM_DEPOSITOSRO.LstCOM_DEPOSITOS

                    oCombo.DisplayMember = "NOM_DEPOSITO"
                    oCombo.ValueMember = "COD_DEPOSITO"

                Case "TB_LOCALIDAD"

                    oBC_TB_LOCALIDADRO.LeerListaTB_LOCALIDAD()
                    oCombo.DataSource = oBC_TB_LOCALIDADRO.LstTB_LOCALIDAD

                    oCombo.DisplayMember = "DES_LOCALIDAD"
                    oCombo.ValueMember = "ID_LOCALIDAD"

                Case "PUB_PERSONAS"

                    'oCombo.Items.Add(New ListViewItem("[Seleccione]", ""))
                    Dim oBE_PUB_PERSONAS As New clsBE_PUB_PERSONAS
                    oBE_PUB_PERSONAS.IDPERSONA = ""
                    oBE_PUB_PERSONAS.RAZON_SOCIAL = "[Seleccione]"

                    oBC_PUB_PERSONASRO.LstPUB_PERSONAS.Add(oBE_PUB_PERSONAS)
                    oBC_PUB_PERSONASRO.LeerListaPUB_PERSONAS()
                    oCombo.DataSource = oBC_PUB_PERSONASRO.LstPUB_PERSONAS
                    'oBC_COM_DEPOSITOSRO.LstCOM_DEPOSITOS.Add(New ListViewItem("[Seleccione]", "")

                    oCombo.DisplayMember = "RAZON_SOCIAL"
                    oCombo.ValueMember = "IDPERSONA"

            End Select

        End Sub

        Public Shared Sub Obtener_ParametrosCombo(ByVal oCombo As ToolStripComboBox, ByVal strTabla As String, _
Optional ByVal lPrimerValor As enumPrimerValorCombo = enumPrimerValorCombo.Seleccione, _
Optional ByVal vintTipo As enumTipoComboGrilla = enumTipoComboGrilla.IdDescripcion)
            Dim oGeneral As New clsBC_GeneralRO
            Dim strPrimerValor As String = ""
            Select Case lPrimerValor
                Case enumPrimerValorCombo.Seleccione
                    strPrimerValor = "[Seleccione]"
                Case enumPrimerValorCombo.Todos
                    strPrimerValor = "[Todos]"
            End Select
            With oGeneral.oBEGeneral
                oGeneral.oBEGeneral.NomTabla = strTabla
                oGeneral.oBEGeneral.PrimerValor = strPrimerValor
                oGeneral.LstGeneral.Clear()
                oGeneral.Obtener_Parametros()
                oCombo.Items.Clear()
                oCombo.Items.Clear()
                oCombo.Items.Add(New ListViewItem(strPrimerValor, ""))
                If Not oGeneral Is Nothing Then
                    If oGeneral.LstGeneral.Count > 0 Then
                        If vintTipo = enumTipoComboGrilla.IdDescripcion Then
                            oCombo.ComboBox.DataSource = oGeneral.LstGeneral
                            oCombo.ComboBox.DisplayMember = "Descripcion_Retorna"
                            oCombo.ComboBox.ValueMember = "Id_Retorna"
                            'For i As Integer = 0 To oGeneral.LstGeneral.Count - 1
                            '    oCombo.Items.Add(
                            '    oCombo.Items.Add(New ListViewItem(oGeneral.LstGeneral(i).Descripcion_Retorna, oGeneral.LstGeneral(i).Id_Retorna))
                            'Next
                            oCombo.SelectedIndex = 0
                        ElseIf vintTipo = enumTipoComboGrilla.IdCodigo Then
                            oCombo.ComboBox.DataSource = oGeneral.LstGeneral
                            oCombo.ComboBox.DisplayMember = "Codigo_Retorna"
                            oCombo.ComboBox.ValueMember = "Id_Retorna"
                            'For i As Integer = 0 To oGeneral.LstGeneral.Count - 1
                            '    oCombo.Items.Add(New ListViewItem(oGeneral.LstGeneral(i).Codigo_Retorna, oGeneral.LstGeneral(i).Id_Retorna))
                            'Next
                            oCombo.SelectedIndex = 0
                        ElseIf vintTipo = enumTipoComboGrilla.IDCodigoDescripcion Or vintTipo = enumTipoComboGrilla.IDDescripcionCodigo Then
                            oCombo.ComboBox.DataSource = oGeneral.LstGeneral
                            oCombo.ComboBox.DisplayMember = "CodigoDescripcion_Retorna"
                            oCombo.ComboBox.ValueMember = "Id_Retorna"
                            'For i As Integer = 0 To oGeneral.LstGeneral.Count - 1
                            '    oCombo.Items.Add(New ListViewItem(oGeneral.LstGeneral(i).CodigoDescripcion_Retorna, oGeneral.LstGeneral(i).Id_Retorna))
                            'Next
                            oCombo.SelectedIndex = 0
                        End If
                    End If

                End If
            End With
        End Sub
        Public Shared Function Obtener_Correlativo(ByVal strTabla As String, ByVal campoID As String, Optional ByVal nomCampo As String = "", Optional ByVal valCampo As String = "", Optional ByVal nomCampo2 As String = "", Optional ByVal valCampo2 As String = "")
            Dim oGeneral As New clsBC_GeneralRO
            Dim strPrimerValor As String = ""
            With oGeneral.oBEGeneral
                oGeneral.oBEGeneral.NomTabla = strTabla
                oGeneral.oBEGeneral.Id_Retorna = campoID
                oGeneral.oBEGeneral.NomCampo1 = nomCampo
                oGeneral.oBEGeneral.ValCampo1 = valCampo
                oGeneral.oBEGeneral.NomCampo2 = nomCampo2
                oGeneral.oBEGeneral.ValCampo2 = valCampo2
                oGeneral.LstGeneral.Clear()
                Return oGeneral.Obtener_Correlativo()
            End With
        End Function
        Public Shared Function Obtener_Correlativo(ByVal tipoCorrelativo As enumTipoCorrelativo)
            Select Case tipoCorrelativo
                Case enumTipoCorrelativo.Contrato
                    Return Obtener_Correlativo("tbContratoLote", "contratoLoteId")

                Case enumTipoCorrelativo.Lote
                    Return Obtener_Correlativo("tbContratoLote", "contratoLoteId")

            End Select
            Return ""
        End Function
        Public Shared Sub Obtener_RegistrosCombo(ByVal oCombo As ComboBox, ByVal strTabla As String, _
  ByVal pIdRetorna As String, ByVal pDescRetorna As String, ByVal pCodigo As String, _
Optional ByVal lPrimerValor As enumPrimerValorCombo = enumPrimerValorCombo.Seleccione, _
Optional ByVal NomCampo1 As String = "", Optional ByVal ValCampo1 As String = "", _
Optional ByVal NomCampo2 As String = "", Optional ByVal ValCampo2 As String = "", _
Optional ByVal vintTipo As enumTipoComboGrilla = enumTipoComboGrilla.IdDescripcion)
            Dim oGeneral As New clsBC_GeneralRO
            Dim strPrimerValor As String = ""
            Select Case lPrimerValor
                Case enumPrimerValorCombo.Seleccione
                    strPrimerValor = "[Seleccione]"
                Case enumPrimerValorCombo.Todos
                    strPrimerValor = "[Todos]"
            End Select
            With oGeneral.oBEGeneral
                oGeneral.oBEGeneral.NomTabla = strTabla
                oGeneral.oBEGeneral.Id_Retorna = pIdRetorna
                oGeneral.oBEGeneral.Descripcion_Retorna = pDescRetorna
                oGeneral.oBEGeneral.Codigo_Retorna = pCodigo
                oGeneral.oBEGeneral.PrimerValor = strPrimerValor
                oGeneral.oBEGeneral.NomCampo1 = NomCampo1
                oGeneral.oBEGeneral.ValCampo1 = ValCampo1
                oGeneral.oBEGeneral.NomCampo2 = NomCampo2
                oGeneral.oBEGeneral.ValCampo2 = ValCampo2
                oGeneral.LstGeneral.Clear()

                oGeneral.Obtener_Registros()
                oCombo.Items.Clear()
                oCombo.Items.Add(New ListViewItem(strPrimerValor, ""))
                With oCombo
                    If Not oGeneral Is Nothing Then
                        If vintTipo = enumTipoComboGrilla.IdDescripcion Then
                            oCombo.DataSource = oGeneral.LstGeneral
                            oCombo.DisplayMember = "codigodescripcion"
                            oCombo.ValueMember = "Id_Retorna"
                        ElseIf vintTipo = enumTipoComboGrilla.IdCodigo Then
                            oCombo.DataSource = oGeneral.LstGeneral
                            oCombo.DisplayMember = "codigodescripcion"
                            oCombo.ValueMember = "Id_Retorna"

                        ElseIf vintTipo = enumTipoComboGrilla.IDCodigoDescripcion Or vintTipo = enumTipoComboGrilla.IDDescripcionCodigo Then
                            oCombo.DataSource = oGeneral.LstGeneral
                            oCombo.DisplayMember = "codigodescripcion"
                            oCombo.ValueMember = "Id_Retorna"

                        End If
                    End If
                End With

            End With
        End Sub

        '@01    AINI
        Public Shared Sub Obtener_RegistrosComboToValidacionCTB(ByVal oCombo As ComboBox, ByVal strTabla As String, _
            ByVal pIdRetorna As String, ByVal pDescRetorna As String, ByVal pCodigo As String, _
            Optional ByVal lPrimerValor As enumPrimerValorCombo = enumPrimerValorCombo.Seleccione, _
            Optional ByVal NomCampo1 As String = "", Optional ByVal ValCampo1 As String = "", _
            Optional ByVal NomCampo2 As String = "", Optional ByVal ValCampo2 As String = "", _
            Optional ByVal vintTipo As enumTipoComboGrilla = enumTipoComboGrilla.IdDescripcion)

            Dim cboTemp As New ComboBox
            Obtener_RegistrosCombo(cboTemp, "tbTabla", "tablaId", "descri", "tablaId", enumPrimerValorCombo.Seleccione, "codigoVisible", "True")

            Dim listVal = CType(cboTemp.DataSource, List(Of SI.BE.clsBE_General))
            listVal.RemoveAll(Function(b) b.Id_Retorna = "ValidacionCTB")

            oCombo.Items.Clear()
            oCombo.DataSource = listVal
            oCombo.DisplayMember = "codigodescripcion"
            oCombo.ValueMember = "Id_Retorna"
        End Sub
        '@01    AFIN

        Public Shared Sub Obtener_ParametrosC1Combo(ByVal oCombo As C1.Win.C1List.C1Combo, ByVal strTabla As String, _
Optional ByVal lPrimerValor As enumPrimerValorCombo = enumPrimerValorCombo.Seleccione, _
Optional ByVal vintTipo As enumTipoComboGrilla = enumTipoComboGrilla.IdDescripcion)
            Dim oGeneral As New clsBC_GeneralRO
            Dim strPrimerValor As String = ""
            Select Case lPrimerValor
                Case enumPrimerValorCombo.Seleccione
                    strPrimerValor = "[Seleccione]"
                Case enumPrimerValorCombo.Todos
                    strPrimerValor = "[Todos]"
            End Select
            With oGeneral.oBEGeneral
                oGeneral.oBEGeneral.NomTabla = strTabla
                oGeneral.oBEGeneral.PrimerValor = strPrimerValor
                oGeneral.LstGeneral.Clear()
                oGeneral.Obtener_Parametros_resultado()

                oCombo.Text = "Seleccione " & strTabla
                'If Not oGeneral Is Nothing Then
                '    If vintTipo = enumTipoComboGrilla.IdDescripcion Then
                oCombo.DataSource = oGeneral.LstGeneralResultado
                oCombo.DisplayMember = "Descripcion_Retorna"
                oCombo.ValueMember = "codigo_retorna"
                oCombo.Columns(0).Caption = "Codigo"
                oCombo.Columns(1).Caption = "Descripcion"
            End With
        End Sub

        Public Shared Function GenericListToDataTable(ByVal list As Object) As DataTable
            Dim dt As DataTable = Nothing
            Dim listType As Type = list.GetType
            If listType.IsGenericType Then
                'determine the underlying type the List<> contains 
                Dim elementType As Type = listType.GetGenericArguments(0)
                'create empty table -- give it a name in case 
                'it needs to be serialized 
                dt = New DataTable((elementType.Name + "List"))
                'define the table -- add a column for each public 
                'property or field 
                Dim miArray() As MemberInfo = elementType.GetMembers((BindingFlags.Public Or BindingFlags.Instance))
                For Each mi As MemberInfo In miArray
                    If (mi.MemberType = MemberTypes.Property) Then
                        Dim pi As PropertyInfo = CType(mi, PropertyInfo)
                        dt.Columns.Add(pi.Name, pi.PropertyType)
                    ElseIf (mi.MemberType = MemberTypes.Field) Then
                        Dim fi As FieldInfo = CType(mi, FieldInfo)
                        dt.Columns.Add(fi.Name, fi.FieldType)
                    End If
                Next
                'populate the table 
                Dim il As IList = CType(list, IList)
                For Each record As Object In il
                    Dim i As Integer = 0
                    Dim fieldValues() As Object = New Object((dt.Columns.Count) - 1) {}
                    For Each c As DataColumn In dt.Columns
                        Dim mi As MemberInfo = elementType.GetMember(c.ColumnName)(0)
                        If (mi.MemberType = MemberTypes.Property) Then
                            Dim pi As PropertyInfo = CType(mi, PropertyInfo)
                            fieldValues(i) = pi.GetValue(record, Nothing)
                        ElseIf (mi.MemberType = MemberTypes.Field) Then
                            Dim fi As FieldInfo = CType(mi, FieldInfo)
                            fieldValues(i) = fi.GetValue(record)
                        End If
                        i = (i + 1)
                    Next
                    dt.Rows.Add(fieldValues)
                Next
            End If
            Return dt
        End Function
        Public Shared Sub Obtener_ParametrosGridView(ByVal lCombo As DataGridViewComboBoxColumn, ByVal strTabla As String, _
   Optional ByVal lPrimerValor As enumPrimerValorCombo = enumPrimerValorCombo.Ninguno, _
   Optional ByVal vintTipo As enumTipoComboGrilla = enumTipoComboGrilla.IdDescripcion, Optional ByVal sParametro1 As String = "", Optional ByVal sParametro2 As String = "")

            Dim strPrimerValor As String = ""
            Select Case lPrimerValor
                Case enumPrimerValorCombo.Seleccione
                    strPrimerValor = "[Seleccione]"
                Case enumPrimerValorCombo.Todos
                    strPrimerValor = "[Todos]"
                Case enumPrimerValorCombo.Vacio
                    strPrimerValor = ""
            End Select




            Select Case strTabla

                Case Else
                    Dim oGeneral As New clsBC_GeneralRO
                    With oGeneral.oBEGeneral
                        oGeneral.oBEGeneral.NomTabla = strTabla
                        oGeneral.oBEGeneral.PrimerValor = strPrimerValor
                        oGeneral.LstGeneral.Clear()
                        oGeneral.Obtener_Parametros()
                        lCombo.DataSource = oGeneral.LstGeneral
                        lCombo.DisplayMember = "descripcion_retorna"
                        lCombo.ValueMember = "Id_Retorna"
                        'For Each item As clsBE_General In oGeneral.LstGeneral
                        '    lCombo.Items.Add(New clsCombo(item.Descripcion_Retorna, item.Codigo_Retorna))
                        'Next
                        'If Not oGeneral Is Nothing Then

                        '    If vintTipo = enumTipoComboGrilla.IdDescripcion Then
                        '        lCombo.DataSource = oGeneral.LstGeneral
                        '        lCombo.DisplayMember = "codigodescripcion"
                        '        lCombo.ValueMember = "Id_Retorna"
                        '    ElseIf vintTipo = enumTipoComboGrilla.IdCodigo Then
                        '        lCombo.DataSource = oGeneral.LstGeneral
                        '        lCombo.DisplayMember = "codigodescripcion"
                        '        lCombo.ValueMember = "Id_Retorna"

                        '    ElseIf vintTipo = enumTipoComboGrilla.IDCodigoDescripcion Or vintTipo = enumTipoComboGrilla.IDDescripcionCodigo Then
                        '        lCombo.DataSource = oGeneral.LstGeneral
                        '        lCombo.DisplayMember = "codigodescripcion"
                        '        lCombo.ValueMember = "Id_Retorna"

                        '    End If

                        'End If
                    End With
            End Select



        End Sub





        Public Shared Sub Obtener_ParametrosGridViewQuitar(ByVal lCombo As DataGridViewComboBoxColumn, ByVal strTabla As String, _
   Optional ByVal lPrimerValor As enumPrimerValorCombo = enumPrimerValorCombo.Ninguno, _
   Optional ByVal vintTipo As enumTipoComboGrilla = enumTipoComboGrilla.IdDescripcion, Optional ByVal sParametro1 As String = "", Optional ByVal sParametro2 As String = "")

            Dim strPrimerValor As String = ""
            Select Case lPrimerValor
                Case enumPrimerValorCombo.Seleccione
                    strPrimerValor = "[Seleccione]"
                Case enumPrimerValorCombo.Todos
                    strPrimerValor = "[Todos]"
                Case enumPrimerValorCombo.Vacio
                    strPrimerValor = ""
            End Select

            Dim oGeneral As New clsBC_GeneralRO
            With oGeneral.oBEGeneral
                oGeneral.oBEGeneral.NomTabla = strTabla
                oGeneral.oBEGeneral.PrimerValor = strPrimerValor
                oGeneral.oBEGeneral.NomCampo1 = sParametro1
                oGeneral.LstGeneral.Clear()
                oGeneral.Obtener_Parametros()
                lCombo.DataSource = oGeneral.LstGeneral
                lCombo.DisplayMember = "descripcion_retorna"
                lCombo.ValueMember = "Id_Retorna"

            End With

        End Sub


        Public Shared Sub Obtener_ParametrosGridViewCampos(ByVal lCombo As DataGridViewComboBoxColumn, ByVal strTabla As String, _
   Optional ByVal lPrimerValor As enumPrimerValorCombo = enumPrimerValorCombo.Seleccione, _
   Optional ByVal sOrden As String = "3", Optional ByVal sDisplayMember As String = "Descripcion_Retorna", Optional ByVal sValueMember As String = "Id_Retorna")
            'Optional ByVal vintTipo As enumTipoComboGrilla = enumTipoComboGrilla.IdDescripcion, _
            'Optional ByVal sParametro1 As String = "", Optional ByVal sParametro2 As String = "")

            Dim strPrimerValor As String = ""
            Select Case lPrimerValor
                Case enumPrimerValorCombo.Seleccione
                    strPrimerValor = "[Seleccione]"
                Case enumPrimerValorCombo.Todos
                    strPrimerValor = "[Todos]"
                Case enumPrimerValorCombo.Vacio
                    strPrimerValor = ""
            End Select

            Select Case strTabla

                Case Else
                    Dim oGeneral As New clsBC_GeneralRO
                    With oGeneral.oBEGeneral
                        oGeneral.oBEGeneral.NomTabla = strTabla
                        oGeneral.oBEGeneral.PrimerValor = strPrimerValor
                        oGeneral.oBEGeneral.CamposOrder = sOrden
                        oGeneral.LstGeneral.Clear()
                        oGeneral.Obtener_Parametros()
                        lCombo.DataSource = oGeneral.LstGeneral
                        'lCombo.DisplayMember = "descripcion_retorna"
                        'lCombo.ValueMember = "Id_Retorna"

                        lCombo.DisplayMember = sDisplayMember '"Descripcion_Retorna"
                        lCombo.ValueMember = sValueMember '"Id_Retorna"
                    End With
            End Select

        End Sub

    End Class

End Namespace
