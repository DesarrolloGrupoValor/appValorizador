Imports SI.DB
Imports SI.BE

Namespace SI.BC
    Public Class clsBC_TB_FJ_APLICACIONTX

        Private oDBTB_FJ_APLICACIONTX As clsDB_TB_FJ_APLICACIONTX
        Public oBETB_FJ_APLICACION As clsBE_TB_FJ_APLICACION
        Public LstTB_FJ_APLICACION As New List(Of clsBE_TB_FJ_APLICACION)
        Public oDSTB_FJ_APLICACION As DataSet

        Sub New()
            oDBTB_FJ_APLICACIONTX = New clsDB_TB_FJ_APLICACIONTX
            oBETB_FJ_APLICACION = New clsBE_TB_FJ_APLICACION
        End Sub

        Public Sub NuevaEntidad()
            oBETB_FJ_APLICACION = New clsBE_TB_FJ_APLICACION
        End Sub

        Public LstTB_FJ_APLICACIONUpd As New List(Of clsBE_TB_FJ_APLICACION)
        Public LstTB_FJ_APLICACIONDel As New List(Of clsBE_TB_FJ_APLICACION)
        Public LstTB_FJ_APLICACIONIns As New List(Of clsBE_TB_FJ_APLICACION)
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 07/12/2010 14:46:15
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function InsertarLiquidacion() As Boolean
            Try
                If LstTB_FJ_APLICACIONIns.Count = 0 Then LstTB_FJ_APLICACIONIns = LstTB_FJ_APLICACION
                Return oDBTB_FJ_APLICACIONTX.InsertarTB_FJ_APLICACION(LstTB_FJ_APLICACIONIns)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 07/12/2010 14:46:15
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function ModificarLiquidacion() As Boolean
            Try
                If LstTB_FJ_APLICACIONUpd.Count = 0 Then LstTB_FJ_APLICACIONUpd = LstTB_FJ_APLICACION
                Return oDBTB_FJ_APLICACIONTX.ModificarTB_FJ_APLICACION(LstTB_FJ_APLICACIONUpd)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 07/12/2010 14:46:15
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function EliminarLiquidacion() As Boolean
            Try
                If LstTB_FJ_APLICACIONDel.Count = 0 Then LstTB_FJ_APLICACIONDel = LstTB_FJ_APLICACION
                Return oDBTB_FJ_APLICACIONTX.EliminarTB_FJ_APLICACION(LstTB_FJ_APLICACIONDel)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function
    End Class


    Public Class clsBC_TB_FJ_APLICACIONRO

        Private oDBTB_FJ_APLICACIONRO As clsDB_TB_FJ_APLICACIONRO
        Public oBETB_FJ_APLICACION As clsBE_TB_FJ_APLICACION
        Public LstTB_FJ_APLICACION As New List(Of clsBE_TB_FJ_APLICACION)
        Public oDSTB_FJ_APLICACION As New DataSet
        Public oDTTB_FJ_APLICACION As New DataTable


        Sub New()
            oDBTB_FJ_APLICACIONRO = New clsDB_TB_FJ_APLICACIONRO
            oBETB_FJ_APLICACION = New clsBE_TB_FJ_APLICACION
        End Sub

        Public Sub NuevaEntidad()
            oBETB_FJ_APLICACION = New clsBE_TB_FJ_APLICACION
        End Sub



        '' ''' <summary>
        '' ''' Escrito por:  Martin Huaman
        '' ''' Fecha Creacion:17/02/2011 16:58:18
        '' ''' Proposito: 
        '' ''' Fecha Modificacion:
        '' ''' </summary>
        '' '''
        ''Public Function LeerListaToDSLiquidacion() As DataSet
        ''    Try
        ''        oDSTB_FJ_APLICACION = oDBTB_FJ_APLICACIONRO.LeerListaToDSLiquidacion(oBETB_FJ_APLICACION)

        ''        Return oDSTB_FJ_APLICACION
        ''    Catch ex As Exception
        ''        Throw ex
        ''    End Try
        ''End Function

        ''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:58:18
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function DefineTablaTB_FJ_APLICACION() As DataTable
            Try
                oDTTB_FJ_APLICACION = oDBTB_FJ_APLICACIONRO.DefineTablaFJ_APLICACION()
                Return oDTTB_FJ_APLICACION
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

End Namespace
