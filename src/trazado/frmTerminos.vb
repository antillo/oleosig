Option Strict Off
Option Explicit On

Friend Class frmTerminos
    Inherits System.Windows.Forms.Form


    Private _editando As Boolean = False
    Private _nuevo As Boolean = False

    Dim vcargadatos As frmslider
    Private terminolocal As oleosigDB.terminosRow
    Private iniciando As Boolean
    Private terminosDB As terminosTableAdapter
    Private todosTerminoDB As terminosIneTableAdapter


    Private Sub codigotxt_KeyPress(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles codigotxt.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

   

    Private Sub frmTerminos_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

      
        _nuevo = False
        _editando = False
        Me.Cursor = Windows.Forms.Cursors.WaitCursor
        terminosDB = New terminosTableAdapter(Almazara.Id)
        terminosDB.Fill(OleosigDB1.terminos)

        todosTerminoDB = New terminosIneTableAdapter()
        todosTerminoDB.Fill(OleosigDB1.terminosIne)

        oConfig.FillProvincias(OleosigDB1.provincia)


        tablaDatos.AutoGenerateColumns = False
        tablaDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect


        TerminosAlmazaraBDS.ResetBindings(False)

        tablaDatos.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)

        Me.Cursor = Cursors.Default


    End Sub

    Private Sub inicia_Componentes()



        _editando = False
        _nuevo = False

        Toolbar1.Items.Item(0).Enabled = True

        Toolbar1.Items.Item(1).Enabled = False

        Toolbar1.Items.Item(5).Enabled = False

        Toolbar1.Items.Item(7).Enabled = False





        deshabilita_controles()




    End Sub

    Private Sub deshabilita_controles()


        codigotxt.Enabled = False
        terminotxt.Enabled = False
        terminoInetxt.Enabled = False
        cmbProvincia.Enabled = False
        cmbTerminos.Enabled = False

    End Sub
    Private Sub habiliTa_controles()

        codigotxt.Enabled = True
        terminotxt.Enabled = True
        terminoInetxt.Enabled = True
        cmbProvincia.Enabled = True
        cmbTerminos.Enabled = True

    End Sub





    Private Sub terminotxt_KeyPress(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles terminotxt.KeyPress



    End Sub

    Private Sub terminoInetxt_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles terminoInetxt.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        KeyAscii = Asc(UCase(Chr(KeyAscii)))

        If KeyAscii < 65 Or KeyAscii > 90 Then
            If KeyAscii <> 8 And KeyAscii <> 32 Then

                KeyAscii = 0
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub


    Private Sub editar()
        _nuevo = False
        _editando = True

        Toolbar1.Items.Item(0).Enabled = False

        Toolbar1.Items.Item(5).Enabled = True

        Toolbar1.Items.Item(7).Enabled = True
        'terminolocal = CType(TerminosAlmazaraBdSource.Current, DataRowView).Row
        'TerminosAlmazaraBdSource.ResetCurrentItem()

        habiliTa_controles()



    End Sub
    Private Sub nuevo()
        inicia_Componentes()
        habiliTa_controles()


        Toolbar1.Items.Item(1).Enabled = False

        Toolbar1.Items.Item(5).Enabled = True

        Toolbar1.Items.Item(7).Enabled = False

        codigotxt.Focus()

        terminolocal = CType(TerminosAlmazaraBDS.AddNew(), DataRowView).Row
        terminolocal.Idalmazara = Almazara.Id

        TerminosAlmazaraBDS.ResetCurrentItem()
        _editando = False
        _nuevo = True
    End Sub
    Private Sub borrar()
        Dim resultado As MsgBoxResult

        If Not TerminosAlmazaraBDS.Current Is Nothing Then

            resultado = MsgBox("Desea borrar permanentemente el termino", MsgBoxStyle.YesNo)
            If resultado = MsgBoxResult.Yes Then
                TerminosAlmazaraBDS.RemoveCurrent()
                TerminosAlmazaraBDS.EndEdit()
                terminosDB.Update(OleosigDB1.terminos)
                TerminosAlmazaraBDS.ResetBindings(False)
                inicia_Componentes()


            End If



        End If
    End Sub

    Private Sub guardar()




        If MsgBox("Desea guardar los cambios ?", vbYesNo) = vbYes Then
            If codigotxt.Text.Length > 0 And terminotxt.Text.Length > 0 And terminoInetxt.Text.Length > 0 Then
                If IsNumeric(codigotxt.Text) And IsNumeric(terminoInetxt.Text) Then

                    'If _editando = False Then

                    'If Not Almazara.Terminos.Find(Function(ter As eTermino) (ter.Codigo = codigotxt.Text)) Is Nothing Then
                    'MsgBox("El codigo ya existe", vbExclamation)
                    'Exit Sub
                    'End If
                    'End If
                    Me.ValidateChildren()
                    TerminosAlmazaraBDS.EndEdit()
                    terminosDB.Update(OleosigDB1.terminos)
                    TerminosAlmazaraBDS.ResetBindings(False)

                    inicia_Componentes()

                Else
                    MsgBox("Debe introducir números")
                End If


            End If

        End If
    End Sub

    Private Sub _Toolbar1_Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button8.Click
        Me.Close()
    End Sub

    Private Sub _Toolbar1_Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button1.Click
        Me.nuevo()
    End Sub

    Private Sub _Toolbar1_Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button2.Click
        Me.editar()
    End Sub

    Private Sub _Toolbar1_Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button3.Click
        Me.TerminosAlmazaraBDS.CancelEdit()
        'Me.TerminosAlmazaraBdSource.ResetBindings(False)
        Me.inicia_Componentes()

    End Sub

    Private Sub _Toolbar1_Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button4.Click
        Me.guardar()
    End Sub

    Private Sub _Toolbar1_Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button6.Click
        Me.borrar()
    End Sub

    Private Sub tablaDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tablaDatos.Click


        If tablaDatos.RowCount > 0 Then

            Toolbar1.Items.Item(1).Enabled = True

        End If
    End Sub




    Private Sub cmbProvincia_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProvincia.SelectionChangeCommitted
        If Not iniciando Then
            If cmbProvincia.SelectedIndex > -1 Then

                codProvTxt.Text = cmbProvincia.SelectedValue.ToString
                TodosTerminosBDS.Filter = "Cpro='" & cmbProvincia.SelectedValue & "'"
                TodosTerminosBDS.ResetBindings(False)

            End If
        End If
    End Sub

    Private Sub cmbTerminos_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTerminos.SelectionChangeCommitted
        If Not iniciando Then
            If terminolocal IsNot Nothing Then
                If cmbTerminos.SelectedIndex > -1 Then
                    terminoInetxt.Text = cmbTerminos.SelectedValue.ToString
                    terminotxt.Text = CType(cmbTerminos.SelectedItem, DataRowView).Row("nombre").ToString.ToUpper

                    'TerminosAlmazaraBdSource.ResetCurrentItem()

                End If
            End If

        End If
    End Sub

    Private Sub tablaDatos_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tablaDatos.RowEnter
        If tablaDatos.RowCount > 0 Then
            terminolocal = CType(tablaDatos.Rows(e.RowIndex).DataBoundItem, DataRowView).Row



            TodosTerminosBDS.Filter = "Cpro='" & terminolocal.CodProvincia.ToString & "'"
            TodosTerminosBDS.ResetBindings(False)


        End If
    End Sub

    
End Class