
Namespace SI.BE

    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 18/04/2011 14:12:56
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    Public Class clsBE_ProfitLossLote

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

        Public Property contratoloteId() As String
        Public Property liquidacionId() As String
        Public Property flete() As Decimal
        Public Property estibas() As Decimal
        Public Property supervision() As Decimal
        Public Property seguridad() As Decimal
        Public Property ensayes() As Decimal
        Public Property otros() As Decimal
        Public Property total() As Decimal


        ''' <summary>
        ''' Get Collection of tbContratoLote.
        ''' </summary>        
        Public mBE_tbProfitLoss As ICollection(Of clsBE_ProfitLossLote)
        ''' <summary>
        ''' Gets or sets the tbContratoLote of this Liquidacion
        ''' </summary>
        Public Overridable Property tbProfitLoss() As ICollection(Of clsBE_ProfitLossLote)
            Get
                Return Me.mBE_tbProfitLoss
            End Get
            Set(ByVal value As ICollection(Of clsBE_ProfitLossLote))
                Me.mBE_tbProfitLoss = value
            End Set
        End Property

#End Region
    End Class

End Namespace

