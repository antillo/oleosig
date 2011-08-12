<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdLotAceite
    Inherits System.Windows.Forms.Form


    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()
        iniciando = True
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        oLoteAc = New loteAceiteTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        oMov = New opbodegaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)

        tanquesDB = New depositosTableAdapter(Almazara.Id)

        detalleslotesDB = New detallesLoteAceiteTableAdapter(Almazara.Id, Almazara.CampañaAct.clave)
        detallesOpbdgDB = New detallesOpBdgTableAdapter(Almazara.Id, Almazara.CampañaAct.clave)

        iniciando = False
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
        Me.Toolbar1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnBorrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCerrar = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtfechafin = New System.Windows.Forms.DateTimePicker()
        Me.dtfechaini = New System.Windows.Forms.DateTimePicker()
        Me.chkAbierto = New System.Windows.Forms.CheckBox()
        Me.LotesBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.OleosigDB1 = New Oleosig.oleosigDB()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lotetxt = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.kilostxt = New System.Windows.Forms.TextBox()
        Me.cmbtanques = New System.Windows.Forms.ComboBox()
        Me.tanquesBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.entradasac = New System.Windows.Forms.DataGridView()
        Me.OperacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaInicialDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFinalDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanqueDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.opbodegaBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.tablalotes = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaInicialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanqueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tabladetalles = New System.Windows.Forms.DataGridView()
        Me.LoteaceiteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpbodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detallesBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.bkworker1 = New System.ComponentModel.BackgroundWorker()
        Me.Toolbar1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.LotesBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tanquesBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.entradasac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.opbodegaBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablalotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.tabladetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.detallesBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Toolbar1
        '
        Me.Toolbar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnEditar, Me.ToolStripSeparator1, Me.btnCancel, Me.ToolStripSeparator2, Me.btnBorrar, Me.ToolStripSeparator3, Me.btnGuardar, Me.ToolStripSeparator4, Me.btnCerrar})
        Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar1.Name = "Toolbar1"
        Me.Toolbar1.Size = New System.Drawing.Size(794, 48)
        Me.Toolbar1.TabIndex = 0
        Me.Toolbar1.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.AutoSize = False
        Me.btnNuevo.Image = Global.Oleosig.My.Resources.Resources.document_new
        Me.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(60, 45)
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnEditar
        '
        Me.btnEditar.AutoSize = False
        Me.btnEditar.Image = Global.Oleosig.My.Resources.Resources.document_properties
        Me.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(60, 45)
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 48)
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = False
        Me.btnCancel.Image = Global.Oleosig.My.Resources.Resources.edit_undo
        Me.btnCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(60, 45)
        Me.btnCancel.Text = "Deshacer"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.btnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(60, 45)
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
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(60, 45)
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
        Me.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(60, 45)
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.entradasac, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tablalotes, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 48)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(794, 443)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dtfechafin)
        Me.Panel1.Controls.Add(Me.dtfechaini)
        Me.Panel1.Controls.Add(Me.chkAbierto)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lotetxt)
        Me.Panel1.Controls.Add(Me.lblId)
        Me.Panel1.Controls.Add(Me.kilostxt)
        Me.Panel1.Controls.Add(Me.cmbtanques)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(391, 201)
        Me.Panel1.TabIndex = 0
        '
        'dtfechafin
        '
        Me.dtfechafin.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfechafin.Location = New System.Drawing.Point(130, 121)
        Me.dtfechafin.Name = "dtfechafin"
        Me.dtfechafin.ShowUpDown = True
        Me.dtfechafin.Size = New System.Drawing.Size(128, 22)
        Me.dtfechafin.TabIndex = 14
        '
        'dtfechaini
        '
        Me.dtfechaini.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtfechaini.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfechaini.Location = New System.Drawing.Point(130, 92)
        Me.dtfechaini.Name = "dtfechaini"
        Me.dtfechaini.ShowUpDown = True
        Me.dtfechaini.Size = New System.Drawing.Size(128, 22)
        Me.dtfechaini.TabIndex = 13
        '
        'chkAbierto
        '
        Me.chkAbierto.AutoSize = True
        Me.chkAbierto.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.LotesBDS, "Abierto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkAbierto.Location = New System.Drawing.Point(249, 156)
        Me.chkAbierto.Name = "chkAbierto"
        Me.chkAbierto.Size = New System.Drawing.Size(68, 20)
        Me.chkAbierto.TabIndex = 12
        Me.chkAbierto.Text = "Abierto"
        Me.chkAbierto.UseVisualStyleBackColor = True
        '
        'LotesBDS
        '
        Me.LotesBDS.DataMember = "loteaceite"
        Me.LotesBDS.DataSource = Me.OleosigDB1
        '
        'OleosigDB1
        '
        Me.OleosigDB1.DataSetName = "oleosigDB"
        Me.OleosigDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(83, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Lote :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Id :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Kilos :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Fecha fin :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = " Fecha ini :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Depósitos :"
        '
        'lotetxt
        '
        Me.lotetxt.Location = New System.Drawing.Point(130, 19)
        Me.lotetxt.Name = "lotetxt"
        Me.lotetxt.Size = New System.Drawing.Size(100, 22)
        Me.lotetxt.TabIndex = 5
        '
        'lblId
        '
        Me.lblId.BackColor = System.Drawing.SystemColors.Window
        Me.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblId.Location = New System.Drawing.Point(39, 19)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(41, 23)
        Me.lblId.TabIndex = 4
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'kilostxt
        '
        Me.kilostxt.Location = New System.Drawing.Point(130, 157)
        Me.kilostxt.Name = "kilostxt"
        Me.kilostxt.Size = New System.Drawing.Size(100, 22)
        Me.kilostxt.TabIndex = 3
        '
        'cmbtanques
        '
        Me.cmbtanques.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LotesBDS, "Tanque", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.cmbtanques.DataSource = Me.tanquesBDS
        Me.cmbtanques.DisplayMember = "Nombre"
        Me.cmbtanques.FormattingEnabled = True
        Me.cmbtanques.Location = New System.Drawing.Point(130, 53)
        Me.cmbtanques.Name = "cmbtanques"
        Me.cmbtanques.Size = New System.Drawing.Size(100, 24)
        Me.cmbtanques.TabIndex = 0
        Me.cmbtanques.ValueMember = "Numero"
        '
        'tanquesBDS
        '
        Me.tanquesBDS.DataMember = "tanques"
        Me.tanquesBDS.DataSource = Me.OleosigDB1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label7.Location = New System.Drawing.Point(3, 210)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 18)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Lotes"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label8.Location = New System.Drawing.Point(400, 210)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 18)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Entradas de aceite"
        '
        'entradasac
        '
        Me.entradasac.AllowUserToAddRows = False
        Me.entradasac.AllowUserToDeleteRows = False
        Me.entradasac.AutoGenerateColumns = False
        Me.entradasac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.entradasac.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.entradasac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.entradasac.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OperacionDataGridViewTextBoxColumn, Me.FechaInicialDataGridViewTextBoxColumn1, Me.FechaFinalDataGridViewTextBoxColumn1, Me.TanqueDataGridViewTextBoxColumn1})
        Me.entradasac.DataSource = Me.opbodegaBDS
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.entradasac.DefaultCellStyle = DataGridViewCellStyle2
        Me.entradasac.Dock = System.Windows.Forms.DockStyle.Fill
        Me.entradasac.Location = New System.Drawing.Point(400, 238)
        Me.entradasac.Name = "entradasac"
        Me.entradasac.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.entradasac.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.entradasac.RowHeadersVisible = False
        Me.entradasac.Size = New System.Drawing.Size(391, 202)
        Me.entradasac.TabIndex = 5
        '
        'OperacionDataGridViewTextBoxColumn
        '
        Me.OperacionDataGridViewTextBoxColumn.DataPropertyName = "Operacion"
        Me.OperacionDataGridViewTextBoxColumn.HeaderText = "Operacion"
        Me.OperacionDataGridViewTextBoxColumn.Name = "OperacionDataGridViewTextBoxColumn"
        Me.OperacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.OperacionDataGridViewTextBoxColumn.Width = 81
        '
        'FechaInicialDataGridViewTextBoxColumn1
        '
        Me.FechaInicialDataGridViewTextBoxColumn1.DataPropertyName = "FechaInicial"
        Me.FechaInicialDataGridViewTextBoxColumn1.HeaderText = "FechaInicial"
        Me.FechaInicialDataGridViewTextBoxColumn1.Name = "FechaInicialDataGridViewTextBoxColumn1"
        Me.FechaInicialDataGridViewTextBoxColumn1.ReadOnly = True
        Me.FechaInicialDataGridViewTextBoxColumn1.Width = 89
        '
        'FechaFinalDataGridViewTextBoxColumn1
        '
        Me.FechaFinalDataGridViewTextBoxColumn1.DataPropertyName = "FechaFinal"
        Me.FechaFinalDataGridViewTextBoxColumn1.HeaderText = "FechaFinal"
        Me.FechaFinalDataGridViewTextBoxColumn1.Name = "FechaFinalDataGridViewTextBoxColumn1"
        Me.FechaFinalDataGridViewTextBoxColumn1.ReadOnly = True
        Me.FechaFinalDataGridViewTextBoxColumn1.Width = 84
        '
        'TanqueDataGridViewTextBoxColumn1
        '
        Me.TanqueDataGridViewTextBoxColumn1.DataPropertyName = "Tanque"
        Me.TanqueDataGridViewTextBoxColumn1.DataSource = Me.tanquesBDS
        Me.TanqueDataGridViewTextBoxColumn1.DisplayMember = "Nombre"
        Me.TanqueDataGridViewTextBoxColumn1.HeaderText = "Depósito"
        Me.TanqueDataGridViewTextBoxColumn1.Name = "TanqueDataGridViewTextBoxColumn1"
        Me.TanqueDataGridViewTextBoxColumn1.ReadOnly = True
        Me.TanqueDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TanqueDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.TanqueDataGridViewTextBoxColumn1.ValueMember = "Numero"
        Me.TanqueDataGridViewTextBoxColumn1.Width = 74
        '
        'opbodegaBDS
        '
        Me.opbodegaBDS.DataMember = "opbodega"
        Me.opbodegaBDS.DataSource = Me.OleosigDB1
        '
        'tablalotes
        '
        Me.tablalotes.AllowUserToAddRows = False
        Me.tablalotes.AllowUserToDeleteRows = False
        Me.tablalotes.AllowUserToResizeColumns = False
        Me.tablalotes.AllowUserToResizeRows = False
        Me.tablalotes.AutoGenerateColumns = False
        Me.tablalotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablalotes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.tablalotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablalotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.FechaInicialDataGridViewTextBoxColumn, Me.FechaFinalDataGridViewTextBoxColumn, Me.TanqueDataGridViewTextBoxColumn})
        Me.tablalotes.DataSource = Me.LotesBDS
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tablalotes.DefaultCellStyle = DataGridViewCellStyle5
        Me.tablalotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablalotes.Location = New System.Drawing.Point(3, 238)
        Me.tablalotes.Name = "tablalotes"
        Me.tablalotes.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablalotes.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.tablalotes.RowHeadersVisible = False
        Me.tablalotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tablalotes.Size = New System.Drawing.Size(391, 202)
        Me.tablalotes.TabIndex = 6
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 41
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
        Me.FechaInicialDataGridViewTextBoxColumn.Width = 89
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
        Me.TanqueDataGridViewTextBoxColumn.DataSource = Me.tanquesBDS
        Me.TanqueDataGridViewTextBoxColumn.DisplayMember = "Nombre"
        Me.TanqueDataGridViewTextBoxColumn.HeaderText = "Depósito"
        Me.TanqueDataGridViewTextBoxColumn.Name = "TanqueDataGridViewTextBoxColumn"
        Me.TanqueDataGridViewTextBoxColumn.ReadOnly = True
        Me.TanqueDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TanqueDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.TanqueDataGridViewTextBoxColumn.ValueMember = "Numero"
        Me.TanqueDataGridViewTextBoxColumn.Width = 74
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tabladetalles, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(400, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.14634!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.85366!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(391, 201)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label9.Location = New System.Drawing.Point(3, 3)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Entradas del lote"
        '
        'tabladetalles
        '
        Me.tabladetalles.AllowUserToAddRows = False
        Me.tabladetalles.AllowUserToDeleteRows = False
        Me.tabladetalles.AllowUserToResizeRows = False
        Me.tabladetalles.AutoGenerateColumns = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabladetalles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.tabladetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabladetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoteaceiteDataGridViewTextBoxColumn, Me.OpbodegaDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1})
        Me.tabladetalles.DataSource = Me.detallesBDS
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabladetalles.DefaultCellStyle = DataGridViewCellStyle8
        Me.tabladetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabladetalles.Location = New System.Drawing.Point(3, 31)
        Me.tabladetalles.Name = "tabladetalles"
        Me.tabladetalles.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabladetalles.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.tabladetalles.RowHeadersVisible = False
        Me.tabladetalles.Size = New System.Drawing.Size(385, 167)
        Me.tabladetalles.TabIndex = 1
        '
        'LoteaceiteDataGridViewTextBoxColumn
        '
        Me.LoteaceiteDataGridViewTextBoxColumn.DataPropertyName = "Loteaceite"
        Me.LoteaceiteDataGridViewTextBoxColumn.HeaderText = "Loteaceite"
        Me.LoteaceiteDataGridViewTextBoxColumn.Name = "LoteaceiteDataGridViewTextBoxColumn"
        Me.LoteaceiteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OpbodegaDataGridViewTextBoxColumn
        '
        Me.OpbodegaDataGridViewTextBoxColumn.DataPropertyName = "Opbodega"
        Me.OpbodegaDataGridViewTextBoxColumn.HeaderText = "Opbodega"
        Me.OpbodegaDataGridViewTextBoxColumn.Name = "OpbodegaDataGridViewTextBoxColumn"
        Me.OpbodegaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Kilos"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Kilos"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'detallesBDS
        '
        Me.detallesBDS.DataMember = "detalles_loteaceite"
        Me.detallesBDS.DataSource = Me.OleosigDB1
        '
        'bkworker1
        '
        '
        'frmAdLotAceite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(794, 491)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Toolbar1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MinimizeBox = False
        Me.Name = "frmAdLotAceite"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Añadir lotes de Aceite"
        Me.Toolbar1.ResumeLayout(False)
        Me.Toolbar1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LotesBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tanquesBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.entradasac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.opbodegaBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablalotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.tabladetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.detallesBDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents entradasac As System.Windows.Forms.DataGridView
    Friend WithEvents opbodegaBDS As System.Windows.Forms.BindingSource
    Friend WithEvents KilosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tablalotes As System.Windows.Forms.DataGridView
    Friend WithEvents LotesBDS As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lotetxt As System.Windows.Forms.TextBox
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents kilostxt As System.Windows.Forms.TextBox
    Friend WithEvents cmbtanques As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tabladetalles As System.Windows.Forms.DataGridView
    Friend WithEvents chkAbierto As System.Windows.Forms.CheckBox
    Friend WithEvents dtfechafin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtfechaini As System.Windows.Forms.DateTimePicker
    Friend WithEvents detallesBDS As System.Windows.Forms.BindingSource
    Friend WithEvents OleosigDB1 As Oleosig.oleosigDB
    Friend WithEvents LoteaceiteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OpbodegaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bkworker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents tanquesBDS As System.Windows.Forms.BindingSource
    Friend WithEvents OperacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaInicialDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFinalDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TanqueDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaInicialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFinalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TanqueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn

End Class