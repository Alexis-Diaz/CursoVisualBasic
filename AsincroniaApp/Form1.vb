Imports System.Threading

Public Class Form1

    Private Sub btnSync_Click(sender As Object, e As EventArgs) Handles btnSync.Click
        Log("Before heavy sync work")
        Dim work = New HeavyWork()
        work.Do()
        Log("After heavy sync work")
    End Sub

    Private Async Sub btnAsync_Click(sender As Object, e As EventArgs) Handles btnAsync.Click
        Log("Before heavy async work")
        Dim work = New HeavyWork()
        Await Task.Run(Sub() work.Do())
        Log("After heavy async work")
    End Sub

    Private Async Sub btnAsyncWithValue_Click(sender As Object, e As EventArgs) Handles btnAsyncWithValue.Click
        Log("Before heavy async work with value")
        Dim work = New HeavyWork()
        Await Task.Run(Function() work.DoWithValue())
        Log("After heavy async work with value")
    End Sub

    Private Sub Log(msg As String)
        lbRegistro.Items.Add($"{Now:HH:mm:ss:fff} {msg}")
    End Sub

End Class

Public Class HeavyWork

    Public Sub [Do]()
        SimulateHeavyWork()
    End Sub

    Public Function DoWithValue() As Boolean
        SimulateHeavyWork()
        Return True
    End Function

    Private Sub SimulateHeavyWork()
        Log("Se inicia la tarea pesada")
        Thread.Sleep(3000)
        Log("Se finaliza la tarea pesada")
    End Sub

    Private Sub Log(msg As String)
        Debug.WriteLine($"{Now:HH:mm:ss:fff} {msg}")
    End Sub

End Class
