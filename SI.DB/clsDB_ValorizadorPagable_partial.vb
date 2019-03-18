Imports SI.BE
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Imports SI.UT

Namespace SI.DB

    Partial Public Class clsDB_ValorizadorPagableTX
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 07/12/2010 14:46:15
        ''' Proposito: Metodo de Insercci?n de Datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function InsertarPagable(ByVal oLstValorizadorPagable As List(Of clsBE_ValorizadorPagable)) As Boolean
            For Each oValorizadorPagable As clsBE_ValorizadorPagable In oLstValorizadorPagable
                Dim prmParameter(23) As SqlParameter

                'prmParameter(0) = New SqlParameter("@pliquidacionTmId", SqlDbType.VarChar, 20)
                'prmParameter(0).Value = IIf(IsNothing(oValorizadorPagable.liquidacionTmId), "", oValorizadorPagable.liquidacionTmId)
                'prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(0) = New SqlParameter("@pliquidacionId", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(oValorizadorPagable.liquidacionId), "", oValorizadorPagable.liquidacionId)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pcontratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(1).Value = IIf(IsNothing(oValorizadorPagable.contratoLoteId), "", oValorizadorPagable.contratoLoteId)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pcodigoElemento", SqlDbType.VarChar, 15)
                prmParameter(2).Value = IIf(IsNothing(oValorizadorPagable.codigoElemento), "", oValorizadorPagable.codigoElemento)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@pPagable", SqlDbType.Float, 4)
                prmParameter(3).Value = IIf(IsNothing(oValorizadorPagable.pagable), 0, oValorizadorPagable.pagable)
                prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@pDeduccion", SqlDbType.Float, 4)
                prmParameter(4).Value = IIf(IsNothing(oValorizadorPagable.deduccion), 0, oValorizadorPagable.deduccion)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@pRefinacion", SqlDbType.Float, 4)
                prmParameter(5).Value = IIf(IsNothing(oValorizadorPagable.refinacion), 0, oValorizadorPagable.refinacion)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@pProteccion", SqlDbType.Float, 4)
                prmParameter(6).Value = IIf(IsNothing(oValorizadorPagable.proteccion), 0, oValorizadorPagable.proteccion)
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7) = New SqlParameter("@pcodigoMercado", SqlDbType.VarChar, 15)
                prmParameter(7).Value = IIf(IsNothing(oValorizadorPagable.codigoMercado), "", oValorizadorPagable.codigoMercado)
                prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(8) = New SqlParameter("@pQpInicio", SqlDbType.DateTime, 10)
                prmParameter(8).Value = clsUT_Funcion.FechaNull(oValorizadorPagable.qpInicio)
                prmParameter(8).Direction = ParameterDirection.Input
                prmParameter(9) = New SqlParameter("@pQpFinal", SqlDbType.DateTime, 10)
                prmParameter(9).Value = clsUT_Funcion.FechaNull(oValorizadorPagable.qpFinal)
                prmParameter(9).Direction = ParameterDirection.Input
                prmParameter(10) = New SqlParameter("@pLeyPagable", SqlDbType.Float, 4)
                prmParameter(10).Value = IIf(IsNothing(oValorizadorPagable.leyPagable), 0, oValorizadorPagable.leyPagable)
                prmParameter(10).Direction = ParameterDirection.Input
                prmParameter(11) = New SqlParameter("@pPrecio", SqlDbType.Float, 4)
                prmParameter(11).Value = IIf(IsNothing(oValorizadorPagable.precio), 0, oValorizadorPagable.precio)
                prmParameter(11).Direction = ParameterDirection.Input
                'prmParameter(13) = New SqlParameter("@pCalculoExposicion", SqlDbType.Float, 4)
                'prmParameter(13).Value = IIf(IsNothing(oValorizadorPagable.proteccion), 0, oValorizadorPagable.proteccion)
                'prmParameter(13).Direction = ParameterDirection.Input
                'prmParameter(14) = New SqlParameter("@pCalculoRefinacion", SqlDbType.Float, 4)
                'prmParameter(14).Value = IIf(IsNothing(oValorizadorPagable.refinacion), 0, oValorizadorPagable.refinacion)
                'prmParameter(14).Direction = ParameterDirection.Input
                prmParameter(12) = New SqlParameter("@pCalculoPagable", SqlDbType.Float, 4)
                prmParameter(12).Value = IIf(IsNothing(oValorizadorPagable.calculoPagable), 0, oValorizadorPagable.calculoPagable)
                prmParameter(12).Direction = ParameterDirection.Input
                prmParameter(13) = New SqlParameter("@pcodigoEstado", SqlDbType.VarChar, 15)
                prmParameter(13).Value = IIf(IsNothing(oValorizadorPagable.codigoEstado), "", oValorizadorPagable.codigoEstado)
                prmParameter(13).Direction = ParameterDirection.Input
                prmParameter(14) = New SqlParameter("@puc", SqlDbType.VarChar, 15)
                prmParameter(14).Value = IIf(IsNothing(oValorizadorPagable.uc), "", oValorizadorPagable.uc)
                prmParameter(14).Direction = ParameterDirection.Input
                prmParameter(15) = New SqlParameter("@pcodigoDeduccion", SqlDbType.VarChar, 15)
                prmParameter(15).Value = IIf(IsNothing(oValorizadorPagable.codigoDeduccion), "", oValorizadorPagable.codigoDeduccion)
                prmParameter(15).Direction = ParameterDirection.Input
                prmParameter(16) = New SqlParameter("@pleymin", SqlDbType.Float, 4)
                prmParameter(16).Value = IIf(IsNothing(oValorizadorPagable.leymin), 0, oValorizadorPagable.leymin)
                prmParameter(16).Direction = ParameterDirection.Input
                prmParameter(17) = New SqlParameter("@pleymax", SqlDbType.Float, 4)
                prmParameter(17).Value = IIf(IsNothing(oValorizadorPagable.leymax), 0, oValorizadorPagable.leymax)
                prmParameter(17).Direction = ParameterDirection.Input
                prmParameter(18) = New SqlParameter("@pcodigoQp", SqlDbType.VarChar, 15)
                prmParameter(18).Value = IIf(IsNothing(oValorizadorPagable.codigoQp), "", oValorizadorPagable.codigoQp)
                prmParameter(18).Direction = ParameterDirection.Input
                prmParameter(19) = New SqlParameter("@pcontenidoPagable", SqlDbType.Float, 4)
                prmParameter(19).Value = IIf(IsNothing(oValorizadorPagable.contenidoPagable), 0, oValorizadorPagable.contenidoPagable)
                prmParameter(19).Direction = ParameterDirection.Input
                prmParameter(20) = New SqlParameter("@pcodigoqpajuste", SqlDbType.VarChar, 15)
                prmParameter(20).Value = IIf(IsNothing(oValorizadorPagable.codigoQpAjuste), "", oValorizadorPagable.codigoQpAjuste)
                prmParameter(20).Direction = ParameterDirection.Input
                prmParameter(21) = New SqlParameter("@pindley", SqlDbType.VarChar, 15)
                prmParameter(21).Value = IIf(IsNothing(oValorizadorPagable.finLey), "0", oValorizadorPagable.finLey)
                prmParameter(21).Direction = ParameterDirection.Input
                prmParameter(22) = New SqlParameter("@pindpre", SqlDbType.VarChar, 15)
                prmParameter(22).Value = IIf(IsNothing(oValorizadorPagable.finPrecio), "0", oValorizadorPagable.finPrecio)
                prmParameter(22).Direction = ParameterDirection.Input
                prmParameter(23) = New SqlParameter("@pProtCont", SqlDbType.Float, 4)
                prmParameter(23).Value = IIf(IsNothing(oValorizadorPagable.protCont), 0, oValorizadorPagable.protCont)
                prmParameter(23).Direction = ParameterDirection.Input


                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_ValorizadorPagable_Insertar", prmParameter)
                Catch ex As Exception
                    Throw ex
                    Return False
                End Try
            Next
            Return True
        End Function
    End Class

    Partial Public Class clsDB_ValorizadorPagableRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 07/12/2010 14:46:15
        ''' Proposito: Lee los datos de un registro
        ''' Fecha Modificacion:
        ''' </summary>
        ''' 
        Public Function LeerPagableCorrelativo(ByVal pValorizadorPagable As clsBE_ValorizadorPagable) As clsBE_ValorizadorPagable
            Dim oValorizadorPagable As clsBE_ValorizadorPagable = Nothing
            Dim DSValorizadorPagable As New DataSet
            Dim prmParameter(1) As SqlParameter
            'prmParameter(0) = New SqlParameter("@pliquidacionTmId", SqlDbType.VarChar, 20)
            'prmParameter(0).Value = IIf(IsNothing(pValorizadorPagable.liquidacionTmId), "", pValorizadorPagable.liquidacionTmId)
            prmParameter(0) = New SqlParameter("@pliquidacionId", SqlDbType.VarChar, 20)
            prmParameter(0).Value = IIf(IsNothing(pValorizadorPagable.liquidacionId), "", pValorizadorPagable.liquidacionId)
            prmParameter(1) = New SqlParameter("@pcontratoLoteId", SqlDbType.VarChar, 20)
            prmParameter(1).Value = IIf(IsNothing(pValorizadorPagable.contratoLoteId), "", pValorizadorPagable.contratoLoteId)
            Try
                Using DSValorizadorPagable
                    DSValorizadorPagable = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_ValorizadorPagable_Sel_correlativo", prmParameter)
                    If Not DSValorizadorPagable Is Nothing Then
                        If DSValorizadorPagable.Tables.Count > 0 Then
                            oValorizadorPagable = New clsBE_ValorizadorPagable
                            If DSValorizadorPagable.Tables(0).Rows.Count > 0 Then
                                With DSValorizadorPagable.Tables(0).Rows(0)
                                    oValorizadorPagable.liquidacionPagable = .Item("correlativo").ToString
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
        ''' Fecha Creacion: 17/02/2011 17:00:41
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSPagable(ByVal pValorizadorPagable As clsBE_ValorizadorPagable) As DataSet
            Dim oDSValorizadorPagable As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(1) As SqlParameter
            'prmParameter(0) = New SqlParameter("@pliquidacionTmId", SqlDbType.VarChar, 20)
            'prmParameter(0).Value = IIf(IsNothing(pValorizadorPagable.liquidacionTmId), "", pValorizadorPagable.liquidacionTmId)
            prmParameter(0) = New SqlParameter("@pliquidacionId", SqlDbType.VarChar, 20)
            prmParameter(0).Value = IIf(IsNothing(pValorizadorPagable.liquidacionId), "", pValorizadorPagable.liquidacionId)
            prmParameter(1) = New SqlParameter("@pcontratoLoteId", SqlDbType.VarChar, 20)
            prmParameter(1).Value = IIf(IsNothing(pValorizadorPagable.contratoLoteId), "", pValorizadorPagable.contratoLoteId)
            Try

                Using oDSValorizadorPagable
                    oDSValorizadorPagable = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_ValorizadorPagable_Sellst_lista", prmParameter)
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
        ''' Fecha Creacion: 11/03/2011 17:53:28
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function DefineTablaValorizadorPagable() As DataTable

            Try
                Dim DTValorizadorPagable As New DataTable

                Dim codigoElemento As DataColumn = DTValorizadorPagable.Columns.Add("codigoElemento", GetType(String))
                codigoElemento.MaxLength = 15
                codigoElemento.AllowDBNull = True
                codigoElemento.DefaultValue = ""

                Dim pagable As DataColumn = DTValorizadorPagable.Columns.Add("pagable", GetType(Double))
                pagable.AllowDBNull = True
                pagable.DefaultValue = 0

                Dim undpag As DataColumn = DTValorizadorPagable.Columns.Add("undpag", GetType(String))
                undpag.MaxLength = 15
                undpag.AllowDBNull = True
                undpag.DefaultValue = ""

                Dim deduccion As DataColumn = DTValorizadorPagable.Columns.Add("deduccion", GetType(Double))
                deduccion.AllowDBNull = True
                deduccion.DefaultValue = 0

                Dim undded As DataColumn = DTValorizadorPagable.Columns.Add("undded", GetType(String))
                undded.MaxLength = 15
                undded.AllowDBNull = True
                undded.DefaultValue = ""

                Dim refinacion As DataColumn = DTValorizadorPagable.Columns.Add("refinacion", GetType(Double))
                refinacion.AllowDBNull = True
                refinacion.DefaultValue = 0

                Dim undrc As DataColumn = DTValorizadorPagable.Columns.Add("undrc", GetType(String))
                undrc.MaxLength = 15
                undrc.AllowDBNull = True
                undrc.DefaultValue = ""

                Dim proteccion As DataColumn = DTValorizadorPagable.Columns.Add("proteccion", GetType(Double))
                proteccion.AllowDBNull = True
                proteccion.DefaultValue = 0

                Dim undprot As DataColumn = DTValorizadorPagable.Columns.Add("undprot", GetType(String))
                undprot.MaxLength = 15
                undprot.AllowDBNull = True
                undprot.DefaultValue = ""

                Dim codigoMercado As DataColumn = DTValorizadorPagable.Columns.Add("codigoMercado", GetType(String))
                codigoMercado.MaxLength = 15
                codigoMercado.AllowDBNull = True
                codigoMercado.DefaultValue = ""

                Dim qpInicio As DataColumn = DTValorizadorPagable.Columns.Add("qpInicio", GetType(DateTime))


                Dim qpFinal As DataColumn = DTValorizadorPagable.Columns.Add("qpFinal", GetType(DateTime))


                Dim leyPagable As DataColumn = DTValorizadorPagable.Columns.Add("leyPagable", GetType(Double))
                leyPagable.AllowDBNull = True
                leyPagable.DefaultValue = 0


                Dim precio As DataColumn = DTValorizadorPagable.Columns.Add("precio", GetType(Double))
                precio.AllowDBNull = True
                precio.DefaultValue = 0


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

                Dim calculoPagable As DataColumn = DTValorizadorPagable.Columns.Add("calculoPagable", GetType(Double))
                calculoPagable.AllowDBNull = True
                calculoPagable.DefaultValue = 0

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

                Dim codigoQpAjuste As DataColumn = DTValorizadorPagable.Columns.Add("codigoQpAjuste", GetType(String))
                codigoQpAjuste.MaxLength = 15
                codigoQpAjuste.AllowDBNull = True
                codigoQpAjuste.DefaultValue = ""

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
                leymin.DefaultValue = 0


                Dim leymax As DataColumn = DTValorizadorPagable.Columns.Add("leymax", GetType(Decimal))
                leymax.AllowDBNull = True
                leymax.DefaultValue = 0

                Dim undfactor As DataColumn = DTValorizadorPagable.Columns.Add("undfactor", GetType(String))
                undfactor.MaxLength = 15
                undfactor.AllowDBNull = True
                undfactor.DefaultValue = ""

                Dim preciounitario As DataColumn = DTValorizadorPagable.Columns.Add("preciounitario", GetType(Decimal))
                preciounitario.AllowDBNull = True
                preciounitario.DefaultValue = 0.0

                Dim indley As DataColumn = DTValorizadorPagable.Columns.Add("finley", GetType(String))
                indley.MaxLength = 15
                indley.AllowDBNull = True
                indley.DefaultValue = ""

                Dim indpre As DataColumn = DTValorizadorPagable.Columns.Add("finprecio", GetType(String))
                indpre.MaxLength = 15
                indpre.AllowDBNull = True
                indpre.DefaultValue = ""

                Dim protCont As DataColumn = DTValorizadorPagable.Columns.Add("ProtCont", GetType(Double))
                protCont.AllowDBNull = True
                protCont.DefaultValue = 0

                Return DTValorizadorPagable
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
