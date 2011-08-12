Imports System.Data.Common
Imports System.Text
Imports System.ComponentModel


Public Class ImportacionTableAdapter


    Private _idalmazara As Integer

    Private cdatos As New CBaseDatos
    Private _conexion As DbConnection
    Private _adpt As DbDataAdapter
    Private _clearBeforeFill As Boolean
    Private _comandos As List(Of DbCommand)




    Private Sub ini_comands()
        Dim cmd As DbCommand
        Dim param As DbParameter

        _comandos = New List(Of DbCommand)

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = "select * from importaciones_ticket where idalmazara=:idalmazara"
        cmd.CommandType = CommandType.Text

        param = cdatos.CreateParameter
        param.DbType = DbType.Int32
        param.SourceColumn = "idalmazara"
        param.ParameterName = ":idalmazara"
        param.Value = CType(Me._idalmazara, Int32)

        cmd.Parameters.Add(param)

        _comandos.Add(cmd)

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = "select max(idconfig) from importaciones_ticket where idalmazara=:idalmazara"
        cmd.CommandType = CommandType.Text

        param = cdatos.CreateParameter
        param.DbType = DbType.Int32
        param.SourceColumn = "idalmazara"
        param.ParameterName = ":idalmazara"
        param.Value = CType(Me._idalmazara, Int32)

        cmd.Parameters.Add(param)

        _comandos.Add(cmd)


    End Sub
    Public Function GetLastNumimportacion() As Integer
        Dim valordevuelto As Integer

        Me._adpt.SelectCommand = _comandos(1)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(Me._idalmazara, Integer)
        Dim estadoanterior As ConnectionState = Me._adpt.SelectCommand.Connection.State
        If (estadoanterior And ConnectionState.Open) <> ConnectionState.Open Then
            Me._adpt.SelectCommand.Connection.Open()
        End If
        Dim result As Object = Me._adpt.SelectCommand.ExecuteScalar()
        If result Is Nothing Then
            valordevuelto = 0
        Else
            If IsDBNull(result) Then
                valordevuelto = 0
            Else
                valordevuelto = CType(result, Integer)
            End If

        End If
        Return valordevuelto
    End Function
    Public Function GetData() As oleosigDB.importaciones_ticketDataTable
        Dim tabla As oleosigDB.importaciones_ticketDataTable = New oleosigDB.importaciones_ticketDataTable()
        Me._adpt.Fill(tabla)
        Return tabla
    End Function
    Public Function Fill(ByVal tabla As oleosigDB.importaciones_ticketDataTable) As Integer

        Me._adpt.SelectCommand = _comandos(0)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(Me._idalmazara, Int32)

        If _clearBeforeFill Then
            tabla.Clear()
        End If
        Dim result As Integer = Me._adpt.Fill(tabla)
        Return result
    End Function

    Public Sub Delete(ByVal importacion As Integer)

        Me._adpt.DeleteCommand.Parameters(":id").Value = CType(importacion, Integer)
        Dim estadoant As ConnectionState = Me._adpt.DeleteCommand.Connection.State

        If (estadoant And ConnectionState.Open) <> ConnectionState.Open Then
            Me._adpt.DeleteCommand.Connection.Open()
        End If

        Me._adpt.DeleteCommand.ExecuteNonQuery()

        If estadoant = ConnectionState.Closed Then
            Me._adpt.DeleteCommand.Connection.Close()
        End If

    End Sub
    Public Overridable Overloads Function Update(ByVal oleosig As oleosigDB) As Integer
        Dim result As Integer = Me._adpt.Update(oleosig, "importaciones_ticket")
        Return result
    End Function
    Public Overridable Overloads Function Update(ByVal importacion As oleosigDB.importaciones_ticketDataTable) As Integer
        Dim result As Integer = Me._adpt.Update(importacion)
        Return result
    End Function


    Private Sub ini_adapt()
        Dim cmd As DbCommand
        Dim datamapping As DataTableMapping
        Dim param As DbParameter
        Dim strsql As New System.Text.StringBuilder

        datamapping = New DataTableMapping("Table", "importaciones_ticket")
        datamapping.ColumnMappings.Add("id", "id")
        datamapping.ColumnMappings.Add("idalmazara", "idalmazara")
        datamapping.ColumnMappings.Add("idconfig", "idconfig")
        datamapping.ColumnMappings.Add("nombre", "nombre")
        datamapping.ColumnMappings.Add("tipo", "tipo")
        datamapping.ColumnMappings.Add("pesaje", "pesaje")
        datamapping.ColumnMappings.Add("delimitador", "delimitador")

        Me._adpt.TableMappings.Add(datamapping)

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = "delete from importaciones_ticket where id=:id"

        Me._adpt.DeleteCommand = cmd

        strsql.Length = 0
        strsql.Append("insert into importaciones_ticket (idalmazara,idconfig,nombre,tipo,pesaje,delimitador) values(:idalmazara,:idconfig,:nombre,:tipo,:pesaje,:delimitador)")


        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.InsertCommand = cmd

        strsql.Length = 0
        strsql.Append("update importaciones_ticket set ")
        strsql.Append("idconfig=:idconfig,")
        strsql.Append("nombre=:nombre,")
        strsql.Append("tipo=:tipo,")
        strsql.Append("pesaje=:pesaje,")
        strsql.Append("delimitador=:delimitador ")
        strsql.Append("where id=:id")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.UpdateCommand = cmd

        param = cdatos.CreateParameter
        param.DbType = DbType.Int32
        param.SourceColumn = "id"
        param.ParameterName = ":id"

        Me._adpt.DeleteCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.DbType = DbType.Int32
        param.SourceColumn = "idalmazara"
        param.ParameterName = ":idalmazara"
        param.Value = CType(Me._idalmazara, Int32)

        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.DbType = DbType.Int32
        param.SourceColumn = "idconfig"
        param.ParameterName = ":idconfig"

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.DbType = DbType.String
        param.SourceColumn = "nombre"
        param.ParameterName = ":nombre"

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.DbType = DbType.Int32
        param.SourceColumn = "tipo"
        param.ParameterName = ":tipo"

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.DbType = DbType.Int32
        param.SourceColumn = "pesaje"
        param.ParameterName = ":pesaje"

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.DbType = DbType.String
        param.SourceColumn = "delimitador"
        param.ParameterName = ":delimitador"

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

    End Sub
    Public Sub New(ByVal idalmazara As Integer)
        Me._idalmazara = idalmazara
        Me._conexion = cdatos.GetConnection
        Me._adpt = cdatos.CreateDataAdapter

        Me.ini_adapt()
        Me.ini_comands()

    End Sub

End Class
