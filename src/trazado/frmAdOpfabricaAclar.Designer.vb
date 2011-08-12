<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAdOpfabricaAclar
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
	Public WithEvents _Toolbar1_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents _Toolbar1_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _Toolbar1_Button3 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents _Toolbar1_Button6 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button8 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip

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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Toolbar1 = New System.Windows.Forms.ToolStrip()
        Me._Toolbar1_Button1 = New System.Windows.Forms.ToolStripButton()
        Me._Toolbar1_Button2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me._Toolbar1_Button3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me._Toolbar1_Button5 = New System.Windows.Forms.ToolStripButton()
        Me._Toolbar1_Button6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me._Toolbar1_Button8 = New System.Windows.Forms.ToolStripButton()
        Me.tablapartidas = New System.Windows.Forms.DataGridView()
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaIniLlenadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFinLlenadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TolvaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KilosDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.partidasBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.OleosigDB1 = New Oleosig.oleosigDB()
        Me.BkWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tablaDetalles = New System.Windows.Forms.DataGridView()
        Me.detallesBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtfechafin = New System.Windows.Forms.DateTimePicker()
        Me.dtfechaini = New System.Windows.Forms.DateTimePicker()
        Me.kilostxt = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkAbierta = New System.Windows.Forms.CheckBox()
        Me.cmbLineas = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbloperacion = New System.Windows.Forms.Label()
        Me.moltBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmdVerpartidas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbTolvas = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tablamolturaciones = New System.Windows.Forms.DataGridView()
        Me.OperacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechainiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechafinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LineafabricaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.PartidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KilosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Toolbar1.SuspendLayout()
        CType(Me.tablapartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.partidasBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.tablaDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.detallesBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.moltBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.tablamolturaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Toolbar1
        '
        Me.Toolbar1.Dock = System.Windows.Forms.DockStyle.None
        Me.Toolbar1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Toolbar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._Toolbar1_Button1, Me._Toolbar1_Button2, Me.ToolStripSeparator1, Me._Toolbar1_Button3, Me.ToolStripSeparator2, Me._Toolbar1_Button5, Me._Toolbar1_Button6, Me.ToolStripSeparator3, Me._Toolbar1_Button8})
        Me.Toolbar1.Location = New System.Drawing.Point(3, 0)
        Me.Toolbar1.Name = "Toolbar1"
        Me.Toolbar1.Size = New System.Drawing.Size(321, 48)
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
        Me._Toolbar1_Button1.ToolTipText = "Nuevo"
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
        Me._Toolbar1_Button2.ToolTipText = "Deshacer"
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
        '_Toolbar1_Button6
        '
        Me._Toolbar1_Button6.AutoSize = False
        Me._Toolbar1_Button6.Image = Global.Oleosig.My.Resources.Resources.document_save
        Me._Toolbar1_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button6.Name = "_Toolbar1_Button6"
        Me._Toolbar1_Button6.Size = New System.Drawing.Size(50, 45)
        Me._Toolbar1_Button6.Text = "Guardar"
        Me._Toolbar1_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Toolbar1_Button6.ToolTipText = "Guardar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 48)
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
        'tablapartidas
        '
        Me.tablapartidas.AllowUserToAddRows = False
        Me.tablapartidas.AllowUserToDeleteRows = False
        Me.tablapartidas.AllowUserToResizeColumns = False
        Me.tablapartidas.AllowUserToResizeRows = False
        Me.tablapartidas.AutoGenerateColumns = False
        Me.tablapartidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablapartidas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tablapartidas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDataGridViewTextBoxColumn, Me.FechaIniLlenadoDataGridViewTextBoxColumn, Me.FechaFinLlenadoDataGridViewTextBoxColumn, Me.TolvaDataGridViewTextBoxColumn, Me.KilosDataGridViewTextBoxColumn1})
        Me.tablapartidas.DataSource = Me.partidasBDS
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tablapartidas.DefaultCellStyle = DataGridViewCellStyle2
        Me.tablapartidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablapartidas.Location = New System.Drawing.Point(10, 50)
        Me.tablapartidas.Margin = New System.Windows.Forms.Padding(10)
        Me.tablapartidas.MultiSelect = False
        Me.tablapartidas.Name = "tablapartidas"
        Me.tablapartidas.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablapartidas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.tablapartidas.RowHeadersVisible = False
        Me.tablapartidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tablapartidas.Size = New System.Drawing.Size(492, 210)
        Me.tablapartidas.TabIndex = 17
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
        Me.FechaIniLlenadoDataGridViewTextBoxColumn.HeaderText = "Fecha Ini"
        Me.FechaIniLlenadoDataGridViewTextBoxColumn.Name = "FechaIniLlenadoDataGridViewTextBoxColumn"
        Me.FechaIniLlenadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaIniLlenadoDataGridViewTextBoxColumn.Width = 76
        '
        'FechaFinLlenadoDataGridViewTextBoxColumn
        '
        Me.FechaFinLlenadoDataGridViewTextBoxColumn.DataPropertyName = "FechaFinLlenado"
        Me.FechaFinLlenadoDataGridViewTextBoxColumn.HeaderText = "Fecha Fin"
        Me.FechaFinLlenadoDataGridViewTextBoxColumn.Name = "FechaFinLlenadoDataGridViewTextBoxColumn"
        Me.FechaFinLlenadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaFinLlenadoDataGridViewTextBoxColumn.Width = 79
        '
        'TolvaDataGridViewTextBoxColumn
        '
        Me.TolvaDataGridViewTextBoxColumn.DataPropertyName = "Tolva"
        Me.TolvaDataGridViewTextBoxColumn.HeaderText = "Tolva"
        Me.TolvaDataGridViewTextBoxColumn.Name = "TolvaDataGridViewTextBoxColumn"
        Me.TolvaDataGridViewTextBoxColumn.ReadOnly = True
        Me.TolvaDataGridViewTextBoxColumn.Width = 59
        '
        'KilosDataGridViewTextBoxColumn1
        '
        Me.KilosDataGridViewTextBoxColumn1.DataPropertyName = "Kilos"
        Me.KilosDataGridViewTextBoxColumn1.HeaderText = "Kilos"
        Me.KilosDataGridViewTextBoxColumn1.Name = "KilosDataGridViewTextBoxColumn1"
        Me.KilosDataGridViewTextBoxColumn1.ReadOnly = True
        Me.KilosDataGridViewTextBoxColumn1.Width = 54
        '
        'partidasBDS
        '
        Me.partidasBDS.AllowNew = False
        Me.partidasBDS.DataMember = "partidasaceituna"
        Me.partidasBDS.DataSource = Me.OleosigDB1
        '
        'OleosigDB1
        '
        Me.OleosigDB1.DataSetName = "oleosigDB"
        Me.OleosigDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BkWorker1
        '
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.09782!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.90218!))
        Me.TableLayoutPanel1.Controls.Add(Me.tablaDetalles, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tablamolturaciones, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.55955!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.44046!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(961, 494)
        Me.TableLayoutPanel1.TabIndex = 38
        '
        'tablaDetalles
        '
        Me.tablaDetalles.AllowUserToAddRows = False
        Me.tablaDetalles.AllowUserToDeleteRows = False
        Me.tablaDetalles.AutoGenerateColumns = False
        Me.tablaDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablaDetalles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.tablaDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaDetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PartidaDataGridViewTextBoxColumn, Me.KilosDataGridViewTextBoxColumn})
        Me.tablaDetalles.DataSource = Me.detallesBDS
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tablaDetalles.DefaultCellStyle = DataGridViewCellStyle5
        Me.tablaDetalles.Location = New System.Drawing.Point(446, 3)
        Me.tablaDetalles.Name = "tablaDetalles"
        Me.tablaDetalles.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablaDetalles.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.tablaDetalles.RowHeadersVisible = False
        Me.tablaDetalles.Size = New System.Drawing.Size(300, 174)
        Me.tablaDetalles.TabIndex = 42
        '
        'detallesBDS
        '
        Me.detallesBDS.DataMember = "detalles_opfabrica"
        Me.detallesBDS.DataSource = Me.OleosigDB1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dtfechafin)
        Me.Panel1.Controls.Add(Me.dtfechaini)
        Me.Panel1.Controls.Add(Me.kilostxt)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.chkAbierta)
        Me.Panel1.Controls.Add(Me.cmbLineas)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lbloperacion)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(437, 174)
        Me.Panel1.TabIndex = 39
        '
        'dtfechafin
        '
        Me.dtfechafin.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtfechafin.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfechafin.Location = New System.Drawing.Point(118, 126)
        Me.dtfechafin.Name = "dtfechafin"
        Me.dtfechafin.ShowUpDown = True
        Me.dtfechafin.Size = New System.Drawing.Size(121, 22)
        Me.dtfechafin.TabIndex = 50
        '
        'dtfechaini
        '
        Me.dtfechaini.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtfechaini.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfechaini.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfechaini.Location = New System.Drawing.Point(118, 90)
        Me.dtfechaini.Name = "dtfechaini"
        Me.dtfechaini.ShowUpDown = True
        Me.dtfechaini.Size = New System.Drawing.Size(121, 22)
        Me.dtfechaini.TabIndex = 49
        '
        'kilostxt
        '
        Me.kilostxt.BackColor = System.Drawing.SystemColors.Window
        Me.kilostxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.kilostxt.Cursor = System.Windows.Forms.Cursors.Default
        Me.kilostxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kilostxt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.kilostxt.Location = New System.Drawing.Point(118, 49)
        Me.kilostxt.Name = "kilostxt"
        Me.kilostxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.kilostxt.Size = New System.Drawing.Size(75, 19)
        Me.kilostxt.TabIndex = 48
        Me.kilostxt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(12, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(91, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Fecha Final :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(94, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Fecha Inicio :"
        '
        'chkAbierta
        '
        Me.chkAbierta.AutoSize = True
        Me.chkAbierta.BackColor = System.Drawing.SystemColors.Control
        Me.chkAbierta.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAbierta.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.OleosigDB1, "opfabrica.abierta", True))
        Me.chkAbierta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAbierta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.chkAbierta.Location = New System.Drawing.Point(352, 10)
        Me.chkAbierta.Name = "chkAbierta"
        Me.chkAbierta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAbierta.Size = New System.Drawing.Size(73, 20)
        Me.chkAbierta.TabIndex = 40
        Me.chkAbierta.Text = "Abierta"
        Me.chkAbierta.UseVisualStyleBackColor = False
        '
        'cmbLineas
        '
        Me.cmbLineas.BackColor = System.Drawing.SystemColors.Window
        Me.cmbLineas.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbLineas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbLineas.Location = New System.Drawing.Point(272, 10)
        Me.cmbLineas.Name = "cmbLineas"
        Me.cmbLineas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbLineas.Size = New System.Drawing.Size(65, 21)
        Me.cmbLineas.TabIndex = 39
        Me.cmbLineas.Text = "Lineas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(103, 16)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Kilos Aceituna:"
        '
        'lbloperacion
        '
        Me.lbloperacion.BackColor = System.Drawing.SystemColors.Window
        Me.lbloperacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbloperacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbloperacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.moltBDS, "operacion", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.lbloperacion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloperacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbloperacion.Location = New System.Drawing.Point(118, 11)
        Me.lbloperacion.Name = "lbloperacion"
        Me.lbloperacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbloperacion.Size = New System.Drawing.Size(75, 19)
        Me.lbloperacion.TabIndex = 43
        Me.lbloperacion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'moltBDS
        '
        Me.moltBDS.DataMember = "opfabrica"
        Me.moltBDS.DataSource = Me.OleosigDB1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(12, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(91, 16)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Molturación :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(214, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Linea :"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.tablapartidas, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(446, 221)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(512, 270)
        Me.TableLayoutPanel2.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmdVerpartidas)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.cmbTolvas)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(506, 34)
        Me.Panel2.TabIndex = 20
        '
        'cmdVerpartidas
        '
        Me.cmdVerpartidas.BackColor = System.Drawing.SystemColors.Control
        Me.cmdVerpartidas.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdVerpartidas.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVerpartidas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdVerpartidas.Location = New System.Drawing.Point(195, 6)
        Me.cmdVerpartidas.Name = "cmdVerpartidas"
        Me.cmdVerpartidas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdVerpartidas.Size = New System.Drawing.Size(79, 23)
        Me.cmdVerpartidas.TabIndex = 27
        Me.cmdVerpartidas.Text = "Ver Partidas"
        Me.cmdVerpartidas.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Tolvas"
        '
        'cmbTolvas
        '
        Me.cmbTolvas.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTolvas.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbTolvas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTolvas.Location = New System.Drawing.Point(98, 7)
        Me.cmbTolvas.Name = "cmbTolvas"
        Me.cmbTolvas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTolvas.Size = New System.Drawing.Size(81, 21)
        Me.cmbTolvas.TabIndex = 26
        Me.cmbTolvas.Text = "Tolvas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(5, 185)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 19)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Molturaciones"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label7.Location = New System.Drawing.Point(448, 185)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 19)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Partidas de Aceituna"
        '
        'tablamolturaciones
        '
        Me.tablamolturaciones.AllowUserToAddRows = False
        Me.tablamolturaciones.AllowUserToDeleteRows = False
        Me.tablamolturaciones.AutoGenerateColumns = False
        Me.tablamolturaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablamolturaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.tablamolturaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablamolturaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OperacionDataGridViewTextBoxColumn, Me.FechainiDataGridViewTextBoxColumn, Me.FechafinDataGridViewTextBoxColumn, Me.LineafabricaDataGridViewTextBoxColumn})
        Me.tablamolturaciones.DataSource = Me.moltBDS
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tablamolturaciones.DefaultCellStyle = DataGridViewCellStyle8
        Me.tablamolturaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablamolturaciones.Location = New System.Drawing.Point(3, 221)
        Me.tablamolturaciones.Name = "tablamolturaciones"
        Me.tablamolturaciones.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablamolturaciones.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.tablamolturaciones.RowHeadersVisible = False
        Me.tablamolturaciones.Size = New System.Drawing.Size(437, 270)
        Me.tablamolturaciones.TabIndex = 42
        '
        'OperacionDataGridViewTextBoxColumn
        '
        Me.OperacionDataGridViewTextBoxColumn.DataPropertyName = "operacion"
        Me.OperacionDataGridViewTextBoxColumn.HeaderText = "Operacion"
        Me.OperacionDataGridViewTextBoxColumn.Name = "OperacionDataGridViewTextBoxColumn"
        Me.OperacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.OperacionDataGridViewTextBoxColumn.Width = 81
        '
        'FechainiDataGridViewTextBoxColumn
        '
        Me.FechainiDataGridViewTextBoxColumn.DataPropertyName = "fechaini"
        Me.FechainiDataGridViewTextBoxColumn.HeaderText = "Fecha Inicial"
        Me.FechainiDataGridViewTextBoxColumn.Name = "FechainiDataGridViewTextBoxColumn"
        Me.FechainiDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechainiDataGridViewTextBoxColumn.Width = 92
        '
        'FechafinDataGridViewTextBoxColumn
        '
        Me.FechafinDataGridViewTextBoxColumn.DataPropertyName = "fechafin"
        Me.FechafinDataGridViewTextBoxColumn.HeaderText = "Fecha Final"
        Me.FechafinDataGridViewTextBoxColumn.Name = "FechafinDataGridViewTextBoxColumn"
        Me.FechafinDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechafinDataGridViewTextBoxColumn.Width = 87
        '
        'LineafabricaDataGridViewTextBoxColumn
        '
        Me.LineafabricaDataGridViewTextBoxColumn.DataPropertyName = "lineafabrica"
        Me.LineafabricaDataGridViewTextBoxColumn.HeaderText = "Linea"
        Me.LineafabricaDataGridViewTextBoxColumn.Name = "LineafabricaDataGridViewTextBoxColumn"
        Me.LineafabricaDataGridViewTextBoxColumn.ReadOnly = True
        Me.LineafabricaDataGridViewTextBoxColumn.Width = 58
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(961, 494)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(961, 542)
        Me.ToolStripContainer1.TabIndex = 40
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.Toolbar1)
        '
        'PartidaDataGridViewTextBoxColumn
        '
        Me.PartidaDataGridViewTextBoxColumn.DataPropertyName = "partida"
        Me.PartidaDataGridViewTextBoxColumn.HeaderText = "partida"
        Me.PartidaDataGridViewTextBoxColumn.Name = "PartidaDataGridViewTextBoxColumn"
        Me.PartidaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PartidaDataGridViewTextBoxColumn.Width = 64
        '
        'KilosDataGridViewTextBoxColumn
        '
        Me.KilosDataGridViewTextBoxColumn.DataPropertyName = "kilos"
        Me.KilosDataGridViewTextBoxColumn.HeaderText = "kilos"
        Me.KilosDataGridViewTextBoxColumn.Name = "KilosDataGridViewTextBoxColumn"
        Me.KilosDataGridViewTextBoxColumn.ReadOnly = True
        Me.KilosDataGridViewTextBoxColumn.Width = 53
        '
        'frmAdOpfabricaAclar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(961, 542)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdOpfabricaAclar"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Añadir/Editar Molturaciones"
        Me.Toolbar1.ResumeLayout(False)
        Me.Toolbar1.PerformLayout()
        CType(Me.tablapartidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.partidasBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.tablaDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.detallesBDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.moltBDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.tablamolturaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents tablapartidas As System.Windows.Forms.DataGridView
    Friend WithEvents BkWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents cmdVerpartidas As System.Windows.Forms.Button
    Public WithEvents cmbTolvas As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Public WithEvents chkAbierta As System.Windows.Forms.CheckBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents cmbLineas As System.Windows.Forms.ComboBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents lbloperacion As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents kilostxt As System.Windows.Forms.Label
    Friend WithEvents tablamolturaciones As System.Windows.Forms.DataGridView
    Friend WithEvents partidasBDS As System.Windows.Forms.BindingSource
    Friend WithEvents moltBDS As System.Windows.Forms.BindingSource
    Friend WithEvents dtfechafin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtfechaini As System.Windows.Forms.DateTimePicker
    Friend WithEvents OleosigDB1 As Oleosig.oleosigDB
    Friend WithEvents tablaDetalles As System.Windows.Forms.DataGridView
    Friend WithEvents detallesBDS As System.Windows.Forms.BindingSource
    Friend WithEvents OperacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechainiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechafinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LineafabricaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaIniLlenadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFinLlenadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TolvaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PartidaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region
End Class