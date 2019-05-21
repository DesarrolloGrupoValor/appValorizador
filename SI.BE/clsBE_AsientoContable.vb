
Namespace  SI.BE

	''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:38:09
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
	Public Class clsBE_AsientoContable
	
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
         ''' Get or Sets the contabilidadId in AsientoContable.
         ''' </summary>
		Public Property contabilidadId() AS String
         ''' <summary>
         ''' Get or Sets the asientoId in AsientoContable.
         ''' </summary>
		Public Property asientoId() AS String
         ''' <summary>
         ''' Get or Sets the codigoContable in AsientoContable.
         ''' </summary>
		Public Property codigoContable() AS String
         ''' <summary>
         ''' Get or Sets the codigoCosto in AsientoContable.
         ''' </summary>
		Public Property codigoCosto() AS String
         ''' <summary>
         ''' Get or Sets the debeSol in AsientoContable.
         ''' </summary>
		Public Property debeSol() AS Integer
         ''' <summary>
         ''' Get or Sets the haberSol in AsientoContable.
         ''' </summary>
		Public Property haberSol() AS Integer
         ''' <summary>
         ''' Get or Sets the debeUsd in AsientoContable.
         ''' </summary>
		Public Property debeUsd() AS Integer
         ''' <summary>
         ''' Get or Sets the haberUsd in AsientoContable.
         ''' </summary>
		Public Property haberUsd() AS Integer
         ''' <summary>
         ''' Get or Sets the descri in AsientoContable.
         ''' </summary>
		Public Property descri() AS String
         ''' <summary>
         ''' Get or Sets the codigoEstado in AsientoContable.
         ''' </summary>
		Public Property codigoEstado() AS String
         ''' <summary>
         ''' Get or Sets the uc in AsientoContable.
         ''' </summary>
		Public Property uc() AS String
         ''' <summary>
         ''' Get or Sets the fc in AsientoContable.
         ''' </summary>
		Public Property fc() AS DateTime
         ''' <summary>
         ''' Get or Sets the um in AsientoContable.
         ''' </summary>
		Public Property um() AS String
         ''' <summary>
         ''' Get or Sets the fm in AsientoContable.
         ''' </summary>
		Public Property fm() AS DateTime
         ''' <summary>
         ''' Get Collection of tbContabilidad.
         ''' </summary>        
        Public mBE_tbContabilidad As ICollection(Of clsBE_Contabilidad)                   
        ''' <summary>
        ''' Gets or sets the tbContabilidad of this AsientoContable
        ''' </summary>
        Public Overridable Property tbContabilidad() As ICollection(Of clsBE_Contabilidad)
            Get
                Return Me.mBE_tbContabilidad
            End Get
            Set(ByVal value As ICollection(Of clsBE_Contabilidad))
                Me.mBE_tbContabilidad = value
            End Set
        End Property
         
		
#End Region
    End Class	
    
End Namespace

