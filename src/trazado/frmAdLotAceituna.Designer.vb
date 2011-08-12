<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAdLotAceituna
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
    Public WithEvents _Toolbar1_Button7 As System.Windows.Forms.ToolStripButton
	Public WithEvents _Toolbar1_Button8 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdLotAceituna))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Toolbar1 = New System.Windows.Forms.ToolStrip()
        Me._Toolbar1_Button1 = New System.Windows.Forms.ToolStripButton()
        Me._Toolbar1_Button2 = New System.Windows.Forms.ToolStripButton()
        Me._Toolbar1_Button3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me._Toolbar1_Button5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me._Toolbar1_Button7 = New System.Windows.Forms.ToolStripButton()
        Me._Toolbar1_Button8 = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Frame_2 = New System.Windows.Forms.GroupBox()
        Me.rendTxt = New System.Windows.Forms.TextBox()
        Me.LotesBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.OleosigDB1 = New Oleosig.oleosigDB()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.partxt = New System.Windows.Forms.TextBox()
        Me.tertxt = New System.Windows.Forms.TextBox()
        Me.polTxt = New System.Windows.Forms.TextBox()
        Me.numsociotxt = New System.Windows.Forms.TextBox()
        Me.tolvastxt = New System.Windows.Forms.TextBox()
        Me._Label11_0 = New System.Windows.Forms.Label()
        Me.cmbCalidad = New System.Windows.Forms.ComboBox()
        Me.kilostxt = New System.Windows.Forms.TextBox()
        Me.matriculatxt = New System.Windows.Forms.TextBox()
        Me.numlotetxt = New System.Windows.Forms.TextBox()
        Me.cmbVariedades = New System.Windows.Forms.ComboBox()
        Me.bascTxt = New System.Windows.Forms.TextBox()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me._Label11_3 = New System.Windows.Forms.Label()
        Me._Label11_11 = New System.Windows.Forms.Label()
        Me._Label11_10 = New System.Windows.Forms.Label()
        Me._Label11_8 = New System.Windows.Forms.Label()
        Me._Label11_7 = New System.Windows.Forms.Label()
        Me._Label11_5 = New System.Windows.Forms.Label()
        Me._Label11_4 = New System.Windows.Forms.Label()
        Me._Label11_2 = New System.Windows.Forms.Label()
        Me._Label11_1 = New System.Windows.Forms.Label()
        Me._Label11_6 = New System.Windows.Forms.Label()
        Me._Label11_9 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tabladatos = New System.Windows.Forms.DataGridView()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.calBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.VarBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CosecheroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KilosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RendimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BasculaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TolvaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TerminoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoligonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VariedadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParcelaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Toolbar1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Frame_2.SuspendLayout()
        CType(Me.LotesBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.tabladatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.calBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VarBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Toolbar1
        '
        Me.Toolbar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._Toolbar1_Button1, Me._Toolbar1_Button2, Me._Toolbar1_Button3, Me.ToolStripSeparator1, Me._Toolbar1_Button5, Me.ToolStripSeparator2, Me._Toolbar1_Button7, Me._Toolbar1_Button8})
        Me.Toolbar1.Location = New System.Drawing.Point(0, 4)
        Me.Toolbar1.Name = "Toolbar1"
        Me.Toolbar1.Size = New System.Drawing.Size(592, 48)
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
        '_Toolbar1_Button8
        '
        Me._Toolbar1_Button8.AutoSize = False
        Me._Toolbar1_Button8.Image = Global.Oleosig.My.Resources.Resources.dialog_close
        Me._Toolbar1_Button8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button8.Name = "_Toolbar1_Button8"
        Me._Toolbar1_Button8.Size = New System.Drawing.Size(50, 45)
        Me._Toolbar1_Button8.Text = "Salir"
        Me._Toolbar1_Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 52)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Frame_2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(592, 391)
        Me.SplitContainer1.SplitterDistance = 195
        Me.SplitContainer1.TabIndex = 4
        '
        'Frame_2
        '
        Me.Frame_2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame_2.Controls.Add(Me.rendTxt)
        Me.Frame_2.Controls.Add(Me.Label1)
        Me.Frame_2.Controls.Add(Me.partxt)
        Me.Frame_2.Controls.Add(Me.tertxt)
        Me.Frame_2.Controls.Add(Me.polTxt)
        Me.Frame_2.Controls.Add(Me.numsociotxt)
        Me.Frame_2.Controls.Add(Me.tolvastxt)
        Me.Frame_2.Controls.Add(Me._Label11_0)
        Me.Frame_2.Controls.Add(Me.cmbCalidad)
        Me.Frame_2.Controls.Add(Me.kilostxt)
        Me.Frame_2.Controls.Add(Me.matriculatxt)
        Me.Frame_2.Controls.Add(Me.numlotetxt)
        Me.Frame_2.Controls.Add(Me.cmbVariedades)
        Me.Frame_2.Controls.Add(Me.bascTxt)
        Me.Frame_2.Controls.Add(Me.dtFecha)
        Me.Frame_2.Controls.Add(Me._Label11_3)
        Me.Frame_2.Controls.Add(Me._Label11_11)
        Me.Frame_2.Controls.Add(Me._Label11_10)
        Me.Frame_2.Controls.Add(Me._Label11_8)
        Me.Frame_2.Controls.Add(Me._Label11_7)
        Me.Frame_2.Controls.Add(Me._Label11_5)
        Me.Frame_2.Controls.Add(Me._Label11_4)
        Me.Frame_2.Controls.Add(Me._Label11_2)
        Me.Frame_2.Controls.Add(Me._Label11_1)
        Me.Frame_2.Controls.Add(Me._Label11_6)
        Me.Frame_2.Controls.Add(Me._Label11_9)
        Me.Frame_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame_2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Frame_2.Location = New System.Drawing.Point(0, 0)
        Me.Frame_2.Margin = New System.Windows.Forms.Padding(5)
        Me.Frame_2.Name = "Frame_2"
        Me.Frame_2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame_2.Size = New System.Drawing.Size(592, 195)
        Me.Frame_2.TabIndex = 1
        Me.Frame_2.TabStop = False
        Me.Frame_2.Text = "Lotes Aceitunas"
        '
        'rendTxt
        '
        Me.rendTxt.AcceptsReturn = True
        Me.rendTxt.BackColor = System.Drawing.SystemColors.Window
        Me.rendTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.rendTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LotesBDS, "Rendimiento", True))
        Me.rendTxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rendTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.rendTxt.Location = New System.Drawing.Point(515, 50)
        Me.rendTxt.MaxLength = 0
        Me.rendTxt.Name = "rendTxt"
        Me.rendTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rendTxt.Size = New System.Drawing.Size(46, 22)
        Me.rendTxt.TabIndex = 58
        '
        'LotesBDS
        '
        Me.LotesBDS.DataMember = "lotesaceituna"
        Me.LotesBDS.DataSource = Me.OleosigDB1
        '
        'OleosigDB1
        '
        Me.OleosigDB1.DataSetName = "oleosigDB"
        Me.OleosigDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(421, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Rendimiento :"
        '
        'partxt
        '
        Me.partxt.AcceptsReturn = True
        Me.partxt.BackColor = System.Drawing.SystemColors.Window
        Me.partxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.partxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LotesBDS, "Parcela", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"))
        Me.partxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.partxt.Location = New System.Drawing.Point(100, 150)
        Me.partxt.MaxLength = 0
        Me.partxt.Name = "partxt"
        Me.partxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.partxt.Size = New System.Drawing.Size(89, 22)
        Me.partxt.TabIndex = 5
        Me.partxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tertxt
        '
        Me.tertxt.AcceptsReturn = True
        Me.tertxt.BackColor = System.Drawing.SystemColors.Window
        Me.tertxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tertxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LotesBDS, "Termino", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0"))
        Me.tertxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tertxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tertxt.Location = New System.Drawing.Point(100, 100)
        Me.tertxt.MaxLength = 0
        Me.tertxt.Name = "tertxt"
        Me.tertxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tertxt.Size = New System.Drawing.Size(89, 22)
        Me.tertxt.TabIndex = 3
        Me.tertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'polTxt
        '
        Me.polTxt.AcceptsReturn = True
        Me.polTxt.BackColor = System.Drawing.SystemColors.Window
        Me.polTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.polTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LotesBDS, "Poligono", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"))
        Me.polTxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.polTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.polTxt.Location = New System.Drawing.Point(100, 125)
        Me.polTxt.MaxLength = 0
        Me.polTxt.Name = "polTxt"
        Me.polTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.polTxt.Size = New System.Drawing.Size(89, 22)
        Me.polTxt.TabIndex = 4
        Me.polTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numsociotxt
        '
        Me.numsociotxt.AcceptsReturn = True
        Me.numsociotxt.BackColor = System.Drawing.SystemColors.Window
        Me.numsociotxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numsociotxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LotesBDS, "Cosechero", True))
        Me.numsociotxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numsociotxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.numsociotxt.Location = New System.Drawing.Point(100, 50)
        Me.numsociotxt.MaxLength = 0
        Me.numsociotxt.Name = "numsociotxt"
        Me.numsociotxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numsociotxt.Size = New System.Drawing.Size(89, 22)
        Me.numsociotxt.TabIndex = 1
        Me.numsociotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tolvastxt
        '
        Me.tolvastxt.AcceptsReturn = True
        Me.tolvastxt.BackColor = System.Drawing.SystemColors.Window
        Me.tolvastxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tolvastxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LotesBDS, "Tolva", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"))
        Me.tolvastxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tolvastxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tolvastxt.Location = New System.Drawing.Point(314, 75)
        Me.tolvastxt.MaxLength = 0
        Me.tolvastxt.Name = "tolvastxt"
        Me.tolvastxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tolvastxt.Size = New System.Drawing.Size(89, 22)
        Me.tolvastxt.TabIndex = 8
        '
        '_Label11_0
        '
        Me._Label11_0.BackColor = System.Drawing.Color.Transparent
        Me._Label11_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label11_0.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label11_0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._Label11_0.Location = New System.Drawing.Point(24, 27)
        Me._Label11_0.Name = "_Label11_0"
        Me._Label11_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label11_0.Size = New System.Drawing.Size(57, 19)
        Me._Label11_0.TabIndex = 56
        Me._Label11_0.Text = "Lote :"
        '
        'cmbCalidad
        '
        Me.cmbCalidad.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCalidad.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCalidad.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LotesBDS, "Calidad", True))
        Me.cmbCalidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCalidad.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCalidad.Location = New System.Drawing.Point(314, 99)
        Me.cmbCalidad.Name = "cmbCalidad"
        Me.cmbCalidad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCalidad.Size = New System.Drawing.Size(89, 24)
        Me.cmbCalidad.TabIndex = 9
        '
        'kilostxt
        '
        Me.kilostxt.AcceptsReturn = True
        Me.kilostxt.BackColor = System.Drawing.SystemColors.Window
        Me.kilostxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kilostxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LotesBDS, "Kilos", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"))
        Me.kilostxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kilostxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.kilostxt.Location = New System.Drawing.Point(314, 150)
        Me.kilostxt.MaxLength = 0
        Me.kilostxt.Name = "kilostxt"
        Me.kilostxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.kilostxt.Size = New System.Drawing.Size(89, 22)
        Me.kilostxt.TabIndex = 11
        '
        'matriculatxt
        '
        Me.matriculatxt.AcceptsReturn = True
        Me.matriculatxt.BackColor = System.Drawing.SystemColors.Window
        Me.matriculatxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.matriculatxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LotesBDS, "Matricula", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.matriculatxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matriculatxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.matriculatxt.Location = New System.Drawing.Point(100, 75)
        Me.matriculatxt.MaxLength = 0
        Me.matriculatxt.Name = "matriculatxt"
        Me.matriculatxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.matriculatxt.Size = New System.Drawing.Size(89, 22)
        Me.matriculatxt.TabIndex = 2
        Me.matriculatxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numlotetxt
        '
        Me.numlotetxt.AcceptsReturn = True
        Me.numlotetxt.BackColor = System.Drawing.SystemColors.Window
        Me.numlotetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numlotetxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LotesBDS, "Numero", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.numlotetxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numlotetxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.numlotetxt.Location = New System.Drawing.Point(100, 25)
        Me.numlotetxt.MaxLength = 0
        Me.numlotetxt.Name = "numlotetxt"
        Me.numlotetxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numlotetxt.Size = New System.Drawing.Size(89, 22)
        Me.numlotetxt.TabIndex = 0
        Me.numlotetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbVariedades
        '
        Me.cmbVariedades.BackColor = System.Drawing.SystemColors.Window
        Me.cmbVariedades.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbVariedades.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LotesBDS, "Variedad", True))
        Me.cmbVariedades.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVariedades.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbVariedades.Location = New System.Drawing.Point(314, 124)
        Me.cmbVariedades.Name = "cmbVariedades"
        Me.cmbVariedades.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbVariedades.Size = New System.Drawing.Size(89, 24)
        Me.cmbVariedades.TabIndex = 10
        '
        'bascTxt
        '
        Me.bascTxt.AcceptsReturn = True
        Me.bascTxt.BackColor = System.Drawing.SystemColors.Window
        Me.bascTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bascTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LotesBDS, "Bascula", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"))
        Me.bascTxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bascTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.bascTxt.Location = New System.Drawing.Point(314, 50)
        Me.bascTxt.MaxLength = 0
        Me.bascTxt.Name = "bascTxt"
        Me.bascTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bascTxt.Size = New System.Drawing.Size(89, 22)
        Me.bascTxt.TabIndex = 7
        '
        'dtFecha
        '
        Me.dtFecha.CalendarFont = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecha.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        Me.dtFecha.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LotesBDS, "Fecha", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dtFecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LotesBDS, "Fecha", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dtFecha.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFecha.Location = New System.Drawing.Point(260, 25)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.ShowUpDown = True
        Me.dtFecha.Size = New System.Drawing.Size(143, 22)
        Me.dtFecha.TabIndex = 6
        '
        '_Label11_3
        '
        Me._Label11_3.AutoSize = True
        Me._Label11_3.BackColor = System.Drawing.Color.Transparent
        Me._Label11_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label11_3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label11_3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._Label11_3.Location = New System.Drawing.Point(24, 153)
        Me._Label11_3.Name = "_Label11_3"
        Me._Label11_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label11_3.Size = New System.Drawing.Size(60, 16)
        Me._Label11_3.TabIndex = 53
        Me._Label11_3.Text = "Parcela :"
        '
        '_Label11_11
        '
        Me._Label11_11.AutoSize = True
        Me._Label11_11.BackColor = System.Drawing.Color.Transparent
        Me._Label11_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label11_11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label11_11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._Label11_11.Location = New System.Drawing.Point(210, 28)
        Me._Label11_11.Name = "_Label11_11"
        Me._Label11_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label11_11.Size = New System.Drawing.Size(52, 16)
        Me._Label11_11.TabIndex = 52
        Me._Label11_11.Text = "Fecha :"
        '
        '_Label11_10
        '
        Me._Label11_10.AutoSize = True
        Me._Label11_10.BackColor = System.Drawing.Color.Transparent
        Me._Label11_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label11_10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label11_10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._Label11_10.Location = New System.Drawing.Point(210, 103)
        Me._Label11_10.Name = "_Label11_10"
        Me._Label11_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label11_10.Size = New System.Drawing.Size(59, 16)
        Me._Label11_10.TabIndex = 51
        Me._Label11_10.Text = "Calidad :"
        '
        '_Label11_8
        '
        Me._Label11_8.AutoSize = True
        Me._Label11_8.BackColor = System.Drawing.Color.Transparent
        Me._Label11_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label11_8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label11_8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._Label11_8.Location = New System.Drawing.Point(24, 78)
        Me._Label11_8.Name = "_Label11_8"
        Me._Label11_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label11_8.Size = New System.Drawing.Size(69, 16)
        Me._Label11_8.TabIndex = 50
        Me._Label11_8.Text = "Matrícula :"
        '
        '_Label11_7
        '
        Me._Label11_7.AutoSize = True
        Me._Label11_7.BackColor = System.Drawing.Color.Transparent
        Me._Label11_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label11_7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label11_7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._Label11_7.Location = New System.Drawing.Point(210, 153)
        Me._Label11_7.Name = "_Label11_7"
        Me._Label11_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label11_7.Size = New System.Drawing.Size(45, 16)
        Me._Label11_7.TabIndex = 49
        Me._Label11_7.Text = "Kilos :"
        '
        '_Label11_5
        '
        Me._Label11_5.AutoSize = True
        Me._Label11_5.BackColor = System.Drawing.Color.Transparent
        Me._Label11_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label11_5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label11_5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._Label11_5.Location = New System.Drawing.Point(210, 78)
        Me._Label11_5.Name = "_Label11_5"
        Me._Label11_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label11_5.Size = New System.Drawing.Size(44, 16)
        Me._Label11_5.TabIndex = 48
        Me._Label11_5.Text = "Tolva :"
        '
        '_Label11_4
        '
        Me._Label11_4.AutoSize = True
        Me._Label11_4.BackColor = System.Drawing.Color.Transparent
        Me._Label11_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label11_4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label11_4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._Label11_4.Location = New System.Drawing.Point(24, 128)
        Me._Label11_4.Name = "_Label11_4"
        Me._Label11_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label11_4.Size = New System.Drawing.Size(66, 16)
        Me._Label11_4.TabIndex = 47
        Me._Label11_4.Text = "Polígono :"
        '
        '_Label11_2
        '
        Me._Label11_2.AutoSize = True
        Me._Label11_2.BackColor = System.Drawing.Color.Transparent
        Me._Label11_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label11_2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label11_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._Label11_2.Location = New System.Drawing.Point(24, 103)
        Me._Label11_2.Name = "_Label11_2"
        Me._Label11_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label11_2.Size = New System.Drawing.Size(62, 16)
        Me._Label11_2.TabIndex = 46
        Me._Label11_2.Text = "Término :"
        '
        '_Label11_1
        '
        Me._Label11_1.AutoSize = True
        Me._Label11_1.BackColor = System.Drawing.Color.Transparent
        Me._Label11_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label11_1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label11_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._Label11_1.Location = New System.Drawing.Point(24, 53)
        Me._Label11_1.Name = "_Label11_1"
        Me._Label11_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label11_1.Size = New System.Drawing.Size(78, 16)
        Me._Label11_1.TabIndex = 45
        Me._Label11_1.Text = "Cosechero :"
        '
        '_Label11_6
        '
        Me._Label11_6.AutoSize = True
        Me._Label11_6.BackColor = System.Drawing.Color.Transparent
        Me._Label11_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label11_6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label11_6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._Label11_6.Location = New System.Drawing.Point(210, 128)
        Me._Label11_6.Name = "_Label11_6"
        Me._Label11_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label11_6.Size = New System.Drawing.Size(66, 16)
        Me._Label11_6.TabIndex = 43
        Me._Label11_6.Text = "Variedad :"
        '
        '_Label11_9
        '
        Me._Label11_9.AutoSize = True
        Me._Label11_9.BackColor = System.Drawing.Color.Transparent
        Me._Label11_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label11_9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label11_9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._Label11_9.Location = New System.Drawing.Point(210, 53)
        Me._Label11_9.Name = "_Label11_9"
        Me._Label11_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label11_9.Size = New System.Drawing.Size(63, 16)
        Me._Label11_9.TabIndex = 42
        Me._Label11_9.Text = "Báscula :"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tabladatos, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BindingNavigator1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.54167!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.45834!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(592, 192)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'tabladatos
        '
        Me.tabladatos.AllowUserToAddRows = False
        Me.tabladatos.AllowUserToDeleteRows = False
        Me.tabladatos.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabladatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tabladatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabladatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDataGridViewTextBoxColumn, Me.CosecheroDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.KilosDataGridViewTextBoxColumn, Me.RendimientoDataGridViewTextBoxColumn, Me.CalidadDataGridViewTextBoxColumn, Me.BasculaDataGridViewTextBoxColumn, Me.TolvaDataGridViewTextBoxColumn, Me.TerminoDataGridViewTextBoxColumn, Me.PoligonoDataGridViewTextBoxColumn, Me.VariedadDataGridViewTextBoxColumn, Me.ParcelaDataGridViewTextBoxColumn})
        Me.tabladatos.DataSource = Me.LotesBDS
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabladatos.DefaultCellStyle = DataGridViewCellStyle2
        Me.tabladatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabladatos.Location = New System.Drawing.Point(3, 29)
        Me.tabladatos.Name = "tabladatos"
        Me.tabladatos.ReadOnly = True
        Me.tabladatos.RowHeadersVisible = False
        Me.tabladatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabladatos.Size = New System.Drawing.Size(586, 160)
        Me.tabladatos.TabIndex = 13
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.LotesBDS
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(592, 25)
        Me.BindingNavigator1.TabIndex = 14
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        Me.NumeroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CosecheroDataGridViewTextBoxColumn
        '
        Me.CosecheroDataGridViewTextBoxColumn.DataPropertyName = "Cosechero"
        Me.CosecheroDataGridViewTextBoxColumn.HeaderText = "Cosechero"
        Me.CosecheroDataGridViewTextBoxColumn.Name = "CosecheroDataGridViewTextBoxColumn"
        Me.CosecheroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KilosDataGridViewTextBoxColumn
        '
        Me.KilosDataGridViewTextBoxColumn.DataPropertyName = "Kilos"
        Me.KilosDataGridViewTextBoxColumn.HeaderText = "Kilos"
        Me.KilosDataGridViewTextBoxColumn.Name = "KilosDataGridViewTextBoxColumn"
        Me.KilosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RendimientoDataGridViewTextBoxColumn
        '
        Me.RendimientoDataGridViewTextBoxColumn.DataPropertyName = "Rendimiento"
        Me.RendimientoDataGridViewTextBoxColumn.HeaderText = "Rendimiento"
        Me.RendimientoDataGridViewTextBoxColumn.Name = "RendimientoDataGridViewTextBoxColumn"
        Me.RendimientoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CalidadDataGridViewTextBoxColumn
        '
        Me.CalidadDataGridViewTextBoxColumn.DataPropertyName = "Calidad"
        Me.CalidadDataGridViewTextBoxColumn.HeaderText = "Calidad"
        Me.CalidadDataGridViewTextBoxColumn.Name = "CalidadDataGridViewTextBoxColumn"
        Me.CalidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BasculaDataGridViewTextBoxColumn
        '
        Me.BasculaDataGridViewTextBoxColumn.DataPropertyName = "Bascula"
        Me.BasculaDataGridViewTextBoxColumn.HeaderText = "Bascula"
        Me.BasculaDataGridViewTextBoxColumn.Name = "BasculaDataGridViewTextBoxColumn"
        Me.BasculaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TolvaDataGridViewTextBoxColumn
        '
        Me.TolvaDataGridViewTextBoxColumn.DataPropertyName = "Tolva"
        Me.TolvaDataGridViewTextBoxColumn.HeaderText = "Tolva"
        Me.TolvaDataGridViewTextBoxColumn.Name = "TolvaDataGridViewTextBoxColumn"
        Me.TolvaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TerminoDataGridViewTextBoxColumn
        '
        Me.TerminoDataGridViewTextBoxColumn.DataPropertyName = "Termino"
        Me.TerminoDataGridViewTextBoxColumn.HeaderText = "Termino"
        Me.TerminoDataGridViewTextBoxColumn.Name = "TerminoDataGridViewTextBoxColumn"
        Me.TerminoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PoligonoDataGridViewTextBoxColumn
        '
        Me.PoligonoDataGridViewTextBoxColumn.DataPropertyName = "Poligono"
        Me.PoligonoDataGridViewTextBoxColumn.HeaderText = "Poligono"
        Me.PoligonoDataGridViewTextBoxColumn.Name = "PoligonoDataGridViewTextBoxColumn"
        Me.PoligonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VariedadDataGridViewTextBoxColumn
        '
        Me.VariedadDataGridViewTextBoxColumn.DataPropertyName = "Variedad"
        Me.VariedadDataGridViewTextBoxColumn.HeaderText = "Variedad"
        Me.VariedadDataGridViewTextBoxColumn.Name = "VariedadDataGridViewTextBoxColumn"
        Me.VariedadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ParcelaDataGridViewTextBoxColumn
        '
        Me.ParcelaDataGridViewTextBoxColumn.DataPropertyName = "Parcela"
        Me.ParcelaDataGridViewTextBoxColumn.HeaderText = "Parcela"
        Me.ParcelaDataGridViewTextBoxColumn.Name = "ParcelaDataGridViewTextBoxColumn"
        Me.ParcelaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmAdLotAceituna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(592, 443)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Toolbar1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdLotAceituna"
        Me.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Añadir lotes Aceituna"
        Me.Toolbar1.ResumeLayout(False)
        Me.Toolbar1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Frame_2.ResumeLayout(False)
        Me.Frame_2.PerformLayout()
        CType(Me.LotesBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.tabladatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.calBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VarBDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Public WithEvents Frame_2 As System.Windows.Forms.GroupBox
    Public WithEvents _Label11_0 As System.Windows.Forms.Label
    Public WithEvents cmbCalidad As System.Windows.Forms.ComboBox
    Public WithEvents kilostxt As System.Windows.Forms.TextBox
    Public WithEvents matriculatxt As System.Windows.Forms.TextBox
    Public WithEvents numlotetxt As System.Windows.Forms.TextBox
    Public WithEvents cmbVariedades As System.Windows.Forms.ComboBox
    Public WithEvents bascTxt As System.Windows.Forms.TextBox
    Public WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Public WithEvents _Label11_3 As System.Windows.Forms.Label
    Public WithEvents _Label11_11 As System.Windows.Forms.Label
    Public WithEvents _Label11_10 As System.Windows.Forms.Label
    Public WithEvents _Label11_8 As System.Windows.Forms.Label
    Public WithEvents _Label11_7 As System.Windows.Forms.Label
    Public WithEvents _Label11_5 As System.Windows.Forms.Label
    Public WithEvents _Label11_4 As System.Windows.Forms.Label
    Public WithEvents _Label11_2 As System.Windows.Forms.Label
    Public WithEvents _Label11_1 As System.Windows.Forms.Label
    Public WithEvents _Label11_6 As System.Windows.Forms.Label
    Public WithEvents _Label11_9 As System.Windows.Forms.Label
    Friend WithEvents tabladatos As System.Windows.Forms.DataGridView
    Friend WithEvents LotesBDS As System.Windows.Forms.BindingSource
    Public WithEvents tolvastxt As System.Windows.Forms.TextBox
    Public WithEvents numsociotxt As System.Windows.Forms.TextBox
    Public WithEvents polTxt As System.Windows.Forms.TextBox
    Public WithEvents tertxt As System.Windows.Forms.TextBox
    Public WithEvents partxt As System.Windows.Forms.TextBox
    Public WithEvents rendTxt As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents VarBDS As System.Windows.Forms.BindingSource
    Friend WithEvents calBDS As System.Windows.Forms.BindingSource
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents OleosigDB1 As Oleosig.oleosigDB
    Friend WithEvents NumeroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CosecheroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RendimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BasculaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TolvaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TerminoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PoligonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VariedadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ParcelaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region
End Class