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
    Public Class clsDB_ReporteCompraVentaRO

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub


        Public Function fnCalculaComparacionVentas(ByVal pReporteCompraVenta As clsBE_ReporteCompraVenta) As Boolean
            Dim lbResultado As Boolean = True

            Try

                Dim prmParameter(3) As SqlParameter

                prmParameter(0) = New SqlParameter("@anio_origen", SqlDbType.Int)
                prmParameter(0).Value = pReporteCompraVenta.nAnio_Origen

                prmParameter(1) = New SqlParameter("@anio_destino", SqlDbType.Int)
                prmParameter(1).Value = pReporteCompraVenta.nAnio_Destino

                prmParameter(2) = New SqlParameter("@mes_origen", SqlDbType.Int)
                prmParameter(2).Value = pReporteCompraVenta.nMes_Origen

                prmParameter(3) = New SqlParameter("@mes_destino", SqlDbType.Int)
                prmParameter(3).Value = pReporteCompraVenta.nMes_Destino

                SqlHelper.ExecuteScalar(CadenaConexion, CommandType.StoredProcedure, "up_RPT_Comparacion_Vent", prmParameter)
            Catch ex As Exception
                lbResultado = False
            End Try
            Return lbResultado
        End Function

        'genera el costo de venta segun periodo seleccionado
        Public Function ProcesaComprasVentas(ByVal pReporteCompraVenta As clsBE_ReporteCompraVenta) As Boolean
            'Dim validacion As Boolean
            ''Dim prmParameter(0) As SqlParameter

            ''prmParameter(0) = New SqlParameter("@periodo", SqlDbType.VarChar, 6)
            ''prmParameter(0).Value = pReporteCompraVenta.periodo

            Try
                ''SqlHelper.ExecuteScalar(CadenaConexion, CommandType.StoredProcedure, "up_ProcesaComprasVentas", prmParameter)



                Dim cnx As New SqlConnection(CadenaConexion)
                Dim cmd As New SqlCommand()
                'Dim da As New SqlDataAdapter()

                cmd.Connection = cnx
                cmd.CommandText = "up_ProcesaComprasVentas"
                cmd.Parameters.Add("@periodo", pReporteCompraVenta.periodo)
                'cmd.Parameters.Add("@producto", pReporteCompraVenta.producto)
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandTimeout = 2000

                cnx.Open()
                cmd.ExecuteNonQuery()
                cnx.Close()

                'da.SelectCommand = cmd
                'da.

            Catch ex As Exception
                Throw ex
                Return False
            End Try
            Return True

        End Function


        Public Function LeerListaToDSCompra_asignacion_Venta(ByVal pReporteCompraVenta As clsBE_ReporteCompraVenta) As DataSet
            Dim oDSContratoLote As New DataSet
            Try

                Dim cnx As New SqlConnection(CadenaConexion)
                Dim cmd As New SqlCommand()
                Dim da As New SqlDataAdapter()

                cmd.Connection = cnx
                cmd.CommandText = "up_LotesComprasVentas"
                cmd.Parameters.Add("@empresa", pReporteCompraVenta.empresa)
                cmd.Parameters.Add("@periodo", pReporteCompraVenta.periodo)
                cmd.Parameters.Add("@periodo_destino", pReporteCompraVenta.periodoFin)
                'cmd.Parameters.Add("@producto", pReporteCompraVenta.producto)
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandTimeout = 200

                da.SelectCommand = cmd

                da.Fill(oDSContratoLote)


            Catch ex As Exception
                Throw ex

            End Try
            Return oDSContratoLote

        End Function


        Public Function LeerListaToDSRepaticionRentabilidad(ByVal pReporteCompraVenta As clsBE_ReporteCompraVenta) As DataSet
            Dim oDSContratoLote As New DataSet
            Try

                Dim cnx As New SqlConnection(CadenaConexion)
                Dim cmd As New SqlCommand()
                Dim da As New SqlDataAdapter()

                cmd.Connection = cnx
                cmd.CommandText = "up_ReparticionRentabilidad"
                cmd.Parameters.Add("@empresa", pReporteCompraVenta.empresa)
                cmd.Parameters.Add("@periodo", pReporteCompraVenta.periodo)
                'cmd.Parameters.Add("@producto", pReporteCompraVenta.producto)
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
                cmd.CommandTimeout = 120

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
                cmd.CommandTimeout = 200

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

