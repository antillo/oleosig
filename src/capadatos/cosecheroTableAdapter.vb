Option Strict Off
Option Explicit On

Imports System.Data.Common

Public Class cosecheroTableAdapter


    Private _idalmazara As Integer
    Private _adpt As DbDataAdapter
    Private cdatos As New CBaseDatos
    Private _conexion As DbConnection
    Private _clearBeforeFill As Boolean
    Private _comandos As List(Of DbCommand)

    
  
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Nombre"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetByNombre(ByVal Nombre As String) As oleosigDB.cosecherosRow
        Dim strsql As String
        Dim entidad As oleosigDB.cosecherosRow
        Dim lector As DbDataReader


        strsql = "select * from socios where socNombre = '" & Nombre & "' and idalmazara='" & Me._idalmazara.ToString & "'"

        Try
            Dim cmd As DbCommand
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strsql.ToString
            If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
                Me._conexion.Open()
            End If

            lector = cmd.ExecuteReader(CommandBehavior.CloseConnection)


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        Return entidad


    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Limpiar()
        Dim strsql As String

        strsql = "delete from cosecheros where idalmazara='" & Me._idalmazara.ToString & "'"

        cDatos.Haz(strsql)

    End Sub
    Public Function Delete(ByVal cosechero As Integer) As Integer
        Dim rslt As Integer

        Me._adpt.DeleteCommand.Parameters(":id").Value = CType(cosechero, Integer)
        Dim constate As ConnectionState = Me._adpt.DeleteCommand.Connection.State

        If (constate And ConnectionState.Open) <> ConnectionState.Open Then
            Me._adpt.DeleteCommand.Connection.Open()
        End If

        rslt = Me._adpt.DeleteCommand.ExecuteNonQuery()

        If constate = ConnectionState.Closed Then
            Me._adpt.DeleteCommand.Connection.Close()
        End If
        Return rslt
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetLastNumCosechero() As Integer
        Dim strsql As String
        Dim cmd As DbCommand
        Dim valordevuelto As Integer

        strsql = "select max(soccodigo) from cosecheros where idalmazara='" & Me._idalmazara.ToString & "'"

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
            Me._conexion.Open()
        End If

        Dim resultado = cmd.ExecuteScalar
        Me._conexion.Close()

        If resultado Is Nothing Then
            valordevuelto = 0

            If IsDBNull(resultado) Then
                valordevuelto = 0
            Else
                valordevuelto = CType(resultado, Integer)
            End If

        End If


        Return valordevuelto

    End Function



    ''' <summary>
    ''' Inserta un cosechero en la base de datos
    ''' </summary>
    ''' <param name="codigo">numero de la cooperativa del cosechero</param>
    ''' <param name="idfaeca">numero de faeca del cosechero</param>
    ''' <param name="idalmazara">identificador de oleosig de la cooperativa</param>
    ''' <param name="nombre">nombre del cosechero</param>
    ''' <param name="apellido1">primer apellido del cosechero</param>
    ''' <param name="apellido2">segundo apellido del cosechero</param>
    ''' <param name="nif">nif del cosechero</param>
    ''' <param name="direccion">direccion del cosechero</param>
    ''' <param name="poblacion">poblacion del cosechero</param>
    ''' <param name="provincia">provincia donde vive el cosechero</param>
    ''' <param name="cp">codigo postal</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Insert(ByVal codigo As Integer, ByVal idfaeca As Integer, ByVal idalmazara As Integer, ByVal nombre As String, ByVal apellido1 As String, ByVal apellido2 As String,
                           ByVal nif As String, ByVal direccion As String, ByVal poblacion As String, ByVal provincia As String, ByVal cp As Integer) As Integer

        Dim rslt As Integer

        Me._adpt.InsertCommand.Parameters(":soccodigo").Value = CType(codigo, Integer)
        Me._adpt.InsertCommand.Parameters(":idfaeca").Value = CType(idfaeca, Integer)
        Me._adpt.InsertCommand.Parameters(":idalmazara").Value = CType(idalmazara, Integer)
        Me._adpt.InsertCommand.Parameters(":socnombre").Value = CType(nombre, String)
        Me._adpt.InsertCommand.Parameters(":socapellido1").Value = CType(apellido1, String)
        Me._adpt.InsertCommand.Parameters(":socapellido2").Value = CType(apellido2, String)
        Me._adpt.InsertCommand.Parameters(":socnif").Value = CType(nif, String)
        Me._adpt.InsertCommand.Parameters(":socdireccion").Value = CType(direccion, String)
        Me._adpt.InsertCommand.Parameters(":socmatricula").Value = "."
        Me._adpt.InsertCommand.Parameters(":socpoblacion").Value = CType(poblacion, String)
        Me._adpt.InsertCommand.Parameters(":socprovincia").Value = CType(provincia, String)
        Me._adpt.InsertCommand.Parameters(":soccp").Value = CType(cp, Integer)

        Dim stadoconn As ConnectionState = Me._adpt.InsertCommand.Connection.State

        If (stadoconn And ConnectionState.Open) <> ConnectionState.Open Then
            Me._adpt.InsertCommand.Connection.Open()
        End If

        rslt = Me._adpt.InsertCommand.ExecuteNonQuery()

        If stadoconn = ConnectionState.Closed Then
            Me._adpt.InsertCommand.Connection.Close()
        End If

        Return rslt
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tabla"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Fill(ByVal tabla As oleosigDB.cosecherosDataTable) As Integer
        If Me._clearBeforeFill Then
            tabla.Clear()
        End If
        Me._adpt.SelectCommand = Me._comandos(0)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(Me._idalmazara, Integer)

        Return Me._adpt.Fill(tabla)

    End Function


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetData() As oleosigDB.cosecherosDataTable
        Dim entidades As New oleosigDB.cosecherosDataTable


        Try
        
            Me._adpt.SelectCommand = Me._comandos(0)
            Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(Me._idalmazara, Integer)
            Me._adpt.Fill(entidades)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return entidades

    End Function
    Public Function Update(ByVal tabla As oleosigDB.cosecherosDataTable) As Integer
        Return Me._adpt.Update(tabla)
    End Function
    Public Function Update(ByVal ds As oleosigDB) As Integer
        Return Me._adpt.Update(ds, "cosecheros")

    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getAllIds() As List(Of Integer)
        Dim strsql As String
        Dim lector As DbDataReader
        Dim retorno As New List(Of Integer)

        strsql = "select id from cosecheros where idalmazara='" & Me._idalmazara.ToString & "' order by socCodigo"

        Dim cmd As DbCommand
        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString
        If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
            Me._conexion.Open()
        End If
        lector = cmd.ExecuteReader(CommandBehavior.CloseConnection)



        Do While lector.Read()

            retorno.Add(lector.GetInt32(0))

        Loop
        lector.Close()
        Return retorno

    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="nif"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByNif(ByVal nif As String) As oleosigDB.cosecherosDataTable
        Dim strsql As String
        Dim tabla As New oleosigDB.cosecherosDataTable

        strsql = "select * from cosecheros where socnif='" & nif & "' and idalmazara='" & Me._idalmazara.ToString & "'"
        Try
            Dim cmd As DbCommand
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strsql.ToString
            cmd.CommandType = CommandType.Text

            Me._adpt.SelectCommand = cmd
            Me._adpt.Fill(tabla)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return tabla
    End Function


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getAllCodSocio() As List(Of Integer)
        Dim strsql As String
        Dim lector As DbDataReader
        Dim retorno As New List(Of Integer)

        strsql = "select socCodigo from cosecheros where idalmazara='" & Me._idalmazara.ToString & "' order by socCodigo"

        Dim cmd As DbCommand
        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString
        If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
            Me._conexion.Open()
        End If
        lector = cmd.ExecuteReader(CommandBehavior.CloseConnection)



        Do While lector.Read()

            retorno.Add(lector.GetInt32(0))

        Loop
        lector.Close()
        Return retorno

    End Function


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="codigo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByCodigo(ByVal codigo As Integer) As oleosigDB.cosecherosDataTable
        Dim strsql As String
        Dim tabla As New oleosigDB.cosecherosDataTable


        strsql = "select * from cosecheros where soccodigo = '" & codigo.ToString() & "' and idalmazara='" & Me._idalmazara.ToString & "'"

        Try
            Dim cmd As DbCommand
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strsql.ToString
            cmd.CommandType = CommandType.Text

            Me._adpt.SelectCommand = cmd
            
            Me._adpt.Fill(tabla)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return tabla

    End Function


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="codigo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ExisteSocio(ByVal codigo As Integer) As Boolean
        Dim strsql As String
        Dim resultado As ULong
        Dim valordevuelto As Boolean
        Dim cmd As DbCommand

        strsql = "select count(*) from cosecheros where soccodigo = '" & codigo.ToString() & "' and idalmazara='" & Me._idalmazara.ToString & "'"
        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql
        If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
            _conexion.Open()
        End If
        resultado = CType(cmd.ExecuteScalar, ULong)
        _conexion.Close()
        If resultado = 0 Then
            valordevuelto = False
        ElseIf resultado > 0 Then
            valordevuelto = True
        End If

        Return valordevuelto


    End Function


    Public Function ExisteSocio(ByVal nif As String) As Boolean
        Dim strsql As String
        Dim valordevuelto As Boolean
        Dim resultado As Object
        Dim cmd As DbCommand

        strsql = "select count(*) from cosecheros where socnif='" & nif & "' and idalmazara='" & Me._idalmazara.ToString & "'"
        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql

        If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
            _conexion.Open()
        End If
        resultado = cmd.ExecuteScalar
        _conexion.Close()

        If resultado Is Nothing Then
            valordevuelto = False
        Else
            If CType(resultado, ULong) > 0 Then
                valordevuelto = True
            Else
                valordevuelto = False

            End If

        End If
        Return valordevuelto
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="entidad"></param>
    ''' <remarks></remarks>
    Public Function Update(ByVal entidad As oleosigDB.cosecherosRow) As Integer
        Dim strsql As New System.Text.StringBuilder

        Return Me._adpt.Update(New DataRow() {entidad})

    End Function

    Private Sub inicia_comandos()
        Dim comando As DbCommand
        Dim strsql As New System.Text.StringBuilder
        Dim param As DbParameter

        Me._comandos = New List(Of DbCommand)

        comando = Me.cdatos.CreateCommand
        comando.CommandText = "select * from cosecheros where idalmazara=:idalmazara order by id"
        comando.Connection = Me.cdatos.GetConnection

        param = cdatos.CreateParameter
        param.ParameterName = ":idalmazara"
        param.DbType = DbType.Int32
        param.SourceColumn = "idalmazara"

        comando.Parameters.Add(param)

        _comandos.Add(comando)

    End Sub
    Private Sub inicia_Datos()
        Dim comando As DbCommand
        Dim strsql As New System.Text.StringBuilder
        Dim param As DbParameter
        Dim datamaper As DataTableMapping

        datamaper = New DataTableMapping("Table", "cosecheros")
        datamaper.ColumnMappings.Add("id", "Id")
        datamaper.ColumnMappings.Add("soccodigo", "Codigo")
        datamaper.ColumnMappings.Add("idfaeca", "Idfaeca")
        datamaper.ColumnMappings.Add("idalmazara", "Idalmazara")
        datamaper.ColumnMappings.Add("socnombre", "Nombre")
        datamaper.ColumnMappings.Add("socapellido1", "Apellido1")
        datamaper.ColumnMappings.Add("socapellido2", "Apellido2")
        datamaper.ColumnMappings.Add("socnif", "Nif")
        datamaper.ColumnMappings.Add("socdireccion", "Direccion")
        datamaper.ColumnMappings.Add("socpoblacion", "Poblacion")
        datamaper.ColumnMappings.Add("socprovincia", "Provincia")
        datamaper.ColumnMappings.Add("soccp", "Cp")

        Me._adpt.TableMappings.Add(datamaper)
        
        strsql.Length = 0

        strsql.Append("insert into cosecheros (")
        strsql.Append("soccodigo,")
        strsql.Append("idfaeca,")
        strsql.Append("idalmazara,")
        strsql.Append("socnombre,")
        strsql.Append("socapellido1,")
        strsql.Append("socapellido2,")
        strsql.Append("socnif,")
        strsql.Append("socdireccion,")
        strsql.Append("socmatricula,")
        strsql.Append("socpoblacion,")
        strsql.Append("socprovincia,")
        strsql.Append("soccp)")
        strsql.Append(" values(")
        strsql.Append(":soccodigo,")
        strsql.Append(":idfaeca,")
        strsql.Append(":idalmazara,")
        strsql.Append(":socnombre,")
        strsql.Append(":socapellido1,")
        strsql.Append(":socapellido2,")
        strsql.Append(":socnif,")
        strsql.Append(":socdireccion,")
        strsql.Append(":socmatricula,")
        strsql.Append(":socpoblacion,")
        strsql.Append(":socprovincia,")
        strsql.Append(":soccp)")




        comando = Me.cdatos.CreateCommand
        comando.CommandText = strsql.ToString()
        comando.Connection = Me.cdatos.GetConnection

        Me._adpt.InsertCommand = comando


        strsql.Length = 0

        strsql.Append("update cosecheros set ")
        strsql.Append("soccodigo =:soccodigo,")
        strsql.Append("idfaeca = :idfaeca,")
        strsql.Append("socnombre =:socnombre,")
        strsql.Append("socapellido1 =:socapellido1,")
        strsql.Append("socApellido2 =:socapellido2,")
        strsql.Append("socnif =:socnif,")
        strsql.Append("socdireccion =:socdireccion,")
        strsql.Append("socmatricula =:socmatricula,")
        strsql.Append("socpoblacion =:socpoblacion,")
        strsql.Append("socprovincia =:socprovincia,")
        strsql.Append("soccp =:soccp ")
        strsql.Append("where id=:id")

        comando = Me.cdatos.CreateCommand
        comando.CommandText = strsql.ToString()
        comando.Connection = cdatos.GetConnection

        Me._adpt.UpdateCommand = comando

        strsql.Length = 0

        strsql.Append("delete from cosecheros where id=:id")

        comando = Me.cdatos.CreateCommand
        comando.CommandText = strsql.ToString()
        comando.Connection = Me.cdatos.GetConnection

        Me._adpt.DeleteCommand = comando

        param = cdatos.CreateParameter
        param.ParameterName = ":id"
        param.DbType = DbType.Int32
        param.SourceColumn = "id"

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.DeleteCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":idalmazara"
        param.DbType = DbType.Int32
        param.SourceColumn = "idalmazara"
        param.Value = Me._idalmazara



        Me._adpt.InsertCommand.Parameters.Add(param)


        param = cdatos.CreateParameter
        param.ParameterName = ":soccodigo"
        param.DbType = DbType.Int32
        param.SourceColumn = "soccodigo"

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":idfaeca"
        param.DbType = DbType.Int32
        param.SourceColumn = "idfaeca"

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":socnombre"
        param.DbType = DbType.String
        param.SourceColumn = "socnombre"

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)


        param = cdatos.CreateParameter
        param.ParameterName = ":socapellido1"
        param.DbType = DbType.String
        param.SourceColumn = "socapellido1"

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":socapellido2"
        param.DbType = DbType.String
        param.SourceColumn = "socapellido2"

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)


        param = cdatos.CreateParameter
        param.ParameterName = ":socnif"
        param.DbType = DbType.String
        param.SourceColumn = "socnif"

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)


        param = cdatos.CreateParameter
        param.ParameterName = ":socdireccion"
        param.DbType = DbType.String
        param.SourceColumn = "socdireccion"

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":socmatricula"
        param.DbType = DbType.String
        param.SourceColumn = "socmatricula"


        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":socpoblacion"
        param.DbType = DbType.String
        param.SourceColumn = "socpoblacion"

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)


        param = cdatos.CreateParameter
        param.ParameterName = ":socprovincia"
        param.DbType = DbType.String
        param.SourceColumn = "socprovincia"

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":soccp"
        param.DbType = DbType.Int32
        param.SourceColumn = "soccp"

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

    End Sub

    Public Sub New(ByVal idalmazara As Integer)

        MyBase.New()
        Me._idalmazara = idalmazara
        Me._clearBeforeFill = True


        Me._conexion = Me.cdatos.GetConnection
        Me._adpt = Me.cdatos.CreateDataAdapter

        inicia_Datos()
        inicia_comandos()

    End Sub


    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub


End Class
