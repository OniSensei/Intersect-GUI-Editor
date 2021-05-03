Imports System.IO
Imports Newtonsoft.Json

Module CharacterCreationWindowGUI
    Public Class CharacterCreationWindow
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
        Public Property CharacterCreationheader As IntersectLabel
        Public Property CharacterNamePanel As CharacterNamePanel
        Public Property ClassPanel As CharWindowClassPanel
        Public Property HintLabel As IntersectLabel
        Public Property Hint2Label As IntersectLabel
        Public Property CharacterContainer As CharacterContainer
        Public Property GenderPanel As GenderPanel
        Public Property CreateButton As IntersectButton
        Public Property BackButton As IntersectButton

    End Class

    Public Class CharacterNamePanel
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
        Public Property Children As CharacterNamePanelChildren
    End Class

    Public Class CharacterNamePanelChildren
        Public Property CharacterNameLabel As IntersectLabel
        Public Property CharacterNameField As IntersectField
    End Class

    Public Class CharWindowClassPanel
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
        Public Property Children As ClassPanelChildren
    End Class

    Public Class ClassPanelChildren
        Public Property ClassLabel As IntersectLabel
        Public Property ClassCombobox As ClassCombobox
    End Class

    Public Class ClassCombobox
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
        Public Property BackgroundTemplate As String
        Public Property TextColor As String
        Public Property HoverTextColor As String
        Public Property ClickedTextColor As String
        Public Property DisabledTextColor As String
        Public Property TextAlign As String
        Public Property TextPadding As String
        Public Property AutoSizeToContents As Boolean
        Public Property Font As String
        Public Property TextScale As Double
        Public Property NormalImage As String
        Public Property HoveredImage As String
        Public Property ClickedImage As String
        Public Property DisabledImage As String
        Public Property CenterImage As Boolean
        Public Property MenuAbove As Boolean
        Public Property Menu As ClassComboboxMenu
        Public Property DropDownButton As ClassComboboxDropDownButton
        Public Property OpenMenuSound As String
        Public Property CloseMenuSound As String
        Public Property HoverMenuSound As String
        Public Property ItemHoverSound As String
        Public Property SelectItemSound As String
    End Class

    Public Class ClassComboboxMenu
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
        Public Property BackgroundTemplate As String
        Public Property ItemTextColor As String
        Public Property ItemHoveredTextColor As String
        Public Property ItemFont As String

    End Class

    Public Class ClassComboboxDropDownButton
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
    End Class

    Public Class CharacterContainer
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
        Public Property Children As CharacterContainerChildren
    End Class

    Public Class CharacterContainerChildren
        Public Property CharacterPortait As CharacterPortait
        Public Property NextSpriteButton As IntersectButton
        Public Property PreviousSpriteButton As IntersectButton
    End Class

    Public Class CharacterPortait
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
    End Class

    Public Class GenderPanel
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
        Public Property Children As GenderPanelChildren
    End Class

    Public Class GenderPanelChildren
        Public Property GenderLabel As IntersectLabel
        Public Property MaleCheckbox As MaleCheckbox
        Public Property FemaleCheckBox As FemaleCheckbox
    End Class

    Public Class MaleCheckbox
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
        Public Property Label As IntersectLabel
        Public Property Checkbox As IntersectCheckbox
    End Class

    Public Class FemaleCheckbox
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
        Public Property Label As IntersectLabel
        Public Property Checkbox As IntersectCheckbox
    End Class

    Public Sub LoadCharacterCreationGUI(ByVal jsonfile As String)
        Form1.StatusText("[OPEN]     " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainCharacterCreationPanel.Visible = True
        Form1.RefreshBtn.Visible = True
        Form1.gridToggle.Visible = True
        Form1.SaveToolStripMenuItem.Visible = True
        Form1.toolSplitContainer.Panel2.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\background.png")

        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        Form1.JTokenTreeUserControl1.SetJsonSource(Form1.fullJson.Text)
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New CharacterCreationWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterCreationWindow)(Form1.fullJson.Text)
        Form1.StatusText("[JSON]     CharacterCreationWindow.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim CharacterCreationHeaderBounds As String() = infoPull.Children.CharacterCreationheader.TextPadding.Split(",")
        Dim CharacterNamePanelBounds As String() = infoPull.Children.CharacterNamePanel.Bounds.Split(",")
        Dim CharacterNameLabelBounds As String() = infoPull.Children.CharacterNamePanel.Children.CharacterNameLabel.Bounds.Split(",")
        Dim CharacterNameFieldBounds As String() = infoPull.Children.CharacterNamePanel.Children.CharacterNameField.Bounds.Split(",")
        Dim ClassPanelBounds As String() = infoPull.Children.ClassPanel.Bounds.Split(",")
        Dim ClassLabelBounds As String() = infoPull.Children.ClassPanel.Children.ClassLabel.Bounds.Split(",")
        Dim ClassComboboxBounds As String() = infoPull.Children.ClassPanel.Children.ClassCombobox.Bounds.Split(",")
        Dim HintLabelBounds As String() = infoPull.Children.HintLabel.Bounds.Split(",")
        Dim Hint2LabelBounds As String() = infoPull.Children.Hint2Label.Bounds.Split(",")
        Dim CharacterContainerBounds As String() = infoPull.Children.CharacterContainer.Bounds.Split(",")
        Dim CharacterPortaitBounds As String() = infoPull.Children.CharacterContainer.Children.CharacterPortait.Bounds.Split(",")
        Dim NextSpriteButtonBounds As String() = infoPull.Children.CharacterContainer.Children.NextSpriteButton.Bounds.Split(",")
        Dim PreviousSpriteButtonBounds As String() = infoPull.Children.CharacterContainer.Children.PreviousSpriteButton.Bounds.Split(",")
        Dim GenderPanelBounds As String() = infoPull.Children.GenderPanel.Bounds.Split(",")
        Dim GenderLabelBounds As String() = infoPull.Children.GenderPanel.Children.GenderLabel.Bounds.Split(",")
        Dim MaleCheckboxPanelBounds As String() = infoPull.Children.GenderPanel.Children.MaleCheckbox.Bounds.Split(",")
        Dim MaleCheckboxLabelBounds As String() = infoPull.Children.GenderPanel.Children.MaleCheckbox.Label.Bounds.Split(",")
        Dim MaleCheckboxCheckboxBounds As String() = infoPull.Children.GenderPanel.Children.MaleCheckbox.Checkbox.Bounds.Split(",")
        Dim FemaleCheckboxPanelBounds As String() = infoPull.Children.GenderPanel.Children.FemaleCheckBox.Bounds.Split(",")
        Dim FemaleCheckboxLabelBounds As String() = infoPull.Children.GenderPanel.Children.FemaleCheckBox.Label.Bounds.Split(",")
        Dim FemaleCheckboxCheckboxBounds As String() = infoPull.Children.GenderPanel.Children.FemaleCheckBox.Checkbox.Bounds.Split(",")
        Dim CreateButtonBounds As String() = infoPull.Children.CreateButton.Bounds.Split(",")
        Dim BackButtonBounds As String() = infoPull.Children.BackButton.Bounds.Split(",")

        Form1.MainCharacterCreationPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainCharacterCreationPanel.Width = mainwindowbounds(2)
        Form1.MainCharacterCreationPanel.Height = mainwindowbounds(3)
        Form1.MainCharacterCreationPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.CharacterCreationHeader.Location = New Point(CharacterCreationHeaderBounds(0), CharacterCreationHeaderBounds(1))
        Form1.CharacterNamePanel.Location = New Point(CharacterNamePanelBounds(0), CharacterNamePanelBounds(1))
        Form1.CharacterNamePanel.Width = CharacterNamePanelBounds(2)
        Form1.CharacterNamePanel.Height = CharacterNamePanelBounds(3)
        Form1.CharacterNamePanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.CharacterNamePanel.Texture)
        Form1.CharacterNameLabel.Location = New Point(CharacterNameLabelBounds(0), CharacterNameLabelBounds(1))
        Form1.CharacterNameField.Location = New Point(CharacterNameFieldBounds(0), CharacterNameFieldBounds(1))
        Form1.CharacterNameField.Width = CharacterNameFieldBounds(2)
        Form1.CharacterNameField.Height = CharacterNameFieldBounds(3)
        Form1.ClassPanel.Location = New Point(ClassPanelBounds(0), ClassPanelBounds(1))
        Form1.ClassPanel.Width = ClassPanelBounds(2)
        Form1.ClassPanel.Height = ClassPanelBounds(3)
        Form1.ClassPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.ClassPanel.Texture)
        Form1.ClassLabel.Location = New Point(ClassLabelBounds(0), ClassLabelBounds(1))
        Form1.ClassCombobox.Location = New Point(ClassComboboxBounds(0), ClassComboboxBounds(1))
        Form1.ClassCombobox.Width = ClassComboboxBounds(2)
        Form1.ClassCombobox.Height = ClassComboboxBounds(3)
        Form1.HintLabel.Location = New Point(HintLabelBounds(0), HintLabelBounds(1))
        Form1.Hint2Label.Location = New Point(Hint2LabelBounds(0), Hint2LabelBounds(1))
        Form1.CharacterContainer.Location = New Point(CharacterContainerBounds(0), CharacterContainerBounds(1))
        Form1.CharacterContainer.Width = CharacterContainerBounds(2)
        Form1.CharacterContainer.Height = CharacterContainerBounds(3)
        Form1.CharacterContainer.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.CharacterContainer.Texture)
        Form1.CharacterPortait.Location = New Point(CharacterPortaitBounds(0), CharacterPortaitBounds(1))
        Form1.CharacterPortait.Width = CharacterPortaitBounds(2)
        Form1.CharacterPortait.Height = CharacterPortaitBounds(3)
        Form1.CharacterPortait.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\baseMale.png")
        Form1.NextSpriteButton.Location = New Point(NextSpriteButtonBounds(0), NextSpriteButtonBounds(1))
        Form1.NextSpriteButton.Width = NextSpriteButtonBounds(2)
        Form1.NextSpriteButton.Height = NextSpriteButtonBounds(3)
        Form1.NextSpriteButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.CharacterContainer.Children.NextSpriteButton.NormalImage)
        Form1.PreviousSpriteButton.Location = New Point(PreviousSpriteButtonBounds(0), PreviousSpriteButtonBounds(1))
        Form1.PreviousSpriteButton.Width = PreviousSpriteButtonBounds(2)
        Form1.PreviousSpriteButton.Height = PreviousSpriteButtonBounds(3)
        Form1.PreviousSpriteButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.CharacterContainer.Children.PreviousSpriteButton.NormalImage)
        Form1.GenderPanel.Location = New Point(GenderPanelBounds(0), GenderPanelBounds(1))
        Form1.GenderPanel.Width = GenderPanelBounds(2)
        Form1.GenderPanel.Height = GenderPanelBounds(3)
        Form1.GenderLabel.Location = New Point(GenderLabelBounds(0), GenderLabelBounds(1))
        Form1.MaleCheckboxPanel.Location = New Point(MaleCheckboxPanelBounds(0), MaleCheckboxPanelBounds(1))
        Form1.MaleCheckboxPanel.Width = MaleCheckboxPanelBounds(2)
        Form1.MaleCheckboxPanel.Height = MaleCheckboxPanelBounds(3)
        Form1.MaleCheckboxLabel.Location = New Point(MaleCheckboxLabelBounds(0), MaleCheckboxLabelBounds(1))
        Form1.MaleCheckbox.Location = New Point(MaleCheckboxCheckboxBounds(0), MaleCheckboxCheckboxBounds(1))
        Form1.MaleCheckbox.Width = MaleCheckboxCheckboxBounds(2)
        Form1.MaleCheckbox.Height = MaleCheckboxCheckboxBounds(3)
        Form1.MaleCheckbox.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.GenderPanel.Children.MaleCheckbox.Checkbox.NormalImage)
        Form1.FemaleCheckboxPanel.Location = New Point(FemaleCheckboxPanelBounds(0), FemaleCheckboxPanelBounds(1))
        Form1.FemaleCheckboxPanel.Width = FemaleCheckboxPanelBounds(2)
        Form1.FemaleCheckboxPanel.Height = FemaleCheckboxPanelBounds(3)
        Form1.FemaleCheckboxLabel.Location = New Point(FemaleCheckboxLabelBounds(0), FemaleCheckboxLabelBounds(1))
        Form1.FemaleCheckbox.Location = New Point(FemaleCheckboxCheckboxBounds(0), FemaleCheckboxCheckboxBounds(1))
        Form1.FemaleCheckbox.Width = FemaleCheckboxCheckboxBounds(2)
        Form1.FemaleCheckbox.Height = FemaleCheckboxCheckboxBounds(3)
        Form1.FemaleCheckbox.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.GenderPanel.Children.FemaleCheckBox.Checkbox.NormalImage)
        Form1.CreateButton.Location = New Point(CreateButtonBounds(0), CreateButtonBounds(1))
        Form1.CreateButton.Width = CreateButtonBounds(2)
        Form1.CreateButton.Height = CreateButtonBounds(3)
        Form1.CreateButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.CreateButton.NormalImage)
        Form1.CharCreateBackButton.Location = New Point(BackButtonBounds(0), BackButtonBounds(1))
        Form1.CharCreateBackButton.Width = BackButtonBounds(2)
        Form1.CharCreateBackButton.Height = BackButtonBounds(3)
        Form1.CharCreateBackButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.BackButton.NormalImage)
    End Sub
End Module
