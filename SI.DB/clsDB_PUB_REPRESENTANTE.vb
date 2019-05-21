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
    Public Class clsDB_PUB_REPRESENTANTERO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionEN")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("EN")
        End Sub



        Public Function LeerListaToDSPUB_REPRESENTANTE(ByVal oPub_Representante As clsBE_PUB_REPRESENTANTE) As DataSet
            Dim oDSPUB_REPRESENTANTE As New DataSet
            Try
                Dim prmParameter(0) As SqlParameter

                prmParameter(0) = New SqlParameter("@IDPERSONA", SqlDbType.VarChar)
                prmParameter(0).Value = IIf(IsNothing(oPub_Representante.IDPERSONA), "", oPub_Representante.IDPERSONA)


                Return SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_pub_representante", prmParameter)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

#End Region

End Namespace


