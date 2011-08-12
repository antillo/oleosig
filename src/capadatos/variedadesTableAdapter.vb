Option Strict Off
Option Explicit On

Imports System.Data.Common
Imports System.Text

Public Class variedadesTableAdapter


    Private _idalmazara As Integer

    'Private _variedades As CeVariedades
    Private cdatos As New CBaseDatos

    Private conexion As DbConnection
    Private _adpt As DbDataAdapter
    Private _clearBeforeFill As Boolean
    Private _transaction As DbTransaction
    Private _comandos As List(Of DbCommand)

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
    Public Property ClearBeforeFill As Boolean
        Get
            Return Me._clearBeforeFill
        End Get
        Set(ByVal value As Boolean)
            Me._clearBeforeFill = value
        End Set
    End Property


    Public Function GetData() As DataTable
        Dim tabla As DataTable = New DataTable("varidades")
        Me._adpt.Fill(tabla)
        Return tabla
    End Function
    Public Function Fill(ByVal tabla As oleosigDB.variedadesDataTable) As Integer
        If Me._clearBeforeFill Then
            tabla.Clear()
        End If
        Dim resultado As Integer = Me._adpt.Fill(tabla)
        Return resultado
    End Function

    Public Sub Delete(ByVal id As Integer)

        Me._adpt.DeleteCommand.Parameters(0).Value = CType(id, Int32)
        If Me.conexion.State = ConnectionState.Closed Then
            Me.conexion.Open()
        End If
        Me._adpt.DeleteCommand.ExecuteNonQuery()
        Me.conexion.Close()

    End Sub

    Public Overridable Overloads Function update(ByVal filas() As oleosigDB.variedadesRow) As Integer
        Return Me._adpt.Update(filas)
    End Function

    Public Overridable Overloads Function Update(ByVal tabla As oleosigDB.variedadesDataTable) As Integer
        Return Me._adpt.Update(tabla)
    End Function

    Public Overridable Overloads Function Update(ByVal oleosig As oleosigDB) As Integer

        Dim resultado As Integer = Me._adpt.Update(oleosig, "variedades")
        Return resultado
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub inicia_datos()
        Dim strsql As String

        Dim cmd As System.Data.Common.DbCommand
        Dim columna As DataColumn
        Dim parametro As DbParameter
        Dim tablemapping As DataTableMapping

        Try


            tablemapping = New DataTableMapping("Table", "variedades")
            tablemapping.ColumnMappings.Add("id", "id")
            tablemapping.ColumnMappings.Add("idalmazara", "idalmazara")
            tablemapping.ColumnMappings.Add("varcodigo", "varcodigo")
            tablemapping.ColumnMappings.Add("varnombre", "varnombre")

            Me._adpt.TableMappings.Add(tablemapping)


            strsql = "select * from variedades where idalmazara=:idalmazara order by varCodigo"

            cmd = Me.cdatos.CreateCommand()
            cmd.CommandText = strsql

            cmd.Connection = Me.conexion


            Me._adpt.SelectCommand = cmd


            cmd = Me.cdatos.CreateCommand()
            cmd.CommandText = "insert into variedades (idalmazara,varcodigo,varnombre) values(:idalmazara,:varcodigo,:varnombre)"
            cmd.Connection = Me.conexion

            Me._adpt.InsertCommand = cmd


            cmd = Me.cdatos.CreateCommand
            cmd.CommandText = "delete from variedades where id=:id"
            cmd.Connection = Me.conexion


            Me._adpt.DeleteCommand = cmd

            cmd = Me.cdatos.CreateCommand()
            cmd.CommandText = "update variedades set varcodigo=:varcodigo, varnombre=:varnombre where id=:id"
            cmd.Connection = Me.conexion

            Me._adpt.UpdateCommand = cmd


            parametro = Me.cdatos.CreateParameter
            parametro.DbType = DbType.Int32
            parametro.ParameterName = ":id"
            parametro.SourceColumn = "id"

            Me._adpt.DeleteCommand.Parameters.Add(parametro)
            Me._adpt.UpdateCommand.Parameters.Add(parametro)


            parametro = Me.cdatos.CreateParameter()
            parametro.DbType = DbType.Int32
            parametro.ParameterName = ":idalmazara"
            parametro.SourceColumn = "idalmazara"
            parametro.Value = CType(Me._idalmazara, Int32)

            Me._adpt.SelectCommand.Parameters.Add(parametro)
            Me._adpt.InsertCommand.Parameters.Add(parametro)

            parametro = Me.cdatos.CreateParameter
            parametro.DbType = DbType.Int32
            parametro.ParameterName = ":varcodigo"
            parametro.SourceColumn = "varcodigo"

            Me._adpt.InsertCommand.Parameters.Add(parametro)
            Me._adpt.UpdateCommand.Parameters.Add(parametro)


            parametro = Me.cdatos.CreateParameter
            parametro.DbType = DbType.String
            parametro.ParameterName = ":varnombre"
            parametro.SourceColumn = "varnombre"

            Me._adpt.InsertCommand.Parameters.Add(parametro)
            Me._adpt.UpdateCommand.Parameters.Add(parametro)


        Catch ex As Exception
        Finally

        End Try


    End Sub
    Public Sub New()
        MyBase.New()
        Me.conexion = cdatos.GetConnection
        Me._idalmazara = 0
        Me._adpt = cdatos.CreateDataAdapter
        Me._clearBeforeFill = True
        inicia_datos()

    End Sub

    Public Sub New(ByVal idalmazara As Integer)
        MyBase.New()
        Me.conexion = cdatos.GetConnection
        Me._idalmazara = idalmazara
        Me._adpt = cdatos.CreateDataAdapter
        Me._clearBeforeFill = True
        inicia_datos()


    End Sub


End Class