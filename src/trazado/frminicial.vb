Option Strict Off
Option Explicit On
Imports System.IO


Friend Class frminicial
	Inherits System.Windows.Forms.Form

    Dim vVehiculos As frmAdvehiculo
    Dim vConductor As frmCondutores
    Dim vTerminos As frmTerminos
    Dim vClientes As frmAdClientes
    Dim vCosechero As frmAdSocios

    'Dim vAddAclarado As frmAdopAclaradoCenV
    Dim vOrujos As frmAdorujos
    Dim vConfig As frmConfig
    Dim vAlbaran As frmalbaranes
    Dim vAdLotes As frmAdLotAceite
    Dim vAddPartidas As frmAdparAceite
    Dim vVisor As frmvisor
    Dim vfrmadlotaceituna As frmAdLotAceituna
    Dim vImportTicket As frmwizardadticket1
    Dim vSocios As frmSocios
    Dim vPatio As frmLotesAceituna
    Dim vTolvas As frmPaAceituna
    Dim vMoltur As frmOpFabrica
    Dim vfrmOpbodega As frmOpBodega
    Dim vlotaceite As frmlotesMolturaciion
    Dim vImpRendimiento As New frmImpRendimientos
    Dim vAddEnvasado As frmAddEnvasado
    Dim vfrmAddEnvasado As frmAddEnvasado
    Dim vfrmpartidas As frmParAceite

    Dim vfrmWizardOpbdg1 As frmWizardOpbdg1
    Dim vWizardMoltur2 As frmWizardMoltur2
    Dim vParAceituna As frmAdPaAceituna
    Dim vAdOpbodega As frmAdOpBodega
    Dim vwizardmoltur1 As frmWizardMoltur1

    Private Property vfrmAdopfabrica As frmAdOpfabricaAclar

    Private Sub frminicial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim vLogin As frmLogin = New frmLogin()
        vLogin.ShowDialog()


    End Sub

    Private Sub mnVehiculos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnVehiculos.Click

        vVehiculos = New frmAdvehiculo



        vVehiculos.MdiParent = Me
        vVehiculos.Show()


    End Sub

    Private Sub mnConductores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnConductores.Click

        vConductor = New frmCondutores

        vConductor.MdiParent = Me


        vConductor.Show()



    End Sub

    Private Sub mnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnSalir.Click
        Application.Exit()
    End Sub

    Private Sub mnterminos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnterminos.Click

        vTerminos = New frmTerminos


        vTerminos.MdiParent = Me
        vTerminos.Show()



    End Sub

    Private Sub mnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnClientes.Click

        vClientes = New frmAdClientes


        vClientes.MdiParent = Me
        vClientes.Show()




    End Sub

    Private Sub mnCosMant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnCosMant.Click

        vCosechero = New frmAdSocios



        vCosechero.MdiParent = Me

        vCosechero.Show()


    End Sub


    

    Private Sub mnaclarado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnaclarado.Click

        ' vAddAclarado = New frmAdopAclaradoCenV


        '        vAddAclarado.MdiParent = Me

        'vAddAclarado.Show()



    End Sub

    Private Sub mnorujos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnorujos.Click

        vOrujos = New frmAdorujos



        vOrujos.MdiParent = Me

        vOrujos.Show()



    End Sub


    Private Sub mncampañas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mncampañas.Click
        Dim vCampañas As frmCampagnas

        CierraTodosDocumentos()

        vCampañas = New frmCampagnas
        vCampañas.MdiParent = Me

        vCampañas.Show()
    End Sub

    Private Sub mnconfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnconfig.Click


        CierraTodosDocumentos()

        vConfig = New frmConfig

        vConfig.MdiParent = Me
        vConfig.Show()


    End Sub


    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click

        vAlbaran = New frmalbaranes


        vAlbaran.MdiParent = Me

        vAlbaran.Show()


    End Sub

    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click


        vAdLotes = New frmAdLotAceite


        vAdLotes.MdiParent = Me

        vAdLotes.Show()





    End Sub




    Private Sub CierraTodosDocumentos()


        For Each ventana As Form In Me.MdiChildren
            ventana.Close()
        Next


    End Sub

    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click


        vAddPartidas = New frmAdparAceite


        vAddPartidas.MdiParent = Me

        vAddPartidas.Show()


    End Sub
    Friend Sub VerInforme()


        vVisor = New frmvisor

        vVisor.MdiParent = Me
        ' vVisor.visor.Navigate(New System.Uri(My.Application.Info.DirectoryPath & "\" & "informe.html"))
        vVisor.visor.Navigate(New System.Uri(My.Application.Info.DirectoryPath & "\" & "informe.pdf"))

        vVisor.Show()


    End Sub




    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click


        vfrmadlotaceituna = New frmAdLotAceituna

        vfrmadlotaceituna.MdiParent = Me
        vfrmadlotaceituna.Show()


    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click

        CierraTodosDocumentos()

        vImportTicket = New frmwizardadticket1


        vImportTicket.MdiParent = Me

        vImportTicket.Show()


    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click


        vSocios = New frmSocios


        vSocios.MdiParent = Me
        vSocios.Show()


    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click


        vPatio = New frmLotesAceituna

        vPatio.MdiParent = Me
        vPatio.Show()

    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click


        vTolvas = New frmPaAceituna


        vTolvas.MdiParent = Me
        vTolvas.Show()
        

    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click


        vMoltur = New frmOpFabrica

        vMoltur.MdiParent = Me
        vMoltur.Show()
        

    End Sub

    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click


        vfrmOpbodega = New frmOpBodega

        vfrmOpbodega.MdiParent = Me
        vfrmOpbodega.Show()
        

    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click


        vlotaceite = New frmlotesMolturaciion

        vlotaceite.MdiParent = Me
        vlotaceite.Show()
        

    End Sub

    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click


        vParAceituna = New frmAdPaAceituna

        vParAceituna.MdiParent = Me
        vParAceituna.Show()
        

    End Sub

    'Pulsación de partidas automáticas
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        Dim vfrmwizardpartidas1 As frmwizardpartidas1

        CierraTodosDocumentos()

        
            vfrmwizardpartidas1 = New frmwizardpartidas1()

            vfrmwizardpartidas1.MdiParent = Me
            vfrmwizardpartidas1.Show()

    End Sub

    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click


        vfrmAdopfabrica = New frmAdOpfabricaAclar


        vfrmAdopfabrica.MdiParent = Me
        vfrmAdopfabrica.Show()
        

    End Sub

    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click

        CierraTodosDocumentos()

        vwizardmoltur1 = New frmWizardMoltur1


        vwizardmoltur1.MdiParent = Me
        vwizardmoltur1.Show()



    End Sub

    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click

        vAdOpbodega = New frmAdOpBodega



        vAdOpbodega.MdiParent = Me
        vAdOpbodega.Show()
        

    End Sub

    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click


        vfrmWizardOpbdg1 = New frmWizardOpbdg1


        vfrmWizardOpbdg1.MdiParent = Me
        vfrmWizardOpbdg1.Show()
        
    End Sub

    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click

        vfrmpartidas = New frmParAceite

        vfrmpartidas.MdiParent = Me
        vfrmpartidas.Show()
        


    End Sub

    

    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click

        vfrmAddEnvasado = New frmAddEnvasado

        vfrmAddEnvasado.MdiParent = Me

        vfrmAddEnvasado.Show()
        
    End Sub

    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        SendKeys.Send("{F1}")
    End Sub

    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click

        vAddEnvasado = New frmAddEnvasado


        vAddEnvasado.MdiParent = Me
        vAddEnvasado.StartPosition = FormStartPosition.CenterScreen
        vAddEnvasado.Show()
        

    End Sub

   
    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem36.Click
        vImpRendimiento = New frmImpRendimientos()

        vImpRendimiento.MdiParent = Me
        vImpRendimiento.Show()
        


    End Sub
End Class