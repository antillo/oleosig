Imports System.Data.Common

Public Class terminosIneTableAdapter
    Private _conexion As DbConnection
    Private _adpt As DbDataAdapter
    Private _clearBeforeFill As Boolean
    Private cdatos As CBaseDatos
    Private _listacomandos As List(Of DbCommand)

    Public Overridable Overloads Function Update(ByVal tabla As oleosigDB.terminosIneDataTable) As Integer
        Return Me._adpt.Update(tabla)
    End Function

    Public Overridable Overloads Function Delete(ByVal id As Integer) As Integer
        Me._adpt.DeleteCommand.Parameters(":id").Value = CType(id, Integer)
        Dim estadoanterior As ConnectionState = Me._adpt.DeleteCommand.Connection.State
        If (estadoanterior And ConnectionState.Open) <> ConnectionState.Open Then
            Me._adpt.DeleteCommand.Connection.Open()
        End If

        Return Me._adpt.DeleteCommand.ExecuteNonQuery
        If estadoanterior = ConnectionState.Closed Then
            Me._adpt.DeleteCommand.Connection.Close()
        End If
    End Function

    Public Overridable Overloads Function Insert(ByVal cpro As Integer, ByVal cmun As Integer, ByVal nombre As String) As Integer
        Me._adpt.InsertCommand.Parameters(":cpro").Value = CType(cpro, Integer)
        Me._adpt.InsertCommand.Parameters(":cmun").Value = CType(cmun, Integer)
        Me._adpt.InsertCommand.Parameters(":nombre").Value = CType(nombre, String)

        Dim estadoanterior As ConnectionState = Me._adpt.InsertCommand.Connection.State

        If (estadoanterior And ConnectionState.Open) <> ConnectionState.Open Then
            Me._adpt.InsertCommand.Connection.Open()
        End If
        Return Me._adpt.InsertCommand.ExecuteNonQuery()

        If estadoanterior = ConnectionState.Closed Then
            Me._adpt.InsertCommand.Connection.Close()
        End If
    End Function

    Public Overridable Overloads Function GetData() As oleosigDB.terminosIneDataTable
        Dim tabla As New oleosigDB.terminosIneDataTable
        Me._adpt.SelectCommand = _listacomandos(0)

        Me._adpt.Fill(tabla)
        Return tabla

    End Function
    Public Overridable Overloads Function Fill(ByVal tabla As oleosigDB.terminosIneDataTable) As Integer
        Me._adpt.SelectCommand = _listacomandos(0)
        If _clearBeforeFill Then
            tabla.Clear()
        End If
        Return Me._adpt.Fill(tabla)
    End Function

    Private Sub inicia_Comandos()
        Dim cmd As DbCommand

        _listacomandos = New List(Of DbCommand)

        cmd = cdatos.CreateCommand
        cmd.Connection = _conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from todos_terminos order by id"

        _listacomandos.Add(cmd)


    End Sub
    Private Sub inicia_datos()
        Dim cmd As DbCommand
        Dim mapa As DataTableMapping
        Dim param As DbParameter

        mapa = New DataTableMapping("Table", "terminosIne")
        mapa.ColumnMappings.Add("id", "Id")
        mapa.ColumnMappings.Add("cpro", "Cpro")
        mapa.ColumnMappings.Add("cmun", "Cmun")
        mapa.ColumnMappings.Add("nombre", "Nombre")

        Me._adpt.TableMappings.Add(mapa)

        cmd = cdatos.CreateCommand
        cmd.Connection = _conexion
        cmd.CommandText = "insert into todos_terminos (cpro,cmun,nombre) value(:cpro,:cmun,:nombre)"

        Me._adpt.InsertCommand = cmd

        cmd = cdatos.CreateCommand
        cmd.Connection = _conexion
        cmd.CommandText = "update todos_terminos set cpro=:cpro,cmun=:cmun,nombre=:nombre where id=:id"

        Me._adpt.UpdateCommand = cmd


        cmd = cdatos.CreateCommand
        cmd.Connection = _conexion
        cmd.CommandText = "delete from todos_terminos where id=:id"

        Me._adpt.DeleteCommand = cmd

        param = cdatos.CreateParameter
        param.ParameterName = ":id"
        param.SourceColumn = "id"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.DeleteCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":cpro"
        param.SourceColumn = "cpro"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":cmun"
        param.SourceColumn = "cmun"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":nombre"
        param.SourceColumn = "nombre"
        param.DbType = DbType.String

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

    End Sub
    Public Sub New()
        _clearBeforeFill = True
        cdatos = New CBaseDatos
        _conexion = cdatos.GetConnection
        _adpt = cdatos.CreateDataAdapter
        inicia_datos()
        inicia_Comandos()

    End Sub
End Class
