
Namespace  SI.BE

	''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 25/02/2011 10:15:55
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
	Public Class clsBE_LogisticaMovimiento
	
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
         ''' Get or Sets the ID in LogisticaMovimiento.
         ''' </summary>
		Public Property ID() AS Long
         ''' <summary>
         ''' Get or Sets the TMH in LogisticaMovimiento.
         ''' </summary>
		Public Property TMH() AS Integer
         ''' <summary>
         ''' Get or Sets the ContratoLoteId in LogisticaMovimiento.
         ''' </summary>
		Public Property ContratoLoteId() AS String
         ''' <summary>
         ''' Get or Sets the ESTADO in LogisticaMovimiento.
         ''' </summary>
		Public Property ESTADO() AS String
         ''' <summary>
         ''' Get or Sets the LiquidacionId in LogisticaMovimiento.
         ''' </summary>
		Public Property LiquidacionId() AS String
         ''' <summary>
         ''' Get or Sets the LiquidacionTmId in LogisticaMovimiento.
         ''' </summary>
		Public Property LiquidacionTmId() AS String
         ''' <summary>
         ''' Get or Sets the ContratoLoteSuceroaId in LogisticaMovimiento.
         ''' </summary>
		Public Property ContratoLoteSuceroaId() AS String
         ''' <summary>
         ''' Get or Sets the EstadoVCM in LogisticaMovimiento.
         ''' </summary>
		Public Property EstadoVCM() AS String
         ''' <summary>
         ''' Get or Sets the EMPRESA in LogisticaMovimiento.
         ''' </summary>
		Public Property EMPRESA() AS String
         ''' <summary>
         ''' Get or Sets the COD_DEPOSITO in LogisticaMovimiento.
         ''' </summary>
		Public Property COD_DEPOSITO() AS String
         ''' <summary>
         ''' Get or Sets the COD_LOTE in LogisticaMovimiento.
         ''' </summary>
		Public Property COD_LOTE() AS String
         ''' <summary>
         ''' Get or Sets the NRO_DOCUMENTO in LogisticaMovimiento.
         ''' </summary>
		Public Property NRO_DOCUMENTO() AS String
         ''' <summary>
         ''' Get or Sets the TIPO_MOV in LogisticaMovimiento.
         ''' </summary>
		Public Property TIPO_MOV() AS String
         ''' <summary>
         ''' Get or Sets the N_ITEM in LogisticaMovimiento.
         ''' </summary>
		Public Property N_ITEM() AS Integer
         ''' <summary>
         ''' Get or Sets the EMPRESA_ORIGEN in LogisticaMovimiento.
         ''' </summary>
		Public Property EMPRESA_ORIGEN() AS String
         ''' <summary>
         ''' Get or Sets the DEPOSITO_ORIGEN in LogisticaMovimiento.
         ''' </summary>
		Public Property DEPOSITO_ORIGEN() AS String
         ''' <summary>
         ''' Get or Sets the LOTE_ORIGEN in LogisticaMovimiento.
         ''' </summary>
		Public Property LOTE_ORIGEN() AS String
         ''' <summary>
         ''' Get or Sets the EMPRESA_DESTINO in LogisticaMovimiento.
         ''' </summary>
		Public Property EMPRESA_DESTINO() AS String
         ''' <summary>
         ''' Get or Sets the DEPOSITO_DESTINO in LogisticaMovimiento.
         ''' </summary>
		Public Property DEPOSITO_DESTINO() AS String
         ''' <summary>
         ''' Get or Sets the LOTE_DESTINO in LogisticaMovimiento.
         ''' </summary>
		Public Property LOTE_DESTINO() AS String
         ''' <summary>
         ''' Get or Sets the PERIODO in LogisticaMovimiento.
         ''' </summary>
		Public Property PERIODO() AS String
         ''' <summary>
         ''' Get or Sets the NUM_CONTRATO in LogisticaMovimiento.
         ''' </summary>
		Public Property NUM_CONTRATO() AS String
         ''' <summary>
         ''' Get or Sets the FECHA_APERTURA in LogisticaMovimiento.
         ''' </summary>
		Public Property FECHA_APERTURA() AS DateTime
         ''' <summary>
         ''' Get or Sets the ELEMENTO_MINERAL in LogisticaMovimiento.
         ''' </summary>
		Public Property ELEMENTO_MINERAL() AS String
         ''' <summary>
         ''' Get or Sets the TIPO_MINERAL in LogisticaMovimiento.
         ''' </summary>
		Public Property TIPO_MINERAL() AS String
         ''' <summary>
         ''' Get or Sets the EMP_PROV_CLIENTE in LogisticaMovimiento.
         ''' </summary>
		Public Property EMP_PROV_CLIENTE() AS String
         ''' <summary>
         ''' Get or Sets the TMH_SLC in LogisticaMovimiento.
         ''' </summary>
		Public Property TMH_SLC() AS Double
         ''' <summary>
         ''' Get or Sets the ESTADO_SLC in LogisticaMovimiento.
         ''' </summary>
		Public Property ESTADO_SLC() AS Integer
         ''' <summary>
         ''' Get or Sets the IND_GUIA_PROVFIN in LogisticaMovimiento.
         ''' </summary>
		Public Property IND_GUIA_PROVFIN() AS Integer
         ''' <summary>
         ''' Get or Sets the IND_ASIGNA_PART in LogisticaMovimiento.
         ''' </summary>
		Public Property IND_ASIGNA_PART() AS Integer
         ''' <summary>
         ''' Get or Sets the IND_ASIGNA_VCL in LogisticaMovimiento.
         ''' </summary>
		Public Property IND_ASIGNA_VCL() AS Integer
         ''' <summary>
         ''' Get or Sets the IND_ASIGNA_BLEND in LogisticaMovimiento.
         ''' </summary>
		Public Property IND_ASIGNA_BLEND() AS Integer
         ''' <summary>
         ''' Get or Sets the IND_ASIGNA_DESP in LogisticaMovimiento.
         ''' </summary>
		Public Property IND_ASIGNA_DESP() AS Integer
         ''' <summary>
         ''' Get or Sets the IND_ASIGNA_LOTE in LogisticaMovimiento.
         ''' </summary>
		Public Property IND_ASIGNA_LOTE() AS Integer
         ''' <summary>
         ''' Get or Sets the TICKET in LogisticaMovimiento.
         ''' </summary>
		Public Property TICKET() AS String
         ''' <summary>
         ''' Get or Sets the NRO_MUESTRA in LogisticaMovimiento.
         ''' </summary>
		Public Property NRO_MUESTRA() AS String
         ''' <summary>
         ''' Get or Sets the H2O in LogisticaMovimiento.
         ''' </summary>
		Public Property H2O() AS Double
         ''' <summary>
         ''' Get or Sets the LEY_CU in LogisticaMovimiento.
         ''' </summary>
		Public Property LEY_CU() AS Double
         ''' <summary>
         ''' Get or Sets the LEY_AG in LogisticaMovimiento.
         ''' </summary>
		Public Property LEY_AG() AS Double
         ''' <summary>
         ''' Get or Sets the LEY_AU in LogisticaMovimiento.
         ''' </summary>
		Public Property LEY_AU() AS Double
         ''' <summary>
         ''' Get or Sets the LEY_PB in LogisticaMovimiento.
         ''' </summary>
		Public Property LEY_PB() AS Double
         ''' <summary>
         ''' Get or Sets the LEY_ZN in LogisticaMovimiento.
         ''' </summary>
		Public Property LEY_ZN() AS Double
         ''' <summary>
         ''' Get or Sets the LEY_SN in LogisticaMovimiento.
         ''' </summary>
		Public Property LEY_SN() AS Double
         ''' <summary>
         ''' Get or Sets the LEY_AS in LogisticaMovimiento.
         ''' </summary>
		Public Property LEY_AS() AS Double
         ''' <summary>
         ''' Get or Sets the LEY_SB in LogisticaMovimiento.
         ''' </summary>
		Public Property LEY_SB() AS Double
         ''' <summary>
         ''' Get or Sets the LEY_BI in LogisticaMovimiento.
         ''' </summary>
		Public Property LEY_BI() AS Double
         ''' <summary>
         ''' Get or Sets the LEY_HG in LogisticaMovimiento.
         ''' </summary>
		Public Property LEY_HG() AS Double
         ''' <summary>
         ''' Get or Sets the LEY_SIO2 in LogisticaMovimiento.
         ''' </summary>
		Public Property LEY_SIO2() AS Double
         ''' <summary>
         ''' Get or Sets the LEY_AS_SB in LogisticaMovimiento.
         ''' </summary>
		Public Property LEY_AS_SB() AS Double
         ''' <summary>
         ''' Get or Sets the LEY_ZN_PB in LogisticaMovimiento.
         ''' </summary>
		Public Property LEY_ZN_PB() AS Double
         ''' <summary>
         ''' Get or Sets the LEY_AUNW in LogisticaMovimiento.
         ''' </summary>
		Public Property LEY_AUNW() AS Double
         ''' <summary>
         ''' Get or Sets the LEY_CUTOT in LogisticaMovimiento.
         ''' </summary>
		Public Property LEY_CUTOT() AS Double
         ''' <summary>
         ''' Get or Sets the LEY_CUSOL in LogisticaMovimiento.
         ''' </summary>
		Public Property LEY_CUSOL() AS Double
         ''' <summary>
         ''' Get or Sets the LEY_CNNa in LogisticaMovimiento.
         ''' </summary>
		Public Property LEY_CNNa() AS Double
         ''' <summary>
         ''' Get or Sets the LEY_CAL in LogisticaMovimiento.
         ''' </summary>
		Public Property LEY_CAL() AS Double
         ''' <summary>
         ''' Get or Sets the LEY_SOD in LogisticaMovimiento.
         ''' </summary>
		Public Property LEY_SOD() AS Double



        Public Property EMPRESA_CLI() As String
        Public Property CATEGORIA() As String



#End Region
    End Class	
    
End Namespace

