Imports SI.BE
Imports SI.DB

Namespace SI.BC
  

    Partial Public Class clsBC_FINANCIANDO_CLITX
        Public LstFINANCIANDO_CLIUpd As New List(Of clsBE_FINANCIANDO_CLI)
        Public LstFINANCIANDO_CLIDel As New List(Of clsBE_FINANCIANDO_CLI)
        Public LstFINANCIANDO_CLIIns As New List(Of clsBE_FINANCIANDO_CLI)

    End Class



    Partial Public Class clsBC_FINANCIANDO_CLIRO


        Private oDBFINANCIANDO_CLIRO As clsDB_FINANCIANDO_CLIRO
        Public oBEFINANCIANDO_CLI As clsBE_FINANCIANDO_CLI

        Public LstFINANCIANDO_CLI As New List(Of clsBE_FINANCIANDO_CLI)
        Public oDSFINANCIANDO_CLI As New DataSet
        Public oDSPRESTAMO_CCH As New DataSet
        Public oDSPRESTAMO_COM As New DataSet
        Public oDTFINANCIANDO_CLI As New DataTable


        Sub New()
            oDBFINANCIANDO_CLIRO = New clsDB_FINANCIANDO_CLIRO
            oBEFINANCIANDO_CLI = New clsBE_FINANCIANDO_CLI

        End Sub

        Public Sub NuevaEntidad()
            oBEFINANCIANDO_CLI = New clsBE_FINANCIANDO_CLI

        End Sub

      
        ''' <summary>
        ''' Escrito por:  Martin Huaman
        ''' Fecha Creacion:17/02/2011 17:00:37
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Function LeerListaToDSFINANCIANDO_CLI() As DataSet
            Try
                oDSFINANCIANDO_CLI = oDBFINANCIANDO_CLIRO.LeerListaToDSFINANCIANDO_CLI(oBEFINANCIANDO_CLI)
                Return oDSFINANCIANDO_CLI
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDSPRESTAMO_CCH() As DataSet
            Try
                oDSPRESTAMO_CCH = oDBFINANCIANDO_CLIRO.LeerListaToDSPRESTAMO_CCH(oBEFINANCIANDO_CLI)
                Return oDSPRESTAMO_CCH
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDSPRESTAMO_COM() As DataSet
            Try
                oDSPRESTAMO_COM = oDBFINANCIANDO_CLIRO.LeerListaToDSPRESTAMO_COM(oBEFINANCIANDO_CLI)
                Return oDSPRESTAMO_COM
            Catch ex As Exception
                Throw ex
            End Try
        End Function

       
    End Class
End Namespace
