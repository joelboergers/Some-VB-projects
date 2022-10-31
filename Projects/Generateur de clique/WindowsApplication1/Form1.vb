Public Class Form1
    Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4

    Dim Touche
    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Me.TopMost = CheckBox1.Checked
    End Sub

    Private Sub TrackBar2_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar2.Scroll
        Me.Opacity = TrackBar2.Value / 1000
    End Sub

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll
        ChangeTextLabel1()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TrackBar1.Value -= 1
        ChangeTextLabel1()
    End Sub
    Sub ChangeTextLabel1()
        Label1.Text = " Un clique tout les " & TrackBar1.Value & " Milisecondes "
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TrackBar1.Value += 1
        ChangeTextLabel1()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Touche = ComboBox1.Text
        ComboBox1.Enabled = False
        Label3.Text = "Appuyer pour tester ..."
        Label3.ForeColor = Color.Blue
        Test.Start()
        Button3.Enabled = False

    End Sub

    Private Sub Test_Tick(sender As System.Object, e As System.EventArgs) Handles Test.Tick
        Select Case Touche
            Case "CTRL"
                If My.Computer.Keyboard.CtrlKeyDown Then
                Else
                    Exit Sub
                End If
            Case "ALT"
                If My.Computer.Keyboard.AltKeyDown Then
                Else
                    Exit Sub
                End If
            Case "SHIFT"
                If My.Computer.Keyboard.ShiftKeyDown Then
                Else
                    Exit Sub
                End If
            Case "NUM LOCK"
                If My.Computer.Keyboard.NumLock Then
                Else
                    Exit Sub
                End If
            Case "Caps LOCK"
                If My.Computer.Keyboard.CapsLock Then
                Else
                    Exit Sub
                End If
            Case Else
                Exit Sub
        End Select

        Label3.Text = "Reussie!"
        Label3.ForeColor = Color.LimeGreen
        ComboBox1.Enabled = True
        Button3.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Generateur.Interval = TrackBar1.Value
        Generateur.Start()
        Button3.Visible = False
        Button4.Visible = True
        ProgressBar1.Visible = True


        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False

    End Sub

    Private Sub Generateur_Tick(sender As System.Object, e As System.EventArgs) Handles Generateur.Tick
         Select Touche
            Case "CTRL"
                If My.Computer.Keyboard.CtrlKeyDown Then
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0) 'Enfonce le bouton de la souris
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0) ' le relève
                End If
            Case "ALT"
                If My.Computer.Keyboard.AltKeyDown Then
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0) 'Enfonce le bouton de la souris
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0) ' le relève
                End If
            Case "SHIFT"
                If My.Computer.Keyboard.ShiftKeyDown Then
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0) 'Enfonce le bouton de la souris
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0) ' le relève
                End If
            Case "NUM LOCK"
                If My.Computer.Keyboard.NumLock Then
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0) 'Enfonce le bouton de la souris
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0) ' le relève

                End If
            Case "Caps LOCK"
                If My.Computer.Keyboard.CapsLock Then
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0) 'Enfonce le bouton de la souris
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0) ' le relève
                End If
            Case Else
                Exit Sub
        End Select
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Generateur.Stop()
        Button3.Visible = True
        Button4.Visible = False
        ProgressBar1.Visible = False

        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        GroupBox3.Enabled = True
    End Sub
End Class
