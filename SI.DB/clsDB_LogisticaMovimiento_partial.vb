'@Modified:
'@01 20141010 BAL01 Validacion de liquidacion para rumas componentes de Despacho - Blend
'@02 20141117 BAL01 Validacion de asociacion; no se permite asociar ruma cuyo TMH disponible se haya excedido.

Imports SI.BE
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Namespace SI.DB
    Partial Public Class clsDB_LogisticaMovimientoTX


        Public Property oBE_AuditoriaD As clsBE_AuditoriaD

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 25/02/2011 10:15:55
        ''' Proposito: Metodo de Insercci?n de Datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function ActualizaEstadoLogisticaMovimiento(ByVal oLstLogisticaMovimiento As List(Of clsBE_LogisticaMovimiento), ByVal oBE_AuditoriaD As clsBE_AuditoriaD) As Boolean
            For Each oLogisticaMovimiento As clsBE_LogisticaMovimiento In oLstLogisticaMovimiento
                Dim prmParameter(4) As SqlParameter

                prmParameter(0) = New SqlParameter("@pID", SqlDbType.Float, 8)
                prmParameter(0).Value = IIf(IsNothing(oLogisticaMovimiento.ID), 0, oLogisticaMovimiento.ID)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pEstadoVCM", SqlDbType.VarChar, 1)
                prmParameter(1).Value = IIf(IsNothing(oLogisticaMovimiento.EstadoVCM), "", oLogisticaMovimiento.EstadoVCM)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pContratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(2).Value = IIf(IsNothing(oLogisticaMovimiento.ContratoLoteId), "", oLogisticaMovimiento.ContratoLoteId)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@pliquidacionId", SqlDbType.VarChar, 20)
                prmParameter(3).Value = IIf(IsNothing(oLogisticaMovimiento.LiquidacionId), "", oLogisticaMovimiento.LiquidacionId)
                prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@pliquidaciontmId", SqlDbType.VarChar, 20)
                prmParameter(4).Value = IIf(IsNothing(oLogisticaMovimiento.LiquidacionTmId), "", oLogisticaMovimiento.LiquidacionTmId)
                prmParameter(4).Direction = ParameterDirection.Input
                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LogisticaMovimiento_Upd_VCM", prmParameter)



                    ' ''Auditoria
                    ''Dim oDB_AuditoriaDTX As New clsDB_AuditoriaDTX
                    ' ''Dim oBE_AuditoriaD As New clsBE_AuditoriaD

                    ' ''oBE_AuditoriaD.IdAuditoria = 1


                    ''oBE_AuditoriaD.CadenaConexion = CadenaConexion
                    ''oBE_AuditoriaD.BaseDatos = CadenaConexion.Split(";")(1).Split("=")(1)
                    ' ''oBE_AuditoriaD.IdMenu = ""

                    ''oBE_AuditoriaD.IdAccion = "L"
                    ''oBE_AuditoriaD.NombreObjeto = "up_LogisticaMovimiento_Upd_VCM"
                    ''oBE_AuditoriaD.Tabla = "tbLogisticaMovimiento"
                    ''oBE_AuditoriaD.Condicion = " contratoLoteId='" & prmParameter(2).Value & "' and ID=" & prmParameter(0).Value

                    ' ''oBE_AuditoriaD.Condicion = " contratoLoteId='" & prmParameter(2).Value & "' " & _
                    ' ''                            " and liquidacionId='" & prmParameter(3).Value & "'" & _
                    ' ''                            " and liquidaciontmId='" & prmParameter(4).Value & "'"

                    ''Dim lstAuditoriaD As New List(Of clsBE_AuditoriaD)
                    ''lstAuditoriaD.Add(oBE_AuditoriaD)
                    ''oDB_AuditoriaDTX.InsertarAuditoriaD(lstAuditoriaD)


                Catch ex As Exception
                    Throw ex
                    Return False
                End Try
            Next
            Return True
        End Function
        Public Function ActualizaEstadoLogisticaDesasociar(ByVal piId As Long, ByVal oBE_AuditoriaD As clsBE_AuditoriaD) As Boolean

            Dim prmParameter(0) As SqlParameter

            prmParameter(0) = New SqlParameter("@pID", SqlDbType.BigInt, 8)
            prmParameter(0).Value = piId
            prmParameter(0).Direction = ParameterDirection.Input


            Try
                SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LogisticaMovimiento_Upd_VCM_Desasociar", prmParameter)



                ' ''Auditoria
                ''Dim oDB_AuditoriaDTX As New clsDB_AuditoriaDTX

                ''oBE_AuditoriaD.CadenaConexion = CadenaConexion
                ''oBE_AuditoriaD.BaseDatos = CadenaConexion.Split(";")(1).Split("=")(1)
                ' ''oBE_AuditoriaD.IdMenu = ""

                ''oBE_AuditoriaD.IdAccion = "L"
                ''oBE_AuditoriaD.NombreObjeto = "up_LogisticaMovimiento_Upd_VCM_Desasociar"
                ''oBE_AuditoriaD.Tabla = "tbLogisticaMovimiento"
                ''oBE_AuditoriaD.Condicion = " ID=" & prmParameter(0).Value


                ''Dim lstAuditoriaD As New List(Of clsBE_AuditoriaD)
                ''lstAuditoriaD.Add(oBE_AuditoriaD)
                ''oDB_AuditoriaDTX.InsertarAuditoriaD(lstAuditoriaD)

            Catch ex As Exception
                'Throw ex
                Return False
            End Try

            Return True
        End Function

        Public Function ActualizaEstadoBtnOK(ByVal psContratoLoteId As String, ByVal psLiquidacionId As String, ByVal oBE_AuditoriaD As clsBE_AuditoriaD) As Boolean

            Dim prmParameter(1) As SqlParameter

            prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.VarChar, 20)
            prmParameter(0).Value = psContratoLoteId
            prmParameter(0).Direction = ParameterDirection.Input
            prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.VarChar, 20)
            prmParameter(1).Value = psLiquidacionId
            prmParameter(1).Direction = ParameterDirection.Input


            Try
                SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LogisticaMovimientoCambioEstadoOk", prmParameter)



                ' ''Auditoria
                ''Dim oDB_AuditoriaDTX As New clsDB_AuditoriaDTX
                ' ''Dim oBE_AuditoriaD As New clsBE_AuditoriaD

                ' ''oBE_AuditoriaD.IdAuditoria = 1


                ''oBE_AuditoriaD.CadenaConexion = CadenaConexion
                ''oBE_AuditoriaD.BaseDatos = CadenaConexion.Split(";")(1).Split("=")(1)
                ' ''oBE_AuditoriaD.IdMenu = ""

                ''oBE_AuditoriaD.IdAccion = "L"
                ''oBE_AuditoriaD.NombreObjeto = "up_LogisticaMovimientoCambioEstadoOk"
                ''oBE_AuditoriaD.Tabla = "tbLogisticaMovimiento"
                ''oBE_AuditoriaD.Condicion = " contratoLoteId='" & prmParameter(0).Value & "'" ' and liquidacionId=" & prmParameter(1).Value

                ' ''oBE_AuditoriaD.Condicion = " contratoLoteId='" & prmParameter(2).Value & "' " & _
                ' ''                            " and liquidacionId='" & prmParameter(3).Value & "'" & _
                ' ''                            " and liquidaciontmId='" & prmParameter(4).Value & "'"

                ''Dim lstAuditoriaD As New List(Of clsBE_AuditoriaD)
                ''lstAuditoriaD.Add(oBE_AuditoriaD)
                ''oDB_AuditoriaDTX.InsertarAuditoriaD(lstAuditoriaD)

            Catch ex As Exception
                'Throw ex.Message
                Return False
            End Try

            Return True
        End Function
        Public Function ActualizaEstadoBtnCancelar(ByVal psContratoLoteId As String, ByVal psLiquidacionId As String) As Boolean

            Dim prmParameter(1) As SqlParameter

            prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.VarChar, 20)
            prmParameter(0).Value = psContratoLoteId
            prmParameter(0).Direction = ParameterDirection.Input
            prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.VarChar, 20)
            prmParameter(1).Value = psLiquidacionId
            prmParameter(1).Direction = ParameterDirection.Input


            Try
                SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LogisticaMovimientoCambioEstadoCancelar", prmParameter)
            Catch ex As Exception
                'Throw ex
                Return False
            End Try

            Return True
        End Function

        '@01    AINI
        Public Function validarLiquidacionRumasComponentes(ByVal loteOrigen As String) As DataTable
            Dim tRumaNoLiquidada As New DataTable
            Dim mintItem As Integer = 0
            Dim prmParameter(0) As SqlParameter

            prmParameter(0) = New SqlParameter("@LOTE_ORIGEN", SqlDbType.VarChar, 20)
            prmParameter(0).Value = loteOrigen
            prmParameter(0).Direction = ParameterDirection.Input
            Try

                Using tRumaNoLiquidada
                    tRumaNoLiquidada = SqlHelper.ExecuteDataTable(CadenaConexion, CommandType.StoredProcedure, "up_validaLiquidacionRumasComponentes", prmParameter)
                    If Not tRumaNoLiquidada Is Nothing Then
                        If Not tRumaNoLiquidada.Rows.Count > 0 Then
                            tRumaNoLiquidada = Nothing
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex
            End Try
            Return tRumaNoLiquidada
        End Function
        '@01    AFIN

        '@02    AINI
        Public Function validarDisponibilidadAsociacion(ByVal lote As String) As Boolean
            Dim validacion As Boolean
            Dim mintItem As Integer = 0
            Dim prmParameter(0) As SqlParameter

            prmParameter(0) = New SqlParameter("@COD_LOTE", SqlDbType.VarChar, 20)
            prmParameter(0).Value = lote
            prmParameter(0).Direction = ParameterDirection.Input
            Try
                Using Reader As SqlDataReader = SqlHelper.ExecuteReader(CadenaConexion, CommandType.StoredProcedure, "up_ValidaDisponibilidadAsociacion", prmParameter)
                    If Reader.HasRows Then
                        Reader.Read()
                        validacion = IIf(CInt(Reader("result")) = 1, True, False)
                    End If
                End Using
            Catch ex As Exception
                Throw ex
                validacion = False
            End Try
            Return validacion
        End Function
        '@02    AFIN
    End Class

End Namespace
