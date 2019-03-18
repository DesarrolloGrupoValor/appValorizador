



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
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la TB_RECLASIFICA TB_RECLASIFICA
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsDB_TB_RECLASIFICATX

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionEN")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("EN")
        End Sub


        Public Function TB_RECLASIFICA_INSERT(ByVal oBE_TB_RECLASIFICA As List(Of clsBE_TB_RECLASIFICA)) As Boolean
            For Each oTB_RECLASIFICA As clsBE_TB_RECLASIFICA In oBE_TB_RECLASIFICA
                Dim prmParameter(24) As SqlParameter



                prmParameter(0) = New SqlParameter("@EMPRESA", SqlDbType.VarChar, 4)
                prmParameter(1) = New SqlParameter("@RUC", SqlDbType.VarChar, 30)
                prmParameter(2) = New SqlParameter("@PROVEEDOR", SqlDbType.VarChar, 510)
                prmParameter(3) = New SqlParameter("@DOCUM", SqlDbType.VarChar, 60)
                prmParameter(4) = New SqlParameter("@FECHA1", SqlDbType.DateTime)
                prmParameter(5) = New SqlParameter("@FECHA2", SqlDbType.DateTime)
                prmParameter(6) = New SqlParameter("@LOTEREF", SqlDbType.VarChar, 510)
                prmParameter(7) = New SqlParameter("@MONEDA", SqlDbType.VarChar, 4)
                prmParameter(8) = New SqlParameter("@DOLAR", SqlDbType.Float)
                prmParameter(9) = New SqlParameter("@SOLES", SqlDbType.Float)
                prmParameter(10) = New SqlParameter("@FACT", SqlDbType.VarChar, 8)
                prmParameter(11) = New SqlParameter("@FACTURA", SqlDbType.VarChar, 30)
                prmParameter(12) = New SqlParameter("@FLG_RECLASIFICA", SqlDbType.Int)
                prmParameter(13) = New SqlParameter("@USER_RECLA", SqlDbType.VarChar, 6)
                prmParameter(14) = New SqlParameter("@FECHA_RECLA", SqlDbType.DateTime)
                prmParameter(15) = New SqlParameter("@ID_ITEM", SqlDbType.Int)
                prmParameter(16) = New SqlParameter("@SUBDIA_CONTAB", SqlDbType.VarChar, 2)
                prmParameter(17) = New SqlParameter("@COMPR_CONTAB", SqlDbType.VarChar, 6)
                prmParameter(18) = New SqlParameter("@FACT_LIQUIDA", SqlDbType.VarChar, 15)
                prmParameter(19) = New SqlParameter("@T_CAMBIO", SqlDbType.Float)
                prmParameter(20) = New SqlParameter("@DOLAR_RECLA", SqlDbType.Float)
                prmParameter(21) = New SqlParameter("@SOLES_RECLA", SqlDbType.Float)
                prmParameter(22) = New SqlParameter("@LOTE_GEN", SqlDbType.VarChar, 10)
                prmParameter(23) = New SqlParameter("@LOTE_APL", SqlDbType.VarChar, 10)

                prmParameter(24) = New SqlParameter("@Item", SqlDbType.Int)


                prmParameter(0).Value = IIf(IsNothing(oTB_RECLASIFICA.EMPRESA), "", oTB_RECLASIFICA.EMPRESA)
                prmParameter(1).Value = IIf(IsNothing(oTB_RECLASIFICA.RUC), "", oTB_RECLASIFICA.RUC)
                prmParameter(2).Value = IIf(IsNothing(oTB_RECLASIFICA.PROVEEDOR), "", oTB_RECLASIFICA.PROVEEDOR)
                prmParameter(3).Value = IIf(IsNothing(oTB_RECLASIFICA.DOCUM), "", oTB_RECLASIFICA.DOCUM)
                prmParameter(4).Value = IIf(IsNothing(oTB_RECLASIFICA.FECHA1), "", oTB_RECLASIFICA.FECHA1)
                prmParameter(5).Value = IIf(IsNothing(oTB_RECLASIFICA.FECHA2), "", oTB_RECLASIFICA.FECHA2)
                prmParameter(6).Value = IIf(IsNothing(oTB_RECLASIFICA.LOTEREF), "", oTB_RECLASIFICA.LOTEREF)
                prmParameter(7).Value = IIf(IsNothing(oTB_RECLASIFICA.MONEDA), "", oTB_RECLASIFICA.MONEDA)
                prmParameter(8).Value = IIf(IsNothing(oTB_RECLASIFICA.DOLAR), 0, oTB_RECLASIFICA.DOLAR)
                prmParameter(9).Value = IIf(IsNothing(oTB_RECLASIFICA.SOLES), 0, oTB_RECLASIFICA.SOLES)
                prmParameter(10).Value = IIf(IsNothing(oTB_RECLASIFICA.FACT), "", oTB_RECLASIFICA.FACT)
                prmParameter(11).Value = IIf(IsNothing(oTB_RECLASIFICA.FACTURA), "", oTB_RECLASIFICA.FACTURA)
                prmParameter(12).Value = IIf(IsNothing(oTB_RECLASIFICA.FLG_RECLASIFICA), 0, oTB_RECLASIFICA.FLG_RECLASIFICA)
                prmParameter(13).Value = IIf(IsNothing(oTB_RECLASIFICA.USER_RECLA), "", oTB_RECLASIFICA.USER_RECLA)
                prmParameter(14).Value = IIf(IsNothing(oTB_RECLASIFICA.FECHA_RECLA), "", oTB_RECLASIFICA.FECHA_RECLA)
                prmParameter(15).Value = IIf(IsNothing(oTB_RECLASIFICA.ID_ITEM), "", oTB_RECLASIFICA.ID_ITEM)
                prmParameter(16).Value = IIf(IsNothing(oTB_RECLASIFICA.SUBDIA_CONTAB), "", oTB_RECLASIFICA.SUBDIA_CONTAB)
                prmParameter(17).Value = IIf(IsNothing(oTB_RECLASIFICA.COMPR_CONTAB), "", oTB_RECLASIFICA.COMPR_CONTAB)
                prmParameter(18).Value = IIf(IsNothing(oTB_RECLASIFICA.FACT_LIQUIDA), "", oTB_RECLASIFICA.FACT_LIQUIDA)
                prmParameter(19).Value = IIf(IsNothing(oTB_RECLASIFICA.T_CAMBIO), 0, oTB_RECLASIFICA.T_CAMBIO)
                prmParameter(20).Value = IIf(IsNothing(oTB_RECLASIFICA.DOLAR_RECLA), 0, oTB_RECLASIFICA.DOLAR_RECLA)
                prmParameter(21).Value = IIf(IsNothing(oTB_RECLASIFICA.SOLES_RECLA), 0, oTB_RECLASIFICA.SOLES_RECLA)
                prmParameter(22).Value = IIf(IsNothing(oTB_RECLASIFICA.LOTE_GEN), "", oTB_RECLASIFICA.LOTE_GEN)
                prmParameter(23).Value = IIf(IsNothing(oTB_RECLASIFICA.LOTE_APL), "", oTB_RECLASIFICA.LOTE_APL)

                prmParameter(24).Value = IIf(IsNothing(oTB_RECLASIFICA.ITEM), 0, oTB_RECLASIFICA.ITEM)


                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3).Direction = ParameterDirection.Input
                prmParameter(4).Direction = ParameterDirection.Input
                prmParameter(5).Direction = ParameterDirection.Input
                prmParameter(6).Direction = ParameterDirection.Input
                prmParameter(7).Direction = ParameterDirection.Input
                prmParameter(8).Direction = ParameterDirection.Input
                prmParameter(9).Direction = ParameterDirection.Input
                prmParameter(10).Direction = ParameterDirection.Input
                prmParameter(11).Direction = ParameterDirection.Input
                prmParameter(12).Direction = ParameterDirection.Input
                prmParameter(13).Direction = ParameterDirection.Input
                prmParameter(14).Direction = ParameterDirection.Input
                prmParameter(15).Direction = ParameterDirection.Input
                prmParameter(16).Direction = ParameterDirection.Input
                prmParameter(17).Direction = ParameterDirection.Input
                prmParameter(18).Direction = ParameterDirection.Input
                prmParameter(19).Direction = ParameterDirection.Input
                prmParameter(20).Direction = ParameterDirection.Input
                prmParameter(21).Direction = ParameterDirection.Input
                prmParameter(22).Direction = ParameterDirection.Input
                prmParameter(23).Direction = ParameterDirection.Input

                prmParameter(24).Direction = ParameterDirection.Input


              

                Try
                    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "usp_tb_reclasifica_Ins", prmParameter)

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
    ''' Proposito: Obtiene los valores de la TB_RECLASIFICA TB_RECLASIFICA
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsDB_TB_RECLASIFICARO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionEN")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("EN")
        End Sub


        Public Function LeerListaToDSTB_RECLASIFICA(ByVal oTB_RECLASIFICA As clsBE_TB_RECLASIFICA) As DataSet
            Dim oDSTB_RECLASIFICA As New DataSet
            Dim mintItem As Integer = 0
            Try

                Dim prmParameter(3) As SqlParameter

                prmParameter(0) = New SqlParameter("@RUC", SqlDbType.VarChar, 30)
                prmParameter(1) = New SqlParameter("@FACT", SqlDbType.VarChar, 8)
                prmParameter(2) = New SqlParameter("@FACTURA", SqlDbType.VarChar, 30)
                prmParameter(3) = New SqlParameter("@FLG_RECLASIFICA", SqlDbType.Int)

                prmParameter(0).Value = IIf(IsNothing(oTB_RECLASIFICA.RUC), "", oTB_RECLASIFICA.RUC)
                prmParameter(1).Value = IIf(IsNothing(oTB_RECLASIFICA.FACT), "", oTB_RECLASIFICA.FACT)
                prmParameter(2).Value = IIf(IsNothing(oTB_RECLASIFICA.FACTURA), "", oTB_RECLASIFICA.FACTURA)
                prmParameter(3).Value = IIf(IsNothing(oTB_RECLASIFICA.FLG_RECLASIFICA), 0, oTB_RECLASIFICA.FLG_RECLASIFICA)
                
                prmParameter(0).Direction = ParameterDirection.Input
                prmParameter(1).Direction = ParameterDirection.Input
                prmParameter(2).Direction = ParameterDirection.Input
                prmParameter(3).Direction = ParameterDirection.Input
                
                Using oDSTB_RECLASIFICA
                    oDSTB_RECLASIFICA = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "usp_tb_reclasifica_sellst", prmParameter)
                    If Not oDSTB_RECLASIFICA Is Nothing Then
                        If oDSTB_RECLASIFICA.Tables.Count > 0 Then
                            'If oDSTB_RECLASIFICA.Tables(0).Rows.Count > 0 Then
                            Return oDSTB_RECLASIFICA
                            'End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSTB_RECLASIFICA

        End Function

    End Class
#End Region

End Namespace
