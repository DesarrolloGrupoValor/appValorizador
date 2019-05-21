'@Modified:
'@01 20141006 BAL01 Se agregan campos para PP (valorPP,valorPPSol,valorTipoCambioPP)

Namespace SI.BE

    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 18/04/2011 14:12:56
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    Public Class clsBE_Liquidacion

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
        ''' Get or Sets the contratoLoteId in Liquidacion.
        ''' </summary>
        Public Property contratoLoteId() As String
        ''' <summary>
        ''' Get or Sets the liquidacionId in Liquidacion.
        ''' </summary>
        Public Property liquidacionId() As String
        ''' <summary>
        ''' Get or Sets the base1 in Liquidacion.
        ''' </summary>
        Public Property base1() As Double
        ''' <summary>
        ''' Get or Sets the escaladorMas1 in Liquidacion.
        ''' </summary>
        Public Property escaladorMas1() As Double
        ''' <summary>
        ''' Get or Sets the escaladorMenos1 in Liquidacion.
        ''' </summary>
        Public Property escaladorMenos1() As Double
        ''' <summary>
        ''' Get or Sets the base2 in Liquidacion.
        ''' </summary>
        Public Property base2() As Double
        ''' <summary>
        ''' Get or Sets the escaladorMas2 in Liquidacion.
        ''' </summary>
        Public Property escaladorMas2() As Double
        ''' <summary>
        ''' Get or Sets the escaladorMenos2 in Liquidacion.
        ''' </summary>
        Public Property escaladorMenos2() As Double
        ''' <summary>
        ''' Get or Sets the pp in Liquidacion.
        ''' </summary>
        Public Property pp() As Double
        ''' <summary>
        ''' Get or Sets the basepp in Liquidacion.
        ''' </summary>
        Public Property basepp() As Double
        ''' <summary>
        ''' Get or Sets the porcentajeMerma in Liquidacion.
        ''' </summary>
        Public Property porcentajeMerma() As Double
        ''' <summary>
        ''' Get or Sets the porcentajePago in Liquidacion.
        ''' </summary>
        Public Property porcentajePago() As Double
        ''' <summary>
        ''' Get or Sets the calculoTMSN in Liquidacion.
        ''' </summary>
        Public Property calculoTMSN() As Double
        ''' <summary>
        ''' Get or Sets the calculoPagable in Liquidacion.
        ''' </summary>
        Public Property calculoPagable() As Double
        ''' <summary>
        ''' Get or Sets the calculoMaquila in Liquidacion.
        ''' </summary>
        Public Property calculoMaquila() As Double
        ''' <summary>
        ''' Get or Sets the calculoRefinacion in Liquidacion.
        ''' </summary>
        Public Property calculoRefinacion() As Double
        ''' <summary>
        ''' Get or Sets the calculoPenalizable in Liquidacion.
        ''' </summary>
        Public Property calculoPenalizable() As Double
        ''' <summary>
        ''' Get or Sets the calculoServicio in Liquidacion.
        ''' </summary>
        Public Property calculoServicio() As Double
        ''' <summary>
        ''' Get or Sets the calculoPrecioTMSN in Liquidacion.
        ''' </summary>
        Public Property calculoPrecioTMSN() As Double
        ''' <summary>
        ''' Get or Sets the calculoCargoAjuste in Liquidacion.
        ''' </summary>
        Public Property calculoCargoAjuste() As Double
        ''' <summary>
        ''' Get or Sets the calculoPrecioUnitario in Liquidacion.
        ''' </summary>
        Public Property calculoPrecioUnitario() As Double
        ''' <summary>
        ''' Get or Sets the valorVenta in Liquidacion.
        ''' </summary>
        Public Property valorVenta() As Double
        ''' <summary>
        ''' Get or Sets the valorIgv in Liquidacion.
        ''' </summary>
        Public Property valorIgv() As Double
        ''' <summary>
        ''' Get or Sets the valorTotal in Liquidacion.
        ''' </summary>
        Public Property valorTotal() As Double
        ''' <summary>
        ''' Get or Sets the totalPorPagar in Liquidacion.
        ''' </summary>
        Public Property totalPorPagar() As Double
        ''' <summary>
        ''' Get or Sets the totalDscto in Liquidacion.
        ''' </summary>
        Public Property totalDscto() As Double
        ''' <summary>
        ''' Get or Sets the totalNetoxPagar in Liquidacion.
        ''' </summary>
        Public Property totalNetoxPagar() As Double
        ''' <summary>
        ''' Get or Sets the codigoCalculo in Liquidacion.
        ''' </summary>
        Public Property codigoCalculo() As String
        ''' <summary>
        ''' Get or Sets the periodo in Liquidacion.
        ''' </summary>
        Public Property periodo() As String
        ''' <summary>
        ''' Get or Sets the codigoDocumento in Liquidacion.
        ''' </summary>
        Public Property codigoDocumento() As String
        ''' <summary>
        ''' Get or Sets the fechaDocumento in Liquidacion.
        ''' </summary>
        Public Property fechaDocumento() As DateTime
        ''' <summary>
        ''' Get or Sets the numeroDocumento in Liquidacion.
        ''' </summary>
        Public Property numeroDocumento() As String
        ''' <summary>
        ''' Get or Sets the codigoEstado in Liquidacion.
        ''' </summary>
        Public Property codigoEstado() As String
        ''' <summary>
        ''' Get or Sets the uc in Liquidacion.
        ''' </summary>
        Public Property uc() As String
        ''' <summary>
        ''' Get or Sets the fc in Liquidacion.
        ''' </summary>
        Public Property fc() As DateTime
        ''' <summary>
        ''' Get or Sets the um in Liquidacion.
        ''' </summary>
        Public Property um() As String
        ''' <summary>
        ''' Get or Sets the fm in Liquidacion.
        ''' </summary>
        Public Property fm() As DateTime
        ''' <summary>
        ''' Get or Sets the numeroCalculo in Liquidacion.
        ''' </summary>
        Public Property numeroCalculo() As Integer
        ''' <summary>
        ''' Get or Sets the calculoTmh in Liquidacion.
        ''' </summary>
        Public Property calculoTmh() As Double
        ''' <summary>
        ''' Get or Sets the calculoH2o in Liquidacion.
        ''' </summary>
        Public Property calculoH2o() As Double
        ''' <summary>
        ''' Get or Sets the calculoTms in Liquidacion.
        ''' </summary>
        Public Property calculoTms() As Double
        ''' <summary>
        ''' Get or Sets the calculoMerma in Liquidacion.
        ''' </summary>
        Public Property calculoMerma() As Double
        ''' <summary>
        ''' Get or Sets the maquila in Liquidacion.
        ''' </summary>
        Public Property maquila() As Double
        ''' <summary>
        ''' Get or Sets the tasaInteres in Liquidacion.
        ''' </summary>
        Public Property tasaInteres() As Double
        ''' <summary>
        ''' Get or Sets the tasaMoratoria in Liquidacion.
        ''' </summary>
        Public Property tasaMoratoria() As Double
        ''' <summary>
        ''' Get or Sets the tasaTiempo in Liquidacion.
        ''' </summary>
        Public Property tasaTiempo() As Double
        ''' <summary>
        ''' Get or Sets the codigoTasa in Liquidacion.
        ''' </summary>
        Public Property codigoTasa() As String
        ''' <summary>
        ''' Get or Sets the codigoIncoterm in Liquidacion.
        ''' </summary>
        Public Property codigoIncoterm() As String
        ''' <summary>
        ''' Get or Sets the codigoDeposito in Liquidacion.
        ''' </summary>
        Public Property codigoDeposito() As String
        ''' <summary>
        ''' Get or Sets the calculoPp in Liquidacion.
        ''' </summary>
        Public Property calculoPp() As Double
        ''' <summary>
        ''' Get or Sets the cargoAjuste in Liquidacion.
        ''' </summary>
        Public Property cargoAjuste() As Double
        ''' <summary>
        ''' Get or Sets the fechaRegistro in Liquidacion.
        ''' </summary>
        Public Property fechaRegistro() As DateTime
        ''' <summary>
        ''' Get or Sets the codigoTrader in Liquidacion.
        ''' </summary>
        Public Property codigoTrader() As String
        ''' <summary>
        ''' Get or Sets the codigoAdministrador in Liquidacion.
        ''' </summary>
        Public Property codigoAdministrador() As String
        ''' <summary>
        ''' Get or Sets the codigoUsuario in Liquidacion.
        ''' </summary>
        Public Property codigoUsuario() As String
        ''' <summary>
        ''' Get or Sets the status in Liquidacion.
        ''' </summary>
        Public Property status() As String
        ''' <summary>
        ''' Get or Sets the control in Liquidacion.
        ''' </summary>
        Public Property control() As String



        Public Property H2O() As Integer
        Public Property Ajuste() As Double

        Public Property costoVenta() As Double
        Public Property ValorNeto() As Double
        Public Property tipo() As String

        '@01    A03
        Public Property valorPP() As Double
        Public Property valorPPSol() As Double
        Public Property valorTipoCambioPP() As Double



        Public Property periodoComercial() As String
        Public Property costoOperativo() As Double

        Public Property baseRc() As Double
        Public Property RcMas() As Double
        Public Property RcMenos() As Double
        Public Property RcBaseCon() As Double
        Public Property ContMas() As Double
        Public Property ContMenos() As Double


        ''' <summary>
        ''' Get Collection of tbContratoLote.
        ''' </summary>        
        Public mBE_tbContratoLote As ICollection(Of clsBE_ContratoLote)
        ''' <summary>
        ''' Gets or sets the tbContratoLote of this Liquidacion
        ''' </summary>
        Public Overridable Property tbContratoLote() As ICollection(Of clsBE_ContratoLote)
            Get
                Return Me.mBE_tbContratoLote
            End Get
            Set(ByVal value As ICollection(Of clsBE_ContratoLote))
                Me.mBE_tbContratoLote = value
            End Set
        End Property

#End Region
    End Class

End Namespace

