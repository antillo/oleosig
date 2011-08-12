Option Strict Off
Option Explicit On
Friend Class frmAdorujos
    Inherits System.Windows.Forms.Form
	
    Dim oConductor As conductorTableAdapter
    Dim oVehiculos As vehiculosTableAdapter
    Dim oOrujo As OpOrujoTableAdapter
    Private editando As Boolean
    Private _nuevo As Boolean

    Private Sub brutoTxt_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles brutoTxt.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii < 48 Or KeyAscii > 57 Then
            If KeyAscii <> 8 Then
                If KeyAscii = 13 Then
                    System.Windows.Forms.SendKeys.Send(vbTab)
                End If
                If KeyAscii = 27 Then
                    Call cancelar()
                    GoTo EventExitSub
                End If

                KeyAscii = 0
            End If
        End If

EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub brutoTxt_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles brutoTxt.Validating
        Dim Cancel As Boolean = eventArgs.Cancel
        If Len(brutoTxt.Text) = 0 Then
            brutoTxt.Text = "0"
        End If
        eventArgs.Cancel = Cancel
    End Sub

    Private Sub conductorTxt_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles conductorTxt.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then
            System.Windows.Forms.SendKeys.Send(vbTab)
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub




    Private Sub fechaOrujos_MaskInputRejected(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MaskInputRejectedEventArgs) Handles fechaOrujos.MaskInputRejected

        Dim StartPosition_Renamed As Short = eventArgs.Position

    End Sub

    Private Sub frmAdorujos_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        oConductor = New conductorTableAdapter(Almazara.Id)
        oVehiculos = New vehiculosTableAdapter(Almazara.Id)
        oOrujo = New OpOrujoTableAdapter(Almazara.CampañaAct.Clave, Almazara.Id)
        oOrujo.Fill(OleosigDB1.oporujo)

        VehiculosBDS.DataSource = oVehiculos.Vehiculos
        conductoresBDS.DataSource = oConductor.Conductores

        inicia_Componentes()
    End Sub
    Private Sub inicia_Componentes()
        

        Call rellena_conductores()



        Call deshabilita_controles()

        Call Activa_Validaciones()

        editando = False
        _nuevo = False

        Toolbar1.Items.Item(1).Enabled = False


        Toolbar1.Items.Item(5).Enabled = False

        Toolbar1.Items.Item(7).Enabled = False

    End Sub



    Private Sub ListaConductores_ItemClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim item As ListViewItem = sender.FocusedItem

        idConductorTxt.Text = item.Text

        conductorTxt.Text = item.SubItems.Item(2).Text & " " & item.SubItems.Item(3).Text & ", " & item.SubItems.Item(1).Text

        dniTxt.Text = item.SubItems.Item(4).Text

    End Sub


   

   

    Private Sub netoTxt_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles netoTxt.KeyPress
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

    Private Sub taraTxt_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles taraTxt.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii < 48 Or KeyAscii > 57 Then
            If KeyAscii <> 8 Then
                If KeyAscii = 13 Then
                    System.Windows.Forms.SendKeys.Send(vbTab)
                End If
                If KeyAscii = 27 Then
                    Call cancelar()
                    GoTo EventExitSub
                End If
                KeyAscii = 0
            End If
        End If

EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub taraTxt_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles taraTxt.Validating
        Dim Cancel As Boolean = eventArgs.Cancel
        If Len(taraTxt.Text) = 0 Then
            Cancel = True
        Else
            netoTxt.Text = CStr(CDbl(brutoTxt.Text) - CDbl(taraTxt.Text))
        End If
        eventArgs.Cancel = Cancel
    End Sub


    Private Sub borrar()
        Dim result As MsgBoxResult
        result = MsgBox("Desea borrar la operación de orujo ?", MsgBoxStyle.Critical Or MsgBoxStyle.YesNo)

        If result = MsgBoxResult.Yes Then
            oporujosBDS.RemoveCurrent()
            oporujosBDS.EndEdit()
            Me.oOrujo.Update(OleosigDB1.oporujo)
            inicia_Componentes()
        End If

    End Sub
    Private Sub editar()
        editando = True
        habiliTa_controles()


        Toolbar1.Items.Item(5).Enabled = True

        Toolbar1.Items.Item(7).Enabled = True

    End Sub
    Private Sub guardar()
        Dim entidad As oleosigDB.oporujoRow



        If Not IsDate(fechaOrujos.Text) Then
            MsgBox("Debe rellenar la fecha de salida de orujo", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Len(idConductorTxt.Text) = 0 Then
            MsgBox("Debe rellenar el identificador de conductor", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Len(idVehiculotxt.Text) = 0 Then
            MsgBox("Debe rellenar el identificador de vehiculo", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Len(brutoTxt.Text) = 0 Then
            MsgBox("Debe rellenar el peso bruto del vehiculo", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Len(taraTxt.Text) = 0 Then
            MsgBox("Debe rellenar la tara del vehiculo", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        entidad = CType(oporujosBDS.Current, DataRowView).Row

        entidad.Campagna = Almazara.CampañaAct.clave
        entidad.Fecha = fechaOrujos.Text
        entidad.Idconductor = conductorTxt.Text
        entidad.Idvehiculo = idVehiculotxt.Text
        entidad.PesoBruto = CInt(brutoTxt.Text)
        entidad.Tara = CInt(taraTxt.Text)

        oporujosBDS.EndEdit()

        oOrujo.Update(OleosigDB1.oporujo)

        inicia_Componentes()

    End Sub
    Private Sub nuevo()
        fechaOrujos.Text = Now
        Call habiliTa_controles()

        Toolbar1.Items.Item(7).Enabled = True
        fechaOrujos.Focus()

    End Sub
    Private Sub cancelar()
        inicia_Componentes()
    End Sub
    
    Private Sub habiliTa_controles()

        idVehiculotxt.Enabled = True
        idConductorTxt.Enabled = True
        fechaOrujos.Enabled = True
        conductorTxt.Enabled = True
        vehiculoTxt.Enabled = True
        brutoTxt.Enabled = True
        taraTxt.Enabled = True
        netoTxt.Enabled = True
        dniTxt.Enabled = True
        tablaVehiculos.Enabled = True
        tablaConductores.Enabled = True

    End Sub
    Private Sub deshabilita_controles()

        idVehiculotxt.Enabled = False
        idConductorTxt.Enabled = False
        fechaOrujos.Enabled = False
        conductorTxt.Enabled = False
        vehiculoTxt.Enabled = False
        brutoTxt.Enabled = False
        taraTxt.Enabled = False
        netoTxt.Enabled = False
        dniTxt.Enabled = False
        tablaVehiculos.Enabled = False
        tablaConductores.Enabled = False
    End Sub

    Private Sub Activa_Validaciones()


        fechaOrujos.CausesValidation = True


        brutoTxt.CausesValidation = True
        taraTxt.CausesValidation = True
        netoTxt.CausesValidation = True


    End Sub
    Private Sub rellena_conductores()
        

        tablaConductores.AutoGenerateColumns = False




        With tablaConductores
            .Columns.Add("0", "Nombre")
            .Columns.Add("1", "Apellido 1")
            .Columns.Add("2", "Apellido 2")
            .Columns.Add("3", "NIF")

            .Columns(0).DataPropertyName = "nombre"
            .Columns(1).DataPropertyName = "apellido1"
            .Columns(2).DataPropertyName = "apellido2"
            .Columns(3).DataPropertyName = "dni"

        End With



    End Sub
   
	
	Private Sub vehiculoTxt_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles vehiculoTxt.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii < 48 Or KeyAscii > 57 Then
			If KeyAscii <> 8 Then
				If KeyAscii = 13 Then
					System.Windows.Forms.SendKeys.Send(vbTab)
				End If
				If KeyAscii = 27 Then
					Call cancelar()
					GoTo EventExitSub
				End If
				KeyAscii = 0
			End If
		End If
		
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub

    Private Sub _Toolbar1_Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button1.Click
        Me.nuevo()
    End Sub

    Private Sub _Toolbar1_Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button2.Click
        Me.editar()
    End Sub

    Private Sub _Toolbar1_Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button3.Click
        Me.cancelar()
    End Sub

    Private Sub _Toolbar1_Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button5.Click
        Me.borrar()
    End Sub

    Private Sub _Toolbar1_Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button7.Click
        Me.guardar()
    End Sub

    Private Sub _Toolbar1_Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Toolbar1_Button9.Click
        Me.Close()
    End Sub
End Class