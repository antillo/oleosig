Option Strict Off
Option Explicit On


Imports System.Net

Friend Class frmLogin
	Inherits System.Windows.Forms.Form


    Private _authToken As String = Nothing
    Private oUsuarios As usuariosTableAdapter

  

    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click

        Me.Close()
        End
    End Sub

    Private Sub cmdLogin_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLogin.Click

        If usertxt.Text.Length > 0 And clavetxt.Text.Length > 0 Then
            Try


                If oUsuarios.Login(usertxt.Text, clavetxt.Text) Then
                    MainModule.carga_almazara(oUsuarios.Almazara)
                    MainModule.carga_campañas()

                    If Me.CheckBox1.Checked Then
                        My.Settings.usuario = usertxt.Text
                        My.Settings.clave = clavetxt.Text
                        My.Settings.recordar = True

                    Else
                        My.Settings.usuario = ""
                        My.Settings.clave = ""
                        My.Settings.recordar = False
                    End If
                    My.Settings.Save()
                    Me.Close()


                Else
                    MsgBox("La contraseña no es válida. Vuelva a intentarlo", , "Inicio de sesión")
                    clavetxt.Focus()

                    System.Windows.Forms.SendKeys.Send("{Home}+{End}")

                End If
               
            Catch ex As Exception
                MsgBox("No hay conexión con el servidor " & ex.Message, vbCritical)
        End Try


        Else
            MsgBox("Los campos usuario y clave no pueden estar vacios", MsgBoxStyle.Exclamation)

        End If


    End Sub

    Private Sub frmLogin_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        'depuracion
        If My.Settings.recordar Then
            Me.CheckBox1.Checked = True
            Me.usertxt.Text = My.Settings.usuario
            Me.clavetxt.Text = My.Settings.clave

        End If

    End Sub

    Private Sub frmLogin_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim Cancel As Boolean = eventArgs.Cancel
        Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
        If UnloadMode = 0 Then
            End
        End If
        eventArgs.Cancel = Cancel
    End Sub
End Class