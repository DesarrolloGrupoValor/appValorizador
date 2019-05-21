


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

    Public Class clsDB_ProfitLossLoteTX

        Private Shared CadenaConexion As String


        Public SqlDataAdapter As System.Data.SqlClient.SqlDataAdapter


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
        Public Function ModificarProfitLoss(ByVal oBE_tbProfitLoss As clsBE_ProfitLossLote) As Boolean

            Dim prmParameter(7) As SqlParameter

            prmParameter(0) = New SqlParameter("@contratoloteId", SqlDbType.VarChar, 20)
            prmParameter(0).Value = IIf(IsNothing(oBE_tbProfitLoss.contratoloteId), "", oBE_tbProfitLoss.contratoloteId)

            prmParameter(1) = New SqlParameter("@liquidacion", SqlDbType.VarChar, 20)
            prmParameter(1).Value = IIf(IsNothing(oBE_tbProfitLoss.liquidacionId), "", oBE_tbProfitLoss.liquidacionId)

            prmParameter(2) = New SqlParameter("@flete", SqlDbType.Decimal)
            prmParameter(2).Value = IIf(IsNothing(oBE_tbProfitLoss.flete), 0, oBE_tbProfitLoss.flete)

            prmParameter(3) = New SqlParameter("@estibas", SqlDbType.Decimal)
            prmParameter(3).Value = IIf(IsNothing(oBE_tbProfitLoss.estibas), 0, oBE_tbProfitLoss.estibas)

            prmParameter(4) = New SqlParameter("@supervision", SqlDbType.Decimal)
            prmParameter(4).Value = IIf(IsNothing(oBE_tbProfitLoss.supervision), 0, oBE_tbProfitLoss.supervision)

            prmParameter(5) = New SqlParameter("@seguridad", SqlDbType.Decimal)
            prmParameter(5).Value = IIf(IsNothing(oBE_tbProfitLoss.seguridad), 0, oBE_tbProfitLoss.seguridad)

            prmParameter(6) = New SqlParameter("@ensayes", SqlDbType.Decimal)
            prmParameter(6).Value = IIf(IsNothing(oBE_tbProfitLoss.ensayes), 0, oBE_tbProfitLoss.ensayes)

            prmParameter(7) = New SqlParameter("@otros", SqlDbType.Decimal)
            prmParameter(7).Value = IIf(IsNothing(oBE_tbProfitLoss.otros), 0, oBE_tbProfitLoss.otros)

            Try
                SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "upProfitLossLote_Upd", prmParameter)

            Catch ex As Exception
                Throw ex
                Return False
            End Try

            Return True
        End Function

        Public Function InsertarProfitLoss(ByVal oBE_tbProfitLoss As clsBE_ProfitLossLote) As Boolean

            Dim prmParameter(1) As SqlParameter

            prmParameter(0) = New SqlParameter("@contratoloteId", SqlDbType.VarChar, 20)
            prmParameter(0).Value = IIf(IsNothing(oBE_tbProfitLoss.contratoloteId), "", oBE_tbProfitLoss.contratoloteId)

            prmParameter(1) = New SqlParameter("@liquidacion", SqlDbType.VarChar, 20)
            prmParameter(1).Value = IIf(IsNothing(oBE_tbProfitLoss.liquidacionId), "", oBE_tbProfitLoss.liquidacionId)


            Try
                SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "upProfitLossLote_Ins", prmParameter)

            Catch ex As Exception
                Throw ex
                Return False
            End Try

            Return True
        End Function

    End Class
#End Region

#Region "Clase Lectura"
    <Serializable()> _
    Public Class clsDB_ProfitLossLoteRO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub


        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 21/04/2011 09:07:44 a.m.
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSProfitLoss(ByVal sContratoLoteId As String) As DataSet
            Dim oDSProfitLoss As New DataSet

            Try

                Dim prmParameter(0) As SqlParameter

                prmParameter(0) = New SqlParameter("@CONTRATOLOTEid", SqlDbType.VarChar, 20)
                prmParameter(0).Value = sContratoLoteId 'IIf(IsNothing(oBE_tbProfitLoss.IdPrecioDiario), 0, oBE_tbProfitLoss.IdPrecioDiario)

                Using oDSProfitLoss
                    oDSProfitLoss = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "upProfitLossLote", prmParameter)
                    If Not oDSProfitLoss Is Nothing Then
                        If oDSProfitLoss.Tables.Count > 0 Then
                            If oDSProfitLoss.Tables(0).Rows.Count > 0 Then
                                Return oDSProfitLoss
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSProfitLoss

        End Function


        Public Function LeerListaToDSProfitLoss_Sel(ByVal oBE_ProfitLoss As clsBE_ProfitLossLote) As DataSet
            Dim oDSProfitLoss As New DataSet

            Try
                Dim prmParameter(1) As SqlParameter

                prmParameter(0) = New SqlParameter("@contratoloteId", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(oBE_ProfitLoss.contratoloteId), "", oBE_ProfitLoss.contratoloteId)

                prmParameter(1) = New SqlParameter("@liquidacion", SqlDbType.VarChar, 20)
                prmParameter(1).Value = IIf(IsNothing(oBE_ProfitLoss.liquidacionId), "", oBE_ProfitLoss.liquidacionId)

                Using oDSProfitLoss
                    oDSProfitLoss = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "upProfitLossLote_Sel", prmParameter)
                    If Not oDSProfitLoss Is Nothing Then
                        If oDSProfitLoss.Tables.Count > 0 Then
                            If oDSProfitLoss.Tables(0).Rows.Count > 0 Then
                                Return oDSProfitLoss
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSProfitLoss

        End Function


    End Class

#End Region


End Namespace
