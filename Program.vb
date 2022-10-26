Imports System

Module Program
    Sub Main(args As String())
        Dim objSample As New Sample()
        objSample.StringProperty = "Vb is Like english!!"
        objSample.PrintSomeValue()
        Dim value As String = objSample.GetSomeValue()
        Console.WriteLine("value=" + value)

        Dim objRectangle As New Rectangle()
        Dim drawn As String = objRectangle.Draw()
        objRectangle.Display()
        Console.WriteLine(drawn)


        Divide(10, 5)
        Multiply(10, 5)
        Subtract(500, 200)
        'Create a variable
        Add()
    End Sub

    Private Sub Divide(v1 As Integer, v2 As Integer)
        Console.WriteLine(v1 / v2)
    End Sub

    Private Sub Multiply(v1 As Integer, v2 As Integer)
        Console.WriteLine(v1 * v2)
    End Sub

    Private Sub Subtract(v1 As Integer, v2 As Integer)
        Console.WriteLine(v1 - v2)
    End Sub

    Private Sub Add()
        Dim n1 As Integer = 200
        Dim n2 As Integer = 200
        Dim Result As Integer = n1 + n2

        Console.WriteLine(Result)
    End Sub
End Module
