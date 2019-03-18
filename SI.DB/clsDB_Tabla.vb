


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
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla Tabla
    ''' Fecha Modificacion:
    ''' </summary>
	'''

	Public Class clsDB_TablaTX
		
		Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: Metodo de Insercci?n de Datos
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Function InsertarTabla(ByVal oLstTabla As List(Of clsBE_Tabla)) As Boolean
			For Each oTabla As clsBE_Tabla In oLstTabla
				Dim prmParameter(4) As SqlParameter
			
					prmParameter(0) = New SqlParameter("@ptablaId", SqlDbType.varchar , 20)
							prmParameter(0).Value = IIf(IsNothing(oTabla.tablaId), "", oTabla.tablaId)
					prmParameter(0).Direction = ParameterDirection.Input
					prmParameter(1) = New SqlParameter("@pdescri", SqlDbType.varchar , 100)
							prmParameter(1).Value = IIf(IsNothing(oTabla.descri), "", oTabla.descri)
					prmParameter(1).Direction = ParameterDirection.Input
					prmParameter(2) = New SqlParameter("@pcodigoEstado", SqlDbType.varchar , 15)
							prmParameter(2).Value = IIf(IsNothing(oTabla.codigoEstado), "", oTabla.codigoEstado)
					prmParameter(2).Direction = ParameterDirection.Input
					prmParameter(3) = New SqlParameter("@puc", SqlDbType.varchar , 15)
							prmParameter(3).Value = IIf(IsNothing(oTabla.uc), "", oTabla.uc)
					prmParameter(3).Direction = ParameterDirection.Input
					prmParameter(4) = New SqlParameter("@pcodigoVisible", SqlDbType.varchar , 15)
							prmParameter(4).Value = IIf(IsNothing(oTabla.codigoVisible), "", oTabla.codigoVisible)
					prmParameter(4).Direction = ParameterDirection.Input
				Try		
				    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_Tabla_Ins", prmParameter)
				Catch ex As Exception
					Throw ex					
					Return False
				End Try
			Next
			Return True
        End Function
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: Metodo de Modificacion de datos
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Function ModificarTabla(ByVal oLstTabla As List(Of clsBE_Tabla)) As Boolean
			For Each oTabla As clsBE_Tabla In oLstTabla
				Dim prmParameter(5) As SqlParameter
					prmParameter(0) = New SqlParameter("@ptablaId", SqlDbType.varchar , 20)
							prmParameter(0).Value = IIf(IsNothing(oTabla.tablaId), "", oTabla.tablaId)
					prmParameter(0).Direction = ParameterDirection.Input
					prmParameter(1) = New SqlParameter("@pdescri", SqlDbType.varchar , 100)
							prmParameter(1).Value = IIf(IsNothing(oTabla.descri), "", oTabla.descri)
					prmParameter(1).Direction = ParameterDirection.Input
					prmParameter(2) = New SqlParameter("@pcodigoEstado", SqlDbType.varchar , 15)
							prmParameter(2).Value = IIf(IsNothing(oTabla.codigoEstado), "", oTabla.codigoEstado)
					prmParameter(2).Direction = ParameterDirection.Input
					prmParameter(3) = New SqlParameter("@pum", SqlDbType.varchar , 15)
							prmParameter(3).Value = IIf(IsNothing(oTabla.um), "", oTabla.um)
					prmParameter(3).Direction = ParameterDirection.Input
					prmParameter(4) = New SqlParameter("@pfm", SqlDbType.DateTime , 8)
						prmParameter(4).Value = clsUT_Funcion.FechaNull(oTabla.fm)
					prmParameter(4).Direction = ParameterDirection.Input
					prmParameter(5) = New SqlParameter("@pcodigoVisible", SqlDbType.varchar , 15)
							prmParameter(5).Value = IIf(IsNothing(oTabla.codigoVisible), "", oTabla.codigoVisible)
					prmParameter(5).Direction = ParameterDirection.Input
				Try		
				    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_Tabla_Upd", prmParameter)
					Catch ex As Exception
					Throw ex					
					Return False
				End Try
			Next
			Return True
        End Function

		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:46
        ''' Proposito: Metodo de Elimacion
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Function EliminarTabla(ByVal oLstTabla As List(Of clsBE_Tabla)) As Boolean
			For Each oTabla As clsBE_Tabla In oLstTabla
				Dim prmParameter(0) As SqlParameter
					prmParameter(0) = New SqlParameter("@ptablaId", SqlDbType.varchar , 20)
							prmParameter(0).Value = IIf(IsNothing(oTabla.tablaId), "", oTabla.tablaId)
					prmParameter(0).Direction = ParameterDirection.Input
				Try		
				    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_Tabla_Del", prmParameter)
					Catch ex As Exception
					Throw ex					
					Return False
				End Try
			Next
			Return True
        End Function
		
			'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:46
        ''' Proposito: Metodo de Guardar Dataset
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Function GuardarTabla(ByVal oDSTabla As Dataset) As Boolean
		 Dim cnxCPO As New SqlConnection(CadenaConexion)
		 

            Try
                Dim objCommnadInsert As New SqlCommand                
				objCommnadInsert.Connection = cnxCPO
                objCommnadInsert.CommandText = "up_Tabla_Ins"
                objCommnadInsert.CommandType = CommandType.StoredProcedure					
			
					objCommnadInsert.Parameters.Add( "@ptablaId", SqlDbType.varchar , 20).SourceColumn = "tablaId"								
					objCommnadInsert.Parameters.Add( "@pdescri", SqlDbType.varchar , 100).SourceColumn = "descri"								
					objCommnadInsert.Parameters.Add( "@pcodigoEstado", SqlDbType.varchar , 15).SourceColumn = "codigoEstado"								
					objCommnadInsert.Parameters.Add( "@puc", SqlDbType.varchar , 15).SourceColumn = "uc"								
					objCommnadInsert.Parameters.Add( "@pcodigoVisible", SqlDbType.varchar , 15).SourceColumn = "codigoVisible"								
				
				Dim objCommandUpdate As New SqlCommand
                objCommandUpdate.Connection = cnxCPO
                objCommandUpdate.CommandText = "up_Tabla_Upd"
                objCommandUpdate.CommandType = CommandType.StoredProcedure
				
					objCommandUpdate.Parameters.Add( "@ptablaId", SqlDbType.varchar , 20).SourceColumn = "tablaId"								
					objCommandUpdate.Parameters.Add( "@pdescri", SqlDbType.varchar , 100).SourceColumn = "descri"								
					objCommandUpdate.Parameters.Add( "@pcodigoEstado", SqlDbType.varchar , 15).SourceColumn = "codigoEstado"								
					objCommandUpdate.Parameters.Add( "@pum", SqlDbType.varchar , 15).SourceColumn = "um"								
					objCommandUpdate.Parameters.Add( "@pfm", SqlDbType.DateTime , 8).SourceColumn = "fm"								
					objCommandUpdate.Parameters.Add( "@pcodigoVisible", SqlDbType.varchar , 15).SourceColumn = "codigoVisible"								
				
				Dim objCommandDelete As New SqlCommand
                objCommandDelete.Connection = cnxCPO
                objCommandDelete.CommandText = "up_Tabla_Del"
                objCommandDelete.CommandType = CommandType.StoredProcedure
				
					objCommandDelete.Parameters.Add( "@ptablaId", SqlDbType.varchar , 20).SourceColumn = "tablaId"								
				
				'SqlHelper.UpdateDataset(objCommnadInsert, objCommandDelete, objCommandUpdate, oDSTabla, "Tabla")

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
    ''' Proposito: Obtiene los valores de la tabla Tabla
    ''' Fecha Modificacion:
    ''' </summary>
	'''
	<Serializable()> _
    Public Class clsDB_TablaRO
		Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion =System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:46
        ''' Proposito: Lee los datos de un registro
        ''' Fecha Modificacion:
        ''' </summary>
        ''' 
        Public Function LeerTabla(ByVal pTabla As clsBE_Tabla) As clsBE_Tabla
			Dim oTabla As clsBE_Tabla = Nothing
			 Dim DSTabla  As New DataSet
			Dim prmParameter(0) As SqlParameter
					prmParameter(0) = New SqlParameter("@ptablaId", SqlDbType.varchar , 20)
							prmParameter(0).Value = IIf(IsNothing(pTabla.tablaId), "", pTabla.tablaId)
			Try		
			 Using DSTabla
                    DSTabla = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_Tabla_Sel", prmParameter)
                    If Not DSTabla Is Nothing Then
                        If DSTabla.Tables.Count > 0 Then
							oTabla = new clsBE_Tabla
                            If DSTabla.Tables(0).Rows.Count > 0 Then
                                With DSTabla.Tables(0).Rows(0)
									    oTabla.tablaId = .Item("tablaId").tostring
									    oTabla.descri = .Item("descri").tostring
									    oTabla.codigoEstado = .Item("codigoEstado").tostring
									    oTabla.uc = .Item("uc").tostring
									    oTabla.fc = .Item("fc").tostring
									    oTabla.codigoVisible = .Item("codigoVisible").tostring
                            	End With
							End If
						End If
					End If
                End Using	
			Catch exSql As SqlException
			
            Catch ex As Exception
				Throw ex	
			Finally
                If Not DSTabla Is Nothing Then
                    DSTabla.Dispose()
                End If
                DSTabla = Nothing
            End Try
		
		    Return oTabla		
        
        End Function


        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:46
        ''' Proposito: Obtiene la lista de registros
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaTabla() As List(Of clsBE_Tabla)
			Dim olstTabla As New List(Of clsBE_Tabla)
            Dim oTabla As clsBE_Tabla = Nothing
            Dim mintItem As Integer = 0
			Try	
				Using Reader As SqlDataReader = SqlHelper.ExecuteReader(CadenaConexion, CommandType.StoredProcedure, "up_Tabla_Sellst")
                    If Reader.HasRows Then
                        While reader.Read
                            oTabla = New clsBE_Tabla
                            mintItem += 1
                            With oTabla
                                .Item = mintItem
								
										.tablaId = Reader("tablaId").tostring
										.descri = Reader("descri").tostring
										.codigoEstado = Reader("codigoEstado").tostring
										.uc = Reader("uc").tostring
										.fc = Reader("fc").tostring
										.um = Reader("um").tostring
										.fm = Reader("fm").tostring
										.codigoVisible = Reader("codigoVisible").tostring
							End With
                            olstTabla.Add(oTabla)
                        End While
                    End If
                End Using
			Catch ex As Exception
				Throw ex				                
            End Try
			
            Return olstTabla
			
        End Function
		
		''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:46
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
		Public Function LeerListaToDSTabla(ByVal pTabla As clsBE_Tabla) As Dataset
			Dim oDSTabla As New DataSet				
			Dim mintItem As Integer = 0
            Dim prmParameter(-1) As SqlParameter
			Try	
								
				Using oDSTabla					
					oDSTabla = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_Tabla_Sellst", prmParameter)
					'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_Tabla_Sellst", oDSTabla, New String() {"Tabla"}, prmParameter)
					If Not oDSTabla Is Nothing Then
						If oDSTabla.Tables.Count > 0 Then
							'If oDSTabla.Tables("Tabla").Rows.Count > 0 Then
							If oDSTabla.Tables(0).Rows.Count > 0 Then
								Return oDSTabla
							End If
                        End If
                    End If
                End Using
			Catch ex As Exception
                Throw ex

            End Try
            Return oDSTabla					
			
        End Function
		
		
		''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:46
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
		public  function DefinirTablaTabla() As DataTable
			
		Try
			Dim DTTabla As New DataTable
			
			Dim tablaId As DataColumn = DTTabla.Columns.Add("tablaId", GetType(String))
						tablaId.MaxLength = 20
					tablaId.AllowDBNull = False
					tablaId.DefaultValue = ""
			
			Dim descri As DataColumn = DTTabla.Columns.Add("descri", GetType(String))
						descri.MaxLength = 100
					descri.AllowDBNull = True
					descri.DefaultValue = ""
			
			Dim codigoEstado As DataColumn = DTTabla.Columns.Add("codigoEstado", GetType(String))
						codigoEstado.MaxLength = 15
					codigoEstado.AllowDBNull = True
					codigoEstado.DefaultValue = ""
			
			Dim uc As DataColumn = DTTabla.Columns.Add("uc", GetType(String))
						uc.MaxLength = 15
					uc.AllowDBNull = True
					uc.DefaultValue = ""
			
			Dim fc As DataColumn = DTTabla.Columns.Add("fc", GetType(DateTime))

			
			Dim um As DataColumn = DTTabla.Columns.Add("um", GetType(String))
						um.MaxLength = 15
					um.AllowDBNull = True
					um.DefaultValue = ""
			
			Dim fm As DataColumn = DTTabla.Columns.Add("fm", GetType(DateTime))

			
			Dim codigoVisible As DataColumn = DTTabla.Columns.Add("codigoVisible", GetType(String))
						codigoVisible.MaxLength = 15
					codigoVisible.AllowDBNull = True
					codigoVisible.DefaultValue = ""
			
		Return DTTabla
        Catch ex As Exception
            Throw ex
        End Try
		End Function	
		
    End Class
#End Region
    
End Namespace
