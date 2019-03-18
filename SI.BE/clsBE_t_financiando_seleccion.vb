
Namespace  SI.BE

	''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:44
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
    Public Class clsBE_t_financiando_seleccion

#Region "Constructor"
        Public Sub New()
            MyBase.New()
        End Sub

#End Region

#Region " Declaracion de Miembros "
        Public Property item() As Integer
        Public Property diferido() As String
        Public Property empresa() As String
        Public Property td() As String
        Public Property nro_doc() As String
        Public Property nro_caja() As String
        Public Property nro_op() As String
        Public Property fch_op() As String
        Public Property lote() As String
        Public Property ruma() As String
        Public Property tad() As String
        Public Property calidad() As String
        Public Property us_aplica_sigv() As Double
        Public Property us_aplica_cigv() As Double
        Public Property saldo_us() As Double

        Public Property nro_cierre As Integer
        Public Property lote_vcm As String
        Public Property proveedor As String

#End Region
    End Class
    
End Namespace

