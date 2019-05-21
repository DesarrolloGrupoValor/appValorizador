'Modified;
'@01 20141016 BAL01 Validacion, no se puede eliminar ReporteCompraVenta cuyo asiento contable haya sido generado

Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC
    Public Class clsBC_ReporteCompraVentaRO

        Private oDBReporteCompraVentaRO As clsDB_ReporteCompraVentaRO
        Public oBEReporteCompraVenta As clsBE_ReporteCompraVenta
        Public LstReporteCompraVenta As New List(Of clsBE_ReporteCompraVenta)
        Public oDSReporteCompraVenta As New DataSet
        Public oDTReporteCompraVenta As New DataTable


        ''' <summary>
        ''' Escrito por:  Lissete Miyahira
        ''' Fecha Creacion:05/12/2017
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Sub New()
            oDBReporteCompraVentaRO = New clsDB_ReporteCompraVentaRO
            oBEReporteCompraVenta = New clsBE_ReporteCompraVenta
        End Sub

        Public Sub NuevaEntidad()
            oBEReporteCompraVenta = New clsBE_ReporteCompraVenta
        End Sub

        Public Function fnCalculaComparacionVentas() As Boolean
            Return oDBReporteCompraVentaRO.fnCalculaComparacionVentas(oBEReporteCompraVenta)
        End Function

        Public Function ProcesaComprasVentas() As Boolean
            Try
                Return oDBReporteCompraVentaRO.ProcesaComprasVentas(oBEReporteCompraVenta)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function LeerListaToDSCompra_asignacion_Venta() As DataSet
            Try
                oDSReporteCompraVenta = oDBReporteCompraVentaRO.LeerListaToDSCompra_asignacion_Venta(oBEReporteCompraVenta)
                Return oDSReporteCompraVenta
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDSRepaticionRentabilidad() As DataSet
            Try
                oDSReporteCompraVenta = oDBReporteCompraVentaRO.LeerListaToDSRepaticionRentabilidad(oBEReporteCompraVenta)
                Return oDSReporteCompraVenta
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class
End Namespace

