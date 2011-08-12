Option Strict Off
Option Explicit On
Friend Class frmAnalisis
    Inherits System.Windows.Forms.Form


    Dim oLotAceite As loteAceiteTableAdapter
    Dim tanquesDB As depositosTableAdapter
    Dim oAnalisis As analisisTableAdapter
    Dim editando As Boolean





    Private Sub frmAnalisis_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        tanquesDB = New depositosTableAdapter(Almazara.Id)
        oLotAceite = New loteAceiteTableAdapter(Almazara.CampañaAct.Clave, Almazara.Id)
        oAnalisis = New analisisTableAdapter(Almazara.CampañaAct.Clave, Almazara.Id)
        editando = False
        oLotAceite.Fill(OleosigDB1.loteaceite)
        tanquesDB.Fill(OleosigDB1.tanques)

        inicia_Componentes()

    End Sub




    Private Sub listaAnalisis_Click(ByVal sender As System.Object, ByVal eventArgs As System.EventArgs) Handles listaAnalisis.Click
        Dim entidad As eAnalisis
        Dim result As Integer
        Dim item As ListViewItem

        item = sender.Focuseditem


        entidad = oAnalisis.getById(item.Text)

        With entidad


            _analtxt_0.Text = .Acidez
            _analtxt_14.Text = .Alcohol_alifatico
            _analtxt_10.Text = .Beta_sitosterol
            _analtxt_7.Text = .Brasicasterol

            _analtxt_8.Text = .Campesterol
            _analtxt_4.Text = .Ceras
            _analtxt_6.Text = .Colesteroles
            _analtxt_11.Text = .D_7_estigmasterol
            _analtxt_12.Text = .Eritrodiol
            _analtxt_5.Text = .Esteroles_tot
            _analtxt_9.Text = .Estigmasterol
            fechaAnaltxt.Text = .Fecha

            _analtxt_3.Text = .K232
            _analtxt_2.Text = .K270



            cmbTanque.SelectedValue = .numTanque



            result = cmbOrgano.FindStringExact(oAnalisis.Organoleptico(.Organoleptico))

            cmbOrgano.SelectedIndex = result

            _analtxt_1.Text = .Peroxidos
            _analtxt_13.Text = .Trilinoleinas

        End With
        'UPGRADE_WARNING: El límite inferior de la colección Toolbar1.Buttons cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
        Toolbar1.Items.Item(2).Enabled = True
    End Sub



    Private Sub Imprimir()
        Dim mivisor As frmvisor
        Dim fileinf As System.IO.StreamWriter
        Dim inforSTR As New System.Text.StringBuilder



        fileinf = My.Computer.FileSystem.OpenTextFileWriter(My.Application.Info.DirectoryPath & "\analisis.html", False)


        inforSTR.Append("<html><head><title></title><link rel=" & Chr(34) & "stylesheet" & Chr(34) & "type=" & Chr(34) & "text/css" & Chr(34) & "href=" & Chr(34) & "estilo.css" & Chr(34) & "/></head><body>")

        inforSTR.Append("<div class=" & Chr(34) & "contenedor" & Chr(34) & ">")

        inforSTR.Append("<div class=" & Chr(34) & "cabecera" & Chr(34) & ">")


        inforSTR.Append("<span class=" & Chr(34) & "titulo" & Chr(34) & ">Informe de An&aacute;lisis</span><br><br>")

        inforSTR.Append("<span class=" & Chr(34) & "lblnmcliente" & Chr(34) & ">" & Almazara.Nombre & "</span><br>")

        inforSTR.Append("<span class=" & Chr(34) & "lbldircliente" & Chr(34) & ">" & Almazara.Direccion & "</span><br>")


        inforSTR.Append("<span id=" & Chr(34) & "label1" & Chr(34) & ">Lote :</span><span id=" & Chr(34) & "" & Chr(34) & ">" & lblLote.Text & "</span><br/>")

        inforSTR.Append("<span id=" & Chr(34) & "label2" & Chr(34) & ">Tanque :</span><span id=" & Chr(34) & "" & Chr(34) & ">" & cmbTanque.Text & "</span><br/>")

        inforSTR.Append("<span id=" & Chr(34) & "label3" & Chr(34) & ">Fecha An&aacute;lisis :</span><span id=" & Chr(34) & "" & Chr(34) & ">" & fechaAnaltxt.Text & "</span><br/>")


        inforSTR.Append("</div>")


        inforSTR.Append("<div class=" & Chr(34) & "cmpgral" & Chr(34) & ">")

        inforSTR.Append("<table class=" & Chr(34) & "tablanalisis" & Chr(34) & ">")

        inforSTR.Append("<tbody>")


        inforSTR.Append("<tr><td class=" & Chr(34) & "nmcampo" & Chr(34) & ">" & _Label1_0.Text & "</td><td>" & _analtxt_0.Text & "</td></tr>")

        inforSTR.Append("<tr><td class=" & Chr(34) & "nmcampo" & Chr(34) & ">" & _Label1_1.Text & "</td><td>" & _analtxt_1.Text & "</td></tr>")

        inforSTR.Append("<tr><td class=" & Chr(34) & "nmcampo" & Chr(34) & ">" & _Label1_2.Text & "</td><td>" & _analtxt_2.Text & "</td></tr>")

        inforSTR.Append("<tr><td class=" & Chr(34) & "nmcampo" & Chr(34) & ">" & _Label1_3.Text & "</td><td>" & _analtxt_3.Text & "</td></tr>")

        inforSTR.Append("<tr><td class=" & Chr(34) & "nmcampo" & Chr(34) & ">" & _Label1_4.Text & "</td><td>" & _analtxt_4.Text & "</td></tr>")

        inforSTR.Append("<tr><td class=" & Chr(34) & "nmcampo" & Chr(34) & ">" & _Label1_5.Text & "</td><td>" & _analtxt_5.Text & "</td></tr>")

        inforSTR.Append("<tr><td class=" & Chr(34) & "nmcampo" & Chr(34) & ">" & _Label1_6.Text & "</td><td>" & _analtxt_6.Text & "</td></tr>")

        inforSTR.Append("<tr><td class=" & Chr(34) & "nmcampo" & Chr(34) & ">" & _Label1_7.Text & "</td><td>" & _analtxt_7.Text & "</td></tr>")

        inforSTR.Append("<tr><td class=" & Chr(34) & "nmcampo" & Chr(34) & ">" & _Label1_8.Text & "</td><td>" & _analtxt_8.Text & "</td></tr>")

        inforSTR.Append("<tr><td class=" & Chr(34) & "nmcampo" & Chr(34) & ">" & _Label1_9.Text & "</td><td>" & _analtxt_9.Text & "</td></tr>")

        inforSTR.Append("<tr><td class=" & Chr(34) & "nmcampo" & Chr(34) & ">" & _Label1_10.Text & "</td><td>" & _analtxt_10.Text & "</td></tr>")

        inforSTR.Append("<tr><td class=" & Chr(34) & "nmcampo" & Chr(34) & ">" & _Label1_11.Text & "</td><td>" & _analtxt_11.Text & "</td></tr>")

        inforSTR.Append("<tr><td class=" & Chr(34) & "nmcampo" & Chr(34) & ">" & _Label1_12.Text & "</td><td>" & _analtxt_12.Text & "</td></tr>")

        inforSTR.Append("<tr><td class=" & Chr(34) & "nmcampo" & Chr(34) & ">" & _Label1_13.Text & "</td><td>" & _analtxt_13.Text & "</td></tr>")

        inforSTR.Append("<tr><td class=" & Chr(34) & "nmcampo" & Chr(34) & ">" & _Label1_14.Text & "</td><td>" & _analtxt_14.Text & "</td></tr>")

        inforSTR.Append("<tr><td class=" & Chr(34) & "nmcampo" & Chr(34) & ">" & _Label1_15.Text & "</td><td>" & cmbOrgano.Text & "</td></tr>")


        inforSTR.Append("</tbody>")

        inforSTR.Append("</table>")

        inforSTR.Append("</div></div>")

        inforSTR.Append("</body></html>")

        fileinf.Write(inforSTR.ToString())

        fileinf.Close()

        mivisor = New frmvisor
        mivisor.MdiParent = Me.MdiParent

        mivisor.visor.Navigate(New System.URI(My.Application.Info.DirectoryPath & "\analisis.html"))
        mivisor.Show()
    End Sub

    Private Sub editar()
        editando = True
        Call activa_Componentes()

        Toolbar1.Items.Item(7).Enabled = True

        Toolbar1.Items.Item(0).Enabled = False
    End Sub
    Private Sub guardar()
        Dim oeAnalisis As eAnalisis
        Dim result As MsgBoxResult

        oeAnalisis = New eAnalisis

        With oeAnalisis

            .Acidez = _analtxt_0.Text
            .Alcohol_alifatico = _analtxt_14.Text
            .Beta_sitosterol = _analtxt_10.Text
            .Brasicasterol = _analtxt_7.Text
            .Campesterol = _analtxt_8.Text
            .Ceras = _analtxt_4.Text
            .Colesteroles = _analtxt_6.Text
            .D_7_estigmasterol = _analtxt_11.Text
            .Eritrodiol = _analtxt_12.Text
            .Esteroles_tot = _analtxt_5.Text
            .Estigmasterol = _analtxt_9.Text
            .fecha = fechaAnaltxt.Text
            .K232 = _analtxt_3.Text
            .K270 = _analtxt_2.Text

            If Len(lblLote.Text) > 0 Then

                .Lote = OleosigDB1.loteaceite.First(Function(lt As oleosigDB.loteaceiteRow) lt.Id = lblLote.Text).Id

            End If

            If cmbTanque.SelectedIndex > -1 Then

                .numTanque = cmbTanque.SelectedValue

            End If

            If cmbOrgano.SelectedIndex > -1 Then
                .Organoleptico = CStr(cmbOrgano.SelectedIndex)
            End If

            .Peroxidos = _analtxt_1.Text
            .Trilinoleinas = _analtxt_13.Text
            .campaña = Almazara.CampañaAct.clave.ToString

            If editando = False Then

                oAnalisis.Insertar(oeAnalisis)

            Else


                result = MsgBox("¿ Desea guardar los cambios ?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation)
                If result = MsgBoxResult.Yes Then
                    oAnalisis.editar(oeAnalisis)
                Else
                    Exit Sub
                End If
            End If

            inicia_Componentes()

        End With

    End Sub
    Private Sub nuevo()
        limpia_Componentes()
        activa_Componentes()
        fechaAnaltxt.Focus()


        Toolbar1.Items.Item(0).Enabled = True

        Toolbar1.Items.Item(1).Enabled = False
        listaAnalisis.Enabled = False

    End Sub
    Private Sub ponCabecera_Analisis()
        listaAnalisis.Columns.Clear()
        listaAnalisis.Columns.Add("Id")


        listaAnalisis.Columns.Add("Lote")


        listaAnalisis.Columns.Add("Tanque")


        listaAnalisis.Columns.Add("Fecha")
        listaAnalisis.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

    End Sub
    Private Sub rellena_tablaAnalisis()
        Dim miLista As System.Windows.Forms.ListViewItem
        Dim misAnalisis As CeAnalisis
        Dim miAnalisis As eAnalisis
        Dim oeLote As oleosigDB.loteaceiteDataTable

        listaAnalisis.Items.Clear()
        misAnalisis = oAnalisis.getAll()

        For Each miAnalisis In misAnalisis
            oeLote = oLotAceite.GetDataById((miAnalisis.Lote))
            Dim lote As oleosigDB.loteaceiteRow

            lote = oeLote.Rows(0)


            miLista = listaAnalisis.Items.Add(miAnalisis.Id)
            miLista.SubItems.Add(lote.Nombre)
            'miLista.SubItems.Add(Almazara.Tanques.AsEnumerable.First(Function(dep As DataRow) dep("numero") = lote.Tanque)("nombre"))
            miLista.SubItems.Add(miAnalisis.Fecha)

        Next miAnalisis

    End Sub
    Private Sub inicia_Componentes()
        Dim i As Short


        editando = False

        Toolbar1.Items.Item(0).Enabled = True

        Toolbar1.Items.Item(1).Enabled = False

        Toolbar1.Items.Item(3).Enabled = True

        Toolbar1.Items.Item(5).Enabled = False

        Toolbar1.Items.Item(7).Enabled = False
        listaAnalisis.Enabled = True


        cmbOrgano.Items.Clear()


        For Each valor As DictionaryEntry In oAnalisis.Organoleptico

            cmbOrgano.Items.Add(valor.Value)

        Next
        cmbOrgano.Text = "Organoléptico"
        limpia_Componentes()
        desactiva_Componentes()

        ponCabecera_Analisis()

        rellena_tablaAnalisis()

    End Sub
	
	Private Sub activa_Componentes()


        _analtxt_0.Enabled = True
        _analtxt_1.Enabled = True
        _analtxt_2.Enabled = True
        _analtxt_3.Enabled = True
        _analtxt_4.Enabled = True
        _analtxt_5.Enabled = True
        _analtxt_6.Enabled = True
        _analtxt_7.Enabled = True
        _analtxt_8.Enabled = True
        _analtxt_9.Enabled = True
        _analtxt_10.Enabled = True
        _analtxt_11.Enabled = True
        _analtxt_12.Enabled = True
        _analtxt_13.Enabled = True
        _analtxt_14.Enabled = True

        cmbTanque.Enabled = True
        cmbOrgano.Enabled = True
		
	End Sub
	Private Sub desactiva_Componentes()


        _analtxt_0.Enabled = False
        _analtxt_1.Enabled = False
        _analtxt_2.Enabled = False
        _analtxt_3.Enabled = False
        _analtxt_4.Enabled = False
        _analtxt_5.Enabled = False
        _analtxt_6.Enabled = False
        _analtxt_7.Enabled = False
        _analtxt_8.Enabled = False
        _analtxt_9.Enabled = False
        _analtxt_10.Enabled = False
        _analtxt_11.Enabled = False
        _analtxt_12.Enabled = False
        _analtxt_13.Enabled = False
        _analtxt_14.Enabled = False

        cmbTanque.Enabled = False
        cmbOrgano.Enabled = False
	End Sub
	Private Sub limpia_Componentes()


		cmbOrgano.SelectedIndex = -1
		cmbOrgano.Text = "Organoléptico"

        fechaAnaltxt.Clear()
		
		Me.lblLote.Text = ""


        _analtxt_0.Text = ""
        _analtxt_1.Text = ""
        _analtxt_2.Text = ""
        _analtxt_3.Text = ""
        _analtxt_4.Text = ""
        _analtxt_5.Text = ""
        _analtxt_6.Text = ""
        _analtxt_7.Text = ""
        _analtxt_8.Text = ""
        _analtxt_9.Text = ""
        _analtxt_10.Text = ""
        _analtxt_11.Text = ""
        _analtxt_12.Text = ""
        _analtxt_13.Text = ""
        _analtxt_14.Text = ""

		
	End Sub

    Private Sub listaLotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim result As Integer
        Dim item As ListViewItem

        item = sender.FocusedItem

        lblLote.Text = item.Text

        result = cmbTanque.FindStringExact(item.SubItems(1).Text)

        cmbTanque.SelectedIndex = result
    End Sub

    Private Sub _Toolbar1_Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button10.Click
        Me.Close()
    End Sub
End Class