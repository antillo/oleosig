Option Strict Off
Option Explicit On

Friend Class frmAdClientes
    Inherits System.Windows.Forms.Form


    Dim oClientes As clientesTableAdapter
    Dim editando As Boolean



    Private Sub borrar()
        Dim result As MsgBoxResult

        result = MsgBox("¿ Desea eliminar el cliente ?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation)
        If result = MsgBoxResult.Yes Then

            ClientesBDS.RemoveCurrent()


        End If
    End Sub
    Private Sub cptxt_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(eventArgs.KeyChar) Then
            eventArgs.Handled = False
        ElseIf Char.IsControl(eventArgs.KeyChar) Then
            eventArgs.Handled = False
        Else
            eventArgs.Handled = True
        End If

    End Sub

    Private Sub faxtxt_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(eventArgs.KeyChar) Then
            eventArgs.Handled = False
        ElseIf Char.IsControl(eventArgs.KeyChar) Then
            eventArgs.Handled = False
        Else
            eventArgs.Handled = True
        End If

    End Sub



    Private Sub frmAdClientes_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load


        Me.Left = (frminicial.ClientRectangle.Width - Me.Width) / 2
        Me.Top = (frminicial.ClientRectangle.Height - Me.Height) / 2
        oClientes = New clientesTableAdapter(Almazara.Id)
        oClientes.Fill(OleosigDB1.clientes)


        Inicia_Componentes()

    End Sub

    Private Sub Inicia_Componentes()
        editando = False
        Me.Text = "Clientes"
        barramenu.Items.Item(0).Enabled = True
        barramenu.Items.Item(1).Enabled = False
        barramenu.Items.Item(5).Enabled = False
        barramenu.Items.Item(7).Enabled = False



        deshabilita_Textbox()
        tablaClientes.Enabled = True

    End Sub



 

    '#########################################################################
    '#
    '#      subrutina llamada al pulsar el boton nuevo
    '#
    '#########################################################################
    Private Sub nuevo()
        'Inicia_Componentes()

        habilita_Textbox()
        barramenu.Items.Item(7).Enabled = True

        Dim cliente As oleosigDB.clientesRow = CType(ClientesBDS.AddNew, DataRowView).Row
        cliente.Idalmazara = Almazara.Id

        numclientetxt.Text = (oClientes.getLastNumCliente + 1).ToString

        SendKeys.Send("{TAB}")
        SendKeys.Send("{TAB}")

        tablaClientes.Enabled = False


    End Sub

    '##########################################################################
    '#
    '#      subrutina llamada al pulsar editar
    '#
    '###########################################################################
    Private Sub editar()
        editando = True

        habilita_Textbox()
        Me.Text = Me.Text & " - Editando -"
        barramenu.Items.Item(0).Enabled = False
        barramenu.Items.Item(5).Enabled = True
        barramenu.Items.Item(7).Enabled = True
        tablaClientes.Enabled = False

    End Sub

    '###########################################################################
    '#
    '#      subrutina llamada al pulsar el boton cancelar
    '#
    '##########################################################################
    Private Sub cancelar()
        ClientesBDS.CancelEdit()
        Inicia_Componentes()


    End Sub

    '############################################################################
    '#
    '#      subrutina llamada al pulsar el boton guardar
    '#
    '############################################################################
    Private Sub Guardar()

        Dim result As MsgBoxResult

        Me.ValidateChildren()

        If Len(nombretxt.Text) > 0 Then
            ' entidad.Nombre = UCase(nombretxt.Text)
        Else
            MsgBox("Debe introducir un nombre de cliente")

            Exit Sub
        End If

        If Len(ciftxt.Text) > 0 Then
            'entidad.Cif = UCase(ciftxt.Text)
        Else
            'MsgBox("Debe introducir un numero de CIF")

            'Exit Sub
        End If
        If Len(cptxt.Text) > 0 Then
            'entidad.CP = cptxt.Text
        Else
            MsgBox("Debe introducir un codigo postal")
            Exit Sub
        End If
        If Len(direcciontxt.Text) > 0 Then
            'entidad.Direccion = UCase(direcciontxt.Text)
        Else
            'MsgBox("Debe introducir una direccion")
            'Exit Sub
        End If
        'If Len(emailtxt.Text) > 0 Then
        ' entidad.Email = emailtxt.Text
        'Else
        'entidad.Email = "."
        'End If
        If Len(localidadtxt.Text) > 0 Then

        Else
            'MsgBox("Debe introducir una localidad")

            'Exit Sub
        End If
        If Len(numclientetxt.Text) > 0 Then

        Else
            MsgBox("Debe introducir un número de cliente")

            Exit Sub
        End If
        If Len(provinciatxt.Text) > 0 Then

        Else
            'MsgBox("Debe introducir una provincia")

            'Exit Sub
        End If
        If Len(telefonotxt.Text) > 0 Then
            'entidad.Telefono = telefonotxt.Text
        Else
            'entidad.Telefono = "."
        End If
        If Len(faxtxt.Text) > 0 Then
            ' entidad.Fax = faxtxt.Text
        Else
            'entidad.Fax = "."
        End If

        result = MsgBox("Está seguro de guardar los datos", MsgBoxStyle.YesNo)

        If result = MsgBoxResult.Yes Then


            ClientesBDS.EndEdit()

            oClientes.Update(OleosigDB1.clientes)

            Inicia_Componentes()

        End If

    End Sub



    '################################################################################
    '#
    '#      subrutina que deshabilita las entradas de texto
    '#
    '################################################################################
    Private Sub deshabilita_Textbox()

        Me.ciftxt.Enabled = False
        Me.cptxt.Enabled = False
        Me.direcciontxt.Enabled = False
        Me.emailtxt.Enabled = False
        Me.faxtxt.Enabled = False
        Me.localidadtxt.Enabled = False
        Me.nombretxt.Enabled = False
        Me.numclientetxt.Enabled = False
        Me.provinciatxt.Enabled = False
        Me.telefonotxt.Enabled = False

    End Sub

    '#################################################################################
    '#
    '#    subrutina que habilita los textbox
    '#
    '#################################################################################
    Private Sub habilita_Textbox()

        Me.ciftxt.Enabled = True
        Me.cptxt.Enabled = True
        Me.direcciontxt.Enabled = True
        Me.emailtxt.Enabled = True
        Me.faxtxt.Enabled = True
        Me.localidadtxt.Enabled = True
        Me.nombretxt.Enabled = True
        Me.numclientetxt.Enabled = True
        Me.provinciatxt.Enabled = True
        Me.telefonotxt.Enabled = True

    End Sub


    Private Sub numclientetxt_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(eventArgs.KeyChar) Then
            eventArgs.Handled = False
        ElseIf Char.IsControl(eventArgs.KeyChar) Then
            eventArgs.Handled = False
        Else
            eventArgs.Handled = True
        End If

    End Sub

    Private Sub telefonotxt_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(eventArgs.KeyChar) Then
            eventArgs.Handled = False
        ElseIf Char.IsControl(eventArgs.KeyChar) Then
            eventArgs.Handled = False
        Else
            eventArgs.Handled = True
        End If

    End Sub

    Private Sub _barramenu_Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _barramenu_Button10.Click

        If OleosigDB1.HasChanges Then
            If MsgBox("¿ Desea guardar los cambios ?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Me.ValidateChildren()
                ClientesBDS.EndEdit()
                oClientes.Update(OleosigDB1.clientes)
            End If
        End If
        Me.Close()
    End Sub


    Private Sub _barramenu_Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _barramenu_Button2.Click
        editar()
    End Sub

    Private Sub _barramenu_Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _barramenu_Button1.Click
        nuevo()
    End Sub

    Private Sub _barramenu_Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _barramenu_Button4.Click
        cancelar()
    End Sub

    Private Sub _barramenu_Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _barramenu_Button6.Click
        borrar()
    End Sub

    Private Sub _barramenu_Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _barramenu_Button8.Click
        Guardar()
    End Sub



    Private Sub numclientetxt_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles numclientetxt.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    

    Private Sub pulsatecla_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ciftxt.KeyPress, direcciontxt.KeyPress, localidadtxt.KeyPress, nombretxt.KeyPress, provinciatxt.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.KeyChar = Char.ToUpper(e.KeyChar)

        End If
    End Sub

    
    Private Sub tablaClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tablaClientes.Click
        barramenu.Items.Item(1).Enabled = True
    End Sub

   
End Class