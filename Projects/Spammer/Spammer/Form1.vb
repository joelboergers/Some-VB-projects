﻿Public Class Form1

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        TextBox1.Clear()
        TextBox1.Focus()

    End Sub

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll
        If TrackBar1.Value = 0 Then
            Label1.Text = "1"
            Vittesse.Interval = 1
            TrackBar1.Value = 1
        Else
            Label1.Text = TrackBar1.Value
            Vittesse.Interval = TrackBar1.Value / 2
            spam.Interval = TrackBar1.Value
        End If

    End Sub

    Private Sub Vittesse_Tick(sender As System.Object, e As System.EventArgs) Handles Vittesse.Tick
        If Label2.Visible = True Then
            Label2.Visible = False
        Else
            Label2.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        spam.Start()

    End Sub

    Private Sub spam_Tick(sender As System.Object, e As System.EventArgs) Handles spam.Tick

        SendKeys.Send(TextBox1.Text)
        SendKeys.Send("{ENTER}")

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        spam.Stop()

    End Sub
End Class
