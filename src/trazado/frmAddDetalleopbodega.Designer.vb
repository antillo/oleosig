<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAddDetalleopbodega
#Region "Código generado por el Diseñador de Windows Forms "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Llamada necesaria para el Diseñador de Windows Forms.
		InitializeComponent()
		
	End Sub
	'Form invalida a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents rendtxt As System.Windows.Forms.MaskedTextBox
	Public WithEvents kilosaceitetxt As System.Windows.Forms.TextBox
	Public WithEvents kilosmasatxt As System.Windows.Forms.TextBox
	Public WithEvents moltTxt As System.Windows.Forms.TextBox
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.rendtxt = New System.Windows.Forms.MaskedTextBox()
        Me.kilosaceitetxt = New System.Windows.Forms.TextBox()
        Me.kilosmasatxt = New System.Windows.Forms.TextBox()
        Me.moltTxt = New System.Windows.Forms.TextBox()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rendtxt
        '
        Me.rendtxt.AllowPromptAsInput = False
        Me.rendtxt.Location = New System.Drawing.Point(152, 80)
        Me.rendtxt.Mask = "##,##"
        Me.rendtxt.Name = "rendtxt"
        Me.rendtxt.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.rendtxt.Size = New System.Drawing.Size(81, 20)
        Me.rendtxt.TabIndex = 3
        '
        'kilosaceitetxt
        '
        Me.kilosaceitetxt.AcceptsReturn = True
        Me.kilosaceitetxt.BackColor = System.Drawing.SystemColors.Window
        Me.kilosaceitetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kilosaceitetxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.kilosaceitetxt.Location = New System.Drawing.Point(152, 112)
        Me.kilosaceitetxt.MaxLength = 0
        Me.kilosaceitetxt.Name = "kilosaceitetxt"
        Me.kilosaceitetxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.kilosaceitetxt.Size = New System.Drawing.Size(81, 20)
        Me.kilosaceitetxt.TabIndex = 4
        Me.kilosaceitetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'kilosmasatxt
        '
        Me.kilosmasatxt.AcceptsReturn = True
        Me.kilosmasatxt.BackColor = System.Drawing.SystemColors.Window
        Me.kilosmasatxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kilosmasatxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.kilosmasatxt.Location = New System.Drawing.Point(152, 48)
        Me.kilosmasatxt.MaxLength = 0
        Me.kilosmasatxt.Name = "kilosmasatxt"
        Me.kilosmasatxt.ReadOnly = True
        Me.kilosmasatxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.kilosmasatxt.Size = New System.Drawing.Size(81, 20)
        Me.kilosmasatxt.TabIndex = 2
        Me.kilosmasatxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'moltTxt
        '
        Me.moltTxt.AcceptsReturn = True
        Me.moltTxt.BackColor = System.Drawing.SystemColors.Window
        Me.moltTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.moltTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.moltTxt.Location = New System.Drawing.Point(152, 16)
        Me.moltTxt.MaxLength = 0
        Me.moltTxt.Name = "moltTxt"
        Me.moltTxt.ReadOnly = True
        Me.moltTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.moltTxt.Size = New System.Drawing.Size(81, 20)
        Me.moltTxt.TabIndex = 1
        Me.moltTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(172, 160)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(81, 33)
        Me.Command2.TabIndex = 6
        Me.Command2.Text = "Cerrar"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(60, 160)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(81, 33)
        Me.Command1.TabIndex = 5
        Me.Command1.Text = "Aceptar"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(72, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(69, 14)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Kilos Aceite :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(72, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(71, 14)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Rendimiento :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(72, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(80, 14)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Kilos de Masa :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(72, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(68, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Molturación :"
        '
        'frmAddDetalleopbodega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(312, 206)
        Me.ControlBox = False
        Me.Controls.Add(Me.rendtxt)
        Me.Controls.Add(Me.kilosaceitetxt)
        Me.Controls.Add(Me.kilosmasatxt)
        Me.Controls.Add(Me.moltTxt)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddDetalleopbodega"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Añadir Detalle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region 
End Class