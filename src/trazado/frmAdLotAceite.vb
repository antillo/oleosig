Option Strict Off
Option Explicit On

Friend Class frmAdLotAceite
    Dim lote As String
    Dim oLoteAc As loteAceiteTableAdapter

    Dim oMov As Oleosig.opbodegaTableAdapter
    Dim detalleslotesDB As detallesLoteAceiteTableAdapter
    Dim detallesOpbdgDB As detallesOpBdgTableAdapter
    Dim tanquesDB As depositosTableAdapter
    Dim mvarTanque As Short
    Dim indiceTab As Short
    Dim editando As Boolean = False
    Dim nuevolote As Boolean = False

    Dim iniciando As Boolean
    Dim vslider As frmslider

    Public WriteOnly Property Tanque() As Short
        Set(ByVal Value As Short)
            mvarTanque = Value
        End Set
    End Property



    Private Sub cmbtanques_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        KeyAscii = 0
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub kilosTxt_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii < 48 Or KeyAscii > 57 Then
            If KeyAscii <> 8 Then
                KeyAscii = 0
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub




    Private Sub tablalotes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tablalotes.Click
        Try
            If Not tablalotes.CurrentRow Is Nothing Then

                Toolbar1.Items.Item(1).Enabled = True


            End If
        Catch ex As Exception
        End Try

    End Sub


    Private Sub borrar()
        Dim result As MsgBoxResult

        If editando = True Then
            result = MsgBox("¿Desea borrar el lote ?" & vbCrLf & "Esta acción no se puede deshacer", MsgBoxStyle.Critical + MsgBoxStyle.YesNo)
            If result = MsgBoxResult.Yes Then

                LotesBDS.RemoveCurrent()
                LotesBDS.EndEdit()
                oLoteAc.Update(OleosigDB1.loteaceite)
                LotesBDS.ResetBindings(False)
                inicia_Componentes()

            Else
                Exit Sub
            End If
        Else
            MsgBox("Debe estar editando un lote para poder borrarlo", MsgBoxStyle.Information)
        End If

    End Sub
    Private Sub Abre_Lote()


    End Sub


    Private Sub editar()

        editando = True
        nuevolote = False

        habiliTa_controles()
        Toolbar1.Items.Item(0).Enabled = False
        Toolbar1.Items.Item(5).Enabled = True

        Toolbar1.Items.Item(7).Enabled = True
        opbodegaBDS.RemoveFilter()

    End Sub



    Private Sub deshabilita_controles()

        lotetxt.Enabled = False
        cmbtanques.Enabled = False
        kilostxt.Enabled = False
        dtfechaini.Enabled = False
        dtfechafin.Enabled = False

    End Sub


    Private Sub habiliTa_controles()

        lotetxt.Enabled = True
        cmbtanques.Enabled = True
        kilostxt.Enabled = True
        dtfechaini.Enabled = True
        dtfechafin.Enabled = True

        lotetxt.ReadOnly = False

    End Sub
    Private Sub nuevo()

        editando = False
        nuevolote = True

        Dim newlote As oleosigDB.loteaceiteRow = CType(LotesBDS.AddNew(), DataRowView).Row

        newlote.Campaña = Almazara.CampañaAct.clave
        newlote.Idalmazara = Almazara.Id
        newlote.Importado = False


        Toolbar1.Items(0).Enabled = False
        Toolbar1.Items.Item(1).Enabled = False
        Toolbar1.Items.Item(5).Enabled = False
        Toolbar1.Items.Item(7).Enabled = True


        habiliTa_controles()

        tablalotes.Enabled = False


        Me.dtfechaini.Text = Now
        Me.dtfechafin.Text = Now


        kilostxt.Text = "0"


    End Sub

    Private Sub Command16_Click()
        Me.Close()
    End Sub

   

    Private Sub frmAdLotAceite_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Me.Load
        bkworker1.RunWorkerAsync()

        Me.vslider = New frmslider

        vslider.mensaje = "Cargando datos"
        vslider.Show(Me)
      

        Me.tablalotes.RowHeadersVisible = False
        tablalotes.AutoGenerateColumns = False

        entradasac.RowHeadersVisible = False
        entradasac.AutoGenerateColumns = False

       

       

        lblId.DataBindings.Add(New Binding("Text", LotesBDS, "id", True, DataSourceUpdateMode.Never))
        lotetxt.DataBindings.Add(New Binding("Text", LotesBDS, "Nombre", True, DataSourceUpdateMode.OnPropertyChanged))
        dtfechaini.DataBindings.Add(New Binding("Value", LotesBDS, "FechaInicial", True, DataSourceUpdateMode.OnPropertyChanged))
        dtfechafin.DataBindings.Add(New Binding("Value", LotesBDS, "FechaFinal", True, DataSourceUpdateMode.OnPropertyChanged))
        ' chkAbierto.DataBindings.Add(New Binding("Checked", LotesBDS, "Abierto", True, DataSourceUpdateMode.OnPropertyChanged))


        inicia_Componentes()
    End Sub

    Public Sub inicia_Componentes()

        indiceTab = 1
        editando = False
        nuevolote = False

        deshabilita_controles()

        tablalotes.Enabled = True

        Toolbar1.Items.Item(0).Enabled = True
        Toolbar1.Items.Item(1).Enabled = False

        Toolbar1.Items.Item(5).Enabled = False

        Toolbar1.Items.Item(7).Enabled = False

        LotesBDS.ResetBindings(False)

        opbodegaBDS.RemoveFilter()

        ' tabladetalles.Rows.Clear()

    End Sub


    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.nuevo()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Me.editar()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        LotesBDS.CancelEdit()
        Me.opbodegaBDS.CancelEdit()
        detallesBDS.CancelEdit()

        oLoteAc.Fill(OleosigDB1.loteaceite)
        inicia_Componentes()
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Me.borrar()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If lotetxt.Text.Length = 0 Then
            MsgBox("Debe introducir un nombre de lote")
            Exit Sub
        End If


        If dtfechaini.Value >= dtfechafin.Value Then
            MsgBox("La fecha inicial debe ser anterior a la fecha final", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If cmbtanques.SelectedIndex < 0 Then
            MsgBox("Debe seleccionar un depósito de aceite")
            Exit Sub
        End If

        If MsgBox("Desea guardar los datos ?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then

            Me.ValidateChildren()

            If editando = True Then

                LotesBDS.EndEdit()

                Me.oLoteAc.Update(OleosigDB1.loteaceite)

                detallesBDS.EndEdit()
                detalleslotesDB.Update(OleosigDB1.detalles_loteaceite)

            Else

                Dim lote As oleosigDB.loteaceiteRow = CType(LotesBDS.Current, DataRowView).Row

                lote.FechaInicial = dtfechaini.Value
                lote.FechaFinal = dtfechafin.Value
                lote.Tanque = cmbtanques.SelectedValue
                lote.Abierto = chkAbierto.Checked

                Dim newid As Integer = oLoteAc.Insert(lote.Idalmazara, lote.Nombre, lote.Tanque, lote.FechaInicial, lote.FechaFinal, lote.Importado, lote.Campaña, lote.Abierto)

                Dim vistadetalles As DataView = New DataView(OleosigDB1.detalles_loteaceite)

                vistadetalles.RowFilter = "Loteaceite='" & lote.Id & "'"

                For i As Integer = vistadetalles.Count - 1 To 0 Step -1
                    vistadetalles(i).BeginEdit()
                    vistadetalles(i)("Loteaceite") = newid
                    vistadetalles(i).EndEdit()
                Next

                detalleslotesDB.Update(OleosigDB1.detalles_loteaceite)

                LotesBDS.EndEdit()

               
            End If

            opbodegaBDS.EndEdit()
            oMov.Update(OleosigDB1.opbodega)

            inicia_Componentes()
        Else

            LotesBDS.CancelEdit()
            detallesBDS.CancelEdit()
            opbodegaBDS.CancelEdit()
        End If


    End Sub


    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub kilostxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kilostxt.TextChanged

    End Sub


    Private Sub tabladetalles_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabladetalles.DoubleClick
        If editando Or nuevolote Then
            If tabladetalles.CurrentRow IsNot Nothing Then
                kilostxt.Text = (CInt(kilostxt.Text) - tabladetalles.CurrentRow.Cells(1).Value).ToString
                If Val(kilostxt.Text) < 0 Then
                    kilostxt.Text = "0"
                End If
                tabladetalles.Rows.Remove(tabladetalles.Rows(tabladetalles.CurrentCell.RowIndex))
            End If
        End If
    End Sub

    Private Sub entradasac_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles entradasac.DoubleClick
        Dim detalle As oleosigDB.detalles_loteaceiteRow

        If Not opbodegaBDS.Current Is Nothing Then
            Dim entradAceite As oleosigDB.opbodegaRow = CType(opbodegaBDS.Current, DataRowView).Row

            If cmbtanques.SelectedValue <> entradAceite.Tanque Then
                MsgBox("El deposito seleccionado no coincide con el deposito de la entrada de aceite")
                Exit Sub
            End If
            
            Try

                detalle = OleosigDB1.detalles_loteaceite.First(Function(lo As oleosigDB.detalles_loteaceiteRow) lo.opbodega = entradAceite.Operacion)

                kilostxt.Text = CInt(kilostxt.Text) - detalle.kilos
                If Val(kilostxt.Text) < 0 Then
                    kilostxt.Text = "0"
                End If
                detalle.Delete()
                detallesBDS.ResetBindings(False)
                entradAceite.Importada = False

            Catch ex As Exception
                If entradAceite.Importada = True Then
                    If MsgBox("La operación de bodega ya está siendo usada." & vbCrLf & "¿ Desea añadirla de todas formas ?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation) = MsgBoxResult.No Then
                        Exit Sub
                    End If
                End If
                Dim entradas As oleosigDB.detalles_opbodegaRow() = entradAceite.Getdetalles_opbodegaRows()
                Dim total As Integer = 0
                For Each filent As oleosigDB.detalles_opbodegaRow In entradas
                    total += filent.Kilos
                Next
                detalle = CType(detallesBDS.AddNew(), DataRowView).Row

                detalle.idalmazara = Almazara.Id
                detalle.Campaña = Almazara.CampañaAct.clave
                detalle.kilos = total
                detalle.opbodega = entradAceite.Operacion
                detalle.loteaceite = CType(LotesBDS.Current, DataRowView).Row("id")
                detallesBDS.ResetBindings(False)
                detallesBDS.MoveFirst()

                kilostxt.Text = (CInt(kilostxt.Text) + total).ToString

                entradAceite.Importada = True

            End Try

            opbodegaBDS.ResetBindings(False)

        End If

    End Sub

    Private Sub cmbtanques_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtanques.SelectedIndexChanged
        If Not iniciando Then
            If nuevolote Then
                opbodegaBDS.Filter = "tanque ='" & cmbtanques.SelectedValue.ToString & "'"
            End If
        End If
    End Sub

   

    Private Sub bkworker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bkworker1.DoWork
        
        oLoteAc.Fill(OleosigDB1.loteaceite)
        oMov.Fill(OleosigDB1.opbodega)

        detalleslotesDB.Fill(OleosigDB1.detalles_loteaceite)
        detallesOpbdgDB.Fill(OleosigDB1.detalles_opbodega)
        tanquesDB.Fill(OleosigDB1.tanques)


    End Sub

    Private Sub bkworker1_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bkworker1.RunWorkerCompleted
       
        Me.vslider.Close()
        opbodegaBDS.ResetBindings(False)
        LotesBDS.ResetBindings(False)
        tanquesBDS.ResetBindings(False)
        detallesBDS.ResetBindings(False)

    End Sub

    Private Sub entradasac_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles entradasac.CellFormatting
        Dim dgv As DataGridView

        If e.ColumnIndex = 1 Then
            dgv = CType(sender, DataGridView)
            Dim fila As oleosigDB.opbodegaRow = CType(dgv.Rows(e.RowIndex).DataBoundItem, DataRowView).Row
            If fila.Importada Then
                dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Yellow
            Else
                dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            End If
        End If
    End Sub

    Private Sub tablalotes_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tablalotes.RowEnter
        Dim suma As Integer = 0
        If Not LotesBDS.Current Is Nothing Then

            Dim fila As oleosigDB.loteaceiteRow = CType(tablalotes.Rows(e.RowIndex).DataBoundItem, DataRowView).Row

            detallesBDS.Filter = "loteaceite='" & fila.Id & "'"

            Dim vista As DataView = CType(detallesBDS.List, DataView)

            For i As Integer = 0 To vista.Count - 1
                Dim detalle As oleosigDB.detalles_loteaceiteRow = vista(i).Row

                suma += detalle.kilos

            Next i

            Me.kilostxt.Text = suma.ToString

        End If
    End Sub

    Private Sub tablalotes_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles tablalotes.DataError

    End Sub
End Class