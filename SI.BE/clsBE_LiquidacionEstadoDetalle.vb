
Namespace SI.BE

    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 18/04/2011 14:12:56
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    Public Class clsBE_LiquidacionEstadoDetalle

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

        Public Property liquidacionEstadoDetalleId() As Integer
        Public Property liquidacionEstadoDetalleOrigenId() As Integer

        Public Property liquidacionId() As String
        Public Property contratoLoteId() As String

        Public Property usuarioId() As String
        Public Property estadoId() As String

        Public Property activo() As String


        Public Property observaciones() As String

        Public Property NRO_OP() As String
        Public Property TIPO_OP() As String

        Public mBE_tbLiquidacionEstadoDetalle As ICollection(Of clsBE_LiquidacionEstadoDetalle)
      
        Public Overridable Property tbContratoLote() As ICollection(Of clsBE_LiquidacionEstadoDetalle)
            Get
                Return Me.mBE_tbLiquidacionEstadoDetalle
            End Get
            Set(ByVal value As ICollection(Of clsBE_LiquidacionEstadoDetalle))
                Me.mBE_tbLiquidacionEstadoDetalle = value
            End Set
        End Property

#End Region
    End Class

End Namespace

