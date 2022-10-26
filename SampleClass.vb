Public Class SampleClass
    Private strProperty As String
    Public Property NewProperty() As String
        Get
            Return strProperty
        End Get
        Set(ByVal value As String)
            strProperty = value
        End Set
    End Property

    Public Function GetSomeValue() As String
        Return "A new VB function"
    End Function

    Public Sub PrintSomeValue()
        Console.WriteLine("Printing values from sample")
    End Sub


End Class
