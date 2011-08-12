Option Strict Off
Option Explicit On

Imports System.Xml.Linq
Imports System.Data
Imports System.Data.Common
Imports System.Configuration

#Const DEPURACION = False

'Public Class cDatos
Public MustInherit Class cConfDatos



    Private factoria As DbProviderFactory
    Private connectionstring As String
    Private adaptador As DbDataAdapter


    Public Sub New()


    End Sub
   
    Public Function GetConnection() As DbConnection
        Dim newConexion As DbConnection = Nothing
        Try
            Try
                factoria = DbProviderFactories.GetFactory("Npgsql")
                newConexion = factoria.CreateConnection

#If DEPURACION Then

        me.ConnectionString = ConfigurationManager.ConnectionStrings("pgconexionlocal").ConnectionString
#Else
                Me.connectionstring = ConfigurationManager.ConnectionStrings("pgconexion").ConnectionString

#End If
                newConexion.ConnectionString = Me.connectionstring

            Catch
                Throw
            End Try

        Catch ex As Exception
            If newConexion IsNot Nothing Then
                newConexion.Close()
            End If
            Throw
        End Try
            Return newConexion
    End Function

    Public Function CreateCommand() As DbCommand
        Return Me.factoria.CreateCommand
    End Function

    Public Function CreateCommand(ByVal queryString As String, ByVal connection As DbConnection) As DbCommand
        Try
            Dim comando As DbCommand = factoria.CreateCommand
            comando.CommandText = queryString
            comando.Connection = connection
            Return comando

        Catch ex As Exception
            Throw
        End Try

    End Function
    Public Function CreateDataAdapter() As DbDataAdapter
        Return factoria.CreateDataAdapter
    End Function

    
    Public Function CreateDataAdapter(ByVal queryString As String, ByVal connection As DbConnection) As DbDataAdapter
        Try
            Dim comando As DbCommand = factoria.CreateCommand
            comando.CommandText = queryString
            comando.Connection = connection

            Dim adaptador As DbDataAdapter = Me.CreateDataAdapter
            adaptador.SelectCommand = comando
            Return adaptador

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CreateParameter() As DbParameter
        Return factoria.CreateParameter
    End Function
    Public Function CreateCommandBuilder() As DbCommandBuilder
        Return factoria.CreateCommandBuilder
    End Function
End Class