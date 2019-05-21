
Namespace SI.BE

    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 24/04/2011 08:51:18 a.m.
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    Public Class clsBE_TB_FJ_FIJACION

#Region "Constructor"
        Public Sub New()
            MyBase.New()
        End Sub

#End Region

#Region " Declaracion de Miembros "
        'Public Item As Integer


        Public Property OC() As String
        Public Property ESTADO() As String
        Public Property UNIDAD() As String
        Public Property DIRECCIONAMIENTO() As String
        Public Property LOCALIZADOR() As String
        Public Property PROVEEDOR() As String
        Public Property CALIDAD() As String
        Public Property TIPOQP() As String
        Public Property AJUSTE() As String
        Public Property ASIGNACION() As String
        Public Property RLC() As String
        Public Property ALCANCE() As String
        Public Property FECHA() As DateTime
        Public Property ELEMENTO() As String
        Public Property CANTIDAD() As Double
        Public Property APLICAR() As Double
        Public Property PRECIO() As Double
        Public Property PROTECCION As Double
        Public Property OPERADOR() As String
        Public Property COMENTARIOS() As String
        Public Property CONTRATOLOTEID() As String
        Public Property LIQUIDACIONID() As String
        Public Property TMH() As Double
        Public Property H20() As Double
        Public Property RUMAREF() As String
        Public Property TIPOFIJACION As Integer
        Public Property LEY() As Double
        Public Property OPERACION() As Double
        Public Property MIOZ() As Double
        Public Property PORCRECUMIN() As Double


        Public mBE_TB_FJ_FIJACION As ICollection(Of clsBE_TB_FJ_FIJACION)
        ''' <summary>
        ''' Gets or sets the tbLiquidacion of this ValorizadorPagable
        ''' </summary>
        Public Overridable Property tbLiquidacion() As ICollection(Of clsBE_TB_FJ_FIJACION)
            Get
                Return Me.mBE_TB_FJ_FIJACION
            End Get
            Set(ByVal value As ICollection(Of clsBE_TB_FJ_FIJACION))
                Me.mBE_TB_FJ_FIJACION = value
            End Set
        End Property

#End Region
    End Class

End Namespace

