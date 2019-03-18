Imports SI.BE

Namespace SI.BC
    Partial Public Class clsBC_LiquidacionRO
        ''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:40:01
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public oBE_AuditoriaD As clsBE_AuditoriaD

        Public Function DefineTablaLiquidacion() As DataTable
            Try
                oDTLiquidacion = oDBLiquidacionRO.DefineTablaLiquidacion()
                Return oDTLiquidacion
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function fnTipoLiquidacion(ByVal psCodLote As String) As DataTable
            Dim lbExisteFinal As Boolean = False


            Try
                oDTLiquidacion = oDBLiquidacionRO.fnTipoLiquidacion(psCodLote)
                Dim lsNumero As String

                For Each loRow As DataRow In oDTLiquidacion.Rows
                    lsNumero = loRow.Item(2)

                    Select Case lsNumero
                        Case 1
                            loRow.Item(1) = "1ra " + loRow.Item(1)
                        Case 2
                            'If loRow.Item(0).ToString().Equals("FIN") Then
                            '    lbExisteFinal = True
                            'End If

                            loRow.Item(1) = "2da " + loRow.Item(1)
                        Case 3
                            loRow.Item(1) = "3ra " + loRow.Item(1)
                        Case 4
                            loRow.Item(1) = "4ta " + loRow.Item(1)
                        Case 5
                            loRow.Item(1) = "5ta " + loRow.Item(1)
                        Case 6
                            loRow.Item(1) = "6ta " + loRow.Item(1)
                        Case 7
                            loRow.Item(1) = "7ma " + loRow.Item(1)
                        Case 8
                            loRow.Item(1) = "8va " + loRow.Item(1)
                        Case 9
                            loRow.Item(1) = "9na " + loRow.Item(1)
                        Case 10
                            loRow.Item(1) = "10ma " + loRow.Item(1)
                        Case 11
                            loRow.Item(1) = "11va " + loRow.Item(1)
                        Case 12
                            loRow.Item(1) = "12va " + loRow.Item(1)
                        Case 13
                            loRow.Item(1) = "13va " + loRow.Item(1)
                        Case 14
                            loRow.Item(1) = "14va " + loRow.Item(1)
                        Case 15
                            loRow.Item(1) = "15va " + loRow.Item(1)
                        Case 16
                            loRow.Item(1) = "16va " + loRow.Item(1)
                        Case 17
                            loRow.Item(1) = "17va " + loRow.Item(1)
                        Case 18
                            loRow.Item(1) = "18va " + loRow.Item(1)
                        Case 19
                            loRow.Item(1) = "19va " + loRow.Item(1)
                        Case Else
                            loRow.Item(1) = "xma " + loRow.Item(1)

                    End Select
                    loRow.Item(0) = loRow.Item(0) + "|" + lsNumero
                Next
                If lbExisteFinal Then
                    oDTLiquidacion.Rows.RemoveAt(0)
                End If

                Return oDTLiquidacion
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function fnTipoLiquidacionOld(ByVal psCodLote As String) As DataTable
            Dim lbExisteFinal As Boolean = False


            Try
                oDTLiquidacion = oDBLiquidacionRO.fnTipoLiquidacionOld(psCodLote)


                Return oDTLiquidacion
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function fnSelDTCalculoValorizado(ByVal psCodntratoLoteId As String) As DataTable
            Dim lbExisteFinal As Boolean = False


            Try
                oDTLiquidacion = oDBLiquidacionRO.fnSelDTCalculoValorizado(psCodntratoLoteId)


                Return oDTLiquidacion
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function fnSelDTLiquidacionAll() As DataTable
            Try
                oDTLiquidacion = oDBLiquidacionRO.fnSelDTLiquidacionAll()
                Return oDTLiquidacion
            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Function fnCrearLiquidacion(ByVal psCodLote As String, _
                                           ByVal piNummeroCalculo As Integer, _
                                           ByVal psCodigoCalculo As String, _
                                           ByVal psUC As String, _
                                           ByVal psCodTrader As String, _
                                           ByVal pdFecha_Liquidacion As Date, _
                                           ByVal sAccion As String) As String
            Dim lsRetorna As String

            Try

                lsRetorna = oDBLiquidacionRO.fnCrearLiquidacion(psCodLote, piNummeroCalculo, psCodigoCalculo, psUC, psCodTrader, pdFecha_Liquidacion, sAccion)
                Return lsRetorna
            Catch ex As Exception
                Throw ex
            End Try


        End Function

        Public Function fnCalculaLoteUnico(ByVal sContratoLoteId As String) As Boolean
            Return oDBLiquidacionRO.fnCalculaLoteUnico(sContratoLoteId)
        End Function

        Public Function fnPreliquidaciones(ByVal sPeriodo As String) As Boolean
            Return oDBLiquidacionRO.fnPreliquidaciones(sPeriodo)
        End Function


        Public Function fnCalculaLote(Optional ByVal sContratoLoteId As String = "", Optional ByVal sUsuarioModifica As String = "VCM", Optional ByVal sAcccion As String = "SISTE") As Boolean
            Return oDBLiquidacionRO.fnCalculaLote(sContratoLoteId, oBE_AuditoriaD, sUsuarioModifica, sAcccion)
        End Function

        Public Function fnCalculaMezcla() As Boolean
            Return oDBLiquidacionRO.fnCalculaMezcla()
        End Function
        Public Function fnCalculaVinculada() As Boolean
            Return oDBLiquidacionRO.fnCalculaVinculada()
        End Function
        Public Function fnSelDTComposicionVinculada(ByVal psCodLote As String) As DataTable
            Try
                Return oDBLiquidacionRO.fnSelDTComposicionVinculada(psCodLote)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function fnSelDTComposicion(ByVal psCodLote As String) As DataTable
            Try
                Return oDBLiquidacionRO.fnSelDTComposicion(psCodLote)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function LeerListaDSRumasVinculadas(ByVal psCodLote As String) As DataSet
            Try
                Return oDBLiquidacionRO.LeerListaDSRumasVinculadas(psCodLote)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function fnDelLiquidacion(ByVal psCodntratoLoteId As String, ByVal psLiquidacionId As String) As Boolean
            Return oDBLiquidacionRO.fnDelLiquidacion(psCodntratoLoteId, psLiquidacionId)
        End Function
        Public Function fnModificarLiquidacion() As Boolean
            Return oDBLiquidacionRO.fnModificarLiquidacion(LstLiquidacion)
        End Function

      
      
    End Class

End Namespace
