<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbNom = New System.Windows.Forms.TextBox()
        Me.tbPrenom = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbMail = New System.Windows.Forms.TextBox()
        Me.tbPasse = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbCPasse = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbJour = New System.Windows.Forms.ComboBox()
        Me.cbMois = New System.Windows.Forms.ComboBox()
        Me.tbAnnees = New System.Windows.Forms.TextBox()
        Me.cbAccepte = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inscription"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-103, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(687, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "---------------------------------------------------------------------------------" & _
    "--------------------------------------------------------------------------------" & _
    "---------"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nom : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(258, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Prenom :"
        '
        'tbNom
        '
        Me.tbNom.Location = New System.Drawing.Point(115, 97)
        Me.tbNom.Name = "tbNom"
        Me.tbNom.Size = New System.Drawing.Size(125, 20)
        Me.tbNom.TabIndex = 0
        '
        'tbPrenom
        '
        Me.tbPrenom.Location = New System.Drawing.Point(313, 97)
        Me.tbPrenom.Name = "tbPrenom"
        Me.tbPrenom.Size = New System.Drawing.Size(144, 20)
        Me.tbPrenom.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Adresse mail : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Mot de passe : "
        '
        'tbMail
        '
        Me.tbMail.Location = New System.Drawing.Point(115, 126)
        Me.tbMail.Name = "tbMail"
        Me.tbMail.Size = New System.Drawing.Size(342, 20)
        Me.tbMail.TabIndex = 3
        '
        'tbPasse
        '
        Me.tbPasse.Location = New System.Drawing.Point(115, 152)
        Me.tbPasse.Name = "tbPasse"
        Me.tbPasse.Size = New System.Drawing.Size(342, 20)
        Me.tbPasse.TabIndex = 2
        Me.tbPasse.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Comfirmer : "
        '
        'tbCPasse
        '
        Me.tbCPasse.Location = New System.Drawing.Point(115, 181)
        Me.tbCPasse.Name = "tbCPasse"
        Me.tbCPasse.Size = New System.Drawing.Size(342, 20)
        Me.tbCPasse.TabIndex = 4
        Me.tbCPasse.UseSystemPasswordChar = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(53, 199)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 26)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Date de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "naissance: "
        '
        'cbJour
        '
        Me.cbJour.FormattingEnabled = True
        Me.cbJour.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cbJour.Location = New System.Drawing.Point(115, 204)
        Me.cbJour.Name = "cbJour"
        Me.cbJour.Size = New System.Drawing.Size(77, 21)
        Me.cbJour.TabIndex = 5
        '
        'cbMois
        '
        Me.cbMois.FormattingEnabled = True
        Me.cbMois.Items.AddRange(New Object() {"Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juni", "Juillet", "Aout", "Septembre", "Novembre", "Decembre"})
        Me.cbMois.Location = New System.Drawing.Point(198, 204)
        Me.cbMois.Name = "cbMois"
        Me.cbMois.Size = New System.Drawing.Size(166, 21)
        Me.cbMois.TabIndex = 6
        '
        'tbAnnees
        '
        Me.tbAnnees.Location = New System.Drawing.Point(370, 204)
        Me.tbAnnees.MaxLength = 4
        Me.tbAnnees.Name = "tbAnnees"
        Me.tbAnnees.Size = New System.Drawing.Size(87, 20)
        Me.tbAnnees.TabIndex = 7
        '
        'cbAccepte
        '
        Me.cbAccepte.AutoSize = True
        Me.cbAccepte.Location = New System.Drawing.Point(141, 240)
        Me.cbAccepte.Name = "cbAccepte"
        Me.cbAccepte.Size = New System.Drawing.Size(193, 17)
        Me.cbAccepte.TabIndex = 8
        Me.cbAccepte.Text = "J'accepte les condition d'utilisations"
        Me.cbAccepte.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 263)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(454, 41)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "S'inscrire"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 316)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbAccepte)
        Me.Controls.Add(Me.tbAnnees)
        Me.Controls.Add(Me.cbMois)
        Me.Controls.Add(Me.cbJour)
        Me.Controls.Add(Me.tbPrenom)
        Me.Controls.Add(Me.tbPasse)
        Me.Controls.Add(Me.tbCPasse)
        Me.Controls.Add(Me.tbMail)
        Me.Controls.Add(Me.tbNom)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulaire d'inscription"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbNom As System.Windows.Forms.TextBox
    Friend WithEvents tbPrenom As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbMail As System.Windows.Forms.TextBox
    Friend WithEvents tbPasse As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbCPasse As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbJour As System.Windows.Forms.ComboBox
    Friend WithEvents cbMois As System.Windows.Forms.ComboBox
    Friend WithEvents tbAnnees As System.Windows.Forms.TextBox
    Friend WithEvents cbAccepte As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
