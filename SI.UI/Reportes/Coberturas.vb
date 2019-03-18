Imports SI.BC
Imports SI.UT
Imports SI.BE
Imports SI.PL.clsFuncion

Public Class Coberturas
    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    Dim dvwRegistros As DataView

    Private Sub Coberturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ObtenerRegistros("", "")
    End Sub

    Private Sub ObtenerRegistros(ByVal empresa As String, ByVal periodo As String)
        Try
            Dim dsregistros As DataSet
            Dim oContratoRO As New clsBC_ContratoLoteRO
            oContratoRO.oBEContratoLote.codigoTabla = "" 'empresa
            oContratoRO.oBEContratoLote.comentarios = "" 'Year(periodo) & IIf(Month(periodo).ToString.Length > 1, "", "0") & Month(periodo)
            dsregistros = oContratoRO.LeerListaToDSCoberturas
            dvwRegistros = New DataView(dsregistros.Tables(0))
            fxgrdExtraccionBd.DataSource = dvwRegistros

            fxgrdExtraccionBd.Cols("TMS").Format = "N4"

            fxgrdExtraccionBd.Cols("CU Precio Aplicable").Format = "N4"
            fxgrdExtraccionBd.Cols("CU Contenido ").Format = "N4"
            fxgrdExtraccionBd.Cols("PB Precio Aplicable").Format = "N4"
            fxgrdExtraccionBd.Cols("PB Contenido ").Format = "N4"
            fxgrdExtraccionBd.Cols("ZN Precio Aplicable").Format = "N4"
            fxgrdExtraccionBd.Cols("ZN Contenido ").Format = "N4"
            fxgrdExtraccionBd.Cols("AG Precio Aplicable").Format = "N4"
            fxgrdExtraccionBd.Cols("AG Contenido ").Format = "N4"
            fxgrdExtraccionBd.Cols("AU Precio Aplicable").Format = "N4"
            fxgrdExtraccionBd.Cols("AU Contenido ").Format = "N4"


            fxgrdExtraccionBd.Cols("Estado").Width = 50
            fxgrdExtraccionBd.Cols("Tipo").Width = 80
            fxgrdExtraccionBd.Cols("producto").Width = 80
            fxgrdExtraccionBd.Cols("cuota").Width = 80

            fxgrdExtraccionBd.Cols("Proveedor/Cliente").Width = 250

            fxgrdExtraccionBd.Cols("CU Mercado").Width = 130
            fxgrdExtraccionBd.Cols("PB Mercado").Width = 130
            fxgrdExtraccionBd.Cols("ZN Mercado").Width = 130
            fxgrdExtraccionBd.Cols("AG Mercado").Width = 130
            fxgrdExtraccionBd.Cols("AU Mercado").Width = 130

            fxgrdExtraccionBd.Cols("CU QP").Width = 50
            fxgrdExtraccionBd.Cols("PB QP").Width = 50
            fxgrdExtraccionBd.Cols("ZN QP").Width = 50
            fxgrdExtraccionBd.Cols("AG QP").Width = 50
            fxgrdExtraccionBd.Cols("AU QP").Width = 50

            fxgrdExtraccionBd.Cols("CU QPInicial").Width = 80
            fxgrdExtraccionBd.Cols("PB QPInicial").Width = 80
            fxgrdExtraccionBd.Cols("ZN QPInicial").Width = 80
            fxgrdExtraccionBd.Cols("AG QPInicial").Width = 80
            fxgrdExtraccionBd.Cols("AU QPInicial").Width = 80

            fxgrdExtraccionBd.Cols("CU QPFinal").Width = 80
            fxgrdExtraccionBd.Cols("PB QPFinal").Width = 80
            fxgrdExtraccionBd.Cols("ZN QPFinal").Width = 80
            fxgrdExtraccionBd.Cols("AG QPFinal").Width = 80
            fxgrdExtraccionBd.Cols("AU QPFinal").Width = 80
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsMantenimiento_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        Try
            SaveFileDialog1.Filter = "Hojas de Excel|*.xls"
            SaveFileDialog1.ShowDialog()
            If SaveFileDialog1.FileName.Length > 0 Then
                fxgrdExtraccionBd.SaveExcel(SaveFileDialog1.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        '    ObtenerRegistros()
        Me.Dispose()

    End Sub
End Class