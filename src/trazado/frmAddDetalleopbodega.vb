Option Strict Off
Option Explicit On
Friend Class frmAddDetalleopbodega
    Inherits System.Windows.Forms.Form


    Private _aceite As Integer
    Public ReadOnly Property Aceite As Integer
        Get
            Return Me._aceite
        End Get
    End Property

    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        Me._aceite = CInt(Me.kilosaceitetxt.Text)
        Me.Hide()

    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click

        Me.Hide()

    End Sub


    Private Sub kilosaceitetxt_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles kilosaceitetxt.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        If KeyCode = System.Windows.Forms.Keys.Return Then
            System.Windows.Forms.SendKeys.Send("{TAB}")
        End If
    End Sub


    Private Sub kilosmasatxt_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles kilosmasatxt.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        If KeyCode = System.Windows.Forms.Keys.Return Then
            System.Windows.Forms.SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub moltTxt_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles moltTxt.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        If KeyCode = System.Windows.Forms.Keys.Return Then
            System.Windows.Forms.SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub rendtxt_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles rendtxt.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        If KeyCode = System.Windows.Forms.Keys.Return Then
            System.Windows.Forms.SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub rendtxt_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles rendtxt.Validating
        Dim Cancel As Boolean = eventArgs.Cancel

        kilosaceitetxt.Text = Trim(CStr((Val(rendtxt.Text) * Val(kilosmasatxt.Text)) / 100))
        Command1.Enabled = True
        eventArgs.Cancel = Cancel
    End Sub

    Private Sub frmAddDetalleopbodega_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Command1.Enabled = False

    End Sub
End Class