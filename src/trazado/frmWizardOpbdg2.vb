Public Class frmWizardOpbdg2
    Private _rendimiento As Single = 0
    Private _totalAceite As Single = 0


    Private oOpbodega As opbodegaTableAdapter
    Private oOpfabrica As opfabricaTableAdapter
    Private ordenDB As orden_depositosDataTableAdapter

    Private otickets As LoteAceitunaTableAdapter

    Private detallesbdgDB As detallesOpBdgTableAdapter
    Private detallesmoltDB As detallesOpFabricaTableAdapter
    Private detallesLotDB As detallesLoteAceiteTableAdapter

    Private oLotesDB As loteAceiteTableAdapter

    Private vistaopbdg As DataView
    Private vistalotes As DataView
    Private vistaDetLot As DataView
    Private vistadetOpbdg As DataView
    Private vistaopfabrica As DataView

    Public Sub New()

        InitializeComponent()


    End Sub



    Private Sub frmWizardOpbdg2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.oOpbodega = New opbodegaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        Me.oOpfabrica = New opfabricaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)


        detallesbdgDB = New detallesOpBdgTableAdapter(Almazara.Id, Almazara.CampañaAct.clave)
        detallesmoltDB = New detallesOpFabricaTableAdapter(Almazara.Id, Almazara.CampañaAct.clave)
        detallesLotDB = New detallesLoteAceiteTableAdapter(Almazara.Id, Almazara.CampañaAct.clave)

        oLotesDB = New loteAceiteTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)

        otickets = New LoteAceitunaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)

        ordenDB = New orden_depositosDataTableAdapter(Almazara.Id)


        Me.totalmasatxt.Text = otickets.TotalKilos.ToString

        detallesmoltDB.Fill(oleosigDB1.detalles_opfabrica)
        oOpfabrica.Fill(oleosigDB1.opfabrica)

        detallesbdgDB.Fill(oleosigDB1.detalles_opbodega)
        oOpbodega.Fill(oleosigDB1.opbodega)

        detallesLotDB.Fill(oleosigDB1.detalles_loteaceite)
        oLotesDB.Fill(oleosigDB1.loteaceite)

        ordenDB.Fill(OleosigDB1.orden_depositos)

        vistaopfabrica = New DataView(OleosigDB1.opfabrica)
        vistaopbdg = New DataView(OleosigDB1.opbodega)
        vistalotes = New DataView(OleosigDB1.loteaceite)
        vistaDetLot = New DataView(OleosigDB1.detalles_loteaceite)
        vistadetOpbdg = New DataView(OleosigDB1.detalles_opbodega)


        tablaopbodega.AutoGenerateColumns = False
        tablaLotes.AutoGenerateColumns = False
        tabladetalleslote.AutoGenerateColumns = False
        tablaDetOpbdg.AutoGenerateColumns = False

        calcula_rendimiento()

        crear_op_bodega()

    End Sub

    Private Sub calcula_rendimiento()
        Dim i As Integer


        For Each fila As oleosigDB.orden_depositosRow In OleosigDB1.orden_depositos.Rows

            _totalAceite += CSng(fila.limite)

        Next

        totalaceitetxt.Text = _totalAceite

        _rendimiento = (_totalAceite / CSng(totalmasatxt.Text)) * 100.0
        rndtxt.Text = _rendimiento.ToString("0##.##")

    End Sub

    ''' <summary>
    ''' Crea operaciones de bodega en funcion de las molturaciones, calculando la cantidad de aceite en cada entrada
    ''' por el rendimiento total
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub crear_op_bodega()
        Dim totalAceite As Integer = 0
        Dim totalmasa As Integer = 0
        Dim aceiteDeposito As Single = 0
        Dim numdeposito As Short
        Dim entidad As oleosigDB.opbodegaRow
        Dim aceite As Single
        Dim contador As Integer = 1
        Dim detalleOpbdg As oleosigDB.detalles_opbodegaRow
        Dim i As Integer
        Dim sumaAceitunaMolt As Integer

        'inicializamos el contador de depositos
        numdeposito = 0


        vistaopfabrica.Sort = "fechaini"

        'para cada molturacion
        For i = 0 To vistaopfabrica.Count - 1
            Dim molturacion As oleosigDB.opfabricaRow = vistaopfabrica(i).Row


            'creamos una operacion de bodega nueva

            entidad = OleosigDB1.opbodega.NewopbodegaRow()
            entidad.Idalmazara = Almazara.Id
            entidad.Operacion = contador.ToString
            entidad.Destino = "Bodega"
            entidad.FechaInicial = molturacion.fechaini
            entidad.FechaFinal = molturacion.fechafin
            entidad.Tipo = 1
            entidad.Tanque = OleosigDB1.orden_depositos(numdeposito).deposito
            entidad.Abierta = False
            entidad.Importada = False
            entidad.Campaña = Almazara.CampañaAct.clave


            Dim detallesmolt() As oleosigDB.detalles_opfabricaRow = molturacion.Getdetalles_opfabricaRows()

            sumaAceitunaMolt = 0

            For Each detallemolt As oleosigDB.detalles_opfabricaRow In detallesmolt

                sumaAceitunaMolt += detallemolt.kilos
                totalmasa += detallemolt.kilos
            Next

            'calculamos el aceite de esta molturacion en funcion del rendimiento total
            aceite = CSng(sumaAceitunaMolt) * _rendimiento / 100.0
            totalAceite += aceite
            'aceite acumulado por deposito sumando los aceites de cada molturacion
            aceiteDeposito += CSng(aceite)

            If aceiteDeposito >= OleosigDB1.orden_depositos(numdeposito).limite Then

                numdeposito += 1

                aceiteDeposito = 0

                If numdeposito > (OleosigDB1.orden_depositos.Rows.Count - 1) Then
                    Exit For
                Else

                End If

            Else

            End If

            OleosigDB1.opbodega.AddopbodegaRow(entidad)

            detalleOpbdg = OleosigDB1.detalles_opbodega.Newdetalles_opbodegaRow()

            detalleOpbdg.Idalmazara = Almazara.Id
            detalleOpbdg.Opbodega = entidad.Id
            detalleOpbdg.Opfabrica = molturacion.operacion
            detalleOpbdg.Campaña = Almazara.CampañaAct.clave
            detalleOpbdg.Kilos = aceite
            detalleOpbdg.Opaclarado = 0
            detalleOpbdg.Opfiltrado = 0


            OleosigDB1.detalles_opbodega.Adddetalles_opbodegaRow(detalleOpbdg)
            contador += 1

        Next i

        masaestimadatxt.Text = totalmasa.ToString
        aceitestimado.Text = totalAceite.ToString

        Me.tablaopbodega.AutoResizeColumns()

        vistaopbdg.RowStateFilter = DataViewRowState.Added
        vistadetOpbdg.RowStateFilter = DataViewRowState.Added

        tablaopbodega.DataSource = vistaopbdg
        tablaDetOpbdg.DataSource = vistadetOpbdg

        crear_lotes_aceite()

    End Sub

    ''' <summary>
    ''' Rellena la tabla del formulario con las entradas de bodega
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub crear_lotes_aceite()
        Dim aceitedeposito As UInteger = 0
        Dim numdepanterior As UShort = 0
        Dim fechaini, fechafin As Date
        Dim nmlote As String
        Dim lote As oleosigDB.loteaceiteRow
        Dim i As Integer
        Dim diclotes As System.Collections.Generic.Dictionary(Of String, Integer)
        Dim inicio As Boolean = True
        Dim detallelotes As oleosigDB.detalles_loteaceiteRow
        'Dim contador As Integer = 0
        Dim entidad As oleosigDB.opbodegaRow
        ' Dim numfiladeposito As Integer = 0

        diclotes = New System.Collections.Generic.Dictionary(Of String, Integer)

        If vistaopbdg.Count > 0 Then


            For j As Integer = 0 To vistaopbdg.Count - 1
                entidad = vistaopbdg(j).Row

                If inicio Then
                    numdepanterior = entidad.Tanque

                    i = 1

                    nmlote = "L-" & i.ToString & "-D" & numdepanterior.ToString

                    While diclotes.ContainsKey(nmlote)
                        i += 1
                        nmlote = "L-" & i.ToString & "-D" & numdepanterior.ToString
                    End While



                    fechaini = entidad.FechaInicial
                    fechafin = entidad.FechaFinal


                    lote = OleosigDB1.loteaceite.NewloteaceiteRow()

                    lote.Idalmazara = Almazara.Id
                    lote.Nombre = nmlote
                    lote.Abierto = False
                    lote.Campaña = Almazara.CampañaAct.clave
                    lote.Importado = False
                    lote.FechaInicial = fechaini
                    lote.FechaFinal = fechafin
                    lote.Tanque = numdepanterior

                    OleosigDB1.loteaceite.AddloteaceiteRow(lote)

                    diclotes.Add(nmlote, numdepanterior)

                    aceitedeposito = 0
                    inicio = False

                End If


                If aceitedeposito < OleosigDB1.orden_depositos.AsEnumerable.First(Function(orden As oleosigDB.orden_depositosRow) orden.deposito = numdepanterior).limite Then

                    lote.FechaFinal = fechafin
                    detallelotes = OleosigDB1.detalles_loteaceite.Newdetalles_loteaceiteRow

                    detallelotes.loteaceite = lote.Id
                    detallelotes.opbodega = entidad.Operacion
                    detallelotes.idalmazara = Almazara.Id
                    detallelotes.Campaña = Almazara.CampañaAct.clave

                    Dim detallesopbdg() As oleosigDB.detalles_opbodegaRow = entidad.Getdetalles_opbodegaRows

                    For Each detalleopbdg As oleosigDB.detalles_opbodegaRow In detallesopbdg
                        detallelotes.kilos += detalleopbdg.Kilos
                    Next


                    OleosigDB1.detalles_loteaceite.Adddetalles_loteaceiteRow(detallelotes)

                Else
                    inicio = True

                End If


            Next j


        End If
        vistalotes.RowStateFilter = DataViewRowState.Added
        vistaDetLot.RowStateFilter = DataViewRowState.Added
        tabladetalleslote.DataSource = vistaDetLot
        tablaLotes.DataSource = vistalotes
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim result As MsgBoxResult
        Dim idopbdg As New ArrayList
        Dim newidopbdg As New ArrayList
        Dim idlot As New ArrayList
        Dim newidlot As New ArrayList
        Dim loteaceite As oleosigDB.loteaceiteRow


        If vistaopbdg.Count > 0 Then
            result = MsgBox("¿Desea actualizar todas estas entradas de bodega?", MsgBoxStyle.YesNo)

            If result = MsgBoxResult.Yes Then


                oOpbodega.Borrar_campaña()

                For i As Integer = 0 To vistaopbdg.Count - 1
                    Dim entidad As oleosigDB.opbodegaRow = CType(vistaopbdg(i), DataRowView).Row

                    idopbdg.Add(entidad.Id)
                    Dim id As Integer = oOpbodega.Insert(Almazara.Id, entidad.Operacion, entidad.FechaInicial, entidad.FechaFinal, entidad.Tanque, entidad.Tipo, entidad.Destino, entidad.Campaña, entidad.Abierta, False)
                    newidopbdg.Add(id)

                Next

                For i As Integer = 0 To vistaopbdg.Count - 1

                    vistadetOpbdg.RowFilter = "opbodega='" & vistaopbdg.Item(i)("Id") & "'"
                    For j As Integer = vistadetOpbdg.Count - 1 To 0 Step -1
                        vistadetOpbdg(j)("opbodega") = newidopbdg(i)
                        vistadetOpbdg(j).EndEdit()
                    Next
                Next

                detallesbdgDB.Update(OleosigDB1.detalles_opbodega)

                MsgBox("Se han creado las entradas de bodega")

                oLotesDB.Borrar_campaña()



                For i As Integer = 0 To vistalotes.Count - 1
                    loteaceite = CType(vistalotes(i), DataRowView).Row
                    idlot.Add(loteaceite.Id)
                    Dim id As Integer = oLotesDB.Insert(loteaceite.Idalmazara, loteaceite.Nombre, loteaceite.Tanque, loteaceite.FechaInicial, loteaceite.FechaFinal, loteaceite.Importado, loteaceite.Campaña, loteaceite.Abierto)
                    newidlot.Add(id)
                Next

                For i As Integer = 0 To vistalotes.Count - 1

                    vistaDetLot.RowFilter = "Loteaceite='" & vistalotes.Item(i)("Id") & "'"

                    For j As Integer = vistaDetLot.Count - 1 To 0 Step -1
                        vistaDetLot(j)("Loteaceite") = newidlot(i)
                    Next j

                Next i
                For i As Integer = 0 To vistaDetLot.Count - 1
                    vistaDetLot(i).EndEdit()
                Next
                detallesLotDB.Update(OleosigDB1.detalles_loteaceite)

                OleosigDB1.opbodega.RejectChanges()
                OleosigDB1.detalles_opbodega.RejectChanges()
                OleosigDB1.loteaceite.RejectChanges()
                OleosigDB1.detalles_loteaceite.RejectChanges()

                MsgBox("Se han creado los lotes de aceite")

                vistalotes = New DataView(OleosigDB1.loteaceite)
                vistaopbdg = New DataView(OleosigDB1.opbodega)
                vistadetOpbdg = New DataView(OleosigDB1.detalles_opbodega)
                vistaDetLot = New DataView(OleosigDB1.detalles_loteaceite)

                tablaopbodega.DataSource = vistaopbdg
                tablaDetOpbdg.DataSource = vistadetOpbdg
                tablaLotes.DataSource = vistalotes
                tabladetalleslote.DataSource = vistaDetLot


                '  Me.Close()
            End If
        Else
            MsgBox("No existen datos para crear las operaciones de bodega")
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If IsNumeric(totalmasatxt.Text) And IsNumeric(rndtxt.Text) Then

            _rendimiento = CSng(rndtxt.Text)
            _totalAceite = CSng(totalmasatxt.Text) * _rendimiento / 100.0

            vistalotes = New DataView(OleosigDB1.loteaceite)
            vistaopbdg = New DataView(OleosigDB1.opbodega)
            vistaDetLot = New DataView(OleosigDB1.detalles_loteaceite)
            vistadetOpbdg = New DataView(OleosigDB1.detalles_opbodega)

            vistalotes.RowStateFilter = DataViewRowState.Added
            vistaopbdg.RowStateFilter = DataViewRowState.Added
            vistaDetLot.RowStateFilter = DataViewRowState.Added
            vistadetOpbdg.RowStateFilter = DataViewRowState.Added


            Me.crear_op_bodega()
        Else
            MsgBox("Revise el dato de total de masa y de rendimiento", MsgBoxStyle.Exclamation)

        End If



    End Sub

    Private Sub tablaopbodega_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tablaopbodega.Resize
        Me.tablaLotes.Left = Me.tablaopbodega.Left * 2 + Me.tablaopbodega.Width
    End Sub

    Private Sub rndtxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rndtxt.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = ","c Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub tablaopbodega_RowEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tablaopbodega.RowEnter
        If e.RowIndex >= 0 Then
            Dim fila As oleosigDB.opbodegaRow = CType(tablaopbodega.Rows(e.RowIndex).DataBoundItem, DataRowView).Row
            vistadetOpbdg.RowFilter = "opbodega='" & fila.Id & "'"
        End If
    End Sub
End Class