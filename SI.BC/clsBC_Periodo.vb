'Modified:
'@01 20141014 BAL01 Mantenimiento de periodos
'@02 20141021 BAL01 Validacion, al generar liquidacion PRV o FIN, eliminar PRL en caso esten en el mismo periodo

Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:34
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_PeriodoTX
    ''' Fecha Modificacion:
    ''' </summary>
	'''

    Public Class clsBC_PeriodoTX
		'Inherits ServicedComponent
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:34
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_PeriodoTX
        ''' Fecha Modificacion:
        ''' </summary>
		
		Private oDBPeriodoTX As clsDB_PeriodoTX
		Public oBEPeriodo As clsBE_Periodo
		Public LstPeriodo As New List(Of clsBE_Periodo)
		Public oDSPeriodo As DataSet
		
        Sub New()
            oDBPeriodoTX = New clsDB_PeriodoTX
			oBEPeriodo = New clsBE_Periodo
        End Sub
		
		Public Sub NuevaEntidad()
            oBEPeriodo = New clsBE_Periodo
        End Sub
		
		'<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:34
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        
				
        Public Function InsertarPeriodo() As Boolean
           	Try
				Return oDBPeriodoTX.InsertarPeriodo(LstPeriodo)
			Catch ex As Exception
				Throw ex
				Return False
            End Try
        End Function

        '@01    AINI
        Public Function InsertPeriodoByEmpresa(ByVal EmpresaID As String, ByVal periodo As String, ByVal fDeclara As String, ByVal cerrado As Integer) As Boolean
            Try
                Return oDBPeriodoTX.InsertPeriodoByEmpresa(EmpresaID, periodo, fDeclara, cerrado)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function

        Public Function UpdatePeriodoByEmpresa(ByVal EmpresaID As String, ByVal periodo As String, ByVal fDeclara As String, ByVal cerrado As Integer) As Boolean
            Try
                Return oDBPeriodoTX.UpdatePeriodoByEmpresa(EmpresaID, periodo, fDeclara, cerrado)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function

        Public Function ValidarRumasPendientesLotizar(ByVal EmpresaID As String, ByVal periodo As String) As Boolean
            Try
                Return oDBPeriodoTX.ValidarRumasPendientesLotizar(EmpresaID, periodo)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function

        Public Function ValidarRumasFicticias(ByVal EmpresaID As String, ByVal periodo As String) As Boolean
            Try
                Return oDBPeriodoTX.ValidarRumasFicticias(EmpresaID, periodo)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function
        '@01    AFIN


        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:34
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function EliminarPeriodo() As Boolean
            Try
                Return oDBPeriodoTX.EliminarPeriodo(LstPeriodo)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:34
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function ModificarPeriodo() As Boolean
            Try
                Return oDBPeriodoTX.ModificarPeriodo(LstPeriodo)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:34
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function GuardarPeriodo() As Boolean
            Try

                Dim oDSNuevo As DataSet = oDSPeriodo.GetChanges(DataRowState.Added)
                If Not (oDSNuevo Is Nothing) Then
                    oDBPeriodoTX.GuardarPeriodo(oDSNuevo)
                    oDSPeriodo.Merge(oDSNuevo)
                End If

                Dim oDSModificar As DataSet = oDSPeriodo.GetChanges(DataRowState.Modified)
                If Not (oDSModificar Is Nothing) Then
                    oDBPeriodoTX.GuardarPeriodo(oDSModificar)
                    oDSPeriodo.Merge(oDSModificar)
                End If

                Dim oDSEliminar As DataSet = oDSPeriodo.GetChanges(DataRowState.Deleted)
                If Not (oDSEliminar Is Nothing) Then
                    oDBPeriodoTX.GuardarPeriodo(oDSEliminar)
                    oDSPeriodo.Merge(oDSEliminar)
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
	''' Fecha Creacion: 17/02/2011 16:58:34
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
	<Serializable()> _
    Public Class clsBC_PeriodoRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:34
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		
        Private oDBPeriodoRO As clsDB_PeriodoRO
		Public oBEPeriodo As clsBE_Periodo
		Public LstPeriodo As New List(Of clsBE_Periodo)
		Public oDSPeriodo As New DataSet
		Public oDTPeriodo As New DataTable
		
		
        Sub New()
            oDBPeriodoRO = New clsDB_PeriodoRO
			oBEPeriodo = New clsBE_Periodo
        End Sub
		
		Public Sub NuevaEntidad()
            oBEPeriodo = New clsBE_Periodo
        End Sub

        '@01    AINI
        Public Function GetPeriodoByEmpresa(ByVal EmpresaID As String) As DataTable
            Return oDBPeriodoRO.GetPeriodoByEmpresa(EmpresaID)
        End Function

        Public Function ValidaPeriodoCerrado(ByVal EmpresaID As String, ByVal periodo As String) As Boolean
            Return oDBPeriodoRO.ValidaPeriodoCerrado(EmpresaID, periodo)
        End Function
        '@01    AFIN

        '@02    AINI
        Public Function EliminarPRLByPeriodo(ByVal ContratoLoteId As String, ByVal periodo As String) As Boolean
            Return oDBPeriodoRO.EliminarPRLByPeriodo(ContratoLoteId, periodo)
        End Function
        '@02    AFIN

        Public Function ObtenerPeriodo(Optional ByVal sTipoPeriodo As String = "P") As DataSet
            Try
                Return oDBPeriodoRO.ObtenerPeriodo(sTipoPeriodo)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:58:34
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerPeriodo()
            Try
				oBEPeriodo = oDBPeriodoRO.LeerPeriodo(oBEPeriodo)
			Catch ex As Exception
				Throw ex
            End Try
        End Sub
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:58:34
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerListaPeriodo()
            Try
				LstPeriodo = oDBPeriodoRO.LeerListaPeriodo()
			Catch ex As Exception
                Throw ex
            End Try
        End Sub
		
		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:58:34
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function LeerListaToDSPeriodo() As DataSet		         
            Try
                oDSPeriodo = oDBPeriodoRO.LeerListaToDSPeriodo(oBEPeriodo)
                Return oDSPeriodo
            Catch ex As Exception
                Throw ex
            End Try
        End Function	
		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:58:34
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function DefinirTablaPeriodo() As DataTable		         
            Try
                oDTPeriodo = oDBPeriodoRO.DefinirTablaPeriodo()
                Return oDTPeriodo
            Catch ex As Exception
                Throw ex
            End Try
        End Function	
		
    End Class
#End Region

End Namespace
