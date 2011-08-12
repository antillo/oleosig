Option Strict Off
Option Explicit On

Imports System.Data.Common

Public Class opFiltradoTableAdapter



    Private _campagna As Byte
    Private _idalmazara As Integer
    Private cdatos As New CBaseDatos
    Private _conexion As DbConnection

    Private Function Rellena_entidad(ByRef lector As DbDataReader) As eOpFiltrado
        Dim entidad As eOpFiltrado
        Dim lectorp As DbDataReader
        Dim strSql As String

        entidad = New eOpFiltrado

        If lector.HasRows Then
            lector.Read()

            If lector.IsDBNull(0) Then
                entidad.Id = 0
            Else
                entidad.Id = lector.GetInt32(0)

            End If
            If lector.IsDBNull(1) Then
                entidad.Idalmazara = 0
            Else
                entidad.Idalmazara = lector.GetInt32(1)
            End If
            If lector.IsDBNull(2) Then
                entidad.Operacion = 0
            Else
                entidad.Operacion = CType(lector.GetInt32(2), UInteger)
            End If

            If lector.IsDBNull(3) Then

            Else
                entidad.FechaInicial = lector.GetDateTime(3)
            End If

            If lector.IsDBNull(4) Then

            Else
                entidad.FechaFinal = lector.GetDateTime(4)
            End If

            If lector.IsDBNull(5) Then
                entidad.Filtro = 0
            Else
                entidad.Filtro = CType(lector.GetInt32(5), UInteger)

            End If

            If lector.IsDBNull(6) Then
                entidad.Campaña = 0
            Else
                entidad.Campaña = lector.GetByte(6)
            End If
            If lector.IsDBNull(7) Then
                entidad.Abierta = False
            Else
                entidad.Abierta = lector.GetBoolean(7)
            End If
            lector.Close()

            strSql = "select * from detalles_opfiltrado where opfiltrado ='" & entidad.Operacion.ToString() & "' and campagna='" & Me._campagna.ToString() & "'"

            Dim cmd As DbCommand
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strSql.ToString
            If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
                Me._conexion.Open()
            End If
            lectorp = cmd.ExecuteReader(CommandBehavior.CloseConnection)



            Do While lectorp.Read()

                entidad.Detalles.Add(New eDetallesOpFiltrado(lectorp.GetInt32(0), _
                                                             lectorp.GetInt32(1), _
                                                             lectorp.GetInt32(2), _
                                                             lectorp.GetInt32(3), _
                                                             lectorp.GetByte(4)))


            Loop
            lectorp.Close()


        End If

        If Not lector.IsClosed Then lector.Close()


        Return entidad

    End Function

    Private Function Rellena_entidades(ByRef lector As DataTableReader) As CeOpFiltrado
        Dim entidades As CeOpFiltrado
        Dim entidad As eOpFiltrado
        Dim strsql As New System.Text.StringBuilder
        Dim lectorp As DbDataReader

        entidades = New CeOpFiltrado


        Do While lector.Read()
            entidad = New eOpFiltrado

            If lector.IsDBNull(0) Then
                entidad.Id = 0
            Else
                entidad.Id = lector.GetInt32(0)

            End If
            If lector.IsDBNull(1) Then
                entidad.Idalmazara = 0
            Else
                entidad.Idalmazara = lector.GetInt32(1)
            End If

            If lector.IsDBNull(2) Then
                entidad.Operacion = 0
            Else
                entidad.Operacion = CType(lector.GetInt32(2), UInteger)
            End If

            If lector.IsDBNull(3) Then

            Else
                entidad.FechaInicial = lector.GetDateTime(3)
            End If

            If lector.IsDBNull(4) Then

            Else
                entidad.FechaFinal = lector.GetDateTime(4)
            End If

            If lector.IsDBNull(5) Then
                entidad.Filtro = 0
            Else
                entidad.Filtro = CType(lector.GetInt32(5), UInteger)

            End If

            If lector.IsDBNull(6) Then
                entidad.Campaña = 0
            Else
                entidad.Campaña = lector.GetByte(6)
            End If
            If lector.IsDBNull(7) Then
                entidad.Abierta = False
            Else
                entidad.Abierta = lector.GetBoolean(7)
            End If




            entidades.Add(entidad)

        Loop

        lector.Close()

        For Each entidad In entidades

            strsql.Append("select * from detalles_opfiltrado where opfiltrado ='" & entidad.Operacion.ToString() & "' and campagna='" & Me._campagna.ToString() & "'")
            Dim cmd As DbCommand
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strsql.ToString
            If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
                Me._conexion.Open()
            End If
            lectorp = cmd.ExecuteReader(CommandBehavior.CloseConnection)



            Do While lectorp.Read()

                entidad.Detalles.Add(New eDetallesOpFiltrado(lectorp.GetInt32(0), _
                                                             lectorp.GetInt32(1), _
                                                             lectorp.GetInt32(2), _
                                                             lectorp.GetInt32(3), _
                                                             lectorp.GetByte(4)))


            Loop
            strsql.Remove(0, strsql.Length)
            lectorp.Close()
        Next




        If Not lector.IsClosed Then lector.Close()




        Return entidades

    End Function

    Public Function getLastNumOp() As UShort
        Dim strSql As String

        Dim resultado As Object
        Dim valordevuelto As Integer = 0

        strSql = "select max(numopfiltrado) from opfiltrado where campagna='" & Me._campagna.ToString() & "'" & _
            " and idalmazara='" & Me._idalmazara.ToString & "'"

        Dim cmd As DbCommand
        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strSql.ToString
        If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
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
    Public Function getLast() As eOpFiltrado
        Dim strSql As String
        Dim ultimoid As UShort
        Dim lector As DbDataReader
        Dim entidad As New eOpFiltrado


        ultimoid = Me.getLastNumOp()

        strSql = "select * from opfiltrado where numopfiltrado='" & ultimoid.ToString & "'" & _
            " and  campagna ='" & Me._campagna.ToString() & "'" & _
            " and idalmazara='" & Me._idalmazara.ToString & "'"
        Dim cmd As DbCommand
        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strSql.ToString
        If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
            Me._conexion.Open()
        End If
        lector = cmd.ExecuteReader(CommandBehavior.CloseConnection)


        entidad = Rellena_entidad(lector)


        Return entidad

    End Function


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="id"></param>
    ''' <remarks></remarks>
    Public Sub Borrar(ByVal id As UShort)
        Dim strSql As String

        strSql = "delete from opfiltrado where id ='" & id.ToString & "' and idalmazara='" & Me._idalmazara.ToString & "'"

        cDatos.Haz(strSql)


    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="entidad"></param>
    ''' <remarks></remarks>
    Public Sub Insertar(ByVal entidad As eOpFiltrado)
        Dim strSql As New System.Text.StringBuilder
        Dim detalle As eDetallesOpFiltrado



        strSql.Append("insert into opfiltrado (idalmazara,numopfiltrado,")
        strSql.Append("filtro,fechaini,fechafin,campagna,abierta)")
        strSql.Append(" values(")
        strSql.Append("'" & Me._idalmazara.ToString & "',")
        strSql.Append("'" & entidad.Operacion.ToString & "',")
        strSql.Append("'" & entidad.Filtro.ToString & "',")
        strSql.Append("'" & entidad.FechaInicial.ToString("yyyy-MM-dd HH:mm:ss") & "',")
        strSql.Append("'" & entidad.FechaFinal.ToString("yyyy-MM-dd HH:mm:ss") & "',")
        strSql.Append("'" & entidad.Campaña.ToString & "',")

        If entidad.Abierta Then
            strSql.Append("'1')")
        Else
            strSql.Append("'0')")
        End If

        cDatos.Haz(strSql.ToString())

        strSql.Remove(0, strSql.Length)

        entidad.Id = Me.getbyoperacion(entidad.Operacion).Id

        For Each detalle In entidad.Detalles

            strSql.Append("insert into detalles_opfiltrado (opfiltrado,opfabrica,kilos,campagna)")
            strSql.Append(" values (")
            strSql.Append("'" & entidad.Id.ToString() & "',")
            strSql.Append("'" & detalle.OpFabrica.ToString & "',")
            strSql.Append("'" & detalle.Kilos.ToString & "',")
            strSql.Append("'" & detalle.Campagna.ToString & "')")

            cDatos.Haz(strSql.ToString())

        Next detalle


    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="operacion"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getbyoperacion(ByVal operacion As Integer) As eOpFiltrado
        Dim strsql As String
        Dim lector As DbDataReader
        Dim entidad As New eOpFiltrado

        strsql = "select * from opfiltrado where numopefiltrado='" & operacion.ToString() & "'" & _
            " and campagna='" & Me._campagna.ToString() & "' and idalmazara='" & Me._idalmazara.ToString & "'"

        Dim cmd As DbCommand
        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString
        If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
            Me._conexion.Open()
        End If
        lector = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        entidad = Rellena_entidad(lector)

        Return entidad

    End Function
    Public Sub Editar(ByVal entidad As eOpFiltrado)

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getAll() As CeOpFiltrado
        Dim strSql As String
        Dim lector As DbDataReader
        Dim entidades As New CeOpFiltrado


        strSql = "select * from opfiltrado where campagna='" & Me._campagna.ToString() & "'" & _
            " and idalmazara='" & Me._idalmazara.ToString & "'"

        Dim cmd As DbCommand
        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strSql.ToString
        If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
            Me._conexion.Open()
        End If
        lector = cmd.ExecuteReader(CommandBehavior.CloseConnection)


        entidades = Rellena_entidades(lector)

        Return entidades

    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getById(ByVal id As UShort) As eOpFiltrado
        Dim strSql As String
        Dim lector As DbDataReader

        Dim entidad As eOpFiltrado


        strSql = "select * from opfiltrado where id='" & id.ToString & "' and campagna='" & Me._campagna.ToString() & "'"
        Dim cmd As DbCommand
        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strSql.ToString
        If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
            Me._conexion.Open()
        End If
        lector = cmd.ExecuteReader(CommandBehavior.CloseConnection)


        entidad = Rellena_entidad(lector)


        Return entidad



    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Fecha"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getByFecha(ByVal Fecha As DateTime) As CeOpFiltrado
        Dim strSql As String
        Dim lector As DbDataReader
        Dim entidades As New CeOpFiltrado

        strSql = "select * from opfiltrado where date(fechaini) <='" & Fecha.ToString("yyyy-MM-dd HH:mm:ss") & "'" & _
            " and date(fechafin) >= '" & Fecha.ToString("yyyy-MM-dd HH:mm:ss") & "'" & _
            " and campagna='" & Me._campagna.ToString() & "'" & _
            " and idalmazara='" & Me._idalmazara.ToString & "'"
        Dim cmd As DbCommand
        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strSql.ToString
        If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
            Me._conexion.Open()
        End If
        lector = cmd.ExecuteReader(CommandBehavior.CloseConnection)


        entidades = Rellena_entidades(lector)

        Return entidades
    End Function


    Public Sub New(ByVal campagna As Byte, ByVal idalmazara As Integer)
        MyBase.New()

        Me._campagna = campagna
        Me._idalmazara = idalmazara
        Me._conexion = cdatos.GetConnection

    End Sub


    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub
End Class