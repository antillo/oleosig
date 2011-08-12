Option Strict Off
Option Explicit On

Imports iTextSharp.text

Friend Class frmSocios
    Inherits System.Windows.Forms.Form


    Dim oCSocio As cosecheroTableAdapter

    Dim oOpbodega As opbodegaTableAdapter
    Dim detOpBdgDB As detallesOpBdgTableAdapter

    Dim oMoltur As opfabricaTableAdapter
    Dim detOpFabricaDB As detallesOpFabricaTableAdapter

    Dim oLotesAceituna As LoteAceitunaTableAdapter
    Dim oPartidas As parAceitunaTableAdapter

    Dim visor As frmvisor


    Dim varDB As variedadesTableAdapter
    Dim recDB As recoleccionTableAdapter

    Private Const WM_SETREDRAW As Integer = &HB
    Const LINEASPORPAGINA As Integer = 45

    Private Sub get_informe()
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

            docPDF.Add(New iTextSharp.text.Paragraph("Informe por Cosechero", fuenteTitulo))
            docPDF.Add(New iTextSharp.text.Paragraph(Almazara.Nombre, fuenteParrafo))
            docPDF.Add(New iTextSharp.text.Paragraph(Almazara.Direccion, fuenteParrafo))
            docPDF.Add(New iTextSharp.text.Paragraph("Fecha impresion : " & Now.ToString("dd/MM/yyyy HH:mm"), fuenteParrafo))

            docPDF.Add(New iTextSharp.text.Paragraph("Trazado", fuenteTitulo))
            docPDF.Add(New iTextSharp.text.Paragraph(" "))
            tabla = New iTextSharp.text.pdf.PdfPTable(tablaPesos.Columns.Count)

            Dim rect As iTextSharp.text.Rectangle = New iTextSharp.text.Rectangle(350, 770)

            tabla.SetWidthPercentage(New Single() {50, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30}, rect)

            For i As Integer = 0 To tablaPesos.Columns.Count - 1
                Dim cell As iTextSharp.text.pdf.PdfPCell = New iTextSharp.text.pdf.PdfPCell(New iTextSharp.text.Phrase(tablaPesos.Columns(i).HeaderText, fuenteCabTabla))
                tabla.AddCell(cell)

            Next

            While cuentalineas <= LINEASPORPAGINA
                If filatabla < tablaPesos.RowCount - 1 Then



                    For j As Integer = 1 To tablaPesos.Columns.Count - 1


                        If tablaPesos(j, filatabla).Value.ToString > 0 Then
                            tabla.AddCell(New iTextSharp.text.Phrase(tablaPesos(j, filatabla).Value, fuenteTabla))
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

        visor = New frmvisor
        visor.MdiParent = Me.MdiParent

        visor.visor.Navigate(New System.Uri(My.Application.Info.DirectoryPath & "\" & "informe.pdf"))

        visor.Show()


    End Sub

    Private Sub cmdBuscar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBuscar.Click
        Dim entCosechero As oleosigDB.cosecherosRow
        Dim result As Integer

        If Len(nombreCostxt.Text) > 0 Then
            entCosechero = oCSocio.GetByNombre(nombreCostxt.Text)
            If Len(entCosechero.Codigo) > 0 Then

                niftxt.Text = entCosechero.nif

                result = ComboCodigos.FindStringExact(entCosechero.codigo.ToString)



                ComboCodigos.SelectedIndex = result
            End If
        End If

    End Sub

    'UPGRADE_WARNING: El evento ComboCodigos.SelectedIndexChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub ComboCodigos_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ComboCodigos.SelectedIndexChanged

        rellena_tabla()

    End Sub




    'UPGRADE_WARNING: El evento chkAll.CheckStateChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub chkAll_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkAll.CheckStateChanged
        Select Case chkAll.CheckState
            Case 0
                Me.fechafin.Enabled = True
                Me.fechaini.Enabled = True
            Case 1
                Me.fechafin.Enabled = False
                Me.fechaini.Enabled = False
        End Select
    End Sub



    Private Sub ComboCodigos_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles ComboCodigos.KeyUp
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        Dim sComboText As String = ""
        Dim iLoop As Integer
        Dim sTempString As String


        If KeyCode >= 48 And KeyCode <= 57 Then

            sTempString = ComboCodigos.Text

            If Len(sTempString) = 1 Then sComboText = sTempString


            'lReturn = SendMessage(ComboCodigos.Handle.ToInt32, WM_SETREDRAW, False, 0)

            For iLoop = 0 To (ComboCodigos.Items.Count - 1)

                If UCase(sTempString & Mid(ComboCodigos.Items(iLoop), Len(sTempString) + 1)) = UCase(ComboCodigos.Items(iLoop)) Then
                    ComboCodigos.SelectedIndex = iLoop
                    ComboCodigos.Text = ComboCodigos.Items(iLoop)
                    ComboCodigos.SelectionStart = Len(sTempString)
                    ComboCodigos.SelectionLength = Len(ComboCodigos.Text) - (Len(sTempString))
                    sComboText = sComboText & Mid(sTempString, Len(sComboText) + 1)
                    Exit For
                Else
                    If InStr(UCase(sTempString), UCase(sComboText)) Then
                        sComboText = sComboText & Mid(sTempString, Len(sComboText) + 1)
                        ComboCodigos.Text = sComboText
                        ComboCodigos.SelectionStart = Len(ComboCodigos.Text)
                    Else
                        sComboText = sTempString
                    End If
                End If

            Next iLoop
            '  lReturn = SendMessage(ComboCodigos.Handle.ToInt32, WM_SETREDRAW, True, 0)
        End If

    End Sub

    Private Sub frmSocios_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        oLotesAceituna = New LoteAceitunaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        oPartidas = New parAceitunaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        oMoltur = New opfabricaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        varDB = New variedadesTableAdapter(Almazara.Id)
        recDB = New recoleccionTableAdapter(Almazara.Id)
        oOpbodega = New opbodegaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        detOpBdgDB = New detallesOpBdgTableAdapter(Almazara.Id, Almazara.CampañaAct.clave)
        detOpFabricaDB = New detallesOpFabricaTableAdapter(Almazara.Id, Almazara.CampañaAct.clave)


        oCSocio = New cosecheroTableAdapter(Almazara.Id)

        varDB.Fill(OleosigDB1.variedades)
        recDB.Fill(OleosigDB1.recoleccion)
        oPartidas.Fill(OleosigDB1.partidasaceituna)
        detOpBdgDB.Fill(OleosigDB1.detalles_opbodega)
        detOpFabricaDB.Fill(OleosigDB1.detalles_opfabrica)
        oMoltur.Fill(OleosigDB1.opfabrica)
        oOpbodega.Fill(OleosigDB1.opbodega)


        fechaini.Value = Now
        fechafin.Value = Now


        inicia_Componentes()

    End Sub
    Private Sub inicia_Componentes()

        Dim sum As Integer
        Dim colids As System.Collections.Generic.List(Of Integer)

        sum = 0

        chkAll.CheckState = System.Windows.Forms.CheckState.Checked

        pon_Cabecera()
        ponCabeceraVar()
        rellenaVariedades()



        colids = oCSocio.getAllCodSocio

        For Each idSocio As UShort In colids

            ComboCodigos.Items.Add(idSocio)

        Next idSocio

    End Sub
    Private Sub rellena_molturaciones()
    End Sub

    Private Sub ponCabeceraVar()
        Dim i As Integer
        Dim ancho As Integer
        ancho = 0

        listaVar.Columns.Clear()

        listaVar.Columns.Add("Código")

        listaVar.Columns.Add("Variedad")
        listaVar.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        For i = 0 To listaVar.Columns.Count - 1

            ancho += listaVar.Columns.Item(i).Width

        Next i
        listaVar.Width = ancho + SystemInformation.VerticalScrollBarWidth + SystemInformation.Border3DSize.Width * 4
    End Sub
    Private Sub rellenaVariedades()
        Dim myitem As System.Windows.Forms.ListViewItem
        Dim i, ancho As UShort

        For Each variedad As oleosigDB.variedadesRow In OleosigDB1.variedades.Rows

            myitem = listaVar.Items.Add(variedad.varcodigo)
            myitem.SubItems.Add(variedad.varnombre)

            listaVar.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent)
        Next
        ancho = 0
        For i = 0 To listaVar.Columns.Count - 1
            ancho += listaVar.Columns(i).Width
        Next
        listaVar.Width = ancho + SystemInformation.VerticalScrollBarWidth + SystemInformation.Border3DSize.Width * 4
    End Sub
    Public Sub pon_Cabecera()
        Dim i, ancho As UShort

        With tablaPesos

            .Columns.Clear()
            .columns.add("col0", "Fecha")

            .Columns.Add("col1", "Ticket")
            .Columns.Add("col2", "Kilos")
            .Columns.Add("col3", "Variedad")
            .Columns.Add("col4", "Calidad")
            .Columns.Add("col5", "Termino")
            .Columns.Add("col6", "Polígono")
            .Columns.Add("col7", "Parcela")
            .Columns.Add("col8", "Báscula")
            .Columns.Add("col9", "Tolva")
            .Columns.Add("col10", "Linea")
            .Columns.Add("col11", "Depósito")

            .AutoResizeColumns()
            ancho = 0
            For i = 0 To .ColumnCount - 1
                ancho += .Columns(i).Width
            Next
            .Width = ancho + SystemInformation.VerticalScrollBarWidth + SystemInformation.Border3DSize.Width * 4
        End With
    End Sub



    Public Sub rellena_tabla()
        Dim Total As Int64
        Dim socio As oleosigDB.cosecherosRow
        Dim lote As oleosigDB.lotesaceitunaRow



        totalKilos.Text = ""
        Total = 0

        If ComboCodigos.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un cosechero", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim socios As oleosigDB.cosecherosDataTable = oCSocio.GetDataByCodigo(ComboCodigos.SelectedItem)
        If socios.Rows.Count > 0 Then
            socio = socios.Rows(0)
            nombreCostxt.Text = socio.Apellido1 & " " & socio.Apellido2 & ", " & socio.Nombre & " "

            niftxt.Text = socio.Nif
        Else
            nombreCostxt.Clear()
            niftxt.Text = ""
        End If
        


        


        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim oClotesAceituna = oLotesAceituna.GetDatabyCosechero(ComboCodigos.SelectedItem)

        tablaPesos.Rows.Clear()

        For Each lote In oClotesAceituna.Rows
            Try
                Dim partidas = From par As oleosigDB.partidasaceitunaRow In OleosigDB1.partidasaceituna Select par Where par.FechaIniLlenado <= lote.Fecha And par.FechaFinLlenado >= lote.Fecha And par.Tolva = lote.Tolva

                For Each part As oleosigDB.partidasaceitunaRow In partidas
                    Dim partida As oleosigDB.partidasaceitunaRow = part

                    Dim detmolturacion As oleosigDB.detalles_opfabricaRow = OleosigDB1.detalles_opfabrica.First(Function(det As oleosigDB.detalles_opfabricaRow) det.partida = partida.Numero)

                    Dim molturacion As oleosigDB.opfabricaRow = OleosigDB1.opfabrica.First(Function(op As oleosigDB.opfabricaRow) op.id = detmolturacion.opfabrica)

                    Dim detopbdg As oleosigDB.detalles_opbodegaRow = OleosigDB1.detalles_opbodega.First(Function(det As oleosigDB.detalles_opbodegaRow) det.Opfabrica = molturacion.operacion)

                    Dim opbdg As oleosigDB.opbodegaRow = OleosigDB1.opbodega.First(Function(op As oleosigDB.opbodegaRow) op.Id = detopbdg.Opbodega)


                    addPesoaTabla(lote, molturacion.lineafabrica, opbdg.Tanque)



                Next

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next lote
        Me.Cursor = System.Windows.Forms.Cursors.Default


    End Sub

    Private Sub addPesoaTabla(ByVal ticket As oleosigDB.lotesaceitunaRow, ByVal linea As UShort, ByVal deposito As Integer)
        Dim i, ancho As Integer
        tablaPesos.Rows.Add(ticket.Fecha.ToString("dd/MM/yyyy HH:mm"), _
                            ticket.Numero, _
                            ticket.Kilos, _
                            OleosigDB1.variedades.AsEnumerable.First(Function(var As DataRow) var("varcodigo") = ticket.Variedad)("varnombre"), _
                            OleosigDB1.recoleccion.AsEnumerable.First(Function(cal As DataRow) cal("codigo") = ticket.Calidad)("nombre"), _
                            ticket.Termino, _
                            ticket.Poligono, _
                            ticket.Parcela, _
                            ticket.Bascula, _
                            ticket.Tolva, linea)
        tablaPesos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        ancho = 0
        For i = 0 To tablaPesos.ColumnCount - 1
            ancho += tablaPesos.Columns(i).Width
        Next
        tablaPesos.Width = ancho + SystemInformation.VerticalScrollBarWidth + SystemInformation.Border3DSize.Width * 4

    End Sub


    
    


    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub listaVar_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listaVar.Resize
        Frame1.Width = listaVar.Left * 2 + listaVar.Width
    End Sub


    Private Sub tablaPesos_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tablaPesos.Resize
        Frame2.Width = tablaPesos.Left * 2 + tablaPesos.Width
    End Sub

    Private Sub _Toolbar1_Button2_Click(sender As System.Object, e As System.EventArgs) Handles _Toolbar1_Button2.Click
        Me.get_informe()
    End Sub
End Class