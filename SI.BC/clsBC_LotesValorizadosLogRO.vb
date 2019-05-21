Imports SI.DB
Imports SI.BE

Namespace SI.BC
    Partial Public Class clsBC_LotesValorizadosLogRO

        Private oDBLotesValorizadosLogRO As clsDB_LotesValorizadosLogRO
        Public oBE_ContratoLote As clsBE_ContratoLote

        'Public LstLotesValorizadosLog As New List(Of clsBE_LotesValorizadosLog)
        Public oDSLotesValorizadosLog As New DataSet
        Public oDTLotesValorizadosLog As New DataTable


        Sub New()
            oDBLotesValorizadosLogRO = New clsDB_LotesValorizadosLogRO
            'oBELotesValorizadosLog = New clsBE_LotesValorizadosLog
        End Sub

        Public Sub NuevaEntidad()
            'oBELotesValorizadosLog = New clsBE_LotesValorizadosLog
        End Sub

        Public Function LeerListaToDSLotesValorizadosLog() As DataSet
            Try
                oDSLotesValorizadosLog = oDBLotesValorizadosLogRO.LeerListaToDStbLotesValorizadosLog(oBE_ContratoLote)
                Return oDSLotesValorizadosLog
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function LeerListaToDSLotesValorizadosVariacion(ByVal dFechaInicio As DateTime, ByVal dFechaFin As DateTime) As DataSet
            Try
                oDSLotesValorizadosLog = oDBLotesValorizadosLogRO.LeerListaToDStbLotesValorizadosVariacion(dFechaInicio, dFechaFin)
                Return oDSLotesValorizadosLog
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class
End Namespace