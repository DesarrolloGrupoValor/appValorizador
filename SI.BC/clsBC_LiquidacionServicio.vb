Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:57:59
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_LiquidacionServicioTX
    ''' Fecha Modificacion:
    ''' </summary>
	'''

    Public Class clsBC_LiquidacionServicioTX
		'Inherits ServicedComponent
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:57:59
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_LiquidacionServicioTX
        ''' Fecha Modificacion:
        ''' </summary>
		
		Private oDBLiquidacionServicioTX As clsDB_LiquidacionServicioTX
		Public oBELiquidacionServicio As clsBE_LiquidacionServicio
		Public LstLiquidacionServicio As New List(Of clsBE_LiquidacionServicio)
		Public oDSLiquidacionServicio As DataSet
		
        Sub New()
            oDBLiquidacionServicioTX = New clsDB_LiquidacionServicioTX
			oBELiquidacionServicio = New clsBE_LiquidacionServicio
        End Sub
		
		Public Sub NuevaEntidad()
            oBELiquidacionServicio = New clsBE_LiquidacionServicio
        End Sub
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:57:59
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function InsertarLiquidacionServicio() As Boolean
           	Try
				Return oDBLiquidacionServicioTX.InsertarLiquidacionServicio(LstLiquidacionServicio)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:57:59
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function EliminarLiquidacionServicio() As Boolean
           	Try
				Return oDBLiquidacionServicioTX.EliminarLiquidacionServicio(LstLiquidacionServicio)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:57:59
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function ModificarLiquidacionServicio() As Boolean
           	Try
				Return oDBLiquidacionServicioTX.ModificarLiquidacionServicio(LstLiquidacionServicio)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:57:59
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function GuardarLiquidacionServicio() As Boolean
           	Try
								
				Dim oDSNuevo As DataSet = oDSLiquidacionServicio.GetChanges(DataRowState.Added)
                If Not (oDSNuevo Is Nothing) Then
                    oDBLiquidacionServicioTX.GuardarLiquidacionServicio(oDSNuevo)
                    oDSLiquidacionServicio.Merge(oDSNuevo)
                End If

                Dim oDSModificar As DataSet = oDSLiquidacionServicio.GetChanges(DataRowState.Modified)
                If Not (oDSModificar Is Nothing) Then
                    oDBLiquidacionServicioTX.GuardarLiquidacionServicio(oDSModificar)
                    oDSLiquidacionServicio.Merge(oDSModificar)
                End If

                Dim oDSEliminar As DataSet = oDSLiquidacionServicio.GetChanges(DataRowState.Deleted)
                If Not (oDSEliminar Is Nothing) Then
                    oDBLiquidacionServicioTX.GuardarLiquidacionServicio(oDSEliminar)
                    oDSLiquidacionServicio.Merge(oDSEliminar)
                End If

                Return True
												
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function


        Public Function CostoLiquidacionServicio() As Boolean
            Try
                Return oDBLiquidacionServicioTX.CostoLiquidacionServicio(LstLiquidacionServicio)
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
	''' Fecha Creacion: 17/02/2011 16:57:59
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
	<Serializable()> _
    Public Class clsBC_LiquidacionServicioRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:57:59
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		
        Private oDBLiquidacionServicioRO As clsDB_LiquidacionServicioRO
		Public oBELiquidacionServicio As clsBE_LiquidacionServicio
		Public LstLiquidacionServicio As New List(Of clsBE_LiquidacionServicio)
		Public oDSLiquidacionServicio As New DataSet
		Public oDTLiquidacionServicio As New DataTable
		
		
        Sub New()
            oDBLiquidacionServicioRO = New clsDB_LiquidacionServicioRO
			oBELiquidacionServicio = New clsBE_LiquidacionServicio
        End Sub
		
		Public Sub NuevaEntidad()
            oBELiquidacionServicio = New clsBE_LiquidacionServicio
        End Sub
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:57:59
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerLiquidacionServicio()
            Try
				oBELiquidacionServicio = oDBLiquidacionServicioRO.LeerLiquidacionServicio(oBELiquidacionServicio)
			Catch ex As Exception
				Throw ex
            End Try
        End Sub
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:57:59
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerListaLiquidacionServicio()
            Try
				LstLiquidacionServicio = oDBLiquidacionServicioRO.LeerListaLiquidacionServicio()
			Catch ex As Exception
                Throw ex
            End Try
        End Sub
		
		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:57:59
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function LeerListaToDSLiquidacionServicio() As DataSet		         
            Try
                oDSLiquidacionServicio = oDBLiquidacionServicioRO.LeerListaToDSLiquidacionServicio(oBELiquidacionServicio)
                Return oDSLiquidacionServicio
            Catch ex As Exception
                Throw ex
            End Try
        End Function

 
		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:57:59
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function DefinirTablaLiquidacionServicio() As DataTable		         
            Try
                oDTLiquidacionServicio = oDBLiquidacionServicioRO.DefinirTablaLiquidacionServicio()
                Return oDTLiquidacionServicio
            Catch ex As Exception
                Throw ex
            End Try
        End Function	
		
    End Class
#End Region

End Namespace
