Option Strict Off
Option Explicit On

Imports System.Text
Imports iTextSharp.text

Friend Class frmPaAceituna
    Inherits System.Windows.Forms.Form


    Dim oParAceituna As parAceitunaTableAdapter
    Dim oTickets As LoteAceitunaTableAdapter

    'Dim detParDB As detallesPartidasAceiteTablaAdapter
    'Dim detLotDB As detallesLoteAceiteTableAdapter

    Dim actTablaLotes As Boolean = False
    Private Const LINEASPORPAGINA As UShort = 45

    Dim recDB As recoleccionTableAdapter
    Dim varDB As variedadesTableAdapter
    Dim tolvasDB As tolvasTableAdapter






    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        Dim myitem As ListViewItem

        actTablaLotes = False

        For Each myitem In listaPartidas.Items

            myitem.Checked = True

        Next
        If Check1.Checked Then rellena_tabla_tickets()
        actTablaLotes = True
    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        Dim myitem As ListViewItem

        actTablaLotes = False

        For Each myitem In listaPartidas.Items
            myitem.Checked = False
        Next
        If Check1.Checked Then rellena_tabla_tickets()
        actTablaLotes = True
    End Sub

    Private Sub frmPaAceituna_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim sum As Integer

        Me.Text = "Control de Tolvas"

        varDB = New variedadesTableAdapter(Almazara.Id)
        recDB = New recoleccionTableAdapter(Almazara.Id)
        tolvasDB = New tolvasTableAdapter(Almazara.Id)


        varDB.Fill(OleosigDB1.variedades)
        recDB.Fill(OleosigDB1.recoleccion)
        tolvasDB.Fill(OleosigDB1.tolvas)


        DTFechaini.Value = Now
        DTFechafin.Value = Now
        Option4.Checked = True

        oParAceituna = New parAceitunaTableAdapter(Almazara.CampañaAct.Clave, Almazara.Id)
        oTickets = New LoteAceitunaTableAdapter(Almazara.CampañaAct.Clave, Almazara.Id)


        sum = 0



        sum = 0

        listaPartidas.Columns(4).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)

        listaPartidas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        For i = 0 To listaPartidas.Columns.Count - 1
            sum = sum + listaPartidas.Columns(i).Width
        Next

        listaPartidas.Width = sum

        ponCabeceraLotes()

    End Sub


    Private Sub listaTolvas_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles listaTolvas.DoubleClick
        listaTolvas.SelectedIndex = -1
    End Sub



    'UPGRADE_WARNING: El evento Option1.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Option1_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option1.CheckedChanged
        If eventSender.Checked Then
            Me.DTfechaini.Enabled = False
            Me.DTfechafin.Enabled = False
            If Me.listaTolvas.SelectedIndex > -1 Then
                Me.listaTolvas.SetSelected(Me.listaTolvas.SelectedIndex, False)
            End If
            Me.listaTolvas.Enabled = False
        End If
    End Sub

    'UPGRADE_WARNING: El evento Option2.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Option2_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option2.CheckedChanged
        If eventSender.Checked Then
            Me.DTfechaini.Enabled = True
            Me.DTfechafin.Enabled = True
            If Me.listaTolvas.SelectedIndex > -1 Then
                Me.listaTolvas.SetSelected(Me.listaTolvas.SelectedIndex, False)
            End If
            Me.listaTolvas.Enabled = False
        End If
    End Sub

    'UPGRADE_WARNING: El evento Option3.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Option3_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option3.CheckedChanged
        If eventSender.Checked Then
            Me.DTfechafin.Enabled = False
            Me.DTfechaini.Enabled = False
            Me.listaTolvas.Enabled = True
        End If
    End Sub

    'UPGRADE_WARNING: El evento Option4.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Option4_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option4.CheckedChanged
        If eventSender.Checked Then
            Me.DTfechafin.Enabled = True
            Me.DTfechaini.Enabled = True
            Me.listaTolvas.Enabled = True
        End If
    End Sub




    '###########################################################################
    '#
    '#      Descripcion :   Obtiene los datos de la base de datos
    '#
    '###########################################################################
    Private Sub get_Datos()


        Dim totalKilos As Double
        Dim Partidas As oleosigDB.partidasaceitunaDataTable



        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        totalKilos = 0
        lbltotal.Text = "0"


        If Option1.Checked = True Then 'todas las partidas
            oParAceituna.Fill(OleosigDB1.partidasaceituna)
            rellena_tabla(OleosigDB1.partidasaceituna)

        End If

        If Option2.Checked = True Then 'todas las tolvas

            Partidas = oParAceituna.GetDataByFechas(DTfechaini.Value, DTfechafin.Value)
            rellena_tabla(Partidas)


        End If
        If Option3.Checked = True Then 'todas las fechas seleccionando tolva

            If listaTolvas.SelectedIndex = -1 Then
                MsgBox("Debe seleccionas una tolva", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Partidas = oParAceituna.GetDataByTolva(listaTolvas.SelectedValue)
            rellena_tabla(Partidas)

        End If
        If Option4.Checked Then
            If listaTolvas.SelectedIndex = -1 Then
                MsgBox("Debe seleccionas una tolva", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Partidas = oParAceituna.GetDataByFechasTolva(DTfechaini.Value, DTfechafin.Value, listaTolvas.SelectedIndex + 1)
            rellena_tabla(Partidas)

        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub ponCabeceraLotes()
        Dim i, ancho As Integer

        tablalotes.Columns.Clear()
        tablalotes.Rows.Clear()
        tablalotes.RowHeadersVisible = False

        With tablalotes

            .columns.add("col0", "Ticket")
            .Columns.Add("col1", "Fecha")
            .Columns.Add("col2", "Kilos")
            .Columns.Add("col3", "Cosechero")
            .Columns.Add("col4", "Calidad")
            .Columns.Add("col5", "Variedad")
            .Columns.Add("col6", "Bascula")
            .Columns.Add("col7", "Tolva")
            .Columns.Add("col8", "Partida")


            .AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader)
            ancho = 0
            For i = 0 To .ColumnCount - 1
                ancho += .Columns(i).Width
            Next
            .Width = ancho + SystemInformation.VerticalScrollBarWidth + SystemInformation.BorderSize.Width * 4
        End With
    End Sub

    Private Sub rellena_tabla(ByVal Partidas As oleosigDB.partidasaceitunaDataTable)
        Dim i As Integer
        Dim ancho As Integer
        Dim suma As UInteger
        Dim myitem As System.Windows.Forms.ListViewItem


        listaPartidas.Items.Clear()


        suma = 0

        If Partidas.Count > 0 Then
            For Each partida As oleosigDB.partidasaceitunaRow In Partidas.Rows
                Dim codigo As Int32 = partida.Calidad
                Dim variedad As Int32 = partida.Variedad
                myitem = listaPartidas.Items.Add(partida.Numero)
                myitem.SubItems.Add(partida.FechaIniLlenado.ToString("dd/MM/yyyy HH:mm"))
                myitem.SubItems.Add(partida.FechaFinLlenado.ToString("dd/MM/yyyy HH:mm"))
                myitem.SubItems.Add(partida.Tolva)
                myitem.SubItems.Add(partida.Kilos)
                myitem.SubItems.Add(OleosigDB1.recoleccion.AsEnumerable.First(Function(cal As oleosigDB.recoleccionRow) cal.codigo = codigo).nombre)
                myitem.SubItems.Add(OleosigDB1.variedades.AsEnumerable.First(Function(var As oleosigDB.variedadesRow) var.varcodigo = variedad).varnombre)
                suma += CUInt(partida.Kilos)
            Next



            listaPartidas.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent)
            listaPartidas.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent)
            listaPartidas.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent)

            ancho = 0

            For i = 0 To listaPartidas.Columns.Count - 1
                ancho = ancho + listaPartidas.Columns(i).Width
            Next

            listaPartidas.Width = ancho + SystemInformation.VerticalScrollBarWidth
        End If
        lbltotal.Text = suma.ToString
    End Sub

    Private Sub rellena_tabla_tickets()
        Dim myitempartida As System.Windows.Forms.ListViewItem
        Dim partida As oleosigDB.partidasaceitunaRow

        tablaLotes.Rows.Clear()

        For Each myitempartida In listaPartidas.Items
            If myitempartida.Checked Then
                partida = oParAceituna.getByNumPartida((myitempartida.Text))

                add_tickets(oTickets.GetDataByFechasVariedad(partida.FechaIniLlenado, partida.FechaFinLlenado, partida.Calidad, partida.Tolva, partida.Variedad), partida)

            End If

        Next myitempartida


    End Sub

    Private Sub add_tickets(ByVal tickets As oleosigDB.lotesaceitunaDataTable, ByVal partida As oleosigDB.partidasaceitunaRow)
        Dim ticket As oleosigDB.lotesaceitunaRow
        Dim oSocio As cosecheroTableAdapter
        Dim oMoltur As opfabricaTableAdapter

        Dim ancho As Short

        oSocio = New cosecheroTableAdapter(Almazara.Id)
        oMoltur = New opfabricaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        If tickets.Count > 0 Then
            For Each ticket In tickets
                tablaLotes.Rows.Add(ticket.Numero, _
                                    ticket.Fecha.ToString("dd/MM/yyyy HH:mm"), _
                                    ticket.Kilos, _
                                    ticket.Cosechero, _
                                    OleosigDB1.recoleccion.First(Function(cal As oleosigDB.recoleccionRow) cal.codigo = ticket.Calidad).nombre, _
                                    OleosigDB1.variedades.First(Function(var As oleosigDB.variedadesRow) var.varcodigo = ticket.Variedad).varnombre, _
                                    ticket.Bascula, _
                                    partida.Tolva, _
                                    partida.Numero)
            Next ticket

            tablaLotes.AutoResizeColumn(1, DataGridViewAutoSizeColumnMode.AllCells)
            tablaLotes.AutoResizeColumn(3, DataGridViewAutoSizeColumnMode.AllCells)

            ancho = 0

            For i As Integer = 0 To tablaLotes.ColumnCount - 1
                ancho = ancho + tablaLotes.Columns(i).Width
            Next
            tablaLotes.Width = ancho + SystemInformation.VerticalScrollBarWidth
        End If
    End Sub



    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ver_informe()

        'If Check1.Checked Then

        get_informe(lbltitulo.Text, lbltotal.Text, listaPartidas)
        'Else

        'get_informe(lbltitulo.Text, lbltotal.Text, listaPartidas)

        'End If

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


        docPDF = New iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 50, 50, 50, 72)
        writer = iTextSharp.text.pdf.PdfWriter.GetInstance(docPDF, New System.IO.FileStream(My.Application.Info.DirectoryPath & "\informe.pdf", IO.FileMode.Create))

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
            docPDF.Add(New iTextSharp.text.Paragraph(Label3.Text & " : " & lbltotal.Text, fuenteParrafo))
            docPDF.Add(New iTextSharp.text.Paragraph("Partidas de Aceituna", fuenteTitulo))
            docPDF.Add(New iTextSharp.text.Paragraph(" "))
            tabla = New iTextSharp.text.pdf.PdfPTable(listadatos.Columns.Count)

            Dim rect As iTextSharp.text.Rectangle = New iTextSharp.text.Rectangle(400, 770)

            tabla.SetWidthPercentage(New Single() {30, 70, 70, 30, 30, 30, 45}, rect)

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
                Dim rect As Rectangle = New Rectangle(400, 770)



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
        docPDF.Close()

        frminicial.VerInforme()

    End Sub

    Private Sub _Toolbar1_Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button1.Click
        get_Datos()
    End Sub

    Private Sub _Toolbar1_Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button2.Click
        ver_informe()
    End Sub




    Private Sub listaPartidas_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles listaPartidas.ItemChecked
        Dim Item As System.Windows.Forms.ListViewItem = sender.FocusedItem
        If actTablaLotes Then
            If Check1.Checked Then rellena_tabla_tickets()
        End If

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Check1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check1.CheckedChanged
        If Check1.Checked Then
            rellena_tabla_tickets()
            actTablaLotes = True
        Else
            tablaLotes.Rows.Clear()
            actTablaLotes = False
        End If
    End Sub


End Class