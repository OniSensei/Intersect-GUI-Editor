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
        Public Property LoginHeader As LoginHeader
        Public Property UsernamePanel As UsernamePanel
        Public Property PasswordPanel As PasswordPanel
        Public Property SavePassCheckbox As SavePassCheckbox
        Public Property ForgotPasswordButton As ForgotPasswordButton
        Public Property LoginButton As LoginButton
        Public Property BackButton As BackButton

    End Class

    Public Class LoginHeader
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
        Public Property BackgroundTemplate As String
        Public Property TextColor As String
        Public Property HoverTextColor As String
        Public Property ClickedTextColor As String
        Public Property DisabledTextColor As String
        Public Property TextAlign As String
        Public Property TextPadding As String
        Public Property AutoSizeToContents As Boolean
        Public Property Font As String
        Public Property TextScale As Double
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
        Public Property UsernameLabel As UsernameLabel
        Public Property UsernameField As UsernameField
    End Class

    Public Class UsernameLabel
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
        Public Property BackgroundTemplate As String
        Public Property TextColor As String
        Public Property HoverTextColor As String
        Public Property ClickedTextColor As String
        Public Property DisabledTextColor As String
        Public Property TextAlign As String
        Public Property TextPadding As String
        Public Property AutoSizeToContents As Boolean
        Public Property Font As String
        Public Property TextScale As Double
    End Class

    Public Class UsernameField
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
        Public Property BackgroundTemplate As String
        Public Property TextColor As String
        Public Property HoverTextColor As String
        Public Property ClickedTextColor As String
        Public Property DisabledTextColor As String
        Public Property TextAlign As String
        Public Property TextPadding As String
        Public Property AutoSizeToContents As Boolean
        Public Property Font As String
        Public Property TextScale As Double
        Public Property AddTextSound As String
        Public Property RemoveTextSound As String
        Public Property SubmitSound As String
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
        Public Property PasswordLabel As PasswordLabel
        Public Property PasswordField As PasswordField
    End Class

    Public Class PasswordLabel
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
        Public Property BackgroundTemplate As String
        Public Property TextColor As String
        Public Property HoverTextColor As String
        Public Property ClickedTextColor As String
        Public Property DisabledTextColor As String
        Public Property TextAlign As String
        Public Property TextPadding As String
        Public Property AutoSizeToContents As Boolean
        Public Property Font As String
        Public Property TextScale As Double
    End Class

    Public Class PasswordField
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
        Public Property BackgroundTemplate As String
        Public Property TextColor As String
        Public Property HoverTextColor As String
        Public Property ClickedTextColor As String
        Public Property DisabledTextColor As String
        Public Property TextAlign As String
        Public Property TextPadding As String
        Public Property AutoSizeToContents As Boolean
        Public Property Font As String
        Public Property TextScale As Double
        Public Property AddTextSound As String
        Public Property RemoveTextSound As String
        Public Property SubmitSound As String
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
        Public Property Label As SaveLabel
        Public Property Checkbox As SaveCheckbox
    End Class

    Public Class SaveLabel
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
        Public Property BackgroundTemplate As String
        Public Property TextColor As String
        Public Property HoverTextColor As String
        Public Property ClickedTextColor As String
        Public Property DisabledTextColor As String
        Public Property TextAlign As String
        Public Property TextPadding As String
        Public Property AutoSizeToContents As Boolean
        Public Property Font As String
        Public Property TextScale As Double
    End Class

    Public Class SaveCheckbox
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
        Public Property BackgroundTemplate As String
        Public Property TextColor As String
        Public Property HoverTextColor As String
        Public Property ClickedTextColor As String
        Public Property DisabledTextColor As String
        Public Property TextAlign As String
        Public Property TextPadding As String
        Public Property AutoSizeToContents As Boolean
        Public Property Font As String
        Public Property TextScale As Double
        Public Property CenterImage As Boolean
        Public Property HoverSound As String
        Public Property MouseUpSound As String
        Public Property MouseDownSound As String
        Public Property ClickSound As String
        Public Property NormalImage As String
        Public Property CheckedImage As String
        Public Property DisabledImage As String
        Public Property CheckedDisabledImage As String
        Public Property CheckedSound As String
        Public Property UncheckedSound As String
    End Class

    Public Class ForgotPasswordButton
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
        Public Property BackgroundTemplate As String
        Public Property TextColor As String
        Public Property HoverTextColor As String
        Public Property ClickedTextColor As String
        Public Property DisabledTextColor As String
        Public Property TextAlign As String
        Public Property TextPadding As String
        Public Property AutoSizeToContents As Boolean
        Public Property Font As String
        Public Property TextScale As Double
        Public Property NormalImage As String
        Public Property HoveredImage As String
        Public Property ClickedImage As String
        Public Property DisabledImage As String
        Public Property CenterImage As Boolean
        Public Property HoverSound As String
        Public Property MouseUpSound As String
        Public Property MouseDownSound As String
        Public Property ClickSound As String
    End Class

    Public Class LoginButton
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
        Public Property BackgroundTemplate As String
        Public Property TextColor As String
        Public Property HoverTextColor As String
        Public Property ClickedTextColor As String
        Public Property DisabledTextColor As String
        Public Property TextAlign As String
        Public Property TextPadding As String
        Public Property AutoSizeToContents As Boolean
        Public Property Font As String
        Public Property TextScale As Double
        Public Property NormalImage As String
        Public Property HoveredImage As String
        Public Property ClickedImage As String
        Public Property DisabledImage As String
        Public Property CenterImage As Boolean
        Public Property HoverSound As String
        Public Property MouseUpSound As String
        Public Property MouseDownSound As String
        Public Property ClickSound As String
    End Class

    Public Class BackButton
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
        Public Property BackgroundTemplate As String
        Public Property TextColor As String
        Public Property HoverTextColor As String
        Public Property ClickedTextColor As String
        Public Property DisabledTextColor As String
        Public Property TextAlign As String
        Public Property TextPadding As String
        Public Property AutoSizeToContents As Boolean
        Public Property Font As String
        Public Property TextScale As Double
        Public Property NormalImage As String
        Public Property HoveredImage As String
        Public Property ClickedImage As String
        Public Property DisabledImage As String
        Public Property CenterImage As Boolean
        Public Property HoverSound As String
        Public Property MouseUpSound As String
        Public Property MouseDownSound As String
        Public Property ClickSound As String
    End Class

    Public Sub LoadLoginGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainLoginWindowPanel.Visible = True
        Form1.RefreshBtn.Visible = True
        Form1.gridToggle.Visible = True
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

        Form1.StatusText("[MAIN]     Visual Window Updated")
    End Sub
End Module
