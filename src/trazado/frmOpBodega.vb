Option Strict Off
Option Explicit On
Friend Class frmOpBodega
    Inherits System.Windows.Forms.Form


    Dim actTickets As Boolean = False

    Dim oOpbodega As opbodegaTableAdapter
    Dim oMoltur As opfabricaTableAdapter
    Dim oPartidas As parAceitunaTableAdapter
    Dim oTickets As LoteAceitunaTableAdapter
    Dim detallesMolturDB As detallesOpFabricaTableAdapter
    Dim detallesOpBdgDB As detallesOpBdgTableAdapter
    Dim varDb As variedadesTableAdapter
    Dim recDb As recoleccionTableAdapter
    Dim depositosDB As depositosTableAdapter

    Private Const LINEASPORPAGINA As Integer = 45

    Private Sub cmbDepositos_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        KeyAscii = 0
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub frmOpBodega_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        Me.Top = 0
        oOpbodega = New opbodegaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        oMoltur = New opfabricaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        oPartidas = New parAceitunaTableAdapter(Almazara.CampañaAct.Clave, Almazara.Id)
        oTickets = New LoteAceitunaTableAdapter(Almazara.CampañaAct.Clave, Almazara.Id)
        detallesMolturDB = New detallesOpFabricaTableAdapter(Almazara.Id, Almazara.CampañaAct.clave)
        detallesOpBdgDB = New detallesOpBdgTableAdapter(Almazara.Id, Almazara.CampañaAct.clave)
        depositosDB = New depositosTableAdapter(Almazara.Id)
        varDb = New variedadesTableAdapter(Almazara.Id)
        recDb = New recoleccionTableAdapter(Almazara.Id)

        detallesMolturDB.Fill(OleosigDB1.detalles_opfabrica)
        detallesOpBdgDB.Fill(OleosigDB1.detalles_opbodega)

        oOpbodega.Fill(OleosigDB1.opbodega)
        depositosDB.Fill(OleosigDB1.tanques)

        varDb.Fill(OleosigDB1.variedades)
        recDb.Fill(OleosigDB1.recoleccion)

        inicia_Componentes()
    End Sub

    Private Sub inicia_Componentes()

        DTFechaini.Value = Now
        DTFechafin.Value = Now

       

        Option4.Checked = True

        ponCabeceraTickets()
        pon_cabecera_listadatos()
        lblkilosaceituna.Text = "0"

    End Sub
    Private Sub ponCabeceraTickets()
        Dim i, ancho As Integer
        tablaTickets.Columns.Clear()
        tablaTickets.RowHeadersVisible = False
        With tablaTickets
            .Columns.Add("0", "Ticket")
            .Columns.Add("1", "Fecha")
            .Columns.Add("2", "Kilos")
            .Columns.Add("3", "Cosechero")
            .Columns.Add("4", "Calidad")
            .Columns.Add("5", "Variedad")
            .Columns.Add("6", "Báscula")
            .Columns.Add("7", "Tolva")
            .Columns.Add("8", "Linea")
            .Columns.Add("9", "Depósito")

            .AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader)
           
        End With

    End Sub

    Private Sub pon_cabecera_listadatos()
        Dim ancho As Integer = 0

        listadatos.Columns.Clear()
        listadatos.Columns.Add("Op.")
        listadatos.Columns.Add("Fecha Ini")
        listadatos.Columns.Add("Fecha Fin")
        listadatos.Columns.Add("Depositos")
        listadatos.Columns.Add("Kilos")

        listadatos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
       
    End Sub

    Private Sub rellena_tabla_opbodega()
        Dim myitem As System.Windows.Forms.ListViewItem
        Dim i, ancho, suma As Integer

        listadatos.Items.Clear()
        suma = 0

        For Each fila As oleosigDB.opbodegaRow In OleosigDB1.opbodega.Rows
            Dim sumparcial As Integer = 0
            Dim dep = fila.Tanque

            myitem = listadatos.Items.Add(fila.Operacion)

            myitem.SubItems.Add(fila.FechaInicial.ToString("dd/MM/yyyy HH:mm"))
            myitem.SubItems.Add(fila.FechaFinal.ToString("dd/MM/yyyy HH:mm"))
            myitem.SubItems.Add(OleosigDB1.tanques.First(Function(tq As oleosigDB.tanquesRow) tq.Numero = dep).Nombre)

            Dim ops() As oleosigDB.detalles_opbodegaRow = fila.Getdetalles_opbodegaRows


            For Each op As oleosigDB.detalles_opbodegaRow In ops
                suma = suma + op.Kilos
                sumparcial += op.Kilos
            Next
            myitem.SubItems.Add(sumparcial.ToString)
        Next

        lbltotal.Text = CStr(suma) & " "

        If listadatos.Items.Count > 0 Then
            listadatos.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent)
            listadatos.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent)
            listadatos.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent)
           
        End If

    End Sub
    
    Private Sub get_Datos()
        lblkilosaceituna.Text = "0"
        lbltotal.Text = "0"

        If Option1.Checked Then ' todas las operaciones
            oOpbodega.Fill(OleosigDB1.opbodega)
            rellena_tabla_opbodega()
        End If
        If Option2.Checked Then ' todas las de un deposito concreto
            If cmbDepositos.SelectedIndex > -1 Then
                oOpbodega.FillByTanque(OleosigDB1.opbodega, cmbDepositos.SelectedValue)
                rellena_tabla_opbodega()
            End If
        End If
        If Option3.Checked Then ' todas las comprendidas entre fechas
            If DTFechaini.Value < DTFechafin.Value Then
                oOpbodega.FillDataByFechas(OleosigDB1.opbodega, DTFechaini.Value, DTFechafin.Value)
                rellena_tabla_opbodega()

            Else
                MsgBox("La fecha inicial debe ser anterior a la fecha final", MsgBoxStyle.Exclamation)

            End If
        End If
        If Option4.Checked Then ' seleccion libre
            If DTFechaini.Value < DTFechafin.Value Then
                If cmbDepositos.SelectedIndex > -1 Then
                    oOpbodega.FillByTanque(OleosigDB1.opbodega, cmbDepositos.SelectedValue, DTFechaini.Value, DTFechafin.Value)
                    rellena_tabla_opbodega()
                Else
                    MsgBox("Debe seleccionar un deposito", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("La fecha inicial debe ser anterior a la fecha final", MsgBoxStyle.Exclamation)
            End If

        End If


    End Sub

    Private Sub ver_Informe()
        'If CheckBox1.Checked Then
        'get_informe(lbltitulo.Text, lbltotal.Text, listadatos, tablaTickets)
        ' Else
        get_informe(lbltitulo.Text, lbltotal.Text, listadatos)
        ' End If
    End Sub
    Private Sub get_informe(ByVal titulo As String, ByVal total As String, ByVal listadatos As ListView)
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
        Dim caminoArchivo As String

        caminoArchivo = System.IO.Path.Combine(My.Application.Info.DirectoryPath, "informe.pdf")

        docPDF = New iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 50, 50, 50, 72)
        writer = iTextSharp.text.pdf.PdfWriter.GetInstance(docPDF, New System.IO.FileStream(caminoArchivo, IO.FileMode.Create))

        fuenteCabTabla = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)
        fuenteTabla = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL)
        fuenteTitulo = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD)
        fuenteParrafo = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL)


        docPDF.Open()
        While fin = False

            cuentalineas = 1

            docPDF.Add(New iTextSharp.text.Paragraph(titulo, fuenteTitulo))
            docPDF.Add(New iTextSharp.text.Paragraph(Almazara.Nombre, fuenteParrafo))
            docPDF.Add(New iTextSharp.text.Paragraph(Almazara.Direccion, fuenteParrafo))
            docPDF.Add(New iTextSharp.text.Paragraph("Fecha impresion : " & Now.ToString("dd/MM/yyyy HH:mm"), fuenteParrafo))
            docPDF.Add(New iTextSharp.text.Paragraph(Label3.Text & lbltotal.Text, fuenteParrafo))
            docPDF.Add(New iTextSharp.text.Paragraph("Entradas de aceite", fuenteTitulo))
            docPDF.Add(New iTextSharp.text.Paragraph(" "))
            tabla = New iTextSharp.text.pdf.PdfPTable(listadatos.Columns.Count)

            Dim rect As iTextSharp.text.Rectangle = New iTextSharp.text.Rectangle(400, 770)

            tabla.SetWidthPercentage(New Single() {30, 100, 100, 30, 30}, rect)

            For i As Integer = 0 To listadatos.Columns.Count - 1
                Dim cell As iTextSharp.text.pdf.PdfPCell = New iTextSharp.text.pdf.PdfPCell(New iTextSharp.text.Phrase(listadatos.Columns(i).Text, fuenteCabTabla))
                tabla.AddCell(cell)

            Next

            While cuentalineas <= LINEASPORPAGINA
                If filatabla <= listadatos.Items.Count - 1 Then

                    tabla.AddCell(New iTextSharp.text.Phrase(listadatos.Items(filatabla).Text, fuenteTabla))

                    For j As Integer = 1 To listadatos.Items(filatabla).SubItems.Count - 1


                        If listadatos.Items(filatabla).SubItems(j).Text.Length > 0 Then
                            tabla.AddCell(New iTextSharp.text.Phrase(listadatos.Items(filatabla).SubItems(j).Text, fuenteTabla))
                        Else
                            tabla.AddCell(New iTextSharp.text.Phrase("0"))
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

        Dim visor As frmvisor
        visor = New frmvisor
        visor.MdiParent = Me.MdiParent
        visor.visor.Navigate(New Uri(caminoArchivo))
        visor.Show()


    End Sub
    Sub get_informe(ByVal titulo As String, ByVal total As String, ByVal listadatos As ListView, ByVal tablatickets As DataGridView)

        Dim cuentalineas As Integer = 0
        Dim cab_part_puesta As Boolean = False
        Dim cab_ticket_puesta As Boolean = False
        Dim docPDF As iTextSharp.text.Document
        Dim writer As iTextSharp.text.pdf.PdfWriter
        Dim masterTabla As iTextSharp.text.pdf.PdfPTable
        Dim detalleTabla As iTextSharp.text.pdf.PdfPTable


        docPDF = New iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 50, 50, 50, 72)
        writer = iTextSharp.text.pdf.PdfWriter.GetInstance(docPDF, New System.IO.FileStream(My.Application.Info.DirectoryPath & "\informe.pdf", IO.FileMode.Create))

        docPDF.Open()


        For Each myitem As ListViewItem In listadatos.Items

            If cab_part_puesta = False Then
                docPDF.Add(New iTextSharp.text.Paragraph(titulo, New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.BOLD)))
                docPDF.Add(New iTextSharp.text.Paragraph(Almazara.Nombre))
                docPDF.Add(New iTextSharp.text.Paragraph(Almazara.Direccion))

                docPDF.Add(New iTextSharp.text.Phrase("Total : " & total.ToString))
                masterTabla = New iTextSharp.text.pdf.PdfPTable(listadatos.Columns.Count - 1)



                cab_part_puesta = True
            End If




            For Each subitem As ListViewItem.ListViewSubItem In myitem.SubItems


                If subitem.Text.Length > 0 Then
                    masterTabla.AddCell(subitem.Text)
                End If


            Next

            If myitem.Checked Then

                docPDF.Add(masterTabla)
                cab_part_puesta = False
                detalleTabla = New iTextSharp.text.pdf.PdfPTable(tablatickets.ColumnCount)



                For Each fila As DataGridViewRow In tablatickets.Rows
                    If fila.Cells(7).Value = myitem.Text Then

                        If cab_ticket_puesta = False Then
                            For j As Integer = 0 To tablatickets.ColumnCount - 1
                                detalleTabla.AddCell(tablatickets.Columns(j).HeaderText)
                            Next j
                            cab_ticket_puesta = True
                        End If


                        For i As Integer = 0 To fila.Cells.Count - 1
                            detalleTabla.AddCell(fila.Cells(i).Value)
                        Next i


                    End If
                Next
                If (Not (detalleTabla Is Nothing)) Then
                    docPDF.Add(detalleTabla)
                End If

                cab_ticket_puesta = False


                cuentalineas = 0
            Else
                cuentalineas += 1
                If cuentalineas = LINEASPORPAGINA Then
                    docPDF.Add(masterTabla)

                    cab_part_puesta = False
                    cuentalineas = 0
                End If
            End If

        Next

        frminicial.VerInforme()

    End Sub

    'UPGRADE_WARNING: El evento Option1.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Option1_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        If eventSender.Checked Then
            If Option1.Checked Then
                DTFechaini.Enabled = False
                DTFechafin.Enabled = False
                cmbDepositos.Enabled = False
            End If

        End If
    End Sub

    'UPGRADE_WARNING: El evento Option2.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Option2_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option2.CheckedChanged
        If eventSender.Checked Then
            If Option2.Checked Then
                DTFechaini.Enabled = False
                DTFechafin.Enabled = False
                cmbDepositos.Enabled = True
            End If

        End If
    End Sub

    'UPGRADE_WARNING: El evento Option3.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Option3_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option3.CheckedChanged
        If eventSender.Checked Then
            If Option3.Checked Then
                DTFechaini.Enabled = True
                DTFechafin.Enabled = True
                cmbDepositos.Enabled = False
            End If
        End If
    End Sub

    'UPGRADE_WARNING: El evento Option4.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Option4_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option4.CheckedChanged
        If eventSender.Checked Then
            If Option4.Checked Then
                DTFechaini.Enabled = True
                DTFechafin.Enabled = True
                cmbDepositos.Enabled = True
            End If
        End If
    End Sub


    Private Sub _Toolbar1_Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetDatos.Click
        get_Datos()
    End Sub

    Private Sub _Toolbar1_Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerInforme.Click
        ver_Informe()
    End Sub


    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command1.Click
        actTickets = False
        For Each myitem As ListViewItem In listadatos.Items
            myitem.Checked = True
        Next
        If CheckBox1.Checked Then
            rellena_tabla_lotes()
            actTickets = True

        End If
    End Sub
    Private Sub rellena_tabla_lotes()
        Dim entopbodega As oleosigDB.opbodegaRow
        Dim detalles() As oleosigDB.detalles_opbodegaRow
        Dim entpartida As oleosigDB.partidasaceitunaRow
        Dim sumakilos As Integer = 0

        tablaTickets.Rows.Clear()

        For Each myitem As ListViewItem In listadatos.Items

            If myitem.Checked Then

                'entopbodega = oOpbodega.getByOperacion(CUShort(myitem.Text))
                'si la entrada de bodega está seleccionada, la recuperamos
                entopbodega = OleosigDB1.opbodega.AsEnumerable.First(Function(op As DataRow) op("operacion") = myitem.Text)

                'obtenemos los detalles de la operacion
                detalles = entopbodega.Getdetalles_opbodegaRows


                For Each detalle As oleosigDB.detalles_opbodegaRow In detalles

                    oMoltur.FillDataByOperacion(OleosigDB1.opfabrica, detalle.Opfabrica)

                    For Each fila As oleosigDB.opfabricaRow In OleosigDB1.opfabrica.Rows
                        Dim partidas() As oleosigDB.detalles_opfabricaRow = fila.Getdetalles_opfabricaRows
                        For Each part As oleosigDB.detalles_opfabricaRow In partidas
                            entpartida = oPartidas.getByNumPartida(part.partida)
                            sumakilos += entpartida.Kilos
                            lblkilosaceituna.Text = sumakilos.ToString

                            Dim tickets As oleosigDB.lotesaceitunaDataTable = oTickets.GetDataByFechasVariedad(entpartida.FechaIniLlenado, _
                                                              entpartida.FechaFinLlenado, _
                                                              entpartida.Calidad, _
                                                              entpartida.Tolva, _
                                                              entpartida.Variedad)

                            rellenalotes(tickets, fila.lineafabrica, entopbodega.Tanque)

                        Next
                    Next
                Next
            End If
        Next

    End Sub

    Private Sub rellenalotes(ByVal lotes As oleosigDB.lotesaceitunaDataTable, ByVal linea As UShort, ByVal opbdg As UShort)
        Dim i, ancho As Integer

        For Each milote As oleosigDB.lotesaceitunaRow In lotes
            Dim lote As oleosigDB.lotesaceitunaRow = milote

            tablaTickets.Rows.Add(lote.Numero, _
                                  lote.Fecha, _
                                  lote.Kilos, _
                                  lote.Cosechero, _
                                  OleosigDB1.recoleccion.First(Function(rec As oleosigDB.recoleccionRow) rec.codigo = lote.Calidad).nombre, _
                                  OleosigDB1.variedades.First(Function(var As oleosigDB.variedadesRow) var.varcodigo = lote.Variedad).varnombre, _
                                  lote.Bascula, _
                                  lote.Tolva, _
                                  linea, _
                                  OleosigDB1.tanques.First(Function(tq As oleosigDB.tanquesRow) tq.Numero = opbdg).Nombre)

        Next
        tablaTickets.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        ancho = 0
        For i = 0 To tablaTickets.ColumnCount - 1
            ancho += tablaTickets.Columns(i).Width
        Next
        tablaTickets.Width = ancho + SystemInformation.VerticalScrollBarWidth + SystemInformation.Border3DSize.Width * 4

    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckStateChanged
        If CheckBox1.Checked Then
            rellena_tabla_lotes()
            actTickets = True
        Else
            tablaTickets.Rows.Clear()
            actTickets = False

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command2.Click
        Dim myitem As ListViewItem
        actTickets = False
        For Each myitem In listadatos.Items
            myitem.Checked = False
        Next
        If CheckBox1.Checked Then rellena_tabla_lotes()
        actTickets = True
    End Sub

    Private Sub listadatos_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles listadatos.ItemChecked
        If actTickets Then
            If CheckBox1.Checked Then rellena_tabla_lotes()
        End If
    End Sub


    
End Class