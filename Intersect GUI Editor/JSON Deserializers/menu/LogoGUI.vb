Imports System.IO
Imports Newtonsoft.Json

Module LogoGUI
    Public Class Logo
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
    End Class

    Public Sub LoadLogoGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainLogoPanel.Visible = True
        Form1.RefreshBtn.Visible = True
        Form1.gridToggle.Visible = True
        Form1.SaveToolStripMenuItem.Visible = True
        Form1.toolSplitContainer.Panel2.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\background.png")

        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        Form1.JTokenTreeUserControl1.SetJsonSource(Form1.fullJson.Text)
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New Logo
        infoPull = JsonConvert.DeserializeObject(Of Logo)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     Logo.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")

        Form1.MainLogoPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainLogoPanel.Width = mainwindowbounds(2)
        Form1.MainLogoPanel.Height = mainwindowbounds(3)
        Form1.MainLogoPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
    End Sub

    Public Sub UpdateLogoGUI(ByVal jsonfile As String)
        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        Form1.JTokenTreeUserControl1.SetJsonSource(Form1.fullJson.Text)
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New Logo
        infoPull = JsonConvert.DeserializeObject(Of Logo)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     Logo.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")

        Form1.MainLogoPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainLogoPanel.Width = mainwindowbounds(2)
        Form1.MainLogoPanel.Height = mainwindowbounds(3)
        Form1.MainLogoPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
    End Sub
End Module
