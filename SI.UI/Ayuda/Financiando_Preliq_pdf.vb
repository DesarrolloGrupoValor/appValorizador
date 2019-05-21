Public Class Financiando_Preliq_pdf

    Private posicion As Integer = 200

    Private Sub Financiando_Preliq_pdf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim pPrinter As New Drawing.Printing.PrinterSettings

        pPrinter.PrinterName = "Adobe PDF"
        pPrinter.PrintToFile = True





        'pPrinter.
        'PrintDocument1.PrinterSettings = pPrinter
       

        'Me.Button1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.p)


        'SaveFileDialog1.FileName = "F:\Informations\EJEMPLOS\Demo\123.pdf"
        'Dim fs As System.IO.FileStream = CType(SaveFileDialog1.OpenFile(), System.IO.FileStream)



        'Dim fs2 As System.IO.FileStream = CType(SaveFileDialog1.OpenFile, System.IO.FileStream)


        ''SaveFileDialog1
        'SaveFileDialog1.OpenFile()

        'PrintDocument1.DefaultPageSettings.PrinterSe()
        'PrintDocument1.PrintController
        'PrintDocument1.

        'Process.Start("F:\Informations\EJEMPLOS\Demo\13.pdf")
        'PrintDocument1.re()
        PrintDocument1.DocumentName = "F:\Informations\EJEMPLOS\Demo\13.pdf"
        PrintDocument1.Print()




        'PrintDocument1.DefaultPageSettings =System.Drawing.Image.
    End Sub


    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim Fuente As New Font("arial", 10)

        Dim displayRectangle1 As New Rectangle
        displayRectangle1 = New Rectangle(New Point(150, posicion + 690), New Size(400, 100))
        e.Graphics.DrawRectangle(Pens.White, displayRectangle1)

        'e.Graphics.DrawString("Fecha", Fuente, Brushes.Black, 50, posicion + 10)
        e.Graphics.DrawString("1", Fuente, Brushes.Black, 90, posicion + 10)
        e.Graphics.DrawString("2", Fuente, Brushes.Black, 170, posicion + 10)
        e.Graphics.DrawString("3".Substring(2, 2), Fuente, Brushes.Black, 370, posicion + 10)

        'e.Graphics.DrawString(sComDescripcion, Fuente, Brushes.Black, 150, posicion + 40)
        'e.Graphics.DrawString(sDireccion, Fuente, Brushes.Black, 150, posicion + 70)
        'e.Graphics.DrawString(sRuc, Fuente, Brushes.Black, 150, posicion + 100)

        'e.Graphics.DrawString(sPrecioUnitario, Fuente, Brushes.Black, 650, posicion + 180, format1)
        'e.Graphics.DrawString(sValorNeto, Fuente, Brushes.Black, 780, posicion + 180, format1)
        'e.Graphics.DrawString(sConcepto, Fuente, Brushes.Black, 150, posicion + 180)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class