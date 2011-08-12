Option Strict Off
Option Explicit On

Imports System.Data.Common
Imports System.Text

Public Class vehiculosTableAdapter



    Private _dt As DataSet
    Private _idalmazara As Integer
    Private _adpt As DbDataAdapter
    Private cdatos As New CBaseDatos
    Private _conexion As DbConnection

    Public ReadOnly Property Vehiculos As DataTable
        Get
            Return Me._dt.Tables("vehiculos")
        End Get
    End Property




    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function existeId(ByVal Id As UShort) As Boolean
        Dim strSql As String
        Dim resultado As Object
        Dim valordevuelto As Boolean
        Dim cmd As DbCommand

        strSql = "select count(*) from vehiculos where id ='" & Id & "'"

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strSql
        If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
            _conexion.Open()
        End If
        resultado = cmd.ExecuteScalar
        _conexion.Close()

        If Not IsDBNull(resultado) Then

            If CType(resultado, ULong) > 0 Then
                valordevuelto = True
            Else
                valordevuelto = False
            End If
        End If

        Return valordevuelto

    End Function

    Public Function existeMatricula(ByVal matricula As String) As Boolean
        Dim cmd As DbCommand
        Dim rs As New DataSet
        Dim lector As DataTableReader

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion

        cmd.CommandText = "select count(*) from vehiculos where matricula ='" & matricula & "' and idalmazara='" & Me._idalmazara.ToString & "'"
        Me._adpt.SelectCommand = cmd

        Me._adpt.Fill(rs)

        lector = rs.CreateDataReader()
        lector.Read()
        If lector(0) = 0 Then
            existeMatricula = False
        Else
            existeMatricula = True
        End If

    End Function

    Public Function getByMatricula(ByVal matricula As String) As DataRow
        Dim fila As DataRow

        fila = Me._dt.Tables("vehiculos").AsEnumerable.Single(Function(row As DataRow) row("matricula") = matricula.ToUpper)

        Return fila

    End Function

    '###################################################################################
    '#
    '#      devuelve una entidad vehiculo dado un id
    '#
    '###################################################################################
    Public Function getById(ByVal Id As UShort) As DataRow


        Return Me._dt.Tables("vehiculos").Rows.Find(Id)


    End Function




    Public Sub Guardar()


        Me._adpt.Update(Me._dt, "vehiculos")


        actualiza()

    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="id"></param>
    ''' <remarks></remarks>
    Public Sub borrar(ByVal id As Integer)
        Dim strSql As String
        strSql = "delete from vehiculos where id='" & id.ToString & "'"
        cDatos.Haz(strSql)
        actualiza()
    End Sub
    Private Sub inicia_Datos()
        Dim strsql As New StringBuilder
        Dim cmd As DbCommand
        Dim parametro As DbParameter
        Dim columna As DataColumn


        strsql.Append("select * from vehiculos where idalmazara=:idalmazara order by id")


        cmd = cdatos.CreateCommand
        cmd.Connection = cdatos.GetConnection
        cmd.CommandText = strsql.ToString

        Me._adpt.SelectCommand = cmd

        strsql.Length = 0
        strsql.Append("insert into vehiculos (idalmazara,matricula) values(:idalmazara,:matricula)")

        cmd = cdatos.CreateCommand
        cmd.Connection = cdatos.GetConnection
        cmd.CommandText = strsql.ToString

        Me._adpt.InsertCommand = cmd

        strsql.Length = 0
        strsql.Append("update vehiculos set matricula=:matricula where id=:id and idalmazara=:idalmazara")


        cmd = cdatos.CreateCommand
        cmd.Connection = cdatos.GetConnection
        cmd.CommandText = strsql.ToString

        Me._adpt.UpdateCommand = cmd

        strsql.Length = 0
        strsql.Append("delete from vehiculos where id=:id")

        cmd = cdatos.CreateCommand
        cmd.CommandText = strsql.ToString
        cmd.Connection = cdatos.GetConnection

        Me._adpt.DeleteCommand = cmd

        parametro = Me.cdatos.CreateParameter

        parametro.DbType = DbType.Int32
        parametro.ParameterName = ":id"
        parametro.SourceColumn = "id"

        Me._adpt.UpdateCommand.Parameters.Add(parametro)
        Me._adpt.DeleteCommand.Parameters.Add(parametro)

        parametro = Me.cdatos.CreateParameter
        parametro.DbType = DbType.Int32
        parametro.ParameterName = ":idalmazara"
        parametro.SourceColumn = "idalmazara"
        parametro.Value = Me._idalmazara

        Me._adpt.SelectCommand.Parameters.Add(parametro)
        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)

        parametro = Me.cdatos.CreateParameter
        parametro.DbType = DbType.String
        parametro.ParameterName = ":matricula"
        parametro.SourceColumn = "matricula"

        Me._adpt.SelectCommand.Parameters.Add(parametro)
        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)


        Me._adpt.Fill(Me._dt, "vehiculos")

        columna = Me._dt.Tables("vehiculos").Columns(0)

        columna.AutoIncrement = True
        columna.AutoIncrementSeed = 0
        columna.AutoIncrementStep = -1

        Me._dt.Tables("vehiculos").PrimaryKey = New DataColumn() {columna}

        actualiza()

    End Sub
    Private Sub actualiza()


        Me._dt.Tables("vehiculos").Clear()
        Me._adpt.Fill(Me._dt, "vehiculos")


    End Sub
    Public Sub New(ByVal idalmazara As Integer)
        MyBase.New()
        Me._idalmazara = idalmazara
        Me._dt = New DataSet
        Me._conexion = cdatos.GetConnection
        Me._adpt = cdatos.CreateDataAdapter


        inicia_Datos()

    End Sub
End Class