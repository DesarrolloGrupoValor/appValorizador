Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:45
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_AuditoriaCTX
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsBC_AuditoriaCTX
        'Inherits ServicedComponent

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_AuditoriaCTX
        ''' Fecha Modificacion:
        ''' </summary>

        Private oDBAuditoriaCTX As clsDB_AuditoriaCTX
        Public oBEAuditoriaC As clsBE_AuditoriaC
        Public LstAuditoriaC As New List(Of clsBE_AuditoriaC)
        Public oDSAuditoriaC As DataSet

        Sub New()
            oDBAuditoriaCTX = New clsDB_AuditoriaCTX
            oBEAuditoriaC = New clsBE_AuditoriaC
        End Sub

        Public Sub NuevaEntidad()
            oBEAuditoriaC = New clsBE_AuditoriaC
        End Sub

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function InsertarAuditoriaC() As Integer
            Try
                Return oDBAuditoriaCTX.InsertarAuditoriaC(LstAuditoriaC)
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
    ''' Fecha Creacion: 17/02/2011 16:58:45
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <Serializable()> _
    Public Class clsBC_AuditoriaCRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Private oDBAuditoriaCRO As clsDB_AuditoriaRO
        Public oBEAuditoriaC As clsBE_AuditoriaC
        Public LstAuditoriaC As New List(Of clsBE_AuditoriaC)
        Public oDSAuditoriaC As New DataSet
        Public oDTAuditoriaC As New DataTable


        Sub New()
            oDBAuditoriaCRO = New clsDB_AuditoriaRO
            oBEAuditoriaC = New clsBE_AuditoriaC
        End Sub

        Public Sub NuevaEntidad()
            oBEAuditoriaC = New clsBE_AuditoriaC
        End Sub



    End Class
#End Region

End Namespace
