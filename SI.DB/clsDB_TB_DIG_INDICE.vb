



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
    ''' Fecha Creacion: 17/02/2011 16:58:45
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la FINANCIANDO_PRELIQ FINANCIANDO_PRELIQ
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsDB_TB_DIG_INDICETX

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionEN")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("EN")
        End Sub


        Public Function TB_DIG_INDICE_INSERT(ByVal oBE_TB_DIG_INDICE As List(Of clsBE_TB_DIG_INDICE)) As Boolean
            For Each oTB_DIG_INDICE As clsBE_TB_DIG_INDICE In oBE_TB_DIG_INDICE
                Dim prmParameter(27) As SqlParameter

                prmParameter(0) = New SqlParameter("@IDITEM", SqlDbType.Int)
                prmParameter(1) = New SqlParameter("@EMPRESA", SqlDbType.VarChar, 15)
                prmParameter(2) = New SqlParameter("@IDTIPODOC_DIG", SqlDbType.VarChar, 10)
                prmParameter(3) = New SqlParameter("@PROVEEDOR", SqlDbType.VarChar, 15)
                prmParameter(4) = New SqlParameter("@CONTRATO", SqlDbType.VarChar, 20)
                prmParameter(5) = New SqlParameter("@LOTE", SqlDbType.VarChar, 20)
                prmParameter(6) = New SqlParameter("@NRO_DOC_INTERNO", SqlDbType.VarChar, 20)
                prmParameter(7) = New SqlParameter("@NRO_DOC_EXTERNO", SqlDbType.VarChar, 20)
                prmParameter(8) = New SqlParameter("@FECHA_DOC", SqlDbType.DateTime)
                prmParameter(9) = New SqlParameter("@RUMA", SqlDbType.VarChar, 15)
                prmParameter(10) = New SqlParameter("@BENEFICIARIO", SqlDbType.VarChar, 15)
                prmParameter(11) = New SqlParameter("@REFERENCIA1", SqlDbType.VarChar, 20)
                prmParameter(12) = New SqlParameter("@ARCHIVO", SqlDbType.VarChar, 200)
                prmParameter(13) = New SqlParameter("@IDFLUJO", SqlDbType.VarChar, 10)
                prmParameter(14) = New SqlParameter("@CONTRATO_LIQ", SqlDbType.VarChar, 20)
                prmParameter(15) = New SqlParameter("@LOTE_LIQ", SqlDbType.VarChar, 20)
                prmParameter(16) = New SqlParameter("@LIQUIDACION", SqlDbType.VarChar, 20)
                prmParameter(17) = New SqlParameter("@ContratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(18) = New SqlParameter("@LiquidacionId", SqlDbType.VarChar, 20)
                prmParameter(19) = New SqlParameter("@IDITEM_ORIGEN", SqlDbType.Int)


                prmParameter(20) = New SqlParameter("@liquidacionEstadoId", SqlDbType.Int)
                prmParameter(21) = New SqlParameter("@liquidacionEstadoDetalleId", SqlDbType.Int)
                prmParameter(22) = New SqlParameter("@uc", SqlDbType.VarChar, 20)
                prmParameter(23) = New SqlParameter("@ruta", SqlDbType.VarChar, 100)
                prmParameter(24) = New SqlParameter("@liquidacionAdjuntoId", SqlDbType.VarChar, 20)
                prmParameter(25) = New SqlParameter("@RUTA_ORIGEN", SqlDbType.VarChar, 2000)

                prmParameter(26) = New SqlParameter("@NRO_OP", SqlDbType.VarChar, 10)
                prmParameter(27) = New SqlParameter("@estado", SqlDbType.Int)


                prmParameter(0).Value = IIf(IsNothing(oTB_DIG_INDICE.IDITEM), 0, oTB_DIG_INDICE.IDITEM)
                prmParameter(1).Value = IIf(IsNothing(oTB_DIG_INDICE.EMPRESA), "", oTB_DIG_INDICE.EMPRESA)
                prmParameter(2).Value = IIf(IsNothing(oTB_DIG_INDICE.IDTIPODOC_DIG), "", oTB_DIG_INDICE.IDTIPODOC_DIG)
                prmParameter(3).Value = IIf(IsNothing(oTB_DIG_INDICE.PROVEEDOR), "", oTB_DIG_INDICE.PROVEEDOR)
                prmParameter(4).Value = IIf(IsNothing(oTB_DIG_INDICE.CONTRATO), "", oTB_DIG_INDICE.CONTRATO)
                prmParameter(5).Value = IIf(IsNothing(oTB_DIG_INDICE.LOTE), "", oTB_DIG_INDICE.LOTE)
                prmParameter(6).Value = IIf(IsNothing(oTB_DIG_INDICE.NRO_DOC_INTERNO), "", oTB_DIG_INDICE.NRO_DOC_INTERNO)
                prmParameter(7).Value = IIf(IsNothing(oTB_DIG_INDICE.NRO_DOC_EXTERNO), "", oTB_DIG_INDICE.NRO_DOC_EXTERNO)
                prmParameter(8).Value = IIf(IsNothing(oTB_DIG_INDICE.FECHA_DOC), "#01/01/1900#", oTB_DIG_INDICE.FECHA_DOC)
                prmParameter(9).Value = IIf(IsNothing(oTB_DIG_INDICE.RUMA), "", oTB_DIG_INDICE.RUMA)
                prmParameter(10).Value = IIf(IsNothing(oTB_DIG_INDICE.BENEFICIARIO), "", oTB_DIG_INDICE.BENEFICIARIO)
                prmParameter(11).Value = IIf(IsNothing(oTB_DIG_INDICE.REFERENCIA1), "", oTB_DIG_INDICE.REFERENCIA1)
                prmParameter(12).Value = IIf(IsNothing(oTB_DIG_INDICE.ARCHIVO), "", oTB_DIG_INDICE.ARCHIVO)
                prmParameter(13).Value = IIf(IsNothing(oTB_DIG_INDICE.IDFLUJO), "", oTB_DIG_INDICE.IDFLUJO)
                prmParameter(14).Value = IIf(IsNothing(oTB_DIG_INDICE.CONTRATO_LIQ), "", oTB_DIG_INDICE.CONTRATO_LIQ)
                prmParameter(15).Value = IIf(IsNothing(oTB_DIG_INDICE.LOTE_LIQ), "", oTB_DIG_INDICE.LOTE_LIQ)
                prmParameter(16).Value = IIf(IsNothing(oTB_DIG_INDICE.LIQUIDACION), "", oTB_DIG_INDICE.LIQUIDACION)
                prmParameter(17).Value = IIf(IsNothing(oTB_DIG_INDICE.ContratoLoteId), "", oTB_DIG_INDICE.ContratoLoteId)
                prmParameter(18).Value = IIf(IsNothing(oTB_DIG_INDICE.LiquidacionId), "", oTB_DIG_INDICE.LiquidacionId)
                prmParameter(19).Value = IIf(IsNothing(oTB_DIG_INDICE.IDITEM_ORIGEN), 0, oTB_DIG_INDICE.IDITEM_ORIGEN)

                prmParameter(20).Value = IIf(IsNothing(oTB_DIG_INDICE.liquidacionEstadoId), 0, oTB_DIG_INDICE.liquidacionEstadoId)
                prmParameter(21).Value = IIf(IsNothing(oTB_DIG_INDICE.liquidacionEstadoDetalleId), 0, oTB_DIG_INDICE.liquidacionEstadoDetalleId)
                prmParameter(22).Value = IIf(IsNothing(oTB_DIG_INDICE.uc), "", oTB_DIG_INDICE.uc)
                prmParameter(23).Value = IIf(IsNothing(oTB_DIG_INDICE.RUTA), "", oTB_DIG_INDICE.RUTA)
                prmParameter(24).Value = IIf(IsNothing(oTB_DIG_INDICE.liquidacionAdjuntoId), "", oTB_DIG_INDICE.liquidacionAdjuntoId)
                prmParameter(25).Value = IIf(IsNothing(oTB_DIG_INDICE.RUTA_ORIGEN), "", oTB_DIG_INDICE.RUTA_ORIGEN)

                prmParameter(26).Value = IIf(IsNothing(oTB_DIG_INDICE.NRO_OP), "", oTB_DIG_INDICE.NRO_OP)
                prmParameter(27).Value = IIf(IsNothing(oTB_DIG_INDICE.ESTADO), 2, oTB_DIG_INDICE.ESTADO)

                prmParameter(0).Direction = ParameterDirection.Output

                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "upTB_DIG_INDICE_Ins", prmParameter)
                    prmParameter(0).Value = oTB_DIG_INDICE.IDITEM
                Catch ex As Exception
                    Throw ex
                    Return False
                End Try
            Next
            Return True
        End Function


        Public Function TB_DIG_INDICE_UPDATE(ByVal oBE_TB_DIG_INDICE As List(Of clsBE_TB_DIG_INDICE)) As Boolean
            For Each oTB_DIG_INDICE As clsBE_TB_DIG_INDICE In oBE_TB_DIG_INDICE
                Dim prmParameter(18) As SqlParameter

                prmParameter(0) = New SqlParameter("@IDITEM", SqlDbType.Int)
                prmParameter(1) = New SqlParameter("@EMPRESA", SqlDbType.VarChar, 4)
                prmParameter(2) = New SqlParameter("@IDTIPODOC_DIG", SqlDbType.VarChar, 4)
                prmParameter(3) = New SqlParameter("@PROVEEDOR", SqlDbType.VarChar, 15)
                prmParameter(4) = New SqlParameter("@CONTRATO", SqlDbType.VarChar, 20)
                prmParameter(5) = New SqlParameter("@LOTE", SqlDbType.VarChar, 20)
                prmParameter(6) = New SqlParameter("@NRO_DOC_INTERNO", SqlDbType.VarChar, 20)
                prmParameter(7) = New SqlParameter("@NRO_DOC_EXTERNO", SqlDbType.VarChar, 20)
                prmParameter(8) = New SqlParameter("@FECHA_DOC", SqlDbType.DateTime)
                prmParameter(9) = New SqlParameter("@RUMA", SqlDbType.VarChar, 15)
                prmParameter(10) = New SqlParameter("@BENEFICIARIO", SqlDbType.VarChar, 15)
                prmParameter(11) = New SqlParameter("@REFERENCIA1", SqlDbType.VarChar, 20)
                prmParameter(12) = New SqlParameter("@ARCHIVO", SqlDbType.VarChar, 200)
                prmParameter(13) = New SqlParameter("@IDFLUJO", SqlDbType.VarChar, 10)
                prmParameter(14) = New SqlParameter("@CONTRATO_LIQ", SqlDbType.VarChar, 20)
                prmParameter(15) = New SqlParameter("@LOTE_LIQ", SqlDbType.VarChar, 20)
                prmParameter(16) = New SqlParameter("@LIQUIDACION", SqlDbType.VarChar, 20)
                prmParameter(17) = New SqlParameter("@ContratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(18) = New SqlParameter("@LiquidacionId", SqlDbType.VarChar, 20)

                prmParameter(0).Value = IIf(IsNothing(oTB_DIG_INDICE.IDITEM), 0, oTB_DIG_INDICE.IDITEM)
                prmParameter(1).Value = IIf(IsNothing(oTB_DIG_INDICE.EMPRESA), "", oTB_DIG_INDICE.EMPRESA)
                prmParameter(2).Value = IIf(IsNothing(oTB_DIG_INDICE.IDTIPODOC_DIG), "", oTB_DIG_INDICE.IDTIPODOC_DIG)
                prmParameter(3).Value = IIf(IsNothing(oTB_DIG_INDICE.PROVEEDOR), "", oTB_DIG_INDICE.PROVEEDOR)
                prmParameter(4).Value = IIf(IsNothing(oTB_DIG_INDICE.CONTRATO), "", oTB_DIG_INDICE.CONTRATO)
                prmParameter(5).Value = IIf(IsNothing(oTB_DIG_INDICE.LOTE), "", oTB_DIG_INDICE.LOTE)
                prmParameter(6).Value = IIf(IsNothing(oTB_DIG_INDICE.NRO_DOC_INTERNO), "", oTB_DIG_INDICE.NRO_DOC_INTERNO)
                prmParameter(7).Value = IIf(IsNothing(oTB_DIG_INDICE.NRO_DOC_EXTERNO), "", oTB_DIG_INDICE.NRO_DOC_EXTERNO)
                prmParameter(8).Value = IIf(IsNothing(oTB_DIG_INDICE.FECHA_DOC), "#01/01/1900#", oTB_DIG_INDICE.FECHA_DOC)
                prmParameter(9).Value = IIf(IsNothing(oTB_DIG_INDICE.RUMA), "", oTB_DIG_INDICE.RUMA)
                prmParameter(10).Value = IIf(IsNothing(oTB_DIG_INDICE.BENEFICIARIO), "", oTB_DIG_INDICE.BENEFICIARIO)
                prmParameter(11).Value = IIf(IsNothing(oTB_DIG_INDICE.REFERENCIA1), "", oTB_DIG_INDICE.REFERENCIA1)
                prmParameter(12).Value = IIf(IsNothing(oTB_DIG_INDICE.ARCHIVO), "", oTB_DIG_INDICE.ARCHIVO)
                prmParameter(13).Value = IIf(IsNothing(oTB_DIG_INDICE.IDFLUJO), "", oTB_DIG_INDICE.IDFLUJO)
                prmParameter(14).Value = IIf(IsNothing(oTB_DIG_INDICE.CONTRATO_LIQ), "", oTB_DIG_INDICE.CONTRATO_LIQ)
                prmParameter(15).Value = IIf(IsNothing(oTB_DIG_INDICE.LOTE_LIQ), "", oTB_DIG_INDICE.LOTE_LIQ)
                prmParameter(16).Value = IIf(IsNothing(oTB_DIG_INDICE.LIQUIDACION), "", oTB_DIG_INDICE.LIQUIDACION)
                prmParameter(17).Value = IIf(IsNothing(oTB_DIG_INDICE.ContratoLoteId), "", oTB_DIG_INDICE.ContratoLoteId)
                prmParameter(18).Value = IIf(IsNothing(oTB_DIG_INDICE.LiquidacionId), "", oTB_DIG_INDICE.LiquidacionId)

                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "upTB_DIG_INDICE_Upd", prmParameter)

                Catch ex As Exception
                    Throw ex
                    Return False
                End Try
            Next
            Return True
        End Function


        Public Function TB_DIG_INDICE_ASOCIA(ByVal oBE_TB_DIG_INDICE As List(Of clsBE_TB_DIG_INDICE)) As Boolean
            For Each oTB_DIG_INDICE As clsBE_TB_DIG_INDICE In oBE_TB_DIG_INDICE
                Dim prmParameter(6) As SqlParameter


                prmParameter(0) = New SqlParameter("@IDFLUJO", SqlDbType.VarChar, 10)
                prmParameter(1) = New SqlParameter("@CONTRATO_LIQ", SqlDbType.VarChar, 20)
                prmParameter(2) = New SqlParameter("@LOTE_LIQ", SqlDbType.VarChar, 10)
                prmParameter(3) = New SqlParameter("@LIQUIDACION", SqlDbType.VarChar, 20)
                prmParameter(4) = New SqlParameter("@ContratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(5) = New SqlParameter("@LiquidacionId", SqlDbType.VarChar, 20)
                prmParameter(6) = New SqlParameter("@IDITEM_ORIGEN", SqlDbType.Int)


                prmParameter(0).Value = IIf(IsNothing(oTB_DIG_INDICE.IDFLUJO), "", oTB_DIG_INDICE.IDFLUJO)
                prmParameter(1).Value = IIf(IsNothing(oTB_DIG_INDICE.CONTRATO_LIQ), "", oTB_DIG_INDICE.CONTRATO_LIQ)
                prmParameter(2).Value = IIf(IsNothing(oTB_DIG_INDICE.LOTE_LIQ), "", oTB_DIG_INDICE.LOTE_LIQ)
                prmParameter(3).Value = IIf(IsNothing(oTB_DIG_INDICE.LIQUIDACION), "", oTB_DIG_INDICE.LIQUIDACION)
                prmParameter(4).Value = IIf(IsNothing(oTB_DIG_INDICE.ContratoLoteId), "", oTB_DIG_INDICE.ContratoLoteId)
                prmParameter(5).Value = IIf(IsNothing(oTB_DIG_INDICE.LiquidacionId), "", oTB_DIG_INDICE.LiquidacionId)
                prmParameter(6).Value = IIf(IsNothing(oTB_DIG_INDICE.IDITEM_ORIGEN), 0, oTB_DIG_INDICE.IDITEM_ORIGEN)

                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "upTB_DIG_INDICE_ASO", prmParameter)

                Catch ex As Exception
                    Throw ex
                    Return False
                End Try
            Next
            Return True
        End Function

    End Class
#End Region

#Region "Clase Lectura"
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:46
    ''' Proposito: Obtiene los valores de la FINANCIANDO_PRELIQ FINANCIANDO_PRELIQ
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsDB_TB_DIG_INDICERO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionEN")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("EN")
        End Sub



        Public Function LeerListaToDSTB_DIG_INDICE_Sel(ByVal nIDITEM As Integer) As DataSet
            Dim oDSTB_DIG_INDICE As New DataSet
            Try
                Dim prmParameter(0) As SqlParameter

                prmParameter(0) = New SqlParameter("@IDTIPODOC_DIG", SqlDbType.Int)
                prmParameter(0).Value = nIDITEM 'IIf(IsNothing(pTB_DIG_INDICE.IDTIPODOC_DIG), 0, pTB_DIG_INDICE.IDTIPODOC_DIG)

                'prmParameter(1) = New SqlParameter("@LOTE_COM", SqlDbType.VarChar, 20)
                'prmParameter(1).Value = IIf(IsNothing(pFINANCIANDO_PRELIQ.LOTE_COM), "", pFINANCIANDO_PRELIQ.LOTE_COM)

                Return SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "upTB_DIG_INDICE_Sel", prmParameter)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function LeerListaToDSTB_DIG_INDICE_Sel_Archivo(ByVal sContratoLoteId As String) As DataSet
            Dim oDSTB_DIG_INDICE As New DataSet
            Try
                Dim prmParameter(0) As SqlParameter

                prmParameter(0) = New SqlParameter("@contratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(0).Value = sContratoLoteId 'IIf(IsNothing(pTB_DIG_INDICE.IDTIPODOC_DIG), 0, pTB_DIG_INDICE.IDTIPODOC_DIG)

                'prmParameter(1) = New SqlParameter("@LOTE_COM", SqlDbType.VarChar, 20)
                'prmParameter(1).Value = IIf(IsNothing(pFINANCIANDO_PRELIQ.LOTE_COM), "", pFINANCIANDO_PRELIQ.LOTE_COM)

                Return SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_DIG_INDICE_Sel_Archivo", prmParameter)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        
        Public Function LeerListaToDSTB_DIG_INDICE_Sel_ASO(ByVal sIDTIPODOC_DIG As String, ByVal sEMPRESA As String, ByVal SPROVEEDOR As String, ByVal sContratoLoteId As String, ByVal sLiquidacionId As String) As DataSet
            Dim oDSTB_DIG_INDICE As New DataSet
            Try
                Dim prmParameter(4) As SqlParameter

                prmParameter(0) = New SqlParameter("@IDTIPODOC_DIG", SqlDbType.VarChar, 10)
                prmParameter(0).Value = sIDTIPODOC_DIG 'IIf(IsNothing(pTB_DIG_INDICE.IDTIPODOC_DIG), 0, pTB_DIG_INDICE.IDTIPODOC_DIG)


                prmParameter(1) = New SqlParameter("@EMPRESA", SqlDbType.VarChar, 20)
                prmParameter(1).Value = sEMPRESA 'IIf(IsNothing(pTB_DIG_INDICE.IDTIPODOC_DIG), 0, pTB_DIG_INDICE.IDTIPODOC_DIG)

                prmParameter(2) = New SqlParameter("@PROVEEDOR", SqlDbType.VarChar, 20)
                prmParameter(2).Value = SPROVEEDOR 'IIf(IsNothing(pTB_DIG_INDICE.IDTIPODOC_DIG), 0, pTB_DIG_INDICE.IDTIPODOC_DIG)

                prmParameter(3) = New SqlParameter("@ContratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(3).Value = sContratoLoteId  'IIf(IsNothing(pTB_DIG_INDICE.IDTIPODOC_DIG), 0, pTB_DIG_INDICE.IDTIPODOC_DIG)

                prmParameter(4) = New SqlParameter("@LiquidacionId", SqlDbType.VarChar, 20)
                prmParameter(4).Value = sLiquidacionId   'IIf(IsNothing(pTB_DIG_INDICE.IDTIPODOC_DIG), 0, pTB_DIG_INDICE.IDTIPODOC_DIG)

                'prmParameter(1) = New SqlParameter("@LOTE_COM", SqlDbType.VarChar, 20)
                'prmParameter(1).Value = IIf(IsNothing(pFINANCIANDO_PRELIQ.LOTE_COM), "", pFINANCIANDO_PRELIQ.LOTE_COM)

                Return SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "upTB_DIG_INDICE_Sel_ASO", prmParameter)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class


   

#End Region

End Namespace
