<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmvisor
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
	Public WithEvents visor As System.Windows.Forms.WebBrowser
    Public WithEvents _barramenu_Button7 As System.Windows.Forms.ToolStripButton
	Public WithEvents barramenu As System.Windows.Forms.ToolStrip
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.visor = New System.Windows.Forms.WebBrowser()
        Me.barramenu = New System.Windows.Forms.ToolStrip()
        Me._barramenu_Button7 = New System.Windows.Forms.ToolStripButton()
        Me.barramenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'visor
        '
        Me.visor.AllowNavigation = False
        Me.visor.AllowWebBrowserDrop = False
        Me.visor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.visor.IsWebBrowserContextMenuEnabled = False
        Me.visor.Location = New System.Drawing.Point(0, 44)
        Me.visor.Name = "visor"
        Me.visor.Size = New System.Drawing.Size(568, 406)
        Me.visor.TabIndex = 1
        Me.visor.WebBrowserShortcutsEnabled = False
        '
        'barramenu
        '
        Me.barramenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._barramenu_Button7})
        Me.barramenu.Location = New System.Drawing.Point(0, 0)
        Me.barramenu.Name = "barramenu"
        Me.barramenu.Size = New System.Drawing.Size(568, 44)
        Me.barramenu.TabIndex = 0
        '
        '_barramenu_Button7
        '
        Me._barramenu_Button7.Image = Global.Oleosig.My.Resources.Resources.dialog_close
        Me._barramenu_Button7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._barramenu_Button7.Name = "_barramenu_Button7"
        Me._barramenu_Button7.Size = New System.Drawing.Size(43, 41)
        Me._barramenu_Button7.Text = "Cerrar"
        Me._barramenu_Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmvisor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(568, 450)
        Me.Controls.Add(Me.visor)
        Me.Controls.Add(Me.barramenu)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "frmvisor"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Visor de Informes"
        Me.barramenu.ResumeLayout(False)
        Me.barramenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
End Class