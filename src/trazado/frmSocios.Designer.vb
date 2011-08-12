<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSocios
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
    Public WithEvents tablaPesos As System.Windows.Forms.DataGridView
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents cmdBuscar As System.Windows.Forms.Button
    Public WithEvents nombreCostxt As System.Windows.Forms.TextBox
    Public WithEvents _Toolbar1_Button1 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button2 As System.Windows.Forms.ToolStripButton
    Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
    Public WithEvents chkAll As System.Windows.Forms.CheckBox
    Public WithEvents fechafin As System.Windows.Forms.DateTimePicker
    Public WithEvents fechaini As System.Windows.Forms.DateTimePicker
    Public WithEvents ComboCodigos As System.Windows.Forms.ComboBox
    Public WithEvents totalKilos As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents niftxt As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.tablaPesos = New System.Windows.Forms.DataGridView()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.listaVar = New System.Windows.Forms.ListView()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.nombreCostxt = New System.Windows.Forms.TextBox()
        Me.Toolbar1 = New System.Windows.Forms.ToolStrip()
        Me._Toolbar1_Button1 = New System.Windows.Forms.ToolStripButton()
        Me._Toolbar1_Button2 = New System.Windows.Forms.ToolStripButton()
        Me.btnCerrar = New System.Windows.Forms.ToolStripButton()
        Me.chkAll = New System.Windows.Forms.CheckBox()
        Me.fechafin = New System.Windows.Forms.DateTimePicker()
        Me.fechaini = New System.Windows.Forms.DateTimePicker()
        Me.ComboCodigos = New System.Windows.Forms.ComboBox()
        Me.totalKilos = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.niftxt = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OleosigDB1 = New Oleosig.oleosigDB()
        Me.Frame2.SuspendLayout()
        CType(Me.tablaPesos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.Toolbar1.SuspendLayout()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame2
        '
        Me.Frame2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.tablaPesos)
        Me.Frame2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Frame2.Location = New System.Drawing.Point(12, 210)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(540, 193)
        Me.Frame2.TabIndex = 19
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Tickets por cosechero"
        '
        'tablaPesos
        '
        Me.tablaPesos.AllowUserToAddRows = False
        Me.tablaPesos.AllowUserToDeleteRows = False
        Me.tablaPesos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tablaPesos.Location = New System.Drawing.Point(8, 24)
        Me.tablaPesos.Name = "tablaPesos"
        Me.tablaPesos.ReadOnly = True
        Me.tablaPesos.RowHeadersVisible = False
        Me.tablaPesos.Size = New System.Drawing.Size(494, 139)
        Me.tablaPesos.TabIndex = 20
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.listaVar)
        Me.Frame1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Frame1.Location = New System.Drawing.Point(704, 48)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(258, 138)
        Me.Frame1.TabIndex = 16
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Variedades"
        '
        'listaVar
        '
        Me.listaVar.BackColor = System.Drawing.SystemColors.Window
        Me.listaVar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listaVar.CheckBoxes = True
        Me.listaVar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listaVar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.listaVar.FullRowSelect = True
        Me.listaVar.GridLines = True
        Me.listaVar.Location = New System.Drawing.Point(16, 28)
        Me.listaVar.Name = "listaVar"
        Me.listaVar.Size = New System.Drawing.Size(228, 97)
        Me.listaVar.TabIndex = 19
        Me.listaVar.UseCompatibleStateImageBehavior = False
        Me.listaVar.View = System.Windows.Forms.View.Details
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBuscar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBuscar.Location = New System.Drawing.Point(640, 56)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBuscar.Size = New System.Drawing.Size(41, 25)
        Me.cmdBuscar.TabIndex = 15
        Me.cmdBuscar.Text = "..."
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'nombreCostxt
        '
        Me.nombreCostxt.AcceptsReturn = True
        Me.nombreCostxt.BackColor = System.Drawing.SystemColors.Window
        Me.nombreCostxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nombreCostxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nombreCostxt.Location = New System.Drawing.Point(240, 56)
        Me.nombreCostxt.MaxLength = 0
        Me.nombreCostxt.Name = "nombreCostxt"
        Me.nombreCostxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nombreCostxt.Size = New System.Drawing.Size(386, 22)
        Me.nombreCostxt.TabIndex = 14
        '
        'Toolbar1
        '
        Me.Toolbar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._Toolbar1_Button1, Me._Toolbar1_Button2, Me.btnCerrar})
        Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar1.Name = "Toolbar1"
        Me.Toolbar1.Size = New System.Drawing.Size(978, 44)
        Me.Toolbar1.TabIndex = 13
        '
        '_Toolbar1_Button1
        '
        Me._Toolbar1_Button1.AutoSize = False
        Me._Toolbar1_Button1.Image = Global.Oleosig.My.Resources.Resources.x_office_spreadsheet
        Me._Toolbar1_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button1.Name = "_Toolbar1_Button1"
        Me._Toolbar1_Button1.Size = New System.Drawing.Size(65, 41)
        Me._Toolbar1_Button1.Text = "Ver Datos"
        Me._Toolbar1_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        '_Toolbar1_Button2
        '
        Me._Toolbar1_Button2.AutoSize = False
        Me._Toolbar1_Button2.Image = Global.Oleosig.My.Resources.Resources.document
        Me._Toolbar1_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button2.Name = "_Toolbar1_Button2"
        Me._Toolbar1_Button2.Size = New System.Drawing.Size(65, 41)
        Me._Toolbar1_Button2.Text = "Ver Informe"
        Me._Toolbar1_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnCerrar
        '
        Me.btnCerrar.AutoSize = False
        Me.btnCerrar.Image = Global.Oleosig.My.Resources.Resources.dialog_close
        Me.btnCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(65, 41)
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.BackColor = System.Drawing.SystemColors.Control
        Me.chkAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.chkAll.Location = New System.Drawing.Point(444, 135)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAll.Size = New System.Drawing.Size(132, 20)
        Me.chkAll.TabIndex = 11
        Me.chkAll.Text = "Todas las fechas"
        Me.chkAll.UseVisualStyleBackColor = False
        '
        'fechafin
        '
        Me.fechafin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechafin.Location = New System.Drawing.Point(333, 131)
        Me.fechafin.Name = "fechafin"
        Me.fechafin.Size = New System.Drawing.Size(94, 22)
        Me.fechafin.TabIndex = 8
        '
        'fechaini
        '
        Me.fechaini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaini.Location = New System.Drawing.Point(117, 131)
        Me.fechaini.Name = "fechaini"
        Me.fechaini.Size = New System.Drawing.Size(94, 22)
        Me.fechaini.TabIndex = 5
        '
        'ComboCodigos
        '
        Me.ComboCodigos.BackColor = System.Drawing.SystemColors.Window
        Me.ComboCodigos.Cursor = System.Windows.Forms.Cursors.Default
        Me.ComboCodigos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboCodigos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ComboCodigos.Location = New System.Drawing.Point(76, 56)
        Me.ComboCodigos.Name = "ComboCodigos"
        Me.ComboCodigos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboCodigos.Size = New System.Drawing.Size(93, 24)
        Me.ComboCodigos.TabIndex = 2
        Me.ComboCodigos.Text = "Código"
        '
        'totalKilos
        '
        Me.totalKilos.BackColor = System.Drawing.SystemColors.Window
        Me.totalKilos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalKilos.Cursor = System.Windows.Forms.Cursors.Default
        Me.totalKilos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.totalKilos.Location = New System.Drawing.Point(309, 94)
        Me.totalKilos.Name = "totalKilos"
        Me.totalKilos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.totalKilos.Size = New System.Drawing.Size(103, 22)
        Me.totalKilos.TabIndex = 10
        Me.totalKilos.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(202, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(107, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Kilos Aceituna :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(228, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(91, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Fecha Final :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(6, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(98, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Fecha Inicial :"
        '
        'niftxt
        '
        Me.niftxt.BackColor = System.Drawing.SystemColors.Window
        Me.niftxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.niftxt.Cursor = System.Windows.Forms.Cursors.Default
        Me.niftxt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.niftxt.Location = New System.Drawing.Point(76, 94)
        Me.niftxt.Name = "niftxt"
        Me.niftxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.niftxt.Size = New System.Drawing.Size(103, 22)
        Me.niftxt.TabIndex = 4
        Me.niftxt.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(6, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(37, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "NIF :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(6, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Numero :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(176, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre :"
        '
        'OleosigDB1
        '
        Me.OleosigDB1.DataSetName = "oleosigDB"
        Me.OleosigDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmSocios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(978, 415)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.nombreCostxt)
        Me.Controls.Add(Me.Toolbar1)
        Me.Controls.Add(Me.chkAll)
        Me.Controls.Add(Me.fechafin)
        Me.Controls.Add(Me.fechaini)
        Me.Controls.Add(Me.ComboCodigos)
        Me.Controls.Add(Me.totalKilos)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.niftxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "frmSocios"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Cosecheros"
        Me.Frame2.ResumeLayout(False)
        CType(Me.tablaPesos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Toolbar1.ResumeLayout(False)
        Me.Toolbar1.PerformLayout()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents listaVar As System.Windows.Forms.ListView
    Friend WithEvents btnCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents OleosigDB1 As Oleosig.oleosigDB
#End Region
End Class