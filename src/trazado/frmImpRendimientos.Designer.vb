<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpRendimientos
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
        Me.dialogArchivo = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkcuadradilla = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.charseptxt = New System.Windows.Forms.TextBox()
        Me.chkOtros = New System.Windows.Forms.CheckBox()
        Me.chkEspacio = New System.Windows.Forms.CheckBox()
        Me.chkComa = New System.Windows.Forms.CheckBox()
        Me.chkpuntocoma = New System.Windows.Forms.CheckBox()
        Me.chkTab = New System.Windows.Forms.CheckBox()
        Me.rbseparadopor = New System.Windows.Forms.RadioButton()
        Me.rbAnchofijo = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tablaRendimientos = New System.Windows.Forms.DataGridView()
        Me.puentedatos = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RendNumUpDown = New System.Windows.Forms.NumericUpDown()
        Me.TicketNumUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.tablaRendimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.puentedatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RendNumUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketNumUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tablaRendimientos, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.18447!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.81553!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(625, 412)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.chkcuadradilla)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.charseptxt)
        Me.Panel1.Controls.Add(Me.chkOtros)
        Me.Panel1.Controls.Add(Me.chkEspacio)
        Me.Panel1.Controls.Add(Me.chkComa)
        Me.Panel1.Controls.Add(Me.chkpuntocoma)
        Me.Panel1.Controls.Add(Me.chkTab)
        Me.Panel1.Controls.Add(Me.rbseparadopor)
        Me.Panel1.Controls.Add(Me.rbAnchofijo)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(619, 209)
        Me.Panel1.TabIndex = 0
        '
        'chkcuadradilla
        '
        Me.chkcuadradilla.AutoSize = True
        Me.chkcuadradilla.Location = New System.Drawing.Point(225, 151)
        Me.chkcuadradilla.Name = "chkcuadradilla"
        Me.chkcuadradilla.Size = New System.Drawing.Size(33, 17)
        Me.chkcuadradilla.TabIndex = 13
        Me.chkcuadradilla.Text = "#"
        Me.chkcuadradilla.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(535, 76)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'charseptxt
        '
        Me.charseptxt.Enabled = False
        Me.charseptxt.Location = New System.Drawing.Point(277, 117)
        Me.charseptxt.Name = "charseptxt"
        Me.charseptxt.Size = New System.Drawing.Size(87, 20)
        Me.charseptxt.TabIndex = 11
        '
        'chkOtros
        '
        Me.chkOtros.AutoSize = True
        Me.chkOtros.Location = New System.Drawing.Point(225, 120)
        Me.chkOtros.Name = "chkOtros"
        Me.chkOtros.Size = New System.Drawing.Size(46, 17)
        Me.chkOtros.TabIndex = 10
        Me.chkOtros.Text = "Otro"
        Me.chkOtros.UseVisualStyleBackColor = True
        '
        'chkEspacio
        '
        Me.chkEspacio.AutoSize = True
        Me.chkEspacio.Location = New System.Drawing.Point(155, 151)
        Me.chkEspacio.Name = "chkEspacio"
        Me.chkEspacio.Size = New System.Drawing.Size(64, 17)
        Me.chkEspacio.TabIndex = 9
        Me.chkEspacio.Text = "Espacio"
        Me.chkEspacio.UseVisualStyleBackColor = True
        '
        'chkComa
        '
        Me.chkComa.AutoSize = True
        Me.chkComa.Location = New System.Drawing.Point(155, 120)
        Me.chkComa.Name = "chkComa"
        Me.chkComa.Size = New System.Drawing.Size(53, 17)
        Me.chkComa.TabIndex = 8
        Me.chkComa.Text = "Coma"
        Me.chkComa.UseVisualStyleBackColor = True
        '
        'chkpuntocoma
        '
        Me.chkpuntocoma.AutoSize = True
        Me.chkpuntocoma.Location = New System.Drawing.Point(58, 151)
        Me.chkpuntocoma.Name = "chkpuntocoma"
        Me.chkpuntocoma.Size = New System.Drawing.Size(91, 17)
        Me.chkpuntocoma.TabIndex = 7
        Me.chkpuntocoma.Text = "Punto y coma"
        Me.chkpuntocoma.UseVisualStyleBackColor = True
        '
        'chkTab
        '
        Me.chkTab.AutoSize = True
        Me.chkTab.Location = New System.Drawing.Point(58, 119)
        Me.chkTab.Name = "chkTab"
        Me.chkTab.Size = New System.Drawing.Size(74, 17)
        Me.chkTab.TabIndex = 6
        Me.chkTab.Text = "Tabulador"
        Me.chkTab.UseVisualStyleBackColor = True
        '
        'rbseparadopor
        '
        Me.rbseparadopor.AutoSize = True
        Me.rbseparadopor.Location = New System.Drawing.Point(27, 83)
        Me.rbseparadopor.Name = "rbseparadopor"
        Me.rbseparadopor.Size = New System.Drawing.Size(89, 17)
        Me.rbseparadopor.TabIndex = 5
        Me.rbseparadopor.TabStop = True
        Me.rbseparadopor.Text = "Separado por"
        Me.rbseparadopor.UseVisualStyleBackColor = True
        '
        'rbAnchofijo
        '
        Me.rbAnchofijo.AutoSize = True
        Me.rbAnchofijo.Location = New System.Drawing.Point(27, 59)
        Me.rbAnchofijo.Name = "rbAnchofijo"
        Me.rbAnchofijo.Size = New System.Drawing.Size(72, 17)
        Me.rbAnchofijo.TabIndex = 4
        Me.rbAnchofijo.TabStop = True
        Me.rbAnchofijo.Text = "Ancho fijo"
        Me.rbAnchofijo.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(535, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Aceptar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(439, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(73, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(338, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Archivo"
        '
        'tablaRendimientos
        '
        Me.tablaRendimientos.AllowUserToAddRows = False
        Me.tablaRendimientos.AllowUserToDeleteRows = False
        Me.tablaRendimientos.AllowUserToResizeRows = False
        Me.tablaRendimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.tablaRendimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaRendimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablaRendimientos.Location = New System.Drawing.Point(3, 218)
        Me.tablaRendimientos.Name = "tablaRendimientos"
        Me.tablaRendimientos.ReadOnly = True
        Me.tablaRendimientos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.tablaRendimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.tablaRendimientos.Size = New System.Drawing.Size(619, 191)
        Me.tablaRendimientos.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TicketNumUpDown)
        Me.GroupBox1.Controls.Add(Me.RendNumUpDown)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(410, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 81)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Numero de Columna"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Rendimiento :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Ticket :"
        '
        'RendNumUpDown
        '
        Me.RendNumUpDown.Location = New System.Drawing.Point(89, 50)
        Me.RendNumUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.RendNumUpDown.Name = "RendNumUpDown"
        Me.RendNumUpDown.Size = New System.Drawing.Size(95, 20)
        Me.RendNumUpDown.TabIndex = 2
        '
        'TicketNumUpDown
        '
        Me.TicketNumUpDown.Location = New System.Drawing.Point(89, 21)
        Me.TicketNumUpDown.Name = "TicketNumUpDown"
        Me.TicketNumUpDown.Size = New System.Drawing.Size(95, 20)
        Me.TicketNumUpDown.TabIndex = 3
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(535, 47)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Guardar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmImpRendimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 412)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmImpRendimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar Rendimientos"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tablaRendimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.puentedatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.RendNumUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketNumUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dialogArchivo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tablaRendimientos As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents puentedatos As System.Windows.Forms.BindingSource
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents charseptxt As System.Windows.Forms.TextBox
    Friend WithEvents chkOtros As System.Windows.Forms.CheckBox
    Friend WithEvents chkEspacio As System.Windows.Forms.CheckBox
    Friend WithEvents chkComa As System.Windows.Forms.CheckBox
    Friend WithEvents chkpuntocoma As System.Windows.Forms.CheckBox
    Friend WithEvents chkTab As System.Windows.Forms.CheckBox
    Friend WithEvents rbseparadopor As System.Windows.Forms.RadioButton
    Friend WithEvents rbAnchofijo As System.Windows.Forms.RadioButton
    Friend WithEvents chkcuadradilla As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TicketNumUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents RendNumUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
