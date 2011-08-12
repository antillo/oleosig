Option Strict Off
Option Explicit On
Imports System.Text
Imports System.Data.Common
Imports System.ComponentModel

Public Class conductorTableAdapter



    Private _idalmazara As Integer
    Private dt As DataSet
    Private conexion As DbConnection
    Private cdatos As New CBaseDatos
    Private _adpt As DbDataAdapter

    'devuelve todos los conductores
    Public ReadOnly Property Conductores As DataTable
        Get
            Return Me.dt.Tables("conductores")
        End Get

    End Property



    Private Sub inicia_datos()
        Dim strSql As String
        Dim cmd As DbCommand
        Dim columna As DataColumn
        Dim parametro As DbParameter


        Try

            strSql = "select * from conductores where idalmazara='" & Me._idalmazara.ToString & "' order by id"

            Me.dt = New DataSet

            cmd = Me.cdatos.CreateCommand()
            cmd.CommandText = strSql
            cmd.Connection = Me.conexion

            Me._adpt.SelectCommand = cmd
            Me._adpt.Fill(dt, "conductores")

            cmd = Me.cdatos.CreateCommand()
            cmd.CommandText = "delete from conductores where id=:id"
            cmd.Connection = Me.conexion

            Me._adpt.DeleteCommand = cmd

            strSql = "insert into conductores (idalmazara,apellido1,apellido2,nombre,dni,telefono) values(:idalmazara,:apellido1,:apellido2,:nombre,:dni,:telefono)"

            cmd = Me.cdatos.CreateCommand
            cmd.CommandText = strSql
            cmd.Connection = Me.conexion

            Me._adpt.InsertCommand = cmd

            strSql = "update conductores set apellido1=:apellido1,apellido2=:apellido2,nombre=:nombre,dni=:dni,telefono=:telefono where id=:id"

            cmd = Me.cdatos.CreateCommand
            cmd.CommandText = strSql
            cmd.Connection = Me.conexion

            Me._adpt.UpdateCommand = cmd

            parametro = Me.cdatos.CreateParameter
            parametro.DbType = DbType.Int32
            parametro.ParameterName = ":id"
            parametro.SourceColumn = "id"

            Me._adpt.DeleteCommand.Parameters.Add(parametro)
            Me._adpt.UpdateCommand.Parameters.Add(parametro)

            parametro = Me.cdatos.CreateParameter
            parametro.DbType = DbType.Int32
            parametro.ParameterName = ":idalmazara"
            parametro.SourceColumn = "idalmazara"
            parametro.Value = Me._idalmazara

            Me._adpt.InsertCommand.Parameters.Add(parametro)

            parametro = Me.cdatos.CreateParameter
            parametro.DbType = DbType.String
            parametro.ParameterName = ":apellido1"
            parametro.SourceColumn = "apellido1"

            Me._adpt.InsertCommand.Parameters.Add(parametro)
            Me._adpt.UpdateCommand.Parameters.Add(parametro)

            parametro = Me.cdatos.CreateParameter
            parametro.DbType = DbType.String
            parametro.ParameterName = ":apellido2"
            parametro.SourceColumn = "apellido2"

            Me._adpt.InsertCommand.Parameters.Add(parametro)
            Me._adpt.UpdateCommand.Parameters.Add(parametro)

            parametro = Me.cdatos.CreateParameter
            parametro.DbType = DbType.String
            parametro.ParameterName = ":nombre"
            parametro.SourceColumn = "nombre"

            Me._adpt.InsertCommand.Parameters.Add(parametro)
            Me._adpt.UpdateCommand.Parameters.Add(parametro)

            parametro = Me.cdatos.CreateParameter
            parametro.DbType = DbType.String
            parametro.ParameterName = ":dni"
            parametro.SourceColumn = "dni"

            Me._adpt.InsertCommand.Parameters.Add(parametro)
            Me._adpt.UpdateCommand.Parameters.Add(parametro)

            parametro = Me.cdatos.CreateParameter
            parametro.DbType = DbType.String
            parametro.ParameterName = ":telefono"
            parametro.SourceColumn = "telefono"

            Me._adpt.InsertCommand.Parameters.Add(parametro)
            Me._adpt.UpdateCommand.Parameters.Add(parametro)

            columna = Me.dt.Tables("conductores").Columns(0)
            columna.AutoIncrement = True
            columna.AutoIncrementSeed = 0
            columna.AutoIncrementStep = -1

            Me.dt.Tables("conductores").PrimaryKey = New DataColumn() {columna}

            actualiza()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub
    Private Sub actualiza()


        Me.dt.Clear()
        Me._adpt.Fill(Me.dt, "conductores")


    End Sub


    'DEVUELVE UNA ENTIDAD CONDUCTOR DADO SU IDENTIFICADOR

    Public Function getById(ByVal vId As UShort) As DataRow

        Dim fila As DataRow



        Try

            fila = dt.Tables("conductores").Rows.Find(vId)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return fila

    End Function


    'DEVUELVE UNA COLECCION DE ENTIDADES CONDUCTOR DADO EL SEGUNDO APELLIDO

    Public Function getByApellido2(ByVal vApellido As String) As DataRow()

        Dim filas() As DataRow



        Try


            filas = Me.dt.Tables("conductores").Select("apellido2='" & vApellido & "'")




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return filas

    End Function


    'DEVUELVE UNA COLECCION DE ENTIDADES CONDUCTOR

    Public Function getByApellido1(ByVal vApellido As String) As DataRow()


        Dim filas() As DataRow

        Try



            filas = Me.dt.Tables("conductores").Select("apellido1='" & vApellido & "'")




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return filas

    End Function

    Public Function getByDNI(ByVal vDNI As String) As DataRow


        Dim fila As DataRow



        Try
            fila = Me.dt.Tables("conductores").AsEnumerable.Single(Function(fil As DataRow) fil("dni") = vDNI.ToUpper)


        Catch ex As Exception

        End Try
        Return fila

    End Function


    Public Sub guardar()


        Me._adpt.Update(Me.dt, "conductores")

        actualiza()

    End Sub



    Public Function existe(ByVal nif As String) As Boolean

        Dim valordevuelto As Boolean

        If Me.dt.Tables("conductores").Select("cif='" & nif.ToUpper & "'").Count > 0 Then



            valordevuelto = True
        Else

            valordevuelto = False

        End If

        Return valordevuelto



    End Function





    Public Sub New(ByVal idalmazara As Integer)
        MyBase.New()

        Me.conexion = Me.cdatos.GetConnection
        Me._adpt = cdatos.CreateDataAdapter

        Me._idalmazara = idalmazara
        Me.inicia_datos()

    End Sub


    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub
End Class