Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:40:01
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_LiquidacionAdjuntoTX
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsBC_LiquidacionAdjuntoTX

        Private oDBLiquidacionAdjuntoTX As clsDB_LiquidacionAdjuntoTX
        Public oBELiquidacionAdjunto As clsBE_LiquidacionAdjunto
        Public LstLiquidacionAdjunto_Insertar As New List(Of clsBE_LiquidacionAdjunto)
        Public LstLiquidacionAdjunto_Eliminar As New List(Of clsBE_LiquidacionAdjunto)
        Public oDSLiquidacionAdjunto As DataSet

        Sub New()
            oDBLiquidacionAdjuntoTX = New clsDB_LiquidacionAdjuntoTX
            oBELiquidacionAdjunto = New clsBE_LiquidacionAdjunto
        End Sub

        Public Sub NuevaEntidad()
            oBELiquidacionAdjunto = New clsBE_LiquidacionAdjunto
        End Sub


        Public Function InsertaLiquidacionAdjunto() As Boolean
            Try
                Return oDBLiquidacionAdjuntoTX.InsertaLiquidacionAdjunto(LstLiquidacionAdjunto_Insertar)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function EliminaLiquidacionAdjunto() As Boolean
            Try
                Return oDBLiquidacionAdjuntoTX.EliminaLiquidacionAdjunto(LstLiquidacionAdjunto_Eliminar)
            Catch ex As Exception
                Throw ex
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
    Public Class clsBC_LiquidacionAdjuntoRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:40:01
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Private oDBLiquidacionAdjuntoRO As clsDB_LiquidacionAdjuntoRO
        Public oBELiquidacionAdjunto As clsBE_LiquidacionAdjunto
        Public LstLiquidacionAdjunto As New List(Of clsBE_LiquidacionAdjunto)
        Public oDSLiquidacionAdjunto As New DataSet
        Public oDTLiquidacionAdjunto As New DataTable


        Sub New()
            oDBLiquidacionAdjuntoRO = New clsDB_LiquidacionAdjuntoRO
            oBELiquidacionAdjunto = New clsBE_LiquidacionAdjunto
        End Sub

        Public Sub NuevaEntidad()
            oBELiquidacionAdjunto = New clsBE_LiquidacionAdjunto
        End Sub

        Public Sub LeerLiquidacionAdjuntoDS_Sel()
            Try
                oDSLiquidacionAdjunto = oDBLiquidacionAdjuntoRO.LeerLiquidacionAdjuntoDS_Sel(oBELiquidacionAdjunto)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub


        Public Function DefinirTablaLiquidacionAdjunto() As DataTable
            Try
                Return oDBLiquidacionAdjuntoRO.DefinirTablaLiquidacionAdjunto()
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class
#End Region

End Namespace
