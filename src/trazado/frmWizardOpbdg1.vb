Public Class frmWizardOpbdg1
  

    Private ordenDB As orden_depositosDataTableAdapter

    Private Sub frmWizardOpbdg1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ordenDB = New orden_depositosDataTableAdapter(Almazara.Id)
        ordenDB.Fill(OleosigDB1.orden_depositos)

    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

   
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim vwizard2 As frmWizardOpbdg2


        Me.OrdeBindingSource.EndEdit()

        Me.ordenDB.Update(OleosigDB1.orden_depositos)

        
        If OleosigDB1.orden_depositos.Rows.Count > 0 Then
            vwizard2 = New frmWizardOpbdg2()
            vwizard2.MdiParent = Me.MdiParent
            vwizard2.Show()
            Me.Close()
        Else
            MsgBox("Debe añadir al menos un depósito a la tabla")
        End If

    End Sub

    Private Sub validar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim celda As DataGridViewCell
        celda = tablaDatos.CurrentCell
        If Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub tablaDatos_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles tablaDatos.EditingControlShowing

        AddHandler e.Control.KeyPress, AddressOf validar

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim fila As DataRowView = CType(OrdeBindingSource.AddNew(), DataRowView)
        fila("idalmazara") = Almazara.Id

    End Sub
End Class