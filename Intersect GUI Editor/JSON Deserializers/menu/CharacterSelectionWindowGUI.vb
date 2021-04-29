Imports System.IO
Imports Newtonsoft.Json
Module CharacterSelectionWindowGUI
    Public Class CharacterSelectionWindow
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
        Public Property CharacterSelectionHeader As IntersectLabel
        Public Property CharacterNameLabel As IntersectLabel
        Public Property CharacterInfoLabel As IntersectLabel
        Public Property CharacterContainer As CharSelectCharacterContainer
        Public Property PlayButton As IntersectButton
        Public Property DeleteButton As IntersectButton
        Public Property NewButton As IntersectButton
        Public Property LogoutButton As IntersectButton
    End Class

    Public Class CharSelectCharacterContainer
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
        Public Property Children As CharSelectCharacterContainerChildren
    End Class

    Public Class CharSelectCharacterContainerChildren
        Public Property NextCharacterButton As IntersectButton
        Public Property PreviousCharacterButton As IntersectButton
    End Class

    Public Sub LoadCharacterSelectionGUI(ByVal jsonfile As String)
        Form1.StatusText("[OPEN]     " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainCharSelectionPanel.Visible = True
        Form1.RefreshBtn.Visible = True
        Form1.gridToggle.Visible = True
        Form1.toolSplitContainer.Panel2.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\background.png")

        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        Form1.JTokenTreeUserControl1.SetJsonSource(Form1.fullJson.Text)
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(Form1.fullJson.Text)
        Form1.StatusText("[JSON]     CharacterSelectionWindow.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim CharacterSelectionHeaderBounds As String() = infoPull.Children.CharacterSelectionHeader.TextPadding.Split(",")
        Dim CharacterNameLabelBounds As String() = infoPull.Children.CharacterNameLabel.Bounds.Split(",")
        Dim CharacterInfoLabelBounds As String() = infoPull.Children.CharacterInfoLabel.Bounds.Split(",")
        Dim CharacterContainerBounds As String() = infoPull.Children.CharacterContainer.Bounds.Split(",")
        Dim NextCharacterButtonBounds As String() = infoPull.Children.CharacterContainer.Children.NextCharacterButton.Bounds.Split(",")
        Dim PreviousCharacterButtonBounds As String() = infoPull.Children.CharacterContainer.Children.PreviousCharacterButton.Bounds.Split(",")
        Dim PlayButtonBounds As String() = infoPull.Children.PlayButton.Bounds.Split(",")
        Dim DeleteButtonBounds As String() = infoPull.Children.DeleteButton.Bounds.Split(",")
        Dim NewButtonBounds As String() = infoPull.Children.NewButton.Bounds.Split(",")
        Dim LogoutButtonBounds As String() = infoPull.Children.LogoutButton.Bounds.Split(",")

        Form1.MainCharSelectionPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainCharSelectionPanel.Width = mainwindowbounds(2)
        Form1.MainCharSelectionPanel.Height = mainwindowbounds(3)
        Form1.MainCharSelectionPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.CharacterSelectionHeader.Location = New Point(CharacterSelectionHeaderBounds(0), CharacterSelectionHeaderBounds(1))
        Form1.SelectCharCharacterNameLabel.Location = New Point(CharacterNameLabelBounds(0), CharacterNameLabelBounds(1))
        Form1.CharacterInfoLabel.Location = New Point(CharacterInfoLabelBounds(0), CharacterInfoLabelBounds(1))
        Form1.SelectCharCharacterContainer.Location = New Point(CharacterContainerBounds(0), CharacterContainerBounds(1))
        Form1.SelectCharCharacterContainer.Width = CharacterContainerBounds(2)
        Form1.SelectCharCharacterContainer.Height = CharacterContainerBounds(3)
        Form1.SelectCharCharacterContainer.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.CharacterContainer.Texture)
        Form1.SelectCharCharacterPortrait.Location = New Point(CharacterContainerBounds(0), CharacterContainerBounds(1))
        Form1.SelectCharCharacterPortrait.Width = CharacterContainerBounds(2)
        Form1.SelectCharCharacterPortrait.Height = CharacterContainerBounds(3)
        Form1.NextCharacterButton.Location = New Point(NextCharacterButtonBounds(0), NextCharacterButtonBounds(1))
        Form1.NextCharacterButton.Width = NextCharacterButtonBounds(2)
        Form1.NextCharacterButton.Height = NextCharacterButtonBounds(3)
        Form1.NextCharacterButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.CharacterContainer.Children.NextCharacterButton.NormalImage)
        Form1.PreviousCharacterButton.Location = New Point(PreviousCharacterButtonBounds(0), PreviousCharacterButtonBounds(1))
        Form1.PreviousCharacterButton.Width = PreviousCharacterButtonBounds(2)
        Form1.PreviousCharacterButton.Height = PreviousCharacterButtonBounds(3)
        Form1.PreviousCharacterButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.CharacterContainer.Children.PreviousCharacterButton.NormalImage)
        Form1.PlayButton.Location = New Point(PlayButtonBounds(0), PlayButtonBounds(1))
        Form1.PlayButton.Width = PlayButtonBounds(2)
        Form1.PlayButton.Height = PlayButtonBounds(3)
        Form1.PlayButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.PlayButton.NormalImage)
        Form1.DeleteButton.Location = New Point(DeleteButtonBounds(0), DeleteButtonBounds(1))
        Form1.DeleteButton.Width = DeleteButtonBounds(2)
        Form1.DeleteButton.Height = DeleteButtonBounds(3)
        Form1.DeleteButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.DeleteButton.NormalImage)
        Form1.NewButton.Location = New Point(NewButtonBounds(0), NewButtonBounds(1))
        Form1.NewButton.Width = NewButtonBounds(2)
        Form1.NewButton.Height = NewButtonBounds(3)
        Form1.NewButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.NewButton.NormalImage)
        Form1.LogoutButton.Location = New Point(LogoutButtonBounds(0), LogoutButtonBounds(1))
        Form1.LogoutButton.Width = LogoutButtonBounds(2)
        Form1.LogoutButton.Height = LogoutButtonBounds(3)
        Form1.LogoutButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.LogoutButton.NormalImage)
        Form1.StatusText("[MAIN]     GUI Window Updated")
    End Sub
End Module
