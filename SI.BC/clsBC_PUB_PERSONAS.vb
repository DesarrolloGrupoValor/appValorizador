Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:45
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_PUB_PERSONASTX
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsBC_PUB_PERSONASTX
        'Inherits ServicedComponent

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_PUB_PERSONASTX
        ''' Fecha Modificacion:
        ''' </summary>

        Private oDBPUB_PERSONASTX As clsDB_PUB_PERSONASTX
        Public oBEPUB_PERSONAS As clsBE_PUB_PERSONAS
        Public LstPUB_PERSONAS As New List(Of clsBE_PUB_PERSONAS)
        Public oDSPUB_PERSONAS As DataSet

        Sub New()
            oDBPUB_PERSONASTX = New clsDB_PUB_PERSONASTX
            oBEPUB_PERSONAS = New clsBE_PUB_PERSONAS
        End Sub

        Public Sub NuevaEntidad()
            oBEPUB_PERSONAS = New clsBE_PUB_PERSONAS
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
    Public Class clsBC_PUB_PERSONASRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Private oDBPUB_PERSONASRO As clsDB_PUB_PERSONASRO
        Public oBEPUB_PERSONAS As clsBE_PUB_PERSONAS
        Public LstPUB_PERSONAS As New List(Of clsBE_PUB_PERSONAS)
        Public oDSPUB_PERSONAS As New DataSet
        Public oDTPUB_PERSONAS As New DataTable


        Sub New()
            oDBPUB_PERSONASRO = New clsDB_PUB_PERSONASRO
            oBEPUB_PERSONAS = New clsBE_PUB_PERSONAS
        End Sub

        Public Sub NuevaEntidad()
            oBEPUB_PERSONAS = New clsBE_PUB_PERSONAS
        End Sub

        '' ''' <summary>
        '' ''' Escrito por: Martin Huaman
        '' ''' Fecha Creacion: 17/02/2011 16:58:45
        '' ''' Proposito: 
        '' ''' Fecha Modificacion:
        '' ''' </summary>
        '' '''
        ''Public Sub LeerPUB_PERSONAS()
        ''    Try
        ''        oBEPUB_PERSONAS = oDBPUB_PERSONASRO.LeerPUB_PERSONAS(oBEPUB_PERSONAS)
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
        Public Sub LeerListaPUB_PERSONAS(Optional ByVal sTipo As String = "", Optional ByVal sIDPERSONA As String = "")
            Try
                LstPUB_PERSONAS = oDBPUB_PERSONASRO.LeerListaPUB_PERSONAS(sTipo, sIDPERSONA)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        ''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function LeerListaToDSPUB_PERSONAS() As DataSet
            Try
                oDSPUB_PERSONAS = oDBPUB_PERSONASRO.LeerListaToDSPUB_PERSONAS(oBEPUB_PERSONAS)
                Return oDSPUB_PERSONAS
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
        ''Public Function DefinirPUB_PERSONASPUB_PERSONAS() As DataTable
        ''    Try
        ''        oDTPUB_PERSONAS = oDBPUB_PERSONASRO.DefinirPUB_PERSONASPUB_PERSONAS()
        ''        Return oDTPUB_PERSONAS
        ''    Catch ex As Exception
        ''        Throw ex
        ''    End Try
        ''End Function

    End Class
#End Region

End Namespace
