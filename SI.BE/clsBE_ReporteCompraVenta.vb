'Modified:
'@01 20141016 BAL01 Se agregan campos no relacionados liquidacionId, periodo, asientoContable

Namespace SI.BE

    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 18/04/2011 14:12:22
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    Public Class clsBE_ReporteCompraVenta

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

        Public Property empresa() As String
        Public Property periodo() As String
        Public Property periodoFin() As String
        Public Property producto() As String

        Public Property nAnio_Origen As Integer
        Public Property nAnio_Destino As Integer
        Public Property nMes_Origen As Integer
        Public Property nMes_Destino As Integer

#End Region
    End Class

End Namespace

