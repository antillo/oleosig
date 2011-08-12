Option Strict Off
Option Explicit On

Imports System.Data.Common

Public Class filtroTableAdapter


    Private _idalmazara As Integer
    Private conexion As DbConnection
    Private cdatos As CBaseDatos
    Private _adpt As DbDataAdapter
    Private _listacomandos As List(Of DbCommand)
    Private _clearBeforeFill As Boolean


    Public Overridable Overloads Function Update(ByVal tabla As oleosigDB.clientesDataTable) As Integer
        Return Me._adpt.Update(tabla)
    End Function

    Public Overridable Overloads Function GetData() As oleosigDB.clientesDataTable
        Dim tabla As New oleosigDB.clientesDataTable

        Me._adpt.SelectCommand = _listacomandos(0)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(_idalmazara, Integer)
        Me._adpt.Fill(tabla)

        Return tabla

    End Function

    Public Overridable Overloads Function Fill(ByVal tabla As oleosigDB.filtrosDataTable) As Integer
        If _clearBeforeFill Then
            tabla.Clear()
        End If
        Me._adpt.SelectCommand = _listacomandos(0)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(_idalmazara, Integer)

        Return Me._adpt.Fill(tabla)

    End Function

    Private Sub inicia_comandos()
        Dim strsql As String
        Dim cmd As System.Data.Common.DbCommand
        Dim param As DbParameter

        _listacomandos = New List(Of DbCommand)

        strsql = "select * from filtros where idalmazara =:idalmazara"

        cmd = Me.cdatos.CreateCommand()
        cmd.CommandText = strsql
        cmd.Connection = Me.conexion

        param = cdatos.CreateParameter
        param.ParameterName = ":idalmazara"
        param.SourceColumn = "idalmazara"
        param.DbType = DbType.Int32

        cmd.Parameters.Add(param)

        _listacomandos.Add(cmd)

    End Sub


    Private Sub inicia_datos()
        Dim strsql As String
        Dim cmd As System.Data.Common.DbCommand
        Dim param As DbParameter
        Dim mapa As DataTableMapping

        mapa = New DataTableMapping("Table", "filtros")
        mapa.ColumnMappings.Add("id", "Id")
        mapa.ColumnMappings.Add("idalmazara", "Idalmazara")
        mapa.ColumnMappings.Add("numero", "Numero")
        mapa.ColumnMappings.Add("nombre", "Nombre")
        mapa.ColumnMappings.Add("capacidad", "Capacidad")

        Me._adpt.TableMappings.Add(mapa)


        strsql = "insert into filtros (idalmazara,numero,nombre,capacidad) values(:idalmazara,:numero,:nombre,:capacidad)"

        cmd = Me.cdatos.CreateCommand()
        cmd.CommandText = strsql
        cmd.Connection = Me.conexion

        Me._adpt.InsertCommand = cmd

        strsql = "update filtros set idalmazara=:idalmzara, numero=:numero, nombre=:nombre, capacidad=:capacidad where id=:id"

        cmd = Me.cdatos.CreateCommand()
        cmd.CommandText = strsql
        cmd.Connection = Me.conexion

        Me._adpt.UpdateCommand = cmd

        strsql = "delete from filtros where id=:id"

        cmd = Me.cdatos.CreateCommand()
        cmd.CommandText = strsql
        cmd.Connection = Me.conexion

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
        param.ParameterName = ":numero"
        param.SourceColumn = "numero"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":nombre"
        param.SourceColumn = "nombre"
        param.DbType = DbType.String

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":capacidad"
        param.SourceColumn = "capacidad"
        param.DbType = DbType.Int64

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

    End Sub


    Public Sub New(ByVal idalmazara As Integer)
        MyBase.New()
        Me._idalmazara = idalmazara
        Me.cdatos = New CBaseDatos
        Me._clearBeforeFill = True
        Me.conexion = Me.cdatos.GetConnection
        Me._adpt = Me.cdatos.CreateDataAdapter


        inicia_datos()
        inicia_comandos()

    End Sub


    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub
End Class