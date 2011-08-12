Imports System.Data
Imports System.Data.Common

Public Class detallesPartidasAceiteTablaAdapter
    Private _adpt As DbDataAdapter
    Private cdatos As New CBaseDatos
    Private _idalmazara As Integer
    Private _campagna As Integer
    Private _clearBeforeFill As Boolean
    Private _comandos As List(Of DbCommand)
    Private _conexion As DbConnection

    Public Overridable Overloads Function Update(ByVal fila As oleosigDB.detalles_partidasaceiteRow) As Integer
        Return Me._adpt.Update(New DataRow() {fila})
    End Function

    Public Overridable Overloads Function Update(ByVal filas() As oleosigDB.detalles_partidasaceiteRow) As Integer
        Return Me._adpt.Update(filas)
    End Function
    Public Overridable Overloads Function Update(ByVal dt As oleosigDB) As Integer
        Return Me._adpt.Update(dt, "detalles_partidasaceite")
    End Function

    Public Overridable Overloads Function Update(ByVal tabla As oleosigDB.detalles_partidasaceiteDataTable) As Integer
        Return Me._adpt.Update(tabla)
    End Function
    Public Overridable Overloads Function GetData() As oleosigDB.detalles_partidasaceiteDataTable
        Dim tabla As New oleosigDB.detalles_partidasaceiteDataTable

        Me._adpt.SelectCommand = Me._comandos(0)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(Me._idalmazara, Integer)
        Me._adpt.SelectCommand.Parameters(":campagna").Value = CType(Me._campagna, Integer)

        Me._adpt.Update(tabla)
        Return tabla
    End Function
    Public Overridable Overloads Function Fill(ByVal tabla As oleosigDB.detalles_partidasaceiteDataTable) As Integer
        If _clearBeforeFill Then
            tabla.Clear()
        End If
        Me._adpt.SelectCommand = _comandos(0)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(Me._idalmazara, Integer)
        Me._adpt.SelectCommand.Parameters(":campagna").Value = CType(Me._campagna, Integer)

        Dim rslt As Integer = Me._adpt.Fill(tabla)
        Return rslt

    End Function

    Private Sub inicia_comandos()
        Dim cmd As DbCommand
        Dim param As DbParameter

        _comandos = New List(Of DbCommand)

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = "select * from detalles_partidasaceite where idalmazara=:idalmazara and campagna=:campagna"

        param = cdatos.CreateParameter
        param.ParameterName = ":idalmazara"
        param.SourceColumn = "idalmazara"
        param.DbType = DbType.Int32

        cmd.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":campagna"
        param.SourceColumn = "campagna"
        param.DbType = DbType.Int32

        cmd.Parameters.Add(param)

        _comandos.Add(cmd)




    End Sub
    Private Sub inicia_datos()
        Dim cmd As DbCommand
        Dim param As DbParameter
        Dim strsql As New System.Text.StringBuilder
        Dim datamaper As DataTableMapping

        datamaper = New DataTableMapping("Table", "detalles_partidasaceite")
        datamaper.ColumnMappings.Add("id", "Id")
        datamaper.ColumnMappings.Add("idalmazara", "Idalmazara")
        datamaper.ColumnMappings.Add("partida", "Idpartida")
        datamaper.ColumnMappings.Add("loteaceite", "Lote")
        datamaper.ColumnMappings.Add("campagna", "Campaña")
        datamaper.ColumnMappings.Add("kilos", "Kilos")

        Me._adpt.TableMappings.Add(datamaper)

        strsql.Append("insert into detalles_partidasaceite (idalmazara,partida,loteaceite,campagna,kilos) values")
        strsql.Append("(:idalmazara,:partida,:loteaceite,:campagna,:kilos)")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.InsertCommand = cmd

        strsql.Length = 0
        strsql.Append("update detalles_partidasaceite set ")
        strsql.Append("idalmazara=:idalmazara,")
        strsql.Append("partida=:partida,")
        strsql.Append("loteaceite=:loteaceite,")
        strsql.Append("campagna=:campagna,")
        strsql.Append("kilos=:kilos where id=:id")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.UpdateCommand = cmd

        strsql.Length = 0
        strsql.Append("delete from detalles_partidasaceite where id=:id")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.DeleteCommand = cmd

        param = cdatos.CreateParameter()
        param.ParameterName = ":id"
        param.SourceColumn = "id"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.DeleteCommand.Parameters.Add(param)

        param = cdatos.CreateParameter()
        param.ParameterName = ":idalmazara"
        param.SourceColumn = "idalmazara"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)


        param = cdatos.CreateParameter()
        param.ParameterName = ":partida"
        param.SourceColumn = "partida"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter()
        param.ParameterName = ":loteaceite"
        param.SourceColumn = "loteaceite"
        param.DbType = DbType.Int32


        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter()
        param.ParameterName = ":campagna"
        param.SourceColumn = "campagna"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter()
        param.ParameterName = ":kilos"
        param.SourceColumn = "kilos"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

    End Sub

    Public Sub New(ByVal idalmazara As Integer, ByVal campaña As Integer)
        _idalmazara = idalmazara
        _campagna = campaña
        _clearBeforeFill = True
        _conexion = cdatos.GetConnection
        _adpt = cdatos.CreateDataAdapter

        inicia_datos()
        inicia_comandos()

    End Sub
End Class
