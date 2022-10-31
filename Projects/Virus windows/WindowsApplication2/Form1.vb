Public Class Form1
    Dim seconde = 10
    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Dim fenetre As New Form1
            fenetre.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim fenetre As New Form1
        fenetre.Show()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If seconde = 0 Then
            Dim fenetre As New Form1
            fenetre.Show()
            seconde = 10
        End If

        Label1.Text = "Ouverture d'une 2éme fenetre dans " & seconde & " secondes."
        seconde = seconde - 1
    End Sub
End Class
