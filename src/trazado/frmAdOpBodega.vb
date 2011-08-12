Option Strict Off
Option Explicit On

Imports System.Data.Linq
Imports System.Data.DataTableExtensions
Imports System.Data.DataRowExtensions
Imports System.Data.EnumerableRowCollection(Of System.Data.DataRow)
Imports Oleosig

Public Class frmAdOpBodega
    Inherits System.Windows.Forms.Form

    Dim oMolturDB As opfabricaTableAdapter
    Dim oOpbodega As opbodegaTableAdapter

    Dim detallesMoltDB As detallesOpFabricaTableAdapter
    Dim detallesOpbdgDB As detallesOpBdgTableAdapter

    Dim partidasDB As parAceitunaTableAdapter
    Dim varDB As variedadesTableAdapter


    Dim editando As Boolean
    Dim nuevaop As Boolean
    Dim vslider As frmslider
    Dim vDetalles As frmAddDetalleopbodega

    Private opEditar As String



    Private Sub habiliTa_controles()
        cmbtanques.Enabled = True
        kilostxt.Enabled = True
        dtfechaini.Enabled = True
        dtfechafin.Enabled = True
        tabladetalles.Enabled = True
        tablaMolts.Enabled = True
        chkAbierta.Enabled = True
        totalAceitunaTxt.Enabled = True
    End Sub
    Private Sub deshabilita_controles()
        cmbtanques.Enabled = False
        kilostxt.Enabled = False
        dtfechaini.Enabled = False
        dtfechafin.Enabled = False
        tabladetalles.Enabled = False
        tablaMolts.Enabled = False
        chkAbierta.Enabled = False
        totalAceitunaTxt.Enabled = False
    End Sub

    Private Sub vacia_controles()

        cmbtanques.SelectedIndex = -1
        cmbtanques.Text = "Depósito"
        kilostxt.Text = "0"



        tabladetalles.Rows.Clear()

    End Sub
    Private Sub nuevo()

        inicia_Componentes()
        habiliTa_controles()

        nuevaop = True
        editando = False

        Dim op As oleosigDB.opbodegaRow = CType(opbdgBDS.AddNew, DataRowView).Row

        Toolbar1.Items.Item(0).Enabled = False
        Toolbar1.Items.Item(1).Enabled = False

        Toolbar1.Items.Item(6).Enabled = True

        tablaopbdg.Enabled = False

        op.Idalmazara = Almazara.Id
        op.Operacion = oOpbodega.GetLastNumOp() + 1
        op.Campaña = Almazara.CampañaAct.clave
        op.Abierta = False
        op.Importada = False
        op.Tipo = 1
        op.Destino = "Bodega"



        opbdgBDS.ResetCurrentItem()


    End Sub


    Private Sub frmAdOpBodega_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        vslider = New frmslider
        vslider.mensaje = "Cargando Datos"

        vslider.Show(Me)
        partidasDB = New parAceitunaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)

        BackgroundWorker1.RunWorkerAsync()


        vslider.Refresh()

        listaVariedades.DataSource = OleosigDB1.variedades
        listaVariedades.DisplayMember = "varnombre"
        listaVariedades.ValueMember = "varcodigo"


        rendtxt.Text = My.Settings.rendopbodega.ToString

        lbloperacion.DataBindings.Add(New Binding("Text", opbdgBDS, "Operacion", True, DataSourceUpdateMode.OnValidation))
        chkAbierta.DataBindings.Add(New Binding("Checked", opbdgBDS, "Abierta", True, DataSourceUpdateMode.OnValidation))
        dtfechaini.DataBindings.Add(New Binding("Value", opbdgBDS, "FechaInicial", True, DataSourceUpdateMode.OnValidation))
        dtfechafin.DataBindings.Add(New Binding("Value", opbdgBDS, "FechaFinal", True, DataSourceUpdateMode.OnValidation))



        inicia_Componentes()


    End Sub

    Private Sub editar()
        editando = True
        nuevaop = False

        Call habiliTa_controles()

        Toolbar1.Items.Item(0).Enabled = False

        Toolbar1.Items.Item(6).Enabled = True

        Toolbar1.Items.Item(4).Enabled = True
        tablaopbdg.Enabled = False

    End Sub




    '#########################################################################
    '#
    '#
    '#
    '#########################################################################
    Private Sub inicia_Componentes()

        chkVerSoloNoImp.Checked = True
        kilostxt.Text = "0"
        totalAceitunaTxt.Text = "0"

        editando = False
        nuevaop = False


        System.Windows.Forms.Application.DoEvents()

        Toolbar1.Items.Item(0).Enabled = True

        Toolbar1.Items.Item(1).Enabled = False

        Toolbar1.Items.Item(4).Enabled = False

        Toolbar1.Items.Item(6).Enabled = False

        tablaopbdg.Enabled = True


        Call deshabilita_controles()
        Call vacia_controles()

        tablaopbdg.Enabled = True



    End Sub


    Private Sub kilosTxt_KeyPress(ByVal eventSender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles kilostxt.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            If AscW(e.KeyChar) = CInt(Keys.Enter) Then

                If kilostxt.Text.Length = 0 Then
                    kilostxt.Text = "0"
                End If

                If totalAceitunaTxt.Text.Length > 0 And Val(totalAceitunaTxt.Text) > 0 Then
                    rendtxt.Text = (Val(kilostxt.Text) / Val(totalAceitunaTxt.Text) * 100.0).ToString
                End If

                SendKeys.Send("{TAB}")
            End If
        Else

            e.Handled = True

        End If
    End Sub


    Private Sub borra_op_bodega()

        Dim resultado As Integer


        Dim fila As DataRow = CType(tablaopbdg.CurrentRow.DataBoundItem, DataRowView).Row
        Dim idop = fila("id")

        resultado = MsgBox("Está a punto de borrar lo operación de bodega " & idop & Chr(13) & "Si contesta si, esta operación se borrará definitivamente", MsgBoxStyle.Critical Or MsgBoxStyle.YesNo)

        If resultado = MsgBoxResult.Yes And editando Then
            opbdgBDS.RemoveCurrent()
            opbdgBDS.EndEdit()
            oOpbodega.Update(OleosigDB1.opbodega)
            inicia_Componentes()
        End If

    End Sub


    Private Sub tabladatos_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tablaMolts.DoubleClick
        Dim i As Short

        Dim suma As Integer
        Dim sumaAceituna As Integer

        suma = CInt(kilostxt.Text)
        sumaAceituna = CInt(totalAceitunaTxt.Text)

        If tablaMolts.RowCount >= 1 Then
            Dim filabdg As oleosigDB.opbodegaRow = CType(opbdgBDS.Current, DataRowView).Row
            Dim fila As oleosigDB.opfabricaRow = CType(tablaMolts.Rows(tablaMolts.CurrentCell.RowIndex).DataBoundItem, DataRowView).Row


            Try
                Dim detbdg As oleosigDB.detalles_opbodegaRow = OleosigDB1.detalles_opbodega.First(Function(op As oleosigDB.detalles_opbodegaRow) op.Opfabrica = fila.operacion)

                suma = suma - detbdg.Kilos
                kilostxt.Text = suma.ToString
                fila.importada = False
                detbdg.Delete()


                If tabladetalles.RowCount > 0 Then
                    For i = tabladetalles.RowCount - 1 To 0 Step -1

                        If tabladetalles(0, i).Value = fila.operacion Then
                            sumaAceituna = sumaAceituna - CInt(tabladetalles(2, i).Value)
                            tabladetalles.Rows.RemoveAt(i)
                            totalAceitunaTxt.Text = sumaAceituna.ToString

                            Exit Sub
                        End If

                    Next i

                End If

            Catch

                Dim filasdetalles() As oleosigDB.detalles_opfabricaRow = fila.Getdetalles_opfabricaRows
                Dim kilostmp As Integer = 0

                For Each filadetalles As oleosigDB.detalles_opfabricaRow In filasdetalles
                    kilostmp += filadetalles.kilos
                Next
                Dim kilosaceitetmp As Integer = kilostmp
                sumaAceituna += kilostmp
                kilostmp = CInt(kilostmp * Val(rendtxt.Text) / 100.0)

                Dim detalleOpbdg As oleosigDB.detalles_opbodegaRow = OleosigDB1.detalles_opbodega.Newdetalles_opbodegaRow()

                detalleOpbdg.Idalmazara = Almazara.Id
                detalleOpbdg.Opbodega = filabdg.Id
                detalleOpbdg.Campaña = Almazara.CampañaAct.clave
                detalleOpbdg.Opfabrica = fila.operacion
                detalleOpbdg.Opfiltrado = 0
                detalleOpbdg.Opaclarado = 0
                detalleOpbdg.Kilos = kilostmp

                OleosigDB1.detalles_opbodega.Adddetalles_opbodegaRow(detalleOpbdg)

                tabladetalles.Rows.Add(fila.operacion, kilostmp, kilosaceitetmp)
                suma += kilostmp
                Me.kilostxt.Text = suma.ToString
                Me.totalAceitunaTxt.Text = sumaAceituna.ToString
                fila.importada = True

            End Try

            moltBDS.ResetBindings(False)



        End If

    End Sub




    Private Sub guardar()

        Me.ValidateChildren()

        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto fechaini. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If dtfechaini.Value > dtfechafin.Value Then
            MsgBox("Debe seleccionar una fecha inicial anterior o igual a la final")
            Exit Sub
        End If

        If cmbtanques.SelectedIndex = -1 Then
            MsgBox("Debe seleccinar un depósito")
            Exit Sub
        End If

        If Len(kilostxt.Text) = 0 Then
            MsgBox("Debe introducir kilos de aceite")
            Exit Sub
        End If
        If MsgBox("¿ Desea guardar los cambios ?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then


            Dim op As oleosigDB.opbodegaRow = CType(opbdgBDS.Current, DataRowView).Row

            op.Tanque = cmbtanques.SelectedValue
            op.FechaInicial = dtfechaini.Value
            op.FechaFinal = dtfechafin.Value
            op.Abierta = chkAbierta.Checked


            Dim old_id As Integer = op.Id


            If nuevaop Then 'If op.RowState = DataRowState.Added Then
                opbdgBDS.EndEdit()
                'op.Id = oOpbodega.Insert(op.Idalmazara, op.Operacion, op.FechaInicial, op.FechaFinal, op.Tanque, op.Tipo, op.Destino, op.Campaña, op.Abierta, op.Importada)
                oOpbodega.Update(OleosigDB1.opbodega)

                Dim tabla As oleosigDB.opbodegaDataTable = oOpbodega.GetDataByOperacion(op.Operacion)
                If tabla.Rows.Count > 0 Then
                    op = tabla.Rows(0)
                    Dim vistadetalls As New DataView(OleosigDB1.detalles_opbodega)

                    vistadetalls.RowFilter = "Opbodega='" & old_id.ToString & "'"

                    For i As Integer = vistadetalls.Count - 1 To 0 Step -1
                        vistadetalls(i).BeginEdit()
                        vistadetalls(i)("Opbodega") = op.Id
                        vistadetalls(i).EndEdit()
                    Next i

                    detallesOpbdgDB.Update(OleosigDB1.detalles_opbodega)
                    OleosigDB1.detalles_opbodega.AcceptChanges()


                End If
            ElseIf editando Then 'op.RowState = DataRowState.Modified Then
                opbdgBDS.EndEdit()
                oOpbodega.Update(OleosigDB1.opbodega)

                detallesOpbdgDB.Update(OleosigDB1.detalles_opbodega)
                OleosigDB1.detalles_opbodega.AcceptChanges()

                opbdgBDS.ResetBindings(False)
            End If


            moltBDS.EndEdit()

            Me.oMolturDB.Update(OleosigDB1.opfabrica)

            opbdgBDS.ResetBindings(False)

            inicia_Componentes()
        Else
            oOpbodega.Fill(OleosigDB1.opbodega)

            moltBDS.CancelEdit()
        End If

    End Sub

    Private Sub _Toolbar1_Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button1.Click
        Me.nuevo()
    End Sub

    Private Sub _Toolbar1_Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button2.Click
        Me.editar()
    End Sub

    Private Sub _Toolbar1_Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button3.Click
        OleosigDB1.opbodega.RejectChanges()
        OleosigDB1.detalles_opbodega.RejectChanges()

        Me.oOpbodega.Fill(OleosigDB1.opbodega)
        Me.detallesOpbdgDB.Fill(OleosigDB1.detalles_opbodega)

        Me.moltBDS.CancelEdit()
        Me.detalles_moltBDS.CancelEdit()

        Me.inicia_Componentes()
    End Sub

    Private Sub _Toolbar1_Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button5.Click
        Me.borra_op_bodega()
    End Sub

    Private Sub _Toolbar1_Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button7.Click
        Me.guardar()
    End Sub

    Private Sub _Toolbar1_Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button9.Click
        Me.Close()
    End Sub

    Private Sub tablaopbdg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tablaopbdg.Click


        If Not tablaopbdg.CurrentRow Is Nothing Then

            Toolbar1.Items.Item(1).Enabled = True
        End If

    End Sub

    Private Sub rendtxt_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rendtxt.Validated
        My.Settings.Save()
        For Each fila As DataGridViewRow In tabladetalles.Rows
            fila.Cells(1).Value = CInt((fila.Cells(2).Value * Val(rendtxt.Text)) / 100.0)
        Next
        kilostxt.Text = CInt(Val(totalAceitunaTxt.Text) * Val(rendtxt.Text) / 100.0)
    End Sub


    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        varDB.Fill(OleosigDB1.variedades)
        detallesMoltDB.Fill(OleosigDB1.detalles_opfabrica)
        oMolturDB.Fill(OleosigDB1.opfabrica)
        detallesOpbdgDB.Fill(OleosigDB1.detalles_opbodega)
        oOpbodega.Fill(OleosigDB1.opbodega)

        vslider.Close()
    End Sub

    Private Sub moltBDS_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles moltBDS.CurrentChanged
        Dim fila As oleosigDB.opfabricaRow
        If Not (moltBDS.Current) Is Nothing Then
            fila = CType(moltBDS.Current, DataRowView).Row
            detalles_moltBDS.Filter = "opfabrica='" & fila.id.ToString & "'"

        Else
            detalles_moltBDS.Filter = "opfabrica='-1'"
        End If
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim vars As New System.Collections.Generic.List(Of Integer)
        Dim parts As New System.Collections.Generic.List(Of Integer)
        Dim totalKilos As Integer = 0
        Dim totalkilosusados As Integer = 0

        Dim filtro As New System.Text.StringBuilder
        If listaVariedades.CheckedItems.Count > 0 Then

            For i As Integer = 0 To listaVariedades.CheckedItems.Count - 1
                vars.Add(CInt(CType(listaVariedades.CheckedItems(i), DataRowView).Row("varcodigo")))
            Next

            Dim partidas As oleosigDB.partidasaceitunaDataTable = Me.partidasDB.GetDataByVariedad(vars)

            For Each part As oleosigDB.partidasaceitunaRow In partidas.Rows
                parts.Add(part.Numero)
            Next

            Dim molturs As System.Collections.Generic.List(Of Integer) = detallesMoltDB.GetMolturByPartida(parts)
            filtro.Append("(")
            For i As Integer = 0 To molturs.Count - 1
                filtro.Append("id='" & molturs(i).ToString & "' or ")
            Next i
            filtro.Length = filtro.Length - 4
            filtro.Append(")")

            If chkVerSoloNoImp.Checked Then
                filtro.Append(" and importada= False")
                moltBDS.Filter = filtro.ToString
            Else
                moltBDS.Filter = filtro.ToString
            End If
            Dim vista As DataView = CType(moltBDS.List, DataView)

            For i As Integer = 0 To vista.Count - 1
                Dim fila As oleosigDB.opfabricaRow = vista(i).Row
                Dim detalles() As oleosigDB.detalles_opfabricaRow = fila.Getdetalles_opfabricaRows
                For Each detalle As oleosigDB.detalles_opfabricaRow In detalles
                    totalKilos += detalle.kilos
                    If fila.importada = True Then
                        totalkilosusados += detalle.kilos
                    End If
                Next

            Next

        Else
            moltBDS.Filter = "operacion='-1'"
        End If

    End Sub

    Private Sub rendtxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rendtxt.KeyPress
        If AscW(e.KeyChar) = CInt(Keys.Enter) Then

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub kilostxt_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kilostxt.Validated

    End Sub

    Private Sub totalAceitunaTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles totalAceitunaTxt.KeyPress

    End Sub


    Private Sub opBdgBDS_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opbdgBDS.CurrentChanged

        If nuevaop = False Then

        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        oMolturDB = New opfabricaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        oOpbodega = New opbodegaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)

        detallesMoltDB = New detallesOpFabricaTableAdapter(Almazara.Id, Almazara.CampañaAct.clave)
        detallesOpbdgDB = New detallesOpBdgTableAdapter(Almazara.Id, Almazara.CampañaAct.clave)


        varDB = New variedadesTableAdapter(Almazara.Id)

        partidasDB.Fill(OleosigDB1.partidasaceituna)

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Me.vslider.Refresh()
    End Sub

    Private Sub tablaMolts_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles tablaMolts.CellFormatting
        Dim dgv As DataGridView

        If e.ColumnIndex = 1 Then
            dgv = CType(sender, DataGridView)
            Dim fila As oleosigDB.opfabricaRow = CType(dgv.Rows(e.RowIndex).DataBoundItem, DataRowView).Row
            If fila.importada Then
                dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Yellow
            Else
                dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            End If
        End If
    End Sub



    Private Sub tabladetalles_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabladetalles.DoubleClick
        If tabladetalles.CurrentRow IsNot Nothing Then
            Dim operacion As Integer = tabladetalles.Item(0, tabladetalles.CurrentCell.RowIndex).Value

            Dim result As oleosigDB.detalles_opbodegaRow = OleosigDB1.detalles_opbodega.First(Function(det As oleosigDB.detalles_opbodegaRow) det.Opfabrica = operacion)

            result.Delete()

            Dim fila As oleosigDB.opfabricaRow = OleosigDB1.opfabrica.First(Function(op As oleosigDB.opfabricaRow) op.operacion = operacion)
            fila.importada = False

            tabladetalles.Rows.RemoveAt(tabladetalles.CurrentCell.RowIndex)


        End If
    End Sub

    Private Sub tablaopbdg_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tablaopbdg.RowEnter

        If tablaopbdg.Rows.Count > 0 Then

            Dim fila As oleosigDB.opbodegaRow = CType(tablaopbdg.Rows(e.RowIndex).DataBoundItem, DataRowView).Row 'obtenemos la operacion de bodega actual
            Dim filtro As New System.Text.StringBuilder

            Dim filasdetalle() As oleosigDB.detalles_opbodegaRow = fila.Getdetalles_opbodegaRows 'obtenemos los detalles de operaciones de bodega

            tabladetalles.Rows.Clear() 'borramos las filas de la tabla de detalles de bodega

            Dim suma As Integer = 0
            Dim totalaceituna As Integer = 0
            filtro.Length = 0

            For Each filadetalle As oleosigDB.detalles_opbodegaRow In filasdetalle 'por cada una de los detalles de operacion de bodega 
                filtro.Append("operacion='" & filadetalle.Opfabrica & "' or ")

                tabladetalles.Rows.Add(filadetalle.Opfabrica, filadetalle.Kilos)

                suma += filadetalle.Kilos


            Next

            If filasdetalle.Count > 0 Then
                filtro.Length = filtro.Length - 4

                Me.moltBDS.Filter = filtro.ToString
                Dim vista As DataView = CType(moltBDS.List, DataView)

                moltBDS.ResetBindings(False)
                Dim contador As Integer = 0
                For contador = 0 To vista.Count - 1
                    Dim filaop As oleosigDB.opfabricaRow = vista.Item(contador).Row
                    Dim detalles() As oleosigDB.detalles_opfabricaRow = filaop.Getdetalles_opfabricaRows
                    Dim kilos As Integer = 0
                    For Each det As oleosigDB.detalles_opfabricaRow In detalles
                        totalaceituna += det.kilos
                        kilos += det.kilos
                    Next
                    tabladetalles.Rows(contador).Cells(2).Value = kilos

                Next contador

                tabladetalles.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)



                kilostxt.Text = suma
                totalAceitunaTxt.Text = totalaceituna.ToString

                rendtxt.Text = ((suma / totalaceituna) * 100.0).ToString
            Else

                moltBDS.Filter = "operacion='-1'"
            End If
        Else

            moltBDS.Filter = "operacion=-1"

        End If

    End Sub
End Class