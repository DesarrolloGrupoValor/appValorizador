Imports SI.BE
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Imports SI.UT

Namespace SI.DB
    Partial Public Class clsDB_LiquidacionDsctoRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:42:15
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function DefineTablaLiquidacionDscto() As DataTable

            Try
                Dim DTLiquidacionDscto As New DataTable

                Dim nro As DataColumn = DTLiquidacionDscto.Columns.Add("nro", GetType(Integer))
                nro.AllowDBNull = True

                Dim codigoDscto As DataColumn = DTLiquidacionDscto.Columns.Add("codigoDscto", GetType(String))
                codigoDscto.MaxLength = 15
                codigoDscto.AllowDBNull = True
                codigoDscto.DefaultValue = ""

                Dim importe As DataColumn = DTLiquidacionDscto.Columns.Add("importe", GetType(Double))
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

                Return DTLiquidacionDscto
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
    Partial Public Class clsDB_LiquidacionDsctoTX
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:42:13
        ''' Proposito: Metodo de Insercci?n de Datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function InsertarDscto(ByVal oLstLiquidacionDscto As List(Of clsBE_LiquidacionDscto)) As Boolean
            For Each oLiquidacionDscto As clsBE_LiquidacionDscto In oLstLiquidacionDscto
                Dim prmParameter(9) As SqlParameter

                prmParameter(0) = New SqlParameter("@pcodigoDscto", SqlDbType.VarChar, 15)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacionDscto.codigoDscto), "", oLiquidacionDscto.codigoDscto)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pimporte", SqlDbType.Float, 4)
                prmParameter(1).Value = IIf(IsNothing(oLiquidacionDscto.importe), 0, oLiquidacionDscto.importe)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pdescri", SqlDbType.VarChar, 100)
                prmParameter(2).Value = IIf(IsNothing(oLiquidacionDscto.descri), "", oLiquidacionDscto.descri)
                prmParameter(2).Direction = ParameterDirection.Input

                prmParameter(3) = New SqlParameter("@pobserva", SqlDbType.VarChar, 100)
                prmParameter(3).Value = IIf(IsNothing(oLiquidacionDscto.observa), "", oLiquidacionDscto.observa)
                prmParameter(3).Direction = ParameterDirection.Input

                prmParameter(4) = New SqlParameter("@pcodigoEstado", SqlDbType.VarChar, 15)
                prmParameter(4).Value = IIf(IsNothing(oLiquidacionDscto.codigoEstado), "", oLiquidacionDscto.codigoEstado)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@puc", SqlDbType.VarChar, 15)
                prmParameter(5).Value = IIf(IsNothing(oLiquidacionDscto.uc), "", oLiquidacionDscto.uc)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@pcontratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(6).Value = IIf(IsNothing(oLiquidacionDscto.contratoLoteId), "", oLiquidacionDscto.contratoLoteId)
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7) = New SqlParameter("@pliquidacionId", SqlDbType.VarChar, 20)
                prmParameter(7).Value = IIf(IsNothing(oLiquidacionDscto.liquidacionId), "", oLiquidacionDscto.liquidacionId)
                prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(8) = New SqlParameter("@pliquidacionDsctoId", SqlDbType.VarChar, 20)
                prmParameter(8).Value = IIf(IsNothing(oLiquidacionDscto.liquidacionDsctoId), "", oLiquidacionDscto.liquidacionDsctoId)
                prmParameter(8).Direction = ParameterDirection.Input

                prmParameter(9) = New SqlParameter("@nro", SqlDbType.Int, 16)
                prmParameter(9).Value = IIf(IsNothing(oLiquidacionDscto.nro), Nothing, oLiquidacionDscto.nro)
                prmParameter(9).Direction = ParameterDirection.Input
                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionDscto_Insertar", prmParameter)
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
        ''' Fecha Creacion: 17/02/2011 16:42:13
        ''' Proposito: Metodo de Modificacion de datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function ModificarDscto(ByVal oLstLiquidacionDscto As List(Of clsBE_LiquidacionDscto)) As Boolean
            For Each oLiquidacionDscto As clsBE_LiquidacionDscto In oLstLiquidacionDscto
                Dim prmParameter(6) As SqlParameter
                prmParameter(0) = New SqlParameter("@pcodigoDscto", SqlDbType.VarChar, 15)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacionDscto.codigoDscto), "", oLiquidacionDscto.codigoDscto)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pimporte", SqlDbType.Float, 4)
                prmParameter(1).Value = IIf(IsNothing(oLiquidacionDscto.importe), 0, oLiquidacionDscto.importe)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pdescri", SqlDbType.VarChar, 100)
                prmParameter(2).Value = IIf(IsNothing(oLiquidacionDscto.descri), "", oLiquidacionDscto.descri)
                prmParameter(2).Direction = ParameterDirection.Input
                'prmParameter(3) = New SqlParameter("@pcartaInstruccion", SqlDbType.VarChar, 100)
                'prmParameter(3).Value = IIf(IsNothing(oLiquidacionDscto.cartaInstruccion), "", oLiquidacionDscto.cartaInstruccion)
                'prmParameter(3).Direction = ParameterDirection.Input
                'prmParameter(4) = New SqlParameter("@pobserva", SqlDbType.VarChar, 100)
                'prmParameter(4).Value = IIf(IsNothing(oLiquidacionDscto.observa), "", oLiquidacionDscto.observa)
                'prmParameter(4).Direction = ParameterDirection.Input
                'prmParameter(3) = New SqlParameter("@pcodigoEstado", SqlDbType.VarChar, 15)
                'prmParameter(3).Value = IIf(IsNothing(oLiquidacionDscto.codigoEstado), "", oLiquidacionDscto.codigoEstado)
                'prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@pum", SqlDbType.VarChar, 15)
                prmParameter(3).Value = IIf(IsNothing(oLiquidacionDscto.um), "", oLiquidacionDscto.um)
                prmParameter(3).Direction = ParameterDirection.Input
                'prmParameter(7) = New SqlParameter("@pfm", SqlDbType.DateTime, 8)
                'prmParameter(7).Value = clsUT_Funcion.FechaNull(oLiquidacionDscto.fm)
                'prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@pcontratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(4).Value = IIf(IsNothing(oLiquidacionDscto.contratoLoteId), "", oLiquidacionDscto.contratoLoteId)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@pliquidacionId", SqlDbType.VarChar, 20)
                prmParameter(5).Value = IIf(IsNothing(oLiquidacionDscto.liquidacionId), "", oLiquidacionDscto.liquidacionId)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@pliquidacionDsctoId", SqlDbType.VarChar, 20)
                prmParameter(6).Value = IIf(IsNothing(oLiquidacionDscto.liquidacionDsctoId), "", oLiquidacionDscto.liquidacionDsctoId)
                prmParameter(6).Direction = ParameterDirection.Input
                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionDscto_Modificar", prmParameter)
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
        ''' Fecha Creacion: 17/02/2011 16:42:14
        ''' Proposito: Metodo de Elimacion
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function EliminarDscto(ByVal oLstLiquidacionDscto As List(Of clsBE_LiquidacionDscto)) As Boolean
            For Each oLiquidacionDscto As clsBE_LiquidacionDscto In oLstLiquidacionDscto
                Dim prmParameter(3) As SqlParameter
                prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacionDscto.contratoLoteId), "", oLiquidacionDscto.contratoLoteId)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.VarChar, 20)
                prmParameter(1).Value = IIf(IsNothing(oLiquidacionDscto.liquidacionId), "", oLiquidacionDscto.liquidacionId)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pliquidacionDsctoId", SqlDbType.VarChar, 20)
                prmParameter(2).Value = IIf(IsNothing(oLiquidacionDscto.liquidacionDsctoId), "", oLiquidacionDscto.liquidacionDsctoId)
                prmParameter(2).Direction = ParameterDirection.Input

                prmParameter(3) = New SqlParameter("@nro", SqlDbType.Int)
                prmParameter(3).Value = IIf(IsNothing(oLiquidacionDscto.nro), "", oLiquidacionDscto.nro)
                prmParameter(3).Direction = ParameterDirection.Input

                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionDscto_Del", prmParameter)
                Catch ex As Exception
                    Throw ex
                    Return False
                End Try
            Next
            Return True
        End Function

    End Class

End Namespace
