
Namespace  SI.BE

	''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:44
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
    Public Class clsBE_TB_RECLASIFICA

#Region "Constructor"
        Public Sub New()
            MyBase.New()
        End Sub

#End Region

#Region " Declaracion de Miembros "

        Public Property EMPRESA() As String
        Public Property RUC() As String
        Public Property PROVEEDOR() As String
        Public Property DOCUM() As String
        Public Property FECHA1() As DateTime
        Public Property FECHA2() As DateTime
        Public Property LOTEREF() As String
        Public Property MONEDA() As String
        Public Property DOLAR() As Double
        Public Property SOLES() As Double
        Public Property FACT() As String
        Public Property FACTURA() As String
        Public Property FLG_RECLASIFICA() As Integer
        Public Property USER_RECLA() As String
        Public Property FECHA_RECLA() As DateTime
        Public Property ID_ITEM() As Integer
        Public Property SUBDIA_CONTAB() As String
        Public Property COMPR_CONTAB() As String
        Public Property FACT_LIQUIDA() As String
        Public Property T_CAMBIO() As Double
        Public Property DOLAR_RECLA() As Double
        Public Property SOLES_RECLA() As Double
        Public Property LOTE_GEN() As String
        Public Property LOTE_APL() As String

        Public Property ITEM() As Integer


#End Region
    End Class
    
End Namespace

