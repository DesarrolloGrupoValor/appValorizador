'Modified:
'@01 20141014 BAL01 Mantenimiento de periodos
'@02 20141021 BAL01 Validacion, al generar liquidacion PRV o FIN, eliminar PRL en caso esten en el mismo periodo


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
    ''' Fecha Creacion: 17/02/2011 16:58:34
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla Periodo
    ''' Fecha Modificacion:
    ''' </summary>
	'''

	Public Class clsDB_PeriodoTX
		
		Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:34
        ''' Proposito: Metodo de Insercci?n de Datos
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Function InsertarPeriodo(ByVal oLstPeriodo As List(Of clsBE_Periodo)) As Boolean
			For Each oPeriodo As clsBE_Periodo In oLstPeriodo
				Dim prmParameter(4) As SqlParameter
			
					prmParameter(0) = New SqlParameter("@pperiodoId", SqlDbType.varchar , 20)
							prmParameter(0).Value = IIf(IsNothing(oPeriodo.periodoId), "", oPeriodo.periodoId)
					prmParameter(0).Direction = ParameterDirection.Input
					prmParameter(1) = New SqlParameter("@pperiodo", SqlDbType.varchar , 6)
							prmParameter(1).Value = IIf(IsNothing(oPeriodo.periodo), "", oPeriodo.periodo)
					prmParameter(1).Direction = ParameterDirection.Input
					prmParameter(2) = New SqlParameter("@pcodigoCerrado", SqlDbType.varchar , 15)
							prmParameter(2).Value = IIf(IsNothing(oPeriodo.codigoCerrado), "", oPeriodo.codigoCerrado)
					prmParameter(2).Direction = ParameterDirection.Input
					prmParameter(3) = New SqlParameter("@pcodigoEstado", SqlDbType.varchar , 15)
							prmParameter(3).Value = IIf(IsNothing(oPeriodo.codigoEstado), "", oPeriodo.codigoEstado)
					prmParameter(3).Direction = ParameterDirection.Input
					prmParameter(4) = New SqlParameter("@puc", SqlDbType.varchar , 15)
							prmParameter(4).Value = IIf(IsNothing(oPeriodo.uc), "", oPeriodo.uc)
					prmParameter(4).Direction = ParameterDirection.Input
				Try		
				    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_Periodo_Ins", prmParameter)
				Catch ex As Exception
					Throw ex					
					Return False
				End Try
			Next
			Return True
        End Function

        '@01    AINI
        Public Function InsertPeriodoByEmpresa(ByVal EmpresaID As String, ByVal periodo As String, ByVal fDeclara As String, ByVal cerrado As Integer) As Boolean
            Dim prmParameter(3) As SqlParameter
            prmParameter(0) = New SqlParameter("@empresaID", SqlDbType.VarChar, 15)
            prmParameter(0).Value = EmpresaID
            prmParameter(0).Direction = ParameterDirection.Input
            prmParameter(1) = New SqlParameter("@Vch_periodo", SqlDbType.VarChar, 6)
            prmParameter(1).Value = periodo
            prmParameter(1).Direction = ParameterDirection.Input
            prmParameter(2) = New SqlParameter("@Dt_fechaDeclara", SqlDbType.VarChar, 30)
            prmParameter(2).Value = fDeclara
            prmParameter(2).Direction = ParameterDirection.Input
            prmParameter(3) = New SqlParameter("@Int_flagDeclara", SqlDbType.Int)
            prmParameter(3).Value = cerrado
            prmParameter(3).Direction = ParameterDirection.Input
            Try
                SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_InsPeriodoByEmpresa", prmParameter)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
            Return True
        End Function

        Public Function UpdatePeriodoByEmpresa(ByVal EmpresaID As String, ByVal periodo As String, ByVal fDeclara As String, ByVal cerrado As Integer) As Boolean
            Dim prmParameter(3) As SqlParameter
            prmParameter(0) = New SqlParameter("@empresaID", SqlDbType.VarChar, 15)
            prmParameter(0).Value = EmpresaID
            prmParameter(0).Direction = ParameterDirection.Input
            prmParameter(1) = New SqlParameter("@Vch_periodo", SqlDbType.VarChar, 6)
            prmParameter(1).Value = periodo
            prmParameter(1).Direction = ParameterDirection.Input
            prmParameter(2) = New SqlParameter("@Dt_fechaDeclara", SqlDbType.VarChar, 30)
            prmParameter(2).Value = fDeclara
            prmParameter(2).Direction = ParameterDirection.Input
            prmParameter(3) = New SqlParameter("@Int_flagDeclara", SqlDbType.Int)
            prmParameter(3).Value = cerrado
            prmParameter(3).Direction = ParameterDirection.Input
            Try
                SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_UpdPeriodoByEmpresa", prmParameter)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
            Return True
        End Function

        Public Function ValidarRumasPendientesLotizar(ByVal EmpresaID As String, ByVal periodo As String) As Boolean
            Dim validacion As Boolean = False
            Dim DS As New DataSet
            Dim prmParameter(1) As SqlParameter
            prmParameter(0) = New SqlParameter("@empresa", SqlDbType.VarChar, 20)
            prmParameter(0).Value = EmpresaID
            prmParameter(0).Direction = ParameterDirection.Input
            prmParameter(1) = New SqlParameter("@periodo", SqlDbType.Char, 6)
            prmParameter(1).Value = periodo
            prmParameter(1).Direction = ParameterDirection.Input
            Try
                Using DS
                    DS = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "sp_RumasComprasPendienteLotizarByEmpresaPeriodo", prmParameter)
                    If Not DS Is Nothing Then
                        If DS.Tables.Count > 0 Then
                            ' Posee rumas pendientes de lotizar
                            If DS.Tables(0).Rows.Count > 0 Then
                                validacion = True
                            End If
                        End If
                    End If
                End Using
            Catch ex As Exception
                Throw ex
            End Try
            Return validacion
        End Function
        '@01    AFIN

		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:34
        ''' Proposito: Metodo de Modificacion de datos
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Function ModificarPeriodo(ByVal oLstPeriodo As List(Of clsBE_Periodo)) As Boolean
			For Each oPeriodo As clsBE_Periodo In oLstPeriodo
				Dim prmParameter(5) As SqlParameter
					prmParameter(0) = New SqlParameter("@pperiodoId", SqlDbType.varchar , 20)
							prmParameter(0).Value = IIf(IsNothing(oPeriodo.periodoId), "", oPeriodo.periodoId)
					prmParameter(0).Direction = ParameterDirection.Input
					prmParameter(1) = New SqlParameter("@pperiodo", SqlDbType.varchar , 6)
							prmParameter(1).Value = IIf(IsNothing(oPeriodo.periodo), "", oPeriodo.periodo)
					prmParameter(1).Direction = ParameterDirection.Input
					prmParameter(2) = New SqlParameter("@pcodigoCerrado", SqlDbType.varchar , 15)
							prmParameter(2).Value = IIf(IsNothing(oPeriodo.codigoCerrado), "", oPeriodo.codigoCerrado)
					prmParameter(2).Direction = ParameterDirection.Input
					prmParameter(3) = New SqlParameter("@pcodigoEstado", SqlDbType.varchar , 15)
							prmParameter(3).Value = IIf(IsNothing(oPeriodo.codigoEstado), "", oPeriodo.codigoEstado)
					prmParameter(3).Direction = ParameterDirection.Input
					prmParameter(4) = New SqlParameter("@pum", SqlDbType.varchar , 15)
							prmParameter(4).Value = IIf(IsNothing(oPeriodo.um), "", oPeriodo.um)
					prmParameter(4).Direction = ParameterDirection.Input
					prmParameter(5) = New SqlParameter("@pfm", SqlDbType.DateTime , 8)
						prmParameter(5).Value = clsUT_Funcion.FechaNull(oPeriodo.fm)
					prmParameter(5).Direction = ParameterDirection.Input
				Try		
				    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_Periodo_Upd", prmParameter)
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
		''' Fecha Creacion: 17/02/2011 16:58:34
        ''' Proposito: Metodo de Elimacion
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Function EliminarPeriodo(ByVal oLstPeriodo As List(Of clsBE_Periodo)) As Boolean
			For Each oPeriodo As clsBE_Periodo In oLstPeriodo
				Dim prmParameter(0) As SqlParameter
					prmParameter(0) = New SqlParameter("@pperiodoId", SqlDbType.varchar , 20)
							prmParameter(0).Value = IIf(IsNothing(oPeriodo.periodoId), "", oPeriodo.periodoId)
					prmParameter(0).Direction = ParameterDirection.Input
				Try		
				    SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_Periodo_Del", prmParameter)
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
		''' Fecha Creacion: 17/02/2011 16:58:34
        ''' Proposito: Metodo de Guardar Dataset
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Function GuardarPeriodo(ByVal oDSPeriodo As Dataset) As Boolean
		 Dim cnxCPO As New SqlConnection(CadenaConexion)
		 

            Try
                Dim objCommnadInsert As New SqlCommand                
				objCommnadInsert.Connection = cnxCPO
                objCommnadInsert.CommandText = "up_Periodo_Ins"
                objCommnadInsert.CommandType = CommandType.StoredProcedure					
			
					objCommnadInsert.Parameters.Add( "@pperiodoId", SqlDbType.varchar , 20).SourceColumn = "periodoId"								
					objCommnadInsert.Parameters.Add( "@pperiodo", SqlDbType.varchar , 6).SourceColumn = "periodo"								
					objCommnadInsert.Parameters.Add( "@pcodigoCerrado", SqlDbType.varchar , 15).SourceColumn = "codigoCerrado"								
					objCommnadInsert.Parameters.Add( "@pcodigoEstado", SqlDbType.varchar , 15).SourceColumn = "codigoEstado"								
					objCommnadInsert.Parameters.Add( "@puc", SqlDbType.varchar , 15).SourceColumn = "uc"								
				
				Dim objCommandUpdate As New SqlCommand
                objCommandUpdate.Connection = cnxCPO
                objCommandUpdate.CommandText = "up_Periodo_Upd"
                objCommandUpdate.CommandType = CommandType.StoredProcedure
				
					objCommandUpdate.Parameters.Add( "@pperiodoId", SqlDbType.varchar , 20).SourceColumn = "periodoId"								
					objCommandUpdate.Parameters.Add( "@pperiodo", SqlDbType.varchar , 6).SourceColumn = "periodo"								
					objCommandUpdate.Parameters.Add( "@pcodigoCerrado", SqlDbType.varchar , 15).SourceColumn = "codigoCerrado"								
					objCommandUpdate.Parameters.Add( "@pcodigoEstado", SqlDbType.varchar , 15).SourceColumn = "codigoEstado"								
					objCommandUpdate.Parameters.Add( "@pum", SqlDbType.varchar , 15).SourceColumn = "um"								
					objCommandUpdate.Parameters.Add( "@pfm", SqlDbType.DateTime , 8).SourceColumn = "fm"								
				
				Dim objCommandDelete As New SqlCommand
                objCommandDelete.Connection = cnxCPO
                objCommandDelete.CommandText = "up_Periodo_Del"
                objCommandDelete.CommandType = CommandType.StoredProcedure
				
					objCommandDelete.Parameters.Add( "@pperiodoId", SqlDbType.varchar , 20).SourceColumn = "periodoId"								
				
				'SqlHelper.UpdateDataset(objCommnadInsert, objCommandDelete, objCommandUpdate, oDSPeriodo, "Periodo")

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
    ''' Fecha Creacion: 17/02/2011 16:58:34
    ''' Proposito: Obtiene los valores de la tabla Periodo
    ''' Fecha Modificacion:
    ''' </summary>
	'''
	<Serializable()> _
    Public Class clsDB_PeriodoRO
		Private Shared CadenaConexion As String
        Public Sub New()
            'CadenaConexion =System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Dim oDB_Functions As New clsDB_Functions
            CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
        End Sub

        '@01    AINI
        Public Function GetPeriodoByEmpresa(ByVal EmpresaID As String) As DataTable
            Dim dt As DataTable
            Dim prmParameter(0) As SqlParameter
            prmParameter(0) = New SqlParameter("@empresaID", SqlDbType.VarChar, 15)
            prmParameter(0).Value = EmpresaID
            Try
                dt = SqlHelper.ExecuteDataTable(CadenaConexion, CommandType.StoredProcedure, "up_PeriodoByEmpresa", prmParameter)
            Catch ex As Exception
                Throw ex
            End Try
            Return dt
        End Function

        Public Function ValidaPeriodoCerrado(ByVal EmpresaID As String, ByVal periodo As String) As Boolean
            Dim validacion As Boolean
            Dim prmParameter(1) As SqlParameter
            prmParameter(0) = New SqlParameter("@empresaID", SqlDbType.VarChar, 15)
            prmParameter(0).Value = EmpresaID
            prmParameter(1) = New SqlParameter("@Vch_periodo", SqlDbType.VarChar, 6)
            prmParameter(1).Value = periodo
            Try
                Using Reader As SqlDataReader = SqlHelper.ExecuteReader(CadenaConexion, CommandType.StoredProcedure, "up_ValidaPeriodoCerrado", prmParameter)
                    If Reader.HasRows Then
                        Reader.Read()
                        validacion = IIf(CInt(Reader("ESTADO_PERIODO")) = 1, True, False)
                    End If
                End Using
            Catch ex As Exception
                Throw ex
                validacion = False
            End Try
            Return validacion
        End Function
        '@01    AFIN

        '@02    AINI
        Public Function EliminarPRLByPeriodo(ByVal ContratoLoteId As String, ByVal periodo As String) As Boolean
            Dim validacion As Boolean
            Dim prmParameter(1) As SqlParameter
            prmParameter(0) = New SqlParameter("@contratoLoteId", SqlDbType.VarChar, 20)
            prmParameter(0).Value = ContratoLoteId
            prmParameter(1) = New SqlParameter("@periodo", SqlDbType.VarChar, 6)
            prmParameter(1).Value = periodo
            Try
                SqlHelper.ExecuteNonQuery(CadenaConexion, CommandType.StoredProcedure, "up_EliminarPRLByPeriodo", prmParameter)
                validacion = True
            Catch ex As Exception
                Throw ex
                validacion = False
            End Try
            Return validacion
        End Function
        '@02    AFIN

        Public Function ObtenerPeriodo(ByVal sTipoPeriodo As String) As DataSet
            'Dim oPeriodo As clsBE_Periodo = Nothing
            Dim DSPeriodo As New DataSet
            Dim prmParameter(0) As SqlParameter
            prmParameter(0) = New SqlParameter("@TIPO_PERIODO", SqlDbType.VarChar, 20)
            prmParameter(0).Value = IIf(IsNothing(sTipoPeriodo), "", sTipoPeriodo)
            Try
                'Using DSPeriodo
                DSPeriodo = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_Periodos", prmParameter)
                'If Not DSPeriodo Is Nothing Then
                '    If DSPeriodo.Tables.Count > 0 Then
                '        oPeriodo = New clsBE_Periodo
                '        If DSPeriodo.Tables(0).Rows.Count > 0 Then
                '            With DSPeriodo.Tables(0).Rows(0)
                '                oPeriodo.periodoId = .Item("periodoId").ToString
                '                oPeriodo.periodo = .Item("periodo").ToString
                '                'oPeriodo.codigoCerrado = .Item("codigoCerrado").ToString
                '                'oPeriodo.codigoEstado = .Item("codigoEstado").ToString
                '                'oPeriodo.uc = .Item("uc").ToString
                '                'oPeriodo.fc = .Item("fc").ToString
                '            End With
                '        End If
                '    End If
                'End If
                'End Using

            Catch exSql As SqlException

            Catch ex As Exception
                Throw ex
            Finally
                If Not DSPeriodo Is Nothing Then
                    DSPeriodo.Dispose()
                End If
                'DSPeriodo = Nothing
            End Try

            Return DSPeriodo

        End Function


        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:34
        ''' Proposito: Lee los datos de un registro
        ''' Fecha Modificacion:
        ''' </summary>
        ''' 
        Public Function LeerPeriodo(ByVal pPeriodo As clsBE_Periodo) As clsBE_Periodo
			Dim oPeriodo As clsBE_Periodo = Nothing
			 Dim DSPeriodo  As New DataSet
			Dim prmParameter(0) As SqlParameter
					prmParameter(0) = New SqlParameter("@pperiodoId", SqlDbType.varchar , 20)
							prmParameter(0).Value = IIf(IsNothing(pPeriodo.periodoId), "", pPeriodo.periodoId)
			Try		
			 Using DSPeriodo
                    DSPeriodo = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_Periodo_Sel", prmParameter)
                    If Not DSPeriodo Is Nothing Then
                        If DSPeriodo.Tables.Count > 0 Then
							oPeriodo = new clsBE_Periodo
                            If DSPeriodo.Tables(0).Rows.Count > 0 Then
                                With DSPeriodo.Tables(0).Rows(0)
									    oPeriodo.periodoId = .Item("periodoId").tostring
									    oPeriodo.periodo = .Item("periodo").tostring
									    oPeriodo.codigoCerrado = .Item("codigoCerrado").tostring
									    oPeriodo.codigoEstado = .Item("codigoEstado").tostring
									    oPeriodo.uc = .Item("uc").tostring
									    oPeriodo.fc = .Item("fc").tostring
                            	End With
							End If
						End If
					End If
                End Using	
			Catch exSql As SqlException
			
            Catch ex As Exception
				Throw ex	
			Finally
                If Not DSPeriodo Is Nothing Then
                    DSPeriodo.Dispose()
                End If
                DSPeriodo = Nothing
            End Try
		
		    Return oPeriodo		
        
        End Function


        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:34
        ''' Proposito: Obtiene la lista de registros
        ''' Fecha Modificacion:
        ''' </summary>
        Public Function LeerListaPeriodo() As List(Of clsBE_Periodo)
			Dim olstPeriodo As New List(Of clsBE_Periodo)
            Dim oPeriodo As clsBE_Periodo = Nothing
            Dim mintItem As Integer = 0
			Try	
				Using Reader As SqlDataReader = SqlHelper.ExecuteReader(CadenaConexion, CommandType.StoredProcedure, "up_Periodo_Sellst")
                    If Reader.HasRows Then
                        While reader.Read
                            oPeriodo = New clsBE_Periodo
                            mintItem += 1
                            With oPeriodo
                                .Item = mintItem
								
										.periodoId = Reader("periodoId").tostring
										.periodo = Reader("periodo").tostring
										.codigoCerrado = Reader("codigoCerrado").tostring
										.codigoEstado = Reader("codigoEstado").tostring
										.uc = Reader("uc").tostring
										.fc = Reader("fc").tostring
										.um = Reader("um").tostring
										.fm = Reader("fm").tostring
							End With
                            olstPeriodo.Add(oPeriodo)
                        End While
                    End If
                End Using
			Catch ex As Exception
				Throw ex				                
            End Try
			
            Return olstPeriodo
			
        End Function
		
		''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:34
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
		Public Function LeerListaToDSPeriodo(ByVal pPeriodo As clsBE_Periodo) As Dataset
			Dim oDSPeriodo As New DataSet				
			Dim mintItem As Integer = 0
            Dim prmParameter(-1) As SqlParameter
			Try	
								
				Using oDSPeriodo					
					oDSPeriodo = SqlHelper.ExecuteDataset(CadenaConexion, CommandType.StoredProcedure, "up_Periodo_Sellst", prmParameter)
					'SqlHelper.FillDataset(CadenaConexion, CommandType.StoredProcedure, "up_Periodo_Sellst", oDSPeriodo, New String() {"Periodo"}, prmParameter)
					If Not oDSPeriodo Is Nothing Then
						If oDSPeriodo.Tables.Count > 0 Then
							'If oDSPeriodo.Tables("Periodo").Rows.Count > 0 Then
							If oDSPeriodo.Tables(0).Rows.Count > 0 Then
								Return oDSPeriodo
							End If
                        End If
                    End If
                End Using
			Catch ex As Exception
                Throw ex

            End Try
            Return oDSPeriodo					
			
        End Function
		
		
		''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:35
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS
        ''' Fecha Modificacion:
        ''' </summary>
		public  function DefinirTablaPeriodo() As DataTable
			
		Try
			Dim DTPeriodo As New DataTable
			
			Dim periodoId As DataColumn = DTPeriodo.Columns.Add("periodoId", GetType(String))
						periodoId.MaxLength = 20
					periodoId.AllowDBNull = False
					periodoId.DefaultValue = ""
			
			Dim periodo As DataColumn = DTPeriodo.Columns.Add("periodo", GetType(String))
						periodo.MaxLength = 6
					periodo.AllowDBNull = True
					periodo.DefaultValue = ""
			
			Dim codigoCerrado As DataColumn = DTPeriodo.Columns.Add("codigoCerrado", GetType(String))
						codigoCerrado.MaxLength = 15
					codigoCerrado.AllowDBNull = True
					codigoCerrado.DefaultValue = ""
			
			Dim codigoEstado As DataColumn = DTPeriodo.Columns.Add("codigoEstado", GetType(String))
						codigoEstado.MaxLength = 15
					codigoEstado.AllowDBNull = True
					codigoEstado.DefaultValue = ""
			
			Dim uc As DataColumn = DTPeriodo.Columns.Add("uc", GetType(String))
						uc.MaxLength = 15
					uc.AllowDBNull = True
					uc.DefaultValue = ""
			
			Dim fc As DataColumn = DTPeriodo.Columns.Add("fc", GetType(DateTime))

			
			Dim um As DataColumn = DTPeriodo.Columns.Add("um", GetType(String))
						um.MaxLength = 15
					um.AllowDBNull = True
					um.DefaultValue = ""
			
			Dim fm As DataColumn = DTPeriodo.Columns.Add("fm", GetType(DateTime))

			
		Return DTPeriodo
        Catch ex As Exception
            Throw ex
        End Try
		End Function	
		
    End Class
#End Region
    
End Namespace
