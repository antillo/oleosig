Option Strict Off
Option Explicit On

Imports System.Data.Common

Public Class parAceitunaTableAdapter



    Private _campagna As Byte
    Private _idalmazara As Integer
    Private _adpt As DbDataAdapter
    Private cdatos As New CBaseDatos
    Private _conexion As DbConnection
    Private _clearBeforeFill As Boolean
    Private _comandos As List(Of DbCommand)


    Public Overridable Overloads Function Fill(ByVal tabla As oleosigDB.partidasaceitunaDataTable) As Integer
        Me._adpt.SelectCommand = _comandos(0)
        Me._adpt.SelectCommand.Parameters(":idalmazara").Value = CType(_idalmazara, Integer)
        Me._adpt.SelectCommand.Parameters(":campagna").Value = CType(_campagna, Integer)
        If _clearBeforeFill Then
            tabla.Clear()
        End If
        Return Me._adpt.Fill(tabla)

    End Function


    Public Function GetDataByVariedad(ByVal variedades As List(Of Integer)) As oleosigDB.partidasaceitunaDataTable
        Dim rsltPartidas As New oleosigDB.partidasaceitunaDataTable
        Dim cmd As DbCommand
        Dim strsql As New System.Text.StringBuilder

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandType = CommandType.Text

        strsql.Append("select * from partidasaceituna where campagna='" & Me._campagna.ToString() & "' and idalmazara='" & Me._idalmazara.ToString() & "'")
        If variedades.Count > 0 Then
            strsql.Append(" and (")

            For Each var As Integer In variedades

                strsql.Append(" variedad='" & var.ToString & "' or")

            Next
            strsql.Length = strsql.Length - 3
            strsql.Append(")")
        End If
        cmd.CommandText = strsql.ToString

        Me._adpt.SelectCommand = cmd

        Me._adpt.Fill(rsltPartidas)


        Return rsltPartidas
    End Function

    ''' <summary>
    '''
    ''' </summary>
    ''' <param name="sTolvas"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByTolvas(ByVal sTolvas As ArrayList) As oleosigDB.partidasaceitunaDataTable
        Dim strsql As New System.Text.StringBuilder
        Dim Tolvas As New System.Text.StringBuilder
        Dim entidades As New oleosigDB.partidasaceitunaDataTable
        Dim i As Short
        Dim cmd As DbCommand


        strsql.Append("select * from partidasaceituna where campagna='" & Me._campagna.ToString() & "'")
        strsql.Append(" and idalmazara='" & Me._idalmazara.ToString & "'")



        For i = 0 To sTolvas.Count() - 1
            Tolvas.Append("parTolva='" & sTolvas.Item(i) & "' or ")
        Next i
        Tolvas.Remove(Tolvas.Length - 4, 4)

        strsql.Append(" and (" & Tolvas.ToString() & ")")


        strsql.Append(" order by parFechaInicio")
        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.SelectCommand = cmd

        Me._adpt.Fill(entidades)



        Return entidades

    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub BorrarTodas()
        Dim strsql As String
        strsql = "delete from partidasaceituna where campagna='" & Me._campagna.ToString & "' and idalmazara='" & Me._idalmazara.ToString & "'"
        Me.cdatos.Haz(strsql)
        strsql = "update lotesaceituna set importado='f' where campagna='" & Me._campagna.ToString & "' and idalmazara='" & Me._idalmazara.ToString & "'"
        Me.cdatos.Haz(strsql)
    End Sub

    Public Sub BorrarTodas(ByVal tolva As UShort)
        Dim strsql As String
        strsql = "delete from partidasaceituna where campagna='" & Me._campagna.ToString & "' and idalmazara='" & Me._idalmazara.ToString & "' and partolva='" & tolva.ToString & "'"
        Me.cdatos.Haz(strsql)
        strsql = "update lotesaceituna set importado='f' where campagna='" & Me._campagna.ToString & "' and idalmazara='" & Me._idalmazara.ToString & "' and lottolva='" & tolva.ToString & "'"
        Me.cdatos.Haz(strsql)

    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Fecha"></param>
    ''' <param name="sTolva"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByFecha(ByVal Fecha As DateTime, ByVal sTolva As UShort) As oleosigDB.partidasaceitunaDataTable
        Dim strSql As New System.Text.StringBuilder
        Dim cmd As DbCommand
        Dim tabla As New oleosigDB.partidasaceitunaDataTable

        strSql.Append("select * from partidasaceituna where parFechaInicio <=")
        strSql.Append("'" & Fecha.ToString("yyyy-MM-dd HH:mm:ss") & "'")
        strSql.Append(" and parFechaFin >=")
        strSql.Append("'" & Fecha.ToString("yyyy-MM-dd HH:mm:ss") & "'")
        strSql.Append(" and campagna ='" & Me._campagna.ToString & "'")
        strSql.Append(" and idalmazara='" & Me._idalmazara.ToString & "'")

        If sTolva > 0 Then
            strSql.Append(" and parTolva ='" & sTolva.ToString & "'")
        End If
        strSql.Append(" order by parNumero")


        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strSql.ToString
        cmd.CommandType = CommandType.Text

        Me._adpt.SelectCommand = cmd
        Me._adpt.Fill(tabla)

        Return tabla

    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="vTolva"></param>
    ''' <remarks></remarks>
    Public Sub ActualizaPorDias(ByVal vTolva As UShort)
        Dim strSql As New System.Text.StringBuilder
        Dim lector As DbDataReader
        Dim oEntidad As oleosigDB.partidasaceitunaRow
        Dim entidades As New oleosigDB.partidasaceitunaDataTable
        Dim otickets As New LoteAceitunaTableAdapter(Me._campagna, Me._idalmazara)
        Dim tickets As oleosigDB.lotesaceitunaDataTable
        Dim ticket As oleosigDB.lotesaceitunaRow
        Dim ultimoid As Integer
        Dim fechas As New ArrayList
        Dim i As Integer
        Dim primero As Boolean = True
        Dim kilos As Integer = 0
        Dim fechatmp As Date
        Dim tolvatmp As Integer
        Dim calidad As Integer
        Dim cmd As DbCommand

        ultimoid = Me.Ultima()

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion


        strSql.Append("select distinct(date(lotFecha)) as fecha from lotesaceituna where lotTolva='" & vTolva.ToString & "'")
        strSql.Append(" and campagna='" & Me._campagna.ToString() & "'")
        strSql.Append(" and idalmazara='" & Me._idalmazara.ToString & "'")
        strSql.Append(" and importado='f'")
        strSql.Append(" order by date(lotfecha)")

        cmd.CommandText = strSql.ToString
        If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
            Me._conexion.Open()
        End If
        lector = cmd.ExecuteReader(CommandBehavior.CloseConnection)


        strSql.Length = 0

        If lector.HasRows Then

            Do While lector.Read()
                fechas.Add(lector.GetDateTime(0))
            Loop
        End If

        lector.Close()

        If fechas.Count > 0 Then
            For i = 0 To fechas.Count - 1

                tickets = otickets.GetDataByTolvaFecha(vTolva, CDate(fechas(i)).ToString("yyyy-MM-dd"))


                For Each ticket In tickets

                    ticket.Importado = True

                    fechatmp = ticket.Fecha
                    tolvatmp = ticket.Tolva
                    calidad = ticket.Calidad

                    If primero Then

                        oEntidad = entidades.NewpartidasaceitunaRow

                        oEntidad.Abierta = True
                        oEntidad.FechaIniLlenado = fechatmp
                        kilos = ticket.Kilos
                        primero = False

                    Else
                        kilos += ticket.Kilos
                    End If

                    If kilos >= 10000 Then

                        oEntidad.Abierta = False
                        oEntidad.FechaFinLlenado = fechatmp
                        oEntidad.FechaIniVaciado = DateAdd(DateInterval.Day, 1, oEntidad.FechaFinLlenado)
                        oEntidad.FechaFinVaciado = DateAdd(DateInterval.Day, 1, oEntidad.FechaIniVaciado)
                        oEntidad.Kilos = kilos
                        oEntidad.Tolva = tolvatmp
                        oEntidad.Campaña = ticket.Campaña
                        oEntidad.Idalmazara = ticket.Idalmazara
                        oEntidad.Numero = ultimoid + 1
                        oEntidad.Calidad = calidad

                        entidades.AddpartidasaceitunaRow(oEntidad)

                        ultimoid = ultimoid + 1
                        primero = True

                    End If
                Next

                If oEntidad.Abierta = True Then
                    oEntidad.Abierta = False
                    oEntidad.FechaFinLlenado = fechatmp
                    oEntidad.FechaIniVaciado = DateAdd(DateInterval.Day, 1, oEntidad.FechaFinLlenado)
                    oEntidad.FechaFinVaciado = DateAdd(DateInterval.Day, 1, oEntidad.FechaIniVaciado)
                    oEntidad.Kilos = kilos
                    oEntidad.Tolva = tolvatmp
                    oEntidad.Numero = ultimoid + 1
                    oEntidad.Calidad = calidad

                    oEntidad.Campaña = Me._campagna.ToString()
                    oEntidad.Idalmazara = Me._idalmazara.ToString
                    entidades.AddpartidasaceitunaRow(oEntidad)

                    kilos = 0
                    ultimoid += 1
                    primero = True
                End If

            Next i

            Me.Update(entidades)

            otickets.Update(tickets)

        End If



    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="vTolva"></param>
    ''' <remarks></remarks>
    Public Sub ActualizaPorDiasVariedad(ByVal vTolva As UShort)
        Dim strSql As New System.Text.StringBuilder
        Dim lector As DbDataReader
        Dim oEntidad As oleosigDB.partidasaceitunaRow
        Dim entidades As New oleosigDB.partidasaceitunaDataTable
        Dim otickets As New LoteAceitunaTableAdapter(Me._campagna, Me._idalmazara)
        Dim tickets As oleosigDB.lotesaceitunaDataTable
        Dim ticket As oleosigDB.lotesaceitunaRow
        Dim ultimoid As Integer
        Dim fechas As New ArrayList
        Dim i As Integer
        Dim primero As Boolean = True
        Dim kilos As Integer = 0
        Dim fechatmp As Date
        Dim tolvatmp As Integer
        Dim calidad As Integer
        Dim cmd As DbCommand
        Dim variedad As Integer

        ultimoid = Me.Ultima()

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion



        strSql.Append("select distinct(date(lotFecha)) as fecha from lotesaceituna where lotTolva='" & vTolva.ToString & "'")
        strSql.Append(" and campagna='" & Me._campagna.ToString() & "'")
        strSql.Append(" and idalmazara='" & Me._idalmazara.ToString & "'")
        strSql.Append(" and importado='f'")
        strSql.Append(" order by date(lotfecha)")

        cmd.CommandText = strSql.ToString

        If (cmd.Connection.State And ConnectionState.Open) <> ConnectionState.Open Then
            cmd.Connection.Open()
        End If
        lector = cmd.ExecuteReader(CommandBehavior.CloseConnection)


        strSql.Length = 0

        If lector.HasRows Then
            Do While lector.Read()
                fechas.Add(lector.GetDateTime(0))
            Loop
        End If

        lector.Close()


        If fechas.Count > 0 Then
            For i = 0 To fechas.Count - 1
                Dim variedades As List(Of Integer) = New List(Of Integer)

                strSql.Length = 0
                strSql.Append("select distinct lotcodigovariedad,lotfecha from lotesaceituna where date(lotfecha) ='" & CDate(fechas(i)).ToString("yyyy-MM-dd") & "'")
                strSql.Append(" and idalmazara='" & Me._idalmazara.ToString & "'")
                strSql.Append(" and importado='f'")
                strSql.Append(" order by lotfecha")

                cmd.CommandText = strSql.ToString

                If (Me._conexion.State And ConnectionState.Open) <> ConnectionState.Open Then
                    cmd.Connection.Open()
                End If

                lector = cmd.ExecuteReader(CommandBehavior.CloseConnection)

                If lector.HasRows Then
                    While lector.Read
                        If Not lector.IsDBNull(0) Then
                            variedades.Add(lector(0))
                        End If
                    End While
                End If

                If Not lector.IsClosed Then
                    lector.Close()
                End If

                For Each var As Integer In variedades

                    tickets = otickets.GetDataByTolvaVariedadFecha(vTolva, var, CDate(fechas(i)).ToString("yyyy-MM-dd"))


                    For Each ticket In tickets

                        ticket.Importado = True

                        fechatmp = ticket.Fecha
                        tolvatmp = ticket.Tolva
                        calidad = ticket.Calidad
                        variedad = ticket.Variedad

                        If primero Then

                            oEntidad = entidades.NewpartidasaceitunaRow

                            oEntidad.Abierta = True
                            oEntidad.FechaIniLlenado = fechatmp

                            kilos = ticket.Kilos
                            primero = False

                        Else
                            kilos += ticket.Kilos
                        End If



                    Next

                    If oEntidad.Abierta = True Then
                        oEntidad.Abierta = False
                        oEntidad.FechaFinLlenado = fechatmp
                        oEntidad.FechaIniVaciado = DateAdd(DateInterval.Day, 1, oEntidad.FechaFinLlenado)
                        oEntidad.FechaFinVaciado = DateAdd(DateInterval.Day, 1, oEntidad.FechaIniVaciado)
                        oEntidad.Kilos = kilos
                        oEntidad.Tolva = tolvatmp
                        oEntidad.Numero = ultimoid + 1
                        oEntidad.Calidad = calidad
                        oEntidad.Variedad = variedad

                        oEntidad.Campaña = Me._campagna.ToString()
                        oEntidad.Idalmazara = Me._idalmazara.ToString
                        entidades.AddpartidasaceitunaRow(oEntidad)

                        kilos = 0
                        ultimoid += 1
                        primero = True
                    End If

                Next

            Next i

            Me.Update(entidades)

            otickets.Update(tickets)

        End If



    End Sub




    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="vTolva"></param>
    ''' <param name="vCalidad"></param>
    ''' <remarks></remarks>
    Public Sub ActualizaPorDiasCalidad(ByVal vTolva As UShort, ByVal vCalidad As Integer)
        Dim strSql As New System.Text.StringBuilder
        Dim lector As DbDataReader
        Dim oEntidad As oleosigDB.partidasaceitunaRow
        Dim entidades As New oleosigDB.partidasaceitunaDataTable
        Dim tickets As oleosigDB.lotesaceitunaDataTable
        Dim ticket As oleosigDB.lotesaceitunaRow
        Dim ultimoid As Integer
        Dim fechas As New ArrayList
        Dim i As Integer
        Dim primero As Boolean = True
        Dim kilos As Integer = 0
        Dim fechatmp As Date
        Dim tolvatmp As Integer
        Dim cmd As DbCommand
        Dim otickets As New LoteAceitunaTableAdapter(Me._campagna, Me._idalmazara)

        ultimoid = Me.Ultima()

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion



        strSql.Append("select distinct(date(lotfecha)) as fecha from lotesaceituna where lotTolva='" & vTolva.ToString & "'")
        strSql.Append(" and campagna='" & Me._campagna.ToString() & "'")
        strSql.Append(" and idalmazara='" & Me._idalmazara.ToString & "'")
        strSql.Append(" and importado='f'")
        strSql.Append(" order by date(lotfecha)")

        cmd.CommandText = strSql.ToString
        If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
            Me._conexion.Open()
        End If
        lector = cmd.ExecuteReader(CommandBehavior.CloseConnection)


        strSql.Length = 0

        If lector.HasRows Then

            Do While lector.Read()
                fechas.Add(lector.GetDateTime(0))
            Loop
        End If

        lector.Close()

        If fechas.Count > 0 Then
            For i = 0 To fechas.Count - 1

                tickets = otickets.GetDatabyTolvaCalidadFecha(vTolva, vCalidad, fechas(i))

                strSql.Length = 0

                For Each ticket In tickets

                    ticket.Importado = True


                    fechatmp = ticket.Fecha
                    tolvatmp = ticket.Tolva

                    If primero Then

                        oEntidad = entidades.NewpartidasaceitunaRow

                        oEntidad.Abierta = True
                        oEntidad.FechaIniLlenado = fechatmp
                        kilos = ticket.Kilos
                        primero = False

                    Else
                        kilos += ticket.Kilos
                    End If

                    If kilos >= 10000 Then

                        oEntidad.Abierta = False
                        oEntidad.FechaFinLlenado = fechatmp
                        oEntidad.FechaIniVaciado = DateAdd(DateInterval.Day, 1, oEntidad.FechaFinLlenado)
                        oEntidad.FechaFinVaciado = DateAdd(DateInterval.Day, 1, oEntidad.FechaIniVaciado)
                        oEntidad.Kilos = kilos
                        oEntidad.Tolva = tolvatmp
                        oEntidad.Campaña = ticket.Campaña
                        oEntidad.Idalmazara = ticket.Idalmazara

                        oEntidad.Numero = ultimoid + 1
                        oEntidad.Calidad = vCalidad

                        entidades.AddpartidasaceitunaRow(oEntidad)

                        ultimoid = ultimoid + 1
                        primero = True

                    End If
                Next

                If oEntidad.Abierta = True Then
                    oEntidad.Abierta = False
                    oEntidad.FechaFinLlenado = fechatmp
                    oEntidad.FechaIniVaciado = DateAdd(DateInterval.Day, 1, oEntidad.FechaFinLlenado)
                    oEntidad.FechaFinVaciado = DateAdd(DateInterval.Day, 1, oEntidad.FechaIniVaciado)
                    oEntidad.Kilos = kilos
                    oEntidad.Tolva = tolvatmp

                    oEntidad.Numero = ultimoid + 1
                    oEntidad.Calidad = vCalidad

                    oEntidad.Campaña = Me._campagna.ToString()
                    oEntidad.Idalmazara = Me._idalmazara.ToString
                    entidades.AddpartidasaceitunaRow(oEntidad)

                    kilos = 0
                    ultimoid += 1
                    primero = True
                End If



                lector.Close()

            Next i
            Me.Update(entidades)

            otickets.Update(tickets)
        End If



    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getLastId() As Integer
        Dim cmd As DbCommand
        Dim id As Object
        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion

        cmd.CommandText = "select max(id) from partidasaceituna where campagna='" & Me._campagna.ToString & "'" & _
            " and idalmazara='" & Me._idalmazara.ToString & "'"
        If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
            Me._conexion.Open()
        End If

        id = cmd.ExecuteScalar()
        Me._conexion.Close()

        If IsDBNull(id) Then
            Return 0
        Else
            Return CInt(id)

        End If


    End Function



    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="vTolva"></param>
    ''' <param name="actualizar"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Ultima(ByVal vTolva As UShort, ByVal actualizar As Boolean) As Integer
        Dim strSql As New System.Text.StringBuilder
        Dim resultado As Object
        Dim numpartida As Integer
        Dim cmd As DbCommand



        Try
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion

            strSql.Append("select max(parNumero) from partidasaceituna")
            strSql.Append(" where campagna='" & Me._campagna.ToString & "'")
            strSql.Append(" and idalmazara='" & Me._idalmazara.ToString & "'")
            strSql.Append(" and parTolva = '" & vTolva.ToString & "'")

            If actualizar = True Then
                strSql.Append(" and parLostLote > 0")
            End If


            cmd.CommandText = strSql.ToString
            If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
                Me._conexion.Open()
            End If

            resultado = cmd.ExecuteScalar
            Me._conexion.Close()


            If Not IsDBNull(resultado) Then

                numpartida = CType(resultado, Integer)
            Else
                numpartida = 0
            End If


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        Return numpartida
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Ultima() As Integer
        Dim cmd As DbCommand
        Dim numpartida As Integer
        Dim resultado As Object

        Try
            cmd = Me.cdatos.CreateCommand
            cmd.Connection = Me._conexion

            cmd.CommandText = "select max(parNumero) from partidasaceituna where campagna='" & Me._campagna.ToString & "'" & _
                " and idalmazara='" & Me._idalmazara.ToString & "'"
            If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
                Me._conexion.Open()
            End If

            resultado = cmd.ExecuteScalar

            Me._conexion.Close()

            If Not IsDBNull(resultado) Then

                numpartida = CType(resultado, Integer)
            Else
                numpartida = 0
            End If


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        Return numpartida
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="vTolva"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getLastIdbyFecha(ByVal vTolva As UShort) As ULong
        Dim cmd As DbCommand
        Dim result As Object
        Dim valordevuelto As ULong

        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion

        cmd.CommandText = "select id from partidasaceituna where campagna ='" & Me._campagna.ToString() & _
            "' and idalmazara='" & Me._idalmazara.ToString & _
            "' and parTolva = '" & vTolva.ToString() & _
            "' and parFechaInicio = (select max(parFechaInicio) from partidasaceituna where parTolva = '" & vTolva & "'" & _
            " and campagna='" & Me._campagna.ToString & "' and idalmazara='" & Me._idalmazara.ToString & "')"

        If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
            Me._conexion.Open()
        End If
        result = cmd.ExecuteScalar

        Me._conexion.Close()

        If IsDBNull(result) Then
            valordevuelto = 0
        Else
            valordevuelto = CType(result, ULong)
        End If

        Return valordevuelto

    End Function


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="numpartida"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getByNumPartida(ByVal numpartida As UShort) As oleosigDB.partidasaceitunaRow
        Dim cmd As DbCommand
        Dim oEntidad As oleosigDB.partidasaceitunaRow
        Dim tabla As New oleosigDB.partidasaceitunaDataTable

        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion

        cmd.CommandText = "select * from partidasaceituna where parnumero ='" & numpartida.ToString & _
            "' and campagna='" & Me._campagna.ToString & "'" & _
            " and idalmazara='" & Me._idalmazara.ToString & "'"


        Me._adpt.SelectCommand = cmd
        Me._adpt.Fill(tabla)

        If tabla.Rows.Count > 0 Then
            oEntidad = tabla.Rows(0)
        Else
            oEntidad = tabla.NewpartidasaceitunaRow
        End If


        Return oEntidad
    End Function



    Public Sub Insert(ByVal idalmazara As Integer, ByVal parNumero As Integer, ByVal parFechaInicio As Date, _
        ByVal parFechaFin As Date, ByVal parTolva As Integer, _
        ByVal parKilos As Integer, _
        ByVal parLostLote As Integer, _
        ByVal parFechaIniVaciado As Date, _
        ByVal parFechaFinVaciado As Date, _
        ByVal campagna As Integer, _
        ByVal abierta As Boolean, _
        ByVal calidad As Integer, _
        ByVal variedad As Integer)

        Dim strSql As New System.Text.StringBuilder


        strSql.Append("insert into partidasaceituna (")
        strSql.Append("idalmazara,")
        strSql.Append("parNumero,")
        strSql.Append("parFechaInicio,")
        strSql.Append("parFechaFin, ")
        strSql.Append("parTolva,")
        strSql.Append("parKilos,")
        strSql.Append("parLostLote,")
        strSql.Append("parFechaIniVaciado,")
        strSql.Append("parFechaFinVaciado,")
        strSql.Append("campagna,")
        strSql.Append("abierta,")
        strSql.Append("calidad,")
        strSql.Append("variedad) ")
        strSql.Append("values(")
        strSql.Append("'" & idalmazara.ToString & "',")
        strSql.Append("'" & parNumero.ToString & "',")
        strSql.Append("'" & parFechaInicio.ToString("yyyy-MM-dd HH:mm:ss") & "',")
        strSql.Append("'" & parFechaFin.ToString("yyyy-MM-dd HH:mm:ss") & "',")
        strSql.Append("'" & parTolva.ToString & "',")
        strSql.Append("'" & parKilos.ToString & "',")
        strSql.Append("'" & parLostLote.ToString & "',")
        strSql.Append("'" & parFechaIniVaciado.ToString("yyyy-MM-dd HH:mm:ss") & "',")
        strSql.Append("'" & parFechaFinVaciado.ToString("yyyy-MM-dd HH:mm:ss") & "',")
        strSql.Append("'" & campagna.ToString & "',")

        If abierta Then
            strSql.Append("'1',")
        Else
            strSql.Append("'0',")
        End If
        strSql.Append("'" & calidad.ToString & "',")
        strSql.Append("'" & variedad.ToString & "')")

        cdatos.Haz(strSql.ToString())

    End Sub
    Public Overridable Overloads Function Update(ByVal tabla As oleosigDB.partidasaceitunaDataTable) As Integer
        Return Me._adpt.Update(tabla)
    End Function

    Public Overridable Overloads Function Update(ByVal dt As oleosigDB) As Integer
        Dim rslt As Integer
        Try
            rslt = Me._adpt.Update(dt, "partidasaceituna")

        Catch ex As Exception
        Finally

        End Try
        Return rslt
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="fechaini"></param>
    ''' <param name="fechafin"></param>
    ''' <param name="sTolva"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByFechasTolva(ByVal fechaini As DateTime, ByVal fechafin As DateTime, ByVal sTolva As UShort) As oleosigDB.partidasaceitunaDataTable
        Dim cmd As DbCommand

        Dim entidades As New oleosigDB.partidasaceitunaDataTable


        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion

        cmd.CommandText = "select * from partidasaceituna where parFechaInicio >='" & fechaini.ToString("yyyy-MM-dd HH:mm:ss") & _
            "' And parFechaFin <= '" & fechafin.ToString("yyyy-MM-dd HH:mm:ss") & _
            "' and campagna ='" & Me._campagna.ToString & "' and parTolva ='" & sTolva.ToString & "'" & _
            " and idalmazara='" & Me._idalmazara.ToString & "' order by parNumero"

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
    Public Function GetDataByFechas(ByVal fechaini As DateTime, ByVal fechafin As DateTime) As oleosigDB.partidasaceitunaDataTable
        Dim cmd As DbCommand
        Dim entidades As New oleosigDB.partidasaceitunaDataTable

        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion

        cmd.CommandText = "select * from partidasaceituna where parFechaInicio >='" & fechaini.ToString("yyyy-MM-dd HH:mm:ss") & _
            "' and parFechaFin <='" & fechafin.ToString("yyyy-MM-dd HH:mm:ss") & _
            "' and campagna ='" & Me._campagna.ToString & "'" & _
            " and idalmazara='" & Me._idalmazara.ToString & "' order by parNumero"
        Me._adpt.SelectCommand = cmd

        Me._adpt.Fill(entidades)

        Return entidades
    End Function



    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Fecha"></param>
    ''' <param name="sTolva"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByDia(ByVal Fecha As DateTime, ByVal sTolva As UShort) As oleosigDB.partidasaceitunaDataTable
        Dim cmd As DbCommand
        Dim entidades As New oleosigDB.partidasaceitunaDataTable


        cmd = Me.cdatos.CreateCommand

        cmd.Connection = Me._conexion
        cmd.CommandText = "select * from partidasaceituna where date(parFechaInicio) <= '" & Fecha.ToString("yyyy-MM-dd") & _
            "' and date(parFechaFinVaciado) >= '" & Fecha.ToString("yyyy-MM-dd") & _
            "' and campagna ='" & Me._campagna.ToString & _
            "' and idalmazara='" & Me._idalmazara.ToString & _
            "' and parTolva = '" & sTolva.ToString & "' order by parTolva"

        cmd.CommandType = CommandType.Text

        Me._adpt.SelectCommand = cmd

        Me._adpt.Fill(entidades)

        Return entidades
    End Function




    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sTolva"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataByTolva(ByVal sTolva As UShort) As oleosigDB.partidasaceitunaDataTable
        Dim cmd As DbCommand
        Dim entidades As New oleosigDB.partidasaceitunaDataTable

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = "select * from partidasaceituna where campagna ='" & Me._campagna.ToString & _
            "' and parTolva ='" & sTolva.ToString & "'" & _
            " and idalmazara='" & Me._idalmazara.ToString & "' order by parNumero"

        Try

            Me._adpt.SelectCommand = cmd
            Me._adpt.Fill(entidades)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return entidades

    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getAllId() As ArrayList
        Dim cmd As DbCommand
        Dim lector As DbDataReader
        Dim resultado As New ArrayList

        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion

        cmd.CommandText = "select id from partidasaceituna where campagna ='" & Me._campagna.ToString & "'" & _
            " and idalmazara='" & Me._idalmazara.ToString & "' order by id"
        If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
            Me._conexion.Open()
        End If

        lector = cmd.ExecuteReader(CommandBehavior.CloseConnection)



        Do While lector.Read()
            If Not lector.IsDBNull(0) Then
                resultado.Add(CType(lector.GetInt32(0), UInteger))
            End If
        Loop

        lector.Close()

        Return resultado

    End Function


    Public Sub Borrar(ByVal id As UShort)
        Dim strSql As String



        strSql = "delete from partidasaceituna where id ='" & id.ToString & "'"

        cdatos.Haz(strSql)


    End Sub

    Private Sub inicia_datos()
        Dim cmd As DbCommand
        Dim strsql As New System.Text.StringBuilder
        Dim param As DbParameter
        Dim tablamaper As DataTableMapping

        tablamaper = New DataTableMapping("Table", "partidasaceituna")
        tablamaper.ColumnMappings.Add("id", "Id")
        tablamaper.ColumnMappings.Add("idalmazara", "Idalmazara")
        tablamaper.ColumnMappings.Add("parnumero", "Numero")
        tablamaper.ColumnMappings.Add("parfechainicio", "FechaIniLlenado")
        tablamaper.ColumnMappings.Add("parfechafin", "FechaFinLlenado")
        tablamaper.ColumnMappings.Add("partolva", "Tolva")
        tablamaper.ColumnMappings.Add("parkilos", "Kilos")
        'tablamaper.ColumnMappings.Add("parLostLote")
        tablamaper.ColumnMappings.Add("parfechainivaciado", "FechaIniVaciado")
        tablamaper.ColumnMappings.Add("parfechafinvaciado", "FechaFinVaciado")
        tablamaper.ColumnMappings.Add("campagna", "Campaña")
        tablamaper.ColumnMappings.Add("abierta", "Abierta")
        tablamaper.ColumnMappings.Add("calidad", "Calidad")
        tablamaper.ColumnMappings.Add("variedad", "Variedad")
        tablamaper.ColumnMappings.Add("importada", "Importada")

        Me._adpt.TableMappings.Add(tablamaper)


        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = "delete from partidasaceituna where id=:id"

        Me._adpt.DeleteCommand = cmd

        strsql.Length = 0

        strsql.Append("insert into partidasaceituna (")
        strsql.Append("idalmazara,")
        strsql.Append("parNumero,")
        strsql.Append("parFechaInicio,")
        strsql.Append("parFechaFin, ")
        strsql.Append("parTolva,")
        strsql.Append("parKilos,")
        strsql.Append("parLostLote,")
        strsql.Append("parFechaIniVaciado,")
        strsql.Append("parFechaFinVaciado,")
        strsql.Append("campagna,")
        strsql.Append("abierta,")
        strsql.Append("calidad,")
        strsql.Append("variedad,")
        strsql.Append("importada) ")
        strsql.Append("values(")
        strsql.Append(":idalmazara,")
        strsql.Append(":parnumero,")
        strsql.Append(":parfechainicio,")
        strsql.Append(":parfechafin,")
        strsql.Append(":partolva,")
        strsql.Append(":parkilos,")
        strsql.Append(":parlostlote,")
        strsql.Append(":parfechainivaciado,")
        strsql.Append(":parfechafinvaciado,")
        strsql.Append(":campagna,")
        strsql.Append(":abierta,")
        strsql.Append(":calidad,")
        strsql.Append(":variedad,")
        strsql.Append(":importada)")

        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.InsertCommand = cmd

        strsql.Length = 0

        strsql.Append("update partidasaceituna set")
        strsql.Append(" parkilos =:parkilos,")
        strsql.Append(" parLostLote =:parlostlote,")
        strsql.Append(" parFechaInicio =:parfechainicio,")
        strsql.Append(" parFechaFin =:parfechafin,")
        strsql.Append(" parFechaIniVaciado=:parfechainivaciado,")
        strsql.Append(" parFechaFinVaciado=:parfechafinvaciado,")
        strsql.Append(" calidad=:calidad,")
        strsql.Append(" abierta =:abierta,")
        strsql.Append(" variedad=:variedad,")
        strsql.Append(" importada=:importada")
        strsql.Append(" where id =:id")

        cmd = Me.cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString

        Me._adpt.UpdateCommand = cmd

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":id"
        param.SourceColumn = "id"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":idalmazara"
        param.SourceColumn = "idalmazara"
        param.DbType = DbType.Int32
        param.Value = Me._idalmazara

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)


        param = Me.cdatos.CreateParameter
        param.ParameterName = ":parnumero"
        param.SourceColumn = "parnumero"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":parfechainicio"
        param.SourceColumn = "parfechainicio"
        param.DbType = DbType.DateTime

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":parfechafin"
        param.SourceColumn = "parfechafin"
        param.DbType = DbType.DateTime

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":partolva"
        param.SourceColumn = "partolva"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":parkilos"
        param.SourceColumn = "parkilos"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":parlostlote"
        param.SourceColumn = "parlostlote"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":parfechainivaciado"
        param.SourceColumn = "parfechainivaciado"
        param.DbType = DbType.DateTime

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":parfechafinvaciado"
        param.SourceColumn = "parfechafinvaciado"
        param.DbType = DbType.DateTime

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":campagna"
        param.SourceColumn = "campagna"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":abierta"
        param.SourceColumn = "abierta"
        param.DbType = DbType.Boolean

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":calidad"
        param.SourceColumn = "calidad"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":variedad"
        param.SourceColumn = "variedad"
        param.DbType = DbType.Int32

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":importada"
        param.SourceColumn = "importada"
        param.DbType = DbType.Boolean

        Me._adpt.UpdateCommand.Parameters.Add(param)
        Me._adpt.InsertCommand.Parameters.Add(param)

    End Sub
    Private Sub inicia_comandos()
        Dim cmd As DbCommand
        Dim strsql As New Text.StringBuilder
        Dim param As DbParameter

        _comandos = New List(Of DbCommand)

        strsql.Append("select * from partidasaceituna where idalmazara=:idalmazara")
        strsql.Append(" and campagna=:campagna")

        cmd = cdatos.CreateCommand()
        cmd.Connection = Me._conexion
        cmd.CommandText = strsql.ToString


        param = Me.cdatos.CreateParameter
        param.ParameterName = ":campagna"
        param.SourceColumn = "campagna"
        param.DbType = DbType.Int32

        cmd.Parameters.Add(param)

        param = Me.cdatos.CreateParameter
        param.ParameterName = ":idalmazara"
        param.SourceColumn = "idalmazara"
        param.DbType = DbType.Int32

        cmd.Parameters.Add(param)

        _comandos.Add(cmd)

    End Sub

    Public Sub New(ByVal campagna As Byte, ByVal idalmazara As Integer)
        MyBase.New()

        Me._campagna = campagna
        Me._idalmazara = idalmazara
        Me._conexion = cdatos.GetConnection
        Me._adpt = cdatos.CreateDataAdapter

        inicia_comandos()
        inicia_datos()

    End Sub


    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub
End Class