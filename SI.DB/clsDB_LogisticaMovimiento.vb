


Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports SI.BE
Imports SI.UT
Imports Microsoft.ApplicationBlocks.Data

Namespace SI.DB

#Region "Clase Escritura"

    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 25/02/2011 10:15:55
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla LogisticaMovimiento
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsDB_LogisticaMovimientoTX

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionIN")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("IN")
        End Sub
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 25/02/2011 10:15:55
        ''' Proposito: Metodo de Insercci?n de Datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function InsertarLogisticaMovimiento(ByVal oLstLogisticaMovimiento As List(Of clsBE_LogisticaMovimiento)) As Boolean
            For Each oLogisticaMovimiento As clsBE_LogisticaMovimiento In oLstLogisticaMovimiento
                Dim prmParameter(54) As SqlParameter

                prmParameter(0) = New SqlParameter("@pTMH", SqlDbType.Float, 4)
                prmParameter(0).Value = IIf(IsNothing(oLogisticaMovimiento.TMH), 0, oLogisticaMovimiento.TMH)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pContratoLoteId", SqlDbType.varchar, 20)
                prmParameter(1).Value = IIf(IsNothing(oLogisticaMovimiento.ContratoLoteId), "", oLogisticaMovimiento.ContratoLoteId)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pESTADO", SqlDbType.varchar, 1)
                prmParameter(2).Value = IIf(IsNothing(oLogisticaMovimiento.ESTADO), 0, oLogisticaMovimiento.ESTADO)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@pLiquidacionId", SqlDbType.varchar, 20)
                prmParameter(3).Value = IIf(IsNothing(oLogisticaMovimiento.LiquidacionId), "", oLogisticaMovimiento.LiquidacionId)
                prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@pLiquidacionTmId", SqlDbType.varchar, 20)
                prmParameter(4).Value = IIf(IsNothing(oLogisticaMovimiento.LiquidacionTmId), "", oLogisticaMovimiento.LiquidacionTmId)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@pContratoLoteSuceroaId", SqlDbType.varchar, 20)
                prmParameter(5).Value = IIf(IsNothing(oLogisticaMovimiento.ContratoLoteSuceroaId), "", oLogisticaMovimiento.ContratoLoteSuceroaId)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@pEstadoVCM", SqlDbType.varchar, 1)
                prmParameter(6).Value = IIf(IsNothing(oLogisticaMovimiento.EstadoVCM), 0, oLogisticaMovimiento.EstadoVCM)
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7) = New SqlParameter("@pEMPRESA", SqlDbType.varchar, 15)
                prmParameter(7).Value = IIf(IsNothing(oLogisticaMovimiento.EMPRESA), "", oLogisticaMovimiento.EMPRESA)
                prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(8) = New SqlParameter("@pCOD_DEPOSITO", SqlDbType.varchar, 3)
                prmParameter(8).Value = IIf(IsNothing(oLogisticaMovimiento.COD_DEPOSITO), "", oLogisticaMovimiento.COD_DEPOSITO)
                prmParameter(8).Direction = ParameterDirection.Input
                prmParameter(9) = New SqlParameter("@pCOD_LOTE", SqlDbType.varchar, 20)
                prmParameter(9).Value = IIf(IsNothing(oLogisticaMovimiento.COD_LOTE), "", oLogisticaMovimiento.COD_LOTE)
                prmParameter(9).Direction = ParameterDirection.Input
                prmParameter(10) = New SqlParameter("@pNRO_DOCUMENTO", SqlDbType.varchar, 12)
                prmParameter(10).Value = IIf(IsNothing(oLogisticaMovimiento.NRO_DOCUMENTO), "", oLogisticaMovimiento.NRO_DOCUMENTO)
                prmParameter(10).Direction = ParameterDirection.Input
                prmParameter(11) = New SqlParameter("@pTIPO_MOV", SqlDbType.varchar, 2)
                prmParameter(11).Value = IIf(IsNothing(oLogisticaMovimiento.TIPO_MOV), "", oLogisticaMovimiento.TIPO_MOV)
                prmParameter(11).Direction = ParameterDirection.Input
                prmParameter(12) = New SqlParameter("@pN_ITEM", SqlDbType.Int, 4)
                prmParameter(12).Value = IIf(IsNothing(oLogisticaMovimiento.N_ITEM), 0, oLogisticaMovimiento.N_ITEM)
                prmParameter(12).Direction = ParameterDirection.Input
                prmParameter(13) = New SqlParameter("@pEMPRESA_ORIGEN", SqlDbType.varchar, 15)
                prmParameter(13).Value = IIf(IsNothing(oLogisticaMovimiento.EMPRESA_ORIGEN), "", oLogisticaMovimiento.EMPRESA_ORIGEN)
                prmParameter(13).Direction = ParameterDirection.Input
                prmParameter(14) = New SqlParameter("@pDEPOSITO_ORIGEN", SqlDbType.varchar, 3)
                prmParameter(14).Value = IIf(IsNothing(oLogisticaMovimiento.DEPOSITO_ORIGEN), "", oLogisticaMovimiento.DEPOSITO_ORIGEN)
                prmParameter(14).Direction = ParameterDirection.Input
                prmParameter(15) = New SqlParameter("@pLOTE_ORIGEN", SqlDbType.varchar, 20)
                prmParameter(15).Value = IIf(IsNothing(oLogisticaMovimiento.LOTE_ORIGEN), "", oLogisticaMovimiento.LOTE_ORIGEN)
                prmParameter(15).Direction = ParameterDirection.Input
                prmParameter(16) = New SqlParameter("@pEMPRESA_DESTINO", SqlDbType.varchar, 15)
                prmParameter(16).Value = IIf(IsNothing(oLogisticaMovimiento.EMPRESA_DESTINO), "", oLogisticaMovimiento.EMPRESA_DESTINO)
                prmParameter(16).Direction = ParameterDirection.Input
                prmParameter(17) = New SqlParameter("@pDEPOSITO_DESTINO", SqlDbType.varchar, 3)
                prmParameter(17).Value = IIf(IsNothing(oLogisticaMovimiento.DEPOSITO_DESTINO), "", oLogisticaMovimiento.DEPOSITO_DESTINO)
                prmParameter(17).Direction = ParameterDirection.Input
                prmParameter(18) = New SqlParameter("@pLOTE_DESTINO", SqlDbType.varchar, 20)
                prmParameter(18).Value = IIf(IsNothing(oLogisticaMovimiento.LOTE_DESTINO), "", oLogisticaMovimiento.LOTE_DESTINO)
                prmParameter(18).Direction = ParameterDirection.Input
                prmParameter(19) = New SqlParameter("@pPERIODO", SqlDbType.varchar, 6)
                prmParameter(19).Value = IIf(IsNothing(oLogisticaMovimiento.PERIODO), "", oLogisticaMovimiento.PERIODO)
                prmParameter(19).Direction = ParameterDirection.Input
                prmParameter(20) = New SqlParameter("@pNUM_CONTRATO", SqlDbType.varchar, 10)
                prmParameter(20).Value = IIf(IsNothing(oLogisticaMovimiento.NUM_CONTRATO), "", oLogisticaMovimiento.NUM_CONTRATO)
                prmParameter(20).Direction = ParameterDirection.Input
                prmParameter(21) = New SqlParameter("@pFECHA_APERTURA", SqlDbType.DateTime, 8)
                prmParameter(21).Value = clsUT_Funcion.FechaNull(oLogisticaMovimiento.FECHA_APERTURA)
                prmParameter(21).Direction = ParameterDirection.Input
                prmParameter(22) = New SqlParameter("@pELEMENTO_MINERAL", SqlDbType.varchar, 3)
                prmParameter(22).Value = IIf(IsNothing(oLogisticaMovimiento.ELEMENTO_MINERAL), "", oLogisticaMovimiento.ELEMENTO_MINERAL)
                prmParameter(22).Direction = ParameterDirection.Input
                prmParameter(23) = New SqlParameter("@pTIPO_MINERAL", SqlDbType.varchar, 6)
                prmParameter(23).Value = IIf(IsNothing(oLogisticaMovimiento.TIPO_MINERAL), "", oLogisticaMovimiento.TIPO_MINERAL)
                prmParameter(23).Direction = ParameterDirection.Input
                prmParameter(24) = New SqlParameter("@pEMP_PROV_CLIENTE", SqlDbType.varchar, 15)
                prmParameter(24).Value = IIf(IsNothing(oLogisticaMovimiento.EMP_PROV_CLIENTE), "", oLogisticaMovimiento.EMP_PROV_CLIENTE)
                prmParameter(24).Direction = ParameterDirection.Input
                prmParameter(25) = New SqlParameter("@pTMH_SLC", SqlDbType.Float, 5)
                prmParameter(25).Value = IIf(IsNothing(oLogisticaMovimiento.TMH_SLC), 0, oLogisticaMovimiento.TMH_SLC)
                prmParameter(25).Direction = ParameterDirection.Input
                prmParameter(26) = New SqlParameter("@pESTADO_SLC", SqlDbType.Int, 4)
                prmParameter(26).Value = IIf(IsNothing(oLogisticaMovimiento.ESTADO_SLC), 0, oLogisticaMovimiento.ESTADO_SLC)
                prmParameter(26).Direction = ParameterDirection.Input
                prmParameter(27) = New SqlParameter("@pIND_GUIA_PROVFIN", SqlDbType.Int, 4)
                prmParameter(27).Value = IIf(IsNothing(oLogisticaMovimiento.IND_GUIA_PROVFIN), 0, oLogisticaMovimiento.IND_GUIA_PROVFIN)
                prmParameter(27).Direction = ParameterDirection.Input
                prmParameter(28) = New SqlParameter("@pIND_ASIGNA_PART", SqlDbType.Int, 4)
                prmParameter(28).Value = IIf(IsNothing(oLogisticaMovimiento.IND_ASIGNA_PART), 0, oLogisticaMovimiento.IND_ASIGNA_PART)
                prmParameter(28).Direction = ParameterDirection.Input
                prmParameter(29) = New SqlParameter("@pIND_ASIGNA_VCL", SqlDbType.Int, 4)
                prmParameter(29).Value = IIf(IsNothing(oLogisticaMovimiento.IND_ASIGNA_VCL), 0, oLogisticaMovimiento.IND_ASIGNA_VCL)
                prmParameter(29).Direction = ParameterDirection.Input
                prmParameter(30) = New SqlParameter("@pIND_ASIGNA_BLEND", SqlDbType.Int, 4)
                prmParameter(30).Value = IIf(IsNothing(oLogisticaMovimiento.IND_ASIGNA_BLEND), 0, oLogisticaMovimiento.IND_ASIGNA_BLEND)
                prmParameter(30).Direction = ParameterDirection.Input
                prmParameter(31) = New SqlParameter("@pIND_ASIGNA_DESP", SqlDbType.Int, 4)
                prmParameter(31).Value = IIf(IsNothing(oLogisticaMovimiento.IND_ASIGNA_DESP), 0, oLogisticaMovimiento.IND_ASIGNA_DESP)
                prmParameter(31).Direction = ParameterDirection.Input
                prmParameter(32) = New SqlParameter("@pIND_ASIGNA_LOTE", SqlDbType.Int, 4)
                prmParameter(32).Value = IIf(IsNothing(oLogisticaMovimiento.IND_ASIGNA_LOTE), 0, oLogisticaMovimiento.IND_ASIGNA_LOTE)
                prmParameter(32).Direction = ParameterDirection.Input
                prmParameter(33) = New SqlParameter("@pTICKET", SqlDbType.varchar, 10)
                prmParameter(33).Value = IIf(IsNothing(oLogisticaMovimiento.TICKET), 0, oLogisticaMovimiento.TICKET)
                prmParameter(33).Direction = ParameterDirection.Input
                prmParameter(34) = New SqlParameter("@pNRO_MUESTRA", SqlDbType.varchar, 12)
                prmParameter(34).Value = IIf(IsNothing(oLogisticaMovimiento.NRO_MUESTRA), 0, oLogisticaMovimiento.NRO_MUESTRA)
                prmParameter(34).Direction = ParameterDirection.Input
                prmParameter(35) = New SqlParameter("@pH2O", SqlDbType.Float, 5)
                prmParameter(35).Value = IIf(IsNothing(oLogisticaMovimiento.H2O), 0, oLogisticaMovimiento.H2O)
                prmParameter(35).Direction = ParameterDirection.Input
                prmParameter(36) = New SqlParameter("@pLEY_CU", SqlDbType.Float, 5)
                prmParameter(36).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_CU), 0, oLogisticaMovimiento.LEY_CU)
                prmParameter(36).Direction = ParameterDirection.Input
                prmParameter(37) = New SqlParameter("@pLEY_AG", SqlDbType.Float, 5)
                prmParameter(37).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_AG), 0, oLogisticaMovimiento.LEY_AG)
                prmParameter(37).Direction = ParameterDirection.Input
                prmParameter(38) = New SqlParameter("@pLEY_AU", SqlDbType.Float, 5)
                prmParameter(38).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_AU), 0, oLogisticaMovimiento.LEY_AU)
                prmParameter(38).Direction = ParameterDirection.Input
                prmParameter(39) = New SqlParameter("@pLEY_PB", SqlDbType.Float, 5)
                prmParameter(39).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_PB), 0, oLogisticaMovimiento.LEY_PB)
                prmParameter(39).Direction = ParameterDirection.Input
                prmParameter(40) = New SqlParameter("@pLEY_ZN", SqlDbType.Float, 5)
                prmParameter(40).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_ZN), 0, oLogisticaMovimiento.LEY_ZN)
                prmParameter(40).Direction = ParameterDirection.Input
                prmParameter(41) = New SqlParameter("@pLEY_SN", SqlDbType.Float, 5)
                prmParameter(41).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_SN), 0, oLogisticaMovimiento.LEY_SN)
                prmParameter(41).Direction = ParameterDirection.Input
                prmParameter(42) = New SqlParameter("@pLEY_AS", SqlDbType.Float, 5)
                prmParameter(42).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_AS), 0, oLogisticaMovimiento.LEY_AS)
                prmParameter(42).Direction = ParameterDirection.Input
                prmParameter(43) = New SqlParameter("@pLEY_SB", SqlDbType.Float, 5)
                prmParameter(43).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_SB), 0, oLogisticaMovimiento.LEY_SB)
                prmParameter(43).Direction = ParameterDirection.Input
                prmParameter(44) = New SqlParameter("@pLEY_BI", SqlDbType.Float, 5)
                prmParameter(44).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_BI), 0, oLogisticaMovimiento.LEY_BI)
                prmParameter(44).Direction = ParameterDirection.Input
                prmParameter(45) = New SqlParameter("@pLEY_HG", SqlDbType.Float, 5)
                prmParameter(45).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_HG), 0, oLogisticaMovimiento.LEY_HG)
                prmParameter(45).Direction = ParameterDirection.Input
                prmParameter(46) = New SqlParameter("@pLEY_SIO2", SqlDbType.Float, 5)
                prmParameter(46).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_SIO2), 0, oLogisticaMovimiento.LEY_SIO2)
                prmParameter(46).Direction = ParameterDirection.Input
                prmParameter(47) = New SqlParameter("@pLEY_AS_SB", SqlDbType.Float, 5)
                prmParameter(47).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_AS_SB), 0, oLogisticaMovimiento.LEY_AS_SB)
                prmParameter(47).Direction = ParameterDirection.Input
                prmParameter(48) = New SqlParameter("@pLEY_ZN_PB", SqlDbType.Float, 5)
                prmParameter(48).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_ZN_PB), 0, oLogisticaMovimiento.LEY_ZN_PB)
                prmParameter(48).Direction = ParameterDirection.Input
                prmParameter(49) = New SqlParameter("@pLEY_AUNW", SqlDbType.Float, 5)
                prmParameter(49).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_AUNW), 0, oLogisticaMovimiento.LEY_AUNW)
                prmParameter(49).Direction = ParameterDirection.Input
                prmParameter(50) = New SqlParameter("@pLEY_CUTOT", SqlDbType.Float, 5)
                prmParameter(50).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_CUTOT), 0, oLogisticaMovimiento.LEY_CUTOT)
                prmParameter(50).Direction = ParameterDirection.Input
                prmParameter(51) = New SqlParameter("@pLEY_CUSOL", SqlDbType.Float, 5)
                prmParameter(51).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_CUSOL), 0, oLogisticaMovimiento.LEY_CUSOL)
                prmParameter(51).Direction = ParameterDirection.Input
                prmParameter(52) = New SqlParameter("@pLEY_CNNa", SqlDbType.Float, 5)
                prmParameter(52).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_CNNa), 0, oLogisticaMovimiento.LEY_CNNa)
                prmParameter(52).Direction = ParameterDirection.Input
                prmParameter(53) = New SqlParameter("@pLEY_CAL", SqlDbType.Float, 5)
                prmParameter(53).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_CAL), 0, oLogisticaMovimiento.LEY_CAL)
                prmParameter(53).Direction = ParameterDirection.Input
                prmParameter(54) = New SqlParameter("@pLEY_SOD", SqlDbType.Float, 5)
                prmParameter(54).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_SOD), 0, oLogisticaMovimiento.LEY_SOD)
                prmParameter(54).Direction = ParameterDirection.Input
                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LogisticaMovimiento_Ins", prmParameter)
                Catch ex As Exception
                    Throw ex
                    Return False
                End Try
            Next
            Return True
        End Function
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 25/02/2011 10:15:55
        ''' Proposito: Metodo de Modificacion de datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function ModificarLogisticaMovimiento(ByVal oLstLogisticaMovimiento As List(Of clsBE_LogisticaMovimiento)) As Boolean
            For Each oLogisticaMovimiento As clsBE_LogisticaMovimiento In oLstLogisticaMovimiento
                Dim prmParameter(55) As SqlParameter
                prmParameter(0) = New SqlParameter("@pID", SqlDbType.bigint, 8)
                prmParameter(0).Value = IIf(IsNothing(oLogisticaMovimiento.ID), 0, oLogisticaMovimiento.ID)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pTMH", SqlDbType.Float, 4)
                prmParameter(1).Value = IIf(IsNothing(oLogisticaMovimiento.TMH), 0, oLogisticaMovimiento.TMH)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pContratoLoteId", SqlDbType.varchar, 20)
                prmParameter(2).Value = IIf(IsNothing(oLogisticaMovimiento.ContratoLoteId), "", oLogisticaMovimiento.ContratoLoteId)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@pESTADO", SqlDbType.varchar, 1)
                prmParameter(3).Value = IIf(IsNothing(oLogisticaMovimiento.ESTADO), 0, oLogisticaMovimiento.ESTADO)
                prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@pLiquidacionId", SqlDbType.varchar, 20)
                prmParameter(4).Value = IIf(IsNothing(oLogisticaMovimiento.LiquidacionId), "", oLogisticaMovimiento.LiquidacionId)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@pLiquidacionTmId", SqlDbType.varchar, 20)
                prmParameter(5).Value = IIf(IsNothing(oLogisticaMovimiento.LiquidacionTmId), "", oLogisticaMovimiento.LiquidacionTmId)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@pContratoLoteSuceroaId", SqlDbType.varchar, 20)
                prmParameter(6).Value = IIf(IsNothing(oLogisticaMovimiento.ContratoLoteSuceroaId), "", oLogisticaMovimiento.ContratoLoteSuceroaId)
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7) = New SqlParameter("@pEstadoVCM", SqlDbType.varchar, 1)
                prmParameter(7).Value = IIf(IsNothing(oLogisticaMovimiento.EstadoVCM), 0, oLogisticaMovimiento.EstadoVCM)
                prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(8) = New SqlParameter("@pEMPRESA", SqlDbType.varchar, 15)
                prmParameter(8).Value = IIf(IsNothing(oLogisticaMovimiento.EMPRESA), "", oLogisticaMovimiento.EMPRESA)
                prmParameter(8).Direction = ParameterDirection.Input
                prmParameter(9) = New SqlParameter("@pCOD_DEPOSITO", SqlDbType.varchar, 3)
                prmParameter(9).Value = IIf(IsNothing(oLogisticaMovimiento.COD_DEPOSITO), "", oLogisticaMovimiento.COD_DEPOSITO)
                prmParameter(9).Direction = ParameterDirection.Input
                prmParameter(10) = New SqlParameter("@pCOD_LOTE", SqlDbType.varchar, 20)
                prmParameter(10).Value = IIf(IsNothing(oLogisticaMovimiento.COD_LOTE), "", oLogisticaMovimiento.COD_LOTE)
                prmParameter(10).Direction = ParameterDirection.Input
                prmParameter(11) = New SqlParameter("@pNRO_DOCUMENTO", SqlDbType.varchar, 12)
                prmParameter(11).Value = IIf(IsNothing(oLogisticaMovimiento.NRO_DOCUMENTO), "", oLogisticaMovimiento.NRO_DOCUMENTO)
                prmParameter(11).Direction = ParameterDirection.Input
                prmParameter(12) = New SqlParameter("@pTIPO_MOV", SqlDbType.varchar, 2)
                prmParameter(12).Value = IIf(IsNothing(oLogisticaMovimiento.TIPO_MOV), "", oLogisticaMovimiento.TIPO_MOV)
                prmParameter(12).Direction = ParameterDirection.Input
                prmParameter(13) = New SqlParameter("@pN_ITEM", SqlDbType.Int, 4)
                prmParameter(13).Value = IIf(IsNothing(oLogisticaMovimiento.N_ITEM), 0, oLogisticaMovimiento.N_ITEM)
                prmParameter(13).Direction = ParameterDirection.Input
                prmParameter(14) = New SqlParameter("@pEMPRESA_ORIGEN", SqlDbType.varchar, 15)
                prmParameter(14).Value = IIf(IsNothing(oLogisticaMovimiento.EMPRESA_ORIGEN), "", oLogisticaMovimiento.EMPRESA_ORIGEN)
                prmParameter(14).Direction = ParameterDirection.Input
                prmParameter(15) = New SqlParameter("@pDEPOSITO_ORIGEN", SqlDbType.varchar, 3)
                prmParameter(15).Value = IIf(IsNothing(oLogisticaMovimiento.DEPOSITO_ORIGEN), "", oLogisticaMovimiento.DEPOSITO_ORIGEN)
                prmParameter(15).Direction = ParameterDirection.Input
                prmParameter(16) = New SqlParameter("@pLOTE_ORIGEN", SqlDbType.varchar, 20)
                prmParameter(16).Value = IIf(IsNothing(oLogisticaMovimiento.LOTE_ORIGEN), "", oLogisticaMovimiento.LOTE_ORIGEN)
                prmParameter(16).Direction = ParameterDirection.Input
                prmParameter(17) = New SqlParameter("@pEMPRESA_DESTINO", SqlDbType.varchar, 15)
                prmParameter(17).Value = IIf(IsNothing(oLogisticaMovimiento.EMPRESA_DESTINO), "", oLogisticaMovimiento.EMPRESA_DESTINO)
                prmParameter(17).Direction = ParameterDirection.Input
                prmParameter(18) = New SqlParameter("@pDEPOSITO_DESTINO", SqlDbType.varchar, 3)
                prmParameter(18).Value = IIf(IsNothing(oLogisticaMovimiento.DEPOSITO_DESTINO), "", oLogisticaMovimiento.DEPOSITO_DESTINO)
                prmParameter(18).Direction = ParameterDirection.Input
                prmParameter(19) = New SqlParameter("@pLOTE_DESTINO", SqlDbType.varchar, 20)
                prmParameter(19).Value = IIf(IsNothing(oLogisticaMovimiento.LOTE_DESTINO), "", oLogisticaMovimiento.LOTE_DESTINO)
                prmParameter(19).Direction = ParameterDirection.Input
                prmParameter(20) = New SqlParameter("@pPERIODO", SqlDbType.varchar, 6)
                prmParameter(20).Value = IIf(IsNothing(oLogisticaMovimiento.PERIODO), "", oLogisticaMovimiento.PERIODO)
                prmParameter(20).Direction = ParameterDirection.Input
                prmParameter(21) = New SqlParameter("@pNUM_CONTRATO", SqlDbType.varchar, 10)
                prmParameter(21).Value = IIf(IsNothing(oLogisticaMovimiento.NUM_CONTRATO), "", oLogisticaMovimiento.NUM_CONTRATO)
                prmParameter(21).Direction = ParameterDirection.Input
                prmParameter(22) = New SqlParameter("@pFECHA_APERTURA", SqlDbType.DateTime, 8)
                prmParameter(22).Value = clsUT_Funcion.FechaNull(oLogisticaMovimiento.FECHA_APERTURA)
                prmParameter(22).Direction = ParameterDirection.Input
                prmParameter(23) = New SqlParameter("@pELEMENTO_MINERAL", SqlDbType.varchar, 3)
                prmParameter(23).Value = IIf(IsNothing(oLogisticaMovimiento.ELEMENTO_MINERAL), "", oLogisticaMovimiento.ELEMENTO_MINERAL)
                prmParameter(23).Direction = ParameterDirection.Input
                prmParameter(24) = New SqlParameter("@pTIPO_MINERAL", SqlDbType.varchar, 6)
                prmParameter(24).Value = IIf(IsNothing(oLogisticaMovimiento.TIPO_MINERAL), "", oLogisticaMovimiento.TIPO_MINERAL)
                prmParameter(24).Direction = ParameterDirection.Input
                prmParameter(25) = New SqlParameter("@pEMP_PROV_CLIENTE", SqlDbType.varchar, 15)
                prmParameter(25).Value = IIf(IsNothing(oLogisticaMovimiento.EMP_PROV_CLIENTE), "", oLogisticaMovimiento.EMP_PROV_CLIENTE)
                prmParameter(25).Direction = ParameterDirection.Input
                prmParameter(26) = New SqlParameter("@pTMH_SLC", SqlDbType.Float, 5)
                prmParameter(26).Value = IIf(IsNothing(oLogisticaMovimiento.TMH_SLC), 0, oLogisticaMovimiento.TMH_SLC)
                prmParameter(26).Direction = ParameterDirection.Input
                prmParameter(27) = New SqlParameter("@pESTADO_SLC", SqlDbType.Int, 4)
                prmParameter(27).Value = IIf(IsNothing(oLogisticaMovimiento.ESTADO_SLC), 0, oLogisticaMovimiento.ESTADO_SLC)
                prmParameter(27).Direction = ParameterDirection.Input
                prmParameter(28) = New SqlParameter("@pIND_GUIA_PROVFIN", SqlDbType.Int, 4)
                prmParameter(28).Value = IIf(IsNothing(oLogisticaMovimiento.IND_GUIA_PROVFIN), 0, oLogisticaMovimiento.IND_GUIA_PROVFIN)
                prmParameter(28).Direction = ParameterDirection.Input
                prmParameter(29) = New SqlParameter("@pIND_ASIGNA_PART", SqlDbType.Int, 4)
                prmParameter(29).Value = IIf(IsNothing(oLogisticaMovimiento.IND_ASIGNA_PART), 0, oLogisticaMovimiento.IND_ASIGNA_PART)
                prmParameter(29).Direction = ParameterDirection.Input
                prmParameter(30) = New SqlParameter("@pIND_ASIGNA_VCL", SqlDbType.Int, 4)
                prmParameter(30).Value = IIf(IsNothing(oLogisticaMovimiento.IND_ASIGNA_VCL), 0, oLogisticaMovimiento.IND_ASIGNA_VCL)
                prmParameter(30).Direction = ParameterDirection.Input
                prmParameter(31) = New SqlParameter("@pIND_ASIGNA_BLEND", SqlDbType.Int, 4)
                prmParameter(31).Value = IIf(IsNothing(oLogisticaMovimiento.IND_ASIGNA_BLEND), 0, oLogisticaMovimiento.IND_ASIGNA_BLEND)
                prmParameter(31).Direction = ParameterDirection.Input
                prmParameter(32) = New SqlParameter("@pIND_ASIGNA_DESP", SqlDbType.Int, 4)
                prmParameter(32).Value = IIf(IsNothing(oLogisticaMovimiento.IND_ASIGNA_DESP), 0, oLogisticaMovimiento.IND_ASIGNA_DESP)
                prmParameter(32).Direction = ParameterDirection.Input
                prmParameter(33) = New SqlParameter("@pIND_ASIGNA_LOTE", SqlDbType.Int, 4)
                prmParameter(33).Value = IIf(IsNothing(oLogisticaMovimiento.IND_ASIGNA_LOTE), 0, oLogisticaMovimiento.IND_ASIGNA_LOTE)
                prmParameter(33).Direction = ParameterDirection.Input
                prmParameter(34) = New SqlParameter("@pTICKET", SqlDbType.varchar, 10)
                prmParameter(34).Value = IIf(IsNothing(oLogisticaMovimiento.TICKET), 0, oLogisticaMovimiento.TICKET)
                prmParameter(34).Direction = ParameterDirection.Input
                prmParameter(35) = New SqlParameter("@pNRO_MUESTRA", SqlDbType.varchar, 12)
                prmParameter(35).Value = IIf(IsNothing(oLogisticaMovimiento.NRO_MUESTRA), 0, oLogisticaMovimiento.NRO_MUESTRA)
                prmParameter(35).Direction = ParameterDirection.Input
                prmParameter(36) = New SqlParameter("@pH2O", SqlDbType.Float, 5)
                prmParameter(36).Value = IIf(IsNothing(oLogisticaMovimiento.H2O), 0, oLogisticaMovimiento.H2O)
                prmParameter(36).Direction = ParameterDirection.Input
                prmParameter(37) = New SqlParameter("@pLEY_CU", SqlDbType.Float, 5)
                prmParameter(37).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_CU), 0, oLogisticaMovimiento.LEY_CU)
                prmParameter(37).Direction = ParameterDirection.Input
                prmParameter(38) = New SqlParameter("@pLEY_AG", SqlDbType.Float, 5)
                prmParameter(38).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_AG), 0, oLogisticaMovimiento.LEY_AG)
                prmParameter(38).Direction = ParameterDirection.Input
                prmParameter(39) = New SqlParameter("@pLEY_AU", SqlDbType.Float, 5)
                prmParameter(39).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_AU), 0, oLogisticaMovimiento.LEY_AU)
                prmParameter(39).Direction = ParameterDirection.Input
                prmParameter(40) = New SqlParameter("@pLEY_PB", SqlDbType.Float, 5)
                prmParameter(40).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_PB), 0, oLogisticaMovimiento.LEY_PB)
                prmParameter(40).Direction = ParameterDirection.Input
                prmParameter(41) = New SqlParameter("@pLEY_ZN", SqlDbType.Float, 5)
                prmParameter(41).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_ZN), 0, oLogisticaMovimiento.LEY_ZN)
                prmParameter(41).Direction = ParameterDirection.Input
                prmParameter(42) = New SqlParameter("@pLEY_SN", SqlDbType.Float, 5)
                prmParameter(42).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_SN), 0, oLogisticaMovimiento.LEY_SN)
                prmParameter(42).Direction = ParameterDirection.Input
                prmParameter(43) = New SqlParameter("@pLEY_AS", SqlDbType.Float, 5)
                prmParameter(43).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_AS), 0, oLogisticaMovimiento.LEY_AS)
                prmParameter(43).Direction = ParameterDirection.Input
                prmParameter(44) = New SqlParameter("@pLEY_SB", SqlDbType.Float, 5)
                prmParameter(44).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_SB), 0, oLogisticaMovimiento.LEY_SB)
                prmParameter(44).Direction = ParameterDirection.Input
                prmParameter(45) = New SqlParameter("@pLEY_BI", SqlDbType.Float, 5)
                prmParameter(45).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_BI), 0, oLogisticaMovimiento.LEY_BI)
                prmParameter(45).Direction = ParameterDirection.Input
                prmParameter(46) = New SqlParameter("@pLEY_HG", SqlDbType.Float, 5)
                prmParameter(46).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_HG), 0, oLogisticaMovimiento.LEY_HG)
                prmParameter(46).Direction = ParameterDirection.Input
                prmParameter(47) = New SqlParameter("@pLEY_SIO2", SqlDbType.Float, 5)
                prmParameter(47).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_SIO2), 0, oLogisticaMovimiento.LEY_SIO2)
                prmParameter(47).Direction = ParameterDirection.Input
                prmParameter(48) = New SqlParameter("@pLEY_AS_SB", SqlDbType.Float, 5)
                prmParameter(48).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_AS_SB), 0, oLogisticaMovimiento.LEY_AS_SB)
                prmParameter(48).Direction = ParameterDirection.Input
                prmParameter(49) = New SqlParameter("@pLEY_ZN_PB", SqlDbType.Float, 5)
                prmParameter(49).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_ZN_PB), 0, oLogisticaMovimiento.LEY_ZN_PB)
                prmParameter(49).Direction = ParameterDirection.Input
                prmParameter(50) = New SqlParameter("@pLEY_AUNW", SqlDbType.Float, 5)
                prmParameter(50).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_AUNW), 0, oLogisticaMovimiento.LEY_AUNW)
                prmParameter(50).Direction = ParameterDirection.Input
                prmParameter(51) = New SqlParameter("@pLEY_CUTOT", SqlDbType.Float, 5)
                prmParameter(51).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_CUTOT), 0, oLogisticaMovimiento.LEY_CUTOT)
                prmParameter(51).Direction = ParameterDirection.Input
                prmParameter(52) = New SqlParameter("@pLEY_CUSOL", SqlDbType.Float, 5)
                prmParameter(52).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_CUSOL), 0, oLogisticaMovimiento.LEY_CUSOL)
                prmParameter(52).Direction = ParameterDirection.Input
                prmParameter(53) = New SqlParameter("@pLEY_CNNa", SqlDbType.Float, 5)
                prmParameter(53).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_CNNa), 0, oLogisticaMovimiento.LEY_CNNa)
                prmParameter(53).Direction = ParameterDirection.Input
                prmParameter(54) = New SqlParameter("@pLEY_CAL", SqlDbType.Float, 5)
                prmParameter(54).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_CAL), 0, oLogisticaMovimiento.LEY_CAL)
                prmParameter(54).Direction = ParameterDirection.Input
                prmParameter(55) = New SqlParameter("@pLEY_SOD", SqlDbType.Float, 5)
                prmParameter(55).Value = IIf(IsNothing(oLogisticaMovimiento.LEY_SOD), 0, oLogisticaMovimiento.LEY_SOD)
                prmParameter(55).Direction = ParameterDirection.Input
                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LogisticaMovimiento_Upd", prmParameter)
                Catch ex As Exception
                    Throw ex
                    Return False
                End Try
            Next
            Return True
        End Function

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 25/02/2011 10:15:55
        ''' Proposito: Metodo de Elimacion
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function EliminarLogisticaMovimiento(ByVal oLstLogisticaMovimiento As List(Of clsBE_LogisticaMovimiento)) As Boolean
            For Each oLogisticaMovimiento As clsBE_LogisticaMovimiento In oLstLogisticaMovimiento
                Dim prmParameter(0) As SqlParameter
                prmParameter(0) = New SqlParameter("@pID", SqlDbType.bigint, 8)
                prmParameter(0).Value = IIf(IsNothing(oLogisticaMovimiento.ID), 0, oLogisticaMovimiento.ID)
                prmParameter(0).Direction = ParameterDirection.Input
                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LogisticaMovimiento_Del", prmParameter)
                Catch ex As Exception
                    Throw ex
                    Return False
                End Try
            Next
            Return True
        End Function

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 25/02/2011 10:15:55
        ''' Proposito: Metodo de Guardar Dataset
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function GuardarLogisticaMovimiento(ByVal oDSLogisticaMovimiento As Dataset) As Boolean
            Dim cnxCPO As New SqlConnection(CadenaConexion)


            Try
                Dim objCommnadInsert As New SqlCommand
                objCommnadInsert.Connection = cnxCPO
                objCommnadInsert.CommandText = "up_LogisticaMovimiento_Ins"
                objCommnadInsert.CommandType = CommandType.StoredProcedure

                objCommnadInsert.Parameters.Add("@pTMH", SqlDbType.Float, 4).SourceColumn = "TMH"
                objCommnadInsert.Parameters.Add("@pContratoLoteId", SqlDbType.varchar, 20).SourceColumn = "ContratoLoteId"
                objCommnadInsert.Parameters.Add("@pESTADO", SqlDbType.varchar, 1).SourceColumn = "ESTADO"
                objCommnadInsert.Parameters.Add("@pLiquidacionId", SqlDbType.varchar, 20).SourceColumn = "LiquidacionId"
                objCommnadInsert.Parameters.Add("@pLiquidacionTmId", SqlDbType.varchar, 20).SourceColumn = "LiquidacionTmId"
                objCommnadInsert.Parameters.Add("@pContratoLoteSuceroaId", SqlDbType.varchar, 20).SourceColumn = "ContratoLoteSuceroaId"
                objCommnadInsert.Parameters.Add("@pEstadoVCM", SqlDbType.varchar, 1).SourceColumn = "EstadoVCM"
                objCommnadInsert.Parameters.Add("@pEMPRESA", SqlDbType.varchar, 15).SourceColumn = "EMPRESA"
                objCommnadInsert.Parameters.Add("@pCOD_DEPOSITO", SqlDbType.varchar, 3).SourceColumn = "COD_DEPOSITO"
                objCommnadInsert.Parameters.Add("@pCOD_LOTE", SqlDbType.varchar, 20).SourceColumn = "COD_LOTE"
                objCommnadInsert.Parameters.Add("@pNRO_DOCUMENTO", SqlDbType.varchar, 12).SourceColumn = "NRO_DOCUMENTO"
                objCommnadInsert.Parameters.Add("@pTIPO_MOV", SqlDbType.varchar, 2).SourceColumn = "TIPO_MOV"
                objCommnadInsert.Parameters.Add("@pN_ITEM", SqlDbType.Int, 4).SourceColumn = "N_ITEM"
                objCommnadInsert.Parameters.Add("@pEMPRESA_ORIGEN", SqlDbType.varchar, 15).SourceColumn = "EMPRESA_ORIGEN"
                objCommnadInsert.Parameters.Add("@pDEPOSITO_ORIGEN", SqlDbType.varchar, 3).SourceColumn = "DEPOSITO_ORIGEN"
                objCommnadInsert.Parameters.Add("@pLOTE_ORIGEN", SqlDbType.varchar, 20).SourceColumn = "LOTE_ORIGEN"
                objCommnadInsert.Parameters.Add("@pEMPRESA_DESTINO", SqlDbType.varchar, 15).SourceColumn = "EMPRESA_DESTINO"
                objCommnadInsert.Parameters.Add("@pDEPOSITO_DESTINO", SqlDbType.varchar, 3).SourceColumn = "DEPOSITO_DESTINO"
                objCommnadInsert.Parameters.Add("@pLOTE_DESTINO", SqlDbType.varchar, 20).SourceColumn = "LOTE_DESTINO"
                objCommnadInsert.Parameters.Add("@pPERIODO", SqlDbType.varchar, 6).SourceColumn = "PERIODO"
                objCommnadInsert.Parameters.Add("@pNUM_CONTRATO", SqlDbType.varchar, 10).SourceColumn = "NUM_CONTRATO"
                objCommnadInsert.Parameters.Add("@pFECHA_APERTURA", SqlDbType.DateTime, 8).SourceColumn = "FECHA_APERTURA"
                objCommnadInsert.Parameters.Add("@pELEMENTO_MINERAL", SqlDbType.varchar, 3).SourceColumn = "ELEMENTO_MINERAL"
                objCommnadInsert.Parameters.Add("@pTIPO_MINERAL", SqlDbType.varchar, 6).SourceColumn = "TIPO_MINERAL"
                objCommnadInsert.Parameters.Add("@pEMP_PROV_CLIENTE", SqlDbType.varchar, 15).SourceColumn = "EMP_PROV_CLIENTE"
                objCommnadInsert.Parameters.Add("@pTMH_SLC", SqlDbType.Float, 5).SourceColumn = "TMH_SLC"
                objCommnadInsert.Parameters.Add("@pESTADO_SLC", SqlDbType.Int, 4).SourceColumn = "ESTADO_SLC"
                objCommnadInsert.Parameters.Add("@pIND_GUIA_PROVFIN", SqlDbType.Int, 4).SourceColumn = "IND_GUIA_PROVFIN"
                objCommnadInsert.Parameters.Add("@pIND_ASIGNA_PART", SqlDbType.Int, 4).SourceColumn = "IND_ASIGNA_PART"
                objCommnadInsert.Parameters.Add("@pIND_ASIGNA_VCL", SqlDbType.Int, 4).SourceColumn = "IND_ASIGNA_VCL"
                objCommnadInsert.Parameters.Add("@pIND_ASIGNA_BLEND", SqlDbType.Int, 4).SourceColumn = "IND_ASIGNA_BLEND"
                objCommnadInsert.Parameters.Add("@pIND_ASIGNA_DESP", SqlDbType.Int, 4).SourceColumn = "IND_ASIGNA_DESP"
                objCommnadInsert.Parameters.Add("@pIND_ASIGNA_LOTE", SqlDbType.Int, 4).SourceColumn = "IND_ASIGNA_LOTE"
                objCommnadInsert.Parameters.Add("@pTICKET", SqlDbType.varchar, 10).SourceColumn = "TICKET"
                objCommnadInsert.Parameters.Add("@pNRO_MUESTRA", SqlDbType.varchar, 12).SourceColumn = "NRO_MUESTRA"
                objCommnadInsert.Parameters.Add("@pH2O", SqlDbType.Float, 5).SourceColumn = "H2O"
                objCommnadInsert.Parameters.Add("@pLEY_CU", SqlDbType.Float, 5).SourceColumn = "LEY_CU"
                objCommnadInsert.Parameters.Add("@pLEY_AG", SqlDbType.Float, 5).SourceColumn = "LEY_AG"
                objCommnadInsert.Parameters.Add("@pLEY_AU", SqlDbType.Float, 5).SourceColumn = "LEY_AU"
                objCommnadInsert.Parameters.Add("@pLEY_PB", SqlDbType.Float, 5).SourceColumn = "LEY_PB"
                objCommnadInsert.Parameters.Add("@pLEY_ZN", SqlDbType.Float, 5).SourceColumn = "LEY_ZN"
                objCommnadInsert.Parameters.Add("@pLEY_SN", SqlDbType.Float, 5).SourceColumn = "LEY_SN"
                objCommnadInsert.Parameters.Add("@pLEY_AS", SqlDbType.Float, 5).SourceColumn = "LEY_AS"
                objCommnadInsert.Parameters.Add("@pLEY_SB", SqlDbType.Float, 5).SourceColumn = "LEY_SB"
                objCommnadInsert.Parameters.Add("@pLEY_BI", SqlDbType.Float, 5).SourceColumn = "LEY_BI"
                objCommnadInsert.Parameters.Add("@pLEY_HG", SqlDbType.Float, 5).SourceColumn = "LEY_HG"
                objCommnadInsert.Parameters.Add("@pLEY_SIO2", SqlDbType.Float, 5).SourceColumn = "LEY_SIO2"
                objCommnadInsert.Parameters.Add("@pLEY_AS_SB", SqlDbType.Float, 5).SourceColumn = "LEY_AS_SB"
                objCommnadInsert.Parameters.Add("@pLEY_ZN_PB", SqlDbType.Float, 5).SourceColumn = "LEY_ZN_PB"
                objCommnadInsert.Parameters.Add("@pLEY_AUNW", SqlDbType.Float, 5).SourceColumn = "LEY_AUNW"
                objCommnadInsert.Parameters.Add("@pLEY_CUTOT", SqlDbType.Float, 5).SourceColumn = "LEY_CUTOT"
                objCommnadInsert.Parameters.Add("@pLEY_CUSOL", SqlDbType.Float, 5).SourceColumn = "LEY_CUSOL"
                objCommnadInsert.Parameters.Add("@pLEY_CNNa", SqlDbType.Float, 5).SourceColumn = "LEY_CNNa"
                objCommnadInsert.Parameters.Add("@pLEY_CAL", SqlDbType.Float, 5).SourceColumn = "LEY_CAL"
                objCommnadInsert.Parameters.Add("@pLEY_SOD", SqlDbType.Float, 5).SourceColumn = "LEY_SOD"

                Dim objCommandUpdate As New SqlCommand
                objCommandUpdate.Connection = cnxCPO
                objCommandUpdate.CommandText = "up_LogisticaMovimiento_Upd"
                objCommandUpdate.CommandType = CommandType.StoredProcedure

                objCommandUpdate.Parameters.Add("@pID", SqlDbType.bigint, 8).SourceColumn = "ID"
                objCommandUpdate.Parameters.Add("@pTMH", SqlDbType.Float, 4).SourceColumn = "TMH"
                objCommandUpdate.Parameters.Add("@pContratoLoteId", SqlDbType.varchar, 20).SourceColumn = "ContratoLoteId"
                objCommandUpdate.Parameters.Add("@pESTADO", SqlDbType.varchar, 1).SourceColumn = "ESTADO"
                objCommandUpdate.Parameters.Add("@pLiquidacionId", SqlDbType.varchar, 20).SourceColumn = "LiquidacionId"
                objCommandUpdate.Parameters.Add("@pLiquidacionTmId", SqlDbType.varchar, 20).SourceColumn = "LiquidacionTmId"
                objCommandUpdate.Parameters.Add("@pContratoLoteSuceroaId", SqlDbType.varchar, 20).SourceColumn = "ContratoLoteSuceroaId"
                objCommandUpdate.Parameters.Add("@pEstadoVCM", SqlDbType.varchar, 1).SourceColumn = "EstadoVCM"
                objCommandUpdate.Parameters.Add("@pEMPRESA", SqlDbType.varchar, 15).SourceColumn = "EMPRESA"
                objCommandUpdate.Parameters.Add("@pCOD_DEPOSITO", SqlDbType.varchar, 3).SourceColumn = "COD_DEPOSITO"
                objCommandUpdate.Parameters.Add("@pCOD_LOTE", SqlDbType.varchar, 20).SourceColumn = "COD_LOTE"
                objCommandUpdate.Parameters.Add("@pNRO_DOCUMENTO", SqlDbType.varchar, 12).SourceColumn = "NRO_DOCUMENTO"
                objCommandUpdate.Parameters.Add("@pTIPO_MOV", SqlDbType.varchar, 2).SourceColumn = "TIPO_MOV"
                objCommandUpdate.Parameters.Add("@pN_ITEM", SqlDbType.Int, 4).SourceColumn = "N_ITEM"
                objCommandUpdate.Parameters.Add("@pEMPRESA_ORIGEN", SqlDbType.varchar, 15).SourceColumn = "EMPRESA_ORIGEN"
                objCommandUpdate.Parameters.Add("@pDEPOSITO_ORIGEN", SqlDbType.varchar, 3).SourceColumn = "DEPOSITO_ORIGEN"
                objCommandUpdate.Parameters.Add("@pLOTE_ORIGEN", SqlDbType.varchar, 20).SourceColumn = "LOTE_ORIGEN"
                objCommandUpdate.Parameters.Add("@pEMPRESA_DESTINO", SqlDbType.varchar, 15).SourceColumn = "EMPRESA_DESTINO"
                objCommandUpdate.Parameters.Add("@pDEPOSITO_DESTINO", SqlDbType.varchar, 3).SourceColumn = "DEPOSITO_DESTINO"
                objCommandUpdate.Parameters.Add("@pLOTE_DESTINO", SqlDbType.varchar, 20).SourceColumn = "LOTE_DESTINO"
                objCommandUpdate.Parameters.Add("@pPERIODO", SqlDbType.varchar, 6).SourceColumn = "PERIODO"
                objCommandUpdate.Parameters.Add("@pNUM_CONTRATO", SqlDbType.varchar, 10).SourceColumn = "NUM_CONTRATO"
                objCommandUpdate.Parameters.Add("@pFECHA_APERTURA", SqlDbType.DateTime, 8).SourceColumn = "FECHA_APERTURA"
                objCommandUpdate.Parameters.Add("@pELEMENTO_MINERAL", SqlDbType.varchar, 3).SourceColumn = "ELEMENTO_MINERAL"
                objCommandUpdate.Parameters.Add("@pTIPO_MINERAL", SqlDbType.varchar, 6).SourceColumn = "TIPO_MINERAL"
                objCommandUpdate.Parameters.Add("@pEMP_PROV_CLIENTE", SqlDbType.varchar, 15).SourceColumn = "EMP_PROV_CLIENTE"
                objCommandUpdate.Parameters.Add("@pTMH_SLC", SqlDbType.Float, 5).SourceColumn = "TMH_SLC"
                objCommandUpdate.Parameters.Add("@pESTADO_SLC", SqlDbType.Int, 4).SourceColumn = "ESTADO_SLC"
                objCommandUpdate.Parameters.Add("@pIND_GUIA_PROVFIN", SqlDbType.Int, 4).SourceColumn = "IND_GUIA_PROVFIN"
                objCommandUpdate.Parameters.Add("@pIND_ASIGNA_PART", SqlDbType.Int, 4).SourceColumn = "IND_ASIGNA_PART"
                objCommandUpdate.Parameters.Add("@pIND_ASIGNA_VCL", SqlDbType.Int, 4).SourceColumn = "IND_ASIGNA_VCL"
                objCommandUpdate.Parameters.Add("@pIND_ASIGNA_BLEND", SqlDbType.Int, 4).SourceColumn = "IND_ASIGNA_BLEND"
                objCommandUpdate.Parameters.Add("@pIND_ASIGNA_DESP", SqlDbType.Int, 4).SourceColumn = "IND_ASIGNA_DESP"
                objCommandUpdate.Parameters.Add("@pIND_ASIGNA_LOTE", SqlDbType.Int, 4).SourceColumn = "IND_ASIGNA_LOTE"
                objCommandUpdate.Parameters.Add("@pTICKET", SqlDbType.varchar, 10).SourceColumn = "TICKET"
                objCommandUpdate.Parameters.Add("@pNRO_MUESTRA", SqlDbType.varchar, 12).SourceColumn = "NRO_MUESTRA"
                objCommandUpdate.Parameters.Add("@pH2O", SqlDbType.Float, 5).SourceColumn = "H2O"
                objCommandUpdate.Parameters.Add("@pLEY_CU", SqlDbType.Float, 5).SourceColumn = "LEY_CU"
                objCommandUpdate.Parameters.Add("@pLEY_AG", SqlDbType.Float, 5).SourceColumn = "LEY_AG"
                objCommandUpdate.Parameters.Add("@pLEY_AU", SqlDbType.Float, 5).SourceColumn = "LEY_AU"
                objCommandUpdate.Parameters.Add("@pLEY_PB", SqlDbType.Float, 5).SourceColumn = "LEY_PB"
                objCommandUpdate.Parameters.Add("@pLEY_ZN", SqlDbType.Float, 5).SourceColumn = "LEY_ZN"
                objCommandUpdate.Parameters.Add("@pLEY_SN", SqlDbType.Float, 5).SourceColumn = "LEY_SN"
                objCommandUpdate.Parameters.Add("@pLEY_AS", SqlDbType.Float, 5).SourceColumn = "LEY_AS"
                objCommandUpdate.Parameters.Add("@pLEY_SB", SqlDbType.Float, 5).SourceColumn = "LEY_SB"
                objCommandUpdate.Parameters.Add("@pLEY_BI", SqlDbType.Float, 5).SourceColumn = "LEY_BI"
                objCommandUpdate.Parameters.Add("@pLEY_HG", SqlDbType.Float, 5).SourceColumn = "LEY_HG"
                objCommandUpdate.Parameters.Add("@pLEY_SIO2", SqlDbType.Float, 5).SourceColumn = "LEY_SIO2"
                objCommandUpdate.Parameters.Add("@pLEY_AS_SB", SqlDbType.Float, 5).SourceColumn = "LEY_AS_SB"
                objCommandUpdate.Parameters.Add("@pLEY_ZN_PB", SqlDbType.Float, 5).SourceColumn = "LEY_ZN_PB"
                objCommandUpdate.Parameters.Add("@pLEY_AUNW", SqlDbType.Float, 5).SourceColumn = "LEY_AUNW"
                objCommandUpdate.Parameters.Add("@pLEY_CUTOT", SqlDbType.Float, 5).SourceColumn = "LEY_CUTOT"
                objCommandUpdate.Parameters.Add("@pLEY_CUSOL", SqlDbType.Float, 5).SourceColumn = "LEY_CUSOL"
                objCommandUpdate.Parameters.Add("@pLEY_CNNa", SqlDbType.Float, 5).SourceColumn = "LEY_CNNa"
                objCommandUpdate.Parameters.Add("@pLEY_CAL", SqlDbType.Float, 5).SourceColumn = "LEY_CAL"
                objCommandUpdate.Parameters.Add("@pLEY_SOD", SqlDbType.Float, 5).SourceColumn = "LEY_SOD"

                Dim objCommandDelete As New SqlCommand
                objCommandDelete.Connection = cnxCPO
                objCommandDelete.CommandText = "up_LogisticaMovimiento_Del"
                objCommandDelete.CommandType = CommandType.StoredProcedure

                objCommandDelete.Parameters.Add("@pID", SqlDbType.bigint, 8).SourceColumn = "ID"

                'SqlHelper.UpdateDataset(objCommnadInsert, objCommandDelete, objCommandUpdate, oDSLogisticaMovimiento, "LogisticaMovimiento")

            Catch ex As Exception
                Throw ex
                Return False
            End Try
            Return True

        End Function

    End Class
#End Region

#Region "Clase Lectura"
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 25/02/2011 10:15:55
    ''' Proposito: Obtiene los valores de la tabla LogisticaMovimiento
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsDB_LogisticaMovimientoRO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionIN")

            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("IN")
        End Sub
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 25/02/2011 10:15:55
        ''' Proposito: Lee los datos de un registro
        ''' Fecha Modificacion:
        ''' </summary>
        ''' 
        Public Function LeerLogisticaMovimiento(ByVal pLogisticaMovimiento As clsBE_LogisticaMovimiento) As clsBE_LogisticaMovimiento
            Dim oLogisticaMovimiento As clsBE_LogisticaMovimiento = Nothing
            Dim DSLogisticaMovimiento As New DataSet
            Dim prmParameter(0) As SqlParameter
            prmParameter(0) = New SqlParameter("@pID", SqlDbType.bigint, 8)
            prmParameter(0).Value = IIf(IsNothing(pLogisticaMovimiento.ID), 0, pLogisticaMovimiento.ID)
            Try
                Using DSLogisticaMovimiento
                    DSLogisticaMovimiento = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_LogisticaMovimiento_Sel", prmParameter)
                    If Not DSLogisticaMovimiento Is Nothing Then
                        If DSLogisticaMovimiento.Tables.Count > 0 Then
                            oLogisticaMovimiento = New clsBE_LogisticaMovimiento
                            If DSLogisticaMovimiento.Tables(0).Rows.Count > 0 Then
                                With DSLogisticaMovimiento.Tables(0).Rows(0)
                                    oLogisticaMovimiento.ID = .Item("ID").tostring
                                    oLogisticaMovimiento.TMH = .Item("TMH").tostring
                                    oLogisticaMovimiento.ContratoLoteId = .Item("ContratoLoteId").tostring
                                    oLogisticaMovimiento.ESTADO = .Item("ESTADO").tostring
                                    oLogisticaMovimiento.LiquidacionId = .Item("LiquidacionId").tostring
                                    oLogisticaMovimiento.LiquidacionTmId = .Item("LiquidacionTmId").tostring
                                    oLogisticaMovimiento.ContratoLoteSuceroaId = .Item("ContratoLoteSuceroaId").tostring
                                    oLogisticaMovimiento.EstadoVCM = .Item("EstadoVCM").tostring
                                    oLogisticaMovimiento.EMPRESA = .Item("EMPRESA").tostring
                                    oLogisticaMovimiento.COD_DEPOSITO = .Item("COD_DEPOSITO").tostring
                                    oLogisticaMovimiento.COD_LOTE = .Item("COD_LOTE").tostring
                                    oLogisticaMovimiento.NRO_DOCUMENTO = .Item("NRO_DOCUMENTO").tostring
                                    oLogisticaMovimiento.TIPO_MOV = .Item("TIPO_MOV").tostring
                                    oLogisticaMovimiento.N_ITEM = .Item("N_ITEM").tostring
                                    oLogisticaMovimiento.EMPRESA_ORIGEN = .Item("EMPRESA_ORIGEN").tostring
                                    oLogisticaMovimiento.DEPOSITO_ORIGEN = .Item("DEPOSITO_ORIGEN").tostring
                                    oLogisticaMovimiento.LOTE_ORIGEN = .Item("LOTE_ORIGEN").tostring
                                    oLogisticaMovimiento.EMPRESA_DESTINO = .Item("EMPRESA_DESTINO").tostring
                                    oLogisticaMovimiento.DEPOSITO_DESTINO = .Item("DEPOSITO_DESTINO").tostring
                                    oLogisticaMovimiento.LOTE_DESTINO = .Item("LOTE_DESTINO").tostring
                                    oLogisticaMovimiento.PERIODO = .Item("PERIODO").tostring
                                    oLogisticaMovimiento.NUM_CONTRATO = .Item("NUM_CONTRATO").tostring
                                    oLogisticaMovimiento.FECHA_APERTURA = .Item("FECHA_APERTURA").tostring
                                    oLogisticaMovimiento.ELEMENTO_MINERAL = .Item("ELEMENTO_MINERAL").tostring
                                    oLogisticaMovimiento.TIPO_MINERAL = .Item("TIPO_MINERAL").tostring
                                    oLogisticaMovimiento.EMP_PROV_CLIENTE = .Item("EMP_PROV_CLIENTE").tostring
                                    oLogisticaMovimiento.TMH_SLC = .Item("TMH_SLC").tostring
                                    oLogisticaMovimiento.ESTADO_SLC = .Item("ESTADO_SLC").tostring
                                    oLogisticaMovimiento.IND_GUIA_PROVFIN = .Item("IND_GUIA_PROVFIN").tostring
                                    oLogisticaMovimiento.IND_ASIGNA_PART = .Item("IND_ASIGNA_PART").tostring
                                    oLogisticaMovimiento.IND_ASIGNA_VCL = .Item("IND_ASIGNA_VCL").tostring
                                    oLogisticaMovimiento.IND_ASIGNA_BLEND = .Item("IND_ASIGNA_BLEND").tostring
                                    oLogisticaMovimiento.IND_ASIGNA_DESP = .Item("IND_ASIGNA_DESP").tostring
                                    oLogisticaMovimiento.IND_ASIGNA_LOTE = .Item("IND_ASIGNA_LOTE").tostring
                                    oLogisticaMovimiento.TICKET = .Item("TICKET").tostring
                                    oLogisticaMovimiento.NRO_MUESTRA = .Item("NRO_MUESTRA").tostring
                                    oLogisticaMovimiento.H2O = .Item("H2O").tostring
                                    oLogisticaMovimiento.LEY_CU = .Item("LEY_CU").tostring
                                    oLogisticaMovimiento.LEY_AG = .Item("LEY_AG").tostring
                                    oLogisticaMovimiento.LEY_AU = .Item("LEY_AU").tostring
                                    oLogisticaMovimiento.LEY_PB = .Item("LEY_PB").tostring
                                    oLogisticaMovimiento.LEY_ZN = .Item("LEY_ZN").tostring
                                    oLogisticaMovimiento.LEY_SN = .Item("LEY_SN").tostring
                                    oLogisticaMovimiento.LEY_AS = .Item("LEY_AS").tostring
                                    oLogisticaMovimiento.LEY_SB = .Item("LEY_SB").tostring
                                    oLogisticaMovimiento.LEY_BI = .Item("LEY_BI").tostring
                                    oLogisticaMovimiento.LEY_HG = .Item("LEY_HG").tostring
                                    oLogisticaMovimiento.LEY_SIO2 = .Item("LEY_SIO2").tostring
                                    oLogisticaMovimiento.LEY_AS_SB = .Item("LEY_AS_SB").tostring
                                    oLogisticaMovimiento.LEY_ZN_PB = .Item("LEY_ZN_PB").tostring
                                    oLogisticaMovimiento.LEY_AUNW = .Item("LEY_AUNW").tostring
                                    oLogisticaMovimiento.LEY_CUTOT = .Item("LEY_CUTOT").tostring
                                    oLogisticaMovimiento.LEY_CUSOL = .Item("LEY_CUSOL").tostring
                                    oLogisticaMovimiento.LEY_CNNa = .Item("LEY_CNNa").tostring
                                    oLogisticaMovimiento.LEY_CAL = .Item("LEY_CAL").tostring
                                    oLogisticaMovimiento.LEY_SOD = .Item("LEY_SOD").tostring
                                End With
                            End If
                        End If
                    End If
                End Using
            Catch exSql As SqlException

            Catch ex As Exception
                Throw ex
            Finally
                If Not DSLogisticaMovimiento Is Nothing Then
                    DSLogisticaMovimiento.Dispose()
                End If
                DSLogisticaMovimiento = Nothing
            End Try

            Return oLogisticaMovimiento

        End Function


        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 25/02/2011 10:15:55
        ''' Proposito: Obtiene la lista de registros
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaLogisticaMovimiento() As List(Of clsBE_LogisticaMovimiento)
            Dim olstLogisticaMovimiento As New List(Of clsBE_LogisticaMovimiento)
            Dim oLogisticaMovimiento As clsBE_LogisticaMovimiento = Nothing
            Dim mintItem As Integer = 0
            Try
                Using Reader As SqlDataReader = SqlHelper.ExecuteReader(CadenaConexion, CommandType.StoredProcedure, "up_LogisticaMovimiento_Sellst")
                    If Reader.HasRows Then
                        While reader.Read
                            oLogisticaMovimiento = New clsBE_LogisticaMovimiento
                            mintItem += 1
                            With oLogisticaMovimiento
                                .Item = mintItem

                                .ID = Reader("ID").tostring
                                .TMH = Reader("TMH").tostring
                                .ContratoLoteId = Reader("ContratoLoteId").tostring
                                .ESTADO = Reader("ESTADO").tostring
                                .LiquidacionId = Reader("LiquidacionId").tostring
                                .LiquidacionTmId = Reader("LiquidacionTmId").tostring
                                .ContratoLoteSuceroaId = Reader("ContratoLoteSuceroaId").tostring
                                .EstadoVCM = Reader("EstadoVCM").tostring
                                .EMPRESA = Reader("EMPRESA").tostring
                                .COD_DEPOSITO = Reader("COD_DEPOSITO").tostring
                                .COD_LOTE = Reader("COD_LOTE").tostring
                                .NRO_DOCUMENTO = Reader("NRO_DOCUMENTO").tostring
                                .TIPO_MOV = Reader("TIPO_MOV").tostring
                                .N_ITEM = Reader("N_ITEM").tostring
                                .EMPRESA_ORIGEN = Reader("EMPRESA_ORIGEN").tostring
                                .DEPOSITO_ORIGEN = Reader("DEPOSITO_ORIGEN").tostring
                                .LOTE_ORIGEN = Reader("LOTE_ORIGEN").tostring
                                .EMPRESA_DESTINO = Reader("EMPRESA_DESTINO").tostring
                                .DEPOSITO_DESTINO = Reader("DEPOSITO_DESTINO").tostring
                                .LOTE_DESTINO = Reader("LOTE_DESTINO").tostring
                                .PERIODO = Reader("PERIODO").tostring
                                .NUM_CONTRATO = Reader("NUM_CONTRATO").tostring
                                .FECHA_APERTURA = Reader("FECHA_APERTURA").tostring
                                .ELEMENTO_MINERAL = Reader("ELEMENTO_MINERAL").tostring
                                .TIPO_MINERAL = Reader("TIPO_MINERAL").tostring
                                .EMP_PROV_CLIENTE = Reader("EMP_PROV_CLIENTE").tostring
                                .TMH_SLC = Reader("TMH_SLC").tostring
                                .ESTADO_SLC = Reader("ESTADO_SLC").tostring
                                .IND_GUIA_PROVFIN = Reader("IND_GUIA_PROVFIN").tostring
                                .IND_ASIGNA_PART = Reader("IND_ASIGNA_PART").tostring
                                .IND_ASIGNA_VCL = Reader("IND_ASIGNA_VCL").tostring
                                .IND_ASIGNA_BLEND = Reader("IND_ASIGNA_BLEND").tostring
                                .IND_ASIGNA_DESP = Reader("IND_ASIGNA_DESP").tostring
                                .IND_ASIGNA_LOTE = Reader("IND_ASIGNA_LOTE").tostring
                                .TICKET = Reader("TICKET").tostring
                                .NRO_MUESTRA = Reader("NRO_MUESTRA").tostring
                                .H2O = Reader("H2O").tostring
                                .LEY_CU = Reader("LEY_CU").tostring
                                .LEY_AG = Reader("LEY_AG").tostring
                                .LEY_AU = Reader("LEY_AU").tostring
                                .LEY_PB = Reader("LEY_PB").tostring
                                .LEY_ZN = Reader("LEY_ZN").tostring
                                .LEY_SN = Reader("LEY_SN").tostring
                                .LEY_AS = Reader("LEY_AS").tostring
                                .LEY_SB = Reader("LEY_SB").tostring
                                .LEY_BI = Reader("LEY_BI").tostring
                                .LEY_HG = Reader("LEY_HG").tostring
                                .LEY_SIO2 = Reader("LEY_SIO2").tostring
                                .LEY_AS_SB = Reader("LEY_AS_SB").tostring
                                .LEY_ZN_PB = Reader("LEY_ZN_PB").tostring
                                .LEY_AUNW = Reader("LEY_AUNW").tostring
                                .LEY_CUTOT = Reader("LEY_CUTOT").tostring
                                .LEY_CUSOL = Reader("LEY_CUSOL").tostring
                                .LEY_CNNa = Reader("LEY_CNNa").tostring
                                .LEY_CAL = Reader("LEY_CAL").tostring
                                .LEY_SOD = Reader("LEY_SOD").tostring
                            End With
                            olstLogisticaMovimiento.Add(oLogisticaMovimiento)
                        End While
                    End If
                End Using
            Catch ex As Exception
                Throw ex
            End Try

            Return olstLogisticaMovimiento

        End Function

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 25/02/2011 10:15:55
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSLogisticaMovimiento(ByVal pLogisticaMovimiento As clsBE_LogisticaMovimiento) As Dataset
            Dim oDSLogisticaMovimiento As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(7) As SqlParameter

            'prmParameter(0) = New SqlParameter("@pTIPO_MOV", SqlDbType.VarChar, 15)
            'prmParameter(0).Value = IIf(IsNothing(pLogisticaMovimiento.TIPO_MOV), 0, pLogisticaMovimiento.TIPO_MOV)
            'prmParameter(1) = New SqlParameter("@pELEMENTO_MINERAL", SqlDbType.VarChar, 15)
            'prmParameter(1).Value = IIf(IsNothing(pLogisticaMovimiento.ELEMENTO_MINERAL), 0, pLogisticaMovimiento.ELEMENTO_MINERAL)
            ''prmParameter(2) = New SqlParameter("@pEMPRESA_ORIGEN", SqlDbType.VarChar, 15)
            ''prmParameter(2).Value = IIf(IsNothing(pLogisticaMovimiento.EMPRESA_ORIGEN), 0, pLogisticaMovimiento.EMPRESA_ORIGEN)

            'prmParameter(2) = New SqlParameter("@pEMP_PROV_CLIENTE", SqlDbType.VarChar, 15)
            'prmParameter(2).Value = IIf(IsNothing(pLogisticaMovimiento.EMP_PROV_CLIENTE), 0, pLogisticaMovimiento.EMP_PROV_CLIENTE)
            'prmParameter(3) = New SqlParameter("@pEMPRESA_CLI", SqlDbType.VarChar, 15)
            'prmParameter(3).Value = IIf(IsNothing(pLogisticaMovimiento.EMPRESA_CLI), 0, pLogisticaMovimiento.EMPRESA_CLI)
            'prmParameter(4) = New SqlParameter("@pCOD_DEPOSITO", SqlDbType.VarChar, 15)
            'prmParameter(4).Value = IIf(IsNothing(pLogisticaMovimiento.COD_DEPOSITO), 0, pLogisticaMovimiento.COD_DEPOSITO)

            'prmParameter(5) = New SqlParameter("@pLOTE_ORIGEN", SqlDbType.VarChar, 15)
            'prmParameter(5).Value = IIf(IsNothing(pLogisticaMovimiento.LOTE_ORIGEN), 0, pLogisticaMovimiento.LOTE_ORIGEN)

            'prmParameter(6) = New SqlParameter("@codigoClase", SqlDbType.VarChar, 20)
            'prmParameter(6).Value = IIf(IsNothing(pLogisticaMovimiento.TIPO_MINERAL), 0, pLogisticaMovimiento.TIPO_MINERAL)

            'prmParameter(7) = New SqlParameter("@CATEGORIA", SqlDbType.VarChar, 10)
            'prmParameter(7).Value = IIf(IsNothing(pLogisticaMovimiento.CATEGORIA), 0, pLogisticaMovimiento.CATEGORIA)


            Try

                Dim cnx As New SqlConnection(CadenaConexion)
                Dim cmd As New SqlCommand()
                Dim da As New SqlDataAdapter()

                cmd.Connection = cnx
                cmd.CommandText = "up_LogisticaMovimiento_Sellst"
                cmd.Parameters.AddWithValue("@pTIPO_MOV", IIf(IsNothing(pLogisticaMovimiento.TIPO_MOV), 0, pLogisticaMovimiento.TIPO_MOV))
                cmd.Parameters.AddWithValue("@pELEMENTO_MINERAL", IIf(IsNothing(pLogisticaMovimiento.ELEMENTO_MINERAL), 0, pLogisticaMovimiento.ELEMENTO_MINERAL))
                cmd.Parameters.AddWithValue("@pEMP_PROV_CLIENTE", IIf(IsNothing(pLogisticaMovimiento.EMP_PROV_CLIENTE), 0, pLogisticaMovimiento.EMP_PROV_CLIENTE))
                cmd.Parameters.AddWithValue("@pEMPRESA_CLI", IIf(IsNothing(pLogisticaMovimiento.EMPRESA_CLI), 0, pLogisticaMovimiento.EMPRESA_CLI))
                cmd.Parameters.AddWithValue("@pCOD_DEPOSITO", IIf(IsNothing(pLogisticaMovimiento.COD_DEPOSITO), 0, pLogisticaMovimiento.COD_DEPOSITO))
                cmd.Parameters.AddWithValue("@pLOTE_ORIGEN", IIf(IsNothing(pLogisticaMovimiento.LOTE_ORIGEN), 0, pLogisticaMovimiento.LOTE_ORIGEN))
                cmd.Parameters.AddWithValue("@codigoClase", IIf(IsNothing(pLogisticaMovimiento.TIPO_MINERAL), 0, pLogisticaMovimiento.TIPO_MINERAL))
                cmd.Parameters.AddWithValue("@CATEGORIA", IIf(IsNothing(pLogisticaMovimiento.CATEGORIA), 0, pLogisticaMovimiento.CATEGORIA))

                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandTimeout = 200

                da.SelectCommand = cmd

                da.Fill(oDSLogisticaMovimiento)


                'Using oDSLogisticaMovimiento
                '    oDSLogisticaMovimiento = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_LogisticaMovimiento_Sellst", prmParameter)
                '    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_LogisticaMovimiento_Sellst", oDSLogisticaMovimiento, New String() {"LogisticaMovimiento"}, prmParameter)
                '    If Not oDSLogisticaMovimiento Is Nothing Then
                '        If oDSLogisticaMovimiento.Tables.Count > 0 Then
                '            'If oDSLogisticaMovimiento.Tables("LogisticaMovimiento").Rows.Count > 0 Then
                '            If oDSLogisticaMovimiento.Tables(0).Rows.Count > 0 Then
                '                Return oDSLogisticaMovimiento
                '            End If
                '        End If
                '    End If
                'End Using

            Catch ex As Exception
                Throw ex

            End Try
            Return oDSLogisticaMovimiento

        End Function

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 25/02/2011 10:15:55
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSLogisticaAsociado(ByVal pLogisticaMovimiento As clsBE_LogisticaMovimiento) As DataSet
            Dim oDSLogisticaMovimiento As New DataSet
            Dim mintItem As Integer = 0

            Dim prmParameter(0) As SqlParameter

            prmParameter(0) = New SqlParameter("@pContratoLoteId", SqlDbType.VarChar, 20)
            prmParameter(0).Value = IIf(IsNothing(pLogisticaMovimiento.ContratoLoteId), "", pLogisticaMovimiento.ContratoLoteId)
            prmParameter(0).Direction = ParameterDirection.Input
            Try

                Using oDSLogisticaMovimiento
                    oDSLogisticaMovimiento = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_LogisticaMovimiento_Sellst_lista", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_LogisticaMovimiento_Sellst", oDSLogisticaMovimiento, New String() {"LogisticaMovimiento"}, prmParameter)
                    If Not oDSLogisticaMovimiento Is Nothing Then
                        If oDSLogisticaMovimiento.Tables.Count > 0 Then
                            'If oDSLogisticaMovimiento.Tables("LogisticaMovimiento").Rows.Count > 0 Then
                            If oDSLogisticaMovimiento.Tables(0).Rows.Count > 0 Then
                                Return oDSLogisticaMovimiento
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSLogisticaMovimiento

        End Function
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 25/02/2011 10:15:55
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function DefinirTablaLogisticaMovimiento() As DataTable

            Try
                Dim DTLogisticaMovimiento As New DataTable

                Dim ID As DataColumn = DTLogisticaMovimiento.Columns.Add("ID", GetType(Integer))
                ID.AllowDBNull = False
                ID.DefaultValue = 0


                Dim TMH As DataColumn = DTLogisticaMovimiento.Columns.Add("TMH", GetType(Integer))
                TMH.AllowDBNull = True
                TMH.DefaultValue = 0


                Dim ContratoLoteId As DataColumn = DTLogisticaMovimiento.Columns.Add("ContratoLoteId", GetType(String))
                ContratoLoteId.MaxLength = 20
                ContratoLoteId.AllowDBNull = True
                ContratoLoteId.DefaultValue = ""

                Dim ESTADO As DataColumn = DTLogisticaMovimiento.Columns.Add("ESTADO", GetType(String))
                ESTADO.MaxLength = 1
                ESTADO.AllowDBNull = True
                ESTADO.DefaultValue = ""

                Dim LiquidacionId As DataColumn = DTLogisticaMovimiento.Columns.Add("LiquidacionId", GetType(String))
                LiquidacionId.MaxLength = 20
                LiquidacionId.AllowDBNull = True
                LiquidacionId.DefaultValue = ""

                Dim LiquidacionTmId As DataColumn = DTLogisticaMovimiento.Columns.Add("LiquidacionTmId", GetType(String))
                LiquidacionTmId.MaxLength = 20
                LiquidacionTmId.AllowDBNull = True
                LiquidacionTmId.DefaultValue = ""

                Dim ContratoLoteSuceroaId As DataColumn = DTLogisticaMovimiento.Columns.Add("ContratoLoteSuceroaId", GetType(String))
                ContratoLoteSuceroaId.MaxLength = 20
                ContratoLoteSuceroaId.AllowDBNull = True
                ContratoLoteSuceroaId.DefaultValue = ""

                Dim EstadoVCM As DataColumn = DTLogisticaMovimiento.Columns.Add("EstadoVCM", GetType(String))
                EstadoVCM.MaxLength = 1
                EstadoVCM.AllowDBNull = True
                EstadoVCM.DefaultValue = ""

                Dim EMPRESA As DataColumn = DTLogisticaMovimiento.Columns.Add("EMPRESA", GetType(String))
                EMPRESA.MaxLength = 15
                EMPRESA.AllowDBNull = True
                EMPRESA.DefaultValue = ""

                Dim COD_DEPOSITO As DataColumn = DTLogisticaMovimiento.Columns.Add("COD_DEPOSITO", GetType(String))
                COD_DEPOSITO.MaxLength = 3
                COD_DEPOSITO.AllowDBNull = True
                COD_DEPOSITO.DefaultValue = ""

                Dim COD_LOTE As DataColumn = DTLogisticaMovimiento.Columns.Add("COD_LOTE", GetType(String))
                COD_LOTE.MaxLength = 20
                COD_LOTE.AllowDBNull = True
                COD_LOTE.DefaultValue = ""

                Dim NRO_DOCUMENTO As DataColumn = DTLogisticaMovimiento.Columns.Add("NRO_DOCUMENTO", GetType(String))
                NRO_DOCUMENTO.MaxLength = 12
                NRO_DOCUMENTO.AllowDBNull = True
                NRO_DOCUMENTO.DefaultValue = ""

                Dim TIPO_MOV As DataColumn = DTLogisticaMovimiento.Columns.Add("TIPO_MOV", GetType(String))
                TIPO_MOV.MaxLength = 2
                TIPO_MOV.AllowDBNull = True
                TIPO_MOV.DefaultValue = ""

                Dim N_ITEM As DataColumn = DTLogisticaMovimiento.Columns.Add("N_ITEM", GetType(Integer))
                N_ITEM.AllowDBNull = True
                N_ITEM.DefaultValue = 0


                Dim EMPRESA_ORIGEN As DataColumn = DTLogisticaMovimiento.Columns.Add("EMPRESA_ORIGEN", GetType(String))
                EMPRESA_ORIGEN.MaxLength = 15
                EMPRESA_ORIGEN.AllowDBNull = True
                EMPRESA_ORIGEN.DefaultValue = ""

                Dim DEPOSITO_ORIGEN As DataColumn = DTLogisticaMovimiento.Columns.Add("DEPOSITO_ORIGEN", GetType(String))
                DEPOSITO_ORIGEN.MaxLength = 3
                DEPOSITO_ORIGEN.AllowDBNull = True
                DEPOSITO_ORIGEN.DefaultValue = ""

                Dim LOTE_ORIGEN As DataColumn = DTLogisticaMovimiento.Columns.Add("LOTE_ORIGEN", GetType(String))
                LOTE_ORIGEN.MaxLength = 20
                LOTE_ORIGEN.AllowDBNull = True
                LOTE_ORIGEN.DefaultValue = ""

                Dim EMPRESA_DESTINO As DataColumn = DTLogisticaMovimiento.Columns.Add("EMPRESA_DESTINO", GetType(String))
                EMPRESA_DESTINO.MaxLength = 15
                EMPRESA_DESTINO.AllowDBNull = True
                EMPRESA_DESTINO.DefaultValue = ""

                Dim DEPOSITO_DESTINO As DataColumn = DTLogisticaMovimiento.Columns.Add("DEPOSITO_DESTINO", GetType(String))
                DEPOSITO_DESTINO.MaxLength = 3
                DEPOSITO_DESTINO.AllowDBNull = True
                DEPOSITO_DESTINO.DefaultValue = ""

                Dim LOTE_DESTINO As DataColumn = DTLogisticaMovimiento.Columns.Add("LOTE_DESTINO", GetType(String))
                LOTE_DESTINO.MaxLength = 20
                LOTE_DESTINO.AllowDBNull = True
                LOTE_DESTINO.DefaultValue = ""

                Dim PERIODO As DataColumn = DTLogisticaMovimiento.Columns.Add("PERIODO", GetType(String))
                PERIODO.MaxLength = 6
                PERIODO.AllowDBNull = True
                PERIODO.DefaultValue = ""

                Dim NUM_CONTRATO As DataColumn = DTLogisticaMovimiento.Columns.Add("NUM_CONTRATO", GetType(String))
                NUM_CONTRATO.MaxLength = 10
                NUM_CONTRATO.AllowDBNull = True
                NUM_CONTRATO.DefaultValue = ""

                Dim FECHA_APERTURA As DataColumn = DTLogisticaMovimiento.Columns.Add("FECHA_APERTURA", GetType(DateTime))


                Dim ELEMENTO_MINERAL As DataColumn = DTLogisticaMovimiento.Columns.Add("ELEMENTO_MINERAL", GetType(String))
                ELEMENTO_MINERAL.MaxLength = 3
                ELEMENTO_MINERAL.AllowDBNull = True
                ELEMENTO_MINERAL.DefaultValue = ""

                Dim TIPO_MINERAL As DataColumn = DTLogisticaMovimiento.Columns.Add("TIPO_MINERAL", GetType(String))
                TIPO_MINERAL.MaxLength = 6
                TIPO_MINERAL.AllowDBNull = True
                TIPO_MINERAL.DefaultValue = ""

                Dim EMP_PROV_CLIENTE As DataColumn = DTLogisticaMovimiento.Columns.Add("EMP_PROV_CLIENTE", GetType(String))
                EMP_PROV_CLIENTE.MaxLength = 15
                EMP_PROV_CLIENTE.AllowDBNull = True
                EMP_PROV_CLIENTE.DefaultValue = ""

                Dim TMH_SLC As DataColumn = DTLogisticaMovimiento.Columns.Add("TMH_SLC", GetType(Decimal))
                TMH_SLC.AllowDBNull = True
                TMH_SLC.DefaultValue = 0.0


                Dim ESTADO_SLC As DataColumn = DTLogisticaMovimiento.Columns.Add("ESTADO_SLC", GetType(Integer))
                ESTADO_SLC.AllowDBNull = True
                ESTADO_SLC.DefaultValue = 0


                Dim IND_GUIA_PROVFIN As DataColumn = DTLogisticaMovimiento.Columns.Add("IND_GUIA_PROVFIN", GetType(Integer))
                IND_GUIA_PROVFIN.AllowDBNull = True
                IND_GUIA_PROVFIN.DefaultValue = 0


                Dim IND_ASIGNA_PART As DataColumn = DTLogisticaMovimiento.Columns.Add("IND_ASIGNA_PART", GetType(Integer))
                IND_ASIGNA_PART.AllowDBNull = True
                IND_ASIGNA_PART.DefaultValue = 0


                Dim IND_ASIGNA_VCL As DataColumn = DTLogisticaMovimiento.Columns.Add("IND_ASIGNA_VCL", GetType(Integer))
                IND_ASIGNA_VCL.AllowDBNull = True
                IND_ASIGNA_VCL.DefaultValue = 0


                Dim IND_ASIGNA_BLEND As DataColumn = DTLogisticaMovimiento.Columns.Add("IND_ASIGNA_BLEND", GetType(Integer))
                IND_ASIGNA_BLEND.AllowDBNull = True
                IND_ASIGNA_BLEND.DefaultValue = 0


                Dim IND_ASIGNA_DESP As DataColumn = DTLogisticaMovimiento.Columns.Add("IND_ASIGNA_DESP", GetType(Integer))
                IND_ASIGNA_DESP.AllowDBNull = True
                IND_ASIGNA_DESP.DefaultValue = 0


                Dim IND_ASIGNA_LOTE As DataColumn = DTLogisticaMovimiento.Columns.Add("IND_ASIGNA_LOTE", GetType(Integer))
                IND_ASIGNA_LOTE.AllowDBNull = True
                IND_ASIGNA_LOTE.DefaultValue = 0


                Dim TICKET As DataColumn = DTLogisticaMovimiento.Columns.Add("TICKET", GetType(String))
                TICKET.MaxLength = 10
                TICKET.AllowDBNull = True
                TICKET.DefaultValue = ""

                Dim NRO_MUESTRA As DataColumn = DTLogisticaMovimiento.Columns.Add("NRO_MUESTRA", GetType(String))
                NRO_MUESTRA.MaxLength = 12
                NRO_MUESTRA.AllowDBNull = True
                NRO_MUESTRA.DefaultValue = ""

                Dim H2O As DataColumn = DTLogisticaMovimiento.Columns.Add("H2O", GetType(Decimal))
                H2O.AllowDBNull = True
                H2O.DefaultValue = 0.0


                Dim LEY_CU As DataColumn = DTLogisticaMovimiento.Columns.Add("LEY_CU", GetType(Decimal))
                LEY_CU.AllowDBNull = True
                LEY_CU.DefaultValue = 0.0


                Dim LEY_AG As DataColumn = DTLogisticaMovimiento.Columns.Add("LEY_AG", GetType(Decimal))
                LEY_AG.AllowDBNull = True
                LEY_AG.DefaultValue = 0.0


                Dim LEY_AU As DataColumn = DTLogisticaMovimiento.Columns.Add("LEY_AU", GetType(Decimal))
                LEY_AU.AllowDBNull = True
                LEY_AU.DefaultValue = 0.0


                Dim LEY_PB As DataColumn = DTLogisticaMovimiento.Columns.Add("LEY_PB", GetType(Decimal))
                LEY_PB.AllowDBNull = True
                LEY_PB.DefaultValue = 0.0


                Dim LEY_ZN As DataColumn = DTLogisticaMovimiento.Columns.Add("LEY_ZN", GetType(Decimal))
                LEY_ZN.AllowDBNull = True
                LEY_ZN.DefaultValue = 0.0


                Dim LEY_SN As DataColumn = DTLogisticaMovimiento.Columns.Add("LEY_SN", GetType(Decimal))
                LEY_SN.AllowDBNull = True
                LEY_SN.DefaultValue = 0.0


                Dim LEY_AS As DataColumn = DTLogisticaMovimiento.Columns.Add("LEY_AS", GetType(Decimal))
                LEY_AS.AllowDBNull = True
                LEY_AS.DefaultValue = 0.0


                Dim LEY_SB As DataColumn = DTLogisticaMovimiento.Columns.Add("LEY_SB", GetType(Decimal))
                LEY_SB.AllowDBNull = True
                LEY_SB.DefaultValue = 0.0


                Dim LEY_BI As DataColumn = DTLogisticaMovimiento.Columns.Add("LEY_BI", GetType(Decimal))
                LEY_BI.AllowDBNull = True
                LEY_BI.DefaultValue = 0.0


                Dim LEY_HG As DataColumn = DTLogisticaMovimiento.Columns.Add("LEY_HG", GetType(Decimal))
                LEY_HG.AllowDBNull = True
                LEY_HG.DefaultValue = 0.0


                Dim LEY_SIO2 As DataColumn = DTLogisticaMovimiento.Columns.Add("LEY_SIO2", GetType(Decimal))
                LEY_SIO2.AllowDBNull = True
                LEY_SIO2.DefaultValue = 0.0


                Dim LEY_AS_SB As DataColumn = DTLogisticaMovimiento.Columns.Add("LEY_AS_SB", GetType(Decimal))
                LEY_AS_SB.AllowDBNull = True
                LEY_AS_SB.DefaultValue = 0.0


                Dim LEY_ZN_PB As DataColumn = DTLogisticaMovimiento.Columns.Add("LEY_ZN_PB", GetType(Decimal))
                LEY_ZN_PB.AllowDBNull = True
                LEY_ZN_PB.DefaultValue = 0.0


                Dim LEY_AUNW As DataColumn = DTLogisticaMovimiento.Columns.Add("LEY_AUNW", GetType(Decimal))
                LEY_AUNW.AllowDBNull = True
                LEY_AUNW.DefaultValue = 0.0


                Dim LEY_CUTOT As DataColumn = DTLogisticaMovimiento.Columns.Add("LEY_CUTOT", GetType(Decimal))
                LEY_CUTOT.AllowDBNull = True
                LEY_CUTOT.DefaultValue = 0.0


                Dim LEY_CUSOL As DataColumn = DTLogisticaMovimiento.Columns.Add("LEY_CUSOL", GetType(Decimal))
                LEY_CUSOL.AllowDBNull = True
                LEY_CUSOL.DefaultValue = 0.0


                Dim LEY_CNNa As DataColumn = DTLogisticaMovimiento.Columns.Add("LEY_CNNa", GetType(Decimal))
                LEY_CNNa.AllowDBNull = True
                LEY_CNNa.DefaultValue = 0.0


                Dim LEY_CAL As DataColumn = DTLogisticaMovimiento.Columns.Add("LEY_CAL", GetType(Decimal))
                LEY_CAL.AllowDBNull = True
                LEY_CAL.DefaultValue = 0.0


                Dim LEY_SOD As DataColumn = DTLogisticaMovimiento.Columns.Add("LEY_SOD", GetType(Decimal))
                LEY_SOD.AllowDBNull = True
                LEY_SOD.DefaultValue = 0.0


                Return DTLogisticaMovimiento
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class
#End Region

End Namespace
