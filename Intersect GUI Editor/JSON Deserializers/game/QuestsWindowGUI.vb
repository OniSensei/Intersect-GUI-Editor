Imports System.IO
Imports Newtonsoft.Json

Module QuestsWindowGUI
    Public Class QuestsWindow
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
        Public Property Titlebar As QuestsWindowTitlebar
        Public Property Title As IntersectLabel
        Public Property CloseButton As IntersectButton
        Public Property InnerPanel As QuestsWindowInnerPanel
    End Class

    Public Class QuestsWindowTitlebar
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

    Public Class QuestsWindowInnerPanel
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
        Public Property Children As QuestsWindowInnerPanelChildren
    End Class

    Public Class QuestsWindowInnerPanelChildren
        Public Property QuestList As QuestList
        Public Property QuestTitle As IntersectLabel
        Public Property QuestStatus As IntersectLabel
        Public Property QuestDescription As IntersectContainer
        Public Property QuestDescriptionTemplate As IntersectLabel
        Public Property BackButton As IntersectButton
        Public Property AbandonQuestButton As IntersectButton
    End Class

    Public Class QuestList
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


    Public Sub LoadQuestsWindowGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainQuestsWindowPanel.Visible = True
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
        Dim infoPull As New QuestsWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestsWindow)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     QuestsWindow.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim TitleBounds As String() = infoPull.Title.Padding.Split(",")
        Dim CloseButtonBounds As String() = infoPull.CloseButton.Bounds.Split(",")
        Dim QuestListBounds As String() = infoPull.InnerPanel.Children.QuestList.Bounds.Split(",")
        Dim QuestTitleBounds As String() = infoPull.InnerPanel.Children.QuestTitle.Bounds.Split(",")
        Dim QuestStatusBounds As String() = infoPull.InnerPanel.Children.QuestStatus.Bounds.Split(",")
        Dim QuestDescriptionBounds As String() = infoPull.InnerPanel.Children.QuestDescription.Bounds.Split(",")
        Dim QuestDescriptionTemplateBounds As String() = infoPull.InnerPanel.Children.QuestDescriptionTemplate.Bounds.Split(",")
        Dim BackButtonBounds As String() = infoPull.InnerPanel.Children.BackButton.Bounds.Split(",")
        Dim AbandonQuestButtonBounds As String() = infoPull.InnerPanel.Children.AbandonQuestButton.Bounds.Split(",")

        Form1.MainQuestsWindowPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainQuestsWindowPanel.Width = mainwindowbounds(2)
        Form1.MainQuestsWindowPanel.Height = mainwindowbounds(3)
        Form1.MainQuestsWindowPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.ActiveImage)
        Form1.QuestsWindowTitle.Location = New Point(TitleBounds(0), TitleBounds(1))
        Form1.QuestsWindowCloseButton.Location = New Point(CloseButtonBounds(0), CloseButtonBounds(1))
        Form1.QuestsWindowCloseButton.Width = CloseButtonBounds(2)
        Form1.QuestsWindowCloseButton.Height = CloseButtonBounds(3)
        Form1.QuestsWindowCloseButton.BackgroundImage = Image.FromFile(imgResources & infoPull.CloseButton.NormalImage)
        Form1.QuestsWindowQuestList.Location = New Point(QuestListBounds(0), QuestListBounds(1))
        Form1.QuestsWindowQuestList.Width = QuestListBounds(2)
        Form1.QuestsWindowQuestList.Height = QuestListBounds(3)
        Form1.QuestsWindowQuestTitle.Location = New Point(QuestTitleBounds(0), QuestTitleBounds(1))
        Form1.QuestsWindowQuestStatus.Location = New Point(QuestStatusBounds(0), QuestStatusBounds(1))
        Form1.QuestsWindowQuestDescription.Location = New Point(QuestDescriptionBounds(0), QuestDescriptionBounds(1))
        Form1.QuestsWindowQuestDescription.Width = QuestDescriptionBounds(2)
        Form1.QuestsWindowQuestDescription.Height = QuestDescriptionBounds(3)
        Form1.QuestsWindowQuestDescriptionTemplate.Location = New Point(QuestDescriptionTemplateBounds(0), QuestDescriptionTemplateBounds(1))
        Form1.QuestsWindowBackButton.Location = New Point(BackButtonBounds(0), BackButtonBounds(1))
        Form1.QuestsWindowBackButton.Width = BackButtonBounds(2)
        Form1.QuestsWindowBackButton.Height = BackButtonBounds(3)
        Form1.QuestsWindowBackButton.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.BackButton.NormalImage)
        Form1.QuestsWindowAbandonQuestButton.Location = New Point(AbandonQuestButtonBounds(0), AbandonQuestButtonBounds(1))
        Form1.QuestsWindowAbandonQuestButton.Width = AbandonQuestButtonBounds(2)
        Form1.QuestsWindowAbandonQuestButton.Height = AbandonQuestButtonBounds(3)
        Form1.QuestsWindowAbandonQuestButton.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.AbandonQuestButton.NormalImage)
    End Sub
End Module
