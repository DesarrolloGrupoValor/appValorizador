
Namespace SI.BE

    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 24/04/2011 08:51:02 a.m.
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    Public Class clsBE_ValorizadorPenalizable

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
        ''' Get or Sets the codigoElemento in ValorizadorPenalizable.
        ''' </summary>
        Public Property codigoElemento() As String
        ''' <summary>
        ''' Get or Sets the minimo in ValorizadorPenalizable.
        ''' </summary>
        Public Property minimo() As Double
        ''' <summary>
        ''' Get or Sets the unidadPenalizable in ValorizadorPenalizable.
        ''' </summary>
        Public Property indLey() As String
        ''' <summary>
        ''' Get Collection of tbLiquidacion.
        ''' </summary> 
        Public Property unidadPenalizable() As Double
        ''' <summary>
        ''' Get or Sets the penalidad in ValorizadorPenalizable.
        ''' </summary>
        Public Property penalidad() As Double
        ''' <summary>
        ''' Get or Sets the leyPenalizable in ValorizadorPenalizable.
        ''' </summary>
        Public Property leyPenalizable() As Double
        ''' <summary>
        ''' Get or Sets the calculoPenalizable in ValorizadorPenalizable.
        ''' </summary>
        Public Property calculoPenalizable() As Double
        ''' <summary>
        ''' Get or Sets the codigoEstado in ValorizadorPenalizable.
        ''' </summary>
        Public Property codigoEstado() As String
        ''' <summary>
        ''' Get or Sets the uc in ValorizadorPenalizable.
        ''' </summary>
        Public Property uc() As String
        ''' <summary>
        ''' Get or Sets the fc in ValorizadorPenalizable.
        ''' </summary>
        Public Property fc() As DateTime
        ''' <summary>
        ''' Get or Sets the um in ValorizadorPenalizable.
        ''' </summary>
        Public Property um() As String
        ''' <summary>
        ''' Get or Sets the fm in ValorizadorPenalizable.
        ''' </summary>
        Public Property fm() As DateTime
        ''' <summary>
        ''' Get or Sets the liquidacionPenalizableId in ValorizadorPenalizable.
        ''' </summary>
        Public Property liquidacionPenalizableId() As String
        ''' <summary>
        ''' Get or Sets the maximo in ValorizadorPenalizable.
        ''' </summary>
        Public Property maximo() As Double
        ''' <summary>
        ''' Get or Sets the contratoLoteId in ValorizadorPenalizable.
        ''' </summary>
        Public Property contratoLoteId() As String
        ''' <summary>
        ''' Get or Sets the liquidacionId in ValorizadorPenalizable.
        ''' </summary>
        Public Property liquidacionId() As String
        ''' <summary>
        ''' Get or Sets the preciounitario in ValorizadorPenalizable.
        ''' </summary>
        Public Property preciounitario() As Double
        ''' <summary>
        ''' Get Collection of tbLiquidacion.
        ''' </summary>        
        Public mBE_tbLiquidacion As ICollection(Of clsBE_Liquidacion)
        ''' <summary>
        ''' Gets or sets the tbLiquidacion of this ValorizadorPenalizable
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

