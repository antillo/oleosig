Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic

Friend Class frmWizardMoltur2
    Inherits System.Windows.Forms.Form


    Private datatablemoltur As oleosigDB.opfabricaDataTable

    Private oPartidas As parAceitunaTableAdapter
    Private oMoltur As opfabricaTableAdapter
    Private oDetalles As detallesOpFabricaTableAdapter
    Private vslider As frmslider
    Private vconfig As frmWizardMoltur1


    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        Dim result As MsgBoxResult


        result = MsgBox("Se van a guardar definitivamente las molturaciones." & vbCrLf & " ¿Desea continuar?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation)
        If result = MsgBoxResult.Yes Then


            oMoltur.borrarTodas()


            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            For Each fila As oleosigDB.opfabricaRow In datatablemoltur
                Dim idfabrica As Integer = fila.id
                Dim newid As Integer = oMoltur.Insert(fila.fechaini, fila.fechafin, fila.lineafabrica, fila.operacion, fila.abierta, fila.importada)
                Dim filadetalle As Integer = detallesBDS.Find("opfabrica", idfabrica)
                ' If filadetalle > -1 Then
                Dim detalle As oleosigDB.detalles_opfabricaRow = CType(detallesBDS.List(filadetalle), DataRowView).Row
                detalle.opfabrica = newid
                'End If
            Next
            detallesBDS.EndEdit()
            oDetalles.Update(OleosigDB1.detalles_opfabrica)
            detallesBDS.ResetBindings(False)

            oMoltur.Fill(datatablemoltur)

            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.vconfig.Close()
            Me.Close()

        Else
            Exit Sub
        End If
    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click

        Me.Close()
    End Sub

    Private Sub frmWizardMoltur2_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        bkworker.RunWorkerAsync()
        Me.vconfig.Hide()

        oPartidas = New parAceitunaTableAdapter(Almazara.CampañaAct.Clave, Almazara.Id)
        oMoltur = New opfabricaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        oDetalles = New detallesOpFabricaTableAdapter(Almazara.Id, Almazara.CampañaAct.clave)

        oMoltur.Fill(OleosigDB1.opfabrica)
        oDetalles.Fill(OleosigDB1.detalles_opfabrica)

        OleosigDB1.opfabrica.Clear()
        OleosigDB1.detalles_opfabrica.Clear()

        datatablemoltur = OleosigDB1.opfabrica.Clone()

        Me.Text = "Molturaciones Automáticas"
        Me.Command1.Enabled = False


        inicia_Componentes()

    End Sub
    Private Sub inicia_Componentes()

        ponCabecera_partidas()


        rellena_partidas()
        Rellena_moltur()

    End Sub
    Private Sub ponCabecera_partidas()
        Dim i As Short
        Dim ancho As Short

        With listaPartidas.Columns

            .Clear()

            .Add("Partida")

            .Add("Fecha Ini. Llen.")

            .Add("Fecha Fin Llen.")

            .Add("Fecha Ini. Vac.")

            .Add("Fecha Fin Vac.")

            .Add("Kilos")

            .Add("Tolva")
            .Add("Calidad")

            listaPartidas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

            ancho = 0
            For i = 0 To .Count - 1

                ancho = ancho + .Item(i).Width
            Next i
        End With
        listaPartidas.Width = ancho + SystemInformation.VerticalScrollBarWidth + SystemInformation.Border3DSize.Width * 4
    End Sub

    

    Private Sub Rellena_moltur()
        Dim numlinea As UShort
        Dim entidad As oleosigDB.opfabricaRow
        Dim detalle As oleosigDB.detalles_opfabricaRow
        Dim contador As Short
        Dim i As Short
        Dim j As Short
        Dim ancho As Short
        Dim numop As UShort
        Dim tvLn As New System.Collections.Generic.Dictionary(Of Integer, Integer)



        numop = 1

        For Each fila As DataGridViewRow In vconfig.tablaDatos.Rows
            If fila.Cells(1).Value Then
                tvLn.Add(fila.Cells(0).Value, fila.Cells(2).Value)
            End If
        Next



        For i = 0 To listaPartidas.Items.Count - 1 'para todas las partidas


            numlinea = tvLn.Item(CInt(listaPartidas.Items(i).SubItems(6).Text))
            '  entidad = CType(opfabricaBDS.AddNew, DataRowView).Row
            entidad = datatablemoltur.NewopfabricaRow
            entidad.lineafabrica = numlinea
            entidad.idalmazara = Almazara.Id
            entidad.fechaini = CDate(listaPartidas.Items.Item(i).SubItems.Item(3).Text)
            entidad.operacion = listaPartidas.Items.Item(i).SubItems.Item(0).Text
            entidad.campagna = Almazara.CampañaAct.clave.ToString
            entidad.fechafin = CDate(listaPartidas.Items.Item(i).SubItems.Item(4).Text)
            entidad.abierta = False
            entidad.importada = False

            datatablemoltur.Rows.Add(entidad)

            detalle = CType(detallesBDS.AddNew, DataRowView).Row

            detalle.idalmazara = Almazara.Id
            detalle.opfabrica = entidad.id
            detalle.partida = CInt(listaPartidas.Items.Item(i).Text)
            detalle.kilos = CInt(listaPartidas.Items.Item(i).SubItems.Item(5).Text)
            detalle.campagna = CShort(entidad.campagna)






            contador = 0
            ancho = 0
            For j = 0 To tablamoltur.ColumnCount - 1
                ancho = ancho + tablamoltur.Columns(j).Width
            Next j
            tablamoltur.Width = ancho + SystemInformation.VerticalScrollBarWidth + SystemInformation.Border3DSize.Width * 4
            numop += 1

        Next
        tablamoltur.DataSource = datatablemoltur
        detallesBDS.MoveFirst()
    End Sub

    Private Sub rellena_partidas()

        Dim tolvas As ArrayList
        Dim i As Short = 0



        tolvas = New ArrayList

        For Each fila As DataGridViewRow In vconfig.tablaDatos.Rows
            If fila.Cells(1).Value = True Then
                Dim numtolva As Integer = fila.Cells(0).Value
                tolvas.Add(OleosigDB1.tolvas.First(Function(tol As oleosigDB.tolvasRow) tol.Nombre = numtolva).Numero)
            End If
            i += 1
        Next

        listaPartidas.Items.Clear()


        AñadePartidas(oPartidas.GetDataByTolvas(tolvas))


    End Sub

    Private Sub AñadePartidas(ByRef Partidas As oleosigDB.partidasaceitunaDataTable)
        Dim i, ancho As Integer
        Dim partida As oleosigDB.partidasaceitunaRow
        Dim myitem As System.Windows.Forms.ListViewItem
        Dim tamaño As SizeF
        Dim grafic As Graphics = Me.CreateGraphics()


        For Each partida In Partidas.Rows
            myitem = listaPartidas.Items.Add(partida.Numero)
            myitem.SubItems.Add(partida.FechaIniLlenado)
            myitem.SubItems.Add(partida.FechaFinLlenado)
            myitem.SubItems.Add(partida.FechaIniVaciado)
            myitem.SubItems.Add(partida.FechaFinVaciado)
            myitem.SubItems.Add(partida.Kilos)
            myitem.SubItems.Add(partida.Tolva)
            myitem.SubItems.Add(partida.Calidad)


            listaPartidas.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent)
            listaPartidas.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent)
            listaPartidas.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent)
            listaPartidas.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent)

            tamaño = grafic.MeasureString(partida.Kilos, listaPartidas.Font)

            If tamaño.Width >= listaPartidas.Columns(5).Width Then
                listaPartidas.AutoResizeColumn(5, ColumnHeaderAutoResizeStyle.ColumnContent)
            End If

        Next partida
        If Partidas.Count > 0 Then
            ancho = 0
            For i = 0 To listaPartidas.Columns.Count - 1
                ancho += listaPartidas.Columns(i).Width
            Next
            listaPartidas.Width = ancho + SystemInformation.VerticalScrollBarWidth + SystemInformation.Border3DSize.Width * 4
            Me.Command1.Enabled = True
        End If
    End Sub
	
	
    Private Sub tablaMoltur_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tablamoltur.DoubleClick
        Dim r As Short

        r = tablamoltur.CurrentRow.Index
        If r < 0 Then Exit Sub

    End Sub

    Private Sub bkworker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bkworker.DoWork

        

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tablaDetalles.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)


    End Sub
End Class