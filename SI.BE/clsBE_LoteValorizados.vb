
Namespace SI.BE

    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 18/04/2011 14:12:56
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    Public Class clsBE_LoteValorizados

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



        Public Property contratoLoteId() As String
        Public Property liquidacionId() As String

        Public mBE_tbLoteValorizados As ICollection(Of clsBE_LoteValorizados)


        Public Overridable Property tbContratoLote() As ICollection(Of clsBE_LoteValorizados)
            Get
                Return Me.mBE_tbLoteValorizados
            End Get
            Set(ByVal value As ICollection(Of clsBE_LoteValorizados))
                Me.mBE_tbLoteValorizados = value
            End Set
        End Property

#End Region
    End Class

End Namespace

