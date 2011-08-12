<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAdPaAceituna
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
    Public WithEvents chkAbierta As System.Windows.Forms.CheckBox
    Public WithEvents cmbTolvas As System.Windows.Forms.ComboBox
	Public WithEvents kilosTxt As System.Windows.Forms.TextBox
    Public WithEvents _Toolbar1_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents _Toolbar1_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _Toolbar1_Button3 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents _Toolbar1_Button6 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button8 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
    Public WithEvents numPartidaAc As System.Windows.Forms.TextBox
    Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkAbierta = New System.Windows.Forms.CheckBox()
        Me.cmbTolvas = New System.Windows.Forms.ComboBox()
        Me.partidaBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.OleosigDB1 = New Oleosig.oleosigDB()
        Me.tolvasBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.kilosTxt = New System.Windows.Forms.TextBox()
        Me.Toolbar1 = New System.Windows.Forms.ToolStrip()
        Me._Toolbar1_Button1 = New System.Windows.Forms.ToolStripButton()
        Me._Toolbar1_Button2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me._Toolbar1_Button3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me._Toolbar1_Button5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me._Toolbar1_Button6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me._Toolbar1_Button8 = New System.Windows.Forms.ToolStripButton()
        Me.numPartidaAc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblidparaceituna = New System.Windows.Forms.Label()
        Me.ticketsBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.tablaPartidas = New System.Windows.Forms.DataGridView()
        Me.calBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtfechafin = New System.Windows.Forms.DateTimePicker()
        Me.dtfechaini = New System.Windows.Forms.DateTimePicker()
        Me.dtfechainivac = New System.Windows.Forms.DateTimePicker()
        Me.dtfechafinvac = New System.Windows.Forms.DateTimePicker()
        Me.varBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.chkImport = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbVariedad = New System.Windows.Forms.ComboBox()
        Me.cmbCalidad = New System.Windows.Forms.ComboBox()
        Me.tablatickets = New System.Windows.Forms.DataGridView()
        Me.NumeroDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KilosDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TolvaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BasculaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VariedadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BKW = New System.ComponentModel.BackgroundWorker()
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaIniLlenadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFinLlenadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaIniVaciadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFinVaciadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TolvaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.KilosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.partidaBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tolvasBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Toolbar1.SuspendLayout()
        CType(Me.ticketsBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablaPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.calBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.varBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablatickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkAbierta
        '
        Me.chkAbierta.BackColor = System.Drawing.SystemColors.Control
        Me.chkAbierta.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAbierta.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAbierta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.chkAbierta.Location = New System.Drawing.Point(551, 61)
        Me.chkAbierta.Name = "chkAbierta"
        Me.chkAbierta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAbierta.Size = New System.Drawing.Size(86, 19)
        Me.chkAbierta.TabIndex = 16
        Me.chkAbierta.Text = "Abierta"
        Me.chkAbierta.UseVisualStyleBackColor = False
        '
        'cmbTolvas
        '
        Me.cmbTolvas.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTolvas.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbTolvas.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.partidaBDS, "Tolva", True))
        Me.cmbTolvas.DataSource = Me.tolvasBDS
        Me.cmbTolvas.DisplayMember = "Nombre"
        Me.cmbTolvas.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTolvas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmbTolvas.Location = New System.Drawing.Point(324, 57)
        Me.cmbTolvas.Name = "cmbTolvas"
        Me.cmbTolvas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTolvas.Size = New System.Drawing.Size(80, 26)
        Me.cmbTolvas.TabIndex = 1
        Me.cmbTolvas.ValueMember = "Numero"
        '
        'partidaBDS
        '
        Me.partidaBDS.DataMember = "partidasaceituna"
        Me.partidaBDS.DataSource = Me.OleosigDB1
        '
        'OleosigDB1
        '
        Me.OleosigDB1.DataSetName = "oleosigDB"
        Me.OleosigDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tolvasBDS
        '
        Me.tolvasBDS.AllowNew = False
        Me.tolvasBDS.DataMember = "tolvas"
        Me.tolvasBDS.DataSource = Me.OleosigDB1
        '
        'kilosTxt
        '
        Me.kilosTxt.AcceptsReturn = True
        Me.kilosTxt.BackColor = System.Drawing.SystemColors.Window
        Me.kilosTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kilosTxt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kilosTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.kilosTxt.Location = New System.Drawing.Point(465, 57)
        Me.kilosTxt.MaxLength = 0
        Me.kilosTxt.Name = "kilosTxt"
        Me.kilosTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.kilosTxt.Size = New System.Drawing.Size(65, 26)
        Me.kilosTxt.TabIndex = 1
        Me.kilosTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Toolbar1
        '
        Me.Toolbar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._Toolbar1_Button1, Me._Toolbar1_Button2, Me.ToolStripSeparator1, Me._Toolbar1_Button3, Me.ToolStripSeparator2, Me._Toolbar1_Button5, Me.ToolStripSeparator3, Me._Toolbar1_Button6, Me.ToolStripSeparator4, Me._Toolbar1_Button8})
        Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar1.Name = "Toolbar1"
        Me.Toolbar1.Size = New System.Drawing.Size(1050, 48)
        Me.Toolbar1.TabIndex = 12
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
        Me._Toolbar1_Button1.ToolTipText = "Crea una nueva partida"
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
        Me._Toolbar1_Button2.ToolTipText = "Cierra una partida abierta"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 48)
        '
        '_Toolbar1_Button3
        '
        Me._Toolbar1_Button3.AutoSize = False
        Me._Toolbar1_Button3.Image = Global.Oleosig.My.Resources.Resources.edittrash
        Me._Toolbar1_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button3.Name = "_Toolbar1_Button3"
        Me._Toolbar1_Button3.Size = New System.Drawing.Size(50, 45)
        Me._Toolbar1_Button3.Text = "Borrar"
        Me._Toolbar1_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 48)
        '
        '_Toolbar1_Button5
        '
        Me._Toolbar1_Button5.AutoSize = False
        Me._Toolbar1_Button5.Image = Global.Oleosig.My.Resources.Resources.edit_undo
        Me._Toolbar1_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button5.Name = "_Toolbar1_Button5"
        Me._Toolbar1_Button5.Size = New System.Drawing.Size(50, 45)
        Me._Toolbar1_Button5.Text = "Cancelar"
        Me._Toolbar1_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 48)
        '
        '_Toolbar1_Button6
        '
        Me._Toolbar1_Button6.AutoSize = False
        Me._Toolbar1_Button6.Image = Global.Oleosig.My.Resources.Resources.document_save
        Me._Toolbar1_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button6.Name = "_Toolbar1_Button6"
        Me._Toolbar1_Button6.Size = New System.Drawing.Size(50, 45)
        Me._Toolbar1_Button6.Text = "Guardar"
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
        'numPartidaAc
        '
        Me.numPartidaAc.AcceptsReturn = True
        Me.numPartidaAc.BackColor = System.Drawing.SystemColors.Window
        Me.numPartidaAc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numPartidaAc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numPartidaAc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.numPartidaAc.Location = New System.Drawing.Point(166, 57)
        Me.numPartidaAc.MaxLength = 0
        Me.numPartidaAc.Name = "numPartidaAc"
        Me.numPartidaAc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numPartidaAc.Size = New System.Drawing.Size(84, 26)
        Me.numPartidaAc.TabIndex = 0
        Me.numPartidaAc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(324, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(144, 18)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Fecha Fin Vaciado :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(324, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(139, 18)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Fecha Ini Vaciado :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(410, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(52, 18)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Kilos :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(265, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(56, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Tolva :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(6, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(126, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Numero Partida :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(142, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Fecha Fin Llenado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(141, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fecha Ini Llenado :"
        '
        'lblidparaceituna
        '
        Me.lblidparaceituna.AutoSize = True
        Me.lblidparaceituna.Location = New System.Drawing.Point(350, 132)
        Me.lblidparaceituna.Name = "lblidparaceituna"
        Me.lblidparaceituna.Size = New System.Drawing.Size(0, 13)
        Me.lblidparaceituna.TabIndex = 18
        '
        'ticketsBDS
        '
        Me.ticketsBDS.DataMember = "lotesaceituna"
        Me.ticketsBDS.DataSource = Me.OleosigDB1
        '
        'tablaPartidas
        '
        Me.tablaPartidas.AllowUserToAddRows = False
        Me.tablaPartidas.AllowUserToDeleteRows = False
        Me.tablaPartidas.AllowUserToResizeRows = False
        Me.tablaPartidas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tablaPartidas.AutoGenerateColumns = False
        Me.tablaPartidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablaPartidas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tablaPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaPartidas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDataGridViewTextBoxColumn, Me.FechaIniLlenadoDataGridViewTextBoxColumn, Me.FechaFinLlenadoDataGridViewTextBoxColumn, Me.FechaIniVaciadoDataGridViewTextBoxColumn, Me.FechaFinVaciadoDataGridViewTextBoxColumn, Me.TolvaDataGridViewTextBoxColumn, Me.KilosDataGridViewTextBoxColumn})
        Me.tablaPartidas.DataSource = Me.partidaBDS
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tablaPartidas.DefaultCellStyle = DataGridViewCellStyle2
        Me.tablaPartidas.Location = New System.Drawing.Point(9, 205)
        Me.tablaPartidas.MultiSelect = False
        Me.tablaPartidas.Name = "tablaPartidas"
        Me.tablaPartidas.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablaPartidas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.tablaPartidas.RowHeadersVisible = False
        Me.tablaPartidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tablaPartidas.Size = New System.Drawing.Size(654, 200)
        Me.tablaPartidas.TabIndex = 6
        '
        'calBDS
        '
        Me.calBDS.DataMember = "recoleccion"
        Me.calBDS.DataSource = Me.OleosigDB1
        '
        'dtfechafin
        '
        Me.dtfechafin.CalendarFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfechafin.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtfechafin.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfechafin.Location = New System.Drawing.Point(166, 153)
        Me.dtfechafin.Name = "dtfechafin"
        Me.dtfechafin.ShowUpDown = True
        Me.dtfechafin.Size = New System.Drawing.Size(147, 22)
        Me.dtfechafin.TabIndex = 3
        '
        'dtfechaini
        '
        Me.dtfechaini.CalendarFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfechaini.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtfechaini.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfechaini.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfechaini.Location = New System.Drawing.Point(166, 100)
        Me.dtfechaini.Name = "dtfechaini"
        Me.dtfechaini.ShowUpDown = True
        Me.dtfechaini.Size = New System.Drawing.Size(147, 22)
        Me.dtfechaini.TabIndex = 2
        '
        'dtfechainivac
        '
        Me.dtfechainivac.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtfechainivac.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfechainivac.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfechainivac.Location = New System.Drawing.Point(473, 100)
        Me.dtfechainivac.Name = "dtfechainivac"
        Me.dtfechainivac.ShowUpDown = True
        Me.dtfechainivac.Size = New System.Drawing.Size(141, 22)
        Me.dtfechainivac.TabIndex = 4
        '
        'dtfechafinvac
        '
        Me.dtfechafinvac.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtfechafinvac.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfechafinvac.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfechafinvac.Location = New System.Drawing.Point(473, 152)
        Me.dtfechafinvac.Name = "dtfechafinvac"
        Me.dtfechafinvac.ShowUpDown = True
        Me.dtfechafinvac.Size = New System.Drawing.Size(141, 22)
        Me.dtfechafinvac.TabIndex = 5
        '
        'varBDS
        '
        Me.varBDS.DataMember = "variedades"
        Me.varBDS.DataSource = Me.OleosigDB1
        '
        'chkImport
        '
        Me.chkImport.AutoSize = True
        Me.chkImport.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkImport.ForeColor = System.Drawing.Color.Navy
        Me.chkImport.Location = New System.Drawing.Point(643, 59)
        Me.chkImport.Name = "chkImport"
        Me.chkImport.Size = New System.Drawing.Size(97, 22)
        Me.chkImport.TabIndex = 19
        Me.chkImport.Text = "Importada"
        Me.chkImport.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(643, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 18)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Variedad :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(643, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 18)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Calidad :"
        '
        'cmbVariedad
        '
        Me.cmbVariedad.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.partidaBDS, "Variedad", True))
        Me.cmbVariedad.DataSource = Me.varBDS
        Me.cmbVariedad.DisplayMember = "varnombre"
        Me.cmbVariedad.FormattingEnabled = True
        Me.cmbVariedad.Location = New System.Drawing.Point(736, 100)
        Me.cmbVariedad.Name = "cmbVariedad"
        Me.cmbVariedad.Size = New System.Drawing.Size(100, 21)
        Me.cmbVariedad.TabIndex = 22
        Me.cmbVariedad.ValueMember = "varcodigo"
        '
        'cmbCalidad
        '
        Me.cmbCalidad.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.partidaBDS, "Calidad", True))
        Me.cmbCalidad.DataSource = Me.calBDS
        Me.cmbCalidad.DisplayMember = "nombre"
        Me.cmbCalidad.FormattingEnabled = True
        Me.cmbCalidad.Location = New System.Drawing.Point(736, 153)
        Me.cmbCalidad.Name = "cmbCalidad"
        Me.cmbCalidad.Size = New System.Drawing.Size(100, 21)
        Me.cmbCalidad.TabIndex = 23
        Me.cmbCalidad.ValueMember = "codigo"
        '
        'tablatickets
        '
        Me.tablatickets.AllowUserToAddRows = False
        Me.tablatickets.AllowUserToDeleteRows = False
        Me.tablatickets.AllowUserToResizeRows = False
        Me.tablatickets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tablatickets.AutoGenerateColumns = False
        Me.tablatickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablatickets.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.tablatickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablatickets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDataGridViewTextBoxColumn1, Me.FechaDataGridViewTextBoxColumn, Me.KilosDataGridViewTextBoxColumn1, Me.TolvaDataGridViewTextBoxColumn1, Me.BasculaDataGridViewTextBoxColumn, Me.CalidadDataGridViewTextBoxColumn, Me.VariedadDataGridViewTextBoxColumn})
        Me.tablatickets.DataSource = Me.ticketsBDS
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tablatickets.DefaultCellStyle = DataGridViewCellStyle5
        Me.tablatickets.Location = New System.Drawing.Point(682, 205)
        Me.tablatickets.MultiSelect = False
        Me.tablatickets.Name = "tablatickets"
        Me.tablatickets.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablatickets.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.tablatickets.RowHeadersVisible = False
        Me.tablatickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tablatickets.Size = New System.Drawing.Size(356, 200)
        Me.tablatickets.TabIndex = 24
        '
        'NumeroDataGridViewTextBoxColumn1
        '
        Me.NumeroDataGridViewTextBoxColumn1.DataPropertyName = "Numero"
        Me.NumeroDataGridViewTextBoxColumn1.HeaderText = "Numero"
        Me.NumeroDataGridViewTextBoxColumn1.Name = "NumeroDataGridViewTextBoxColumn1"
        Me.NumeroDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NumeroDataGridViewTextBoxColumn1.Width = 69
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 62
        '
        'KilosDataGridViewTextBoxColumn1
        '
        Me.KilosDataGridViewTextBoxColumn1.DataPropertyName = "Kilos"
        Me.KilosDataGridViewTextBoxColumn1.HeaderText = "Kilos"
        Me.KilosDataGridViewTextBoxColumn1.Name = "KilosDataGridViewTextBoxColumn1"
        Me.KilosDataGridViewTextBoxColumn1.ReadOnly = True
        Me.KilosDataGridViewTextBoxColumn1.Width = 54
        '
        'TolvaDataGridViewTextBoxColumn1
        '
        Me.TolvaDataGridViewTextBoxColumn1.DataPropertyName = "Tolva"
        Me.TolvaDataGridViewTextBoxColumn1.HeaderText = "Tolva"
        Me.TolvaDataGridViewTextBoxColumn1.Name = "TolvaDataGridViewTextBoxColumn1"
        Me.TolvaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.TolvaDataGridViewTextBoxColumn1.Width = 59
        '
        'BasculaDataGridViewTextBoxColumn
        '
        Me.BasculaDataGridViewTextBoxColumn.DataPropertyName = "Bascula"
        Me.BasculaDataGridViewTextBoxColumn.HeaderText = "Bascula"
        Me.BasculaDataGridViewTextBoxColumn.Name = "BasculaDataGridViewTextBoxColumn"
        Me.BasculaDataGridViewTextBoxColumn.ReadOnly = True
        Me.BasculaDataGridViewTextBoxColumn.Width = 70
        '
        'CalidadDataGridViewTextBoxColumn
        '
        Me.CalidadDataGridViewTextBoxColumn.DataPropertyName = "Calidad"
        Me.CalidadDataGridViewTextBoxColumn.HeaderText = "Calidad"
        Me.CalidadDataGridViewTextBoxColumn.Name = "CalidadDataGridViewTextBoxColumn"
        Me.CalidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.CalidadDataGridViewTextBoxColumn.Width = 67
        '
        'VariedadDataGridViewTextBoxColumn
        '
        Me.VariedadDataGridViewTextBoxColumn.DataPropertyName = "Variedad"
        Me.VariedadDataGridViewTextBoxColumn.HeaderText = "Variedad"
        Me.VariedadDataGridViewTextBoxColumn.Name = "VariedadDataGridViewTextBoxColumn"
        Me.VariedadDataGridViewTextBoxColumn.ReadOnly = True
        Me.VariedadDataGridViewTextBoxColumn.Width = 74
        '
        'BKW
        '
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        Me.NumeroDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroDataGridViewTextBoxColumn.Width = 69
        '
        'FechaIniLlenadoDataGridViewTextBoxColumn
        '
        Me.FechaIniLlenadoDataGridViewTextBoxColumn.DataPropertyName = "FechaIniLlenado"
        Me.FechaIniLlenadoDataGridViewTextBoxColumn.HeaderText = "FechaIniLlenado"
        Me.FechaIniLlenadoDataGridViewTextBoxColumn.Name = "FechaIniLlenadoDataGridViewTextBoxColumn"
        Me.FechaIniLlenadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaIniLlenadoDataGridViewTextBoxColumn.Width = 111
        '
        'FechaFinLlenadoDataGridViewTextBoxColumn
        '
        Me.FechaFinLlenadoDataGridViewTextBoxColumn.DataPropertyName = "FechaFinLlenado"
        Me.FechaFinLlenadoDataGridViewTextBoxColumn.HeaderText = "FechaFinLlenado"
        Me.FechaFinLlenadoDataGridViewTextBoxColumn.Name = "FechaFinLlenadoDataGridViewTextBoxColumn"
        Me.FechaFinLlenadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaFinLlenadoDataGridViewTextBoxColumn.Width = 114
        '
        'FechaIniVaciadoDataGridViewTextBoxColumn
        '
        Me.FechaIniVaciadoDataGridViewTextBoxColumn.DataPropertyName = "FechaIniVaciado"
        Me.FechaIniVaciadoDataGridViewTextBoxColumn.HeaderText = "FechaIniVaciado"
        Me.FechaIniVaciadoDataGridViewTextBoxColumn.Name = "FechaIniVaciadoDataGridViewTextBoxColumn"
        Me.FechaIniVaciadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaIniVaciadoDataGridViewTextBoxColumn.Width = 112
        '
        'FechaFinVaciadoDataGridViewTextBoxColumn
        '
        Me.FechaFinVaciadoDataGridViewTextBoxColumn.DataPropertyName = "FechaFinVaciado"
        Me.FechaFinVaciadoDataGridViewTextBoxColumn.HeaderText = "FechaFinVaciado"
        Me.FechaFinVaciadoDataGridViewTextBoxColumn.Name = "FechaFinVaciadoDataGridViewTextBoxColumn"
        Me.FechaFinVaciadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaFinVaciadoDataGridViewTextBoxColumn.Width = 115
        '
        'TolvaDataGridViewTextBoxColumn
        '
        Me.TolvaDataGridViewTextBoxColumn.DataPropertyName = "Tolva"
        Me.TolvaDataGridViewTextBoxColumn.DataSource = Me.tolvasBDS
        Me.TolvaDataGridViewTextBoxColumn.DisplayMember = "Nombre"
        Me.TolvaDataGridViewTextBoxColumn.HeaderText = "Tolva"
        Me.TolvaDataGridViewTextBoxColumn.Name = "TolvaDataGridViewTextBoxColumn"
        Me.TolvaDataGridViewTextBoxColumn.ReadOnly = True
        Me.TolvaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TolvaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.TolvaDataGridViewTextBoxColumn.ValueMember = "Numero"
        Me.TolvaDataGridViewTextBoxColumn.Width = 59
        '
        'KilosDataGridViewTextBoxColumn
        '
        Me.KilosDataGridViewTextBoxColumn.DataPropertyName = "Kilos"
        Me.KilosDataGridViewTextBoxColumn.HeaderText = "Kilos"
        Me.KilosDataGridViewTextBoxColumn.Name = "KilosDataGridViewTextBoxColumn"
        Me.KilosDataGridViewTextBoxColumn.ReadOnly = True
        Me.KilosDataGridViewTextBoxColumn.Width = 54
        '
        'frmAdPaAceituna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1050, 417)
        Me.Controls.Add(Me.tablatickets)
        Me.Controls.Add(Me.cmbCalidad)
        Me.Controls.Add(Me.cmbVariedad)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.chkImport)
        Me.Controls.Add(Me.dtfechafinvac)
        Me.Controls.Add(Me.dtfechainivac)
        Me.Controls.Add(Me.dtfechaini)
        Me.Controls.Add(Me.dtfechafin)
        Me.Controls.Add(Me.tablaPartidas)
        Me.Controls.Add(Me.lblidparaceituna)
        Me.Controls.Add(Me.chkAbierta)
        Me.Controls.Add(Me.cmbTolvas)
        Me.Controls.Add(Me.kilosTxt)
        Me.Controls.Add(Me.Toolbar1)
        Me.Controls.Add(Me.numPartidaAc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(3, 29)
        Me.Name = "frmAdPaAceituna"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Añadir Partida de Aceituna"
        CType(Me.partidaBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tolvasBDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Toolbar1.ResumeLayout(False)
        Me.Toolbar1.PerformLayout()
        CType(Me.ticketsBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablaPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.calBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.varBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablatickets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblidparaceituna As System.Windows.Forms.Label
    Friend WithEvents partidaBDS As System.Windows.Forms.BindingSource
    Friend WithEvents ticketsBDS As System.Windows.Forms.BindingSource
    Friend WithEvents tablaPartidas As System.Windows.Forms.DataGridView
    Friend WithEvents tolvasBDS As System.Windows.Forms.BindingSource
    Friend WithEvents dtfechafin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtfechaini As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtfechainivac As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtfechafinvac As System.Windows.Forms.DateTimePicker
    Friend WithEvents OleosigDB1 As Oleosig.oleosigDB
    Friend WithEvents varBDS As System.Windows.Forms.BindingSource
    Friend WithEvents calBDS As System.Windows.Forms.BindingSource
    Friend WithEvents chkImport As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbVariedad As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCalidad As System.Windows.Forms.ComboBox
    Friend WithEvents tablatickets As System.Windows.Forms.DataGridView
    Friend WithEvents BKW As System.ComponentModel.BackgroundWorker
    Friend WithEvents NumeroDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TolvaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BasculaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VariedadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaIniLlenadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFinLlenadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaIniVaciadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFinVaciadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TolvaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents KilosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region
End Class