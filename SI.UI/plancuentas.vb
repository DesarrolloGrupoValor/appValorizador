
Imports SI.BC
Imports SI.PL.clsFuncion
Imports SI.PL.clsProcedimientos
Imports SI.PL.clsEnumerado
Imports SI.PL.clsGeneral
Imports SI.UT
Imports System.Data
Imports System.Drawing.Drawing2D

Public Class plancuentas
    Private oTablaDetRO As New clsBC_TablaDetRO
    Private dvwDatos As DataView
    Private lblnEditando As Boolean
    Private lblnNuevo As Boolean
    Private strTitulo1 As String
    Private strTitulo2 As String
    Private strTitulo3 As String
    Private strTitulo4 As String
    Private strTitulo5 As String
    Private strTitulo6 As String
    Private strTitulo7 As String
    Private strTitulo8 As String
    Private strTitulo9 As String
    Private strTitulo10 As String
    Private strTitulo11 As String
    Private strTitulo12 As String
    Private strTitulo13 As String
    Private strTitulo14 As String
    Private strTitulo15 As String
    Private strTitulo16 As String
    Private strTitulo17 As String
    Private strTitulo18 As String
    Private strTitulo19 As String
    Private strTitulo20 As String
    Private strTabla As String = "PlanCuentas"
    Private Sub frmTabla_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim dsdatos As DataSet
        'Dim dvwDatos As DataView
        'dsdatos = oUsuarioRO.LeerListaToDSusuario
        'dvwDatos = New DataView(dsdatos.Tables(0))
        'tdbgMantenimiento.DataSource = dvwDatos
        ConfiguraForm(Me)
        CargarRegistros()



        txt1.MaxLength = 200
        txt2.MaxLength = 200
       

    End Sub
 

    Private Sub CargarRegistros()

        oTablaDetRO.oBETablaDet.tablaId = strTabla
        'oTablaDetRO.oBETablaDet.tablaId = CType(cboTabla.SelectedValue, SI.BE.clsBE_General).Id_Retorna
        dvwDatos = New DataView(oTablaDetRO.LeerListaToDSTablaDet.Tables(0))
        dgvMantenimiento.AutoGenerateColumns = False
        dgvMantenimiento.DataSource = dvwDatos
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case keyData
            Case Keys.Escape
                If Not lblnEditando Then
                    Me.Dispose()
                Else
                    btnCancelar_Click(Nothing, Nothing)
                End If
            Case Keys.Control + Keys.G
                If lblnEditando Then
                    btnGuardar_Click(Nothing, Nothing)
                End If
        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)

    End Function
    Private Sub EditandoRegistro()
        lblnEditando = Not lblnEditando
        tsMantenimiento.Enabled = Not lblnEditando
        msMantenimiento.Enabled = Not lblnEditando
        tbcEditar.Visible = lblnEditando
        'gpoTabla.Enabled = Not lblnEditando
        dgvMantenimiento.Enabled = Not lblnEditando
        oTablaDetRO.oBETablaDet.tablaId = "Titulos"
        oTablaDetRO.oBETablaDet.tablaDetId = strTabla
        oTablaDetRO.LeerTablaDet()
        'lbl1.Visible = False : txt1.Visible = False
        'lbl2.Visible = False : txt2.Visible = False
       
        If oTablaDetRO.oBETablaDet.campo0 <> "" Then
            With oTablaDetRO.oBETablaDet
                If .campo0 <> "" Then lbl1.Text = .campo0 : lbl1.Visible = True : txt1.Visible = True : strTitulo1 = .campo1
                If .campo1 <> "" Then lbl2.Text = .campo1 : lbl2.Visible = True : txt2.Visible = True : strTitulo2 = .campo2
              
            End With
        End If
        If lblnEditando Then
            If lblnNuevo Then
                'txtCodigo.Enabled = True
                'txtDescripcion.Enabled = True
                txt0.Focus()
            Else
                Dim drow As DataGridViewRow = dgvMantenimiento.CurrentRow
                ' dgvMantenimiento.Rows(dgvMantenimiento.RowSel).Item("tabladetid")
                txtCodigo.Text = drow.Cells("tabladetid").Value
                txtDescripcion.Text = drow.Cells("descri").Value
                txt0.Text = drow.Cells("campo0").Value
                txt1.Text = drow.Cells("campo1").Value
                txt2.Text = drow.Cells("campo2").Value
              

                'txt0.Enabled = False
                txtDescripcion.Enabled = True
                txtDescripcion.Focus()
            End If
        End If

    End Sub
    Private Sub OperacionRegistro(ByVal operacion As enumTipoOperacion)
        lblnNuevo = False
        Select Case operacion
            Case enumTipoOperacion.Nuevo
                txtCodigo.Text = ""
                txtDescripcion.Text = ""
                txt0.Text = ""
                txt1.Text = ""
                txt2.Text = ""
                lblnNuevo = True
                EditandoRegistro()
            Case enumTipoOperacion.Modificar

                EditandoRegistro()
            Case enumTipoOperacion.Grabar
                EditandoRegistro()
            Case enumTipoOperacion.Eliminar

            Case enumTipoOperacion.Cancelar
                EditandoRegistro()
        End Select
    End Sub

    Private Sub tsbNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNuevo.Click, tsmNuevo.Click
        OperacionRegistro(enumTipoOperacion.Nuevo)

    End Sub

    Private Sub tsbModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModificar.Click, tsmModificar.Click
        OperacionRegistro(enumTipoOperacion.Modificar)

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click, tsmGuardar.Click
        If MsgBox("Esta seguro de guardar el registro", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then
            If Not ValidaRegistro() Then Exit Sub
            If lblnNuevo Then
                'If RegistroExiste(cboTabla.SelectedValue, txtCodigo.Text) Then
                '    MsgBox("Codigo ya existe, verifique porfavor.")
                '    Exit Sub
                'End If
            End If
            If GrabarRegistro() Then
                MsgBox("Registro Guardado correctamente.")
                CargarRegistros()
                OperacionRegistro(enumTipoOperacion.Grabar)
            Else
                MsgBox("Hubo errores al actualizar/insertar el registro.")
            End If
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click, tsmCancelar.Click
        OperacionRegistro(enumTipoOperacion.Cancelar)

    End Sub
    Private Function ValidaRegistro()
        Dim strmensaje As String = ""

        'If String.IsNullOrEmpty(txtCodigo.Text) Then
        '    strmensaje = strmensaje & "* Ingrese Codigo" & vbCrLf
        '    resaltarobjecto(txtCodigo)
        'End If
        If String.IsNullOrEmpty(txtDescripcion.Text) Then
            strmensaje = strmensaje & "* Ingrese Descripcion" & vbCrLf
            resaltarobjecto(txtDescripcion)
        End If
        If strmensaje.Length > 0 Then
            MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Valorizador de Minerales")
            Return False
        End If
        'If lblnNuevo Then
        '    If RegistroExiste(strTabla, txtCodigo.Text) Then
        '        MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Cuenta ya registrada.")
        '        Return False
        '    End If
        'End If
        Return True
    End Function
    Private Function GrabarRegistro()
        Dim oTablaDetTX As New clsBC_TablaDetTX
        With oTablaDetTX.oBETablaDet
            .tablaId = strTabla
            .tablaDetId = txtCodigo.Text
            .descri = txtDescripcion.Text
            .campo0 = txt0.Text
            .campo1 = txt1.Text
            .campo2 = txt2.Text
          
            .codigoEstado = TABLA_DE_ESTADOS.ACTIVO.Value
            '.indicador = True
            .uc = pBEUsuario.tablaDetId
            .um = pBEUsuario.tablaDetId
            oTablaDetTX.LstTablaDet.Add(oTablaDetTX.oBETablaDet)
        End With
        If lblnNuevo Then
            Return oTablaDetTX.InsertarTablaDet()
        Else

            Return oTablaDetTX.ModificarTablaDet()
        End If

    End Function
    Private Function RegistroExiste(ByVal tablaid As String, ByVal tabladetid As String)
        Dim oTablaDetRO As New clsBC_TablaDetRO
        With oTablaDetRO.oBETablaDet
            .tablaId = tablaid
            .tablaDetId = tabladetid
        End With
        oTablaDetRO.LeerTablaDet()
        If String.IsNullOrEmpty(oTablaDetRO.oBETablaDet.descri) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub frmTabla_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim BaseRectangle As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)

        Dim Gradient_Brush As New LinearGradientBrush(BaseRectangle, SI.PL.clsGeneral.ColorForm, Color.White, LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(Gradient_Brush, BaseRectangle)
    End Sub

    Private Sub tsmSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmSalir.Click, tsbSalir.Click
        Me.Dispose()
    End Sub

    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click
        Dim oTablaDetTX As New clsBC_TablaDetTX
        If dgvMantenimiento.Rows.Count > 0 Then
            If MsgBox("Esta seguro de eliminar el Registro Seleccionado", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then
                With (oTablaDetTX.oBETablaDet)
                    .tablaId = strTabla
                    .tablaDetId = dgvMantenimiento.CurrentRow.Cells("tabladetid").Value
                    ' tdbgMantenimiento.Splits(0).Rows.
                    oTablaDetTX.LstTablaDet.Add(oTablaDetTX.oBETablaDet)
                End With

                oTablaDetTX.EliminarTablaDet()
                CargarRegistros()
            End If
        End If
    End Sub
    Private Shared Sub resaltarobjecto(ByVal txt As TextBox)
        If txt.BackColor <> Color.Orange Then
            txt.BackColor = Color.Khaki
        Else
            txt.BackColor = Color.White
        End If
    End Sub
    Private Shared Sub resaltarobjecto(ByVal cbo As ComboBox)
        If cbo.BackColor <> Color.Orange Then
            cbo.BackColor = Color.Khaki
        Else
            cbo.BackColor = Color.White
        End If
    End Sub
    Private Shared Sub resaltarobjecto(ByVal nupd As NumericUpDown)
        If nupd.BackColor <> Color.Orange Then
            nupd.BackColor = Color.Khaki
        Else
            nupd.BackColor = Color.White
        End If
    End Sub

    Private Sub txt1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1.TextChanged

    End Sub
End Class