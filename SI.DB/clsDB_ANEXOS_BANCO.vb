


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
    ''' Fecha Creacion: 17/02/2011 16:58:45
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la ANEXOS_BANCO ANEXOS_BANCO
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsDB_ANEXOS_BANCOTX

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionEN")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("EN")
        End Sub




    End Class
#End Region

#Region "Clase Lectura"
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:46
    ''' Proposito: Obtiene los valores de la ANEXOS_BANCO ANEXOS_BANCO
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsDB_ANEXOS_BANCORO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionEN")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("EN")

        End Sub





        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:46
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSANEXOS_BANCO(ByVal pANEXOS_BANCO As clsBE_ANEXOS_BANCO) As DataSet
            Dim oDSANEXOS_BANCO As New DataSet
            Dim mintItem As Integer = 0
            Try
                Dim prmParameter(1) As SqlParameter
                prmParameter(0) = New SqlParameter("@EMPRESA", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(pANEXOS_BANCO.EMPRESA), "", pANEXOS_BANCO.EMPRESA)
                prmParameter(1) = New SqlParameter("@ANEXO", SqlDbType.VarChar, 20)
                prmParameter(1).Value = IIf(IsNothing(pANEXOS_BANCO.ANEXO), "", pANEXOS_BANCO.ANEXO)

                Using oDSANEXOS_BANCO
                    oDSANEXOS_BANCO = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_ANEXOS_BANCO", prmParameter)

                    If Not oDSANEXOS_BANCO Is Nothing Then
                        If oDSANEXOS_BANCO.Tables.Count > 0 Then
                            'If oDSANEXOS_BANCO.Tables("ANEXOS_BANCO").Rows.Count > 0 Then
                            If oDSANEXOS_BANCO.Tables(0).Rows.Count > 0 Then
                                Return oDSANEXOS_BANCO
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSANEXOS_BANCO

        End Function



    End Class
#End Region

End Namespace
