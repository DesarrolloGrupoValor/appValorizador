Imports SI.BE
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Imports SI.UT

Namespace SI.DB

    Partial Public Class clsDB_TB_DESCUENTOS_LIQTX

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionEN")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("EN")
        End Sub

        Public Function TB_DESCUENTOS_LIQ_INSERT(ByVal oBE_TB_DESCUENTOS_LIQ As List(Of clsBE_TB_DESCUENTOS_LIQ)) As Boolean
            For Each oTB_DESCUENTOS_LIQ As clsBE_TB_DESCUENTOS_LIQ In oBE_TB_DESCUENTOS_LIQ
                Dim prmParameter(13) As SqlParameter

                prmParameter(0) = New SqlParameter("@ITEM", SqlDbType.Int)
                prmParameter(1) = New SqlParameter("@SEC", SqlDbType.Int)
                prmParameter(2) = New SqlParameter("@BENEFICIARIO", SqlDbType.VarChar, 15)
                prmParameter(3) = New SqlParameter("@BANCO", SqlDbType.VarChar, 4)
                prmParameter(4) = New SqlParameter("@CUENTA_BCO", SqlDbType.VarChar, 20)
                prmParameter(5) = New SqlParameter("@TIPO", SqlDbType.VarChar, 20)
                prmParameter(6) = New SqlParameter("@DESCRIPCION", SqlDbType.VarChar, 200)
                prmParameter(7) = New SqlParameter("@IMPORTE", SqlDbType.Float)
                prmParameter(8) = New SqlParameter("@TIPO_COMPR", SqlDbType.VarChar, 3)
                prmParameter(9) = New SqlParameter("@NUM_COMPR", SqlDbType.VarChar, 15)


                prmParameter(10) = New SqlParameter("@LINEA_CLI", SqlDbType.Int)  '12
                prmParameter(11) = New SqlParameter("@CUENTA_PROV", SqlDbType.VarChar, 12) '13

                prmParameter(12) = New SqlParameter("@contratoloteId", SqlDbType.VarChar, 20)  '10
                prmParameter(13) = New SqlParameter("@usuario_liq", SqlDbType.VarChar, 20)     '11

                prmParameter(0).Value = IIf(IsNothing(oTB_DESCUENTOS_LIQ.ITEM), 0, oTB_DESCUENTOS_LIQ.ITEM)
                prmParameter(1).Value = IIf(IsNothing(oTB_DESCUENTOS_LIQ.SEC), 0, oTB_DESCUENTOS_LIQ.SEC)
                prmParameter(2).Value = IIf(IsNothing(oTB_DESCUENTOS_LIQ.BENEFICIARIO), "", oTB_DESCUENTOS_LIQ.BENEFICIARIO)
                prmParameter(3).Value = IIf(IsNothing(oTB_DESCUENTOS_LIQ.BANCO), "", oTB_DESCUENTOS_LIQ.BANCO)
                prmParameter(4).Value = IIf(IsNothing(oTB_DESCUENTOS_LIQ.CUENTA_BCO), "", oTB_DESCUENTOS_LIQ.CUENTA_BCO)
                prmParameter(5).Value = IIf(IsNothing(oTB_DESCUENTOS_LIQ.TIPO), "", oTB_DESCUENTOS_LIQ.TIPO)
                prmParameter(6).Value = IIf(IsNothing(oTB_DESCUENTOS_LIQ.DESCRIPCION), "", oTB_DESCUENTOS_LIQ.DESCRIPCION)
                prmParameter(7).Value = IIf(IsNothing(oTB_DESCUENTOS_LIQ.IMPORTE), 0, oTB_DESCUENTOS_LIQ.IMPORTE)
                prmParameter(8).Value = IIf(IsNothing(oTB_DESCUENTOS_LIQ.TIPO_COMPR), "", oTB_DESCUENTOS_LIQ.TIPO_COMPR)
                prmParameter(9).Value = IIf(IsNothing(oTB_DESCUENTOS_LIQ.NUM_COMPR), "", oTB_DESCUENTOS_LIQ.NUM_COMPR)

                prmParameter(12).Value = IIf(IsNothing(oTB_DESCUENTOS_LIQ.contratoLoteId), "", oTB_DESCUENTOS_LIQ.contratoLoteId)
                prmParameter(13).Value = IIf(IsNothing(oTB_DESCUENTOS_LIQ.usuario_liq), "", oTB_DESCUENTOS_LIQ.usuario_liq)

                prmParameter(10).Value = IIf(IsNothing(oTB_DESCUENTOS_LIQ.LINEA_CLI), 0, oTB_DESCUENTOS_LIQ.LINEA_CLI)
                prmParameter(11).Value = IIf(IsNothing(oTB_DESCUENTOS_LIQ.CUENTA_PROV), "", oTB_DESCUENTOS_LIQ.CUENTA_PROV)


                ''prmParameter(0).Direction = ParameterDirection.Input
                ''prmParameter(1).Direction = ParameterDirection.Input
                ''prmParameter(2).Direction = ParameterDirection.Input
                ''prmParameter(3).Direction = ParameterDirection.Input
                ''prmParameter(4).Direction = ParameterDirection.Input
                ''prmParameter(5).Direction = ParameterDirection.Input
                ''prmParameter(6).Direction = ParameterDirection.Input
                ''prmParameter(7).Direction = ParameterDirection.Input
                ''prmParameter(8).Direction = ParameterDirection.Input
                ''prmParameter(9).Direction = ParameterDirection.Input

                ''prmParameter(10).Direction = ParameterDirection.Input
                ''prmParameter(11).Direction = ParameterDirection.Input



                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "UPS_TB_DESCUENTOS_LIQ_INS", prmParameter)

                Catch ex As Exception
                    Throw ex
                    Return False
                End Try
            Next
            Return True
        End Function





        Public Function TB_DESCUENTOS_LIQ_UPDATE(ByVal oBE_TB_DESCUENTOS_LIQ As List(Of clsBE_TB_DESCUENTOS_LIQ)) As Boolean
            For Each oTB_DESCUENTOS_LIQ As clsBE_TB_DESCUENTOS_LIQ In oBE_TB_DESCUENTOS_LIQ
                Dim prmParameter(4) As SqlParameter

                prmParameter(0) = New SqlParameter("@ITEM", SqlDbType.Int)
                prmParameter(1) = New SqlParameter("@SEC", SqlDbType.Int)
                prmParameter(2) = New SqlParameter("@DESCRIPCION", SqlDbType.VarChar, 200)
                prmParameter(3) = New SqlParameter("@FECHA_CARTA", SqlDbType.DateTime)

                'prmParameter(4) = New SqlParameter("@MONEDA", SqlDbType.Char, 2)
                prmParameter(4) = New SqlParameter("@IMP_MONEDA", SqlDbType.Decimal)

                prmParameter(0).Value = IIf(IsNothing(oTB_DESCUENTOS_LIQ.ITEM), 0, oTB_DESCUENTOS_LIQ.ITEM)
                prmParameter(1).Value = IIf(IsNothing(oTB_DESCUENTOS_LIQ.SEC), 0, oTB_DESCUENTOS_LIQ.SEC)
                prmParameter(2).Value = IIf(IsNothing(oTB_DESCUENTOS_LIQ.DESCRIPCION), "", oTB_DESCUENTOS_LIQ.DESCRIPCION)
                prmParameter(3).Value = IIf(IsNothing(oTB_DESCUENTOS_LIQ.FECHA_CARTA), "01/01/1900", oTB_DESCUENTOS_LIQ.FECHA_CARTA)

                'prmParameter(4).Value = IIf(IsNothing(oTB_DESCUENTOS_LIQ.MONEDA), "", oTB_DESCUENTOS_LIQ.MONEDA)
                prmParameter(4).Value = IIf(IsNothing(oTB_DESCUENTOS_LIQ.IMP_MONEDA), 0, oTB_DESCUENTOS_LIQ.IMP_MONEDA)

                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3).Direction = ParameterDirection.Input

                prmParameter(4).Direction = ParameterDirection.Input
                'prmParameter(5).Direction = ParameterDirection.Input

                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "UPS_TB_DESCUENTOS_LIQ_UPD", prmParameter)

                Catch ex As Exception
                    Throw ex
                    Return False
                End Try
            Next
            Return True
        End Function
    End Class

    Partial Public Class clsDB_TB_DESCUENTOS_LIQRO

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionEN")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("EN")
        End Sub

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 07/12/2010 14:46:15
        ''' Proposito: Lee los datos de un registro
        ''' Fecha Modificacion:
        ''' </summary>
        ''' 
        Public Function LeerPagableCorrelativo(ByVal pTB_DESCUENTOS_LIQ As clsBE_TB_DESCUENTOS_LIQ) As clsBE_TB_DESCUENTOS_LIQ
            Dim oTB_DESCUENTOS_LIQ As clsBE_TB_DESCUENTOS_LIQ = Nothing
            Dim DSTB_DESCUENTOS_LIQ As New DataSet
            ''Dim prmParameter(1) As SqlParameter
            ' ''prmParameter(0) = New SqlParameter("@pliquidacionTmId", SqlDbType.VarChar, 20)
            ' ''prmParameter(0).Value = IIf(IsNothing(pTB_DESCUENTOS_LIQ.liquidacionTmId), "", pTB_DESCUENTOS_LIQ.liquidacionTmId)
            ''prmParameter(0) = New SqlParameter("@pliquidacionId", SqlDbType.VarChar, 20)
            ''prmParameter(0).Value = IIf(IsNothing(pTB_DESCUENTOS_LIQ.liquidacionId), "", pTB_DESCUENTOS_LIQ.liquidacionId)
            ''prmParameter(1) = New SqlParameter("@pcontratoLoteId", SqlDbType.VarChar, 20)
            ''prmParameter(1).Value = IIf(IsNothing(pTB_DESCUENTOS_LIQ.contratoLoteId), "", pTB_DESCUENTOS_LIQ.contratoLoteId)
            ''Try
            ''    Using DSTB_DESCUENTOS_LIQ
            ''        DSTB_DESCUENTOS_LIQ = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_TB_DESCUENTOS_LIQ_Sel_correlativo", prmParameter)
            ''        If Not DSTB_DESCUENTOS_LIQ Is Nothing Then
            ''            If DSTB_DESCUENTOS_LIQ.Tables.Count > 0 Then
            ''                oTB_DESCUENTOS_LIQ = New clsBE_TB_DESCUENTOS_LIQ
            ''                If DSTB_DESCUENTOS_LIQ.Tables(0).Rows.Count > 0 Then
            ''                    With DSTB_DESCUENTOS_LIQ.Tables(0).Rows(0)
            ''                        oTB_DESCUENTOS_LIQ.liquidacionPagable = .Item("correlativo").ToString
            ''                    End With
            ''                End If
            ''            End If
            ''        End If
            ''    End Using
            ''Catch exSql As SqlException

            ''Catch ex As Exception
            ''    Throw ex
            ''Finally
            ''    If Not DSTB_DESCUENTOS_LIQ Is Nothing Then
            ''        DSTB_DESCUENTOS_LIQ.Dispose()
            ''    End If
            ''    DSTB_DESCUENTOS_LIQ = Nothing
            ''End Try

            Return oTB_DESCUENTOS_LIQ

        End Function
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 17:00:41
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSTB_DESCUENTOS_LIQ(ByVal pTB_DESCUENTOS_LIQ As clsBE_TB_DESCUENTOS_LIQ) As DataSet
            Dim oDSTB_DESCUENTOS_LIQ As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(1) As SqlParameter

            prmParameter(0) = New SqlParameter("@ITEM", SqlDbType.VarChar, 5)
            prmParameter(0).Value = IIf(IsNothing(pTB_DESCUENTOS_LIQ.ITEM), 0, pTB_DESCUENTOS_LIQ.ITEM)

            prmParameter(1) = New SqlParameter("@empresa", SqlDbType.VarChar, 5)
            prmParameter(1).Value = IIf(IsNothing(pTB_DESCUENTOS_LIQ.EMPRESA), "", pTB_DESCUENTOS_LIQ.EMPRESA)


            Try

                Using oDSTB_DESCUENTOS_LIQ
                    oDSTB_DESCUENTOS_LIQ = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "UPS_TB_DESCUENTOS_LIQ_SEL", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_TB_DESCUENTOS_LIQ_Sellst", oDSTB_DESCUENTOS_LIQ, New String() {"TB_DESCUENTOS_LIQ"}, prmParameter)
                    If Not oDSTB_DESCUENTOS_LIQ Is Nothing Then
                        If oDSTB_DESCUENTOS_LIQ.Tables.Count > 0 Then
                            'If oDSTB_DESCUENTOS_LIQ.Tables("TB_DESCUENTOS_LIQ").Rows.Count > 0 Then
                            If oDSTB_DESCUENTOS_LIQ.Tables(0).Rows.Count > 0 Then
                                Return oDSTB_DESCUENTOS_LIQ
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSTB_DESCUENTOS_LIQ

        End Function

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 11/03/2011 17:53:28
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function DefineTablaTB_DESCUENTOS_LIQ() As DataTable

            Try
                Dim DTTB_DESCUENTOS_LIQ As New DataTable


                Dim orden As DataColumn = DTTB_DESCUENTOS_LIQ.Columns.Add("orden", GetType(Integer))
                'orden.MaxLength = 20
                orden.AllowDBNull = True
                orden.DefaultValue = 0

                Dim codigoElemento As DataColumn = DTTB_DESCUENTOS_LIQ.Columns.Add("tablaDetId", GetType(String))
                codigoElemento.MaxLength = 20
                codigoElemento.AllowDBNull = True
                codigoElemento.DefaultValue = ""

                Dim txtDescripcion As DataColumn = DTTB_DESCUENTOS_LIQ.Columns.Add("txtDescripcion", GetType(String))
                txtDescripcion.MaxLength = 50
                txtDescripcion.AllowDBNull = True
                txtDescripcion.DefaultValue = ""

                Dim IMPORTE As DataColumn = DTTB_DESCUENTOS_LIQ.Columns.Add("IMPORTE", GetType(Double))
                IMPORTE.AllowDBNull = True
                IMPORTE.DefaultValue = 0


                Dim BENEFICIARIO As DataColumn = DTTB_DESCUENTOS_LIQ.Columns.Add("BENEFICIARIO", GetType(String))
                BENEFICIARIO.MaxLength = 50
                BENEFICIARIO.AllowDBNull = True
                BENEFICIARIO.DefaultValue = ""

                Dim BENEFICIARIO_DESC As DataColumn = DTTB_DESCUENTOS_LIQ.Columns.Add("BENEFICIARIO_DESC", GetType(String))
                BENEFICIARIO_DESC.AllowDBNull = True
                BENEFICIARIO_DESC.DefaultValue = ""

                Dim BANCO As DataColumn = DTTB_DESCUENTOS_LIQ.Columns.Add("BANCO", GetType(String))
                BANCO.MaxLength = 15
                BANCO.AllowDBNull = True
                BANCO.DefaultValue = ""


                Dim MONEDA As DataColumn = DTTB_DESCUENTOS_LIQ.Columns.Add("MONEDA", GetType(String))
                MONEDA.MaxLength = 15
                MONEDA.AllowDBNull = True
                MONEDA.DefaultValue = ""

                Dim CUENTA_BCO As DataColumn = DTTB_DESCUENTOS_LIQ.Columns.Add("CUENTA_BCO", GetType(String))
                CUENTA_BCO.MaxLength = 15
                CUENTA_BCO.AllowDBNull = True
                CUENTA_BCO.DefaultValue = ""


                Dim TIPO_COMPR As DataColumn = DTTB_DESCUENTOS_LIQ.Columns.Add("TIPO_COMPR", GetType(String))
                TIPO_COMPR.MaxLength = 3
                TIPO_COMPR.AllowDBNull = True
                TIPO_COMPR.DefaultValue = ""

                Dim NUM_COMPR As DataColumn = DTTB_DESCUENTOS_LIQ.Columns.Add("NUM_COMPR", GetType(String))
                NUM_COMPR.MaxLength = 15
                NUM_COMPR.AllowDBNull = True
                NUM_COMPR.DefaultValue = ""

                Dim LINEA_CLI As DataColumn = DTTB_DESCUENTOS_LIQ.Columns.Add("LINEA_CLI", GetType(Integer))
                LINEA_CLI.AllowDBNull = True
                LINEA_CLI.DefaultValue = 0

                Dim CUENTA_PROV As DataColumn = DTTB_DESCUENTOS_LIQ.Columns.Add("CUENTA_PROV", GetType(String))
                CUENTA_PROV.MaxLength = 12
                CUENTA_PROV.AllowDBNull = True
                CUENTA_PROV.DefaultValue = ""

                Return DTTB_DESCUENTOS_LIQ
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
