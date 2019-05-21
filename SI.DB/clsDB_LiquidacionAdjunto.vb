


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

    Public Class clsDB_LiquidacionAdjuntoTX

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub



        Public Function InsertaLiquidacionAdjunto(ByVal oLstLiquidacionAdjunto As List(Of clsBE_LiquidacionAdjunto)) As Boolean
            For Each oLiquidacionAdjunto As clsBE_LiquidacionAdjunto In oLstLiquidacionAdjunto
                Dim prmParameter(7) As SqlParameter

                prmParameter(0) = New SqlParameter("@liquidacionEstadoId", SqlDbType.Int)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacionAdjunto.liquidacionEstadoId), 0, oLiquidacionAdjunto.liquidacionEstadoId)
                prmParameter(0).Direction = ParameterDirection.Input

                prmParameter(1) = New SqlParameter("@liquidacionEstadoDetalleId", SqlDbType.Int)
                prmParameter(1).Value = IIf(IsNothing(oLiquidacionAdjunto.liquidacionEstadoDetalleId), 0, oLiquidacionAdjunto.liquidacionEstadoDetalleId)
                prmParameter(1).Direction = ParameterDirection.Input

                prmParameter(2) = New SqlParameter("@tipoAdjuntarDoc", SqlDbType.VarChar, 20)
                prmParameter(2).Value = IIf(IsNothing(oLiquidacionAdjunto.tipoAdjuntarDoc), "", oLiquidacionAdjunto.tipoAdjuntarDoc)
                prmParameter(2).Direction = ParameterDirection.Input

                prmParameter(3) = New SqlParameter("@ruta", SqlDbType.VarChar, 2000)
                prmParameter(3).Value = IIf(IsNothing(oLiquidacionAdjunto.ruta), "", oLiquidacionAdjunto.ruta)
                prmParameter(3).Direction = ParameterDirection.Input

                prmParameter(4) = New SqlParameter("@archivo", SqlDbType.VarChar, 200)
                prmParameter(4).Value = IIf(IsNothing(oLiquidacionAdjunto.archivo), "", oLiquidacionAdjunto.archivo)
                prmParameter(4).Direction = ParameterDirection.Input

                prmParameter(5) = New SqlParameter("@uc", SqlDbType.VarChar, 20)
                prmParameter(5).Value = IIf(IsNothing(oLiquidacionAdjunto.uc), "", oLiquidacionAdjunto.uc)
                prmParameter(5).Direction = ParameterDirection.Input

                prmParameter(6) = New SqlParameter("@IDITEM", SqlDbType.Int)
                prmParameter(6).Value = IIf(IsNothing(oLiquidacionAdjunto.IDITEM), "", oLiquidacionAdjunto.IDITEM)
                prmParameter(6).Direction = ParameterDirection.Input

                prmParameter(7) = New SqlParameter("@NRO_OP", SqlDbType.VarChar, 10)
                prmParameter(7).Value = IIf(IsNothing(oLiquidacionAdjunto.nro_op), "", oLiquidacionAdjunto.nro_op)
                prmParameter(7).Direction = ParameterDirection.Input

                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "upLiquidacionAdjunto_Ins", prmParameter)
                Catch ex As Exception
                    Throw ex
                    Return False
                End Try
            Next
            Return True
        End Function

        Public Function EliminaLiquidacionAdjunto(ByVal oLstLiquidacionAdjunto As List(Of clsBE_LiquidacionAdjunto)) As Boolean
            For Each oLiquidacionAdjunto As clsBE_LiquidacionAdjunto In oLstLiquidacionAdjunto
                'Public Function EliminaLiquidacionAdjunto(ByVal oLstLiquidacionEstadoDetalle As List(Of clsBE_LiquidacionEstadoDetalle)) As Boolean
                '    For Each oLiquidacionEstadoDetalle As clsBE_LiquidacionEstadoDetalle In oLstLiquidacionEstadoDetalle
                Dim prmParameter(2) As SqlParameter

                prmParameter(0) = New SqlParameter("@liquidacionEstadoId", SqlDbType.Int)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacionAdjunto.liquidacionEstadoId), 0, oLiquidacionAdjunto.liquidacionEstadoId)
                prmParameter(0).Direction = ParameterDirection.Input

                prmParameter(1) = New SqlParameter("@liquidacionEstadoDetalleId", SqlDbType.Int)
                prmParameter(1).Value = IIf(IsNothing(oLiquidacionAdjunto.liquidacionEstadoDetalleId), 0, oLiquidacionAdjunto.liquidacionEstadoDetalleId)
                prmParameter(1).Direction = ParameterDirection.Input

                prmParameter(2) = New SqlParameter("@liquidacionAdjuntoId", SqlDbType.Int)
                prmParameter(2).Value = IIf(IsNothing(oLiquidacionAdjunto.liquidacionAdjuntoId), 0, oLiquidacionAdjunto.liquidacionAdjuntoId)
                prmParameter(2).Direction = ParameterDirection.Input

                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "upLiquidacionAdjunto_Del", prmParameter)
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
    ''' Fecha Creacion: 17/02/2011 16:40:02
    ''' Proposito: Obtiene los valores de la tabla Liquidacion
    ''' Fecha Modificacion:
    ''' </summary>
	'''
    <Serializable()> _
    Public Class clsDB_LiquidacionAdjuntoRO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub


        Public Function DefinirTablaLiquidacionAdjunto() As DataTable

            Try
                Dim DTLiquidacionAdjunto As New DataTable

                Dim orden As DataColumn = DTLiquidacionAdjunto.Columns.Add("orden", GetType(Integer))
                orden.AllowDBNull = False
                orden.DefaultValue = 0

                Dim liquidacionEstadoId As DataColumn = DTLiquidacionAdjunto.Columns.Add("liquidacionEstadoId", GetType(Integer))
                liquidacionEstadoId.AllowDBNull = False
                liquidacionEstadoId.DefaultValue = 0

                Dim liquidacionEstadoDetalleId As DataColumn = DTLiquidacionAdjunto.Columns.Add("liquidacionEstadoDetalleId", GetType(Integer))
                liquidacionEstadoDetalleId.AllowDBNull = False
                liquidacionEstadoDetalleId.DefaultValue = 0

                Dim liquidacionAdjuntoId As DataColumn = DTLiquidacionAdjunto.Columns.Add("liquidacionAdjuntoId", GetType(Integer))
                liquidacionAdjuntoId.AllowDBNull = False
                liquidacionAdjuntoId.DefaultValue = 0

                Dim tipoAdjuntarDoc As DataColumn = DTLiquidacionAdjunto.Columns.Add("tipoAdjuntarDoc", GetType(String))
                tipoAdjuntarDoc.MaxLength = 20
                tipoAdjuntarDoc.AllowDBNull = False
                tipoAdjuntarDoc.DefaultValue = ""

                Dim ruta As DataColumn = DTLiquidacionAdjunto.Columns.Add("ruta", GetType(String))
                ruta.MaxLength = 2000
                ruta.AllowDBNull = True
                ruta.DefaultValue = ""

                Dim archivo As DataColumn = DTLiquidacionAdjunto.Columns.Add("archivo", GetType(String))
                archivo.MaxLength = 200
                archivo.AllowDBNull = True
                archivo.DefaultValue = ""

                Dim uc As DataColumn = DTLiquidacionAdjunto.Columns.Add("uc", GetType(String))
                uc.MaxLength = 20
                uc.AllowDBNull = True
                uc.DefaultValue = ""

                Dim fc As DataColumn = DTLiquidacionAdjunto.Columns.Add("fc", GetType(DateTime))



                Return DTLiquidacionAdjunto
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function LeerLiquidacionAdjuntoDS_Sel(ByVal oBE_LiquidacionAdjunto As clsBE_LiquidacionAdjunto) As DataSet
            Dim oDSLiquidacionEstadoDetalle As New DataSet

            Dim prmParameter(0) As SqlParameter
            prmParameter(0) = New SqlParameter("@liquidacionEstadoId", SqlDbType.Int)
            prmParameter(0).Value = IIf(IsNothing(oBE_LiquidacionAdjunto.liquidacionEstadoId), 0, oBE_LiquidacionAdjunto.liquidacionEstadoId)

            Try
                Using oDSLiquidacionEstadoDetalle
                    oDSLiquidacionEstadoDetalle = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "upLiquidacionAdjunto_Sel", prmParameter)
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

        Public Function LeerLiquidacionEstadoDetalleDS_Sel(ByVal oLiquidacionEstadoDetalle As clsBE_LiquidacionEstadoDetalle) As DataSet
            Dim oDSLiquidacionEstadoDetalle As New DataSet

            Try
                Dim prmParameter(0) As SqlParameter
                prmParameter(0) = New SqlParameter("@liquidacionEstadoId", SqlDbType.Int)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacionEstadoDetalle.liquidacionEstadoId), 0, oLiquidacionEstadoDetalle.liquidacionEstadoId)


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

    End Class

#End Region
    
End Namespace
