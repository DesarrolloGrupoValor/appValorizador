Imports Microsoft.ApplicationBlocks.Data
Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports SI.BE
Imports SI.UT
Namespace SI.DB
    Public Class clsDB_GenerarQPRO

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub

        Public Function fnCalcular_QPs(ByVal sPeriodo As String) As DataSet
            Dim lbResultado As Boolean = True

            Try
                Dim prmParameter(0) As SqlParameter

                prmParameter(0) = New SqlParameter("@periodo", SqlDbType.VarChar, 6)
                prmParameter(0).Value = IIf(IsNothing(sPeriodo), "", sPeriodo)

                Return SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_calcular_qps", prmParameter)

            Catch ex As Exception
                lbResultado = False
            End Try
            Return Nothing
        End Function

        'Public Function fnCalcular_QPs_Detalle(ByVal sPeriodo As String) As DataSet
        '    Dim lbResultado As Boolean = True

        '    Try
        '        Dim prmParameter(0) As SqlParameter

        '        prmParameter(0) = New SqlParameter("@periodo", SqlDbType.VarChar, 6)
        '        prmParameter(0).Value = IIf(IsNothing(sPeriodo), "", sPeriodo)

        '        Return SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_calcular_qps_detalle", prmParameter)

        '    Catch ex As Exception
        '        lbResultado = False
        '    End Try
        '    Return Nothing
        'End Function


        Public Function fnGenerarQP_SellAll(ByVal sPeriodo As String) As DataSet
            Dim lbResultado As Boolean = True

            Try
                Dim prmParameter(0) As SqlParameter
                prmParameter(0) = New SqlParameter("@periodo", SqlDbType.VarChar, 6)
                prmParameter(0).Value = IIf(IsNothing(sPeriodo), "", sPeriodo)

                Return SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "ups_GenerarQP_SellAll", prmParameter)

            Catch ex As Exception
                lbResultado = False
            End Try
            Return Nothing
        End Function


        Public Function fnGenerarQP_Detalle_Sell(ByVal sPeriodo As String, ByVal sVinculada As String) As DataSet
            Dim lbResultado As Boolean = True

            Try
                Dim prmParameter(1) As SqlParameter
                prmParameter(0) = New SqlParameter("@periodo", SqlDbType.VarChar, 6)
                prmParameter(0).Value = IIf(IsNothing(sPeriodo), "", sPeriodo)

                prmParameter(1) = New SqlParameter("@vinculada", SqlDbType.VarChar, 5)
                prmParameter(1).Value = IIf(IsNothing(sVinculada), "", sVinculada)

                Return SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "ups_GenerarQP_Detalle_Sell", prmParameter)

            Catch ex As Exception
                lbResultado = False
            End Try
            Return Nothing
        End Function




    End Class



    Public Class clsDB_GenerarQPTX

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub

        Public Function fnCalcular_QPs(ByVal sPeriodo As String) As Boolean
            Dim lbResultado As Boolean = True

            Try
                Dim prmParameter(0) As SqlParameter

                prmParameter(0) = New SqlParameter("@periodo", SqlDbType.VarChar, 6)
                prmParameter(0).Value = IIf(IsNothing(sPeriodo), "", sPeriodo)

                'Inicio CJ0112 Se modificó forma de invocar al SP.
                Dim cnx As New SqlConnection(CadenaConexion)
                Dim cmd As New SqlCommand()
                Dim da As New SqlDataAdapter()

                cmd.Connection = cnx
                cmd.CommandText = "up_calcular_qps"
                cmd.Parameters.Add("@PERIODO", sPeriodo)
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandTimeout = 300

                cmd.Connection.Open()
                cmd.ExecuteNonQuery()
                ' Fin CJ0112

                'SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_calcular_qps", prmParameter)

            Catch ex As Exception
                Return False
            End Try
            Return True
        End Function

        'Public Function InsertarGenerarQP(ByVal sPeriodo As String) As Boolean

        '    Dim prmParameter(0) As SqlParameter
        '    prmParameter(0) = New SqlParameter("@periodo", SqlDbType.VarChar, 6)
        '    prmParameter(0).Value = IIf(IsNothing(sPeriodo), "", sPeriodo)

        '    Try
        '        SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_GenerarQP_ins", prmParameter)
        '    Catch ex As Exception
        '        Throw ex
        '        Return False
        '    End Try

        '    Return True
        'End Function

    End Class

End Namespace
