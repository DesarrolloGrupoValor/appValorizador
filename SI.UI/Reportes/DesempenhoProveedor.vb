Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient
Imports System.Configuration
Imports SI.BC

Public Class DesempenhoProveedor
    Private oTableDet As New clsBC_TablaDetRO
    Private oContratoRO As New clsBC_ContratoLoteRO
    Private dtTablaDet1 As DataTable
    Private dtTablaDet2 As DataTable
    Private dtTablaDet3 As DataTable
    Private dtLoteMov As DataTable
    Dim conexion As String

    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conexion = ConfigurationManager.AppSettings("SQLConexion").Trim()

            oTableDet.oBETablaDet.tablaId = "producto"
            dtTablaDet1 = oTableDet.LeerListaToDSTablaDet().Tables(0)
            Me.cmbTipo.ValueMember = "tablaDetId"
            Me.cmbTipo.DisplayMember = "descri"
            Me.cmbTipo.DataSource = dtTablaDet1
            Me.cmbTipo.SelectedValue = dtTablaDet1.Rows(0)("tablaDetId")

            oTableDet.oBETablaDet.tablaId = "empresa"
            dtTablaDet2 = oTableDet.LeerListaToDSTablaDet().Tables(0)

            Dim newRow2 As DataRow = dtTablaDet2.NewRow()
            newRow2("tablaId") = "empresa"
            newRow2("tablaDetId") = ""
            newRow2("descri") = "<TODOS>"
            dtTablaDet2.Rows.Add(newRow2)
            dtTablaDet2.AcceptChanges()

            Me.cmbcomprador.ValueMember = "tablaDetId"
            Me.cmbcomprador.DisplayMember = "descri"
            Me.cmbcomprador.DataSource = dtTablaDet2
            Me.cmbcomprador.SelectedValue = dtTablaDet2.Rows(0)("tablaDetId")

            oTableDet.oBETablaDet.tablaId = "calidad"
            dtTablaDet3 = oTableDet.LeerListaToDSTablaDet().Tables(0)

            Dim newRow As DataRow = dtTablaDet3.NewRow()
            newRow("tablaId") = "calidad"
            newRow("tablaDetId") = ""
            newRow("descri") = "<TODOS>"
            dtTablaDet3.Rows.Add(newRow)
            dtTablaDet3.AcceptChanges()

            Me.cmbcalidad.ValueMember = "tablaDetId"
            Me.cmbcalidad.DisplayMember = "descri"
            Me.cmbcalidad.DataSource = dtTablaDet3
            Me.cmbcalidad.SelectedValue = dtTablaDet3.Rows(0)("tablaDetId")

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try

    End Sub




    Private Sub FillTable(ByVal ds As DataSet, ByVal tableName As String, ByVal conn As String, ByVal numero As String)
        tableName = tableName.Trim()
        Dim sql As String = String.Format("select * from [{0}]('" + Me.cmbcomprador.SelectedValue.ToString().Trim() + "','" + Me.cmbTipo.SelectedValue.ToString().Trim() + "','" + cmbcalidad.SelectedValue.ToString().Trim() + "','" + Me.txtperiodofin.Text + "','" + Me.txtperiodoini.Text + "',2) where nivel = " + numero, tableName)
        Dim da As New SqlDataAdapter(sql, conn)
        da.Fill(ds, tableName + numero)
    End Sub



    ' apply column information to a grid
    ' this will set the column positions, caption, format, and visibility
    ' (any columns not included in the 'columns' array will not be displayed
    Private Sub SetupColumns(ByVal grid As C1FlexDataTree, ByVal columns As String())
        ' initialize column position
        Dim position As Integer = grid.Cols.Fixed

        ' apply column information
        For Each s As String In columns
            ' split column info (name, caption, format)
            Dim columnInfo As String() = s.Split(","c)

            ' move column to proper position based on its name
            Dim column As Column = grid.Cols(columnInfo(0).Trim())
            If column IsNot Nothing Then
                column.Move(position)
                position += 1

                ' apply caption
                If columnInfo.Length > 1 Then
                    column.Caption = columnInfo(1).Trim()
                End If

                ' apply format
                If columnInfo.Length > 2 Then
                    column.Format = columnInfo(2).Trim()
                End If
            End If
        Next
        For i As Integer = position To grid.Cols.Count - 1
            grid.Cols(i).Visible = False
        Next

        ' hide all other columns
    End Sub

    Private Sub C1FlexDataTree1_SetupColumns(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1FlexDataTree1.SetupColumns
        ' get grid that was just bound
        Dim grid As C1FlexDataTree = TryCast(sender, C1FlexDataTree)
        If grid Is Nothing OrElse grid.DataSource Is Nothing Then
            Return
        End If

        ' get source DataTable
        Dim cm As CurrencyManager = DirectCast(BindingContext(grid.DataSource, grid.DataMember), CurrencyManager)
        Dim dt As DataTable = DirectCast(cm.List, DataView).Table

        ' apply custom column order, captions, format
        Dim columns As String() = TryCast(dt.ExtendedProperties("ShowColumns"), String())
        If columns IsNot Nothing Then
            SetupColumns(grid, columns)
        End If

        ' apply custom data maps
        For Each gridColumn As Column In grid.Cols
            Dim dataColumn As DataColumn = dt.Columns(gridColumn.Name)
            If dataColumn Is Nothing Then
                Continue For
            End If
            gridColumn.DataMap = TryCast(dataColumn.ExtendedProperties("DataMap"), IDictionary)
            If gridColumn.DataMap IsNot Nothing Then
                gridColumn.TextAlign = TextAlignEnum.LeftCenter
            End If
        Next

        ' all done, autosize to show mapped data
        If grid.AutoResize Then
            grid.AutoSizeCols(12)
        End If
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click        
        Dim _ds As DataSet = New DataSet()
        Dim _ds2 As DataSet = New DataSet()
        Dim tables As String() = "f_tbLotesValorizadas, f_tbLotesValorizadas".Split(","c)
        Dim a As Integer = 0
        For Each tableName As String In tables
            FillTable(_ds, tableName, conexion, a.ToString)
            a = a + 1
        Next


        Dim sql As String = String.Format("select * from [{0}]('" + Me.cmbcomprador.SelectedValue.ToString().Trim() + "','" + Me.cmbTipo.SelectedValue.ToString().Trim() + "','" + cmbcalidad.SelectedValue.ToString().Trim() + "','" + Me.txtperiodofin.Text + "','" + Me.txtperiodoini.Text + "')  ", "up_tbLotesValorizados_DP")
        Dim da As New SqlDataAdapter(sql, conexion)
        da.Fill(_ds2, "up_tbLotesValorizados_DP")

        C1TrueDBGrid1.DataSource = _ds2.Tables(0)

        C1FlexDataTree1.SetDataBinding(Nothing, String.Empty)

        Dim loclsBC_LiquidacionRO As New clsBC_LiquidacionRO


        Dim dt As DataTable = _ds.Tables("f_tbLotesValorizadas0")

            If dt.Rows.Count > 0 Then

            Dim dt1 As DataTable = _ds.Tables("f_tbLotesValorizadas1")
            Dim col As DataColumn
                Dim xx(40) As String

                a = 0
                For Each col In dt.Columns

                    If col.ColumnName().Substring(col.ColumnName().Length - 1, 1) = "0" Then

                        xx(a) = col.ColumnName().Trim() + ", " + col.ColumnName().Substring(0, col.ColumnName().Length - 1)
                        a = a + 1
                    End If

                Next
                ReDim Preserve xx(a - 1)

            _ds.Relations.Add("rel1", _ds.Tables(0).Columns("Codigo"), _ds.Tables(1).Columns("Codigo"))

                dt.ExtendedProperties.Add("ShowColumns", xx)
                dt1.ExtendedProperties.Add("ShowColumns", xx)

            Me.C1FlexDataTree1.SetDataBinding(_ds, "f_tbLotesValorizadas0")

        End If
    End Sub

    Private Sub C1FlexDataTree1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1FlexDataTree1.KeyDown
        Select Case e.KeyCode
            Case Keys.C
                If e.Modifiers = Keys.Control Then
                    System.Windows.Forms.Clipboard.SetText(C1FlexDataTree1.Clip)

                End If
        End Select
    End Sub

    Private Sub cmbTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipo.SelectedIndexChanged
        If cmbTipo.SelectedIndex <> -1 Then



        End If
    End Sub

    Private Sub txtCorrelativo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

    End Sub
End Class