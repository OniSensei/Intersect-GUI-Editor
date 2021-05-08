Imports System.IO
Imports Newtonsoft.Json

Module ShopItemGUI
    Public Class ShopItem
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
        Public Property ShopItemIcon As IntersectIcon
    End Class

    Public Sub LoadShopItemGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainShopItemPanel.Visible = True
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
        Dim infoPull As New ShopItem
        infoPull = JsonConvert.DeserializeObject(Of ShopItem)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     ShopItem.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim ShopItemIconBounds As String() = infoPull.Children.ShopItemIcon.Bounds.Split(",")

        Form1.MainShopItemPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainShopItemPanel.Width = mainwindowbounds(2)
        Form1.MainShopItemPanel.Height = mainwindowbounds(3)
        Form1.MainShopItemPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.ShopItemIcon.Location = New Point(ShopItemIconBounds(0), ShopItemIconBounds(1))
        Form1.ShopItemIcon.Width = ShopItemIconBounds(2)
        Form1.ShopItemIcon.Height = ShopItemIconBounds(3)
        Form1.ShopItemIcon.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\potion.png")
    End Sub

    Public Sub UpdateShopItemGUI(ByVal jsonfile As String)
        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New ShopItem
        infoPull = JsonConvert.DeserializeObject(Of ShopItem)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     ShopItem.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim ShopItemIconBounds As String() = infoPull.Children.ShopItemIcon.Bounds.Split(",")

        Form1.MainShopItemPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainShopItemPanel.Width = mainwindowbounds(2)
        Form1.MainShopItemPanel.Height = mainwindowbounds(3)
        Form1.MainShopItemPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.ShopItemIcon.Location = New Point(ShopItemIconBounds(0), ShopItemIconBounds(1))
        Form1.ShopItemIcon.Width = ShopItemIconBounds(2)
        Form1.ShopItemIcon.Height = ShopItemIconBounds(3)
        Form1.ShopItemIcon.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\potion.png")
    End Sub
End Module
