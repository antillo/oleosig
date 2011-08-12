<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAdparAceite
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
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents _barramenu_Button1 As System.Windows.Forms.ToolStripButton
    Public WithEvents _barramenu_Button2 As System.Windows.Forms.ToolStripButton
    Public WithEvents _barramenu_Button3 As System.Windows.Forms.ToolStripButton
    Public WithEvents _barramenu_Button5 As System.Windows.Forms.ToolStripButton
    Public WithEvents _barramenu_Button7 As System.Windows.Forms.ToolStripButton
    Public WithEvents _barramenu_Button9 As System.Windows.Forms.ToolStripButton
    Public WithEvents barramenu As System.Windows.Forms.ToolStrip

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabladetalles = New System.Windows.Forms.DataGridView()
        Me.IdpartidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KilosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detallesBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.OleosigDB1 = New Oleosig.oleosigDB()
        Me.comentstxt = New System.Windows.Forms.TextBox()
        Me.partidasBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.kilosTxt = New System.Windows.Forms.TextBox()
        Me.numpartidaTxt = New System.Windows.Forms.TextBox()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.barramenu = New System.Windows.Forms.ToolStrip()
        Me._barramenu_Button1 = New System.Windows.Forms.ToolStripButton()
        Me._barramenu_Button2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me._barramenu_Button3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me._barramenu_Button5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me._barramenu_Button7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me._barramenu_Button9 = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tablaLotes = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaInicialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanqueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lotesBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.tablaPartidas = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bkworker = New System.ComponentModel.BackgroundWorker()
        Me.Frame1.SuspendLayout()
        CType(Me.tabladetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.detallesBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.partidasBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barramenu.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.tablaLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lotesBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablaPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.tabladetalles)
        Me.Frame1.Controls.Add(Me.comentstxt)
        Me.Frame1.Controls.Add(Me.cmbTipo)
        Me.Frame1.Controls.Add(Me.kilosTxt)
        Me.Frame1.Controls.Add(Me.numpartidaTxt)
        Me.Frame1.Controls.Add(Me.dtFecha)
        Me.Frame1.Controls.Add(Me.Label10)
        Me.Frame1.Controls.Add(Me.Label8)
        Me.Frame1.Controls.Add(Me.Label7)
        Me.Frame1.Controls.Add(Me.Label6)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Frame1.Location = New System.Drawing.Point(3, 3)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(899, 251)
        Me.Frame1.TabIndex = 2
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Partidas de Aceite"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(613, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 17)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Detalles de Partidas"
        '
        'tabladetalles
        '
        Me.tabladetalles.AllowUserToAddRows = False
        Me.tabladetalles.AllowUserToDeleteRows = False
        Me.tabladetalles.AutoGenerateColumns = False
        Me.tabladetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.tabladetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabladetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdpartidaDataGridViewTextBoxColumn, Me.LoteDataGridViewTextBoxColumn, Me.KilosDataGridViewTextBoxColumn})
        Me.tabladetalles.DataSource = Me.detallesBDS
        Me.tabladetalles.Location = New System.Drawing.Point(616, 59)
        Me.tabladetalles.Name = "tabladetalles"
        Me.tabladetalles.ReadOnly = True
        Me.tabladetalles.RowHeadersVisible = False
        Me.tabladetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabladetalles.Size = New System.Drawing.Size(261, 179)
        Me.tabladetalles.TabIndex = 39
        '
        'IdpartidaDataGridViewTextBoxColumn
        '
        Me.IdpartidaDataGridViewTextBoxColumn.DataPropertyName = "Idpartida"
        Me.IdpartidaDataGridViewTextBoxColumn.HeaderText = "Partida"
        Me.IdpartidaDataGridViewTextBoxColumn.Name = "IdpartidaDataGridViewTextBoxColumn"
        Me.IdpartidaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdpartidaDataGridViewTextBoxColumn.Width = 79
        '
        'LoteDataGridViewTextBoxColumn
        '
        Me.LoteDataGridViewTextBoxColumn.DataPropertyName = "Lote"
        Me.LoteDataGridViewTextBoxColumn.HeaderText = "Lote"
        Me.LoteDataGridViewTextBoxColumn.Name = "LoteDataGridViewTextBoxColumn"
        Me.LoteDataGridViewTextBoxColumn.ReadOnly = True
        Me.LoteDataGridViewTextBoxColumn.Width = 61
        '
        'KilosDataGridViewTextBoxColumn
        '
        Me.KilosDataGridViewTextBoxColumn.DataPropertyName = "Kilos"
        Me.KilosDataGridViewTextBoxColumn.HeaderText = "Kilos"
        Me.KilosDataGridViewTextBoxColumn.Name = "KilosDataGridViewTextBoxColumn"
        Me.KilosDataGridViewTextBoxColumn.ReadOnly = True
        Me.KilosDataGridViewTextBoxColumn.Width = 65
        '
        'detallesBDS
        '
        Me.detallesBDS.DataMember = "detalles_partidasaceite"
        Me.detallesBDS.DataSource = Me.OleosigDB1
        '
        'OleosigDB1
        '
        Me.OleosigDB1.DataSetName = "oleosigDB"
        Me.OleosigDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'comentstxt
        '
        Me.comentstxt.AcceptsReturn = True
        Me.comentstxt.BackColor = System.Drawing.SystemColors.Window
        Me.comentstxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.comentstxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.comentstxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.partidasBDS, "Comentarios", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.comentstxt.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comentstxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.comentstxt.Location = New System.Drawing.Point(24, 127)
        Me.comentstxt.MaxLength = 0
        Me.comentstxt.Multiline = True
        Me.comentstxt.Name = "comentstxt"
        Me.comentstxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.comentstxt.Size = New System.Drawing.Size(525, 111)
        Me.comentstxt.TabIndex = 32
        '
        'partidasBDS
        '
        Me.partidasBDS.DataMember = "partidasaceite"
        Me.partidasBDS.DataSource = Me.OleosigDB1
        '
        'cmbTipo
        '
        Me.cmbTipo.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTipo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmbTipo.Location = New System.Drawing.Point(231, 60)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTipo.Size = New System.Drawing.Size(79, 24)
        Me.cmbTipo.TabIndex = 25
        Me.cmbTipo.Text = "Tipo"
        '
        'kilosTxt
        '
        Me.kilosTxt.AcceptsReturn = True
        Me.kilosTxt.BackColor = System.Drawing.SystemColors.Window
        Me.kilosTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kilosTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.partidasBDS, "Kilos", True))
        Me.kilosTxt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kilosTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.kilosTxt.Location = New System.Drawing.Point(87, 59)
        Me.kilosTxt.MaxLength = 0
        Me.kilosTxt.Name = "kilosTxt"
        Me.kilosTxt.ReadOnly = True
        Me.kilosTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.kilosTxt.Size = New System.Drawing.Size(78, 26)
        Me.kilosTxt.TabIndex = 24
        Me.kilosTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numpartidaTxt
        '
        Me.numpartidaTxt.AcceptsReturn = True
        Me.numpartidaTxt.BackColor = System.Drawing.SystemColors.Window
        Me.numpartidaTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numpartidaTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.partidasBDS, "Numero", True))
        Me.numpartidaTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.numpartidaTxt.Location = New System.Drawing.Point(87, 24)
        Me.numpartidaTxt.MaxLength = 0
        Me.numpartidaTxt.Name = "numpartidaTxt"
        Me.numpartidaTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numpartidaTxt.Size = New System.Drawing.Size(79, 25)
        Me.numpartidaTxt.TabIndex = 23
        Me.numpartidaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtFecha
        '
        Me.dtFecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.partidasBDS, "Fecha", True))
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(261, 25)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(129, 25)
        Me.dtFecha.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(24, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(100, 17)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Comentarios :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(188, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(40, 16)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Tipo :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(22, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(45, 16)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Kilos :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(190, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Fecha :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(22, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Partida :"
        '
        'barramenu
        '
        Me.barramenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._barramenu_Button1, Me._barramenu_Button2, Me.ToolStripSeparator1, Me._barramenu_Button3, Me.ToolStripSeparator2, Me._barramenu_Button5, Me.ToolStripSeparator3, Me._barramenu_Button7, Me.ToolStripSeparator4, Me._barramenu_Button9})
        Me.barramenu.Location = New System.Drawing.Point(0, 0)
        Me.barramenu.Name = "barramenu"
        Me.barramenu.Size = New System.Drawing.Size(914, 48)
        Me.barramenu.TabIndex = 1
        '
        '_barramenu_Button1
        '
        Me._barramenu_Button1.AutoSize = False
        Me._barramenu_Button1.Image = Global.Oleosig.My.Resources.Resources.document_new
        Me._barramenu_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._barramenu_Button1.Name = "_barramenu_Button1"
        Me._barramenu_Button1.Size = New System.Drawing.Size(50, 45)
        Me._barramenu_Button1.Text = "Nueva"
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
        '_barramenu_Button3
        '
        Me._barramenu_Button3.AutoSize = False
        Me._barramenu_Button3.Image = Global.Oleosig.My.Resources.Resources.edit_undo
        Me._barramenu_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._barramenu_Button3.Name = "_barramenu_Button3"
        Me._barramenu_Button3.Size = New System.Drawing.Size(50, 45)
        Me._barramenu_Button3.Text = "Cancelar"
        Me._barramenu_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 48)
        '
        '_barramenu_Button5
        '
        Me._barramenu_Button5.AutoSize = False
        Me._barramenu_Button5.Image = Global.Oleosig.My.Resources.Resources.edittrash
        Me._barramenu_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._barramenu_Button5.Name = "_barramenu_Button5"
        Me._barramenu_Button5.Size = New System.Drawing.Size(50, 45)
        Me._barramenu_Button5.Text = "Borrar"
        Me._barramenu_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 48)
        '
        '_barramenu_Button7
        '
        Me._barramenu_Button7.AutoSize = False
        Me._barramenu_Button7.Image = Global.Oleosig.My.Resources.Resources.document_save
        Me._barramenu_Button7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._barramenu_Button7.Name = "_barramenu_Button7"
        Me._barramenu_Button7.Size = New System.Drawing.Size(50, 45)
        Me._barramenu_Button7.Text = "Guardar"
        Me._barramenu_Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 48)
        '
        '_barramenu_Button9
        '
        Me._barramenu_Button9.AutoSize = False
        Me._barramenu_Button9.Image = Global.Oleosig.My.Resources.Resources.dialog_close
        Me._barramenu_Button9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._barramenu_Button9.Name = "_barramenu_Button9"
        Me._barramenu_Button9.Size = New System.Drawing.Size(50, 45)
        Me._barramenu_Button9.Text = "Cerrar"
        Me._barramenu_Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Frame1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 48)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(914, 515)
        Me.TableLayoutPanel1.TabIndex = 16
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tablaLotes, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.tablaPartidas, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 260)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(908, 252)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(5, 5)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Partidas de Aceite"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label9.Location = New System.Drawing.Point(459, 5)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 17)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Lotes de Aceite"
        '
        'tablaLotes
        '
        Me.tablaLotes.AllowUserToAddRows = False
        Me.tablaLotes.AllowUserToDeleteRows = False
        Me.tablaLotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tablaLotes.AutoGenerateColumns = False
        Me.tablaLotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.tablaLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaLotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.NombreDataGridViewTextBoxColumn, Me.FechaInicialDataGridViewTextBoxColumn, Me.FechaFinalDataGridViewTextBoxColumn, Me.TanqueDataGridViewTextBoxColumn})
        Me.tablaLotes.DataSource = Me.lotesBDS
        Me.tablaLotes.Location = New System.Drawing.Point(464, 37)
        Me.tablaLotes.Margin = New System.Windows.Forms.Padding(10)
        Me.tablaLotes.MultiSelect = False
        Me.tablaLotes.Name = "tablaLotes"
        Me.tablaLotes.ReadOnly = True
        Me.tablaLotes.RowHeadersVisible = False
        Me.tablaLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tablaLotes.Size = New System.Drawing.Size(434, 205)
        Me.tablaLotes.TabIndex = 24
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 42
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 77
        '
        'FechaInicialDataGridViewTextBoxColumn
        '
        Me.FechaInicialDataGridViewTextBoxColumn.DataPropertyName = "FechaInicial"
        Me.FechaInicialDataGridViewTextBoxColumn.HeaderText = "FechaInicial"
        Me.FechaInicialDataGridViewTextBoxColumn.Name = "FechaInicialDataGridViewTextBoxColumn"
        Me.FechaInicialDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaInicialDataGridViewTextBoxColumn.Width = 98
        '
        'FechaFinalDataGridViewTextBoxColumn
        '
        Me.FechaFinalDataGridViewTextBoxColumn.DataPropertyName = "FechaFinal"
        Me.FechaFinalDataGridViewTextBoxColumn.HeaderText = "FechaFinal"
        Me.FechaFinalDataGridViewTextBoxColumn.Name = "FechaFinalDataGridViewTextBoxColumn"
        Me.FechaFinalDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaFinalDataGridViewTextBoxColumn.Width = 93
        '
        'TanqueDataGridViewTextBoxColumn
        '
        Me.TanqueDataGridViewTextBoxColumn.DataPropertyName = "Tanque"
        Me.TanqueDataGridViewTextBoxColumn.HeaderText = "Tanque"
        Me.TanqueDataGridViewTextBoxColumn.Name = "TanqueDataGridViewTextBoxColumn"
        Me.TanqueDataGridViewTextBoxColumn.ReadOnly = True
        Me.TanqueDataGridViewTextBoxColumn.Width = 74
        '
        'lotesBDS
        '
        Me.lotesBDS.DataMember = "loteaceite"
        Me.lotesBDS.DataSource = Me.OleosigDB1
        '
        'tablaPartidas
        '
        Me.tablaPartidas.AllowUserToAddRows = False
        Me.tablaPartidas.AllowUserToDeleteRows = False
        Me.tablaPartidas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tablaPartidas.AutoGenerateColumns = False
        Me.tablaPartidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.tablaPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaPartidas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.NumeroDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn})
        Me.tablaPartidas.DataSource = Me.partidasBDS
        Me.tablaPartidas.Location = New System.Drawing.Point(10, 37)
        Me.tablaPartidas.Margin = New System.Windows.Forms.Padding(10)
        Me.tablaPartidas.MultiSelect = False
        Me.tablaPartidas.Name = "tablaPartidas"
        Me.tablaPartidas.ReadOnly = True
        Me.tablaPartidas.RowHeadersVisible = False
        Me.tablaPartidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tablaPartidas.Size = New System.Drawing.Size(417, 205)
        Me.tablaPartidas.TabIndex = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 42
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        Me.NumeroDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroDataGridViewTextBoxColumn.Width = 77
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 66
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoDataGridViewTextBoxColumn.Width = 56
        '
        'bkworker
        '
        '
        'frmAdparAceite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(914, 563)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.barramenu)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(3, 29)
        Me.Name = "frmAdparAceite"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Partidas de Aceite"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.tabladetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.detallesBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.partidasBDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barramenu.ResumeLayout(False)
        Me.barramenu.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.tablaLotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lotesBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablaPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents comentstxt As System.Windows.Forms.TextBox
    Public WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Public WithEvents kilosTxt As System.Windows.Forms.TextBox
    Public WithEvents numpartidaTxt As System.Windows.Forms.TextBox
    Public WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tablaLotes As System.Windows.Forms.DataGridView
    Friend WithEvents lotesBDS As System.Windows.Forms.BindingSource
    Friend WithEvents OleosigDB1 As Oleosig.oleosigDB
    Friend WithEvents tabladetalles As System.Windows.Forms.DataGridView
    Friend WithEvents tablaPartidas As System.Windows.Forms.DataGridView
    Friend WithEvents partidasBDS As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents detallesBDS As System.Windows.Forms.BindingSource
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaInicialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFinalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TanqueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bkworker As System.ComponentModel.BackgroundWorker
    Friend WithEvents IdpartidaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region
End Class