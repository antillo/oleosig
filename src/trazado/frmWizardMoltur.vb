Option Strict Off
Option Explicit On
Friend Class frmWizardMoltur1
    Inherits System.Windows.Forms.Form

	
    Private Sub cmbLinea_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        KeyAscii = 0
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Me.Close()
	End Sub
	
	Private Sub frmWizardMoltur1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		inicia_Componentes()
		If frminicial.WindowState <> 1 Then
            Me.Left = (frminicial.ClientRectangle.Width - Me.Width) / 2
            Me.Top = (frminicial.ClientRectangle.Height - Me.Height) / 2
		End If
	End Sub
	Private Sub inicia_Componentes()
		Dim i As Short
        Dim cmbColumn As New DataGridViewComboBoxColumn

        cmbColumn.HeaderText = "Lineas"
        For i = 1 To Almazara.Batidoras
            cmbColumn.Items.Add(i.ToString)
        Next

        cmbColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader

        tablaDatos.Columns.Add(cmbColumn)

        For Each fila As oleosigDB.tolvasRow In OleosigDB1.tolvas.Rows
            tablaDatos.Rows.Add(fila.Nombre)
        Next

    End Sub

    Private Sub Command1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command1.Click
        Dim vconfig As frmWizardMoltur2
        Dim salir As Boolean = True
        For Each fila As DataGridViewRow In tablaDatos.Rows
            If fila.Cells(1).Value Then
                If fila.Cells(2).Value Is Nothing Then
                    MsgBox("Debes seleccionar una linea para la tolva " & fila.Cells(0).Value)
                    Exit Sub
                End If
                salir = False

            End If
        Next
        If salir = True Then
            MsgBox("Debes selecionar al menos una tolva de origen")
            Exit Sub
        End If
        vconfig = New frmWizardMoltur2(Me)

        vconfig.MdiParent = Me.MdiParent
        vconfig.Show()
        Me.Hide()
    End Sub
End Class