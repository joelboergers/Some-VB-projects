﻿Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        AxWindowsMediaPlayer1.URL = TextBox1.Text
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        AxWindowsMediaPlayer1.URL = "http://icecast.funradio.fr/fun-1-44-128"
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.URL = "http://dradio_mp3_dlf_s.akacast.akamaistream.net/7/251/142684/v1/gnl.akacast.akamaistream.net/dradio_mp3_dlf_s"
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        AxWindowsMediaPlayer1.URL = "http://cdn.nrjaudio.fm/audio1/fr/30001/aac_64.mp3"
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        AxWindowsMediaPlayer1.URL = "http://streaming.radio.funradio.fr/fun-1-48-192"
    End Sub
End Class
