
Namespace  SI.BE

	''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:38:22
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
	Public Class clsBE_ConfiguracionContable
	
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
         ''' Get or Sets the configuracionId in ConfiguracionContable.
         ''' </summary>
		Public Property configuracionId() AS String
         ''' <summary>
         ''' Get or Sets the codigoContableMercaderia in ConfiguracionContable.
         ''' </summary>
		Public Property codigoContableMercaderia() AS String
         ''' <summary>
         ''' Get or Sets the codigoContableServicio in ConfiguracionContable.
         ''' </summary>
		Public Property codigoContableServicio() AS String
         ''' <summary>
         ''' Get or Sets the codigoContableVariacion in ConfiguracionContable.
         ''' </summary>
		Public Property codigoContableVariacion() AS String
         ''' <summary>
         ''' Get or Sets the codigoContableCompra in ConfiguracionContable.
         ''' </summary>
		Public Property codigoContableCompra() AS String
         ''' <summary>
         ''' Get or Sets the codigoContableImpuesto in ConfiguracionContable.
         ''' </summary>
		Public Property codigoContableImpuesto() AS String
         ''' <summary>
         ''' Get or Sets the codigoContablePasivo in ConfiguracionContable.
         ''' </summary>
		Public Property codigoContablePasivo() AS String
         ''' <summary>
         ''' Get or Sets the codigoCosto in ConfiguracionContable.
         ''' </summary>
		Public Property codigoCosto() AS String
         ''' <summary>
         ''' Get or Sets the codigoEstado in ConfiguracionContable.
         ''' </summary>
		Public Property codigoEstado() AS String
         ''' <summary>
         ''' Get or Sets the uc in ConfiguracionContable.
         ''' </summary>
		Public Property uc() AS String
         ''' <summary>
         ''' Get or Sets the fc in ConfiguracionContable.
         ''' </summary>
		Public Property fc() AS DateTime
         ''' <summary>
         ''' Get or Sets the um in ConfiguracionContable.
         ''' </summary>
		Public Property um() AS String
         ''' <summary>
         ''' Get or Sets the fm in ConfiguracionContable.
         ''' </summary>
		Public Property fm() AS DateTime
         ''' <summary>
         ''' Get or Sets the codigoMovimiento in ConfiguracionContable.
         ''' </summary>
		Public Property codigoMovimiento() AS String
         ''' <summary>
         ''' Get or Sets the codigoProducto in ConfiguracionContable.
         ''' </summary>
		Public Property codigoProducto() AS String
         ''' <summary>
         ''' Get or Sets the codigoClase in ConfiguracionContable.
         ''' </summary>
		Public Property codigoClase() AS String
		
#End Region
    End Class	
    
End Namespace

