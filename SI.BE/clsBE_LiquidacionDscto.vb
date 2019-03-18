
Namespace SI.BE

    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 21/04/2011 09:06:17 a.m.
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    Public Class clsBE_LiquidacionDscto

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
        Public Item As Integer

        ''' <summary>
        ''' Get or Sets the codigoDscto in LiquidacionDscto.
        ''' </summary>
        Public Property codigoDscto() As String
        ''' <summary>
        ''' Get or Sets the importe in LiquidacionDscto.
        ''' </summary>
        Public Property importe() As Double
        ''' <summary>
        ''' Get or Sets the descri in LiquidacionDscto.
        ''' </summary>
        Public Property descri() As String
        ''' <summary>
        ''' Get or Sets the cartaInstruccion in LiquidacionDscto.
        ''' </summary>
        Public Property cartaInstruccion() As String
        ''' <summary>
        ''' Get or Sets the observa in LiquidacionDscto.
        ''' </summary>
        Public Property observa() As String
        ''' <summary>
        ''' Get or Sets the codigoEstado in LiquidacionDscto.
        ''' </summary>
        Public Property codigoEstado() As String
        ''' <summary>
        ''' Get or Sets the uc in LiquidacionDscto.
        ''' </summary>
        Public Property uc() As String
        ''' <summary>
        ''' Get or Sets the fc in LiquidacionDscto.
        ''' </summary>
        Public Property fc() As DateTime
        ''' <summary>
        ''' Get or Sets the um in LiquidacionDscto.
        ''' </summary>
        Public Property um() As String
        ''' <summary>
        ''' Get or Sets the fm in LiquidacionDscto.
        ''' </summary>
        Public Property fm() As DateTime
        ''' <summary>
        ''' Get or Sets the contratoLoteId in LiquidacionDscto.
        ''' </summary>
        Public Property contratoLoteId() As String
        ''' <summary>
        ''' Get or Sets the liquidacionId in LiquidacionDscto.
        ''' </summary>
        Public Property liquidacionId() As String
        ''' <summary>
        ''' Get or Sets the liquidacionDsctoId in LiquidacionDscto.
        ''' </summary>
        Public Property liquidacionDsctoId() As String
        ''' <summary>
        ''' Get or Sets the nro in LiquidacionDscto.
        ''' </summary>
        Public Property nro() As Integer



        Public Property EMPRESA() As String
        Public Property NRO_OP() As String
        Public Property TIPO_OP() As String
        Public Property TIPO_COMPR() As String
        Public Property NUM_COMPR() As String
        Public Property SEQ() As String
        Public Property SEQ_INT() As Integer
        Public Property PROVEEDOR() As String


        'Public Property A_nro() As Integer

        ''' <summary>
        ''' Get Collection of tbLiquidacion.
        ''' </summary>        
        Public mBE_tbLiquidacion As ICollection(Of clsBE_Liquidacion)
        ''' <summary>
        ''' Gets or sets the tbLiquidacion of this LiquidacionDscto
        ''' </summary>
        Public Overridable Property tbLiquidacion() As ICollection(Of clsBE_Liquidacion)
            Get
                Return Me.mBE_tbLiquidacion
            End Get
            Set(ByVal value As ICollection(Of clsBE_Liquidacion))
                Me.mBE_tbLiquidacion = value
            End Set
        End Property

#End Region
    End Class

End Namespace

