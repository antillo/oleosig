Option Strict Off
Option Explicit On
Public Class frmAdparAceite
    Inherits System.Windows.Forms.Form

    Dim oClientes As clientesTableAdapter
    Dim oLotAc As loteAceiteTableAdapter
    Dim oPartidas As partAceiteTableAdapter
    Dim detallesPArDB As detallesPartidasAceiteTablaAdapter
    Dim vslider As frmslider
    Dim editando As Boolean




    Private Sub cmbTipo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        KeyAscii = 0
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub


    Private Sub inicia_Componentes()


        dtFecha.Value = Now
        editando = False


        deshabilita_controles()

        barramenu.Items.Item(0).Enabled = True
        barramenu.Items.Item(1).Enabled = False
        barramenu.Items.Item(5).Enabled = False
        barramenu.Items.Item(7).Enabled = False

        numpartidaTxt.BringToFront()

        cmbTipo.SelectedIndex = -1
        cmbTipo.Text = "Tipo"


    End Sub

    Private Sub frmAdparAceite_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        dtFecha.Value = Now

        vslider = New frmslider
        vslider.mensaje = "Cargando datos"
        vslider.Show(Me)

        Me.tablaLotes.AutoGenerateColumns = False
        Me.tablaPartidas.AutoGenerateColumns = False
        Me.tabladetalles.AutoGenerateColumns = False

        bkworker.RunWorkerAsync()



        cmbTipo.Items.Add("Venta")
        cmbTipo.Items.Add("Envasado")

        inicia_Componentes()

    End Sub






    Private Sub nuevo()
        barramenu.Items.Item(0).Enabled = False
        barramenu.Items.Item(1).Enabled = False
        barramenu.Items.Item(7).Enabled = True

        Dim partida As oleosigDB.partidasaceiteRow = CType(partidasBDS.AddNew, DataRowView).Row
        partida.Idalmazara = Almazara.Id
        partida.Campaña = Almazara.CampañaAct.clave


        habiliTa_controles()

        partida.Numero = oPartidas.getLastPartida() + 1

        partidasBDS.ResetCurrentItem()

        editando = False


    End Sub


    Private Sub borrar()
        Dim result As MsgBoxResult

        result = MsgBox("Desea borrar la partida", MsgBoxStyle.YesNo Or MsgBoxStyle.Critical)
        If result = MsgBoxResult.Yes Then

            partidasBDS.RemoveCurrent()
            partidasBDS.EndEdit()
            oPartidas.Update(OleosigDB1.partidasaceite)

            inicia_Componentes()
        End If

    End Sub

    '################################################################################
    '#
    '#      subrutina llamada cuando pulsas editar
    '#
    '################################################################################
    Private Sub editar()

        habiliTa_controles()
        editando = True

        barramenu.Items.Item(0).Enabled = False
        barramenu.Items.Item(5).Enabled = True
        barramenu.Items.Item(7).Enabled = True

    End Sub

    '################################################################################
    '#
    '#      subrutina llamada cuando pulsas cancelar
    '#
    '################################################################################
    Private Sub cancelar()
        partidasBDS.CancelEdit()
        detallesBDS.CancelEdit()
        inicia_Componentes()

    End Sub

    ''' <summary>
    ''' Guarda en la base de datos las partidas creadas o modificadas
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub guardar()
        Dim entidad As oleosigDB.partidasaceiteRow
        Dim result As MsgBoxResult
        Dim old_id As Integer


        If cmbTipo.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un tipo de partida")
            Exit Sub
        End If


        result = MsgBox("Desea guardar la partida", MsgBoxStyle.YesNo Or MsgBoxStyle.Question)

        If result = MsgBoxResult.Yes Then
            entidad = CType(partidasBDS.Current, DataRowView).Row

            entidad.Tipo = cmbTipo.SelectedIndex + 1
            entidad.Fecha = dtFecha.Value

            old_id = entidad.Id

            Me.ValidateChildren()

            Select Case editando

                Case True

                    partidasBDS.EndEdit()
                    oPartidas.Update(OleosigDB1.partidasaceite)

                    detallesBDS.EndEdit()
                    detallesPArDB.Update(OleosigDB1.detalles_partidasaceite)
                    lotesBDS.EndEdit()
                    oLotAc.Update(OleosigDB1.loteaceite)

                Case False

                    Dim id As Integer = oPartidas.Insert(entidad.Idalmazara, entidad.Fecha, entidad.Tipo, entidad.Comentarios, entidad.Numero, entidad.Campaña)

                    Dim vistadetalles As DataView = New DataView(OleosigDB1.detalles_partidasaceite)

                    vistadetalles.RowFilter = "Idpartida='" & old_id.ToString & "'"

                    For i As Integer = vistadetalles.Count - 1 To 0 Step -1
                        vistadetalles(i).BeginEdit()
                        vistadetalles(i)("Idpartida") = id
                        vistadetalles(i).EndEdit()
                    Next i

                    detallesPArDB.Update(OleosigDB1.detalles_partidasaceite)
                    partidasBDS.EndEdit()

                    lotesBDS.EndEdit()
                    oLotAc.Update(OleosigDB1.loteaceite)
            End Select


            deshabilita_controles()



            inicia_Componentes()
        End If
    End Sub


    '################################################################################
    '#
    '#      deshabilita los textbox y los combobox
    '#
    '################################################################################
    Private Sub deshabilita_controles()

        Me.numpartidaTxt.Enabled = False
        kilosTxt.Enabled = False

        dtFecha.Enabled = False
        cmbTipo.Enabled = False
        comentstxt.Enabled = False

        tablaLotes.Enabled = False

    End Sub

    '################################################################################
    '#
    '#      habilita los controles
    '#
    '################################################################################
    Private Sub habiliTa_controles()

        Me.numpartidaTxt.Enabled = True
        kilosTxt.Enabled = True

        dtFecha.Enabled = True
        cmbTipo.Enabled = True
        comentstxt.Enabled = True

        tablaLotes.Enabled = True

    End Sub



    Private Sub _barramenu_Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _barramenu_Button1.Click
        Me.nuevo()
    End Sub

    Private Sub _barramenu_Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _barramenu_Button2.Click
        Me.editar()
    End Sub

    Private Sub _barramenu_Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _barramenu_Button3.Click
        Me.partidasBDS.CancelEdit()
        Me.detallesBDS.CancelEdit()
        OleosigDB1.detalles_partidasaceite.RejectChanges()
        Me.inicia_Componentes()
    End Sub

    Private Sub _barramenu_Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _barramenu_Button5.Click
        Me.borrar()
    End Sub

    Private Sub _barramenu_Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _barramenu_Button7.Click
        Me.guardar()
    End Sub

    Private Sub _barramenu_Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _barramenu_Button9.Click
        Me.Close()
    End Sub



    Private Sub tablaLotes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tablaLotes.DoubleClick
        If Me.tablaLotes.RowCount > 0 Then
            Dim lote As oleosigDB.loteaceiteRow = CType(lotesBDS.Current, DataRowView).Row

            Dim partida As oleosigDB.partidasaceiteRow = CType(partidasBDS.Current, DataRowView).Row

            'Dim detalles As DataView = New DataView(OleosigDB1.detalles_partidasaceite)
            Dim detalles As DataView = CType(detallesBDS.List, DataView)
            ' detalles.RowStateFilter = DataViewRowState.Added


            detalles.Sort = "Lote"
            Dim rslt As Integer = detalles.Find(lote.Id)

            If rslt = -1 Then
                Dim ventana As frmAddDetallePartida
                ventana = New frmAddDetallePartida

                Dim kilos As Integer = 0
                If ventana.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    kilos = CInt(ventana.TextBox1.Text)
                Else
                    Exit Sub
                End If


                Dim detalle As oleosigDB.detalles_partidasaceiteRow = OleosigDB1.detalles_partidasaceite.Newdetalles_partidasaceiteRow
                detalle.BeginEdit()
                detalle.Campaña = Almazara.CampañaAct.clave
                detalle.Idalmazara = Almazara.Id
                detalle.Idpartida = partida.Id
                detalle.Lote = lote.Id
                detalle.Kilos = kilos
                detalle.EndEdit()
                OleosigDB1.detalles_partidasaceite.Adddetalles_partidasaceiteRow(detalle)

                detallesBDS.ResetBindings(False)
                detallesBDS.MoveFirst()
                lote.Importado = True
            Else
                detalles.Delete(rslt)
                lote.Importado = False
            End If

        End If
    End Sub


    Private Sub bkworker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bkworker.DoWork
        detallesPArDB = New detallesPartidasAceiteTablaAdapter(Almazara.Id, Almazara.CampañaAct.clave)
        oPartidas = New partAceiteTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        oLotAc = New loteAceiteTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
    End Sub

    Private Sub bkworker_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bkworker.RunWorkerCompleted
        detallesPArDB.Fill(OleosigDB1.detalles_partidasaceite)
        oPartidas.Fill(OleosigDB1.partidasaceite)
        oLotAc.Fill(OleosigDB1.loteaceite)

        vslider.Close()
    End Sub

  
    

    Private Sub tablaPartidas_Click(sender As System.Object, e As System.EventArgs) Handles tablaPartidas.Click
        If tablaPartidas.RowCount > 0 Then
            Me._barramenu_Button2.Enabled = True
        End If

    End Sub

    
    Private Sub tablaPartidas_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tablaPartidas.RowEnter
        Dim detalles() As oleosigDB.detalles_partidasaceiteRow
        Dim suma As Integer = 0

        If tablaPartidas.CurrentRow IsNot Nothing Then
            Dim fila As oleosigDB.partidasaceiteRow = CType(tablaPartidas.Rows(e.RowIndex).DataBoundItem, DataRowView).Row
            detallesBDS.Filter = "Idpartida='" & fila.Id.ToString & "'"
            cmbTipo.SelectedIndex = fila.Tipo - 1
            detalles = fila.Getdetalles_partidasaceiteRows

            For Each detalle As oleosigDB.detalles_partidasaceiteRow In detalles
                suma += detalle.Kilos
            Next
            kilosTxt.Text = suma.ToString
        End If
    End Sub
End Class