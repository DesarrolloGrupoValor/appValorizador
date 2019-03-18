
Namespace SI.BE

    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 24/04/2011 10:52:51 a.m.
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    Public Class clsBE_LiquidacionTm

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
        ''' Get or Sets the contratoLoteId in LiquidacionTm.
        ''' </summary>
        Public Property contratoLoteId() As String
        ''' <summary>
        ''' Get or Sets the liquidacionId in LiquidacionTm.
        ''' </summary>
        Public Property liquidacionId() As String
        ''' <summary>
        ''' Get or Sets the liquidacionTmId in LiquidacionTm.
        ''' </summary>
        Public Property liquidacionTmId() As String
        ''' <summary>
        ''' Get or Sets the tmh in LiquidacionTm.
        ''' </summary>
        Public Property tmh() As Double
        ''' <summary>
        ''' Get or Sets the h2o in LiquidacionTm.
        ''' </summary>
        Public Property h2o() As Double
        ''' <summary>
        ''' Get or Sets the tms in LiquidacionTm.
        ''' </summary>
        Public Property tms() As Double
        ''' <summary>
        ''' Get or Sets the tmsn in LiquidacionTm.
        ''' </summary>
        Public Property tmsn() As Double
        ''' <summary>
        ''' Get or Sets the codigoAnalisis in LiquidacionTm.
        ''' </summary>
        Public Property codigoAnalisis() As String
        ''' <summary>
        ''' Get or Sets the codigoLaboratorio in LiquidacionTm.
        ''' </summary>
        Public Property codigoLaboratorio() As String
        ''' <summary>
        ''' Get or Sets the valorLiquidacion in LiquidacionTm.
        ''' </summary>
        Public Property valorLiquidacion() As Double
        ''' <summary>
        ''' Get or Sets the codigoEstado in LiquidacionTm.
        ''' </summary>
        Public Property codigoEstado() As String
        ''' <summary>
        ''' Get or Sets the uc in LiquidacionTm.
        ''' </summary>
        Public Property uc() As String
        ''' <summary>
        ''' Get or Sets the fc in LiquidacionTm.
        ''' </summary>
        Public Property fc() As DateTime
        ''' <summary>
        ''' Get or Sets the um in LiquidacionTm.
        ''' </summary>
        Public Property um() As String
        ''' <summary>
        ''' Get or Sets the fm in LiquidacionTm.
        ''' </summary>
        Public Property fm() As DateTime
        ''' <summary>
        ''' Get or Sets the PagCu in LiquidacionTm.
        ''' </summary>
        Public Property PagCu() As Double
        ''' <summary>
        ''' Get or Sets the PagZn in LiquidacionTm.
        ''' </summary>
        Public Property PagZn() As Double
        ''' <summary>
        ''' Get or Sets the PagPb in LiquidacionTm.
        ''' </summary>
        Public Property PagPb() As Double
        ''' <summary>
        ''' Get or Sets the PagAg in LiquidacionTm.
        ''' </summary>
        Public Property PagAg() As Double
        ''' <summary>
        ''' Get or Sets the PagAu in LiquidacionTm.
        ''' </summary>
        Public Property PagAu() As Double
        ''' <summary>
        ''' Get or Sets the PenAs in LiquidacionTm.
        ''' </summary>
        Public Property PenAs() As Double
        ''' <summary>
        ''' Get or Sets the PenSb in LiquidacionTm.
        ''' </summary>
        Public Property PenSb() As Double
        ''' <summary>
        ''' Get or Sets the PenBi in LiquidacionTm.
        ''' </summary>
        Public Property PenBi() As Double
        ''' <summary>
        ''' Get or Sets the PenZn in LiquidacionTm.
        ''' </summary>
        Public Property PenZn() As Double
        ''' <summary>
        ''' Get or Sets the PenPb in LiquidacionTm.
        ''' </summary>
        Public Property PenPb() As Double
        ''' <summary>
        ''' Get or Sets the PenHg in LiquidacionTm.
        ''' </summary>
        Public Property PenHg() As Double
        ''' <summary>
        ''' Get or Sets the PenSiO2 in LiquidacionTm.
        ''' </summary>
        Public Property PenSiO2() As Double
        ''' <summary>
        ''' Get or Sets the Pen1 in LiquidacionTm.
        ''' </summary>
        Public Property Pen1() As Double
        ''' <summary>
        ''' Get or Sets the Pen2 in LiquidacionTm.
        ''' </summary>
        Public Property Pen2() As Double
        ''' <summary>
        ''' Get or Sets the Pen3 in LiquidacionTm.
        ''' </summary>
        Public Property Pen3() As Double
        ''' <summary>
        ''' Get or Sets the codigoLote in LiquidacionTm.
        ''' </summary>
        Public Property codigoLote() As String
        ''' <summary>
        ''' Get or Sets the fecha_ingreso in LiquidacionTm.
        ''' </summary>
        Public Property fecha_ingreso() As DateTime
        ''' <summary>
        ''' Get or Sets the ticket in LiquidacionTm.
        ''' </summary>
        Public Property ticket() As String
        ''' <summary>
        ''' Get or Sets the guia in LiquidacionTm.
        ''' </summary>
        Public Property guia() As String
        ''' <summary>
        ''' Get Collection of tbLiquidacion.
        ''' </summary>        
        Public Property idtablaint() As Integer


        Public Property PenCl() As Double
        Public Property PenCd() As Double
        Public Property PenF() As Double
        Public Property PenS() As Double
        Public Property PenFe() As Double
        Public Property PenAl203() As Double
        Public Property PenCo() As Double
        Public Property PenMo() As Double
        Public Property PenP() As Double
        Public Property Pen20() As Double
        Public Property Pen21() As Double
        Public Property Pen22() As Double
        Public Property Pen23() As Double
        Public Property Pen24() As Double
        Public Property Pen25() As Double
        Public Property Pen26() As Double
        Public Property Pen27() As Double
        Public Property Pen28() As Double
        Public Property Pen29() As Double
        Public Property Pen30() As Double



        ''' <summary>
        ''' Get Collection of tbLiquidacion.
        ''' </summary>        
        Public mBE_tbLiquidacion As ICollection(Of clsBE_Liquidacion)
        ''' <summary>
        ''' Gets or sets the tbLiquidacion of this LiquidacionTm
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

