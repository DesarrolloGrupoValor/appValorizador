<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComposicionVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComposicionVentas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmblotes = New C1.Win.C1List.C1Combo()
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.C1FlexDataTree1 = New C1FlexDataTree()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.fxgrdGrilla = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.txtCorrelativo = New CUTextbox()
        CType(Me.cmblotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.C1FlexDataTree1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.fxgrdGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(620, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "LOTE"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(798, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbTipo
        '
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(53, 23)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipo.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "TIPO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(190, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "LISTA LOTES"
        '
        'cmblotes
        '
        Me.cmblotes.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmblotes.Caption = ""
        Me.cmblotes.CaptionHeight = 17
        Me.cmblotes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmblotes.ColumnCaptionHeight = 17
        Me.cmblotes.ColumnFooterHeight = 17
        Me.cmblotes.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmblotes.ContentHeight = 15
        Me.cmblotes.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmblotes.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmblotes.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmblotes.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmblotes.EditorHeight = 15
        Me.cmblotes.Images.Add(CType(resources.GetObject("cmblotes.Images"), System.Drawing.Image))
        Me.cmblotes.ItemHeight = 15
        Me.cmblotes.Location = New System.Drawing.Point(284, 24)
        Me.cmblotes.MatchEntryTimeout = CType(2000, Long)
        Me.cmblotes.MaxDropDownItems = CType(5, Short)
        Me.cmblotes.MaxLength = 32767
        Me.cmblotes.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmblotes.Name = "cmblotes"
        Me.cmblotes.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmblotes.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmblotes.Size = New System.Drawing.Size(287, 21)
        Me.cmblotes.TabIndex = 27
        Me.cmblotes.Text = "C1Combo1"
        Me.cmblotes.PropBag = resources.GetString("cmblotes.PropBag")
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1FlexGrid1.ColumnInfo = "10,1,0,0,0,95,Columns:"
        Me.C1FlexGrid1.Location = New System.Drawing.Point(12, 50)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.DefaultSize = 19
        Me.C1FlexGrid1.Size = New System.Drawing.Size(1004, 104)
        Me.C1FlexGrid1.TabIndex = 28
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 170)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1007, 323)
        Me.TabControl1.TabIndex = 29
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.C1FlexDataTree1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(999, 297)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Niveles"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'C1FlexDataTree1
        '
        Me.C1FlexDataTree1.ColumnInfo = "10,1,0,0,0,95,Columns:0{Width:38;Style:""ImageAlign:RightCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.C1FlexDataTree1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1FlexDataTree1.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw
        Me.C1FlexDataTree1.Location = New System.Drawing.Point(3, 3)
        Me.C1FlexDataTree1.Name = "C1FlexDataTree1"
        Me.C1FlexDataTree1.Rows.DefaultSize = 19
        Me.C1FlexDataTree1.Size = New System.Drawing.Size(993, 291)
        Me.C1FlexDataTree1.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.fxgrdGrilla)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1138, 297)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Grilla"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'fxgrdGrilla
        '
        Me.fxgrdGrilla.AllowEditing = False
        Me.fxgrdGrilla.AllowFiltering = True
        Me.fxgrdGrilla.ColumnInfo = "10,1,0,0,0,95,Columns:0{AllowFiltering:ByValue;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fxgrdGrilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fxgrdGrilla.Location = New System.Drawing.Point(3, 3)
        Me.fxgrdGrilla.Name = "fxgrdGrilla"
        Me.fxgrdGrilla.Rows.Count = 2
        Me.fxgrdGrilla.Rows.DefaultSize = 19
        Me.fxgrdGrilla.Size = New System.Drawing.Size(1132, 291)
        Me.fxgrdGrilla.TabIndex = 1
        '
        'txtCorrelativo
        '
        Me.txtCorrelativo.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtCorrelativo.Location = New System.Drawing.Point(659, 23)
        Me.txtCorrelativo.MandatoryColor = System.Drawing.Color.Empty
        Me.txtCorrelativo.MandatoryField = False
        Me.txtCorrelativo.Name = "txtCorrelativo"
        Me.txtCorrelativo.Size = New System.Drawing.Size(120, 20)
        Me.txtCorrelativo.TabIndex = 21
        Me.txtCorrelativo.Text = "0"
        Me.txtCorrelativo.VCM_ColorPerderFoco = System.Drawing.Color.Empty
        Me.txtCorrelativo.VCM_ColorRecibirFoco = System.Drawing.Color.Empty
        Me.txtCorrelativo.VCM_CustomInputTypeString = Nothing
        Me.txtCorrelativo.VCM_CustomOmmitString = Nothing
        Me.txtCorrelativo.VCM_EnterFocus = True
        Me.txtCorrelativo.VCM_IsValidated = True
        Me.txtCorrelativo.VCM_MensajeFoco = Nothing
        Me.txtCorrelativo.VCM_MuestraMensajeFoco = False
        Me.txtCorrelativo.VCM_NumeroPrecision = CUTextbox.PRECISION_CONFIGURACION.CuatroDecimales
        Me.txtCorrelativo.VCM_RegularExpression = Nothing
        Me.txtCorrelativo.VCM_RegularExpressionErrorMessage = Nothing
        Me.txtCorrelativo.VCM_ShowMessage = True
        Me.txtCorrelativo.VCM_TipoIngreso = CUTextbox.TIPO_CONFIGURACION.NumeroDecimal
        '
        'ComposicionVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 501)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.C1FlexGrid1)
        Me.Controls.Add(Me.cmblotes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCorrelativo)
        Me.Name = "ComposicionVentas"
        Me.Text = "Composicion de Ventas"
        CType(Me.cmblotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.C1FlexDataTree1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.fxgrdGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCorrelativo As CUTextbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmblotes As C1.Win.C1List.C1Combo
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents C1FlexDataTree1 As C1FlexDataTree
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents fxgrdGrilla As C1.Win.C1FlexGrid.C1FlexGrid
End Class
