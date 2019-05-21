


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

    Public Class clsDB_AuditoriaDTX

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
        Public Function InsertarAuditoriaD(ByVal oLstTabla As List(Of clsBE_AuditoriaD)) As Boolean
            For Each oAuditoria As clsBE_AuditoriaD In oLstTabla
                Dim prmParameter(6) As SqlParameter

                prmParameter(0) = New SqlParameter("@BaseDatos", SqlDbType.VarChar, 50)
                prmParameter(0).Value = IIf(IsNothing(oAuditoria.BaseDatos), "", oAuditoria.BaseDatos)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@IdAuditoria", SqlDbType.Int)
                prmParameter(1).Value = IIf(IsNothing(oAuditoria.IdAuditoria), "", oAuditoria.IdAuditoria)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@IdMenu", SqlDbType.VarChar, 20)
                prmParameter(2).Value = IIf(IsNothing(oAuditoria.IdMenu), "", oAuditoria.IdMenu)
                prmParameter(2).Direction = ParameterDirection.Input

                prmParameter(3) = New SqlParameter("@IdAccion", SqlDbType.VarChar, 20)
                prmParameter(3).Value = IIf(IsNothing(oAuditoria.IdAccion), "", oAuditoria.IdAccion)
                prmParameter(3).Direction = ParameterDirection.Input

                prmParameter(4) = New SqlParameter("@NombreObjeto", SqlDbType.VarChar, 50)
                prmParameter(4).Value = IIf(IsNothing(oAuditoria.NombreObjeto), "", oAuditoria.NombreObjeto)
                prmParameter(4).Direction = ParameterDirection.Input

                prmParameter(5) = New SqlParameter("@Tabla", SqlDbType.VarChar, 50)
                prmParameter(5).Value = IIf(IsNothing(oAuditoria.Tabla), "", oAuditoria.Tabla)
                prmParameter(5).Direction = ParameterDirection.Input

                prmParameter(6) = New SqlParameter("@Condicion", SqlDbType.VarChar, 200)
                prmParameter(6).Value = IIf(IsNothing(oAuditoria.Condicion), "", oAuditoria.Condicion)
                prmParameter(6).Direction = ParameterDirection.Input
                Try
                    SqlHelper.ExecuteNonQuery(oAuditoria.CadenaConexion, CommandType.StoredProcedure, "[up_AuditoriaD_Ins]", prmParameter)
                    'SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "[up_AuditoriaD_Ins]", prmParameter)
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
    ''' Proposito: Obtiene los valores de la tabla Tabla
    ''' Fecha Modificacion:
    ''' </summary>
	'''
    <Serializable()> _
    Public Class clsDB_AuditoriaDRO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub


    End Class
#End Region
    
End Namespace
