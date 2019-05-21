Imports SI.BE

Namespace SI.BC
    Partial Public Class clsBC_ValorizadorPenalizableTX
        Public LstValorizadorPenalizableUpd As New List(Of clsBE_ValorizadorPenalizable)
        Public LstValorizadorPenalizableDel As New List(Of clsBE_ValorizadorPenalizable)
        Public LstValorizadorPenalizableIns As New List(Of clsBE_ValorizadorPenalizable)
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 07/12/2010 14:46:24
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function InsertarPenalizable() As Boolean
            Try
                If LstValorizadorPenalizableIns.Count = 0 Then LstValorizadorPenalizableIns = LstValorizadorPenalizable
                Return oDBValorizadorPenalizableTX.InsertarPenalizable(LstValorizadorPenalizableIns)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 07/12/2010 14:46:24
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function ModificarPenalizable() As Boolean
            Try
                If LstValorizadorPenalizableUpd.Count = 0 Then LstValorizadorPenalizableUpd = LstValorizadorPenalizable
                Return oDBValorizadorPenalizableTX.ModificarValorizadorPenalizable(LstValorizadorPenalizableUpd)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 07/12/2010 14:46:24
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function EliminarPenalizable() As Boolean
            Try
                If LstValorizadorPenalizableDel.Count = 0 Then LstValorizadorPenalizableDel = LstValorizadorPenalizable
                Return oDBValorizadorPenalizableTX.EliminarValorizadorPenalizable(LstValorizadorPenalizableDel)
            Catch ex As Exception
                Throw ex
                Return False
            End Try
        End Function
    End Class

    Partial Public Class clsBC_ValorizadorPenalizableRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 07/12/2010 14:46:15
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Sub LeerPenalizableCorrelativo()
            Try
                oBEValorizadorPenalizable = oDBValorizadorPenalizableRO.LeerPenalizableCorrelativo(oBEValorizadorPenalizable)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        ''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 17:00:51
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function LeerListaToDSPenalizable() As DataSet
            Try
                oDSValorizadorPenalizable = oDBValorizadorPenalizableRO.LeerListaToDSPenalizable(oBEValorizadorPenalizable)
                Return oDSValorizadorPenalizable
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
