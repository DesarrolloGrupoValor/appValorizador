Imports SI.BC
Imports SI.BE
Imports SI.PL.clsFuncion

Imports Microsoft.Office.Interop

Public Class frmValidarSaldoFinal

    Private oMensajeError As mensajeError = New mensajeError

    Public sPeriodo As String


    Private Sub frmValidarSaldoFinal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ConfiguraForm(Me)
        dgvSaldoFinal.Rows(0).Selected = True
        dgvValidarSaldoFinal.AutoGenerateColumns = False

        ObtenerPeriodos()

        cboPeriodo.SelectedValue = sPeriodo
    End Sub

    Private Sub ObtenerPeriodos()
        Dim dsPeriodo As DataSet
        Dim oBC_PeriodoRO As New clsBC_PeriodoRO
        dsPeriodo = oBC_PeriodoRO.ObtenerPeriodo()

        cboPeriodo.DataSource = dsPeriodo.Tables(0)
        cboPeriodo.DisplayMember = "periodo"
        cboPeriodo.ValueMember = "periodoId"

    End Sub

    Public Function GetTopLeftSelectedCell(ByVal cells As DataGridViewSelectedCellCollection) As DataGridViewCell
        If Not IsNothing(cells) AndAlso cells.Count > 0 Then
            Dim cellList = (From c In cells.Cast(Of DataGridViewCell)()
                            Order By c.RowIndex, c.ColumnIndex
                            Select c).ToList
            Return cellList(0)
        End If

        Return Nothing
    End Function

    Private Sub fnPegar_Data()
        Dim dgv = dgvSaldoFinal

        If Not IsNothing(dgv) Then
            If dgv.SelectedCells.Count > 0 Then
                Dim rowSplitter = {ControlChars.Cr, ControlChars.Lf}
                Dim columnSplitter = {ControlChars.Tab}
                'Dim topLeftCell = GetTopLeftSelectedCell(dgv.SelectedCells)

                'If Not IsNothing(topLeftCell) Then
                Dim data = Clipboard.GetData(DataFormats.Text)

                If Not IsNothing(data) Then
                    'Dim columnIndex = topLeftCell.ColumnIndex
                    'Dim rowIndex = topLeftCell.RowIndex
                    'Dim columnCount = dgv.Columns.Count
                    'Dim rowCount = dgv.Rows.Count

                    'Split clipboard data into rows
                    Dim rows = data.ToString.Split(rowSplitter, StringSplitOptions.RemoveEmptyEntries)

                    For i = 0 To rows.Length - 1
                        'Split row into cell values
                        Dim values = rows(i).Split(columnSplitter)

                        dgv.Rows.Add(values)

                    Next
                    'End If
                End If
            End If
        End If
    End Sub


    Private Sub tsbPegar_Click(sender As System.Object, e As System.EventArgs) Handles tsbPegar.Click
        fnPegar_Data()
    End Sub

    Private Sub dgvSaldoFinal_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvSaldoFinal.KeyUp

        If e.KeyCode = Keys.V Then
            fnPegar_Data()
        End If

    End Sub

    Private Function Validar()

        Dim strmensaje As String = ""
        Try
            For i = 0 To dgvSaldoFinal.Rows.Count - 1
                If Not (dgvSaldoFinal.Item("precinto", i).Value) = "" Then
                    If Not IsNumeric(dgvSaldoFinal.Item("tmh", i).Value) Then
                        strmensaje = strmensaje & "* " & dgvSaldoFinal.Item("precinto", i).Value & " TMH no es numérico" & Chr(13)
                    End If

                    If Not IsDate(dgvSaldoFinal.Item("fec_ingreso", i).Value) Then
                        strmensaje = strmensaje & "* " & dgvSaldoFinal.Item("precinto", i).Value & " fec.ingreso no tiene formato de fecha" & Chr(13)
                    End If
                End If
            Next
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try

        If strmensaje.Length > 0 Then
            MsgBox("Error en las rumas: " & Chr(13) & strmensaje, MsgBoxStyle.Critical, "Valorizador de Minerales")
            Return False
        End If
        Return True

    End Function

    Private Sub TsbConsultar_Click(sender As System.Object, e As System.EventArgs) Handles TsbConsultar.Click

        Try
            If Validar() Then
                Dim oBC_SaldoFinalRO As New clsBC_SaldoFinalRO
                Dim oBC_SaldoFinalTX As New clsBC_SaldoFinalTX
                Dim oBE_SaldoFinal As New clsBE_SaldoFinal

                'delete
                If Not oBC_SaldoFinalTX.EliminarSaldoFinal() Then
                    MsgBox("Error en eliminación de registros históricos", MsgBoxStyle.Critical, "Valorizador de Minerales")
                    Exit Sub
                End If

                'insert
                For i = 0 To dgvSaldoFinal.RowCount - 2
                    If dgvSaldoFinal.Item("precinto", i).Value <> "" Then
                        oBE_SaldoFinal = New clsBE_SaldoFinal
                        oBE_SaldoFinal.calidad = dgvSaldoFinal.Item("calidad", i).Value
                        oBE_SaldoFinal.precinto = dgvSaldoFinal.Item("precinto", i).Value
                        oBE_SaldoFinal.ruma = dgvSaldoFinal.Item("ruma", i).Value
                        oBE_SaldoFinal.clase = dgvSaldoFinal.Item("clase", i).Value
                        oBE_SaldoFinal.tmh = dgvSaldoFinal.Item("tmh", i).Value
                        oBE_SaldoFinal.fec_ingreso = dgvSaldoFinal.Item("fec_ingreso", i).Value
                        oBE_SaldoFinal.ticket = dgvSaldoFinal.Item("ticket", i).Value

                        oBC_SaldoFinalTX.LstSaldoFinal.Add(oBE_SaldoFinal)
                    End If
                Next

                If Not oBC_SaldoFinalTX.InsertarSaldoFinal() Then
                    MsgBox("Error en carga de registros", MsgBoxStyle.Critical, "Valorizador de Minerales")
                    Exit Sub
                End If

                'select
                oBC_SaldoFinalRO.fnValidaSaldoFinal_Sell(cboPeriodo.SelectedValue)
                dgvValidarSaldoFinal.DataSource = oBC_SaldoFinalRO.oDSSaldoFinal.Tables(0)

                'tcRegistros.SelectTab(tpSaldoFinal)

                'Negrita los totales
                Dim style As New DataGridViewCellStyle()
                style.Font = New Font(dgvValidarSaldoFinal.Font, FontStyle.Bold)
                dgvValidarSaldoFinal.Rows(0).DefaultCellStyle = style

                'Fondo rojo lo que es diferente
                style = New DataGridViewCellStyle()
                style.BackColor = Color.Red

                For i = 0 To dgvValidarSaldoFinal.Rows.Count - 1
                    If dgvValidarSaldoFinal.Item("dgvtxtObs", i).Value.ToString() = "X" And dgvValidarSaldoFinal.Item("dgvtxtPrecinto", i).Value.ToString() <> "" Then

                        For j = 0 To dgvSaldoFinal.Rows.Count - 1
                            If dgvValidarSaldoFinal.Item("dgvtxtPrecinto", i).Value = dgvSaldoFinal.Item("precinto", j).Value Then
                                dgvSaldoFinal.Rows(j).DefaultCellStyle = style
                                Exit For
                            End If
                        Next
                    End If

                Next

            End If

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try


    End Sub

    Private Sub tsbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles tsbLimpiar.Click
        Try
            dgvSaldoFinal.Rows.Clear()
            dgvValidarSaldoFinal.DataSource = Nothing
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
        
    End Sub

    Private Sub tsbEliminar_Click(sender As System.Object, e As System.EventArgs) Handles tsbEliminar.Click
        Try
            If dgvSaldoFinal.SelectedRows.Count > 0 Then
                dgvSaldoFinal.Rows.Remove(dgvSaldoFinal.SelectedRows(0))

                MsgBox("La fila se eliminó correctamente", MsgBoxStyle.Information, "Valorizador de Minerales")
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


   

    Private Sub TsbExportarExcel_Click(sender As System.Object, e As System.EventArgs) Handles TsbExportarExcel.Click
        Dim xlApp As Excel.Application = New Excel.Application
        Dim nContador As Integer
        xlApp.SheetsInNewWorkbook = 2

        Dim xlWorkBook As Excel.Workbook = xlApp.Workbooks.Add
        Dim xlWorkSheet As Excel.Worksheet

        xlWorkSheet = xlWorkBook.Worksheets.Item(1)
        xlWorkSheet.Name = "SaldoFinal"

        For nRow = 0 To dgvSaldoFinal.Rows.Count - 1
            nContador = 1
            For nCol = 0 To dgvSaldoFinal.Columns.Count - 1
                'xlWorkSheet.Cells(nRow + 1, nCol + 1) = dgvSaldoFinal.Rows(nRow).Cells(nCol).Value
                If dgvSaldoFinal.Columns(nCol).Visible = True Then
                    xlWorkSheet.Cells(1, nCol + 1) = dgvSaldoFinal.Columns(nCol).HeaderText
                    xlWorkSheet.Cells(nRow + 2, nContador) = dgvSaldoFinal.Rows(nRow).Cells(nCol).Value
                    nContador += 1
                End If
            Next nCol
        Next nRow

        xlWorkSheet = xlWorkBook.Worksheets.Item(2)
        xlWorkSheet.Name = "ValidarSaldoFinal"

        For nRow = 0 To dgvValidarSaldoFinal.Rows.Count - 1
            nContador = 1
            For nCol = 0 To dgvValidarSaldoFinal.Columns.Count - 1
                If dgvValidarSaldoFinal.Columns(nCol).Visible = True Then
                    xlWorkSheet.Cells(1, nContador) = dgvValidarSaldoFinal.Columns(nCol).HeaderText

                    xlWorkSheet.Cells(nRow + 2, nContador) = dgvValidarSaldoFinal.Rows(nRow).Cells(nCol).Value
                    nContador += 1
                End If
            Next nCol
        Next nRow

        xlApp.DisplayAlerts = False

        sfDialog.Filter = "Hojas de Excel|*.xls"
        sfDialog.ShowDialog()
        If sfDialog.FileName.Length > 0 Then

            xlWorkBook.SaveAs(sfDialog.FileName, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, Type.Missing, Type.Missing, _
                          Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlLocalSessionChanges)
        End If


        xlWorkBook.Close()
        xlApp.Quit()

    End Sub

    Private Sub TsbSalir_Click(sender As System.Object, e As System.EventArgs) Handles TsbSalir.Click
        Me.Close()
    End Sub

End Class