


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
    ''' Fecha Creacion: 17/02/2011 16:58:45
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la FINANCIANDO_CLI FINANCIANDO_CLI
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsDB_TB_PROVIPREVTX

        Private Shared CadenaConexion As String
        Public Sub New()
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("EN")

        End Sub

        Public Function PROVIPREV_IU(ByVal oBE_TB_PROVIPREV As List(Of clsBE_TB_PROVIPREV)) As Boolean
            For Each oTB_FJ_FIJACION As clsBE_TB_PROVIPREV In oBE_TB_PROVIPREV
                Dim prmParameter(5) As SqlParameter

                prmParameter(0) = New SqlParameter("@TIPO_OPERACION", SqlDbType.VarChar, 1)
                prmParameter(0).Value = IIf(IsNothing(oTB_FJ_FIJACION.pTIPO_OPERACION), "", oTB_FJ_FIJACION.pTIPO_OPERACION)
                prmParameter(0).Direction = ParameterDirection.Input

                prmParameter(1) = New SqlParameter("@IDPROVI", SqlDbType.Int)
                prmParameter(1).Value = IIf(IsNothing(oTB_FJ_FIJACION.pIDPROVI), 0, oTB_FJ_FIJACION.pIDPROVI)
                prmParameter(1).Direction = ParameterDirection.Input

                prmParameter(2) = New SqlParameter("@ESTADO", SqlDbType.VarChar, 20)
                prmParameter(2).Value = IIf(IsNothing(oTB_FJ_FIJACION.pESTADO), "", oTB_FJ_FIJACION.pESTADO)
                prmParameter(2).Direction = ParameterDirection.Input

                prmParameter(3) = New SqlParameter("@contratoloteid", SqlDbType.VarChar, 20)
                prmParameter(3).Value = IIf(IsNothing(oTB_FJ_FIJACION.PcontratoloteId), "", oTB_FJ_FIJACION.PcontratoloteId)
                prmParameter(3).Direction = ParameterDirection.Input

                prmParameter(4) = New SqlParameter("@liquidacionid", SqlDbType.VarChar, 20)
                prmParameter(4).Value = IIf(IsNothing(oTB_FJ_FIJACION.pLiquidacionId), "", oTB_FJ_FIJACION.pLiquidacionId)
                prmParameter(4).Direction = ParameterDirection.Input

                prmParameter(5) = New SqlParameter("@usuarioId", SqlDbType.VarChar, 20)
                prmParameter(5).Value = IIf(IsNothing(oTB_FJ_FIJACION.pUsuarioId), "", oTB_FJ_FIJACION.pUsuarioId)
                prmParameter(5).Direction = ParameterDirection.Input

                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_PROVIPREV_IU", prmParameter)

                Catch ex As Exception
                    Throw ex
                    Return False
                End Try
            Next
            Return True
        End Function

    End Class
#End Region

#Region "Clase Lectura"
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:46
    ''' Proposito: Obtiene los valores de la FINANCIANDO_CLI FINANCIANDO_CLI
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsDB_TB_PROVIPREVRO
        Private Shared CadenaConexion As String
        Public Sub New()
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("EN")
        End Sub


        Public Function LeerListaToDSPROVIPREV_ADELANTOS(ByVal pTB_PROVIPREV As clsBE_TB_PROVIPREV) As DataSet
            Dim oDSTB_PROVIPREV As New DataSet
            Dim mintItem As Integer = 0
            Try
                Dim prmParameter(1) As SqlParameter

                prmParameter(0) = New SqlParameter("@contratoLoteId", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(pTB_PROVIPREV.pContratoloteId), "", pTB_PROVIPREV.pContratoloteId)

                prmParameter(1) = New SqlParameter("@liquidacionId", SqlDbType.VarChar, 20)
                prmParameter(1).Value = IIf(IsNothing(pTB_PROVIPREV.pLiquidacionId), "", pTB_PROVIPREV.pLiquidacionId)

                Using oDSTB_PROVIPREV
                    oDSTB_PROVIPREV = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_TB_PROVIPREV_ADELANTOS", prmParameter)
                    If Not oDSTB_PROVIPREV Is Nothing Then
                        If oDSTB_PROVIPREV.Tables.Count > 0 Then
                            If oDSTB_PROVIPREV.Tables(0).Rows.Count > 0 Then
                                Return oDSTB_PROVIPREV
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSTB_PROVIPREV

        End Function

    End Class
#End Region

End Namespace
