Option Strict Off
Option Explicit On
Imports System.Data.Common
Imports System.Text

Public Class loteAceiteTableAdapter



    Dim oAnalisis As analisisTableAdapter


    Dim oConfiguracion As ConfigDB

    Private _campagna As Byte
    Private _idalmazara As Integer
    Private _conexion As DbConnection
    Private WithEvents _adpt As DbDataAdapter
    Private _dt As DataSet
    Private cdatos As New CBaseDatos
    Private _comandos As List(Of DbCommand)
    Private _clearBeforeFill As Boolean




    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Borrar_campaña()
        Dim cmd As DbCommand

        Try
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion

            cmd.CommandText = "delete from loteaceite where campagna='" & Me._campagna.ToString() & "' and idalmazara='" & Me._idalmazara.ToString & "'"
            If Not (Me._conexion.State And ConnectionState.Open) <> ConnectionState.Open Then
                Me._conexion.Open()

            End If
            cmd.ExecuteNonQuery()
            Me._conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="id"></param>
    ''' <remarks></remarks>
    Public Sub Delete(ByVal id As UShort)
        Dim cmd As DbCommand
        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion

        cmd.CommandText = "delete from loteaceite where id ='" & id.ToString & "' and campagna='" & Me._campagna.ToString() & "'"
        If (Me._conexion.State And ConnectionState.Open) <> ConnectionState.Open Then
            Me._conexion.Open()
        End If
        cmd.ExecuteNonQuery()
        Me._conexion.Close()

    End Sub


    Public Function GetDataById(ByVal id As Integer) As oleosigDB.loteaceiteDataTable
        Dim strSql As New StringBuilder

        Dim entidad As New oleosigDB.loteaceiteDataTable



        strSql.Append("select * from loteaceite")
        strSql.Append(" where id = '" & id & "'")
        strSql.Append(" and campagna ='" & Me._campagna.ToString() & "'")
        Try
            Dim cmd As DbCommand
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strSql.ToString

            Me._adpt.SelectCommand = cmd

            Me._adpt.Fill(entidad)


        Catch ex As Exception
            MsgBox(ex.Message)


        End Try
        Return entidad

    End Function

    Public Function GetDataByOpBdg(ByVal op As Integer) As oleosigDB.loteaceiteDataTable
        Dim cmd As DbCommand
        Dim strsql As New StringBuilder
        Dim tabla As New oleosigDB.loteaceiteDataTable

        strsql.Append("select loteaceite from detalles_loteaceite where opbodega='" & op.ToString & "'")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = strsql.ToString

        If (cmd.Connection.State And ConnectionState.Open) <> ConnectionState.Open Then
            cmd.Connection.Open()
        End If

        Dim rslt As Object = cmd.ExecuteScalar

        cmd.Connection.Close()

        If rslt IsNot Nothing Then
            If Not IsDBNull(rslt) Then
                tabla = Me.GetDataById(CType(rslt, Integer))
            End If
        End If

        Return tabla
    End Function





    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetData() As oleosigDB.loteaceiteDataTable
        Dim tabla As oleosigDB.loteaceiteDataTable = New oleosigDB.loteaceiteDataTable


        Try
            Me._adpt.SelectCommand = _comandos(0)
            Me._adpt.Fill(tabla)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
        Return tabla

    End Function
    Public Function Fill(ByVal tabla As oleosigDB.loteaceiteDataTable) As Integer
        If _clearBeforeFill Then
            tabla.Clear()
        End If

        Me._adpt.SelectCommand = _comandos(0)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(Me._idalmazara, Int32)
        Me._adpt.SelectCommand.Parameters(":campagna").Value = CType(Me._campagna, Int32)

        Dim rslt As Integer = Me._adpt.Fill(tabla)

        Return rslt

    End Function


    Public Function Insert(ByVal idalmazara As Integer, ByVal nombre As String, ByVal ntanque As UShort, ByVal fechaini As DateTime, ByVal fechafin As DateTime, ByVal actualiza As Boolean, ByVal campaña As Integer, ByVal abierto As Boolean) As Integer
        Dim strSql As New StringBuilder
        Dim result As Integer

        Me._adpt.InsertCommand.Parameters(":idalmazara").Value = CType(idalmazara, Int32)
        Me._adpt.InsertCommand.Parameters(":nombre").Value = CType(nombre, String)
        Me._adpt.InsertCommand.Parameters(":tanque").Value = CType(ntanque, Int32)
        Me._adpt.InsertCommand.Parameters(":fechaini").Value = CType(fechaini, DateTime)
        Me._adpt.InsertCommand.Parameters(":fechafin").Value = CType(fechafin, DateTime)
        Me._adpt.InsertCommand.Parameters(":campagna").Value = CType(campaña, Int32)
        Me._adpt.InsertCommand.Parameters(":abierta").Value = CType(abierto, Boolean)
        Me._adpt.InsertCommand.Parameters(":actualizado").Value = CType(actualiza, Boolean)

        Dim estado As ConnectionState = Me._adpt.InsertCommand.Connection.State

        If (estado And ConnectionState.Open) <> ConnectionState.Open Then
            Me._adpt.InsertCommand.Connection.Open()
        End If

        Me._adpt.InsertCommand.ExecuteNonQuery()

        If estado = ConnectionState.Closed Then
            Me._adpt.InsertCommand.Connection.Close()
        End If

        strSql.Length = 0
        strSql.Append("select id from loteaceite where idalmazara='" & idalmazara.ToString & "'")
        strSql.Append(" and lote='" & nombre & "'")
        strSql.Append(" and tanque='" & ntanque.ToString & "'")
        strSql.Append(" and fechaini='" & fechaini.ToString("yyyy-MM-dd HH:mm:ss") & "'")
        strSql.Append(" and fechafin='" & fechafin.ToString("yyyy-MM-dd HH:mm:ss") & "'")
        strSql.Append(" and campagna='" & campaña.ToString & "'")

        Dim cmd As DbCommand = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = strSql.ToString

        If (cmd.Connection.State And ConnectionState.Open) <> ConnectionState.Open Then
            cmd.Connection.Open()
        End If

        Dim lector As DbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        If lector.HasRows Then
            lector.Read()
            If Not IsDBNull(lector(0)) Then
                result = lector(0)
            Else
                result = 0
            End If

        Else
            result = 0
        End If
        lector.Close()

        Return result
    End Function

    Public Function Update(ByVal tabla As oleosigDB.loteaceiteDataTable) As Integer
        Return Me._adpt.Update(tabla)
    End Function




    Private Sub inicia_comandos()
        Dim cmd As DbCommand
        Dim param As DbParameter

        _comandos = New List(Of DbCommand)

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = "select * from loteaceite where campagna = :campagna and idalmazara=:idalmazara order by id"
        cmd.CommandType = CommandType.Text

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

        _comandos.Add(cmd)
    End Sub
    Private Sub inicia_Datos()
        Dim strsql As New System.Text.StringBuilder
        Dim cmd As DbCommand
        Dim datamaper As DataTableMapping
        Dim param As DbParameter


        datamaper = New DataTableMapping("Table", "loteaceite")
        datamaper.ColumnMappings.Add("id", "Id")
        datamaper.ColumnMappings.Add("idalmazara", "Idalmazara")
        datamaper.ColumnMappings.Add("lote", "Nombre")
        datamaper.ColumnMappings.Add("tanque", "Tanque")
        datamaper.ColumnMappings.Add("fechaini", "FechaInicial")
        datamaper.ColumnMappings.Add("fechafin", "FechaFinal")
        datamaper.ColumnMappings.Add("actualiza", "Importado")
        datamaper.ColumnMappings.Add("kilos", "Kilos")
        datamaper.ColumnMappings.Add("campagna", "Campaña")
        datamaper.ColumnMappings.Add("abierto", "Abierto")


        Me._adpt.TableMappings.Add(datamaper)

        Try

            strsql.Length = 0
            strsql.Append("insert into loteaceite (")
            strsql.Append("idalmazara,")
            strsql.Append("lote,")
            strsql.Append("tanque,")
            strsql.Append("fechaini,")
            strsql.Append("fechafin,")
            strsql.Append("actualiza,")
            strsql.Append("campagna,")
            strsql.Append("abierto) values(")
            strsql.Append(":idalmazara,")
            strsql.Append(":nombre,")
            strsql.Append(":tanque,")
            strsql.Append(":fechaini,")
            strsql.Append(":fechafin,")
            strsql.Append(":actualizado,")
            strsql.Append(":campagna,")
            strsql.Append(":abierta)")

            cmd = cdatos.CreateCommand
            cmd.Connection = _conexion
            cmd.CommandText = strsql.ToString

            Me._adpt.InsertCommand = cmd

            strsql.Length = 0

            strsql.Append("update loteaceite set ")
            strsql.Append("idalmazara=:idalmazara,")
            strsql.Append("lote=:nombre,")
            strsql.Append("tanque=:tanque,")
            strsql.Append("fechaini=:fechaini,")
            strsql.Append("fechafin=:fechafin,")
            strsql.Append("actualiza=:actualizado,")
            strsql.Append("campagna=:campagna,")
            strsql.Append("abierto=:abierta")
            strsql.Append(" where id=:id")

            cmd = cdatos.CreateCommand
            cmd.Connection = _conexion
            cmd.CommandText = strsql.ToString

            Me._adpt.UpdateCommand = cmd

            strsql.Length = 0

            strsql.Append("delete from loteaceite where id=:id")

            cmd = cdatos.CreateCommand
            cmd.Connection = _conexion
            cmd.CommandText = strsql.ToString

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

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = cdatos.CreateParameter
            param.ParameterName = ":nombre"
            param.SourceColumn = "lote"
            param.DbType = DbType.String

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = cdatos.CreateParameter
            param.ParameterName = ":tanque"
            param.SourceColumn = "tanque"
            param.DbType = DbType.Int32

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = cdatos.CreateParameter
            param.ParameterName = ":fechaini"
            param.SourceColumn = "fechaini"
            param.DbType = DbType.DateTime

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = cdatos.CreateParameter
            param.ParameterName = ":fechafin"
            param.SourceColumn = "fechafin"
            param.DbType = DbType.DateTime

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = cdatos.CreateParameter
            param.ParameterName = ":actualizado"
            param.SourceColumn = "actualizado"
            param.DbType = DbType.Boolean

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = cdatos.CreateParameter
            param.ParameterName = ":campagna"
            param.SourceColumn = "campagna"
            param.DbType = DbType.Int32

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = cdatos.CreateParameter
            param.ParameterName = ":abierta"
            param.SourceColumn = "abierta"
            param.DbType = DbType.Boolean

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

        Catch ex As Exception
        End Try
    End Sub

    Public Sub New(ByVal campagna As Byte, ByVal idalmazara As Integer)
        MyBase.New()
        _clearBeforeFill = True
        Me._idalmazara = idalmazara
        Me._campagna = campagna
        Me.cdatos = New CBaseDatos
        Me._conexion = cdatos.GetConnection
        oConfiguracion = New ConfigDB
        oAnalisis = New analisisTableAdapter(Me._campagna, Me._idalmazara)
        Me._adpt = cdatos.CreateDataAdapter
        Me._dt = New DataSet


        inicia_Datos()
        inicia_comandos()

    End Sub


    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub
End Class