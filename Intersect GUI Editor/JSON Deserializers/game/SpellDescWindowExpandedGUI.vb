Imports System.IO
Imports Newtonsoft.Json

Module SpellDescWindowExpandedGUI
    Public Class SpellDescWindowExpanded
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
        Public Property SpellIcon As IntersectIcon
        Public Property SpellName As IntersectLabel
        Public Property SpellType As IntersectLabel
        Public Property SpellDesc As IntersectBase
        Public Property SpellStats As IntersectBase
        Public Property SpellDescText As IntersectLabel
        Public Property SpellStatsText As IntersectLabel
    End Class

    Public Sub LoadSpellDescWindowExpandedGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainSpellDescWindowExpandedPanel.Visible = True
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
        Dim infoPull As New SpellDescWindowExpanded
        infoPull = JsonConvert.DeserializeObject(Of SpellDescWindowExpanded)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     SpellDescWindowExpanded.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim SpellIconBounds As String() = infoPull.Children.SpellIcon.Bounds.Split(",")
        Dim SpellNameBounds As String() = infoPull.Children.SpellName.Bounds.Split(",")
        Dim SpellTypeBounds As String() = infoPull.Children.SpellType.Bounds.Split(",")
        Dim SpellDescBounds As String() = infoPull.Children.SpellDesc.Bounds.Split(",")
        Dim SpellDescTextBounds As String() = infoPull.Children.SpellDescText.Bounds.Split(",")
        Dim SpellStatsBounds As String() = infoPull.Children.SpellStats.Bounds.Split(",")
        Dim SpellStatsTextBounds As String() = infoPull.Children.SpellStatsText.Bounds.Split(",")

        Form1.MainSpellDescWindowExpandedPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainSpellDescWindowExpandedPanel.Width = mainwindowbounds(2)
        Form1.MainSpellDescWindowExpandedPanel.Height = mainwindowbounds(3)
        Form1.MainSpellDescWindowExpandedPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.SpellDescExpandedSpellIcon.Location = New Point(SpellIconBounds(0), SpellIconBounds(1))
        Form1.SpellDescExpandedSpellIcon.Width = SpellIconBounds(2)
        Form1.SpellDescExpandedSpellIcon.Height = SpellIconBounds(3)
        Form1.SpellDescExpandedSpellIcon.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\spell.png")
        Form1.SpellDescExpandedSpellName.Location = New Point(SpellNameBounds(0), SpellNameBounds(1))
        Form1.SpellDescExpandedSpellType.Location = New Point(SpellTypeBounds(0), SpellTypeBounds(1))
        Form1.SpellDescExpandedSpellDescText.Location = New Point(SpellDescTextBounds(0), SpellDescTextBounds(1))
        Form1.SpellDescExpandedSpellDesc.Location = New Point(SpellDescBounds(0), SpellDescBounds(1))
        Form1.SpellDescExpandedSpellDesc.Width = SpellDescBounds(2)
        Form1.SpellDescExpandedSpellDesc.Height = SpellDescBounds(3)
        Form1.SpellDescExpandedStatsText.Location = New Point(SpellStatsTextBounds(0), SpellStatsTextBounds(1))
        Form1.SpellDescExpandedStats.Location = New Point(SpellStatsBounds(0), SpellStatsBounds(1))
        Form1.SpellDescExpandedStats.Width = SpellStatsBounds(2)
        Form1.SpellDescExpandedStats.Height = SpellStatsBounds(3)
    End Sub

    Public Sub UpdateSpellDescWindowExpandedGUI(ByVal jsonfile As String)
        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New SpellDescWindowExpanded
        infoPull = JsonConvert.DeserializeObject(Of SpellDescWindowExpanded)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     SpellDescWindowExpanded.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim SpellIconBounds As String() = infoPull.Children.SpellIcon.Bounds.Split(",")
        Dim SpellNameBounds As String() = infoPull.Children.SpellName.Bounds.Split(",")
        Dim SpellTypeBounds As String() = infoPull.Children.SpellType.Bounds.Split(",")
        Dim SpellDescBounds As String() = infoPull.Children.SpellDesc.Bounds.Split(",")
        Dim SpellDescTextBounds As String() = infoPull.Children.SpellDescText.Bounds.Split(",")
        Dim SpellStatsBounds As String() = infoPull.Children.SpellStats.Bounds.Split(",")
        Dim SpellStatsTextBounds As String() = infoPull.Children.SpellStatsText.Bounds.Split(",")

        Form1.MainSpellDescWindowExpandedPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainSpellDescWindowExpandedPanel.Width = mainwindowbounds(2)
        Form1.MainSpellDescWindowExpandedPanel.Height = mainwindowbounds(3)
        Form1.MainSpellDescWindowExpandedPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.SpellDescExpandedSpellIcon.Location = New Point(SpellIconBounds(0), SpellIconBounds(1))
        Form1.SpellDescExpandedSpellIcon.Width = SpellIconBounds(2)
        Form1.SpellDescExpandedSpellIcon.Height = SpellIconBounds(3)
        Form1.SpellDescExpandedSpellIcon.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\spell.png")
        Form1.SpellDescExpandedSpellName.Location = New Point(SpellNameBounds(0), SpellNameBounds(1))
        Form1.SpellDescExpandedSpellType.Location = New Point(SpellTypeBounds(0), SpellTypeBounds(1))
        Form1.SpellDescExpandedSpellDescText.Location = New Point(SpellDescTextBounds(0), SpellDescTextBounds(1))
        Form1.SpellDescExpandedSpellDesc.Location = New Point(SpellDescBounds(0), SpellDescBounds(1))
        Form1.SpellDescExpandedSpellDesc.Width = SpellDescBounds(2)
        Form1.SpellDescExpandedSpellDesc.Height = SpellDescBounds(3)
        Form1.SpellDescExpandedStatsText.Location = New Point(SpellStatsTextBounds(0), SpellStatsTextBounds(1))
        Form1.SpellDescExpandedStats.Location = New Point(SpellStatsBounds(0), SpellStatsBounds(1))
        Form1.SpellDescExpandedStats.Width = SpellStatsBounds(2)
        Form1.SpellDescExpandedStats.Height = SpellStatsBounds(3)
    End Sub
End Module
