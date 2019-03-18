Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:45
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_TablaTX
    ''' Fecha Modificacion:
    ''' </summary>
	'''

    Public Class clsBC_TablaTX
		'Inherits ServicedComponent
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_TablaTX
        ''' Fecha Modificacion:
        ''' </summary>
		
		Private oDBTablaTX As clsDB_TablaTX
		Public oBETabla As clsBE_Tabla
		Public LstTabla As New List(Of clsBE_Tabla)
		Public oDSTabla As DataSet
		
        Sub New()
            oDBTablaTX = New clsDB_TablaTX
			oBETabla = New clsBE_Tabla
        End Sub
		
		Public Sub NuevaEntidad()
            oBETabla = New clsBE_Tabla
        End Sub
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function InsertarTabla() As Boolean
           	Try
				Return oDBTablaTX.InsertarTabla(LstTabla)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function EliminarTabla() As Boolean
           	Try
				Return oDBTablaTX.EliminarTabla(LstTabla)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function ModificarTabla() As Boolean
           	Try
				Return oDBTablaTX.ModificarTabla(LstTabla)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function GuardarTabla() As Boolean
           	Try
								
				Dim oDSNuevo As DataSet = oDSTabla.GetChanges(DataRowState.Added)
                If Not (oDSNuevo Is Nothing) Then
                    oDBTablaTX.GuardarTabla(oDSNuevo)
                    oDSTabla.Merge(oDSNuevo)
                End If

                Dim oDSModificar As DataSet = oDSTabla.GetChanges(DataRowState.Modified)
                If Not (oDSModificar Is Nothing) Then
                    oDBTablaTX.GuardarTabla(oDSModificar)
                    oDSTabla.Merge(oDSModificar)
                End If

                Dim oDSEliminar As DataSet = oDSTabla.GetChanges(DataRowState.Deleted)
                If Not (oDSEliminar Is Nothing) Then
                    oDBTablaTX.GuardarTabla(oDSEliminar)
                    oDSTabla.Merge(oDSEliminar)
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
	''' Fecha Creacion: 17/02/2011 16:58:45
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
	<Serializable()> _
    Public Class clsBC_TablaRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		
        Private oDBTablaRO As clsDB_TablaRO
		Public oBETabla As clsBE_Tabla
		Public LstTabla As New List(Of clsBE_Tabla)
		Public oDSTabla As New DataSet
		Public oDTTabla As New DataTable
		
		
        Sub New()
            oDBTablaRO = New clsDB_TablaRO
			oBETabla = New clsBE_Tabla
        End Sub
		
		Public Sub NuevaEntidad()
            oBETabla = New clsBE_Tabla
        End Sub
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerTabla()
            Try
				oBETabla = oDBTablaRO.LeerTabla(oBETabla)
			Catch ex As Exception
				Throw ex
            End Try
        End Sub
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerListaTabla()
            Try
				LstTabla = oDBTablaRO.LeerListaTabla()
			Catch ex As Exception
                Throw ex
            End Try
        End Sub
		
		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function LeerListaToDSTabla() As DataSet		         
            Try
                oDSTabla = oDBTablaRO.LeerListaToDSTabla(oBETabla)
                Return oDSTabla
            Catch ex As Exception
                Throw ex
            End Try
        End Function	
		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function DefinirTablaTabla() As DataTable		         
            Try
                oDTTabla = oDBTablaRO.DefinirTablaTabla()
                Return oDTTabla
            Catch ex As Exception
                Throw ex
            End Try
        End Function	
		
    End Class
#End Region

End Namespace
