Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Lissete Miyahira
    ''' Fecha Creacion: 29/11/2017
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_SaldoFinalTX
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsBC_SaldoFinalTX
        'Inherits ServicedComponent

        ''' <summary>
        ''' Escrito por: Lissete Miyahira
        ''' Fecha Creacion: 29/11/2017
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_SaldoFinalTX
        ''' Fecha Modificacion:
        ''' </summary>

        Private oDBSaldoFinalTX As clsDB_SaldoFinalTX
        Public oBESaldoFinal As clsBE_SaldoFinal
        Public LstSaldoFinal As New List(Of clsBE_SaldoFinal)
        Public oDSSaldoFinal As DataSet

        Sub New()
            oDBSaldoFinalTX = New clsDB_SaldoFinalTX
            oBESaldoFinal = New clsBE_SaldoFinal
        End Sub

        Public Sub NuevaEntidad()
            oBESaldoFinal = New clsBE_SaldoFinal
        End Sub

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function InsertarSaldoFinal() As Boolean
            Try
                Return oDBSaldoFinalTX.InsertarSaldoFinal(LstSaldoFinal)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function

        Public Function EliminarSaldoFinal() As Integer
            Try
                Return oDBSaldoFinalTX.EliminarSaldoFinal()
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function



    End Class
#End Region

#Region "Clase Lectura"
    ''' <summary>
    ''' Escrito por: Lissete Miyahira
    ''' Fecha Creacion: 29/11/2017
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsBC_SaldoFinalRO
        ''' <summary>
        ''' Escrito por: Lissete Miyahira
        ''' Fecha Creacion: 29/11/2017
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Private oDBSaldoFinalRO As clsDB_SaldoFinalRO
        Public oBESaldoFinal As clsBE_SaldoFinal
        Public LstSaldoFinal As New List(Of clsBE_SaldoFinal)
        Public oDSSaldoFinal As New DataSet
        Public oDTSaldoFinal As New DataTable


        Sub New()
            oDBSaldoFinalRO = New clsDB_SaldoFinalRO
            oBESaldoFinal = New clsBE_SaldoFinal
        End Sub

        Public Sub NuevaEntidad()
            oBESaldoFinal = New clsBE_SaldoFinal
        End Sub

        ''' <summary>
        ''' Escrito por: Lissete Miyahira
        ''' Fecha Creacion: 29/11/2017
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Sub fnValidaSaldoFinal_Sell(speriodo As String)
            Try
                oDSSaldoFinal = oDBSaldoFinalRO.fnValidaSaldoFinal_Sell(speriodo)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

    End Class
#End Region

End Namespace
