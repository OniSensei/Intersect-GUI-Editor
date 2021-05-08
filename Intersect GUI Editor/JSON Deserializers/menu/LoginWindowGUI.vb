Imports System.IO
Imports Newtonsoft.Json

Module LoginWindowGUI
    Public Class LoginWindow
        Public Property Bounds As String
        Public Property Padding As String
        Public Property AlignmentEdgeDistances As String
        Public Property AlignmentTransform As String
        Public Property Margin As String
        Public Property RenderColor As String
        Public Property Alignments As String
        Public Property DrawBackground As Boolean
        Public Property MinimumSize As String
        Public Property MaximumSize As String
        Public Property Disabled As Boolean
        Public Property Hidden As Boolean
        Public Property RestrictToParent As Boolean
        Public Property MouseInputEnabled As Boolean
        Public Property HideToolTip As Boolean
        Public Property ToolTipBackground As String
        Public Property ToolTipFont As String
        Public Property ToolTipTextColor As String
        Public Property Texture As String
        Public Property HoverSound As String
        Public Property LeftMouseClickSound As String
        Public Property RightMouseClickSound As String
        Public Property Children As Children
    End Class

    Public Class Children
        Public Property LoginHeader As IntersectLabel
        Public Property UsernamePanel As UsernamePanel
        Public Property PasswordPanel As PasswordPanel
        Public Property SavePassCheckbox As SavePassCheckbox
        Public Property ForgotPasswordButton As IntersectButton
        Public Property LoginButton As IntersectButton
        Public Property BackButton As IntersectButton

    End Class

    Public Class UsernamePanel
        Public Property Bounds As String
        Public Property Padding As String
        Public Property AlignmentEdgeDistances As String
        Public Property AlignmentTransform As String
        Public Property Margin As String
        Public Property RenderColor As String
        Public Property Alignments As String
        Public Property DrawBackground As Boolean
        Public Property MinimumSize As String
        Public Property MaximumSize As String
        Public Property Disabled As Boolean
        Public Property Hidden As Boolean
        Public Property RestrictToParent As Boolean
        Public Property MouseInputEnabled As Boolean
        Public Property HideToolTip As Boolean
        Public Property ToolTipBackground As String
        Public Property ToolTipFont As String
        Public Property ToolTipTextColor As String
        Public Property Texture As String
        Public Property HoverSound As String
        Public Property LeftMouseClickSound As String
        Public Property RightMouseClickSound As String
        Public Property Children As UserPanelChildren
    End Class

    Public Class UserPanelChildren
        Public Property UsernameLabel As IntersectLabel
        Public Property UsernameField As IntersectField
    End Class

    Public Class PasswordPanel
        Public Property Bounds As String
        Public Property Padding As String
        Public Property AlignmentEdgeDistances As String
        Public Property AlignmentTransform As String
        Public Property Margin As String
        Public Property RenderColor As String
        Public Property Alignments As String
        Public Property DrawBackground As Boolean
        Public Property MinimumSize As String
        Public Property MaximumSize As String
        Public Property Disabled As Boolean
        Public Property Hidden As Boolean
        Public Property RestrictToParent As Boolean
        Public Property MouseInputEnabled As Boolean
        Public Property HideToolTip As Boolean
        Public Property ToolTipBackground As String
        Public Property ToolTipFont As String
        Public Property ToolTipTextColor As String
        Public Property Texture As String
        Public Property HoverSound As String
        Public Property LeftMouseClickSound As String
        Public Property RightMouseClickSound As String
        Public Property Children As PasswordPanelChildren
    End Class

    Public Class PasswordPanelChildren
        Public Property PasswordLabel As IntersectLabel
        Public Property PasswordField As IntersectField
    End Class

    Public Class SavePassCheckbox
        Public Property Bounds As String
        Public Property Padding As String
        Public Property AlignmentEdgeDistances As String
        Public Property AlignmentTransform As String
        Public Property Margin As String
        Public Property RenderColor As String
        Public Property Alignments As String
        Public Property DrawBackground As Boolean
        Public Property MinimumSize As String
        Public Property MaximumSize As String
        Public Property Disabled As Boolean
        Public Property Hidden As Boolean
        Public Property RestrictToParent As Boolean
        Public Property MouseInputEnabled As Boolean
        Public Property HideToolTip As Boolean
        Public Property ToolTipBackground As String
        Public Property ToolTipFont As String
        Public Property ToolTipTextColor As String
        Public Property Label As IntersectLabel
        Public Property Checkbox As IntersectCheckbox
    End Class

    Public Sub LoadLoginGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainLoginWindowPanel.Visible = True
        Form1.RefreshBtn.Visible = True
        Form1.gridToggle.Visible = True
        Form1.SaveToolStripMenuItem.Visible = True
        Form1.toolSplitContainer.Panel2.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\background.png")

        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        Form1.JTokenTreeUserControl1.SetJsonSource(Form1.fullJson.Text)
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New LoginWindow
        infoPull = JsonConvert.DeserializeObject(Of LoginWindow)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     LoginWindow.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim loginheaderlabelbounds As String() = infoPull.Children.LoginHeader.TextPadding.Split(",")
        Dim usernamepanelbounds As String() = infoPull.Children.UsernamePanel.Bounds.Split(",")
        Dim usernamelabelbounds As String() = infoPull.Children.UsernamePanel.Children.UsernameLabel.Bounds.Split(",")
        Dim usernamefieldbounds As String() = infoPull.Children.UsernamePanel.Children.UsernameField.Bounds.Split(",")
        Dim passwordpanelbounds As String() = infoPull.Children.PasswordPanel.Bounds.Split(",")
        Dim passwordlabelbounds As String() = infoPull.Children.PasswordPanel.Children.PasswordLabel.Bounds.Split(",")
        Dim passwordfieldbounds As String() = infoPull.Children.PasswordPanel.Children.PasswordField.Bounds.Split(",")
        Dim savepasspanel As String() = infoPull.Children.SavePassCheckbox.Bounds.Split(",")
        Dim savepasslabel As String() = infoPull.Children.SavePassCheckbox.Label.Bounds.Split(",")
        Dim savepasscheckbox As String() = infoPull.Children.SavePassCheckbox.Checkbox.Bounds.Split(",")
        Dim forgotpasswordbuttonbounds As String() = infoPull.Children.ForgotPasswordButton.Bounds.Split(",")
        Dim loginbuttonbounds As String() = infoPull.Children.LoginButton.Bounds.Split(",")
        Dim backbuttonbounds As String() = infoPull.Children.BackButton.Bounds.Split(",")

        Form1.MainLoginWindowPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainLoginWindowPanel.Width = mainwindowbounds(2)
        Form1.MainLoginWindowPanel.Height = mainwindowbounds(3)
        Form1.MainLoginWindowPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.LoginHeaderLabel.Location = New Point(loginheaderlabelbounds(0), loginheaderlabelbounds(1))
        Form1.UsernamePanel.Location = New Point(usernamepanelbounds(0), usernamepanelbounds(1))
        Form1.UsernamePanel.Width = usernamepanelbounds(2)
        Form1.UsernamePanel.Height = usernamepanelbounds(3)
        Form1.UsernamePanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.UsernamePanel.Texture)
        Form1.UsernameLabel.Location = New Point(usernamelabelbounds(0), usernamelabelbounds(1))
        Form1.UsernameFieldPB.Location = New Point(usernamefieldbounds(0), usernamefieldbounds(1))
        Form1.UsernameFieldPB.Width = usernamefieldbounds(2)
        Form1.UsernameFieldPB.Height = usernamefieldbounds(3)
        Form1.PasswordPanel.Location = New Point(passwordpanelbounds(0), passwordpanelbounds(1))
        Form1.PasswordPanel.Width = passwordpanelbounds(2)
        Form1.PasswordPanel.Height = passwordpanelbounds(3)
        Form1.PasswordPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.PasswordPanel.Texture)
        Form1.PasswordLabel.Location = New Point(passwordlabelbounds(0), passwordlabelbounds(1))
        Form1.PasswordField.Location = New Point(passwordfieldbounds(0), passwordfieldbounds(1))
        Form1.PasswordField.Width = passwordfieldbounds(2)
        Form1.PasswordField.Height = passwordfieldbounds(3)
        Form1.SavePassPanel.Location = New Point(savepasspanel(0), savepasspanel(1))
        Form1.SavePassPanel.Width = savepasspanel(2)
        Form1.SavePassPanel.Height = savepasspanel(3)
        Form1.SavePassLabel.Location = New Point(savepasslabel(0), savepasslabel(1))
        Form1.SavePassCheckbox.Location = New Point(savepasscheckbox(0), savepasscheckbox(1))
        Form1.SavePassCheckbox.Width = savepasscheckbox(2)
        Form1.SavePassCheckbox.Height = savepasscheckbox(3)
        Form1.SavePassCheckbox.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.SavePassCheckbox.Checkbox.NormalImage)
        Form1.LoginButton.Location = New Point(loginbuttonbounds(0), loginbuttonbounds(1))
        Form1.LoginButton.Width = loginbuttonbounds(2)
        Form1.LoginButton.Height = loginbuttonbounds(3)
        Form1.LoginButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.LoginButton.NormalImage)
        Form1.BackButton.Location = New Point(backbuttonbounds(0), backbuttonbounds(1))
        Form1.BackButton.Width = backbuttonbounds(2)
        Form1.BackButton.Height = backbuttonbounds(3)
        Form1.BackButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.BackButton.NormalImage)
    End Sub

    Public Sub UpdateLoginGUI(ByVal jsonfile As String)
        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New LoginWindow
        infoPull = JsonConvert.DeserializeObject(Of LoginWindow)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     LoginWindow.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim loginheaderlabelbounds As String() = infoPull.Children.LoginHeader.TextPadding.Split(",")
        Dim usernamepanelbounds As String() = infoPull.Children.UsernamePanel.Bounds.Split(",")
        Dim usernamelabelbounds As String() = infoPull.Children.UsernamePanel.Children.UsernameLabel.Bounds.Split(",")
        Dim usernamefieldbounds As String() = infoPull.Children.UsernamePanel.Children.UsernameField.Bounds.Split(",")
        Dim passwordpanelbounds As String() = infoPull.Children.PasswordPanel.Bounds.Split(",")
        Dim passwordlabelbounds As String() = infoPull.Children.PasswordPanel.Children.PasswordLabel.Bounds.Split(",")
        Dim passwordfieldbounds As String() = infoPull.Children.PasswordPanel.Children.PasswordField.Bounds.Split(",")
        Dim savepasspanel As String() = infoPull.Children.SavePassCheckbox.Bounds.Split(",")
        Dim savepasslabel As String() = infoPull.Children.SavePassCheckbox.Label.Bounds.Split(",")
        Dim savepasscheckbox As String() = infoPull.Children.SavePassCheckbox.Checkbox.Bounds.Split(",")
        Dim forgotpasswordbuttonbounds As String() = infoPull.Children.ForgotPasswordButton.Bounds.Split(",")
        Dim loginbuttonbounds As String() = infoPull.Children.LoginButton.Bounds.Split(",")
        Dim backbuttonbounds As String() = infoPull.Children.BackButton.Bounds.Split(",")

        Form1.MainLoginWindowPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainLoginWindowPanel.Width = mainwindowbounds(2)
        Form1.MainLoginWindowPanel.Height = mainwindowbounds(3)
        Form1.MainLoginWindowPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.LoginHeaderLabel.Location = New Point(loginheaderlabelbounds(0), loginheaderlabelbounds(1))
        Form1.UsernamePanel.Location = New Point(usernamepanelbounds(0), usernamepanelbounds(1))
        Form1.UsernamePanel.Width = usernamepanelbounds(2)
        Form1.UsernamePanel.Height = usernamepanelbounds(3)
        Form1.UsernamePanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.UsernamePanel.Texture)
        Form1.UsernameLabel.Location = New Point(usernamelabelbounds(0), usernamelabelbounds(1))
        Form1.UsernameFieldPB.Location = New Point(usernamefieldbounds(0), usernamefieldbounds(1))
        Form1.UsernameFieldPB.Width = usernamefieldbounds(2)
        Form1.UsernameFieldPB.Height = usernamefieldbounds(3)
        Form1.PasswordPanel.Location = New Point(passwordpanelbounds(0), passwordpanelbounds(1))
        Form1.PasswordPanel.Width = passwordpanelbounds(2)
        Form1.PasswordPanel.Height = passwordpanelbounds(3)
        Form1.PasswordPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.PasswordPanel.Texture)
        Form1.PasswordLabel.Location = New Point(passwordlabelbounds(0), passwordlabelbounds(1))
        Form1.PasswordField.Location = New Point(passwordfieldbounds(0), passwordfieldbounds(1))
        Form1.PasswordField.Width = passwordfieldbounds(2)
        Form1.PasswordField.Height = passwordfieldbounds(3)
        Form1.SavePassPanel.Location = New Point(savepasspanel(0), savepasspanel(1))
        Form1.SavePassPanel.Width = savepasspanel(2)
        Form1.SavePassPanel.Height = savepasspanel(3)
        Form1.SavePassLabel.Location = New Point(savepasslabel(0), savepasslabel(1))
        Form1.SavePassCheckbox.Location = New Point(savepasscheckbox(0), savepasscheckbox(1))
        Form1.SavePassCheckbox.Width = savepasscheckbox(2)
        Form1.SavePassCheckbox.Height = savepasscheckbox(3)
        Form1.SavePassCheckbox.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.SavePassCheckbox.Checkbox.NormalImage)
        Form1.LoginButton.Location = New Point(loginbuttonbounds(0), loginbuttonbounds(1))
        Form1.LoginButton.Width = loginbuttonbounds(2)
        Form1.LoginButton.Height = loginbuttonbounds(3)
        Form1.LoginButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.LoginButton.NormalImage)
        Form1.BackButton.Location = New Point(backbuttonbounds(0), backbuttonbounds(1))
        Form1.BackButton.Width = backbuttonbounds(2)
        Form1.BackButton.Height = backbuttonbounds(3)
        Form1.BackButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.BackButton.NormalImage)
    End Sub
End Module
