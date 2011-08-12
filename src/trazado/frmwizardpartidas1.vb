Public Class frmwizardpartidas1
    Private opartidas As parAceitunaTableAdapter

    Private Sub frmwizardpartidas1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opartidas = New parAceitunaTableAdapter(Almazara.CampañaAct.Clave, Almazara.Id)

        chktolvas.DataSource = tolvasBDS
        chktolvas.DisplayMember = "Nombre"
        chktolvas.ValueMember = "Numero"


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        If MsgBox("Está a punto de realizar una actualización" & vbCr _
                                   & "de las partidas de aceituna de forma automatica," & vbCr _
                                   & "Desea continuar", MsgBoxStyle.YesNo Or MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            If chkborrarpartidas.Checked Then
                opartidas.BorrarTodas()
            End If

            If chktolvas.Items.Count <> 0 Then
                For i As Integer = 0 To chktolvas.CheckedItems.Count - 1
                    Dim contador As Integer = i
                    'Dim tolva As DataRow = Almazara.Tolvas.AsEnumerable.First(Function(tol As DataRow) tol("nombre") = chktolvas.CheckedItems(contador).ToString)
                    Dim tolva As DataRow = CType(chktolvas.CheckedItems(contador), DataRowView).Row
                    'opartidas.BorrarTodas(tolva.Numero)
                    'If chkVar.Checked Then
                    opartidas.ActualizaPorDiasVariedad(tolva("numero"))
                    ' Else
                    ' opartidas.ActualizaPorDias(tolva("numero"))
                    ' End If
                Next

                MsgBox("Se ha finalizado la creación de partidas", MsgBoxStyle.Information)
                Me.Close()

            End If



        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class