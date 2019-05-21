


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
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la FINANCIANDO_CLI FINANCIANDO_CLI
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsDB_FINANCIANDO_CLITX

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
    ''' Proposito: Obtiene los valores de la FINANCIANDO_CLI FINANCIANDO_CLI
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsDB_FINANCIANDO_CLIRO
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
        Public Function LeerListaToDSFINANCIANDO_CLI(ByVal pFINANCIANDO_CLI As clsBE_FINANCIANDO_CLI) As DataSet
            Dim oDSFINANCIANDO_CLI As New DataSet
            Dim mintItem As Integer = 0
            Try
                Dim prmParameter(0) As SqlParameter
                prmParameter(0) = New SqlParameter("@proveedor", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(pFINANCIANDO_CLI.proveedor), "", pFINANCIANDO_CLI.proveedor)

                Using oDSFINANCIANDO_CLI
                    oDSFINANCIANDO_CLI = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "ups_FINANCIANDO_CLI", prmParameter)

                    If Not oDSFINANCIANDO_CLI Is Nothing Then
                        If oDSFINANCIANDO_CLI.Tables.Count > 0 Then
                            'If oDSFINANCIANDO_CLI.Tables("FINANCIANDO_CLI").Rows.Count > 0 Then
                            If oDSFINANCIANDO_CLI.Tables(0).Rows.Count > 0 Then
                                Return oDSFINANCIANDO_CLI
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSFINANCIANDO_CLI

        End Function


        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:46
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSPRESTAMO_CCH(ByVal pFINANCIANDO_CLI As clsBE_FINANCIANDO_CLI) As DataSet
            Dim oDSPRESTAMO_CCH As New DataSet
            Dim mintItem As Integer = 0
            Try
                Dim prmParameter(0) As SqlParameter
                prmParameter(0) = New SqlParameter("@proveedor", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(pFINANCIANDO_CLI.proveedor), "", pFINANCIANDO_CLI.proveedor)

                Using oDSPRESTAMO_CCH
                    oDSPRESTAMO_CCH = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "PA_prestamosCajaCh", prmParameter)

                    If Not oDSPRESTAMO_CCH Is Nothing Then
                        If oDSPRESTAMO_CCH.Tables.Count > 0 Then
                            'If oDSFINANCIANDO_CLI.Tables("FINANCIANDO_CLI").Rows.Count > 0 Then
                            If oDSPRESTAMO_CCH.Tables(0).Rows.Count > 0 Then
                                Return oDSPRESTAMO_CCH
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSPRESTAMO_CCH

        End Function

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:46
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSPRESTAMO_COM(ByVal pFINANCIANDO_CLI As clsBE_FINANCIANDO_CLI) As DataSet
            Dim oDSPRESTAMO_COM As New DataSet
            Dim mintItem As Integer = 0
            Try
                Dim prmParameter(1) As SqlParameter
                prmParameter(0) = New SqlParameter("@ls_proveedor", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(pFINANCIANDO_CLI.proveedor), "", pFINANCIANDO_CLI.proveedor)
                prmParameter(1) = New SqlParameter("@ls_empresa", SqlDbType.VarChar, 20)
                prmParameter(1).Value = IIf(IsNothing(pFINANCIANDO_CLI.empresa), "", pFINANCIANDO_CLI.empresa)



                Using oDSPRESTAMO_COM
                    oDSPRESTAMO_COM = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "sp_listado_prestamos_comerciales", prmParameter)

                    If Not oDSPRESTAMO_COM Is Nothing Then
                        If oDSPRESTAMO_COM.Tables.Count > 0 Then
                            'If oDSFINANCIANDO_CLI.Tables("FINANCIANDO_CLI").Rows.Count > 0 Then
                            If oDSPRESTAMO_COM.Tables(0).Rows.Count > 0 Then
                                Return oDSPRESTAMO_COM
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSPRESTAMO_COM

        End Function



    End Class
#End Region

End Namespace
