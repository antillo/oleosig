
Imports System.Data.Common
Imports System.Text

Public Class marcasTableAdapter
    Private _idalmazara As Integer
    Private _adpt As DbDataAdapter
    Private _conexion As DbConnection
    Private cdatos As CBaseDatos
    Private _comandos As List(Of DbCommand)
    Private _clearBeforeFill As Boolean


    Private Sub inicia_comandos()
        Dim cmd As DbCommand
        Dim param As DbParameter

        Me._comandos = New List(Of DbCommand)

        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = "select * from marcas where idalmazara=:idalmazara"

        param = Me.cdatos.CreateParameter
        param.SourceColumn = "idalmazara"
        param.DbType = DbType.Int32
        param.ParameterName = ":idalmazara"

        cmd.Parameters.Add(param)

        Me._comandos.Add(cmd)

    End Sub

    Public Function Update(ByVal tabla As oleosigDB.marcasDataTable) As Integer
        Return Me._adpt.Update(tabla)
    End Function

    Public Function Fill(ByVal tabla As oleosigDB.marcasDataTable) As Integer
        If Me._clearBeforeFill Then
            tabla.Clear()
        End If
        Me._adpt.SelectCommand = _comandos(0)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(_idalmazara, Integer)

        Return Me._adpt.Fill(tabla)

    End Function
    Private Sub inicia_datos()
        Dim cmd As DbCommand
        Dim param As DbParameter
        Dim strsql As New StringBuilder
        Dim tablamapping As DataTableMapping




        tablamapping = New DataTableMapping("Table", "marcas")
        tablamapping.ColumnMappings.Add("id", "Id")
        tablamapping.ColumnMappings.Add("idalmazara", "Idalmazara")
        tablamapping.ColumnMappings.Add("codigo", "Codigo")
        tablamapping.ColumnMappings.Add("nombre", "Nombre")

        Me._adpt.TableMappings.Add(tablamapping)


      
        strsql.Length = 0

        strsql.Append("insert into marcas (idalmazara,codigo,nombre) values(:idalmazara,:codigo,:nombre)")

        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.InsertCommand = cmd

        strsql.Length = 0

        strsql.Append("update marcas set ")
        strsql.Append("codigo=:codigo,")
        strsql.Append("nombre=:nombre ")
        strsql.Append("where id=:id")

        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.UpdateCommand = cmd

        strsql.Length = 0

        strsql.Append("delete from marcas where id=:id")

        cmd = Me.cdatos.CreateCommand
        cmd.Connection = _conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.DeleteCommand = cmd


        param = Me.cdatos.CreateParameter
        param.SourceColumn = "id"
        param.DbType = DbType.Int32
        param.ParameterName = ":id"

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.DeleteCommand.Parameters.Add(param)



        param = Me.cdatos.CreateParameter
        param.SourceColumn = "idalmazara"
        param.DbType = DbType.Int32
        param.ParameterName = ":idalmazara"
        param.Value = Me._idalmazara

        Me._adpt.InsertCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.SourceColumn = "codigo"
        param.DbType = DbType.Int32
        param.ParameterName = ":codigo"

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.SourceColumn = "nombre"
        param.DbType = DbType.String
        param.ParameterName = ":nombre"

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

       
    End Sub

    Public Sub New(ByVal idalmazara As Integer)
        Me._idalmazara = idalmazara
        Me._clearBeforeFill = True
        cdatos = New CBaseDatos

        Me._conexion = cdatos.GetConnection
        Me._adpt = cdatos.CreateDataAdapter
        inicia_datos()
        inicia_comandos()
    End Sub
End Class
