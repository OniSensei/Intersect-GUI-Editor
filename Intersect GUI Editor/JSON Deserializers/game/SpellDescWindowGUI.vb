Imports System.IO
Imports Newtonsoft.Json

Module SpellDescWindowGUI
    Public Class SpellDescWindow
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
        Public Property SpellIcon As DescSpellIcon
        Public Property SpellName As IntersectLabel
        Public Property SpellType As IntersectLabel
        Public Property SpellDesc As IntersectBase
        Public Property SpellDescText As IntersectLabel
    End Class

    Public Class DescSpellIcon
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

    Public Sub LoadSpellDescWindowGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainSpellDescWindowPanel.Visible = True
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
        Dim infoPull As New SpellDescWindow
        infoPull = JsonConvert.DeserializeObject(Of SpellDescWindow)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     SpellDescWindow.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim SpellIconBounds As String() = infoPull.Children.SpellIcon.Bounds.Split(",")
        Dim SpellNameBounds As String() = infoPull.Children.SpellName.Bounds.Split(",")
        Dim SpellTypeBounds As String() = infoPull.Children.SpellType.Bounds.Split(",")
        Dim SpellDescBounds As String() = infoPull.Children.SpellDesc.Bounds.Split(",")
        Dim SpellDescTextBounds As String() = infoPull.Children.SpellDescText.Bounds.Split(",")

        Form1.MainSpellDescWindowPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainSpellDescWindowPanel.Width = mainwindowbounds(2)
        Form1.MainSpellDescWindowPanel.Height = mainwindowbounds(3)
        Form1.MainSpellDescWindowPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.SpellDescSpellIcon.Location = New Point(SpellIconBounds(0), SpellIconBounds(1))
        Form1.SpellDescSpellIcon.Width = SpellIconBounds(2)
        Form1.SpellDescSpellIcon.Height = SpellIconBounds(3)
        Form1.SpellDescSpellIcon.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\spell.png")
        Form1.SpellDescSpellName.Location = New Point(SpellNameBounds(0), SpellNameBounds(1))
        Form1.SpellDescSpellType.Location = New Point(SpellTypeBounds(0), SpellTypeBounds(1))
        Form1.SpellDescSpellDescText.Location = New Point(SpellDescTextBounds(0), SpellDescTextBounds(1))
        Form1.SpellDescSpellDesc.Location = New Point(SpellDescBounds(0), SpellDescBounds(1))
        Form1.SpellDescSpellDesc.Width = SpellDescBounds(2)
        Form1.SpellDescSpellDesc.Height = SpellDescBounds(3)
    End Sub
End Module
