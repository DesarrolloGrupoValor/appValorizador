Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:18
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_LiquidacionTmTX
    ''' Fecha Modificacion:
    ''' </summary>
	'''

    Public Class clsBC_LiquidacionTmTX
		'Inherits ServicedComponent
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:18
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_LiquidacionTmTX
        ''' Fecha Modificacion:
        ''' </summary>
		
		Private oDBLiquidacionTmTX As clsDB_LiquidacionTmTX
		Public oBELiquidacionTm As clsBE_LiquidacionTm
		Public LstLiquidacionTm As New List(Of clsBE_LiquidacionTm)
		Public oDSLiquidacionTm As DataSet
		
        Sub New()
            oDBLiquidacionTmTX = New clsDB_LiquidacionTmTX
			oBELiquidacionTm = New clsBE_LiquidacionTm
        End Sub
		
		Public Sub NuevaEntidad()
            oBELiquidacionTm = New clsBE_LiquidacionTm
        End Sub
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:18
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function InsertarLiquidacionTm() As Boolean
           	Try
				Return oDBLiquidacionTmTX.InsertarLiquidacionTm(LstLiquidacionTm)
			Catch ex As Exception
                Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:18
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function EliminarLiquidacionTm() As Boolean
           	Try
				Return oDBLiquidacionTmTX.EliminarLiquidacionTm(LstLiquidacionTm)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:18
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function ModificarLiquidacionTm() As Boolean
            Try
                'Return oDBLiquidacionTmTX.ModificarLiquidacionTm(LstLiquidacionTmUpd)
                Return oDBLiquidacionTmTX.ModificarLiquidacionTm(LstLiquidacionTm)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:18
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
				
        Public Function GuardarLiquidacionTm() As Boolean
           	Try
								
				Dim oDSNuevo As DataSet = oDSLiquidacionTm.GetChanges(DataRowState.Added)
                If Not (oDSNuevo Is Nothing) Then
                    oDBLiquidacionTmTX.GuardarLiquidacionTm(oDSNuevo)
                    oDSLiquidacionTm.Merge(oDSNuevo)
                End If

                Dim oDSModificar As DataSet = oDSLiquidacionTm.GetChanges(DataRowState.Modified)
                If Not (oDSModificar Is Nothing) Then
                    oDBLiquidacionTmTX.GuardarLiquidacionTm(oDSModificar)
                    oDSLiquidacionTm.Merge(oDSModificar)
                End If

                Dim oDSEliminar As DataSet = oDSLiquidacionTm.GetChanges(DataRowState.Deleted)
                If Not (oDSEliminar Is Nothing) Then
                    oDBLiquidacionTmTX.GuardarLiquidacionTm(oDSEliminar)
                    oDSLiquidacionTm.Merge(oDSEliminar)
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
	''' Fecha Creacion: 17/02/2011 16:58:18
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
	<Serializable()> _
    Public Class clsBC_LiquidacionTmRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:18
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		
        Private oDBLiquidacionTmRO As clsDB_LiquidacionTmRO
		Public oBELiquidacionTm As clsBE_LiquidacionTm
		Public LstLiquidacionTm As New List(Of clsBE_LiquidacionTm)
		Public oDSLiquidacionTm As New DataSet
		Public oDTLiquidacionTm As New DataTable
		
		
        Sub New()
            oDBLiquidacionTmRO = New clsDB_LiquidacionTmRO
			oBELiquidacionTm = New clsBE_LiquidacionTm
        End Sub
		
		Public Sub NuevaEntidad()
            oBELiquidacionTm = New clsBE_LiquidacionTm
        End Sub
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:18
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerLiquidacionTm()
            Try
				oBELiquidacionTm = oDBLiquidacionTmRO.LeerLiquidacionTm(oBELiquidacionTm)
			Catch ex As Exception
				Throw ex
            End Try
        End Sub
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:58:18
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerListaLiquidacionTm()
            Try
				LstLiquidacionTm = oDBLiquidacionTmRO.LeerListaLiquidacionTm()
			Catch ex As Exception
                Throw ex
            End Try
        End Sub
		
		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:58:18
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function LeerListaToDSLiquidacionTm() As DataSet		         
            Try
                oDSLiquidacionTm = oDBLiquidacionTmRO.LeerListaToDSLiquidacionTm(oBELiquidacionTm)
                Return oDSLiquidacionTm
            Catch ex As Exception
                Throw ex
            End Try
        End Function	
		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:58:18
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function DefinirTablaLiquidacionTm() As DataTable		         
            Try
                oDTLiquidacionTm = oDBLiquidacionTmRO.DefinirTablaLiquidacionTm()
                Return oDTLiquidacionTm
            Catch ex As Exception
                Throw ex
            End Try
        End Function	
        Public Function GuardarLiquidacionTm(ByVal psIdContratoLote As String, ByVal psIdLiquidacion As String) As Boolean
            Return oDBLiquidacionTmRO.GuardarLiquidacionTm(psIdContratoLote, psIdLiquidacion)
        End Function

        Public Function BuscaLiquidacionTm_RumaLiquidada(ByVal psIdContratoLote As String, ByVal psCodigoLote As String) As Boolean
            Return oDBLiquidacionTmRO.BuscaLiquidacionTm_RumaLiquidada(psIdContratoLote, psCodigoLote)
        End Function

    End Class
#End Region

    

End Namespace
