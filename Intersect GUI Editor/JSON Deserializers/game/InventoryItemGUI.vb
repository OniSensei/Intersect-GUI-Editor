Imports System.IO
Imports Newtonsoft.Json

Module InventoryItemGUI
    Public Class InventoryItem
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
        Public Property InventoryItemIcon As InventoryItemIcon
        Public Property InventoryItemValue As IntersectLabel
    End Class

    Public Class InventoryItemIcon
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
        Public Property Children As InventoryItemIconChildren
    End Class

    Public Class InventoryItemIconChildren
        Public Property InventoryItemEquippedIcon As IntersectIcon
        Public Property InventoryItemEquippedLabel As IntersectLabel
        Public Property InventoryItemCooldownLabel As IntersectLabel
    End Class


    Public Sub LoadInventoryItemGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainInventoryItemPanel.Visible = True
        Form1.RefreshBtn.Visible = True
        Form1.gridToggle.Visible = True
        Form1.toolSplitContainer.Panel2.BackColor = Color.Gray
        Form1.toolSplitContainer.Panel2.BackgroundImage = Nothing

        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        Form1.JTokenTreeUserControl1.SetJsonSource(Form1.fullJson.Text)
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New InventoryItem
        infoPull = JsonConvert.DeserializeObject(Of InventoryItem)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     InventoryItem.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim InventoryItemIconBounds As String() = infoPull.Children.InventoryItemIcon.Bounds.Split(",")
        Dim InventoryItemEquippedLabelBounds As String() = infoPull.Children.InventoryItemIcon.Children.InventoryItemEquippedLabel.Bounds.Split(",")
        Dim InventoryItemCooldownLabelBounds As String() = infoPull.Children.InventoryItemIcon.Children.InventoryItemCooldownLabel.Bounds.Split(",")
        Dim InventoryItemValueBounds As String() = infoPull.Children.InventoryItemValue.Bounds.Split(",")

        Form1.MainInventoryItemPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainBagItemPanel.Width = mainwindowbounds(2)
        Form1.MainBagItemPanel.Height = mainwindowbounds(3)
        Form1.MainBagItemPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.InventoryItemIcon.Location = New Point(InventoryItemIconBounds(0), InventoryItemIconBounds(1))
        Form1.InventoryItemIcon.Width = InventoryItemIconBounds(2)
        Form1.InventoryItemIcon.Height = InventoryItemIconBounds(3)
        Form1.InventoryItemIcon.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\itemIcon.png")
        Form1.InventoryItemValue.Location = New Point(InventoryItemValueBounds(0), InventoryItemValueBounds(1))
        Form1.InventoryItemEquippedLabel.Location = New Point(InventoryItemEquippedLabelBounds(0), InventoryItemEquippedLabelBounds(1))
        Form1.InventoryItemCooldownLabel.Location = New Point(InventoryItemCooldownLabelBounds(0), InventoryItemCooldownLabelBounds(1))
    End Sub
End Module
