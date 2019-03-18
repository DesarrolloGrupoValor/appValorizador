<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mezcla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mezcla))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmblotes = New C1.Win.C1List.C1Combo()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbmodo = New System.Windows.Forms.ComboBox()
        Me.txtCorrelativo = New CUTextbox()
        Me.C1FlexDataTree1 = New C1FlexDataTree()
        CType(Me.cmblotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexDataTree1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(865, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "LOTE"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1043, 21)
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(588, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Modo"
        '
        'cmbmodo
        '
        Me.cmbmodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmodo.FormattingEnabled = True
        Me.cmbmodo.Location = New System.Drawing.Point(628, 24)
        Me.cmbmodo.Name = "cmbmodo"
        Me.cmbmodo.Size = New System.Drawing.Size(217, 21)
        Me.cmbmodo.TabIndex = 29
        '
        'txtCorrelativo
        '
        Me.txtCorrelativo.AutoFormat = CUTextbox.AUTOFORMATO_CONFIGURACION.None
        Me.txtCorrelativo.Location = New System.Drawing.Point(904, 23)
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
        'C1FlexDataTree1
        '
        Me.C1FlexDataTree1.ColumnInfo = "10,1,0,0,0,95,Columns:0{Width:38;Style:""ImageAlign:RightCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.C1FlexDataTree1.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw
        Me.C1FlexDataTree1.Location = New System.Drawing.Point(12, 81)
        Me.C1FlexDataTree1.Name = "C1FlexDataTree1"
        Me.C1FlexDataTree1.Rows.DefaultSize = 19
        Me.C1FlexDataTree1.Size = New System.Drawing.Size(1143, 393)
        Me.C1FlexDataTree1.TabIndex = 0
        '
        'Mezcla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1167, 501)
        Me.Controls.Add(Me.cmbmodo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmblotes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCorrelativo)
        Me.Controls.Add(Me.C1FlexDataTree1)
        Me.Name = "Mezcla"
        Me.Text = "Mezcla"
        CType(Me.cmblotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexDataTree1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1FlexDataTree1 As C1FlexDataTree
    Friend WithEvents txtCorrelativo As CUTextbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmblotes As C1.Win.C1List.C1Combo
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbmodo As System.Windows.Forms.ComboBox
End Class
