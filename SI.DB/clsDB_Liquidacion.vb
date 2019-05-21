'@Modified:
'@01 20141006 BAL01 Se agregan campos para PP (valorPP,valorPPSol,valorTipoCambioPP)

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
    ''' Fecha Creacion: 17/02/2011 16:40:01
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla Liquidacion
    ''' Fecha Modificacion:
    ''' </summary>
	'''

	Public Class clsDB_LiquidacionTX
		
		Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:40:01
        ''' Proposito: Metodo de Insercci?n de Datos
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Function InsertarLiquidacion(ByVal oLstLiquidacion As List(Of clsBE_Liquidacion)) As Boolean
			For Each oLiquidacion As clsBE_Liquidacion In oLstLiquidacion
                '@01    D01
                'Dim prmParameter(56) As SqlParameter
                '@01    A01
                Dim prmParameter(66) As SqlParameter
			
					prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar , 20)
							prmParameter(0).Value = IIf(IsNothing(oLiquidacion.contratoLoteId), "", oLiquidacion.contratoLoteId)
					prmParameter(0).Direction = ParameterDirection.Input
					prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.varchar , 20)
							prmParameter(1).Value = IIf(IsNothing(oLiquidacion.liquidacionId), "", oLiquidacion.liquidacionId)
					prmParameter(1).Direction = ParameterDirection.Input
					prmParameter(2) = New SqlParameter("@pbase1", SqlDbType.Float , 4)
								prmParameter(2).Value = IIf(IsNothing(oLiquidacion.base1),0, oLiquidacion.base1)
					prmParameter(2).Direction = ParameterDirection.Input
					prmParameter(3) = New SqlParameter("@pescaladorMas1", SqlDbType.Float , 4)
								prmParameter(3).Value = IIf(IsNothing(oLiquidacion.escaladorMas1),0, oLiquidacion.escaladorMas1)
					prmParameter(3).Direction = ParameterDirection.Input
					prmParameter(4) = New SqlParameter("@pescaladorMenos1", SqlDbType.Float , 4)
								prmParameter(4).Value = IIf(IsNothing(oLiquidacion.escaladorMenos1),0, oLiquidacion.escaladorMenos1)
					prmParameter(4).Direction = ParameterDirection.Input
					prmParameter(5) = New SqlParameter("@pbase2", SqlDbType.Float , 4)
								prmParameter(5).Value = IIf(IsNothing(oLiquidacion.base2),0, oLiquidacion.base2)
					prmParameter(5).Direction = ParameterDirection.Input
					prmParameter(6) = New SqlParameter("@pescaladorMas2", SqlDbType.Float , 4)
								prmParameter(6).Value = IIf(IsNothing(oLiquidacion.escaladorMas2),0, oLiquidacion.escaladorMas2)
					prmParameter(6).Direction = ParameterDirection.Input
					prmParameter(7) = New SqlParameter("@pescaladorMenos2", SqlDbType.Float , 4)
								prmParameter(7).Value = IIf(IsNothing(oLiquidacion.escaladorMenos2),0, oLiquidacion.escaladorMenos2)
					prmParameter(7).Direction = ParameterDirection.Input
					prmParameter(8) = New SqlParameter("@ppp", SqlDbType.Float , 4)
								prmParameter(8).Value = IIf(IsNothing(oLiquidacion.pp),0, oLiquidacion.pp)
					prmParameter(8).Direction = ParameterDirection.Input
					prmParameter(9) = New SqlParameter("@pbasepp", SqlDbType.Float , 4)
								prmParameter(9).Value = IIf(IsNothing(oLiquidacion.basepp),0, oLiquidacion.basepp)
					prmParameter(9).Direction = ParameterDirection.Input
					prmParameter(10) = New SqlParameter("@pporcentajeMerma", SqlDbType.Float , 4)
								prmParameter(10).Value = IIf(IsNothing(oLiquidacion.porcentajeMerma),0, oLiquidacion.porcentajeMerma)
					prmParameter(10).Direction = ParameterDirection.Input
					prmParameter(11) = New SqlParameter("@pporcentajePago", SqlDbType.Float , 4)
								prmParameter(11).Value = IIf(IsNothing(oLiquidacion.porcentajePago),0, oLiquidacion.porcentajePago)
					prmParameter(11).Direction = ParameterDirection.Input
					prmParameter(12) = New SqlParameter("@pcalculoTMSN", SqlDbType.Float , 4)
								prmParameter(12).Value = IIf(IsNothing(oLiquidacion.calculoTMSN),0, oLiquidacion.calculoTMSN)
					prmParameter(12).Direction = ParameterDirection.Input
					prmParameter(13) = New SqlParameter("@pcalculoPagable", SqlDbType.Float , 4)
								prmParameter(13).Value = IIf(IsNothing(oLiquidacion.calculoPagable),0, oLiquidacion.calculoPagable)
					prmParameter(13).Direction = ParameterDirection.Input
					prmParameter(14) = New SqlParameter("@pcalculoMaquila", SqlDbType.Float , 4)
								prmParameter(14).Value = IIf(IsNothing(oLiquidacion.calculoMaquila),0, oLiquidacion.calculoMaquila)
					prmParameter(14).Direction = ParameterDirection.Input
					prmParameter(15) = New SqlParameter("@pcalculoRefinacion", SqlDbType.Float , 4)
								prmParameter(15).Value = IIf(IsNothing(oLiquidacion.calculoRefinacion),0, oLiquidacion.calculoRefinacion)
					prmParameter(15).Direction = ParameterDirection.Input
					prmParameter(16) = New SqlParameter("@pcalculoPenalizable", SqlDbType.Float , 4)
								prmParameter(16).Value = IIf(IsNothing(oLiquidacion.calculoPenalizable),0, oLiquidacion.calculoPenalizable)
					prmParameter(16).Direction = ParameterDirection.Input
					prmParameter(17) = New SqlParameter("@pcalculoServicio", SqlDbType.Float , 4)
								prmParameter(17).Value = IIf(IsNothing(oLiquidacion.calculoServicio),0, oLiquidacion.calculoServicio)
					prmParameter(17).Direction = ParameterDirection.Input
					prmParameter(18) = New SqlParameter("@pcalculoPrecioTMSN", SqlDbType.Float , 4)
								prmParameter(18).Value = IIf(IsNothing(oLiquidacion.calculoPrecioTMSN),0, oLiquidacion.calculoPrecioTMSN)
					prmParameter(18).Direction = ParameterDirection.Input
					prmParameter(19) = New SqlParameter("@pcalculoCargoAjuste", SqlDbType.Float , 4)
								prmParameter(19).Value = IIf(IsNothing(oLiquidacion.calculoCargoAjuste),0, oLiquidacion.calculoCargoAjuste)
					prmParameter(19).Direction = ParameterDirection.Input
					prmParameter(20) = New SqlParameter("@pcalculoPrecioUnitario", SqlDbType.Float , 4)
								prmParameter(20).Value = IIf(IsNothing(oLiquidacion.calculoPrecioUnitario),0, oLiquidacion.calculoPrecioUnitario)
					prmParameter(20).Direction = ParameterDirection.Input
					prmParameter(21) = New SqlParameter("@pvalorVenta", SqlDbType.Float , 4)
								prmParameter(21).Value = IIf(IsNothing(oLiquidacion.valorVenta),0, oLiquidacion.valorVenta)
					prmParameter(21).Direction = ParameterDirection.Input
					prmParameter(22) = New SqlParameter("@pvalorIgv", SqlDbType.Float , 4)
								prmParameter(22).Value = IIf(IsNothing(oLiquidacion.valorIgv),0, oLiquidacion.valorIgv)
					prmParameter(22).Direction = ParameterDirection.Input
					prmParameter(23) = New SqlParameter("@pvalorTotal", SqlDbType.Float , 4)
								prmParameter(23).Value = IIf(IsNothing(oLiquidacion.valorTotal),0, oLiquidacion.valorTotal)
					prmParameter(23).Direction = ParameterDirection.Input
					prmParameter(24) = New SqlParameter("@ptotalPorPagar", SqlDbType.Float , 4)
								prmParameter(24).Value = IIf(IsNothing(oLiquidacion.totalPorPagar),0, oLiquidacion.totalPorPagar)
					prmParameter(24).Direction = ParameterDirection.Input
					prmParameter(25) = New SqlParameter("@ptotalDscto", SqlDbType.Float , 4)
								prmParameter(25).Value = IIf(IsNothing(oLiquidacion.totalDscto),0, oLiquidacion.totalDscto)
					prmParameter(25).Direction = ParameterDirection.Input
					prmParameter(26) = New SqlParameter("@ptotalNetoxPagar", SqlDbType.Float , 4)
								prmParameter(26).Value = IIf(IsNothing(oLiquidacion.totalNetoxPagar),0, oLiquidacion.totalNetoxPagar)
					prmParameter(26).Direction = ParameterDirection.Input
					prmParameter(27) = New SqlParameter("@pcodigoCalculo", SqlDbType.varchar , 15)
							prmParameter(27).Value = IIf(IsNothing(oLiquidacion.codigoCalculo), "", oLiquidacion.codigoCalculo)
					prmParameter(27).Direction = ParameterDirection.Input
					prmParameter(28) = New SqlParameter("@pperiodo", SqlDbType.varchar , 6)
							prmParameter(28).Value = IIf(IsNothing(oLiquidacion.periodo), "", oLiquidacion.periodo)
					prmParameter(28).Direction = ParameterDirection.Input
					prmParameter(29) = New SqlParameter("@pcodigoDocumento", SqlDbType.varchar , 15)
							prmParameter(29).Value = IIf(IsNothing(oLiquidacion.codigoDocumento), "", oLiquidacion.codigoDocumento)
					prmParameter(29).Direction = ParameterDirection.Input
					prmParameter(30) = New SqlParameter("@pfechaDocumento", SqlDbType.DateTime , 8)
						prmParameter(30).Value = clsUT_Funcion.FechaNull(oLiquidacion.fechaDocumento)
					prmParameter(30).Direction = ParameterDirection.Input
					prmParameter(31) = New SqlParameter("@pnumeroDocumento", SqlDbType.varchar , 18)
								prmParameter(31).Value = IIf(IsNothing(oLiquidacion.numeroDocumento),0, oLiquidacion.numeroDocumento)
					prmParameter(31).Direction = ParameterDirection.Input
					prmParameter(32) = New SqlParameter("@pcodigoEstado", SqlDbType.varchar , 15)
							prmParameter(32).Value = IIf(IsNothing(oLiquidacion.codigoEstado), "", oLiquidacion.codigoEstado)
					prmParameter(32).Direction = ParameterDirection.Input
					prmParameter(33) = New SqlParameter("@puc", SqlDbType.varchar , 15)
							prmParameter(33).Value = IIf(IsNothing(oLiquidacion.uc), "", oLiquidacion.uc)
					prmParameter(33).Direction = ParameterDirection.Input
					prmParameter(34) = New SqlParameter("@pnumeroCalculo", SqlDbType.Int , 4)
								prmParameter(34).Value = IIf(IsNothing(oLiquidacion.numeroCalculo),0, oLiquidacion.numeroCalculo)
					prmParameter(34).Direction = ParameterDirection.Input
					prmParameter(35) = New SqlParameter("@pcalculoTmh", SqlDbType.Float , 4)
								prmParameter(35).Value = IIf(IsNothing(oLiquidacion.calculoTmh),0, oLiquidacion.calculoTmh)
					prmParameter(35).Direction = ParameterDirection.Input
					prmParameter(36) = New SqlParameter("@pcalculoH2o", SqlDbType.Float , 4)
								prmParameter(36).Value = IIf(IsNothing(oLiquidacion.calculoH2o),0, oLiquidacion.calculoH2o)
					prmParameter(36).Direction = ParameterDirection.Input
					prmParameter(37) = New SqlParameter("@pcalculoTms", SqlDbType.Float , 4)
								prmParameter(37).Value = IIf(IsNothing(oLiquidacion.calculoTms),0, oLiquidacion.calculoTms)
					prmParameter(37).Direction = ParameterDirection.Input
					prmParameter(38) = New SqlParameter("@pcalculoMerma", SqlDbType.Float , 4)
								prmParameter(38).Value = IIf(IsNothing(oLiquidacion.calculoMerma),0, oLiquidacion.calculoMerma)
					prmParameter(38).Direction = ParameterDirection.Input
					prmParameter(39) = New SqlParameter("@pmaquila", SqlDbType.Float , 4)
								prmParameter(39).Value = IIf(IsNothing(oLiquidacion.maquila),0, oLiquidacion.maquila)
					prmParameter(39).Direction = ParameterDirection.Input
					prmParameter(40) = New SqlParameter("@ptasaInteres", SqlDbType.Float , 4)
								prmParameter(40).Value = IIf(IsNothing(oLiquidacion.tasaInteres),0, oLiquidacion.tasaInteres)
					prmParameter(40).Direction = ParameterDirection.Input
					prmParameter(41) = New SqlParameter("@ptasaMoratoria", SqlDbType.Float , 4)
								prmParameter(41).Value = IIf(IsNothing(oLiquidacion.tasaMoratoria),0, oLiquidacion.tasaMoratoria)
					prmParameter(41).Direction = ParameterDirection.Input
					prmParameter(42) = New SqlParameter("@ptasaTiempo", SqlDbType.Float , 4)
								prmParameter(42).Value = IIf(IsNothing(oLiquidacion.tasaTiempo),0, oLiquidacion.tasaTiempo)
					prmParameter(42).Direction = ParameterDirection.Input
					prmParameter(43) = New SqlParameter("@pcodigoTasa", SqlDbType.varchar , 15)
							prmParameter(43).Value = IIf(IsNothing(oLiquidacion.codigoTasa), "", oLiquidacion.codigoTasa)
					prmParameter(43).Direction = ParameterDirection.Input
					prmParameter(44) = New SqlParameter("@pcodigoIncoterm", SqlDbType.varchar , 15)
							prmParameter(44).Value = IIf(IsNothing(oLiquidacion.codigoIncoterm), "", oLiquidacion.codigoIncoterm)
					prmParameter(44).Direction = ParameterDirection.Input
					prmParameter(45) = New SqlParameter("@pcodigoDeposito", SqlDbType.varchar , 15)
							prmParameter(45).Value = IIf(IsNothing(oLiquidacion.codigoDeposito), "", oLiquidacion.codigoDeposito)
					prmParameter(45).Direction = ParameterDirection.Input
					prmParameter(46) = New SqlParameter("@pcalculoPp", SqlDbType.Float , 4)
								prmParameter(46).Value = IIf(IsNothing(oLiquidacion.calculoPp),0, oLiquidacion.calculoPp)
					prmParameter(46).Direction = ParameterDirection.Input
					prmParameter(47) = New SqlParameter("@pcargoAjuste", SqlDbType.Float , 4)
								prmParameter(47).Value = IIf(IsNothing(oLiquidacion.cargoAjuste),0, oLiquidacion.cargoAjuste)
					prmParameter(47).Direction = ParameterDirection.Input
					prmParameter(48) = New SqlParameter("@pfechaRegistro", SqlDbType.DateTime , 8)
						prmParameter(48).Value = clsUT_Funcion.FechaNull(oLiquidacion.fechaRegistro)
					prmParameter(48).Direction = ParameterDirection.Input
					prmParameter(49) = New SqlParameter("@pcodigoTrader", SqlDbType.varchar , 15)
							prmParameter(49).Value = IIf(IsNothing(oLiquidacion.codigoTrader), "", oLiquidacion.codigoTrader)
					prmParameter(49).Direction = ParameterDirection.Input
					prmParameter(50) = New SqlParameter("@pcodigoAdministrador", SqlDbType.varchar , 15)
							prmParameter(50).Value = IIf(IsNothing(oLiquidacion.codigoAdministrador), "", oLiquidacion.codigoAdministrador)
					prmParameter(50).Direction = ParameterDirection.Input
					prmParameter(51) = New SqlParameter("@pcodigoUsuario", SqlDbType.varchar , 15)
							prmParameter(51).Value = IIf(IsNothing(oLiquidacion.codigoUsuario), "", oLiquidacion.codigoUsuario)
					prmParameter(51).Direction = ParameterDirection.Input
					prmParameter(52) = New SqlParameter("@pstatus", SqlDbType.varchar , 100)
							prmParameter(52).Value = IIf(IsNothing(oLiquidacion.status), "", oLiquidacion.status)
					prmParameter(52).Direction = ParameterDirection.Input
					prmParameter(53) = New SqlParameter("@pcontrol", SqlDbType.varchar , 100)
							prmParameter(53).Value = IIf(IsNothing(oLiquidacion.control), "", oLiquidacion.control)
                prmParameter(53).Direction = ParameterDirection.Input

                prmParameter(54) = New SqlParameter("@H2OFin", SqlDbType.Int)
                prmParameter(54).Value = IIf(IsNothing(oLiquidacion.H2O), "", oLiquidacion.H2O)
                prmParameter(54).Direction = ParameterDirection.Input



                prmParameter(55) = New SqlParameter("@produccionPropia", SqlDbType.Float)
                '@01    D02
                'prmParameter(55).Value = IIf(IsNothing(oLiquidacion.Ajuste), 0, oLiquidacion.Ajuste)
                'prmParameter(55).Direction = ParameterDirection.Input
                '@01    A02
                prmParameter(55).Value = IIf(IsNothing(oLiquidacion.valorPP), 0, oLiquidacion.valorPP)
                prmParameter(55).Direction = ParameterDirection.Input

                prmParameter(56) = New SqlParameter("@costoVenta", SqlDbType.Float)
                prmParameter(56).Value = IIf(IsNothing(oLiquidacion.costoVenta), 0, oLiquidacion.costoVenta)
                prmParameter(56).Direction = ParameterDirection.Input

                'Agregar campos = que al modif liquidacion... existe otra function que utiliza up_Liquidacion_Ins pero la funcion que la invoca no tiene referencias hacia el, se puede modificar sin cuidado =).
                '@01    A06
                prmParameter(57) = New SqlParameter("@valorPPSol", SqlDbType.Float)
                prmParameter(57).Value = IIf(IsNothing(oLiquidacion.valorPPSol), 0, oLiquidacion.valorPPSol)
                prmParameter(57).Direction = ParameterDirection.Input

                prmParameter(58) = New SqlParameter("@valorTipoCambioPP", SqlDbType.Float)
                prmParameter(58).Value = IIf(IsNothing(oLiquidacion.valorTipoCambioPP), 0, oLiquidacion.valorTipoCambioPP)
                prmParameter(58).Direction = ParameterDirection.Input


                prmParameter(59) = New SqlParameter("@periodoComercial", SqlDbType.VarChar, 6)
                prmParameter(59).Value = IIf(IsNothing(oLiquidacion.periodoComercial), "", oLiquidacion.periodoComercial)
                prmParameter(59).Direction = ParameterDirection.Input

                prmParameter(60) = New SqlParameter("@costoOperativo", SqlDbType.Float)
                prmParameter(60).Value = IIf(IsNothing(oLiquidacion.costoOperativo), 0, oLiquidacion.costoOperativo)
                prmParameter(60).Direction = ParameterDirection.Input

                prmParameter(61) = New SqlParameter("@pbaseRc", SqlDbType.Float, 4)
                prmParameter(61).Value = IIf(IsNothing(oLiquidacion.baseRc), 0, oLiquidacion.baseRc)
                prmParameter(61).Direction = ParameterDirection.Input

                prmParameter(62) = New SqlParameter("@pRcmas", SqlDbType.Float, 4)
                prmParameter(62).Value = IIf(IsNothing(oLiquidacion.RcMas), 0, oLiquidacion.RcMas)
                prmParameter(62).Direction = ParameterDirection.Input

                prmParameter(63) = New SqlParameter("@pRcmenos", SqlDbType.Float, 4)
                prmParameter(63).Value = IIf(IsNothing(oLiquidacion.RcMenos), 0, oLiquidacion.RcMenos)
                prmParameter(63).Direction = ParameterDirection.Input

                prmParameter(64) = New SqlParameter("@pRcBaseCon", SqlDbType.Float, 4)
                prmParameter(64).Value = IIf(IsNothing(oLiquidacion.RcBaseCon), 0, oLiquidacion.RcBaseCon)
                prmParameter(64).Direction = ParameterDirection.Input

                prmParameter(65) = New SqlParameter("@pContMas", SqlDbType.Float, 4)
                prmParameter(65).Value = IIf(IsNothing(oLiquidacion.ContMas), 0, oLiquidacion.ContMas)
                prmParameter(65).Direction = ParameterDirection.Input

                prmParameter(66) = New SqlParameter("@pContmenos", SqlDbType.Float, 4)
                prmParameter(66).Value = IIf(IsNothing(oLiquidacion.ContMenos), 0, oLiquidacion.ContMenos)
                prmParameter(66).Direction = ParameterDirection.Input



				Try		
				    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_Liquidacion_Ins", prmParameter)
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
		''' Fecha Creacion: 17/02/2011 16:40:01
        ''' Proposito: Metodo de Modificacion de datos
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Function ModificarLiquidacion(ByVal oLstLiquidacion As List(Of clsBE_Liquidacion)) As Boolean
            For Each oLiquidacion As clsBE_Liquidacion In oLstLiquidacion
                '@01    D01
                'Dim prmParameter(57) As SqlParameter
                '@01    A01
                Dim prmParameter(67) As SqlParameter

                prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(oLiquidacion.contratoLoteId), "", oLiquidacion.contratoLoteId)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.VarChar, 20)
                prmParameter(1).Value = IIf(IsNothing(oLiquidacion.liquidacionId), "", oLiquidacion.liquidacionId)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pbase1", SqlDbType.Int, 8)
                prmParameter(2).Value = IIf(IsNothing(oLiquidacion.base1), 0, oLiquidacion.base1)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@pescaladorMas1", SqlDbType.Float, 4)
                prmParameter(3).Value = IIf(IsNothing(oLiquidacion.escaladorMas1), 0, oLiquidacion.escaladorMas1)
                prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@pescaladorMenos1", SqlDbType.Float, 4)
                prmParameter(4).Value = IIf(IsNothing(oLiquidacion.escaladorMenos1), 0, oLiquidacion.escaladorMenos1)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@pbase2", SqlDbType.Float, 4)
                prmParameter(5).Value = IIf(IsNothing(oLiquidacion.base2), 0, oLiquidacion.base2)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@pescaladorMas2", SqlDbType.Float, 4)
                prmParameter(6).Value = IIf(IsNothing(oLiquidacion.escaladorMas2), 0, oLiquidacion.escaladorMas2)
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7) = New SqlParameter("@pescaladorMenos2", SqlDbType.Float, 4)
                prmParameter(7).Value = IIf(IsNothing(oLiquidacion.escaladorMenos2), 0, oLiquidacion.escaladorMenos2)
                prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(8) = New SqlParameter("@ppp", SqlDbType.Float, 4)
                prmParameter(8).Value = IIf(IsNothing(oLiquidacion.pp), 0, oLiquidacion.pp)
                prmParameter(8).Direction = ParameterDirection.Input
                prmParameter(9) = New SqlParameter("@pbasepp", SqlDbType.Float, 4)
                prmParameter(9).Value = IIf(IsNothing(oLiquidacion.basepp), 0, oLiquidacion.basepp)
                prmParameter(9).Direction = ParameterDirection.Input
                prmParameter(10) = New SqlParameter("@pporcentajeMerma", SqlDbType.Float, 4)
                prmParameter(10).Value = IIf(IsNothing(oLiquidacion.porcentajeMerma), 0, oLiquidacion.porcentajeMerma)
                prmParameter(10).Direction = ParameterDirection.Input
                prmParameter(11) = New SqlParameter("@pporcentajePago", SqlDbType.Float, 4)
                prmParameter(11).Value = IIf(IsNothing(oLiquidacion.porcentajePago), 0, oLiquidacion.porcentajePago)
                prmParameter(11).Direction = ParameterDirection.Input
                prmParameter(12) = New SqlParameter("@pcalculoTMSN", SqlDbType.Float, 4)
                prmParameter(12).Value = IIf(IsNothing(oLiquidacion.calculoTMSN), 0, oLiquidacion.calculoTMSN)
                prmParameter(12).Direction = ParameterDirection.Input
                prmParameter(13) = New SqlParameter("@pcalculoPagable", SqlDbType.Float, 4)
                prmParameter(13).Value = IIf(IsNothing(oLiquidacion.calculoPagable), 0, oLiquidacion.calculoPagable)
                prmParameter(13).Direction = ParameterDirection.Input
                prmParameter(14) = New SqlParameter("@pcalculoMaquila", SqlDbType.Float, 4)
                prmParameter(14).Value = IIf(IsNothing(oLiquidacion.calculoMaquila), 0, oLiquidacion.calculoMaquila)
                prmParameter(14).Direction = ParameterDirection.Input
                prmParameter(15) = New SqlParameter("@pcalculoRefinacion", SqlDbType.Float, 4)
                prmParameter(15).Value = IIf(IsNothing(oLiquidacion.calculoRefinacion), 0, oLiquidacion.calculoRefinacion)
                prmParameter(15).Direction = ParameterDirection.Input
                prmParameter(16) = New SqlParameter("@pcalculoPenalizable", SqlDbType.Float, 4)
                prmParameter(16).Value = IIf(IsNothing(oLiquidacion.calculoPenalizable), 0, oLiquidacion.calculoPenalizable)
                prmParameter(16).Direction = ParameterDirection.Input
                prmParameter(17) = New SqlParameter("@pcalculoServicio", SqlDbType.Float, 4)
                prmParameter(17).Value = IIf(IsNothing(oLiquidacion.calculoServicio), 0, oLiquidacion.calculoServicio)
                prmParameter(17).Direction = ParameterDirection.Input
                prmParameter(18) = New SqlParameter("@pcalculoPrecioTMSN", SqlDbType.Float, 4)
                prmParameter(18).Value = IIf(IsNothing(oLiquidacion.calculoPrecioTMSN), 0, oLiquidacion.calculoPrecioTMSN)
                prmParameter(18).Direction = ParameterDirection.Input
                prmParameter(19) = New SqlParameter("@pcalculoCargoAjuste", SqlDbType.Float, 4)
                prmParameter(19).Value = IIf(IsNothing(oLiquidacion.calculoCargoAjuste), 0, oLiquidacion.calculoCargoAjuste)
                prmParameter(19).Direction = ParameterDirection.Input
                prmParameter(20) = New SqlParameter("@pcalculoPrecioUnitario", SqlDbType.Float, 4)
                prmParameter(20).Value = IIf(IsNothing(oLiquidacion.calculoPrecioUnitario), 0, oLiquidacion.calculoPrecioUnitario)
                prmParameter(20).Direction = ParameterDirection.Input
                prmParameter(21) = New SqlParameter("@pvalorVenta", SqlDbType.Float, 4)
                prmParameter(21).Value = IIf(IsNothing(oLiquidacion.valorVenta), 0, oLiquidacion.valorVenta)
                prmParameter(21).Direction = ParameterDirection.Input
                prmParameter(22) = New SqlParameter("@pvalorIgv", SqlDbType.Float, 4)
                prmParameter(22).Value = IIf(IsNothing(oLiquidacion.valorIgv), 0, oLiquidacion.valorIgv)
                prmParameter(22).Direction = ParameterDirection.Input
                prmParameter(23) = New SqlParameter("@pvalorTotal", SqlDbType.Float, 4)
                prmParameter(23).Value = IIf(IsNothing(oLiquidacion.valorTotal), 0, oLiquidacion.valorTotal)
                prmParameter(23).Direction = ParameterDirection.Input
                prmParameter(24) = New SqlParameter("@ptotalPorPagar", SqlDbType.Float, 4)
                prmParameter(24).Value = IIf(IsNothing(oLiquidacion.totalPorPagar), 0, oLiquidacion.totalPorPagar)
                prmParameter(24).Direction = ParameterDirection.Input
                prmParameter(25) = New SqlParameter("@ptotalDscto", SqlDbType.Float, 4)
                prmParameter(25).Value = IIf(IsNothing(oLiquidacion.totalDscto), 0, oLiquidacion.totalDscto)
                prmParameter(25).Direction = ParameterDirection.Input
                prmParameter(26) = New SqlParameter("@ptotalNetoxPagar", SqlDbType.Float, 4)
                prmParameter(26).Value = IIf(IsNothing(oLiquidacion.totalNetoxPagar), 0, oLiquidacion.totalNetoxPagar)
                prmParameter(26).Direction = ParameterDirection.Input
                prmParameter(27) = New SqlParameter("@pcodigoCalculo", SqlDbType.VarChar, 15)
                prmParameter(27).Value = IIf(IsNothing(oLiquidacion.codigoCalculo), "", oLiquidacion.codigoCalculo)
                prmParameter(27).Direction = ParameterDirection.Input
                prmParameter(28) = New SqlParameter("@pperiodo", SqlDbType.VarChar, 6)
                prmParameter(28).Value = IIf(IsNothing(oLiquidacion.periodo), "", oLiquidacion.periodo)
                prmParameter(28).Direction = ParameterDirection.Input
                prmParameter(29) = New SqlParameter("@pcodigoDocumento", SqlDbType.VarChar, 15)
                prmParameter(29).Value = IIf(IsNothing(oLiquidacion.codigoDocumento), "", oLiquidacion.codigoDocumento)
                prmParameter(29).Direction = ParameterDirection.Input
                prmParameter(30) = New SqlParameter("@pfechaDocumento", SqlDbType.DateTime, 8)
                prmParameter(30).Value = clsUT_Funcion.FechaNull(oLiquidacion.fechaDocumento)
                prmParameter(30).Direction = ParameterDirection.Input
                prmParameter(31) = New SqlParameter("@pnumeroDocumento", SqlDbType.VarChar, 18)
                prmParameter(31).Value = IIf(IsNothing(oLiquidacion.numeroDocumento), 0, oLiquidacion.numeroDocumento)
                prmParameter(31).Direction = ParameterDirection.Input
                prmParameter(32) = New SqlParameter("@pcodigoEstado", SqlDbType.VarChar, 15)
                prmParameter(32).Value = IIf(IsNothing(oLiquidacion.codigoEstado), "", oLiquidacion.codigoEstado)
                prmParameter(32).Direction = ParameterDirection.Input
                prmParameter(33) = New SqlParameter("@pum", SqlDbType.VarChar, 15)
                prmParameter(33).Value = IIf(IsNothing(oLiquidacion.um), "", oLiquidacion.um)
                prmParameter(33).Direction = ParameterDirection.Input
                prmParameter(34) = New SqlParameter("@pfm", SqlDbType.DateTime, 8)
                prmParameter(34).Value = clsUT_Funcion.FechaNull(oLiquidacion.fm)
                prmParameter(34).Direction = ParameterDirection.Input
                prmParameter(35) = New SqlParameter("@pnumeroCalculo", SqlDbType.Int, 4)
                prmParameter(35).Value = IIf(IsNothing(oLiquidacion.numeroCalculo), 0, oLiquidacion.numeroCalculo)
                prmParameter(35).Direction = ParameterDirection.Input
                prmParameter(36) = New SqlParameter("@pcalculoTmh", SqlDbType.Float, 4)
                prmParameter(36).Value = IIf(IsNothing(oLiquidacion.calculoTmh), 0, oLiquidacion.calculoTmh)
                prmParameter(36).Direction = ParameterDirection.Input
                prmParameter(37) = New SqlParameter("@pcalculoH2o", SqlDbType.Float, 4)
                prmParameter(37).Value = IIf(IsNothing(oLiquidacion.calculoH2o), 0, oLiquidacion.calculoH2o)
                prmParameter(37).Direction = ParameterDirection.Input
                prmParameter(38) = New SqlParameter("@pcalculoTms", SqlDbType.Float, 4)
                prmParameter(38).Value = IIf(IsNothing(oLiquidacion.calculoTms), 0, oLiquidacion.calculoTms)
                prmParameter(38).Direction = ParameterDirection.Input
                prmParameter(39) = New SqlParameter("@pcalculoMerma", SqlDbType.Float, 4)
                prmParameter(39).Value = IIf(IsNothing(oLiquidacion.calculoMerma), 0, oLiquidacion.calculoMerma)
                prmParameter(39).Direction = ParameterDirection.Input
                prmParameter(40) = New SqlParameter("@pmaquila", SqlDbType.Float, 4)
                prmParameter(40).Value = IIf(IsNothing(oLiquidacion.maquila), 0, oLiquidacion.maquila)
                prmParameter(40).Direction = ParameterDirection.Input
                prmParameter(41) = New SqlParameter("@ptasaInteres", SqlDbType.Float, 4)
                prmParameter(41).Value = IIf(IsNothing(oLiquidacion.tasaInteres), 0, oLiquidacion.tasaInteres)
                prmParameter(41).Direction = ParameterDirection.Input
                prmParameter(42) = New SqlParameter("@ptasaMoratoria", SqlDbType.Float, 4)
                prmParameter(42).Value = IIf(IsNothing(oLiquidacion.tasaMoratoria), 0, oLiquidacion.tasaMoratoria)
                prmParameter(42).Direction = ParameterDirection.Input
                prmParameter(43) = New SqlParameter("@ptasaTiempo", SqlDbType.Float, 4)
                prmParameter(43).Value = IIf(IsNothing(oLiquidacion.tasaTiempo), 0, oLiquidacion.tasaTiempo)
                prmParameter(43).Direction = ParameterDirection.Input
                prmParameter(44) = New SqlParameter("@pcodigoTasa", SqlDbType.VarChar, 15)
                prmParameter(44).Value = IIf(IsNothing(oLiquidacion.codigoTasa), "", oLiquidacion.codigoTasa)
                prmParameter(44).Direction = ParameterDirection.Input
                prmParameter(45) = New SqlParameter("@pcodigoIncoterm", SqlDbType.VarChar, 15)
                prmParameter(45).Value = IIf(IsNothing(oLiquidacion.codigoIncoterm), "", oLiquidacion.codigoIncoterm)
                prmParameter(45).Direction = ParameterDirection.Input
                prmParameter(46) = New SqlParameter("@pcodigoDeposito", SqlDbType.VarChar, 15)
                prmParameter(46).Value = IIf(IsNothing(oLiquidacion.codigoDeposito), "", oLiquidacion.codigoDeposito)
                prmParameter(46).Direction = ParameterDirection.Input
                prmParameter(47) = New SqlParameter("@pcalculoPp", SqlDbType.Float, 4)
                prmParameter(47).Value = IIf(IsNothing(oLiquidacion.calculoPp), 0, oLiquidacion.calculoPp)
                prmParameter(47).Direction = ParameterDirection.Input
                prmParameter(48) = New SqlParameter("@pcargoAjuste", SqlDbType.Float, 4)
                prmParameter(48).Value = IIf(IsNothing(oLiquidacion.cargoAjuste), 0, oLiquidacion.cargoAjuste)
                prmParameter(48).Direction = ParameterDirection.Input
                prmParameter(49) = New SqlParameter("@pfechaRegistro", SqlDbType.DateTime, 8)
                prmParameter(49).Value = clsUT_Funcion.FechaNull(oLiquidacion.fechaRegistro)
                prmParameter(49).Direction = ParameterDirection.Input
                prmParameter(50) = New SqlParameter("@pcodigoTrader", SqlDbType.VarChar, 15)
                prmParameter(50).Value = IIf(IsNothing(oLiquidacion.codigoTrader), "", oLiquidacion.codigoTrader)
                prmParameter(50).Direction = ParameterDirection.Input
                prmParameter(51) = New SqlParameter("@pcodigoAdministrador", SqlDbType.VarChar, 15)
                prmParameter(51).Value = IIf(IsNothing(oLiquidacion.codigoAdministrador), "", oLiquidacion.codigoAdministrador)
                prmParameter(51).Direction = ParameterDirection.Input
                prmParameter(52) = New SqlParameter("@pcodigoUsuario", SqlDbType.VarChar, 15)
                prmParameter(52).Value = IIf(IsNothing(oLiquidacion.codigoUsuario), "", oLiquidacion.codigoUsuario)
                prmParameter(52).Direction = ParameterDirection.Input
                prmParameter(53) = New SqlParameter("@pstatus", SqlDbType.VarChar, 100)
                prmParameter(53).Value = IIf(IsNothing(oLiquidacion.status), "", oLiquidacion.status)
                prmParameter(53).Direction = ParameterDirection.Input
                prmParameter(54) = New SqlParameter("@pcontrol", SqlDbType.VarChar, 100)
                prmParameter(54).Value = IIf(IsNothing(oLiquidacion.control), "", oLiquidacion.control)
                prmParameter(54).Direction = ParameterDirection.Input

                prmParameter(55) = New SqlParameter("@H2OFin", SqlDbType.Int)
                prmParameter(55).Value = IIf(IsNothing(oLiquidacion.H2O), 0, oLiquidacion.H2O)
                prmParameter(55).Direction = ParameterDirection.Input


                prmParameter(56) = New SqlParameter("@produccionPropia", SqlDbType.Float)
                '@01    D02
                'prmParameter(56).Value = IIf(IsNothing(oLiquidacion.Ajuste), 0, oLiquidacion.Ajuste)
                'prmParameter(56).Direction = ParameterDirection.Input
                '@01    A02
                prmParameter(56).Value = IIf(IsNothing(oLiquidacion.valorPP), 0, oLiquidacion.valorPP)
                prmParameter(56).Direction = ParameterDirection.Input

                prmParameter(57) = New SqlParameter("@costoVenta", SqlDbType.Float)
                prmParameter(57).Value = IIf(IsNothing(oLiquidacion.costoVenta), 0, oLiquidacion.costoVenta)
                prmParameter(57).Direction = ParameterDirection.Input

                '@01    A06
                prmParameter(58) = New SqlParameter("@valorPPSol", SqlDbType.Float)
                prmParameter(58).Value = IIf(IsNothing(oLiquidacion.valorPPSol), 0, oLiquidacion.valorPPSol)
                prmParameter(58).Direction = ParameterDirection.Input

                prmParameter(59) = New SqlParameter("@valorTipoCambioPP", SqlDbType.Float)
                prmParameter(59).Value = IIf(IsNothing(oLiquidacion.valorTipoCambioPP), 0, oLiquidacion.valorTipoCambioPP)
                prmParameter(59).Direction = ParameterDirection.Input



                prmParameter(60) = New SqlParameter("@periodoComercial", SqlDbType.VarChar, 6)
                prmParameter(60).Value = IIf(IsNothing(oLiquidacion.periodoComercial), "", oLiquidacion.periodoComercial)
                prmParameter(60).Direction = ParameterDirection.Input

                prmParameter(61) = New SqlParameter("@costoOperativo", SqlDbType.Float)
                prmParameter(61).Value = IIf(IsNothing(oLiquidacion.costoOperativo), 0, oLiquidacion.costoOperativo)
                prmParameter(61).Direction = ParameterDirection.Input

                prmParameter(62) = New SqlParameter("@pbaseRc", SqlDbType.Float, 4)
                prmParameter(62).Value = IIf(IsNothing(oLiquidacion.baseRc), 0, oLiquidacion.baseRc)
                prmParameter(62).Direction = ParameterDirection.Input

                prmParameter(63) = New SqlParameter("@pRcmas", SqlDbType.Float, 4)
                prmParameter(63).Value = IIf(IsNothing(oLiquidacion.RcMas), 0, oLiquidacion.RcMas)
                prmParameter(63).Direction = ParameterDirection.Input

                prmParameter(64) = New SqlParameter("@pRcmenos", SqlDbType.Float, 4)
                prmParameter(64).Value = IIf(IsNothing(oLiquidacion.RcMenos), 0, oLiquidacion.RcMenos)
                prmParameter(64).Direction = ParameterDirection.Input

                prmParameter(65) = New SqlParameter("@pRcBaseCon", SqlDbType.Float, 4)
                prmParameter(65).Value = IIf(IsNothing(oLiquidacion.RcBaseCon), 0, oLiquidacion.RcBaseCon)
                prmParameter(65).Direction = ParameterDirection.Input

                prmParameter(66) = New SqlParameter("@pContmas", SqlDbType.Float, 4)
                prmParameter(66).Value = IIf(IsNothing(oLiquidacion.ContMas), 0, oLiquidacion.ContMas)
                prmParameter(66).Direction = ParameterDirection.Input

                prmParameter(67) = New SqlParameter("@pContmenos", SqlDbType.Float, 4)
                prmParameter(67).Value = IIf(IsNothing(oLiquidacion.ContMenos), 0, oLiquidacion.ContMenos)
                prmParameter(67).Direction = ParameterDirection.Input


                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_Liquidacion_Upd", prmParameter)
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
		''' Fecha Creacion: 17/02/2011 16:40:02
        ''' Proposito: Metodo de Elimacion
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Function EliminarLiquidacion(ByVal oLstLiquidacion As List(Of clsBE_Liquidacion)) As Boolean
			For Each oLiquidacion As clsBE_Liquidacion In oLstLiquidacion
				Dim prmParameter(1) As SqlParameter
					prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar , 20)
							prmParameter(0).Value = IIf(IsNothing(oLiquidacion.contratoLoteId), "", oLiquidacion.contratoLoteId)
					prmParameter(0).Direction = ParameterDirection.Input
					prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.varchar , 20)
							prmParameter(1).Value = IIf(IsNothing(oLiquidacion.liquidacionId), "", oLiquidacion.liquidacionId)
					prmParameter(1).Direction = ParameterDirection.Input
				Try		
				    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_Liquidacion_Del", prmParameter)
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
		''' Fecha Creacion: 17/02/2011 16:40:02
        ''' Proposito: Metodo de Guardar Dataset
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Function GuardarLiquidacion(ByVal oDSLiquidacion As Dataset) As Boolean
		 Dim cnxCPO As New SqlConnection(CadenaConexion)
		 

            Try
                Dim objCommnadInsert As New SqlCommand                
				objCommnadInsert.Connection = cnxCPO
                objCommnadInsert.CommandText = "up_Liquidacion_Ins"
                objCommnadInsert.CommandType = CommandType.StoredProcedure					
			
					objCommnadInsert.Parameters.Add( "@pcontratoLoteId", SqlDbType.varchar , 20).SourceColumn = "contratoLoteId"								
					objCommnadInsert.Parameters.Add( "@pliquidacionId", SqlDbType.varchar , 20).SourceColumn = "liquidacionId"								
					objCommnadInsert.Parameters.Add( "@pbase1", SqlDbType.Float , 4).SourceColumn = "base1"								
					objCommnadInsert.Parameters.Add( "@pescaladorMas1", SqlDbType.Float , 4).SourceColumn = "escaladorMas1"								
					objCommnadInsert.Parameters.Add( "@pescaladorMenos1", SqlDbType.Float , 4).SourceColumn = "escaladorMenos1"								
					objCommnadInsert.Parameters.Add( "@pbase2", SqlDbType.Float , 4).SourceColumn = "base2"								
					objCommnadInsert.Parameters.Add( "@pescaladorMas2", SqlDbType.Float , 4).SourceColumn = "escaladorMas2"								
					objCommnadInsert.Parameters.Add( "@pescaladorMenos2", SqlDbType.Float , 4).SourceColumn = "escaladorMenos2"								
					objCommnadInsert.Parameters.Add( "@ppp", SqlDbType.Float , 4).SourceColumn = "pp"								
					objCommnadInsert.Parameters.Add( "@pbasepp", SqlDbType.Float , 4).SourceColumn = "basepp"								
					objCommnadInsert.Parameters.Add( "@pporcentajeMerma", SqlDbType.Float , 4).SourceColumn = "porcentajeMerma"								
					objCommnadInsert.Parameters.Add( "@pporcentajePago", SqlDbType.Float , 4).SourceColumn = "porcentajePago"								
					objCommnadInsert.Parameters.Add( "@pcalculoTMSN", SqlDbType.Float , 4).SourceColumn = "calculoTMSN"								
					objCommnadInsert.Parameters.Add( "@pcalculoPagable", SqlDbType.Float , 4).SourceColumn = "calculoPagable"								
					objCommnadInsert.Parameters.Add( "@pcalculoMaquila", SqlDbType.Float , 4).SourceColumn = "calculoMaquila"								
					objCommnadInsert.Parameters.Add( "@pcalculoRefinacion", SqlDbType.Float , 4).SourceColumn = "calculoRefinacion"								
					objCommnadInsert.Parameters.Add( "@pcalculoPenalizable", SqlDbType.Float , 4).SourceColumn = "calculoPenalizable"								
					objCommnadInsert.Parameters.Add( "@pcalculoServicio", SqlDbType.Float , 4).SourceColumn = "calculoServicio"								
					objCommnadInsert.Parameters.Add( "@pcalculoPrecioTMSN", SqlDbType.Float , 4).SourceColumn = "calculoPrecioTMSN"								
					objCommnadInsert.Parameters.Add( "@pcalculoCargoAjuste", SqlDbType.Float , 4).SourceColumn = "calculoCargoAjuste"								
					objCommnadInsert.Parameters.Add( "@pcalculoPrecioUnitario", SqlDbType.Float , 4).SourceColumn = "calculoPrecioUnitario"								
					objCommnadInsert.Parameters.Add( "@pvalorVenta", SqlDbType.Float , 4).SourceColumn = "valorVenta"								
					objCommnadInsert.Parameters.Add( "@pvalorIgv", SqlDbType.Float , 4).SourceColumn = "valorIgv"								
					objCommnadInsert.Parameters.Add( "@pvalorTotal", SqlDbType.Float , 4).SourceColumn = "valorTotal"								
					objCommnadInsert.Parameters.Add( "@ptotalPorPagar", SqlDbType.Float , 4).SourceColumn = "totalPorPagar"								
					objCommnadInsert.Parameters.Add( "@ptotalDscto", SqlDbType.Float , 4).SourceColumn = "totalDscto"								
					objCommnadInsert.Parameters.Add( "@ptotalNetoxPagar", SqlDbType.Float , 4).SourceColumn = "totalNetoxPagar"								
					objCommnadInsert.Parameters.Add( "@pcodigoCalculo", SqlDbType.varchar , 15).SourceColumn = "codigoCalculo"								
					objCommnadInsert.Parameters.Add( "@pperiodo", SqlDbType.varchar , 6).SourceColumn = "periodo"								
					objCommnadInsert.Parameters.Add( "@pcodigoDocumento", SqlDbType.varchar , 15).SourceColumn = "codigoDocumento"								
					objCommnadInsert.Parameters.Add( "@pfechaDocumento", SqlDbType.DateTime , 8).SourceColumn = "fechaDocumento"								
					objCommnadInsert.Parameters.Add( "@pnumeroDocumento", SqlDbType.varchar , 18).SourceColumn = "numeroDocumento"								
					objCommnadInsert.Parameters.Add( "@pcodigoEstado", SqlDbType.varchar , 15).SourceColumn = "codigoEstado"								
					objCommnadInsert.Parameters.Add( "@puc", SqlDbType.varchar , 15).SourceColumn = "uc"								
					objCommnadInsert.Parameters.Add( "@pnumeroCalculo", SqlDbType.Int , 4).SourceColumn = "numeroCalculo"								
					objCommnadInsert.Parameters.Add( "@pcalculoTmh", SqlDbType.Float , 4).SourceColumn = "calculoTmh"								
					objCommnadInsert.Parameters.Add( "@pcalculoH2o", SqlDbType.Float , 4).SourceColumn = "calculoH2o"								
					objCommnadInsert.Parameters.Add( "@pcalculoTms", SqlDbType.Float , 4).SourceColumn = "calculoTms"								
					objCommnadInsert.Parameters.Add( "@pcalculoMerma", SqlDbType.Float , 4).SourceColumn = "calculoMerma"								
					objCommnadInsert.Parameters.Add( "@pmaquila", SqlDbType.Float , 4).SourceColumn = "maquila"								
					objCommnadInsert.Parameters.Add( "@ptasaInteres", SqlDbType.Float , 4).SourceColumn = "tasaInteres"								
					objCommnadInsert.Parameters.Add( "@ptasaMoratoria", SqlDbType.Float , 4).SourceColumn = "tasaMoratoria"								
					objCommnadInsert.Parameters.Add( "@ptasaTiempo", SqlDbType.Float , 4).SourceColumn = "tasaTiempo"								
					objCommnadInsert.Parameters.Add( "@pcodigoTasa", SqlDbType.varchar , 15).SourceColumn = "codigoTasa"								
					objCommnadInsert.Parameters.Add( "@pcodigoIncoterm", SqlDbType.varchar , 15).SourceColumn = "codigoIncoterm"								
					objCommnadInsert.Parameters.Add( "@pcodigoDeposito", SqlDbType.varchar , 15).SourceColumn = "codigoDeposito"								
					objCommnadInsert.Parameters.Add( "@pcalculoPp", SqlDbType.Float , 4).SourceColumn = "calculoPp"								
					objCommnadInsert.Parameters.Add( "@pcargoAjuste", SqlDbType.Float , 4).SourceColumn = "cargoAjuste"								
					objCommnadInsert.Parameters.Add( "@pfechaRegistro", SqlDbType.DateTime , 8).SourceColumn = "fechaRegistro"								
					objCommnadInsert.Parameters.Add( "@pcodigoTrader", SqlDbType.varchar , 15).SourceColumn = "codigoTrader"								
					objCommnadInsert.Parameters.Add( "@pcodigoAdministrador", SqlDbType.varchar , 15).SourceColumn = "codigoAdministrador"								
					objCommnadInsert.Parameters.Add( "@pcodigoUsuario", SqlDbType.varchar , 15).SourceColumn = "codigoUsuario"								
					objCommnadInsert.Parameters.Add( "@pstatus", SqlDbType.varchar , 100).SourceColumn = "status"								
					objCommnadInsert.Parameters.Add( "@pcontrol", SqlDbType.varchar , 100).SourceColumn = "control"								
				
				Dim objCommandUpdate As New SqlCommand
                objCommandUpdate.Connection = cnxCPO
                objCommandUpdate.CommandText = "up_Liquidacion_Upd"
                objCommandUpdate.CommandType = CommandType.StoredProcedure
				
					objCommandUpdate.Parameters.Add( "@pcontratoLoteId", SqlDbType.varchar , 20).SourceColumn = "contratoLoteId"								
					objCommandUpdate.Parameters.Add( "@pliquidacionId", SqlDbType.varchar , 20).SourceColumn = "liquidacionId"								
					objCommandUpdate.Parameters.Add( "@pbase1", SqlDbType.Int , 8).SourceColumn = "base1"								
					objCommandUpdate.Parameters.Add( "@pescaladorMas1", SqlDbType.Float , 4).SourceColumn = "escaladorMas1"								
					objCommandUpdate.Parameters.Add( "@pescaladorMenos1", SqlDbType.Float , 4).SourceColumn = "escaladorMenos1"								
					objCommandUpdate.Parameters.Add( "@pbase2", SqlDbType.Float , 4).SourceColumn = "base2"								
					objCommandUpdate.Parameters.Add( "@pescaladorMas2", SqlDbType.Float , 4).SourceColumn = "escaladorMas2"								
					objCommandUpdate.Parameters.Add( "@pescaladorMenos2", SqlDbType.Float , 4).SourceColumn = "escaladorMenos2"								
					objCommandUpdate.Parameters.Add( "@ppp", SqlDbType.Float , 4).SourceColumn = "pp"								
					objCommandUpdate.Parameters.Add( "@pbasepp", SqlDbType.Float , 4).SourceColumn = "basepp"								
					objCommandUpdate.Parameters.Add( "@pporcentajeMerma", SqlDbType.Float , 4).SourceColumn = "porcentajeMerma"								
					objCommandUpdate.Parameters.Add( "@pporcentajePago", SqlDbType.Float , 4).SourceColumn = "porcentajePago"								
					objCommandUpdate.Parameters.Add( "@pcalculoTMSN", SqlDbType.Float , 4).SourceColumn = "calculoTMSN"								
					objCommandUpdate.Parameters.Add( "@pcalculoPagable", SqlDbType.Float , 4).SourceColumn = "calculoPagable"								
					objCommandUpdate.Parameters.Add( "@pcalculoMaquila", SqlDbType.Float , 4).SourceColumn = "calculoMaquila"								
					objCommandUpdate.Parameters.Add( "@pcalculoRefinacion", SqlDbType.Float , 4).SourceColumn = "calculoRefinacion"								
					objCommandUpdate.Parameters.Add( "@pcalculoPenalizable", SqlDbType.Float , 4).SourceColumn = "calculoPenalizable"								
					objCommandUpdate.Parameters.Add( "@pcalculoServicio", SqlDbType.Float , 4).SourceColumn = "calculoServicio"								
					objCommandUpdate.Parameters.Add( "@pcalculoPrecioTMSN", SqlDbType.Float , 4).SourceColumn = "calculoPrecioTMSN"								
					objCommandUpdate.Parameters.Add( "@pcalculoCargoAjuste", SqlDbType.Float , 4).SourceColumn = "calculoCargoAjuste"								
					objCommandUpdate.Parameters.Add( "@pcalculoPrecioUnitario", SqlDbType.Float , 4).SourceColumn = "calculoPrecioUnitario"								
					objCommandUpdate.Parameters.Add( "@pvalorVenta", SqlDbType.Float , 4).SourceColumn = "valorVenta"								
					objCommandUpdate.Parameters.Add( "@pvalorIgv", SqlDbType.Float , 4).SourceColumn = "valorIgv"								
					objCommandUpdate.Parameters.Add( "@pvalorTotal", SqlDbType.Float , 4).SourceColumn = "valorTotal"								
					objCommandUpdate.Parameters.Add( "@ptotalPorPagar", SqlDbType.Float , 4).SourceColumn = "totalPorPagar"								
					objCommandUpdate.Parameters.Add( "@ptotalDscto", SqlDbType.Float , 4).SourceColumn = "totalDscto"								
					objCommandUpdate.Parameters.Add( "@ptotalNetoxPagar", SqlDbType.Float , 4).SourceColumn = "totalNetoxPagar"								
					objCommandUpdate.Parameters.Add( "@pcodigoCalculo", SqlDbType.varchar , 15).SourceColumn = "codigoCalculo"								
					objCommandUpdate.Parameters.Add( "@pperiodo", SqlDbType.varchar , 6).SourceColumn = "periodo"								
					objCommandUpdate.Parameters.Add( "@pcodigoDocumento", SqlDbType.varchar , 15).SourceColumn = "codigoDocumento"								
					objCommandUpdate.Parameters.Add( "@pfechaDocumento", SqlDbType.DateTime , 8).SourceColumn = "fechaDocumento"								
					objCommandUpdate.Parameters.Add( "@pnumeroDocumento", SqlDbType.varchar , 18).SourceColumn = "numeroDocumento"								
					objCommandUpdate.Parameters.Add( "@pcodigoEstado", SqlDbType.varchar , 15).SourceColumn = "codigoEstado"								
					objCommandUpdate.Parameters.Add( "@pum", SqlDbType.varchar , 15).SourceColumn = "um"								
					objCommandUpdate.Parameters.Add( "@pfm", SqlDbType.DateTime , 8).SourceColumn = "fm"								
					objCommandUpdate.Parameters.Add( "@pnumeroCalculo", SqlDbType.Int , 4).SourceColumn = "numeroCalculo"								
					objCommandUpdate.Parameters.Add( "@pcalculoTmh", SqlDbType.Float , 4).SourceColumn = "calculoTmh"								
					objCommandUpdate.Parameters.Add( "@pcalculoH2o", SqlDbType.Float , 4).SourceColumn = "calculoH2o"								
					objCommandUpdate.Parameters.Add( "@pcalculoTms", SqlDbType.Float , 4).SourceColumn = "calculoTms"								
					objCommandUpdate.Parameters.Add( "@pcalculoMerma", SqlDbType.Float , 4).SourceColumn = "calculoMerma"								
					objCommandUpdate.Parameters.Add( "@pmaquila", SqlDbType.Float , 4).SourceColumn = "maquila"								
					objCommandUpdate.Parameters.Add( "@ptasaInteres", SqlDbType.Float , 4).SourceColumn = "tasaInteres"								
					objCommandUpdate.Parameters.Add( "@ptasaMoratoria", SqlDbType.Float , 4).SourceColumn = "tasaMoratoria"								
					objCommandUpdate.Parameters.Add( "@ptasaTiempo", SqlDbType.Float , 4).SourceColumn = "tasaTiempo"								
					objCommandUpdate.Parameters.Add( "@pcodigoTasa", SqlDbType.varchar , 15).SourceColumn = "codigoTasa"								
					objCommandUpdate.Parameters.Add( "@pcodigoIncoterm", SqlDbType.varchar , 15).SourceColumn = "codigoIncoterm"								
					objCommandUpdate.Parameters.Add( "@pcodigoDeposito", SqlDbType.varchar , 15).SourceColumn = "codigoDeposito"								
					objCommandUpdate.Parameters.Add( "@pcalculoPp", SqlDbType.Float , 4).SourceColumn = "calculoPp"								
					objCommandUpdate.Parameters.Add( "@pcargoAjuste", SqlDbType.Float , 4).SourceColumn = "cargoAjuste"								
					objCommandUpdate.Parameters.Add( "@pfechaRegistro", SqlDbType.DateTime , 8).SourceColumn = "fechaRegistro"								
					objCommandUpdate.Parameters.Add( "@pcodigoTrader", SqlDbType.varchar , 15).SourceColumn = "codigoTrader"								
					objCommandUpdate.Parameters.Add( "@pcodigoAdministrador", SqlDbType.varchar , 15).SourceColumn = "codigoAdministrador"								
					objCommandUpdate.Parameters.Add( "@pcodigoUsuario", SqlDbType.varchar , 15).SourceColumn = "codigoUsuario"								
					objCommandUpdate.Parameters.Add( "@pstatus", SqlDbType.varchar , 100).SourceColumn = "status"								
					objCommandUpdate.Parameters.Add( "@pcontrol", SqlDbType.varchar , 100).SourceColumn = "control"								
				
				Dim objCommandDelete As New SqlCommand
                objCommandDelete.Connection = cnxCPO
                objCommandDelete.CommandText = "up_Liquidacion_Del"
                objCommandDelete.CommandType = CommandType.StoredProcedure
				
					objCommandDelete.Parameters.Add( "@pcontratoLoteId", SqlDbType.varchar , 20).SourceColumn = "contratoLoteId"								
					objCommandDelete.Parameters.Add( "@pliquidacionId", SqlDbType.varchar , 20).SourceColumn = "liquidacionId"								
				
				'SqlHelper.UpdateDataset(objCommnadInsert, objCommandDelete, objCommandUpdate, oDSLiquidacion, "Liquidacion")

            Catch ex As Exception
                Throw ex
                Return False
            End Try
            Return True
				
        End Function




        Public Function Modificar_Liquidacion_Financiamiento(ByVal oLiquidacion As clsBE_Liquidacion) As Boolean
            'For Each oLiquidacion As clsBE_Liquidacion In oLstLiquidacion
            Dim prmParameter(2) As SqlParameter

            prmParameter(0) = New SqlParameter("@contratoLoteId", SqlDbType.VarChar, 20)
            prmParameter(0).Value = IIf(IsNothing(oLiquidacion.contratoLoteId), "", oLiquidacion.contratoLoteId)
            prmParameter(0).Direction = ParameterDirection.Input
            prmParameter(1) = New SqlParameter("@liquidacionId", SqlDbType.VarChar, 20)
            prmParameter(1).Value = IIf(IsNothing(oLiquidacion.liquidacionId), "", oLiquidacion.liquidacionId)
            prmParameter(1).Direction = ParameterDirection.Input
            prmParameter(2) = New SqlParameter("@usuario", SqlDbType.VarChar, 20)
            prmParameter(2).Value = IIf(IsNothing(oLiquidacion.uc), "", oLiquidacion.uc)
            prmParameter(2).Direction = ParameterDirection.Input

            Try
                SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_Liquidacion_Financiamiento", prmParameter)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
            'Next
            Return True
        End Function

    End Class
#End Region
    
#Region "Clase Lectura"
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:40:02
    ''' Proposito: Obtiene los valores de la tabla Liquidacion
    ''' Fecha Modificacion:
    ''' </summary>
	'''
	<Serializable()> _
    Public Class clsDB_LiquidacionRO
		Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion =System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:40:02
        ''' Proposito: Lee los datos de un registro
        ''' Fecha Modificacion:
        ''' </summary>
        ''' 
        Public Function LeerLiquidacion(ByVal pLiquidacion As clsBE_Liquidacion) As clsBE_Liquidacion
			Dim oLiquidacion As clsBE_Liquidacion = Nothing
			 Dim DSLiquidacion  As New DataSet
			Dim prmParameter(1) As SqlParameter
					prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar , 20)
							prmParameter(0).Value = IIf(IsNothing(pLiquidacion.contratoLoteId), "", pLiquidacion.contratoLoteId)
					prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.varchar , 20)
							prmParameter(1).Value = IIf(IsNothing(pLiquidacion.liquidacionId), "", pLiquidacion.liquidacionId)
			Try		
			 Using DSLiquidacion
                    DSLiquidacion = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_Liquidacion_Sel", prmParameter)
                    If Not DSLiquidacion Is Nothing Then
                        If DSLiquidacion.Tables.Count > 0 Then
							oLiquidacion = new clsBE_Liquidacion
                            If DSLiquidacion.Tables(0).Rows.Count > 0 Then
                                With DSLiquidacion.Tables(0).Rows(0)
									    oLiquidacion.contratoLoteId = .Item("contratoLoteId").tostring
									    oLiquidacion.liquidacionId = .Item("liquidacionId").tostring
									    oLiquidacion.base1 = .Item("base1").tostring
									    oLiquidacion.escaladorMas1 = .Item("escaladorMas1").tostring
									    oLiquidacion.escaladorMenos1 = .Item("escaladorMenos1").tostring
									    oLiquidacion.base2 = .Item("base2").tostring
									    oLiquidacion.escaladorMas2 = .Item("escaladorMas2").tostring
									    oLiquidacion.escaladorMenos2 = .Item("escaladorMenos2").tostring
									    oLiquidacion.pp = .Item("pp").tostring
									    oLiquidacion.basepp = .Item("basepp").tostring
									    oLiquidacion.porcentajeMerma = .Item("porcentajeMerma").tostring
									    oLiquidacion.porcentajePago = .Item("porcentajePago").tostring
									    oLiquidacion.calculoTMSN = .Item("calculoTMSN").tostring
									    oLiquidacion.calculoPagable = .Item("calculoPagable").tostring
									    oLiquidacion.calculoMaquila = .Item("calculoMaquila").tostring
									    oLiquidacion.calculoRefinacion = .Item("calculoRefinacion").tostring
									    oLiquidacion.calculoPenalizable = .Item("calculoPenalizable").tostring
									    oLiquidacion.calculoServicio = .Item("calculoServicio").tostring
									    oLiquidacion.calculoPrecioTMSN = .Item("calculoPrecioTMSN").tostring
									    oLiquidacion.calculoCargoAjuste = .Item("calculoCargoAjuste").tostring
									    oLiquidacion.calculoPrecioUnitario = .Item("calculoPrecioUnitario").tostring
									    oLiquidacion.valorVenta = .Item("valorVenta").tostring
									    oLiquidacion.valorIgv = .Item("valorIgv").tostring
									    oLiquidacion.valorTotal = .Item("valorTotal").tostring
									    oLiquidacion.totalPorPagar = .Item("totalPorPagar").tostring
									    oLiquidacion.totalDscto = .Item("totalDscto").tostring
									    oLiquidacion.totalNetoxPagar = .Item("totalNetoxPagar").tostring
									    oLiquidacion.codigoCalculo = .Item("codigoCalculo").tostring
									    oLiquidacion.periodo = .Item("periodo").tostring
									    oLiquidacion.codigoDocumento = .Item("codigoDocumento").tostring
									    oLiquidacion.fechaDocumento = .Item("fechaDocumento").tostring
									    oLiquidacion.numeroDocumento = .Item("numeroDocumento").tostring
									    oLiquidacion.codigoEstado = .Item("codigoEstado").tostring
									    oLiquidacion.uc = .Item("uc").tostring
									    oLiquidacion.fc = .Item("fc").tostring
									    oLiquidacion.numeroCalculo = .Item("numeroCalculo").tostring
									    oLiquidacion.calculoTmh = .Item("calculoTmh").tostring
									    oLiquidacion.calculoH2o = .Item("calculoH2o").tostring
									    oLiquidacion.calculoTms = .Item("calculoTms").tostring
									    oLiquidacion.calculoMerma = .Item("calculoMerma").tostring
									    oLiquidacion.maquila = .Item("maquila").tostring
									    oLiquidacion.tasaInteres = .Item("tasaInteres").tostring
									    oLiquidacion.tasaMoratoria = .Item("tasaMoratoria").tostring
									    oLiquidacion.tasaTiempo = .Item("tasaTiempo").tostring
									    oLiquidacion.codigoTasa = .Item("codigoTasa").tostring
									    oLiquidacion.codigoIncoterm = .Item("codigoIncoterm").tostring
									    oLiquidacion.codigoDeposito = .Item("codigoDeposito").tostring
									    oLiquidacion.calculoPp = .Item("calculoPp").tostring
									    oLiquidacion.cargoAjuste = .Item("cargoAjuste").tostring
									    oLiquidacion.fechaRegistro = .Item("fechaRegistro").tostring
									    oLiquidacion.codigoTrader = .Item("codigoTrader").tostring
									    oLiquidacion.codigoAdministrador = .Item("codigoAdministrador").tostring
									    oLiquidacion.codigoUsuario = .Item("codigoUsuario").tostring
									    oLiquidacion.status = .Item("status").tostring
                                    oLiquidacion.control = .Item("control").ToString

                                    oLiquidacion.H2O = .Item("H2OFin").ToString
                                    oLiquidacion.Ajuste = .Item("ajuste").ToString

                                    oLiquidacion.costoVenta = .Item("costoVenta").ToString

                                    oLiquidacion.ValorNeto = .Item("ValorNeto").ToString

                                    '@01    A03
                                    oLiquidacion.valorPP = CDbl(.Item("valorPP"))
                                    oLiquidacion.valorPPSol = CDbl(.Item("valorPPSol"))
                                    oLiquidacion.valorTipoCambioPP = CDbl(.Item("valorTipoCambioPP"))


                                    oLiquidacion.periodoComercial = .Item("periodoComercial").ToString
                                    oLiquidacion.costoOperativo = CDbl(.Item("costoOperativo"))
                                    oLiquidacion.baseRc = CDbl(.Item("baseRc"))
                                    oLiquidacion.RcMas = CDbl(.Item("Rcmas"))
                                    oLiquidacion.RcMenos = CDbl(.Item("Rcmenos"))
                                    oLiquidacion.RcBaseCon = CDbl(.Item("Rcbasecon"))
                                    oLiquidacion.ContMas = CDbl(.Item("Contmas"))
                                    oLiquidacion.ContMenos = CDbl(.Item("Contmenos"))


                                End With
							End If
						End If
					End If
                End Using	
			Catch exSql As SqlException
			
            Catch ex As Exception
				Throw ex	
			Finally
                If Not DSLiquidacion Is Nothing Then
                    DSLiquidacion.Dispose()
                End If
                DSLiquidacion = Nothing
            End Try
		
		    Return oLiquidacion		
        
        End Function


        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:40:02
        ''' Proposito: Obtiene la lista de registros
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaLiquidacion() As List(Of clsBE_Liquidacion)
			Dim olstLiquidacion As New List(Of clsBE_Liquidacion)
            Dim oLiquidacion As clsBE_Liquidacion = Nothing
            Dim mintItem As Integer = 0
			Try	
				Using Reader As SqlDataReader = SqlHelper.ExecuteReader(CadenaConexion, CommandType.StoredProcedure, "up_Liquidacion_Sellst")
                    If Reader.HasRows Then
                        While reader.Read
                            oLiquidacion = New clsBE_Liquidacion
                            mintItem += 1
                            With oLiquidacion
                                .Item = mintItem
								
										.contratoLoteId = Reader("contratoLoteId").tostring
										.liquidacionId = Reader("liquidacionId").tostring
										.base1 = Reader("base1").tostring
										.escaladorMas1 = Reader("escaladorMas1").tostring
										.escaladorMenos1 = Reader("escaladorMenos1").tostring
										.base2 = Reader("base2").tostring
										.escaladorMas2 = Reader("escaladorMas2").tostring
										.escaladorMenos2 = Reader("escaladorMenos2").tostring
										.pp = Reader("pp").tostring
										.basepp = Reader("basepp").tostring
										.porcentajeMerma = Reader("porcentajeMerma").tostring
										.porcentajePago = Reader("porcentajePago").tostring
										.calculoTMSN = Reader("calculoTMSN").tostring
										.calculoPagable = Reader("calculoPagable").tostring
										.calculoMaquila = Reader("calculoMaquila").tostring
										.calculoRefinacion = Reader("calculoRefinacion").tostring
										.calculoPenalizable = Reader("calculoPenalizable").tostring
										.calculoServicio = Reader("calculoServicio").tostring
										.calculoPrecioTMSN = Reader("calculoPrecioTMSN").tostring
										.calculoCargoAjuste = Reader("calculoCargoAjuste").tostring
										.calculoPrecioUnitario = Reader("calculoPrecioUnitario").tostring
										.valorVenta = Reader("valorVenta").tostring
										.valorIgv = Reader("valorIgv").tostring
										.valorTotal = Reader("valorTotal").tostring
										.totalPorPagar = Reader("totalPorPagar").tostring
										.totalDscto = Reader("totalDscto").tostring
										.totalNetoxPagar = Reader("totalNetoxPagar").tostring
										.codigoCalculo = Reader("codigoCalculo").tostring
										.periodo = Reader("periodo").tostring
										.codigoDocumento = Reader("codigoDocumento").tostring
										.fechaDocumento = Reader("fechaDocumento").tostring
										.numeroDocumento = Reader("numeroDocumento").tostring
										.codigoEstado = Reader("codigoEstado").tostring
										.uc = Reader("uc").tostring
										.fc = Reader("fc").tostring
										.um = Reader("um").tostring
										.fm = Reader("fm").tostring
										.numeroCalculo = Reader("numeroCalculo").tostring
										.calculoTmh = Reader("calculoTmh").tostring
										.calculoH2o = Reader("calculoH2o").tostring
										.calculoTms = Reader("calculoTms").tostring
										.calculoMerma = Reader("calculoMerma").tostring
										.maquila = Reader("maquila").tostring
										.tasaInteres = Reader("tasaInteres").tostring
										.tasaMoratoria = Reader("tasaMoratoria").tostring
										.tasaTiempo = Reader("tasaTiempo").tostring
										.codigoTasa = Reader("codigoTasa").tostring
										.codigoIncoterm = Reader("codigoIncoterm").tostring
										.codigoDeposito = Reader("codigoDeposito").tostring
										.calculoPp = Reader("calculoPp").tostring
										.cargoAjuste = Reader("cargoAjuste").tostring
										.fechaRegistro = Reader("fechaRegistro").tostring
										.codigoTrader = Reader("codigoTrader").tostring
										.codigoAdministrador = Reader("codigoAdministrador").tostring
										.codigoUsuario = Reader("codigoUsuario").tostring
										.status = Reader("status").tostring
										.control = Reader("control").tostring
							End With
                            olstLiquidacion.Add(oLiquidacion)
                        End While
                    End If
                End Using
			Catch ex As Exception
				Throw ex				                
            End Try
			
            Return olstLiquidacion
			
        End Function
		
		''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:40:02
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
		Public Function LeerListaToDSLiquidacion(ByVal pLiquidacion As clsBE_Liquidacion) As Dataset
			Dim oDSLiquidacion As New DataSet				
			Dim mintItem As Integer = 0
            Dim prmParameter(0) As SqlParameter
            prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.VarChar, 20)
            prmParameter(0).Value = IIf(IsNothing(pLiquidacion.contratoLoteId), "", pLiquidacion.contratoLoteId)

			Try	
								
				Using oDSLiquidacion					
					oDSLiquidacion = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_Liquidacion_Sellst", prmParameter)
					'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_Liquidacion_Sellst", oDSLiquidacion, New String() {"Liquidacion"}, prmParameter)
					If Not oDSLiquidacion Is Nothing Then
						If oDSLiquidacion.Tables.Count > 0 Then
							'If oDSLiquidacion.Tables("Liquidacion").Rows.Count > 0 Then
							If oDSLiquidacion.Tables(0).Rows.Count > 0 Then
								Return oDSLiquidacion
							End If
                        End If
                    End If
                End Using
			Catch ex As Exception
                Throw ex

            End Try
            Return oDSLiquidacion					
			
        End Function


        Public Function LeerListaToDSLiquidacion_Documento(ByVal pLiquidacion As clsBE_Liquidacion) As DataSet
            Dim oDSLiquidacion As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(0) As SqlParameter
            prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.VarChar, 20)
            prmParameter(0).Value = IIf(IsNothing(pLiquidacion.contratoLoteId), "", pLiquidacion.contratoLoteId)

            Try

                Using oDSLiquidacion
                    oDSLiquidacion = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_Liquidacion_Documento", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_Liquidacion_Sellst", oDSLiquidacion, New String() {"Liquidacion"}, prmParameter)
                    If Not oDSLiquidacion Is Nothing Then
                        If oDSLiquidacion.Tables.Count > 0 Then
                            'If oDSLiquidacion.Tables("Liquidacion").Rows.Count > 0 Then
                            If oDSLiquidacion.Tables(0).Rows.Count > 0 Then
                                Return oDSLiquidacion
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSLiquidacion

        End Function
		
		
		''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:40:02
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
		public  function DefinirTablaLiquidacion() As DataTable
			
		Try
			Dim DTLiquidacion As New DataTable
			
			Dim contratoLoteId As DataColumn = DTLiquidacion.Columns.Add("contratoLoteId", GetType(String))
						contratoLoteId.MaxLength = 20
					contratoLoteId.AllowDBNull = False
					contratoLoteId.DefaultValue = ""
			
			Dim liquidacionId As DataColumn = DTLiquidacion.Columns.Add("liquidacionId", GetType(String))
						liquidacionId.MaxLength = 20
					liquidacionId.AllowDBNull = False
					liquidacionId.DefaultValue = ""
			
			Dim base1 As DataColumn = DTLiquidacion.Columns.Add("base1", GetType(Integer))
        	base1.AllowDBNull = True
		    base1.DefaultValue =  0

			
			Dim escaladorMas1 As DataColumn = DTLiquidacion.Columns.Add("escaladorMas1", GetType(Integer))
        	escaladorMas1.AllowDBNull = True
		    escaladorMas1.DefaultValue =  0

			
			Dim escaladorMenos1 As DataColumn = DTLiquidacion.Columns.Add("escaladorMenos1", GetType(Integer))
        	escaladorMenos1.AllowDBNull = True
		    escaladorMenos1.DefaultValue =  0

			
			Dim base2 As DataColumn = DTLiquidacion.Columns.Add("base2", GetType(Integer))
        	base2.AllowDBNull = True
		    base2.DefaultValue =  0

			
			Dim escaladorMas2 As DataColumn = DTLiquidacion.Columns.Add("escaladorMas2", GetType(Integer))
        	escaladorMas2.AllowDBNull = True
		    escaladorMas2.DefaultValue =  0

			
			Dim escaladorMenos2 As DataColumn = DTLiquidacion.Columns.Add("escaladorMenos2", GetType(Integer))
        	escaladorMenos2.AllowDBNull = True
		    escaladorMenos2.DefaultValue =  0

			
			Dim pp As DataColumn = DTLiquidacion.Columns.Add("pp", GetType(Integer))
        	pp.AllowDBNull = True
		    pp.DefaultValue =  0

			
			Dim basepp As DataColumn = DTLiquidacion.Columns.Add("basepp", GetType(Integer))
        	basepp.AllowDBNull = True
		    basepp.DefaultValue =  0

			
			Dim porcentajeMerma As DataColumn = DTLiquidacion.Columns.Add("porcentajeMerma", GetType(Integer))
        	porcentajeMerma.AllowDBNull = True
		    porcentajeMerma.DefaultValue =  0

			
			Dim porcentajePago As DataColumn = DTLiquidacion.Columns.Add("porcentajePago", GetType(Integer))
        	porcentajePago.AllowDBNull = True
		    porcentajePago.DefaultValue =  0

			
			Dim calculoTMSN As DataColumn = DTLiquidacion.Columns.Add("calculoTMSN", GetType(Integer))
        	calculoTMSN.AllowDBNull = True
		    calculoTMSN.DefaultValue =  0

			
			Dim calculoPagable As DataColumn = DTLiquidacion.Columns.Add("calculoPagable", GetType(Integer))
        	calculoPagable.AllowDBNull = True
		    calculoPagable.DefaultValue =  0

			
			Dim calculoMaquila As DataColumn = DTLiquidacion.Columns.Add("calculoMaquila", GetType(Integer))
        	calculoMaquila.AllowDBNull = True
		    calculoMaquila.DefaultValue =  0

			
			Dim calculoRefinacion As DataColumn = DTLiquidacion.Columns.Add("calculoRefinacion", GetType(Integer))
        	calculoRefinacion.AllowDBNull = True
		    calculoRefinacion.DefaultValue =  0

			
			Dim calculoPenalizable As DataColumn = DTLiquidacion.Columns.Add("calculoPenalizable", GetType(Integer))
        	calculoPenalizable.AllowDBNull = True
		    calculoPenalizable.DefaultValue =  0

			
			Dim calculoServicio As DataColumn = DTLiquidacion.Columns.Add("calculoServicio", GetType(Integer))
        	calculoServicio.AllowDBNull = True
		    calculoServicio.DefaultValue =  0

			
			Dim calculoPrecioTMSN As DataColumn = DTLiquidacion.Columns.Add("calculoPrecioTMSN", GetType(Integer))
        	calculoPrecioTMSN.AllowDBNull = True
		    calculoPrecioTMSN.DefaultValue =  0

			
			Dim calculoCargoAjuste As DataColumn = DTLiquidacion.Columns.Add("calculoCargoAjuste", GetType(Integer))
        	calculoCargoAjuste.AllowDBNull = True
		    calculoCargoAjuste.DefaultValue =  0

			
			Dim calculoPrecioUnitario As DataColumn = DTLiquidacion.Columns.Add("calculoPrecioUnitario", GetType(Integer))
        	calculoPrecioUnitario.AllowDBNull = True
		    calculoPrecioUnitario.DefaultValue =  0

			
			Dim valorVenta As DataColumn = DTLiquidacion.Columns.Add("valorVenta", GetType(Integer))
        	valorVenta.AllowDBNull = True
		    valorVenta.DefaultValue =  0

			
			Dim valorIgv As DataColumn = DTLiquidacion.Columns.Add("valorIgv", GetType(Integer))
        	valorIgv.AllowDBNull = True
		    valorIgv.DefaultValue =  0

			
			Dim valorTotal As DataColumn = DTLiquidacion.Columns.Add("valorTotal", GetType(Integer))
        	valorTotal.AllowDBNull = True
		    valorTotal.DefaultValue =  0

			
			Dim totalPorPagar As DataColumn = DTLiquidacion.Columns.Add("totalPorPagar", GetType(Integer))
        	totalPorPagar.AllowDBNull = True
		    totalPorPagar.DefaultValue =  0

			
			Dim totalDscto As DataColumn = DTLiquidacion.Columns.Add("totalDscto", GetType(Integer))
        	totalDscto.AllowDBNull = True
		    totalDscto.DefaultValue =  0

			
			Dim totalNetoxPagar As DataColumn = DTLiquidacion.Columns.Add("totalNetoxPagar", GetType(Integer))
        	totalNetoxPagar.AllowDBNull = True
		    totalNetoxPagar.DefaultValue =  0

			
			Dim codigoCalculo As DataColumn = DTLiquidacion.Columns.Add("codigoCalculo", GetType(String))
						codigoCalculo.MaxLength = 15
					codigoCalculo.AllowDBNull = True
					codigoCalculo.DefaultValue = ""
			
			Dim periodo As DataColumn = DTLiquidacion.Columns.Add("periodo", GetType(String))
						periodo.MaxLength = 6
					periodo.AllowDBNull = True
					periodo.DefaultValue = ""
			
			Dim codigoDocumento As DataColumn = DTLiquidacion.Columns.Add("codigoDocumento", GetType(String))
						codigoDocumento.MaxLength = 15
					codigoDocumento.AllowDBNull = True
					codigoDocumento.DefaultValue = ""
			
			Dim fechaDocumento As DataColumn = DTLiquidacion.Columns.Add("fechaDocumento", GetType(DateTime))

			
			Dim numeroDocumento As DataColumn = DTLiquidacion.Columns.Add("numeroDocumento", GetType(String))
						numeroDocumento.MaxLength = 18
					numeroDocumento.AllowDBNull = True
					numeroDocumento.DefaultValue = ""
			
			Dim codigoEstado As DataColumn = DTLiquidacion.Columns.Add("codigoEstado", GetType(String))
						codigoEstado.MaxLength = 15
					codigoEstado.AllowDBNull = True
					codigoEstado.DefaultValue = ""
			
			Dim uc As DataColumn = DTLiquidacion.Columns.Add("uc", GetType(String))
						uc.MaxLength = 15
					uc.AllowDBNull = True
					uc.DefaultValue = ""
			
			Dim fc As DataColumn = DTLiquidacion.Columns.Add("fc", GetType(DateTime))

			
			Dim um As DataColumn = DTLiquidacion.Columns.Add("um", GetType(String))
						um.MaxLength = 15
					um.AllowDBNull = True
					um.DefaultValue = ""
			
			Dim fm As DataColumn = DTLiquidacion.Columns.Add("fm", GetType(DateTime))

			
			Dim numeroCalculo As DataColumn = DTLiquidacion.Columns.Add("numeroCalculo", GetType(Integer))
        	numeroCalculo.AllowDBNull = True
		    numeroCalculo.DefaultValue =  0

			
			Dim calculoTmh As DataColumn = DTLiquidacion.Columns.Add("calculoTmh", GetType(Integer))
        	calculoTmh.AllowDBNull = True
		    calculoTmh.DefaultValue =  0

			
			Dim calculoH2o As DataColumn = DTLiquidacion.Columns.Add("calculoH2o", GetType(Integer))
        	calculoH2o.AllowDBNull = True
		    calculoH2o.DefaultValue =  0

			
			Dim calculoTms As DataColumn = DTLiquidacion.Columns.Add("calculoTms", GetType(Integer))
        	calculoTms.AllowDBNull = True
		    calculoTms.DefaultValue =  0

			
			Dim calculoMerma As DataColumn = DTLiquidacion.Columns.Add("calculoMerma", GetType(Integer))
        	calculoMerma.AllowDBNull = True
		    calculoMerma.DefaultValue =  0

			
			Dim maquila As DataColumn = DTLiquidacion.Columns.Add("maquila", GetType(Integer))
        	maquila.AllowDBNull = True
		    maquila.DefaultValue =  0

			
			Dim tasaInteres As DataColumn = DTLiquidacion.Columns.Add("tasaInteres", GetType(Integer))
        	tasaInteres.AllowDBNull = True
		    tasaInteres.DefaultValue =  0

			
			Dim tasaMoratoria As DataColumn = DTLiquidacion.Columns.Add("tasaMoratoria", GetType(Integer))
        	tasaMoratoria.AllowDBNull = True
		    tasaMoratoria.DefaultValue =  0

			
			Dim tasaTiempo As DataColumn = DTLiquidacion.Columns.Add("tasaTiempo", GetType(Integer))
        	tasaTiempo.AllowDBNull = True
		    tasaTiempo.DefaultValue =  0

			
			Dim codigoTasa As DataColumn = DTLiquidacion.Columns.Add("codigoTasa", GetType(String))
						codigoTasa.MaxLength = 15
					codigoTasa.AllowDBNull = True
					codigoTasa.DefaultValue = ""
			
			Dim codigoIncoterm As DataColumn = DTLiquidacion.Columns.Add("codigoIncoterm", GetType(String))
						codigoIncoterm.MaxLength = 15
					codigoIncoterm.AllowDBNull = True
					codigoIncoterm.DefaultValue = ""
			
			Dim codigoDeposito As DataColumn = DTLiquidacion.Columns.Add("codigoDeposito", GetType(String))
						codigoDeposito.MaxLength = 15
					codigoDeposito.AllowDBNull = True
					codigoDeposito.DefaultValue = ""
			
			Dim calculoPp As DataColumn = DTLiquidacion.Columns.Add("calculoPp", GetType(Integer))
        	calculoPp.AllowDBNull = True
		    calculoPp.DefaultValue =  0

			
			Dim cargoAjuste As DataColumn = DTLiquidacion.Columns.Add("cargoAjuste", GetType(Integer))
        	cargoAjuste.AllowDBNull = True
		    cargoAjuste.DefaultValue =  0

			
			Dim fechaRegistro As DataColumn = DTLiquidacion.Columns.Add("fechaRegistro", GetType(DateTime))

			
			Dim codigoTrader As DataColumn = DTLiquidacion.Columns.Add("codigoTrader", GetType(String))
						codigoTrader.MaxLength = 15
					codigoTrader.AllowDBNull = True
					codigoTrader.DefaultValue = ""
			
			Dim codigoAdministrador As DataColumn = DTLiquidacion.Columns.Add("codigoAdministrador", GetType(String))
						codigoAdministrador.MaxLength = 15
					codigoAdministrador.AllowDBNull = True
					codigoAdministrador.DefaultValue = ""
			
			Dim codigoUsuario As DataColumn = DTLiquidacion.Columns.Add("codigoUsuario", GetType(String))
						codigoUsuario.MaxLength = 15
					codigoUsuario.AllowDBNull = True
					codigoUsuario.DefaultValue = ""
			
			Dim status As DataColumn = DTLiquidacion.Columns.Add("status", GetType(String))
						status.MaxLength = 100
					status.AllowDBNull = True
					status.DefaultValue = ""
			
			Dim control As DataColumn = DTLiquidacion.Columns.Add("control", GetType(String))
						control.MaxLength = 100
					control.AllowDBNull = True
					control.DefaultValue = ""
			
		Return DTLiquidacion
        Catch ex As Exception
            Throw ex
        End Try
		End Function	









        Public Function LeerLiquidacuibToDSFactura(ByVal pLiquidacion As clsBE_Liquidacion) As DataSet
            Dim oDSLiquidacion As New DataSet
            Dim mintItem As Integer = 0

            Dim prmParameter(1) As SqlParameter
            prmParameter(0) = New SqlParameter("@contratoLoteId", SqlDbType.VarChar, 20)
            prmParameter(0).Value = IIf(IsNothing(pLiquidacion.contratoLoteId), "", pLiquidacion.contratoLoteId)
            prmParameter(1) = New SqlParameter("@liquidacionId", SqlDbType.VarChar, 20)
            prmParameter(1).Value = IIf(IsNothing(pLiquidacion.liquidacionId), "", pLiquidacion.liquidacionId)

            Try

                Using oDSLiquidacion
                    oDSLiquidacion = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_tbLotesValorizados_factura ", prmParameter)
                    If Not oDSLiquidacion Is Nothing Then
                        If oDSLiquidacion.Tables.Count > 0 Then
                            If oDSLiquidacion.Tables(0).Rows.Count > 0 Then
                                Return oDSLiquidacion
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSLiquidacion

        End Function






    End Class
#End Region
    
End Namespace
