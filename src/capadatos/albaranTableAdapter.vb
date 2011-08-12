Option Strict Off
Option Explicit On

Imports System.Data.Common

Public Class albaranTableAdapter


    Private _campagna As Byte
    Private _idalmazara As Integer
    Private cdatos As New CBaseDatos
    Private _adpt As DbDataAdapter
    Private _conexion As DbConnection
    Private _clearBeforeFill As Boolean
    Private _listacomandos As List(Of DbCommand)


    Public ReadOnly Property Ultimo() As Integer

        Get

            Dim resultado As Object
            Dim valordevuelto As Integer
            Dim cmd As DbCommand

            cmd = Me.cdatos.CreateCommand
            cmd.CommandText = "select numero from albaranes where id=(select max(id) from albaranes where idalmazara='" & Me._idalmazara.ToString & "')"
            cmd.Connection = _conexion
            cmd.Connection.Open()

            resultado = cmd.ExecuteScalar()
            cmd.Connection.Close()


            If resultado Is Nothing Then
                valordevuelto = 0
            Else
                valordevuelto = CType(resultado, Int32)


            End If
            Return valordevuelto
        End Get
    End Property
   
   
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="vNumero"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByNumero(ByVal vNumero As Short) As oleosigDB.albaranesDataTable
        Dim cmd As DbCommand
        Dim tabla As New oleosigDB.albaranesDataTable

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion

        cmd.CommandText = "select * from albaranes where numero ='" & vNumero.ToString & "' and campagna='" & Me._campagna.ToString() & "' and idalmazara='" & Me._idalmazara.ToString & "'"
        Me._adpt.SelectCommand = cmd


        Me._adpt.Fill(tabla)

        Return tabla

    End Function
   
  
    Public Function Fill(ByVal tabla As oleosigDB.albaranesDataTable) As Integer





        Try
            If _clearBeforeFill Then
                tabla.Clear()
            End If
            Me._adpt.SelectCommand = _listacomandos(0)
            Me._adpt.SelectCommand.Parameters(":idalmzara").Value = CType(Me._idalmazara, Integer)
            Me._adpt.SelectCommand.Parameters(":campagna").Value = CType(Me._campagna, Integer)


            Return Me._adpt.Fill(tabla)


        Catch e As Exception
            MsgBox(e.Message)

        End Try


    End Function

  
  
    Public Function GetData() As oleosigDB.albaranesDataTable
        
        Dim albaranes As New oleosigDB.albaranesDataTable



        Try
            Me._adpt.SelectCommand = _listacomandos(0)
            Me._adpt.SelectCommand.Parameters(":idalmzara").Value = CType(Me._idalmazara, Integer)
            Me._adpt.SelectCommand.Parameters(":campagna").Value = CType(Me._campagna, Integer)

            
            Me._adpt.Fill(albaranes)


        Catch e As Exception
            MsgBox(e.Message)

        End Try

        Return albaranes
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="id"></param>
    ''' <remarks></remarks>
    Public Overridable Overloads Function Delete(ByVal id As Integer) As Integer
        Me._adpt.DeleteCommand.Parameters(":id").Value = CType(id, Integer)
        Dim estadoanterior As ConnectionState = Me._adpt.DeleteCommand.Connection.State

        If (estadoanterior And ConnectionState.Open) <> ConnectionState.Open Then
            Me._adpt.DeleteCommand.Connection.Open()
        End If
        Return Me._adpt.DeleteCommand.ExecuteNonQuery()
        If estadoanterior = ConnectionState.Closed Then
            Me._adpt.DeleteCommand.Connection.Close()
        End If
    End Function

   
    Public Overridable Overloads Function Update(ByVal vAlbaran As oleosigDB.albaranesDataTable) As Integer

        Return Me._adpt.Update(vAlbaran)


    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="operacion"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function getId(ByVal operacion As UShort) As Integer
        Dim cmd As DbCommand
        Dim valordevuelto As Integer = 0

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = "select id from albaranes where numero='" & operacion.ToString & "' and campagna='" & Me._campagna.ToString() & "'"

        cmd.Connection.Open()

        Dim rsult As Object = cmd.ExecuteScalar()

        cmd.Connection.Close()

        If rsult IsNot Nothing Then
            If Not IsDBNull(rsult) Then
                valordevuelto = CType(rsult, Integer)
            End If
        End If

        Return valordevuelto

    End Function

    Public Sub Insertar(ByVal idalmazara As Integer, ByVal numero As Integer, _
        ByVal fecha As Date, _
        ByVal cliente As Int32, _
        ByVal vehiculo As Integer, _
        ByVal conductor As Integer, _
        ByVal tipo As Integer, _
        ByVal tara As Integer, _
        ByVal bruto As Integer, _
        ByVal neto As Integer, _
        ByVal campagna As Integer)

        Me._adpt.InsertCommand.Parameters(":idalmazara").Value = CType(idalmazara, Integer)
        Me._adpt.InsertCommand.Parameters(":numero").Value = CType(numero, Integer)
        Me._adpt.InsertCommand.Parameters(":fecha").Value = CType(fecha, Date)
        Me._adpt.InsertCommand.Parameters(":cliente").Value = CType(cliente, Integer)
        Me._adpt.InsertCommand.Parameters(":vehiculo").Value = CType(vehiculo, Integer)
        Me._adpt.InsertCommand.Parameters(":conductor").Value = CType(conductor, Integer)
        Me._adpt.InsertCommand.Parameters(":tipo").Value = CType(tipo, Integer)
        Me._adpt.InsertCommand.Parameters(":tara").Value = CType(tara, Integer)
        Me._adpt.InsertCommand.Parameters(":bruto").Value = CType(bruto, Integer)
        Me._adpt.InsertCommand.Parameters(":neto").Value = CType(neto, Integer)
        Me._adpt.InsertCommand.Parameters(":campagna").Value = CType(campagna, Integer)

        Dim estadoanterior As ConnectionState = Me._adpt.InsertCommand.Connection.State

        If (estadoanterior And ConnectionState.Open) <> ConnectionState.Open Then
            Me._adpt.InsertCommand.Connection.Open()
        End If

        Me._adpt.InsertCommand.ExecuteNonQuery()

        If estadoanterior = ConnectionState.Closed Then
            Me._adpt.InsertCommand.Connection.Close()
        End If


    End Sub
    Private Sub inicia_comandos()
        Dim cmd As DbCommand
        Dim param As DbParameter

        _listacomandos = New List(Of DbCommand)

        cmd = cdatos.CreateCommand
        cmd.Connection = _conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from albaranes where idalmazara=:idalmzara and campagna=:campagna order by id"

        param = cdatos.CreateParameter
        param.ParameterName = ":idalmzara"
        param.SourceColumn = "idalmzara"
        param.DbType = DbType.Int32

        cmd.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":campagna"
        param.SourceColumn = "campagna"
        param.DbType = DbType.Int32

        cmd.Parameters.Add(param)

        _listacomandos.Add(cmd)

    End Sub
    Private Sub inicia_datos()
        Dim strsql As New System.Text.StringBuilder
        Dim cmd As DbCommand
        Dim param As DbParameter
        Dim mapa As DataTableMapping


        mapa = New DataTableMapping("Table", "albaranes")
        mapa.ColumnMappings.Add("id", "Id")
        mapa.ColumnMappings.Add("idalmazara", "Idalmazara")
        mapa.ColumnMappings.Add("numero", "Numero")
        mapa.ColumnMappings.Add("fecha", "Fecha")
        mapa.ColumnMappings.Add("cliente", "Cliente")
        mapa.ColumnMappings.Add("vehiculo", "Vehiculo")
        mapa.ColumnMappings.Add("conductor", "Conductor")
        mapa.ColumnMappings.Add("tipo", "Tipo")
        mapa.ColumnMappings.Add("bruto", "Bruto")
        mapa.ColumnMappings.Add("neto", "Neto")
        mapa.ColumnMappings.Add("tara", "Tara")
        mapa.ColumnMappings.Add("campagna", "Campagna")

        _adpt.TableMappings.Add(mapa)


        strsql.Append("insert into albaranes (")
        strsql.Append("idalmazara,")
        strsql.Append("numero,")
        strsql.Append("fecha,")
        strsql.Append("cliente,")
        strsql.Append("vehiculo,")
        strsql.Append("conductor,")
        strsql.Append("tipo,")
        strsql.Append("tara,")
        strsql.Append("bruto,")
        strsql.Append("neto,")
        strsql.Append("campagna) values(")
        strsql.Append(":idalmazara,")
        strsql.Append(":numero,")
        strsql.Append(":fecha,")
        strsql.Append(":cliente,")
        strsql.Append(":vehiculo,")
        strsql.Append(":conductor,")
        strsql.Append(":tipo,")
        strsql.Append(":tara,")
        strsql.Append(":bruto,")
        strsql.Append(":neto,")
        strsql.Append(":campagna)")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.InsertCommand = cmd

        strsql.Length = 0

        strsql.Append("update albaranes set ")
        strsql.Append("idalmazara=:idalmazara,")
        strsql.Append("numero=:numero,")
        strsql.Append("fecha=:fecha,")
        strsql.Append("cliente=:cliente,")
        strsql.Append("vehiculo=:vehiculo,")
        strsql.Append("conductor=:conductor,")
        strsql.Append("tipo=:tipo,")
        strsql.Append("tara=:tara,")
        strsql.Append("bruto=:bruto,")
        strsql.Append("neto=:neto,")
        strsql.Append("campagna=:campagna ")
        strsql.Append("where id=:id")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.UpdateCommand = cmd

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = "delete from albaranes where id=:id"

        Me._adpt.DeleteCommand = cmd

        param = cdatos.CreateParameter
        param.SourceColumn = "id"
        param.ParameterName = ":id"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.DeleteCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.SourceColumn = "idalmazara"
        param.ParameterName = ":idalmazara"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.SourceColumn = "numero"
        param.ParameterName = ":numero"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.SourceColumn = "fecha"
        param.ParameterName = ":fecha"
        param.DbType = DbType.DateTime

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.SourceColumn = "cliente"
        param.ParameterName = ":cliente"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.SourceColumn = "vehiculo"
        param.ParameterName = ":vehiculo"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.SourceColumn = "conductor"
        param.ParameterName = ":conductor"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.SourceColumn = "tipo"
        param.ParameterName = ":tipo"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.SourceColumn = "tara"
        param.ParameterName = ":tara"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.SourceColumn = "bruto"
        param.ParameterName = ":bruto"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.SourceColumn = "neto"
        param.ParameterName = ":neto"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.SourceColumn = "campagna"
        param.ParameterName = ":campagna"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

    End Sub
    Public Sub New(ByVal campagna As Byte, ByVal idalmazara As Integer)
        MyBase.New()

        Me.cdatos = New CBaseDatos
        Me._idalmazara = idalmazara
        Me._campagna = campagna
        Me._conexion = cdatos.GetConnection
        Me._adpt = cdatos.CreateDataAdapter()
        _clearBeforeFill = True
        inicia_datos()
        inicia_comandos()

    End Sub


    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub
End Class