


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
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la TB_LOCALIDAD TB_LOCALIDAD
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsDB_TB_LOCALIDADTX

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
    ''' Proposito: Obtiene los valores de la TB_LOCALIDAD TB_LOCALIDAD
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsDB_TB_LOCALIDADRO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionEN")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("EN")
        End Sub
       


        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:46
        ''' Proposito: Obtiene la lista de registros
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaTB_LOCALIDAD() As List(Of clsBE_TB_LOCALIDAD)
            Dim olstTB_LOCALIDAD As New List(Of clsBE_TB_LOCALIDAD)
            Dim oTB_LOCALIDAD As clsBE_TB_LOCALIDAD = Nothing
            Dim mintItem As Integer = 0

            oTB_LOCALIDAD = New clsBE_TB_LOCALIDAD
            oTB_LOCALIDAD.ID_LOCALIDAD = ""
            oTB_LOCALIDAD.DES_LOCALIDAD = "[Seleccione]"
            olstTB_LOCALIDAD.Add(oTB_LOCALIDAD)
            Try
                Using Reader As SqlDataReader = SqlHelper.ExecuteReader(CadenaConexion, CommandType.StoredProcedure, "up_LOCALIDAD_sel")
                    If Reader.HasRows Then
                        While Reader.Read
                            oTB_LOCALIDAD = New clsBE_TB_LOCALIDAD
                            mintItem += 1
                            With oTB_LOCALIDAD
                                .Item = mintItem

                                .ID_LOCALIDAD = Reader("ID_LOCALIDAD").ToString
                                .DES_LOCALIDAD = Reader("DES_LOCALIDAD").ToString
                            End With
                            olstTB_LOCALIDAD.Add(oTB_LOCALIDAD)
                        End While
                    End If
                End Using
            Catch ex As Exception
                Throw ex
            End Try

            Return olstTB_LOCALIDAD

        End Function

      

    End Class
#End Region

End Namespace
