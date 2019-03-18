


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
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la PUB_PERSONAS PUB_PERSONAS
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsDB_GestionComercialTX

        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub

        
        Public Function GenerarGestionComercial_Ins(ByVal oBE_GestionComercial As clsBE_GestionComercial) As Boolean
            'Dim dsGestionComercial As New DataSet

            Dim prmParameter(10) As SqlParameter

            prmParameter(0) = New SqlParameter("@fechaEmision", SqlDbType.DateTime)
            prmParameter(0).Value = IIf(IsNothing(oBE_GestionComercial.dFechaEmision), "", oBE_GestionComercial.dFechaEmision)
            prmParameter(0).Direction = ParameterDirection.Input
            prmParameter(1) = New SqlParameter("@mes", SqlDbType.VarChar, 2)
            prmParameter(1).Value = IIf(IsNothing(oBE_GestionComercial.sMes), "", oBE_GestionComercial.sMes)
            prmParameter(1).Direction = ParameterDirection.Input
            prmParameter(2) = New SqlParameter("@mesDescripcion", SqlDbType.VarChar, 20)
            prmParameter(2).Value = IIf(IsNothing(oBE_GestionComercial.sMesDescripcion), "", oBE_GestionComercial.sMesDescripcion)
            prmParameter(2).Direction = ParameterDirection.Input
            prmParameter(3) = New SqlParameter("@anio", SqlDbType.VarChar, 4)
            prmParameter(3).Value = IIf(IsNothing(oBE_GestionComercial.sAnio), 0, oBE_GestionComercial.sAnio)
            prmParameter(3).Direction = ParameterDirection.Input
            prmParameter(4) = New SqlParameter("@TipoDocumento", SqlDbType.VarChar, 20)
            prmParameter(4).Value = IIf(IsNothing(oBE_GestionComercial.sTipoDocumento), "", oBE_GestionComercial.sTipoDocumento)
            prmParameter(4).Direction = ParameterDirection.Input
            prmParameter(5) = New SqlParameter("@NumeroDcoumento", SqlDbType.VarChar, 20)
            prmParameter(5).Value = IIf(IsNothing(oBE_GestionComercial.sNumeroDcoumento), "", oBE_GestionComercial.sNumeroDcoumento)
            prmParameter(5).Direction = ParameterDirection.Input
            prmParameter(6) = New SqlParameter("@Empresa", SqlDbType.VarChar, 20)
            prmParameter(6).Value = IIf(IsNothing(oBE_GestionComercial.sEmpresa), 0, oBE_GestionComercial.sEmpresa)
            prmParameter(6).Direction = ParameterDirection.Input
            prmParameter(7) = New SqlParameter("@Cliente", SqlDbType.VarChar, 20)
            prmParameter(7).Value = IIf(IsNothing(oBE_GestionComercial.sCliente), "", oBE_GestionComercial.sCliente)
            prmParameter(7).Direction = ParameterDirection.Input
            prmParameter(8) = New SqlParameter("@comision", SqlDbType.Float)
            prmParameter(8).Value = IIf(IsNothing(oBE_GestionComercial.nComision), "", oBE_GestionComercial.nComision)
            prmParameter(8).Direction = ParameterDirection.Input
            prmParameter(9) = New SqlParameter("@uc", SqlDbType.VarChar, 20)
            prmParameter(9).Value = IIf(IsNothing(oBE_GestionComercial.sUc), "", oBE_GestionComercial.sUc)
            prmParameter(9).Direction = ParameterDirection.Input

            prmParameter(10) = New SqlParameter("@GestionComercialId", SqlDbType.Int)
            prmParameter(10).Direction = ParameterDirection.Output

            Try

                SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_GestionComercial_insert", prmParameter)
                oBE_GestionComercial.nGestionComercialId = prmParameter(10).Value

                ''Using dsGestionComercial
                ''    dsGestionComercial = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_tbGestionComercial_sel", prmParameter)
                ''    If Not dsGestionComercial Is Nothing Then
                ''        If dsGestionComercial.Tables.Count > 0 Then
                ''            If dsGestionComercial.Tables(0).Rows.Count > 0 Then
                ''                Return dsGestionComercial
                ''            End If
                ''        End If
                ''    End If
                ''End Using
            Catch ex As Exception
                Throw ex
                Return False
            End Try
            'Return dsGestionComercial
            Return True
        End Function



        Public Function GenerarGestionComercial_Anu(ByVal oBE_GestionComercial As clsBE_GestionComercial) As Boolean

            Dim prmParameter(0) As SqlParameter

            prmParameter(0) = New SqlParameter("@GestionComercialId", SqlDbType.Int)
            prmParameter(0).Direction = ParameterDirection.Input
            prmParameter(0).Value = IIf(IsNothing(oBE_GestionComercial.nGestionComercialId), 0, oBE_GestionComercial.nGestionComercialId)

            Try
                SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_GestionComercial_anular", prmParameter)
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
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:46
    ''' Proposito: Obtiene los valores de la PUB_PERSONAS PUB_PERSONAS
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsDB_GestionComercialRO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
       

        


        ''Public Function GenerarGestionComercial(ByVal oBE_GestionComercial As clsBE_GestionComercial) As DataSet
        ''    Dim dsBE_GestionComercial As DataSet
        ''    Dim prmParameter(9) As SqlParameter

        ''    prmParameter(0) = New SqlParameter("@fechaEmision", SqlDbType.DateTime)
        ''    prmParameter(0).Value = IIf(IsNothing(oBE_GestionComercial.dFechaEmision), "", oBE_GestionComercial.dFechaEmision)
        ''    prmParameter(0).Direction = ParameterDirection.Input
        ''    prmParameter(1) = New SqlParameter("@mes", SqlDbType.VarChar, 2)
        ''    prmParameter(1).Value = IIf(IsNothing(oBE_GestionComercial.sMes), "", oBE_GestionComercial.sMes)
        ''    prmParameter(1).Direction = ParameterDirection.Input
        ''    prmParameter(2) = New SqlParameter("@mesDescripcion", SqlDbType.VarChar, 20)
        ''    prmParameter(2).Value = IIf(IsNothing(oBE_GestionComercial.sMesDescripcion), "", oBE_GestionComercial.sMesDescripcion)
        ''    prmParameter(2).Direction = ParameterDirection.Input
        ''    prmParameter(3) = New SqlParameter("@anio", SqlDbType.VarChar, 4)
        ''    prmParameter(3).Value = IIf(IsNothing(oBE_GestionComercial.sAnio), 0, oBE_GestionComercial.sAnio)
        ''    prmParameter(3).Direction = ParameterDirection.Input
        ''    prmParameter(4) = New SqlParameter("@TipoDocumento", SqlDbType.VarChar, 20)
        ''    prmParameter(4).Value = IIf(IsNothing(oBE_GestionComercial.sTipoDocumento), "", oBE_GestionComercial.sTipoDocumento)
        ''    prmParameter(4).Direction = ParameterDirection.Input
        ''    prmParameter(5) = New SqlParameter("@NumeroDcoumento", SqlDbType.VarChar, 20)
        ''    prmParameter(5).Value = IIf(IsNothing(oBE_GestionComercial.sNumeroDcoumento), "", oBE_GestionComercial.sNumeroDcoumento)
        ''    prmParameter(5).Direction = ParameterDirection.Input
        ''    prmParameter(6) = New SqlParameter("@Empresa", SqlDbType.VarChar, 20)
        ''    prmParameter(6).Value = IIf(IsNothing(oBE_GestionComercial.sEmpresa), 0, oBE_GestionComercial.sEmpresa)
        ''    prmParameter(6).Direction = ParameterDirection.Input
        ''    prmParameter(7) = New SqlParameter("@Cliente", SqlDbType.VarChar, 20)
        ''    prmParameter(7).Value = IIf(IsNothing(oBE_GestionComercial.sCliente), "", oBE_GestionComercial.sCliente)
        ''    prmParameter(7).Direction = ParameterDirection.Input
        ''    prmParameter(8) = New SqlParameter("@comision", SqlDbType.Float)
        ''    prmParameter(8).Value = IIf(IsNothing(oBE_GestionComercial.nComision), "", oBE_GestionComercial.nComision)
        ''    prmParameter(8).Direction = ParameterDirection.Input
        ''    prmParameter(9) = New SqlParameter("@uc", SqlDbType.VarChar, 20)
        ''    prmParameter(9).Value = IIf(IsNothing(oBE_GestionComercial.sUc), "", oBE_GestionComercial.sUc)
        ''    prmParameter(9).Direction = ParameterDirection.Input

        ''    Try
        ''        dsBE_GestionComercial = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_GestionComercial_insert", prmParameter)
        ''        'oContratoLote.contratoLoteId = prmParameter(0).Value
        ''    Catch ex As Exception
        ''        Throw ex
        ''        Return Nothing
        ''    End Try

        ''    Return dsBE_GestionComercial
        ''End Function


        Public Function LeerListaToDSGestionComercial(ByVal oBE_GestionComercial As clsBE_GestionComercial) As DataSet
            Dim dsGestionComercial As New DataSet

            Dim prmParameter(2) As SqlParameter

            prmParameter(0) = New SqlParameter("@empresaVCM", SqlDbType.VarChar, 20)
            prmParameter(0).Value = IIf(IsNothing(oBE_GestionComercial.sEmpresa), "", oBE_GestionComercial.sEmpresa)

            prmParameter(1) = New SqlParameter("@mes", SqlDbType.VarChar, 2)
            prmParameter(1).Value = IIf(IsNothing(oBE_GestionComercial.sMes), "", oBE_GestionComercial.sMes)

            prmParameter(2) = New SqlParameter("@anio", SqlDbType.VarChar, 4)
            prmParameter(2).Value = IIf(IsNothing(oBE_GestionComercial.sAnio), "", oBE_GestionComercial.sAnio)

            Try

                Using dsGestionComercial
                    dsGestionComercial = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_tbGestionComercial_sel", prmParameter)
                    If Not dsGestionComercial Is Nothing Then
                        If dsGestionComercial.Tables.Count > 0 Then
                            If dsGestionComercial.Tables(0).Rows.Count > 0 Then
                                Return dsGestionComercial
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return dsGestionComercial

        End Function

        Public Function LeerListaToDSGestionComercial_Sel(ByVal oBE_GestionComercial As clsBE_GestionComercial) As DataSet
            Dim dsGestionComercial As New DataSet

            Dim prmParameter(0) As SqlParameter

            prmParameter(0) = New SqlParameter("@GestionComercialId", SqlDbType.Int)
            prmParameter(0).Value = IIf(IsNothing(oBE_GestionComercial.nGestionComercialId), "", oBE_GestionComercial.nGestionComercialId)

            Try

                Using dsGestionComercial
                    dsGestionComercial = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_GestionComercial_Registro_Sel", prmParameter)
                    If Not dsGestionComercial Is Nothing Then
                        If dsGestionComercial.Tables.Count > 0 Then
                            If dsGestionComercial.Tables(0).Rows.Count > 0 Then
                                Return dsGestionComercial
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return dsGestionComercial

        End Function



        Public Function LeerListaToDSGestionComercial_SelAll(ByVal oBE_GestionComercial) As DataSet
            Dim dsGestionComercial As New DataSet

            Try
                Dim prmParameter(0) As SqlParameter

                prmParameter(0) = New SqlParameter("@GestionComercialId", SqlDbType.Int)
                prmParameter(0).Value = IIf(IsNothing(oBE_GestionComercial.nGestionComercialId), 0, oBE_GestionComercial.nGestionComercialId)


                Using dsGestionComercial
                    dsGestionComercial = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_GestionComercial_Registro_SelAll", prmParameter)
                    If Not dsGestionComercial Is Nothing Then
                        If dsGestionComercial.Tables.Count > 0 Then
                            If dsGestionComercial.Tables(0).Rows.Count > 0 Then
                                Return dsGestionComercial
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return dsGestionComercial

        End Function


    End Class
#End Region

End Namespace
