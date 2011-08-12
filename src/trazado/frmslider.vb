Option Strict Off
Option Explicit On
Friend Class frmslider
	Inherits System.Windows.Forms.Form
	Public WriteOnly Property mensaje() As String
		Set(ByVal Value As String)
			Mensajelbl.Text = Value
			Mensajelbl.Visible = True

		End Set
	End Property
	
	
	Private Sub frmslider_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        System.Windows.Forms.Application.DoEvents()
	End Sub
End Class