Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:45
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_TB_BENEFICIARIO_CCHICATX
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsBC_TB_BENEFICIARIO_CCHICATX
        'Inherits ServicedComponent

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_TB_BENEFICIARIO_CCHICATX
        ''' Fecha Modificacion:
        ''' </summary>

        Private oDBTB_BENEFICIARIO_CCHICATX As clsDB_TB_BENEFICIARIO_CCHICATX
        Public oBETB_BENEFICIARIO_CCHICA As clsBE_TB_BENEFICIARIO_CCHICA
        Public LstTB_BENEFICIARIO_CCHICA As New List(Of clsBE_TB_BENEFICIARIO_CCHICA)
        Public oDSTB_BENEFICIARIO_CCHICA As DataSet

        Sub New()
            oDBTB_BENEFICIARIO_CCHICATX = New clsDB_TB_BENEFICIARIO_CCHICATX
            oBETB_BENEFICIARIO_CCHICA = New clsBE_TB_BENEFICIARIO_CCHICA
        End Sub

        Public Sub NuevaEntidad()
            oBETB_BENEFICIARIO_CCHICA = New clsBE_TB_BENEFICIARIO_CCHICA
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
    Public Class clsBC_TB_BENEFICIARIO_CCHICARO
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Private oDBTB_BENEFICIARIO_CCHICARO As clsDB_TB_BENEFICIARIO_CCHICARO
        Public oBETB_BENEFICIARIO_CCHICA As clsBE_TB_BENEFICIARIO_CCHICA
        Public LstTB_BENEFICIARIO_CCHICA As New List(Of clsBE_TB_BENEFICIARIO_CCHICA)
        Public oDSTB_BENEFICIARIO_CCHICA As New DataSet
        Public oDTTB_BENEFICIARIO_CCHICA As New DataTable


        Sub New()
            oDBTB_BENEFICIARIO_CCHICARO = New clsDB_TB_BENEFICIARIO_CCHICARO
            oBETB_BENEFICIARIO_CCHICA = New clsBE_TB_BENEFICIARIO_CCHICA
        End Sub

        Public Sub NuevaEntidad()
            oBETB_BENEFICIARIO_CCHICA = New clsBE_TB_BENEFICIARIO_CCHICA
        End Sub

       
    

       
        Public Function LeerListaToDSTB_BENEFICIARIO_CCHICA() As DataSet
            Try
                oDSTB_BENEFICIARIO_CCHICA = oDBTB_BENEFICIARIO_CCHICARO.LeerListaToDSTB_BENEFICIARIO_CCHICA(oBETB_BENEFICIARIO_CCHICA)
                Return oDSTB_BENEFICIARIO_CCHICA
            Catch ex As Exception
                Throw ex
            End Try
        End Function
       

    End Class
#End Region

End Namespace
