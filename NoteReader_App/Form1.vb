Imports System.IO.File
Public Class Form1
    Function TextFile()
        Dim text As String = ""
        If Exists("D:\text.txt") Then
            text = ReadAllText("D:\text.txt")
        End If
        Return text
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim count As Integer = 0
        For Each word As String In Split(TextFile(), " ")
            count += 1
        Next
        MsgBox(count.ToString + " Words")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox(TextFile())
    End Sub
End Class
