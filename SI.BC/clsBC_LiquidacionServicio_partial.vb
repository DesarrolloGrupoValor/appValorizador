Imports SI.BE
Namespace SI.BC
    Partial Public Class clsBC_LiquidacionServicioTX
        Public LstLiquidacionservicioUpd As New List(Of clsBE_LiquidacionServicio)
        Public LstLiquidacionservicioDel As New List(Of clsBE_LiquidacionServicio)
        Public LstLiquidacionservicioIns As New List(Of clsBE_LiquidacionServicio)
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 07/12/2010 14:46:15
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function Insertarservicio() As Boolean
            Try
                If LstLiquidacionservicioIns.Count = 0 Then LstLiquidacionservicioIns = LstLiquidacionservicio
                Return oDBLiquidacionServicioTX.InsertarServicio(LstLiquidacionservicioIns)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 07/12/2010 14:46:15
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function Modificarservicio() As Boolean
            Try
                If LstLiquidacionservicioUpd.Count = 0 Then LstLiquidacionservicioUpd = LstLiquidacionservicio
                Return oDBLiquidacionservicioTX.Modificarservicio(LstLiquidacionservicioUpd)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 07/12/2010 14:46:15
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function Eliminarservicio() As Boolean
            Try
                If LstLiquidacionservicioDel.Count = 0 Then LstLiquidacionservicioDel = LstLiquidacionservicio
                Return oDBLiquidacionservicioTX.Eliminarservicio(LstLiquidacionservicioDel)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function


    End Class

End Namespace
