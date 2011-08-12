

Public Class frmAddNewImportacion

    Private _padre As frmCfgImportTickets
    Public Sub New(ByVal padre As frmCfgImportTickets)
        Me._padre = padre
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me._padre.nmimportacion.Text = Me.nmImportacion.Text
        Me._padre.rb1.Checked = RadioButton1.Checked
        Me._padre.rb2.Checked = RadioButton2.Checked
        Me._padre.delimTxt.Text = Me.delimtxt.Text

        DialogResult = DialogResult.OK

        'Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            delimtxt.Visible = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            delimtxt.Visible = False
        End If
    End Sub

    Private Sub frmAddNewImportacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        delimtxt.Visible = False
    End Sub
End Class