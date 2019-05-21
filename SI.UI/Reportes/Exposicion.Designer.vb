<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exposicion
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbcomprador = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbcalidad = New System.Windows.Forms.ComboBox()
        Me.C1FlexDataTree1 = New C1FlexDataTree()
        CType(Me.C1FlexDataTree1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(832, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbcomprador
        '
        Me.cmbcomprador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcomprador.FormattingEnabled = True
        Me.cmbcomprador.Location = New System.Drawing.Point(97, 26)
        Me.cmbcomprador.Name = "cmbcomprador"
        Me.cmbcomprador.Size = New System.Drawing.Size(121, 21)
        Me.cmbcomprador.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "EMPRESA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(262, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "CALIDAD"
        '
        'cmbcalidad
        '
        Me.cmbcalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcalidad.FormattingEnabled = True
        Me.cmbcalidad.Location = New System.Drawing.Point(332, 26)
        Me.cmbcalidad.Name = "cmbcalidad"
        Me.cmbcalidad.Size = New System.Drawing.Size(174, 21)
        Me.cmbcalidad.TabIndex = 31
        '
        'C1FlexDataTree1
        '
        Me.C1FlexDataTree1.ColumnInfo = "10,1,0,0,0,95,Columns:0{Width:38;Style:""ImageAlign:RightCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.C1FlexDataTree1.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw
        Me.C1FlexDataTree1.Location = New System.Drawing.Point(12, 95)
        Me.C1FlexDataTree1.Name = "C1FlexDataTree1"
        Me.C1FlexDataTree1.Rows.DefaultSize = 19
        Me.C1FlexDataTree1.Size = New System.Drawing.Size(1143, 369)
        Me.C1FlexDataTree1.TabIndex = 0
        '
        'Exposicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 501)
        Me.Controls.Add(Me.cmbcalidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbcomprador)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.C1FlexDataTree1)
        Me.Name = "Exposicion"
        Me.Text = "Exposicion"
        CType(Me.C1FlexDataTree1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1FlexDataTree1 As C1FlexDataTree
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbcomprador As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbcalidad As System.Windows.Forms.ComboBox
End Class
