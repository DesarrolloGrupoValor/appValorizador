Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"

    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:45
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_TB_SERIE_DOCTX
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsBC_TB_SERIE_DOCTX
        'Inherits ServicedComponent

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_ANEXOS_BANCOTX
        ''' Fecha Modificacion:
        ''' </summary>

        Private oDBTB_SERIE_DOCTX As clsDB_TB_SERIE_DOCTX
        Public oBETB_SERIE_DOC As clsBE_TB_SERIE_DOC
        Public LstTB_SERIE_DOC As New List(Of clsBE_TB_SERIE_DOC)
        Public oDSTB_sERIE_dOC As DataSet

        Sub New()
            oDBTB_SERIE_DOCTX = New clsDB_TB_SERIE_DOCTX
            oBETB_SERIE_DOC = New clsBE_TB_SERIE_DOC
        End Sub

        Public Sub NuevaEntidad()
            oBETB_SERIE_DOC = New clsBE_TB_SERIE_DOC
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
    Public Class clsBC_TB_SERIE_DOCRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Private oDBTB_SERIE_DOCRO As clsDB_TB_SERIE_DOCRO
        Public oBETB_SERIE_DOC As clsBE_TB_SERIE_DOC
        Public LstTB_SERIE_DOC As New List(Of clsBE_TB_SERIE_DOC)
        Public oDSTB_SERIE_DOC As New DataSet
        Public oDTTB_SERIE_DOC As New DataTable


        Sub New()
            oDBTB_SERIE_DOCRO = New clsDB_TB_SERIE_DOCRO
            oBETB_SERIE_DOC = New clsBE_TB_SERIE_DOC

        End Sub

        Public Sub NuevaEntidad()
            oBETB_SERIE_DOC = New clsBE_TB_SERIE_DOC
        End Sub



        Public Function LeerListaToDSTB_SERIE_DOC() As DataSet
            Try
                oDSTB_SERIE_DOC = oDBTB_SERIE_DOCRO.LeerListaToDSTB_SERIE_DOC(oBETB_SERIE_DOC)
                Return oDSTB_SERIE_DOC
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub LeerTB_SERIE_DOC()
            Try
                oBETB_SERIE_DOC = oDBTB_SERIE_DOCRO.LeerTB_SERIE_DOC(oBETB_SERIE_DOC)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub


    End Class
#End Region

End Namespace
