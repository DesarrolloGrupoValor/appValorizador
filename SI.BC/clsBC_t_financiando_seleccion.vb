Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:45
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_t_financiando_seleccionTX
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsBC_t_financiando_seleccionTX
        'Inherits ServicedComponent

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_t_financiando_seleccionTX
        ''' Fecha Modificacion:
        ''' </summary>

        Private oDBt_financiando_seleccionTX As clsDB_t_financiando_seleccionTX
        Public oBEt_financiando_seleccion As clsBE_t_financiando_seleccion
        Public Lstt_financiando_seleccion As New List(Of clsBE_t_financiando_seleccion)

        Public Lstt_financiando_seleccion_INSERT As New List(Of clsBE_t_financiando_seleccion)
        'Public Lstt_financiando_seleccion_UPDATE As New List(Of clsBE_t_financiando_seleccion)

        Public oDSt_financiando_seleccion As DataSet

        Sub New()
            oDBt_financiando_seleccionTX = New clsDB_t_financiando_seleccionTX
            oBEt_financiando_seleccion = New clsBE_t_financiando_seleccion
        End Sub

        Public Sub NuevaEntidad()
            oBEt_financiando_seleccion = New clsBE_t_financiando_seleccion
        End Sub


        Public Function t_financiando_seleccion_INSERT() As Boolean
            Try
                Return oDBt_financiando_seleccionTX.t_financiando_seleccion_INSERT(Lstt_financiando_seleccion_INSERT)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function

        Public Function t_financiando_seleccion_Update() As Boolean
            Try
                Return oDBt_financiando_seleccionTX.t_financiando_seleccion_Update(Lstt_financiando_seleccion_INSERT)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function

        Public Function t_financiando_seleccion_DELETE() As Boolean
            Try
                Return oDBt_financiando_seleccionTX.t_financiando_seleccion_DELETE(Lstt_financiando_seleccion_INSERT)
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
    Public Class clsBC_t_financiando_seleccionRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Private oDBt_financiando_seleccionRO As clsDB_t_financiando_seleccionRO
        Public oBEt_financiando_seleccion As clsBE_t_financiando_seleccion
        Public Lstt_financiando_seleccion As New List(Of clsBE_t_financiando_seleccion)
        Public oDSt_financiando_seleccion As New DataSet
        Public oDTt_financiando_seleccion As New DataTable


        Sub New()
            oDBt_financiando_seleccionRO = New clsDB_t_financiando_seleccionRO
            oBEt_financiando_seleccion = New clsBE_t_financiando_seleccion
        End Sub

        Public Sub NuevaEntidad()
            oBEt_financiando_seleccion = New clsBE_t_financiando_seleccion
        End Sub

        Public Sub LeerListaToDSt_financiando_seleccion_sel()
            Try
                oDSt_financiando_seleccion = oDBt_financiando_seleccionRO.LeerListaToDSt_financiando_seleccion_sel(oBEt_financiando_seleccion)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
       

    End Class
#End Region

End Namespace
