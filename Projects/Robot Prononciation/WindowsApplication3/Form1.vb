﻿Public Class Form1
    Dim ep = CreateObject("sapi.spvoice")
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ep.speak(TextBox1.Text)
    End Sub
End Class
