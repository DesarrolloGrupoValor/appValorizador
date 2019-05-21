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

    Public Class clsBC_COM_LOTE_MUESTRASLABTX
        ''Inherits ServicedComponent

        ' ''' <summary>
        ' ''' Escrito por: Martin Huaman
        ' ''' Fecha Creacion: 17/02/2011 16:58:45
        ' ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_PUB_PERSONASTX
        ' ''' Fecha Modificacion:
        ' ''' </summary>

        'Private oDBPUB_PERSONASTX As clsDB_PUB_PERSONASTX
        'Public oBEPUB_PERSONAS As clsBE_PUB_PERSONAS
        'Public LstPUB_PERSONAS As New List(Of clsBE_PUB_PERSONAS)
        'Public oDSPUB_PERSONAS As DataSet

        'Sub New()
        '    oDBPUB_PERSONASTX = New clsDB_PUB_PERSONASTX
        '    oBEPUB_PERSONAS = New clsBE_PUB_PERSONAS
        'End Sub

        'Public Sub NuevaEntidad()
        '    oBEPUB_PERSONAS = New clsBE_PUB_PERSONAS
        'End Sub



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
    Public Class clsBC_COM_LOTE_MUESTRASLABRO
        
        Private oDBCOM_LOTE_MUESTRASLABRO As clsDB_COM_LOTE_MUESTRASLABRO
        Public oBECOM_LOTE_MUESTRASLAB As clsBE_COM_LOTE_MUESTRASLAB
        Public oDSCOM_LOTE_MUESTRASLAB As New DataSet
       
        Sub New()
            oDBCOM_LOTE_MUESTRASLABRO = New clsDB_COM_LOTE_MUESTRASLABRO
            oBECOM_LOTE_MUESTRASLAB = New clsBE_COM_LOTE_MUESTRASLAB
        End Sub

        Public Sub NuevaEntidad()
            oBECOM_LOTE_MUESTRASLAB = New clsBE_COM_LOTE_MUESTRASLAB
        End Sub

        Public Function LeerListaToDSValidarLeyesFinales() As DataSet
            Try
                oDSCOM_LOTE_MUESTRASLAB = oDBCOM_LOTE_MUESTRASLABRO.LeerListaToDSValidarLeyesFinales(oBECOM_LOTE_MUESTRASLAB)
                Return oDSCOM_LOTE_MUESTRASLAB
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class
#End Region

End Namespace
