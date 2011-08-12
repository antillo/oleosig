Option Strict Off
Option Explicit On
Imports System.Data.Common
Imports System.ComponentModel

Public Class aclaradoresTableAdapter




    Private _idalmazara As Integer = 0
    Private conexion As DbConnection
    Private _adpt As DbDataAdapter
    Private cdatos As CBaseDatos
    Private _clearbeforeFill As Boolean

    Public Function GetData() As oleosigDB.aclaradoresDataTable
        Dim tabla As New oleosigDB.aclaradoresDataTable
        Me._adpt.Fill(tabla)
        Return tabla
    End Function

    Public Function Fill(ByVal tabla As oleosigDB.aclaradoresDataTable) As Integer
        If _clearbeforeFill Then
            tabla.Clear()
        End If
        Return Me._adpt.Fill(tabla)
    End Function

    Public Function Update(ByVal tabla As oleosigDB.aclaradoresDataTable) As Integer

        Return Me._adpt.Update(tabla)

    End Function

    Private Sub inicia_datos()
        Dim cmd As DbCommand

        Dim param As DbParameter
        Dim tablemapper As DataTableMapping

        Me._adpt = Me.cdatos.CreateDataAdapter

        tablemapper = New DataTableMapping("Table", "aclaradores")
        tablemapper.ColumnMappings.Add("id", "Id")
        tablemapper.ColumnMappings.Add("idalmazara", "Idalmazara")
        tablemapper.ColumnMappings.Add("numero", "Numero")
        tablemapper.ColumnMappings.Add("nombre", "Nombre")
        tablemapper.ColumnMappings.Add("capacidad", "Capacidad")

        Me._adpt.TableMappings.Add(tablemapper)

        cmd = Me.cdatos.CreateCommand()

        cmd.CommandText = "select * from aclaradores where idalmazara=:idalmazara"
        cmd.Connection = Me.conexion

        Me._adpt.SelectCommand = cmd


        cmd = Me.cdatos.CreateCommand()

        cmd.CommandText = "insert into aclaradores (idalmazara,numero,nombre,capacidad) values(:idalmazara,:numero,:nombre,:capacidad)"
        cmd.Connection = Me.conexion

        Me._adpt.InsertCommand = cmd


        cmd = Me.cdatos.CreateCommand()

        cmd.CommandText = "update aclaradores set numero=:numero, nombre=:nombre, capacidad=:capacidad where id=:id"
        cmd.Connection = Me.conexion

        Me._adpt.UpdateCommand = cmd

        cmd = Me.cdatos.CreateCommand()

        cmd.CommandText = "delete from aclaradores where id=:id"
        cmd.Connection = Me.conexion
        Me._adpt.DeleteCommand = cmd


        param = Me.cdatos.CreateParameter
        param.DbType = DbType.Int32
        param.ParameterName = ":id"
        param.SourceColumn = "id"


        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.DeleteCommand.Parameters.Add(param)


        param = Me.cdatos.CreateParameter
        param.DbType = DbType.Int32
        param.ParameterName = ":idalmazara"
        param.SourceColumn = "idalmazara"
        param.Value = Me._idalmazara

        Me._adpt.SelectCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)



        param = Me.cdatos.CreateParameter
        param.DbType = DbType.Int32
        param.ParameterName = ":codigo"
        param.SourceColumn = "codigo"

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)



        param = Me.cdatos.CreateParameter
        param.DbType = DbType.String
        param.ParameterName = ":nombre"
        param.SourceColumn = "nombre"

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)


        param = Me.cdatos.CreateParameter
        param.DbType = DbType.Int64
        param.ParameterName = ":capacidad"
        param.SourceColumn = "capacidad"

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)



    End Sub




    Public Sub New(ByVal idalmazara As Integer)

        MyBase.New()
        Me.cdatos = New CBaseDatos
        Me.conexion = Me.cdatos.GetConnection
        Me._idalmazara = idalmazara
        Me._clearbeforeFill = True

        inicia_datos()

    End Sub



    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub
End Class