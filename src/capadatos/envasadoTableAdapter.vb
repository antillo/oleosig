Option Strict Off
Option Explicit On

Imports System.Data.Common
Imports System.Text


Partial Public Class envasadoTableAdapter


    Private _campagna As Byte
    Private _idalmazara As Integer

    Private _clearbeforefill As Boolean
    Private _comandos As List(Of DbCommand)

    Private WithEvents _adapt As DbDataAdapter

    Private _conexion As DbConnection

    Private cdatos As New CBaseDatos

    Protected Friend ReadOnly Property Adapter As DbDataAdapter
        Get
            If Me._adapt Is Nothing Then
                Me.inicia_datos()
            End If
            Return Me._adapt
        End Get
    End Property

    Public Sub Update(ByVal ds As oleosigDB)
        Me._adapt.Update(ds, "envasado")
    End Sub

    Public Sub Update(ByVal envasado As oleosigDB.envasadoDataTable)
        Me._adapt.Update(envasado)
    End Sub
    Public Property ClearBeforeFill As Boolean
        Get
            Return Me._clearbeforefill
        End Get
        Set(ByVal value As Boolean)
            Me._clearbeforefill = value
        End Set
    End Property

    Public Property Connection As DbConnection
        Get
            If (Me._conexion Is Nothing) Then
                Me._conexion = cdatos.GetConnection
            End If
            Return Me._conexion
        End Get
        Set(ByVal value As DbConnection)
            Me._conexion = value
        End Set
    End Property



    Public Sub Delete(ByVal id As Integer)

        Me._adapt.DeleteCommand.Parameters(":id").Value = CType(id, Integer)
        If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
            Me._conexion.Open()
        End If
        Me._adapt.DeleteCommand.ExecuteNonQuery()
        Me._conexion.Close()

    End Sub

    Public Function GetData() As oleosigDB.envasadoDataTable
        Dim datatable As oleosigDB.envasadoDataTable = New oleosigDB.envasadoDataTable
        Me._adapt.SelectCommand = _comandos(0)
        Me._adapt.SelectCommand.Parameters(":idalmazara").Value = CType(_idalmazara, Integer)
        Me._adapt.SelectCommand.Parameters(":campagna").Value = CType(_campagna, Integer)
        Me._adapt.Fill(datatable)
        Return datatable

    End Function

    Public Function Fill(ByVal tabla As DataTable) As Integer
        If Me._clearbeforefill Then
            tabla.Clear()
        End If
        Me._adapt.SelectCommand = _comandos(0)
        Me._adapt.SelectCommand.Parameters(":idalmazara").Value = CType(_idalmazara, Integer)
        Me._adapt.SelectCommand.Parameters(":campagna").Value = CType(_campagna, Integer)

        Dim resultado As Integer = Me._adapt.Fill(tabla)
        Return resultado
    End Function
    Private Sub inicia_comandos()
        Dim strsql As New StringBuilder
        Dim cmd As DbCommand
        Dim param As DbParameter

        _comandos = New List(Of DbCommand)

        strsql.Append("select * from envasado where campagna =:campagna and idalmazara=:idalmazara")
        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString


        param = Me.cdatos.CreateParameter
        param.ParameterName = ":idalmazara"
        param.SourceColumn = "idalamzara"
        param.DbType = DbType.Int32
        param.Value = Me._idalmazara

        cmd.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":campagna"
        param.SourceColumn = "campagna"
        param.DbType = DbType.Int32
        param.Value = Me._campagna

        cmd.Parameters.Add(param)

        _comandos.Add(cmd)

    End Sub
    Private Sub inicia_datos()
        Dim strsql As New StringBuilder
        Dim cmd As DbCommand
        Dim param As DbParameter


        Me._adapt = Me.cdatos.CreateDataAdapter()
        Dim tableMapping As New DataTableMapping("Table", "envasado")

        tableMapping.ColumnMappings.Add("id", "id")
        tableMapping.ColumnMappings.Add("idalmazara", "idalmazara")
        tableMapping.ColumnMappings.Add("partida", "partida")
        tableMapping.ColumnMappings.Add("marca", "marca")
        tableMapping.ColumnMappings.Add("fecha_env", "fecha_env")
        tableMapping.ColumnMappings.Add("envase", "envase")
        tableMapping.ColumnMappings.Add("n_envases", "n_envases")
        tableMapping.ColumnMappings.Add("litros", "litros")
        tableMapping.ColumnMappings.Add("campagna", "campagna")
        tableMapping.ColumnMappings.Add("cod_trazabilidad", "cod_trazabilidad")

        Me._adapt.TableMappings.Add(tableMapping)



        strsql.Length = 0
        strsql.Append("delete from envasado where id=:id")

        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adapt.DeleteCommand = cmd

        strsql.Length = 0

        strsql.Append("update envasado set ")
        strsql.Append("partida =:partida,")
        strsql.Append("marca =:marca,")
        strsql.Append("fecha_env =:fecha_env,")
        strsql.Append("envase =:envase,")
        strsql.Append("n_envases =:n_envases,")
        strsql.Append("litros =:litros,")
        strsql.Append("where id =:id")

        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adapt.UpdateCommand = cmd

        strsql.Length = 0

        strsql.Append("insert into envasado (")
        strsql.Append("idalmazara,")
        strsql.Append("partida,")
        strsql.Append("marca,")
        strsql.Append("fecha_env,")
        strsql.Append("envase,")
        strsql.Append("n_envases,")
        strsql.Append("litros,")
        strsql.Append("campagna,")
        strsql.Append("cod_trazabilidad) values (")
        strsql.Append(":idalmazara,")
        strsql.Append(":partida,")
        strsql.Append(":marca,")
        strsql.Append(":fecha_env,")
        strsql.Append(":envase,")
        strsql.Append(":n_envases,")
        strsql.Append(":litros,")
        strsql.Append(":campagna,")
        strsql.Append(":cod_trazabilidad)")

        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adapt.InsertCommand = cmd


        param = Me.cdatos.CreateParameter
        param.ParameterName = ":id"
        param.SourceColumn = "id"
        param.DbType = DbType.Int32


        Me._adapt.DeleteCommand.Parameters.Add(param)
        Me._adapt.UpdateCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":idalmazara"
        param.SourceColumn = "idalamzara"
        param.DbType = DbType.Int32
        param.Value = Me._idalmazara


        Me._adapt.InsertCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":partida"
        param.SourceColumn = "partida"
        param.DbType = DbType.Int32

        Me._adapt.InsertCommand.Parameters.Add(param)
        Me._adapt.UpdateCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":marca"
        param.SourceColumn = "marca"
        param.DbType = DbType.Int32

        Me._adapt.InsertCommand.Parameters.Add(param)
        Me._adapt.UpdateCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":fecha_env"
        param.SourceColumn = "fecha_env"
        param.DbType = DbType.DateTime

        Me._adapt.InsertCommand.Parameters.Add(param)
        Me._adapt.UpdateCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":envase"
        param.SourceColumn = "envase"
        param.DbType = DbType.Int32

        Me._adapt.InsertCommand.Parameters.Add(param)
        Me._adapt.UpdateCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":n_envases"
        param.SourceColumn = "n_envases"
        param.DbType = DbType.Int32

        Me._adapt.InsertCommand.Parameters.Add(param)
        Me._adapt.UpdateCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":litros"
        param.SourceColumn = "litros"
        param.DbType = DbType.Int32

        Me._adapt.InsertCommand.Parameters.Add(param)
        Me._adapt.UpdateCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":campagna"
        param.SourceColumn = "campagna"
        param.DbType = DbType.Int32
        param.Value = Me._campagna


        Me._adapt.InsertCommand.Parameters.Add(param)
        Me._adapt.UpdateCommand.Parameters.Add(param)


    End Sub



    Public Sub New(ByVal campagna As Byte, ByVal idalmazara As Integer)
        MyBase.New()
        cdatos = New CBaseDatos
        Me._conexion = cdatos.GetConnection
        Me._campagna = campagna
        Me._idalmazara = idalmazara

        Me._clearbeforefill = True

        Me.inicia_datos()
        Me.inicia_comandos()

    End Sub


    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub


End Class