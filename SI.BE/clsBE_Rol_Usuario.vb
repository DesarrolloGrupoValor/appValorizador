
Namespace SI.BE

    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 18/04/2011 14:12:56
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    Public Class clsBE_Rol_Usuario

#Region "Constructor"
        Public Sub New()
            MyBase.New()
        End Sub

#End Region
      
#Region " Declaracion de Miembros "


        'Public Property liquidacionEstadoId() As Integer

        Public Property rolId() As Integer
        'Public Property Rol_UsuarioOrigenId() As Integer

        'Public Property liquidacionId() As String
        'Public Property contratoLoteId() As String

        Public Property usuarioId() As String
        'Public Property estadoId() As String

        'Public Property activo() As String


        'Public Property observaciones() As String

        Public mBE_tbRol_Usuario As ICollection(Of clsBE_Rol_Usuario)

        Public Overridable Property tbRol_Usuario() As ICollection(Of clsBE_Rol_Usuario)
            Get
                Return Me.mBE_tbRol_Usuario
            End Get
            Set(ByVal value As ICollection(Of clsBE_Rol_Usuario))
                Me.mBE_tbRol_Usuario = value
            End Set
        End Property

#End Region
    End Class

End Namespace

