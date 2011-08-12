Option Strict Off
Option Explicit On

Imports System.Data.Common
Imports System.Text

Public Class analisisTableAdapter

    Private mvarOrganoleptico As System.Collections.Hashtable

    Private _campagna As Byte
    Private _idalmazara As Integer
    Private cdatos As New CBaseDatos
    Private _conexion As DbConnection
    Private _adpt As DbDataAdapter


    Public ReadOnly Property Organoleptico() As System.Collections.Hashtable
        Get

            If mvarOrganoleptico Is Nothing Then
                mvarOrganoleptico = New System.Collections.Hashtable
            End If

            Organoleptico = mvarOrganoleptico
        End Get
    End Property

    Private Function Rellena_entidad(ByRef lector As DbDataReader) As eAnalisis
        Dim entidad As eAnalisis



        entidad = New eAnalisis

        If lector.HasRows Then
            lector.Read()
            If IsDBNull(lector("id")) Then
                entidad.Id = 0
            Else
                entidad.Id = lector("id")
            End If
            If IsDBNull(lector("idalmazara")) Then
                entidad.Idalmazara = 0
            Else
                entidad = lector("idalmazara")
            End If
            If IsDBNull(lector("idlote")) Then
                entidad.Lote = 0
            Else
                entidad.Lote = lector("idlote")
            End If

            If IsDBNull(lector("numtanque")) Then
                entidad.numTanque = 0
            Else
                entidad.numTanque = lector("numtanque")
            End If

            If IsDBNull(lector("acidez")) Then
                entidad.Acidez = 0
            Else
                entidad.Acidez = lector("acidez")
            End If

            If IsDBNull(lector("peroxidos")) Then
                entidad.Peroxidos = 0
            Else
                entidad.Peroxidos = lector("peroxidos")
            End If

            If IsDBNull(lector("k270")) Then
                entidad.K270 = 0
            Else
                entidad.K270 = lector("k270")
            End If

            If IsDBNull(lector("k232")) Then
                entidad.K232 = 0
            Else
                entidad.K232 = lector("k232")
            End If

            If IsDBNull(lector("ceras")) Then
                entidad.Ceras = 0
            Else
                entidad.Ceras = lector("ceras")
            End If

            If IsDBNull(lector("esteroles_tot")) Then
                entidad.Esteroles_tot = 0
            Else
                entidad.Esteroles_tot = lector("esteroles_tot")
            End If

            If IsDBNull(lector("colesteroles")) Then
                entidad.Colesteroles = 0
            Else
                entidad.Colesteroles = lector("colesteroles")
            End If

            If IsDBNull(lector("brasicasterol")) Then
                entidad.Brasicasterol = 0
            Else
                entidad.Brasicasterol = lector("brasicasterol")
            End If

            If IsDBNull(lector("campesterol")) Then
                entidad.Campesterol = 0
            Else
                entidad.Campesterol = lector("campesterol")
            End If

            If IsDBNull(lector("estigmasterol")) Then
                entidad.Estigmasterol = 0
            Else
                entidad.Estigmasterol = lector("estigmasterol")
            End If

            If IsDBNull(lector("beta_sitosterol")) Then
                entidad.Beta_sitosterol = 0
            Else
                entidad.Beta_sitosterol = lector("beta_sitosterol")
            End If

            If IsDBNull(lector("d_7_estigmasterol")) Then
                entidad.D_7_estigmasterol = 0
            Else
                entidad.D_7_estigmasterol = lector("d_7_estigmasterol")
            End If

            If IsDBNull(lector("eritrodiol")) Then
                entidad.Eritrodiol = 0
            Else
                entidad.Eritrodiol = lector("eritrodiol")
            End If

            If IsDBNull(lector("trilinoleinas")) Then
                entidad.Trilinoleinas = 0
            Else
                entidad.Trilinoleinas = lector("trilinoleinas")
            End If

            If IsDBNull(lector("organoleptico")) Then
                entidad.Organoleptico = 0
            Else
                entidad.Organoleptico = lector("organoleptico")
            End If

            If IsDBNull(lector("alcohol_alifatico")) Then
                entidad.Alcohol_alifatico = 0
            Else
                entidad.Alcohol_alifatico = lector("alcohol_alifatico")
            End If

            If IsDBNull(lector("fecha")) Then

            Else
                entidad.Fecha = lector("fecha")
            End If

            If IsDBNull(lector("campagna")) Then
                entidad.Campaña = 0
            Else
                entidad.Campaña = lector("campagna")
            End If

        End If
        lector.Close()

        Return entidad

    End Function

    Private Function Rellena_entidades(ByRef lector As DbDataReader) As CeAnalisis
        Dim entidad As eAnalisis
        Dim entidades As CeAnalisis

        entidades = New CeAnalisis
        If lector.HasRows Then
            Do While lector.Read
                entidad = New eAnalisis

                If IsDBNull(lector("id")) Then
                    entidad.Id = 0
                Else
                    entidad.Id = lector("id")
                End If
                If IsDBNull(lector("idalmazara")) Then
                    entidad.Idalmazara = 0
                Else
                    entidad.Idalmazara = lector("idalmazara")
                End If
                If IsDBNull(lector("idlote")) Then
                    entidad.Lote = 0
                Else
                    entidad.Lote = lector("idlote")
                End If

                If IsDBNull(lector("numtanque")) Then
                    entidad.numTanque = 0
                Else
                    entidad.numTanque = lector("numtanque")
                End If

                If IsDBNull(lector("acidez")) Then
                    entidad.Acidez = 0
                Else
                    entidad.Acidez = lector("acidez")
                End If

                If IsDBNull(lector("peroxidos")) Then
                    entidad.Peroxidos = 0
                Else
                    entidad.Peroxidos = lector("peroxidos")
                End If

                If IsDBNull(lector("k270")) Then
                    entidad.K270 = 0
                Else
                    entidad.K270 = lector("k270")
                End If

                If IsDBNull(lector("k232")) Then
                    entidad.K232 = 0
                Else
                    entidad.K232 = lector("k232")
                End If

                If IsDBNull(lector("ceras")) Then
                    entidad.Ceras = 0
                Else
                    entidad.Ceras = lector("ceras")
                End If

                If IsDBNull(lector("esteroles_tot")) Then
                    entidad.Esteroles_tot = 0
                Else
                    entidad.Esteroles_tot = lector("esteroles_tot")
                End If

                If IsDBNull(lector("colesteroles")) Then
                    entidad.Colesteroles = 0
                Else
                    entidad.Colesteroles = lector("colesteroles")
                End If

                If IsDBNull(lector("brasicasterol")) Then
                    entidad.Brasicasterol = 0
                Else
                    entidad.Brasicasterol = lector("brasicasterol")
                End If

                If IsDBNull(lector("campesterol")) Then
                    entidad.Campesterol = 0
                Else
                    entidad.Campesterol = lector("campesterol")
                End If

                If IsDBNull(lector("estigmasterol")) Then
                    entidad.Estigmasterol = 0
                Else
                    entidad.Estigmasterol = lector("estigmasterol")
                End If

                If IsDBNull(lector("beta_sitosterol")) Then
                    entidad.Beta_sitosterol = 0
                Else
                    entidad.Beta_sitosterol = lector("beta_sitosterol")
                End If

                If IsDBNull(lector("d_7_estigmasterol")) Then
                    entidad.D_7_estigmasterol = 0
                Else
                    entidad.D_7_estigmasterol = lector("d_7_estigmasterol")
                End If

                If IsDBNull(lector("eritrodiol")) Then
                    entidad.Eritrodiol = 0
                Else
                    entidad.Eritrodiol = lector("eritrodiol")
                End If

                If IsDBNull(lector("trilinoleinas")) Then
                    entidad.Trilinoleinas = 0
                Else
                    entidad.Trilinoleinas = lector("trilinoleinas")
                End If

                If IsDBNull(lector("organoleptico")) Then
                    entidad.Organoleptico = 0
                Else
                    entidad.Organoleptico = lector("organoleptico")
                End If

                If IsDBNull(lector("alcohol_alifatico")) Then
                    entidad.Alcohol_alifatico = 0
                Else
                    entidad.Alcohol_alifatico = lector("alcohol_alifatico")
                End If

                If IsDBNull(lector("fecha")) Then

                Else
                    entidad.Fecha = lector("fecha")
                End If

                If IsDBNull(lector("campagna")) Then
                    entidad.Campaña = 0
                Else
                    entidad.Campaña = lector("campagna")
                End If

                entidades.Add(entidad)
            Loop

        End If
        lector.Close()

        Return entidades
    End Function
    Private Sub rellenaOrganoleptico()
        Dim strSql As String
        Dim lector As DbDataReader



        strSql = "select * from organoleptico where idalmazara='" & Me._idalmazara.ToString & "' order by id"
        Try
            Dim cmd As DbCommand
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strSql.ToString
            If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
                Me._conexion.Open()
            End If
            lector = cmd.ExecuteReader(CommandBehavior.CloseConnection)



            If mvarOrganoleptico Is Nothing Then
                mvarOrganoleptico = New System.Collections.Hashtable
            End If

            Do While lector.Read()

                mvarOrganoleptico.Add(lector(0), lector(1))

            Loop
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Insertar(ByVal entidad As eAnalisis)
        Dim strSql As New Stringbuilder

        Try

            strSql.Append("insert into analisis (")
            strSql.Append("idalmazara,")
            strSql.Append("idlote,")
            strSql.Append("numtanque,")
            strSql.Append("acidez,")
            strSql.Append("peroxidos,")
            strSql.Append("k270,")
            strSql.Append("k232,")
            strSql.Append("ceras,")
            strSql.Append("esteroles_tot,")
            strSql.Append("colesteroles,")
            strSql.Append("brasicasterol,")
            strSql.Append("campesterol,")
            strSql.Append("estigmasterol,")
            strSql.Append("beta_sitosterol,")
            strSql.Append("d_7_estigmasterol,")
            strSql.Append("eritrodiol,")
            strSql.Append("trilinoleinas,")
            strSql.Append("organoleptico,")
            strSql.Append("alcohol_alifatico,")
            strSql.Append("fecha,")
            strSql.Append("campagna) values (")
            strSql.Append("'" & entidad.Idalmazara.ToString & "',")
            strSql.Append("'" & entidad.Lote.ToString & "',")
            strSql.Append("'" & entidad.numTanque.ToString & "',")
            strSql.Append("'" & entidad.Acidez.ToString & "',")
            strSql.Append("'" & entidad.Peroxidos.ToString & "',")
            strSql.Append("'" & entidad.K270.ToString & "',")
            strSql.Append("'" & entidad.K232.ToString & "',")
            strSql.Append("'" & entidad.Ceras.ToString & "',")
            strSql.Append("'" & entidad.Esteroles_tot.ToString & "',")
            strSql.Append("'" & entidad.Colesteroles.ToString & "',")
            strSql.Append("'" & entidad.Brasicasterol.ToString & "',")
            strSql.Append("'" & entidad.Campesterol.ToString & "',")
            strSql.Append("'" & entidad.Estigmasterol.ToString & "',")
            strSql.Append("'" & entidad.Beta_sitosterol.ToString & "',")
            strSql.Append("'" & entidad.D_7_estigmasterol.ToString & "',")
            strSql.Append("'" & entidad.Eritrodiol.ToString & "',")
            strSql.Append("'" & entidad.Trilinoleinas.ToString & "',")
            strSql.Append("'" & entidad.Organoleptico.ToString & "',")
            strSql.Append("'" & entidad.Alcohol_alifatico.ToString & "',")
            strSql.Append("'" & entidad.Fecha.ToString("yyyy-MM-dd") & "',")
            strSql.Append("'" & entidad.Campaña.ToString & "')")


            cDatos.Haz(strSql.ToString())


        Catch e As Exception


        End Try


    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="entidad"></param>
    ''' <remarks></remarks>
    Public Sub editar(ByVal entidad As eAnalisis)
        Dim strSql As New StringBuilder



        strSql.Append("update analisis set ")
        strSql.Append("idlote ='" & entidad.Lote.ToString & "',")
        strSql.Append("numtanque ='" & entidad.numTanque.ToString & "',")
        strSql.Append("acidez ='" & entidad.Acidez.ToString & "',")
        strSql.Append("peroxidos ='" & entidad.Peroxidos.ToString & "',")
        strSql.Append("k270 ='" & entidad.K270.ToString & "',")
        strSql.Append("k232 ='" & entidad.K232.ToString & "',")
        strSql.Append("ceras ='" & entidad.Ceras.ToString & "',")
        strSql.Append("esteroles_tot ='" & entidad.Esteroles_tot.ToString & "',")
        strSql.Append("colesteroles ='" & entidad.Colesteroles.ToString & "',")
        strSql.Append("brasicasterol ='" & entidad.Brasicasterol.ToString & "',")
        strSql.Append("campesterol ='" & entidad.Campesterol.ToString & "',")
        strSql.Append("estigmasterol ='" & entidad.Estigmasterol.ToString & "',")
        strSql.Append("beta_sitosterol ='" & entidad.Beta_sitosterol.ToString & "',")
        strSql.Append("d_7_estigmasterol ='" & entidad.D_7_estigmasterol.ToString & "',")
        strSql.Append("eritrodiol ='" & entidad.Eritrodiol.ToString & "',")
        strSql.Append("trilinoleinas ='" & entidad.Trilinoleinas.ToString & "',")
        strSql.Append("organoleptico ='" & entidad.Organoleptico.ToString & "',")
        strSql.Append("alcohol_alifatico ='" & entidad.Alcohol_alifatico.ToString & "',")
        strSql.Append("fecha ='" & entidad.Fecha.ToString("yyyy-mm-dd") & "',")
        strSql.Append("campagna ='" & entidad.Campaña.ToString & "'")
        strSql.Append(" where id= '" & entidad.Id.ToString & "'")
        Try
            cDatos.Haz(strSql.ToString())
        Catch ex As Exception
        End Try


    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getAll() As CeAnalisis
        Dim strSql As String
        Dim lector As DbDataReader
        Dim analisis As CeAnalisis
        analisis = New CeAnalisis

        Try

            strSql = "select * from analisis where campagna='" & Me._campagna.ToString & "' and idalmazara='" & Me._idalmazara.ToString & "' order by id"
            Dim cmd As DbCommand
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strSql.ToString
            If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
                Me._conexion.Open()
            End If
            lector = cmd.ExecuteReader(CommandBehavior.CloseConnection)


            analisis = Rellena_entidades(lector)


        Catch ex As Exception

            MsgBox(ex.Message)
            'Call RaiseError(MyUnhandledError, "cAnalisis:getAll Metodo")
        End Try

        Return analisis

    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="vData"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getByLote(ByVal vData As UShort) As eAnalisis
        Dim strSql As String
        Dim lector As DbDataReader
        Dim entidad As eAnalisis

        entidad = New eAnalisis

        Try

            strSql = "select * from analisis where idlote='" & vData.ToString & _
                "' and campagna='" & Me._campagna.ToString & "' and idalmazara='" & Me._idalmazara.ToString & "' order by id"
            Dim cmd As DbCommand
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strSql.ToString
            If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
                Me._conexion.Open()
            End If
            lector = cmd.ExecuteReader(CommandBehavior.CloseConnection)


            entidad = Rellena_entidad(lector)


        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
        Return entidad

    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="vData"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getById(ByVal vData As UShort) As eAnalisis
        Dim strSql As String
        Dim lector As DbDataReader
        Dim entidad As New eAnalisis

        Try

            strSql = "select * from analisis where id='" & vData.ToString & "' and campagna='" & Me._campagna.ToString & "'"
            Dim cmd As DbCommand
            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strSql.ToString
            If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
                Me._conexion.Open()
            End If
            lector = cmd.ExecuteReader(CommandBehavior.CloseConnection)


            entidad = Rellena_entidad(lector)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        Return entidad

    End Function


    Public Sub New(ByVal campagna As Byte, ByVal idalmazara As Integer)
        MyBase.New()
        Me._conexion = cdatos.GetConnection
        Me._adpt = cdatos.CreateDataAdapter

        Me._idalmazara = idalmazara
        Me._campagna = campagna
        rellenaOrganoleptico()

    End Sub
End Class