


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
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la TB_BENEFICIARIO_CCHICA TB_BENEFICIARIO_CCHICA
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsDB_TB_BENEFICIARIO_CCHICATX

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
    ''' Proposito: Obtiene los valores de la TB_BENEFICIARIO_CCHICA TB_BENEFICIARIO_CCHICA
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsDB_TB_BENEFICIARIO_CCHICARO
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
        Public Function LeerListaToDSTB_BENEFICIARIO_CCHICA(ByVal pTB_BENEFICIARIO_CCHICA As clsBE_TB_BENEFICIARIO_CCHICA) As DataSet
            Dim oDSTB_BENEFICIARIO_CCHICA As New DataSet
            Dim mintItem As Integer = 0
            Try
                Dim prmParameter(0) As SqlParameter
                prmParameter(0) = New SqlParameter("@EMPRESA", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(pTB_BENEFICIARIO_CCHICA.EMPRESA), "", pTB_BENEFICIARIO_CCHICA.EMPRESA)

                Using oDSTB_BENEFICIARIO_CCHICA
                    oDSTB_BENEFICIARIO_CCHICA = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "UPS_BENEFICIARIO_CCHICA", prmParameter)

                    If Not oDSTB_BENEFICIARIO_CCHICA Is Nothing Then
                        If oDSTB_BENEFICIARIO_CCHICA.Tables.Count > 0 Then
                            'If oDSTB_BENEFICIARIO_CCHICA.Tables("TB_BENEFICIARIO_CCHICA").Rows.Count > 0 Then
                            If oDSTB_BENEFICIARIO_CCHICA.Tables(0).Rows.Count > 0 Then
                                Return oDSTB_BENEFICIARIO_CCHICA
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSTB_BENEFICIARIO_CCHICA

        End Function



    End Class
#End Region

End Namespace
