Option Strict Off
Option Explicit On

Imports System.Data.Common
Imports System.ComponentModel


Public Class depositosTableAdapter


    Private _idalmazara As Integer

    Private _conexion As DbConnection
    Private _adpt As DbDataAdapter
    Private cdatos As CBaseDatos

    
    Public Function GetData() As DataTable
        Dim tabla As DataTable = New DataTable("tanques")
        Me._adpt.Fill(tabla)
        Return tabla
    End Function

    Public Function Fill(ByVal tabla As DataTable) As Integer
        tabla.Clear()
        Dim resultado As Integer = Me._adpt.Fill(tabla)
        Return resultado
    End Function

    Public Sub Delete(ByVal id As Integer)

        Me._adpt.DeleteCommand.Parameters(":id").Value = CType(id, Integer)
        If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
            Me._conexion.Open()
        End If
        Me._adpt.DeleteCommand.ExecuteNonQuery()
        Me._conexion.Close()

    End Sub

    Public Function Guardar(ByVal tabla As DataTable) As Integer
        Dim result As Integer = Me._adpt.Update(tabla)
        Return result
    End Function

    Private Sub iniAdapt()
        Dim strsql As String
        Dim cmd As DbCommand
        Dim columna As DataColumn
        Dim parametro As DbParameter
        Dim tabla As DataTable
        Dim tablemapping As DataTableMapping

        Try



            Me._adpt = Me.cdatos.CreateDataAdapter

            tablemapping = New DataTableMapping("Table", "tanques")
            tablemapping.ColumnMappings.Add("id", "Id")
            tablemapping.ColumnMappings.Add("idalmazara", "Idalmazara")
            tablemapping.ColumnMappings.Add("numero", "Numero")
            tablemapping.ColumnMappings.Add("nombre", "Nombre")
            tablemapping.ColumnMappings.Add("capacidad", "Capacidad")

            Me._adpt.TableMappings.Add(tablemapping)

            strsql = "select * from tanques where idalmazara='" & Me._idalmazara.ToString() & "' order by numero"
            cmd = Me.cdatos.CreateCommand()
            cmd.CommandText = strsql
            cmd.Connection = Me._conexion
            Me._adpt.SelectCommand = cmd


            strsql = "insert into tanques (idalmazara,numero,nombre,capacidad) values(:idalmazara,:numero,:nombre,:capacidad)"

            cmd = Me.cdatos.CreateCommand
            cmd.CommandText = strsql
            cmd.Connection = Me._conexion

            Me._adpt.InsertCommand = cmd

            strsql = "delete from tanques where id=:id"

            cmd = Me.cdatos.CreateCommand
            cmd.CommandText = strsql
            cmd.Connection = Me._conexion



            Me._adpt.DeleteCommand = cmd

            strsql = "update tanques set numero=:numero,nombre=:nombre,capacidad=:capacidad where id=:id"

            cmd = Me.cdatos.CreateCommand
            cmd.CommandText = strsql
            cmd.Connection = Me._conexion


            cmd.CommandText = strsql

            Me._adpt.UpdateCommand = cmd

            parametro = Me.cdatos.CreateParameter
            parametro.DbType = DbType.Int32
            parametro.ParameterName = ":id"
            parametro.SourceColumn = "id"

            Me._adpt.UpdateCommand.Parameters.Add(parametro)
            Me._adpt.DeleteCommand.Parameters.Add(parametro)

            parametro = Me.cdatos.CreateParameter
            parametro.DbType = DbType.Int32
            parametro.SourceColumn = "idalmazara"
            parametro.ParameterName = ":idalmazara"
            parametro.Value = Me._idalmazara

            Me._adpt.InsertCommand.Parameters.Add(parametro)

            parametro = Me.cdatos.CreateParameter
            parametro.DbType = DbType.Int32
            parametro.ParameterName = ":numero"
            parametro.SourceColumn = "numero"

            Me._adpt.InsertCommand.Parameters.Add(parametro)
            Me._adpt.UpdateCommand.Parameters.Add(parametro)

            parametro = Me.cdatos.CreateParameter
            parametro.DbType = DbType.String
            parametro.ParameterName = ":nombre"
            parametro.SourceColumn = "nombre"

            Me._adpt.InsertCommand.Parameters.Add(parametro)
            Me._adpt.UpdateCommand.Parameters.Add(parametro)

            parametro = Me.cdatos.CreateParameter
            parametro.DbType = DbType.Int64
            parametro.ParameterName = ":capacidad"
            parametro.SourceColumn = "capacidad"

            Me._adpt.InsertCommand.Parameters.Add(parametro)
            Me._adpt.UpdateCommand.Parameters.Add(parametro)



        Catch ex As Exception
        Finally

        End Try

    End Sub




    Public Sub New(ByVal idalmazara As Integer)
        MyBase.New()
        Me.cdatos = New CBaseDatos
        Me._conexion = Me.cdatos.GetConnection
        Me._idalmazara = idalmazara
        iniAdapt()

    End Sub

    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub
End Class