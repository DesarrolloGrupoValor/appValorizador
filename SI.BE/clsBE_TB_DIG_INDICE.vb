
Namespace  SI.BE

	''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 17/02/2011 16:58:44
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
	'''
    Public Class clsBE_TB_DIG_INDICE

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
        Public Property	IDITEM	() AS INTEGER
        Public Property EMPRESA() As String
        Public Property IDTIPODOC_DIG() As String
        Public Property PROVEEDOR() As String
        Public Property CONTRATO() As String
        Public Property LOTE() As String
        Public Property NRO_DOC_INTERNO() As String
        Public Property NRO_DOC_EXTERNO() As String
        Public Property FECHA_DOC() As DateTime
        Public Property RUMA() As String
        Public Property BENEFICIARIO() As String
        Public Property REFERENCIA1() As String
        Public Property ARCHIVO() As String
        Public Property IDFLUJO() As String
        Public Property CONTRATO_LIQ() As String
        Public Property LOTE_LIQ() As String
        Public Property LIQUIDACION() As String
        '        Public Property PC_CREADOR() As String
        'Public Property	FECHA_CREA	datetime
        'Public Property	PC_ULT_MODIF	varchar
        'Public Property	FECHA_ULT_MODIF	datetime
        Public Property ContratoLoteId() As String
        Public Property LiquidacionId() As String
        Public Property IDITEM_ORIGEN() As Integer
        Public Property ESTADO() As String

        Public Property liquidacionEstadoId As Integer
        Public Property liquidacionEstadoDetalleId As Integer
        'Public Property '0000000001',
        Public Property uc As String


        Public Property liquidacionAdjuntoId() As String
        Public Property RUTA() As String
        Public Property RUTA_ORIGEN() As String

        Public Property NRO_OP() As String

#End Region
    End Class
    
End Namespace

