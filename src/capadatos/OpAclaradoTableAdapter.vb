Option Strict Off
Option Explicit On

Imports System.Data.Common
Imports System.Text

Public Class OpAclaradoTableAdapter


    Private _campagna As Byte
    Private _idalmazara As Integer
    Private cdatos As New CBaseDatos
    Private _conexion As DbConnection
    Private _adpt As DbDataAdapter
    Dim _clearbeforefill As Boolean
    Dim _lista_comandos As List(Of DbCommand)

  
    Public Function getId(ByVal operacion As Integer, ByVal fechaini As DateTime, ByVal aclarador As Integer) As Integer
        Dim strsql As New StringBuilder
        Dim resultado As Object
        Dim valordevuelto As Integer = 0

        strsql.Append("select id from opaclarado where ")
        strsql.Append("campagna='" & Me._campagna.ToString() & "' ")
        strsql.Append("and idalmazara='" & Me._idalmazara.ToString() & "' ")
        strsql.Append("and operacion='" & operacion.ToString() & "' ")
        strsql.Append("and fechaini='" & fechaini.ToString("yyyy-MM-dd HH:mm:ss") & "' ")
        strsql.Append("and aclarador='" & aclarador.ToString() & "'")

        Try
            Dim cmd As DbCommand
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strsql.ToString
            If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
                Me._conexion.Open()
            End If


            resultado = cmd.ExecuteScalar
            Me._conexion.Close()

            If Not resultado Is Nothing Then
                valordevuelto = CType(resultado, Integer)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return valordevuelto


    End Function


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getLastId() As Integer
        Dim strsql As String
        Dim resultado As Object
        Dim valordevuelto As Integer

        strsql = "select max(id) from opaclarado where campagna='" & Me._campagna.ToString() & "' and idalmazara='" & Me._idalmazara.ToString() & "'"
        Try
            Dim cmd As DbCommand
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strsql.ToString
            If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
                Me._conexion.Open()
            End If

            resultado = cmd.ExecuteScalar
            Me._conexion.Close()

            If resultado Is Nothing Then
                valordevuelto = 0
            Else
                valordevuelto = CType(resultado, Integer)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return valordevuelto
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getLast() As UShort
        Dim strSql As String
        Dim maxid As UShort
        Dim resultado As Object

        strSql = "select max(operacion) from opaclarado where campagna='" & Me._campagna.ToString() & "' and idalmazara='" & Me._idalmazara.ToString & "'"

        Dim cmd As DbCommand
        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strSql.ToString
        If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
            Me._conexion.Open()
        End If

        resultado = cmd.ExecuteScalar
        Me._conexion.Close()



        If Not IsDBNull(resultado) Then
            maxid = CType(resultado, UShort)
        Else
            maxid = 0
        End If
        Return maxid

    End Function



    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Linea"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByLinea(ByVal Linea As UShort) As oleosigDB.opaclaradoDataTable
        Dim strSql As String
        Dim entidades As New oleosigDB.opaclaradoDataTable

        Try
            strSql = "select * from opaclarado where linea='" & Linea.ToString & "' and campagna ='" & Me._campagna.ToString() & "'" & _
                " and idalmazara='" & Me._idalmazara.ToString & "'"
            Dim cmd As DbCommand
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strSql.ToString

            Me._adpt.SelectCommand = cmd

            Me._adpt.Fill(entidades)


        Catch ex As Exception

        End Try
        Return entidades
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Aclarador"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByAclarador(ByVal Aclarador As UShort) As oleosigDB.opaclaradoDataTable
        Dim strSql As String

        Dim entidades As New oleosigDB.opaclaradoDataTable

        strSql = "select * from opaclarado where aclarador ='" & Aclarador.ToString & "'" & _
            " and campagna='" & Me._campagna.ToString() & "'" & _
            " and idalmazara='" & Me._idalmazara.ToString & "'"

        Try
            Dim cmd As DbCommand
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strSql.ToString

            Me._adpt.SelectCommand = cmd
            Me._adpt.Fill(entidades)


        Catch ex As Exception

        End Try

        Return entidades
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="id"></param>
    ''' <remarks></remarks>
    Public Sub Delete(ByVal id As UShort)
        Dim strSql As String
        strSql = "delete from opaclarado"
        strSql = strSql & " where id ='" & id.ToString & "'"

        cDatos.Haz(strSql)


    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Function Update(ByVal tabla As oleosigDB.opaclaradoDataTable) As Integer

        Return Me._adpt.Update(tabla)

    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Insert(ByVal idalmazara As Integer, ByVal operacion As Integer, ByVal fechaini As DateTime, ByVal fechafin As DateTime, ByVal aclarador As Integer, ByVal abierta As Boolean, ByVal kilos As Integer, ByVal campagna As Integer, ByVal importada As Boolean)
        Dim strSql As New StringBuilder


        strSql.Append("insert into opaclarado (")
        strSql.Append("idalmazara,")
        strSql.Append("operacion,")
        strSql.Append("fechaini,")
        strSql.Append("fechafin,")
        strSql.Append("aclarador,")
        strSql.Append("abierta,")
        strSql.Append("campagna,")
        strSql.Append("kilosaceite")
        strSql.Append(") values(")
        strSql.Append("'" & idalmazara.ToString & "',")
        strSql.Append("'" & operacion.ToString & "',")
        strSql.Append("'" & fechaini.ToString("yyyy-MM-dd HH:mm:ss") & "',")
        strSql.Append("'" & fechafin.ToString("yyyy-MM-dd HH:mm:ss") & "',")
        strSql.Append("'" & aclarador.ToString & "',")

        If abierta Then
            strSql.Append("'t',")
        Else
            strSql.Append("'f',")
        End If

        strSql.Append("'" & campagna.ToString & "',")
        strSql.Append("'" & kilos.ToString & "')")

        cdatos.Haz(strSql.ToString)


    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Fill(ByVal tabla As oleosigDB.opaclaradoDataTable) As Integer

        Me._adpt.SelectCommand = Me._lista_comandos(0)

        If _clearbeforefill Then
            tabla.Clear()
        End If

        Return Me._adpt.Fill(tabla)
        
    End Function

    Private Sub inicia_comandos()
        Dim cmd As DbCommand
        Dim param As DbParameter

        Me._lista_comandos = New List(Of DbCommand)


        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = "select * from opaclarado where idalmazara=:idalmazara and campagna=:campagna order by id"
        cmd.CommandType = CommandType.Text


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

        Me._lista_comandos.Add(cmd)



    End Sub

    Private Sub inicia_datos()
        Dim cmd As DbCommand
        Dim param As DbParameter
        Dim tablamaper As DataTableMapping
        Dim strsql As New System.Text.StringBuilder


        tablamaper = New DataTableMapping("Table", "opaclarado")
        tablamaper.ColumnMappings.Add("id", "Id")
        tablamaper.ColumnMappings.Add("idalmazara", "Idalmazara")
        tablamaper.ColumnMappings.Add("operacion", "Operacion")
        tablamaper.ColumnMappings.Add("fechaini", "Fechaini")
        tablamaper.ColumnMappings.Add("fechafin", "Fechafin")
        tablamaper.ColumnMappings.Add("aclarador", "Aclarador")
        tablamaper.ColumnMappings.Add("abierta", "Abierta")
        tablamaper.ColumnMappings.Add("campagna", "Campagna")
        tablamaper.ColumnMappings.Add("importada", "Importada")

        Me._adpt.TableMappings.Add(tablamaper)

        strsql.Length = 0

        

        strsql.Append("insert into opaclarado (idalmazara,operacion,fechaini,fechafin,aclarador,abierta,importada,campagna) values(")
        strsql.Append(":idalmazara,:operacion,:fechaini,:fechafin,:aclarador,:abierta,:importada,:campagna)")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.InsertCommand = cmd

        strsql.Length = 0
        strsql.Append("update opaclarado set ")
        strsql.Append("idalmazara=:idalmazara,")
        strsql.Append("operacion=:operacion,")
        strsql.Append("fechaini=:fechaini,")
        strsql.Append("fechafin=:fechafin,")
        strsql.Append("aclarador=:aclarador,")
        strsql.Append("abierta=:abierta,")
        strsql.Append("importada=:importada,")
        strsql.Append("campagna=:campagna ")
        strsql.Append("where id=:id")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.UpdateCommand = cmd


        strsql.Length = 0
        strsql.Append("delete from opaclarado where id=:id")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.DeleteCommand = cmd

    End Sub



    Public Sub New(ByVal campagna As Byte, ByVal idalmazara As Integer)
        MyBase.New()
        Me._conexion = cdatos.GetConnection
        Me._campagna = campagna
        Me._idalmazara = idalmazara
        Me._adpt = cdatos.CreateDataAdapter

        Me.inicia_comandos()
        Me.inicia_datos()

    End Sub



    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub


End Class