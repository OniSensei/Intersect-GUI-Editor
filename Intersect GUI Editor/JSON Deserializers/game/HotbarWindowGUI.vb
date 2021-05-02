Imports System.IO
Imports Newtonsoft.Json

Module HotbarWindowGUI
    Public Class HotbarWindow
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
        Public Property HotbarContainer0 As IntersectHotbarContainer
        Public Property HotbarContainer1 As IntersectHotbarContainer
        Public Property HotbarContainer2 As IntersectHotbarContainer
        Public Property HotbarContainer3 As IntersectHotbarContainer
        Public Property HotbarContainer4 As IntersectHotbarContainer
        Public Property HotbarContainer5 As IntersectHotbarContainer
        Public Property HotbarContainer6 As IntersectHotbarContainer
        Public Property HotbarContainer7 As IntersectHotbarContainer
        Public Property HotbarContainer8 As IntersectHotbarContainer
        Public Property HotbarContainer9 As IntersectHotbarContainer
    End Class

    Public Sub LoadHotbarWindowGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainHotbarWindowPanel.Visible = True
        Form1.RefreshBtn.Visible = True
        Form1.gridToggle.Visible = True
        Form1.toolSplitContainer.Panel2.BackColor = Color.Gray
        Form1.toolSplitContainer.Panel2.BackgroundImage = Nothing

        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        Form1.JTokenTreeUserControl1.SetJsonSource(Form1.fullJson.Text)
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New HotbarWindow
        infoPull = JsonConvert.DeserializeObject(Of HotbarWindow)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     HotbarWindow.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim HotbarContainer0Bounds As String() = infoPull.Children.HotbarContainer0.Bounds.Split(",")
        Dim HotbarContainer1Bounds As String() = infoPull.Children.HotbarContainer1.Bounds.Split(",")
        Dim HotbarContainer2Bounds As String() = infoPull.Children.HotbarContainer2.Bounds.Split(",")
        Dim HotbarContainer3Bounds As String() = infoPull.Children.HotbarContainer3.Bounds.Split(",")
        Dim HotbarContainer4Bounds As String() = infoPull.Children.HotbarContainer4.Bounds.Split(",")
        Dim HotbarContainer5Bounds As String() = infoPull.Children.HotbarContainer5.Bounds.Split(",")
        Dim HotbarContainer6Bounds As String() = infoPull.Children.HotbarContainer6.Bounds.Split(",")
        Dim HotbarContainer7Bounds As String() = infoPull.Children.HotbarContainer7.Bounds.Split(",")
        Dim HotbarContainer8Bounds As String() = infoPull.Children.HotbarContainer8.Bounds.Split(",")
        Dim HotbarContainer9Bounds As String() = infoPull.Children.HotbarContainer9.Bounds.Split(",")
        Dim HotbarIcon0Bounds As String() = infoPull.Children.HotbarContainer0.Children.HotbarIcon0.Bounds.Split(",")
        Dim HotbarIcon1Bounds As String() = infoPull.Children.HotbarContainer1.Children.HotbarIcon1.Bounds.Split(",")
        Dim HotbarIcon2Bounds As String() = infoPull.Children.HotbarContainer2.Children.HotbarIcon2.Bounds.Split(",")
        Dim HotbarIcon3Bounds As String() = infoPull.Children.HotbarContainer3.Children.HotbarIcon3.Bounds.Split(",")
        Dim HotbarIcon4Bounds As String() = infoPull.Children.HotbarContainer4.Children.HotbarIcon4.Bounds.Split(",")
        Dim HotbarIcon5Bounds As String() = infoPull.Children.HotbarContainer5.Children.HotbarIcon5.Bounds.Split(",")
        Dim HotbarIcon6Bounds As String() = infoPull.Children.HotbarContainer6.Children.HotbarIcon6.Bounds.Split(",")
        Dim HotbarIcon7Bounds As String() = infoPull.Children.HotbarContainer7.Children.HotbarIcon7.Bounds.Split(",")
        Dim HotbarIcon8Bounds As String() = infoPull.Children.HotbarContainer8.Children.HotbarIcon8.Bounds.Split(",")
        Dim HotbarIcon9Bounds As String() = infoPull.Children.HotbarContainer9.Children.HotbarIcon9.Bounds.Split(",")
        Dim HotbarEquippedLabel0Bounds As String() = infoPull.Children.HotbarContainer0.Children.HotbarEquippedLabel0.Bounds.Split(",")
        Dim HotbarEquippedLabel1Bounds As String() = infoPull.Children.HotbarContainer1.Children.HotbarEquippedLabel1.Bounds.Split(",")
        Dim HotbarEquippedLabel2Bounds As String() = infoPull.Children.HotbarContainer2.Children.HotbarEquippedLabel2.Bounds.Split(",")
        Dim HotbarEquippedLabel3Bounds As String() = infoPull.Children.HotbarContainer3.Children.HotbarEquippedLabel3.Bounds.Split(",")
        Dim HotbarEquippedLabel4Bounds As String() = infoPull.Children.HotbarContainer4.Children.HotbarEquippedLabel4.Bounds.Split(",")
        Dim HotbarEquippedLabel5Bounds As String() = infoPull.Children.HotbarContainer5.Children.HotbarEquippedLabel5.Bounds.Split(",")
        Dim HotbarEquippedLabel6Bounds As String() = infoPull.Children.HotbarContainer6.Children.HotbarEquippedLabel6.Bounds.Split(",")
        Dim HotbarEquippedLabel7Bounds As String() = infoPull.Children.HotbarContainer7.Children.HotbarEquippedLabel7.Bounds.Split(",")
        Dim HotbarEquippedLabel8Bounds As String() = infoPull.Children.HotbarContainer8.Children.HotbarEquippedLabel8.Bounds.Split(",")
        Dim HotbarEquippedLabel9Bounds As String() = infoPull.Children.HotbarContainer9.Children.HotbarEquippedLabel9.Bounds.Split(",")
        Dim HotbarCooldownLabel0Bounds As String() = infoPull.Children.HotbarContainer0.Children.HotbarCooldownLabel0.Bounds.Split(",")
        Dim HotbarCooldownLabel1Bounds As String() = infoPull.Children.HotbarContainer1.Children.HotbarCooldownLabel1.Bounds.Split(",")
        Dim HotbarCooldownLabel2Bounds As String() = infoPull.Children.HotbarContainer2.Children.HotbarCooldownLabel2.Bounds.Split(",")
        Dim HotbarCooldownLabel3Bounds As String() = infoPull.Children.HotbarContainer3.Children.HotbarCooldownLabel3.Bounds.Split(",")
        Dim HotbarCooldownLabel4Bounds As String() = infoPull.Children.HotbarContainer4.Children.HotbarCooldownLabel4.Bounds.Split(",")
        Dim HotbarCooldownLabel5Bounds As String() = infoPull.Children.HotbarContainer5.Children.HotbarCooldownLabel5.Bounds.Split(",")
        Dim HotbarCooldownLabel6Bounds As String() = infoPull.Children.HotbarContainer6.Children.HotbarCooldownLabel6.Bounds.Split(",")
        Dim HotbarCooldownLabel7Bounds As String() = infoPull.Children.HotbarContainer7.Children.HotbarCooldownLabel7.Bounds.Split(",")
        Dim HotbarCooldownLabel8Bounds As String() = infoPull.Children.HotbarContainer8.Children.HotbarCooldownLabel8.Bounds.Split(",")
        Dim HotbarCooldownLabel9Bounds As String() = infoPull.Children.HotbarContainer9.Children.HotbarCooldownLabel9.Bounds.Split(",")
        Dim HotbarLabel0Bounds As String() = infoPull.Children.HotbarContainer0.Children.HotbarLabel0.Bounds.Split(",")
        Dim HotbarLabel1Bounds As String() = infoPull.Children.HotbarContainer1.Children.HotbarLabel1.Bounds.Split(",")
        Dim HotbarLabel2Bounds As String() = infoPull.Children.HotbarContainer2.Children.HotbarLabel2.Bounds.Split(",")
        Dim HotbarLabel3Bounds As String() = infoPull.Children.HotbarContainer3.Children.HotbarLabel3.Bounds.Split(",")
        Dim HotbarLabel4Bounds As String() = infoPull.Children.HotbarContainer4.Children.HotbarLabel4.Bounds.Split(",")
        Dim HotbarLabel5Bounds As String() = infoPull.Children.HotbarContainer5.Children.HotbarLabel5.Bounds.Split(",")
        Dim HotbarLabel6Bounds As String() = infoPull.Children.HotbarContainer6.Children.HotbarLabel6.Bounds.Split(",")
        Dim HotbarLabel7Bounds As String() = infoPull.Children.HotbarContainer7.Children.HotbarLabel7.Bounds.Split(",")
        Dim HotbarLabel8Bounds As String() = infoPull.Children.HotbarContainer8.Children.HotbarLabel8.Bounds.Split(",")
        Dim HotbarLabel9Bounds As String() = infoPull.Children.HotbarContainer9.Children.HotbarLabel9.Bounds.Split(",")

        Form1.MainHotbarWindowPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainHotbarWindowPanel.Width = mainwindowbounds(2)
        Form1.MainHotbarWindowPanel.Height = mainwindowbounds(3)
        Form1.MainHotbarWindowPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.HotbarContainer0.Location = New Point(HotbarContainer0Bounds(0), HotbarContainer0Bounds(1))
        Form1.HotbarContainer0.Width = HotbarContainer0Bounds(2)
        Form1.HotbarContainer0.Height = HotbarContainer0Bounds(3)
        Form1.HotbarContainer0.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.HotbarContainer0.Texture)
        Form1.HotbarIcon0.Location = New Point(HotbarIcon0Bounds(0), HotbarIcon0Bounds(1))
        Form1.HotbarIcon0.Width = HotbarIcon0Bounds(2)
        Form1.HotbarIcon0.Height = HotbarIcon0Bounds(3)
        Form1.HotbarIcon0.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\hotbar.png")
        Form1.HotbarEquippedLabel0.Location = New Point(HotbarEquippedLabel0Bounds(0), HotbarEquippedLabel0Bounds(1))
        Form1.HotbarCooldownLabel0.Location = New Point(HotbarCooldownLabel0Bounds(0), HotbarCooldownLabel0Bounds(1))
        Form1.HotbarLabel0.Location = New Point(HotbarLabel0Bounds(0), HotbarLabel0Bounds(1))
        Form1.HotbarContainer1.Location = New Point(HotbarContainer1Bounds(0), HotbarContainer1Bounds(1))
        Form1.HotbarContainer1.Width = HotbarContainer1Bounds(2)
        Form1.HotbarContainer1.Height = HotbarContainer1Bounds(3)
        Form1.HotbarContainer1.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.HotbarContainer1.Texture)
        Form1.HotbarIcon1.Location = New Point(HotbarIcon1Bounds(0), HotbarIcon1Bounds(1))
        Form1.HotbarIcon1.Width = HotbarIcon1Bounds(2)
        Form1.HotbarIcon1.Height = HotbarIcon1Bounds(3)
        Form1.HotbarIcon1.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\hotbar.png")
        Form1.HotbarEquippedLabel1.Location = New Point(HotbarEquippedLabel1Bounds(0), HotbarEquippedLabel1Bounds(1))
        Form1.HotbarCooldownLabel1.Location = New Point(HotbarCooldownLabel1Bounds(0), HotbarCooldownLabel1Bounds(1))
        Form1.HotbarLabel1.Location = New Point(HotbarLabel1Bounds(0), HotbarLabel1Bounds(1))
        Form1.HotbarContainer2.Location = New Point(HotbarContainer2Bounds(0), HotbarContainer2Bounds(1))
        Form1.HotbarContainer2.Width = HotbarContainer2Bounds(2)
        Form1.HotbarContainer2.Height = HotbarContainer2Bounds(3)
        Form1.HotbarContainer2.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.HotbarContainer2.Texture)
        Form1.HotbarIcon2.Location = New Point(HotbarIcon2Bounds(0), HotbarIcon2Bounds(1))
        Form1.HotbarIcon2.Width = HotbarIcon2Bounds(2)
        Form1.HotbarIcon2.Height = HotbarIcon2Bounds(3)
        Form1.HotbarIcon2.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\hotbar.png")
        Form1.HotbarEquippedLabel2.Location = New Point(HotbarEquippedLabel2Bounds(0), HotbarEquippedLabel2Bounds(1))
        Form1.HotbarCooldownLabel2.Location = New Point(HotbarCooldownLabel2Bounds(0), HotbarCooldownLabel2Bounds(1))
        Form1.HotbarLabel2.Location = New Point(HotbarLabel2Bounds(0), HotbarLabel2Bounds(1))
        Form1.HotbarContainer3.Location = New Point(HotbarContainer3Bounds(0), HotbarContainer3Bounds(1))
        Form1.HotbarContainer3.Width = HotbarContainer3Bounds(2)
        Form1.HotbarContainer3.Height = HotbarContainer3Bounds(3)
        Form1.HotbarContainer3.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.HotbarContainer3.Texture)
        Form1.HotbarIcon3.Location = New Point(HotbarIcon3Bounds(0), HotbarIcon3Bounds(1))
        Form1.HotbarIcon3.Width = HotbarIcon3Bounds(2)
        Form1.HotbarIcon3.Height = HotbarIcon3Bounds(3)
        Form1.HotbarIcon3.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\hotbar.png")
        Form1.HotbarEquippedLabel3.Location = New Point(HotbarEquippedLabel3Bounds(0), HotbarEquippedLabel3Bounds(1))
        Form1.HotbarCooldownLabel3.Location = New Point(HotbarCooldownLabel3Bounds(0), HotbarCooldownLabel3Bounds(1))
        Form1.HotbarLabel3.Location = New Point(HotbarLabel3Bounds(0), HotbarLabel3Bounds(1))
        Form1.HotbarContainer4.Location = New Point(HotbarContainer4Bounds(0), HotbarContainer4Bounds(1))
        Form1.HotbarContainer4.Width = HotbarContainer4Bounds(2)
        Form1.HotbarContainer4.Height = HotbarContainer4Bounds(3)
        Form1.HotbarContainer4.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.HotbarContainer4.Texture)
        Form1.HotbarIcon4.Location = New Point(HotbarIcon4Bounds(0), HotbarIcon4Bounds(1))
        Form1.HotbarIcon4.Width = HotbarIcon4Bounds(2)
        Form1.HotbarIcon4.Height = HotbarIcon4Bounds(3)
        Form1.HotbarIcon4.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\hotbar.png")
        Form1.HotbarEquippedLabel4.Location = New Point(HotbarEquippedLabel4Bounds(0), HotbarEquippedLabel4Bounds(1))
        Form1.HotbarCooldownLabel4.Location = New Point(HotbarCooldownLabel4Bounds(0), HotbarCooldownLabel4Bounds(1))
        Form1.HotbarLabel4.Location = New Point(HotbarLabel4Bounds(0), HotbarLabel4Bounds(1))
        Form1.HotbarContainer5.Location = New Point(HotbarContainer5Bounds(0), HotbarContainer5Bounds(1))
        Form1.HotbarContainer5.Width = HotbarContainer5Bounds(2)
        Form1.HotbarContainer5.Height = HotbarContainer5Bounds(3)
        Form1.HotbarContainer5.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.HotbarContainer5.Texture)
        Form1.HotbarIcon5.Location = New Point(HotbarIcon5Bounds(0), HotbarIcon5Bounds(1))
        Form1.HotbarIcon5.Width = HotbarIcon5Bounds(2)
        Form1.HotbarIcon5.Height = HotbarIcon5Bounds(3)
        Form1.HotbarIcon5.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\hotbar.png")
        Form1.HotbarEquippedLabel5.Location = New Point(HotbarEquippedLabel5Bounds(0), HotbarEquippedLabel5Bounds(1))
        Form1.HotbarCooldownLabel5.Location = New Point(HotbarCooldownLabel5Bounds(0), HotbarCooldownLabel5Bounds(1))
        Form1.HotbarLabel5.Location = New Point(HotbarLabel5Bounds(0), HotbarLabel5Bounds(1))
        Form1.HotbarContainer6.Location = New Point(HotbarContainer6Bounds(0), HotbarContainer6Bounds(1))
        Form1.HotbarContainer6.Width = HotbarContainer6Bounds(2)
        Form1.HotbarContainer6.Height = HotbarContainer6Bounds(3)
        Form1.HotbarContainer6.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.HotbarContainer6.Texture)
        Form1.HotbarIcon6.Location = New Point(HotbarIcon6Bounds(0), HotbarIcon6Bounds(1))
        Form1.HotbarIcon6.Width = HotbarIcon6Bounds(2)
        Form1.HotbarIcon6.Height = HotbarIcon6Bounds(3)
        Form1.HotbarIcon6.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\hotbar.png")
        Form1.HotbarEquippedLabel6.Location = New Point(HotbarEquippedLabel6Bounds(0), HotbarEquippedLabel6Bounds(1))
        Form1.HotbarCooldownLabel6.Location = New Point(HotbarCooldownLabel6Bounds(0), HotbarCooldownLabel6Bounds(1))
        Form1.HotbarLabel6.Location = New Point(HotbarLabel6Bounds(0), HotbarLabel6Bounds(1))
        Form1.HotbarContainer7.Location = New Point(HotbarContainer7Bounds(0), HotbarContainer7Bounds(1))
        Form1.HotbarContainer7.Width = HotbarContainer7Bounds(2)
        Form1.HotbarContainer7.Height = HotbarContainer7Bounds(3)
        Form1.HotbarContainer7.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.HotbarContainer7.Texture)
        Form1.HotbarIcon7.Location = New Point(HotbarIcon7Bounds(0), HotbarIcon7Bounds(1))
        Form1.HotbarIcon7.Width = HotbarIcon7Bounds(2)
        Form1.HotbarIcon7.Height = HotbarIcon7Bounds(3)
        Form1.HotbarIcon7.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\hotbar.png")
        Form1.HotbarEquippedLabel7.Location = New Point(HotbarEquippedLabel7Bounds(0), HotbarEquippedLabel7Bounds(1))
        Form1.HotbarCooldownLabel7.Location = New Point(HotbarCooldownLabel7Bounds(0), HotbarCooldownLabel7Bounds(1))
        Form1.HotbarLabel7.Location = New Point(HotbarLabel7Bounds(0), HotbarLabel7Bounds(1))
        Form1.HotbarContainer8.Location = New Point(HotbarContainer8Bounds(0), HotbarContainer8Bounds(1))
        Form1.HotbarContainer8.Width = HotbarContainer8Bounds(2)
        Form1.HotbarContainer8.Height = HotbarContainer8Bounds(3)
        Form1.HotbarContainer8.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.HotbarContainer8.Texture)
        Form1.HotbarIcon8.Location = New Point(HotbarIcon8Bounds(0), HotbarIcon8Bounds(1))
        Form1.HotbarIcon8.Width = HotbarIcon8Bounds(2)
        Form1.HotbarIcon8.Height = HotbarIcon8Bounds(3)
        Form1.HotbarIcon8.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\hotbar.png")
        Form1.HotbarEquippedLabel8.Location = New Point(HotbarEquippedLabel8Bounds(0), HotbarEquippedLabel8Bounds(1))
        Form1.HotbarCooldownLabel8.Location = New Point(HotbarCooldownLabel8Bounds(0), HotbarCooldownLabel8Bounds(1))
        Form1.HotbarLabel8.Location = New Point(HotbarLabel8Bounds(0), HotbarLabel8Bounds(1))
        Form1.HotbarContainer9.Location = New Point(HotbarContainer9Bounds(0), HotbarContainer9Bounds(1))
        Form1.HotbarContainer9.Width = HotbarContainer9Bounds(2)
        Form1.HotbarContainer9.Height = HotbarContainer9Bounds(3)
        Form1.HotbarContainer9.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.HotbarContainer9.Texture)
        Form1.HotbarIcon9.Location = New Point(HotbarIcon9Bounds(0), HotbarIcon9Bounds(1))
        Form1.HotbarIcon9.Width = HotbarIcon9Bounds(2)
        Form1.HotbarIcon9.Height = HotbarIcon9Bounds(3)
        Form1.HotbarIcon9.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\hotbar.png")
        Form1.HotbarEquippedLabel9.Location = New Point(HotbarEquippedLabel9Bounds(0), HotbarEquippedLabel9Bounds(1))
        Form1.HotbarCooldownLabel9.Location = New Point(HotbarCooldownLabel9Bounds(0), HotbarCooldownLabel9Bounds(1))
        Form1.HotbarLabel9.Location = New Point(HotbarLabel1Bounds(0), HotbarLabel9Bounds(1))

        
    End Sub
End Module
