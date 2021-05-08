Imports System.IO
Imports Newtonsoft.Json

Module MenuWindowGUI
    Public Class MenuWindow
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
        Public Property ServerStatusLabel As IntersectLabel
        Public Property Title As IntersectLabel
        Public Property LoginButton As IntersectButton
        Public Property RegisterButton As IntersectButton
        Public Property CreditsButton As IntersectButton
        Public Property ExitButton As IntersectButton
        Public Property OptionsButton As IntersectButton
    End Class

    Public Sub LoadMenuWindow(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainMenuWindowPanel.Visible = True
        Form1.RefreshBtn.Visible = True
        Form1.gridToggle.Visible = True
        Form1.SaveToolStripMenuItem.Visible = True
        Form1.toolSplitContainer.Panel2.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\background.png")

        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        Form1.JTokenTreeUserControl1.SetJsonSource(Form1.fullJson.Text)
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New MenuWindow
        infoPull = JsonConvert.DeserializeObject(Of MenuWindow)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     LoginWindow.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim ServerStatusLabelBounds As String() = infoPull.Children.ServerStatusLabel.Bounds.Split(",")
        Dim MenuWindowTitleBounds As String() = infoPull.Children.Title.TextPadding.Split(",")
        Dim MenuWindowLoginButtonBounds As String() = infoPull.Children.LoginButton.Bounds.Split(",")
        Dim MenuWindowRegisterButtonBounds As String() = infoPull.Children.RegisterButton.Bounds.Split(",")
        Dim MenuWindowCreditsButtonBounds As String() = infoPull.Children.CreditsButton.Bounds.Split(",")
        Dim MenuWindowExitButtonBounds As String() = infoPull.Children.ExitButton.Bounds.Split(",")
        Dim MenuWindowOptionsButtonBounds As String() = infoPull.Children.OptionsButton.Bounds.Split(",")

        Form1.MainMenuWindowPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainMenuWindowPanel.Width = mainwindowbounds(2)
        Form1.MainMenuWindowPanel.Height = mainwindowbounds(3)
        Form1.MainMenuWindowPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.MainMenuTitle.Location = New Point(MenuWindowTitleBounds(0), MenuWindowTitleBounds(1))
        Form1.MainMenuLoginButton.Location = New Point(MenuWindowLoginButtonBounds(0), MenuWindowLoginButtonBounds(1))
        Form1.MainMenuLoginButton.Width = MenuWindowLoginButtonBounds(2)
        Form1.MainMenuLoginButton.Height = MenuWindowLoginButtonBounds(3)
        Form1.MainMenuLoginButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.LoginButton.NormalImage)
        Form1.MainMenuRegisterButton.Location = New Point(MenuWindowRegisterButtonBounds(0), MenuWindowRegisterButtonBounds(1))
        Form1.MainMenuRegisterButton.Width = MenuWindowRegisterButtonBounds(2)
        Form1.MainMenuRegisterButton.Height = MenuWindowRegisterButtonBounds(3)
        Form1.MainMenuRegisterButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.RegisterButton.NormalImage)
        Form1.MainMenuCreditsButton.Location = New Point(MenuWindowCreditsButtonBounds(0), MenuWindowCreditsButtonBounds(1))
        Form1.MainMenuCreditsButton.Width = MenuWindowCreditsButtonBounds(2)
        Form1.MainMenuCreditsButton.Height = MenuWindowCreditsButtonBounds(3)
        Form1.MainMenuCreditsButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.CreditsButton.NormalImage)
        Form1.MainMenuExitButton.Location = New Point(MenuWindowExitButtonBounds(0), MenuWindowExitButtonBounds(1))
        Form1.MainMenuExitButton.Width = MenuWindowExitButtonBounds(2)
        Form1.MainMenuExitButton.Height = MenuWindowExitButtonBounds(3)
        Form1.MainMenuExitButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.ExitButton.NormalImage)
        Form1.MainMenuOptionsButton.Location = New Point(MenuWindowOptionsButtonBounds(0), MenuWindowOptionsButtonBounds(1))
        Form1.MainMenuOptionsButton.Width = MenuWindowOptionsButtonBounds(2)
        Form1.MainMenuOptionsButton.Height = MenuWindowOptionsButtonBounds(3)
        Form1.MainMenuOptionsButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.OptionsButton.NormalImage)
    End Sub

    Public Sub UpdateMenuWindow(ByVal jsonfile As String)
        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New MenuWindow
        infoPull = JsonConvert.DeserializeObject(Of MenuWindow)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     LoginWindow.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim ServerStatusLabelBounds As String() = infoPull.Children.ServerStatusLabel.Bounds.Split(",")
        Dim MenuWindowTitleBounds As String() = infoPull.Children.Title.TextPadding.Split(",")
        Dim MenuWindowLoginButtonBounds As String() = infoPull.Children.LoginButton.Bounds.Split(",")
        Dim MenuWindowRegisterButtonBounds As String() = infoPull.Children.RegisterButton.Bounds.Split(",")
        Dim MenuWindowCreditsButtonBounds As String() = infoPull.Children.CreditsButton.Bounds.Split(",")
        Dim MenuWindowExitButtonBounds As String() = infoPull.Children.ExitButton.Bounds.Split(",")
        Dim MenuWindowOptionsButtonBounds As String() = infoPull.Children.OptionsButton.Bounds.Split(",")

        Form1.MainMenuWindowPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainMenuWindowPanel.Width = mainwindowbounds(2)
        Form1.MainMenuWindowPanel.Height = mainwindowbounds(3)
        Form1.MainMenuWindowPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.MainMenuTitle.Location = New Point(MenuWindowTitleBounds(0), MenuWindowTitleBounds(1))
        Form1.MainMenuLoginButton.Location = New Point(MenuWindowLoginButtonBounds(0), MenuWindowLoginButtonBounds(1))
        Form1.MainMenuLoginButton.Width = MenuWindowLoginButtonBounds(2)
        Form1.MainMenuLoginButton.Height = MenuWindowLoginButtonBounds(3)
        Form1.MainMenuLoginButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.LoginButton.NormalImage)
        Form1.MainMenuRegisterButton.Location = New Point(MenuWindowRegisterButtonBounds(0), MenuWindowRegisterButtonBounds(1))
        Form1.MainMenuRegisterButton.Width = MenuWindowRegisterButtonBounds(2)
        Form1.MainMenuRegisterButton.Height = MenuWindowRegisterButtonBounds(3)
        Form1.MainMenuRegisterButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.RegisterButton.NormalImage)
        Form1.MainMenuCreditsButton.Location = New Point(MenuWindowCreditsButtonBounds(0), MenuWindowCreditsButtonBounds(1))
        Form1.MainMenuCreditsButton.Width = MenuWindowCreditsButtonBounds(2)
        Form1.MainMenuCreditsButton.Height = MenuWindowCreditsButtonBounds(3)
        Form1.MainMenuCreditsButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.CreditsButton.NormalImage)
        Form1.MainMenuExitButton.Location = New Point(MenuWindowExitButtonBounds(0), MenuWindowExitButtonBounds(1))
        Form1.MainMenuExitButton.Width = MenuWindowExitButtonBounds(2)
        Form1.MainMenuExitButton.Height = MenuWindowExitButtonBounds(3)
        Form1.MainMenuExitButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.ExitButton.NormalImage)
        Form1.MainMenuOptionsButton.Location = New Point(MenuWindowOptionsButtonBounds(0), MenuWindowOptionsButtonBounds(1))
        Form1.MainMenuOptionsButton.Width = MenuWindowOptionsButtonBounds(2)
        Form1.MainMenuOptionsButton.Height = MenuWindowOptionsButtonBounds(3)
        Form1.MainMenuOptionsButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.OptionsButton.NormalImage)
    End Sub
End Module
