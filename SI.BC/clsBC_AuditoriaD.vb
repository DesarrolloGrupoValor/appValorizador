Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports SI.BE
Imports SI.DB

Namespace SI.BC

#Region "Clase Escritura"
	
    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:45
    ''' Proposito: Ejecutar los metodos de la capa de datos clsDB_AuditoriaDTX
    ''' Fecha Modificacion:
    ''' </summary>
    '''

    Public Class clsBC_AuditoriaDTX
        'Inherits ServicedComponent

        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: Ejecuta los metodos transaccionales de la clase clsDB_AuditoriaDTX
        ''' Fecha Modificacion:
        ''' </summary>

        Private oDBAuditoriaDTX As clsDB_AuditoriaDTX
        Public oBEAuditoriaD As clsBE_AuditoriaD
        Public LstAuditoriaD As New List(Of clsBE_AuditoriaD)
        Public oDSAuditoriaD As DataSet

        Sub New()
            oDBAuditoriaDTX = New clsDB_AuditoriaDTX
            oBEAuditoriaD = New clsBE_AuditoriaD
        End Sub

        Public Sub NuevaEntidad()
            oBEAuditoriaD = New clsBE_AuditoriaD
        End Sub

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por:Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Public Function InsertarAuditoriaD() As Boolean
            Try
                Return oDBAuditoriaDTX.InsertarAuditoriaD(LstAuditoriaD)
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
    Public Class clsBC_AuditoriaDRO
        ''' <summary>
        ''' Escrito por: Martin Huaman
        ''' Fecha Creacion: 17/02/2011 16:58:45
        ''' Proposito: 
        ''' Fecha Modificacion:
        ''' </summary>
        '''

        Private oDBAuditoriaDRO As clsDB_AuditoriaDRO
        Public oBEAuditoriaD As clsBE_AuditoriaD
        Public LstAuditoriaD As New List(Of clsBE_AuditoriaD)
        Public oDSAuditoriaD As New DataSet
        Public oDTAuditoriaD As New DataTable


        Sub New()
            oDBAuditoriaDRO = New clsDB_AuditoriaDRO
            oBEAuditoriaD = New clsBE_AuditoriaD
        End Sub

        Public Sub NuevaEntidad()
            oBEAuditoriaD = New clsBE_AuditoriaD
        End Sub



    End Class
#End Region

End Namespace
