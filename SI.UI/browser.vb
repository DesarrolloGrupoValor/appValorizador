Public Class browser
    Public psurl As String


    Private Sub browser_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim suri As New System.Uri(psurl)
        Dim authHeader As String = "Authorization: Basic " + Convert.ToBase64String(System.Text.UnicodeEncoding.ASCII.GetBytes("enproyec\valorizador" + ":" + "Password$")) + System.Environment.NewLine
        'Dim authHeader As String = "Authorization: Basic " + Convert.ToBase64String(System.Text.UnicodeEncoding.ASCII.GetBytes("enproyec\valorizador" + ":" + "Password$")) + System.Environment.NewLine
        WebBrowser1.Navigate(suri.ToString, Nothing, Nothing, authHeader)
        'ebBrowser1.Url = suri


    End Sub
End Class