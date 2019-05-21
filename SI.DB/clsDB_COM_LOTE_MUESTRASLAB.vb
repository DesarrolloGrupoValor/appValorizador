

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
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la PUB_PERSONAS PUB_PERSONAS
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsDB_COM_LOTE_MUESTRASLABTX

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
    ''' Proposito: Obtiene los valores de la PUB_PERSONAS PUB_PERSONAS
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsDB_COM_LOTE_MUESTRASLABRO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionEN")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("EN")
        End Sub
       


        Public Function LeerListaToDSValidarLeyesFinales(ByVal oBE_COM_LOTE_MUESTRASLAB As clsBE_COM_LOTE_MUESTRASLAB) As DataSet
            Dim oDSCOM_LOTE_MUESTRASLAB As New DataSet
            'Dim mintItem As Integer = 0
            Dim prmParameter(1) As SqlParameter

            prmParameter(0) = New SqlParameter("@COD_LOTE", SqlDbType.VarChar, 20)
            prmParameter(0).Value = IIf(IsNothing(oBE_COM_LOTE_MUESTRASLAB.COD_LOTE), "", oBE_COM_LOTE_MUESTRASLAB.COD_LOTE)
            prmParameter(0).Direction = ParameterDirection.Input

            prmParameter(1) = New SqlParameter("@NRO_GUIA", SqlDbType.VarChar, 20)
            prmParameter(1).Value = IIf(IsNothing(oBE_COM_LOTE_MUESTRASLAB.NRO_GUIA), "", oBE_COM_LOTE_MUESTRASLAB.NRO_GUIA)
            prmParameter(1).Direction = ParameterDirection.Input

            Try
                Using oDSCOM_LOTE_MUESTRASLAB
                    oDSCOM_LOTE_MUESTRASLAB = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_valida_leyes_fianles", prmParameter)
                    If Not oDSCOM_LOTE_MUESTRASLAB Is Nothing Then
                        If oDSCOM_LOTE_MUESTRASLAB.Tables.Count > 0 Then
                            If oDSCOM_LOTE_MUESTRASLAB.Tables(0).Rows.Count > 0 Then
                                Return oDSCOM_LOTE_MUESTRASLAB
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSCOM_LOTE_MUESTRASLAB

        End Function


    End Class
#End Region

End Namespace
