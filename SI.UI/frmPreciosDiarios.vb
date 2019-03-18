Imports SI.PL.clsFuncion
Imports SI.PL.clsGeneral
Imports SI.PL.clsProcedimientos
Imports SI.UT
Imports SI.BC
Imports System.Data
Imports System.Drawing.Drawing2D
Imports SI.BE
Imports SI.UT.clsUT_Enumerado
Imports System.Configuration

Imports Microsoft.Reporting.WinForms

Imports Microsoft.Office.Interop.Excel

Public Class frmPreciosDiarios

    Private oMensajeError As mensajeError = New mensajeError
    Private nPrecio_Diario As Integer


    Private dt As New System.Data.DataTable()
    Private SqlDataAdapter As System.Data.SqlClient.SqlDataAdapter


    Private Sub frmPrecio_Diario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ConfiguraForm(Me)

        dgxPrecio_Diario.AutoGenerateColumns = False
        fdxPreciosMensuales.AutoGenerateColumns = False
       

        CargarParametros()

        ObtenerRegistros()

    End Sub

    Private Sub CargarParametros()
        Try

            Obtener_ParametrosCombo(cboElemento, clsUT_Dominio.domMETAL, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            dtpFecha.Text = Now '.Today.ToString

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Private Sub ObtenerRegistros()
        Limpiar()

        Dim dsPrecio_DiarioRO As DataSet

        Dim oBC_Precio_DiarioRO As New clsBC_Precio_DiarioRO
        oBC_Precio_DiarioRO.LeerListaToDSPrecio_Diario_SelAll()
        dsPrecio_DiarioRO = oBC_Precio_DiarioRO.oDSPrecio_Diario
        dgxPrecio_Diario.DataSource = dsPrecio_DiarioRO.Tables(0)

        oBC_Precio_DiarioRO = New clsBC_Precio_DiarioRO
        oBC_Precio_DiarioRO.LeerListaToDSPrecio_Diario_SelAll("M")
        dsPrecio_DiarioRO = oBC_Precio_DiarioRO.oDSPrecio_Diario
        fdxPreciosMensuales.DataSource = dsPrecio_DiarioRO.Tables(0)

    End Sub

    Private Sub tsbConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       ObtenerRegistros
    End Sub


    Private Sub GuardarRegistro()
        Dim oBC_Precio_DiarioTX As New clsBC_Precio_DiarioTX
        oBC_Precio_DiarioTX.oBEPrecio_Diario = New clsBE_Precio_Diario

        oBC_Precio_DiarioTX.oBEPrecio_Diario.IdPrecioDiario = txtIdPrecioDiario.Text

        oBC_Precio_DiarioTX.oBEPrecio_Diario.fecha = dtpFecha.Text

        oBC_Precio_DiarioTX.oBEPrecio_Diario.elemento = cboElemento.SelectedValue
        oBC_Precio_DiarioTX.oBEPrecio_Diario.precio1 = txtPrecio1.Text
        oBC_Precio_DiarioTX.oBEPrecio_Diario.precio2 = txtPrecio2.Text
        oBC_Precio_DiarioTX.oBEPrecio_Diario.precio3 = txtPrecio3.Text
        oBC_Precio_DiarioTX.oBEPrecio_Diario.precio4 = txtPrecio4.Text
        oBC_Precio_DiarioTX.oBEPrecio_Diario.calculado1 = txtCalculado1.Text
        oBC_Precio_DiarioTX.oBEPrecio_Diario.calculado2 = txtCalculado2.Text
        oBC_Precio_DiarioTX.oBEPrecio_Diario.calculado3 = txtCalculado3.Text
        oBC_Precio_DiarioTX.oBEPrecio_Diario.calculado4 = txtCalculado4.Text

        oBC_Precio_DiarioTX.oBEPrecio_Diario.uc = pBEUsuario.tablaDetId
        oBC_Precio_DiarioTX.oBEPrecio_Diario.um = pBEUsuario.tablaDetId

        Dim bEstado As Boolean
        If txtIdPrecioDiario.Text = 0 Then
            bEstado = oBC_Precio_DiarioTX.InsertarPrecio_Diario()
        Else
            bEstado = oBC_Precio_DiarioTX.ModificarPrecio_Diario()
        End If

        If bEstado Then
            MsgBox("El registro se guardó satisfactoriamente", MsgBoxStyle.Information, "Valorizador Comercial de Minerales")
        Else
            MsgBox("El registro NO se guardó satisfactoriamente", MsgBoxStyle.Exclamation, "Valorizador Comercial de Minerales")
        End If


    End Sub


    Private Sub Exportar(ByVal dgvGrid As C1.Win.C1FlexGrid.C1FlexGrid)
        Try
            sfdSaveFileDialog.Filter = "Hojas de Excel|*.xls"
            sfdSaveFileDialog.FileName = "Precio Diario"

            If sfdSaveFileDialog.ShowDialog = DialogResult.OK Then
                'fxgrdPrecio_DiarioExport.SaveExcel(sfdSaveFileDialog.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
                dgxPrecio_Diario.SaveExcel(sfdSaveFileDialog.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)

                Dim processInfo As New ProcessStartInfo("explorer.exe", sfdSaveFileDialog.FileName)
                Process.Start(processInfo)
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub




    Private Sub Limpiar()

        txtIdPrecioDiario.Text = 0
        dtpFecha.Text = Now

        cboElemento.SelectedIndex = 0

        txtPrecio1.Text = 0
        txtPrecio2.Text = 0
        txtPrecio3.Text = 0
        txtPrecio4.Text = 0
        txtCalculado1.Text = 0
        txtCalculado2.Text = 0
        txtCalculado3.Text = 0
        txtCalculado4.Text = 0

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False

        txtuc.Text = ""
        txtfc.Text = ""
        txtum.Text = ""
        txtfm.Text = ""

    End Sub

    Private Sub tsbNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNuevo.Click
        Limpiar()
    End Sub

    Private Sub tsbRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRefrescar.Click
        ObtenerRegistros()
    End Sub


    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        If cboElemento.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar Elemento Mineral.", MsgBoxStyle.Exclamation, "Valorizador Comercial de Minerales")
            Exit Sub
        End If

        GuardarRegistro()

        ObtenerRegistros()

    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarDiario.Click
        Exportar(dgxPrecio_Diario)
    End Sub

    Private Sub tsbAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAnular.Click
        Dim oBC_Precio_DiarioTX As New clsBC_Precio_DiarioTX
        oBC_Precio_DiarioTX.oBEPrecio_Diario = New clsBE_Precio_Diario

        oBC_Precio_DiarioTX.oBEPrecio_Diario.IdPrecioDiario = txtIdPrecioDiario.Text


        Dim bEstado As Boolean

        bEstado = oBC_Precio_DiarioTX.EliminaPrecio_Diario()
      

        If bEstado Then
            MsgBox("El registro se anuló satisfactoriamente", MsgBoxStyle.Information, "Valorizador Comercial de Minerales")
        Else
            MsgBox("El registro NO se anuló satisfactoriamente", MsgBoxStyle.Exclamation, "Valorizador Comercial de Minerales")
        End If

        ObtenerRegistros()
    End Sub


    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Dispose()
    End Sub



    Private Sub dgxPrecio_Diario_SelChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgxPrecio_Diario.SelChange
        If dgxPrecio_Diario.RowSel >= 0 Then
            seleccionarRegistro()
        End If

    End Sub


    Private Sub seleccionarRegistro()
        Limpiar()

        Dim nActivo As Integer

        Dim dsPrecio_DiarioRO As DataSet

        Dim oBC_Precio_DiarioRO As New clsBC_Precio_DiarioRO
        oBC_Precio_DiarioRO.oBEPrecio_Diario = New clsBE_Precio_Diario
        oBC_Precio_DiarioRO.oBEPrecio_Diario.IdPrecioDiario = dgxPrecio_Diario.Rows(dgxPrecio_Diario.RowSel).Item("IdPrecioDiario")
        oBC_Precio_DiarioRO.LeerListaPrecio_Diario_Sel(oBC_Precio_DiarioRO.oBEPrecio_Diario)
        dsPrecio_DiarioRO = oBC_Precio_DiarioRO.oDSPrecio_Diario

        txtIdPrecioDiario.Text = dsPrecio_DiarioRO.Tables(0).Rows(0)("IdPrecioDiario").ToString
        dtpFecha.Text = dsPrecio_DiarioRO.Tables(0).Rows(0)("fecha").ToString
        cboElemento.SelectedValue = dsPrecio_DiarioRO.Tables(0).Rows(0)("elemento").ToString
        txtPrecio_oficial.Text = FormatNumber(dsPrecio_DiarioRO.Tables(0).Rows(0)("precio_oficial").ToString, 2)
        txtPrecio1.Text = FormatNumber(dsPrecio_DiarioRO.Tables(0).Rows(0)("precio1").ToString, 2)
        txtPrecio2.Text = FormatNumber(dsPrecio_DiarioRO.Tables(0).Rows(0)("precio2").ToString, 2)
        txtPrecio3.Text = FormatNumber(dsPrecio_DiarioRO.Tables(0).Rows(0)("precio3").ToString, 2)
        txtPrecio4.Text = FormatNumber(dsPrecio_DiarioRO.Tables(0).Rows(0)("precio4").ToString, 2)
        txtCalculado1.Text = FormatNumber(dsPrecio_DiarioRO.Tables(0).Rows(0)("calculado1").ToString, 2)
        txtCalculado2.Text = FormatNumber(dsPrecio_DiarioRO.Tables(0).Rows(0)("calculado2").ToString, 2)
        txtCalculado3.Text = FormatNumber(dsPrecio_DiarioRO.Tables(0).Rows(0)("calculado3").ToString, 2)
        txtCalculado4.Text = FormatNumber(dsPrecio_DiarioRO.Tables(0).Rows(0)("calculado4").ToString, 2)
        nActivo = dsPrecio_DiarioRO.Tables(0).Rows(0)("activo")


        Select Case nActivo
            Case 1
                CheckBox1.Checked = True
            Case 2
                CheckBox2.Checked = True
            Case 3
                CheckBox3.Checked = True
            Case 4
                CheckBox4.Checked = True
            Case 5
                CheckBox5.Checked = True
            Case 6
                CheckBox6.Checked = True
            Case 7
                CheckBox7.Checked = True
            Case 8
                CheckBox8.Checked = True
        End Select


        txtuc.Text = dsPrecio_DiarioRO.Tables(0).Rows(0)("usu_cre").ToString
        txtfc.Text = dsPrecio_DiarioRO.Tables(0).Rows(0)("fc").ToString
        txtum.Text = dsPrecio_DiarioRO.Tables(0).Rows(0)("usu_mod").ToString
        txtfm.Text = dsPrecio_DiarioRO.Tables(0).Rows(0)("fm").ToString
    End Sub


    'BindingSource  
    Private WithEvents bs As New BindingSource

   

    

    ' flag  
    Private bEdit As Boolean

   


    Private Sub cargar_registros()

        Try

            Dim oBC_Precio_DiarioTX As New clsBC_Precio_DiarioTX
            oBC_Precio_DiarioTX.SqlDataAdapter = SqlDataAdapter
            oBC_Precio_DiarioTX.dtPrecio_Diario = dt
            dt = oBC_Precio_DiarioTX.MasivoPrecio_Diario()

            SqlDataAdapter = oBC_Precio_DiarioTX.SqlDataAdapter

            bs.DataSource = dt

            ''dt.Clear()
            ' ''Dim dv As DataGridView
            ''Dim Sql As String = "select  * from tbprecio_diario WHERE TIPO = 'a'"
            ' '' Inicializar el SqlDataAdapter indicandole el comando y el connection string  
            ''SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(Sql, cs)

            ''Dim SqlCommandBuilder As New System.Data.SqlClient.SqlCommandBuilder(SqlDataAdapter)
            ''SqlDataAdapter.Fill(dt)

            ' '' Enlazar el BindingSource con el datatable anterior  
            ' '' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''  
            ''bs.DataSource = dt

            ''With dgvPrecio_Diario_Masivo
            ''    .Refresh()
            ''End With

        Catch exSql As System.Data.SqlClient.SqlException
            MsgBox(exSql.Message.ToString)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

   


    Public Sub PasteData(ByRef dgv As DataGridView)
        Dim tArr() As String
        Dim arT() As String
        Dim i, ii As Integer
        Dim c, cc, r As Integer

        tArr = Clipboard.GetText().Trim().Split(Environment.NewLine)  '!!! Added Trim() ...because when pasting from vb App

        r = dgv.CurrentCellAddress.Y()     'this is easier
        c = dgv.CurrentCellAddress.X()


        While (tArr.Length >= (dgv.Rows.Count - r))
            Dim row As DataRow = dt.NewRow

            row("tipo") = "D"
            row("uc") = pBEUsuario.tablaDetId

            dt.Rows.Add(row)
        End While

        dt.AcceptChanges()
        dgv.DataSource = dt
        'dgv.Rows.Add(tArr.Length - (dgv.Rows.Count - r)) 'check length of the clipboard and the datagridview

        For i = 0 To tArr.Length - 1
            If tArr(i) <> "" Then
                arT = tArr(i).Split(vbTab)
                cc = c
                For ii = 0 To arT.Length - 1
                    If cc > dgv.ColumnCount - 1 Then Exit For
                    If r > dgv.Rows.Count - 1 Then Exit Sub
                    With dgv.Item(cc, r)
                        .Value = arT(ii).TrimStart                        
                    End With
                    cc = cc + 1
                Next
                r = r + 1
            End If
        Next
    End Sub


    Private Sub tsbLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'SqlDataAdapter = New SqlClient.SqlDataAdapter
        dt.Clear()

        cargar_registros()
    End Sub



    Private Sub tsbCargaMasiva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCargaMasiva.Click


        ' Create new Application.
        Dim excel As Application = New Application

        Dim sElemento As String = ""
        Dim dFecha As Date

        Dim dPrecio1 As Decimal = 0
        Dim dPrecio2 As Decimal = 0
        Dim dPrecio3 As Decimal = 0
        Dim dPrecio4 As Decimal = 0

        ofdCargaExcel.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*xls)|*.xls|All Files (*.*)|*.*"
        ofdCargaExcel.FileName = "Precio.xls"

        ofdCargaExcel.ShowDialog()
        If ofdCargaExcel.FileName <> "Precio.xls" Then


            ' Open Excel spreadsheet.
            'Dim w As Workbook = excel.Workbooks.Open("F:\Informations\Fase II\Precios Diarios\precios.xlsx")
            Dim w As Workbook = excel.Workbooks.Open(ofdCargaExcel.FileName)

            ' Loop over all sheets.
            'For i As Integer = 1 To w.Sheets.Count

            ' Get sheet.
            Dim sheet As Worksheet = w.Sheets("Official Base") ' obtiene la primera hoja del libro

            ' Get range.
            Dim r As Range = sheet.UsedRange

            ' Load all cells into 2d array.
            Dim array(,) As Object = r.Value(XlRangeValueDataType.xlRangeValueDefault)

            ' Scan the cells.
            If array IsNot Nothing Then
                Console.WriteLine("Length: {0}", array.Length)

                ' Get bounds of the array.
                Dim bound0 As Integer = array.GetUpperBound(0) ' *** cantidad de filas
                Dim bound1 As Integer = 13 'array.GetUpperBound(1) ' *** cantidad de columnas

                'Console.WriteLine("Dimension 0: {0}", bound0)
                'Console.WriteLine("Dimension 1: {0}", bound1)

                ' Loop over all elements.
                For j As Integer = 5 To bound0
                    For x As Integer = 1 To bound1
                        Dim s1 As String = array(j, x)
                        'Console.Write(s1)
                        'Console.Write(" "c)

                        If Not array(j, 1) = Nothing Then
                            If x = 1 Then
                                dFecha = array(j, 1)
                            Else
                                If x = 2 Then
                                    sElemento = "CU"
                                    dPrecio1 = array(j, 2)
                                    dPrecio2 = array(j, 3)
                                    dPrecio3 = array(j, 4)
                                    dPrecio4 = array(j, 5)
                                    guardar(dFecha, sElemento, dPrecio1, dPrecio2, dPrecio3, dPrecio4)
                                    x = 6
                                End If
                                If x = 6 Then
                                    sElemento = "PB"
                                    dPrecio1 = array(j, 6)
                                    dPrecio2 = array(j, 7)
                                    dPrecio3 = array(j, 8)
                                    dPrecio4 = array(j, 9)
                                    guardar(dFecha, sElemento, dPrecio1, dPrecio2, dPrecio3, dPrecio4)
                                    x = 10
                                End If
                                If x = 10 Then
                                    sElemento = "ZN"
                                    dPrecio1 = array(j, 10)
                                    dPrecio2 = array(j, 11)
                                    dPrecio3 = array(j, 12)
                                    dPrecio4 = array(j, 13)
                                    guardar(dFecha, sElemento, dPrecio1, dPrecio2, dPrecio3, dPrecio4)
                                    x = 14
                                End If
                                ''If x = 14 Then
                                ''    sElemento = "AG"
                                ''    dPrecio1 = array(j, 14) / 100
                                ''    dPrecio2 = 0
                                ''    dPrecio3 = 0
                                ''    dPrecio4 = 0
                                ''    guardar(dFecha, sElemento, dPrecio1, dPrecio2, dPrecio3, dPrecio4)
                                ''    x = 15
                                ''End If
                                ''If x = 15 Then
                                ''    sElemento = "AU"
                                ''    dPrecio1 = array(j, 15)
                                ''    dPrecio2 = array(j, 16)
                                ''    dPrecio3 = 0
                                ''    dPrecio4 = 0
                                ''    guardar(dFecha, sElemento, dPrecio1, dPrecio2, dPrecio3, dPrecio4)
                                ''    x = 16
                                ''End If
                            End If
                        Else
                            Exit For
                        End If
                    Next
                    'Console.WriteLine()
                Next
            End If
            'Next






            ' Get sheet.
            sheet = w.Sheets("Official Precious") ' obtiene la primera hoja del libro

            ' Get range.
            r = sheet.UsedRange

            ' Load all cells into 2d array.
            array = r.Value(XlRangeValueDataType.xlRangeValueDefault)

            ' Scan the cells.
            If array IsNot Nothing Then
                Console.WriteLine("Length: {0}", array.Length)

                ' Get bounds of the array.
                Dim bound0 As Integer = array.GetUpperBound(0) ' *** cantidad de filas
                Dim bound1 As Integer = 6 'array.GetUpperBound(1) ' *** cantidad de columnas

                'Console.WriteLine("Dimension 0: {0}", bound0)
                'Console.WriteLine("Dimension 1: {0}", bound1)

                ' Loop over all elements.
                For j As Integer = 5 To bound0
                    For x As Integer = 1 To bound1
                        Dim s1 As String = array(j, x)
                        'Console.Write(s1)
                        'Console.Write(" "c)

                        If Not array(j, 1) = Nothing Then
                            If x = 1 Then
                                dFecha = array(j, 1)
                            Else
                                If x = 2 Then
                                    sElemento = "AG"
                                    dPrecio1 = array(j, 2) / 100
                                    dPrecio2 = 0
                                    dPrecio3 = 0
                                    dPrecio4 = 0
                                    guardar(dFecha, sElemento, dPrecio1, dPrecio2, dPrecio3, dPrecio4)
                                    x = 4
                                End If
                                If x = 4 Then
                                    If Not array(j, 3) Is Nothing Then
                                        sElemento = "AU"

                                        'AM
                                        dFecha = array(j, 3)
                                        dPrecio1 = array(j, 4)
                                        dPrecio2 = 0
                                        dPrecio3 = 0
                                        dPrecio4 = 0
                                        guardar(dFecha, sElemento, dPrecio1, dPrecio2, dPrecio3, dPrecio4)

                                        'PM
                                        If Not array(j, 5) Is Nothing Then
                                            dFecha = array(j, 5)
                                            dPrecio1 = 0
                                            dPrecio2 = array(j, 6)
                                            dPrecio3 = 0
                                            dPrecio4 = 0
                                            guardar(dFecha, sElemento, dPrecio1, dPrecio2, dPrecio3, dPrecio4)
                                        End If
                                        x = 6

                                        Exit For
                                    End If

                                End If
                            End If
                        Else
                            Exit For
                        End If
                    Next
                    'Console.WriteLine()
                Next
            End If
            'Next


            ' Close.
            w.Close(False)

            excel.Quit()

            MsgBox("La carga se realizó satisfactoriamente", MsgBoxStyle.Information, "Valorizador Comercial de Minerales")
            ObtenerRegistros()
        End If


    End Sub


    Private Sub guardar(ByVal dFecha As Date, ByVal sElemento As String, ByVal dPrecio1 As Decimal, ByVal dPrecio2 As Decimal, ByVal dPrecio3 As Decimal, ByVal dPrecio4 As Decimal)
        Dim nValida As Integer
        Dim oBC_Precio_DiarioRO As New clsBC_Precio_DiarioRO
        oBC_Precio_DiarioRO.oBEPrecio_Diario = New clsBE_Precio_Diario
        oBC_Precio_DiarioRO.oBEPrecio_Diario.fecha = dFecha
        oBC_Precio_DiarioRO.oBEPrecio_Diario.elemento = sElemento


        If sElemento <> "AU" Then
            nValida = oBC_Precio_DiarioRO.Precio_Diario_Valida()
        End If

        If nValida = 0 Then
            Dim oBC_Precio_DiarioTX As New clsBC_Precio_DiarioTX
            oBC_Precio_DiarioTX.oBEPrecio_Diario = New clsBE_Precio_Diario

            oBC_Precio_DiarioTX.oBEPrecio_Diario.IdPrecioDiario = 0

            oBC_Precio_DiarioTX.oBEPrecio_Diario.fecha = dFecha

            oBC_Precio_DiarioTX.oBEPrecio_Diario.elemento = sElemento
            oBC_Precio_DiarioTX.oBEPrecio_Diario.precio1 = dPrecio1
            oBC_Precio_DiarioTX.oBEPrecio_Diario.precio2 = dPrecio2
            oBC_Precio_DiarioTX.oBEPrecio_Diario.precio3 = dPrecio3
            oBC_Precio_DiarioTX.oBEPrecio_Diario.precio4 = dPrecio4

            oBC_Precio_DiarioTX.oBEPrecio_Diario.uc = pBEUsuario.tablaDetId
            oBC_Precio_DiarioTX.oBEPrecio_Diario.um = pBEUsuario.tablaDetId

            Dim bEstado As Boolean
            bEstado = oBC_Precio_DiarioTX.InsertarPrecio_Diario()
            ''Dim bEstado As Boolean
            ''If txtIdPrecioDiario.Text = 0 Then
            ''    bEstado = oBC_Precio_DiarioTX.InsertarPrecio_Diario()
            ''Else
            ''    bEstado = oBC_Precio_DiarioTX.ModificarPrecio_Diario()
            ''End If
        End If
    End Sub


    Private Sub tsbExportarMensual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarMensual.Click
        Exportar(fdxPreciosMensuales)
    End Sub

End Class