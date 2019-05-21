Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:38:22
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_ConfiguracionContableTX
    ''' Fecha Modificacion:
    ''' </summary>
	'''

    Public Class clsBC_ConfiguracionContableTX
		'Inherits ServicedComponent
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:22
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_ConfiguracionContableTX
        ''' Fecha Modificacion:
        ''' </summary>
		
		Private oDBConfiguracionContableTX As clsDB_ConfiguracionContableTX
		Public oBEConfiguracionContable As clsBE_ConfiguracionContable
		Public LstConfiguracionContable As New List(Of clsBE_ConfiguracionContable)
		Public oDSConfiguracionContable As DataSet
		
        Sub New()
            oDBConfiguracionContableTX = New clsDB_ConfiguracionContableTX
			oBEConfiguracionContable = New clsBE_ConfiguracionContable
        End Sub
		
		Public Sub NuevaEntidad()
            oBEConfiguracionContable = New clsBE_ConfiguracionContable
        End Sub
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:22
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function InsertarConfiguracionContable() As Boolean
           	Try
				Return oDBConfiguracionContableTX.InsertarConfiguracionContable(LstConfiguracionContable)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:22
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function EliminarConfiguracionContable() As Boolean
           	Try
				Return oDBConfiguracionContableTX.EliminarConfiguracionContable(LstConfiguracionContable)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:22
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function ModificarConfiguracionContable() As Boolean
           	Try
				Return oDBConfiguracionContableTX.ModificarConfiguracionContable(LstConfiguracionContable)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:22
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function GuardarConfiguracionContable() As Boolean
           	Try
								
				Dim oDSNuevo As DataSet = oDSConfiguracionContable.GetChanges(DataRowState.Added)
                If Not (oDSNuevo Is Nothing) Then
                    oDBConfiguracionContableTX.GuardarConfiguracionContable(oDSNuevo)
                    oDSConfiguracionContable.Merge(oDSNuevo)
                End If

                Dim oDSModificar As DataSet = oDSConfiguracionContable.GetChanges(DataRowState.Modified)
                If Not (oDSModificar Is Nothing) Then
                    oDBConfiguracionContableTX.GuardarConfiguracionContable(oDSModificar)
                    oDSConfiguracionContable.Merge(oDSModificar)
                End If

                Dim oDSEliminar As DataSet = oDSConfiguracionContable.GetChanges(DataRowState.Deleted)
                If Not (oDSEliminar Is Nothing) Then
                    oDBConfiguracionContableTX.GuardarConfiguracionContable(oDSEliminar)
                    oDSConfiguracionContable.Merge(oDSEliminar)
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
	''' Fecha Creacion: 17/02/2011 16:38:22
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
	<Serializable()> _
    Public Class clsBC_ConfiguracionContableRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:22
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		
        Private oDBConfiguracionContableRO As clsDB_ConfiguracionContableRO
		Public oBEConfiguracionContable As clsBE_ConfiguracionContable
		Public LstConfiguracionContable As New List(Of clsBE_ConfiguracionContable)
		Public oDSConfiguracionContable As New DataSet
		Public oDTConfiguracionContable As New DataTable
		
		
        Sub New()
            oDBConfiguracionContableRO = New clsDB_ConfiguracionContableRO
			oBEConfiguracionContable = New clsBE_ConfiguracionContable
        End Sub
		
		Public Sub NuevaEntidad()
            oBEConfiguracionContable = New clsBE_ConfiguracionContable
        End Sub
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:38:22
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerConfiguracionContable()
            Try
				oBEConfiguracionContable = oDBConfiguracionContableRO.LeerConfiguracionContable(oBEConfiguracionContable)
			Catch ex As Exception
				Throw ex
            End Try
        End Sub
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:38:22
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerListaConfiguracionContable()
            Try
				LstConfiguracionContable = oDBConfiguracionContableRO.LeerListaConfiguracionContable()
			Catch ex As Exception
                Throw ex
            End Try
        End Sub
		
		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:38:22
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function LeerListaToDSConfiguracionContable() As DataSet		         
            Try
                oDSConfiguracionContable = oDBConfiguracionContableRO.LeerListaToDSConfiguracionContable(oBEConfiguracionContable)
                Return oDSConfiguracionContable
            Catch ex As Exception
                Throw ex
            End Try
        End Function	
		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:38:22
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function DefinirTablaConfiguracionContable() As DataTable		         
            Try
                oDTConfiguracionContable = oDBConfiguracionContableRO.DefinirTablaConfiguracionContable()
                Return oDTConfiguracionContable
            Catch ex As Exception
                Throw ex
            End Try
        End Function	
		
    End Class
#End Region

End Namespace
