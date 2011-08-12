<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAdorujos
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
    Public WithEvents dniTxt As System.Windows.Forms.TextBox
	Public WithEvents idConductorTxt As System.Windows.Forms.TextBox
	Public WithEvents conductorTxt As System.Windows.Forms.TextBox
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents netoTxt As System.Windows.Forms.TextBox
	Public WithEvents vehiculoTxt As System.Windows.Forms.TextBox
	Public WithEvents brutoTxt As System.Windows.Forms.TextBox
	Public WithEvents taraTxt As System.Windows.Forms.TextBox
	Public WithEvents idVehiculotxt As System.Windows.Forms.TextBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents fechaOrujos As System.Windows.Forms.MaskedTextBox
	Public WithEvents _Toolbar1_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents _Toolbar1_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _Toolbar1_Button3 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button5 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button7 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button9 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
    Public WithEvents Label2 As System.Windows.Forms.Label
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdorujos))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.dniTxt = New System.Windows.Forms.TextBox()
        Me.idConductorTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.conductorTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.netoTxt = New System.Windows.Forms.TextBox()
        Me.vehiculoTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.taraTxt = New System.Windows.Forms.TextBox()
        Me.brutoTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.idVehiculotxt = New System.Windows.Forms.TextBox()
        Me.fechaOrujos = New System.Windows.Forms.MaskedTextBox()
        Me.Toolbar1 = New System.Windows.Forms.ToolStrip()
        Me._Toolbar1_Button1 = New System.Windows.Forms.ToolStripButton()
        Me._Toolbar1_Button2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me._Toolbar1_Button3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me._Toolbar1_Button5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me._Toolbar1_Button7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me._Toolbar1_Button9 = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VehiculosBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me._SSTab1_TabPage2 = New System.Windows.Forms.TabPage()
        Me.tablaVehiculos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._SSTab1_TabPage1 = New System.Windows.Forms.TabPage()
        Me.tablaConductores = New System.Windows.Forms.DataGridView()
        Me.conductoresBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me._SSTab1_TabPage0 = New System.Windows.Forms.TabPage()
        Me.SSTab1 = New System.Windows.Forms.TabControl()
        Me.OleosigDB1 = New Oleosig.oleosigDB()
        Me.oporujosBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.tablaorujos = New System.Windows.Forms.DataGridView()
        Me.IdconductorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdvehiculoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PesobrutoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.Toolbar1.SuspendLayout()
        CType(Me.VehiculosBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._SSTab1_TabPage2.SuspendLayout()
        CType(Me.tablaVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._SSTab1_TabPage1.SuspendLayout()
        CType(Me.tablaConductores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.conductoresBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._SSTab1_TabPage0.SuspendLayout()
        Me.SSTab1.SuspendLayout()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oporujosBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablaorujos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.dniTxt)
        Me.Frame2.Controls.Add(Me.idConductorTxt)
        Me.Frame2.Controls.Add(Me.Label8)
        Me.Frame2.Controls.Add(Me.conductorTxt)
        Me.Frame2.Controls.Add(Me.Label4)
        Me.Frame2.Controls.Add(Me.Label9)
        Me.Frame2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Frame2.Location = New System.Drawing.Point(16, 88)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(465, 129)
        Me.Frame2.TabIndex = 23
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Conductor"
        '
        'dniTxt
        '
        Me.dniTxt.AcceptsReturn = True
        Me.dniTxt.BackColor = System.Drawing.SystemColors.Window
        Me.dniTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dniTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.dniTxt.Location = New System.Drawing.Point(88, 87)
        Me.dniTxt.MaxLength = 0
        Me.dniTxt.Name = "dniTxt"
        Me.dniTxt.ReadOnly = True
        Me.dniTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dniTxt.Size = New System.Drawing.Size(97, 22)
        Me.dniTxt.TabIndex = 3
        Me.dniTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'idConductorTxt
        '
        Me.idConductorTxt.AcceptsReturn = True
        Me.idConductorTxt.BackColor = System.Drawing.SystemColors.Window
        Me.idConductorTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.idConductorTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.idConductorTxt.Location = New System.Drawing.Point(88, 23)
        Me.idConductorTxt.MaxLength = 0
        Me.idConductorTxt.Name = "idConductorTxt"
        Me.idConductorTxt.ReadOnly = True
        Me.idConductorTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.idConductorTxt.Size = New System.Drawing.Size(49, 22)
        Me.idConductorTxt.TabIndex = 1
        Me.idConductorTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(8, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(28, 16)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Id :"
        '
        'conductorTxt
        '
        Me.conductorTxt.AcceptsReturn = True
        Me.conductorTxt.BackColor = System.Drawing.SystemColors.Window
        Me.conductorTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.conductorTxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conductorTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.conductorTxt.Location = New System.Drawing.Point(88, 55)
        Me.conductorTxt.MaxLength = 0
        Me.conductorTxt.Name = "conductorTxt"
        Me.conductorTxt.ReadOnly = True
        Me.conductorTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.conductorTxt.Size = New System.Drawing.Size(345, 22)
        Me.conductorTxt.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Nombre :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(8, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(42, 16)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "D.N.I."
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.netoTxt)
        Me.Frame1.Controls.Add(Me.vehiculoTxt)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.taraTxt)
        Me.Frame1.Controls.Add(Me.brutoTxt)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label7)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Controls.Add(Me.Label6)
        Me.Frame1.Controls.Add(Me.idVehiculotxt)
        Me.Frame1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Frame1.Location = New System.Drawing.Point(16, 224)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(465, 113)
        Me.Frame1.TabIndex = 16
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Vehículo"
        '
        'netoTxt
        '
        Me.netoTxt.AcceptsReturn = True
        Me.netoTxt.BackColor = System.Drawing.SystemColors.Window
        Me.netoTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.netoTxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.netoTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.netoTxt.Location = New System.Drawing.Point(341, 61)
        Me.netoTxt.MaxLength = 0
        Me.netoTxt.Name = "netoTxt"
        Me.netoTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.netoTxt.Size = New System.Drawing.Size(73, 22)
        Me.netoTxt.TabIndex = 8
        Me.netoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'vehiculoTxt
        '
        Me.vehiculoTxt.AcceptsReturn = True
        Me.vehiculoTxt.BackColor = System.Drawing.SystemColors.Window
        Me.vehiculoTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.vehiculoTxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vehiculoTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.vehiculoTxt.Location = New System.Drawing.Point(293, 24)
        Me.vehiculoTxt.MaxLength = 0
        Me.vehiculoTxt.Name = "vehiculoTxt"
        Me.vehiculoTxt.ReadOnly = True
        Me.vehiculoTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.vehiculoTxt.Size = New System.Drawing.Size(121, 22)
        Me.vehiculoTxt.TabIndex = 5
        Me.vehiculoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(28, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Id :"
        '
        'taraTxt
        '
        Me.taraTxt.AcceptsReturn = True
        Me.taraTxt.BackColor = System.Drawing.SystemColors.Window
        Me.taraTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.taraTxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taraTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.taraTxt.Location = New System.Drawing.Point(203, 61)
        Me.taraTxt.MaxLength = 0
        Me.taraTxt.Name = "taraTxt"
        Me.taraTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.taraTxt.Size = New System.Drawing.Size(73, 22)
        Me.taraTxt.TabIndex = 7
        Me.taraTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'brutoTxt
        '
        Me.brutoTxt.AcceptsReturn = True
        Me.brutoTxt.BackColor = System.Drawing.SystemColors.Window
        Me.brutoTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.brutoTxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brutoTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.brutoTxt.Location = New System.Drawing.Point(62, 61)
        Me.brutoTxt.MaxLength = 0
        Me.brutoTxt.Name = "brutoTxt"
        Me.brutoTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.brutoTxt.Size = New System.Drawing.Size(73, 22)
        Me.brutoTxt.TabIndex = 6
        Me.brutoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(287, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Neto :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(8, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(50, 16)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Bruto :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(208, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(75, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Matrícula :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(154, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(45, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Tara :"
        '
        'idVehiculotxt
        '
        Me.idVehiculotxt.AcceptsReturn = True
        Me.idVehiculotxt.BackColor = System.Drawing.SystemColors.Window
        Me.idVehiculotxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.idVehiculotxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.idVehiculotxt.Location = New System.Drawing.Point(62, 23)
        Me.idVehiculotxt.MaxLength = 0
        Me.idVehiculotxt.Name = "idVehiculotxt"
        Me.idVehiculotxt.ReadOnly = True
        Me.idVehiculotxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.idVehiculotxt.Size = New System.Drawing.Size(57, 22)
        Me.idVehiculotxt.TabIndex = 4
        Me.idVehiculotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fechaOrujos
        '
        Me.fechaOrujos.AllowPromptAsInput = False
        Me.fechaOrujos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.oporujosBDS, "Fecha", True))
        Me.fechaOrujos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaOrujos.Location = New System.Drawing.Point(104, 56)
        Me.fechaOrujos.Mask = "##/##/####"
        Me.fechaOrujos.Name = "fechaOrujos"
        Me.fechaOrujos.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.fechaOrujos.Size = New System.Drawing.Size(105, 22)
        Me.fechaOrujos.TabIndex = 0
        '
        'Toolbar1
        '
        Me.Toolbar1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Toolbar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._Toolbar1_Button1, Me._Toolbar1_Button2, Me.ToolStripSeparator1, Me._Toolbar1_Button3, Me.ToolStripSeparator2, Me._Toolbar1_Button5, Me.ToolStripSeparator3, Me._Toolbar1_Button7, Me.ToolStripSeparator4, Me._Toolbar1_Button9})
        Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar1.Name = "Toolbar1"
        Me.Toolbar1.Size = New System.Drawing.Size(489, 48)
        Me.Toolbar1.TabIndex = 14
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 48)
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 48)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(24, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Fecha :"
        '
        '_SSTab1_TabPage2
        '
        Me._SSTab1_TabPage2.Controls.Add(Me.tablaVehiculos)
        Me._SSTab1_TabPage2.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage2.Name = "_SSTab1_TabPage2"
        Me._SSTab1_TabPage2.Size = New System.Drawing.Size(465, 190)
        Me._SSTab1_TabPage2.TabIndex = 2
        Me._SSTab1_TabPage2.Text = "Vehiculos"
        '
        'tablaVehiculos
        '
        Me.tablaVehiculos.AllowUserToAddRows = False
        Me.tablaVehiculos.AllowUserToDeleteRows = False
        Me.tablaVehiculos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tablaVehiculos.AutoGenerateColumns = False
        Me.tablaVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaVehiculos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.tablaVehiculos.DataSource = Me.VehiculosBDS
        Me.tablaVehiculos.Location = New System.Drawing.Point(16, 13)
        Me.tablaVehiculos.MultiSelect = False
        Me.tablaVehiculos.Name = "tablaVehiculos"
        Me.tablaVehiculos.ReadOnly = True
        Me.tablaVehiculos.Size = New System.Drawing.Size(240, 171)
        Me.tablaVehiculos.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "matricula"
        Me.Column1.HeaderText = "Matricula"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        '_SSTab1_TabPage1
        '
        Me._SSTab1_TabPage1.Controls.Add(Me.tablaConductores)
        Me._SSTab1_TabPage1.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage1.Name = "_SSTab1_TabPage1"
        Me._SSTab1_TabPage1.Size = New System.Drawing.Size(465, 190)
        Me._SSTab1_TabPage1.TabIndex = 1
        Me._SSTab1_TabPage1.Text = "Conductores"
        '
        'tablaConductores
        '
        Me.tablaConductores.AllowUserToAddRows = False
        Me.tablaConductores.AllowUserToDeleteRows = False
        Me.tablaConductores.AutoGenerateColumns = False
        Me.tablaConductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaConductores.DataSource = Me.conductoresBDS
        Me.tablaConductores.Location = New System.Drawing.Point(15, 15)
        Me.tablaConductores.Name = "tablaConductores"
        Me.tablaConductores.ReadOnly = True
        Me.tablaConductores.Size = New System.Drawing.Size(434, 169)
        Me.tablaConductores.TabIndex = 0
        '
        '_SSTab1_TabPage0
        '
        Me._SSTab1_TabPage0.Controls.Add(Me.tablaorujos)
        Me._SSTab1_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage0.Name = "_SSTab1_TabPage0"
        Me._SSTab1_TabPage0.Size = New System.Drawing.Size(465, 190)
        Me._SSTab1_TabPage0.TabIndex = 0
        Me._SSTab1_TabPage0.Text = "Salidas Orujos"
        '
        'SSTab1
        '
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage0)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage1)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage2)
        Me.SSTab1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SSTab1.ItemSize = New System.Drawing.Size(42, 18)
        Me.SSTab1.Location = New System.Drawing.Point(8, 344)
        Me.SSTab1.Name = "SSTab1"
        Me.SSTab1.SelectedIndex = 1
        Me.SSTab1.Size = New System.Drawing.Size(473, 216)
        Me.SSTab1.TabIndex = 9
        '
        'OleosigDB1
        '
        Me.OleosigDB1.DataSetName = "oleosigDB"
        Me.OleosigDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'oporujosBDS
        '
        Me.oporujosBDS.DataMember = "oporujos"
        Me.oporujosBDS.DataSource = Me.OleosigDB1
        '
        'tablaorujos
        '
        Me.tablaorujos.AllowUserToAddRows = False
        Me.tablaorujos.AllowUserToDeleteRows = False
        Me.tablaorujos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tablaorujos.AutoGenerateColumns = False
        Me.tablaorujos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.tablaorujos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaorujos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdconductorDataGridViewTextBoxColumn, Me.IdvehiculoDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.PesobrutoDataGridViewTextBoxColumn, Me.TaraDataGridViewTextBoxColumn})
        Me.tablaorujos.DataSource = Me.oporujosBDS
        Me.tablaorujos.Location = New System.Drawing.Point(15, 13)
        Me.tablaorujos.MultiSelect = False
        Me.tablaorujos.Name = "tablaorujos"
        Me.tablaorujos.ReadOnly = True
        Me.tablaorujos.RowHeadersVisible = False
        Me.tablaorujos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tablaorujos.Size = New System.Drawing.Size(422, 150)
        Me.tablaorujos.TabIndex = 0
        '
        'IdconductorDataGridViewTextBoxColumn
        '
        Me.IdconductorDataGridViewTextBoxColumn.DataPropertyName = "Idconductor"
        Me.IdconductorDataGridViewTextBoxColumn.HeaderText = "Idconductor"
        Me.IdconductorDataGridViewTextBoxColumn.Name = "IdconductorDataGridViewTextBoxColumn"
        Me.IdconductorDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdconductorDataGridViewTextBoxColumn.Width = 108
        '
        'IdvehiculoDataGridViewTextBoxColumn
        '
        Me.IdvehiculoDataGridViewTextBoxColumn.DataPropertyName = "Idvehiculo"
        Me.IdvehiculoDataGridViewTextBoxColumn.HeaderText = "Idvehiculo"
        Me.IdvehiculoDataGridViewTextBoxColumn.Name = "IdvehiculoDataGridViewTextBoxColumn"
        Me.IdvehiculoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdvehiculoDataGridViewTextBoxColumn.Width = 99
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 72
        '
        'PesobrutoDataGridViewTextBoxColumn
        '
        Me.PesobrutoDataGridViewTextBoxColumn.DataPropertyName = "Pesobruto"
        Me.PesobrutoDataGridViewTextBoxColumn.HeaderText = "Pesobruto"
        Me.PesobrutoDataGridViewTextBoxColumn.Name = "PesobrutoDataGridViewTextBoxColumn"
        Me.PesobrutoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PesobrutoDataGridViewTextBoxColumn.Width = 97
        '
        'TaraDataGridViewTextBoxColumn
        '
        Me.TaraDataGridViewTextBoxColumn.DataPropertyName = "Tara"
        Me.TaraDataGridViewTextBoxColumn.HeaderText = "Tara"
        Me.TaraDataGridViewTextBoxColumn.Name = "TaraDataGridViewTextBoxColumn"
        Me.TaraDataGridViewTextBoxColumn.ReadOnly = True
        Me.TaraDataGridViewTextBoxColumn.Width = 62
        '
        'frmAdorujos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(489, 562)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.SSTab1)
        Me.Controls.Add(Me.fechaOrujos)
        Me.Controls.Add(Me.Toolbar1)
        Me.Controls.Add(Me.Label2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdorujos"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Orujos"
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Toolbar1.ResumeLayout(False)
        Me.Toolbar1.PerformLayout()
        CType(Me.VehiculosBDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me._SSTab1_TabPage2.ResumeLayout(False)
        CType(Me.tablaVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me._SSTab1_TabPage1.ResumeLayout(False)
        CType(Me.tablaConductores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.conductoresBDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me._SSTab1_TabPage0.ResumeLayout(False)
        Me.SSTab1.ResumeLayout(False)
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.oporujosBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablaorujos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VehiculosBDS As System.Windows.Forms.BindingSource
    Public WithEvents _SSTab1_TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents tablaVehiculos As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents _SSTab1_TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents _SSTab1_TabPage0 As System.Windows.Forms.TabPage
    Public WithEvents SSTab1 As System.Windows.Forms.TabControl
    Friend WithEvents tablaConductores As System.Windows.Forms.DataGridView
    Friend WithEvents conductoresBDS As System.Windows.Forms.BindingSource
    Friend WithEvents OleosigDB1 As Oleosig.oleosigDB
    Friend WithEvents oporujosBDS As System.Windows.Forms.BindingSource
    Friend WithEvents tablaorujos As System.Windows.Forms.DataGridView
    Friend WithEvents IdconductorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdvehiculoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PesobrutoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region 
End Class