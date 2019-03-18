Imports SI.BE
Imports SI.DB

Namespace SI.BC
  

    Partial Public Class clsBC_TB_DESCUENTOS_LIQTX
        
        Private oDBTB_DESCUENTOS_LIQTX As clsDB_TB_DESCUENTOS_LIQTX
        Public oBETB_DESCUENTOS_LIQ As clsBE_TB_DESCUENTOS_LIQ
        Public LstTB_DESCUENTOS_LIQ As New List(Of clsBE_TB_DESCUENTOS_LIQ)

        Public LstTB_DESCUENTOS_LIQ_INSERT As New List(Of clsBE_TB_DESCUENTOS_LIQ)
        'Public LstTB_DESCUENTOS_LIQ_UPDATE As New List(Of clsBE_TB_DESCUENTOS_LIQ)

        Public oDSTB_DESCUENTOS_LIQ As DataSet

        Sub New()
            oDBTB_DESCUENTOS_LIQTX = New clsDB_TB_DESCUENTOS_LIQTX
            oBETB_DESCUENTOS_LIQ = New clsBE_TB_DESCUENTOS_LIQ
        End Sub

        Public Sub NuevaEntidad()
            oBETB_DESCUENTOS_LIQ = New clsBE_TB_DESCUENTOS_LIQ
        End Sub




        Public Function TB_DESCUENTOS_LIQ_INSERT() As Boolean
            Try
                Return oDBTB_DESCUENTOS_LIQTX.TB_DESCUENTOS_LIQ_INSERT(LstTB_DESCUENTOS_LIQ_INSERT)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function

        Public Function TB_DESCUENTOS_LIQ_UPDATE() As Boolean
            Try
                Return oDBTB_DESCUENTOS_LIQTX.TB_DESCUENTOS_LIQ_UPDATE(LstTB_DESCUENTOS_LIQ_INSERT)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function

    End Class



    Partial Public Class clsBC_TB_DESCUENTOS_LIQRO


        Private oDBTB_DESCUENTOS_LIQRO As clsDB_TB_DESCUENTOS_LIQRO
        Public oBETB_DESCUENTOS_LIQ As clsBE_TB_DESCUENTOS_LIQ

        Public LstTB_DESCUENTOS_LIQ As New List(Of clsBE_TB_DESCUENTOS_LIQ)
        Public oDSTB_DESCUENTOS_LIQ As New DataSet
        Public oDTTB_DESCUENTOS_LIQ As New DataTable


        Sub New()
            oDBTB_DESCUENTOS_LIQRO = New clsDB_TB_DESCUENTOS_LIQRO
            oBETB_DESCUENTOS_LIQ = New clsBE_TB_DESCUENTOS_LIQ

        End Sub

        Public Sub NuevaEntidad()
            oBETB_DESCUENTOS_LIQ = New clsBE_TB_DESCUENTOS_LIQ

        End Sub

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 07/12/2010 14:46:15
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Sub LeerPagableCorrelativo()
            Try
                oBETB_DESCUENTOS_LIQ = oDBTB_DESCUENTOS_LIQRO.LeerPagableCorrelativo(oBETB_DESCUENTOS_LIQ)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        ''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 17:00:37
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function LeerListaToDSTB_DESCUENTOS_LIQ() As DataSet
            Try
                oDSTB_DESCUENTOS_LIQ = oDBTB_DESCUENTOS_LIQRO.LeerListaToDSTB_DESCUENTOS_LIQ(oBETB_DESCUENTOS_LIQ)
                Return oDSTB_DESCUENTOS_LIQ
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:11/03/2011 17:53:28
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function DefineTablaTB_DESCUENTOS_LIQ() As DataTable
            Try
                oDTTB_DESCUENTOS_LIQ = oDBTB_DESCUENTOS_LIQRO.DefineTablaTB_DESCUENTOS_LIQ()
                Return oDTTB_DESCUENTOS_LIQ
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
