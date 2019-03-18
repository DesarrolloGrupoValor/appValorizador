'Modified:
'@01 20141009 BAL01 ValidacionCTB

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
    ''' Fecha Creacion: 21/04/2011 08:27:56 a.m.
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla TablaDet
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsDB_TablaDetTX

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 21/04/2011 08:27:56 a.m.
        ''' Proposito: Metodo de Insercci?n de Datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function InsertarTablaDet(ByVal oLstTablaDet As List(Of clsBE_TablaDet)) As Boolean
            For Each oTablaDet As clsBE_TablaDet In oLstTablaDet
                Dim prmParameter(57) As SqlParameter

                Dim MinMax As Integer() = MinMaxTabla(oTablaDet.tablaId)
                MinMax(1) += 1


                prmParameter(0) = New SqlParameter("@ptablaId", SqlDbType.varchar, 20)
                prmParameter(0).Value = IIf(IsNothing(oTablaDet.tablaId), "", oTablaDet.tablaId)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@ptablaDetId", SqlDbType.varchar, 15)
                ''prmParameter(1).Value = IIf(IsNothing(oTablaDet.tablaDetId), "", oTablaDet.tablaDetId)
                prmParameter(1).Value = MinMax(1).ToString.PadLeft(10, "0"c)

                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pdescri", SqlDbType.varchar, 100)
                prmParameter(2).Value = IIf(IsNothing(oTablaDet.descri), "", oTablaDet.descri)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@pcampo0", SqlDbType.VarChar, 200)
                prmParameter(3).Value = IIf(IsNothing(oTablaDet.campo0), "", oTablaDet.campo0)
                prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@pcampo1", SqlDbType.VarChar, 200)
                prmParameter(4).Value = IIf(IsNothing(oTablaDet.campo1), "", oTablaDet.campo1)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@pcampo2", SqlDbType.VarChar, 200)
                prmParameter(5).Value = IIf(IsNothing(oTablaDet.campo2), "", oTablaDet.campo2)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@pcampo3", SqlDbType.VarChar, 200)
                prmParameter(6).Value = IIf(IsNothing(oTablaDet.campo3), "", oTablaDet.campo3)
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7) = New SqlParameter("@pcampo4", SqlDbType.VarChar, 200)
                prmParameter(7).Value = IIf(IsNothing(oTablaDet.campo4), "", oTablaDet.campo4)
                prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(8) = New SqlParameter("@pcampo5", SqlDbType.VarChar, 200)
                prmParameter(8).Value = IIf(IsNothing(oTablaDet.campo5), "", oTablaDet.campo5)
                prmParameter(8).Direction = ParameterDirection.Input
                prmParameter(9) = New SqlParameter("@pcampo6", SqlDbType.VarChar, 200)
                prmParameter(9).Value = IIf(IsNothing(oTablaDet.campo6), "", oTablaDet.campo6)
                prmParameter(9).Direction = ParameterDirection.Input
                prmParameter(10) = New SqlParameter("@pcampo7", SqlDbType.VarChar, 200)
                prmParameter(10).Value = IIf(IsNothing(oTablaDet.campo7), "", oTablaDet.campo7)
                prmParameter(10).Direction = ParameterDirection.Input
                prmParameter(11) = New SqlParameter("@pcampo8", SqlDbType.VarChar, 200)
                prmParameter(11).Value = IIf(IsNothing(oTablaDet.campo8), "", oTablaDet.campo8)
                prmParameter(11).Direction = ParameterDirection.Input
                prmParameter(12) = New SqlParameter("@pcampo9", SqlDbType.VarChar, 200)
                prmParameter(12).Value = IIf(IsNothing(oTablaDet.campo9), "", oTablaDet.campo9)
                prmParameter(12).Direction = ParameterDirection.Input
                prmParameter(13) = New SqlParameter("@pcodigoEstado", SqlDbType.varchar, 15)
                prmParameter(13).Value = IIf(IsNothing(oTablaDet.codigoEstado), "", oTablaDet.codigoEstado)
                prmParameter(13).Direction = ParameterDirection.Input
                prmParameter(14) = New SqlParameter("@puc", SqlDbType.varchar, 15)
                prmParameter(14).Value = IIf(IsNothing(oTablaDet.uc), "", oTablaDet.uc)
                prmParameter(14).Direction = ParameterDirection.Input
                prmParameter(15) = New SqlParameter("@pcodigoVisible", SqlDbType.varchar, 15)
                prmParameter(15).Value = IIf(IsNothing(oTablaDet.codigoVisible), "", oTablaDet.codigoVisible)
                prmParameter(15).Direction = ParameterDirection.Input
                prmParameter(16) = New SqlParameter("@pcampo10", SqlDbType.VarChar, 200)
                prmParameter(16).Value = IIf(IsNothing(oTablaDet.campo10), "", oTablaDet.campo10)
                prmParameter(16).Direction = ParameterDirection.Input
                prmParameter(17) = New SqlParameter("@pcampo11", SqlDbType.VarChar, 200)
                prmParameter(17).Value = IIf(IsNothing(oTablaDet.campo11), "", oTablaDet.campo11)
                prmParameter(17).Direction = ParameterDirection.Input
                prmParameter(18) = New SqlParameter("@pcampo12", SqlDbType.VarChar, 200)
                prmParameter(18).Value = IIf(IsNothing(oTablaDet.campo12), "", oTablaDet.campo12)
                prmParameter(18).Direction = ParameterDirection.Input
                prmParameter(19) = New SqlParameter("@pcampo13", SqlDbType.VarChar, 200)
                prmParameter(19).Value = IIf(IsNothing(oTablaDet.campo13), "", oTablaDet.campo13)
                prmParameter(19).Direction = ParameterDirection.Input
                prmParameter(20) = New SqlParameter("@pcampo14", SqlDbType.VarChar, 200)
                prmParameter(20).Value = IIf(IsNothing(oTablaDet.campo14), "", oTablaDet.campo14)
                prmParameter(20).Direction = ParameterDirection.Input
                prmParameter(21) = New SqlParameter("@pcampo15", SqlDbType.VarChar, 200)
                prmParameter(21).Value = IIf(IsNothing(oTablaDet.campo15), "", oTablaDet.campo15)
                prmParameter(21).Direction = ParameterDirection.Input
                prmParameter(22) = New SqlParameter("@pcampo16", SqlDbType.VarChar, 200)
                prmParameter(22).Value = IIf(IsNothing(oTablaDet.campo16), "", oTablaDet.campo16)
                prmParameter(22).Direction = ParameterDirection.Input
                prmParameter(23) = New SqlParameter("@pcampo17", SqlDbType.VarChar, 200)
                prmParameter(23).Value = IIf(IsNothing(oTablaDet.campo17), "", oTablaDet.campo17)
                prmParameter(23).Direction = ParameterDirection.Input
                prmParameter(24) = New SqlParameter("@pcampo18", SqlDbType.VarChar, 200)
                prmParameter(24).Value = IIf(IsNothing(oTablaDet.campo18), "", oTablaDet.campo18)
                prmParameter(24).Direction = ParameterDirection.Input
                prmParameter(25) = New SqlParameter("@pcampo19", SqlDbType.VarChar, 200)
                prmParameter(25).Value = IIf(IsNothing(oTablaDet.campo19), "", oTablaDet.campo19)
                prmParameter(25).Direction = ParameterDirection.Input
                prmParameter(26) = New SqlParameter("@pcampo20", SqlDbType.VarChar, 200)
                prmParameter(26).Value = IIf(IsNothing(oTablaDet.campo20), "", oTablaDet.campo20)
                prmParameter(26).Direction = ParameterDirection.Input
                prmParameter(27) = New SqlParameter("@pcampo21", SqlDbType.VarChar, 200)
                prmParameter(27).Value = IIf(IsNothing(oTablaDet.campo21), "", oTablaDet.campo21)
                prmParameter(27).Direction = ParameterDirection.Input

                prmParameter(28) = New SqlParameter("@pcampo22", SqlDbType.VarChar, 200)
                prmParameter(28).Value = IIf(IsNothing(oTablaDet.campo22), "", oTablaDet.campo22)
                prmParameter(28).Direction = ParameterDirection.Input
                prmParameter(29) = New SqlParameter("@pcampo23", SqlDbType.VarChar, 200)
                prmParameter(29).Value = IIf(IsNothing(oTablaDet.campo23), "", oTablaDet.campo23)
                prmParameter(29).Direction = ParameterDirection.Input
                prmParameter(30) = New SqlParameter("@pcampo24", SqlDbType.VarChar, 200)
                prmParameter(30).Value = IIf(IsNothing(oTablaDet.campo24), "", oTablaDet.campo24)
                prmParameter(30).Direction = ParameterDirection.Input
                prmParameter(31) = New SqlParameter("@pcampo25", SqlDbType.VarChar, 200)
                prmParameter(31).Value = IIf(IsNothing(oTablaDet.campo25), "", oTablaDet.campo25)
                prmParameter(31).Direction = ParameterDirection.Input
                prmParameter(32) = New SqlParameter("@pcampo26", SqlDbType.VarChar, 200)
                prmParameter(32).Value = IIf(IsNothing(oTablaDet.campo26), "", oTablaDet.campo26)
                prmParameter(32).Direction = ParameterDirection.Input
                prmParameter(33) = New SqlParameter("@pcampo27", SqlDbType.VarChar, 200)
                prmParameter(33).Value = IIf(IsNothing(oTablaDet.campo27), "", oTablaDet.campo27)
                prmParameter(33).Direction = ParameterDirection.Input

                prmParameter(34) = New SqlParameter("@pcampo28", SqlDbType.VarChar, 200)
                prmParameter(34).Value = IIf(IsNothing(oTablaDet.campo28), "", oTablaDet.campo28)
                prmParameter(34).Direction = ParameterDirection.Input
                prmParameter(35) = New SqlParameter("@pcampo29", SqlDbType.VarChar, 200)
                prmParameter(35).Value = IIf(IsNothing(oTablaDet.campo29), "", oTablaDet.campo29)
                prmParameter(35).Direction = ParameterDirection.Input
                prmParameter(36) = New SqlParameter("@pcampo30", SqlDbType.VarChar, 200)
                prmParameter(36).Value = IIf(IsNothing(oTablaDet.campo30), "", oTablaDet.campo30)
                prmParameter(36).Direction = ParameterDirection.Input
                prmParameter(37) = New SqlParameter("@pcampo31", SqlDbType.VarChar, 200)
                prmParameter(37).Value = IIf(IsNothing(oTablaDet.campo31), "", oTablaDet.campo31)
                prmParameter(37).Direction = ParameterDirection.Input
                prmParameter(38) = New SqlParameter("@pcampo32", SqlDbType.VarChar, 200)
                prmParameter(38).Value = IIf(IsNothing(oTablaDet.campo32), "", oTablaDet.campo32)
                prmParameter(38).Direction = ParameterDirection.Input
                prmParameter(39) = New SqlParameter("@pcampo33", SqlDbType.VarChar, 200)
                prmParameter(39).Value = IIf(IsNothing(oTablaDet.campo33), "", oTablaDet.campo33)
                prmParameter(39).Direction = ParameterDirection.Input
                prmParameter(40) = New SqlParameter("@pcampo34", SqlDbType.VarChar, 200)
                prmParameter(40).Value = IIf(IsNothing(oTablaDet.campo34), "", oTablaDet.campo34)
                prmParameter(40).Direction = ParameterDirection.Input
                prmParameter(41) = New SqlParameter("@pcampo35", SqlDbType.VarChar, 200)
                prmParameter(41).Value = IIf(IsNothing(oTablaDet.campo35), "", oTablaDet.campo35)
                prmParameter(41).Direction = ParameterDirection.Input
                prmParameter(42) = New SqlParameter("@pcampo36", SqlDbType.VarChar, 200)
                prmParameter(42).Value = IIf(IsNothing(oTablaDet.campo36), "", oTablaDet.campo36)
                prmParameter(42).Direction = ParameterDirection.Input
                prmParameter(43) = New SqlParameter("@pcampo37", SqlDbType.VarChar, 200)
                prmParameter(43).Value = IIf(IsNothing(oTablaDet.campo37), "", oTablaDet.campo37)
                prmParameter(43).Direction = ParameterDirection.Input
                prmParameter(44) = New SqlParameter("@pcampo38", SqlDbType.VarChar, 200)
                prmParameter(44).Value = IIf(IsNothing(oTablaDet.campo38), "", oTablaDet.campo38)
                prmParameter(44).Direction = ParameterDirection.Input
                prmParameter(45) = New SqlParameter("@pcampo39", SqlDbType.VarChar, 200)
                prmParameter(45).Value = IIf(IsNothing(oTablaDet.campo39), "", oTablaDet.campo39)
                prmParameter(45).Direction = ParameterDirection.Input
                prmParameter(46) = New SqlParameter("@pcampo40", SqlDbType.VarChar, 200)
                prmParameter(46).Value = IIf(IsNothing(oTablaDet.campo40), "", oTablaDet.campo40)
                prmParameter(46).Direction = ParameterDirection.Input
                prmParameter(47) = New SqlParameter("@pcampo41", SqlDbType.VarChar, 200)
                prmParameter(47).Value = IIf(IsNothing(oTablaDet.campo41), "", oTablaDet.campo41)
                prmParameter(47).Direction = ParameterDirection.Input
                prmParameter(48) = New SqlParameter("@pcampo42", SqlDbType.VarChar, 200)
                prmParameter(48).Value = IIf(IsNothing(oTablaDet.campo42), "", oTablaDet.campo42)
                prmParameter(48).Direction = ParameterDirection.Input
                prmParameter(49) = New SqlParameter("@pcampo43", SqlDbType.VarChar, 200)
                prmParameter(49).Value = IIf(IsNothing(oTablaDet.campo43), "", oTablaDet.campo43)
                prmParameter(49).Direction = ParameterDirection.Input
                prmParameter(50) = New SqlParameter("@pcampo44", SqlDbType.VarChar, 200)
                prmParameter(50).Value = IIf(IsNothing(oTablaDet.campo44), "", oTablaDet.campo44)
                prmParameter(50).Direction = ParameterDirection.Input
                prmParameter(51) = New SqlParameter("@pcampo45", SqlDbType.VarChar, 200)
                prmParameter(51).Value = IIf(IsNothing(oTablaDet.campo45), "", oTablaDet.campo45)
                prmParameter(51).Direction = ParameterDirection.Input
                prmParameter(52) = New SqlParameter("@pcampo46", SqlDbType.VarChar, 200)
                prmParameter(52).Value = IIf(IsNothing(oTablaDet.campo46), "", oTablaDet.campo46)
                prmParameter(52).Direction = ParameterDirection.Input
                prmParameter(53) = New SqlParameter("@pcampo47", SqlDbType.VarChar, 200)
                prmParameter(53).Value = IIf(IsNothing(oTablaDet.campo47), "", oTablaDet.campo47)
                prmParameter(53).Direction = ParameterDirection.Input
                prmParameter(54) = New SqlParameter("@pcampo48", SqlDbType.VarChar, 200)
                prmParameter(54).Value = IIf(IsNothing(oTablaDet.campo48), "", oTablaDet.campo48)
                prmParameter(54).Direction = ParameterDirection.Input
                prmParameter(55) = New SqlParameter("@pcampo49", SqlDbType.VarChar, 200)
                prmParameter(55).Value = IIf(IsNothing(oTablaDet.campo49), "", oTablaDet.campo49)
                prmParameter(55).Direction = ParameterDirection.Input
                prmParameter(56) = New SqlParameter("@pcampo50", SqlDbType.VarChar, 200)
                prmParameter(56).Value = IIf(IsNothing(oTablaDet.campo50), "", oTablaDet.campo50)
                prmParameter(56).Direction = ParameterDirection.Input
                prmParameter(57) = New SqlParameter("@pcampo51", SqlDbType.VarChar, 200)
                prmParameter(57).Value = IIf(IsNothing(oTablaDet.campo51), "", oTablaDet.campo51)
                prmParameter(57).Direction = ParameterDirection.Input

                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_TablaDet_Ins", prmParameter)
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
        ''' Fecha Creacion: 21/04/2011 08:27:56 a.m.
        ''' Proposito: Metodo de Modificacion de datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function ModificarTablaDet(ByVal oLstTablaDet As List(Of clsBE_TablaDet)) As Boolean
            For Each oTablaDet As clsBE_TablaDet In oLstTablaDet
                Dim prmParameter(58) As SqlParameter
                prmParameter(0) = New SqlParameter("@ptablaId", SqlDbType.varchar, 20)
                prmParameter(0).Value = IIf(IsNothing(oTablaDet.tablaId), "", oTablaDet.tablaId)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@ptablaDetId", SqlDbType.varchar, 15)
                prmParameter(1).Value = IIf(IsNothing(oTablaDet.tablaDetId), "", oTablaDet.tablaDetId)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@pdescri", SqlDbType.varchar, 100)
                prmParameter(2).Value = IIf(IsNothing(oTablaDet.descri), "", oTablaDet.descri)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@pcampo0", SqlDbType.VarChar, 200)
                prmParameter(3).Value = IIf(IsNothing(oTablaDet.campo0), "", oTablaDet.campo0)
                prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@pcampo1", SqlDbType.VarChar, 200)
                prmParameter(4).Value = IIf(IsNothing(oTablaDet.campo1), "", oTablaDet.campo1)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@pcampo2", SqlDbType.VarChar, 200)
                prmParameter(5).Value = IIf(IsNothing(oTablaDet.campo2), "", oTablaDet.campo2)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@pcampo3", SqlDbType.VarChar, 200)
                prmParameter(6).Value = IIf(IsNothing(oTablaDet.campo3), "", oTablaDet.campo3)
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7) = New SqlParameter("@pcampo4", SqlDbType.VarChar, 200)
                prmParameter(7).Value = IIf(IsNothing(oTablaDet.campo4), "", oTablaDet.campo4)
                prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(8) = New SqlParameter("@pcampo5", SqlDbType.VarChar, 200)
                prmParameter(8).Value = IIf(IsNothing(oTablaDet.campo5), "", oTablaDet.campo5)
                prmParameter(8).Direction = ParameterDirection.Input
                prmParameter(9) = New SqlParameter("@pcampo6", SqlDbType.VarChar, 200)
                prmParameter(9).Value = IIf(IsNothing(oTablaDet.campo6), "", oTablaDet.campo6)
                prmParameter(9).Direction = ParameterDirection.Input
                prmParameter(10) = New SqlParameter("@pcampo7", SqlDbType.VarChar, 200)
                prmParameter(10).Value = IIf(IsNothing(oTablaDet.campo7), "", oTablaDet.campo7)
                prmParameter(10).Direction = ParameterDirection.Input
                prmParameter(11) = New SqlParameter("@pcampo8", SqlDbType.VarChar, 200)
                prmParameter(11).Value = IIf(IsNothing(oTablaDet.campo8), "", oTablaDet.campo8)
                prmParameter(11).Direction = ParameterDirection.Input
                prmParameter(12) = New SqlParameter("@pcampo9", SqlDbType.VarChar, 200)
                prmParameter(12).Value = IIf(IsNothing(oTablaDet.campo9), "", oTablaDet.campo9)
                prmParameter(12).Direction = ParameterDirection.Input
                prmParameter(13) = New SqlParameter("@pcodigoEstado", SqlDbType.varchar, 15)
                prmParameter(13).Value = IIf(IsNothing(oTablaDet.codigoEstado), "", oTablaDet.codigoEstado)
                prmParameter(13).Direction = ParameterDirection.Input
                prmParameter(14) = New SqlParameter("@pum", SqlDbType.varchar, 15)
                prmParameter(14).Value = IIf(IsNothing(oTablaDet.um), "", oTablaDet.um)
                prmParameter(14).Direction = ParameterDirection.Input
                prmParameter(15) = New SqlParameter("@pfm", SqlDbType.DateTime, 8)
                prmParameter(15).Value = clsUT_Funcion.FechaNull(oTablaDet.fm)
                prmParameter(15).Direction = ParameterDirection.Input
                prmParameter(16) = New SqlParameter("@pcodigoVisible", SqlDbType.varchar, 15)
                prmParameter(16).Value = IIf(IsNothing(oTablaDet.codigoVisible), "", oTablaDet.codigoVisible)
                prmParameter(16).Direction = ParameterDirection.Input
                prmParameter(17) = New SqlParameter("@pcampo10", SqlDbType.VarChar, 200)
                prmParameter(17).Value = IIf(IsNothing(oTablaDet.campo10), "", oTablaDet.campo10)
                prmParameter(17).Direction = ParameterDirection.Input
                prmParameter(18) = New SqlParameter("@pcampo11", SqlDbType.VarChar, 200)
                prmParameter(18).Value = IIf(IsNothing(oTablaDet.campo11), "", oTablaDet.campo11)
                prmParameter(18).Direction = ParameterDirection.Input
                prmParameter(19) = New SqlParameter("@pcampo12", SqlDbType.VarChar, 200)
                prmParameter(19).Value = IIf(IsNothing(oTablaDet.campo12), "", oTablaDet.campo12)
                prmParameter(19).Direction = ParameterDirection.Input
                prmParameter(20) = New SqlParameter("@pcampo13", SqlDbType.VarChar, 200)
                prmParameter(20).Value = IIf(IsNothing(oTablaDet.campo13), "", oTablaDet.campo13)
                prmParameter(20).Direction = ParameterDirection.Input
                prmParameter(21) = New SqlParameter("@pcampo14", SqlDbType.VarChar, 200)
                prmParameter(21).Value = IIf(IsNothing(oTablaDet.campo14), "", oTablaDet.campo14)
                prmParameter(21).Direction = ParameterDirection.Input
                prmParameter(22) = New SqlParameter("@pcampo15", SqlDbType.VarChar, 200)
                prmParameter(22).Value = IIf(IsNothing(oTablaDet.campo15), "", oTablaDet.campo15)
                prmParameter(22).Direction = ParameterDirection.Input
                prmParameter(23) = New SqlParameter("@pcampo16", SqlDbType.VarChar, 200)
                prmParameter(23).Value = IIf(IsNothing(oTablaDet.campo16), "", oTablaDet.campo16)
                prmParameter(23).Direction = ParameterDirection.Input
                prmParameter(24) = New SqlParameter("@pcampo17", SqlDbType.VarChar, 200)
                prmParameter(24).Value = IIf(IsNothing(oTablaDet.campo17), "", oTablaDet.campo17)
                prmParameter(24).Direction = ParameterDirection.Input
                prmParameter(25) = New SqlParameter("@pcampo18", SqlDbType.VarChar, 200)
                prmParameter(25).Value = IIf(IsNothing(oTablaDet.campo18), "", oTablaDet.campo18)
                prmParameter(25).Direction = ParameterDirection.Input
                prmParameter(26) = New SqlParameter("@pcampo19", SqlDbType.VarChar, 200)
                prmParameter(26).Value = IIf(IsNothing(oTablaDet.campo19), "", oTablaDet.campo19)
                prmParameter(26).Direction = ParameterDirection.Input
                prmParameter(27) = New SqlParameter("@pcampo20", SqlDbType.VarChar, 200)
                prmParameter(27).Value = IIf(IsNothing(oTablaDet.campo20), "", oTablaDet.campo20)
                prmParameter(27).Direction = ParameterDirection.Input
                prmParameter(28) = New SqlParameter("@pcampo21", SqlDbType.VarChar, 200)
                prmParameter(28).Value = IIf(IsNothing(oTablaDet.campo21), "", oTablaDet.campo21)
                prmParameter(28).Direction = ParameterDirection.Input
                prmParameter(29) = New SqlParameter("@pcampo22", SqlDbType.VarChar, 200)
                prmParameter(29).Value = IIf(IsNothing(oTablaDet.campo22), "", oTablaDet.campo22)
                prmParameter(29).Direction = ParameterDirection.Input
                prmParameter(30) = New SqlParameter("@pcampo23", SqlDbType.VarChar, 200)
                prmParameter(30).Value = IIf(IsNothing(oTablaDet.campo23), "", oTablaDet.campo23)
                prmParameter(30).Direction = ParameterDirection.Input
                prmParameter(31) = New SqlParameter("@pcampo24", SqlDbType.VarChar, 200)
                prmParameter(31).Value = IIf(IsNothing(oTablaDet.campo24), "", oTablaDet.campo24)
                prmParameter(31).Direction = ParameterDirection.Input
                prmParameter(32) = New SqlParameter("@pcampo25", SqlDbType.VarChar, 200)
                prmParameter(32).Value = IIf(IsNothing(oTablaDet.campo25), "", oTablaDet.campo25)
                prmParameter(32).Direction = ParameterDirection.Input
                prmParameter(33) = New SqlParameter("@pcampo26", SqlDbType.VarChar, 200)
                prmParameter(33).Value = IIf(IsNothing(oTablaDet.campo26), "", oTablaDet.campo26)
                prmParameter(33).Direction = ParameterDirection.Input
                prmParameter(34) = New SqlParameter("@pcampo27", SqlDbType.VarChar, 200)
                prmParameter(34).Value = IIf(IsNothing(oTablaDet.campo27), "", oTablaDet.campo27)
                prmParameter(34).Direction = ParameterDirection.Input

                prmParameter(35) = New SqlParameter("@pcampo28", SqlDbType.VarChar, 200)
                prmParameter(35).Value = IIf(IsNothing(oTablaDet.campo28), "", oTablaDet.campo28)
                prmParameter(35).Direction = ParameterDirection.Input
                prmParameter(36) = New SqlParameter("@pcampo29", SqlDbType.VarChar, 200)
                prmParameter(36).Value = IIf(IsNothing(oTablaDet.campo29), "", oTablaDet.campo29)
                prmParameter(36).Direction = ParameterDirection.Input
                prmParameter(37) = New SqlParameter("@pcampo30", SqlDbType.VarChar, 200)
                prmParameter(37).Value = IIf(IsNothing(oTablaDet.campo30), "", oTablaDet.campo30)
                prmParameter(37).Direction = ParameterDirection.Input
                prmParameter(38) = New SqlParameter("@pcampo31", SqlDbType.VarChar, 200)
                prmParameter(38).Value = IIf(IsNothing(oTablaDet.campo31), "", oTablaDet.campo31)
                prmParameter(38).Direction = ParameterDirection.Input
                prmParameter(39) = New SqlParameter("@pcampo32", SqlDbType.VarChar, 200)
                prmParameter(39).Value = IIf(IsNothing(oTablaDet.campo32), "", oTablaDet.campo32)
                prmParameter(39).Direction = ParameterDirection.Input
                prmParameter(40) = New SqlParameter("@pcampo33", SqlDbType.VarChar, 200)
                prmParameter(40).Value = IIf(IsNothing(oTablaDet.campo33), "", oTablaDet.campo33)
                prmParameter(40).Direction = ParameterDirection.Input
                prmParameter(41) = New SqlParameter("@pcampo34", SqlDbType.VarChar, 200)
                prmParameter(41).Value = IIf(IsNothing(oTablaDet.campo34), "", oTablaDet.campo34)
                prmParameter(41).Direction = ParameterDirection.Input
                prmParameter(42) = New SqlParameter("@pcampo35", SqlDbType.VarChar, 200)
                prmParameter(42).Value = IIf(IsNothing(oTablaDet.campo35), "", oTablaDet.campo35)
                prmParameter(42).Direction = ParameterDirection.Input
                prmParameter(43) = New SqlParameter("@pcampo36", SqlDbType.VarChar, 200)
                prmParameter(43).Value = IIf(IsNothing(oTablaDet.campo36), "", oTablaDet.campo36)
                prmParameter(43).Direction = ParameterDirection.Input
                prmParameter(44) = New SqlParameter("@pcampo37", SqlDbType.VarChar, 200)
                prmParameter(44).Value = IIf(IsNothing(oTablaDet.campo37), "", oTablaDet.campo37)
                prmParameter(44).Direction = ParameterDirection.Input
                prmParameter(45) = New SqlParameter("@pcampo38", SqlDbType.VarChar, 200)
                prmParameter(45).Value = IIf(IsNothing(oTablaDet.campo38), "", oTablaDet.campo38)
                prmParameter(45).Direction = ParameterDirection.Input
                prmParameter(46) = New SqlParameter("@pcampo39", SqlDbType.VarChar, 200)
                prmParameter(46).Value = IIf(IsNothing(oTablaDet.campo39), "", oTablaDet.campo39)
                prmParameter(46).Direction = ParameterDirection.Input
                prmParameter(47) = New SqlParameter("@pcampo40", SqlDbType.VarChar, 200)
                prmParameter(47).Value = IIf(IsNothing(oTablaDet.campo40), "", oTablaDet.campo40)
                prmParameter(47).Direction = ParameterDirection.Input
                prmParameter(48) = New SqlParameter("@pcampo41", SqlDbType.VarChar, 200)
                prmParameter(48).Value = IIf(IsNothing(oTablaDet.campo41), "", oTablaDet.campo41)
                prmParameter(48).Direction = ParameterDirection.Input
                prmParameter(49) = New SqlParameter("@pcampo42", SqlDbType.VarChar, 200)
                prmParameter(49).Value = IIf(IsNothing(oTablaDet.campo42), "", oTablaDet.campo42)
                prmParameter(49).Direction = ParameterDirection.Input
                prmParameter(50) = New SqlParameter("@pcampo43", SqlDbType.VarChar, 200)
                prmParameter(50).Value = IIf(IsNothing(oTablaDet.campo43), "", oTablaDet.campo43)
                prmParameter(50).Direction = ParameterDirection.Input
                prmParameter(51) = New SqlParameter("@pcampo44", SqlDbType.VarChar, 200)
                prmParameter(51).Value = IIf(IsNothing(oTablaDet.campo44), "", oTablaDet.campo44)
                prmParameter(51).Direction = ParameterDirection.Input
                prmParameter(52) = New SqlParameter("@pcampo45", SqlDbType.VarChar, 200)
                prmParameter(52).Value = IIf(IsNothing(oTablaDet.campo45), "", oTablaDet.campo45)
                prmParameter(52).Direction = ParameterDirection.Input
                prmParameter(53) = New SqlParameter("@pcampo46", SqlDbType.VarChar, 200)
                prmParameter(53).Value = IIf(IsNothing(oTablaDet.campo46), "", oTablaDet.campo46)
                prmParameter(53).Direction = ParameterDirection.Input
                prmParameter(54) = New SqlParameter("@pcampo47", SqlDbType.VarChar, 200)
                prmParameter(54).Value = IIf(IsNothing(oTablaDet.campo47), "", oTablaDet.campo47)
                prmParameter(54).Direction = ParameterDirection.Input
                prmParameter(55) = New SqlParameter("@pcampo48", SqlDbType.VarChar, 200)
                prmParameter(55).Value = IIf(IsNothing(oTablaDet.campo48), "", oTablaDet.campo48)
                prmParameter(55).Direction = ParameterDirection.Input
                prmParameter(56) = New SqlParameter("@pcampo49", SqlDbType.VarChar, 200)
                prmParameter(56).Value = IIf(IsNothing(oTablaDet.campo49), "", oTablaDet.campo49)
                prmParameter(56).Direction = ParameterDirection.Input
                prmParameter(57) = New SqlParameter("@pcampo50", SqlDbType.VarChar, 200)
                prmParameter(57).Value = IIf(IsNothing(oTablaDet.campo50), "", oTablaDet.campo50)
                prmParameter(57).Direction = ParameterDirection.Input
                prmParameter(58) = New SqlParameter("@pcampo51", SqlDbType.VarChar, 200)
                prmParameter(58).Value = IIf(IsNothing(oTablaDet.campo51), "", oTablaDet.campo51)
                prmParameter(58).Direction = ParameterDirection.Input

                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_TablaDet_Upd", prmParameter)
                Catch ex As Exception
                    Throw ex
                    Return False
                End Try
            Next
            Return True
        End Function


        Public Function MinMaxTabla(ByVal TablaId As String) As Integer()
            Dim numArray(2) As Integer

            Dim par(0) As SqlParameter
            par(0) = New SqlParameter("@ptablaId", SqlDbType.VarChar)
            par(0).Value = TablaId

            Try
                Dim reader As SqlDataReader = SqlHelper.ExecuteReader(CadenaConexion, CommandType.StoredProcedure, "usp_TablaDet_MinMax", par)
                reader.Read()
                numArray(0) = CInt(reader.GetValue(reader.GetOrdinal("Minimo")))
                numArray(1) = CInt(reader.GetValue(reader.GetOrdinal("Maximo")))
            Catch exception As Exception
                Throw exception
            End Try

            Return numArray
        End Function



        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 21/04/2011 08:27:56 a.m.
        ''' Proposito: Metodo de Elimacion
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function EliminarTablaDet(ByVal oLstTablaDet As List(Of clsBE_TablaDet)) As Boolean
            For Each oTablaDet As clsBE_TablaDet In oLstTablaDet
                Dim prmParameter(1) As SqlParameter
                prmParameter(0) = New SqlParameter("@ptablaId", SqlDbType.varchar, 20)
                prmParameter(0).Value = IIf(IsNothing(oTablaDet.tablaId), "", oTablaDet.tablaId)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@ptablaDetId", SqlDbType.varchar, 15)
                prmParameter(1).Value = IIf(IsNothing(oTablaDet.tablaDetId), "", oTablaDet.tablaDetId)
                prmParameter(1).Direction = ParameterDirection.Input
                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_TablaDet_Del", prmParameter)
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
        ''' Fecha Creacion: 21/04/2011 08:27:56 a.m.
        ''' Proposito: Metodo de Guardar Dataset
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function GuardarTablaDet(ByVal oDSTablaDet As Dataset) As Boolean
            Dim cnxCPO As New SqlConnection(CadenaConexion)


            Try
                Dim objCommnadInsert As New SqlCommand
                objCommnadInsert.Connection = cnxCPO
                objCommnadInsert.CommandText = "up_TablaDet_Ins"
                objCommnadInsert.CommandType = CommandType.StoredProcedure

                objCommnadInsert.Parameters.Add("@ptablaId", SqlDbType.varchar, 20).SourceColumn = "tablaId"
                objCommnadInsert.Parameters.Add("@ptablaDetId", SqlDbType.varchar, 15).SourceColumn = "tablaDetId"
                objCommnadInsert.Parameters.Add("@pdescri", SqlDbType.varchar, 100).SourceColumn = "descri"
                objCommnadInsert.Parameters.Add("@pcampo0", SqlDbType.VarChar, 200).SourceColumn = "campo0"
                objCommnadInsert.Parameters.Add("@pcampo1", SqlDbType.VarChar, 200).SourceColumn = "campo1"
                objCommnadInsert.Parameters.Add("@pcampo2", SqlDbType.VarChar, 200).SourceColumn = "campo2"
                objCommnadInsert.Parameters.Add("@pcampo3", SqlDbType.VarChar, 200).SourceColumn = "campo3"
                objCommnadInsert.Parameters.Add("@pcampo4", SqlDbType.VarChar, 200).SourceColumn = "campo4"
                objCommnadInsert.Parameters.Add("@pcampo5", SqlDbType.VarChar, 200).SourceColumn = "campo5"
                objCommnadInsert.Parameters.Add("@pcampo6", SqlDbType.VarChar, 200).SourceColumn = "campo6"
                objCommnadInsert.Parameters.Add("@pcampo7", SqlDbType.VarChar, 200).SourceColumn = "campo7"
                objCommnadInsert.Parameters.Add("@pcampo8", SqlDbType.VarChar, 200).SourceColumn = "campo8"
                objCommnadInsert.Parameters.Add("@pcampo9", SqlDbType.VarChar, 200).SourceColumn = "campo9"
                objCommnadInsert.Parameters.Add("@pcodigoEstado", SqlDbType.varchar, 15).SourceColumn = "codigoEstado"
                objCommnadInsert.Parameters.Add("@puc", SqlDbType.varchar, 15).SourceColumn = "uc"
                objCommnadInsert.Parameters.Add("@pcodigoVisible", SqlDbType.varchar, 15).SourceColumn = "codigoVisible"
                objCommnadInsert.Parameters.Add("@pcampo10", SqlDbType.VarChar, 200).SourceColumn = "campo10"
                objCommnadInsert.Parameters.Add("@pcampo11", SqlDbType.VarChar, 200).SourceColumn = "campo11"
                objCommnadInsert.Parameters.Add("@pcampo12", SqlDbType.VarChar, 200).SourceColumn = "campo12"
                objCommnadInsert.Parameters.Add("@pcampo13", SqlDbType.VarChar, 200).SourceColumn = "campo13"
                objCommnadInsert.Parameters.Add("@pcampo14", SqlDbType.VarChar, 200).SourceColumn = "campo14"
                objCommnadInsert.Parameters.Add("@pcampo15", SqlDbType.VarChar, 200).SourceColumn = "campo15"
                objCommnadInsert.Parameters.Add("@pcampo16", SqlDbType.VarChar, 200).SourceColumn = "campo16"
                objCommnadInsert.Parameters.Add("@pcampo17", SqlDbType.VarChar, 200).SourceColumn = "campo17"
                objCommnadInsert.Parameters.Add("@pcampo18", SqlDbType.VarChar, 200).SourceColumn = "campo18"
                objCommnadInsert.Parameters.Add("@pcampo19", SqlDbType.VarChar, 200).SourceColumn = "campo19"
                objCommnadInsert.Parameters.Add("@pcampo20", SqlDbType.VarChar, 200).SourceColumn = "campo20"

                Dim objCommandUpdate As New SqlCommand
                objCommandUpdate.Connection = cnxCPO
                objCommandUpdate.CommandText = "up_TablaDet_Upd"
                objCommandUpdate.CommandType = CommandType.StoredProcedure

                objCommandUpdate.Parameters.Add("@ptablaId", SqlDbType.varchar, 20).SourceColumn = "tablaId"
                objCommandUpdate.Parameters.Add("@ptablaDetId", SqlDbType.varchar, 15).SourceColumn = "tablaDetId"
                objCommandUpdate.Parameters.Add("@pdescri", SqlDbType.varchar, 100).SourceColumn = "descri"
                objCommandUpdate.Parameters.Add("@pcampo0", SqlDbType.VarChar, 200).SourceColumn = "campo0"
                objCommandUpdate.Parameters.Add("@pcampo1", SqlDbType.VarChar, 200).SourceColumn = "campo1"
                objCommandUpdate.Parameters.Add("@pcampo2", SqlDbType.VarChar, 200).SourceColumn = "campo2"
                objCommandUpdate.Parameters.Add("@pcampo3", SqlDbType.VarChar, 200).SourceColumn = "campo3"
                objCommandUpdate.Parameters.Add("@pcampo4", SqlDbType.VarChar, 200).SourceColumn = "campo4"
                objCommandUpdate.Parameters.Add("@pcampo5", SqlDbType.VarChar, 200).SourceColumn = "campo5"
                objCommandUpdate.Parameters.Add("@pcampo6", SqlDbType.VarChar, 200).SourceColumn = "campo6"
                objCommandUpdate.Parameters.Add("@pcampo7", SqlDbType.VarChar, 200).SourceColumn = "campo7"
                objCommandUpdate.Parameters.Add("@pcampo8", SqlDbType.VarChar, 200).SourceColumn = "campo8"
                objCommandUpdate.Parameters.Add("@pcampo9", SqlDbType.VarChar, 200).SourceColumn = "campo9"
                objCommandUpdate.Parameters.Add("@pcodigoEstado", SqlDbType.varchar, 15).SourceColumn = "codigoEstado"
                objCommandUpdate.Parameters.Add("@pum", SqlDbType.varchar, 15).SourceColumn = "um"
                objCommandUpdate.Parameters.Add("@pfm", SqlDbType.DateTime, 8).SourceColumn = "fm"
                objCommandUpdate.Parameters.Add("@pcodigoVisible", SqlDbType.varchar, 15).SourceColumn = "codigoVisible"
                objCommandUpdate.Parameters.Add("@pcampo10", SqlDbType.VarChar, 200).SourceColumn = "campo10"
                objCommandUpdate.Parameters.Add("@pcampo11", SqlDbType.VarChar, 200).SourceColumn = "campo11"
                objCommandUpdate.Parameters.Add("@pcampo12", SqlDbType.VarChar, 200).SourceColumn = "campo12"
                objCommandUpdate.Parameters.Add("@pcampo13", SqlDbType.VarChar, 200).SourceColumn = "campo13"
                objCommandUpdate.Parameters.Add("@pcampo14", SqlDbType.VarChar, 200).SourceColumn = "campo14"
                objCommandUpdate.Parameters.Add("@pcampo15", SqlDbType.VarChar, 200).SourceColumn = "campo15"
                objCommandUpdate.Parameters.Add("@pcampo16", SqlDbType.VarChar, 200).SourceColumn = "campo16"
                objCommandUpdate.Parameters.Add("@pcampo17", SqlDbType.VarChar, 200).SourceColumn = "campo17"
                objCommandUpdate.Parameters.Add("@pcampo18", SqlDbType.VarChar, 200).SourceColumn = "campo18"
                objCommandUpdate.Parameters.Add("@pcampo19", SqlDbType.VarChar, 200).SourceColumn = "campo19"
                objCommandUpdate.Parameters.Add("@pcampo20", SqlDbType.VarChar, 200).SourceColumn = "campo20"

                Dim objCommandDelete As New SqlCommand
                objCommandDelete.Connection = cnxCPO
                objCommandDelete.CommandText = "up_TablaDet_Del"
                objCommandDelete.CommandType = CommandType.StoredProcedure

                objCommandDelete.Parameters.Add("@ptablaId", SqlDbType.varchar, 20).SourceColumn = "tablaId"
                objCommandDelete.Parameters.Add("@ptablaDetId", SqlDbType.varchar, 15).SourceColumn = "tablaDetId"

                'SqlHelper.UpdateDataset(objCommnadInsert, objCommandDelete, objCommandUpdate, oDSTablaDet, "TablaDet")

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
    ''' Fecha Creacion: 21/04/2011 08:27:56 a.m.
    ''' Proposito: Obtiene los valores de la tabla TablaDet
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsDB_TablaDetRO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 21/04/2011 08:27:56 a.m.
        ''' Proposito: Lee los datos de un registro
        ''' Fecha Modificacion:
        ''' </summary>
        ''' 
        Public Function LeerTablaDet(ByVal pTablaDet As clsBE_TablaDet) As clsBE_TablaDet
            Dim oTablaDet As clsBE_TablaDet = Nothing
            Dim DSTablaDet As New DataSet
            Dim prmParameter(1) As SqlParameter
            prmParameter(0) = New SqlParameter("@ptablaId", SqlDbType.varchar, 20)
            prmParameter(0).Value = IIf(IsNothing(pTablaDet.tablaId), "", pTablaDet.tablaId)
            prmParameter(1) = New SqlParameter("@ptablaDetId", SqlDbType.varchar, 15)
            prmParameter(1).Value = IIf(IsNothing(pTablaDet.tablaDetId), "", pTablaDet.tablaDetId)
            Try
                Using DSTablaDet
                    DSTablaDet = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_TablaDet_Sel", prmParameter)
                    If Not DSTablaDet Is Nothing Then
                        If DSTablaDet.Tables.Count > 0 Then
                            oTablaDet = New clsBE_TablaDet
                            If DSTablaDet.Tables(0).Rows.Count > 0 Then
                                With DSTablaDet.Tables(0).Rows(0)
                                    oTablaDet.tablaId = .Item("tablaId").tostring
                                    oTablaDet.tablaDetId = .Item("tablaDetId").tostring
                                    oTablaDet.descri = .Item("descri").tostring
                                    oTablaDet.campo0 = .Item("campo0").tostring
                                    oTablaDet.campo1 = .Item("campo1").tostring
                                    oTablaDet.campo2 = .Item("campo2").tostring
                                    oTablaDet.campo3 = .Item("campo3").tostring
                                    oTablaDet.campo4 = .Item("campo4").tostring
                                    oTablaDet.campo5 = .Item("campo5").tostring
                                    oTablaDet.campo6 = .Item("campo6").tostring
                                    oTablaDet.campo7 = .Item("campo7").tostring
                                    oTablaDet.campo8 = .Item("campo8").tostring
                                    oTablaDet.campo9 = .Item("campo9").tostring
                                    oTablaDet.codigoEstado = .Item("codigoEstado").tostring
                                    oTablaDet.uc = .Item("uc").tostring
                                    oTablaDet.fc = .Item("fc").tostring
                                    oTablaDet.codigoVisible = .Item("codigoVisible").tostring
                                    oTablaDet.campo10 = .Item("campo10").tostring
                                    oTablaDet.campo11 = .Item("campo11").tostring
                                    oTablaDet.campo12 = .Item("campo12").tostring
                                    oTablaDet.campo13 = .Item("campo13").tostring
                                    oTablaDet.campo14 = .Item("campo14").tostring
                                    oTablaDet.campo15 = .Item("campo15").tostring
                                    oTablaDet.campo16 = .Item("campo16").tostring
                                    oTablaDet.campo17 = .Item("campo17").tostring
                                    oTablaDet.campo18 = .Item("campo18").tostring
                                    oTablaDet.campo19 = .Item("campo19").tostring
                                    oTablaDet.campo20 = .Item("campo20").ToString
                                    oTablaDet.campo21 = .Item("campo21").ToString
                                    oTablaDet.campo22 = .Item("campo22").ToString
                                    oTablaDet.campo23 = .Item("campo23").ToString
                                    oTablaDet.campo24 = .Item("campo24").ToString
                                    oTablaDet.campo25 = .Item("campo25").ToString
                                    oTablaDet.campo26 = .Item("campo26").ToString
                                    oTablaDet.campo27 = .Item("campo27").ToString
                                    oTablaDet.campo28 = .Item("campo28").ToString
                                    oTablaDet.campo29 = .Item("campo29").ToString
                                    oTablaDet.campo30 = .Item("campo30").ToString
                                    oTablaDet.campo31 = .Item("campo31").ToString
                                    oTablaDet.campo32 = .Item("campo32").ToString
                                    oTablaDet.campo33 = .Item("campo33").ToString
                                    oTablaDet.campo34 = .Item("campo34").ToString
                                    oTablaDet.campo35 = .Item("campo35").ToString
                                    oTablaDet.campo36 = .Item("campo36").ToString
                                    oTablaDet.campo37 = .Item("campo37").ToString
                                    oTablaDet.campo38 = .Item("campo38").ToString
                                    oTablaDet.campo39 = .Item("campo39").ToString
                                    oTablaDet.campo40 = .Item("campo40").ToString
                                    oTablaDet.campo41 = .Item("campo41").ToString
                                    oTablaDet.campo42 = .Item("campo42").ToString
                                    oTablaDet.campo43 = .Item("campo43").ToString
                                    oTablaDet.campo44 = .Item("campo44").ToString
                                    oTablaDet.campo45 = .Item("campo45").ToString
                                    oTablaDet.campo46 = .Item("campo46").ToString
                                    oTablaDet.campo47 = .Item("campo47").ToString
                                    oTablaDet.campo48 = .Item("campo48").ToString
                                    oTablaDet.campo49 = .Item("campo49").ToString
                                    oTablaDet.campo50 = .Item("campo50").ToString
                                    oTablaDet.campo51 = .Item("campo51").ToString


                                End With
                            End If
                        End If
                    End If
                End Using
            Catch exSql As SqlException

            Catch ex As Exception
                Throw ex
            Finally
                If Not DSTablaDet Is Nothing Then
                    DSTablaDet.Dispose()
                End If
                DSTablaDet = Nothing
            End Try

            Return oTablaDet

        End Function


        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 21/04/2011 08:27:56 a.m.
        ''' Proposito: Obtiene la lista de registros
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaTablaDet() As List(Of clsBE_TablaDet)
            Dim olstTablaDet As New List(Of clsBE_TablaDet)
            Dim oTablaDet As clsBE_TablaDet = Nothing
            Dim mintItem As Integer = 0
            Try
                Using Reader As SqlDataReader = SqlHelper.ExecuteReader(CadenaConexion, CommandType.StoredProcedure, "up_TablaDet_Sellst")
                    If Reader.HasRows Then
                        While reader.Read
                            oTablaDet = New clsBE_TablaDet
                            mintItem += 1
                            With oTablaDet
                                .Item = mintItem

                                .tablaId = Reader("tablaId").tostring
                                .tablaDetId = Reader("tablaDetId").tostring
                                .descri = Reader("descri").tostring
                                .campo0 = Reader("campo0").tostring
                                .campo1 = Reader("campo1").tostring
                                .campo2 = Reader("campo2").tostring
                                .campo3 = Reader("campo3").tostring
                                .campo4 = Reader("campo4").tostring
                                .campo5 = Reader("campo5").tostring
                                .campo6 = Reader("campo6").tostring
                                .campo7 = Reader("campo7").tostring
                                .campo8 = Reader("campo8").tostring
                                .campo9 = Reader("campo9").tostring
                                .codigoEstado = Reader("codigoEstado").tostring
                                .uc = Reader("uc").tostring
                                .fc = Reader("fc").tostring
                                .um = Reader("um").tostring
                                .fm = Reader("fm").tostring
                                .codigoVisible = Reader("codigoVisible").tostring
                                .campo10 = Reader("campo10").tostring
                                .campo11 = Reader("campo11").tostring
                                .campo12 = Reader("campo12").tostring
                                .campo13 = Reader("campo13").tostring
                                .campo14 = Reader("campo14").tostring
                                .campo15 = Reader("campo15").tostring
                                .campo16 = Reader("campo16").tostring
                                .campo17 = Reader("campo17").tostring
                                .campo18 = Reader("campo18").tostring
                                .campo19 = Reader("campo19").tostring
                                .campo20 = Reader("campo20").tostring
                            End With
                            olstTablaDet.Add(oTablaDet)
                        End While
                    End If
                End Using
            Catch ex As Exception
                Throw ex
            End Try

            Return olstTablaDet

        End Function

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 21/04/2011 08:27:56 a.m.
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSTablaDet(ByVal pTablaDet As clsBE_TablaDet) As Dataset
            Dim oDSTablaDet As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(0) As SqlParameter
            prmParameter(0) = New SqlParameter("@ptablaId", SqlDbType.varchar, 20)
            prmParameter(0).Value = IIf(IsNothing(pTablaDet.tablaId), "", pTablaDet.tablaId)
            Try

                Using oDSTablaDet
                    oDSTablaDet = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_TablaDet_Sellst", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_TablaDet_Sellst", oDSTablaDet, New String() {"TablaDet"}, prmParameter)
                    If Not oDSTablaDet Is Nothing Then
                        If oDSTablaDet.Tables.Count > 0 Then
                            'If oDSTablaDet.Tables("TablaDet").Rows.Count > 0 Then
                            If oDSTablaDet.Tables(0).Rows.Count > 0 Then
                                Return oDSTablaDet
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSTablaDet

        End Function



        Public Function LeerListaToDSMes() As DataSet
            Dim oDSTablaDet As New DataSet
            Try
                Using oDSTablaDet
                    oDSTablaDet = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "UP_MES_SEL")

                    If Not oDSTablaDet Is Nothing Then
                        If oDSTablaDet.Tables.Count > 0 Then
                            If oDSTablaDet.Tables(0).Rows.Count > 0 Then
                                Return oDSTablaDet
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex
            End Try
            Return oDSTablaDet
        End Function

        Public Function LeerListaToDSAnio() As DataSet
            Dim oDSTablaDet As New DataSet
            Try
                Using oDSTablaDet
                    oDSTablaDet = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "UP_ANIO_SEL")

                    If Not oDSTablaDet Is Nothing Then
                        If oDSTablaDet.Tables.Count > 0 Then
                            If oDSTablaDet.Tables(0).Rows.Count > 0 Then
                                Return oDSTablaDet
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex
            End Try
            Return oDSTablaDet
        End Function





        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 21/04/2011 08:27:56 a.m.
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function DefinirTablaTablaDet() As DataTable

            Try
                Dim DTTablaDet As New DataTable

                Dim tablaId As DataColumn = DTTablaDet.Columns.Add("tablaId", GetType(String))
                tablaId.MaxLength = 20
                tablaId.AllowDBNull = False
                tablaId.DefaultValue = ""

                Dim tablaDetId As DataColumn = DTTablaDet.Columns.Add("tablaDetId", GetType(String))
                tablaDetId.MaxLength = 15
                tablaDetId.AllowDBNull = False
                tablaDetId.DefaultValue = ""

                Dim descri As DataColumn = DTTablaDet.Columns.Add("descri", GetType(String))
                descri.MaxLength = 100
                descri.AllowDBNull = True
                descri.DefaultValue = ""

                Dim campo0 As DataColumn = DTTablaDet.Columns.Add("campo0", GetType(String))
                campo0.MaxLength = 200
                campo0.AllowDBNull = True
                campo0.DefaultValue = ""

                Dim campo1 As DataColumn = DTTablaDet.Columns.Add("campo1", GetType(String))
                campo1.MaxLength = 200
                campo1.AllowDBNull = True
                campo1.DefaultValue = ""

                Dim campo2 As DataColumn = DTTablaDet.Columns.Add("campo2", GetType(String))
                campo2.MaxLength = 200
                campo2.AllowDBNull = True
                campo2.DefaultValue = ""

                Dim campo3 As DataColumn = DTTablaDet.Columns.Add("campo3", GetType(String))
                campo3.MaxLength = 200
                campo3.AllowDBNull = True
                campo3.DefaultValue = ""

                Dim campo4 As DataColumn = DTTablaDet.Columns.Add("campo4", GetType(String))
                campo4.MaxLength = 200
                campo4.AllowDBNull = True
                campo4.DefaultValue = ""

                Dim campo5 As DataColumn = DTTablaDet.Columns.Add("campo5", GetType(String))
                campo5.MaxLength = 200
                campo5.AllowDBNull = True
                campo5.DefaultValue = ""

                Dim campo6 As DataColumn = DTTablaDet.Columns.Add("campo6", GetType(String))
                campo6.MaxLength = 200
                campo6.AllowDBNull = True
                campo6.DefaultValue = ""

                Dim campo7 As DataColumn = DTTablaDet.Columns.Add("campo7", GetType(String))
                campo7.MaxLength = 200
                campo7.AllowDBNull = True
                campo7.DefaultValue = ""

                Dim campo8 As DataColumn = DTTablaDet.Columns.Add("campo8", GetType(String))
                campo8.MaxLength = 200
                campo8.AllowDBNull = True
                campo8.DefaultValue = ""

                Dim campo9 As DataColumn = DTTablaDet.Columns.Add("campo9", GetType(String))
                campo9.MaxLength = 200
                campo9.AllowDBNull = True
                campo9.DefaultValue = ""

                Dim codigoEstado As DataColumn = DTTablaDet.Columns.Add("codigoEstado", GetType(String))
                codigoEstado.MaxLength = 15
                codigoEstado.AllowDBNull = True
                codigoEstado.DefaultValue = ""

                Dim uc As DataColumn = DTTablaDet.Columns.Add("uc", GetType(String))
                uc.MaxLength = 15
                uc.AllowDBNull = True
                uc.DefaultValue = ""

                Dim fc As DataColumn = DTTablaDet.Columns.Add("fc", GetType(DateTime))


                Dim um As DataColumn = DTTablaDet.Columns.Add("um", GetType(String))
                um.MaxLength = 15
                um.AllowDBNull = True
                um.DefaultValue = ""

                Dim fm As DataColumn = DTTablaDet.Columns.Add("fm", GetType(DateTime))


                Dim codigoVisible As DataColumn = DTTablaDet.Columns.Add("codigoVisible", GetType(String))
                codigoVisible.MaxLength = 15
                codigoVisible.AllowDBNull = True
                codigoVisible.DefaultValue = ""

                Dim campo10 As DataColumn = DTTablaDet.Columns.Add("campo10", GetType(String))
                campo10.MaxLength = 200
                campo10.AllowDBNull = True
                campo10.DefaultValue = ""

                Dim campo11 As DataColumn = DTTablaDet.Columns.Add("campo11", GetType(String))
                campo11.MaxLength = 200
                campo11.AllowDBNull = True
                campo11.DefaultValue = ""

                Dim campo12 As DataColumn = DTTablaDet.Columns.Add("campo12", GetType(String))
                campo12.MaxLength = 200
                campo12.AllowDBNull = True
                campo12.DefaultValue = ""

                Dim campo13 As DataColumn = DTTablaDet.Columns.Add("campo13", GetType(String))
                campo13.MaxLength = 200
                campo13.AllowDBNull = True
                campo13.DefaultValue = ""

                Dim campo14 As DataColumn = DTTablaDet.Columns.Add("campo14", GetType(String))
                campo14.MaxLength = 200
                campo14.AllowDBNull = True
                campo14.DefaultValue = ""

                Dim campo15 As DataColumn = DTTablaDet.Columns.Add("campo15", GetType(String))
                campo15.MaxLength = 200
                campo15.AllowDBNull = True
                campo15.DefaultValue = ""

                Dim campo16 As DataColumn = DTTablaDet.Columns.Add("campo16", GetType(String))
                campo16.MaxLength = 200
                campo16.AllowDBNull = True
                campo16.DefaultValue = ""

                Dim campo17 As DataColumn = DTTablaDet.Columns.Add("campo17", GetType(String))
                campo17.MaxLength = 200
                campo17.AllowDBNull = True
                campo17.DefaultValue = ""

                Dim campo18 As DataColumn = DTTablaDet.Columns.Add("campo18", GetType(String))
                campo18.MaxLength = 200
                campo18.AllowDBNull = True
                campo18.DefaultValue = ""

                Dim campo19 As DataColumn = DTTablaDet.Columns.Add("campo19", GetType(String))
                campo19.MaxLength = 200
                campo19.AllowDBNull = True
                campo19.DefaultValue = ""

                Dim campo20 As DataColumn = DTTablaDet.Columns.Add("campo20", GetType(String))
                campo20.MaxLength = 200
                campo20.AllowDBNull = True
                campo20.DefaultValue = ""

                Return DTTablaDet
            Catch ex As Exception
                Throw ex
            End Try
        End Function




        Public Function LeerListaToDSTablaDetCondicion(ByVal pTablaDet As clsBE_TablaDet) As DataSet
            Dim oDSTablaDet As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(1) As SqlParameter
            prmParameter(0) = New SqlParameter("@ptablaId", SqlDbType.VarChar, 20)
            prmParameter(0).Value = IIf(IsNothing(pTablaDet.tablaId), "", pTablaDet.tablaId)

            prmParameter(1) = New SqlParameter("@Campo0", SqlDbType.VarChar, 20)
            prmParameter(1).Value = IIf(IsNothing(pTablaDet.campo0), "", pTablaDet.campo0)

            Try

                Using oDSTablaDet
                    oDSTablaDet = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "[up_TablaDet_Sellst_Condicion]", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_TablaDet_Sellst", oDSTablaDet, New String() {"TablaDet"}, prmParameter)
                    If Not oDSTablaDet Is Nothing Then
                        If oDSTablaDet.Tables.Count > 0 Then
                            'If oDSTablaDet.Tables("TablaDet").Rows.Count > 0 Then
                            If oDSTablaDet.Tables(0).Rows.Count > 0 Then
                                Return oDSTablaDet
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSTablaDet

        End Function





        Public Function LeerListaToDSTablaDetObjects(ByVal pTablaDet As clsBE_TablaDet) As DataSet
            Dim oDSTablaDet As New DataSet
            Dim mintItem As Integer = 0

            Dim prmParameter(0) As SqlParameter
            prmParameter(0) = New SqlParameter("@tablaDetId", SqlDbType.VarChar, 15)
            prmParameter(0).Value = IIf(IsNothing(pTablaDet.tablaDetId), "", pTablaDet.tablaDetId)


            Try

                Dim cnx As New SqlConnection(CadenaConexion)
                Dim cmd As New SqlCommand()
                Dim da As New SqlDataAdapter()

                cmd.Connection = cnx
                cmd.CommandText = "upTablaDet_Sel_Objects"
                cmd.Parameters.AddWithValue("@tablaDetId", IIf(IsNothing(pTablaDet.tablaDetId), "", pTablaDet.tablaDetId))
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandTimeout = 3000

                da.SelectCommand = cmd

                da.Fill(oDSTablaDet)

                'Using oDSTablaDet
                '    oDSTablaDet = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "[upTablaDet_Sel_Objects]", prmParameter)
                '    If Not oDSTablaDet Is Nothing Then
                '        If oDSTablaDet.Tables.Count > 0 Then

                '            If oDSTablaDet.Tables(0).Rows.Count > 0 Then
                '                Return oDSTablaDet
                '            End If
                '        End If
                '    End If
                'End Using

            Catch ex As Exception
                Throw ex

            End Try
            Return oDSTablaDet

        End Function




        Public Function LeerListaToDSEstadoPeriodos(ByVal pTablaDet As clsBE_TablaDet) As DataSet
            Dim oDSTablaDet As New DataSet
            Try
                Dim prmParameter(1) As SqlParameter

                prmParameter(0) = New SqlParameter("@tablaDetId", SqlDbType.VarChar, 15)
                prmParameter(0).Value = IIf(IsNothing(pTablaDet.tablaDetId), "", pTablaDet.tablaDetId)

                prmParameter(1) = New SqlParameter("@Vch_periodo", SqlDbType.VarChar, 15)
                prmParameter(1).Value = IIf(IsNothing(pTablaDet.campo6), "", pTablaDet.campo6)

                Using oDSTablaDet
                    oDSTablaDet = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_ESTADO_PERIODO", prmParameter)

                    If Not oDSTablaDet Is Nothing Then
                        If oDSTablaDet.Tables.Count > 0 Then
                            If oDSTablaDet.Tables(0).Rows.Count > 0 Then
                                Return oDSTablaDet
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex
            End Try
            Return oDSTablaDet
        End Function

        '@01    AINI

        Function ValidarUsuarioToValidacionCTB(ByVal currentUserCode As String) As Boolean
            Dim validacion As Boolean
            Dim prmParameter(0) As SqlParameter
            prmParameter(0) = New SqlParameter("@currentUserCode", SqlDbType.VarChar, 15)
            prmParameter(0).Value = currentUserCode
            prmParameter(0).Direction = ParameterDirection.Input
            Try
                Using Reader As SqlDataReader = SqlHelper.ExecuteReader(CadenaConexion, CommandType.StoredProcedure, "up_ValidacionCTB", prmParameter)
                    If Reader.HasRows Then
                        Reader.Read()
                        validacion = IIf(CInt(Reader("PERMISO")) = 1, True, False)
                    End If
                End Using
            Catch ex As Exception
                Throw ex
                validacion = False
            End Try
            Return validacion
        End Function
        '@01    AFIN
    End Class
#End Region

End Namespace
