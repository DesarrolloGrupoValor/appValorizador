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
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la ANEXOS_BANCO ANEXOS_BANCO
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsDB_TB_SERIE_DOCTX

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionEN")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("EN")
        End Sub

    End Class
#End Region


#Region "Clase Lectura"
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:46
    ''' Proposito: Obtiene los valores de la SERIE DE DOCUMENTO FACTURA ELECTRONINCA
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsDB_TB_SERIE_DOCRO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionEN")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("EN")

        End Sub

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:46
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSTB_SERIE_DOC(ByVal pSERIEDOC As clsBE_TB_SERIE_DOC) As DataSet
            Dim oDSTB_SERIE_DOC As New DataSet
            Dim mintItem As Integer = 0
            Try
                Dim prmParameter(1) As SqlParameter
                prmParameter(0) = New SqlParameter("@EMPRESA", SqlDbType.VarChar, 20)
                prmParameter(0).Value = IIf(IsNothing(pSERIEDOC.EMPRESA), "", pSERIEDOC.EMPRESA)

                prmParameter(1) = New SqlParameter("@OPERACION", SqlDbType.VarChar, 20)
                prmParameter(1).Value = IIf(IsNothing(pSERIEDOC.OPERACION), "", pSERIEDOC.OPERACION)

                prmParameter(2) = New SqlParameter("@TIPO", SqlDbType.VarChar, 20)
                prmParameter(2).Value = IIf(IsNothing(pSERIEDOC.TIPO), "", pSERIEDOC.TIPO)

                prmParameter(3) = New SqlParameter("@TIPODOC", SqlDbType.VarChar, 20)
                prmParameter(3).Value = IIf(IsNothing(pSERIEDOC.TIPODOC), "", pSERIEDOC.TIPODOC)

                Using oDSTB_SERIE_DOC

                    oDSTB_SERIE_DOC = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "PA_OBTENERSERIE", prmParameter)

                    If Not oDSTB_SERIE_DOC Is Nothing Then
                        If oDSTB_SERIE_DOC.Tables.Count > 0 Then
                            'If oDSANEXOS_BANCO.Tables("ANEXOS_BANCO").Rows.Count > 0 Then
                            If oDSTB_SERIE_DOC.Tables(0).Rows.Count > 0 Then
                                Return oDSTB_SERIE_DOC
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSTB_SERIE_DOC

        End Function

        Public Function LeerTB_SERIE_DOC(ByVal pSerieDoc As clsBE_TB_SERIE_DOC) As clsBE_TB_SERIE_DOC
            Dim oTB_SERIE_DOC As clsBE_TB_SERIE_DOC = Nothing
            Dim DSTB_SERIE_DOC As New DataSet
            Dim prmParameter(3) As SqlParameter
            prmParameter(0) = New SqlParameter("@EMPRESA", SqlDbType.VarChar, 10)
            prmParameter(0).Value = IIf(IsNothing(pSerieDoc.EMPRESA), "", pSerieDoc.EMPRESA)

            prmParameter(1) = New SqlParameter("@OPERACION", SqlDbType.VarChar, 4)
            prmParameter(1).Value = IIf(IsNothing(pSerieDoc.OPERACION), "", pSerieDoc.OPERACION)

            prmParameter(2) = New SqlParameter("@TIPO", SqlDbType.VarChar, 1)
            prmParameter(2).Value = IIf(IsNothing(pSerieDoc.TIPO), "", pSerieDoc.TIPO)

            prmParameter(3) = New SqlParameter("@TIPODOC", SqlDbType.VarChar, 1)
            prmParameter(3).Value = IIf(IsNothing(pSerieDoc.TIPODOC), "", pSerieDoc.TIPODOC)


            Try
                Using DSTB_SERIE_DOC
                    DSTB_SERIE_DOC = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "PA_OBTENERSERIE", prmParameter)
                    If Not DSTB_SERIE_DOC Is Nothing Then
                        If DSTB_SERIE_DOC.Tables.Count > 0 Then
                            oTB_SERIE_DOC = New clsBE_TB_SERIE_DOC
                            If DSTB_SERIE_DOC.Tables(0).Rows.Count > 0 Then
                                With DSTB_SERIE_DOC.Tables(0).Rows(0)
                                    oTB_SERIE_DOC.SERIE = .Item("SERIE").ToString
                                End With
                            End If
                        End If
                    End If
                End Using
            Catch exSql As SqlException

            Catch ex As Exception
                Throw ex
            Finally
                If Not DSTB_SERIE_DOC Is Nothing Then
                    DSTB_SERIE_DOC.Dispose()
                End If
                DSTB_SERIE_DOC = Nothing
            End Try

            Return oTB_SERIE_DOC

        End Function


    End Class
#End Region

End Namespace

