
Namespace SI.BE

    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 24/04/2011 08:51:18 a.m.
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    Public Class clsBE_FINANCIANDO_CLI

#Region "Constructor"
        Public Sub New()
            MyBase.New()
        End Sub

#End Region

#Region " Declaracion de Miembros "
        'Public Item As Integer


       
        Public Property proveedor() As String
        Public Property empresa() As String


        Public mBE_FINANCIANDO_CLI As ICollection(Of clsBE_FINANCIANDO_CLI)
        ''' <summary>
        ''' Gets or sets the tbLiquidacion of this ValorizadorPagable
        ''' </summary>
        Public Overridable Property tbLiquidacion() As ICollection(Of clsBE_FINANCIANDO_CLI)
            Get
                Return Me.mBE_FINANCIANDO_CLI
            End Get
            Set(ByVal value As ICollection(Of clsBE_FINANCIANDO_CLI))
                Me.mBE_FINANCIANDO_CLI = value
            End Set
        End Property

#End Region
    End Class

End Namespace

