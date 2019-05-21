
Namespace  SI.BE

	''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:44
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
    Public Class clsBE_AuditoriaC

#Region "Constructor"
        Public Sub New()
            MyBase.New()
        End Sub

#End Region
        ''' <summary>
        ''' Miembros privados de la entidad.
        ''' </summary>
        ''' <remarks></remarks>
#Region " Declaracion de Miembros "
        Public Item As Integer

        Public Property IdAuditoria() As Integer 
        Public Property IdModulo() As Integer
        Public Property IdUsuario() As String
        Public Property NombrePC() As String
        Public Property UsuarioWin() As String
        Public Property UsuarioIp() As String

#End Region
    End Class
    
End Namespace

