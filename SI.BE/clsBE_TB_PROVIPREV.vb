
Namespace SI.BE

    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 24/04/2011 08:51:18 a.m.
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    Public Class clsBE_TB_PROVIPREV

#Region "Constructor"
        Public Sub New()
            MyBase.New()
        End Sub

#End Region

#Region " Declaracion de Miembros "
        'Public Item As Integer

        Public Property pTIPO_OPERACION As String
        Public Property pIDPROVI As Integer
        Public Property pESTADO As String

        Public Property pContratoloteId As String
        Public Property pLiquidacionId As String
        Public Property pUsuarioId As String




        Public mBE_TB_PROVIPREV As ICollection(Of clsBE_TB_PROVIPREV)
        ''' <summary>
        ''' Gets or sets the tbLiquidacion of this ValorizadorPagable
        ''' </summary>
        Public Overridable Property tbLiquidacion() As ICollection(Of clsBE_TB_PROVIPREV)
            Get
                Return Me.mBE_TB_PROVIPREV
            End Get
            Set(ByVal value As ICollection(Of clsBE_TB_PROVIPREV))
                Me.mBE_TB_PROVIPREV = value
            End Set
        End Property

#End Region
    End Class

End Namespace

