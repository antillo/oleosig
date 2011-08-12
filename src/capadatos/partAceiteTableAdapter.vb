Option Strict Off
Option Explicit On

Imports System.Data.Common
Imports Oleosig.oleosigDB

Public Class partAceiteTableAdapter



    Private _campagna As Byte
    Private _idalmazara As Integer
    Private cdatos As New CBaseDatos
    Private _adpt As DbDataAdapter
    Private _conexion As DbConnection
    Private _comandos As List(Of DbCommand)
    Private _clearBeforeFill As Boolean


    Private Sub inicia_comandos()
        Dim strsql As New System.Text.StringBuilder
        Dim cmd As DbCommand
        Dim param As DbParameter
        Me._comandos = New List(Of DbCommand)

        strsql.Length = 0
        strsql.Append("select * from partidasaceite where campagna=:campagna and idalmazara=:idalmazara")

        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString
        cmd.CommandType = CommandType.Text



        param = Me.cdatos.CreateParameter
        param.SourceColumn = "idalmazara"
        param.ParameterName = ":idalmazara"
        param.DbType = DbType.Int32
        param.Value = Me._idalmazara

        cmd.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.SourceColumn = "campagna"
        param.ParameterName = ":campagna"
        param.DbType = DbType.Int32
        param.Value = CType(Me._campagna, Int32)

        cmd.Parameters.Add(param)

        Me._comandos.Add(cmd)

        strsql.Length = 0
        strsql.Append("select * from partidasaceite where deposito=:deposito and campagna=:campagna and idalmazara=:idalmazara order by id")

        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString
        cmd.CommandType = CommandType.Text



        param = Me.cdatos.CreateParameter
        param.SourceColumn = "idalmazara"
        param.ParameterName = ":idalmazara"
        param.DbType = DbType.Int32
        param.Value = Me._idalmazara

        cmd.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.SourceColumn = "campagna"
        param.ParameterName = ":campagna"
        param.DbType = DbType.Int32
        param.Value = CType(Me._campagna, Int32)

        cmd.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.SourceColumn = "deposito"
        param.ParameterName = ":deposito"
        param.DbType = DbType.String

        cmd.Parameters.Add(param)

        Me._comandos.Add(cmd)

        strsql.Length = 0

        strsql.Append("select * from partidasaceite where fecha between :fechaini " & _
          "and :fechafin and campagna =:campagna and idalmazara=:idalmazara order by id")

        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString
        cmd.CommandType = CommandType.Text



        param = Me.cdatos.CreateParameter
        param.SourceColumn = "idalmazara"
        param.ParameterName = ":idalmazara"
        param.DbType = DbType.Int32
        param.Value = Me._idalmazara

        cmd.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.SourceColumn = "campagna"
        param.ParameterName = ":campagna"
        param.DbType = DbType.Int32
        param.Value = CType(Me._campagna, Int32)

        cmd.Parameters.Add(param)


        param = Me.cdatos.CreateParameter
        param.ParameterName = ":fechaini"
        param.DbType = DbType.DateTime

        cmd.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":fechafin"
        param.DbType = DbType.DateTime

        cmd.Parameters.Add(param)

        Me._comandos.Add(cmd)

        strsql.Length = 0

        strsql.Append("select * from partidasaceite where fecha between :fechaini" & _
            " and :fechafin and campagna =:campagna" & _
            " and deposito =:deposito and idalmazara=:idalmazara order by id")

        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString
        cmd.CommandType = CommandType.Text

        Me._comandos.Add(cmd)




    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Id"></param>
    ''' <remarks></remarks>
    Public Sub Delete(ByVal Id As UShort)

        Me._adpt.DeleteCommand.Parameters("id").Value = CType(Id, Integer)

        Try


            If Me._conexion.State = ConnectionState.Closed Then
                Me._conexion.Open()
            End If
            Me._adpt.DeleteCommand.ExecuteNonQuery()
            Me._conexion.Close()

        Catch ex As Exception
        End Try


    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="vDeposito"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByDeposito(ByVal vDeposito As String) As oleosigDB.partidasaceiteDataTable

        Dim tabla As oleosigDB.partidasaceiteDataTable = New oleosigDB.partidasaceiteDataTable()

        Me._adpt.SelectCommand = Me._comandos(1)
        Me._adpt.SelectCommand.Parameters(":deposito").Value = CType(vDeposito, String)

        Try

            Me._adpt.Fill(tabla)
            Return tabla
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function



    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="vEntidad"></param>
    ''' <remarks></remarks>
    Public Function Update(ByVal vEntidad As oleosigDB.partidasaceiteDataTable) As Integer


        Return Me._adpt.Update(vEntidad)


    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getLastPartida() As Short
        Dim strSql As String
        Dim resultado As Object
        Dim cmd As DbCommand

        Dim ultimapartida As Short = 0


        strSql = "select max(numero) from partidasaceite where campagna ='" & Me._campagna.ToString & "' and idalmazara='" & Me._idalmazara.ToString & "'"

        Try
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strSql
            If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
                _conexion.Open()
            End If
            resultado = cmd.ExecuteScalar
            _conexion.Close()


            If Not IsDBNull(resultado) Then
                ultimapartida = CType(resultado, Short)

            End If



        Catch ex As Exception

        End Try
        Return ultimapartida
    End Function

   

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="numpartida"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByNumPartida(ByVal numpartida As String) As oleosigDB.partidasaceiteDataTable
        Dim strSql As String

        Dim entidad As oleosigDB.partidasaceiteDataTable
        Dim cmd As DbCommand

        entidad = New oleosigDB.partidasaceiteDataTable

        strSql = "select * from partidasaceite where numero ='" & numpartida & "' and campagna ='" & Me._campagna.ToString & "' and idalmazara='" & Me._idalmazara.ToString & "'"

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strSql.ToString

        Me._adpt.SelectCommand = cmd

        Me._adpt.Fill(entidad)


        Return entidad
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Function Insert(ByVal idalmazara As Integer, ByVal fecha As DateTime, ByVal tipo As Integer, ByVal comentarios As String, ByVal numero As Integer, ByVal campaña As Integer) As Integer
        Dim strSql As New System.Text.StringBuilder


        strSql.Append("insert into partidasaceite (")
        strSql.Append("idalmazara,")
        strSql.Append("fecha,")
        strSql.Append("tipo,")
        strSql.Append("comentarios,")
        strSql.Append("numero,")
        strSql.Append("campagna) ")
        strSql.Append("values(")
        strSql.Append("'" & idalmazara.ToString & "',")
        strSql.Append("'" & fecha.ToString("yyyy-MM-dd HH:mm:00") & "',")
        strSql.Append("'" & tipo.ToString & "',")
        strSql.Append("'" & comentarios & "',")
        strSql.Append("'" & numero.ToString & "',")
        strSql.Append("'" & campaña.ToString & "')")

        Try
            cdatos.Haz(strSql.ToString)
            Dim tabla As oleosigDB.partidasaceiteDataTable = Me.GetDataByNumPartida(numero.ToString)
            If tabla.Rows.Count > 0 Then
                Return tabla(0).Id
            Else
                Return 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="fechaini"></param>
    ''' <param name="fechafin"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByFechas(ByVal fechaini As DateTime, ByVal fechafin As DateTime) As oleosigDB.partidasaceiteDataTable
        Dim tabla As oleosigDB.partidasaceiteDataTable = New oleosigDB.partidasaceiteDataTable

        Me._adpt.SelectCommand = Me._comandos(2)


        Me._adpt.SelectCommand.Parameters(":fechaini").Value = CType(fechaini, DateTime)
        Me._adpt.SelectCommand.Parameters(":fechafin").Value = CType(fechafin, DateTime)

        Me._adpt.Fill(tabla)


        Return tabla

    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="fechaini"></param>
    ''' <param name="fechafin"></param>
    ''' <param name="sDeposito"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByFechas(ByVal fechaini As DateTime, ByVal fechafin As DateTime, ByVal sDeposito As Int32) As oleosigDB.partidasaceiteDataTable
        Dim tabla As oleosigDB.partidasaceiteDataTable = New oleosigDB.partidasaceiteDataTable

        Me._adpt.SelectCommand = Me._comandos(3)

        Me._adpt.SelectCommand.Parameters(":fechaini").Value = CType(fechaini, DateTime)
        Me._adpt.SelectCommand.Parameters(":fechafin").Value = CType(fechafin, DateTime)
        Me._adpt.SelectCommand.Parameters(":deposito").Value = CType(sDeposito, Int32)

        Me._adpt.Fill(tabla)

        Return tabla


    End Function
    Public Overridable Overloads Function Fill(ByVal tabla As oleosigDB.partidasaceiteDataTable) As Integer
        Me._adpt.SelectCommand = Me._comandos(0)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(_idalmazara, Integer)
        Me._adpt.SelectCommand.Parameters(":campagna").Value = CType(_campagna, Integer)

        If Me._clearBeforeFill Then
            tabla.Clear()

        End If
        Return Me._adpt.Fill(tabla)
    End Function


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetData() As oleosigDB.partidasaceiteDataTable

        Dim tabla As oleosigDB.partidasaceiteDataTable = New oleosigDB.partidasaceiteDataTable()

        Me._adpt.SelectCommand = Me._comandos(0)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(Me._idalmazara, Integer)
        Me._adpt.SelectCommand.Parameters(":campagna").Value = CType(Me._campagna, Integer)


        Me._adpt.Fill(tabla)

        Return tabla

    End Function



    Private Sub iniAdapter()
        Dim strsql As New System.Text.StringBuilder
        Dim cmd As DbCommand
        Dim param As DbParameter
        Dim tableMapping As DataTableMapping





        Me._adpt = cdatos.CreateDataAdapter

        tableMapping = New DataTableMapping("partidasaceite", "partidasaceite")
        tableMapping.ColumnMappings.Add("id", "Id")
        tableMapping.ColumnMappings.Add("idalmazara", "Idalmazara")
        tableMapping.ColumnMappings.Add("fecha", "Fecha")
        tableMapping.ColumnMappings.Add("tipo", "Tipo")
        tableMapping.ColumnMappings.Add("comentarios", "comentarios")
        tableMapping.ColumnMappings.Add("numero", "Numero")
        tableMapping.ColumnMappings.Add("campagna", "Campaña")


        strsql.Length = 0

        strsql.Append("insert into partidasaceite (")
        strsql.Append("idlote,")
        strsql.Append("idalmazara,")
        strsql.Append("fecha,")
        strsql.Append("tipo,")
        strsql.Append("comentarios,")
        strsql.Append("numero,")
        strsql.Append("campagna) ")
        strsql.Append("values(")
        strsql.Append(":idlote,")
        strsql.Append(":idalmazara,")
        strsql.Append(":fecha,")
        strsql.Append(":tipo,")
        strsql.Append(":comentario,")
        strsql.Append(":numero,")
        strsql.Append(":campagna)")

        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.InsertCommand = cmd

        strsql.Length = 0

        strsql.Append("update partidasaceite set ")
        strsql.Append("fecha=:fecha,")
        strsql.Append("tipo=:tipo,")
        strsql.Append("comentarios=:comentarios,")
        strsql.Append("numero=:numero ")
        strsql.Append("where id=:id")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.UpdateCommand = cmd

        strsql.Length = 0

        strsql.Append("delete from partidasaceite where id=:id")

        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.DeleteCommand = cmd

        param = Me.cdatos.CreateParameter
        param.SourceColumn = "id"
        param.ParameterName = ":id"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.DeleteCommand.Parameters.Add(param)


        param = Me.cdatos.CreateParameter
        param.SourceColumn = "idalmazara"
        param.ParameterName = ":idalmazara"
        param.DbType = DbType.Int32
        param.Value = Me._idalmazara


        Me._adpt.InsertCommand.Parameters.Add(param)


        param = Me.cdatos.CreateParameter
        param.SourceColumn = "fecha"
        param.ParameterName = ":fecha"
        param.DbType = DbType.DateTime

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.SourceColumn = "tipo"
        param.ParameterName = ":tipo"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.SourceColumn = "comentarios"
        param.ParameterName = ":comentarios"
        param.DbType = DbType.String

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)


        param = Me.cdatos.CreateParameter
        param.SourceColumn = "numero"
        param.ParameterName = ":numero"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.SourceColumn = "campagna"
        param.ParameterName = ":campagna"
        param.DbType = DbType.Int32
        param.Value = CType(Me._campagna, Int32)


        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)



    End Sub

    Public Sub New(ByVal campagna As Byte, ByVal idalmazara As Integer)
        MyBase.New()
        Me._campagna = campagna
        Me._idalmazara = idalmazara
        Me._conexion = cdatos.GetConnection
        Me._adpt = cdatos.CreateDataAdapter
        _clearBeforeFill = True

        inicia_comandos()
        iniAdapter()

    End Sub


    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub
End Class