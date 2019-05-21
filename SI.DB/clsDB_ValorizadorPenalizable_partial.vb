Imports SI.BE
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Namespace SI.DB
    Partial Public Class clsDB_ValorizadorPenalizableTX
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 07/12/2010 14:46:24
        ''' Proposito: Metodo de Insercci?n de Datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function InsertarPenalizable(ByVal oLstValorizadorPenalizable As List(Of clsBE_ValorizadorPenalizable)) As Boolean
            For Each oValorizadorPenalizable As clsBE_ValorizadorPenalizable In oLstValorizadorPenalizable
                Dim prmParameter(11) As SqlParameter

                'prmParameter(0) = New SqlParameter("@pliquidacionTmId", SqlDbType.VarChar, 20)
                'prmParameter(0).Value = IIf(IsNothing(oValorizadorPenalizable.liquidacionTmId), "", oValorizadorPenalizable.liquidacionTmId)
                'prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(0) = New SqlParameter("@pliquidacionId", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(oValorizadorPenalizable.liquidacionId), "", oValorizadorPenalizable.liquidacionId)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pcontratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(1).Value = IIf(IsNothing(oValorizadorPenalizable.contratoLoteId), "", oValorizadorPenalizable.contratoLoteId)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pcodigoElemento", SqlDbType.VarChar, 15)
                prmParameter(2).Value = IIf(IsNothing(oValorizadorPenalizable.codigoElemento), "", oValorizadorPenalizable.codigoElemento)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@pMinimo", SqlDbType.Float, 4)
                prmParameter(3).Value = IIf(IsNothing(oValorizadorPenalizable.minimo), 0, oValorizadorPenalizable.minimo)
                prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@pUnidadPenalizable", SqlDbType.Float, 4)
                prmParameter(4).Value = IIf(IsNothing(oValorizadorPenalizable.unidadPenalizable), 0, oValorizadorPenalizable.unidadPenalizable)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@pPenalidad", SqlDbType.Float, 4)
                prmParameter(5).Value = IIf(IsNothing(oValorizadorPenalizable.penalidad), 0, oValorizadorPenalizable.penalidad)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@pLeyPenalizable", SqlDbType.Float, 4)
                prmParameter(6).Value = IIf(IsNothing(oValorizadorPenalizable.leyPenalizable), 0, oValorizadorPenalizable.leyPenalizable)
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7) = New SqlParameter("@pCalculoPenalizable", SqlDbType.Float, 4)
                prmParameter(7).Value = IIf(IsNothing(oValorizadorPenalizable.calculoPenalizable), 0, oValorizadorPenalizable.calculoPenalizable)
                prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(8) = New SqlParameter("@pcodigoEstado", SqlDbType.VarChar, 15)
                prmParameter(8).Value = IIf(IsNothing(oValorizadorPenalizable.codigoEstado), "", oValorizadorPenalizable.codigoEstado)
                prmParameter(8).Direction = ParameterDirection.Input
                prmParameter(9) = New SqlParameter("@puc", SqlDbType.VarChar, 15)
                prmParameter(9).Value = IIf(IsNothing(oValorizadorPenalizable.uc), "", oValorizadorPenalizable.uc)
                prmParameter(9).Direction = ParameterDirection.Input
                prmParameter(10) = New SqlParameter("@pMaximo", SqlDbType.Float, 4)
                prmParameter(10).Value = IIf(IsNothing(oValorizadorPenalizable.maximo), 0, oValorizadorPenalizable.maximo)
                prmParameter(10).Direction = ParameterDirection.Input
                prmParameter(11) = New SqlParameter("@pindley", SqlDbType.VarChar, 15)
                prmParameter(11).Value = IIf(IsNothing(oValorizadorPenalizable.indLey), "", oValorizadorPenalizable.indLey)
                prmParameter(11).Direction = ParameterDirection.Input
                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_ValorizadorPenalizable_Insertar", prmParameter)
                Catch ex As Exception
                    Throw ex
                    Return False
                End Try
            Next
            Return True
        End Function
    End Class

    Partial Public Class clsDB_ValorizadorPenalizableRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 07/12/2010 14:46:15
        ''' Proposito: Lee los datos de un registro
        ''' Fecha Modificacion:
        ''' </summary>
        ''' 
        Public Function LeerPenalizableCorrelativo(ByVal pValorizadorPenalizable As clsBE_ValorizadorPenalizable) As clsBE_ValorizadorPenalizable
            Dim oValorizadorPenalizable As clsBE_ValorizadorPenalizable = Nothing
            Dim DSValorizadorPenalizable As New DataSet
            Dim prmParameter(1) As SqlParameter
            'prmParameter(0) = New SqlParameter("@pliquidacionTmId", SqlDbType.VarChar, 20)
            'prmParameter(0).Value = IIf(IsNothing(pValorizadorPenalizable.liquidacionTmId), "", pValorizadorPenalizable.liquidacionTmId)
            prmParameter(0) = New SqlParameter("@pliquidacionId", SqlDbType.VarChar, 20)
            prmParameter(0).Value = IIf(IsNothing(pValorizadorPenalizable.liquidacionId), "", pValorizadorPenalizable.liquidacionId)
            prmParameter(1) = New SqlParameter("@pcontratoLoteId", SqlDbType.VarChar, 20)
            prmParameter(1).Value = IIf(IsNothing(pValorizadorPenalizable.contratoLoteId), "", pValorizadorPenalizable.contratoLoteId)
            Try
                Using DSValorizadorPenalizable
                    DSValorizadorPenalizable = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_ValorizadorPenalizable_Sel_correlativo", prmParameter)
                    If Not DSValorizadorPenalizable Is Nothing Then
                        If DSValorizadorPenalizable.Tables.Count > 0 Then
                            oValorizadorPenalizable = New clsBE_ValorizadorPenalizable
                            If DSValorizadorPenalizable.Tables(0).Rows.Count > 0 Then
                                With DSValorizadorPenalizable.Tables(0).Rows(0)
                                    oValorizadorPenalizable.liquidacionPenalizableId = .Item("correlativo").ToString
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
        ''' Fecha Creacion: 17/02/2011 17:00:52
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSPenalizable(ByVal pValorizadorPenalizable As clsBE_ValorizadorPenalizable) As DataSet
            Dim oDSValorizadorPenalizable As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(1) As SqlParameter
            'prmParameter(0) = New SqlParameter("@pliquidacionTmId", SqlDbType.VarChar, 20)
            'prmParameter(0).Value = IIf(IsNothing(pValorizadorPenalizable.liquidacionTmId), "", pValorizadorPenalizable.liquidacionTmId)
            prmParameter(0) = New SqlParameter("@pliquidacionId", SqlDbType.VarChar, 20)
            prmParameter(0).Value = IIf(IsNothing(pValorizadorPenalizable.liquidacionId), "", pValorizadorPenalizable.liquidacionId)
            prmParameter(1) = New SqlParameter("@pcontratoLoteId", SqlDbType.VarChar, 20)
            prmParameter(1).Value = IIf(IsNothing(pValorizadorPenalizable.contratoLoteId), "", pValorizadorPenalizable.contratoLoteId)
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
    End Class
End Namespace
