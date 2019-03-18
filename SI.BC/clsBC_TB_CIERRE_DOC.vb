Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:45
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_TB_CIERRE_DOCTX
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsBC_TB_CIERRE_DOCTX
        'Inherits ServicedComponent

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_TB_CIERRE_DOCTX
        ''' Fecha Modificacion:
        ''' </summary>

        Private oDBTB_CIERRE_DOCTX As clsDB_TB_CIERRE_DOCTX
        Public oBETB_CIERRE_DOC As clsBE_TB_CIERRE_DOC
        Public LstTB_CIERRE_DOC As New List(Of clsBE_TB_CIERRE_DOC)

        Public LstTB_CIERRE_DOC_INSERT As New List(Of clsBE_TB_CIERRE_DOC)
        'Public LstTB_CIERRE_DOC_UPDATE As New List(Of clsBE_TB_CIERRE_DOC)

        Public oDSTB_CIERRE_DOC As DataSet

        Sub New()
            oDBTB_CIERRE_DOCTX = New clsDB_TB_CIERRE_DOCTX
            oBETB_CIERRE_DOC = New clsBE_TB_CIERRE_DOC
        End Sub

        Public Sub NuevaEntidad()
            oBETB_CIERRE_DOC = New clsBE_TB_CIERRE_DOC
        End Sub

        Public Function TB_CIERRE_DOC_INSERT() As Boolean
            Try
                Return oDBTB_CIERRE_DOCTX.TB_CIERRE_DOC_INSERT(LstTB_CIERRE_DOC_INSERT)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function


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
    Public Class clsBC_TB_CIERRE_DOCRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Private oDBTB_CIERRE_DOCRO As clsDB_TB_CIERRE_DOCRO
        Public oBETB_CIERRE_DOC As clsBE_TB_CIERRE_DOC
        Public LstTB_CIERRE_DOC As New List(Of clsBE_TB_CIERRE_DOC)
        Public oDSTB_CIERRE_DOC As New DataSet
        Public oDTTB_CIERRE_DOC As New DataTable


        Sub New()
            oDBTB_CIERRE_DOCRO = New clsDB_TB_CIERRE_DOCRO
            oBETB_CIERRE_DOC = New clsBE_TB_CIERRE_DOC
        End Sub

        Public Sub NuevaEntidad()
            oBETB_CIERRE_DOC = New clsBE_TB_CIERRE_DOC
        End Sub

       

    End Class
#End Region

End Namespace
