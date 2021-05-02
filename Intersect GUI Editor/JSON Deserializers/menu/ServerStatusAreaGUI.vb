Imports System.IO
Imports Newtonsoft.Json

Module ServerStatusAreaGUI
    Public Class ServerStatusArea
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
        Public Property ServerStatusLabel As IntersectLabel
    End Class

    Public Sub LoadServerStatusAreaGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainServerStatusAreaPanel.Visible = True
        Form1.RefreshBtn.Visible = True
        Form1.gridToggle.Visible = True
        Form1.toolSplitContainer.Panel2.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\background.png")

        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        Form1.JTokenTreeUserControl1.SetJsonSource(Form1.fullJson.Text)
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New ServerStatusArea
        infoPull = JsonConvert.DeserializeObject(Of ServerStatusArea)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     ServerStatusArea.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim ServerStatusLabelBounds As String() = infoPull.Children.ServerStatusLabel.Bounds.Split(",")

        Form1.MainServerStatusAreaPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainServerStatusAreaPanel.Width = mainwindowbounds(2)
        Form1.MainServerStatusAreaPanel.Height = mainwindowbounds(3)
        Form1.MainServerStatusAreaPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.ServerStatusAreaServerStatusLabel.Location = New Point(ServerStatusLabelBounds(0), ServerStatusLabelBounds(1))
        
    End Sub
End Module
