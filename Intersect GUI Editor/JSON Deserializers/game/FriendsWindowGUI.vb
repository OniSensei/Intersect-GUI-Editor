Imports System.IO
Imports Newtonsoft.Json

Module FriendsWindowGUI
    Public Class FriendsWindow
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
        Public Property ClampMovement As Boolean
        Public Property ActiveImage As String
        Public Property InactiveImage As String
        Public Property ActiveColor As String
        Public Property InactiveColor As String
        Public Property Closable As Boolean
        Public Property Titlebar As FriendsWindowTitlebar
        Public Property Title As IntersectLabel
        Public Property CloseButton As IntersectButton
        Public Property InnerPanel As FriendsWindowInnerPanel
    End Class

    Public Class FriendsWindowTitlebar
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
    End Class

    Public Class FriendsWindowInnerPanel
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
        Public Property Children As FriendsWindowInnerPanelChildren
    End Class

    Public Class FriendsWindowInnerPanelChildren
        Public Property SearchContainer As SearchContainer
        Public Property FriendsList As FriendsList
        Public Property AddFriendButton As IntersectButton
        Public Property AddFriendPopupButton As IntersectButton
    End Class

    Public Class SearchContainer
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
        Public Property Children As SearchContainerChildren
    End Class

    Public Class SearchContainerChildren
        Public Property SearchTextbox As IntersectField
    End Class

    Public Class FriendsList
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
        Public Property CanScrollH As Boolean
        Public Property CanScrollV As Boolean
        Public Property AutoHideBars As Boolean
        Public Property InnerPanel As IntersectInnerPanel
        Public Property HorizontalScrollBar As IntersectScrollBar
        Public Property VerticalScrollBar As IntersectScrollBar
        Public Property SizeToContents As Boolean
        Public Property MultiSelect As Boolean
        Public Property IsToggle As Boolean
        Public Property Font As String
        Public Property ItemHoverSound As String
        Public Property ItemClickSound As String
        Public Property ItemRightClickSound As String
    End Class

    Public Sub LoadFriendsWindowGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainFriendsWindowPanel.Visible = True
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
        Dim infoPull As New FriendsWindow
        infoPull = JsonConvert.DeserializeObject(Of FriendsWindow)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     FriendsWindow.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim TitleBounds As String() = infoPull.Title.Padding.Split(",")
        Dim CloseButtonBounds As String() = infoPull.CloseButton.Bounds.Split(",")
        Dim AddFriendPopupButtonBounds As String() = infoPull.InnerPanel.Children.AddFriendPopupButton.Bounds.Split(",")

        Form1.MainFriendsWindowPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainFriendsWindowPanel.Width = mainwindowbounds(2)
        Form1.MainFriendsWindowPanel.Height = mainwindowbounds(3)
        Form1.MainFriendsWindowPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.ActiveImage)
        Form1.FriendsWindowTitle.Location = New Point(TitleBounds(0), TitleBounds(1))
        Form1.FriendsWindowCloseButton.Location = New Point(CloseButtonBounds(0), CloseButtonBounds(1))
        Form1.FriendsWindowCloseButton.Width = CloseButtonBounds(2)
        Form1.FriendsWindowCloseButton.Height = CloseButtonBounds(3)
        Form1.FriendsWindowCloseButton.BackgroundImage = Image.FromFile(imgResources & infoPull.CloseButton.NormalImage)
        Form1.AddFriendPopupButton.Location = New Point(AddFriendPopupButtonBounds(0), AddFriendPopupButtonBounds(1))
        Form1.AddFriendPopupButton.Width = AddFriendPopupButtonBounds(2)
        Form1.AddFriendPopupButton.Height = AddFriendPopupButtonBounds(3)
        Form1.AddFriendPopupButton.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.AddFriendPopupButton.NormalImage)
    End Sub
End Module
