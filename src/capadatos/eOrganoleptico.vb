Option Strict Off
Option Explicit On
Public Class eOrganoleptico



    Private mvarNombre As String 'copia local
    Private _codigo As UInteger

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Nombre() As String
        Get
            
            Return mvarNombre
        End Get
        Set(ByVal Value As String)
            
            mvarNombre = Value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Codigo As UInteger
        Get
            Return Me._codigo
        End Get
        Set(ByVal value As UInteger)
            Me._codigo = value
        End Set
    End Property
End Class