<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frminicial
#Region "Código generado por el Diseñador de Windows Forms "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Llamada necesaria para el Diseñador de Windows Forms.
		InitializeComponent()
	End Sub
	'Form invalida a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
    Public dialogoOpen As System.Windows.Forms.OpenFileDialog

	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frminicial))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.dialogoOpen = New System.Windows.Forms.OpenFileDialog()
        Me.dialogoSave = New System.Windows.Forms.SaveFileDialog()
        Me.MainMenu2 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.mnSalir = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.mnVehiculos = New System.Windows.Forms.MenuItem()
        Me.mnConductores = New System.Windows.Forms.MenuItem()
        Me.mnClientes = New System.Windows.Forms.MenuItem()
        Me.mnCosecheros = New System.Windows.Forms.MenuItem()
        Me.mnCosMant = New System.Windows.Forms.MenuItem()
        Me.mnterminos = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem35 = New System.Windows.Forms.MenuItem()
        Me.MenuItem36 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.mnaclarado = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.mnorujos = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.mnopbodega = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem34 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.mncampañas = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.mnconfig = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.mnVentana = New System.Windows.Forms.MenuItem()
        Me.MenuItem33 = New System.Windows.Forms.MenuItem()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.SuspendLayout()
        '
        'MainMenu2
        '
        Me.MainMenu2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem8, Me.mnVentana, Me.MenuItem33})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnSalir})
        Me.MenuItem1.Text = "Archivo"
        '
        'mnSalir
        '
        Me.mnSalir.Index = 0
        Me.mnSalir.Text = "Salir"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnVehiculos, Me.mnConductores, Me.mnClientes, Me.mnCosecheros, Me.mnterminos, Me.MenuItem4, Me.MenuItem5, Me.MenuItem12, Me.MenuItem13, Me.MenuItem14, Me.MenuItem34, Me.MenuItem16, Me.mncampañas, Me.MenuItem18, Me.mnconfig})
        Me.MenuItem2.Text = "Mantenimiento"
        '
        'mnVehiculos
        '
        Me.mnVehiculos.Index = 0
        Me.mnVehiculos.Text = "Vehiculos"
        '
        'mnConductores
        '
        Me.mnConductores.Index = 1
        Me.mnConductores.Text = "Conductores"
        '
        'mnClientes
        '
        Me.mnClientes.Index = 2
        Me.mnClientes.Text = "Clientes"
        '
        'mnCosecheros
        '
        Me.mnCosecheros.Index = 3
        Me.mnCosecheros.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnCosMant})
        Me.mnCosecheros.Text = "Cosecheros"
        '
        'mnCosMant
        '
        Me.mnCosMant.Index = 0
        Me.mnCosMant.Text = "Mantenimiento"
        '
        'mnterminos
        '
        Me.mnterminos.Index = 4
        Me.mnterminos.Text = "Términos"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 5
        Me.MenuItem4.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 6
        Me.MenuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6, Me.MenuItem35, Me.MenuItem9})
        Me.MenuItem5.Text = "Patio"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 0
        Me.MenuItem6.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.MenuItem7})
        Me.MenuItem6.Text = "Tickets"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "Importar"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 1
        Me.MenuItem7.Text = "Añadir/Editar"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 1
        Me.MenuItem35.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem36})
        Me.MenuItem35.Text = "Rendimientos"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 0
        Me.MenuItem36.Text = "Importar"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 2
        Me.MenuItem9.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem22, Me.MenuItem23})
        Me.MenuItem9.Text = "Tolvas"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 0
        Me.MenuItem22.Text = "Manual"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 1
        Me.MenuItem23.Text = "Automático"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 7
        Me.MenuItem12.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem20, Me.mnaclarado, Me.MenuItem25, Me.mnorujos})
        Me.MenuItem12.Text = "Fábrica"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 0
        Me.MenuItem20.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem24, Me.MenuItem26})
        Me.MenuItem20.Text = "Molturaciones"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 0
        Me.MenuItem24.Text = "Manual"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 1
        Me.MenuItem26.Text = "Automático"
        '
        'mnaclarado
        '
        Me.mnaclarado.Index = 1
        Me.mnaclarado.Text = "Aclarado"
        Me.mnaclarado.Visible = False
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 2
        Me.MenuItem25.Text = "-"
        '
        'mnorujos
        '
        Me.mnorujos.Index = 3
        Me.mnorujos.Text = "Orujos"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 8
        Me.MenuItem13.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnopbodega, Me.MenuItem28, Me.MenuItem29, Me.MenuItem32})
        Me.MenuItem13.Text = "Bodega"
        '
        'mnopbodega
        '
        Me.mnopbodega.Index = 0
        Me.mnopbodega.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem27, Me.MenuItem30})
        Me.mnopbodega.Text = "Entradas Fábrica"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 0
        Me.MenuItem27.Text = "Manual"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 1
        Me.MenuItem30.Text = "Automático"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 1
        Me.MenuItem28.Text = "Lotes Aceite"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 2
        Me.MenuItem29.Text = "Partidas Aceite"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 3
        Me.MenuItem32.Text = "Envasado"
        Me.MenuItem32.Visible = False
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 9
        Me.MenuItem14.Text = "Ventas Granel"
        Me.MenuItem14.Visible = False
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 10
        Me.MenuItem34.Text = "Envasado"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 11
        Me.MenuItem16.Text = "-"
        '
        'mncampañas
        '
        Me.mncampañas.Index = 12
        Me.mncampañas.Text = "Campañas"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 13
        Me.MenuItem18.Text = "-"
        '
        'mnconfig
        '
        Me.mnconfig.Index = 14
        Me.mnconfig.Text = "Configuración"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 2
        Me.MenuItem8.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem10, Me.MenuItem11, Me.MenuItem15, Me.MenuItem17, Me.MenuItem19, Me.MenuItem21, Me.MenuItem31})
        Me.MenuItem8.Text = "Informes"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 0
        Me.MenuItem10.Text = "Cosecheros"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 1
        Me.MenuItem11.Text = "Tickets"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 2
        Me.MenuItem15.Text = "Tolvas"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 3
        Me.MenuItem17.Text = "Molturaciones"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 4
        Me.MenuItem19.Text = "Entradas Aceite"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 5
        Me.MenuItem21.Text = "Lotes Aceite"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 6
        Me.MenuItem31.Text = "Partidas de aceite"
        '
        'mnVentana
        '
        Me.mnVentana.Index = 3
        Me.mnVentana.MdiList = True
        Me.mnVentana.Text = "Ventana"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 4
        Me.MenuItem33.Text = "Ayuda"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "ayuda trazado.chm"
        '
        'frminicial
        '
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(736, 449)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Location = New System.Drawing.Point(11, 57)
        Me.Menu = Me.MainMenu2
        Me.Name = "frminicial"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Oleosig"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dialogoSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MainMenu2 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnVentana As System.Windows.Forms.MenuItem
    Friend WithEvents mnVehiculos As System.Windows.Forms.MenuItem
    Friend WithEvents mnConductores As System.Windows.Forms.MenuItem
    Friend WithEvents mnClientes As System.Windows.Forms.MenuItem
    Friend WithEvents mnCosecheros As System.Windows.Forms.MenuItem
    Friend WithEvents mnCosMant As System.Windows.Forms.MenuItem
    Friend WithEvents mnterminos As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents mnaclarado As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents mnorujos As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents mncampañas As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents mnconfig As System.Windows.Forms.MenuItem
    Friend WithEvents mnopbodega As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents mnSalir As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem

#End Region
End Class