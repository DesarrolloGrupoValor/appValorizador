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
    ''' Fecha Creacion: 21/04/2011 09:58:47 a.m.
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla LiquidacionTotal
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsDB_LiquidacionTotalTX

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 21/04/2011 09:58:47 a.m.
        ''' Proposito: Metodo de Insercci?n de Datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function InsertarLiquidacionTotal(ByVal oLstLiquidacionTotal As List(Of clsBE_LiquidacionTotal)) As Boolean
            For Each oLiquidacionTotal As clsBE_LiquidacionTotal In oLstLiquidacionTotal
                Dim prmParameter(9) As SqlParameter

                prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacionTotal.contratoLoteId), "", oLiquidacionTotal.contratoLoteId)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
                prmParameter(1).Value = IIf(IsNothing(oLiquidacionTotal.liquidacionId), "", oLiquidacionTotal.liquidacionId)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pimporte", SqlDbType.Int, 8)
                prmParameter(2).Value = IIf(IsNothing(oLiquidacionTotal.importe), 0, oLiquidacionTotal.importe)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@pcodigoEstado", SqlDbType.varchar, 15)
                prmParameter(3).Value = IIf(IsNothing(oLiquidacionTotal.codigoEstado), "", oLiquidacionTotal.codigoEstado)
                prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@puc", SqlDbType.varchar, 15)
                prmParameter(4).Value = IIf(IsNothing(oLiquidacionTotal.uc), "", oLiquidacionTotal.uc)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@pcodigoTotal", SqlDbType.varchar, 15)
                prmParameter(5).Value = IIf(IsNothing(oLiquidacionTotal.codigoTotal), "", oLiquidacionTotal.codigoTotal)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@pdescri", SqlDbType.varchar, 100)
                prmParameter(6).Value = IIf(IsNothing(oLiquidacionTotal.descri), "", oLiquidacionTotal.descri)
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7) = New SqlParameter("@pliquidacionTotalId", SqlDbType.varchar, 20)
                prmParameter(7).Value = IIf(IsNothing(oLiquidacionTotal.liquidacionTotalId), "", oLiquidacionTotal.liquidacionTotalId)
                prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(8) = New SqlParameter("@pnro", SqlDbType.Int, 4)
                prmParameter(8).Value = IIf(IsNothing(oLiquidacionTotal.nro), 0, oLiquidacionTotal.nro)
                prmParameter(8).Direction = ParameterDirection.Input
                prmParameter(9) = New SqlParameter("@pcodigoCalculoTotal", SqlDbType.varchar, 15)
                prmParameter(9).Value = IIf(IsNothing(oLiquidacionTotal.codigoCalculoTotal), "", oLiquidacionTotal.codigoCalculoTotal)
                prmParameter(9).Direction = ParameterDirection.Input
                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionTotal_Ins", prmParameter)
                Catch ex As Exception
                    Throw ex
                    Return False
                End Try
            Next
            Return True
        End Function
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 21/04/2011 09:58:47 a.m.
        ''' Proposito: Metodo de Modificacion de datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function ModificarLiquidacionTotal(ByVal oLstLiquidacionTotal As List(Of clsBE_LiquidacionTotal)) As Boolean
            For Each oLiquidacionTotal As clsBE_LiquidacionTotal In oLstLiquidacionTotal
                Dim prmParameter(10) As SqlParameter
                prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacionTotal.contratoLoteId), "", oLiquidacionTotal.contratoLoteId)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
                prmParameter(1).Value = IIf(IsNothing(oLiquidacionTotal.liquidacionId), "", oLiquidacionTotal.liquidacionId)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pimporte", SqlDbType.Int, 8)
                prmParameter(2).Value = IIf(IsNothing(oLiquidacionTotal.importe), 0, oLiquidacionTotal.importe)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@pcodigoEstado", SqlDbType.varchar, 15)
                prmParameter(3).Value = IIf(IsNothing(oLiquidacionTotal.codigoEstado), "", oLiquidacionTotal.codigoEstado)
                prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@pum", SqlDbType.varchar, 15)
                prmParameter(4).Value = IIf(IsNothing(oLiquidacionTotal.um), "", oLiquidacionTotal.um)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@pfm", SqlDbType.DateTime, 8)
                prmParameter(5).Value = clsUT_Funcion.FechaNull(oLiquidacionTotal.fm)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@pcodigoTotal", SqlDbType.varchar, 15)
                prmParameter(6).Value = IIf(IsNothing(oLiquidacionTotal.codigoTotal), "", oLiquidacionTotal.codigoTotal)
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7) = New SqlParameter("@pdescri", SqlDbType.varchar, 100)
                prmParameter(7).Value = IIf(IsNothing(oLiquidacionTotal.descri), "", oLiquidacionTotal.descri)
                prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(8) = New SqlParameter("@pliquidacionTotalId", SqlDbType.varchar, 20)
                prmParameter(8).Value = IIf(IsNothing(oLiquidacionTotal.liquidacionTotalId), "", oLiquidacionTotal.liquidacionTotalId)
                prmParameter(8).Direction = ParameterDirection.Input
                prmParameter(9) = New SqlParameter("@pnro", SqlDbType.Int, 4)
                prmParameter(9).Value = IIf(IsNothing(oLiquidacionTotal.nro), 0, oLiquidacionTotal.nro)
                prmParameter(9).Direction = ParameterDirection.Input
                prmParameter(10) = New SqlParameter("@pcodigoCalculoTotal", SqlDbType.varchar, 15)
                prmParameter(10).Value = IIf(IsNothing(oLiquidacionTotal.codigoCalculoTotal), "", oLiquidacionTotal.codigoCalculoTotal)
                prmParameter(10).Direction = ParameterDirection.Input
                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionTotal_Upd", prmParameter)
                Catch ex As Exception
                    Throw ex
                    Return False
                End Try
            Next
            Return True
        End Function

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 21/04/2011 09:58:47 a.m.
        ''' Proposito: Metodo de Elimacion
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function EliminarLiquidacionTotal(ByVal oLstLiquidacionTotal As List(Of clsBE_LiquidacionTotal)) As Boolean
            For Each oLiquidacionTotal As clsBE_LiquidacionTotal In oLstLiquidacionTotal
                Dim prmParameter(2) As SqlParameter
                prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacionTotal.contratoLoteId), "", oLiquidacionTotal.contratoLoteId)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
                prmParameter(1).Value = IIf(IsNothing(oLiquidacionTotal.liquidacionId), "", oLiquidacionTotal.liquidacionId)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pliquidacionTotalId", SqlDbType.varchar, 20)
                prmParameter(2).Value = IIf(IsNothing(oLiquidacionTotal.liquidacionTotalId), "", oLiquidacionTotal.liquidacionTotalId)
                prmParameter(2).Direction = ParameterDirection.Input
                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionTotal_Del", prmParameter)
                Catch ex As Exception
                    Throw ex
                    Return False
                End Try
            Next
            Return True
        End Function

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 21/04/2011 09:58:47 a.m.
        ''' Proposito: Metodo de Guardar Dataset
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function GuardarLiquidacionTotal(ByVal oDSLiquidacionTotal As Dataset) As Boolean
            Dim cnxCPO As New SqlConnection(CadenaConexion)


            Try
                Dim objCommnadInsert As New SqlCommand
                objCommnadInsert.Connection = cnxCPO
                objCommnadInsert.CommandText = "up_LiquidacionTotal_Ins"
                objCommnadInsert.CommandType = CommandType.StoredProcedure

                objCommnadInsert.Parameters.Add("@pcontratoLoteId", SqlDbType.varchar, 20).SourceColumn = "contratoLoteId"
                objCommnadInsert.Parameters.Add("@pliquidacionId", SqlDbType.varchar, 20).SourceColumn = "liquidacionId"
                objCommnadInsert.Parameters.Add("@pimporte", SqlDbType.Int, 8).SourceColumn = "importe"
                objCommnadInsert.Parameters.Add("@pcodigoEstado", SqlDbType.varchar, 15).SourceColumn = "codigoEstado"
                objCommnadInsert.Parameters.Add("@puc", SqlDbType.varchar, 15).SourceColumn = "uc"
                objCommnadInsert.Parameters.Add("@pcodigoTotal", SqlDbType.varchar, 15).SourceColumn = "codigoTotal"
                objCommnadInsert.Parameters.Add("@pdescri", SqlDbType.varchar, 100).SourceColumn = "descri"
                objCommnadInsert.Parameters.Add("@pliquidacionTotalId", SqlDbType.varchar, 20).SourceColumn = "liquidacionTotalId"
                objCommnadInsert.Parameters.Add("@pnro", SqlDbType.Int, 4).SourceColumn = "nro"
                objCommnadInsert.Parameters.Add("@pcodigoCalculoTotal", SqlDbType.varchar, 15).SourceColumn = "codigoCalculoTotal"

                Dim objCommandUpdate As New SqlCommand
                objCommandUpdate.Connection = cnxCPO
                objCommandUpdate.CommandText = "up_LiquidacionTotal_Upd"
                objCommandUpdate.CommandType = CommandType.StoredProcedure

                objCommandUpdate.Parameters.Add("@pcontratoLoteId", SqlDbType.varchar, 20).SourceColumn = "contratoLoteId"
                objCommandUpdate.Parameters.Add("@pliquidacionId", SqlDbType.varchar, 20).SourceColumn = "liquidacionId"
                objCommandUpdate.Parameters.Add("@pimporte", SqlDbType.Int, 8).SourceColumn = "importe"
                objCommandUpdate.Parameters.Add("@pcodigoEstado", SqlDbType.varchar, 15).SourceColumn = "codigoEstado"
                objCommandUpdate.Parameters.Add("@pum", SqlDbType.varchar, 15).SourceColumn = "um"
                objCommandUpdate.Parameters.Add("@pfm", SqlDbType.DateTime, 8).SourceColumn = "fm"
                objCommandUpdate.Parameters.Add("@pcodigoTotal", SqlDbType.varchar, 15).SourceColumn = "codigoTotal"
                objCommandUpdate.Parameters.Add("@pdescri", SqlDbType.varchar, 100).SourceColumn = "descri"
                objCommandUpdate.Parameters.Add("@pliquidacionTotalId", SqlDbType.varchar, 20).SourceColumn = "liquidacionTotalId"
                objCommandUpdate.Parameters.Add("@pnro", SqlDbType.Int, 4).SourceColumn = "nro"
                objCommandUpdate.Parameters.Add("@pcodigoCalculoTotal", SqlDbType.varchar, 15).SourceColumn = "codigoCalculoTotal"

                Dim objCommandDelete As New SqlCommand
                objCommandDelete.Connection = cnxCPO
                objCommandDelete.CommandText = "up_LiquidacionTotal_Del"
                objCommandDelete.CommandType = CommandType.StoredProcedure

                objCommandDelete.Parameters.Add("@pcontratoLoteId", SqlDbType.varchar, 20).SourceColumn = "contratoLoteId"
                objCommandDelete.Parameters.Add("@pliquidacionId", SqlDbType.varchar, 20).SourceColumn = "liquidacionId"
                objCommandDelete.Parameters.Add("@pliquidacionTotalId", SqlDbType.varchar, 20).SourceColumn = "liquidacionTotalId"

                'SqlHelper.UpdateDataset(objCommnadInsert, objCommandDelete, objCommandUpdate, oDSLiquidacionTotal, "LiquidacionTotal")

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
    ''' Fecha Creacion: 21/04/2011 09:58:47 a.m.
    ''' Proposito: Obtiene los valores de la tabla LiquidacionTotal
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsDB_LiquidacionTotalRO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 21/04/2011 09:58:47 a.m.
        ''' Proposito: Lee los datos de un registro
        ''' Fecha Modificacion:
        ''' </summary>
        ''' 
        Public Function LeerLiquidacionTotal(ByVal pLiquidacionTotal As clsBE_LiquidacionTotal) As clsBE_LiquidacionTotal
            Dim oLiquidacionTotal As clsBE_LiquidacionTotal = Nothing
            Dim DSLiquidacionTotal As New DataSet
            Dim prmParameter(2) As SqlParameter
            prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
            prmParameter(0).Value = IIf(IsNothing(pLiquidacionTotal.contratoLoteId), "", pLiquidacionTotal.contratoLoteId)
            prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
            prmParameter(1).Value = IIf(IsNothing(pLiquidacionTotal.liquidacionId), "", pLiquidacionTotal.liquidacionId)
            prmParameter(2) = New SqlParameter("@pliquidacionTotalId", SqlDbType.varchar, 20)
            prmParameter(2).Value = IIf(IsNothing(pLiquidacionTotal.liquidacionTotalId), "", pLiquidacionTotal.liquidacionTotalId)
            Try
                Using DSLiquidacionTotal
                    DSLiquidacionTotal = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionTotal_Sel", prmParameter)
                    If Not DSLiquidacionTotal Is Nothing Then
                        If DSLiquidacionTotal.Tables.Count > 0 Then
                            oLiquidacionTotal = New clsBE_LiquidacionTotal
                            If DSLiquidacionTotal.Tables(0).Rows.Count > 0 Then
                                With DSLiquidacionTotal.Tables(0).Rows(0)
                                    oLiquidacionTotal.contratoLoteId = .Item("contratoLoteId").tostring
                                    oLiquidacionTotal.liquidacionId = .Item("liquidacionId").tostring
                                    oLiquidacionTotal.importe = .Item("importe").tostring
                                    oLiquidacionTotal.codigoEstado = .Item("codigoEstado").tostring
                                    oLiquidacionTotal.uc = .Item("uc").tostring
                                    oLiquidacionTotal.fc = .Item("fc").tostring
                                    oLiquidacionTotal.codigoTotal = .Item("codigoTotal").tostring
                                    oLiquidacionTotal.descri = .Item("descri").tostring
                                    oLiquidacionTotal.liquidacionTotalId = .Item("liquidacionTotalId").tostring
                                    oLiquidacionTotal.nro = .Item("nro").tostring
                                    oLiquidacionTotal.codigoCalculoTotal = .Item("codigoCalculoTotal").tostring
                                End With
                            End If
                        End If
                    End If
                End Using
            Catch exSql As SqlException

            Catch ex As Exception
                Throw ex
            Finally
                If Not DSLiquidacionTotal Is Nothing Then
                    DSLiquidacionTotal.Dispose()
                End If
                DSLiquidacionTotal = Nothing
            End Try

            Return oLiquidacionTotal

        End Function


        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 21/04/2011 09:58:47 a.m.
        ''' Proposito: Obtiene la lista de registros
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaLiquidacionTotal() As List(Of clsBE_LiquidacionTotal)
            Dim olstLiquidacionTotal As New List(Of clsBE_LiquidacionTotal)
            Dim oLiquidacionTotal As clsBE_LiquidacionTotal = Nothing
            Dim mintItem As Integer = 0
            Try
                Using Reader As SqlDataReader = SqlHelper.ExecuteReader(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionTotal_Sellst")
                    If Reader.HasRows Then
                        While reader.Read
                            oLiquidacionTotal = New clsBE_LiquidacionTotal
                            mintItem += 1
                            With oLiquidacionTotal
                                .Item = mintItem

                                .contratoLoteId = Reader("contratoLoteId").tostring
                                .liquidacionId = Reader("liquidacionId").tostring
                                .importe = Reader("importe").tostring
                                .codigoEstado = Reader("codigoEstado").tostring
                                .uc = Reader("uc").tostring
                                .fc = Reader("fc").tostring
                                .um = Reader("um").tostring
                                .fm = Reader("fm").tostring
                                .codigoTotal = Reader("codigoTotal").tostring
                                .descri = Reader("descri").tostring
                                .liquidacionTotalId = Reader("liquidacionTotalId").tostring
                                .nro = Reader("nro").tostring
                                .codigoCalculoTotal = Reader("codigoCalculoTotal").tostring
                            End With
                            olstLiquidacionTotal.Add(oLiquidacionTotal)
                        End While
                    End If
                End Using
            Catch ex As Exception
                Throw ex
            End Try

            Return olstLiquidacionTotal

        End Function

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 21/04/2011 09:58:47 a.m.
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSLiquidacionTotal(ByVal pLiquidacionTotal As clsBE_LiquidacionTotal) As Dataset
            Dim oDSLiquidacionTotal As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(0) As SqlParameter
            prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
            prmParameter(0).Value = IIf(IsNothing(pLiquidacionTotal.contratoLoteId), "", pLiquidacionTotal.contratoLoteId)
           
            Try

                Using oDSLiquidacionTotal
                    oDSLiquidacionTotal = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionTotal_Sellst", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionTotal_Sellst", oDSLiquidacionTotal, New String() {"LiquidacionTotal"}, prmParameter)
                    If Not oDSLiquidacionTotal Is Nothing Then
                        If oDSLiquidacionTotal.Tables.Count > 0 Then
                            'If oDSLiquidacionTotal.Tables("LiquidacionTotal").Rows.Count > 0 Then
                            If oDSLiquidacionTotal.Tables(0).Rows.Count > 0 Then
                                Return oDSLiquidacionTotal
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSLiquidacionTotal

        End Function


        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 21/04/2011 09:58:47 a.m.
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function DefinirTablaLiquidacionTotal() As DataTable

            Try
                Dim DTLiquidacionTotal As New DataTable

                Dim contratoLoteId As DataColumn = DTLiquidacionTotal.Columns.Add("contratoLoteId", GetType(String))
                contratoLoteId.MaxLength = 20
                contratoLoteId.AllowDBNull = False
                contratoLoteId.DefaultValue = ""

                Dim liquidacionId As DataColumn = DTLiquidacionTotal.Columns.Add("liquidacionId", GetType(String))
                liquidacionId.MaxLength = 20
                liquidacionId.AllowDBNull = False
                liquidacionId.DefaultValue = ""

                Dim importe As DataColumn = DTLiquidacionTotal.Columns.Add("importe", GetType(Integer))
                importe.AllowDBNull = True
                importe.DefaultValue = 0


                Dim codigoEstado As DataColumn = DTLiquidacionTotal.Columns.Add("codigoEstado", GetType(String))
                codigoEstado.MaxLength = 15
                codigoEstado.AllowDBNull = True
                codigoEstado.DefaultValue = ""

                Dim uc As DataColumn = DTLiquidacionTotal.Columns.Add("uc", GetType(String))
                uc.MaxLength = 15
                uc.AllowDBNull = True
                uc.DefaultValue = ""

                Dim fc As DataColumn = DTLiquidacionTotal.Columns.Add("fc", GetType(DateTime))


                Dim um As DataColumn = DTLiquidacionTotal.Columns.Add("um", GetType(String))
                um.MaxLength = 15
                um.AllowDBNull = True
                um.DefaultValue = ""

                Dim fm As DataColumn = DTLiquidacionTotal.Columns.Add("fm", GetType(DateTime))


                Dim codigoTotal As DataColumn = DTLiquidacionTotal.Columns.Add("codigoTotal", GetType(String))
                codigoTotal.MaxLength = 15
                codigoTotal.AllowDBNull = True
                codigoTotal.DefaultValue = ""

                Dim descri As DataColumn = DTLiquidacionTotal.Columns.Add("descri", GetType(String))
                descri.MaxLength = 100
                descri.AllowDBNull = True
                descri.DefaultValue = ""

                Dim liquidacionTotalId As DataColumn = DTLiquidacionTotal.Columns.Add("liquidacionTotalId", GetType(String))
                liquidacionTotalId.MaxLength = 20
                liquidacionTotalId.AllowDBNull = False
                liquidacionTotalId.DefaultValue = ""

                Dim nro As DataColumn = DTLiquidacionTotal.Columns.Add("nro", GetType(Integer))
                nro.AllowDBNull = True
                nro.DefaultValue = 0


                Dim codigoCalculoTotal As DataColumn = DTLiquidacionTotal.Columns.Add("codigoCalculoTotal", GetType(String))
                codigoCalculoTotal.MaxLength = 15
                codigoCalculoTotal.AllowDBNull = True
                codigoCalculoTotal.DefaultValue = ""

                Return DTLiquidacionTotal
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class
#End Region

End Namespace
