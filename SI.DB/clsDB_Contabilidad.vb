


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
    ''' Fecha Creacion: 17/02/2011 16:38:33
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla Contabilidad
    ''' Fecha Modificacion:
    ''' </summary>
	'''

	Public Class clsDB_ContabilidadTX
		
		Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:33
        ''' Proposito: Metodo de Insercci?n de Datos
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Function InsertarContabilidad(ByVal oLstContabilidad As List(Of clsBE_Contabilidad)) As Boolean
			For Each oContabilidad As clsBE_Contabilidad In oLstContabilidad
				Dim prmParameter(7) As SqlParameter
			
					prmParameter(0) = New SqlParameter("@pcontabilidadId", SqlDbType.varchar , 20)
							prmParameter(0).Value = IIf(IsNothing(oContabilidad.contabilidadId), "", oContabilidad.contabilidadId)
					prmParameter(0).Direction = ParameterDirection.Input
					prmParameter(1) = New SqlParameter("@pperiodo", SqlDbType.varchar , 6)
							prmParameter(1).Value = IIf(IsNothing(oContabilidad.periodo), "", oContabilidad.periodo)
					prmParameter(1).Direction = ParameterDirection.Input
					prmParameter(2) = New SqlParameter("@pcodigoEstado", SqlDbType.varchar , 15)
							prmParameter(2).Value = IIf(IsNothing(oContabilidad.codigoEstado), "", oContabilidad.codigoEstado)
					prmParameter(2).Direction = ParameterDirection.Input
					prmParameter(3) = New SqlParameter("@puc", SqlDbType.varchar , 15)
							prmParameter(3).Value = IIf(IsNothing(oContabilidad.uc), "", oContabilidad.uc)
					prmParameter(3).Direction = ParameterDirection.Input
					prmParameter(4) = New SqlParameter("@pcodigoDiario", SqlDbType.varchar , 15)
							prmParameter(4).Value = IIf(IsNothing(oContabilidad.codigoDiario), "", oContabilidad.codigoDiario)
					prmParameter(4).Direction = ParameterDirection.Input
					prmParameter(5) = New SqlParameter("@pcodigoTransferido", SqlDbType.varchar , 15)
							prmParameter(5).Value = IIf(IsNothing(oContabilidad.codigoTransferido), "", oContabilidad.codigoTransferido)
					prmParameter(5).Direction = ParameterDirection.Input
					prmParameter(6) = New SqlParameter("@pcodigoEmpresa", SqlDbType.varchar , 15)
							prmParameter(6).Value = IIf(IsNothing(oContabilidad.codigoEmpresa), "", oContabilidad.codigoEmpresa)
					prmParameter(6).Direction = ParameterDirection.Input
					prmParameter(7) = New SqlParameter("@pfecha", SqlDbType.DateTime , 8)
						prmParameter(7).Value = clsUT_Funcion.FechaNull(oContabilidad.fecha)
					prmParameter(7).Direction = ParameterDirection.Input
				Try		
				    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_Contabilidad_Ins", prmParameter)
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
		''' Fecha Creacion: 17/02/2011 16:38:34
        ''' Proposito: Metodo de Modificacion de datos
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Function ModificarContabilidad(ByVal oLstContabilidad As List(Of clsBE_Contabilidad)) As Boolean
			For Each oContabilidad As clsBE_Contabilidad In oLstContabilidad
				Dim prmParameter(8) As SqlParameter
					prmParameter(0) = New SqlParameter("@pcontabilidadId", SqlDbType.varchar , 20)
							prmParameter(0).Value = IIf(IsNothing(oContabilidad.contabilidadId), "", oContabilidad.contabilidadId)
					prmParameter(0).Direction = ParameterDirection.Input
					prmParameter(1) = New SqlParameter("@pperiodo", SqlDbType.varchar , 6)
							prmParameter(1).Value = IIf(IsNothing(oContabilidad.periodo), "", oContabilidad.periodo)
					prmParameter(1).Direction = ParameterDirection.Input
					prmParameter(2) = New SqlParameter("@pcodigoEstado", SqlDbType.varchar , 15)
							prmParameter(2).Value = IIf(IsNothing(oContabilidad.codigoEstado), "", oContabilidad.codigoEstado)
					prmParameter(2).Direction = ParameterDirection.Input
					prmParameter(3) = New SqlParameter("@pum", SqlDbType.varchar , 15)
							prmParameter(3).Value = IIf(IsNothing(oContabilidad.um), "", oContabilidad.um)
					prmParameter(3).Direction = ParameterDirection.Input
					prmParameter(4) = New SqlParameter("@pfm", SqlDbType.DateTime , 8)
						prmParameter(4).Value = clsUT_Funcion.FechaNull(oContabilidad.fm)
					prmParameter(4).Direction = ParameterDirection.Input
					prmParameter(5) = New SqlParameter("@pcodigoDiario", SqlDbType.varchar , 15)
							prmParameter(5).Value = IIf(IsNothing(oContabilidad.codigoDiario), "", oContabilidad.codigoDiario)
					prmParameter(5).Direction = ParameterDirection.Input
					prmParameter(6) = New SqlParameter("@pcodigoTransferido", SqlDbType.varchar , 15)
							prmParameter(6).Value = IIf(IsNothing(oContabilidad.codigoTransferido), "", oContabilidad.codigoTransferido)
					prmParameter(6).Direction = ParameterDirection.Input
					prmParameter(7) = New SqlParameter("@pcodigoEmpresa", SqlDbType.varchar , 15)
							prmParameter(7).Value = IIf(IsNothing(oContabilidad.codigoEmpresa), "", oContabilidad.codigoEmpresa)
					prmParameter(7).Direction = ParameterDirection.Input
					prmParameter(8) = New SqlParameter("@pfecha", SqlDbType.DateTime , 8)
						prmParameter(8).Value = clsUT_Funcion.FechaNull(oContabilidad.fecha)
					prmParameter(8).Direction = ParameterDirection.Input
				Try		
				    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_Contabilidad_Upd", prmParameter)
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
		''' Fecha Creacion: 17/02/2011 16:38:34
        ''' Proposito: Metodo de Elimacion
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Function EliminarContabilidad(ByVal oLstContabilidad As List(Of clsBE_Contabilidad)) As Boolean
			For Each oContabilidad As clsBE_Contabilidad In oLstContabilidad
				Dim prmParameter(0) As SqlParameter
					prmParameter(0) = New SqlParameter("@pcontabilidadId", SqlDbType.varchar , 20)
							prmParameter(0).Value = IIf(IsNothing(oContabilidad.contabilidadId), "", oContabilidad.contabilidadId)
					prmParameter(0).Direction = ParameterDirection.Input
				Try		
				    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_Contabilidad_Del", prmParameter)
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
		''' Fecha Creacion: 17/02/2011 16:38:34
        ''' Proposito: Metodo de Guardar Dataset
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Function GuardarContabilidad(ByVal oDSContabilidad As Dataset) As Boolean
		 Dim cnxCPO As New SqlConnection(CadenaConexion)
		 

            Try
                Dim objCommnadInsert As New SqlCommand                
				objCommnadInsert.Connection = cnxCPO
                objCommnadInsert.CommandText = "up_Contabilidad_Ins"
                objCommnadInsert.CommandType = CommandType.StoredProcedure					
			
					objCommnadInsert.Parameters.Add( "@pcontabilidadId", SqlDbType.varchar , 20).SourceColumn = "contabilidadId"								
					objCommnadInsert.Parameters.Add( "@pperiodo", SqlDbType.varchar , 6).SourceColumn = "periodo"								
					objCommnadInsert.Parameters.Add( "@pcodigoEstado", SqlDbType.varchar , 15).SourceColumn = "codigoEstado"								
					objCommnadInsert.Parameters.Add( "@puc", SqlDbType.varchar , 15).SourceColumn = "uc"								
					objCommnadInsert.Parameters.Add( "@pcodigoDiario", SqlDbType.varchar , 15).SourceColumn = "codigoDiario"								
					objCommnadInsert.Parameters.Add( "@pcodigoTransferido", SqlDbType.varchar , 15).SourceColumn = "codigoTransferido"								
					objCommnadInsert.Parameters.Add( "@pcodigoEmpresa", SqlDbType.varchar , 15).SourceColumn = "codigoEmpresa"								
					objCommnadInsert.Parameters.Add( "@pfecha", SqlDbType.DateTime , 8).SourceColumn = "fecha"								
				
				Dim objCommandUpdate As New SqlCommand
                objCommandUpdate.Connection = cnxCPO
                objCommandUpdate.CommandText = "up_Contabilidad_Upd"
                objCommandUpdate.CommandType = CommandType.StoredProcedure
				
					objCommandUpdate.Parameters.Add( "@pcontabilidadId", SqlDbType.varchar , 20).SourceColumn = "contabilidadId"								
					objCommandUpdate.Parameters.Add( "@pperiodo", SqlDbType.varchar , 6).SourceColumn = "periodo"								
					objCommandUpdate.Parameters.Add( "@pcodigoEstado", SqlDbType.varchar , 15).SourceColumn = "codigoEstado"								
					objCommandUpdate.Parameters.Add( "@pum", SqlDbType.varchar , 15).SourceColumn = "um"								
					objCommandUpdate.Parameters.Add( "@pfm", SqlDbType.DateTime , 8).SourceColumn = "fm"								
					objCommandUpdate.Parameters.Add( "@pcodigoDiario", SqlDbType.varchar , 15).SourceColumn = "codigoDiario"								
					objCommandUpdate.Parameters.Add( "@pcodigoTransferido", SqlDbType.varchar , 15).SourceColumn = "codigoTransferido"								
					objCommandUpdate.Parameters.Add( "@pcodigoEmpresa", SqlDbType.varchar , 15).SourceColumn = "codigoEmpresa"								
					objCommandUpdate.Parameters.Add( "@pfecha", SqlDbType.DateTime , 8).SourceColumn = "fecha"								
				
				Dim objCommandDelete As New SqlCommand
                objCommandDelete.Connection = cnxCPO
                objCommandDelete.CommandText = "up_Contabilidad_Del"
                objCommandDelete.CommandType = CommandType.StoredProcedure
				
					objCommandDelete.Parameters.Add( "@pcontabilidadId", SqlDbType.varchar , 20).SourceColumn = "contabilidadId"								
				
				'SqlHelper.UpdateDataset(objCommnadInsert, objCommandDelete, objCommandUpdate, oDSContabilidad, "Contabilidad")

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
    ''' Fecha Creacion: 17/02/2011 16:38:34
    ''' Proposito: Obtiene los valores de la tabla Contabilidad
    ''' Fecha Modificacion:
    ''' </summary>
	'''
	<Serializable()> _
    Public Class clsDB_ContabilidadRO
		Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion =System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:34
        ''' Proposito: Lee los datos de un registro
        ''' Fecha Modificacion:
        ''' </summary>
        ''' 
        Public Function LeerContabilidad(ByVal pContabilidad As clsBE_Contabilidad) As clsBE_Contabilidad
			Dim oContabilidad As clsBE_Contabilidad = Nothing
			 Dim DSContabilidad  As New DataSet
			Dim prmParameter(0) As SqlParameter
					prmParameter(0) = New SqlParameter("@pcontabilidadId", SqlDbType.varchar , 20)
							prmParameter(0).Value = IIf(IsNothing(pContabilidad.contabilidadId), "", pContabilidad.contabilidadId)
			Try		
			 Using DSContabilidad
                    DSContabilidad = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_Contabilidad_Sel", prmParameter)
                    If Not DSContabilidad Is Nothing Then
                        If DSContabilidad.Tables.Count > 0 Then
							oContabilidad = new clsBE_Contabilidad
                            If DSContabilidad.Tables(0).Rows.Count > 0 Then
                                With DSContabilidad.Tables(0).Rows(0)
									    oContabilidad.contabilidadId = .Item("contabilidadId").tostring
									    oContabilidad.periodo = .Item("periodo").tostring
									    oContabilidad.codigoEstado = .Item("codigoEstado").tostring
									    oContabilidad.uc = .Item("uc").tostring
									    oContabilidad.fc = .Item("fc").tostring
									    oContabilidad.codigoDiario = .Item("codigoDiario").tostring
									    oContabilidad.codigoTransferido = .Item("codigoTransferido").tostring
									    oContabilidad.codigoEmpresa = .Item("codigoEmpresa").tostring
									    oContabilidad.fecha = .Item("fecha").tostring
                            	End With
							End If
						End If
					End If
                End Using	
			Catch exSql As SqlException
			
            Catch ex As Exception
				Throw ex	
			Finally
                If Not DSContabilidad Is Nothing Then
                    DSContabilidad.Dispose()
                End If
                DSContabilidad = Nothing
            End Try
		
		    Return oContabilidad		
        
        End Function


        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:34
        ''' Proposito: Obtiene la lista de registros
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaContabilidad() As List(Of clsBE_Contabilidad)
			Dim olstContabilidad As New List(Of clsBE_Contabilidad)
            Dim oContabilidad As clsBE_Contabilidad = Nothing
            Dim mintItem As Integer = 0
			Try	
				Using Reader As SqlDataReader = SqlHelper.ExecuteReader(CadenaConexion, CommandType.StoredProcedure, "up_Contabilidad_Sellst")
                    If Reader.HasRows Then
                        While reader.Read
                            oContabilidad = New clsBE_Contabilidad
                            mintItem += 1
                            With oContabilidad
                                .Item = mintItem
								
										.contabilidadId = Reader("contabilidadId").tostring
										.periodo = Reader("periodo").tostring
										.codigoEstado = Reader("codigoEstado").tostring
										.uc = Reader("uc").tostring
										.fc = Reader("fc").tostring
										.um = Reader("um").tostring
										.fm = Reader("fm").tostring
										.codigoDiario = Reader("codigoDiario").tostring
										.codigoTransferido = Reader("codigoTransferido").tostring
										.codigoEmpresa = Reader("codigoEmpresa").tostring
										.fecha = Reader("fecha").tostring
							End With
                            olstContabilidad.Add(oContabilidad)
                        End While
                    End If
                End Using
			Catch ex As Exception
				Throw ex				                
            End Try
			
            Return olstContabilidad
			
        End Function
		
		''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:34
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
		Public Function LeerListaToDSContabilidad(ByVal pContabilidad As clsBE_Contabilidad) As Dataset
			Dim oDSContabilidad As New DataSet				
			Dim mintItem As Integer = 0
            Dim prmParameter(-1) As SqlParameter
			Try	
								
				Using oDSContabilidad					
					oDSContabilidad = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_Contabilidad_Sellst", prmParameter)
					'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_Contabilidad_Sellst", oDSContabilidad, New String() {"Contabilidad"}, prmParameter)
					If Not oDSContabilidad Is Nothing Then
						If oDSContabilidad.Tables.Count > 0 Then
							'If oDSContabilidad.Tables("Contabilidad").Rows.Count > 0 Then
							If oDSContabilidad.Tables(0).Rows.Count > 0 Then
								Return oDSContabilidad
							End If
                        End If
                    End If
                End Using
			Catch ex As Exception
                Throw ex

            End Try
            Return oDSContabilidad					
			
        End Function
		
		
		''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:34
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
		public  function DefinirTablaContabilidad() As DataTable
			
		Try
			Dim DTContabilidad As New DataTable
			
			Dim contabilidadId As DataColumn = DTContabilidad.Columns.Add("contabilidadId", GetType(String))
						contabilidadId.MaxLength = 20
					contabilidadId.AllowDBNull = False
					contabilidadId.DefaultValue = ""
			
			Dim periodo As DataColumn = DTContabilidad.Columns.Add("periodo", GetType(String))
						periodo.MaxLength = 6
					periodo.AllowDBNull = True
					periodo.DefaultValue = ""
			
			Dim codigoEstado As DataColumn = DTContabilidad.Columns.Add("codigoEstado", GetType(String))
						codigoEstado.MaxLength = 15
					codigoEstado.AllowDBNull = True
					codigoEstado.DefaultValue = ""
			
			Dim uc As DataColumn = DTContabilidad.Columns.Add("uc", GetType(String))
						uc.MaxLength = 15
					uc.AllowDBNull = True
					uc.DefaultValue = ""
			
			Dim fc As DataColumn = DTContabilidad.Columns.Add("fc", GetType(DateTime))

			
			Dim um As DataColumn = DTContabilidad.Columns.Add("um", GetType(String))
						um.MaxLength = 15
					um.AllowDBNull = True
					um.DefaultValue = ""
			
			Dim fm As DataColumn = DTContabilidad.Columns.Add("fm", GetType(DateTime))

			
			Dim codigoDiario As DataColumn = DTContabilidad.Columns.Add("codigoDiario", GetType(String))
						codigoDiario.MaxLength = 15
					codigoDiario.AllowDBNull = True
					codigoDiario.DefaultValue = ""
			
			Dim codigoTransferido As DataColumn = DTContabilidad.Columns.Add("codigoTransferido", GetType(String))
						codigoTransferido.MaxLength = 15
					codigoTransferido.AllowDBNull = True
					codigoTransferido.DefaultValue = ""
			
			Dim codigoEmpresa As DataColumn = DTContabilidad.Columns.Add("codigoEmpresa", GetType(String))
						codigoEmpresa.MaxLength = 15
					codigoEmpresa.AllowDBNull = True
					codigoEmpresa.DefaultValue = ""
			
			Dim fecha As DataColumn = DTContabilidad.Columns.Add("fecha", GetType(DateTime))

			
		Return DTContabilidad
        Catch ex As Exception
            Throw ex
        End Try
		End Function	
		
    End Class
#End Region
    
End Namespace
