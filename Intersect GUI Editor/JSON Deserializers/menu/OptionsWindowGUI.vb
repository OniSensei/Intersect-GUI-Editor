Imports System.IO
Imports Newtonsoft.Json

Module OptionsWindowGUI
    Public Class OptionsWindow
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
        Public Property OptionsHeader As OptionsHeader
        Public Property OptionsContainer As OptionsContainer
        Public Property ControlsContainer As ControlsContainer
        Public Property ExitControlsButton As IntersectButton
        Public Property CancelControlsButton As IntersectButton
        Public Property RestoreControlsButton As IntersectButton
    End Class

    Public Class OptionsHeader
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
    End Class

    Public Class OptionsContainer
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
        Public Property InnerPanel As OptionsInnerPanel
        Public Property HorizontalScrollBar As IntersectScrollBar
        Public Property VerticalScrollBar As IntersectScrollBar
    End Class

    Public Class OptionsInnerPanel
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
        Public Property Children As OptionsInnerPanelChildren
    End Class

    Public Class OptionsInnerPanelChildren
        Public Property ResolutionPanel As ResolutionPanel
        Public Property FPSPanel As FPSPanel
        Public Property FullscreenCheckbox As FullscreenCheckbox
        Public Property AutocloseWindowsCheckbox As AutocloseWindowsCheckbox
        Public Property KeybindingsButton As IntersectButton
        Public Property SoundLabel As IntersectLabel
        Public Property SoundSlider As SoundSlider
        Public Property MusicLabel As IntersectLabel
        Public Property MusicSlider As MusicSlider
        Public Property ApplyButton As IntersectButton
        Public Property CancelButton As IntersectButton

    End Class

    Public Class ResolutionPanel
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
        Public Property Children As ResolutionPanelChildren
    End Class

    Public Class ResolutionPanelChildren
        Public Property ResolutionLabel As IntersectLabel
        Public Property ResolutionCombobox As ResolutionCombobox
    End Class

    Public Class ResolutionCombobox
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
        Public Property Menu As ResolutionComboboxMenu
        Public Property DropDownmButton As IntersectButton
        Public Property OpenMenuSound As String
        Public Property CloseMenuSound As String
        Public Property HoverMenuSound As String
        Public Property ItemHoverSound As String
        Public Property SelectItemSound As String
    End Class

    Public Class ResolutionComboboxMenu
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
    End Class

    Public Class FPSPanel
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
        Public Property Children As FPSPanelChildren
    End Class

    Public Class FPSPanelChildren
        Public Property FPSLabel As IntersectLabel
        Public Property FPSCombobox As FPSCombobox

    End Class

    Public Class FPSCombobox
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
        Public Property Menu As FPSComboboxMenu
        Public Property DropDownmButton As IntersectButton
        Public Property OpenMenuSound As String
        Public Property CloseMenuSound As String
        Public Property HoverMenuSound As String
        Public Property ItemHoverSound As String
        Public Property SelectItemSound As String
    End Class

    Public Class FPSComboboxMenu
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
    End Class


    Public Class FullscreenCheckbox
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

    Public Class AutocloseWindowsCheckbox
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

    Public Class SoundSlider
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
        Public Property BackgroundImage As String
        Public Property SnapToNotchs As Boolean
        Public Property NotchCount As Integer
        Public Property SliderBar As IntersectButton
    End Class

    Public Class MusicSlider
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
        Public Property BackgroundImage As String
        Public Property SnapToNotchs As Boolean
        Public Property NotchCount As Integer
        Public Property SliderBar As IntersectButton
    End Class

    Public Class ControlsContainer
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
        Public Property InnerPanel As ControlsInnerPanel
        Public Property HorizontalScrollBar As IntersectScrollBar
        Public Property VerticalScrollBar As IntersectScrollBar
    End Class

    Public Class ControlsInnerPanel
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
        Public Property Children As ControlsInnerPanelChildren
    End Class

    Public Class ControlsInnerPanelChildren
        Public Property ControlMoveUpLabel As IntersectLabel
        Public Property ControlMoveUpButton1 As IntersectButton
        Public Property ControlMoveUpButton2 As IntersectButton
        Public Property ControlMoveLeftLabel As IntersectLabel
        Public Property ControlMoveLeftButton1 As IntersectButton
        Public Property ControlMoveLeftButton2 As IntersectButton
        Public Property ControlMoveDownLabel As IntersectButton
        Public Property ControlMoveDownButton1 As IntersectButton
        Public Property ControlMoveDownButton2 As IntersectButton
        Public Property ControlMoveRightLabel As IntersectLabel
        Public Property ControlMoveRightButton1 As IntersectButton
        Public Property ControlMoveRightButton2 As IntersectButton
        Public Property ControlAttackInteractLabel As IntersectLabel
        Public Property ControlAttackInteractButton1 As IntersectButton
        Public Property ControlAttackInteractButton2 As IntersectButton
        Public Property ControlBlockLabel As IntersectLabel
        Public Property ControlBlockButton1 As IntersectButton
        Public Property ControlBlockButton2 As IntersectButton
        Public Property ControlAutoTargetLabel As IntersectLabel
        Public Property ControlAutoTargetButton1 As IntersectButton
        Public Property ControlAutoTargetButton2 As IntersectButton
        Public Property ControlPickUpLabel As IntersectLabel
        Public Property ControlPickUpButton1 As IntersectButton
        Public Property ControlPickUpButton2 As IntersectButton
        Public Property ControlEnterLabel As IntersectLabel
        Public Property ControlEnterButton1 As IntersectButton
        Public Property ControlEnterButton2 As IntersectButton
        Public Property ControlHotkey1Label As IntersectLabel
        Public Property ControlHotkey1Button1 As IntersectButton
        Public Property ControlHotkey1Button2 As IntersectButton
        Public Property ControlHotkey2Label As IntersectLabel
        Public Property ControlHotkey2Button1 As IntersectButton
        Public Property ControlHotkey2Button2 As IntersectButton
        Public Property ControlHotkey3Label As IntersectLabel
        Public Property ControlHotkey3Button1 As IntersectButton
        Public Property ControlHotkey3Button2 As IntersectButton
        Public Property ControlHotkey4Label As IntersectLabel
        Public Property ControlHotkey4Button1 As IntersectButton
        Public Property ControlHotkey4Button2 As IntersectButton
        Public Property ControlHotkey5Label As IntersectLabel
        Public Property ControlHotkey5Button1 As IntersectButton
        Public Property ControlHotkey5Button2 As IntersectButton
        Public Property ControlHotkey6Label As IntersectLabel
        Public Property ControlHotkey6Button1 As IntersectButton
        Public Property ControlHotkey6Button2 As IntersectButton
        Public Property ControlHotkey7Label As IntersectLabel
        Public Property ControlHotkey7Button1 As IntersectButton
        Public Property ControlHotkey7Button2 As IntersectButton
        Public Property ControlHotkey8Label As IntersectLabel
        Public Property ControlHotkey8Button1 As IntersectButton
        Public Property ControlHotkey8Button2 As IntersectButton
        Public Property ControlHotkey9Label As IntersectLabel
        Public Property ControlHotkey9Button1 As IntersectButton
        Public Property ControlHotkey9Button2 As IntersectButton
        Public Property ControlHotkey0Label As IntersectLabel
        Public Property ControlHotkey0Button1 As IntersectButton
        Public Property ControlHotkey0Button2 As IntersectButton
        Public Property ControlScreenshotLabel As IntersectLabel
        Public Property ControlScreenshotButton1 As IntersectButton
        Public Property ControlScreenshotButton2 As IntersectButton
        Public Property ControlOpenMenuLabel As IntersectLabel
        Public Property ControlOpenMenuButton1 As IntersectButton
        Public Property ControlOpenMenuButton2 As IntersectButton
        Public Property ControlOpenInventoryLabel As IntersectLabel
        Public Property ControlOpenInventoryButton1 As IntersectButton
        Public Property ControlOpenInventoryButton2 As IntersectButton
        Public Property ControlOpenQuestsLabel As IntersectLabel
        Public Property ControlOpenQuestsButton1 As IntersectButton
        Public Property ControlOpenQuestsButton2 As IntersectButton
        Public Property ControlOpenCharacterInfoLabel As IntersectLabel
        Public Property ControlOpenCharacterInfoButton1 As IntersectButton
        Public Property ControlOpenCharacterInfoButton2 As IntersectButton
        Public Property ControlOpenPartiesLabel As IntersectLabel
        Public Property ControlOpenPartiesButton1 As IntersectButton
        Public Property ControlOpenPartiesButton2 As IntersectButton
        Public Property ControlOpenSpellsLabel As IntersectLabel
        Public Property ControlOpenSpellsButton1 As IntersectButton
        Public Property ControlOpenSpellsButton2 As IntersectButton
        Public Property ControlOpenFriendsLabel As IntersectLabel
        Public Property ControlOpenFriendsButton1 As IntersectButton
        Public Property ControlOpenFriendsButton2 As IntersectButton
        Public Property ControlOpenSettingsLabel As IntersectLabel
        Public Property ControlOpenSettingsButton1 As IntersectButton
        Public Property ControlOpenSettingsButton2 As IntersectButton
        Public Property ControlOpenDebuggerLabel As IntersectLabel
        Public Property ControlOpenDebuggerButton1 As IntersectButton
        Public Property ControlOpenDebuggerButton2 As IntersectButton
        Public Property ControlOpenAdminPanelLabel As IntersectLabel
        Public Property ControlOpenAdminPanelButton1 As IntersectButton
        Public Property ControlOpenAdminPanelButton2 As IntersectButton
        Public Property ControlToggleGuiLabel As IntersectLabel
        Public Property ControlToggleGuiButton1 As IntersectButton
        Public Property ControlToggleGuiButton2 As IntersectButton
    End Class

    Public Sub LoadOptionsWindowGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainOptionsWindowPanel.Visible = True
        Form1.RefreshBtn.Visible = True
        Form1.gridToggle.Visible = True
        Form1.toolSplitContainer.Panel2.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\background.png")

        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        Form1.JTokenTreeUserControl1.SetJsonSource(Form1.fullJson.Text)
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     OptionsWindow.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim OptionsHeaderBounds As String() = infoPull.Children.OptionsHeader.TextPadding.Split(",")
        Dim OptionsContainerBounds As String() = infoPull.Children.OptionsContainer.Bounds.Split(",")
        Dim ResolutionPanelBounds As String() = infoPull.Children.OptionsContainer.InnerPanel.Children.ResolutionPanel.Bounds.Split(",")
        Dim ResolutionLabelBounds As String() = infoPull.Children.OptionsContainer.InnerPanel.Children.ResolutionPanel.Children.ResolutionLabel.Bounds.Split(",")
        Dim ResolutionComboboxBounds As String() = infoPull.Children.OptionsContainer.InnerPanel.Children.ResolutionPanel.Children.ResolutionCombobox.Bounds.Split(",")
        Dim FPSPanelBounds As String() = infoPull.Children.OptionsContainer.InnerPanel.Children.FPSPanel.Bounds.Split(",")
        Dim FPSLabelBounds As String() = infoPull.Children.OptionsContainer.InnerPanel.Children.FPSPanel.Children.FPSLabel.Bounds.Split(",")
        Dim FPSComboboxBounds As String() = infoPull.Children.OptionsContainer.InnerPanel.Children.FPSPanel.Children.FPSCombobox.Bounds.Split(",")
        Dim FullscreenCheckboxBounds As String() = infoPull.Children.OptionsContainer.InnerPanel.Children.FullscreenCheckbox.Bounds.Split(",")
        Dim FullscreenCheckboxLabelBounds As String() = infoPull.Children.OptionsContainer.InnerPanel.Children.FullscreenCheckbox.Label.Bounds.Split(",")
        Dim FullscreenCheckboxCheckboxBounds As String() = infoPull.Children.OptionsContainer.InnerPanel.Children.FullscreenCheckbox.Checkbox.Bounds.Split(",")
        Dim AutocloseWindowsCheckboxBounds As String() = infoPull.Children.OptionsContainer.InnerPanel.Children.AutocloseWindowsCheckbox.Bounds.Split(",")
        Dim AutocloseWindowsCheckboxLabelBounds As String() = infoPull.Children.OptionsContainer.InnerPanel.Children.AutocloseWindowsCheckbox.Label.Bounds.Split(",")
        Dim AutocloseWindowsCheckboxCheckboxBounds As String() = infoPull.Children.OptionsContainer.InnerPanel.Children.AutocloseWindowsCheckbox.Checkbox.Bounds.Split(",")
        Dim KeybindingsButtonBounds As String() = infoPull.Children.OptionsContainer.InnerPanel.Children.KeybindingsButton.Bounds.Split(",")
        Dim SoundLabelBounds As String() = infoPull.Children.OptionsContainer.InnerPanel.Children.SoundLabel.Bounds.Split(",")
        Dim SoundSliderBounds As String() = infoPull.Children.OptionsContainer.InnerPanel.Children.SoundSlider.Bounds.Split(",")
        Dim SoundSliderBarBounds As String() = infoPull.Children.OptionsContainer.InnerPanel.Children.SoundSlider.SliderBar.Bounds.Split(",")
        Dim MusicLabelBounds As String() = infoPull.Children.OptionsContainer.InnerPanel.Children.MusicLabel.Bounds.Split(",")
        Dim MusicSliderBounds As String() = infoPull.Children.OptionsContainer.InnerPanel.Children.MusicSlider.Bounds.Split(",")
        Dim MusicSliderBarBounds As String() = infoPull.Children.OptionsContainer.InnerPanel.Children.MusicSlider.SliderBar.Bounds.Split(",")
        Dim ApplyButtonBounds As String() = infoPull.Children.OptionsContainer.InnerPanel.Children.ApplyButton.Bounds.Split(",")
        Dim CancelButtonBounds As String() = infoPull.Children.OptionsContainer.InnerPanel.Children.CancelButton.Bounds.Split(",")
        Dim ControlsContainerInnerPanelBounds As String() = infoPull.Children.ControlsContainer.InnerPanel.Bounds.Split(",")
        Dim ExitControlsButtonBounds As String() = infoPull.Children.ExitControlsButton.Bounds.Split(",")
        Dim CancelControlsButtonBounds As String() = infoPull.Children.CancelControlsButton.Bounds.Split(",")
        Dim RestoreControlsButtonBounds As String() = infoPull.Children.RestoreControlsButton.Bounds.Split(",")

        Form1.MainOptionsWindowPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainOptionsWindowPanel.Width = mainwindowbounds(2)
        Form1.MainOptionsWindowPanel.Height = mainwindowbounds(3)
        Form1.MainOptionsWindowPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.OptionsHeader.Location = New Point(OptionsHeaderBounds(0), OptionsHeaderBounds(1))
        Form1.OptionsHeader.Width = OptionsHeaderBounds(2)
        Form1.OptionsHeader.Height = OptionsHeaderBounds(3)
        Form1.OptionsContainer.Location = New Point(OptionsContainerBounds(0), OptionsContainerBounds(1))
        Form1.OptionsContainer.Width = OptionsContainerBounds(2)
        Form1.OptionsContainer.Height = OptionsContainerBounds(3)
        Form1.ResolutionPanel.Location = New Point(ResolutionPanelBounds(0), ResolutionPanelBounds(1))
        Form1.ResolutionPanel.Width = ResolutionPanelBounds(2)
        Form1.ResolutionPanel.Height = ResolutionPanelBounds(3)
        Form1.ResolutionPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.OptionsContainer.InnerPanel.Children.ResolutionPanel.Texture)
        Form1.ResolutionLabel.Location = New Point(ResolutionLabelBounds(0), ResolutionLabelBounds(1))
        Form1.ResolutionCombobox.Location = New Point(ResolutionComboboxBounds(0), ResolutionComboboxBounds(1))
        Form1.ResolutionCombobox.Width = ResolutionComboboxBounds(2)
        Form1.ResolutionCombobox.Height = ResolutionComboboxBounds(3)
        Form1.FPSPanel.Location = New Point(FPSPanelBounds(0), FPSPanelBounds(1))
        Form1.FPSPanel.Width = FPSPanelBounds(2)
        Form1.FPSPanel.Height = FPSPanelBounds(3)
        Form1.FPSPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.OptionsContainer.InnerPanel.Children.FPSPanel.Texture)
        Form1.FPSLabel.Location = New Point(FPSLabelBounds(0), FPSLabelBounds(1))
        Form1.FPSCombobox.Location = New Point(FPSComboboxBounds(0), FPSComboboxBounds(1))
        Form1.FPSCombobox.Width = FPSComboboxBounds(2)
        Form1.FPSCombobox.Height = FPSComboboxBounds(3)
        Form1.FullscreenCheckboxPanel.Location = New Point(FullscreenCheckboxBounds(0), FullscreenCheckboxBounds(1))
        Form1.FullscreenCheckboxPanel.Width = FullscreenCheckboxBounds(2)
        Form1.FullscreenCheckboxPanel.Height = FullscreenCheckboxBounds(3)
        Form1.FullscreenCheckboxLabel.Location = New Point(FullscreenCheckboxLabelBounds(0), FullscreenCheckboxLabelBounds(1))
        Form1.FullscreenCheckboxCheckbox.Location = New Point(FullscreenCheckboxCheckboxBounds(0), FullscreenCheckboxCheckboxBounds(1))
        Form1.FullscreenCheckboxCheckbox.Width = FullscreenCheckboxCheckboxBounds(2)
        Form1.FullscreenCheckboxCheckbox.Height = FullscreenCheckboxCheckboxBounds(3)
        Form1.FullscreenCheckboxCheckbox.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.OptionsContainer.InnerPanel.Children.FullscreenCheckbox.Checkbox.CheckedImage)
        Form1.AutocloseWindowsCheckboxPanel.Location = New Point(AutocloseWindowsCheckboxBounds(0), AutocloseWindowsCheckboxBounds(1))
        Form1.AutocloseWindowsCheckboxPanel.Width = AutocloseWindowsCheckboxBounds(2)
        Form1.AutocloseWindowsCheckboxPanel.Height = AutocloseWindowsCheckboxBounds(3)
        Form1.AutocloseWindowsCheckboxLabel.Location = New Point(AutocloseWindowsCheckboxLabelBounds(0), AutocloseWindowsCheckboxLabelBounds(1))
        Form1.AutocloseWindowsCheckboxCheckbox.Location = New Point(AutocloseWindowsCheckboxCheckboxBounds(0), AutocloseWindowsCheckboxCheckboxBounds(1))
        Form1.AutocloseWindowsCheckboxCheckbox.Width = AutocloseWindowsCheckboxCheckboxBounds(2)
        Form1.AutocloseWindowsCheckboxCheckbox.Height = AutocloseWindowsCheckboxCheckboxBounds(3)
        Form1.AutocloseWindowsCheckboxCheckbox.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.OptionsContainer.InnerPanel.Children.AutocloseWindowsCheckbox.Checkbox.NormalImage)
        Form1.SoundLabel.Location = New Point(SoundLabelBounds(0), SoundLabelBounds(1))
        Form1.SoundSlider.Location = New Point(SoundSliderBounds(0), SoundSliderBounds(1))
        Form1.SoundSlider.Width = SoundSliderBounds(2)
        Form1.SoundSlider.Height = SoundSliderBounds(3)
        Form1.SoundSlider.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.OptionsContainer.InnerPanel.Children.SoundSlider.BackgroundImage)
        Form1.SoundSliderBar.Location = New Point(SoundSliderBarBounds(0), SoundSliderBarBounds(1))
        Form1.SoundSliderBar.Width = SoundSliderBarBounds(2)
        Form1.SoundSliderBar.Height = SoundSliderBarBounds(3)
        Form1.SoundSliderBar.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.OptionsContainer.InnerPanel.Children.SoundSlider.SliderBar.NormalImage)
        Form1.MusicLabel.Location = New Point(MusicLabelBounds(0), MusicLabelBounds(1))
        Form1.MusicSlider.Location = New Point(MusicSliderBounds(0), MusicSliderBounds(1))
        Form1.MusicSlider.Width = MusicSliderBounds(2)
        Form1.MusicSlider.Height = MusicSliderBounds(3)
        Form1.MusicSlider.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.OptionsContainer.InnerPanel.Children.MusicSlider.BackgroundImage)
        Form1.MusicSliderBar.Location = New Point(MusicSliderBarBounds(0), MusicSliderBarBounds(1))
        Form1.MusicSliderBar.Width = MusicSliderBarBounds(2)
        Form1.MusicSliderBar.Height = MusicSliderBarBounds(3)
        Form1.MusicSliderBar.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.OptionsContainer.InnerPanel.Children.MusicSlider.SliderBar.NormalImage)
        Form1.OptionsApplyButton.Location = New Point(ApplyButtonBounds(0), ApplyButtonBounds(1))
        Form1.OptionsApplyButton.Width = ApplyButtonBounds(2)
        Form1.OptionsApplyButton.Height = ApplyButtonBounds(3)
        Form1.OptionsApplyButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.OptionsContainer.InnerPanel.Children.ApplyButton.NormalImage)
        Form1.OptionsCancelButton.Location = New Point(CancelButtonBounds(0), CancelButtonBounds(1))
        Form1.OptionsCancelButton.Width = CancelButtonBounds(2)
        Form1.OptionsCancelButton.Height = CancelButtonBounds(3)
        Form1.OptionsCancelButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.OptionsContainer.InnerPanel.Children.CancelButton.NormalImage)
        Form1.MainControlPanelsWindow.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainControlPanelsWindow.Width = mainwindowbounds(2)
        Form1.MainControlPanelsWindow.Height = mainwindowbounds(3)
        Form1.MainControlPanelsWindow.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.ControlsPanelInnerPanel.Location = New Point(ControlsContainerInnerPanelBounds(0), ControlsContainerInnerPanelBounds(1))
        Form1.ControlsPanelInnerPanel.Width = ControlsContainerInnerPanelBounds(2)
        Form1.ControlsPanelInnerPanel.Height = ControlsContainerInnerPanelBounds(3)
        Form1.ExitControlsButton.Location = New Point(ExitControlsButtonBounds(0), ExitControlsButtonBounds(1))
        Form1.ExitControlsButton.Width = ExitControlsButtonBounds(2)
        Form1.ExitControlsButton.Height = ExitControlsButtonBounds(3)
        Form1.ExitControlsButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.ExitControlsButton.NormalImage)
        Form1.CancelControlsButton.Location = New Point(CancelControlsButtonBounds(0), CancelControlsButtonBounds(1))
        Form1.CancelControlsButton.Width = CancelControlsButtonBounds(2)
        Form1.CancelControlsButton.Height = CancelControlsButtonBounds(3)
        Form1.CancelControlsButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.CancelControlsButton.NormalImage)
        Form1.RestoreControlsButton.Location = New Point(RestoreControlsButtonBounds(0), RestoreControlsButtonBounds(1))
        Form1.RestoreControlsButton.Width = RestoreControlsButtonBounds(2)
        Form1.RestoreControlsButton.Height = RestoreControlsButtonBounds(3)
        Form1.RestoreControlsButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.RestoreControlsButton.NormalImage)
        Form1.ControlsHeader.Location = New Point(OptionsHeaderBounds(0), OptionsHeaderBounds(1))
        Form1.ControlsHeader.Width = OptionsHeaderBounds(2)
        Form1.ControlsHeader.Height = OptionsHeaderBounds(3)

        Form1.StatusText("[MAIN]     Visual Window Updated")
    End Sub
End Module
