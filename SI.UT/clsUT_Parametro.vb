Namespace SI.UT
    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los dominios
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public Class clsUT_Dominio
        Public Shared domTABLA_DE_AJUSTES As String = "Ajuste"
        Public Shared domALMACEN As String = "Almacen"
        Public Shared domANALISIS As String = "Analisis"
        Public Shared domTABLA_DE_CALCULOS As String = "Calculo"
        Public Shared domTABLA_DE_CLASES As String = "Clase"
        Public Shared domTABLA_CONTABLE As String = "Contable"
        Public Shared domCONTABLE__COMPRA As String = "ContableCompra"
        Public Shared domCONTABLE__IMPUESTO As String = "ContableImpuesto"
        Public Shared domCONTABLE_MERCADERIA As String = "ContableMercaderia"
        Public Shared domCONTABLE__PASIVO As String = "ContablePasivo"
        Public Shared domCONTABLE__SERVICIO As String = "ContableServicio"
        Public Shared domCONTABLE__VARIACION As String = "ContableVariacion"
        Public Shared domTABLA_DE_CONTACTOS As String = "Contacto"
        Public Shared domTABLA_COSTOS As String = "Costo"
        Public Shared domTIPO_DE_DEDUCCION As String = "Deduccion"
        Public Shared domTABLA_DE_DEPOSITO As String = "Deposito"
        Public Shared domDIARIO As String = "Diario"
        Public Shared domTABLA_DE_DOCUMENTOS As String = "Documento"
        Public Shared domTABLA_DE_EMPRESA As String = "Empresa"
        Public Shared domTABLA_DE_ESTADOS As String = "Estado"
        Public Shared domTABLA_DE_INCOTERM As String = "Incoterm"
        Public Shared domLABORATORIO As String = "Laboratorio"
        Public Shared domMERCADO As String = "Mercado"
        Public Shared domMETAL As String = "Metal"
        Public Shared domTABLA_DE_MONEDAS As String = "Moneda"
        Public Shared domTABLA_DE_MOVIMIENTOS As String = "Movimiento"
        Public Shared domTABLA_DE_PRODUCTOS As String = "Producto"
        Public Shared domTIPO_DE_AJUSTE_DE_QP As String = "QpAjuste"
        Public Shared domTIPO_DE_PERIODO_DE_COTIZACION As String = "QpTipo"
        Public Shared domTABLA_DE_SERVICIOS As String = "Servicios"
        Public Shared domTABLA_DE_SOCIO As String = "Socio"
        Public Shared domTABLA As String = "Tabla"
        Public Shared domTIPOCONTRATO As String = "TipoContrato"
        Public Shared domTRADER As String = "Trader"
        Public Shared domADMINISTRADOR As String = "Administrador"
        Public Shared domTABLA_DE_CALIDAD As String = "Calidad"
        Public Shared domTABLA_DE_USUARIOS As String = "Usuario"


        Public Shared domFINANCIANDO_PRELIQ As String = "Adelanto"
        Public Shared domVentaVinculada As String = "VentaVinculada"
        Public Shared domTB_BENEFICIARIO_CCHICA As String = "Beneficiario"
        Public Shared domANEXOS_BANCO As String = "Anexo_Banco"
        Public Shared domOTRAS_CUENTAS_X_COBRAR As String = "OtrasCuentasXCobrar"
        Public Shared domPRESTAMOSCCHICA As String = "PrestamosCchica"
        Public Shared domPRESTAMOSCOMER As String = "PrestamosComer"
        Public Shared domTIPO_CATEGORIA As String = "Categoria"

    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Tabla de Ajustes"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class TABLA_DE_AJUSTES
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
        Public Shared ReadOnly ADELANTOS As New TABLA_DE_AJUSTES("Adelantos")
        Public Shared ReadOnly DESCUENTOS As New TABLA_DE_AJUSTES("Descuentos")
        Public Shared ReadOnly OTROS As New TABLA_DE_AJUSTES("Otros")
        Public Shared ReadOnly PLANTA As New TABLA_DE_AJUSTES("Planta")
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Almacen"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class ALMACEN
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
        Public Shared ReadOnly CALLAO As New ALMACEN("CALLAO")
        Public Shared ReadOnly LIMA As New ALMACEN("LIMA")
        Public Shared ReadOnly NAZCA As New ALMACEN("NAZCA")
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Analisis"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class ANALISIS
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
        Public Shared ReadOnly FINAL As New ANALISIS("FIN")
        Public Shared ReadOnly PRELIMINAR As New ANALISIS("PRE")
        Public Shared ReadOnly TIPICA As New ANALISIS("TIP")
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Tabla de Calculos"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class TABLA_DE_CALCULOS
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
        Public Shared ReadOnly ACTUAL As New TABLA_DE_CALCULOS("ACT")
        Public Shared ReadOnly CONTABLE As New TABLA_DE_CALCULOS("CTB")
        Public Shared ReadOnly PROVISIONAL As New TABLA_DE_CALCULOS("PRV")
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Tabla de Clases"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class TABLA_DE_CLASES
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
        Public Shared ReadOnly CEMENTO As New TABLA_DE_CLASES("CEMENTO")
        Public Shared ReadOnly CONCENTRADO As New TABLA_DE_CLASES("CONCENTRADO")
        Public Shared ReadOnly OXIDO_BAJA_LEY As New TABLA_DE_CLASES("OXIDO")
        Public Shared ReadOnly POLVO_ALTA_LEY As New TABLA_DE_CLASES("POLVO")
        Public Shared ReadOnly SULFURO_BAJA_LEY As New TABLA_DE_CLASES("SULFURO")
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Tabla Contable"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class TABLA_CONTABLE
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
        Public Shared ReadOnly IMPUESTO As New TABLA_CONTABLE("40xxx")
        Public Shared ReadOnly POR_PAGAR As New TABLA_CONTABLE("42xxx")
        Public Shared ReadOnly COMPRA As New TABLA_CONTABLE("60xxx")
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Contable  Compra"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class CONTABLE__COMPRA
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Contable  Impuesto"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class CONTABLE__IMPUESTO
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Contable Mercaderia"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class CONTABLE_MERCADERIA
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Contable  Pasivo"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class CONTABLE__PASIVO
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Contable  Servicio"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class CONTABLE__SERVICIO
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Contable  Variacion"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class CONTABLE__VARIACION
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Tabla de Contactos"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class TABLA_DE_CONTACTOS
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
        Public Shared ReadOnly DATOS_DE_CONTATO As New TABLA_DE_CONTACTOS("20708358")
        Public Shared ReadOnly DATOS_DE_OTRO_COTNACTO As New TABLA_DE_CONTACTOS("21548754")
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Tabla Costos"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class TABLA_COSTOS
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
        Public Shared ReadOnly CENTRO_DE_COSTO_1 As New TABLA_COSTOS("aaaaa")
        Public Shared ReadOnly CENTRO_DE_COSTO_2 As New TABLA_COSTOS("bbbbb")
        Public Shared ReadOnly CENTRO_DE_COSTO_3 As New TABLA_COSTOS("ccccc")
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Tipo de Deduccion"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class TIPO_DE_DEDUCCION
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
        Public Shared ReadOnly MINIMA As New TIPO_DE_DEDUCCION("MIN")
        Public Shared ReadOnly PREVIA As New TIPO_DE_DEDUCCION("PRE")
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Tabla de Deposito"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class TABLA_DE_DEPOSITO
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
        Public Shared ReadOnly CALLAO As New TABLA_DE_DEPOSITO("Callao")
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Diario"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class DIARIO
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
        Public Shared ReadOnly COMPRAS As New DIARIO("COMP")
        Public Shared ReadOnly INVENTARIOS As New DIARIO("INVE")
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Tabla de Documentos"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class TABLA_DE_DOCUMENTOS
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
        Public Shared ReadOnly FACTURA As New TABLA_DE_DOCUMENTOS("FA")
        Public Shared ReadOnly NOTA_DE_CREDITO As New TABLA_DE_DOCUMENTOS("NC")
        Public Shared ReadOnly NOTA_DE_DEBITO As New TABLA_DE_DOCUMENTOS("ND")
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Tabla de Empresa"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class TABLA_DE_EMPRESA
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
        Public Shared ReadOnly ENPROYEC As New TABLA_DE_EMPRESA("ENP")
        Public Shared ReadOnly MINCORP As New TABLA_DE_EMPRESA("MNC")
        Public Shared ReadOnly MINEX As New TABLA_DE_EMPRESA("MNX")
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Tabla de Estados"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class TABLA_DE_ESTADOS
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
        Public Shared ReadOnly INACTIVO As New TABLA_DE_ESTADOS("0")
        Public Shared ReadOnly ACTIVO As New TABLA_DE_ESTADOS("1")
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Tabla de Incoterm"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class TABLA_DE_INCOTERM
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
        Public Shared ReadOnly FREIGTH_ON_BOARD As New TABLA_DE_INCOTERM("FOB")
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Laboratorio"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class LABORATORIO
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
        Public Shared ReadOnly ALFRED_H_KNIGHT As New LABORATORIO("AHK")
        Public Shared ReadOnly INSPECTORATE As New LABORATORIO("INS")
        Public Shared ReadOnly PERULAB As New LABORATORIO("PER")
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Mercado"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class MERCADO
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
        Public Shared ReadOnly BULLETIN As New MERCADO("BUL")
        Public Shared ReadOnly LME As New MERCADO("LME")
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Metal"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class METAL
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
        Public Shared ReadOnly PLATA As New METAL("AG")
        Public Shared ReadOnly ARSENICO As New METAL("AS")
        Public Shared ReadOnly ORO As New METAL("AU")
        Public Shared ReadOnly BISMUTO As New METAL("BI")
        Public Shared ReadOnly COBRE As New METAL("CU")
        Public Shared ReadOnly PLOMO As New METAL("PB")
        Public Shared ReadOnly ZINC As New METAL("ZN")
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Tabla de Monedas"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class TABLA_DE_MONEDAS
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
        Public Shared ReadOnly DOLARES As New TABLA_DE_MONEDAS("DOL")
        Public Shared ReadOnly SOLES As New TABLA_DE_MONEDAS("SOL")
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Tabla de Movimientos"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class TABLA_DE_MOVIMIENTOS
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
        Public Shared ReadOnly MEZCLA As New TABLA_DE_MOVIMIENTOS("B")
        Public Shared ReadOnly DESPACHO As New TABLA_DE_MOVIMIENTOS("D")
        Public Shared ReadOnly COMPRA As New TABLA_DE_MOVIMIENTOS("P")
        Public Shared ReadOnly VENTA As New TABLA_DE_MOVIMIENTOS("S")
        Public Shared ReadOnly VINCULADA As New TABLA_DE_MOVIMIENTOS("V")
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Tabla de Productos"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class TABLA_DE_PRODUCTOS
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
        Public Shared ReadOnly PLATA As New TABLA_DE_PRODUCTOS("AG")
        Public Shared ReadOnly ORO As New TABLA_DE_PRODUCTOS("AU")
        Public Shared ReadOnly COBRE As New TABLA_DE_PRODUCTOS("CU")
        Public Shared ReadOnly PLOMO As New TABLA_DE_PRODUCTOS("PB")
        Public Shared ReadOnly ZINC As New TABLA_DE_PRODUCTOS("ZN")
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Tipo de Ajuste de QP"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class TIPO_DE_AJUSTE_DE_QP
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
        Public Shared ReadOnly CLOSE As New TIPO_DE_AJUSTE_DE_QP("CLOSE")
        Public Shared ReadOnly FIXED As New TIPO_DE_AJUSTE_DE_QP("FIXED")
        Public Shared ReadOnly M As New TIPO_DE_AJUSTE_DE_QP("M")
        Public Shared ReadOnly MAMA As New TIPO_DE_AJUSTE_DE_QP("MAMA")
        Public Shared ReadOnly MAMD As New TIPO_DE_AJUSTE_DE_QP("MAMD")
        Public Shared ReadOnly MAMS As New TIPO_DE_AJUSTE_DE_QP("MAMS")
        Public Shared ReadOnly MOSD As New TIPO_DE_AJUSTE_DE_QP("MOSD")
        Public Shared ReadOnly MOSH As New TIPO_DE_AJUSTE_DE_QP("MOSH")
        Public Shared ReadOnly MOSS As New TIPO_DE_AJUSTE_DE_QP("MOSS")
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Tipo de Periodo de Cotizacion"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class TIPO_DE_PERIODO_DE_COTIZACION
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
        Public Shared ReadOnly FIJADO As New TIPO_DE_PERIODO_DE_COTIZACION("FIJ")
        Public Shared ReadOnly REGULAR As New TIPO_DE_PERIODO_DE_COTIZACION("REG")
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Tabla de Servicios"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class TABLA_DE_SERVICIOS
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
        Public Shared ReadOnly SERVICIO1 As New TABLA_DE_SERVICIOS("servicio1")
        Public Shared ReadOnly SERVICIO2 As New TABLA_DE_SERVICIOS("servicio2")
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Tabla de Socio"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class TABLA_DE_SOCIO
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
        Public Shared ReadOnly DREYFUS As New TABLA_DE_SOCIO("2012345678")
        Public Shared ReadOnly VILLIBRODIS As New TABLA_DE_SOCIO("2012345679")
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Tabla"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class TABLA
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
        Public Shared ReadOnly CONTRATO As New TABLA("CON")
        Public Shared ReadOnly LOTE As New TABLA("LOT")
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "TipoContrato"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class TIPOCONTRATO
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
    End Class

    '''<summary>
    '''Escrito por: Martin Huaman
    '''Fecha Creacion: Mar 22 2011 12:06PM
    '''Proposito: Contiene los parametros del dominio "Trader"
    '''Fecha Modificacion:
    '''</summary>
    '''
    Public NotInheritable Class TRADER
        Private Sub New(ByVal stringValue As String)
            Me.Value = stringValue
        End Sub
        Public Value As String
        Public Shared ReadOnly JUAN_ARIAS As New TRADER("JARIAS")
    End Class

    '  '''<summary>
    '  '''Escrito por: Martin Huaman
    '  '''Fecha Creacion: Mar 22 2011 12:06PM
    '  '''Proposito: Contiene los parametros del dominio "Tabla de Usuarios"
    '  '''Fecha Modificacion:
    '  '''</summary>
    '  '''
    '  Public NotInheritable Class TABLA_DE_USUARIOS
    '      Private Sub New(ByVal stringValue As String)
    '          Me.Value = stringValue
    '      End Sub
    '      Public Value As String
    'Public Shared ReadOnly 12345678 As New  TABLA_DE_USUARIOS("AHUARINGA")
    'Public Shared ReadOnly 12345678 As New  TABLA_DE_USUARIOS("AVARGAS")
    'Public Shared ReadOnly 12345678 As New  TABLA_DE_USUARIOS("MHUAMAN")
    '  End Class

End Namespace
