Option Strict Off
Option Explicit On

Imports System.Data.Common
Imports System.Text

Public Class LoteAceitunaTableAdapter


    Private _campagna As Byte
    Private _idalmazara As Integer
    Private _adpt As DbDataAdapter
    Private mvarFechas As ArrayList
    ' Private _lotes As CeLotAceituna
    Private cdatos As New CBaseDatos
    Private _conexion As DbConnection
    Private _clearBeforeFill As Boolean
    Private _comandos As List(Of DbCommand)


    'Public ReadOnly Property Lotes As CeLotAceituna
    '    Get
    '        Return _lotes
    '    End Get
    'End Property

    Public ReadOnly Property TotalKilos() As Integer
        Get
            TotalKilos = getTotal()
        End Get

    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Id"></param>
    ''' <remarks></remarks>
    Public Sub Delete(ByVal Id As UShort)
        Dim strSql As String


        strSql = "delete from lotesaceituna where id='" & Id.ToString & "'"

        cdatos.Haz(strSql)


    End Sub

    Public ReadOnly Property FechasTickets() As ArrayList
        Get
            If mvarFechas Is Nothing Then

                rellenaFechas()

            End If
            FechasTickets = mvarFechas
        End Get
    End Property


    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub


    Private Sub rellenaFechas()
        Dim cmd As DbCommand

        Dim lector As DbDataReader
        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = "select distinct(date(lotFecha)) as fecha from lotesaceituna where campagna='" & Me._campagna.ToString & "'" & _
            " and idalmazara='" & Me._idalmazara.ToString & "'"
        If _conexion.State = ConnectionState.Broken Or _conexion.State = ConnectionState.Closed Then
            Me._conexion.Open()
        End If

        lector = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        mvarFechas = New ArrayList


        Do While lector.Read()

            mvarFechas.Add(lector("fecha"))


        Loop
        lector.Close()

    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="numtolva"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getLastnumLote(ByVal numtolva As UShort) As UShort
        Dim cmd As DbCommand
        Dim lector As DbDataReader

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion

        cmd.CommandText = "select max(lotNumero) from lotesaceituna" & _
            " where campagna ='" & Me._campagna.ToString() & "'" & _
            " and lotTolva ='" & numtolva.ToString & "'" & _
            " and idalmazara='" & Me._idalmazara.ToString() & "'"

        If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
            Me._conexion.Open()
        End If

        lector = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        lector.Read()

        If Not IsDBNull(lector(0)) Then
            Return lector(0)
        Else
            Return 0
        End If
        lector.Close()

    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getLastnumLote() As UShort
        Dim cmd As DbCommand
        Dim result As Object
        Dim valordevuelto As UShort = 0


        cmd = _conexion.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = "select max(lotNumero) from lotesaceituna" & _
            " where campagna ='" & Me._campagna.ToString() & "'" & _
            " and idalmazara='" & Me._idalmazara.ToString() & "'"
        If Me._conexion.State = ConnectionState.Broken Or _conexion.State = ConnectionState.Closed Then
            Me._conexion.Open()
        End If

        result = cmd.ExecuteScalar
        Me._conexion.Close()

        If result Is Nothing Then
            valordevuelto = 0
        Else
            valordevuelto = CType(result, UShort)

        End If

        Return valordevuelto

    End Function


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="idSocio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDatabyCosechero(ByVal idSocio As UShort) As oleosigDB.lotesaceitunaDataTable
        Dim cmd As DbCommand
        Dim tabla As New oleosigDB.lotesaceitunaDataTable

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = "select * from lotesaceituna" & _
            " where lotCodigoSocio ='" & idSocio.ToString & "'" & _
            " and campagna ='" & Me._campagna.ToString() & "'" & _
            " and idalmazara='" & Me._idalmazara.ToString() & "'" & _
            " order by lotNumero"

        Me._adpt.SelectCommand = cmd
        Me._adpt.Fill(tabla)

        Return tabla

    End Function



    Public Sub actulizaRendimientos(ByVal numpesada As Integer, ByVal rendimiento As Double)
        Dim strsqlbldr As New StringBuilder

        strsqlbldr.Append("update lotesaceituna set lotrend='" & rendimiento.ToString() & "'")
        strsqlbldr.Append(" where lotnumero='" & numpesada.ToString & "'")
        strsqlbldr.Append(" and idalmazara='" & Me._idalmazara.ToString() & "'")
        strsqlbldr.Append(" and campagna='" & Me._campagna.ToString() & "'")
        Try
            cdatos.Haz(strsqlbldr.ToString)
        Catch ex As Exception

        End Try

    End Sub



    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="fechaini"></param>
    ''' <param name="fechafin"></param>
    ''' <param name="calidad"></param>
    ''' <param name="sSocio"></param>
    ''' <param name="sTolva"></param>
    ''' <param name="Variedades"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByFechas(ByVal fechaini As DateTime, ByVal fechafin As DateTime, ByVal calidad As Short, ByVal sSocio As String, ByVal sTolva As UShort, ByVal Variedades As ArrayList) As oleosigDB.lotesaceitunaDataTable
        Dim strSql As New StringBuilder
        Dim i As UShort
        Dim entidades As New oleosigDB.lotesaceitunaDataTable
        Dim cmd As DbCommand

        strSql.Append("select * from lotesaceituna")
        strSql.Append(" where lotFecha between ")
        strSql.Append("'" & fechaini.ToString("yyyy-MM-dd HH:mm:ss") & "'")
        strSql.Append(" and '" & fechafin.ToString("yyyy-MM-dd HH:mm:ss") & "'")
        strSql.Append(" and idalmazara='" & Me._idalmazara.ToString & "'")
        strSql.Append(" and campagna ='" & Me._campagna.ToString() & "'")
        strSql.Append(" and lotRecoleccion='" & calidad.ToString & "'")
        strSql.Append(" and lotCodigoSocio ='" & sSocio & "' and lotTolva ='" & sTolva.ToString & "'")

        strSql.Append(" and ")
        If Variedades.Count() > 0 Then
            For i = 0 To Variedades.Count - 1
                strSql.Append("lotCodigoVariedad ='" & Variedades.Item(i) & "'" & " or ")
            Next i
            strSql.Length = (strSql.Length - 4)
        End If




        strSql.Append(" order by lotNumero")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strSql.ToString

        Me._adpt.SelectCommand = cmd

        Me._adpt.Fill(entidades)

        Return entidades
    End Function
    Public Function GetDataByTolvaFecha(ByVal tolva As Integer, ByVal fecha As String) As oleosigDB.lotesaceitunaDataTable
        Dim tabla As New oleosigDB.lotesaceitunaDataTable
        Dim cmd As DbCommand
        Dim strsql As New Text.StringBuilder

        strsql.Append("select * from lotesaceituna where")
        strsql.Append(" lotTolva='" & tolva.ToString & "'")
        strsql.Append(" and campagna='" & Me._campagna.ToString() & "'")
        strsql.Append(" and idalmazara='" & Me._idalmazara.ToString() & "'")
        strsql.Append(" and date(lotfecha) ='" & fecha & "'")
        strsql.Append(" and importado='f'")
        strsql.Append(" order by lotfecha")

        cmd = cdatos.CreateCommand
        cmd.CommandText = strsql.ToString
        cmd.Connection = Me._conexion

        Me._adpt.SelectCommand = cmd

        Me._adpt.Fill(tabla)

        Return tabla

    End Function
    Public Function GetDataByTolvaVariedadFecha(ByVal tolva As Integer, ByVal variedad As Integer, ByVal fecha As String) As oleosigDB.lotesaceitunaDataTable
        Dim strsql As New Text.StringBuilder
        Dim cmd As DbCommand
        Dim tabla As New oleosigDB.lotesaceitunaDataTable

        strSql.Append("select * from lotesaceituna where")
        strsql.Append(" lotTolva='" & tolva.ToString & "'")
        strSql.Append(" and campagna='" & Me._campagna.ToString() & "'")
        strSql.Append(" and idalmazara='" & Me._idalmazara.ToString() & "'")
        strsql.Append(" and date(lotfecha) ='" & fecha & "'")
        strSql.Append(" and importado='f'")
        strsql.Append(" and lotcodigovariedad='" & variedad.ToString & "'")
        strSql.Append(" order by lotfecha")

        cmd = cdatos.CreateCommand
        cmd.CommandText = strsql.ToString
        cmd.Connection = Me._conexion

        Me._adpt.SelectCommand = cmd

        Me._adpt.Fill(tabla)

        Return tabla

    End Function
    Public Function GetDatabyTolvaCalidadFecha(ByVal tolva As Integer, ByVal recoleccion As Integer, ByVal fecha As DateTime) As oleosigDB.lotesaceitunaDataTable
        Dim tabla As oleosigDB.lotesaceitunaDataTable = New oleosigDB.lotesaceitunaDataTable()

        Me._adpt.SelectCommand = _comandos(1)

        Me._adpt.SelectCommand.Parameters(":lottolva").Value = CType(tolva, Integer)
        Me._adpt.SelectCommand.Parameters(":fecha").Value = fecha.ToString("yyyy-MM-dd")
        Me._adpt.SelectCommand.Parameters(":campagna").Value = CType(_campagna, Integer)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(_idalmazara, Integer)
        Me._adpt.SelectCommand.Parameters(":importado").Value = CType(False, Boolean)
        Me._adpt.SelectCommand.Parameters(":lotrecoleccion").Value = CType(recoleccion, Integer)


        Me._adpt.Fill(tabla)

        Return tabla
    End Function
    Public Overridable Overloads Function Fill(ByVal tabla As oleosigDB.lotesaceitunaDataTable) As Integer
        Me._adpt.SelectCommand = _comandos(0)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(_idalmazara, Integer)
        Me._adpt.SelectCommand.Parameters(":campagna").Value = CType(_campagna, Integer)
        If Me._clearBeforeFill Then
            tabla.Clear()
        End If
        Return Me._adpt.Fill(tabla)
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="fechaini"></param>
    ''' <param name="fechafin"></param>
    ''' <param name="calidad"></param>
    ''' <param name="sTolva"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByFechas(ByVal fechaini As DateTime, ByVal fechafin As DateTime, ByVal calidad As Short, ByVal sTolva As UShort) As oleosigDB.lotesaceitunaDataTable
        Dim strSql As New StringBuilder

        Dim entidades As New oleosigDB.lotesaceitunaDataTable
        Dim cmd As DbCommand


        strSql.Append("select * from lotesaceituna")
        strSql.Append(" where lotFecha between ")
        strSql.Append("'" & fechaini.ToString("yyyy-MM-dd HH:mm:ss") & "'")
        strSql.Append(" and '" & fechafin.ToString("yyyy-MM-dd HH:mm:ss") & "'")
        strSql.Append(" and idalmazara='" & Me._idalmazara.ToString & "'")
        strSql.Append(" and campagna ='" & Me._campagna.ToString() & "'")
        strSql.Append(" and lotRecoleccion='" & calidad.ToString & "'")
        strSql.Append(" and lotTolva ='" & sTolva.ToString & "'")
        strSql.Append(" order by lotNumero")

        cmd = cdatos.CreateCommand
        cmd.Connection = _conexion
        cmd.CommandText = strSql.ToString

        Me._adpt.SelectCommand = cmd
        Me._adpt.Fill(entidades)

        Return entidades
    End Function

    Public Function GetDataByFechasVariedad(ByVal fechaini As DateTime, ByVal fechafin As DateTime, ByVal calidad As Integer, ByVal sTolva As Integer, ByVal variedad As Integer) As oleosigDB.lotesaceitunaDataTable
        Dim strSql As New StringBuilder
        Dim entidades As New oleosigDB.lotesaceitunaDataTable
        Dim cmd As DbCommand


        strSql.Append("select * from lotesaceituna")
        strSql.Append(" where lotFecha between ")
        strSql.Append("'" & fechaini.ToString("yyyy-MM-dd HH:mm:ss") & "'")
        strSql.Append(" and '" & fechafin.ToString("yyyy-MM-dd HH:mm:ss") & "'")
        strSql.Append(" and idalmazara='" & Me._idalmazara.ToString & "'")
        strSql.Append(" and campagna ='" & Me._campagna.ToString() & "'")
        strSql.Append(" and lotRecoleccion='" & calidad.ToString & "'")
        strSql.Append(" and lotTolva ='" & sTolva.ToString & "'")
        strSql.Append(" and lotcodigovariedad='" & variedad.ToString & "'")
        strSql.Append(" order by lotNumero")

        cmd = cdatos.CreateCommand
        cmd.Connection = _conexion
        cmd.CommandText = strSql.ToString
        Me._adpt.SelectCommand = cmd
        Me._adpt.Fill(entidades)


        Return entidades
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="fechaini"></param>
    ''' <param name="fechafin"></param>
    ''' <param name="sTolva"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByFechas(ByVal fechaini As DateTime, ByVal fechafin As DateTime, ByVal sTolva As UShort) As oleosigDB.lotesaceitunaDataTable
        Dim strSql As New StringBuilder
        Dim entidades As New oleosigDB.lotesaceitunaDataTable
        Dim cmd As DbCommand


        strSql.Append("select * from lotesaceituna")
        strSql.Append(" where lotFecha between ")
        strSql.Append("'" & fechaini.ToString("yyyy-MM-dd HH:mm:ss") & "'")
        strSql.Append(" and '" & fechafin.ToString("yyyy-MM-dd HH:mm:ss") & "'")
        strSql.Append(" and idalmazara='" & Me._idalmazara.ToString & "'")
        strSql.Append(" and campagna ='" & Me._campagna.ToString() & "'")
        strSql.Append(" and lotTolva ='" & sTolva.ToString & "'")

        strSql.Append(" order by lotNumero")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strSql.ToString

        Me._adpt.SelectCommand = cmd
        Me._adpt.Fill(entidades)


        Return entidades
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="fechaini"></param>
    ''' <param name="fechafin"></param>
    ''' <param name="Variedades"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByFechas(ByVal fechaini As DateTime, ByVal fechafin As DateTime, ByVal Variedades As ArrayList) As oleosigDB.lotesaceitunaDataTable
        Dim strSql As New StringBuilder
        Dim i As UShort
        Dim entidades As New oleosigDB.lotesaceitunaDataTable
        Dim cmd As DbCommand

        strSql.Append("select * from lotesaceituna")
        strSql.Append(" where lotFecha between ")
        strSql.Append("'" & fechaini.ToString("yyyy-MM-dd HH:mm:ss") & "'")
        strSql.Append(" and '" & fechafin.ToString("yyyy-MM-dd HH:mm:ss") & "'")
        strSql.Append(" and idalmazara='" & Me._idalmazara.ToString & "'")
        strSql.Append(" and campagna ='" & Me._campagna.ToString() & "'")



        strSql.Append(" and ")
        If Variedades.Count() > 0 Then
            For i = 0 To Variedades.Count - 1
                strSql.Append("lotCodigoVariedad ='" & Variedades.Item(i) & "'" & " or ")
            Next i
            strSql.Length = strSql.Length - 4
        End If



        strSql.Append(" order by lotNumero")

        cmd = cdatos.CreateCommand
        cmd.Connection = _conexion
        cmd.CommandText = strSql.ToString

        Me._adpt.SelectCommand = cmd

        Me._adpt.Fill(entidades)



        Return entidades
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="fechaini"></param>
    ''' <param name="fechafin"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByFechas(ByVal fechaini As DateTime, ByVal fechafin As DateTime) As oleosigDB.lotesaceitunaDataTable
        Dim strSql As New StringBuilder
        Dim entidades As New oleosigDB.lotesaceitunaDataTable
        Dim cmd As DbCommand


        strSql.Append("select * from lotesaceituna")
        strSql.Append(" where lotFecha between ")
        strSql.Append("'" & fechaini.ToString("yyyy-MM-dd HH:mm:ss") & "'")
        strSql.Append(" and '" & fechafin.ToString("yyyy-MM-dd HH:mm:ss") & "'")
        strSql.Append(" and idalmazara='" & Me._idalmazara.ToString & "'")
        strSql.Append(" and campagna ='" & Me._campagna.ToString() & "'")

        strSql.Append(" order by lotNumero")

        cmd = cdatos.CreateCommand
        cmd.Connection = _conexion
        cmd.CommandText = strSql.ToString

        Me._adpt.SelectCommand = cmd

        Me._adpt.Fill(entidades)


        Return entidades
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="numtolva"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByTolva(ByVal numtolva As UShort) As oleosigDB.lotesaceitunaDataTable
        Dim strSql As String
        Dim Lotes As New oleosigDB.lotesaceitunaDataTable
        Dim cmd As DbCommand


        strSql = "select * from lotesaceituna where lotTolva ='" & numtolva.ToString & "'" & _
            " and idalmazara='" & Me._idalmazara & "' and campagna ='" & Me._campagna.ToString() & "' order by lotNumero"

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strSql

        Me._adpt.SelectCommand = cmd
        Me._adpt.Fill(Lotes)

        Return Lotes

    End Function





    Public Function GetDatabyVariedades(ByVal variedades As List(Of Integer)) As oleosigDB.lotesaceitunaDataTable
        Dim tabla As New oleosigDB.lotesaceitunaDataTable
        Dim strsql As New StringBuilder
        Dim cmd As DbCommand

        strsql.Append("select * from lotesaceituna where idalmazara='" & Me._idalmazara.ToString & "' ")
        strsql.Append("and campagna='" & Me._campagna.ToString & "' ")

        If variedades.Count > 0 Then
            strsql.Append("and (")
            For i = 0 To variedades.Count - 1
                strsql.Append("lotcodigovariedad='" & variedades(i).ToString & "' or ")
            Next
            strsql.Length = strsql.Length - 4
            strsql.Append(")")
        End If
        cmd = cdatos.CreateCommand
        cmd.CommandText = strsql.ToString
        cmd.CommandType = CommandType.Text
        cmd.Connection = Me._conexion

        Me._adpt.SelectCommand = cmd

        Me._adpt.Fill(tabla)
        Return tabla

    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetData() As oleosigDB.lotesaceitunaDataTable
        Dim tabla As New oleosigDB.lotesaceitunaDataTable



        Me._adpt.SelectCommand = _comandos(0)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(_idalmazara, Integer)
        Me._adpt.SelectCommand.Parameters(":campagna").Value = CType(_campagna, Integer)

        Me._adpt.Fill(tabla)

        Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return tabla
    End Function




    Private Sub inicia_datos()
        Dim cmd As DbCommand
        Dim strsql As New System.Text.StringBuilder
        Dim parametro As DbParameter
        Dim tablamaper As DataTableMapping

        tablamaper = New DataTableMapping("Table", "lotesaceituna")
        tablamaper.ColumnMappings.Add("id", "Id")
        tablamaper.ColumnMappings.Add("idalmazara", "Idalmazara")
        tablamaper.ColumnMappings.Add("lotnumero", "Numero")
        tablamaper.ColumnMappings.Add("lotcodigosocio", "Cosechero")
        tablamaper.ColumnMappings.Add("lotcodigotermino", "Termino")
        tablamaper.ColumnMappings.Add("lotparcela", "Parcela")
        tablamaper.ColumnMappings.Add("lotpoligono", "Poligono")
        tablamaper.ColumnMappings.Add("lotfinalkg", "Kilos")
        tablamaper.ColumnMappings.Add("lottolva", "Tolva")
        tablamaper.ColumnMappings.Add("lotmatricula", "Matricula")
        tablamaper.ColumnMappings.Add("lotfecha", "Fecha")
        tablamaper.ColumnMappings.Add("lotrecoleccion", "Calidad")
        tablamaper.ColumnMappings.Add("lotbascula", "Bascula")
        tablamaper.ColumnMappings.Add("lotcodigovariedad", "Variedad")
        tablamaper.ColumnMappings.Add("lotrend", "Rendimiento")
        tablamaper.ColumnMappings.Add("importado", "Importado")
        tablamaper.ColumnMappings.Add("campagna", "Campaña")

        Me._adpt.TableMappings.Add(tablamaper)


        strsql.Length = 0

        strsql.Append("insert into lotesaceituna (")
        strsql.Append("idalmazara,")
        strsql.Append("lotnumero,")
        strsql.Append("lotcodigosocio,")
        strsql.Append("lotcodigotermino,")
        strsql.Append("lotparcela,")
        strsql.Append("lotpoligono,")
        strsql.Append("lotfinalkg,")
        strsql.Append("lottolva,")
        strsql.Append("lotmatricula,")
        strsql.Append("lotfecha,")
        strsql.Append("lotrecoleccion,")
        strsql.Append("lotbascula,")
        strsql.Append("lotcodigovariedad,")
        strsql.Append("lotrend,")
        strsql.Append("importado,")
        strsql.Append("campagna)")
        strsql.Append(" values(")
        strsql.Append(":idalmazara,")
        strsql.Append(":lotnumero,")
        strsql.Append(":lotcodigosocio,")
        strsql.Append(":lotcodigotermino,")
        strsql.Append(":lotparcela,")
        strsql.Append(":lotpoligono,")
        strsql.Append(":lotfinalkg,")
        strsql.Append(":lottolva,")
        strsql.Append(":lotmatricula,")
        strsql.Append(":lotfecha,")
        strsql.Append(":lotrecoleccion,")
        strsql.Append(":lotbascula,")
        strsql.Append(":lotcodigovariedad,")
        strsql.Append(":lotrend,")
        strsql.Append(":importado,")
        strsql.Append(":campagna)")

        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.InsertCommand = cmd

        strsql.Length = 0

        strsql.Append("update lotesaceituna set lotcodigosocio = :lotcodigosocio,")
        strsql.Append("lotcodigotermino =:lotcodigotermino,")
        strsql.Append("lotparcela =:lotparcela,")
        strsql.Append("lotpoligono =:lotpoligono,")
        strsql.Append("lotfinalkg =:lotfinalkg,")
        strsql.Append("lottolva =:lottolva,")
        strsql.Append("lotmatricula =:lotmatricula,")
        strsql.Append("lotfecha = :lotfecha,")
        strsql.Append("lotrecoleccion =:lotrecoleccion,")
        strsql.Append("lotbascula =:lotbascula ,")
        strsql.Append("lotcodigovariedad =:lotcodigovariedad, ")
        strsql.Append("lotrend=:lotrend,")
        strsql.Append("importado=:importado")
        strsql.Append(" where id =:id")



        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.UpdateCommand = cmd

        strsql.Length = 0

        strsql.Append("delete from lotesaceituna where id=:id")

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString


        Me._adpt.DeleteCommand = cmd

        'parametros

        parametro = cdatos.CreateParameter
        parametro.DbType = DbType.Int32
        parametro.ParameterName = ":id"
        parametro.SourceColumn = "id"


        Me._adpt.UpdateCommand.Parameters.Add(parametro)
        Me._adpt.DeleteCommand.Parameters.Add(parametro)

        parametro = cdatos.CreateParameter
        parametro.DbType = DbType.Int32
        parametro.ParameterName = ":lotnumero"
        parametro.SourceColumn = "lotnumero"

        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)

        parametro = cdatos.CreateParameter
        parametro.ParameterName = ":idalmazara"
        parametro.DbType = DbType.Int32
        parametro.Value = Me._idalmazara
        parametro.SourceColumn = "idalmazara"


        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)

        parametro = cdatos.CreateParameter
        parametro.SourceColumn = "lotcodigosocio"
        parametro.ParameterName = ":lotcodigosocio"
        parametro.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)

        parametro = cdatos.CreateParameter
        parametro.SourceColumn = "lotcodigotermino"
        parametro.ParameterName = ":lotcodigotermino"
        parametro.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)

        parametro = cdatos.CreateParameter
        parametro.SourceColumn = "lotparcela"
        parametro.ParameterName = ":lotparcela"
        parametro.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)

        parametro = cdatos.CreateParameter
        parametro.SourceColumn = "lotpoligono"
        parametro.ParameterName = ":lotpoligono"
        parametro.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)

        parametro = cdatos.CreateParameter
        parametro.SourceColumn = "lotfinalkg"
        parametro.ParameterName = ":lotfinalkg"
        parametro.DbType = DbType.Double

        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)

        parametro = cdatos.CreateParameter
        parametro.SourceColumn = "lottolva"
        parametro.ParameterName = ":lottolva"
        parametro.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)

        parametro = cdatos.CreateParameter
        parametro.SourceColumn = "lotmatricula"
        parametro.ParameterName = ":lotmatricula"
        parametro.DbType = DbType.String

        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)

        parametro = cdatos.CreateParameter
        parametro.SourceColumn = "lotfecha"
        parametro.ParameterName = ":lotfecha"
        parametro.DbType = DbType.DateTime

        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)

        parametro = cdatos.CreateParameter
        parametro.SourceColumn = "lotrecoleccion"
        parametro.ParameterName = ":lotrecoleccion"
        parametro.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)

        parametro = cdatos.CreateParameter
        parametro.SourceColumn = "lotbascula"
        parametro.ParameterName = ":lotbascula"
        parametro.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)

        parametro = cdatos.CreateParameter
        parametro.SourceColumn = "lotcodigovariedad"
        parametro.ParameterName = ":lotcodigovariedad"
        parametro.DbType = DbType.Int32

        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)

        parametro = cdatos.CreateParameter
        parametro.ParameterName = ":campagna"
        parametro.SourceColumn = "campagna"
        parametro.DbType = DbType.Int32
        parametro.Value = Me._campagna


        Me._adpt.InsertCommand.Parameters.Add(parametro)

        parametro = cdatos.CreateParameter
        parametro.ParameterName = ":lotrend"
        parametro.SourceColumn = "lotrend"
        parametro.DbType = DbType.String

        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)

        parametro = Me.cdatos.CreateParameter
        parametro.ParameterName = ":importado"
        parametro.SourceColumn = "importado"
        parametro.DbType = DbType.Boolean

        Me._adpt.InsertCommand.Parameters.Add(parametro)
        Me._adpt.UpdateCommand.Parameters.Add(parametro)



    End Sub


    Public Overridable Overloads Function Update(ByVal tickets() As oleosigDB.lotesaceitunaRow) As Integer

        Return Me._adpt.Update(tickets)

    End Function



    Public Overridable Overloads Function Update(ByVal tabla As oleosigDB.lotesaceitunaDataTable) As Integer

        Return Me._adpt.Update(tabla)

    End Function
    Private Sub inicia_comandos()
        Dim cmd As DbCommand
        Dim strsql As New System.Text.StringBuilder
        Dim parametro As DbParameter

        _comandos = New List(Of DbCommand)

        strsql.Append("select * from lotesaceituna where idalmazara=:idalmazara and campagna=:campagna order by id")

        cmd = cdatos.CreateCommand()
        cmd.CommandText = strsql.ToString
        cmd.Connection = Me._conexion

        parametro = cdatos.CreateParameter
        parametro.SourceColumn = "idalmazara"
        parametro.ParameterName = ":idalmazara"
        parametro.DbType = DbType.Int32

        cmd.Parameters.Add(parametro)

        parametro = cdatos.CreateParameter
        parametro.SourceColumn = "campagna"
        parametro.ParameterName = ":campagna"
        parametro.DbType = DbType.Int32

        cmd.Parameters.Add(parametro)

        _comandos.Add(cmd)

        strsql.Length = 0
        strsql.Append("select * from lotesaceituna where")
        strsql.Append(" lotTolva=:lottolva")
        strsql.Append(" and campagna=:campagna")
        strsql.Append(" and idalmazara=:idalmazara")
        strsql.Append(" and date(lotFecha) =:lotfecha")
        strsql.Append(" and lotRecoleccion =:lotrecoleccion")
        strsql.Append(" and importado=:importado")
        strsql.Append(" order by lotfecha")

        cmd = cdatos.CreateCommand()
        cmd.CommandText = strsql.ToString
        cmd.Connection = Me._conexion

        parametro = cdatos.CreateParameter
        parametro.ParameterName = ":lottolva"
        parametro.DbType = DbType.Int32

        cmd.Parameters.Add(parametro)

        parametro = cdatos.CreateParameter
        parametro.ParameterName = ":campagna"
        parametro.DbType = DbType.Int32

        cmd.Parameters.Add(parametro)

        parametro = cdatos.CreateParameter
        parametro.ParameterName = ":idalmazara"
        parametro.DbType = DbType.Int32

        cmd.Parameters.Add(parametro)

        parametro = cdatos.CreateParameter
        parametro.ParameterName = ":lotfecha"
        parametro.DbType = DbType.String

        cmd.Parameters.Add(parametro)

        parametro = cdatos.CreateParameter
        parametro.ParameterName = ":lotrecoleccion"
        parametro.DbType = DbType.Int32

        cmd.Parameters.Add(parametro)

        parametro = cdatos.CreateParameter
        parametro.ParameterName = ":importado"
        parametro.DbType = DbType.Boolean

        cmd.Parameters.Add(parametro)

        _comandos.Add(cmd)

    End Sub
    Public Sub New(ByVal campagna As Byte, ByVal idalmazara As Integer)
        MyBase.New()
        Me._clearBeforeFill = True
        Me._idalmazara = idalmazara
        Me._campagna = campagna
        Me._conexion = cdatos.GetConnection
        Me._adpt = cdatos.CreateDataAdapter()


        inicia_comandos()
        inicia_datos()
        rellenaFechas()

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function getTotal() As Integer
        Dim strsql As String
        Dim total As Integer
        Dim cmd As DbCommand

        strsql = "select sum(lotFinalKg) from lotesaceituna where campagna ='" & Me._campagna.ToString() & _
            "' and idalmazara='" & Me._idalmazara.ToString() & "'"
        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql
        If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
            _conexion.Open()
        End If
        total = cmd.ExecuteScalar
        _conexion.Close()
        Return total
    End Function

End Class