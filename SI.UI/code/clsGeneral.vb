Imports SI.UT.clsUT_Funcion
Imports SI.BE
Namespace SI.PL
    Public Class clsGeneral
        Public Shared pblnContratos As Boolean
        Public Shared pblnEditContratos As Boolean
        Public Shared ColorRed As Integer
        Public Shared ColorGreen As Integer
        Public Shared ColorBlue As Integer
        Public Shared ColorForm As New System.Drawing.Color
        Public Shared pstrVersion As String
        Public Shared pBEUsuario As New clsBE_TablaDet
        Public Shared pblnRetornaContratos As Boolean
        Public Shared pblnRetornaLotes As Boolean
        Shared Sub SetConfiguracion()
            ColorRed = getConfig("ColorRed")
            ColorGreen = getConfig("ColorGreen")
            ColorBlue = getConfig("ColorBlue")
            ColorForm = System.Drawing.Color.FromArgb(ColorRed, ColorGreen, ColorBlue)
        End Sub
        Shared Sub SetColorEtiquetas(ByVal frm As Form)
            For Each ctrl As Control In frm.Controls
                If TypeOf ctrl Is GroupBox Then
                    ctrl.ForeColor = Color.Black
                    For Each ctrl2 In ctrl.Controls
                        If TypeOf ctrl2 Is TextBox Or TypeOf ctrl2 Is ComboBox Or TypeOf ctrl2 Is NumericUpDown Then
                            ctrl2.BackColor = Color.White
                        End If

                    Next
                End If
                If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Or TypeOf ctrl Is NumericUpDown Then
                    ctrl.BackColor = Color.White
                End If


            Next
        End Sub
    End Class
End Namespace