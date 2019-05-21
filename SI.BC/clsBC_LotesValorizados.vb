Imports SI.DB
Imports SI.BE

Namespace SI.BC
    Partial Public Class clsBC_LotesValorizadosRO

        Private oDBLotesValorizadosRO As clsDB_LotesValorizadosRO
        Public oBELotesValorizados As clsBE_LoteValorizados
        'Public LstLotesValorizadosLog As New List(Of clsBE_LotesValorizadosLog)
        Public oDSLotesValorizados As New DataSet
        Public oDTLotesValorizados As New DataTable


        Sub New()
            oDBLotesValorizadosRO = New clsDB_LotesValorizadosRO
            'oBELotesValorizadosLog = New clsBE_LotesValorizadosLog
        End Sub

        Public Sub NuevaEntidad()
            'oBELotesValorizadosLog = New clsBE_LotesValorizadosLog
        End Sub

        Public Function LeerListaToDStbLotesValorizados_valortotal_sel() As DataSet
            Try
                oDSLotesValorizados = oDBLotesValorizadosRO.LeerListaToDStbLotesValorizados_valortotal_sel(oBELotesValorizados)
                Return oDSLotesValorizados
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDStbLotesValorizados_netoapagar_sel() As DataSet
            Try
                oDSLotesValorizados = oDBLotesValorizadosRO.LeerListaToDStbLotesValorizados_netoapagar_sel(oBELotesValorizados)
                Return oDSLotesValorizados
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDStbLotesValorizados_sel() As DataSet
            Try
                oDSLotesValorizados = oDBLotesValorizadosRO.LeerListaToDStbLotesValorizados_sel(oBELotesValorizados)
                Return oDSLotesValorizados
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class
End Namespace