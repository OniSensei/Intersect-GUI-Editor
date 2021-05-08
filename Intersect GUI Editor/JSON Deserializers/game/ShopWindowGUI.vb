Imports System.IO
Imports Newtonsoft.Json

Module ShopWindowGUI
    Public Class ShopWindow
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
        Public Property InnerPanel As ShopWindowInnerPanel
    End Class

    Public Class ShopWindowInnerPanel
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
        Public Property Children As ShopWindowInnerPanelChildren
    End Class

    Public Class ShopWindowInnerPanelChildren
        Public Property ItemContainer As IntersectContainer
    End Class

    Public Sub LoadShopWindowGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainShopWindowPanel.Visible = True
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
        Dim infoPull As New ShopWindow
        infoPull = JsonConvert.DeserializeObject(Of ShopWindow)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     ShopWindow.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim TitleBounds As String() = infoPull.Title.Padding.Split(",")
        Dim CloseButtonBounds As String() = infoPull.CloseButton.Bounds.Split(",")

        Form1.MainShopWindowPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainShopWindowPanel.Width = mainwindowbounds(2)
        Form1.MainShopWindowPanel.Height = mainwindowbounds(3)
        Form1.MainShopWindowPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.ActiveImage)
        Form1.ShopWindowTitle.Location = New Point(TitleBounds(0), TitleBounds(1))
        Form1.ShopWindowCloseButton.Location = New Point(CloseButtonBounds(0), CloseButtonBounds(1))
        Form1.ShopWindowCloseButton.Width = CloseButtonBounds(2)
        Form1.ShopWindowCloseButton.Height = CloseButtonBounds(3)
        Form1.ShopWindowCloseButton.BackgroundImage = Image.FromFile(imgResources & infoPull.CloseButton.NormalImage)
    End Sub

    Public Sub UpdateShopWindowGUI(ByVal jsonfile As String)
        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New ShopWindow
        infoPull = JsonConvert.DeserializeObject(Of ShopWindow)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     ShopWindow.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim TitleBounds As String() = infoPull.Title.Padding.Split(",")
        Dim CloseButtonBounds As String() = infoPull.CloseButton.Bounds.Split(",")

        Form1.MainShopWindowPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainShopWindowPanel.Width = mainwindowbounds(2)
        Form1.MainShopWindowPanel.Height = mainwindowbounds(3)
        Form1.MainShopWindowPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.ActiveImage)
        Form1.ShopWindowTitle.Location = New Point(TitleBounds(0), TitleBounds(1))
        Form1.ShopWindowCloseButton.Location = New Point(CloseButtonBounds(0), CloseButtonBounds(1))
        Form1.ShopWindowCloseButton.Width = CloseButtonBounds(2)
        Form1.ShopWindowCloseButton.Height = CloseButtonBounds(3)
        Form1.ShopWindowCloseButton.BackgroundImage = Image.FromFile(imgResources & infoPull.CloseButton.NormalImage)
    End Sub
End Module
