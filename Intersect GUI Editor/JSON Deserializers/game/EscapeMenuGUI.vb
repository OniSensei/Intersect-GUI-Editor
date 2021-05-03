Imports System.IO
Imports Newtonsoft.Json

Module EscapeMenuGUI
    Public Class EscapeMenu
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
        Public Property TitleLabel As IntersectLabel
        Public Property OptionsButton As IntersectButton
        Public Property CharacterSelectButton As IntersectButton
        Public Property LogoutButton As IntersectButton
        Public Property ExitToDesktopButton As IntersectButton
        Public Property CloseButton As IntersectButton
    End Class

    Public Sub LoadEscapeMenuGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainEscapeMenuPanel.Visible = True
        Form1.RefreshBtn.Visible = True
        Form1.gridToggle.Visible = True
        Form1.SaveToolStripMenuItem.Visible = True
        Form1.toolSplitContainer.Panel2.BackColor = Color.Gray
        Form1.toolSplitContainer.Panel2.BackgroundImage = Nothing

        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        Form1.JTokenTreeUserControl1.SetJsonSource(Form1.fullJson.Text)
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New EscapeMenu
        infoPull = JsonConvert.DeserializeObject(Of EscapeMenu)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     EscapeMenu.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim TitleLabelBounds As String() = infoPull.Children.TitleLabel.TextPadding.Split(",")
        Dim OptionsButtonBounds As String() = infoPull.Children.OptionsButton.Bounds.Split(",")
        Dim CharacterSelectButtonBounds As String() = infoPull.Children.CharacterSelectButton.Bounds.Split(",")
        Dim LogoutButtonBounds As String() = infoPull.Children.LogoutButton.Bounds.Split(",")
        Dim ExitToDesktopButtonBounds As String() = infoPull.Children.ExitToDesktopButton.Bounds.Split(",")
        Dim CloseButtonBounds As String() = infoPull.Children.CloseButton.Bounds.Split(",")

        Form1.MainEscapeMenuPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainEscapeMenuPanel.Width = mainwindowbounds(2)
        Form1.MainEscapeMenuPanel.Height = mainwindowbounds(3)
        Form1.MainEscapeMenuPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.EscapeMenuTitleLabel.Location = New Point(TitleLabelBounds(0), TitleLabelBounds(1))
        Form1.EscapeMenuOptionsButton.Location = New Point(OptionsButtonBounds(0), OptionsButtonBounds(1))
        Form1.EscapeMenuOptionsButton.Width = OptionsButtonBounds(2)
        Form1.EscapeMenuOptionsButton.Height = OptionsButtonBounds(3)
        Form1.EscapeMenuOptionsButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.OptionsButton.NormalImage)
        Form1.EscapeMenuCharacterSelectButton.Location = New Point(CharacterSelectButtonBounds(0), CharacterSelectButtonBounds(1))
        Form1.EscapeMenuCharacterSelectButton.Width = CharacterSelectButtonBounds(2)
        Form1.EscapeMenuCharacterSelectButton.Height = CharacterSelectButtonBounds(3)
        Form1.EscapeMenuCharacterSelectButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.CharacterSelectButton.NormalImage)
        Form1.EscapeMenuLogoutButton.Location = New Point(LogoutButtonBounds(0), LogoutButtonBounds(1))
        Form1.EscapeMenuLogoutButton.Width = LogoutButtonBounds(2)
        Form1.EscapeMenuLogoutButton.Height = LogoutButtonBounds(3)
        Form1.EscapeMenuLogoutButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.LogoutButton.NormalImage)
        Form1.EscapeMenuExitToDesktopButton.Location = New Point(ExitToDesktopButtonBounds(0), ExitToDesktopButtonBounds(1))
        Form1.EscapeMenuExitToDesktopButton.Width = ExitToDesktopButtonBounds(2)
        Form1.EscapeMenuExitToDesktopButton.Height = ExitToDesktopButtonBounds(3)
        Form1.EscapeMenuExitToDesktopButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.ExitToDesktopButton.NormalImage)
        Form1.EscapeMenuCloseButton.Location = New Point(CloseButtonBounds(0), CloseButtonBounds(1))
        Form1.EscapeMenuCloseButton.Width = CloseButtonBounds(2)
        Form1.EscapeMenuCloseButton.Height = CloseButtonBounds(3)
        Form1.EscapeMenuCloseButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.CloseButton.NormalImage)
    End Sub
End Module
