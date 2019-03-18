Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:45
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_TB_PROVIPREVTX
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsBC_TB_PROVIPREVTX
        'Inherits ServicedComponent

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_TB_PROVIPREVTX
        ''' Fecha Modificacion:
        ''' </summary>

        Private oDBTB_PROVIPREVTX As clsDB_TB_PROVIPREVTX
        Public oBETB_PROVIPREV As clsBE_TB_PROVIPREV
        Public LstTB_PROVIPREV As New List(Of clsBE_TB_PROVIPREV)

        Public LstTB_PROVIPREV_INSERT As New List(Of clsBE_TB_PROVIPREV)
        'Public LstTB_PROVIPREV_UPDATE As New List(Of clsBE_TB_PROVIPREV)
        Public LstTB_PROVIPREV_DELETE As New List(Of clsBE_TB_PROVIPREV)

        Public oDSTB_PROVIPREV As DataSet

        Sub New()
            oDBTB_PROVIPREVTX = New clsDB_TB_PROVIPREVTX
            oBETB_PROVIPREV = New clsBE_TB_PROVIPREV
        End Sub

        Public Sub NuevaEntidad()
            oBETB_PROVIPREV = New clsBE_TB_PROVIPREV
        End Sub

        Public Function PROVIPREV_IU() As Boolean
            Try
                Return oDBTB_PROVIPREVTX.PROVIPREV_IU(LstTB_PROVIPREV_INSERT)
            Catch ex As Exception
                'Catch ex As System.Data.SqlClient.SqlException 

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
    Public Class clsBC_TB_PROVIPREVRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Private oDBTB_PROVIPREVRO As clsDB_TB_PROVIPREVRO
        Public oBETB_PROVIPREV As clsBE_TB_PROVIPREV
        Public LstTB_PROVIPREV As New List(Of clsBE_TB_PROVIPREV)
        Public oDSTB_PROVIPREV As New DataSet
        Public oDTTB_PROVIPREV As New DataTable


        Sub New()
            oDBTB_PROVIPREVRO = New clsDB_TB_PROVIPREVRO
            oBETB_PROVIPREV = New clsBE_TB_PROVIPREV
        End Sub

        Public Sub NuevaEntidad()
            oBETB_PROVIPREV = New clsBE_TB_PROVIPREV
        End Sub

        Public Sub LeerListaToDSPROVIPREV_ADELANTOS()
            Try
                oDSTB_PROVIPREV = oDBTB_PROVIPREVRO.LeerListaToDSPROVIPREV_ADELANTOS(oBETB_PROVIPREV)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

    End Class
#End Region

End Namespace
