Public Class frmAddEnvasado


    Dim oPartidas As partAceiteTableAdapter
    Dim oEnvasado As envasadoTableAdapter
    Dim editando As Boolean = False
    Dim vCarga As frmslider
    Dim marcasDB As marcasTableAdapter

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' vCarga = New frmslider
        ' vCarga.mensaje = "Cargando datos"
        ' vCarga.ShowDialog(Me)

        ' Add any initialization after the InitializeComponent() call.
        oEnvasado = New envasadoTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        oPartidas = New partAceiteTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)
        marcasDB = New marcasTableAdapter(Almazara.Id)


    End Sub

   
    Private Sub desactiva_controles()
        cmbMarcas.Enabled = False
        codigoenvasadotxt.Enabled = False
        cmbEnvases.Enabled = False
        partidatxt.Enabled = False
        dtFecha.Enabled = False
        numenvasestxt.Enabled = False
        litrostxt.Enabled = False

    End Sub
    Private Sub activa_controles()
        cmbMarcas.Enabled = True
        codigoenvasadotxt.Enabled = True
        cmbEnvases.Enabled = True
        partidatxt.Enabled = True
        dtFecha.Enabled = True
        numenvasestxt.Enabled = True
        litrostxt.Enabled = True
    End Sub

    Private Sub limpia_controles()

        codigoenvasadotxt.Clear()

        partidatxt.Clear()
        dtFecha.Value = Now
        numenvasestxt.Clear()
        litrostxt.Clear()

    End Sub
    Private Sub nuevo()

        Me.activa_controles()
        tablaEnvasado.Enabled = False
        btnGuardar.Enabled = True
        editando = False

        Dim fila As oleosigDB.envasadoRow = CType(EnvasadoBDS.AddNew(), DataRowView).Row
        fila.Idalmazara = Almazara.Id

    End Sub
    
    Private Sub editar()
        ToolStrip1.Items(5).Enabled = True
        ToolStrip1.Items(6).Enabled = True
        activa_controles()
        editando = True
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.nuevo()
    End Sub

    Private Sub frmAddEnvasado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        oEnvasado.Fill(OleosigDB1.envasado)
        marcasDB.Fill(OleosigDB1.marcas)
        oPartidas.Fill(OleosigDB1.partidasaceite)

        codigoenvasadotxt.DataBindings.Add("Text", EnvasadoBDS, "cod_trazabilidad", True, DataSourceUpdateMode.OnPropertyChanged)
        partidatxt.DataBindings.Add("Text", EnvasadoBDS, "partida", True, DataSourceUpdateMode.OnPropertyChanged)
        litrostxt.DataBindings.Add("Text", EnvasadoBDS, "litros", True, DataSourceUpdateMode.OnPropertyChanged)
        numenvasestxt.DataBindings.Add("Text", EnvasadoBDS, "n_envases", True, DataSourceUpdateMode.OnPropertyChanged)
        dtFecha.DataBindings.Add("Value", EnvasadoBDS, "fecha_env", True, DataSourceUpdateMode.OnPropertyChanged)


        tablaPartidas.AutoGenerateColumns = False
        Me.tablaPartidas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)


        inicia_componentes()


    End Sub
    Private Sub inicia_componentes()
        editando = False

        Me.ToolStrip1.Items(0).Enabled = True
        Me.ToolStrip1.Items(1).Enabled = False
        Me.ToolStrip1.Items(5).Enabled = False
        Me.ToolStrip1.Items(6).Enabled = False

        tablaEnvasado.Enabled = True



        desactiva_controles()


    End Sub



    Private Sub tablaEnvasado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tablaEnvasado.Click


        ToolStrip1.Items(0).Enabled = False
        ToolStrip1.Items(1).Enabled = True



    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        EnvasadoBDS.CancelEdit()
        inicia_componentes()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
       
        If MsgBox("¿ Desea guardar las modificaciones ?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Me.ValidateChildren()

            EnvasadoBDS.EndEdit()

            Me.oEnvasado.Update(OleosigDB1.envasado)
        End If
    End Sub

    Private Sub tablaPartidas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tablaPartidas.DoubleClick
        If tablaPartidas.Rows.Count > 0 Then
            Me.partidatxt.Text = tablaPartidas.Rows(tablaPartidas.CurrentCell.RowIndex).Cells(0).Value
        End If

    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        editar()

    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click

        If MsgBox("¿ Desea borrar el envasado ?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then

            EnvasadoBDS.RemoveCurrent()
            EnvasadoBDS.EndEdit()
            oEnvasado.Update(OleosigDB1.envasado)
            EnvasadoBDS.ResetBindings(False)

            inicia_componentes()
        End If

    End Sub

    Private Sub numenvasestxt_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles numenvasestxt.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub litrostxt_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles litrostxt.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class