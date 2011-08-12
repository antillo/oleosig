Option Strict Off
Option Explicit On

Imports System.Data.Common
Imports System.Text

Public Class ConfigDB


    Private _adpt As DbDataAdapter
    Private cdatos As New CBaseDatos
    Private _conexion As DbConnection
    Private _clearBeforeFill As Boolean
    Private _listacomandos As List(Of DbCommand)



    Public Overridable Overloads Function FillProvincias(ByVal tabla As oleosigDB.provinciaDataTable) As Integer
        If _clearBeforeFill Then
            tabla.Clear()
        End If
        Me._adpt.SelectCommand = _listacomandos(0)
        Return Me._adpt.Fill(tabla)
    End Function

    Public Overridable Overloads Function FillTipo_pesaje(ByVal tabla As oleosigDB.tipo_pesajeDataTable) As Integer
        If _clearBeforeFill Then
            tabla.Clear()
        End If
        Me._adpt.SelectCommand = _listacomandos(1)
        Return Me._adpt.Fill(tabla)
    End Function
    

    Private Sub inicia_comandos()
        Dim cmd As DbCommand
        Dim strsql As String

        _listacomandos = New List(Of DbCommand)

        strsql = "select * from provincia"

        cmd = Me.cdatos.CreateCommand()
        cmd.Connection = _conexion
        cmd.CommandText = strsql
        cmd.CommandType = CommandType.Text

        _listacomandos.Add(cmd)

        cmd = Me.cdatos.CreateCommand
        cmd.Connection = _conexion
        cmd.CommandText = "select * from tipo_pesaje"
        cmd.CommandType = CommandType.Text

        _listacomandos.Add(cmd)


    End Sub
    Private Sub inicia_datos()

        Dim mapa As DataTableMapping

        mapa = New DataTableMapping("provincia", "provincia")
        mapa.ColumnMappings.Add("id_provincia", "Id")
        mapa.ColumnMappings.Add("descripcion", "Nombre")

        Me._adpt.TableMappings.Add(mapa)

        mapa = New DataTableMapping("tipo_pesaje", "tipo_pesaje")

        mapa.ColumnMappings.Add("id", "Id")
        mapa.ColumnMappings.Add("codigo", "Codigo")
        mapa.ColumnMappings.Add("descripcion", "Nombre")

        Me._adpt.TableMappings.Add(mapa)


    End Sub

    Public Sub New()
        MyBase.New()

        Me._conexion = cdatos.GetConnection
        Me._adpt = Me.cdatos.CreateDataAdapter()
        _clearBeforeFill = True

        inicia_datos()
        inicia_comandos()



    End Sub

End Class