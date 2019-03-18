


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
    ''' Fecha Creacion: 24/04/2011 10:54:50 a.m.
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla LiquidacionTm
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsDB_LiquidacionTmTX

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 24/04/2011 10:54:50 a.m.
        ''' Proposito: Metodo de Insercci?n de Datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function InsertarLiquidacionTm(ByVal oLstLiquidacionTm As List(Of clsBE_LiquidacionTm)) As Boolean
            For Each oLiquidacionTm As clsBE_LiquidacionTm In oLstLiquidacionTm
                Dim prmParameter(51) As SqlParameter

                prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacionTm.contratoLoteId), "", oLiquidacionTm.contratoLoteId)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
                prmParameter(1).Value = IIf(IsNothing(oLiquidacionTm.liquidacionId), "", oLiquidacionTm.liquidacionId)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pliquidacionTmId", SqlDbType.varchar, 20)
                prmParameter(2).Value = IIf(IsNothing(oLiquidacionTm.liquidacionTmId), "", oLiquidacionTm.liquidacionTmId)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@ptmh", SqlDbType.Float, 8)
                prmParameter(3).Value = IIf(IsNothing(oLiquidacionTm.tmh), 0, oLiquidacionTm.tmh)
                prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@ph2o", SqlDbType.Float, 8)
                prmParameter(4).Value = IIf(IsNothing(oLiquidacionTm.h2o), 0, oLiquidacionTm.h2o)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@ptms", SqlDbType.Float, 8)
                prmParameter(5).Value = IIf(IsNothing(oLiquidacionTm.tms), 0, oLiquidacionTm.tms)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@ptmsn", SqlDbType.Float, 8)
                prmParameter(6).Value = IIf(IsNothing(oLiquidacionTm.tmsn), 0, oLiquidacionTm.tmsn)
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7) = New SqlParameter("@pcodigoAnalisis", SqlDbType.varchar, 15)
                prmParameter(7).Value = IIf(IsNothing(oLiquidacionTm.codigoAnalisis), "", oLiquidacionTm.codigoAnalisis)
                prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(8) = New SqlParameter("@pcodigoLaboratorio", SqlDbType.varchar, 15)
                prmParameter(8).Value = IIf(IsNothing(oLiquidacionTm.codigoLaboratorio), "", oLiquidacionTm.codigoLaboratorio)
                prmParameter(8).Direction = ParameterDirection.Input
                prmParameter(9) = New SqlParameter("@pvalorLiquidacion", SqlDbType.Float, 8)
                prmParameter(9).Value = IIf(IsNothing(oLiquidacionTm.valorLiquidacion), 0, oLiquidacionTm.valorLiquidacion)
                prmParameter(9).Direction = ParameterDirection.Input
                prmParameter(10) = New SqlParameter("@pcodigoEstado", SqlDbType.varchar, 15)
                prmParameter(10).Value = IIf(IsNothing(oLiquidacionTm.codigoEstado), "", oLiquidacionTm.codigoEstado)
                prmParameter(10).Direction = ParameterDirection.Input
                prmParameter(11) = New SqlParameter("@puc", SqlDbType.varchar, 15)
                prmParameter(11).Value = IIf(IsNothing(oLiquidacionTm.uc), "", oLiquidacionTm.uc)
                prmParameter(11).Direction = ParameterDirection.Input
                prmParameter(12) = New SqlParameter("@pPagCu", SqlDbType.Float, 8)
                prmParameter(12).Value = IIf(IsNothing(oLiquidacionTm.PagCu), 0, oLiquidacionTm.PagCu)
                prmParameter(12).Direction = ParameterDirection.Input
                prmParameter(13) = New SqlParameter("@pPagZn", SqlDbType.Float, 8)
                prmParameter(13).Value = IIf(IsNothing(oLiquidacionTm.PagZn), 0, oLiquidacionTm.PagZn)
                prmParameter(13).Direction = ParameterDirection.Input
                prmParameter(14) = New SqlParameter("@pPagPb", SqlDbType.Float, 8)
                prmParameter(14).Value = IIf(IsNothing(oLiquidacionTm.PagPb), 0, oLiquidacionTm.PagPb)
                prmParameter(14).Direction = ParameterDirection.Input
                prmParameter(15) = New SqlParameter("@pPagAg", SqlDbType.Float, 8)
                prmParameter(15).Value = IIf(IsNothing(oLiquidacionTm.PagAg), 0, oLiquidacionTm.PagAg)
                prmParameter(15).Direction = ParameterDirection.Input
                prmParameter(16) = New SqlParameter("@pPagAu", SqlDbType.Float, 8)
                prmParameter(16).Value = IIf(IsNothing(oLiquidacionTm.PagAu), 0, oLiquidacionTm.PagAu)
                prmParameter(16).Direction = ParameterDirection.Input
                prmParameter(17) = New SqlParameter("@pPenAs", SqlDbType.Float, 8)
                prmParameter(17).Value = IIf(IsNothing(oLiquidacionTm.PenAs), 0, oLiquidacionTm.PenAs)
                prmParameter(17).Direction = ParameterDirection.Input
                prmParameter(18) = New SqlParameter("@pPenSb", SqlDbType.Float, 8)
                prmParameter(18).Value = IIf(IsNothing(oLiquidacionTm.PenSb), 0, oLiquidacionTm.PenSb)
                prmParameter(18).Direction = ParameterDirection.Input
                prmParameter(19) = New SqlParameter("@pPenBi", SqlDbType.Float, 8)
                prmParameter(19).Value = IIf(IsNothing(oLiquidacionTm.PenBi), 0, oLiquidacionTm.PenBi)
                prmParameter(19).Direction = ParameterDirection.Input
                prmParameter(20) = New SqlParameter("@pPenZn", SqlDbType.Float, 8)
                prmParameter(20).Value = IIf(IsNothing(oLiquidacionTm.PenZn), 0, oLiquidacionTm.PenZn)
                prmParameter(20).Direction = ParameterDirection.Input
                prmParameter(21) = New SqlParameter("@pPenPb", SqlDbType.Float, 8)
                prmParameter(21).Value = IIf(IsNothing(oLiquidacionTm.PenPb), 0, oLiquidacionTm.PenPb)
                prmParameter(21).Direction = ParameterDirection.Input
                prmParameter(22) = New SqlParameter("@pPenHg", SqlDbType.Float, 8)
                prmParameter(22).Value = IIf(IsNothing(oLiquidacionTm.PenHg), 0, oLiquidacionTm.PenHg)
                prmParameter(22).Direction = ParameterDirection.Input
                prmParameter(23) = New SqlParameter("@pPenSiO2", SqlDbType.Float, 8)
                prmParameter(23).Value = IIf(IsNothing(oLiquidacionTm.PenSiO2), 0, oLiquidacionTm.PenSiO2)
                prmParameter(23).Direction = ParameterDirection.Input
                prmParameter(24) = New SqlParameter("@pPen1", SqlDbType.Float, 8)
                prmParameter(24).Value = IIf(IsNothing(oLiquidacionTm.Pen1), 0, oLiquidacionTm.Pen1)
                prmParameter(24).Direction = ParameterDirection.Input
                prmParameter(25) = New SqlParameter("@pPen2", SqlDbType.Float, 8)
                prmParameter(25).Value = IIf(IsNothing(oLiquidacionTm.Pen2), 0, oLiquidacionTm.Pen2)
                prmParameter(25).Direction = ParameterDirection.Input
                prmParameter(26) = New SqlParameter("@pPen3", SqlDbType.Float, 8)
                prmParameter(26).Value = IIf(IsNothing(oLiquidacionTm.Pen3), 0, oLiquidacionTm.Pen3)
                prmParameter(26).Direction = ParameterDirection.Input
                prmParameter(27) = New SqlParameter("@pcodigoLote", SqlDbType.varchar, 20)
                prmParameter(27).Value = IIf(IsNothing(oLiquidacionTm.codigoLote), "", oLiquidacionTm.codigoLote)
                prmParameter(27).Direction = ParameterDirection.Input
                prmParameter(28) = New SqlParameter("@pfecha_ingreso", SqlDbType.DateTime, 8)
                prmParameter(28).Value = clsUT_Funcion.FechaNull(oLiquidacionTm.fecha_ingreso)
                prmParameter(28).Direction = ParameterDirection.Input
                prmParameter(29) = New SqlParameter("@pticket", SqlDbType.varchar, 20)
                prmParameter(29).Value = IIf(IsNothing(oLiquidacionTm.ticket), "", oLiquidacionTm.ticket)
                prmParameter(29).Direction = ParameterDirection.Input
                prmParameter(30) = New SqlParameter("@pguia", SqlDbType.VarChar, 20)
                prmParameter(30).Value = IIf(IsNothing(oLiquidacionTm.guia), "", oLiquidacionTm.guia)
                prmParameter(30).Direction = ParameterDirection.Input
                prmParameter(31) = New SqlParameter("@pidtablaint", SqlDbType.Int, 20)
                prmParameter(31).Value = IIf(IsNothing(oLiquidacionTm.idtablaint), "", oLiquidacionTm.idtablaint)
                prmParameter(31).Direction = ParameterDirection.Input



                prmParameter(32) = New SqlParameter("@PenCl", SqlDbType.Float, 8)
                prmParameter(33) = New SqlParameter("@PenCd", SqlDbType.Float, 8)
                prmParameter(34) = New SqlParameter("@PenF", SqlDbType.Float, 8)
                prmParameter(35) = New SqlParameter("@PenS", SqlDbType.Float, 8)
                prmParameter(36) = New SqlParameter("@PenFe", SqlDbType.Float, 8)
                prmParameter(37) = New SqlParameter("@PenAl203", SqlDbType.Float, 8)
                prmParameter(38) = New SqlParameter("@PenCo", SqlDbType.Float, 8)
                prmParameter(39) = New SqlParameter("@PenMo", SqlDbType.Float, 8)
                prmParameter(40) = New SqlParameter("@PenP", SqlDbType.Float, 8)
                prmParameter(41) = New SqlParameter("@Pen20", SqlDbType.Float, 8)
                prmParameter(42) = New SqlParameter("@Pen21", SqlDbType.Float, 8)
                prmParameter(43) = New SqlParameter("@Pen22", SqlDbType.Float, 8)
                prmParameter(44) = New SqlParameter("@Pen23", SqlDbType.Float, 8)
                prmParameter(45) = New SqlParameter("@Pen24", SqlDbType.Float, 8)
                prmParameter(46) = New SqlParameter("@Pen25", SqlDbType.Float, 8)
                prmParameter(47) = New SqlParameter("@Pen26", SqlDbType.Float, 8)
                prmParameter(48) = New SqlParameter("@Pen27", SqlDbType.Float, 8)
                prmParameter(49) = New SqlParameter("@Pen28", SqlDbType.Float, 8)
                prmParameter(50) = New SqlParameter("@Pen29", SqlDbType.Float, 8)
                prmParameter(51) = New SqlParameter("@Pen30", SqlDbType.Float, 8)

                prmParameter(32).Value = IIf(IsNothing(oLiquidacionTm.PenCl), 0, oLiquidacionTm.PenCl)
                prmParameter(33).Value = IIf(IsNothing(oLiquidacionTm.PenCd), 0, oLiquidacionTm.PenCd)
                prmParameter(34).Value = IIf(IsNothing(oLiquidacionTm.PenF), 0, oLiquidacionTm.PenF)
                prmParameter(35).Value = IIf(IsNothing(oLiquidacionTm.PenS), 0, oLiquidacionTm.PenS)
                prmParameter(36).Value = IIf(IsNothing(oLiquidacionTm.PenFe), 0, oLiquidacionTm.PenFe)
                prmParameter(37).Value = IIf(IsNothing(oLiquidacionTm.PenAl203), 0, oLiquidacionTm.PenAl203)
                prmParameter(38).Value = IIf(IsNothing(oLiquidacionTm.PenCo), 0, oLiquidacionTm.PenCo)
                prmParameter(39).Value = IIf(IsNothing(oLiquidacionTm.PenMo), 0, oLiquidacionTm.PenMo)
                prmParameter(40).Value = IIf(IsNothing(oLiquidacionTm.PenP), 0, oLiquidacionTm.PenP)
                prmParameter(41).Value = IIf(IsNothing(oLiquidacionTm.Pen20), 0, oLiquidacionTm.Pen20)
                prmParameter(42).Value = IIf(IsNothing(oLiquidacionTm.Pen21), 0, oLiquidacionTm.Pen21)
                prmParameter(43).Value = IIf(IsNothing(oLiquidacionTm.Pen22), 0, oLiquidacionTm.Pen22)
                prmParameter(44).Value = IIf(IsNothing(oLiquidacionTm.Pen23), 0, oLiquidacionTm.Pen23)
                prmParameter(45).Value = IIf(IsNothing(oLiquidacionTm.Pen24), 0, oLiquidacionTm.Pen24)
                prmParameter(46).Value = IIf(IsNothing(oLiquidacionTm.Pen25), 0, oLiquidacionTm.Pen25)
                prmParameter(47).Value = IIf(IsNothing(oLiquidacionTm.Pen26), 0, oLiquidacionTm.Pen26)
                prmParameter(48).Value = IIf(IsNothing(oLiquidacionTm.Pen27), 0, oLiquidacionTm.Pen27)
                prmParameter(49).Value = IIf(IsNothing(oLiquidacionTm.Pen28), 0, oLiquidacionTm.Pen28)
                prmParameter(50).Value = IIf(IsNothing(oLiquidacionTm.Pen29), 0, oLiquidacionTm.Pen29)
                prmParameter(51).Value = IIf(IsNothing(oLiquidacionTm.Pen30), 0, oLiquidacionTm.Pen30)

                prmParameter(32).Direction = ParameterDirection.Input
                prmParameter(33).Direction = ParameterDirection.Input
                prmParameter(34).Direction = ParameterDirection.Input
                prmParameter(35).Direction = ParameterDirection.Input
                prmParameter(36).Direction = ParameterDirection.Input
                prmParameter(37).Direction = ParameterDirection.Input
                prmParameter(38).Direction = ParameterDirection.Input
                prmParameter(39).Direction = ParameterDirection.Input
                prmParameter(40).Direction = ParameterDirection.Input
                prmParameter(41).Direction = ParameterDirection.Input
                prmParameter(42).Direction = ParameterDirection.Input
                prmParameter(43).Direction = ParameterDirection.Input
                prmParameter(44).Direction = ParameterDirection.Input
                prmParameter(45).Direction = ParameterDirection.Input
                prmParameter(46).Direction = ParameterDirection.Input
                prmParameter(47).Direction = ParameterDirection.Input
                prmParameter(48).Direction = ParameterDirection.Input
                prmParameter(49).Direction = ParameterDirection.Input
                prmParameter(50).Direction = ParameterDirection.Input
                prmParameter(51).Direction = ParameterDirection.Input


                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionTm_Ins", prmParameter)
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
        ''' Fecha Creacion: 24/04/2011 10:54:50 a.m.
        ''' Proposito: Metodo de Modificacion de datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function ModificarLiquidacionTm(ByVal oLstLiquidacionTm As List(Of clsBE_LiquidacionTm)) As Boolean
            For Each oLiquidacionTm As clsBE_LiquidacionTm In oLstLiquidacionTm
                Dim prmParameter(52) As SqlParameter

                prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacionTm.contratoLoteId), "", oLiquidacionTm.contratoLoteId)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
                prmParameter(1).Value = IIf(IsNothing(oLiquidacionTm.liquidacionId), "", oLiquidacionTm.liquidacionId)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pliquidacionTmId", SqlDbType.varchar, 20)
                prmParameter(2).Value = IIf(IsNothing(oLiquidacionTm.liquidacionTmId), "", oLiquidacionTm.liquidacionTmId)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@ptmh", SqlDbType.Float, 8)
                prmParameter(3).Value = IIf(IsNothing(oLiquidacionTm.tmh), 0, oLiquidacionTm.tmh)
                prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@ph2o", SqlDbType.Float, 8)
                prmParameter(4).Value = IIf(IsNothing(oLiquidacionTm.h2o), 0, oLiquidacionTm.h2o)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@ptms", SqlDbType.Float, 8)
                prmParameter(5).Value = IIf(IsNothing(oLiquidacionTm.tms), 0, oLiquidacionTm.tms)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@ptmsn", SqlDbType.Float, 8)
                prmParameter(6).Value = IIf(IsNothing(oLiquidacionTm.tmsn), 0, oLiquidacionTm.tmsn)
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7) = New SqlParameter("@pcodigoAnalisis", SqlDbType.varchar, 15)
                prmParameter(7).Value = IIf(IsNothing(oLiquidacionTm.codigoAnalisis), "", oLiquidacionTm.codigoAnalisis)
                prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(8) = New SqlParameter("@pcodigoLaboratorio", SqlDbType.varchar, 15)
                prmParameter(8).Value = IIf(IsNothing(oLiquidacionTm.codigoLaboratorio), "", oLiquidacionTm.codigoLaboratorio)
                prmParameter(8).Direction = ParameterDirection.Input
                prmParameter(9) = New SqlParameter("@pvalorLiquidacion", SqlDbType.Float, 8)
                prmParameter(9).Value = IIf(IsNothing(oLiquidacionTm.valorLiquidacion), 0, oLiquidacionTm.valorLiquidacion)
                prmParameter(9).Direction = ParameterDirection.Input
                prmParameter(10) = New SqlParameter("@pcodigoEstado", SqlDbType.varchar, 15)
                prmParameter(10).Value = IIf(IsNothing(oLiquidacionTm.codigoEstado), "", oLiquidacionTm.codigoEstado)
                prmParameter(10).Direction = ParameterDirection.Input
                prmParameter(11) = New SqlParameter("@pum", SqlDbType.varchar, 15)
                prmParameter(11).Value = IIf(IsNothing(oLiquidacionTm.um), "", oLiquidacionTm.um)
                prmParameter(11).Direction = ParameterDirection.Input
                prmParameter(12) = New SqlParameter("@pfm", SqlDbType.DateTime, 8)
                prmParameter(12).Value = clsUT_Funcion.FechaNull(oLiquidacionTm.fm)
                prmParameter(12).Direction = ParameterDirection.Input
                prmParameter(13) = New SqlParameter("@pPagCu", SqlDbType.Float, 8)
                prmParameter(13).Value = IIf(IsNothing(oLiquidacionTm.PagCu), 0, oLiquidacionTm.PagCu)
                prmParameter(13).Direction = ParameterDirection.Input
                prmParameter(14) = New SqlParameter("@pPagZn", SqlDbType.Float, 8)
                prmParameter(14).Value = IIf(IsNothing(oLiquidacionTm.PagZn), 0, oLiquidacionTm.PagZn)
                prmParameter(14).Direction = ParameterDirection.Input
                prmParameter(15) = New SqlParameter("@pPagPb", SqlDbType.Float, 8)
                prmParameter(15).Value = IIf(IsNothing(oLiquidacionTm.PagPb), 0, oLiquidacionTm.PagPb)
                prmParameter(15).Direction = ParameterDirection.Input
                prmParameter(16) = New SqlParameter("@pPagAg", SqlDbType.Float, 8)
                prmParameter(16).Value = IIf(IsNothing(oLiquidacionTm.PagAg), 0, oLiquidacionTm.PagAg)
                prmParameter(16).Direction = ParameterDirection.Input
                prmParameter(17) = New SqlParameter("@pPagAu", SqlDbType.Float, 8)
                prmParameter(17).Value = IIf(IsNothing(oLiquidacionTm.PagAu), 0, oLiquidacionTm.PagAu)
                prmParameter(17).Direction = ParameterDirection.Input
                prmParameter(18) = New SqlParameter("@pPenAs", SqlDbType.Float, 8)
                prmParameter(18).Value = IIf(IsNothing(oLiquidacionTm.PenAs), 0, oLiquidacionTm.PenAs)
                prmParameter(18).Direction = ParameterDirection.Input
                prmParameter(19) = New SqlParameter("@pPenSb", SqlDbType.Float, 8)
                prmParameter(19).Value = IIf(IsNothing(oLiquidacionTm.PenSb), 0, oLiquidacionTm.PenSb)
                prmParameter(19).Direction = ParameterDirection.Input
                prmParameter(20) = New SqlParameter("@pPenBi", SqlDbType.Float, 8)
                prmParameter(20).Value = IIf(IsNothing(oLiquidacionTm.PenBi), 0, oLiquidacionTm.PenBi)
                prmParameter(20).Direction = ParameterDirection.Input
                prmParameter(21) = New SqlParameter("@pPenZn", SqlDbType.Float, 8)
                prmParameter(21).Value = IIf(IsNothing(oLiquidacionTm.PenZn), 0, oLiquidacionTm.PenZn)
                prmParameter(21).Direction = ParameterDirection.Input
                prmParameter(22) = New SqlParameter("@pPenPb", SqlDbType.Float, 8)
                prmParameter(22).Value = IIf(IsNothing(oLiquidacionTm.PenPb), 0, oLiquidacionTm.PenPb)
                prmParameter(22).Direction = ParameterDirection.Input
                prmParameter(23) = New SqlParameter("@pPenHg", SqlDbType.Float, 8)
                prmParameter(23).Value = IIf(IsNothing(oLiquidacionTm.PenHg), 0, oLiquidacionTm.PenHg)
                prmParameter(23).Direction = ParameterDirection.Input
                prmParameter(24) = New SqlParameter("@pPenSiO2", SqlDbType.Float, 8)
                prmParameter(24).Value = IIf(IsNothing(oLiquidacionTm.PenSiO2), 0, oLiquidacionTm.PenSiO2)
                prmParameter(24).Direction = ParameterDirection.Input
                prmParameter(25) = New SqlParameter("@pPen1", SqlDbType.Float, 8)
                prmParameter(25).Value = IIf(IsNothing(oLiquidacionTm.Pen1), 0, oLiquidacionTm.Pen1)
                prmParameter(25).Direction = ParameterDirection.Input
                prmParameter(26) = New SqlParameter("@pPen2", SqlDbType.Float, 8)
                prmParameter(26).Value = IIf(IsNothing(oLiquidacionTm.Pen2), 0, oLiquidacionTm.Pen2)
                prmParameter(26).Direction = ParameterDirection.Input
                prmParameter(27) = New SqlParameter("@pPen3", SqlDbType.Float, 8)
                prmParameter(27).Value = IIf(IsNothing(oLiquidacionTm.Pen3), 0, oLiquidacionTm.Pen3)
                prmParameter(27).Direction = ParameterDirection.Input
                prmParameter(28) = New SqlParameter("@pcodigoLote", SqlDbType.varchar, 20)
                prmParameter(28).Value = IIf(IsNothing(oLiquidacionTm.codigoLote), "", oLiquidacionTm.codigoLote)
                prmParameter(28).Direction = ParameterDirection.Input
                prmParameter(29) = New SqlParameter("@pfecha_ingreso", SqlDbType.DateTime, 8)
                prmParameter(29).Value = clsUT_Funcion.FechaNull(oLiquidacionTm.fecha_ingreso)
                prmParameter(29).Direction = ParameterDirection.Input
                prmParameter(30) = New SqlParameter("@pticket", SqlDbType.varchar, 20)
                prmParameter(30).Value = IIf(IsNothing(oLiquidacionTm.ticket), "", oLiquidacionTm.ticket)
                prmParameter(30).Direction = ParameterDirection.Input
                prmParameter(31) = New SqlParameter("@pguia", SqlDbType.VarChar, 20)
                prmParameter(31).Value = IIf(IsNothing(oLiquidacionTm.guia), "", oLiquidacionTm.guia)
                prmParameter(31).Direction = ParameterDirection.Input
                prmParameter(32) = New SqlParameter("@pidtablaint", SqlDbType.Int, 20)
                prmParameter(32).Value = IIf(IsNothing(oLiquidacionTm.idtablaint), "", oLiquidacionTm.idtablaint)
                prmParameter(32).Direction = ParameterDirection.Input


                prmParameter(33) = New SqlParameter("@PenCl", SqlDbType.Float, 8)
                prmParameter(34) = New SqlParameter("@PenCd", SqlDbType.Float, 8)
                prmParameter(35) = New SqlParameter("@PenF", SqlDbType.Float, 8)
                prmParameter(36) = New SqlParameter("@PenS", SqlDbType.Float, 8)
                prmParameter(37) = New SqlParameter("@PenFe", SqlDbType.Float, 8)
                prmParameter(38) = New SqlParameter("@PenAl203", SqlDbType.Float, 8)
                prmParameter(39) = New SqlParameter("@PenCo", SqlDbType.Float, 8)
                prmParameter(40) = New SqlParameter("@PenMo", SqlDbType.Float, 8)
                prmParameter(41) = New SqlParameter("@PenP", SqlDbType.Float, 8)
                prmParameter(42) = New SqlParameter("@Pen20", SqlDbType.Float, 8)
                prmParameter(43) = New SqlParameter("@Pen21", SqlDbType.Float, 8)
                prmParameter(44) = New SqlParameter("@Pen22", SqlDbType.Float, 8)
                prmParameter(45) = New SqlParameter("@Pen23", SqlDbType.Float, 8)
                prmParameter(46) = New SqlParameter("@Pen24", SqlDbType.Float, 8)
                prmParameter(47) = New SqlParameter("@Pen25", SqlDbType.Float, 8)
                prmParameter(48) = New SqlParameter("@Pen26", SqlDbType.Float, 8)
                prmParameter(49) = New SqlParameter("@Pen27", SqlDbType.Float, 8)
                prmParameter(50) = New SqlParameter("@Pen28", SqlDbType.Float, 8)
                prmParameter(51) = New SqlParameter("@Pen29", SqlDbType.Float, 8)
                prmParameter(52) = New SqlParameter("@Pen30", SqlDbType.Float, 8)

                prmParameter(33).Value = IIf(IsNothing(oLiquidacionTm.PenCl), 0, oLiquidacionTm.PenCl)
                prmParameter(34).Value = IIf(IsNothing(oLiquidacionTm.PenCd), 0, oLiquidacionTm.PenCd)
                prmParameter(35).Value = IIf(IsNothing(oLiquidacionTm.PenF), 0, oLiquidacionTm.PenF)
                prmParameter(36).Value = IIf(IsNothing(oLiquidacionTm.PenS), 0, oLiquidacionTm.PenS)
                prmParameter(37).Value = IIf(IsNothing(oLiquidacionTm.PenFe), 0, oLiquidacionTm.PenFe)
                prmParameter(38).Value = IIf(IsNothing(oLiquidacionTm.PenAl203), 0, oLiquidacionTm.PenAl203)
                prmParameter(39).Value = IIf(IsNothing(oLiquidacionTm.PenCo), 0, oLiquidacionTm.PenCo)
                prmParameter(40).Value = IIf(IsNothing(oLiquidacionTm.PenMo), 0, oLiquidacionTm.PenMo)
                prmParameter(41).Value = IIf(IsNothing(oLiquidacionTm.PenP), 0, oLiquidacionTm.PenP)
                prmParameter(42).Value = IIf(IsNothing(oLiquidacionTm.Pen20), 0, oLiquidacionTm.Pen20)
                prmParameter(43).Value = IIf(IsNothing(oLiquidacionTm.Pen21), 0, oLiquidacionTm.Pen21)
                prmParameter(44).Value = IIf(IsNothing(oLiquidacionTm.Pen22), 0, oLiquidacionTm.Pen22)
                prmParameter(45).Value = IIf(IsNothing(oLiquidacionTm.Pen23), 0, oLiquidacionTm.Pen23)
                prmParameter(46).Value = IIf(IsNothing(oLiquidacionTm.Pen24), 0, oLiquidacionTm.Pen24)
                prmParameter(47).Value = IIf(IsNothing(oLiquidacionTm.Pen25), 0, oLiquidacionTm.Pen25)
                prmParameter(48).Value = IIf(IsNothing(oLiquidacionTm.Pen26), 0, oLiquidacionTm.Pen26)
                prmParameter(49).Value = IIf(IsNothing(oLiquidacionTm.Pen27), 0, oLiquidacionTm.Pen27)
                prmParameter(50).Value = IIf(IsNothing(oLiquidacionTm.Pen28), 0, oLiquidacionTm.Pen28)
                prmParameter(51).Value = IIf(IsNothing(oLiquidacionTm.Pen29), 0, oLiquidacionTm.Pen29)
                prmParameter(52).Value = IIf(IsNothing(oLiquidacionTm.Pen30), 0, oLiquidacionTm.Pen30)

                prmParameter(33).Direction = ParameterDirection.Input
                prmParameter(34).Direction = ParameterDirection.Input
                prmParameter(35).Direction = ParameterDirection.Input
                prmParameter(36).Direction = ParameterDirection.Input
                prmParameter(37).Direction = ParameterDirection.Input
                prmParameter(38).Direction = ParameterDirection.Input
                prmParameter(39).Direction = ParameterDirection.Input
                prmParameter(40).Direction = ParameterDirection.Input
                prmParameter(41).Direction = ParameterDirection.Input
                prmParameter(42).Direction = ParameterDirection.Input
                prmParameter(43).Direction = ParameterDirection.Input
                prmParameter(44).Direction = ParameterDirection.Input
                prmParameter(45).Direction = ParameterDirection.Input
                prmParameter(46).Direction = ParameterDirection.Input
                prmParameter(47).Direction = ParameterDirection.Input
                prmParameter(48).Direction = ParameterDirection.Input
                prmParameter(49).Direction = ParameterDirection.Input
                prmParameter(50).Direction = ParameterDirection.Input
                prmParameter(51).Direction = ParameterDirection.Input
                prmParameter(52).Direction = ParameterDirection.Input

                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionTm_Upd", prmParameter)
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
        ''' Fecha Creacion: 24/04/2011 10:54:50 a.m.
        ''' Proposito: Metodo de Elimacion
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function EliminarLiquidacionTm(ByVal oLstLiquidacionTm As List(Of clsBE_LiquidacionTm)) As Boolean
            For Each oLiquidacionTm As clsBE_LiquidacionTm In oLstLiquidacionTm
                Dim prmParameter(2) As SqlParameter
                prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacionTm.contratoLoteId), "", oLiquidacionTm.contratoLoteId)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
                prmParameter(1).Value = IIf(IsNothing(oLiquidacionTm.liquidacionId), "", oLiquidacionTm.liquidacionId)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pliquidacionTmId", SqlDbType.varchar, 20)
                prmParameter(2).Value = IIf(IsNothing(oLiquidacionTm.liquidacionTmId), "", oLiquidacionTm.liquidacionTmId)
                prmParameter(2).Direction = ParameterDirection.Input
                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionTm_Del", prmParameter)
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
        ''' Fecha Creacion: 24/04/2011 10:54:50 a.m.
        ''' Proposito: Metodo de Guardar Dataset
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function GuardarLiquidacionTm(ByVal oDSLiquidacionTm As Dataset) As Boolean
            Dim cnxCPO As New SqlConnection(CadenaConexion)


            Try
                Dim objCommnadInsert As New SqlCommand
                objCommnadInsert.Connection = cnxCPO
                objCommnadInsert.CommandText = "up_LiquidacionTm_Ins"
                objCommnadInsert.CommandType = CommandType.StoredProcedure

                objCommnadInsert.Parameters.Add("@pcontratoLoteId", SqlDbType.varchar, 20).SourceColumn = "contratoLoteId"
                objCommnadInsert.Parameters.Add("@pliquidacionId", SqlDbType.varchar, 20).SourceColumn = "liquidacionId"
                objCommnadInsert.Parameters.Add("@pliquidacionTmId", SqlDbType.varchar, 20).SourceColumn = "liquidacionTmId"
                objCommnadInsert.Parameters.Add("@ptmh", SqlDbType.Float, 8).SourceColumn = "tmh"
                objCommnadInsert.Parameters.Add("@ph2o", SqlDbType.Float, 8).SourceColumn = "h2o"
                objCommnadInsert.Parameters.Add("@ptms", SqlDbType.Float, 8).SourceColumn = "tms"
                objCommnadInsert.Parameters.Add("@ptmsn", SqlDbType.Float, 8).SourceColumn = "tmsn"
                objCommnadInsert.Parameters.Add("@pcodigoAnalisis", SqlDbType.varchar, 15).SourceColumn = "codigoAnalisis"
                objCommnadInsert.Parameters.Add("@pcodigoLaboratorio", SqlDbType.varchar, 15).SourceColumn = "codigoLaboratorio"
                objCommnadInsert.Parameters.Add("@pvalorLiquidacion", SqlDbType.Float, 8).SourceColumn = "valorLiquidacion"
                objCommnadInsert.Parameters.Add("@pcodigoEstado", SqlDbType.varchar, 15).SourceColumn = "codigoEstado"
                objCommnadInsert.Parameters.Add("@puc", SqlDbType.varchar, 15).SourceColumn = "uc"
                objCommnadInsert.Parameters.Add("@pPagCu", SqlDbType.Float, 8).SourceColumn = "PagCu"
                objCommnadInsert.Parameters.Add("@pPagZn", SqlDbType.Float, 8).SourceColumn = "PagZn"
                objCommnadInsert.Parameters.Add("@pPagPb", SqlDbType.Float, 8).SourceColumn = "PagPb"
                objCommnadInsert.Parameters.Add("@pPagAg", SqlDbType.Float, 8).SourceColumn = "PagAg"
                objCommnadInsert.Parameters.Add("@pPagAu", SqlDbType.Float, 8).SourceColumn = "PagAu"
                objCommnadInsert.Parameters.Add("@pPenAs", SqlDbType.Float, 8).SourceColumn = "PenAs"
                objCommnadInsert.Parameters.Add("@pPenSb", SqlDbType.Float, 8).SourceColumn = "PenSb"
                objCommnadInsert.Parameters.Add("@pPenBi", SqlDbType.Float, 8).SourceColumn = "PenBi"
                objCommnadInsert.Parameters.Add("@pPenZn", SqlDbType.Float, 8).SourceColumn = "PenZn"
                objCommnadInsert.Parameters.Add("@pPenPb", SqlDbType.Float, 8).SourceColumn = "PenPb"
                objCommnadInsert.Parameters.Add("@pPenHg", SqlDbType.Float, 8).SourceColumn = "PenHg"
                objCommnadInsert.Parameters.Add("@pPenSiO2", SqlDbType.Float, 8).SourceColumn = "PenSiO2"
                objCommnadInsert.Parameters.Add("@pPen1", SqlDbType.Float, 8).SourceColumn = "Pen1"
                objCommnadInsert.Parameters.Add("@pPen2", SqlDbType.Float, 8).SourceColumn = "Pen2"
                objCommnadInsert.Parameters.Add("@pPen3", SqlDbType.Float, 8).SourceColumn = "Pen3"
                objCommnadInsert.Parameters.Add("@pcodigoLote", SqlDbType.varchar, 20).SourceColumn = "codigoLote"
                objCommnadInsert.Parameters.Add("@pfecha_ingreso", SqlDbType.DateTime, 8).SourceColumn = "fecha_ingreso"
                objCommnadInsert.Parameters.Add("@pticket", SqlDbType.varchar, 20).SourceColumn = "ticket"
                objCommnadInsert.Parameters.Add("@pguia", SqlDbType.VarChar, 20).SourceColumn = "guia"
                objCommnadInsert.Parameters.Add("@pidtablaint", SqlDbType.Int, 20).SourceColumn = "idtablaint"

                Dim objCommandUpdate As New SqlCommand
                objCommandUpdate.Connection = cnxCPO
                objCommandUpdate.CommandText = "up_LiquidacionTm_Upd"
                objCommandUpdate.CommandType = CommandType.StoredProcedure

                objCommandUpdate.Parameters.Add("@pcontratoLoteId", SqlDbType.varchar, 20).SourceColumn = "contratoLoteId"
                objCommandUpdate.Parameters.Add("@pliquidacionId", SqlDbType.varchar, 20).SourceColumn = "liquidacionId"
                objCommandUpdate.Parameters.Add("@pliquidacionTmId", SqlDbType.varchar, 20).SourceColumn = "liquidacionTmId"
                objCommandUpdate.Parameters.Add("@ptmh", SqlDbType.Float, 8).SourceColumn = "tmh"
                objCommandUpdate.Parameters.Add("@ph2o", SqlDbType.Float, 8).SourceColumn = "h2o"
                objCommandUpdate.Parameters.Add("@ptms", SqlDbType.Float, 8).SourceColumn = "tms"
                objCommandUpdate.Parameters.Add("@ptmsn", SqlDbType.Float, 8).SourceColumn = "tmsn"
                objCommandUpdate.Parameters.Add("@pcodigoAnalisis", SqlDbType.varchar, 15).SourceColumn = "codigoAnalisis"
                objCommandUpdate.Parameters.Add("@pcodigoLaboratorio", SqlDbType.varchar, 15).SourceColumn = "codigoLaboratorio"
                objCommandUpdate.Parameters.Add("@pvalorLiquidacion", SqlDbType.Float, 8).SourceColumn = "valorLiquidacion"
                objCommandUpdate.Parameters.Add("@pcodigoEstado", SqlDbType.varchar, 15).SourceColumn = "codigoEstado"
                objCommandUpdate.Parameters.Add("@pum", SqlDbType.varchar, 15).SourceColumn = "um"
                objCommandUpdate.Parameters.Add("@pfm", SqlDbType.DateTime, 8).SourceColumn = "fm"
                objCommandUpdate.Parameters.Add("@pPagCu", SqlDbType.Float, 8).SourceColumn = "PagCu"
                objCommandUpdate.Parameters.Add("@pPagZn", SqlDbType.Float, 8).SourceColumn = "PagZn"
                objCommandUpdate.Parameters.Add("@pPagPb", SqlDbType.Float, 8).SourceColumn = "PagPb"
                objCommandUpdate.Parameters.Add("@pPagAg", SqlDbType.Float, 8).SourceColumn = "PagAg"
                objCommandUpdate.Parameters.Add("@pPagAu", SqlDbType.Float, 8).SourceColumn = "PagAu"
                objCommandUpdate.Parameters.Add("@pPenAs", SqlDbType.Float, 8).SourceColumn = "PenAs"
                objCommandUpdate.Parameters.Add("@pPenSb", SqlDbType.Float, 8).SourceColumn = "PenSb"
                objCommandUpdate.Parameters.Add("@pPenBi", SqlDbType.Float, 8).SourceColumn = "PenBi"
                objCommandUpdate.Parameters.Add("@pPenZn", SqlDbType.Float, 8).SourceColumn = "PenZn"
                objCommandUpdate.Parameters.Add("@pPenPb", SqlDbType.Float, 8).SourceColumn = "PenPb"
                objCommandUpdate.Parameters.Add("@pPenHg", SqlDbType.Float, 8).SourceColumn = "PenHg"
                objCommandUpdate.Parameters.Add("@pPenSiO2", SqlDbType.Float, 8).SourceColumn = "PenSiO2"
                objCommandUpdate.Parameters.Add("@pPen1", SqlDbType.Float, 8).SourceColumn = "Pen1"
                objCommandUpdate.Parameters.Add("@pPen2", SqlDbType.Float, 8).SourceColumn = "Pen2"
                objCommandUpdate.Parameters.Add("@pPen3", SqlDbType.Float, 8).SourceColumn = "Pen3"
                objCommandUpdate.Parameters.Add("@pcodigoLote", SqlDbType.varchar, 20).SourceColumn = "codigoLote"
                objCommandUpdate.Parameters.Add("@pfecha_ingreso", SqlDbType.DateTime, 8).SourceColumn = "fecha_ingreso"
                objCommandUpdate.Parameters.Add("@pticket", SqlDbType.varchar, 20).SourceColumn = "ticket"
                objCommandUpdate.Parameters.Add("@pguia", SqlDbType.VarChar, 20).SourceColumn = "guia"
                objCommandUpdate.Parameters.Add("@pidtablaint", SqlDbType.Int, 20).SourceColumn = "idtablaint"

                Dim objCommandDelete As New SqlCommand
                objCommandDelete.Connection = cnxCPO
                objCommandDelete.CommandText = "up_LiquidacionTm_Del"
                objCommandDelete.CommandType = CommandType.StoredProcedure

                objCommandDelete.Parameters.Add("@pcontratoLoteId", SqlDbType.varchar, 20).SourceColumn = "contratoLoteId"
                objCommandDelete.Parameters.Add("@pliquidacionId", SqlDbType.varchar, 20).SourceColumn = "liquidacionId"
                objCommandDelete.Parameters.Add("@pliquidacionTmId", SqlDbType.varchar, 20).SourceColumn = "liquidacionTmId"

                'SqlHelper.UpdateDataset(objCommnadInsert, objCommandDelete, objCommandUpdate, oDSLiquidacionTm, "LiquidacionTm")

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
    ''' Fecha Creacion: 24/04/2011 10:54:50 a.m.
    ''' Proposito: Obtiene los valores de la tabla LiquidacionTm
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsDB_LiquidacionTmRO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 24/04/2011 10:54:50 a.m.
        ''' Proposito: Lee los datos de un registro
        ''' Fecha Modificacion:
        ''' </summary>
        ''' 
        Public Function LeerLiquidacionTm(ByVal pLiquidacionTm As clsBE_LiquidacionTm) As clsBE_LiquidacionTm
            Dim oLiquidacionTm As clsBE_LiquidacionTm = Nothing
            Dim DSLiquidacionTm As New DataSet
            Dim prmParameter(2) As SqlParameter
            prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
            prmParameter(0).Value = IIf(IsNothing(pLiquidacionTm.contratoLoteId), "", pLiquidacionTm.contratoLoteId)
            prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
            prmParameter(1).Value = IIf(IsNothing(pLiquidacionTm.liquidacionId), "", pLiquidacionTm.liquidacionId)
            prmParameter(2) = New SqlParameter("@pliquidacionTmId", SqlDbType.varchar, 20)
            prmParameter(2).Value = IIf(IsNothing(pLiquidacionTm.liquidacionTmId), "", pLiquidacionTm.liquidacionTmId)
            Try
                Using DSLiquidacionTm
                    DSLiquidacionTm = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionTm_Sel", prmParameter)
                    If Not DSLiquidacionTm Is Nothing Then
                        If DSLiquidacionTm.Tables.Count > 0 Then
                            oLiquidacionTm = New clsBE_LiquidacionTm
                            If DSLiquidacionTm.Tables(0).Rows.Count > 0 Then
                                With DSLiquidacionTm.Tables(0).Rows(0)
                                    oLiquidacionTm.contratoLoteId = .Item("contratoLoteId").tostring
                                    oLiquidacionTm.liquidacionId = .Item("liquidacionId").tostring
                                    oLiquidacionTm.liquidacionTmId = .Item("liquidacionTmId").tostring
                                    oLiquidacionTm.tmh = .Item("tmh").tostring
                                    oLiquidacionTm.h2o = .Item("h2o").tostring
                                    oLiquidacionTm.tms = .Item("tms").tostring
                                    oLiquidacionTm.tmsn = .Item("tmsn").tostring
                                    oLiquidacionTm.codigoAnalisis = .Item("codigoAnalisis").tostring
                                    oLiquidacionTm.codigoLaboratorio = .Item("codigoLaboratorio").tostring
                                    oLiquidacionTm.valorLiquidacion = .Item("valorLiquidacion").tostring
                                    oLiquidacionTm.codigoEstado = .Item("codigoEstado").tostring
                                    oLiquidacionTm.uc = .Item("uc").tostring
                                    oLiquidacionTm.fc = .Item("fc").tostring
                                    oLiquidacionTm.PagCu = .Item("PagCu").tostring
                                    oLiquidacionTm.PagZn = .Item("PagZn").tostring
                                    oLiquidacionTm.PagPb = .Item("PagPb").tostring
                                    oLiquidacionTm.PagAg = .Item("PagAg").tostring
                                    oLiquidacionTm.PagAu = .Item("PagAu").tostring
                                    oLiquidacionTm.PenAs = .Item("PenAs").tostring
                                    oLiquidacionTm.PenSb = .Item("PenSb").tostring
                                    oLiquidacionTm.PenBi = .Item("PenBi").tostring
                                    oLiquidacionTm.PenZn = .Item("PenZn").tostring
                                    oLiquidacionTm.PenPb = .Item("PenPb").tostring
                                    oLiquidacionTm.PenHg = .Item("PenHg").tostring
                                    oLiquidacionTm.PenSiO2 = .Item("PenSiO2").tostring
                                    oLiquidacionTm.Pen1 = .Item("Pen1").tostring
                                    oLiquidacionTm.Pen2 = .Item("Pen2").tostring
                                    oLiquidacionTm.Pen3 = .Item("Pen3").tostring
                                    oLiquidacionTm.codigoLote = .Item("codigoLote").tostring
                                    oLiquidacionTm.fecha_ingreso = SI.UT.clsUT_Funcion.DbValueToNullable(Of Date)(.Item("fecha_ingreso")).GetValueOrDefault
                                    oLiquidacionTm.ticket = .Item("ticket").tostring
                                    oLiquidacionTm.guia = .Item("guia").tostring
                                End With
                            End If
                        End If
                    End If
                End Using
            Catch exSql As SqlException

            Catch ex As Exception
                Throw ex
            Finally
                If Not DSLiquidacionTm Is Nothing Then
                    DSLiquidacionTm.Dispose()
                End If
                DSLiquidacionTm = Nothing
            End Try

            Return oLiquidacionTm

        End Function


        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 24/04/2011 10:54:50 a.m.
        ''' Proposito: Obtiene la lista de registros
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaLiquidacionTm() As List(Of clsBE_LiquidacionTm)
            Dim olstLiquidacionTm As New List(Of clsBE_LiquidacionTm)
            Dim oLiquidacionTm As clsBE_LiquidacionTm = Nothing
            Dim mintItem As Integer = 0
            Try
                Using Reader As SqlDataReader = SqlHelper.ExecuteReader(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionTm_Sellst")
                    If Reader.HasRows Then
                        While reader.Read
                            oLiquidacionTm = New clsBE_LiquidacionTm
                            mintItem += 1
                            With oLiquidacionTm
                                .Item = mintItem

                                .contratoLoteId = Reader("contratoLoteId").tostring
                                .liquidacionId = Reader("liquidacionId").tostring
                                .liquidacionTmId = Reader("liquidacionTmId").tostring
                                .tmh = Reader("tmh").tostring
                                .h2o = Reader("h2o").tostring
                                .tms = Reader("tms").tostring
                                .tmsn = Reader("tmsn").tostring
                                .codigoAnalisis = Reader("codigoAnalisis").tostring
                                .codigoLaboratorio = Reader("codigoLaboratorio").tostring
                                .valorLiquidacion = Reader("valorLiquidacion").tostring
                                .codigoEstado = Reader("codigoEstado").tostring
                                .uc = Reader("uc").tostring
                                .fc = Reader("fc").tostring
                                .um = Reader("um").tostring
                                .fm = Reader("fm").tostring
                                .PagCu = Reader("PagCu").tostring
                                .PagZn = Reader("PagZn").tostring
                                .PagPb = Reader("PagPb").tostring
                                .PagAg = Reader("PagAg").tostring
                                .PagAu = Reader("PagAu").tostring
                                .PenAs = Reader("PenAs").tostring
                                .PenSb = Reader("PenSb").tostring
                                .PenBi = Reader("PenBi").tostring
                                .PenZn = Reader("PenZn").tostring
                                .PenPb = Reader("PenPb").tostring
                                .PenHg = Reader("PenHg").tostring
                                .PenSiO2 = Reader("PenSiO2").tostring
                                .Pen1 = Reader("Pen1").tostring
                                .Pen2 = Reader("Pen2").tostring
                                .Pen3 = Reader("Pen3").tostring
                                .codigoLote = Reader("codigoLote").tostring
                                .fecha_ingreso = Reader("fecha_ingreso").tostring
                                .ticket = Reader("ticket").tostring
                                .guia = Reader("guia").tostring
                            End With
                            olstLiquidacionTm.Add(oLiquidacionTm)
                        End While
                    End If
                End Using
            Catch ex As Exception
                Throw ex
            End Try

            Return olstLiquidacionTm

        End Function

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 24/04/2011 10:54:50 a.m.
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSLiquidacionTm(ByVal pLiquidacionTm As clsBE_LiquidacionTm) As Dataset
            Dim oDSLiquidacionTm As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(1) As SqlParameter
            prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
            prmParameter(0).Value = IIf(IsNothing(pLiquidacionTm.contratoLoteId), "", pLiquidacionTm.contratoLoteId)
            prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.varchar, 20)
            prmParameter(1).Value = IIf(IsNothing(pLiquidacionTm.liquidacionId), "", pLiquidacionTm.liquidacionId)
            Try

                Using oDSLiquidacionTm
                    oDSLiquidacionTm = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionTm_Sellst", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionTm_Sellst", oDSLiquidacionTm, New String() {"LiquidacionTm"}, prmParameter)
                    If Not oDSLiquidacionTm Is Nothing Then
                        If oDSLiquidacionTm.Tables.Count > 0 Then
                            'If oDSLiquidacionTm.Tables("LiquidacionTm").Rows.Count > 0 Then
                            If oDSLiquidacionTm.Tables(0).Rows.Count > 0 Then
                                Return oDSLiquidacionTm
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSLiquidacionTm

        End Function


        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 24/04/2011 10:54:50 a.m.
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function DefinirTablaLiquidacionTm() As DataTable

            Try
                Dim DTLiquidacionTm As New DataTable

                Dim contratoLoteId As DataColumn = DTLiquidacionTm.Columns.Add("contratoLoteId", GetType(String))
                contratoLoteId.MaxLength = 20
                contratoLoteId.AllowDBNull = False
                contratoLoteId.DefaultValue = ""

                Dim liquidacionId As DataColumn = DTLiquidacionTm.Columns.Add("liquidacionId", GetType(String))
                liquidacionId.MaxLength = 20
                liquidacionId.AllowDBNull = False
                liquidacionId.DefaultValue = ""

                Dim liquidacionTmId As DataColumn = DTLiquidacionTm.Columns.Add("liquidacionTmId", GetType(String))
                liquidacionTmId.MaxLength = 20
                liquidacionTmId.AllowDBNull = False
                liquidacionTmId.DefaultValue = ""

                Dim tmh As DataColumn = DTLiquidacionTm.Columns.Add("tmh", GetType(Decimal))
                tmh.AllowDBNull = True
                tmh.DefaultValue = 0.0


                Dim h2o As DataColumn = DTLiquidacionTm.Columns.Add("h2o", GetType(Decimal))
                h2o.AllowDBNull = True
                h2o.DefaultValue = 0.0


                Dim tms As DataColumn = DTLiquidacionTm.Columns.Add("tms", GetType(Decimal))
                tms.AllowDBNull = True
                tms.DefaultValue = 0.0


                Dim tmsn As DataColumn = DTLiquidacionTm.Columns.Add("tmsn", GetType(Decimal))
                tmsn.AllowDBNull = True
                tmsn.DefaultValue = 0.0


                Dim codigoAnalisis As DataColumn = DTLiquidacionTm.Columns.Add("codigoAnalisis", GetType(String))
                codigoAnalisis.MaxLength = 15
                codigoAnalisis.AllowDBNull = True
                codigoAnalisis.DefaultValue = ""

                Dim codigoLaboratorio As DataColumn = DTLiquidacionTm.Columns.Add("codigoLaboratorio", GetType(String))
                codigoLaboratorio.MaxLength = 15
                codigoLaboratorio.AllowDBNull = True
                codigoLaboratorio.DefaultValue = ""

                Dim valorLiquidacion As DataColumn = DTLiquidacionTm.Columns.Add("valorLiquidacion", GetType(Decimal))
                valorLiquidacion.AllowDBNull = True
                valorLiquidacion.DefaultValue = 0.0


                Dim codigoEstado As DataColumn = DTLiquidacionTm.Columns.Add("codigoEstado", GetType(String))
                codigoEstado.MaxLength = 15
                codigoEstado.AllowDBNull = True
                codigoEstado.DefaultValue = ""

                Dim uc As DataColumn = DTLiquidacionTm.Columns.Add("uc", GetType(String))
                uc.MaxLength = 15
                uc.AllowDBNull = True
                uc.DefaultValue = ""

                Dim fc As DataColumn = DTLiquidacionTm.Columns.Add("fc", GetType(DateTime))


                Dim um As DataColumn = DTLiquidacionTm.Columns.Add("um", GetType(String))
                um.MaxLength = 15
                um.AllowDBNull = True
                um.DefaultValue = ""

                Dim fm As DataColumn = DTLiquidacionTm.Columns.Add("fm", GetType(DateTime))


                Dim PagCu As DataColumn = DTLiquidacionTm.Columns.Add("PagCu", GetType(Decimal))
                PagCu.AllowDBNull = True
                PagCu.DefaultValue = 0.0


                Dim PagZn As DataColumn = DTLiquidacionTm.Columns.Add("PagZn", GetType(Decimal))
                PagZn.AllowDBNull = True
                PagZn.DefaultValue = 0.0


                Dim PagPb As DataColumn = DTLiquidacionTm.Columns.Add("PagPb", GetType(Decimal))
                PagPb.AllowDBNull = True
                PagPb.DefaultValue = 0.0


                Dim PagAg As DataColumn = DTLiquidacionTm.Columns.Add("PagAg", GetType(Decimal))
                PagAg.AllowDBNull = True
                PagAg.DefaultValue = 0.0


                Dim PagAu As DataColumn = DTLiquidacionTm.Columns.Add("PagAu", GetType(Decimal))
                PagAu.AllowDBNull = True
                PagAu.DefaultValue = 0.0


                Dim PenAs As DataColumn = DTLiquidacionTm.Columns.Add("PenAs", GetType(Decimal))
                PenAs.AllowDBNull = True
                PenAs.DefaultValue = 0.0


                Dim PenSb As DataColumn = DTLiquidacionTm.Columns.Add("PenSb", GetType(Decimal))
                PenSb.AllowDBNull = True
                PenSb.DefaultValue = 0.0


                Dim PenBi As DataColumn = DTLiquidacionTm.Columns.Add("PenBi", GetType(Decimal))
                PenBi.AllowDBNull = True
                PenBi.DefaultValue = 0.0


                Dim PenZn As DataColumn = DTLiquidacionTm.Columns.Add("PenZn", GetType(Decimal))
                PenZn.AllowDBNull = True
                PenZn.DefaultValue = 0.0


                Dim PenPb As DataColumn = DTLiquidacionTm.Columns.Add("PenPb", GetType(Decimal))
                PenPb.AllowDBNull = True
                PenPb.DefaultValue = 0.0


                Dim PenHg As DataColumn = DTLiquidacionTm.Columns.Add("PenHg", GetType(Decimal))
                PenHg.AllowDBNull = True
                PenHg.DefaultValue = 0.0


                Dim PenSiO2 As DataColumn = DTLiquidacionTm.Columns.Add("PenSiO2", GetType(Decimal))
                PenSiO2.AllowDBNull = True
                PenSiO2.DefaultValue = 0.0


                Dim Pen1 As DataColumn = DTLiquidacionTm.Columns.Add("Pen1", GetType(Decimal))
                Pen1.AllowDBNull = True
                Pen1.DefaultValue = 0.0


                Dim Pen2 As DataColumn = DTLiquidacionTm.Columns.Add("Pen2", GetType(Decimal))
                Pen2.AllowDBNull = True
                Pen2.DefaultValue = 0.0


                Dim Pen3 As DataColumn = DTLiquidacionTm.Columns.Add("Pen3", GetType(Decimal))
                Pen3.AllowDBNull = True
                Pen3.DefaultValue = 0.0


                Dim codigoLote As DataColumn = DTLiquidacionTm.Columns.Add("codigoLote", GetType(String))
                codigoLote.MaxLength = 20
                codigoLote.AllowDBNull = True
                codigoLote.DefaultValue = ""

                Dim fecha_ingreso As DataColumn = DTLiquidacionTm.Columns.Add("fecha_ingreso", GetType(DateTime))


                Dim ticket As DataColumn = DTLiquidacionTm.Columns.Add("ticket", GetType(String))
                ticket.MaxLength = 20
                ticket.AllowDBNull = True
                ticket.DefaultValue = ""

                Dim guia As DataColumn = DTLiquidacionTm.Columns.Add("guia", GetType(String))
                guia.MaxLength = 20
                guia.AllowDBNull = True
                guia.DefaultValue = ""

                Return DTLiquidacionTm
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function GuardarLiquidacionTm(ByVal psIdContratoLote As String, ByVal psIdLiquidacion As String) As Boolean
            Dim lbResultado As Boolean = True
            Dim prmParameter(2) As SqlParameter
            prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.VarChar, 20)
            prmParameter(0).Value = psIdContratoLote
            prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.VarChar, 20)
            prmParameter(1).Value = psIdLiquidacion

            Try

                SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionTm_Sellst", prmParameter)

            Catch ex As Exception
                lbResultado = False

            End Try
            Return lbResultado
        End Function


        Public Function BuscaLiquidacionTm_RumaLiquidada(ByVal psIdContratoLote As String, ByVal psCodigoLote As String) As Boolean
            Dim lbResultado As Boolean = True
            Dim dCantidad As Integer = 0
            Dim prmParameter(2) As SqlParameter
            prmParameter(0) = New SqlParameter("@contratoLoteId", SqlDbType.VarChar, 20)
            prmParameter(0).Value = psIdContratoLote
            prmParameter(1) = New SqlParameter("@codigoLote", SqlDbType.VarChar, 20)
            prmParameter(1).Value = psCodigoLote

            prmParameter(2) = New SqlParameter("@cantidad_rumas", SqlDbType.Int)
            prmParameter(2).Direction = ParameterDirection.Output

            Try

                SqlHelper.ExecuteScalar(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionTm_RumaLiquidada", prmParameter)

                dCantidad = prmParameter(2).Value

                If dCantidad = 0 Then
                    lbResultado = False
                Else
                    lbResultado = True
                End If


            Catch ex As Exception
                lbResultado = False
            End Try
            Return lbResultado
        End Function


    End Class
#End Region

End Namespace
