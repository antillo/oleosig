Option Strict Off
Option Explicit On

Imports System.Data.Common
Imports System.Text

Public Class opfabricaTableAdapter


    Private _campagna As Byte
    Private _idalmazara As Integer
    Private _adpt As DbDataAdapter
    ' Private _dt As DataSet
    Private cdatos As New CBaseDatos
    Private _conexion As DbConnection
    Private _clearBeforeFill As Boolean
    Private _comandos As List(Of DbCommand)
    Private _transaction As DbTransaction

    Public Property Transaction As DbTransaction
        Get
            Return Me._transaction
        End Get
        Set(ByVal value As DbTransaction)
            Me._transaction = value
            Dim i As Integer = 0
            Do While (i < Me._comandos.Count - 1)
                Me._comandos(i).Transaction = Me._transaction
                i += 1
            Loop
            If (Not (Me._adpt) Is Nothing) AndAlso (Not (Me._adpt.DeleteCommand) Is Nothing) Then
                Me._adpt.DeleteCommand.Transaction = Me._transaction
            End If
            If (Not (Me._adpt) Is Nothing) AndAlso (Not (Me._adpt.InsertCommand) Is Nothing) Then
                Me._adpt.InsertCommand.Transaction = Me._transaction
            End If
            If (Not (Me._adpt) Is Nothing) AndAlso (Not (Me._adpt.UpdateCommand) Is Nothing) Then
                Me._adpt.UpdateCommand.Transaction = Me._transaction
            End If
        End Set
    End Property

    Public Property Connection As DbConnection
        Get
            Return Me._conexion
        End Get
        Set(ByVal value As DbConnection)
            Me._conexion = value
            If (Not (Me.Adapter.InsertCommand) Is Nothing) Then
                Me.Adapter.InsertCommand.Connection = value
            End If
            If (Not (Me.Adapter.DeleteCommand) Is Nothing) Then
                Me.Adapter.DeleteCommand.Connection = value
            End If
            If (Not (Me.Adapter.UpdateCommand) Is Nothing) Then
                Me.Adapter.UpdateCommand.Connection = value
            End If
            Dim i As Integer = 0
            Do While (i < Me._comandos.Count)
                If (Not (Me._comandos(i)) Is Nothing) Then
                    CType(Me._comandos(i), Global.System.Data.Common.DbCommand).Connection = value
                End If
                i = (i + 1)
            Loop
        End Set
    End Property

    Public ReadOnly Property Adapter As DbDataAdapter
        Get
            Return Me._adpt
        End Get
    End Property

    Public Property ClearBeforeFill As Boolean
        Get
            Return _clearBeforeFill
        End Get
        Set(ByVal value As Boolean)
            Me._clearBeforeFill = value
        End Set
    End Property



    Public Sub borrarTodas()
        Dim strsql As String


        strsql = "delete from opfabrica where campagna ='" & Me._campagna.ToString() & "' and idalmazara='" & Me._idalmazara.ToString & "'"
        Me.cdatos.Haz(strsql)


    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetLast() As Integer
        Dim strSql As New StringBuilder
        Dim resultado As Object
        Dim valordevuelto As Integer

        strSql.Append("select max(operacion) from opfabrica")
        strSql.Append(" where campagna ='" & Me._campagna.ToString() & "' and idalmazara='" & Me._idalmazara.ToString & "'")


        Try
            Dim cmd As DbCommand
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strSql.ToString
            If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
                Me._conexion.Open()
            End If
            resultado = cmd.ExecuteScalar()

            If resultado IsNot Nothing Then
                If IsDBNull(resultado) Then
                    valordevuelto = 0
                Else
                    valordevuelto = CType(resultado, Integer)
                End If

            Else
                valordevuelto = 0
            End If
            Me._conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try
        Return valordevuelto
    End Function


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="operacion"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByOperacion(ByVal operacion As Int32) As oleosigDB.opfabricaDataTable
        Dim tabla As oleosigDB.opfabricaDataTable = New oleosigDB.opfabricaDataTable


        Try
            Me._adpt.SelectCommand = Me._comandos(4)
            Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(Me._idalmazara, Int32)
            Me._adpt.SelectCommand.Parameters(":campagna").Value = CType(Me._campagna, Int16)
            Me._adpt.SelectCommand.Parameters(":operacion").Value = CType(operacion, Int32)

            Me._adpt.Fill(tabla)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return tabla
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataById(ByVal id As Integer) As oleosigDB.opfabricaDataTable
        Dim tabla As oleosigDB.opfabricaDataTable = New oleosigDB.opfabricaDataTable()


        Try
            Me._adpt.SelectCommand = Me._comandos(5)
            Me._adpt.SelectCommand.Parameters(":id").Value = CType(id, Int32)
            Me._adpt.SelectCommand.Parameters(":campagna").Value = CType(Me._campagna, Int16)
            Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(Me._idalmazara, Int32)

            Me._adpt.Fill(tabla)


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
        Return tabla
    End Function


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getAllNumOp() As ArrayList
        Dim strSql As String
        Dim lector As DbDataReader
        Dim Numop As New ArrayList



        strSql = "select operacion from opfabrica where campagna ='" & Me._campagna.ToString() & "'" & _
            " and idalmazara='" & Me._idalmazara.ToString & "' order by operacion"
        Try

            Dim cmd As DbCommand
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strSql.ToString
            If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
                Me._conexion.Open()
            End If
            lector = cmd.ExecuteReader(CommandBehavior.CloseConnection)



            Do While lector.Read()

                If IsDBNull(lector(0)) Then

                Else
                    Numop.Add(lector(0))
                End If

            Loop

            If Not lector.IsClosed Then lector.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return Numop




    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="id"></param>
    ''' <remarks></remarks>
    Public Sub Delete(ByVal id As UInteger)


        Try
            Me._adpt.DeleteCommand.Parameters(":id").Value = CType(id, Int32)
            If (Me._adpt.DeleteCommand.Connection.State And ConnectionState.Open) <> ConnectionState.Open Then
                Me._adpt.DeleteCommand.Connection.Open()
            End If
            Me._adpt.DeleteCommand.ExecuteNonQuery()
            Me._adpt.DeleteCommand.Connection.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="operacion"></param>
    ''' <remarks></remarks>
    Public Function Insert(ByVal fechaini As DateTime, ByVal fechafin As DateTime, ByVal linea As Int32, ByVal operacion As Int32, ByVal abierta As Boolean, ByVal importada As Boolean) As Integer


        Me._adpt.InsertCommand.Parameters(":idalmazara").Value = CType(Me._idalmazara, Int32)
        Me._adpt.InsertCommand.Parameters(":fechaini").Value = CType(fechaini, DateTime)
        Me._adpt.InsertCommand.Parameters(":fechafin").Value = CType(fechafin, DateTime)
        Me._adpt.InsertCommand.Parameters(":lineafabrica").Value = CType(linea, Int32)
        Me._adpt.InsertCommand.Parameters(":operacion").Value = CType(operacion, Int32)
        Me._adpt.InsertCommand.Parameters(":campagna").Value = CType(Me._campagna, Int16)
        Me._adpt.InsertCommand.Parameters(":abierta").Value = CType(abierta, Boolean)
        Me._adpt.InsertCommand.Parameters(":importada").Value = CType(importada, Boolean)

        Dim con_previa As System.Data.ConnectionState = Me._adpt.InsertCommand.Connection.State
        If (Me._adpt.InsertCommand.Connection.State And System.Data.ConnectionState.Open) <> ConnectionState.Open Then
            Me._adpt.InsertCommand.Connection.Open()
        End If
        Try
            Dim result As Integer = Me._adpt.InsertCommand.ExecuteNonQuery()
            If result > 0 Then
                Dim tabla As oleosigDB.opfabricaDataTable = Me.GetDataByOperacion(operacion)
                If tabla.Rows.Count > 0 Then
                    result = tabla.Rows(0)(0)
                End If
            End If

            Return result
        Catch ex As Exception

            Throw

        Finally


            If con_previa = ConnectionState.Closed Then
                Me._adpt.InsertCommand.Connection.Close()
            End If
        End Try

    End Function
    Public Overridable Overloads Function Update(ByVal datarow As DataRow) As Integer
        Return Me._adpt.Update(New DataRow() {datarow})
    End Function
    Public Overridable Overloads Function Update(ByVal oleosig As oleosigDB) As Integer
        Return Me._adpt.Update(oleosig, "opfabrica")
    End Function
    Public Overridable Overloads Function Update(ByVal tabla As oleosigDB.opfabricaDataTable) As Integer
        Return Me._adpt.Update(tabla)
    End Function
    Public Overridable Overloads Function Update(ByVal dataRows() As Global.System.Data.DataRow) As Integer
        Return Me.Adapter.Update(dataRows)
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="operacion"></param>
    ''' <remarks></remarks>
    Public Overridable Overloads Function Update(ByVal id As Int32, ByVal fechaini As DateTime, ByVal fechafin As DateTime, ByVal linea As Int32, ByVal abierta As Boolean, ByVal operacion As Int32) As Integer
        Dim strSql As New StringBuilder


        Me._adpt.UpdateCommand.Parameters(":id").Value = CType(id, Int32)
        Me._adpt.UpdateCommand.Parameters(":fechaini").Value = CType(fechaini, DateTime)
        Me._adpt.UpdateCommand.Parameters(":fechafin").Value = CType(fechafin, DateTime)
        Me._adpt.UpdateCommand.Parameters(":abierta").Value = CType(abierta, Boolean)
        Me._adpt.UpdateCommand.Parameters(":operacion").Value = CType(operacion, Int32)

        Dim estadoConPrevio As ConnectionState = Me._adpt.UpdateCommand.Connection.State

        If estadoConPrevio And ConnectionState.Open <> ConnectionState.Open Then
            Me._adpt.UpdateCommand.Connection.Open()
        End If


        Try
            Dim resultado As Integer = Me._adpt.UpdateCommand.ExecuteNonQuery
            Return resultado
        Finally
            If estadoConPrevio = ConnectionState.Closed Then
                Me._adpt.UpdateCommand.Connection.Close()
            End If
        End Try

    End Function
    Public Overridable Overloads Function FillDataByOperacion(ByVal tabla As oleosigDB.opfabricaDataTable, ByVal operacion As Integer) As Integer
        Me._adpt.SelectCommand = Me._comandos(4)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(Me._idalmazara, Int32)
        Me._adpt.SelectCommand.Parameters(":campagna").Value = CType(Me._campagna, Int16)
        Me._adpt.SelectCommand.Parameters(":operacion").Value = CType(operacion, Int32)
        If Me._clearBeforeFill Then
            tabla.Clear()
        End If
        Dim result As Integer = Me._adpt.Fill(tabla)
        Return result
    End Function
    Public Overridable Overloads Function FillDataByOperacion(ByVal tabla As oleosigDB.opfabricaDataTable, ByVal opd As List(Of Integer)) As Integer
        Dim strsql As New StringBuilder
        Dim valordevuelto As Integer
        Dim cmd As DbCommand

        If opd.Count > 0 Then
            strsql.Append("select * from opfabrica where (")
            For Each op As Integer In opd
                strsql.Append("operacion='" & op.ToString & "' or ")
            Next
            strsql.Length = strsql.Length - 4
            strsql.Append(") and campagna='" & Me._campagna.ToString & "' and idalmazara='" & Me._idalmazara.ToString & "' order by id")

            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strsql.ToString

            Me._adpt.SelectCommand = cmd

            If Me._clearBeforeFill Then
                tabla.Clear()
            End If

            valordevuelto = Me._adpt.Fill(tabla)
        Else
            valordevuelto = 0
        End If
        Return valordevuelto
    End Function
    Public Overridable Overloads Function FillDataById(ByVal tabla As oleosigDB.opfabricaDataTable, ByVal ids As List(Of Integer), ByVal tipo As Integer) As Integer
        Dim strsql As New StringBuilder
        Dim valordevuelto As Integer
        Dim cmd As DbCommand

        If Me._clearBeforeFill Then
            tabla.Clear()
        End If

        If ids.Count > 0 Then
            strsql.Append("select * from opfabrica where (")
            For Each id As Integer In ids
                strsql.Append("id='" & id.ToString & "' or ")
            Next
            strsql.Length = strsql.Length - 4
            strsql.Append(")")

            Select Case tipo
                Case 1
                    strsql.Append(" and importada='f'")
                Case 2
                    strsql.Append(" and importada='t'")
            End Select


            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strsql.ToString

            Me._adpt.SelectCommand = cmd



            valordevuelto = Me._adpt.Fill(tabla)


        Else
            valordevuelto = 0
        End If
        Return valordevuelto
    End Function


    Public Overridable Overloads Function Fill(ByVal tabla As oleosigDB.opfabricaDataTable) As Integer
        Me._adpt.SelectCommand = Me._comandos(0)
        If Me.ClearBeforeFill Then
            tabla.Clear()
        End If
        Dim result As Integer = Me._adpt.Fill(tabla)
        Return result
    End Function



    ''' <summary>
    ''' Devuelve todas las operaciones de fábrica
    ''' </summary>
    ''' <param name="orden">Onden en el que se obtienen los datos orden:=0 por número de operacion
    ''' orden:=1 por fecha</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetData(ByVal orden As UShort) As oleosigDB.opfabricaDataTable
        Dim strSql As String
        Dim tabla As oleosigDB.opfabricaDataTable = New oleosigDB.opfabricaDataTable()


        strSql = "SELECT * FROM opfabrica where campagna ='" & Me._campagna.ToString() & "' and idalmazara='" & Me._idalmazara.ToString & "'"

        Select Case orden
            Case 0
                strSql = strSql & " order by operacion"
            Case 1
                strSql = strSql & " order by fechaini"
        End Select
        Try

            Me._adpt.SelectCommand.CommandText = strSql

            Me._adpt.Fill(tabla)

            Return tabla


        Catch e As Exception

            Throw New ApplicationException("Exception Occured")

        End Try

    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="fechaini"></param>
    ''' <param name="fechafin"></param>
    ''' <param name="sLinea"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByFechas(ByVal fechaini As DateTime, ByVal fechafin As DateTime, ByVal sLinea As UInteger) As oleosigDB.opfabricaDataTable
        Dim tabla As oleosigDB.opfabricaDataTable = New oleosigDB.opfabricaDataTable

        Me._adpt.SelectCommand = Me._comandos(2)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(Me._idalmazara, Int32)
        Me._adpt.SelectCommand.Parameters(":campagna").Value = CType(Me._campagna, Int16)
        Me._adpt.SelectCommand.Parameters(":fechaini").Value = CType(fechaini, DateTime)
        Me._adpt.SelectCommand.Parameters(":fechafin").Value = CType(fechafin, DateTime)
        Me._adpt.SelectCommand.Parameters(":lineafabrica").Value = CType(sLinea, Int32)

        Me._adpt.Fill(tabla)
        Return tabla

    End Function
    Public Function FillDataByFechas(ByVal fechaini As DateTime, ByVal fechafin As DateTime, ByVal linea As Integer, ByVal tabla As oleosigDB.opfabricaDataTable) As Integer
        If Me.ClearBeforeFill Then
            tabla.Clear()
        End If
        Me._adpt.SelectCommand = Me._comandos(2)

        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(Me._idalmazara, Int32)
        Me._adpt.SelectCommand.Parameters(":campagna").Value = CType(Me._campagna, Int16)
        Me._adpt.SelectCommand.Parameters(":fechaini").Value = CType(fechaini, DateTime)
        Me._adpt.SelectCommand.Parameters(":fechafin").Value = CType(fechafin, DateTime)
        Me._adpt.SelectCommand.Parameters(":lineafabrica").Value = CType(linea, Int32)

        Dim result As Integer = Me._adpt.Fill(tabla)

        Return result
    End Function
    Public Function FillDataByFechas(ByVal fechaini As DateTime, ByVal fechafin As DateTime, ByVal tabla As oleosigDB.opfabricaDataTable) As Integer

        Me._adpt.SelectCommand = Me._comandos(1)

        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(Me._idalmazara, Int32)
        Me._adpt.SelectCommand.Parameters(":campagna").Value = CType(Me._campagna, Int16)
        Me._adpt.SelectCommand.Parameters(":fechaini").Value = CType(fechaini, DateTime)
        Me._adpt.SelectCommand.Parameters(":fechafin").Value = CType(fechafin, DateTime)

        tabla.Clear()
        Dim result As Integer = Me._adpt.Fill(tabla)

        Return result

    End Function

    Public Function GetDataByFechas(ByVal fechaini As DateTime, ByVal fechafin As DateTime) As oleosigDB.opfabricaDataTable
        Dim tabla As oleosigDB.opfabricaDataTable = New oleosigDB.opfabricaDataTable

        Me._adpt.SelectCommand = Me._comandos(1)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(Me._idalmazara, Int32)
        Me._adpt.SelectCommand.Parameters(":campagna").Value = CType(Me._campagna, Int16)
        Me._adpt.SelectCommand.Parameters(":fechaini").Value = CType(fechaini, DateTime)
        Me._adpt.SelectCommand.Parameters(":fechafin").Value = CType(fechafin, DateTime)

        Me._adpt.Fill(tabla)

        Return tabla

    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Partida"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByPartida(ByVal Partida As oleosigDB.partidasaceitunaRow) As oleosigDB.opfabricaDataTable
        Dim tabla As oleosigDB.opfabricaDataTable = New oleosigDB.opfabricaDataTable()
        Dim strSql As String
        Dim rslt As Object
        Dim partidas As New ArrayList

        strSql = "select opfabrica from detalles_opfabrica where" & _
            " partida ='" & Partida.Numero.ToString & "'" & _
            " and campagna ='" & Partida.Campaña.ToString & "'" & _
            " and idalmazara='" & Me._idalmazara.ToString & "'"

        Dim cmd As DbCommand
        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strSql.ToString

        If cmd.Connection.State = ConnectionState.Broken Or cmd.Connection.State = ConnectionState.Closed Then
            cmd.Connection.Open()
        End If

        rslt = cmd.ExecuteScalar

        If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()

        If rslt IsNot Nothing Then

            If Not IsDBNull(rslt) Then
                tabla = Me.GetDataById(CType(rslt, Integer))
            End If

        End If

        Return tabla

    End Function

    Public Function FillDataByDecanter(ByVal decanter As Int32, ByVal tabla As oleosigDB.opfabricaDataTable) As Integer
        If Me._clearBeforeFill Then
            tabla.Clear()
        End If
        Me._adpt.SelectCommand = Me._comandos(3)
        Me._adpt.SelectCommand.Parameters(":campagna").Value = CType(Me._campagna, Int16)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(Me._idalmazara, Int32)
        Me._adpt.SelectCommand.Parameters(":lineafabrica").Value = CType(decanter, Int32)

        Dim result As Integer = Me._adpt.Fill(tabla)
        Return result

    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="decanter"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByDecanter(ByVal decanter As Int32) As oleosigDB.opfabricaDataTable
        Dim tabla As oleosigDB.opfabricaDataTable = New oleosigDB.opfabricaDataTable

        Try

            Me._adpt.SelectCommand = Me._comandos(3)
            Me._adpt.SelectCommand.Parameters(":campagna").Value = CType(Me._campagna, Int16)
            Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(Me._idalmazara, Int32)
            Me._adpt.SelectCommand.Parameters(":lineafabrica").Value = CType(decanter, Int32)

            Me._adpt.Fill(tabla)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return tabla
    End Function
    Private Sub iniAdapt()
        Dim cmd As DbCommand
        Dim strsql As New StringBuilder
        Dim param As DbParameter


        Dim tablemapping As DataTableMapping

        tablemapping = New DataTableMapping
        tablemapping.SourceTable = "Table"
        tablemapping.DataSetTable = "opfabrica"
        tablemapping.ColumnMappings.Add("id", "id")
        tablemapping.ColumnMappings.Add("idalmazara", "idalmazara")
        tablemapping.ColumnMappings.Add("fechaini", "fechaini")
        tablemapping.ColumnMappings.Add("fechafin", "fechafin")
        tablemapping.ColumnMappings.Add("lineafabrica", "lineafabrica")
        tablemapping.ColumnMappings.Add("operacion", "operacion")
        tablemapping.ColumnMappings.Add("campagna", "campagna")
        tablemapping.ColumnMappings.Add("abierta", "abierta")
        tablemapping.ColumnMappings.Add("importada", "importada")

        Me._adpt.TableMappings.Add(tablemapping)

        strsql.Append("insert into opfabrica (")
        strsql.Append("idalmazara,")
        strsql.Append("fechaini,")
        strsql.Append("fechafin,")
        strsql.Append("lineafabrica,")
        strsql.Append("operacion,")
        strsql.Append("campagna,")
        strsql.Append("abierta,")
        strsql.Append("importada)")
        strsql.Append(" values(")
        strsql.Append(":idalmazara,")
        strsql.Append(":fechaini,")
        strsql.Append(":fechafin,")
        strsql.Append(":lineafabrica,")
        strsql.Append(":operacion,")
        strsql.Append(":campagna,")
        strsql.Append(":abierta,:importada)")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.InsertCommand = cmd

        strsql.Length = 0

        strsql.Append("update opfabrica set ")
        strsql.Append("fechaini=:fechaini,")
        strsql.Append("fechafin=:fechafin,")
        strsql.Append("lineafabrica=:lineafabrica,")
        strsql.Append("operacion=:operacion,")
        strsql.Append("abierta=:abierta, ")
        strsql.Append("importada=:importada ")
        strsql.Append("where id=:id")


        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.UpdateCommand = cmd

        strsql.Length = 0
        strsql.Append("delete from opfabrica where id=:id")

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
        param.Value = CType(Me._idalmazara, Int32)

        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":fechaini"
        param.SourceColumn = "fechaini"
        param.DbType = DbType.DateTime

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":fechafin"
        param.SourceColumn = "fechafin"
        param.DbType = DbType.DateTime

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":lineafabrica"
        param.SourceColumn = "lineafabrica"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":operacion"
        param.SourceColumn = "operacion"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":campagna"
        param.SourceColumn = "campagna"
        param.DbType = DbType.Int16
        param.Value = CType(Me._campagna, Int16)

        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":abierta"
        param.SourceColumn = "abierta"
        param.DbType = DbType.Boolean

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":importada"
        param.SourceColumn = "importada"
        param.DbType = DbType.Boolean

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

    End Sub
    Private Sub iniCommands()
        Dim strsql As New StringBuilder
        Dim cmd As DbCommand
        Dim param As DbParameter


        'comando 0 GetData

        Me._comandos = New List(Of DbCommand)
        strsql.Append("select * from opfabrica where idalmazara=:idalmazara")
        strsql.Append(" and campagna=:campagna order by id")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString
        cmd.CommandType = CommandType.Text

        param = cdatos.CreateParameter
        param.ParameterName = ":idalmazara"
        param.SourceColumn = "idalmazara"
        param.DbType = DbType.Int32
        param.Value = CType(Me._idalmazara, Int32)

        cmd.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":campagna"
        param.SourceColumn = "campagna"
        param.DbType = DbType.Int16
        param.Value = CType(Me._campagna, Int16)

        cmd.Parameters.Add(param)

        Me._comandos.Add(cmd)

        'comando 1 GetDatabyFecha

        strsql.Length = 0

        strsql.Append("SELECT  * FROM opfabrica")
        strsql.Append(" where campagna =:campagna")
        strsql.Append(" and fechaini >=:fechaini")
        strsql.Append(" and fechafin <=:fechafin")
        strsql.Append(" and idalmazara=:idalmazara")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString
        cmd.CommandType = CommandType.Text

        param = cdatos.CreateParameter
        param.ParameterName = ":idalmazara"
        param.SourceColumn = "idalmazara"
        param.DbType = DbType.Int32
        param.Value = CType(Me._idalmazara, Int32)

        cmd.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":campagna"
        param.SourceColumn = "campagna"
        param.DbType = DbType.Int16
        param.Value = CType(Me._campagna, Int16)

        cmd.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":fechaini"
        param.DbType = DbType.DateTime

        cmd.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":fechafin"
        param.DbType = DbType.DateTime

        cmd.Parameters.Add(param)

        Me._comandos.Add(cmd)

        'comando 2 GetDatabyfecha con linea

        strsql.Length = 0

        strsql.Append("SELECT  * FROM opfabrica")
        strsql.Append(" where campagna =:campagna")

        strsql.Append(" and fechaini >=:fechaini")
        strsql.Append(" and fechafin <=:fechafin")
        strsql.Append(" and lineafabrica =:lineafabrica")
        strsql.Append(" and idalmazara=:idalmazara")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString
        cmd.CommandType = CommandType.Text

        param = cdatos.CreateParameter
        param.ParameterName = ":idalmazara"
        param.SourceColumn = "idalmazara"
        param.DbType = DbType.Int32
        param.Value = CType(Me._idalmazara, Int32)

        cmd.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":campagna"
        param.SourceColumn = "campagna"
        param.DbType = DbType.Int16
        param.Value = CType(Me._campagna, Int16)

        cmd.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":fechaini"
        param.DbType = DbType.DateTime

        cmd.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":fechafin"
        param.DbType = DbType.DateTime

        cmd.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":lineafabrica"
        param.DbType = DbType.Int32

        cmd.Parameters.Add(param)

        Me._comandos.Add(cmd)

        strsql.Length = 0

        'comando 3 GetDatabyDecanter

        strsql.Append("select * from opfabrica where")
        strsql.Append(" lineafabrica=:lineafabrica")
        strsql.Append(" and campagna=:campagna")
        strsql.Append(" and idalmazara=:idalmazara")
        strsql.Append(" order by id")

        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString
        cmd.CommandType = CommandType.Text

        param = cdatos.CreateParameter
        param.ParameterName = ":lineafabrica"
        param.DbType = DbType.Int32

        cmd.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":campagna"
        param.SourceColumn = "campagna"
        param.DbType = DbType.Int16
        param.Value = CType(Me._campagna, Int16)

        cmd.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":idalmazara"
        param.SourceColumn = "idalmazara"
        param.DbType = DbType.Int32
        param.Value = CType(Me._idalmazara, Int32)

        cmd.Parameters.Add(param)

        Me._comandos.Add(cmd)

        'comando 4 GetDatabyOperacion

        strsql.Length = 0

        strsql.Append("select * from opfabrica where operacion =:operacion")
        strsql.Append(" and campagna =:campagna")
        strsql.Append(" and idalmazara=:idalmazara")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString
        cmd.CommandType = CommandType.Text

        param = cdatos.CreateParameter
        param.ParameterName = ":campagna"
        param.SourceColumn = "campagna"
        param.DbType = DbType.Int16
        param.Value = CType(Me._campagna, Int16)

        cmd.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":idalmazara"
        param.SourceColumn = "idalmazara"
        param.DbType = DbType.Int32
        param.Value = CType(Me._idalmazara, Int32)

        cmd.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":operacion"
        param.SourceColumn = "operacion"
        param.DbType = DbType.Int32

        cmd.Parameters.Add(param)

        Me._comandos.Add(cmd)

        ' comando 5 GetDatabyId
        strsql.Length = 0
        strsql.Append("select * from opfabrica where id =:id and campagna =:campagna and idalmazara=:idalmazara")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString
        cmd.CommandType = CommandType.Text

        param = cdatos.CreateParameter
        param.ParameterName = ":id"
        param.SourceColumn = "id"
        param.DbType = DbType.Int32

        cmd.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":idalmazara"
        param.SourceColumn = "idalmazara"
        param.DbType = DbType.Int32
        param.Value = CType(Me._idalmazara, Int32)

        cmd.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":campagna"
        param.SourceColumn = "campagna"
        param.DbType = DbType.Int16
        param.Value = CType(Me._campagna, Int16)

        cmd.Parameters.Add(param)

        Me._comandos.Add(cmd)



    End Sub


    Public Sub New(ByVal campagna As Byte, ByVal idalmazara As Integer)
        MyBase.New()
        Me._clearBeforeFill = True
        Me._idalmazara = idalmazara
        Me._campagna = campagna
        Me._conexion = cdatos.GetConnection
        Me._adpt = cdatos.CreateDataAdapter


        iniCommands()
        iniAdapt()

    End Sub


    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub
End Class