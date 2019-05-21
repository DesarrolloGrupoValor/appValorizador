
Namespace  SI.BE

	''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:44
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
    Public Class clsBE_AuditoriaD

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

        Public Property CadenaConexion() As String

        Public Property IdAuditoria() As Integer
        Public Property IdDetalle() As Integer
        Public Property IdMenu() As String
        Public Property IdAccion() As String
        Public Property Tabla() As String
        Public Property FechaHora() As DateTime
        Public Property NombreObjeto() As String
        'Public Property AuditoriaXml() As String


        Public Property BaseDatos As String
        Public Property Condicion As String
#End Region
    End Class
    
End Namespace

