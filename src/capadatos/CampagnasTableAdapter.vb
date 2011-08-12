Option Strict Off
Option Explicit On

Imports System.Data.Common
Imports System.Data
Imports System.ComponentModel

Public Class CampagnaDB



    Private _idalmazara As Integer
    Private _adpt As DbDataAdapter
    Private cdatos As New CBaseDatos
    Private _conexion As DbConnection
    Private _comandos As List(Of DbCommand)

    Public Property Almazara As Integer
        Get
            Return Me._idalmazara
        End Get
        Set(value As Integer)
            Me._idalmazara = value
        End Set
    End Property

  
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetData() As oleosigDB.campagnasDataTable
        Dim tabla As oleosigDB.campagnasDataTable = New oleosigDB.campagnasDataTable

        Me._adpt.SelectCommand = Me._comandos(0)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(Me._idalmazara, Int32)


        Me._adpt.Fill(tabla)
        Return tabla

    End Function
    Public Function Fill(ByVal tabla As oleosigDB.campagnasDataTable) As Integer
        Me._adpt.SelectCommand = Me._comandos(0)

        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(Me._idalmazara, Int32)
        tabla.Clear()
        Dim result As Integer = Me._adpt.Fill(tabla)
        Return result
    End Function
    Public Function GetLast() As Long
        Dim cmd As DbCommand
        Dim valordevuelto As Long

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = "select max(clave) from campagnas where idalmazara='" & Me._idalmazara.ToString & "'"
        cmd.CommandType = CommandType.Text

        Dim estadoanterior As ConnectionState = cmd.Connection.State
        If (estadoanterior And ConnectionState.Open) <> ConnectionState.Open Then
            cmd.Connection.Open()
        End If
        Dim resultado As Object = cmd.ExecuteScalar()
        If estadoanterior = ConnectionState.Closed Then
            cmd.Connection.Close()
        End If
        If resultado Is Nothing Then
            valordevuelto = 0
        Else
            If IsDBNull(resultado) Then
                valordevuelto = 0
            Else
                valordevuelto = CType(resultado, Long)
            End If
        End If
        Return valordevuelto
    End Function


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="campaña"></param>
    ''' <remarks></remarks>
    Public Sub SelectCampaña_actual(ByVal campaña As oleosigDB.campagnasRow)
        Dim cmd As DbCommand
        Dim param As DbParameter

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandType = CommandType.Text


        param = cdatos.CreateParameter
        param.ParameterName = ":activa"
        param.DbType = DbType.Boolean

        cmd.Parameters.Add(param)

        param = cdatos.CreateParameter()
        param.ParameterName = ":idalmazara"
        param.SourceColumn = "idalmazara"
        param.DbType = DbType.Int32
        param.Value = CType(Me._idalmazara, Int32)

        cmd.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":id"
        param.SourceColumn = "id"
        param.DbType = DbType.Int32
        param.Value = CType(campaña.id, Int32)

        cmd.Parameters.Add(param)


        Dim estadoanterior As ConnectionState = cmd.Connection.State
        If (estadoanterior And ConnectionState.Open) <> ConnectionState.Open Then
            cmd.Connection.Open()
        End If
        cmd.Parameters(":activa").Value = False
        cmd.CommandText = "update campagnas set activa=:activa where idalmazara=:idalmazara"
        cmd.ExecuteNonQuery()

        cmd.Parameters(":activa").Value = True
        cmd.CommandText = "update campagnas set activa=:activa where id=:id"
        cmd.ExecuteNonQuery()

        If estadoanterior = ConnectionState.Closed Then
            cmd.Connection.Close()
        End If

    End Sub



    Public Sub NuevaCampaña(ByVal Nombre As String, ByVal Clave As Byte)
        Dim strsql As New System.Text.StringBuilder
        Dim cmd As DbCommand
        Dim resultado As Long

        strsql.Append("select count(*) from campagnas where idalmazara='" & Me._idalmazara.ToString & "' ")
        strsql.Append("and nombre='" & Nombre & "' ")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString
        cmd.CommandType = CommandType.Text

        If (cmd.Connection.State And ConnectionState.Open) <> ConnectionState.Open Then
            cmd.Connection.Open()
        End If
        resultado = CType(cmd.ExecuteScalar(), Long)
        cmd.Connection.Close()

        If resultado >= 1 Then

            MsgBox("Existe ya una campaña con ese nombre")

        Else

            Me._adpt.InsertCommand.Parameters(":idalmazara").Value = CType(Me._idalmazara, Int32)
            Me._adpt.InsertCommand.Parameters(":nombre").Value = CType(Nombre, String)
            Me._adpt.InsertCommand.Parameters(":clave").Value = CType(Clave, Int32)
            Me._adpt.InsertCommand.Parameters(":activa").Value = False

            If (Me._adpt.InsertCommand.Connection.State And ConnectionState.Open) <> ConnectionState.Open Then
                Me._adpt.InsertCommand.Connection.Open()
            End If
            Me._adpt.InsertCommand.ExecuteNonQuery()
            Me._adpt.InsertCommand.Connection.Close()


        End If

    End Sub

    Public Overridable Overloads Function Update(ByVal oleosig As oleosigDB) As Integer
        Return Me._adpt.Update(oleosig, "campagnas")
    End Function
    Public Overridable Overloads Function Update(ByVal datarow As DataRow) As Integer
        Return Me._adpt.Update(New DataRow() {datarow})
    End Function
    Public Overridable Overloads Function Update(ByVal tabla As oleosigDB.campagnasDataTable) As Integer
        Return Me._adpt.Update(tabla)
    End Function
    Public Overridable Overloads Function Update(ByVal datarows() As DataRow) As Integer
        Return Me._adpt.Update(datarows)
    End Function
    Public Overridable Overloads Function Update(ByVal nombre As String, ByVal clave As Integer, ByVal activa As Boolean) As Integer
        Me._adpt.UpdateCommand.Parameters(":nombre").Value = CType(nombre, String)
        Me._adpt.UpdateCommand.Parameters(":clave").Value = CType(clave, Int32)
        Me._adpt.UpdateCommand.Parameters(":activa").Value = CType(activa, Boolean)
        Dim estadoconexion As ConnectionState = Me._adpt.UpdateCommand.Connection.State
        If (estadoconexion And ConnectionState.Open) <> ConnectionState.Open Then
            Me._adpt.UpdateCommand.Connection.Open()
        End If

        Try
            Dim resultado As Integer = Me._adpt.UpdateCommand.ExecuteNonQuery()
            Return resultado
        Finally
            If estadoconexion = ConnectionState.Closed Then
                Me._adpt.UpdateCommand.Connection.Close()
            End If
        End Try
    End Function

    Public Sub Delete(ByVal id As Integer)


        Me._adpt.DeleteCommand.Parameters(":id").Value = CType(id, Int32)
        Dim conexion_anterior As DbConnection = Me._adpt.DeleteCommand.Connection
        If (Me._adpt.DeleteCommand.Connection.State And ConnectionState.Open) <> ConnectionState.Open Then
            Me._adpt.DeleteCommand.Connection.Open()
        End If

        Me._adpt.DeleteCommand.ExecuteNonQuery()
        If (conexion_anterior.State And ConnectionState.Closed) = ConnectionState.Closed Then
            Me._adpt.DeleteCommand.Connection.Close()
        End If


    End Sub
    Public Sub New()
        MyBase.New()
        Me._idalmazara = 0
        Me._conexion = cdatos.GetConnection
        Me._adpt = Me.cdatos.CreateDataAdapter
        inicia_datos()
        ini_comandos()

    End Sub
    Public Sub New(ByVal idalmazara As Integer)
        MyBase.New()

        Me._idalmazara = idalmazara
        Me._conexion = cdatos.GetConnection
        Me._adpt = Me.cdatos.CreateDataAdapter()


        inicia_datos()
        ini_comandos()

    End Sub


    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub

    Private Sub ini_comandos()
        Dim strsql As New System.Text.StringBuilder
        Dim cmd As DbCommand
        Dim param As DbParameter

        Me._comandos = New List(Of DbCommand)


        strsql.Append("select * from campagnas where idalmazara=:idalmazara order by id")

        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString
        cmd.CommandType = CommandType.Text


        param = Me.cdatos.CreateParameter
        param.ParameterName = ":idalmazara"
        param.SourceColumn = "idalmazara"
        param.DbType = DbType.Int32
        param.Value = Me._idalmazara

        cmd.Parameters.Add(param)

        Me._comandos.Add(cmd)



    End Sub

    '/*******************************************************************************
    '/*
    '/*     cargamos las campañas que hay en la base de datos
    '/*
    '/*******************************************************************************
    Private Sub inicia_datos()

        Dim strSql As String
        Dim cmd As DbCommand
        Dim param As DbParameter
        Dim tablamaping As DataTableMapping

        tablamaping = New DataTableMapping("campagna", "campagna")

        tablamaping.ColumnMappings.Add("id", "id")
        tablamaping.ColumnMappings.Add("idalmazara", "idalamzara")
        tablamaping.ColumnMappings.Add("nombre", "nombre")
        tablamaping.ColumnMappings.Add("clave", "clave")
        tablamaping.ColumnMappings.Add("activa", "activa")

        Me._adpt.TableMappings.Add(tablamaping)


        strSql = "insert into campagnas (idalmazara,nombre,clave,activa) values(:idalmazara,:nombre,:clave,:activa)"
        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strSql

        Me._adpt.InsertCommand = cmd

        strSql = "delete from campagnas where id=:id"
        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strSql

        Me._adpt.DeleteCommand = cmd

        strSql = "update campagnas set nombre=:nombre,clave=:clave,activa=:activa where id=:id"
        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strSql

        Me._adpt.UpdateCommand = cmd


        param = Me.cdatos.CreateParameter
        param.ParameterName = ":id"
        param.SourceColumn = "id"
        param.DbType = DbType.Int32

        Me._adpt.DeleteCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":idalmazara"
        param.SourceColumn = "idalmazara"
        param.DbType = DbType.Int32
        param.Value = Me._idalmazara

        Me._adpt.InsertCommand.Parameters.Add(param)


        param = Me.cdatos.CreateParameter
        param.ParameterName = ":nombre"
        param.SourceColumn = "nombre"
        param.DbType = DbType.String

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":clave"
        param.SourceColumn = "clave"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":activa"
        param.SourceColumn = "activa"
        param.DbType = DbType.Boolean

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)


    End Sub

End Class