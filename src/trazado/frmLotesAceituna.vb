Option Strict Off
Option Explicit On

Imports System.Text
Imports iTextSharp.text

Friend Class frmLotesAceituna
    Inherits System.Windows.Forms.Form



    Dim oLotAceituna As LoteAceitunaTableAdapter
    Dim oPartAceituna As parAceitunaTableAdapter
    Dim oMoltur As opfabricaTableAdapter
    Dim opbdgDB As opbodegaTableAdapter
    Dim olotDB As loteAceiteTableAdapter

    Dim detalleMolturDB As detallesOpFabricaTableAdapter
    Dim detalleOpbdgDB As detallesOpBdgTableAdapter

    Dim visor As frmvisor


    Dim varDB As variedadesTableAdapter
    Dim recDB As recoleccionTableAdapter
    Dim depositosDB As depositosTableAdapter

    Dim tolvasDB As tolvasTableAdapter

    Private vslider As frmslider


    'UPGRADE_WARNING: El evento Option1.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Option1_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option1.CheckedChanged
        If eventSender.Checked Then


            DTPicker1.Enabled = False
            DTPicker2.Enabled = False
            cmbTolvas.Enabled = False


        End If
    End Sub

    'UPGRADE_WARNING: El evento Option2.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Option2_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option2.CheckedChanged
        If eventSender.Checked Then

            DTPicker1.Enabled = True
            DTPicker2.Enabled = True
            cmbTolvas.SelectedIndex = -1
            cmbTolvas.Text = "Tolvas"
            cmbTolvas.Enabled = False

        End If
    End Sub

    'UPGRADE_WARNING: El evento Option3.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Option3_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option3.CheckedChanged
        If eventSender.Checked Then

            DTPicker1.Enabled = False
            DTPicker2.Enabled = False
            cmbTolvas.Enabled = True

        End If
    End Sub

    'UPGRADE_WARNING: El evento Option4.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Option4_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option4.CheckedChanged
        If eventSender.Checked Then

            DTPicker1.Enabled = True
            DTPicker2.Enabled = True
            cmbTolvas.Enabled = True

        End If
    End Sub




    Private Sub ver_informe()
        Dim i As Short
        Dim j As Short
        Dim cuentalineas As Short
        Dim filatabla As Short

        Dim fin As Boolean

        Dim docPdf As Document
        Dim writer As pdf.PdfWriter
        Dim tabla As pdf.PdfPTable
        Dim fuenteCabTabla As iTextSharp.text.Font
        Dim fuenteTabla As iTextSharp.text.Font
        Dim fuenteTitulo As iTextSharp.text.Font
        Dim fuenteParrafo As iTextSharp.text.Font


        fin = False
        filatabla = 0
        cuentalineas = 0

        docPdf = New Document(PageSize.A4, 50, 50, 50, 72)
        docPdf.AddTitle("Control de entradas de aceituna")


        fuenteCabTabla = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD)
        fuenteTabla = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL)
        fuenteTitulo = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD)
        fuenteParrafo = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL)

        writer = pdf.PdfWriter.GetInstance(docPdf, New System.IO.FileStream(My.Application.Info.DirectoryPath & "\" & "informe.pdf", IO.FileMode.Create))
        docPdf.Open()


        '----------------------------------------------------------

        While fin = False
            cuentalineas = 1

            docPdf.Add(New Paragraph(Label2.Text, fuenteTitulo))
            docPdf.Add(New Paragraph(Almazara.Nombre, fuenteParrafo))
            docPdf.Add(New Paragraph(Almazara.Direccion, fuenteParrafo))

            docPdf.Add(New Paragraph("Fecha impresión : " & Now.ToString("dd/MM/yyyy HH:mm"), fuenteParrafo))
            docPdf.Add(New Paragraph(Label4.Text & " " & totaltxt.Text, fuenteParrafo))
            docPdf.Add(New Paragraph("Tickets de Aceituna", fuenteTitulo))
            docPdf.Add(New Paragraph(" "))

            tabla = New pdf.PdfPTable(tabladatos.ColumnCount)
            Dim rect As Rectangle = New Rectangle(400, 770)
            tabla.SetWidthPercentage(New Single() {25, 60, 30, 30, 35, 30, 30, 45, 30, 35, 25, 25, 35}, rect)

            For i = 0 To Me.tabladatos.Columns.Count - 1
                tabla.AddCell(New Phrase(tabladatos.Columns(i).HeaderText, fuenteCabTabla))
            Next i


            While cuentalineas <= 45
                If filatabla <= tabladatos.Rows.Count - 1 Then


                    For j = 0 To tabladatos.Columns.Count - 1

                        If Len(tabladatos(j, filatabla).Value) > 0 Then
                            tabla.AddCell(New Phrase(tabladatos(j, filatabla).Value.ToString, fuenteTabla))

                        Else
                            tabla.AddCell(New Phrase(" "))

                        End If

                    Next j


                    filatabla = filatabla + 1
                Else
                    fin = True
                    cuentalineas = 126
                End If
                cuentalineas = cuentalineas + 1
            End While

            docPdf.Add(tabla)
            If fin = False Then
                docPdf.NewPage()
            End If

        End While

        docPdf.Close()


        frminicial.VerInforme()


    End Sub

    Public Sub ver_datos()
        Dim Kilos As Integer
        Dim lotes
        Dim i, ancho As Integer
        Dim numMoltur As Integer
        Dim numDep As Integer
        Dim nmDep As String

        If OleosigDB1.variedades.Rows.Count = 0 Or OleosigDB1.recoleccion.Rows.Count = 0 Then
            MsgBox("Debe configurar correctamente las variedades y la calidad", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Kilos = 0
        totaltxt.Text = ""


        If Option1.Checked = True Then 'todos los lotes de aceituna
            If chkVar.CheckedItems.Count > 0 Then
                Dim var As New System.Collections.Generic.List(Of Integer)

                For i = 0 To chkVar.CheckedItems.Count - 1

                    var.Add(CType(chkVar.CheckedItems(i), DataRowView).Row("varcodigo"))
                Next

                lotes = From lottmp In OleosigDB1.lotesaceituna Select lottmp Where lottmp.Variedad = var(0) Or var(1)   ' oLotAceituna.GetDatabyVariedades(var)
            Else
                lotes = From lottmp In OleosigDB1.lotesaceituna Select lottmp
            End If
        End If

        If Option2.Checked = True Then ' todas las tolvas pero con fechas

            If DTPicker1.Value <= DTPicker2.Value Then

                lotes = From lottmp In OleosigDB1.lotesaceituna Select lottmp Where lottmp.Fecha >= DTPicker1.Value And lottmp.Fecha <= DTPicker2.Value

            Else

                MsgBox("La fecha inicial debe ser menor o igual a la fecha final", MsgBoxStyle.Exclamation)

            End If
        End If

        If Option3.Checked = True Then ' todas las fecha seleccionando tolva

            If cmbTolvas.SelectedIndex >= 0 Then
                lotes = From lottmp In OleosigDB1.lotesaceituna Select lottmp Where lottmp.Tolva = (cmbTolvas.SelectedIndex + 1)
            Else
                MsgBox("Debe seleccionar una tolva", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

        End If

        If Option4.Checked = True Then
            If DTPicker1.Value <= DTPicker2.Value Then

                If cmbTolvas.SelectedIndex >= 0 Then
                    lotes = From lottmp In OleosigDB1.lotesaceituna Select lottmp Where lottmp.Fecha >= DTPicker1.Value And lottmp.Fecha <= DTPicker2.Value And lottmp.Tolva = (cmbTolvas.SelectedIndex + 1)
                Else
                    MsgBox("Debe seleccionar una tolva", MsgBoxStyle.Exclamation)
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Exit Sub
                End If
            Else
                MsgBox("La fecha inicial debe ser menor o igual a la fecha final", MsgBoxStyle.Exclamation)
            End If
        End If


        tabladatos.Rows.Clear()
        For Each lote As oleosigDB.lotesaceitunaRow In lotes
            Try
                Dim lot As oleosigDB.lotesaceitunaRow = lote

                Dim partidas = From par In OleosigDB1.partidasaceituna Select par Where par.FechaIniLlenado <= lot.Fecha And par.FechaFinLlenado >= lot.Fecha And par.Tolva = lot.Tolva And par.Variedad = lot.Variedad


                For Each part As oleosigDB.partidasaceitunaRow In partidas

                    Dim detallesmoltur = From detmoltur In OleosigDB1.detalles_opfabrica Select detmoltur Where detmoltur.partida = part.Numero

                    For Each detallemoltur As oleosigDB.detalles_opfabricaRow In detallesmoltur

                        Dim molturaciones = From mol In OleosigDB1.opfabrica Select mol Where mol.id = detallemoltur.opfabrica


                        numMoltur = 0
                        For Each moltur As oleosigDB.opfabricaRow In molturaciones

                            Dim detallesbodega = From detopbdg In OleosigDB1.detalles_opbodega Select detopbdg Where detopbdg.Opfabrica = moltur.operacion


                            numDep = 0
                            For Each detallebodega As oleosigDB.detalles_opbodegaRow In detallesbodega

                                Dim opsbdg = From opbdg In OleosigDB1.opbodega Select opbdg Where opbdg.Id = detallebodega.Opbodega

                                For Each operacion As oleosigDB.opbodegaRow In opsbdg
                                    numDep = operacion.Tanque

                                Next
                            Next

                            numMoltur = moltur.lineafabrica
                        Next

                    Next
                Next
                If numDep = 0 Then
                    nmDep = "Sin asignar"
                Else
                    nmDep = OleosigDB1.tanques.First(Function(tq As oleosigDB.tanquesRow) tq.Numero = numDep).Nombre
                End If
                Dim filatabla As String() = {lote.Numero.ToString, _
                                      lote.Fecha.ToString("dd/MM/yyyy HH:mm"), _
                                      lote.Cosechero, _
                                      lote.Termino, _
                                      lote.Poligono.ToString, _
                                      lote.Parcela.ToString, _
                                      lote.Kilos.ToString, _
                                      OleosigDB1.variedades.AsEnumerable.First(Function(var As oleosigDB.variedadesRow) var.varcodigo = lot.Variedad).varnombre, _
                                      OleosigDB1.recoleccion.AsEnumerable.First(Function(cal As oleosigDB.recoleccionRow) cal.codigo = lot.Calidad).nombre, _
                                      lote.Bascula.ToString, _
                                      lote.Tolva.ToString, _
                                      numMoltur.ToString, _
                                    nmDep}

                tabladatos.Rows.Add(filatabla)

                Kilos = Kilos + lote.Kilos
            Catch ex As Exception
                'MsgBox(numDep.ToString)
            End Try

        Next

        totaltxt.Text = Kilos.ToString & " "

        Me.Cursor = System.Windows.Forms.Cursors.Default
        tabladatos.AutoResizeColumns()
        ancho = 0
        For i = 0 To tabladatos.ColumnCount - 1
            ancho += tabladatos.Columns(i).Width
        Next
        Me.Width = ancho + SystemInformation.VerticalScrollBarWidth + SystemInformation.Border3DSize.Width * 6
        Me.Left = (frminicial.ClientSize.Width - Me.Width) / 2

    End Sub


    Private Sub inicia_Componentes()

        vslider = New frmslider
        vslider.mensaje = "Cargando datos"

        vslider.Show(Me)

        DTPicker1.Value = Now
        DTPicker2.Value = Now

        ponCabeceraTabla()

    End Sub

    Private Sub ponCabeceraTabla()
        Dim ancho, i As Integer

        With tabladatos
            .Columns.Clear()
            .Columns.Add("col0", "Ticket")
            .Columns.Add("col1", "Fecha")
            .Columns.Add("col2", "Nº Socio")
            .Columns.Add("col3", "Término")
            .Columns.Add("col4", "Polígono")
            .Columns.Add("col5", "Parcela")
            .Columns.Add("col6", "Kilos")
            .Columns.Add("col7", "Variedad")
            .Columns.Add("col8", "Calidad")
            .Columns.Add("col9", "Bascula")
            .Columns.Add("col10", "Tolva")
            .Columns.Add("col11", "Linea")
            .Columns.Add("col12", "Deposito")
            .AutoResizeColumns()
        End With
        ancho = 0
        For i = 0 To tabladatos.ColumnCount - 1
            ancho += tabladatos.Columns(i).Width
        Next

        Me.Width = ancho + SystemInformation.VerticalScrollBarWidth + SystemInformation.Border3DSize.Width * 6


    End Sub

    Private Sub frmPatio_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        bkw.RunWorkerAsync()


        inicia_Componentes()

        Option4.Checked = True




    End Sub


    Private Sub _Toolbar1_Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button1.Click
        ver_datos()
    End Sub

    Private Sub _Toolbar1_Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button2.Click
        ver_informe()
    End Sub



    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


    Private Sub bkw_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bkw.DoWork

        oLotAceituna = New LoteAceitunaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        oPartAceituna = New parAceitunaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        oMoltur = New opfabricaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        opbdgDB = New opbodegaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)

        Me.detalleMolturDB = New detallesOpFabricaTableAdapter(Almazara.Id, Almazara.CampañaAct.clave)
        Me.detalleOpbdgDB = New detallesOpBdgTableAdapter(Almazara.Id, Almazara.CampañaAct.clave)


        olotDB = New loteAceiteTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)

        depositosDB = New depositosTableAdapter(Almazara.Id)
        depositosDB.Fill(OleosigDB1.tanques)

        varDB = New variedadesTableAdapter(Almazara.Id)
        varDB.Fill(OleosigDB1.variedades)

        recDB = New recoleccionTableAdapter(Almazara.Id)
        recDB.Fill(OleosigDB1.recoleccion)

        oPartAceituna.Fill(OleosigDB1.partidasaceituna)

        oMoltur.Fill(OleosigDB1.opfabrica)
        detalleMolturDB.Fill(OleosigDB1.detalles_opfabrica)

        opbdgDB.Fill(OleosigDB1.opbodega)
        detalleOpbdgDB.Fill(OleosigDB1.detalles_opbodega)
        oLotAceituna.Fill(OleosigDB1.lotesaceituna)

        tolvasDB = New tolvasTableAdapter(Almazara.Id)





    End Sub

    Private Sub bkw_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bkw.RunWorkerCompleted
        chkVar.DataSource = OleosigDB1.variedades
        chkVar.DisplayMember = "varnombre"
        chkVar.ValueMember = "varcodigo"
        tolvasDB.Fill(OleosigDB1.tolvas)
        vslider.Close()
    End Sub

    Private Sub chkVar_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles chkVar.ItemCheck
        If e.NewValue = CheckState.Checked Then
            If chkVar.CheckedItems.Count = 1 Then

            End If
        End If
    End Sub
End Class