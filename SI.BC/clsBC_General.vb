'Modified:
'@01 20141016 BAL01 Elimar asiento contable segun filtro (Empresa, Tipo movimiento, periodo)
'@02 20141016 BAL01 Carga de datos para Verificacion vs CONCAR


Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Lectura"
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 08/11/2007 10:54:27 a.m.
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
       Public Class clsBC_GeneralRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 08/11/2007 10:54:27 a.m.
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Private oDALCGeneralRO As clsDB_GeneralRO
        Public oBEGeneral As clsBE_General
        Public oBETablaDet As clsBE_TablaDet
        Public LstGeneral As New List(Of clsBE_General)
        Public LstGeneralResultado As New List(Of clsBE_General_resultado)
        Public oDTGeneral As New DataTable
        Public oDSGeneral As New DataSet

        Sub New()
            oDALCGeneralRO = New clsDB_GeneralRO
            oBEGeneral = New clsBE_General
            oBETablaDet = New clsBE_TablaDet
        End Sub

        Public Sub NuevaEntidad()
            oBEGeneral = New clsBE_General
            oBETablaDet = New clsBE_TablaDet
        End Sub
        ''' <summary>
        ''' Escrito por: 
        ''' Fecha Creacion:
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Sub Obtener_Parametros()
            Try
                LstGeneral = oDALCGeneralRO.Obtener_Parametros(oBEGeneral)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        ''' <summary>
        ''' Escrito por: 
        ''' Fecha Creacion:
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function Obtener_ParametrosDS() As DataSet
            Try
                Return oDALCGeneralRO.Obtener_ParametrosDS(oBEGeneral)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ''' <summary>
        ''' Escrito por: 
        ''' Fecha Creacion:
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Sub Obtener_Parametros_resultado()
            Try
                LstGeneralResultado = oDALCGeneralRO.Obtener_Parametros_Resultado(oBEGeneral)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        ''' <summary>
        ''' Escrito por: 
        ''' Fecha Creacion:
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Sub Obtener_Registros()
            Try
                LstGeneral = oDALCGeneralRO.Obtener_Registros(oBEGeneral)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        ''' <summary>
        ''' Escrito por: 
        ''' Fecha Creacion:
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function Obtener_RegistrosDS() As DataSet
            Try
                Return oDALCGeneralRO.Obtener_RegistrosDS(oBEGeneral)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ''' <summary>
        ''' Escrito por: 
        ''' Fecha Creacion:
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function Obtener_Correlativo() As String
            Try
                Return oDALCGeneralRO.Obtener_Correlativo(oBEGeneral)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ''' <summary>
        ''' Escrito por: 
        ''' Fecha Creacion:
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function Validar_Usuario() As clsBE_TablaDet
            Try
                Return oDALCGeneralRO.Validar_Usuario(oBETablaDet)

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ProcesarContabilidad() As Boolean
            Try
                Return oDALCGeneralRO.ProcesarContabilidad(oBEGeneral)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function

        '@01    AINI
        Public Function EliminarAsientoContableByFiltro() As Boolean
            Try
                Return oDALCGeneralRO.EliminarAsientoContableByFiltro(oBEGeneral)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function
        '@01    AFIN

        '@02    AINI
        Public Function Obtener_RegistrosToVerificarConcarDS() As DataSet
            Try
                Return oDALCGeneralRO.Obtener_RegistrosToVerificarConcarDS(oBEGeneral)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        '@01    AFIN

        '@02    AINI
        Public Function Obtener_RegistrosToMatrizDS() As DataSet
            Try
                Return oDALCGeneralRO.Obtener_RegistrosToMatrizDS(oBEGeneral)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        '@02    AFIN

        Public Function Obtener_AsientosConcarDS() As DataSet
            Try
                Return oDALCGeneralRO.Obtener_AsientosConcarDS(oBEGeneral)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class
#End Region

End Namespace
