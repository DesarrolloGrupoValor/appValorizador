Imports SI.DB
Imports SI.BE

Namespace SI.BC
    Partial Public Class clsBC_LiquidacionTmTX
        Public LstLiquidacionTmUpd As New List(Of clsBE_LiquidacionTm)
        Public LstLiquidacionTmDel As New List(Of clsBE_LiquidacionTm)
        Public LstLiquidacionTmIns As New List(Of clsBE_LiquidacionTm)
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 07/12/2010 14:46:15
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function InsertarLiquidacion() As Boolean
            Try
                If LstLiquidacionTmIns.Count = 0 Then LstLiquidacionTmIns = LstLiquidacionTm
                Return oDBLiquidacionTmTX.InsertarLiquidacion(LstLiquidacionTmIns)
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

        Public Function ModificarLiquidacion() As Boolean
            Try
                If LstLiquidacionTmUpd.Count = 0 Then LstLiquidacionTmUpd = LstLiquidacionTm
                Return oDBLiquidacionTmTX.ModificarLiquidacionTm(LstLiquidacionTmUpd)
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

        Public Function EliminarLiquidacion() As Boolean
            Try
                If LstLiquidacionTmDel.Count = 0 Then LstLiquidacionTmDel = LstLiquidacionTm
                Return oDBLiquidacionTmTX.EliminarLiquidacionTm(LstLiquidacionTmDel)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function
    End Class
    Partial Public Class clsBC_LiquidacionTmRO
        ''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:58:18
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function LeerListaToDSLiquidacion() As DataSet
            Try
                oDSLiquidacionTm = oDBLiquidacionTmRO.LeerListaToDSLiquidacion(oBELiquidacionTm)

                Return oDSLiquidacionTm
            Catch ex As Exception
                Throw ex
            End Try
        End Function
      
        ''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:58:18
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function DefineTablaLiquidacionTm() As DataTable
            Try
                oDTLiquidacionTm = oDBLiquidacionTmRO.DefineTablaLiquidacionTm()
                Return oDTLiquidacionTm
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

End Namespace
