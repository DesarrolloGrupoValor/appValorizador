
Namespace  SI.BE

	''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:33
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
	Public Class clsBE_Periodo
	
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
         ''' Get or Sets the periodoId in Periodo.
         ''' </summary>
		Public Property periodoId() AS String
         ''' <summary>
         ''' Get or Sets the periodo in Periodo.
         ''' </summary>
		Public Property periodo() AS String
         ''' <summary>
         ''' Get or Sets the codigoCerrado in Periodo.
         ''' </summary>
		Public Property codigoCerrado() AS String
         ''' <summary>
         ''' Get or Sets the codigoEstado in Periodo.
         ''' </summary>
		Public Property codigoEstado() AS String
         ''' <summary>
         ''' Get or Sets the uc in Periodo.
         ''' </summary>
		Public Property uc() AS String
         ''' <summary>
         ''' Get or Sets the fc in Periodo.
         ''' </summary>
		Public Property fc() AS DateTime
         ''' <summary>
         ''' Get or Sets the um in Periodo.
         ''' </summary>
		Public Property um() AS String
         ''' <summary>
         ''' Get or Sets the fm in Periodo.
         ''' </summary>
		Public Property fm() AS DateTime
		
#End Region
    End Class	
    
End Namespace

