Imports System.IO
Imports Newtonsoft.Json

Module EventDialogWindow1ResonseGUI
    Public Class EventDialogWindow1Resonse
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
        Public Property Children As Children
    End Class

    Public Class Children
        Public Property EventFacePanel As EventFacePanel
        Public Property EventDialogArea As EventDialogArea
        Public Property EventDialogAreaNoFace As EventDialogAreaNoFace
        Public Property Response1Button As IntersectButton
    End Class

    Public Class EventFacePanel
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
    End Class

    Public Class EventDialogArea
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
        Public Property InnerPanel As EventDialogAreaInnerPanel
        Public Property HorizontalScrollBar As IntersectScrollBar
        Public Property VerticalScrollBar As IntersectScrollBar
    End Class

    Public Class EventDialogAreaInnerPanel
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
        Public Property Children As EventDialogAreaInnerPanelChildren
    End Class

    Public Class EventDialogAreaInnerPanelChildren
        Public Property EventDialogLabel As IntersectLabel
    End Class

    Public Class EventDialogAreaNoFace
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
        Public Property InnerPanel As EventDialogAreaNoFaceInnerPanel
        Public Property HorizontalScrollBar As IntersectScrollBar
        Public Property VerticalScrollBar As IntersectScrollBar
    End Class

    Public Class EventDialogAreaNoFaceInnerPanel
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
        Public Property Children As EventDialogAreaNoFaceInnerPanelChildren
    End Class

    Public Class EventDialogAreaNoFaceInnerPanelChildren
        Public Property EventDialogLabel As IntersectLabel
    End Class

    Public Sub LoadEventDialogWindow1ResponseGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainEventDialogWindow1ResponsePanel.Visible = True
        Form1.RefreshBtn.Visible = True
        Form1.gridToggle.Visible = True
        Form1.toolSplitContainer.Panel2.BackColor = Color.Gray
        Form1.toolSplitContainer.Panel2.BackgroundImage = Nothing

        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        Form1.JTokenTreeUserControl1.SetJsonSource(Form1.fullJson.Text)
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New EventDialogWindow1Resonse
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow1Resonse)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     EventDialogWindow_1Response.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim EventFacePanelBounds As String() = infoPull.Children.EventFacePanel.Bounds.Split(",")
        Dim EventDialogAreaBounds As String() = infoPull.Children.EventDialogArea.Bounds.Split(",")
        Dim InnerPanelBounds As String() = infoPull.Children.EventDialogArea.InnerPanel.Bounds.Split(",")
        Dim EventDialogLabelBounds As String() = infoPull.Children.EventDialogArea.InnerPanel.Children.EventDialogLabel.Bounds.Split(",")
        Dim Response1ButtonBounds As String() = infoPull.Children.Response1Button.Bounds.Split(",")

        Form1.MainEventDialogWindow1ResponsePanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainEventDialogWindow1ResponsePanel.Width = mainwindowbounds(2)
        Form1.MainEventDialogWindow1ResponsePanel.Height = mainwindowbounds(3)
        Form1.MainEventDialogWindow1ResponsePanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.Dialog1EventDialogLabel.Location = New Point(EventDialogLabelBounds(0), EventDialogLabelBounds(1))
        Form1.Dialog1Response1Button.Location = New Point(Response1ButtonBounds(0), Response1ButtonBounds(1))
        Form1.Dialog1Response1Button.Width = Response1ButtonBounds(2)
        Form1.Dialog1Response1Button.Height = Response1ButtonBounds(3)
        Form1.Dialog1Response1Button.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.Response1Button.NormalImage)
        Form1.Dialog1EventFacePanel.Location = New Point(EventFacePanelBounds(0), EventFacePanelBounds(1))
        Form1.Dialog1EventFacePanel.Width = EventFacePanelBounds(2)
        Form1.Dialog1EventFacePanel.Height = EventFacePanelBounds(3)
        Form1.Dialog1EventFacePanel.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\face.png")
        Form1.Dialog1EventDialogArea.Location = New Point(EventDialogAreaBounds(0), EventDialogAreaBounds(1))
        Form1.Dialog1EventDialogArea.Width = EventDialogAreaBounds(2)
        Form1.Dialog1EventDialogArea.Height = EventDialogAreaBounds(3)
        Form1.Dialog1EventDialogAreaInnerPanel.Location = New Point(InnerPanelBounds(0), InnerPanelBounds(1))
        Form1.Dialog1EventDialogAreaInnerPanel.Width = InnerPanelBounds(2)
        Form1.Dialog1EventDialogAreaInnerPanel.Height = InnerPanelBounds(3)

        Form1.StatusText("[MAIN]     Visual Window Updated")
    End Sub
End Module
