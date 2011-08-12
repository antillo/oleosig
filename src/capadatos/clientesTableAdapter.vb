Option Strict Off
Option Explicit On

Imports System.Text
Imports System.Data.Common

Public Class clientesTableAdapter


    Private _idalmazara As Integer

    Private _adpt As DbDataAdapter
    Private cdatos As New CBaseDatos
    Private _conexion As DbConnection
    Private _listacomandos As List(Of DbCommand)
    Private _clearBeforeFill As Boolean

    Public Overridable Overloads Function GetData() As oleosigDB.clientesDataTable
        Dim tabla As New oleosigDB.clientesDataTable
        Me._adpt.SelectCommand = _listacomandos(0)

        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(_idalmazara, Integer)

        Me._adpt.Fill(tabla)
        Return tabla
    End Function

    Public Overridable Overloads Function Fill(ByVal tabla As oleosigDB.clientesDataTable) As Integer
        If _clearBeforeFill Then
            tabla.Clear()
        End If
        Me._adpt.SelectCommand = _listacomandos(0)

        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(_idalmazara, Integer)

        Return Me._adpt.Fill(tabla)

    End Function


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getLastId() As UShort
        Dim cmd As DbCommand
        Dim resultado As Object
        Dim valordevuelto As UShort

        cmd = Me.cdatos.CreateCommand

        cmd.CommandText = "select max(id) from clientes where idalmazara='" & Me._idalmazara.ToString & "'"
        If Me._conexion.State = ConnectionState.Closed Or Me._conexion.State = ConnectionState.Broken Then
            Me._conexion.Open()
        End If
        resultado = cmd.ExecuteScalar

        Me._conexion.Close()


        If IsDBNull(resultado) Then
            valordevuelto = 0
        Else
            valordevuelto = CType(resultado, UShort)
        End If

        Return valordevuelto
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getLastNumCliente() As ULong
        Dim cmd As DbCommand
        Dim resultado As ULong


        Try
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion

            cmd.CommandText = "select max(numcliente) from clientes where idalmazara='" & Me._idalmazara & "'"
            If Me._conexion.State = ConnectionState.Closed Or Me._conexion.State = ConnectionState.Broken Then
                Me._conexion.Open()
            End If
            resultado = CType(cmd.ExecuteScalar, Long)
            Me._conexion.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
        Return resultado
    End Function






    
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Id"></param>
    ''' <remarks></remarks>
    Public Sub Delete(ByVal Id As UShort)
        Dim cmd As DbCommand
        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion


        cmd.CommandText = "delete from clientes where id ='" & Id.ToString & "'"
        If _conexion.State = ConnectionState.Closed Then
            _conexion.Open()
        End If
        cmd.ExecuteNonQuery()
        _conexion.Close()



    End Sub

    Public Overridable Overloads Function Update(ByVal tabla As oleosigDB.clientesDataTable) As Integer
        Return Me._adpt.Update(tabla)
    End Function

    Public Overridable Overloads Function Update(ByVal ds As oleosigDB) As Integer

        Return Me._adpt.Update(ds, "clientes")

    End Function
    Private Sub inicia_comandos()
        Dim strsql As New Text.StringBuilder
        Dim cmd As DbCommand
        Dim param As DbParameter

        _listacomandos = New List(Of DbCommand)

        strsql.Append("select * from clientes where idalmazara=:idalmazara")

        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        param = cdatos.CreateParameter
        param.ParameterName = ":idalmazara"
        param.SourceColumn = "idalmazara"
        param.DbType = DbType.Int32
        param.Value = Me._idalmazara

        cmd.Parameters.Add(param)

        _listacomandos.Add(cmd)

    End Sub
    Private Sub inicia_datos()
        Dim strsql As New Text.StringBuilder
        Dim cmd As DbCommand
        Dim param As DbParameter
        Dim mapa As DataTableMapping


        mapa = New DataTableMapping("Table", "clientes")
        mapa.ColumnMappings.Add("id", "Id")
        mapa.ColumnMappings.Add("idalmazara", "Idalmazara")
        mapa.ColumnMappings.Add("numcliente", "Numero")
        mapa.ColumnMappings.Add("nombre", "Nombre")
        mapa.ColumnMappings.Add("direccion", "Direccion")
        mapa.ColumnMappings.Add("telefono", "Telefono")
        mapa.ColumnMappings.Add("fax", "Fax")
        mapa.ColumnMappings.Add("localidad", "Localidad")
        mapa.ColumnMappings.Add("provincia", "Provincia")
        mapa.ColumnMappings.Add("cp", "Cp")
        mapa.ColumnMappings.Add("cif", "Cif")



        Me._adpt.TableMappings.Add(mapa)
        strsql.Length = 0

        strsql.Append("insert into clientes (")
        strsql.Append("idalmazara,")
        strsql.Append("cif,")
        strsql.Append("cp,")
        strsql.Append("direccion,")
        strsql.Append("email,")
        strsql.Append("localidad,")
        strsql.Append("nombre,")
        strsql.Append("numcliente,")
        strsql.Append("provincia,")
        strsql.Append("telefono,")
        strsql.Append("fax)")
        strsql.Append(" values(")
        strsql.Append(":idalmazara,")
        strsql.Append(":cif,")
        strsql.Append(":cp,")
        strsql.Append(":direccion,")
        strsql.Append(":email,")
        strsql.Append(":localidad,")
        strsql.Append(":nombre,")
        strsql.Append(":numcliente,")
        strsql.Append(":provincia,")
        strsql.Append(":telefono,")
        strsql.Append(":fax)")

        cmd = cdatos.CreateCommand
        cmd.Connection = cdatos.GetConnection
        cmd.CommandText = strsql.ToString

        Me._adpt.InsertCommand = cmd

        strsql.Length = 0

        strsql.Append("update clientes set ")
        strsql.Append("cif =:cif,")
        strsql.Append("cp =:cp,")
        strsql.Append("direccion =:direccion,")
        strsql.Append("email =:email,")
        strsql.Append("localidad =:localidad,")
        strsql.Append("nombre =:nombre,")
        strsql.Append("numcliente=:numcliente,")
        strsql.Append("provincia=:provincia,")
        strsql.Append("telefono=:telefono,")
        strsql.Append("fax=:fax")
        strsql.Append(" where id=:id")

        cmd = cdatos.CreateCommand
        cmd.Connection = cdatos.GetConnection
        cmd.CommandText = strsql.ToString

        Me._adpt.UpdateCommand = cmd

        strsql.Length = 0
        strsql.Append("delete from clientes where id =:id")

        cmd = cdatos.CreateCommand
        cmd.Connection = cdatos.GetConnection
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
        param.Value = Me._idalmazara


        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":cif"
        param.SourceColumn = "cif"
        param.DbType = DbType.String

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":cp"
        param.SourceColumn = "cp"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":direccion"
        param.SourceColumn = "direccion"
        param.DbType = DbType.String

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":email"
        param.SourceColumn = "email"
        param.DbType = DbType.String

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":nombre"
        param.SourceColumn = "nombre"
        param.DbType = DbType.String

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":localidad"
        param.SourceColumn = "localidad"
        param.DbType = DbType.String

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":numcliente"
        param.SourceColumn = "numcliente"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":provincia"
        param.SourceColumn = "provincia"
        param.DbType = DbType.String

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":telefono"
        param.SourceColumn = "telefono"
        param.DbType = DbType.String

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":fax"
        param.SourceColumn = "fax"
        param.DbType = DbType.String

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)


    End Sub

    

    Public Sub New(ByVal idalmazara As Integer)
        MyBase.New()

        Me.cdatos = New CBaseDatos
        Me._idalmazara = idalmazara
        Me._conexion = Me.cdatos.GetConnection
        Me._adpt = Me.cdatos.CreateDataAdapter
        Me._clearBeforeFill = True

        inicia_datos()
        inicia_comandos()

    End Sub
End Class