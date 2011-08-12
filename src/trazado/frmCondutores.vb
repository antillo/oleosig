Option Strict Off
Option Explicit On

Friend Class frmCondutores
    Inherits System.Windows.Forms.Form

    Private editando As Boolean = False
    Private _nuevo As Boolean


    Private Sub ap1Conductortxt_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then

            SendKeys.Send("{TAB}")

        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub


    Private Sub ap2Conductortxt_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If Char.IsLetter(eventArgs.KeyChar) Then
            eventArgs.KeyChar = Char.ToUpper(eventArgs.KeyChar)
        ElseIf KeyAscii = 13 Then

            SendKeys.Send("{TAB}")

        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

   

    Private Sub frmCondutores_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load


        Me.ConductoresDataGridView.AutoGenerateColumns = False
        Me.ConductoresBindingSource.DataSource = Almazara.Conductores
        Me.ConductoresDataGridView.DataSource = ConductoresBindingSource

        Me.ConductoresDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)


        Me.nmConductortxt.DataBindings.Add("Text", ConductoresBindingSource, "nombre", True, DataSourceUpdateMode.OnPropertyChanged)
        Me.ap1Conductortxt.DataBindings.Add("Text", ConductoresBindingSource, "apellido1", True, DataSourceUpdateMode.OnPropertyChanged)
        Me.ap2Conductortxt.DataBindings.Add("Text", ConductoresBindingSource, "apellido2", True, DataSourceUpdateMode.OnPropertyChanged)
        Me.nifConductortxt.DataBindings.Add("Text", ConductoresBindingSource, "dni", True, DataSourceUpdateMode.OnPropertyChanged)
        Me.teltxt.DataBindings.Add("Text", ConductoresBindingSource, "telefono", True, DataSourceUpdateMode.OnPropertyChanged)


        inicia_Componentes()
    End Sub

    
    Private Sub bloquea_Controles()
        Me.nmConductortxt.ReadOnly = True
        Me.ap1Conductortxt.ReadOnly = True
        Me.ap2Conductortxt.ReadOnly = True
        Me.nifConductortxt.ReadOnly = True
        Me.teltxt.ReadOnly = True
    End Sub
    Private Sub habilita_controles()
        Me.nmConductortxt.ReadOnly = False
        Me.ap1Conductortxt.ReadOnly = False
        Me.ap2Conductortxt.ReadOnly = False
        Me.nifConductortxt.ReadOnly = False
        Me.teltxt.ReadOnly = False
    End Sub
    Private Sub inicia_Componentes()

        Me.Toolbar1.Items(0).Enabled = True
        Me.Toolbar1.Items(1).Enabled = False
        Me.Toolbar1.Items(4).Enabled = False
        Me.Toolbar1.Items(6).Enabled = False


        bloquea_Controles()

    End Sub


    Private Sub nmConductortxt_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then
            ap1Conductortxt.Focus()
        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub nuevo()
        Dim fila As DataRow
        habilita_controles()
        fila = CType(ConductoresBindingSource.AddNew(), DataRowView).Row

        fila("idalmazara") = Almazara.Id

        nmConductortxt.Focus()
        Toolbar1.Items(1).Enabled = False
        Toolbar1.Items(4).Enabled = False
        Toolbar1.Items(6).Enabled = True

        _nuevo = True
        editando = False
    End Sub
    Private Sub editar()
        habilita_controles()

        Toolbar1.Items.Item(4).Enabled = True

        Toolbar1.Items.Item(6).Enabled = True
        editando = True


    End Sub

    Private Sub Guardar()

        If MsgBox("¿ Desea guardar los cambios ?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then

            If nmConductortxt.Text.Length > 0 And ap1Conductortxt.Text.Length > 0 And ap2Conductortxt.Text.Length > 0 And nifConductortxt.Text.Length > 0 Then
                If teltxt.Left = 0 Then
                    teltxt.Text = "0"
                End If

                ConductoresBindingSource.EndEdit()

                Almazara.Guarda_conductores()

                inicia_Componentes()

            Else
                MsgBox("Debe introducir datos", MsgBoxStyle.Exclamation)
            End If
        End If

    End Sub

    Private Sub borrar()

        Dim resultado As MsgBoxResult

        If Len(nmConductortxt.Text) > 0 And Len(ap1Conductortxt.Text) > 0 And Len(ap2Conductortxt.Text) > 0 And Len(nifConductortxt.Text) > 0 Then
            resultado = MsgBox("¿ Desea realmente borrar el conductor ?", MsgBoxStyle.YesNo)
            If resultado = MsgBoxResult.Yes Then
                ConductoresBindingSource.RemoveCurrent()
                Almazara.Guarda_conductores()
                inicia_Componentes()

            End If
        Else
            MsgBox("Debe introducir datos", MsgBoxStyle.Exclamation)
        End If
    End Sub

    
    Private Sub _Toolbar1_Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub _Toolbar1_Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        nuevo()
    End Sub

    Private Sub _Toolbar1_Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        borrar()
    End Sub

    Private Sub _Toolbar1_Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        editar()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        ConductoresBindingSource.CancelEdit()
        inicia_Componentes()
    End Sub


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Guardar()
    End Sub

    
    Private Sub teltxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles teltxt.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    
    Private Sub ConductoresDataGridView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConductoresDataGridView.Click
        Me.btnEditar.Enabled = True
    End Sub
End Class