
Namespace  SI.BE

	''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:38:33
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
	Public Class clsBE_Contabilidad
	
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
         ''' Get or Sets the contabilidadId in Contabilidad.
         ''' </summary>
		Public Property contabilidadId() AS String
         ''' <summary>
         ''' Get or Sets the periodo in Contabilidad.
         ''' </summary>
		Public Property periodo() AS String
         ''' <summary>
         ''' Get or Sets the codigoEstado in Contabilidad.
         ''' </summary>
		Public Property codigoEstado() AS String
         ''' <summary>
         ''' Get or Sets the uc in Contabilidad.
         ''' </summary>
		Public Property uc() AS String
         ''' <summary>
         ''' Get or Sets the fc in Contabilidad.
         ''' </summary>
		Public Property fc() AS DateTime
         ''' <summary>
         ''' Get or Sets the um in Contabilidad.
         ''' </summary>
		Public Property um() AS String
         ''' <summary>
         ''' Get or Sets the fm in Contabilidad.
         ''' </summary>
		Public Property fm() AS DateTime
         ''' <summary>
         ''' Get or Sets the codigoDiario in Contabilidad.
         ''' </summary>
		Public Property codigoDiario() AS String
         ''' <summary>
         ''' Get or Sets the codigoTransferido in Contabilidad.
         ''' </summary>
		Public Property codigoTransferido() AS String
         ''' <summary>
         ''' Get or Sets the codigoEmpresa in Contabilidad.
         ''' </summary>
		Public Property codigoEmpresa() AS String
         ''' <summary>
         ''' Get or Sets the fecha in Contabilidad.
         ''' </summary>
		Public Property fecha() AS DateTime
		
#End Region
    End Class	
    
End Namespace

