Option Strict Off
Option Explicit On
Imports System.ComponentModel
Imports System.Data.Common

Public Class tolvasTableAdapter


    Private _idalmazara As Integer
    Private _conexion As DbConnection
    Private cdatos As CBaseDatos

    Private _clearBeforeFill As Boolean

    Private WithEvents _adpt As DbDataAdapter

    Public Function GetData() As oleosigDB.tolvasDataTable
        Dim tabla As oleosigDB.tolvasDataTable = New oleosigDB.tolvasDataTable

        Me._adpt.Fill(tabla)

        Return tabla

    End Function
    Public Function Fill(ByVal tolvas As oleosigDB.tolvasDataTable) As Integer
        If _clearBeforeFill Then
            tolvas.Clear()
        End If

        Dim retorno As Integer = Me._adpt.Fill(tolvas)
        Return retorno
    End Function
    Public Function Update(ByVal tolvas As oleosigDB.tolvasDataTable) As Integer
        Dim result As Integer = Me._adpt.Update(tolvas)
        Return result
    End Function


    Public Sub Delete(ByVal id As Integer)

        Me._adpt.DeleteCommand.Parameters(0).Value = CType(id, Integer)

        If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
            Me._conexion.Open()
        End If

        Me._adpt.DeleteCommand.ExecuteNonQuery()

        Me._conexion.Close()

    End Sub
    Private Sub iniAdapt(ByVal idalmazara As Integer)
        Dim strsql As String
        Dim cmd As DbCommand
        Dim cmdInsertar As DbCommand
        Dim cmdUpdate As DbCommand
        Dim cmdDelete As DbCommand
        Dim tablemapping As DataTableMapping
        Dim parametro As DbParameter



        tablemapping = New DataTableMapping("Table", "tolvas")
        tablemapping.ColumnMappings.Add("id", "Id")
        tablemapping.ColumnMappings.Add("idalmazara", "Idalmazara")
        tablemapping.ColumnMappings.Add("numero", "Numero")
        tablemapping.ColumnMappings.Add("nombre", "Nombre")
        tablemapping.ColumnMappings.Add("capacidad", "Capacidad")


        Me._adpt = Me.cdatos.CreateDataAdapter

        Me._adpt.TableMappings.Add(tablemapping)


        strsql = "select * from tolvas where idalmazara='" & idalmazara.ToString() & "' order by id"

        cmd = Me.cdatos.CreateCommand()
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql
        Me._adpt.SelectCommand = cmd



        strsql = "insert into tolvas (idalmazara,numero,nombre,capacidad) values(:idalmazara,:numero,:nombre,:capacidad)"

        cmdInsertar = Me.cdatos.CreateCommand()
        cmdInsertar.Connection = Me._conexion
        cmdInsertar.CommandText = strsql

        strsql = "update tolvas set numero=:numero,nombre=:nombre,capacidad=:capacidad where id=:id and idalmazara=:idalmazara"

        cmdUpdate = Me.cdatos.CreateCommand()
        cmdUpdate.Connection = _conexion
        cmdUpdate.CommandText = strsql


        strsql = "delete from tolvas where id=:id and idalmazara=:idalmazara"

        cmdDelete = Me.cdatos.CreateCommand()
        cmdDelete.Connection = _conexion
        cmdDelete.CommandText = strsql


        Me._adpt.InsertCommand = cmdInsertar
        Me._adpt.UpdateCommand = cmdUpdate
        Me._adpt.DeleteCommand = cmdDelete

        parametro = Me.cdatos.CreateParameter()
        parametro.ParameterName = ":id"
        parametro.DbType = DbType.Int32
        parametro.SourceColumn = "id"

        Me._adpt.DeleteCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)


        parametro = Me.cdatos.CreateParameter()
        parametro.ParameterName = ":idalmazara"
        parametro.DbType = DbType.Int32
        parametro.SourceColumn = "idalmazara"

        Me._adpt.DeleteCommand.Parameters.Add(parametro)
        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)


        parametro = Me.cdatos.CreateParameter()
        parametro.ParameterName = ":numero"
        parametro.DbType = DbType.Int32
        parametro.SourceColumn = "numero"

        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)


        parametro = Me.cdatos.CreateParameter
        parametro.ParameterName = ":nombre"
        parametro.DbType = DbType.String
        parametro.SourceColumn = "nombre"

        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)

        parametro = Me.cdatos.CreateParameter
        parametro.ParameterName = ":capacidad"
        parametro.DbType = DbType.Int64
        parametro.SourceColumn = "capacidad"

        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)


    End Sub



    Public Sub New(ByVal idalmazara As Integer)
        MyBase.New()
        Me._clearBeforeFill = True
        Me.cdatos = New CBaseDatos
        Me._conexion = Me.cdatos.GetConnection
        Me._idalmazara = idalmazara


        iniAdapt(idalmazara)

    End Sub


    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub
End Class