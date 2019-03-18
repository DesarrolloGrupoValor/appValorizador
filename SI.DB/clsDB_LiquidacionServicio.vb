


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
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla LiquidacionServicio
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsDB_LiquidacionServicioTX

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
        Public Function InsertarLiquidacionServicio(ByVal oLstLiquidacionServicio As List(Of clsBE_LiquidacionServicio)) As Boolean
            For Each oLiquidacionServicio As clsBE_LiquidacionServicio In oLstLiquidacionServicio
                Dim prmParameter(9) As SqlParameter

                prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacionServicio.contratoLoteId), "", oLiquidacionServicio.contratoLoteId)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
                prmParameter(1).Value = IIf(IsNothing(oLiquidacionServicio.liquidacionId), "", oLiquidacionServicio.liquidacionId)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pimporte", SqlDbType.Int, 8)
                prmParameter(2).Value = IIf(IsNothing(oLiquidacionServicio.importe), 0, oLiquidacionServicio.importe)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@pcodigoEstado", SqlDbType.varchar, 15)
                prmParameter(3).Value = IIf(IsNothing(oLiquidacionServicio.codigoEstado), "", oLiquidacionServicio.codigoEstado)
                prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@puc", SqlDbType.varchar, 15)
                prmParameter(4).Value = IIf(IsNothing(oLiquidacionServicio.uc), "", oLiquidacionServicio.uc)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@pcodigoServicio", SqlDbType.varchar, 15)
                prmParameter(5).Value = IIf(IsNothing(oLiquidacionServicio.codigoServicio), "", oLiquidacionServicio.codigoServicio)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@pdescri", SqlDbType.varchar, 100)
                prmParameter(6).Value = IIf(IsNothing(oLiquidacionServicio.descri), "", oLiquidacionServicio.descri)
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7) = New SqlParameter("@pliquidacionServicioId", SqlDbType.varchar, 20)
                prmParameter(7).Value = IIf(IsNothing(oLiquidacionServicio.liquidacionServicioId), "", oLiquidacionServicio.liquidacionServicioId)
                prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(8) = New SqlParameter("@pnro", SqlDbType.Int, 4)
                prmParameter(8).Value = IIf(IsNothing(oLiquidacionServicio.nro), 0, oLiquidacionServicio.nro)
                prmParameter(8).Direction = ParameterDirection.Input
                prmParameter(9) = New SqlParameter("@pcodigoCalculoServicio", SqlDbType.varchar, 15)
                prmParameter(9).Value = IIf(IsNothing(oLiquidacionServicio.codigoCalculoServicio), "", oLiquidacionServicio.codigoCalculoServicio)
                prmParameter(9).Direction = ParameterDirection.Input
                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionServicio_Ins", prmParameter)
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
        Public Function ModificarLiquidacionServicio(ByVal oLstLiquidacionServicio As List(Of clsBE_LiquidacionServicio)) As Boolean
            For Each oLiquidacionServicio As clsBE_LiquidacionServicio In oLstLiquidacionServicio
                Dim prmParameter(10) As SqlParameter
                prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacionServicio.contratoLoteId), "", oLiquidacionServicio.contratoLoteId)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
                prmParameter(1).Value = IIf(IsNothing(oLiquidacionServicio.liquidacionId), "", oLiquidacionServicio.liquidacionId)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pimporte", SqlDbType.Int, 8)
                prmParameter(2).Value = IIf(IsNothing(oLiquidacionServicio.importe), 0, oLiquidacionServicio.importe)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@pcodigoEstado", SqlDbType.varchar, 15)
                prmParameter(3).Value = IIf(IsNothing(oLiquidacionServicio.codigoEstado), "", oLiquidacionServicio.codigoEstado)
                prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@pum", SqlDbType.varchar, 15)
                prmParameter(4).Value = IIf(IsNothing(oLiquidacionServicio.um), "", oLiquidacionServicio.um)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@pfm", SqlDbType.DateTime, 8)
                prmParameter(5).Value = clsUT_Funcion.FechaNull(oLiquidacionServicio.fm)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@pcodigoServicio", SqlDbType.varchar, 15)
                prmParameter(6).Value = IIf(IsNothing(oLiquidacionServicio.codigoServicio), "", oLiquidacionServicio.codigoServicio)
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7) = New SqlParameter("@pdescri", SqlDbType.varchar, 100)
                prmParameter(7).Value = IIf(IsNothing(oLiquidacionServicio.descri), "", oLiquidacionServicio.descri)
                prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(8) = New SqlParameter("@pliquidacionServicioId", SqlDbType.varchar, 20)
                prmParameter(8).Value = IIf(IsNothing(oLiquidacionServicio.liquidacionServicioId), "", oLiquidacionServicio.liquidacionServicioId)
                prmParameter(8).Direction = ParameterDirection.Input
                prmParameter(9) = New SqlParameter("@pnro", SqlDbType.Int, 4)
                prmParameter(9).Value = IIf(IsNothing(oLiquidacionServicio.nro), 0, oLiquidacionServicio.nro)
                prmParameter(9).Direction = ParameterDirection.Input
                prmParameter(10) = New SqlParameter("@pcodigoCalculoServicio", SqlDbType.varchar, 15)
                prmParameter(10).Value = IIf(IsNothing(oLiquidacionServicio.codigoCalculoServicio), "", oLiquidacionServicio.codigoCalculoServicio)
                prmParameter(10).Direction = ParameterDirection.Input
                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionServicio_Upd", prmParameter)
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
        Public Function EliminarLiquidacionServicio(ByVal oLstLiquidacionServicio As List(Of clsBE_LiquidacionServicio)) As Boolean
            For Each oLiquidacionServicio As clsBE_LiquidacionServicio In oLstLiquidacionServicio
                Dim prmParameter(2) As SqlParameter
                prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacionServicio.contratoLoteId), "", oLiquidacionServicio.contratoLoteId)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
                prmParameter(1).Value = IIf(IsNothing(oLiquidacionServicio.liquidacionId), "", oLiquidacionServicio.liquidacionId)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pliquidacionServicioId", SqlDbType.varchar, 20)
                prmParameter(2).Value = IIf(IsNothing(oLiquidacionServicio.liquidacionServicioId), "", oLiquidacionServicio.liquidacionServicioId)
                prmParameter(2).Direction = ParameterDirection.Input
                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionServicio_Del", prmParameter)
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
        Public Function GuardarLiquidacionServicio(ByVal oDSLiquidacionServicio As Dataset) As Boolean
            Dim cnxCPO As New SqlConnection(CadenaConexion)


            Try
                Dim objCommnadInsert As New SqlCommand
                objCommnadInsert.Connection = cnxCPO
                objCommnadInsert.CommandText = "up_LiquidacionServicio_Ins"
                objCommnadInsert.CommandType = CommandType.StoredProcedure

                objCommnadInsert.Parameters.Add("@pcontratoLoteId", SqlDbType.varchar, 20).SourceColumn = "contratoLoteId"
                objCommnadInsert.Parameters.Add("@pliquidacionId", SqlDbType.varchar, 20).SourceColumn = "liquidacionId"
                objCommnadInsert.Parameters.Add("@pimporte", SqlDbType.Int, 8).SourceColumn = "importe"
                objCommnadInsert.Parameters.Add("@pcodigoEstado", SqlDbType.varchar, 15).SourceColumn = "codigoEstado"
                objCommnadInsert.Parameters.Add("@puc", SqlDbType.varchar, 15).SourceColumn = "uc"
                objCommnadInsert.Parameters.Add("@pcodigoServicio", SqlDbType.varchar, 15).SourceColumn = "codigoServicio"
                objCommnadInsert.Parameters.Add("@pdescri", SqlDbType.varchar, 100).SourceColumn = "descri"
                objCommnadInsert.Parameters.Add("@pliquidacionServicioId", SqlDbType.varchar, 20).SourceColumn = "liquidacionServicioId"
                objCommnadInsert.Parameters.Add("@pnro", SqlDbType.Int, 4).SourceColumn = "nro"
                objCommnadInsert.Parameters.Add("@pcodigoCalculoServicio", SqlDbType.varchar, 15).SourceColumn = "codigoCalculoServicio"

                Dim objCommandUpdate As New SqlCommand
                objCommandUpdate.Connection = cnxCPO
                objCommandUpdate.CommandText = "up_LiquidacionServicio_Upd"
                objCommandUpdate.CommandType = CommandType.StoredProcedure

                objCommandUpdate.Parameters.Add("@pcontratoLoteId", SqlDbType.varchar, 20).SourceColumn = "contratoLoteId"
                objCommandUpdate.Parameters.Add("@pliquidacionId", SqlDbType.varchar, 20).SourceColumn = "liquidacionId"
                objCommandUpdate.Parameters.Add("@pimporte", SqlDbType.Int, 8).SourceColumn = "importe"
                objCommandUpdate.Parameters.Add("@pcodigoEstado", SqlDbType.varchar, 15).SourceColumn = "codigoEstado"
                objCommandUpdate.Parameters.Add("@pum", SqlDbType.varchar, 15).SourceColumn = "um"
                objCommandUpdate.Parameters.Add("@pfm", SqlDbType.DateTime, 8).SourceColumn = "fm"
                objCommandUpdate.Parameters.Add("@pcodigoServicio", SqlDbType.varchar, 15).SourceColumn = "codigoServicio"
                objCommandUpdate.Parameters.Add("@pdescri", SqlDbType.varchar, 100).SourceColumn = "descri"
                objCommandUpdate.Parameters.Add("@pliquidacionServicioId", SqlDbType.varchar, 20).SourceColumn = "liquidacionServicioId"
                objCommandUpdate.Parameters.Add("@pnro", SqlDbType.Int, 4).SourceColumn = "nro"
                objCommandUpdate.Parameters.Add("@pcodigoCalculoServicio", SqlDbType.varchar, 15).SourceColumn = "codigoCalculoServicio"

                Dim objCommandDelete As New SqlCommand
                objCommandDelete.Connection = cnxCPO
                objCommandDelete.CommandText = "up_LiquidacionServicio_Del"
                objCommandDelete.CommandType = CommandType.StoredProcedure

                objCommandDelete.Parameters.Add("@pcontratoLoteId", SqlDbType.varchar, 20).SourceColumn = "contratoLoteId"
                objCommandDelete.Parameters.Add("@pliquidacionId", SqlDbType.varchar, 20).SourceColumn = "liquidacionId"
                objCommandDelete.Parameters.Add("@pliquidacionServicioId", SqlDbType.varchar, 20).SourceColumn = "liquidacionServicioId"

                'SqlHelper.UpdateDataset(objCommnadInsert, objCommandDelete, objCommandUpdate, oDSLiquidacionServicio, "LiquidacionServicio")

            Catch ex As Exception
                Throw ex
                Return False
            End Try
            Return True

        End Function








        Public Function CostoLiquidacionServicio(ByVal oLstLiquidacionServicio As List(Of clsBE_LiquidacionServicio)) As Boolean
            For Each oLiquidacionServicio As clsBE_LiquidacionServicio In oLstLiquidacionServicio
                Dim prmParameter(2) As SqlParameter

                prmParameter(0) = New SqlParameter("@contratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacionServicio.contratoLoteId), "", oLiquidacionServicio.contratoLoteId)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@liquidacionId", SqlDbType.VarChar, 20)
                prmParameter(1).Value = IIf(IsNothing(oLiquidacionServicio.liquidacionId), "", oLiquidacionServicio.liquidacionId)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@uc", SqlDbType.VarChar, 15)
                prmParameter(2).Value = IIf(IsNothing(oLiquidacionServicio.uc), "", oLiquidacionServicio.uc)
                prmParameter(2).Direction = ParameterDirection.Input

                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionServicio_Costo", prmParameter)
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
    ''' Fecha Creacion: 21/04/2011 09:58:47 a.m.
    ''' Proposito: Obtiene los valores de la tabla LiquidacionServicio
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsDB_LiquidacionServicioRO
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
        Public Function LeerLiquidacionServicio(ByVal pLiquidacionServicio As clsBE_LiquidacionServicio) As clsBE_LiquidacionServicio
            Dim oLiquidacionServicio As clsBE_LiquidacionServicio = Nothing
            Dim DSLiquidacionServicio As New DataSet
            Dim prmParameter(2) As SqlParameter
            prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
            prmParameter(0).Value = IIf(IsNothing(pLiquidacionServicio.contratoLoteId), "", pLiquidacionServicio.contratoLoteId)
            prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
            prmParameter(1).Value = IIf(IsNothing(pLiquidacionServicio.liquidacionId), "", pLiquidacionServicio.liquidacionId)
            prmParameter(2) = New SqlParameter("@pliquidacionServicioId", SqlDbType.varchar, 20)
            prmParameter(2).Value = IIf(IsNothing(pLiquidacionServicio.liquidacionServicioId), "", pLiquidacionServicio.liquidacionServicioId)
            Try
                Using DSLiquidacionServicio
                    DSLiquidacionServicio = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionServicio_Sel", prmParameter)
                    If Not DSLiquidacionServicio Is Nothing Then
                        If DSLiquidacionServicio.Tables.Count > 0 Then
                            oLiquidacionServicio = New clsBE_LiquidacionServicio
                            If DSLiquidacionServicio.Tables(0).Rows.Count > 0 Then
                                With DSLiquidacionServicio.Tables(0).Rows(0)
                                    oLiquidacionServicio.contratoLoteId = .Item("contratoLoteId").tostring
                                    oLiquidacionServicio.liquidacionId = .Item("liquidacionId").tostring
                                    oLiquidacionServicio.importe = .Item("importe").tostring
                                    oLiquidacionServicio.codigoEstado = .Item("codigoEstado").tostring
                                    oLiquidacionServicio.uc = .Item("uc").tostring
                                    oLiquidacionServicio.fc = .Item("fc").tostring
                                    oLiquidacionServicio.codigoServicio = .Item("codigoServicio").tostring
                                    oLiquidacionServicio.descri = .Item("descri").tostring
                                    oLiquidacionServicio.liquidacionServicioId = .Item("liquidacionServicioId").tostring
                                    oLiquidacionServicio.nro = .Item("nro").tostring
                                    oLiquidacionServicio.codigoCalculoServicio = .Item("codigoCalculoServicio").tostring
                                End With
                            End If
                        End If
                    End If
                End Using
            Catch exSql As SqlException

            Catch ex As Exception
                Throw ex
            Finally
                If Not DSLiquidacionServicio Is Nothing Then
                    DSLiquidacionServicio.Dispose()
                End If
                DSLiquidacionServicio = Nothing
            End Try

            Return oLiquidacionServicio

        End Function


        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 21/04/2011 09:58:47 a.m.
        ''' Proposito: Obtiene la lista de registros
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaLiquidacionServicio() As List(Of clsBE_LiquidacionServicio)
            Dim olstLiquidacionServicio As New List(Of clsBE_LiquidacionServicio)
            Dim oLiquidacionServicio As clsBE_LiquidacionServicio = Nothing
            Dim mintItem As Integer = 0
            Try
                Using Reader As SqlDataReader = SqlHelper.ExecuteReader(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionServicio_Sellst")
                    If Reader.HasRows Then
                        While reader.Read
                            oLiquidacionServicio = New clsBE_LiquidacionServicio
                            mintItem += 1
                            With oLiquidacionServicio
                                .Item = mintItem

                                .contratoLoteId = Reader("contratoLoteId").tostring
                                .liquidacionId = Reader("liquidacionId").tostring
                                .importe = Reader("importe").tostring
                                .codigoEstado = Reader("codigoEstado").tostring
                                .uc = Reader("uc").tostring
                                .fc = Reader("fc").tostring
                                .um = Reader("um").tostring
                                .fm = Reader("fm").tostring
                                .codigoServicio = Reader("codigoServicio").tostring
                                .descri = Reader("descri").tostring
                                .liquidacionServicioId = Reader("liquidacionServicioId").tostring
                                .nro = Reader("nro").tostring
                                .codigoCalculoServicio = Reader("codigoCalculoServicio").tostring
                            End With
                            olstLiquidacionServicio.Add(oLiquidacionServicio)
                        End While
                    End If
                End Using
            Catch ex As Exception
                Throw ex
            End Try

            Return olstLiquidacionServicio

        End Function

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 21/04/2011 09:58:47 a.m.
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSLiquidacionServicio(ByVal pLiquidacionServicio As clsBE_LiquidacionServicio) As Dataset
            Dim oDSLiquidacionServicio As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(1) As SqlParameter
            prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
            prmParameter(0).Value = IIf(IsNothing(pLiquidacionServicio.contratoLoteId), "", pLiquidacionServicio.contratoLoteId)
            prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
            prmParameter(1).Value = IIf(IsNothing(pLiquidacionServicio.liquidacionId), "", pLiquidacionServicio.liquidacionId)
            Try

                Using oDSLiquidacionServicio
                    oDSLiquidacionServicio = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionServicio_Sellst", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionServicio_Sellst", oDSLiquidacionServicio, New String() {"LiquidacionServicio"}, prmParameter)
                    If Not oDSLiquidacionServicio Is Nothing Then
                        If oDSLiquidacionServicio.Tables.Count > 0 Then
                            'If oDSLiquidacionServicio.Tables("LiquidacionServicio").Rows.Count > 0 Then
                            If oDSLiquidacionServicio.Tables(0).Rows.Count > 0 Then
                                Return oDSLiquidacionServicio
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSLiquidacionServicio

        End Function

    
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 21/04/2011 09:58:47 a.m.
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function DefinirTablaLiquidacionServicio() As DataTable

            Try
                Dim DTLiquidacionServicio As New DataTable

                Dim contratoLoteId As DataColumn = DTLiquidacionServicio.Columns.Add("contratoLoteId", GetType(String))
                contratoLoteId.MaxLength = 20
                contratoLoteId.AllowDBNull = False
                contratoLoteId.DefaultValue = ""

                Dim liquidacionId As DataColumn = DTLiquidacionServicio.Columns.Add("liquidacionId", GetType(String))
                liquidacionId.MaxLength = 20
                liquidacionId.AllowDBNull = False
                liquidacionId.DefaultValue = ""

                Dim importe As DataColumn = DTLiquidacionServicio.Columns.Add("importe", GetType(Integer))
                importe.AllowDBNull = True
                importe.DefaultValue = 0


                Dim codigoEstado As DataColumn = DTLiquidacionServicio.Columns.Add("codigoEstado", GetType(String))
                codigoEstado.MaxLength = 15
                codigoEstado.AllowDBNull = True
                codigoEstado.DefaultValue = ""

                Dim uc As DataColumn = DTLiquidacionServicio.Columns.Add("uc", GetType(String))
                uc.MaxLength = 15
                uc.AllowDBNull = True
                uc.DefaultValue = ""

                Dim fc As DataColumn = DTLiquidacionServicio.Columns.Add("fc", GetType(DateTime))


                Dim um As DataColumn = DTLiquidacionServicio.Columns.Add("um", GetType(String))
                um.MaxLength = 15
                um.AllowDBNull = True
                um.DefaultValue = ""

                Dim fm As DataColumn = DTLiquidacionServicio.Columns.Add("fm", GetType(DateTime))


                Dim codigoServicio As DataColumn = DTLiquidacionServicio.Columns.Add("codigoServicio", GetType(String))
                codigoServicio.MaxLength = 15
                codigoServicio.AllowDBNull = True
                codigoServicio.DefaultValue = ""

                Dim descri As DataColumn = DTLiquidacionServicio.Columns.Add("descri", GetType(String))
                descri.MaxLength = 100
                descri.AllowDBNull = True
                descri.DefaultValue = ""

                Dim liquidacionServicioId As DataColumn = DTLiquidacionServicio.Columns.Add("liquidacionServicioId", GetType(String))
                liquidacionServicioId.MaxLength = 20
                liquidacionServicioId.AllowDBNull = False
                liquidacionServicioId.DefaultValue = ""

                Dim nro As DataColumn = DTLiquidacionServicio.Columns.Add("nro", GetType(Integer))
                nro.AllowDBNull = True
                nro.DefaultValue = 0


                Dim codigoCalculoServicio As DataColumn = DTLiquidacionServicio.Columns.Add("codigoCalculoServicio", GetType(String))
                codigoCalculoServicio.MaxLength = 15
                codigoCalculoServicio.AllowDBNull = True
                codigoCalculoServicio.DefaultValue = ""


                Dim indservicio As DataColumn = DTLiquidacionServicio.Columns.Add("indservicio", GetType(String))
                indservicio.MaxLength = 1
                indservicio.AllowDBNull = True
                indservicio.DefaultValue = ""

                Return DTLiquidacionServicio
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class
#End Region

End Namespace
