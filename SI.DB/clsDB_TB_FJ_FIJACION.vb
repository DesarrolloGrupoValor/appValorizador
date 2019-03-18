Imports SI.BE
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Imports SI.UT

Namespace SI.DB

    Partial Public Class clsDB_TB_FJ_FIJACIONTX

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionEN")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("EN")
        End Sub

        Public Function TB_FJ_FIJACION_INSERT(ByVal oBE_TB_FJ_FIJACION As List(Of clsBE_TB_FJ_FIJACION)) As Boolean
            For Each oTB_FJ_FIJACION As clsBE_TB_FJ_FIJACION In oBE_TB_FJ_FIJACION
                Dim prmParameter(5) As SqlParameter

                prmParameter(0) = New SqlParameter("@elemento", SqlDbType.VarChar, 3)
                prmParameter(0).Value = IIf(IsNothing(oTB_FJ_FIJACION.ELEMENTO), "", oTB_FJ_FIJACION.ELEMENTO)
                prmParameter(0).Direction = ParameterDirection.Input

                prmParameter(1) = New SqlParameter("@contratoloteid", SqlDbType.VarChar, 20)
                prmParameter(1).Value = IIf(IsNothing(oTB_FJ_FIJACION.CONTRATOLOTEID), "", oTB_FJ_FIJACION.CONTRATOLOTEID)
                prmParameter(1).Direction = ParameterDirection.Input

                prmParameter(2) = New SqlParameter("@liquidacionid", SqlDbType.VarChar, 20)
                prmParameter(2).Value = IIf(IsNothing(oTB_FJ_FIJACION.LIQUIDACIONID), "", oTB_FJ_FIJACION.LIQUIDACIONID)
                prmParameter(2).Direction = ParameterDirection.Input

                prmParameter(3) = New SqlParameter("@cantidad", SqlDbType.Decimal)
                prmParameter(3).Value = IIf(IsNothing(oTB_FJ_FIJACION.CANTIDAD), 0, oTB_FJ_FIJACION.CANTIDAD)
                prmParameter(3).Direction = ParameterDirection.Input

                prmParameter(4) = New SqlParameter("@precio", SqlDbType.Decimal)
                prmParameter(4).Value = IIf(IsNothing(oTB_FJ_FIJACION.PRECIO), 0, oTB_FJ_FIJACION.PRECIO)
                prmParameter(4).Direction = ParameterDirection.Input

                prmParameter(5) = New SqlParameter("@OPERADOR", SqlDbType.VarChar, 20)
                prmParameter(5).Value = IIf(IsNothing(oTB_FJ_FIJACION.OPERADOR), "", oTB_FJ_FIJACION.OPERADOR)
                prmParameter(5).Direction = ParameterDirection.Input


                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "UP_FJ_FIJACION_INS", prmParameter)

                Catch ex As Exception
                    Throw ex
                    Return False
                End Try
            Next
            Return True
        End Function





        Public Function TB_FJ_FIJACION_UPDATE(ByVal oBE_TB_FJ_FIJACION As List(Of clsBE_TB_FJ_FIJACION)) As Boolean
            For Each oTB_FJ_FIJACION As clsBE_TB_FJ_FIJACION In oBE_TB_FJ_FIJACION
                Dim prmParameter(3) As SqlParameter

                ''prmParameter(0) = New SqlParameter("@ITEM", SqlDbType.Int)
                ''prmParameter(1) = New SqlParameter("@SEC", SqlDbType.Int)
                ''prmParameter(2) = New SqlParameter("@DESCRIPCION", SqlDbType.VarChar, 200)
                ''prmParameter(3) = New SqlParameter("@FECHA_CARTA", SqlDbType.DateTime)

                ''prmParameter(0).Value = IIf(IsNothing(oTB_FJ_FIJACION.ITEM), 0, oTB_FJ_FIJACION.ITEM)
                ''prmParameter(1).Value = IIf(IsNothing(oTB_FJ_FIJACION.SEC), 0, oTB_FJ_FIJACION.SEC)
                ''prmParameter(2).Value = IIf(IsNothing(oTB_FJ_FIJACION.DESCRIPCION), "", oTB_FJ_FIJACION.DESCRIPCION)
                ''prmParameter(3).Value = IIf(IsNothing(oTB_FJ_FIJACION.FECHA_CARTA), "01/01/1900", oTB_FJ_FIJACION.FECHA_CARTA)

                ''prmParameter(0).Direction = ParameterDirection.Input
                ''prmParameter(1).Direction = ParameterDirection.Input
                ''prmParameter(2).Direction = ParameterDirection.Input
                ''prmParameter(3).Direction = ParameterDirection.Input

                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "UPS_TB_FJ_FIJACION_UPD", prmParameter)

                Catch ex As Exception
                    Throw ex
                    Return False
                End Try
            Next
            Return True
        End Function
    End Class

    Partial Public Class clsDB_TB_FJ_FIJACIONRO

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionEN")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("EN")
        End Sub

      
        Public Function LeerListaToDSTB_FJ_FIJACION_Sel_Prov(ByVal pTB_FJ_FIJACION As clsBE_TB_FJ_FIJACION) As DataSet
            Dim oDSTB_FJ_FIJACION As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(3) As SqlParameter

            prmParameter(0) = New SqlParameter("@PROVEEDOR", SqlDbType.VarChar, 18)
            prmParameter(0).Value = IIf(IsNothing(pTB_FJ_FIJACION.PROVEEDOR), "", pTB_FJ_FIJACION.PROVEEDOR)

            prmParameter(1) = New SqlParameter("@ELEMENTO", SqlDbType.VarChar, 3)
            prmParameter(1).Value = IIf(IsNothing(pTB_FJ_FIJACION.ELEMENTO), "", pTB_FJ_FIJACION.ELEMENTO)

            prmParameter(2) = New SqlParameter("@ESTADO", SqlDbType.Char, 1)
            prmParameter(2).Value = IIf(IsNothing(pTB_FJ_FIJACION.ESTADO), "", pTB_FJ_FIJACION.ESTADO)

            prmParameter(3) = New SqlParameter("@contratoloteId", SqlDbType.VarChar, 10)
            prmParameter(3).Value = IIf(IsNothing(pTB_FJ_FIJACION.CONTRATOLOTEID), "", pTB_FJ_FIJACION.CONTRATOLOTEID)

            Try

                Using oDSTB_FJ_FIJACION
                    oDSTB_FJ_FIJACION = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "upFJ_FIJACION_Sel_Prov", prmParameter)

                    If Not oDSTB_FJ_FIJACION Is Nothing Then
                        If oDSTB_FJ_FIJACION.Tables.Count > 0 Then
                            If oDSTB_FJ_FIJACION.Tables(0).Rows.Count > 0 Then
                                Return oDSTB_FJ_FIJACION
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSTB_FJ_FIJACION

        End Function

        Public Function LeerListaToDSTB_FJ_FIJACION_Sel(ByVal pTB_FJ_FIJACION As clsBE_TB_FJ_FIJACION) As DataSet
            Dim oDSTB_FJ_FIJACION As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(3) As SqlParameter

            prmParameter(0) = New SqlParameter("@PROVEEDOR", SqlDbType.VarChar, 18)
            prmParameter(0).Value = IIf(IsNothing(pTB_FJ_FIJACION.PROVEEDOR), "", pTB_FJ_FIJACION.PROVEEDOR)

            prmParameter(1) = New SqlParameter("@ELEMENTO", SqlDbType.VarChar, 3)
            prmParameter(1).Value = IIf(IsNothing(pTB_FJ_FIJACION.ELEMENTO), "", pTB_FJ_FIJACION.ELEMENTO)

            prmParameter(2) = New SqlParameter("@ESTADO", SqlDbType.Char, 1)
            prmParameter(2).Value = IIf(IsNothing(pTB_FJ_FIJACION.ESTADO), "", pTB_FJ_FIJACION.ESTADO)

            prmParameter(3) = New SqlParameter("@contratoloteId", SqlDbType.VarChar, 10)
            prmParameter(3).Value = IIf(IsNothing(pTB_FJ_FIJACION.CONTRATOLOTEID), "", pTB_FJ_FIJACION.CONTRATOLOTEID)

            Try

                Using oDSTB_FJ_FIJACION
                    oDSTB_FJ_FIJACION = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "upFJ_FIJACION_Sel_Prov2", prmParameter)

                    If Not oDSTB_FJ_FIJACION Is Nothing Then
                        If oDSTB_FJ_FIJACION.Tables.Count > 0 Then
                            If oDSTB_FJ_FIJACION.Tables(0).Rows.Count > 0 Then
                                Return oDSTB_FJ_FIJACION
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSTB_FJ_FIJACION

        End Function


        Public Function Leer_FJ_AJUSTE_ESCALA(ByVal pTB_FJ_FIJACION As clsBE_TB_FJ_FIJACION) As Decimal

            Dim prmParameter(0) As SqlParameter

            prmParameter(0) = New SqlParameter("@Contenido", SqlDbType.Decimal)
            prmParameter(0).Value = IIf(IsNothing(pTB_FJ_FIJACION.CANTIDAD), 0, pTB_FJ_FIJACION.CANTIDAD)

            Try
                Return SqlHelper.ExecuteScalar(CadenaConexion, CommandType.StoredProcedure, "UP_FJ_AJUSTE_ESCALA", prmParameter)

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Function LeerListaToDSTB_FJ_FIJACION_Sel_Prov2(oBETB_FJ_FIJACION As clsBE_TB_FJ_FIJACION) As DataSet
            Throw New NotImplementedException
        End Function

    End Class
End Namespace
