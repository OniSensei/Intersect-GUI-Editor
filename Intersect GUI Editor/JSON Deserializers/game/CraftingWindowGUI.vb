Imports System.IO
Imports Newtonsoft.Json

Module CraftingWindowGUI
    Public Class CraftingWindow
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
        Public Property InnerPanel As CraftingWindowInnerPanel
    End Class

    Public Class CraftingWindowInnerPanel
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
        Public Property Children As Children
    End Class

    Public Class Children
        Public Property IngredientsContainer As IntersectContainer
        Public Property RecipesTitle As IntersectLabel
        Public Property IngredientsTitle As IntersectLabel
        Public Property ProductLabel As IntersectLabel
        Public Property RecipesList As RecipesList
        Public Property ProgressBarContainer As ProgressBarContainer
        Public Property CraftButton As IntersectButton
    End Class

    Public Class RecipesList
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
        Public Property CanScrollH As Boolean
        Public Property CanScrollV As Boolean
        Public Property AutoHideBars As Boolean
        Public Property InnerPanel As IntersectInnerPanel
        Public Property HorizontalScrollBar As IntersectScrollBar
        Public Property VerticalScrollBar As IntersectScrollBar
        Public Property SizeToContents As Boolean
        Public Property MultiSelect As Boolean
        Public Property IsToggle As Boolean
        Public Property Font As String
        Public Property ItemHoverSound As String
        Public Property ItemClickSound As String
        Public Property ItemRightClickSound As String
    End Class

    Public Class ProgressBarContainer
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
        Public Property Children As ProgressBarContainerChildren
    End Class

    Public Class ProgressBarContainerChildren
        Public Property ProgressBar As IntersectIcon
    End Class

    Public Sub LoadCraftingWindowGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainCraftingWindowPanel.Visible = True
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
        Dim infoPull As New CraftingWindow
        infoPull = JsonConvert.DeserializeObject(Of CraftingWindow)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     CraftingWindow.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim TitleBounds As String() = infoPull.Title.Padding.Split(",")
        Dim CloseButtonBounds As String() = infoPull.CloseButton.Bounds.Split(",")
        Dim IngredientsContainerBounds As String() = infoPull.InnerPanel.Children.IngredientsContainer.Bounds.Split(",")
        Dim RecipesTitleBounds As String() = infoPull.InnerPanel.Children.RecipesTitle.Bounds.Split(",")
        Dim IngredientsTitleBounds As String() = infoPull.InnerPanel.Children.IngredientsTitle.Bounds.Split(",")
        Dim ProductLabelBounds As String() = infoPull.InnerPanel.Children.ProductLabel.Bounds.Split(",")
        Dim ProgressBarContainerBounds As String() = infoPull.InnerPanel.Children.ProgressBarContainer.Bounds.Split(",")
        Dim CraftButtonBounds As String() = infoPull.InnerPanel.Children.CraftButton.Bounds.Split(",")

        Form1.MainCraftingWindowPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainCraftingWindowPanel.Width = mainwindowbounds(2)
        Form1.MainCraftingWindowPanel.Height = mainwindowbounds(3)
        Form1.MainCraftingWindowPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.ActiveImage)
        Form1.CraftingWindowTitle.Location = New Point(TitleBounds(0), TitleBounds(1))
        Form1.CraftingWindowCloseButton.Location = New Point(CloseButtonBounds(0), CloseButtonBounds(1))
        Form1.CraftingWindowCloseButton.Width = CloseButtonBounds(2)
        Form1.CraftingWindowCloseButton.Height = CloseButtonBounds(3)
        Form1.CraftingWindowCloseButton.BackgroundImage = Image.FromFile(imgResources & infoPull.CloseButton.NormalImage)
        Form1.IngredientsContainer.Location = New Point(IngredientsContainerBounds(0), IngredientsContainerBounds(1))
        Form1.IngredientsContainer.Width = IngredientsContainerBounds(2)
        Form1.IngredientsContainer.Height = IngredientsContainerBounds(3)
        Form1.CraftingWindowTitle.Location = New Point(TitleBounds(0), TitleBounds(1))
        Form1.RecipesTitle.Location = New Point(RecipesTitleBounds(0), RecipesTitleBounds(1))
        Form1.IngredientsTitle.Location = New Point(IngredientsTitleBounds(0), IngredientsTitleBounds(1))
        Form1.ProductLabel.Location = New Point(ProductLabelBounds(0), ProductLabelBounds(1))
        Form1.CraftingWindowProgressBar.Location = New Point(ProgressBarContainerBounds(0), ProgressBarContainerBounds(1))
        Form1.CraftingWindowProgressBar.Width = ProgressBarContainerBounds(2)
        Form1.CraftingWindowProgressBar.Height = ProgressBarContainerBounds(3)
        Form1.CraftingWindowProgressBar.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.ProgressBarContainer.Children.ProgressBar.Texture)
    End Sub
End Module
