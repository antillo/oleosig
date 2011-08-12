Option Strict Off
Option Explicit On

Imports System.Data.Common
Imports System.Linq

Public Class opbodegaTableAdapter


    Private _campagna As Byte
    Private _idalmazara As Integer
    Private _adpt As DbDataAdapter


    Private cdatos As New CBaseDatos
    Private _conexion As DbConnection
    Private _clearBeforeFill As Boolean
    Private _comandos As List(Of DbCommand)



    Public Sub Borrar_campaña()
        Dim strSql As String

        Try
            strSql = "delete from opbodega where campagna='" & Me._campagna.ToString() & "' and idalmazara='" & Me._idalmazara.ToString & "'"
            Me.cdatos.Haz(strSql)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="actualizados"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataAgrupByTanque(ByVal actualizados As Boolean) As oleosigDB.opbodegaDataTable
        Dim entidades As New oleosigDB.opbodegaDataTable
        Dim strsql As New System.Text.StringBuilder


        strsql.Append("select distinct(tanque) as tanque,")
        strsql.Append("min(fechainicial) as fechainicial,")
        strsql.Append("max(fechafinal) as fechafinal, ")
        strsql.Append("campagna from opbodega ")
        strsql.Append("where campagna='" & Me._campagna.ToString() & "' ")
        strsql.Append("and idalmazara='" & Me._idalmazara.ToString & "' ")
        strsql.Append("and destino ='Bodega' ")
        strsql.Append("and tipo='1' ")
        If actualizados Then
            strsql.Append("and actualizada='0' ")
        End If
        strsql.Append("group by tanque order by fechainicial")



        Try
            Dim cmd As DbCommand
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strsql.ToString
            Me._adpt.SelectCommand = cmd


            Me._adpt.Fill(entidades)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return entidades
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="id"></param>
    ''' <remarks></remarks>
    Public Sub Delete(ByVal id As Integer)
        Dim strSql As String


        strSql = "delete from opbodega where id ='" & id.ToString & "'"

        cdatos.Haz(strSql)


    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetLastNumOp() As ULong

        Dim resultado As Object
        Dim valordevuelto As ULong
        Dim cmd As DbCommand

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion

        cmd.CommandText = "select max(operacion) from opbodega where campagna='" & Me._campagna.ToString() & "'" & _
            " and idalmazara='" & Me._idalmazara.ToString & "'"


        If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
            Me._conexion.Open()
        End If


        resultado = cmd.ExecuteScalar
        Me._conexion.Close()

        If IsDBNull(resultado) Then
            valordevuelto = 0
        Else
            valordevuelto = CType(resultado, ULong)
        End If

        Return valordevuelto

    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetLast() As oleosigDB.opbodegaDataTable
        Dim strSql As String
        Dim entidad As New oleosigDB.opbodegaDataTable



        strSql = "select * from opbodega where operacion = (select max(operacion) from opbodega where campagna='" & _
            Me._campagna.ToString() & "' and idalmazara='" & Me._idalmazara.ToString & "') and campagna ='" & Me._campagna.ToString() & "'" & _
            " and idalmazara='" & Me._idalmazara.ToString & "'"

        Try
            Dim cmd As DbCommand
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strSql.ToString

            Me._adpt.SelectCommand = cmd

            Me._adpt.Fill(entidad)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return entidad
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ntanque"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetByTanque(ByVal ntanque As UInteger) As oleosigDB.opbodegaDataTable
        Dim strSql As String
        Dim entidades As New oleosigDB.opbodegaDataTable



        strSql = "select * from opbodega where tanque ='" & ntanque.ToString() & "'" & _
            " and campagna ='" & Me._campagna.ToString() & "'" & _
            " and idalmazara='" & Me._idalmazara.ToString & "'" & _
            " order by id"
        Try
            Dim cmd As DbCommand
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strSql.ToString

            Me._adpt.SelectCommand = cmd

            Me._adpt.Fill(entidades)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return entidades

    End Function
    Public Function FillByTanque(ByVal tabla As oleosigDB.opbodegaDataTable, ByVal ntanque As UInteger) As Integer
        Dim strSql As String
        Dim rslt As Integer = 0

        If _clearBeforeFill Then
            tabla.Clear()
        End If

        strSql = "select * from opbodega where tanque ='" & ntanque.ToString() & "'" & _
            " and campagna ='" & Me._campagna.ToString() & "'" & _
            " and idalmazara='" & Me._idalmazara.ToString & "'" & _
            " order by id"
        Try
            Dim cmd As DbCommand
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strSql.ToString

            Me._adpt.SelectCommand = cmd

            rslt = Me._adpt.Fill(tabla)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return rslt

    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ntanque"></param>
    ''' <param name="fechaini"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByTanque(ByVal ntanque As UInteger, ByVal fechaini As DateTime) As oleosigDB.opbodegaDataTable
        Dim strSql As String
        Dim entidades As New oleosigDB.opbodegaDataTable




        strSql = "select * from opbodega where tanque ='" & ntanque.ToString() & _
            "' and campagna ='" & Me._campagna.ToString() & _
            "' and fechainicial >='" & fechaini.ToString("yyyy-MM-dd HH:mm:ss") & "'" & _
            " and idalmazara='" & Me._idalmazara.ToString & "'" & _
            " order by id"

        Try
            Dim cmd As DbCommand
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strSql.ToString

            Me._adpt.SelectCommand = cmd

            Me._adpt.Fill(entidades)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return entidades

    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ntanque"></param>
    ''' <param name="fechaini"></param>
    ''' <param name="fechafin"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByTanque(ByVal ntanque As UInteger, ByVal fechaini As DateTime, ByVal fechafin As DateTime) As oleosigDB.opbodegaDataTable
        Dim strSql As New System.Text.StringBuilder
        Dim entidades As New oleosigDB.opbodegaDataTable




        strSql.Append("select * from opbodega")
        strSql.Append(" where tanque ='" & ntanque.ToString & "'")
        strSql.Append(" and campagna ='" & Me._campagna.ToString() & "'")
        strSql.Append(" and idalmazara='" & Me._idalmazara.ToString & "'")
        strSql.Append(" and fechainicial >='" & fechaini.ToString("yyyy-MM-dd HH:mm:ss") & "'")
        strSql.Append(" and fechafinal <='" & fechafin.ToString("yyyy-MM-dd HH:mm:ss") & "'")
        strSql.Append(" order by id")
        Try
            Dim cmd As DbCommand
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strSql.ToString

            Me._adpt.SelectCommand = cmd
            Me._adpt.Fill(entidades)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return entidades
    End Function
    Public Function FillByTanque(ByVal tabla As oleosigDB.opbodegaDataTable, ByVal ntanque As UInteger, ByVal fechaini As DateTime, ByVal fechafin As DateTime) As Integer
        Dim strSql As New System.Text.StringBuilder
        Dim result As Integer

        If _clearBeforeFill Then
            tabla.Clear()
        End If



        strSql.Append("select * from opbodega")
        strSql.Append(" where tanque ='" & ntanque.ToString & "'")
        strSql.Append(" and campagna ='" & Me._campagna.ToString() & "'")
        strSql.Append(" and idalmazara='" & Me._idalmazara.ToString & "'")
        strSql.Append(" and fechainicial >='" & fechaini.ToString("yyyy-MM-dd HH:mm:ss") & "'")
        strSql.Append(" and fechafinal <='" & fechafin.ToString("yyyy-MM-dd HH:mm:ss") & "'")
        strSql.Append(" order by id")
        Try
            Dim cmd As DbCommand
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strSql.ToString

            Me._adpt.SelectCommand = cmd
            result = Me._adpt.Fill(tabla)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return result
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataById(ByVal Id As UInteger) As oleosigDB.opbodegaDataTable
        Dim strSql As String

        Dim entidad As New oleosigDB.opbodegaDataTable


        strSql = "select * from opbodega where id='" & Id.ToString & "'" & _
            " and campagna ='" & Me._campagna.ToString() & "'"

        Dim cmd As DbCommand
        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strSql.ToString
        Me._adpt.SelectCommand = cmd


        Me._adpt.Fill(entidad)

        Return entidad

    End Function
    Public Function FillById(ByVal tabla As oleosigDB.opbodegaDataTable, ByVal Id As UInteger) As Integer
        Dim strSql As String

        If _clearBeforeFill Then
            tabla.Clear()
        End If


        strSql = "select * from opbodega where id='" & Id.ToString & "'" & _
            " and campagna ='" & Me._campagna.ToString() & "'"

        Dim cmd As DbCommand
        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strSql.ToString
        Me._adpt.SelectCommand = cmd


        Return Me._adpt.Fill(tabla)



    End Function
    Public Function GetDataByMolturacion(ByVal molturacion As Integer) As oleosigDB.opbodegaDataTable
        Dim tabla As New oleosigDB.opbodegaDataTable
        Dim cmd As DbCommand
        Dim strsql As New System.Text.StringBuilder

        strsql.Append("select opbodega from detalles_opbodega where opfabrica='" & molturacion.ToString & "'")
        strsql.Append(" and idalmazara='" & Me._idalmazara.ToString & "'")
        strsql.Append(" and campagna='" & Me._campagna.ToString & "'")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = strsql.ToString

        If (cmd.Connection.State And ConnectionState.Open) <> ConnectionState.Open Then
            cmd.Connection.Open()
        End If

        Dim rslt As Object = cmd.ExecuteScalar()

        If cmd.Connection.State = ConnectionState.Open Then
            cmd.Connection.Close()
        End If


        If rslt IsNot Nothing Then
            strsql.Length = 0
            strsql.Append("select * from opbodega where id ='" & rslt.ToString & "'")

            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strsql.ToString

            Me._adpt.SelectCommand = cmd

            Me._adpt.Fill(tabla)

        End If

        Return tabla

    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Op"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByOperacion(ByVal Op As Integer) As oleosigDB.opbodegaDataTable

        Dim strSql As String
        Dim entidad As oleosigDB.opbodegaDataTable = New oleosigDB.opbodegaDataTable



        strSql = "select * from opbodega where operacion ='" & Op.ToString() & "'" & _
            " and campagna ='" & Me._campagna.ToString() & "'" & _
            " and idalmazara='" & Me._idalmazara.ToString & "'"

        Dim cmd As DbCommand
        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strSql.ToString

        Me._adpt.SelectCommand = cmd

        Me._adpt.Fill(entidad)

        Return entidad

    End Function

    Public Function FillByOperacion(ByVal tabla As oleosigDB.opbodegaDataTable, ByVal Op As Integer) As Integer
        Dim strSql As String

        If _clearBeforeFill Then
            tabla.Clear()
        End If



        strSql = "select * from opbodega where operacion ='" & Op.ToString() & "'" & _
            " and campagna ='" & Me._campagna.ToString() & "'" & _
            " and idalmazara='" & Me._idalmazara.ToString & "'"

        Dim cmd As DbCommand
        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strSql.ToString

        Me._adpt.SelectCommand = cmd

        Return Me._adpt.Fill(tabla)

    End Function


    Public Function Fill(ByVal tabla As oleosigDB.opbodegaDataTable) As Integer
        Dim rslt As Integer = -1
        Me._adpt.SelectCommand = _comandos(0)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(Me._idalmazara, Integer)
        Me._adpt.SelectCommand.Parameters(":campagna").Value = CType(Me._campagna, Integer)

        If _clearBeforeFill Then
            tabla.Clear()
        End If
        Try
            rslt = Me._adpt.Fill(tabla)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return rslt
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetData() As oleosigDB.opbodegaDataTable

        Dim entidades As oleosigDB.opbodegaDataTable = New oleosigDB.opbodegaDataTable()

        Try
            Me._adpt.SelectCommand = _comandos(0)
            Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(_idalmazara, Integer)
            Me._adpt.SelectCommand.Parameters(":campagna").Value = CType(_campagna, Integer)

            Me._adpt.Fill(entidades)

        Catch ex As Exception

            Throw

        End Try

        Return entidades

    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="fechaini"></param>
    ''' <param name="fechafin"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByFechas(ByVal fechaini As Date, ByVal fechafin As Date) As oleosigDB.opbodegaDataTable

        Dim entidades As New oleosigDB.opbodegaDataTable
        Dim strsql As String



        strsql = "select * from opbodega where fechainicial >='" & fechaini.ToString("yyyy-MM-dd HH:mm:ss") & _
            "' and fechafinal <=" & fechafin.ToString("yyyy-MM-dd HH:mm:ss") & _
            "' and campagna='" & Me._campagna.ToString() & "'" & _
            " and idalmazara='" & Me._idalmazara.ToString & "'"

        Try
            Dim cmd As DbCommand
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strsql.ToString

            Me._adpt.SelectCommand = cmd

            Me._adpt.Fill(entidades)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return entidades

    End Function

    Public Function FillDataByFechas(ByVal tabla As oleosigDB.opbodegaDataTable, ByVal fechaini As Date, ByVal fechafin As Date) As Integer
        Dim result As Integer = 0
        Dim strsql As String

        If _clearBeforeFill Then
            tabla.Clear()
        End If

        strsql = "select * from opbodega where fechainicial >='" & fechaini.ToString("yyyy-MM-dd HH:mm:ss") & _
            "' and fechafinal <=" & fechafin.ToString("yyyy-MM-dd HH:mm:ss") & _
            "' and campagna='" & Me._campagna.ToString() & "'" & _
            " and idalmazara='" & Me._idalmazara.ToString & "'"

        Try
            Dim cmd As DbCommand
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strsql.ToString

            Me._adpt.SelectCommand = cmd

            result = Me._adpt.Fill(tabla)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return result

    End Function


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="operacion"></param>
    ''' <remarks></remarks>
    Public Function Insert(ByVal idalmazara As Integer, ByVal operacion As Integer, ByVal fechainicial As DateTime, ByVal fechafinal As DateTime, ByVal tanque As Integer, ByVal tipo As Integer, ByVal destino As String, ByVal campagna As Integer, ByVal abierta As Boolean, ByVal actualizada As Boolean) As Integer
        Dim strSql As New System.Text.StringBuilder
        Dim op As oleosigDB.opbodegaDataTable
        Dim resultado As Integer

        Me._adpt.InsertCommand.Parameters(":idalmazara").Value = CType(idalmazara, Integer)
        Me._adpt.InsertCommand.Parameters(":operacion").Value = CType(operacion, Integer)
        Me._adpt.InsertCommand.Parameters(":fechainicial").Value = CType(fechainicial, DateTime)
        Me._adpt.InsertCommand.Parameters(":fechafinal").Value = CType(fechafinal, DateTime)
        Me._adpt.InsertCommand.Parameters(":tanque").Value = CType(tanque, Integer)
        Me._adpt.InsertCommand.Parameters(":tipo").Value = CType(tipo, Integer)
        Me._adpt.InsertCommand.Parameters(":destino").Value = CType(destino, String)
        Me._adpt.InsertCommand.Parameters(":campagna").Value = CType(campagna, Integer)
        Me._adpt.InsertCommand.Parameters(":abierta").Value = CType(abierta, Boolean)
        Me._adpt.InsertCommand.Parameters(":importada").Value = CType(actualizada, Boolean)

        If (Me._adpt.InsertCommand.Connection.State And ConnectionState.Open) <> ConnectionState.Open Then
            Me._adpt.InsertCommand.Connection.Open()
        End If

        Me._adpt.InsertCommand.ExecuteNonQuery()

        op = Me.GetDataByOperacion(operacion)
        If op.Rows.Count = 0 Then
            resultado = 0
        Else
            resultado = op.Rows(0)("id")
        End If
        Return resultado
    End Function
    Public Overridable Overloads Function Update(ByVal dt As oleosigDB) As Integer
        Return Me._adpt.Update(dt, "opbodega")
    End Function
    Public Overridable Overloads Function Update(ByVal tabla As oleosigDB.opbodegaDataTable) As Integer
        Return Me._adpt.Update(tabla)
    End Function

    Public Overridable Overloads Function Update(ByVal opbodega As oleosigDB.detalles_loteaceiteRow) As Integer
        Return Me._adpt.Update(New DataRow() {opbodega})
    End Function
    Private Sub inicia_comandos()
        Dim strsql As New Text.StringBuilder
        Dim cmd As DbCommand
        Dim param As DbParameter

        _comandos = New List(Of DbCommand)


        strsql.Length = 0

        strsql.Append("select * from opbodega where idalmazara=:idalmazara")
        strsql.Append(" and campagna=:campagna order by id")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = strsql.ToString


        param = cdatos.CreateParameter
        param.DbType = DbType.Int32
        param.ParameterName = ":idalmazara"
        param.SourceColumn = "idalmazara"

        cmd.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.DbType = DbType.Int32
        param.ParameterName = ":campagna"
        param.SourceColumn = "campagna"

        cmd.Parameters.Add(param)

        _comandos.Add(cmd)

    End Sub
    Private Sub inicia_datos()
        Dim strsql As New System.Text.StringBuilder
        Dim cmd As DbCommand
        Dim datamaper As DataTableMapping
        Dim param As DbParameter

        datamaper = New DataTableMapping("Table", "opbodega")

        datamaper.ColumnMappings.Add("id", "Id")
        datamaper.ColumnMappings.Add("idalmazara", "Idalmazara")
        datamaper.ColumnMappings.Add("operacion", "Operacion")
        datamaper.ColumnMappings.Add("fechainicial", "FechaInicial")
        datamaper.ColumnMappings.Add("fechafinal", "FechaFinal")
        datamaper.ColumnMappings.Add("tanque", "Tanque")
        datamaper.ColumnMappings.Add("tipo", "Tipo")
        datamaper.ColumnMappings.Add("destino", "Destino")
        datamaper.ColumnMappings.Add("campagna", "Campaña")
        datamaper.ColumnMappings.Add("abierta", "Abierta")
        datamaper.ColumnMappings.Add("importada", "Importada")

        Me._adpt.TableMappings.Add(datamaper)

        Try
            strsql.Length = 0

            strsql.Append("insert into opbodega(")
            strsql.Append("idalmazara,")
            strsql.Append("operacion,")
            strsql.Append("fechainicial,")
            strsql.Append("fechafinal,")
            strsql.Append("tanque,")
            strsql.Append("tipo,")
            strsql.Append("destino,")
            strsql.Append("campagna,")
            strsql.Append("abierta,")
            strsql.Append("importada)")
            strsql.Append(" values(")
            strsql.Append(":idalmazara,")
            strsql.Append(":operacion,")
            strsql.Append(":fechainicial,")
            strsql.Append(":fechafinal,")
            strsql.Append(":tanque,")
            strsql.Append(":tipo,")
            strsql.Append(":destino,")
            strsql.Append(":campagna,")
            strsql.Append(":abierta,")
            strsql.Append(":importada)")

            cmd = cdatos.CreateCommand()
            cmd.Connection = Me._conexion
            cmd.CommandText = strsql.ToString()

            Me._adpt.InsertCommand = cmd

            strsql.Length = 0

            strsql.Append("update opbodega set")
            strsql.Append(" idalmazara=:idalmazara,")
            strsql.Append(" fechainicial =:fechainicial,")
            strsql.Append(" fechafinal =:fechafinal,")
            strsql.Append(" tanque =:tanque,")
            strsql.Append(" tipo =:tipo,")
            strsql.Append(" destino =:destino,")
            strsql.Append(" abierta =:abierta,")
            strsql.Append(" importada =:importada,")
            strsql.Append(" campagna =:campagna")
            strsql.Append(" where id=:id")

            cmd = cdatos.CreateCommand()
            cmd.Connection = Me._conexion
            cmd.CommandText = strsql.ToString()

            Me._adpt.UpdateCommand = cmd

            strsql.Length = 0
            strsql.Append("delete from opbodega where id=:id")

            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strsql.ToString

            Me._adpt.DeleteCommand = cmd

            param = cdatos.CreateParameter
            param.ParameterName = ":id"
            param.SourceColumn = "id"
            param.DbType = DbType.Int32

            Me._adpt.DeleteCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = cdatos.CreateParameter
            param.ParameterName = ":idalmazara"
            param.SourceColumn = "idalmazara"
            param.DbType = DbType.Int32

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = cdatos.CreateParameter
            param.ParameterName = ":operacion"
            param.SourceColumn = "operacion"
            param.DbType = DbType.Int32

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = cdatos.CreateParameter
            param.ParameterName = ":fechainicial"
            param.SourceColumn = "fechainicial"
            param.DbType = DbType.DateTime

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = cdatos.CreateParameter
            param.ParameterName = ":fechafinal"
            param.SourceColumn = "fechafinal"
            param.DbType = DbType.DateTime

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = cdatos.CreateParameter
            param.ParameterName = ":tanque"
            param.SourceColumn = "tanque"
            param.DbType = DbType.Int32

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = cdatos.CreateParameter
            param.ParameterName = ":tipo"
            param.SourceColumn = "tipo"
            param.DbType = DbType.Int32

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

            param = cdatos.CreateParameter
            param.ParameterName = ":destino"
            param.SourceColumn = "destino"
            param.DbType = DbType.String

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

            param = cdatos.CreateParameter
            param.ParameterName = ":importada"
            param.SourceColumn = "importada"
            param.DbType = DbType.Boolean

            Me._adpt.InsertCommand.Parameters.Add(param)
            Me._adpt.UpdateCommand.Parameters.Add(param)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub New(ByVal campagna As Byte, ByVal idalmazara As Integer)
        MyBase.New()
        Me._campagna = campagna
        Me._idalmazara = idalmazara
        _clearBeforeFill = True

        Me._conexion = cdatos.GetConnection
        Me._adpt = cdatos.CreateDataAdapter

        inicia_comandos()
        inicia_datos()


    End Sub



    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub
End Class