


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
    ''' Fecha Creacion: 17/02/2011 16:38:22
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla ConfiguracionContable
    ''' Fecha Modificacion:
    ''' </summary>
	'''

	Public Class clsDB_ConfiguracionContableTX
		
		Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:22
        ''' Proposito: Metodo de Insercci?n de Datos
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Function InsertarConfiguracionContable(ByVal oLstConfiguracionContable As List(Of clsBE_ConfiguracionContable)) As Boolean
			For Each oConfiguracionContable As clsBE_ConfiguracionContable In oLstConfiguracionContable
				Dim prmParameter(12) As SqlParameter
			
					prmParameter(0) = New SqlParameter("@pconfiguracionId", SqlDbType.varchar , 20)
							prmParameter(0).Value = IIf(IsNothing(oConfiguracionContable.configuracionId), "", oConfiguracionContable.configuracionId)
					prmParameter(0).Direction = ParameterDirection.Input
					prmParameter(1) = New SqlParameter("@pcodigoContableMercaderia", SqlDbType.varchar , 15)
							prmParameter(1).Value = IIf(IsNothing(oConfiguracionContable.codigoContableMercaderia), "", oConfiguracionContable.codigoContableMercaderia)
					prmParameter(1).Direction = ParameterDirection.Input
					prmParameter(2) = New SqlParameter("@pcodigoContableServicio", SqlDbType.varchar , 15)
							prmParameter(2).Value = IIf(IsNothing(oConfiguracionContable.codigoContableServicio), "", oConfiguracionContable.codigoContableServicio)
					prmParameter(2).Direction = ParameterDirection.Input
					prmParameter(3) = New SqlParameter("@pcodigoContableVariacion", SqlDbType.varchar , 15)
							prmParameter(3).Value = IIf(IsNothing(oConfiguracionContable.codigoContableVariacion), "", oConfiguracionContable.codigoContableVariacion)
					prmParameter(3).Direction = ParameterDirection.Input
					prmParameter(4) = New SqlParameter("@pcodigoContableCompra", SqlDbType.varchar , 15)
							prmParameter(4).Value = IIf(IsNothing(oConfiguracionContable.codigoContableCompra), "", oConfiguracionContable.codigoContableCompra)
					prmParameter(4).Direction = ParameterDirection.Input
					prmParameter(5) = New SqlParameter("@pcodigoContableImpuesto", SqlDbType.varchar , 15)
							prmParameter(5).Value = IIf(IsNothing(oConfiguracionContable.codigoContableImpuesto), "", oConfiguracionContable.codigoContableImpuesto)
					prmParameter(5).Direction = ParameterDirection.Input
					prmParameter(6) = New SqlParameter("@pcodigoContablePasivo", SqlDbType.varchar , 15)
							prmParameter(6).Value = IIf(IsNothing(oConfiguracionContable.codigoContablePasivo), "", oConfiguracionContable.codigoContablePasivo)
					prmParameter(6).Direction = ParameterDirection.Input
					prmParameter(7) = New SqlParameter("@pcodigoCosto", SqlDbType.varchar , 15)
							prmParameter(7).Value = IIf(IsNothing(oConfiguracionContable.codigoCosto), "", oConfiguracionContable.codigoCosto)
					prmParameter(7).Direction = ParameterDirection.Input
					prmParameter(8) = New SqlParameter("@pcodigoEstado", SqlDbType.varchar , 15)
							prmParameter(8).Value = IIf(IsNothing(oConfiguracionContable.codigoEstado), "", oConfiguracionContable.codigoEstado)
					prmParameter(8).Direction = ParameterDirection.Input
					prmParameter(9) = New SqlParameter("@puc", SqlDbType.varchar , 15)
							prmParameter(9).Value = IIf(IsNothing(oConfiguracionContable.uc), "", oConfiguracionContable.uc)
					prmParameter(9).Direction = ParameterDirection.Input
					prmParameter(10) = New SqlParameter("@pcodigoMovimiento", SqlDbType.varchar , 15)
							prmParameter(10).Value = IIf(IsNothing(oConfiguracionContable.codigoMovimiento), "", oConfiguracionContable.codigoMovimiento)
					prmParameter(10).Direction = ParameterDirection.Input
					prmParameter(11) = New SqlParameter("@pcodigoProducto", SqlDbType.varchar , 15)
							prmParameter(11).Value = IIf(IsNothing(oConfiguracionContable.codigoProducto), "", oConfiguracionContable.codigoProducto)
					prmParameter(11).Direction = ParameterDirection.Input
					prmParameter(12) = New SqlParameter("@pcodigoClase", SqlDbType.varchar , 15)
							prmParameter(12).Value = IIf(IsNothing(oConfiguracionContable.codigoClase), "", oConfiguracionContable.codigoClase)
					prmParameter(12).Direction = ParameterDirection.Input
				Try		
				    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_ConfiguracionContable_Ins", prmParameter)
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
		''' Fecha Creacion: 17/02/2011 16:38:23
        ''' Proposito: Metodo de Modificacion de datos
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Function ModificarConfiguracionContable(ByVal oLstConfiguracionContable As List(Of clsBE_ConfiguracionContable)) As Boolean
			For Each oConfiguracionContable As clsBE_ConfiguracionContable In oLstConfiguracionContable
				Dim prmParameter(13) As SqlParameter
					prmParameter(0) = New SqlParameter("@pconfiguracionId", SqlDbType.varchar , 20)
							prmParameter(0).Value = IIf(IsNothing(oConfiguracionContable.configuracionId), "", oConfiguracionContable.configuracionId)
					prmParameter(0).Direction = ParameterDirection.Input
					prmParameter(1) = New SqlParameter("@pcodigoContableMercaderia", SqlDbType.varchar , 15)
							prmParameter(1).Value = IIf(IsNothing(oConfiguracionContable.codigoContableMercaderia), "", oConfiguracionContable.codigoContableMercaderia)
					prmParameter(1).Direction = ParameterDirection.Input
					prmParameter(2) = New SqlParameter("@pcodigoContableServicio", SqlDbType.varchar , 15)
							prmParameter(2).Value = IIf(IsNothing(oConfiguracionContable.codigoContableServicio), "", oConfiguracionContable.codigoContableServicio)
					prmParameter(2).Direction = ParameterDirection.Input
					prmParameter(3) = New SqlParameter("@pcodigoContableVariacion", SqlDbType.varchar , 15)
							prmParameter(3).Value = IIf(IsNothing(oConfiguracionContable.codigoContableVariacion), "", oConfiguracionContable.codigoContableVariacion)
					prmParameter(3).Direction = ParameterDirection.Input
					prmParameter(4) = New SqlParameter("@pcodigoContableCompra", SqlDbType.varchar , 15)
							prmParameter(4).Value = IIf(IsNothing(oConfiguracionContable.codigoContableCompra), "", oConfiguracionContable.codigoContableCompra)
					prmParameter(4).Direction = ParameterDirection.Input
					prmParameter(5) = New SqlParameter("@pcodigoContableImpuesto", SqlDbType.varchar , 15)
							prmParameter(5).Value = IIf(IsNothing(oConfiguracionContable.codigoContableImpuesto), "", oConfiguracionContable.codigoContableImpuesto)
					prmParameter(5).Direction = ParameterDirection.Input
					prmParameter(6) = New SqlParameter("@pcodigoContablePasivo", SqlDbType.varchar , 15)
							prmParameter(6).Value = IIf(IsNothing(oConfiguracionContable.codigoContablePasivo), "", oConfiguracionContable.codigoContablePasivo)
					prmParameter(6).Direction = ParameterDirection.Input
					prmParameter(7) = New SqlParameter("@pcodigoCosto", SqlDbType.varchar , 15)
							prmParameter(7).Value = IIf(IsNothing(oConfiguracionContable.codigoCosto), "", oConfiguracionContable.codigoCosto)
					prmParameter(7).Direction = ParameterDirection.Input
					prmParameter(8) = New SqlParameter("@pcodigoEstado", SqlDbType.varchar , 15)
							prmParameter(8).Value = IIf(IsNothing(oConfiguracionContable.codigoEstado), "", oConfiguracionContable.codigoEstado)
					prmParameter(8).Direction = ParameterDirection.Input
					prmParameter(9) = New SqlParameter("@pum", SqlDbType.varchar , 15)
							prmParameter(9).Value = IIf(IsNothing(oConfiguracionContable.um), "", oConfiguracionContable.um)
					prmParameter(9).Direction = ParameterDirection.Input
					prmParameter(10) = New SqlParameter("@pfm", SqlDbType.DateTime , 8)
						prmParameter(10).Value = clsUT_Funcion.FechaNull(oConfiguracionContable.fm)
					prmParameter(10).Direction = ParameterDirection.Input
					prmParameter(11) = New SqlParameter("@pcodigoMovimiento", SqlDbType.varchar , 15)
							prmParameter(11).Value = IIf(IsNothing(oConfiguracionContable.codigoMovimiento), "", oConfiguracionContable.codigoMovimiento)
					prmParameter(11).Direction = ParameterDirection.Input
					prmParameter(12) = New SqlParameter("@pcodigoProducto", SqlDbType.varchar , 15)
							prmParameter(12).Value = IIf(IsNothing(oConfiguracionContable.codigoProducto), "", oConfiguracionContable.codigoProducto)
					prmParameter(12).Direction = ParameterDirection.Input
					prmParameter(13) = New SqlParameter("@pcodigoClase", SqlDbType.varchar , 15)
							prmParameter(13).Value = IIf(IsNothing(oConfiguracionContable.codigoClase), "", oConfiguracionContable.codigoClase)
					prmParameter(13).Direction = ParameterDirection.Input
				Try		
				    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_ConfiguracionContable_Upd", prmParameter)
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
		''' Fecha Creacion: 17/02/2011 16:38:23
        ''' Proposito: Metodo de Elimacion
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Function EliminarConfiguracionContable(ByVal oLstConfiguracionContable As List(Of clsBE_ConfiguracionContable)) As Boolean
			For Each oConfiguracionContable As clsBE_ConfiguracionContable In oLstConfiguracionContable
				Dim prmParameter(0) As SqlParameter
					prmParameter(0) = New SqlParameter("@pconfiguracionId", SqlDbType.varchar , 20)
							prmParameter(0).Value = IIf(IsNothing(oConfiguracionContable.configuracionId), "", oConfiguracionContable.configuracionId)
					prmParameter(0).Direction = ParameterDirection.Input
				Try		
				    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_ConfiguracionContable_Del", prmParameter)
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
		''' Fecha Creacion: 17/02/2011 16:38:23
        ''' Proposito: Metodo de Guardar Dataset
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Function GuardarConfiguracionContable(ByVal oDSConfiguracionContable As Dataset) As Boolean
		 Dim cnxCPO As New SqlConnection(CadenaConexion)
		 

            Try
                Dim objCommnadInsert As New SqlCommand                
				objCommnadInsert.Connection = cnxCPO
                objCommnadInsert.CommandText = "up_ConfiguracionContable_Ins"
                objCommnadInsert.CommandType = CommandType.StoredProcedure					
			
					objCommnadInsert.Parameters.Add( "@pconfiguracionId", SqlDbType.varchar , 20).SourceColumn = "configuracionId"								
					objCommnadInsert.Parameters.Add( "@pcodigoContableMercaderia", SqlDbType.varchar , 15).SourceColumn = "codigoContableMercaderia"								
					objCommnadInsert.Parameters.Add( "@pcodigoContableServicio", SqlDbType.varchar , 15).SourceColumn = "codigoContableServicio"								
					objCommnadInsert.Parameters.Add( "@pcodigoContableVariacion", SqlDbType.varchar , 15).SourceColumn = "codigoContableVariacion"								
					objCommnadInsert.Parameters.Add( "@pcodigoContableCompra", SqlDbType.varchar , 15).SourceColumn = "codigoContableCompra"								
					objCommnadInsert.Parameters.Add( "@pcodigoContableImpuesto", SqlDbType.varchar , 15).SourceColumn = "codigoContableImpuesto"								
					objCommnadInsert.Parameters.Add( "@pcodigoContablePasivo", SqlDbType.varchar , 15).SourceColumn = "codigoContablePasivo"								
					objCommnadInsert.Parameters.Add( "@pcodigoCosto", SqlDbType.varchar , 15).SourceColumn = "codigoCosto"								
					objCommnadInsert.Parameters.Add( "@pcodigoEstado", SqlDbType.varchar , 15).SourceColumn = "codigoEstado"								
					objCommnadInsert.Parameters.Add( "@puc", SqlDbType.varchar , 15).SourceColumn = "uc"								
					objCommnadInsert.Parameters.Add( "@pcodigoMovimiento", SqlDbType.varchar , 15).SourceColumn = "codigoMovimiento"								
					objCommnadInsert.Parameters.Add( "@pcodigoProducto", SqlDbType.varchar , 15).SourceColumn = "codigoProducto"								
					objCommnadInsert.Parameters.Add( "@pcodigoClase", SqlDbType.varchar , 15).SourceColumn = "codigoClase"								
				
				Dim objCommandUpdate As New SqlCommand
                objCommandUpdate.Connection = cnxCPO
                objCommandUpdate.CommandText = "up_ConfiguracionContable_Upd"
                objCommandUpdate.CommandType = CommandType.StoredProcedure
				
					objCommandUpdate.Parameters.Add( "@pconfiguracionId", SqlDbType.varchar , 20).SourceColumn = "configuracionId"								
					objCommandUpdate.Parameters.Add( "@pcodigoContableMercaderia", SqlDbType.varchar , 15).SourceColumn = "codigoContableMercaderia"								
					objCommandUpdate.Parameters.Add( "@pcodigoContableServicio", SqlDbType.varchar , 15).SourceColumn = "codigoContableServicio"								
					objCommandUpdate.Parameters.Add( "@pcodigoContableVariacion", SqlDbType.varchar , 15).SourceColumn = "codigoContableVariacion"								
					objCommandUpdate.Parameters.Add( "@pcodigoContableCompra", SqlDbType.varchar , 15).SourceColumn = "codigoContableCompra"								
					objCommandUpdate.Parameters.Add( "@pcodigoContableImpuesto", SqlDbType.varchar , 15).SourceColumn = "codigoContableImpuesto"								
					objCommandUpdate.Parameters.Add( "@pcodigoContablePasivo", SqlDbType.varchar , 15).SourceColumn = "codigoContablePasivo"								
					objCommandUpdate.Parameters.Add( "@pcodigoCosto", SqlDbType.varchar , 15).SourceColumn = "codigoCosto"								
					objCommandUpdate.Parameters.Add( "@pcodigoEstado", SqlDbType.varchar , 15).SourceColumn = "codigoEstado"								
					objCommandUpdate.Parameters.Add( "@pum", SqlDbType.varchar , 15).SourceColumn = "um"								
					objCommandUpdate.Parameters.Add( "@pfm", SqlDbType.DateTime , 8).SourceColumn = "fm"								
					objCommandUpdate.Parameters.Add( "@pcodigoMovimiento", SqlDbType.varchar , 15).SourceColumn = "codigoMovimiento"								
					objCommandUpdate.Parameters.Add( "@pcodigoProducto", SqlDbType.varchar , 15).SourceColumn = "codigoProducto"								
					objCommandUpdate.Parameters.Add( "@pcodigoClase", SqlDbType.varchar , 15).SourceColumn = "codigoClase"								
				
				Dim objCommandDelete As New SqlCommand
                objCommandDelete.Connection = cnxCPO
                objCommandDelete.CommandText = "up_ConfiguracionContable_Del"
                objCommandDelete.CommandType = CommandType.StoredProcedure
				
					objCommandDelete.Parameters.Add( "@pconfiguracionId", SqlDbType.varchar , 20).SourceColumn = "configuracionId"								
				
				'SqlHelper.UpdateDataset(objCommnadInsert, objCommandDelete, objCommandUpdate, oDSConfiguracionContable, "ConfiguracionContable")

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
    ''' Fecha Creacion: 17/02/2011 16:38:23
    ''' Proposito: Obtiene los valores de la tabla ConfiguracionContable
    ''' Fecha Modificacion:
    ''' </summary>
	'''
	<Serializable()> _
    Public Class clsDB_ConfiguracionContableRO
		Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion =System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:23
        ''' Proposito: Lee los datos de un registro
        ''' Fecha Modificacion:
        ''' </summary>
        ''' 
        Public Function LeerConfiguracionContable(ByVal pConfiguracionContable As clsBE_ConfiguracionContable) As clsBE_ConfiguracionContable
			Dim oConfiguracionContable As clsBE_ConfiguracionContable = Nothing
			 Dim DSConfiguracionContable  As New DataSet
			Dim prmParameter(0) As SqlParameter
					prmParameter(0) = New SqlParameter("@pconfiguracionId", SqlDbType.varchar , 20)
							prmParameter(0).Value = IIf(IsNothing(pConfiguracionContable.configuracionId), "", pConfiguracionContable.configuracionId)
			Try		
			 Using DSConfiguracionContable
                    DSConfiguracionContable = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_ConfiguracionContable_Sel", prmParameter)
                    If Not DSConfiguracionContable Is Nothing Then
                        If DSConfiguracionContable.Tables.Count > 0 Then
							oConfiguracionContable = new clsBE_ConfiguracionContable
                            If DSConfiguracionContable.Tables(0).Rows.Count > 0 Then
                                With DSConfiguracionContable.Tables(0).Rows(0)
									    oConfiguracionContable.configuracionId = .Item("configuracionId").tostring
									    oConfiguracionContable.codigoContableMercaderia = .Item("codigoContableMercaderia").tostring
									    oConfiguracionContable.codigoContableServicio = .Item("codigoContableServicio").tostring
									    oConfiguracionContable.codigoContableVariacion = .Item("codigoContableVariacion").tostring
									    oConfiguracionContable.codigoContableCompra = .Item("codigoContableCompra").tostring
									    oConfiguracionContable.codigoContableImpuesto = .Item("codigoContableImpuesto").tostring
									    oConfiguracionContable.codigoContablePasivo = .Item("codigoContablePasivo").tostring
									    oConfiguracionContable.codigoCosto = .Item("codigoCosto").tostring
									    oConfiguracionContable.codigoEstado = .Item("codigoEstado").tostring
									    oConfiguracionContable.uc = .Item("uc").tostring
									    oConfiguracionContable.fc = .Item("fc").tostring
									    oConfiguracionContable.codigoMovimiento = .Item("codigoMovimiento").tostring
									    oConfiguracionContable.codigoProducto = .Item("codigoProducto").tostring
									    oConfiguracionContable.codigoClase = .Item("codigoClase").tostring
                            	End With
							End If
						End If
					End If
                End Using	
			Catch exSql As SqlException
			
            Catch ex As Exception
				Throw ex	
			Finally
                If Not DSConfiguracionContable Is Nothing Then
                    DSConfiguracionContable.Dispose()
                End If
                DSConfiguracionContable = Nothing
            End Try
		
		    Return oConfiguracionContable		
        
        End Function


        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:23
        ''' Proposito: Obtiene la lista de registros
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaConfiguracionContable() As List(Of clsBE_ConfiguracionContable)
			Dim olstConfiguracionContable As New List(Of clsBE_ConfiguracionContable)
            Dim oConfiguracionContable As clsBE_ConfiguracionContable = Nothing
            Dim mintItem As Integer = 0
			Try	
				Using Reader As SqlDataReader = SqlHelper.ExecuteReader(CadenaConexion, CommandType.StoredProcedure, "up_ConfiguracionContable_Sellst")
                    If Reader.HasRows Then
                        While reader.Read
                            oConfiguracionContable = New clsBE_ConfiguracionContable
                            mintItem += 1
                            With oConfiguracionContable
                                .Item = mintItem
								
										.configuracionId = Reader("configuracionId").tostring
										.codigoContableMercaderia = Reader("codigoContableMercaderia").tostring
										.codigoContableServicio = Reader("codigoContableServicio").tostring
										.codigoContableVariacion = Reader("codigoContableVariacion").tostring
										.codigoContableCompra = Reader("codigoContableCompra").tostring
										.codigoContableImpuesto = Reader("codigoContableImpuesto").tostring
										.codigoContablePasivo = Reader("codigoContablePasivo").tostring
										.codigoCosto = Reader("codigoCosto").tostring
										.codigoEstado = Reader("codigoEstado").tostring
										.uc = Reader("uc").tostring
										.fc = Reader("fc").tostring
										.um = Reader("um").tostring
										.fm = Reader("fm").tostring
										.codigoMovimiento = Reader("codigoMovimiento").tostring
										.codigoProducto = Reader("codigoProducto").tostring
										.codigoClase = Reader("codigoClase").tostring
							End With
                            olstConfiguracionContable.Add(oConfiguracionContable)
                        End While
                    End If
                End Using
			Catch ex As Exception
				Throw ex				                
            End Try
			
            Return olstConfiguracionContable
			
        End Function
		
		''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:23
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
		Public Function LeerListaToDSConfiguracionContable(ByVal pConfiguracionContable As clsBE_ConfiguracionContable) As Dataset
			Dim oDSConfiguracionContable As New DataSet				
			Dim mintItem As Integer = 0
            Dim prmParameter(-1) As SqlParameter
			Try	
								
				Using oDSConfiguracionContable					
					oDSConfiguracionContable = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_ConfiguracionContable_Sellst", prmParameter)
					'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_ConfiguracionContable_Sellst", oDSConfiguracionContable, New String() {"ConfiguracionContable"}, prmParameter)
					If Not oDSConfiguracionContable Is Nothing Then
						If oDSConfiguracionContable.Tables.Count > 0 Then
							'If oDSConfiguracionContable.Tables("ConfiguracionContable").Rows.Count > 0 Then
							If oDSConfiguracionContable.Tables(0).Rows.Count > 0 Then
								Return oDSConfiguracionContable
							End If
                        End If
                    End If
                End Using
			Catch ex As Exception
                Throw ex

            End Try
            Return oDSConfiguracionContable					
			
        End Function
		
		
		''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:23
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
		public  function DefinirTablaConfiguracionContable() As DataTable
			
		Try
			Dim DTConfiguracionContable As New DataTable
			
			Dim configuracionId As DataColumn = DTConfiguracionContable.Columns.Add("configuracionId", GetType(String))
						configuracionId.MaxLength = 20
					configuracionId.AllowDBNull = False
					configuracionId.DefaultValue = ""
			
			Dim codigoContableMercaderia As DataColumn = DTConfiguracionContable.Columns.Add("codigoContableMercaderia", GetType(String))
						codigoContableMercaderia.MaxLength = 15
					codigoContableMercaderia.AllowDBNull = True
					codigoContableMercaderia.DefaultValue = ""
			
			Dim codigoContableServicio As DataColumn = DTConfiguracionContable.Columns.Add("codigoContableServicio", GetType(String))
						codigoContableServicio.MaxLength = 15
					codigoContableServicio.AllowDBNull = True
					codigoContableServicio.DefaultValue = ""
			
			Dim codigoContableVariacion As DataColumn = DTConfiguracionContable.Columns.Add("codigoContableVariacion", GetType(String))
						codigoContableVariacion.MaxLength = 15
					codigoContableVariacion.AllowDBNull = True
					codigoContableVariacion.DefaultValue = ""
			
			Dim codigoContableCompra As DataColumn = DTConfiguracionContable.Columns.Add("codigoContableCompra", GetType(String))
						codigoContableCompra.MaxLength = 15
					codigoContableCompra.AllowDBNull = True
					codigoContableCompra.DefaultValue = ""
			
			Dim codigoContableImpuesto As DataColumn = DTConfiguracionContable.Columns.Add("codigoContableImpuesto", GetType(String))
						codigoContableImpuesto.MaxLength = 15
					codigoContableImpuesto.AllowDBNull = True
					codigoContableImpuesto.DefaultValue = ""
			
			Dim codigoContablePasivo As DataColumn = DTConfiguracionContable.Columns.Add("codigoContablePasivo", GetType(String))
						codigoContablePasivo.MaxLength = 15
					codigoContablePasivo.AllowDBNull = True
					codigoContablePasivo.DefaultValue = ""
			
			Dim codigoCosto As DataColumn = DTConfiguracionContable.Columns.Add("codigoCosto", GetType(String))
						codigoCosto.MaxLength = 15
					codigoCosto.AllowDBNull = True
					codigoCosto.DefaultValue = ""
			
			Dim codigoEstado As DataColumn = DTConfiguracionContable.Columns.Add("codigoEstado", GetType(String))
						codigoEstado.MaxLength = 15
					codigoEstado.AllowDBNull = True
					codigoEstado.DefaultValue = ""
			
			Dim uc As DataColumn = DTConfiguracionContable.Columns.Add("uc", GetType(String))
						uc.MaxLength = 15
					uc.AllowDBNull = True
					uc.DefaultValue = ""
			
			Dim fc As DataColumn = DTConfiguracionContable.Columns.Add("fc", GetType(DateTime))

			
			Dim um As DataColumn = DTConfiguracionContable.Columns.Add("um", GetType(String))
						um.MaxLength = 15
					um.AllowDBNull = True
					um.DefaultValue = ""
			
			Dim fm As DataColumn = DTConfiguracionContable.Columns.Add("fm", GetType(DateTime))

			
			Dim codigoMovimiento As DataColumn = DTConfiguracionContable.Columns.Add("codigoMovimiento", GetType(String))
						codigoMovimiento.MaxLength = 15
					codigoMovimiento.AllowDBNull = True
					codigoMovimiento.DefaultValue = ""
			
			Dim codigoProducto As DataColumn = DTConfiguracionContable.Columns.Add("codigoProducto", GetType(String))
						codigoProducto.MaxLength = 15
					codigoProducto.AllowDBNull = True
					codigoProducto.DefaultValue = ""
			
			Dim codigoClase As DataColumn = DTConfiguracionContable.Columns.Add("codigoClase", GetType(String))
						codigoClase.MaxLength = 15
					codigoClase.AllowDBNull = True
					codigoClase.DefaultValue = ""
			
		Return DTConfiguracionContable
        Catch ex As Exception
            Throw ex
        End Try
		End Function	
		
    End Class
#End Region
    
End Namespace
