<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAnalisis
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
	Public WithEvents listaAnalisis As System.Windows.Forms.ListView
	Public WithEvents _SSTab1_TabPage0 As System.Windows.Forms.TabPage
    Public WithEvents _SSTab1_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents SSTab1 As System.Windows.Forms.TabControl
    Public WithEvents _Toolbar1_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents _Toolbar1_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _Toolbar1_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _Toolbar1_Button4 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button6 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button8 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button10 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
    Public WithEvents cmbOrgano As System.Windows.Forms.ComboBox
	Public WithEvents cmbTanque As System.Windows.Forms.ComboBox
	Public WithEvents fechaAnaltxt As System.Windows.Forms.MaskedTextBox
	Public WithEvents _analtxt_14 As System.Windows.Forms.TextBox
	Public WithEvents _analtxt_13 As System.Windows.Forms.TextBox
	Public WithEvents _analtxt_12 As System.Windows.Forms.TextBox
	Public WithEvents _analtxt_11 As System.Windows.Forms.TextBox
	Public WithEvents _analtxt_10 As System.Windows.Forms.TextBox
	Public WithEvents _analtxt_9 As System.Windows.Forms.TextBox
	Public WithEvents _analtxt_8 As System.Windows.Forms.TextBox
	Public WithEvents _analtxt_7 As System.Windows.Forms.TextBox
	Public WithEvents _analtxt_6 As System.Windows.Forms.TextBox
	Public WithEvents _analtxt_5 As System.Windows.Forms.TextBox
	Public WithEvents _analtxt_4 As System.Windows.Forms.TextBox
	Public WithEvents _analtxt_3 As System.Windows.Forms.TextBox
	Public WithEvents _analtxt_2 As System.Windows.Forms.TextBox
	Public WithEvents _analtxt_1 As System.Windows.Forms.TextBox
	Public WithEvents _analtxt_0 As System.Windows.Forms.TextBox
    Public WithEvents _lblnombre_0 As System.Windows.Forms.Label
	Public WithEvents lblLote As System.Windows.Forms.Label
	Public WithEvents _Label1_0 As System.Windows.Forms.Label
	Public WithEvents _Label1_1 As System.Windows.Forms.Label
	Public WithEvents _Label1_2 As System.Windows.Forms.Label
	Public WithEvents _Label1_3 As System.Windows.Forms.Label
	Public WithEvents _Label1_4 As System.Windows.Forms.Label
	Public WithEvents _Label1_5 As System.Windows.Forms.Label
	Public WithEvents _Label1_6 As System.Windows.Forms.Label
	Public WithEvents _Label1_7 As System.Windows.Forms.Label
	Public WithEvents _lblnombre_2 As System.Windows.Forms.Label
	Public WithEvents _Label1_14 As System.Windows.Forms.Label
	Public WithEvents _lblnombre_1 As System.Windows.Forms.Label
	Public WithEvents _Label1_15 As System.Windows.Forms.Label
	Public WithEvents _Label1_13 As System.Windows.Forms.Label
	Public WithEvents _Label1_12 As System.Windows.Forms.Label
	Public WithEvents _Label1_11 As System.Windows.Forms.Label
	Public WithEvents _Label1_10 As System.Windows.Forms.Label
	Public WithEvents _Label1_9 As System.Windows.Forms.Label
	Public WithEvents _Label1_8 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SSTab1 = New System.Windows.Forms.TabControl()
        Me._SSTab1_TabPage0 = New System.Windows.Forms.TabPage()
        Me.listaAnalisis = New System.Windows.Forms.ListView()
        Me._SSTab1_TabPage1 = New System.Windows.Forms.TabPage()
        Me.tablalotes = New System.Windows.Forms.DataGridView()
        Me.lotesBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.OleosigDB1 = New Oleosig.oleosigDB()
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
        Me._Toolbar1_Button10 = New System.Windows.Forms.ToolStripButton()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.cmbOrgano = New System.Windows.Forms.ComboBox()
        Me.cmbTanque = New System.Windows.Forms.ComboBox()
        Me.tanquesBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.fechaAnaltxt = New System.Windows.Forms.MaskedTextBox()
        Me._analtxt_14 = New System.Windows.Forms.TextBox()
        Me._analtxt_13 = New System.Windows.Forms.TextBox()
        Me._analtxt_12 = New System.Windows.Forms.TextBox()
        Me._analtxt_11 = New System.Windows.Forms.TextBox()
        Me._analtxt_10 = New System.Windows.Forms.TextBox()
        Me._analtxt_9 = New System.Windows.Forms.TextBox()
        Me._analtxt_8 = New System.Windows.Forms.TextBox()
        Me._analtxt_7 = New System.Windows.Forms.TextBox()
        Me._analtxt_6 = New System.Windows.Forms.TextBox()
        Me._analtxt_5 = New System.Windows.Forms.TextBox()
        Me._analtxt_4 = New System.Windows.Forms.TextBox()
        Me._analtxt_3 = New System.Windows.Forms.TextBox()
        Me._analtxt_2 = New System.Windows.Forms.TextBox()
        Me._analtxt_1 = New System.Windows.Forms.TextBox()
        Me._analtxt_0 = New System.Windows.Forms.TextBox()
        Me._lblnombre_0 = New System.Windows.Forms.Label()
        Me.lblLote = New System.Windows.Forms.Label()
        Me._Label1_0 = New System.Windows.Forms.Label()
        Me._Label1_1 = New System.Windows.Forms.Label()
        Me._Label1_2 = New System.Windows.Forms.Label()
        Me._Label1_3 = New System.Windows.Forms.Label()
        Me._Label1_4 = New System.Windows.Forms.Label()
        Me._Label1_5 = New System.Windows.Forms.Label()
        Me._Label1_6 = New System.Windows.Forms.Label()
        Me._Label1_7 = New System.Windows.Forms.Label()
        Me._lblnombre_2 = New System.Windows.Forms.Label()
        Me._Label1_14 = New System.Windows.Forms.Label()
        Me._lblnombre_1 = New System.Windows.Forms.Label()
        Me._Label1_15 = New System.Windows.Forms.Label()
        Me._Label1_13 = New System.Windows.Forms.Label()
        Me._Label1_12 = New System.Windows.Forms.Label()
        Me._Label1_11 = New System.Windows.Forms.Label()
        Me._Label1_10 = New System.Windows.Forms.Label()
        Me._Label1_9 = New System.Windows.Forms.Label()
        Me._Label1_8 = New System.Windows.Forms.Label()
        Me.analisisBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaInicialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanqueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSTab1.SuspendLayout()
        Me._SSTab1_TabPage0.SuspendLayout()
        Me._SSTab1_TabPage1.SuspendLayout()
        CType(Me.tablalotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lotesBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Toolbar1.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.tanquesBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.analisisBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SSTab1
        '
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage0)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage1)
        Me.SSTab1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSTab1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SSTab1.ItemSize = New System.Drawing.Size(42, 18)
        Me.SSTab1.Location = New System.Drawing.Point(1, 335)
        Me.SSTab1.Name = "SSTab1"
        Me.SSTab1.SelectedIndex = 0
        Me.SSTab1.Size = New System.Drawing.Size(383, 191)
        Me.SSTab1.TabIndex = 36
        '
        '_SSTab1_TabPage0
        '
        Me._SSTab1_TabPage0.Controls.Add(Me.listaAnalisis)
        Me._SSTab1_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage0.Name = "_SSTab1_TabPage0"
        Me._SSTab1_TabPage0.Size = New System.Drawing.Size(375, 165)
        Me._SSTab1_TabPage0.TabIndex = 0
        Me._SSTab1_TabPage0.Text = "Análisis"
        '
        'listaAnalisis
        '
        Me.listaAnalisis.BackColor = System.Drawing.SystemColors.Window
        Me.listaAnalisis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listaAnalisis.ForeColor = System.Drawing.SystemColors.WindowText
        Me.listaAnalisis.FullRowSelect = True
        Me.listaAnalisis.GridLines = True
        Me.listaAnalisis.Location = New System.Drawing.Point(7, 20)
        Me.listaAnalisis.Name = "listaAnalisis"
        Me.listaAnalisis.Size = New System.Drawing.Size(347, 141)
        Me.listaAnalisis.TabIndex = 37
        Me.listaAnalisis.UseCompatibleStateImageBehavior = False
        Me.listaAnalisis.View = System.Windows.Forms.View.Details
        '
        '_SSTab1_TabPage1
        '
        Me._SSTab1_TabPage1.Controls.Add(Me.tablalotes)
        Me._SSTab1_TabPage1.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage1.Name = "_SSTab1_TabPage1"
        Me._SSTab1_TabPage1.Size = New System.Drawing.Size(375, 165)
        Me._SSTab1_TabPage1.TabIndex = 1
        Me._SSTab1_TabPage1.Text = "Lotes"
        '
        'tablalotes
        '
        Me.tablalotes.AllowUserToAddRows = False
        Me.tablalotes.AllowUserToDeleteRows = False
        Me.tablalotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tablalotes.AutoGenerateColumns = False
        Me.tablalotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.tablalotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablalotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn, Me.FechaInicialDataGridViewTextBoxColumn, Me.FechaFinalDataGridViewTextBoxColumn, Me.TanqueDataGridViewTextBoxColumn})
        Me.tablalotes.DataSource = Me.lotesBDS
        Me.tablalotes.Location = New System.Drawing.Point(7, 11)
        Me.tablalotes.Name = "tablalotes"
        Me.tablalotes.ReadOnly = True
        Me.tablalotes.RowHeadersVisible = False
        Me.tablalotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tablalotes.Size = New System.Drawing.Size(360, 150)
        Me.tablalotes.TabIndex = 0
        '
        'lotesBDS
        '
        Me.lotesBDS.DataMember = "loteaceite"
        Me.lotesBDS.DataSource = Me.OleosigDB1
        '
        'OleosigDB1
        '
        Me.OleosigDB1.DataSetName = "oleosigDB"
        Me.OleosigDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Toolbar1
        '
        Me.Toolbar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._Toolbar1_Button1, Me._Toolbar1_Button2, Me.ToolStripSeparator1, Me._Toolbar1_Button3, Me.ToolStripSeparator2, Me._Toolbar1_Button4, Me.ToolStripSeparator3, Me._Toolbar1_Button6, Me.ToolStripSeparator4, Me._Toolbar1_Button8, Me._Toolbar1_Button10})
        Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar1.Name = "Toolbar1"
        Me.Toolbar1.Size = New System.Drawing.Size(402, 48)
        Me.Toolbar1.TabIndex = 20
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
        Me._Toolbar1_Button4.Image = Global.Oleosig.My.Resources.Resources.printer
        Me._Toolbar1_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button4.Name = "_Toolbar1_Button4"
        Me._Toolbar1_Button4.Size = New System.Drawing.Size(50, 45)
        Me._Toolbar1_Button4.Text = "Imprimir"
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
        Me._Toolbar1_Button8.Image = Global.Oleosig.My.Resources.Resources.document_save
        Me._Toolbar1_Button8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button8.Name = "_Toolbar1_Button8"
        Me._Toolbar1_Button8.Size = New System.Drawing.Size(50, 45)
        Me._Toolbar1_Button8.Text = "Guardar"
        Me._Toolbar1_Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        '_Toolbar1_Button10
        '
        Me._Toolbar1_Button10.AutoSize = False
        Me._Toolbar1_Button10.Image = Global.Oleosig.My.Resources.Resources.dialog_close
        Me._Toolbar1_Button10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button10.Name = "_Toolbar1_Button10"
        Me._Toolbar1_Button10.Size = New System.Drawing.Size(50, 45)
        Me._Toolbar1_Button10.Text = "Salir"
        Me._Toolbar1_Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.cmbOrgano)
        Me.Frame1.Controls.Add(Me.cmbTanque)
        Me.Frame1.Controls.Add(Me.fechaAnaltxt)
        Me.Frame1.Controls.Add(Me._analtxt_14)
        Me.Frame1.Controls.Add(Me._analtxt_13)
        Me.Frame1.Controls.Add(Me._analtxt_12)
        Me.Frame1.Controls.Add(Me._analtxt_11)
        Me.Frame1.Controls.Add(Me._analtxt_10)
        Me.Frame1.Controls.Add(Me._analtxt_9)
        Me.Frame1.Controls.Add(Me._analtxt_8)
        Me.Frame1.Controls.Add(Me._analtxt_7)
        Me.Frame1.Controls.Add(Me._analtxt_6)
        Me.Frame1.Controls.Add(Me._analtxt_5)
        Me.Frame1.Controls.Add(Me._analtxt_4)
        Me.Frame1.Controls.Add(Me._analtxt_3)
        Me.Frame1.Controls.Add(Me._analtxt_2)
        Me.Frame1.Controls.Add(Me._analtxt_1)
        Me.Frame1.Controls.Add(Me._analtxt_0)
        Me.Frame1.Controls.Add(Me._lblnombre_0)
        Me.Frame1.Controls.Add(Me.lblLote)
        Me.Frame1.Controls.Add(Me._Label1_0)
        Me.Frame1.Controls.Add(Me._Label1_1)
        Me.Frame1.Controls.Add(Me._Label1_2)
        Me.Frame1.Controls.Add(Me._Label1_3)
        Me.Frame1.Controls.Add(Me._Label1_4)
        Me.Frame1.Controls.Add(Me._Label1_5)
        Me.Frame1.Controls.Add(Me._Label1_6)
        Me.Frame1.Controls.Add(Me._Label1_7)
        Me.Frame1.Controls.Add(Me._lblnombre_2)
        Me.Frame1.Controls.Add(Me._Label1_14)
        Me.Frame1.Controls.Add(Me._lblnombre_1)
        Me.Frame1.Controls.Add(Me._Label1_15)
        Me.Frame1.Controls.Add(Me._Label1_13)
        Me.Frame1.Controls.Add(Me._Label1_12)
        Me.Frame1.Controls.Add(Me._Label1_11)
        Me.Frame1.Controls.Add(Me._Label1_10)
        Me.Frame1.Controls.Add(Me._Label1_9)
        Me.Frame1.Controls.Add(Me._Label1_8)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Frame1.Location = New System.Drawing.Point(1, 54)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(387, 270)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Analisis"
        '
        'cmbOrgano
        '
        Me.cmbOrgano.BackColor = System.Drawing.SystemColors.Window
        Me.cmbOrgano.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbOrgano.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbOrgano.Location = New System.Drawing.Point(275, 235)
        Me.cmbOrgano.Name = "cmbOrgano"
        Me.cmbOrgano.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbOrgano.Size = New System.Drawing.Size(97, 22)
        Me.cmbOrgano.TabIndex = 42
        Me.cmbOrgano.Text = "Combo1"
        '
        'cmbTanque
        '
        Me.cmbTanque.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTanque.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbTanque.DataSource = Me.tanquesBDS
        Me.cmbTanque.DisplayMember = "Nombre"
        Me.cmbTanque.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTanque.Location = New System.Drawing.Point(144, 40)
        Me.cmbTanque.Name = "cmbTanque"
        Me.cmbTanque.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTanque.Size = New System.Drawing.Size(81, 22)
        Me.cmbTanque.TabIndex = 41
        Me.cmbTanque.ValueMember = "Numero"
        '
        'tanquesBDS
        '
        Me.tanquesBDS.AllowNew = False
        Me.tanquesBDS.DataMember = "tanques"
        Me.tanquesBDS.DataSource = Me.OleosigDB1
        '
        'fechaAnaltxt
        '
        Me.fechaAnaltxt.AllowPromptAsInput = False
        Me.fechaAnaltxt.Location = New System.Drawing.Point(144, 64)
        Me.fechaAnaltxt.Mask = "##/##/####"
        Me.fechaAnaltxt.Name = "fechaAnaltxt"
        Me.fechaAnaltxt.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.fechaAnaltxt.Size = New System.Drawing.Size(85, 20)
        Me.fechaAnaltxt.TabIndex = 40
        '
        '_analtxt_14
        '
        Me._analtxt_14.AcceptsReturn = True
        Me._analtxt_14.BackColor = System.Drawing.SystemColors.Window
        Me._analtxt_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._analtxt_14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._analtxt_14.Location = New System.Drawing.Point(329, 214)
        Me._analtxt_14.MaxLength = 0
        Me._analtxt_14.Name = "_analtxt_14"
        Me._analtxt_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._analtxt_14.Size = New System.Drawing.Size(43, 20)
        Me._analtxt_14.TabIndex = 35
        Me._analtxt_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_analtxt_13
        '
        Me._analtxt_13.AcceptsReturn = True
        Me._analtxt_13.BackColor = System.Drawing.SystemColors.Window
        Me._analtxt_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._analtxt_13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._analtxt_13.Location = New System.Drawing.Point(329, 192)
        Me._analtxt_13.MaxLength = 0
        Me._analtxt_13.Name = "_analtxt_13"
        Me._analtxt_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._analtxt_13.Size = New System.Drawing.Size(43, 20)
        Me._analtxt_13.TabIndex = 34
        Me._analtxt_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_analtxt_12
        '
        Me._analtxt_12.AcceptsReturn = True
        Me._analtxt_12.BackColor = System.Drawing.SystemColors.Window
        Me._analtxt_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._analtxt_12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._analtxt_12.Location = New System.Drawing.Point(329, 170)
        Me._analtxt_12.MaxLength = 0
        Me._analtxt_12.Name = "_analtxt_12"
        Me._analtxt_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._analtxt_12.Size = New System.Drawing.Size(43, 20)
        Me._analtxt_12.TabIndex = 33
        Me._analtxt_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_analtxt_11
        '
        Me._analtxt_11.AcceptsReturn = True
        Me._analtxt_11.BackColor = System.Drawing.SystemColors.Window
        Me._analtxt_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._analtxt_11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._analtxt_11.Location = New System.Drawing.Point(329, 148)
        Me._analtxt_11.MaxLength = 0
        Me._analtxt_11.Name = "_analtxt_11"
        Me._analtxt_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._analtxt_11.Size = New System.Drawing.Size(43, 20)
        Me._analtxt_11.TabIndex = 32
        Me._analtxt_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_analtxt_10
        '
        Me._analtxt_10.AcceptsReturn = True
        Me._analtxt_10.BackColor = System.Drawing.SystemColors.Window
        Me._analtxt_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._analtxt_10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._analtxt_10.Location = New System.Drawing.Point(329, 126)
        Me._analtxt_10.MaxLength = 0
        Me._analtxt_10.Name = "_analtxt_10"
        Me._analtxt_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._analtxt_10.Size = New System.Drawing.Size(43, 20)
        Me._analtxt_10.TabIndex = 31
        Me._analtxt_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_analtxt_9
        '
        Me._analtxt_9.AcceptsReturn = True
        Me._analtxt_9.BackColor = System.Drawing.SystemColors.Window
        Me._analtxt_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._analtxt_9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._analtxt_9.Location = New System.Drawing.Point(329, 104)
        Me._analtxt_9.MaxLength = 0
        Me._analtxt_9.Name = "_analtxt_9"
        Me._analtxt_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._analtxt_9.Size = New System.Drawing.Size(43, 20)
        Me._analtxt_9.TabIndex = 30
        Me._analtxt_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_analtxt_8
        '
        Me._analtxt_8.AcceptsReturn = True
        Me._analtxt_8.BackColor = System.Drawing.SystemColors.Window
        Me._analtxt_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._analtxt_8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._analtxt_8.Location = New System.Drawing.Point(329, 82)
        Me._analtxt_8.MaxLength = 0
        Me._analtxt_8.Name = "_analtxt_8"
        Me._analtxt_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._analtxt_8.Size = New System.Drawing.Size(43, 20)
        Me._analtxt_8.TabIndex = 29
        Me._analtxt_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_analtxt_7
        '
        Me._analtxt_7.AcceptsReturn = True
        Me._analtxt_7.BackColor = System.Drawing.SystemColors.Window
        Me._analtxt_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._analtxt_7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._analtxt_7.Location = New System.Drawing.Point(144, 236)
        Me._analtxt_7.MaxLength = 0
        Me._analtxt_7.Name = "_analtxt_7"
        Me._analtxt_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._analtxt_7.Size = New System.Drawing.Size(43, 20)
        Me._analtxt_7.TabIndex = 28
        Me._analtxt_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_analtxt_6
        '
        Me._analtxt_6.AcceptsReturn = True
        Me._analtxt_6.BackColor = System.Drawing.SystemColors.Window
        Me._analtxt_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._analtxt_6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._analtxt_6.Location = New System.Drawing.Point(144, 215)
        Me._analtxt_6.MaxLength = 0
        Me._analtxt_6.Name = "_analtxt_6"
        Me._analtxt_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._analtxt_6.Size = New System.Drawing.Size(43, 20)
        Me._analtxt_6.TabIndex = 27
        Me._analtxt_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_analtxt_5
        '
        Me._analtxt_5.AcceptsReturn = True
        Me._analtxt_5.BackColor = System.Drawing.SystemColors.Window
        Me._analtxt_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._analtxt_5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._analtxt_5.Location = New System.Drawing.Point(144, 193)
        Me._analtxt_5.MaxLength = 0
        Me._analtxt_5.Name = "_analtxt_5"
        Me._analtxt_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._analtxt_5.Size = New System.Drawing.Size(43, 20)
        Me._analtxt_5.TabIndex = 26
        Me._analtxt_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_analtxt_4
        '
        Me._analtxt_4.AcceptsReturn = True
        Me._analtxt_4.BackColor = System.Drawing.SystemColors.Window
        Me._analtxt_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._analtxt_4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._analtxt_4.Location = New System.Drawing.Point(144, 171)
        Me._analtxt_4.MaxLength = 0
        Me._analtxt_4.Name = "_analtxt_4"
        Me._analtxt_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._analtxt_4.Size = New System.Drawing.Size(43, 20)
        Me._analtxt_4.TabIndex = 25
        Me._analtxt_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_analtxt_3
        '
        Me._analtxt_3.AcceptsReturn = True
        Me._analtxt_3.BackColor = System.Drawing.SystemColors.Window
        Me._analtxt_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._analtxt_3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._analtxt_3.Location = New System.Drawing.Point(144, 149)
        Me._analtxt_3.MaxLength = 0
        Me._analtxt_3.Name = "_analtxt_3"
        Me._analtxt_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._analtxt_3.Size = New System.Drawing.Size(43, 20)
        Me._analtxt_3.TabIndex = 24
        Me._analtxt_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_analtxt_2
        '
        Me._analtxt_2.AcceptsReturn = True
        Me._analtxt_2.BackColor = System.Drawing.SystemColors.Window
        Me._analtxt_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._analtxt_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._analtxt_2.Location = New System.Drawing.Point(144, 127)
        Me._analtxt_2.MaxLength = 0
        Me._analtxt_2.Name = "_analtxt_2"
        Me._analtxt_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._analtxt_2.Size = New System.Drawing.Size(43, 20)
        Me._analtxt_2.TabIndex = 23
        Me._analtxt_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_analtxt_1
        '
        Me._analtxt_1.AcceptsReturn = True
        Me._analtxt_1.BackColor = System.Drawing.SystemColors.Window
        Me._analtxt_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._analtxt_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._analtxt_1.Location = New System.Drawing.Point(144, 106)
        Me._analtxt_1.MaxLength = 0
        Me._analtxt_1.Name = "_analtxt_1"
        Me._analtxt_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._analtxt_1.Size = New System.Drawing.Size(43, 20)
        Me._analtxt_1.TabIndex = 22
        Me._analtxt_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_analtxt_0
        '
        Me._analtxt_0.AcceptsReturn = True
        Me._analtxt_0.BackColor = System.Drawing.SystemColors.Window
        Me._analtxt_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._analtxt_0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._analtxt_0.Location = New System.Drawing.Point(144, 84)
        Me._analtxt_0.MaxLength = 0
        Me._analtxt_0.Name = "_analtxt_0"
        Me._analtxt_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._analtxt_0.Size = New System.Drawing.Size(43, 20)
        Me._analtxt_0.TabIndex = 21
        Me._analtxt_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_lblnombre_0
        '
        Me._lblnombre_0.AutoSize = True
        Me._lblnombre_0.BackColor = System.Drawing.SystemColors.Control
        Me._lblnombre_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblnombre_0.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblnombre_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblnombre_0.Location = New System.Drawing.Point(18, 20)
        Me._lblnombre_0.Name = "_lblnombre_0"
        Me._lblnombre_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblnombre_0.Size = New System.Drawing.Size(31, 15)
        Me._lblnombre_0.TabIndex = 43
        Me._lblnombre_0.Text = "Lote"
        '
        'lblLote
        '
        Me.lblLote.BackColor = System.Drawing.SystemColors.Window
        Me.lblLote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLote.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLote.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.lotesBDS, "Nombre", True))
        Me.lblLote.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLote.Location = New System.Drawing.Point(144, 16)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLote.Size = New System.Drawing.Size(43, 19)
        Me.lblLote.TabIndex = 39
        '
        '_Label1_0
        '
        Me._Label1_0.AutoSize = True
        Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_0.Location = New System.Drawing.Point(18, 84)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(64, 15)
        Me._Label1_0.TabIndex = 18
        Me._Label1_0.Text = "Acidez (%)"
        '
        '_Label1_1
        '
        Me._Label1_1.AutoSize = True
        Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_1.Location = New System.Drawing.Point(18, 106)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_1.Size = New System.Drawing.Size(128, 15)
        Me._Label1_1.TabIndex = 17
        Me._Label1_1.Text = "Peróxidos (meg/O/Kg)"
        '
        '_Label1_2
        '
        Me._Label1_2.AutoSize = True
        Me._Label1_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_2.Location = New System.Drawing.Point(18, 128)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_2.Size = New System.Drawing.Size(36, 15)
        Me._Label1_2.TabIndex = 16
        Me._Label1_2.Text = "K270"
        '
        '_Label1_3
        '
        Me._Label1_3.AutoSize = True
        Me._Label1_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_3.Location = New System.Drawing.Point(18, 150)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_3.Size = New System.Drawing.Size(36, 15)
        Me._Label1_3.TabIndex = 15
        Me._Label1_3.Text = "K232"
        '
        '_Label1_4
        '
        Me._Label1_4.AutoSize = True
        Me._Label1_4.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_4.Location = New System.Drawing.Point(18, 172)
        Me._Label1_4.Name = "_Label1_4"
        Me._Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_4.Size = New System.Drawing.Size(41, 15)
        Me._Label1_4.TabIndex = 14
        Me._Label1_4.Text = "Ceras"
        '
        '_Label1_5
        '
        Me._Label1_5.AutoSize = True
        Me._Label1_5.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_5.Location = New System.Drawing.Point(18, 194)
        Me._Label1_5.Name = "_Label1_5"
        Me._Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_5.Size = New System.Drawing.Size(130, 15)
        Me._Label1_5.TabIndex = 13
        Me._Label1_5.Text = "Esteroles Tot. (mg/Kg)"
        '
        '_Label1_6
        '
        Me._Label1_6.AutoSize = True
        Me._Label1_6.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_6.Location = New System.Drawing.Point(18, 216)
        Me._Label1_6.Name = "_Label1_6"
        Me._Label1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_6.Size = New System.Drawing.Size(86, 15)
        Me._Label1_6.TabIndex = 12
        Me._Label1_6.Text = "Colesterol (%)"
        '
        '_Label1_7
        '
        Me._Label1_7.AutoSize = True
        Me._Label1_7.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_7.Location = New System.Drawing.Point(18, 238)
        Me._Label1_7.Name = "_Label1_7"
        Me._Label1_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_7.Size = New System.Drawing.Size(102, 15)
        Me._Label1_7.TabIndex = 11
        Me._Label1_7.Text = "Brasicasterol (%)"
        '
        '_lblnombre_2
        '
        Me._lblnombre_2.AutoSize = True
        Me._lblnombre_2.BackColor = System.Drawing.SystemColors.Control
        Me._lblnombre_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblnombre_2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblnombre_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblnombre_2.Location = New System.Drawing.Point(18, 62)
        Me._lblnombre_2.Name = "_lblnombre_2"
        Me._lblnombre_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblnombre_2.Size = New System.Drawing.Size(88, 15)
        Me._lblnombre_2.TabIndex = 10
        Me._lblnombre_2.Text = "Fecha Analisis"
        '
        '_Label1_14
        '
        Me._Label1_14.AutoSize = True
        Me._Label1_14.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_14.Location = New System.Drawing.Point(192, 216)
        Me._Label1_14.Name = "_Label1_14"
        Me._Label1_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_14.Size = New System.Drawing.Size(113, 15)
        Me._Label1_14.TabIndex = 9
        Me._Label1_14.Text = "Alcoholes Alifáticos"
        '
        '_lblnombre_1
        '
        Me._lblnombre_1.AutoSize = True
        Me._lblnombre_1.BackColor = System.Drawing.SystemColors.Control
        Me._lblnombre_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblnombre_1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblnombre_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblnombre_1.Location = New System.Drawing.Point(18, 40)
        Me._lblnombre_1.Name = "_lblnombre_1"
        Me._lblnombre_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblnombre_1.Size = New System.Drawing.Size(63, 15)
        Me._lblnombre_1.TabIndex = 8
        Me._lblnombre_1.Text = "Depósito :"
        '
        '_Label1_15
        '
        Me._Label1_15.AutoSize = True
        Me._Label1_15.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_15.Location = New System.Drawing.Point(192, 238)
        Me._Label1_15.Name = "_Label1_15"
        Me._Label1_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_15.Size = New System.Drawing.Size(84, 15)
        Me._Label1_15.TabIndex = 7
        Me._Label1_15.Text = "Organoleptico"
        '
        '_Label1_13
        '
        Me._Label1_13.AutoSize = True
        Me._Label1_13.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_13.Location = New System.Drawing.Point(192, 194)
        Me._Label1_13.Name = "_Label1_13"
        Me._Label1_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_13.Size = New System.Drawing.Size(68, 15)
        Me._Label1_13.TabIndex = 6
        Me._Label1_13.Text = "Trilinoleina"
        '
        '_Label1_12
        '
        Me._Label1_12.AutoSize = True
        Me._Label1_12.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_12.Location = New System.Drawing.Point(192, 172)
        Me._Label1_12.Name = "_Label1_12"
        Me._Label1_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_12.Size = New System.Drawing.Size(78, 15)
        Me._Label1_12.TabIndex = 5
        Me._Label1_12.Text = "Eritrodiol (%)"
        '
        '_Label1_11
        '
        Me._Label1_11.AutoSize = True
        Me._Label1_11.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_11.Location = New System.Drawing.Point(192, 150)
        Me._Label1_11.Name = "_Label1_11"
        Me._Label1_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_11.Size = New System.Drawing.Size(108, 15)
        Me._Label1_11.TabIndex = 4
        Me._Label1_11.Text = "D-7-Estigmasterol"
        '
        '_Label1_10
        '
        Me._Label1_10.AutoSize = True
        Me._Label1_10.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_10.Location = New System.Drawing.Point(192, 128)
        Me._Label1_10.Name = "_Label1_10"
        Me._Label1_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_10.Size = New System.Drawing.Size(109, 15)
        Me._Label1_10.TabIndex = 3
        Me._Label1_10.Text = "Beta-sitosterol (%)"
        '
        '_Label1_9
        '
        Me._Label1_9.AutoSize = True
        Me._Label1_9.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_9.Location = New System.Drawing.Point(192, 106)
        Me._Label1_9.Name = "_Label1_9"
        Me._Label1_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_9.Size = New System.Drawing.Size(106, 15)
        Me._Label1_9.TabIndex = 2
        Me._Label1_9.Text = "Estigmasterol (%)"
        '
        '_Label1_8
        '
        Me._Label1_8.AutoSize = True
        Me._Label1_8.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_8.Location = New System.Drawing.Point(192, 84)
        Me._Label1_8.Name = "_Label1_8"
        Me._Label1_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_8.Size = New System.Drawing.Size(101, 15)
        Me._Label1_8.TabIndex = 1
        Me._Label1_8.Text = "Campesterol (%)"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 69
        '
        'FechaInicialDataGridViewTextBoxColumn
        '
        Me.FechaInicialDataGridViewTextBoxColumn.DataPropertyName = "FechaInicial"
        Me.FechaInicialDataGridViewTextBoxColumn.HeaderText = "FechaInicial"
        Me.FechaInicialDataGridViewTextBoxColumn.Name = "FechaInicialDataGridViewTextBoxColumn"
        Me.FechaInicialDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaInicialDataGridViewTextBoxColumn.Width = 88
        '
        'FechaFinalDataGridViewTextBoxColumn
        '
        Me.FechaFinalDataGridViewTextBoxColumn.DataPropertyName = "FechaFinal"
        Me.FechaFinalDataGridViewTextBoxColumn.HeaderText = "FechaFinal"
        Me.FechaFinalDataGridViewTextBoxColumn.Name = "FechaFinalDataGridViewTextBoxColumn"
        Me.FechaFinalDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaFinalDataGridViewTextBoxColumn.Width = 84
        '
        'TanqueDataGridViewTextBoxColumn
        '
        Me.TanqueDataGridViewTextBoxColumn.DataPropertyName = "Tanque"
        Me.TanqueDataGridViewTextBoxColumn.HeaderText = "Depósito"
        Me.TanqueDataGridViewTextBoxColumn.Name = "TanqueDataGridViewTextBoxColumn"
        Me.TanqueDataGridViewTextBoxColumn.ReadOnly = True
        Me.TanqueDataGridViewTextBoxColumn.Width = 74
        '
        'frmAnalisis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(402, 530)
        Me.Controls.Add(Me.SSTab1)
        Me.Controls.Add(Me.Toolbar1)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAnalisis"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Analisis del Lote"
        Me.SSTab1.ResumeLayout(False)
        Me._SSTab1_TabPage0.ResumeLayout(False)
        Me._SSTab1_TabPage1.ResumeLayout(False)
        CType(Me.tablalotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lotesBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Toolbar1.ResumeLayout(False)
        Me.Toolbar1.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.tanquesBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.analisisBDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents analisisBDS As System.Windows.Forms.BindingSource
    Friend WithEvents lotesBDS As System.Windows.Forms.BindingSource
    Friend WithEvents OleosigDB1 As Oleosig.oleosigDB
    Friend WithEvents tablalotes As System.Windows.Forms.DataGridView
    Friend WithEvents tanquesBDS As System.Windows.Forms.BindingSource
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaInicialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFinalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TanqueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region 
End Class