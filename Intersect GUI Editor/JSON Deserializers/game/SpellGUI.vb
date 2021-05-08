Imports System.IO
Imports Newtonsoft.Json

Module SpellGUI
    Public Class Spell
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
        Public Property SpellIcon As SpellIcon
    End Class

    Public Class SpellIcon
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
        Public Property Children As SpellIconChildren
    End Class

    Public Class SpellIconChildren
        Public Property SpellCooldownLabel As IntersectLabel
    End Class

    Public Sub LoadSpellGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainSpellPanel.Visible = True
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
        Dim infoPull As New Spell
        infoPull = JsonConvert.DeserializeObject(Of Spell)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     Spell.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim SpellIconBounds As String() = infoPull.Children.SpellIcon.Bounds.Split(",")
        Dim SpellCooldownLabelBounds As String() = infoPull.Children.SpellIcon.Children.SpellCooldownLabel.Bounds.Split(",")

        Form1.MainSpellPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainSpellPanel.Width = mainwindowbounds(2)
        Form1.MainSpellPanel.Height = mainwindowbounds(3)
        Form1.MainSpellPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.SpellIcon.Location = New Point(SpellIconBounds(0), SpellIconBounds(1))
        Form1.SpellIcon.Width = SpellIconBounds(2)
        Form1.SpellIcon.Height = SpellIconBounds(3)
        Form1.SpellIcon.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\spell.png")
        Form1.SpellCooldownLabel.Location = New Point(SpellCooldownLabelBounds(0), SpellCooldownLabelBounds(1))
    End Sub

    Public Sub UpdateSpellGUI(ByVal jsonfile As String)
        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New Spell
        infoPull = JsonConvert.DeserializeObject(Of Spell)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     Spell.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim SpellIconBounds As String() = infoPull.Children.SpellIcon.Bounds.Split(",")
        Dim SpellCooldownLabelBounds As String() = infoPull.Children.SpellIcon.Children.SpellCooldownLabel.Bounds.Split(",")

        Form1.MainSpellPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainSpellPanel.Width = mainwindowbounds(2)
        Form1.MainSpellPanel.Height = mainwindowbounds(3)
        Form1.MainSpellPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.SpellIcon.Location = New Point(SpellIconBounds(0), SpellIconBounds(1))
        Form1.SpellIcon.Width = SpellIconBounds(2)
        Form1.SpellIcon.Height = SpellIconBounds(3)
        Form1.SpellIcon.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\spell.png")
        Form1.SpellCooldownLabel.Location = New Point(SpellCooldownLabelBounds(0), SpellCooldownLabelBounds(1))
    End Sub
End Module
