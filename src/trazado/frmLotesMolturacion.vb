Option Strict Off
Option Explicit On
Imports System.Data
Imports System.Linq


Friend Class frmlotesMolturaciion
    Inherits System.Windows.Forms.Form


    Private IsInitializing As Boolean
    Dim oLotAceite As loteAceiteTableAdapter
    Dim oCopBodega As opbodegaTableAdapter
    Dim oOpAclarado As OpAclaradoTableAdapter
    Dim oCofabrica As opfabricaTableAdapter
    Dim oCpartidas As parAceitunaTableAdapter
    Dim oClotAceituna As LoteAceitunaTableAdapter
    Dim vSlider As frmslider
    Dim detallesMolturDB As detallesOpFabricaTableAdapter
    Dim detallesLotesDB As detallesLoteAceiteTableAdapter
    Dim detallesOpbdgDB As detallesOpBdgTableAdapter

    Dim varDB As variedadesTableAdapter
    Dim recDB As recoleccionTableAdapter
    Dim depositosDB As depositosTableAdapter
    Dim tolvasDB As tolvasTableAdapter


    Private Sub Combo1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Combo1.SelectedIndexChanged
        get_Datos()
    End Sub
    Private Sub get_Datos()

        Dim lote As oleosigDB.loteaceiteRow
        Dim detallesLotes() As oleosigDB.detalles_loteaceiteRow
        Dim opbodega As oleosigDB.opbodegaRow
        Dim detallesopbodega As DataRow()



        Dim detallesopfabrica() As oleosigDB.detalles_opfabricaRow

        Dim OpFabrica As oleosigDB.opfabricaRow
        Dim partidas As DataRow()
        Dim partida As oleosigDB.partidasaceitunaRow
        Dim tickets As oleosigDB.lotesaceitunaDataTable


        If IsInitializing Then
            Exit Sub
        Else

            gridLotes.Rows.Clear()
            gridOpBodega.Rows.Clear()
            gridOpFabrica.Rows.Clear()

            If Combo1.SelectedIndex > -1 Then

                lote = CType(ltAceitBDS.Current, DataRowView).Row

                'colocamos el nombre del tanque
                Label10.Text = OleosigDB1.tanques.First(Function(tan As DataRow) tan("numero") = lote.Tanque)("nombre")

                'colocamos la fecha inicial del lote
                Label11.Text = lote.FechaInicial & " "

                detallesLotes = lote.Getdetalles_loteaceiteRows()

                Dim totalaceite As Integer = 0
                For Each filadetalle As oleosigDB.detalles_loteaceiteRow In detallesLotes
                    totalaceite += filadetalle.kilos
                Next
                lblTotal.Text = totalaceite.ToString

                If IsDBNull(lote.FechaFinal) Then

                    Label12.Text = "Aun está abierto"


                Else
                    'colocamos la fecha final del lote si existe
                    Label12.Text = lote.FechaFinal

                    'rellenamos la tabla de las operaciones de bodega


                    For Each detalle As oleosigDB.detalles_loteaceiteRow In detallesLotes
                        Dim detalletmp As oleosigDB.detalles_loteaceiteRow = detalle
                        Try
                            opbodega = OleosigDB1.opbodega.AsEnumerable.FirstOrDefault(Function(op As oleosigDB.opbodegaRow) (op.Operacion = detalletmp.opbodega))

                            addOpaTablaBodega(opbodega)

                            detallesopbodega = opbodega.Getdetalles_opbodegaRows

                            For Each detalleopbodega As oleosigDB.detalles_opbodegaRow In detallesopbodega

                                oCofabrica.FillDataByOperacion(OleosigDB1.opfabrica, detalleopbodega.Opfabrica)

                                For Each OpFabrica In OleosigDB1.opfabrica.Rows
                                    addOpaTablaMolturacion(OpFabrica)

                                    detallesopfabrica = OpFabrica.Getdetalles_opfabricaRows()

                                    For Each detalleopfabrica As oleosigDB.detalles_opfabricaRow In detallesopfabrica
                                        Dim detaleMltTemp As oleosigDB.detalles_opfabricaRow = detalleopfabrica
                                        partida = OleosigDB1.partidasaceituna.AsEnumerable.SingleOrDefault(Function(par) (par.Numero = detaleMltTemp.partida))
                                        If partida IsNot Nothing Then
                                            addpartidas_Atabla(partida, OpFabrica.operacion.ToString)
                                            tickets = oClotAceituna.GetDataByFechasVariedad(partida.FechaIniLlenado, partida.FechaFinVaciado, partida.Calidad, partida.Tolva, partida.Variedad)
                                            addpesadas_atabla(tickets, partida.Numero)
                                        End If
                                    Next
                                Next

                            Next

                        Catch ex As Exception
                        End Try
                    Next

                End If
            End If
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End If

    End Sub


    Private Sub Combo1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        KeyAscii = 0
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub frmlotesMolturaciion_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        vSlider = New frmslider
        vSlider.mensaje = "Cargando Datos"
        vSlider.Show(Me)

        tolvasDB = New tolvasTableAdapter(Almazara.Id)

        bkworker.RunWorkerAsync()

        varDB = New variedadesTableAdapter(Almazara.Id)
        varDB.Fill(OleosigDB1.variedades)

        recDB = New recoleccionTableAdapter(Almazara.Id)
        recDB.Fill(OleosigDB1.recoleccion)

        depositosDB = New depositosTableAdapter(Almazara.Id)
        depositosDB.Fill(OleosigDB1.tanques)


        lbcooperativa.Text = Almazara.Nombre
        lbdireccion.Text = Almazara.Direccion



        gridOpBodega.RowHeadersVisible = False
        gridOpFabrica.RowHeadersVisible = False
        gridPartidas.RowHeadersVisible = False
        gridLotes.RowHeadersVisible = False



        inicia_Componentes()

    End Sub

    Private Sub inicia_Componentes()

    End Sub




    Private Sub rellenaTablaFabrica(ByVal Operacion As oleosigDB.opfabricaRow, ByVal aclarado As String)


        Dim fila As String() = {Operacion.operacion, _
                                Operacion.fechaini, _
                                Operacion.fechafin, _
                                Operacion.lineafabrica, aclarado}

        gridOpFabrica.Rows.Add(fila)


    End Sub

    Private Sub addOpaTablaMolturacion(ByVal operacion As oleosigDB.opfabricaRow)
        Try
            gridOpFabrica.Rows.Add(operacion(5), operacion(2), operacion(3), operacion(4))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub addOpaTablaBodega(ByVal operacion As oleosigDB.opbodegaRow)
        If operacion IsNot Nothing Then
            gridOpBodega.Rows.Add(operacion.Operacion, operacion.FechaInicial.ToString("dd/MM/yyyy"), operacion.FechaFinal.ToString("dd/MM/yyyy"), OleosigDB1.tanques.First(Function(tq As oleosigDB.tanquesRow) tq.Numero = operacion.Tanque).Nombre)
        End If
    End Sub


    Private Sub addpartidas_Atabla(ByVal Operacion As oleosigDB.partidasaceitunaRow, ByVal moltur As String)
        If Operacion IsNot Nothing Then
            gridPartidas.Rows.Add(Operacion.Numero, Operacion.FechaIniLlenado, Operacion.FechaFinLlenado, OleosigDB1.tolvas.First(Function(tv As oleosigDB.tolvasRow) tv.Numero = Operacion.Tolva).Nombre)
        End If
    End Sub

    Private Sub addpesadas_atabla(ByVal operaciones As oleosigDB.lotesaceitunaDataTable, ByVal part As String)



        For Each operacion As oleosigDB.lotesaceitunaRow In operaciones
            Dim op As oleosigDB.lotesaceitunaRow = operacion
            gridLotes.Rows.Add(operacion.Numero.ToString(), _
                               operacion.Cosechero.ToString(), _
                               operacion.Termino.ToString(), _
                               operacion.Parcela.ToString(), _
                               operacion.Poligono.ToString(), _
                               operacion.Kilos.ToString(), _
                               OleosigDB1.variedades.AsEnumerable.First(Function(var As DataRow) var("varcodigo") = op.Variedad)("varnombre"), _
                               OleosigDB1.recoleccion.AsEnumerable.First(Function(cal As DataRow) cal("codigo") = op.Calidad)("nombre"), _
                               operacion.Tolva.ToString, _
                               part)
        Next
    End Sub


    Public Sub ver_informe()
        Dim cuentalineas As Integer = 0
        Dim filatabla As Integer = 0
        Dim fin As Boolean = False
        Dim docPDF As iTextSharp.text.Document
        Dim tablaOpbdg As iTextSharp.text.pdf.PdfPTable
        Dim tablaMoltur As iTextSharp.text.pdf.PdfPTable
        Dim tablaPartidas As iTextSharp.text.pdf.PdfPTable
        Dim tablatickets As iTextSharp.text.pdf.PdfPTable
        Dim writer As iTextSharp.text.DocWriter
        Dim fuenteCabTabla As iTextSharp.text.Font
        Dim fuenteTabla As iTextSharp.text.Font
        Dim fuenteTitulo As iTextSharp.text.Font
        Dim fuenteParrafo As iTextSharp.text.Font
        Dim pathtoarchivo As String
        Dim mivisor As frmvisor

        Dim fileinf As System.IO.StreamWriter
        Dim i As Short
        Dim j As Short


        pathtoarchivo = System.IO.Path.Combine(My.Application.Info.DirectoryPath, "informe.pdf")
        docPDF = New iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 50, 50, 50, 72)
        writer = iTextSharp.text.pdf.PdfWriter.GetInstance(docPDF, New System.IO.FileStream(pathtoarchivo, IO.FileMode.Create))

        fuenteCabTabla = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)
        fuenteTabla = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL)
        fuenteTitulo = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD)
        fuenteParrafo = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL)


        docPDF.Open()




        cuentalineas = 1

        docPDF.Add(New iTextSharp.text.Paragraph("Informe de Trazabilidad", fuenteTitulo))
        docPDF.Add(New iTextSharp.text.Paragraph(Almazara.Nombre, fuenteParrafo))
        docPDF.Add(New iTextSharp.text.Paragraph(Almazara.Direccion, fuenteParrafo))
        docPDF.Add(New iTextSharp.text.Paragraph("Fecha impresion : " & Now.ToString("dd/MM/yyyy HH:mm"), fuenteParrafo))
        docPDF.Add(New iTextSharp.text.Paragraph("Lote : " & Combo1.Text & vbTab & " Kilos : " & lblTotal.Text, fuenteParrafo))
        docPDF.Add(New iTextSharp.text.Paragraph("Operaciones de Bodega", fuenteTitulo))
        docPDF.Add(New iTextSharp.text.Paragraph(" "))
        tablaOpbdg = New iTextSharp.text.pdf.PdfPTable(gridOpBodega.Columns.Count)

        Dim rectopbdg As iTextSharp.text.Rectangle = New iTextSharp.text.Rectangle(350, 770)

        tablaOpbdg.SetWidthPercentage(New Single() {40, 120, 120, 30}, rectopbdg)

        For i = 0 To gridOpBodega.Columns.Count - 1
            Dim cell As iTextSharp.text.pdf.PdfPCell = New iTextSharp.text.pdf.PdfPCell(New iTextSharp.text.Phrase(gridOpBodega.Columns(i).HeaderText, fuenteCabTabla))
            tablaOpbdg.AddCell(cell)

        Next

        If gridOpBodega.Rows.Count > 0 Then

            For i = 0 To gridOpBodega.Rows.Count - 1
                For j = 0 To gridOpBodega.Columns.Count - 1
                    If Len(gridOpBodega(j, i).Value) > 0 Then
                        tablaOpbdg.AddCell(New iTextSharp.text.Phrase(gridOpBodega(j, i).Value, fuenteTabla))
                    Else
                        tablaOpbdg.AddCell(" ")
                    End If
                Next j
            Next i
        End If
        docPDF.Add(tablaOpbdg)
        docPDF.Add(New iTextSharp.text.Paragraph(" "))
        docPDF.Add(New iTextSharp.text.Paragraph("Molturaciones", fuenteTitulo))
        docPDF.Add(New iTextSharp.text.Paragraph(" "))

        tablaMoltur = New iTextSharp.text.pdf.PdfPTable(gridOpFabrica.Columns.Count)

        Dim rectopfab As iTextSharp.text.Rectangle = New iTextSharp.text.Rectangle(350, 700)

        tablaMoltur.SetWidthPercentage(New Single() {40, 120, 120, 30}, rectopfab)

        For i = 0 To gridOpFabrica.Columns.Count - 1
            tablaMoltur.AddCell(New iTextSharp.text.Phrase(gridOpFabrica.Columns(i).HeaderText, fuenteCabTabla))
        Next i

        If gridOpFabrica.Rows.Count > 0 Then
            For i = 0 To gridOpFabrica.Rows.Count - 1
                For j = 0 To gridOpFabrica.Columns.Count - 1
                    If Len(gridOpFabrica(j, i).Value) > 0 Then
                        tablaMoltur.AddCell(New iTextSharp.text.Phrase(gridOpFabrica(j, i).Value, fuenteTabla))
                    Else
                        tablaMoltur.AddCell(" ")
                    End If
                Next j
            Next i
        End If

        docPDF.Add(tablaMoltur)


        'mostramos la tabla de partidas de aceituna
        docPDF.Add(New iTextSharp.text.Paragraph(" "))
        docPDF.Add(New iTextSharp.text.Paragraph("Partidas de aceituna", fuenteTitulo))
        docPDF.Add(New iTextSharp.text.Paragraph(" "))

        tablaPartidas = New iTextSharp.text.pdf.PdfPTable(gridPartidas.Columns.Count)


        For i = 0 To gridPartidas.Columns.Count - 1
            tablaPartidas.AddCell(New iTextSharp.text.Phrase(gridPartidas.Columns(i).HeaderText, fuenteCabTabla))
        Next i


        If gridPartidas.Rows.Count > 0 Then
            For i = 0 To gridPartidas.Rows.Count - 1


                For j = 0 To gridPartidas.Columns.Count - 1


                    If Len(gridPartidas(j, i).Value) > 0 Then
                        tablaPartidas.AddCell(New iTextSharp.text.Phrase(gridPartidas(j, i).Value, fuenteTabla))
                    Else
                        tablaPartidas.AddCell(" ")
                    End If

                Next j


            Next i
        End If
        docPDF.Add(tablaPartidas)
        docPDF.Add(New iTextSharp.text.Paragraph(" "))

        'mostramos la tabla de lotes de aceitunas
        docPDF.Add(New iTextSharp.text.Paragraph(" "))
        docPDF.Add(New iTextSharp.text.Paragraph("Tickets Aceituna", fuenteTitulo))
        docPDF.Add(New iTextSharp.text.Paragraph(" "))


        Dim rectLotTickets As New iTextSharp.text.Rectangle(300, 770)


        tablatickets = New iTextSharp.text.pdf.PdfPTable(gridLotes.Columns.Count)

        tablatickets.SetWidthPercentage(New Single() {30, 30, 30, 30, 30, 30, 40, 30, 30, 30}, rectLotTickets)

        For i = 0 To gridLotes.Columns.Count - 1
            tablatickets.AddCell(New iTextSharp.text.Phrase(gridLotes.Columns(i).HeaderText, fuenteCabTabla))
        Next i

        If gridLotes.Rows.Count > 0 Then
            For i = 0 To gridLotes.Rows.Count - 1


                For j = 0 To gridLotes.Columns.Count - 1


                    If Len(gridLotes(j, i).Value) > 0 Then

                        tablatickets.AddCell(New iTextSharp.text.Phrase(gridLotes(j, i).Value, fuenteTabla))
                    Else
                        tablatickets.AddCell(" ")

                    End If


                Next j


            Next i
        End If

        docPDF.Add(tablatickets)

        docPDF.Close()

        mivisor = New frmvisor
        mivisor.MdiParent = Me.MdiParent
        mivisor.visor.Navigate(New System.Uri(pathtoarchivo))
        mivisor.Show()
    End Sub

    Private Sub gridLotes_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridLotes.Resize
        SSTab1.Width = gridLotes.Width + gridLotes.Left * 2
    End Sub

    Private Sub _Toolbar1_Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button3.Click
        Me.Close()
    End Sub


    Private Sub _Toolbar1_Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button1.Click
        ver_informe()
    End Sub

    Private Sub bkworker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bkworker.DoWork

        oLotAceite = New loteAceiteTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)

        oCopBodega = New opbodegaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)

        oOpAclarado = New OpAclaradoTableAdapter(Almazara.CampañaAct.Clave, Almazara.Id)
        oCofabrica = New opfabricaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        oCpartidas = New parAceitunaTableAdapter(Almazara.CampañaAct.Clave, Almazara.Id)
        oClotAceituna = New LoteAceitunaTableAdapter(Almazara.CampañaAct.Clave, Almazara.Id)
        detallesMolturDB = New detallesOpFabricaTableAdapter(Almazara.Id, Almazara.CampañaAct.clave)
        detallesLotesDB = New detallesLoteAceiteTableAdapter(Almazara.Id, Almazara.CampañaAct.clave)
        detallesOpbdgDB = New detallesOpBdgTableAdapter(Almazara.Id, Almazara.CampañaAct.clave)

        tolvasDB.Fill(OleosigDB1.tolvas)

    End Sub

    Private Sub bkworker_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bkworker.RunWorkerCompleted
        oCopBodega.Fill(OleosigDB1.opbodega)
        oCofabrica.Fill(OleosigDB1.opfabrica)
        oLotAceite.Fill(OleosigDB1.loteaceite)
        oCpartidas.Fill(OleosigDB1.partidasaceituna)

        detallesOpbdgDB.Fill(OleosigDB1.detalles_opbodega)
        detallesMolturDB.Fill(OleosigDB1.detalles_opfabrica)
        detallesLotesDB.Fill(OleosigDB1.detalles_loteaceite)

        vSlider.Close()

    End Sub

    Private Sub ltAceitBDS_CurrentChanged(sender As System.Object, e As System.EventArgs) Handles ltAceitBDS.CurrentChanged
        get_Datos()
    End Sub
End Class