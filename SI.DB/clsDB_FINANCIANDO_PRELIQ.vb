



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

    Public Class clsDB_FINANCIANDO_PRELIQTX

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionEN")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("EN")
        End Sub

        ''Public Function financiando_UPDATE(ByVal oBE_FINANCIANDO_PRELIQ As List(Of clsBE_FINANCIANDO_PRELIQ)) As Boolean
        ''    For Each oFINANCIANDO_PRELIQ As clsBE_FINANCIANDO_PRELIQ In oBE_FINANCIANDO_PRELIQ
        ''        Dim prmParameter(8) As SqlParameter

        ''        'prmParameter(0) = New SqlParameter("@@estado_fin", SqlDbType.VarChar, 20)
        ''        ''prmParameter(0).Value = IIf(IsNothing(oContratoLote.contratoLoteId), "", oContratoLote.contratoLoteId)
        ''        'prmParameter(0).Direction = ParameterDirection.Output
        ''        prmParameter(0) = New SqlParameter("@estado_fin", SqlDbType.VarChar, 1)
        ''        prmParameter(0).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.estado_fin), "", oFINANCIANDO_PRELIQ.estado_fin)
        ''        prmParameter(0).Direction = ParameterDirection.Input

        ''        prmParameter(1) = New SqlParameter("@flg_aplica", SqlDbType.VarChar, 1)
        ''        prmParameter(1).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.flg_aplica), "", oFINANCIANDO_PRELIQ.flg_aplica)
        ''        prmParameter(1).Direction = ParameterDirection.Input
        ''        prmParameter(2) = New SqlParameter("@flg_diferido", SqlDbType.VarChar, 1)
        ''        prmParameter(2).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.flg_diferido), "", oFINANCIANDO_PRELIQ.flg_diferido)
        ''        prmParameter(2).Direction = ParameterDirection.Input
        ''        prmParameter(3) = New SqlParameter("@empresa", SqlDbType.VarChar, 4)
        ''        prmParameter(3).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.empresa), "", oFINANCIANDO_PRELIQ.empresa)
        ''        prmParameter(3).Direction = ParameterDirection.Input
        ''        prmParameter(4) = New SqlParameter("@nro_op", SqlDbType.VarChar, 10)
        ''        prmParameter(4).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.NRO_OP), "", oFINANCIANDO_PRELIQ.NRO_OP)
        ''        prmParameter(4).Direction = ParameterDirection.Input
        ''        prmParameter(5) = New SqlParameter("@tipo_op", SqlDbType.VarChar, 1)
        ''        prmParameter(5).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.tipo_op), "", oFINANCIANDO_PRELIQ.tipo_op)
        ''        prmParameter(5).Direction = ParameterDirection.Input
        ''        prmParameter(6) = New SqlParameter("@TIPO_COMPR", SqlDbType.VarChar, 2)
        ''        prmParameter(6).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.TIPO_COMPR), "", oFINANCIANDO_PRELIQ.TIPO_COMPR)
        ''        prmParameter(6).Direction = ParameterDirection.Input
        ''        prmParameter(7) = New SqlParameter("@num_compr", SqlDbType.VarChar, 10)
        ''        prmParameter(7).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.num_compr), "", oFINANCIANDO_PRELIQ.num_compr)
        ''        prmParameter(7).Direction = ParameterDirection.Input
        ''        prmParameter(8) = New SqlParameter("@seq", SqlDbType.VarChar, 2)
        ''        prmParameter(8).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.seq), "", oFINANCIANDO_PRELIQ.seq)
        ''        prmParameter(8).Direction = ParameterDirection.Input

        ''        Try
        ''            SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "financiando_UPDATE", prmParameter)
        ''            'oFINANCIANDO_PRELIQ.contratoLoteId = prmParameter(0).Value
        ''        Catch ex As Exception
        ''            Throw ex
        ''            Return False
        ''        End Try
        ''    Next
        ''    Return True
        ''End Function


        Public Function financiando_preliq_INSERT(ByVal oBE_FINANCIANDO_PRELIQ As List(Of clsBE_FINANCIANDO_PRELIQ)) As Boolean
            Dim item As Integer = 0

            For Each oFINANCIANDO_PRELIQ As clsBE_FINANCIANDO_PRELIQ In oBE_FINANCIANDO_PRELIQ
                Dim prmParameter(20) As SqlParameter

                prmParameter(0) = New SqlParameter("@empresa", SqlDbType.VarChar, 4)
                prmParameter(0).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.empresa), "", oFINANCIANDO_PRELIQ.empresa)
                prmParameter(0).Direction = ParameterDirection.Input
                'prmParameter(0) = New SqlParameter("@empresa", SqlDbType.VarChar, 20)
                ''prmParameter(0).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.contratoLoteId), "", oFINANCIANDO_PRELIQ.contratoLoteId)
                'prmParameter(0).Direction = ParameterDirection.Output
                prmParameter(1) = New SqlParameter("@nro_op", SqlDbType.VarChar, 10)
                prmParameter(1).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.NRO_OP), "", oFINANCIANDO_PRELIQ.NRO_OP)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@tipo_op", SqlDbType.VarChar, 1)
                prmParameter(2).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.tipo_op), "", oFINANCIANDO_PRELIQ.tipo_op)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@tipo_compr", SqlDbType.VarChar, 2)
                prmParameter(3).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.TIPO_COMPR), "", oFINANCIANDO_PRELIQ.TIPO_COMPR)
                prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@num_compr", SqlDbType.VarChar, 10)
                prmParameter(4).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.num_compr), "", oFINANCIANDO_PRELIQ.num_compr)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@seq", SqlDbType.VarChar, 2)
                prmParameter(5).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.seq), "", oFINANCIANDO_PRELIQ.seq)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@tipo_compr_liq", SqlDbType.VarChar, 2)
                prmParameter(6).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.LOTE), "", oFINANCIANDO_PRELIQ.LOTE)
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7) = New SqlParameter("@num_compr_liq", SqlDbType.VarChar, 10)
                prmParameter(7).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.tipo_compr_liq), "", oFINANCIANDO_PRELIQ.tipo_compr_liq)
                prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(8) = New SqlParameter("@usuario_liq", SqlDbType.VarChar, 10)
                prmParameter(8).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.usuario_liq), "", oFINANCIANDO_PRELIQ.usuario_liq)
                prmParameter(8).Direction = ParameterDirection.Input
                prmParameter(9) = New SqlParameter("@monto_Liq", SqlDbType.Float)
                prmParameter(9).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.monto_Liq), 0, oFINANCIANDO_PRELIQ.monto_Liq)
                prmParameter(9).Direction = ParameterDirection.Input
                prmParameter(10) = New SqlParameter("@monto_tot_liq", SqlDbType.Float)
                prmParameter(10).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.monto_tot_liq), 0, oFINANCIANDO_PRELIQ.monto_tot_liq)
                prmParameter(10).Direction = ParameterDirection.Input
                prmParameter(11) = New SqlParameter("@cod_lote", SqlDbType.VarChar, 11)
                prmParameter(11).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.cod_lote), "", oFINANCIANDO_PRELIQ.cod_lote)
                prmParameter(11).Direction = ParameterDirection.Input
                prmParameter(12) = New SqlParameter("@LOTE_COM", SqlDbType.VarChar, 5)
                prmParameter(12).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.LOTE_COM), "", oFINANCIANDO_PRELIQ.LOTE_COM)
                prmParameter(12).Direction = ParameterDirection.Input
                prmParameter(13) = New SqlParameter("@proveedor_liq", SqlDbType.VarChar, 11)
                prmParameter(13).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.proveedor_liq), "", oFINANCIANDO_PRELIQ.proveedor_liq)
                prmParameter(13).Direction = ParameterDirection.Input
                prmParameter(14) = New SqlParameter("@estado_liq", SqlDbType.VarChar, 1)
                prmParameter(14).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.estado_liq), "", oFINANCIANDO_PRELIQ.estado_liq)
                prmParameter(14).Direction = ParameterDirection.Input
                'prmParameter(15) = New SqlParameter("@item", SqlDbType.Float)
                'prmParameter(15).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.Item), 0, oFINANCIANDO_PRELIQ.Item)
                'prmParameter(15).Direction = ParameterDirection.Input

                prmParameter(15) = New SqlParameter("@estado_fin", SqlDbType.VarChar, 1)
                prmParameter(15).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.estado_fin), "", oFINANCIANDO_PRELIQ.estado_fin)
                prmParameter(15).Direction = ParameterDirection.Input

                prmParameter(16) = New SqlParameter("@flg_aplica", SqlDbType.VarChar, 1)
                prmParameter(16).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.flg_aplica), "", oFINANCIANDO_PRELIQ.flg_aplica)
                prmParameter(16).Direction = ParameterDirection.Input
                prmParameter(17) = New SqlParameter("@flg_diferido", SqlDbType.VarChar, 1)
                prmParameter(17).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.flg_diferido), "", oFINANCIANDO_PRELIQ.flg_diferido)
                prmParameter(17).Direction = ParameterDirection.Input

                prmParameter(18) = New SqlParameter("@contratoloteId", SqlDbType.VarChar, 20)
                prmParameter(18).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.sContratoLoteId), "", oFINANCIANDO_PRELIQ.sContratoLoteId)
                prmParameter(18).Direction = ParameterDirection.Input

                prmParameter(19) = New SqlParameter("@item_insert", SqlDbType.Int)
                'prmParameter(19).Value = item 'IIf(IsNothing(oFINANCIANDO_PRELIQ.Item), 0, oFINANCIANDO_PRELIQ.Item)
                prmParameter(19).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.Item), 0, oFINANCIANDO_PRELIQ.Item)
                prmParameter(19).Direction = ParameterDirection.Input

                prmParameter(20) = New SqlParameter("@ruma", SqlDbType.VarChar, 20)
                prmParameter(20).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.RUMA), "", oFINANCIANDO_PRELIQ.RUMA)
                prmParameter(20).Direction = ParameterDirection.Input

                'prmParameter(20) = New SqlParameter("@item_output", SqlDbType.Int)
                'prmParameter(20).Direction = ParameterDirection.Output
                ''oFINANCIANDO_PRELIQ.Item = prmParameter(18).Value

                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "financiando_preliq_INSERT", prmParameter)
                    'oFINANCIANDO_PRELIQ.Item = prmParameter(20).Value
                    'item = prmParameter(20).Value
                Catch ex As Exception
                    Throw ex
                    Return False
                End Try
            Next
            Return True
        End Function

        Public Function financiando_preliq_APLICA(ByVal oFINANCIANDO_PRELIQ As clsBE_FINANCIANDO_PRELIQ) As Integer
            Dim item As Integer = 0

            'For Each oFINANCIANDO_PRELIQ As clsBE_FINANCIANDO_PRELIQ In oBE_FINANCIANDO_PRELIQ
            Dim prmParameter(5) As SqlParameter

            prmParameter(0) = New SqlParameter("@item", SqlDbType.Int)
            prmParameter(0).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.Item), 0, oFINANCIANDO_PRELIQ.Item)
            prmParameter(0).Direction = ParameterDirection.Input


            prmParameter(1) = New SqlParameter("@contratoloteId", SqlDbType.VarChar, 20)
            prmParameter(1).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.sContratoLoteId), "", oFINANCIANDO_PRELIQ.sContratoLoteId)
            prmParameter(1).Direction = ParameterDirection.Input


            prmParameter(2) = New SqlParameter("@liquidacionId", SqlDbType.VarChar, 20)
            prmParameter(2).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.sLiquidacionId), "", oFINANCIANDO_PRELIQ.sLiquidacionId)
            prmParameter(2).Direction = ParameterDirection.Input

            prmParameter(3) = New SqlParameter("@TIPO_COMPR", SqlDbType.VarChar, 20)
            prmParameter(3).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.tipo_compr_liq), 0, oFINANCIANDO_PRELIQ.tipo_compr_liq)
            prmParameter(3).Direction = ParameterDirection.Input

            prmParameter(4) = New SqlParameter("@NUM_COMPR", SqlDbType.VarChar, 20)
            prmParameter(4).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.NUM_COMPR_LIQ), "", oFINANCIANDO_PRELIQ.NUM_COMPR_LIQ)
            prmParameter(4).Direction = ParameterDirection.Input

            prmParameter(5) = New SqlParameter("@FECHA_COMPR", SqlDbType.DateTime)
            prmParameter(5).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.dFechaLiquidacion), "01/01/1900", oFINANCIANDO_PRELIQ.dFechaLiquidacion)
            prmParameter(5).Direction = ParameterDirection.Input

            Try
                'SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "financiando_preliq_aplica", prmParameter)
                Dim nExiste As Integer = 0
                nExiste = SqlHelper.ExecuteScalar(CadenaConexion, CommandType.StoredProcedure, "financiando_preliq_aplica", prmParameter)

                Return nExiste
            Catch ex As Exception
                Throw ex
                Return 0
            End Try
            'Next
            'Return 0
        End Function



        Public Function financiando_preliq_DELETE(ByVal oFINANCIANDO_PRELIQ As clsBE_FINANCIANDO_PRELIQ) As Boolean
            Dim item As Integer = 0

            'For Each oFINANCIANDO_PRELIQ As clsBE_FINANCIANDO_PRELIQ In oBE_FINANCIANDO_PRELIQ
            Dim prmParameter(2) As SqlParameter

            prmParameter(0) = New SqlParameter("@item", SqlDbType.Int)
            prmParameter(0).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.Item), 0, oFINANCIANDO_PRELIQ.Item)
            prmParameter(0).Direction = ParameterDirection.Input

            prmParameter(1) = New SqlParameter("@contratoloteid", SqlDbType.VarChar, 20)
            prmParameter(1).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.sContratoLoteId), "", oFINANCIANDO_PRELIQ.sContratoLoteId)
            prmParameter(1).Direction = ParameterDirection.Input

            prmParameter(2) = New SqlParameter("@LiquidacionId", SqlDbType.VarChar, 20)
            prmParameter(2).Value = IIf(IsNothing(oFINANCIANDO_PRELIQ.sLiquidacionId), "", oFINANCIANDO_PRELIQ.sLiquidacionId)
            prmParameter(2).Direction = ParameterDirection.Input

            Try
                SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "financiando_preliq_DEL", prmParameter)

            Catch ex As Exception
                Throw ex
                Return False
            End Try
            'Next
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
    Public Class clsDB_FINANCIANDO_PRELIQRO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionEN")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("EN")
        End Sub
        ''    ''' <summary>
        ''    ''' Escrito por: Lissete Miyahira
        ''    ''' Fecha Creacion: 24/10/2012 16:58:46
        ''    ''' Proposito: Lee los datos de un registro
        ''    ''' Fecha Modificacion:
        ''    ''' </summary>
        ''    ''' 
        ''    Public Function LeerFINANCIANDO_PRELIQ() As clsBE_FINANCIANDO_PRELIQ
        ''        Dim oFINANCIANDO_PRELIQ As clsBE_FINANCIANDO_PRELIQ = Nothing
        ''        Dim DSFINANCIANDO_PRELIQ As New DataSet
        ''        Try
        ''            Using DSFINANCIANDO_PRELIQ
        ''                DSFINANCIANDO_PRELIQ = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_FINANCIANDO_PRELIQ")
        ''                If Not DSFINANCIANDO_PRELIQ Is Nothing Then
        ''                    If DSFINANCIANDO_PRELIQ.Tables.Count > 0 Then
        ''                        oFINANCIANDO_PRELIQ = New clsBE_FINANCIANDO_PRELIQ
        ''                        If DSFINANCIANDO_PRELIQ.Tables(0).Rows.Count > 0 Then
        ''                            With DSFINANCIANDO_PRELIQ.Tables(0).Rows(0)
        ''                                oFINANCIANDO_PRELIQ.COD_DEPOSITO = .Item("COD_DEPOSITO").ToString
        ''                                oFINANCIANDO_PRELIQ.NOM_DEPOSITO = .Item("NOM_DEPOSITO").ToString

        ''                                oFINANCIANDO_PRELIQ.EMPRESA = .Item("EMPRESA").ToString
        ''                                oFINANCIANDO_PRELIQ.LOCALIDAD = .Item("LOCALIDAD").ToString
        ''                                oFINANCIANDO_PRELIQ.DIRECCION = .Item("DIRECCION").ToString

        ''                                oFINANCIANDO_PRELIQ.DESC_ABREV_DEP = .Item("DESC_ABREV_DEP").ToString
        ''                                oFINANCIANDO_PRELIQ.FECHA_REG_DEP = .Item("FECHA_REG_DEP").ToString
        ''                                oFINANCIANDO_PRELIQ.ID_LOCALIDAD = .Item("ID_LOCALIDAD").ToString
        ''                                oFINANCIANDO_PRELIQ.DES_LOCALIDAD = .Item("DES_LOCALIDAD").ToString
        ''                            End With
        ''                        End If
        ''                    End If
        ''                End If
        ''            End Using
        ''        Catch exSql As SqlException

        ''        Catch ex As Exception
        ''            Throw ex
        ''        Finally
        ''            If Not DSFINANCIANDO_PRELIQ Is Nothing Then
        ''                DSFINANCIANDO_PRELIQ.Dispose()
        ''            End If
        ''            DSFINANCIANDO_PRELIQ = Nothing
        ''        End Try

        ''        Return oFINANCIANDO_PRELIQ

        ''    End Function

        Public Function Obtener_Correlativo() As Integer
            Dim oDSgeneral As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(5) As SqlParameter

            Try
                Using oDSgeneral
                    oDSgeneral = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "UPS_FINANCIANDO_CIE_OBTENER_ID")
                    If Not oDSgeneral Is Nothing Then
                        If oDSgeneral.Tables.Count > 0 Then
                            If oDSgeneral.Tables(0).Rows.Count > 0 Then
                                Return oDSgeneral.Tables(0).Rows(0).Item("correlativo")
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex
            End Try
            Return ""
        End Function

        Public Function ObtenerMaximoDiasValidacion() As Integer
            Dim oDSgeneral As New DataSet
            Try
                Using oDSgeneral
                    oDSgeneral = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "SP_MAXIMO_DIAS_VALIDACION")
                    If Not oDSgeneral Is Nothing Then
                        If oDSgeneral.Tables.Count > 0 Then
                            If oDSgeneral.Tables(0).Rows.Count > 0 Then
                                Return oDSgeneral.Tables(0).Rows(0).Item("C_C_VALOR")
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex
            End Try
            Return ""
        End Function

        Public Function LeerListaToDSFINANCIANDO_PRELIQ(ByVal pFINANCIANDO_PRELIQ As clsBE_FINANCIANDO_PRELIQ) As DataSet
            Dim oDSFINANCIANDO_PRELIQ As New DataSet
            Dim mintItem As Integer = 0
            Try
                Dim prmParameter(1) As SqlParameter

                prmParameter(0) = New SqlParameter("@cod_lote", SqlDbType.VarChar, 11)
                prmParameter(0).Value = IIf(IsNothing(pFINANCIANDO_PRELIQ.CONTRATO), "", pFINANCIANDO_PRELIQ.CONTRATO)

                prmParameter(1) = New SqlParameter("@lote", SqlDbType.VarChar, 5)
                prmParameter(1).Value = IIf(IsNothing(pFINANCIANDO_PRELIQ.LOTE), "", pFINANCIANDO_PRELIQ.LOTE)

                Using oDSFINANCIANDO_PRELIQ
                    oDSFINANCIANDO_PRELIQ = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_FINANCIANDO_PRELIQ_Sel", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_PUB_PERSONAS_Sellst", oDSPUB_PERSONAS, New String() {"PUB_PERSONAS"}, prmParameter)
                    If Not oDSFINANCIANDO_PRELIQ Is Nothing Then
                        If oDSFINANCIANDO_PRELIQ.Tables.Count > 0 Then
                            'If oDSPUB_PERSONAS.Tables("PUB_PERSONAS").Rows.Count > 0 Then
                            If oDSFINANCIANDO_PRELIQ.Tables(0).Rows.Count > 0 Then
                                Return oDSFINANCIANDO_PRELIQ
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSFINANCIANDO_PRELIQ

        End Function


        Public Function LeerListaToDSFINANCIANDO_PRELIQ_CBT(ByVal nItem As Integer) As String
            Dim oDSFINANCIANDO As New DataSet
            Dim mintItem As Integer = 0
            Try
                'Dim prmParameter(2) As SqlParameter

                'prmParameter(0) = New SqlParameter("@proveedor", SqlDbType.VarChar, 20)
                'prmParameter(0).Value = IIf(IsNothing(pFINANCIANDO.proveedor), "", pFINANCIANDO.proveedor)

                'prmParameter(1) = New SqlParameter("@ESTADO_FIN", SqlDbType.VarChar, 2)
                'prmParameter(1).Value = IIf(IsNothing(pFINANCIANDO.estado_fin), "", pFINANCIANDO.estado_fin)

                'prmParameter(2) = New SqlParameter("@empresa", SqlDbType.VarChar, 20)
                'prmParameter(2).Value = IIf(IsNothing(pFINANCIANDO.stablaDetId), "", pFINANCIANDO.stablaDetId)

                Return SqlHelper.ExecuteScalar(CadenaConexion, CommandType.Text, "select isnull(max(FLG_VALIDA),0) from FINANCIANDO_CIE where ITEM =" & nItem)
            Catch ex As Exception
                Throw ex

            End Try
            'Return oDSFINANCIANDO

        End Function



        Public Function LeerListaToDSFINANCIANDO(ByVal pFINANCIANDO As clsBE_FINANCIANDO_PRELIQ) As DataSet
            Dim oDSFINANCIANDO As New DataSet
            Dim mintItem As Integer = 0
            Try
                Dim prmParameter(2) As SqlParameter

                prmParameter(0) = New SqlParameter("@proveedor", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(pFINANCIANDO.proveedor), "", pFINANCIANDO.proveedor)

                prmParameter(1) = New SqlParameter("@ESTADO_FIN", SqlDbType.VarChar, 2)
                prmParameter(1).Value = IIf(IsNothing(pFINANCIANDO.estado_fin), "", pFINANCIANDO.estado_fin)

                prmParameter(2) = New SqlParameter("@empresa", SqlDbType.VarChar, 20)
                prmParameter(2).Value = IIf(IsNothing(pFINANCIANDO.stablaDetId), "", pFINANCIANDO.stablaDetId)

                Using oDSFINANCIANDO
                    oDSFINANCIANDO = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_FINANCIANDO_sel", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_PUB_PERSONAS_Sellst", oDSPUB_PERSONAS, New String() {"PUB_PERSONAS"}, prmParameter)
                    If Not oDSFINANCIANDO Is Nothing Then
                        If oDSFINANCIANDO.Tables.Count > 0 Then
                            'If oDSPUB_PERSONAS.Tables("PUB_PERSONAS").Rows.Count > 0 Then
                            If oDSFINANCIANDO.Tables(0).Rows.Count > 0 Then
                                Return oDSFINANCIANDO
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSFINANCIANDO

        End Function


        Public Function LeerListaToDSFINANCIANDO_PREAPLICA(ByVal pFINANCIANDO As clsBE_FINANCIANDO_PRELIQ) As DataSet
            Dim oDSFINANCIANDO As New DataSet
            Dim mintItem As Integer = 0
            Try
                Dim prmParameter(1) As SqlParameter

                'prmParameter(0) = New SqlParameter("@proveedor", SqlDbType.VarChar, 20)
                'prmParameter(0).Value = IIf(IsNothing(pFINANCIANDO.proveedor), "", pFINANCIANDO.proveedor)

                'prmParameter(1) = New SqlParameter("@ESTADO_FIN", SqlDbType.VarChar, 2)
                'prmParameter(1).Value = IIf(IsNothing(pFINANCIANDO.estado_fin), "", pFINANCIANDO.estado_fin)

                Using oDSFINANCIANDO
                    oDSFINANCIANDO = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_Financiando_preliq_preaplica")
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_PUB_PERSONAS_Sellst", oDSPUB_PERSONAS, New String() {"PUB_PERSONAS"}, prmParameter)
                    If Not oDSFINANCIANDO Is Nothing Then
                        If oDSFINANCIANDO.Tables.Count > 0 Then
                            'If oDSPUB_PERSONAS.Tables("PUB_PERSONAS").Rows.Count > 0 Then
                            If oDSFINANCIANDO.Tables(0).Rows.Count > 0 Then
                                Return oDSFINANCIANDO
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSFINANCIANDO

        End Function


        Public Function LeerListaToDSFINANCIANDO_DETALLE(ByVal pFINANCIANDO As clsBE_FINANCIANDO_PRELIQ) As DataSet
            Dim oDSFINANCIANDO As New DataSet
            Dim mintItem As Integer = 0
            Try
                Dim prmParameter(1) As SqlParameter

                prmParameter(0) = New SqlParameter("@Item", SqlDbType.Int)
                prmParameter(0).Value = IIf(IsNothing(pFINANCIANDO.Item), 0, pFINANCIANDO.Item)

                prmParameter(1) = New SqlParameter("@liquidacion", SqlDbType.VarChar, 20)
                prmParameter(1).Value = IIf(IsNothing(pFINANCIANDO.sLiquidacionId), "", pFINANCIANDO.sLiquidacionId)

                Using oDSFINANCIANDO
                    oDSFINANCIANDO = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_Financiando_preliq_detalle", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_PUB_PERSONAS_Sellst", oDSPUB_PERSONAS, New String() {"PUB_PERSONAS"}, prmParameter)
                    If Not oDSFINANCIANDO Is Nothing Then
                        If oDSFINANCIANDO.Tables.Count > 0 Then
                            'If oDSPUB_PERSONAS.Tables("PUB_PERSONAS").Rows.Count > 0 Then
                            If oDSFINANCIANDO.Tables(0).Rows.Count > 0 Then
                                Return oDSFINANCIANDO
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSFINANCIANDO

        End Function



        Public Function LeerListaToDSFINANCIANDO_CLI(ByVal pFINANCIANDO As clsBE_FINANCIANDO_PRELIQ) As DataSet
            Dim oDSFINANCIANDO As New DataSet
            Dim mintItem As Integer = 0
            Try
                Dim prmParameter(0) As SqlParameter

                prmParameter(0) = New SqlParameter("@proveedor", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(pFINANCIANDO.proveedor), "", pFINANCIANDO.proveedor)

                'prmParameter(1) = New SqlParameter("@ESTADO_FIN", SqlDbType.VarChar, 2)
                'prmParameter(1).Value = IIf(IsNothing(pFINANCIANDO.estado_fin), "", pFINANCIANDO.estado_fin)

                Using oDSFINANCIANDO
                    oDSFINANCIANDO = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_FINANCIANDO_CLI_sel", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_PUB_PERSONAS_Sellst", oDSPUB_PERSONAS, New String() {"PUB_PERSONAS"}, prmParameter)
                    If Not oDSFINANCIANDO Is Nothing Then
                        If oDSFINANCIANDO.Tables.Count > 0 Then
                            'If oDSPUB_PERSONAS.Tables("PUB_PERSONAS").Rows.Count > 0 Then
                            If oDSFINANCIANDO.Tables(0).Rows.Count > 0 Then
                                Return oDSFINANCIANDO
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSFINANCIANDO

        End Function


        Public Function LeerListaToDSAplicados(ByVal pFINANCIANDO As clsBE_FINANCIANDO_PRELIQ) As DataSet
            Dim oDSFINANCIANDO As New DataSet
            Dim mintItem As Integer = 0
            Try
                Dim prmParameter(1) As SqlParameter

                prmParameter(0) = New SqlParameter("@proveedor", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(pFINANCIANDO.proveedor), "", pFINANCIANDO.proveedor)

                prmParameter(1) = New SqlParameter("@ESTADO_FIN", SqlDbType.VarChar, 2)
                prmParameter(1).Value = IIf(IsNothing(pFINANCIANDO.estado_fin), "", pFINANCIANDO.estado_fin)

                Using oDSFINANCIANDO
                    oDSFINANCIANDO = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_APLICADOS_sel", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_PUB_PERSONAS_Sellst", oDSPUB_PERSONAS, New String() {"PUB_PERSONAS"}, prmParameter)
                    If Not oDSFINANCIANDO Is Nothing Then
                        If oDSFINANCIANDO.Tables.Count > 0 Then
                            'If oDSPUB_PERSONAS.Tables("PUB_PERSONAS").Rows.Count > 0 Then
                            If oDSFINANCIANDO.Tables(0).Rows.Count > 0 Then
                                Return oDSFINANCIANDO
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSFINANCIANDO

        End Function


        'Public Function VERIFICA_OP_FINANCIAMIENTO() As DataSet
        '    Dim oDSFINANCIANDO As New DataSet
        '    Dim mintItem As Integer = 0
        '    Try


        '        Using oDSFINANCIANDO
        '            oDSFINANCIANDO = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_VERIFICA_OP_FINANCIAMIENTO_VCM")
        '            'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_PUB_PERSONAS_Sellst", oDSPUB_PERSONAS, New String() {"PUB_PERSONAS"}, prmParameter)
        '            If Not oDSFINANCIANDO Is Nothing Then
        '                If oDSFINANCIANDO.Tables.Count > 0 Then
        '                    'If oDSPUB_PERSONAS.Tables("PUB_PERSONAS").Rows.Count > 0 Then
        '                    If oDSFINANCIANDO.Tables(0).Rows.Count > 0 Then
        '                        Return oDSFINANCIANDO
        '                    End If
        '                End If
        '            End If
        '        End Using
        '    Catch ex As Exception
        '        Throw ex

        '    End Try
        '    Return oDSFINANCIANDO

        'End Function




        Public Function LeerListaToDSFINANCIANDO_SELECCION(ByVal pFINANCIANDO As clsBE_FINANCIANDO_PRELIQ) As DataSet
            Dim oDSFINANCIANDO As New DataSet
            Dim mintItem As Integer = 0
            Try
                Dim prmParameter(5) As SqlParameter

                prmParameter(0) = New SqlParameter("@condicion_empresa", SqlDbType.VarChar, 2000)
                prmParameter(0).Value = IIf(IsNothing(pFINANCIANDO.scondicion_empresa), "", pFINANCIANDO.scondicion_empresa)
                prmParameter(1) = New SqlParameter("@condicion_nro_op", SqlDbType.VarChar, 2000)
                prmParameter(1).Value = IIf(IsNothing(pFINANCIANDO.scondicion_nro_op), "", pFINANCIANDO.scondicion_nro_op)
                prmParameter(2) = New SqlParameter("@condicion_tipo_op", SqlDbType.VarChar, 2000)
                prmParameter(2).Value = IIf(IsNothing(pFINANCIANDO.scondicion_tipo_op), "", pFINANCIANDO.scondicion_tipo_op)
                prmParameter(3) = New SqlParameter("@condicion_tipo_compr", SqlDbType.VarChar, 2000)
                prmParameter(3).Value = IIf(IsNothing(pFINANCIANDO.scondicion_tipo_compr), "", pFINANCIANDO.scondicion_tipo_compr)
                prmParameter(4) = New SqlParameter("@condicion_num_compr", SqlDbType.VarChar, 2000)
                prmParameter(4).Value = IIf(IsNothing(pFINANCIANDO.scondicion_num_compr), "", pFINANCIANDO.scondicion_num_compr)
                prmParameter(5) = New SqlParameter("@condicion_seq", SqlDbType.VarChar, 2000)
                prmParameter(5).Value = IIf(IsNothing(pFINANCIANDO.scondicion_seq), "", pFINANCIANDO.scondicion_seq)

                Using oDSFINANCIANDO
                    oDSFINANCIANDO = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_financiando_seleccion", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_PUB_PERSONAS_Sellst", oDSPUB_PERSONAS, New String() {"PUB_PERSONAS"}, prmParameter)
                    If Not oDSFINANCIANDO Is Nothing Then
                        If oDSFINANCIANDO.Tables.Count > 0 Then
                            'If oDSPUB_PERSONAS.Tables("PUB_PERSONAS").Rows.Count > 0 Then
                            If oDSFINANCIANDO.Tables(0).Rows.Count > 0 Then
                                Return oDSFINANCIANDO
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSFINANCIANDO

        End Function



        Public Function LeerListaToDSFINANCIANDO_PRELIQ_PDF(ByVal pFINANCIANDO As clsBE_FINANCIANDO_PRELIQ) As DataSet
            Dim oDSFINANCIANDO As New DataSet
            Dim mintItem As Integer = 0
            Try
                Dim prmParameter(0) As SqlParameter

                prmParameter(0) = New SqlParameter("@ITEM", SqlDbType.Int)
                prmParameter(0).Value = IIf(IsNothing(pFINANCIANDO.Item), "", pFINANCIANDO.Item)
                

                Using oDSFINANCIANDO
                    oDSFINANCIANDO = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "ups_financiando_preliq_pdf", prmParameter)
                    If Not oDSFINANCIANDO Is Nothing Then
                        If oDSFINANCIANDO.Tables.Count > 0 Then
                            If oDSFINANCIANDO.Tables(0).Rows.Count > 0 Then
                                Return oDSFINANCIANDO
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSFINANCIANDO

        End Function

        '' ''' <summary>
        '' ''' Escrito por: Martin Huaman
        '' ''' Fecha Creacion: 17/02/2011 16:58:46
        '' ''' Proposito: Obtiene la lista de registros
        '' ''' Fecha Modificacion:
        '' ''' </summary>
        ''Public Function LeerListaFINANCIANDO_PRELIQ() As List(Of clsBE_FINANCIANDO_PRELIQ)
        ''    Dim olstFINANCIANDO_PRELIQ As New List(Of clsBE_FINANCIANDO_PRELIQ)
        ''    Dim oFINANCIANDO_PRELIQ As clsBE_FINANCIANDO_PRELIQ = Nothing
        ''    Dim mintItem As Integer = 0

        ''    oFINANCIANDO_PRELIQ = New clsBE_FINANCIANDO_PRELIQ
        ''    'oFINANCIANDO_PRELIQ.COD_DEPOSITO = ""
        ''    'oFINANCIANDO_PRELIQ.NOM_DEPOSITO = "[Seleccione]"
        ''    olstFINANCIANDO_PRELIQ.Add(oFINANCIANDO_PRELIQ)
        ''    Try
        ''        Using Reader As SqlDataReader = SqlHelper.ExecuteReader(CadenaConexion, CommandType.StoredProcedure, "up_FINANCIANDO_PRELIQ_Sel")




        ''            ''If Reader.HasRows Then
        ''            ''    While Reader.Read
        ''            ''        oFINANCIANDO_PRELIQ = New clsBE_FINANCIANDO_PRELIQ
        ''            ''        mintItem += 1
        ''            ''        With oFINANCIANDO_PRELIQ
        ''            ''            '.Item = mintItem
        ''            ''            .Item = Reader("Item").ToString
        ''            ''            .NUM_COMPR_LIQ = Reader("NUM_COMPR_LIQ").ToString
        ''            ''            .MONTO_TOTAL_LIQ = Reader("MONTO_TOT_LIQ").ToString

        ''            ''        End With
        ''            ''        olstFINANCIANDO_PRELIQ.Add(oFINANCIANDO_PRELIQ)
        ''            ''    End While
        ''            ''End If
        ''        End Using
        ''    Catch ex As Exception
        ''        Throw ex
        ''    End Try

        ''    Return olstFINANCIANDO_PRELIQ

        ''End Function

        ' ''' <summary>
        ' ''' Escrito por: Martin Huaman
        ' ''' Fecha Creacion: 17/02/2011 16:58:46
        ' ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ' ''' Fecha Modificacion:
        ' ''' </summary>
        'Public Function LeerListaToDSFINANCIANDO_PRELIQ(ByVal pFINANCIANDO_PRELIQ As clsBE_FINANCIANDO_PRELIQ) As Dataset
        '    Dim oDSFINANCIANDO_PRELIQ As New DataSet
        '    Dim mintItem As Integer = 0
        '    Try

        '        Using oDSFINANCIANDO_PRELIQ
        '            oDSFINANCIANDO_PRELIQ = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_FINANCIANDO_PRELIQ")
        '            'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_FINANCIANDO_PRELIQ_Sellst", oDSFINANCIANDO_PRELIQ, New String() {"FINANCIANDO_PRELIQ"}, prmParameter)
        '            If Not oDSFINANCIANDO_PRELIQ Is Nothing Then
        '                If oDSFINANCIANDO_PRELIQ.Tables.Count > 0 Then
        '                    'If oDSFINANCIANDO_PRELIQ.Tables("FINANCIANDO_PRELIQ").Rows.Count > 0 Then
        '                    If oDSFINANCIANDO_PRELIQ.Tables(0).Rows.Count > 0 Then
        '                        Return oDSFINANCIANDO_PRELIQ
        '                    End If
        '                End If
        '            End If
        '        End Using
        '    Catch ex As Exception
        '        Throw ex

        '    End Try
        '    Return oDSFINANCIANDO_PRELIQ

        'End Function


        '' ''' <summary>
        '' ''' Escrito por: Martin Huaman
        '' ''' Fecha Creacion: 17/02/2011 16:58:46
        '' ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        '' ''' Fecha Modificacion:
        '' ''' </summary>
        ''Public Function DefinirFINANCIANDO_PRELIQFINANCIANDO_PRELIQ() As DataTable

        ''    Try
        ''        Dim DTFINANCIANDO_PRELIQ As New DataTable

        ''        Dim FINANCIANDO_PRELIQId As DataColumn = DTFINANCIANDO_PRELIQ.Columns.Add("FINANCIANDO_PRELIQId", GetType(String))
        ''        FINANCIANDO_PRELIQId.MaxLength = 20
        ''        FINANCIANDO_PRELIQId.AllowDBNull = False
        ''        FINANCIANDO_PRELIQId.DefaultValue = ""

        ''        Dim descri As DataColumn = DTFINANCIANDO_PRELIQ.Columns.Add("descri", GetType(String))
        ''        descri.MaxLength = 100
        ''        descri.AllowDBNull = True
        ''        descri.DefaultValue = ""

        ''        Dim codigoEstado As DataColumn = DTFINANCIANDO_PRELIQ.Columns.Add("codigoEstado", GetType(String))
        ''        codigoEstado.MaxLength = 15
        ''        codigoEstado.AllowDBNull = True
        ''        codigoEstado.DefaultValue = ""

        ''        Dim uc As DataColumn = DTFINANCIANDO_PRELIQ.Columns.Add("uc", GetType(String))
        ''        uc.MaxLength = 15
        ''        uc.AllowDBNull = True
        ''        uc.DefaultValue = ""

        ''        Dim fc As DataColumn = DTFINANCIANDO_PRELIQ.Columns.Add("fc", GetType(DateTime))


        ''        Dim um As DataColumn = DTFINANCIANDO_PRELIQ.Columns.Add("um", GetType(String))
        ''        um.MaxLength = 15
        ''        um.AllowDBNull = True
        ''        um.DefaultValue = ""

        ''        Dim fm As DataColumn = DTFINANCIANDO_PRELIQ.Columns.Add("fm", GetType(DateTime))


        ''        Dim codigoVisible As DataColumn = DTFINANCIANDO_PRELIQ.Columns.Add("codigoVisible", GetType(String))
        ''        codigoVisible.MaxLength = 15
        ''        codigoVisible.AllowDBNull = True
        ''        codigoVisible.DefaultValue = ""

        ''        Return DTFINANCIANDO_PRELIQ
        ''    Catch ex As Exception
        ''        Throw ex
        ''    End Try
        ''End Function

    End Class
#End Region

End Namespace
