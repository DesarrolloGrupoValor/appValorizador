Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient
Imports System.Configuration
Imports SI.BC

Public Class Mezcla
    Private oTableDet As New clsBC_TablaDetRO
    Private oTableDet1 As New clsBC_TablaDetRO
    Private oContratoRO As New clsBC_ContratoLoteRO
    Private dtTablaDet As DataTable
    Private dtTablaDet1 As DataTable
    Private dtLoteMov As DataTable
    Dim conexion As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion = ConfigurationManager.AppSettings("SQLConexion").Trim()

        oTableDet.oBETablaDet.tablaId = "movimiento"
        dtTablaDet = oTableDet.LeerListaToDSTablaDet().Tables(0)
        Me.cmbTipo.ValueMember = "tablaDetId"
        Me.cmbTipo.DisplayMember = "descri"
        Me.cmbTipo.DataSource = dtTablaDet
        Me.cmbTipo.SelectedValue = dtTablaDet.Rows(0)("tablaDetId")

        oTableDet1.oBETablaDet.tablaId = "ModoMezcla"
        dtTablaDet1 = oTableDet1.LeerListaToDSTablaDet().Tables(0)

        Me.cmbmodo.ValueMember = "tablaDetId"
        Me.cmbmodo.DisplayMember = "descri"
        Me.cmbmodo.DataSource = dtTablaDet1
        Me.cmbmodo.SelectedValue = dtTablaDet1.Rows(0)("tablaDetId")


    End Sub

    Private Sub CargaLotes(ByVal codigoMovimiento As String)
        oContratoRO.oBEContratoLote.codigoMovimiento = codigoMovimiento
        dtLoteMov = oContratoRO.LeerListaToDSLoteMov.Tables(0)
        Dim keys(1) As DataColumn
        Dim col1 As DataColumn
        col1 = dtLoteMov.Columns("contratoLoteId")

        keys(0) = col1

        dtLoteMov.PrimaryKey = keys

        cmblotes.ValueMember = "contratoLoteId"
        cmblotes.DisplayMember = "contratoLoteId"
        cmblotes.DataSource = dtLoteMov
        If dtLoteMov.Rows.Count > 0 Then
            cmblotes.SelectedValue = dtLoteMov.Rows(0)("contratoLoteId")
        Else
            cmblotes.SelectedValue = ""
        End If


    End Sub

    Private Sub FillTable(ByVal ds As DataSet, ByVal tableName As String, ByVal conn As String, ByVal numero As String)
        tableName = tableName.Trim()
        Dim sql As String = String.Format("select * from [{0}]('" + txtCorrelativo.Text.Trim() + "',2) where nivel = " + numero, tableName)
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

    Private Sub txtCorrelativo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCorrelativo.Validating
        txtCorrelativo.Text = txtCorrelativo.Text.Trim().PadLeft(10, "0")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click        
        Dim _ds As DataSet = New DataSet()
        Dim tables As String() = "f_tbRumasValorizadas_MZ, f_tbRumasValorizadas_MZ".Split(","c)
        Dim a As Integer = 0
        For Each tableName As String In tables
            FillTable(_ds, tableName, conexion, a.ToString)
            a = a + 1
        Next
        C1FlexDataTree1.SetDataBinding(Nothing, String.Empty)



        Dim dbrFoundRow As DataRow
        Dim sSearchKey As New Object

        sSearchKey = txtCorrelativo.Text.Trim()

        dbrFoundRow = dtLoteMov.Rows.Find(sSearchKey)

        If Not dbrFoundRow Is Nothing Then

            Dim dt As DataTable = _ds.Tables("f_tbRumasValorizadas_MZ0")

            If dt.Rows.Count > 0 Then

                Dim dt1 As DataTable = _ds.Tables("f_tbRumasValorizadas_MZ1")

                'Dim col As DataColumn
                'Dim xx(40) As String

                'a = 0
                'For Each col In dt.Columns

                '    If col.ColumnName().Substring(col.ColumnName().Length - 1, 1) = "0" Then

                '        xx(a) = col.ColumnName().Trim() + ", " + col.ColumnName().Substring(0, col.ColumnName().Length - 1)
                '        a = a + 1
                '    End If

                'Next
                'ReDim Preserve xx(a - 1)

                _ds.Relations.Add("rel1", _ds.Tables(0).Columns("nivelOrig"), _ds.Tables(1).Columns("nivel"))


                'dt.ExtendedProperties.Add("ShowColumns", xx)
                'dt1.ExtendedProperties.Add("ShowColumns", xx)


                Me.C1FlexDataTree1.SetDataBinding(_ds, "f_tbRumasValorizadas_MZ0")
            Else
                C1FlexDataTree1.SetDataBinding(Nothing, String.Empty)

            End If
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

            CargaLotes(cmbTipo.SelectedValue)

        End If
    End Sub

    Private Sub cmblotes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblotes.TextChanged
        If cmblotes.SelectedIndex <> -1 Then
            txtCorrelativo.Text = cmblotes.SelectedValue.ToString()




        End If

    End Sub

    Private Sub cmblotes_SelChange(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmblotes.SelChange

    End Sub
End Class