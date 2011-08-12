
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmwizardpartidas1
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
        Me.chktolvas = New System.Windows.Forms.CheckedListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbltolvas = New System.Windows.Forms.Label()
        Me.chkborrarpartidas = New System.Windows.Forms.CheckBox()
        Me.chkVar = New System.Windows.Forms.CheckBox()
        Me.OleosigDB1 = New Oleosig.oleosigDB()
        Me.tolvasBDS = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tolvasBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chktolvas
        '
        Me.chktolvas.FormattingEnabled = True
        Me.chktolvas.Location = New System.Drawing.Point(29, 36)
        Me.chktolvas.Name = "chktolvas"
        Me.chktolvas.Size = New System.Drawing.Size(90, 94)
        Me.chktolvas.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(143, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(143, 66)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lbltolvas
        '
        Me.lbltolvas.AutoSize = True
        Me.lbltolvas.Location = New System.Drawing.Point(29, 17)
        Me.lbltolvas.Name = "lbltolvas"
        Me.lbltolvas.Size = New System.Drawing.Size(39, 13)
        Me.lbltolvas.TabIndex = 5
        Me.lbltolvas.Text = "Tolvas"
        '
        'chkborrarpartidas
        '
        Me.chkborrarpartidas.AutoSize = True
        Me.chkborrarpartidas.Location = New System.Drawing.Point(30, 143)
        Me.chkborrarpartidas.Name = "chkborrarpartidas"
        Me.chkborrarpartidas.Size = New System.Drawing.Size(94, 17)
        Me.chkborrarpartidas.TabIndex = 6
        Me.chkborrarpartidas.Text = "Borrar partidas"
        Me.chkborrarpartidas.UseVisualStyleBackColor = True
        '
        'chkVar
        '
        Me.chkVar.AutoSize = True
        Me.chkVar.Location = New System.Drawing.Point(29, 166)
        Me.chkVar.Name = "chkVar"
        Me.chkVar.Size = New System.Drawing.Size(118, 17)
        Me.chkVar.TabIndex = 7
        Me.chkVar.Text = "Agrupar variedades"
        Me.chkVar.UseVisualStyleBackColor = True
        Me.chkVar.Visible = False
        '
        'OleosigDB1
        '
        Me.OleosigDB1.DataSetName = "oleosigDB"
        Me.OleosigDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmwizardpartidas1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 226)
        Me.Controls.Add(Me.chkVar)
        Me.Controls.Add(Me.chkborrarpartidas)
        Me.Controls.Add(Me.lbltolvas)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chktolvas)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmwizardpartidas1"
        Me.Text = "frmwizardpartidas1"
        CType(Me.OleosigDB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tolvasBDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chktolvas As System.Windows.Forms.CheckedListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lbltolvas As System.Windows.Forms.Label
    Friend WithEvents chkborrarpartidas As System.Windows.Forms.CheckBox
    Friend WithEvents chkVar As System.Windows.Forms.CheckBox
    Friend WithEvents OleosigDB1 As Oleosig.oleosigDB
    Friend WithEvents tolvasBDS As System.Windows.Forms.BindingSource
End Class
