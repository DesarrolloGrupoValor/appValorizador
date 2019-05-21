Imports SI.BE
Imports SI.DB

Namespace SI.BC
  

    Partial Public Class clsBC_TB_FJ_FIJACIONTX

        Private oDBTB_FJ_FIJACIONTX As clsDB_TB_FJ_FIJACIONTX
        Public oBETB_FJ_FIJACION As clsBE_TB_FJ_FIJACION
        Public LstTB_FJ_FIJACION As New List(Of clsBE_TB_FJ_FIJACION)

        Public LstTB_FJ_FIJACION_INSERT As New List(Of clsBE_TB_FJ_FIJACION)
        'Public LstTB_FJ_FIJACION_UPDATE As New List(Of clsBE_TB_FJ_FIJACION)

        Public oDSTB_FJ_FIJACION As DataSet

        Sub New()
            oDBTB_FJ_FIJACIONTX = New clsDB_TB_FJ_FIJACIONTX
            oBETB_FJ_FIJACION = New clsBE_TB_FJ_FIJACION
        End Sub

        Public Sub NuevaEntidad()
            oBETB_FJ_FIJACION = New clsBE_TB_FJ_FIJACION
        End Sub


        Public Function TB_FJ_FIJACION_INSERT() As Boolean
            Try
                Return oDBTB_FJ_FIJACIONTX.TB_FJ_FIJACION_INSERT(LstTB_FJ_FIJACION_INSERT)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function

        Public Function TB_FJ_FIJACION_UPDATE() As Boolean
            Try
                Return oDBTB_FJ_FIJACIONTX.TB_FJ_FIJACION_UPDATE(LstTB_FJ_FIJACION_INSERT)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function

    End Class



    Partial Public Class clsBC_TB_FJ_FIJACIONRO

        Private oDBTB_FJ_FIJACIONRO As clsDB_TB_FJ_FIJACIONRO
        Public oBETB_FJ_FIJACION, oBETB_FJ_FIJACIOn2 As clsBE_TB_FJ_FIJACION

        Public LstTB_FJ_FIJACION As New List(Of clsBE_TB_FJ_FIJACION)
        Public oDSTB_FJ_FIJACION, oDSTB_FJ_FIJACION2 As New DataSet
        Public oDTTB_FJ_FIJACION, oDTTB_FJ_FIJACION2 As New DataTable


        Sub New()
            oDBTB_FJ_FIJACIONRO = New clsDB_TB_FJ_FIJACIONRO
            oBETB_FJ_FIJACION = New clsBE_TB_FJ_FIJACION
            oBETB_FJ_FIJACION2 = New clsBE_TB_FJ_FIJACION
        End Sub

        Public Sub NuevaEntidad()
            oBETB_FJ_FIJACION = New clsBE_TB_FJ_FIJACION
            oBETB_FJ_FIJACION2 = New clsBE_TB_FJ_FIJACION
        End Sub

        ''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 17:00:37
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function LeerListaToDSTB_FJ_FIJACION_Sel_Prov() As DataSet
            Try
                oDSTB_FJ_FIJACION = oDBTB_FJ_FIJACIONRO.LeerListaToDSTB_FJ_FIJACION_Sel_Prov(oBETB_FJ_FIJACION)
                Return oDSTB_FJ_FIJACION
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDSTB_FJ_FIJACION_Sel() As DataSet
            Try
                oDSTB_FJ_FIJACION = oDBTB_FJ_FIJACIONRO.LeerListaToDSTB_FJ_FIJACION_Sel(oBETB_FJ_FIJACION)
                Return oDSTB_FJ_FIJACION
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function Leer_FJ_AJUSTE_ESCALA() As Decimal
            Try
                Return oDBTB_FJ_FIJACIONRO.Leer_FJ_AJUSTE_ESCALA(oBETB_FJ_FIJACION)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
      
    End Class
End Namespace
