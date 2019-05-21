


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

    Public Class clsDB_Rol_UsuarioTX

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub

        ' ''elimina todos los permisos
        ''Public Function EliminaRol_Usuario() As Boolean

        ''    Try
        ''        SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_Rol_Usuario_Del")

        ''    Catch ex As Exception
        ''        Throw ex
        ''        Return False
        ''    End Try

        ''    Return True
        ''End Function


        'ByVal oLstTablaDet As List(Of clsBE_TablaDet)
        'ByVal oBE_Rol_Usuario As clsBE_Rol_Usuario
        Public Function InsertaRol_Usuario(ByVal rolId As Integer, ByVal oLstRol_Usuario As List(Of clsBE_Rol_Usuario)) As Boolean

            Dim prmParameter1(0) As SqlParameter

            prmParameter1(0) = New SqlParameter("@rolId", SqlDbType.Int)
            prmParameter1(0).Value = IIf(IsNothing(rolId), 0, rolId)
            prmParameter1(0).Direction = ParameterDirection.Input

            SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_Rol_Usuario_Del", prmParameter1)

            For Each oBE_Rol_Usuario As clsBE_Rol_Usuario In oLstRol_Usuario
                Dim prmParameter(1) As SqlParameter

                prmParameter(0) = New SqlParameter("@rolId", SqlDbType.Int)
                prmParameter(0).Value = IIf(IsNothing(oBE_Rol_Usuario.rolId), 0, oBE_Rol_Usuario.rolId)
                prmParameter(0).Direction = ParameterDirection.Input

                prmParameter(1) = New SqlParameter("@usuarioId", SqlDbType.VarChar, 20)
                prmParameter(1).Value = IIf(IsNothing(oBE_Rol_Usuario.usuarioId), "", oBE_Rol_Usuario.usuarioId)
                prmParameter(1).Direction = ParameterDirection.Input

                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_Rol_Usuario_Ins", prmParameter)
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
    ''' Fecha Creacion: 17/02/2011 16:40:02
    ''' Proposito: Obtiene los valores de la tabla Liquidacion
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsDB_Rol_UsuarioRO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub




        Public Function LeerRol_UsuarioDS_SelAll() As DataSet
            Dim oDSRol_Usuario As New DataSet

            Try
                Using oDSRol_Usuario
                    oDSRol_Usuario = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "upRol_Usuario_SelAll")
                    If Not oDSRol_Usuario Is Nothing Then
                        If oDSRol_Usuario.Tables.Count > 0 Then
                            If oDSRol_Usuario.Tables(0).Rows.Count > 0 Then
                                Return oDSRol_Usuario
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSRol_Usuario

        End Function

        Public Function LeerRol_UsuarioDS_Sel(ByVal oRol_Usuario As clsBE_Rol_Usuario) As DataSet
            Dim oDSRol_Usuario As New DataSet

            Try
                Dim prmParameter(0) As SqlParameter
                prmParameter(0) = New SqlParameter("@usuarioId", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(oRol_Usuario.usuarioId), "", oRol_Usuario.usuarioId)


                Using oDSRol_Usuario
                    oDSRol_Usuario = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "upRol_Usuario_Sel", prmParameter)
                    If Not oDSRol_Usuario Is Nothing Then
                        If oDSRol_Usuario.Tables.Count > 0 Then
                            If oDSRol_Usuario.Tables(0).Rows.Count > 0 Then
                                Return oDSRol_Usuario
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSRol_Usuario

        End Function

    End Class

#End Region
    
End Namespace
