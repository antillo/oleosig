Public Class frmCfgImportTickets

    Private importacionDB As ImportacionTableAdapter
    Private cfgimpFijoDB As cfgTicketsFijoTableAdapter
    Private cfgimpDelimDB As TicketDelimTableAdapter

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmCfgImportTickets_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        importacionDB = New ImportacionTableAdapter(Almazara.Id)
        cfgimpFijoDB = New cfgTicketsFijoTableAdapter(Almazara.Id)
        cfgimpDelimDB = New TicketDelimTableAdapter(Almazara.Id)

        cfgimpFijoDB.Fill(OleosigDB1.cfg_imp_ticket_fijo)
        cfgimpDelimDB.Fill(OleosigDB1.cfg_imp_ticket_delimitado)
        importacionDB.Fill(OleosigDB1.importaciones_ticket)


        For Each imp As oleosigDB.importaciones_ticketRow In Me.OleosigDB1.importaciones_ticket.Rows
            arbolImportaciones.Nodes(0).Nodes.Add(imp.nombre)
        Next
        arbolImportaciones.ExpandAll()

        Label4.Visible = False
        Label22.Visible = False
        Label23.Visible = False
        Label24.Visible = False
        Label38.Visible = False

        nmimportacion.Enabled = False

        rb1.Enabled = False
        rb2.Enabled = False
        delimTxt.Enabled = False

        rb1.Checked = False
        rb2.Checked = False

        inicia_componentes()
    End Sub


    Private Sub guarda_fijo()




    End Sub
    Private Sub guarda_Delimitado()


    End Sub

    Private Sub inicia_componentes()

        nmimportacion.Clear()
        nmimportacion.Enabled = True
        delimTxt.Clear()

        Label4.Visible = False
        Label22.Visible = False
        Label23.Visible = False
        Label24.Visible = False
        Label38.Visible = False


        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label13.Visible = False
        Label14.Visible = False
        Label15.Visible = False
        Label16.Visible = False
        Label17.Visible = False
        Label18.Visible = False
        Label19.Visible = False
        Label20.Visible = False
        Label21.Visible = False

        Label25.Visible = False
        Label26.Visible = False
        Label27.Visible = False
        Label28.Visible = False
        Label29.Visible = False
        Label30.Visible = False
        Label31.Visible = False
        Label32.Visible = False
        Label33.Visible = False
        Label34.Visible = False
        Label35.Visible = False
        Label36.Visible = False
        Label37.Visible = False


        cmpImpIni0.Enabled = False
        cmpImpIni1.Enabled = False
        cmpImpIni2.Enabled = False
        cmpImpIni3.Enabled = False
        cmpImpIni4.Enabled = False
        cmpImpIni5.Enabled = False
        cmpImpIni6.Enabled = False
        cmpImpIni7.Enabled = False
        cmpImpIni8.Enabled = False
        cmpImpIni9.Enabled = False
        cmpImpIni10.Enabled = False
        cmpImpIni11.Enabled = False
        cmpImpIni12.Enabled = False
        cmpImpIni13.Enabled = False
        cmpImpIni14.Enabled = False
        cmpImpIni15.Enabled = False
        cmpImpIni16.Enabled = False

        cmpImpIni0.Visible = False
        cmpImpIni1.Visible = False
        cmpImpIni2.Visible = False
        cmpImpIni3.Visible = False
        cmpImpIni4.Visible = False
        cmpImpIni5.Visible = False
        cmpImpIni6.Visible = False
        cmpImpIni7.Visible = False
        cmpImpIni8.Visible = False
        cmpImpIni9.Visible = False
        cmpImpIni10.Visible = False
        cmpImpIni11.Visible = False
        cmpImpIni12.Visible = False
        cmpImpIni13.Visible = False
        cmpImpIni14.Visible = False
        cmpImpIni15.Visible = False
        cmpImpIni16.Visible = False


        cmpLng0.Enabled = False
        cmpLng1.Enabled = False
        cmpLng2.Enabled = False
        cmpLng3.Enabled = False
        cmpLng4.Enabled = False
        cmpLng5.Enabled = False
        cmpLng6.Enabled = False
        cmpLng7.Enabled = False
        cmpLng8.Enabled = False
        cmpLng9.Enabled = False
        cmpLng10.Enabled = False
        cmpLng11.Enabled = False
        cmpLng12.Enabled = False
        cmpLng13.Enabled = False
        cmpLng14.Enabled = False
        cmpLng15.Enabled = False
        cmpLng16.Enabled = False

        cmpLng0.Visible = False
        cmpLng1.Visible = False
        cmpLng2.Visible = False
        cmpLng3.Visible = False
        cmpLng4.Visible = False
        cmpLng5.Visible = False
        cmpLng6.Visible = False
        cmpLng7.Visible = False
        cmpLng8.Visible = False
        cmpLng9.Visible = False
        cmpLng10.Visible = False
        cmpLng11.Visible = False
        cmpLng12.Visible = False
        cmpLng13.Visible = False
        cmpLng14.Visible = False
        cmpLng15.Visible = False
        cmpLng16.Visible = False


        cmpPos0.Enabled = False
        cmpPos1.Enabled = False
        cmpPos2.Enabled = False
        cmpPos3.Enabled = False
        cmpPos4.Enabled = False
        cmpPos5.Enabled = False
        cmpPos6.Enabled = False
        cmpPos7.Enabled = False
        cmpPos8.Enabled = False
        cmpPos9.Enabled = False
        cmpPos10.Enabled = False
        cmpPos11.Enabled = False
        cmpPos12.Enabled = False


        cmpPos0.Visible = False
        cmpPos1.Visible = False
        cmpPos2.Visible = False
        cmpPos3.Visible = False
        cmpPos4.Visible = False
        cmpPos5.Visible = False
        cmpPos6.Visible = False
        cmpPos7.Visible = False
        cmpPos8.Visible = False
        cmpPos9.Visible = False
        cmpPos10.Visible = False
        cmpPos11.Visible = False
        cmpPos12.Visible = False




        Button4.Enabled = False
        Button1.Enabled = False
        Button5.Enabled = True

        chkImportF0.Enabled = False
        chkImportF1.Enabled = False
        chkImportF2.Enabled = False
        chkImportF3.Enabled = False
        chkImportF4.Enabled = False
        chkImportF5.Enabled = False
        chkImportF6.Enabled = False
        chkImportF7.Enabled = False
        chkImportF8.Enabled = False
        chkImportF9.Enabled = False
        chkImportF10.Enabled = False
        chkImportF11.Enabled = False
        chkImportF12.Enabled = False
        chkImportF13.Enabled = False
        chkImportF14.Enabled = False
        chkImportF15.Enabled = False
        chkImportF16.Enabled = False

        chkImportD0.Enabled = False
        chkImportD1.Enabled = False
        chkImportD2.Enabled = False
        chkImportD3.Enabled = False
        chkImportD4.Enabled = False
        chkImportD5.Enabled = False
        chkImportD6.Enabled = False
        chkImportD7.Enabled = False
        chkImportD8.Enabled = False
        chkImportD9.Enabled = False
        chkImportD10.Enabled = False
        chkImportD11.Enabled = False
        chkImportD12.Enabled = False



        cmpImpIni0.Clear()
        cmpImpIni1.Clear()
        cmpImpIni2.Clear()
        cmpImpIni3.Clear()
        cmpImpIni4.Clear()
        cmpImpIni5.Clear()
        cmpImpIni6.Clear()
        cmpImpIni7.Clear()
        cmpImpIni8.Clear()
        cmpImpIni9.Clear()
        cmpImpIni10.Clear()
        cmpImpIni11.Clear()
        cmpImpIni12.Clear()
        cmpImpIni13.Clear()
        cmpImpIni14.Clear()
        cmpImpIni15.Clear()
        cmpImpIni16.Clear()

        cmpLng0.Clear()
        cmpLng1.Clear()
        cmpLng2.Clear()
        cmpLng3.Clear()
        cmpLng4.Clear()
        cmpLng5.Clear()
        cmpLng6.Clear()
        cmpLng7.Clear()
        cmpLng8.Clear()
        cmpLng9.Clear()
        cmpLng10.Clear()
        cmpLng11.Clear()
        cmpLng12.Clear()
        cmpLng13.Clear()
        cmpLng14.Clear()
        cmpLng15.Clear()
        cmpLng16.Clear()


        cmpPos0.Clear()
        cmpPos1.Clear()
        cmpPos2.Clear()
        cmpPos3.Clear()
        cmpPos4.Clear()
        cmpPos5.Clear()
        cmpPos6.Clear()
        cmpPos7.Clear()
        cmpPos8.Clear()
        cmpPos9.Clear()
        cmpPos10.Clear()
        cmpPos11.Clear()
        cmpPos12.Clear()

        chkImportF0.Checked = False
        chkImportF1.Checked = False
        chkImportF2.Checked = False
        chkImportF3.Checked = False
        chkImportF4.Checked = False
        chkImportF5.Checked = False
        chkImportF6.Checked = False
        chkImportF7.Checked = False
        chkImportF8.Checked = False
        chkImportF9.Checked = False
        chkImportF10.Checked = False
        chkImportF11.Checked = False
        chkImportF12.Checked = False
        chkImportF13.Checked = False
        chkImportF14.Checked = False
        chkImportF15.Checked = False
        chkImportF16.Checked = False

        chkImportD0.Checked = False
        chkImportD1.Checked = False
        chkImportD2.Checked = False
        chkImportD3.Checked = False
        chkImportD4.Checked = False
        chkImportD5.Checked = False
        chkImportD6.Checked = False
        chkImportD7.Checked = False
        chkImportD8.Checked = False
        chkImportD9.Checked = False
        chkImportD10.Checked = False
        chkImportD11.Checked = False
        chkImportD12.Checked = False

        chkImportF0.Visible = False
        chkImportF1.Visible = False
        chkImportF2.Visible = False
        chkImportF3.Visible = False
        chkImportF4.Visible = False
        chkImportF5.Visible = False
        chkImportF6.Visible = False
        chkImportF7.Visible = False
        chkImportF8.Visible = False
        chkImportF9.Visible = False
        chkImportF10.Visible = False
        chkImportF11.Visible = False
        chkImportF12.Visible = False
        chkImportF13.Visible = False
        chkImportF14.Visible = False
        chkImportF15.Visible = False
        chkImportF16.Visible = False

        chkImportD0.Visible = False
        chkImportD1.Visible = False
        chkImportD2.Visible = False
        chkImportD3.Visible = False
        chkImportD4.Visible = False
        chkImportD5.Visible = False
        chkImportD6.Visible = False
        chkImportD7.Visible = False
        chkImportD8.Visible = False
        chkImportD9.Visible = False
        chkImportD10.Visible = False
        chkImportD11.Visible = False
        chkImportD12.Visible = False



        rb1.Enabled = False
        rb2.Enabled = False

        arbolImportaciones.Enabled = True
        arbolImportaciones.CollapseAll()
        arbolImportaciones.ExpandAll()
    End Sub
    Private Sub rb1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb1.CheckedChanged
        If rb1.Checked Then



            Label4.Visible = True
            Label22.Visible = True
            Label23.Visible = True
            Label24.Visible = False
            Label38.Visible = False

            Label5.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            Label10.Visible = True
            Label11.Visible = True
            Label12.Visible = True
            Label13.Visible = True
            Label14.Visible = True
            Label15.Visible = True
            Label16.Visible = True
            Label17.Visible = True
            Label18.Visible = True
            Label19.Visible = True
            Label20.Visible = True
            Label21.Visible = True

            Label25.Visible = False
            Label26.Visible = False
            Label27.Visible = False
            Label28.Visible = False
            Label29.Visible = False
            Label30.Visible = False
            Label31.Visible = False
            Label32.Visible = False
            Label33.Visible = False
            Label35.Visible = False
            Label34.Visible = False
            Label36.Visible = False
            Label37.Visible = False


            cmpLng0.Visible = True
            cmpLng1.Visible = True
            cmpLng2.Visible = True
            cmpLng3.Visible = True
            cmpLng4.Visible = True
            cmpLng5.Visible = True
            cmpLng6.Visible = True
            cmpLng7.Visible = True
            cmpLng8.Visible = True
            cmpLng9.Visible = True
            cmpLng10.Visible = True
            cmpLng11.Visible = True
            cmpLng12.Visible = True
            cmpLng13.Visible = True
            cmpLng14.Visible = True
            cmpLng15.Visible = True
            cmpLng16.Visible = True

            cmpImpIni0.Visible = True
            cmpImpIni1.Visible = True
            cmpImpIni2.Visible = True
            cmpImpIni3.Visible = True
            cmpImpIni4.Visible = True
            cmpImpIni5.Visible = True
            cmpImpIni6.Visible = True
            cmpImpIni7.Visible = True
            cmpImpIni8.Visible = True
            cmpImpIni9.Visible = True
            cmpImpIni10.Visible = True
            cmpImpIni11.Visible = True
            cmpImpIni12.Visible = True
            cmpImpIni13.Visible = True
            cmpImpIni14.Visible = True
            cmpImpIni15.Visible = True
            cmpImpIni16.Visible = True

            cmpPos0.Visible = False
            cmpPos1.Visible = False
            cmpPos2.Visible = False
            cmpPos3.Visible = False
            cmpPos4.Visible = False
            cmpPos5.Visible = False
            cmpPos6.Visible = False
            cmpPos7.Visible = False
            cmpPos8.Visible = False
            cmpPos9.Visible = False
            cmpPos10.Visible = False
            cmpPos11.Visible = False
            cmpPos12.Visible = False

            chkImportF0.Visible = True
            chkImportF1.Visible = True
            chkImportF2.Visible = True
            chkImportF3.Visible = True
            chkImportF4.Visible = True
            chkImportF5.Visible = True
            chkImportF6.Visible = True
            chkImportF7.Visible = True
            chkImportF8.Visible = True
            chkImportF9.Visible = True
            chkImportF10.Visible = True
            chkImportF11.Visible = True
            chkImportF12.Visible = True
            chkImportF13.Visible = True
            chkImportF14.Visible = True
            chkImportF15.Visible = True
            chkImportF16.Visible = True

            chkImportD0.Visible = False
            chkImportD1.Visible = False
            chkImportD2.Visible = False
            chkImportD3.Visible = False
            chkImportD4.Visible = False
            chkImportD5.Visible = False
            chkImportD6.Visible = False
            chkImportD7.Visible = False
            chkImportD8.Visible = False
            chkImportD9.Visible = False
            chkImportD0.Visible = False
            chkImportD10.Visible = False
            chkImportD11.Visible = False
            chkImportD12.Visible = False

        End If
    End Sub

    Private Sub rb2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb2.CheckedChanged
        If rb2.Checked Then



            Label4.Visible = False
            Label22.Visible = False
            Label23.Visible = False
            Label24.Visible = True
            Label38.Visible = True

            Label5.Visible = False
            Label6.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            Label9.Visible = False
            Label10.Visible = False
            Label11.Visible = False
            Label12.Visible = False
            Label13.Visible = False
            Label14.Visible = False
            Label15.Visible = False
            Label16.Visible = False
            Label17.Visible = False
            Label18.Visible = False
            Label19.Visible = False
            Label20.Visible = False
            Label21.Visible = False

            cmpImpIni0.Visible = False
            cmpImpIni1.Visible = False
            cmpImpIni2.Visible = False
            cmpImpIni3.Visible = False
            cmpImpIni4.Visible = False
            cmpImpIni5.Visible = False
            cmpImpIni6.Visible = False
            cmpImpIni7.Visible = False
            cmpImpIni8.Visible = False
            cmpImpIni9.Visible = False
            cmpImpIni10.Visible = False
            cmpImpIni11.Visible = False
            cmpImpIni12.Visible = False
            cmpImpIni13.Visible = False
            cmpImpIni14.Visible = False
            cmpImpIni15.Visible = False
            cmpImpIni16.Visible = False

            cmpLng0.Visible = False
            cmpLng1.Visible = False
            cmpLng2.Visible = False
            cmpLng3.Visible = False
            cmpLng4.Visible = False
            cmpLng5.Visible = False
            cmpLng6.Visible = False
            cmpLng7.Visible = False
            cmpLng8.Visible = False
            cmpLng9.Visible = False
            cmpLng10.Visible = False
            cmpLng11.Visible = False
            cmpLng12.Visible = False
            cmpLng13.Visible = False
            cmpLng14.Visible = False
            cmpLng15.Visible = False
            cmpLng16.Visible = False

            chkImportF0.Visible = False
            chkImportF1.Visible = False
            chkImportF2.Visible = False
            chkImportF3.Visible = False
            chkImportF4.Visible = False
            chkImportF5.Visible = False
            chkImportF6.Visible = False
            chkImportF7.Visible = False
            chkImportF8.Visible = False
            chkImportF9.Visible = False
            chkImportF10.Visible = False
            chkImportF11.Visible = False
            chkImportF12.Visible = False
            chkImportF13.Visible = False
            chkImportF14.Visible = False
            chkImportF15.Visible = False
            chkImportF16.Visible = False

            Label25.Visible = True
            Label26.Visible = True
            Label27.Visible = True
            Label28.Visible = True
            Label29.Visible = True
            Label30.Visible = True
            Label31.Visible = True
            Label32.Visible = True
            Label33.Visible = True
            Label34.Visible = True
            Label35.Visible = True
            Label36.Visible = True
            Label37.Visible = True


            cmpPos0.Visible = True
            cmpPos1.Visible = True
            cmpPos2.Visible = True
            cmpPos3.Visible = True
            cmpPos4.Visible = True
            cmpPos5.Visible = True
            cmpPos6.Visible = True
            cmpPos7.Visible = True
            cmpPos8.Visible = True
            cmpPos9.Visible = True
            cmpPos10.Visible = True
            cmpPos11.Visible = True
            cmpPos12.Visible = True

            chkImportD0.Visible = True
            chkImportD1.Visible = True
            chkImportD2.Visible = True
            chkImportD3.Visible = True
            chkImportD4.Visible = True
            chkImportD5.Visible = True
            chkImportD6.Visible = True
            chkImportD7.Visible = True
            chkImportD8.Visible = True
            chkImportD9.Visible = True
            chkImportD10.Visible = True
            chkImportD11.Visible = True
            chkImportD12.Visible = True



        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Desea guardar los datos ?", MsgBoxStyle.Critical Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Dim importacion As oleosigDB.importaciones_ticketRow
            importacion = CType(importacionesBDS.AddNew, DataRowView).Row

            importacion.nombre = nmimportacion.Text
            importacion.idalmazara = Almazara.Id
            importacion.pesaje = 0
            importacion.idconfig = importacionDB.GetLastNumimportacion() + 1

            If rb1.Checked Then
                Dim impfijo As oleosigDB.cfg_imp_ticket_fijoRow

                importacion.Tipo = 1
                impfijo = CType(cfgImpFijoBDS.AddNew(), DataRowView).Row

                impfijo.idalmazara = Almazara.Id
                impfijo.inicio = cmpImpIni0.Text
                impfijo.campo = 0
                impfijo.longitud = cmpLng0.Text
                impfijo.importar = chkImportF0.Checked
                impfijo.numimportacion = importacion.idconfig

                impfijo = CType(cfgImpFijoBDS.AddNew(), DataRowView).Row

                impfijo.idalmazara = Almazara.Id
                impfijo.inicio = cmpImpIni1.Text
                impfijo.campo = 1
                impfijo.longitud = cmpLng1.Text
                impfijo.importar = chkImportF1.Checked
                impfijo.numimportacion = importacion.idconfig

                impfijo = CType(cfgImpFijoBDS.AddNew(), DataRowView).Row

                impfijo.idalmazara = Almazara.Id
                impfijo.inicio = cmpImpIni2.Text
                impfijo.campo = 2
                impfijo.longitud = cmpLng2.Text
                impfijo.importar = chkImportF2.Checked
                impfijo.numimportacion = importacion.idconfig

                impfijo = CType(cfgImpFijoBDS.AddNew(), DataRowView).Row

                impfijo.idalmazara = Almazara.Id
                impfijo.inicio = cmpImpIni3.Text
                impfijo.campo = 3
                impfijo.longitud = cmpLng3.Text
                impfijo.importar = chkImportF3.Checked
                impfijo.numimportacion = importacion.idconfig

                impfijo = CType(cfgImpFijoBDS.AddNew(), DataRowView).Row

                impfijo.idalmazara = Almazara.Id
                impfijo.inicio = cmpImpIni4.Text
                impfijo.campo = 4
                impfijo.longitud = cmpLng4.Text
                impfijo.importar = chkImportF4.Checked
                impfijo.numimportacion = importacion.idconfig

                impfijo = CType(cfgImpFijoBDS.AddNew(), DataRowView).Row

                impfijo.idalmazara = Almazara.Id
                impfijo.inicio = cmpImpIni5.Text
                impfijo.campo = 5
                impfijo.longitud = cmpLng5.Text
                impfijo.importar = chkImportF5.Checked
                impfijo.numimportacion = importacion.idconfig


                impfijo = CType(cfgImpFijoBDS.AddNew(), DataRowView).Row

                impfijo.idalmazara = Almazara.Id
                impfijo.inicio = cmpImpIni6.Text
                impfijo.campo = 6
                impfijo.longitud = cmpLng6.Text
                impfijo.importar = chkImportF6.Checked
                impfijo.numimportacion = importacion.idconfig

                impfijo = CType(cfgImpFijoBDS.AddNew(), DataRowView).Row

                impfijo.idalmazara = Almazara.Id
                impfijo.inicio = cmpImpIni7.Text()
                impfijo.campo = 7
                impfijo.longitud = cmpLng7.Text
                impfijo.importar = chkImportF7.Checked
                impfijo.numimportacion = importacion.idconfig

                impfijo = CType(cfgImpFijoBDS.AddNew(), DataRowView).Row

                impfijo.idalmazara = Almazara.Id
                impfijo.inicio = cmpImpIni8.Text
                impfijo.campo = 8
                impfijo.longitud = cmpLng8.Text
                impfijo.importar = chkImportF8.Checked
                impfijo.numimportacion = importacion.idconfig

                impfijo = CType(cfgImpFijoBDS.AddNew(), DataRowView).Row

                impfijo.idalmazara = Almazara.Id
                impfijo.inicio = cmpImpIni9.Text
                impfijo.campo = 9
                impfijo.longitud = cmpLng9.Text
                impfijo.importar = chkImportF9.Checked
                impfijo.numimportacion = importacion.idconfig

                impfijo = CType(cfgImpFijoBDS.AddNew(), DataRowView).Row

                impfijo.idalmazara = Almazara.Id
                impfijo.inicio = cmpImpIni10.Text
                impfijo.campo = 10
                impfijo.longitud = cmpLng10.Text
                impfijo.importar = chkImportF10.Checked
                impfijo.numimportacion = importacion.idconfig

                impfijo = CType(cfgImpFijoBDS.AddNew(), DataRowView).Row

                impfijo.idalmazara = Almazara.Id
                impfijo.inicio = cmpImpIni11.Text
                impfijo.campo = 11
                impfijo.longitud = cmpLng11.Text
                impfijo.importar = chkImportF11.Checked
                impfijo.numimportacion = importacion.idconfig

                impfijo = CType(cfgImpFijoBDS.AddNew(), DataRowView).Row

                impfijo.idalmazara = Almazara.Id
                impfijo.inicio = cmpImpIni12.Text
                impfijo.campo = 12
                impfijo.longitud = cmpLng12.Text
                impfijo.importar = chkImportF12.Checked
                impfijo.numimportacion = importacion.idconfig

                impfijo = CType(cfgImpFijoBDS.AddNew(), DataRowView).Row

                impfijo.idalmazara = Almazara.Id
                impfijo.inicio = cmpImpIni13.Text
                impfijo.campo = 13
                impfijo.longitud = cmpLng13.Text
                impfijo.importar = chkImportF13.Checked
                impfijo.numimportacion = importacion.idconfig

                impfijo = CType(cfgImpFijoBDS.AddNew(), DataRowView).Row

                impfijo.idalmazara = Almazara.Id
                impfijo.inicio = cmpImpIni14.Text
                impfijo.campo = 14
                impfijo.longitud = cmpLng14.Text
                impfijo.importar = chkImportF14.Checked
                impfijo.numimportacion = importacion.idconfig

                impfijo = CType(cfgImpFijoBDS.AddNew(), DataRowView).Row

                impfijo.idalmazara = Almazara.Id
                impfijo.inicio = cmpImpIni15.Text
                impfijo.campo = 15
                impfijo.longitud = cmpLng15.Text
                impfijo.importar = chkImportF15.Checked
                impfijo.numimportacion = importacion.idconfig

                impfijo = CType(cfgImpFijoBDS.AddNew(), DataRowView).Row

                impfijo.idalmazara = Almazara.Id
                impfijo.inicio = cmpImpIni16.Text
                impfijo.campo = 16
                impfijo.longitud = cmpLng16.Text
                impfijo.importar = chkImportF16.Checked
                impfijo.numimportacion = importacion.idconfig

                cfgImpFijoBDS.EndEdit()
                importacionesBDS.EndEdit()

                importacionDB.Update(OleosigDB1.importaciones_ticket)
                cfgimpFijoDB.Update(OleosigDB1.cfg_imp_ticket_fijo)

            ElseIf rb2.Checked Then

                Dim impdelim As oleosigDB.cfg_imp_ticket_delimitadoRow

                importacion.tipo = 2
                importacion.Delimitador = delimTxt.Text

                impdelim = CType(cfgDelimBDS.AddNew, DataRowView).Row

                impdelim.idalmazara = Almazara.Id
                impdelim.posicion = cmpPos0.Text
                impdelim.campo = 0
                impdelim.numimportacion = importacion.idconfig
                impdelim.importar = chkImportD0.Checked

                impdelim = CType(cfgDelimBDS.AddNew, DataRowView).Row

                impdelim.idalmazara = Almazara.Id
                impdelim.posicion = cmpPos1.Text
                impdelim.campo = 1
                impdelim.numimportacion = importacion.idconfig
                impdelim.importar = chkImportD1.Checked

                impdelim = CType(cfgDelimBDS.AddNew, DataRowView).Row

                impdelim.idalmazara = Almazara.Id
                impdelim.posicion = cmpPos2.Text
                impdelim.campo = 2
                impdelim.numimportacion = importacion.idconfig
                impdelim.importar = chkImportD2.Checked

                impdelim = CType(cfgDelimBDS.AddNew, DataRowView).Row

                impdelim.idalmazara = Almazara.Id
                impdelim.posicion = cmpPos3.Text
                impdelim.campo = 3
                impdelim.numimportacion = importacion.idconfig
                impdelim.importar = chkImportD3.Checked

                impdelim = CType(cfgDelimBDS.AddNew, DataRowView).Row

                impdelim.idalmazara = Almazara.Id
                impdelim.posicion = cmpPos4.Text
                impdelim.campo = 4
                impdelim.numimportacion = importacion.idconfig
                impdelim.importar = chkImportD4.Checked

                impdelim = CType(cfgDelimBDS.AddNew, DataRowView).Row

                impdelim.idalmazara = Almazara.Id
                impdelim.posicion = cmpPos5.Text
                impdelim.campo = 5
                impdelim.numimportacion = importacion.idconfig
                impdelim.importar = chkImportD5.Checked

                impdelim = CType(cfgDelimBDS.AddNew, DataRowView).Row

                impdelim.idalmazara = Almazara.Id
                impdelim.posicion = cmpPos6.Text
                impdelim.campo = 6
                impdelim.numimportacion = importacion.idconfig
                impdelim.importar = chkImportD6.Checked

                impdelim = CType(cfgDelimBDS.AddNew, DataRowView).Row

                impdelim.idalmazara = Almazara.Id
                impdelim.posicion = cmpPos7.Text
                impdelim.campo = 7
                impdelim.numimportacion = importacion.idconfig
                impdelim.importar = chkImportD7.Checked

                impdelim = CType(cfgDelimBDS.AddNew, DataRowView).Row

                impdelim.idalmazara = Almazara.Id
                impdelim.posicion = cmpPos8.Text
                impdelim.campo = 8
                impdelim.numimportacion = importacion.idconfig
                impdelim.importar = chkImportD8.Checked


                impdelim = CType(cfgDelimBDS.AddNew, DataRowView).Row

                impdelim.idalmazara = Almazara.Id
                impdelim.posicion = cmpPos9.Text
                impdelim.campo = 9
                impdelim.numimportacion = importacion.idconfig
                impdelim.importar = chkImportD9.Checked

                impdelim = CType(cfgDelimBDS.AddNew, DataRowView).Row

                impdelim.idalmazara = Almazara.Id
                impdelim.posicion = cmpPos10.Text
                impdelim.campo = 10
                impdelim.numimportacion = importacion.idconfig
                impdelim.importar = chkImportD10.Checked

                impdelim = CType(cfgDelimBDS.AddNew, DataRowView).Row

                impdelim.idalmazara = Almazara.Id
                impdelim.posicion = cmpPos11.Text
                impdelim.campo = 11
                impdelim.numimportacion = importacion.idconfig
                impdelim.importar = chkImportD11.Checked

                impdelim = CType(cfgDelimBDS.AddNew, DataRowView).Row

                impdelim.idalmazara = Almazara.Id
                impdelim.posicion = cmpPos12.Text
                impdelim.campo = 12
                impdelim.numimportacion = importacion.idconfig
                impdelim.importar = chkImportD12.Checked

                cfgDelimBDS.EndEdit()
                importacionesBDS.EndEdit()

                importacionDB.Update(OleosigDB1.importaciones_ticket)
                cfgimpDelimDB.Update(OleosigDB1.cfg_imp_ticket_delimitado)
            End If


            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Private Sub arbolImportaciones_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles arbolImportaciones.AfterSelect
        If arbolImportaciones.SelectedNode.Level > 0 Then
            nmimportacion.Text = arbolImportaciones.SelectedNode.Text
            'importacion = Almazara.ConfigsTicket.Find("Nombre", arbolImportaciones.SelectedNode.Text)

            importacionesBDS.Filter = "nombre='" & arbolImportaciones.SelectedNode.Text & "'"
            Dim importacion As oleosigDB.importaciones_ticketrow = CType(importacionesBDS.Current, DataRowView).Row

            If importacion IsNot Nothing Then
                Button4.Enabled = True
                If importacion.tipo = 1 Then

                    'cfgFijoBDS.Filter = "numimportacion='" & importacion.idconfig.ToString & "'"
                    Dim impFijo() As oleosigDB.cfg_imp_ticket_fijoRow
                    impFijo = importacion.Getcfg_imp_ticket_fijoRows()


                    Button5.Enabled = False
                    Button4.Enabled = True



                    rb1.Checked = True

                    Label4.Visible = True
                    Label22.Visible = True
                    Label24.Visible = False
                    Label5.Visible = True
                    Label6.Visible = True
                    Label7.Visible = True
                    Label8.Visible = True
                    Label9.Visible = True
                    Label10.Visible = True
                    Label11.Visible = True
                    Label12.Visible = True
                    Label13.Visible = True
                    Label14.Visible = True
                    Label15.Visible = True
                    Label16.Visible = True
                    Label17.Visible = True
                    Label18.Visible = True
                    Label19.Visible = True
                    Label20.Visible = True
                    Label21.Visible = True

                    Label25.Visible = False
                    Label26.Visible = False
                    Label27.Visible = False
                    Label28.Visible = False
                    Label29.Visible = False
                    Label30.Visible = False
                    Label31.Visible = False
                    Label32.Visible = False
                    Label33.Visible = False
                    Label35.Visible = False
                    Label34.Visible = False
                    Label36.Visible = False
                    Label37.Visible = False


                    cmpLng0.Visible = True
                    cmpLng1.Visible = True
                    cmpLng2.Visible = True
                    cmpLng3.Visible = True
                    cmpLng4.Visible = True
                    cmpLng5.Visible = True
                    cmpLng6.Visible = True
                    cmpLng7.Visible = True
                    cmpLng8.Visible = True
                    cmpLng9.Visible = True
                    cmpLng10.Visible = True
                    cmpLng11.Visible = True
                    cmpLng12.Visible = True
                    cmpLng13.Visible = True
                    cmpLng14.Visible = True
                    cmpLng15.Visible = True
                    cmpLng16.Visible = True

                    cmpImpIni0.Visible = True
                    cmpImpIni1.Visible = True
                    cmpImpIni2.Visible = True
                    cmpImpIni3.Visible = True
                    cmpImpIni4.Visible = True
                    cmpImpIni5.Visible = True
                    cmpImpIni6.Visible = True
                    cmpImpIni7.Visible = True
                    cmpImpIni8.Visible = True
                    cmpImpIni9.Visible = True
                    cmpImpIni10.Visible = True
                    cmpImpIni11.Visible = True
                    cmpImpIni12.Visible = True
                    cmpImpIni13.Visible = True
                    cmpImpIni14.Visible = True
                    cmpImpIni15.Visible = True
                    cmpImpIni16.Visible = True

                    chkImportF0.Visible = True
                    chkImportF1.Visible = True
                    chkImportF2.Visible = True
                    chkImportF3.Visible = True
                    chkImportF4.Visible = True
                    chkImportF5.Visible = True
                    chkImportF6.Visible = True
                    chkImportF7.Visible = True
                    chkImportF8.Visible = True
                    chkImportF9.Visible = True
                    chkImportF10.Visible = True
                    chkImportF11.Visible = True
                    chkImportF12.Visible = True
                    chkImportF13.Visible = True
                    chkImportF14.Visible = True
                    chkImportF15.Visible = True
                    chkImportF16.Visible = True


                    chkImportD0.Visible = False
                    chkImportD1.Visible = False
                    chkImportD2.Visible = False
                    chkImportD3.Visible = False
                    chkImportD4.Visible = False
                    chkImportD5.Visible = False
                    chkImportD6.Visible = False
                    chkImportD7.Visible = False
                    chkImportD8.Visible = False
                    chkImportD9.Visible = False
                    chkImportD10.Visible = False
                    chkImportD11.Visible = False
                    chkImportD12.Visible = False



                    cmpPos0.Visible = False
                    cmpPos1.Visible = False
                    cmpPos2.Visible = False
                    cmpPos3.Visible = False
                    cmpPos4.Visible = False
                    cmpPos5.Visible = False
                    cmpPos6.Visible = False
                    cmpPos7.Visible = False
                    cmpPos8.Visible = False
                    cmpPos9.Visible = False
                    cmpPos10.Visible = False
                    cmpPos11.Visible = False
                    cmpPos12.Visible = False


                    cmpImpIni0.Text = impFijo(0).inicio
                    cmpImpIni1.Text = impFijo(1).inicio
                    cmpImpIni2.Text = impFijo(2).inicio
                    cmpImpIni3.Text = impFijo(3).inicio
                    cmpImpIni4.Text = impFijo(4).inicio
                    cmpImpIni5.Text = impFijo(5).inicio
                    cmpImpIni6.Text = impFijo(6).inicio
                    cmpImpIni7.Text = impFijo(7).inicio
                    cmpImpIni8.Text = impFijo(8).inicio
                    cmpImpIni9.Text = impFijo(9).inicio
                    cmpImpIni10.Text = impFijo(10).inicio
                    cmpImpIni11.Text = impFijo(11).inicio
                    cmpImpIni12.Text = impFijo(12).inicio
                    cmpImpIni13.Text = impFijo(13).inicio
                    cmpImpIni14.Text = impFijo(14).inicio
                    cmpImpIni15.Text = impFijo(15).inicio
                    cmpImpIni16.Text = impFijo(16).inicio


                    cmpLng0.Text = impFijo(0).longitud
                    cmpLng1.Text = impFijo(1).longitud
                    cmpLng2.Text = impFijo(2).longitud
                    cmpLng3.Text = impFijo(3).longitud
                    cmpLng4.Text = impFijo(4).longitud
                    cmpLng5.Text = impFijo(5).longitud
                    cmpLng6.Text = impFijo(6).longitud
                    cmpLng7.Text = impFijo(7).longitud
                    cmpLng8.Text = impFijo(8).longitud
                    cmpLng9.Text = impFijo(9).longitud
                    cmpLng10.Text = impFijo(10).longitud
                    cmpLng11.Text = impFijo(11).longitud
                    cmpLng12.Text = impFijo(12).longitud
                    cmpLng13.Text = impFijo(13).longitud
                    cmpLng14.Text = impFijo(14).longitud
                    cmpLng15.Text = impFijo(15).longitud
                    cmpLng16.Text = impFijo(16).longitud

                    chkImportF0.Checked = impFijo(0).importar
                    chkImportF1.Checked = impFijo(1).importar
                    chkImportF2.Checked = impFijo(2).importar
                    chkImportF3.Checked = impFijo(3).importar
                    chkImportF4.Checked = impFijo(4).importar
                    chkImportF5.Checked = impFijo(5).importar
                    chkImportF6.Checked = impFijo(6).importar
                    chkImportF7.Checked = impFijo(7).importar
                    chkImportF8.Checked = impFijo(8).importar
                    chkImportF9.Checked = impFijo(9).importar
                    chkImportF10.Checked = impFijo(10).importar
                    chkImportF11.Checked = impFijo(11).importar
                    chkImportF12.Checked = impFijo(12).importar
                    chkImportF13.Checked = impFijo(13).importar
                    chkImportF14.Checked = impFijo(14).importar
                    chkImportF15.Checked = impFijo(15).importar
                    chkImportF16.Checked = impFijo(16).importar


                ElseIf importacion.tipo = 2 Then
                    Dim impDelim() As oleosigDB.cfg_imp_ticket_delimitadoRow
                    impDelim = importacion.Getcfg_imp_ticket_delimitadoRows
                    rb2.Checked = True

                    delimTxt.Text = importacion.delimitador

                    Label4.Visible = False
                    Label22.Visible = False
                    Label24.Visible = True
                    Label5.Visible = False
                    Label6.Visible = False
                    Label7.Visible = False
                    Label8.Visible = False
                    Label9.Visible = False
                    Label10.Visible = False
                    Label11.Visible = False
                    Label12.Visible = False
                    Label13.Visible = False
                    Label14.Visible = False
                    Label15.Visible = False
                    Label16.Visible = False
                    Label17.Visible = False
                    Label18.Visible = False
                    Label19.Visible = False
                    Label20.Visible = False
                    Label21.Visible = False

                    Label25.Visible = True
                    Label26.Visible = True
                    Label27.Visible = True
                    Label28.Visible = True
                    Label29.Visible = True
                    Label30.Visible = True
                    Label31.Visible = True
                    Label32.Visible = True
                    Label33.Visible = True
                    Label34.Visible = True
                    Label35.Visible = True
                    Label36.Visible = True
                    Label37.Visible = True


                    cmpImpIni0.Visible = False
                    cmpImpIni1.Visible = False
                    cmpImpIni2.Visible = False
                    cmpImpIni3.Visible = False
                    cmpImpIni4.Visible = False
                    cmpImpIni5.Visible = False
                    cmpImpIni6.Visible = False
                    cmpImpIni7.Visible = False
                    cmpImpIni8.Visible = False
                    cmpImpIni9.Visible = False
                    cmpImpIni10.Visible = False
                    cmpImpIni11.Visible = False
                    cmpImpIni12.Visible = False
                    cmpImpIni13.Visible = False
                    cmpImpIni14.Visible = False
                    cmpImpIni15.Visible = False
                    cmpImpIni16.Visible = False

                    cmpLng0.Visible = False
                    cmpLng1.Visible = False
                    cmpLng2.Visible = False
                    cmpLng3.Visible = False
                    cmpLng4.Visible = False
                    cmpLng5.Visible = False
                    cmpLng6.Visible = False
                    cmpLng7.Visible = False
                    cmpLng8.Visible = False
                    cmpLng9.Visible = False
                    cmpLng10.Visible = False
                    cmpLng11.Visible = False
                    cmpLng12.Visible = False
                    cmpLng13.Visible = False
                    cmpLng14.Visible = False
                    cmpLng15.Visible = False
                    cmpLng16.Visible = False

                    cmpPos0.Visible = True
                    cmpPos1.Visible = True
                    cmpPos2.Visible = True
                    cmpPos3.Visible = True
                    cmpPos4.Visible = True
                    cmpPos5.Visible = True
                    cmpPos6.Visible = True
                    cmpPos7.Visible = True
                    cmpPos8.Visible = True
                    cmpPos9.Visible = True
                    cmpPos10.Visible = True
                    cmpPos11.Visible = True
                    cmpPos12.Visible = True

                    chkImportF0.Visible = False
                    chkImportF1.Visible = False
                    chkImportF2.Visible = False
                    chkImportF3.Visible = False
                    chkImportF4.Visible = False
                    chkImportF5.Visible = False
                    chkImportF6.Visible = False
                    chkImportF7.Visible = False
                    chkImportF8.Visible = False
                    chkImportF9.Visible = False
                    chkImportF10.Visible = False
                    chkImportF11.Visible = False
                    chkImportF12.Visible = False
                    chkImportF13.Visible = False
                    chkImportF14.Visible = False
                    chkImportF15.Visible = False
                    chkImportF16.Visible = False

                    chkImportD0.Visible = True
                    chkImportD1.Visible = True
                    chkImportD2.Visible = True
                    chkImportD3.Visible = True
                    chkImportD4.Visible = True
                    chkImportD5.Visible = True
                    chkImportD6.Visible = True
                    chkImportD7.Visible = True
                    chkImportD8.Visible = True
                    chkImportD9.Visible = True
                    chkImportD10.Visible = True
                    chkImportD11.Visible = True
                    chkImportD12.Visible = True


                    cmpPos0.Text = impDelim(0).posicion.ToString
                    cmpPos1.Text = impDelim(1).posicion.ToString
                    cmpPos2.Text = impDelim(2).posicion.ToString
                    cmpPos3.Text = impDelim(3).posicion.ToString
                    cmpPos4.Text = impDelim(4).posicion.ToString
                    cmpPos5.Text = impDelim(5).posicion.ToString
                    cmpPos6.Text = impDelim(6).posicion.ToString
                    cmpPos7.Text = impDelim(7).posicion.ToString
                    cmpPos8.Text = impDelim(8).posicion.ToString
                    cmpPos9.Text = impDelim(9).posicion.ToString
                    cmpPos10.Text = impDelim(10).posicion.ToString
                    cmpPos11.Text = impDelim(11).posicion.ToString
                    cmpPos12.Text = impDelim(12).posicion.ToString

                    chkImportD0.Checked = impDelim(0).importar
                    chkImportD1.Checked = impDelim(1).importar
                    chkImportD2.Checked = impDelim(2).importar
                    chkImportD3.Checked = impDelim(3).importar
                    chkImportD4.Checked = impDelim(4).importar
                    chkImportD5.Checked = impDelim(5).importar
                    chkImportD6.Checked = impDelim(6).importar
                    chkImportD7.Checked = impDelim(7).importar
                    chkImportD8.Checked = impDelim(8).importar
                    chkImportD9.Checked = impDelim(9).importar
                    chkImportD10.Checked = impDelim(10).importar
                    chkImportD11.Checked = impDelim(11).importar
                    chkImportD12.Checked = impDelim(12).importar


                End If
            End If
        ElseIf arbolImportaciones.SelectedNode.Level = 0 Then
            inicia_componentes()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If arbolImportaciones.SelectedNode.Level > 0 Then

            If MsgBox("Desea borrar la configuración seleccionada", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                'importacion = Almazara.ConfigsTicket.Find("Nombre", arbolImportaciones.SelectedNode.Text)

                ' Almazara.guarda_importacion_ticket(importacion)

                arbolImportaciones.Nodes.Remove(arbolImportaciones.SelectedNode)

                nmimportacion.Clear()
                delimTxt.Clear()

                cmpImpIni0.Clear()
                cmpImpIni1.Clear()
                cmpImpIni2.Clear()
                cmpImpIni3.Clear()
                cmpImpIni4.Clear()
                cmpImpIni5.Clear()
                cmpImpIni6.Clear()
                cmpImpIni7.Clear()
                cmpImpIni8.Clear()
                cmpImpIni9.Clear()
                cmpImpIni10.Clear()
                cmpImpIni11.Clear()
                cmpImpIni12.Clear()
                cmpImpIni13.Clear()
                cmpImpIni14.Clear()
                cmpImpIni15.Clear()
                cmpImpIni16.Clear()

                cmpLng0.Clear()
                cmpLng1.Clear()
                cmpLng2.Clear()
                cmpLng3.Clear()
                cmpLng4.Clear()
                cmpLng5.Clear()
                cmpLng6.Clear()
                cmpLng7.Clear()
                cmpLng8.Clear()
                cmpLng9.Clear()
                cmpLng10.Clear()
                cmpLng11.Clear()
                cmpLng12.Clear()
                cmpLng13.Clear()
                cmpLng14.Clear()
                cmpLng15.Clear()
                cmpLng16.Clear()


                cmpPos0.Clear()
                cmpPos1.Clear()
                cmpPos2.Clear()
                cmpPos3.Clear()
                cmpPos4.Clear()
                cmpPos5.Clear()
                cmpPos6.Clear()
                cmpPos7.Clear()
                cmpPos8.Clear()
                cmpPos9.Clear()
                cmpPos10.Clear()
                cmpPos11.Clear()
                cmpPos12.Clear()



            End If

        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim vcfgimp As frmAddNewImportacion
        vcfgimp = New frmAddNewImportacion(Me)



        If vcfgimp.ShowDialog(Me) = DialogResult.OK Then


            Button1.Enabled = True
            Button4.Enabled = False


            rb1.Enabled = True
            rb2.Enabled = True

            cmpImpIni0.Enabled = True
            cmpImpIni1.Enabled = True
            cmpImpIni2.Enabled = True
            cmpImpIni3.Enabled = True
            cmpImpIni4.Enabled = True
            cmpImpIni5.Enabled = True
            cmpImpIni6.Enabled = True
            cmpImpIni7.Enabled = True
            cmpImpIni8.Enabled = True
            cmpImpIni9.Enabled = True
            cmpImpIni10.Enabled = True
            cmpImpIni11.Enabled = True
            cmpImpIni12.Enabled = True
            cmpImpIni13.Enabled = True
            cmpImpIni14.Enabled = True
            cmpImpIni15.Enabled = True
            cmpImpIni16.Enabled = True


            cmpLng0.Enabled = True
            cmpLng1.Enabled = True
            cmpLng2.Enabled = True
            cmpLng3.Enabled = True
            cmpLng4.Enabled = True
            cmpLng5.Enabled = True
            cmpLng6.Enabled = True
            cmpLng7.Enabled = True
            cmpLng8.Enabled = True
            cmpLng9.Enabled = True
            cmpLng10.Enabled = True
            cmpLng11.Enabled = True
            cmpLng12.Enabled = True
            cmpLng13.Enabled = True
            cmpLng14.Enabled = True
            cmpLng15.Enabled = True
            cmpLng16.Enabled = True

            chkImportF0.Enabled = True
            chkImportF1.Enabled = True
            chkImportF2.Enabled = True
            chkImportF3.Enabled = True
            chkImportF4.Enabled = True
            chkImportF5.Enabled = True
            chkImportF6.Enabled = True
            chkImportF7.Enabled = True
            chkImportF8.Enabled = True
            chkImportF9.Enabled = True
            chkImportF10.Enabled = True
            chkImportF11.Enabled = True
            chkImportF12.Enabled = True
            chkImportF13.Enabled = True
            chkImportF14.Enabled = True
            chkImportF15.Enabled = True
            chkImportF16.Enabled = True

            cmpPos0.Enabled = True
            cmpPos1.Enabled = True
            cmpPos2.Enabled = True
            cmpPos3.Enabled = True
            cmpPos4.Enabled = True
            cmpPos5.Enabled = True
            cmpPos6.Enabled = True
            cmpPos7.Enabled = True
            cmpPos8.Enabled = True
            cmpPos9.Enabled = True
            cmpPos10.Enabled = True
            cmpPos11.Enabled = True
            cmpPos12.Enabled = True

            chkImportD0.Enabled = True
            chkImportD1.Enabled = True
            chkImportD2.Enabled = True
            chkImportD3.Enabled = True
            chkImportD4.Enabled = True
            chkImportD5.Enabled = True
            chkImportD6.Enabled = True
            chkImportD7.Enabled = True
            chkImportD8.Enabled = True
            chkImportD9.Enabled = True
            chkImportD10.Enabled = True
            chkImportD11.Enabled = True
            chkImportD12.Enabled = True


            If rb1.Checked Then

                Label4.Visible = True
                Label22.Visible = True
                Label24.Visible = False

                Label5.Visible = True
                Label6.Visible = True
                Label7.Visible = True
                Label8.Visible = True
                Label9.Visible = True
                Label10.Visible = True
                Label11.Visible = True
                Label12.Visible = True
                Label13.Visible = True
                Label14.Visible = True
                Label15.Visible = True
                Label16.Visible = True
                Label17.Visible = True
                Label18.Visible = True
                Label19.Visible = True
                Label20.Visible = True
                Label21.Visible = True

                cmpImpIni0.Visible = True
                cmpImpIni1.Visible = True
                cmpImpIni2.Visible = True
                cmpImpIni3.Visible = True
                cmpImpIni4.Visible = True
                cmpImpIni5.Visible = True
                cmpImpIni6.Visible = True
                cmpImpIni7.Visible = True
                cmpImpIni8.Visible = True
                cmpImpIni9.Visible = True
                cmpImpIni10.Visible = True
                cmpImpIni11.Visible = True
                cmpImpIni12.Visible = True
                cmpImpIni13.Visible = True
                cmpImpIni14.Visible = True
                cmpImpIni15.Visible = True
                cmpImpIni16.Visible = True



                cmpLng0.Visible = True
                cmpLng1.Visible = True
                cmpLng2.Visible = True
                cmpLng3.Visible = True
                cmpLng4.Visible = True
                cmpLng5.Visible = True
                cmpLng6.Visible = True
                cmpLng7.Visible = True
                cmpLng8.Visible = True
                cmpLng9.Visible = True
                cmpLng10.Visible = True
                cmpLng11.Visible = True
                cmpLng12.Visible = True
                cmpLng13.Visible = True
                cmpLng14.Visible = True
                cmpLng15.Visible = True
                cmpLng16.Visible = True




                cmpPos0.Visible = False
                cmpPos1.Visible = False
                cmpPos2.Visible = False
                cmpPos3.Visible = False
                cmpPos4.Visible = False
                cmpPos5.Visible = False
                cmpPos6.Visible = False
                cmpPos7.Visible = False
                cmpPos8.Visible = False
                cmpPos9.Visible = False
                cmpPos10.Visible = False
                cmpPos11.Visible = False
                cmpPos12.Visible = False


            ElseIf rb2.Checked Then

                Label4.Visible = False
                Label22.Visible = False
                Label24.Visible = True

                Label25.Visible = True
                Label26.Visible = True
                Label27.Visible = True
                Label28.Visible = True
                Label29.Visible = True
                Label30.Visible = True
                Label31.Visible = True
                Label32.Visible = True
                Label33.Visible = True
                Label34.Visible = True
                Label35.Visible = True
                Label36.Visible = True
                Label37.Visible = True


                cmpPos0.Visible = True
                cmpPos1.Visible = True
                cmpPos2.Visible = True
                cmpPos3.Visible = True
                cmpPos4.Visible = True
                cmpPos5.Visible = True
                cmpPos6.Visible = True
                cmpPos7.Visible = True
                cmpPos8.Visible = True
                cmpPos9.Visible = True
                cmpPos10.Visible = True
                cmpPos11.Visible = True
                cmpPos12.Visible = True


                arbolImportaciones.Enabled = False
                Button5.Enabled = False


            End If

        Else
            MsgBox("Debe introducir un nombre para la importación")
        End If
    End Sub

   

    Private Sub cmpImpIni_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmpImpIni0.KeyPress, cmpImpIni1.KeyPress, cmpImpIni2.KeyPress, cmpImpIni3.KeyPress, cmpImpIni4.KeyPress, cmpImpIni5.KeyPress, cmpImpIni6.KeyPress, cmpImpIni7.KeyPress, cmpImpIni8.KeyPress, cmpImpIni9.KeyPress, cmpImpIni10.KeyPress, cmpImpIni11.KeyPress, cmpImpIni12.KeyPress, cmpImpIni13.KeyPress, cmpImpIni14.KeyPress, cmpImpIni15.KeyPress, cmpImpIni16.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub cmpLng_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmpLng0.KeyPress, cmpLng1.KeyPress, cmpLng2.KeyPress, cmpLng3.KeyPress, cmpLng4.KeyPress, cmpLng5.KeyPress, cmpLng6.KeyPress, cmpLng7.KeyPress, cmpLng8.KeyPress, cmpLng9.KeyPress, cmpLng10.KeyPress, cmpLng11.KeyPress, cmpLng12.KeyPress, cmpLng13.KeyPress, cmpLng14.KeyPress, cmpLng15.KeyPress, cmpLng16.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    
    Private Sub cmpPos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmpPos0.KeyPress, cmpPos1.KeyPress, cmpPos2.KeyPress, cmpPos3.KeyPress, cmpPos4.KeyPress, cmpPos5.KeyPress, cmpPos6.KeyPress, cmpPos7.KeyPress, cmpPos8.KeyPress, cmpPos9.KeyPress, cmpPos10.KeyPress, cmpPos11.KeyPress, cmpPos12.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        inicia_componentes()
    End Sub

   
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim path As String
        Dim archivoFijo As System.IO.StreamReader
        Dim archivoDelim As Microsoft.VisualBasic.FileIO.TextFieldParser
        Dim camposImpFijo As New cimpfijo()
        Dim longitudes As ArrayList

        dialogoAbrir.FileName = ""
        dialogoAbrir.Filter = "Todos los archivos (*.*)|*.*"

        If dialogoAbrir.ShowDialog() = Windows.Forms.DialogResult.OK Then
            path = dialogoAbrir.FileName
            nmarchivotxt.Text = path

            With tablatickets
                .Columns.Clear()
                .RowHeadersVisible = False

                If rb1.Checked Then
                    .Columns.Add("0", "Ticket")
                    .Columns.Add("1", "Cosechero")
                    .Columns.Add("2", "Día")
                    .Columns.Add("3", "Mes")
                    .Columns.Add("4", "Año")
                    .Columns.Add("5", "Hora")
                    .Columns.Add("6", "Minuto")
                    .Columns.Add("7", "Segundo")
                    .Columns.Add("8", "Kilos")
                    .Columns.Add("9", "Matrícula")
                    .Columns.Add("10", "Calidad")
                    .Columns.Add("11", "Variedad")
                    .Columns.Add("12", "Termino")
                    .Columns.Add("13", "Báscula")
                    .Columns.Add("14", "Tolva")
                    .Columns.Add("15", "Polígono")
                    .Columns.Add("16", "Parcela")
                    .AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)



                    If chkImportF0.Checked Then
                        If cmpImpIni0.Text.Length > 0 And cmpLng0.Text.Length > 0 Then

                            camposImpFijo.Ticket.Importar = True
                            camposImpFijo.Ticket.Inicio = cmpImpIni0.Text
                            camposImpFijo.Ticket.Longitud = cmpLng0.Text

                        End If
                    End If
                    If chkImportF1.Checked Then
                        If cmpImpIni1.Text.Length > 0 And cmpLng1.Text.Length > 0 Then

                            camposImpFijo.Cosechero.Importar = True
                            camposImpFijo.Cosechero.Inicio = cmpImpIni1.Text
                            camposImpFijo.Cosechero.Longitud = cmpLng1.Text

                        End If
                    End If
                    If chkImportF2.Checked Then
                        If cmpImpIni2.Text.Length > 0 And cmpLng2.Text.Length > 0 Then
                            camposImpFijo.Dia.Importar = True
                            camposImpFijo.Dia.Inicio = cmpImpIni2.Text
                            camposImpFijo.Dia.Longitud = cmpLng2.Text
                        End If
                    End If
                    If chkImportF3.Checked Then
                        If cmpImpIni3.Text.Length > 0 And cmpLng3.Text.Length > 0 Then
                            camposImpFijo.Mes.Importar = True
                            camposImpFijo.Mes.Inicio = cmpImpIni3.Text
                            camposImpFijo.Mes.Longitud = cmpLng3.Text
                        End If
                    End If
                    If chkImportF4.Checked Then
                        If cmpImpIni4.Text.Length > 0 And cmpLng4.Text.Length > 0 Then
                            camposImpFijo.Anio.Importar = True
                            camposImpFijo.Anio.Inicio = cmpImpIni4.Text
                            camposImpFijo.Anio.Longitud = cmpLng4.Text
                        End If
                    End If
                    If chkImportF5.Checked Then
                        If cmpImpIni5.Text.Length > 0 And cmpLng5.Text.Length > 0 Then
                            camposImpFijo.Hora.Importar = True
                            camposImpFijo.Hora.Inicio = cmpImpIni5.Text
                            camposImpFijo.Hora.Longitud = cmpLng5.Text
                        End If
                    End If
                    If chkImportF6.Checked Then
                        If cmpImpIni6.Text.Length > 0 And cmpLng6.Text.Length > 0 Then
                            camposImpFijo.Minuto.Importar = True
                            camposImpFijo.Minuto.Inicio = cmpImpIni6.Text
                            camposImpFijo.Minuto.Longitud = cmpLng6.Text
                        End If
                    End If
                    If chkImportF7.Checked Then
                        If cmpImpIni7.Text.Length > 0 And cmpLng7.Text.Length > 0 Then
                            camposImpFijo.Segundo.Importar = True
                            camposImpFijo.Segundo.Inicio = cmpImpIni7.Text
                            camposImpFijo.Segundo.Longitud = cmpLng7.Text
                        End If
                    End If
                    If chkImportF8.Checked Then
                        If cmpImpIni8.Text.Length > 0 And cmpLng8.Text.Length > 0 Then
                            camposImpFijo.Kilos.Importar = True
                            camposImpFijo.Kilos.Inicio = cmpImpIni8.Text
                            camposImpFijo.Kilos.Longitud = cmpLng8.Text
                        End If
                    End If
                    If chkImportF9.Checked Then
                        If cmpImpIni9.Text.Length > 0 And cmpLng9.Text.Length > 0 Then
                            camposImpFijo.Matricula.Importar = True
                            camposImpFijo.Matricula.Inicio = cmpImpIni9.Text
                            camposImpFijo.Matricula.Longitud = cmpLng9.Text
                        End If
                    End If
                    If chkImportF10.Checked Then
                        If cmpImpIni10.Text.Length > 0 And cmpLng10.Text.Length > 0 Then
                            camposImpFijo.Calidad.Importar = True
                            camposImpFijo.Calidad.Inicio = cmpImpIni10.Text
                            camposImpFijo.Calidad.Longitud = cmpLng10.Text
                        End If
                    End If
                    If chkImportF11.Checked Then
                        If cmpImpIni11.Text.Length > 0 And cmpLng11.Text.Length > 0 Then
                            camposImpFijo.Variedad.Importar = True
                            camposImpFijo.Variedad.Inicio = cmpImpIni11.Text
                            camposImpFijo.Variedad.Longitud = cmpLng11.Text
                        End If
                    End If
                    If chkImportF12.Checked Then
                        If cmpImpIni12.Text.Length > 0 And cmpLng12.Text.Length > 0 Then
                            camposImpFijo.Termino.Importar = True
                            camposImpFijo.Termino.Inicio = cmpImpIni12.Text
                            camposImpFijo.Termino.Longitud = cmpLng12.Text
                        End If
                    End If
                    If chkImportF13.Checked Then
                        If cmpImpIni13.Text.Length > 0 And cmpLng13.Text.Length > 0 Then
                            camposImpFijo.Bascula.Importar = True
                            camposImpFijo.Bascula.Inicio = cmpImpIni13.Text
                            camposImpFijo.Bascula.Longitud = cmpLng13.Text
                        End If
                    End If
                    If chkImportF14.Checked Then
                        If cmpImpIni14.Text.Length > 0 And cmpLng14.Text.Length > 0 Then
                            camposImpFijo.Tolva.Importar = True
                            camposImpFijo.Tolva.Inicio = cmpImpIni14.Text
                            camposImpFijo.Tolva.Longitud = cmpLng14.Text
                        End If
                    End If
                    If chkImportF15.Checked Then
                        If cmpImpIni15.Text.Length > 0 And cmpLng15.Text.Length > 0 Then
                            camposImpFijo.Poligono.Importar = True
                            camposImpFijo.Poligono.Inicio = cmpImpIni15.Text
                            camposImpFijo.Poligono.Longitud = cmpLng15.Text
                        End If
                    End If
                    If chkImportF16.Checked Then
                        If cmpImpIni16.Text.Length > 0 And cmpLng16.Text.Length > 0 Then
                            camposImpFijo.Parcela.Importar = True
                            camposImpFijo.Parcela.Inicio = cmpImpIni16.Text
                            camposImpFijo.Parcela.Longitud = cmpLng16.Text
                        End If
                    End If

                    If My.Computer.FileSystem.FileExists(path) Then
                        archivoFijo = My.Computer.FileSystem.OpenTextFileReader(path)


                        While Not archivoFijo.EndOfStream
                            Try
                                Dim filaArchivo As String = archivoFijo.ReadLine()
                                Dim filaTabla() As String

                                filaTabla = New String() {"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""}

                                If camposImpFijo.Ticket.Importar Then
                                    filaTabla(0) = filaArchivo.Substring(camposImpFijo.Ticket.Inicio, camposImpFijo.Ticket.Longitud)
                                End If
                                If camposImpFijo.Cosechero.Importar Then
                                    filaTabla(1) = filaArchivo.Substring(camposImpFijo.Cosechero.Inicio, camposImpFijo.Cosechero.Longitud)
                                End If
                                If camposImpFijo.Dia.Importar Then
                                    filaTabla(2) = filaArchivo.Substring(camposImpFijo.Dia.Inicio, camposImpFijo.Dia.Longitud)
                                End If
                                If camposImpFijo.Mes.Importar Then
                                    filaTabla(3) = filaArchivo.Substring(camposImpFijo.Mes.Inicio, camposImpFijo.Mes.Longitud)
                                End If
                                If camposImpFijo.Anio.Importar Then
                                    filaTabla(4) = filaArchivo.Substring(camposImpFijo.Anio.Inicio, camposImpFijo.Anio.Longitud)
                                End If
                                If camposImpFijo.Hora.Importar Then
                                    filaTabla(5) = filaArchivo.Substring(camposImpFijo.Hora.Inicio, camposImpFijo.Hora.Longitud)
                                End If
                                If camposImpFijo.Minuto.Importar Then
                                    filaTabla(6) = filaArchivo.Substring(camposImpFijo.Minuto.Inicio, camposImpFijo.Minuto.Longitud)
                                End If
                                If camposImpFijo.Segundo.Importar Then
                                    filaTabla(7) = filaArchivo.Substring(camposImpFijo.Segundo.Inicio, camposImpFijo.Segundo.Longitud)
                                End If
                                If camposImpFijo.Kilos.Importar Then
                                    filaTabla(8) = filaArchivo.Substring(camposImpFijo.Kilos.Inicio, camposImpFijo.Kilos.Longitud)
                                End If
                                If camposImpFijo.Matricula.Importar Then
                                    filaTabla(9) = filaArchivo.Substring(camposImpFijo.Matricula.Inicio, camposImpFijo.Matricula.Longitud)
                                End If
                                If camposImpFijo.Calidad.Importar Then
                                    filaTabla(10) = filaArchivo.Substring(camposImpFijo.Calidad.Inicio, camposImpFijo.Calidad.Longitud)
                                End If
                                If camposImpFijo.Variedad.Importar Then
                                    filaTabla(11) = filaArchivo.Substring(camposImpFijo.Variedad.Inicio, camposImpFijo.Variedad.Longitud)
                                End If
                                If camposImpFijo.Termino.Importar Then
                                    filaTabla(12) = filaArchivo.Substring(camposImpFijo.Termino.Inicio, camposImpFijo.Termino.Longitud)
                                End If
                                If camposImpFijo.Bascula.Importar Then
                                    filaTabla(13) = filaArchivo.Substring(camposImpFijo.Bascula.Inicio, camposImpFijo.Bascula.Longitud)
                                End If
                                If camposImpFijo.Tolva.Importar Then
                                    filaTabla(14) = filaArchivo.Substring(camposImpFijo.Tolva.Inicio, camposImpFijo.Tolva.Longitud)
                                End If
                                If camposImpFijo.Poligono.Importar Then
                                    filaTabla(15) = filaArchivo.Substring(camposImpFijo.Poligono.Inicio, camposImpFijo.Poligono.Longitud)
                                End If
                                If camposImpFijo.Parcela.Importar Then
                                    filaTabla(16) = filaArchivo.Substring(camposImpFijo.Parcela.Inicio, camposImpFijo.Parcela.Longitud)
                                End If
                                tablatickets.Rows.Add(filaTabla)
                            Catch ex As Exception

                            End Try
                        End While

                    End If

                ElseIf rb2.Checked Then
                    .Columns.Add("0", "Ticket")
                    .Columns.Add("1", "Cosechero")
                    .Columns.Add("2", "Fecha")
                    .Columns.Add("3", "Hora")
                    .Columns.Add("4", "Kilos")
                    .Columns.Add("5", "Matricula")
                    .Columns.Add("6", "Calidad")
                    .Columns.Add("7", "Variedad")
                    .Columns.Add("8", "Término")
                    .Columns.Add("9", "Báscula")
                    .Columns.Add("10", "Tolva")
                    .Columns.Add("11", "Polígono")
                    .Columns.Add("12", "Parcela")
                    .AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

                End If
            End With
        End If
    End Sub

    Friend Class cimpfijo
        Private _Ticket As campoimpfijo
        Private _Cosechero As campoimpfijo
        Private _Dia As campoimpfijo
        Private _Mes As campoimpfijo
        Private _Anio As campoimpfijo
        Private _Hora As campoimpfijo
        Private _Minuto As campoimpfijo
        Private _Segundo As campoimpfijo
        Private _Kilos As campoimpfijo
        Private _Matricula As campoimpfijo
        Private _Calidad As campoimpfijo
        Private _Variedad As campoimpfijo
        Private _Termino As campoimpfijo
        Private _Bascula As campoimpfijo
        Private _Tolva As campoimpfijo
        Private _Poligono As campoimpfijo
        Private _Parcela As campoimpfijo


        Public Property Ticket As campoimpfijo
            Get
                Return _Ticket
            End Get
            Set(value As campoimpfijo)
                _Ticket = value
            End Set
        End Property

        Public Property Cosechero As campoimpfijo
            Get
                Return _Cosechero
            End Get
            Set(value As campoimpfijo)
                _Cosechero = value
            End Set
        End Property
        Public Property Dia As campoimpfijo
            Get
                Return _Dia
            End Get
            Set(value As campoimpfijo)
                _Dia = value
            End Set
        End Property
        Public Property Mes As campoimpfijo
            Get
                Return _Mes
            End Get
            Set(value As campoimpfijo)
                _Mes = value
            End Set
        End Property
        Public Property Anio As campoimpfijo
            Get
                Return _Anio
            End Get
            Set(value As campoimpfijo)

            End Set
        End Property
        Public Property Hora As campoimpfijo
            Get
                Return _Hora
            End Get
            Set(value As campoimpfijo)
                _Hora = value
            End Set
        End Property
        Public Property Minuto As campoimpfijo
            Get
                Return _Minuto
            End Get
            Set(value As campoimpfijo)
                _Minuto = value
            End Set
        End Property
        Public Property Segundo As campoimpfijo
            Get
                Return _Segundo
            End Get
            Set(value As campoimpfijo)
                _Segundo = value
            End Set
        End Property
        Public Property Kilos As campoimpfijo
            Get
                Return _Kilos
            End Get
            Set(value As campoimpfijo)
                _Kilos = value
            End Set
        End Property
        Public Property Matricula As campoimpfijo
            Get
                Return _Matricula
            End Get
            Set(value As campoimpfijo)
                _Matricula = value
            End Set
        End Property
        Public Property Calidad As campoimpfijo
            Get
                Return _Calidad
            End Get
            Set(value As campoimpfijo)
                _Calidad = value
            End Set
        End Property
        Public Property Variedad As campoimpfijo
            Get
                Return _Variedad
            End Get
            Set(value As campoimpfijo)
                _Variedad = value
            End Set
        End Property
        Public Property Termino As campoimpfijo
            Get
                Return _Termino
            End Get
            Set(value As campoimpfijo)
                _Termino = value
            End Set
        End Property
        Public Property Bascula As campoimpfijo
            Get
                Return _Bascula
            End Get
            Set(value As campoimpfijo)
                _Bascula = value
            End Set
        End Property
        Public Property Tolva As campoimpfijo
            Get
                Return _Tolva
            End Get
            Set(value As campoimpfijo)
                _Tolva = value
            End Set
        End Property
        Public Property Poligono As campoimpfijo
            Get
                Return _Poligono
            End Get
            Set(value As campoimpfijo)
                _Poligono = value
            End Set
        End Property
        Public Property Parcela As campoimpfijo
            Get
                Return _Parcela
            End Get
            Set(value As campoimpfijo)
                _Parcela = value
            End Set
        End Property


        Public Sub New()
            _Ticket = New campoimpfijo()
            _Cosechero = New campoimpfijo()
            _Dia = New campoimpfijo()
            _Mes = New campoimpfijo()
            _Anio = New campoimpfijo()
            _Hora = New campoimpfijo()
            _Minuto = New campoimpfijo()
            _Segundo = New campoimpfijo()
            _Kilos = New campoimpfijo()
            _Matricula = New campoimpfijo()
            _Calidad = New campoimpfijo()
            _Variedad = New campoimpfijo()
            _Termino = New campoimpfijo()
            _Bascula = New campoimpfijo()
            _Tolva = New campoimpfijo()
            _Poligono = New campoimpfijo()
            _Parcela = New campoimpfijo()

        End Sub
    End Class
    Friend Class campoimpfijo
        Private _importar As Boolean
        Private _inicio As Integer
        Private _longitud As Integer
        Public Property Importar As Boolean
            Get
                Return _importar
            End Get
            Set(value As Boolean)
                _importar = value
            End Set
        End Property
        Public Property Inicio As Integer
            Get
                Return _inicio
            End Get
            Set(value As Integer)
                _inicio = value
            End Set
        End Property
        Public Property Longitud As Integer
            Get
                Return _longitud
            End Get
            Set(value As Integer)
                _longitud = value
            End Set
        End Property
        Public Sub New()
            Me._importar = False
            Me._inicio = 0
            Me._longitud = 0
        End Sub
    End Class
End Class