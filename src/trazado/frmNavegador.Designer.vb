<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNavegador
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
        Me.Navegador = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'Navegador
        '
        Me.Navegador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Navegador.Location = New System.Drawing.Point(0, 0)
        Me.Navegador.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Navegador.Name = "Navegador"
        Me.Navegador.Size = New System.Drawing.Size(284, 262)
        Me.Navegador.TabIndex = 0
        '
        'frmNavegador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Navegador)
        Me.Name = "frmNavegador"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Navegador As System.Windows.Forms.WebBrowser
End Class
