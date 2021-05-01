Imports System.IO
Imports Newtonsoft.Json

Module BagItemGUI
    Public Class BagItem
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
        Public Property BagItemIcon As IntersectIcon
        Public Property BagItemValue As IntersectLabel
    End Class

    Public Sub LoadBagItemGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainBagItemPanel.Visible = True
        Form1.RefreshBtn.Visible = True
        Form1.gridToggle.Visible = True
        Form1.toolSplitContainer.Panel2.BackColor = Color.Gray
        Form1.toolSplitContainer.Panel2.BackgroundImage = Nothing

        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        Form1.JTokenTreeUserControl1.SetJsonSource(Form1.fullJson.Text)
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New BagItem
        infoPull = JsonConvert.DeserializeObject(Of BagItem)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     BagItem.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim BagItemIconBounds As String() = infoPull.Children.BagItemIcon.Bounds.Split(",")
        Dim BagItemValueBounds As String() = infoPull.Children.BagItemValue.Bounds.Split(",")

        Form1.MainBagItemPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainBagItemPanel.Width = mainwindowbounds(2)
        Form1.MainBagItemPanel.Height = mainwindowbounds(3)
        Form1.MainBagItemPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.BagItemIcon.Location = New Point(BagItemIconBounds(0), BagItemIconBounds(1))
        Form1.BagItemIcon.Width = BagItemIconBounds(2)
        Form1.BagItemIcon.Height = BagItemIconBounds(3)
        Form1.BagItemIcon.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\itemIcon.png")
        Form1.BagItemValue.Location = New Point(BagItemValueBounds(0), BagItemValueBounds(1))

        Form1.StatusText("[MAIN]     Visual Window Updated")
    End Sub
End Module
