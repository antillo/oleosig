Option Strict Off
Option Explicit On

Imports TwitterVB2
Imports iTextSharp.text



Module MainModule


    Public oConfig As ConfigDB
    Public Almazara As almazaraTableAdapter


    Public Const TITULO_APLICACION As String = "Oleosig -Trazabilidad"
    Private Const LINEASPORPAGINA As Integer = 45



    Public Sub carga_campañas()

        frmCampagnas.ShowDialog()

    End Sub

    Friend Sub carga_almazara(ByVal numalmazara As Integer)
        Almazara = New almazaraTableAdapter(numalmazara)

    End Sub

    Public Sub inicia()




        oConfig = New ConfigDB


        frminicial.Left = 0
        frminicial.Top = 0
        frminicial.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width
        frminicial.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height
        frminicial.Text = TITULO_APLICACION 'Almazara.Nombre
        frminicial.Show()

    End Sub



    Friend Sub get_informe(ByVal titulo As String, ByVal total As String, ByVal listadatos As ListView)
        Dim cuentalineas As Integer = 0

        Dim docPDF As iTextSharp.text.Document
        Dim tabla As iTextSharp.text.pdf.PdfPTable
        Dim writer As iTextSharp.text.DocWriter

        

        docPDF = New Document(PageSize.A4, 50, 50, 50, 72)
        writer = iTextSharp.text.pdf.PdfWriter.GetInstance(docPDF, New System.IO.FileStream(My.Application.Info.DirectoryPath & "\informe.pdf", IO.FileMode.Create))

        docPDF.Open()

        For Each myitem As ListViewItem In listadatos.Items

            If cuentalineas = 0 Then
        
                docPDF.Add(New Paragraph(titulo, New Font(Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.BOLD)))
                docPDF.Add(New Paragraph(Almazara.Nombre))
                docPDF.Add(New Paragraph(Almazara.Direccion))

                docPDF.Add(New Phrase("Total : " & total.ToString))
                tabla = New pdf.PdfPTable(listadatos.Columns.Count - 1)
                'Dim rect As Rectangle = New Rectangle(500, 770)

                'tabla.SetWidthPercentage(New Single() {50, 150, 150, 50}, rect)

                For i As Integer = 0 To listadatos.Columns.Count - 2
                    Dim cell As pdf.PdfPCell = New pdf.PdfPCell(New Phrase(listadatos.Columns(i).Text))
                    tabla.AddCell(cell)

                Next


            End If

            For Each subitem As ListViewItem.ListViewSubItem In myitem.SubItems


                If subitem.Text.Length > 0 Then
                    tabla.AddCell(subitem.Text)
                End If


            Next

            cuentalineas += 1

            If cuentalineas = LINEASPORPAGINA Then

                cuentalineas = 0
                docPDF.Add(tabla)
            End If
        Next
        If listadatos.Items.Count < LINEASPORPAGINA Then
            docPDF.Add(tabla)
        End If
        docPDF.Close()

        ver_informe()

    End Sub

    Friend Sub get_informe(ByVal titulo As String, ByVal total As String, ByVal listadatos As ListView, ByVal tablatickets As DataGridView)

        Dim cuentalineas As Integer = 0
        Dim cab_part_puesta As Boolean = False
        Dim cab_ticket_puesta As Boolean = False
        Dim docPDF As iTextSharp.text.Document
        Dim writer As pdf.PdfWriter
        Dim masterTabla As pdf.PdfPTable
        Dim detalleTabla As pdf.PdfPTable


        docPDF = New Document(PageSize.A4, 50, 50, 50, 72)
        writer = iTextSharp.text.pdf.PdfWriter.GetInstance(docPDF, New System.IO.FileStream(My.Application.Info.DirectoryPath & "\informe.pdf", IO.FileMode.Create))

        docPDF.Open()


        For Each myitem As ListViewItem In listadatos.Items

            If cab_part_puesta = False Then
                docPDF.Add(New Paragraph(titulo, New Font(Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.BOLD)))
                docPDF.Add(New Paragraph(Almazara.Nombre))
                docPDF.Add(New Paragraph(Almazara.Direccion))

                docPDF.Add(New Phrase("Total : " & total.ToString))
                masterTabla = New pdf.PdfPTable(listadatos.Columns.Count - 1)



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
                detalleTabla = New pdf.PdfPTable(tablatickets.ColumnCount)



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

        ver_informe()

    End Sub

    Private Sub ver_informe()


        frminicial.VerInforme()

    End Sub

End Module