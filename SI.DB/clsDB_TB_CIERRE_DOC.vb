



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
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la TB_CIERRE_DOC TB_CIERRE_DOC
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsDB_TB_CIERRE_DOCTX

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionEN")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("EN")
        End Sub


        Public Function TB_CIERRE_DOC_INSERT(ByVal oBE_TB_CIERRE_DOC As List(Of clsBE_TB_CIERRE_DOC)) As Boolean
            For Each oTB_CIERRE_DOC As clsBE_TB_CIERRE_DOC In oBE_TB_CIERRE_DOC
                Dim prmParameter(2) As SqlParameter

                prmParameter(0) = New SqlParameter("@item_cierre", SqlDbType.Int)
                prmParameter(0).Value = IIf(IsNothing(oTB_CIERRE_DOC.Item_cierre), 0, oTB_CIERRE_DOC.Item_cierre)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@archivo", SqlDbType.VarChar, 200)
                prmParameter(1).Value = IIf(IsNothing(oTB_CIERRE_DOC.Archivo), "", oTB_CIERRE_DOC.Archivo)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@ruta", SqlDbType.VarChar, 200)
                prmParameter(2).Value = IIf(IsNothing(oTB_CIERRE_DOC.Ruta), "", oTB_CIERRE_DOC.Ruta)
                prmParameter(2).Direction = ParameterDirection.Input

                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_TB_CIERRE_DOC_ins", prmParameter)

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
    ''' Fecha Creacion: 17/02/2011 16:58:46
    ''' Proposito: Obtiene los valores de la TB_CIERRE_DOC TB_CIERRE_DOC
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsDB_TB_CIERRE_DOCRO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionEN")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("EN")
        End Sub
       

    End Class
#End Region

End Namespace
