Option Strict Off
Option Explicit On
Friend Class frmConfig
    Inherits System.Windows.Forms.Form


    Dim idcampo As Short
    Dim oUsuarios As usuariosTableAdapter
    Private varDB As variedadesTableAdapter
    Private calDB As recoleccionTableAdapter
    Private marcasDB As marcasTableAdapter
    Private tanquesDB As depositosTableAdapter
    Private aclaradoresDB As aclaradoresTableAdapter
    Private tolvasDB As tolvasTableAdapter

    Private Sub cmdCerrar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub



    Private Sub frmConfig_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        varDB = New variedadesTableAdapter(Almazara.Id)
        calDB = New recoleccionTableAdapter(Almazara.Id)
        marcasDB = New marcasTableAdapter(Almazara.Id)
        tanquesDB = New depositosTableAdapter(Almazara.Id)
        aclaradoresDB = New aclaradoresTableAdapter(Almazara.Id)
        tolvasDB = New tolvasTableAdapter(Almazara.Id)

        varDB.Fill(OleosigDB1.variedades)
        calDB.Fill(OleosigDB1.recoleccion)
        marcasDB.Fill(OleosigDB1.marcas)
        tanquesDB.Fill(OleosigDB1.tanques)
        aclaradoresDB.Fill(OleosigDB1.aclaradores)
        tolvasDB.Fill(OleosigDB1.tolvas)
        oConfig.FillTipo_pesaje(OleosigDB1.tipo_pesaje)

        MarcasDataGridView.AutoGenerateColumns = False
        VariedadesDataGridView.AutoGenerateColumns = False
        TolvasDataGridView.AutoGenerateColumns = False
        AclaradoresDataGridView.AutoGenerateColumns = False
        TanquesDataGridView.AutoGenerateColumns = False
        CalidadesDataGridView.AutoGenerateColumns = False

        oUsuarios = New usuariosTableAdapter

        Me.AlmazaraBDS.DataSource = Almazara
        Me.AlmazaraBDS.ResetBindings(False)




        CalidadesDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        MarcasDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        VariedadesDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        TolvasDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        AclaradoresDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        TanquesDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)




        'CmbPesaje.Items.Clear()
        'For Each pesaje As Config.eTipoPesaje In oConfig.Pesaje
        ' CmbPesaje.Items.Add(pesaje.Descripcion)
        ' Next
        ' CmbPesaje.Text = "Pesaje"
    End Sub





    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        If MsgBox("¿ Desea guardar los datos ?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Me.AlmazaraBDS.EndEdit()
            Me.TanquesBDS.EndEdit()
            Me.VariedadesBDS.EndEdit()
            Me.AclaradoresBDS.EndEdit()
            Me.CalidadesBDS.EndEdit()
            Me.TolvasBDS.EndEdit()
            Me.MarcasBDS.EndEdit()

            Almazara.Guardar_almazara()

            tanquesDB.Guardar(OleosigDB1.tanques)
            varDB.update(OleosigDB1.variedades)
            aclaradoresDB.Update(OleosigDB1.aclaradores)
            calDB.Update(OleosigDB1.recoleccion)
            tolvasDB.Update(OleosigDB1.tolvas)
            marcasDB.Update(OleosigDB1.marcas)

            Me.Close()

        End If

    End Sub

    Private Sub cpTxt_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cpTxt.Validated

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim entidad As oleosigDB.tanquesRow = CType(Me.TanquesBDS.AddNew(), DataRowView).Row
        entidad.Idalmazara = Almazara.Id

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim entidad As oleosigDB.variedadesRow = CType(Me.VariedadesBDS.AddNew(), DataRowView).Row
        entidad.idalmazara = Almazara.Id

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Not Me.VariedadesBDS.Current Is Nothing Then

            Me.VariedadesBDS.RemoveCurrent()
            Me.VariedadesBDS.ResetBindings(False)


        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim entidad As oleosigDB.tolvasRow = CType(Me.TolvasBDS.AddNew(), DataRowView).Row
        entidad.Idalmazara = Almazara.Id
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Not Me.TolvasBDS.Current Is Nothing Then

            Me.TolvasBDS.RemoveCurrent()


        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim entidad As oleosigDB.aclaradoresRow = CType(Me.AclaradoresBDS.AddNew(), DataRowView).Row
        entidad.Idalmazara = Almazara.Id
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If Not Me.AclaradoresBDS.Current Is Nothing Then
            Me.AclaradoresBDS.RemoveCurrent()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Not Me.TanquesBDS.Current Is Nothing Then

            Me.TanquesBDS.RemoveCurrent()

        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim entidad As oleosigDB.recoleccionRow = CType(Me.CalidadesBDS.AddNew(), DataRowView).Row
        entidad.idalmazara = Almazara.Id
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If Not Me.CalidadesBDS.Current Is Nothing Then

            Me.CalidadesBDS.RemoveCurrent()

        End If
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        Dim fila As oleosigDB.marcasRow = CType(MarcasBDS.AddNew(), DataRowView).Row
        fila.Idalmazara = Almazara.Id

    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        MarcasBDS.RemoveCurrent()

    End Sub
End Class