Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 11/03/2011 17:53:28
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_ValorizadorPagableTX
    ''' Fecha Modificacion:
    ''' </summary>
	'''

    Public Class clsBC_ValorizadorPagableTX
		'Inherits ServicedComponent
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 11/03/2011 17:53:28
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_ValorizadorPagableTX
        ''' Fecha Modificacion:
        ''' </summary>
		
		Private oDBValorizadorPagableTX As clsDB_ValorizadorPagableTX
        Public oBEValorizadorPagable As clsBE_ValorizadorPagable
        Public oBEValorizadorPagableIns As clsBE_ValorizadorPagable
        Public oBEValorizadorPagableUpd As clsBE_ValorizadorPagable
        Public oBEValorizadorPagableDel As clsBE_ValorizadorPagable
		Public LstValorizadorPagable As New List(Of clsBE_ValorizadorPagable)
		Public oDSValorizadorPagable As DataSet
		
        Sub New()
            oDBValorizadorPagableTX = New clsDB_ValorizadorPagableTX
            oBEValorizadorPagable = New clsBE_ValorizadorPagable
            oBEValorizadorPagableIns = New clsBE_ValorizadorPagable
            oBEValorizadorPagableUpd = New clsBE_ValorizadorPagable
            oBEValorizadorPagableDel = New clsBE_ValorizadorPagable
        End Sub
		
		Public Sub NuevaEntidad()
            oBEValorizadorPagable = New clsBE_ValorizadorPagable
            oBEValorizadorPagableIns = New clsBE_ValorizadorPagable
            oBEValorizadorPagableUpd = New clsBE_ValorizadorPagable
            oBEValorizadorPagableDel = New clsBE_ValorizadorPagable
        End Sub
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 11/03/2011 17:53:28
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function InsertarValorizadorPagable() As Boolean
           	Try
				Return oDBValorizadorPagableTX.InsertarValorizadorPagable(LstValorizadorPagable)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 11/03/2011 17:53:28
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function EliminarValorizadorPagable() As Boolean
           	Try
				Return oDBValorizadorPagableTX.EliminarValorizadorPagable(LstValorizadorPagable)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 11/03/2011 17:53:28
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function ModificarValorizadorPagable() As Boolean
           	Try
				Return oDBValorizadorPagableTX.ModificarValorizadorPagable(LstValorizadorPagable)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function



        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 11/03/2011 17:53:28
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function FijacionPreciosValorizadorPagable() As Boolean
            Try
                Return oDBValorizadorPagableTX.FijacionPreciosValorizadorPagable(LstValorizadorPagable)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 11/03/2011 17:53:28
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function GuardarValorizadorPagable() As Boolean
           	Try
								
				Dim oDSNuevo As DataSet = oDSValorizadorPagable.GetChanges(DataRowState.Added)
                If Not (oDSNuevo Is Nothing) Then
                    oDBValorizadorPagableTX.GuardarValorizadorPagable(oDSNuevo)
                    oDSValorizadorPagable.Merge(oDSNuevo)
                End If

                Dim oDSModificar As DataSet = oDSValorizadorPagable.GetChanges(DataRowState.Modified)
                If Not (oDSModificar Is Nothing) Then
                    oDBValorizadorPagableTX.GuardarValorizadorPagable(oDSModificar)
                    oDSValorizadorPagable.Merge(oDSModificar)
                End If

                Dim oDSEliminar As DataSet = oDSValorizadorPagable.GetChanges(DataRowState.Deleted)
                If Not (oDSEliminar Is Nothing) Then
                    oDBValorizadorPagableTX.GuardarValorizadorPagable(oDSEliminar)
                    oDSValorizadorPagable.Merge(oDSEliminar)
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
	''' Fecha Creacion: 11/03/2011 17:53:28
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
	<Serializable()> _
    Public Class clsBC_ValorizadorPagableRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 11/03/2011 17:53:28
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		
        Private oDBValorizadorPagableRO As clsDB_ValorizadorPagableRO
        Public oBEValorizadorPagable As clsBE_ValorizadorPagable
        
		Public LstValorizadorPagable As New List(Of clsBE_ValorizadorPagable)
		Public oDSValorizadorPagable As New DataSet
		Public oDTValorizadorPagable As New DataTable
		
		
        Sub New()
            oDBValorizadorPagableRO = New clsDB_ValorizadorPagableRO
            oBEValorizadorPagable = New clsBE_ValorizadorPagable
           
        End Sub
		
		Public Sub NuevaEntidad()
            oBEValorizadorPagable = New clsBE_ValorizadorPagable
          
        End Sub
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 11/03/2011 17:53:28
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerValorizadorPagable()
            Try
				oBEValorizadorPagable = oDBValorizadorPagableRO.LeerValorizadorPagable(oBEValorizadorPagable)
			Catch ex As Exception
				Throw ex
            End Try
        End Sub
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion:11/03/2011 17:53:28
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerListaValorizadorPagable()
            Try
				LstValorizadorPagable = oDBValorizadorPagableRO.LeerListaValorizadorPagable()
			Catch ex As Exception
                Throw ex
            End Try
        End Sub
		
		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:11/03/2011 17:53:28
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function LeerListaToDSValorizadorPagable() As DataSet		         
            Try
                oDSValorizadorPagable = oDBValorizadorPagableRO.LeerListaToDSValorizadorPagable(oBEValorizadorPagable)
                Return oDSValorizadorPagable
            Catch ex As Exception
                Throw ex
            End Try
        End Function	
		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:11/03/2011 17:53:28
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function DefinirTablaValorizadorPagable() As DataTable		         
            Try
                oDTValorizadorPagable = oDBValorizadorPagableRO.DefinirTablaValorizadorPagable()
                Return oDTValorizadorPagable
            Catch ex As Exception
                Throw ex
            End Try
        End Function	
		
    End Class
#End Region

End Namespace
