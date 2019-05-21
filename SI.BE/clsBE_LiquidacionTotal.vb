Namespace SI.BE

    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 21/04/2011 09:56:22 a.m.
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    Public Class clsBE_LiquidacionTotal

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
        ''' Get or Sets the contratoLoteId in LiquidacionTotal.
        ''' </summary>
        Public Property contratoLoteId() As String
        ''' <summary>
        ''' Get or Sets the liquidacionId in LiquidacionTotal.
        ''' </summary>
        Public Property liquidacionId() As String
        ''' <summary>
        ''' Get or Sets the importe in LiquidacionTotal.
        ''' </summary>
        Public Property importe() As Integer
        ''' <summary>
        ''' Get or Sets the codigoEstado in LiquidacionTotal.
        ''' </summary>
        Public Property codigoEstado() As String
        ''' <summary>
        ''' Get or Sets the uc in LiquidacionTotal.
        ''' </summary>
        Public Property uc() As String
        ''' <summary>
        ''' Get or Sets the fc in LiquidacionTotal.
        ''' </summary>
        Public Property fc() As DateTime
        ''' <summary>
        ''' Get or Sets the um in LiquidacionTotal.
        ''' </summary>
        Public Property um() As String
        ''' <summary>
        ''' Get or Sets the fm in LiquidacionTotal.
        ''' </summary>
        Public Property fm() As DateTime
        ''' <summary>
        ''' Get or Sets the codigoTotal in LiquidacionTotal.
        ''' </summary>
        Public Property codigoTotal() As String
        ''' <summary>
        ''' Get or Sets the descri in LiquidacionTotal.
        ''' </summary>
        Public Property descri() As String
        ''' <summary>
        ''' Get or Sets the liquidacionTotalId in LiquidacionTotal.
        ''' </summary>
        Public Property liquidacionTotalId() As String
        ''' <summary>
        ''' Get or Sets the nro in LiquidacionTotal.
        ''' </summary>
        Public Property nro() As Integer
        ''' <summary>
        ''' Get or Sets the codigoCalculoTotal in LiquidacionTotal.
        ''' </summary>
        Public Property codigoCalculoTotal() As String
        ''' <summary>
        ''' Get Collection of tbLiquidacion.
        ''' </summary>        
        Public mBE_tbLiquidacion As ICollection(Of clsBE_Liquidacion)
        ''' <summary>
        ''' Gets or sets the tbLiquidacion of this LiquidacionTotal
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
