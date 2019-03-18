


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
    ''' Fecha Creacion: 17/02/2011 16:38:11
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla AsientoContable
    ''' Fecha Modificacion:
    ''' </summary>
	'''

	Public Class clsDB_AsientoContableTX
		
		Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:11
        ''' Proposito: Metodo de Insercci?n de Datos
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Function InsertarAsientoContable(ByVal oLstAsientoContable As List(Of clsBE_AsientoContable)) As Boolean
			For Each oAsientoContable As clsBE_AsientoContable In oLstAsientoContable
				Dim prmParameter(10) As SqlParameter
			
					prmParameter(0) = New SqlParameter("@pcontabilidadId", SqlDbType.varchar , 20)
							prmParameter(0).Value = IIf(IsNothing(oAsientoContable.contabilidadId), "", oAsientoContable.contabilidadId)
					prmParameter(0).Direction = ParameterDirection.Input
					prmParameter(1) = New SqlParameter("@pasientoId", SqlDbType.varchar , 20)
							prmParameter(1).Value = IIf(IsNothing(oAsientoContable.asientoId), "", oAsientoContable.asientoId)
					prmParameter(1).Direction = ParameterDirection.Input
					prmParameter(2) = New SqlParameter("@pcodigoContable", SqlDbType.varchar , 15)
							prmParameter(2).Value = IIf(IsNothing(oAsientoContable.codigoContable), "", oAsientoContable.codigoContable)
					prmParameter(2).Direction = ParameterDirection.Input
					prmParameter(3) = New SqlParameter("@pcodigoCosto", SqlDbType.varchar , 15)
							prmParameter(3).Value = IIf(IsNothing(oAsientoContable.codigoCosto), "", oAsientoContable.codigoCosto)
					prmParameter(3).Direction = ParameterDirection.Input
					prmParameter(4) = New SqlParameter("@pdebeSol", SqlDbType.Float , 4)
								prmParameter(4).Value = IIf(IsNothing(oAsientoContable.debeSol),0, oAsientoContable.debeSol)
					prmParameter(4).Direction = ParameterDirection.Input
					prmParameter(5) = New SqlParameter("@phaberSol", SqlDbType.Float , 4)
								prmParameter(5).Value = IIf(IsNothing(oAsientoContable.haberSol),0, oAsientoContable.haberSol)
					prmParameter(5).Direction = ParameterDirection.Input
					prmParameter(6) = New SqlParameter("@pdebeUsd", SqlDbType.Float , 4)
								prmParameter(6).Value = IIf(IsNothing(oAsientoContable.debeUsd),0, oAsientoContable.debeUsd)
					prmParameter(6).Direction = ParameterDirection.Input
					prmParameter(7) = New SqlParameter("@phaberUsd", SqlDbType.Float , 4)
								prmParameter(7).Value = IIf(IsNothing(oAsientoContable.haberUsd),0, oAsientoContable.haberUsd)
					prmParameter(7).Direction = ParameterDirection.Input
					prmParameter(8) = New SqlParameter("@pdescri", SqlDbType.varchar , 100)
							prmParameter(8).Value = IIf(IsNothing(oAsientoContable.descri), "", oAsientoContable.descri)
					prmParameter(8).Direction = ParameterDirection.Input
					prmParameter(9) = New SqlParameter("@pcodigoEstado", SqlDbType.varchar , 15)
							prmParameter(9).Value = IIf(IsNothing(oAsientoContable.codigoEstado), "", oAsientoContable.codigoEstado)
					prmParameter(9).Direction = ParameterDirection.Input
					prmParameter(10) = New SqlParameter("@puc", SqlDbType.varchar , 15)
							prmParameter(10).Value = IIf(IsNothing(oAsientoContable.uc), "", oAsientoContable.uc)
					prmParameter(10).Direction = ParameterDirection.Input
				Try		
				    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_AsientoContable_Ins", prmParameter)
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
		''' Fecha Creacion: 17/02/2011 16:38:11
        ''' Proposito: Metodo de Modificacion de datos
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Function ModificarAsientoContable(ByVal oLstAsientoContable As List(Of clsBE_AsientoContable)) As Boolean
			For Each oAsientoContable As clsBE_AsientoContable In oLstAsientoContable
				Dim prmParameter(11) As SqlParameter
					prmParameter(0) = New SqlParameter("@pcontabilidadId", SqlDbType.varchar , 20)
							prmParameter(0).Value = IIf(IsNothing(oAsientoContable.contabilidadId), "", oAsientoContable.contabilidadId)
					prmParameter(0).Direction = ParameterDirection.Input
					prmParameter(1) = New SqlParameter("@pasientoId", SqlDbType.varchar , 20)
							prmParameter(1).Value = IIf(IsNothing(oAsientoContable.asientoId), "", oAsientoContable.asientoId)
					prmParameter(1).Direction = ParameterDirection.Input
					prmParameter(2) = New SqlParameter("@pcodigoContable", SqlDbType.varchar , 15)
							prmParameter(2).Value = IIf(IsNothing(oAsientoContable.codigoContable), "", oAsientoContable.codigoContable)
					prmParameter(2).Direction = ParameterDirection.Input
					prmParameter(3) = New SqlParameter("@pcodigoCosto", SqlDbType.varchar , 15)
							prmParameter(3).Value = IIf(IsNothing(oAsientoContable.codigoCosto), "", oAsientoContable.codigoCosto)
					prmParameter(3).Direction = ParameterDirection.Input
					prmParameter(4) = New SqlParameter("@pdebeSol", SqlDbType.Float , 4)
							prmParameter(4).Value = IIf(IsNothing(oAsientoContable.debeSol),0, oAsientoContable.debeSol)
					prmParameter(4).Direction = ParameterDirection.Input
					prmParameter(5) = New SqlParameter("@phaberSol", SqlDbType.Float , 4)
							prmParameter(5).Value = IIf(IsNothing(oAsientoContable.haberSol),0, oAsientoContable.haberSol)
					prmParameter(5).Direction = ParameterDirection.Input
					prmParameter(6) = New SqlParameter("@pdebeUsd", SqlDbType.Float , 4)
							prmParameter(6).Value = IIf(IsNothing(oAsientoContable.debeUsd),0, oAsientoContable.debeUsd)
					prmParameter(6).Direction = ParameterDirection.Input
					prmParameter(7) = New SqlParameter("@phaberUsd", SqlDbType.Float , 4)
							prmParameter(7).Value = IIf(IsNothing(oAsientoContable.haberUsd),0, oAsientoContable.haberUsd)
					prmParameter(7).Direction = ParameterDirection.Input
					prmParameter(8) = New SqlParameter("@pdescri", SqlDbType.varchar , 100)
							prmParameter(8).Value = IIf(IsNothing(oAsientoContable.descri), "", oAsientoContable.descri)
					prmParameter(8).Direction = ParameterDirection.Input
					prmParameter(9) = New SqlParameter("@pcodigoEstado", SqlDbType.varchar , 15)
							prmParameter(9).Value = IIf(IsNothing(oAsientoContable.codigoEstado), "", oAsientoContable.codigoEstado)
					prmParameter(9).Direction = ParameterDirection.Input
					prmParameter(10) = New SqlParameter("@pum", SqlDbType.varchar , 15)
							prmParameter(10).Value = IIf(IsNothing(oAsientoContable.um), "", oAsientoContable.um)
					prmParameter(10).Direction = ParameterDirection.Input
					prmParameter(11) = New SqlParameter("@pfm", SqlDbType.DateTime , 8)
						prmParameter(11).Value = clsUT_Funcion.FechaNull(oAsientoContable.fm)
					prmParameter(11).Direction = ParameterDirection.Input
				Try		
				    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_AsientoContable_Upd", prmParameter)
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
		''' Fecha Creacion: 17/02/2011 16:38:12
        ''' Proposito: Metodo de Elimacion
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Function EliminarAsientoContable(ByVal oLstAsientoContable As List(Of clsBE_AsientoContable)) As Boolean
			For Each oAsientoContable As clsBE_AsientoContable In oLstAsientoContable
				Dim prmParameter(1) As SqlParameter
					prmParameter(0) = New SqlParameter("@pcontabilidadId", SqlDbType.varchar , 20)
							prmParameter(0).Value = IIf(IsNothing(oAsientoContable.contabilidadId), "", oAsientoContable.contabilidadId)
					prmParameter(0).Direction = ParameterDirection.Input
					prmParameter(1) = New SqlParameter("@pasientoId", SqlDbType.varchar , 20)
							prmParameter(1).Value = IIf(IsNothing(oAsientoContable.asientoId), "", oAsientoContable.asientoId)
					prmParameter(1).Direction = ParameterDirection.Input
				Try		
				    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_AsientoContable_Del", prmParameter)
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
		''' Fecha Creacion: 17/02/2011 16:38:12
        ''' Proposito: Metodo de Guardar Dataset
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Function GuardarAsientoContable(ByVal oDSAsientoContable As Dataset) As Boolean
		 Dim cnxCPO As New SqlConnection(CadenaConexion)
		 

            Try
                Dim objCommnadInsert As New SqlCommand                
				objCommnadInsert.Connection = cnxCPO
                objCommnadInsert.CommandText = "up_AsientoContable_Ins"
                objCommnadInsert.CommandType = CommandType.StoredProcedure					
			
					objCommnadInsert.Parameters.Add( "@pcontabilidadId", SqlDbType.varchar , 20).SourceColumn = "contabilidadId"								
					objCommnadInsert.Parameters.Add( "@pasientoId", SqlDbType.varchar , 20).SourceColumn = "asientoId"								
					objCommnadInsert.Parameters.Add( "@pcodigoContable", SqlDbType.varchar , 15).SourceColumn = "codigoContable"								
					objCommnadInsert.Parameters.Add( "@pcodigoCosto", SqlDbType.varchar , 15).SourceColumn = "codigoCosto"								
					objCommnadInsert.Parameters.Add( "@pdebeSol", SqlDbType.Float , 4).SourceColumn = "debeSol"								
					objCommnadInsert.Parameters.Add( "@phaberSol", SqlDbType.Float , 4).SourceColumn = "haberSol"								
					objCommnadInsert.Parameters.Add( "@pdebeUsd", SqlDbType.Float , 4).SourceColumn = "debeUsd"								
					objCommnadInsert.Parameters.Add( "@phaberUsd", SqlDbType.Float , 4).SourceColumn = "haberUsd"								
					objCommnadInsert.Parameters.Add( "@pdescri", SqlDbType.varchar , 100).SourceColumn = "descri"								
					objCommnadInsert.Parameters.Add( "@pcodigoEstado", SqlDbType.varchar , 15).SourceColumn = "codigoEstado"								
					objCommnadInsert.Parameters.Add( "@puc", SqlDbType.varchar , 15).SourceColumn = "uc"								
				
				Dim objCommandUpdate As New SqlCommand
                objCommandUpdate.Connection = cnxCPO
                objCommandUpdate.CommandText = "up_AsientoContable_Upd"
                objCommandUpdate.CommandType = CommandType.StoredProcedure
				
					objCommandUpdate.Parameters.Add( "@pcontabilidadId", SqlDbType.varchar , 20).SourceColumn = "contabilidadId"								
					objCommandUpdate.Parameters.Add( "@pasientoId", SqlDbType.varchar , 20).SourceColumn = "asientoId"								
					objCommandUpdate.Parameters.Add( "@pcodigoContable", SqlDbType.varchar , 15).SourceColumn = "codigoContable"								
					objCommandUpdate.Parameters.Add( "@pcodigoCosto", SqlDbType.varchar , 15).SourceColumn = "codigoCosto"								
					objCommandUpdate.Parameters.Add( "@pdebeSol", SqlDbType.Float , 4).SourceColumn = "debeSol"								
					objCommandUpdate.Parameters.Add( "@phaberSol", SqlDbType.Float , 4).SourceColumn = "haberSol"								
					objCommandUpdate.Parameters.Add( "@pdebeUsd", SqlDbType.Float , 4).SourceColumn = "debeUsd"								
					objCommandUpdate.Parameters.Add( "@phaberUsd", SqlDbType.Float , 4).SourceColumn = "haberUsd"								
					objCommandUpdate.Parameters.Add( "@pdescri", SqlDbType.varchar , 100).SourceColumn = "descri"								
					objCommandUpdate.Parameters.Add( "@pcodigoEstado", SqlDbType.varchar , 15).SourceColumn = "codigoEstado"								
					objCommandUpdate.Parameters.Add( "@pum", SqlDbType.varchar , 15).SourceColumn = "um"								
					objCommandUpdate.Parameters.Add( "@pfm", SqlDbType.DateTime , 8).SourceColumn = "fm"								
				
				Dim objCommandDelete As New SqlCommand
                objCommandDelete.Connection = cnxCPO
                objCommandDelete.CommandText = "up_AsientoContable_Del"
                objCommandDelete.CommandType = CommandType.StoredProcedure
				
					objCommandDelete.Parameters.Add( "@pcontabilidadId", SqlDbType.varchar , 20).SourceColumn = "contabilidadId"								
					objCommandDelete.Parameters.Add( "@pasientoId", SqlDbType.varchar , 20).SourceColumn = "asientoId"								
				
				'SqlHelper.UpdateDataset(objCommnadInsert, objCommandDelete, objCommandUpdate, oDSAsientoContable, "AsientoContable")

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
    ''' Fecha Creacion: 17/02/2011 16:38:12
    ''' Proposito: Obtiene los valores de la tabla AsientoContable
    ''' Fecha Modificacion:
    ''' </summary>
	'''
	<Serializable()> _
    Public Class clsDB_AsientoContableRO
		Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion =System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:12
        ''' Proposito: Lee los datos de un registro
        ''' Fecha Modificacion:
        ''' </summary>
        ''' 
        Public Function LeerAsientoContable(ByVal pAsientoContable As clsBE_AsientoContable) As clsBE_AsientoContable
			Dim oAsientoContable As clsBE_AsientoContable = Nothing
			 Dim DSAsientoContable  As New DataSet
			Dim prmParameter(1) As SqlParameter
					prmParameter(0) = New SqlParameter("@pcontabilidadId", SqlDbType.varchar , 20)
							prmParameter(0).Value = IIf(IsNothing(pAsientoContable.contabilidadId), "", pAsientoContable.contabilidadId)
					prmParameter(1) = New SqlParameter("@pasientoId", SqlDbType.varchar , 20)
							prmParameter(1).Value = IIf(IsNothing(pAsientoContable.asientoId), "", pAsientoContable.asientoId)
			Try		
			 Using DSAsientoContable
                    DSAsientoContable = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_AsientoContable_Sel", prmParameter)
                    If Not DSAsientoContable Is Nothing Then
                        If DSAsientoContable.Tables.Count > 0 Then
							oAsientoContable = new clsBE_AsientoContable
                            If DSAsientoContable.Tables(0).Rows.Count > 0 Then
                                With DSAsientoContable.Tables(0).Rows(0)
									    oAsientoContable.contabilidadId = .Item("contabilidadId").tostring
									    oAsientoContable.asientoId = .Item("asientoId").tostring
									    oAsientoContable.codigoContable = .Item("codigoContable").tostring
									    oAsientoContable.codigoCosto = .Item("codigoCosto").tostring
									    oAsientoContable.debeSol = .Item("debeSol").tostring
									    oAsientoContable.haberSol = .Item("haberSol").tostring
									    oAsientoContable.debeUsd = .Item("debeUsd").tostring
									    oAsientoContable.haberUsd = .Item("haberUsd").tostring
									    oAsientoContable.descri = .Item("descri").tostring
									    oAsientoContable.codigoEstado = .Item("codigoEstado").tostring
									    oAsientoContable.uc = .Item("uc").tostring
									    oAsientoContable.fc = .Item("fc").tostring
                            	End With
							End If
						End If
					End If
                End Using	
			Catch exSql As SqlException
			
            Catch ex As Exception
				Throw ex	
			Finally
                If Not DSAsientoContable Is Nothing Then
                    DSAsientoContable.Dispose()
                End If
                DSAsientoContable = Nothing
            End Try
		
		    Return oAsientoContable		
        
        End Function


        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:12
        ''' Proposito: Obtiene la lista de registros
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaAsientoContable() As List(Of clsBE_AsientoContable)
			Dim olstAsientoContable As New List(Of clsBE_AsientoContable)
            Dim oAsientoContable As clsBE_AsientoContable = Nothing
            Dim mintItem As Integer = 0
			Try	
				Using Reader As SqlDataReader = SqlHelper.ExecuteReader(CadenaConexion, CommandType.StoredProcedure, "up_AsientoContable_Sellst")
                    If Reader.HasRows Then
                        While reader.Read
                            oAsientoContable = New clsBE_AsientoContable
                            mintItem += 1
                            With oAsientoContable
                                .Item = mintItem
								
										.contabilidadId = Reader("contabilidadId").tostring
										.asientoId = Reader("asientoId").tostring
										.codigoContable = Reader("codigoContable").tostring
										.codigoCosto = Reader("codigoCosto").tostring
										.debeSol = Reader("debeSol").tostring
										.haberSol = Reader("haberSol").tostring
										.debeUsd = Reader("debeUsd").tostring
										.haberUsd = Reader("haberUsd").tostring
										.descri = Reader("descri").tostring
										.codigoEstado = Reader("codigoEstado").tostring
										.uc = Reader("uc").tostring
										.fc = Reader("fc").tostring
										.um = Reader("um").tostring
										.fm = Reader("fm").tostring
							End With
                            olstAsientoContable.Add(oAsientoContable)
                        End While
                    End If
                End Using
			Catch ex As Exception
				Throw ex				                
            End Try
			
            Return olstAsientoContable
			
        End Function
		
		''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:12
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
		Public Function LeerListaToDSAsientoContable(ByVal pAsientoContable As clsBE_AsientoContable) As Dataset
			Dim oDSAsientoContable As New DataSet				
			Dim mintItem As Integer = 0
            Dim prmParameter(0) As SqlParameter
					prmParameter(0) = New SqlParameter("@pcontabilidadId", SqlDbType.varchar , 20)
							prmParameter(0).Value = IIf(IsNothing(pAsientoContable.contabilidadId), "", pAsientoContable.contabilidadId)
			Try	
								
				Using oDSAsientoContable					
					oDSAsientoContable = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_AsientoContable_Sellst", prmParameter)
					'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_AsientoContable_Sellst", oDSAsientoContable, New String() {"AsientoContable"}, prmParameter)
					If Not oDSAsientoContable Is Nothing Then
						If oDSAsientoContable.Tables.Count > 0 Then
							'If oDSAsientoContable.Tables("AsientoContable").Rows.Count > 0 Then
							If oDSAsientoContable.Tables(0).Rows.Count > 0 Then
								Return oDSAsientoContable
							End If
                        End If
                    End If
                End Using
			Catch ex As Exception
                Throw ex

            End Try
            Return oDSAsientoContable					
			
        End Function
		
		
		''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:12
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
		public  function DefinirTablaAsientoContable() As DataTable
			
		Try
			Dim DTAsientoContable As New DataTable
			
			Dim contabilidadId As DataColumn = DTAsientoContable.Columns.Add("contabilidadId", GetType(String))
						contabilidadId.MaxLength = 20
					contabilidadId.AllowDBNull = False
					contabilidadId.DefaultValue = ""
			
			Dim asientoId As DataColumn = DTAsientoContable.Columns.Add("asientoId", GetType(String))
						asientoId.MaxLength = 20
					asientoId.AllowDBNull = False
					asientoId.DefaultValue = ""
			
			Dim codigoContable As DataColumn = DTAsientoContable.Columns.Add("codigoContable", GetType(String))
						codigoContable.MaxLength = 15
					codigoContable.AllowDBNull = True
					codigoContable.DefaultValue = ""
			
			Dim codigoCosto As DataColumn = DTAsientoContable.Columns.Add("codigoCosto", GetType(String))
						codigoCosto.MaxLength = 15
					codigoCosto.AllowDBNull = True
					codigoCosto.DefaultValue = ""
			
			Dim debeSol As DataColumn = DTAsientoContable.Columns.Add("debeSol", GetType(Integer))
        	debeSol.AllowDBNull = True
		    debeSol.DefaultValue =  0

			
			Dim haberSol As DataColumn = DTAsientoContable.Columns.Add("haberSol", GetType(Integer))
        	haberSol.AllowDBNull = True
		    haberSol.DefaultValue =  0

			
			Dim debeUsd As DataColumn = DTAsientoContable.Columns.Add("debeUsd", GetType(Integer))
        	debeUsd.AllowDBNull = True
		    debeUsd.DefaultValue =  0

			
			Dim haberUsd As DataColumn = DTAsientoContable.Columns.Add("haberUsd", GetType(Integer))
        	haberUsd.AllowDBNull = True
		    haberUsd.DefaultValue =  0

			
			Dim descri As DataColumn = DTAsientoContable.Columns.Add("descri", GetType(String))
						descri.MaxLength = 100
					descri.AllowDBNull = True
					descri.DefaultValue = ""
			
			Dim codigoEstado As DataColumn = DTAsientoContable.Columns.Add("codigoEstado", GetType(String))
						codigoEstado.MaxLength = 15
					codigoEstado.AllowDBNull = True
					codigoEstado.DefaultValue = ""
			
			Dim uc As DataColumn = DTAsientoContable.Columns.Add("uc", GetType(String))
						uc.MaxLength = 15
					uc.AllowDBNull = True
					uc.DefaultValue = ""
			
			Dim fc As DataColumn = DTAsientoContable.Columns.Add("fc", GetType(DateTime))

			
			Dim um As DataColumn = DTAsientoContable.Columns.Add("um", GetType(String))
						um.MaxLength = 15
					um.AllowDBNull = True
					um.DefaultValue = ""
			
			Dim fm As DataColumn = DTAsientoContable.Columns.Add("fm", GetType(DateTime))

			
		Return DTAsientoContable
        Catch ex As Exception
            Throw ex
        End Try
		End Function	
		
    End Class
#End Region
    
End Namespace
