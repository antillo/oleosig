Imports System.Data.Common
Imports System.ComponentModel

Public Class detallesOpBdgTableAdapter

    Private cdatos As CBaseDatos
    Private _conexion As DbConnection
    Private _adpt As DbDataAdapter
    Private _clearBeforeFill As Boolean
    Private _comandos As List(Of DbCommand)
    Private _idalmazara As Integer
    Private _campagna As Integer

    Public Function Delete(ByVal id As Integer) As Integer
        Me._adpt.DeleteCommand.Parameters(":id").Value = CType(id, Integer)

        Dim estadoanterior As ConnectionState = Me._adpt.DeleteCommand.Connection.State

        If (estadoanterior And ConnectionState.Open) <> ConnectionState.Open Then
            Me._adpt.DeleteCommand.Connection.Open()
        End If
        Dim result As Integer = Me._adpt.DeleteCommand.ExecuteNonQuery()

        If estadoanterior = ConnectionState.Closed Then
            Me._adpt.DeleteCommand.Connection.Close()
        End If
        Return result
    End Function

    Public Function Update(ByVal oleosig As oleosigDB) As Integer
        Return Me._adpt.Update(oleosig, "detalles_opbodega")
    End Function

    Public Function Update(ByVal tabla As oleosigDB.detalles_opbodegaDataTable) As Integer
        Return Me._adpt.Update(tabla)
    End Function

    Public Function Update(ByVal filas() As oleosigDB.detalles_opbodegaRow) As Integer
        Return Me._adpt.Update(filas)
    End Function

    Public Function Update(ByVal fila As oleosigDB.detalles_opbodegaRow) As Integer
        Return Me._adpt.Update(New DataRow() {fila})
    End Function


    Public Function Insert(ByVal idalmazara As Integer, ByVal opbodega As Integer, ByVal opfabrica As Integer, ByVal opaclarado As Integer, ByVal opfiltrado As Integer, ByVal kilos As Integer, ByVal campaña As Integer) As Integer
        Me._adpt.InsertCommand.Parameters(":idalmazara").Value = CType(idalmazara, Integer)
        Me._adpt.InsertCommand.Parameters(":opbodega").Value = CType(opbodega, Integer)
        Me._adpt.InsertCommand.Parameters(":opfabrica").Value = CType(opfabrica, Integer)
        Me._adpt.InsertCommand.Parameters(":opaclarado").Value = CType(opaclarado, Integer)
        Me._adpt.InsertCommand.Parameters(":opfiltrado").Value = CType(opfiltrado, Integer)
        Me._adpt.InsertCommand.Parameters(":kilos").Value = CType(kilos, Integer)
        Me._adpt.InsertCommand.Parameters(":campagna").Value = CType(campaña, Integer)

        Dim estadoanterior As ConnectionState = Me._adpt.InsertCommand.Connection.State

        If (estadoanterior And ConnectionState.Open) <> ConnectionState.Open Then
            Me._adpt.InsertCommand.Connection.Open()
        End If

        Dim result As Integer = Me._adpt.InsertCommand.ExecuteNonQuery()

        If estadoanterior = ConnectionState.Closed Then
            Me._adpt.InsertCommand.Connection.Close()
        End If

        Return result

    End Function

    Public Function GetData() As oleosigDB.detalles_opbodegaDataTable
        Dim tabla As New oleosigDB.detalles_opbodegaDataTable
        Me._adpt.SelectCommand = _comandos(0)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(Me._idalmazara, Integer)
        Me._adpt.SelectCommand.Parameters(":campagna").Value = CType(Me._campagna, Integer)

        Me._adpt.Fill(tabla)

        Return tabla

    End Function

    Public Function Fill(ByVal tabla As oleosigDB.detalles_opbodegaDataTable) As Integer
        If _clearBeforeFill Then
            tabla.Clear()
        End If
        Me._adpt.SelectCommand = _comandos(0)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(_idalmazara, Integer)
        Me._adpt.SelectCommand.Parameters(":campagna").Value = CType(Me._campagna, Integer)

        Return Me._adpt.Fill(tabla)

    End Function

    Private Sub inicia_datos()
        Dim cmd As DbCommand
        Dim param As DbParameter
        Dim datamaper As DataTableMapping
        Dim strsql As New System.Text.StringBuilder

        datamaper = New DataTableMapping("Table", "detalles_opbodega")
        datamaper.ColumnMappings.Add("id", "Id")
        datamaper.ColumnMappings.Add("idalmazara", "Idalmazara")
        datamaper.ColumnMappings.Add("opbodega", "Opbodega")
        datamaper.ColumnMappings.Add("opfabrica", "Opfabrica")
        datamaper.ColumnMappings.Add("opfiltrado", "Opfiltrado")
        datamaper.ColumnMappings.Add("opaclarado", "Opaclarado")
        datamaper.ColumnMappings.Add("kilos", "Kilos")
        datamaper.ColumnMappings.Add("campagna", "Campaña")

        Me._adpt.TableMappings.Add(datamaper)

        strsql.Length = 0

        strsql.Append("insert into detalles_opbodega (")
        strsql.Append("opbodega,")
        strsql.Append("opfabrica,")
        strsql.Append("opfiltrado,")
        strsql.Append("opaclarado,")
        strsql.Append("kilos,")
        strsql.Append("campagna,idalmazara) values (")
        strsql.Append(":opbodega,")
        strsql.Append(":opfabrica,")
        strsql.Append(":opfiltrado,")
        strsql.Append(":opaclarado,")
        strsql.Append(":kilos,")
        strsql.Append(":campagna,")
        strsql.Append(":idalmazara)")

        cmd = cdatos.CreateCommand
        cmd.Connection = _conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.InsertCommand = cmd

        strsql.Length = 0
        strsql.Append("update detalles_opbodega set ")
        strsql.Append("opbodega=:opbodega,")
        strsql.Append("opfabrica=:opfabrica,")
        strsql.Append("opfiltrado=:opfiltrado,")
        strsql.Append("opaclarado=:opaclarado,")
        strsql.Append("kilos=:kilos,")
        strsql.Append("campagna=:campagna,")
        strsql.Append("idalmazara=:idalmazara ")
        strsql.Append("where id=:id")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.UpdateCommand = cmd

        strsql.Length = 0
        strsql.Append("delete from detalles_opbodega where id=:id")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.DeleteCommand = cmd

        param = cdatos.CreateParameter
        param.ParameterName = ":id"
        param.SourceColumn = "id"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.DeleteCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":idalmazara"
        param.SourceColumn = "idalmazara"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":opbodega"
        param.SourceColumn = "opbodega"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":opfabrica"
        param.SourceColumn = "opfabrica"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)


        param = cdatos.CreateParameter
        param.ParameterName = ":opfiltrado"
        param.SourceColumn = "opfiltrado"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":opaclarado"
        param.SourceColumn = "opaclarado"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":kilos"
        param.SourceColumn = "kilos"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":campagna"
        param.SourceColumn = "campagna"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

    End Sub
    Private Sub inicia_comandos()
        Dim cmd As DbCommand
        Dim param As DbParameter
        Dim strsql As New System.Text.StringBuilder


        _comandos = New List(Of DbCommand)

        strsql.Append("select * from detalles_opbodega where idalmazara=:idalmazara and campagna=:campagna order by id")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = strsql.ToString

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

    Public Sub New(ByVal idalmazara As Integer, ByVal campaña As Integer)
        Me._idalmazara = idalmazara
        Me._campagna = campaña
        Me._clearBeforeFill = True

        cdatos = New CBaseDatos
        _conexion = cdatos.GetConnection
        _adpt = cdatos.CreateDataAdapter
        inicia_datos()
        inicia_comandos()
    End Sub
End Class
