Option Strict Off
Option Explicit On


Friend Class frmAdvehiculo
    Inherits System.Windows.Forms.Form


    Dim oVehiculo As vehiculosTableAdapter

    Private editando As Boolean = False



    Private Sub frmAdvehiculo_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load


        Me.Top = (frminicial.ClientRectangle.Height - Me.Height) / 2
        Me.Left = (frminicial.ClientRectangle.Width - Me.Width) / 2
        oVehiculo = New vehiculosTableAdapter(Almazara.Id)
        VehiculosBDS.DataSource = oVehiculo.Vehiculos

        tabladatos.AutoGenerateColumns = False
        tabladatos.Columns.Clear()


        tabladatos.Columns.Add("col1", "Matricula")
        tabladatos.Columns(0).DataPropertyName = "Matricula"


        tabladatos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

        tabladatos.DataSource = VehiculosBDS


        matriculatxt.DataBindings.Add("Text", VehiculosBDS, "matricula", True, DataSourceUpdateMode.OnPropertyChanged)



        inicia_componentes()


    End Sub

    Private Sub inicia_componentes()

        editando = False

        matriculatxt.Enabled = False


        Toolbar1.Items(0).Enabled = True
        Toolbar1.Items(1).Enabled = False
        Toolbar1.Items(4).Enabled = False
        Toolbar1.Items(6).Enabled = False


    End Sub

    Private Sub Guardar()

        If Len(matriculatxt.Text) > 0 Then

            If MsgBox("¿ Desea guardar el vehiculo ?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then

                VehiculosBDS.EndEdit()

                oVehiculo.Guardar()

            End If

        End If
        inicia_componentes()
    End Sub

    Private Sub borrar()

        If MsgBox("¿ Desea borrar el vehículo ?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.VehiculosBDS.RemoveCurrent()

            oVehiculo.Guardar()

            inicia_componentes()
        End If

    End Sub



    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click


        matriculatxt.Enabled = True
        Toolbar1.Items(1).Enabled = False
        Toolbar1.Items(4).Enabled = True
        Toolbar1.Items(6).Enabled = True
        Dim fila As DataRow = CType(Me.VehiculosBDS.AddNew, DataRowView).Row
        fila("idalmazara") = Almazara.Id

        editando = False
    End Sub

    Private Sub tabladatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabladatos.Click
        If tabladatos.CurrentRow IsNot Nothing Then
            

            Toolbar1.Items(1).Enabled = True
        End If


    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click

        Toolbar1.Items(4).Enabled = True
        Toolbar1.Items(6).Enabled = True
        matriculatxt.Enabled = True
        editando = True
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        borrar()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Guardar()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        inicia_componentes()
    End Sub

   
End Class