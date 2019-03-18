
Namespace  SI.BE

	''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:44
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
    Public Class clsBE_FINANCIANDO_PRELIQ

#Region "Constructor"
        Public Sub New()
            MyBase.New()
        End Sub

#End Region
     
#Region " Declaracion de Miembros "
        'Public Item As Integer

        ''' <summary>
        ''' Get or Sets the ITEM in FINANCIANDO_PRELIQ.
        ''' </summary>
        Public Property Item() As Integer
        ''' <summary>
        ''' Get or Sets the NUM_COMPR_LIQ in FINANCIANDO_PRELIQ.
        ''' </summary>
        Public Property NUM_COMPR_LIQ() As String
        ''' <summary>
        ''' Get or Sets the MONTO_TOTAL_LIQ in FINANCIANDO_PRELIQ.
        ''' </summary>
        Public Property MONTO_TOTAL_LIQ() As Double
        

        Public Property CONTRATO() As String
        Public Property LOTE() As String



        Public Property proveedor() As String


        Public Property AdDiferido() As String
        Public Property Td() As String
        Public Property COMPROBANTE() As String
        Public Property Sq() As String
        Public Property FCH_PROGPAGO() As Date
        Public Property Gasto() As String
        Public Property NRO_DOC() As String
        Public Property RUMA() As String
        Public Property Tad() As String
        Public Property Calidad() As String
        Public Property Moneda() As String
        Public Property Monto() As Double
        Public Property Monto_Us() As Double
        Public Property Monto_Apli() As Double
        Public Property Saldo_US() As Double
        Public Property Aplicar_US() As Double
        Public Property c_IGV() As Double
        Public Property Dh() As String
        Public Property ESTADO() As String
        Public Property Fch_Div() As Date
        Public Property NRO_OP() As String
        Public Property Observaciones() As String


        Public Property NOMBRE_EMPRESA As String
        Public Property MONTO_AP As Double

        Public Property aplicar As Double
        Public Property SALDO_CIGV As Double




        Public Property scondicion_empresa As String
        Public Property scondicion_nro_op As String
        Public Property scondicion_tipo_op As String
        Public Property scondicion_tipo_compr As String
        Public Property scondicion_num_compr As String
        Public Property scondicion_seq As String




        Public Property estado_fin As String
        Public Property flg_aplica As String
        Public Property flg_diferido As String

        Public Property empresa As String
        'Public Property nro_op As String
        Public Property tipo_op As String
        Public Property TIPO_COMPR As String
        Public Property num_compr As String
        Public Property seq As String

        Public Property tipo_compr_liq As String
        'Public Property num_compr_liq As String

        Public Property usuario_liq As String
        Public Property monto_Liq As Double
        Public Property monto_Liq_CIGV As Double
        Public Property monto_tot_liq As Double
        Public Property cod_lote As String
        Public Property LOTE_COM As String
        Public Property proveedor_liq As String
        Public Property estado_liq As String


        Public Property sOperacion As String
        Public Property sContratoLoteId As String
        Public Property sLiquidacionId As String
        Public Property dFechaLiquidacion As DateTime

        Public Property stablaDetId() As String

#End Region
    End Class
    
End Namespace

