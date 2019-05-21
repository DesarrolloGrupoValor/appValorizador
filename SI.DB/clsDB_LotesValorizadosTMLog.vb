Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports SI.BE
Imports SI.UT
Imports Microsoft.ApplicationBlocks.Data

Namespace SI.DB

    <Serializable()> _
    Public Class clsDB_LotesValorizadosLogTMRO
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
        Public Function LeerListaToDStbLotesValorizadosTMLog(ByVal sContratoLoteId As String, ByVal sLiquidacion As String, ByVal nLotesValorizadosLogID As Integer) As DataSet
            Dim oDStbLotesValorizadosTMLog As New DataSet

            Try
                Dim prmParameter(2) As SqlParameter

                prmParameter(0) = New SqlParameter("@contratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(0).Value = sContratoLoteId
                prmParameter(0).Direction = ParameterDirection.Input

                prmParameter(1) = New SqlParameter("@liquidacionId", SqlDbType.VarChar, 20)
                prmParameter(1).Value = sLiquidacion
                prmParameter(1).Direction = ParameterDirection.Input

                prmParameter(2) = New SqlParameter("@LotesValorizadosLogID", SqlDbType.Int)
                prmParameter(2).Value = nLotesValorizadosLogID
                prmParameter(2).Direction = ParameterDirection.Input

                'Using oDStbLotesValorizadosTMLog
                oDStbLotesValorizadosTMLog = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_tbLotesValorizadosTMLog_SelectALL", prmParameter)
                If Not oDStbLotesValorizadosTMLog Is Nothing Then
                    If oDStbLotesValorizadosTMLog.Tables.Count > 0 Then
                        If oDStbLotesValorizadosTMLog.Tables(0).Rows.Count > 0 Then
                            Return oDStbLotesValorizadosTMLog
                        End If
                    End If
                End If
                'End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDStbLotesValorizadosTMLog

        End Function





    End Class

End Namespace

