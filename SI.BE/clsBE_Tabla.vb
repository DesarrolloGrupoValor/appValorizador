
Namespace  SI.BE

	''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:44
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
	Public Class clsBE_Tabla
	
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
         ''' Get or Sets the tablaId in Tabla.
         ''' </summary>
		Public Property tablaId() AS String
         ''' <summary>
         ''' Get or Sets the descri in Tabla.
         ''' </summary>
		Public Property descri() AS String
         ''' <summary>
         ''' Get or Sets the codigoEstado in Tabla.
         ''' </summary>
		Public Property codigoEstado() AS String
         ''' <summary>
         ''' Get or Sets the uc in Tabla.
         ''' </summary>
		Public Property uc() AS String
         ''' <summary>
         ''' Get or Sets the fc in Tabla.
         ''' </summary>
		Public Property fc() AS DateTime
         ''' <summary>
         ''' Get or Sets the um in Tabla.
         ''' </summary>
		Public Property um() AS String
         ''' <summary>
         ''' Get or Sets the fm in Tabla.
         ''' </summary>
		Public Property fm() AS DateTime
         ''' <summary>
         ''' Get or Sets the codigoVisible in Tabla.
         ''' </summary>
		Public Property codigoVisible() AS String
		
#End Region
    End Class	
    
End Namespace

