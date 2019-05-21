Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Lectura"
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:40:01
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''   

    <Serializable()> _
        Public Class clsBC_TB_REPRESENTANTE
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:40:01
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Private oDBPub_REPRESENTANTERO As clsDB_PUB_REPRESENTANTERO
        Public oBEPub_Representante As clsBE_PUB_REPRESENTANTE
        Public LstPub_Representante As New List(Of clsBE_PUB_REPRESENTANTE)
        Public oDSPub_Representante As New DataSet
        Public oDTPub_Representante As New DataTable


        Sub New()
            oDBPub_REPRESENTANTERO = New clsDB_PUB_REPRESENTANTERO
            oBEPub_Representante = New clsBE_PUB_REPRESENTANTE
        End Sub

        Public Sub NuevaEntidad()
            oBEPub_Representante = New clsBE_PUB_REPRESENTANTE
        End Sub

        Public Sub LeerPub_RepresentanteDS_Sel()
            Try
                oDSPub_Representante = oDBPub_REPRESENTANTERO.LeerListaToDSPUB_REPRESENTANTE(oBEPub_Representante)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

    End Class
#End Region

 

End Namespace

