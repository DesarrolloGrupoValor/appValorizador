


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
    ''' Fecha Creacion: 21/04/2011 09:07:43 a.m.
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla LiquidacionDscto
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsDB_LiquidacionDsctoTX

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 21/04/2011 09:07:43 a.m.
        ''' Proposito: Metodo de Insercci?n de Datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function InsertarLiquidacionDscto(ByVal oLstLiquidacionDscto As List(Of clsBE_LiquidacionDscto)) As Boolean
            For Each oLiquidacionDscto As clsBE_LiquidacionDscto In oLstLiquidacionDscto
                Dim prmParameter(10) As SqlParameter

                prmParameter(0) = New SqlParameter("@pcodigoDscto", SqlDbType.varchar, 15)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacionDscto.codigoDscto), "", oLiquidacionDscto.codigoDscto)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pimporte", SqlDbType.Int, 8)
                prmParameter(1).Value = IIf(IsNothing(oLiquidacionDscto.importe), 0, oLiquidacionDscto.importe)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pdescri", SqlDbType.varchar, 100)
                prmParameter(2).Value = IIf(IsNothing(oLiquidacionDscto.descri), "", oLiquidacionDscto.descri)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@pcartaInstruccion", SqlDbType.varchar, 100)
                prmParameter(3).Value = IIf(IsNothing(oLiquidacionDscto.cartaInstruccion), "", oLiquidacionDscto.cartaInstruccion)
                prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@pobserva", SqlDbType.varchar, 100)
                prmParameter(4).Value = IIf(IsNothing(oLiquidacionDscto.observa), "", oLiquidacionDscto.observa)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@pcodigoEstado", SqlDbType.varchar, 15)
                prmParameter(5).Value = IIf(IsNothing(oLiquidacionDscto.codigoEstado), "", oLiquidacionDscto.codigoEstado)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@puc", SqlDbType.varchar, 15)
                prmParameter(6).Value = IIf(IsNothing(oLiquidacionDscto.uc), "", oLiquidacionDscto.uc)
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
                prmParameter(7).Value = IIf(IsNothing(oLiquidacionDscto.contratoLoteId), "", oLiquidacionDscto.contratoLoteId)
                prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(8) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
                prmParameter(8).Value = IIf(IsNothing(oLiquidacionDscto.liquidacionId), "", oLiquidacionDscto.liquidacionId)
                prmParameter(8).Direction = ParameterDirection.Input
                prmParameter(9) = New SqlParameter("@pliquidacionDsctoId", SqlDbType.varchar, 20)
                prmParameter(9).Value = IIf(IsNothing(oLiquidacionDscto.liquidacionDsctoId), "", oLiquidacionDscto.liquidacionDsctoId)
                prmParameter(9).Direction = ParameterDirection.Input
                prmParameter(10) = New SqlParameter("@pnro", SqlDbType.Int, 4)
                prmParameter(10).Value = IIf(IsNothing(oLiquidacionDscto.nro), 0, oLiquidacionDscto.nro)
                prmParameter(10).Direction = ParameterDirection.Input
                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionDscto_Ins", prmParameter)
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
        ''' Fecha Creacion: 21/04/2011 09:07:44 a.m.
        ''' Proposito: Metodo de Modificacion de datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function ModificarLiquidacionDscto(ByVal oLstLiquidacionDscto As List(Of clsBE_LiquidacionDscto)) As Boolean
            For Each oLiquidacionDscto As clsBE_LiquidacionDscto In oLstLiquidacionDscto
                Dim prmParameter(11) As SqlParameter
                prmParameter(0) = New SqlParameter("@pcodigoDscto", SqlDbType.varchar, 15)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacionDscto.codigoDscto), "", oLiquidacionDscto.codigoDscto)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pimporte", SqlDbType.Int, 8)
                prmParameter(1).Value = IIf(IsNothing(oLiquidacionDscto.importe), 0, oLiquidacionDscto.importe)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pdescri", SqlDbType.varchar, 100)
                prmParameter(2).Value = IIf(IsNothing(oLiquidacionDscto.descri), "", oLiquidacionDscto.descri)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@pcartaInstruccion", SqlDbType.varchar, 100)
                prmParameter(3).Value = IIf(IsNothing(oLiquidacionDscto.cartaInstruccion), "", oLiquidacionDscto.cartaInstruccion)
                prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@pobserva", SqlDbType.varchar, 100)
                prmParameter(4).Value = IIf(IsNothing(oLiquidacionDscto.observa), "", oLiquidacionDscto.observa)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@pcodigoEstado", SqlDbType.varchar, 15)
                prmParameter(5).Value = IIf(IsNothing(oLiquidacionDscto.codigoEstado), "", oLiquidacionDscto.codigoEstado)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@pum", SqlDbType.varchar, 15)
                prmParameter(6).Value = IIf(IsNothing(oLiquidacionDscto.um), "", oLiquidacionDscto.um)
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7) = New SqlParameter("@pfm", SqlDbType.DateTime, 8)
                prmParameter(7).Value = clsUT_Funcion.FechaNull(oLiquidacionDscto.fm)
                prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(8) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
                prmParameter(8).Value = IIf(IsNothing(oLiquidacionDscto.contratoLoteId), "", oLiquidacionDscto.contratoLoteId)
                prmParameter(8).Direction = ParameterDirection.Input
                prmParameter(9) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
                prmParameter(9).Value = IIf(IsNothing(oLiquidacionDscto.liquidacionId), "", oLiquidacionDscto.liquidacionId)
                prmParameter(9).Direction = ParameterDirection.Input
                prmParameter(10) = New SqlParameter("@pliquidacionDsctoId", SqlDbType.varchar, 20)
                prmParameter(10).Value = IIf(IsNothing(oLiquidacionDscto.liquidacionDsctoId), "", oLiquidacionDscto.liquidacionDsctoId)
                prmParameter(10).Direction = ParameterDirection.Input
                prmParameter(11) = New SqlParameter("@pnro", SqlDbType.Int, 4)
                prmParameter(11).Value = IIf(IsNothing(oLiquidacionDscto.nro), 0, oLiquidacionDscto.nro)
                prmParameter(11).Direction = ParameterDirection.Input
                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionDscto_Upd", prmParameter)
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
        ''' Fecha Creacion: 21/04/2011 09:07:44 a.m.
        ''' Proposito: Metodo de Elimacion
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function EliminarLiquidacionDscto(ByVal oLstLiquidacionDscto As List(Of clsBE_LiquidacionDscto)) As Boolean
            For Each oLiquidacionDscto As clsBE_LiquidacionDscto In oLstLiquidacionDscto
                Dim prmParameter(2) As SqlParameter
                prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacionDscto.contratoLoteId), "", oLiquidacionDscto.contratoLoteId)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
                prmParameter(1).Value = IIf(IsNothing(oLiquidacionDscto.liquidacionId), "", oLiquidacionDscto.liquidacionId)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pliquidacionDsctoId", SqlDbType.varchar, 20)
                prmParameter(2).Value = IIf(IsNothing(oLiquidacionDscto.liquidacionDsctoId), "", oLiquidacionDscto.liquidacionDsctoId)
                prmParameter(2).Direction = ParameterDirection.Input
                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionDscto_Del", prmParameter)
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
        ''' Fecha Creacion: 21/04/2011 09:07:44 a.m.
        ''' Proposito: Metodo de Guardar Dataset
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function GuardarLiquidacionDscto(ByVal oDSLiquidacionDscto As Dataset) As Boolean
            Dim cnxCPO As New SqlConnection(CadenaConexion)


            Try
                Dim objCommnadInsert As New SqlCommand
                objCommnadInsert.Connection = cnxCPO
                objCommnadInsert.CommandText = "up_LiquidacionDscto_Ins"
                objCommnadInsert.CommandType = CommandType.StoredProcedure

                objCommnadInsert.Parameters.Add("@pcodigoDscto", SqlDbType.varchar, 15).SourceColumn = "codigoDscto"
                objCommnadInsert.Parameters.Add("@pimporte", SqlDbType.Int, 8).SourceColumn = "importe"
                objCommnadInsert.Parameters.Add("@pdescri", SqlDbType.varchar, 100).SourceColumn = "descri"
                objCommnadInsert.Parameters.Add("@pcartaInstruccion", SqlDbType.varchar, 100).SourceColumn = "cartaInstruccion"
                objCommnadInsert.Parameters.Add("@pobserva", SqlDbType.varchar, 100).SourceColumn = "observa"
                objCommnadInsert.Parameters.Add("@pcodigoEstado", SqlDbType.varchar, 15).SourceColumn = "codigoEstado"
                objCommnadInsert.Parameters.Add("@puc", SqlDbType.varchar, 15).SourceColumn = "uc"
                objCommnadInsert.Parameters.Add("@pcontratoLoteId", SqlDbType.varchar, 20).SourceColumn = "contratoLoteId"
                objCommnadInsert.Parameters.Add("@pliquidacionId", SqlDbType.varchar, 20).SourceColumn = "liquidacionId"
                objCommnadInsert.Parameters.Add("@pliquidacionDsctoId", SqlDbType.varchar, 20).SourceColumn = "liquidacionDsctoId"
                objCommnadInsert.Parameters.Add("@pnro", SqlDbType.Int, 4).SourceColumn = "nro"

                Dim objCommandUpdate As New SqlCommand
                objCommandUpdate.Connection = cnxCPO
                objCommandUpdate.CommandText = "up_LiquidacionDscto_Upd"
                objCommandUpdate.CommandType = CommandType.StoredProcedure

                objCommandUpdate.Parameters.Add("@pcodigoDscto", SqlDbType.varchar, 15).SourceColumn = "codigoDscto"
                objCommandUpdate.Parameters.Add("@pimporte", SqlDbType.Int, 8).SourceColumn = "importe"
                objCommandUpdate.Parameters.Add("@pdescri", SqlDbType.varchar, 100).SourceColumn = "descri"
                objCommandUpdate.Parameters.Add("@pcartaInstruccion", SqlDbType.varchar, 100).SourceColumn = "cartaInstruccion"
                objCommandUpdate.Parameters.Add("@pobserva", SqlDbType.varchar, 100).SourceColumn = "observa"
                objCommandUpdate.Parameters.Add("@pcodigoEstado", SqlDbType.varchar, 15).SourceColumn = "codigoEstado"
                objCommandUpdate.Parameters.Add("@pum", SqlDbType.varchar, 15).SourceColumn = "um"
                objCommandUpdate.Parameters.Add("@pfm", SqlDbType.DateTime, 8).SourceColumn = "fm"
                objCommandUpdate.Parameters.Add("@pcontratoLoteId", SqlDbType.varchar, 20).SourceColumn = "contratoLoteId"
                objCommandUpdate.Parameters.Add("@pliquidacionId", SqlDbType.varchar, 20).SourceColumn = "liquidacionId"
                objCommandUpdate.Parameters.Add("@pliquidacionDsctoId", SqlDbType.varchar, 20).SourceColumn = "liquidacionDsctoId"
                objCommandUpdate.Parameters.Add("@pnro", SqlDbType.Int, 4).SourceColumn = "nro"

                Dim objCommandDelete As New SqlCommand
                objCommandDelete.Connection = cnxCPO
                objCommandDelete.CommandText = "up_LiquidacionDscto_Del"
                objCommandDelete.CommandType = CommandType.StoredProcedure

                objCommandDelete.Parameters.Add("@pcontratoLoteId", SqlDbType.varchar, 20).SourceColumn = "contratoLoteId"
                objCommandDelete.Parameters.Add("@pliquidacionId", SqlDbType.varchar, 20).SourceColumn = "liquidacionId"
                objCommandDelete.Parameters.Add("@pliquidacionDsctoId", SqlDbType.varchar, 20).SourceColumn = "liquidacionDsctoId"

                'SqlHelper.UpdateDataset(objCommnadInsert, objCommandDelete, objCommandUpdate, oDSLiquidacionDscto, "LiquidacionDscto")

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
    ''' Fecha Creacion: 21/04/2011 09:07:44 a.m.
    ''' Proposito: Obtiene los valores de la tabla LiquidacionDscto
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsDB_LiquidacionDsctoRO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 21/04/2011 09:07:44 a.m.
        ''' Proposito: Lee los datos de un registro
        ''' Fecha Modificacion:
        ''' </summary>
        ''' 
        Public Function LeerLiquidacionDscto(ByVal pLiquidacionDscto As clsBE_LiquidacionDscto) As clsBE_LiquidacionDscto
            Dim oLiquidacionDscto As clsBE_LiquidacionDscto = Nothing
            Dim DSLiquidacionDscto As New DataSet
            Dim prmParameter(2) As SqlParameter
            prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
            prmParameter(0).Value = IIf(IsNothing(pLiquidacionDscto.contratoLoteId), "", pLiquidacionDscto.contratoLoteId)
            prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
            prmParameter(1).Value = IIf(IsNothing(pLiquidacionDscto.liquidacionId), "", pLiquidacionDscto.liquidacionId)
            prmParameter(2) = New SqlParameter("@pliquidacionDsctoId", SqlDbType.varchar, 20)
            prmParameter(2).Value = IIf(IsNothing(pLiquidacionDscto.liquidacionDsctoId), "", pLiquidacionDscto.liquidacionDsctoId)
            Try
                Using DSLiquidacionDscto
                    DSLiquidacionDscto = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionDscto_Sel", prmParameter)
                    If Not DSLiquidacionDscto Is Nothing Then
                        If DSLiquidacionDscto.Tables.Count > 0 Then
                            oLiquidacionDscto = New clsBE_LiquidacionDscto
                            If DSLiquidacionDscto.Tables(0).Rows.Count > 0 Then
                                With DSLiquidacionDscto.Tables(0).Rows(0)
                                    oLiquidacionDscto.codigoDscto = .Item("codigoDscto").tostring
                                    oLiquidacionDscto.importe = .Item("importe").tostring
                                    oLiquidacionDscto.descri = .Item("descri").tostring
                                    oLiquidacionDscto.cartaInstruccion = .Item("cartaInstruccion").tostring
                                    oLiquidacionDscto.observa = .Item("observa").tostring
                                    oLiquidacionDscto.codigoEstado = .Item("codigoEstado").tostring
                                    oLiquidacionDscto.uc = .Item("uc").tostring
                                    oLiquidacionDscto.fc = .Item("fc").tostring
                                    oLiquidacionDscto.contratoLoteId = .Item("contratoLoteId").tostring
                                    oLiquidacionDscto.liquidacionId = .Item("liquidacionId").tostring
                                    oLiquidacionDscto.liquidacionDsctoId = .Item("liquidacionDsctoId").tostring
                                    oLiquidacionDscto.nro = .Item("nro").tostring
                                End With
                            End If
                        End If
                    End If
                End Using
            Catch exSql As SqlException

            Catch ex As Exception
                Throw ex
            Finally
                If Not DSLiquidacionDscto Is Nothing Then
                    DSLiquidacionDscto.Dispose()
                End If
                DSLiquidacionDscto = Nothing
            End Try

            Return oLiquidacionDscto

        End Function


        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 21/04/2011 09:07:44 a.m.
        ''' Proposito: Obtiene la lista de registros
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaLiquidacionDscto() As List(Of clsBE_LiquidacionDscto)
            Dim olstLiquidacionDscto As New List(Of clsBE_LiquidacionDscto)
            Dim oLiquidacionDscto As clsBE_LiquidacionDscto = Nothing
            Dim mintItem As Integer = 0
            Try
                Using Reader As SqlDataReader = SqlHelper.ExecuteReader(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionDscto_Sellst")
                    If Reader.HasRows Then
                        While reader.Read
                            oLiquidacionDscto = New clsBE_LiquidacionDscto
                            mintItem += 1
                            With oLiquidacionDscto
                                .Item = mintItem

                                .codigoDscto = Reader("codigoDscto").tostring
                                .importe = Reader("importe").tostring
                                .descri = Reader("descri").tostring
                                .cartaInstruccion = Reader("cartaInstruccion").tostring
                                .observa = Reader("observa").tostring
                                .codigoEstado = Reader("codigoEstado").tostring
                                .uc = Reader("uc").tostring
                                .fc = Reader("fc").tostring
                                .um = Reader("um").tostring
                                .fm = Reader("fm").tostring
                                .contratoLoteId = Reader("contratoLoteId").tostring
                                .liquidacionId = Reader("liquidacionId").tostring
                                .liquidacionDsctoId = Reader("liquidacionDsctoId").tostring
                                .nro = Reader("nro").tostring
                            End With
                            olstLiquidacionDscto.Add(oLiquidacionDscto)
                        End While
                    End If
                End Using
            Catch ex As Exception
                Throw ex
            End Try

            Return olstLiquidacionDscto

        End Function

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 21/04/2011 09:07:44 a.m.
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSLiquidacionDscto(ByVal pLiquidacionDscto As clsBE_LiquidacionDscto) As Dataset
            Dim oDSLiquidacionDscto As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(2) As SqlParameter
            prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
            prmParameter(0).Value = IIf(IsNothing(pLiquidacionDscto.contratoLoteId), "", pLiquidacionDscto.contratoLoteId)
            prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
            prmParameter(1).Value = IIf(IsNothing(pLiquidacionDscto.liquidacionId), "", pLiquidacionDscto.liquidacionId)

            prmParameter(2) = New SqlParameter("@codigoDscto", SqlDbType.VarChar, 20)
            prmParameter(2).Value = IIf(IsNothing(pLiquidacionDscto.codigoDscto), "", pLiquidacionDscto.codigoDscto)
            Try

                Using oDSLiquidacionDscto
                    oDSLiquidacionDscto = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionDscto_Sellst", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionDscto_Sellst", oDSLiquidacionDscto, New String() {"LiquidacionDscto"}, prmParameter)
                    If Not oDSLiquidacionDscto Is Nothing Then
                        If oDSLiquidacionDscto.Tables.Count > 0 Then
                            'If oDSLiquidacionDscto.Tables("LiquidacionDscto").Rows.Count > 0 Then
                            If oDSLiquidacionDscto.Tables(0).Rows.Count > 0 Then
                                Return oDSLiquidacionDscto
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSLiquidacionDscto

        End Function


        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 21/04/2011 09:07:44 a.m.
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function DefinirTablaLiquidacionDscto() As DataTable

            Try
                Dim DTLiquidacionDscto As New DataTable

                Dim codigoDscto As DataColumn = DTLiquidacionDscto.Columns.Add("codigoDscto", GetType(String))
                codigoDscto.MaxLength = 15
                codigoDscto.AllowDBNull = True
                codigoDscto.DefaultValue = ""

                Dim importe As DataColumn = DTLiquidacionDscto.Columns.Add("importe", GetType(Integer))
                importe.AllowDBNull = True
                importe.DefaultValue = 0


                Dim descri As DataColumn = DTLiquidacionDscto.Columns.Add("descri", GetType(String))
                descri.MaxLength = 100
                descri.AllowDBNull = True
                descri.DefaultValue = ""

                Dim cartaInstruccion As DataColumn = DTLiquidacionDscto.Columns.Add("cartaInstruccion", GetType(String))
                cartaInstruccion.MaxLength = 100
                cartaInstruccion.AllowDBNull = True
                cartaInstruccion.DefaultValue = ""

                Dim observa As DataColumn = DTLiquidacionDscto.Columns.Add("observa", GetType(String))
                observa.MaxLength = 100
                observa.AllowDBNull = True
                observa.DefaultValue = ""

                Dim codigoEstado As DataColumn = DTLiquidacionDscto.Columns.Add("codigoEstado", GetType(String))
                codigoEstado.MaxLength = 15
                codigoEstado.AllowDBNull = True
                codigoEstado.DefaultValue = ""

                Dim uc As DataColumn = DTLiquidacionDscto.Columns.Add("uc", GetType(String))
                uc.MaxLength = 15
                uc.AllowDBNull = True
                uc.DefaultValue = ""

                Dim fc As DataColumn = DTLiquidacionDscto.Columns.Add("fc", GetType(DateTime))


                Dim um As DataColumn = DTLiquidacionDscto.Columns.Add("um", GetType(String))
                um.MaxLength = 15
                um.AllowDBNull = True
                um.DefaultValue = ""

                Dim fm As DataColumn = DTLiquidacionDscto.Columns.Add("fm", GetType(DateTime))


                Dim contratoLoteId As DataColumn = DTLiquidacionDscto.Columns.Add("contratoLoteId", GetType(String))
                contratoLoteId.MaxLength = 20
                contratoLoteId.AllowDBNull = False
                contratoLoteId.DefaultValue = ""

                Dim liquidacionId As DataColumn = DTLiquidacionDscto.Columns.Add("liquidacionId", GetType(String))
                liquidacionId.MaxLength = 20
                liquidacionId.AllowDBNull = False
                liquidacionId.DefaultValue = ""

                Dim liquidacionDsctoId As DataColumn = DTLiquidacionDscto.Columns.Add("liquidacionDsctoId", GetType(String))
                liquidacionDsctoId.MaxLength = 20
                liquidacionDsctoId.AllowDBNull = False
                liquidacionDsctoId.DefaultValue = ""

                Dim nro As DataColumn = DTLiquidacionDscto.Columns.Add("nro", GetType(Integer))
                nro.AllowDBNull = True
                nro.DefaultValue = 0


                Return DTLiquidacionDscto
            Catch ex As Exception
                Throw ex
            End Try
        End Function




        ''' <summary>
        ''' Escrito por: Lissete Miyahira
        ''' Fecha Creacion: 20/09/2012
        ''' Proposito: Obtiene las provisiones
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function ObtenerProvisionalDscto(ByVal pLiquidacionDscto As clsBE_LiquidacionDscto) As DataSet
            Dim oDSLiquidacionDscto As New DataSet
            'Dim mintItem As Integer = 0
            Dim prmParameter(0) As SqlParameter
            prmParameter(0) = New SqlParameter("@contratoLoteId", SqlDbType.VarChar, 20)
            prmParameter(0).Value = IIf(IsNothing(pLiquidacionDscto.contratoLoteId), "", pLiquidacionDscto.contratoLoteId)
            Try

                Using oDSLiquidacionDscto
                    oDSLiquidacionDscto = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_tbLotesValorizados_ProvisionalDscto", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionDscto_Sellst", oDSLiquidacionDscto, New String() {"LiquidacionDscto"}, prmParameter)
                    If Not oDSLiquidacionDscto Is Nothing Then
                        If oDSLiquidacionDscto.Tables.Count > 0 Then
                            'If oDSLiquidacionDscto.Tables("LiquidacionDscto").Rows.Count > 0 Then
                            If oDSLiquidacionDscto.Tables(0).Rows.Count > 0 Then
                                Return oDSLiquidacionDscto
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSLiquidacionDscto

        End Function


    End Class
#End Region

End Namespace
