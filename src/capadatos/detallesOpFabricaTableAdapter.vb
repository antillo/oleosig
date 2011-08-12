Imports System.Data.Common
Public Class detallesOpFabricaTableAdapter
    Private _adpt As DbDataAdapter
    Private cdatos As CBaseDatos
    Private _conexion As DbConnection
    Private _campagna As Int16
    Private _idalmazara As Int32
    Private _comandos As List(Of DbCommand)
    Private _transaction As DbTransaction

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
    Public Overridable Overloads Function Update(ByVal tabla As oleosigDB.detalles_opfabricaDataTable) As Integer
        Return Me._adpt.Update(tabla)
    End Function
    Public Overridable Overloads Function Update(ByVal oleosig As oleosigDB) As Integer
        Return Me._adpt.Update(oleosig, "detalles_opfabrica")
    End Function
    Public Overridable Overloads Function Update(ByVal datarow As DataRow) As Integer
        Return Me._adpt.Update(New DataRow() {datarow})
    End Function

    Public Overridable Overloads Function Update(ByVal datarows() As DataRow) As Integer
        Dim result As Integer = Me._adpt.Update(datarows)
        Return result
    End Function
    Public Function GetData() As oleosigDB.detalles_opfabricaDataTable
        Dim tabla As oleosigDB.detalles_opfabricaDataTable = New oleosigDB.detalles_opfabricaDataTable
        Me._adpt.SelectCommand = Me._comandos(0)
        Me._adpt.Fill(tabla)
        Return tabla
    End Function

    Public Function GetMolturByPartida(ByVal partidas As List(Of Integer)) As List(Of Integer)
        Dim cmd As DbCommand

        Dim result As New List(Of Integer)

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandType = CommandType.Text

        For Each par As Integer In partidas


            cmd.CommandText = "select distinct(opfabrica) from detalles_opfabrica where campagna='" & Me._campagna.ToString & "' and idalmazara='" & Me._idalmazara.ToString & "' and partida='" & par.ToString & "'"

            If (cmd.Connection.State And ConnectionState.Open) <> ConnectionState.Open Then
                cmd.Connection.Open()
            End If
            Dim lector As DbDataReader = cmd.ExecuteReader()
            If lector.HasRows Then
                While lector.Read
                    If Not IsDBNull(lector(0)) Then
                        result.Add(CInt(lector(0)))
                    End If
                End While
            End If
            lector.Close()

        Next
        Return result
    End Function
    Public Function Fill(ByVal detalle As oleosigDB.detalles_opfabricaDataTable) As Integer
        detalle.Clear()
        Me._adpt.SelectCommand = Me._comandos(0)
        Dim result As Integer = Me._adpt.Fill(detalle)

        Return result

    End Function
    Private Sub iniComandos()
        Dim strsql As New System.Text.StringBuilder
        Dim cmd As DbCommand
        Dim param As DbParameter

        Me._comandos = New List(Of DbCommand)

        strsql.Append("select * from detalles_opfabrica where idalmazara=:idalmazara and campagna=:campagna order by id")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString
        cmd.CommandType = CommandType.Text

        param = cdatos.CreateParameter
        param.ParameterName = ":idalmazara"
        param.DbType = DbType.Int32
        param.Value = CType(Me._idalmazara, Int32)

        cmd.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":campagna"
        param.DbType = DbType.Int16
        param.Value = CType(Me._campagna, Int16)

        cmd.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":opfabrica"
        param.SourceColumn = "opfabrica"
        param.DbType = DbType.Int32



        Me._comandos.Add(cmd)



    End Sub
    Private Sub iniAdapt()
        Dim cmd As DbCommand
        Dim strsql As New System.Text.StringBuilder
        Dim tablamapping As DataTableMapping
        Dim param As DbParameter

        Me._adpt = cdatos.CreateDataAdapter()

        tablamapping = New DataTableMapping
        tablamapping.SourceTable = "Table"
        tablamapping.DataSetTable = "detalles_opfabrica"

        tablamapping.ColumnMappings.Add("id", "id")
        tablamapping.ColumnMappings.Add("opfabrica", "opfabrica")
        tablamapping.ColumnMappings.Add("partida", "partida")
        tablamapping.ColumnMappings.Add("kilos", "kilos")
        tablamapping.ColumnMappings.Add("campagna", "campagna")
        tablamapping.ColumnMappings.Add("idalmazara", "idalmazara")

        Me._adpt.TableMappings.Add(tablamapping)

        strsql.Append("insert into detalles_opfabrica (opfabrica,partida,kilos,campagna,idalmazara)")
        strsql.Append(" values (:opfabrica,:partida,:kilos,:campagna,:idalmazara)")


        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.InsertCommand = cmd

        strsql.Length = 0

        strsql.Append("update detalles_opfabrica set ")
        strsql.Append("opfabrica=:opfabrica,")
        strsql.Append("partida=:partida,")
        strsql.Append("kilos=:kilos")
        strsql.Append(" where id=:id")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.UpdateCommand = cmd

        strsql.Length = 0
        strsql.Append("delete from detalles_opfabrica where id=:id")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
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
        param.Value = CType(Me._idalmazara, Int32)

        Me._adpt.InsertCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":opfabrica"
        param.SourceColumn = "opfabrica"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = cdatos.CreateParameter
        param.ParameterName = ":partida"
        param.SourceColumn = "partida"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)


        param = cdatos.CreateParameter
        param.ParameterName = ":kilos"
        param.SourceColumn = "kilos"
        param.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(param)
        Me._adpt.UpdateCommand.Parameters.Add(param)


        param = cdatos.CreateParameter
        param.ParameterName = ":campagna"
        param.SourceColumn = "campagna"
        param.DbType = DbType.Int16
        param.Value = CType(Me._campagna, Int16)

        Me._adpt.InsertCommand.Parameters.Add(param)

    End Sub

    Public Sub New(ByVal idalmazara As Int32, ByVal campaña As Int16)
        Me._idalmazara = idalmazara
        Me._campagna = campaña

        cdatos = New CBaseDatos
        Me._conexion = cdatos.GetConnection

        iniAdapt()
        iniComandos()

    End Sub

End Class
