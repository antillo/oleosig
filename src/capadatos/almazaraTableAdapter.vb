Imports System.Data.Common
Imports System.Text
Imports System.ComponentModel

Public Class almazaraTableAdapter


    Private _ds As DataSet
    Private _adpt As DbDataAdapter
    Private cdatos As New CBaseDatos


    Private _almazara As eAlmazara
    Private _campañas As CampagnaDB


    Private _vehiculos As vehiculosTableAdapter
    Private _conductores As conductorTableAdapter


    Private _miscampañas As oleosigDB.campagnasDataTable
    Private _idalmazara As Integer
    Private conexion As DbConnection


    Public ReadOnly Property Conductores As DataTable
        Get
            Return Me._conductores.Conductores
        End Get
    End Property



    Public ReadOnly Property Id As Integer
        Get
            Return Me._almazara.Id
        End Get
    End Property

    Public Property Nombre As String
        Get
            Return Me._almazara.Nombre
        End Get
        Set(ByVal value As String)
            Me._almazara.Nombre = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return Me._almazara.Direccion
        End Get
        Set(ByVal value As String)
            Me._almazara.Direccion = value
        End Set
    End Property

    Public Property Batidoras As Integer
        Get
            Return Me._almazara.Batidoras
        End Get
        Set(ByVal value As Integer)
            Me._almazara.Batidoras = value
        End Set
    End Property

    Public Property Centrifugas As Integer
        Get
            Return Me._almazara.Centrifugas
        End Get
        Set(ByVal value As Integer)
            Me._almazara.Centrifugas = value
        End Set
    End Property

    Public Property Cif As String
        Get
            Return Me._almazara.Cif
        End Get
        Set(ByVal value As String)
            Me._almazara.Cif = value
        End Set
    End Property

    Public Property Agrario As String
        Get
            Return Me._almazara.Agrario
        End Get
        Set(ByVal value As String)
            Me._almazara.Agrario = value
        End Set
    End Property

    Public Property Decanters As Integer
        Get
            Return Me._almazara.Decanters
        End Get
        Set(ByVal value As Integer)
            Me._almazara.Decanters = value
        End Set
    End Property
    Public Property Email As String
        Get
            Return Me._almazara.Email
        End Get
        Set(ByVal value As String)
            Me._almazara.Email = value
        End Set
    End Property

    Public Property CodPostal As String
        Get
            Return Me._almazara.CodPostal.ToString
        End Get
        Set(ByVal value As String)
            Me._almazara.CodPostal = value
        End Set
    End Property

    Public Property Localidad As String
        Get
            Return Me._almazara.Localidad
        End Get
        Set(ByVal value As String)
            Me._almazara.Localidad = value
        End Set
    End Property
    Public Property Provincia As String
        Get
            Return Me._almazara.Provincia
        End Get
        Set(ByVal value As String)
            Me._almazara.Provincia = value
        End Set
    End Property
    Public Property Sanitario As String
        Get
            Return Me._almazara.Sanitario
        End Get
        Set(ByVal value As String)
            Me._almazara.Sanitario = value
        End Set
    End Property
    Public Property Telefono As String
        Get
            Return Me._almazara.Telefono.ToString
        End Get
        Set(ByVal value As String)
            Me._almazara.Telefono = value
        End Set
    End Property
    Public Property Pesaje As Integer
        Get
            Return Me._almazara.Pesaje
        End Get
        Set(ByVal value As Integer)
            Me._almazara.Pesaje = value
        End Set
    End Property
    Public Property Delimitador As String
        Get
            Return Me._almazara.Delimitador
        End Get
        Set(ByVal value As String)
            Me._almazara.Delimitador = value
        End Set
    End Property
    Public Property DelimitadorRend As String
        Get
            Return Me._almazara.DelimitadorRend
        End Get
        Set(ByVal value As String)
            Me._almazara.DelimitadorRend = value
        End Set
    End Property
    Public Property Multibasculas As Boolean
        Get
            Return Me._almazara.Multibascula
        End Get
        Set(ByVal value As Boolean)
            Me._almazara.Multibascula = value
        End Set
    End Property


    Public ReadOnly Property CampañaAct As oleosigDB.campagnasRow
        Get
            If Me._miscampañas Is Nothing Then
                Me._miscampañas = New oleosigDB.campagnasDataTable
                Me._campañas.Fill(Me._miscampañas)
            End If
            Dim fila As oleosigDB.campagnasRow = Me._miscampañas.AsEnumerable.First(Function(camp As oleosigDB.campagnasRow) camp.activa = True)
            Return fila

        End Get

    End Property


    Public ReadOnly Property Campañas As oleosigDB.campagnasDataTable
        Get
            If Me._miscampañas Is Nothing Then
                Me._miscampañas = New oleosigDB.campagnasDataTable
                Me._campañas.Fill(Me._miscampañas)
            End If
            Return Me._miscampañas
        End Get
    End Property

    Public Sub SelectCampaña(ByVal campaña As oleosigDB.campagnasRow)
        Me._campañas.SelectCampaña_actual(campaña)
    End Sub

    Public Sub NuevaCampaña(ByVal campaña As String, ByVal clave As Int32)
        Me._campañas.NuevaCampaña(campaña, clave)
    End Sub




    Public Sub BorraCampaña(ByVal campagna As oleosigDB.campagnasRow)
        Me._campañas.Delete(campagna.id)
    End Sub



    Public Sub Guarda_conductores()
        Me._conductores.guardar()
    End Sub

    Public Sub Guardar_almazara()

        Dim fila As DataRow = Me._ds.Tables("cfgalmazara").Rows.Find(Me._idalmazara)

        fila("regagrario") = Me._almazara.Agrario
        fila("batidoras") = Me._almazara.Batidoras
        fila("centrifugas") = Me._almazara.Centrifugas
        fila("cif") = Me._almazara.Cif
        fila("cp") = Me._almazara.CodPostal
        fila("decanters") = Me._almazara.Decanters
        fila("direccion") = Me._almazara.Direccion
        fila("email") = Me._almazara.Email
        fila("localidad") = Me._almazara.Localidad
        fila("nombre") = Me._almazara.Nombre
        fila("provincia") = Me._almazara.Provincia
        fila("regsanitario") = Me._almazara.Sanitario
        fila("telefono") = Me._almazara.Telefono
        fila("pesaje") = Me._almazara.Pesaje
        fila("delimitador") = Me._almazara.Delimitador
        fila("delimitadorRend") = Me._almazara.DelimitadorRend
        fila("multibasculas") = Me._almazara.Multibascula
        fila("seltolva") = Me._almazara.Seltolva


        Me._adpt.Update(Me._ds, "cfgalmazara")

        actualizar_almazara()
    End Sub
    Private Sub actualizar_almazara()

        Me._ds.Tables("cfgalmazara").Clear()


        Try
            Me._ds.Tables("cfgalmazara").BeginLoadData()
            Me._adpt.Fill(Me._ds, "cfgalmazara")
            Me._ds.Tables("cfgalmazara").EndLoadData()


            Dim fila As DataRow = Me._ds.Tables("cfgalmazara").Rows.Find(Me._idalmazara)


            If Not IsDBNull(fila("id")) Then
                Me._almazara.Id = fila("id")
            Else
                Me._almazara.Id = 0
            End If


            If Not IsDBNull(fila("nombre")) Then

                Me._almazara.Nombre = fila("nombre")
            Else
                Me._almazara.Nombre = String.Empty
            End If
            If Not IsDBNull(fila("cif")) Then
                Me._almazara.Cif = fila("cif")
            Else
                Me._almazara.Cif = String.Empty
            End If

            If Not IsDBNull(fila("direccion")) Then

                Me._almazara.Direccion = fila("direccion")
            Else
                Me._almazara.Direccion = ""
            End If


            If Not IsDBNull(fila("telefono")) Then
                Me._almazara.Telefono = fila("telefono")
            Else

                Me._almazara.Telefono = String.Empty

            End If


            If Not IsDBNull(fila("email")) Then

                Me._almazara.Email = fila("email")

            Else

                Me._almazara.Email = String.Empty

            End If


            If Not IsDBNull(fila("decanters")) Then

                Me._almazara.Decanters = fila("decanters")

            Else

                Me._almazara.Decanters = 0

            End If



            If Not IsDBNull(fila("regagrario")) Then
                Me._almazara.Agrario = fila("regagrario")
            Else
                Me._almazara.Agrario = String.Empty
            End If

            If Not IsDBNull(fila("regsanitario")) Then
                Me._almazara.Sanitario = fila("regsanitario")
            Else
                Me._almazara.Sanitario = String.Empty
            End If
            If Not IsDBNull(fila("batidoras")) Then
                Me._almazara.Batidoras = fila("batidoras")
            Else
                Me._almazara.Batidoras = 0
            End If
            If Not IsDBNull(fila("centrifugas")) Then
                Me._almazara.Centrifugas = fila("centrifugas")
            Else
                Me._almazara.Centrifugas = 0
            End If
            If Not IsDBNull(fila("localidad")) Then
                Me._almazara.Localidad = fila("localidad")
            Else
                Me._almazara.Localidad = String.Empty
            End If
            If Not IsDBNull(fila("provincia")) Then
                Me._almazara.Provincia = fila("provincia")
            Else
                Me._almazara.Provincia = String.Empty
            End If
            If Not IsDBNull(fila("cp")) Then
                Me._almazara.CodPostal = fila("cp")
            Else
                Me._almazara.CodPostal = 0
            End If
            If Not IsDBNull(fila("multibasculas")) Then
                Me._almazara.Multibascula = fila("multibasculas")
            Else
                Me._almazara.Multibascula = False
            End If
            If Not IsDBNull(fila("delimitadorrend")) Then
                Me._almazara.DelimitadorRend = fila("delimitadorrend")
            Else
                Me._almazara.DelimitadorRend = String.Empty
            End If

            If Not IsDBNull(fila("seltolva")) Then
                Me._almazara.Seltolva = fila("seltolva")
            End If

        Catch e As Exception

        End Try

    End Sub

    Private Sub _rellena_almazara()
        Dim strsql As New StringBuilder
        Dim param As DbParameter
        Dim cmd As DbCommand
        Dim columna As DataColumn

        Try
            Me._adpt = cdatos.CreateDataAdapter

            strsql.Append("select * from cfgalmazara where id=:id")

            cmd = Me.cdatos.CreateCommand()
            cmd.CommandText = strsql.ToString
            cmd.Connection = Me.conexion
            Me._adpt.SelectCommand = cmd

            strsql.Length = 0

            strsql.Append("update cfgalmazara set ")
            strsql.Append("regagrario=:regagrario,")
            strsql.Append("batidoras=:batidoras,")
            strsql.Append("centrifugas=:centrifugas,")
            strsql.Append("cif=:cif,")
            strsql.Append("cp=:cp,")
            strsql.Append("decanters=:decanters,")
            strsql.Append("direccion=:direccion,")
            strsql.Append("email=:email,")
            strsql.Append("localidad=:localidad,")
            strsql.Append("nombre=:nombre,")
            strsql.Append("provincia=:provincia,")
            strsql.Append("regsanitario=:regsanitario,")
            strsql.Append("telefono=:telefono,")
            strsql.Append("pesaje=:pesaje,")
            strsql.Append("delimitador=:delimitador,")
            strsql.Append("delimitadorRend=:delimitadorrend,")
            strsql.Append("multibasculas=:multibasculas,")
            strsql.Append("seltolva=:seltolva ")
            strsql.Append("where id=:id")

            cmd = Me.cdatos.CreateCommand
            cmd.Connection = Me.conexion
            cmd.CommandText = strsql.ToString

            Me._adpt.UpdateCommand = cmd

            strsql.Length = 0

            strsql.Append("insert into cfgalmazara (")
            strsql.Append("regagrario,")
            strsql.Append("batidoras,")
            strsql.Append("centrifugas,")
            strsql.Append("cif,")
            strsql.Append("cp,")
            strsql.Append("decanters,")
            strsql.Append("direccion,")
            strsql.Append("email,")
            strsql.Append("localidad,")
            strsql.Append("nombre,")
            strsql.Append("provincia,")
            strsql.Append("regsanitario,")
            strsql.Append("telefono,")
            strsql.Append("pesaje,")
            strsql.Append("delimitador,")
            strsql.Append("delimitadorrend,")
            strsql.Append("multibasculas,")
            strsql.Append("seltolva) values(")
            strsql.Append(":regagrario,")
            strsql.Append(":batidoras,")
            strsql.Append(":centrifugas,")
            strsql.Append(":cif,")
            strsql.Append(":cp,")
            strsql.Append(":decanters,")
            strsql.Append(":direccion,")
            strsql.Append(":email,")
            strsql.Append(":localidad,")
            strsql.Append(":nombre,")
            strsql.Append(":provincia,")
            strsql.Append(":regsanitario,")
            strsql.Append(":telefono,")
            strsql.Append(":pesaje,")
            strsql.Append(":delimitador,")
            strsql.Append(":delimitadorrend,")
            strsql.Append(":multibasculas,")
            strsql.Append(":seltolva)")

            cmd = Me.cdatos.CreateCommand
            cmd.Connection = Me.conexion
            cmd.CommandText = strsql.ToString

            Me._adpt.InsertCommand = cmd

            cmd = Me.cdatos.CreateCommand
            cmd.Connection = Me.conexion
            cmd.CommandText = "delete from cfgalmazara where id=:id"

            Me._adpt.DeleteCommand = cmd

            param = Me.cdatos.CreateParameter
            param.SourceColumn = "id"
            param.ParameterName = ":id"
            param.DbType = DbType.Int32
            param.Value = _idalmazara

            Me._adpt.SelectCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)
            Me._adpt.DeleteCommand.Parameters.Add(param)


            param = Me.cdatos.CreateParameter
            param.SourceColumn = "regagrario"
            param.ParameterName = ":regagrario"
            param.DbType = DbType.String

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)


            param = Me.cdatos.CreateParameter
            param.SourceColumn = "batidoras"
            param.ParameterName = ":batidoras"
            param.DbType = DbType.Int32

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = Me.cdatos.CreateParameter
            param.SourceColumn = "centrifugas"
            param.ParameterName = ":centrifugas"
            param.DbType = DbType.Int32

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = Me.cdatos.CreateParameter
            param.SourceColumn = "cif"
            param.ParameterName = ":cif"
            param.DbType = DbType.String

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = Me.cdatos.CreateParameter
            param.SourceColumn = "cp"
            param.ParameterName = ":cp"
            param.DbType = DbType.Int32

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = Me.cdatos.CreateParameter
            param.SourceColumn = "decanters"
            param.ParameterName = ":decanters"
            param.DbType = DbType.Int32

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = Me.cdatos.CreateParameter
            param.SourceColumn = "direccion"
            param.ParameterName = ":direccion"
            param.DbType = DbType.String

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = Me.cdatos.CreateParameter
            param.SourceColumn = "email"
            param.ParameterName = ":email"
            param.DbType = DbType.String

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = Me.cdatos.CreateParameter
            param.SourceColumn = "localidad"
            param.ParameterName = ":localidad"
            param.DbType = DbType.String

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = Me.cdatos.CreateParameter
            param.SourceColumn = "nombre"
            param.ParameterName = ":nombre"
            param.DbType = DbType.String

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = Me.cdatos.CreateParameter
            param.SourceColumn = "provincia"
            param.ParameterName = ":provincia"
            param.DbType = DbType.String

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = Me.cdatos.CreateParameter
            param.SourceColumn = "regsanitario"
            param.ParameterName = ":regsanitario"
            param.DbType = DbType.String

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = Me.cdatos.CreateParameter
            param.SourceColumn = "telefono"
            param.ParameterName = ":telefono"
            param.DbType = DbType.String

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = Me.cdatos.CreateParameter
            param.SourceColumn = "pesaje"
            param.ParameterName = ":pesaje"
            param.DbType = DbType.Int32

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = Me.cdatos.CreateParameter
            param.SourceColumn = "delimitador"
            param.ParameterName = ":delimitador"
            param.DbType = DbType.String

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = Me.cdatos.CreateParameter
            param.SourceColumn = "delimitadorrend"
            param.ParameterName = ":delimitadorrend"
            param.DbType = DbType.String

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = Me.cdatos.CreateParameter
            param.SourceColumn = "multibasculas"
            param.ParameterName = ":multibasculas"
            param.DbType = DbType.Boolean

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = Me.cdatos.CreateParameter
            param.SourceColumn = "seltolva"
            param.ParameterName = ":seltolva"
            param.DbType = DbType.Boolean

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)


            Me._adpt.Fill(Me._ds, "cfgalmazara")

            columna = Me._ds.Tables("cfgalmazara").Columns("id")

            Me._ds.Tables("cfgalmazara").PrimaryKey = New DataColumn() {columna}


            actualizar_almazara()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub




    Public Sub New(ByVal idalmazara As Integer)
        MyBase.New()
        Me.conexion = Me.cdatos.GetConnection
        Me._idalmazara = idalmazara


        Me._campañas = New CampagnaDB(idalmazara)
        Me._almazara = New eAlmazara
        Me._conductores = New conductorTableAdapter(idalmazara)

        Me._ds = New DataSet

        _rellena_almazara()


    End Sub



End Class
