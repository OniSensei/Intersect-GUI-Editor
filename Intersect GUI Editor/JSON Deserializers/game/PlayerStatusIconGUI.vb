Imports System.IO
Imports Newtonsoft.Json

Module PlayerStatusIconGUI
    Public Class PlayerStatusIcon
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
        Public Property StatusIcon As IntersectIcon
        Public Property DurationLabel As IntersectLabel
    End Class

    Public Sub LoadPlayerStatusIconGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainPlayerStatusIconPanel.Visible = True
        Form1.RefreshBtn.Visible = True
        Form1.gridToggle.Visible = True
        Form1.SaveToolStripMenuItem.Visible = True

        Form1.SaveToolStripMenuItem.Visible = True
        Form1.toolSplitContainer.Panel2.BackColor = Color.Gray
        Form1.toolSplitContainer.Panel2.BackgroundImage = Nothing

        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        Form1.JTokenTreeUserControl1.SetJsonSource(Form1.fullJson.Text)
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New PlayerStatusIcon
        infoPull = JsonConvert.DeserializeObject(Of PlayerStatusIcon)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     PlayerStatusIcon.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim StatusIconBounds As String() = infoPull.Children.StatusIcon.Bounds.Split(",")
        Dim DurationLabelBounds As String() = infoPull.Children.DurationLabel.Bounds.Split(",")

        Form1.MainPlayerStatusIconPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainPlayerStatusIconPanel.Width = mainwindowbounds(2)
        Form1.MainPlayerStatusIconPanel.Height = mainwindowbounds(3)
        Form1.MainPlayerStatusIconPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.StatusIcon.Location = New Point(StatusIconBounds(0), StatusIconBounds(1))
        Form1.StatusIcon.Width = StatusIconBounds(2)
        Form1.StatusIcon.Height = StatusIconBounds(3)
        Form1.StatusIcon.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\poison.png")
        Form1.DurationLabel.Location = New Point(DurationLabelBounds(0), DurationLabelBounds(1))
    End Sub
End Module
