
Namespace  SI.BE

	''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:44
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
    Public Class clsBE_PUB_PERSONAS

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

        ''' <summary>
        ''' Get or Sets the COD_DEPOSITO in PUB_PERSONAS.
        ''' </summary>
        Public Property IDPERSONA() As String
        ''' <summary>
        ''' Get or Sets the NOM_DEPOSITO in PUB_PERSONAS.
        ''' </summary>
        Public Property RAZON_SOCIAL() As String        
        ''' <summary>
        ''' Get or Sets the LOCALIDAD in PUB_PERSONAS.
        ''' </summary>
        Public Property DIRECCION() As String
        ''' <summary>
        ''' Get or Sets the DIRECCION in PUB_PERSONAS.
        ''' </summary>
        Public Property CONTACTO() As String
        ''' <summary>
        ''' Get or Sets the DESC_ABREV_DEP in PUB_PERSONAS.
        ''' </summary>
        Public Property CELULAR1() As String
        ''' <summary>
        ''' Get or Sets the FECHA_REG_DEP in PUB_PERSONAS.
        ''' </summary>
        Public Property CORREO() As String
       

#End Region
    End Class
    
End Namespace

