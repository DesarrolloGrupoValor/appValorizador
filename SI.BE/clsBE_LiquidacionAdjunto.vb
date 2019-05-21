
Namespace SI.BE

    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 18/04/2011 14:12:56
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    Public Class clsBE_LiquidacionAdjunto

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
        Public Property liquidacionAdjuntoId() As Integer

        Public Property tipoAdjuntarDoc() As String
        Public Property ruta() As String
        Public Property archivo() As String
        Public Property uc() As String
        Public Property uc_nombre() As String

        Public Property IDITEM() As Integer

        Public Property NRO_OP() As String

        Public mBE_tbLiquidacionAdjunto As ICollection(Of clsBE_LiquidacionAdjunto)

        Public Overridable Property tbAdjunto() As ICollection(Of clsBE_LiquidacionAdjunto)
            Get
                Return Me.mBE_tbLiquidacionAdjunto
            End Get
            Set(ByVal value As ICollection(Of clsBE_LiquidacionAdjunto))
                Me.mBE_tbLiquidacionAdjunto = value
            End Set
        End Property

#End Region
    End Class

End Namespace

