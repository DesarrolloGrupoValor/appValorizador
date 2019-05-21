Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:42:13
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_Precio_DiarioTX
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsBC_Precio_DiarioTX
        'Inherits ServicedComponent

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:42:13
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_Precio_DiarioTX
        ''' Fecha Modificacion:
        ''' </summary>

        Private oDBPrecio_DiarioTX As clsDB_Precio_DiarioTX
        Public oBEPrecio_Diario As clsBE_Precio_Diario
        Public LstPrecio_Diario As New List(Of clsBE_Precio_Diario)
        Public oDSPrecio_Diario As DataSet


        Public SqlDataAdapter As System.Data.SqlClient.SqlDataAdapter
        Public dtPrecio_Diario As New DataTable()

        Sub New()
            oDBPrecio_DiarioTX = New clsDB_Precio_DiarioTX
            oBEPrecio_Diario = New clsBE_Precio_Diario
        End Sub

        Public Sub NuevaEntidad()
            oBEPrecio_Diario = New clsBE_Precio_Diario
        End Sub

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:42:13
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function InsertarPrecio_Diario() As Boolean
            Try
                Return oDBPrecio_DiarioTX.InsertarPrecio_Diario(oBEPrecio_Diario)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:42:13
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function EliminaPrecio_Diario() As Boolean
            Try
                Return oDBPrecio_DiarioTX.EliminaPrecio_Diario(oBEPrecio_Diario)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function


        Public Function MasivoPrecio_Diario() As DataTable
            Try
                Dim dt As DataTable = oDBPrecio_DiarioTX.MasivoPrecio_Diario(dtPrecio_Diario)
                SqlDataAdapter = oDBPrecio_DiarioTX.SqlDataAdapter
                Return dt
            Catch ex As Exception
                Throw ex
                'Return False
            End Try
        End Function

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:42:13
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function ModificarPrecio_Diario() As Boolean
            Try
                Return oDBPrecio_DiarioTX.ModificarPrecio_Diario(oBEPrecio_Diario)
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
    ''' Fecha Creacion: 17/02/2011 16:42:13
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsBC_Precio_DiarioRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:42:13
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Private oDBPrecio_DiarioRO As clsDB_Precio_DiarioRO
        Public oBEPrecio_Diario As clsBE_Precio_Diario
        Public LstPrecio_Diario As New List(Of clsBE_Precio_Diario)
        Public oDSPrecio_Diario As New DataSet
        Public oDTPrecio_Diario As New DataTable


        Sub New()
            oDBPrecio_DiarioRO = New clsDB_Precio_DiarioRO
            oBEPrecio_Diario = New clsBE_Precio_Diario
        End Sub

        Public Sub NuevaEntidad()
            oBEPrecio_Diario = New clsBE_Precio_Diario
        End Sub

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:42:13
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function Precio_Diario_Valida()
            Try
                Return oDBPrecio_DiarioRO.Precio_Diario_Valida(oBEPrecio_Diario)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Sub LeerListaPrecio_Diario_Sel(ByVal oBEPrecio_Diario As clsBE_Precio_Diario)
            Try
                oDSPrecio_Diario = oDBPrecio_DiarioRO.LeerListaPrecio_Diario_Sel(oBEPrecio_Diario)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:42:13
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Sub LeerListaToDSPrecio_Diario_SelAll(Optional ByVal sTipo As String = "D")
            Try
                oDSPrecio_Diario = oDBPrecio_DiarioRO.LeerListaToDSPrecio_Diario_SelAll(sTipo)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        

    End Class
#End Region

End Namespace
