Imports System.IO
Imports Newtonsoft.Json

Module PartyWindowGUI
    Public Class PartyWindow
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
        Public Property InnerPanel As PartyWindowInnerPanel
    End Class

    Public Class PartyWindowInnerPanel
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
        Public Property Children As InnerPanelChildren
    End Class

    Public Class InnerPanelChildren
        Public Property LeaderIcon As IntersectIcon
        Public Property LeaderText As IntersectLabel
        Public Property MemberName0 As IntersectLabel
        Public Property HealthBarContainer0 As IntersectStatusBarContainer
        Public Property HealthLabel0 As IntersectLabel
        Public Property HealthValue0 As IntersectLabel
        Public Property ManaBarContainer0 As IntersectStatusBarContainer
        Public Property ManaLabel0 As IntersectLabel
        Public Property ManaValue0 As IntersectLabel
        Public Property MemberName1 As IntersectLabel
        Public Property HealthBarContainer1 As IntersectStatusBarContainer
        Public Property HealthLabel1 As IntersectLabel
        Public Property HealthValue1 As IntersectLabel
        Public Property ManaBarContainer1 As IntersectStatusBarContainer
        Public Property ManaLabel1 As IntersectLabel
        Public Property ManaValue1 As IntersectLabel
        Public Property KickButton1 As IntersectButton
        Public Property MemberName2 As IntersectLabel
        Public Property HealthBarContainer2 As IntersectStatusBarContainer
        Public Property HealthLabel2 As IntersectLabel
        Public Property HealthValue2 As IntersectLabel
        Public Property ManaBarContainer2 As IntersectStatusBarContainer
        Public Property ManaLabel2 As IntersectLabel
        Public Property ManaValue2 As IntersectLabel
        Public Property KickButton2 As IntersectButton
        Public Property MemberName3 As IntersectLabel
        Public Property HealthBarContainer3 As IntersectStatusBarContainer
        Public Property HealthLabel3 As IntersectLabel
        Public Property HealthValue3 As IntersectLabel
        Public Property ManaBarContainer3 As IntersectStatusBarContainer
        Public Property ManaLabel3 As IntersectLabel
        Public Property ManaValue3 As IntersectLabel
        Public Property KickButton3 As IntersectButton
        Public Property LeavePartyButton As IntersectButton
    End Class

    Public Sub LoadPartyWindowGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainPartyWindowPanel.Visible = True
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
        Dim infoPull As New PartyWindow
        infoPull = JsonConvert.DeserializeObject(Of PartyWindow)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     PartyWindow.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim TitleBounds As String() = infoPull.Title.Padding.Split(",")
        Dim CloseButtonBounds As String() = infoPull.CloseButton.Bounds.Split(",")
        Dim LeaderIconBounds As String() = infoPull.InnerPanel.Children.LeaderIcon.Bounds.Split(",")
        Dim LeaderTextBounds As String() = infoPull.InnerPanel.Children.LeaderText.Bounds.Split(",")
        Dim MemberName0Bounds As String() = infoPull.InnerPanel.Children.MemberName0.Bounds.Split(",")
        Dim HealthBarContainer0Bounds As String() = infoPull.InnerPanel.Children.HealthBarContainer0.Bounds.Split(",")
        Dim HealthBar0Bounds As String() = infoPull.InnerPanel.Children.HealthBarContainer0.Children.HealthBar0.Bounds.Split(",")
        Dim HealthLabel0Bounds As String() = infoPull.InnerPanel.Children.HealthLabel0.Bounds.Split(",")
        Dim HealthValue0Bounds As String() = infoPull.InnerPanel.Children.HealthValue0.Bounds.Split(",")
        Dim ManaBarContainer0Bounds As String() = infoPull.InnerPanel.Children.ManaBarContainer0.Bounds.Split(",")
        Dim ManaBar0Bounds As String() = infoPull.InnerPanel.Children.ManaBarContainer0.Children.ManaBar0.Bounds.Split(",")
        Dim ManaLabel0Bounds As String() = infoPull.InnerPanel.Children.ManaLabel0.Bounds.Split(",")
        Dim ManaValue0Bounds As String() = infoPull.InnerPanel.Children.ManaValue0.Bounds.Split(",")
        Dim MemberName1Bounds As String() = infoPull.InnerPanel.Children.MemberName1.Bounds.Split(",")
        Dim HealthBarContainer1Bounds As String() = infoPull.InnerPanel.Children.HealthBarContainer1.Bounds.Split(",")
        Dim HealthBar1Bounds As String() = infoPull.InnerPanel.Children.HealthBarContainer1.Children.HealthBar1.Bounds.Split(",")
        Dim HealthLabel1Bounds As String() = infoPull.InnerPanel.Children.HealthLabel1.Bounds.Split(",")
        Dim HealthValue1Bounds As String() = infoPull.InnerPanel.Children.HealthValue1.Bounds.Split(",")
        Dim ManaBarContainer1Bounds As String() = infoPull.InnerPanel.Children.ManaBarContainer1.Bounds.Split(",")
        Dim ManaBar1Bounds As String() = infoPull.InnerPanel.Children.ManaBarContainer1.Children.ManaBar1.Bounds.Split(",")
        Dim ManaLabel1Bounds As String() = infoPull.InnerPanel.Children.ManaLabel1.Bounds.Split(",")
        Dim ManaValue1Bounds As String() = infoPull.InnerPanel.Children.ManaValue1.Bounds.Split(",")
        Dim KickButton1Bounds As String() = infoPull.InnerPanel.Children.KickButton1.Bounds.Split(",")
        Dim MemberName2Bounds As String() = infoPull.InnerPanel.Children.MemberName2.Bounds.Split(",")
        Dim HealthBarContainer2Bounds As String() = infoPull.InnerPanel.Children.HealthBarContainer2.Bounds.Split(",")
        Dim HealthBar2Bounds As String() = infoPull.InnerPanel.Children.HealthBarContainer2.Children.HealthBar2.Bounds.Split(",")
        Dim HealthLabel2Bounds As String() = infoPull.InnerPanel.Children.HealthLabel2.Bounds.Split(",")
        Dim HealthValue2Bounds As String() = infoPull.InnerPanel.Children.HealthValue2.Bounds.Split(",")
        Dim ManaBarContainer2Bounds As String() = infoPull.InnerPanel.Children.ManaBarContainer2.Bounds.Split(",")
        Dim ManaBar2Bounds As String() = infoPull.InnerPanel.Children.ManaBarContainer2.Children.ManaBar2.Bounds.Split(",")
        Dim ManaLabel2Bounds As String() = infoPull.InnerPanel.Children.ManaLabel2.Bounds.Split(",")
        Dim ManaValue2Bounds As String() = infoPull.InnerPanel.Children.ManaValue2.Bounds.Split(",")
        Dim KickButton2Bounds As String() = infoPull.InnerPanel.Children.KickButton2.Bounds.Split(",")
        Dim MemberName3Bounds As String() = infoPull.InnerPanel.Children.MemberName3.Bounds.Split(",")
        Dim HealthBarContainer3Bounds As String() = infoPull.InnerPanel.Children.HealthBarContainer3.Bounds.Split(",")
        Dim HealthBar3Bounds As String() = infoPull.InnerPanel.Children.HealthBarContainer3.Children.HealthBar3.Bounds.Split(",")
        Dim HealthLabel3Bounds As String() = infoPull.InnerPanel.Children.HealthLabel3.Bounds.Split(",")
        Dim HealthValue3Bounds As String() = infoPull.InnerPanel.Children.HealthValue3.Bounds.Split(",")
        Dim ManaBarContainer3Bounds As String() = infoPull.InnerPanel.Children.ManaBarContainer3.Bounds.Split(",")
        Dim ManaBar3Bounds As String() = infoPull.InnerPanel.Children.ManaBarContainer3.Children.ManaBar3.Bounds.Split(",")
        Dim ManaLabel3Bounds As String() = infoPull.InnerPanel.Children.ManaLabel3.Bounds.Split(",")
        Dim ManaValue3Bounds As String() = infoPull.InnerPanel.Children.ManaValue3.Bounds.Split(",")
        Dim KickButton3Bounds As String() = infoPull.InnerPanel.Children.KickButton3.Bounds.Split(",")
        Dim LeavePartyButtonBounds As String() = infoPull.InnerPanel.Children.LeavePartyButton.Bounds.Split(",")

        Form1.MainPartyWindowPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainPartyWindowPanel.Width = mainwindowbounds(2)
        Form1.MainPartyWindowPanel.Height = mainwindowbounds(3)
        Form1.MainPartyWindowPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.ActiveImage)
        Form1.PartyTitle.Location = New Point(TitleBounds(0), TitleBounds(1))
        Form1.PartyCloseButton.Location = New Point(CloseButtonBounds(0), CloseButtonBounds(1))
        Form1.PartyCloseButton.Width = CloseButtonBounds(2)
        Form1.PartyCloseButton.Height = CloseButtonBounds(3)
        Form1.PartyCloseButton.BackgroundImage = Image.FromFile(imgResources & infoPull.CloseButton.NormalImage)
        Form1.LeaderIcon.Location = New Point(LeaderIconBounds(0), LeaderIconBounds(1))
        Form1.LeaderIcon.Width = LeaderIconBounds(2)
        Form1.LeaderIcon.Height = LeaderIconBounds(3)
        Form1.LeaderText.Location = New Point(LeaderTextBounds(0), LeaderTextBounds(1))
        Form1.MemberName0.Location = New Point(MemberName0Bounds(0), MemberName0Bounds(1))
        Form1.HealthBarContainer0.Location = New Point(HealthBarContainer0Bounds(0), HealthBarContainer0Bounds(1))
        Form1.HealthBarContainer0.Width = HealthBarContainer0Bounds(2)
        Form1.HealthBarContainer0.Height = HealthBarContainer0Bounds(3)
        Form1.HealthBarContainer0.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.HealthBarContainer0.Texture)
        Form1.HealthBar0.Location = New Point(HealthBar0Bounds(0), HealthBar0Bounds(1))
        Form1.HealthBar0.Width = HealthBar0Bounds(2)
        Form1.HealthBar0.Height = HealthBar0Bounds(3)
        Form1.HealthBar0.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.HealthBarContainer0.Children.HealthBar0.Texture)
        Form1.HealthLabel0.Location = New Point(HealthLabel0Bounds(0), HealthLabel0Bounds(1))
        Form1.HealthValue0.Location = New Point(HealthValue0Bounds(0), HealthValue0Bounds(1))
        Form1.ManaBarContainer0.Location = New Point(ManaBarContainer0Bounds(0), ManaBarContainer0Bounds(1))
        Form1.ManaBarContainer0.Width = ManaBarContainer0Bounds(2)
        Form1.ManaBarContainer0.Height = ManaBarContainer0Bounds(3)
        Form1.ManaBarContainer0.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.ManaBarContainer0.Texture)
        Form1.ManaBar0.Location = New Point(ManaBar0Bounds(0), ManaBar0Bounds(1))
        Form1.ManaBar0.Width = ManaBar0Bounds(2)
        Form1.ManaBar0.Height = ManaBar0Bounds(3)
        Form1.ManaBar0.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.ManaBarContainer0.Children.ManaBar0.Texture)
        Form1.ManaLabel0.Location = New Point(ManaLabel0Bounds(0), ManaLabel0Bounds(1))
        Form1.ManaValue0.Location = New Point(ManaValue0Bounds(0), ManaValue0Bounds(1))
        Form1.MemberName1.Location = New Point(MemberName1Bounds(0), MemberName1Bounds(1))
        Form1.HealthBarContainer1.Location = New Point(HealthBarContainer1Bounds(0), HealthBarContainer1Bounds(1))
        Form1.HealthBarContainer1.Width = HealthBarContainer1Bounds(2)
        Form1.HealthBarContainer1.Height = HealthBarContainer1Bounds(3)
        Form1.HealthBarContainer1.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.HealthBarContainer1.Texture)
        Form1.HealthBar1.Location = New Point(HealthBar1Bounds(0), HealthBar1Bounds(1))
        Form1.HealthBar1.Width = HealthBar1Bounds(2)
        Form1.HealthBar1.Height = HealthBar1Bounds(3)
        Form1.HealthBar1.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.HealthBarContainer1.Children.HealthBar1.Texture)
        Form1.HealthLabel1.Location = New Point(HealthLabel1Bounds(0), HealthLabel1Bounds(1))
        Form1.HealthValue1.Location = New Point(HealthValue1Bounds(0), HealthValue1Bounds(1))
        Form1.ManaBarContainer1.Location = New Point(ManaBarContainer1Bounds(0), ManaBarContainer1Bounds(1))
        Form1.ManaBarContainer1.Width = ManaBarContainer1Bounds(2)
        Form1.ManaBarContainer1.Height = ManaBarContainer1Bounds(3)
        Form1.ManaBarContainer1.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.ManaBarContainer1.Texture)
        Form1.ManaBar1.Location = New Point(ManaBar1Bounds(0), ManaBar1Bounds(1))
        Form1.ManaBar1.Width = ManaBar1Bounds(2)
        Form1.ManaBar1.Height = ManaBar1Bounds(3)
        Form1.ManaBar1.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.ManaBarContainer1.Children.ManaBar1.Texture)
        Form1.ManaLabel1.Location = New Point(ManaLabel1Bounds(0), ManaLabel1Bounds(1))
        Form1.ManaValue1.Location = New Point(ManaValue1Bounds(0), ManaValue1Bounds(1))
        Form1.KickButton1.Location = New Point(KickButton1Bounds(0), KickButton1Bounds(1))
        Form1.MemberName2.Location = New Point(MemberName2Bounds(0), MemberName2Bounds(1))
        Form1.HealthBarContainer2.Location = New Point(HealthBarContainer2Bounds(0), HealthBarContainer2Bounds(1))
        Form1.HealthBarContainer2.Width = HealthBarContainer2Bounds(2)
        Form1.HealthBarContainer2.Height = HealthBarContainer2Bounds(3)
        Form1.HealthBarContainer2.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.HealthBarContainer2.Texture)
        Form1.HealthBar2.Location = New Point(HealthBar2Bounds(0), HealthBar2Bounds(1))
        Form1.HealthBar2.Width = HealthBar2Bounds(2)
        Form1.HealthBar2.Height = HealthBar2Bounds(3)
        Form1.HealthBar2.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.HealthBarContainer2.Children.HealthBar2.Texture)
        Form1.HealthLabel2.Location = New Point(HealthLabel2Bounds(0), HealthLabel2Bounds(1))
        Form1.HealthValue2.Location = New Point(HealthValue2Bounds(0), HealthValue2Bounds(1))
        Form1.ManaBarContainer2.Location = New Point(ManaBarContainer2Bounds(0), ManaBarContainer2Bounds(1))
        Form1.ManaBarContainer2.Width = ManaBarContainer2Bounds(2)
        Form1.ManaBarContainer2.Height = ManaBarContainer2Bounds(3)
        Form1.ManaBarContainer2.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.ManaBarContainer2.Texture)
        Form1.ManaBar2.Location = New Point(ManaBar2Bounds(0), ManaBar2Bounds(1))
        Form1.ManaBar2.Width = ManaBar2Bounds(2)
        Form1.ManaBar2.Height = ManaBar2Bounds(3)
        Form1.ManaBar2.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.ManaBarContainer2.Children.ManaBar2.Texture)
        Form1.ManaLabel2.Location = New Point(ManaLabel2Bounds(0), ManaLabel2Bounds(1))
        Form1.ManaValue2.Location = New Point(ManaValue2Bounds(0), ManaValue2Bounds(1))
        Form1.KickButton2.Location = New Point(KickButton2Bounds(0), KickButton2Bounds(1))
        Form1.MemberName3.Location = New Point(MemberName3Bounds(0), MemberName3Bounds(1))
        Form1.HealthBarContainer3.Location = New Point(HealthBarContainer3Bounds(0), HealthBarContainer3Bounds(1))
        Form1.HealthBarContainer3.Width = HealthBarContainer3Bounds(2)
        Form1.HealthBarContainer3.Height = HealthBarContainer3Bounds(3)
        Form1.HealthBarContainer3.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.HealthBarContainer3.Texture)
        Form1.HealthBar3.Location = New Point(HealthBar3Bounds(0), HealthBar3Bounds(1))
        Form1.HealthBar3.Width = HealthBar3Bounds(2)
        Form1.HealthBar3.Height = HealthBar3Bounds(3)
        Form1.HealthBar3.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.HealthBarContainer3.Children.HealthBar3.Texture)
        Form1.HealthLabel3.Location = New Point(HealthLabel3Bounds(0), HealthLabel3Bounds(1))
        Form1.HealthValue3.Location = New Point(HealthValue3Bounds(0), HealthValue3Bounds(1))
        Form1.ManaBarContainer3.Location = New Point(ManaBarContainer3Bounds(0), ManaBarContainer3Bounds(1))
        Form1.ManaBarContainer3.Width = ManaBarContainer3Bounds(2)
        Form1.ManaBarContainer3.Height = ManaBarContainer3Bounds(3)
        Form1.ManaBarContainer3.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.ManaBarContainer3.Texture)
        Form1.ManaBar3.Location = New Point(ManaBar3Bounds(0), ManaBar3Bounds(1))
        Form1.ManaBar3.Width = ManaBar3Bounds(2)
        Form1.ManaBar3.Height = ManaBar3Bounds(3)
        Form1.ManaBar3.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.ManaBarContainer3.Children.ManaBar3.Texture)
        Form1.ManaLabel3.Location = New Point(ManaLabel3Bounds(0), ManaLabel3Bounds(1))
        Form1.ManaValue3.Location = New Point(ManaValue3Bounds(0), ManaValue3Bounds(1))
        Form1.KickButton3.Location = New Point(KickButton3Bounds(0), KickButton3Bounds(1))
        Form1.LeavePartyButton.Location = New Point(LeavePartyButtonBounds(0), LeavePartyButtonBounds(1))
        Form1.LeavePartyButton.Width = LeavePartyButtonBounds(2)
        Form1.LeavePartyButton.Height = LeavePartyButtonBounds(3)
        Form1.LeavePartyButton.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.LeavePartyButton.NormalImage)
    End Sub
End Module
