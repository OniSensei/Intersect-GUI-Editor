Imports System.IO
Imports Newtonsoft.Json

Module ItemDescWindowExpandedGUI
    Public Class ItemDescWindowExpanded
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
        Public Property ItemIcon As IntersectIcon
        Public Property ItemNameLabel As IntersectLabel
        Public Property ItemQuantityLabel As IntersectLabel
        Public Property ItemTypeLabel As IntersectLabel
        Public Property ItemValueLabel As IntersectLabel
        Public Property ItemDescription As IntersectBase
        Public Property ItemDescText As IntersectLabel
        Public Property ItemStatsText As IntersectLabel
        Public Property ItemStats As IntersectBase
    End Class

    Public Sub LoadItemDescWindowExpandedGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainItemDescWindowExpandedPanel.Visible = True
        Form1.RefreshBtn.Visible = True
        Form1.gridToggle.Visible = True
        Form1.toolSplitContainer.Panel2.BackColor = Color.Gray
        Form1.toolSplitContainer.Panel2.BackgroundImage = Nothing

        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        Form1.JTokenTreeUserControl1.SetJsonSource(Form1.fullJson.Text)
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New ItemDescWindowExpanded
        infoPull = JsonConvert.DeserializeObject(Of ItemDescWindowExpanded)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     ItemDescWindowExpanded.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim ItemIconBounds As String() = infoPull.Children.ItemIcon.Bounds.Split(",")
        Dim ItemQuantityLabelBounds As String() = infoPull.Children.ItemQuantityLabel.Bounds.Split(",")
        Dim ItemTypeLabelBounds As String() = infoPull.Children.ItemTypeLabel.Bounds.Split(",")
        Dim ItemValueLabelBounds As String() = infoPull.Children.ItemValueLabel.Bounds.Split(",")
        Dim ItemDescriptionBounds As String() = infoPull.Children.ItemDescription.Bounds.Split(",")
        Dim ItemStatsTextBounds As String() = infoPull.Children.ItemStatsText.Bounds.Split(",")
        Dim ItemStatsBounds As String() = infoPull.Children.ItemStats.Bounds.Split(",")

        Form1.MainItemDescWindowExpandedPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainItemDescWindowExpandedPanel.Width = mainwindowbounds(2)
        Form1.MainItemDescWindowExpandedPanel.Height = mainwindowbounds(3)
        Form1.MainItemDescWindowExpandedPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.ItemDescExpandedItemIcon.Location = New Point(ItemIconBounds(0), ItemIconBounds(1))
        Form1.ItemDescExpandedItemIcon.Width = ItemIconBounds(2)
        Form1.ItemDescExpandedItemIcon.Height = ItemIconBounds(3)
        Form1.ItemDescExpandedItemIcon.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\potion.png")
        Form1.ItemDescExpandedItemQuantity.Location = New Point(ItemQuantityLabelBounds(0), ItemQuantityLabelBounds(1))
        Form1.ItemDescExpandedItemTypeLabel.Location = New Point(ItemTypeLabelBounds(0), ItemTypeLabelBounds(1))
        Form1.ItemDescExpandedItemValueLabel.Location = New Point(ItemValueLabelBounds(0), ItemValueLabelBounds(1))
        Form1.ItemDescExpandedItemDescription.Location = New Point(ItemDescriptionBounds(0), ItemDescriptionBounds(1))
        Form1.ItemDescExpandedItemDescription.Width = ItemDescriptionBounds(2)
        Form1.ItemDescExpandedItemDescription.Height = ItemDescriptionBounds(3)
        Form1.ItemDescItemStatsText.Location = New Point(ItemStatsTextBounds(0), ItemStatsTextBounds(1))
        Form1.ItemDescExpandedItemStats.Location = New Point(ItemStatsBounds(0), ItemStatsBounds(1))
        Form1.ItemDescExpandedItemStats.Width = ItemStatsBounds(2)
        Form1.ItemDescExpandedItemStats.Height = ItemStatsBounds(3)
    End Sub
End Module
