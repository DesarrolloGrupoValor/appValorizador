Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC


#Region "Clase Escritura"

    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:40:01
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_LiquidacionEstadoDetalleTX
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsBC_LiquidacionEstadoDetalleTX

        Private oDBLiquidacionEstadoDetalleTX As clsDB_LiquidacionEstadoDetalleTX
        Public oBELiquidacionEstadoDetalle As clsBE_LiquidacionEstadoDetalle
        Public LstLiquidacionEstadoDetalle As New List(Of clsBE_LiquidacionEstadoDetalle)
        Public oDSLiquidacionEstadoDetalle As DataSet

        Sub New()
            oDBLiquidacionEstadoDetalleTX = New clsDB_LiquidacionEstadoDetalleTX
            oBELiquidacionEstadoDetalle = New clsBE_LiquidacionEstadoDetalle
        End Sub

        Public Sub NuevaEntidad()
            oBELiquidacionEstadoDetalle = New clsBE_LiquidacionEstadoDetalle
        End Sub

        Public Function InsertaLiquidacionEstado() As Boolean
            Try
                Return oDBLiquidacionEstadoDetalleTX.InsertaLiquidacionEstado(oBELiquidacionEstadoDetalle)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function InsertaLiquidacionEstadoVenta() As Boolean
            Try
                Return oDBLiquidacionEstadoDetalleTX.InsertaLiquidacionEstadoVenta(oBELiquidacionEstadoDetalle)
            Catch ex As Exception
                Throw ex
            End Try
        End Function



    End Class
#End Region

#Region "Clase Lectura"

 
    Public Class clsBC_LiquidacionEstadoDetalleRO
        

        Private oDBLiquidacionEstadoDetalleRO As clsDB_LiquidacionEstadoDetalleRO
        Public oDSLiquidacionEstadoDetalle As DataSet

        Public oBE_LiquidacionEstado As clsBE_LiquidacionEstado

        Public oBELiquidacionEstadoDetalle As clsBE_LiquidacionEstadoDetalle

        Sub New()
            oDBLiquidacionEstadoDetalleRO = New clsDB_LiquidacionEstadoDetalleRO
            oBE_LiquidacionEstado = New clsBE_LiquidacionEstado
        End Sub


        Public Sub LeerListaToDSLiquidacionEstadoDetalle()
            Try
                oDSLiquidacionEstadoDetalle = oDBLiquidacionEstadoDetalleRO.LeerListaToDSLiquidacionEstadoDetalle(oBE_LiquidacionEstado)
            Catch ex As Exception
                Throw ex
                'Return Nothing
            End Try
        End Sub


        Public Sub LeerLiquidacionEstadoDetalleDS_Sel()
            Try
                oDSLiquidacionEstadoDetalle = oDBLiquidacionEstadoDetalleRO.LeerLiquidacionEstadoDetalleDS_Sel(oBELiquidacionEstadoDetalle)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub


        Public Sub LeerLiquidacionEstadoDetalleDS_Sel_Adelanto()
            Try
                oDSLiquidacionEstadoDetalle = oDBLiquidacionEstadoDetalleRO.LeerLiquidacionEstadoDetalleDS_Sel_Adelanto(oBELiquidacionEstadoDetalle)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub LeerLiquidacionEstadoDetalleDS_SelAll(ByVal sCodigoMovimiento As String)
            Try
                oDSLiquidacionEstadoDetalle = oDBLiquidacionEstadoDetalleRO.LeerLiquidacionEstadoDetalleDS_SelAll(sCodigoMovimiento)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub LeerLiquidacionEstadoDetalleDS_Sel_Seguimiento()
            Try
                oDSLiquidacionEstadoDetalle = oDBLiquidacionEstadoDetalleRO.LeerLiquidacionEstadoDetalleDS_Sel_Seguimiento(oBELiquidacionEstadoDetalle)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

    End Class
#End Region



End Namespace
