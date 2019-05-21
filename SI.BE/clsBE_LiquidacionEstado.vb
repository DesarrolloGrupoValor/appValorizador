
Namespace SI.BE

    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 18/04/2011 14:12:56
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    Public Class clsBE_LiquidacionEstado

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

        Public Property liquidacionEstadoId() As Integer
        Public Property liquidacionId() As String
        Public Property contratoLoteId() As String
        Public Property codigoCalculo() As String
        Public Property fc() As DateTime
        Public Property uc() As String

        Public Property archivo() As String

        ''' <summary>
        ''' Get Collection of tbContratoLote.
        ''' </summary>        
        Public mBE_tbLiquidacionEstado As ICollection(Of clsBE_LiquidacionEstado)
        ''' <summary>
        ''' Gets or sets the tbContratoLote of this Liquidacion
        ''' </summary>
        Public Overridable Property tbContratoLote() As ICollection(Of clsBE_LiquidacionEstado)
            Get
                Return Me.mBE_tbLiquidacionEstado
            End Get
            Set(ByVal value As ICollection(Of clsBE_LiquidacionEstado))
                Me.mBE_tbLiquidacionEstado = value
            End Set
        End Property

#End Region
    End Class

End Namespace

