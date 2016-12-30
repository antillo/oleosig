Option Strict Off
Option Explicit On
Friend Class frmCampagnas
    Inherits System.Windows.Forms.Form

    Private ocampa�as As CampagnaDB

    Private Sub cmdA�adir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdA�adir.Click
        If campa�atxt.Text.Length = 0 Then
            MsgBox("Debe introducir una campa�a", MsgBoxStyle.Exclamation)
        Else
            If MsgBox("� Desea a�adir la nueva campa�a ?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Validate()

                ' Almazara.NuevaCampa�a(campa�atxt.Text, idtxt.Text)
                campa�asBDS.EndEdit()
                ocampa�as.Update(OleosigDB1.campagnas)
                campa�asBDS.ResetBindings(False)



            Else
                campa�asBDS.CancelEdit()

            End If
            cmdNueva.Enabled = True
            cmdA�adir.Enabled = False
            frmSelect.Enabled = True
            cmdBorrar.Enabled = True

        End If
    End Sub

    Private Sub cmdBorrar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBorrar.Click
        If campa�asBDS.Current IsNot Nothing Then

            If MsgBox("� Desea borrar la campa�a ?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim campa�a As oleosigDB.campagnasRow

                'borramos la campa�a
                campa�a = CType(campa�asBDS.Current, DataRowView).Row
                If campa�a.clave = Almazara.Campa�aAct.clave And campa�a.nombre = Almazara.Campa�aAct.nombre Then
                    MsgBox("No puede borrar la campa�a actual", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                campa�asBDS.RemoveCurrent()
                ocampa�as.Update(OleosigDB1.campagnas)
                campa�asBDS.ResetBindings(False)

                MsgBox("Se ha borrado la campa�a con exito")



            End If
        End If
    End Sub



    Private Sub cmdNueva_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNueva.Click
        Dim ultima As Long
        Dim campLocal As oleosigDB.campagnasRow = CType(campa�asBDS.AddNew(), DataRowView).Row


        campLocal.activa = False
        campLocal.idalmazara = Almazara.Id
        ultima = ocampa�as.GetLast
        idtxt.Text = ultima + 1
        'campLocal.clave = ultima + 1

        campa�atxt.Focus()
        cmdNueva.Enabled = False
        cmdA�adir.Enabled = True
        frmSelect.Enabled = False
        cmdBorrar.Enabled = False

    End Sub

    Private Sub frmCampa�as_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        ocampa�as = New CampagnaDB(Almazara.Id)

        ocampa�as.Fill(OleosigDB1.campagnas)


        Me.listaCampa�as.DataSource = campa�asBDS
        Me.listaCampa�as.DisplayMember = "nombre"
        Me.listaCampa�as.ValueMember = "clave"

        Me.listaCampa�as.SelectedValue = Almazara.Campa�aAct.clave
        Me.campActtxt.Text = Almazara.Campa�aAct.nombre

        Me.campa�atxt.DataBindings.Add(New Binding("Text", campa�asBDS, "nombre", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.idtxt.DataBindings.Add(New Binding("Text", campa�asBDS, "clave", True, DataSourceUpdateMode.OnPropertyChanged))

        cmdA�adir.Enabled = False
        If campa�asBDS.List.Count = 0 Then
            cmdBorrar.Enabled = False

        End If
    End Sub

    Private Sub frmsalir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles frmsalir.Click

        Me.Close()

        MainModule.inicia()

    End Sub

    Private Sub frmSelect_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles frmSelect.Click

        Dim result As MsgBoxResult

        If listaCampa�as.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una campa�a")
        Else
            If MsgBox("� Desea cambiar la campa�a actual ?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim entidad As oleosigDB.campagnasRow = CType(campa�asBDS.Current, DataRowView).Row 'Almazara.Campa�as.Find(Function(ent As eCampa�a) (ent.Nombre = listaCampa�as.SelectedItem))
                Almazara.SelectCampa�a(entidad)
                campActtxt.Text = entidad.Nombre

                result = MsgBox("La campa�a actual ha cambiado")
            End If
        End If


    End Sub



    Private Sub cmdCancelar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancelar.Click
        campa�asBDS.CancelEdit()
        cmdNueva.Enabled = True
        cmdA�adir.Enabled = False
        frmSelect.Enabled = True
        cmdBorrar.Enabled = True
    End Sub
End Class