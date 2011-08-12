<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmwizardadticket1
    Inherits System.Windows.Forms.Form


    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cmbImpTickets = New System.Windows.Forms.ComboBox()
        Me.impTicketsBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.OleosigDB1 = New Oleosig.oleosigDB()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblmensaje = New System.Windows.Forms.Label()
        Me.brnCancel = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.puentedatos = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dialogo = New System.Windows.Forms.OpenFileDialog()
        Me.cfgImpFijoBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.cfgImpDelimBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CosecheroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TerminoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoligonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParcelaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KilosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TolvaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BasculaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatriculaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VariedadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CampañaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RendimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImportadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.impTicketsBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.puentedatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cfgImpFijoBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cfgImpDelimBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbImpTickets)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblmensaje)
        Me.SplitContainer1.Panel1.Controls.Add(Me.brnCancel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(656, 348)
        Me.SplitContainer1.SplitterDistance = 144
        Me.SplitContainer1.TabIndex = 0
        '
        'cmbImpTickets
        '
        Me.cmbImpTickets.DataSource = Me.impTicketsBDS
        Me.cmbImpTickets.DisplayMember = "nombre"
        Me.cmbImpTickets.FormattingEnabled = True
        Me.cmbImpTickets.Location = New System.Drawing.Point(136, 53)
        Me.cmbImpTickets.Name = "cmbImpTickets"
        Me.cmbImpTickets.Size = New System.Drawing.Size(311, 22)
        Me.cmbImpTickets.TabIndex = 13
        Me.cmbImpTickets.ValueMember = "idconfig"
        '
        'impTicketsBDS
        '
        Me.impTicketsBDS.DataMember = "importaciones_ticket"
        Me.impTicketsBDS.DataSource = Me.OleosigDB1
        '
        'OleosigDB1
        '
        Me.OleosigDB1.DataSetName = "oleosigDB"
        Me.OleosigDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Configuración :"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(465, 50)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(36, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblmensaje
        '
        Me.lblmensaje.AutoSize = True
        Me.lblmensaje.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmensaje.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblmensaje.Location = New System.Drawing.Point(130, 107)
        Me.lblmensaje.Name = "lblmensaje"
        Me.lblmensaje.Size = New System.Drawing.Size(0, 36)
        Me.lblmensaje.TabIndex = 8
        '
        'brnCancel
        '
        Me.brnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.brnCancel.Location = New System.Drawing.Point(569, 85)
        Me.brnCancel.Name = "brnCancel"
        Me.brnCancel.Size = New System.Drawing.Size(75, 23)
        Me.brnCancel.TabIndex = 7
        Me.brnCancel.Text = "Cancelar"
        Me.brnCancel.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(465, 93)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(36, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(136, 95)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(311, 21)
        Me.TextBox1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Archivo a importar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(569, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Importar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tickets de Báscula a actualizar"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.NumeroDataGridViewTextBoxColumn, Me.CosecheroDataGridViewTextBoxColumn, Me.TerminoDataGridViewTextBoxColumn, Me.PoligonoDataGridViewTextBoxColumn, Me.ParcelaDataGridViewTextBoxColumn, Me.KilosDataGridViewTextBoxColumn, Me.TolvaDataGridViewTextBoxColumn, Me.BasculaDataGridViewTextBoxColumn, Me.MatriculaDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.CalidadDataGridViewTextBoxColumn, Me.VariedadDataGridViewTextBoxColumn, Me.CampañaDataGridViewTextBoxColumn, Me.RendimientoDataGridViewTextBoxColumn, Me.ImportadoDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.puentedatos
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.Size = New System.Drawing.Size(656, 200)
        Me.DataGridView1.TabIndex = 0
        '
        'puentedatos
        '
        Me.puentedatos.DataMember = "lotesaceituna"
        Me.puentedatos.DataSource = Me.OleosigDB1
        '
        'Dialogo
        '
        Me.Dialogo.Filter = "todos los archivos (*.*) | *.*"
        '
        'cfgImpFijoBDS
        '
        Me.cfgImpFijoBDS.DataMember = "cfg_imp_ticket_fijo"
        Me.cfgImpFijoBDS.DataSource = Me.OleosigDB1
        '
        'cfgImpDelimBDS
        '
        Me.cfgImpDelimBDS.DataSource = Me.OleosigDB1
        Me.cfgImpDelimBDS.Position = 0
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 40
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        Me.NumeroDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroDataGridViewTextBoxColumn.Width = 69
        '
        'CosecheroDataGridViewTextBoxColumn
        '
        Me.CosecheroDataGridViewTextBoxColumn.DataPropertyName = "Cosechero"
        Me.CosecheroDataGridViewTextBoxColumn.HeaderText = "Cosechero"
        Me.CosecheroDataGridViewTextBoxColumn.Name = "CosecheroDataGridViewTextBoxColumn"
        Me.CosecheroDataGridViewTextBoxColumn.ReadOnly = True
        Me.CosecheroDataGridViewTextBoxColumn.Width = 85
        '
        'TerminoDataGridViewTextBoxColumn
        '
        Me.TerminoDataGridViewTextBoxColumn.DataPropertyName = "Termino"
        Me.TerminoDataGridViewTextBoxColumn.HeaderText = "Termino"
        Me.TerminoDataGridViewTextBoxColumn.Name = "TerminoDataGridViewTextBoxColumn"
        Me.TerminoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TerminoDataGridViewTextBoxColumn.Width = 69
        '
        'PoligonoDataGridViewTextBoxColumn
        '
        Me.PoligonoDataGridViewTextBoxColumn.DataPropertyName = "Poligono"
        Me.PoligonoDataGridViewTextBoxColumn.HeaderText = "Poligono"
        Me.PoligonoDataGridViewTextBoxColumn.Name = "PoligonoDataGridViewTextBoxColumn"
        Me.PoligonoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PoligonoDataGridViewTextBoxColumn.Width = 72
        '
        'ParcelaDataGridViewTextBoxColumn
        '
        Me.ParcelaDataGridViewTextBoxColumn.DataPropertyName = "Parcela"
        Me.ParcelaDataGridViewTextBoxColumn.HeaderText = "Parcela"
        Me.ParcelaDataGridViewTextBoxColumn.Name = "ParcelaDataGridViewTextBoxColumn"
        Me.ParcelaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ParcelaDataGridViewTextBoxColumn.Width = 68
        '
        'KilosDataGridViewTextBoxColumn
        '
        Me.KilosDataGridViewTextBoxColumn.DataPropertyName = "Kilos"
        Me.KilosDataGridViewTextBoxColumn.HeaderText = "Kilos"
        Me.KilosDataGridViewTextBoxColumn.Name = "KilosDataGridViewTextBoxColumn"
        Me.KilosDataGridViewTextBoxColumn.ReadOnly = True
        Me.KilosDataGridViewTextBoxColumn.Width = 55
        '
        'TolvaDataGridViewTextBoxColumn
        '
        Me.TolvaDataGridViewTextBoxColumn.DataPropertyName = "Tolva"
        Me.TolvaDataGridViewTextBoxColumn.HeaderText = "Tolva"
        Me.TolvaDataGridViewTextBoxColumn.Name = "TolvaDataGridViewTextBoxColumn"
        Me.TolvaDataGridViewTextBoxColumn.ReadOnly = True
        Me.TolvaDataGridViewTextBoxColumn.Width = 57
        '
        'BasculaDataGridViewTextBoxColumn
        '
        Me.BasculaDataGridViewTextBoxColumn.DataPropertyName = "Bascula"
        Me.BasculaDataGridViewTextBoxColumn.HeaderText = "Bascula"
        Me.BasculaDataGridViewTextBoxColumn.Name = "BasculaDataGridViewTextBoxColumn"
        Me.BasculaDataGridViewTextBoxColumn.ReadOnly = True
        Me.BasculaDataGridViewTextBoxColumn.Width = 71
        '
        'MatriculaDataGridViewTextBoxColumn
        '
        Me.MatriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula"
        Me.MatriculaDataGridViewTextBoxColumn.HeaderText = "Matricula"
        Me.MatriculaDataGridViewTextBoxColumn.Name = "MatriculaDataGridViewTextBoxColumn"
        Me.MatriculaDataGridViewTextBoxColumn.ReadOnly = True
        Me.MatriculaDataGridViewTextBoxColumn.Width = 75
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 62
        '
        'CalidadDataGridViewTextBoxColumn
        '
        Me.CalidadDataGridViewTextBoxColumn.DataPropertyName = "Calidad"
        Me.CalidadDataGridViewTextBoxColumn.HeaderText = "Calidad"
        Me.CalidadDataGridViewTextBoxColumn.Name = "CalidadDataGridViewTextBoxColumn"
        Me.CalidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.CalidadDataGridViewTextBoxColumn.Width = 67
        '
        'VariedadDataGridViewTextBoxColumn
        '
        Me.VariedadDataGridViewTextBoxColumn.DataPropertyName = "Variedad"
        Me.VariedadDataGridViewTextBoxColumn.HeaderText = "Variedad"
        Me.VariedadDataGridViewTextBoxColumn.Name = "VariedadDataGridViewTextBoxColumn"
        Me.VariedadDataGridViewTextBoxColumn.ReadOnly = True
        Me.VariedadDataGridViewTextBoxColumn.Width = 75
        '
        'CampañaDataGridViewTextBoxColumn
        '
        Me.CampañaDataGridViewTextBoxColumn.DataPropertyName = "Campaña"
        Me.CampañaDataGridViewTextBoxColumn.HeaderText = "Campaña"
        Me.CampañaDataGridViewTextBoxColumn.Name = "CampañaDataGridViewTextBoxColumn"
        Me.CampañaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CampañaDataGridViewTextBoxColumn.Width = 77
        '
        'RendimientoDataGridViewTextBoxColumn
        '
        Me.RendimientoDataGridViewTextBoxColumn.DataPropertyName = "Rendimiento"
        Me.RendimientoDataGridViewTextBoxColumn.HeaderText = "Rendimiento"
        Me.RendimientoDataGridViewTextBoxColumn.Name = "RendimientoDataGridViewTextBoxColumn"
        Me.RendimientoDataGridViewTextBoxColumn.ReadOnly = True
        Me.RendimientoDataGridViewTextBoxColumn.Width = 90
        '
        'ImportadoDataGridViewCheckBoxColumn
        '
        Me.ImportadoDataGridViewCheckBoxColumn.DataPropertyName = "Importado"
        Me.ImportadoDataGridViewCheckBoxColumn.HeaderText = "Importado"
        Me.ImportadoDataGridViewCheckBoxColumn.Name = "ImportadoDataGridViewCheckBoxColumn"
        Me.ImportadoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ImportadoDataGridViewCheckBoxColumn.Width = 60
        '
        'frmwizardadticket1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.brnCancel
        Me.ClientSize = New System.Drawing.Size(656, 348)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmwizardadticket1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tickets de Báscula"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.impTicketsBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.puentedatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cfgImpFijoBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cfgImpDelimBDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Dialogo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents brnCancel As System.Windows.Forms.Button
    Friend WithEvents lblmensaje As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents puentedatos As System.Windows.Forms.BindingSource
    Friend WithEvents cmbImpTickets As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents impTicketsBDS As System.Windows.Forms.BindingSource
    Friend WithEvents cfgImpFijoBDS As System.Windows.Forms.BindingSource
    Friend WithEvents cfgImpDelimBDS As System.Windows.Forms.BindingSource
    Friend WithEvents OleosigDB1 As Oleosig.oleosigDB
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CosecheroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TerminoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PoligonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ParcelaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TolvaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BasculaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MatriculaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VariedadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CampañaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RendimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImportadoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
