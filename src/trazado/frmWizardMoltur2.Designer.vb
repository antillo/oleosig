<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmWizardMoltur2
#Region "Código generado por el Diseñador de Windows Forms "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New(ByVal vcfg As frmWizardMoltur1)
        MyBase.New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        vconfig = vcfg
        InitializeComponent()
        'Éste es un formulario MDI secundario.
        'Este código simula la funcionalidad de VB6 
        ' de cargar automáticamente
        ' y mostrar el formulario primario de
        ' un MDI secundario.

    End Sub
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New(ByVal linea As Short)
        MyBase.New()
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
    Public WithEvents tablamoltur As System.Windows.Forms.DataGridView
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents listaPartidas As System.Windows.Forms.ListView
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tablamoltur = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdalmazaraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechainiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechafinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LineafabricaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OperacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CampagnaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbiertaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ImportadaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.opfabricaBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.OleosigDB1 = New Oleosig.oleosigDB()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.listaPartidas = New System.Windows.Forms.ListView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bkworker = New System.ComponentModel.BackgroundWorker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.detallesBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.tablaDetalles = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpfabricaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KilosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CampagnaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdalmazaraDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.tablamoltur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.opfabricaBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.detallesBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablaDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tablamoltur
        '
        Me.tablamoltur.AllowUserToAddRows = False
        Me.tablamoltur.AllowUserToDeleteRows = False
        Me.tablamoltur.AllowUserToResizeColumns = False
        Me.tablamoltur.AllowUserToResizeRows = False
        Me.tablamoltur.AutoGenerateColumns = False
        Me.tablamoltur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablamoltur.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tablamoltur.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.IdalmazaraDataGridViewTextBoxColumn, Me.FechainiDataGridViewTextBoxColumn, Me.FechafinDataGridViewTextBoxColumn, Me.LineafabricaDataGridViewTextBoxColumn, Me.OperacionDataGridViewTextBoxColumn, Me.CampagnaDataGridViewTextBoxColumn, Me.AbiertaDataGridViewCheckBoxColumn, Me.ImportadaDataGridViewCheckBoxColumn})
        Me.tablamoltur.DataSource = Me.opfabricaBDS
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tablamoltur.DefaultCellStyle = DataGridViewCellStyle2
        Me.tablamoltur.Location = New System.Drawing.Point(16, 112)
        Me.tablamoltur.Name = "tablamoltur"
        Me.tablamoltur.ReadOnly = True
        Me.tablamoltur.RowHeadersVisible = False
        Me.tablamoltur.Size = New System.Drawing.Size(633, 241)
        Me.tablamoltur.TabIndex = 6
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 40
        '
        'IdalmazaraDataGridViewTextBoxColumn
        '
        Me.IdalmazaraDataGridViewTextBoxColumn.DataPropertyName = "idalmazara"
        Me.IdalmazaraDataGridViewTextBoxColumn.HeaderText = "idalmazara"
        Me.IdalmazaraDataGridViewTextBoxColumn.Name = "IdalmazaraDataGridViewTextBoxColumn"
        Me.IdalmazaraDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdalmazaraDataGridViewTextBoxColumn.Width = 82
        '
        'FechainiDataGridViewTextBoxColumn
        '
        Me.FechainiDataGridViewTextBoxColumn.DataPropertyName = "fechaini"
        Me.FechainiDataGridViewTextBoxColumn.HeaderText = "fechaini"
        Me.FechainiDataGridViewTextBoxColumn.Name = "FechainiDataGridViewTextBoxColumn"
        Me.FechainiDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechainiDataGridViewTextBoxColumn.Width = 69
        '
        'FechafinDataGridViewTextBoxColumn
        '
        Me.FechafinDataGridViewTextBoxColumn.DataPropertyName = "fechafin"
        Me.FechafinDataGridViewTextBoxColumn.HeaderText = "fechafin"
        Me.FechafinDataGridViewTextBoxColumn.Name = "FechafinDataGridViewTextBoxColumn"
        Me.FechafinDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechafinDataGridViewTextBoxColumn.Width = 70
        '
        'LineafabricaDataGridViewTextBoxColumn
        '
        Me.LineafabricaDataGridViewTextBoxColumn.DataPropertyName = "lineafabrica"
        Me.LineafabricaDataGridViewTextBoxColumn.HeaderText = "lineafabrica"
        Me.LineafabricaDataGridViewTextBoxColumn.Name = "LineafabricaDataGridViewTextBoxColumn"
        Me.LineafabricaDataGridViewTextBoxColumn.ReadOnly = True
        Me.LineafabricaDataGridViewTextBoxColumn.Width = 86
        '
        'OperacionDataGridViewTextBoxColumn
        '
        Me.OperacionDataGridViewTextBoxColumn.DataPropertyName = "operacion"
        Me.OperacionDataGridViewTextBoxColumn.HeaderText = "operacion"
        Me.OperacionDataGridViewTextBoxColumn.Name = "OperacionDataGridViewTextBoxColumn"
        Me.OperacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.OperacionDataGridViewTextBoxColumn.Width = 79
        '
        'CampagnaDataGridViewTextBoxColumn
        '
        Me.CampagnaDataGridViewTextBoxColumn.DataPropertyName = "campagna"
        Me.CampagnaDataGridViewTextBoxColumn.HeaderText = "campagna"
        Me.CampagnaDataGridViewTextBoxColumn.Name = "CampagnaDataGridViewTextBoxColumn"
        Me.CampagnaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CampagnaDataGridViewTextBoxColumn.Width = 82
        '
        'AbiertaDataGridViewCheckBoxColumn
        '
        Me.AbiertaDataGridViewCheckBoxColumn.DataPropertyName = "abierta"
        Me.AbiertaDataGridViewCheckBoxColumn.HeaderText = "abierta"
        Me.AbiertaDataGridViewCheckBoxColumn.Name = "AbiertaDataGridViewCheckBoxColumn"
        Me.AbiertaDataGridViewCheckBoxColumn.ReadOnly = True
        Me.AbiertaDataGridViewCheckBoxColumn.Width = 45
        '
        'ImportadaDataGridViewCheckBoxColumn
        '
        Me.ImportadaDataGridViewCheckBoxColumn.DataPropertyName = "importada"
        Me.ImportadaDataGridViewCheckBoxColumn.HeaderText = "importada"
        Me.ImportadaDataGridViewCheckBoxColumn.Name = "ImportadaDataGridViewCheckBoxColumn"
        Me.ImportadaDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ImportadaDataGridViewCheckBoxColumn.Width = 59
        '
        'opfabricaBDS
        '
        Me.opfabricaBDS.DataMember = "opfabrica"
        Me.opfabricaBDS.DataSource = Me.OleosigDB1
        '
        'OleosigDB1
        '
        Me.OleosigDB1.DataSetName = "oleosigDB"
        Me.OleosigDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(1036, 544)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(81, 33)
        Me.Command2.TabIndex = 2
        Me.Command2.Text = "Cerrar"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(1036, 505)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(81, 33)
        Me.Command1.TabIndex = 1
        Me.Command1.Text = "Guardar"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'listaPartidas
        '
        Me.listaPartidas.BackColor = System.Drawing.SystemColors.Window
        Me.listaPartidas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listaPartidas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.listaPartidas.FullRowSelect = True
        Me.listaPartidas.GridLines = True
        Me.listaPartidas.Location = New System.Drawing.Point(8, 400)
        Me.listaPartidas.Name = "listaPartidas"
        Me.listaPartidas.Size = New System.Drawing.Size(297, 217)
        Me.listaPartidas.TabIndex = 0
        Me.listaPartidas.UseCompatibleStateImageBehavior = False
        Me.listaPartidas.View = System.Windows.Forms.View.Details
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(16, 368)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(200, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Partidas de Aceituna"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(143, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Molturaciones"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(814, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Se crearán las siguientes molturaciones de acuerdo con las partidas generadas"
        '
        'bkworker
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(674, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(228, 22)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Detalles de Molturacion"
        '
        'detallesBDS
        '
        Me.detallesBDS.DataMember = "detalles_opfabrica"
        Me.detallesBDS.DataSource = Me.OleosigDB1
        '
        'tablaDetalles
        '
        Me.tablaDetalles.AllowUserToAddRows = False
        Me.tablaDetalles.AllowUserToDeleteRows = False
        Me.tablaDetalles.AutoGenerateColumns = False
        Me.tablaDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablaDetalles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.tablaDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaDetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.OpfabricaDataGridViewTextBoxColumn, Me.PartidaDataGridViewTextBoxColumn, Me.KilosDataGridViewTextBoxColumn, Me.CampagnaDataGridViewTextBoxColumn1, Me.IdalmazaraDataGridViewTextBoxColumn1})
        Me.tablaDetalles.DataSource = Me.detallesBDS
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tablaDetalles.DefaultCellStyle = DataGridViewCellStyle4
        Me.tablaDetalles.Location = New System.Drawing.Point(702, 112)
        Me.tablaDetalles.Name = "tablaDetalles"
        Me.tablaDetalles.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablaDetalles.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.tablaDetalles.RowHeadersVisible = False
        Me.tablaDetalles.Size = New System.Drawing.Size(415, 241)
        Me.tablaDetalles.TabIndex = 7
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        Me.IdDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn1.Width = 40
        '
        'OpfabricaDataGridViewTextBoxColumn
        '
        Me.OpfabricaDataGridViewTextBoxColumn.DataPropertyName = "opfabrica"
        Me.OpfabricaDataGridViewTextBoxColumn.HeaderText = "opfabrica"
        Me.OpfabricaDataGridViewTextBoxColumn.Name = "OpfabricaDataGridViewTextBoxColumn"
        Me.OpfabricaDataGridViewTextBoxColumn.ReadOnly = True
        Me.OpfabricaDataGridViewTextBoxColumn.Width = 76
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
        'CampagnaDataGridViewTextBoxColumn1
        '
        Me.CampagnaDataGridViewTextBoxColumn1.DataPropertyName = "campagna"
        Me.CampagnaDataGridViewTextBoxColumn1.HeaderText = "campagna"
        Me.CampagnaDataGridViewTextBoxColumn1.Name = "CampagnaDataGridViewTextBoxColumn1"
        Me.CampagnaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CampagnaDataGridViewTextBoxColumn1.Width = 82
        '
        'IdalmazaraDataGridViewTextBoxColumn1
        '
        Me.IdalmazaraDataGridViewTextBoxColumn1.DataPropertyName = "idalmazara"
        Me.IdalmazaraDataGridViewTextBoxColumn1.HeaderText = "idalmazara"
        Me.IdalmazaraDataGridViewTextBoxColumn1.Name = "IdalmazaraDataGridViewTextBoxColumn1"
        Me.IdalmazaraDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdalmazaraDataGridViewTextBoxColumn1.Width = 82
        '
        'frmWizardMoltur2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1161, 625)
        Me.Controls.Add(Me.tablaDetalles)
        Me.Controls.Add(Me.tablamoltur)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.listaPartidas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MinimizeBox = False
        Me.Name = "frmWizardMoltur2"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.tablamoltur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.opfabricaBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.detallesBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablaDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bkworker As System.ComponentModel.BackgroundWorker
    Friend WithEvents OleosigDB1 As Oleosig.oleosigDB
    Friend WithEvents opfabricaBDS As System.Windows.Forms.BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdalmazaraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechainiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechafinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LineafabricaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OperacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CampagnaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AbiertaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ImportadaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Public WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents detallesBDS As System.Windows.Forms.BindingSource
    Friend WithEvents tablaDetalles As System.Windows.Forms.DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OpfabricaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PartidaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CampagnaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdalmazaraDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region
End Class