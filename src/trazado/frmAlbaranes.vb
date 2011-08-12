Option Strict Off
Option Explicit On
Imports iTextSharp.text

Friend Class frmalbaranes
    Inherits System.Windows.Forms.Form


	Const MARGENSUP As Double = 0.3
	Const MARGENIZQ As Double = 1.6
	
	
    Dim oPartidas As partAceiteTableAdapter
    Dim oClientes As clientesTableAdapter
    Dim oVehiculos As vehiculosTableAdapter
    Dim oConductor As conductorTableAdapter
    Dim oAlbaranes As albaranTableAdapter
    Dim oAnalisis As analisisTableAdapter
    Dim oLotAceite As loteAceiteTableAdapter

    Dim editando As Boolean

    Dim iniciando As Boolean



    Private Sub habiliTa_controles()
        fechaAlbaran.Enabled = True
        nmclientetxt.Enabled = True
        dirclientetxt.Enabled = True
        cpclientetxt.Enabled = True
        pobclientetxt.Enabled = True
        provclientetxt.Enabled = True
        cifclientetxt.Enabled = True

        nmConductortxt.Enabled = True
        dniconductortxt.Enabled = True
        matriculatxt.Enabled = True
        taraTxt.Enabled = True
        brutoTxt.Enabled = True
        netoTxt.Enabled = True
        tablaPartidas.Enabled = True
        tablaClientes.Enabled = True
        tablaVehiculos.Enabled = True
        tablaconductores.Enabled = True
        listaParAlbaran.Enabled = True

        horaAlbaran.Enabled = True
    End Sub
    Private Sub deshabilita_controles()
        fechaAlbaran.Enabled = False
        nmclientetxt.Enabled = False
        dirclientetxt.Enabled = False
        cpclientetxt.Enabled = False
        pobclientetxt.Enabled = False
        provclientetxt.Enabled = False
        cifclientetxt.Enabled = False

        nmConductortxt.Enabled = False
        dniconductortxt.Enabled = False
        matriculatxt.Enabled = False
        taraTxt.Enabled = False
        brutoTxt.Enabled = False
        netoTxt.Enabled = False
        tablaPartidas.Enabled = False
        tablaClientes.Enabled = False
        tablaVehiculos.Enabled = False
        tablaconductores.Enabled = False
        listaParAlbaran.Enabled = False

        horaAlbaran.Enabled = False
    End Sub
    Private Sub limpia_entradas()

        nmclientetxt.Clear()
        dirclientetxt.Clear()
        cpclientetxt.Clear()
        pobclientetxt.Clear()
        provclientetxt.Clear()
        cifclientetxt.Clear()

        nmconductortxt.Clear()
        dniconductortxt.Clear()
        matriculatxt.Clear()
        taratxt.Clear()
        brutotxt.Clear()
        netotxt.Clear()
        lblIdcliente.Text = ""


        horaAlbaran.Text = Now
        listaParAlbaran.Items.Clear()
        lblIdconductor.Text = ""
        lblIdVehiculo.Text = ""
    End Sub
   

    Private Sub rellena_conductores()


        With tablaconductores

            .AutoGenerateColumns = False




            .Columns.Add("0", "Nombre")
            .Columns.Add("1", "Apellido 1")
            .Columns.Add("2", "Apellido 2")
            .Columns.Add("3", "NIF")

            .Columns(0).DataPropertyName = "nombre"
            .Columns(1).DataPropertyName = "apellido1"
            .Columns(2).DataPropertyName = "apellido2"
            .Columns(3).DataPropertyName = "dni"

            .AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

        End With



    End Sub

    

    Private Sub brutoTxt_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles brutotxt.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii < 48 Or KeyAscii > 57 Then
            If KeyAscii <> 8 Then
                KeyAscii = 0
            End If
        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub


    Private Sub cmbTanques_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbTanques.SelectedIndexChanged

        If iniciando = False Then

            partidasBDS.Filter = "deposito='" & cmbTanques.SelectedValue.ToString & "'"


        End If

    End Sub

    Private Sub frmalbaranes_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load


        fechaAlbaran.Value = Now
        horaAlbaran.Text = Now
        oPartidas = New partAceiteTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        oClientes = New clientesTableAdapter(Almazara.Id)
        oVehiculos = New vehiculosTableAdapter(Almazara.Id)
        oConductor = New conductorTableAdapter(Almazara.Id)
        oAlbaranes = New albaranTableAdapter(Almazara.CampañaAct.Clave, Almazara.Id)
        oAnalisis = New analisisTableAdapter(Almazara.CampañaAct.Clave, Almazara.Id)
        oLotAceite = New loteAceiteTableAdapter(Almazara.CampañaAct.Clave, Almazara.Id)

        oAlbaranes.Fill(OleosigDB1.albaranes)
        oPartidas.Fill(OleosigDB1.partidasaceite)
        oClientes.Fill(OleosigDB1.clientes)

        vehiculosBDS.DataSource = oVehiculos.Vehiculos

        inicia_Componentes()
        iniciando = False
    End Sub


    Private Sub inicia_Componentes()
        Dim i As Short

        editando = False

        lblnumalbaran.Text = ""

        Toolbar1.Items.Item(1).Enabled = False

        Toolbar1.Items.Item(6).Enabled = False

        Toolbar1.Items.Item(8).Enabled = False


        Call rellena_conductores()


        listaParAlbaran.Items.Clear()

        SSTab1.SelectedIndex = 0
        deshabilita_controles()
        limpia_entradas()
    End Sub




    Private Sub netoTxt_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles netotxt.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii < 48 Or KeyAscii > 57 Then
            If KeyAscii <> 8 Then
                KeyAscii = 0
            End If
        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub taraTxt_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles taratxt.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii < 48 Or KeyAscii > 57 Then
            If KeyAscii <> 8 Then
                KeyAscii = 0
            End If
        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub


    Private Sub borra_albaran()

        Dim result As MsgBoxResult
        result = MsgBox("Está a punto de borrar de forma definitiva un Albaran" & Chr(13) & "¿ Desea Hacerlo ?", MsgBoxStyle.YesNo Or MsgBoxStyle.Critical)

        If result = MsgBoxResult.Yes Then
            albaranesBDS.RemoveCurrent()
            albaranesBDS.EndEdit()
            oAlbaranes.Update(OleosigDB1.albaranes)

            inicia_Componentes()
        End If
    End Sub
    Private Sub editar()
        editando = True
        habiliTa_controles()

        'UPGRADE_WARNING: El límite inferior de la colección Toolbar1.Buttons cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
        Toolbar1.Items.Item(7).Enabled = True
        'UPGRADE_WARNING: El límite inferior de la colección Toolbar1.Buttons cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
        Toolbar1.Items.Item(9).Enabled = True

    End Sub
    Private Sub Nuevo_Albaran()
        lblnumalbaran.Text = CStr(CDbl(oAlbaranes.ultimo) + 1)
        habiliTa_controles()
        'UPGRADE_WARNING: El límite inferior de la colección Toolbar1.Buttons cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
        Toolbar1.Items.Item(9).Enabled = True

        fechaAlbaran.Focus()
    End Sub


    Private Sub imprimir_html()
        Dim partida As oleosigDB.partidasaceiteDataTable
        Dim fileinf As System.IO.StreamWriter
        Dim albaranSTR As System.Text.StringBuilder
        Dim mivisor As frmvisor
        Dim i As Short
        Dim docPDF As iTextSharp.text.Document
        Dim writer As iTextSharp.text.pdf.PdfWriter


        docPDF = New iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 50, 50, 50, 70)
        writer = iTextSharp.text.pdf.PdfWriter.GetInstance(docPDF, New System.IO.FileStream(My.Application.Info.DirectoryPath & "\" & "albaran.pdf", IO.FileMode.Create))


        fileinf = My.Computer.FileSystem.OpenTextFileWriter(My.Application.Info.DirectoryPath & "\albaran.html", False)

        albaranSTR = New System.Text.StringBuilder()


        albaranSTR.Append("<!DOCTYPE html PUBLIC " & Chr(34) & "-//W3C//DTD HTML 4.01//EN" & Chr(34) & " " & Chr(34) & "http://www.w3.org/TR/html4/strict.dtd" & Chr(34) & ">")

        albaranSTR.Append("<html><head><meta content=" & Chr(34) & "text/html;  charset=ISO-8859-1" & Chr(34) & "http-equiv=" & Chr(34) & "content-type" & Chr(34) & "><title>Albaran</title>")
        albaranSTR.Append("<link href=" & Chr(34) & "albaran.css" & Chr(34) & "rel=" & Chr(34) & "stylesheet" & Chr(34) & "type=" & Chr(34) & "text/css" & Chr(34) & "/></head><body>")



        albaranSTR.Append("<div class=" & Chr(34) & "contenedor_gral" & Chr(34) & ">")


        albaranSTR.Append("<div id=" & Chr(34) & "cabecera" & Chr(34) & ">")

        albaranSTR.Append("<span class=" & Chr(34) & "nmempresa" & Chr(34) & ">" & Almazara.Nombre & "</span><br/>")

        albaranSTR.Append("<span >" & Almazara.Cif & "</span><br/>")

        albaranSTR.Append("<span >" & Almazara.Direccion & "</span><br/>")

        albaranSTR.Append("</div>")


        albaranSTR.Append("<div id=" & Chr(34) & "cliente" & Chr(34) & ">")

        albaranSTR.Append("<div id=" & Chr(34) & "caja_cliente" & Chr(34) & ">")


        albaranSTR.Append("<span class=" & Chr(34) & "nmempresa" & Chr(34) & ">" & nmclientetxt.Text & "</span><br/>")

        albaranSTR.Append("<span>" & cifclientetxt.Text & "</span><br/>")

        albaranSTR.Append("<span>" & dirclientetxt.Text & "</span><br/>")

        albaranSTR.Append("<span>" & cpclientetxt.Text & "</span><br/>")

        albaranSTR.Append("<span>" & pobclientetxt.Text & "</span><br/>")

        albaranSTR.Append("<span>" & provclientetxt.Text & "</span><br/>")


        albaranSTR.Append("</div>")

        albaranSTR.Append("</div>")


        albaranSTR.Append("<div id=" & Chr(34) & "cab_num_albaran" & Chr(34) & ">")

        albaranSTR.Append("<div id=" & Chr(34) & "numalbaran" & Chr(34) & ">Albarán de Salida a Granel nº : " & lblnumalbaran.Text & "</div>")

        albaranSTR.Append("<div id=" & Chr(34) & "fecha" & Chr(34) & ">Fecha :" & fechaAlbaran.Value.ToString("dd/mm/yyyy") & "</div>")

        albaranSTR.Append("<br>")

        albaranSTR.Append("</div>")



        albaranSTR.Append("<br/>")


        albaranSTR.Append("<table id=" & Chr(34) & "tabla_partidas" & Chr(34) & ">")

        albaranSTR.Append("<thead>")

        albaranSTR.Append("<th>Producto</th><th>Acidez</th><th>Depósito</th><th>Kilos</th>")

        albaranSTR.Append("</thead>")

        albaranSTR.Append("<tbody>")
        For i = 1 To listaParAlbaran.Items.Count

            partida = oPartidas.GetDataByNumPartida((listaParAlbaran.Items.Item(i).Text))

            albaranSTR.Append("<tr>")

            albaranSTR.Append("<td class=" & Chr(34) & "partida" & Chr(34) & ">" & listaParAlbaran.Items.Item(i).SubItems.Item(3).Text & "</td>")

            albaranSTR.Append("<td class=" & Chr(34) & "partida" & Chr(34) & ">" & listaParAlbaran.Items.Item(i).SubItems.Item(2).Text & "</td>")

            '  albaranSTR.Append("<td class=" & Chr(34) & "partida" & Chr(34) & ">" & oConfig.Tanques(CShort(oLotAceite.getById((partida.Lote)).Tanque)).Nombre & "</td>")

            albaranSTR.Append("<td class=" & Chr(34) & "partida" & Chr(34) & ">" & listaParAlbaran.Items.Item(i).SubItems.Item(1).Text & "</td>")

            albaranSTR.Append("</tr>")


        Next i

        albaranSTR.Append("</tbody>")

        albaranSTR.Append("</table>")

        albaranSTR.Append("<div id=" & Chr(34) & "transporte" & Chr(34) & ">")

        albaranSTR.Append("<div id=" & Chr(34) & "titulo_trans" & Chr(34) & "><h2>Transporte</h2></div>")

        albaranSTR.Append("</div>")

        albaranSTR.Append("<table><tbody>")

        albaranSTR.Append("<tr>")

        albaranSTR.Append("<td>Conductor :</td><td>" & nmconductortxt.Text & "</td><td>D.N.I.</td><td>" & dniconductortxt.Text & "</td>")

        albaranSTR.Append("</tr>")

        albaranSTR.Append("<tr><td>Matricula</td><td>" & matriculatxt.Text & "</td></tr>")

        albaranSTR.Append("</tbody></table>")

        albaranSTR.Append("<table id=" & Chr(34) & "peso_vehiculo" & Chr(34) & "><tbody>")

        albaranSTR.Append("<tr>")

        albaranSTR.Append("<td>Tara</td>")

        albaranSTR.Append("</tr>")

        albaranSTR.Append("<td>Bruto</td>")

        albaranSTR.Append("<tr>")

        albaranSTR.Append("<td>Neto</td>")

        albaranSTR.Append("</tr>")

        albaranSTR.Append("</tbody></table>")

        albaranSTR.Append("<div id=" & Chr(34) & "lblfirma" & Chr(34) & ">Firma del cliente</div>")

        albaranSTR.Append("<div id=" & Chr(34) & "firma" & Chr(34) & "></div>")

        albaranSTR.Append("</div>")
        albaranSTR.Append("</body></html>")


        fileinf.Write(albaranSTR.ToString())
        fileinf.Close()

        docPDF.Close()

        mivisor = New frmvisor
        mivisor.MdiParent = Me.MdiParent

        mivisor.visor.Navigate(New System.Uri(My.Application.Info.DirectoryPath & "\albaran.html"))

        mivisor.Show()

    End Sub



    Private Sub guardar()
        Dim entidad As oleosigDB.albaranesRow
        Dim result As MsgBoxResult


        result = MsgBox("Desea guardar el albarán", MsgBoxStyle.YesNo Or MsgBoxStyle.Question)
        If result = MsgBoxResult.Yes Then

            If Len(lblIdcliente.Text) = 0 Then
                MsgBox("Debe seleccionar un cliente", MsgBoxStyle.Exclamation)
                SSTab1.SelectedIndex = 2
                tablaClientes.Focus()
                Exit Sub
            End If

            If Len(lblIdconductor.Text) = 0 Then
                MsgBox("Debe seleccionar un conductor", MsgBoxStyle.Exclamation)
                SSTab1.SelectedIndex = 3
                tablaconductores.Focus()
                Exit Sub
            End If

            If Len(lblIdVehiculo.Text) = 0 Then
                MsgBox("Debe seleccionar un vehiculo", MsgBoxStyle.Exclamation)
                SSTab1.SelectedIndex = 3
                tablaVehiculos.Focus()
                Exit Sub
            End If

            If Len(brutoTxt.Text) = 0 Then
                MsgBox("Debe introducir un valor para el campo bruto", MsgBoxStyle.Exclamation)
                brutoTxt.Focus()
                Exit Sub
            End If
            If Len(taraTxt.Text) = 0 Then
                MsgBox("Debe introducir un valor para el campo tara", MsgBoxStyle.Exclamation)
                taraTxt.Focus()
                Exit Sub
            End If

            If Len(netoTxt.Text) = 0 Then
                MsgBox("Debe introducir un valor para el campo neto", MsgBoxStyle.Exclamation)
                netoTxt.Focus()
                Exit Sub
            End If

            If listaParAlbaran.Items.Count = 0 Then
                MsgBox("Debe seleccionar partidas de aceite", MsgBoxStyle.Exclamation)
                SSTab1.SelectedIndex = 1
                tablaPartidas.Focus()
                Exit Sub
            End If

            entidad = CType(albaranesBDS.Current, DataRowView).Row

            entidad.cliente = lblIdcliente.Text
            entidad.conductor = lblIdconductor.Text
            entidad.Fecha = fechaAlbaran.Value.ToString("yyyy-mm-dd") & " " & horaAlbaran.Text("hh:mm:00")
            entidad.Numero = lblnumalbaran.Text
            entidad.Tipo = "0"
            entidad.vehiculo = lblIdVehiculo.Text
            entidad.Bruto = brutoTxt.Text
            entidad.Neto = netoTxt.Text
            entidad.Tara = taraTxt.Text
            entidad.Campagna = Almazara.CampañaAct.clave

            oAlbaranes.Update(OleosigDB1.albaranes)

            If editando = True Then


            Else


            End If


            inicia_Componentes()
        End If
    End Sub

   

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        editar()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        inicia_Componentes()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        imprimir_html()
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        borra_albaran()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        guardar()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


    Private Sub btnNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Nuevo_Albaran()
    End Sub

    Private Sub tablaVehiculos_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tablaVehiculos.Click

        Dim fila As DataRow = CType(vehiculosBDS.Current, DataRowView).Row
        lblIdVehiculo.Text = fila("id")
        matriculatxt.Text = fila("matricula")
    End Sub
End Class