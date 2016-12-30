Option Strict Off
Option Explicit On
Friend Class frmCampagnas
    Inherits System.Windows.Forms.Form

    Private ocampañas As CampagnaDB

    Private Sub cmdAñadir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAñadir.Click
        If campañatxt.Text.Length = 0 Then
            MsgBox("Debe introducir una campaña", MsgBoxStyle.Exclamation)
        Else
            If MsgBox("¿ Desea añadir la nueva campaña ?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Validate()

                ' Almazara.NuevaCampaña(campañatxt.Text, idtxt.Text)
                campañasBDS.EndEdit()
                ocampañas.Update(OleosigDB1.campagnas)
                campañasBDS.ResetBindings(False)



            Else
                campañasBDS.CancelEdit()

            End If
            cmdNueva.Enabled = True
            cmdAñadir.Enabled = False
            frmSelect.Enabled = True
            cmdBorrar.Enabled = True

        End If
    End Sub

    Private Sub cmdBorrar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBorrar.Click
        If campañasBDS.Current IsNot Nothing Then

            If MsgBox("¿ Desea borrar la campaña ?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim campaña As oleosigDB.campagnasRow

                'borramos la campaña
                campaña = CType(campañasBDS.Current, DataRowView).Row
                If campaña.clave = Almazara.CampañaAct.clave And campaña.nombre = Almazara.CampañaAct.nombre Then
                    MsgBox("No puede borrar la campaña actual", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                campañasBDS.RemoveCurrent()
                ocampañas.Update(OleosigDB1.campagnas)
                campañasBDS.ResetBindings(False)

                MsgBox("Se ha borrado la campaña con exito")



            End If
        End If
    End Sub



    Private Sub cmdNueva_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNueva.Click
        Dim ultima As Long
        Dim campLocal As oleosigDB.campagnasRow = CType(campañasBDS.AddNew(), DataRowView).Row


        campLocal.activa = False
        campLocal.idalmazara = Almazara.Id
        ultima = ocampañas.GetLast
        idtxt.Text = ultima + 1
        'campLocal.clave = ultima + 1

        campañatxt.Focus()
        cmdNueva.Enabled = False
        cmdAñadir.Enabled = True
        frmSelect.Enabled = False
        cmdBorrar.Enabled = False

    End Sub

    Private Sub frmCampañas_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        ocampañas = New CampagnaDB(Almazara.Id)

        ocampañas.Fill(OleosigDB1.campagnas)


        Me.listaCampañas.DataSource = campañasBDS
        Me.listaCampañas.DisplayMember = "nombre"
        Me.listaCampañas.ValueMember = "clave"

        Me.listaCampañas.SelectedValue = Almazara.CampañaAct.clave
        Me.campActtxt.Text = Almazara.CampañaAct.nombre

        Me.campañatxt.DataBindings.Add(New Binding("Text", campañasBDS, "nombre", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.idtxt.DataBindings.Add(New Binding("Text", campañasBDS, "clave", True, DataSourceUpdateMode.OnPropertyChanged))

        cmdAñadir.Enabled = False
        If campañasBDS.List.Count = 0 Then
            cmdBorrar.Enabled = False

        End If
    End Sub

    Private Sub frmsalir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles frmsalir.Click

        Me.Close()

        MainModule.inicia()

    End Sub

    Private Sub frmSelect_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles frmSelect.Click

        Dim result As MsgBoxResult

        If listaCampañas.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una campaña")
        Else
            If MsgBox("¿ Desea cambiar la campaña actual ?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim entidad As oleosigDB.campagnasRow = CType(campañasBDS.Current, DataRowView).Row 'Almazara.Campañas.Find(Function(ent As eCampaña) (ent.Nombre = listaCampañas.SelectedItem))
                Almazara.SelectCampaña(entidad)
                campActtxt.Text = entidad.Nombre

                result = MsgBox("La campaña actual ha cambiado")
            End If
        End If


    End Sub



    Private Sub cmdCancelar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancelar.Click
        campañasBDS.CancelEdit()
        cmdNueva.Enabled = True
        cmdAñadir.Enabled = False
        frmSelect.Enabled = True
        cmdBorrar.Enabled = True
    End Sub
End Class