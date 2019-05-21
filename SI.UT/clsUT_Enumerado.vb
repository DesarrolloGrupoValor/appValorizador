﻿Namespace SI.UT
    Public Class clsUT_Enumerado
#Region " Enumeraciones "
        Public Enum enumAyuda
            Inicio = 10
            Usuarios = 11
            Perfiles = 12
            Log = 13
            Acceso = 14
            catalogorubros = 21
            CatalogoRecursos = 22
            CatalogoPA = 23
            Clientes = 24
            CatalogoCI = 25
            Clases = 26
            Companias = 27
            Pais = 28
            Moneda = 29
            Tipodecambio = 210
            Unidades = 211
            Tipodecontrato = 212
            Zonas = 213
            ipuc = 214
            ValoresIPUC = 215
            CatalogoCostosvarios = 216
            Contingencias = 217
            Fianzas = 218
            Ofertas = 31
            Rubros = 32
            Recursos = 33
            PC = 34
            PA = 35
            RelacionarPartidas = 36
            CronogramaPC = 37
            CronogramaPA = 38
            Formulapolinomica = 39
            CI = 310
            Presentacion = 311
            CostosVarios = 312
        End Enum
        Public Enum enumParametros
            Load = 0
            FiltroBasico = 1
            FiltroAvanzado = 2
            Analisis = 3
        End Enum
        Public Enum enumExportar
            NoExportable = 0
            Exportable = 1
        End Enum
        Public Enum enumEdicion
            NoAccesible = 0
            Buscar = 1
            Reemplazar = 2
            BuscaryReemplazar = 3
        End Enum
        Public Enum enumCalculoCronograma
            Periodos = 1
            Trabajadores = 2
        End Enum
        Public Enum enumIdioma
            Ingles = 0
            Espanol = 1
        End Enum
       
        Public Enum enumAnalisis
            R95 = 95
            R35 = 35
        End Enum
        Public Enum enumKeyF12
            Crear = 0
            Modificar = 1
            Eliminar = 2
            Guardar = 3
            Cancelar = 4
            Refrescar = 7
            FiltroB = 8
            FiltroA = 9
            ModificarDI = 10
            ModificarAE = 11
            Selectivo = 12
            Calculo = 13
            Indices = 14
            CabeceraAnalisis = 15
            Buscar = 16
            VerPadres = 17
            VerPartidaAnalisis = 18
            AyudaTeclas = 19
            Reiniciar = 20
            Update = 21
            AcercaDe = 22
            Ayuda = 23
            Salir = 24
            PartidaCliente = 25
            PartidaAnalisis = 26
            CalcularOferta = 27
            CostoIndirecto = 28
            Rubro = 29
            Recurso = 30
            FormulaPol = 31
            CopiarAnalisis = 32
            Analisis = 33
            Cronograma = 34
            Arbol = 35
            ActualizaCosto = 36
        End Enum
        Public Enum enumKeys
            'KEYEVENTF_KEYUP = &H2
            KeyEventF_Keyup = &H2
            keyBackspace = &H8
            keyTab = &H9
            keyReturn = &HD
            keyShift = &H10
            keyControl = &H11
            keyAlt = &H12
            keyPause = &H13
            keyEscape = &H1B
            keySpace = &H20
            keyEnd = &H23
            keyHome = &H24
            keyLeft = &H25
            KeyUp = &H26
            keyRight = &H27
            KeyDown = &H28
            keyInsert = &H2D
            keyDelete = &H2E
            keyF1 = &H70
            keyF2 = &H71
            keyF3 = &H72
            keyF4 = &H73
            keyF5 = &H74
            keyF6 = &H75
            keyF7 = &H76
            keyF8 = &H77
            keyF9 = &H78
            keyF10 = &H79
            keyF11 = &H7A
            keyF12 = &H7B
            keyNumLock = &H90
            keyScrollLock = &H91
            keyCapsLock = &H14
            Key1 = &H31
            Key2 = &H32
            KeyA = &H41
            KeyB = &H42
            KeyC = &H43
            KeyD = &H44
            KeyE = &H45
            KeyF = &H46
            KeyG = &H47
            KeyH = &H48
            KeyI = &H49
            KeyJ = &H4A
            KeyK = &H4B
            KeyL = &H4C
            KeyM = &H4D
            KeyN = &H4E
            KeyO = &H4F
            KeyP = &H50
            KeyQ = &H51
            KeyR = &H52
            KeyS = &H53
            KeyT = &H54
            KeyU = &H55
            KeyV = &H56
            KeyW = &H57
            KeyX = &H58
            KeyY = &H59
            KeyZ = &H5A

        End Enum
        Public Enum EnumPageAnalisis
            Directo1 = 0
            Directo2 = 1
            Directo3 = 2
            Amortizacion = 3
            Especial = 4
        End Enum
        Public Enum enumEdicionCelda    '**Revisar tambien maskedtextboccolumn.cs
            NoEditable = 0
            AlCrear = 1
            AlModificar = 2
            AlCrearyModificar = 3
        End Enum
        Public Enum enumConfiguracionLocal
            appName = 0
            appVersion = 1
            appColorAnalisis = 2
            appColorOfertaCerrada = 3
            appColorEdicion = 4
            appStandAlone = 5
            appPathActualiza = 6
            appContadorActualiza = 7
            appColorenAnalisis = 8
        End Enum
        Public Enum enumTipoSpoTextbox
            AlfaNumerico = 0
            SoloAlfabeto = 1
            Moneda = 2
            Personalizado = 3
            NumeroDecimal = 4
            CorreoElectronico = 5
            NumeroEntero = 6
            Normal = 7
            NumeroTelefono = 8
            NumeroSerial = 9
            Apellidos = 10
            Unidad = 11
            SoloLectura = 12
        End Enum
        Public Enum enumTipoAmortizacion
            FOB = 0
            Almacen = 1
        End Enum
        Public Enum enumTipoCadena
            Numero = 0
        End Enum
        Public Enum enumTipoMant
            Listado = 1
            Analisis = 2
        End Enum
        Public Enum enumTipoMantCV
            CostosVarios = 1
            Fianza = 2
            Contingencia = 3
        End Enum
        Public Enum enumTipoFactor
            Clase = 1
            PCliente = 2
        End Enum
        Public Enum enumTipoCopia
            PorVariante = 1
            PorRango = 2
        End Enum
        Public Enum enumTipoEdicion
            SinEditar = 0
            Copiar = 1
            Cortar = 2
            Pegar = 3
        End Enum
        Public Enum enumTipoCronogramaRecursos
            Barra = 1
            Dias = 2
            Porcentaje = 3
        End Enum
        Public Enum enumTipoEquivalencia
            PCaPA = 1
            PAaPC = 2
        End Enum
        Public Enum enumTipoFila
            Normal = 0
            Cortada = 1
            Copiada = 2
            Pegada = 3
        End Enum
        Public Enum enumTipoRegistro
            Activo = 0
            Nuevo = 1
            Modificado = 2
            Eliminado = 3
            Temporal = 4
        End Enum
        Public Enum enumTipoRegistroContingencia
            Contingencia = 0
            Rubro = 1
        End Enum
        Public Enum enumTipoComboGrilla
            IdDescripcion = 0
            IdCodigo = 1
            IDDescripcionCodigo = 2
            IDCodigoDescripcion = 3
            IdDescripcion_larga = 4
        End Enum
        Public Enum enumCamposOrder
            Ninguno = 0
            Id = 1
            Descripcion = 2
            Codigo = 3
            CodigoDescripcion = 4
        End Enum
        Public Enum enumValidUsuario
            UserValido = 0
            DatosInvalidos = 1
            UserBloqueado = 2
            NoExiste = 3
        End Enum
        Public Enum enumEntidadReporte
            Usuario = 0
            Perfil = 1
            TablaGeneral = 2
            Rubros = 3
            Oferta = 4
            Cliente = 5
            LogAcceso = 6
            Recursos = 7
            CatalogoRubros = 8
            CatalogoRecursos = 9
            CatalogoRecursosPrecio = 10
            PresupuestoBase = 11
            EquivalenciasPAvsPC = 12
            EquivalenciasPCvsPA = 13
            Persona = 14
            PartidaAnalisisResumen = 15
            CatalogoPartidaAnalisisResumen = 16
            CatalogoPartidaAnalisisAnalisisUnitarios = 17
            PartidaAnalisisUnitarios = 18
            PartidaAnalisisUnitariosDesconsolidado = 19
            PartidaAnalisisUnitariosCliente = 20
            PartidaDetalleAnalisisEspecial = 21
            MonedaTipoCambio = 22
            ResumenCostoxRubro = 23
            ListadoOfertaRubro = 24
            PresupuestoOferta = 25
            ResumenCostoxRubroCols = 26
            ResumenCostoUnitRend = 27
            ResumenCostoUnitRendCols = 28
            ResumenEspecialesCons = 29
            ResumenEspecialesSemiDesc = 30
            FormulaPolinomica = 31
            ResumenCostoxIPUCFP = 32
            ResumenCostosxIPUCxFPolinomicas = 33
            ListadoPartidaCliente = 34
            ListadoPartidaAnalisis = 35
            FormulaCliente = 36
            RecursosResumen = 37
            ListadoCostoIndirecto = 38
            IndicesZona = 39
            ListaCostosVarios = 40
            CronogramaValorizadoPC = 41
            ResumenEquipos = 42
            AnalisisCostoUnitarioEquipo = 43
            ListadoPartidaAnalisisSinDetalle = 44
            OfertaUsuarios = 45
            ListadoPartidaClienteRxC = 46
            OfertaDatosGenerales = 47
            CatalogoCostoIndirecto = 48
            DetalleCostoIndirecto = 49
            CatalogoRecursosMonedaPrecio = 50
            CatalogoPartidaAnalisisAnalisisUnitariosDesconsolidado = 51
            RecursosEspecialesDesc = 52
            PASinDetalle = 53
            RecursosEspecialesClienteDesc = 54
            OfertaResumenCostoVenta = 55
            PresupuestoBaseN1 = 56
            PresupuestoBaseN2 = 57
            PresupuestoBaseN3 = 58
            PresupuestoBaseN4 = 59
            PresupuestoBaseN5 = 60
            RecursosArbol = 61
            CatalogoRecursoRelacion = 62
            CatalogoRecursoEspecial = 63
            CatalogoResumenEquipos = 64
            CronogramaRecursos = 65
            CronogramaRecursosPorcentaje = 66
            CatalogoRecursosArbol = 67
            CronogramaCostoIndirectoRecursoAsignado = 68
            CronogramaValorizadoRecursosEspeciales = 69
            CronogramaValorizadoPartidaAnalisisDes = 70
            CronogramaValorizadoPartidaAnalisisCon = 71
            PresupuestoBase_HH = 72
            ResumenCostoxRubroAgru = 73
            HojaVentaDetalle = 74
            ResumenCostoxRubroAgru_1Mon = 75
            PartidaAnalisisUnitariosCliente_1Mon = 76
            RecursosEspecialesClienteDesc_1Mon = 77
            PresupuestoBase_1Mon = 78
            RecursosArbolPartida = 79
            HojaVenta = 80
            CronogramaValorizadoPartidaClienteCosto = 81
            CronogramaValorizadoPartidaClienteVenta = 82
            CronogramaValorizadoPartidaClienteRecursos = 83
            CostoIndirecto_ResumenRecurso = 84
            ResumenCostoVenta = 85
            CostoIndirecto_Detalle = 86
            CostosVariosResumen = 87
            CronogramaPartidaCliente = 88
            OfertaErroresyOmisiones = 89
            CronogramaValorizadoPartidaAnalisisConsolidado = 90
            CronogramaValorizadoPartidaAnalisisDesConsolidado = 91
        End Enum
        Public Enum enumEntidadParametro
            Usuario = 0
            Perfil = 1
            Estado_General = 2
        End Enum
        Public Enum EnumEntidadTablaGeneral
            Moneda = 0
            Pais = 1
            Unidad = 2
            Clase = 3
            Compañia = 4
            TipoContrato = 5
            Zona = 6
            Indice = 7
            cargo = 8
            CostosVarios = 9
            Fianzas = 10
            Contingencia = 11
        End Enum
        Public Enum EnumFormAyuda
           
            EstadoGeneral = 0
            Contratos = 1
            Lotes = 2
            Socio = 3
            Empresa = 4
            Trader = 5
            Calidad = 6

            Adelanto = 7

            VentaVinculada = 8

            Administrador = 9

            Beneficiario = 10
            Anexo_Banco = 11
            OtrasCuentasXCobrar = 12
            PrestamosCChica = 13
            PrestamosComer = 14

        End Enum
        Public Enum enumEntidadMantenimiento
            Oferta = 0
            Usuario = 1
            Perfil = 2
            Clientes = 3
            PartidaCliente = 4
            PartidaAnalisis = 5
            CostoIndirecto = 7
            RecursoIndirecto = 8
            RubroIndirecto = 9
            Rubro = 10
            Recurso = 11
            RecursoAnalisis = 12
            Equivalencia = 15
            CostoCronograma = 16
            CostoVarios = 17
            CargoPersonal = 18
            MargenVenta = 19
            VentaEscondida = 20
            CronogramaOferta = 21
            FormulaPolinomica = 22
            Persona = 29
            CostosVarios = 30
            CostosFianza = 31
            CostosContingencia = 32

        End Enum
        Public Enum enumTipoOferta
            Normal = 1
            Tipica = 2
            Prueba = 3
        End Enum
        Public Enum enumEstadoOferta
            Eliminado = 1
            EnTransito = 2
        End Enum
        Public Enum enumMensajes As Integer
            mInterrogativo = 1
            mInformacion = 2
            mExclamacion = 3
            mError = 4
        End Enum
        Public Enum enumCopiarOferta As Integer
            Revision = 0
            Version = 1
        End Enum
        Public Enum enumPrimerValorCombo
            Seleccione = 0
            Todos = 1
            Ninguno = 2
            Vacio = 3
        End Enum
        Public Enum enumOperacionesMantenimiento
            Formatear = 0
            Crear = 1
            Copiar = 2
            Modificar = 3
            Eliminar = 4
            Refrescar = 5
            CargarDatos = 6
            Busqueda = 7
            Transferir = 8
            ImportarCatalogo = 9
            ExportarCatalogo = 10
            Consultar = 11
            RetornarRegistro = 12
            Cancelar = 13
            Grabar = 14
            ErrorCrear = 15
            ErrorModificar = 15
            ErrorEliminar = 16
            CerrarOferta = 17
            ActivarOferta = 18
            ErrorCerrarOferta = 19
            ErrorActivarOferta = 20
            GuardarTodos = 21
            ImportarExcel = 22
            ExportarExcel = 23
            CrearAutomatico = 24
            ErrorActualizar = 25
            ImportarPCdO = 26
            ExportarPCaO = 27
            ImportarPAdO = 28
            ExportarPAaO = 29
            ImportarPAdC = 30
            ExportarPAaC = 31
            CopiarPAaV = 32
            CopiarPCaV = 33
            CopiarAnalisisCPAaPA = 34
            CopiarAnalisisPAaPA = 35
            Insertar = 36
            OfertaSincronizar = 37
            Salir = 38
        End Enum
        Public Enum enumAnalisisAdicionales
            DatosImportacion = 1
            AnalisisEquipos = 2
            MuestraCalculo = 3
            CambioPorcentaje = 4
        End Enum
        Public Enum enumTipoAnalisis
            Directo = 1
            Directo2 = 2
            Directo3 = 3
            Amortizacion = 4
            Especial = 5
        End Enum
        Public Enum enumFormTipo
            Modal = 0
            NoModal = 1
            LibreModal = 2
            LibreNoModal = 3
        End Enum
        Public Enum enumFormMantenimiento
            Principal = 0
            OfertaListado = 1
            Oferta = 2
            OfertaRubro = 3
            OfertaRecursos = 4
            OfertaCopiarRecursos = 5
            OfertaCalcular = 6
            OfertaCopiar = 7
            OfertaMargen = 8
            OfertaCostoVarios = 9
            OfertaFactorVenta = 10
            OfertaVentaEscondida = 11
            OfertaCopiarCatalogoRecursos = 12
            Rubro = 13
            Recurso = 14
            RecursoCambiarPorcentaje = 15
            RecursosCopiardePA = 16
            RecursoAnalisis = 17
            PartidaCliente = 18
            CopiarPartidaClienteaPartidaAnalisis = 19
            PartidaAnalisisCopiardeOfertaMas = 20
            PartidaAnalisis = 21
            PartidaAnalisisCopiardeOferta = 22
            PartidaClienteCopiardeOferta = 23
            CostoIndirecto = 24
            Usuario = 25
            Perfil = 26
            Clientes = 27
            Moneda = 28
            RecursoIndirecto = 29
            RubroIndirecto = 30
            Indice = 31
            Equivalencia = 32
            CostoCronograma = 33
            CostoVarios = 34
            CargoPersonal = 35
            MargenVenta = 36
            VentaEscondida = 37
            FormulaPolinomica = 38
            CostoIndirectoAsociar = 39 '21102007
            RubroCatalogo = 40
            RecursoCatalogo = 41
            RecursosCopiardePC = 42
            RecursosActualizaPrecios = 43
            PartidaClienteCopiar = 44
            CronogramaOferta = 45
            CronogramaRecursosEspeciales = 46
            CronogramaValorizadoPC = 47
            CatalogoPartidaAnalisisCopiarPA = 48
            CatalogoRecursoAnalisis = 49
            IndiceUnificado = 50
            ReportesPartidaAnalisis = 51
            RecursoAsignadoCronograma = 52
            PartidaAnalisisCronograma = 53
            PartidaClienteCronograma = 54
            CostosIndirectosCopiardeCatalogo = 55
            CostosIndirectosCopiardeOferta = 56
            CostoIndirectoCronograma = 57
            IndPrecioUnifConstruccionResumen = 58
            ReporteRecursosResumen = 59
            AyudaRecurso = 60
            AyudaRecursoSelectivo = 61
            PartidaAnalisisCopiarRecursos = 62
            ReporteCostosxFormula = 63
            ReporteFormulaPolinomica = 64
            RecursosCrear = 65
            ReportePresupuestoBase = 66
            ReportesPartidaCliente = 67
            RecursosCronograma = 68
            CatalogoPartidaAnalisis = 69
            Persona = 70
            CatalogoCostoIndirecto = 71
            General = 72
            TipodeCambio = 73
            CatalogodeValoresdeIPUC = 74
            RecursosPrecios = 75
            AnalisisRecursos = 76
            CopiarAnalisisRecursoCatalogo = 77
            CronoValPartidaCliente = 78
            CronoValPartidaAnalisis = 79
            CronoCostoIndirecto = 80
            CronoRecursosAsignados = 81
            ResumenIPUC = 82
            CronogramaRecurso = 83
            OfertaRecursosEspecialRpt = 84
            ReporteCatalogoPartidaAnalisis = 85
            CopiarAnalisisCatalogoRecurso = 86
            ReporteOfertaRecursos = 87
            OfertaRecursosEspecialClienteRpt = 88
            CopiarAnalisisdeCatalogoPartidaAnalisis = 89
            OfertaCopíade = 90
            RecursosCopiarAnalisis = 91
            RecursoAnalisisD1 = 92
            RecursoAnalisisAM = 93
            RecursoAnalisisES = 94
            PartidasResumen = 95
            OfertaListadoSPODown = 96
            OfertaBackup = 97
            OfertaSincronizar = 98
        End Enum
        Public Enum enumCampoValor
            Valor1 = 1
            Valor2 = 2
            Valor3 = 3
            Valor4 = 4
            Valor5 = 5
            Valor6 = 6
            Valor7 = 7
            Valor8 = 8
            Valor9 = 9
            Valor10 = 10
            Valor11 = 11
            Valor12 = 12
        End Enum
        Public Enum enumEstadoGeneral
            Activo = 68
            Inactivo = 69
            Predeterminado = 232
        End Enum
        Public Enum enumCalculoIndice
            tipo_calculo = 1
            numero_orden_ini = 0
            numero_orden_fin = 0
            cod_formula_polinomica_ini = 0
            cod_formula_polinomica_fin = 0
        End Enum
#End Region
    End Class

End Namespace
