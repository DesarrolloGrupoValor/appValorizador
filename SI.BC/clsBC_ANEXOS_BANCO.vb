Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:45
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_ANEXOS_BANCOTX
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsBC_ANEXOS_BANCOTX
        'Inherits ServicedComponent

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_ANEXOS_BANCOTX
        ''' Fecha Modificacion:
        ''' </summary>

        Private oDBANEXOS_BANCOTX As clsDB_ANEXOS_BANCOTX
        Public oBEANEXOS_BANCO As clsBE_ANEXOS_BANCO
        Public LstANEXOS_BANCO As New List(Of clsBE_ANEXOS_BANCO)
        Public oDSANEXOS_BANCO As DataSet

        Sub New()
            oDBANEXOS_BANCOTX = New clsDB_ANEXOS_BANCOTX
            oBEANEXOS_BANCO = New clsBE_ANEXOS_BANCO
        End Sub

        Public Sub NuevaEntidad()
            oBEANEXOS_BANCO = New clsBE_ANEXOS_BANCO
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
    Public Class clsBC_ANEXOS_BANCORO
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Private oDBANEXOS_BANCORO As clsDB_ANEXOS_BANCORO
        Public oBEANEXOS_BANCO As clsBE_ANEXOS_BANCO
        Public LstANEXOS_BANCO As New List(Of clsBE_ANEXOS_BANCO)
        Public oDSANEXOS_BANCO As New DataSet
        Public oDTANEXOS_BANCO As New DataTable


        Sub New()
            oDBANEXOS_BANCORO = New clsDB_ANEXOS_BANCORO
            oBEANEXOS_BANCO = New clsBE_ANEXOS_BANCO
        End Sub

        Public Sub NuevaEntidad()
            oBEANEXOS_BANCO = New clsBE_ANEXOS_BANCO
        End Sub





        Public Function LeerListaToDSANEXOS_BANCO() As DataSet
            Try
                oDSANEXOS_BANCO = oDBANEXOS_BANCORO.LeerListaToDSANEXOS_BANCO(oBEANEXOS_BANCO)
                Return oDSANEXOS_BANCO
            Catch ex As Exception
                Throw ex
            End Try
        End Function


    End Class
#End Region

End Namespace
