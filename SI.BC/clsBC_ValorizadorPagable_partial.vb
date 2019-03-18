Imports SI.BE

Namespace SI.BC
  

    Partial Public Class clsBC_ValorizadorPagableTX
        Public LstValorizadorPagableUpd As New List(Of clsBE_ValorizadorPagable)
        Public LstValorizadorPagableDel As New List(Of clsBE_ValorizadorPagable)
        Public LstValorizadorPagableIns As New List(Of clsBE_ValorizadorPagable)
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 07/12/2010 14:46:15
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function InsertarPagable() As Boolean
            Try
                Return oDBValorizadorPagableTX.InsertarPagable(LstValorizadorPagableIns)
                'If LstValorizadorPagableIns.Count = 0 Then LstValorizadorPagableIns = LstValorizadorPagable
                'Return oDBValorizadorPagableTX.InsertarPagable(LstValorizadorPagableIns)
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

        Public Function ModificarPagable() As Boolean
            Try
                If LstValorizadorPagableUpd.Count = 0 Then LstValorizadorPagableUpd = LstValorizadorPagable
                Return oDBValorizadorPagableTX.ModificarValorizadorPagable(LstValorizadorPagableUpd)
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

        Public Function EliminarPagable() As Boolean
            Try
                'If LstValorizadorPagableDel.Count > 0 Then 'Then LstValorizadorPagableDel = LstValorizadorPagable
                '    Return oDBValorizadorPagableTX.EliminarValorizadorPagable(LstValorizadorPagableDel)
                'End If
                Return oDBValorizadorPagableTX.EliminarValorizadorPagable(LstValorizadorPagableDel)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function
    End Class

    Partial Public Class clsBC_ValorizadorPagableRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 07/12/2010 14:46:15
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Sub LeerPagableCorrelativo()
            Try
                oBEValorizadorPagable = oDBValorizadorPagableRO.LeerPagableCorrelativo(oBEValorizadorPagable)
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
        Public Function LeerListaToDSPagable() As DataSet
            Try
                oDSValorizadorPagable = oDBValorizadorPagableRO.LeerListaToDSPagable(oBEValorizadorPagable)
                Return oDSValorizadorPagable
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
        Public Function DefineTablaValorizadorPagable() As DataTable
            Try
                oDTValorizadorPagable = oDBValorizadorPagableRO.DefineTablaValorizadorPagable()
                Return oDTValorizadorPagable
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
