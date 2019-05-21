


Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports SI.BE
Imports SI.UT
Imports Microsoft.ApplicationBlocks.Data

Namespace SI.DB

#Region "Clase Escritura"

    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:40:01
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla Liquidacion
    ''' Fecha Modificacion:
    ''' </summary>
	'''

    Public Class clsDB_LiquidacionEstadoTX

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:40:01
        ''' Proposito: Metodo de Insercci?n de Datos
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function InsertarLiquidacionEstado(ByVal oBE_tbLiquidacionEstado As clsBE_LiquidacionEstado) As Boolean

            Dim prmParameter(4) As SqlParameter

            prmParameter(0) = New SqlParameter("@contratoLoteId", SqlDbType.VarChar, 20)
            prmParameter(0).Value = IIf(IsNothing(oBE_tbLiquidacionEstado.contratoLoteId), "", oBE_tbLiquidacionEstado.contratoLoteId)
            prmParameter(0).Direction = ParameterDirection.Input
            prmParameter(1) = New SqlParameter("@liquidacionId", SqlDbType.VarChar, 20)
            prmParameter(1).Value = IIf(IsNothing(oBE_tbLiquidacionEstado.liquidacionId), "", oBE_tbLiquidacionEstado.liquidacionId)
            prmParameter(1).Direction = ParameterDirection.Input
            prmParameter(2) = New SqlParameter("@codigoCalculo", SqlDbType.VarChar, 3)
            prmParameter(2).Value = IIf(IsNothing(oBE_tbLiquidacionEstado.codigoCalculo), "", oBE_tbLiquidacionEstado.codigoCalculo)
            prmParameter(2).Direction = ParameterDirection.Input
            prmParameter(3) = New SqlParameter("@uc", SqlDbType.VarChar, 20)
            prmParameter(3).Value = IIf(IsNothing(oBE_tbLiquidacionEstado.uc), "", oBE_tbLiquidacionEstado.uc)
            prmParameter(3).Direction = ParameterDirection.Input

            prmParameter(4) = New SqlParameter("@archivo", SqlDbType.VarChar, 200)
            prmParameter(4).Value = IIf(IsNothing(oBE_tbLiquidacionEstado.archivo), "", oBE_tbLiquidacionEstado.archivo)
            prmParameter(4).Direction = ParameterDirection.Input

            Try
                SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "upLiquidacionEstado_Ins", prmParameter)


            Catch ex As Exception
                Throw ex
                Return False
            End Try

            Return True
        End Function
        

    End Class
#End Region
    

    
End Namespace
