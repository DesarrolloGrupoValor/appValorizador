Imports SI.BE
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Imports SI.UT
Namespace SI.DB
    Partial Public Class clsDB_LiquidacionServicioTX
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:57:59
        ''' Proposito: Metodo de Insercci?n de Datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function InsertarServicio(ByVal oLstLiquidacionServicio As List(Of clsBE_LiquidacionServicio)) As Boolean
            For Each oLiquidacionServicio As clsBE_LiquidacionServicio In oLstLiquidacionServicio
                Dim prmParameter(9) As SqlParameter

                prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacionServicio.contratoLoteId), "", oLiquidacionServicio.contratoLoteId)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.VarChar, 20)
                prmParameter(1).Value = IIf(IsNothing(oLiquidacionServicio.liquidacionId), "", oLiquidacionServicio.liquidacionId)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pimporte", SqlDbType.Float, 4)
                prmParameter(2).Value = IIf(IsNothing(oLiquidacionServicio.importe), 0, oLiquidacionServicio.importe)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@pcodigoEstado", SqlDbType.VarChar, 15)
                prmParameter(3).Value = IIf(IsNothing(oLiquidacionServicio.codigoEstado), "", oLiquidacionServicio.codigoEstado)
                prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@puc", SqlDbType.VarChar, 15)
                prmParameter(4).Value = IIf(IsNothing(oLiquidacionServicio.uc), "", oLiquidacionServicio.uc)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@pcodigoServicio", SqlDbType.VarChar, 15)
                prmParameter(5).Value = IIf(IsNothing(oLiquidacionServicio.codigoServicio), "", oLiquidacionServicio.codigoServicio)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@pdescri", SqlDbType.VarChar, 100)
                prmParameter(6).Value = IIf(IsNothing(oLiquidacionServicio.descri), "", oLiquidacionServicio.descri)
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7) = New SqlParameter("@pliquidacionServicioId", SqlDbType.VarChar, 20)
                prmParameter(7).Value = IIf(IsNothing(oLiquidacionServicio.liquidacionServicioId), "", oLiquidacionServicio.liquidacionServicioId)
                prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(8) = New SqlParameter("@pcodigoCalculoServicio", SqlDbType.VarChar, 15)
                prmParameter(8).Value = IIf(IsNothing(oLiquidacionServicio.codigoCalculoServicio), "", oLiquidacionServicio.codigoCalculoServicio)
                prmParameter(8).Direction = ParameterDirection.Input

                prmParameter(9) = New SqlParameter("@indservicio", SqlDbType.Char, 1)
                prmParameter(9).Value = IIf(IsNothing(oLiquidacionServicio.indservicio), "", oLiquidacionServicio.indservicio)
                prmParameter(9).Direction = ParameterDirection.Input

                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionServicio_Insertar", prmParameter)
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
        ''' Fecha Creacion: 17/02/2011 16:57:59
        ''' Proposito: Metodo de Modificacion de datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function ModificarServicio(ByVal oLstLiquidacionServicio As List(Of clsBE_LiquidacionServicio)) As Boolean
            For Each oLiquidacionServicio As clsBE_LiquidacionServicio In oLstLiquidacionServicio
                Dim prmParameter(8) As SqlParameter

                prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacionServicio.contratoLoteId), "", oLiquidacionServicio.contratoLoteId)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.VarChar, 20)
                prmParameter(1).Value = IIf(IsNothing(oLiquidacionServicio.liquidacionId), "", oLiquidacionServicio.liquidacionId)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pimporte", SqlDbType.Float, 4)
                prmParameter(2).Value = IIf(IsNothing(oLiquidacionServicio.importe), 0, oLiquidacionServicio.importe)
                prmParameter(2).Direction = ParameterDirection.Input
                'prmParameter(3) = New SqlParameter("@pcodigoEstado", SqlDbType.VarChar, 15)
                'prmParameter(3).Value = IIf(IsNothing(oLiquidacionServicio.codigoEstado), "", oLiquidacionServicio.codigoEstado)
                'prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@pum", SqlDbType.VarChar, 15)
                prmParameter(3).Value = IIf(IsNothing(oLiquidacionServicio.um), "", oLiquidacionServicio.um)
                prmParameter(3).Direction = ParameterDirection.Input
                'prmParameter(5) = New SqlParameter("@pfm", SqlDbType.DateTime, 8)
                'prmParameter(5).Value = clsUT_Funcion.FechaNull(oLiquidacionServicio.fm)
                'prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@pcodigoServicio", SqlDbType.VarChar, 15)
                prmParameter(4).Value = IIf(IsNothing(oLiquidacionServicio.codigoServicio), "", oLiquidacionServicio.codigoServicio)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@pdescri", SqlDbType.VarChar, 100)
                prmParameter(5).Value = IIf(IsNothing(oLiquidacionServicio.descri), "", oLiquidacionServicio.descri)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@pliquidacionServicioId", SqlDbType.VarChar, 20)
                prmParameter(6).Value = IIf(IsNothing(oLiquidacionServicio.liquidacionServicioId), "", oLiquidacionServicio.liquidacionServicioId)
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7) = New SqlParameter("@pcodigoCalculoServicio", SqlDbType.VarChar, 15)
                prmParameter(7).Value = IIf(IsNothing(oLiquidacionServicio.codigoCalculoServicio), "", oLiquidacionServicio.codigoCalculoServicio)
                prmParameter(7).Direction = ParameterDirection.Input


                prmParameter(8) = New SqlParameter("@indservicio", SqlDbType.Char, 1)
                prmParameter(8).Value = IIf(IsNothing(oLiquidacionServicio.indservicio), "", oLiquidacionServicio.indservicio)
                prmParameter(8).Direction = ParameterDirection.Input

                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionServicio_Modificar", prmParameter)
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
        ''' Fecha Creacion: 17/02/2011 16:58:00
        ''' Proposito: Metodo de Elimacion
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function EliminarServicio(ByVal oLstLiquidacionServicio As List(Of clsBE_LiquidacionServicio)) As Boolean
            For Each oLiquidacionServicio As clsBE_LiquidacionServicio In oLstLiquidacionServicio
                Dim prmParameter(2) As SqlParameter
                prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacionServicio.contratoLoteId), "", oLiquidacionServicio.contratoLoteId)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.VarChar, 20)
                prmParameter(1).Value = IIf(IsNothing(oLiquidacionServicio.liquidacionId), "", oLiquidacionServicio.liquidacionId)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pliquidacionServicioId", SqlDbType.VarChar, 20)
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

    End Class

End Namespace
