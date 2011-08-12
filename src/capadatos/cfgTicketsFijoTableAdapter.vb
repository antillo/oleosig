Imports System.Data.Common
Imports System.ComponentModel

Public Class cfgTicketsFijoTableAdapter


    Private cdatos As CBaseDatos


    Private _idalmazara As Integer
    Private _tipo As Integer

    Private _adpt As DbDataAdapter
    Private _conexion As DbConnection
    Private _comandos As List(Of DbCommand)
    Private _clearBeforeFill As Boolean

    Public Overridable Overloads Function Delete(ByVal id As Integer) As Integer

        Me._adpt.DeleteCommand.Parameters(":id").Value = CType(id, Integer)
        Dim estadoanterior As ConnectionState = Me._adpt.DeleteCommand.Connection.State

        If (estadoanterior And ConnectionState.Open) <> ConnectionState.Open Then
            Me._adpt.DeleteCommand.Connection.Open()
        End If
        Dim result As Integer = Me._adpt.DeleteCommand.ExecuteNonQuery()
        If estadoanterior = ConnectionState.Closed Then
            Me._adpt.DeleteCommand.Connection.Close()
        End If
        Return result
    End Function

    Public Overridable Overloads Function Update(ByVal oleosig As oleosigDB) As Integer
        Dim result As Integer = Me._adpt.Update(oleosig, "cfg_imp_ticket_fijo")
        Return result
    End Function
    Public Overridable Overloads Function Update(ByVal tabla As oleosigDB.cfg_imp_ticket_fijoDataTable) As Integer
        Dim result As Integer = Me._adpt.Update(tabla)
        Return result
    End Function

    Public Function Fill(ByVal tabla As oleosigDB.cfg_imp_ticket_fijoDataTable) As Integer
        Me._adpt.SelectCommand = _comandos(0)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(Me._idalmazara, Integer)
        If _clearBeforeFill Then
            tabla.Clear()
        End If
        Dim result As Integer = Me._adpt.Fill(tabla)
        Return result
    End Function
    Private Sub inicia_comands()
        Dim cmd As DbCommand
        Dim parametro As DbParameter

        _comandos = New List(Of DbCommand)

        cmd = Me.cdatos.CreateCommand()
        cmd.CommandText = "select * from cfg_imp_ticket_fijo where idalmazara=:idalmazara order by id"
        cmd.Connection = Me._conexion
        cmd.CommandType = CommandType.Text

        parametro = Me.cdatos.CreateParameter
        parametro.ParameterName = ":idalmazara"
        parametro.SourceColumn = "idalmazara"
        parametro.DbType = DbType.Int32
        parametro.Value = Me._idalmazara

        cmd.Parameters.Add(parametro)
        _comandos.Add(cmd)

    End Sub
    Private Sub inicia_datos()
        Dim cmd As DbCommand
        Dim parametro As DbParameter
        Dim tablamaping As DataTableMapping


        tablamaping = New DataTableMapping("Table", "cfg_imp_ticke_fijo")
        tablamaping.ColumnMappings.Add("id", "id")
        tablamaping.ColumnMappings.Add("idalamzara", "idalmazara")
        tablamaping.ColumnMappings.Add("campo", "campo")
        tablamaping.ColumnMappings.Add("posicion", "poscion")
        tablamaping.ColumnMappings.Add("descripcion", "descripcion")
        tablamaping.ColumnMappings.Add("importar", "importar")
        tablamaping.ColumnMappings.Add("numimportacion", "numimportacion")

        Me._adpt.TableMappings.Add(tablamaping)

        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = "insert into cfg_imp_ticket_fijo (idalmazara,campo,inicio,longitud,descripcion,importar,numimportacion) values(:idalmazara,:campo,:inicio,:longitud,:descripcion,:importar,:numimportacion)"

        Me._adpt.InsertCommand = cmd

        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = "update cfg_imp_ticket_fijo set campo=:campo, inicio=:inicio, longitud=:longitud, descripcion=:descripcion, importar=:importar, numimportacion=:numimportacion where id=:id"

        Me._adpt.UpdateCommand = cmd

        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = "delete from cfg_imp_ticket_fijo where id=:id"

        Me._adpt.DeleteCommand = cmd

        parametro = Me.cdatos.CreateParameter
        parametro.ParameterName = ":id"
        parametro.SourceColumn = "id"
        parametro.DbType = DbType.Int32


        Me._adpt.UpdateCommand.Parameters.Add(parametro)
        Me._adpt.DeleteCommand.Parameters.Add(parametro)


        parametro = Me.cdatos.CreateParameter
        parametro.ParameterName = ":idalmazara"
        parametro.SourceColumn = "idalmazara"
        parametro.DbType = DbType.Int32
        parametro.Value = Me._idalmazara


        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)


        parametro = Me.cdatos.CreateParameter
        parametro.ParameterName = ":campo"
        parametro.SourceColumn = "campo"
        parametro.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)

        parametro = Me.cdatos.CreateParameter
        parametro.ParameterName = ":inicio"
        parametro.SourceColumn = "inicio"
        parametro.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)

        parametro = Me.cdatos.CreateParameter
        parametro.ParameterName = ":longitud"
        parametro.SourceColumn = "longitud"
        parametro.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)

        parametro = Me.cdatos.CreateParameter
        parametro.ParameterName = ":descripcion"
        parametro.SourceColumn = "descripcion"
        parametro.DbType = DbType.String

        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)

        parametro = Me.cdatos.CreateParameter
        parametro.ParameterName = ":importar"
        parametro.SourceColumn = "importar"
        parametro.DbType = DbType.Boolean

        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)

        parametro = Me.cdatos.CreateParameter
        parametro.ParameterName = ":numimportacion"
        parametro.SourceColumn = "numimportacion"
        parametro.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)



    End Sub


    Public Sub New(ByVal idalmazara As Integer)
        MyBase.New()
        Me.cdatos = New CBaseDatos
        Me._conexion = cdatos.GetConnection
        Me._idalmazara = idalmazara

        Me._adpt = cdatos.CreateDataAdapter

        Me.inicia_datos()
        Me.inicia_comands()

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class ImpTicketFijo


        Private _campos As camposImpFijo

        Public Property Campos As camposImpFijo
            Get
                If _campos Is Nothing Then
                    _campos = New camposImpFijo
                End If
                Return _campos
            End Get
            Set(ByVal value As camposImpFijo)
                _campos = value
            End Set
        End Property


        Public Class camposImpFijo
            Private _Ticket As campoImpFijo
            Private _Cosechero As campoImpFijo
            Private _Dia As campoImpFijo
            Private _Mes As campoImpFijo
            Private _Anio As campoImpFijo
            Private _Hora As campoImpFijo
            Private _Minuto As campoImpFijo
            Private _Segundo As campoImpFijo
            Private _Kilos As campoImpFijo
            Private _Matricula As campoImpFijo
            Private _Calidad As campoImpFijo
            Private _Variedad As campoImpFijo
            Private _Termino As campoImpFijo
            Private _Bascula As campoImpFijo
            Private _Tolva As campoImpFijo
            Private _Poligono As campoImpFijo
            Private _Parcela As campoImpFijo

            Public Property Ticket As campoImpFijo
                Get
                    Return _Ticket
                End Get
                Set(ByVal value As campoImpFijo)
                    _Ticket = value
                End Set
            End Property
            Public Property Cosechero As campoImpFijo
                Get
                    Return _Cosechero
                End Get
                Set(ByVal value As campoImpFijo)
                    _Cosechero = value
                End Set
            End Property

            Public Property Dia As campoImpFijo
                Get
                    Return _Dia
                End Get
                Set(ByVal value As campoImpFijo)
                    _Dia = value
                End Set
            End Property
            Public Property Mes As campoImpFijo
                Get
                    Return _Mes
                End Get
                Set(ByVal value As campoImpFijo)
                    _Mes = value
                End Set
            End Property
            Public Property Anio As campoImpFijo
                Get
                    Return _Anio
                End Get
                Set(ByVal value As campoImpFijo)
                    _Anio = value
                End Set
            End Property
            Public Property Hora As campoImpFijo
                Get
                    Return _Hora
                End Get
                Set(ByVal value As campoImpFijo)
                    _Hora = value
                End Set
            End Property
            Public Property Minuto As campoImpFijo
                Get
                    Return _Minuto
                End Get
                Set(ByVal value As campoImpFijo)
                    _Minuto = value
                End Set
            End Property
            Public Property Segundo As campoImpFijo
                Get
                    Return _Segundo
                End Get
                Set(ByVal value As campoImpFijo)
                    _Segundo = value
                End Set
            End Property
            Public Property Kilos As campoImpFijo
                Get
                    Return _Kilos
                End Get
                Set(ByVal value As campoImpFijo)
                    _Kilos = value
                End Set
            End Property
            Public Property Matricula As campoImpFijo
                Get
                    Return _Matricula
                End Get
                Set(ByVal value As campoImpFijo)
                    _Matricula = value
                End Set
            End Property
            Public Property Calidad As campoImpFijo
                Get
                    Return _Calidad
                End Get
                Set(ByVal value As campoImpFijo)
                    _Calidad = value
                End Set
            End Property
            Public Property Variedad As campoImpFijo
                Get
                    Return _Variedad
                End Get
                Set(ByVal value As campoImpFijo)
                    _Variedad = value
                End Set
            End Property
            Public Property Termino As campoImpFijo
                Get
                    Return _Termino
                End Get
                Set(ByVal value As campoImpFijo)
                    _Termino = value
                End Set
            End Property
            Public Property Bascula As campoImpFijo
                Get
                    Return _Bascula
                End Get
                Set(ByVal value As campoImpFijo)
                    _Bascula = value
                End Set
            End Property

            Public Property Tolva As campoImpFijo
                Get
                    Return _Tolva
                End Get
                Set(ByVal value As campoImpFijo)
                    _Tolva = value
                End Set
            End Property
            Public Property Poligono As campoImpFijo
                Get
                    Return _Poligono
                End Get
                Set(ByVal value As campoImpFijo)
                    _Poligono = value
                End Set
            End Property
            Public Property Parcela As campoImpFijo
                Get
                    Return _Parcela
                End Get
                Set(ByVal value As campoImpFijo)
                    _Parcela = value
                End Set
            End Property

            Public Sub New()
                _Ticket = New campoImpFijo
                _Cosechero = New campoImpFijo
                _Dia = New campoImpFijo
                _Mes = New campoImpFijo
                _Anio = New campoImpFijo
                _Hora = New campoImpFijo
                _Minuto = New campoImpFijo
                _Segundo = New campoImpFijo
                _Kilos = New campoImpFijo
                _Matricula = New campoImpFijo
                _Calidad = New campoImpFijo
                _Variedad = New campoImpFijo
                _Termino = New campoImpFijo
                _Bascula = New campoImpFijo
                _Tolva = New campoImpFijo
                _Poligono = New campoImpFijo
                _Parcela = New campoImpFijo

            End Sub
        End Class

        Public Class campoImpFijo
            Private _id As Integer
            Private _idalmazara As Integer
            Private _campo As Integer
            Private _inicio As Integer
            Private _longitud As Integer
            Private _descripcion As String
            Private _importar As Boolean
            Private _numimportacion As Integer

            Public Property Id As Integer
                Get
                    Return Me._id
                End Get
                Set(ByVal value As Integer)
                    Me._id = value
                End Set
            End Property
            Public Property Idalmazara As Integer
                Get
                    Return Me._idalmazara
                End Get
                Set(ByVal value As Integer)
                    Me._idalmazara = value
                End Set
            End Property
            Public Property Campo As Integer
                Get
                    Return Me._campo
                End Get
                Set(ByVal value As Integer)
                    Me._campo = value
                End Set
            End Property
            Public Property Inicio As Integer
                Get
                    Return Me._inicio
                End Get
                Set(ByVal value As Integer)
                    Me._inicio = value
                End Set
            End Property
            Public Property Longitud As Integer
                Get
                    Return Me._longitud
                End Get
                Set(ByVal value As Integer)
                    Me._longitud = value
                End Set
            End Property
            Public Property Descripcion As String
                Get
                    Return Me._descripcion
                End Get
                Set(ByVal value As String)
                    Me._descripcion = value
                End Set
            End Property
            Public Property Importar As Boolean
                Get
                    Return Me._importar
                End Get
                Set(ByVal value As Boolean)
                    Me._importar = value
                End Set
            End Property
            Public Property Numimportacion As Integer
                Get
                    Return Me._numimportacion
                End Get
                Set(ByVal value As Integer)
                    Me._numimportacion = value
                End Set
            End Property
            Public Sub New()
                Me.New(0, 0, 0, 0, 0, "", False, 0)

            End Sub
            Public Sub New(ByVal idalmazara As UInteger, ByVal campo As UInteger, ByVal inicio As UInteger, ByVal longitud As UInteger, ByVal descripcion As String, ByVal importar As Boolean, ByVal numimportacion As Integer)
                Me.New(0, idalmazara, campo, inicio, longitud, descripcion, importar, numimportacion)
            End Sub

            Public Sub New(ByVal id As UInteger, ByVal idalmazara As UInteger, ByVal campo As UInteger, ByVal inicio As UInteger, ByVal longitud As UInteger, ByVal descripcion As String, ByVal importar As Boolean, ByVal numimportacion As Integer)

                Me._id = id
                Me._idalmazara = idalmazara
                Me._campo = campo
                Me._inicio = inicio
                Me._longitud = longitud
                Me._descripcion = descripcion
                Me._importar = importar
                Me._numimportacion = numimportacion
            End Sub
        End Class


    End Class
End Class
