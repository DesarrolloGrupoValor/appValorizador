


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

    Public Class clsDB_Precio_DiarioTX

        Private Shared CadenaConexion As String


        Public SqlDataAdapter As System.Data.SqlClient.SqlDataAdapter


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
        Public Function InsertarPrecio_Diario(ByVal oBE_tbPrecio_Diario As clsBE_Precio_Diario) As Boolean

            Dim prmParameter(6) As SqlParameter

            prmParameter(0) = New SqlParameter("@fecha", SqlDbType.DateTime)
            prmParameter(0).Value = IIf(IsNothing(oBE_tbPrecio_Diario.fecha), "", oBE_tbPrecio_Diario.fecha)

            prmParameter(1) = New SqlParameter("@elemento", SqlDbType.VarChar, 10)
            prmParameter(1).Value = IIf(IsNothing(oBE_tbPrecio_Diario.elemento), "", oBE_tbPrecio_Diario.elemento)

            prmParameter(2) = New SqlParameter("@precio1", SqlDbType.Decimal)
            prmParameter(2).Value = IIf(IsNothing(oBE_tbPrecio_Diario.precio1), 0, oBE_tbPrecio_Diario.precio1)

            prmParameter(3) = New SqlParameter("@precio2", SqlDbType.Decimal)
            prmParameter(3).Value = IIf(IsNothing(oBE_tbPrecio_Diario.precio2), 0, oBE_tbPrecio_Diario.precio2)

            prmParameter(4) = New SqlParameter("@precio3", SqlDbType.Decimal)
            prmParameter(4).Value = IIf(IsNothing(oBE_tbPrecio_Diario.precio3), 0, oBE_tbPrecio_Diario.precio3)

            prmParameter(5) = New SqlParameter("@precio4", SqlDbType.Decimal)
            prmParameter(5).Value = IIf(IsNothing(oBE_tbPrecio_Diario.precio4), 0, oBE_tbPrecio_Diario.precio4)

            'prmParameter(6) = New SqlParameter("@activo", SqlDbType.Int)
            'prmParameter(6).Value = IIf(IsNothing(oBE_tbPrecio_Diario.activo), 0, oBE_tbPrecio_Diario.activo)

            prmParameter(6) = New SqlParameter("@uc", SqlDbType.VarChar, 10)
            prmParameter(6).Value = IIf(IsNothing(oBE_tbPrecio_Diario.uc), "", oBE_tbPrecio_Diario.uc)

            Try
                SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "upPrecio_Diario_Ins", prmParameter)

            Catch ex As Exception
                Throw ex
                Return False
            End Try

            Return True
        End Function


        Public Function ModificarPrecio_Diario(ByVal oBE_tbPrecio_Diario As clsBE_Precio_Diario) As Boolean

            Dim prmParameter(8) As SqlParameter

            prmParameter(0) = New SqlParameter("@IdPrecioDiario", SqlDbType.Int)
            prmParameter(0).Value = IIf(IsNothing(oBE_tbPrecio_Diario.IdPrecioDiario), 0, oBE_tbPrecio_Diario.IdPrecioDiario)

            prmParameter(1) = New SqlParameter("@fecha", SqlDbType.DateTime)
            prmParameter(1).Value = IIf(IsNothing(oBE_tbPrecio_Diario.fecha), "", oBE_tbPrecio_Diario.fecha)

            prmParameter(2) = New SqlParameter("@elemento", SqlDbType.VarChar, 10)
            prmParameter(2).Value = IIf(IsNothing(oBE_tbPrecio_Diario.elemento), "", oBE_tbPrecio_Diario.elemento)

            prmParameter(3) = New SqlParameter("@precio1", SqlDbType.Decimal)
            prmParameter(3).Value = IIf(IsNothing(oBE_tbPrecio_Diario.precio1), 0, oBE_tbPrecio_Diario.precio1)

            prmParameter(4) = New SqlParameter("@precio2", SqlDbType.Decimal)
            prmParameter(4).Value = IIf(IsNothing(oBE_tbPrecio_Diario.precio2), 0, oBE_tbPrecio_Diario.precio2)

            prmParameter(5) = New SqlParameter("@precio3", SqlDbType.Decimal)
            prmParameter(5).Value = IIf(IsNothing(oBE_tbPrecio_Diario.precio3), 0, oBE_tbPrecio_Diario.precio3)

            prmParameter(6) = New SqlParameter("@precio4", SqlDbType.Decimal)
            prmParameter(6).Value = IIf(IsNothing(oBE_tbPrecio_Diario.precio4), 0, oBE_tbPrecio_Diario.precio4)

            prmParameter(7) = New SqlParameter("@activo", SqlDbType.Int)
            prmParameter(7).Value = IIf(IsNothing(oBE_tbPrecio_Diario.activo), 0, oBE_tbPrecio_Diario.activo)

            prmParameter(8) = New SqlParameter("@um", SqlDbType.VarChar, 10)
            prmParameter(8).Value = IIf(IsNothing(oBE_tbPrecio_Diario.um), "", oBE_tbPrecio_Diario.um)

            Try
                SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "upPrecio_Diario_Upd", prmParameter)

            Catch ex As Exception
                Throw ex
                Return False
            End Try

            Return True
        End Function

        Public Function EliminaPrecio_Diario(ByVal oBE_tbPrecio_Diario As clsBE_Precio_Diario) As Boolean

            Dim prmParameter(0) As SqlParameter

            prmParameter(0) = New SqlParameter("@IdPrecioDiario", SqlDbType.Int)
            prmParameter(0).Value = IIf(IsNothing(oBE_tbPrecio_Diario.IdPrecioDiario), 0, oBE_tbPrecio_Diario.IdPrecioDiario)

            Try
                SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "upPrecio_Diario_Del", prmParameter)

            Catch ex As Exception
                Throw ex
                Return False
            End Try

            Return True
        End Function



        Public Function MasivoPrecio_Diario(ByVal dtPrecio_Diario As DataTable) As DataTable

            Try
                Dim Sql As String = "select  IdPrecioDiario,	fecha, tipo, elemento, precio1, precio2, precio3, precio4, uc from tbprecio_diario WHERE TIPO = 'a'"
                SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(Sql, CadenaConexion)

                Dim SqlCommandBuilder As New System.Data.SqlClient.SqlCommandBuilder(SqlDataAdapter)
                SqlDataAdapter.Fill(dtPrecio_Diario)


                Return dtPrecio_Diario
            Catch ex As Exception
                Throw ex
                'Return False
            End Try

            'Return True
        End Function



    End Class
#End Region
    
#Region "Clase Lectura"
    <Serializable()> _
    Public Class clsDB_Precio_DiarioRO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
        


        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 21/04/2011 09:07:44 a.m.
        ''' Proposito: Obtiene la lista de registros
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaPrecio_Diario_Sel(ByVal oBE_tbPrecio_Diario As clsBE_Precio_Diario) As DataSet   'As List(Of clsBE_Precio_Diario)
            Dim oDSPrecio_Diario As New DataSet

            Try
                Dim prmParameter(0) As SqlParameter

                prmParameter(0) = New SqlParameter("@IdPrecioDiario", SqlDbType.Int)
                prmParameter(0).Value = IIf(IsNothing(oBE_tbPrecio_Diario.IdPrecioDiario), 0, oBE_tbPrecio_Diario.IdPrecioDiario)

                Using oDSPrecio_Diario
                    oDSPrecio_Diario = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "upPrecio_Diario_Sel", prmParameter)
                    If Not oDSPrecio_Diario Is Nothing Then
                        If oDSPrecio_Diario.Tables.Count > 0 Then
                            If oDSPrecio_Diario.Tables(0).Rows.Count > 0 Then
                                Return oDSPrecio_Diario
                            End If
                        End If
                    End If
                End Using

            Catch ex As Exception
                Throw ex
            End Try

            Return oDSPrecio_Diario

        End Function

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 21/04/2011 09:07:44 a.m.
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSPrecio_Diario_SelAll(ByVal sTipo As String) As DataSet
            Dim oDSPrecio_Diario As New DataSet

            Try

                Dim prmParameter(0) As SqlParameter

                prmParameter(0) = New SqlParameter("@tipo", SqlDbType.Char, 1)
                prmParameter(0).Value = sTipo 'IIf(IsNothing(oBE_tbPrecio_Diario.IdPrecioDiario), 0, oBE_tbPrecio_Diario.IdPrecioDiario)

                Using oDSPrecio_Diario
                    oDSPrecio_Diario = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "upPrecio_Diario_SelAll", prmParameter)
                    If Not oDSPrecio_Diario Is Nothing Then
                        If oDSPrecio_Diario.Tables.Count > 0 Then
                            If oDSPrecio_Diario.Tables(0).Rows.Count > 0 Then
                                Return oDSPrecio_Diario
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSPrecio_Diario

        End Function

        Public Function Precio_Diario_Valida(ByVal oBE_tbPrecio_Diario As clsBE_Precio_Diario) As Integer   'As List(Of clsBE_Precio_Diario)
            Try
                Dim prmParameter(1) As SqlParameter

                prmParameter(0) = New SqlParameter("@fecha", SqlDbType.DateTime)
                prmParameter(0).Value = IIf(IsNothing(oBE_tbPrecio_Diario.fecha), "1900-01-01", oBE_tbPrecio_Diario.fecha)

                prmParameter(1) = New SqlParameter("@elemento", SqlDbType.VarChar, 20)
                prmParameter(1).Value = IIf(IsNothing(oBE_tbPrecio_Diario.elemento), "", oBE_tbPrecio_Diario.elemento)

                Return SqlHelper.ExecuteScalar(CadenaConexion, CommandType.StoredProcedure, "upPrecio_Diario_valida", prmParameter)

            Catch ex As Exception
                Throw ex
            End Try

            Return 0

        End Function

    End Class

#End Region


End Namespace
