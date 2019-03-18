Imports Microsoft.ApplicationBlocks.Data
Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports SI.BE
Imports SI.UT
Namespace SI.DB
    Partial Public Class clsDB_LiquidacionRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:40:02
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function DefineTablaLiquidacion() As DataTable

            Try
                Dim DTLiquidacion As New DataTable



                Return DTLiquidacion
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function fnTipoLiquidacion(ByVal psCodLote As String) As DataTable
            Dim prmParameter(0) As SqlParameter

            prmParameter(0) = New SqlParameter("@codigoLote", SqlDbType.VarChar, 15)
            prmParameter(0).Value = psCodLote
            prmParameter(0).Direction = ParameterDirection.Input
            Try
                Dim DTTipLiquidacion As New DataTable

                DTTipLiquidacion = SqlHelper.ExecuteDataTable(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionTipo", prmParameter)


                Return DTTipLiquidacion
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function fnTipoLiquidacionOld(ByVal psCodLote As String) As DataTable
            Dim prmParameter(0) As SqlParameter

            prmParameter(0) = New SqlParameter("@codigoLote", SqlDbType.VarChar, 15)
            prmParameter(0).Value = psCodLote
            prmParameter(0).Direction = ParameterDirection.Input
            Try
                Dim DTTipLiquidacion As New DataTable

                DTTipLiquidacion = SqlHelper.ExecuteDataTable(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionTipo_old", prmParameter)


                Return DTTipLiquidacion
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function fnCrearLiquidacion(ByVal psCodLote As String, ByVal piNummeroCalculo As Integer, _
                                            ByVal psCodigoCalculo As String, ByVal psUC As String, _
                                            ByVal psCodTrader As String, ByVal pdFecha_Liquidacion As Date, ByVal sAccion As String) As String

            Dim oDSContratoLote As New DataSet
            Dim lsRetorna As String = String.Empty

            'Dim prmParameter(6) As SqlParameter
            'prmParameter(0) = New SqlParameter("@psCodLote", SqlDbType.VarChar, 20)
            'prmParameter(0).Value = psCodLote
            'prmParameter(0).Direction = ParameterDirection.Input
            'prmParameter(1) = New SqlParameter("@numeroCalculo", SqlDbType.Int)
            'prmParameter(1).Value = piNummeroCalculo
            'prmParameter(1).Direction = ParameterDirection.Input
            'prmParameter(2) = New SqlParameter("@codigoCalculo", SqlDbType.VarChar, 15)
            'prmParameter(2).Value = psCodigoCalculo
            'prmParameter(2).Direction = ParameterDirection.Input
            'prmParameter(3) = New SqlParameter("@uc", SqlDbType.VarChar, 15)
            'prmParameter(3).Value = psUC
            'prmParameter(3).Direction = ParameterDirection.Input
            'prmParameter(4) = New SqlParameter("@codigoTrader", SqlDbType.VarChar, 20)
            'prmParameter(4).Value = psCodTrader
            'prmParameter(4).Direction = ParameterDirection.Input
            'prmParameter(5) = New SqlParameter("@pfecha_liquidacion", SqlDbType.DateTime, 20)
            'prmParameter(5).Value = pdFecha_Liquidacion
            'prmParameter(5).Direction = ParameterDirection.Input

            'prmParameter(6) = New SqlParameter("@accion", SqlDbType.VarChar, 200)
            'prmParameter(6).Value = sAccion
            'prmParameter(6).Direction = ParameterDirection.Input

            Try
                Dim cnx As New SqlConnection(CadenaConexion)
                Dim cmd As New SqlCommand()
                Dim da As New SqlDataAdapter()

                cnx.Open()
                cmd.Connection = cnx

                cmd.CommandText = "up_LiquidacionGenerar"
                cmd.Parameters.Add("@psCodLote", psCodLote)
                cmd.Parameters.Add("@numeroCalculo", piNummeroCalculo)
                cmd.Parameters.Add("@codigoCalculo", psCodigoCalculo)
                cmd.Parameters.Add("@uc", psUC)
                cmd.Parameters.Add("@codigoTrader", psCodTrader)
                cmd.Parameters.Add("@pfecha_liquidacion", pdFecha_Liquidacion)
                cmd.Parameters.Add("@accion", sAccion)


                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandTimeout = 3000

                'da.SelectCommand = cmd
                'lsRetorna = da.Fill(oDSContratoLote).ToString
                lsRetorna = Convert.ToString(cmd.ExecuteScalar())

                cnx.Close()
                'Try

                'lsRetorna = Convert.ToString(SqlHelper.ExecuteScalar(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionGenerar", prmParameter))


            Catch ex As Exception
                Throw ex
            End Try
            Return lsRetorna
        End Function


        Public Function fnPreliquidaciones(ByVal sPeriodo As String) As Boolean
            Dim lbResultado As Boolean = True

            Try
                Dim prmParameter(0) As SqlParameter
                prmParameter(0) = New SqlParameter("@periodo", SqlDbType.VarChar, 6)
                prmParameter(0).Value = IIf(IsNothing(sPeriodo), "", sPeriodo)

                SqlHelper.ExecuteScalar(CadenaConexion, CommandType.StoredProcedure, "GeneraLiquidaciones03", prmParameter)

                SqlHelper.ExecuteScalar(CadenaConexion, CommandType.StoredProcedure, "CalculaLotes")

                SqlHelper.ExecuteScalar(CadenaConexion, CommandType.StoredProcedure, "upMezclas_x_Periodo", prmParameter)

                SqlHelper.ExecuteScalar(CadenaConexion, CommandType.StoredProcedure, "up_COSTO_VENTA", prmParameter)

            Catch ex As Exception
                lbResultado = False
            End Try
            Return lbResultado
        End Function



        Public Function fnCalculaLote(ByVal sContratoLoteId As String, ByVal oBE_AuditoriaD As clsBE_AuditoriaD, Optional ByVal sUsuarioModifica As String = "VCM", Optional ByVal sAcccion As String = "SISTE") As Boolean
            Dim lbResultado As Boolean = True

            Try
                Dim prmParameter(2) As SqlParameter

                prmParameter(0) = New SqlParameter("@contratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(sContratoLoteId), "", sContratoLoteId)

                prmParameter(1) = New SqlParameter("@usuarioModifica", SqlDbType.VarChar, 20)
                prmParameter(1).Value = sUsuarioModifica 'IIf(IsNothing(sContratoLoteId), "", sContratoLoteId)

                prmParameter(2) = New SqlParameter("@accion", SqlDbType.VarChar, 5)
                prmParameter(2).Value = sAcccion 'IIf(IsNothing(sContratoLoteId), "", sContratoLoteId)

                SqlHelper.ExecuteScalar(CadenaConexion, CommandType.StoredProcedure, "CalculaLotes", prmParameter)


                ''Auditoria
                'Dim oDB_AuditoriaDTX As New clsDB_AuditoriaDTX

                'oBE_AuditoriaD.CadenaConexion = CadenaConexion
                'oBE_AuditoriaD.BaseDatos = CadenaConexion.Split(";")(1).Split("=")(1)
                ''oBE_AuditoriaD.IdMenu = ""

                'oBE_AuditoriaD.IdAccion = "L"
                'oBE_AuditoriaD.NombreObjeto = "CalculaLotes"
                'oBE_AuditoriaD.Tabla = "tbLotesValorizados"
                'oBE_AuditoriaD.Condicion = " contratoLoteId='" & prmParameter(0).Value & "' and liquidacionId='0000000001'"

                'Dim lstAuditoriaD As New List(Of clsBE_AuditoriaD)
                'lstAuditoriaD.Add(oBE_AuditoriaD)
                'oDB_AuditoriaDTX.InsertarAuditoriaD(lstAuditoriaD)

            Catch ex As Exception
                lbResultado = False
            End Try
            Return lbResultado
        End Function

        


        Public Function fnCalculaMezcla() As Boolean
            Dim lbResultado As Boolean = True

            Try
                SqlHelper.ExecuteScalar(CadenaConexion, CommandType.StoredProcedure, "CalculaMezclas")
            Catch ex As Exception
                lbResultado = False
            End Try
            Return lbResultado
        End Function
        Public Function fnCalculaVinculada() As Boolean
            Dim lbResultado As Boolean = True

            Try
                SqlHelper.ExecuteScalar(CadenaConexion, CommandType.StoredProcedure, "CalculaVinculadas")
            Catch ex As Exception
                lbResultado = False
            End Try
            Return lbResultado
        End Function

        Public Function fnSelDTComposicion(ByVal psCodLote As String) As DataTable
            Dim prmParameter(0) As SqlParameter
            prmParameter(0) = New SqlParameter("@LOTEMEZCLA", SqlDbType.VarChar, 15)
            prmParameter(0).Value = psCodLote
            prmParameter(0).Direction = ParameterDirection.Input

            Try
                Dim loDataTable As New DataTable

                loDataTable = SqlHelper.ExecuteDataTable(CadenaConexion, CommandType.StoredProcedure, "MezclaComposicion_sellst", prmParameter)
                Return loDataTable
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function fnSelDTComposicionVinculada(ByVal psCodLote As String) As DataTable
            Dim prmParameter(0) As SqlParameter
            prmParameter(0) = New SqlParameter("@contratoLoteId", SqlDbType.VarChar, 20)
            prmParameter(0).Value = psCodLote
            prmParameter(0).Direction = ParameterDirection.Input

            Try
                Dim loDataTable As New DataTable

                loDataTable = SqlHelper.ExecuteDataTable(CadenaConexion, CommandType.StoredProcedure, "VinculadaComposicion_sellst", prmParameter)
                Return loDataTable
            Catch ex As Exception
                Throw ex
            End Try
        End Function



        Public Function LeerListaDSRumasVinculadas(ByVal psCodLote As String) As DataSet
            Dim prmParameter(0) As SqlParameter
            prmParameter(0) = New SqlParameter("@contratoLoteId", SqlDbType.VarChar, 20)
            prmParameter(0).Value = psCodLote
            prmParameter(0).Direction = ParameterDirection.Input

            Try
                Dim dsRumasVinculadas As New DataSet

                dsRumasVinculadas = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_RumasVinculadas_sellst", prmParameter)
                Return dsRumasVinculadas
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function fnSelDTLiquidacionAll() As DataTable
            Try
                Dim loDataTable As New DataTable

                loDataTable = SqlHelper.ExecuteDataTable(CadenaConexion, CommandType.StoredProcedure, "up_tbLotesValorizados_selAll")
                Return loDataTable
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function fnSelDTCalculoValorizado(ByVal psCodntratoLoteId As String) As DataTable
            Try
                Dim loDataTable As New DataTable
                Dim prmParameter(0) As SqlParameter
                prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(0).Value = psCodntratoLoteId
                prmParameter(0).Direction = ParameterDirection.Input

                loDataTable = SqlHelper.ExecuteDataTable(CadenaConexion, CommandType.StoredProcedure, "up_tbLotesValorizados_SelCalc", prmParameter)
                Return loDataTable
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function fnDelLiquidacion(ByVal psCodntratoLoteId As String, ByVal psLiquidacionId As String) As Boolean
            Dim lsResultado As Boolean = True

            Dim prmParameter(1) As SqlParameter
            prmParameter(0) = New SqlParameter("@contratoLoteId", SqlDbType.VarChar, 20)
            prmParameter(0).Value = psCodntratoLoteId
            prmParameter(0).Direction = ParameterDirection.Input
            prmParameter(1) = New SqlParameter("@liquidacionId", SqlDbType.VarChar, 20)
            prmParameter(1).Value = psLiquidacionId
            prmParameter(1).Direction = ParameterDirection.Input

            Try
                Dim loDataTable As New DataTable

                SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_liquidacionDel", prmParameter)

            Catch ex As Exception
                lsResultado = False
            End Try
            Return lsResultado
        End Function

        Public Function fnModificarLiquidacion(ByVal oLstLiquidacion As List(Of clsBE_Liquidacion)) As Boolean
            For Each oLiquidacion As clsBE_Liquidacion In oLstLiquidacion
                Dim prmParameter(7) As SqlParameter
                prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacion.contratoLoteId), "", oLiquidacion.contratoLoteId)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.VarChar, 20)
                prmParameter(1).Value = IIf(IsNothing(oLiquidacion.liquidacionId), "", oLiquidacion.liquidacionId)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pperiodo", SqlDbType.VarChar, 6)
                prmParameter(2).Value = IIf(IsNothing(oLiquidacion.periodo), "", oLiquidacion.periodo)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@pcodigoDocumento", SqlDbType.VarChar, 15)
                prmParameter(3).Value = IIf(IsNothing(oLiquidacion.codigoDocumento), "", oLiquidacion.codigoDocumento)
                prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@pfechaDocumento", SqlDbType.DateTime, 8)
                prmParameter(4).Value = clsUT_Funcion.FechaNull(oLiquidacion.fechaDocumento)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@pnumeroDocumento", SqlDbType.VarChar, 18)
                prmParameter(5).Value = IIf(IsNothing(oLiquidacion.numeroDocumento), 0, oLiquidacion.numeroDocumento)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@valorPP", SqlDbType.Float)
                prmParameter(6).Value = IIf(IsNothing(oLiquidacion.valorPP), 0, oLiquidacion.valorPP)
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7) = New SqlParameter("@valorPPSol", SqlDbType.Float)
                prmParameter(7).Value = IIf(IsNothing(oLiquidacion.valorPPSol), 0, oLiquidacion.valorPPSol)
                prmParameter(7).Direction = ParameterDirection.Input

                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_Liquidacion_Modificar", prmParameter)
                Catch ex As Exception
                    Throw ex
                    Return False
                End Try
            Next
            Return True
        End Function


        Public Function fnCalculaLoteUnico(ByVal sContratoLoteId As String) As Boolean
            Dim lbResultado As Boolean = True

            Try
                Dim prmParameter(0) As SqlParameter
                prmParameter(0) = New SqlParameter("@contratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(sContratoLoteId), "", sContratoLoteId)

                SqlHelper.ExecuteScalar(CadenaConexion, CommandType.StoredProcedure, "CalculaLotes_Unico", prmParameter)
            Catch ex As Exception
                lbResultado = False
            End Try
            Return lbResultado
        End Function


        Public Function ObtenerCantidadLiquidaciones(ByVal sContratoloteId As String) As Integer

            Dim sSql As String = "select COUNT(LIQUIDACIONID)cantidad from tbLiquidacion where contratoLoteId='" & sContratoloteId & "' and status!='E' and codigoCalculo in ('PRV','FIN')"

            Try

                Return SqlHelper.ExecuteScalar(CadenaConexion, CommandType.Text, sSql)
            Catch ex As Exception
                Throw ex

            End Try
            Return 0

        End Function


        

    End Class
End Namespace
