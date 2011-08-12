Imports System.ComponentModel
Imports System.Data.Common

Public Class detallesLoteAceiteTableAdapter


    Private _campagna As Byte
    Private _idalmazara As Integer
    Private _conexion As DbConnection
    Private WithEvents _adpt As DbDataAdapter
    Private cdatos As CBaseDatos
    Private _comandos As List(Of DbCommand)

    Private _clearBeforeFill As Boolean


    Public Overridable Overloads Function Insert(ByVal idalmazara As Integer, ByVal kilos As Integer, ByVal lote As Integer, ByVal opbdg As Integer, ByVal campaña As Integer) As Integer
        Me._adpt.InsertCommand.Parameters(":idalmazara").Value = CType(idalmazara, Integer)
        Me._adpt.InsertCommand.Parameters(":kilos").Value = CType(kilos, Integer)
        Me._adpt.InsertCommand.Parameters(":loteaceite").Value = CType(lote, Integer)
        Me._adpt.InsertCommand.Parameters(":opbodega").Value = CType(opbdg, Integer)
        Me._adpt.InsertCommand.Parameters(":campagna").Value = CType(campaña, Integer)

        Dim estado As ConnectionState = Me._adpt.InsertCommand.Connection.State
        If (estado And ConnectionState.Open) <> ConnectionState.Open Then
            Me._adpt.InsertCommand.Connection.Open()
        End If
        Dim result As Integer = Me._adpt.InsertCommand.ExecuteNonQuery()
        If estado = ConnectionState.Closed Then
            Me._adpt.InsertCommand.Connection.Close()
        End If
        Return result
    End Function

    Public Overridable Overloads Function Update(ByVal dt As oleosigDB) As Integer
        Return Me._adpt.Update(dt, "detalles_loteaceite")
    End Function

    Public Overridable Overloads Function Update(ByVal fila() As oleosigDB.detalles_loteaceiteRow) As Integer
        Return Me._adpt.Update(fila)
    End Function

    Public Overridable Overloads Function Update(ByVal tabla As oleosigDB.detalles_loteaceiteDataTable) As Integer
        Return Me._adpt.Update(tabla)
    End Function


    Public Function Fill(ByVal tabla As oleosigDB.detalles_loteaceiteDataTable) As Integer
        If _clearBeforeFill Then
            tabla.Clear()
        End If
        Me._adpt.SelectCommand = _comandos(0)
        Me._adpt.SelectCommand.Parameters(":campagna").Value = CType(Me._campagna, Integer)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(Me._idalmazara, Integer)

        Dim rslt As Integer = Me._adpt.Fill(tabla)
        Return rslt

    End Function

    Private Sub inicia_datos()
        Dim strsql As New System.Text.StringBuilder
        Dim cmd As DbCommand
        Dim param As DbParameter
        Dim datamaper As DataTableMapping

        Me._adpt = cdatos.CreateDataAdapter

        datamaper = New DataTableMapping("Table", "detalles_loteaceite")
        datamaper.ColumnMappings.Add("id", "Id")
        datamaper.ColumnMappings.Add("loteaceite", "Loteaceite")
        datamaper.ColumnMappings.Add("opbodega", "Opbodega")
        datamaper.ColumnMappings.Add("kilos", "Kilos")
        datamaper.ColumnMappings.Add("idalmazara", "Idalmazara")
        datamaper.ColumnMappings.Add("campagna", "Campaña")

        Me._adpt.TableMappings.Add(datamaper)

        strsql.Length = 0
        strsql.Append("insert into detalles_loteaceite (loteaceite,opbodega,kilos,idalmazara,campagna) values(")
        strsql.Append(":loteaceite,:opbodega,:kilos,:idalmazara,:campagna)")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.InsertCommand = cmd

        strsql.Length = 0
        strsql.Append("update detalles_loteaceite set ")
        strsql.Append("loteaceite=:loteaceite,")
        strsql.Append("opbodega=:opbodega,")
        strsql.Append("kilos=:kilos,")
        strsql.Append("idalmazara=:idalmazara,")
        strsql.Append("campagna=:campagna ")
        strsql.Append("where id=:id")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.UpdateCommand = cmd


        strsql.Length = 0
        strsql.Append("delete from detalles_loteaceite where id=:id")

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

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":loteaceite"
        param.SourceColumn = "loteaceite"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":kilos"
        param.SourceColumn = "kilos"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":opbodega"
        param.SourceColumn = "opbodega"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":campagna"
        param.SourceColumn = "campagna"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

    End Sub

    Private Sub inicia_comandos()
        Dim strsql As New System.Text.StringBuilder
        Dim cmd As DbCommand
        Dim param As DbParameter

        _comandos = New List(Of DbCommand)

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from detalles_loteaceite where campagna=:campagna and idalmazara=:idalmazara"

        param = cdatos.CreateParameter
        param.ParameterName = ":campagna"
        param.SourceColumn = "campagna"
        param.DbType = DbType.Int32

        cmd.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":idalmazara"
        param.SourceColumn = "idalmazara"
        param.DbType = DbType.Int32

        cmd.Parameters.Add(param)

        _comandos.Add(cmd)



    End Sub
    Public Sub New(ByVal idalmazara As Integer, ByVal campaña As Integer)
        Me._campagna = campaña
        Me._idalmazara = idalmazara

        cdatos = New CBaseDatos
        _conexion = cdatos.GetConnection

        inicia_datos()
        inicia_comandos()

    End Sub
End Class
