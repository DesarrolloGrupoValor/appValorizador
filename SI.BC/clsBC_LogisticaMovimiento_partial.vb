'@Modified:
'@01 20141010 BAL01 Validacion de liquidacion para rumas componentes de Despacho - Blend
'@02 20141117 BAL01 Validacion de asociacion; no se permite asociar ruma cuyo TMH disponible se haya excedido.

Imports SI.BE

Namespace SI.BC
    Partial Public Class clsBC_LogisticaMovimientoRO
        ''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:25/02/2011 10:15:55
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function LeerListaToDSLogisticaMovimientoAsociado() As DataSet
            Try
                oDSLogisticaMovimiento = oDBLogisticaMovimientoRO.LeerListaToDSLogisticaAsociado(oBELogisticaMovimiento)
                Return oDSLogisticaMovimiento
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
    Partial Public Class clsBC_LogisticaMovimientoTX
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 25/02/2011 10:15:55
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function ActualizaEstadoLogisticaMovimiento() As Boolean
            Try
                Return oDBLogisticaMovimientoTX.ActualizaEstadoLogisticaMovimiento(LstLogisticaMovimiento, oBE_AuditoriaD)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function

        Public Function ActualizaEstadoLogisticaDesasociar(ByVal piId As Long) As Boolean
            Try
                Return oDBLogisticaMovimientoTX.ActualizaEstadoLogisticaDesasociar(piId, oBE_AuditoriaD)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function
        Public Function ActualizaEstadoBtnOK(ByVal psContratoLoteId As String, ByVal psLiquidacionId As String) As Boolean

            Try
                Return oDBLogisticaMovimientoTX.ActualizaEstadoBtnOK(psContratoLoteId, psLiquidacionId, oBE_AuditoriaD)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function
        Public Function ActualizaEstadoBtnCancelar(ByVal psContratoLoteId As String, ByVal psLiquidacionId As String) As Boolean

            Try
                Return oDBLogisticaMovimientoTX.ActualizaEstadoBtnCancelar(psContratoLoteId, psLiquidacionId)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function

        '@01    AINI
        Public Function validarLiquidacionRumasComponentes(ByVal loteOrigen As String) As DataTable
            Try
                Return oDBLogisticaMovimientoTX.validarLiquidacionRumasComponentes(loteOrigen)
            Catch ex As Exception
                Throw ex
                Return Nothing
            End Try
        End Function
        '@01    AFIN

        '@02    AINI
        Public Function validarDisponibilidadAsociacion(ByVal lote As String) As Boolean
            Try
                Return oDBLogisticaMovimientoTX.validarDisponibilidadAsociacion(lote)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        '@02    AFIN
    End Class

End Namespace
