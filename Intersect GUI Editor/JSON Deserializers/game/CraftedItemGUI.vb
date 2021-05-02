Imports System.IO
Imports Newtonsoft.Json

Module CraftedItemGUI
    Public Class CraftedItem
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
        Public Property CraftedItemIcon As IntersectIcon
        Public Property CraftedItemQuantity As IntersectLabel
    End Class

    Public Sub LoadCraftedItemGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainCraftedItemPanel.Visible = True
        Form1.RefreshBtn.Visible = True
        Form1.gridToggle.Visible = True
        Form1.toolSplitContainer.Panel2.BackColor = Color.Gray
        Form1.toolSplitContainer.Panel2.BackgroundImage = Nothing

        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        Form1.JTokenTreeUserControl1.SetJsonSource(Form1.fullJson.Text)
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New CraftedItem
        infoPull = JsonConvert.DeserializeObject(Of CraftedItem)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     CraftedItem.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim CraftedItemIconBounds As String() = infoPull.Children.CraftedItemIcon.Bounds.Split(",")
        Dim CraftedItemQuantityBounds As String() = infoPull.Children.CraftedItemQuantity.Bounds.Split(",")

        Form1.MainCraftedItemPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainCraftedItemPanel.Width = mainwindowbounds(2)
        Form1.MainCraftedItemPanel.Height = mainwindowbounds(3)
        Form1.MainCraftedItemPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.CraftedItemIcon.Location = New Point(CraftedItemIconBounds(0), CraftedItemIconBounds(1))
        Form1.CraftedItemIcon.Width = CraftedItemIconBounds(2)
        Form1.CraftedItemIcon.Height = CraftedItemIconBounds(3)
        Form1.CraftedItemIcon.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\itemIcon.png")
        Form1.CraftedItemQuantity.Location = New Point(CraftedItemQuantityBounds(0), CraftedItemQuantityBounds(1))

        
    End Sub
End Module
