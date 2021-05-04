Imports System.IO
Imports Newtonsoft.Json

Module SpellsWindowGUI
    Public Class SpellsWindow
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
        Public Property InnerPanel As SpellsWindowInnerPanel
    End Class

    Public Class SpellsWindowInnerPanel
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
        Public Property Children As SpellsWindowInnerPanelChildren
    End Class

    Public Class SpellsWindowInnerPanelChildren
        Public Property SpellsContainer As SpellsContainer
    End Class

    Public Class SpellsContainer
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

    Public Sub LoadSpellsWindowGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainSpellsWindowPanel.Visible = True
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
        Dim infoPull As New SpellsWindow
        infoPull = JsonConvert.DeserializeObject(Of SpellsWindow)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     SpellsWindow.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim TitleBounds As String() = infoPull.Title.Padding.Split(",")
        Dim CloseButtonBounds As String() = infoPull.CloseButton.Bounds.Split(",")

        Form1.MainSpellsWindowPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainSpellsWindowPanel.Width = mainwindowbounds(2)
        Form1.MainSpellsWindowPanel.Height = mainwindowbounds(3)
        Form1.MainSpellsWindowPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.ActiveImage)
        Form1.SpellsWindowTitle.Location = New Point(TitleBounds(0), TitleBounds(1))
        Form1.SpellsWindowCloseButton.Location = New Point(CloseButtonBounds(0), CloseButtonBounds(1))
        Form1.SpellsWindowCloseButton.Width = CloseButtonBounds(2)
        Form1.SpellsWindowCloseButton.Height = CloseButtonBounds(3)
        Form1.SpellsWindowCloseButton.BackgroundImage = Image.FromFile(imgResources & infoPull.CloseButton.NormalImage)
    End Sub
End Module
