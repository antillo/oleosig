<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCampa�as
#Region "C�digo generado por el Dise�ador de Windows Forms "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Llamada necesaria para el Dise�ador de Windows Forms.
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
	'Requerido por el Dise�ador de Windows Forms
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents campa�atxt As System.Windows.Forms.TextBox
	Public WithEvents idtxt As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents frmsalir As System.Windows.Forms.Button
    Public WithEvents listaCampa�as As System.Windows.Forms.ListBox
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTA: el Dise�ador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Dise�ador de Windows Forms.
	'No lo modifique con el editor de c�digo.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.cmdNueva = New System.Windows.Forms.Button()
        Me.cmdA�adir = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.campa�atxt = New System.Windows.Forms.TextBox()
        Me.idtxt = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.campa�asBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.OleosigDB1 = New Oleosig.oleosigDB()
        Me.frmsalir = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.frmSelect = New System.Windows.Forms.Button()
        Me.listaCampa�as = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.campActtxt = New System.Windows.Forms.TextBox()
        Me.Frame2.SuspendLayout()
        CType(Me.campa�asBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.cmdNueva)
        Me.Frame2.Controls.Add(Me.cmdA�adir)
        Me.Frame2.Controls.Add(Me.cmdCancelar)
        Me.Frame2.Controls.Add(Me.cmdBorrar)
        Me.Frame2.Controls.Add(Me.campa�atxt)
        Me.Frame2.Controls.Add(Me.idtxt)
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.Controls.Add(Me.Label1)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(6, 188)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(439, 167)
        Me.Frame2.TabIndex = 3
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Registro de Campa�as"
        '
        'cmdNueva
        '
        Me.cmdNueva.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNueva.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNueva.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNueva.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdNueva.Location = New System.Drawing.Point(354, 20)
        Me.cmdNueva.Name = "cmdNueva"
        Me.cmdNueva.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdNueva.Size = New System.Drawing.Size(79, 31)
        Me.cmdNueva.TabIndex = 18
        Me.cmdNueva.Text = "Nueva"
        Me.cmdNueva.UseVisualStyleBackColor = False
        '
        'cmdA�adir
        '
        Me.cmdA�adir.BackColor = System.Drawing.SystemColors.Control
        Me.cmdA�adir.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdA�adir.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdA�adir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdA�adir.Location = New System.Drawing.Point(354, 55)
        Me.cmdA�adir.Name = "cmdA�adir"
        Me.cmdA�adir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdA�adir.Size = New System.Drawing.Size(79, 31)
        Me.cmdA�adir.TabIndex = 17
        Me.cmdA�adir.Text = "A�adir"
        Me.cmdA�adir.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(354, 129)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(79, 31)
        Me.cmdCancelar.TabIndex = 16
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdBorrar
        '
        Me.cmdBorrar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBorrar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBorrar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBorrar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBorrar.Location = New System.Drawing.Point(354, 92)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBorrar.Size = New System.Drawing.Size(79, 31)
        Me.cmdBorrar.TabIndex = 16
        Me.cmdBorrar.Text = "Borrar"
        Me.cmdBorrar.UseVisualStyleBackColor = False
        '
        'campa�atxt
        '
        Me.campa�atxt.AcceptsReturn = True
        Me.campa�atxt.BackColor = System.Drawing.SystemColors.Window
        Me.campa�atxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.campa�atxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.campa�atxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.campa�atxt.Location = New System.Drawing.Point(108, 26)
        Me.campa�atxt.MaxLength = 0
        Me.campa�atxt.Name = "campa�atxt"
        Me.campa�atxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.campa�atxt.Size = New System.Drawing.Size(235, 22)
        Me.campa�atxt.TabIndex = 5
        Me.campa�atxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'idtxt
        '
        Me.idtxt.BackColor = System.Drawing.SystemColors.Window
        Me.idtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.idtxt.Cursor = System.Windows.Forms.Cursors.Default
        Me.idtxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idtxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.idtxt.Location = New System.Drawing.Point(108, 59)
        Me.idtxt.Name = "idtxt"
        Me.idtxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.idtxt.Size = New System.Drawing.Size(37, 21)
        Me.idtxt.TabIndex = 14
        Me.idtxt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(12, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(26, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Id :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Campa�a :"
        '
        'campa�asBDS
        '
        Me.campa�asBDS.DataMember = "campagnas"
        Me.campa�asBDS.DataSource = Me.OleosigDB1
        '
        'OleosigDB1
        '
        Me.OleosigDB1.DataSetName = "oleosigDB"
        Me.OleosigDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmsalir
        '
        Me.frmsalir.BackColor = System.Drawing.SystemColors.Control
        Me.frmsalir.Cursor = System.Windows.Forms.Cursors.Default
        Me.frmsalir.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmsalir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmsalir.Location = New System.Drawing.Point(361, 30)
        Me.frmsalir.Name = "frmsalir"
        Me.frmsalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmsalir.Size = New System.Drawing.Size(79, 31)
        Me.frmsalir.TabIndex = 1
        Me.frmsalir.Text = "Aceptar"
        Me.frmsalir.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.frmSelect)
        Me.Frame1.Controls.Add(Me.listaCampa�as)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(6, 79)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(439, 103)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Selecci�n de Campa�as"
        '
        'frmSelect
        '
        Me.frmSelect.BackColor = System.Drawing.SystemColors.Control
        Me.frmSelect.Cursor = System.Windows.Forms.Cursors.Default
        Me.frmSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmSelect.Location = New System.Drawing.Point(360, 34)
        Me.frmSelect.Name = "frmSelect"
        Me.frmSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmSelect.Size = New System.Drawing.Size(73, 31)
        Me.frmSelect.TabIndex = 13
        Me.frmSelect.Text = "Seleccionar"
        Me.frmSelect.UseVisualStyleBackColor = False
        '
        'listaCampa�as
        '
        Me.listaCampa�as.BackColor = System.Drawing.SystemColors.Window
        Me.listaCampa�as.Cursor = System.Windows.Forms.Cursors.Default
        Me.listaCampa�as.ForeColor = System.Drawing.SystemColors.WindowText
        Me.listaCampa�as.ItemHeight = 16
        Me.listaCampa�as.Location = New System.Drawing.Point(12, 24)
        Me.listaCampa�as.Name = "listaCampa�as"
        Me.listaCampa�as.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.listaCampa�as.Size = New System.Drawing.Size(337, 52)
        Me.listaCampa�as.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Campa�a actual :"
        '
        'campActtxt
        '
        Me.campActtxt.BackColor = System.Drawing.Color.White
        Me.campActtxt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.campActtxt.Location = New System.Drawing.Point(131, 34)
        Me.campActtxt.Name = "campActtxt"
        Me.campActtxt.ReadOnly = True
        Me.campActtxt.Size = New System.Drawing.Size(123, 22)
        Me.campActtxt.TabIndex = 5
        Me.campActtxt.TabStop = False
        Me.campActtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmCampa�as
        '
        Me.AcceptButton = Me.frmsalir
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(453, 363)
        Me.ControlBox = False
        Me.Controls.Add(Me.campActtxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.frmsalir)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCampa�as"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Campa�as"
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        CType(Me.campa�asBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents frmSelect As System.Windows.Forms.Button
    Public WithEvents cmdNueva As System.Windows.Forms.Button
    Public WithEvents cmdA�adir As System.Windows.Forms.Button
    Public WithEvents cmdBorrar As System.Windows.Forms.Button
    Friend WithEvents campa�asBDS As System.Windows.Forms.BindingSource
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents campActtxt As System.Windows.Forms.TextBox
    Friend WithEvents OleosigDB1 As Oleosig.oleosigDB
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
#End Region
End Class