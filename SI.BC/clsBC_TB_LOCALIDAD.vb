Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:45
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_TB_LOCALIDADTX
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsBC_TB_LOCALIDADTX
        'Inherits ServicedComponent

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_TB_LOCALIDADTX
        ''' Fecha Modificacion:
        ''' </summary>

        Private oDBTB_LOCALIDADTX As clsDB_TB_LOCALIDADTX
        Public oBETB_LOCALIDAD As clsBE_TB_LOCALIDAD
        Public LstTB_LOCALIDAD As New List(Of clsBE_TB_LOCALIDAD)
        Public oDSTB_LOCALIDAD As DataSet

        Sub New()
            oDBTB_LOCALIDADTX = New clsDB_TB_LOCALIDADTX
            oBETB_LOCALIDAD = New clsBE_TB_LOCALIDAD
        End Sub

        Public Sub NuevaEntidad()
            oBETB_LOCALIDAD = New clsBE_TB_LOCALIDAD
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
    Public Class clsBC_TB_LOCALIDADRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Private oDBTB_LOCALIDADRO As clsDB_TB_LOCALIDADRO
        Public oBETB_LOCALIDAD As clsBE_TB_LOCALIDAD
        Public LstTB_LOCALIDAD As New List(Of clsBE_TB_LOCALIDAD)
        Public oDSTB_LOCALIDAD As New DataSet
        Public oDTTB_LOCALIDAD As New DataTable


        Sub New()
            oDBTB_LOCALIDADRO = New clsDB_TB_LOCALIDADRO
            oBETB_LOCALIDAD = New clsBE_TB_LOCALIDAD
        End Sub

        Public Sub NuevaEntidad()
            oBETB_LOCALIDAD = New clsBE_TB_LOCALIDAD
        End Sub

        '' ''' <summary>
        '' ''' Escrito por: Martin Huaman
        '' ''' Fecha Creacion: 17/02/2011 16:58:45
        '' ''' Proposito: 
        '' ''' Fecha Modificacion:
        '' ''' </summary>
        '' '''
        ''Public Sub LeerTB_LOCALIDAD()
        ''    Try
        ''        oBETB_LOCALIDAD = oDBTB_LOCALIDADRO.LeerTB_LOCALIDAD(oBETB_LOCALIDAD)
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
        Public Sub LeerListaTB_LOCALIDAD()
            Try
                LstTB_LOCALIDAD = oDBTB_LOCALIDADRO.LeerListaTB_LOCALIDAD()
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
        ''Public Function LeerListaToDSTB_LOCALIDAD() As DataSet
        ''    Try
        ''        oDSTB_LOCALIDAD = oDBTB_LOCALIDADRO.LeerListaToDSTB_LOCALIDAD(oBETB_LOCALIDAD)
        ''        Return oDSTB_LOCALIDAD
        ''    Catch ex As Exception
        ''        Throw ex
        ''    End Try
        ''End Function
        '' ''' <summary>
        '' ''' Escrito por:  Martin Huaman
        '' ''' Fecha Creacion:17/02/2011 16:58:45
        '' ''' Proposito: 
        '' ''' Fecha Modificacion:
        '' ''' </summary>
        '' '''
        ''Public Function DefinirTB_LOCALIDADTB_LOCALIDAD() As DataTable
        ''    Try
        ''        oDTTB_LOCALIDAD = oDBTB_LOCALIDADRO.DefinirTB_LOCALIDADTB_LOCALIDAD()
        ''        Return oDTTB_LOCALIDAD
        ''    Catch ex As Exception
        ''        Throw ex
        ''    End Try
        ''End Function

    End Class
#End Region

End Namespace
