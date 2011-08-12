<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAdSocios
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
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents _Toolbar1_Button1 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button2 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button3 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button5 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button7 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button9 As System.Windows.Forms.ToolStripButton
    Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip

    Public WithEvents numSociotxt As System.Windows.Forms.TextBox
    Public WithEvents cpTxt As System.Windows.Forms.TextBox
    Public WithEvents nifTxt As System.Windows.Forms.TextBox
    Public WithEvents nombreTxt As System.Windows.Forms.TextBox
    Public WithEvents provinciaTxt As System.Windows.Forms.TextBox
    Public WithEvents poblacionTxt As System.Windows.Forms.TextBox
    Public WithEvents _Label8_1 As System.Windows.Forms.Label
    Public WithEvents _Label2_0 As System.Windows.Forms.Label
    Public WithEvents _Label5_0 As System.Windows.Forms.Label
    Public WithEvents _Label6_0 As System.Windows.Forms.Label
    Public WithEvents _Label7_0 As System.Windows.Forms.Label
    Public WithEvents _Label8_0 As System.Windows.Forms.Label
    Public WithEvents _Frame_0 As System.Windows.Forms.GroupBox
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdSocios))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.tablasocios = New System.Windows.Forms.DataGridView()
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
        Me._Frame_0 = New System.Windows.Forms.GroupBox()
        Me.dirTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.apellido2Txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.apellido1Txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.numSociotxt = New System.Windows.Forms.TextBox()
        Me.cpTxt = New System.Windows.Forms.TextBox()
        Me.nifTxt = New System.Windows.Forms.TextBox()
        Me.nombreTxt = New System.Windows.Forms.TextBox()
        Me.provinciaTxt = New System.Windows.Forms.TextBox()
        Me.poblacionTxt = New System.Windows.Forms.TextBox()
        Me._Label8_1 = New System.Windows.Forms.Label()
        Me._Label2_0 = New System.Windows.Forms.Label()
        Me._Label5_0 = New System.Windows.Forms.Label()
        Me._Label6_0 = New System.Windows.Forms.Label()
        Me._Label7_0 = New System.Windows.Forms.Label()
        Me._Label8_0 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.CosecherosBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.OleosigDB1 = New Oleosig.oleosigDB()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NifDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoblacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvinciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Frame3.SuspendLayout()
        CType(Me.tablasocios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Toolbar1.SuspendLayout()
        Me._Frame_0.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.CosecherosBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.tablasocios)
        Me.Frame3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Frame3.Location = New System.Drawing.Point(3, 208)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(628, 200)
        Me.Frame3.TabIndex = 32
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "Cosecheros Existentes"
        '
        'tablasocios
        '
        Me.tablasocios.AllowUserToAddRows = False
        Me.tablasocios.AllowUserToDeleteRows = False
        Me.tablasocios.AllowUserToResizeColumns = False
        Me.tablasocios.AllowUserToResizeRows = False
        Me.tablasocios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tablasocios.AutoGenerateColumns = False
        Me.tablasocios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.tablasocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablasocios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.Apellido1DataGridViewTextBoxColumn, Me.Apellido2DataGridViewTextBoxColumn, Me.NifDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.PoblacionDataGridViewTextBoxColumn, Me.ProvinciaDataGridViewTextBoxColumn})
        Me.tablasocios.DataSource = Me.CosecherosBDS
        Me.tablasocios.Location = New System.Drawing.Point(14, 24)
        Me.tablasocios.Name = "tablasocios"
        Me.tablasocios.ReadOnly = True
        Me.tablasocios.RowHeadersVisible = False
        Me.tablasocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tablasocios.Size = New System.Drawing.Size(598, 157)
        Me.tablasocios.TabIndex = 34
        '
        'Toolbar1
        '
        Me.Toolbar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._Toolbar1_Button1, Me._Toolbar1_Button2, Me._Toolbar1_Button3, Me.ToolStripSeparator1, Me._Toolbar1_Button5, Me.ToolStripSeparator2, Me._Toolbar1_Button7, Me.ToolStripSeparator3, Me._Toolbar1_Button9})
        Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar1.Name = "Toolbar1"
        Me.Toolbar1.Size = New System.Drawing.Size(634, 48)
        Me.Toolbar1.TabIndex = 18
        '
        '_Toolbar1_Button1
        '
        Me._Toolbar1_Button1.AutoSize = False
        Me._Toolbar1_Button1.Image = Global.Oleosig.My.Resources.Resources.document_new
        Me._Toolbar1_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button1.Name = "_Toolbar1_Button1"
        Me._Toolbar1_Button1.Size = New System.Drawing.Size(50, 45)
        Me._Toolbar1_Button1.Text = "&Nuevo"
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
        '_Frame_0
        '
        Me._Frame_0.BackColor = System.Drawing.SystemColors.Control
        Me._Frame_0.Controls.Add(Me.dirTxt)
        Me._Frame_0.Controls.Add(Me.Label5)
        Me._Frame_0.Controls.Add(Me.apellido2Txt)
        Me._Frame_0.Controls.Add(Me.Label3)
        Me._Frame_0.Controls.Add(Me.apellido1Txt)
        Me._Frame_0.Controls.Add(Me.Label2)
        Me._Frame_0.Controls.Add(Me.cmdFind)
        Me._Frame_0.Controls.Add(Me.numSociotxt)
        Me._Frame_0.Controls.Add(Me.cpTxt)
        Me._Frame_0.Controls.Add(Me.nifTxt)
        Me._Frame_0.Controls.Add(Me.nombreTxt)
        Me._Frame_0.Controls.Add(Me.provinciaTxt)
        Me._Frame_0.Controls.Add(Me.poblacionTxt)
        Me._Frame_0.Controls.Add(Me._Label8_1)
        Me._Frame_0.Controls.Add(Me._Label2_0)
        Me._Frame_0.Controls.Add(Me._Label5_0)
        Me._Frame_0.Controls.Add(Me._Label6_0)
        Me._Frame_0.Controls.Add(Me._Label7_0)
        Me._Frame_0.Controls.Add(Me._Label8_0)
        Me._Frame_0.Dock = System.Windows.Forms.DockStyle.Fill
        Me._Frame_0.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame_0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._Frame_0.Location = New System.Drawing.Point(3, 3)
        Me._Frame_0.Name = "_Frame_0"
        Me._Frame_0.Padding = New System.Windows.Forms.Padding(0)
        Me._Frame_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Frame_0.Size = New System.Drawing.Size(628, 199)
        Me._Frame_0.TabIndex = 0
        Me._Frame_0.TabStop = False
        Me._Frame_0.Text = "Cosecheros"
        '
        'dirTxt
        '
        Me.dirTxt.AcceptsReturn = True
        Me.dirTxt.BackColor = System.Drawing.SystemColors.Window
        Me.dirTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dirTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CosecherosBDS, "Direccion", True))
        Me.dirTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.dirTxt.Location = New System.Drawing.Point(80, 116)
        Me.dirTxt.MaxLength = 0
        Me.dirTxt.Name = "dirTxt"
        Me.dirTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dirTxt.Size = New System.Drawing.Size(306, 22)
        Me.dirTxt.TabIndex = 4
        Me.dirTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(8, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Dirección :"
        '
        'apellido2Txt
        '
        Me.apellido2Txt.AcceptsReturn = True
        Me.apellido2Txt.BackColor = System.Drawing.SystemColors.Window
        Me.apellido2Txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.apellido2Txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CosecherosBDS, "Apellido2", True))
        Me.apellido2Txt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.apellido2Txt.Location = New System.Drawing.Point(319, 88)
        Me.apellido2Txt.MaxLength = 0
        Me.apellido2Txt.Name = "apellido2Txt"
        Me.apellido2Txt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.apellido2Txt.Size = New System.Drawing.Size(162, 22)
        Me.apellido2Txt.TabIndex = 3
        Me.apellido2Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(248, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Apellido2 :"
        '
        'apellido1Txt
        '
        Me.apellido1Txt.AcceptsReturn = True
        Me.apellido1Txt.BackColor = System.Drawing.SystemColors.Window
        Me.apellido1Txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.apellido1Txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CosecherosBDS, "Apellido1", True))
        Me.apellido1Txt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.apellido1Txt.Location = New System.Drawing.Point(80, 88)
        Me.apellido1Txt.MaxLength = 0
        Me.apellido1Txt.Name = "apellido1Txt"
        Me.apellido1Txt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.apellido1Txt.Size = New System.Drawing.Size(162, 22)
        Me.apellido1Txt.TabIndex = 2
        Me.apellido1Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Apellido1 :"
        '
        'cmdFind
        '
        Me.cmdFind.BackColor = System.Drawing.SystemColors.Control
        Me.cmdFind.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFind.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.Location = New System.Drawing.Point(332, 21)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdFind.Size = New System.Drawing.Size(43, 29)
        Me.cmdFind.TabIndex = 36
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdFind.UseVisualStyleBackColor = False
        '
        'numSociotxt
        '
        Me.numSociotxt.AcceptsReturn = True
        Me.numSociotxt.BackColor = System.Drawing.SystemColors.Window
        Me.numSociotxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numSociotxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CosecherosBDS, "Codigo", True))
        Me.numSociotxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.numSociotxt.Location = New System.Drawing.Point(80, 24)
        Me.numSociotxt.MaxLength = 0
        Me.numSociotxt.Name = "numSociotxt"
        Me.numSociotxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numSociotxt.Size = New System.Drawing.Size(49, 22)
        Me.numSociotxt.TabIndex = 1
        Me.numSociotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cpTxt
        '
        Me.cpTxt.AcceptsReturn = True
        Me.cpTxt.BackColor = System.Drawing.SystemColors.Window
        Me.cpTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cpTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CosecherosBDS, "Cp", True))
        Me.cpTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cpTxt.Location = New System.Drawing.Point(432, 117)
        Me.cpTxt.MaxLength = 0
        Me.cpTxt.Name = "cpTxt"
        Me.cpTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cpTxt.Size = New System.Drawing.Size(49, 22)
        Me.cpTxt.TabIndex = 5
        Me.cpTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nifTxt
        '
        Me.nifTxt.AcceptsReturn = True
        Me.nifTxt.BackColor = System.Drawing.SystemColors.Window
        Me.nifTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nifTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CosecherosBDS, "Nif", True))
        Me.nifTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nifTxt.Location = New System.Drawing.Point(234, 24)
        Me.nifTxt.MaxLength = 0
        Me.nifTxt.Name = "nifTxt"
        Me.nifTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nifTxt.Size = New System.Drawing.Size(73, 22)
        Me.nifTxt.TabIndex = 0
        Me.nifTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nombreTxt
        '
        Me.nombreTxt.AcceptsReturn = True
        Me.nombreTxt.BackColor = System.Drawing.SystemColors.Window
        Me.nombreTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nombreTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CosecherosBDS, "Nombre", True))
        Me.nombreTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nombreTxt.Location = New System.Drawing.Point(80, 56)
        Me.nombreTxt.MaxLength = 0
        Me.nombreTxt.Name = "nombreTxt"
        Me.nombreTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nombreTxt.Size = New System.Drawing.Size(162, 22)
        Me.nombreTxt.TabIndex = 1
        Me.nombreTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'provinciaTxt
        '
        Me.provinciaTxt.AcceptsReturn = True
        Me.provinciaTxt.BackColor = System.Drawing.SystemColors.Window
        Me.provinciaTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.provinciaTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CosecherosBDS, "Provincia", True))
        Me.provinciaTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.provinciaTxt.Location = New System.Drawing.Point(80, 145)
        Me.provinciaTxt.MaxLength = 0
        Me.provinciaTxt.Name = "provinciaTxt"
        Me.provinciaTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.provinciaTxt.Size = New System.Drawing.Size(105, 22)
        Me.provinciaTxt.TabIndex = 6
        Me.provinciaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'poblacionTxt
        '
        Me.poblacionTxt.AcceptsReturn = True
        Me.poblacionTxt.BackColor = System.Drawing.SystemColors.Window
        Me.poblacionTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.poblacionTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CosecherosBDS, "Provincia", True))
        Me.poblacionTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.poblacionTxt.Location = New System.Drawing.Point(291, 145)
        Me.poblacionTxt.MaxLength = 0
        Me.poblacionTxt.Name = "poblacionTxt"
        Me.poblacionTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.poblacionTxt.Size = New System.Drawing.Size(190, 22)
        Me.poblacionTxt.TabIndex = 7
        Me.poblacionTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Label8_1
        '
        Me._Label8_1.AutoSize = True
        Me._Label8_1.BackColor = System.Drawing.Color.Transparent
        Me._Label8_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label8_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._Label8_1.Location = New System.Drawing.Point(8, 27)
        Me._Label8_1.Name = "_Label8_1"
        Me._Label8_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label8_1.Size = New System.Drawing.Size(61, 16)
        Me._Label8_1.TabIndex = 26
        Me._Label8_1.Text = "Número :"
        '
        '_Label2_0
        '
        Me._Label2_0.AutoSize = True
        Me._Label2_0.BackColor = System.Drawing.Color.Transparent
        Me._Label2_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._Label2_0.Location = New System.Drawing.Point(7, 59)
        Me._Label2_0.Name = "_Label2_0"
        Me._Label2_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_0.Size = New System.Drawing.Size(61, 16)
        Me._Label2_0.TabIndex = 16
        Me._Label2_0.Text = "Nombre :"
        '
        '_Label5_0
        '
        Me._Label5_0.AutoSize = True
        Me._Label5_0.BackColor = System.Drawing.Color.Transparent
        Me._Label5_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label5_0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._Label5_0.Location = New System.Drawing.Point(392, 122)
        Me._Label5_0.Name = "_Label5_0"
        Me._Label5_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label5_0.Size = New System.Drawing.Size(34, 16)
        Me._Label5_0.TabIndex = 15
        Me._Label5_0.Text = "CP :"
        '
        '_Label6_0
        '
        Me._Label6_0.AutoSize = True
        Me._Label6_0.BackColor = System.Drawing.Color.Transparent
        Me._Label6_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label6_0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._Label6_0.Location = New System.Drawing.Point(195, 148)
        Me._Label6_0.Name = "_Label6_0"
        Me._Label6_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label6_0.Size = New System.Drawing.Size(73, 16)
        Me._Label6_0.TabIndex = 14
        Me._Label6_0.Text = "Población :"
        '
        '_Label7_0
        '
        Me._Label7_0.AutoSize = True
        Me._Label7_0.BackColor = System.Drawing.Color.Transparent
        Me._Label7_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label7_0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._Label7_0.Location = New System.Drawing.Point(9, 150)
        Me._Label7_0.Name = "_Label7_0"
        Me._Label7_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label7_0.Size = New System.Drawing.Size(45, 16)
        Me._Label7_0.TabIndex = 13
        Me._Label7_0.Text = "Prov. :"
        '
        '_Label8_0
        '
        Me._Label8_0.AutoSize = True
        Me._Label8_0.BackColor = System.Drawing.Color.Transparent
        Me._Label8_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label8_0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._Label8_0.Location = New System.Drawing.Point(142, 27)
        Me._Label8_0.Name = "_Label8_0"
        Me._Label8_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label8_0.Size = New System.Drawing.Size(88, 16)
        Me._Label8_0.TabIndex = 12
        Me._Label8_0.Text = "N.I. F./C.I.F. :"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Frame3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me._Frame_0, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 48)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(634, 411)
        Me.TableLayoutPanel1.TabIndex = 33
        '
        'CosecherosBDS
        '
        Me.CosecherosBDS.DataMember = "cosecheros"
        Me.CosecherosBDS.DataSource = Me.OleosigDB1
        '
        'OleosigDB1
        '
        Me.OleosigDB1.DataSetName = "oleosigDB"
        Me.OleosigDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoDataGridViewTextBoxColumn.Width = 73
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 78
        '
        'Apellido1DataGridViewTextBoxColumn
        '
        Me.Apellido1DataGridViewTextBoxColumn.DataPropertyName = "Apellido1"
        Me.Apellido1DataGridViewTextBoxColumn.HeaderText = "Apellido1"
        Me.Apellido1DataGridViewTextBoxColumn.Name = "Apellido1DataGridViewTextBoxColumn"
        Me.Apellido1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Apellido1DataGridViewTextBoxColumn.Width = 86
        '
        'Apellido2DataGridViewTextBoxColumn
        '
        Me.Apellido2DataGridViewTextBoxColumn.DataPropertyName = "Apellido2"
        Me.Apellido2DataGridViewTextBoxColumn.HeaderText = "Apellido2"
        Me.Apellido2DataGridViewTextBoxColumn.Name = "Apellido2DataGridViewTextBoxColumn"
        Me.Apellido2DataGridViewTextBoxColumn.ReadOnly = True
        Me.Apellido2DataGridViewTextBoxColumn.Width = 86
        '
        'NifDataGridViewTextBoxColumn
        '
        Me.NifDataGridViewTextBoxColumn.DataPropertyName = "Nif"
        Me.NifDataGridViewTextBoxColumn.HeaderText = "Nif"
        Me.NifDataGridViewTextBoxColumn.Name = "NifDataGridViewTextBoxColumn"
        Me.NifDataGridViewTextBoxColumn.ReadOnly = True
        Me.NifDataGridViewTextBoxColumn.Width = 48
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DireccionDataGridViewTextBoxColumn.Width = 87
        '
        'PoblacionDataGridViewTextBoxColumn
        '
        Me.PoblacionDataGridViewTextBoxColumn.DataPropertyName = "Poblacion"
        Me.PoblacionDataGridViewTextBoxColumn.HeaderText = "Poblacion"
        Me.PoblacionDataGridViewTextBoxColumn.Name = "PoblacionDataGridViewTextBoxColumn"
        Me.PoblacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.PoblacionDataGridViewTextBoxColumn.Width = 90
        '
        'ProvinciaDataGridViewTextBoxColumn
        '
        Me.ProvinciaDataGridViewTextBoxColumn.DataPropertyName = "Provincia"
        Me.ProvinciaDataGridViewTextBoxColumn.HeaderText = "Provincia"
        Me.ProvinciaDataGridViewTextBoxColumn.Name = "ProvinciaDataGridViewTextBoxColumn"
        Me.ProvinciaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProvinciaDataGridViewTextBoxColumn.Width = 85
        '
        'frmAdSocios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(634, 459)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Toolbar1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MinimizeBox = False
        Me.Name = "frmAdSocios"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Cosecheros"
        Me.Frame3.ResumeLayout(False)
        CType(Me.tablasocios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Toolbar1.ResumeLayout(False)
        Me.Toolbar1.PerformLayout()
        Me._Frame_0.ResumeLayout(False)
        Me._Frame_0.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.CosecherosBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents tablasocios As System.Windows.Forms.DataGridView
    Public WithEvents apellido2Txt As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents apellido1Txt As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents dirTxt As System.Windows.Forms.TextBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CosecherosBDS As System.Windows.Forms.BindingSource
    Friend WithEvents OleosigDB1 As Oleosig.oleosigDB
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NifDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PoblacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvinciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region
End Class