Option Strict Off
Option Explicit On

Imports System.Text
Imports iTextSharp

Friend Class frmOpFabrica
    Inherits System.Windows.Forms.Form


    Dim oOpFabrica As Oleosig.opfabricaTableAdapter
    Dim oParAceituna As parAceitunaTableAdapter
    Dim oLotAceituna As LoteAceitunaTableAdapter
    Dim oSocios As cosecheroTableAdapter
    Dim actTickets As Boolean = False
    Dim puentedatos As BindingSource
    Dim vslider As frmslider

    Dim oDetalles As detallesOpFabricaTableAdapter
    Dim pdf As iTextSharp.text.Document

    Dim recDB As recoleccionTableAdapter
    Dim varDB As variedadesTableAdapter

    Const LINEASPORPAGINA As Integer = 38


    'UPGRADE_WARNING: El evento Option1.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Option1_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option1.CheckedChanged
        If eventSender.Checked Then
            Me.DTFechafin.Enabled = False
            Me.DTFechaini.Enabled = False
            Me.listalineas.Enabled = False

        End If
    End Sub

    'UPGRADE_WARNING: El evento Option2.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Option2_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option2.CheckedChanged
        If eventSender.Checked Then
            Me.DTFechafin.Enabled = True
            Me.DTFechaini.Enabled = True
            Me.listalineas.Enabled = False


        End If
    End Sub

    'UPGRADE_WARNING: El evento Option3.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Option3_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option3.CheckedChanged
        If eventSender.Checked Then
            Me.DTFechafin.Enabled = False
            Me.DTFechaini.Enabled = False
            Me.listalineas.Enabled = True


        End If
    End Sub

    'UPGRADE_WARNING: El evento Option4.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Option4_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option4.CheckedChanged
        If eventSender.Checked Then

            Me.DTFechafin.Enabled = True
            Me.DTFechaini.Enabled = True
            Me.listalineas.Enabled = True


        End If
    End Sub

    Private Sub Option5_Click()
        Me.DTFechafin.Enabled = True
        Me.DTFechaini.Enabled = True
        Me.listalineas.Enabled = False

    End Sub

    Private Sub get_datos_tickets()
        Dim Operacion As oleosigDB.opfabricaRow
        Dim partida As oleosigDB.partidasaceitunaRow
        Dim tickets As oleosigDB.lotesaceitunaDataTable

        tablalotes.Rows.Clear()

        For Each myitem As ListViewItem In listaDatos.Items
            If myitem.Checked Then

                Operacion = OleosigDB2.opfabrica.AsEnumerable.First(Function(op As oleosigDB.opfabricaRow) op.operacion = myitem.Text)


                Dim detalles() As oleosigDB.detalles_opfabricaRow = Operacion.Getdetalles_opfabricaRows
                For Each detalle As oleosigDB.detalles_opfabricaRow In detalles
                    partida = oParAceituna.getByNumPartida(detalle.partida)

                    If partida IsNot Nothing Then

                        tickets = oLotAceituna.GetDataByFechasVariedad((partida.FechaIniLlenado), (partida.FechaFinLlenado), partida.Calidad, partida.Tolva, partida.Variedad)

                        Call rellenaLotes(tickets, Operacion.lineafabrica, Operacion.operacion)

                    End If

                Next
            End If
        Next

    End Sub





    Private Sub ponCabecera()
        Dim i, ancho As Integer

        listadatos.Columns.Clear()

        With listaDatos
            .Columns.Add("Molt.")
            .Columns.Add("Fecha Inicio")
            .Columns.Add("Fecha Fin")
            .Columns.Add("Linea")
            .Columns.Add("Kilos")

            .AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

            ancho = 0

            For i = 0 To .Columns.Count - 1
                ancho += .Columns(i).Width
            Next

            .Width = ancho + SystemInformation.VerticalScrollBarWidth + SystemInformation.BorderSize.Width * 4

        End With

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
            .Columns.Add("col8", "Molt")


            .AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader)
            ancho = 0
            For i = 0 To .ColumnCount - 1
                ancho += .Columns(i).Width
            Next
            .Width = ancho + SystemInformation.VerticalScrollBarWidth + SystemInformation.BorderSize.Width * 4
        End With


    End Sub


    Private Sub frmOpFabrica_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        oOpFabrica = New opfabricaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        oParAceituna = New parAceitunaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        oLotAceituna = New LoteAceitunaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        oSocios = New cosecheroTableAdapter(Almazara.Id)
        oDetalles = New detallesOpFabricaTableAdapter(Almazara.Id, Almazara.CampañaAct.clave)

        oOpFabrica.Fill(OleosigDB2.opfabrica)
        oDetalles.Fill(OleosigDB2.detalles_opfabrica)

        recDB = New recoleccionTableAdapter(Almazara.Id)
        recDB.Fill(OleosigDB2.recoleccion)

        varDB = New variedadesTableAdapter(Almazara.Id)
        varDB.Fill(OleosigDB2.variedades)

        ' vslider = New frmslider
        ' vslider.mensaje = "Cargando datos"
        ' vslider.ShowDialog()


        inicia_componentes()


    End Sub

    Private Sub inicia_componentes()
        Dim i As Integer

        DTFechaini.Value = Now
        DTFechafin.Value = Now

        
        ponCabecera()
        ponCabeceraLotes()

        listalineas.Items.Clear()

        For i = 1 To Almazara.Decanters
            listalineas.Items.Add(i.ToString)
        Next i
        listalineas.Text = "Decanter"

        Option4.Checked = True

    End Sub


    Private Sub ver_informe()



        get_informe(Label1.Text, lblTotal.Text, listaDatos)

        

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
            docPDF.Add(New iTextSharp.text.Paragraph(Label4.Text & lblTotal.Text, fuenteParrafo))
            docPDF.Add(New iTextSharp.text.Paragraph("Molturaciones", fuenteTitulo))
            docPDF.Add(New iTextSharp.text.Paragraph(" "))
            tabla = New iTextSharp.text.pdf.PdfPTable(listadatos.Columns.Count)

            Dim rect As iTextSharp.text.Rectangle = New iTextSharp.text.Rectangle(400, 770)

            tabla.SetWidthPercentage(New Single() {50, 150, 150, 30, 30}, rect)

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
        writer = iTextSharp.text.pdf.PdfWriter.GetInstance(docPDF, New System.IO.FileStream(My.Application.Info.DirectoryPath & "\" & "informe.pdf", IO.FileMode.Create))
        docPDF.Open()


        For Each myitem As ListViewItem In listadatos.Items

            If cab_part_puesta = False Then
                docPDF.Add(New iTextSharp.text.Paragraph(titulo, New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.BOLD)))
                docPDF.Add(New iTextSharp.text.Paragraph(Almazara.Nombre))
                docPDF.Add(New iTextSharp.text.Paragraph(Almazara.Direccion))

                docPDF.Add(New iTextSharp.text.Phrase("Total : " & lblTotal.Text.ToString))
                masterTabla = New iTextSharp.text.pdf.PdfPTable(listadatos.Columns.Count)

                For i As Integer = 0 To listadatos.Columns.Count - 1
                    masterTabla.AddCell(listadatos.Columns(i).Text)
                Next i

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
    '####################################################################
    '#
    '#      Descripcion :   Muestra los datos de la consulta
    '#
    '####################################################################
    Private Sub get_datos()

        Dim i As Object
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        ponCabecera()
        ponCabeceraLotes()

        lblTotal.Text = ""

        If Option1.Checked = True Then 'todas las operaciones de fabrica

            oOpFabrica.Fill(OleosigDB2.opfabrica)
            rellenaTabla(OleosigDB2.opfabrica)

        End If

        If Option2.Checked = True Then 'todas las lineas de fabricacion

            oOpFabrica.FillDataByFechas(DTFechaini.Value, DTFechafin.Value, OleosigDB2.opfabrica)
            rellenaTabla(OleosigDB2.opfabrica)

        End If
        If Option3.Checked = True Then 'todas las fecha de la linea
            If listalineas.SelectedIndex >= 0 Then

                oOpFabrica.FillDataByDecanter(CInt(listalineas.Items(listalineas.SelectedIndex)), OleosigDB2.opfabrica)
                rellenaTabla(OleosigDB2.opfabrica)

            End If
        End If
        If Option4.Checked = True Then
            ponCabecera()


            If DTFechaini.Value > DTFechafin.Value Then
                MsgBox("La fecha inicial es posterior o igual a la fecha final")
            End If

            oOpFabrica.FillDataByFechas(DTFechaini.Value, DTFechafin.Value, CInt(listalineas.Items(listalineas.SelectedIndex)), OleosigDB2.opfabrica)
            rellenaTabla(OleosigDB2.opfabrica)




        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub rellenaLotes(ByVal lotes As oleosigDB.lotesaceitunaDataTable, ByVal decanter As String, ByVal molt As UShort)
        Dim i, ancho As Integer
        Dim cosechero As oleosigDB.cosecherosRow
        Dim cosecheros As oleosigDB.cosecherosDataTable
        For Each milote As oleosigDB.lotesaceitunaRow In lotes.Rows
            Dim lote As oleosigDB.lotesaceitunaRow = milote
            Dim rec As UShort = lote.Calidad

            'cosecheros = oSocios.GetDataByCodigo((lote.Cosechero))
            Dim fila As String() = {lote.Numero.ToString, _
                                    lote.Fecha.ToString("dd/MM/yyyy HH:mm"), _
                                    lote.Kilos.ToString, _
                                    lote.Cosechero.ToString, _
                                    OleosigDB2.recoleccion.First(Function(cal As oleosigDB.recoleccionRow) cal.codigo = rec).nombre, _
                                    OleosigDB2.variedades.First(Function(vari As oleosigDB.variedadesRow) vari.varcodigo = lote.Variedad).varnombre, _
                                    lote.Bascula.ToString, _
                                    lote.Tolva.ToString, _
                                    molt.ToString()}

            tablalotes.Rows.Add(fila)

        Next
        tablalotes.AutoResizeColumn(1, DataGridViewAutoSizeColumnMode.AllCellsExceptHeader)
        ancho = 0
        For i = 0 To tablalotes.ColumnCount - 1
            ancho += tablalotes.Columns(i).Width
        Next
        tablalotes.Width = ancho + SystemInformation.VerticalScrollBarWidth + SystemInformation.BorderSize.Width * 4
    End Sub



    Private Sub rellenaTabla(ByVal Operaciones As oleosigDB.opfabricaDataTable)
        Dim i, ancho, suma As Integer
        Dim myitem As ListViewItem


        suma = 0
        listaDatos.Items.Clear()

        For Each operacion As oleosigDB.opfabricaRow In Operaciones.Rows
            myitem = listaDatos.Items.Add(operacion.operacion)

            myitem.SubItems.Add(operacion.fechaini)
            myitem.SubItems.Add(operacion.fechafin)
            myitem.SubItems.Add(operacion.lineafabrica)
            Dim filas() As oleosigDB.detalles_opfabricaRow = operacion.Getdetalles_opfabricaRows()
            Dim parcial As Integer = 0
            For Each fila As oleosigDB.detalles_opfabricaRow In filas
                parcial += fila.kilos
                suma += fila.kilos
            Next
            myitem.SubItems.Add(parcial)



        Next
        If Operaciones.Rows.Count > 0 Then
            listaDatos.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent)
            listaDatos.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent)
            ancho = 0
            For i = 0 To listaDatos.Columns.Count - 1
                ancho += listaDatos.Columns(i).Width
            Next
            listaDatos.Width = ancho + SystemInformation.VerticalScrollBarWidth + SystemInformation.BorderSize.Width * 4

            lblTotal.Text = suma.ToString & " "
        End If
    End Sub

    
   

    Private Sub btnVerdatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerdatos.Click
        get_datos()
    End Sub

    Private Sub btnInforme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInforme.Click
        ver_informe()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


    Private Sub listaDatos_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles listaDatos.ItemChecked
        If actTickets Then
            If CheckBox1.Checked Then get_datos_tickets()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            get_datos_tickets()
            actTickets = True
        Else
            tablalotes.Rows.Clear()
            actTickets = False

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myitem As ListViewItem
        actTickets = False
        For Each myitem In listaDatos.Items
            myitem.Checked = True
        Next
        If CheckBox1.Checked Then get_datos_tickets()
        actTickets = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim myitem As ListViewItem
        actTickets = False
        For Each myitem In listaDatos.Items
            myitem.Checked = False
        Next
        If CheckBox1.Checked Then get_datos_tickets()
        actTickets = True
    End Sub

    Private Sub BkgWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BkgWorker.DoWork
       
    End Sub

    Private Sub BkgWorker_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BkgWorker.RunWorkerCompleted
        vslider.Close()

    End Sub
End Class