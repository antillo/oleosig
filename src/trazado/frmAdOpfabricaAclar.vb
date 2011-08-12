Option Strict Off
Option Explicit On
Friend Class frmAdOpfabricaAclar
    Inherits System.Windows.Forms.Form

    Dim detallesDB As detallesOpFabricaTableAdapter
    Dim oOpFabrica As opfabricaTableAdapter
    Dim oPartida As parAceitunaTableAdapter
    'Dim oleosigdb As oleosigDB
    Dim editando As Boolean
    Dim vslider As frmslider


    Dim nuevamolturacion As Boolean = False


    Private Sub cmbLineas_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cmbLineas.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        KeyAscii = 0
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub




    Private Sub cmbTolvas_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)

        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        KeyAscii = 0
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub






    Private Sub borrar_operacion_fabrica()
        Dim resultado As Integer


        Try

            resultado = MsgBox("Está a punto de borrar una operación de fábrica. Si contesta si, esta operación se borrará definitivamente", MsgBoxStyle.Critical Or MsgBoxStyle.YesNo)

            If resultado = MsgBoxResult.Yes Then


                moltBDS.RemoveCurrent()
                moltBDS.EndEdit()

                oOpFabrica.Update(OleosigDB1.opfabrica)

                moltBDS.ResetBindings(False)
                detallesBDS.ResetBindings(False)


                inicia_Componentes()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try



    End Sub

    Private Sub deshabilita_controles()
        cmbLineas.Enabled = False

        chkAbierta.Enabled = False

        dtfechaini.Enabled = False
        dtfechafin.Enabled = False
        tablaDetalles.Enabled = False
        tablapartidas.Enabled = False
        kilostxt.Enabled = False

    End Sub

    Private Sub habiliTa_controles()
        cmbLineas.Enabled = True

        chkAbierta.Enabled = True

        dtfechaini.Enabled = True
        dtfechafin.Enabled = True
        tablaDetalles.Enabled = True
        tablapartidas.Enabled = True
        kilostxt.Enabled = True

    End Sub


    Private Sub tablapartidas_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tablapartidas.DoubleClick

        Dim partida As oleosigDB.partidasaceitunaRow
        Dim suma As Integer


        If Not partidasBDS.Current Is Nothing Then
            partida = CType(partidasBDS.Current, DataRowView).Row
            If Len(kilostxt.Text) > 0 Then
                suma = CInt(kilostxt.Text)
            Else
                suma = 0
            End If


            If tablaDetalles.Rows.Count = 0 Then
                dtfechaini.Value = partida.FechaIniLlenado
                dtfechafin.Value = partida.FechaFinLlenado
            End If

            For Each fila As DataGridViewRow In tablaDetalles.Rows


                If fila.Cells(0).Value = partida.Numero Then
                    'tablaDetalles.Rows.Remove(fila)
                    detallesBDS.RemoveCurrent()
                    suma = suma - partida.Kilos
                    kilostxt.Text = suma.ToString
                    partida.Importada = False

                    Exit Sub

                End If

            Next
            Dim filadetallle As oleosigDB.detalles_opfabricaRow = CType(detallesBDS.AddNew, DataRowView).Row

            filadetallle.opfabrica = CType(moltBDS.Current, DataRowView)("id")
            filadetallle.idalmazara = Almazara.Id
            filadetallle.campagna = Almazara.CampañaAct.clave
            filadetallle.partida = partida.Numero
            filadetallle.kilos = partida.Kilos

            partida.Importada = True

            suma = suma + CInt(tablapartidas(4, tablapartidas.CurrentCell.RowIndex).Value)
            kilostxt.Text = suma.ToString


        End If
    End Sub



    Private Sub editar()
        nuevamolturacion = False
        editando = True
        habiliTa_controles()

        Toolbar1.Items.Item(0).Enabled = False
        Toolbar1.Items.Item(5).Enabled = True

        Toolbar1.Items.Item(6).Enabled = True



    End Sub
    '#########################################################################
    '#
    '#  Descripcion :   Inicia los componentes del formulario
    '#
    '#########################################################################
    Private Sub inicia_Componentes()
        Dim i As Integer

        nuevamolturacion = False
        editando = False
        kilostxt.Text = "0"


        'lineas
        cmbLineas.Items.Clear()
        For i = 1 To Almazara.Decanters
            cmbLineas.Items.Add(i.ToString)
        Next i
        cmbLineas.Text = "Decanter"


        Toolbar1.Items(0).Enabled = True
        Toolbar1.Items(1).Enabled = False
        Toolbar1.Items.Item(3).Enabled = True

        Toolbar1.Items.Item(5).Enabled = False

        Toolbar1.Items.Item(6).Enabled = False

        deshabilita_controles()
        borra_componentes()

        tablamolturaciones.Enabled = True



    End Sub


    Private Sub Nueva()

        nuevamolturacion = True

        Dim molturacionlocal As oleosigDB.opfabricaRow = CType(moltBDS.AddNew(), DataRowView).Row

        molturacionlocal.idalmazara = Almazara.Id
        molturacionlocal.campagna = Almazara.CampañaAct.clave
        molturacionlocal.importada = False
        molturacionlocal.abierta = False
        molturacionlocal.operacion = oOpFabrica.GetLast() + 1

        moltBDS.ResetCurrentItem()

        tablamolturaciones.Enabled = False


        Toolbar1.Items.Item(6).Enabled = True

        habiliTa_controles()


    End Sub

    Private Sub borra_componentes()
        cmbLineas.SelectedIndex = -1
        cmbLineas.Text = "Lineas"



    End Sub


    Private Sub frmAdOpfabricaAclar_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        vslider = New frmslider
        vslider.mensaje = "Cargando datos"
        vslider.StartPosition = FormStartPosition.CenterScreen
        vslider.Show(Me)

        BkWorker1.RunWorkerAsync()

        tablaDetalles.AutoGenerateColumns = False

        tablaDetalles.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

        tablamolturaciones.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)


        dtfechaini.DataBindings.Add("Value", moltBDS, "fechaini", True, DataSourceUpdateMode.OnPropertyChanged)
        dtfechafin.DataBindings.Add("Value", moltBDS, "fechafin", True, DataSourceUpdateMode.OnPropertyChanged)


        Call inicia_Componentes()

    End Sub







    '####################################################################
    '#
    '#      Descripcion : Inserta una operacion de fábrica
    '#                    con todas sus partidas de aceituna
    '#
    '###################################################################
    Private Sub Guardar()


        If tablaDetalles.Rows.Count = 0 Then
            MsgBox("Debe añadir partidas de aceituna", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If cmbLineas.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una linea de fabrica", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If kilostxt.Text.Length = 0 Then
            MsgBox("Debe introducir kilos")
            Exit Sub
        End If

        If MsgBox("¿ Desea guardar los cambios ?", MsgBoxStyle.ApplicationModal Or MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Guardar cambios") = MsgBoxResult.Yes Then
            Me.ValidateChildren()

            Dim op As oleosigDB.opfabricaRow = CType(moltBDS.Current, DataRowView).Row

            op.idalmazara = Almazara.Id
            op.campagna = Almazara.CampañaAct.clave
            op.fechaini = dtfechaini.Value
            op.fechafin = dtfechafin.Value
            op.lineafabrica = (cmbLineas.SelectedIndex + 1)
            op.abierta = chkAbierta.Checked
            op.importada = False


            Me.moltBDS.EndEdit()

            Dim id As Integer = CType(moltBDS.Current, DataRowView).Row("id")

            Me.oOpFabrica.Update(Me.OleosigDB1.opfabrica)

            Dim tabla As oleosigDB.opfabricaDataTable = oOpFabrica.GetDataByOperacion(op.operacion)





            Me.detallesBDS.Filter = "opfabrica='" & id.ToString & "'"

            For i As Integer = detallesBDS.List.Count - 1 To 0 Step -1
                CType(detallesBDS.Item(i), DataRowView)("opfabrica") = tabla.Rows(0)("id")
            Next

            Me.detallesBDS.EndEdit()
            Me.detallesDB.Update(Me.OleosigDB1.detalles_opfabrica)


            Me.moltBDS.ResetBindings(False)
            Me.detallesBDS.ResetBindings(False)

            Me.partidasBDS.EndEdit()

            Me.oPartida.Update(OleosigDB1.partidasaceituna)
        Else
            moltBDS.CancelEdit()
            detallesBDS.CancelEdit()
            partidasBDS.CancelEdit()
        End If


        inicia_Componentes()


    End Sub

    Private Sub _Toolbar1_Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button1.Click
        Nueva()
    End Sub



    Private Sub _Toolbar1_Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button2.Click
        Me.editar()
    End Sub

    Private Sub _Toolbar1_Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button8.Click
        Me.Close()
    End Sub

    Private Sub _Toolbar1_Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button6.Click
        Guardar()
    End Sub


    Private Sub _Toolbar1_Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button3.Click
        moltBDS.CancelEdit()
        detallesBDS.CancelEdit()

        moltBDS.ResetBindings(False)
        detallesBDS.ResetBindings(False)

        inicia_Componentes()
    End Sub

    Private Sub _Toolbar1_Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button5.Click
        Me.nuevamolturacion = False
        Me.editando = False
        borrar_operacion_fabrica()
    End Sub




    Private Sub BkWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BkWorker1.DoWork
        oOpFabrica = New opfabricaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        detallesDB = New detallesOpFabricaTableAdapter(Almazara.Id, Almazara.CampañaAct.clave)
        oPartida = New parAceitunaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)

    End Sub


    Private Sub BkWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BkWorker1.RunWorkerCompleted

        detallesDB.Fill(Me.OleosigDB1.detalles_opfabrica)
        oOpFabrica.Fill(Me.OleosigDB1.opfabrica)
        oPartida.Fill(Me.OleosigDB1.partidasaceituna)

        ' TolvasBindigSource.DataMember = "partidasaceituna"


        vslider.Close()


        Me.Cursor = Cursors.Default
    End Sub


    Private Sub cmdVerpartidas_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVerpartidas.Click

        If cmbTolvas.SelectedIndex <> -1 Then
            If cmbTolvas.SelectedItem.ToString.Equals("Todas") Then
                partidasBDS.Filter = ""
                Exit Sub
            End If
            partidasBDS.Filter = "Tolva=" & cmbTolvas.SelectedValue.ToString
        End If

    End Sub

    Private Sub tablamolturaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tablamolturaciones.Click

        If tablamolturaciones.RowCount > 0 Then

            Toolbar1.Items.Item(1).Enabled = True

        End If

    End Sub



    Private Sub tablaDetalles_DoubleClick(sender As System.Object, e As System.EventArgs) Handles tablaDetalles.DoubleClick
        Dim suma As Integer
        Dim partida As oleosigDB.partidasaceitunaRow
        If Me.editando Then
            If Not (tablaDetalles.CurrentRow) Is Nothing Then
                suma = CInt(kilostxt.Text)
                Dim det As oleosigDB.detalles_opfabricaRow = CType(detallesBDS.Current, DataRowView).Row

                partida = OleosigDB1.partidasaceituna.First(Function(par As oleosigDB.partidasaceitunaRow) par.Numero = det.partida)

                detallesBDS.RemoveCurrent()

                suma = suma - partida.Kilos
                kilostxt.Text = suma.ToString
                partida.Importada = False
                'tablaDetalles.Rows.Remove(tablaDetalles.CurrentRow)

            End If
        End If
    End Sub

    Private Sub BkWorker1_ProgressChanged(sender As System.Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BkWorker1.ProgressChanged
        vslider.Refresh()
    End Sub

    Private Sub tablamolturaciones_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tablamolturaciones.RowEnter
        Dim suma As Integer = 0
        Dim fila As oleosigDB.opfabricaRow

        If Not moltBDS.Current Is Nothing Then

            fila = CType(tablamolturaciones.Rows(e.RowIndex).DataBoundItem, DataRowView).Row ' CType(moltBDS.Current, DataRowView).Row

            If fila.RowState = DataRowState.Deleted Then
                Exit Sub
            End If

            cmbLineas.SelectedIndex = cmbLineas.FindString(fila.lineafabrica)
            Dim filas() As oleosigDB.detalles_opfabricaRow = fila.Getdetalles_opfabricaRows()
            For Each detalle As oleosigDB.detalles_opfabricaRow In filas
                suma += detalle.kilos
            Next
            kilostxt.Text = suma.ToString
            detallesBDS.Filter = "opfabrica='" & fila.id.ToString & "'"
        End If

    End Sub
End Class