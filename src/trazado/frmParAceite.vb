Option Strict Off
Option Explicit On

Friend Class frmParAceite
    Inherits System.Windows.Forms.Form


    Dim oClientes As clientesTableAdapter
    Dim oPartidas As partAceiteTableAdapter
    Dim detPar As detallesPartidasAceiteTablaAdapter

    Dim oLotes As loteAceiteTableAdapter

    Dim detLotAcDB As detallesLoteAceiteTableAdapter

    Dim detOpBdDB As detallesOpBdgTableAdapter
    Dim oOpbdg As opbodegaTableAdapter

    Dim detMoltDB As detallesOpFabricaTableAdapter

    Dim oMoltur As opfabricaTableAdapter
    Dim oPartAceituna As parAceitunaTableAdapter
    Dim oTickets As LoteAceitunaTableAdapter
    Dim oVehiculo As vehiculosTableAdapter

    Dim depositosDB As depositosTableAdapter


    Dim actTickets As Boolean = False

    Dim tipos As String() = New String() {"sin", "Venta", "Envasado"}
    Private Const LINEASPORPAGINA As Integer = 45

    '##################################################################################
    '#
    '#      subrutina que rellena el grid con los datos del informe
    '#
    '##################################################################################
    Private Sub rellena_tabla_partidas(ByRef colEnt As oleosigDB.partidasaceiteDataTable)
        Dim entidad As oleosigDB.partidasaceiteRow
        Dim i, ancho As Integer
        Dim myitem As ListViewItem
        listaDatos.Items.Clear()


        For Each entidad In colEnt.Rows


            myitem = listaDatos.Items.Add(entidad.Numero)

            myitem.SubItems.Add(entidad.Fecha)

            myitem.SubItems.Add(tipos(entidad.Tipo))


        Next entidad
        If colEnt.Rows.Count > 0 Then
            'listaDatos.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent)
            listaDatos.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent)
            ancho = 0
            For i = 0 To listaDatos.Columns.Count - 1
                ancho += listaDatos.Columns(i).Width
            Next
            listaDatos.Width = ancho + SystemInformation.VerticalScrollBarWidth + SystemInformation.Border3DSize.Width * 4
        End If



    End Sub

    '##################################################################################
    '#
    '#      subrutina llamada cuando pulsamos verdatos, muestra los datos
    '#
    '##################################################################################
    Private Sub get_datos()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        If Option1.Checked = True Then
            rellena_tabla_partidas(OleosigDB1.partidasaceite)
        End If

        If Option2.Checked = True Then
            If cmbtanques.SelectedIndex > -1 Then
                rellena_tabla_partidas(oPartidas.GetDataByFechas((DTFechaini.Value), (DTFechafin.Value)))
            End If
        End If

        If Option3.Checked = True Then

            If DTFechaini.Value >= DTFechafin.Value Then
                rellena_tabla_partidas(oPartidas.GetDataByDeposito(cmbTanques.SelectedValue.ToString))
            End If
        End If

        If Option4.Checked = True Then

            If DTFechaini.Value >= DTFechafin.Value And cmbtanques.SelectedIndex > -1 Then
                rellena_tabla_partidas(oPartidas.GetDataByFechas(DTFechaini.Value, DTFechafin.Value, _
                                                             cmbTanques.SelectedValue))
            End If
        End If



        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub


    '##################################################################################
    '#
    '#      subrutina que muestra los datos como un documento html
    '#
    '##################################################################################
    Private Sub ver_informe()
        Dim cuentalineas As Integer = 0
        Dim filatabla As Integer = 0
        Dim fin As Boolean = False
        Dim docPDF As iTextSharp.text.Document
        Dim tabla As iTextSharp.text.pdf.PdfPTable
        Dim writer As iTextSharp.text.DocWriter
        Dim fuenteCabTabla As iTextSharp.text.Font
        Dim fuenteTabla As iTextSharp.text.Font
        Dim fuenteTitulo As iTextSharp.text.Font
        Dim fuenteParrafo As iTextSharp.text.Font


        docPDF = New iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 50, 50, 50, 72)
        writer = iTextSharp.text.pdf.PdfWriter.GetInstance(docPDF, New System.IO.FileStream(My.Application.Info.DirectoryPath & "\informe.pdf", IO.FileMode.Create))

        fuenteCabTabla = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)
        fuenteTabla = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL)
        fuenteTitulo = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD)
        fuenteParrafo = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL)


        docPDF.Open()
        While fin = False

            cuentalineas = 1

            docPDF.Add(New iTextSharp.text.Paragraph("Partidas de aceite", fuenteTitulo))
            docPDF.Add(New iTextSharp.text.Paragraph(Almazara.Nombre, fuenteParrafo))
            docPDF.Add(New iTextSharp.text.Paragraph(Almazara.Direccion, fuenteParrafo))
            docPDF.Add(New iTextSharp.text.Paragraph("Fecha impresion : " & Now.ToString("dd/MM/yyyy HH:mm"), fuenteParrafo))
            docPDF.Add(New iTextSharp.text.Paragraph(Label4.Text & lbltotal.Text, fuenteParrafo))
            docPDF.Add(New iTextSharp.text.Paragraph("Partidas", fuenteTitulo))
            docPDF.Add(New iTextSharp.text.Paragraph(" "))
            tabla = New iTextSharp.text.pdf.PdfPTable(listaDatos.Columns.Count)

            Dim rect As iTextSharp.text.Rectangle = New iTextSharp.text.Rectangle(400, 770)

            tabla.SetWidthPercentage(New Single() {50, 150, 80}, rect)

            For i As Integer = 0 To listaDatos.Columns.Count - 1
                Dim cell As iTextSharp.text.pdf.PdfPCell = New iTextSharp.text.pdf.PdfPCell(New iTextSharp.text.Phrase(listaDatos.Columns(i).Text, fuenteCabTabla))
                tabla.AddCell(cell)

            Next

            While cuentalineas <= LINEASPORPAGINA
                If filatabla <= listaDatos.Items.Count - 1 Then

                    tabla.AddCell(New iTextSharp.text.Phrase(listaDatos.Items(filatabla).Text, fuenteTabla))

                    For j As Integer = 1 To listaDatos.Items(filatabla).SubItems.Count - 1


                        If listaDatos.Items(filatabla).SubItems(j).Text.Length > 0 Then
                            tabla.AddCell(New iTextSharp.text.Phrase(listaDatos.Items(filatabla).SubItems(j).Text, fuenteTabla))
                        Else
                            tabla.AddCell(New iTextSharp.text.Phrase(" "))
                        End If


                    Next j

                    filatabla += 1


                Else
                    fin = True
                    cuentalineas = 126
                End If
                cuentalineas += 1
            End While
            docPDF.Add(tabla)
            If fin = False Then
                docPDF.NewPage()
            End If
        End While
        docPDF.Close()

        frminicial.VerInforme()
    End Sub


    Private Sub frmParAceite_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load


        oPartidas = New partAceiteTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        detPar = New detallesPartidasAceiteTablaAdapter(Almazara.Id, Almazara.CampañaAct.clave)

        oClientes = New clientesTableAdapter(Almazara.Id)
        oLotes = New loteAceiteTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        detLotAcDB = New detallesLoteAceiteTableAdapter(Almazara.Id, Almazara.CampañaAct.clave)

        oOpbdg = New opbodegaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        oMoltur = New opfabricaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)

        detOpBdDB = New detallesOpBdgTableAdapter(Almazara.Id, Almazara.CampañaAct.clave)
        detMoltDB = New detallesOpFabricaTableAdapter(Almazara.Id, Almazara.CampañaAct.clave)

        oPartAceituna = New parAceitunaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        oTickets = New LoteAceitunaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)

        depositosDB = New depositosTableAdapter(Almazara.Id)
        depositosDB.Fill(OleosigDB1.tanques)

        BkgWorker1.RunWorkerAsync()

        iniciaComponentes()
    End Sub
    Private Sub iniciaComponentes()

       

        dtfechaini.Value = Now
        dtfechafin.Value = Now
        Option4.Checked = True

        For Each elemento As ToolStripButton In barraMenu.Items
            elemento.Enabled = False
        Next


        pon_Cabecera()
        ponCabeceralotes()

    End Sub
    Private Sub ponCabeceralotes()
        Dim i, ancho As Integer

        tablaLotes.Columns.Clear()
        tablaLotes.Rows.Clear()
        tablaLotes.RowHeadersVisible = False

        With tablaLotes

            .Columns.Add("col0", "Ticket")
            .Columns.Add("col1", "Fecha")
            .Columns.Add("col2", "Kilos")
            .Columns.Add("col3", "Cosechero")
            .Columns.Add("col4", "Bascula")
            .Columns.Add("col5", "Tolva")
            .Columns.Add("col6", "Decanter")
            .Columns.Add("col7", "Deposito")
            .Columns.Add("col8", "Partida")

            .AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader)
            ancho = 0
            For i = 0 To .ColumnCount - 1
                ancho += .Columns(i).Width
            Next
            .Width = ancho + SystemInformation.VerticalScrollBarWidth + SystemInformation.BorderSize.Width * 4
        End With

    End Sub
    Private Sub pon_Cabecera()
        Dim i, ancho As Integer

        With listaDatos
            .Columns.Clear()

            .Columns.Add("0", "Partida")
            .Columns.Add("2", "Fecha")
            .Columns.Add("3", "Tipo")
            .AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            ancho = 0
            For i = 0 To .Columns.Count - 1
                ancho = ancho + .Columns(i).Width
            Next
            .Width = ancho + SystemInformation.VerticalScrollBarWidth + SystemInformation.BorderSize.Width * 4
        End With

    End Sub


    'UPGRADE_WARNING: El evento Option1.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Option1_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option1.CheckedChanged
        If eventSender.Checked Then
            If Option1.Checked = True Then
                DTFechaini.Enabled = False
                DTFechafin.Enabled = False
                cmbtanques.Enabled = False
            End If

        End If
    End Sub

    'UPGRADE_WARNING: El evento Option2.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Option2_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option2.CheckedChanged
        If eventSender.Checked Then
            If Option2.Checked = True Then
                DTFechaini.Enabled = True
                DTFechafin.Enabled = True
                cmbTanques.Enabled = False

            End If
        End If
    End Sub
    'UPGRADE_WARNING: El evento Option3.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Option3_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option3.CheckedChanged
        If eventSender.Checked Then
            If Option3.Checked = True Then
                DTFechaini.Enabled = False
                DTFechafin.Enabled = False
                cmbTanques.Enabled = True
            End If
        End If
    End Sub


    'UPGRADE_WARNING: El evento Option4.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Option4_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option4.CheckedChanged
        If eventSender.Checked Then
            dtfechaini.Enabled = True
            dtfechafin.Enabled = True
            cmbTanques.Enabled = True

        End If
    End Sub

    Private Sub _barramenu_Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerdatos.Click
        get_datos()
    End Sub

    Private Sub _barramenu_Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerInforme.Click
        ver_informe()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command1.Click
        Dim myitem As ListViewItem
        actTickets = False
        For Each myitem In listaDatos.Items
            myitem.Checked = True
        Next
        If CheckBox1.Checked Then get_datos_tickets()
        actTickets = True
    End Sub
    Private Sub get_datos_tickets()
        Dim partida As oleosigDB.partidasaceiteRow

        Try
            tablaLotes.Rows.Clear()

            For Each myitem As ListViewItem In listaDatos.Items
                If myitem.Checked Then

                    partida = OleosigDB1.partidasaceite.First(Function(par As oleosigDB.partidasaceiteRow) par.Numero = myitem.Text)

                    Dim detallespartidas() As oleosigDB.detalles_partidasaceiteRow = partida.Getdetalles_partidasaceiteRows

                    For Each detallepartida As oleosigDB.detalles_partidasaceiteRow In detallespartidas
                        Dim detalle As oleosigDB.detalles_partidasaceiteRow = detallepartida

                        Dim lote As oleosigDB.loteaceiteRow = OleosigDB1.loteaceite.First(Function(lot As oleosigDB.loteaceiteRow) lot.Id = detalle.Lote)

                        Dim detalleslote() As oleosigDB.detalles_loteaceiteRow = lote.Getdetalles_loteaceiteRows

                        For Each detallelote As oleosigDB.detalles_loteaceiteRow In detalleslote

                            Dim opbodega As oleosigDB.opbodegaRow = OleosigDB1.opbodega.First(Function(opbdg As oleosigDB.opbodegaRow) opbdg.Operacion = detallelote.opbodega)

                            Dim detallesopbdg() As oleosigDB.detalles_opbodegaRow = opbodega.Getdetalles_opbodegaRows()

                            For Each detalleopbdg As oleosigDB.detalles_opbodegaRow In detallesopbdg
                                Dim detopbdg As oleosigDB.detalles_opbodegaRow = detalleopbdg

                                Dim molturacion As oleosigDB.opfabricaRow = OleosigDB1.opfabrica.First(Function(opmolt As oleosigDB.opfabricaRow) opmolt.operacion = detopbdg.Opfabrica)

                                Dim detallesopmoltur() As oleosigDB.detalles_opfabricaRow = molturacion.Getdetalles_opfabricaRows

                                For Each detalleopmoltur As oleosigDB.detalles_opfabricaRow In detallesopmoltur
                                    Dim detMolt As oleosigDB.detalles_opfabricaRow = detalleopmoltur

                                    Dim partaceituna As oleosigDB.partidasaceitunaRow = Me.oPartAceituna.getByNumPartida(detMolt.partida)
                                    rellenalotes(Me.oTickets.GetDataByFechasVariedad(partaceituna.FechaIniLlenado, partaceituna.FechaFinLlenado, partaceituna.Calidad, partaceituna.Tolva, partaceituna.Variedad), molturacion.lineafabrica, lote.Tanque, partida.Numero)

                                Next

                            Next
                        Next
                    Next
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub rellenalotes(ByVal lotes As oleosigDB.lotesaceitunaDataTable, ByVal linea As UShort, ByVal deposito As UShort, ByVal partida As String)
        Dim i, ancho As Integer

        For Each lote As oleosigDB.lotesaceitunaRow In lotes

            tablaLotes.Rows.Add(lote.Numero, _
                                  lote.Fecha, _
                                  lote.Kilos, _
                                  lote.Cosechero, _
                                  lote.Bascula, _
                                  lote.Tolva, _
                                  linea, _
                                  OleosigDB1.tanques.First(Function(tq As oleosigDB.tanquesRow) tq.Numero = deposito).Nombre, _
                                  partida)

        Next
        tablaLotes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        ancho = 0
        For i = 0 To tablaLotes.ColumnCount - 1
            ancho += tablaLotes.Columns(i).Width
        Next
        tablaLotes.Width = ancho + SystemInformation.VerticalScrollBarWidth + SystemInformation.Border3DSize.Width * 4

    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command2.Click
        Dim myitem As ListViewItem
        actTickets = False
        For Each myitem In listaDatos.Items
            myitem.Checked = False
        Next
        If CheckBox1.Checked Then get_datos_tickets()
        actTickets = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            get_datos_tickets()
            actTickets = True
        Else
            tablaLotes.Rows.Clear()
            actTickets = False

        End If
    End Sub

    Private Sub BkgWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BkgWorker1.DoWork
        'oPartidas = New partAceiteDB(Almazara.CampañaAct.clave, Almazara.Id)
        'oClientes = New clientesDB(Almazara.Id)

        detLotAcDB.Fill(OleosigDB1.detalles_loteaceite)
        oLotes.Fill(OleosigDB1.loteaceite)

        detOpBdDB.Fill(OleosigDB1.detalles_opbodega)
        oOpbdg.Fill(OleosigDB1.opbodega)

        detMoltDB.Fill(OleosigDB1.detalles_opfabrica)
        oMoltur.Fill(OleosigDB1.opfabrica)

        oPartidas.Fill(OleosigDB1.partidasaceite)
        detPar.Fill(OleosigDB1.detalles_partidasaceite)

        '   oPartAceituna = New cParAceituna(Almazara.CampañaAct.clave, Almazara.Id)
        '   oTickets = New cLotAceituna(Almazara.CampañaAct.clave, Almazara.Id)



    End Sub

    Private Sub BkgWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BkgWorker1.RunWorkerCompleted
        For Each elemento As ToolStripButton In barraMenu.Items
            elemento.Enabled = True
        Next
    End Sub

    Private Sub listaDatos_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles listaDatos.ItemChecked
        If actTickets Then
            If CheckBox1.Checked Then get_datos_tickets()
        End If
    End Sub
End Class