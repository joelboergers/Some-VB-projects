Imports System.Net.Mail

Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        GroupBox1.Enabled = False
        GroupBox2.Enabled = True
        Button2.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Dim mail As New MailMessage
        Dim SMTP As New SmtpClient("smtp.aol.com")

        mail.From = New MailAddress(TextBox1.Text)
        mail.To.Add(TextBox1.Text)
        mail.Subject = TextBox4.Text
        mail.Body = TextBox6.Text()

        SMTP.Port = "587"
        SMTP.Credentials = New System.Net.NetworkCredential(TextBox1.Text, TextBox2.Text)
        SMTP.EnableSsl = True

        SMTP.Send(mail)

    End Sub
End Class
