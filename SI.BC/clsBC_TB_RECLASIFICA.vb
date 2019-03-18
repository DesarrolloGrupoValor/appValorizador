Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:45
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_TB_RECLASIFICATX
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsBC_TB_RECLASIFICATX
        'Inherits ServicedComponent

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_TB_RECLASIFICATX
        ''' Fecha Modificacion:
        ''' </summary>

        Private oDBTB_RECLASIFICATX As clsDB_TB_RECLASIFICATX
        Public oBETB_RECLASIFICA As clsBE_TB_RECLASIFICA
        Public LstTB_RECLASIFICA As New List(Of clsBE_TB_RECLASIFICA)

        Public LstTB_RECLASIFICA_INSERT As New List(Of clsBE_TB_RECLASIFICA)
        'Public LstTB_RECLASIFICA_UPDATE As New List(Of clsBE_TB_RECLASIFICA)

        Public oDSTB_RECLASIFICA As DataSet

        Sub New()
            oDBTB_RECLASIFICATX = New clsDB_TB_RECLASIFICATX
            oBETB_RECLASIFICA = New clsBE_TB_RECLASIFICA
        End Sub

        Public Sub NuevaEntidad()
            oBETB_RECLASIFICA = New clsBE_TB_RECLASIFICA
        End Sub

        Public Function TB_RECLASIFICA_INSERT() As Boolean
            Try
                Return oDBTB_RECLASIFICATX.TB_RECLASIFICA_INSERT(LstTB_RECLASIFICA_INSERT)
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
    Public Class clsBC_TB_RECLASIFICARO
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Private oDBTB_RECLASIFICARO As clsDB_TB_RECLASIFICARO
        Public oBETB_RECLASIFICA As clsBE_TB_RECLASIFICA
        Public LstTB_RECLASIFICA As New List(Of clsBE_TB_RECLASIFICA)
        Public oDSTB_RECLASIFICA As New DataSet
        Public oDTTB_RECLASIFICA As New DataTable


        Sub New()
            oDBTB_RECLASIFICARO = New clsDB_TB_RECLASIFICARO
            oBETB_RECLASIFICA = New clsBE_TB_RECLASIFICA
        End Sub

        Public Sub NuevaEntidad()
            oBETB_RECLASIFICA = New clsBE_TB_RECLASIFICA
        End Sub


        Public Function LeerListaToDSTB_RECLASIFICA() As DataSet
            Try
                oDSTB_RECLASIFICA = oDBTB_RECLASIFICARO.LeerListaToDSTB_RECLASIFICA(oBETB_RECLASIFICA)
                Return oDSTB_RECLASIFICA
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class
#End Region

End Namespace
