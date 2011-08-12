Imports System.Data.Common
Imports System.ComponentModel

Public Class TicketDelimTableAdapter



    Private _idalmazara As Integer
    Private _tipo As Integer

    Private _adpt As DbDataAdapter
    Private cdatos As New CBaseDatos
    Private _conexion As DbConnection
    Private _comandos As List(Of DbCommand)
    Private _clearBeforeFill As Boolean

    Private Sub inicia_comandos()
        Dim cmd As DbCommand
        Dim parametro As DbParameter

        _comandos = New List(Of DbCommand)

        cmd = Me.cdatos.CreateCommand()
        cmd.CommandText = "select * from cfg_imp_ticket_delimitado where idalmazara=:idalmazara order by id"
        cmd.Connection = Me._conexion
        cmd.CommandType = CommandType.Text

        parametro = Me.cdatos.CreateParameter
        parametro.ParameterName = ":idalmazara"
        parametro.DbType = DbType.Int32
        parametro.SourceColumn = "idalmazara"


        cmd.Parameters.Add(parametro)

        _comandos.Add(cmd)

    End Sub

    Public Function Fill(ByVal tabla As oleosigDB.cfg_imp_ticket_delimitadoDataTable) As Integer
        Me._adpt.SelectCommand = Me._comandos(0)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(Me._idalmazara, Integer)
        If _clearBeforeFill Then
            tabla.Clear()
        End If
        Dim result As Integer = Me._adpt.Fill(tabla)
        Return result
    End Function
    Private Sub inicia_datos()
        Dim cmd As DbCommand
        Dim parametro As DbParameter
        Dim mapatabla As DataTableMapping


        mapatabla = New DataTableMapping("Table", "cfg_imp_ticket_delimitado")

        mapatabla.ColumnMappings.Add("id", "id")
        mapatabla.ColumnMappings.Add("idalamzara", "idalmazara")
        mapatabla.ColumnMappings.Add("campo", "campo")
        mapatabla.ColumnMappings.Add("posicion", "posicion")
        mapatabla.ColumnMappings.Add("descripcion", "descripcion")
        mapatabla.ColumnMappings.Add("importar", "importar")
        mapatabla.ColumnMappings.Add("numimportacion", "numimportacion")

        Me._adpt.TableMappings.Add(mapatabla)


        cmd = Me.cdatos.CreateCommand()
        cmd.Connection = Me._conexion
        cmd.CommandText = "insert into cfg_imp_ticket_delimitado (idalmazara,campo,posicion,descripcion,importar,numimportacion) values(:idalmazara,:campo,:posicion,:descripcion,:importar,:numimportacion)"


        Me._adpt.InsertCommand = cmd

        cmd = Me.cdatos.CreateCommand()
        cmd.CommandText = "update cfg_imp_ticket_delimitado set campo=:campo, posicion=:posicion,descripcion=:descripcion,importar=:importar,numimportacion=:numimportacion where id=:id"
        cmd.Connection = Me._conexion

        Me._adpt.UpdateCommand = cmd

        cmd = Me.cdatos.CreateCommand()
        cmd.CommandText = "delete from cfg_imp_ticket_delimitado where id=:id"
        cmd.Connection = Me._conexion

        Me._adpt.DeleteCommand = cmd

        parametro = Me.cdatos.CreateParameter
        parametro.ParameterName = ":id"
        parametro.DbType = DbType.Int32
        parametro.SourceColumn = "id"


        Me._adpt.UpdateCommand.Parameters.Add(parametro)
        Me._adpt.DeleteCommand.Parameters.Add(parametro)


        parametro = Me.cdatos.CreateParameter
        parametro.ParameterName = ":idalmazara"
        parametro.DbType = DbType.Int32
        parametro.SourceColumn = "idalmazara"
        parametro.Value = Me._idalmazara


        Me._adpt.InsertCommand.Parameters.Add(parametro)
        

        parametro = Me.cdatos.CreateParameter
        parametro.ParameterName = ":campo"
        parametro.DbType = DbType.Int32
        parametro.SourceColumn = "campo"


        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)


        parametro = Me.cdatos.CreateParameter
        parametro.ParameterName = ":posicion"
        parametro.DbType = DbType.Int32
        parametro.SourceColumn = "posicion"


        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)


        parametro = Me.cdatos.CreateParameter
        parametro.ParameterName = ":descripcion"
        parametro.DbType = DbType.String
        parametro.SourceColumn = "descripcion"

        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)

        parametro = Me.cdatos.CreateParameter
        parametro.ParameterName = ":importar"
        parametro.DbType = DbType.Boolean
        parametro.SourceColumn = "importar"

        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)

        parametro = Me.cdatos.CreateParameter
        parametro.ParameterName = ":numimportacion"
        parametro.DbType = DbType.Int32
        parametro.SourceColumn = "numimportacion"

        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)

    End Sub

    Public Sub New(ByVal idalmzara As Integer)
        MyBase.New()
        _clearBeforeFill = True
        Me._idalmazara = idalmzara

        Me._conexion = cdatos.GetConnection
        Me._adpt = cdatos.CreateDataAdapter

        Me.inicia_datos()
        Me.inicia_comandos()

    End Sub
    Public Overridable Overloads Function Update(ByVal tabla As oleosigDB.cfg_imp_ticket_delimitadoDataTable) As Integer
        If Me._clearBeforeFill Then
            tabla.Clear()
        End If
        Dim result As Integer = Me._adpt.Update(tabla)
        Return result
    End Function
    Public Overridable Overloads Function Update(ByVal dataset As oleosigDB) As Integer
        Dim result As Integer = Me._adpt.Update(dataset, "cfg_imp_ticket_delimitado")
        Return result
    End Function

    
End Class
