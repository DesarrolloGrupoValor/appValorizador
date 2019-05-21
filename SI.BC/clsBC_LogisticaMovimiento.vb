Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 25/02/2011 10:15:55
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_LogisticaMovimientoTX
    ''' Fecha Modificacion:
    ''' </summary>
	'''

    Public Class clsBC_LogisticaMovimientoTX
		'Inherits ServicedComponent


        Public Property oBE_AuditoriaD As clsBE_AuditoriaD

        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 25/02/2011 10:15:55
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_LogisticaMovimientoTX
        ''' Fecha Modificacion:
        ''' </summary>
		
		Private oDBLogisticaMovimientoTX As clsDB_LogisticaMovimientoTX
		Public oBELogisticaMovimiento As clsBE_LogisticaMovimiento
		Public LstLogisticaMovimiento As New List(Of clsBE_LogisticaMovimiento)
		Public oDSLogisticaMovimiento As DataSet
		
        Sub New()
            oDBLogisticaMovimientoTX = New clsDB_LogisticaMovimientoTX
			oBELogisticaMovimiento = New clsBE_LogisticaMovimiento
        End Sub
		
		Public Sub NuevaEntidad()
            oBELogisticaMovimiento = New clsBE_LogisticaMovimiento
        End Sub
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 25/02/2011 10:15:55
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function InsertarLogisticaMovimiento() As Boolean
           	Try
				Return oDBLogisticaMovimientoTX.InsertarLogisticaMovimiento(LstLogisticaMovimiento)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 25/02/2011 10:15:55
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function EliminarLogisticaMovimiento() As Boolean
           	Try
				Return oDBLogisticaMovimientoTX.EliminarLogisticaMovimiento(LstLogisticaMovimiento)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 25/02/2011 10:15:55
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function ModificarLogisticaMovimiento() As Boolean
           	Try
				Return oDBLogisticaMovimientoTX.ModificarLogisticaMovimiento(LstLogisticaMovimiento)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 25/02/2011 10:15:55
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function GuardarLogisticaMovimiento() As Boolean
           	Try
								
				Dim oDSNuevo As DataSet = oDSLogisticaMovimiento.GetChanges(DataRowState.Added)
                If Not (oDSNuevo Is Nothing) Then
                    oDBLogisticaMovimientoTX.GuardarLogisticaMovimiento(oDSNuevo)
                    oDSLogisticaMovimiento.Merge(oDSNuevo)
                End If

                Dim oDSModificar As DataSet = oDSLogisticaMovimiento.GetChanges(DataRowState.Modified)
                If Not (oDSModificar Is Nothing) Then
                    oDBLogisticaMovimientoTX.GuardarLogisticaMovimiento(oDSModificar)
                    oDSLogisticaMovimiento.Merge(oDSModificar)
                End If

                Dim oDSEliminar As DataSet = oDSLogisticaMovimiento.GetChanges(DataRowState.Deleted)
                If Not (oDSEliminar Is Nothing) Then
                    oDBLogisticaMovimientoTX.GuardarLogisticaMovimiento(oDSEliminar)
                    oDSLogisticaMovimiento.Merge(oDSEliminar)
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
	''' Fecha Creacion: 25/02/2011 10:15:55
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
	<Serializable()> _
    Public Class clsBC_LogisticaMovimientoRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 25/02/2011 10:15:55
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		
        Private oDBLogisticaMovimientoRO As clsDB_LogisticaMovimientoRO
		Public oBELogisticaMovimiento As clsBE_LogisticaMovimiento
		Public LstLogisticaMovimiento As New List(Of clsBE_LogisticaMovimiento)
		Public oDSLogisticaMovimiento As New DataSet
		Public oDTLogisticaMovimiento As New DataTable
		
		
        Sub New()
            oDBLogisticaMovimientoRO = New clsDB_LogisticaMovimientoRO
			oBELogisticaMovimiento = New clsBE_LogisticaMovimiento
        End Sub
		
		Public Sub NuevaEntidad()
            oBELogisticaMovimiento = New clsBE_LogisticaMovimiento
        End Sub
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 25/02/2011 10:15:55
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerLogisticaMovimiento()
            Try
				oBELogisticaMovimiento = oDBLogisticaMovimientoRO.LeerLogisticaMovimiento(oBELogisticaMovimiento)
			Catch ex As Exception
				Throw ex
            End Try
        End Sub
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion:25/02/2011 10:15:55
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerListaLogisticaMovimiento()
            Try
				LstLogisticaMovimiento = oDBLogisticaMovimientoRO.LeerListaLogisticaMovimiento()
			Catch ex As Exception
                Throw ex
            End Try
        End Sub
		
		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:25/02/2011 10:15:55
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function LeerListaToDSLogisticaMovimiento() As DataSet		         
            Try
                oDSLogisticaMovimiento = oDBLogisticaMovimientoRO.LeerListaToDSLogisticaMovimiento(oBELogisticaMovimiento)
                Return oDSLogisticaMovimiento
            Catch ex As Exception
                Throw ex
            End Try
        End Function	
		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:25/02/2011 10:15:55
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function DefinirTablaLogisticaMovimiento() As DataTable		         
            Try
                oDTLogisticaMovimiento = oDBLogisticaMovimientoRO.DefinirTablaLogisticaMovimiento()
                Return oDTLogisticaMovimiento
            Catch ex As Exception
                Throw ex
            End Try
        End Function	
		
    End Class
#End Region

End Namespace
