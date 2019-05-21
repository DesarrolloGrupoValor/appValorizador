Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC



#Region "Clase Lectura"
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:45
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsBC_TB_TABLAS_GENRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Private oDBTB_TABLAS_GENRO As clsDB_TB_TABLAS_GENRO
        Public oBETB_TABLAS_GEN As clsBE_TB_TABLAS_GEN
        Public LstTB_TABLAS_GEN As New List(Of clsBE_TB_TABLAS_GEN)
        Public oDSTB_TABLAS_GEN As New DataSet
        Public oDTTB_TABLAS_GEN As New DataTable


        Sub New()
            oDBTB_TABLAS_GENRO = New clsDB_TB_TABLAS_GENRO
            oBETB_TABLAS_GEN = New clsBE_TB_TABLAS_GEN
        End Sub

        Public Sub NuevaEntidad()
            oBETB_TABLAS_GEN = New clsBE_TB_TABLAS_GEN
        End Sub

        Public Sub LeerListaTB_TABLAS_GEN()
            Try
                oDSTB_TABLAS_GEN = oDBTB_TABLAS_GENRO.LeerListaToDSTB_TABLAS_GEN(oBETB_TABLAS_GEN)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

    End Class
#End Region

End Namespace
