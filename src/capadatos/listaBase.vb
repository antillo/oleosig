Imports System.ComponentModel
Imports System.Reflection

<Serializable()>
Public Class listaBase(Of T)
    Inherits BindingList(Of T)

    Private selectedIndices As ArrayList
    Private returnIndice As Integer

    Protected Overrides ReadOnly Property SupportsSearchingCore As Boolean
        Get
            Return True
        End Get
    End Property

    Protected Overrides Function FindCore(ByVal prop As System.ComponentModel.PropertyDescriptor, ByVal key As Object) As Integer
        Dim propInfo As PropertyInfo = GetType(T).GetProperty(prop.Name)
        Dim found As Integer = -1
        Dim item As T

        selectedIndices = New ArrayList()
        If prop Is Nothing Then Return -1


        For Each item In Items

            Dim valor As String = Convert.ToString(prop.GetValue(item))
            If Convert.ToString(key = valor) Then
                found = IndexOf(item)
            End If

        Next

        Return found
    End Function
    Public Function Find(ByVal propiedad As String, ByVal key As Object) As T
        Dim propiedades As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
        Dim prop As PropertyDescriptor = propiedades.Find(propiedad, True)

        If IsNothing(prop) Then
            Return Nothing
        Else
            returnIndice = FindCore(prop, key)
            If returnIndice > -1 Then

                Return Items(returnIndice)

            End If

        End If

    End Function
    Protected Overrides Sub OnListChanged(ByVal e As System.ComponentModel.ListChangedEventArgs)
        MyBase.OnListChanged(e)
    End Sub
End Class
