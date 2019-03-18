


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
    ''' Fecha Creacion: 24/04/2011 08:52:59 a.m.
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla ValorizadorPagable
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsDB_ValorizadorPagableTX

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 24/04/2011 08:52:59 a.m.
        ''' Proposito: Metodo de Insercci?n de Datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function InsertarValorizadorPagable(ByVal oLstValorizadorPagable As List(Of clsBE_ValorizadorPagable)) As Boolean
            For Each oValorizadorPagable As clsBE_ValorizadorPagable In oLstValorizadorPagable
                Dim prmParameter(20) As SqlParameter

                prmParameter(0) = New SqlParameter("@pcodigoElemento", SqlDbType.varchar, 15)
                prmParameter(0).Value = IIf(IsNothing(oValorizadorPagable.codigoElemento), "", oValorizadorPagable.codigoElemento)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@ppagable", SqlDbType.Float, 8)
                prmParameter(1).Value = IIf(IsNothing(oValorizadorPagable.pagable), 0, oValorizadorPagable.pagable)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pdeduccion", SqlDbType.Float, 8)
                prmParameter(2).Value = IIf(IsNothing(oValorizadorPagable.deduccion), 0, oValorizadorPagable.deduccion)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@prefinacion", SqlDbType.Float, 8)
                prmParameter(3).Value = IIf(IsNothing(oValorizadorPagable.refinacion), 0, oValorizadorPagable.refinacion)
                prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@pproteccion", SqlDbType.Float, 8)
                prmParameter(4).Value = IIf(IsNothing(oValorizadorPagable.proteccion), 0, oValorizadorPagable.proteccion)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@pcodigoMercado", SqlDbType.varchar, 15)
                prmParameter(5).Value = IIf(IsNothing(oValorizadorPagable.codigoMercado), "", oValorizadorPagable.codigoMercado)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@pqpInicio", SqlDbType.DateTime, 8)
                prmParameter(6).Value = clsUT_Funcion.FechaNull(oValorizadorPagable.qpInicio)
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7) = New SqlParameter("@pqpFinal", SqlDbType.DateTime, 8)
                prmParameter(7).Value = clsUT_Funcion.FechaNull(oValorizadorPagable.qpFinal)
                prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(8) = New SqlParameter("@pleyPagable", SqlDbType.Float, 8)
                prmParameter(8).Value = IIf(IsNothing(oValorizadorPagable.leyPagable), 0, oValorizadorPagable.leyPagable)
                prmParameter(8).Direction = ParameterDirection.Input
                prmParameter(9) = New SqlParameter("@pprecio", SqlDbType.Float, 8)
                prmParameter(9).Value = IIf(IsNothing(oValorizadorPagable.precio), 0, oValorizadorPagable.precio)
                prmParameter(9).Direction = ParameterDirection.Input
                prmParameter(10) = New SqlParameter("@pcodigoEstado", SqlDbType.varchar, 15)
                prmParameter(10).Value = IIf(IsNothing(oValorizadorPagable.codigoEstado), "", oValorizadorPagable.codigoEstado)
                prmParameter(10).Direction = ParameterDirection.Input
                prmParameter(11) = New SqlParameter("@puc", SqlDbType.varchar, 15)
                prmParameter(11).Value = IIf(IsNothing(oValorizadorPagable.uc), "", oValorizadorPagable.uc)
                prmParameter(11).Direction = ParameterDirection.Input
                prmParameter(12) = New SqlParameter("@pliquidacionPagable", SqlDbType.varchar, 20)
                prmParameter(12).Value = IIf(IsNothing(oValorizadorPagable.liquidacionPagable), "", oValorizadorPagable.liquidacionPagable)
                prmParameter(12).Direction = ParameterDirection.Input
                prmParameter(13) = New SqlParameter("@pcodigoDeduccion", SqlDbType.varchar, 15)
                prmParameter(13).Value = IIf(IsNothing(oValorizadorPagable.codigoDeduccion), "", oValorizadorPagable.codigoDeduccion)
                prmParameter(13).Direction = ParameterDirection.Input
                prmParameter(14) = New SqlParameter("@pcalculoPagable", SqlDbType.Float, 8)
                prmParameter(14).Value = IIf(IsNothing(oValorizadorPagable.calculoPagable), 0, oValorizadorPagable.calculoPagable)
                prmParameter(14).Direction = ParameterDirection.Input
                prmParameter(15) = New SqlParameter("@pcodigoQp", SqlDbType.varchar, 15)
                prmParameter(15).Value = IIf(IsNothing(oValorizadorPagable.codigoQp), "", oValorizadorPagable.codigoQp)
                prmParameter(15).Direction = ParameterDirection.Input
                prmParameter(16) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
                prmParameter(16).Value = IIf(IsNothing(oValorizadorPagable.contratoLoteId), "", oValorizadorPagable.contratoLoteId)
                prmParameter(16).Direction = ParameterDirection.Input
                prmParameter(17) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
                prmParameter(17).Value = IIf(IsNothing(oValorizadorPagable.liquidacionId), "", oValorizadorPagable.liquidacionId)
                prmParameter(17).Direction = ParameterDirection.Input
                prmParameter(18) = New SqlParameter("@pleymin", SqlDbType.Float, 8)
                prmParameter(18).Value = IIf(IsNothing(oValorizadorPagable.leymin), 0, oValorizadorPagable.leymin)
                prmParameter(18).Direction = ParameterDirection.Input
                prmParameter(19) = New SqlParameter("@pleymax", SqlDbType.Float, 8)
                prmParameter(19).Value = IIf(IsNothing(oValorizadorPagable.leymax), 0, oValorizadorPagable.leymax)
                prmParameter(19).Direction = ParameterDirection.Input
                prmParameter(20) = New SqlParameter("@ppreciounitario", SqlDbType.Float, 8)
                prmParameter(20).Value = IIf(IsNothing(oValorizadorPagable.preciounitario), 0, oValorizadorPagable.preciounitario)
                prmParameter(20).Direction = ParameterDirection.Input
                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_ValorizadorPagable_Ins", prmParameter)
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
        ''' Fecha Creacion: 24/04/2011 08:52:59 a.m.
        ''' Proposito: Metodo de Modificacion de datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function ModificarValorizadorPagable(ByVal oLstValorizadorPagable As List(Of clsBE_ValorizadorPagable)) As Boolean
            For Each oValorizadorPagable As clsBE_ValorizadorPagable In oLstValorizadorPagable
                Dim prmParameter(25) As SqlParameter
                prmParameter(0) = New SqlParameter("@pcodigoElemento", SqlDbType.varchar, 15)
                prmParameter(0).Value = IIf(IsNothing(oValorizadorPagable.codigoElemento), "", oValorizadorPagable.codigoElemento)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@ppagable", SqlDbType.Float, 8)
                prmParameter(1).Value = IIf(IsNothing(oValorizadorPagable.pagable), 0, oValorizadorPagable.pagable)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pdeduccion", SqlDbType.Float, 8)
                prmParameter(2).Value = IIf(IsNothing(oValorizadorPagable.deduccion), 0, oValorizadorPagable.deduccion)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@prefinacion", SqlDbType.Float, 8)
                prmParameter(3).Value = IIf(IsNothing(oValorizadorPagable.refinacion), 0, oValorizadorPagable.refinacion)
                prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@pproteccion", SqlDbType.Float, 8)
                prmParameter(4).Value = IIf(IsNothing(oValorizadorPagable.proteccion), 0, oValorizadorPagable.proteccion)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@pcodigoMercado", SqlDbType.varchar, 15)
                prmParameter(5).Value = IIf(IsNothing(oValorizadorPagable.codigoMercado), "", oValorizadorPagable.codigoMercado)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@pqpInicio", SqlDbType.DateTime, 8)
                prmParameter(6).Value = clsUT_Funcion.FechaNull(oValorizadorPagable.qpInicio)
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7) = New SqlParameter("@pqpFinal", SqlDbType.DateTime, 8)
                prmParameter(7).Value = clsUT_Funcion.FechaNull(oValorizadorPagable.qpFinal)
                prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(8) = New SqlParameter("@pleyPagable", SqlDbType.Float, 8)
                prmParameter(8).Value = IIf(IsNothing(oValorizadorPagable.leyPagable), 0, oValorizadorPagable.leyPagable)
                prmParameter(8).Direction = ParameterDirection.Input
                prmParameter(9) = New SqlParameter("@pprecio", SqlDbType.Float, 8)
                prmParameter(9).Value = IIf(IsNothing(oValorizadorPagable.precio), 0, oValorizadorPagable.precio)
                prmParameter(9).Direction = ParameterDirection.Input
                prmParameter(10) = New SqlParameter("@pcodigoEstado", SqlDbType.varchar, 15)
                prmParameter(10).Value = IIf(IsNothing(oValorizadorPagable.codigoEstado), "", oValorizadorPagable.codigoEstado)
                prmParameter(10).Direction = ParameterDirection.Input
                prmParameter(11) = New SqlParameter("@pum", SqlDbType.varchar, 15)
                prmParameter(11).Value = IIf(IsNothing(oValorizadorPagable.um), "", oValorizadorPagable.um)
                prmParameter(11).Direction = ParameterDirection.Input
                prmParameter(12) = New SqlParameter("@pfm", SqlDbType.DateTime, 8)
                prmParameter(12).Value = clsUT_Funcion.FechaNull(oValorizadorPagable.fm)
                prmParameter(12).Direction = ParameterDirection.Input
                prmParameter(13) = New SqlParameter("@pliquidacionPagable", SqlDbType.varchar, 20)
                prmParameter(13).Value = IIf(IsNothing(oValorizadorPagable.liquidacionPagable), "", oValorizadorPagable.liquidacionPagable)
                prmParameter(13).Direction = ParameterDirection.Input
                prmParameter(14) = New SqlParameter("@pcodigoDeduccion", SqlDbType.varchar, 15)
                prmParameter(14).Value = IIf(IsNothing(oValorizadorPagable.codigoDeduccion), "", oValorizadorPagable.codigoDeduccion)
                prmParameter(14).Direction = ParameterDirection.Input
                prmParameter(15) = New SqlParameter("@pcalculoPagable", SqlDbType.Float, 8)
                prmParameter(15).Value = IIf(IsNothing(oValorizadorPagable.calculoPagable), 0, oValorizadorPagable.calculoPagable)
                prmParameter(15).Direction = ParameterDirection.Input
                prmParameter(16) = New SqlParameter("@pcodigoQp", SqlDbType.varchar, 15)
                prmParameter(16).Value = IIf(IsNothing(oValorizadorPagable.codigoQp), "", oValorizadorPagable.codigoQp)
                prmParameter(16).Direction = ParameterDirection.Input
                prmParameter(17) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
                prmParameter(17).Value = IIf(IsNothing(oValorizadorPagable.contratoLoteId), "", oValorizadorPagable.contratoLoteId)
                prmParameter(17).Direction = ParameterDirection.Input
                prmParameter(18) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
                prmParameter(18).Value = IIf(IsNothing(oValorizadorPagable.liquidacionId), "", oValorizadorPagable.liquidacionId)
                prmParameter(18).Direction = ParameterDirection.Input
                prmParameter(19) = New SqlParameter("@pleymin", SqlDbType.Float, 8)
                prmParameter(19).Value = IIf(IsNothing(oValorizadorPagable.leymin), 0, oValorizadorPagable.leymin)
                prmParameter(19).Direction = ParameterDirection.Input
                prmParameter(20) = New SqlParameter("@pleymax", SqlDbType.Float, 8)
                prmParameter(20).Value = IIf(IsNothing(oValorizadorPagable.leymax), 0, oValorizadorPagable.leymax)
                prmParameter(20).Direction = ParameterDirection.Input
                prmParameter(21) = New SqlParameter("@ppreciounitario", SqlDbType.Float, 8)
                prmParameter(21).Value = IIf(IsNothing(oValorizadorPagable.preciounitario), 0, oValorizadorPagable.preciounitario)
                prmParameter(21).Direction = ParameterDirection.Input
                prmParameter(22) = New SqlParameter("@pcodigoqpajuste", SqlDbType.VarChar, 15)
                prmParameter(22).Value = IIf(IsNothing(oValorizadorPagable.codigoQpAjuste), "", oValorizadorPagable.codigoQpAjuste)
                prmParameter(22).Direction = ParameterDirection.Input
                prmParameter(23) = New SqlParameter("@pindley", SqlDbType.VarChar, 15)
                prmParameter(23).Value = oValorizadorPagable.finLey

                'prmParameter(23).Direction = ParameterDirection.Input
                prmParameter(24) = New SqlParameter("@pindpre", SqlDbType.VarChar, 15)
                prmParameter(24).Value = oValorizadorPagable.finPrecio

                prmParameter(25) = New SqlParameter("@pprotCont", SqlDbType.Float, 8)
                prmParameter(25).Value = IIf(IsNothing(oValorizadorPagable.protCont), 0, oValorizadorPagable.protCont)
                prmParameter(25).Direction = ParameterDirection.Input

                'prmParameter(24).Direction = ParameterDirection.Input


                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_ValorizadorPagable_Upd", prmParameter)
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
        ''' Fecha Creacion: 24/04/2011 08:52:59 a.m.
        ''' Proposito: Metodo de Modificacion de datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function FijacionPreciosValorizadorPagable(ByVal oLstValorizadorPagable As List(Of clsBE_ValorizadorPagable)) As Boolean
            For Each oValorizadorPagable As clsBE_ValorizadorPagable In oLstValorizadorPagable
                Dim prmParameter(5) As SqlParameter

                prmParameter(0) = New SqlParameter("@pprecio", SqlDbType.Float, 8)
                prmParameter(0).Value = IIf(IsNothing(oValorizadorPagable.precio), 0, oValorizadorPagable.precio)
                prmParameter(0).Direction = ParameterDirection.Input

                prmParameter(1) = New SqlParameter("@pum", SqlDbType.VarChar, 15)
                prmParameter(1).Value = IIf(IsNothing(oValorizadorPagable.um), "", oValorizadorPagable.um)
                prmParameter(1).Direction = ParameterDirection.Input

                prmParameter(2) = New SqlParameter("@pliquidacionPagable", SqlDbType.VarChar, 20)
                prmParameter(2).Value = IIf(IsNothing(oValorizadorPagable.liquidacionPagable), "", oValorizadorPagable.liquidacionPagable)
                prmParameter(2).Direction = ParameterDirection.Input

                prmParameter(3) = New SqlParameter("@pcontratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(3).Value = IIf(IsNothing(oValorizadorPagable.contratoLoteId), "", oValorizadorPagable.contratoLoteId)
                prmParameter(3).Direction = ParameterDirection.Input

                prmParameter(4) = New SqlParameter("@pliquidacionId", SqlDbType.VarChar, 20)
                prmParameter(4).Value = IIf(IsNothing(oValorizadorPagable.liquidacionId), "", oValorizadorPagable.liquidacionId)
                prmParameter(4).Direction = ParameterDirection.Input

                prmParameter(5) = New SqlParameter("@pindpre", SqlDbType.VarChar, 15)
                prmParameter(5).Value = oValorizadorPagable.finPrecio
                prmParameter(5).Direction = ParameterDirection.Input

                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_ValorizadorPagable_FijaPrecios", prmParameter)
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
        ''' Fecha Creacion: 24/04/2011 08:52:59 a.m.
        ''' Proposito: Metodo de Elimacion
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function EliminarValorizadorPagable(ByVal oLstValorizadorPagable As List(Of clsBE_ValorizadorPagable)) As Boolean
            For Each oValorizadorPagable As clsBE_ValorizadorPagable In oLstValorizadorPagable
                Dim prmParameter(2) As SqlParameter
                prmParameter(0) = New SqlParameter("@pliquidacionPagable", SqlDbType.varchar, 20)
                prmParameter(0).Value = IIf(IsNothing(oValorizadorPagable.liquidacionPagable), "", oValorizadorPagable.liquidacionPagable)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
                prmParameter(1).Value = IIf(IsNothing(oValorizadorPagable.contratoLoteId), "", oValorizadorPagable.contratoLoteId)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
                prmParameter(2).Value = IIf(IsNothing(oValorizadorPagable.liquidacionId), "", oValorizadorPagable.liquidacionId)
                prmParameter(2).Direction = ParameterDirection.Input
                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_ValorizadorPagable_Del", prmParameter)
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
        ''' Fecha Creacion: 24/04/2011 08:52:59 a.m.
        ''' Proposito: Metodo de Guardar Dataset
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function GuardarValorizadorPagable(ByVal oDSValorizadorPagable As Dataset) As Boolean
            Dim cnxCPO As New SqlConnection(CadenaConexion)


            Try
                Dim objCommnadInsert As New SqlCommand
                objCommnadInsert.Connection = cnxCPO
                objCommnadInsert.CommandText = "up_ValorizadorPagable_Ins"
                objCommnadInsert.CommandType = CommandType.StoredProcedure

                objCommnadInsert.Parameters.Add("@pcodigoElemento", SqlDbType.varchar, 15).SourceColumn = "codigoElemento"
                objCommnadInsert.Parameters.Add("@ppagable", SqlDbType.Float, 8).SourceColumn = "pagable"
                objCommnadInsert.Parameters.Add("@pdeduccion", SqlDbType.Float, 8).SourceColumn = "deduccion"
                objCommnadInsert.Parameters.Add("@prefinacion", SqlDbType.Float, 8).SourceColumn = "refinacion"
                objCommnadInsert.Parameters.Add("@pproteccion", SqlDbType.Float, 8).SourceColumn = "proteccion"
                objCommnadInsert.Parameters.Add("@pcodigoMercado", SqlDbType.varchar, 15).SourceColumn = "codigoMercado"
                objCommnadInsert.Parameters.Add("@pqpInicio", SqlDbType.DateTime, 8).SourceColumn = "qpInicio"
                objCommnadInsert.Parameters.Add("@pqpFinal", SqlDbType.DateTime, 8).SourceColumn = "qpFinal"
                objCommnadInsert.Parameters.Add("@pleyPagable", SqlDbType.Float, 8).SourceColumn = "leyPagable"
                objCommnadInsert.Parameters.Add("@pprecio", SqlDbType.Float, 8).SourceColumn = "precio"
                objCommnadInsert.Parameters.Add("@pcodigoEstado", SqlDbType.varchar, 15).SourceColumn = "codigoEstado"
                objCommnadInsert.Parameters.Add("@puc", SqlDbType.varchar, 15).SourceColumn = "uc"
                objCommnadInsert.Parameters.Add("@pliquidacionPagable", SqlDbType.varchar, 20).SourceColumn = "liquidacionPagable"
                objCommnadInsert.Parameters.Add("@pcodigoDeduccion", SqlDbType.varchar, 15).SourceColumn = "codigoDeduccion"
                objCommnadInsert.Parameters.Add("@pcalculoPagable", SqlDbType.Float, 8).SourceColumn = "calculoPagable"
                objCommnadInsert.Parameters.Add("@pcodigoQp", SqlDbType.varchar, 15).SourceColumn = "codigoQp"
                objCommnadInsert.Parameters.Add("@pcontratoLoteId", SqlDbType.varchar, 20).SourceColumn = "contratoLoteId"
                objCommnadInsert.Parameters.Add("@pliquidacionId", SqlDbType.varchar, 20).SourceColumn = "liquidacionId"
                objCommnadInsert.Parameters.Add("@pleymin", SqlDbType.Float, 8).SourceColumn = "leymin"
                objCommnadInsert.Parameters.Add("@pleymax", SqlDbType.Float, 8).SourceColumn = "leymax"
                objCommnadInsert.Parameters.Add("@ppreciounitario", SqlDbType.Float, 8).SourceColumn = "preciounitario"

                Dim objCommandUpdate As New SqlCommand
                objCommandUpdate.Connection = cnxCPO
                objCommandUpdate.CommandText = "up_ValorizadorPagable_Upd"
                objCommandUpdate.CommandType = CommandType.StoredProcedure

                objCommandUpdate.Parameters.Add("@pcodigoElemento", SqlDbType.varchar, 15).SourceColumn = "codigoElemento"
                objCommandUpdate.Parameters.Add("@ppagable", SqlDbType.Float, 8).SourceColumn = "pagable"
                objCommandUpdate.Parameters.Add("@pdeduccion", SqlDbType.Float, 8).SourceColumn = "deduccion"
                objCommandUpdate.Parameters.Add("@prefinacion", SqlDbType.Float, 8).SourceColumn = "refinacion"
                objCommandUpdate.Parameters.Add("@pproteccion", SqlDbType.Float, 8).SourceColumn = "proteccion"
                objCommandUpdate.Parameters.Add("@pcodigoMercado", SqlDbType.varchar, 15).SourceColumn = "codigoMercado"
                objCommandUpdate.Parameters.Add("@pqpInicio", SqlDbType.DateTime, 8).SourceColumn = "qpInicio"
                objCommandUpdate.Parameters.Add("@pqpFinal", SqlDbType.DateTime, 8).SourceColumn = "qpFinal"
                objCommandUpdate.Parameters.Add("@pleyPagable", SqlDbType.Float, 8).SourceColumn = "leyPagable"
                objCommandUpdate.Parameters.Add("@pprecio", SqlDbType.Float, 8).SourceColumn = "precio"
                objCommandUpdate.Parameters.Add("@pcodigoEstado", SqlDbType.varchar, 15).SourceColumn = "codigoEstado"
                objCommandUpdate.Parameters.Add("@pum", SqlDbType.varchar, 15).SourceColumn = "um"
                objCommandUpdate.Parameters.Add("@pfm", SqlDbType.DateTime, 8).SourceColumn = "fm"
                objCommandUpdate.Parameters.Add("@pliquidacionPagable", SqlDbType.varchar, 20).SourceColumn = "liquidacionPagable"
                objCommandUpdate.Parameters.Add("@pcodigoDeduccion", SqlDbType.varchar, 15).SourceColumn = "codigoDeduccion"
                objCommandUpdate.Parameters.Add("@pcalculoPagable", SqlDbType.Float, 8).SourceColumn = "calculoPagable"
                objCommandUpdate.Parameters.Add("@pcodigoQp", SqlDbType.varchar, 15).SourceColumn = "codigoQp"
                objCommandUpdate.Parameters.Add("@pcontratoLoteId", SqlDbType.varchar, 20).SourceColumn = "contratoLoteId"
                objCommandUpdate.Parameters.Add("@pliquidacionId", SqlDbType.varchar, 20).SourceColumn = "liquidacionId"
                objCommandUpdate.Parameters.Add("@pleymin", SqlDbType.Float, 8).SourceColumn = "leymin"
                objCommandUpdate.Parameters.Add("@pleymax", SqlDbType.Float, 8).SourceColumn = "leymax"
                objCommandUpdate.Parameters.Add("@ppreciounitario", SqlDbType.Float, 8).SourceColumn = "preciounitario"

                Dim objCommandDelete As New SqlCommand
                objCommandDelete.Connection = cnxCPO
                objCommandDelete.CommandText = "up_ValorizadorPagable_Del"
                objCommandDelete.CommandType = CommandType.StoredProcedure

                objCommandDelete.Parameters.Add("@pliquidacionPagable", SqlDbType.varchar, 20).SourceColumn = "liquidacionPagable"
                objCommandDelete.Parameters.Add("@pcontratoLoteId", SqlDbType.varchar, 20).SourceColumn = "contratoLoteId"
                objCommandDelete.Parameters.Add("@pliquidacionId", SqlDbType.varchar, 20).SourceColumn = "liquidacionId"

                'SqlHelper.UpdateDataset(objCommnadInsert, objCommandDelete, objCommandUpdate, oDSValorizadorPagable, "ValorizadorPagable")

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
    ''' Fecha Creacion: 24/04/2011 08:52:59 a.m.
    ''' Proposito: Obtiene los valores de la tabla ValorizadorPagable
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsDB_ValorizadorPagableRO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 24/04/2011 08:52:59 a.m.
        ''' Proposito: Lee los datos de un registro
        ''' Fecha Modificacion:
        ''' </summary>
        ''' 
        Public Function LeerValorizadorPagable(ByVal pValorizadorPagable As clsBE_ValorizadorPagable) As clsBE_ValorizadorPagable
            Dim oValorizadorPagable As clsBE_ValorizadorPagable = Nothing
            Dim DSValorizadorPagable As New DataSet
            Dim prmParameter(2) As SqlParameter
            prmParameter(0) = New SqlParameter("@pliquidacionPagable", SqlDbType.varchar, 20)
            prmParameter(0).Value = IIf(IsNothing(pValorizadorPagable.liquidacionPagable), "", pValorizadorPagable.liquidacionPagable)
            prmParameter(1) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
            prmParameter(1).Value = IIf(IsNothing(pValorizadorPagable.contratoLoteId), "", pValorizadorPagable.contratoLoteId)
            prmParameter(2) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
            prmParameter(2).Value = IIf(IsNothing(pValorizadorPagable.liquidacionId), "", pValorizadorPagable.liquidacionId)
            Try
                Using DSValorizadorPagable
                    DSValorizadorPagable = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_ValorizadorPagable_Sel", prmParameter)
                    If Not DSValorizadorPagable Is Nothing Then
                        If DSValorizadorPagable.Tables.Count > 0 Then
                            oValorizadorPagable = New clsBE_ValorizadorPagable
                            If DSValorizadorPagable.Tables(0).Rows.Count > 0 Then
                                With DSValorizadorPagable.Tables(0).Rows(0)
                                    oValorizadorPagable.codigoElemento = .Item("codigoElemento").tostring
                                    oValorizadorPagable.pagable = .Item("pagable").tostring
                                    oValorizadorPagable.deduccion = .Item("deduccion").tostring
                                    oValorizadorPagable.refinacion = .Item("refinacion").tostring
                                    oValorizadorPagable.proteccion = .Item("proteccion").tostring
                                    oValorizadorPagable.codigoMercado = .Item("codigoMercado").tostring
                                    oValorizadorPagable.qpInicio = .Item("qpInicio").tostring
                                    oValorizadorPagable.qpFinal = .Item("qpFinal").tostring
                                    oValorizadorPagable.leyPagable = .Item("leyPagable").tostring
                                    oValorizadorPagable.precio = .Item("precio").tostring
                                    oValorizadorPagable.codigoEstado = .Item("codigoEstado").tostring
                                    oValorizadorPagable.uc = .Item("uc").tostring
                                    oValorizadorPagable.fc = .Item("fc").tostring
                                    oValorizadorPagable.liquidacionPagable = .Item("liquidacionPagable").tostring
                                    oValorizadorPagable.codigoDeduccion = .Item("codigoDeduccion").tostring
                                    oValorizadorPagable.calculoPagable = .Item("calculoPagable").tostring
                                    oValorizadorPagable.codigoQp = .Item("codigoQp").tostring
                                    oValorizadorPagable.contratoLoteId = .Item("contratoLoteId").tostring
                                    oValorizadorPagable.liquidacionId = .Item("liquidacionId").tostring
                                    oValorizadorPagable.leymin = .Item("leymin").tostring
                                    oValorizadorPagable.leymax = .Item("leymax").tostring
                                    oValorizadorPagable.preciounitario = .Item("preciounitario").tostring
                                End With
                            End If
                        End If
                    End If
                End Using
            Catch exSql As SqlException

            Catch ex As Exception
                Throw ex
            Finally
                If Not DSValorizadorPagable Is Nothing Then
                    DSValorizadorPagable.Dispose()
                End If
                DSValorizadorPagable = Nothing
            End Try

            Return oValorizadorPagable

        End Function


        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 24/04/2011 08:52:59 a.m.
        ''' Proposito: Obtiene la lista de registros
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaValorizadorPagable() As List(Of clsBE_ValorizadorPagable)
            Dim olstValorizadorPagable As New List(Of clsBE_ValorizadorPagable)
            Dim oValorizadorPagable As clsBE_ValorizadorPagable = Nothing
            Dim mintItem As Integer = 0
            Try
                Using Reader As SqlDataReader = SqlHelper.ExecuteReader(CadenaConexion, CommandType.StoredProcedure, "up_ValorizadorPagable_Sellst")
                    If Reader.HasRows Then
                        While reader.Read
                            oValorizadorPagable = New clsBE_ValorizadorPagable
                            mintItem += 1
                            With oValorizadorPagable
                                .Item = mintItem

                                .codigoElemento = Reader("codigoElemento").tostring
                                .pagable = Reader("pagable").tostring
                                .deduccion = Reader("deduccion").tostring
                                .refinacion = Reader("refinacion").tostring
                                .proteccion = Reader("proteccion").tostring
                                .codigoMercado = Reader("codigoMercado").tostring
                                .qpInicio = Reader("qpInicio").tostring
                                .qpFinal = Reader("qpFinal").tostring
                                .leyPagable = Reader("leyPagable").tostring
                                .precio = Reader("precio").tostring
                                .codigoEstado = Reader("codigoEstado").tostring
                                .uc = Reader("uc").tostring
                                .fc = Reader("fc").tostring
                                .um = Reader("um").tostring
                                .fm = Reader("fm").tostring
                                .liquidacionPagable = Reader("liquidacionPagable").tostring
                                .codigoDeduccion = Reader("codigoDeduccion").tostring
                                .calculoPagable = Reader("calculoPagable").tostring
                                .codigoQp = Reader("codigoQp").tostring
                                .contratoLoteId = Reader("contratoLoteId").tostring
                                .liquidacionId = Reader("liquidacionId").tostring
                                .leymin = Reader("leymin").tostring
                                .leymax = Reader("leymax").tostring
                                .preciounitario = Reader("preciounitario").tostring
                            End With
                            olstValorizadorPagable.Add(oValorizadorPagable)
                        End While
                    End If
                End Using
            Catch ex As Exception
                Throw ex
            End Try

            Return olstValorizadorPagable

        End Function

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 24/04/2011 08:52:59 a.m.
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSValorizadorPagable(ByVal pValorizadorPagable As clsBE_ValorizadorPagable) As Dataset
            Dim oDSValorizadorPagable As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(1) As SqlParameter
            prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
            prmParameter(0).Value = IIf(IsNothing(pValorizadorPagable.contratoLoteId), "", pValorizadorPagable.contratoLoteId)
            prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
            prmParameter(1).Value = IIf(IsNothing(pValorizadorPagable.liquidacionId), "", pValorizadorPagable.liquidacionId)
            Try

                Using oDSValorizadorPagable
                    oDSValorizadorPagable = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_ValorizadorPagable_Sellst", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_ValorizadorPagable_Sellst", oDSValorizadorPagable, New String() {"ValorizadorPagable"}, prmParameter)
                    If Not oDSValorizadorPagable Is Nothing Then
                        If oDSValorizadorPagable.Tables.Count > 0 Then
                            'If oDSValorizadorPagable.Tables("ValorizadorPagable").Rows.Count > 0 Then
                            If oDSValorizadorPagable.Tables(0).Rows.Count > 0 Then
                                Return oDSValorizadorPagable
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSValorizadorPagable

        End Function


        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 24/04/2011 08:52:59 a.m.
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function DefinirTablaValorizadorPagable() As DataTable

            Try
                Dim DTValorizadorPagable As New DataTable

                Dim codigoElemento As DataColumn = DTValorizadorPagable.Columns.Add("codigoElemento", GetType(String))
                codigoElemento.MaxLength = 15
                codigoElemento.AllowDBNull = True
                codigoElemento.DefaultValue = ""

                Dim pagable As DataColumn = DTValorizadorPagable.Columns.Add("pagable", GetType(Decimal))
                pagable.AllowDBNull = True
                pagable.DefaultValue = 0.0


                Dim deduccion As DataColumn = DTValorizadorPagable.Columns.Add("deduccion", GetType(Decimal))
                deduccion.AllowDBNull = True
                deduccion.DefaultValue = 0.0


                Dim refinacion As DataColumn = DTValorizadorPagable.Columns.Add("refinacion", GetType(Decimal))
                refinacion.AllowDBNull = True
                refinacion.DefaultValue = 0.0


                Dim proteccion As DataColumn = DTValorizadorPagable.Columns.Add("proteccion", GetType(Decimal))
                proteccion.AllowDBNull = True
                proteccion.DefaultValue = 0.0


                Dim codigoMercado As DataColumn = DTValorizadorPagable.Columns.Add("codigoMercado", GetType(String))
                codigoMercado.MaxLength = 15
                codigoMercado.AllowDBNull = True
                codigoMercado.DefaultValue = ""

                Dim qpInicio As DataColumn = DTValorizadorPagable.Columns.Add("qpInicio", GetType(DateTime))


                Dim qpFinal As DataColumn = DTValorizadorPagable.Columns.Add("qpFinal", GetType(DateTime))


                Dim leyPagable As DataColumn = DTValorizadorPagable.Columns.Add("leyPagable", GetType(Decimal))
                leyPagable.AllowDBNull = True
                leyPagable.DefaultValue = 0.0


                Dim precio As DataColumn = DTValorizadorPagable.Columns.Add("precio", GetType(Decimal))
                precio.AllowDBNull = True
                precio.DefaultValue = 0.0


                Dim codigoEstado As DataColumn = DTValorizadorPagable.Columns.Add("codigoEstado", GetType(String))
                codigoEstado.MaxLength = 15
                codigoEstado.AllowDBNull = True
                codigoEstado.DefaultValue = ""

                Dim uc As DataColumn = DTValorizadorPagable.Columns.Add("uc", GetType(String))
                uc.MaxLength = 15
                uc.AllowDBNull = True
                uc.DefaultValue = ""

                Dim fc As DataColumn = DTValorizadorPagable.Columns.Add("fc", GetType(DateTime))


                Dim um As DataColumn = DTValorizadorPagable.Columns.Add("um", GetType(String))
                um.MaxLength = 15
                um.AllowDBNull = True
                um.DefaultValue = ""

                Dim fm As DataColumn = DTValorizadorPagable.Columns.Add("fm", GetType(DateTime))


                Dim liquidacionPagable As DataColumn = DTValorizadorPagable.Columns.Add("liquidacionPagable", GetType(String))
                liquidacionPagable.MaxLength = 20
                liquidacionPagable.AllowDBNull = False
                liquidacionPagable.DefaultValue = ""

                Dim codigoDeduccion As DataColumn = DTValorizadorPagable.Columns.Add("codigoDeduccion", GetType(String))
                codigoDeduccion.MaxLength = 15
                codigoDeduccion.AllowDBNull = True
                codigoDeduccion.DefaultValue = ""

                Dim calculoPagable As DataColumn = DTValorizadorPagable.Columns.Add("calculoPagable", GetType(Decimal))
                calculoPagable.AllowDBNull = True
                calculoPagable.DefaultValue = 0.0

                Dim contenidoPagable As DataColumn = DTValorizadorPagable.Columns.Add("contenidoPagable", GetType(Decimal))
                contenidoPagable.AllowDBNull = True
                contenidoPagable.DefaultValue = 0.0

                Dim undcp As DataColumn = DTValorizadorPagable.Columns.Add("undcp", GetType(String))
                undcp.MaxLength = 15
                undcp.AllowDBNull = True
                undcp.DefaultValue = ""

                Dim codigoQp As DataColumn = DTValorizadorPagable.Columns.Add("codigoQp", GetType(String))
                codigoQp.MaxLength = 15
                codigoQp.AllowDBNull = True
                codigoQp.DefaultValue = ""

                Dim qpAjuste As DataColumn = DTValorizadorPagable.Columns.Add("qpAjuste", GetType(String))
                qpAjuste.MaxLength = 15
                qpAjuste.AllowDBNull = True
                qpAjuste.DefaultValue = ""

                Dim contratoLoteId As DataColumn = DTValorizadorPagable.Columns.Add("contratoLoteId", GetType(String))
                contratoLoteId.MaxLength = 20
                contratoLoteId.AllowDBNull = False
                contratoLoteId.DefaultValue = ""

                Dim liquidacionId As DataColumn = DTValorizadorPagable.Columns.Add("liquidacionId", GetType(String))
                liquidacionId.MaxLength = 20
                liquidacionId.AllowDBNull = False
                liquidacionId.DefaultValue = ""

                Dim leymin As DataColumn = DTValorizadorPagable.Columns.Add("leymin", GetType(Decimal))
                leymin.AllowDBNull = True
                leymin.DefaultValue = 0.0


                Dim leymax As DataColumn = DTValorizadorPagable.Columns.Add("leymax", GetType(Decimal))
                leymax.AllowDBNull = True
                leymax.DefaultValue = 0.0


                Dim preciounitario As DataColumn = DTValorizadorPagable.Columns.Add("preciounitario", GetType(Decimal))
                preciounitario.AllowDBNull = True
                preciounitario.DefaultValue = 0.0


                Return DTValorizadorPagable
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class
#End Region

End Namespace
