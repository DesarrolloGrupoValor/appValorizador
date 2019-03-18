
Namespace SI.BE

    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 24/04/2011 08:51:18 a.m.
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    Public Class clsBE_TB_FJ_APLICACION

#Region "Constructor"
        Public Sub New()
            MyBase.New()
        End Sub

#End Region

#Region " Declaracion de Miembros "
        'Public Item As Integer


        Public Property	oc	() as	string
        Public Property contratoloteid() As String
        Public Property liquidacionid() As String
        Public Property cantidad() As Decimal
        Public Property precio() As Decimal
        Public Property usereg() As String

        Public Property localizador() As String
        Public Property contrato() As String
        Public Property estado() As String
        Public Property id() As Integer

        Public Property TIPOFIJACION() As Integer


        Public mBE_TB_FJ_APLICACION As ICollection(Of clsBE_TB_FJ_APLICACION)
        ''' <summary>
        ''' Gets or sets the tbLiquidacion of this ValorizadorPagable
        ''' </summary>
        Public Overridable Property tbLiquidacion() As ICollection(Of clsBE_TB_FJ_APLICACION)
            Get
                Return Me.mBE_TB_FJ_APLICACION
            End Get
            Set(ByVal value As ICollection(Of clsBE_TB_FJ_APLICACION))
                Me.mBE_TB_FJ_APLICACION = value
            End Set
        End Property

#End Region
    End Class

End Namespace

