Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:45
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_COM_DEPOSITOSTX
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsBC_COM_DEPOSITOSTX
        'Inherits ServicedComponent

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_COM_DEPOSITOSTX
        ''' Fecha Modificacion:
        ''' </summary>

        Private oDBCOM_DEPOSITOSTX As clsDB_COM_DEPOSITOSTX
        Public oBECOM_DEPOSITOS As clsBE_COM_DEPOSITOS
        Public LstCOM_DEPOSITOS As New List(Of clsBE_COM_DEPOSITOS)
        Public oDSCOM_DEPOSITOS As DataSet

        Sub New()
            oDBCOM_DEPOSITOSTX = New clsDB_COM_DEPOSITOSTX
            oBECOM_DEPOSITOS = New clsBE_COM_DEPOSITOS
        End Sub

        Public Sub NuevaEntidad()
            oBECOM_DEPOSITOS = New clsBE_COM_DEPOSITOS
        End Sub

      

    End Class
#End Region

#Region "Clase Lectura"
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:45
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsBC_COM_DEPOSITOSRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Private oDBCOM_DEPOSITOSRO As clsDB_COM_DEPOSITOSRO
        Public oBECOM_DEPOSITOS As clsBE_COM_DEPOSITOS
        Public LstCOM_DEPOSITOS As New List(Of clsBE_COM_DEPOSITOS)
        Public oDSCOM_DEPOSITOS As New DataSet
        Public oDTCOM_DEPOSITOS As New DataTable


        Sub New()
            oDBCOM_DEPOSITOSRO = New clsDB_COM_DEPOSITOSRO
            oBECOM_DEPOSITOS = New clsBE_COM_DEPOSITOS
        End Sub

        Public Sub NuevaEntidad()
            oBECOM_DEPOSITOS = New clsBE_COM_DEPOSITOS
        End Sub

        '' ''' <summary>
        '' ''' Escrito por: Martin Huaman
        '' ''' Fecha Creacion: 17/02/2011 16:58:45
        '' ''' Proposito: 
        '' ''' Fecha Modificacion:
        '' ''' </summary>
        '' '''
        ''Public Sub LeerCOM_DEPOSITOS()
        ''    Try
        ''        oBECOM_DEPOSITOS = oDBCOM_DEPOSITOSRO.LeerCOM_DEPOSITOS(oBECOM_DEPOSITOS)
        ''    Catch ex As Exception
        ''        Throw ex
        ''    End Try
        ''End Sub

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Sub LeerListaCOM_DEPOSITOS()
            Try
                LstCOM_DEPOSITOS = oDBCOM_DEPOSITOSRO.LeerListaCOM_DEPOSITOS()
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        '' ''' <summary>
        '' ''' Escrito por:  Martin Huaman
        '' ''' Fecha Creacion:17/02/2011 16:58:45
        '' ''' Proposito: 
        '' ''' Fecha Modificacion:
        '' ''' </summary>
        '' '''
        Public Function LeerListaToDSCOM_DEPOSITOS() As DataSet
            Try
                oDSCOM_DEPOSITOS = oDBCOM_DEPOSITOSRO.LeerListaToDSCOM_DEPOSITOS(oBECOM_DEPOSITOS)
                Return oDSCOM_DEPOSITOS
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        '' ''' <summary>
        '' ''' Escrito por:  Martin Huaman
        '' ''' Fecha Creacion:17/02/2011 16:58:45
        '' ''' Proposito: 
        '' ''' Fecha Modificacion:
        '' ''' </summary>
        '' '''
        ''Public Function DefinirCOM_DEPOSITOSCOM_DEPOSITOS() As DataTable
        ''    Try
        ''        oDTCOM_DEPOSITOS = oDBCOM_DEPOSITOSRO.DefinirCOM_DEPOSITOSCOM_DEPOSITOS()
        ''        Return oDTCOM_DEPOSITOS
        ''    Catch ex As Exception
        ''        Throw ex
        ''    End Try
        ''End Function

    End Class
#End Region

End Namespace
