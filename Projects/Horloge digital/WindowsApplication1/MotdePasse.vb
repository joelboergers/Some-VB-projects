﻿Public Class MotdePasse

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Verification()
    End Sub

    Sub Verification()

        If TextBox1.Text = "Horloge Digital" Then
            Form1.Show()
            Me.Close()
        Else
            MsgBox("Mot de passe incorrect", MsgBoxStyle.Critical + vbOKOnly, "Erreur")
            TextBox1.Clear()
            TextBox1.Focus()
        End If

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Verification()
        End If
    End Sub
End Class