Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 11/03/2011 17:53:49
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_ValorizadorPenalizableTX
    ''' Fecha Modificacion:
    ''' </summary>
	'''

    Public Class clsBC_ValorizadorPenalizableTX
		'Inherits ServicedComponent
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 11/03/2011 17:53:49
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_ValorizadorPenalizableTX
        ''' Fecha Modificacion:
        ''' </summary>
		
		Private oDBValorizadorPenalizableTX As clsDB_ValorizadorPenalizableTX
		Public oBEValorizadorPenalizable As clsBE_ValorizadorPenalizable
		Public LstValorizadorPenalizable As New List(Of clsBE_ValorizadorPenalizable)
		Public oDSValorizadorPenalizable As DataSet
		
        Sub New()
            oDBValorizadorPenalizableTX = New clsDB_ValorizadorPenalizableTX
			oBEValorizadorPenalizable = New clsBE_ValorizadorPenalizable
        End Sub
		
		Public Sub NuevaEntidad()
            oBEValorizadorPenalizable = New clsBE_ValorizadorPenalizable
        End Sub
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 11/03/2011 17:53:49
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function InsertarValorizadorPenalizable() As Boolean
           	Try
				Return oDBValorizadorPenalizableTX.InsertarValorizadorPenalizable(LstValorizadorPenalizable)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 11/03/2011 17:53:49
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function EliminarValorizadorPenalizable() As Boolean
           	Try
				Return oDBValorizadorPenalizableTX.EliminarValorizadorPenalizable(LstValorizadorPenalizable)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 11/03/2011 17:53:49
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function ModificarValorizadorPenalizable() As Boolean
           	Try
				Return oDBValorizadorPenalizableTX.ModificarValorizadorPenalizable(LstValorizadorPenalizable)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 11/03/2011 17:53:49
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function GuardarValorizadorPenalizable() As Boolean
           	Try
								
				Dim oDSNuevo As DataSet = oDSValorizadorPenalizable.GetChanges(DataRowState.Added)
                If Not (oDSNuevo Is Nothing) Then
                    oDBValorizadorPenalizableTX.GuardarValorizadorPenalizable(oDSNuevo)
                    oDSValorizadorPenalizable.Merge(oDSNuevo)
                End If

                Dim oDSModificar As DataSet = oDSValorizadorPenalizable.GetChanges(DataRowState.Modified)
                If Not (oDSModificar Is Nothing) Then
                    oDBValorizadorPenalizableTX.GuardarValorizadorPenalizable(oDSModificar)
                    oDSValorizadorPenalizable.Merge(oDSModificar)
                End If

                Dim oDSEliminar As DataSet = oDSValorizadorPenalizable.GetChanges(DataRowState.Deleted)
                If Not (oDSEliminar Is Nothing) Then
                    oDBValorizadorPenalizableTX.GuardarValorizadorPenalizable(oDSEliminar)
                    oDSValorizadorPenalizable.Merge(oDSEliminar)
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
	''' Fecha Creacion: 11/03/2011 17:53:49
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
	<Serializable()> _
    Public Class clsBC_ValorizadorPenalizableRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 11/03/2011 17:53:49
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		
        Private oDBValorizadorPenalizableRO As clsDB_ValorizadorPenalizableRO
		Public oBEValorizadorPenalizable As clsBE_ValorizadorPenalizable
		Public LstValorizadorPenalizable As New List(Of clsBE_ValorizadorPenalizable)
		Public oDSValorizadorPenalizable As New DataSet
		Public oDTValorizadorPenalizable As New DataTable
		
		
        Sub New()
            oDBValorizadorPenalizableRO = New clsDB_ValorizadorPenalizableRO
			oBEValorizadorPenalizable = New clsBE_ValorizadorPenalizable
        End Sub
		
		Public Sub NuevaEntidad()
            oBEValorizadorPenalizable = New clsBE_ValorizadorPenalizable
        End Sub
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 11/03/2011 17:53:49
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerValorizadorPenalizable()
            Try
				oBEValorizadorPenalizable = oDBValorizadorPenalizableRO.LeerValorizadorPenalizable(oBEValorizadorPenalizable)
			Catch ex As Exception
				Throw ex
            End Try
        End Sub
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion:11/03/2011 17:53:49
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerListaValorizadorPenalizable()
            Try
				LstValorizadorPenalizable = oDBValorizadorPenalizableRO.LeerListaValorizadorPenalizable()
			Catch ex As Exception
                Throw ex
            End Try
        End Sub
		
		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:11/03/2011 17:53:49
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function LeerListaToDSValorizadorPenalizable() As DataSet		         
            Try
                oDSValorizadorPenalizable = oDBValorizadorPenalizableRO.LeerListaToDSValorizadorPenalizable(oBEValorizadorPenalizable)
                Return oDSValorizadorPenalizable
            Catch ex As Exception
                Throw ex
            End Try
        End Function	
		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:11/03/2011 17:53:49
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function DefinirTablaValorizadorPenalizable() As DataTable		         
            Try
                oDTValorizadorPenalizable = oDBValorizadorPenalizableRO.DefinirTablaValorizadorPenalizable()
                Return oDTValorizadorPenalizable
            Catch ex As Exception
                Throw ex
            End Try
        End Function	
		
    End Class
#End Region

End Namespace
