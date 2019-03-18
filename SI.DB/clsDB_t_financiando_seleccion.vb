



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
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la FINANCIANDO_PRELIQ FINANCIANDO_PRELIQ
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsDB_t_financiando_seleccionTX

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionEN")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("EN")
        End Sub

       
        Public Function t_financiando_seleccion_DELETE(ByVal oBE_t_financiando_seleccion As List(Of clsBE_t_financiando_seleccion)) As Boolean
            For Each ot_financiando_seleccion As clsBE_t_financiando_seleccion In oBE_t_financiando_seleccion
                Dim prmParameter(0) As SqlParameter

                prmParameter(0) = New SqlParameter("@item", SqlDbType.Int)
                prmParameter(0).Value = IIf(IsNothing(ot_financiando_seleccion.item), 0, ot_financiando_seleccion.item)
                prmParameter(0).Direction = ParameterDirection.Input

                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_t_financiando_seleccion_del", prmParameter)

                Catch ex As Exception
                    Throw ex
                    Return False
                End Try
            Next
            Return True
        End Function

        Public Function t_financiando_seleccion_INSERT(ByVal oBE_t_financiando_seleccion As List(Of clsBE_t_financiando_seleccion)) As Boolean
            For Each ot_financiando_seleccion As clsBE_t_financiando_seleccion In oBE_t_financiando_seleccion
                Dim prmParameter(14) As SqlParameter

                prmParameter(0) = New SqlParameter("@item", SqlDbType.Int)
                prmParameter(0).Value = IIf(IsNothing(ot_financiando_seleccion.item), 0, ot_financiando_seleccion.item)
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1) = New SqlParameter("@diferido", SqlDbType.VarChar, 1)
                prmParameter(1).Value = IIf(IsNothing(ot_financiando_seleccion.diferido), "", ot_financiando_seleccion.diferido)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@empresa", SqlDbType.VarChar, 50)
                prmParameter(2).Value = IIf(IsNothing(ot_financiando_seleccion.empresa), "", ot_financiando_seleccion.empresa)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@td", SqlDbType.VarChar, 5)
                prmParameter(3).Value = IIf(IsNothing(ot_financiando_seleccion.td), "", ot_financiando_seleccion.td)
                prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(4) = New SqlParameter("@nro_doc", SqlDbType.VarChar, 20)
                prmParameter(4).Value = IIf(IsNothing(ot_financiando_seleccion.nro_doc), "", ot_financiando_seleccion.nro_doc)
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5) = New SqlParameter("@nro_caja", SqlDbType.VarChar, 20)
                prmParameter(5).Value = IIf(IsNothing(ot_financiando_seleccion.nro_caja), "", ot_financiando_seleccion.nro_caja)
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6) = New SqlParameter("@nro_op", SqlDbType.VarChar, 20)
                prmParameter(6).Value = IIf(IsNothing(ot_financiando_seleccion.nro_op), "", ot_financiando_seleccion.nro_op)
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7) = New SqlParameter("@fch_op", SqlDbType.VarChar, 10)
                prmParameter(7).Value = IIf(IsNothing(ot_financiando_seleccion.fch_op), "", ot_financiando_seleccion.fch_op)
                prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(8) = New SqlParameter("@lote", SqlDbType.VarChar, 10)
                prmParameter(8).Value = IIf(IsNothing(ot_financiando_seleccion.lote), "", ot_financiando_seleccion.lote)
                prmParameter(8).Direction = ParameterDirection.Input
                prmParameter(9) = New SqlParameter("@ruma", SqlDbType.VarChar, 10)
                prmParameter(9).Value = IIf(IsNothing(ot_financiando_seleccion.ruma), "", ot_financiando_seleccion.ruma)
                prmParameter(9).Direction = ParameterDirection.Input
                prmParameter(10) = New SqlParameter("@tad", SqlDbType.VarChar, 5)
                prmParameter(10).Value = IIf(IsNothing(ot_financiando_seleccion.tad), "", ot_financiando_seleccion.tad)
                prmParameter(10).Direction = ParameterDirection.Input
                prmParameter(11) = New SqlParameter("@calidad", SqlDbType.VarChar, 50)
                prmParameter(11).Value = IIf(IsNothing(ot_financiando_seleccion.calidad), "", ot_financiando_seleccion.calidad)
                prmParameter(11).Direction = ParameterDirection.Input
                prmParameter(12) = New SqlParameter("@us_aplica_sigv", SqlDbType.Float)
                prmParameter(12).Value = IIf(IsNothing(ot_financiando_seleccion.us_aplica_sigv), 0, ot_financiando_seleccion.us_aplica_sigv)
                prmParameter(12).Direction = ParameterDirection.Input
                prmParameter(13) = New SqlParameter("@us_aplica_cigv", SqlDbType.Float)
                prmParameter(13).Value = IIf(IsNothing(ot_financiando_seleccion.us_aplica_cigv), 0, ot_financiando_seleccion.us_aplica_cigv)
                prmParameter(13).Direction = ParameterDirection.Input
                prmParameter(14) = New SqlParameter("@saldo_us", SqlDbType.Float)
                prmParameter(14).Value = IIf(IsNothing(ot_financiando_seleccion.saldo_us), 0, ot_financiando_seleccion.saldo_us)
                prmParameter(14).Direction = ParameterDirection.Input

                ''prmParameter(14) = New SqlParameter("@nro_cierre", SqlDbType.Int)
                ''prmParameter(14).Value = IIf(IsNothing(ot_financiando_seleccion.nro_cierre), 0, ot_financiando_seleccion.nro_cierre)
                ''prmParameter(14).Direction = ParameterDirection.Input
                ''prmParameter(14) = New SqlParameter("@lote_vcm", SqlDbType.VarChar, 20)
                ''prmParameter(14).Value = IIf(IsNothing(ot_financiando_seleccion.lote_vcm), 0, ot_financiando_seleccion.lote_vcm)
                ''prmParameter(14).Direction = ParameterDirection.Input
                ''prmParameter(14) = New SqlParameter("@proveedor", SqlDbType.VarChar, 100)
                ''prmParameter(14).Value = IIf(IsNothing(ot_financiando_seleccion.proveedor), 0, ot_financiando_seleccion.proveedor)
                ''prmParameter(14).Direction = ParameterDirection.Input
                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_t_financiando_seleccion_ins", prmParameter)

                Catch ex As Exception
                    Throw ex
                    Return False
                End Try
            Next
            Return True
        End Function



        Public Function t_financiando_seleccion_Update(ByVal oBE_t_financiando_seleccion As List(Of clsBE_t_financiando_seleccion)) As Boolean
            For Each ot_financiando_seleccion As clsBE_t_financiando_seleccion In oBE_t_financiando_seleccion
                Dim prmParameter(14) As SqlParameter

                prmParameter(0) = New SqlParameter("@item", SqlDbType.Int)
                prmParameter(0).Value = IIf(IsNothing(ot_financiando_seleccion.item), 0, ot_financiando_seleccion.item)
                prmParameter(0).Direction = ParameterDirection.Input

                prmParameter(1) = New SqlParameter("@nro_cierre", SqlDbType.Int)
                prmParameter(1).Value = IIf(IsNothing(ot_financiando_seleccion.nro_cierre), 0, ot_financiando_seleccion.nro_cierre)
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2) = New SqlParameter("@lote_vcm", SqlDbType.VarChar, 20)
                prmParameter(2).Value = IIf(IsNothing(ot_financiando_seleccion.lote_vcm), 0, ot_financiando_seleccion.lote_vcm)
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3) = New SqlParameter("@proveedor", SqlDbType.VarChar, 100)
                prmParameter(3).Value = IIf(IsNothing(ot_financiando_seleccion.proveedor), 0, ot_financiando_seleccion.proveedor)
                prmParameter(3).Direction = ParameterDirection.Input

                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_t_financiando_seleccion_upd", prmParameter)

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
    ''' Proposito: Obtiene los valores de la FINANCIANDO_PRELIQ FINANCIANDO_PRELIQ
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsDB_t_financiando_seleccionRO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionEN")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("EN")
        End Sub


        Public Function LeerListaToDSt_financiando_seleccion_sel(ByVal pt_financiando_seleccion As clsBE_t_financiando_seleccion) As DataSet
            Dim oDSt_financiando_seleccion As New DataSet
            Dim mintItem As Integer = 0
            Try
                Dim prmParameter(0) As SqlParameter

                prmParameter(0) = New SqlParameter("@ITEM", SqlDbType.Int)
                prmParameter(0).Value = IIf(IsNothing(pt_financiando_seleccion.item), 0, pt_financiando_seleccion.item)


                Using oDSt_financiando_seleccion
                    oDSt_financiando_seleccion = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_t_financiando_seleccion_sel", prmParameter)
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_PUB_PERSONAS_Sellst", oDSPUB_PERSONAS, New String() {"PUB_PERSONAS"}, prmParameter)
                    If Not oDSt_financiando_seleccion Is Nothing Then
                        If oDSt_financiando_seleccion.Tables.Count > 0 Then
                            'If oDSPUB_PERSONAS.Tables("PUB_PERSONAS").Rows.Count > 0 Then
                            If oDSt_financiando_seleccion.Tables(0).Rows.Count > 0 Then
                                Return oDSt_financiando_seleccion
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSt_financiando_seleccion

        End Function


    End Class
#End Region

End Namespace
