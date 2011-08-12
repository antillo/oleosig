Option Strict Off
Option Explicit On

Imports System.Data.Common

Public Class recoleccionTableAdapter



    Private _idalmazara As Integer

    Private _adapt As DbDataAdapter
    Private _conexion As DbConnection
    Private cdatos As CBaseDatos
    Private _clearBeforeFill As Boolean


    Public Function GetData() As DataTable
        Dim tabla As DataTable = New DataTable("recoleccion")
        Me._adapt.Fill(tabla)
        Return tabla

    End Function
    Public Function Fill(ByVal tabla As oleosigDB.recoleccionDataTable) As Integer
        If Me._clearBeforeFill = True Then
            tabla.Clear()
        End If
        Dim result As Integer = Me._adapt.Fill(tabla)
        Return result
    End Function

    Public Sub Delete(ByVal id As Integer)
        Me._adapt.DeleteCommand.Parameters(0).Value = CType(id, Integer)

        If Me._conexion.State = ConnectionState.Closed Then
            Me._conexion.Open()
        End If
        Me._adapt.DeleteCommand.ExecuteNonQuery()
        Me._conexion.Close()

    End Sub
    Public Overridable Overloads Function Update(ByVal oleosig As oleosigDB) As Integer
        Return Me._adapt.Update(oleosig, "recoleccion")
    End Function
    Public Overridable Overloads Function Update(ByVal tabla As oleosigDB.recoleccionDataTable) As Integer
        Dim result As Integer = Me._adapt.Update(tabla)

        Return result

    End Function


    Private Sub iniciaAdaptador()
        Dim strsql As String

        Dim cmd As DbCommand

        Dim parametro As DbParameter
        Dim tablamapping As DataTableMapping


        tablamapping = New DataTableMapping("Table", "recoleccion")
        tablamapping.ColumnMappings.Add("id", "id")
        tablamapping.ColumnMappings.Add("idalmazara", "idalmazara")
        tablamapping.ColumnMappings.Add("codigo", "codigo")
        tablamapping.ColumnMappings.Add("nombre", "nombre")

        Me._adapt = Me.cdatos.CreateDataAdapter

        Me._adapt.TableMappings.Add(tablamapping)


        strsql = "select * from recoleccion where idalmazara=:idalmazara"
        cmd = Me.cdatos.CreateCommand

        cmd.CommandText = strsql
        cmd.Connection = Me._conexion

        Me._adapt.SelectCommand = cmd


        strsql = "insert into recoleccion (idalmazara,codigo,nombre) values(:idalmazara,:codigo,:nombre)"

        cmd = Me.cdatos.CreateCommand
        cmd.CommandText = strsql
        cmd.Connection = Me._conexion

        Me._adapt.InsertCommand = cmd

        strsql = "delete from recoleccion where id=:id"
        cmd = Me.cdatos.CreateCommand
        cmd.CommandText = strsql
        cmd.Connection = _conexion

        Me._adapt.DeleteCommand = cmd

        strsql = "update recoleccion set codigo=:codigo, nombre=:nombre where id=:id"
        cmd = Me.cdatos.CreateCommand
        cmd.CommandText = strsql
        cmd.Connection = _conexion

        Me._adapt.UpdateCommand = cmd

        parametro = Me.cdatos.CreateParameter
        parametro.ParameterName = ":id"
        parametro.DbType = DbType.Int32
        parametro.SourceColumn = "id"

        Me._adapt.DeleteCommand.Parameters.Add(parametro)
        Me._adapt.UpdateCommand.Parameters.Add(parametro)


        parametro = Me.cdatos.CreateParameter
        parametro.ParameterName = ":idalmazara"
        parametro.DbType = DbType.Int32
        parametro.SourceColumn = "idalmazara"
        parametro.Value = CType(Me._idalmazara, Integer)

        Me._adapt.SelectCommand.Parameters.Add(parametro)
        Me._adapt.InsertCommand.Parameters.Add(parametro)


        parametro = Me.cdatos.CreateParameter
        parametro.ParameterName = ":codigo"
        parametro.DbType = DbType.Int32
        parametro.SourceColumn = "codigo"

        Me._adapt.InsertCommand.Parameters.Add(parametro)
        Me._adapt.UpdateCommand.Parameters.Add(parametro)

        parametro = Me.cdatos.CreateParameter
        parametro.ParameterName = ":nombre"
        parametro.DbType = DbType.String
        parametro.SourceColumn = "nombre"

        Me._adapt.UpdateCommand.Parameters.Add(parametro)
        Me._adapt.InsertCommand.Parameters.Add(parametro)


    End Sub


    Public Sub New(ByVal idalmazara As Integer)
        MyBase.New()
        cdatos = New CBaseDatos
        Me._conexion = Me.cdatos.GetConnection
        Me._idalmazara = idalmazara
        Me._clearBeforeFill = True


        iniciaAdaptador()

    End Sub


    Protected Overrides Sub Finalize()

        MyBase.Finalize()

    End Sub
End Class