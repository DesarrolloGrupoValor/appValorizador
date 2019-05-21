Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:38:33
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_ContabilidadTX
    ''' Fecha Modificacion:
    ''' </summary>
	'''

    Public Class clsBC_ContabilidadTX
		'Inherits ServicedComponent
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:33
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_ContabilidadTX
        ''' Fecha Modificacion:
        ''' </summary>
		
		Private oDBContabilidadTX As clsDB_ContabilidadTX
		Public oBEContabilidad As clsBE_Contabilidad
		Public LstContabilidad As New List(Of clsBE_Contabilidad)
		Public oDSContabilidad As DataSet
		
        Sub New()
            oDBContabilidadTX = New clsDB_ContabilidadTX
			oBEContabilidad = New clsBE_Contabilidad
        End Sub
		
		Public Sub NuevaEntidad()
            oBEContabilidad = New clsBE_Contabilidad
        End Sub
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:33
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function InsertarContabilidad() As Boolean
           	Try
				Return oDBContabilidadTX.InsertarContabilidad(LstContabilidad)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:33
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function EliminarContabilidad() As Boolean
           	Try
				Return oDBContabilidadTX.EliminarContabilidad(LstContabilidad)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:33
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function ModificarContabilidad() As Boolean
           	Try
				Return oDBContabilidadTX.ModificarContabilidad(LstContabilidad)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:33
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function GuardarContabilidad() As Boolean
           	Try
								
				Dim oDSNuevo As DataSet = oDSContabilidad.GetChanges(DataRowState.Added)
                If Not (oDSNuevo Is Nothing) Then
                    oDBContabilidadTX.GuardarContabilidad(oDSNuevo)
                    oDSContabilidad.Merge(oDSNuevo)
                End If

                Dim oDSModificar As DataSet = oDSContabilidad.GetChanges(DataRowState.Modified)
                If Not (oDSModificar Is Nothing) Then
                    oDBContabilidadTX.GuardarContabilidad(oDSModificar)
                    oDSContabilidad.Merge(oDSModificar)
                End If

                Dim oDSEliminar As DataSet = oDSContabilidad.GetChanges(DataRowState.Deleted)
                If Not (oDSEliminar Is Nothing) Then
                    oDBContabilidadTX.GuardarContabilidad(oDSEliminar)
                    oDSContabilidad.Merge(oDSEliminar)
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
	''' Fecha Creacion: 17/02/2011 16:38:33
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
	<Serializable()> _
    Public Class clsBC_ContabilidadRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:33
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		
        Private oDBContabilidadRO As clsDB_ContabilidadRO
		Public oBEContabilidad As clsBE_Contabilidad
		Public LstContabilidad As New List(Of clsBE_Contabilidad)
		Public oDSContabilidad As New DataSet
		Public oDTContabilidad As New DataTable
		
		
        Sub New()
            oDBContabilidadRO = New clsDB_ContabilidadRO
			oBEContabilidad = New clsBE_Contabilidad
        End Sub
		
		Public Sub NuevaEntidad()
            oBEContabilidad = New clsBE_Contabilidad
        End Sub
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:33
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerContabilidad()
            Try
				oBEContabilidad = oDBContabilidadRO.LeerContabilidad(oBEContabilidad)
			Catch ex As Exception
				Throw ex
            End Try
        End Sub
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:38:33
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerListaContabilidad()
            Try
				LstContabilidad = oDBContabilidadRO.LeerListaContabilidad()
			Catch ex As Exception
                Throw ex
            End Try
        End Sub
		
		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:38:33
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function LeerListaToDSContabilidad() As DataSet		         
            Try
                oDSContabilidad = oDBContabilidadRO.LeerListaToDSContabilidad(oBEContabilidad)
                Return oDSContabilidad
            Catch ex As Exception
                Throw ex
            End Try
        End Function	
		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:38:33
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function DefinirTablaContabilidad() As DataTable		         
            Try
                oDTContabilidad = oDBContabilidadRO.DefinirTablaContabilidad()
                Return oDTContabilidad
            Catch ex As Exception
                Throw ex
            End Try
        End Function	
		
    End Class
#End Region

End Namespace
