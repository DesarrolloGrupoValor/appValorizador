Imports SI.BE
Imports SI.DB

Namespace SI.BC
  

    Partial Public Class clsBC_TB_DIG_INDICETX

        Private oDBTB_DIG_INDICETX As clsDB_TB_DIG_INDICETX
        Public oBETB_DIG_INDICE As clsBE_TB_DIG_INDICE
        Public LstTB_DIG_INDICE As New List(Of clsBE_TB_DIG_INDICE)

        Public LstTB_DIG_INDICE_INSERT As New List(Of clsBE_TB_DIG_INDICE)
        Public LstTB_DIG_INDICE_UPDATE As New List(Of clsBE_TB_DIG_INDICE)
        Public LstTB_DIG_INDICE_ASOCIA As New List(Of clsBE_TB_DIG_INDICE)

        Public oDSTB_DIG_INDICE As DataSet

        Sub New()
            oDBTB_DIG_INDICETX = New clsDB_TB_DIG_INDICETX
            oBETB_DIG_INDICE = New clsBE_TB_DIG_INDICE
        End Sub

        Public Sub NuevaEntidad()
            oBETB_DIG_INDICE = New clsBE_TB_DIG_INDICE
        End Sub




        Public Function TB_DIG_INDICE_UPDATE() As Boolean
            Try
                Return oDBTB_DIG_INDICETX.TB_DIG_INDICE_UPDATE(LstTB_DIG_INDICE_UPDATE)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function

        Public Function TB_DIG_INDICE_INSERT() As Boolean
            Try
                Return oDBTB_DIG_INDICETX.TB_DIG_INDICE_INSERT(LstTB_DIG_INDICE_INSERT)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function

        Public Function TB_DIG_INDICE_ASOCIA() As Boolean
            Try
                Return oDBTB_DIG_INDICETX.TB_DIG_INDICE_ASOCIA(LstTB_DIG_INDICE_ASOCIA)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function

    End Class



    Partial Public Class clsBC_TB_DIG_INDICERO


        Private oDBTB_DIG_INDICERO As clsDB_TB_DIG_INDICERO
        Public oBETB_DIG_INDICE As clsBE_TB_DIG_INDICE

        Public LstTB_DIG_INDICE As New List(Of clsBE_TB_DIG_INDICE)
        Public oDSTB_DIG_INDICE As New DataSet
        Public oDTTB_DIG_INDICE As New DataTable


        Sub New()
            oDBTB_DIG_INDICERO = New clsDB_TB_DIG_INDICERO
            oBETB_DIG_INDICE = New clsBE_TB_DIG_INDICE

        End Sub

        Public Sub NuevaEntidad()
            oBETB_DIG_INDICE = New clsBE_TB_DIG_INDICE
        End Sub

        Public Function LeerListaToDSTB_DIG_INDICE_Sel(ByVal nIDITEM As Integer) As DataSet
            Try
                oDSTB_DIG_INDICE = oDBTB_DIG_INDICERO.LeerListaToDSTB_DIG_INDICE_Sel(nIDITEM)
                Return oDSTB_DIG_INDICE
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDSTB_DIG_INDICE_Sel_Archivo(ByVal sContratoLoteId As String) As DataSet
            Try
                oDSTB_DIG_INDICE = oDBTB_DIG_INDICERO.LeerListaToDSTB_DIG_INDICE_Sel_Archivo(sContratoLoteId)
                Return oDSTB_DIG_INDICE
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function LeerListaToDSTB_DIG_INDICE_Sel_ASO(ByVal sIDTIPODOC_DIG As String, ByVal sEMPRESA As String, ByVal SPROVEEDOR As String, ByVal sContratoLoteId As String, ByVal sLiquidacionId As String) As DataSet
            Try
                oDSTB_DIG_INDICE = oDBTB_DIG_INDICERO.LeerListaToDSTB_DIG_INDICE_Sel_ASO(sIDTIPODOC_DIG, sEMPRESA, SPROVEEDOR, sContratoLoteId, sLiquidacionId)
                Return oDSTB_DIG_INDICE
            Catch ex As Exception
                Throw ex
            End Try
        End Function
       

    End Class

End Namespace
