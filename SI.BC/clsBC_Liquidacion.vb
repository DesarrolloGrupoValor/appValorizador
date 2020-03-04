Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:40:01
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_LiquidacionTX
    ''' Fecha Modificacion:
    ''' </summary>
	'''

    Public Class clsBC_LiquidacionTX
		'Inherits ServicedComponent
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:40:01
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_LiquidacionTX
        ''' Fecha Modificacion:
        ''' </summary>
		
		Private oDBLiquidacionTX As clsDB_LiquidacionTX
		Public oBELiquidacion As clsBE_Liquidacion
		Public LstLiquidacion As New List(Of clsBE_Liquidacion)
		Public oDSLiquidacion As DataSet
		
        Sub New()
            oDBLiquidacionTX = New clsDB_LiquidacionTX
			oBELiquidacion = New clsBE_Liquidacion
        End Sub
		
		Public Sub NuevaEntidad()
            oBELiquidacion = New clsBE_Liquidacion
        End Sub
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:40:01
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function InsertarLiquidacion() As Boolean
           	Try
				Return oDBLiquidacionTX.InsertarLiquidacion(LstLiquidacion)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:40:01
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function EliminarLiquidacion() As Boolean
           	Try
				Return oDBLiquidacionTX.EliminarLiquidacion(LstLiquidacion)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:40:01
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function ModificarLiquidacion() As Boolean
           	Try
				Return oDBLiquidacionTX.ModificarLiquidacion(LstLiquidacion)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:40:01
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function GuardarLiquidacion() As Boolean
           	Try
								
				Dim oDSNuevo As DataSet = oDSLiquidacion.GetChanges(DataRowState.Added)
                If Not (oDSNuevo Is Nothing) Then
                    oDBLiquidacionTX.GuardarLiquidacion(oDSNuevo)
                    oDSLiquidacion.Merge(oDSNuevo)
                End If

                Dim oDSModificar As DataSet = oDSLiquidacion.GetChanges(DataRowState.Modified)
                If Not (oDSModificar Is Nothing) Then
                    oDBLiquidacionTX.GuardarLiquidacion(oDSModificar)
                    oDSLiquidacion.Merge(oDSModificar)
                End If

                Dim oDSEliminar As DataSet = oDSLiquidacion.GetChanges(DataRowState.Deleted)
                If Not (oDSEliminar Is Nothing) Then
                    oDBLiquidacionTX.GuardarLiquidacion(oDSEliminar)
                    oDSLiquidacion.Merge(oDSEliminar)
                End If

                Return True
												
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function


        Public Function Modificar_Liquidacion_Financiamiento() As Boolean
            Try
                Return oDBLiquidacionTX.Modificar_Liquidacion_Financiamiento(oBELiquidacion)
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
	''' Fecha Creacion: 17/02/2011 16:40:01
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
	<Serializable()> _
    Public Class clsBC_LiquidacionRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:40:01
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		
        Private oDBLiquidacionRO As clsDB_LiquidacionRO
		Public oBELiquidacion As clsBE_Liquidacion
		Public LstLiquidacion As New List(Of clsBE_Liquidacion)
		Public oDSLiquidacion As New DataSet
		Public oDTLiquidacion As New DataTable
		
		
        Sub New()
            oDBLiquidacionRO = New clsDB_LiquidacionRO
			oBELiquidacion = New clsBE_Liquidacion
        End Sub
		
		Public Sub NuevaEntidad()
            oBELiquidacion = New clsBE_Liquidacion
        End Sub
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:40:01
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerLiquidacion()
            Try
				oBELiquidacion = oDBLiquidacionRO.LeerLiquidacion(oBELiquidacion)
			Catch ex As Exception
				Throw ex
            End Try
        End Sub
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:40:01
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerListaLiquidacion()
            Try
				LstLiquidacion = oDBLiquidacionRO.LeerListaLiquidacion()
			Catch ex As Exception
                Throw ex
            End Try
        End Sub


		
		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:40:01
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function LeerListaToDSLiquidacion() As DataSet		         
            Try
                oDSLiquidacion = oDBLiquidacionRO.LeerListaToDSLiquidacion(oBELiquidacion)
                Return oDSLiquidacion
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function LeerListaToDSLiquidacion_Documento() As DataSet
            Try
                oDSLiquidacion = oDBLiquidacionRO.LeerListaToDSLiquidacion_Documento(oBELiquidacion)
                Return oDSLiquidacion
            Catch ex As Exception
                Throw ex
            End Try
        End Function

		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:40:01
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function DefinirTablaLiquidacion() As DataTable		         
            Try
                oDTLiquidacion = oDBLiquidacionRO.DefinirTablaLiquidacion()
                Return oDTLiquidacion
            Catch ex As Exception
                Throw ex
            End Try
        End Function	




        Public Function LeerLiquidacuibToDSFactura() As DataSet
            Try
                oDSLiquidacion = oDBLiquidacionRO.LeerLiquidacuibToDSFactura(oBELiquidacion)
                Return oDSLiquidacion
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function ObtenerCantidadLiquidaciones(ByVal sContratoloteId As String) As Integer
            Try
                Return oDBLiquidacionRO.ObtenerCantidadLiquidaciones(sContratoloteId)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ObtenerCantidadAdjuntos(ByVal sContratoloteId As String, sLiquidacionId As String, sTipoDocumento As String) As Integer
            Try
                Return oDBLiquidacionRO.ObtenerCantidadAdjuntos(sContratoloteId, sLiquidacionId, sTipoDocumento)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        

    End Class
#End Region

End Namespace
