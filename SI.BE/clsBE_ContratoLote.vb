'Modified:
'@01 20141016 BAL01 Se agregan campos no relacionados liquidacionId, periodo, asientoContable

Namespace SI.BE

    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 18/04/2011 14:12:22
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    Public Class clsBE_ContratoLote

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
        ''' Get or Sets the contratoLoteId in ContratoLote.
        ''' </summary>
        Public Property contratoLoteId() As String
        ''' <summary>
        ''' Get or Sets the codigoTabla in ContratoLote.
        ''' </summary>
        Public Property codigoTabla() As String
        ''' <summary>
        ''' Get or Sets the codigoMovimiento in ContratoLote.
        ''' </summary>
        Public Property codigoMovimiento() As String
        ''' <summary>
        ''' Get or Sets the contrato in ContratoLote.
        ''' </summary>
        Public Property contrato() As String
        ''' <summary>
        ''' Get or Sets the codigoEmpresa in ContratoLote.
        ''' </summary>
        Public Property codigoEmpresa() As String
        ''' <summary>
        ''' Get or Sets the codigoSocio in ContratoLote.
        ''' </summary>
        Public Property codigoSocio() As String
        ''' <summary>
        ''' Get or Sets the lote in ContratoLote.
        ''' </summary>
        Public Property lote() As String
        ''' <summary>
        ''' Get or Sets the codigoClase in ContratoLote.
        ''' </summary>
        Public Property codigoClase() As String
        ''' <summary>
        ''' Get or Sets the codigoProducto in ContratoLote.
        ''' </summary>
        Public Property codigoProducto() As String
        ''' <summary>
        ''' Get or Sets the cuota in ContratoLote.
        ''' </summary>
        Public Property cuota() As String
        ''' <summary>
        ''' Get or Sets the direccion in ContratoLote.
        ''' </summary>
        Public Property direccion() As String
        ''' <summary>
        ''' Get or Sets the codigoEstado in ContratoLote.
        ''' </summary>
        Public Property codigoEstado() As String
        ''' <summary>
        ''' Get or Sets the uc in ContratoLote.
        ''' </summary>
        Public Property uc() As String
        ''' <summary>
        ''' Get or Sets the fc in ContratoLote.
        ''' </summary>
        Public Property fc() As DateTime
        ''' <summary>
        ''' Get or Sets the um in ContratoLote.
        ''' </summary>
        Public Property um() As String
        ''' <summary>
        ''' Get or Sets the fm in ContratoLote.
        ''' </summary>
        Public Property fm() As DateTime
        ''' <summary>
        ''' Get or Sets the tmAnualMinimo in ContratoLote.
        ''' </summary>
        Public Property tmAnualMinimo() As Double
        ''' <summary>
        ''' Get or Sets the tmAnualMaximo in ContratoLote.
        ''' </summary>
        Public Property tmAnualMaximo() As Double
        ''' <summary>
        ''' Get or Sets the tmMensualMinimo in ContratoLote.
        ''' </summary>
        Public Property tmMensualMinimo() As Double
        ''' <summary>
        ''' Get or Sets the tmMensualMaximo in ContratoLote.
        ''' </summary>
        Public Property tmMensualMaximo() As Double
        ''' <summary>
        ''' Get or Sets the adenda in ContratoLote.
        ''' </summary>
        Public Property adenda() As String
        ''' <summary>
        ''' Get or Sets the calidad in ContratoLote.
        ''' </summary>
        Public Property calidad() As String
        ''' <summary>
        ''' Get or Sets the VigenciaInicio in ContratoLote.
        ''' </summary>
        Public Property VigenciaInicio() As DateTime
        ''' <summary>
        ''' Get or Sets the VigenciaFin in ContratoLote.
        ''' </summary>
        Public Property VigenciaFin() As DateTime
        ''' <summary>
        ''' Get or Sets the procedencia in ContratoLote.
        ''' </summary>
        Public Property procedencia() As String
        ''' <summary>
        ''' Get or Sets the comentarios in ContratoLote.
        ''' </summary>
        Public Property comentarios() As String
        ''' <summary>
        ''' Get or Sets the codigoModo in ContratoLote.
        ''' </summary>
        Public Property codigoModo() As String
        ''' <summary>
        ''' Get or Sets the codigoModo in ContratoLote.
        ''' </summary>
        Public Property codigoCalidad() As String

        Public Property descuento() As Double
        Public Property otrosDescuentos() As Double


        Public Property adelanto() As Double

        Public Property ref1() As String

        Public Property ref2() As String

        Public Property ref3() As Double

        Public Property ref4() As Double


        Public Property detraccion() As Double


        Public Property rucEmpresa() As String

        Public Property permiso() As String


        Public Property categoria() As String


        Public Property LOTE_CERRADO() As String

        Public Property preliquidacionFija As String


        ''' <summary>
        ''' Get or Sets the loteNuevo in ContratoLote.
        ''' </summary>
        Public Property loteNuevo() As String

        '@01    A03
        Public Property liquidacionId() As String
        Public Property periodo() As String
        Public Property asientocontable() As Decimal
        Public Property periodo_origen() As String
        Public Property periodo_destino() As String

#End Region
    End Class

End Namespace

