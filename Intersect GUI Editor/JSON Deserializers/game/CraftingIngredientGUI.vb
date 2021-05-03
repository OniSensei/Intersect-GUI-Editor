Imports System.IO
Imports Newtonsoft.Json

Module CraftingIngredientGUI
    Public Class CraftingIngredient
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
        Public Property IngredientItemIcon As IntersectIcon
        Public Property IngredientItemValue As IntersectLabel
    End Class

    Public Sub LoadCraftingIngredientGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainCraftingIngredientPanel.Visible = True
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
        Dim infoPull As New CraftingIngredient
        infoPull = JsonConvert.DeserializeObject(Of CraftingIngredient)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     CraftingIngredient.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim IngredientItemIconBounds As String() = infoPull.Children.IngredientItemIcon.Bounds.Split(",")
        Dim IngredientItemValueBounds As String() = infoPull.Children.IngredientItemValue.Bounds.Split(",")

        Form1.MainCraftingIngredientPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainCraftingIngredientPanel.Width = mainwindowbounds(2)
        Form1.MainCraftingIngredientPanel.Height = mainwindowbounds(3)
        Form1.MainCraftingIngredientPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.IngredientItemIcon.Location = New Point(IngredientItemIconBounds(0), IngredientItemIconBounds(1))
        Form1.IngredientItemIcon.Width = IngredientItemIconBounds(2)
        Form1.IngredientItemIcon.Height = IngredientItemIconBounds(3)
        Form1.IngredientItemIcon.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\itemIcon.png")
        Form1.IngredientItemValue.Location = New Point(IngredientItemValueBounds(0), IngredientItemValueBounds(1))
        Form1.IngredientItemValue.Width = IngredientItemValueBounds(2)
        Form1.IngredientItemValue.Height = IngredientItemValueBounds(3)
    End Sub
End Module
