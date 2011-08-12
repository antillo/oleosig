<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAdClientes
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
    Public WithEvents _barramenu_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents _barramenu_Button2 As System.Windows.Forms.ToolStripButton
    Public WithEvents _barramenu_Button4 As System.Windows.Forms.ToolStripButton
    Public WithEvents _barramenu_Button6 As System.Windows.Forms.ToolStripButton
    Public WithEvents _barramenu_Button8 As System.Windows.Forms.ToolStripButton
    Public WithEvents _barramenu_Button10 As System.Windows.Forms.ToolStripButton
	Public WithEvents barramenu As System.Windows.Forms.ToolStrip
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.nombretxt = New System.Windows.Forms.TextBox()
        Me.ClientesBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.OleosigDB1 = New Oleosig.oleosigDB()
        Me.barramenu = New System.Windows.Forms.ToolStrip()
        Me._barramenu_Button1 = New System.Windows.Forms.ToolStripButton()
        Me._barramenu_Button2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me._barramenu_Button4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me._barramenu_Button6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me._barramenu_Button8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me._barramenu_Button10 = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.numclientetxt = New System.Windows.Forms.TextBox()
        Me.faxtxt = New System.Windows.Forms.TextBox()
        Me.direcciontxt = New System.Windows.Forms.TextBox()
        Me.provinciatxt = New System.Windows.Forms.TextBox()
        Me.localidadtxt = New System.Windows.Forms.TextBox()
        Me.cptxt = New System.Windows.Forms.TextBox()
        Me.emailtxt = New System.Windows.Forms.TextBox()
        Me.telefonotxt = New System.Windows.Forms.TextBox()
        Me.ciftxt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tablaClientes = New System.Windows.Forms.DataGridView()
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CifDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ClientesBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barramenu.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.tablaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nombretxt
        '
        Me.nombretxt.AcceptsReturn = True
        Me.nombretxt.BackColor = System.Drawing.Color.White
        Me.nombretxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nombretxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBDS, "Nombre", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nombretxt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombretxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nombretxt.Location = New System.Drawing.Point(107, 45)
        Me.nombretxt.MaxLength = 0
        Me.nombretxt.Name = "nombretxt"
        Me.nombretxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nombretxt.Size = New System.Drawing.Size(247, 21)
        Me.nombretxt.TabIndex = 1
        Me.nombretxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.nombretxt, "Nombre de cliente, obligatorio")
        '
        'ClientesBDS
        '
        Me.ClientesBDS.DataMember = "clientes"
        Me.ClientesBDS.DataSource = Me.OleosigDB1
        '
        'OleosigDB1
        '
        Me.OleosigDB1.DataSetName = "oleosigDB"
        Me.OleosigDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'barramenu
        '
        Me.barramenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.barramenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._barramenu_Button1, Me._barramenu_Button2, Me.ToolStripSeparator1, Me._barramenu_Button4, Me.ToolStripSeparator2, Me._barramenu_Button6, Me.ToolStripSeparator3, Me._barramenu_Button8, Me.ToolStripSeparator4, Me._barramenu_Button10})
        Me.barramenu.Location = New System.Drawing.Point(0, 0)
        Me.barramenu.Name = "barramenu"
        Me.barramenu.Size = New System.Drawing.Size(614, 48)
        Me.barramenu.TabIndex = 2
        '
        '_barramenu_Button1
        '
        Me._barramenu_Button1.AutoSize = False
        Me._barramenu_Button1.Image = Global.Oleosig.My.Resources.Resources.document_new
        Me._barramenu_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._barramenu_Button1.Name = "_barramenu_Button1"
        Me._barramenu_Button1.Size = New System.Drawing.Size(50, 45)
        Me._barramenu_Button1.Text = "Nuevo"
        Me._barramenu_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        '_barramenu_Button2
        '
        Me._barramenu_Button2.AutoSize = False
        Me._barramenu_Button2.Image = Global.Oleosig.My.Resources.Resources.document_properties
        Me._barramenu_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._barramenu_Button2.Name = "_barramenu_Button2"
        Me._barramenu_Button2.Size = New System.Drawing.Size(50, 45)
        Me._barramenu_Button2.Text = "Editar"
        Me._barramenu_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 48)
        '
        '_barramenu_Button4
        '
        Me._barramenu_Button4.AutoSize = False
        Me._barramenu_Button4.Image = Global.Oleosig.My.Resources.Resources.edit_undo
        Me._barramenu_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._barramenu_Button4.Name = "_barramenu_Button4"
        Me._barramenu_Button4.Size = New System.Drawing.Size(50, 45)
        Me._barramenu_Button4.Text = "Cancelar"
        Me._barramenu_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 48)
        '
        '_barramenu_Button6
        '
        Me._barramenu_Button6.AutoSize = False
        Me._barramenu_Button6.Image = Global.Oleosig.My.Resources.Resources.edittrash
        Me._barramenu_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._barramenu_Button6.Name = "_barramenu_Button6"
        Me._barramenu_Button6.Size = New System.Drawing.Size(50, 45)
        Me._barramenu_Button6.Text = "Borrar"
        Me._barramenu_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 48)
        '
        '_barramenu_Button8
        '
        Me._barramenu_Button8.AutoSize = False
        Me._barramenu_Button8.Image = Global.Oleosig.My.Resources.Resources.document_save
        Me._barramenu_Button8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._barramenu_Button8.Name = "_barramenu_Button8"
        Me._barramenu_Button8.Size = New System.Drawing.Size(50, 45)
        Me._barramenu_Button8.Text = "Guardar"
        Me._barramenu_Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 48)
        '
        '_barramenu_Button10
        '
        Me._barramenu_Button10.AutoSize = False
        Me._barramenu_Button10.Image = Global.Oleosig.My.Resources.Resources.dialog_close
        Me._barramenu_Button10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._barramenu_Button10.Name = "_barramenu_Button10"
        Me._barramenu_Button10.Size = New System.Drawing.Size(50, 45)
        Me._barramenu_Button10.Text = "Cerrar"
        Me._barramenu_Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 48)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.numclientetxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.faxtxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.direcciontxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.provinciatxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.localidadtxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cptxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.emailtxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.telefonotxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ciftxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.nombretxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label16)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label14)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.tablaClientes)
        Me.SplitContainer1.Size = New System.Drawing.Size(614, 343)
        Me.SplitContainer1.SplitterDistance = 210
        Me.SplitContainer1.TabIndex = 31
        '
        'numclientetxt
        '
        Me.numclientetxt.AcceptsReturn = True
        Me.numclientetxt.BackColor = System.Drawing.Color.White
        Me.numclientetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numclientetxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBDS, "Numero", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.numclientetxt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numclientetxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.numclientetxt.Location = New System.Drawing.Point(107, 16)
        Me.numclientetxt.MaxLength = 0
        Me.numclientetxt.Name = "numclientetxt"
        Me.numclientetxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numclientetxt.Size = New System.Drawing.Size(79, 21)
        Me.numclientetxt.TabIndex = 0
        Me.numclientetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'faxtxt
        '
        Me.faxtxt.AcceptsReturn = True
        Me.faxtxt.BackColor = System.Drawing.Color.White
        Me.faxtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.faxtxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBDS, "Fax", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.faxtxt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.faxtxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.faxtxt.Location = New System.Drawing.Point(274, 173)
        Me.faxtxt.MaxLength = 0
        Me.faxtxt.Name = "faxtxt"
        Me.faxtxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.faxtxt.Size = New System.Drawing.Size(106, 21)
        Me.faxtxt.TabIndex = 9
        Me.faxtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'direcciontxt
        '
        Me.direcciontxt.AcceptsReturn = True
        Me.direcciontxt.BackColor = System.Drawing.Color.White
        Me.direcciontxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.direcciontxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBDS, "Direccion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.direcciontxt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.direcciontxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.direcciontxt.Location = New System.Drawing.Point(107, 77)
        Me.direcciontxt.MaxLength = 0
        Me.direcciontxt.Name = "direcciontxt"
        Me.direcciontxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.direcciontxt.Size = New System.Drawing.Size(453, 21)
        Me.direcciontxt.TabIndex = 3
        Me.direcciontxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'provinciatxt
        '
        Me.provinciatxt.AcceptsReturn = True
        Me.provinciatxt.BackColor = System.Drawing.Color.White
        Me.provinciatxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.provinciatxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBDS, "Provincia", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.provinciatxt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.provinciatxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.provinciatxt.Location = New System.Drawing.Point(107, 141)
        Me.provinciatxt.MaxLength = 0
        Me.provinciatxt.Name = "provinciatxt"
        Me.provinciatxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.provinciatxt.Size = New System.Drawing.Size(151, 21)
        Me.provinciatxt.TabIndex = 6
        Me.provinciatxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'localidadtxt
        '
        Me.localidadtxt.AcceptsReturn = True
        Me.localidadtxt.BackColor = System.Drawing.Color.White
        Me.localidadtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.localidadtxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBDS, "Localidad", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.localidadtxt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.localidadtxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.localidadtxt.Location = New System.Drawing.Point(244, 109)
        Me.localidadtxt.MaxLength = 0
        Me.localidadtxt.Name = "localidadtxt"
        Me.localidadtxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.localidadtxt.Size = New System.Drawing.Size(316, 21)
        Me.localidadtxt.TabIndex = 5
        Me.localidadtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cptxt
        '
        Me.cptxt.AcceptsReturn = True
        Me.cptxt.BackColor = System.Drawing.Color.White
        Me.cptxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cptxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBDS, "Cp", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cptxt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cptxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cptxt.Location = New System.Drawing.Point(107, 109)
        Me.cptxt.MaxLength = 0
        Me.cptxt.Name = "cptxt"
        Me.cptxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cptxt.Size = New System.Drawing.Size(49, 21)
        Me.cptxt.TabIndex = 4
        Me.cptxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'emailtxt
        '
        Me.emailtxt.AcceptsReturn = True
        Me.emailtxt.BackColor = System.Drawing.Color.White
        Me.emailtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.emailtxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBDS, "Email", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.emailtxt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailtxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.emailtxt.Location = New System.Drawing.Point(330, 141)
        Me.emailtxt.MaxLength = 0
        Me.emailtxt.Name = "emailtxt"
        Me.emailtxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.emailtxt.Size = New System.Drawing.Size(230, 21)
        Me.emailtxt.TabIndex = 7
        Me.emailtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'telefonotxt
        '
        Me.telefonotxt.AcceptsReturn = True
        Me.telefonotxt.BackColor = System.Drawing.Color.White
        Me.telefonotxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.telefonotxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBDS, "Telefono", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.telefonotxt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefonotxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.telefonotxt.Location = New System.Drawing.Point(107, 173)
        Me.telefonotxt.MaxLength = 0
        Me.telefonotxt.Name = "telefonotxt"
        Me.telefonotxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.telefonotxt.Size = New System.Drawing.Size(114, 21)
        Me.telefonotxt.TabIndex = 8
        Me.telefonotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ciftxt
        '
        Me.ciftxt.AcceptsReturn = True
        Me.ciftxt.BackColor = System.Drawing.Color.White
        Me.ciftxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ciftxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBDS, "Cif", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ciftxt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ciftxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ciftxt.Location = New System.Drawing.Point(437, 45)
        Me.ciftxt.MaxLength = 0
        Me.ciftxt.Name = "ciftxt"
        Me.ciftxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ciftxt.Size = New System.Drawing.Size(123, 21)
        Me.ciftxt.TabIndex = 2
        Me.ciftxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(566, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(18, 24)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(226, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = " Fax :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(13, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = " Dirección :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(566, 45)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(18, 24)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(566, 111)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(18, 24)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(360, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(18, 24)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(13, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(95, 16)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = " Num. Cliente  "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(271, 143)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(53, 16)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = " Email :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(377, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = " C.I.F.:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(13, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = " Provincia :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(162, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(75, 16)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = " Localidad :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(13, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = " Cod. Postal :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(13, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = " Teléfono :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = " Nombre :   "
        '
        'tablaClientes
        '
        Me.tablaClientes.AllowUserToAddRows = False
        Me.tablaClientes.AllowUserToDeleteRows = False
        Me.tablaClientes.AllowUserToResizeColumns = False
        Me.tablaClientes.AllowUserToResizeRows = False
        Me.tablaClientes.AutoGenerateColumns = False
        Me.tablaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.tablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.LocalidadDataGridViewTextBoxColumn, Me.CifDataGridViewTextBoxColumn})
        Me.tablaClientes.DataSource = Me.ClientesBDS
        Me.tablaClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablaClientes.Location = New System.Drawing.Point(0, 0)
        Me.tablaClientes.MultiSelect = False
        Me.tablaClientes.Name = "tablaClientes"
        Me.tablaClientes.ReadOnly = True
        Me.tablaClientes.RowHeadersVisible = False
        Me.tablaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tablaClientes.Size = New System.Drawing.Size(614, 129)
        Me.tablaClientes.TabIndex = 10
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        Me.NumeroDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroDataGridViewTextBoxColumn.Width = 78
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 78
        '
        'LocalidadDataGridViewTextBoxColumn
        '
        Me.LocalidadDataGridViewTextBoxColumn.DataPropertyName = "Localidad"
        Me.LocalidadDataGridViewTextBoxColumn.HeaderText = "Localidad"
        Me.LocalidadDataGridViewTextBoxColumn.Name = "LocalidadDataGridViewTextBoxColumn"
        Me.LocalidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.LocalidadDataGridViewTextBoxColumn.Width = 88
        '
        'CifDataGridViewTextBoxColumn
        '
        Me.CifDataGridViewTextBoxColumn.DataPropertyName = "Cif"
        Me.CifDataGridViewTextBoxColumn.HeaderText = "Cif"
        Me.CifDataGridViewTextBoxColumn.Name = "CifDataGridViewTextBoxColumn"
        Me.CifDataGridViewTextBoxColumn.ReadOnly = True
        Me.CifDataGridViewTextBoxColumn.Width = 48
        '
        'frmAdClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(614, 391)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.barramenu)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdClientes"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Clientes"
        CType(Me.ClientesBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barramenu.ResumeLayout(False)
        Me.barramenu.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.tablaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Public WithEvents numclientetxt As System.Windows.Forms.TextBox
    Public WithEvents faxtxt As System.Windows.Forms.TextBox
    Public WithEvents direcciontxt As System.Windows.Forms.TextBox
    Public WithEvents provinciatxt As System.Windows.Forms.TextBox
    Public WithEvents localidadtxt As System.Windows.Forms.TextBox
    Public WithEvents cptxt As System.Windows.Forms.TextBox
    Public WithEvents emailtxt As System.Windows.Forms.TextBox
    Public WithEvents telefonotxt As System.Windows.Forms.TextBox
    Public WithEvents ciftxt As System.Windows.Forms.TextBox
    Public WithEvents nombretxt As System.Windows.Forms.TextBox
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tablaClientes As System.Windows.Forms.DataGridView
    Friend WithEvents ClientesBDS As System.Windows.Forms.BindingSource
    Friend WithEvents OleosigDB1 As Oleosig.oleosigDB
    Friend WithEvents NumeroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocalidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CifDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region
End Class