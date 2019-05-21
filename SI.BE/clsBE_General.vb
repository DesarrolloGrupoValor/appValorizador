Namespace SI.BE

    ''' <summary>
    ''' Escrito por: Martin Huaman
    ''' Fecha Creacion: 07/11/2007 03:45:36 p.m.
    ''' Proposito: 
    ''' Fecha Modificacion:
    ''' </summary>
    '''
    <CLSCompliant(True)> _
     <Serializable()> _
    Public Class clsBE_General

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
        Private mintItem As Integer
        Private mstrNomTabla As String
        Private mstrValueField As String
        Private mstrNomCampo1 As String
        Private mstrNomCampo2 As String
        Private mstrNomCampo3 As String
        Private mstrNomCampo4 As String
        Private mstrNomCampo5 As String
        Private mstrNomCampo6 As String
        Private mstrNomCampo7 As String
        Private mstrNomCampo8 As String

        Private mstrNomCampo9 As String
        Private mstrNomCampo10 As String

        Private mstrValCampo1 As String
        Private mstrValCampo2 As String
        Private mstrValCampo3 As String
        Private mstrValCampo4 As String
        Private mstrValCampo5 As String

        Private mstrValCampo6 As String
        Private mstrValCampo7 As String
        Private mstrValCampo8 As String

        Private mstrValCampo9 As String
        Private mstrValCampo10 As String

        Private mstrCampoRetorna As String
        Private mstrPrimerValor As String
        Private mstrDescripcion_Retorna As String
        Private mstrId_Retorna As String
        Private mstrCodigo_Retorna As String
        Private mstrCodigoDescripcion_Retorna As String
        Private mstrCamposOrder As String
        Private mlngId_Valor As Long
        Private mbytvinculo As Byte()
#End Region

        ''' <summary>
        ''' Propiedades de la entidad.
        ''' </summary>
#Region " Propiedades "

        Public Property Descripcion_Retorna() As String
            Get
                Return mstrDescripcion_Retorna
            End Get
            Set(ByVal value As String)
                mstrDescripcion_Retorna = value
            End Set
        End Property

        Public Property Id_Valor() As Long
            Get
                Return mlngId_Valor
            End Get
            Set(ByVal value As Long)
                mlngId_Valor = value
            End Set
        End Property

        Public Property Id_Retorna() As String
            Get
                Return mstrId_Retorna
            End Get
            Set(ByVal value As String)
                mstrId_Retorna = value
            End Set
        End Property

        Public Property Codigo_Retorna() As String
            Get
                Return mstrCodigo_Retorna
            End Get
            Set(ByVal value As String)
                mstrCodigo_Retorna = value
            End Set
        End Property
        Public Property CodigoDescripcion_Retorna() As String
            Get
                Return mstrCodigoDescripcion_Retorna
            End Get
            Set(ByVal value As String)
                mstrCodigoDescripcion_Retorna = value
            End Set
        End Property
        Public Property CamposOrder() As String
            Get
                Return mstrCamposOrder
            End Get
            Set(ByVal value As String)
                mstrCamposOrder = value
            End Set
        End Property
        Public Property PrimerValor() As String
            Get
                Return mstrPrimerValor
            End Get
            Set(ByVal value As String)
                mstrPrimerValor = value
            End Set
        End Property

        Public Property ValueField() As String
            Get
                Return mstrValueField
            End Get
            Set(ByVal value As String)
                mstrValueField = value
            End Set
        End Property

        Public Property Item() As Integer
            Get
                Return mintItem
            End Get
            Set(ByVal Value As Integer)
                mintItem = Value
            End Set
        End Property

        Public Property NomTabla() As String
            Get
                Return mstrNomTabla
            End Get
            Set(ByVal Value As String)
                mstrNomTabla = Value
            End Set
        End Property

        Public Property NomCampo1() As String
            Get
                Return mstrNomCampo1
            End Get
            Set(ByVal Value As String)
                mstrNomCampo1 = Value
            End Set
        End Property

        Public Property NomCampo2() As String
            Get
                Return mstrNomCampo2
            End Get
            Set(ByVal Value As String)
                mstrNomCampo2 = Value
            End Set
        End Property

        Public Property NomCampo3() As String
            Get
                Return mstrNomCampo3
            End Get
            Set(ByVal Value As String)
                mstrNomCampo3 = Value
            End Set
        End Property
        Public Property NomCampo4() As String
            Get
                Return mstrNomCampo4
            End Get
            Set(ByVal Value As String)
                mstrNomCampo4 = Value
            End Set
        End Property
        Public Property NomCampo5() As String
            Get
                Return mstrNomCampo5
            End Get
            Set(ByVal Value As String)
                mstrNomCampo5 = Value
            End Set
        End Property
        Public Property NomCampo6() As String
            Get
                Return mstrNomCampo6
            End Get
            Set(ByVal Value As String)
                mstrNomCampo6 = Value
            End Set
        End Property


        Public Property NomCampo7() As String
            Get
                Return mstrNomCampo7
            End Get
            Set(ByVal Value As String)
                mstrNomCampo7 = Value
            End Set
        End Property


        Public Property NomCampo8() As String
            Get
                Return mstrNomCampo8
            End Get
            Set(ByVal Value As String)
                mstrNomCampo8 = Value
            End Set
        End Property

        Public Property NomCampo9() As String
            Get
                Return mstrNomCampo9
            End Get
            Set(ByVal Value As String)
                mstrNomCampo9 = Value
            End Set
        End Property

        Public Property NomCampo10() As String
            Get
                Return mstrNomCampo10
            End Get
            Set(ByVal Value As String)
                mstrNomCampo10 = Value
            End Set
        End Property

        Public Property ValCampo1() As String
            Get
                Return mstrValCampo1
            End Get
            Set(ByVal Value As String)
                mstrValCampo1 = Value
            End Set
        End Property

        Public Property ValCampo2() As String
            Get
                Return mstrValCampo2
            End Get
            Set(ByVal Value As String)
                mstrValCampo2 = Value
            End Set
        End Property
        Public Property ValCampo3() As String
            Get
                Return mstrValCampo3
            End Get
            Set(ByVal Value As String)
                mstrValCampo3 = Value
            End Set
        End Property
        Public Property ValCampo4() As String
            Get
                Return mstrValCampo4
            End Get
            Set(ByVal Value As String)
                mstrValCampo4 = Value
            End Set
        End Property
        Public Property ValCampo5() As String
            Get
                Return mstrValCampo5
            End Get
            Set(ByVal Value As String)
                mstrValCampo5 = Value
            End Set
        End Property




        Public Property ValCampo6() As String
            Get
                Return mstrValCampo6
            End Get
            Set(ByVal Value As String)
                mstrValCampo6 = Value
            End Set
        End Property
        Public Property ValCampo7() As String
            Get
                Return mstrValCampo7
            End Get
            Set(ByVal Value As String)
                mstrValCampo7 = Value
            End Set
        End Property

        Public Property ValCampo8() As String
            Get
                Return mstrValCampo8
            End Get
            Set(ByVal Value As String)
                mstrValCampo8 = Value
            End Set
        End Property

        Public Property ValCampo9() As String
            Get
                Return mstrValCampo9
            End Get
            Set(ByVal Value As String)
                mstrValCampo9 = Value
            End Set
        End Property

        Public Property ValCampo10() As String
            Get
                Return mstrValCampo10
            End Get
            Set(ByVal Value As String)
                mstrValCampo10 = Value
            End Set
        End Property

        Public Property CampoRetorna() As String
            Get
                Return mstrCampoRetorna
            End Get
            Set(ByVal Value As String)
                mstrCampoRetorna = Value
            End Set
        End Property
        Public Property vinculo() As Byte()
            Get
                Return mbytvinculo
            End Get
            Set(ByVal Value As Byte())
                mbytvinculo = Value
            End Set
        End Property
#End Region

    End Class
    <CLSCompliant(True)> _
     <Serializable()> _
    Public Class clsBE_General_resultado

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
        Private mintItem As Integer
        Private mstrCodigo_Retorna As String
        Private mstrDescripcion_Retorna As String



#End Region

        ''' <summary>
        ''' Propiedades de la entidad.
        ''' </summary>
#Region " Propiedades "

        
        Public Property Codigo_Retorna() As String
            Get
                Return mstrCodigo_Retorna
            End Get
            Set(ByVal value As String)
                mstrCodigo_Retorna = value
            End Set
        End Property
        Public Property Descripcion_Retorna() As String
            Get
                Return mstrDescripcion_Retorna
            End Get
            Set(ByVal value As String)
                mstrDescripcion_Retorna = value
            End Set
        End Property
#End Region

    End Class
End Namespace




