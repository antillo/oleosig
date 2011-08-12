Option Strict Off
Option Explicit On

Public Class frmAdLotAceituna
    Inherits System.Windows.Forms.Form


    Dim oCSocio As cosecheroTableAdapter
    Dim oLotAceituna As LoteAceitunaTableAdapter
    Dim editando As Boolean
    Dim ticket As oleosigDB.lotesaceitunaRow
    Dim varDB As variedadesTableAdapter
    Dim recDB As recoleccionTableAdapter


    Private Sub inicia_Componentes()

        editando = False


        Toolbar1.Items.Item(0).Enabled = True

        Toolbar1.Items.Item(1).Enabled = False
        Toolbar1.Items.Item(4).Enabled = False
        Toolbar1.Items.Item(6).Enabled = False



        deshabilita_componentes()
        'borra_componentes()

        tabladatos.Enabled = True

    End Sub

    Private Sub borra_componentes()
        numlotetxt.Clear()
        dtFecha.Value = Now
        kilostxt.Clear()
        matriculatxt.Clear()
        bascTxt.Clear()
        tertxt.Clear()
        polTxt.Clear()
        tolvastxt.Clear()
        numsociotxt.Clear()
        rendTxt.Text = 0

    End Sub


    Private Sub deshabilita_componentes()

        dtFecha.Enabled = False
        numsociotxt.Enabled = False
        tertxt.Enabled = False
        cmbVariedades.Enabled = False
        partxt.Enabled = False
        tolvastxt.Enabled = False
        polTxt.Enabled = False
        cmbCalidad.Enabled = False
        kilostxt.Enabled = False
        matriculatxt.Enabled = False
        bascTxt.Enabled = False
        rendTxt.Enabled = False

    End Sub
    Private Sub habilita_componentes()

        dtFecha.Enabled = True
        numsociotxt.Enabled = True
        tertxt.Enabled = True
        cmbVariedades.Enabled = True
        partxt.Enabled = True
        tolvastxt.Enabled = True
        polTxt.Enabled = True
        cmbCalidad.Enabled = True
        kilostxt.Enabled = True
        matriculatxt.Enabled = True
        bascTxt.Enabled = True
        rendTxt.Enabled = True

    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub editar()



        editando = True
        habilita_componentes()

        Toolbar1.Items.Item(4).Enabled = True
        Toolbar1.Items.Item(6).Enabled = True

    End Sub





    Private Sub bascTxt_KeyPress(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cmbCalidad_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        KeyAscii = 0
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub




    Private Sub cmbVariedades_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        KeyAscii = 0
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub borrar()
        Dim resultado As MsgBoxResult

        If Not tabladatos.CurrentRow Is Nothing Then

            resultado = MsgBox("¿ Desea realmente borrar el ticket ?", vbYesNo)
            If resultado = MsgBoxResult.Yes Then

                Me.LotesBDS.RemoveCurrent()
                Me.LotesBDS.EndEdit()
                Me.oLotAceituna.Update(OleosigDB1.lotesaceituna)
                Me.LotesBDS.ResetBindings(False)
                inicia_Componentes()

            End If
        End If

    End Sub


    Private Sub guardar()



        If MsgBox("¿ Desea guardar los cambios ?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            LotesBDS.EndEdit()
            oLotAceituna.Update(OleosigDB1.lotesaceituna)
            LotesBDS.ResetBindings(False)
            inicia_Componentes()
        End If
    End Sub

    Private Sub frmAdLotAceituna_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        editando = False

        oLotAceituna = New LoteAceitunaTableAdapter(Almazara.CampañaAct.Clave, Almazara.Id)
        oCSocio = New cosecheroTableAdapter(Almazara.Id)
        varDB = New variedadesTableAdapter(Almazara.Id)
        recDB = New recoleccionTableAdapter(Almazara.Id)

        varDB.Fill(OleosigDB1.variedades)
        recDB.Fill(OleosigDB1.recoleccion)

        oLotAceituna.Fill(OleosigDB1.lotesaceituna)

        tabladatos.AutoGenerateColumns = False



        calBDS.DataSource = OleosigDB1
        calBDS.DataMember = "recoleccion"

        VarBDS.DataSource = OleosigDB1
        VarBDS.DataMember = "variedades"

        cmbVariedades.DataSource = VarBDS
        cmbVariedades.DisplayMember = "varnombre"
        cmbVariedades.ValueMember = "varcodigo"

        cmbCalidad.DataSource = calBDS
        cmbCalidad.DisplayMember = "nombre"
        cmbCalidad.ValueMember = "codigo"



        Me.tabladatos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

        inicia_Componentes()

    End Sub
    Private Sub nuevo()
        Dim ultimo As UShort
        inicia_Componentes()

        Toolbar1.Items.Item(6).Enabled = True
        ultimo = oLotAceituna.getLastnumLote

        ticket = CType(LotesBDS.AddNew(), DataRowView).Row

        ticket.Idalmazara = Almazara.Id
        ticket.Campaña = Almazara.CampañaAct.clave
        ticket.Numero = ultimo + 1
        ticket.Importado = False

        habilita_componentes()
        tabladatos.Enabled = False

        LotesBDS.ResetCurrentItem()

    End Sub

    Private Sub _Toolbar1_Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button8.Click
        Me.Close()
    End Sub

    Private Sub _Toolbar1_Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button7.Click
        guardar()
    End Sub

    Private Sub _Toolbar1_Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button5.Click
        borrar()
    End Sub

    Private Sub _Toolbar1_Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button3.Click
        inicia_Componentes()
    End Sub

    Private Sub _Toolbar1_Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button2.Click
        editar()
    End Sub

    Private Sub _Toolbar1_Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button1.Click
        nuevo()
    End Sub






    Private Sub tabladatos_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tabladatos.RowEnter



        '  If Not tabladatos.CurrentRow Is Nothing Then
        'Toolbar1.Items.Item(0).Enabled = False
        Toolbar1.Items.Item(1).Enabled = True


        ticket = CType(LotesBDS.Current, DataRowView).Row


        cmbCalidad.SelectedValue = ticket.Calidad


        cmbVariedades.SelectedValue = ticket.Variedad



        '  End If

    End Sub




    Private Sub numlotetxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles numlotetxt.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub numsociotxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles numsociotxt.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tertxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tertxt.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub partxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles partxt.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub tolvastxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tolvastxt.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub kilostxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles kilostxt.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub polTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles polTxt.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub bascTxt_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles bascTxt.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub rendTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rendTxt.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub tabladatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabladatos.Click


        If Not tabladatos.CurrentRow Is Nothing Then
            'Toolbar1.Items.Item(0).Enabled = False
            Toolbar1.Items.Item(1).Enabled = True


            ticket = CType(LotesBDS.Current, DataRowView).Row

            cmbCalidad.SelectedValue = ticket.Calidad

            cmbVariedades.SelectedValue = ticket.Variedad

        End If


    End Sub


End Class