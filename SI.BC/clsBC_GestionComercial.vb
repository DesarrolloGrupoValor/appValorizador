Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:45
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_GestionComercialTX
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsBC_GestionComercialTX
        'Inherits ServicedComponent

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_GestionComercialTX
        ''' Fecha Modificacion:
        ''' </summary>

        Private oDBGestionComercialTX As clsDB_GestionComercialTX
        Public oBEGestionComercial As clsBE_GestionComercial
        Public LstGestionComercial As New List(Of clsBE_GestionComercial)
        Public oDSGestionComercial As DataSet

        Sub New()
            oDBGestionComercialTX = New clsDB_GestionComercialTX
            oBEGestionComercial = New clsBE_GestionComercial
        End Sub

        Public Sub NuevaEntidad()
            oBEGestionComercial = New clsBE_GestionComercial
        End Sub

        Public Function GenerarGestionComercial_Ins() As Boolean
            Try
                Return oDBGestionComercialTX.GenerarGestionComercial_Ins(oBEGestionComercial)

            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function


        Public Function GenerarGestionComercial_Anu() As Boolean
            Try
                Return oDBGestionComercialTX.GenerarGestionComercial_Anu(oBEGestionComercial)

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
    Public Class clsBC_GestionComercialRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Private oDBGestionComercialRO As clsDB_GestionComercialRO
        Public oBEGestionComercial As clsBE_GestionComercial
        Public LstGestionComercial As New List(Of clsBE_GestionComercial)
        Public oDSGestionComercial As New DataSet
        Public oDTGestionComercial As New DataTable


        Sub New()
            oDBGestionComercialRO = New clsDB_GestionComercialRO
            oBEGestionComercial = New clsBE_GestionComercial
        End Sub

        Public Sub NuevaEntidad()
            oBEGestionComercial = New clsBE_GestionComercial
        End Sub


       

        Public Function LeerListaToDSGestionComercial() As DataSet
            Try
                oDSGestionComercial = oDBGestionComercialRO.LeerListaToDSGestionComercial(oBEGestionComercial)
                Return oDSGestionComercial
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function LeerListaToDSGestionComercial_Sel() As DataSet
            Try
                oDSGestionComercial = oDBGestionComercialRO.LeerListaToDSGestionComercial_Sel(oBEGestionComercial)
                Return oDSGestionComercial
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function LeerListaToDSGestionComercial_SelAll() As DataSet
            Try
                oDSGestionComercial = oDBGestionComercialRO.LeerListaToDSGestionComercial_SelAll(oBEGestionComercial)
                Return oDSGestionComercial
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class
#End Region

End Namespace
