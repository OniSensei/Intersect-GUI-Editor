Imports System.IO
Imports Newtonsoft.Json
Module CreditsWindowGUI
    Public Class CreditsWindow
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
        Public Property CreditsHeader As IntersectLabel
        Public Property CreditsScrollview As CreditsScrollview
        Public Property BackButton As IntersectButton
    End Class

    Public Class CreditsScrollview
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
        Public Property InnerPanel As CreditsWindowInnerPanel
        Public Property HorizontalScrollBar As CreditsWindowHorizontalScrollBar
        Public Property VerticalScrollBar As CreditsWindowVerticalScrollBar
    End Class

    Public Class CreditsWindowInnerPanel
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
        Public Property Children As CreditsWindowInnerPanelChildren
    End Class

    Public Class CreditsWindowInnerPanelChildren
        Public Property CreditsLabel As IntersectLabel
    End Class

    Public Class CreditsWindowHorizontalScrollBar
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
        Public Property UpOrLeftButton As IntersectUpOrLeftButton
        Public Property Bar As IntersectBar
        Public Property DownOrRightButton As IntersectDownOrRightButton
    End Class

    Public Class CreditsWindowVerticalScrollBar
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
        Public Property UpOrLeftButton As IntersectUpOrLeftButton
        Public Property Bar As IntersectBar
        Public Property DownOrRightButton As IntersectDownOrRightButton
    End Class

    Public Sub LoadCreditsGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainCreditsPanel.Visible = True
        Form1.RefreshBtn.Visible = True
        Form1.gridToggle.Visible = True
        Form1.toolSplitContainer.Panel2.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\background.png")

        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        Form1.JTokenTreeUserControl1.SetJsonSource(Form1.fullJson.Text)
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New CreditsWindow
        infoPull = JsonConvert.DeserializeObject(Of CreditsWindow)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     CreditsWindow.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim CreditsHeaderBounds As String() = infoPull.Children.CreditsHeader.TextPadding.Split(",")
        Dim CreditsScrollviewBounds As String() = infoPull.Children.CreditsScrollview.Bounds.Split(",")
        Dim CreditsInnerPanelBounds As String() = infoPull.Children.CreditsScrollview.InnerPanel.Bounds.Split(",")
        Dim CreditsLabelBounds As String() = infoPull.Children.CreditsScrollview.InnerPanel.Children.CreditsLabel.Bounds.Split(",")
        Dim BackButtonBounds As String() = infoPull.Children.BackButton.Bounds.Split(",")

        Form1.MainCreditsPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainCreditsPanel.Width = mainwindowbounds(2)
        Form1.MainCreditsPanel.Height = mainwindowbounds(3)
        Form1.MainCreditsPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.CreditsHeader.Location = New Point(CreditsHeaderBounds(0), CreditsHeaderBounds(1))
        Form1.CreditsScrollview.Location = New Point(CreditsScrollviewBounds(0), CreditsScrollviewBounds(1))
        Form1.CreditsScrollview.Width = CreditsScrollviewBounds(2)
        Form1.CreditsScrollview.Height = CreditsScrollviewBounds(3)
        Form1.CreditsInnerPanel.Location = New Point(CreditsInnerPanelBounds(0), CreditsInnerPanelBounds(1))
        Form1.CreditsInnerPanel.Width = CreditsInnerPanelBounds(2)
        Form1.CreditsInnerPanel.Height = CreditsInnerPanelBounds(3)
        Form1.CreditsLabel.Location = New Point(CreditsLabelBounds(0), CreditsLabelBounds(1))
        Form1.CreditsBackButton.Location = New Point(BackButtonBounds(0), BackButtonBounds(1))
        Form1.CreditsBackButton.Width = BackButtonBounds(2)
        Form1.CreditsBackButton.Height = BackButtonBounds(3)
        Form1.CreditsBackButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.BackButton.NormalImage)

        Form1.StatusText("[MAIN]     Visual Window Updated")
    End Sub
End Module
