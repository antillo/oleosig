Option Strict Off
Option Explicit On
Imports System.Data.Common

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class usuariosTableAdapter


    Private _usuario As eUsuario
    Private cdatos As New CBaseDatos
    Private _conexion As DbConnection
    Private _adpt As DbDataAdapter

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Id As Integer
        Get
            Return Me._usuario.Id
        End Get
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Almazara As Integer
        Get
            Return Me._usuario.Almazara
        End Get
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Usuario As String
        Get
            Return Me._usuario.Nombre
        End Get
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="usuario"></param>
    ''' <param name="clave"></param>
    ''' <remarks></remarks>
    Public Sub Insertar(ByVal usuario As String, ByVal clave As String)


        cDatos.Haz("insert into usuarios (usuario,clave) values('" & usuario & "','" & clave & "')")


    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Id"></param>
    ''' <remarks></remarks>
    Public Sub Borra(ByVal Id As String)



        cDatos.Haz("delete from usuarios where id ='" & Id & "'")



    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="usuario"></param>
    ''' <param name="clave"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Login(ByVal usuario As String, ByVal clave As String) As Boolean
        Dim cmd As DbCommand
        Dim resultado As Long

        Dim valordevuelto As Boolean
        Try

            cmd = cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = "select count(*) from usuarios where usuario='" & usuario & "' and clave='" & clave & "'"
            If Me._conexion.State = ConnectionState.Closed Or Me._conexion.State = ConnectionState.Broken Then
                Me._conexion.Open()
            End If
            resultado = CType(cmd.ExecuteScalar(), Long)


            If resultado > 0 Then

                Dim usuarios As New DataTable
                Me._adpt.SelectCommand = cdatos.CreateCommand
                Me._adpt.SelectCommand.Connection = Me._conexion
                Me._adpt.SelectCommand.CommandText = "select * from usuarios where usuario='" & usuario & "' and clave='" & clave & "'"
                Me._adpt.Fill(usuarios)

                Me._usuario = New eUsuario
                Me._usuario.Id = usuarios(0)(0)
                Me._usuario.Almazara = usuarios(0)(1)
                Me._usuario.Nombre = usuarios(0)(2)

                valordevuelto = True
            Else
                valordevuelto = False
            End If



        Catch ex As Exception
            MsgBox(ex.Message)


        End Try
        Return valordevuelto


    End Function

    Public Function HayUsuarios() As Boolean
        Dim strsql As String
        Dim numusuarios As Long
        Dim resultado As Boolean = False
        Dim cmd As DbCommand

        strsql = "select count(*) from usuarios"
        Try
            cmd = Me.cdatos.CreateCommand
            cmd.Connection = Me._conexion
            cmd.CommandText = strsql
            If Me._conexion.State = ConnectionState.Broken Or Me._conexion.State = ConnectionState.Closed Then
                _conexion.Open()
            End If
            numusuarios = CType(cmd.ExecuteScalar, Long)
            _conexion.Close()

            If numusuarios > 0 Then
                resultado = True
            End If
        Catch ex As Exception
        End Try
        Return resultado
    End Function


    Public Sub New()
        MyBase.New()

        Me._conexion = cdatos.GetConnection
        Me._adpt = cdatos.CreateDataAdapter

    End Sub



    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub



    Protected Class eUsuario
        Private _Nombre As String 'copia local
        Private _idalmazara As Integer
        Private _Id As UInteger 'copia local

        Private _usuario As eUsuario

        Public Property Almazara As Integer
            Get
                Return Me._idalmazara
            End Get
            Set(ByVal value As Integer)
                Me._idalmazara = value
            End Set
        End Property


        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Id() As UInteger
            Get
                Return Me._Id
            End Get
            Set(ByVal Value As UInteger)

                Me._Id = Value


            End Set
        End Property

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Nombre() As String
            Get
                Return Me._Nombre

            End Get
            Set(ByVal Value As String)
                Me._Nombre = Value
            End Set
        End Property


        Protected Overrides Sub Finalize()

            MyBase.Finalize()
        End Sub

        Public Sub New()
            MyBase.New()

        End Sub
    End Class
End Class