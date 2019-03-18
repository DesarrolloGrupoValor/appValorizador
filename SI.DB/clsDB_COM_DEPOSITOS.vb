


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
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la COM_DEPOSITOS COM_DEPOSITOS
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsDB_COM_DEPOSITOSTX

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
    ''' Proposito: Obtiene los valores de la COM_DEPOSITOS COM_DEPOSITOS
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsDB_COM_DEPOSITOSRO
        Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionEN")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("EN")
        End Sub
        ''    ''' <summary>
        ''    ''' Escrito por: Lissete Miyahira
        ''    ''' Fecha Creacion: 24/10/2012 16:58:46
        ''    ''' Proposito: Lee los datos de un registro
        ''    ''' Fecha Modificacion:
        ''    ''' </summary>
        ''    ''' 
        ''    Public Function LeerCOM_DEPOSITOS() As clsBE_COM_DEPOSITOS
        ''        Dim oCOM_DEPOSITOS As clsBE_COM_DEPOSITOS = Nothing
        ''        Dim DSCOM_DEPOSITOS As New DataSet
        ''        Try
        ''            Using DSCOM_DEPOSITOS
        ''                DSCOM_DEPOSITOS = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_com_depositos")
        ''                If Not DSCOM_DEPOSITOS Is Nothing Then
        ''                    If DSCOM_DEPOSITOS.Tables.Count > 0 Then
        ''                        oCOM_DEPOSITOS = New clsBE_COM_DEPOSITOS
        ''                        If DSCOM_DEPOSITOS.Tables(0).Rows.Count > 0 Then
        ''                            With DSCOM_DEPOSITOS.Tables(0).Rows(0)
        ''                                oCOM_DEPOSITOS.COD_DEPOSITO = .Item("COD_DEPOSITO").ToString
        ''                                oCOM_DEPOSITOS.NOM_DEPOSITO = .Item("NOM_DEPOSITO").ToString

        ''                                oCOM_DEPOSITOS.EMPRESA = .Item("EMPRESA").ToString
        ''                                oCOM_DEPOSITOS.LOCALIDAD = .Item("LOCALIDAD").ToString
        ''                                oCOM_DEPOSITOS.DIRECCION = .Item("DIRECCION").ToString

        ''                                oCOM_DEPOSITOS.DESC_ABREV_DEP = .Item("DESC_ABREV_DEP").ToString
        ''                                oCOM_DEPOSITOS.FECHA_REG_DEP = .Item("FECHA_REG_DEP").ToString
        ''                                oCOM_DEPOSITOS.ID_LOCALIDAD = .Item("ID_LOCALIDAD").ToString
        ''                                oCOM_DEPOSITOS.DES_LOCALIDAD = .Item("DES_LOCALIDAD").ToString
        ''                            End With
        ''                        End If
        ''                    End If
        ''                End If
        ''            End Using
        ''        Catch exSql As SqlException

        ''        Catch ex As Exception
        ''            Throw ex
        ''        Finally
        ''            If Not DSCOM_DEPOSITOS Is Nothing Then
        ''                DSCOM_DEPOSITOS.Dispose()
        ''            End If
        ''            DSCOM_DEPOSITOS = Nothing
        ''        End Try

        ''        Return oCOM_DEPOSITOS

        ''    End Function


        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:46
        ''' Proposito: Obtiene la lista de registros
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaCOM_DEPOSITOS() As List(Of clsBE_COM_DEPOSITOS)
            Dim olstCOM_DEPOSITOS As New List(Of clsBE_COM_DEPOSITOS)
            Dim oCOM_DEPOSITOS As clsBE_COM_DEPOSITOS = Nothing
            Dim mintItem As Integer = 0

            oCOM_DEPOSITOS = New clsBE_COM_DEPOSITOS
            oCOM_DEPOSITOS.COD_DEPOSITO = ""
            oCOM_DEPOSITOS.NOM_DEPOSITO = "[Seleccione]"
            olstCOM_DEPOSITOS.Add(oCOM_DEPOSITOS)
            Try
                Using Reader As SqlDataReader = SqlHelper.ExecuteReader(CadenaConexion, CommandType.StoredProcedure, "up_com_depositos")
                    If Reader.HasRows Then
                        While Reader.Read
                            oCOM_DEPOSITOS = New clsBE_COM_DEPOSITOS
                            mintItem += 1
                            With oCOM_DEPOSITOS
                                .Item = mintItem

                                .COD_DEPOSITO = Reader("COD_DEPOSITO").ToString
                                .NOM_DEPOSITO = Reader("NOM_DEPOSITO").ToString
                                .ID_LOCALIDAD = Reader("ID_LOCALIDAD").ToString
                                .DES_LOCALIDAD = Reader("DES_LOCALIDAD").ToString
                            End With
                            olstCOM_DEPOSITOS.Add(oCOM_DEPOSITOS)
                        End While
                    End If
                End Using
            Catch ex As Exception
                Throw ex
            End Try

            Return olstCOM_DEPOSITOS

        End Function

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:46
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSCOM_DEPOSITOS(ByVal pCOM_DEPOSITOS As clsBE_COM_DEPOSITOS) As DataSet
            Dim oDSCOM_DEPOSITOS As New DataSet
            Dim mintItem As Integer = 0
            Try

                Using oDSCOM_DEPOSITOS
                    oDSCOM_DEPOSITOS = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_com_depositos")
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_COM_DEPOSITOS_Sellst", oDSCOM_DEPOSITOS, New String() {"COM_DEPOSITOS"}, prmParameter)
                    If Not oDSCOM_DEPOSITOS Is Nothing Then
                        If oDSCOM_DEPOSITOS.Tables.Count > 0 Then
                            'If oDSCOM_DEPOSITOS.Tables("COM_DEPOSITOS").Rows.Count > 0 Then
                            If oDSCOM_DEPOSITOS.Tables(0).Rows.Count > 0 Then
                                Return oDSCOM_DEPOSITOS
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSCOM_DEPOSITOS

        End Function


        '' ''' <summary>
        '' ''' Escrito por: Martin Huaman
        '' ''' Fecha Creacion: 17/02/2011 16:58:46
        '' ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        '' ''' Fecha Modificacion:
        '' ''' </summary>
        ''Public Function DefinirCOM_DEPOSITOSCOM_DEPOSITOS() As DataTable

        ''    Try
        ''        Dim DTCOM_DEPOSITOS As New DataTable

        ''        Dim COM_DEPOSITOSId As DataColumn = DTCOM_DEPOSITOS.Columns.Add("COM_DEPOSITOSId", GetType(String))
        ''        COM_DEPOSITOSId.MaxLength = 20
        ''        COM_DEPOSITOSId.AllowDBNull = False
        ''        COM_DEPOSITOSId.DefaultValue = ""

        ''        Dim descri As DataColumn = DTCOM_DEPOSITOS.Columns.Add("descri", GetType(String))
        ''        descri.MaxLength = 100
        ''        descri.AllowDBNull = True
        ''        descri.DefaultValue = ""

        ''        Dim codigoEstado As DataColumn = DTCOM_DEPOSITOS.Columns.Add("codigoEstado", GetType(String))
        ''        codigoEstado.MaxLength = 15
        ''        codigoEstado.AllowDBNull = True
        ''        codigoEstado.DefaultValue = ""

        ''        Dim uc As DataColumn = DTCOM_DEPOSITOS.Columns.Add("uc", GetType(String))
        ''        uc.MaxLength = 15
        ''        uc.AllowDBNull = True
        ''        uc.DefaultValue = ""

        ''        Dim fc As DataColumn = DTCOM_DEPOSITOS.Columns.Add("fc", GetType(DateTime))


        ''        Dim um As DataColumn = DTCOM_DEPOSITOS.Columns.Add("um", GetType(String))
        ''        um.MaxLength = 15
        ''        um.AllowDBNull = True
        ''        um.DefaultValue = ""

        ''        Dim fm As DataColumn = DTCOM_DEPOSITOS.Columns.Add("fm", GetType(DateTime))


        ''        Dim codigoVisible As DataColumn = DTCOM_DEPOSITOS.Columns.Add("codigoVisible", GetType(String))
        ''        codigoVisible.MaxLength = 15
        ''        codigoVisible.AllowDBNull = True
        ''        codigoVisible.DefaultValue = ""

        ''        Return DTCOM_DEPOSITOS
        ''    Catch ex As Exception
        ''        Throw ex
        ''    End Try
        ''End Function

    End Class
#End Region

End Namespace
