


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
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla TB_FJ_APLICACION
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsDB_TB_FJ_APLICACIONTX

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionEN")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("EN")
        End Sub
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 24/04/2011 10:54:50 a.m.
        ''' Proposito: Metodo de Insercci?n de Datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function InsertarTB_FJ_APLICACION(ByVal oLstTB_FJ_APLICACION As List(Of clsBE_TB_FJ_APLICACION)) As Boolean
            For Each oTB_FJ_APLICACION As clsBE_TB_FJ_APLICACION In oLstTB_FJ_APLICACION
                Dim prmParameter(8) As SqlParameter

                prmParameter(0) = New SqlParameter("@oc", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(oTB_FJ_APLICACION.oc), "", oTB_FJ_APLICACION.oc)
                prmParameter(0).Direction = ParameterDirection.Input

                prmParameter(1) = New SqlParameter("@contratoloteid", SqlDbType.VarChar, 20)
                prmParameter(1).Value = IIf(IsNothing(oTB_FJ_APLICACION.contratoloteid), "", oTB_FJ_APLICACION.contratoloteid)
                prmParameter(1).Direction = ParameterDirection.Input

                prmParameter(2) = New SqlParameter("@liquidacionid", SqlDbType.VarChar, 20)
                prmParameter(2).Value = IIf(IsNothing(oTB_FJ_APLICACION.liquidacionid), "", oTB_FJ_APLICACION.liquidacionid)
                prmParameter(2).Direction = ParameterDirection.Input

                prmParameter(3) = New SqlParameter("@cantidad", SqlDbType.Decimal)
                prmParameter(3).Value = IIf(IsNothing(oTB_FJ_APLICACION.cantidad), 0, oTB_FJ_APLICACION.cantidad)
                prmParameter(3).Direction = ParameterDirection.Input

                prmParameter(4) = New SqlParameter("@precio", SqlDbType.Decimal)
                prmParameter(4).Value = IIf(IsNothing(oTB_FJ_APLICACION.precio), 0, oTB_FJ_APLICACION.precio)
                prmParameter(4).Direction = ParameterDirection.Input

                prmParameter(5) = New SqlParameter("@usereg", SqlDbType.VarChar, 20)
                prmParameter(5).Value = IIf(IsNothing(oTB_FJ_APLICACION.usereg), "", oTB_FJ_APLICACION.usereg)
                prmParameter(5).Direction = ParameterDirection.Input

                prmParameter(6) = New SqlParameter("@localizador", SqlDbType.VarChar, 10)
                prmParameter(6).Value = IIf(IsNothing(oTB_FJ_APLICACION.localizador), "", oTB_FJ_APLICACION.localizador)
                prmParameter(6).Direction = ParameterDirection.Input

                prmParameter(7) = New SqlParameter("@contrato", SqlDbType.VarChar, 10)
                prmParameter(7).Value = IIf(IsNothing(oTB_FJ_APLICACION.contrato), "", oTB_FJ_APLICACION.contrato)
                prmParameter(7).Direction = ParameterDirection.Input

                prmParameter(8) = New SqlParameter("@id", SqlDbType.TinyInt)
                prmParameter(8).Value = IIf(IsNothing(oTB_FJ_APLICACION.id), "", oTB_FJ_APLICACION.id)
                prmParameter(8).Direction = ParameterDirection.Input

                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_FJ_APLICACION_Ins", prmParameter)
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
        Public Function ModificarTB_FJ_APLICACION(ByVal oLstTB_FJ_APLICACION As List(Of clsBE_TB_FJ_APLICACION)) As Boolean
            For Each oTB_FJ_APLICACION As clsBE_TB_FJ_APLICACION In oLstTB_FJ_APLICACION
                Dim prmParameter(32) As SqlParameter
               
                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_FJ_APLICACION_Upd", prmParameter)
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
        Public Function EliminarTB_FJ_APLICACION(ByVal oLstTB_FJ_APLICACION As List(Of clsBE_TB_FJ_APLICACION)) As Boolean
            For Each oTB_FJ_APLICACION As clsBE_TB_FJ_APLICACION In oLstTB_FJ_APLICACION
                Dim prmParameter(4) As SqlParameter


                prmParameter(0) = New SqlParameter("@oc", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(oTB_FJ_APLICACION.oc), "", oTB_FJ_APLICACION.oc)
                prmParameter(0).Direction = ParameterDirection.Input

                prmParameter(1) = New SqlParameter("@usereg", SqlDbType.VarChar, 20)
                prmParameter(1).Value = IIf(IsNothing(oTB_FJ_APLICACION.usereg), "", oTB_FJ_APLICACION.usereg)
                prmParameter(1).Direction = ParameterDirection.Input

                prmParameter(2) = New SqlParameter("@id", SqlDbType.TinyInt)
                prmParameter(2).Value = IIf(IsNothing(oTB_FJ_APLICACION.id), "", oTB_FJ_APLICACION.id)
                prmParameter(2).Direction = ParameterDirection.Input

                prmParameter(3) = New SqlParameter("@estado", SqlDbType.Char, 1)
                prmParameter(3).Value = IIf(IsNothing(oTB_FJ_APLICACION.estado), "", oTB_FJ_APLICACION.estado)
                prmParameter(3).Direction = ParameterDirection.Input

                prmParameter(4) = New SqlParameter("@tipoFijacion", SqlDbType.TinyInt)
                prmParameter(4).Value = IIf(IsNothing(oTB_FJ_APLICACION.TIPOFIJACION), 0, oTB_FJ_APLICACION.TIPOFIJACION)
                prmParameter(4).Direction = ParameterDirection.Input

                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "UP_fj_aplicacion_DEL", prmParameter)
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
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 24/04/2011 10:54:50 a.m.
    ''' Proposito: Obtiene los valores de la tabla TB_FJ_APLICACION
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsDB_TB_FJ_APLICACIONRO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("EN")
        End Sub
       


       

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 24/04/2011 10:54:50 a.m.
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSTB_FJ_APLICACION(ByVal pTB_FJ_APLICACION As clsBE_TB_FJ_APLICACION) As Dataset
            Dim oDSTB_FJ_APLICACION As New DataSet
            Dim mintItem As Integer = 0
            Dim prmParameter(1) As SqlParameter
            prmParameter(0) = New SqlParameter("@pcontratoLoteId", SqlDbType.varchar, 20)
            prmParameter(0).Value = IIf(IsNothing(pTB_FJ_APLICACION.contratoLoteId), "", pTB_FJ_APLICACION.contratoLoteId)
            prmParameter(1) = New SqlParameter("@pliquidacionId", SqlDbType.VarChar, 20)
            prmParameter(1).Value = IIf(IsNothing(pTB_FJ_APLICACION.liquidacionid), "", pTB_FJ_APLICACION.liquidacionid)
            Try

                Using oDSTB_FJ_APLICACION
                    oDSTB_FJ_APLICACION = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_TB_FJ_APLICACION_Sell", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_TB_FJ_APLICACION_Sellst", oDSTB_FJ_APLICACION, New String() {"TB_FJ_APLICACION"}, prmParameter)
                    If Not oDSTB_FJ_APLICACION Is Nothing Then
                        If oDSTB_FJ_APLICACION.Tables.Count > 0 Then
                            'If oDSTB_FJ_APLICACION.Tables("TB_FJ_APLICACION").Rows.Count > 0 Then
                            If oDSTB_FJ_APLICACION.Tables(0).Rows.Count > 0 Then
                                Return oDSTB_FJ_APLICACION
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSTB_FJ_APLICACION

        End Function


       ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 24/04/2011 10:53:25 a.m.
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function DefineTablaFJ_APLICACION() As DataTable

            Try
                Dim dtFJ_APLICACION As New DataTable

                Dim oc As DataColumn = dtFJ_APLICACION.Columns.Add("oc", GetType(String))
                oc.AllowDBNull = False

                Dim contratoloteid As DataColumn = dtFJ_APLICACION.Columns.Add("contratoloteid", GetType(String))
                contratoloteid.AllowDBNull = True
                contratoloteid.DefaultValue = ""

                Dim liquidacionid As DataColumn = dtFJ_APLICACION.Columns.Add("liquidacionid", GetType(String))
                liquidacionid.AllowDBNull = True
                liquidacionid.DefaultValue = ""

                Dim cantidad As DataColumn = dtFJ_APLICACION.Columns.Add("cantidad", GetType(Decimal))
                cantidad.AllowDBNull = True
                cantidad.DefaultValue = ""

                Dim precio As DataColumn = dtFJ_APLICACION.Columns.Add("precio", GetType(Decimal))
                precio.AllowDBNull = True
                precio.DefaultValue = ""

                Dim usereg As DataColumn = dtFJ_APLICACION.Columns.Add("usereg", GetType(String))
                usereg.AllowDBNull = True
                usereg.DefaultValue = ""

                Dim localizador As DataColumn = dtFJ_APLICACION.Columns.Add("localizador", GetType(String))
                localizador.AllowDBNull = True
                localizador.DefaultValue = ""

                Dim contrato As DataColumn = dtFJ_APLICACION.Columns.Add("contrato", GetType(String))
                contrato.AllowDBNull = True
                contrato.DefaultValue = ""

                Dim estado As DataColumn = dtFJ_APLICACION.Columns.Add("estado", GetType(String))
                estado.AllowDBNull = True
                estado.DefaultValue = ""

                Dim ocid As DataColumn = dtFJ_APLICACION.Columns.Add("ocid", GetType(Integer))
                ocid.AllowDBNull = True
                ocid.DefaultValue = ""

                Return dtFJ_APLICACION
            Catch ex As Exception
                Throw ex
            End Try
        End Function


    End Class
#End Region

End Namespace
