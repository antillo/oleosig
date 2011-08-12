Option Strict Off
Option Explicit On
Imports System.Data.Common
Public Class procedenciasTableAdapter



    '_________________________________________________________________________________
    '|
    '|
    '|
    '|
    '|
    '|________________________________________________________________________________
    Private cdatos As New CBaseDatos
    Private _conexion As DbConnection

    Public Sub delBySocio(ByVal Id As UShort)
        Dim strSql As String

        strSql = "delete from procedencias where proCodigoSocio ='" & Id.ToString & "'"

        cDatos.Haz(strSql)

    End Sub

    'borra todos los datos de la tabla de procedencias
    Public Sub Limpiar()
        Dim strSql As String

        strSql = "truncate table procedencias"
        cDatos.Haz(strSql)


    End Sub


    Public Function getAllbySocio(ByVal cosechero As UShort) As CeProcedencias
        Dim strSql As String
        Dim lector As System.Data.Common.DbDataReader
        Dim entidad As eProcedencias
        Dim entidades As CeProcedencias

        strSql = "select * from procedencias where proCodigoSocio='" & cosechero.ToString & "'"
        Dim cmd As DbCommand
        cmd = cdatos.CreateCommand
        cmd.Connection = Me._conexion
        cmd.CommandText = strSql.ToString
        If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
            Me._conexion.Open()
        End If
        lector = cmd.ExecuteReader(CommandBehavior.CloseConnection)


        entidades = New CeProcedencias

        Do While lector.Read()
            entidad = New eProcedencias

            If IsDBNull(lector("proCodigoSocio")) Then
                entidad.Cosechero = ""
            Else
                entidad.Cosechero = lector("proCodigoSocio")
            End If

            If IsDBNull(lector("proCodigoTermino")) Then
                entidad.Termino = ""
            Else
                entidad.Termino = lector("proCodigoTermino")
            End If

            If IsDBNull(lector("proPoligono")) Then
                entidad.Poligono = ""
            Else
                entidad.Poligono = lector("proPoligono")
            End If

            If IsDBNull(lector("proParcela")) Then
                entidad.Parcela = ""
            Else
                entidad.Parcela = lector("proParcela")
            End If

            If IsDBNull(lector("proNombreFinca")) Then
                entidad.Finca = ""
            Else
                entidad.Finca = lector("proNombreFinca")
            End If

            If IsDBNull(lector("proNombreParaje")) Then
                entidad.Paraje = ""
            Else
                entidad.Paraje = lector("proNombreParaje")
            End If

            entidades.Add(entidad)


        Loop

        lector.Close()

        Return entidades
    End Function

    '#################################################################
    '#
    '#  Descripcion :   Inserta una procedencia en la base de datos
    '#
    '#################################################################
    Public Sub Insertar(ByVal procedencia As eProcedencias)
        Dim strSql As New System.Text.StringBuilder

        strSql.Append("insert into procedencias (proCodigoSocio,proCodigoTermino,proPoligono,proParcela,proNombreFinca,proNombreParaje) values(")
        strSql.Append("'" & procedencia.Cosechero & "',")
        strSql.Append("'" & procedencia.Termino & "',")
        strSql.Append("'" & procedencia.Poligono & "',")
        strSql.Append("'" & procedencia.Parcela & "',")
        strSql.Append("'" & procedencia.Finca & "',")
        strSql.Append("'" & procedencia.Paraje & "')")

        cDatos.Haz(strSql.ToString())

    End Sub


    Public Sub New()
        MyBase.New()
        _conexion = cdatos.GetConnection
    End Sub

    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub
End Class