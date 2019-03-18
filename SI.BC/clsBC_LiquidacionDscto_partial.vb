Imports SI.BE

Namespace SI.BC
    Partial Public Class clsBC_LiquidacionDsctoTX
        Public LstLiquidacionDsctoUpd As New List(Of clsBE_LiquidacionDscto)
        Public LstLiquidacionDsctoDel As New List(Of clsBE_LiquidacionDscto)
        Public LstLiquidacionDsctoIns As New List(Of clsBE_LiquidacionDscto)
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 07/12/2010 14:46:15
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function InsertarDscto() As Boolean
            Try
                If LstLiquidacionDsctoIns.Count = 0 Then LstLiquidacionDsctoIns = LstLiquidacionDscto
                Return oDBLiquidacionDsctoTX.InsertarDscto(LstLiquidacionDsctoIns)
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

        Public Function ModificarDscto() As Boolean
            Try
                If LstLiquidacionDsctoUpd.Count = 0 Then LstLiquidacionDsctoUpd = LstLiquidacionDscto
                Return oDBLiquidacionDsctoTX.ModificarDscto(LstLiquidacionDsctoUpd)
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

        Public Function EliminarDscto() As Boolean
            Try
                If LstLiquidacionDsctoDel.Count = 0 Then LstLiquidacionDsctoDel = LstLiquidacionDscto
                Return oDBLiquidacionDsctoTX.EliminarDscto(LstLiquidacionDsctoDel)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function

    End Class
End Namespace

