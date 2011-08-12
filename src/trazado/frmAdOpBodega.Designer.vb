<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAdOpBodega
#Region "Código generado por el Diseñador de Windows Forms "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Llamada necesaria para el Diseñador de Windows Forms.
		InitializeComponent()
        Me.MdiParent = frminicial
        frminicial.Show()

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
	Public WithEvents chkAbierta As System.Windows.Forms.CheckBox
    Public WithEvents _Toolbar1_Button1 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button2 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button3 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button5 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button7 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button9 As System.Windows.Forms.ToolStripButton

    Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
    Public WithEvents kilostxt As System.Windows.Forms.TextBox
    Public WithEvents cmbtanques As System.Windows.Forms.ComboBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lbloperacion As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkAbierta = New System.Windows.Forms.CheckBox()
        Me.Toolbar1 = New System.Windows.Forms.ToolStrip()
        Me._Toolbar1_Button1 = New System.Windows.Forms.ToolStripButton()
        Me._Toolbar1_Button2 = New System.Windows.Forms.ToolStripButton()
        Me._Toolbar1_Button3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me._Toolbar1_Button5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me._Toolbar1_Button7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me._Toolbar1_Button9 = New System.Windows.Forms.ToolStripButton()
        Me.kilostxt = New System.Windows.Forms.TextBox()
        Me.cmbtanques = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbloperacion = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tablaMolts = New System.Windows.Forms.DataGridView()
        Me.OperacionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechainiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechafinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LineafabricaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.moltBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.OleosigDB1 = New Oleosig.oleosigDB()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkVerSoloNoImp = New System.Windows.Forms.CheckBox()
        Me.dtfechafin = New System.Windows.Forms.DateTimePicker()
        Me.dtfechaini = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.listaVariedades = New System.Windows.Forms.CheckedListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.totalAceitunaTxt = New System.Windows.Forms.TextBox()
        Me.rendtxt = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tablaopbdg = New System.Windows.Forms.DataGridView()
        Me.OperacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaInicialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanqueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DestinoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.opbdgBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.tablaPartidas = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpfabricaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KilosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detalles_moltBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabladetalles = New System.Windows.Forms.DataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.tanqueBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.Toolbar1.SuspendLayout()
        CType(Me.tablaMolts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.moltBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.tablaopbdg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.opbdgBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablaPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.detalles_moltBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabladetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.tanqueBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkAbierta
        '
        Me.chkAbierta.BackColor = System.Drawing.SystemColors.Control
        Me.chkAbierta.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAbierta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAbierta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.chkAbierta.Location = New System.Drawing.Point(12, 153)
        Me.chkAbierta.Name = "chkAbierta"
        Me.chkAbierta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAbierta.Size = New System.Drawing.Size(92, 25)
        Me.chkAbierta.TabIndex = 17
        Me.chkAbierta.Text = "Abierta"
        Me.chkAbierta.UseVisualStyleBackColor = False
        '
        'Toolbar1
        '
        Me.Toolbar1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Toolbar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._Toolbar1_Button1, Me._Toolbar1_Button2, Me._Toolbar1_Button3, Me.ToolStripSeparator1, Me._Toolbar1_Button5, Me.ToolStripSeparator2, Me._Toolbar1_Button7, Me.ToolStripSeparator3, Me._Toolbar1_Button9})
        Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar1.Name = "Toolbar1"
        Me.Toolbar1.Size = New System.Drawing.Size(1000, 48)
        Me.Toolbar1.TabIndex = 5
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 48)
        '
        '_Toolbar1_Button5
        '
        Me._Toolbar1_Button5.AutoSize = False
        Me._Toolbar1_Button5.Image = Global.Oleosig.My.Resources.Resources.edittrash
        Me._Toolbar1_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button5.Name = "_Toolbar1_Button5"
        Me._Toolbar1_Button5.Size = New System.Drawing.Size(50, 45)
        Me._Toolbar1_Button5.Text = "Borrar"
        Me._Toolbar1_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 48)
        '
        '_Toolbar1_Button7
        '
        Me._Toolbar1_Button7.AutoSize = False
        Me._Toolbar1_Button7.Image = Global.Oleosig.My.Resources.Resources.document_save
        Me._Toolbar1_Button7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button7.Name = "_Toolbar1_Button7"
        Me._Toolbar1_Button7.Size = New System.Drawing.Size(50, 45)
        Me._Toolbar1_Button7.Text = "Guardar"
        Me._Toolbar1_Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 48)
        '
        '_Toolbar1_Button9
        '
        Me._Toolbar1_Button9.AutoSize = False
        Me._Toolbar1_Button9.Image = Global.Oleosig.My.Resources.Resources.dialog_close
        Me._Toolbar1_Button9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button9.Name = "_Toolbar1_Button9"
        Me._Toolbar1_Button9.Size = New System.Drawing.Size(50, 45)
        Me._Toolbar1_Button9.Text = "Cerrar"
        Me._Toolbar1_Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'kilostxt
        '
        Me.kilostxt.AcceptsReturn = True
        Me.kilostxt.BackColor = System.Drawing.SystemColors.Window
        Me.kilostxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kilostxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kilostxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.kilostxt.Location = New System.Drawing.Point(113, 56)
        Me.kilostxt.MaxLength = 0
        Me.kilostxt.Name = "kilostxt"
        Me.kilostxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.kilostxt.Size = New System.Drawing.Size(69, 22)
        Me.kilostxt.TabIndex = 1
        Me.kilostxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbtanques
        '
        Me.cmbtanques.BackColor = System.Drawing.SystemColors.Window
        Me.cmbtanques.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbtanques.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtanques.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmbtanques.Location = New System.Drawing.Point(272, 22)
        Me.cmbtanques.Name = "cmbtanques"
        Me.cmbtanques.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbtanques.Size = New System.Drawing.Size(86, 24)
        Me.cmbtanques.TabIndex = 0
        Me.cmbtanques.Text = "Depósito"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(9, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Operacion :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(9, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Fecha Final :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(98, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Fecha Inicial :"
        '
        'lbloperacion
        '
        Me.lbloperacion.BackColor = System.Drawing.SystemColors.Window
        Me.lbloperacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbloperacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbloperacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbloperacion.Location = New System.Drawing.Point(113, 23)
        Me.lbloperacion.Name = "lbloperacion"
        Me.lbloperacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbloperacion.Size = New System.Drawing.Size(68, 22)
        Me.lbloperacion.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(9, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "K. Aceite :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(185, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Depósito :"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label6.Location = New System.Drawing.Point(5, 221)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 22)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Entradas de aceite"
        '
        'tablaMolts
        '
        Me.tablaMolts.AllowUserToAddRows = False
        Me.tablaMolts.AllowUserToDeleteRows = False
        Me.tablaMolts.AutoGenerateColumns = False
        Me.tablaMolts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.tablaMolts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaMolts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OperacionDataGridViewTextBoxColumn1, Me.FechainiDataGridViewTextBoxColumn, Me.FechafinDataGridViewTextBoxColumn, Me.LineafabricaDataGridViewTextBoxColumn})
        Me.tablaMolts.DataSource = Me.moltBDS
        Me.tablaMolts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablaMolts.Location = New System.Drawing.Point(343, 258)
        Me.tablaMolts.Margin = New System.Windows.Forms.Padding(10)
        Me.tablaMolts.Name = "tablaMolts"
        Me.tablaMolts.ReadOnly = True
        Me.tablaMolts.RowHeadersVisible = False
        Me.tablaMolts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tablaMolts.Size = New System.Drawing.Size(313, 197)
        Me.tablaMolts.TabIndex = 17
        '
        'OperacionDataGridViewTextBoxColumn1
        '
        Me.OperacionDataGridViewTextBoxColumn1.DataPropertyName = "operacion"
        Me.OperacionDataGridViewTextBoxColumn1.HeaderText = "Op."
        Me.OperacionDataGridViewTextBoxColumn1.Name = "OperacionDataGridViewTextBoxColumn1"
        Me.OperacionDataGridViewTextBoxColumn1.ReadOnly = True
        Me.OperacionDataGridViewTextBoxColumn1.Width = 51
        '
        'FechainiDataGridViewTextBoxColumn
        '
        Me.FechainiDataGridViewTextBoxColumn.DataPropertyName = "fechaini"
        Me.FechainiDataGridViewTextBoxColumn.HeaderText = "Fecha Ini"
        Me.FechainiDataGridViewTextBoxColumn.Name = "FechainiDataGridViewTextBoxColumn"
        Me.FechainiDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechainiDataGridViewTextBoxColumn.Width = 82
        '
        'FechafinDataGridViewTextBoxColumn
        '
        Me.FechafinDataGridViewTextBoxColumn.DataPropertyName = "fechafin"
        Me.FechafinDataGridViewTextBoxColumn.HeaderText = "Fecha Fin"
        Me.FechafinDataGridViewTextBoxColumn.Name = "FechafinDataGridViewTextBoxColumn"
        Me.FechafinDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechafinDataGridViewTextBoxColumn.Width = 86
        '
        'LineafabricaDataGridViewTextBoxColumn
        '
        Me.LineafabricaDataGridViewTextBoxColumn.DataPropertyName = "lineafabrica"
        Me.LineafabricaDataGridViewTextBoxColumn.HeaderText = "Linea"
        Me.LineafabricaDataGridViewTextBoxColumn.Name = "LineafabricaDataGridViewTextBoxColumn"
        Me.LineafabricaDataGridViewTextBoxColumn.ReadOnly = True
        Me.LineafabricaDataGridViewTextBoxColumn.Width = 63
        '
        'moltBDS
        '
        Me.moltBDS.DataMember = "opfabrica"
        Me.moltBDS.DataSource = Me.OleosigDB1
        '
        'OleosigDB1
        '
        Me.OleosigDB1.DataSetName = "oleosigDB"
        Me.OleosigDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tablaMolts, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.tablaopbdg, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.tablaPartidas, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.tabladetalles, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 48)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1000, 465)
        Me.TableLayoutPanel2.TabIndex = 19
        '
        'Panel1
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.Panel1, 2)
        Me.Panel1.Controls.Add(Me.chkVerSoloNoImp)
        Me.Panel1.Controls.Add(Me.dtfechafin)
        Me.Panel1.Controls.Add(Me.dtfechaini)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.listaVariedades)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.totalAceitunaTxt)
        Me.Panel1.Controls.Add(Me.rendtxt)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lbloperacion)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.kilostxt)
        Me.Panel1.Controls.Add(Me.chkAbierta)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmbtanques)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(660, 210)
        Me.Panel1.TabIndex = 0
        '
        'chkVerSoloNoImp
        '
        Me.chkVerSoloNoImp.AutoSize = True
        Me.chkVerSoloNoImp.ForeColor = System.Drawing.Color.DarkBlue
        Me.chkVerSoloNoImp.Location = New System.Drawing.Point(524, 182)
        Me.chkVerSoloNoImp.Name = "chkVerSoloNoImp"
        Me.chkVerSoloNoImp.Size = New System.Drawing.Size(156, 19)
        Me.chkVerSoloNoImp.TabIndex = 25
        Me.chkVerSoloNoImp.Text = "Mostrar solo no usadas"
        Me.chkVerSoloNoImp.UseVisualStyleBackColor = True
        '
        'dtfechafin
        '
        Me.dtfechafin.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfechafin.Location = New System.Drawing.Point(113, 121)
        Me.dtfechafin.Name = "dtfechafin"
        Me.dtfechafin.ShowUpDown = True
        Me.dtfechafin.Size = New System.Drawing.Size(133, 21)
        Me.dtfechafin.TabIndex = 24
        '
        'dtfechaini
        '
        Me.dtfechaini.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtfechaini.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfechaini.Location = New System.Drawing.Point(113, 88)
        Me.dtfechaini.Name = "dtfechaini"
        Me.dtfechaini.ShowUpDown = True
        Me.dtfechaini.Size = New System.Drawing.Size(133, 21)
        Me.dtfechaini.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(534, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Actualizar Molt"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'listaVariedades
        '
        Me.listaVariedades.FormattingEnabled = True
        Me.listaVariedades.Location = New System.Drawing.Point(533, 28)
        Me.listaVariedades.Name = "listaVariedades"
        Me.listaVariedades.Size = New System.Drawing.Size(120, 116)
        Me.listaVariedades.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(184, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(89, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "K. Aceituna :"
        '
        'totalAceitunaTxt
        '
        Me.totalAceitunaTxt.AcceptsReturn = True
        Me.totalAceitunaTxt.BackColor = System.Drawing.SystemColors.Window
        Me.totalAceitunaTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.totalAceitunaTxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalAceitunaTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.totalAceitunaTxt.Location = New System.Drawing.Point(274, 56)
        Me.totalAceitunaTxt.MaxLength = 0
        Me.totalAceitunaTxt.Name = "totalAceitunaTxt"
        Me.totalAceitunaTxt.ReadOnly = True
        Me.totalAceitunaTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.totalAceitunaTxt.Size = New System.Drawing.Size(67, 22)
        Me.totalAceitunaTxt.TabIndex = 19
        Me.totalAceitunaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rendtxt
        '
        Me.rendtxt.CausesValidation = False
        Me.rendtxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Oleosig.My.MySettings.Default, "rendopbodega", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.rendtxt.HideSelection = False
        Me.rendtxt.Location = New System.Drawing.Point(407, 57)
        Me.rendtxt.Mask = "99,99"
        Me.rendtxt.Name = "rendtxt"
        Me.rendtxt.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.rendtxt.Size = New System.Drawing.Size(59, 21)
        Me.rendtxt.TabIndex = 3
        Me.rendtxt.Text = Global.Oleosig.My.MySettings.Default.rendopbodega
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(352, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(49, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Rend :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(530, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Variedades"
        '
        'tablaopbdg
        '
        Me.tablaopbdg.AllowUserToAddRows = False
        Me.tablaopbdg.AllowUserToDeleteRows = False
        Me.tablaopbdg.AutoGenerateColumns = False
        Me.tablaopbdg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.tablaopbdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaopbdg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OperacionDataGridViewTextBoxColumn, Me.FechaInicialDataGridViewTextBoxColumn, Me.FechaFinalDataGridViewTextBoxColumn, Me.TanqueDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.DestinoDataGridViewTextBoxColumn})
        Me.tablaopbdg.DataSource = Me.opbdgBDS
        Me.tablaopbdg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablaopbdg.Location = New System.Drawing.Point(10, 258)
        Me.tablaopbdg.Margin = New System.Windows.Forms.Padding(10)
        Me.tablaopbdg.Name = "tablaopbdg"
        Me.tablaopbdg.ReadOnly = True
        Me.tablaopbdg.RowHeadersVisible = False
        Me.tablaopbdg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tablaopbdg.Size = New System.Drawing.Size(313, 197)
        Me.tablaopbdg.TabIndex = 19
        '
        'OperacionDataGridViewTextBoxColumn
        '
        Me.OperacionDataGridViewTextBoxColumn.DataPropertyName = "Operacion"
        Me.OperacionDataGridViewTextBoxColumn.HeaderText = "Operacion"
        Me.OperacionDataGridViewTextBoxColumn.Name = "OperacionDataGridViewTextBoxColumn"
        Me.OperacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.OperacionDataGridViewTextBoxColumn.Width = 89
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
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoDataGridViewTextBoxColumn.Width = 56
        '
        'DestinoDataGridViewTextBoxColumn
        '
        Me.DestinoDataGridViewTextBoxColumn.DataPropertyName = "Destino"
        Me.DestinoDataGridViewTextBoxColumn.HeaderText = "Destino"
        Me.DestinoDataGridViewTextBoxColumn.Name = "DestinoDataGridViewTextBoxColumn"
        Me.DestinoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DestinoDataGridViewTextBoxColumn.Width = 75
        '
        'opbdgBDS
        '
        Me.opbdgBDS.DataMember = "opbodega"
        Me.opbdgBDS.DataSource = Me.OleosigDB1
        '
        'tablaPartidas
        '
        Me.tablaPartidas.AllowUserToAddRows = False
        Me.tablaPartidas.AllowUserToDeleteRows = False
        Me.tablaPartidas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tablaPartidas.AutoGenerateColumns = False
        Me.tablaPartidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.tablaPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaPartidas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.OpfabricaDataGridViewTextBoxColumn, Me.PartidaDataGridViewTextBoxColumn, Me.KilosDataGridViewTextBoxColumn})
        Me.tablaPartidas.DataSource = Me.detalles_moltBDS
        Me.tablaPartidas.Location = New System.Drawing.Point(676, 258)
        Me.tablaPartidas.Margin = New System.Windows.Forms.Padding(10)
        Me.tablaPartidas.Name = "tablaPartidas"
        Me.tablaPartidas.ReadOnly = True
        Me.tablaPartidas.RowHeadersVisible = False
        Me.tablaPartidas.Size = New System.Drawing.Size(314, 173)
        Me.tablaPartidas.TabIndex = 20
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 42
        '
        'OpfabricaDataGridViewTextBoxColumn
        '
        Me.OpfabricaDataGridViewTextBoxColumn.DataPropertyName = "opfabrica"
        Me.OpfabricaDataGridViewTextBoxColumn.HeaderText = "opfabrica"
        Me.OpfabricaDataGridViewTextBoxColumn.Name = "OpfabricaDataGridViewTextBoxColumn"
        Me.OpfabricaDataGridViewTextBoxColumn.ReadOnly = True
        Me.OpfabricaDataGridViewTextBoxColumn.Width = 83
        '
        'PartidaDataGridViewTextBoxColumn
        '
        Me.PartidaDataGridViewTextBoxColumn.DataPropertyName = "partida"
        Me.PartidaDataGridViewTextBoxColumn.HeaderText = "partida"
        Me.PartidaDataGridViewTextBoxColumn.Name = "PartidaDataGridViewTextBoxColumn"
        Me.PartidaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PartidaDataGridViewTextBoxColumn.Width = 70
        '
        'KilosDataGridViewTextBoxColumn
        '
        Me.KilosDataGridViewTextBoxColumn.DataPropertyName = "kilos"
        Me.KilosDataGridViewTextBoxColumn.HeaderText = "kilos"
        Me.KilosDataGridViewTextBoxColumn.Name = "KilosDataGridViewTextBoxColumn"
        Me.KilosDataGridViewTextBoxColumn.ReadOnly = True
        Me.KilosDataGridViewTextBoxColumn.Width = 58
        '
        'detalles_moltBDS
        '
        Me.detalles_moltBDS.DataMember = "detalles_opfabrica"
        Me.detalles_moltBDS.DataSource = Me.OleosigDB1
        '
        'tabladetalles
        '
        Me.tabladetalles.AllowUserToAddRows = False
        Me.tabladetalles.AllowUserToDeleteRows = False
        Me.tabladetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabladetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabladetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column10, Me.Column11})
        Me.tabladetalles.Location = New System.Drawing.Point(676, 10)
        Me.tabladetalles.Margin = New System.Windows.Forms.Padding(10)
        Me.tabladetalles.Name = "tabladetalles"
        Me.tabladetalles.ReadOnly = True
        Me.tabladetalles.RowHeadersVisible = False
        Me.tabladetalles.Size = New System.Drawing.Size(314, 196)
        Me.tabladetalles.TabIndex = 18
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "Opfabrica"
        Me.Column9.HeaderText = "Molturacion"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 80
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "Kilos"
        Me.Column10.HeaderText = "Kilos de Aceite"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 110
        '
        'Column11
        '
        Me.Column11.HeaderText = "Kilos Aceituna"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label10.Location = New System.Drawing.Point(671, 221)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(166, 22)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Detalles Molturaciones"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(336, 219)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(327, 26)
        Me.Panel2.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label7.Location = New System.Drawing.Point(0, 1)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 18)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Molturaciones"
        '
        'BackgroundWorker1
        '
        '
        'frmAdOpBodega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1000, 513)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.Toolbar1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MinimizeBox = False
        Me.Name = "frmAdOpBodega"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Añadir operaciones de Bodega"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Toolbar1.ResumeLayout(False)
        Me.Toolbar1.PerformLayout()
        CType(Me.tablaMolts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.moltBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tablaopbdg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.opbdgBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablaPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.detalles_moltBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabladetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.tanqueBDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tablaMolts As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tabladetalles As System.Windows.Forms.DataGridView
    Friend WithEvents tablaopbdg As System.Windows.Forms.DataGridView
    Friend WithEvents rendtxt As System.Windows.Forms.MaskedTextBox
    Public WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents moltBDS As System.Windows.Forms.BindingSource
    Friend WithEvents OleosigDB1 As Oleosig.oleosigDB
    Friend WithEvents tablaPartidas As System.Windows.Forms.DataGridView
    Friend WithEvents detalles_moltBDS As System.Windows.Forms.BindingSource
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents totalAceitunaTxt As System.Windows.Forms.TextBox
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OpfabricaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PartidaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents listaVariedades As System.Windows.Forms.CheckedListBox
    Public WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtfechafin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtfechaini As System.Windows.Forms.DateTimePicker
    Friend WithEvents OperacionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechainiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechafinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LineafabricaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkVerSoloNoImp As System.Windows.Forms.CheckBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents opbdgBDS As System.Windows.Forms.BindingSource
    Friend WithEvents OperacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaInicialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFinalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TanqueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DestinoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tanqueBDS As System.Windows.Forms.BindingSource
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region
End Class