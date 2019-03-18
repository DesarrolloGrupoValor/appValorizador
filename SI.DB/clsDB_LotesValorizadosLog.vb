Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports SI.BE
Imports SI.UT
Imports Microsoft.ApplicationBlocks.Data

Namespace SI.DB

    <Serializable()> _
    Public Class clsDB_LotesValorizadosLogRO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub


        ''' <summary>
        ''' Escrito por: 
        ''' Fecha Creacion: 25/02/2013
        ''' Proposito: Obtener lotesValorizadosLog
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDStbLotesValorizadosLog(ByVal oBE_ContratoLote As clsBE_ContratoLote) As DataSet
            Dim oDStbLotesValorizadosLog As New DataSet

            Try
                Dim prmParameter(0) As SqlParameter
                prmParameter(0) = New SqlParameter("@contratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(oBE_ContratoLote.contratoLoteId), "", oBE_ContratoLote.contratoLoteId)
                prmParameter(0).Direction = ParameterDirection.Input

                'Using oDStbLotesValorizadosTMLog
                oDStbLotesValorizadosLog = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_tbLotesValorizadosLog_SelectAll", prmParameter)
                If Not oDStbLotesValorizadosLog Is Nothing Then
                    If oDStbLotesValorizadosLog.Tables.Count > 0 Then
                        If oDStbLotesValorizadosLog.Tables(0).Rows.Count > 0 Then
                            Return oDStbLotesValorizadosLog
                        End If
                    End If
                End If
                'End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDStbLotesValorizadosLog

        End Function



        Public Function LeerListaToDStbLotesValorizadosVariacion(ByVal dFechaInicio As DateTime, ByVal dFechaFin As DateTime) As DataSet
            Dim oDStbLotesValorizadosLog As New DataSet

            Try
                Dim prmParameter(1) As SqlParameter
                prmParameter(0) = New SqlParameter("@fechaInicio", SqlDbType.DateTime)
                prmParameter(0).Value = dFechaInicio
                prmParameter(0).Direction = ParameterDirection.Input

                prmParameter(1) = New SqlParameter("@fechaFin", SqlDbType.DateTime)
                prmParameter(1).Value = dFechaFin
                prmParameter(1).Direction = ParameterDirection.Input

                'Using oDStbLotesValorizadosTMLog
                oDStbLotesValorizadosLog = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_tbLotesValorizadosConVariacion_sel", prmParameter)
                If Not oDStbLotesValorizadosLog Is Nothing Then
                    If oDStbLotesValorizadosLog.Tables.Count > 0 Then
                        If oDStbLotesValorizadosLog.Tables(0).Rows.Count > 0 Then
                            Return oDStbLotesValorizadosLog
                        End If
                    End If
                End If
                'End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDStbLotesValorizadosLog

        End Function

    End Class

End Namespace

