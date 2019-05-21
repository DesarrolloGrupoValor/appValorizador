'Modified:
'@01 20141009 BAL01 ValidacionCTB

Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 17:00:27
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_TablaDetTX
    ''' Fecha Modificacion:
    ''' </summary>
	'''

    Public Class clsBC_TablaDetTX
		'Inherits ServicedComponent
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 17:00:27
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_TablaDetTX
        ''' Fecha Modificacion:
        ''' </summary>
		
		Private oDBTablaDetTX As clsDB_TablaDetTX
		Public oBETablaDet As clsBE_TablaDet
		Public LstTablaDet As New List(Of clsBE_TablaDet)
		Public oDSTablaDet As DataSet
		
        Sub New()
            oDBTablaDetTX = New clsDB_TablaDetTX
			oBETablaDet = New clsBE_TablaDet
        End Sub
		
		Public Sub NuevaEntidad()
            oBETablaDet = New clsBE_TablaDet
        End Sub
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 17:00:27
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function InsertarTablaDet() As Boolean
           	Try
				Return oDBTablaDetTX.InsertarTablaDet(LstTablaDet)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 17:00:27
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function EliminarTablaDet() As Boolean
           	Try
				Return oDBTablaDetTX.EliminarTablaDet(LstTablaDet)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 17:00:27
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function ModificarTablaDet() As Boolean
           	Try
				Return oDBTablaDetTX.ModificarTablaDet(LstTablaDet)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 17:00:27
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function GuardarTablaDet() As Boolean
           	Try
								
				Dim oDSNuevo As DataSet = oDSTablaDet.GetChanges(DataRowState.Added)
                If Not (oDSNuevo Is Nothing) Then
                    oDBTablaDetTX.GuardarTablaDet(oDSNuevo)
                    oDSTablaDet.Merge(oDSNuevo)
                End If

                Dim oDSModificar As DataSet = oDSTablaDet.GetChanges(DataRowState.Modified)
                If Not (oDSModificar Is Nothing) Then
                    oDBTablaDetTX.GuardarTablaDet(oDSModificar)
                    oDSTablaDet.Merge(oDSModificar)
                End If

                Dim oDSEliminar As DataSet = oDSTablaDet.GetChanges(DataRowState.Deleted)
                If Not (oDSEliminar Is Nothing) Then
                    oDBTablaDetTX.GuardarTablaDet(oDSEliminar)
                    oDSTablaDet.Merge(oDSEliminar)
                End If

                Return True
												
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
    End Class
#End Region

#Region "Clase Lectura"
    ''' <summary>
    ''' Escrito por: Martin Huaman
	''' Fecha Creacion: 17/02/2011 17:00:27
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
	<Serializable()> _
    Public Class clsBC_TablaDetRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 17:00:27
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		
        Private oDBTablaDetRO As clsDB_TablaDetRO
		Public oBETablaDet As clsBE_TablaDet
		Public LstTablaDet As New List(Of clsBE_TablaDet)
		Public oDSTablaDet As New DataSet
		Public oDTTablaDet As New DataTable
		
		
        Sub New()
            oDBTablaDetRO = New clsDB_TablaDetRO
			oBETablaDet = New clsBE_TablaDet
        End Sub
		
		Public Sub NuevaEntidad()
            oBETablaDet = New clsBE_TablaDet
        End Sub
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 17:00:27
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerTablaDet()
            Try
				oBETablaDet = oDBTablaDetRO.LeerTablaDet(oBETablaDet)
			Catch ex As Exception
				Throw ex
            End Try
        End Sub
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion:17/02/2011 17:00:27
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerListaTablaDet()
            Try
				LstTablaDet = oDBTablaDetRO.LeerListaTablaDet()
			Catch ex As Exception
                Throw ex
            End Try
        End Sub
		
		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 17:00:27
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function LeerListaToDSTablaDet() As DataSet		         
            Try
                oDSTablaDet = oDBTablaDetRO.LeerListaToDSTablaDet(oBETablaDet)
                Return oDSTablaDet
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function LeerListaToDSMes() As DataSet
            Try
                oDSTablaDet = oDBTablaDetRO.LeerListaToDSMes()
                Return oDSTablaDet
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        
        Public Function LeerListaToDSAnio() As DataSet
            Try
                oDSTablaDet = oDBTablaDetRO.LeerListaToDSAnio()
                Return oDSTablaDet
            Catch ex As Exception
                Throw ex
            End Try
        End Function



        Public Function LeerListaToDSTablaDetCondicion() As DataSet
            Try
                oDSTablaDet = oDBTablaDetRO.LeerListaToDSTablaDetCondicion(oBETablaDet)
                Return oDSTablaDet
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function LeerListaToDSTablaDetObjects() As DataSet
            Try
                oDSTablaDet = oDBTablaDetRO.LeerListaToDSTablaDetObjects(oBETablaDet)
                Return oDSTablaDet
            Catch ex As Exception
                Throw ex
            End Try
        End Function

		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 17:00:27
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function DefinirTablaTablaDet() As DataTable		         
            Try
                oDTTablaDet = oDBTablaDetRO.DefinirTablaTablaDet()
                Return oDTTablaDet
            Catch ex As Exception
                Throw ex
            End Try
        End Function	


        Public Function LeerListaToDSEstadoPeriodos() As DataSet
            Try
                oDSTablaDet = oDBTablaDetRO.LeerListaToDSEstadoPeriodos(oBETablaDet)
                Return oDSTablaDet
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        '@01    AINI
        Function ValidarUsuarioToValidacionCTB(ByVal currentUserCode As String) As Boolean
            Return oDBTablaDetRO.ValidarUsuarioToValidacionCTB(currentUserCode)
        End Function
        '@01    AFIN

    End Class
#End Region

End Namespace
