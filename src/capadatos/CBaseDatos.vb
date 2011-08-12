Imports System.Data.Common

Public Class CBaseDatos
    Inherits cConfDatos


    Public Sub New()
        MyBase.New()

    End Sub
   
    Friend Sub Haz(ByVal strsql As String)
        Dim cmd As DbCommand

        Using conexion As DbConnection = MyBase.GetConnection
            cmd = MyBase.CreateCommand
            cmd.Connection = conexion
            cmd.CommandText = strsql
            Try
                conexion.Open()
                cmd.ExecuteNonQuery()
                conexion.Close()
            Catch ex As Exception
                Throw
            End Try
        End Using

    End Sub
   
End Class
