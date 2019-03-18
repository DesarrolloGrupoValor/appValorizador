
Namespace SI.BE

    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 24/04/2011 08:51:18 a.m.
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    Public Class clsBE_TB_DESCUENTOS_LIQ

#Region "Constructor"
        Public Sub New()
            MyBase.New()
        End Sub

#End Region

#Region " Declaracion de Miembros "
        'Public Item As Integer


        Public Property ITEM() As Integer
        Public Property SEC() As Integer
        Public Property BENEFICIARIO() As String
        Public Property BANCO() As String
        Public Property CUENTA_BCO() As String
        Public Property TIPO() As String
        Public Property DESCRIPCION() As String
        Public Property IMPORTE() As Double
        Public Property FLG_ESTADO() As String
        Public Property NRO_OP() As String
        Public Property LINEA_CLI() As Double
        Public Property CUENTA_PROV() As String
        Public Property ESTADO_CLI() As String

        Public Property EMPRESA() As String


        Public Property TIPO_COMPR() As String
        Public Property NUM_COMPR() As String

        Public Property contratoLoteId() As String
        Public Property usuario_liq() As String

        Public Property FECHA_CARTA As DateTime


        Public Property MONEDA() As String
        Public Property IMP_MONEDA() As Double

        Public mBE_TB_DESCUENTOS_LIQ As ICollection(Of clsBE_TB_DESCUENTOS_LIQ)
        ''' <summary>
        ''' Gets or sets the tbLiquidacion of this ValorizadorPagable
        ''' </summary>
        Public Overridable Property tbLiquidacion() As ICollection(Of clsBE_TB_DESCUENTOS_LIQ)
            Get
                Return Me.mBE_TB_DESCUENTOS_LIQ
            End Get
            Set(ByVal value As ICollection(Of clsBE_TB_DESCUENTOS_LIQ))
                Me.mBE_TB_DESCUENTOS_LIQ = value
            End Set
        End Property

#End Region
    End Class

End Namespace

