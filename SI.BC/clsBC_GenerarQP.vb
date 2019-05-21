Imports SI.BE
Imports SI.DB

Namespace SI.BC
    Public Class clsBC_GenerarQPRO


        Private oDBGenerarQPRO As clsDB_GenerarQPRO
        'Public oBEGestionComercial As clsBE_GestionComercial
        'Public LstGestionComercial As New List(Of clsBE_GestionComercial)
        Public oDSGenerarQP As New DataSet
        Public oDTGenerarQP As New DataTable


        Sub New()
            oDBGenerarQPRO = New clsDB_GenerarQPRO
            'oBEGestionComercial = New clsBE_GestionComercial
        End Sub

        'Public Sub NuevaEntidad()
        '    oBEGestionComercial = New clsBE_GestionComercial
        'End Sub


        'Public Function fnCalcular_QPs_Detalle(ByVal sPeriodo As String) As DataSet
        '    Return oDBGenerarQPRO.fnCalcular_QPs_Detalle(sPeriodo)
        'End Function

        Public Function fnCalcular_QPs(ByVal sPeriodo As String) As DataSet
            Return oDBGenerarQPRO.fnCalcular_QPs(sPeriodo)
        End Function

        Public Function fnGenerarQP_SellAll(Optional ByVal sPeriodo As String = "") As DataSet
            Return oDBGenerarQPRO.fnGenerarQP_SellAll(sPeriodo)
        End Function

        Public Function fnGenerarQP_Detalle_Sell(ByVal sPeriodo As String, ByVal sVinculada As String) As DataSet
            Return oDBGenerarQPRO.fnGenerarQP_Detalle_Sell(sPeriodo, sVinculada)
        End Function

    End Class


    Public Class clsBC_GenerarQPTX
        Private oDBGenerarQPTX As New clsDB_GenerarQPTX

        'Public Function InsertarGenerarQP(ByVal sPeriodo As String) As Boolean
        '    Return oDBGenerarQPTX.InsertarGenerarQP(sPeriodo)
        'End Function

        Public Function fnCalcular_QPs(ByVal sPeriodo As String) As Boolean
            Return oDBGenerarQPTX.fnCalcular_QPs(sPeriodo)
        End Function

    End Class

End Namespace
