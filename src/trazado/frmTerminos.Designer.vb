<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmTerminos
#Region "Código generado por el Diseñador de Windows Forms "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
        Me.iniciando = True
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        Me.iniciando = False

        inicia_Componentes()

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
    Public WithEvents codigotxt As System.Windows.Forms.TextBox
	Public WithEvents terminotxt As System.Windows.Forms.TextBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents _Toolbar1_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents _Toolbar1_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _Toolbar1_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _Toolbar1_Button4 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button6 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button8 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip

    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.codProvTxt = New System.Windows.Forms.TextBox()
        Me.TerminosAlmazaraBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.OleosigDB1 = New Oleosig.oleosigDB()
        Me.terminoInetxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbTerminos = New System.Windows.Forms.ComboBox()
        Me.TodosTerminosBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbProvincia = New System.Windows.Forms.ComboBox()
        Me.ProvinciasBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.codigotxt = New System.Windows.Forms.TextBox()
        Me.terminotxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Toolbar1 = New System.Windows.Forms.ToolStrip()
        Me._Toolbar1_Button1 = New System.Windows.Forms.ToolStripButton()
        Me._Toolbar1_Button2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me._Toolbar1_Button3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me._Toolbar1_Button4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me._Toolbar1_Button6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me._Toolbar1_Button8 = New System.Windows.Forms.ToolStripButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tablaDatos = New System.Windows.Forms.DataGridView()
        Me.CodAlmazaraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodIneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodProvinciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Frame1.SuspendLayout()
        CType(Me.TerminosAlmazaraBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TodosTerminosBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvinciasBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Toolbar1.SuspendLayout()
        CType(Me.tablaDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.codProvTxt)
        Me.Frame1.Controls.Add(Me.terminoInetxt)
        Me.Frame1.Controls.Add(Me.Label7)
        Me.Frame1.Controls.Add(Me.cmbTerminos)
        Me.Frame1.Controls.Add(Me.Label6)
        Me.Frame1.Controls.Add(Me.Label8)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Controls.Add(Me.cmbProvincia)
        Me.Frame1.Controls.Add(Me.codigotxt)
        Me.Frame1.Controls.Add(Me.terminotxt)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(7, 82)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(438, 189)
        Me.Frame1.TabIndex = 7
        Me.Frame1.TabStop = False
        '
        'codProvTxt
        '
        Me.codProvTxt.AcceptsReturn = True
        Me.codProvTxt.BackColor = System.Drawing.Color.White
        Me.codProvTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.codProvTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TerminosAlmazaraBDS, "CodProvincia", True))
        Me.codProvTxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codProvTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.codProvTxt.Location = New System.Drawing.Point(312, 53)
        Me.codProvTxt.MaxLength = 0
        Me.codProvTxt.Name = "codProvTxt"
        Me.codProvTxt.ReadOnly = True
        Me.codProvTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.codProvTxt.Size = New System.Drawing.Size(73, 22)
        Me.codProvTxt.TabIndex = 17
        Me.codProvTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TerminosAlmazaraBDS
        '
        Me.TerminosAlmazaraBDS.DataMember = "terminos"
        Me.TerminosAlmazaraBDS.DataSource = Me.OleosigDB1
        '
        'OleosigDB1
        '
        Me.OleosigDB1.DataSetName = "oleosigDB"
        Me.OleosigDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'terminoInetxt
        '
        Me.terminoInetxt.AcceptsReturn = True
        Me.terminoInetxt.BackColor = System.Drawing.Color.White
        Me.terminoInetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.terminoInetxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TerminosAlmazaraBDS, "CodIne", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.terminoInetxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.terminoInetxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.terminoInetxt.Location = New System.Drawing.Point(92, 117)
        Me.terminoInetxt.MaxLength = 0
        Me.terminoInetxt.Name = "terminoInetxt"
        Me.terminoInetxt.ReadOnly = True
        Me.terminoInetxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.terminoInetxt.Size = New System.Drawing.Size(73, 22)
        Me.terminoInetxt.TabIndex = 3
        Me.terminoInetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(10, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(66, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Ine :"
        '
        'cmbTerminos
        '
        Me.cmbTerminos.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TerminosAlmazaraBDS, "CodIne", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.cmbTerminos.DataSource = Me.TodosTerminosBDS
        Me.cmbTerminos.DisplayMember = "Nombre"
        Me.cmbTerminos.FormattingEnabled = True
        Me.cmbTerminos.Location = New System.Drawing.Point(92, 85)
        Me.cmbTerminos.Name = "cmbTerminos"
        Me.cmbTerminos.Size = New System.Drawing.Size(156, 21)
        Me.cmbTerminos.TabIndex = 2
        Me.cmbTerminos.ValueMember = "Cmun"
        '
        'TodosTerminosBDS
        '
        Me.TodosTerminosBDS.AllowNew = False
        Me.TodosTerminosBDS.DataMember = "terminosIne"
        Me.TodosTerminosBDS.DataSource = Me.OleosigDB1
        Me.TodosTerminosBDS.Filter = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(10, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(78, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Términos :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(194, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(111, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Cod. Provincia :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(10, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Provincia :"
        '
        'cmbProvincia
        '
        Me.cmbProvincia.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TerminosAlmazaraBDS, "CodProvincia", True))
        Me.cmbProvincia.DataSource = Me.ProvinciasBDS
        Me.cmbProvincia.DisplayMember = "Nombre"
        Me.cmbProvincia.FormattingEnabled = True
        Me.cmbProvincia.Location = New System.Drawing.Point(92, 54)
        Me.cmbProvincia.Name = "cmbProvincia"
        Me.cmbProvincia.Size = New System.Drawing.Size(96, 21)
        Me.cmbProvincia.TabIndex = 1
        Me.cmbProvincia.ValueMember = "Id"
        '
        'ProvinciasBDS
        '
        Me.ProvinciasBDS.DataMember = "provincia"
        Me.ProvinciasBDS.DataSource = Me.OleosigDB1
        '
        'codigotxt
        '
        Me.codigotxt.AcceptsReturn = True
        Me.codigotxt.BackColor = System.Drawing.Color.White
        Me.codigotxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.codigotxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TerminosAlmazaraBDS, "CodAlmazara", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.codigotxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codigotxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.codigotxt.Location = New System.Drawing.Point(92, 24)
        Me.codigotxt.MaxLength = 0
        Me.codigotxt.Name = "codigotxt"
        Me.codigotxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.codigotxt.Size = New System.Drawing.Size(73, 22)
        Me.codigotxt.TabIndex = 0
        Me.codigotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'terminotxt
        '
        Me.terminotxt.AcceptsReturn = True
        Me.terminotxt.BackColor = System.Drawing.Color.White
        Me.terminotxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.terminotxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TerminosAlmazaraBDS, "Nombre", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.terminotxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.terminotxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.terminotxt.Location = New System.Drawing.Point(92, 150)
        Me.terminotxt.MaxLength = 0
        Me.terminotxt.Name = "terminotxt"
        Me.terminotxt.ReadOnly = True
        Me.terminotxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.terminotxt.Size = New System.Drawing.Size(293, 22)
        Me.terminotxt.TabIndex = 4
        Me.terminotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(10, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Código :"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(10, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Término :"
        '
        'Toolbar1
        '
        Me.Toolbar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._Toolbar1_Button1, Me._Toolbar1_Button2, Me.ToolStripSeparator1, Me._Toolbar1_Button3, Me.ToolStripSeparator2, Me._Toolbar1_Button4, Me.ToolStripSeparator3, Me._Toolbar1_Button6, Me.ToolStripSeparator4, Me._Toolbar1_Button8})
        Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar1.Name = "Toolbar1"
        Me.Toolbar1.Size = New System.Drawing.Size(457, 48)
        Me.Toolbar1.TabIndex = 6
        '
        '_Toolbar1_Button1
        '
        Me._Toolbar1_Button1.AutoSize = False
        Me._Toolbar1_Button1.Image = Global.Oleosig.My.Resources.Resources.document_new
        Me._Toolbar1_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button1.Name = "_Toolbar1_Button1"
        Me._Toolbar1_Button1.Size = New System.Drawing.Size(50, 45)
        Me._Toolbar1_Button1.Text = "Nuevo"
        Me._Toolbar1_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        '_Toolbar1_Button2
        '
        Me._Toolbar1_Button2.AutoSize = False
        Me._Toolbar1_Button2.Image = Global.Oleosig.My.Resources.Resources.document_properties
        Me._Toolbar1_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button2.Name = "_Toolbar1_Button2"
        Me._Toolbar1_Button2.Size = New System.Drawing.Size(50, 45)
        Me._Toolbar1_Button2.Text = "Editar"
        Me._Toolbar1_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 48)
        '
        '_Toolbar1_Button3
        '
        Me._Toolbar1_Button3.AutoSize = False
        Me._Toolbar1_Button3.Image = Global.Oleosig.My.Resources.Resources.edit_undo
        Me._Toolbar1_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button3.Name = "_Toolbar1_Button3"
        Me._Toolbar1_Button3.Size = New System.Drawing.Size(50, 45)
        Me._Toolbar1_Button3.Text = "Cancelar"
        Me._Toolbar1_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 48)
        '
        '_Toolbar1_Button4
        '
        Me._Toolbar1_Button4.AutoSize = False
        Me._Toolbar1_Button4.Image = Global.Oleosig.My.Resources.Resources.document_save
        Me._Toolbar1_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button4.Name = "_Toolbar1_Button4"
        Me._Toolbar1_Button4.Size = New System.Drawing.Size(50, 45)
        Me._Toolbar1_Button4.Text = "Guardar"
        Me._Toolbar1_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 48)
        '
        '_Toolbar1_Button6
        '
        Me._Toolbar1_Button6.AutoSize = False
        Me._Toolbar1_Button6.Image = Global.Oleosig.My.Resources.Resources.edittrash
        Me._Toolbar1_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button6.Name = "_Toolbar1_Button6"
        Me._Toolbar1_Button6.Size = New System.Drawing.Size(50, 45)
        Me._Toolbar1_Button6.Text = "Borrar"
        Me._Toolbar1_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 48)
        '
        '_Toolbar1_Button8
        '
        Me._Toolbar1_Button8.AutoSize = False
        Me._Toolbar1_Button8.Image = Global.Oleosig.My.Resources.Resources.dialog_close
        Me._Toolbar1_Button8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button8.Name = "_Toolbar1_Button8"
        Me._Toolbar1_Button8.Size = New System.Drawing.Size(50, 45)
        Me._Toolbar1_Button8.Text = "Cerrar"
        Me._Toolbar1_Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(3, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(145, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Lista de Términos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(90, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Términos"
        '
        'tablaDatos
        '
        Me.tablaDatos.AllowUserToAddRows = False
        Me.tablaDatos.AllowUserToDeleteRows = False
        Me.tablaDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tablaDatos.AutoGenerateColumns = False
        Me.tablaDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablaDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodAlmazaraDataGridViewTextBoxColumn, Me.CodIneDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CodProvinciaDataGridViewTextBoxColumn})
        Me.tablaDatos.DataSource = Me.TerminosAlmazaraBDS
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tablaDatos.DefaultCellStyle = DataGridViewCellStyle4
        Me.tablaDatos.Location = New System.Drawing.Point(7, 308)
        Me.tablaDatos.Name = "tablaDatos"
        Me.tablaDatos.ReadOnly = True
        Me.tablaDatos.RowHeadersVisible = False
        Me.tablaDatos.Size = New System.Drawing.Size(438, 222)
        Me.tablaDatos.TabIndex = 8
        '
        'CodAlmazaraDataGridViewTextBoxColumn
        '
        Me.CodAlmazaraDataGridViewTextBoxColumn.DataPropertyName = "CodAlmazara"
        Me.CodAlmazaraDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodAlmazaraDataGridViewTextBoxColumn.Name = "CodAlmazaraDataGridViewTextBoxColumn"
        Me.CodAlmazaraDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodAlmazaraDataGridViewTextBoxColumn.Width = 65
        '
        'CodIneDataGridViewTextBoxColumn
        '
        Me.CodIneDataGridViewTextBoxColumn.DataPropertyName = "CodIne"
        Me.CodIneDataGridViewTextBoxColumn.HeaderText = "CodIne"
        Me.CodIneDataGridViewTextBoxColumn.Name = "CodIneDataGridViewTextBoxColumn"
        Me.CodIneDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodIneDataGridViewTextBoxColumn.Width = 66
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 69
        '
        'CodProvinciaDataGridViewTextBoxColumn
        '
        Me.CodProvinciaDataGridViewTextBoxColumn.DataPropertyName = "CodProvincia"
        Me.CodProvinciaDataGridViewTextBoxColumn.HeaderText = "CodProvincia"
        Me.CodProvinciaDataGridViewTextBoxColumn.Name = "CodProvinciaDataGridViewTextBoxColumn"
        Me.CodProvinciaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodProvinciaDataGridViewTextBoxColumn.Width = 95
        '
        'frmTerminos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(457, 542)
        Me.Controls.Add(Me.tablaDatos)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Toolbar1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTerminos"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Términos"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.TerminosAlmazaraBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TodosTerminosBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvinciasBDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Toolbar1.ResumeLayout(False)
        Me.Toolbar1.PerformLayout()
        CType(Me.tablaDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tablaDatos As System.Windows.Forms.DataGridView
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents TerminosAlmazaraBDS As System.Windows.Forms.BindingSource
    Friend WithEvents ProvinciasBDS As System.Windows.Forms.BindingSource
    Public WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbTerminos As System.Windows.Forms.ComboBox
    Friend WithEvents TodosTerminosBDS As System.Windows.Forms.BindingSource
    Public WithEvents terminoInetxt As System.Windows.Forms.TextBox
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents codProvTxt As System.Windows.Forms.TextBox
    Public WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents OleosigDB1 As Oleosig.oleosigDB
    Friend WithEvents CodAlmazaraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodIneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodProvinciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region
End Class