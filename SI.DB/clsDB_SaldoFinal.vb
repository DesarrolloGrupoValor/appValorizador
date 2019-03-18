


Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports SI.BE
Imports SI.UT
Imports Microsoft.ApplicationBlocks.Data

Namespace SI.DB

#Region "Clase Escritura"

    ''' <summary>
    ''' Escrito por: Lissete Miyahira
    ''' Fecha Creacion: 29/11/2017
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla Tabla
    ''' Fecha Modificacion:
    ''' </summary>
	'''

    Public Class clsDB_SaldoFinalTX

        Private Shared CadenaConexion As String
        Public Sub New()

            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Lissete Miyahira
        ''' Fecha Creacion: 29/11/2017
        ''' Proposito: Metodo de Insercci?n de Datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function InsertarSaldoFinal(ByVal oLstTabla As List(Of clsBE_SaldoFinal)) As Boolean
            For Each oSaldoFinal As clsBE_SaldoFinal In oLstTabla
                Dim prmParameter(6) As SqlParameter

                prmParameter(0) = New SqlParameter("@calidad", SqlDbType.VarChar, 50)
                prmParameter(0).Value = IIf(IsNothing(oSaldoFinal.calidad), "", oSaldoFinal.calidad)
                prmParameter(0).Direction = ParameterDirection.Input

                prmParameter(1) = New SqlParameter("@precinto", SqlDbType.VarChar, 10)
                prmParameter(1).Value = IIf(IsNothing(oSaldoFinal.precinto), "", oSaldoFinal.precinto)
                prmParameter(1).Direction = ParameterDirection.Input

                prmParameter(2) = New SqlParameter("@ruma", SqlDbType.VarChar, 10)
                prmParameter(2).Value = IIf(IsNothing(oSaldoFinal.ruma), "", oSaldoFinal.ruma)
                prmParameter(2).Direction = ParameterDirection.Input

                prmParameter(3) = New SqlParameter("@clase", SqlDbType.VarChar, 10)
                prmParameter(3).Value = IIf(IsNothing(oSaldoFinal.clase), "", oSaldoFinal.clase)
                prmParameter(3).Direction = ParameterDirection.Input

                prmParameter(4) = New SqlParameter("@tmh", SqlDbType.Float)
                prmParameter(4).Value = IIf(IsNothing(oSaldoFinal.tmh), "", oSaldoFinal.tmh)
                prmParameter(4).Direction = ParameterDirection.Input

                prmParameter(5) = New SqlParameter("@fec_ingreso", SqlDbType.Date)
                prmParameter(5).Value = IIf(IsNothing(oSaldoFinal.fec_ingreso), "", oSaldoFinal.fec_ingreso)
                prmParameter(5).Direction = ParameterDirection.Input

                prmParameter(6) = New SqlParameter("@ticket", SqlDbType.VarChar, 50)
                prmParameter(6).Value = IIf(IsNothing(oSaldoFinal.ticket), "", oSaldoFinal.ticket)
                prmParameter(6).Direction = ParameterDirection.Input

                Try

                    SqlHelper.ExecuteScalar(CadenaConexion, CommandType.StoredProcedure, "PA_SaldoFinal_Ins", prmParameter)
                Catch ex As Exception
                    Throw ex
                    Return False
                End Try
            Next
            Return True
        End Function


        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Lissete Miyahira
        ''' Fecha Creacion: 29/11/2017
        ''' Proposito: Metodo de Elimacion
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function EliminarSaldoFinal() As Boolean

            Try
                SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "PA_SaldoFinal_Del")
            Catch ex As Exception
                Throw ex
                Return False
            End Try

            Return True
        End Function

    End Class
#End Region

#Region "Clase Lectura"
    ''' <summary>
    ''' Escrito por: Lissete Miyahira
    ''' Fecha Creacion: 29/11/2017
    ''' Proposito: Obtiene los valores de la tabla Tabla
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsDB_SaldoFinalRO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub


        Public Function fnValidaSaldoFinal_Sell(ByVal sPeriodo As String) As DataSet
            Dim lbResultado As Boolean = True

            Try
                Dim prmParameter(0) As SqlParameter
                prmParameter(0) = New SqlParameter("@periodo", SqlDbType.VarChar, 6)
                prmParameter(0).Value = IIf(IsNothing(sPeriodo), "", sPeriodo)


                Return SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "PA_Valida_SaldoFinal", prmParameter)

            Catch ex As Exception
                lbResultado = False
            End Try
            Return Nothing
        End Function

    End Class
#End Region
    
End Namespace
