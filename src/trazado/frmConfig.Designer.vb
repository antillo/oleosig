<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmConfig
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
	Public WithEvents cmdGuardar As System.Windows.Forms.Button
	Public WithEvents cmdCerrar As System.Windows.Forms.Button
	Public WithEvents regsantxt As System.Windows.Forms.TextBox
	Public WithEvents regagtxt As System.Windows.Forms.TextBox
    Public WithEvents decantersTxt As System.Windows.Forms.TextBox
    Public WithEvents ciftxt As System.Windows.Forms.TextBox
    Public WithEvents emailtxt As System.Windows.Forms.TextBox
    Public WithEvents telefonotxt As System.Windows.Forms.TextBox
    Public WithEvents direcciontxt As System.Windows.Forms.TextBox
    Public WithEvents nombretxt As System.Windows.Forms.TextBox
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents _SSTab1_TabPage0 As System.Windows.Forms.TabPage
    Public WithEvents _SSTab1_TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents _SSTab1_TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents _SSTab1_TabPage3 As System.Windows.Forms.TabPage
    Public WithEvents _SSTab1_TabPage4 As System.Windows.Forms.TabPage
    Public WithEvents _SSTab1_TabPage6 As System.Windows.Forms.TabPage
    Public WithEvents SSTab1 As System.Windows.Forms.TabControl
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.SSTab1 = New System.Windows.Forms.TabControl()
        Me._SSTab1_TabPage0 = New System.Windows.Forms.TabPage()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.AlmazaraBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.CmbPesaje = New System.Windows.Forms.ComboBox()
        Me.pesajeBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.OleosigDB1 = New Oleosig.oleosigDB()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.provinciaTxt = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PoblacionTxt = New System.Windows.Forms.TextBox()
        Me.cpTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.batTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.centrtxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.regsantxt = New System.Windows.Forms.TextBox()
        Me.regagtxt = New System.Windows.Forms.TextBox()
        Me.decantersTxt = New System.Windows.Forms.TextBox()
        Me.ciftxt = New System.Windows.Forms.TextBox()
        Me.emailtxt = New System.Windows.Forms.TextBox()
        Me.telefonotxt = New System.Windows.Forms.TextBox()
        Me.direcciontxt = New System.Windows.Forms.TextBox()
        Me.nombretxt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._SSTab1_TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.VariedadesDataGridView = New System.Windows.Forms.DataGridView()
        Me.VarcodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarnombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VariedadesBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me._SSTab1_TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TolvasDataGridView = New System.Windows.Forms.DataGridView()
        Me.NumeroDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapacidadDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TolvasBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me._SSTab1_TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.AclaradoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.NumeroDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapacidadDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AclaradoresBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me._SSTab1_TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TanquesDataGridView = New System.Windows.Forms.DataGridView()
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapacidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanquesBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me._SSTab1_TabPage6 = New System.Windows.Forms.TabPage()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.CalidadesDataGridView = New System.Windows.Forms.DataGridView()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalidadesBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.MarcasDataGridView = New System.Windows.Forms.DataGridView()
        Me.CodigoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcasBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.SSTab1.SuspendLayout()
        Me._SSTab1_TabPage0.SuspendLayout()
        CType(Me.AlmazaraBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pesajeBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._SSTab1_TabPage1.SuspendLayout()
        CType(Me.VariedadesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VariedadesBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._SSTab1_TabPage2.SuspendLayout()
        CType(Me.TolvasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TolvasBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._SSTab1_TabPage3.SuspendLayout()
        CType(Me.AclaradoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AclaradoresBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._SSTab1_TabPage4.SuspendLayout()
        CType(Me.TanquesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanquesBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._SSTab1_TabPage6.SuspendLayout()
        CType(Me.CalidadesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalidadesBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.MarcasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcasBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdGuardar
        '
        Me.cmdGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGuardar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGuardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGuardar.Location = New System.Drawing.Point(320, 328)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGuardar.Size = New System.Drawing.Size(89, 33)
        Me.cmdGuardar.TabIndex = 27
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = False
        '
        'cmdCerrar
        '
        Me.cmdCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCerrar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCerrar.Location = New System.Drawing.Point(424, 328)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCerrar.Size = New System.Drawing.Size(89, 33)
        Me.cmdCerrar.TabIndex = 26
        Me.cmdCerrar.Text = "Cerrar"
        Me.cmdCerrar.UseVisualStyleBackColor = False
        '
        'SSTab1
        '
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage0)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage1)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage2)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage3)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage4)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage6)
        Me.SSTab1.Controls.Add(Me.TabPage1)
        Me.SSTab1.ItemSize = New System.Drawing.Size(42, 18)
        Me.SSTab1.Location = New System.Drawing.Point(16, 16)
        Me.SSTab1.Name = "SSTab1"
        Me.SSTab1.SelectedIndex = 4
        Me.SSTab1.Size = New System.Drawing.Size(576, 301)
        Me.SSTab1.TabIndex = 0
        '
        '_SSTab1_TabPage0
        '
        Me._SSTab1_TabPage0.Controls.Add(Me.CheckBox1)
        Me._SSTab1_TabPage0.Controls.Add(Me.CmbPesaje)
        Me._SSTab1_TabPage0.Controls.Add(Me.Label9)
        Me._SSTab1_TabPage0.Controls.Add(Me.provinciaTxt)
        Me._SSTab1_TabPage0.Controls.Add(Me.Label16)
        Me._SSTab1_TabPage0.Controls.Add(Me.PoblacionTxt)
        Me._SSTab1_TabPage0.Controls.Add(Me.cpTxt)
        Me._SSTab1_TabPage0.Controls.Add(Me.Label8)
        Me._SSTab1_TabPage0.Controls.Add(Me.Label7)
        Me._SSTab1_TabPage0.Controls.Add(Me.batTxt)
        Me._SSTab1_TabPage0.Controls.Add(Me.Label6)
        Me._SSTab1_TabPage0.Controls.Add(Me.centrtxt)
        Me._SSTab1_TabPage0.Controls.Add(Me.Label5)
        Me._SSTab1_TabPage0.Controls.Add(Me.regsantxt)
        Me._SSTab1_TabPage0.Controls.Add(Me.regagtxt)
        Me._SSTab1_TabPage0.Controls.Add(Me.decantersTxt)
        Me._SSTab1_TabPage0.Controls.Add(Me.ciftxt)
        Me._SSTab1_TabPage0.Controls.Add(Me.emailtxt)
        Me._SSTab1_TabPage0.Controls.Add(Me.telefonotxt)
        Me._SSTab1_TabPage0.Controls.Add(Me.direcciontxt)
        Me._SSTab1_TabPage0.Controls.Add(Me.nombretxt)
        Me._SSTab1_TabPage0.Controls.Add(Me.Label15)
        Me._SSTab1_TabPage0.Controls.Add(Me.Label14)
        Me._SSTab1_TabPage0.Controls.Add(Me.Label18)
        Me._SSTab1_TabPage0.Controls.Add(Me.Label17)
        Me._SSTab1_TabPage0.Controls.Add(Me.Label4)
        Me._SSTab1_TabPage0.Controls.Add(Me.Label3)
        Me._SSTab1_TabPage0.Controls.Add(Me.Label2)
        Me._SSTab1_TabPage0.Controls.Add(Me.Label1)
        Me._SSTab1_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage0.Name = "_SSTab1_TabPage0"
        Me._SSTab1_TabPage0.Size = New System.Drawing.Size(568, 275)
        Me._SSTab1_TabPage0.TabIndex = 0
        Me._SSTab1_TabPage0.Text = "Almazara"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.AlmazaraBDS, "Multibasculas", True))
        Me.CheckBox1.Location = New System.Drawing.Point(327, 154)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(95, 19)
        Me.CheckBox1.TabIndex = 64
        Me.CheckBox1.Text = "Multibáscula"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'AlmazaraBDS
        '
        Me.AlmazaraBDS.DataSource = GetType(Oleosig.almazaraTableAdapter)
        '
        'CmbPesaje
        '
        Me.CmbPesaje.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AlmazaraBDS, "Pesaje", True))
        Me.CmbPesaje.DataSource = Me.pesajeBDS
        Me.CmbPesaje.DisplayMember = "Descripcion"
        Me.CmbPesaje.FormattingEnabled = True
        Me.CmbPesaje.Location = New System.Drawing.Point(386, 222)
        Me.CmbPesaje.Name = "CmbPesaje"
        Me.CmbPesaje.Size = New System.Drawing.Size(103, 23)
        Me.CmbPesaje.TabIndex = 63
        Me.CmbPesaje.ValueMember = "Codigo"
        '
        'pesajeBDS
        '
        Me.pesajeBDS.DataMember = "tipo_pesaje"
        Me.pesajeBDS.DataSource = Me.OleosigDB1
        '
        'OleosigDB1
        '
        Me.OleosigDB1.DataSetName = "oleosigDB"
        Me.OleosigDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(328, 225)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 15)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Pesaje :"
        '
        'provinciaTxt
        '
        Me.provinciaTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlmazaraBDS, "Provincia", True))
        Me.provinciaTxt.Location = New System.Drawing.Point(82, 123)
        Me.provinciaTxt.Name = "provinciaTxt"
        Me.provinciaTxt.Size = New System.Drawing.Size(176, 21)
        Me.provinciaTxt.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(11, 123)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 15)
        Me.Label16.TabIndex = 61
        Me.Label16.Text = "Provincia :"
        '
        'PoblacionTxt
        '
        Me.PoblacionTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlmazaraBDS, "Localidad", True))
        Me.PoblacionTxt.Location = New System.Drawing.Point(221, 89)
        Me.PoblacionTxt.Name = "PoblacionTxt"
        Me.PoblacionTxt.Size = New System.Drawing.Size(255, 21)
        Me.PoblacionTxt.TabIndex = 3
        '
        'cpTxt
        '
        Me.cpTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlmazaraBDS, "CodPostal", True))
        Me.cpTxt.Location = New System.Drawing.Point(82, 89)
        Me.cpTxt.Name = "cpTxt"
        Me.cpTxt.Size = New System.Drawing.Size(59, 21)
        Me.cpTxt.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(147, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 15)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Población :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 15)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "C. Postal :"
        '
        'batTxt
        '
        Me.batTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlmazaraBDS, "Batidoras", True))
        Me.batTxt.Location = New System.Drawing.Point(82, 185)
        Me.batTxt.Name = "batTxt"
        Me.batTxt.Size = New System.Drawing.Size(74, 21)
        Me.batTxt.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 15)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Batidoras :"
        '
        'centrtxt
        '
        Me.centrtxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlmazaraBDS, "Centrifugas", True))
        Me.centrtxt.Location = New System.Drawing.Point(420, 185)
        Me.centrtxt.Name = "centrtxt"
        Me.centrtxt.Size = New System.Drawing.Size(56, 21)
        Me.centrtxt.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(333, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 15)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Centrífugas :"
        '
        'regsantxt
        '
        Me.regsantxt.AcceptsReturn = True
        Me.regsantxt.BackColor = System.Drawing.SystemColors.Window
        Me.regsantxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.regsantxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlmazaraBDS, "Sanitario", True))
        Me.regsantxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.regsantxt.Location = New System.Drawing.Point(250, 222)
        Me.regsantxt.MaxLength = 0
        Me.regsantxt.Name = "regsantxt"
        Me.regsantxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.regsantxt.Size = New System.Drawing.Size(72, 21)
        Me.regsantxt.TabIndex = 12
        Me.regsantxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'regagtxt
        '
        Me.regagtxt.AcceptsReturn = True
        Me.regagtxt.BackColor = System.Drawing.SystemColors.Window
        Me.regagtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.regagtxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlmazaraBDS, "Agrario", True))
        Me.regagtxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.regagtxt.Location = New System.Drawing.Point(82, 222)
        Me.regagtxt.MaxLength = 0
        Me.regagtxt.Name = "regagtxt"
        Me.regagtxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.regagtxt.Size = New System.Drawing.Size(74, 21)
        Me.regagtxt.TabIndex = 11
        Me.regagtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'decantersTxt
        '
        Me.decantersTxt.AcceptsReturn = True
        Me.decantersTxt.BackColor = System.Drawing.SystemColors.Window
        Me.decantersTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.decantersTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlmazaraBDS, "Decanters", True))
        Me.decantersTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.decantersTxt.Location = New System.Drawing.Point(266, 185)
        Me.decantersTxt.MaxLength = 0
        Me.decantersTxt.Name = "decantersTxt"
        Me.decantersTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.decantersTxt.Size = New System.Drawing.Size(57, 21)
        Me.decantersTxt.TabIndex = 9
        '
        'ciftxt
        '
        Me.ciftxt.AcceptsReturn = True
        Me.ciftxt.BackColor = System.Drawing.SystemColors.Window
        Me.ciftxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ciftxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlmazaraBDS, "Cif", True))
        Me.ciftxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ciftxt.Location = New System.Drawing.Point(209, 156)
        Me.ciftxt.MaxLength = 0
        Me.ciftxt.Name = "ciftxt"
        Me.ciftxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ciftxt.Size = New System.Drawing.Size(81, 21)
        Me.ciftxt.TabIndex = 7
        Me.ciftxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'emailtxt
        '
        Me.emailtxt.AcceptsReturn = True
        Me.emailtxt.BackColor = System.Drawing.SystemColors.Window
        Me.emailtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.emailtxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlmazaraBDS, "Email", True))
        Me.emailtxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.emailtxt.Location = New System.Drawing.Point(327, 123)
        Me.emailtxt.MaxLength = 0
        Me.emailtxt.Name = "emailtxt"
        Me.emailtxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.emailtxt.Size = New System.Drawing.Size(149, 21)
        Me.emailtxt.TabIndex = 5
        '
        'telefonotxt
        '
        Me.telefonotxt.AcceptsReturn = True
        Me.telefonotxt.BackColor = System.Drawing.SystemColors.Window
        Me.telefonotxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.telefonotxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlmazaraBDS, "Telefono", True))
        Me.telefonotxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.telefonotxt.Location = New System.Drawing.Point(82, 154)
        Me.telefonotxt.MaxLength = 0
        Me.telefonotxt.Name = "telefonotxt"
        Me.telefonotxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.telefonotxt.Size = New System.Drawing.Size(74, 21)
        Me.telefonotxt.TabIndex = 6
        Me.telefonotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'direcciontxt
        '
        Me.direcciontxt.AcceptsReturn = True
        Me.direcciontxt.BackColor = System.Drawing.SystemColors.Window
        Me.direcciontxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.direcciontxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlmazaraBDS, "Direccion", True))
        Me.direcciontxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.direcciontxt.Location = New System.Drawing.Point(82, 53)
        Me.direcciontxt.MaxLength = 0
        Me.direcciontxt.Name = "direcciontxt"
        Me.direcciontxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.direcciontxt.Size = New System.Drawing.Size(394, 21)
        Me.direcciontxt.TabIndex = 1
        '
        'nombretxt
        '
        Me.nombretxt.AcceptsReturn = True
        Me.nombretxt.BackColor = System.Drawing.SystemColors.Window
        Me.nombretxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nombretxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlmazaraBDS, "Nombre", True))
        Me.nombretxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nombretxt.Location = New System.Drawing.Point(82, 21)
        Me.nombretxt.MaxLength = 0
        Me.nombretxt.Name = "nombretxt"
        Me.nombretxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nombretxt.Size = New System.Drawing.Size(394, 21)
        Me.nombretxt.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(162, 225)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(85, 15)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Reg. Sanitario"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(11, 225)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(57, 15)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Reg. Agr."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(186, 189)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(70, 15)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Decanters :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(162, 160)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(41, 15)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "C.I.F. :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(272, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "E-mail :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(11, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Teléfono :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(11, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dirección :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(11, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre :"
        '
        '_SSTab1_TabPage1
        '
        Me._SSTab1_TabPage1.Controls.Add(Me.Button3)
        Me._SSTab1_TabPage1.Controls.Add(Me.Button2)
        Me._SSTab1_TabPage1.Controls.Add(Me.VariedadesDataGridView)
        Me._SSTab1_TabPage1.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage1.Name = "_SSTab1_TabPage1"
        Me._SSTab1_TabPage1.Size = New System.Drawing.Size(568, 275)
        Me._SSTab1_TabPage1.TabIndex = 1
        Me._SSTab1_TabPage1.Text = "Variedades"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(404, 51)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Borrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(404, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Nueva"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'VariedadesDataGridView
        '
        Me.VariedadesDataGridView.AllowUserToAddRows = False
        Me.VariedadesDataGridView.AllowUserToDeleteRows = False
        Me.VariedadesDataGridView.AutoGenerateColumns = False
        Me.VariedadesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VariedadesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VarcodigoDataGridViewTextBoxColumn, Me.VarnombreDataGridViewTextBoxColumn})
        Me.VariedadesDataGridView.DataSource = Me.VariedadesBDS
        Me.VariedadesDataGridView.Location = New System.Drawing.Point(21, 21)
        Me.VariedadesDataGridView.Name = "VariedadesDataGridView"
        Me.VariedadesDataGridView.RowHeadersVisible = False
        Me.VariedadesDataGridView.Size = New System.Drawing.Size(233, 222)
        Me.VariedadesDataGridView.TabIndex = 0
        '
        'VarcodigoDataGridViewTextBoxColumn
        '
        Me.VarcodigoDataGridViewTextBoxColumn.DataPropertyName = "varcodigo"
        Me.VarcodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.VarcodigoDataGridViewTextBoxColumn.Name = "VarcodigoDataGridViewTextBoxColumn"
        '
        'VarnombreDataGridViewTextBoxColumn
        '
        Me.VarnombreDataGridViewTextBoxColumn.DataPropertyName = "varnombre"
        Me.VarnombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.VarnombreDataGridViewTextBoxColumn.Name = "VarnombreDataGridViewTextBoxColumn"
        '
        'VariedadesBDS
        '
        Me.VariedadesBDS.DataMember = "variedades"
        Me.VariedadesBDS.DataSource = Me.OleosigDB1
        '
        '_SSTab1_TabPage2
        '
        Me._SSTab1_TabPage2.AutoScroll = True
        Me._SSTab1_TabPage2.Controls.Add(Me.Button5)
        Me._SSTab1_TabPage2.Controls.Add(Me.Button4)
        Me._SSTab1_TabPage2.Controls.Add(Me.TolvasDataGridView)
        Me._SSTab1_TabPage2.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage2.Name = "_SSTab1_TabPage2"
        Me._SSTab1_TabPage2.Size = New System.Drawing.Size(568, 275)
        Me._SSTab1_TabPage2.TabIndex = 2
        Me._SSTab1_TabPage2.Text = "Tolvas"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(404, 51)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Borrar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(404, 21)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Nuevo"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TolvasDataGridView
        '
        Me.TolvasDataGridView.AllowUserToAddRows = False
        Me.TolvasDataGridView.AllowUserToDeleteRows = False
        Me.TolvasDataGridView.AutoGenerateColumns = False
        Me.TolvasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TolvasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDataGridViewTextBoxColumn1, Me.NombreDataGridViewTextBoxColumn3, Me.CapacidadDataGridViewTextBoxColumn1})
        Me.TolvasDataGridView.DataSource = Me.TolvasBDS
        Me.TolvasDataGridView.Location = New System.Drawing.Point(21, 21)
        Me.TolvasDataGridView.Name = "TolvasDataGridView"
        Me.TolvasDataGridView.RowHeadersVisible = False
        Me.TolvasDataGridView.Size = New System.Drawing.Size(355, 222)
        Me.TolvasDataGridView.TabIndex = 0
        '
        'NumeroDataGridViewTextBoxColumn1
        '
        Me.NumeroDataGridViewTextBoxColumn1.DataPropertyName = "Numero"
        Me.NumeroDataGridViewTextBoxColumn1.HeaderText = "Numero"
        Me.NumeroDataGridViewTextBoxColumn1.Name = "NumeroDataGridViewTextBoxColumn1"
        '
        'NombreDataGridViewTextBoxColumn3
        '
        Me.NombreDataGridViewTextBoxColumn3.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn3.Name = "NombreDataGridViewTextBoxColumn3"
        '
        'CapacidadDataGridViewTextBoxColumn1
        '
        Me.CapacidadDataGridViewTextBoxColumn1.DataPropertyName = "Capacidad"
        Me.CapacidadDataGridViewTextBoxColumn1.HeaderText = "Capacidad"
        Me.CapacidadDataGridViewTextBoxColumn1.Name = "CapacidadDataGridViewTextBoxColumn1"
        '
        'TolvasBDS
        '
        Me.TolvasBDS.AllowNew = True
        Me.TolvasBDS.DataMember = "tolvas"
        Me.TolvasBDS.DataSource = Me.OleosigDB1
        '
        '_SSTab1_TabPage3
        '
        Me._SSTab1_TabPage3.AutoScroll = True
        Me._SSTab1_TabPage3.Controls.Add(Me.Button8)
        Me._SSTab1_TabPage3.Controls.Add(Me.Button7)
        Me._SSTab1_TabPage3.Controls.Add(Me.AclaradoresDataGridView)
        Me._SSTab1_TabPage3.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage3.Name = "_SSTab1_TabPage3"
        Me._SSTab1_TabPage3.Size = New System.Drawing.Size(568, 275)
        Me._SSTab1_TabPage3.TabIndex = 3
        Me._SSTab1_TabPage3.Text = "Aclaradores"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(404, 51)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "Borrar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(404, 21)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "Nuevo"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'AclaradoresDataGridView
        '
        Me.AclaradoresDataGridView.AllowUserToAddRows = False
        Me.AclaradoresDataGridView.AllowUserToDeleteRows = False
        Me.AclaradoresDataGridView.AutoGenerateColumns = False
        Me.AclaradoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AclaradoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDataGridViewTextBoxColumn2, Me.NombreDataGridViewTextBoxColumn4, Me.CapacidadDataGridViewTextBoxColumn2})
        Me.AclaradoresDataGridView.DataSource = Me.AclaradoresBDS
        Me.AclaradoresDataGridView.Location = New System.Drawing.Point(21, 21)
        Me.AclaradoresDataGridView.Name = "AclaradoresDataGridView"
        Me.AclaradoresDataGridView.RowHeadersVisible = False
        Me.AclaradoresDataGridView.Size = New System.Drawing.Size(355, 222)
        Me.AclaradoresDataGridView.TabIndex = 0
        '
        'NumeroDataGridViewTextBoxColumn2
        '
        Me.NumeroDataGridViewTextBoxColumn2.DataPropertyName = "Numero"
        Me.NumeroDataGridViewTextBoxColumn2.HeaderText = "Numero"
        Me.NumeroDataGridViewTextBoxColumn2.Name = "NumeroDataGridViewTextBoxColumn2"
        '
        'NombreDataGridViewTextBoxColumn4
        '
        Me.NombreDataGridViewTextBoxColumn4.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn4.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn4.Name = "NombreDataGridViewTextBoxColumn4"
        '
        'CapacidadDataGridViewTextBoxColumn2
        '
        Me.CapacidadDataGridViewTextBoxColumn2.DataPropertyName = "Capacidad"
        Me.CapacidadDataGridViewTextBoxColumn2.HeaderText = "Capacidad"
        Me.CapacidadDataGridViewTextBoxColumn2.Name = "CapacidadDataGridViewTextBoxColumn2"
        '
        'AclaradoresBDS
        '
        Me.AclaradoresBDS.DataMember = "aclaradores"
        Me.AclaradoresBDS.DataSource = Me.OleosigDB1
        '
        '_SSTab1_TabPage4
        '
        Me._SSTab1_TabPage4.AutoScroll = True
        Me._SSTab1_TabPage4.Controls.Add(Me.Button6)
        Me._SSTab1_TabPage4.Controls.Add(Me.TanquesDataGridView)
        Me._SSTab1_TabPage4.Controls.Add(Me.Button1)
        Me._SSTab1_TabPage4.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage4.Name = "_SSTab1_TabPage4"
        Me._SSTab1_TabPage4.Size = New System.Drawing.Size(568, 275)
        Me._SSTab1_TabPage4.TabIndex = 4
        Me._SSTab1_TabPage4.Text = "Depósitos"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(404, 51)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Borrar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TanquesDataGridView
        '
        Me.TanquesDataGridView.AllowUserToAddRows = False
        Me.TanquesDataGridView.AllowUserToDeleteRows = False
        Me.TanquesDataGridView.AutoGenerateColumns = False
        Me.TanquesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TanquesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn2, Me.CapacidadDataGridViewTextBoxColumn})
        Me.TanquesDataGridView.DataSource = Me.TanquesBDS
        Me.TanquesDataGridView.Location = New System.Drawing.Point(21, 21)
        Me.TanquesDataGridView.Name = "TanquesDataGridView"
        Me.TanquesDataGridView.RowHeadersVisible = False
        Me.TanquesDataGridView.Size = New System.Drawing.Size(355, 220)
        Me.TanquesDataGridView.TabIndex = 1
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn2
        '
        Me.NombreDataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn2.Name = "NombreDataGridViewTextBoxColumn2"
        '
        'CapacidadDataGridViewTextBoxColumn
        '
        Me.CapacidadDataGridViewTextBoxColumn.DataPropertyName = "Capacidad"
        Me.CapacidadDataGridViewTextBoxColumn.HeaderText = "Capacidad"
        Me.CapacidadDataGridViewTextBoxColumn.Name = "CapacidadDataGridViewTextBoxColumn"
        '
        'TanquesBDS
        '
        Me.TanquesBDS.DataMember = "tanques"
        Me.TanquesBDS.DataSource = Me.OleosigDB1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(404, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Nuevo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        '_SSTab1_TabPage6
        '
        Me._SSTab1_TabPage6.AutoScroll = True
        Me._SSTab1_TabPage6.Controls.Add(Me.Button10)
        Me._SSTab1_TabPage6.Controls.Add(Me.Button9)
        Me._SSTab1_TabPage6.Controls.Add(Me.CalidadesDataGridView)
        Me._SSTab1_TabPage6.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage6.Name = "_SSTab1_TabPage6"
        Me._SSTab1_TabPage6.Size = New System.Drawing.Size(568, 275)
        Me._SSTab1_TabPage6.TabIndex = 6
        Me._SSTab1_TabPage6.Text = "Recoleccion"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(404, 51)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 2
        Me.Button10.Text = "Borrar"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(404, 21)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 1
        Me.Button9.Text = "Nuevo"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'CalidadesDataGridView
        '
        Me.CalidadesDataGridView.AllowUserToAddRows = False
        Me.CalidadesDataGridView.AllowUserToDeleteRows = False
        Me.CalidadesDataGridView.AutoGenerateColumns = False
        Me.CalidadesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CalidadesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn})
        Me.CalidadesDataGridView.DataSource = Me.CalidadesBDS
        Me.CalidadesDataGridView.Location = New System.Drawing.Point(21, 21)
        Me.CalidadesDataGridView.Name = "CalidadesDataGridView"
        Me.CalidadesDataGridView.RowHeadersVisible = False
        Me.CalidadesDataGridView.Size = New System.Drawing.Size(233, 222)
        Me.CalidadesDataGridView.TabIndex = 0
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'CalidadesBDS
        '
        Me.CalidadesBDS.DataMember = "recoleccion"
        Me.CalidadesBDS.DataSource = Me.OleosigDB1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button11)
        Me.TabPage1.Controls.Add(Me.Button12)
        Me.TabPage1.Controls.Add(Me.MarcasDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(568, 275)
        Me.TabPage1.TabIndex = 7
        Me.TabPage1.Text = "Marcas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(404, 52)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 23)
        Me.Button11.TabIndex = 4
        Me.Button11.Text = "Borrar"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(404, 22)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 23)
        Me.Button12.TabIndex = 3
        Me.Button12.Text = "Nuevo"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'MarcasDataGridView
        '
        Me.MarcasDataGridView.AllowUserToAddRows = False
        Me.MarcasDataGridView.AllowUserToDeleteRows = False
        Me.MarcasDataGridView.AutoGenerateColumns = False
        Me.MarcasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MarcasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn1, Me.NombreDataGridViewTextBoxColumn1})
        Me.MarcasDataGridView.DataSource = Me.MarcasBDS
        Me.MarcasDataGridView.Location = New System.Drawing.Point(21, 22)
        Me.MarcasDataGridView.MultiSelect = False
        Me.MarcasDataGridView.Name = "MarcasDataGridView"
        Me.MarcasDataGridView.ReadOnly = True
        Me.MarcasDataGridView.RowHeadersVisible = False
        Me.MarcasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MarcasDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.MarcasDataGridView.TabIndex = 0
        '
        'CodigoDataGridViewTextBoxColumn1
        '
        Me.CodigoDataGridViewTextBoxColumn1.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn1.Name = "CodigoDataGridViewTextBoxColumn1"
        Me.CodigoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn1
        '
        Me.NombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn1.Name = "NombreDataGridViewTextBoxColumn1"
        Me.NombreDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'MarcasBDS
        '
        Me.MarcasBDS.AllowNew = True
        Me.MarcasBDS.DataMember = "marcas"
        Me.MarcasBDS.DataSource = Me.OleosigDB1
        '
        'frmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(604, 365)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.SSTab1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfig"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configuración"
        Me.SSTab1.ResumeLayout(False)
        Me._SSTab1_TabPage0.ResumeLayout(False)
        Me._SSTab1_TabPage0.PerformLayout()
        CType(Me.AlmazaraBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pesajeBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me._SSTab1_TabPage1.ResumeLayout(False)
        CType(Me.VariedadesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VariedadesBDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me._SSTab1_TabPage2.ResumeLayout(False)
        CType(Me.TolvasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TolvasBDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me._SSTab1_TabPage3.ResumeLayout(False)
        CType(Me.AclaradoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AclaradoresBDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me._SSTab1_TabPage4.ResumeLayout(False)
        CType(Me.TanquesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanquesBDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me._SSTab1_TabPage6.ResumeLayout(False)
        CType(Me.CalidadesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalidadesBDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.MarcasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcasBDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents centrtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents batTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents provinciaTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents PoblacionTxt As System.Windows.Forms.TextBox
    Friend WithEvents cpTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents AclaradoresDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents AclaradoresBDS As System.Windows.Forms.BindingSource
    Friend WithEvents TolvasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TolvasBDS As System.Windows.Forms.BindingSource
    Friend WithEvents AlmazaraBDS As System.Windows.Forms.BindingSource
    Friend WithEvents VariedadesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents VariedadesBDS As System.Windows.Forms.BindingSource
    Friend WithEvents CalidadesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CalidadesBDS As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TanquesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TanquesBDS As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents CmbPesaje As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents pesajeBDS As System.Windows.Forms.BindingSource
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents MarcasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MarcasBDS As System.Windows.Forms.BindingSource
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents OleosigDB1 As Oleosig.oleosigDB
    Friend WithEvents CodigoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VarcodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VarnombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CapacidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CapacidadDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CapacidadDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region
End Class