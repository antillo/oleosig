Option Strict Off
Option Explicit On

Imports System.Data.Common
Imports System.Text
Imports Oleosig.oleosigDB

Public Class terminosTableAdapter


    Private _idalmazara As Integer
    Private _adpt As DbDataAdapter
    Private _clearBeforeFill As Boolean
    Private cdatos As New CBaseDatos
    Private _conexion As DbConnection
    Private _comandos As List(Of DbCommand)

    Public Function GetData() As oleosigDB.terminosDataTable
        Dim tabla As New oleosigDB.terminosDataTable
        Me._adpt.SelectCommand = _comandos(0)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(_idalmazara, Integer)
        Me._adpt.Fill(tabla)
        Return tabla
    End Function

    Public Function Fill(ByVal tabla As oleosigDB.terminosDataTable) As Integer
        Me._adpt.SelectCommand = _comandos(0)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(_idalmazara, Integer)
        If Me._clearBeforeFill Then
            tabla.Clear()
        End If
        Return Me._adpt.Fill(tabla)
    End Function
    Public Function Update(ByVal tabla As oleosigDB.terminosDataTable) As Integer

        Return Me._adpt.Update(tabla)

    End Function

    ''' <summary>
    ''' Borra un termino
    ''' </summary>
    ''' <param name="id"></param>
    ''' <remarks></remarks>
    Public Sub Delete(ByVal id As Integer)
        Dim strsql As String


        strsql = "delete from terminos where id ='" & id.ToString & "' and idalmazara='" & Me._idalmazara.ToString & "'"
        cdatos.Haz(strsql)


    End Sub



    Private Sub inicia_comandos()
        Dim strsql As New StringBuilder
        Dim cmd As DbCommand
        Dim parametro As DbParameter

        _comandos = New List(Of DbCommand)

        strsql.Append("select * from terminos where idalmazara=:idalmazara order by id")
        cmd = cdatos.CreateCommand
        cmd.Connection = cdatos.GetConnection
        cmd.CommandText = strsql.ToString

        parametro = cdatos.CreateParameter
        parametro.ParameterName = ":idalmazara"
        parametro.DbType = DbType.Int32
        parametro.SourceColumn = "idalmazara"
        parametro.Value = Me._idalmazara

        cmd.Parameters.Add(parametro)

        _comandos.Add(cmd)

    End Sub

    Private Sub inicia_Datos()
        Dim strsql As New StringBuilder
        Dim cmd As DbCommand
        Dim parametro As DbParameter
        Dim tablamaper As DataTableMapping



        Try

            tablamaper = New DataTableMapping("Table", "terminos")
            tablamaper.ColumnMappings.Add("id", "Id")
            tablamaper.ColumnMappings.Add("idalmazara", "Idalmazara")
            tablamaper.ColumnMappings.Add("codigo", "CodAlmazara")
            tablamaper.ColumnMappings.Add("ine", "CodIne")
            tablamaper.ColumnMappings.Add("nombre", "Nombre")
            tablamaper.ColumnMappings.Add("cod_prov", "CodProvincia")

            Me._adpt.TableMappings.Add(tablamaper)

            strsql.Length = 0

            strsql.Append("insert into terminos (idalmazara,codigo,ine,nombre,cod_prov) values(:idalmazara,:codigo,:ine,:nombre,:cod_prov)")

            cmd = cdatos.CreateCommand()
            cmd.Connection = cdatos.GetConnection
            cmd.CommandText = strsql.ToString()

            Me._adpt.InsertCommand = cmd


            strsql.Length = 0
            strsql.Append("delete from terminos where id=:id and idalmazara=:idalamzara")

            cmd = cdatos.CreateCommand
            cmd.Connection = cdatos.GetConnection
            cmd.CommandText = strsql.ToString

            Me._adpt.DeleteCommand = cmd

            strsql.Length = 0
            strsql.Append("update terminos set codigo=:codigo,ine=:ine,nombre=:nombre,cod_prov=:cod_prov where id=:id")

            cmd = cdatos.CreateCommand
            cmd.Connection = cdatos.GetConnection
            cmd.CommandText = strsql.ToString

            Me._adpt.UpdateCommand = cmd


            parametro = cdatos.CreateParameter
            parametro.ParameterName = ":id"
            parametro.DbType = DbType.Int32
            parametro.SourceColumn = "id"

            Me._adpt.UpdateCommand.Parameters.Add(parametro)
            Me._adpt.DeleteCommand.Parameters.Add(parametro)


            parametro = cdatos.CreateParameter
            parametro.ParameterName = ":idalmazara"
            parametro.DbType = DbType.Int32
            parametro.SourceColumn = "idalmazara"
            parametro.Value = Me._idalmazara


            Me._adpt.InsertCommand.Parameters.Add(parametro)
            Me._adpt.UpdateCommand.Parameters.Add(parametro)


            parametro = cdatos.CreateParameter
            parametro.ParameterName = ":codigo"
            parametro.DbType = DbType.Double
            parametro.SourceColumn = "codigo"

            Me._adpt.InsertCommand.Parameters.Add(parametro)
            Me._adpt.UpdateCommand.Parameters.Add(parametro)

            parametro = cdatos.CreateParameter
            parametro.ParameterName = ":ine"
            parametro.DbType = DbType.Int32
            parametro.SourceColumn = "ine"

            Me._adpt.InsertCommand.Parameters.Add(parametro)
            Me._adpt.UpdateCommand.Parameters.Add(parametro)


            parametro = cdatos.CreateParameter
            parametro.ParameterName = ":nombre"
            parametro.DbType = DbType.String
            parametro.SourceColumn = "nombre"

            Me._adpt.InsertCommand.Parameters.Add(parametro)
            Me._adpt.UpdateCommand.Parameters.Add(parametro)


            parametro = cdatos.CreateParameter
            parametro.ParameterName = ":cod_prov"
            parametro.DbType = DbType.Double
            parametro.SourceColumn = "cod_prov"

            Me._adpt.InsertCommand.Parameters.Add(parametro)
            Me._adpt.UpdateCommand.Parameters.Add(parametro)



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub New(ByVal idalmazara As Integer)
        MyBase.New()
        Me._idalmazara = idalmazara
        Me._clearBeforeFill = True
        Me.cdatos = New CBaseDatos
        Me._conexion = cdatos.GetConnection
        Me._adpt = Me.cdatos.CreateDataAdapter

        inicia_comandos()
        inicia_Datos()
    End Sub


    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub
End Class