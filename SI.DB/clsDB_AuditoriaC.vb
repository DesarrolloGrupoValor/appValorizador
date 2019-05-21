


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
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla Tabla
    ''' Fecha Modificacion:
    ''' </summary>
	'''

    Public Class clsDB_AuditoriaCTX

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: Metodo de Insercci?n de Datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function InsertarAuditoriaC(ByVal oLstTabla As List(Of clsBE_AuditoriaC)) As Integer
            For Each oAuditoria As clsBE_AuditoriaC In oLstTabla
                Dim prmParameter(3) As SqlParameter

                prmParameter(0) = New SqlParameter("@IdModulo", SqlDbType.Int)
                prmParameter(0).Value = IIf(IsNothing(oAuditoria.IdModulo), "", oAuditoria.IdModulo)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@IdUsuario", SqlDbType.VarChar, 20)
                prmParameter(1).Value = IIf(IsNothing(oAuditoria.IdUsuario), "", oAuditoria.IdUsuario)
                prmParameter(1).Direction = ParameterDirection.Input

                prmParameter(2) = New SqlParameter("@UsuarioWin", SqlDbType.VarChar, 20)
                prmParameter(2).Value = IIf(IsNothing(oAuditoria.UsuarioWin), "", oAuditoria.UsuarioWin)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@UsuarioIp", SqlDbType.VarChar, 20)
                prmParameter(3).Value = IIf(IsNothing(oAuditoria.UsuarioIp), "", oAuditoria.UsuarioIp)
                prmParameter(3).Direction = ParameterDirection.Input
                Try
                    'Return SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_AuditoriaC_Ins", prmParameter)



                    Return SqlHelper.ExecuteScalar(CadenaConexion, CommandType.StoredProcedure, "up_AuditoriaC_Ins", prmParameter)
                Catch ex As Exception
                    Throw ex
                    Return 0
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
    ''' Proposito: Obtiene los valores de la tabla Tabla
    ''' Fecha Modificacion:
    ''' </summary>
	'''
    <Serializable()> _
    Public Class clsDB_AuditoriaRO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
       

    End Class
#End Region
    
End Namespace
