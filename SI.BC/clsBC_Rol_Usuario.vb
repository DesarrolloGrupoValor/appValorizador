Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:40:01
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_Rol_UsuarioTX
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsBC_Rol_UsuarioTX

        Private oDBRol_UsuarioTX As clsDB_Rol_UsuarioTX
        Public oBERol_Usuario As clsBE_Rol_Usuario
        Public LstRol_Usuario As New List(Of clsBE_Rol_Usuario)
        Public oDSRol_Usuario As DataSet

        Sub New()
            oDBRol_UsuarioTX = New clsDB_Rol_UsuarioTX
            oBERol_Usuario = New clsBE_Rol_Usuario
        End Sub

        Public Sub NuevaEntidad()
            oBERol_Usuario = New clsBE_Rol_Usuario
        End Sub

        Public Function InsertaLiquidacionAdjunto(ByVal rolId As Integer) As Boolean
            Try
                Return oDBRol_UsuarioTX.InsertaRol_Usuario(rolId, LstRol_Usuario)
            Catch ex As Exception
                Throw ex
            End Try
        End Function



    End Class
#End Region

#Region "Clase Lectura"
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:40:01
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsBC_Rol_UsuarioRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:40:01
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Private oDBRol_UsuarioRO As clsDB_Rol_UsuarioRO
        Public oBERol_Usuario As clsBE_Rol_Usuario
        Public LstRol_Usuario As New List(Of clsBE_Rol_Usuario)
        Public oDSRol_Usuario As New DataSet
        Public oDTRol_Usuario As New DataTable


        Sub New()
            oDBRol_UsuarioRO = New clsDB_Rol_UsuarioRO
            oBERol_Usuario = New clsBE_Rol_Usuario
        End Sub

        Public Sub NuevaEntidad()
            oBERol_Usuario = New clsBE_Rol_Usuario
        End Sub


        Public Sub LeerRol_UsuarioDS_SelAll()
            Try
                oDSRol_Usuario = oDBRol_UsuarioRO.LeerRol_UsuarioDS_SelAll()
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub LeerRol_UsuarioDS_Sel()
            Try
                oDSRol_Usuario = oDBRol_UsuarioRO.LeerRol_UsuarioDS_Sel(oBERol_Usuario)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

    End Class
#End Region

End Namespace
