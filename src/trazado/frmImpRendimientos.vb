Public Class frmImpRendimientos
    Private _rendimientos As New CeRendTicket
    Dim strseparacion As New System.Text.StringBuilder

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim path As String
        Dim i As Integer
        Dim ancho As UInteger = 0
        Dim lector As Microsoft.VisualBasic.FileIO.TextFieldParser

        Dim fila As String()
        Dim rendimientos As New ArrayList

        dialogArchivo.Filter = "todo los tipos (*.*)|*.*"
       

        If dialogArchivo.ShowDialog() = Windows.Forms.DialogResult.OK Then

            If My.Computer.FileSystem.FileExists(dialogArchivo.FileName) Then
                tablaRendimientos.DataSource = Nothing
                tablaRendimientos.Columns.Clear()

                path = dialogArchivo.FileName
                TextBox1.Text = path

                lector = My.Computer.FileSystem.OpenTextFieldParser(dialogArchivo.FileName)
                If rbAnchofijo.Checked Then
                    lector.TextFieldType = FileIO.FieldType.FixedWidth

                Else
                    lector.TextFieldType = FileIO.FieldType.Delimited

                    If strseparacion.ToString.Length = 0 Then Exit Sub

                    lector.SetDelimiters(strseparacion.ToString)

                End If
                While Not lector.EndOfData
                    Try

                        fila = lector.ReadFields()
                        If tablaRendimientos.ColumnCount = 0 Then

                            For i = 0 To fila.Length - 1
                                tablaRendimientos.Columns.Add("c" & i.ToString, i.ToString)
                                tablaRendimientos.Columns(i).SortMode = DataGridViewColumnSortMode.Programmatic
                            Next i
                        End If

                        tablaRendimientos.Rows.Add(fila)


                    Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException

                    End Try
                End While
                tablaRendimientos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
                lector.Close()

                Button2.Enabled = True
                Button4.Enabled = False

                'Me.puentedatos.DataSource = rendimientos

                'Me.tablaRendimientos.DataSource = Me.puentedatos


            End If

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim tickets As New LoteAceitunaTableAdapter(Almazara.CampañaAct.Clave, Almazara.Id)
        Dim ren As eRendTicket

        Me._rendimientos = New CeRendTicket

        If TicketNumUpDown.Value = RendNumUpDown.Value Then
            MsgBox("Revise los valores de selección de columna", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        For Each fila As DataGridViewRow In tablaRendimientos.Rows
            ren = New eRendTicket

            ren.NumTicket = fila.Cells(CInt(TicketNumUpDown.Value)).Value
            ren.Rendimiento = fila.Cells(CInt(RendNumUpDown.Value)).Value
            Me._rendimientos.Add(ren)

        Next

        tablaRendimientos.Columns.Clear()
        puentedatos.DataSource = Me._rendimientos
        tablaRendimientos.DataSource = puentedatos
        Button2.Enabled = False
        Button4.Enabled = True

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub frmImpRendimientos_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        My.Settings.colImpRendRend = CInt(RendNumUpDown.Value)
        My.Settings.colImpRendTicket = CInt(TicketNumUpDown.Value)

        If rbAnchofijo.Checked Then
            My.Settings.tipoImpRend = 0

        Else
            My.Settings.tipoImpRend = 1
            If Not chkEspacio.Checked And Not chkComa.Checked And Not chkOtros.Checked And Not chkpuntocoma.Checked And Not chkTab.Checked Then


                strseparacion.Length = 0

                Almazara.DelimitadorRend = vbNullString
            Else
                Almazara.DelimitadorRend = strseparacion.ToString
            End If

        End If
        My.Settings.Save()
        Almazara.Guardar_almazara()

    End Sub

    Private Sub frmImpRendimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        Button2.Enabled = False
        Button4.Enabled = False

        RendNumUpDown.Value = CDec(My.Settings.colImpRendRend)
        TicketNumUpDown.Value = CDec(My.Settings.colImpRendTicket)


        Select Case My.Settings.tipoImpRend
            Case 0
                rbAnchofijo.Checked = True
            Case 1
                rbseparadopor.Checked = True

                strseparacion.Append(Almazara.DelimitadorRend)

                If InStr(strseparacion.ToString, vbTab, CompareMethod.Text) > 0 Then
                    chkTab.Checked = True
                End If
                If InStr(strseparacion.ToString, " ", CompareMethod.Text) > 0 Then
                    chkEspacio.Checked = True
                End If
                If InStr(strseparacion.ToString, ";", CompareMethod.Text) > 0 Then
                    chkpuntocoma.Checked = True
                End If
                If InStr(strseparacion.ToString, ",", CompareMethod.Text) > 0 Then
                    chkComa.Checked = True
                End If
                If InStr(strseparacion.ToString, "#", CompareMethod.Text) > 0 Then
                    chkcuadradilla.Checked = True
                End If
        End Select
    End Sub

    Private Sub rbAnchofijo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAnchofijo.CheckedChanged
        If rbAnchofijo.Checked Then
            chkComa.Enabled = False
            chkEspacio.Enabled = False
            chkpuntocoma.Enabled = False
            chkTab.Enabled = False
            chkOtros.Enabled = False
        End If

    End Sub

    Private Sub rbseparadopor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbseparadopor.CheckedChanged
        If rbseparadopor.Checked Then
            chkComa.Enabled = True
            chkEspacio.Enabled = True
            chkpuntocoma.Enabled = True
            chkTab.Enabled = True
            chkOtros.Enabled = True
        End If
    End Sub

    Private Sub chkOtros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOtros.CheckedChanged
        If chkOtros.Checked Then
            charseptxt.Enabled = True
            If charseptxt.Text.Length > 0 Then
                Button1.Enabled = True
            End If

        Else
            charseptxt.Enabled = False
            If chkOtros.Checked = False And chkComa.Checked = False And chkcuadradilla.Checked = False And chkEspacio.Checked = False And chkpuntocoma.Checked = False And chkTab.Checked = False Then
                Button1.Enabled = False
            End If
        End If
    End Sub

    Private Sub chkTab_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTab.CheckedChanged
        If chkTab.Checked Then

            If InStr(strseparacion.ToString, vbTab, CompareMethod.Text) = 0 Then
                strseparacion.Append(vbTab)
            End If
            Button1.Enabled = True
        Else
            Dim rst = InStr(strseparacion.ToString, vbTab, CompareMethod.Text)
            If rst > 0 Then
                strseparacion.Remove(rst - 1, 1)
            End If
            If chkOtros.Checked = False And chkComa.Checked = False And chkcuadradilla.Checked = False And chkEspacio.Checked = False And chkpuntocoma.Checked = False And chkTab.Checked = False Then
                Button1.Enabled = False
            End If
        End If
    End Sub

    Private Sub chkEspacio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEspacio.CheckedChanged

        If chkEspacio.Checked Then
            If InStr(strseparacion.ToString, " ", CompareMethod.Text) = 0 Then

                strseparacion.Append(" ")
            End If
            Button1.Enabled = True

        Else

            Dim rst = InStr(strseparacion.ToString, " ", CompareMethod.Text)
            If rst > 0 Then
                strseparacion.Remove(rst - 1, 1)
            End If
            If chkOtros.Checked = False And chkComa.Checked = False And chkcuadradilla.Checked = False And chkEspacio.Checked = False And chkpuntocoma.Checked = False And chkTab.Checked = False Then
                Button1.Enabled = False
            End If
        End If
    End Sub

    Private Sub chkpuntocoma_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkpuntocoma.CheckedChanged
        If chkpuntocoma.Checked Then
            If InStr(strseparacion.ToString, ";", CompareMethod.Text) = 0 Then
                strseparacion.Append(";")
            End If
            Button1.Enabled = True
        Else
            Dim rst = InStr(strseparacion.ToString, ";", CompareMethod.Text)
            If rst > 0 Then
                strseparacion.Remove(rst - 1, 1)
            End If
            If chkOtros.Checked = False And chkComa.Checked = False And chkcuadradilla.Checked = False And chkEspacio.Checked = False And chkpuntocoma.Checked = False And chkTab.Checked = False Then
                Button1.Enabled = False
            End If
        End If
    End Sub

    Private Sub chkComa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkComa.CheckedChanged
        If chkComa.Checked Then
            If InStr(strseparacion.ToString, ",", CompareMethod.Text) = 0 Then
                strseparacion.Append(",")
            End If
            Button1.Enabled = True
        Else
            Dim rst = InStr(strseparacion.ToString, ",", CompareMethod.Text)
            If rst > 0 Then
                strseparacion.Remove(rst - 1, 1)
            End If
            If chkOtros.Checked = False And chkComa.Checked = False And chkcuadradilla.Checked = False And chkEspacio.Checked = False And chkpuntocoma.Checked = False And chkTab.Checked = False Then
                Button1.Enabled = False
            End If
        End If
    End Sub

    Private Sub chkcuadradilla_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcuadradilla.CheckedChanged
        If chkcuadradilla.Checked Then
            If InStr(strseparacion.ToString, "#", CompareMethod.Text) = 0 Then
                strseparacion.Append("#")
            End If
            Button1.Enabled = True
        Else
            Dim rst = InStr(strseparacion.ToString, "#", CompareMethod.Text)
            If rst > 0 Then
                strseparacion.Remove(rst - 1, 1)
            End If
            If chkOtros.Checked = False And chkComa.Checked = False And chkcuadradilla.Checked = False And chkEspacio.Checked = False And chkpuntocoma.Checked = False And chkTab.Checked = False Then
                Button1.Enabled = False
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim tickets As New LoteAceitunaTableAdapter(Almazara.CampañaAct.Clave, Almazara.Id)
        If MsgBox("¿ Desea actualizar los rendimientos de los tickets ? ", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            For Each ren As eRendTicket In Me._rendimientos
                tickets.actulizaRendimientos(ren.NumTicket, ren.Rendimiento)
            Next
            Button2.Enabled = False
            Button4.Enabled = False
            MsgBox("Se ha finalizado la importación de rendimientos")

        End If

    End Sub
End Class