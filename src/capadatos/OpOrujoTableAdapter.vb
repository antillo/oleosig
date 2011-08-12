Option Strict Off
Option Explicit On
Imports System.Data.Common

Public Class OpOrujoTableAdapter


    Private _idalmazara As Integer
    Private _campagna As Byte
    Private cdatos As New CBaseDatos
    Private _adpt As DbDataAdapter
    Private _conexion As DbConnection
    Private _listacomandos As List(Of DbCommand)
    Private _clearBeforeFill As Boolean

    Public Sub Delete(ByVal Id As UShort)
        Dim strSql As String



        strSql = "delete from oporujos where id='" & Id.ToString & "'"

        cDatos.Haz(strSql)


    End Sub

    Public Overridable Overloads Function Update(ByVal tabla As oleosigDB.oporujoDataTable) As Integer

        Return Me._adpt.Update(tabla)

    End Function

    Public Sub Insertar(ByVal idalmazara As Integer, ByVal idconductor As Integer, ByVal idvehiculo As Integer, ByVal fecha As Date, ByVal pesobruto As Integer, ByVal tara As Integer, ByVal campagna As Integer)



        Me._adpt.InsertCommand.Parameters(":idalmazara").Value = CType(idalmazara, Integer)
        Me._adpt.InsertCommand.Parameters(":idconductor").Value = CType(idconductor, Integer)
        Me._adpt.InsertCommand.Parameters(":idvehiculo").Value = CType(idvehiculo, Integer)
        Me._adpt.InsertCommand.Parameters(":fecha").Value = CType(fecha, Date)
        Me._adpt.InsertCommand.Parameters(":pesobruto").Value = CType(pesobruto, Integer)
        Me._adpt.InsertCommand.Parameters(":tara").Value = CType(tara, Integer)
        Me._adpt.InsertCommand.Parameters(":campagna").Value = CType(campagna, Integer)

        Dim estadoanterior As ConnectionState
        estadoanterior = Me._adpt.InsertCommand.Connection.State

        If (estadoanterior And ConnectionState.Open) <> ConnectionState.Open Then
            Me._adpt.InsertCommand.Connection.Open()
        End If

        Me._adpt.InsertCommand.ExecuteNonQuery()


    End Sub
    Public Overridable Overloads Function Fill(ByVal tabla As oleosigDB.oporujoDataTable) As Integer
        If _clearBeforeFill Then
            tabla.Clear()
        End If

        Me._adpt.SelectCommand = _listacomandos(0)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(_idalmazara, Integer)
        Me._adpt.SelectCommand.Parameters(":campagna").Value = CType(_campagna, Integer)

        Return Me._adpt.Fill(tabla)

    End Function
    Public Function GetData() As oleosigDB.oporujoDataTable
        Dim tabla As New oleosigDB.oporujoDataTable
        Me._adpt.SelectCommand = _listacomandos(0)

        Me._adpt.SelectCommand.Parameters(":idalmzara").Value = CType(_idalmazara, Integer)
        Me._adpt.SelectCommand.Parameters(":campagna").Value = CType(_campagna, Integer)

        Me._adpt.Fill(tabla)

        Return tabla

    End Function
    Private Sub inicia_comandos()
        Dim cmd As DbCommand
        Dim param As DbParameter

        _listacomandos = New List(Of DbCommand)

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "select * from oporujos where idalmazara=:idalmazara and campagna=:campagna order by id"

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

        _listacomandos.Add(cmd)

    End Sub
    Private Sub inicia_datos()
        Dim cmd As DbCommand
        Dim param As DbParameter
        Dim mapa As DataTableMapping

        mapa = New DataTableMapping("Table", "oporujo")
        mapa.ColumnMappings.Add("id", "Id")
        mapa.ColumnMappings.Add("idalmazara", "Idalmazara")
        mapa.ColumnMappings.Add("idconductor", "Idconductor")
        mapa.ColumnMappings.Add("idvehiculo", "Idvehiculo")
        mapa.ColumnMappings.Add("fecha", "Fecha")
        mapa.ColumnMappings.Add("pesobruto", "Pesobruto")
        mapa.ColumnMappings.Add("tara", "Tara")
        mapa.ColumnMappings.Add("campagna", "Campagna")

        Me._adpt.TableMappings.Add(mapa)

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = "insert into oporujos (idalmazara,idconductor,idvehiculo,fecha,pesobruto,tara,campagna) values(:idalmazara,:idconductor,:idvehiculo,:fecha,:pesobruto,:tara,:campagna)"

        Me._adpt.InsertCommand = cmd

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = "update oporujos set idalmazara=:idalmzara, idconductor=:idconductor, idvehiculo=:idvehiculo, fecha=:fecha, pesobruto=:pesobruto, tara=:tara, campagna=:campagna where id=:id"

        Me._adpt.UpdateCommand = cmd


        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = "delete from oporujos where id=:id"

        Me._adpt.DeleteCommand = cmd

        param = cdatos.CreateParameter
        param.SourceColumn = "id"
        param.ParameterName = ":id"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.DeleteCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.SourceColumn = "idalmazara"
        param.ParameterName = ":idalmazara"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.SourceColumn = "idconductor"
        param.ParameterName = ":idconductor"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.SourceColumn = "idvehiculo"
        param.ParameterName = ":idvehiculo"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.SourceColumn = "fecha"
        param.ParameterName = ":fecha"
        param.DbType = DbType.Date

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.SourceColumn = "pesobruto"
        param.ParameterName = ":pesobruto"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.SourceColumn = "tara"
        param.ParameterName = ":tara"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.SourceColumn = "campagna"
        param.ParameterName = ":campagna"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

    End Sub

    Public Sub New(ByVal campagna As Byte, ByVal idalmazara As Integer)
        MyBase.New()
        Me._campagna = campagna
        Me._idalmazara = idalmazara
        Me._clearBeforeFill = True
        Me._conexion = cdatos.GetConnection
        Me._adpt = cdatos.CreateDataAdapter
        inicia_datos()
        inicia_comandos()

    End Sub


    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub
End Class