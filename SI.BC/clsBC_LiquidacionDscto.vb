Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:42:13
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_LiquidacionDsctoTX
    ''' Fecha Modificacion:
    ''' </summary>
	'''

    Public Class clsBC_LiquidacionDsctoTX
		'Inherits ServicedComponent
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:42:13
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_LiquidacionDsctoTX
        ''' Fecha Modificacion:
        ''' </summary>
		
		Private oDBLiquidacionDsctoTX As clsDB_LiquidacionDsctoTX
		Public oBELiquidacionDscto As clsBE_LiquidacionDscto
		Public LstLiquidacionDscto As New List(Of clsBE_LiquidacionDscto)
		Public oDSLiquidacionDscto As DataSet
		
        Sub New()
            oDBLiquidacionDsctoTX = New clsDB_LiquidacionDsctoTX
			oBELiquidacionDscto = New clsBE_LiquidacionDscto
        End Sub
		
		Public Sub NuevaEntidad()
            oBELiquidacionDscto = New clsBE_LiquidacionDscto
        End Sub
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:42:13
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function InsertarLiquidacionDscto() As Boolean
           	Try
				Return oDBLiquidacionDsctoTX.InsertarLiquidacionDscto(LstLiquidacionDscto)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:42:13
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function EliminarLiquidacionDscto() As Boolean
           	Try
				Return oDBLiquidacionDsctoTX.EliminarLiquidacionDscto(LstLiquidacionDscto)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:42:13
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function ModificarLiquidacionDscto() As Boolean
           	Try
				Return oDBLiquidacionDsctoTX.ModificarLiquidacionDscto(LstLiquidacionDscto)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:42:13
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function GuardarLiquidacionDscto() As Boolean
           	Try
								
				Dim oDSNuevo As DataSet = oDSLiquidacionDscto.GetChanges(DataRowState.Added)
                If Not (oDSNuevo Is Nothing) Then
                    oDBLiquidacionDsctoTX.GuardarLiquidacionDscto(oDSNuevo)
                    oDSLiquidacionDscto.Merge(oDSNuevo)
                End If

                Dim oDSModificar As DataSet = oDSLiquidacionDscto.GetChanges(DataRowState.Modified)
                If Not (oDSModificar Is Nothing) Then
                    oDBLiquidacionDsctoTX.GuardarLiquidacionDscto(oDSModificar)
                    oDSLiquidacionDscto.Merge(oDSModificar)
                End If

                Dim oDSEliminar As DataSet = oDSLiquidacionDscto.GetChanges(DataRowState.Deleted)
                If Not (oDSEliminar Is Nothing) Then
                    oDBLiquidacionDsctoTX.GuardarLiquidacionDscto(oDSEliminar)
                    oDSLiquidacionDscto.Merge(oDSEliminar)
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
	''' Fecha Creacion: 17/02/2011 16:42:13
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
	<Serializable()> _
    Public Class clsBC_LiquidacionDsctoRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:42:13
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		
        Private oDBLiquidacionDsctoRO As clsDB_LiquidacionDsctoRO
		Public oBELiquidacionDscto As clsBE_LiquidacionDscto
		Public LstLiquidacionDscto As New List(Of clsBE_LiquidacionDscto)
		Public oDSLiquidacionDscto As New DataSet
		Public oDTLiquidacionDscto As New DataTable
		
		
        Sub New()
            oDBLiquidacionDsctoRO = New clsDB_LiquidacionDsctoRO
			oBELiquidacionDscto = New clsBE_LiquidacionDscto
        End Sub
		
		Public Sub NuevaEntidad()
            oBELiquidacionDscto = New clsBE_LiquidacionDscto
        End Sub
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:42:13
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerLiquidacionDscto()
            Try
				oBELiquidacionDscto = oDBLiquidacionDsctoRO.LeerLiquidacionDscto(oBELiquidacionDscto)
			Catch ex As Exception
				Throw ex
            End Try
        End Sub
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:42:13
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerListaLiquidacionDscto()
            Try
				LstLiquidacionDscto = oDBLiquidacionDsctoRO.LeerListaLiquidacionDscto()
			Catch ex As Exception
                Throw ex
            End Try
        End Sub
		
		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:42:13
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function LeerListaToDSLiquidacionDscto() As DataSet		         
            Try
                oDSLiquidacionDscto = oDBLiquidacionDsctoRO.LeerListaToDSLiquidacionDscto(oBELiquidacionDscto)
                Return oDSLiquidacionDscto
            Catch ex As Exception
                Throw ex
            End Try
        End Function	
		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:42:13
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function DefinirTablaLiquidacionDscto() As DataTable		         
            Try
                oDTLiquidacionDscto = oDBLiquidacionDsctoRO.DefinirTablaLiquidacionDscto()
                Return oDTLiquidacionDscto
            Catch ex As Exception
                Throw ex
            End Try
        End Function	



        ''' <summary>
        ''' Escrito por: Lissete Miyahira
        ''' Fecha Creacion:17/02/2011 16:42:13
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function ObtenerProvisionalDscto() As DataSet
            Try
                oDSLiquidacionDscto = oDBLiquidacionDsctoRO.ObtenerProvisionalDscto(oBELiquidacionDscto)
                Return oDSLiquidacionDscto
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class
#End Region

End Namespace
