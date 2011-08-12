Option Strict Off
Option Explicit On
Friend Class frmAdSocios
    Inherits System.Windows.Forms.Form


    Dim oSocios As cosecheroTableAdapter
    Dim cosechero As oleosigDB.cosecherosRow
    Dim numSocio As String
    Dim editando As Boolean



    Private Sub Guardar()

        Dim oProcedencia As New procedenciasTableAdapter

        If MsgBox("¿ Desea guardar los datos ?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            If numSociotxt.Text.Length = 0 Then
                MsgBox("El campo código de cosechero no puede estar vacio", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If nombreTxt.Text.Length = 0 Then
                MsgBox("El campo nombre del cosechero no puede estar vacio", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If nifTxt.Text.Length = 0 Then
                MsgBox("El campo nif del cosechero no puede estar vacio", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If provinciaTxt.Text.Length = 0 Then
                MsgBox("El campo provincia no puede estar vacio", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If cpTxt.Text.Length = 0 Then
                MsgBox("El campo codigo postal no puede estar vacio", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If poblacionTxt.Text.Length = 0 Then
                MsgBox("El campo poblacion no puede estar vacio", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Me.ValidateChildren()


            CosecherosBDS.EndEdit()
            oSocios.Update(OleosigDB1.cosecheros)

            inicia_Componentes()

        End If

    End Sub




    Private Sub cmdFind_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFind.Click
        '

    End Sub

    Private Sub frmAdSocios_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        oSocios = New cosecheroTableAdapter(Almazara.Id)

        oSocios.Fill(OleosigDB1.cosecheros)

        tablasocios.AutoGenerateColumns = False

        inicia_Componentes()


    End Sub


    Private Sub inicia_Componentes()


        Toolbar1.Items.Item(0).Enabled = True

        Toolbar1.Items.Item(1).Enabled = False

        Toolbar1.Items.Item(4).Enabled = False

        Toolbar1.Items.Item(6).Enabled = False



        deshabilita_controles()



    End Sub

    Private Sub habiliTa_controles()


        numSociotxt.Enabled = True
        nombreTxt.Enabled = True
        nifTxt.Enabled = True
        provinciaTxt.Enabled = True
        cpTxt.Enabled = True
        poblacionTxt.Enabled = True
        apellido1Txt.Enabled = True
        apellido2Txt.Enabled = True
        dirTxt.Enabled = True



    End Sub
    Private Sub deshabilita_controles()


        numSociotxt.Enabled = False
        nombreTxt.Enabled = False
        nifTxt.Enabled = False
        provinciaTxt.Enabled = False
        cpTxt.Enabled = False
        poblacionTxt.Enabled = False
        apellido1Txt.Enabled = False
        apellido2Txt.Enabled = False
        dirTxt.Enabled = False


    End Sub




    Private Sub poltxt_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii < 48 Or KeyAscii > 57 Then
            If KeyAscii <> 8 Then
                KeyAscii = 0
                If KeyAscii = 13 Then

                    System.Windows.Forms.SendKeys.Send("{TAB}")
                End If

            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub sociotxt_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs)
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000

        If KeyCode = 222 Then
            System.Windows.Forms.SendKeys.Send("{ESC}")
            System.Windows.Forms.SendKeys.Send("{BACKSPACE}")
        End If

    End Sub



    Private Sub termtxt_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        'If KeyAscii < 48 Or KeyAscii > 57 Then
        '    If KeyAscii <> 8 Then
        '        If KeyAscii = 13 Then
        KeyAscii = 0
        System.Windows.Forms.SendKeys.Send("{TAB}")
        '       End If
        '       KeyAscii = 0
        '   End If
        'End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub


    Private Sub editar()

        Toolbar1.Items.Item(0).Enabled = False

        Toolbar1.Items.Item(4).Enabled = True

        Toolbar1.Items.Item(6).Enabled = True
        habiliTa_controles()
        editando = True

    End Sub
    Private Sub nuevo()
        inicia_Componentes()
        Toolbar1.Items.Item(1).Enabled = False
        Toolbar1.Items.Item(6).Enabled = True
        Dim cosechero As oleosigDB.cosecherosRow = CType(CosecherosBDS.AddNew(), DataRowView).Row

        cosechero.Codigo = (oSocios.GetLastNumCosechero() + 1).ToString
        cosechero.Idalmazara = Almazara.Id
        cosechero.Idfaeca = 0
        CosecherosBDS.ResetCurrentItem()

        habiliTa_controles()

    End Sub


    Private Sub _sociotxt_1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nombreTxt.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        KeyAscii = Asc(UCase(Chr(KeyAscii)))
    End Sub



    Private Sub _sociotxt_3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles provinciaTxt.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        KeyAscii = Asc(UCase(Chr(KeyAscii)))
    End Sub

    Private Sub _sociotxt_5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles poblacionTxt.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        KeyAscii = Asc(UCase(Chr(KeyAscii)))
    End Sub



    Private Sub _Toolbar1_Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button9.Click
        Me.Close()
    End Sub

    Private Sub _Toolbar1_Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button1.Click
        Me.nuevo()
    End Sub

    Private Sub _Toolbar1_Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button2.Click
        Me.editar()
    End Sub

    Private Sub _Toolbar1_Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button3.Click
        CosecherosBDS.CancelEdit()
        Me.inicia_Componentes()
    End Sub

    Private Sub _Toolbar1_Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button5.Click
        If MsgBox("Desea borrar el cosechero ?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            CosecherosBDS.RemoveCurrent()
            CosecherosBDS.EndEdit()
            Me.oSocios.Update(OleosigDB1.cosecheros)

            Me.inicia_Componentes()
        End If
    End Sub

    Private Sub _Toolbar1_Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button7.Click
        Me.Guardar()
    End Sub



    Private Sub tablasocios_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tablasocios.Resize

        Frame3.Width = tablasocios.Width + tablasocios.Left * 2

    End Sub

    Private Sub tablasocios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tablasocios.Click


        If tablasocios.Rows.Count > 0 Then
            Toolbar1.Items.Item(1).Enabled = True


        End If


    End Sub

    Private Sub cmbAddproc_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    
End Class