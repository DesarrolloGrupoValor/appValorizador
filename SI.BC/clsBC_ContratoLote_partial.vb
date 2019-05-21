'Modified;
'@01 20141016 BAL01 Validacion, no se puede eliminar liquidacion cuyo asiento contable haya sido generado

Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC
    Partial Public Class clsBC_ContratoLoteRO
        ''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:11/11/2010 21:18:58
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function LeerListaToDSExtraccionBd() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSExtraccionBd(oBEContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDSComercial_Kardex() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSComercial_Kardex(oBEContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDSComercial_Resultado() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSComercial_Resultado(oBEContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDSComposicionComercial() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSComposicionComercial(oBEContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDSComposicionContable() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSComposicionContable(oBEContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDSComposicionMezcla() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSComposicionMezcla(oBEContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDSCoberturas() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSCoberturas(oBEContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function LeerListaToDSConsultaLiquidaciones() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSConsultaLiq(oBEContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDSDesempeño() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSDesempeño(oBEContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function LeerListaToDSContable_CuadreTMH() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSContable_CuadreTMH(oBEContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDSContable_DiferenciaTMHVenta() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSContable_DiferenciaTMHVenta(oBEContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDSContable_CompraMezcla() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSContable_CompraMezcla(oBEContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDSContable_CompraVenta() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSContable_CompraVenta(oBEContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDSContable_Estimaciones() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSContable_Estimaciones(oBEContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDSContable_Liquidacioneslote() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSContable_LiquidacionesLote(oBEContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDSContable_Vinculadas() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSContable_Vinculadas(oBEContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function LeerListaToDSContable_Movimiento() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSContable_Movimiento(oBEContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDSContable_Movimiento_New() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSContable_Movimiento_New(oBEContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function LeerListaToDSSaldoLosa() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSSaldoLosa(oBEContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDSContable_Kardex(sTipo As String) As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSContable_Kardex(sTipo, oBEContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function LeerListaToDSMatriz_Mezcla() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSMatriz_mezcla(oBEContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        'Public Function LeerListaToDSCompra_asignacion_Venta() As DataSet
        '    Try
        '        oDSContratoLote = oDBContratoLoteRO.LeerListaToDSCompra_asignacion_Venta(oBEContratoLote)
        '        Return oDSContratoLote
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function







        ''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:11/11/2010 21:18:58
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function LeerListaToDSReporteLista() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSReporteLista(oBEContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function





        ''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:11/11/2010 21:18:58
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function LeerListaToDSContabilidad() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSContabilidad(oBEContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        '@01    AINI
        Public Function ExisteAsientoContableToLiquidacion(ByVal pContratoLote As clsBE_ContratoLote) As Boolean
            Return oDBContratoLoteRO.ExisteAsientoContableToLiquidacion(pContratoLote)
        End Function
        '@01    AFIN

        ''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:11/11/2010 21:18:58
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function LeerListaToDSContrato() As DataSet
            'oDSContratoLote = oDBContratoLoteRO.LeerListaToDSContrato(oBEContratoLote)
            'Return oDSContratoLote
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSContrato(oBEContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDSLoteMov() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSLoteMov(oBEContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:39:41
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Sub VerificarNumeroLote()
            Try
                oBEContratoLote = oDBContratoLoteRO.VerificarNumeroLote(oBEContratoLote)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:39:41
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Sub VerificarNumeroContrato()
            Try
                oBEContratoLote = oDBContratoLoteRO.VerificarNumeroContrato(oBEContratoLote)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function LeerListaToDSExtraccionVCM() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSExtraccionVCM()
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDSSaldoBlend() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSSaldoBlend()
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDSExtraccionVCM_Despacho() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSExtraccionVCM_Despacho()
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDSExtraccionVCM_Venta() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSExtraccionVCM_Venta()
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDSComposicionVentaSab() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSComposicionVentaSab()
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class
End Namespace

