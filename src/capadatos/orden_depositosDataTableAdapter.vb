Imports System.Data.Common

Public Class orden_depositosDataTableAdapter



    Private _idalmazara As Integer
    Private _adpt As DbDataAdapter
    Private _conexion As DbConnection
    Private cdatos As New CBaseDatos
    Private _clearBeforeFill As Boolean

    Public Overridable Overloads Function Fill(ByVal tabla As oleosigDB.orden_depositosDataTable) As Integer
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(_idalmazara, Integer)
        If _clearBeforeFill Then
            tabla.Clear()
        End If
        Return Me._adpt.Fill(tabla)
    End Function

    Public Overridable Overloads Function GetData() As oleosigDB.orden_depositosDataTable
        Dim tabla As oleosigDB.orden_depositosDataTable = New oleosigDB.orden_depositosDataTable()
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(_idalmazara, Integer)
        Me._adpt.Fill(tabla)
        Return tabla
    End Function

    Public Overridable Overloads Function Update(ByVal dt As oleosigDB) As Integer
        Return Me._adpt.Update(dt, "orden_depositos")
    End Function
    Public Overridable Overloads Function Update(ByVal tabla As oleosigDB.orden_depositosDataTable) As Integer
        Return Me._adpt.Update(tabla)
    End Function
    Public Overridable Overloads Function Update(ByVal filas() As oleosigDB.orden_depositosRow) As Integer
        Return Me._adpt.Update(filas)
    End Function
    Public Overridable Overloads Function Update(ByVal fila As oleosigDB.orden_depositosRow) As Integer
        Return Me._adpt.Update(New DataRow() {fila})
    End Function

    Private Sub inicia_datos()
        Dim strsql As String
        Dim cmd As DbCommand
        Dim param As DbParameter


        strsql = "select * from orden_depositos where idalmazara =:idalmazara order by deposito"
        cmd = Me.cdatos.CreateCommand()
        cmd.CommandText = strsql
        cmd.Connection = Me._conexion
        Me._adpt.SelectCommand = cmd

        strsql = "insert into orden_depositos (idalmazara,deposito,limite) values(:idalmazara,:deposito,:limite)"
        cmd = Me.cdatos.CreateCommand
        cmd.CommandText = strsql
        cmd.Connection = Me._conexion

        Me._adpt.InsertCommand = cmd


        strsql = "update orden_depositos set idalmazara=:idalmazara,deposito=:deposito,limite=:limite where id=:id"
        cmd = Me.cdatos.CreateCommand
        cmd.CommandText = strsql
        cmd.Connection = Me._conexion
        Me._adpt.UpdateCommand = cmd

        strsql = "delete from orden_depositos where id=:id"
        cmd = Me.cdatos.CreateCommand
        cmd.CommandText = strsql
        cmd.Connection = Me._conexion
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

        Me._adpt.SelectCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":deposito"
        param.SourceColumn = "deposito"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":limite"
        param.SourceColumn = "limite"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

    End Sub


    Public Sub New(ByVal idalmazara As Integer)
        MyBase.New()
        Me._idalmazara = idalmazara
        Me._conexion = cdatos.GetConnection
        Me._adpt = cdatos.CreateDataAdapter
        _clearBeforeFill = True


        Me.inicia_datos()
    End Sub
End Class
