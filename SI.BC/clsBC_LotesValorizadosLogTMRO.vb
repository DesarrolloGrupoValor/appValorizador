Imports SI.DB

Namespace SI.BC
    Partial Public Class clsBC_LotesValorizadosTMLogRO

        Private oDBLotesValorizadosLogTMRO As clsDB_LotesValorizadosLogTMRO
        'Public oBELotesValorizadosLog As clsBE_LotesValorizadosLog
        'Public LstLotesValorizadosLog As New List(Of clsBE_LotesValorizadosLog)
        Public oDSLotesValorizadosTMLog As New DataSet
        Public oDTLotesValorizadosLog As New DataTable


        Sub New()
            oDBLotesValorizadosLogTMRO = New clsDB_LotesValorizadosLogTMRO
            'oBELotesValorizadosLog = New clsBE_LotesValorizadosLog
        End Sub

        Public Sub NuevaEntidad()
            'oBELotesValorizadosLog = New clsBE_LotesValorizadosLog
        End Sub

        Public Function LeerListaToDSLotesValorizadosTMLog(ByVal sContratoLoteId As String, ByVal sLiquidacion As String, ByVal nLotesValorizadosLogID As Integer) As DataSet
            Try
                oDSLotesValorizadosTMLog = oDBLotesValorizadosLogTMRO.LeerListaToDStbLotesValorizadosTMLog(sContratoLoteId, sLiquidacion, nLotesValorizadosLogID)
                Return oDSLotesValorizadosTMLog
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace