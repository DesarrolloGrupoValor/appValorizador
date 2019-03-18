


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
    ''' Fecha Creacion: 24/04/2011 08:52:29 a.m.
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla ValorizadorPenalizable
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsDB_ValorizadorPenalizableTX

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 24/04/2011 08:52:29 a.m.
        ''' Proposito: Metodo de Insercci?n de Datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function InsertarValorizadorPenalizable(ByVal oLstValorizadorPenalizable As List(Of clsBE_ValorizadorPenalizable)) As Boolean
            For Each oValorizadorPenalizable As clsBE_ValorizadorPenalizable In oLstValorizadorPenalizable
                Dim prmParameter(13) As SqlParameter

                prmParameter(0) = New SqlParameter("@pcodigoElemento", SqlDbType.varchar, 15)
                prmParameter(0).Value = IIf(IsNothing(oValorizadorPenalizable.codigoElemento), "", oValorizadorPenalizable.codigoElemento)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pminimo", SqlDbType.Float, 8)
                prmParameter(1).Value = IIf(IsNothing(oValorizadorPenalizable.minimo), 0, oValorizadorPenalizable.minimo)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@punidadPenalizable", SqlDbType.Float, 8)
                prmParameter(2).Value = IIf(IsNothing(oValorizadorPenalizable.unidadPenalizable), 0, oValorizadorPenalizable.unidadPenalizable)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@ppenalidad", SqlDbType.Float, 8)
                prmParameter(3).Value = IIf(IsNothing(oValorizadorPenalizable.penalidad), 0, oValorizadorPenalizable.penalidad)
                prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@pleyPenalizable", SqlDbType.Float, 8)
                prmParameter(4).Value = IIf(IsNothing(oValorizadorPenalizable.leyPenalizable), 0, oValorizadorPenalizable.leyPenalizable)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@pcalculoPenalizable", SqlDbType.Float, 8)
                prmParameter(5).Value = IIf(IsNothing(oValorizadorPenalizable.calculoPenalizable), 0, oValorizadorPenalizable.calculoPenalizable)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@pcodigoEstado", SqlDbType.varchar, 15)
                prmParameter(6).Value = IIf(IsNothing(oValorizadorPenalizable.codigoEstado), "", oValorizadorPenalizable.codigoEstado)
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7) = New SqlParameter("@puc", SqlDbType.varchar, 15)
                prmParameter(7).Value = IIf(IsNothing(oValorizadorPenalizable.uc), "", oValorizadorPenalizable.uc)
                prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(8) = New SqlParameter("@pliquidacionPenalizableId", SqlDbType.varchar, 20)
                prmParameter(8).Value = IIf(IsNothing(oValorizadorPenalizable.liquidacionPenalizableId), "", oValorizadorPenalizable.liquidacionPenalizableId)
                prmParameter(8).Direction = ParameterDirection.Input
                prmParameter(9) = New SqlParameter("@pmaximo", SqlDbType.Float, 8)
                prmParameter(9).Value = IIf(IsNothing(oValorizadorPenalizable.maximo), 0, oValorizadorPenalizable.maximo)
                prmParameter(9).Direction = ParameterDirection.Input
                prmParameter(10) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
                prmParameter(10).Value = IIf(IsNothing(oValorizadorPenalizable.contratoLoteId), "", oValorizadorPenalizable.contratoLoteId)
                prmParameter(10).Direction = ParameterDirection.Input
                prmParameter(11) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
                prmParameter(11).Value = IIf(IsNothing(oValorizadorPenalizable.liquidacionId), "", oValorizadorPenalizable.liquidacionId)
                prmParameter(11).Direction = ParameterDirection.Input
                prmParameter(12) = New SqlParameter("@ppreciounitario", SqlDbType.Float, 8)
                prmParameter(12).Value = IIf(IsNothing(oValorizadorPenalizable.preciounitario), 0, oValorizadorPenalizable.preciounitario)
                prmParameter(12).Direction = ParameterDirection.Input
                prmParameter(13) = New SqlParameter("@pindley", SqlDbType.VarChar, 15)
                prmParameter(13).Value = oValorizadorPenalizable.indLey

                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_ValorizadorPenalizable_Ins", prmParameter)
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
        ''' Fecha Creacion: 24/04/2011 08:52:29 a.m.
        ''' Proposito: Metodo de Modificacion de datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function ModificarValorizadorPenalizable(ByVal oLstValorizadorPenalizable As List(Of clsBE_ValorizadorPenalizable)) As Boolean
            For Each oValorizadorPenalizable As clsBE_ValorizadorPenalizable In oLstValorizadorPenalizable
                Dim prmParameter(14) As SqlParameter
                prmParameter(0) = New SqlParameter("@pcodigoElemento", SqlDbType.varchar, 15)
                prmParameter(0).Value = IIf(IsNothing(oValorizadorPenalizable.codigoElemento), "", oValorizadorPenalizable.codigoElemento)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pminimo", SqlDbType.Float, 8)
                prmParameter(1).Value = IIf(IsNothing(oValorizadorPenalizable.minimo), 0, oValorizadorPenalizable.minimo)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@punidadPenalizable", SqlDbType.Float, 8)
                prmParameter(2).Value = IIf(IsNothing(oValorizadorPenalizable.unidadPenalizable), 0, oValorizadorPenalizable.unidadPenalizable)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@ppenalidad", SqlDbType.Float, 8)
                prmParameter(3).Value = IIf(IsNothing(oValorizadorPenalizable.penalidad), 0, oValorizadorPenalizable.penalidad)
                prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@pleyPenalizable", SqlDbType.Float, 8)
                prmParameter(4).Value = IIf(IsNothing(oValorizadorPenalizable.leyPenalizable), 0, oValorizadorPenalizable.leyPenalizable)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@pcalculoPenalizable", SqlDbType.Float, 8)
                prmParameter(5).Value = IIf(IsNothing(oValorizadorPenalizable.calculoPenalizable), 0, oValorizadorPenalizable.calculoPenalizable)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@pcodigoEstado", SqlDbType.varchar, 15)
                prmParameter(6).Value = IIf(IsNothing(oValorizadorPenalizable.codigoEstado), "", oValorizadorPenalizable.codigoEstado)
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7) = New SqlParameter("@pum", SqlDbType.varchar, 15)
                prmParameter(7).Value = IIf(IsNothing(oValorizadorPenalizable.um), "", oValorizadorPenalizable.um)
                prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(8) = New SqlParameter("@pfm", SqlDbType.DateTime, 8)
                prmParameter(8).Value = clsUT_Funcion.FechaNull(oValorizadorPenalizable.fm)
                prmParameter(8).Direction = ParameterDirection.Input
                prmParameter(9) = New SqlParameter("@pliquidacionPenalizableId", SqlDbType.varchar, 20)
                prmParameter(9).Value = IIf(IsNothing(oValorizadorPenalizable.liquidacionPenalizableId), "", oValorizadorPenalizable.liquidacionPenalizableId)
                prmParameter(9).Direction = ParameterDirection.Input
                prmParameter(10) = New SqlParameter("@pmaximo", SqlDbType.Float, 8)
                prmParameter(10).Value = IIf(IsNothing(oValorizadorPenalizable.maximo), 0, oValorizadorPenalizable.maximo)
                prmParameter(10).Direction = ParameterDirection.Input
                prmParameter(11) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
                prmParameter(11).Value = IIf(IsNothing(oValorizadorPenalizable.contratoLoteId), "", oValorizadorPenalizable.contratoLoteId)
                prmParameter(11).Direction = ParameterDirection.Input
                prmParameter(12) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
                prmParameter(12).Value = IIf(IsNothing(oValorizadorPenalizable.liquidacionId), "", oValorizadorPenalizable.liquidacionId)
                prmParameter(12).Direction = ParameterDirection.Input
                prmParameter(13) = New SqlParameter("@ppreciounitario", SqlDbType.Float, 8)
                prmParameter(13).Value = IIf(IsNothing(oValorizadorPenalizable.preciounitario), 0, oValorizadorPenalizable.preciounitario)
                prmParameter(13).Direction = ParameterDirection.Input
                prmParameter(14) = New SqlParameter("@pindley", SqlDbType.VarChar, 15)
                prmParameter(14).Value = oValorizadorPenalizable.indLey
                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_ValorizadorPenalizable_Upd", prmParameter)
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
        ''' Fecha Creacion: 24/04/2011 08:52:29 a.m.
        ''' Proposito: Metodo de Elimacion
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function EliminarValorizadorPenalizable(ByVal oLstValorizadorPenalizable As List(Of clsBE_ValorizadorPenalizable)) As Boolean
            For Each oValorizadorPenalizable As clsBE_ValorizadorPenalizable In oLstValorizadorPenalizable
                Dim prmParameter(2) As SqlParameter
                prmParameter(0) = New SqlParameter("@pliquidacionPenalizableId", SqlDbType.varchar, 20)
                prmParameter(0).Value = IIf(IsNothing(oValorizadorPenalizable.liquidacionPenalizableId), "", oValorizadorPenalizable.liquidacionPenalizableId)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
                prmParameter(1).Value = IIf(IsNothing(oValorizadorPenalizable.contratoLoteId), "", oValorizadorPenalizable.contratoLoteId)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
                prmParameter(2).Value = IIf(IsNothing(oValorizadorPenalizable.liquidacionId), "", oValorizadorPenalizable.liquidacionId)
                prmParameter(2).Direction = ParameterDirection.Input
                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_ValorizadorPenalizable_Del", prmParameter)
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
        ''' Fecha Creacion: 24/04/2011 08:52:29 a.m.
        ''' Proposito: Metodo de Guardar Dataset
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function GuardarValorizadorPenalizable(ByVal oDSValorizadorPenalizable As Dataset) As Boolean
            Dim cnxCPO As New SqlConnection(CadenaConexion)


            Try
                Dim objCommnadInsert As New SqlCommand
                objCommnadInsert.Connection = cnxCPO
                objCommnadInsert.CommandText = "up_ValorizadorPenalizable_Ins"
                objCommnadInsert.CommandType = CommandType.StoredProcedure

                objCommnadInsert.Parameters.Add("@pcodigoElemento", SqlDbType.varchar, 15).SourceColumn = "codigoElemento"
                objCommnadInsert.Parameters.Add("@pminimo", SqlDbType.Float, 8).SourceColumn = "minimo"
                objCommnadInsert.Parameters.Add("@punidadPenalizable", SqlDbType.Float, 8).SourceColumn = "unidadPenalizable"
                objCommnadInsert.Parameters.Add("@ppenalidad", SqlDbType.Float, 8).SourceColumn = "penalidad"
                objCommnadInsert.Parameters.Add("@pleyPenalizable", SqlDbType.Float, 8).SourceColumn = "leyPenalizable"
                objCommnadInsert.Parameters.Add("@pcalculoPenalizable", SqlDbType.Float, 8).SourceColumn = "calculoPenalizable"
                objCommnadInsert.Parameters.Add("@pcodigoEstado", SqlDbType.varchar, 15).SourceColumn = "codigoEstado"
                objCommnadInsert.Parameters.Add("@puc", SqlDbType.varchar, 15).SourceColumn = "uc"
                objCommnadInsert.Parameters.Add("@pliquidacionPenalizableId", SqlDbType.varchar, 20).SourceColumn = "liquidacionPenalizableId"
                objCommnadInsert.Parameters.Add("@pmaximo", SqlDbType.Float, 8).SourceColumn = "maximo"
                objCommnadInsert.Parameters.Add("@pcontratoLoteId", SqlDbType.varchar, 20).SourceColumn = "contratoLoteId"
                objCommnadInsert.Parameters.Add("@pliquidacionId", SqlDbType.varchar, 20).SourceColumn = "liquidacionId"
                objCommnadInsert.Parameters.Add("@ppreciounitario", SqlDbType.Float, 8).SourceColumn = "preciounitario"

                Dim objCommandUpdate As New SqlCommand
                objCommandUpdate.Connection = cnxCPO
                objCommandUpdate.CommandText = "up_ValorizadorPenalizable_Upd"
                objCommandUpdate.CommandType = CommandType.StoredProcedure

                objCommandUpdate.Parameters.Add("@pcodigoElemento", SqlDbType.varchar, 15).SourceColumn = "codigoElemento"
                objCommandUpdate.Parameters.Add("@pminimo", SqlDbType.Float, 8).SourceColumn = "minimo"
                objCommandUpdate.Parameters.Add("@punidadPenalizable", SqlDbType.Float, 8).SourceColumn = "unidadPenalizable"
                objCommandUpdate.Parameters.Add("@ppenalidad", SqlDbType.Float, 8).SourceColumn = "penalidad"
                objCommandUpdate.Parameters.Add("@pleyPenalizable", SqlDbType.Float, 8).SourceColumn = "leyPenalizable"
                objCommandUpdate.Parameters.Add("@pcalculoPenalizable", SqlDbType.Float, 8).SourceColumn = "calculoPenalizable"
                objCommandUpdate.Parameters.Add("@pcodigoEstado", SqlDbType.varchar, 15).SourceColumn = "codigoEstado"
                objCommandUpdate.Parameters.Add("@pum", SqlDbType.varchar, 15).SourceColumn = "um"
                objCommandUpdate.Parameters.Add("@pfm", SqlDbType.DateTime, 8).SourceColumn = "fm"
                objCommandUpdate.Parameters.Add("@pliquidacionPenalizableId", SqlDbType.varchar, 20).SourceColumn = "liquidacionPenalizableId"
                objCommandUpdate.Parameters.Add("@pmaximo", SqlDbType.Float, 8).SourceColumn = "maximo"
                objCommandUpdate.Parameters.Add("@pcontratoLoteId", SqlDbType.varchar, 20).SourceColumn = "contratoLoteId"
                objCommandUpdate.Parameters.Add("@pliquidacionId", SqlDbType.varchar, 20).SourceColumn = "liquidacionId"
                objCommandUpdate.Parameters.Add("@ppreciounitario", SqlDbType.Float, 8).SourceColumn = "preciounitario"
                objCommandUpdate.Parameters.Add("@pindley", SqlDbType.VarChar, 15).SourceColumn = "indley"

                Dim objCommandDelete As New SqlCommand
                objCommandDelete.Connection = cnxCPO
                objCommandDelete.CommandText = "up_ValorizadorPenalizable_Del"
                objCommandDelete.CommandType = CommandType.StoredProcedure

                objCommandDelete.Parameters.Add("@pliquidacionPenalizableId", SqlDbType.varchar, 20).SourceColumn = "liquidacionPenalizableId"
                objCommandDelete.Parameters.Add("@pcontratoLoteId", SqlDbType.varchar, 20).SourceColumn = "contratoLoteId"
                objCommandDelete.Parameters.Add("@pliquidacionId", SqlDbType.varchar, 20).SourceColumn = "liquidacionId"

                'SqlHelper.UpdateDataset(objCommnadInsert, objCommandDelete, objCommandUpdate, oDSValorizadorPenalizable, "ValorizadorPenalizable")

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
    ''' Fecha Creacion: 24/04/2011 08:52:29 a.m.
    ''' Proposito: Obtiene los valores de la tabla ValorizadorPenalizable
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsDB_ValorizadorPenalizableRO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 24/04/2011 08:52:29 a.m.
        ''' Proposito: Lee los datos de un registro
        ''' Fecha Modificacion:
        ''' </summary>
        ''' 
        Public Function LeerValorizadorPenalizable(ByVal pValorizadorPenalizable As clsBE_ValorizadorPenalizable) As clsBE_ValorizadorPenalizable
            Dim oValorizadorPenalizable As clsBE_ValorizadorPenalizable = Nothing
            Dim DSValorizadorPenalizable As New DataSet
            Dim prmParameter(2) As SqlParameter
            prmParameter(0) = New SqlParameter("@pliquidacionPenalizableId", SqlDbType.varchar, 20)
            prmParameter(0).Value = IIf(IsNothing(pValorizadorPenalizable.liquidacionPenalizableId), "", pValorizadorPenalizable.liquidacionPenalizableId)
            prmParameter(1) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
            prmParameter(1).Value = IIf(IsNothing(pValorizadorPenalizable.contratoLoteId), "", pValorizadorPenalizable.contratoLoteId)
            prmParameter(2) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
            prmParameter(2).Value = IIf(IsNothing(pValorizadorPenalizable.liquidacionId), "", pValorizadorPenalizable.liquidacionId)
            Try
                Using DSValorizadorPenalizable
                    DSValorizadorPenalizable = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_ValorizadorPenalizable_Sel", prmParameter)
                    If Not DSValorizadorPenalizable Is Nothing Then
                        If DSValorizadorPenalizable.Tables.Count > 0 Then
                            oValorizadorPenalizable = New clsBE_ValorizadorPenalizable
                            If DSValorizadorPenalizable.Tables(0).Rows.Count > 0 Then
                                With DSValorizadorPenalizable.Tables(0).Rows(0)
                                    oValorizadorPenalizable.codigoElemento = .Item("codigoElemento").tostring
                                    oValorizadorPenalizable.minimo = .Item("minimo").tostring
                                    oValorizadorPenalizable.unidadPenalizable = .Item("unidadPenalizable").tostring
                                    oValorizadorPenalizable.penalidad = .Item("penalidad").tostring
                                    oValorizadorPenalizable.leyPenalizable = .Item("leyPenalizable").tostring
                                    oValorizadorPenalizable.calculoPenalizable = .Item("calculoPenalizable").tostring
                                    oValorizadorPenalizable.codigoEstado = .Item("codigoEstado").tostring
                                    oValorizadorPenalizable.uc = .Item("uc").tostring
                                    oValorizadorPenalizable.fc = .Item("fc").tostring
                                    oValorizadorPenalizable.liquidacionPenalizableId = .Item("liquidacionPenalizableId").tostring
                                    oValorizadorPenalizable.maximo = .Item("maximo").tostring
                                    oValorizadorPenalizable.contratoLoteId = .Item("contratoLoteId").tostring
                                    oValorizadorPenalizable.liquidacionId = .Item("liquidacionId").tostring
                                    oValorizadorPenalizable.preciounitario = .Item("preciounitario").ToString
                                    oValorizadorPenalizable.indLey = .Item("indley").ToString
                                End With
                            End If
                        End If
                    End If
                End Using
            Catch exSql As SqlException

            Catch ex As Exception
                Throw ex
            Finally
                If Not DSValorizadorPenalizable Is Nothing Then
                    DSValorizadorPenalizable.Dispose()
                End If
                DSValorizadorPenalizable = Nothing
            End Try

            Return oValorizadorPenalizable

        End Function


        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 24/04/2011 08:52:29 a.m.
        ''' Proposito: Obtiene la lista de registros
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaValorizadorPenalizable() As List(Of clsBE_ValorizadorPenalizable)
            Dim olstValorizadorPenalizable As New List(Of clsBE_ValorizadorPenalizable)
            Dim oValorizadorPenalizable As clsBE_ValorizadorPenalizable = Nothing
            Dim mintItem As Integer = 0
            Try
                Using Reader As SqlDataReader = SqlHelper.ExecuteReader(CadenaConexion, CommandType.StoredProcedure, "up_ValorizadorPenalizable_Sellst")
                    If Reader.HasRows Then
                        While reader.Read
                            oValorizadorPenalizable = New clsBE_ValorizadorPenalizable
                            mintItem += 1
                            With oValorizadorPenalizable
                                .Item = mintItem

                                .codigoElemento = Reader("codigoElemento").tostring
                                .minimo = Reader("minimo").tostring
                                .unidadPenalizable = Reader("unidadPenalizable").tostring
                                .penalidad = Reader("penalidad").tostring
                                .leyPenalizable = Reader("leyPenalizable").tostring
                                .calculoPenalizable = Reader("calculoPenalizable").tostring
                                .codigoEstado = Reader("codigoEstado").tostring
                                .uc = Reader("uc").tostring
                                .fc = Reader("fc").tostring
                                .um = Reader("um").tostring
                                .fm = Reader("fm").tostring
                                .liquidacionPenalizableId = Reader("liquidacionPenalizableId").tostring
                                .maximo = Reader("maximo").tostring
                                .contratoLoteId = Reader("contratoLoteId").tostring
                                .liquidacionId = Reader("liquidacionId").tostring
                                .preciounitario = Reader("preciounitario").ToString
                                .indLey = Reader("indley").ToString

                            End With
                            olstValorizadorPenalizable.Add(oValorizadorPenalizable)
                        End While
                    End If
                End Using
            Catch ex As Exception
                Throw ex
            End Try

            Return olstValorizadorPenalizable

        End Function

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 24/04/2011 08:52:29 a.m.
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSValorizadorPenalizable(ByVal pValorizadorPenalizable As clsBE_ValorizadorPenalizable) As Dataset
            Dim oDSValorizadorPenalizable As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(1) As SqlParameter
            prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
            prmParameter(0).Value = IIf(IsNothing(pValorizadorPenalizable.contratoLoteId), "", pValorizadorPenalizable.contratoLoteId)
            prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
            prmParameter(1).Value = IIf(IsNothing(pValorizadorPenalizable.liquidacionId), "", pValorizadorPenalizable.liquidacionId)
            Try

                Using oDSValorizadorPenalizable
                    oDSValorizadorPenalizable = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_ValorizadorPenalizable_Sellst_lista", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_ValorizadorPenalizable_Sellst", oDSValorizadorPenalizable, New String() {"ValorizadorPenalizable"}, prmParameter)
                    If Not oDSValorizadorPenalizable Is Nothing Then
                        If oDSValorizadorPenalizable.Tables.Count > 0 Then
                            'If oDSValorizadorPenalizable.Tables("ValorizadorPenalizable").Rows.Count > 0 Then
                            If oDSValorizadorPenalizable.Tables(0).Rows.Count > 0 Then
                                Return oDSValorizadorPenalizable
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSValorizadorPenalizable

        End Function


        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 24/04/2011 08:52:29 a.m.
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function DefinirTablaValorizadorPenalizable() As DataTable

            Try
                Dim DTValorizadorPenalizable As New DataTable

                Dim codigoElemento As DataColumn = DTValorizadorPenalizable.Columns.Add("codigoElemento", GetType(String))
                codigoElemento.MaxLength = 15
                codigoElemento.AllowDBNull = True
                codigoElemento.DefaultValue = ""

                Dim minimo As DataColumn = DTValorizadorPenalizable.Columns.Add("minimo", GetType(Decimal))
                minimo.AllowDBNull = True
                minimo.DefaultValue = 0.0


                Dim unidadPenalizable As DataColumn = DTValorizadorPenalizable.Columns.Add("unidadPenalizable", GetType(Decimal))
                unidadPenalizable.AllowDBNull = True
                unidadPenalizable.DefaultValue = 0.0


                Dim penalidad As DataColumn = DTValorizadorPenalizable.Columns.Add("penalidad", GetType(Decimal))
                penalidad.AllowDBNull = True
                penalidad.DefaultValue = 0.0

                Dim undpen As DataColumn = DTValorizadorPenalizable.Columns.Add("undpen", GetType(String))
                undpen.MaxLength = 15
                undpen.AllowDBNull = True
                undpen.DefaultValue = ""

                Dim leyPenalizable As DataColumn = DTValorizadorPenalizable.Columns.Add("leyPenalizable", GetType(Decimal))
                leyPenalizable.AllowDBNull = True
                leyPenalizable.DefaultValue = 0.0


                Dim calculoPenalizable As DataColumn = DTValorizadorPenalizable.Columns.Add("calculoPenalizable", GetType(Decimal))
                calculoPenalizable.AllowDBNull = True
                calculoPenalizable.DefaultValue = 0.0


                Dim codigoEstado As DataColumn = DTValorizadorPenalizable.Columns.Add("codigoEstado", GetType(String))
                codigoEstado.MaxLength = 15
                codigoEstado.AllowDBNull = True
                codigoEstado.DefaultValue = ""

                Dim uc As DataColumn = DTValorizadorPenalizable.Columns.Add("uc", GetType(String))
                uc.MaxLength = 15
                uc.AllowDBNull = True
                uc.DefaultValue = ""

                Dim fc As DataColumn = DTValorizadorPenalizable.Columns.Add("fc", GetType(DateTime))


                Dim um As DataColumn = DTValorizadorPenalizable.Columns.Add("um", GetType(String))
                um.MaxLength = 15
                um.AllowDBNull = True
                um.DefaultValue = ""

                Dim fm As DataColumn = DTValorizadorPenalizable.Columns.Add("fm", GetType(DateTime))


                Dim liquidacionPenalizableId As DataColumn = DTValorizadorPenalizable.Columns.Add("liquidacionPenalizableId", GetType(String))
                liquidacionPenalizableId.MaxLength = 20
                liquidacionPenalizableId.AllowDBNull = False
                liquidacionPenalizableId.DefaultValue = ""

                Dim maximo As DataColumn = DTValorizadorPenalizable.Columns.Add("maximo", GetType(Decimal))
                maximo.AllowDBNull = True
                maximo.DefaultValue = 0.0

                Dim undfactorp As DataColumn = DTValorizadorPenalizable.Columns.Add("undfactorp", GetType(String))
                undfactorp.MaxLength = 15
                undfactorp.AllowDBNull = True
                undfactorp.DefaultValue = ""

                Dim contratoLoteId As DataColumn = DTValorizadorPenalizable.Columns.Add("contratoLoteId", GetType(String))
                contratoLoteId.MaxLength = 20
                contratoLoteId.AllowDBNull = False
                contratoLoteId.DefaultValue = ""

                Dim liquidacionId As DataColumn = DTValorizadorPenalizable.Columns.Add("liquidacionId", GetType(String))
                liquidacionId.MaxLength = 20
                liquidacionId.AllowDBNull = False
                liquidacionId.DefaultValue = ""

                Dim preciounitario As DataColumn = DTValorizadorPenalizable.Columns.Add("preciounitario", GetType(Decimal))
                preciounitario.AllowDBNull = True
                preciounitario.DefaultValue = 0.0

                Dim indley As DataColumn = DTValorizadorPenalizable.Columns.Add("indley", GetType(String))
                indley.MaxLength = 15
                indley.AllowDBNull = False
                indley.DefaultValue = ""

                Return DTValorizadorPenalizable
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class
#End Region

End Namespace
