
Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If tbNom.Text = "" Or tbPrenom.Text = "" Or tbMail.Text = "" Or tbPasse.Text = "" Or cbJour.Text = "" Or cbMois.Text = "" Or tbAnnees.Text = "" Or cbAccepte.Checked = False Then
            MsgBox(" Vous devez remplire toute les cases. ")
            Exit Sub
        End If

        If tbPasse.Text <> tbCPasse.Text Then

            MsgBox(" Les mots de passes ne correspondent pas. ")

            Exit Sub
        End If
    End Sub
End Class
