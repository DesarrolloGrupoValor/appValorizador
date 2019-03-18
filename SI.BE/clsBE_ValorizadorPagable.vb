
Namespace SI.BE

    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 24/04/2011 08:51:18 a.m.
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    Public Class clsBE_ValorizadorPagable

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
        ''' Get or Sets the codigoElemento in ValorizadorPagable.
        ''' </summary>
        Public Property codigoElemento() As String
        ''' <summary>
        ''' Get or Sets the pagable in ValorizadorPagable.
        ''' </summary>
        Public Property pagable() As Double
        ''' <summary>
        ''' Get or Sets the deduccion in ValorizadorPagable.
        ''' </summary>
        Public Property deduccion() As Double
        ''' <summary>
        ''' Get or Sets the refinacion in ValorizadorPagable.
        ''' </summary>
        Public Property refinacion() As Double
        ''' <summary>
        ''' Get or Sets the proteccion in ValorizadorPagable.
        ''' </summary>
        Public Property proteccion() As Double
        ''' <summary>
        ''' Get or Sets the codigoMercado in ValorizadorPagable.
        ''' </summary>
        Public Property codigoMercado() As String
        ''' <summary>
        ''' Get or Sets the qpInicio in ValorizadorPagable.
        ''' </summary>
        Public Property qpInicio() As DateTime
        ''' <summary>
        ''' Get or Sets the qpFinal in ValorizadorPagable.
        ''' </summary>
        Public Property qpFinal() As DateTime
        ''' <summary>
        ''' Get or Sets the leyPagable in ValorizadorPagable.
        ''' </summary>
        Public Property leyPagable() As Double
        ''' <summary>
        ''' Get or Sets the precio in ValorizadorPagable.
        ''' </summary>
        Public Property precio() As Double
        ''' <summary>
        ''' Get or Sets the codigoEstado in ValorizadorPagable.
        ''' </summary>
        Public Property codigoEstado() As String
        ''' <summary>
        ''' Get or Sets the uc in ValorizadorPagable.
        ''' </summary>
        Public Property uc() As String
        ''' <summary>
        ''' Get or Sets the fc in ValorizadorPagable.
        ''' </summary>
        Public Property fc() As DateTime
        ''' <summary>
        ''' Get or Sets the um in ValorizadorPagable.
        ''' </summary>
        Public Property um() As String
        ''' <summary>
        ''' Get or Sets the fm in ValorizadorPagable.
        ''' </summary>
        Public Property fm() As DateTime
        ''' <summary>
        ''' Get or Sets the liquidacionPagable in ValorizadorPagable.
        ''' </summary>
        Public Property liquidacionPagable() As String
        ''' <summary>
        ''' Get or Sets the codigoDeduccion in ValorizadorPagable.
        ''' </summary>
        Public Property codigoDeduccion() As String
        ''' <summary>
        ''' Get or Sets the calculoPagable in ValorizadorPagable.
        ''' </summary>
        Public Property calculoPagable() As Double
        ''' <summary>
        ''' Get or Sets the codigoQp in ValorizadorPagable.
        ''' </summary>
        Public Property codigoQp() As String
        ''' <summary>
        ''' Get or Sets the qpAjuste in ValorizadorPagable.
        ''' </summary>
        Public Property codigoQpAjuste() As String
        ''' <summary>
        ''' Get or Sets the contratoLoteId in ValorizadorPagable.
        ''' </summary>
        Public Property contratoLoteId() As String
        ''' <summary>
        ''' Get or Sets the liquidacionId in ValorizadorPagable.
        ''' </summary>
        Public Property liquidacionId() As String
        ''' <summary>
        ''' Get or Sets the leymin in ValorizadorPagable.
        ''' </summary>
        Public Property leymin() As Double
        ''' <summary>
        ''' Get or Sets the leymax in ValorizadorPagable.
        ''' </summary>
        Public Property leymax() As Double
        ''' <summary>
        ''' Get or Sets the preciounitario in ValorizadorPagable.
        ''' </summary>
        Public Property preciounitario() As Double
        ''' <summary>
        ''' Get or Sets the codntenidoPagable in ValorizadorPagable.
        ''' </summary>
        Public Property contenidoPagable() As Double
        ''' <summary>
        ''' Get Collection of tbLiquidacion.
        ''' </summary> 
        Public Property finLey() As String
        ''' <summary>
        ''' Get Collection of tbLiquidacion.
        ''' </summary> 
        Public Property finPrecio() As String
        ''' <summary>
        ''' Get Collection of tbLiquidacion.
        ''' </summary>        
        Public Property protCont() As Double
        ''' <summary>
        ''' Get or Sets the ProteccionPagable in ValorizadorPagable.
        ''' </summary>

        Public mBE_tbLiquidacion As ICollection(Of clsBE_Liquidacion)
        ''' <summary>
        ''' Gets or sets the tbLiquidacion of this ValorizadorPagable
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

