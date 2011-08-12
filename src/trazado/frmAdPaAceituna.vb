Option Strict Off
Option Explicit On
Friend Class frmAdPaAceituna
    Inherits System.Windows.Forms.Form
	
    Dim oPartida As parAceitunaTableAdapter
    Dim oTickets As LoteAceitunaTableAdapter
    Dim calDB As recoleccionTableAdapter
    Dim varDB As variedadesTableAdapter
    Dim tolvasDB As tolvasTableAdapter

    Public editando As Boolean


    Friend Sub editarPartida()



        Me.Text = "Editar Partida de Aceituna"
        Label2.Visible = True

        Me.editando = True

        habiliTa_controles()
        Toolbar1.Items(0).Enabled = False
        Toolbar1.Items(3).Enabled = True
        Toolbar1.Items(7).Enabled = True

    End Sub

    Private Sub Nuevo()


        Dim fila As oleosigDB.partidasaceitunaRow = CType(partidaBDS.AddNew(), DataRowView).Row

        fila.Idalmazara = Almazara.Id
        fila.Campaña = Almazara.CampañaAct.clave


        numPartidaAc.Text = CStr(oPartida.Ultima + 1)
        dtfechaini.Value = Now
        dtfechafin.Value = Now
        dtfechainivac.Value = Now
        dtfechafinvac.Value = Now

        partidaBDS.ResetCurrentItem()

        Me.editando = False

        habiliTa_controles()

        _Toolbar1_Button2.Enabled = False
        _Toolbar1_Button6.Enabled = True


        Me.Text = "Añadir Partida de Aceituna"
        tablaPartidas.Enabled = False
        dtfechaini.Focus()

    End Sub




    '####################################################################
    '#
    '#          Nombre : guardarPartida
    '#          Crea una partida nueva en la base de datos o la cierra
    '#          si esta ya existe
    '#
    '####################################################################

    Private Sub guardarPartida()



        If MsgBox("¿ Desea guardar la partida ?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Me.ValidateChildren()

            partidaBDS.EndEdit()

            oPartida.Update(OleosigDB1.partidasaceituna)

            inicia_Componentes()

        End If


    End Sub




    Private Sub frmAdPaAceituna_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        tolvasDB = New tolvasTableAdapter(Almazara.Id)

        BKW.RunWorkerAsync()

        tablaPartidas.AutoGenerateColumns = False

        tablaPartidas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

        numPartidaAc.DataBindings.Add("Text", partidaBDS, "Numero", True, DataSourceUpdateMode.OnPropertyChanged)
        kilosTxt.DataBindings.Add("Text", partidaBDS, "Kilos", True, DataSourceUpdateMode.OnPropertyChanged)
        dtfechaini.DataBindings.Add("Value", partidaBDS, "FechaIniLlenado", True, DataSourceUpdateMode.OnPropertyChanged)
        dtfechafin.DataBindings.Add("Value", partidaBDS, "FechaFinLlenado", True, DataSourceUpdateMode.OnPropertyChanged)
        dtfechainivac.DataBindings.Add("Value", partidaBDS, "FechaIniVaciado", True, DataSourceUpdateMode.OnPropertyChanged)
        dtfechafinvac.DataBindings.Add("Value", partidaBDS, "FechaFinVaciado", True, DataSourceUpdateMode.OnPropertyChanged)
        chkAbierta.DataBindings.Add("Checked", partidaBDS, "Abierta", True, DataSourceUpdateMode.OnPropertyChanged)




        inicia_Componentes()
    End Sub

    '#######################################################################
    '#
    '#
    '#
    '#
    '#######################################################################
    Public Sub inicia_Componentes()


        Me.Text = "Partidas de Aceituna"

        Label2.Visible = True



        Me.editando = False



        deshabilita_controles()
        tablaPartidas.Enabled = True

        Toolbar1.Items(0).Enabled = True
        Toolbar1.Items(1).Enabled = False
        Toolbar1.Items(3).Enabled = False
        Toolbar1.Items(7).Enabled = False



    End Sub




    Private Sub deshabilita_controles()
        numPartidaAc.Enabled = False
        kilostxt.Enabled = False
        cmbTolvas.Enabled = False
        chkAbierta.Enabled = False
        dtfechaini.Enabled = False
        dtfechafin.Enabled = False
        dtfechainivac.Enabled = False
        dtfechafinvac.Enabled = False
        cmbCalidad.Enabled = False
        cmbVariedad.Enabled = False

    End Sub

    Private Sub habiliTa_controles()
        numPartidaAc.Enabled = True
        kilostxt.Enabled = True
        cmbTolvas.Enabled = True
        chkAbierta.Enabled = True
        dtfechaini.Enabled = True
        dtfechafin.Enabled = True
        dtfechafinvac.Enabled = True
        dtfechainivac.Enabled = True
        cmbCalidad.Enabled = True
        cmbVariedad.Enabled = True
    End Sub

    Private Sub kilosTxt_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles kilosTxt.KeyPress
        If Char.IsDigit(eventArgs.KeyChar) Then
            eventArgs.Handled = False
        ElseIf Char.IsControl(eventArgs.KeyChar) Then
            eventArgs.Handled = False
        Else
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub borrar_partida()

        Dim resultado As MsgBoxResult

        resultado = MsgBox("¿ Está seguro de borrar la partida ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Borrar partida de Aceituna")
        If resultado = MsgBoxResult.Yes Then
            partidaBDS.RemoveCurrent()
            partidaBDS.EndEdit()

            oPartida.Update(OleosigDB1.partidasaceituna)
            partidaBDS.ResetBindings(False)

            inicia_Componentes()


        End If
    End Sub


    Private Sub _Toolbar1_Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button8.Click
        Me.Close()
    End Sub


    Private Sub _Toolbar1_Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button1.Click
        Me.Nuevo()
    End Sub

    Private Sub _Toolbar1_Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button2.Click
        Me.editarPartida()
    End Sub

    Private Sub _Toolbar1_Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button3.Click
        Me.borrar_partida()
    End Sub

    Private Sub _Toolbar1_Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button5.Click
        partidaBDS.CancelEdit()
        Me.inicia_Componentes()
    End Sub

    Private Sub _Toolbar1_Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button6.Click
        Me.guardarPartida()
    End Sub


    Private Sub tablaPartidas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tablaPartidas.Click
        Toolbar1.Items(1).Enabled = True
    End Sub


    Private Sub dtfechaini_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtfechaini.KeyDown
        If e.KeyCode = Keys.Enter Then

        End If
    End Sub

    Private Sub BKW_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BKW.DoWork

        oPartida = New parAceitunaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        oTickets = New LoteAceitunaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        calDB = New recoleccionTableAdapter(Almazara.Id)
        varDB = New variedadesTableAdapter(Almazara.Id)

        tolvasDB.Fill(OleosigDB1.tolvas)

    End Sub

    Private Sub BKW_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BKW.RunWorkerCompleted

        calDB.Fill(OleosigDB1.recoleccion)
        varDB.Fill(OleosigDB1.variedades)
        oPartida.Fill(OleosigDB1.partidasaceituna)

        oTickets.Fill(OleosigDB1.lotesaceituna)
        tolvasBDS.ResetBindings(False)

    End Sub

    Private Sub tablaPartidas_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles tablaPartidas.DataError

    End Sub
End Class