


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
    ''' Fecha Creacion: 17/02/2011 16:40:01
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla Liquidacion
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsDB_LiquidacionEstadoDetalleTX

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub

        Public Function InsertaLiquidacionEstado(ByVal oBE_LiquidacionEstadoDetalle As clsBE_LiquidacionEstadoDetalle) As Boolean

            Dim prmParameter(9) As SqlParameter

            prmParameter(0) = New SqlParameter("@liquidacionEstadoId", SqlDbType.Int)
            prmParameter(0).Value = IIf(IsNothing(oBE_LiquidacionEstadoDetalle.liquidacionEstadoId), 0, oBE_LiquidacionEstadoDetalle.liquidacionEstadoId)
            prmParameter(0).Direction = ParameterDirection.Input

            prmParameter(1) = New SqlParameter("@contratoLoteId", SqlDbType.VarChar, 20)
            prmParameter(1).Value = IIf(IsNothing(oBE_LiquidacionEstadoDetalle.contratoLoteId), "", oBE_LiquidacionEstadoDetalle.contratoLoteId)
            prmParameter(1).Direction = ParameterDirection.Input

            prmParameter(2) = New SqlParameter("@liquidacionId", SqlDbType.VarChar, 20)
            prmParameter(2).Value = IIf(IsNothing(oBE_LiquidacionEstadoDetalle.liquidacionId), "", oBE_LiquidacionEstadoDetalle.liquidacionId)
            prmParameter(2).Direction = ParameterDirection.Input

            prmParameter(3) = New SqlParameter("@usuarioId", SqlDbType.VarChar, 20)
            prmParameter(3).Value = IIf(IsNothing(oBE_LiquidacionEstadoDetalle.usuarioId), "", oBE_LiquidacionEstadoDetalle.usuarioId)
            prmParameter(3).Direction = ParameterDirection.Input

            prmParameter(4) = New SqlParameter("@estadoId", SqlDbType.VarChar, 20)
            prmParameter(4).Value = IIf(IsNothing(oBE_LiquidacionEstadoDetalle.estadoId), "", oBE_LiquidacionEstadoDetalle.estadoId)
            prmParameter(4).Direction = ParameterDirection.Input

            prmParameter(5) = New SqlParameter("@liquidacionEstadoDetalleOrigenId", SqlDbType.Int)
            prmParameter(5).Value = IIf(IsNothing(oBE_LiquidacionEstadoDetalle.liquidacionEstadoDetalleOrigenId), 0, oBE_LiquidacionEstadoDetalle.liquidacionEstadoDetalleOrigenId)
            prmParameter(5).Direction = ParameterDirection.Input

            prmParameter(6) = New SqlParameter("@observaciones", SqlDbType.VarChar, 200)
            prmParameter(6).Value = IIf(IsNothing(oBE_LiquidacionEstadoDetalle.observaciones), "", oBE_LiquidacionEstadoDetalle.observaciones)
            prmParameter(6).Direction = ParameterDirection.Input


            prmParameter(7) = New SqlParameter("@NRO_OP", SqlDbType.VarChar, 10)
            prmParameter(7).Value = IIf(IsNothing(oBE_LiquidacionEstadoDetalle.NRO_OP), "", oBE_LiquidacionEstadoDetalle.NRO_OP)
            prmParameter(7).Direction = ParameterDirection.Input

            prmParameter(8) = New SqlParameter("@TIPO_OP", SqlDbType.VarChar, 10)
            prmParameter(8).Value = IIf(IsNothing(oBE_LiquidacionEstadoDetalle.TIPO_OP), "", oBE_LiquidacionEstadoDetalle.TIPO_OP)
            prmParameter(8).Direction = ParameterDirection.Input

            prmParameter(9) = New SqlParameter("@liquidacionEstadoDetalleId", SqlDbType.Int)
            prmParameter(9).Direction = ParameterDirection.Output

            Try
                SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "upLiquidacionEstadoDetalle_Ins", prmParameter)
                oBE_LiquidacionEstadoDetalle.liquidacionEstadoDetalleId = prmParameter(9).Value
            Catch ex As Exception
                Throw ex
                Return False
            End Try

            Return True
        End Function


        Public Function InsertaLiquidacionEstadoVenta(ByVal oBE_LiquidacionEstadoDetalle As clsBE_LiquidacionEstadoDetalle) As Boolean

            Dim prmParameter(7) As SqlParameter

            prmParameter(0) = New SqlParameter("@liquidacionEstadoId", SqlDbType.Int)
            prmParameter(0).Value = IIf(IsNothing(oBE_LiquidacionEstadoDetalle.liquidacionEstadoId), 0, oBE_LiquidacionEstadoDetalle.liquidacionEstadoId)
            prmParameter(0).Direction = ParameterDirection.Input

            prmParameter(1) = New SqlParameter("@contratoLoteId", SqlDbType.VarChar, 20)
            prmParameter(1).Value = IIf(IsNothing(oBE_LiquidacionEstadoDetalle.contratoLoteId), "", oBE_LiquidacionEstadoDetalle.contratoLoteId)
            prmParameter(1).Direction = ParameterDirection.Input

            prmParameter(2) = New SqlParameter("@liquidacionId", SqlDbType.VarChar, 20)
            prmParameter(2).Value = IIf(IsNothing(oBE_LiquidacionEstadoDetalle.liquidacionId), "", oBE_LiquidacionEstadoDetalle.liquidacionId)
            prmParameter(2).Direction = ParameterDirection.Input

            prmParameter(3) = New SqlParameter("@usuarioId", SqlDbType.VarChar, 20)
            prmParameter(3).Value = IIf(IsNothing(oBE_LiquidacionEstadoDetalle.usuarioId), "", oBE_LiquidacionEstadoDetalle.usuarioId)
            prmParameter(3).Direction = ParameterDirection.Input

            prmParameter(4) = New SqlParameter("@estadoId", SqlDbType.VarChar, 20)
            prmParameter(4).Value = IIf(IsNothing(oBE_LiquidacionEstadoDetalle.estadoId), "", oBE_LiquidacionEstadoDetalle.estadoId)
            prmParameter(4).Direction = ParameterDirection.Input

            prmParameter(5) = New SqlParameter("@liquidacionEstadoDetalleOrigenId", SqlDbType.Int)
            prmParameter(5).Value = IIf(IsNothing(oBE_LiquidacionEstadoDetalle.liquidacionEstadoDetalleOrigenId), 0, oBE_LiquidacionEstadoDetalle.liquidacionEstadoDetalleOrigenId)
            prmParameter(5).Direction = ParameterDirection.Input

            prmParameter(6) = New SqlParameter("@observaciones", SqlDbType.VarChar, 200)
            prmParameter(6).Value = IIf(IsNothing(oBE_LiquidacionEstadoDetalle.observaciones), "", oBE_LiquidacionEstadoDetalle.observaciones)
            prmParameter(6).Direction = ParameterDirection.Input

            prmParameter(7) = New SqlParameter("@liquidacionEstadoDetalleId", SqlDbType.Int)
            prmParameter(7).Direction = ParameterDirection.Output

            Try
                SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionEstadoDetalle_Ins_Venta", prmParameter)
                oBE_LiquidacionEstadoDetalle.liquidacionEstadoDetalleId = prmParameter(7).Value
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
    ''' Fecha Creacion: 17/02/2011 16:40:01
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla Liquidacion
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsDB_LiquidacionEstadoDetalleRO

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub


        Public Function LeerListaToDSLiquidacionEstadoDetalle(ByVal oBE_LiquidacionEstado As clsBE_LiquidacionEstado) As DataSet
            Dim dsLiquidacionEstadoDetalle As New DataSet

            Dim prmParameter(0) As SqlParameter
            prmParameter(0) = New SqlParameter("@contratoLoteId", SqlDbType.VarChar, 20)
            prmParameter(0).Value = IIf(IsNothing(oBE_LiquidacionEstado.contratoLoteId), "", oBE_LiquidacionEstado.contratoLoteId)

            Try
                Using dsLiquidacionEstadoDetalle
                    dsLiquidacionEstadoDetalle = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "upLiquidacionEstadoDetalle_Val_Generacion", prmParameter)
                    If Not dsLiquidacionEstadoDetalle Is Nothing Then
                        If dsLiquidacionEstadoDetalle.Tables.Count > 0 Then
                            If dsLiquidacionEstadoDetalle.Tables(0).Rows.Count > 0 Then
                                Return dsLiquidacionEstadoDetalle
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return dsLiquidacionEstadoDetalle

        End Function

        Public Function LeerLiquidacionEstadoDetalleDS_Sel(ByVal oLiquidacionEstadoDetalle As clsBE_LiquidacionEstadoDetalle) As DataSet
            Dim oDSLiquidacionEstadoDetalle As New DataSet

            Try
                Dim prmParameter(1) As SqlParameter
                prmParameter(0) = New SqlParameter("@liquidacionEstadoId", SqlDbType.Int)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacionEstadoDetalle.liquidacionEstadoId), 0, oLiquidacionEstadoDetalle.liquidacionEstadoId)

                prmParameter(1) = New SqlParameter("@NRO_OP", SqlDbType.VarChar, 10)
                prmParameter(1).Value = ""

                Using oDSLiquidacionEstadoDetalle
                    oDSLiquidacionEstadoDetalle = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "upLiquidacionEstadoDetalle_Sel", prmParameter)
                    If Not oDSLiquidacionEstadoDetalle Is Nothing Then
                        If oDSLiquidacionEstadoDetalle.Tables.Count > 0 Then
                            If oDSLiquidacionEstadoDetalle.Tables(0).Rows.Count > 0 Then
                                Return oDSLiquidacionEstadoDetalle
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSLiquidacionEstadoDetalle

        End Function


        Public Function LeerLiquidacionEstadoDetalleDS_Sel_Adelanto(ByVal oLiquidacionEstadoDetalle As clsBE_LiquidacionEstadoDetalle) As DataSet
            Dim oDSLiquidacionEstadoDetalle As New DataSet

            Try
                Dim prmParameter(2) As SqlParameter
                prmParameter(0) = New SqlParameter("@contratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacionEstadoDetalle.contratoLoteId), "", oLiquidacionEstadoDetalle.contratoLoteId)
                prmParameter(1) = New SqlParameter("@liquidacionId", SqlDbType.VarChar, 20)
                prmParameter(1).Value = IIf(IsNothing(oLiquidacionEstadoDetalle.liquidacionId), "", oLiquidacionEstadoDetalle.liquidacionId)
                prmParameter(2) = New SqlParameter("@estadoId", SqlDbType.VarChar, 5)
                prmParameter(2).Value = IIf(IsNothing(oLiquidacionEstadoDetalle.estadoId), "", oLiquidacionEstadoDetalle.estadoId)


                Using oDSLiquidacionEstadoDetalle
                    oDSLiquidacionEstadoDetalle = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "upTBLiquidacionEstadoDetalle_Sel_Adelanto", prmParameter)
                    If Not oDSLiquidacionEstadoDetalle Is Nothing Then
                        If oDSLiquidacionEstadoDetalle.Tables.Count > 0 Then
                            If oDSLiquidacionEstadoDetalle.Tables(0).Rows.Count > 0 Then
                                Return oDSLiquidacionEstadoDetalle
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSLiquidacionEstadoDetalle

        End Function





        Public Function LeerLiquidacionEstadoDetalleDS_SelAll(ByVal sCodigoMovimiento As String) As DataSet
            Dim oDSLiquidacionEstadoDetalle As New DataSet

            Try
                Dim prmParameter(0) As SqlParameter
                prmParameter(0) = New SqlParameter("@codigomovimiento", SqlDbType.Char, 1)
                prmParameter(0).Value = sCodigoMovimiento

                Using oDSLiquidacionEstadoDetalle
                    oDSLiquidacionEstadoDetalle = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "upLiquidacionEstadoDetalle_SelAll ", prmParameter)
                    If Not oDSLiquidacionEstadoDetalle Is Nothing Then
                        If oDSLiquidacionEstadoDetalle.Tables.Count > 0 Then
                            If oDSLiquidacionEstadoDetalle.Tables(0).Rows.Count > 0 Then
                                Return oDSLiquidacionEstadoDetalle
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSLiquidacionEstadoDetalle

        End Function

        Public Function LeerLiquidacionEstadoDetalleDS_Sel_Seguimiento(ByVal oLiquidacionEstadoDetalle As clsBE_LiquidacionEstadoDetalle) As DataSet
            Dim oDSLiquidacionEstadoDetalle As New DataSet

            Try
                Dim prmParameter(1) As SqlParameter
                prmParameter(0) = New SqlParameter("@liquidacionEstadoId", SqlDbType.Int)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacionEstadoDetalle.liquidacionEstadoId), 0, oLiquidacionEstadoDetalle.liquidacionEstadoId)

                prmParameter(1) = New SqlParameter("@NRO_OP", SqlDbType.VarChar, 20)
                prmParameter(1).Value = IIf(IsNothing(oLiquidacionEstadoDetalle.NRO_OP), "", oLiquidacionEstadoDetalle.NRO_OP)


                Using oDSLiquidacionEstadoDetalle
                    oDSLiquidacionEstadoDetalle = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "upLiquidacionEstadoDetalle_Sel_Seguimiento", prmParameter)
                    If Not oDSLiquidacionEstadoDetalle Is Nothing Then
                        If oDSLiquidacionEstadoDetalle.Tables.Count > 0 Then
                            If oDSLiquidacionEstadoDetalle.Tables(0).Rows.Count > 0 Then
                                Return oDSLiquidacionEstadoDetalle
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSLiquidacionEstadoDetalle

        End Function
    End Class
#End Region
    

    
End Namespace
