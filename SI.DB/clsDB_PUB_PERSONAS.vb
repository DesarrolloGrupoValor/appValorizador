


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

    Public Class clsDB_PUB_PERSONASTX

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
    ''' Proposito: Obtiene los valores de la PUB_PERSONAS PUB_PERSONAS
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsDB_PUB_PERSONASRO
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
        ''    Public Function LeerPUB_PERSONAS() As clsBE_PUB_PERSONAS
        ''        Dim oPUB_PERSONAS As clsBE_PUB_PERSONAS = Nothing
        ''        Dim DSPUB_PERSONAS As New DataSet
        ''        Try
        ''            Using DSPUB_PERSONAS
        ''                DSPUB_PERSONAS = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_PUB_PERSONAS")
        ''                If Not DSPUB_PERSONAS Is Nothing Then
        ''                    If DSPUB_PERSONAS.Tables.Count > 0 Then
        ''                        oPUB_PERSONAS = New clsBE_PUB_PERSONAS
        ''                        If DSPUB_PERSONAS.Tables(0).Rows.Count > 0 Then
        ''                            With DSPUB_PERSONAS.Tables(0).Rows(0)
        ''                                oPUB_PERSONAS.COD_DEPOSITO = .Item("COD_DEPOSITO").ToString
        ''                                oPUB_PERSONAS.NOM_DEPOSITO = .Item("NOM_DEPOSITO").ToString

        ''                                oPUB_PERSONAS.EMPRESA = .Item("EMPRESA").ToString
        ''                                oPUB_PERSONAS.LOCALIDAD = .Item("LOCALIDAD").ToString
        ''                                oPUB_PERSONAS.DIRECCION = .Item("DIRECCION").ToString

        ''                                oPUB_PERSONAS.DESC_ABREV_DEP = .Item("DESC_ABREV_DEP").ToString
        ''                                oPUB_PERSONAS.FECHA_REG_DEP = .Item("FECHA_REG_DEP").ToString
        ''                                oPUB_PERSONAS.ID_LOCALIDAD = .Item("ID_LOCALIDAD").ToString
        ''                                oPUB_PERSONAS.DES_LOCALIDAD = .Item("DES_LOCALIDAD").ToString
        ''                            End With
        ''                        End If
        ''                    End If
        ''                End If
        ''            End Using
        ''        Catch exSql As SqlException

        ''        Catch ex As Exception
        ''            Throw ex
        ''        Finally
        ''            If Not DSPUB_PERSONAS Is Nothing Then
        ''                DSPUB_PERSONAS.Dispose()
        ''            End If
        ''            DSPUB_PERSONAS = Nothing
        ''        End Try

        ''        Return oPUB_PERSONAS

        ''    End Function


        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:46
        ''' Proposito: Obtiene la lista de registros
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaPUB_PERSONAS(Optional ByVal sTipo As String = "", Optional ByVal sIDPERSONA As String = "") As List(Of clsBE_PUB_PERSONAS)
            Dim olstPUB_PERSONAS As New List(Of clsBE_PUB_PERSONAS)
            Dim oPUB_PERSONAS As clsBE_PUB_PERSONAS = Nothing
            Dim mintItem As Integer = 0

            Dim prmParameter(0) As SqlParameter
            'prmParameter(0) = New SqlParameter("@tipo", SqlDbType.VarChar, 10)
            'prmParameter(0).Value = IIf(IsNothing(sTipo), "", sTipo)
            prmParameter(0) = New SqlParameter("@IDPERSONA", SqlDbType.VarChar, 20)
            prmParameter(0).Value = IIf(IsNothing(sIDPERSONA), "", sIDPERSONA)


            oPUB_PERSONAS = New clsBE_PUB_PERSONAS
            oPUB_PERSONAS.IDPERSONA = ""
            oPUB_PERSONAS.RAZON_SOCIAL = "[Seleccione]"
            olstPUB_PERSONAS.Add(oPUB_PERSONAS)

            Try
                Using Reader As SqlDataReader = SqlHelper.ExecuteReader(CadenaConexion, CommandType.StoredProcedure, "up_PUB_PERSONAS", prmParameter)
                    If Reader.HasRows Then
                        While Reader.Read
                            oPUB_PERSONAS = New clsBE_PUB_PERSONAS
                            mintItem += 1
                            With oPUB_PERSONAS
                                .Item = mintItem

                                'If sTipo = "AYUDA" Then
                                '    .IDPERSONA = Reader("codigo").ToString
                                '    .RAZON_SOCIAL = Reader("descripcion").ToString
                                'Else
                                .IDPERSONA = Reader("IDPERSONA").ToString
                                .RAZON_SOCIAL = Reader("RAZON_SOCIAL").ToString
                                .DIRECCION = Reader("DIRECCION").ToString
                                .CONTACTO = Reader("CONTACTO").ToString

                                .CELULAR1 = Reader("CELULAR1").ToString
                                .CORREO = Reader("CORREO").ToString


                                'End If



                            End With
                            olstPUB_PERSONAS.Add(oPUB_PERSONAS)
                        End While
                    End If
                End Using
            Catch ex As Exception
                Throw ex
            End Try

            Return olstPUB_PERSONAS

        End Function

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:46
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaToDSPUB_PERSONAS(ByVal pPUB_PERSONAS As clsBE_PUB_PERSONAS) As DataSet
            Dim oDSPUB_PERSONAS As New DataSet
            Dim mintItem As Integer = 0
            Try

                Using oDSPUB_PERSONAS
                    oDSPUB_PERSONAS = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_PUB_PERSONAS")
                    'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_PUB_PERSONAS_Sellst", oDSPUB_PERSONAS, New String() {"PUB_PERSONAS"}, prmParameter)
                    If Not oDSPUB_PERSONAS Is Nothing Then
                        If oDSPUB_PERSONAS.Tables.Count > 0 Then
                            'If oDSPUB_PERSONAS.Tables("PUB_PERSONAS").Rows.Count > 0 Then
                            If oDSPUB_PERSONAS.Tables(0).Rows.Count > 0 Then
                                Return oDSPUB_PERSONAS
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex

            End Try
            Return oDSPUB_PERSONAS

        End Function


        '' ''' <summary>
        '' ''' Escrito por: Martin Huaman
        '' ''' Fecha Creacion: 17/02/2011 16:58:46
        '' ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        '' ''' Fecha Modificacion:
        '' ''' </summary>
        ''Public Function DefinirPUB_PERSONASPUB_PERSONAS() As DataTable

        ''    Try
        ''        Dim DTPUB_PERSONAS As New DataTable

        ''        Dim PUB_PERSONASId As DataColumn = DTPUB_PERSONAS.Columns.Add("PUB_PERSONASId", GetType(String))
        ''        PUB_PERSONASId.MaxLength = 20
        ''        PUB_PERSONASId.AllowDBNull = False
        ''        PUB_PERSONASId.DefaultValue = ""

        ''        Dim descri As DataColumn = DTPUB_PERSONAS.Columns.Add("descri", GetType(String))
        ''        descri.MaxLength = 100
        ''        descri.AllowDBNull = True
        ''        descri.DefaultValue = ""

        ''        Dim codigoEstado As DataColumn = DTPUB_PERSONAS.Columns.Add("codigoEstado", GetType(String))
        ''        codigoEstado.MaxLength = 15
        ''        codigoEstado.AllowDBNull = True
        ''        codigoEstado.DefaultValue = ""

        ''        Dim uc As DataColumn = DTPUB_PERSONAS.Columns.Add("uc", GetType(String))
        ''        uc.MaxLength = 15
        ''        uc.AllowDBNull = True
        ''        uc.DefaultValue = ""

        ''        Dim fc As DataColumn = DTPUB_PERSONAS.Columns.Add("fc", GetType(DateTime))


        ''        Dim um As DataColumn = DTPUB_PERSONAS.Columns.Add("um", GetType(String))
        ''        um.MaxLength = 15
        ''        um.AllowDBNull = True
        ''        um.DefaultValue = ""

        ''        Dim fm As DataColumn = DTPUB_PERSONAS.Columns.Add("fm", GetType(DateTime))


        ''        Dim codigoVisible As DataColumn = DTPUB_PERSONAS.Columns.Add("codigoVisible", GetType(String))
        ''        codigoVisible.MaxLength = 15
        ''        codigoVisible.AllowDBNull = True
        ''        codigoVisible.DefaultValue = ""

        ''        Return DTPUB_PERSONAS
        ''    Catch ex As Exception
        ''        Throw ex
        ''    End Try
        ''End Function

    End Class
#End Region

End Namespace
