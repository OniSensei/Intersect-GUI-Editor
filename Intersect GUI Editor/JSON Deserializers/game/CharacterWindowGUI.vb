Imports System.IO
Imports Newtonsoft.Json

Module CharacterWindowGUI
    Public Class CharacterWindow
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
        Public Property Titlebar As CharacterWindowTitlebar
        Public Property Title As IntersectLabel
        Public Property CloseButton As IntersectButton
        Public Property InnerPanel As CharacterWindowInnerPanel
    End Class

    Public Class CharacterWindowTitlebar
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
        Public Property HoverSound As String
        Public Property MouseUpSound As String
        Public Property MouseDownSound As String
    End Class

    Public Class CharacterWindowInnerPanel
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
        Public Property Children As CharacterWindowInnerPanelChildren
    End Class

    Public Class CharacterWindowInnerPanelChildren
        Public Property CharacterNameLabel As IntersectLabel
        Public Property ChatacterInfoLabel As IntersectLabel
        Public Property CharacterContainer As IntersectIcon
        Public Property EquipmentLabel As IntersectLabel
        Public Property StatsLabel As IntersectLabel
        Public Property AttackLabel As IntersectLabel
        Public Property IncreaseAttackButton As IntersectButton
        Public Property DefenseLabel As IntersectLabel
        Public Property IncreaseDefenseButton As IntersectButton
        Public Property SpeedLabel As IntersectLabel
        Public Property IncreaseSpeedButton As IntersectButton
        Public Property AbilityPowerLabel As IntersectLabel
        Public Property IncreaseAbilityPowerButton As IntersectButton
        Public Property MagicResistLabel As IntersectLabel
        Public Property IncreaseMagicResistButton As IntersectButton
        Public Property PointsLabel As IntersectLabel
        Public Property EquipmentItem0 As EquipmentItem0
        Public Property EquipmentItem1 As EquipmentItem1
        Public Property EquipmentItem2 As EquipmentItem2
        Public Property EquipmentItem3 As EquipmentItem3
        Public Property EquipmentItem4 As EquipmentItem4
    End Class

    Public Class EquipmentItem0
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
        Public Property Children As EquipmentItemChildren
    End Class

    Public Class EquipmentItem1
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
        Public Property Children As EquipmentItemChildren
    End Class

    Public Class EquipmentItem2
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
        Public Property Children As EquipmentItemChildren
    End Class

    Public Class EquipmentItem3
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
        Public Property Children As EquipmentItemChildren
    End Class

    Public Class EquipmentItem4
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
        Public Property Children As EquipmentItemChildren
    End Class

    Public Class EquipmentItemChildren
        Public Property EquipmentIcon As IntersectIcon
    End Class
    Public Sub LoadCharacterWindowGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainCharacterWindowPanel.Visible = True
        Form1.RefreshBtn.Visible = True
        Form1.gridToggle.Visible = True
        Form1.toolSplitContainer.Panel2.BackColor = Color.Gray
        Form1.toolSplitContainer.Panel2.BackgroundImage = Nothing

        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        Form1.JTokenTreeUserControl1.SetJsonSource(Form1.fullJson.Text)
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     CharacterWindow.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim TitleBounds As String() = infoPull.Title.Padding.Split(",")
        Dim CloseButtonBounds As String() = infoPull.CloseButton.Bounds.Split(",")
        Dim CharacterNameLabelBounds As String() = infoPull.InnerPanel.Children.CharacterNameLabel.Bounds.Split(",")
        Dim CharacterInfoLabelBounds As String() = infoPull.InnerPanel.Children.ChatacterInfoLabel.Bounds.Split(",")
        Dim CharacterContainerBounds As String() = infoPull.InnerPanel.Children.CharacterContainer.Bounds.Split(",")
        Dim EquipmentLabelBounds As String() = infoPull.InnerPanel.Children.EquipmentLabel.Bounds.Split(",")
        Dim StatsLabelBounds As String() = infoPull.InnerPanel.Children.StatsLabel.Bounds.Split(",")
        Dim AttackLabelBounds As String() = infoPull.InnerPanel.Children.AttackLabel.Bounds.Split(",")
        Dim IncreaseAttackButtonBounds As String() = infoPull.InnerPanel.Children.IncreaseAttackButton.Bounds.Split(",")
        Dim DefenseLabelBounds As String() = infoPull.InnerPanel.Children.DefenseLabel.Bounds.Split(",")
        Dim IncreaseDefenseButtonBounds As String() = infoPull.InnerPanel.Children.IncreaseDefenseButton.Bounds.Split(",")
        Dim SpeedLabelBounds As String() = infoPull.InnerPanel.Children.SpeedLabel.Bounds.Split(",")
        Dim IncreaseSpeedButtonBounds As String() = infoPull.InnerPanel.Children.IncreaseSpeedButton.Bounds.Split(",")
        Dim AbilityPowerLabelBounds As String() = infoPull.InnerPanel.Children.AbilityPowerLabel.Bounds.Split(",")
        Dim IncreaseAbilityPowerButtonBounds As String() = infoPull.InnerPanel.Children.IncreaseAbilityPowerButton.Bounds.Split(",")
        Dim MagicResistLabelBounds As String() = infoPull.InnerPanel.Children.MagicResistLabel.Bounds.Split(",")
        Dim IncreaseMagicResistButtonBounds As String() = infoPull.InnerPanel.Children.IncreaseMagicResistButton.Bounds.Split(",")
        Dim PointsLabelBounds As String() = infoPull.InnerPanel.Children.PointsLabel.Bounds.Split(",")
        Dim EquipmentItem0Bounds As String() = infoPull.InnerPanel.Children.EquipmentItem0.Bounds.Split(",")
        Dim EquipmentIcon0Bounds As String() = infoPull.InnerPanel.Children.EquipmentItem0.Children.EquipmentIcon.Bounds.Split(",")
        Dim EquipmentItem1Bounds As String() = infoPull.InnerPanel.Children.EquipmentItem1.Bounds.Split(",")
        Dim EquipmentIcon1Bounds As String() = infoPull.InnerPanel.Children.EquipmentItem1.Children.EquipmentIcon.Bounds.Split(",")
        Dim EquipmentItem2Bounds As String() = infoPull.InnerPanel.Children.EquipmentItem2.Bounds.Split(",")
        Dim EquipmentIcon2Bounds As String() = infoPull.InnerPanel.Children.EquipmentItem2.Children.EquipmentIcon.Bounds.Split(",")
        Dim EquipmentItem3Bounds As String() = infoPull.InnerPanel.Children.EquipmentItem3.Bounds.Split(",")
        Dim EquipmentIcon3Bounds As String() = infoPull.InnerPanel.Children.EquipmentItem3.Children.EquipmentIcon.Bounds.Split(",")
        Dim EquipmentItem4Bounds As String() = infoPull.InnerPanel.Children.EquipmentItem4.Bounds.Split(",")
        Dim EquipmentIcon4Bounds As String() = infoPull.InnerPanel.Children.EquipmentItem4.Children.EquipmentIcon.Bounds.Split(",")

        Form1.MainCharacterWindowPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainCharacterWindowPanel.Width = mainwindowbounds(2)
        Form1.MainCharacterWindowPanel.Height = mainwindowbounds(3)
        Form1.MainCharacterWindowPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.ActiveImage)
        Form1.CharacterWindowTitle.Location = New Point(TitleBounds(0), TitleBounds(1))
        Form1.CharacterWindowCloseButton.Location = New Point(CloseButtonBounds(0), CloseButtonBounds(1))
        Form1.CharacterWindowCloseButton.Width = CloseButtonBounds(2)
        Form1.CharacterWindowCloseButton.Height = CloseButtonBounds(3)
        Form1.CharacterWindowCloseButton.BackgroundImage = Image.FromFile(imgResources & infoPull.CloseButton.NormalImage)
        Form1.CharacterWindowCharacterNameLabel.Location = New Point(CharacterNameLabelBounds(0), CharacterNameLabelBounds(1))
        Form1.CharacterInfoLabel.Location = New Point(CharacterInfoLabelBounds(0), CharacterInfoLabelBounds(1))
        Form1.CharacterWindowCharacterContainer.Location = New Point(CharacterContainerBounds(0), CharacterContainerBounds(1))
        Form1.CharacterWindowCharacterContainer.Width = CharacterContainerBounds(2)
        Form1.CharacterWindowCharacterContainer.Height = CharacterContainerBounds(3)
        Form1.CharacterWindowCharacterContainer.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\baseMale.png")
        Form1.CharacterWindowEquipmentLabel.Location = New Point(EquipmentLabelBounds(0), EquipmentLabelBounds(1))
        Form1.CharacterWindowStatsLabel.Location = New Point(StatsLabelBounds(0), StatsLabelBounds(1))
        Form1.CharacterWindowAttackLabel.Location = New Point(AttackLabelBounds(0), AttackLabelBounds(1))
        Form1.IncreaseAttackButton.Location = New Point(IncreaseAttackButtonBounds(0), IncreaseAttackButtonBounds(1))
        Form1.IncreaseAttackButton.Width = IncreaseAttackButtonBounds(2)
        Form1.IncreaseAttackButton.Height = IncreaseAttackButtonBounds(3)
        Form1.IncreaseAttackButton.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.IncreaseAttackButton.NormalImage)
        Form1.CharacterWindowDefenseLabel.Location = New Point(DefenseLabelBounds(0), DefenseLabelBounds(1))
        Form1.IncreaseDefenseButton.Location = New Point(IncreaseDefenseButtonBounds(0), IncreaseDefenseButtonBounds(1))
        Form1.IncreaseDefenseButton.Width = IncreaseDefenseButtonBounds(2)
        Form1.IncreaseDefenseButton.Height = IncreaseDefenseButtonBounds(3)
        Form1.IncreaseDefenseButton.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.IncreaseDefenseButton.NormalImage)
        Form1.SpeedLabel.Location = New Point(SpeedLabelBounds(0), SpeedLabelBounds(1))
        Form1.IncreaseSpeedButton.Location = New Point(IncreaseSpeedButtonBounds(0), IncreaseSpeedButtonBounds(1))
        Form1.IncreaseSpeedButton.Width = IncreaseSpeedButtonBounds(2)
        Form1.IncreaseSpeedButton.Height = IncreaseSpeedButtonBounds(3)
        Form1.IncreaseSpeedButton.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.IncreaseSpeedButton.NormalImage)
        Form1.AbilityPowerLabel.Location = New Point(AbilityPowerLabelBounds(0), AbilityPowerLabelBounds(1))
        Form1.IncreaseAbilityPowerButton.Location = New Point(IncreaseAbilityPowerButtonBounds(0), IncreaseAbilityPowerButtonBounds(1))
        Form1.IncreaseAbilityPowerButton.Width = IncreaseAbilityPowerButtonBounds(2)
        Form1.IncreaseAbilityPowerButton.Height = IncreaseAbilityPowerButtonBounds(3)
        Form1.IncreaseAbilityPowerButton.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.IncreaseAbilityPowerButton.NormalImage)
        Form1.MagicResistLabel.Location = New Point(MagicResistLabelBounds(0), MagicResistLabelBounds(1))
        Form1.IncreaseMagicResistButton.Location = New Point(IncreaseMagicResistButtonBounds(0), IncreaseMagicResistButtonBounds(1))
        Form1.IncreaseMagicResistButton.Width = IncreaseMagicResistButtonBounds(2)
        Form1.IncreaseMagicResistButton.Height = IncreaseMagicResistButtonBounds(3)
        Form1.IncreaseMagicResistButton.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.IncreaseMagicResistButton.NormalImage)
        Form1.PointsLabel.Location = New Point(PointsLabelBounds(0), PointsLabelBounds(1))
        Form1.EquipmentItem0.Location = New Point(EquipmentItem0Bounds(0), EquipmentItem0Bounds(1))
        Form1.EquipmentItem0.Width = EquipmentItem0Bounds(2)
        Form1.EquipmentItem0.Height = EquipmentItem0Bounds(3)
        Form1.EquipmentItem0.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.EquipmentItem0.Texture)
        Form1.Equipment0Icon.Location = New Point(EquipmentIcon0Bounds(0), EquipmentIcon0Bounds(1))
        Form1.Equipment0Icon.Width = EquipmentIcon0Bounds(2)
        Form1.Equipment0Icon.Height = EquipmentIcon0Bounds(3)
        Form1.Equipment0Icon.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\helmet.png")
        Form1.EquipmentItem1.Location = New Point(EquipmentItem1Bounds(0), EquipmentItem1Bounds(1))
        Form1.EquipmentItem1.Width = EquipmentItem1Bounds(2)
        Form1.EquipmentItem1.Height = EquipmentItem1Bounds(3)
        Form1.EquipmentItem1.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.EquipmentItem1.Texture)
        Form1.Equipment1Icon.Location = New Point(EquipmentIcon1Bounds(0), EquipmentIcon1Bounds(1))
        Form1.Equipment1Icon.Width = EquipmentIcon1Bounds(2)
        Form1.Equipment1Icon.Height = EquipmentIcon1Bounds(3)
        Form1.Equipment1Icon.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\armor.png")
        Form1.EquipmentItem2.Location = New Point(EquipmentItem2Bounds(0), EquipmentItem2Bounds(1))
        Form1.EquipmentItem2.Width = EquipmentItem2Bounds(2)
        Form1.EquipmentItem2.Height = EquipmentItem2Bounds(3)
        Form1.EquipmentItem2.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.EquipmentItem2.Texture)
        Form1.Equipment2Icon.Location = New Point(EquipmentIcon2Bounds(0), EquipmentIcon2Bounds(1))
        Form1.Equipment2Icon.Width = EquipmentIcon2Bounds(2)
        Form1.Equipment2Icon.Height = EquipmentIcon2Bounds(3)
        Form1.Equipment2Icon.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\weapon.png")
        Form1.EquipmentItem3.Location = New Point(EquipmentItem3Bounds(0), EquipmentItem3Bounds(1))
        Form1.EquipmentItem3.Width = EquipmentItem3Bounds(2)
        Form1.EquipmentItem3.Height = EquipmentItem3Bounds(3)
        Form1.EquipmentItem3.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.EquipmentItem3.Texture)
        Form1.Equipment3Icon.Location = New Point(EquipmentIcon3Bounds(0), EquipmentIcon3Bounds(1))
        Form1.Equipment3Icon.Width = EquipmentIcon3Bounds(2)
        Form1.Equipment3Icon.Height = EquipmentIcon3Bounds(3)
        Form1.Equipment3Icon.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\shield.png")
        Form1.EquipmentItem4.Location = New Point(EquipmentItem4Bounds(0), EquipmentItem4Bounds(1))
        Form1.EquipmentItem4.Width = EquipmentItem4Bounds(2)
        Form1.EquipmentItem4.Height = EquipmentItem4Bounds(3)
        Form1.EquipmentItem4.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.EquipmentItem4.Texture)
        Form1.Equipment4Icon.Location = New Point(EquipmentIcon4Bounds(0), EquipmentIcon4Bounds(1))
        Form1.Equipment4Icon.Width = EquipmentIcon4Bounds(2)
        Form1.Equipment4Icon.Height = EquipmentIcon4Bounds(3)
        Form1.Equipment4Icon.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\boots.png")

        Form1.StatusText("[MAIN]     Visual Window Updated")
    End Sub
End Module
