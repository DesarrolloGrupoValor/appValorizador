
Namespace  SI.BE

	''' <summary>
    ''' Escrito por: Lissete Miyahira
    ''' Fecha Creacion: 29/11/2017
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
    Public Class clsBE_SaldoFinal

#Region "Constructor"
        Public Sub New()
            MyBase.New()
        End Sub

#End Region
        ''' <summary>
        ''' Miembros privados de la entidad.
        ''' </summary>
        ''' <remarks></remarks>
#Region " Declaracion de Miembros "


        Public Property calidad() As String
        Public Property precinto() As String
        Public Property ruma() As String
        Public Property clase() As String
        Public Property tmh() As Double
        Public Property fec_ingreso() As DateTime
        Public Property ticket() As String


#End Region
    End Class
    
End Namespace

