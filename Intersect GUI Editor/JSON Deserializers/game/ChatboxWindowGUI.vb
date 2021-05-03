Imports System.IO
Imports Newtonsoft.Json

Module ChatboxWindowGUI
    Public Class ChatboxWindow
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
        Public Property MessageList As MessageList
        Public Property ChatboxTitle As IntersectLabel
        Public Property Chatbar As IntersectIcon
        Public Property ChatboxInputField As IntersectField
        Public Property ChannelLabel As IntersectLabel
        Public Property ChatChannelCombobox As ChatChannelCombobox
        Public Property ChatboxText As IntersectLabel
        Public Property ChatboxSendButton As IntersectButton
    End Class

    Public Class MessageList
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

    Public Class ChatChannelCombobox
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
        Public Property MenuAbove As Boolean
        Public Property Menu As ChatWindowComboboxMenu
        Public Property DropDownButton As IntersectButton
        Public Property OpenMenuSound As String
        Public Property CloseMenuSound As String
        Public Property HoverMenuSound As String
        Public Property ItemHoverSound As String
        Public Property SelectItemSound As String
    End Class

    Public Class ChatWindowComboboxMenu
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
    End Class

    Public Sub LoadChatboxWindowGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainChatboxWindowPanel.Visible = True
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
        Dim infoPull As New ChatboxWindow
        infoPull = JsonConvert.DeserializeObject(Of ChatboxWindow)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     ChatboxWindow.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim ChatbarBounds As String() = infoPull.Children.Chatbar.Bounds.Split(",")
        Dim ChatboxInputFieldBounds As String() = infoPull.Children.ChatboxInputField.Bounds.Split(",")

        Form1.MainChatboxWindowPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainChatboxWindowPanel.Width = mainwindowbounds(2)
        Form1.MainChatboxWindowPanel.Height = mainwindowbounds(3)
        Form1.MainChatboxWindowPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.Chatbar.Location = New Point(ChatbarBounds(0), ChatbarBounds(1))
        Form1.Chatbar.Width = ChatbarBounds(2)
        Form1.Chatbar.Height = ChatbarBounds(3)
        Form1.Chatbar.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.Chatbar.Texture)
        Form1.ChatboxInputField.Location = New Point(ChatboxInputFieldBounds(0), ChatboxInputFieldBounds(1))
        Form1.ChatboxInputField.Width = ChatboxInputFieldBounds(2)
        Form1.ChatboxInputField.Height = ChatboxInputFieldBounds(3)
    End Sub
End Module
