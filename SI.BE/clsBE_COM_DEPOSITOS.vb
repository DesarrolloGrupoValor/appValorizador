
Namespace  SI.BE

	''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:44
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
    Public Class clsBE_COM_DEPOSITOS

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
        ''' Get or Sets the COD_DEPOSITO in COM_DEPOSITOS.
        ''' </summary>
        Public Property COD_DEPOSITO() As String
        ''' <summary>
        ''' Get or Sets the NOM_DEPOSITO in COM_DEPOSITOS.
        ''' </summary>
        Public Property NOM_DEPOSITO() As String
        ''' <summary>
        ''' Get or Sets the EMPRESA in COM_DEPOSITOS.
        ''' </summary>
        Public Property EMPRESA() As String
        ''' <summary>
        ''' Get or Sets the LOCALIDAD in COM_DEPOSITOS.
        ''' </summary>
        Public Property LOCALIDAD() As String
        ''' <summary>
        ''' Get or Sets the DIRECCION in COM_DEPOSITOS.
        ''' </summary>
        Public Property DIRECCION() As String
        ''' <summary>
        ''' Get or Sets the DESC_ABREV_DEP in COM_DEPOSITOS.
        ''' </summary>
        Public Property DESC_ABREV_DEP() As String
        ''' <summary>
        ''' Get or Sets the FECHA_REG_DEP in COM_DEPOSITOS.
        ''' </summary>
        Public Property FECHA_REG_DEP() As DateTime
        ''' <summary>
        ''' Get or Sets the ID_LOCALIDAD in COM_DEPOSITOS.
        ''' </summary>
        Public Property ID_LOCALIDAD() As String
        ''' <summary>
        ''' Get or Sets the DES_LOCALIDAD in COM_DEPOSITOS.
        ''' </summary>
        Public Property DES_LOCALIDAD() As String

#End Region
    End Class
    
End Namespace

