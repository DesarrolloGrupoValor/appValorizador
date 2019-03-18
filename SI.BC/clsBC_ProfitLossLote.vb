Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:42:13
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_ProfitLossTX
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsBC_ProfitLossLoteTX
        'Inherits ServicedComponent

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:42:13
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_ProfitLossTX
        ''' Fecha Modificacion:
        ''' </summary>

        Private oDBProfitLossTX As clsDB_ProfitLossLoteTX
        Public oBEProfitLoss As clsBE_ProfitLossLote
        Public LstProfitLoss As New List(Of clsBE_ProfitLossLote)
        Public oDSProfitLoss As DataSet


        Public SqlDataAdapter As System.Data.SqlClient.SqlDataAdapter
        Public dtProfitLoss As New DataTable()

        Sub New()
            oDBProfitLossTX = New clsDB_ProfitLossLoteTX
            oBEProfitLoss = New clsBE_ProfitLossLote
        End Sub

        Public Sub NuevaEntidad()
            oBEProfitLoss = New clsBE_ProfitLossLote
        End Sub

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:42:13
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function InsertarProfitLoss() As Boolean
            Try
                Return oDBProfitLossTX.InsertarProfitLoss(oBEProfitLoss)
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

        Public Function ModificarProfitLoss() As Boolean
            Try
                Return oDBProfitLossTX.ModificarProfitLoss(oBEProfitLoss)
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
    Public Class clsBC_ProfitLossLoteRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:42:13
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Private oDBProfitLossLoteRO As clsDB_ProfitLossLoteRO
        Public oBEProfitLossLote As clsBE_ProfitLossLote
        Public LstProfitLossLote As New List(Of clsBE_ProfitLossLote)
        Public oDSProfitLossLote As New DataSet
        Public oDTProfitLossLote As New DataTable


        Sub New()
            oDBProfitLossLoteRO = New clsDB_ProfitLossLoteRO
            oBEProfitLossLote = New clsBE_ProfitLossLote
        End Sub

        Public Sub NuevaEntidad()
            oBEProfitLossLote = New clsBE_ProfitLossLote
        End Sub

        '' ''' <summary>
        '' ''' Escrito por: Martin Huaman
        '' ''' Fecha Creacion: 17/02/2011 16:42:13
        '' ''' Proposito: 
        '' ''' Fecha Modificacion:
        '' ''' </summary>
        '' '''
        ''Public Function ProfitLoss_Valida()
        ''    Try
        ''        Return oDBProfitLossRO.ProfitLoss_Valida(oBEProfitLoss)
        ''    Catch ex As Exception
        ''        Throw ex
        ''    End Try
        ''End Function


        Public Sub LeerListaToDSProfitLoss(ByVal sContratoLoteId As String)
            Try
                oDSProfitLossLote = oDBProfitLossLoteRO.LeerListaToDSProfitLoss(sContratoLoteId)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub LeerListaToDSProfitLoss_Sel(ByVal oBE_ProfitLoss As clsBE_ProfitLossLote)
            Try
                oDSProfitLossLote = oDBProfitLossLoteRO.LeerListaToDSProfitLoss_Sel(oBE_ProfitLoss)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub



    End Class
#End Region

End Namespace
