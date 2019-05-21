Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports SI.BE
Imports SI.UT
Imports Microsoft.ApplicationBlocks.Data

Namespace SI.DB

#Region "Clase Lectura"
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:46
    ''' Proposito: Obtiene los valores de la FINANCIANDO_PRELIQ FINANCIANDO_PRELIQ
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsDB_TB_TABLAS_GENRO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionEN")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("EN")
        End Sub


        Public Function LeerListaToDSTB_TABLAS_GEN(ByVal pTB_TABLAS_GEN As clsBE_TB_TABLAS_GEN) As DataSet
            Dim oDSTB_TABLAS_GEN As New DataSet
            Dim mintItem As Integer = 0
            Try
                Dim prmParameter(1) As SqlParameter

                prmParameter(0) = New SqlParameter("@clave", SqlDbType.VarChar, 2)
                prmParameter(0).Value = IIf(IsNothing(pTB_TABLAS_GEN.clave), "", pTB_TABLAS_GEN.clave)

                prmParameter(1) = New SqlParameter("@codigo", SqlDbType.VarChar, 3)
                prmParameter(1).Value = IIf(IsNothing(pTB_TABLAS_GEN.codigo), "", pTB_TABLAS_GEN.codigo)

                Using oDSTB_TABLAS_GEN
                    oDSTB_TABLAS_GEN = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_TB_TABLAS_GEN_sel", prmParameter)
                    If Not oDSTB_TABLAS_GEN Is Nothing Then
                        If oDSTB_TABLAS_GEN.Tables.Count > 0 Then
                            If oDSTB_TABLAS_GEN.Tables(0).Rows.Count > 0 Then
                                Return oDSTB_TABLAS_GEN
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSTB_TABLAS_GEN

        End Function


    End Class
#End Region

End Namespace
