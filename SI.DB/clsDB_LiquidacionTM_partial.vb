


Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports SI.BE
Imports SI.UT
Imports Microsoft.ApplicationBlocks.Data

Namespace SI.DB

#Region "Clase Escritura"

    Partial Public Class clsDB_LiquidacionTmTX


        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 24/04/2011 10:53:25 a.m.
        ''' Proposito: Metodo de Insercci?n de Datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function InsertarLiquidacion(ByVal oLstLiquidacionTm As List(Of clsBE_LiquidacionTm)) As Boolean
            For Each oLiquidacionTm As clsBE_LiquidacionTm In oLstLiquidacionTm
                Dim prmParameter(48) As SqlParameter

                prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacionTm.contratoLoteId), "", oLiquidacionTm.contratoLoteId)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.VarChar, 20)
                prmParameter(1).Value = IIf(IsNothing(oLiquidacionTm.liquidacionId), "", oLiquidacionTm.liquidacionId)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pliquidacionTmId", SqlDbType.VarChar, 20)
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
                prmParameter(7) = New SqlParameter("@pcodigolote", SqlDbType.VarChar, 20)
                prmParameter(7).Value = IIf(IsNothing(oLiquidacionTm.codigoLote), "", oLiquidacionTm.codigoLote)
                prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(8) = New SqlParameter("@pguia", SqlDbType.VarChar, 20)
                prmParameter(8).Value = IIf(IsNothing(oLiquidacionTm.guia), "", oLiquidacionTm.guia)
                prmParameter(8).Direction = ParameterDirection.Input
                prmParameter(9) = New SqlParameter("@pticket", SqlDbType.VarChar, 20)
                prmParameter(9).Value = IIf(IsNothing(oLiquidacionTm.ticket), 0, oLiquidacionTm.ticket)
                prmParameter(9).Direction = ParameterDirection.Input
                prmParameter(10) = New SqlParameter("@pcodigoEstado", SqlDbType.VarChar, 15)
                prmParameter(10).Value = IIf(IsNothing(oLiquidacionTm.codigoEstado), "", oLiquidacionTm.codigoEstado)
                prmParameter(10).Direction = ParameterDirection.Input
                prmParameter(11) = New SqlParameter("@puc", SqlDbType.VarChar, 15)
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
                prmParameter(27) = New SqlParameter("@pfecha_ingreso", SqlDbType.DateTime, 8)
                prmParameter(27).Value = clsUT_Funcion.FechaNull(oLiquidacionTm.fecha_ingreso)
                prmParameter(27).Direction = ParameterDirection.Input
                prmParameter(28) = New SqlParameter("@pidtablaint", SqlDbType.Int, 8)
                prmParameter(28).Value = IIf(IsNothing(oLiquidacionTm.idtablaint), 0, oLiquidacionTm.idtablaint)
                prmParameter(28).Direction = ParameterDirection.Input


                prmParameter(29) = New SqlParameter("@PenCl", SqlDbType.Float, 8)
                prmParameter(30) = New SqlParameter("@PenCd", SqlDbType.Float, 8)
                prmParameter(31) = New SqlParameter("@PenF", SqlDbType.Float, 8)
                prmParameter(32) = New SqlParameter("@PenS", SqlDbType.Float, 8)
                prmParameter(33) = New SqlParameter("@PenFe", SqlDbType.Float, 8)
                prmParameter(34) = New SqlParameter("@PenAl203", SqlDbType.Float, 8)
                prmParameter(35) = New SqlParameter("@PenCo", SqlDbType.Float, 8)
                prmParameter(36) = New SqlParameter("@PenMo", SqlDbType.Float, 8)
                prmParameter(37) = New SqlParameter("@PenP", SqlDbType.Float, 8)
                prmParameter(38) = New SqlParameter("@Pen20", SqlDbType.Float, 8)
                prmParameter(39) = New SqlParameter("@Pen21", SqlDbType.Float, 8)
                prmParameter(40) = New SqlParameter("@Pen22", SqlDbType.Float, 8)
                prmParameter(41) = New SqlParameter("@Pen23", SqlDbType.Float, 8)
                prmParameter(42) = New SqlParameter("@Pen24", SqlDbType.Float, 8)
                prmParameter(43) = New SqlParameter("@Pen25", SqlDbType.Float, 8)
                prmParameter(44) = New SqlParameter("@Pen26", SqlDbType.Float, 8)
                prmParameter(45) = New SqlParameter("@Pen27", SqlDbType.Float, 8)
                prmParameter(46) = New SqlParameter("@Pen28", SqlDbType.Float, 8)
                prmParameter(47) = New SqlParameter("@Pen29", SqlDbType.Float, 8)
                prmParameter(48) = New SqlParameter("@Pen30", SqlDbType.Float, 8)

                prmParameter(29).Value = IIf(IsNothing(oLiquidacionTm.PenCl), 0, oLiquidacionTm.PenCl)
                prmParameter(30).Value = IIf(IsNothing(oLiquidacionTm.PenCd), 0, oLiquidacionTm.PenCd)
                prmParameter(31).Value = IIf(IsNothing(oLiquidacionTm.PenF), 0, oLiquidacionTm.PenF)
                prmParameter(32).Value = IIf(IsNothing(oLiquidacionTm.PenS), 0, oLiquidacionTm.PenS)
                prmParameter(33).Value = IIf(IsNothing(oLiquidacionTm.PenFe), 0, oLiquidacionTm.PenFe)
                prmParameter(34).Value = IIf(IsNothing(oLiquidacionTm.PenAl203), 0, oLiquidacionTm.PenAl203)
                prmParameter(35).Value = IIf(IsNothing(oLiquidacionTm.PenCo), 0, oLiquidacionTm.PenCo)
                prmParameter(36).Value = IIf(IsNothing(oLiquidacionTm.PenMo), 0, oLiquidacionTm.PenMo)
                prmParameter(37).Value = IIf(IsNothing(oLiquidacionTm.PenP), 0, oLiquidacionTm.PenP)
                prmParameter(38).Value = IIf(IsNothing(oLiquidacionTm.Pen20), 0, oLiquidacionTm.Pen20)
                prmParameter(39).Value = IIf(IsNothing(oLiquidacionTm.Pen21), 0, oLiquidacionTm.Pen21)
                prmParameter(40).Value = IIf(IsNothing(oLiquidacionTm.Pen22), 0, oLiquidacionTm.Pen22)
                prmParameter(41).Value = IIf(IsNothing(oLiquidacionTm.Pen23), 0, oLiquidacionTm.Pen23)
                prmParameter(42).Value = IIf(IsNothing(oLiquidacionTm.Pen24), 0, oLiquidacionTm.Pen24)
                prmParameter(43).Value = IIf(IsNothing(oLiquidacionTm.Pen25), 0, oLiquidacionTm.Pen25)
                prmParameter(44).Value = IIf(IsNothing(oLiquidacionTm.Pen26), 0, oLiquidacionTm.Pen26)
                prmParameter(45).Value = IIf(IsNothing(oLiquidacionTm.Pen27), 0, oLiquidacionTm.Pen27)
                prmParameter(46).Value = IIf(IsNothing(oLiquidacionTm.Pen28), 0, oLiquidacionTm.Pen28)
                prmParameter(47).Value = IIf(IsNothing(oLiquidacionTm.Pen29), 0, oLiquidacionTm.Pen29)
                prmParameter(48).Value = IIf(IsNothing(oLiquidacionTm.Pen30), 0, oLiquidacionTm.Pen30)

                prmParameter(29).Direction = ParameterDirection.Input
                prmParameter(30).Direction = ParameterDirection.Input
                prmParameter(31).Direction = ParameterDirection.Input
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


                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionTm_Insertar", prmParameter)
                Catch ex As Exception
                    Throw ex
                    Return False
                End Try
            Next
            Return True
        End Function

    End Class
#End Region

#Region "Clase Lectura"
    
    Partial Public Class clsDB_LiquidacionTmRO


        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 24/04/2011 10:53:25 a.m.
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSLiquidacion(ByVal pLiquidacionTm As clsBE_LiquidacionTm) As DataSet
            Dim oDSLiquidacionTm As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(1) As SqlParameter
            prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.VarChar, 20)
            prmParameter(0).Value = IIf(IsNothing(pLiquidacionTm.contratoLoteId), "", pLiquidacionTm.contratoLoteId)
            prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.VarChar, 20)
            prmParameter(1).Value = IIf(IsNothing(pLiquidacionTm.liquidacionId), "", pLiquidacionTm.liquidacionId)
            Try

                Using oDSLiquidacionTm
                    oDSLiquidacionTm = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_LiquidacionTm_Sellst_lista", prmParameter)
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
        ''' Fecha Creacion: 24/04/2011 10:53:25 a.m.
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function DefineTablaLiquidacionTm() As DataTable

            Try
                Dim DTLiquidacionTm As New DataTable

                Dim id As DataColumn = DTLiquidacionTm.Columns.Add("id", GetType(Integer))
                id.AllowDBNull = False

                Dim merma As DataColumn = DTLiquidacionTm.Columns.Add("merma", GetType(Decimal))
                merma.AllowDBNull = False

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


                Dim PagAgOz As DataColumn = DTLiquidacionTm.Columns.Add("PagAgOz", GetType(Decimal))
                PagAg.AllowDBNull = True
                PagAg.DefaultValue = 0.0


                Dim PagAu As DataColumn = DTLiquidacionTm.Columns.Add("PagAu", GetType(Decimal))
                PagAu.AllowDBNull = True
                PagAu.DefaultValue = 0.0


                Dim PagAuOz As DataColumn = DTLiquidacionTm.Columns.Add("PagAuOz", GetType(Decimal))
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

                Dim periodo As DataColumn = DTLiquidacionTm.Columns.Add("periodo", GetType(String))
                periodo.MaxLength = 50
                periodo.AllowDBNull = True
                periodo.DefaultValue = ""

                Dim idtablaint As DataColumn = DTLiquidacionTm.Columns.Add("idtablaint", GetType(String))
                idtablaint.MaxLength = 20
                idtablaint.AllowDBNull = True
                idtablaint.DefaultValue = ""



                Dim PenCl As DataColumn = DTLiquidacionTm.Columns.Add("PenCl", GetType(Decimal))
                PenCl.AllowDBNull = True
                PenCl.DefaultValue = 0.0

                Dim PenCd As DataColumn = DTLiquidacionTm.Columns.Add("PenCd", GetType(Decimal))
                PenCd.AllowDBNull = True
                PenCd.DefaultValue = 0.0

                Dim PenF As DataColumn = DTLiquidacionTm.Columns.Add("PenF", GetType(Decimal))
                PenF.AllowDBNull = True
                PenF.DefaultValue = 0.0

                Dim PenS As DataColumn = DTLiquidacionTm.Columns.Add("PenS", GetType(Decimal))
                PenS.AllowDBNull = True
                PenS.DefaultValue = 0.0

                Dim PenFe As DataColumn = DTLiquidacionTm.Columns.Add("PenFe", GetType(Decimal))
                PenFe.AllowDBNull = True
                PenFe.DefaultValue = 0.0

                Dim PenAl203 As DataColumn = DTLiquidacionTm.Columns.Add("PenAl203", GetType(Decimal))
                PenAl203.AllowDBNull = True
                PenAl203.DefaultValue = 0.0

                Dim PenCo As DataColumn = DTLiquidacionTm.Columns.Add("PenCo", GetType(Decimal))
                PenCo.AllowDBNull = True
                PenCo.DefaultValue = 0.0

                Dim PenMo As DataColumn = DTLiquidacionTm.Columns.Add("PenMo", GetType(Decimal))
                PenMo.AllowDBNull = True
                PenMo.DefaultValue = 0.0

                Dim PenP As DataColumn = DTLiquidacionTm.Columns.Add("PenP", GetType(Decimal))
                PenP.AllowDBNull = True
                PenP.DefaultValue = 0.0



                Dim Pen20 As DataColumn = DTLiquidacionTm.Columns.Add("Pen20", GetType(Decimal))
                Pen20.AllowDBNull = True
                Pen20.DefaultValue = 0.0
                Dim Pen21 As DataColumn = DTLiquidacionTm.Columns.Add("Pen21", GetType(Decimal))
                Pen21.AllowDBNull = True
                Pen21.DefaultValue = 0.0
                Dim Pen22 As DataColumn = DTLiquidacionTm.Columns.Add("Pen22", GetType(Decimal))
                Pen22.AllowDBNull = True
                Pen22.DefaultValue = 0.0
                Dim Pen23 As DataColumn = DTLiquidacionTm.Columns.Add("Pen23", GetType(Decimal))
                Pen23.AllowDBNull = True
                Pen23.DefaultValue = 0.0
                Dim Pen24 As DataColumn = DTLiquidacionTm.Columns.Add("Pen24", GetType(Decimal))
                Pen24.AllowDBNull = True
                Pen24.DefaultValue = 0.0
                Dim Pen25 As DataColumn = DTLiquidacionTm.Columns.Add("Pen25", GetType(Decimal))
                Pen25.AllowDBNull = True
                Pen25.DefaultValue = 0.0
                Dim Pen26 As DataColumn = DTLiquidacionTm.Columns.Add("Pen26", GetType(Decimal))
                Pen26.AllowDBNull = True
                Pen26.DefaultValue = 0.0
                Dim Pen27 As DataColumn = DTLiquidacionTm.Columns.Add("Pen27", GetType(Decimal))
                Pen27.AllowDBNull = True
                Pen27.DefaultValue = 0.0
                Dim Pen28 As DataColumn = DTLiquidacionTm.Columns.Add("Pen28", GetType(Decimal))
                Pen28.AllowDBNull = True
                Pen28.DefaultValue = 0.0
                Dim Pen29 As DataColumn = DTLiquidacionTm.Columns.Add("Pen29", GetType(Decimal))
                Pen29.AllowDBNull = True
                Pen29.DefaultValue = 0.0
                Dim Pen30 As DataColumn = DTLiquidacionTm.Columns.Add("Pen30", GetType(Decimal))
                Pen30.AllowDBNull = True
                Pen30.DefaultValue = 0.0


                Return DTLiquidacionTm
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class
#End Region

End Namespace
