


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
    ''' Fecha Creacion: 17/04/2011 08:58:10 p.m.
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla ContratoLote
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsDB_ContratoLoteTX

        Private Shared CadenaConexion As String
        'Public oBE_AuditoriaD As clsBE_AuditoriaD

        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/04/2011 08:58:10 p.m.
        ''' Proposito: Metodo de Insercci?n de Datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function InsertarContratoLote(ByVal oLstContratoLote As List(Of clsBE_ContratoLote)) As Boolean
            For Each oContratoLote As clsBE_ContratoLote In oLstContratoLote
                Dim prmParameter(29) As SqlParameter

                prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.VarChar, 20)
                'prmParameter(0).Value = IIf(IsNothing(oContratoLote.contratoLoteId), "", oContratoLote.contratoLoteId)
                prmParameter(0).Direction = ParameterDirection.Output
                prmParameter(1) = New SqlParameter("@pcodigoTabla", SqlDbType.VarChar, 15)
                prmParameter(1).Value = IIf(IsNothing(oContratoLote.codigoTabla), "", oContratoLote.codigoTabla)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pcodigoMovimiento", SqlDbType.VarChar, 15)
                prmParameter(2).Value = IIf(IsNothing(oContratoLote.codigoMovimiento), "", oContratoLote.codigoMovimiento)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@pcontrato", SqlDbType.VarChar, 18)
                prmParameter(3).Value = IIf(IsNothing(oContratoLote.contrato), 0, oContratoLote.contrato)
                prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@pcodigoEmpresa", SqlDbType.VarChar, 15)
                prmParameter(4).Value = IIf(IsNothing(oContratoLote.codigoEmpresa), "", oContratoLote.codigoEmpresa)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@pcodigoSocio", SqlDbType.VarChar, 15)
                prmParameter(5).Value = IIf(IsNothing(oContratoLote.codigoSocio), "", oContratoLote.codigoSocio)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@plote", SqlDbType.VarChar, 18)
                prmParameter(6).Value = IIf(IsNothing(oContratoLote.lote), 0, oContratoLote.lote)
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7) = New SqlParameter("@pcodigoClase", SqlDbType.VarChar, 15)
                prmParameter(7).Value = IIf(IsNothing(oContratoLote.codigoClase), "", oContratoLote.codigoClase)
                prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(8) = New SqlParameter("@pcodigoProducto", SqlDbType.VarChar, 15)
                prmParameter(8).Value = IIf(IsNothing(oContratoLote.codigoProducto), "", oContratoLote.codigoProducto)
                prmParameter(8).Direction = ParameterDirection.Input
                prmParameter(9) = New SqlParameter("@pcuota", SqlDbType.VarChar, 6)
                prmParameter(9).Value = IIf(IsNothing(oContratoLote.cuota), "", oContratoLote.cuota)
                prmParameter(9).Direction = ParameterDirection.Input
                prmParameter(10) = New SqlParameter("@pdireccion", SqlDbType.VarChar, 100)
                prmParameter(10).Value = IIf(IsNothing(oContratoLote.direccion), "", oContratoLote.direccion)
                prmParameter(10).Direction = ParameterDirection.Input
                prmParameter(11) = New SqlParameter("@pcodigoEstado", SqlDbType.VarChar, 15)
                prmParameter(11).Value = IIf(IsNothing(oContratoLote.codigoEstado), "", oContratoLote.codigoEstado)
                prmParameter(11).Direction = ParameterDirection.Input
                prmParameter(12) = New SqlParameter("@puc", SqlDbType.VarChar, 15)
                prmParameter(12).Value = IIf(IsNothing(oContratoLote.uc), "", oContratoLote.uc)
                prmParameter(12).Direction = ParameterDirection.Input
                prmParameter(13) = New SqlParameter("@ptmAnualMinimo", SqlDbType.Float, 4)
                prmParameter(13).Value = IIf(IsNothing(oContratoLote.tmAnualMinimo), 0, oContratoLote.tmAnualMinimo)
                prmParameter(13).Direction = ParameterDirection.Input
                prmParameter(14) = New SqlParameter("@ptmAnualMaximo", SqlDbType.Float, 4)
                prmParameter(14).Value = IIf(IsNothing(oContratoLote.tmAnualMaximo), 0, oContratoLote.tmAnualMaximo)
                prmParameter(14).Direction = ParameterDirection.Input
                prmParameter(15) = New SqlParameter("@ptmMensualMinimo", SqlDbType.Float, 4)
                prmParameter(15).Value = IIf(IsNothing(oContratoLote.tmMensualMinimo), 0, oContratoLote.tmMensualMinimo)
                prmParameter(15).Direction = ParameterDirection.Input
                prmParameter(16) = New SqlParameter("@ptmMensualMaximo", SqlDbType.Float, 4)
                prmParameter(16).Value = IIf(IsNothing(oContratoLote.tmMensualMaximo), 0, oContratoLote.tmMensualMaximo)
                prmParameter(16).Direction = ParameterDirection.Input
                prmParameter(17) = New SqlParameter("@padenda", SqlDbType.VarChar, 100)
                prmParameter(17).Value = IIf(IsNothing(oContratoLote.adenda), "", oContratoLote.adenda)
                prmParameter(17).Direction = ParameterDirection.Input
                prmParameter(18) = New SqlParameter("@pcalidad", SqlDbType.VarChar, 100)
                prmParameter(18).Value = IIf(IsNothing(oContratoLote.calidad), "", oContratoLote.calidad)
                prmParameter(18).Direction = ParameterDirection.Input
                prmParameter(19) = New SqlParameter("@pVigenciaInicio", SqlDbType.DateTime, 8)
                prmParameter(19).Value = clsUT_Funcion.FechaNull(oContratoLote.VigenciaInicio)
                prmParameter(19).Direction = ParameterDirection.Input
                prmParameter(20) = New SqlParameter("@pVigenciaFin", SqlDbType.DateTime, 8)
                prmParameter(20).Value = clsUT_Funcion.FechaNull(oContratoLote.VigenciaFin)
                prmParameter(20).Direction = ParameterDirection.Input
                prmParameter(21) = New SqlParameter("@pprocedencia", SqlDbType.VarChar, 100)
                prmParameter(21).Value = IIf(IsNothing(oContratoLote.procedencia), "", oContratoLote.procedencia)
                prmParameter(21).Direction = ParameterDirection.Input
                prmParameter(22) = New SqlParameter("@pcomentarios", SqlDbType.VarChar, 255)
                prmParameter(22).Value = IIf(IsNothing(oContratoLote.comentarios), "", oContratoLote.comentarios)
                prmParameter(22).Direction = ParameterDirection.Input
                prmParameter(23) = New SqlParameter("@pcodigoModo", SqlDbType.VarChar, 255)
                prmParameter(23).Value = IIf(IsNothing(oContratoLote.codigoModo), "", oContratoLote.codigoModo)
                prmParameter(23).Direction = ParameterDirection.Input
                prmParameter(24) = New SqlParameter("@pcodigoCalidad", SqlDbType.VarChar, 255)
                prmParameter(24).Value = IIf(IsNothing(oContratoLote.codigoCalidad), "", oContratoLote.codigoCalidad)
                prmParameter(24).Direction = ParameterDirection.Input

                prmParameter(25) = New SqlParameter("@pref1", SqlDbType.VarChar, 100)
                prmParameter(25).Value = IIf(IsNothing(oContratoLote.ref1), "", oContratoLote.ref1)
                prmParameter(25).Direction = ParameterDirection.Input

                prmParameter(26) = New SqlParameter("@pref2", SqlDbType.VarChar, 100)
                prmParameter(26).Value = IIf(IsNothing(oContratoLote.ref2), "", oContratoLote.ref2)
                prmParameter(26).Direction = ParameterDirection.Input

                prmParameter(27) = New SqlParameter("@pref3", SqlDbType.Float, 4)
                prmParameter(27).Value = IIf(IsNothing(oContratoLote.ref3), "", oContratoLote.ref3)
                prmParameter(27).Direction = ParameterDirection.Input

                prmParameter(28) = New SqlParameter("@pref4", SqlDbType.Float, 4)
                prmParameter(28).Value = IIf(IsNothing(oContratoLote.ref4), "", oContratoLote.ref4)
                prmParameter(28).Direction = ParameterDirection.Input

                prmParameter(29) = New SqlParameter("categoria", SqlDbType.VarChar, 10)
                prmParameter(29).Value = IIf(IsNothing(oContratoLote.categoria), "", oContratoLote.categoria)
                prmParameter(29).Direction = ParameterDirection.Input


                Try
                    If IIf(IsNothing(oContratoLote.codigoTabla), "", oContratoLote.codigoTabla) = "CON" Then
                        SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_ValidaDuplicado", prmParameter)
                    Else
                        SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Insertar", prmParameter)
                    End If
                    'SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Insertar", prmParameter)

                    oContratoLote.contratoLoteId = prmParameter(0).Value
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
        ''' Fecha Creacion: 17/04/2011 08:58:10 p.m.
        ''' Proposito: Metodo de Modificacion de datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function ModificarContratoLote(ByVal oLstContratoLote As List(Of clsBE_ContratoLote), ByVal oBE_AuditoriaD As clsBE_AuditoriaD) As Boolean
            For Each oContratoLote As clsBE_ContratoLote In oLstContratoLote
                Dim prmParameter(32) As SqlParameter

                prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(oContratoLote.contratoLoteId), "", oContratoLote.contratoLoteId)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pcodigoTabla", SqlDbType.VarChar, 15)
                prmParameter(1).Value = IIf(IsNothing(oContratoLote.codigoTabla), "", oContratoLote.codigoTabla)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pcodigoMovimiento", SqlDbType.VarChar, 15)
                prmParameter(2).Value = IIf(IsNothing(oContratoLote.codigoMovimiento), "", oContratoLote.codigoMovimiento)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@pcontrato", SqlDbType.VarChar, 18)
                prmParameter(3).Value = IIf(IsNothing(oContratoLote.contrato), 0, oContratoLote.contrato)
                prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@pcodigoEmpresa", SqlDbType.VarChar, 15)
                prmParameter(4).Value = IIf(IsNothing(oContratoLote.codigoEmpresa), "", oContratoLote.codigoEmpresa)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@pcodigoSocio", SqlDbType.VarChar, 15)
                prmParameter(5).Value = IIf(IsNothing(oContratoLote.codigoSocio), "", oContratoLote.codigoSocio)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@plote", SqlDbType.VarChar, 18)
                prmParameter(6).Value = IIf(IsNothing(oContratoLote.lote), 0, oContratoLote.lote)
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7) = New SqlParameter("@pcodigoClase", SqlDbType.VarChar, 15)
                prmParameter(7).Value = IIf(IsNothing(oContratoLote.codigoClase), "", oContratoLote.codigoClase)
                prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(8) = New SqlParameter("@pcodigoProducto", SqlDbType.VarChar, 15)
                prmParameter(8).Value = IIf(IsNothing(oContratoLote.codigoProducto), "", oContratoLote.codigoProducto)
                prmParameter(8).Direction = ParameterDirection.Input
                prmParameter(9) = New SqlParameter("@pcuota", SqlDbType.VarChar, 6)
                prmParameter(9).Value = IIf(IsNothing(oContratoLote.cuota), "", oContratoLote.cuota)
                prmParameter(9).Direction = ParameterDirection.Input
                prmParameter(10) = New SqlParameter("@pdireccion", SqlDbType.VarChar, 100)
                prmParameter(10).Value = IIf(IsNothing(oContratoLote.direccion), "", oContratoLote.direccion)
                prmParameter(10).Direction = ParameterDirection.Input
                prmParameter(11) = New SqlParameter("@pcodigoEstado", SqlDbType.VarChar, 15)
                prmParameter(11).Value = IIf(IsNothing(oContratoLote.codigoEstado), "", oContratoLote.codigoEstado)
                prmParameter(11).Direction = ParameterDirection.Input
                prmParameter(12) = New SqlParameter("@pum", SqlDbType.VarChar, 15)
                prmParameter(12).Value = IIf(IsNothing(oContratoLote.um), "", oContratoLote.um)
                prmParameter(12).Direction = ParameterDirection.Input
                prmParameter(13) = New SqlParameter("@pfm", SqlDbType.DateTime, 8)
                prmParameter(13).Value = clsUT_Funcion.FechaNull(oContratoLote.fm)
                prmParameter(13).Direction = ParameterDirection.Input
                prmParameter(14) = New SqlParameter("@ptmAnualMinimo", SqlDbType.Float, 4)
                prmParameter(14).Value = IIf(IsNothing(oContratoLote.tmAnualMinimo), 0, oContratoLote.tmAnualMinimo)
                prmParameter(14).Direction = ParameterDirection.Input
                prmParameter(15) = New SqlParameter("@ptmAnualMaximo", SqlDbType.Float, 4)
                prmParameter(15).Value = IIf(IsNothing(oContratoLote.tmAnualMaximo), 0, oContratoLote.tmAnualMaximo)
                prmParameter(15).Direction = ParameterDirection.Input
                prmParameter(16) = New SqlParameter("@ptmMensualMinimo", SqlDbType.Float, 4)
                prmParameter(16).Value = IIf(IsNothing(oContratoLote.tmMensualMinimo), 0, oContratoLote.tmMensualMinimo)
                prmParameter(16).Direction = ParameterDirection.Input
                prmParameter(17) = New SqlParameter("@ptmMensualMaximo", SqlDbType.Float, 4)
                prmParameter(17).Value = IIf(IsNothing(oContratoLote.tmMensualMaximo), 0, oContratoLote.tmMensualMaximo)
                prmParameter(17).Direction = ParameterDirection.Input
                prmParameter(18) = New SqlParameter("@padenda", SqlDbType.VarChar, 100)
                prmParameter(18).Value = IIf(IsNothing(oContratoLote.adenda), "", oContratoLote.adenda)
                prmParameter(18).Direction = ParameterDirection.Input
                prmParameter(19) = New SqlParameter("@pcalidad", SqlDbType.VarChar, 100)
                prmParameter(19).Value = IIf(IsNothing(oContratoLote.calidad), "", oContratoLote.calidad)
                prmParameter(19).Direction = ParameterDirection.Input
                prmParameter(20) = New SqlParameter("@pVigenciaInicio", SqlDbType.DateTime, 8)
                prmParameter(20).Value = clsUT_Funcion.FechaNull(oContratoLote.VigenciaInicio)
                prmParameter(20).Direction = ParameterDirection.Input
                prmParameter(21) = New SqlParameter("@pVigenciaFin", SqlDbType.DateTime, 8)
                prmParameter(21).Value = clsUT_Funcion.FechaNull(oContratoLote.VigenciaFin)
                prmParameter(21).Direction = ParameterDirection.Input
                prmParameter(22) = New SqlParameter("@pprocedencia", SqlDbType.VarChar, 100)
                prmParameter(22).Value = IIf(IsNothing(oContratoLote.procedencia), "", oContratoLote.procedencia)
                prmParameter(22).Direction = ParameterDirection.Input
                prmParameter(23) = New SqlParameter("@pcomentarios", SqlDbType.VarChar, 255)
                prmParameter(23).Value = IIf(IsNothing(oContratoLote.comentarios), "", oContratoLote.comentarios)
                prmParameter(23).Direction = ParameterDirection.Input
                prmParameter(24) = New SqlParameter("@pcodigoModo", SqlDbType.VarChar, 255)
                prmParameter(24).Value = IIf(IsNothing(oContratoLote.codigoModo), "", oContratoLote.codigoModo)
                prmParameter(24).Direction = ParameterDirection.Input
                prmParameter(25) = New SqlParameter("@pcodigoCalidad", SqlDbType.VarChar, 50)
                prmParameter(25).Value = IIf(IsNothing(oContratoLote.codigoCalidad), "", oContratoLote.codigoCalidad)
                prmParameter(25).Direction = ParameterDirection.Input


                prmParameter(26) = New SqlParameter("@pref1", SqlDbType.VarChar, 100)
                prmParameter(26).Value = IIf(IsNothing(oContratoLote.ref1), "", oContratoLote.ref1)
                prmParameter(26).Direction = ParameterDirection.Input

                prmParameter(27) = New SqlParameter("@pref2", SqlDbType.VarChar, 100)
                prmParameter(27).Value = IIf(IsNothing(oContratoLote.ref2), "", oContratoLote.ref2)
                prmParameter(27).Direction = ParameterDirection.Input

                prmParameter(28) = New SqlParameter("@pref3", SqlDbType.Float, 4)
                prmParameter(28).Value = IIf(IsNothing(oContratoLote.ref3), "", oContratoLote.ref3)
                prmParameter(28).Direction = ParameterDirection.Input

                prmParameter(29) = New SqlParameter("@pref4", SqlDbType.Float, 4)
                prmParameter(29).Value = IIf(IsNothing(oContratoLote.ref4), "", oContratoLote.ref4)
                prmParameter(29).Direction = ParameterDirection.Input


                prmParameter(30) = New SqlParameter("@categoria", SqlDbType.VarChar, 10)
                prmParameter(30).Value = IIf(IsNothing(oContratoLote.categoria), "", oContratoLote.categoria)
                prmParameter(30).Direction = ParameterDirection.Input

                prmParameter(31) = New SqlParameter("@LOTE_CERRADO", SqlDbType.VarChar, 10)
                prmParameter(31).Value = IIf(IsNothing(oContratoLote.LOTE_CERRADO), "", oContratoLote.LOTE_CERRADO)
                prmParameter(31).Direction = ParameterDirection.Input

                prmParameter(32) = New SqlParameter("preliquidacionFija", SqlDbType.Char, 1)
                prmParameter(32).Value = IIf(IsNothing(oContratoLote.preliquidacionFija), "0", IIf(oContratoLote.preliquidacionFija = "1", "1", "0"))
                prmParameter(32).Direction = ParameterDirection.Input

                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Upd", prmParameter)

                    ' ''Auditoria
                    ''Dim oDB_AuditoriaDTX As New clsDB_AuditoriaDTX

                    ''oBE_AuditoriaD.CadenaConexion = CadenaConexion
                    ''oBE_AuditoriaD.BaseDatos = CadenaConexion.Split(";")(1).Split("=")(1)
                    ' ''oBE_AuditoriaD.IdMenu = ""

                    ''oBE_AuditoriaD.IdAccion = "L"
                    ''oBE_AuditoriaD.NombreObjeto = "up_ContratoLote_Upd"
                    ''oBE_AuditoriaD.Tabla = "tbContratoLote"
                    ''oBE_AuditoriaD.Condicion = " contratoLoteId='" & prmParameter(0).Value & "'" ' and liquidacionId=" & prmParameter(1).Value

                    ''Dim lstAuditoriaD As New List(Of clsBE_AuditoriaD)
                    ''lstAuditoriaD.Add(oBE_AuditoriaD)
                    ''oDB_AuditoriaDTX.InsertarAuditoriaD(lstAuditoriaD)

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
        ''' Fecha Creacion: 17/04/2011 08:58:10 p.m.
        ''' Proposito: Metodo de Elimacion
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function EliminarContratoLote(ByVal oLstContratoLote As List(Of clsBE_ContratoLote)) As Boolean
            For Each oContratoLote As clsBE_ContratoLote In oLstContratoLote
                Dim prmParameter(0) As SqlParameter
                prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
                prmParameter(0).Value = IIf(IsNothing(oContratoLote.contratoLoteId), "", oContratoLote.contratoLoteId)
                prmParameter(0).Direction = ParameterDirection.Input
                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Del", prmParameter)
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
        ''' Fecha Creacion: 17/04/2011 08:58:10 p.m.
        ''' Proposito: Metodo de Guardar Dataset
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function GuardarContratoLote(ByVal oDSContratoLote As Dataset) As Boolean
            Dim cnxCPO As New SqlConnection(CadenaConexion)


            Try
                Dim objCommnadInsert As New SqlCommand
                objCommnadInsert.Connection = cnxCPO
                objCommnadInsert.CommandText = "up_ContratoLote_Ins"
                objCommnadInsert.CommandType = CommandType.StoredProcedure

                objCommnadInsert.Parameters.Add("@pcontratoLoteId", SqlDbType.varchar, 20).SourceColumn = "contratoLoteId"
                objCommnadInsert.Parameters.Add("@pcodigoTabla", SqlDbType.varchar, 15).SourceColumn = "codigoTabla"
                objCommnadInsert.Parameters.Add("@pcodigoMovimiento", SqlDbType.varchar, 15).SourceColumn = "codigoMovimiento"
                objCommnadInsert.Parameters.Add("@pcontrato", SqlDbType.varchar, 18).SourceColumn = "contrato"
                objCommnadInsert.Parameters.Add("@pcodigoEmpresa", SqlDbType.varchar, 15).SourceColumn = "codigoEmpresa"
                objCommnadInsert.Parameters.Add("@pcodigoSocio", SqlDbType.varchar, 15).SourceColumn = "codigoSocio"
                objCommnadInsert.Parameters.Add("@plote", SqlDbType.varchar, 18).SourceColumn = "lote"
                objCommnadInsert.Parameters.Add("@pcodigoClase", SqlDbType.varchar, 15).SourceColumn = "codigoClase"
                objCommnadInsert.Parameters.Add("@pcodigoProducto", SqlDbType.varchar, 15).SourceColumn = "codigoProducto"
                objCommnadInsert.Parameters.Add("@pcuota", SqlDbType.varchar, 6).SourceColumn = "cuota"
                objCommnadInsert.Parameters.Add("@pdireccion", SqlDbType.varchar, 100).SourceColumn = "direccion"
                objCommnadInsert.Parameters.Add("@pcodigoEstado", SqlDbType.varchar, 15).SourceColumn = "codigoEstado"
                objCommnadInsert.Parameters.Add("@puc", SqlDbType.varchar, 15).SourceColumn = "uc"
                objCommnadInsert.Parameters.Add("@ptmAnualMinimo", SqlDbType.Float, 4).SourceColumn = "tmAnualMinimo"
                objCommnadInsert.Parameters.Add("@ptmAnualMaximo", SqlDbType.Float, 4).SourceColumn = "tmAnualMaximo"
                objCommnadInsert.Parameters.Add("@ptmMensualMinimo", SqlDbType.Float, 4).SourceColumn = "tmMensualMinimo"
                objCommnadInsert.Parameters.Add("@ptmMensualMaximo", SqlDbType.Float, 4).SourceColumn = "tmMensualMaximo"
                objCommnadInsert.Parameters.Add("@padenda", SqlDbType.varchar, 100).SourceColumn = "adenda"
                objCommnadInsert.Parameters.Add("@pcalidad", SqlDbType.varchar, 100).SourceColumn = "calidad"
                objCommnadInsert.Parameters.Add("@pVigenciaInicio", SqlDbType.DateTime, 8).SourceColumn = "VigenciaInicio"
                objCommnadInsert.Parameters.Add("@pVigenciaFin", SqlDbType.DateTime, 8).SourceColumn = "VigenciaFin"
                objCommnadInsert.Parameters.Add("@pprocedencia", SqlDbType.varchar, 100).SourceColumn = "procedencia"
                objCommnadInsert.Parameters.Add("@pcomentarios", SqlDbType.varchar, 255).SourceColumn = "comentarios"
                objCommnadInsert.Parameters.Add("@pcodigoModo", SqlDbType.VarChar, 255).SourceColumn = "codigoModo"
                objCommnadInsert.Parameters.Add("@pref1", SqlDbType.VarChar, 100).SourceColumn = "ref1"
                objCommnadInsert.Parameters.Add("@pref2", SqlDbType.VarChar, 100).SourceColumn = "ref2"
                objCommnadInsert.Parameters.Add("@pref3", SqlDbType.Float, 4).SourceColumn = "ref3"
                objCommnadInsert.Parameters.Add("@pref4", SqlDbType.Float, 4).SourceColumn = "ref4"

                Dim objCommandUpdate As New SqlCommand
                objCommandUpdate.Connection = cnxCPO
                objCommandUpdate.CommandText = "up_ContratoLote_Upd"
                objCommandUpdate.CommandType = CommandType.StoredProcedure

                objCommandUpdate.Parameters.Add("@pcontratoLoteId", SqlDbType.varchar, 20).SourceColumn = "contratoLoteId"
                objCommandUpdate.Parameters.Add("@pcodigoTabla", SqlDbType.varchar, 15).SourceColumn = "codigoTabla"
                objCommandUpdate.Parameters.Add("@pcodigoMovimiento", SqlDbType.varchar, 15).SourceColumn = "codigoMovimiento"
                objCommandUpdate.Parameters.Add("@pcontrato", SqlDbType.varchar, 18).SourceColumn = "contrato"
                objCommandUpdate.Parameters.Add("@pcodigoEmpresa", SqlDbType.varchar, 15).SourceColumn = "codigoEmpresa"
                objCommandUpdate.Parameters.Add("@pcodigoSocio", SqlDbType.varchar, 15).SourceColumn = "codigoSocio"
                objCommandUpdate.Parameters.Add("@plote", SqlDbType.varchar, 18).SourceColumn = "lote"
                objCommandUpdate.Parameters.Add("@pcodigoClase", SqlDbType.varchar, 15).SourceColumn = "codigoClase"
                objCommandUpdate.Parameters.Add("@pcodigoProducto", SqlDbType.varchar, 15).SourceColumn = "codigoProducto"
                objCommandUpdate.Parameters.Add("@pcuota", SqlDbType.varchar, 6).SourceColumn = "cuota"
                objCommandUpdate.Parameters.Add("@pdireccion", SqlDbType.varchar, 100).SourceColumn = "direccion"
                objCommandUpdate.Parameters.Add("@pcodigoEstado", SqlDbType.varchar, 15).SourceColumn = "codigoEstado"
                objCommandUpdate.Parameters.Add("@pum", SqlDbType.varchar, 15).SourceColumn = "um"
                objCommandUpdate.Parameters.Add("@pfm", SqlDbType.DateTime, 8).SourceColumn = "fm"
                objCommandUpdate.Parameters.Add("@ptmAnualMinimo", SqlDbType.Float, 4).SourceColumn = "tmAnualMinimo"
                objCommandUpdate.Parameters.Add("@ptmAnualMaximo", SqlDbType.Float, 4).SourceColumn = "tmAnualMaximo"
                objCommandUpdate.Parameters.Add("@ptmMensualMinimo", SqlDbType.Float, 4).SourceColumn = "tmMensualMinimo"
                objCommandUpdate.Parameters.Add("@ptmMensualMaximo", SqlDbType.Float, 4).SourceColumn = "tmMensualMaximo"
                objCommandUpdate.Parameters.Add("@padenda", SqlDbType.varchar, 100).SourceColumn = "adenda"
                objCommandUpdate.Parameters.Add("@pcalidad", SqlDbType.varchar, 100).SourceColumn = "calidad"
                objCommandUpdate.Parameters.Add("@pVigenciaInicio", SqlDbType.DateTime, 8).SourceColumn = "VigenciaInicio"
                objCommandUpdate.Parameters.Add("@pVigenciaFin", SqlDbType.DateTime, 8).SourceColumn = "VigenciaFin"
                objCommandUpdate.Parameters.Add("@pprocedencia", SqlDbType.varchar, 100).SourceColumn = "procedencia"
                objCommandUpdate.Parameters.Add("@pcomentarios", SqlDbType.varchar, 255).SourceColumn = "comentarios"
                objCommandUpdate.Parameters.Add("@pcodigoModo", SqlDbType.VarChar, 255).SourceColumn = "codigoModo"
                objCommandUpdate.Parameters.Add("@pref1", SqlDbType.VarChar, 100).SourceColumn = "ref1"
                objCommandUpdate.Parameters.Add("@pref2", SqlDbType.VarChar, 100).SourceColumn = "ref2"
                objCommandUpdate.Parameters.Add("@pref3", SqlDbType.Float, 4).SourceColumn = "ref3"
                objCommandUpdate.Parameters.Add("@pref4", SqlDbType.Float, 4).SourceColumn = "ref4"

                Dim objCommandDelete As New SqlCommand
                objCommandDelete.Connection = cnxCPO
                objCommandDelete.CommandText = "up_ContratoLote_Del"
                objCommandDelete.CommandType = CommandType.StoredProcedure

                objCommandDelete.Parameters.Add("@pcontratoLoteId", SqlDbType.varchar, 20).SourceColumn = "contratoLoteId"

                'SqlHelper.UpdateDataset(objCommnadInsert, objCommandDelete, objCommandUpdate, oDSContratoLote, "ContratoLote")

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
    ''' Fecha Creacion: 17/04/2011 08:58:10 p.m.
    ''' Proposito: Obtiene los valores de la tabla ContratoLote
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsDB_ContratoLoteRO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/04/2011 08:58:10 p.m.
        ''' Proposito: Lee los datos de un registro
        ''' Fecha Modificacion:
        ''' </summary>
        ''' 
        Public Function LeerContratoLote(ByVal pContratoLote As clsBE_ContratoLote, ByVal oBE_AuditoriaD As clsBE_AuditoriaD) As clsBE_ContratoLote
            Dim oContratoLote As clsBE_ContratoLote = Nothing
            Dim DSContratoLote As New DataSet
            Dim prmParameter(0) As SqlParameter
            prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.VarChar, 20)
            prmParameter(0).Value = IIf(IsNothing(pContratoLote.contratoLoteId), "", pContratoLote.contratoLoteId)
            Try
                Using DSContratoLote
                    DSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sel", prmParameter)
                    If Not DSContratoLote Is Nothing Then
                        If DSContratoLote.Tables.Count > 0 Then
                            oContratoLote = New clsBE_ContratoLote
                            If DSContratoLote.Tables(0).Rows.Count > 0 Then
                                With DSContratoLote.Tables(0).Rows(0)
                                    oContratoLote.contratoLoteId = .Item("contratoLoteId").ToString
                                    oContratoLote.codigoTabla = .Item("codigoTabla").ToString
                                    oContratoLote.codigoMovimiento = .Item("codigoMovimiento").ToString
                                    oContratoLote.contrato = .Item("contrato").ToString

                                    oContratoLote.rucEmpresa = .Item("rucEmpresa").ToString

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

                                    oContratoLote.um = .Item("um").ToString
                                    oContratoLote.fm = IIf(.Item("fm").ToString = "", Nothing, .Item("fm").ToString)

                                    oContratoLote.tmAnualMinimo = .Item("tmAnualMinimo").ToString
                                    oContratoLote.tmAnualMaximo = .Item("tmAnualMaximo").ToString
                                    oContratoLote.tmMensualMinimo = .Item("tmMensualMinimo").ToString
                                    oContratoLote.tmMensualMaximo = .Item("tmMensualMaximo").ToString
                                    oContratoLote.adenda = .Item("adenda").ToString
                                    oContratoLote.calidad = .Item("calidad").ToString
                                    oContratoLote.VigenciaInicio = .Item("VigenciaInicio").ToString
                                    oContratoLote.VigenciaFin = .Item("VigenciaFin").ToString
                                    oContratoLote.procedencia = .Item("procedencia").ToString
                                    oContratoLote.comentarios = .Item("comentarios").ToString
                                    oContratoLote.codigoModo = .Item("codigoModo").ToString
                                    oContratoLote.codigoCalidad = .Item("codigoCalidad").ToString

                                    oContratoLote.otrosDescuentos = .Item("otrosDescuentos").ToString
                                    oContratoLote.descuento = .Item("descuento").ToString
                                    oContratoLote.adelanto = .Item("adelanto").ToString
                                    oContratoLote.detraccion = .Item("Detraccion").ToString

                                    oContratoLote.ref1 = .Item("ref1").ToString
                                    oContratoLote.ref2 = .Item("ref2").ToString
                                    oContratoLote.ref3 = .Item("ref3").ToString
                                    oContratoLote.ref4 = .Item("ref4").ToString

                                    oContratoLote.loteNuevo = .Item("loteNuevo").ToString

                                    oContratoLote.categoria = .Item("categoria").ToString


                                    oContratoLote.LOTE_CERRADO = .Item("LOTE_CERRADO").ToString

                                    oContratoLote.preliquidacionFija = .Item("preliquidacionFija").ToString


                                    ' ''Auditoria
                                    ''Dim oDB_AuditoriaDTX As New clsDB_AuditoriaDTX
                                    ' ''Dim oBE_AuditoriaD As New clsBE_AuditoriaD

                                    ' ''oBE_AuditoriaD.IdAuditoria = 1

                                    ''oBE_AuditoriaD.CadenaConexion = CadenaConexion
                                    ''oBE_AuditoriaD.BaseDatos = CadenaConexion.Split(";")(1).Split("=")(1)
                                    ' ''oBE_AuditoriaD.IdMenu = ""
                                    ''oBE_AuditoriaD.IdAccion = "L"
                                    ''oBE_AuditoriaD.NombreObjeto = "up_ContratoLote_Sel"
                                    ''oBE_AuditoriaD.Tabla = "TbContratoLote"
                                    ''oBE_AuditoriaD.Condicion = " contratoLoteId='" & prmParameter(0).Value & "'"

                                    ''Dim lstAuditoriaD As New List(Of clsBE_AuditoriaD)
                                    ''lstAuditoriaD.Add(oBE_AuditoriaD)
                                    ''oDB_AuditoriaDTX.InsertarAuditoriaD(lstAuditoriaD)


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







        'obtiene el lote de venta a partir de la mezcla
        Public Function ContratoLote_Sel_Venta(ByVal pContratoLote As clsBE_ContratoLote) As clsBE_ContratoLote
            Dim oContratoLote As clsBE_ContratoLote = Nothing
            Dim DSContratoLote As New DataSet
            Dim prmParameter(0) As SqlParameter
            prmParameter(0) = New SqlParameter("@LOTE_ORIGEN", SqlDbType.VarChar, 20)
            prmParameter(0).Value = IIf(IsNothing(pContratoLote.contratoLoteId), "", pContratoLote.contratoLoteId)
            Try
                Using DSContratoLote
                    DSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sel_Venta", prmParameter)
                    If Not DSContratoLote Is Nothing Then
                        If DSContratoLote.Tables.Count > 0 Then
                            oContratoLote = New clsBE_ContratoLote
                            If DSContratoLote.Tables(0).Rows.Count > 0 Then
                                With DSContratoLote.Tables(0).Rows(0)
                                    oContratoLote.contratoLoteId = .Item("contratoLoteId").ToString
                                    oContratoLote.lote = .Item("lote").ToString                                   
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
        ''' Fecha Creacion: 17/04/2011 08:58:10 p.m.
        ''' Proposito: Obtiene la lista de registros
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaContratoLote() As List(Of clsBE_ContratoLote)
            Dim olstContratoLote As New List(Of clsBE_ContratoLote)
            Dim oContratoLote As clsBE_ContratoLote = Nothing
            Dim mintItem As Integer = 0
            Try
                Using Reader As SqlDataReader = SqlHelper.ExecuteReader(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sellst")
                    If Reader.HasRows Then
                        While reader.Read
                            oContratoLote = New clsBE_ContratoLote
                            mintItem += 1
                            With oContratoLote
                                .Item = mintItem

                                .contratoLoteId = Reader("contratoLoteId").tostring
                                .codigoTabla = Reader("codigoTabla").tostring
                                .codigoMovimiento = Reader("codigoMovimiento").tostring
                                .contrato = Reader("contrato").tostring
                                .codigoEmpresa = Reader("codigoEmpresa").tostring
                                .codigoSocio = Reader("codigoSocio").tostring
                                .lote = Reader("lote").tostring
                                .codigoClase = Reader("codigoClase").tostring
                                .codigoProducto = Reader("codigoProducto").tostring
                                .cuota = Reader("cuota").tostring
                                .direccion = Reader("direccion").tostring
                                .codigoEstado = Reader("codigoEstado").tostring
                                .uc = Reader("uc").tostring
                                .fc = Reader("fc").tostring
                                .um = Reader("um").tostring
                                .fm = Reader("fm").tostring
                                .tmAnualMinimo = Reader("tmAnualMinimo").tostring
                                .tmAnualMaximo = Reader("tmAnualMaximo").tostring
                                .tmMensualMinimo = Reader("tmMensualMinimo").tostring
                                .tmMensualMaximo = Reader("tmMensualMaximo").tostring
                                .adenda = Reader("adenda").tostring
                                .calidad = Reader("calidad").tostring
                                .VigenciaInicio = Reader("VigenciaInicio").tostring
                                .VigenciaFin = Reader("VigenciaFin").tostring
                                .procedencia = Reader("procedencia").tostring
                                .comentarios = Reader("comentarios").tostring
                                .codigoModo = Reader("codigoModo").ToString
                                .codigoCalidad = Reader("codigoCalidad").ToString


                                .ref1 = Reader("ref1").ToString
                                .ref2 = Reader("ref2").ToString
                                .ref3 = Reader("ref3").ToString
                                .ref4 = Reader("ref4").ToString


                            End With
                            olstContratoLote.Add(oContratoLote)
                        End While
                    End If
                End Using
            Catch ex As Exception
                Throw ex
            End Try

            Return olstContratoLote

        End Function

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/04/2011 08:58:10 p.m.
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSContratoLote(ByVal pContratoLote As clsBE_ContratoLote) As Dataset
            Dim oDSContratoLote As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(-1) As SqlParameter
            Try

                Using oDSContratoLote
                    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Sellst", prmParameter)
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
        ''' Fecha Creacion: 17/04/2011 08:58:10 p.m.
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function DefinirTablaContratoLote() As DataTable

            Try
                Dim DTContratoLote As New DataTable

                Dim contratoLoteId As DataColumn = DTContratoLote.Columns.Add("contratoLoteId", GetType(String))
                contratoLoteId.MaxLength = 20
                contratoLoteId.AllowDBNull = False
                contratoLoteId.DefaultValue = ""

                Dim codigoTabla As DataColumn = DTContratoLote.Columns.Add("codigoTabla", GetType(String))
                codigoTabla.MaxLength = 15
                codigoTabla.AllowDBNull = True
                codigoTabla.DefaultValue = ""

                Dim codigoMovimiento As DataColumn = DTContratoLote.Columns.Add("codigoMovimiento", GetType(String))
                codigoMovimiento.MaxLength = 15
                codigoMovimiento.AllowDBNull = True
                codigoMovimiento.DefaultValue = ""

                Dim contrato As DataColumn = DTContratoLote.Columns.Add("contrato", GetType(String))
                contrato.MaxLength = 18
                contrato.AllowDBNull = True
                contrato.DefaultValue = ""

                Dim codigoEmpresa As DataColumn = DTContratoLote.Columns.Add("codigoEmpresa", GetType(String))
                codigoEmpresa.MaxLength = 15
                codigoEmpresa.AllowDBNull = True
                codigoEmpresa.DefaultValue = ""

                Dim codigoSocio As DataColumn = DTContratoLote.Columns.Add("codigoSocio", GetType(String))
                codigoSocio.MaxLength = 15
                codigoSocio.AllowDBNull = True
                codigoSocio.DefaultValue = ""

                Dim lote As DataColumn = DTContratoLote.Columns.Add("lote", GetType(String))
                lote.MaxLength = 18
                lote.AllowDBNull = True
                lote.DefaultValue = ""

                Dim codigoClase As DataColumn = DTContratoLote.Columns.Add("codigoClase", GetType(String))
                codigoClase.MaxLength = 15
                codigoClase.AllowDBNull = True
                codigoClase.DefaultValue = ""

                Dim codigoProducto As DataColumn = DTContratoLote.Columns.Add("codigoProducto", GetType(String))
                codigoProducto.MaxLength = 15
                codigoProducto.AllowDBNull = True
                codigoProducto.DefaultValue = ""

                Dim cuota As DataColumn = DTContratoLote.Columns.Add("cuota", GetType(String))
                cuota.MaxLength = 6
                cuota.AllowDBNull = True
                cuota.DefaultValue = ""

                Dim direccion As DataColumn = DTContratoLote.Columns.Add("direccion", GetType(String))
                direccion.MaxLength = 100
                direccion.AllowDBNull = True
                direccion.DefaultValue = ""

                Dim codigoEstado As DataColumn = DTContratoLote.Columns.Add("codigoEstado", GetType(String))
                codigoEstado.MaxLength = 15
                codigoEstado.AllowDBNull = True
                codigoEstado.DefaultValue = ""

                Dim uc As DataColumn = DTContratoLote.Columns.Add("uc", GetType(String))
                uc.MaxLength = 15
                uc.AllowDBNull = True
                uc.DefaultValue = ""

                Dim fc As DataColumn = DTContratoLote.Columns.Add("fc", GetType(DateTime))


                Dim um As DataColumn = DTContratoLote.Columns.Add("um", GetType(String))
                um.MaxLength = 15
                um.AllowDBNull = True
                um.DefaultValue = ""

                Dim fm As DataColumn = DTContratoLote.Columns.Add("fm", GetType(DateTime))


                Dim tmAnualMinimo As DataColumn = DTContratoLote.Columns.Add("tmAnualMinimo", GetType(Integer))
                tmAnualMinimo.AllowDBNull = True
                tmAnualMinimo.DefaultValue = 0


                Dim tmAnualMaximo As DataColumn = DTContratoLote.Columns.Add("tmAnualMaximo", GetType(Integer))
                tmAnualMaximo.AllowDBNull = True
                tmAnualMaximo.DefaultValue = 0


                Dim tmMensualMinimo As DataColumn = DTContratoLote.Columns.Add("tmMensualMinimo", GetType(Integer))
                tmMensualMinimo.AllowDBNull = True
                tmMensualMinimo.DefaultValue = 0


                Dim tmMensualMaximo As DataColumn = DTContratoLote.Columns.Add("tmMensualMaximo", GetType(Integer))
                tmMensualMaximo.AllowDBNull = True
                tmMensualMaximo.DefaultValue = 0


                Dim adenda As DataColumn = DTContratoLote.Columns.Add("adenda", GetType(String))
                adenda.MaxLength = 100
                adenda.AllowDBNull = True
                adenda.DefaultValue = ""

                Dim calidad As DataColumn = DTContratoLote.Columns.Add("calidad", GetType(String))
                calidad.MaxLength = 100
                calidad.AllowDBNull = True
                calidad.DefaultValue = ""

                Dim VigenciaInicio As DataColumn = DTContratoLote.Columns.Add("VigenciaInicio", GetType(DateTime))


                Dim VigenciaFin As DataColumn = DTContratoLote.Columns.Add("VigenciaFin", GetType(DateTime))


                Dim procedencia As DataColumn = DTContratoLote.Columns.Add("procedencia", GetType(String))
                procedencia.MaxLength = 100
                procedencia.AllowDBNull = True
                procedencia.DefaultValue = ""

                Dim comentarios As DataColumn = DTContratoLote.Columns.Add("comentarios", GetType(String))
                comentarios.MaxLength = 255
                comentarios.AllowDBNull = True
                comentarios.DefaultValue = ""

                Dim codigoModo As DataColumn = DTContratoLote.Columns.Add("codigoModo", GetType(String))
                codigoModo.MaxLength = 255
                codigoModo.AllowDBNull = True
                codigoModo.DefaultValue = ""




                Dim ref1 As DataColumn = DTContratoLote.Columns.Add("ref1", GetType(String))
                ref1.MaxLength = 100
                ref1.AllowDBNull = True
                ref1.DefaultValue = ""

                Dim ref2 As DataColumn = DTContratoLote.Columns.Add("ref2", GetType(String))
                ref2.MaxLength = 100
                ref2.AllowDBNull = True
                ref2.DefaultValue = ""

                Dim ref3 As DataColumn = DTContratoLote.Columns.Add("ref3", GetType(Double))
                ref3.AllowDBNull = True
                ref3.DefaultValue = 0

                Dim ref4 As DataColumn = DTContratoLote.Columns.Add("ref4", GetType(Double))
                ref4.AllowDBNull = True
                ref4.DefaultValue = 0



                Return DTContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function






        Public Function LeerListaToDSContratoLote_Vinculada(ByVal oBE_ContratoLote As clsBE_ContratoLote) As DataSet
            Dim oDSContratoLote As New DataSet
            Dim mintItem As Integer = 0
            Try
                Dim prmParameter(0) As SqlParameter
                prmParameter(0) = New SqlParameter("@contratoVinculada", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(oBE_ContratoLote.contrato), "", oBE_ContratoLote.contrato)

                Using oDSContratoLote
                    oDSContratoLote = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_ContratoLote_Vinculada", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_PUB_PERSONAS_Sellst", oDSPUB_PERSONAS, New String() {"PUB_PERSONAS"}, prmParameter)
                    If Not oDSContratoLote Is Nothing Then
                        If oDSContratoLote.Tables.Count > 0 Then
                            'If oDSPUB_PERSONAS.Tables("PUB_PERSONAS").Rows.Count > 0 Then
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




    End Class
#End Region

End Namespace
