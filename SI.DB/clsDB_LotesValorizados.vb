Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports SI.BE
Imports SI.UT
Imports Microsoft.ApplicationBlocks.Data

Namespace SI.DB

    <Serializable()> _
    Public Class clsDB_LotesValorizadosRO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub


        Public Function LeerListaToDStbLotesValorizados_valortotal_sel(ByVal oBE_LoteValorizado As clsBE_LoteValorizados) As DataSet
            Dim oDStbLotesValorizados As New DataSet

            Try
                Dim prmParameter(1) As SqlParameter
                prmParameter(0) = New SqlParameter("@contratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(oBE_LoteValorizado.contratoLoteId), "", oBE_LoteValorizado.contratoLoteId)
                prmParameter(1) = New SqlParameter("@liquidacionId", SqlDbType.VarChar, 20)
                prmParameter(1).Value = IIf(IsNothing(oBE_LoteValorizado.liquidacionId), "", oBE_LoteValorizado.liquidacionId)

                'Using oDStbLotesValorizadosTMLog
                oDStbLotesValorizados = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_tbLotesValorizados_valortotal_sel", prmParameter)
                If Not oDStbLotesValorizados Is Nothing Then
                    If oDStbLotesValorizados.Tables.Count > 0 Then
                        If oDStbLotesValorizados.Tables(0).Rows.Count > 0 Then
                            Return oDStbLotesValorizados
                        End If
                    End If
                End If
                'End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDStbLotesValorizados

        End Function

        Public Function LeerListaToDStbLotesValorizados_netoapagar_sel(ByVal oBE_LoteValorizado As clsBE_LoteValorizados) As DataSet
            Dim oDStbLotesValorizados As New DataSet

            Try
                Dim prmParameter(1) As SqlParameter
                prmParameter(0) = New SqlParameter("@contratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(oBE_LoteValorizado.contratoLoteId), "", oBE_LoteValorizado.contratoLoteId)
                prmParameter(1) = New SqlParameter("@liquidacionId", SqlDbType.VarChar, 20)
                prmParameter(1).Value = IIf(IsNothing(oBE_LoteValorizado.liquidacionId), "", oBE_LoteValorizado.liquidacionId)

                'Using oDStbLotesValorizadosTMLog
                oDStbLotesValorizados = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_tbLotesValorizados_netoapagar_sel", prmParameter)
                If Not oDStbLotesValorizados Is Nothing Then
                    If oDStbLotesValorizados.Tables.Count > 0 Then
                        If oDStbLotesValorizados.Tables(0).Rows.Count > 0 Then
                            Return oDStbLotesValorizados
                        End If
                    End If
                End If
                'End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDStbLotesValorizados

        End Function


        Public Function LeerListaToDStbLotesValorizados_sel(ByVal oBE_LoteValorizado As clsBE_LoteValorizados) As DataSet
            Dim oDStbLotesValorizados As New DataSet

            Try
                Dim prmParameter(1) As SqlParameter
                prmParameter(0) = New SqlParameter("@contratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(oBE_LoteValorizado.contratoLoteId), "", oBE_LoteValorizado.contratoLoteId)
                prmParameter(1) = New SqlParameter("@liquidacionId", SqlDbType.VarChar, 20)
                prmParameter(1).Value = IIf(IsNothing(oBE_LoteValorizado.liquidacionId), "", oBE_LoteValorizado.liquidacionId)

                'Using oDStbLotesValorizadosTMLog
                oDStbLotesValorizados = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_tbLotesValorizados_sel", prmParameter)
                If Not oDStbLotesValorizados Is Nothing Then
                    If oDStbLotesValorizados.Tables.Count > 0 Then
                        If oDStbLotesValorizados.Tables(0).Rows.Count > 0 Then
                            Return oDStbLotesValorizados
                        End If
                    End If
                End If
                'End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDStbLotesValorizados

        End Function
    End Class

End Namespace

