Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"

    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:57:59
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_LiquidacionTotalTX
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsBC_LiquidacionTotalTX
        'Inherits ServicedComponent

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:57:59
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_LiquidacionTotalTX
        ''' Fecha Modificacion:
        ''' </summary>

        Private oDBLiquidacionTotalTX As clsDB_LiquidacionTotalTX
        Public oBELiquidacionTotal As clsBE_LiquidacionTotal
        Public LstLiquidacionTotal As New List(Of clsBE_LiquidacionTotal)
        Public oDSLiquidacionTotal As DataSet

        Sub New()
            oDBLiquidacionTotalTX = New clsDB_LiquidacionTotalTX
            oBELiquidacionTotal = New clsBE_LiquidacionTotal
        End Sub

        Public Sub NuevaEntidad()
            oBELiquidacionTotal = New clsBE_LiquidacionTotal
        End Sub

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:57:59
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function InsertarLiquidacionTotal() As Boolean
            Try
                Return oDBLiquidacionTotalTX.InsertarLiquidacionTotal(LstLiquidacionTotal)
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

        Public Function EliminarLiquidacionTotal() As Boolean
            Try
                Return oDBLiquidacionTotalTX.EliminarLiquidacionTotal(LstLiquidacionTotal)
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

        Public Function ModificarLiquidacionTotal() As Boolean
            Try
                Return oDBLiquidacionTotalTX.ModificarLiquidacionTotal(LstLiquidacionTotal)
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

        Public Function GuardarLiquidacionTotal() As Boolean
            Try

                Dim oDSNuevo As DataSet = oDSLiquidacionTotal.GetChanges(DataRowState.Added)
                If Not (oDSNuevo Is Nothing) Then
                    oDBLiquidacionTotalTX.GuardarLiquidacionTotal(oDSNuevo)
                    oDSLiquidacionTotal.Merge(oDSNuevo)
                End If

                Dim oDSModificar As DataSet = oDSLiquidacionTotal.GetChanges(DataRowState.Modified)
                If Not (oDSModificar Is Nothing) Then
                    oDBLiquidacionTotalTX.GuardarLiquidacionTotal(oDSModificar)
                    oDSLiquidacionTotal.Merge(oDSModificar)
                End If

                Dim oDSEliminar As DataSet = oDSLiquidacionTotal.GetChanges(DataRowState.Deleted)
                If Not (oDSEliminar Is Nothing) Then
                    oDBLiquidacionTotalTX.GuardarLiquidacionTotal(oDSEliminar)
                    oDSLiquidacionTotal.Merge(oDSEliminar)
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
    ''' Fecha Creacion: 17/02/2011 16:57:59
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsBC_LiquidacionTotalRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:57:59
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Private oDBLiquidacionTotalRO As clsDB_LiquidacionTotalRO
        Public oBELiquidacionTotal As clsBE_LiquidacionTotal
        Public LstLiquidacionTotal As New List(Of clsBE_LiquidacionTotal)
        Public oDSLiquidacionTotal As New DataSet
        Public oDTLiquidacionTotal As New DataTable


        Sub New()
            oDBLiquidacionTotalRO = New clsDB_LiquidacionTotalRO
            oBELiquidacionTotal = New clsBE_LiquidacionTotal
        End Sub

        Public Sub NuevaEntidad()
            oBELiquidacionTotal = New clsBE_LiquidacionTotal
        End Sub

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:57:59
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Sub LeerLiquidacionTotal()
            Try
                oBELiquidacionTotal = oDBLiquidacionTotalRO.LeerLiquidacionTotal(oBELiquidacionTotal)
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
        Public Sub LeerListaLiquidacionTotal()
            Try
                LstLiquidacionTotal = oDBLiquidacionTotalRO.LeerListaLiquidacionTotal()
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
        Public Function LeerListaToDSLiquidacionTotal() As DataSet
            Try
                oDSLiquidacionTotal = oDBLiquidacionTotalRO.LeerListaToDSLiquidacionTotal(oBELiquidacionTotal)
                Dim liTotal As Integer = oDSLiquidacionTotal.Tables(0).Rows.Count
                If liTotal > 0 Then
                    oDSLiquidacionTotal.Tables(0).Rows(liTotal - 1).Item("Eliminar") = "1"
                End If
               

                Return oDSLiquidacionTotal
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
        Public Function DefinirTablaLiquidacionTotal() As DataTable
            Try
                oDTLiquidacionTotal = oDBLiquidacionTotalRO.DefinirTablaLiquidacionTotal()
                Return oDTLiquidacionTotal
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class
#End Region

End Namespace
