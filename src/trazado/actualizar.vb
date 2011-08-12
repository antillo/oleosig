Option Strict Off
Option Explicit On

Imports System
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Globalization

Module actualizar
	
    Dim oParAceituna As parAceitunaTableAdapter 'objeto que representa una clase partida aceituna
    Dim oLotAceituna As LoteAceitunaTableAdapter 'objeto que representa una clase de lote de aceituna


    Const ForReading As Short = 1
    Const ForWriting As Short = 2
    Const ForAppending As Short = 8



    Sub importCosecheros(ByRef path As String)

        Dim archivo As System.IO.StreamReader
        Dim strLinea As String
        Dim strLinea1 As String
        Dim oCosechero As cosecheroTableAdapter
        Dim oProcedencias As procedenciasTableAdapter
        Dim procedencias As eProcedencias

        Dim cosechero As oleosigDB.cosecherosRow
        Dim posicion As Short
        Dim posicion1 As Short
        Dim posicion2 As Short
        Dim agricultores As Boolean
        Dim procAct As Boolean
        Dim oleosigdb1 As New oleosigDB()
        Dim idcosechero As String

        oCosechero = New cosecheroTableAdapter(Almazara.Id)
        oProcedencias = New procedenciasTableAdapter

        oCosechero.Fill(oleosigdb1.cosecheros)




        agricultores = False
        procAct = False


        If My.Computer.FileSystem.FileExists(path) Then

            archivo = My.Computer.FileSystem.OpenTextFileReader(path)

            Do

                strLinea = archivo.ReadLine()
                strLinea1 = Replace(strLinea, "'", Chr(96))

                If strLinea1 = "AGROS" Then
                    posicion = 0
                    agricultores = True
                    procAct = False

                    oCosechero.Limpiar()

                End If
                If strLinea1 = "DETATPPP" Then
                    posicion = 0
                    agricultores = False
                    procAct = True

                    oProcedencias.Limpiar()

                End If
                If strLinea1 = "CMATRICULAS" Then
                    posicion = 0
                    agricultores = False
                    procAct = False
                End If
                If agricultores And strLinea1 <> "AGROS" Then
                    idcosechero = ""
                    posicion = InStr(1, strLinea1, "#", CompareMethod.Text)

                    idcosechero = Mid(strLinea1, 1, posicion - 1)

                    posicion1 = posicion + 1

                    If (oCosechero.ExisteSocio(idcosechero)) Then

                        cosechero = oleosigdb1.cosecheros.First(Function(cos As oleosigDB.cosecherosRow) cos.Codigo = idcosechero)

                        cosechero.Codigo = idcosechero

                        posicion2 = InStr(posicion1, strLinea1, "#", CompareMethod.Text)

                        cosechero.Nombre = Mid(strLinea1, posicion1, posicion2 - posicion1)

                        posicion1 = posicion2 + 1
                        posicion2 = InStr(posicion1, strLinea1, "#", CompareMethod.Text)

                        cosechero.nif = Mid(strLinea1, posicion1, posicion2 - posicion1)

                        posicion1 = posicion2 + 1
                        posicion2 = InStr(posicion1, strLinea1, "#", CompareMethod.Text)

                        cosechero.Direccion = Mid(strLinea1, posicion1, posicion2 - posicion1)

                        posicion1 = posicion2 + 1
                        posicion2 = InStr(posicion1, strLinea1, "#", CompareMethod.Text)

                        cosechero.CP = Mid(strLinea1, posicion1, posicion2 - posicion1)

                        posicion1 = posicion2 + 1
                        posicion2 = InStr(posicion1, strLinea1, "#", CompareMethod.Text)

                        cosechero.poblacion = Mid(strLinea1, posicion1, posicion2 - posicion1)

                        posicion1 = posicion2 + 1
                        posicion2 = InStr(posicion1, strLinea1, "#", CompareMethod.Text)

                        cosechero.Provincia = Mid(strLinea1, posicion1, posicion2 - posicion1)
                        oleosigdb1.cosecheros.AcceptChanges()

                        oCosechero.Update(oleosigdb1.cosecheros)

                    Else

                        cosechero = oleosigdb1.cosecheros.NewcosecherosRow()

                        posicion2 = InStr(posicion1, strLinea1, "#", CompareMethod.Text)

                        cosechero.Codigo = idcosechero
                        cosechero.Nombre = Mid(strLinea1, posicion1, posicion2 - posicion1)

                        posicion1 = posicion2 + 1

                        posicion2 = InStr(posicion1, strLinea1, "#", CompareMethod.Text)

                        cosechero.nif = Mid(strLinea1, posicion1, posicion2 - posicion1)

                        posicion1 = posicion2 + 1
                        posicion2 = InStr(posicion1, strLinea1, "#", CompareMethod.Text)

                        cosechero.Direccion = Mid(strLinea1, posicion1, posicion2 - posicion1)

                        posicion1 = posicion2 + 1
                        posicion2 = InStr(posicion1, strLinea1, "#", CompareMethod.Text)

                        cosechero.CP = Mid(strLinea1, posicion1, posicion2 - posicion1)

                        posicion1 = posicion2 + 1
                        posicion2 = InStr(posicion1, strLinea1, "#", CompareMethod.Text)

                        cosechero.poblacion = Mid(strLinea1, posicion1, posicion2 - posicion1)

                        posicion1 = posicion2 + 1
                        posicion2 = InStr(posicion1, strLinea1, "#", CompareMethod.Text)

                        cosechero.Provincia = Mid(strLinea1, posicion1, posicion2 - posicion1)

                        oleosigdb1.cosecheros.AddcosecherosRow(cosechero)
                        oleosigdb1.cosecheros.AcceptChanges()

                        oCosechero.Update(oleosigdb1.cosecheros)

                    End If
                End If
                If procAct And strLinea1 <> "DETATPPP" Then
                    idcosechero = ""

                    procedencias = New eProcedencias

                    posicion = InStr(1, strLinea1, "#", CompareMethod.Text)

                    idcosechero = Mid(strLinea1, 1, posicion - 1)

                    posicion1 = posicion + 1

                    procedencias.cosechero = idcosechero

                    posicion2 = InStr(posicion1, strLinea1, "#", CompareMethod.Text)


                    procedencias.Termino = Mid(strLinea1, posicion1, posicion2 - posicion1)
                    posicion1 = posicion2 + 1
                    posicion2 = InStr(posicion1, strLinea1, "#", CompareMethod.Text)

                    procedencias.Poligono = Mid(strLinea1, posicion1, posicion2 - posicion1)
                    posicion1 = posicion2 + 1
                    posicion2 = InStr(posicion1, strLinea1, "#", CompareMethod.Text)

                    procedencias.Parcela = Mid(strLinea1, posicion1, posicion2 - posicion1)
                    procedencias.Paraje = ""
                    procedencias.Finca = ""

                    oProcedencias.Insertar(procedencias)

                End If

            Loop Until strLinea Is Nothing

        End If



    End Sub


    '   Function act_lot_jar(ByVal path As String) As CeLotAceituna
    ' Dim archivo As System.IO.StreamReader
    ' Dim strLine As String
    ' Dim ticket As eLotAceituna
    ' Dim tickets As New CeLotAceituna
    ' Dim fecha As String
    ' Dim fechauniversal As String
    ' Dim hora As String
    ' Dim fechahora As String
    ' Dim recoleccion As String
    ' Dim oLotAceituna As cLotAceituna
    ' Dim campos As String()

    '    Try

    '            If My.Computer.FileSystem.FileExists(path) Then


    '                archivo = My.Computer.FileSystem.OpenTextFileReader(path)
    '                oLotAceituna = New cLotAceituna(Almazara.CampañaAct.Clave, Almazara.Id)


    '                Do

    '                strLine = archivo.ReadLine
    '               If strLine.Length > 0 Then
    '                  campos = Split(strLine, "#")
    '
    '                   ticket = New eLotAceituna
    '
    ''ticket.Numero = campos(0) ' Trim(Str(CInt(Mid(strLine, 1, 6)))) 'nº ticket

    '                  ticket.Numero = campos(Almazara.ConfigsTicket(0).Campos_delimitado(0).Posicion)

    'ticket.Socio = campos(6) 'Trim(Str(CShort(Mid(strLine, 49, 6)))) ' cod cliente

    '                    ticket.Socio = campos(Almazara.ConfigsTicket(0).Campos_delimitado(1).Posicion)

    '                   fecha = campos(1) 'Mid(strLine, 8, 10) ' fecha

    '                    hora = campos(3) 'Mid(strLine, 28, 8)

    '                   fechauniversal = DateTime.Parse(fecha & " " & hora).ToString("yyyy-MM-dd HH:mm:ss")


    ' fechahora = fechauniversal & " " & hora
    '                    ticket.Fecha = CDate(fecha & " " & hora) ' fechauniversal

    '                   If Trim(campos(17)).Length > 0 Then
    '                      ticket.Kilos = CUShort(campos(17)) 'Trim(CStr(CShort(Mid(strLine, 245, 6))))
    '                 Else
    '                    ticket.Kilos = 0
    '               End If

    '                    ticket.Matricula = campos(19) 'Trim(Mid(strLine, 254, 10))
    '                   recoleccion = campos(21) 'UCase(Trim(Mid(strLine, 267, 8)))

    '                    Select Case recoleccion
    '                       Case "ARBOL"
    '                          ticket.Recoleccion = "0"
    '                     Case "SUELO"
    '                        ticket.Recoleccion = "1"
    '               End Select

    '                    ticket.Variedad = "0" 'Trim$(Str(CLng(Mid$(strLine, 64, 9))))

    '                   If Trim(campos(9)).Length > 0 Then
    '                      ticket.Termino = CInt(campos(9)) ' Trim(Str(CInt(Mid(strLine, 105, 5))))
    '                 Else
    '                    ticket.Termino = 0
    '               End If

    '                    If Trim(campos(5)).Length > 0 Then
    '                       ticket.Bascula = CInt(campos(5)) 'Trim(Str(CInt(Mid(strLine, 46, 2))))
    '                  Else
    '                     ticket.Bascula = 0
    '                End If

    '                    If Trim(campos(22)).Length > 0 Then
    '                       ticket.Tolva = CInt(campos(22)) 'Trim(Mid(strLine, 276, 6))
    '                  Else
    '                     ticket.Tolva = 0
    '                End If

    '                    If Trim(campos(11)).Length > 0 Then
    '                       ticket.Poligono = CInt(campos(11)) 'Trim(Str(CInt(Mid(strLine, 148, 6))))
    '                  Else
    '                     ticket.Poligono = 0
    '                End If
    '               If Trim(campos(12)).Length > 0 Then
    '                  ticket.Parcela = CInt(campos(12)) ' Trim(Str(CInt(Mid(strLine, 155, 6))))
    '             Else
    '                ticket.Parcela = 0
    '           End If

    '                    tickets.Add(ticket)

    '               End If

    '            Loop Until strLine Is Nothing


    '           archivo.Close()


    '        End If



    '   Catch ex As Exception


    '        MsgBox("Se ha producido un error en la importacion de archivos ")
    '   End Try


    '    Return tickets
    'End Function

    ''' <summary>
    ''' Actualiza los tickets de pesaje leyendo directamente de la base de datos de Comyser
    ''' </summary>
    ''' <param name="path">Path hasta el archivo de la base de datos *.mdb</param>
    ''' <returns>Devuelve una colección con todos los lotes de aceituna</returns>
    ''' <remarks></remarks>
    ' Function act_lot_comyser_db(ByVal path As String) As CeLotAceituna
    ' Dim tickets As CeLotAceituna
    'Dim fecha As Date
    'Dim hora As Date
    'Dim ticket As eLotAceituna
    'Dim ConexionAdo As OleDb.OleDbConnection
    'Dim dt As New DataSet
    'Dim adaptador As OleDb.OleDbDataAdapter
    'Dim tablaticket As DataTable
    'Dim strsql As String

    '   tickets = New CeLotAceituna


    '    Try
    '       ConexionAdo = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & ";Jet OLEDB:Database Password=01042000;")
    '      ConexionAdo.Open()

    '        strsql = "select tickets.*,parcela.codparcela,parcela.termino as termino,"
    '       strsql = strsql & "parcela.poligono as poligono,parcela.parcela as parcela,parcela.paraje as paraje "
    '      strsql = strsql & "from tickets LEFT JOIN parcela ON tickets.codparcela = parcela.codparcela ORDER BY tickets.numticket"


    '            adaptador = New OleDb.OleDbDataAdapter(strsql, ConexionAdo)

    '        adaptador.Fill(dt, "tickets")
    '
    '       tablaticket = dt.Tables("tickets")

    '        For Each fila As DataRow In tablaticket.Rows
    '           ticket = New eLotAceituna
    '
    '           fecha = fila("fecha")
    '          hora = fila("horasalida")

    '            ticket.Idalmazara = Almazara.Id
    '           ticket.Fecha = CDate(fecha.ToString("dd/MM/yyyy") & " " & hora.ToString("HH:mm:ss"))
    '          ticket.Numero = fila("numticket")
    '         ticket.Kilos = fila("kilosmedianeria")
    '         ticket.Bascula = fila("basculaentrada")
    '        ticket.Tolva = fila("marca")
    '       ticket.Variedad = fila("codvariedad")
    '       ticket.Socio = fila("codcliente")
    '      ticket.Recoleccion = fila("codcalidad")
    '         ticket.Parcela = fila("parcela")
    '         ticket.Termino = fila("termino")
    '         ticket.Poligono = fila("poligono")
    '         ticket.Paraje = fila("paraje")
    '         ticket.Matricula = fila("codmatricula")
    '         ticket.Campaña = Almazara.CampañaAct.clave



    '                tickets.Add(ticket)

    '        Next
    '   Catch ex As Exception
    '      MsgBox(ex.Message)
    ' End Try
    '   Return tickets
    'End Function

    '####################################################################
    '#
    '#
    '#  Descripcion :   Abre el archivo de las pesadas de comyser
    '#                  y los inserta en la tabla de lotes de aceituna
    '#
    '####################################################################

    '  Function act_lot_Comyser(ByVal path As String) As CeLotAceituna
    ' Dim archivo As System.IO.StreamReader
    ' Dim strLine As String
    ' Dim oLotAceituna As cLotAceituna
    ' Dim ticket As eLotAceituna
    ' Dim tickets As CeLotAceituna
    ' Dim fecha As String
    ' Dim fechauniversal As New System.Text.StringBuilder()
    ' Dim hora As String
    ' Dim fechahora As String

    '    oLotAceituna = New cLotAceituna(Almazara.CampañaAct.clave, Almazara.Id)
    '    tickets = New CeLotAceituna
    '    ticket = New eLotAceituna

    '        If My.Computer.FileSystem.FileExists(path) Then

    '        archivo = My.Computer.FileSystem.OpenTextFileReader(path)


    '       Try

    '            Do

    '               ticket = New eLotAceituna
    '              ticket.Idalmazara = Almazara.Id

    '                strLine = archivo.ReadLine
    '               If Len(strLine) > 0 Then
    '                  ticket.Numero = CUInt(strLine.Substring(Almazara.ConfigsTicket(0).Campos_fijo(0).Inicio, Almazara.ConfigsTicket(0).Campos_fijo(0).Longitud)) 'nº ticket
    '                 ticket.Socio = CUInt(strLine.Substring(Almazara.ConfigsTicket(0).Campos_fijo(1).Inicio, Almazara.ConfigsTicket(1).Campos_fijo(1).Longitud)) ' cod cliente
    '                fecha = strLine.Substring(Almazara.ConfigsTicket(0).Campos_fijo(2).Inicio, Almazara.ConfigsTicket(2).Campos_fijo(2).Longitud)
    '               hora = strLine.Substring(Almazara.ConfigsTicket(0).Campos_fijo(3).Inicio, Almazara.ConfigsTicket(0).Campos_fijo(3).Longitud)

    ' fecha

    '                    fechauniversal.Append(fecha.Substring(0, 4))
    '                   fechauniversal.Append("-")
    '                  fechauniversal.Append(fecha.Substring(4, 2))
    '                 fechauniversal.Append("-")
    '                fechauniversal.Append(fecha.Substring(6, 2))
    '               fechauniversal.Append(" ")
    '              fechauniversal.Append(hora.Substring(0, 2))
    '             fechauniversal.Append(":")
    '            fechauniversal.Append(hora.Substring(2, 2))
    '           fechauniversal.Append(":")
    '          fechauniversal.Append(hora.Substring(4, 2))



    '                    fechahora = fechauniversal.ToString
    '
    '                   fechauniversal.Length = 0
    '
    '                   ticket.Fecha = fechahora

    '                    ticket.Kilos = CUInt(strLine.Substring(Almazara.ConfigsTicket(0).Campos_fijo(4).Inicio, Almazara.ConfigsTicket(0).Campos_fijo(4).Longitud))
    '                   ticket.Matricula = strLine.Substring(Almazara.ConfigsTicket(0).Campos_fijo(5).Inicio, Almazara.ConfigsTicket(0).Campos_fijo(5).Longitud)
    '                  ticket.Recoleccion = CUShort(strLine.Substring(Almazara.ConfigsTicket(0).Campos_fijo(6).Inicio, Almazara.ConfigsTicket(0).Campos_fijo(6).Longitud))
    '                 ticket.Variedad = CUShort(strLine.Substring(Almazara.ConfigsTicket(0).Campos_fijo(7).Inicio, Almazara.ConfigsTicket(0).Campos_fijo(7).Longitud))
    '                ticket.Termino = CUInt(strLine.Substring(Almazara.ConfigsTicket(0).Campos_fijo(8).Inicio, Almazara.ConfigsTicket(0).Campos_fijo(8).Longitud))
    '               ticket.Bascula = CUShort(strLine.Substring(Almazara.ConfigsTicket(0).Campos_fijo(9).Inicio, Almazara.ConfigsTicket(0).Campos_fijo(9).Longitud))
    '              ticket.Tolva = CUShort(strLine.Substring(Almazara.ConfigsTicket(0).Campos_fijo(10).Inicio, Almazara.ConfigsTicket(0).Campos_fijo(10).Longitud))
    '             ticket.Poligono = CUInt(strLine.Substring(Almazara.ConfigsTicket(0).Campos_fijo(11).Inicio, Almazara.ConfigsTicket(0).Campos_fijo(11).Longitud))
    '           ticket.Parcela = CUInt(strLine.Substring(Almazara.ConfigsTicket(0).Campos_fijo(12).Inicio, Almazara.ConfigsTicket(0).Campos_fijo(12).Longitud))
    '            ticket.Campaña = Almazara.CampañaAct.clave
    '          tickets.Add(ticket)

    '                End If

    '           Loop Until strLine Is Nothing

    '            archivo.Close()

    '       Catch ex As Exception
    '          MessageBox.Show(ex.Message)
    '     End Try

    '    End If

    '   Return tickets
    ' End Function



    ''' <summary>
    ''' Creación de partidas de aceituna por dias
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub crea_partidas_dias()
        Dim recDB As New recoleccionTableAdapter(Almazara.Id)
        Dim tolvasDB As New tolvasTableAdapter(Almazara.Id)
        Dim resultado As MsgBoxResult
        Dim tolvas As oleosigDB.tolvasDataTable

        resultado = MsgBox("Está a punto de realizar una actualización" & vbCr _
                           & "de las partidas de aceituna de forma automatica," & vbCr _
                           & "Desea continuar", MsgBoxStyle.YesNo Or MsgBoxStyle.Information)

        If resultado = MsgBoxResult.Yes Then
            oParAceituna = New parAceitunaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)

            oLotAceituna = New LoteAceitunaTableAdapter(Almazara.CampañaAct.clave, Almazara.Id)

            oParAceituna.BorrarTodas()

            Dim calidades As oleosigDB.recoleccionDataTable = recDB.GetData()
            tolvas = tolvasDB.GetData()

            For Each tolva As oleosigDB.tolvasRow In tolvas.Rows

                For Each calidad As oleosigDB.recoleccionRow In calidades.Rows

                    oParAceituna.ActualizaPorDiasCalidad(tolva.Numero, calidad.codigo)

                Next

            Next
            MsgBox("Se ha finalizado la creación de partidas", MsgBoxStyle.Information)
        End If

    End Sub



    Public Sub importaLotes(ByRef path As Object)

        'Dim fs As Object
        'Dim archivo As Object
        'Dim strLine As String
        'Dim ticket As eLotAceituna
        'Dim fecha As String
        'Dim fechauniversal As String
        'Dim hora As String
        'Dim fechahora As String
        'On Error GoTo importerr

        'Set fs = CreateObject("Scripting.FileSystemObject")


        'If fs.FileExists(path) Then

        '   Set archivo = fs.OpenTextFile(path, ForReading, False)
        '   Set oLotAceituna = New cLotAceituna


        '    Do While archivo.AtEndOfStream <> True

        '        Set ticket = New eLotAceituna

        '       strLine = archivo.ReadLine

        '      ticket.Numero = Trim$(Str(CLng(Mid$(strLine, oConfig.LotCampos("lotNumero").Inicio, oConfig.LotCampos("lotNumero").Longitud)))) 'nº ticket

        '     ticket.socio = Trim$(Str(CInt(Mid$(strLine, oConfig.LotCampos.Obten("lotCodigoSocio").Inicio, oConfig.LotCampos.Obten("lotCodigoSocio").Longitud)))) ' cod cliente

        '    fecha = Mid$(strLine, oConfig.LotCampos.Obten("lotFecha").Inicio, oConfig.LotCampos.Obten("lotFecha").Longitud) ' fecha

        '   hora = Mid$(strLine, oConfig.LotCampos.Obten("lotHora").Inicio, oConfig.LotCampos.Obten("lotHora").Longitud)

        '  fechauniversal = Mid$(fecha, 1, 4) & "-" & Mid$(fecha, 5, 2) & "-" & Mid$(fecha, 7, 2) 'fecha

        ' fechahora = fechauniversal & " " & hora

        ' ticket.fecha = fechahora

        ' ticket.Kilos = Trim$(Str(CLng(Mid$(strLine, oConfig.LotCampos.Obten("lotFinalKg").Inicio, oConfig.LotCampos.Obten("lotFinalKg").Longitud))))

        ' ticket.matricula = Mid$(strLine, oConfig.LotCampos.Obten("lotMatricula").Inicio, oConfig.LotCampos.Obten("lotMatricula").Longitud)

        ' ticket.Recoleccion = Trim$(Str(CLng(Mid$(strLine, oConfig.LotCampos.Obten("lotRecoleccion").Inicio, oConfig.LotCampos.Obten("lotRecoleccion").Longitud))))

        '  ticket.variedad = Trim$(Str(CLng(Mid$(strLine, oConfig.LotCampos.Obten("lotCodigoVariedad").Inicio, oConfig.LotCampos.Obten("lotCodigoVariedad").Longitud))))

        '  ticket.Termino = Trim$(Str(CLng(Mid$(strLine, oConfig.LotCampos.Obten("lotCodigoTermino").Inicio, oConfig.LotCampos.Obten("lotCodigoTermino").Longitud))))

        '   ticket.bascula = Trim$(Str(CLng(Mid$(strLine, oConfig.LotCampos.Obten("lotBascula").Inicio, oConfig.LotCampos.Obten("lotBascula").Longitud))))

        '     ticket.Tolva = Trim$(Str(CLng(Mid$(strLine, oConfig.LotCampos.Obten("lotTolva").Inicio, oConfig.LotCampos.Obten("lotTolva").Longitud))))

        '    ticket.Poligono = Trim$(Str(CLng(Mid$(strLine, oConfig.LotCampos.Obten("lotPoligono").Inicio, oConfig.LotCampos.Obten("lotPoligono").Longitud))))

        '   ticket.Parcela = Trim$(Str(CLng(Mid$(strLine, oConfig.LotCampos.Obten("lotParcela").Inicio, oConfig.LotCampos.Obten("lotParcela").Longitud))))

        '  If Not oLotAceituna.existeId(ticket.Numero) Then

        '     oLotAceituna.Insertar ticket

        '  End If

        ' Set ticket = Nothing

        'Loop

        'archivo.Close
        'MsgBox "La actualización de datos se ha realizado con exito", vbInformation

        'fs.DeleteFile path, True

        'End If

        'Set archivo = Nothing
        'Set fs = Nothing
        'Set oLotAceituna = Nothing
        'On Error GoTo 0
        'Exit Sub
        'Unload frmslider
        'importerr:
        'MsgBox "Se ha producido un error en la importacion de archivos " & Err.Description & " " & ticket.fecha





    End Sub
End Module