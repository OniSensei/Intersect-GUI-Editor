Imports System.IO
Imports Newtonsoft.Json

Module QuestOfferWindowGUI
    Public Class QuestOfferWindow
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
        Public Property Titlebar As IntersectTitlebar
        Public Property Title As IntersectLabel
        Public Property CloseButton As IntersectButton
        Public Property InnerPanel As QuestOfferWindowInnerPanel
    End Class

    Public Class QuestOfferWindowInnerPanel
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
        Public Property Children As InnerPanelChildren
    End Class

    Public Class InnerPanelChildren
        Public Property QuestTitle As IntersectLabel
        Public Property QuestOfferArea As QuestOfferArea
        Public Property AcceptButton As IntersectButton
        Public Property DeclineButton As IntersectButton
    End Class

    Public Class QuestOfferArea
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
        Public Property InnerPanel As QuestOfferAreaInnerPanel
        Public Property HorizontalScrollBar As IntersectScrollBar
        Public Property VerticalScrollBar As IntersectScrollBar
    End Class

    Public Class QuestOfferAreaInnerPanel
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
        Public Property Children As QuestOfferAreaInnerPanelChildren
    End Class

    Public Class QuestOfferAreaInnerPanelChildren
        Public Property QuestOfferTemplate As IntersectLabel
    End Class

    Public Sub LoadQuestOfferWindowGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainQuestOfferWindowPanel.Visible = True
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
        Dim infoPull As New QuestOfferWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestOfferWindow)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     QuestOfferWindow.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim TitleBounds As String() = infoPull.Title.Padding.Split(",")
        Dim CloseButtonBounds As String() = infoPull.CloseButton.Bounds.Split(",")
        Dim QuestTitleBounds As String() = infoPull.InnerPanel.Children.QuestTitle.Bounds.Split(",")
        Dim QuestOfferAreaBounds As String() = infoPull.InnerPanel.Children.QuestOfferArea.Bounds.Split(",")
        Dim QuestOfferTemplateBounds As String() = infoPull.InnerPanel.Children.QuestOfferArea.InnerPanel.Children.QuestOfferTemplate.Bounds.Split(",")
        Dim AcceptButtonBounds As String() = infoPull.InnerPanel.Children.AcceptButton.Bounds.Split(",")
        Dim DeclineButtonBounds As String() = infoPull.InnerPanel.Children.DeclineButton.Bounds.Split(",")

        Form1.MainQuestOfferWindowPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainQuestOfferWindowPanel.Width = mainwindowbounds(2)
        Form1.MainQuestOfferWindowPanel.Height = mainwindowbounds(3)
        Form1.MainQuestOfferWindowPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.ActiveImage)
        Form1.QuestOfferTitle.Location = New Point(TitleBounds(0), TitleBounds(1))
        Form1.QuestOfferCloseButton.Location = New Point(CloseButtonBounds(0), CloseButtonBounds(1))
        Form1.QuestOfferCloseButton.Width = CloseButtonBounds(2)
        Form1.QuestOfferCloseButton.Height = CloseButtonBounds(3)
        Form1.QuestOfferCloseButton.BackgroundImage = Image.FromFile(imgResources & infoPull.CloseButton.NormalImage)
        Form1.QuestTitle.Location = New Point(QuestTitleBounds(0), QuestTitleBounds(1))
        Form1.QuestOfferArea.Location = New Point(QuestOfferAreaBounds(0), QuestOfferAreaBounds(1))
        Form1.QuestOfferArea.Width = QuestOfferAreaBounds(2)
        Form1.QuestOfferArea.Height = QuestOfferAreaBounds(3)
        Form1.QuestOfferTemplate.Location = New Point(QuestOfferTemplateBounds(0), QuestOfferTemplateBounds(1))
        Form1.QuestOfferAcceptButton.Location = New Point(AcceptButtonBounds(0), AcceptButtonBounds(1))
        Form1.QuestOfferAcceptButton.Width = AcceptButtonBounds(2)
        Form1.QuestOfferAcceptButton.Height = AcceptButtonBounds(3)
        Form1.QuestOfferAcceptButton.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.AcceptButton.NormalImage)
        Form1.QuestOfferDeclineButton.Location = New Point(DeclineButtonBounds(0), DeclineButtonBounds(1))
        Form1.QuestOfferDeclineButton.Width = DeclineButtonBounds(2)
        Form1.QuestOfferDeclineButton.Height = DeclineButtonBounds(3)
        Form1.QuestOfferDeclineButton.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.DeclineButton.NormalImage)
    End Sub

    Public Sub UpdateQuestOfferWindowGUI(ByVal jsonfile As String)
        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New QuestOfferWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestOfferWindow)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     QuestOfferWindow.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim TitleBounds As String() = infoPull.Title.Padding.Split(",")
        Dim CloseButtonBounds As String() = infoPull.CloseButton.Bounds.Split(",")
        Dim QuestTitleBounds As String() = infoPull.InnerPanel.Children.QuestTitle.Bounds.Split(",")
        Dim QuestOfferAreaBounds As String() = infoPull.InnerPanel.Children.QuestOfferArea.Bounds.Split(",")
        Dim QuestOfferTemplateBounds As String() = infoPull.InnerPanel.Children.QuestOfferArea.InnerPanel.Children.QuestOfferTemplate.Bounds.Split(",")
        Dim AcceptButtonBounds As String() = infoPull.InnerPanel.Children.AcceptButton.Bounds.Split(",")
        Dim DeclineButtonBounds As String() = infoPull.InnerPanel.Children.DeclineButton.Bounds.Split(",")

        Form1.MainQuestOfferWindowPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainQuestOfferWindowPanel.Width = mainwindowbounds(2)
        Form1.MainQuestOfferWindowPanel.Height = mainwindowbounds(3)
        Form1.MainQuestOfferWindowPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.ActiveImage)
        Form1.QuestOfferTitle.Location = New Point(TitleBounds(0), TitleBounds(1))
        Form1.QuestOfferCloseButton.Location = New Point(CloseButtonBounds(0), CloseButtonBounds(1))
        Form1.QuestOfferCloseButton.Width = CloseButtonBounds(2)
        Form1.QuestOfferCloseButton.Height = CloseButtonBounds(3)
        Form1.QuestOfferCloseButton.BackgroundImage = Image.FromFile(imgResources & infoPull.CloseButton.NormalImage)
        Form1.QuestTitle.Location = New Point(QuestTitleBounds(0), QuestTitleBounds(1))
        Form1.QuestOfferArea.Location = New Point(QuestOfferAreaBounds(0), QuestOfferAreaBounds(1))
        Form1.QuestOfferArea.Width = QuestOfferAreaBounds(2)
        Form1.QuestOfferArea.Height = QuestOfferAreaBounds(3)
        Form1.QuestOfferTemplate.Location = New Point(QuestOfferTemplateBounds(0), QuestOfferTemplateBounds(1))
        Form1.QuestOfferAcceptButton.Location = New Point(AcceptButtonBounds(0), AcceptButtonBounds(1))
        Form1.QuestOfferAcceptButton.Width = AcceptButtonBounds(2)
        Form1.QuestOfferAcceptButton.Height = AcceptButtonBounds(3)
        Form1.QuestOfferAcceptButton.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.AcceptButton.NormalImage)
        Form1.QuestOfferDeclineButton.Location = New Point(DeclineButtonBounds(0), DeclineButtonBounds(1))
        Form1.QuestOfferDeclineButton.Width = DeclineButtonBounds(2)
        Form1.QuestOfferDeclineButton.Height = DeclineButtonBounds(3)
        Form1.QuestOfferDeclineButton.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.DeclineButton.NormalImage)
    End Sub
End Module
