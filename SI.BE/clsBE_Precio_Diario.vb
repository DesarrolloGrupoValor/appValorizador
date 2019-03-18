
Namespace SI.BE

    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 18/04/2011 14:12:56
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    Public Class clsBE_Precio_Diario

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

        Public Property IdPrecioDiario() As Integer
        Public Property fecha() As DateTime
        Public Property elemento() As String
        Public Property precio1() As Decimal
        Public Property precio2() As Decimal
        Public Property precio3() As Decimal
        Public Property precio4() As Decimal
        Public Property calculado1() As Decimal
        Public Property calculado2() As Decimal
        Public Property calculado3() As Decimal
        Public Property calculado4() As Decimal
        Public Property activo() As Integer
        Public Property uc() As String
        Public Property fc() As DateTime
        Public Property um() As String
        Public Property fm() As DateTime

        ''' <summary>
        ''' Get Collection of tbContratoLote.
        ''' </summary>        
        Public mBE_tbPrecio_Diario As ICollection(Of clsBE_Precio_Diario)
        ''' <summary>
        ''' Gets or sets the tbContratoLote of this Liquidacion
        ''' </summary>
        Public Overridable Property tbPrecio_Diario() As ICollection(Of clsBE_Precio_Diario)
            Get
                Return Me.mBE_tbPrecio_Diario
            End Get
            Set(ByVal value As ICollection(Of clsBE_Precio_Diario))
                Me.mBE_tbPrecio_Diario = value
            End Set
        End Property

#End Region
    End Class

End Namespace

