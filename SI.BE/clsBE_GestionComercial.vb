
Namespace SI.BE

    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 18/04/2011 14:12:56
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    Public Class clsBE_GestionComercial

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

        Public Property nGestionComercialId As Integer
        Public Property dFechaEmision As DateTime
        Public Property sMes As String
        Public Property sMesDescripcion As String
        Public Property sAnio As String
        Public Property sTipoDocumento As String
        Public Property sNumeroDcoumento As String
        Public Property sEmpresa As String
        Public Property sCliente As String
        Public Property nComision As Double
        Public Property sUc As String

        Public mBE_GestionComercial As ICollection(Of clsBE_GestionComercial)
       
        Public Overridable Property tbContratoLote() As ICollection(Of clsBE_GestionComercial)
            Get
                Return Me.mBE_GestionComercial
            End Get
            Set(ByVal value As ICollection(Of clsBE_GestionComercial))
                Me.mBE_GestionComercial = value
            End Set
        End Property

#End Region
    End Class

End Namespace

