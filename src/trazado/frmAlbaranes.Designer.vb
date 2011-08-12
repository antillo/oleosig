<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmalbaranes
#Region "Código generado por el Diseñador de Windows Forms "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
        iniciando = True
        'Llamada necesaria para el Diseñador de Windows Forms.
		InitializeComponent()
        
	End Sub
	'Form invalida a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents horaAlbaran As System.Windows.Forms.MaskedTextBox
    Public WithEvents Frame4 As System.Windows.Forms.GroupBox
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public printDialogPrint As System.Windows.Forms.PrintDialog
    Public WithEvents _SSTab1_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents cmbTanques As System.Windows.Forms.ComboBox
    Public WithEvents Label20 As System.Windows.Forms.Label
	Public WithEvents _SSTab1_TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents _SSTab1_TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents _SSTab1_TabPage3 As System.Windows.Forms.TabPage
	Public WithEvents SSTab1 As System.Windows.Forms.TabControl
    Public WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Public WithEvents btnEditar As System.Windows.Forms.ToolStripButton
    Public WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Public WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Public WithEvents btnBorrar As System.Windows.Forms.ToolStripButton
    Public WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Public WithEvents btnCerrar As System.Windows.Forms.ToolStripButton
    Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip

    Public WithEvents fechaAlbaran As System.Windows.Forms.DateTimePicker
    Public WithEvents lblidalbaran As System.Windows.Forms.Label
    Public WithEvents lblnumalbaran As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.horaAlbaran = New System.Windows.Forms.MaskedTextBox()
        Me.Frame4 = New System.Windows.Forms.GroupBox()
        Me.cifclientetxt = New System.Windows.Forms.TextBox()
        Me.provclientetxt = New System.Windows.Forms.TextBox()
        Me.pobclientetxt = New System.Windows.Forms.TextBox()
        Me.cpclientetxt = New System.Windows.Forms.TextBox()
        Me.dirclientetxt = New System.Windows.Forms.TextBox()
        Me.nmclientetxt = New System.Windows.Forms.TextBox()
        Me.lblIdcliente = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.listaParAlbaran = New System.Windows.Forms.ListBox()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.dniconductortxt = New System.Windows.Forms.TextBox()
        Me.nmconductortxt = New System.Windows.Forms.TextBox()
        Me.lblIdconductor = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.netotxt = New System.Windows.Forms.TextBox()
        Me.brutotxt = New System.Windows.Forms.TextBox()
        Me.taratxt = New System.Windows.Forms.TextBox()
        Me.matriculatxt = New System.Windows.Forms.TextBox()
        Me.lblIdVehiculo = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.printDialogPrint = New System.Windows.Forms.PrintDialog()
        Me.SSTab1 = New System.Windows.Forms.TabControl()
        Me._SSTab1_TabPage0 = New System.Windows.Forms.TabPage()
        Me.tablaAlbaranes = New System.Windows.Forms.DataGridView()
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.albaranesBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.OleosigDB1 = New Oleosig.oleosigDB()
        Me._SSTab1_TabPage1 = New System.Windows.Forms.TabPage()
        Me.tablaPartidas = New System.Windows.Forms.DataGridView()
        Me.NumeroDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KilosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.partidasBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbTanques = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me._SSTab1_TabPage2 = New System.Windows.Forms.TabPage()
        Me.tablaClientes = New System.Windows.Forms.DataGridView()
        Me.clientesBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me._SSTab1_TabPage3 = New System.Windows.Forms.TabPage()
        Me.tablaconductores = New System.Windows.Forms.DataGridView()
        Me.conductoresBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.tablaVehiculos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vehiculosBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.Toolbar1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnBorrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCerrar = New System.Windows.Forms.ToolStripButton()
        Me.fechaAlbaran = New System.Windows.Forms.DateTimePicker()
        Me.lblidalbaran = New System.Windows.Forms.Label()
        Me.lblnumalbaran = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumeroDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CifDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvinciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Frame4.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.SSTab1.SuspendLayout()
        Me._SSTab1_TabPage0.SuspendLayout()
        CType(Me.tablaAlbaranes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.albaranesBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._SSTab1_TabPage1.SuspendLayout()
        CType(Me.tablaPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.partidasBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._SSTab1_TabPage2.SuspendLayout()
        CType(Me.tablaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clientesBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._SSTab1_TabPage3.SuspendLayout()
        CType(Me.tablaconductores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.conductoresBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablaVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vehiculosBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Toolbar1.SuspendLayout()
        Me.SuspendLayout()
        '
        'horaAlbaran
        '
        Me.horaAlbaran.AllowPromptAsInput = False
        Me.horaAlbaran.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horaAlbaran.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.horaAlbaran.Location = New System.Drawing.Point(370, 64)
        Me.horaAlbaran.Mask = "00:00"
        Me.horaAlbaran.Name = "horaAlbaran"
        Me.horaAlbaran.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.horaAlbaran.Size = New System.Drawing.Size(51, 21)
        Me.horaAlbaran.TabIndex = 3
        Me.horaAlbaran.ValidatingType = GetType(Date)
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.SystemColors.Control
        Me.Frame4.Controls.Add(Me.cifclientetxt)
        Me.Frame4.Controls.Add(Me.provclientetxt)
        Me.Frame4.Controls.Add(Me.pobclientetxt)
        Me.Frame4.Controls.Add(Me.cpclientetxt)
        Me.Frame4.Controls.Add(Me.dirclientetxt)
        Me.Frame4.Controls.Add(Me.nmclientetxt)
        Me.Frame4.Controls.Add(Me.lblIdcliente)
        Me.Frame4.Controls.Add(Me.Label7)
        Me.Frame4.Controls.Add(Me.Label13)
        Me.Frame4.Controls.Add(Me.Label12)
        Me.Frame4.Controls.Add(Me.Label11)
        Me.Frame4.Controls.Add(Me.Label10)
        Me.Frame4.Controls.Add(Me.Label9)
        Me.Frame4.Controls.Add(Me.Label8)
        Me.Frame4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Frame4.Location = New System.Drawing.Point(4, 94)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(370, 199)
        Me.Frame4.TabIndex = 41
        Me.Frame4.TabStop = False
        Me.Frame4.Text = "Cliente"
        '
        'cifclientetxt
        '
        Me.cifclientetxt.AcceptsReturn = True
        Me.cifclientetxt.BackColor = System.Drawing.SystemColors.Window
        Me.cifclientetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cifclientetxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cifclientetxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cifclientetxt.Location = New System.Drawing.Point(278, 146)
        Me.cifclientetxt.MaxLength = 0
        Me.cifclientetxt.Name = "cifclientetxt"
        Me.cifclientetxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cifclientetxt.Size = New System.Drawing.Size(79, 22)
        Me.cifclientetxt.TabIndex = 56
        Me.cifclientetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'provclientetxt
        '
        Me.provclientetxt.AcceptsReturn = True
        Me.provclientetxt.BackColor = System.Drawing.SystemColors.Window
        Me.provclientetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.provclientetxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.provclientetxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.provclientetxt.Location = New System.Drawing.Point(78, 146)
        Me.provclientetxt.MaxLength = 0
        Me.provclientetxt.Name = "provclientetxt"
        Me.provclientetxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.provclientetxt.Size = New System.Drawing.Size(81, 22)
        Me.provclientetxt.TabIndex = 55
        Me.provclientetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pobclientetxt
        '
        Me.pobclientetxt.AcceptsReturn = True
        Me.pobclientetxt.BackColor = System.Drawing.SystemColors.Window
        Me.pobclientetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pobclientetxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pobclientetxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pobclientetxt.Location = New System.Drawing.Point(189, 117)
        Me.pobclientetxt.MaxLength = 0
        Me.pobclientetxt.Name = "pobclientetxt"
        Me.pobclientetxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pobclientetxt.Size = New System.Drawing.Size(168, 22)
        Me.pobclientetxt.TabIndex = 54
        Me.pobclientetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cpclientetxt
        '
        Me.cpclientetxt.AcceptsReturn = True
        Me.cpclientetxt.BackColor = System.Drawing.SystemColors.Window
        Me.cpclientetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cpclientetxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpclientetxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cpclientetxt.Location = New System.Drawing.Point(78, 117)
        Me.cpclientetxt.MaxLength = 0
        Me.cpclientetxt.Name = "cpclientetxt"
        Me.cpclientetxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cpclientetxt.Size = New System.Drawing.Size(41, 22)
        Me.cpclientetxt.TabIndex = 53
        Me.cpclientetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dirclientetxt
        '
        Me.dirclientetxt.AcceptsReturn = True
        Me.dirclientetxt.BackColor = System.Drawing.SystemColors.Window
        Me.dirclientetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dirclientetxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dirclientetxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dirclientetxt.Location = New System.Drawing.Point(78, 88)
        Me.dirclientetxt.MaxLength = 0
        Me.dirclientetxt.Name = "dirclientetxt"
        Me.dirclientetxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dirclientetxt.Size = New System.Drawing.Size(279, 22)
        Me.dirclientetxt.TabIndex = 52
        Me.dirclientetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nmclientetxt
        '
        Me.nmclientetxt.AcceptsReturn = True
        Me.nmclientetxt.BackColor = System.Drawing.SystemColors.Window
        Me.nmclientetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nmclientetxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nmclientetxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.nmclientetxt.Location = New System.Drawing.Point(78, 60)
        Me.nmclientetxt.MaxLength = 0
        Me.nmclientetxt.Name = "nmclientetxt"
        Me.nmclientetxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nmclientetxt.Size = New System.Drawing.Size(279, 22)
        Me.nmclientetxt.TabIndex = 51
        Me.nmclientetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblIdcliente
        '
        Me.lblIdcliente.BackColor = System.Drawing.SystemColors.Window
        Me.lblIdcliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIdcliente.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblIdcliente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdcliente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIdcliente.Location = New System.Drawing.Point(78, 31)
        Me.lblIdcliente.Name = "lblIdcliente"
        Me.lblIdcliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblIdcliente.Size = New System.Drawing.Size(63, 24)
        Me.lblIdcliente.TabIndex = 50
        Me.lblIdcliente.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(14, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(58, 15)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Numero :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(14, 151)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(63, 15)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "Provincia :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(130, 121)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(68, 15)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "Población :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(14, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(36, 15)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "C.P. :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(14, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(65, 15)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Dirección :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(219, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(37, 15)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "C.i.f. :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(14, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(58, 15)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Nombre :"
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.listaParAlbaran)
        Me.Frame3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Frame3.Location = New System.Drawing.Point(755, 94)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(128, 199)
        Me.Frame3.TabIndex = 39
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "Partidas de Aceite"
        '
        'listaParAlbaran
        '
        Me.listaParAlbaran.FormattingEnabled = True
        Me.listaParAlbaran.ItemHeight = 14
        Me.listaParAlbaran.Location = New System.Drawing.Point(16, 23)
        Me.listaParAlbaran.Name = "listaParAlbaran"
        Me.listaParAlbaran.Size = New System.Drawing.Size(94, 158)
        Me.listaParAlbaran.TabIndex = 0
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.dniconductortxt)
        Me.Frame2.Controls.Add(Me.nmconductortxt)
        Me.Frame2.Controls.Add(Me.lblIdconductor)
        Me.Frame2.Controls.Add(Me.Label14)
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.Controls.Add(Me.Label1)
        Me.Frame2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Frame2.Location = New System.Drawing.Point(381, 94)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(369, 111)
        Me.Frame2.TabIndex = 35
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Conductor"
        '
        'dniconductortxt
        '
        Me.dniconductortxt.AcceptsReturn = True
        Me.dniconductortxt.BackColor = System.Drawing.SystemColors.Window
        Me.dniconductortxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dniconductortxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dniconductortxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dniconductortxt.Location = New System.Drawing.Point(76, 73)
        Me.dniconductortxt.MaxLength = 0
        Me.dniconductortxt.Name = "dniconductortxt"
        Me.dniconductortxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dniconductortxt.Size = New System.Drawing.Size(81, 22)
        Me.dniconductortxt.TabIndex = 53
        Me.dniconductortxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nmconductortxt
        '
        Me.nmconductortxt.AcceptsReturn = True
        Me.nmconductortxt.BackColor = System.Drawing.SystemColors.Window
        Me.nmconductortxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nmconductortxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nmconductortxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.nmconductortxt.Location = New System.Drawing.Point(76, 45)
        Me.nmconductortxt.MaxLength = 0
        Me.nmconductortxt.Name = "nmconductortxt"
        Me.nmconductortxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nmconductortxt.Size = New System.Drawing.Size(279, 22)
        Me.nmconductortxt.TabIndex = 52
        Me.nmconductortxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblIdconductor
        '
        Me.lblIdconductor.BackColor = System.Drawing.SystemColors.Window
        Me.lblIdconductor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIdconductor.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblIdconductor.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdconductor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIdconductor.Location = New System.Drawing.Point(76, 16)
        Me.lblIdconductor.Name = "lblIdconductor"
        Me.lblIdconductor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblIdconductor.Size = New System.Drawing.Size(81, 24)
        Me.lblIdconductor.TabIndex = 51
        Me.lblIdconductor.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(16, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(23, 15)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Id :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(14, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(34, 15)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "DNI :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(14, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Nombre :"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.netotxt)
        Me.Frame1.Controls.Add(Me.brutotxt)
        Me.Frame1.Controls.Add(Me.taratxt)
        Me.Frame1.Controls.Add(Me.matriculatxt)
        Me.Frame1.Controls.Add(Me.lblIdVehiculo)
        Me.Frame1.Controls.Add(Me.Label18)
        Me.Frame1.Controls.Add(Me.Label17)
        Me.Frame1.Controls.Add(Me.Label16)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Frame1.Location = New System.Drawing.Point(381, 210)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(369, 83)
        Me.Frame1.TabIndex = 29
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Vehiculo"
        '
        'netotxt
        '
        Me.netotxt.AcceptsReturn = True
        Me.netotxt.BackColor = System.Drawing.SystemColors.Window
        Me.netotxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.netotxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.netotxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.netotxt.Location = New System.Drawing.Point(288, 44)
        Me.netotxt.MaxLength = 0
        Me.netotxt.Name = "netotxt"
        Me.netotxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.netotxt.Size = New System.Drawing.Size(60, 22)
        Me.netotxt.TabIndex = 56
        Me.netotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'brutotxt
        '
        Me.brutotxt.AcceptsReturn = True
        Me.brutotxt.BackColor = System.Drawing.SystemColors.Window
        Me.brutotxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.brutotxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brutotxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.brutotxt.Location = New System.Drawing.Point(81, 44)
        Me.brutotxt.MaxLength = 0
        Me.brutotxt.Name = "brutotxt"
        Me.brutotxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.brutotxt.Size = New System.Drawing.Size(60, 22)
        Me.brutotxt.TabIndex = 54
        Me.brutotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'taratxt
        '
        Me.taratxt.AcceptsReturn = True
        Me.taratxt.BackColor = System.Drawing.SystemColors.Window
        Me.taratxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.taratxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taratxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.taratxt.Location = New System.Drawing.Point(188, 44)
        Me.taratxt.MaxLength = 0
        Me.taratxt.Name = "taratxt"
        Me.taratxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.taratxt.Size = New System.Drawing.Size(60, 22)
        Me.taratxt.TabIndex = 55
        Me.taratxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'matriculatxt
        '
        Me.matriculatxt.AcceptsReturn = True
        Me.matriculatxt.BackColor = System.Drawing.SystemColors.Window
        Me.matriculatxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.matriculatxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matriculatxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.matriculatxt.Location = New System.Drawing.Point(267, 16)
        Me.matriculatxt.MaxLength = 0
        Me.matriculatxt.Name = "matriculatxt"
        Me.matriculatxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.matriculatxt.Size = New System.Drawing.Size(81, 22)
        Me.matriculatxt.TabIndex = 53
        Me.matriculatxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblIdVehiculo
        '
        Me.lblIdVehiculo.BackColor = System.Drawing.SystemColors.Window
        Me.lblIdVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIdVehiculo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblIdVehiculo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdVehiculo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIdVehiculo.Location = New System.Drawing.Point(81, 16)
        Me.lblIdVehiculo.Name = "lblIdVehiculo"
        Me.lblIdVehiculo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblIdVehiculo.Size = New System.Drawing.Size(81, 24)
        Me.lblIdVehiculo.TabIndex = 52
        Me.lblIdVehiculo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(21, 21)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(23, 15)
        Me.Label18.TabIndex = 61
        Me.Label18.Text = "Id :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(251, 49)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(39, 15)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = "Neto :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(21, 49)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(42, 15)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = "Bruto :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(154, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(38, 15)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Tara :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(201, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Matrícula :"
        '
        'SSTab1
        '
        Me.SSTab1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage0)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage1)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage2)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage3)
        Me.SSTab1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSTab1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SSTab1.ItemSize = New System.Drawing.Size(42, 18)
        Me.SSTab1.Location = New System.Drawing.Point(8, 296)
        Me.SSTab1.Name = "SSTab1"
        Me.SSTab1.SelectedIndex = 0
        Me.SSTab1.Size = New System.Drawing.Size(578, 247)
        Me.SSTab1.TabIndex = 28
        '
        '_SSTab1_TabPage0
        '
        Me._SSTab1_TabPage0.Controls.Add(Me.tablaAlbaranes)
        Me._SSTab1_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage0.Name = "_SSTab1_TabPage0"
        Me._SSTab1_TabPage0.Size = New System.Drawing.Size(570, 221)
        Me._SSTab1_TabPage0.TabIndex = 0
        Me._SSTab1_TabPage0.Text = "Albaranes"
        '
        'tablaAlbaranes
        '
        Me.tablaAlbaranes.AllowUserToAddRows = False
        Me.tablaAlbaranes.AllowUserToDeleteRows = False
        Me.tablaAlbaranes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tablaAlbaranes.AutoGenerateColumns = False
        Me.tablaAlbaranes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.tablaAlbaranes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaAlbaranes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn})
        Me.tablaAlbaranes.DataSource = Me.albaranesBDS
        Me.tablaAlbaranes.Location = New System.Drawing.Point(9, 14)
        Me.tablaAlbaranes.MultiSelect = False
        Me.tablaAlbaranes.Name = "tablaAlbaranes"
        Me.tablaAlbaranes.ReadOnly = True
        Me.tablaAlbaranes.RowHeadersVisible = False
        Me.tablaAlbaranes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.tablaAlbaranes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tablaAlbaranes.Size = New System.Drawing.Size(552, 194)
        Me.tablaAlbaranes.TabIndex = 0
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        Me.NumeroDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroDataGridViewTextBoxColumn.Width = 69
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 62
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClienteDataGridViewTextBoxColumn.Width = 64
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoDataGridViewTextBoxColumn.Width = 52
        '
        'albaranesBDS
        '
        Me.albaranesBDS.DataMember = "albaranes"
        Me.albaranesBDS.DataSource = Me.OleosigDB1
        '
        'OleosigDB1
        '
        Me.OleosigDB1.DataSetName = "oleosigDB"
        Me.OleosigDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_SSTab1_TabPage1
        '
        Me._SSTab1_TabPage1.Controls.Add(Me.tablaPartidas)
        Me._SSTab1_TabPage1.Controls.Add(Me.cmbTanques)
        Me._SSTab1_TabPage1.Controls.Add(Me.Label20)
        Me._SSTab1_TabPage1.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage1.Name = "_SSTab1_TabPage1"
        Me._SSTab1_TabPage1.Size = New System.Drawing.Size(570, 221)
        Me._SSTab1_TabPage1.TabIndex = 1
        Me._SSTab1_TabPage1.Text = "Partidas"
        '
        'tablaPartidas
        '
        Me.tablaPartidas.AllowUserToAddRows = False
        Me.tablaPartidas.AllowUserToDeleteRows = False
        Me.tablaPartidas.AutoGenerateColumns = False
        Me.tablaPartidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.tablaPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaPartidas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDataGridViewTextBoxColumn2, Me.FechaDataGridViewTextBoxColumn1, Me.TipoDataGridViewTextBoxColumn1, Me.KilosDataGridViewTextBoxColumn})
        Me.tablaPartidas.DataSource = Me.partidasBDS
        Me.tablaPartidas.Location = New System.Drawing.Point(9, 12)
        Me.tablaPartidas.MultiSelect = False
        Me.tablaPartidas.Name = "tablaPartidas"
        Me.tablaPartidas.ReadOnly = True
        Me.tablaPartidas.RowHeadersVisible = False
        Me.tablaPartidas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.tablaPartidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tablaPartidas.Size = New System.Drawing.Size(372, 198)
        Me.tablaPartidas.TabIndex = 54
        '
        'NumeroDataGridViewTextBoxColumn2
        '
        Me.NumeroDataGridViewTextBoxColumn2.DataPropertyName = "Numero"
        Me.NumeroDataGridViewTextBoxColumn2.HeaderText = "Numero"
        Me.NumeroDataGridViewTextBoxColumn2.Name = "NumeroDataGridViewTextBoxColumn2"
        Me.NumeroDataGridViewTextBoxColumn2.ReadOnly = True
        Me.NumeroDataGridViewTextBoxColumn2.Width = 69
        '
        'FechaDataGridViewTextBoxColumn1
        '
        Me.FechaDataGridViewTextBoxColumn1.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn1.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn1.Name = "FechaDataGridViewTextBoxColumn1"
        Me.FechaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn1.Width = 62
        '
        'TipoDataGridViewTextBoxColumn1
        '
        Me.TipoDataGridViewTextBoxColumn1.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn1.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn1.Name = "TipoDataGridViewTextBoxColumn1"
        Me.TipoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.TipoDataGridViewTextBoxColumn1.Width = 52
        '
        'KilosDataGridViewTextBoxColumn
        '
        Me.KilosDataGridViewTextBoxColumn.DataPropertyName = "Kilos"
        Me.KilosDataGridViewTextBoxColumn.HeaderText = "Kilos"
        Me.KilosDataGridViewTextBoxColumn.Name = "KilosDataGridViewTextBoxColumn"
        Me.KilosDataGridViewTextBoxColumn.ReadOnly = True
        Me.KilosDataGridViewTextBoxColumn.Width = 55
        '
        'partidasBDS
        '
        Me.partidasBDS.DataMember = "partidasaceite"
        Me.partidasBDS.DataSource = Me.OleosigDB1
        '
        'cmbTanques
        '
        Me.cmbTanques.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTanques.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbTanques.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTanques.Location = New System.Drawing.Point(474, 39)
        Me.cmbTanques.Name = "cmbTanques"
        Me.cmbTanques.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTanques.Size = New System.Drawing.Size(81, 22)
        Me.cmbTanques.TabIndex = 52
        Me.cmbTanques.Text = "Combo1"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(387, 44)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(55, 14)
        Me.Label20.TabIndex = 53
        Me.Label20.Text = "Deposito :"
        '
        '_SSTab1_TabPage2
        '
        Me._SSTab1_TabPage2.Controls.Add(Me.tablaClientes)
        Me._SSTab1_TabPage2.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage2.Name = "_SSTab1_TabPage2"
        Me._SSTab1_TabPage2.Size = New System.Drawing.Size(570, 221)
        Me._SSTab1_TabPage2.TabIndex = 2
        Me._SSTab1_TabPage2.Text = "Clientes"
        '
        'tablaClientes
        '
        Me.tablaClientes.AllowUserToAddRows = False
        Me.tablaClientes.AllowUserToDeleteRows = False
        Me.tablaClientes.AutoGenerateColumns = False
        Me.tablaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.tablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDataGridViewTextBoxColumn1, Me.NombreDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.CifDataGridViewTextBoxColumn, Me.LocalidadDataGridViewTextBoxColumn, Me.ProvinciaDataGridViewTextBoxColumn})
        Me.tablaClientes.DataSource = Me.clientesBDS
        Me.tablaClientes.Location = New System.Drawing.Point(9, 16)
        Me.tablaClientes.MultiSelect = False
        Me.tablaClientes.Name = "tablaClientes"
        Me.tablaClientes.ReadOnly = True
        Me.tablaClientes.RowHeadersVisible = False
        Me.tablaClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.tablaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tablaClientes.Size = New System.Drawing.Size(551, 188)
        Me.tablaClientes.TabIndex = 0
        '
        'clientesBDS
        '
        Me.clientesBDS.DataMember = "clientes"
        Me.clientesBDS.DataSource = Me.OleosigDB1
        '
        '_SSTab1_TabPage3
        '
        Me._SSTab1_TabPage3.Controls.Add(Me.tablaconductores)
        Me._SSTab1_TabPage3.Controls.Add(Me.tablaVehiculos)
        Me._SSTab1_TabPage3.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage3.Name = "_SSTab1_TabPage3"
        Me._SSTab1_TabPage3.Size = New System.Drawing.Size(570, 221)
        Me._SSTab1_TabPage3.TabIndex = 3
        Me._SSTab1_TabPage3.Text = "Transporte"
        '
        'tablaconductores
        '
        Me.tablaconductores.AllowUserToAddRows = False
        Me.tablaconductores.AllowUserToDeleteRows = False
        Me.tablaconductores.AutoGenerateColumns = False
        Me.tablaconductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaconductores.DataSource = Me.conductoresBDS
        Me.tablaconductores.Location = New System.Drawing.Point(173, 20)
        Me.tablaconductores.Name = "tablaconductores"
        Me.tablaconductores.ReadOnly = True
        Me.tablaconductores.Size = New System.Drawing.Size(387, 140)
        Me.tablaconductores.TabIndex = 25
        '
        'tablaVehiculos
        '
        Me.tablaVehiculos.AllowUserToAddRows = False
        Me.tablaVehiculos.AllowUserToDeleteRows = False
        Me.tablaVehiculos.AutoGenerateColumns = False
        Me.tablaVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaVehiculos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.tablaVehiculos.DataSource = Me.vehiculosBDS
        Me.tablaVehiculos.Location = New System.Drawing.Point(9, 20)
        Me.tablaVehiculos.MultiSelect = False
        Me.tablaVehiculos.Name = "tablaVehiculos"
        Me.tablaVehiculos.ReadOnly = True
        Me.tablaVehiculos.RowHeadersVisible = False
        Me.tablaVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tablaVehiculos.Size = New System.Drawing.Size(124, 140)
        Me.tablaVehiculos.TabIndex = 24
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "matricula"
        Me.Column1.HeaderText = "Matriculas"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Toolbar1
        '
        Me.Toolbar1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Toolbar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnEditar, Me.btnCancelar, Me.ToolStripSeparator1, Me.btnImprimir, Me.ToolStripSeparator2, Me.btnBorrar, Me.ToolStripSeparator3, Me.btnGuardar, Me.ToolStripSeparator4, Me.btnCerrar})
        Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar1.Name = "Toolbar1"
        Me.Toolbar1.Size = New System.Drawing.Size(1059, 48)
        Me.Toolbar1.TabIndex = 27
        '
        'btnNuevo
        '
        Me.btnNuevo.AutoSize = False
        Me.btnNuevo.Image = Global.Oleosig.My.Resources.Resources.document_new
        Me.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(50, 45)
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnEditar
        '
        Me.btnEditar.AutoSize = False
        Me.btnEditar.Image = Global.Oleosig.My.Resources.Resources.document_properties
        Me.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(50, 45)
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnCancelar
        '
        Me.btnCancelar.AutoSize = False
        Me.btnCancelar.Image = Global.Oleosig.My.Resources.Resources.edit_undo
        Me.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(50, 45)
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 48)
        '
        'btnImprimir
        '
        Me.btnImprimir.AutoSize = False
        Me.btnImprimir.Image = Global.Oleosig.My.Resources.Resources.printer
        Me.btnImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(50, 45)
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 48)
        '
        'btnBorrar
        '
        Me.btnBorrar.AutoSize = False
        Me.btnBorrar.Image = Global.Oleosig.My.Resources.Resources.edittrash
        Me.btnBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(50, 45)
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 48)
        '
        'btnGuardar
        '
        Me.btnGuardar.AutoSize = False
        Me.btnGuardar.Image = Global.Oleosig.My.Resources.Resources.document_save
        Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(50, 45)
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 48)
        '
        'btnCerrar
        '
        Me.btnCerrar.AutoSize = False
        Me.btnCerrar.Image = Global.Oleosig.My.Resources.Resources.dialog_close
        Me.btnCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(50, 45)
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'fechaAlbaran
        '
        Me.fechaAlbaran.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaAlbaran.Location = New System.Drawing.Point(265, 64)
        Me.fechaAlbaran.Name = "fechaAlbaran"
        Me.fechaAlbaran.Size = New System.Drawing.Size(96, 20)
        Me.fechaAlbaran.TabIndex = 1
        '
        'lblidalbaran
        '
        Me.lblidalbaran.BackColor = System.Drawing.SystemColors.Control
        Me.lblidalbaran.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblidalbaran.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblidalbaran.Location = New System.Drawing.Point(464, 64)
        Me.lblidalbaran.Name = "lblidalbaran"
        Me.lblidalbaran.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblidalbaran.Size = New System.Drawing.Size(73, 17)
        Me.lblidalbaran.TabIndex = 54
        Me.lblidalbaran.Visible = False
        '
        'lblnumalbaran
        '
        Me.lblnumalbaran.BackColor = System.Drawing.SystemColors.Window
        Me.lblnumalbaran.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblnumalbaran.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblnumalbaran.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumalbaran.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblnumalbaran.Location = New System.Drawing.Point(152, 65)
        Me.lblnumalbaran.Name = "lblnumalbaran"
        Me.lblnumalbaran.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnumalbaran.Size = New System.Drawing.Size(57, 21)
        Me.lblnumalbaran.TabIndex = 0
        Me.lblnumalbaran.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(217, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Fecha :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(11, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(125, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Numero de albarán :"
        '
        'NumeroDataGridViewTextBoxColumn1
        '
        Me.NumeroDataGridViewTextBoxColumn1.DataPropertyName = "Numero"
        Me.NumeroDataGridViewTextBoxColumn1.HeaderText = "Numero"
        Me.NumeroDataGridViewTextBoxColumn1.Name = "NumeroDataGridViewTextBoxColumn1"
        Me.NumeroDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NumeroDataGridViewTextBoxColumn1.Width = 69
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 69
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelefonoDataGridViewTextBoxColumn.Width = 74
        '
        'CifDataGridViewTextBoxColumn
        '
        Me.CifDataGridViewTextBoxColumn.DataPropertyName = "Cif"
        Me.CifDataGridViewTextBoxColumn.HeaderText = "Cif"
        Me.CifDataGridViewTextBoxColumn.Name = "CifDataGridViewTextBoxColumn"
        Me.CifDataGridViewTextBoxColumn.ReadOnly = True
        Me.CifDataGridViewTextBoxColumn.Width = 45
        '
        'LocalidadDataGridViewTextBoxColumn
        '
        Me.LocalidadDataGridViewTextBoxColumn.DataPropertyName = "Localidad"
        Me.LocalidadDataGridViewTextBoxColumn.HeaderText = "Localidad"
        Me.LocalidadDataGridViewTextBoxColumn.Name = "LocalidadDataGridViewTextBoxColumn"
        Me.LocalidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.LocalidadDataGridViewTextBoxColumn.Width = 78
        '
        'ProvinciaDataGridViewTextBoxColumn
        '
        Me.ProvinciaDataGridViewTextBoxColumn.DataPropertyName = "Provincia"
        Me.ProvinciaDataGridViewTextBoxColumn.HeaderText = "Provincia"
        Me.ProvinciaDataGridViewTextBoxColumn.Name = "ProvinciaDataGridViewTextBoxColumn"
        Me.ProvinciaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProvinciaDataGridViewTextBoxColumn.Width = 76
        '
        'frmalbaranes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1059, 578)
        Me.Controls.Add(Me.horaAlbaran)
        Me.Controls.Add(Me.Frame4)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.SSTab1)
        Me.Controls.Add(Me.Toolbar1)
        Me.Controls.Add(Me.fechaAlbaran)
        Me.Controls.Add(Me.lblidalbaran)
        Me.Controls.Add(Me.lblnumalbaran)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmalbaranes"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Albaranes de Salida a granel"
        Me.Frame4.ResumeLayout(False)
        Me.Frame4.PerformLayout()
        Me.Frame3.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.SSTab1.ResumeLayout(False)
        Me._SSTab1_TabPage0.ResumeLayout(False)
        CType(Me.tablaAlbaranes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.albaranesBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me._SSTab1_TabPage1.ResumeLayout(False)
        Me._SSTab1_TabPage1.PerformLayout()
        CType(Me.tablaPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.partidasBDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me._SSTab1_TabPage2.ResumeLayout(False)
        CType(Me.tablaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clientesBDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me._SSTab1_TabPage3.ResumeLayout(False)
        CType(Me.tablaconductores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.conductoresBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablaVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vehiculosBDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Toolbar1.ResumeLayout(False)
        Me.Toolbar1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents cifclientetxt As System.Windows.Forms.TextBox
    Public WithEvents provclientetxt As System.Windows.Forms.TextBox
    Public WithEvents pobclientetxt As System.Windows.Forms.TextBox
    Public WithEvents cpclientetxt As System.Windows.Forms.TextBox
    Public WithEvents dirclientetxt As System.Windows.Forms.TextBox
    Public WithEvents nmclientetxt As System.Windows.Forms.TextBox
    Public WithEvents lblIdcliente As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents dniconductortxt As System.Windows.Forms.TextBox
    Public WithEvents nmconductortxt As System.Windows.Forms.TextBox
    Public WithEvents lblIdconductor As System.Windows.Forms.Label
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents netotxt As System.Windows.Forms.TextBox
    Public WithEvents brutotxt As System.Windows.Forms.TextBox
    Public WithEvents taratxt As System.Windows.Forms.TextBox
    Public WithEvents matriculatxt As System.Windows.Forms.TextBox
    Public WithEvents lblIdVehiculo As System.Windows.Forms.Label
    Public WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator

    Friend WithEvents listaParAlbaran As System.Windows.Forms.ListBox
    Friend WithEvents tablaVehiculos As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vehiculosBDS As System.Windows.Forms.BindingSource
    Friend WithEvents tablaClientes As System.Windows.Forms.DataGridView
    Friend WithEvents clientesBDS As System.Windows.Forms.BindingSource
    Friend WithEvents tablaconductores As System.Windows.Forms.DataGridView
    Friend WithEvents conductoresBDS As System.Windows.Forms.BindingSource
    Friend WithEvents partidasBDS As System.Windows.Forms.BindingSource
    Friend WithEvents albaranesBDS As System.Windows.Forms.BindingSource
    Friend WithEvents tablaPartidas As System.Windows.Forms.DataGridView
    Friend WithEvents OleosigDB1 As Oleosig.oleosigDB
    Friend WithEvents tablaAlbaranes As System.Windows.Forms.DataGridView
    Friend WithEvents NumeroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CifDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocalidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvinciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region 
End Class