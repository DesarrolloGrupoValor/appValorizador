Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:45
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_FINANCIANDO_PRELIQTX
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsBC_FINANCIANDO_PRELIQTX
        'Inherits ServicedComponent

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_FINANCIANDO_PRELIQTX
        ''' Fecha Modificacion:
        ''' </summary>

        Private oDBFINANCIANDO_PRELIQTX As clsDB_FINANCIANDO_PRELIQTX
        Public oBEFINANCIANDO_PRELIQ As clsBE_FINANCIANDO_PRELIQ
        Public LstFINANCIANDO_PRELIQ As New List(Of clsBE_FINANCIANDO_PRELIQ)

        Public LstFINANCIANDO_PRELIQ_INSERT As New List(Of clsBE_FINANCIANDO_PRELIQ)
        'Public LstFINANCIANDO_PRELIQ_UPDATE As New List(Of clsBE_FINANCIANDO_PRELIQ)
        Public LstFINANCIANDO_PRELIQ_DELETE As New List(Of clsBE_FINANCIANDO_PRELIQ)

        Public oDSFINANCIANDO_PRELIQ As DataSet

        Sub New()
            oDBFINANCIANDO_PRELIQTX = New clsDB_FINANCIANDO_PRELIQTX
            oBEFINANCIANDO_PRELIQ = New clsBE_FINANCIANDO_PRELIQ
        End Sub

        Public Sub NuevaEntidad()
            oBEFINANCIANDO_PRELIQ = New clsBE_FINANCIANDO_PRELIQ
        End Sub

        Public Function financiando_preliq_INSERT() As Boolean
            Try
                Return oDBFINANCIANDO_PRELIQTX.financiando_preliq_INSERT(LstFINANCIANDO_PRELIQ_INSERT)
            Catch ex As Exception
                'Catch ex As System.Data.SqlClient.SqlException 

                Throw ex
                Return False
            End Try
        End Function


        Public Function financiando_preliq_DELETE() As Integer
            Try
                Return oDBFINANCIANDO_PRELIQTX.financiando_preliq_DELETE(oBEFINANCIANDO_PRELIQ)
            Catch ex As Exception
                Throw ex
                Return 0
            End Try
        End Function

        Public Function financiando_preliq_APLICA() As Integer
            Try
                Return oDBFINANCIANDO_PRELIQTX.financiando_preliq_APLICA(oBEFINANCIANDO_PRELIQ)
            Catch ex As Exception
                Throw ex
                Return 0
            End Try
        End Function


    End Class
#End Region

#Region "Clase Lectura"
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:45
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsBC_FINANCIANDO_PRELIQRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Private oDBFINANCIANDO_PRELIQRO As clsDB_FINANCIANDO_PRELIQRO
        Public oBEFINANCIANDO_PRELIQ As clsBE_FINANCIANDO_PRELIQ
        Public LstFINANCIANDO_PRELIQ As New List(Of clsBE_FINANCIANDO_PRELIQ)
        Public oDSFINANCIANDO_PRELIQ As New DataSet
        Public oDTFINANCIANDO_PRELIQ As New DataTable


        Sub New()
            oDBFINANCIANDO_PRELIQRO = New clsDB_FINANCIANDO_PRELIQRO
            oBEFINANCIANDO_PRELIQ = New clsBE_FINANCIANDO_PRELIQ
        End Sub

        Public Sub NuevaEntidad()
            oBEFINANCIANDO_PRELIQ = New clsBE_FINANCIANDO_PRELIQ
        End Sub

        '' ''' <summary>
        '' ''' Escrito por: Martin Huaman
        '' ''' Fecha Creacion: 17/02/2011 16:58:45
        '' ''' Proposito: 
        '' ''' Fecha Modificacion:
        '' ''' </summary>
        '' '''
        ''Public Sub LeerFINANCIANDO_PRELIQ()
        ''    Try
        ''        oBEFINANCIANDO_PRELIQ = oDBFINANCIANDO_PRELIQRO.LeerFINANCIANDO_PRELIQ(oBEFINANCIANDO_PRELIQ)
        ''    Catch ex As Exception
        ''        Throw ex
        ''    End Try
        ''End Sub

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion:17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''
        Public Sub LeerListaToDSFINANCIANDO_PREAPLICA()
            Try
                oDSFINANCIANDO_PRELIQ = oDBFINANCIANDO_PRELIQRO.LeerListaToDSFINANCIANDO_PREAPLICA(oBEFINANCIANDO_PRELIQ)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function LeerDiasPermitidos()
            Try
                Return oDBFINANCIANDO_PRELIQRO.ObtenerMaximoDiasValidacion()
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function LeerListaToDSFINANCIANDO_PRELIQ_CBT(ByVal nItem As Integer) As String
            Try
                Return oDBFINANCIANDO_PRELIQRO.LeerListaToDSFINANCIANDO_PRELIQ_CBT(nItem)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Sub LeerListaToDSFINANCIANDO_DETALLE()
            Try
                oDSFINANCIANDO_PRELIQ = oDBFINANCIANDO_PRELIQRO.LeerListaToDSFINANCIANDO_DETALLE(oBEFINANCIANDO_PRELIQ)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub


        Public Sub LeerListaFINANCIANDO_PRELIQ()
            Try
                oDSFINANCIANDO_PRELIQ = oDBFINANCIANDO_PRELIQRO.LeerListaToDSFINANCIANDO_PRELIQ(oBEFINANCIANDO_PRELIQ)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub


        Public Function Obtener_Correlativo() As Integer
            Try
                Return oDBFINANCIANDO_PRELIQRO.Obtener_Correlativo()
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        'Public Sub VERIFICA_OP_FINANCIAMIENTO()
        '    Try
        '        oDSFINANCIANDO_PRELIQ = oDBFINANCIANDO_PRELIQRO.VERIFICA_OP_FINANCIAMIENTO()
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Sub

        Public Sub LeerListaToDSFINANCIANDO_PRELIQ_PDF()
            Try
                oDSFINANCIANDO_PRELIQ = oDBFINANCIANDO_PRELIQRO.LeerListaToDSFINANCIANDO_PRELIQ_PDF(oBEFINANCIANDO_PRELIQ)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub


        Public Sub LeerListaToDSFINANCIANDO_SELECCION()
            Try
                oDSFINANCIANDO_PRELIQ = oDBFINANCIANDO_PRELIQRO.LeerListaToDSFINANCIANDO_SELECCION(oBEFINANCIANDO_PRELIQ)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub LeerListaToDSFINANCIANDO()
            Try
                oDSFINANCIANDO_PRELIQ = oDBFINANCIANDO_PRELIQRO.LeerListaToDSFINANCIANDO(oBEFINANCIANDO_PRELIQ)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub


        Public Sub LeerListaToDSAplicados()
            Try
                oDSFINANCIANDO_PRELIQ = oDBFINANCIANDO_PRELIQRO.LeerListaToDSAplicados(oBEFINANCIANDO_PRELIQ)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub


        Public Sub LeerListaToDSFINANCIANDO_CLI()
            Try
                oDSFINANCIANDO_PRELIQ = oDBFINANCIANDO_PRELIQRO.LeerListaToDSFINANCIANDO_CLI(oBEFINANCIANDO_PRELIQ)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        '' ''' <summary>
        '' ''' Escrito por:  Martin Huaman
        '' ''' Fecha Creacion:17/02/2011 16:58:45
        '' ''' Proposito: 
        '' ''' Fecha Modificacion:
        '' ''' </summary>
        '' '''
        ''Public Function LeerListaToDSFINANCIANDO_PRELIQ() As DataSet
        ''    Try
        ''        oDSFINANCIANDO_PRELIQ = oDBFINANCIANDO_PRELIQRO.LeerListaToDSFINANCIANDO_PRELIQ(oBEFINANCIANDO_PRELIQ)
        ''        Return oDSFINANCIANDO_PRELIQ
        ''    Catch ex As Exception
        ''        Throw ex
        ''    End Try
        ''End Function
        '' ''' <summary>
        '' ''' Escrito por:  Martin Huaman
        '' ''' Fecha Creacion:17/02/2011 16:58:45
        '' ''' Proposito: 
        '' ''' Fecha Modificacion:
        '' ''' </summary>
        '' '''
        ''Public Function DefinirFINANCIANDO_PRELIQFINANCIANDO_PRELIQ() As DataTable
        ''    Try
        ''        oDTFINANCIANDO_PRELIQ = oDBFINANCIANDO_PRELIQRO.DefinirFINANCIANDO_PRELIQFINANCIANDO_PRELIQ()
        ''        Return oDTFINANCIANDO_PRELIQ
        ''    Catch ex As Exception
        ''        Throw ex
        ''    End Try
        ''End Function

    End Class
#End Region

End Namespace
