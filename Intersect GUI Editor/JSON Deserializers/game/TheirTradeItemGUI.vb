Imports System.IO
Imports Newtonsoft.Json

Module TheirTradeItemGUI
    Public Class TheirTradeItem
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
        Public Property Children As Children
    End Class

    Public Class Children
        Public Property TradeIcon As TradeIcon
        Public Property TradeValue As IntersectLabel
    End Class

    Public Class TradeIcon
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
    End Class

    Public Sub LoadTheirTradeItemGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainTheirTradeItemPanel.Visible = True
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
        Dim infoPull As New TheirTradeItem
        infoPull = JsonConvert.DeserializeObject(Of TheirTradeItem)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     TheirTradeItem.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim TradeIconBounds As String() = infoPull.Children.TradeIcon.Bounds.Split(",")
        Dim TradeValueBounds As String() = infoPull.Children.TradeValue.Bounds.Split(",")

        Form1.MainTheirTradeItemPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainTheirTradeItemPanel.Width = mainwindowbounds(2)
        Form1.MainTheirTradeItemPanel.Height = mainwindowbounds(3)
        Form1.MainTheirTradeItemPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.TheirTradeItemTradeIcon.Location = New Point(TradeIconBounds(0), TradeIconBounds(1))
        Form1.TheirTradeItemTradeIcon.Width = TradeIconBounds(2)
        Form1.TheirTradeItemTradeIcon.Height = TradeIconBounds(3)
        Form1.TheirTradeItemTradeIcon.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\armor.png")
        Form1.TheirTradeItemTradeValue.Location = New Point(TradeValueBounds(0), TradeValueBounds(1))
    End Sub

    Public Sub UpdateTheirTradeItemGUI(ByVal jsonfile As String)
        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New TheirTradeItem
        infoPull = JsonConvert.DeserializeObject(Of TheirTradeItem)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     TheirTradeItem.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim TradeIconBounds As String() = infoPull.Children.TradeIcon.Bounds.Split(",")
        Dim TradeValueBounds As String() = infoPull.Children.TradeValue.Bounds.Split(",")

        Form1.MainTheirTradeItemPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainTheirTradeItemPanel.Width = mainwindowbounds(2)
        Form1.MainTheirTradeItemPanel.Height = mainwindowbounds(3)
        Form1.MainTheirTradeItemPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.TheirTradeItemTradeIcon.Location = New Point(TradeIconBounds(0), TradeIconBounds(1))
        Form1.TheirTradeItemTradeIcon.Width = TradeIconBounds(2)
        Form1.TheirTradeItemTradeIcon.Height = TradeIconBounds(3)
        Form1.TheirTradeItemTradeIcon.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\armor.png")
        Form1.TheirTradeItemTradeValue.Location = New Point(TradeValueBounds(0), TradeValueBounds(1))
    End Sub
End Module
