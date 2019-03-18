Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:40:01
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_LiquidacionEstadoTX
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsBC_LiquidacionEstadoTX
        'Inherits ServicedComponent

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:40:01
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_LiquidacionEstadoTX
        ''' Fecha Modificacion:
        ''' </summary>

        Private oDBLiquidacionEstadoTX As clsDB_LiquidacionEstadoTX
        Public oBELiquidacionEstado As clsBE_LiquidacionEstado
        Public LstLiquidacionEstado As New List(Of clsBE_LiquidacionEstado)
        Public oDSLiquidacionEstado As DataSet

        Sub New()
            oDBLiquidacionEstadoTX = New clsDB_LiquidacionEstadoTX
            oBELiquidacionEstado = New clsBE_LiquidacionEstado
        End Sub

        Public Sub NuevaEntidad()
            oBELiquidacionEstado = New clsBE_LiquidacionEstado
        End Sub

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:40:01
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function InsertarLiquidacionEstado() As Boolean
            Try
                Return oDBLiquidacionEstadoTX.InsertarLiquidacionEstado(oBELiquidacionEstado)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function

    End Class
#End Region



End Namespace
