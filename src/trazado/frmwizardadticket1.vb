

Public Class frmwizardadticket1

    Private _olotaceituna As LoteAceitunaTableAdapter
    Private impDB As ImportacionTableAdapter
    Private cfgFijoDB As cfgTicketsFijoTableAdapter
    Private cfgDelimDB As TicketDelimTableAdapter
    Private _vistatickets As DataView

    Dim recDB As recoleccionTableAdapter


    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _olotaceituna = New LoteAceitunaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)



        cfgDelimDB = New TicketDelimTableAdapter(Almazara.Id)
        cfgFijoDB = New cfgTicketsFijoTableAdapter(Almazara.Id)
        impDB = New ImportacionTableAdapter(Almazara.Id)


        cfgDelimDB.Fill(OleosigDB1.cfg_imp_ticket_delimitado)
        cfgFijoDB.Fill(OleosigDB1.cfg_imp_ticket_fijo)
        impDB.Fill(OleosigDB1.importaciones_ticket)
        _olotaceituna.Fill(OleosigDB1.lotesaceituna)

        _vistatickets = New DataView(OleosigDB1.lotesaceituna)
        _vistatickets.RowStateFilter = DataViewRowState.OriginalRows


    End Sub


    Sub act_lot_jar(ByRef path As String)

        Dim archivo As System.IO.StreamReader
        Dim strLine As String
        Dim ticket As oleosigDB.lotesaceitunaRow
        Dim fecha As String

        Dim hora As String
        Dim recoleccion As String
        Dim campos As String()


        Try


            If My.Computer.FileSystem.FileExists(path) Then


                archivo = My.Computer.FileSystem.OpenTextFileReader(path)

                Do

                    ticket = OleosigDB1.lotesaceituna.NewlotesaceitunaRow
                    ticket.Campaña = Almazara.CampañaAct.clave

                    strLine = archivo.ReadLine

                    If Len(strLine) > 0 Then
                        campos = Split(strLine, "#")

                        ticket.Numero = CUShort(campos(0))

                        ticket.Cosechero = CUShort(campos(6))

                        fecha = campos(1) ' Mid(strLine, 8, 10) ' fecha
                        hora = campos(3)


                        ' fechahora = fechauniversal & " " & hora
                        ticket.Fecha = CDate(fecha & " " & hora)

                        If Len(Trim(campos(17))) > 0 Then
                            ticket.Kilos = CUShort(campos(17))
                        Else
                            ticket.Kilos = 0
                        End If

                        ticket.Matricula = Trim(campos(19))
                        recoleccion = Trim(campos(21))

                        Select Case recoleccion
                            Case "ARBOL"
                                ticket.Calidad = 0
                            Case "SUELO"
                                ticket.Calidad = 1
                            Case Else
                                ticket.Calidad = 0
                        End Select

                        ticket.Variedad = 0 'Trim$(Str(CLng(Mid$(strLine, 64, 9))))
                        If Len(Trim(campos(9))) > 0 Then
                            ticket.Termino = CInt(Trim(campos(9)))
                        Else
                            ticket.Termino = 0
                        End If
                        If Len(Trim(campos(5))) > 0 Then
                            ticket.Bascula = CInt(campos(5))
                        Else
                            ticket.Bascula = 0
                        End If

                        If Len(Trim(campos(22))) > 0 Then
                            ticket.Tolva = CUShort(campos(22))
                        Else
                            ticket.Tolva = 0
                        End If

                        If Len(Trim(campos(11))) > 0 Then


                            ticket.Poligono = CInt(campos(11))
                        Else
                            ticket.Poligono = 0
                        End If

                        If Len(Trim(campos(12))) > 0 Then
                            ticket.Parcela = CInt(campos(12))
                        Else
                            ticket.Parcela = 0
                        End If

                        _vistatickets.Sort = "Numero"

                        If _vistatickets.Find(ticket.Numero) = -1 Then
                            OleosigDB1.lotesaceituna.AddlotesaceitunaRow(ticket)
                        End If

                    End If
                Loop Until strLine Is Nothing


                archivo.Close()

            End If


        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Se ha producido un error en la importacion de archivos " & Err.Description)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim path As String
        Dim i As Integer
        Dim ancho As UInteger = 0




        If Dialogo.ShowDialog() = Windows.Forms.DialogResult.OK Then
            path = Dialogo.FileName
            TextBox1.Text = path

            If Len(path) > 0 Then

                Dim importacion As oleosigDB.importaciones_ticketRow = CType(impTicketsBDS.Current, DataRowView).Row


                Select Case importacion.tipo
                    Case 1
                        act_lot_ancho_fijo(path)
                    Case 2

                        act_lot_delimitado(path)
                    Case 3

                        act_lot_delimitado(path)
                    Case 4
                        act_lot_ancho_fijo(path)
                    Case 5
                        act_lot_ancho_fijo(path)
                End Select



                Me.DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)


                Button1.Enabled = True
            End If
        End If
    End Sub

    Private Sub brnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnCancel.Click
        Me.Close()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Button1.Enabled = False
        Me.Button2.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        Me.lblmensaje.Text = "Enviando tickets"

        'For Each ticket As eLotAceituna In Tickets
        '_olotaceituna.Insertar(ticket)
        'Next
        puentedatos.EndEdit()

        '_olotaceituna.guardar()
        _olotaceituna.Update(OleosigDB1.lotesaceituna)
        puentedatos.ResetBindings(False)

        Me.lblmensaje.Text = ""

        Me.Cursor = Cursors.Default

        MsgBox("Los tickets se han importado con exito")

        TextBox1.Clear()
        Me.Close()

    End Sub

    Private Sub frmwizardadticket1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Enabled = False


        recDB = New recoleccionTableAdapter(Almazara.Id)
        recDB.Fill(OleosigDB1.recoleccion)


        If cmbImpTickets.SelectedIndex < 0 Then
            Button2.Enabled = False
        End If

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim vcfgimptickets As frmCfgImportTickets

        vcfgimptickets = New frmCfgImportTickets()


        vcfgimptickets.MdiParent = Me.MdiParent
        vcfgimptickets.Show()


        Me.Close()

    End Sub

    Sub act_lot_delimitado(ByVal path As String)
        Dim archivo As Microsoft.VisualBasic.FileIO.TextFieldParser

        Dim ticket As oleosigDB.lotesaceitunaRow
        Dim fila As String()
        Dim dia As String
        Dim mes As String
        Dim año As String
        Dim hora As String
        Dim minuto As String
        Dim segundo As String

        Try
            If My.Computer.FileSystem.FileExists(path) Then

                Dim filaimportacion As oleosigDB.importaciones_ticketRow = CType(impTicketsBDS.Current, DataRowView).Row

                Dim importacion() As oleosigDB.cfg_imp_ticket_delimitadoRow

                importacion = filaimportacion.Getcfg_imp_ticket_delimitadoRows

                archivo = My.Computer.FileSystem.OpenTextFieldParser(path)
                archivo.TextFieldType = FileIO.FieldType.Delimited
                archivo.SetDelimiters(filaimportacion.delimitador)
                While Not archivo.EndOfData

                    ticket = OleosigDB1.lotesaceituna.NewlotesaceitunaRow

                    fila = archivo.ReadFields
                    ticket.Idalmazara = Almazara.Id
                    ticket.Campaña = Almazara.CampañaAct.clave
                    ticket.Importado = False
                    ticket.Rendimiento = 0

                    If importacion(0).importar Then
                        ticket.Numero = fila(importacion(0).posicion)
                    Else

                    End If
                    If importacion(1).importar Then
                        ticket.Cosechero = fila(importacion(1).posicion)
                    End If

                    If importacion(2).importar Then
                        ticket.Fecha = fila(importacion(2).posicion) & " " & fila(importacion(3).posicion)
                    End If
                    If importacion(4).importar Then
                        ticket.Kilos = fila(importacion(4).posicion)
                    End If
                    If importacion(5).importar Then
                        ticket.Matricula = fila(importacion(5).posicion)
                    End If
                    If importacion(6).importar Then
                        If IsNumeric(fila(importacion(6).posicion)) Then
                            ticket.Calidad = fila(importacion(6).posicion)
                        Else
                            ticket.Calidad = OleosigDB1.recoleccion.AsEnumerable.First(Function(cal As oleosigDB.recoleccionRow) cal.nombre = fila(importacion(6).posicion).ToUpper).codigo
                        End If

                    End If
                    If importacion(7).importar Then
                        If IsNumeric(fila(importacion(7).posicion)) Then
                            ticket.Variedad = fila(importacion(7).posicion)
                        Else
                            ticket.Variedad = OleosigDB1.variedades.AsEnumerable.First(Function(var As oleosigDB.variedadesRow) var.varnombre = fila(importacion(7).posicion).ToUpper).varcodigo
                        End If

                    End If

                    If importacion(8).importar Then
                        ticket.Termino = fila(importacion(8).posicion)
                    End If
                    If importacion(9).importar Then
                        ticket.Bascula = fila(importacion(9).posicion)
                    End If

                    If importacion(10).importar Then
                        ticket.Tolva = fila(importacion(10).posicion)
                    End If
                    If importacion(11).importar Then
                        ticket.Poligono = fila(importacion(11).posicion)
                    End If
                    If importacion(12).importar Then
                        ticket.Parcela = fila(importacion(12).posicion)
                    End If

                    _vistatickets.Sort = "Numero"
                    If _vistatickets.Find(ticket.Numero) = -1 Then
                        OleosigDB1.lotesaceituna.AddlotesaceitunaRow(ticket)
                    End If
                End While

                archivo.Close()
            End If
        Catch ex As Exception

        Finally

        End Try
    End Sub

    Sub act_lot_ancho_fijo(ByVal path As String)
        Dim archivo As System.IO.StreamReader

        Dim ticket As oleosigDB.lotesaceitunaRow
        Dim dia As String
        Dim mes As String
        Dim año As String
        Dim hora As String
        Dim minuto As String
        Dim segundo As String


        Try
            If My.Computer.FileSystem.FileExists(path) Then
                archivo = My.Computer.FileSystem.OpenTextFileReader(path)

                Dim filaImp As oleosigDB.importaciones_ticketRow = CType(impTicketsBDS.Current, DataRowView).Row

                Dim impFijo() As oleosigDB.cfg_imp_ticket_fijoRow = filaImp.Getcfg_imp_ticket_fijoRows()

                While Not archivo.EndOfStream

                    Dim fila As String = archivo.ReadLine()

                    ticket = OleosigDB1.lotesaceituna.NewlotesaceitunaRow

                    ticket.Idalmazara = Almazara.Id
                    ticket.Campaña = Almazara.CampañaAct.clave
                    ticket.Importado = False
                    ticket.Rendimiento = 0

                    If impFijo(0).importar Then

                        ticket.Numero = fila.Substring(impFijo(0).inicio, impFijo(0).longitud)
                    Else
                        ticket.Numero = 0
                    End If

                    If impFijo(1).importar Then
                        ticket.Cosechero = fila.Substring(impFijo(1).inicio, impFijo(1).longitud)
                    Else
                        ticket.Cosechero = 0
                    End If

                    If impFijo(2).importar Then
                        dia = fila.Substring(impFijo(2).inicio, impFijo(2).longitud)
                    End If

                    If impFijo(3).importar Then
                        mes = fila.Substring(impFijo(3).inicio, impFijo(3).longitud)
                    End If
                    If impFijo(4).importar Then
                        año = fila.Substring(impFijo(4).inicio, impFijo(4).longitud)
                    End If

                    If impFijo(5).importar Then
                        hora = fila.Substring(impFijo(5).inicio, impFijo(5).longitud)
                    End If
                    If impFijo(6).importar Then
                        minuto = fila.Substring(impFijo(6).inicio, impFijo(6).longitud)
                    End If
                    If impFijo(7).importar Then
                        segundo = fila.Substring(impFijo(7).inicio, impFijo(7).longitud)
                    End If

                    If impFijo(2).importar And impFijo(3).importar And impFijo(4).importar And impFijo(5).importar And impFijo(6).importar And impFijo(7).importar Then
                        ticket.Fecha = CDate(dia & "/" & mes & "/" & año & " " & hora & ":" & minuto & ":" & segundo)
                    ElseIf impFijo(2).importar And impFijo(3).importar And impFijo(4).importar Then
                        ticket.Fecha = CDate(dia & "/" & mes & "/" & año)
                    End If

                    If impFijo(8).importar Then
                        ticket.Kilos = fila.Substring(impFijo(8).inicio, impFijo(8).longitud)
                    Else
                        ticket.Kilos = 0
                    End If

                    If impFijo(9).importar Then
                        ticket.Matricula = fila.Substring(impFijo(9).inicio, impFijo(9).longitud)
                    Else
                        ticket.Matricula = "."
                    End If

                    If impFijo(10).importar Then
                        ticket.Calidad = fila.Substring(impFijo(10).inicio, impFijo(10).longitud)
                    Else
                        ticket.Calidad = 0
                    End If

                    If impFijo(11).importar Then
                        ticket.Variedad = fila.Substring(impFijo(11).inicio, impFijo(11).longitud)
                    Else
                        ticket.Variedad = 0
                    End If
                    If impFijo(12).importar Then
                        ticket.Termino = CUInt(fila.Substring(impFijo(12).inicio, impFijo(12).longitud))
                    Else
                        ticket.Termino = 0
                    End If
                    If impFijo(13).importar Then
                        ticket.Bascula = CUShort(fila.Substring(impFijo(13).inicio, impFijo(13).longitud))
                    Else
                        ticket.Bascula = 0
                    End If
                    If impFijo(14).importar Then
                        ticket.Tolva = CUShort(fila.Substring(impFijo(14).inicio, impFijo(14).longitud))
                    Else
                        ticket.Tolva = 0
                    End If

                    If impFijo(15).importar Then
                        ticket.Poligono = CUInt(fila.Substring(impFijo(15).inicio, impFijo(15).longitud))
                    Else
                        ticket.Poligono = 0
                    End If
                    If impFijo(16).importar Then
                        ticket.Parcela = CUInt(fila.Substring(impFijo(16).inicio, impFijo(16).longitud))
                    Else
                        ticket.Parcela = 0
                    End If


                    _vistatickets.Sort = "Numero"
                    If _vistatickets.Find(ticket.Numero) = -1 Then

                        OleosigDB1.lotesaceituna.AddlotesaceitunaRow(ticket)

                    End If


                End While


                archivo.Close()
            End If
        Catch ex As Exception
        End Try


    End Sub

   
End Class