<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEnvasado
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnBorrar = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCerrar = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbMarcas = New System.Windows.Forms.ComboBox()
        Me.EnvasadoBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.OleosigDB1 = New Oleosig.oleosigDB()
        Me.MarcasBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbEnvases = New System.Windows.Forms.ComboBox()
        Me.partidatxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.codigoenvasadotxt = New System.Windows.Forms.TextBox()
        Me.litrostxt = New System.Windows.Forms.TextBox()
        Me.numenvasestxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tablaPartidas = New System.Windows.Forms.DataGridView()
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartidasBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tablaEnvasado = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaenvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodtrazabilidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LitrosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.EnvasadoBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcasBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablaPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartidasBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablaEnvasado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnEditar, Me.ToolStripSeparator1, Me.btnCancelar, Me.ToolStripSeparator2, Me.btnBorrar, Me.btnGuardar, Me.ToolStripSeparator3, Me.btnCerrar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(797, 42)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.Oleosig.My.Resources.Resources.document_new
        Me.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(42, 39)
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnNuevo.ToolTipText = "Nuevo"
        '
        'btnEditar
        '
        Me.btnEditar.Image = Global.Oleosig.My.Resources.Resources.document_properties
        Me.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(39, 39)
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 42)
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.Oleosig.My.Resources.Resources.edit_undo
        Me.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(53, 39)
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 42)
        '
        'btnBorrar
        '
        Me.btnBorrar.Image = Global.Oleosig.My.Resources.Resources.edittrash
        Me.btnBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(41, 39)
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBorrar.ToolTipText = "Borrar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.Oleosig.My.Resources.Resources.document_save
        Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(50, 39)
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 42)
        '
        'btnCerrar
        '
        Me.btnCerrar.Image = Global.Oleosig.My.Resources.Resources.dialog_close
        Me.btnCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(42, 39)
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 421.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tablaPartidas, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tablaEnvasado, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 42)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.80952!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.19048!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(797, 325)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel1, 2)
        Me.Panel1.Controls.Add(Me.cmbMarcas)
        Me.Panel1.Controls.Add(Me.cmbEnvases)
        Me.Panel1.Controls.Add(Me.partidatxt)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.codigoenvasadotxt)
        Me.Panel1.Controls.Add(Me.litrostxt)
        Me.Panel1.Controls.Add(Me.numenvasestxt)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtFecha)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(791, 140)
        Me.Panel1.TabIndex = 3
        '
        'cmbMarcas
        '
        Me.cmbMarcas.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EnvasadoBDS, "marca", True))
        Me.cmbMarcas.DataSource = Me.MarcasBDS
        Me.cmbMarcas.DisplayMember = "Nombre"
        Me.cmbMarcas.FormattingEnabled = True
        Me.cmbMarcas.Location = New System.Drawing.Point(93, 12)
        Me.cmbMarcas.Name = "cmbMarcas"
        Me.cmbMarcas.Size = New System.Drawing.Size(143, 23)
        Me.cmbMarcas.TabIndex = 17
        Me.cmbMarcas.ValueMember = "Codigo"
        '
        'EnvasadoBDS
        '
        Me.EnvasadoBDS.DataMember = "envasado"
        Me.EnvasadoBDS.DataSource = Me.OleosigDB1
        '
        'OleosigDB1
        '
        Me.OleosigDB1.DataSetName = "oleosigDB"
        Me.OleosigDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MarcasBDS
        '
        Me.MarcasBDS.DataMember = "marcas"
        Me.MarcasBDS.DataSource = Me.OleosigDB1
        '
        'cmbEnvases
        '
        Me.cmbEnvases.FormattingEnabled = True
        Me.cmbEnvases.Location = New System.Drawing.Point(518, 13)
        Me.cmbEnvases.Name = "cmbEnvases"
        Me.cmbEnvases.Size = New System.Drawing.Size(100, 23)
        Me.cmbEnvases.TabIndex = 14
        '
        'partidatxt
        '
        Me.partidatxt.Location = New System.Drawing.Point(682, 14)
        Me.partidatxt.Name = "partidatxt"
        Me.partidatxt.ReadOnly = True
        Me.partidatxt.Size = New System.Drawing.Size(90, 21)
        Me.partidatxt.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(624, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 15)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Partida :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(458, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Envase :"
        '
        'codigoenvasadotxt
        '
        Me.codigoenvasadotxt.Location = New System.Drawing.Point(352, 14)
        Me.codigoenvasadotxt.Name = "codigoenvasadotxt"
        Me.codigoenvasadotxt.Size = New System.Drawing.Size(100, 21)
        Me.codigoenvasadotxt.TabIndex = 9
        '
        'litrostxt
        '
        Me.litrostxt.Location = New System.Drawing.Point(520, 57)
        Me.litrostxt.Name = "litrostxt"
        Me.litrostxt.Size = New System.Drawing.Size(100, 21)
        Me.litrostxt.TabIndex = 8
        '
        'numenvasestxt
        '
        Me.numenvasestxt.Location = New System.Drawing.Point(329, 57)
        Me.numenvasestxt.Name = "numenvasestxt"
        Me.numenvasestxt.Size = New System.Drawing.Size(88, 21)
        Me.numenvasestxt.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(435, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Litros :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(243, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nº Envases"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(243, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Códio envasado :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Envasado :"
        '
        'dtFecha
        '
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(128, 57)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(100, 21)
        Me.dtFecha.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Marca"
        '
        'tablaPartidas
        '
        Me.tablaPartidas.AllowUserToAddRows = False
        Me.tablaPartidas.AllowUserToDeleteRows = False
        Me.tablaPartidas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tablaPartidas.AutoGenerateColumns = False
        Me.tablaPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaPartidas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn})
        Me.tablaPartidas.DataSource = Me.PartidasBDS
        Me.tablaPartidas.Location = New System.Drawing.Point(396, 191)
        Me.tablaPartidas.Margin = New System.Windows.Forms.Padding(20)
        Me.tablaPartidas.Name = "tablaPartidas"
        Me.tablaPartidas.ReadOnly = True
        Me.tablaPartidas.RowHeadersVisible = False
        Me.tablaPartidas.Size = New System.Drawing.Size(381, 114)
        Me.tablaPartidas.TabIndex = 4
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        Me.NumeroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PartidasBDS
        '
        Me.PartidasBDS.DataMember = "partidasaceite"
        Me.PartidasBDS.DataSource = Me.OleosigDB1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(3, 149)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Op. de Envasado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(379, 149)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Partidas de Aceite"
        '
        'tablaEnvasado
        '
        Me.tablaEnvasado.AllowUserToAddRows = False
        Me.tablaEnvasado.AllowUserToDeleteRows = False
        Me.tablaEnvasado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tablaEnvasado.AutoGenerateColumns = False
        Me.tablaEnvasado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.tablaEnvasado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaEnvasado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FechaenvDataGridViewTextBoxColumn, Me.CodtrazabilidadDataGridViewTextBoxColumn, Me.MarcaDataGridViewTextBoxColumn, Me.LitrosDataGridViewTextBoxColumn})
        Me.tablaEnvasado.DataSource = Me.EnvasadoBDS
        Me.tablaEnvasado.Location = New System.Drawing.Point(20, 191)
        Me.tablaEnvasado.Margin = New System.Windows.Forms.Padding(20)
        Me.tablaEnvasado.MultiSelect = False
        Me.tablaEnvasado.Name = "tablaEnvasado"
        Me.tablaEnvasado.ReadOnly = True
        Me.tablaEnvasado.RowHeadersVisible = False
        Me.tablaEnvasado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tablaEnvasado.Size = New System.Drawing.Size(336, 114)
        Me.tablaEnvasado.TabIndex = 9
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 42
        '
        'FechaenvDataGridViewTextBoxColumn
        '
        Me.FechaenvDataGridViewTextBoxColumn.DataPropertyName = "fecha_env"
        Me.FechaenvDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaenvDataGridViewTextBoxColumn.Name = "FechaenvDataGridViewTextBoxColumn"
        Me.FechaenvDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaenvDataGridViewTextBoxColumn.Width = 66
        '
        'CodtrazabilidadDataGridViewTextBoxColumn
        '
        Me.CodtrazabilidadDataGridViewTextBoxColumn.DataPropertyName = "cod_trazabilidad"
        Me.CodtrazabilidadDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodtrazabilidadDataGridViewTextBoxColumn.Name = "CodtrazabilidadDataGridViewTextBoxColumn"
        Me.CodtrazabilidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodtrazabilidadDataGridViewTextBoxColumn.Width = 72
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        Me.MarcaDataGridViewTextBoxColumn.ReadOnly = True
        Me.MarcaDataGridViewTextBoxColumn.Width = 65
        '
        'LitrosDataGridViewTextBoxColumn
        '
        Me.LitrosDataGridViewTextBoxColumn.DataPropertyName = "litros"
        Me.LitrosDataGridViewTextBoxColumn.HeaderText = "Litros"
        Me.LitrosDataGridViewTextBoxColumn.Name = "LitrosDataGridViewTextBoxColumn"
        Me.LitrosDataGridViewTextBoxColumn.ReadOnly = True
        Me.LitrosDataGridViewTextBoxColumn.Width = 63
        '
        'frmAddEnvasado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 367)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmAddEnvasado"
        Me.Text = "Añadir Envasado"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EnvasadoBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcasBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablaPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartidasBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablaEnvasado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tablaPartidas As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents codigoenvasadotxt As System.Windows.Forms.TextBox
    Friend WithEvents litrostxt As System.Windows.Forms.TextBox
    Friend WithEvents numenvasestxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents partidatxt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbEnvases As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMarcas As System.Windows.Forms.ComboBox
    Friend WithEvents MarcasBDS As System.Windows.Forms.BindingSource
    Friend WithEvents EnvasadoBDS As System.Windows.Forms.BindingSource
    Friend WithEvents PartidasBDS As System.Windows.Forms.BindingSource
    Friend WithEvents tablaEnvasado As System.Windows.Forms.DataGridView
    Friend WithEvents OleosigDB1 As Oleosig.oleosigDB
    Friend WithEvents NumeroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaenvDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodtrazabilidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LitrosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
