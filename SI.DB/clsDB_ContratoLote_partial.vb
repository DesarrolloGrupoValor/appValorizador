'Modified:
'@01 20141016 BAL01 Validacion, no se puede eliminar liquidacion cuyo asiento contable haya sido generado
'@02 20141028 BAL01 Se amplia el tiempo de espera para el retorno de data

Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports SI.BE
Imports SI.UT
Imports Microsoft.ApplicationBlocks.Data

Namespace SI.DB
    Partial Public Class clsDB_ContratoLoteRO

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 13/11/2010 14:58:04
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSExtraccionBd(ByVal pContratoLote As clsBE_ContratoLote) As DataSet
            Dim oDSContratoLote As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(1) As SqlParameter
            prmParameter(0) = New SqlParameter("@Emp", SqlDbType.VarChar, 15)
            prmParameter(0).Value = "" 'IIf(IsNothing(pContratoLote.codigoTabla), "", pContratoLote.codigoTabla)
            prmParameter(1) = New SqlParameter("@Per", SqlDbType.VarChar, 15)
            prmParameter(1).Value = "" 'IIf(IsNothing(pContratoLote.comentarios), "", pContratoLote.comentarios)
            Try

                Using oDSContratoLote
                    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "usp_reporte_ExtraccionBd", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sellst", oDSContratoLote, New String() {"ContratoLote"}, prmParameter)
                    If Not oDSContratoLote Is Nothing Then
                        If oDSContratoLote.Tables.Count > 0 Then
                            'If oDSContratoLote.Tables("ContratoLote").Rows.Count > 0 Then
                            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                                Return oDSContratoLote
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function



        Public Function LeerListaToDSComercial_Kardex(ByVal pContratoLote As clsBE_ContratoLote) As DataSet
            Dim oDSContratoLote As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(0) As SqlParameter
            prmParameter(0) = New SqlParameter("@Periodo", SqlDbType.VarChar, 15)
            prmParameter(0).Value = IIf(IsNothing(pContratoLote.comentarios), "", pContratoLote.comentarios)
            Try

                Using oDSContratoLote
                    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "Comercial_Kardex", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sellst", oDSContratoLote, New String() {"ContratoLote"}, prmParameter)
                    If Not oDSContratoLote Is Nothing Then
                        If oDSContratoLote.Tables.Count > 0 Then
                            'If oDSContratoLote.Tables("ContratoLote").Rows.Count > 0 Then
                            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                                Return oDSContratoLote
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function


        Public Function LeerListaToDSComercial_Resultado(ByVal pContratoLote As clsBE_ContratoLote) As DataSet
            Dim oDSContratoLote As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(0) As SqlParameter
            prmParameter(0) = New SqlParameter("@Periodo", SqlDbType.VarChar, 15)
            prmParameter(0).Value = IIf(IsNothing(pContratoLote.comentarios), "", pContratoLote.comentarios)
            Try

                Using oDSContratoLote
                    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "Comercial_Resultado", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sellst", oDSContratoLote, New String() {"ContratoLote"}, prmParameter)
                    If Not oDSContratoLote Is Nothing Then
                        If oDSContratoLote.Tables.Count > 0 Then
                            'If oDSContratoLote.Tables("ContratoLote").Rows.Count > 0 Then
                            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                                Return oDSContratoLote
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function


        Public Function LeerListaToDSComposicionComercial(ByVal pContratoLote As clsBE_ContratoLote) As DataSet
            Dim oDSContratoLote As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(1) As SqlParameter
            prmParameter(0) = New SqlParameter("@Emp", SqlDbType.VarChar, 15)
            prmParameter(0).Value = "" 'IIf(IsNothing(pContratoLote.codigoTabla), "", pContratoLote.codigoTabla)
            prmParameter(1) = New SqlParameter("@Per", SqlDbType.VarChar, 15)
            prmParameter(1).Value = "" 'IIf(IsNothing(pContratoLote.comentarios), "", pContratoLote.comentarios)
            Try

                Using oDSContratoLote
                    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "Comercial_ComposicionCom", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sellst", oDSContratoLote, New String() {"ContratoLote"}, prmParameter)
                    If Not oDSContratoLote Is Nothing Then
                        If oDSContratoLote.Tables.Count > 0 Then
                            'If oDSContratoLote.Tables("ContratoLote").Rows.Count > 0 Then
                            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                                Return oDSContratoLote
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function


        Public Function LeerListaToDSComposicionContable(ByVal pContratoLote As clsBE_ContratoLote) As DataSet
            Dim oDSContratoLote As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(1) As SqlParameter
            prmParameter(0) = New SqlParameter("@Emp", SqlDbType.VarChar, 15)
            prmParameter(0).Value = "" 'IIf(IsNothing(pContratoLote.codigoTabla), "", pContratoLote.codigoTabla)
            prmParameter(1) = New SqlParameter("@Per", SqlDbType.VarChar, 15)
            prmParameter(1).Value = "" 'IIf(IsNothing(pContratoLote.comentarios), "", pContratoLote.comentarios)
            Try

                Using oDSContratoLote
                    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "Comercial_ComposicionContable", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sellst", oDSContratoLote, New String() {"ContratoLote"}, prmParameter)
                    If Not oDSContratoLote Is Nothing Then
                        If oDSContratoLote.Tables.Count > 0 Then
                            'If oDSContratoLote.Tables("ContratoLote").Rows.Count > 0 Then
                            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                                Return oDSContratoLote
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function


        Public Function LeerListaToDSComposicionMezcla(ByVal pContratoLote As clsBE_ContratoLote) As DataSet
            Dim oDSContratoLote As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(1) As SqlParameter
            prmParameter(0) = New SqlParameter("@Emp", SqlDbType.VarChar, 15)
            prmParameter(0).Value = "" 'IIf(IsNothing(pContratoLote.codigoTabla), "", pContratoLote.codigoTabla)
            prmParameter(1) = New SqlParameter("@Per", SqlDbType.VarChar, 15)
            prmParameter(1).Value = "" 'IIf(IsNothing(pContratoLote.comentarios), "", pContratoLote.comentarios)
            Try

                Using oDSContratoLote
                    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "Comercial_ComposicionMezcla", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sellst", oDSContratoLote, New String() {"ContratoLote"}, prmParameter)
                    If Not oDSContratoLote Is Nothing Then
                        If oDSContratoLote.Tables.Count > 0 Then
                            'If oDSContratoLote.Tables("ContratoLote").Rows.Count > 0 Then
                            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                                Return oDSContratoLote
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function


        Public Function LeerListaToDSCoberturas(ByVal pContratoLote As clsBE_ContratoLote) As DataSet
            Dim oDSContratoLote As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(1) As SqlParameter
            prmParameter(0) = New SqlParameter("@Emp", SqlDbType.VarChar, 15)
            prmParameter(0).Value = "" 'IIf(IsNothing(pContratoLote.codigoTabla), "", pContratoLote.codigoTabla)
            prmParameter(1) = New SqlParameter("@Per", SqlDbType.VarChar, 15)
            prmParameter(1).Value = "" 'IIf(IsNothing(pContratoLote.comentarios), "", pContratoLote.comentarios)
            Try

                Using oDSContratoLote
                    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "Comercial_Coberturas", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sellst", oDSContratoLote, New String() {"ContratoLote"}, prmParameter)
                    If Not oDSContratoLote Is Nothing Then
                        If oDSContratoLote.Tables.Count > 0 Then
                            'If oDSContratoLote.Tables("ContratoLote").Rows.Count > 0 Then
                            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                                Return oDSContratoLote
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function

        Public Function LeerListaToDSConsultaLiq(ByVal pContratoLote As clsBE_ContratoLote) As DataSet
            Dim oDSContratoLote As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(1) As SqlParameter
            prmParameter(0) = New SqlParameter("@FechaIni", SqlDbType.VarChar, 15)
            prmParameter(0).Value = IIf(IsNothing(pContratoLote.periodo_origen), "", pContratoLote.periodo_origen)
            prmParameter(1) = New SqlParameter("@FechaFin", SqlDbType.VarChar, 15)
            prmParameter(1).Value = IIf(IsNothing(pContratoLote.periodo_destino), "", pContratoLote.periodo_destino)
            Try

                Using oDSContratoLote
                    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "PA_REPORTELIQUIDACIONES", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sellst", oDSContratoLote, New String() {"ContratoLote"}, prmParameter)
                    If Not oDSContratoLote Is Nothing Then
                        If oDSContratoLote.Tables.Count > 0 Then
                            'If oDSContratoLote.Tables("ContratoLote").Rows.Count > 0 Then
                            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                                Return oDSContratoLote
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function

        Public Function LeerListaToDSDesempeño(ByVal pContratoLote As clsBE_ContratoLote) As DataSet
            Dim oDSContratoLote As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(1) As SqlParameter
            prmParameter(0) = New SqlParameter("@Emp", SqlDbType.VarChar, 15)
            prmParameter(0).Value = "" 'IIf(IsNothing(pContratoLote.codigoTabla), "", pContratoLote.codigoTabla)
            prmParameter(1) = New SqlParameter("@Per", SqlDbType.VarChar, 15)
            prmParameter(1).Value = "" 'IIf(IsNothing(pContratoLote.comentarios), "", pContratoLote.comentarios)
            Try

                Using oDSContratoLote
                    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "Comercial_Desempeño", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sellst", oDSContratoLote, New String() {"ContratoLote"}, prmParameter)
                    If Not oDSContratoLote Is Nothing Then
                        If oDSContratoLote.Tables.Count > 0 Then
                            'If oDSContratoLote.Tables("ContratoLote").Rows.Count > 0 Then
                            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                                Return oDSContratoLote
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function







        Public Function LeerListaToDSContable_CuadreTMH(ByVal pContratoLote As clsBE_ContratoLote) As DataSet
            Dim oDSContratoLote As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(0) As SqlParameter
            prmParameter(0) = New SqlParameter("@Periodo", SqlDbType.VarChar, 15)
            prmParameter(0).Value = IIf(IsNothing(pContratoLote.comentarios), "", pContratoLote.comentarios)
            Try

                Dim cnx As New SqlConnection(CadenaConexion)
                Dim cmd As New SqlCommand()
                Dim da As New SqlDataAdapter()

                cmd.Connection = cnx
                cmd.CommandText = "Contable_CuadreTMH"
                cmd.Parameters.Add("@Periodo", pContratoLote.comentarios)
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandTimeout = 200

                da.SelectCommand = cmd

                da.Fill(oDSContratoLote)

                ''Using oDSContratoLote
                ''    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "Contable_CuadreTMH", prmParameter)
                ''    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sellst", oDSContratoLote, New String() {"ContratoLote"}, prmParameter)
                ''    If Not oDSContratoLote Is Nothing Then
                ''        If oDSContratoLote.Tables.Count > 0 Then
                ''            'If oDSContratoLote.Tables("ContratoLote").Rows.Count > 0 Then
                ''            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                ''                Return oDSContratoLote
                ''            End If
                ''        End If
                ''    End If
                ''End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function


        Public Function LeerListaToDSContable_DiferenciaTMHVenta(ByVal pContratoLote As clsBE_ContratoLote) As DataSet
            Dim oDSContratoLote As New DataSet
            Dim mintItem As Integer = 0
            ''Dim prmParameter(2) As SqlParameter

            ''prmParameter(0) = New SqlParameter("@Periodo", SqlDbType.VarChar, 15)
            ''prmParameter(0).Value = IIf(IsNothing(pContratoLote.comentarios), "", pContratoLote.comentarios)

            ''prmParameter(1) = New SqlParameter("@empresa", SqlDbType.VarChar, 15)
            ''prmParameter(1).Value = IIf(IsNothing(pContratoLote.comentarios), "", pContratoLote.codigoEmpresa)

            ''prmParameter(2) = New SqlParameter("@usuario", SqlDbType.VarChar, 15)
            ''prmParameter(2).Value = IIf(IsNothing(pContratoLote.comentarios), "", pContratoLote.um)
            Try

                Dim cnx As New SqlConnection(CadenaConexion)
                Dim cmd As New SqlCommand()
                Dim da As New SqlDataAdapter()

                cmd.Connection = cnx
                cmd.CommandText = "PA_DiferenciaLotesVenta_vs_Concar"
                cmd.Parameters.Add("@Periodo_origen", pContratoLote.periodo_origen)
                cmd.Parameters.Add("@Periodo_destino", pContratoLote.periodo_destino)
                cmd.Parameters.Add("@empresa", pContratoLote.codigoEmpresa)
                cmd.Parameters.Add("@usuario", pContratoLote.um)
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandTimeout = 200

                da.SelectCommand = cmd

                da.Fill(oDSContratoLote)

            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function

        Public Function LeerListaToDSContable_CompraMezcla(ByVal pContratoLote As clsBE_ContratoLote) As DataSet
            Dim oDSContratoLote As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(0) As SqlParameter
            prmParameter(0) = New SqlParameter("@Periodo", SqlDbType.VarChar, 15)
            prmParameter(0).Value = IIf(IsNothing(pContratoLote.comentarios), "", pContratoLote.comentarios)
            Try

                Using oDSContratoLote
                    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "Contable_CompraMezcla", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sellst", oDSContratoLote, New String() {"ContratoLote"}, prmParameter)
                    If Not oDSContratoLote Is Nothing Then
                        If oDSContratoLote.Tables.Count > 0 Then
                            'If oDSContratoLote.Tables("ContratoLote").Rows.Count > 0 Then
                            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                                Return oDSContratoLote
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function

        Public Function LeerListaToDSContable_CompraVenta(ByVal pContratoLote As clsBE_ContratoLote) As DataSet
            Dim oDSContratoLote As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(0) As SqlParameter
            prmParameter(0) = New SqlParameter("@Periodo", SqlDbType.VarChar, 15)
            prmParameter(0).Value = IIf(IsNothing(pContratoLote.comentarios), "", pContratoLote.comentarios)
            Try

                Using oDSContratoLote
                    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "Contable_CompraVenta", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sellst", oDSContratoLote, New String() {"ContratoLote"}, prmParameter)
                    If Not oDSContratoLote Is Nothing Then
                        If oDSContratoLote.Tables.Count > 0 Then
                            'If oDSContratoLote.Tables("ContratoLote").Rows.Count > 0 Then
                            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                                Return oDSContratoLote
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function

        Public Function LeerListaToDSContable_Estimaciones(ByVal pContratoLote As clsBE_ContratoLote) As DataSet
            Dim oDSContratoLote As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(0) As SqlParameter
            prmParameter(0) = New SqlParameter("@Periodo", SqlDbType.VarChar, 15)
            prmParameter(0).Value = IIf(IsNothing(pContratoLote.comentarios), "", pContratoLote.comentarios)
            Try

                Using oDSContratoLote
                    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "Contable_Estimaciones", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sellst", oDSContratoLote, New String() {"ContratoLote"}, prmParameter)
                    If Not oDSContratoLote Is Nothing Then
                        If oDSContratoLote.Tables.Count > 0 Then
                            'If oDSContratoLote.Tables("ContratoLote").Rows.Count > 0 Then
                            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                                Return oDSContratoLote
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function

        Public Function LeerListaToDSContable_LiquidacionesLote(ByVal pContratoLote As clsBE_ContratoLote) As DataSet
            Dim oDSContratoLote As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(0) As SqlParameter
            prmParameter(0) = New SqlParameter("@Periodo", SqlDbType.VarChar, 15)
            prmParameter(0).Value = IIf(IsNothing(pContratoLote.comentarios), "", pContratoLote.comentarios)
            Try

                Using oDSContratoLote
                    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "pa_LiquidacionesporLote", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sellst", oDSContratoLote, New String() {"ContratoLote"}, prmParameter)
                    If Not oDSContratoLote Is Nothing Then
                        If oDSContratoLote.Tables.Count > 0 Then
                            'If oDSContratoLote.Tables("ContratoLote").Rows.Count > 0 Then
                            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                                Return oDSContratoLote
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function


        Public Function LeerListaToDSContable_Vinculadas(ByVal pContratoLote As clsBE_ContratoLote) As DataSet
            Dim oDSContratoLote As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(1) As SqlParameter
            prmParameter(0) = New SqlParameter("@periodo", SqlDbType.VarChar, 15)
            prmParameter(0).Value = IIf(IsNothing(pContratoLote.comentarios), "", pContratoLote.comentarios)

            prmParameter(1) = New SqlParameter("@empresa", SqlDbType.VarChar, 15)
            prmParameter(1).Value = IIf(IsNothing(pContratoLote.codigoEmpresa), "", pContratoLote.codigoEmpresa)
            Try

                Using oDSContratoLote
                    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "Contable_Vinculaciones", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sellst", oDSContratoLote, New String() {"ContratoLote"}, prmParameter)
                    If Not oDSContratoLote Is Nothing Then
                        If oDSContratoLote.Tables.Count > 0 Then
                            'If oDSContratoLote.Tables("ContratoLote").Rows.Count > 0 Then
                            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                                Return oDSContratoLote
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function


        Public Function LeerListaToDSContable_Movimiento(ByVal pContratoLote As clsBE_ContratoLote) As DataSet
            Dim oDSContratoLote As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(1) As SqlParameter
            prmParameter(0) = New SqlParameter("@periodo", SqlDbType.VarChar, 15)
            prmParameter(0).Value = IIf(IsNothing(pContratoLote.comentarios), "", pContratoLote.comentarios)

            prmParameter(1) = New SqlParameter("@empresa", SqlDbType.VarChar, 15)
            prmParameter(1).Value = IIf(IsNothing(pContratoLote.codigoEmpresa), "", pContratoLote.codigoEmpresa)
            Try


                Dim cnx As New SqlConnection(CadenaConexion)
                Dim cmd As New SqlCommand()
                Dim da As New SqlDataAdapter()

                cmd.Connection = cnx
                cmd.CommandText = "up_Contable_MovimientosMes"
                cmd.Parameters.Add("@Periodo", pContratoLote.comentarios)
                cmd.Parameters.Add("@empresa", pContratoLote.codigoEmpresa)
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandTimeout = 200

                da.SelectCommand = cmd

                da.Fill(oDSContratoLote)

                ''Using oDSContratoLote
                ''    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_Contable_MovimientosMes", prmParameter)
                ''    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sellst", oDSContratoLote, New String() {"ContratoLote"}, prmParameter)
                ''    If Not oDSContratoLote Is Nothing Then
                ''        If oDSContratoLote.Tables.Count > 0 Then
                ''            'If oDSContratoLote.Tables("ContratoLote").Rows.Count > 0 Then
                ''            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                ''                Return oDSContratoLote
                ''            End If
                ''        End If
                ''    End If
                ''End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function

        Public Function LeerListaToDSContable_Movimiento_New(ByVal pContratoLote As clsBE_ContratoLote) As DataSet
            Dim oDSContratoLote As New DataSet
            Dim mintItem As Integer = 0
           

            Try


                Dim cnx As New SqlConnection(CadenaConexion)
                Dim cmd As New SqlCommand()
                Dim da As New SqlDataAdapter()

                cmd.Connection = cnx
                cmd.CommandText = "PA_MovimientosAnual"
                cmd.Parameters.Add("@PERIODO_ORIGEN", pContratoLote.periodo_origen)
                cmd.Parameters.Add("@PERIODO_DESTINO", pContratoLote.periodo_destino)
                cmd.Parameters.Add("@EMPRESA", pContratoLote.codigoEmpresa)
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandTimeout = 200

                da.SelectCommand = cmd

                da.Fill(oDSContratoLote)

                ''Using oDSContratoLote
                ''    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_Contable_MovimientosMes", prmParameter)
                ''    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sellst", oDSContratoLote, New String() {"ContratoLote"}, prmParameter)
                ''    If Not oDSContratoLote Is Nothing Then
                ''        If oDSContratoLote.Tables.Count > 0 Then
                ''            'If oDSContratoLote.Tables("ContratoLote").Rows.Count > 0 Then
                ''            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                ''                Return oDSContratoLote
                ''            End If
                ''        End If
                ''    End If
                ''End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function



        Public Function LeerListaToDSContable_Kardex(sTipo As String, ByVal pContratoLote As clsBE_ContratoLote) As DataSet
            Dim oDSContratoLote As New DataSet
            ''Dim mintItem As Integer = 0
            ''Dim prmParameter(1) As SqlParameter
            ''prmParameter(0) = New SqlParameter("@AS_EMPRESA", SqlDbType.VarChar, 10)
            ''prmParameter(0).Value = IIf(IsNothing(pContratoLote.comentarios), "", pContratoLote.comentarios)

            ''prmParameter(1) = New SqlParameter("@PERIODO", SqlDbType.VarChar, 6)
            ''prmParameter(1).Value = IIf(IsNothing(pContratoLote.codigoEmpresa), "", pContratoLote.codigoEmpresa)
            Try
                Dim sSentenciaSQL As String = IIf(sTipo = "N", "PA_GENERA_KARDEX", "PA_GENERA_KARDEX_ANTERIOR")

                Dim cnx As New SqlConnection(CadenaConexion)
                Dim cmd As New SqlCommand()
                Dim da As New SqlDataAdapter()

                cmd.Connection = cnx
                cmd.CommandText = sSentenciaSQL
                cmd.Parameters.Add("@AS_EMPRESA", pContratoLote.codigoEmpresa)
                cmd.Parameters.Add("@PERIODO", pContratoLote.comentarios)
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandTimeout = 500

                da.SelectCommand = cmd

                da.Fill(oDSContratoLote)


            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function


        Public Function LeerListaToDSMatriz_mezcla(ByVal pContratoLote As clsBE_ContratoLote) As DataSet
            Dim oDSContratoLote As New DataSet
            Try

                Dim cnx As New SqlConnection(CadenaConexion)
                Dim cmd As New SqlCommand()
                Dim da As New SqlDataAdapter()

                cmd.Connection = cnx
                cmd.CommandText = "PA_matrizCostoMezcla"
                cmd.Parameters.Add("@EMPRESA", pContratoLote.codigoEmpresa)
                cmd.Parameters.Add("@PERIODO", pContratoLote.comentarios)
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandTimeout = 200

                da.SelectCommand = cmd

                da.Fill(oDSContratoLote)


            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function



        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 13/11/2010 14:58:04
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSReporteLista(ByVal pContratoLote As clsBE_ContratoLote) As DataSet
            Dim oDSContratoLote As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(1) As SqlParameter
            prmParameter(0) = New SqlParameter("@Emp", SqlDbType.VarChar, 15)
            prmParameter(0).Value = "" 'IIf(IsNothing(pContratoLote.codigoTabla), "", pContratoLote.codigoTabla)
            prmParameter(1) = New SqlParameter("@Per", SqlDbType.VarChar, 15)
            prmParameter(1).Value = "" 'IIf(IsNothing(pContratoLote.comentarios), "", pContratoLote.comentarios)
            Try

                Using oDSContratoLote
                    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "usp_reporte_ReporteLista", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sellst", oDSContratoLote, New String() {"ContratoLote"}, prmParameter)
                    If Not oDSContratoLote Is Nothing Then
                        If oDSContratoLote.Tables.Count > 0 Then
                            'If oDSContratoLote.Tables("ContratoLote").Rows.Count > 0 Then
                            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                                Return oDSContratoLote
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function





        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 13/11/2010 14:58:04
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSContabilidad(ByVal pContratoLote As clsBE_ContratoLote) As DataSet
            Dim oDSContratoLote As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(3) As SqlParameter

            'prmParameter(0) = New SqlParameter("@Emp", SqlDbType.VarChar, 15)
            'prmParameter(0).Value = IIf(IsNothing(pContratoLote.codigoTabla), "", pContratoLote.codigoTabla)
            'prmParameter(1) = New SqlParameter("@Per", SqlDbType.VarChar, 15)
            'prmParameter(1).Value = IIf(IsNothing(pContratoLote.comentarios), "", pContratoLote.comentarios)

            'prmParameter(2) = New SqlParameter("@CodMovi", SqlDbType.VarChar, 1)
            'prmParameter(2).Value = IIf(IsNothing(pContratoLote.codigoMovimiento), "", pContratoLote.codigoMovimiento)
            'prmParameter(2).Direction = ParameterDirection.Input

            'prmParameter(3) = New SqlParameter("@CodClase", SqlDbType.VarChar, 200)
            'prmParameter(3).Value = IIf(IsNothing(pContratoLote.codigoClase), "", pContratoLote.codigoClase)
            'prmParameter(3).Direction = ParameterDirection.Input


            Try


                Dim cnx As New SqlConnection(CadenaConexion)
                Dim cmd As New SqlCommand()
                Dim da As New SqlDataAdapter()

                cmd.Connection = cnx
                cmd.CommandText = "pa_generaContabilidad"
                cmd.Parameters.Add("@Emp", IIf(IsNothing(pContratoLote.codigoTabla), "", pContratoLote.codigoTabla))
                cmd.Parameters.Add("@Per", IIf(IsNothing(pContratoLote.comentarios), "", pContratoLote.comentarios))
                cmd.Parameters.Add("@CodMovi", IIf(IsNothing(pContratoLote.codigoMovimiento), "", pContratoLote.codigoMovimiento))
                cmd.Parameters.Add("@CodClase", IIf(IsNothing(pContratoLote.codigoClase), "", pContratoLote.codigoClase))

                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandTimeout = 30000

                da.SelectCommand = cmd

                da.Fill(oDSContratoLote)
                'Return oDSContratoLote

                '$$$$$$
                'Using oDSContratoLote
                '    'oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "usp_resumen_contabilidad", prmParameter)
                '    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "pa_generaContabilidad", prmParameter)
                '    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sellst", oDSContratoLote, New String() {"ContratoLote"}, prmParameter)
                '    If Not oDSContratoLote Is Nothing Then
                '        If oDSContratoLote.Tables.Count > 0 Then
                '            'If oDSContratoLote.Tables("ContratoLote").Rows.Count > 0 Then
                '            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                '                Return oDSContratoLote
                '            End If
                '        End If
                '    End If
                'End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function

        '@01    AINI
        Public Function ExisteAsientoContableToLiquidacion(ByVal pContratoLote As clsBE_ContratoLote) As Boolean
            Dim validacion As Boolean
            Dim prmParameter(5) As SqlParameter

            prmParameter(0) = New SqlParameter("@contratoloteID", SqlDbType.VarChar, 20)
            prmParameter(0).Value = pContratoLote.contratoLoteId
            prmParameter(1) = New SqlParameter("@liquidacionID", SqlDbType.VarChar, 20)
            prmParameter(1).Value = pContratoLote.liquidacionId
            prmParameter(2) = New SqlParameter("@Emp", SqlDbType.VarChar, 10)
            prmParameter(2).Value = pContratoLote.codigoEmpresa
            prmParameter(3) = New SqlParameter("@Per", SqlDbType.VarChar, 6)
            prmParameter(3).Value = pContratoLote.periodo
            prmParameter(4) = New SqlParameter("@CodMovi", SqlDbType.VarChar, 1)
            prmParameter(4).Value = pContratoLote.codigoMovimiento

            prmParameter(5) = New SqlParameter("@EXISTE", SqlDbType.Decimal, 12)
            prmParameter(5).Direction = ParameterDirection.Output
            Try
                SqlHelper.ExecuteScalar(CadenaConexion, CommandType.StoredProcedure, "PA_ExisteLiqenConcar", prmParameter)
                validacion = IIf(CDec(prmParameter(5).Value) = 1, True, False)
            Catch ex As Exception
                Throw ex

            End Try
            Return validacion
        End Function
        '@01    AFIN

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 13/11/2010 14:58:04
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSContrato(ByVal pContratoLote As clsBE_ContratoLote) As DataSet
            Dim oDSContratoLote As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(3) As SqlParameter

            prmParameter(0) = New SqlParameter("@pcodigotabla", SqlDbType.VarChar, 15)
            prmParameter(0).Value = IIf(IsNothing(pContratoLote.codigoTabla), "", pContratoLote.codigoTabla)
            prmParameter(1) = New SqlParameter("@palcance_lote", SqlDbType.VarChar, 15)
            prmParameter(1).Value = IIf(IsNothing(pContratoLote.comentarios), "", pContratoLote.comentarios)
            prmParameter(2) = New SqlParameter("@pcontrato", SqlDbType.VarChar, 15)
            prmParameter(2).Value = IIf(IsNothing(pContratoLote.contrato), "", pContratoLote.contrato)

            prmParameter(3) = New SqlParameter("@permiso", SqlDbType.Char, 1)
            prmParameter(3).Value = IIf(IsNothing(pContratoLote.permiso), "", pContratoLote.permiso)
            Try

                Using oDSContratoLote
                    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sellst_Lista", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sellst", oDSContratoLote, New String() {"ContratoLote"}, prmParameter)
                    If Not oDSContratoLote Is Nothing Then
                        If oDSContratoLote.Tables.Count > 0 Then
                            'If oDSContratoLote.Tables("ContratoLote").Rows.Count > 0 Then
                            If oDSContratoLote.Tables(0).Rows.Count > 0 Then

                                Return oDSContratoLote
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function


        Public Function LeerListaToDSLoteMov(ByVal pContratoLote As clsBE_ContratoLote) As DataSet
            Dim oDSContratoLote As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(0) As SqlParameter
            prmParameter(0) = New SqlParameter("@codigoMovimiento", SqlDbType.VarChar, 15)
            prmParameter(0).Value = IIf(IsNothing(pContratoLote.codigoMovimiento), "", pContratoLote.codigoMovimiento)
            Try

                Using oDSContratoLote
                    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sellst_Lotes_Mov", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sellst", oDSContratoLote, New String() {"ContratoLote"}, prmParameter)
                    If Not oDSContratoLote Is Nothing Then
                        If oDSContratoLote.Tables.Count > 0 Then
                            'If oDSContratoLote.Tables("ContratoLote").Rows.Count > 0 Then
                            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                                Return oDSContratoLote
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:39:42
        ''' Proposito: Lee los datos de un registro
        ''' Fecha Modificacion:
        ''' </summary>
        ''' 
        Public Function VerificarNumeroLote(ByVal pContratoLote As clsBE_ContratoLote) As clsBE_ContratoLote
            Dim oContratoLote As clsBE_ContratoLote = Nothing
            Dim DSContratoLote As New DataSet
            Dim prmParameter(1) As SqlParameter
            prmParameter(0) = New SqlParameter("@pcontrato", SqlDbType.VarChar, 20)
            prmParameter(0).Value = IIf(IsNothing(pContratoLote.contrato), "", pContratoLote.codigoMovimiento + pContratoLote.contrato)
            prmParameter(1) = New SqlParameter("@plote", SqlDbType.VarChar, 20)
            prmParameter(1).Value = IIf(IsNothing(pContratoLote.lote), "", pContratoLote.lote)
            Try
                Using DSContratoLote
                    DSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sel_lote", prmParameter)
                    If Not DSContratoLote Is Nothing Then
                        If DSContratoLote.Tables.Count > 0 Then
                            oContratoLote = New clsBE_ContratoLote
                            If DSContratoLote.Tables(0).Rows.Count > 0 Then
                                With DSContratoLote.Tables(0).Rows(0)
                                    oContratoLote.contratoLoteId = .Item("contratoLoteId").ToString
                                    oContratoLote.codigoTabla = .Item("codigoTabla").ToString
                                    oContratoLote.codigoMovimiento = .Item("codigoMovimiento").ToString
                                    oContratoLote.contrato = .Item("contrato").ToString
                                    oContratoLote.codigoEmpresa = .Item("codigoEmpresa").ToString
                                    oContratoLote.codigoSocio = .Item("codigoSocio").ToString
                                    oContratoLote.lote = .Item("lote").ToString
                                    oContratoLote.codigoClase = .Item("codigoClase").ToString
                                    oContratoLote.codigoProducto = .Item("codigoProducto").ToString
                                    oContratoLote.cuota = .Item("cuota").ToString
                                    oContratoLote.direccion = .Item("direccion").ToString
                                    oContratoLote.codigoEstado = .Item("codigoEstado").ToString
                                    oContratoLote.uc = .Item("uc").ToString
                                    oContratoLote.fc = .Item("fc").ToString
                                    oContratoLote.tmAnualMinimo = .Item("tmAnualMinimo").ToString
                                    oContratoLote.tmAnualMaximo = .Item("tmAnualMaximo").ToString
                                    oContratoLote.tmMensualMinimo = .Item("tmMensualMinimo").ToString
                                    oContratoLote.tmMensualMaximo = .Item("tmMensualMaximo").ToString
                                    oContratoLote.adenda = .Item("adenda").ToString



                                    oContratoLote.VigenciaFin = .Item("VigenciaFin").ToString
                                End With
                            End If
                        End If
                    End If
                End Using
            Catch exSql As SqlException

            Catch ex As Exception
                Throw ex
            Finally
                If Not DSContratoLote Is Nothing Then
                    DSContratoLote.Dispose()
                End If
                DSContratoLote = Nothing
            End Try

            Return oContratoLote

        End Function
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:39:42
        ''' Proposito: Lee los datos de un registro
        ''' Fecha Modificacion:
        ''' </summary>
        ''' 
        Public Function VerificarNumeroContrato(ByVal pContratoLote As clsBE_ContratoLote) As clsBE_ContratoLote
            Dim oContratoLote As clsBE_ContratoLote = Nothing
            Dim DSContratoLote As New DataSet
            Dim prmParameter(1) As SqlParameter
            prmParameter(0) = New SqlParameter("@pcodigotabla", SqlDbType.VarChar, 20)
            prmParameter(0).Value = IIf(IsNothing(pContratoLote.codigoTabla), "", pContratoLote.codigoTabla)
            prmParameter(1) = New SqlParameter("@pcontrato", SqlDbType.VarChar, 20)
            prmParameter(1).Value = IIf(IsNothing(pContratoLote.contrato), "", pContratoLote.contrato)
            Try
                Using DSContratoLote
                    DSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_valida", prmParameter)
                    If Not DSContratoLote Is Nothing Then
                        If DSContratoLote.Tables.Count > 0 Then
                            oContratoLote = New clsBE_ContratoLote
                            If DSContratoLote.Tables(0).Rows.Count > 0 Then
                                With DSContratoLote.Tables(0).Rows(0)
                                    oContratoLote.contratoLoteId = .Item("contratoLoteId").ToString

                                End With
                            End If
                        End If
                    End If
                End Using
            Catch exSql As SqlException

            Catch ex As Exception
                Throw ex
            Finally
                If Not DSContratoLote Is Nothing Then
                    DSContratoLote.Dispose()
                End If
                DSContratoLote = Nothing
            End Try

            Return oContratoLote

        End Function




        ''' <summary>
        ''' Escrito por: Lissete MIyahira
        ''' Fecha Creacion: 08/01/2013 14:58:04
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSExtraccionVCM() As DataSet
            Dim oDSContratoLote As New DataSet
            Try
                '@02    AINI
                Dim cnn As New SqlConnection(CadenaConexion)
                Dim cmd As New SqlCommand
                Dim table As New SqlDataAdapter

                cmd.CommandText = "usp_reporte_ExtraccionVCM"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.CommandTimeout = 3000

                table.SelectCommand = cmd

                cnn.Open()

                table.Fill(oDSContratoLote)

                cnn.Close()
                '@02    AFIN

                '@02    DINI
                'Using oDSContratoLote
                '    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "usp_reporte_ExtraccionVCM")
                '    If Not oDSContratoLote Is Nothing Then
                '        If oDSContratoLote.Tables.Count > 0 Then
                '            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                '                Return oDSContratoLote
                '            End If
                '        End If
                '    End If
                'End Using
                '@02    DFIN
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function

        ''' <summary>
        ''' Extrae todas los registros de ventas en forma de lote
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function LeerListaToDSExtraccionVCM_Venta() As DataSet
            Dim oDSContratoLote As New DataSet
            Try

                '@02    AINI
                Dim cnn As New SqlConnection(CadenaConexion)
                Dim cmd As New SqlCommand
                Dim table As New SqlDataAdapter

                cmd.CommandText = "UPS_EXTRACCION_VENTAS"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.CommandTimeout = 120

                table.SelectCommand = cmd

                cnn.Open()

                table.Fill(oDSContratoLote)

                cnn.Close()

                'Using oDSContratoLote
                '    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "UPS_EXTRACCION_VENTAS")
                '    If Not oDSContratoLote Is Nothing Then
                '        If oDSContratoLote.Tables.Count > 0 Then
                '            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                '                Return oDSContratoLote
                '            End If
                '        End If
                '    End If
                'End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function

        Public Function LeerListaToDSSaldoBlend() As DataSet
            Dim oDSContratoLote As New DataSet
            Try

                '@02    AINI
                Dim cnn As New SqlConnection(CadenaConexion)
                Dim cmd As New SqlCommand
                Dim table As New SqlDataAdapter

                cmd.CommandText = "usp_reporte_ExtraccionVCM_Blend_Usayma "
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.CommandTimeout = 120

                table.SelectCommand = cmd

                cnn.Open()

                table.Fill(oDSContratoLote)

                cnn.Close()

                'Using oDSContratoLote
                '    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "UPS_EXTRACCION_VENTAS")
                '    If Not oDSContratoLote Is Nothing Then
                '        If oDSContratoLote.Tables.Count > 0 Then
                '            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                '                Return oDSContratoLote
                '            End If
                '        End If
                '    End If
                'End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function

        Public Function LeerListaToDSExtraccionVCM_Despacho() As DataSet
            Dim oDSContratoLote As New DataSet
            Try
                Using oDSContratoLote
                    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "UPS_EXTRACCION_DESPACHO")
                    If Not oDSContratoLote Is Nothing Then
                        If oDSContratoLote.Tables.Count > 0 Then
                            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                                Return oDSContratoLote
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 13/11/2010 14:58:04
        ''' Proposito: Obtiene la lista de costos y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSContratoLoteCosto(ByVal pContratoLote As clsBE_ContratoLote) As DataSet
            Dim oDSContratoLote As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(0) As SqlParameter
            prmParameter(0) = New SqlParameter("@contratoLoteId", SqlDbType.VarChar, 20)
            prmParameter(0).Value = IIf(IsNothing(pContratoLote.contratoLoteId), "", pContratoLote.contratoLoteId)
            Try

                Using oDSContratoLote
                    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "usp_ContratoLoteCosto", prmParameter)
                    If Not oDSContratoLote Is Nothing Then
                        If oDSContratoLote.Tables.Count > 0 Then
                            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                                Return oDSContratoLote
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function



        Public Function LeerListaToDSRumasPendientesVincular() As DataSet
            Dim oDSContratoLote As New DataSet
            'Dim mintItem As Integer = 0
            'Dim prmParameter(0) As SqlParameter
            'prmParameter(0) = New SqlParameter("@codigoMovimiento", SqlDbType.VarChar, 15)
            'prmParameter(0).Value = IIf(IsNothing(pContratoLote.codigoMovimiento), "", pContratoLote.codigoMovimiento)
            Try

                Using oDSContratoLote
                    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_rumasPendientesVincular")
                    If Not oDSContratoLote Is Nothing Then
                        If oDSContratoLote.Tables.Count > 0 Then
                            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                                Return oDSContratoLote
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function



        Public Function LeerListaToDSRumasPendientesLotizar() As DataSet
            Dim oDSContratoLote As New DataSet

            Try


                Dim cnx As New SqlConnection(CadenaConexion)
                Dim cmd As New SqlCommand()
                Dim da As New SqlDataAdapter()

                cmd.Connection = cnx
                cmd.CommandText = "up_rumas_pendientes_lotizar"
                 cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandTimeout = 3000

                da.SelectCommand = cmd

                da.Fill(oDSContratoLote)

                'Using oDSContratoLote
                '    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_rumas_pendientes_lotizar")
                '    If Not oDSContratoLote Is Nothing Then
                '        If oDSContratoLote.Tables.Count > 0 Then
                '            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                '                Return oDSContratoLote
                '            End If
                '        End If
                '    End If
                'End Using


            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function


        Public Function LeerListaToDSDocumentosVenta() As DataSet
            Dim oDSContratoLote As New DataSet

            Try

                Using oDSContratoLote
                    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_DOCUMENTOS_VENTAS")
                    If Not oDSContratoLote Is Nothing Then
                        If oDSContratoLote.Tables.Count > 0 Then
                            If oDSContratoLote.Tables(0).Rows.Count > 0 Then
                                Return oDSContratoLote
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function


        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub
    End Class
End Namespace

