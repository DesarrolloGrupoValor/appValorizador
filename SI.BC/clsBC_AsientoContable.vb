Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:38:11
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_AsientoContableTX
    ''' Fecha Modificacion:
    ''' </summary>
	'''

    Public Class clsBC_AsientoContableTX
		'Inherits ServicedComponent
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:11
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_AsientoContableTX
        ''' Fecha Modificacion:
        ''' </summary>
		
		Private oDBAsientoContableTX As clsDB_AsientoContableTX
		Public oBEAsientoContable As clsBE_AsientoContable
		Public LstAsientoContable As New List(Of clsBE_AsientoContable)
		Public oDSAsientoContable As DataSet
		
        Sub New()
            oDBAsientoContableTX = New clsDB_AsientoContableTX
			oBEAsientoContable = New clsBE_AsientoContable
        End Sub
		
		Public Sub NuevaEntidad()
            oBEAsientoContable = New clsBE_AsientoContable
        End Sub
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:11
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function InsertarAsientoContable() As Boolean
           	Try
				Return oDBAsientoContableTX.InsertarAsientoContable(LstAsientoContable)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:11
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function EliminarAsientoContable() As Boolean
           	Try
				Return oDBAsientoContableTX.EliminarAsientoContable(LstAsientoContable)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:11
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function ModificarAsientoContable() As Boolean
           	Try
				Return oDBAsientoContableTX.ModificarAsientoContable(LstAsientoContable)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:11
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function GuardarAsientoContable() As Boolean
           	Try
								
				Dim oDSNuevo As DataSet = oDSAsientoContable.GetChanges(DataRowState.Added)
                If Not (oDSNuevo Is Nothing) Then
                    oDBAsientoContableTX.GuardarAsientoContable(oDSNuevo)
                    oDSAsientoContable.Merge(oDSNuevo)
                End If

                Dim oDSModificar As DataSet = oDSAsientoContable.GetChanges(DataRowState.Modified)
                If Not (oDSModificar Is Nothing) Then
                    oDBAsientoContableTX.GuardarAsientoContable(oDSModificar)
                    oDSAsientoContable.Merge(oDSModificar)
                End If

                Dim oDSEliminar As DataSet = oDSAsientoContable.GetChanges(DataRowState.Deleted)
                If Not (oDSEliminar Is Nothing) Then
                    oDBAsientoContableTX.GuardarAsientoContable(oDSEliminar)
                    oDSAsientoContable.Merge(oDSEliminar)
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
	''' Fecha Creacion: 17/02/2011 16:38:11
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
	<Serializable()> _
    Public Class clsBC_AsientoContableRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:11
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		
        Private oDBAsientoContableRO As clsDB_AsientoContableRO
		Public oBEAsientoContable As clsBE_AsientoContable
		Public LstAsientoContable As New List(Of clsBE_AsientoContable)
		Public oDSAsientoContable As New DataSet
		Public oDTAsientoContable As New DataTable
		
		
        Sub New()
            oDBAsientoContableRO = New clsDB_AsientoContableRO
			oBEAsientoContable = New clsBE_AsientoContable
        End Sub
		
		Public Sub NuevaEntidad()
            oBEAsientoContable = New clsBE_AsientoContable
        End Sub
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:11
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerAsientoContable()
            Try
				oBEAsientoContable = oDBAsientoContableRO.LeerAsientoContable(oBEAsientoContable)
			Catch ex As Exception
				Throw ex
            End Try
        End Sub
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:38:11
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerListaAsientoContable()
            Try
				LstAsientoContable = oDBAsientoContableRO.LeerListaAsientoContable()
			Catch ex As Exception
                Throw ex
            End Try
        End Sub
		
		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:38:11
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function LeerListaToDSAsientoContable() As DataSet		         
            Try
                oDSAsientoContable = oDBAsientoContableRO.LeerListaToDSAsientoContable(oBEAsientoContable)
                Return oDSAsientoContable
            Catch ex As Exception
                Throw ex
            End Try
        End Function	
		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:38:11
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function DefinirTablaAsientoContable() As DataTable		         
            Try
                oDTAsientoContable = oDBAsientoContableRO.DefinirTablaAsientoContable()
                Return oDTAsientoContable
            Catch ex As Exception
                Throw ex
            End Try
        End Function	
		
    End Class
#End Region

End Namespace
