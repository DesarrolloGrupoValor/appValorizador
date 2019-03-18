Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:39:41
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_ContratoLoteTX
    ''' Fecha Modificacion:
    ''' </summary>
	'''

    Public Class clsBC_ContratoLoteTX


        Public oBE_AuditoriaD As clsBE_AuditoriaD


        'Inherits ServicedComponent

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:39:41
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_ContratoLoteTX
        ''' Fecha Modificacion:
        ''' </summary>

        Private oDBContratoLoteTX As clsDB_ContratoLoteTX
        Public oBEContratoLote As clsBE_ContratoLote
        Public LstContratoLote As New List(Of clsBE_ContratoLote)
        Public oDSContratoLote As DataSet

        Sub New()
            oDBContratoLoteTX = New clsDB_ContratoLoteTX
            oBEContratoLote = New clsBE_ContratoLote
        End Sub

        Public Sub NuevaEntidad()
            oBEContratoLote = New clsBE_ContratoLote
        End Sub

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:39:41
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function InsertarContratoLote() As Boolean
            Try
                Return oDBContratoLoteTX.InsertarContratoLote(LstContratoLote)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:39:41
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function EliminarContratoLote() As Boolean
            Try
                Return oDBContratoLoteTX.EliminarContratoLote(LstContratoLote)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:39:41
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function ModificarContratoLote() As Boolean
            Try
                Return oDBContratoLoteTX.ModificarContratoLote(LstContratoLote, oBE_AuditoriaD)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:39:41
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function GuardarContratoLote() As Boolean
            Try

                Dim oDSNuevo As DataSet = oDSContratoLote.GetChanges(DataRowState.Added)
                If Not (oDSNuevo Is Nothing) Then
                    oDBContratoLoteTX.GuardarContratoLote(oDSNuevo)
                    oDSContratoLote.Merge(oDSNuevo)
                End If

                Dim oDSModificar As DataSet = oDSContratoLote.GetChanges(DataRowState.Modified)
                If Not (oDSModificar Is Nothing) Then
                    oDBContratoLoteTX.GuardarContratoLote(oDSModificar)
                    oDSContratoLote.Merge(oDSModificar)
                End If

                Dim oDSEliminar As DataSet = oDSContratoLote.GetChanges(DataRowState.Deleted)
                If Not (oDSEliminar Is Nothing) Then
                    oDBContratoLoteTX.GuardarContratoLote(oDSEliminar)
                    oDSContratoLote.Merge(oDSEliminar)
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
	''' Fecha Creacion: 17/02/2011 16:39:41
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
	<Serializable()> _
    Public Class clsBC_ContratoLoteRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:39:41
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		
        Private oDBContratoLoteRO As clsDB_ContratoLoteRO
		Public oBEContratoLote As clsBE_ContratoLote
		Public LstContratoLote As New List(Of clsBE_ContratoLote)
		Public oDSContratoLote As New DataSet
        Public oDTContratoLote As New DataTable

        Public oBE_AuditoriaD As clsBE_AuditoriaD
		
		
        Sub New()
            oDBContratoLoteRO = New clsDB_ContratoLoteRO
			oBEContratoLote = New clsBE_ContratoLote
        End Sub
		
		Public Sub NuevaEntidad()
            oBEContratoLote = New clsBE_ContratoLote
        End Sub
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
		''' Fecha Creacion: 17/02/2011 16:39:41
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerContratoLote()
            Try
                oBEContratoLote = oDBContratoLoteRO.LeerContratoLote(oBEContratoLote, oBE_AuditoriaD)
			Catch ex As Exception
				Throw ex
            End Try
        End Sub
		
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:39:41
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
        Public Sub LeerListaContratoLote()
            Try
				LstContratoLote = oDBContratoLoteRO.LeerListaContratoLote()
			Catch ex As Exception
                Throw ex
            End Try
        End Sub
		
		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:39:41
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function LeerListaToDSContratoLote() As DataSet		         
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSContratoLote(oBEContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function



        Public Sub ContratoLote_Sel_Venta(ByVal pContratoLote As clsBE_ContratoLote)
            Try
                oBEContratoLote = oDBContratoLoteRO.ContratoLote_Sel_Venta(pContratoLote)

            Catch ex As Exception
                Throw ex
            End Try
        End Sub



		''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:39:41
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
		'''
		Public Function DefinirTablaContratoLote() As DataTable		         
            Try
                oDTContratoLote = oDBContratoLoteRO.DefinirTablaContratoLote()
                Return oDTContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function	




        Public Function LeerListaToDSContratoLote_Vinculada() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSContratoLote_Vinculada(oBEContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function LeerListaToDSContratoLoteCosto(ByVal pContratoLote As clsBE_ContratoLote) As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSContratoLoteCosto(pContratoLote)
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function LeerListaToDSRumasPendientesVincular() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSRumasPendientesVincular()
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDSRumasPendientesLotizar() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSRumasPendientesLotizar()
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDSDocumentosVenta() As DataSet
            Try
                oDSContratoLote = oDBContratoLoteRO.LeerListaToDSDocumentosVenta()
                Return oDSContratoLote
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class
#End Region

End Namespace
