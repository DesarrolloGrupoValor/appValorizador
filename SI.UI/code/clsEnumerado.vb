Imports Microsoft.VisualBasic
Namespace SI.PL
    Public Class clsEnumerado
        Public Enum enumPrimerValorCombo
            Seleccione = 0
            Todos = 1
            Ninguno = 2
            Vacio = 3
        End Enum
       
        Public Enum enumTipoComboGrilla
            IdDescripcion = 0
            IdCodigo = 1
            IDDescripcionCodigo = 2
            IDCodigoDescripcion = 3
        End Enum
        Public Enum enumTipoOperacion
            Nuevo = 0
            Modificar = 1
            Grabar = 2
            Cancelar = 3
            Eliminar = 4
        End Enum
        Public Enum enumTipoCorrelativo
            Contrato = 0
            Lote = 1
            Liquidacion = 2
        End Enum
        Public Enum enumTipoFormulario
            Contrato = 0
            Lote = 1
            TablaDetalle = 2
            NuevoContrato = 3
            EditarContrato = 4
            Configuracion = 5
            CopiarContrato = 5
        End Enum
    End Class
End Namespace



