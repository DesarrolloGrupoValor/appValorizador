'Modified:
'@01 20141016 BAL01 Elimar asiento contable segun filtro (Empresa, Tipo movimiento, periodo)
'@02 20141016 BAL01 Carga de datos para Verificacion vs CONCAR

Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports SI.BE
Imports Microsoft.ApplicationBlocks.Data

Namespace SI.DB
#Region "Clase Lectura"
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 07/11/2007 03:44:43 p.m.
    ''' Proposito: Obtiene los valores de la tabla General
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
       Public Class clsDB_GeneralRO
        Private Shared strCadenaConexion As String
        Public Sub New()
            'strCadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            strCadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
        ''' <summary>
        ''' Escrito por: 
        ''' Fecha Creacion:
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function Obtener_Parametros(ByVal pGeneral As clsBE_General) As List(Of clsBE_General)
            Dim olstGeneral As New List(Of clsBE_General)
            Dim oGeneral As clsBE_General = Nothing
            Dim mintItem As Integer = 0
            Dim prmParameter(1) As SqlParameter

            prmParameter(0) = New SqlParameter("@pCampo_Dominio", SqlDbType.VarChar, 200)
            prmParameter(0).Value = IIf(IsNothing(pGeneral.NomTabla), "", pGeneral.NomTabla)

            prmParameter(1) = New SqlParameter("@pPrimer_Valor", SqlDbType.VarChar, 200)
            prmParameter(1).Value = IIf(IsNothing(pGeneral.PrimerValor), "", pGeneral.PrimerValor)


            Try
                Using Reader As SqlDataReader = SqlHelper.ExecuteReader(strCadenaConexion, CommandType.StoredProcedure, "up_Gral_Mostrar_Parametros", prmParameter)
                    If Reader.HasRows Then
                        While Reader.Read
                            oGeneral = New clsBE_General

                            If pGeneral.NomCampo1 IsNot Nothing And pGeneral.NomCampo1 = Reader("codigo").ToString Then
                            Else
                                mintItem += 1
                                With oGeneral
                                    .Id_Retorna = Reader("id")
                                    .Descripcion_Retorna = Reader("descripcion").ToString
                                    .Codigo_Retorna = Reader("codigo").ToString
                                    .CodigoDescripcion_Retorna = Reader("codigodescripcion").ToString
                                End With
                                olstGeneral.Add(oGeneral)
                            End If
                        End While
                    End If
                End Using
            Catch ex As Exception
                Throw ex
            End Try
            Return olstGeneral
        End Function
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 17:00:29
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function Obtener_ParametrosDS(ByVal pGeneral As clsBE_General) As DataSet
            Dim oDSTablaDet As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(1) As SqlParameter
            prmParameter(0) = New SqlParameter("@pCampo_Dominio", SqlDbType.VarChar, 200)
            prmParameter(0).Value = IIf(IsNothing(pGeneral.NomTabla), "", pGeneral.NomTabla)
            prmParameter(1) = New SqlParameter("@pPrimer_Valor", SqlDbType.VarChar, 200)
            prmParameter(1).Value = IIf(IsNothing(pGeneral.PrimerValor), "", pGeneral.PrimerValor)
            Try
                Using oDSTablaDet
                    oDSTablaDet = SqlHelper.ExecuteDataset(strCadenaConexion, CommandType.StoredProcedure, "up_Gral_Obtener_Parametros", prmParameter)
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
        ''' Escrito por: 
        ''' Fecha Creacion:
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function Obtener_Parametros_Resultado(ByVal pGeneral As clsBE_General) As List(Of clsBE_General_resultado)
            Dim olstGeneral As New List(Of clsBE_General_resultado)
            Dim oGeneral As clsBE_General_resultado = Nothing
            Dim mintItem As Integer = 0
            Dim prmParameter(1) As SqlParameter

            prmParameter(0) = New SqlParameter("@pCampo_Dominio", SqlDbType.VarChar, 200)
            prmParameter(0).Value = IIf(IsNothing(pGeneral.NomTabla), "", pGeneral.NomTabla)

            prmParameter(1) = New SqlParameter("@pPrimer_Valor", SqlDbType.VarChar, 200)
            prmParameter(1).Value = IIf(IsNothing(pGeneral.PrimerValor), "", pGeneral.PrimerValor)


            Try
                Using Reader As SqlDataReader = SqlHelper.ExecuteReader(strCadenaConexion, CommandType.StoredProcedure, "up_Gral_Obtener_Parametros", prmParameter)
                    If Reader.HasRows Then
                        While Reader.Read
                            oGeneral = New clsBE_General_resultado
                            mintItem += 1
                            With oGeneral

                                .Descripcion_Retorna = Reader("descripcion").ToString
                                .Codigo_Retorna = Reader("codigo").ToString

                            End With
                            olstGeneral.Add(oGeneral)
                        End While
                    End If
                End Using
            Catch ex As Exception
                Throw ex
            End Try
            Return olstGeneral
        End Function

        ''' <summary>
        ''' Escrito por: 
        ''' Fecha Creacion:
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function Obtener_Registros(ByVal pGeneral As clsBE_General) As List(Of clsBE_General)
            Dim olstGeneral As New List(Of clsBE_General)
            Dim oGeneral As clsBE_General = Nothing
            Dim mintItem As Integer = 0
            Dim prmParameter(8) As SqlParameter

            prmParameter(0) = New SqlParameter("@pNombre_Tabla", SqlDbType.VarChar, 200)
            prmParameter(0).Value = IIf(IsNothing(pGeneral.NomTabla), "", pGeneral.NomTabla)

            prmParameter(1) = New SqlParameter("@pid_Retorna", SqlDbType.VarChar, 500)
            prmParameter(1).Value = IIf(IsNothing(pGeneral.Id_Retorna), "", pGeneral.Id_Retorna)

            prmParameter(2) = New SqlParameter("@pCodigo_Retorna", SqlDbType.VarChar, 500)
            prmParameter(2).Value = IIf(IsNothing(pGeneral.Codigo_Retorna), "", pGeneral.Codigo_Retorna)

            prmParameter(3) = New SqlParameter("@pDescripcion_Retorna", SqlDbType.VarChar, 500)
            prmParameter(3).Value = IIf(IsNothing(pGeneral.Descripcion_Retorna), "", pGeneral.Descripcion_Retorna)

            prmParameter(4) = New SqlParameter("@pPrimer_Valor", SqlDbType.VarChar, 200)
            prmParameter(4).Value = IIf(IsNothing(pGeneral.PrimerValor), "", pGeneral.PrimerValor)

            prmParameter(5) = New SqlParameter("@pNombre_Campo1", SqlDbType.VarChar, 200)
            prmParameter(5).Value = IIf(IsNothing(pGeneral.NomCampo1), "", pGeneral.NomCampo1)

            prmParameter(6) = New SqlParameter("@pValor_Campo1", SqlDbType.VarChar, 200)
            prmParameter(6).Value = IIf(IsNothing(pGeneral.ValCampo1), "", pGeneral.ValCampo1)

            prmParameter(7) = New SqlParameter("@pNombre_Campo2", SqlDbType.VarChar, 200)
            prmParameter(7).Value = IIf(IsNothing(pGeneral.NomCampo2), "", pGeneral.NomCampo2)

            prmParameter(8) = New SqlParameter("@pValor_Campo2", SqlDbType.VarChar, 200)
            prmParameter(8).Value = IIf(IsNothing(pGeneral.ValCampo2), "", pGeneral.ValCampo2)

            Try
                Using Reader As SqlDataReader = SqlHelper.ExecuteReader(strCadenaConexion, CommandType.StoredProcedure, "up_Gral_Obtener_Registros", prmParameter)
                    If Reader.HasRows Then
                        While Reader.Read
                            oGeneral = New clsBE_General
                            mintItem += 1
                            With oGeneral
                                .Id_Retorna = Reader("id")
                                .Descripcion_Retorna = Reader("descripcion").ToString
                                .Codigo_Retorna = Reader("codigo").ToString
                                .CodigoDescripcion_Retorna = Reader("codigodescripcion").ToString
                            End With
                            olstGeneral.Add(oGeneral)
                        End While
                    End If
                End Using
            Catch ex As Exception
                Throw ex
            End Try
            Return olstGeneral
        End Function
        ''' <summary>
        ''' Escrito por: 
        ''' Fecha Creacion:
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function Obtener_RegistrosDS(ByVal pGeneral As clsBE_General) As DataSet
            Dim oDSTablaDet As New DataSet
            Dim oGeneral As clsBE_General = Nothing
            Dim mintItem As Integer = 0
            Dim prmParameter(8) As SqlParameter

            prmParameter(0) = New SqlParameter("@pNombre_Tabla", SqlDbType.VarChar, 200)
            prmParameter(0).Value = IIf(IsNothing(pGeneral.NomTabla), "", pGeneral.NomTabla)

            prmParameter(1) = New SqlParameter("@pid_Retorna", SqlDbType.VarChar, 500)
            prmParameter(1).Value = IIf(IsNothing(pGeneral.Id_Retorna), "", pGeneral.Id_Retorna)

            prmParameter(2) = New SqlParameter("@pCodigo_Retorna", SqlDbType.VarChar, 500)
            prmParameter(2).Value = IIf(IsNothing(pGeneral.Codigo_Retorna), "", pGeneral.Codigo_Retorna)

            prmParameter(3) = New SqlParameter("@pDescripcion_Retorna", SqlDbType.VarChar, 500)
            prmParameter(3).Value = IIf(IsNothing(pGeneral.Descripcion_Retorna), "", pGeneral.Descripcion_Retorna)

            prmParameter(4) = New SqlParameter("@pPrimer_Valor", SqlDbType.VarChar, 200)
            prmParameter(4).Value = IIf(IsNothing(pGeneral.PrimerValor), "", pGeneral.PrimerValor)

            prmParameter(5) = New SqlParameter("@pNombre_Campo1", SqlDbType.VarChar, 200)
            prmParameter(5).Value = IIf(IsNothing(pGeneral.NomCampo1), "", pGeneral.NomCampo1)

            prmParameter(6) = New SqlParameter("@pValor_Campo1", SqlDbType.VarChar, 200)
            prmParameter(6).Value = IIf(IsNothing(pGeneral.ValCampo1), "", pGeneral.ValCampo1)

            prmParameter(7) = New SqlParameter("@pNombre_Campo2", SqlDbType.VarChar, 200)
            prmParameter(7).Value = IIf(IsNothing(pGeneral.NomCampo2), "", pGeneral.NomCampo2)

            prmParameter(8) = New SqlParameter("@pValor_Campo2", SqlDbType.VarChar, 200)
            prmParameter(8).Value = IIf(IsNothing(pGeneral.ValCampo2), "", pGeneral.ValCampo2)


             Try
                Using oDSTablaDet
                    oDSTablaDet = SqlHelper.ExecuteDataset(strCadenaConexion, CommandType.StoredProcedure, "up_Gral_Obtener_Registros", prmParameter)
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
        ''' Escrito por: 
        ''' Fecha Creacion:
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function Obtener_Correlativo(ByVal pGeneral As clsBE_General) As String
            Dim oDSgeneral As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(5) As SqlParameter

            prmParameter(0) = New SqlParameter("@pNombre_Tabla", SqlDbType.VarChar, 200)
            prmParameter(0).Value = IIf(IsNothing(pGeneral.NomTabla), "", pGeneral.NomTabla)

            prmParameter(1) = New SqlParameter("@pid_Retorna", SqlDbType.VarChar, 500)
            prmParameter(1).Value = IIf(IsNothing(pGeneral.Id_Retorna), "", pGeneral.Id_Retorna)

            prmParameter(2) = New SqlParameter("@pNombre_Campo1", SqlDbType.VarChar, 200)
            prmParameter(2).Value = IIf(IsNothing(pGeneral.NomCampo1), "", pGeneral.NomCampo1)

            prmParameter(3) = New SqlParameter("@pValor_Campo1", SqlDbType.VarChar, 200)
            prmParameter(3).Value = IIf(IsNothing(pGeneral.ValCampo1), "", pGeneral.ValCampo1)

            prmParameter(4) = New SqlParameter("@pNombre_Campo2", SqlDbType.VarChar, 200)
            prmParameter(4).Value = IIf(IsNothing(pGeneral.NomCampo2), "", pGeneral.NomCampo2)

            prmParameter(5) = New SqlParameter("@pValor_Campo2", SqlDbType.VarChar, 200)
            prmParameter(5).Value = IIf(IsNothing(pGeneral.ValCampo2), "", pGeneral.ValCampo2)


            Try
                Using oDSgeneral
                    oDSgeneral = SqlHelper.ExecuteDataset(strCadenaConexion, CommandType.StoredProcedure, "up_Gral_Obtener_Correlativo", prmParameter)
                    If Not oDSgeneral Is Nothing Then
                        If oDSgeneral.Tables.Count > 0 Then
                            If oDSgeneral.Tables(0).Rows.Count > 0 Then
                                Return oDSgeneral.Tables(0).Rows(0).Item("correlativo")
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex
            End Try
            Return ""
        End Function
        Public Function Validar_Usuario(ByVal pTablaDet As clsBE_TablaDet) As clsBE_TablaDet
            Dim oTablaDet As clsBE_TablaDet = Nothing
            Dim DSTablaDet As New DataSet
            Dim prmParameter(1) As SqlParameter
            prmParameter(0) = New SqlParameter("@ptablaDetId", SqlDbType.VarChar, 15)
            prmParameter(0).Value = IIf(IsNothing(pTablaDet.tablaDetId), "", pTablaDet.tablaDetId)
            prmParameter(1) = New SqlParameter("@pCampo0", SqlDbType.VarChar, 20)
            prmParameter(1).Value = IIf(IsNothing(pTablaDet.campo0), "", pTablaDet.campo0)
            Try
                Using DSTablaDet
                    DSTablaDet = SqlHelper.ExecuteDataset(strCadenaConexion, CommandType.StoredProcedure, "up_TablaDet_Validar_Usuario", prmParameter)
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
                                    oTablaDet.campo4 = .Item("campo4").ToString
                                    oTablaDet.campo5 = .Item("campo5").ToString
                                    oTablaDet.campo6 = .Item("campo6").ToString
                                    oTablaDet.campo7 = .Item("campo7").ToString
                                    oTablaDet.campo8 = .Item("campo8").ToString
                                    oTablaDet.campo9 = .Item("campo9").ToString
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
        Public Function ProcesarContabilidad(ByVal pTablaDet As clsBE_General) As Boolean
            Dim oDSContratoLote As New DataSet
            Dim prmParameter(3) As SqlParameter

            'prmParameter(0) = New SqlParameter("@Emp", SqlDbType.VarChar, 20)
            'prmParameter(0).Value = IIf(IsNothing(pTablaDet.ValCampo1), "", pTablaDet.ValCampo1)
            'prmParameter(0).Direction = ParameterDirection.Input
            'prmParameter(1) = New SqlParameter("@Per", SqlDbType.VarChar, 20)
            'prmParameter(1).Value = IIf(IsNothing(pTablaDet.ValCampo2), "", pTablaDet.ValCampo2)
            'prmParameter(1).Direction = ParameterDirection.Input

            'prmParameter(2) = New SqlParameter("@CodMovi", SqlDbType.VarChar, 1)
            'prmParameter(2).Value = IIf(IsNothing(pTablaDet.ValCampo3), "", pTablaDet.ValCampo3)
            'prmParameter(2).Direction = ParameterDirection.Input

            'prmParameter(3) = New SqlParameter("@CodClase", SqlDbType.VarChar, 100)
            'prmParameter(3).Value = IIf(IsNothing(pTablaDet.ValCampo4), "", pTablaDet.ValCampo4)
            'prmParameter(3).Direction = ParameterDirection.Input


            Try
                '  SqlHelper.ExecuteNonQuery(strCadenaConexion, CommandType.StoredProcedure, "pa_valorizador_to_contabilidad", prmParameter)

                Dim cnx As New SqlConnection(strCadenaConexion)
                Dim cmd As New SqlCommand()
                Dim da As New SqlDataAdapter()

                cmd.Connection = cnx
                cmd.CommandText = "pa_valorizador_to_contabilidad"
                cmd.Parameters.AddWithValue("@Emp", IIf(IsNothing(pTablaDet.ValCampo1), "", pTablaDet.ValCampo1))
                cmd.Parameters.AddWithValue("@Per", IIf(IsNothing(pTablaDet.ValCampo2), "", pTablaDet.ValCampo2))
                cmd.Parameters.AddWithValue("@CodMovi", IIf(IsNothing(pTablaDet.ValCampo3), "", pTablaDet.ValCampo3))
                cmd.Parameters.AddWithValue("@CodClase", IIf(IsNothing(pTablaDet.ValCampo4), "", pTablaDet.ValCampo4))

                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandTimeout = 200

                da.SelectCommand = cmd

                cnx.Open()
                da.Fill(oDSContratoLote)
                cnx.Close()

            Catch ex As Exception
                Throw ex
                Return False
            End Try

            Return True
        End Function

        '@01    AINI
        Public Function EliminarAsientoContableByFiltro(ByVal pTablaDet As clsBE_General) As Boolean
            Dim prmParameter(2) As SqlParameter

            prmParameter(0) = New SqlParameter("@Emp", SqlDbType.VarChar, 20)
            prmParameter(0).Value = pTablaDet.ValCampo1
            prmParameter(0).Direction = ParameterDirection.Input
            prmParameter(1) = New SqlParameter("@Per", SqlDbType.VarChar, 20)
            prmParameter(1).Value = pTablaDet.ValCampo2
            prmParameter(1).Direction = ParameterDirection.Input

            prmParameter(2) = New SqlParameter("@CodMovi", SqlDbType.VarChar, 1)
            prmParameter(2).Value = pTablaDet.ValCampo3
            prmParameter(2).Direction = ParameterDirection.Input

            Try
                SqlHelper.ExecuteNonQuery(strCadenaConexion, CommandType.StoredProcedure, "PA_EliminaAsientoConcar", prmParameter)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
            Return True
        End Function

        '@01    AFIN

        '@02    AINI
        Public Function Obtener_RegistrosToMatrizDS(ByVal pGeneral As clsBE_General) As DataSet
            Dim oDSTablaDet As New DataSet
            Dim oGeneral As clsBE_General = Nothing
            Dim prmParameter(2) As SqlParameter

            prmParameter(0) = New SqlParameter("@empresa", SqlDbType.VarChar, 20)
            prmParameter(0).Value = pGeneral.ValCampo1
            prmParameter(0).Direction = ParameterDirection.Input
            prmParameter(1) = New SqlParameter("@mes", SqlDbType.VarChar, 2)
            prmParameter(1).Value = pGeneral.ValCampo2
            prmParameter(1).Direction = ParameterDirection.Input

            prmParameter(2) = New SqlParameter("@anio", SqlDbType.VarChar, 2)
            prmParameter(2).Value = pGeneral.ValCampo3
            prmParameter(2).Direction = ParameterDirection.Input


            Try
                Using oDSTablaDet
                    oDSTablaDet = SqlHelper.ExecuteDataset(strCadenaConexion, CommandType.StoredProcedure, "PA_matrizcomecialResum", prmParameter)
                    If Not oDSTablaDet Is Nothing Then
                        If oDSTablaDet.Tables.Count > 0 Then
                            If oDSTablaDet.Tables(0).Rows.Count > 0 Then
                                Return oDSTablaDet
                            Else
                                oDSTablaDet = Nothing
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex
            End Try
            Return oDSTablaDet
        End Function
        '@01    AFIN

        '@02    AINI
        Public Function Obtener_RegistrosToVerificarConcarDS(ByVal pGeneral As clsBE_General) As DataSet
            Dim oDSTablaDet As New DataSet
            Dim oGeneral As clsBE_General = Nothing
            Dim prmParameter(2) As SqlParameter

            prmParameter(0) = New SqlParameter("@Emp", SqlDbType.VarChar, 20)
            prmParameter(0).Value = pGeneral.ValCampo1
            prmParameter(0).Direction = ParameterDirection.Input
            prmParameter(1) = New SqlParameter("@Per", SqlDbType.VarChar, 20)
            prmParameter(1).Value = pGeneral.ValCampo2
            prmParameter(1).Direction = ParameterDirection.Input

            prmParameter(2) = New SqlParameter("@CodMovi", SqlDbType.VarChar, 1)
            prmParameter(2).Value = pGeneral.ValCampo3
            prmParameter(2).Direction = ParameterDirection.Input


            Try
                Using oDSTablaDet
                    oDSTablaDet = SqlHelper.ExecuteDataset(strCadenaConexion, CommandType.StoredProcedure, "PA_ValidaAsientoPrevio", prmParameter)
                    If Not oDSTablaDet Is Nothing Then
                        If oDSTablaDet.Tables.Count > 0 Then
                            If oDSTablaDet.Tables(0).Rows.Count > 0 Then
                                Return oDSTablaDet
                            Else
                                oDSTablaDet = Nothing
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex
            End Try
            Return oDSTablaDet
        End Function
        '@02    AFIN

        Public Function Obtener_AsientosConcarDS(ByVal pGeneral As clsBE_General) As DataSet
            Dim oDSTablaDet As New DataSet
            Dim oGeneral As clsBE_General = Nothing
            Dim prmParameter(2) As SqlParameter

            prmParameter(0) = New SqlParameter("@Emp", SqlDbType.VarChar, 20)
            prmParameter(0).Value = pGeneral.ValCampo1
            prmParameter(0).Direction = ParameterDirection.Input
            prmParameter(1) = New SqlParameter("@Per", SqlDbType.VarChar, 20)
            prmParameter(1).Value = pGeneral.ValCampo2
            prmParameter(1).Direction = ParameterDirection.Input

            prmParameter(2) = New SqlParameter("@CodMovi", SqlDbType.VarChar, 1)
            prmParameter(2).Value = pGeneral.ValCampo3
            prmParameter(2).Direction = ParameterDirection.Input


            Try
                Using oDSTablaDet
                    oDSTablaDet = SqlHelper.ExecuteDataset(strCadenaConexion, CommandType.StoredProcedure, "PA_ValidaExisteAsiento", prmParameter)
                    If Not oDSTablaDet Is Nothing Then
                        If oDSTablaDet.Tables.Count > 0 Then
                            If oDSTablaDet.Tables(0).Rows.Count > 0 Then
                                Return oDSTablaDet
                            Else
                                oDSTablaDet = Nothing
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex
            End Try
            Return oDSTablaDet
        End Function

    End Class


#End Region
End Namespace
