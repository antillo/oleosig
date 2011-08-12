<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCondutores
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
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Public WithEvents btnEditar As System.Windows.Forms.ToolStripButton
    Public WithEvents btnBorrar As System.Windows.Forms.ToolStripButton
    Public WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Public WithEvents btnCerrar As System.Windows.Forms.ToolStripButton
    Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.teltxt = New System.Windows.Forms.TextBox()
        Me.nifConductortxt = New System.Windows.Forms.TextBox()
        Me.ap2Conductortxt = New System.Windows.Forms.TextBox()
        Me.ap1Conductortxt = New System.Windows.Forms.TextBox()
        Me.nmConductortxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Toolbar1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnBorrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCerrar = New System.Windows.Forms.ToolStripButton()
        Me.ConductoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConductoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Frame1.SuspendLayout()
        Me.Toolbar1.SuspendLayout()
        CType(Me.ConductoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConductoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.Label6)
        Me.Frame1.Controls.Add(Me.teltxt)
        Me.Frame1.Controls.Add(Me.nifConductortxt)
        Me.Frame1.Controls.Add(Me.ap2Conductortxt)
        Me.Frame1.Controls.Add(Me.ap1Conductortxt)
        Me.Frame1.Controls.Add(Me.nmConductortxt)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Frame1.Location = New System.Drawing.Point(7, 56)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(344, 165)
        Me.Frame1.TabIndex = 3
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Conductores"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(180, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(29, 15)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Tel.:"
        '
        'teltxt
        '
        Me.teltxt.AcceptsReturn = True
        Me.teltxt.BackColor = System.Drawing.SystemColors.Window
        Me.teltxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.teltxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.teltxt.Location = New System.Drawing.Point(233, 124)
        Me.teltxt.MaxLength = 0
        Me.teltxt.Name = "teltxt"
        Me.teltxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.teltxt.Size = New System.Drawing.Size(90, 21)
        Me.teltxt.TabIndex = 27
        Me.teltxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nifConductortxt
        '
        Me.nifConductortxt.AcceptsReturn = True
        Me.nifConductortxt.BackColor = System.Drawing.SystemColors.Window
        Me.nifConductortxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nifConductortxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nifConductortxt.Location = New System.Drawing.Point(84, 126)
        Me.nifConductortxt.MaxLength = 0
        Me.nifConductortxt.Name = "nifConductortxt"
        Me.nifConductortxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nifConductortxt.Size = New System.Drawing.Size(90, 21)
        Me.nifConductortxt.TabIndex = 19
        Me.nifConductortxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ap2Conductortxt
        '
        Me.ap2Conductortxt.AcceptsReturn = True
        Me.ap2Conductortxt.BackColor = System.Drawing.SystemColors.Window
        Me.ap2Conductortxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ap2Conductortxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ap2Conductortxt.Location = New System.Drawing.Point(84, 89)
        Me.ap2Conductortxt.MaxLength = 0
        Me.ap2Conductortxt.Name = "ap2Conductortxt"
        Me.ap2Conductortxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ap2Conductortxt.Size = New System.Drawing.Size(239, 21)
        Me.ap2Conductortxt.TabIndex = 18
        Me.ap2Conductortxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ap1Conductortxt
        '
        Me.ap1Conductortxt.AcceptsReturn = True
        Me.ap1Conductortxt.BackColor = System.Drawing.SystemColors.Window
        Me.ap1Conductortxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ap1Conductortxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ap1Conductortxt.Location = New System.Drawing.Point(84, 52)
        Me.ap1Conductortxt.MaxLength = 0
        Me.ap1Conductortxt.Name = "ap1Conductortxt"
        Me.ap1Conductortxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ap1Conductortxt.Size = New System.Drawing.Size(239, 21)
        Me.ap1Conductortxt.TabIndex = 17
        Me.ap1Conductortxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nmConductortxt
        '
        Me.nmConductortxt.AcceptsReturn = True
        Me.nmConductortxt.BackColor = System.Drawing.SystemColors.Window
        Me.nmConductortxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nmConductortxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nmConductortxt.Location = New System.Drawing.Point(84, 15)
        Me.nmConductortxt.MaxLength = 0
        Me.nmConductortxt.Name = "nmConductortxt"
        Me.nmConductortxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nmConductortxt.Size = New System.Drawing.Size(134, 21)
        Me.nmConductortxt.TabIndex = 16
        Me.nmConductortxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(14, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "N.I.F. :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(14, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Apellido 2 :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(14, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Apellido 1 :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(14, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nombre :"
        '
        'Toolbar1
        '
        Me.Toolbar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnEditar, Me.btnCancelar, Me.ToolStripSeparator1, Me.btnBorrar, Me.ToolStripSeparator2, Me.btnGuardar, Me.ToolStripSeparator3, Me.btnCerrar})
        Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar1.Name = "Toolbar1"
        Me.Toolbar1.Size = New System.Drawing.Size(899, 48)
        Me.Toolbar1.TabIndex = 2
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
        Me.btnCancelar.Image = Global.Oleosig.My.Resources.Resources.edit_undo
        Me.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(57, 45)
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 48)
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 48)
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 48)
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
        'ConductoresDataGridView
        '
        Me.ConductoresDataGridView.AllowUserToAddRows = False
        Me.ConductoresDataGridView.AllowUserToDeleteRows = False
        Me.ConductoresDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConductoresDataGridView.AutoGenerateColumns = False
        Me.ConductoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConductoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Telefono})
        Me.ConductoresDataGridView.DataSource = Me.ConductoresBindingSource
        Me.ConductoresDataGridView.Location = New System.Drawing.Point(357, 56)
        Me.ConductoresDataGridView.MultiSelect = False
        Me.ConductoresDataGridView.Name = "ConductoresDataGridView"
        Me.ConductoresDataGridView.ReadOnly = True
        Me.ConductoresDataGridView.RowHeadersVisible = False
        Me.ConductoresDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ConductoresDataGridView.Size = New System.Drawing.Size(530, 165)
        Me.ConductoresDataGridView.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "nombre"
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "apellido1"
        Me.Column2.HeaderText = "Apellido1"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "dni"
        Me.Column3.HeaderText = "Nif"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.DataPropertyName = "telefono"
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        '
        'frmCondutores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(899, 233)
        Me.Controls.Add(Me.ConductoresDataGridView)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Toolbar1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCondutores"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Conductores"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Toolbar1.ResumeLayout(False)
        Me.Toolbar1.PerformLayout()
        CType(Me.ConductoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConductoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents nifConductortxt As System.Windows.Forms.TextBox
    Public WithEvents ap2Conductortxt As System.Windows.Forms.TextBox
    Public WithEvents ap1Conductortxt As System.Windows.Forms.TextBox
    Public WithEvents nmConductortxt As System.Windows.Forms.TextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ConductoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConductoresDataGridView As System.Windows.Forms.DataGridView
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents teltxt As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region
End Class