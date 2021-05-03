<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.mainSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.toolSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.JTokenTreeUserControl1 = New ZTn.Json.JsonTreeView.Controls.JTokenTreeUserControl()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.jsonValue = New System.Windows.Forms.RichTextBox()
        Me.jsonTypeCombo = New System.Windows.Forms.ComboBox()
        Me.jsonType = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.fullJson = New System.Windows.Forms.RichTextBox()
        Me.MainSpellPanel = New System.Windows.Forms.Panel()
        Me.SpellCooldownLabel = New System.Windows.Forms.Label()
        Me.SpellIcon = New System.Windows.Forms.PictureBox()
        Me.MainShopWindowPanel = New System.Windows.Forms.Panel()
        Me.ShopWindowCloseButton = New System.Windows.Forms.PictureBox()
        Me.ShopWindowTitle = New System.Windows.Forms.Label()
        Me.MainShopItemPanel = New System.Windows.Forms.Panel()
        Me.ShopItemIcon = New System.Windows.Forms.PictureBox()
        Me.MainQuestsWindowPanel = New System.Windows.Forms.Panel()
        Me.QuestsWindowQuestList = New System.Windows.Forms.Panel()
        Me.QuestsWindowQuestTitle = New System.Windows.Forms.Label()
        Me.QuestsWindowAbandonQuestButton = New System.Windows.Forms.PictureBox()
        Me.QuestsWindowQuestStatus = New System.Windows.Forms.Label()
        Me.QuestsWindowQuestDescription = New System.Windows.Forms.Panel()
        Me.QuestsWindowQuestDescriptionTemplate = New System.Windows.Forms.Label()
        Me.QuestsWindowBackButton = New System.Windows.Forms.PictureBox()
        Me.QuestsWindowCloseButton = New System.Windows.Forms.PictureBox()
        Me.QuestsWindowTitle = New System.Windows.Forms.Label()
        Me.MainQuestOfferWindowPanel = New System.Windows.Forms.Panel()
        Me.QuestOfferCloseButton = New System.Windows.Forms.PictureBox()
        Me.QuestOfferTitle = New System.Windows.Forms.Label()
        Me.QuestOfferInnerPanel = New System.Windows.Forms.Panel()
        Me.QuestOfferArea = New System.Windows.Forms.Panel()
        Me.QuestOfferTemplate = New System.Windows.Forms.Label()
        Me.QuestOfferDeclineButton = New System.Windows.Forms.PictureBox()
        Me.QuestOfferAcceptButton = New System.Windows.Forms.PictureBox()
        Me.QuestTitle = New System.Windows.Forms.Label()
        Me.MainPlayerStatusIconPanel = New System.Windows.Forms.Panel()
        Me.DurationLabel = New System.Windows.Forms.Label()
        Me.StatusIcon = New System.Windows.Forms.PictureBox()
        Me.MainPlayerBoxPanel = New System.Windows.Forms.Panel()
        Me.PlayerBoxFriendButton = New System.Windows.Forms.PictureBox()
        Me.PlayerBoxPartyButton = New System.Windows.Forms.PictureBox()
        Me.PlayerBoxTradeButton = New System.Windows.Forms.PictureBox()
        Me.EntityInfoPanel = New System.Windows.Forms.Panel()
        Me.EXPLabel = New System.Windows.Forms.Label()
        Me.EXPTitle = New System.Windows.Forms.Label()
        Me.EXPBar = New System.Windows.Forms.PictureBox()
        Me.EXPBackground = New System.Windows.Forms.PictureBox()
        Me.MPLabel = New System.Windows.Forms.Label()
        Me.MPTitle = New System.Windows.Forms.Label()
        Me.MPBar = New System.Windows.Forms.PictureBox()
        Me.MPBackground = New System.Windows.Forms.PictureBox()
        Me.HPLabel = New System.Windows.Forms.Label()
        Me.HPTitle = New System.Windows.Forms.Label()
        Me.ShieldBar = New System.Windows.Forms.PictureBox()
        Me.HPBar = New System.Windows.Forms.PictureBox()
        Me.HPBarBackground = New System.Windows.Forms.PictureBox()
        Me.EntityGraphicContainer = New System.Windows.Forms.PictureBox()
        Me.EntityMapLabel = New System.Windows.Forms.Label()
        Me.NameAndLevelLabel = New System.Windows.Forms.Label()
        Me.EntityLevelLabel = New System.Windows.Forms.Label()
        Me.EntityNameLabel = New System.Windows.Forms.Label()
        Me.MainPartyWindowPanel = New System.Windows.Forms.Panel()
        Me.PartyInnerPanel = New System.Windows.Forms.Panel()
        Me.KickButton3 = New System.Windows.Forms.PictureBox()
        Me.KickButton2 = New System.Windows.Forms.PictureBox()
        Me.KickButton1 = New System.Windows.Forms.PictureBox()
        Me.LeavePartyButton = New System.Windows.Forms.PictureBox()
        Me.ManaValue3 = New System.Windows.Forms.Label()
        Me.ManaLabel3 = New System.Windows.Forms.Label()
        Me.ManaBarContainer3 = New System.Windows.Forms.Panel()
        Me.ManaBar3 = New System.Windows.Forms.PictureBox()
        Me.HealthValue3 = New System.Windows.Forms.Label()
        Me.HealthLabel3 = New System.Windows.Forms.Label()
        Me.HealthBarContainer3 = New System.Windows.Forms.Panel()
        Me.HealthBar3 = New System.Windows.Forms.PictureBox()
        Me.MemberName3 = New System.Windows.Forms.Label()
        Me.ManaValue2 = New System.Windows.Forms.Label()
        Me.ManaLabel2 = New System.Windows.Forms.Label()
        Me.ManaBarContainer2 = New System.Windows.Forms.Panel()
        Me.ManaBar2 = New System.Windows.Forms.PictureBox()
        Me.HealthValue2 = New System.Windows.Forms.Label()
        Me.HealthLabel2 = New System.Windows.Forms.Label()
        Me.HealthBarContainer2 = New System.Windows.Forms.Panel()
        Me.HealthBar2 = New System.Windows.Forms.PictureBox()
        Me.MemberName2 = New System.Windows.Forms.Label()
        Me.ManaValue1 = New System.Windows.Forms.Label()
        Me.ManaLabel1 = New System.Windows.Forms.Label()
        Me.ManaBarContainer1 = New System.Windows.Forms.Panel()
        Me.ManaBar1 = New System.Windows.Forms.PictureBox()
        Me.HealthValue1 = New System.Windows.Forms.Label()
        Me.HealthLabel1 = New System.Windows.Forms.Label()
        Me.HealthBarContainer1 = New System.Windows.Forms.Panel()
        Me.HealthBar1 = New System.Windows.Forms.PictureBox()
        Me.MemberName1 = New System.Windows.Forms.Label()
        Me.ManaValue0 = New System.Windows.Forms.Label()
        Me.ManaLabel0 = New System.Windows.Forms.Label()
        Me.ManaBarContainer0 = New System.Windows.Forms.Panel()
        Me.ManaBar0 = New System.Windows.Forms.PictureBox()
        Me.HealthValue0 = New System.Windows.Forms.Label()
        Me.HealthLabel0 = New System.Windows.Forms.Label()
        Me.LeaderText = New System.Windows.Forms.Label()
        Me.LeaderIcon = New System.Windows.Forms.PictureBox()
        Me.HealthBarContainer0 = New System.Windows.Forms.Panel()
        Me.HealthBar0 = New System.Windows.Forms.PictureBox()
        Me.MemberName0 = New System.Windows.Forms.Label()
        Me.PartyCloseButton = New System.Windows.Forms.PictureBox()
        Me.PartyTitle = New System.Windows.Forms.Label()
        Me.MainMenuContainerPanel = New System.Windows.Forms.Panel()
        Me.MenuContainer = New System.Windows.Forms.Panel()
        Me.MenuButton = New System.Windows.Forms.PictureBox()
        Me.PartyContainer = New System.Windows.Forms.Panel()
        Me.PartyButton = New System.Windows.Forms.PictureBox()
        Me.FriendsContainer = New System.Windows.Forms.Panel()
        Me.FriendsButton = New System.Windows.Forms.PictureBox()
        Me.QuestsContainer = New System.Windows.Forms.Panel()
        Me.QuestsButton = New System.Windows.Forms.PictureBox()
        Me.MenuCharacterContainer = New System.Windows.Forms.Panel()
        Me.CharacterButton = New System.Windows.Forms.PictureBox()
        Me.SpellsContainer = New System.Windows.Forms.Panel()
        Me.SpellsButton = New System.Windows.Forms.PictureBox()
        Me.InventoryContainer = New System.Windows.Forms.Panel()
        Me.InventoryButton = New System.Windows.Forms.PictureBox()
        Me.MainItemDescWindowExpandedPanel = New System.Windows.Forms.Panel()
        Me.ItemDescExpandedItemStats = New System.Windows.Forms.Panel()
        Me.ItemDescItemStatsText = New System.Windows.Forms.Label()
        Me.ItemDescExpandedItemValueLabel = New System.Windows.Forms.Label()
        Me.ItemDescExpandedItemTypeLabel = New System.Windows.Forms.Label()
        Me.ItemDescExpandedItemQuantity = New System.Windows.Forms.Label()
        Me.ItemDescExpandedItemNameLabel = New System.Windows.Forms.Label()
        Me.ItemDescExpandedItemIcon = New System.Windows.Forms.PictureBox()
        Me.ItemDescExpandedItemDescription = New System.Windows.Forms.Panel()
        Me.MainItemDescWindowPanel = New System.Windows.Forms.Panel()
        Me.ItemDescItemValueLabel = New System.Windows.Forms.Label()
        Me.ItemDescItemTypeLabel = New System.Windows.Forms.Label()
        Me.ItemDescItemQantityLabel = New System.Windows.Forms.Label()
        Me.ItemDescItemNameLabel = New System.Windows.Forms.Label()
        Me.ItemDescItemIcon = New System.Windows.Forms.PictureBox()
        Me.ItemDescItemDescription = New System.Windows.Forms.Panel()
        Me.MainInventoryWindowPanel = New System.Windows.Forms.Panel()
        Me.InventoryWindowCloseButton = New System.Windows.Forms.PictureBox()
        Me.InventoryWindowTitle = New System.Windows.Forms.Label()
        Me.MainInventoryItemPanel = New System.Windows.Forms.Panel()
        Me.InventoryItemCooldownLabel = New System.Windows.Forms.Label()
        Me.InventoryItemEquippedLabel = New System.Windows.Forms.Label()
        Me.InventoryItemValue = New System.Windows.Forms.Label()
        Me.InventoryItemIcon = New System.Windows.Forms.PictureBox()
        Me.MainGameInputBoxPanel = New System.Windows.Forms.Panel()
        Me.GameInputBoxInnerPanel = New System.Windows.Forms.Panel()
        Me.GameInputOkayButton = New System.Windows.Forms.PictureBox()
        Me.GameInputBoxTextBox = New System.Windows.Forms.Panel()
        Me.GameInputBoxTextboxText = New System.Windows.Forms.PictureBox()
        Me.GameInputNoButton = New System.Windows.Forms.PictureBox()
        Me.GameInputPromptLabel = New System.Windows.Forms.Label()
        Me.GameInputYesButton = New System.Windows.Forms.PictureBox()
        Me.GameInputBoxCloseButton = New System.Windows.Forms.PictureBox()
        Me.GameInputboxTitle = New System.Windows.Forms.Label()
        Me.MainHotbarWindowPanel = New System.Windows.Forms.Panel()
        Me.HotbarContainer9 = New System.Windows.Forms.Panel()
        Me.HotbarLabel9 = New System.Windows.Forms.Label()
        Me.HotbarCooldownLabel9 = New System.Windows.Forms.Label()
        Me.HotbarEquippedLabel9 = New System.Windows.Forms.Label()
        Me.HotbarIcon9 = New System.Windows.Forms.PictureBox()
        Me.HotbarContainer8 = New System.Windows.Forms.Panel()
        Me.HotbarLabel8 = New System.Windows.Forms.Label()
        Me.HotbarCooldownLabel8 = New System.Windows.Forms.Label()
        Me.HotbarEquippedLabel8 = New System.Windows.Forms.Label()
        Me.HotbarIcon8 = New System.Windows.Forms.PictureBox()
        Me.HotbarContainer7 = New System.Windows.Forms.Panel()
        Me.HotbarLabel7 = New System.Windows.Forms.Label()
        Me.HotbarCooldownLabel7 = New System.Windows.Forms.Label()
        Me.HotbarEquippedLabel7 = New System.Windows.Forms.Label()
        Me.HotbarIcon7 = New System.Windows.Forms.PictureBox()
        Me.HotbarContainer6 = New System.Windows.Forms.Panel()
        Me.HotbarLabel6 = New System.Windows.Forms.Label()
        Me.HotbarCooldownLabel6 = New System.Windows.Forms.Label()
        Me.HotbarEquippedLabel6 = New System.Windows.Forms.Label()
        Me.HotbarIcon6 = New System.Windows.Forms.PictureBox()
        Me.HotbarContainer5 = New System.Windows.Forms.Panel()
        Me.HotbarLabel5 = New System.Windows.Forms.Label()
        Me.HotbarCooldownLabel5 = New System.Windows.Forms.Label()
        Me.HotbarEquippedLabel5 = New System.Windows.Forms.Label()
        Me.HotbarIcon5 = New System.Windows.Forms.PictureBox()
        Me.HotbarContainer4 = New System.Windows.Forms.Panel()
        Me.HotbarLabel4 = New System.Windows.Forms.Label()
        Me.HotbarCooldownLabel4 = New System.Windows.Forms.Label()
        Me.HotbarEquippedLabel4 = New System.Windows.Forms.Label()
        Me.HotbarIcon4 = New System.Windows.Forms.PictureBox()
        Me.HotbarContainer3 = New System.Windows.Forms.Panel()
        Me.HotbarLabel3 = New System.Windows.Forms.Label()
        Me.HotbarCooldownLabel3 = New System.Windows.Forms.Label()
        Me.HotbarEquippedLabel3 = New System.Windows.Forms.Label()
        Me.HotbarIcon3 = New System.Windows.Forms.PictureBox()
        Me.HotbarContainer2 = New System.Windows.Forms.Panel()
        Me.HotbarLabel2 = New System.Windows.Forms.Label()
        Me.HotbarCooldownLabel2 = New System.Windows.Forms.Label()
        Me.HotbarEquippedLabel2 = New System.Windows.Forms.Label()
        Me.HotbarIcon2 = New System.Windows.Forms.PictureBox()
        Me.HotbarContainer1 = New System.Windows.Forms.Panel()
        Me.HotbarLabel1 = New System.Windows.Forms.Label()
        Me.HotbarCooldownLabel1 = New System.Windows.Forms.Label()
        Me.HotbarEquippedLabel1 = New System.Windows.Forms.Label()
        Me.HotbarIcon1 = New System.Windows.Forms.PictureBox()
        Me.HotbarContainer0 = New System.Windows.Forms.Panel()
        Me.HotbarLabel0 = New System.Windows.Forms.Label()
        Me.HotbarCooldownLabel0 = New System.Windows.Forms.Label()
        Me.HotbarEquippedLabel0 = New System.Windows.Forms.Label()
        Me.HotbarIcon0 = New System.Windows.Forms.PictureBox()
        Me.MainFriendsWindowPanel = New System.Windows.Forms.Panel()
        Me.AddFriendPopupButton = New System.Windows.Forms.PictureBox()
        Me.FriendsWindowCloseButton = New System.Windows.Forms.PictureBox()
        Me.FriendsWindowTitle = New System.Windows.Forms.Label()
        Me.MainEventDialogWindow4ResponsePanel = New System.Windows.Forms.Panel()
        Me.Dialog4Response4Button = New System.Windows.Forms.PictureBox()
        Me.Dialog4Response3Button = New System.Windows.Forms.PictureBox()
        Me.Dialog4Response2Button = New System.Windows.Forms.PictureBox()
        Me.Dialog4EventDialogArea = New System.Windows.Forms.Panel()
        Me.Dialog4EventDialogAreaInnerPanel = New System.Windows.Forms.Panel()
        Me.Dialog4EventDialogLabel = New System.Windows.Forms.Label()
        Me.Dialog4Response1Button = New System.Windows.Forms.PictureBox()
        Me.Dialog4EventFacePanel = New System.Windows.Forms.Panel()
        Me.MainEventDialogWindow3ResponsePanel = New System.Windows.Forms.Panel()
        Me.Dialog3Response3Button = New System.Windows.Forms.PictureBox()
        Me.Dialog3Response2Button = New System.Windows.Forms.PictureBox()
        Me.Dialog3EventDialogArea = New System.Windows.Forms.Panel()
        Me.Dialog3EventDialogAreaInnerPanel = New System.Windows.Forms.Panel()
        Me.Dialog3EventDialogLabel = New System.Windows.Forms.Label()
        Me.Dialog3Response1Button = New System.Windows.Forms.PictureBox()
        Me.Dialog3EventFacePanel = New System.Windows.Forms.Panel()
        Me.MainEventDialogWindow2ResponsePanel = New System.Windows.Forms.Panel()
        Me.Dialog2Response2Button = New System.Windows.Forms.PictureBox()
        Me.Dialog2EventDialogArea = New System.Windows.Forms.Panel()
        Me.Dialog2EventDialogAreaInnerPanel = New System.Windows.Forms.Panel()
        Me.Dialog2EventDialogLabel = New System.Windows.Forms.Label()
        Me.Dialog2Response1Button = New System.Windows.Forms.PictureBox()
        Me.Dialog2EventFacePanel = New System.Windows.Forms.Panel()
        Me.MainEventDialogWindow1ResponsePanel = New System.Windows.Forms.Panel()
        Me.Dialog1EventDialogArea = New System.Windows.Forms.Panel()
        Me.Dialog1EventDialogAreaInnerPanel = New System.Windows.Forms.Panel()
        Me.Dialog1EventDialogLabel = New System.Windows.Forms.Label()
        Me.Dialog1Response1Button = New System.Windows.Forms.PictureBox()
        Me.Dialog1EventFacePanel = New System.Windows.Forms.Panel()
        Me.MainEscapeMenuPanel = New System.Windows.Forms.Panel()
        Me.EscapeMenuLogoutButton = New System.Windows.Forms.PictureBox()
        Me.EscapeMenuCloseButton = New System.Windows.Forms.PictureBox()
        Me.EscapeMenuExitToDesktopButton = New System.Windows.Forms.PictureBox()
        Me.EscapeMenuCharacterSelectButton = New System.Windows.Forms.PictureBox()
        Me.EscapeMenuOptionsButton = New System.Windows.Forms.PictureBox()
        Me.EscapeMenuTitleLabel = New System.Windows.Forms.Label()
        Me.MainEquipmentItemPanel = New System.Windows.Forms.Panel()
        Me.EquipmentIcon = New System.Windows.Forms.PictureBox()
        Me.MainCraftingWindowPanel = New System.Windows.Forms.Panel()
        Me.CraftButton = New System.Windows.Forms.PictureBox()
        Me.CraftingWindowProgressBar = New System.Windows.Forms.Panel()
        Me.ProductLabel = New System.Windows.Forms.Label()
        Me.IngredientsTitle = New System.Windows.Forms.Label()
        Me.RecipesTitle = New System.Windows.Forms.Label()
        Me.IngredientsContainer = New System.Windows.Forms.Panel()
        Me.CraftingWindowCloseButton = New System.Windows.Forms.PictureBox()
        Me.CraftingWindowTitle = New System.Windows.Forms.Label()
        Me.MainCraftingIngredientPanel = New System.Windows.Forms.Panel()
        Me.IngredientItemValue = New System.Windows.Forms.Label()
        Me.IngredientItemIcon = New System.Windows.Forms.PictureBox()
        Me.MainCraftedItemPanel = New System.Windows.Forms.Panel()
        Me.CraftedItemQuantity = New System.Windows.Forms.Label()
        Me.CraftedItemIcon = New System.Windows.Forms.PictureBox()
        Me.MainChatboxWindowPanel = New System.Windows.Forms.Panel()
        Me.ChatboxInputField = New System.Windows.Forms.PictureBox()
        Me.Chatbar = New System.Windows.Forms.Panel()
        Me.ChatboxTitle = New System.Windows.Forms.Label()
        Me.MainCharacterWindowPanel = New System.Windows.Forms.Panel()
        Me.CharacterWindowInnerPanel = New System.Windows.Forms.Panel()
        Me.EquipmentItem4 = New System.Windows.Forms.Panel()
        Me.Equipment4Icon = New System.Windows.Forms.PictureBox()
        Me.EquipmentItem3 = New System.Windows.Forms.Panel()
        Me.Equipment3Icon = New System.Windows.Forms.PictureBox()
        Me.EquipmentItem2 = New System.Windows.Forms.Panel()
        Me.Equipment2Icon = New System.Windows.Forms.PictureBox()
        Me.EquipmentItem1 = New System.Windows.Forms.Panel()
        Me.Equipment1Icon = New System.Windows.Forms.PictureBox()
        Me.EquipmentItem0 = New System.Windows.Forms.Panel()
        Me.Equipment0Icon = New System.Windows.Forms.PictureBox()
        Me.PointsLabel = New System.Windows.Forms.Label()
        Me.IncreaseMagicResistButton = New System.Windows.Forms.PictureBox()
        Me.MagicResistLabel = New System.Windows.Forms.Label()
        Me.IncreaseAbilityPowerButton = New System.Windows.Forms.PictureBox()
        Me.AbilityPowerLabel = New System.Windows.Forms.Label()
        Me.IncreaseSpeedButton = New System.Windows.Forms.PictureBox()
        Me.SpeedLabel = New System.Windows.Forms.Label()
        Me.IncreaseDefenseButton = New System.Windows.Forms.PictureBox()
        Me.IncreaseAttackButton = New System.Windows.Forms.PictureBox()
        Me.CharacterWindowDefenseLabel = New System.Windows.Forms.Label()
        Me.CharacterWindowAttackLabel = New System.Windows.Forms.Label()
        Me.CharacterWindowStatsLabel = New System.Windows.Forms.Label()
        Me.CharacterWindowEquipmentLabel = New System.Windows.Forms.Label()
        Me.CharacterWindowCharacterContainer = New System.Windows.Forms.PictureBox()
        Me.ChatacterInfoLabel = New System.Windows.Forms.Label()
        Me.CharacterWindowCharacterNameLabel = New System.Windows.Forms.Label()
        Me.CharacterWindowCloseButton = New System.Windows.Forms.PictureBox()
        Me.CharacterWindowTitle = New System.Windows.Forms.Label()
        Me.MainBankWindowPanel = New System.Windows.Forms.Panel()
        Me.BankWindowCloseButton = New System.Windows.Forms.PictureBox()
        Me.BankWindowTitle = New System.Windows.Forms.Label()
        Me.MainBankItemPanel = New System.Windows.Forms.Panel()
        Me.BankItemValue = New System.Windows.Forms.Label()
        Me.BankItemIcon = New System.Windows.Forms.PictureBox()
        Me.MainBagWindowPanel = New System.Windows.Forms.Panel()
        Me.BagWindowCloseButton = New System.Windows.Forms.PictureBox()
        Me.BagWindowTitle = New System.Windows.Forms.Label()
        Me.MainBagItemPanel = New System.Windows.Forms.Panel()
        Me.BagItemValue = New System.Windows.Forms.Label()
        Me.BagItemIcon = New System.Windows.Forms.PictureBox()
        Me.MainControlPanelsWindow = New System.Windows.Forms.Panel()
        Me.RestoreControlsButton = New System.Windows.Forms.PictureBox()
        Me.ExitControlsButton = New System.Windows.Forms.PictureBox()
        Me.CancelControlsButton = New System.Windows.Forms.PictureBox()
        Me.ControlsPanelInnerPanel = New System.Windows.Forms.Panel()
        Me.ControlsHeader = New System.Windows.Forms.Label()
        Me.MainServerStatusAreaPanel = New System.Windows.Forms.Panel()
        Me.ServerStatusAreaServerStatusLabel = New System.Windows.Forms.Label()
        Me.MainResetPasswordWindowPanel = New System.Windows.Forms.Panel()
        Me.ResetPassword2Panel = New System.Windows.Forms.Panel()
        Me.ResetPassword2Field = New System.Windows.Forms.PictureBox()
        Me.ResetPassword2Label = New System.Windows.Forms.Label()
        Me.ResetPassword1Panel = New System.Windows.Forms.Panel()
        Me.ResetPassword1Field = New System.Windows.Forms.PictureBox()
        Me.ResetPassword1Label = New System.Windows.Forms.Label()
        Me.ResetBackButton = New System.Windows.Forms.PictureBox()
        Me.ResetSubmitButton = New System.Windows.Forms.PictureBox()
        Me.CodePanel = New System.Windows.Forms.Panel()
        Me.CodeField = New System.Windows.Forms.PictureBox()
        Me.CodeLabel = New System.Windows.Forms.Label()
        Me.ResetPassHeader = New System.Windows.Forms.Label()
        Me.MainRegistrationWindowPanel = New System.Windows.Forms.Panel()
        Me.Password2Panel = New System.Windows.Forms.Panel()
        Me.Password2Field = New System.Windows.Forms.PictureBox()
        Me.Password2Label = New System.Windows.Forms.Label()
        Me.Password1Panel = New System.Windows.Forms.Panel()
        Me.Password1Field = New System.Windows.Forms.PictureBox()
        Me.Password1Label = New System.Windows.Forms.Label()
        Me.RegistrationLabel = New System.Windows.Forms.Label()
        Me.RegistrationBackButton = New System.Windows.Forms.PictureBox()
        Me.RegistrationUsernamePanel = New System.Windows.Forms.Panel()
        Me.RegistrationUsernameField = New System.Windows.Forms.PictureBox()
        Me.RegistrationUsernameLabel = New System.Windows.Forms.Label()
        Me.RegistrationRegisterButton = New System.Windows.Forms.PictureBox()
        Me.EmailPanel = New System.Windows.Forms.Panel()
        Me.EmailField = New System.Windows.Forms.PictureBox()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.MainOptionsWindowPanel = New System.Windows.Forms.Panel()
        Me.OptionsContainer = New System.Windows.Forms.Panel()
        Me.OptionsCancelButton = New System.Windows.Forms.PictureBox()
        Me.OptionsApplyButton = New System.Windows.Forms.PictureBox()
        Me.MusicSlider = New System.Windows.Forms.Panel()
        Me.MusicSliderBar = New System.Windows.Forms.PictureBox()
        Me.MusicLabel = New System.Windows.Forms.Label()
        Me.SoundSlider = New System.Windows.Forms.Panel()
        Me.SoundSliderBar = New System.Windows.Forms.PictureBox()
        Me.SoundLabel = New System.Windows.Forms.Label()
        Me.KeybindingsButton = New System.Windows.Forms.PictureBox()
        Me.AutocloseWindowsCheckboxPanel = New System.Windows.Forms.Panel()
        Me.AutocloseWindowsCheckboxCheckbox = New System.Windows.Forms.PictureBox()
        Me.AutocloseWindowsCheckboxLabel = New System.Windows.Forms.Label()
        Me.FullscreenCheckboxPanel = New System.Windows.Forms.Panel()
        Me.FullscreenCheckboxCheckbox = New System.Windows.Forms.PictureBox()
        Me.FullscreenCheckboxLabel = New System.Windows.Forms.Label()
        Me.FPSPanel = New System.Windows.Forms.Panel()
        Me.FPSCombobox = New System.Windows.Forms.PictureBox()
        Me.FPSLabel = New System.Windows.Forms.Label()
        Me.ResolutionPanel = New System.Windows.Forms.Panel()
        Me.ResolutionCombobox = New System.Windows.Forms.PictureBox()
        Me.ResolutionLabel = New System.Windows.Forms.Label()
        Me.OptionsHeader = New System.Windows.Forms.Label()
        Me.MainMenuWindowPanel = New System.Windows.Forms.Panel()
        Me.MainMenuOptionsButton = New System.Windows.Forms.PictureBox()
        Me.MainMenuExitButton = New System.Windows.Forms.PictureBox()
        Me.MainMenuCreditsButton = New System.Windows.Forms.PictureBox()
        Me.MainMenuRegisterButton = New System.Windows.Forms.PictureBox()
        Me.MainMenuLoginButton = New System.Windows.Forms.PictureBox()
        Me.MainMenuTitle = New System.Windows.Forms.Label()
        Me.MainLogoPanel = New System.Windows.Forms.PictureBox()
        Me.MainInputBoxPanel = New System.Windows.Forms.Panel()
        Me.InputBoxInnerPanel = New System.Windows.Forms.Panel()
        Me.OkayButton = New System.Windows.Forms.PictureBox()
        Me.InputBoxTextBox = New System.Windows.Forms.Panel()
        Me.InputBoxTextboxText = New System.Windows.Forms.PictureBox()
        Me.NoButton = New System.Windows.Forms.PictureBox()
        Me.PromptLabel = New System.Windows.Forms.Label()
        Me.YesButton = New System.Windows.Forms.PictureBox()
        Me.InputBoxCloseButton = New System.Windows.Forms.PictureBox()
        Me.InputBoxTitle = New System.Windows.Forms.Label()
        Me.MainForgotPasswordWindowPanel = New System.Windows.Forms.Panel()
        Me.ForgotPasswordHintLabel = New System.Windows.Forms.Label()
        Me.ForgotPasswordBackButton = New System.Windows.Forms.PictureBox()
        Me.ForgotPasswordSubmitButton = New System.Windows.Forms.PictureBox()
        Me.ForgotPasswordInputPanel = New System.Windows.Forms.Panel()
        Me.ForgotPasswordInputField = New System.Windows.Forms.PictureBox()
        Me.ForgotPasswordInputLabel = New System.Windows.Forms.Label()
        Me.ForgotPasswordHeader = New System.Windows.Forms.Label()
        Me.MainCreditsPanel = New System.Windows.Forms.Panel()
        Me.CreditsBackButton = New System.Windows.Forms.PictureBox()
        Me.CreditsScrollview = New System.Windows.Forms.Panel()
        Me.CreditsInnerPanel = New System.Windows.Forms.Panel()
        Me.CreditsLabel = New System.Windows.Forms.Label()
        Me.CreditsHeader = New System.Windows.Forms.Label()
        Me.MainCharSelectionPanel = New System.Windows.Forms.Panel()
        Me.LogoutButton = New System.Windows.Forms.PictureBox()
        Me.NewButton = New System.Windows.Forms.PictureBox()
        Me.CharacterInfoLabel = New System.Windows.Forms.Label()
        Me.SelectCharCharacterNameLabel = New System.Windows.Forms.Label()
        Me.DeleteButton = New System.Windows.Forms.PictureBox()
        Me.PlayButton = New System.Windows.Forms.PictureBox()
        Me.SelectCharCharacterContainer = New System.Windows.Forms.Panel()
        Me.PreviousCharacterButton = New System.Windows.Forms.PictureBox()
        Me.NextCharacterButton = New System.Windows.Forms.PictureBox()
        Me.SelectCharCharacterPortrait = New System.Windows.Forms.PictureBox()
        Me.CharacterSelectionHeader = New System.Windows.Forms.Label()
        Me.MainCharacterCreationPanel = New System.Windows.Forms.Panel()
        Me.GenderPanel = New System.Windows.Forms.Panel()
        Me.FemaleCheckboxPanel = New System.Windows.Forms.Panel()
        Me.FemaleCheckboxLabel = New System.Windows.Forms.Label()
        Me.FemaleCheckbox = New System.Windows.Forms.PictureBox()
        Me.MaleCheckboxPanel = New System.Windows.Forms.Panel()
        Me.MaleCheckboxLabel = New System.Windows.Forms.Label()
        Me.MaleCheckbox = New System.Windows.Forms.PictureBox()
        Me.GenderLabel = New System.Windows.Forms.Label()
        Me.Hint2Label = New System.Windows.Forms.Label()
        Me.HintLabel = New System.Windows.Forms.Label()
        Me.CharCreateBackButton = New System.Windows.Forms.PictureBox()
        Me.CreateButton = New System.Windows.Forms.PictureBox()
        Me.CharacterContainer = New System.Windows.Forms.Panel()
        Me.PreviousSpriteButton = New System.Windows.Forms.PictureBox()
        Me.NextSpriteButton = New System.Windows.Forms.PictureBox()
        Me.CharacterPortait = New System.Windows.Forms.PictureBox()
        Me.ClassPanel = New System.Windows.Forms.Panel()
        Me.ClassCombobox = New System.Windows.Forms.PictureBox()
        Me.ClassLabel = New System.Windows.Forms.Label()
        Me.CharacterNamePanel = New System.Windows.Forms.Panel()
        Me.CharacterNameField = New System.Windows.Forms.PictureBox()
        Me.CharacterNameLabel = New System.Windows.Forms.Label()
        Me.CharacterCreationHeader = New System.Windows.Forms.Label()
        Me.MainLoginWindowPanel = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.PictureBox()
        Me.LoginButton = New System.Windows.Forms.PictureBox()
        Me.SavePassPanel = New System.Windows.Forms.Panel()
        Me.SavePassLabel = New System.Windows.Forms.Label()
        Me.SavePassCheckbox = New System.Windows.Forms.PictureBox()
        Me.PasswordPanel = New System.Windows.Forms.Panel()
        Me.PasswordField = New System.Windows.Forms.PictureBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernamePanel = New System.Windows.Forms.Panel()
        Me.UsernameFieldPB = New System.Windows.Forms.PictureBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.LoginHeaderLabel = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.statusTxtBox = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BagItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BagWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BankItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BankWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CharacterWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChatboxWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CraftedItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CraftingIngredientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CraftingWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DraggableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquipmentItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EscapeMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventDialogWindow1ResponseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventDialogWindow2ResponseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventDialogWindow3ResponseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventDialogWindow4ResponseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FriendsWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HotbarWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputBoxToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemDescWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemDescWindowExpandedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuContainerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsWindowToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartyWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayerBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayerStatusIconToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuestOfferWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuestWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShopItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShopWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpellMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpellDescWindowMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpellDescWindowExpandedMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpellsWindowMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TargetBoxMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TargetStatusIconMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TheirTradeItemMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TradeWindowMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YourTradeItemMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CharacterCreationWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CharacterSelectionWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditsWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForgotPasswordWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrationWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetPasswordWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServerStatusAreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshBtn = New System.Windows.Forms.ToolStripMenuItem()
        Me.gridToggle = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainSpellDescWindowPanel = New System.Windows.Forms.Panel()
        Me.SpellDescSpellDescText = New System.Windows.Forms.Label()
        Me.SpellDescSpellType = New System.Windows.Forms.Label()
        Me.SpellDescSpellName = New System.Windows.Forms.Label()
        Me.SpellDescSpellIcon = New System.Windows.Forms.PictureBox()
        Me.SpellDescSpellDesc = New System.Windows.Forms.Panel()
        CType(Me.mainSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit
        Me.mainSplitContainer.Panel1.SuspendLayout
        Me.mainSplitContainer.Panel2.SuspendLayout
        Me.mainSplitContainer.SuspendLayout
        CType(Me.toolSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit
        Me.toolSplitContainer.Panel1.SuspendLayout
        Me.toolSplitContainer.Panel2.SuspendLayout
        Me.toolSplitContainer.SuspendLayout
        Me.TabControl1.SuspendLayout
        Me.TabPage1.SuspendLayout
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.TabPage2.SuspendLayout
        Me.MainSpellPanel.SuspendLayout
        CType(Me.SpellIcon, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainShopWindowPanel.SuspendLayout
        CType(Me.ShopWindowCloseButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainShopItemPanel.SuspendLayout
        CType(Me.ShopItemIcon, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainQuestsWindowPanel.SuspendLayout
        Me.QuestsWindowQuestList.SuspendLayout
        CType(Me.QuestsWindowAbandonQuestButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.QuestsWindowQuestDescription.SuspendLayout
        CType(Me.QuestsWindowBackButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.QuestsWindowCloseButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainQuestOfferWindowPanel.SuspendLayout
        CType(Me.QuestOfferCloseButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.QuestOfferInnerPanel.SuspendLayout
        Me.QuestOfferArea.SuspendLayout
        CType(Me.QuestOfferDeclineButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.QuestOfferAcceptButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainPlayerStatusIconPanel.SuspendLayout
        CType(Me.StatusIcon, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainPlayerBoxPanel.SuspendLayout
        CType(Me.PlayerBoxFriendButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PlayerBoxPartyButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PlayerBoxTradeButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.EntityInfoPanel.SuspendLayout
        CType(Me.EXPBar, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.EXPBackground, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MPBar, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MPBackground, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ShieldBar, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.HPBar, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.HPBarBackground, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.EntityGraphicContainer, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainPartyWindowPanel.SuspendLayout
        Me.PartyInnerPanel.SuspendLayout
        CType(Me.KickButton3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.KickButton2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.KickButton1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.LeavePartyButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.ManaBarContainer3.SuspendLayout
        CType(Me.ManaBar3, System.ComponentModel.ISupportInitialize).BeginInit
        Me.HealthBarContainer3.SuspendLayout
        CType(Me.HealthBar3, System.ComponentModel.ISupportInitialize).BeginInit
        Me.ManaBarContainer2.SuspendLayout
        CType(Me.ManaBar2, System.ComponentModel.ISupportInitialize).BeginInit
        Me.HealthBarContainer2.SuspendLayout
        CType(Me.HealthBar2, System.ComponentModel.ISupportInitialize).BeginInit
        Me.ManaBarContainer1.SuspendLayout
        CType(Me.ManaBar1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.HealthBarContainer1.SuspendLayout
        CType(Me.HealthBar1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.ManaBarContainer0.SuspendLayout
        CType(Me.ManaBar0, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.LeaderIcon, System.ComponentModel.ISupportInitialize).BeginInit
        Me.HealthBarContainer0.SuspendLayout
        CType(Me.HealthBar0, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PartyCloseButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainMenuContainerPanel.SuspendLayout
        Me.MenuContainer.SuspendLayout
        CType(Me.MenuButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.PartyContainer.SuspendLayout
        CType(Me.PartyButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.FriendsContainer.SuspendLayout
        CType(Me.FriendsButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.QuestsContainer.SuspendLayout
        CType(Me.QuestsButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MenuCharacterContainer.SuspendLayout
        CType(Me.CharacterButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.SpellsContainer.SuspendLayout
        CType(Me.SpellsButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.InventoryContainer.SuspendLayout
        CType(Me.InventoryButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainItemDescWindowExpandedPanel.SuspendLayout
        Me.ItemDescExpandedItemStats.SuspendLayout
        CType(Me.ItemDescExpandedItemIcon, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainItemDescWindowPanel.SuspendLayout
        CType(Me.ItemDescItemIcon, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainInventoryWindowPanel.SuspendLayout
        CType(Me.InventoryWindowCloseButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainInventoryItemPanel.SuspendLayout
        CType(Me.InventoryItemIcon, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainGameInputBoxPanel.SuspendLayout
        Me.GameInputBoxInnerPanel.SuspendLayout
        CType(Me.GameInputOkayButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GameInputBoxTextBox.SuspendLayout
        CType(Me.GameInputBoxTextboxText, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GameInputNoButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GameInputYesButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GameInputBoxCloseButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainHotbarWindowPanel.SuspendLayout
        Me.HotbarContainer9.SuspendLayout
        CType(Me.HotbarIcon9, System.ComponentModel.ISupportInitialize).BeginInit
        Me.HotbarContainer8.SuspendLayout
        CType(Me.HotbarIcon8, System.ComponentModel.ISupportInitialize).BeginInit
        Me.HotbarContainer7.SuspendLayout
        CType(Me.HotbarIcon7, System.ComponentModel.ISupportInitialize).BeginInit
        Me.HotbarContainer6.SuspendLayout
        CType(Me.HotbarIcon6, System.ComponentModel.ISupportInitialize).BeginInit
        Me.HotbarContainer5.SuspendLayout
        CType(Me.HotbarIcon5, System.ComponentModel.ISupportInitialize).BeginInit
        Me.HotbarContainer4.SuspendLayout
        CType(Me.HotbarIcon4, System.ComponentModel.ISupportInitialize).BeginInit
        Me.HotbarContainer3.SuspendLayout
        CType(Me.HotbarIcon3, System.ComponentModel.ISupportInitialize).BeginInit
        Me.HotbarContainer2.SuspendLayout
        CType(Me.HotbarIcon2, System.ComponentModel.ISupportInitialize).BeginInit
        Me.HotbarContainer1.SuspendLayout
        CType(Me.HotbarIcon1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.HotbarContainer0.SuspendLayout
        CType(Me.HotbarIcon0, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainFriendsWindowPanel.SuspendLayout
        CType(Me.AddFriendPopupButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.FriendsWindowCloseButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainEventDialogWindow4ResponsePanel.SuspendLayout
        CType(Me.Dialog4Response4Button, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Dialog4Response3Button, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Dialog4Response2Button, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Dialog4EventDialogArea.SuspendLayout
        Me.Dialog4EventDialogAreaInnerPanel.SuspendLayout
        CType(Me.Dialog4Response1Button, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainEventDialogWindow3ResponsePanel.SuspendLayout
        CType(Me.Dialog3Response3Button, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Dialog3Response2Button, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Dialog3EventDialogArea.SuspendLayout
        Me.Dialog3EventDialogAreaInnerPanel.SuspendLayout
        CType(Me.Dialog3Response1Button, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainEventDialogWindow2ResponsePanel.SuspendLayout
        CType(Me.Dialog2Response2Button, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Dialog2EventDialogArea.SuspendLayout
        Me.Dialog2EventDialogAreaInnerPanel.SuspendLayout
        CType(Me.Dialog2Response1Button, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainEventDialogWindow1ResponsePanel.SuspendLayout
        Me.Dialog1EventDialogArea.SuspendLayout
        Me.Dialog1EventDialogAreaInnerPanel.SuspendLayout
        CType(Me.Dialog1Response1Button, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainEscapeMenuPanel.SuspendLayout
        CType(Me.EscapeMenuLogoutButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.EscapeMenuCloseButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.EscapeMenuExitToDesktopButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.EscapeMenuCharacterSelectButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.EscapeMenuOptionsButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainEquipmentItemPanel.SuspendLayout
        CType(Me.EquipmentIcon, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainCraftingWindowPanel.SuspendLayout
        CType(Me.CraftButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CraftingWindowCloseButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainCraftingIngredientPanel.SuspendLayout
        CType(Me.IngredientItemIcon, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainCraftedItemPanel.SuspendLayout
        CType(Me.CraftedItemIcon, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainChatboxWindowPanel.SuspendLayout
        CType(Me.ChatboxInputField, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainCharacterWindowPanel.SuspendLayout
        Me.CharacterWindowInnerPanel.SuspendLayout
        Me.EquipmentItem4.SuspendLayout
        CType(Me.Equipment4Icon, System.ComponentModel.ISupportInitialize).BeginInit
        Me.EquipmentItem3.SuspendLayout
        CType(Me.Equipment3Icon, System.ComponentModel.ISupportInitialize).BeginInit
        Me.EquipmentItem2.SuspendLayout
        CType(Me.Equipment2Icon, System.ComponentModel.ISupportInitialize).BeginInit
        Me.EquipmentItem1.SuspendLayout
        CType(Me.Equipment1Icon, System.ComponentModel.ISupportInitialize).BeginInit
        Me.EquipmentItem0.SuspendLayout
        CType(Me.Equipment0Icon, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.IncreaseMagicResistButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.IncreaseAbilityPowerButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.IncreaseSpeedButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.IncreaseDefenseButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.IncreaseAttackButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CharacterWindowCharacterContainer, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CharacterWindowCloseButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainBankWindowPanel.SuspendLayout
        CType(Me.BankWindowCloseButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainBankItemPanel.SuspendLayout
        CType(Me.BankItemIcon, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainBagWindowPanel.SuspendLayout
        CType(Me.BagWindowCloseButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainBagItemPanel.SuspendLayout
        CType(Me.BagItemIcon, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainControlPanelsWindow.SuspendLayout
        CType(Me.RestoreControlsButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ExitControlsButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CancelControlsButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainServerStatusAreaPanel.SuspendLayout
        Me.MainResetPasswordWindowPanel.SuspendLayout
        Me.ResetPassword2Panel.SuspendLayout
        CType(Me.ResetPassword2Field, System.ComponentModel.ISupportInitialize).BeginInit
        Me.ResetPassword1Panel.SuspendLayout
        CType(Me.ResetPassword1Field, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ResetBackButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ResetSubmitButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.CodePanel.SuspendLayout
        CType(Me.CodeField, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainRegistrationWindowPanel.SuspendLayout
        Me.Password2Panel.SuspendLayout
        CType(Me.Password2Field, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Password1Panel.SuspendLayout
        CType(Me.Password1Field, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RegistrationBackButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.RegistrationUsernamePanel.SuspendLayout
        CType(Me.RegistrationUsernameField, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RegistrationRegisterButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.EmailPanel.SuspendLayout
        CType(Me.EmailField, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainOptionsWindowPanel.SuspendLayout
        Me.OptionsContainer.SuspendLayout
        CType(Me.OptionsCancelButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.OptionsApplyButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MusicSlider.SuspendLayout
        CType(Me.MusicSliderBar, System.ComponentModel.ISupportInitialize).BeginInit
        Me.SoundSlider.SuspendLayout
        CType(Me.SoundSliderBar, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.KeybindingsButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.AutocloseWindowsCheckboxPanel.SuspendLayout
        CType(Me.AutocloseWindowsCheckboxCheckbox, System.ComponentModel.ISupportInitialize).BeginInit
        Me.FullscreenCheckboxPanel.SuspendLayout
        CType(Me.FullscreenCheckboxCheckbox, System.ComponentModel.ISupportInitialize).BeginInit
        Me.FPSPanel.SuspendLayout
        CType(Me.FPSCombobox, System.ComponentModel.ISupportInitialize).BeginInit
        Me.ResolutionPanel.SuspendLayout
        CType(Me.ResolutionCombobox, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainMenuWindowPanel.SuspendLayout
        CType(Me.MainMenuOptionsButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MainMenuExitButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MainMenuCreditsButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MainMenuRegisterButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MainMenuLoginButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MainLogoPanel, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainInputBoxPanel.SuspendLayout
        Me.InputBoxInnerPanel.SuspendLayout
        CType(Me.OkayButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.InputBoxTextBox.SuspendLayout
        CType(Me.InputBoxTextboxText, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.NoButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.YesButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.InputBoxCloseButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainForgotPasswordWindowPanel.SuspendLayout
        CType(Me.ForgotPasswordBackButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ForgotPasswordSubmitButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.ForgotPasswordInputPanel.SuspendLayout
        CType(Me.ForgotPasswordInputField, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainCreditsPanel.SuspendLayout
        CType(Me.CreditsBackButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.CreditsScrollview.SuspendLayout
        Me.CreditsInnerPanel.SuspendLayout
        Me.MainCharSelectionPanel.SuspendLayout
        CType(Me.LogoutButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.NewButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DeleteButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PlayButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.SelectCharCharacterContainer.SuspendLayout
        CType(Me.PreviousCharacterButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.NextCharacterButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SelectCharCharacterPortrait, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainCharacterCreationPanel.SuspendLayout
        Me.GenderPanel.SuspendLayout
        Me.FemaleCheckboxPanel.SuspendLayout
        CType(Me.FemaleCheckbox, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MaleCheckboxPanel.SuspendLayout
        CType(Me.MaleCheckbox, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CharCreateBackButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CreateButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.CharacterContainer.SuspendLayout
        CType(Me.PreviousSpriteButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.NextSpriteButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CharacterPortait, System.ComponentModel.ISupportInitialize).BeginInit
        Me.ClassPanel.SuspendLayout
        CType(Me.ClassCombobox, System.ComponentModel.ISupportInitialize).BeginInit
        Me.CharacterNamePanel.SuspendLayout
        CType(Me.CharacterNameField, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MainLoginWindowPanel.SuspendLayout
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.LoginButton, System.ComponentModel.ISupportInitialize).BeginInit
        Me.SavePassPanel.SuspendLayout
        CType(Me.SavePassCheckbox, System.ComponentModel.ISupportInitialize).BeginInit
        Me.PasswordPanel.SuspendLayout
        CType(Me.PasswordField, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UsernamePanel.SuspendLayout
        CType(Me.UsernameFieldPB, System.ComponentModel.ISupportInitialize).BeginInit
        Me.StatusStrip1.SuspendLayout
        Me.MenuStrip1.SuspendLayout
        Me.MainSpellDescWindowPanel.SuspendLayout
        CType(Me.SpellDescSpellIcon, System.ComponentModel.ISupportInitialize).BeginInit
        Me.SpellDescSpellDesc.SuspendLayout
        Me.SuspendLayout
        '
        'mainSplitContainer
        '
        Me.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainSplitContainer.Location = New System.Drawing.Point(0, 24)
        Me.mainSplitContainer.Name = "mainSplitContainer"
        Me.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'mainSplitContainer.Panel1
        '
        Me.mainSplitContainer.Panel1.Controls.Add(Me.toolSplitContainer)
        '
        'mainSplitContainer.Panel2
        '
        Me.mainSplitContainer.Panel2.Controls.Add(Me.StatusStrip1)
        Me.mainSplitContainer.Size = New System.Drawing.Size(1125, 637)
        Me.mainSplitContainer.SplitterDistance = 607
        Me.mainSplitContainer.TabIndex = 0
        '
        'toolSplitContainer
        '
        Me.toolSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.toolSplitContainer.Name = "toolSplitContainer"
        '
        'toolSplitContainer.Panel1
        '
        Me.toolSplitContainer.Panel1.Controls.Add(Me.TabControl1)
        '
        'toolSplitContainer.Panel2
        '
        Me.toolSplitContainer.Panel2.AutoScroll = True
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainSpellDescWindowPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainSpellPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainShopWindowPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainShopItemPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainQuestsWindowPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainQuestOfferWindowPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainPlayerStatusIconPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainPlayerBoxPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainPartyWindowPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainMenuContainerPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainItemDescWindowExpandedPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainItemDescWindowPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainInventoryWindowPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainInventoryItemPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainGameInputBoxPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainHotbarWindowPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainFriendsWindowPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainEventDialogWindow4ResponsePanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainEventDialogWindow3ResponsePanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainEventDialogWindow2ResponsePanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainEventDialogWindow1ResponsePanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainEscapeMenuPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainEquipmentItemPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainCraftingWindowPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainCraftingIngredientPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainCraftedItemPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainChatboxWindowPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainCharacterWindowPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainBankWindowPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainBankItemPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainBagWindowPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainBagItemPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainControlPanelsWindow)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainServerStatusAreaPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainResetPasswordWindowPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainRegistrationWindowPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainOptionsWindowPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainMenuWindowPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainLogoPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainInputBoxPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainForgotPasswordWindowPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainCreditsPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainCharSelectionPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainCharacterCreationPanel)
        Me.toolSplitContainer.Panel2.Controls.Add(Me.MainLoginWindowPanel)
        Me.toolSplitContainer.Size = New System.Drawing.Size(1125, 607)
        Me.toolSplitContainer.SplitterDistance = 282
        Me.toolSplitContainer.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(282, 607)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(274, 581)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tree"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.JTokenTreeUserControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.updateBtn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.jsonValue)
        Me.SplitContainer1.Panel2.Controls.Add(Me.jsonTypeCombo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.jsonType)
        Me.SplitContainer1.Size = New System.Drawing.Size(268, 575)
        Me.SplitContainer1.SplitterDistance = 373
        Me.SplitContainer1.TabIndex = 1
        '
        'JTokenTreeUserControl1
        '
        Me.JTokenTreeUserControl1.CollapsedFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JTokenTreeUserControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JTokenTreeUserControl1.ExpandedFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline)
        Me.JTokenTreeUserControl1.Location = New System.Drawing.Point(0, 0)
        Me.JTokenTreeUserControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.JTokenTreeUserControl1.Name = "JTokenTreeUserControl1"
        Me.JTokenTreeUserControl1.Size = New System.Drawing.Size(268, 373)
        Me.JTokenTreeUserControl1.TabIndex = 1
        '
        'updateBtn
        '
        Me.updateBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.updateBtn.Location = New System.Drawing.Point(5, 172)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(260, 23)
        Me.updateBtn.TabIndex = 3
        Me.updateBtn.Text = "Update"
        Me.updateBtn.UseVisualStyleBackColor = True
        '
        'jsonValue
        '
        Me.jsonValue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.jsonValue.Location = New System.Drawing.Point(5, 57)
        Me.jsonValue.Name = "jsonValue"
        Me.jsonValue.Size = New System.Drawing.Size(260, 109)
        Me.jsonValue.TabIndex = 2
        Me.jsonValue.Text = ""
        '
        'jsonTypeCombo
        '
        Me.jsonTypeCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.jsonTypeCombo.Enabled = False
        Me.jsonTypeCombo.FormattingEnabled = True
        Me.jsonTypeCombo.Location = New System.Drawing.Point(5, 30)
        Me.jsonTypeCombo.Name = "jsonTypeCombo"
        Me.jsonTypeCombo.Size = New System.Drawing.Size(260, 21)
        Me.jsonTypeCombo.TabIndex = 1
        '
        'jsonType
        '
        Me.jsonType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.jsonType.Location = New System.Drawing.Point(5, 4)
        Me.jsonType.Name = "jsonType"
        Me.jsonType.ReadOnly = True
        Me.jsonType.Size = New System.Drawing.Size(260, 20)
        Me.jsonType.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.fullJson)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(274, 581)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Text"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'fullJson
        '
        Me.fullJson.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fullJson.Location = New System.Drawing.Point(3, 3)
        Me.fullJson.Name = "fullJson"
        Me.fullJson.ReadOnly = True
        Me.fullJson.Size = New System.Drawing.Size(268, 575)
        Me.fullJson.TabIndex = 0
        Me.fullJson.Text = ""
        '
        'MainSpellPanel
        '
        Me.MainSpellPanel.BackColor = System.Drawing.Color.Transparent
        Me.MainSpellPanel.BackgroundImage = CType(resources.GetObject("MainSpellPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainSpellPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainSpellPanel.Controls.Add(Me.SpellCooldownLabel)
        Me.MainSpellPanel.Controls.Add(Me.SpellIcon)
        Me.MainSpellPanel.Location = New System.Drawing.Point(3, 859)
        Me.MainSpellPanel.Name = "MainSpellPanel"
        Me.MainSpellPanel.Size = New System.Drawing.Size(34, 35)
        Me.MainSpellPanel.TabIndex = 51
        Me.MainSpellPanel.Visible = False
        '
        'SpellCooldownLabel
        '
        Me.SpellCooldownLabel.AutoSize = True
        Me.SpellCooldownLabel.BackColor = System.Drawing.Color.Transparent
        Me.SpellCooldownLabel.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpellCooldownLabel.ForeColor = System.Drawing.Color.White
        Me.SpellCooldownLabel.Location = New System.Drawing.Point(13, 10)
        Me.SpellCooldownLabel.Name = "SpellCooldownLabel"
        Me.SpellCooldownLabel.Size = New System.Drawing.Size(12, 14)
        Me.SpellCooldownLabel.TabIndex = 6
        Me.SpellCooldownLabel.Text = "0"
        '
        'SpellIcon
        '
        Me.SpellIcon.BackgroundImage = CType(resources.GetObject("SpellIcon.BackgroundImage"), System.Drawing.Image)
        Me.SpellIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SpellIcon.Location = New System.Drawing.Point(1, 1)
        Me.SpellIcon.Name = "SpellIcon"
        Me.SpellIcon.Size = New System.Drawing.Size(32, 32)
        Me.SpellIcon.TabIndex = 0
        Me.SpellIcon.TabStop = False
        '
        'MainShopWindowPanel
        '
        Me.MainShopWindowPanel.BackgroundImage = CType(resources.GetObject("MainShopWindowPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainShopWindowPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainShopWindowPanel.Controls.Add(Me.ShopWindowCloseButton)
        Me.MainShopWindowPanel.Controls.Add(Me.ShopWindowTitle)
        Me.MainShopWindowPanel.Location = New System.Drawing.Point(825, 1137)
        Me.MainShopWindowPanel.Name = "MainShopWindowPanel"
        Me.MainShopWindowPanel.Size = New System.Drawing.Size(442, 469)
        Me.MainShopWindowPanel.TabIndex = 50
        Me.MainShopWindowPanel.Visible = False
        '
        'ShopWindowCloseButton
        '
        Me.ShopWindowCloseButton.BackColor = System.Drawing.Color.Transparent
        Me.ShopWindowCloseButton.BackgroundImage = CType(resources.GetObject("ShopWindowCloseButton.BackgroundImage"), System.Drawing.Image)
        Me.ShopWindowCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ShopWindowCloseButton.Location = New System.Drawing.Point(408, 0)
        Me.ShopWindowCloseButton.Name = "ShopWindowCloseButton"
        Me.ShopWindowCloseButton.Size = New System.Drawing.Size(34, 32)
        Me.ShopWindowCloseButton.TabIndex = 19
        Me.ShopWindowCloseButton.TabStop = False
        '
        'ShopWindowTitle
        '
        Me.ShopWindowTitle.AutoSize = True
        Me.ShopWindowTitle.BackColor = System.Drawing.Color.Transparent
        Me.ShopWindowTitle.Font = New System.Drawing.Font("Source Sans Pro SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShopWindowTitle.ForeColor = System.Drawing.Color.White
        Me.ShopWindowTitle.Location = New System.Drawing.Point(32, 6)
        Me.ShopWindowTitle.Name = "ShopWindowTitle"
        Me.ShopWindowTitle.Size = New System.Drawing.Size(79, 20)
        Me.ShopWindowTitle.TabIndex = 3
        Me.ShopWindowTitle.Text = "Shop Title"
        '
        'MainShopItemPanel
        '
        Me.MainShopItemPanel.BackColor = System.Drawing.Color.Transparent
        Me.MainShopItemPanel.BackgroundImage = CType(resources.GetObject("MainShopItemPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainShopItemPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainShopItemPanel.Controls.Add(Me.ShopItemIcon)
        Me.MainShopItemPanel.Location = New System.Drawing.Point(42, 820)
        Me.MainShopItemPanel.Name = "MainShopItemPanel"
        Me.MainShopItemPanel.Size = New System.Drawing.Size(34, 35)
        Me.MainShopItemPanel.TabIndex = 49
        Me.MainShopItemPanel.Visible = False
        '
        'ShopItemIcon
        '
        Me.ShopItemIcon.BackgroundImage = CType(resources.GetObject("ShopItemIcon.BackgroundImage"), System.Drawing.Image)
        Me.ShopItemIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ShopItemIcon.Location = New System.Drawing.Point(1, 1)
        Me.ShopItemIcon.Name = "ShopItemIcon"
        Me.ShopItemIcon.Size = New System.Drawing.Size(32, 32)
        Me.ShopItemIcon.TabIndex = 0
        Me.ShopItemIcon.TabStop = False
        '
        'MainQuestsWindowPanel
        '
        Me.MainQuestsWindowPanel.BackgroundImage = CType(resources.GetObject("MainQuestsWindowPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainQuestsWindowPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainQuestsWindowPanel.Controls.Add(Me.QuestsWindowQuestList)
        Me.MainQuestsWindowPanel.Controls.Add(Me.QuestsWindowCloseButton)
        Me.MainQuestsWindowPanel.Controls.Add(Me.QuestsWindowTitle)
        Me.MainQuestsWindowPanel.Location = New System.Drawing.Point(110, 1164)
        Me.MainQuestsWindowPanel.Name = "MainQuestsWindowPanel"
        Me.MainQuestsWindowPanel.Size = New System.Drawing.Size(220, 342)
        Me.MainQuestsWindowPanel.TabIndex = 48
        Me.MainQuestsWindowPanel.Visible = False
        '
        'QuestsWindowQuestList
        '
        Me.QuestsWindowQuestList.BackColor = System.Drawing.Color.Transparent
        Me.QuestsWindowQuestList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuestsWindowQuestList.Controls.Add(Me.QuestsWindowQuestTitle)
        Me.QuestsWindowQuestList.Controls.Add(Me.QuestsWindowAbandonQuestButton)
        Me.QuestsWindowQuestList.Controls.Add(Me.QuestsWindowQuestStatus)
        Me.QuestsWindowQuestList.Controls.Add(Me.QuestsWindowQuestDescription)
        Me.QuestsWindowQuestList.Controls.Add(Me.QuestsWindowBackButton)
        Me.QuestsWindowQuestList.Location = New System.Drawing.Point(1, 0)
        Me.QuestsWindowQuestList.Name = "QuestsWindowQuestList"
        Me.QuestsWindowQuestList.Size = New System.Drawing.Size(218, 310)
        Me.QuestsWindowQuestList.TabIndex = 31
        '
        'QuestsWindowQuestTitle
        '
        Me.QuestsWindowQuestTitle.AutoSize = True
        Me.QuestsWindowQuestTitle.BackColor = System.Drawing.Color.Transparent
        Me.QuestsWindowQuestTitle.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestsWindowQuestTitle.ForeColor = System.Drawing.Color.White
        Me.QuestsWindowQuestTitle.Location = New System.Drawing.Point(3, 9)
        Me.QuestsWindowQuestTitle.Name = "QuestsWindowQuestTitle"
        Me.QuestsWindowQuestTitle.Size = New System.Drawing.Size(72, 17)
        Me.QuestsWindowQuestTitle.TabIndex = 23
        Me.QuestsWindowQuestTitle.Text = "Hunt Slimes"
        Me.QuestsWindowQuestTitle.Visible = False
        '
        'QuestsWindowAbandonQuestButton
        '
        Me.QuestsWindowAbandonQuestButton.BackColor = System.Drawing.Color.Transparent
        Me.QuestsWindowAbandonQuestButton.BackgroundImage = CType(resources.GetObject("QuestsWindowAbandonQuestButton.BackgroundImage"), System.Drawing.Image)
        Me.QuestsWindowAbandonQuestButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuestsWindowAbandonQuestButton.Location = New System.Drawing.Point(114, 268)
        Me.QuestsWindowAbandonQuestButton.Name = "QuestsWindowAbandonQuestButton"
        Me.QuestsWindowAbandonQuestButton.Size = New System.Drawing.Size(96, 35)
        Me.QuestsWindowAbandonQuestButton.TabIndex = 30
        Me.QuestsWindowAbandonQuestButton.TabStop = False
        '
        'QuestsWindowQuestStatus
        '
        Me.QuestsWindowQuestStatus.AutoSize = True
        Me.QuestsWindowQuestStatus.BackColor = System.Drawing.Color.Transparent
        Me.QuestsWindowQuestStatus.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestsWindowQuestStatus.ForeColor = System.Drawing.Color.White
        Me.QuestsWindowQuestStatus.Location = New System.Drawing.Point(3, 27)
        Me.QuestsWindowQuestStatus.Name = "QuestsWindowQuestStatus"
        Me.QuestsWindowQuestStatus.Size = New System.Drawing.Size(68, 17)
        Me.QuestsWindowQuestStatus.TabIndex = 24
        Me.QuestsWindowQuestStatus.Text = "In Progress"
        Me.QuestsWindowQuestStatus.Visible = False
        '
        'QuestsWindowQuestDescription
        '
        Me.QuestsWindowQuestDescription.BackColor = System.Drawing.Color.Transparent
        Me.QuestsWindowQuestDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuestsWindowQuestDescription.Controls.Add(Me.QuestsWindowQuestDescriptionTemplate)
        Me.QuestsWindowQuestDescription.Location = New System.Drawing.Point(15, 51)
        Me.QuestsWindowQuestDescription.Name = "QuestsWindowQuestDescription"
        Me.QuestsWindowQuestDescription.Size = New System.Drawing.Size(211, 212)
        Me.QuestsWindowQuestDescription.TabIndex = 28
        '
        'QuestsWindowQuestDescriptionTemplate
        '
        Me.QuestsWindowQuestDescriptionTemplate.AutoSize = True
        Me.QuestsWindowQuestDescriptionTemplate.BackColor = System.Drawing.Color.Transparent
        Me.QuestsWindowQuestDescriptionTemplate.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestsWindowQuestDescriptionTemplate.ForeColor = System.Drawing.Color.White
        Me.QuestsWindowQuestDescriptionTemplate.Location = New System.Drawing.Point(0, 0)
        Me.QuestsWindowQuestDescriptionTemplate.Name = "QuestsWindowQuestDescriptionTemplate"
        Me.QuestsWindowQuestDescriptionTemplate.Size = New System.Drawing.Size(209, 17)
        Me.QuestsWindowQuestDescriptionTemplate.TabIndex = 24
        Me.QuestsWindowQuestDescriptionTemplate.Text = "Go hunt and kill 10 slimes? K thanks..."
        '
        'QuestsWindowBackButton
        '
        Me.QuestsWindowBackButton.BackColor = System.Drawing.Color.Transparent
        Me.QuestsWindowBackButton.BackgroundImage = CType(resources.GetObject("QuestsWindowBackButton.BackgroundImage"), System.Drawing.Image)
        Me.QuestsWindowBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuestsWindowBackButton.Location = New System.Drawing.Point(9, 268)
        Me.QuestsWindowBackButton.Name = "QuestsWindowBackButton"
        Me.QuestsWindowBackButton.Size = New System.Drawing.Size(96, 35)
        Me.QuestsWindowBackButton.TabIndex = 29
        Me.QuestsWindowBackButton.TabStop = False
        '
        'QuestsWindowCloseButton
        '
        Me.QuestsWindowCloseButton.BackColor = System.Drawing.Color.Transparent
        Me.QuestsWindowCloseButton.BackgroundImage = CType(resources.GetObject("QuestsWindowCloseButton.BackgroundImage"), System.Drawing.Image)
        Me.QuestsWindowCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuestsWindowCloseButton.Location = New System.Drawing.Point(194, 8)
        Me.QuestsWindowCloseButton.Name = "QuestsWindowCloseButton"
        Me.QuestsWindowCloseButton.Size = New System.Drawing.Size(26, 25)
        Me.QuestsWindowCloseButton.TabIndex = 19
        Me.QuestsWindowCloseButton.TabStop = False
        '
        'QuestsWindowTitle
        '
        Me.QuestsWindowTitle.AutoSize = True
        Me.QuestsWindowTitle.BackColor = System.Drawing.Color.Transparent
        Me.QuestsWindowTitle.Font = New System.Drawing.Font("Source Sans Pro SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestsWindowTitle.ForeColor = System.Drawing.Color.White
        Me.QuestsWindowTitle.Location = New System.Drawing.Point(40, 7)
        Me.QuestsWindowTitle.Name = "QuestsWindowTitle"
        Me.QuestsWindowTitle.Size = New System.Drawing.Size(57, 20)
        Me.QuestsWindowTitle.TabIndex = 3
        Me.QuestsWindowTitle.Text = "Quests"
        '
        'MainQuestOfferWindowPanel
        '
        Me.MainQuestOfferWindowPanel.BackgroundImage = CType(resources.GetObject("MainQuestOfferWindowPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainQuestOfferWindowPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainQuestOfferWindowPanel.Controls.Add(Me.QuestOfferCloseButton)
        Me.MainQuestOfferWindowPanel.Controls.Add(Me.QuestOfferTitle)
        Me.MainQuestOfferWindowPanel.Controls.Add(Me.QuestOfferInnerPanel)
        Me.MainQuestOfferWindowPanel.Location = New System.Drawing.Point(354, 1095)
        Me.MainQuestOfferWindowPanel.Name = "MainQuestOfferWindowPanel"
        Me.MainQuestOfferWindowPanel.Size = New System.Drawing.Size(442, 469)
        Me.MainQuestOfferWindowPanel.TabIndex = 47
        Me.MainQuestOfferWindowPanel.Visible = False
        '
        'QuestOfferCloseButton
        '
        Me.QuestOfferCloseButton.BackColor = System.Drawing.Color.Transparent
        Me.QuestOfferCloseButton.BackgroundImage = CType(resources.GetObject("QuestOfferCloseButton.BackgroundImage"), System.Drawing.Image)
        Me.QuestOfferCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuestOfferCloseButton.Location = New System.Drawing.Point(408, 0)
        Me.QuestOfferCloseButton.Name = "QuestOfferCloseButton"
        Me.QuestOfferCloseButton.Size = New System.Drawing.Size(34, 32)
        Me.QuestOfferCloseButton.TabIndex = 19
        Me.QuestOfferCloseButton.TabStop = False
        '
        'QuestOfferTitle
        '
        Me.QuestOfferTitle.AutoSize = True
        Me.QuestOfferTitle.BackColor = System.Drawing.Color.Transparent
        Me.QuestOfferTitle.Font = New System.Drawing.Font("Source Sans Pro SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestOfferTitle.ForeColor = System.Drawing.Color.White
        Me.QuestOfferTitle.Location = New System.Drawing.Point(32, 6)
        Me.QuestOfferTitle.Name = "QuestOfferTitle"
        Me.QuestOfferTitle.Size = New System.Drawing.Size(88, 20)
        Me.QuestOfferTitle.TabIndex = 3
        Me.QuestOfferTitle.Text = "Quest Offer"
        '
        'QuestOfferInnerPanel
        '
        Me.QuestOfferInnerPanel.BackColor = System.Drawing.Color.Transparent
        Me.QuestOfferInnerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuestOfferInnerPanel.Controls.Add(Me.QuestOfferArea)
        Me.QuestOfferInnerPanel.Controls.Add(Me.QuestOfferDeclineButton)
        Me.QuestOfferInnerPanel.Controls.Add(Me.QuestOfferAcceptButton)
        Me.QuestOfferInnerPanel.Controls.Add(Me.QuestTitle)
        Me.QuestOfferInnerPanel.Location = New System.Drawing.Point(0, 38)
        Me.QuestOfferInnerPanel.Name = "QuestOfferInnerPanel"
        Me.QuestOfferInnerPanel.Size = New System.Drawing.Size(442, 431)
        Me.QuestOfferInnerPanel.TabIndex = 20
        '
        'QuestOfferArea
        '
        Me.QuestOfferArea.BackColor = System.Drawing.Color.Transparent
        Me.QuestOfferArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuestOfferArea.Controls.Add(Me.QuestOfferTemplate)
        Me.QuestOfferArea.Location = New System.Drawing.Point(39, 52)
        Me.QuestOfferArea.Name = "QuestOfferArea"
        Me.QuestOfferArea.Size = New System.Drawing.Size(370, 318)
        Me.QuestOfferArea.TabIndex = 27
        '
        'QuestOfferTemplate
        '
        Me.QuestOfferTemplate.AutoSize = True
        Me.QuestOfferTemplate.BackColor = System.Drawing.Color.Transparent
        Me.QuestOfferTemplate.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestOfferTemplate.ForeColor = System.Drawing.Color.White
        Me.QuestOfferTemplate.Location = New System.Drawing.Point(0, 0)
        Me.QuestOfferTemplate.Name = "QuestOfferTemplate"
        Me.QuestOfferTemplate.Size = New System.Drawing.Size(209, 17)
        Me.QuestOfferTemplate.TabIndex = 23
        Me.QuestOfferTemplate.Text = "Go hunt and kill 10 slimes? K thanks..."
        '
        'QuestOfferDeclineButton
        '
        Me.QuestOfferDeclineButton.BackColor = System.Drawing.Color.Transparent
        Me.QuestOfferDeclineButton.BackgroundImage = CType(resources.GetObject("QuestOfferDeclineButton.BackgroundImage"), System.Drawing.Image)
        Me.QuestOfferDeclineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuestOfferDeclineButton.Location = New System.Drawing.Point(288, 393)
        Me.QuestOfferDeclineButton.Name = "QuestOfferDeclineButton"
        Me.QuestOfferDeclineButton.Size = New System.Drawing.Size(96, 35)
        Me.QuestOfferDeclineButton.TabIndex = 26
        Me.QuestOfferDeclineButton.TabStop = False
        '
        'QuestOfferAcceptButton
        '
        Me.QuestOfferAcceptButton.BackColor = System.Drawing.Color.Transparent
        Me.QuestOfferAcceptButton.BackgroundImage = CType(resources.GetObject("QuestOfferAcceptButton.BackgroundImage"), System.Drawing.Image)
        Me.QuestOfferAcceptButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuestOfferAcceptButton.Location = New System.Drawing.Point(54, 393)
        Me.QuestOfferAcceptButton.Name = "QuestOfferAcceptButton"
        Me.QuestOfferAcceptButton.Size = New System.Drawing.Size(96, 35)
        Me.QuestOfferAcceptButton.TabIndex = 25
        Me.QuestOfferAcceptButton.TabStop = False
        '
        'QuestTitle
        '
        Me.QuestTitle.AutoSize = True
        Me.QuestTitle.BackColor = System.Drawing.Color.Transparent
        Me.QuestTitle.Font = New System.Drawing.Font("Source Sans Pro SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestTitle.ForeColor = System.Drawing.Color.White
        Me.QuestTitle.Location = New System.Drawing.Point(0, 10)
        Me.QuestTitle.Name = "QuestTitle"
        Me.QuestTitle.Size = New System.Drawing.Size(150, 31)
        Me.QuestTitle.TabIndex = 22
        Me.QuestTitle.Text = "Kill 10 Slimes"
        '
        'MainPlayerStatusIconPanel
        '
        Me.MainPlayerStatusIconPanel.BackColor = System.Drawing.Color.Transparent
        Me.MainPlayerStatusIconPanel.BackgroundImage = CType(resources.GetObject("MainPlayerStatusIconPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainPlayerStatusIconPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainPlayerStatusIconPanel.Controls.Add(Me.DurationLabel)
        Me.MainPlayerStatusIconPanel.Controls.Add(Me.StatusIcon)
        Me.MainPlayerStatusIconPanel.Location = New System.Drawing.Point(3, 820)
        Me.MainPlayerStatusIconPanel.Name = "MainPlayerStatusIconPanel"
        Me.MainPlayerStatusIconPanel.Size = New System.Drawing.Size(34, 35)
        Me.MainPlayerStatusIconPanel.TabIndex = 46
        Me.MainPlayerStatusIconPanel.Visible = False
        '
        'DurationLabel
        '
        Me.DurationLabel.AutoSize = True
        Me.DurationLabel.BackColor = System.Drawing.Color.Transparent
        Me.DurationLabel.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DurationLabel.ForeColor = System.Drawing.Color.White
        Me.DurationLabel.Location = New System.Drawing.Point(1, 1)
        Me.DurationLabel.Name = "DurationLabel"
        Me.DurationLabel.Size = New System.Drawing.Size(12, 14)
        Me.DurationLabel.TabIndex = 6
        Me.DurationLabel.Text = "0"
        '
        'StatusIcon
        '
        Me.StatusIcon.BackgroundImage = CType(resources.GetObject("StatusIcon.BackgroundImage"), System.Drawing.Image)
        Me.StatusIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StatusIcon.Location = New System.Drawing.Point(1, 1)
        Me.StatusIcon.Name = "StatusIcon"
        Me.StatusIcon.Size = New System.Drawing.Size(32, 32)
        Me.StatusIcon.TabIndex = 0
        Me.StatusIcon.TabStop = False
        '
        'MainPlayerBoxPanel
        '
        Me.MainPlayerBoxPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainPlayerBoxPanel.Controls.Add(Me.PlayerBoxFriendButton)
        Me.MainPlayerBoxPanel.Controls.Add(Me.PlayerBoxPartyButton)
        Me.MainPlayerBoxPanel.Controls.Add(Me.PlayerBoxTradeButton)
        Me.MainPlayerBoxPanel.Controls.Add(Me.EntityInfoPanel)
        Me.MainPlayerBoxPanel.Location = New System.Drawing.Point(2034, 844)
        Me.MainPlayerBoxPanel.Name = "MainPlayerBoxPanel"
        Me.MainPlayerBoxPanel.Size = New System.Drawing.Size(314, 208)
        Me.MainPlayerBoxPanel.TabIndex = 45
        Me.MainPlayerBoxPanel.Visible = False
        '
        'PlayerBoxFriendButton
        '
        Me.PlayerBoxFriendButton.BackColor = System.Drawing.Color.Transparent
        Me.PlayerBoxFriendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlayerBoxFriendButton.Location = New System.Drawing.Point(0, 0)
        Me.PlayerBoxFriendButton.Name = "PlayerBoxFriendButton"
        Me.PlayerBoxFriendButton.Size = New System.Drawing.Size(100, 20)
        Me.PlayerBoxFriendButton.TabIndex = 58
        Me.PlayerBoxFriendButton.TabStop = False
        Me.PlayerBoxFriendButton.Visible = False
        '
        'PlayerBoxPartyButton
        '
        Me.PlayerBoxPartyButton.BackColor = System.Drawing.Color.Transparent
        Me.PlayerBoxPartyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlayerBoxPartyButton.Location = New System.Drawing.Point(165, 89)
        Me.PlayerBoxPartyButton.Name = "PlayerBoxPartyButton"
        Me.PlayerBoxPartyButton.Size = New System.Drawing.Size(100, 20)
        Me.PlayerBoxPartyButton.TabIndex = 57
        Me.PlayerBoxPartyButton.TabStop = False
        Me.PlayerBoxPartyButton.Visible = False
        '
        'PlayerBoxTradeButton
        '
        Me.PlayerBoxTradeButton.BackColor = System.Drawing.Color.Transparent
        Me.PlayerBoxTradeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlayerBoxTradeButton.Location = New System.Drawing.Point(117, 89)
        Me.PlayerBoxTradeButton.Name = "PlayerBoxTradeButton"
        Me.PlayerBoxTradeButton.Size = New System.Drawing.Size(100, 20)
        Me.PlayerBoxTradeButton.TabIndex = 56
        Me.PlayerBoxTradeButton.TabStop = False
        Me.PlayerBoxTradeButton.Visible = False
        '
        'EntityInfoPanel
        '
        Me.EntityInfoPanel.BackColor = System.Drawing.Color.Transparent
        Me.EntityInfoPanel.BackgroundImage = CType(resources.GetObject("EntityInfoPanel.BackgroundImage"), System.Drawing.Image)
        Me.EntityInfoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EntityInfoPanel.Controls.Add(Me.EXPLabel)
        Me.EntityInfoPanel.Controls.Add(Me.EXPTitle)
        Me.EntityInfoPanel.Controls.Add(Me.EXPBar)
        Me.EntityInfoPanel.Controls.Add(Me.EXPBackground)
        Me.EntityInfoPanel.Controls.Add(Me.MPLabel)
        Me.EntityInfoPanel.Controls.Add(Me.MPTitle)
        Me.EntityInfoPanel.Controls.Add(Me.MPBar)
        Me.EntityInfoPanel.Controls.Add(Me.MPBackground)
        Me.EntityInfoPanel.Controls.Add(Me.HPLabel)
        Me.EntityInfoPanel.Controls.Add(Me.HPTitle)
        Me.EntityInfoPanel.Controls.Add(Me.ShieldBar)
        Me.EntityInfoPanel.Controls.Add(Me.HPBar)
        Me.EntityInfoPanel.Controls.Add(Me.HPBarBackground)
        Me.EntityInfoPanel.Controls.Add(Me.EntityGraphicContainer)
        Me.EntityInfoPanel.Controls.Add(Me.EntityMapLabel)
        Me.EntityInfoPanel.Controls.Add(Me.NameAndLevelLabel)
        Me.EntityInfoPanel.Controls.Add(Me.EntityLevelLabel)
        Me.EntityInfoPanel.Controls.Add(Me.EntityNameLabel)
        Me.EntityInfoPanel.Location = New System.Drawing.Point(0, 0)
        Me.EntityInfoPanel.Name = "EntityInfoPanel"
        Me.EntityInfoPanel.Size = New System.Drawing.Size(314, 126)
        Me.EntityInfoPanel.TabIndex = 7
        '
        'EXPLabel
        '
        Me.EXPLabel.AutoSize = True
        Me.EXPLabel.BackColor = System.Drawing.Color.Transparent
        Me.EXPLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXPLabel.ForeColor = System.Drawing.Color.White
        Me.EXPLabel.Location = New System.Drawing.Point(130, 95)
        Me.EXPLabel.Name = "EXPLabel"
        Me.EXPLabel.Size = New System.Drawing.Size(67, 17)
        Me.EXPLabel.TabIndex = 33
        Me.EXPLabel.Text = "9999 / 9999"
        '
        'EXPTitle
        '
        Me.EXPTitle.AutoSize = True
        Me.EXPTitle.BackColor = System.Drawing.Color.Transparent
        Me.EXPTitle.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXPTitle.ForeColor = System.Drawing.Color.White
        Me.EXPTitle.Location = New System.Drawing.Point(95, 95)
        Me.EXPTitle.Name = "EXPTitle"
        Me.EXPTitle.Size = New System.Drawing.Size(32, 17)
        Me.EXPTitle.TabIndex = 32
        Me.EXPTitle.Text = "EXP:"
        '
        'EXPBar
        '
        Me.EXPBar.BackgroundImage = CType(resources.GetObject("EXPBar.BackgroundImage"), System.Drawing.Image)
        Me.EXPBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EXPBar.Location = New System.Drawing.Point(130, 97)
        Me.EXPBar.Name = "EXPBar"
        Me.EXPBar.Size = New System.Drawing.Size(168, 14)
        Me.EXPBar.TabIndex = 31
        Me.EXPBar.TabStop = False
        '
        'EXPBackground
        '
        Me.EXPBackground.BackgroundImage = CType(resources.GetObject("EXPBackground.BackgroundImage"), System.Drawing.Image)
        Me.EXPBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EXPBackground.Location = New System.Drawing.Point(130, 96)
        Me.EXPBackground.Name = "EXPBackground"
        Me.EXPBackground.Size = New System.Drawing.Size(168, 14)
        Me.EXPBackground.TabIndex = 30
        Me.EXPBackground.TabStop = False
        '
        'MPLabel
        '
        Me.MPLabel.AutoSize = True
        Me.MPLabel.BackColor = System.Drawing.Color.Transparent
        Me.MPLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MPLabel.ForeColor = System.Drawing.Color.White
        Me.MPLabel.Location = New System.Drawing.Point(130, 69)
        Me.MPLabel.Name = "MPLabel"
        Me.MPLabel.Size = New System.Drawing.Size(67, 17)
        Me.MPLabel.TabIndex = 29
        Me.MPLabel.Text = "9999 / 9999"
        '
        'MPTitle
        '
        Me.MPTitle.AutoSize = True
        Me.MPTitle.BackColor = System.Drawing.Color.Transparent
        Me.MPTitle.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MPTitle.ForeColor = System.Drawing.Color.White
        Me.MPTitle.Location = New System.Drawing.Point(100, 69)
        Me.MPTitle.Name = "MPTitle"
        Me.MPTitle.Size = New System.Drawing.Size(27, 17)
        Me.MPTitle.TabIndex = 28
        Me.MPTitle.Text = "MP:"
        '
        'MPBar
        '
        Me.MPBar.BackgroundImage = CType(resources.GetObject("MPBar.BackgroundImage"), System.Drawing.Image)
        Me.MPBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MPBar.Location = New System.Drawing.Point(130, 71)
        Me.MPBar.Name = "MPBar"
        Me.MPBar.Size = New System.Drawing.Size(168, 14)
        Me.MPBar.TabIndex = 27
        Me.MPBar.TabStop = False
        '
        'MPBackground
        '
        Me.MPBackground.BackgroundImage = CType(resources.GetObject("MPBackground.BackgroundImage"), System.Drawing.Image)
        Me.MPBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MPBackground.Location = New System.Drawing.Point(130, 70)
        Me.MPBackground.Name = "MPBackground"
        Me.MPBackground.Size = New System.Drawing.Size(168, 14)
        Me.MPBackground.TabIndex = 26
        Me.MPBackground.TabStop = False
        '
        'HPLabel
        '
        Me.HPLabel.AutoSize = True
        Me.HPLabel.BackColor = System.Drawing.Color.Transparent
        Me.HPLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HPLabel.ForeColor = System.Drawing.Color.White
        Me.HPLabel.Location = New System.Drawing.Point(130, 43)
        Me.HPLabel.Name = "HPLabel"
        Me.HPLabel.Size = New System.Drawing.Size(67, 17)
        Me.HPLabel.TabIndex = 25
        Me.HPLabel.Text = "9999 / 9999"
        '
        'HPTitle
        '
        Me.HPTitle.AutoSize = True
        Me.HPTitle.BackColor = System.Drawing.Color.Transparent
        Me.HPTitle.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HPTitle.ForeColor = System.Drawing.Color.White
        Me.HPTitle.Location = New System.Drawing.Point(100, 43)
        Me.HPTitle.Name = "HPTitle"
        Me.HPTitle.Size = New System.Drawing.Size(26, 17)
        Me.HPTitle.TabIndex = 24
        Me.HPTitle.Text = "HP:"
        '
        'ShieldBar
        '
        Me.ShieldBar.BackgroundImage = CType(resources.GetObject("ShieldBar.BackgroundImage"), System.Drawing.Image)
        Me.ShieldBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ShieldBar.Location = New System.Drawing.Point(130, 45)
        Me.ShieldBar.Name = "ShieldBar"
        Me.ShieldBar.Size = New System.Drawing.Size(168, 14)
        Me.ShieldBar.TabIndex = 23
        Me.ShieldBar.TabStop = False
        '
        'HPBar
        '
        Me.HPBar.BackgroundImage = CType(resources.GetObject("HPBar.BackgroundImage"), System.Drawing.Image)
        Me.HPBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HPBar.Location = New System.Drawing.Point(130, 45)
        Me.HPBar.Name = "HPBar"
        Me.HPBar.Size = New System.Drawing.Size(168, 14)
        Me.HPBar.TabIndex = 22
        Me.HPBar.TabStop = False
        '
        'HPBarBackground
        '
        Me.HPBarBackground.BackgroundImage = CType(resources.GetObject("HPBarBackground.BackgroundImage"), System.Drawing.Image)
        Me.HPBarBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HPBarBackground.Location = New System.Drawing.Point(130, 45)
        Me.HPBarBackground.Name = "HPBarBackground"
        Me.HPBarBackground.Size = New System.Drawing.Size(168, 14)
        Me.HPBarBackground.TabIndex = 21
        Me.HPBarBackground.TabStop = False
        '
        'EntityGraphicContainer
        '
        Me.EntityGraphicContainer.BackColor = System.Drawing.Color.Transparent
        Me.EntityGraphicContainer.BackgroundImage = CType(resources.GetObject("EntityGraphicContainer.BackgroundImage"), System.Drawing.Image)
        Me.EntityGraphicContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.EntityGraphicContainer.Location = New System.Drawing.Point(18, 39)
        Me.EntityGraphicContainer.Name = "EntityGraphicContainer"
        Me.EntityGraphicContainer.Size = New System.Drawing.Size(64, 64)
        Me.EntityGraphicContainer.TabIndex = 20
        Me.EntityGraphicContainer.TabStop = False
        '
        'EntityMapLabel
        '
        Me.EntityMapLabel.AutoSize = True
        Me.EntityMapLabel.BackColor = System.Drawing.Color.Transparent
        Me.EntityMapLabel.Font = New System.Drawing.Font("Source Sans Pro SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntityMapLabel.ForeColor = System.Drawing.Color.White
        Me.EntityMapLabel.Location = New System.Drawing.Point(100, 6)
        Me.EntityMapLabel.Name = "EntityMapLabel"
        Me.EntityMapLabel.Size = New System.Drawing.Size(78, 20)
        Me.EntityMapLabel.TabIndex = 7
        Me.EntityMapLabel.Text = "MapName"
        '
        'NameAndLevelLabel
        '
        Me.NameAndLevelLabel.AutoSize = True
        Me.NameAndLevelLabel.BackColor = System.Drawing.Color.Transparent
        Me.NameAndLevelLabel.Font = New System.Drawing.Font("Source Sans Pro SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameAndLevelLabel.ForeColor = System.Drawing.Color.White
        Me.NameAndLevelLabel.Location = New System.Drawing.Point(32, 6)
        Me.NameAndLevelLabel.Name = "NameAndLevelLabel"
        Me.NameAndLevelLabel.Size = New System.Drawing.Size(136, 20)
        Me.NameAndLevelLabel.TabIndex = 6
        Me.NameAndLevelLabel.Text = "EntityName Lvl. 99"
        '
        'EntityLevelLabel
        '
        Me.EntityLevelLabel.AutoSize = True
        Me.EntityLevelLabel.BackColor = System.Drawing.Color.Transparent
        Me.EntityLevelLabel.Font = New System.Drawing.Font("Source Sans Pro SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntityLevelLabel.ForeColor = System.Drawing.Color.White
        Me.EntityLevelLabel.Location = New System.Drawing.Point(16, 7)
        Me.EntityLevelLabel.Name = "EntityLevelLabel"
        Me.EntityLevelLabel.Size = New System.Drawing.Size(46, 20)
        Me.EntityLevelLabel.TabIndex = 5
        Me.EntityLevelLabel.Text = "Lv. 99"
        Me.EntityLevelLabel.Visible = False
        '
        'EntityNameLabel
        '
        Me.EntityNameLabel.AutoSize = True
        Me.EntityNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.EntityNameLabel.Font = New System.Drawing.Font("Source Sans Pro SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntityNameLabel.ForeColor = System.Drawing.Color.White
        Me.EntityNameLabel.Location = New System.Drawing.Point(76, 7)
        Me.EntityNameLabel.Name = "EntityNameLabel"
        Me.EntityNameLabel.Size = New System.Drawing.Size(91, 20)
        Me.EntityNameLabel.TabIndex = 4
        Me.EntityNameLabel.Text = "EntityName"
        Me.EntityNameLabel.Visible = False
        '
        'MainPartyWindowPanel
        '
        Me.MainPartyWindowPanel.BackgroundImage = CType(resources.GetObject("MainPartyWindowPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainPartyWindowPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainPartyWindowPanel.Controls.Add(Me.PartyInnerPanel)
        Me.MainPartyWindowPanel.Controls.Add(Me.PartyCloseButton)
        Me.MainPartyWindowPanel.Controls.Add(Me.PartyTitle)
        Me.MainPartyWindowPanel.Location = New System.Drawing.Point(2034, 500)
        Me.MainPartyWindowPanel.Name = "MainPartyWindowPanel"
        Me.MainPartyWindowPanel.Size = New System.Drawing.Size(220, 338)
        Me.MainPartyWindowPanel.TabIndex = 44
        Me.MainPartyWindowPanel.Visible = False
        '
        'PartyInnerPanel
        '
        Me.PartyInnerPanel.BackColor = System.Drawing.Color.Transparent
        Me.PartyInnerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PartyInnerPanel.Controls.Add(Me.KickButton3)
        Me.PartyInnerPanel.Controls.Add(Me.KickButton2)
        Me.PartyInnerPanel.Controls.Add(Me.KickButton1)
        Me.PartyInnerPanel.Controls.Add(Me.LeavePartyButton)
        Me.PartyInnerPanel.Controls.Add(Me.ManaValue3)
        Me.PartyInnerPanel.Controls.Add(Me.ManaLabel3)
        Me.PartyInnerPanel.Controls.Add(Me.ManaBarContainer3)
        Me.PartyInnerPanel.Controls.Add(Me.HealthValue3)
        Me.PartyInnerPanel.Controls.Add(Me.HealthLabel3)
        Me.PartyInnerPanel.Controls.Add(Me.HealthBarContainer3)
        Me.PartyInnerPanel.Controls.Add(Me.MemberName3)
        Me.PartyInnerPanel.Controls.Add(Me.ManaValue2)
        Me.PartyInnerPanel.Controls.Add(Me.ManaLabel2)
        Me.PartyInnerPanel.Controls.Add(Me.ManaBarContainer2)
        Me.PartyInnerPanel.Controls.Add(Me.HealthValue2)
        Me.PartyInnerPanel.Controls.Add(Me.HealthLabel2)
        Me.PartyInnerPanel.Controls.Add(Me.HealthBarContainer2)
        Me.PartyInnerPanel.Controls.Add(Me.MemberName2)
        Me.PartyInnerPanel.Controls.Add(Me.ManaValue1)
        Me.PartyInnerPanel.Controls.Add(Me.ManaLabel1)
        Me.PartyInnerPanel.Controls.Add(Me.ManaBarContainer1)
        Me.PartyInnerPanel.Controls.Add(Me.HealthValue1)
        Me.PartyInnerPanel.Controls.Add(Me.HealthLabel1)
        Me.PartyInnerPanel.Controls.Add(Me.HealthBarContainer1)
        Me.PartyInnerPanel.Controls.Add(Me.MemberName1)
        Me.PartyInnerPanel.Controls.Add(Me.ManaValue0)
        Me.PartyInnerPanel.Controls.Add(Me.ManaLabel0)
        Me.PartyInnerPanel.Controls.Add(Me.ManaBarContainer0)
        Me.PartyInnerPanel.Controls.Add(Me.HealthValue0)
        Me.PartyInnerPanel.Controls.Add(Me.HealthLabel0)
        Me.PartyInnerPanel.Controls.Add(Me.LeaderText)
        Me.PartyInnerPanel.Controls.Add(Me.LeaderIcon)
        Me.PartyInnerPanel.Controls.Add(Me.HealthBarContainer0)
        Me.PartyInnerPanel.Controls.Add(Me.MemberName0)
        Me.PartyInnerPanel.Location = New System.Drawing.Point(2, 29)
        Me.PartyInnerPanel.Name = "PartyInnerPanel"
        Me.PartyInnerPanel.Size = New System.Drawing.Size(215, 306)
        Me.PartyInnerPanel.TabIndex = 26
        '
        'KickButton3
        '
        Me.KickButton3.BackColor = System.Drawing.Color.Transparent
        Me.KickButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.KickButton3.Location = New System.Drawing.Point(180, 203)
        Me.KickButton3.Name = "KickButton3"
        Me.KickButton3.Size = New System.Drawing.Size(30, 16)
        Me.KickButton3.TabIndex = 58
        Me.KickButton3.TabStop = False
        '
        'KickButton2
        '
        Me.KickButton2.BackColor = System.Drawing.Color.Transparent
        Me.KickButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.KickButton2.Location = New System.Drawing.Point(180, 137)
        Me.KickButton2.Name = "KickButton2"
        Me.KickButton2.Size = New System.Drawing.Size(30, 16)
        Me.KickButton2.TabIndex = 57
        Me.KickButton2.TabStop = False
        '
        'KickButton1
        '
        Me.KickButton1.BackColor = System.Drawing.Color.Transparent
        Me.KickButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.KickButton1.Location = New System.Drawing.Point(180, 71)
        Me.KickButton1.Name = "KickButton1"
        Me.KickButton1.Size = New System.Drawing.Size(30, 16)
        Me.KickButton1.TabIndex = 56
        Me.KickButton1.TabStop = False
        '
        'LeavePartyButton
        '
        Me.LeavePartyButton.BackColor = System.Drawing.Color.Transparent
        Me.LeavePartyButton.BackgroundImage = CType(resources.GetObject("LeavePartyButton.BackgroundImage"), System.Drawing.Image)
        Me.LeavePartyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LeavePartyButton.Location = New System.Drawing.Point(50, 270)
        Me.LeavePartyButton.Name = "LeavePartyButton"
        Me.LeavePartyButton.Size = New System.Drawing.Size(120, 28)
        Me.LeavePartyButton.TabIndex = 55
        Me.LeavePartyButton.TabStop = False
        '
        'ManaValue3
        '
        Me.ManaValue3.AutoSize = True
        Me.ManaValue3.BackColor = System.Drawing.Color.Transparent
        Me.ManaValue3.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManaValue3.ForeColor = System.Drawing.Color.White
        Me.ManaValue3.Location = New System.Drawing.Point(42, 241)
        Me.ManaValue3.Name = "ManaValue3"
        Me.ManaValue3.Size = New System.Drawing.Size(67, 17)
        Me.ManaValue3.TabIndex = 53
        Me.ManaValue3.Text = "9999 / 9999"
        '
        'ManaLabel3
        '
        Me.ManaLabel3.AutoSize = True
        Me.ManaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.ManaLabel3.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManaLabel3.ForeColor = System.Drawing.Color.White
        Me.ManaLabel3.Location = New System.Drawing.Point(10, 241)
        Me.ManaLabel3.Name = "ManaLabel3"
        Me.ManaLabel3.Size = New System.Drawing.Size(27, 17)
        Me.ManaLabel3.TabIndex = 52
        Me.ManaLabel3.Text = "MP:"
        '
        'ManaBarContainer3
        '
        Me.ManaBarContainer3.BackColor = System.Drawing.Color.Transparent
        Me.ManaBarContainer3.BackgroundImage = CType(resources.GetObject("ManaBarContainer3.BackgroundImage"), System.Drawing.Image)
        Me.ManaBarContainer3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ManaBarContainer3.Controls.Add(Me.ManaBar3)
        Me.ManaBarContainer3.Location = New System.Drawing.Point(42, 243)
        Me.ManaBarContainer3.Name = "ManaBarContainer3"
        Me.ManaBarContainer3.Size = New System.Drawing.Size(168, 14)
        Me.ManaBarContainer3.TabIndex = 51
        '
        'ManaBar3
        '
        Me.ManaBar3.BackgroundImage = CType(resources.GetObject("ManaBar3.BackgroundImage"), System.Drawing.Image)
        Me.ManaBar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ManaBar3.Location = New System.Drawing.Point(0, 0)
        Me.ManaBar3.Name = "ManaBar3"
        Me.ManaBar3.Size = New System.Drawing.Size(168, 14)
        Me.ManaBar3.TabIndex = 0
        Me.ManaBar3.TabStop = False
        '
        'HealthValue3
        '
        Me.HealthValue3.AutoSize = True
        Me.HealthValue3.BackColor = System.Drawing.Color.Transparent
        Me.HealthValue3.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HealthValue3.ForeColor = System.Drawing.Color.White
        Me.HealthValue3.Location = New System.Drawing.Point(42, 221)
        Me.HealthValue3.Name = "HealthValue3"
        Me.HealthValue3.Size = New System.Drawing.Size(67, 17)
        Me.HealthValue3.TabIndex = 50
        Me.HealthValue3.Text = "9999 / 9999"
        '
        'HealthLabel3
        '
        Me.HealthLabel3.AutoSize = True
        Me.HealthLabel3.BackColor = System.Drawing.Color.Transparent
        Me.HealthLabel3.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HealthLabel3.ForeColor = System.Drawing.Color.White
        Me.HealthLabel3.Location = New System.Drawing.Point(10, 221)
        Me.HealthLabel3.Name = "HealthLabel3"
        Me.HealthLabel3.Size = New System.Drawing.Size(26, 17)
        Me.HealthLabel3.TabIndex = 49
        Me.HealthLabel3.Text = "HP:"
        '
        'HealthBarContainer3
        '
        Me.HealthBarContainer3.BackColor = System.Drawing.Color.Transparent
        Me.HealthBarContainer3.BackgroundImage = CType(resources.GetObject("HealthBarContainer3.BackgroundImage"), System.Drawing.Image)
        Me.HealthBarContainer3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HealthBarContainer3.Controls.Add(Me.HealthBar3)
        Me.HealthBarContainer3.Location = New System.Drawing.Point(42, 223)
        Me.HealthBarContainer3.Name = "HealthBarContainer3"
        Me.HealthBarContainer3.Size = New System.Drawing.Size(168, 14)
        Me.HealthBarContainer3.TabIndex = 48
        '
        'HealthBar3
        '
        Me.HealthBar3.BackgroundImage = CType(resources.GetObject("HealthBar3.BackgroundImage"), System.Drawing.Image)
        Me.HealthBar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HealthBar3.Location = New System.Drawing.Point(0, 0)
        Me.HealthBar3.Name = "HealthBar3"
        Me.HealthBar3.Size = New System.Drawing.Size(168, 14)
        Me.HealthBar3.TabIndex = 0
        Me.HealthBar3.TabStop = False
        '
        'MemberName3
        '
        Me.MemberName3.AutoSize = True
        Me.MemberName3.BackColor = System.Drawing.Color.Transparent
        Me.MemberName3.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberName3.ForeColor = System.Drawing.Color.White
        Me.MemberName3.Location = New System.Drawing.Point(10, 203)
        Me.MemberName3.Name = "MemberName3"
        Me.MemberName3.Size = New System.Drawing.Size(127, 17)
        Me.MemberName3.TabIndex = 47
        Me.MemberName3.Text = "MemberName - Lvl. 99"
        '
        'ManaValue2
        '
        Me.ManaValue2.AutoSize = True
        Me.ManaValue2.BackColor = System.Drawing.Color.Transparent
        Me.ManaValue2.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManaValue2.ForeColor = System.Drawing.Color.White
        Me.ManaValue2.Location = New System.Drawing.Point(42, 175)
        Me.ManaValue2.Name = "ManaValue2"
        Me.ManaValue2.Size = New System.Drawing.Size(67, 17)
        Me.ManaValue2.TabIndex = 45
        Me.ManaValue2.Text = "9999 / 9999"
        '
        'ManaLabel2
        '
        Me.ManaLabel2.AutoSize = True
        Me.ManaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.ManaLabel2.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManaLabel2.ForeColor = System.Drawing.Color.White
        Me.ManaLabel2.Location = New System.Drawing.Point(10, 175)
        Me.ManaLabel2.Name = "ManaLabel2"
        Me.ManaLabel2.Size = New System.Drawing.Size(27, 17)
        Me.ManaLabel2.TabIndex = 44
        Me.ManaLabel2.Text = "MP:"
        '
        'ManaBarContainer2
        '
        Me.ManaBarContainer2.BackColor = System.Drawing.Color.Transparent
        Me.ManaBarContainer2.BackgroundImage = CType(resources.GetObject("ManaBarContainer2.BackgroundImage"), System.Drawing.Image)
        Me.ManaBarContainer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ManaBarContainer2.Controls.Add(Me.ManaBar2)
        Me.ManaBarContainer2.Location = New System.Drawing.Point(42, 177)
        Me.ManaBarContainer2.Name = "ManaBarContainer2"
        Me.ManaBarContainer2.Size = New System.Drawing.Size(168, 14)
        Me.ManaBarContainer2.TabIndex = 43
        '
        'ManaBar2
        '
        Me.ManaBar2.BackgroundImage = CType(resources.GetObject("ManaBar2.BackgroundImage"), System.Drawing.Image)
        Me.ManaBar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ManaBar2.Location = New System.Drawing.Point(0, 0)
        Me.ManaBar2.Name = "ManaBar2"
        Me.ManaBar2.Size = New System.Drawing.Size(168, 14)
        Me.ManaBar2.TabIndex = 0
        Me.ManaBar2.TabStop = False
        '
        'HealthValue2
        '
        Me.HealthValue2.AutoSize = True
        Me.HealthValue2.BackColor = System.Drawing.Color.Transparent
        Me.HealthValue2.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HealthValue2.ForeColor = System.Drawing.Color.White
        Me.HealthValue2.Location = New System.Drawing.Point(42, 155)
        Me.HealthValue2.Name = "HealthValue2"
        Me.HealthValue2.Size = New System.Drawing.Size(67, 17)
        Me.HealthValue2.TabIndex = 42
        Me.HealthValue2.Text = "9999 / 9999"
        '
        'HealthLabel2
        '
        Me.HealthLabel2.AutoSize = True
        Me.HealthLabel2.BackColor = System.Drawing.Color.Transparent
        Me.HealthLabel2.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HealthLabel2.ForeColor = System.Drawing.Color.White
        Me.HealthLabel2.Location = New System.Drawing.Point(10, 155)
        Me.HealthLabel2.Name = "HealthLabel2"
        Me.HealthLabel2.Size = New System.Drawing.Size(26, 17)
        Me.HealthLabel2.TabIndex = 41
        Me.HealthLabel2.Text = "HP:"
        '
        'HealthBarContainer2
        '
        Me.HealthBarContainer2.BackColor = System.Drawing.Color.Transparent
        Me.HealthBarContainer2.BackgroundImage = CType(resources.GetObject("HealthBarContainer2.BackgroundImage"), System.Drawing.Image)
        Me.HealthBarContainer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HealthBarContainer2.Controls.Add(Me.HealthBar2)
        Me.HealthBarContainer2.Location = New System.Drawing.Point(42, 157)
        Me.HealthBarContainer2.Name = "HealthBarContainer2"
        Me.HealthBarContainer2.Size = New System.Drawing.Size(168, 14)
        Me.HealthBarContainer2.TabIndex = 40
        '
        'HealthBar2
        '
        Me.HealthBar2.BackgroundImage = CType(resources.GetObject("HealthBar2.BackgroundImage"), System.Drawing.Image)
        Me.HealthBar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HealthBar2.Location = New System.Drawing.Point(0, 0)
        Me.HealthBar2.Name = "HealthBar2"
        Me.HealthBar2.Size = New System.Drawing.Size(168, 14)
        Me.HealthBar2.TabIndex = 0
        Me.HealthBar2.TabStop = False
        '
        'MemberName2
        '
        Me.MemberName2.AutoSize = True
        Me.MemberName2.BackColor = System.Drawing.Color.Transparent
        Me.MemberName2.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberName2.ForeColor = System.Drawing.Color.White
        Me.MemberName2.Location = New System.Drawing.Point(10, 137)
        Me.MemberName2.Name = "MemberName2"
        Me.MemberName2.Size = New System.Drawing.Size(127, 17)
        Me.MemberName2.TabIndex = 39
        Me.MemberName2.Text = "MemberName - Lvl. 99"
        '
        'ManaValue1
        '
        Me.ManaValue1.AutoSize = True
        Me.ManaValue1.BackColor = System.Drawing.Color.Transparent
        Me.ManaValue1.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManaValue1.ForeColor = System.Drawing.Color.White
        Me.ManaValue1.Location = New System.Drawing.Point(42, 109)
        Me.ManaValue1.Name = "ManaValue1"
        Me.ManaValue1.Size = New System.Drawing.Size(67, 17)
        Me.ManaValue1.TabIndex = 37
        Me.ManaValue1.Text = "9999 / 9999"
        '
        'ManaLabel1
        '
        Me.ManaLabel1.AutoSize = True
        Me.ManaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ManaLabel1.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManaLabel1.ForeColor = System.Drawing.Color.White
        Me.ManaLabel1.Location = New System.Drawing.Point(10, 109)
        Me.ManaLabel1.Name = "ManaLabel1"
        Me.ManaLabel1.Size = New System.Drawing.Size(27, 17)
        Me.ManaLabel1.TabIndex = 36
        Me.ManaLabel1.Text = "MP:"
        '
        'ManaBarContainer1
        '
        Me.ManaBarContainer1.BackColor = System.Drawing.Color.Transparent
        Me.ManaBarContainer1.BackgroundImage = CType(resources.GetObject("ManaBarContainer1.BackgroundImage"), System.Drawing.Image)
        Me.ManaBarContainer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ManaBarContainer1.Controls.Add(Me.ManaBar1)
        Me.ManaBarContainer1.Location = New System.Drawing.Point(42, 111)
        Me.ManaBarContainer1.Name = "ManaBarContainer1"
        Me.ManaBarContainer1.Size = New System.Drawing.Size(168, 14)
        Me.ManaBarContainer1.TabIndex = 35
        '
        'ManaBar1
        '
        Me.ManaBar1.BackgroundImage = CType(resources.GetObject("ManaBar1.BackgroundImage"), System.Drawing.Image)
        Me.ManaBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ManaBar1.Location = New System.Drawing.Point(0, 0)
        Me.ManaBar1.Name = "ManaBar1"
        Me.ManaBar1.Size = New System.Drawing.Size(168, 14)
        Me.ManaBar1.TabIndex = 0
        Me.ManaBar1.TabStop = False
        '
        'HealthValue1
        '
        Me.HealthValue1.AutoSize = True
        Me.HealthValue1.BackColor = System.Drawing.Color.Transparent
        Me.HealthValue1.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HealthValue1.ForeColor = System.Drawing.Color.White
        Me.HealthValue1.Location = New System.Drawing.Point(42, 89)
        Me.HealthValue1.Name = "HealthValue1"
        Me.HealthValue1.Size = New System.Drawing.Size(67, 17)
        Me.HealthValue1.TabIndex = 34
        Me.HealthValue1.Text = "9999 / 9999"
        '
        'HealthLabel1
        '
        Me.HealthLabel1.AutoSize = True
        Me.HealthLabel1.BackColor = System.Drawing.Color.Transparent
        Me.HealthLabel1.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HealthLabel1.ForeColor = System.Drawing.Color.White
        Me.HealthLabel1.Location = New System.Drawing.Point(10, 89)
        Me.HealthLabel1.Name = "HealthLabel1"
        Me.HealthLabel1.Size = New System.Drawing.Size(26, 17)
        Me.HealthLabel1.TabIndex = 33
        Me.HealthLabel1.Text = "HP:"
        '
        'HealthBarContainer1
        '
        Me.HealthBarContainer1.BackColor = System.Drawing.Color.Transparent
        Me.HealthBarContainer1.BackgroundImage = CType(resources.GetObject("HealthBarContainer1.BackgroundImage"), System.Drawing.Image)
        Me.HealthBarContainer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HealthBarContainer1.Controls.Add(Me.HealthBar1)
        Me.HealthBarContainer1.Location = New System.Drawing.Point(42, 91)
        Me.HealthBarContainer1.Name = "HealthBarContainer1"
        Me.HealthBarContainer1.Size = New System.Drawing.Size(168, 14)
        Me.HealthBarContainer1.TabIndex = 32
        '
        'HealthBar1
        '
        Me.HealthBar1.BackgroundImage = CType(resources.GetObject("HealthBar1.BackgroundImage"), System.Drawing.Image)
        Me.HealthBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HealthBar1.Location = New System.Drawing.Point(0, 0)
        Me.HealthBar1.Name = "HealthBar1"
        Me.HealthBar1.Size = New System.Drawing.Size(168, 14)
        Me.HealthBar1.TabIndex = 0
        Me.HealthBar1.TabStop = False
        '
        'MemberName1
        '
        Me.MemberName1.AutoSize = True
        Me.MemberName1.BackColor = System.Drawing.Color.Transparent
        Me.MemberName1.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberName1.ForeColor = System.Drawing.Color.White
        Me.MemberName1.Location = New System.Drawing.Point(10, 71)
        Me.MemberName1.Name = "MemberName1"
        Me.MemberName1.Size = New System.Drawing.Size(127, 17)
        Me.MemberName1.TabIndex = 31
        Me.MemberName1.Text = "MemberName - Lvl. 99"
        '
        'ManaValue0
        '
        Me.ManaValue0.AutoSize = True
        Me.ManaValue0.BackColor = System.Drawing.Color.Transparent
        Me.ManaValue0.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManaValue0.ForeColor = System.Drawing.Color.White
        Me.ManaValue0.Location = New System.Drawing.Point(42, 45)
        Me.ManaValue0.Name = "ManaValue0"
        Me.ManaValue0.Size = New System.Drawing.Size(67, 17)
        Me.ManaValue0.TabIndex = 30
        Me.ManaValue0.Text = "9999 / 9999"
        '
        'ManaLabel0
        '
        Me.ManaLabel0.AutoSize = True
        Me.ManaLabel0.BackColor = System.Drawing.Color.Transparent
        Me.ManaLabel0.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManaLabel0.ForeColor = System.Drawing.Color.White
        Me.ManaLabel0.Location = New System.Drawing.Point(10, 45)
        Me.ManaLabel0.Name = "ManaLabel0"
        Me.ManaLabel0.Size = New System.Drawing.Size(27, 17)
        Me.ManaLabel0.TabIndex = 29
        Me.ManaLabel0.Text = "MP:"
        '
        'ManaBarContainer0
        '
        Me.ManaBarContainer0.BackColor = System.Drawing.Color.Transparent
        Me.ManaBarContainer0.BackgroundImage = CType(resources.GetObject("ManaBarContainer0.BackgroundImage"), System.Drawing.Image)
        Me.ManaBarContainer0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ManaBarContainer0.Controls.Add(Me.ManaBar0)
        Me.ManaBarContainer0.Location = New System.Drawing.Point(42, 45)
        Me.ManaBarContainer0.Name = "ManaBarContainer0"
        Me.ManaBarContainer0.Size = New System.Drawing.Size(168, 14)
        Me.ManaBarContainer0.TabIndex = 28
        '
        'ManaBar0
        '
        Me.ManaBar0.BackgroundImage = CType(resources.GetObject("ManaBar0.BackgroundImage"), System.Drawing.Image)
        Me.ManaBar0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ManaBar0.Location = New System.Drawing.Point(0, 0)
        Me.ManaBar0.Name = "ManaBar0"
        Me.ManaBar0.Size = New System.Drawing.Size(168, 14)
        Me.ManaBar0.TabIndex = 0
        Me.ManaBar0.TabStop = False
        '
        'HealthValue0
        '
        Me.HealthValue0.AutoSize = True
        Me.HealthValue0.BackColor = System.Drawing.Color.Transparent
        Me.HealthValue0.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HealthValue0.ForeColor = System.Drawing.Color.White
        Me.HealthValue0.Location = New System.Drawing.Point(42, 23)
        Me.HealthValue0.Name = "HealthValue0"
        Me.HealthValue0.Size = New System.Drawing.Size(67, 17)
        Me.HealthValue0.TabIndex = 27
        Me.HealthValue0.Text = "9999 / 9999"
        '
        'HealthLabel0
        '
        Me.HealthLabel0.AutoSize = True
        Me.HealthLabel0.BackColor = System.Drawing.Color.Transparent
        Me.HealthLabel0.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HealthLabel0.ForeColor = System.Drawing.Color.White
        Me.HealthLabel0.Location = New System.Drawing.Point(10, 23)
        Me.HealthLabel0.Name = "HealthLabel0"
        Me.HealthLabel0.Size = New System.Drawing.Size(26, 17)
        Me.HealthLabel0.TabIndex = 26
        Me.HealthLabel0.Text = "HP:"
        '
        'LeaderText
        '
        Me.LeaderText.AutoSize = True
        Me.LeaderText.BackColor = System.Drawing.Color.Transparent
        Me.LeaderText.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LeaderText.ForeColor = System.Drawing.Color.White
        Me.LeaderText.Location = New System.Drawing.Point(42, 5)
        Me.LeaderText.Name = "LeaderText"
        Me.LeaderText.Size = New System.Drawing.Size(45, 17)
        Me.LeaderText.TabIndex = 23
        Me.LeaderText.Text = "Leader"
        Me.LeaderText.Visible = False
        '
        'LeaderIcon
        '
        Me.LeaderIcon.BackColor = System.Drawing.Color.Transparent
        Me.LeaderIcon.Location = New System.Drawing.Point(148, 4)
        Me.LeaderIcon.Name = "LeaderIcon"
        Me.LeaderIcon.Size = New System.Drawing.Size(34, 34)
        Me.LeaderIcon.TabIndex = 20
        Me.LeaderIcon.TabStop = False
        Me.LeaderIcon.Visible = False
        '
        'HealthBarContainer0
        '
        Me.HealthBarContainer0.BackColor = System.Drawing.Color.Transparent
        Me.HealthBarContainer0.BackgroundImage = CType(resources.GetObject("HealthBarContainer0.BackgroundImage"), System.Drawing.Image)
        Me.HealthBarContainer0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HealthBarContainer0.Controls.Add(Me.HealthBar0)
        Me.HealthBarContainer0.Location = New System.Drawing.Point(42, 25)
        Me.HealthBarContainer0.Name = "HealthBarContainer0"
        Me.HealthBarContainer0.Size = New System.Drawing.Size(168, 14)
        Me.HealthBarContainer0.TabIndex = 25
        '
        'HealthBar0
        '
        Me.HealthBar0.BackgroundImage = CType(resources.GetObject("HealthBar0.BackgroundImage"), System.Drawing.Image)
        Me.HealthBar0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HealthBar0.Location = New System.Drawing.Point(0, 0)
        Me.HealthBar0.Name = "HealthBar0"
        Me.HealthBar0.Size = New System.Drawing.Size(168, 14)
        Me.HealthBar0.TabIndex = 0
        Me.HealthBar0.TabStop = False
        '
        'MemberName0
        '
        Me.MemberName0.AutoSize = True
        Me.MemberName0.BackColor = System.Drawing.Color.Transparent
        Me.MemberName0.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberName0.ForeColor = System.Drawing.Color.White
        Me.MemberName0.Location = New System.Drawing.Point(10, 5)
        Me.MemberName0.Name = "MemberName0"
        Me.MemberName0.Size = New System.Drawing.Size(127, 17)
        Me.MemberName0.TabIndex = 24
        Me.MemberName0.Text = "MemberName - Lvl. 99"
        '
        'PartyCloseButton
        '
        Me.PartyCloseButton.BackColor = System.Drawing.Color.Transparent
        Me.PartyCloseButton.BackgroundImage = CType(resources.GetObject("PartyCloseButton.BackgroundImage"), System.Drawing.Image)
        Me.PartyCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PartyCloseButton.Location = New System.Drawing.Point(194, 4)
        Me.PartyCloseButton.Name = "PartyCloseButton"
        Me.PartyCloseButton.Size = New System.Drawing.Size(26, 25)
        Me.PartyCloseButton.TabIndex = 19
        Me.PartyCloseButton.TabStop = False
        '
        'PartyTitle
        '
        Me.PartyTitle.AutoSize = True
        Me.PartyTitle.BackColor = System.Drawing.Color.Transparent
        Me.PartyTitle.Font = New System.Drawing.Font("Source Sans Pro SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PartyTitle.ForeColor = System.Drawing.Color.White
        Me.PartyTitle.Location = New System.Drawing.Point(40, 5)
        Me.PartyTitle.Name = "PartyTitle"
        Me.PartyTitle.Size = New System.Drawing.Size(45, 20)
        Me.PartyTitle.TabIndex = 3
        Me.PartyTitle.Text = "Party"
        '
        'MainMenuContainerPanel
        '
        Me.MainMenuContainerPanel.BackgroundImage = CType(resources.GetObject("MainMenuContainerPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainMenuContainerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainMenuContainerPanel.Controls.Add(Me.MenuContainer)
        Me.MainMenuContainerPanel.Controls.Add(Me.PartyContainer)
        Me.MainMenuContainerPanel.Controls.Add(Me.FriendsContainer)
        Me.MainMenuContainerPanel.Controls.Add(Me.QuestsContainer)
        Me.MainMenuContainerPanel.Controls.Add(Me.MenuCharacterContainer)
        Me.MainMenuContainerPanel.Controls.Add(Me.SpellsContainer)
        Me.MainMenuContainerPanel.Controls.Add(Me.InventoryContainer)
        Me.MainMenuContainerPanel.Location = New System.Drawing.Point(825, 1089)
        Me.MainMenuContainerPanel.Name = "MainMenuContainerPanel"
        Me.MainMenuContainerPanel.Size = New System.Drawing.Size(289, 42)
        Me.MainMenuContainerPanel.TabIndex = 43
        Me.MainMenuContainerPanel.Visible = False
        '
        'MenuContainer
        '
        Me.MenuContainer.BackgroundImage = CType(resources.GetObject("MenuContainer.BackgroundImage"), System.Drawing.Image)
        Me.MenuContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuContainer.Controls.Add(Me.MenuButton)
        Me.MenuContainer.Location = New System.Drawing.Point(248, 4)
        Me.MenuContainer.Name = "MenuContainer"
        Me.MenuContainer.Size = New System.Drawing.Size(34, 35)
        Me.MenuContainer.TabIndex = 46
        '
        'MenuButton
        '
        Me.MenuButton.BackColor = System.Drawing.Color.Transparent
        Me.MenuButton.BackgroundImage = CType(resources.GetObject("MenuButton.BackgroundImage"), System.Drawing.Image)
        Me.MenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuButton.Location = New System.Drawing.Point(1, 1)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(32, 32)
        Me.MenuButton.TabIndex = 0
        Me.MenuButton.TabStop = False
        '
        'PartyContainer
        '
        Me.PartyContainer.BackgroundImage = CType(resources.GetObject("PartyContainer.BackgroundImage"), System.Drawing.Image)
        Me.PartyContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PartyContainer.Controls.Add(Me.PartyButton)
        Me.PartyContainer.Location = New System.Drawing.Point(208, 4)
        Me.PartyContainer.Name = "PartyContainer"
        Me.PartyContainer.Size = New System.Drawing.Size(34, 35)
        Me.PartyContainer.TabIndex = 45
        '
        'PartyButton
        '
        Me.PartyButton.BackColor = System.Drawing.Color.Transparent
        Me.PartyButton.BackgroundImage = CType(resources.GetObject("PartyButton.BackgroundImage"), System.Drawing.Image)
        Me.PartyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PartyButton.Location = New System.Drawing.Point(2, 2)
        Me.PartyButton.Name = "PartyButton"
        Me.PartyButton.Size = New System.Drawing.Size(30, 30)
        Me.PartyButton.TabIndex = 0
        Me.PartyButton.TabStop = False
        '
        'FriendsContainer
        '
        Me.FriendsContainer.BackgroundImage = CType(resources.GetObject("FriendsContainer.BackgroundImage"), System.Drawing.Image)
        Me.FriendsContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FriendsContainer.Controls.Add(Me.FriendsButton)
        Me.FriendsContainer.Location = New System.Drawing.Point(168, 4)
        Me.FriendsContainer.Name = "FriendsContainer"
        Me.FriendsContainer.Size = New System.Drawing.Size(34, 35)
        Me.FriendsContainer.TabIndex = 44
        '
        'FriendsButton
        '
        Me.FriendsButton.BackColor = System.Drawing.Color.Transparent
        Me.FriendsButton.BackgroundImage = CType(resources.GetObject("FriendsButton.BackgroundImage"), System.Drawing.Image)
        Me.FriendsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FriendsButton.Location = New System.Drawing.Point(1, 1)
        Me.FriendsButton.Name = "FriendsButton"
        Me.FriendsButton.Size = New System.Drawing.Size(32, 32)
        Me.FriendsButton.TabIndex = 0
        Me.FriendsButton.TabStop = False
        '
        'QuestsContainer
        '
        Me.QuestsContainer.BackgroundImage = CType(resources.GetObject("QuestsContainer.BackgroundImage"), System.Drawing.Image)
        Me.QuestsContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuestsContainer.Controls.Add(Me.QuestsButton)
        Me.QuestsContainer.Location = New System.Drawing.Point(128, 4)
        Me.QuestsContainer.Name = "QuestsContainer"
        Me.QuestsContainer.Size = New System.Drawing.Size(34, 35)
        Me.QuestsContainer.TabIndex = 43
        '
        'QuestsButton
        '
        Me.QuestsButton.BackColor = System.Drawing.Color.Transparent
        Me.QuestsButton.BackgroundImage = CType(resources.GetObject("QuestsButton.BackgroundImage"), System.Drawing.Image)
        Me.QuestsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuestsButton.Location = New System.Drawing.Point(1, 1)
        Me.QuestsButton.Name = "QuestsButton"
        Me.QuestsButton.Size = New System.Drawing.Size(32, 32)
        Me.QuestsButton.TabIndex = 0
        Me.QuestsButton.TabStop = False
        '
        'MenuCharacterContainer
        '
        Me.MenuCharacterContainer.BackgroundImage = CType(resources.GetObject("MenuCharacterContainer.BackgroundImage"), System.Drawing.Image)
        Me.MenuCharacterContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuCharacterContainer.Controls.Add(Me.CharacterButton)
        Me.MenuCharacterContainer.Location = New System.Drawing.Point(88, 4)
        Me.MenuCharacterContainer.Name = "MenuCharacterContainer"
        Me.MenuCharacterContainer.Size = New System.Drawing.Size(34, 35)
        Me.MenuCharacterContainer.TabIndex = 42
        '
        'CharacterButton
        '
        Me.CharacterButton.BackColor = System.Drawing.Color.Transparent
        Me.CharacterButton.BackgroundImage = CType(resources.GetObject("CharacterButton.BackgroundImage"), System.Drawing.Image)
        Me.CharacterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CharacterButton.Location = New System.Drawing.Point(1, 1)
        Me.CharacterButton.Name = "CharacterButton"
        Me.CharacterButton.Size = New System.Drawing.Size(32, 32)
        Me.CharacterButton.TabIndex = 0
        Me.CharacterButton.TabStop = False
        '
        'SpellsContainer
        '
        Me.SpellsContainer.BackgroundImage = CType(resources.GetObject("SpellsContainer.BackgroundImage"), System.Drawing.Image)
        Me.SpellsContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SpellsContainer.Controls.Add(Me.SpellsButton)
        Me.SpellsContainer.Location = New System.Drawing.Point(48, 4)
        Me.SpellsContainer.Name = "SpellsContainer"
        Me.SpellsContainer.Size = New System.Drawing.Size(34, 35)
        Me.SpellsContainer.TabIndex = 41
        '
        'SpellsButton
        '
        Me.SpellsButton.BackColor = System.Drawing.Color.Transparent
        Me.SpellsButton.BackgroundImage = CType(resources.GetObject("SpellsButton.BackgroundImage"), System.Drawing.Image)
        Me.SpellsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SpellsButton.Location = New System.Drawing.Point(1, 1)
        Me.SpellsButton.Name = "SpellsButton"
        Me.SpellsButton.Size = New System.Drawing.Size(32, 32)
        Me.SpellsButton.TabIndex = 0
        Me.SpellsButton.TabStop = False
        '
        'InventoryContainer
        '
        Me.InventoryContainer.BackgroundImage = CType(resources.GetObject("InventoryContainer.BackgroundImage"), System.Drawing.Image)
        Me.InventoryContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.InventoryContainer.Controls.Add(Me.InventoryButton)
        Me.InventoryContainer.Location = New System.Drawing.Point(8, 4)
        Me.InventoryContainer.Name = "InventoryContainer"
        Me.InventoryContainer.Size = New System.Drawing.Size(34, 35)
        Me.InventoryContainer.TabIndex = 40
        '
        'InventoryButton
        '
        Me.InventoryButton.BackColor = System.Drawing.Color.Transparent
        Me.InventoryButton.BackgroundImage = CType(resources.GetObject("InventoryButton.BackgroundImage"), System.Drawing.Image)
        Me.InventoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.InventoryButton.Location = New System.Drawing.Point(1, 1)
        Me.InventoryButton.Name = "InventoryButton"
        Me.InventoryButton.Size = New System.Drawing.Size(32, 32)
        Me.InventoryButton.TabIndex = 0
        Me.InventoryButton.TabStop = False
        '
        'MainItemDescWindowExpandedPanel
        '
        Me.MainItemDescWindowExpandedPanel.BackgroundImage = CType(resources.GetObject("MainItemDescWindowExpandedPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainItemDescWindowExpandedPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainItemDescWindowExpandedPanel.Controls.Add(Me.ItemDescExpandedItemStats)
        Me.MainItemDescWindowExpandedPanel.Controls.Add(Me.ItemDescExpandedItemValueLabel)
        Me.MainItemDescWindowExpandedPanel.Controls.Add(Me.ItemDescExpandedItemTypeLabel)
        Me.MainItemDescWindowExpandedPanel.Controls.Add(Me.ItemDescExpandedItemQuantity)
        Me.MainItemDescWindowExpandedPanel.Controls.Add(Me.ItemDescExpandedItemNameLabel)
        Me.MainItemDescWindowExpandedPanel.Controls.Add(Me.ItemDescExpandedItemIcon)
        Me.MainItemDescWindowExpandedPanel.Controls.Add(Me.ItemDescExpandedItemDescription)
        Me.MainItemDescWindowExpandedPanel.Location = New System.Drawing.Point(2034, 250)
        Me.MainItemDescWindowExpandedPanel.Name = "MainItemDescWindowExpandedPanel"
        Me.MainItemDescWindowExpandedPanel.Size = New System.Drawing.Size(364, 244)
        Me.MainItemDescWindowExpandedPanel.TabIndex = 42
        Me.MainItemDescWindowExpandedPanel.Visible = False
        '
        'ItemDescExpandedItemStats
        '
        Me.ItemDescExpandedItemStats.BackColor = System.Drawing.Color.Transparent
        Me.ItemDescExpandedItemStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ItemDescExpandedItemStats.Controls.Add(Me.ItemDescItemStatsText)
        Me.ItemDescExpandedItemStats.Location = New System.Drawing.Point(192, 8)
        Me.ItemDescExpandedItemStats.Name = "ItemDescExpandedItemStats"
        Me.ItemDescExpandedItemStats.Size = New System.Drawing.Size(173, 228)
        Me.ItemDescExpandedItemStats.TabIndex = 27
        '
        'ItemDescItemStatsText
        '
        Me.ItemDescItemStatsText.AutoSize = True
        Me.ItemDescItemStatsText.BackColor = System.Drawing.Color.Transparent
        Me.ItemDescItemStatsText.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemDescItemStatsText.ForeColor = System.Drawing.Color.White
        Me.ItemDescItemStatsText.Location = New System.Drawing.Point(0, 0)
        Me.ItemDescItemStatsText.Name = "ItemDescItemStatsText"
        Me.ItemDescItemStatsText.Size = New System.Drawing.Size(81, 17)
        Me.ItemDescItemStatsText.TabIndex = 28
        Me.ItemDescItemStatsText.Text = "Stat Bonuses:"
        '
        'ItemDescExpandedItemValueLabel
        '
        Me.ItemDescExpandedItemValueLabel.AutoSize = True
        Me.ItemDescExpandedItemValueLabel.BackColor = System.Drawing.Color.Transparent
        Me.ItemDescExpandedItemValueLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemDescExpandedItemValueLabel.ForeColor = System.Drawing.Color.White
        Me.ItemDescExpandedItemValueLabel.Location = New System.Drawing.Point(4, 44)
        Me.ItemDescExpandedItemValueLabel.Name = "ItemDescExpandedItemValueLabel"
        Me.ItemDescExpandedItemValueLabel.Size = New System.Drawing.Size(107, 17)
        Me.ItemDescExpandedItemValueLabel.TabIndex = 26
        Me.ItemDescExpandedItemValueLabel.Text = "Sells for 10 Gold(s)"
        '
        'ItemDescExpandedItemTypeLabel
        '
        Me.ItemDescExpandedItemTypeLabel.AutoSize = True
        Me.ItemDescExpandedItemTypeLabel.BackColor = System.Drawing.Color.Transparent
        Me.ItemDescExpandedItemTypeLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemDescExpandedItemTypeLabel.ForeColor = System.Drawing.Color.White
        Me.ItemDescExpandedItemTypeLabel.Location = New System.Drawing.Point(4, 122)
        Me.ItemDescExpandedItemTypeLabel.Name = "ItemDescExpandedItemTypeLabel"
        Me.ItemDescExpandedItemTypeLabel.Size = New System.Drawing.Size(75, 17)
        Me.ItemDescExpandedItemTypeLabel.TabIndex = 25
        Me.ItemDescExpandedItemTypeLabel.Text = "Consumable"
        '
        'ItemDescExpandedItemQuantity
        '
        Me.ItemDescExpandedItemQuantity.AutoSize = True
        Me.ItemDescExpandedItemQuantity.BackColor = System.Drawing.Color.Transparent
        Me.ItemDescExpandedItemQuantity.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemDescExpandedItemQuantity.ForeColor = System.Drawing.Color.White
        Me.ItemDescExpandedItemQuantity.Location = New System.Drawing.Point(4, 26)
        Me.ItemDescExpandedItemQuantity.Name = "ItemDescExpandedItemQuantity"
        Me.ItemDescExpandedItemQuantity.Size = New System.Drawing.Size(14, 17)
        Me.ItemDescExpandedItemQuantity.TabIndex = 24
        Me.ItemDescExpandedItemQuantity.Text = "1"
        '
        'ItemDescExpandedItemNameLabel
        '
        Me.ItemDescExpandedItemNameLabel.AutoSize = True
        Me.ItemDescExpandedItemNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.ItemDescExpandedItemNameLabel.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemDescExpandedItemNameLabel.ForeColor = System.Drawing.Color.White
        Me.ItemDescExpandedItemNameLabel.Location = New System.Drawing.Point(4, 8)
        Me.ItemDescExpandedItemNameLabel.Name = "ItemDescExpandedItemNameLabel"
        Me.ItemDescExpandedItemNameLabel.Size = New System.Drawing.Size(101, 20)
        Me.ItemDescExpandedItemNameLabel.TabIndex = 23
        Me.ItemDescExpandedItemNameLabel.Text = "Health Potion"
        '
        'ItemDescExpandedItemIcon
        '
        Me.ItemDescExpandedItemIcon.BackColor = System.Drawing.Color.Transparent
        Me.ItemDescExpandedItemIcon.BackgroundImage = CType(resources.GetObject("ItemDescExpandedItemIcon.BackgroundImage"), System.Drawing.Image)
        Me.ItemDescExpandedItemIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ItemDescExpandedItemIcon.Location = New System.Drawing.Point(68, 68)
        Me.ItemDescExpandedItemIcon.Name = "ItemDescExpandedItemIcon"
        Me.ItemDescExpandedItemIcon.Size = New System.Drawing.Size(48, 48)
        Me.ItemDescExpandedItemIcon.TabIndex = 19
        Me.ItemDescExpandedItemIcon.TabStop = False
        '
        'ItemDescExpandedItemDescription
        '
        Me.ItemDescExpandedItemDescription.BackColor = System.Drawing.Color.Transparent
        Me.ItemDescExpandedItemDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ItemDescExpandedItemDescription.Location = New System.Drawing.Point(4, 150)
        Me.ItemDescExpandedItemDescription.Name = "ItemDescExpandedItemDescription"
        Me.ItemDescExpandedItemDescription.Size = New System.Drawing.Size(177, 100)
        Me.ItemDescExpandedItemDescription.TabIndex = 7
        '
        'MainItemDescWindowPanel
        '
        Me.MainItemDescWindowPanel.BackgroundImage = CType(resources.GetObject("MainItemDescWindowPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainItemDescWindowPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainItemDescWindowPanel.Controls.Add(Me.ItemDescItemValueLabel)
        Me.MainItemDescWindowPanel.Controls.Add(Me.ItemDescItemTypeLabel)
        Me.MainItemDescWindowPanel.Controls.Add(Me.ItemDescItemQantityLabel)
        Me.MainItemDescWindowPanel.Controls.Add(Me.ItemDescItemNameLabel)
        Me.MainItemDescWindowPanel.Controls.Add(Me.ItemDescItemIcon)
        Me.MainItemDescWindowPanel.Controls.Add(Me.ItemDescItemDescription)
        Me.MainItemDescWindowPanel.Location = New System.Drawing.Point(2034, 0)
        Me.MainItemDescWindowPanel.Name = "MainItemDescWindowPanel"
        Me.MainItemDescWindowPanel.Size = New System.Drawing.Size(185, 244)
        Me.MainItemDescWindowPanel.TabIndex = 41
        Me.MainItemDescWindowPanel.Visible = False
        '
        'ItemDescItemValueLabel
        '
        Me.ItemDescItemValueLabel.AutoSize = True
        Me.ItemDescItemValueLabel.BackColor = System.Drawing.Color.Transparent
        Me.ItemDescItemValueLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemDescItemValueLabel.ForeColor = System.Drawing.Color.White
        Me.ItemDescItemValueLabel.Location = New System.Drawing.Point(4, 44)
        Me.ItemDescItemValueLabel.Name = "ItemDescItemValueLabel"
        Me.ItemDescItemValueLabel.Size = New System.Drawing.Size(107, 17)
        Me.ItemDescItemValueLabel.TabIndex = 26
        Me.ItemDescItemValueLabel.Text = "Sells for 10 Gold(s)"
        '
        'ItemDescItemTypeLabel
        '
        Me.ItemDescItemTypeLabel.AutoSize = True
        Me.ItemDescItemTypeLabel.BackColor = System.Drawing.Color.Transparent
        Me.ItemDescItemTypeLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemDescItemTypeLabel.ForeColor = System.Drawing.Color.White
        Me.ItemDescItemTypeLabel.Location = New System.Drawing.Point(4, 122)
        Me.ItemDescItemTypeLabel.Name = "ItemDescItemTypeLabel"
        Me.ItemDescItemTypeLabel.Size = New System.Drawing.Size(75, 17)
        Me.ItemDescItemTypeLabel.TabIndex = 25
        Me.ItemDescItemTypeLabel.Text = "Consumable"
        '
        'ItemDescItemQantityLabel
        '
        Me.ItemDescItemQantityLabel.AutoSize = True
        Me.ItemDescItemQantityLabel.BackColor = System.Drawing.Color.Transparent
        Me.ItemDescItemQantityLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemDescItemQantityLabel.ForeColor = System.Drawing.Color.White
        Me.ItemDescItemQantityLabel.Location = New System.Drawing.Point(4, 26)
        Me.ItemDescItemQantityLabel.Name = "ItemDescItemQantityLabel"
        Me.ItemDescItemQantityLabel.Size = New System.Drawing.Size(14, 17)
        Me.ItemDescItemQantityLabel.TabIndex = 24
        Me.ItemDescItemQantityLabel.Text = "1"
        '
        'ItemDescItemNameLabel
        '
        Me.ItemDescItemNameLabel.AutoSize = True
        Me.ItemDescItemNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.ItemDescItemNameLabel.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemDescItemNameLabel.ForeColor = System.Drawing.Color.White
        Me.ItemDescItemNameLabel.Location = New System.Drawing.Point(4, 8)
        Me.ItemDescItemNameLabel.Name = "ItemDescItemNameLabel"
        Me.ItemDescItemNameLabel.Size = New System.Drawing.Size(101, 20)
        Me.ItemDescItemNameLabel.TabIndex = 23
        Me.ItemDescItemNameLabel.Text = "Health Potion"
        '
        'ItemDescItemIcon
        '
        Me.ItemDescItemIcon.BackColor = System.Drawing.Color.Transparent
        Me.ItemDescItemIcon.BackgroundImage = CType(resources.GetObject("ItemDescItemIcon.BackgroundImage"), System.Drawing.Image)
        Me.ItemDescItemIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ItemDescItemIcon.Location = New System.Drawing.Point(68, 68)
        Me.ItemDescItemIcon.Name = "ItemDescItemIcon"
        Me.ItemDescItemIcon.Size = New System.Drawing.Size(48, 48)
        Me.ItemDescItemIcon.TabIndex = 19
        Me.ItemDescItemIcon.TabStop = False
        '
        'ItemDescItemDescription
        '
        Me.ItemDescItemDescription.BackColor = System.Drawing.Color.Transparent
        Me.ItemDescItemDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ItemDescItemDescription.Location = New System.Drawing.Point(4, 150)
        Me.ItemDescItemDescription.Name = "ItemDescItemDescription"
        Me.ItemDescItemDescription.Size = New System.Drawing.Size(177, 100)
        Me.ItemDescItemDescription.TabIndex = 7
        '
        'MainInventoryWindowPanel
        '
        Me.MainInventoryWindowPanel.BackgroundImage = CType(resources.GetObject("MainInventoryWindowPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainInventoryWindowPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainInventoryWindowPanel.Controls.Add(Me.InventoryWindowCloseButton)
        Me.MainInventoryWindowPanel.Controls.Add(Me.InventoryWindowTitle)
        Me.MainInventoryWindowPanel.Location = New System.Drawing.Point(110, 820)
        Me.MainInventoryWindowPanel.Name = "MainInventoryWindowPanel"
        Me.MainInventoryWindowPanel.Size = New System.Drawing.Size(220, 338)
        Me.MainInventoryWindowPanel.TabIndex = 40
        Me.MainInventoryWindowPanel.Visible = False
        '
        'InventoryWindowCloseButton
        '
        Me.InventoryWindowCloseButton.BackColor = System.Drawing.Color.Transparent
        Me.InventoryWindowCloseButton.BackgroundImage = CType(resources.GetObject("InventoryWindowCloseButton.BackgroundImage"), System.Drawing.Image)
        Me.InventoryWindowCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.InventoryWindowCloseButton.Location = New System.Drawing.Point(194, 4)
        Me.InventoryWindowCloseButton.Name = "InventoryWindowCloseButton"
        Me.InventoryWindowCloseButton.Size = New System.Drawing.Size(26, 25)
        Me.InventoryWindowCloseButton.TabIndex = 19
        Me.InventoryWindowCloseButton.TabStop = False
        '
        'InventoryWindowTitle
        '
        Me.InventoryWindowTitle.AutoSize = True
        Me.InventoryWindowTitle.BackColor = System.Drawing.Color.Transparent
        Me.InventoryWindowTitle.Font = New System.Drawing.Font("Source Sans Pro SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventoryWindowTitle.ForeColor = System.Drawing.Color.White
        Me.InventoryWindowTitle.Location = New System.Drawing.Point(40, 5)
        Me.InventoryWindowTitle.Name = "InventoryWindowTitle"
        Me.InventoryWindowTitle.Size = New System.Drawing.Size(77, 20)
        Me.InventoryWindowTitle.TabIndex = 3
        Me.InventoryWindowTitle.Text = "Inventory"
        '
        'MainInventoryItemPanel
        '
        Me.MainInventoryItemPanel.BackColor = System.Drawing.Color.Transparent
        Me.MainInventoryItemPanel.BackgroundImage = CType(resources.GetObject("MainInventoryItemPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainInventoryItemPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainInventoryItemPanel.Controls.Add(Me.InventoryItemCooldownLabel)
        Me.MainInventoryItemPanel.Controls.Add(Me.InventoryItemEquippedLabel)
        Me.MainInventoryItemPanel.Controls.Add(Me.InventoryItemValue)
        Me.MainInventoryItemPanel.Controls.Add(Me.InventoryItemIcon)
        Me.MainInventoryItemPanel.Location = New System.Drawing.Point(813, 412)
        Me.MainInventoryItemPanel.Name = "MainInventoryItemPanel"
        Me.MainInventoryItemPanel.Size = New System.Drawing.Size(34, 35)
        Me.MainInventoryItemPanel.TabIndex = 30
        Me.MainInventoryItemPanel.Visible = False
        '
        'InventoryItemCooldownLabel
        '
        Me.InventoryItemCooldownLabel.AutoSize = True
        Me.InventoryItemCooldownLabel.BackColor = System.Drawing.Color.Transparent
        Me.InventoryItemCooldownLabel.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventoryItemCooldownLabel.ForeColor = System.Drawing.Color.White
        Me.InventoryItemCooldownLabel.Location = New System.Drawing.Point(13, 10)
        Me.InventoryItemCooldownLabel.Name = "InventoryItemCooldownLabel"
        Me.InventoryItemCooldownLabel.Size = New System.Drawing.Size(12, 14)
        Me.InventoryItemCooldownLabel.TabIndex = 8
        Me.InventoryItemCooldownLabel.Text = "0"
        '
        'InventoryItemEquippedLabel
        '
        Me.InventoryItemEquippedLabel.AutoSize = True
        Me.InventoryItemEquippedLabel.BackColor = System.Drawing.Color.Transparent
        Me.InventoryItemEquippedLabel.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventoryItemEquippedLabel.ForeColor = System.Drawing.Color.White
        Me.InventoryItemEquippedLabel.Location = New System.Drawing.Point(22, 0)
        Me.InventoryItemEquippedLabel.Name = "InventoryItemEquippedLabel"
        Me.InventoryItemEquippedLabel.Size = New System.Drawing.Size(12, 14)
        Me.InventoryItemEquippedLabel.TabIndex = 7
        Me.InventoryItemEquippedLabel.Text = "0"
        '
        'InventoryItemValue
        '
        Me.InventoryItemValue.AutoSize = True
        Me.InventoryItemValue.BackColor = System.Drawing.Color.Transparent
        Me.InventoryItemValue.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventoryItemValue.ForeColor = System.Drawing.Color.White
        Me.InventoryItemValue.Location = New System.Drawing.Point(29, 24)
        Me.InventoryItemValue.Name = "InventoryItemValue"
        Me.InventoryItemValue.Size = New System.Drawing.Size(12, 14)
        Me.InventoryItemValue.TabIndex = 6
        Me.InventoryItemValue.Text = "0"
        '
        'InventoryItemIcon
        '
        Me.InventoryItemIcon.BackgroundImage = CType(resources.GetObject("InventoryItemIcon.BackgroundImage"), System.Drawing.Image)
        Me.InventoryItemIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.InventoryItemIcon.Location = New System.Drawing.Point(1, 1)
        Me.InventoryItemIcon.Name = "InventoryItemIcon"
        Me.InventoryItemIcon.Size = New System.Drawing.Size(32, 32)
        Me.InventoryItemIcon.TabIndex = 0
        Me.InventoryItemIcon.TabStop = False
        '
        'MainGameInputBoxPanel
        '
        Me.MainGameInputBoxPanel.BackgroundImage = CType(resources.GetObject("MainGameInputBoxPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainGameInputBoxPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainGameInputBoxPanel.Controls.Add(Me.GameInputBoxInnerPanel)
        Me.MainGameInputBoxPanel.Controls.Add(Me.GameInputBoxCloseButton)
        Me.MainGameInputBoxPanel.Controls.Add(Me.GameInputboxTitle)
        Me.MainGameInputBoxPanel.Location = New System.Drawing.Point(-122, 619)
        Me.MainGameInputBoxPanel.Name = "MainGameInputBoxPanel"
        Me.MainGameInputBoxPanel.Size = New System.Drawing.Size(452, 198)
        Me.MainGameInputBoxPanel.TabIndex = 39
        Me.MainGameInputBoxPanel.Visible = False
        '
        'GameInputBoxInnerPanel
        '
        Me.GameInputBoxInnerPanel.BackColor = System.Drawing.Color.Transparent
        Me.GameInputBoxInnerPanel.Controls.Add(Me.GameInputOkayButton)
        Me.GameInputBoxInnerPanel.Controls.Add(Me.GameInputBoxTextBox)
        Me.GameInputBoxInnerPanel.Controls.Add(Me.GameInputNoButton)
        Me.GameInputBoxInnerPanel.Controls.Add(Me.GameInputPromptLabel)
        Me.GameInputBoxInnerPanel.Controls.Add(Me.GameInputYesButton)
        Me.GameInputBoxInnerPanel.Location = New System.Drawing.Point(3, 39)
        Me.GameInputBoxInnerPanel.Name = "GameInputBoxInnerPanel"
        Me.GameInputBoxInnerPanel.Size = New System.Drawing.Size(449, 156)
        Me.GameInputBoxInnerPanel.TabIndex = 12
        '
        'GameInputOkayButton
        '
        Me.GameInputOkayButton.BackColor = System.Drawing.Color.Transparent
        Me.GameInputOkayButton.BackgroundImage = CType(resources.GetObject("GameInputOkayButton.BackgroundImage"), System.Drawing.Image)
        Me.GameInputOkayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameInputOkayButton.Location = New System.Drawing.Point(174, 94)
        Me.GameInputOkayButton.Name = "GameInputOkayButton"
        Me.GameInputOkayButton.Size = New System.Drawing.Size(96, 35)
        Me.GameInputOkayButton.TabIndex = 14
        Me.GameInputOkayButton.TabStop = False
        '
        'GameInputBoxTextBox
        '
        Me.GameInputBoxTextBox.BackColor = System.Drawing.Color.Transparent
        Me.GameInputBoxTextBox.BackgroundImage = CType(resources.GetObject("GameInputBoxTextBox.BackgroundImage"), System.Drawing.Image)
        Me.GameInputBoxTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameInputBoxTextBox.Controls.Add(Me.GameInputBoxTextboxText)
        Me.GameInputBoxTextBox.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.GameInputBoxTextBox.Location = New System.Drawing.Point(76, 60)
        Me.GameInputBoxTextBox.Name = "GameInputBoxTextBox"
        Me.GameInputBoxTextBox.Size = New System.Drawing.Size(308, 22)
        Me.GameInputBoxTextBox.TabIndex = 5
        '
        'GameInputBoxTextboxText
        '
        Me.GameInputBoxTextboxText.BackgroundImage = CType(resources.GetObject("GameInputBoxTextboxText.BackgroundImage"), System.Drawing.Image)
        Me.GameInputBoxTextboxText.Location = New System.Drawing.Point(0, 2)
        Me.GameInputBoxTextboxText.Name = "GameInputBoxTextboxText"
        Me.GameInputBoxTextboxText.Size = New System.Drawing.Size(308, 20)
        Me.GameInputBoxTextboxText.TabIndex = 0
        Me.GameInputBoxTextboxText.TabStop = False
        '
        'GameInputNoButton
        '
        Me.GameInputNoButton.BackColor = System.Drawing.Color.Transparent
        Me.GameInputNoButton.BackgroundImage = CType(resources.GetObject("GameInputNoButton.BackgroundImage"), System.Drawing.Image)
        Me.GameInputNoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameInputNoButton.Location = New System.Drawing.Point(266, 100)
        Me.GameInputNoButton.Name = "GameInputNoButton"
        Me.GameInputNoButton.Size = New System.Drawing.Size(96, 35)
        Me.GameInputNoButton.TabIndex = 13
        Me.GameInputNoButton.TabStop = False
        '
        'GameInputPromptLabel
        '
        Me.GameInputPromptLabel.AutoSize = True
        Me.GameInputPromptLabel.BackColor = System.Drawing.Color.Transparent
        Me.GameInputPromptLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameInputPromptLabel.ForeColor = System.Drawing.Color.White
        Me.GameInputPromptLabel.Location = New System.Drawing.Point(36, 12)
        Me.GameInputPromptLabel.Name = "GameInputPromptLabel"
        Me.GameInputPromptLabel.Size = New System.Drawing.Size(91, 17)
        Me.GameInputPromptLabel.TabIndex = 4
        Me.GameInputPromptLabel.Text = "PROMPT LABEL"
        '
        'GameInputYesButton
        '
        Me.GameInputYesButton.BackColor = System.Drawing.Color.Transparent
        Me.GameInputYesButton.BackgroundImage = CType(resources.GetObject("GameInputYesButton.BackgroundImage"), System.Drawing.Image)
        Me.GameInputYesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameInputYesButton.Location = New System.Drawing.Point(90, 100)
        Me.GameInputYesButton.Name = "GameInputYesButton"
        Me.GameInputYesButton.Size = New System.Drawing.Size(96, 35)
        Me.GameInputYesButton.TabIndex = 10
        Me.GameInputYesButton.TabStop = False
        '
        'GameInputBoxCloseButton
        '
        Me.GameInputBoxCloseButton.BackColor = System.Drawing.Color.Transparent
        Me.GameInputBoxCloseButton.BackgroundImage = CType(resources.GetObject("GameInputBoxCloseButton.BackgroundImage"), System.Drawing.Image)
        Me.GameInputBoxCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameInputBoxCloseButton.InitialImage = Nothing
        Me.GameInputBoxCloseButton.Location = New System.Drawing.Point(432, 0)
        Me.GameInputBoxCloseButton.Name = "GameInputBoxCloseButton"
        Me.GameInputBoxCloseButton.Size = New System.Drawing.Size(20, 20)
        Me.GameInputBoxCloseButton.TabIndex = 9
        Me.GameInputBoxCloseButton.TabStop = False
        '
        'GameInputboxTitle
        '
        Me.GameInputboxTitle.AutoSize = True
        Me.GameInputboxTitle.BackColor = System.Drawing.Color.Transparent
        Me.GameInputboxTitle.Font = New System.Drawing.Font("Source Sans Pro SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameInputboxTitle.ForeColor = System.Drawing.Color.White
        Me.GameInputboxTitle.Location = New System.Drawing.Point(25, 9)
        Me.GameInputboxTitle.Name = "GameInputboxTitle"
        Me.GameInputboxTitle.Size = New System.Drawing.Size(129, 20)
        Me.GameInputboxTitle.TabIndex = 3
        Me.GameInputboxTitle.Text = "INPUT BOX TITLE"
        '
        'MainHotbarWindowPanel
        '
        Me.MainHotbarWindowPanel.BackgroundImage = CType(resources.GetObject("MainHotbarWindowPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainHotbarWindowPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainHotbarWindowPanel.Controls.Add(Me.HotbarContainer9)
        Me.MainHotbarWindowPanel.Controls.Add(Me.HotbarContainer8)
        Me.MainHotbarWindowPanel.Controls.Add(Me.HotbarContainer7)
        Me.MainHotbarWindowPanel.Controls.Add(Me.HotbarContainer6)
        Me.MainHotbarWindowPanel.Controls.Add(Me.HotbarContainer5)
        Me.MainHotbarWindowPanel.Controls.Add(Me.HotbarContainer4)
        Me.MainHotbarWindowPanel.Controls.Add(Me.HotbarContainer3)
        Me.MainHotbarWindowPanel.Controls.Add(Me.HotbarContainer2)
        Me.MainHotbarWindowPanel.Controls.Add(Me.HotbarContainer1)
        Me.MainHotbarWindowPanel.Controls.Add(Me.HotbarContainer0)
        Me.MainHotbarWindowPanel.Location = New System.Drawing.Point(825, 1041)
        Me.MainHotbarWindowPanel.Name = "MainHotbarWindowPanel"
        Me.MainHotbarWindowPanel.Size = New System.Drawing.Size(409, 42)
        Me.MainHotbarWindowPanel.TabIndex = 38
        Me.MainHotbarWindowPanel.Visible = False
        '
        'HotbarContainer9
        '
        Me.HotbarContainer9.BackgroundImage = CType(resources.GetObject("HotbarContainer9.BackgroundImage"), System.Drawing.Image)
        Me.HotbarContainer9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HotbarContainer9.Controls.Add(Me.HotbarLabel9)
        Me.HotbarContainer9.Controls.Add(Me.HotbarCooldownLabel9)
        Me.HotbarContainer9.Controls.Add(Me.HotbarEquippedLabel9)
        Me.HotbarContainer9.Controls.Add(Me.HotbarIcon9)
        Me.HotbarContainer9.Location = New System.Drawing.Point(368, 4)
        Me.HotbarContainer9.Name = "HotbarContainer9"
        Me.HotbarContainer9.Size = New System.Drawing.Size(34, 35)
        Me.HotbarContainer9.TabIndex = 46
        '
        'HotbarLabel9
        '
        Me.HotbarLabel9.AutoSize = True
        Me.HotbarLabel9.BackColor = System.Drawing.Color.Transparent
        Me.HotbarLabel9.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarLabel9.ForeColor = System.Drawing.Color.White
        Me.HotbarLabel9.Location = New System.Drawing.Point(24, 24)
        Me.HotbarLabel9.Name = "HotbarLabel9"
        Me.HotbarLabel9.Size = New System.Drawing.Size(12, 14)
        Me.HotbarLabel9.TabIndex = 9
        Me.HotbarLabel9.Text = "0"
        '
        'HotbarCooldownLabel9
        '
        Me.HotbarCooldownLabel9.AutoSize = True
        Me.HotbarCooldownLabel9.BackColor = System.Drawing.Color.Transparent
        Me.HotbarCooldownLabel9.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarCooldownLabel9.ForeColor = System.Drawing.Color.White
        Me.HotbarCooldownLabel9.Location = New System.Drawing.Point(14, 12)
        Me.HotbarCooldownLabel9.Name = "HotbarCooldownLabel9"
        Me.HotbarCooldownLabel9.Size = New System.Drawing.Size(12, 14)
        Me.HotbarCooldownLabel9.TabIndex = 8
        Me.HotbarCooldownLabel9.Text = "0"
        '
        'HotbarEquippedLabel9
        '
        Me.HotbarEquippedLabel9.AutoSize = True
        Me.HotbarEquippedLabel9.BackColor = System.Drawing.Color.Transparent
        Me.HotbarEquippedLabel9.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarEquippedLabel9.ForeColor = System.Drawing.Color.White
        Me.HotbarEquippedLabel9.Location = New System.Drawing.Point(24, 0)
        Me.HotbarEquippedLabel9.Name = "HotbarEquippedLabel9"
        Me.HotbarEquippedLabel9.Size = New System.Drawing.Size(12, 14)
        Me.HotbarEquippedLabel9.TabIndex = 7
        Me.HotbarEquippedLabel9.Text = "0"
        '
        'HotbarIcon9
        '
        Me.HotbarIcon9.BackColor = System.Drawing.Color.Transparent
        Me.HotbarIcon9.BackgroundImage = CType(resources.GetObject("HotbarIcon9.BackgroundImage"), System.Drawing.Image)
        Me.HotbarIcon9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HotbarIcon9.Location = New System.Drawing.Point(1, 1)
        Me.HotbarIcon9.Name = "HotbarIcon9"
        Me.HotbarIcon9.Size = New System.Drawing.Size(32, 32)
        Me.HotbarIcon9.TabIndex = 0
        Me.HotbarIcon9.TabStop = False
        '
        'HotbarContainer8
        '
        Me.HotbarContainer8.BackgroundImage = CType(resources.GetObject("HotbarContainer8.BackgroundImage"), System.Drawing.Image)
        Me.HotbarContainer8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HotbarContainer8.Controls.Add(Me.HotbarLabel8)
        Me.HotbarContainer8.Controls.Add(Me.HotbarCooldownLabel8)
        Me.HotbarContainer8.Controls.Add(Me.HotbarEquippedLabel8)
        Me.HotbarContainer8.Controls.Add(Me.HotbarIcon8)
        Me.HotbarContainer8.Location = New System.Drawing.Point(328, 4)
        Me.HotbarContainer8.Name = "HotbarContainer8"
        Me.HotbarContainer8.Size = New System.Drawing.Size(34, 35)
        Me.HotbarContainer8.TabIndex = 45
        '
        'HotbarLabel8
        '
        Me.HotbarLabel8.AutoSize = True
        Me.HotbarLabel8.BackColor = System.Drawing.Color.Transparent
        Me.HotbarLabel8.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarLabel8.ForeColor = System.Drawing.Color.White
        Me.HotbarLabel8.Location = New System.Drawing.Point(24, 24)
        Me.HotbarLabel8.Name = "HotbarLabel8"
        Me.HotbarLabel8.Size = New System.Drawing.Size(12, 14)
        Me.HotbarLabel8.TabIndex = 9
        Me.HotbarLabel8.Text = "0"
        '
        'HotbarCooldownLabel8
        '
        Me.HotbarCooldownLabel8.AutoSize = True
        Me.HotbarCooldownLabel8.BackColor = System.Drawing.Color.Transparent
        Me.HotbarCooldownLabel8.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarCooldownLabel8.ForeColor = System.Drawing.Color.White
        Me.HotbarCooldownLabel8.Location = New System.Drawing.Point(14, 12)
        Me.HotbarCooldownLabel8.Name = "HotbarCooldownLabel8"
        Me.HotbarCooldownLabel8.Size = New System.Drawing.Size(12, 14)
        Me.HotbarCooldownLabel8.TabIndex = 8
        Me.HotbarCooldownLabel8.Text = "0"
        '
        'HotbarEquippedLabel8
        '
        Me.HotbarEquippedLabel8.AutoSize = True
        Me.HotbarEquippedLabel8.BackColor = System.Drawing.Color.Transparent
        Me.HotbarEquippedLabel8.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarEquippedLabel8.ForeColor = System.Drawing.Color.White
        Me.HotbarEquippedLabel8.Location = New System.Drawing.Point(24, 0)
        Me.HotbarEquippedLabel8.Name = "HotbarEquippedLabel8"
        Me.HotbarEquippedLabel8.Size = New System.Drawing.Size(12, 14)
        Me.HotbarEquippedLabel8.TabIndex = 7
        Me.HotbarEquippedLabel8.Text = "0"
        '
        'HotbarIcon8
        '
        Me.HotbarIcon8.BackColor = System.Drawing.Color.Transparent
        Me.HotbarIcon8.BackgroundImage = CType(resources.GetObject("HotbarIcon8.BackgroundImage"), System.Drawing.Image)
        Me.HotbarIcon8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HotbarIcon8.Location = New System.Drawing.Point(1, 1)
        Me.HotbarIcon8.Name = "HotbarIcon8"
        Me.HotbarIcon8.Size = New System.Drawing.Size(32, 32)
        Me.HotbarIcon8.TabIndex = 0
        Me.HotbarIcon8.TabStop = False
        '
        'HotbarContainer7
        '
        Me.HotbarContainer7.BackgroundImage = CType(resources.GetObject("HotbarContainer7.BackgroundImage"), System.Drawing.Image)
        Me.HotbarContainer7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HotbarContainer7.Controls.Add(Me.HotbarLabel7)
        Me.HotbarContainer7.Controls.Add(Me.HotbarCooldownLabel7)
        Me.HotbarContainer7.Controls.Add(Me.HotbarEquippedLabel7)
        Me.HotbarContainer7.Controls.Add(Me.HotbarIcon7)
        Me.HotbarContainer7.Location = New System.Drawing.Point(288, 4)
        Me.HotbarContainer7.Name = "HotbarContainer7"
        Me.HotbarContainer7.Size = New System.Drawing.Size(34, 35)
        Me.HotbarContainer7.TabIndex = 44
        '
        'HotbarLabel7
        '
        Me.HotbarLabel7.AutoSize = True
        Me.HotbarLabel7.BackColor = System.Drawing.Color.Transparent
        Me.HotbarLabel7.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarLabel7.ForeColor = System.Drawing.Color.White
        Me.HotbarLabel7.Location = New System.Drawing.Point(24, 24)
        Me.HotbarLabel7.Name = "HotbarLabel7"
        Me.HotbarLabel7.Size = New System.Drawing.Size(12, 14)
        Me.HotbarLabel7.TabIndex = 9
        Me.HotbarLabel7.Text = "0"
        '
        'HotbarCooldownLabel7
        '
        Me.HotbarCooldownLabel7.AutoSize = True
        Me.HotbarCooldownLabel7.BackColor = System.Drawing.Color.Transparent
        Me.HotbarCooldownLabel7.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarCooldownLabel7.ForeColor = System.Drawing.Color.White
        Me.HotbarCooldownLabel7.Location = New System.Drawing.Point(14, 12)
        Me.HotbarCooldownLabel7.Name = "HotbarCooldownLabel7"
        Me.HotbarCooldownLabel7.Size = New System.Drawing.Size(12, 14)
        Me.HotbarCooldownLabel7.TabIndex = 8
        Me.HotbarCooldownLabel7.Text = "0"
        '
        'HotbarEquippedLabel7
        '
        Me.HotbarEquippedLabel7.AutoSize = True
        Me.HotbarEquippedLabel7.BackColor = System.Drawing.Color.Transparent
        Me.HotbarEquippedLabel7.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarEquippedLabel7.ForeColor = System.Drawing.Color.White
        Me.HotbarEquippedLabel7.Location = New System.Drawing.Point(24, 0)
        Me.HotbarEquippedLabel7.Name = "HotbarEquippedLabel7"
        Me.HotbarEquippedLabel7.Size = New System.Drawing.Size(12, 14)
        Me.HotbarEquippedLabel7.TabIndex = 7
        Me.HotbarEquippedLabel7.Text = "0"
        '
        'HotbarIcon7
        '
        Me.HotbarIcon7.BackColor = System.Drawing.Color.Transparent
        Me.HotbarIcon7.BackgroundImage = CType(resources.GetObject("HotbarIcon7.BackgroundImage"), System.Drawing.Image)
        Me.HotbarIcon7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HotbarIcon7.Location = New System.Drawing.Point(1, 1)
        Me.HotbarIcon7.Name = "HotbarIcon7"
        Me.HotbarIcon7.Size = New System.Drawing.Size(32, 32)
        Me.HotbarIcon7.TabIndex = 0
        Me.HotbarIcon7.TabStop = False
        '
        'HotbarContainer6
        '
        Me.HotbarContainer6.BackgroundImage = CType(resources.GetObject("HotbarContainer6.BackgroundImage"), System.Drawing.Image)
        Me.HotbarContainer6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HotbarContainer6.Controls.Add(Me.HotbarLabel6)
        Me.HotbarContainer6.Controls.Add(Me.HotbarCooldownLabel6)
        Me.HotbarContainer6.Controls.Add(Me.HotbarEquippedLabel6)
        Me.HotbarContainer6.Controls.Add(Me.HotbarIcon6)
        Me.HotbarContainer6.Location = New System.Drawing.Point(248, 4)
        Me.HotbarContainer6.Name = "HotbarContainer6"
        Me.HotbarContainer6.Size = New System.Drawing.Size(34, 35)
        Me.HotbarContainer6.TabIndex = 43
        '
        'HotbarLabel6
        '
        Me.HotbarLabel6.AutoSize = True
        Me.HotbarLabel6.BackColor = System.Drawing.Color.Transparent
        Me.HotbarLabel6.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarLabel6.ForeColor = System.Drawing.Color.White
        Me.HotbarLabel6.Location = New System.Drawing.Point(24, 24)
        Me.HotbarLabel6.Name = "HotbarLabel6"
        Me.HotbarLabel6.Size = New System.Drawing.Size(12, 14)
        Me.HotbarLabel6.TabIndex = 9
        Me.HotbarLabel6.Text = "0"
        '
        'HotbarCooldownLabel6
        '
        Me.HotbarCooldownLabel6.AutoSize = True
        Me.HotbarCooldownLabel6.BackColor = System.Drawing.Color.Transparent
        Me.HotbarCooldownLabel6.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarCooldownLabel6.ForeColor = System.Drawing.Color.White
        Me.HotbarCooldownLabel6.Location = New System.Drawing.Point(14, 12)
        Me.HotbarCooldownLabel6.Name = "HotbarCooldownLabel6"
        Me.HotbarCooldownLabel6.Size = New System.Drawing.Size(12, 14)
        Me.HotbarCooldownLabel6.TabIndex = 8
        Me.HotbarCooldownLabel6.Text = "0"
        '
        'HotbarEquippedLabel6
        '
        Me.HotbarEquippedLabel6.AutoSize = True
        Me.HotbarEquippedLabel6.BackColor = System.Drawing.Color.Transparent
        Me.HotbarEquippedLabel6.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarEquippedLabel6.ForeColor = System.Drawing.Color.White
        Me.HotbarEquippedLabel6.Location = New System.Drawing.Point(24, 0)
        Me.HotbarEquippedLabel6.Name = "HotbarEquippedLabel6"
        Me.HotbarEquippedLabel6.Size = New System.Drawing.Size(12, 14)
        Me.HotbarEquippedLabel6.TabIndex = 7
        Me.HotbarEquippedLabel6.Text = "0"
        '
        'HotbarIcon6
        '
        Me.HotbarIcon6.BackColor = System.Drawing.Color.Transparent
        Me.HotbarIcon6.BackgroundImage = CType(resources.GetObject("HotbarIcon6.BackgroundImage"), System.Drawing.Image)
        Me.HotbarIcon6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HotbarIcon6.Location = New System.Drawing.Point(1, 1)
        Me.HotbarIcon6.Name = "HotbarIcon6"
        Me.HotbarIcon6.Size = New System.Drawing.Size(32, 32)
        Me.HotbarIcon6.TabIndex = 0
        Me.HotbarIcon6.TabStop = False
        '
        'HotbarContainer5
        '
        Me.HotbarContainer5.BackgroundImage = CType(resources.GetObject("HotbarContainer5.BackgroundImage"), System.Drawing.Image)
        Me.HotbarContainer5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HotbarContainer5.Controls.Add(Me.HotbarLabel5)
        Me.HotbarContainer5.Controls.Add(Me.HotbarCooldownLabel5)
        Me.HotbarContainer5.Controls.Add(Me.HotbarEquippedLabel5)
        Me.HotbarContainer5.Controls.Add(Me.HotbarIcon5)
        Me.HotbarContainer5.Location = New System.Drawing.Point(208, 4)
        Me.HotbarContainer5.Name = "HotbarContainer5"
        Me.HotbarContainer5.Size = New System.Drawing.Size(34, 35)
        Me.HotbarContainer5.TabIndex = 42
        '
        'HotbarLabel5
        '
        Me.HotbarLabel5.AutoSize = True
        Me.HotbarLabel5.BackColor = System.Drawing.Color.Transparent
        Me.HotbarLabel5.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarLabel5.ForeColor = System.Drawing.Color.White
        Me.HotbarLabel5.Location = New System.Drawing.Point(24, 24)
        Me.HotbarLabel5.Name = "HotbarLabel5"
        Me.HotbarLabel5.Size = New System.Drawing.Size(12, 14)
        Me.HotbarLabel5.TabIndex = 9
        Me.HotbarLabel5.Text = "0"
        '
        'HotbarCooldownLabel5
        '
        Me.HotbarCooldownLabel5.AutoSize = True
        Me.HotbarCooldownLabel5.BackColor = System.Drawing.Color.Transparent
        Me.HotbarCooldownLabel5.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarCooldownLabel5.ForeColor = System.Drawing.Color.White
        Me.HotbarCooldownLabel5.Location = New System.Drawing.Point(14, 12)
        Me.HotbarCooldownLabel5.Name = "HotbarCooldownLabel5"
        Me.HotbarCooldownLabel5.Size = New System.Drawing.Size(12, 14)
        Me.HotbarCooldownLabel5.TabIndex = 8
        Me.HotbarCooldownLabel5.Text = "0"
        '
        'HotbarEquippedLabel5
        '
        Me.HotbarEquippedLabel5.AutoSize = True
        Me.HotbarEquippedLabel5.BackColor = System.Drawing.Color.Transparent
        Me.HotbarEquippedLabel5.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarEquippedLabel5.ForeColor = System.Drawing.Color.White
        Me.HotbarEquippedLabel5.Location = New System.Drawing.Point(24, 0)
        Me.HotbarEquippedLabel5.Name = "HotbarEquippedLabel5"
        Me.HotbarEquippedLabel5.Size = New System.Drawing.Size(12, 14)
        Me.HotbarEquippedLabel5.TabIndex = 7
        Me.HotbarEquippedLabel5.Text = "0"
        '
        'HotbarIcon5
        '
        Me.HotbarIcon5.BackColor = System.Drawing.Color.Transparent
        Me.HotbarIcon5.BackgroundImage = CType(resources.GetObject("HotbarIcon5.BackgroundImage"), System.Drawing.Image)
        Me.HotbarIcon5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HotbarIcon5.Location = New System.Drawing.Point(1, 1)
        Me.HotbarIcon5.Name = "HotbarIcon5"
        Me.HotbarIcon5.Size = New System.Drawing.Size(32, 32)
        Me.HotbarIcon5.TabIndex = 0
        Me.HotbarIcon5.TabStop = False
        '
        'HotbarContainer4
        '
        Me.HotbarContainer4.BackgroundImage = CType(resources.GetObject("HotbarContainer4.BackgroundImage"), System.Drawing.Image)
        Me.HotbarContainer4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HotbarContainer4.Controls.Add(Me.HotbarLabel4)
        Me.HotbarContainer4.Controls.Add(Me.HotbarCooldownLabel4)
        Me.HotbarContainer4.Controls.Add(Me.HotbarEquippedLabel4)
        Me.HotbarContainer4.Controls.Add(Me.HotbarIcon4)
        Me.HotbarContainer4.Location = New System.Drawing.Point(168, 4)
        Me.HotbarContainer4.Name = "HotbarContainer4"
        Me.HotbarContainer4.Size = New System.Drawing.Size(34, 35)
        Me.HotbarContainer4.TabIndex = 41
        '
        'HotbarLabel4
        '
        Me.HotbarLabel4.AutoSize = True
        Me.HotbarLabel4.BackColor = System.Drawing.Color.Transparent
        Me.HotbarLabel4.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarLabel4.ForeColor = System.Drawing.Color.White
        Me.HotbarLabel4.Location = New System.Drawing.Point(24, 24)
        Me.HotbarLabel4.Name = "HotbarLabel4"
        Me.HotbarLabel4.Size = New System.Drawing.Size(12, 14)
        Me.HotbarLabel4.TabIndex = 9
        Me.HotbarLabel4.Text = "0"
        '
        'HotbarCooldownLabel4
        '
        Me.HotbarCooldownLabel4.AutoSize = True
        Me.HotbarCooldownLabel4.BackColor = System.Drawing.Color.Transparent
        Me.HotbarCooldownLabel4.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarCooldownLabel4.ForeColor = System.Drawing.Color.White
        Me.HotbarCooldownLabel4.Location = New System.Drawing.Point(14, 12)
        Me.HotbarCooldownLabel4.Name = "HotbarCooldownLabel4"
        Me.HotbarCooldownLabel4.Size = New System.Drawing.Size(12, 14)
        Me.HotbarCooldownLabel4.TabIndex = 8
        Me.HotbarCooldownLabel4.Text = "0"
        '
        'HotbarEquippedLabel4
        '
        Me.HotbarEquippedLabel4.AutoSize = True
        Me.HotbarEquippedLabel4.BackColor = System.Drawing.Color.Transparent
        Me.HotbarEquippedLabel4.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarEquippedLabel4.ForeColor = System.Drawing.Color.White
        Me.HotbarEquippedLabel4.Location = New System.Drawing.Point(24, 0)
        Me.HotbarEquippedLabel4.Name = "HotbarEquippedLabel4"
        Me.HotbarEquippedLabel4.Size = New System.Drawing.Size(12, 14)
        Me.HotbarEquippedLabel4.TabIndex = 7
        Me.HotbarEquippedLabel4.Text = "0"
        '
        'HotbarIcon4
        '
        Me.HotbarIcon4.BackColor = System.Drawing.Color.Transparent
        Me.HotbarIcon4.BackgroundImage = CType(resources.GetObject("HotbarIcon4.BackgroundImage"), System.Drawing.Image)
        Me.HotbarIcon4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HotbarIcon4.Location = New System.Drawing.Point(1, 1)
        Me.HotbarIcon4.Name = "HotbarIcon4"
        Me.HotbarIcon4.Size = New System.Drawing.Size(32, 32)
        Me.HotbarIcon4.TabIndex = 0
        Me.HotbarIcon4.TabStop = False
        '
        'HotbarContainer3
        '
        Me.HotbarContainer3.BackgroundImage = CType(resources.GetObject("HotbarContainer3.BackgroundImage"), System.Drawing.Image)
        Me.HotbarContainer3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HotbarContainer3.Controls.Add(Me.HotbarLabel3)
        Me.HotbarContainer3.Controls.Add(Me.HotbarCooldownLabel3)
        Me.HotbarContainer3.Controls.Add(Me.HotbarEquippedLabel3)
        Me.HotbarContainer3.Controls.Add(Me.HotbarIcon3)
        Me.HotbarContainer3.Location = New System.Drawing.Point(128, 4)
        Me.HotbarContainer3.Name = "HotbarContainer3"
        Me.HotbarContainer3.Size = New System.Drawing.Size(34, 35)
        Me.HotbarContainer3.TabIndex = 40
        '
        'HotbarLabel3
        '
        Me.HotbarLabel3.AutoSize = True
        Me.HotbarLabel3.BackColor = System.Drawing.Color.Transparent
        Me.HotbarLabel3.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarLabel3.ForeColor = System.Drawing.Color.White
        Me.HotbarLabel3.Location = New System.Drawing.Point(24, 24)
        Me.HotbarLabel3.Name = "HotbarLabel3"
        Me.HotbarLabel3.Size = New System.Drawing.Size(12, 14)
        Me.HotbarLabel3.TabIndex = 9
        Me.HotbarLabel3.Text = "0"
        '
        'HotbarCooldownLabel3
        '
        Me.HotbarCooldownLabel3.AutoSize = True
        Me.HotbarCooldownLabel3.BackColor = System.Drawing.Color.Transparent
        Me.HotbarCooldownLabel3.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarCooldownLabel3.ForeColor = System.Drawing.Color.White
        Me.HotbarCooldownLabel3.Location = New System.Drawing.Point(14, 12)
        Me.HotbarCooldownLabel3.Name = "HotbarCooldownLabel3"
        Me.HotbarCooldownLabel3.Size = New System.Drawing.Size(12, 14)
        Me.HotbarCooldownLabel3.TabIndex = 8
        Me.HotbarCooldownLabel3.Text = "0"
        '
        'HotbarEquippedLabel3
        '
        Me.HotbarEquippedLabel3.AutoSize = True
        Me.HotbarEquippedLabel3.BackColor = System.Drawing.Color.Transparent
        Me.HotbarEquippedLabel3.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarEquippedLabel3.ForeColor = System.Drawing.Color.White
        Me.HotbarEquippedLabel3.Location = New System.Drawing.Point(24, 0)
        Me.HotbarEquippedLabel3.Name = "HotbarEquippedLabel3"
        Me.HotbarEquippedLabel3.Size = New System.Drawing.Size(12, 14)
        Me.HotbarEquippedLabel3.TabIndex = 7
        Me.HotbarEquippedLabel3.Text = "0"
        '
        'HotbarIcon3
        '
        Me.HotbarIcon3.BackColor = System.Drawing.Color.Transparent
        Me.HotbarIcon3.BackgroundImage = CType(resources.GetObject("HotbarIcon3.BackgroundImage"), System.Drawing.Image)
        Me.HotbarIcon3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HotbarIcon3.Location = New System.Drawing.Point(1, 1)
        Me.HotbarIcon3.Name = "HotbarIcon3"
        Me.HotbarIcon3.Size = New System.Drawing.Size(32, 32)
        Me.HotbarIcon3.TabIndex = 0
        Me.HotbarIcon3.TabStop = False
        '
        'HotbarContainer2
        '
        Me.HotbarContainer2.BackgroundImage = CType(resources.GetObject("HotbarContainer2.BackgroundImage"), System.Drawing.Image)
        Me.HotbarContainer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HotbarContainer2.Controls.Add(Me.HotbarLabel2)
        Me.HotbarContainer2.Controls.Add(Me.HotbarCooldownLabel2)
        Me.HotbarContainer2.Controls.Add(Me.HotbarEquippedLabel2)
        Me.HotbarContainer2.Controls.Add(Me.HotbarIcon2)
        Me.HotbarContainer2.Location = New System.Drawing.Point(88, 4)
        Me.HotbarContainer2.Name = "HotbarContainer2"
        Me.HotbarContainer2.Size = New System.Drawing.Size(34, 35)
        Me.HotbarContainer2.TabIndex = 39
        '
        'HotbarLabel2
        '
        Me.HotbarLabel2.AutoSize = True
        Me.HotbarLabel2.BackColor = System.Drawing.Color.Transparent
        Me.HotbarLabel2.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarLabel2.ForeColor = System.Drawing.Color.White
        Me.HotbarLabel2.Location = New System.Drawing.Point(24, 24)
        Me.HotbarLabel2.Name = "HotbarLabel2"
        Me.HotbarLabel2.Size = New System.Drawing.Size(12, 14)
        Me.HotbarLabel2.TabIndex = 9
        Me.HotbarLabel2.Text = "0"
        '
        'HotbarCooldownLabel2
        '
        Me.HotbarCooldownLabel2.AutoSize = True
        Me.HotbarCooldownLabel2.BackColor = System.Drawing.Color.Transparent
        Me.HotbarCooldownLabel2.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarCooldownLabel2.ForeColor = System.Drawing.Color.White
        Me.HotbarCooldownLabel2.Location = New System.Drawing.Point(14, 12)
        Me.HotbarCooldownLabel2.Name = "HotbarCooldownLabel2"
        Me.HotbarCooldownLabel2.Size = New System.Drawing.Size(12, 14)
        Me.HotbarCooldownLabel2.TabIndex = 8
        Me.HotbarCooldownLabel2.Text = "0"
        '
        'HotbarEquippedLabel2
        '
        Me.HotbarEquippedLabel2.AutoSize = True
        Me.HotbarEquippedLabel2.BackColor = System.Drawing.Color.Transparent
        Me.HotbarEquippedLabel2.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarEquippedLabel2.ForeColor = System.Drawing.Color.White
        Me.HotbarEquippedLabel2.Location = New System.Drawing.Point(24, 0)
        Me.HotbarEquippedLabel2.Name = "HotbarEquippedLabel2"
        Me.HotbarEquippedLabel2.Size = New System.Drawing.Size(12, 14)
        Me.HotbarEquippedLabel2.TabIndex = 7
        Me.HotbarEquippedLabel2.Text = "0"
        '
        'HotbarIcon2
        '
        Me.HotbarIcon2.BackColor = System.Drawing.Color.Transparent
        Me.HotbarIcon2.BackgroundImage = CType(resources.GetObject("HotbarIcon2.BackgroundImage"), System.Drawing.Image)
        Me.HotbarIcon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HotbarIcon2.Location = New System.Drawing.Point(1, 1)
        Me.HotbarIcon2.Name = "HotbarIcon2"
        Me.HotbarIcon2.Size = New System.Drawing.Size(32, 32)
        Me.HotbarIcon2.TabIndex = 0
        Me.HotbarIcon2.TabStop = False
        '
        'HotbarContainer1
        '
        Me.HotbarContainer1.BackgroundImage = CType(resources.GetObject("HotbarContainer1.BackgroundImage"), System.Drawing.Image)
        Me.HotbarContainer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HotbarContainer1.Controls.Add(Me.HotbarLabel1)
        Me.HotbarContainer1.Controls.Add(Me.HotbarCooldownLabel1)
        Me.HotbarContainer1.Controls.Add(Me.HotbarEquippedLabel1)
        Me.HotbarContainer1.Controls.Add(Me.HotbarIcon1)
        Me.HotbarContainer1.Location = New System.Drawing.Point(48, 4)
        Me.HotbarContainer1.Name = "HotbarContainer1"
        Me.HotbarContainer1.Size = New System.Drawing.Size(34, 35)
        Me.HotbarContainer1.TabIndex = 38
        '
        'HotbarLabel1
        '
        Me.HotbarLabel1.AutoSize = True
        Me.HotbarLabel1.BackColor = System.Drawing.Color.Transparent
        Me.HotbarLabel1.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarLabel1.ForeColor = System.Drawing.Color.White
        Me.HotbarLabel1.Location = New System.Drawing.Point(24, 24)
        Me.HotbarLabel1.Name = "HotbarLabel1"
        Me.HotbarLabel1.Size = New System.Drawing.Size(12, 14)
        Me.HotbarLabel1.TabIndex = 9
        Me.HotbarLabel1.Text = "0"
        '
        'HotbarCooldownLabel1
        '
        Me.HotbarCooldownLabel1.AutoSize = True
        Me.HotbarCooldownLabel1.BackColor = System.Drawing.Color.Transparent
        Me.HotbarCooldownLabel1.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarCooldownLabel1.ForeColor = System.Drawing.Color.White
        Me.HotbarCooldownLabel1.Location = New System.Drawing.Point(14, 12)
        Me.HotbarCooldownLabel1.Name = "HotbarCooldownLabel1"
        Me.HotbarCooldownLabel1.Size = New System.Drawing.Size(12, 14)
        Me.HotbarCooldownLabel1.TabIndex = 8
        Me.HotbarCooldownLabel1.Text = "0"
        '
        'HotbarEquippedLabel1
        '
        Me.HotbarEquippedLabel1.AutoSize = True
        Me.HotbarEquippedLabel1.BackColor = System.Drawing.Color.Transparent
        Me.HotbarEquippedLabel1.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarEquippedLabel1.ForeColor = System.Drawing.Color.White
        Me.HotbarEquippedLabel1.Location = New System.Drawing.Point(24, 0)
        Me.HotbarEquippedLabel1.Name = "HotbarEquippedLabel1"
        Me.HotbarEquippedLabel1.Size = New System.Drawing.Size(12, 14)
        Me.HotbarEquippedLabel1.TabIndex = 7
        Me.HotbarEquippedLabel1.Text = "0"
        '
        'HotbarIcon1
        '
        Me.HotbarIcon1.BackColor = System.Drawing.Color.Transparent
        Me.HotbarIcon1.BackgroundImage = CType(resources.GetObject("HotbarIcon1.BackgroundImage"), System.Drawing.Image)
        Me.HotbarIcon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HotbarIcon1.Location = New System.Drawing.Point(1, 1)
        Me.HotbarIcon1.Name = "HotbarIcon1"
        Me.HotbarIcon1.Size = New System.Drawing.Size(32, 32)
        Me.HotbarIcon1.TabIndex = 0
        Me.HotbarIcon1.TabStop = False
        '
        'HotbarContainer0
        '
        Me.HotbarContainer0.BackgroundImage = CType(resources.GetObject("HotbarContainer0.BackgroundImage"), System.Drawing.Image)
        Me.HotbarContainer0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HotbarContainer0.Controls.Add(Me.HotbarLabel0)
        Me.HotbarContainer0.Controls.Add(Me.HotbarCooldownLabel0)
        Me.HotbarContainer0.Controls.Add(Me.HotbarEquippedLabel0)
        Me.HotbarContainer0.Controls.Add(Me.HotbarIcon0)
        Me.HotbarContainer0.Location = New System.Drawing.Point(8, 4)
        Me.HotbarContainer0.Name = "HotbarContainer0"
        Me.HotbarContainer0.Size = New System.Drawing.Size(34, 35)
        Me.HotbarContainer0.TabIndex = 37
        '
        'HotbarLabel0
        '
        Me.HotbarLabel0.AutoSize = True
        Me.HotbarLabel0.BackColor = System.Drawing.Color.Transparent
        Me.HotbarLabel0.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarLabel0.ForeColor = System.Drawing.Color.White
        Me.HotbarLabel0.Location = New System.Drawing.Point(24, 24)
        Me.HotbarLabel0.Name = "HotbarLabel0"
        Me.HotbarLabel0.Size = New System.Drawing.Size(12, 14)
        Me.HotbarLabel0.TabIndex = 9
        Me.HotbarLabel0.Text = "0"
        '
        'HotbarCooldownLabel0
        '
        Me.HotbarCooldownLabel0.AutoSize = True
        Me.HotbarCooldownLabel0.BackColor = System.Drawing.Color.Transparent
        Me.HotbarCooldownLabel0.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarCooldownLabel0.ForeColor = System.Drawing.Color.White
        Me.HotbarCooldownLabel0.Location = New System.Drawing.Point(14, 12)
        Me.HotbarCooldownLabel0.Name = "HotbarCooldownLabel0"
        Me.HotbarCooldownLabel0.Size = New System.Drawing.Size(12, 14)
        Me.HotbarCooldownLabel0.TabIndex = 8
        Me.HotbarCooldownLabel0.Text = "0"
        '
        'HotbarEquippedLabel0
        '
        Me.HotbarEquippedLabel0.AutoSize = True
        Me.HotbarEquippedLabel0.BackColor = System.Drawing.Color.Transparent
        Me.HotbarEquippedLabel0.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotbarEquippedLabel0.ForeColor = System.Drawing.Color.White
        Me.HotbarEquippedLabel0.Location = New System.Drawing.Point(24, 0)
        Me.HotbarEquippedLabel0.Name = "HotbarEquippedLabel0"
        Me.HotbarEquippedLabel0.Size = New System.Drawing.Size(12, 14)
        Me.HotbarEquippedLabel0.TabIndex = 7
        Me.HotbarEquippedLabel0.Text = "0"
        '
        'HotbarIcon0
        '
        Me.HotbarIcon0.BackColor = System.Drawing.Color.Transparent
        Me.HotbarIcon0.BackgroundImage = CType(resources.GetObject("HotbarIcon0.BackgroundImage"), System.Drawing.Image)
        Me.HotbarIcon0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HotbarIcon0.Location = New System.Drawing.Point(1, 1)
        Me.HotbarIcon0.Name = "HotbarIcon0"
        Me.HotbarIcon0.Size = New System.Drawing.Size(32, 32)
        Me.HotbarIcon0.TabIndex = 0
        Me.HotbarIcon0.TabStop = False
        '
        'MainFriendsWindowPanel
        '
        Me.MainFriendsWindowPanel.BackgroundImage = CType(resources.GetObject("MainFriendsWindowPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainFriendsWindowPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainFriendsWindowPanel.Controls.Add(Me.AddFriendPopupButton)
        Me.MainFriendsWindowPanel.Controls.Add(Me.FriendsWindowCloseButton)
        Me.MainFriendsWindowPanel.Controls.Add(Me.FriendsWindowTitle)
        Me.MainFriendsWindowPanel.Location = New System.Drawing.Point(1283, 694)
        Me.MainFriendsWindowPanel.Name = "MainFriendsWindowPanel"
        Me.MainFriendsWindowPanel.Size = New System.Drawing.Size(220, 339)
        Me.MainFriendsWindowPanel.TabIndex = 37
        Me.MainFriendsWindowPanel.Visible = False
        '
        'AddFriendPopupButton
        '
        Me.AddFriendPopupButton.BackColor = System.Drawing.Color.Transparent
        Me.AddFriendPopupButton.BackgroundImage = CType(resources.GetObject("AddFriendPopupButton.BackgroundImage"), System.Drawing.Image)
        Me.AddFriendPopupButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AddFriendPopupButton.Location = New System.Drawing.Point(50, 268)
        Me.AddFriendPopupButton.Name = "AddFriendPopupButton"
        Me.AddFriendPopupButton.Size = New System.Drawing.Size(120, 28)
        Me.AddFriendPopupButton.TabIndex = 20
        Me.AddFriendPopupButton.TabStop = False
        '
        'FriendsWindowCloseButton
        '
        Me.FriendsWindowCloseButton.BackColor = System.Drawing.Color.Transparent
        Me.FriendsWindowCloseButton.BackgroundImage = CType(resources.GetObject("FriendsWindowCloseButton.BackgroundImage"), System.Drawing.Image)
        Me.FriendsWindowCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FriendsWindowCloseButton.Location = New System.Drawing.Point(194, 5)
        Me.FriendsWindowCloseButton.Name = "FriendsWindowCloseButton"
        Me.FriendsWindowCloseButton.Size = New System.Drawing.Size(26, 25)
        Me.FriendsWindowCloseButton.TabIndex = 19
        Me.FriendsWindowCloseButton.TabStop = False
        '
        'FriendsWindowTitle
        '
        Me.FriendsWindowTitle.AutoSize = True
        Me.FriendsWindowTitle.BackColor = System.Drawing.Color.Transparent
        Me.FriendsWindowTitle.Font = New System.Drawing.Font("Source Sans Pro SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FriendsWindowTitle.ForeColor = System.Drawing.Color.White
        Me.FriendsWindowTitle.Location = New System.Drawing.Point(40, 7)
        Me.FriendsWindowTitle.Name = "FriendsWindowTitle"
        Me.FriendsWindowTitle.Size = New System.Drawing.Size(60, 20)
        Me.FriendsWindowTitle.TabIndex = 3
        Me.FriendsWindowTitle.Text = "Friends"
        '
        'MainEventDialogWindow4ResponsePanel
        '
        Me.MainEventDialogWindow4ResponsePanel.BackgroundImage = CType(resources.GetObject("MainEventDialogWindow4ResponsePanel.BackgroundImage"), System.Drawing.Image)
        Me.MainEventDialogWindow4ResponsePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainEventDialogWindow4ResponsePanel.Controls.Add(Me.Dialog4Response4Button)
        Me.MainEventDialogWindow4ResponsePanel.Controls.Add(Me.Dialog4Response3Button)
        Me.MainEventDialogWindow4ResponsePanel.Controls.Add(Me.Dialog4Response2Button)
        Me.MainEventDialogWindow4ResponsePanel.Controls.Add(Me.Dialog4EventDialogArea)
        Me.MainEventDialogWindow4ResponsePanel.Controls.Add(Me.Dialog4Response1Button)
        Me.MainEventDialogWindow4ResponsePanel.Controls.Add(Me.Dialog4EventFacePanel)
        Me.MainEventDialogWindow4ResponsePanel.Location = New System.Drawing.Point(1508, 807)
        Me.MainEventDialogWindow4ResponsePanel.Name = "MainEventDialogWindow4ResponsePanel"
        Me.MainEventDialogWindow4ResponsePanel.Size = New System.Drawing.Size(520, 300)
        Me.MainEventDialogWindow4ResponsePanel.TabIndex = 36
        Me.MainEventDialogWindow4ResponsePanel.Visible = False
        '
        'Dialog4Response4Button
        '
        Me.Dialog4Response4Button.BackColor = System.Drawing.Color.Transparent
        Me.Dialog4Response4Button.BackgroundImage = CType(resources.GetObject("Dialog4Response4Button.BackgroundImage"), System.Drawing.Image)
        Me.Dialog4Response4Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dialog4Response4Button.Location = New System.Drawing.Point(12, 242)
        Me.Dialog4Response4Button.Name = "Dialog4Response4Button"
        Me.Dialog4Response4Button.Size = New System.Drawing.Size(496, 44)
        Me.Dialog4Response4Button.TabIndex = 22
        Me.Dialog4Response4Button.TabStop = False
        '
        'Dialog4Response3Button
        '
        Me.Dialog4Response3Button.BackColor = System.Drawing.Color.Transparent
        Me.Dialog4Response3Button.BackgroundImage = CType(resources.GetObject("Dialog4Response3Button.BackgroundImage"), System.Drawing.Image)
        Me.Dialog4Response3Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dialog4Response3Button.Location = New System.Drawing.Point(12, 197)
        Me.Dialog4Response3Button.Name = "Dialog4Response3Button"
        Me.Dialog4Response3Button.Size = New System.Drawing.Size(496, 44)
        Me.Dialog4Response3Button.TabIndex = 21
        Me.Dialog4Response3Button.TabStop = False
        '
        'Dialog4Response2Button
        '
        Me.Dialog4Response2Button.BackColor = System.Drawing.Color.Transparent
        Me.Dialog4Response2Button.BackgroundImage = CType(resources.GetObject("Dialog4Response2Button.BackgroundImage"), System.Drawing.Image)
        Me.Dialog4Response2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dialog4Response2Button.Location = New System.Drawing.Point(12, 152)
        Me.Dialog4Response2Button.Name = "Dialog4Response2Button"
        Me.Dialog4Response2Button.Size = New System.Drawing.Size(496, 44)
        Me.Dialog4Response2Button.TabIndex = 20
        Me.Dialog4Response2Button.TabStop = False
        '
        'Dialog4EventDialogArea
        '
        Me.Dialog4EventDialogArea.BackColor = System.Drawing.Color.Transparent
        Me.Dialog4EventDialogArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dialog4EventDialogArea.Controls.Add(Me.Dialog4EventDialogAreaInnerPanel)
        Me.Dialog4EventDialogArea.Location = New System.Drawing.Point(106, 14)
        Me.Dialog4EventDialogArea.Name = "Dialog4EventDialogArea"
        Me.Dialog4EventDialogArea.Size = New System.Drawing.Size(402, 80)
        Me.Dialog4EventDialogArea.TabIndex = 19
        '
        'Dialog4EventDialogAreaInnerPanel
        '
        Me.Dialog4EventDialogAreaInnerPanel.BackColor = System.Drawing.Color.Transparent
        Me.Dialog4EventDialogAreaInnerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dialog4EventDialogAreaInnerPanel.Controls.Add(Me.Dialog4EventDialogLabel)
        Me.Dialog4EventDialogAreaInnerPanel.Location = New System.Drawing.Point(0, 0)
        Me.Dialog4EventDialogAreaInnerPanel.Name = "Dialog4EventDialogAreaInnerPanel"
        Me.Dialog4EventDialogAreaInnerPanel.Size = New System.Drawing.Size(387, 900)
        Me.Dialog4EventDialogAreaInnerPanel.TabIndex = 20
        '
        'Dialog4EventDialogLabel
        '
        Me.Dialog4EventDialogLabel.AutoSize = True
        Me.Dialog4EventDialogLabel.BackColor = System.Drawing.Color.Transparent
        Me.Dialog4EventDialogLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dialog4EventDialogLabel.ForeColor = System.Drawing.Color.White
        Me.Dialog4EventDialogLabel.Location = New System.Drawing.Point(0, 0)
        Me.Dialog4EventDialogLabel.Name = "Dialog4EventDialogLabel"
        Me.Dialog4EventDialogLabel.Size = New System.Drawing.Size(102, 17)
        Me.Dialog4EventDialogLabel.TabIndex = 22
        Me.Dialog4EventDialogLabel.Text = "EventDialogLabel"
        '
        'Dialog4Response1Button
        '
        Me.Dialog4Response1Button.BackColor = System.Drawing.Color.Transparent
        Me.Dialog4Response1Button.BackgroundImage = CType(resources.GetObject("Dialog4Response1Button.BackgroundImage"), System.Drawing.Image)
        Me.Dialog4Response1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dialog4Response1Button.Location = New System.Drawing.Point(12, 107)
        Me.Dialog4Response1Button.Name = "Dialog4Response1Button"
        Me.Dialog4Response1Button.Size = New System.Drawing.Size(496, 44)
        Me.Dialog4Response1Button.TabIndex = 18
        Me.Dialog4Response1Button.TabStop = False
        '
        'Dialog4EventFacePanel
        '
        Me.Dialog4EventFacePanel.BackColor = System.Drawing.Color.Transparent
        Me.Dialog4EventFacePanel.BackgroundImage = CType(resources.GetObject("Dialog4EventFacePanel.BackgroundImage"), System.Drawing.Image)
        Me.Dialog4EventFacePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dialog4EventFacePanel.Location = New System.Drawing.Point(16, 14)
        Me.Dialog4EventFacePanel.Name = "Dialog4EventFacePanel"
        Me.Dialog4EventFacePanel.Size = New System.Drawing.Size(80, 80)
        Me.Dialog4EventFacePanel.TabIndex = 7
        '
        'MainEventDialogWindow3ResponsePanel
        '
        Me.MainEventDialogWindow3ResponsePanel.BackgroundImage = CType(resources.GetObject("MainEventDialogWindow3ResponsePanel.BackgroundImage"), System.Drawing.Image)
        Me.MainEventDialogWindow3ResponsePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainEventDialogWindow3ResponsePanel.Controls.Add(Me.Dialog3Response3Button)
        Me.MainEventDialogWindow3ResponsePanel.Controls.Add(Me.Dialog3Response2Button)
        Me.MainEventDialogWindow3ResponsePanel.Controls.Add(Me.Dialog3EventDialogArea)
        Me.MainEventDialogWindow3ResponsePanel.Controls.Add(Me.Dialog3Response1Button)
        Me.MainEventDialogWindow3ResponsePanel.Controls.Add(Me.Dialog3EventFacePanel)
        Me.MainEventDialogWindow3ResponsePanel.Location = New System.Drawing.Point(1508, 547)
        Me.MainEventDialogWindow3ResponsePanel.Name = "MainEventDialogWindow3ResponsePanel"
        Me.MainEventDialogWindow3ResponsePanel.Size = New System.Drawing.Size(520, 254)
        Me.MainEventDialogWindow3ResponsePanel.TabIndex = 35
        Me.MainEventDialogWindow3ResponsePanel.Visible = False
        '
        'Dialog3Response3Button
        '
        Me.Dialog3Response3Button.BackColor = System.Drawing.Color.Transparent
        Me.Dialog3Response3Button.BackgroundImage = CType(resources.GetObject("Dialog3Response3Button.BackgroundImage"), System.Drawing.Image)
        Me.Dialog3Response3Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dialog3Response3Button.Location = New System.Drawing.Point(12, 197)
        Me.Dialog3Response3Button.Name = "Dialog3Response3Button"
        Me.Dialog3Response3Button.Size = New System.Drawing.Size(496, 44)
        Me.Dialog3Response3Button.TabIndex = 21
        Me.Dialog3Response3Button.TabStop = False
        '
        'Dialog3Response2Button
        '
        Me.Dialog3Response2Button.BackColor = System.Drawing.Color.Transparent
        Me.Dialog3Response2Button.BackgroundImage = CType(resources.GetObject("Dialog3Response2Button.BackgroundImage"), System.Drawing.Image)
        Me.Dialog3Response2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dialog3Response2Button.Location = New System.Drawing.Point(12, 152)
        Me.Dialog3Response2Button.Name = "Dialog3Response2Button"
        Me.Dialog3Response2Button.Size = New System.Drawing.Size(496, 44)
        Me.Dialog3Response2Button.TabIndex = 20
        Me.Dialog3Response2Button.TabStop = False
        '
        'Dialog3EventDialogArea
        '
        Me.Dialog3EventDialogArea.BackColor = System.Drawing.Color.Transparent
        Me.Dialog3EventDialogArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dialog3EventDialogArea.Controls.Add(Me.Dialog3EventDialogAreaInnerPanel)
        Me.Dialog3EventDialogArea.Location = New System.Drawing.Point(106, 14)
        Me.Dialog3EventDialogArea.Name = "Dialog3EventDialogArea"
        Me.Dialog3EventDialogArea.Size = New System.Drawing.Size(402, 80)
        Me.Dialog3EventDialogArea.TabIndex = 19
        '
        'Dialog3EventDialogAreaInnerPanel
        '
        Me.Dialog3EventDialogAreaInnerPanel.BackColor = System.Drawing.Color.Transparent
        Me.Dialog3EventDialogAreaInnerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dialog3EventDialogAreaInnerPanel.Controls.Add(Me.Dialog3EventDialogLabel)
        Me.Dialog3EventDialogAreaInnerPanel.Location = New System.Drawing.Point(0, 0)
        Me.Dialog3EventDialogAreaInnerPanel.Name = "Dialog3EventDialogAreaInnerPanel"
        Me.Dialog3EventDialogAreaInnerPanel.Size = New System.Drawing.Size(387, 900)
        Me.Dialog3EventDialogAreaInnerPanel.TabIndex = 20
        '
        'Dialog3EventDialogLabel
        '
        Me.Dialog3EventDialogLabel.AutoSize = True
        Me.Dialog3EventDialogLabel.BackColor = System.Drawing.Color.Transparent
        Me.Dialog3EventDialogLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dialog3EventDialogLabel.ForeColor = System.Drawing.Color.White
        Me.Dialog3EventDialogLabel.Location = New System.Drawing.Point(0, 0)
        Me.Dialog3EventDialogLabel.Name = "Dialog3EventDialogLabel"
        Me.Dialog3EventDialogLabel.Size = New System.Drawing.Size(102, 17)
        Me.Dialog3EventDialogLabel.TabIndex = 22
        Me.Dialog3EventDialogLabel.Text = "EventDialogLabel"
        '
        'Dialog3Response1Button
        '
        Me.Dialog3Response1Button.BackColor = System.Drawing.Color.Transparent
        Me.Dialog3Response1Button.BackgroundImage = CType(resources.GetObject("Dialog3Response1Button.BackgroundImage"), System.Drawing.Image)
        Me.Dialog3Response1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dialog3Response1Button.Location = New System.Drawing.Point(12, 107)
        Me.Dialog3Response1Button.Name = "Dialog3Response1Button"
        Me.Dialog3Response1Button.Size = New System.Drawing.Size(496, 44)
        Me.Dialog3Response1Button.TabIndex = 18
        Me.Dialog3Response1Button.TabStop = False
        '
        'Dialog3EventFacePanel
        '
        Me.Dialog3EventFacePanel.BackColor = System.Drawing.Color.Transparent
        Me.Dialog3EventFacePanel.BackgroundImage = CType(resources.GetObject("Dialog3EventFacePanel.BackgroundImage"), System.Drawing.Image)
        Me.Dialog3EventFacePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dialog3EventFacePanel.Location = New System.Drawing.Point(16, 14)
        Me.Dialog3EventFacePanel.Name = "Dialog3EventFacePanel"
        Me.Dialog3EventFacePanel.Size = New System.Drawing.Size(80, 80)
        Me.Dialog3EventFacePanel.TabIndex = 7
        '
        'MainEventDialogWindow2ResponsePanel
        '
        Me.MainEventDialogWindow2ResponsePanel.BackgroundImage = CType(resources.GetObject("MainEventDialogWindow2ResponsePanel.BackgroundImage"), System.Drawing.Image)
        Me.MainEventDialogWindow2ResponsePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainEventDialogWindow2ResponsePanel.Controls.Add(Me.Dialog2Response2Button)
        Me.MainEventDialogWindow2ResponsePanel.Controls.Add(Me.Dialog2EventDialogArea)
        Me.MainEventDialogWindow2ResponsePanel.Controls.Add(Me.Dialog2Response1Button)
        Me.MainEventDialogWindow2ResponsePanel.Controls.Add(Me.Dialog2EventFacePanel)
        Me.MainEventDialogWindow2ResponsePanel.Location = New System.Drawing.Point(1508, 336)
        Me.MainEventDialogWindow2ResponsePanel.Name = "MainEventDialogWindow2ResponsePanel"
        Me.MainEventDialogWindow2ResponsePanel.Size = New System.Drawing.Size(520, 208)
        Me.MainEventDialogWindow2ResponsePanel.TabIndex = 34
        Me.MainEventDialogWindow2ResponsePanel.Visible = False
        '
        'Dialog2Response2Button
        '
        Me.Dialog2Response2Button.BackColor = System.Drawing.Color.Transparent
        Me.Dialog2Response2Button.BackgroundImage = CType(resources.GetObject("Dialog2Response2Button.BackgroundImage"), System.Drawing.Image)
        Me.Dialog2Response2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dialog2Response2Button.Location = New System.Drawing.Point(12, 152)
        Me.Dialog2Response2Button.Name = "Dialog2Response2Button"
        Me.Dialog2Response2Button.Size = New System.Drawing.Size(496, 44)
        Me.Dialog2Response2Button.TabIndex = 20
        Me.Dialog2Response2Button.TabStop = False
        '
        'Dialog2EventDialogArea
        '
        Me.Dialog2EventDialogArea.BackColor = System.Drawing.Color.Transparent
        Me.Dialog2EventDialogArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dialog2EventDialogArea.Controls.Add(Me.Dialog2EventDialogAreaInnerPanel)
        Me.Dialog2EventDialogArea.Location = New System.Drawing.Point(106, 14)
        Me.Dialog2EventDialogArea.Name = "Dialog2EventDialogArea"
        Me.Dialog2EventDialogArea.Size = New System.Drawing.Size(402, 80)
        Me.Dialog2EventDialogArea.TabIndex = 19
        '
        'Dialog2EventDialogAreaInnerPanel
        '
        Me.Dialog2EventDialogAreaInnerPanel.BackColor = System.Drawing.Color.Transparent
        Me.Dialog2EventDialogAreaInnerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dialog2EventDialogAreaInnerPanel.Controls.Add(Me.Dialog2EventDialogLabel)
        Me.Dialog2EventDialogAreaInnerPanel.Location = New System.Drawing.Point(0, 0)
        Me.Dialog2EventDialogAreaInnerPanel.Name = "Dialog2EventDialogAreaInnerPanel"
        Me.Dialog2EventDialogAreaInnerPanel.Size = New System.Drawing.Size(387, 900)
        Me.Dialog2EventDialogAreaInnerPanel.TabIndex = 20
        '
        'Dialog2EventDialogLabel
        '
        Me.Dialog2EventDialogLabel.AutoSize = True
        Me.Dialog2EventDialogLabel.BackColor = System.Drawing.Color.Transparent
        Me.Dialog2EventDialogLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dialog2EventDialogLabel.ForeColor = System.Drawing.Color.White
        Me.Dialog2EventDialogLabel.Location = New System.Drawing.Point(0, 0)
        Me.Dialog2EventDialogLabel.Name = "Dialog2EventDialogLabel"
        Me.Dialog2EventDialogLabel.Size = New System.Drawing.Size(102, 17)
        Me.Dialog2EventDialogLabel.TabIndex = 22
        Me.Dialog2EventDialogLabel.Text = "EventDialogLabel"
        '
        'Dialog2Response1Button
        '
        Me.Dialog2Response1Button.BackColor = System.Drawing.Color.Transparent
        Me.Dialog2Response1Button.BackgroundImage = CType(resources.GetObject("Dialog2Response1Button.BackgroundImage"), System.Drawing.Image)
        Me.Dialog2Response1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dialog2Response1Button.Location = New System.Drawing.Point(12, 107)
        Me.Dialog2Response1Button.Name = "Dialog2Response1Button"
        Me.Dialog2Response1Button.Size = New System.Drawing.Size(496, 44)
        Me.Dialog2Response1Button.TabIndex = 18
        Me.Dialog2Response1Button.TabStop = False
        '
        'Dialog2EventFacePanel
        '
        Me.Dialog2EventFacePanel.BackColor = System.Drawing.Color.Transparent
        Me.Dialog2EventFacePanel.BackgroundImage = CType(resources.GetObject("Dialog2EventFacePanel.BackgroundImage"), System.Drawing.Image)
        Me.Dialog2EventFacePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dialog2EventFacePanel.Location = New System.Drawing.Point(16, 14)
        Me.Dialog2EventFacePanel.Name = "Dialog2EventFacePanel"
        Me.Dialog2EventFacePanel.Size = New System.Drawing.Size(80, 80)
        Me.Dialog2EventFacePanel.TabIndex = 7
        '
        'MainEventDialogWindow1ResponsePanel
        '
        Me.MainEventDialogWindow1ResponsePanel.BackgroundImage = CType(resources.GetObject("MainEventDialogWindow1ResponsePanel.BackgroundImage"), System.Drawing.Image)
        Me.MainEventDialogWindow1ResponsePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainEventDialogWindow1ResponsePanel.Controls.Add(Me.Dialog1EventDialogArea)
        Me.MainEventDialogWindow1ResponsePanel.Controls.Add(Me.Dialog1Response1Button)
        Me.MainEventDialogWindow1ResponsePanel.Controls.Add(Me.Dialog1EventFacePanel)
        Me.MainEventDialogWindow1ResponsePanel.Location = New System.Drawing.Point(1508, 168)
        Me.MainEventDialogWindow1ResponsePanel.Name = "MainEventDialogWindow1ResponsePanel"
        Me.MainEventDialogWindow1ResponsePanel.Size = New System.Drawing.Size(520, 162)
        Me.MainEventDialogWindow1ResponsePanel.TabIndex = 33
        Me.MainEventDialogWindow1ResponsePanel.Visible = False
        '
        'Dialog1EventDialogArea
        '
        Me.Dialog1EventDialogArea.BackColor = System.Drawing.Color.Transparent
        Me.Dialog1EventDialogArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dialog1EventDialogArea.Controls.Add(Me.Dialog1EventDialogAreaInnerPanel)
        Me.Dialog1EventDialogArea.Location = New System.Drawing.Point(106, 14)
        Me.Dialog1EventDialogArea.Name = "Dialog1EventDialogArea"
        Me.Dialog1EventDialogArea.Size = New System.Drawing.Size(402, 80)
        Me.Dialog1EventDialogArea.TabIndex = 19
        '
        'Dialog1EventDialogAreaInnerPanel
        '
        Me.Dialog1EventDialogAreaInnerPanel.BackColor = System.Drawing.Color.Transparent
        Me.Dialog1EventDialogAreaInnerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dialog1EventDialogAreaInnerPanel.Controls.Add(Me.Dialog1EventDialogLabel)
        Me.Dialog1EventDialogAreaInnerPanel.Location = New System.Drawing.Point(0, 0)
        Me.Dialog1EventDialogAreaInnerPanel.Name = "Dialog1EventDialogAreaInnerPanel"
        Me.Dialog1EventDialogAreaInnerPanel.Size = New System.Drawing.Size(387, 900)
        Me.Dialog1EventDialogAreaInnerPanel.TabIndex = 20
        '
        'Dialog1EventDialogLabel
        '
        Me.Dialog1EventDialogLabel.AutoSize = True
        Me.Dialog1EventDialogLabel.BackColor = System.Drawing.Color.Transparent
        Me.Dialog1EventDialogLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dialog1EventDialogLabel.ForeColor = System.Drawing.Color.White
        Me.Dialog1EventDialogLabel.Location = New System.Drawing.Point(0, 0)
        Me.Dialog1EventDialogLabel.Name = "Dialog1EventDialogLabel"
        Me.Dialog1EventDialogLabel.Size = New System.Drawing.Size(102, 17)
        Me.Dialog1EventDialogLabel.TabIndex = 22
        Me.Dialog1EventDialogLabel.Text = "EventDialogLabel"
        '
        'Dialog1Response1Button
        '
        Me.Dialog1Response1Button.BackColor = System.Drawing.Color.Transparent
        Me.Dialog1Response1Button.BackgroundImage = CType(resources.GetObject("Dialog1Response1Button.BackgroundImage"), System.Drawing.Image)
        Me.Dialog1Response1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dialog1Response1Button.Location = New System.Drawing.Point(12, 107)
        Me.Dialog1Response1Button.Name = "Dialog1Response1Button"
        Me.Dialog1Response1Button.Size = New System.Drawing.Size(496, 44)
        Me.Dialog1Response1Button.TabIndex = 18
        Me.Dialog1Response1Button.TabStop = False
        '
        'Dialog1EventFacePanel
        '
        Me.Dialog1EventFacePanel.BackColor = System.Drawing.Color.Transparent
        Me.Dialog1EventFacePanel.BackgroundImage = CType(resources.GetObject("Dialog1EventFacePanel.BackgroundImage"), System.Drawing.Image)
        Me.Dialog1EventFacePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dialog1EventFacePanel.Location = New System.Drawing.Point(16, 14)
        Me.Dialog1EventFacePanel.Name = "Dialog1EventFacePanel"
        Me.Dialog1EventFacePanel.Size = New System.Drawing.Size(80, 80)
        Me.Dialog1EventFacePanel.TabIndex = 7
        '
        'MainEscapeMenuPanel
        '
        Me.MainEscapeMenuPanel.BackgroundImage = CType(resources.GetObject("MainEscapeMenuPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainEscapeMenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainEscapeMenuPanel.Controls.Add(Me.EscapeMenuLogoutButton)
        Me.MainEscapeMenuPanel.Controls.Add(Me.EscapeMenuCloseButton)
        Me.MainEscapeMenuPanel.Controls.Add(Me.EscapeMenuExitToDesktopButton)
        Me.MainEscapeMenuPanel.Controls.Add(Me.EscapeMenuCharacterSelectButton)
        Me.MainEscapeMenuPanel.Controls.Add(Me.EscapeMenuOptionsButton)
        Me.MainEscapeMenuPanel.Controls.Add(Me.EscapeMenuTitleLabel)
        Me.MainEscapeMenuPanel.Location = New System.Drawing.Point(825, 822)
        Me.MainEscapeMenuPanel.Name = "MainEscapeMenuPanel"
        Me.MainEscapeMenuPanel.Size = New System.Drawing.Size(452, 213)
        Me.MainEscapeMenuPanel.TabIndex = 32
        Me.MainEscapeMenuPanel.Visible = False
        '
        'EscapeMenuLogoutButton
        '
        Me.EscapeMenuLogoutButton.BackColor = System.Drawing.Color.Transparent
        Me.EscapeMenuLogoutButton.BackgroundImage = CType(resources.GetObject("EscapeMenuLogoutButton.BackgroundImage"), System.Drawing.Image)
        Me.EscapeMenuLogoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EscapeMenuLogoutButton.Location = New System.Drawing.Point(182, 48)
        Me.EscapeMenuLogoutButton.Name = "EscapeMenuLogoutButton"
        Me.EscapeMenuLogoutButton.Size = New System.Drawing.Size(87, 154)
        Me.EscapeMenuLogoutButton.TabIndex = 14
        Me.EscapeMenuLogoutButton.TabStop = False
        '
        'EscapeMenuCloseButton
        '
        Me.EscapeMenuCloseButton.BackColor = System.Drawing.Color.Transparent
        Me.EscapeMenuCloseButton.BackgroundImage = CType(resources.GetObject("EscapeMenuCloseButton.BackgroundImage"), System.Drawing.Image)
        Me.EscapeMenuCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EscapeMenuCloseButton.Location = New System.Drawing.Point(358, 48)
        Me.EscapeMenuCloseButton.Name = "EscapeMenuCloseButton"
        Me.EscapeMenuCloseButton.Size = New System.Drawing.Size(87, 154)
        Me.EscapeMenuCloseButton.TabIndex = 13
        Me.EscapeMenuCloseButton.TabStop = False
        '
        'EscapeMenuExitToDesktopButton
        '
        Me.EscapeMenuExitToDesktopButton.BackColor = System.Drawing.Color.Transparent
        Me.EscapeMenuExitToDesktopButton.BackgroundImage = CType(resources.GetObject("EscapeMenuExitToDesktopButton.BackgroundImage"), System.Drawing.Image)
        Me.EscapeMenuExitToDesktopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EscapeMenuExitToDesktopButton.Location = New System.Drawing.Point(270, 48)
        Me.EscapeMenuExitToDesktopButton.Name = "EscapeMenuExitToDesktopButton"
        Me.EscapeMenuExitToDesktopButton.Size = New System.Drawing.Size(87, 154)
        Me.EscapeMenuExitToDesktopButton.TabIndex = 12
        Me.EscapeMenuExitToDesktopButton.TabStop = False
        '
        'EscapeMenuCharacterSelectButton
        '
        Me.EscapeMenuCharacterSelectButton.BackColor = System.Drawing.Color.Transparent
        Me.EscapeMenuCharacterSelectButton.BackgroundImage = CType(resources.GetObject("EscapeMenuCharacterSelectButton.BackgroundImage"), System.Drawing.Image)
        Me.EscapeMenuCharacterSelectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EscapeMenuCharacterSelectButton.Location = New System.Drawing.Point(94, 48)
        Me.EscapeMenuCharacterSelectButton.Name = "EscapeMenuCharacterSelectButton"
        Me.EscapeMenuCharacterSelectButton.Size = New System.Drawing.Size(87, 154)
        Me.EscapeMenuCharacterSelectButton.TabIndex = 11
        Me.EscapeMenuCharacterSelectButton.TabStop = False
        '
        'EscapeMenuOptionsButton
        '
        Me.EscapeMenuOptionsButton.BackColor = System.Drawing.Color.Transparent
        Me.EscapeMenuOptionsButton.BackgroundImage = CType(resources.GetObject("EscapeMenuOptionsButton.BackgroundImage"), System.Drawing.Image)
        Me.EscapeMenuOptionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EscapeMenuOptionsButton.Location = New System.Drawing.Point(7, 48)
        Me.EscapeMenuOptionsButton.Name = "EscapeMenuOptionsButton"
        Me.EscapeMenuOptionsButton.Size = New System.Drawing.Size(87, 154)
        Me.EscapeMenuOptionsButton.TabIndex = 10
        Me.EscapeMenuOptionsButton.TabStop = False
        '
        'EscapeMenuTitleLabel
        '
        Me.EscapeMenuTitleLabel.AutoSize = True
        Me.EscapeMenuTitleLabel.BackColor = System.Drawing.Color.Transparent
        Me.EscapeMenuTitleLabel.Font = New System.Drawing.Font("Source Sans Pro SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EscapeMenuTitleLabel.ForeColor = System.Drawing.Color.White
        Me.EscapeMenuTitleLabel.Location = New System.Drawing.Point(25, 8)
        Me.EscapeMenuTitleLabel.Name = "EscapeMenuTitleLabel"
        Me.EscapeMenuTitleLabel.Size = New System.Drawing.Size(47, 20)
        Me.EscapeMenuTitleLabel.TabIndex = 3
        Me.EscapeMenuTitleLabel.Text = "Menu"
        '
        'MainEquipmentItemPanel
        '
        Me.MainEquipmentItemPanel.BackColor = System.Drawing.Color.Transparent
        Me.MainEquipmentItemPanel.BackgroundImage = CType(resources.GetObject("MainEquipmentItemPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainEquipmentItemPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainEquipmentItemPanel.Controls.Add(Me.EquipmentIcon)
        Me.MainEquipmentItemPanel.Location = New System.Drawing.Point(814, 374)
        Me.MainEquipmentItemPanel.Name = "MainEquipmentItemPanel"
        Me.MainEquipmentItemPanel.Size = New System.Drawing.Size(34, 34)
        Me.MainEquipmentItemPanel.TabIndex = 31
        Me.MainEquipmentItemPanel.Visible = False
        '
        'EquipmentIcon
        '
        Me.EquipmentIcon.BackgroundImage = CType(resources.GetObject("EquipmentIcon.BackgroundImage"), System.Drawing.Image)
        Me.EquipmentIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EquipmentIcon.Location = New System.Drawing.Point(1, 1)
        Me.EquipmentIcon.Name = "EquipmentIcon"
        Me.EquipmentIcon.Size = New System.Drawing.Size(32, 32)
        Me.EquipmentIcon.TabIndex = 0
        Me.EquipmentIcon.TabStop = False
        '
        'MainCraftingWindowPanel
        '
        Me.MainCraftingWindowPanel.BackgroundImage = CType(resources.GetObject("MainCraftingWindowPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainCraftingWindowPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainCraftingWindowPanel.Controls.Add(Me.CraftButton)
        Me.MainCraftingWindowPanel.Controls.Add(Me.CraftingWindowProgressBar)
        Me.MainCraftingWindowPanel.Controls.Add(Me.ProductLabel)
        Me.MainCraftingWindowPanel.Controls.Add(Me.IngredientsTitle)
        Me.MainCraftingWindowPanel.Controls.Add(Me.RecipesTitle)
        Me.MainCraftingWindowPanel.Controls.Add(Me.IngredientsContainer)
        Me.MainCraftingWindowPanel.Controls.Add(Me.CraftingWindowCloseButton)
        Me.MainCraftingWindowPanel.Controls.Add(Me.CraftingWindowTitle)
        Me.MainCraftingWindowPanel.Location = New System.Drawing.Point(354, 619)
        Me.MainCraftingWindowPanel.Name = "MainCraftingWindowPanel"
        Me.MainCraftingWindowPanel.Size = New System.Drawing.Size(442, 469)
        Me.MainCraftingWindowPanel.TabIndex = 30
        Me.MainCraftingWindowPanel.Visible = False
        '
        'CraftButton
        '
        Me.CraftButton.BackColor = System.Drawing.Color.Transparent
        Me.CraftButton.BackgroundImage = CType(resources.GetObject("CraftButton.BackgroundImage"), System.Drawing.Image)
        Me.CraftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CraftButton.Location = New System.Drawing.Point(330, 394)
        Me.CraftButton.Name = "CraftButton"
        Me.CraftButton.Size = New System.Drawing.Size(96, 35)
        Me.CraftButton.TabIndex = 25
        Me.CraftButton.TabStop = False
        '
        'CraftingWindowProgressBar
        '
        Me.CraftingWindowProgressBar.BackColor = System.Drawing.Color.Transparent
        Me.CraftingWindowProgressBar.BackgroundImage = CType(resources.GetObject("CraftingWindowProgressBar.BackgroundImage"), System.Drawing.Image)
        Me.CraftingWindowProgressBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CraftingWindowProgressBar.Location = New System.Drawing.Point(194, 431)
        Me.CraftingWindowProgressBar.Name = "CraftingWindowProgressBar"
        Me.CraftingWindowProgressBar.Size = New System.Drawing.Size(247, 5)
        Me.CraftingWindowProgressBar.TabIndex = 24
        '
        'ProductLabel
        '
        Me.ProductLabel.AutoSize = True
        Me.ProductLabel.BackColor = System.Drawing.Color.Transparent
        Me.ProductLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductLabel.ForeColor = System.Drawing.Color.White
        Me.ProductLabel.Location = New System.Drawing.Point(216, 20)
        Me.ProductLabel.Name = "ProductLabel"
        Me.ProductLabel.Size = New System.Drawing.Size(54, 17)
        Me.ProductLabel.TabIndex = 23
        Me.ProductLabel.Text = "Product:"
        Me.ProductLabel.Visible = False
        '
        'IngredientsTitle
        '
        Me.IngredientsTitle.AutoSize = True
        Me.IngredientsTitle.BackColor = System.Drawing.Color.Transparent
        Me.IngredientsTitle.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IngredientsTitle.ForeColor = System.Drawing.Color.White
        Me.IngredientsTitle.Location = New System.Drawing.Point(216, 62)
        Me.IngredientsTitle.Name = "IngredientsTitle"
        Me.IngredientsTitle.Size = New System.Drawing.Size(71, 17)
        Me.IngredientsTitle.TabIndex = 22
        Me.IngredientsTitle.Text = "Ingredients:"
        Me.IngredientsTitle.Visible = False
        '
        'RecipesTitle
        '
        Me.RecipesTitle.AutoSize = True
        Me.RecipesTitle.BackColor = System.Drawing.Color.Transparent
        Me.RecipesTitle.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipesTitle.ForeColor = System.Drawing.Color.White
        Me.RecipesTitle.Location = New System.Drawing.Point(4, 4)
        Me.RecipesTitle.Name = "RecipesTitle"
        Me.RecipesTitle.Size = New System.Drawing.Size(51, 17)
        Me.RecipesTitle.TabIndex = 21
        Me.RecipesTitle.Text = "Recipes:"
        Me.RecipesTitle.Visible = False
        '
        'IngredientsContainer
        '
        Me.IngredientsContainer.BackColor = System.Drawing.Color.Transparent
        Me.IngredientsContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IngredientsContainer.Location = New System.Drawing.Point(210, 82)
        Me.IngredientsContainer.Name = "IngredientsContainer"
        Me.IngredientsContainer.Size = New System.Drawing.Size(215, 301)
        Me.IngredientsContainer.TabIndex = 20
        '
        'CraftingWindowCloseButton
        '
        Me.CraftingWindowCloseButton.BackColor = System.Drawing.Color.Transparent
        Me.CraftingWindowCloseButton.BackgroundImage = CType(resources.GetObject("CraftingWindowCloseButton.BackgroundImage"), System.Drawing.Image)
        Me.CraftingWindowCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CraftingWindowCloseButton.Location = New System.Drawing.Point(408, 0)
        Me.CraftingWindowCloseButton.Name = "CraftingWindowCloseButton"
        Me.CraftingWindowCloseButton.Size = New System.Drawing.Size(34, 32)
        Me.CraftingWindowCloseButton.TabIndex = 19
        Me.CraftingWindowCloseButton.TabStop = False
        '
        'CraftingWindowTitle
        '
        Me.CraftingWindowTitle.AutoSize = True
        Me.CraftingWindowTitle.BackColor = System.Drawing.Color.Transparent
        Me.CraftingWindowTitle.Font = New System.Drawing.Font("Source Sans Pro SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CraftingWindowTitle.ForeColor = System.Drawing.Color.White
        Me.CraftingWindowTitle.Location = New System.Drawing.Point(32, 6)
        Me.CraftingWindowTitle.Name = "CraftingWindowTitle"
        Me.CraftingWindowTitle.Size = New System.Drawing.Size(63, 20)
        Me.CraftingWindowTitle.TabIndex = 3
        Me.CraftingWindowTitle.Text = "Crafting"
        '
        'MainCraftingIngredientPanel
        '
        Me.MainCraftingIngredientPanel.BackColor = System.Drawing.Color.Transparent
        Me.MainCraftingIngredientPanel.BackgroundImage = CType(resources.GetObject("MainCraftingIngredientPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainCraftingIngredientPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainCraftingIngredientPanel.Controls.Add(Me.IngredientItemValue)
        Me.MainCraftingIngredientPanel.Controls.Add(Me.IngredientItemIcon)
        Me.MainCraftingIngredientPanel.Location = New System.Drawing.Point(813, 336)
        Me.MainCraftingIngredientPanel.Name = "MainCraftingIngredientPanel"
        Me.MainCraftingIngredientPanel.Size = New System.Drawing.Size(34, 35)
        Me.MainCraftingIngredientPanel.TabIndex = 29
        Me.MainCraftingIngredientPanel.Visible = False
        '
        'IngredientItemValue
        '
        Me.IngredientItemValue.AutoSize = True
        Me.IngredientItemValue.BackColor = System.Drawing.Color.Transparent
        Me.IngredientItemValue.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IngredientItemValue.ForeColor = System.Drawing.Color.White
        Me.IngredientItemValue.Location = New System.Drawing.Point(27, 24)
        Me.IngredientItemValue.Name = "IngredientItemValue"
        Me.IngredientItemValue.Size = New System.Drawing.Size(12, 14)
        Me.IngredientItemValue.TabIndex = 6
        Me.IngredientItemValue.Text = "0"
        '
        'IngredientItemIcon
        '
        Me.IngredientItemIcon.BackgroundImage = CType(resources.GetObject("IngredientItemIcon.BackgroundImage"), System.Drawing.Image)
        Me.IngredientItemIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IngredientItemIcon.Location = New System.Drawing.Point(1, 1)
        Me.IngredientItemIcon.Name = "IngredientItemIcon"
        Me.IngredientItemIcon.Size = New System.Drawing.Size(32, 32)
        Me.IngredientItemIcon.TabIndex = 0
        Me.IngredientItemIcon.TabStop = False
        '
        'MainCraftedItemPanel
        '
        Me.MainCraftedItemPanel.BackColor = System.Drawing.Color.Transparent
        Me.MainCraftedItemPanel.BackgroundImage = CType(resources.GetObject("MainCraftedItemPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainCraftedItemPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainCraftedItemPanel.Controls.Add(Me.CraftedItemQuantity)
        Me.MainCraftedItemPanel.Controls.Add(Me.CraftedItemIcon)
        Me.MainCraftedItemPanel.Location = New System.Drawing.Point(814, 297)
        Me.MainCraftedItemPanel.Name = "MainCraftedItemPanel"
        Me.MainCraftedItemPanel.Size = New System.Drawing.Size(34, 35)
        Me.MainCraftedItemPanel.TabIndex = 28
        Me.MainCraftedItemPanel.Visible = False
        '
        'CraftedItemQuantity
        '
        Me.CraftedItemQuantity.AutoSize = True
        Me.CraftedItemQuantity.BackColor = System.Drawing.Color.Transparent
        Me.CraftedItemQuantity.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CraftedItemQuantity.ForeColor = System.Drawing.Color.White
        Me.CraftedItemQuantity.Location = New System.Drawing.Point(27, 24)
        Me.CraftedItemQuantity.Name = "CraftedItemQuantity"
        Me.CraftedItemQuantity.Size = New System.Drawing.Size(12, 14)
        Me.CraftedItemQuantity.TabIndex = 6
        Me.CraftedItemQuantity.Text = "0"
        '
        'CraftedItemIcon
        '
        Me.CraftedItemIcon.BackgroundImage = CType(resources.GetObject("CraftedItemIcon.BackgroundImage"), System.Drawing.Image)
        Me.CraftedItemIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CraftedItemIcon.Location = New System.Drawing.Point(1, 1)
        Me.CraftedItemIcon.Name = "CraftedItemIcon"
        Me.CraftedItemIcon.Size = New System.Drawing.Size(32, 32)
        Me.CraftedItemIcon.TabIndex = 0
        Me.CraftedItemIcon.TabStop = False
        '
        'MainChatboxWindowPanel
        '
        Me.MainChatboxWindowPanel.BackgroundImage = CType(resources.GetObject("MainChatboxWindowPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainChatboxWindowPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainChatboxWindowPanel.Controls.Add(Me.ChatboxInputField)
        Me.MainChatboxWindowPanel.Controls.Add(Me.Chatbar)
        Me.MainChatboxWindowPanel.Controls.Add(Me.ChatboxTitle)
        Me.MainChatboxWindowPanel.Location = New System.Drawing.Point(1270, 0)
        Me.MainChatboxWindowPanel.Name = "MainChatboxWindowPanel"
        Me.MainChatboxWindowPanel.Size = New System.Drawing.Size(386, 162)
        Me.MainChatboxWindowPanel.TabIndex = 27
        Me.MainChatboxWindowPanel.Visible = False
        '
        'ChatboxInputField
        '
        Me.ChatboxInputField.BackgroundImage = CType(resources.GetObject("ChatboxInputField.BackgroundImage"), System.Drawing.Image)
        Me.ChatboxInputField.Location = New System.Drawing.Point(2, 141)
        Me.ChatboxInputField.Name = "ChatboxInputField"
        Me.ChatboxInputField.Size = New System.Drawing.Size(312, 16)
        Me.ChatboxInputField.TabIndex = 10
        Me.ChatboxInputField.TabStop = False
        '
        'Chatbar
        '
        Me.Chatbar.BackColor = System.Drawing.Color.Transparent
        Me.Chatbar.BackgroundImage = CType(resources.GetObject("Chatbar.BackgroundImage"), System.Drawing.Image)
        Me.Chatbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Chatbar.Location = New System.Drawing.Point(0, 136)
        Me.Chatbar.Name = "Chatbar"
        Me.Chatbar.Size = New System.Drawing.Size(386, 25)
        Me.Chatbar.TabIndex = 20
        '
        'ChatboxTitle
        '
        Me.ChatboxTitle.AutoSize = True
        Me.ChatboxTitle.BackColor = System.Drawing.Color.Transparent
        Me.ChatboxTitle.Font = New System.Drawing.Font("Source Sans Pro SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChatboxTitle.ForeColor = System.Drawing.Color.White
        Me.ChatboxTitle.Location = New System.Drawing.Point(32, 8)
        Me.ChatboxTitle.Name = "ChatboxTitle"
        Me.ChatboxTitle.Size = New System.Drawing.Size(41, 20)
        Me.ChatboxTitle.TabIndex = 3
        Me.ChatboxTitle.Text = "Chat"
        Me.ChatboxTitle.Visible = False
        '
        'MainCharacterWindowPanel
        '
        Me.MainCharacterWindowPanel.BackgroundImage = CType(resources.GetObject("MainCharacterWindowPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainCharacterWindowPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainCharacterWindowPanel.Controls.Add(Me.CharacterWindowInnerPanel)
        Me.MainCharacterWindowPanel.Controls.Add(Me.CharacterWindowCloseButton)
        Me.MainCharacterWindowPanel.Controls.Add(Me.CharacterWindowTitle)
        Me.MainCharacterWindowPanel.Location = New System.Drawing.Point(825, 476)
        Me.MainCharacterWindowPanel.Name = "MainCharacterWindowPanel"
        Me.MainCharacterWindowPanel.Size = New System.Drawing.Size(220, 340)
        Me.MainCharacterWindowPanel.TabIndex = 27
        Me.MainCharacterWindowPanel.Visible = False
        '
        'CharacterWindowInnerPanel
        '
        Me.CharacterWindowInnerPanel.BackColor = System.Drawing.Color.Transparent
        Me.CharacterWindowInnerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CharacterWindowInnerPanel.Controls.Add(Me.EquipmentItem4)
        Me.CharacterWindowInnerPanel.Controls.Add(Me.EquipmentItem3)
        Me.CharacterWindowInnerPanel.Controls.Add(Me.EquipmentItem2)
        Me.CharacterWindowInnerPanel.Controls.Add(Me.EquipmentItem1)
        Me.CharacterWindowInnerPanel.Controls.Add(Me.EquipmentItem0)
        Me.CharacterWindowInnerPanel.Controls.Add(Me.PointsLabel)
        Me.CharacterWindowInnerPanel.Controls.Add(Me.IncreaseMagicResistButton)
        Me.CharacterWindowInnerPanel.Controls.Add(Me.MagicResistLabel)
        Me.CharacterWindowInnerPanel.Controls.Add(Me.IncreaseAbilityPowerButton)
        Me.CharacterWindowInnerPanel.Controls.Add(Me.AbilityPowerLabel)
        Me.CharacterWindowInnerPanel.Controls.Add(Me.IncreaseSpeedButton)
        Me.CharacterWindowInnerPanel.Controls.Add(Me.SpeedLabel)
        Me.CharacterWindowInnerPanel.Controls.Add(Me.IncreaseDefenseButton)
        Me.CharacterWindowInnerPanel.Controls.Add(Me.IncreaseAttackButton)
        Me.CharacterWindowInnerPanel.Controls.Add(Me.CharacterWindowDefenseLabel)
        Me.CharacterWindowInnerPanel.Controls.Add(Me.CharacterWindowAttackLabel)
        Me.CharacterWindowInnerPanel.Controls.Add(Me.CharacterWindowStatsLabel)
        Me.CharacterWindowInnerPanel.Controls.Add(Me.CharacterWindowEquipmentLabel)
        Me.CharacterWindowInnerPanel.Controls.Add(Me.CharacterWindowCharacterContainer)
        Me.CharacterWindowInnerPanel.Controls.Add(Me.ChatacterInfoLabel)
        Me.CharacterWindowInnerPanel.Controls.Add(Me.CharacterWindowCharacterNameLabel)
        Me.CharacterWindowInnerPanel.Location = New System.Drawing.Point(0, 30)
        Me.CharacterWindowInnerPanel.Name = "CharacterWindowInnerPanel"
        Me.CharacterWindowInnerPanel.Size = New System.Drawing.Size(220, 307)
        Me.CharacterWindowInnerPanel.TabIndex = 21
        '
        'EquipmentItem4
        '
        Me.EquipmentItem4.BackgroundImage = CType(resources.GetObject("EquipmentItem4.BackgroundImage"), System.Drawing.Image)
        Me.EquipmentItem4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EquipmentItem4.Controls.Add(Me.Equipment4Icon)
        Me.EquipmentItem4.Location = New System.Drawing.Point(176, 144)
        Me.EquipmentItem4.Name = "EquipmentItem4"
        Me.EquipmentItem4.Size = New System.Drawing.Size(36, 36)
        Me.EquipmentItem4.TabIndex = 40
        '
        'Equipment4Icon
        '
        Me.Equipment4Icon.BackgroundImage = CType(resources.GetObject("Equipment4Icon.BackgroundImage"), System.Drawing.Image)
        Me.Equipment4Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Equipment4Icon.Location = New System.Drawing.Point(2, 2)
        Me.Equipment4Icon.Name = "Equipment4Icon"
        Me.Equipment4Icon.Size = New System.Drawing.Size(32, 32)
        Me.Equipment4Icon.TabIndex = 0
        Me.Equipment4Icon.TabStop = False
        '
        'EquipmentItem3
        '
        Me.EquipmentItem3.BackgroundImage = CType(resources.GetObject("EquipmentItem3.BackgroundImage"), System.Drawing.Image)
        Me.EquipmentItem3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EquipmentItem3.Controls.Add(Me.Equipment3Icon)
        Me.EquipmentItem3.Location = New System.Drawing.Point(134, 144)
        Me.EquipmentItem3.Name = "EquipmentItem3"
        Me.EquipmentItem3.Size = New System.Drawing.Size(36, 36)
        Me.EquipmentItem3.TabIndex = 39
        '
        'Equipment3Icon
        '
        Me.Equipment3Icon.BackgroundImage = CType(resources.GetObject("Equipment3Icon.BackgroundImage"), System.Drawing.Image)
        Me.Equipment3Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Equipment3Icon.Location = New System.Drawing.Point(2, 2)
        Me.Equipment3Icon.Name = "Equipment3Icon"
        Me.Equipment3Icon.Size = New System.Drawing.Size(32, 32)
        Me.Equipment3Icon.TabIndex = 0
        Me.Equipment3Icon.TabStop = False
        '
        'EquipmentItem2
        '
        Me.EquipmentItem2.BackgroundImage = CType(resources.GetObject("EquipmentItem2.BackgroundImage"), System.Drawing.Image)
        Me.EquipmentItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EquipmentItem2.Controls.Add(Me.Equipment2Icon)
        Me.EquipmentItem2.Location = New System.Drawing.Point(92, 144)
        Me.EquipmentItem2.Name = "EquipmentItem2"
        Me.EquipmentItem2.Size = New System.Drawing.Size(36, 36)
        Me.EquipmentItem2.TabIndex = 38
        '
        'Equipment2Icon
        '
        Me.Equipment2Icon.BackgroundImage = CType(resources.GetObject("Equipment2Icon.BackgroundImage"), System.Drawing.Image)
        Me.Equipment2Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Equipment2Icon.Location = New System.Drawing.Point(2, 2)
        Me.Equipment2Icon.Name = "Equipment2Icon"
        Me.Equipment2Icon.Size = New System.Drawing.Size(32, 32)
        Me.Equipment2Icon.TabIndex = 0
        Me.Equipment2Icon.TabStop = False
        '
        'EquipmentItem1
        '
        Me.EquipmentItem1.BackgroundImage = CType(resources.GetObject("EquipmentItem1.BackgroundImage"), System.Drawing.Image)
        Me.EquipmentItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EquipmentItem1.Controls.Add(Me.Equipment1Icon)
        Me.EquipmentItem1.Location = New System.Drawing.Point(50, 144)
        Me.EquipmentItem1.Name = "EquipmentItem1"
        Me.EquipmentItem1.Size = New System.Drawing.Size(36, 36)
        Me.EquipmentItem1.TabIndex = 37
        '
        'Equipment1Icon
        '
        Me.Equipment1Icon.BackgroundImage = CType(resources.GetObject("Equipment1Icon.BackgroundImage"), System.Drawing.Image)
        Me.Equipment1Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Equipment1Icon.Location = New System.Drawing.Point(2, 2)
        Me.Equipment1Icon.Name = "Equipment1Icon"
        Me.Equipment1Icon.Size = New System.Drawing.Size(32, 32)
        Me.Equipment1Icon.TabIndex = 0
        Me.Equipment1Icon.TabStop = False
        '
        'EquipmentItem0
        '
        Me.EquipmentItem0.BackgroundImage = CType(resources.GetObject("EquipmentItem0.BackgroundImage"), System.Drawing.Image)
        Me.EquipmentItem0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EquipmentItem0.Controls.Add(Me.Equipment0Icon)
        Me.EquipmentItem0.Location = New System.Drawing.Point(8, 144)
        Me.EquipmentItem0.Name = "EquipmentItem0"
        Me.EquipmentItem0.Size = New System.Drawing.Size(36, 36)
        Me.EquipmentItem0.TabIndex = 36
        '
        'Equipment0Icon
        '
        Me.Equipment0Icon.BackgroundImage = CType(resources.GetObject("Equipment0Icon.BackgroundImage"), System.Drawing.Image)
        Me.Equipment0Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Equipment0Icon.Location = New System.Drawing.Point(2, 2)
        Me.Equipment0Icon.Name = "Equipment0Icon"
        Me.Equipment0Icon.Size = New System.Drawing.Size(32, 32)
        Me.Equipment0Icon.TabIndex = 0
        Me.Equipment0Icon.TabStop = False
        '
        'PointsLabel
        '
        Me.PointsLabel.AutoSize = True
        Me.PointsLabel.BackColor = System.Drawing.Color.Transparent
        Me.PointsLabel.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PointsLabel.ForeColor = System.Drawing.Color.White
        Me.PointsLabel.Location = New System.Drawing.Point(4, 292)
        Me.PointsLabel.Name = "PointsLabel"
        Me.PointsLabel.Size = New System.Drawing.Size(62, 14)
        Me.PointsLabel.TabIndex = 35
        Me.PointsLabel.Text = "Points: 1000"
        '
        'IncreaseMagicResistButton
        '
        Me.IncreaseMagicResistButton.BackColor = System.Drawing.Color.Transparent
        Me.IncreaseMagicResistButton.BackgroundImage = CType(resources.GetObject("IncreaseMagicResistButton.BackgroundImage"), System.Drawing.Image)
        Me.IncreaseMagicResistButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IncreaseMagicResistButton.Location = New System.Drawing.Point(202, 278)
        Me.IncreaseMagicResistButton.Name = "IncreaseMagicResistButton"
        Me.IncreaseMagicResistButton.Size = New System.Drawing.Size(9, 9)
        Me.IncreaseMagicResistButton.TabIndex = 34
        Me.IncreaseMagicResistButton.TabStop = False
        '
        'MagicResistLabel
        '
        Me.MagicResistLabel.AutoSize = True
        Me.MagicResistLabel.BackColor = System.Drawing.Color.Transparent
        Me.MagicResistLabel.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MagicResistLabel.ForeColor = System.Drawing.Color.White
        Me.MagicResistLabel.Location = New System.Drawing.Point(4, 275)
        Me.MagicResistLabel.Name = "MagicResistLabel"
        Me.MagicResistLabel.Size = New System.Drawing.Size(90, 14)
        Me.MagicResistLabel.TabIndex = 33
        Me.MagicResistLabel.Text = "Magic Resist: 1000"
        '
        'IncreaseAbilityPowerButton
        '
        Me.IncreaseAbilityPowerButton.BackColor = System.Drawing.Color.Transparent
        Me.IncreaseAbilityPowerButton.BackgroundImage = CType(resources.GetObject("IncreaseAbilityPowerButton.BackgroundImage"), System.Drawing.Image)
        Me.IncreaseAbilityPowerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IncreaseAbilityPowerButton.Location = New System.Drawing.Point(202, 261)
        Me.IncreaseAbilityPowerButton.Name = "IncreaseAbilityPowerButton"
        Me.IncreaseAbilityPowerButton.Size = New System.Drawing.Size(9, 9)
        Me.IncreaseAbilityPowerButton.TabIndex = 32
        Me.IncreaseAbilityPowerButton.TabStop = False
        '
        'AbilityPowerLabel
        '
        Me.AbilityPowerLabel.AutoSize = True
        Me.AbilityPowerLabel.BackColor = System.Drawing.Color.Transparent
        Me.AbilityPowerLabel.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbilityPowerLabel.ForeColor = System.Drawing.Color.White
        Me.AbilityPowerLabel.Location = New System.Drawing.Point(4, 258)
        Me.AbilityPowerLabel.Name = "AbilityPowerLabel"
        Me.AbilityPowerLabel.Size = New System.Drawing.Size(93, 14)
        Me.AbilityPowerLabel.TabIndex = 31
        Me.AbilityPowerLabel.Text = "Ability Power: 1000"
        '
        'IncreaseSpeedButton
        '
        Me.IncreaseSpeedButton.BackColor = System.Drawing.Color.Transparent
        Me.IncreaseSpeedButton.BackgroundImage = CType(resources.GetObject("IncreaseSpeedButton.BackgroundImage"), System.Drawing.Image)
        Me.IncreaseSpeedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IncreaseSpeedButton.Location = New System.Drawing.Point(202, 243)
        Me.IncreaseSpeedButton.Name = "IncreaseSpeedButton"
        Me.IncreaseSpeedButton.Size = New System.Drawing.Size(9, 9)
        Me.IncreaseSpeedButton.TabIndex = 30
        Me.IncreaseSpeedButton.TabStop = False
        '
        'SpeedLabel
        '
        Me.SpeedLabel.AutoSize = True
        Me.SpeedLabel.BackColor = System.Drawing.Color.Transparent
        Me.SpeedLabel.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpeedLabel.ForeColor = System.Drawing.Color.White
        Me.SpeedLabel.Location = New System.Drawing.Point(4, 240)
        Me.SpeedLabel.Name = "SpeedLabel"
        Me.SpeedLabel.Size = New System.Drawing.Size(60, 14)
        Me.SpeedLabel.TabIndex = 29
        Me.SpeedLabel.Text = "Speed: 1000"
        '
        'IncreaseDefenseButton
        '
        Me.IncreaseDefenseButton.BackColor = System.Drawing.Color.Transparent
        Me.IncreaseDefenseButton.BackgroundImage = CType(resources.GetObject("IncreaseDefenseButton.BackgroundImage"), System.Drawing.Image)
        Me.IncreaseDefenseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IncreaseDefenseButton.Location = New System.Drawing.Point(202, 227)
        Me.IncreaseDefenseButton.Name = "IncreaseDefenseButton"
        Me.IncreaseDefenseButton.Size = New System.Drawing.Size(9, 9)
        Me.IncreaseDefenseButton.TabIndex = 28
        Me.IncreaseDefenseButton.TabStop = False
        '
        'IncreaseAttackButton
        '
        Me.IncreaseAttackButton.BackColor = System.Drawing.Color.Transparent
        Me.IncreaseAttackButton.BackgroundImage = CType(resources.GetObject("IncreaseAttackButton.BackgroundImage"), System.Drawing.Image)
        Me.IncreaseAttackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IncreaseAttackButton.Location = New System.Drawing.Point(202, 211)
        Me.IncreaseAttackButton.Name = "IncreaseAttackButton"
        Me.IncreaseAttackButton.Size = New System.Drawing.Size(9, 9)
        Me.IncreaseAttackButton.TabIndex = 27
        Me.IncreaseAttackButton.TabStop = False
        '
        'CharacterWindowDefenseLabel
        '
        Me.CharacterWindowDefenseLabel.AutoSize = True
        Me.CharacterWindowDefenseLabel.BackColor = System.Drawing.Color.Transparent
        Me.CharacterWindowDefenseLabel.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CharacterWindowDefenseLabel.ForeColor = System.Drawing.Color.White
        Me.CharacterWindowDefenseLabel.Location = New System.Drawing.Point(4, 224)
        Me.CharacterWindowDefenseLabel.Name = "CharacterWindowDefenseLabel"
        Me.CharacterWindowDefenseLabel.Size = New System.Drawing.Size(68, 14)
        Me.CharacterWindowDefenseLabel.TabIndex = 26
        Me.CharacterWindowDefenseLabel.Text = "Defense: 1000"
        '
        'CharacterWindowAttackLabel
        '
        Me.CharacterWindowAttackLabel.AutoSize = True
        Me.CharacterWindowAttackLabel.BackColor = System.Drawing.Color.Transparent
        Me.CharacterWindowAttackLabel.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CharacterWindowAttackLabel.ForeColor = System.Drawing.Color.White
        Me.CharacterWindowAttackLabel.Location = New System.Drawing.Point(4, 208)
        Me.CharacterWindowAttackLabel.Name = "CharacterWindowAttackLabel"
        Me.CharacterWindowAttackLabel.Size = New System.Drawing.Size(62, 14)
        Me.CharacterWindowAttackLabel.TabIndex = 25
        Me.CharacterWindowAttackLabel.Text = "Attack: 1000"
        '
        'CharacterWindowStatsLabel
        '
        Me.CharacterWindowStatsLabel.AutoSize = True
        Me.CharacterWindowStatsLabel.BackColor = System.Drawing.Color.Transparent
        Me.CharacterWindowStatsLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CharacterWindowStatsLabel.ForeColor = System.Drawing.Color.White
        Me.CharacterWindowStatsLabel.Location = New System.Drawing.Point(4, 188)
        Me.CharacterWindowStatsLabel.Name = "CharacterWindowStatsLabel"
        Me.CharacterWindowStatsLabel.Size = New System.Drawing.Size(38, 17)
        Me.CharacterWindowStatsLabel.TabIndex = 24
        Me.CharacterWindowStatsLabel.Text = "Stats:"
        Me.CharacterWindowStatsLabel.Visible = False
        '
        'CharacterWindowEquipmentLabel
        '
        Me.CharacterWindowEquipmentLabel.AutoSize = True
        Me.CharacterWindowEquipmentLabel.BackColor = System.Drawing.Color.Transparent
        Me.CharacterWindowEquipmentLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CharacterWindowEquipmentLabel.ForeColor = System.Drawing.Color.White
        Me.CharacterWindowEquipmentLabel.Location = New System.Drawing.Point(4, 126)
        Me.CharacterWindowEquipmentLabel.Name = "CharacterWindowEquipmentLabel"
        Me.CharacterWindowEquipmentLabel.Size = New System.Drawing.Size(70, 17)
        Me.CharacterWindowEquipmentLabel.TabIndex = 23
        Me.CharacterWindowEquipmentLabel.Text = "Equipment:"
        Me.CharacterWindowEquipmentLabel.Visible = False
        '
        'CharacterWindowCharacterContainer
        '
        Me.CharacterWindowCharacterContainer.BackgroundImage = CType(resources.GetObject("CharacterWindowCharacterContainer.BackgroundImage"), System.Drawing.Image)
        Me.CharacterWindowCharacterContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CharacterWindowCharacterContainer.Location = New System.Drawing.Point(60, 18)
        Me.CharacterWindowCharacterContainer.Name = "CharacterWindowCharacterContainer"
        Me.CharacterWindowCharacterContainer.Size = New System.Drawing.Size(100, 100)
        Me.CharacterWindowCharacterContainer.TabIndex = 22
        Me.CharacterWindowCharacterContainer.TabStop = False
        '
        'ChatacterInfoLabel
        '
        Me.ChatacterInfoLabel.AutoSize = True
        Me.ChatacterInfoLabel.BackColor = System.Drawing.Color.Transparent
        Me.ChatacterInfoLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChatacterInfoLabel.ForeColor = System.Drawing.Color.White
        Me.ChatacterInfoLabel.Location = New System.Drawing.Point(4, 116)
        Me.ChatacterInfoLabel.Name = "ChatacterInfoLabel"
        Me.ChatacterInfoLabel.Size = New System.Drawing.Size(111, 17)
        Me.ChatacterInfoLabel.TabIndex = 21
        Me.ChatacterInfoLabel.Text = "Level: 99 GUI Editor"
        '
        'CharacterWindowCharacterNameLabel
        '
        Me.CharacterWindowCharacterNameLabel.AutoSize = True
        Me.CharacterWindowCharacterNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.CharacterWindowCharacterNameLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CharacterWindowCharacterNameLabel.ForeColor = System.Drawing.Color.White
        Me.CharacterWindowCharacterNameLabel.Location = New System.Drawing.Point(4, 4)
        Me.CharacterWindowCharacterNameLabel.Name = "CharacterWindowCharacterNameLabel"
        Me.CharacterWindowCharacterNameLabel.Size = New System.Drawing.Size(94, 17)
        Me.CharacterWindowCharacterNameLabel.TabIndex = 20
        Me.CharacterWindowCharacterNameLabel.Text = "CharacterName"
        '
        'CharacterWindowCloseButton
        '
        Me.CharacterWindowCloseButton.BackColor = System.Drawing.Color.Transparent
        Me.CharacterWindowCloseButton.BackgroundImage = CType(resources.GetObject("CharacterWindowCloseButton.BackgroundImage"), System.Drawing.Image)
        Me.CharacterWindowCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CharacterWindowCloseButton.Location = New System.Drawing.Point(194, 6)
        Me.CharacterWindowCloseButton.Name = "CharacterWindowCloseButton"
        Me.CharacterWindowCloseButton.Size = New System.Drawing.Size(26, 25)
        Me.CharacterWindowCloseButton.TabIndex = 19
        Me.CharacterWindowCloseButton.TabStop = False
        '
        'CharacterWindowTitle
        '
        Me.CharacterWindowTitle.AutoSize = True
        Me.CharacterWindowTitle.BackColor = System.Drawing.Color.Transparent
        Me.CharacterWindowTitle.Font = New System.Drawing.Font("Source Sans Pro SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CharacterWindowTitle.ForeColor = System.Drawing.Color.White
        Me.CharacterWindowTitle.Location = New System.Drawing.Point(40, 7)
        Me.CharacterWindowTitle.Name = "CharacterWindowTitle"
        Me.CharacterWindowTitle.Size = New System.Drawing.Size(76, 20)
        Me.CharacterWindowTitle.TabIndex = 3
        Me.CharacterWindowTitle.Text = "Character"
        '
        'MainBankWindowPanel
        '
        Me.MainBankWindowPanel.BackgroundImage = CType(resources.GetObject("MainBankWindowPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainBankWindowPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainBankWindowPanel.Controls.Add(Me.BankWindowCloseButton)
        Me.MainBankWindowPanel.Controls.Add(Me.BankWindowTitle)
        Me.MainBankWindowPanel.Location = New System.Drawing.Point(1051, 219)
        Me.MainBankWindowPanel.Name = "MainBankWindowPanel"
        Me.MainBankWindowPanel.Size = New System.Drawing.Size(442, 469)
        Me.MainBankWindowPanel.TabIndex = 26
        Me.MainBankWindowPanel.Visible = False
        '
        'BankWindowCloseButton
        '
        Me.BankWindowCloseButton.BackColor = System.Drawing.Color.Transparent
        Me.BankWindowCloseButton.BackgroundImage = CType(resources.GetObject("BankWindowCloseButton.BackgroundImage"), System.Drawing.Image)
        Me.BankWindowCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BankWindowCloseButton.Location = New System.Drawing.Point(408, 0)
        Me.BankWindowCloseButton.Name = "BankWindowCloseButton"
        Me.BankWindowCloseButton.Size = New System.Drawing.Size(34, 32)
        Me.BankWindowCloseButton.TabIndex = 19
        Me.BankWindowCloseButton.TabStop = False
        '
        'BankWindowTitle
        '
        Me.BankWindowTitle.AutoSize = True
        Me.BankWindowTitle.BackColor = System.Drawing.Color.Transparent
        Me.BankWindowTitle.Font = New System.Drawing.Font("Source Sans Pro SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BankWindowTitle.ForeColor = System.Drawing.Color.White
        Me.BankWindowTitle.Location = New System.Drawing.Point(32, 6)
        Me.BankWindowTitle.Name = "BankWindowTitle"
        Me.BankWindowTitle.Size = New System.Drawing.Size(44, 20)
        Me.BankWindowTitle.TabIndex = 3
        Me.BankWindowTitle.Text = "Bank"
        '
        'MainBankItemPanel
        '
        Me.MainBankItemPanel.BackColor = System.Drawing.Color.Transparent
        Me.MainBankItemPanel.BackgroundImage = CType(resources.GetObject("MainBankItemPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainBankItemPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainBankItemPanel.Controls.Add(Me.BankItemValue)
        Me.MainBankItemPanel.Controls.Add(Me.BankItemIcon)
        Me.MainBankItemPanel.Location = New System.Drawing.Point(814, 258)
        Me.MainBankItemPanel.Name = "MainBankItemPanel"
        Me.MainBankItemPanel.Size = New System.Drawing.Size(34, 35)
        Me.MainBankItemPanel.TabIndex = 26
        Me.MainBankItemPanel.Visible = False
        '
        'BankItemValue
        '
        Me.BankItemValue.AutoSize = True
        Me.BankItemValue.BackColor = System.Drawing.Color.Transparent
        Me.BankItemValue.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BankItemValue.ForeColor = System.Drawing.Color.White
        Me.BankItemValue.Location = New System.Drawing.Point(27, 24)
        Me.BankItemValue.Name = "BankItemValue"
        Me.BankItemValue.Size = New System.Drawing.Size(12, 14)
        Me.BankItemValue.TabIndex = 6
        Me.BankItemValue.Text = "0"
        '
        'BankItemIcon
        '
        Me.BankItemIcon.BackgroundImage = CType(resources.GetObject("BankItemIcon.BackgroundImage"), System.Drawing.Image)
        Me.BankItemIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BankItemIcon.Location = New System.Drawing.Point(1, 1)
        Me.BankItemIcon.Name = "BankItemIcon"
        Me.BankItemIcon.Size = New System.Drawing.Size(32, 32)
        Me.BankItemIcon.TabIndex = 0
        Me.BankItemIcon.TabStop = False
        '
        'MainBagWindowPanel
        '
        Me.MainBagWindowPanel.BackgroundImage = CType(resources.GetObject("MainBagWindowPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainBagWindowPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainBagWindowPanel.Controls.Add(Me.BagWindowCloseButton)
        Me.MainBagWindowPanel.Controls.Add(Me.BagWindowTitle)
        Me.MainBagWindowPanel.Location = New System.Drawing.Point(853, 219)
        Me.MainBagWindowPanel.Name = "MainBagWindowPanel"
        Me.MainBagWindowPanel.Size = New System.Drawing.Size(192, 254)
        Me.MainBagWindowPanel.TabIndex = 25
        Me.MainBagWindowPanel.Visible = False
        '
        'BagWindowCloseButton
        '
        Me.BagWindowCloseButton.BackColor = System.Drawing.Color.Transparent
        Me.BagWindowCloseButton.BackgroundImage = CType(resources.GetObject("BagWindowCloseButton.BackgroundImage"), System.Drawing.Image)
        Me.BagWindowCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BagWindowCloseButton.Location = New System.Drawing.Point(166, 4)
        Me.BagWindowCloseButton.Name = "BagWindowCloseButton"
        Me.BagWindowCloseButton.Size = New System.Drawing.Size(26, 24)
        Me.BagWindowCloseButton.TabIndex = 19
        Me.BagWindowCloseButton.TabStop = False
        '
        'BagWindowTitle
        '
        Me.BagWindowTitle.AutoSize = True
        Me.BagWindowTitle.BackColor = System.Drawing.Color.Transparent
        Me.BagWindowTitle.Font = New System.Drawing.Font("Source Sans Pro SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BagWindowTitle.ForeColor = System.Drawing.Color.White
        Me.BagWindowTitle.Location = New System.Drawing.Point(40, 5)
        Me.BagWindowTitle.Name = "BagWindowTitle"
        Me.BagWindowTitle.Size = New System.Drawing.Size(35, 20)
        Me.BagWindowTitle.TabIndex = 3
        Me.BagWindowTitle.Text = "Bag"
        '
        'MainBagItemPanel
        '
        Me.MainBagItemPanel.BackColor = System.Drawing.Color.Transparent
        Me.MainBagItemPanel.BackgroundImage = CType(resources.GetObject("MainBagItemPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainBagItemPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainBagItemPanel.Controls.Add(Me.BagItemValue)
        Me.MainBagItemPanel.Controls.Add(Me.BagItemIcon)
        Me.MainBagItemPanel.Location = New System.Drawing.Point(813, 219)
        Me.MainBagItemPanel.Name = "MainBagItemPanel"
        Me.MainBagItemPanel.Size = New System.Drawing.Size(34, 35)
        Me.MainBagItemPanel.TabIndex = 24
        Me.MainBagItemPanel.Visible = False
        '
        'BagItemValue
        '
        Me.BagItemValue.AutoSize = True
        Me.BagItemValue.BackColor = System.Drawing.Color.Transparent
        Me.BagItemValue.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BagItemValue.ForeColor = System.Drawing.Color.White
        Me.BagItemValue.Location = New System.Drawing.Point(27, 24)
        Me.BagItemValue.Name = "BagItemValue"
        Me.BagItemValue.Size = New System.Drawing.Size(12, 14)
        Me.BagItemValue.TabIndex = 6
        Me.BagItemValue.Text = "0"
        '
        'BagItemIcon
        '
        Me.BagItemIcon.BackgroundImage = CType(resources.GetObject("BagItemIcon.BackgroundImage"), System.Drawing.Image)
        Me.BagItemIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BagItemIcon.Location = New System.Drawing.Point(1, 1)
        Me.BagItemIcon.Name = "BagItemIcon"
        Me.BagItemIcon.Size = New System.Drawing.Size(32, 32)
        Me.BagItemIcon.TabIndex = 0
        Me.BagItemIcon.TabStop = False
        '
        'MainControlPanelsWindow
        '
        Me.MainControlPanelsWindow.BackgroundImage = CType(resources.GetObject("MainControlPanelsWindow.BackgroundImage"), System.Drawing.Image)
        Me.MainControlPanelsWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainControlPanelsWindow.Controls.Add(Me.RestoreControlsButton)
        Me.MainControlPanelsWindow.Controls.Add(Me.ExitControlsButton)
        Me.MainControlPanelsWindow.Controls.Add(Me.CancelControlsButton)
        Me.MainControlPanelsWindow.Controls.Add(Me.ControlsPanelInnerPanel)
        Me.MainControlPanelsWindow.Controls.Add(Me.ControlsHeader)
        Me.MainControlPanelsWindow.Location = New System.Drawing.Point(812, 0)
        Me.MainControlPanelsWindow.Name = "MainControlPanelsWindow"
        Me.MainControlPanelsWindow.Size = New System.Drawing.Size(452, 213)
        Me.MainControlPanelsWindow.TabIndex = 21
        Me.MainControlPanelsWindow.Visible = False
        '
        'RestoreControlsButton
        '
        Me.RestoreControlsButton.BackColor = System.Drawing.Color.Transparent
        Me.RestoreControlsButton.BackgroundImage = CType(resources.GetObject("RestoreControlsButton.BackgroundImage"), System.Drawing.Image)
        Me.RestoreControlsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RestoreControlsButton.Location = New System.Drawing.Point(8, 178)
        Me.RestoreControlsButton.Name = "RestoreControlsButton"
        Me.RestoreControlsButton.Size = New System.Drawing.Size(120, 28)
        Me.RestoreControlsButton.TabIndex = 19
        Me.RestoreControlsButton.TabStop = False
        '
        'ExitControlsButton
        '
        Me.ExitControlsButton.BackColor = System.Drawing.Color.Transparent
        Me.ExitControlsButton.BackgroundImage = CType(resources.GetObject("ExitControlsButton.BackgroundImage"), System.Drawing.Image)
        Me.ExitControlsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExitControlsButton.Location = New System.Drawing.Point(238, 174)
        Me.ExitControlsButton.Name = "ExitControlsButton"
        Me.ExitControlsButton.Size = New System.Drawing.Size(96, 35)
        Me.ExitControlsButton.TabIndex = 17
        Me.ExitControlsButton.TabStop = False
        '
        'CancelControlsButton
        '
        Me.CancelControlsButton.BackColor = System.Drawing.Color.Transparent
        Me.CancelControlsButton.BackgroundImage = CType(resources.GetObject("CancelControlsButton.BackgroundImage"), System.Drawing.Image)
        Me.CancelControlsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelControlsButton.Location = New System.Drawing.Point(342, 174)
        Me.CancelControlsButton.Name = "CancelControlsButton"
        Me.CancelControlsButton.Size = New System.Drawing.Size(96, 35)
        Me.CancelControlsButton.TabIndex = 18
        Me.CancelControlsButton.TabStop = False
        '
        'ControlsPanelInnerPanel
        '
        Me.ControlsPanelInnerPanel.BackColor = System.Drawing.Color.Transparent
        Me.ControlsPanelInnerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ControlsPanelInnerPanel.Location = New System.Drawing.Point(0, 40)
        Me.ControlsPanelInnerPanel.Name = "ControlsPanelInnerPanel"
        Me.ControlsPanelInnerPanel.Size = New System.Drawing.Size(451, 132)
        Me.ControlsPanelInnerPanel.TabIndex = 7
        '
        'ControlsHeader
        '
        Me.ControlsHeader.AutoSize = True
        Me.ControlsHeader.BackColor = System.Drawing.Color.Transparent
        Me.ControlsHeader.Font = New System.Drawing.Font("Source Sans Pro SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControlsHeader.ForeColor = System.Drawing.Color.White
        Me.ControlsHeader.Location = New System.Drawing.Point(25, 9)
        Me.ControlsHeader.Name = "ControlsHeader"
        Me.ControlsHeader.Size = New System.Drawing.Size(68, 20)
        Me.ControlsHeader.TabIndex = 3
        Me.ControlsHeader.Text = "Controls"
        '
        'MainServerStatusAreaPanel
        '
        Me.MainServerStatusAreaPanel.BackColor = System.Drawing.Color.Transparent
        Me.MainServerStatusAreaPanel.BackgroundImage = CType(resources.GetObject("MainServerStatusAreaPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainServerStatusAreaPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainServerStatusAreaPanel.Controls.Add(Me.ServerStatusAreaServerStatusLabel)
        Me.MainServerStatusAreaPanel.Location = New System.Drawing.Point(355, 589)
        Me.MainServerStatusAreaPanel.Name = "MainServerStatusAreaPanel"
        Me.MainServerStatusAreaPanel.Size = New System.Drawing.Size(200, 24)
        Me.MainServerStatusAreaPanel.TabIndex = 23
        Me.MainServerStatusAreaPanel.Visible = False
        '
        'ServerStatusAreaServerStatusLabel
        '
        Me.ServerStatusAreaServerStatusLabel.AutoSize = True
        Me.ServerStatusAreaServerStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.ServerStatusAreaServerStatusLabel.Font = New System.Drawing.Font("Source Sans Pro SemiBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServerStatusAreaServerStatusLabel.ForeColor = System.Drawing.Color.White
        Me.ServerStatusAreaServerStatusLabel.Location = New System.Drawing.Point(0, 4)
        Me.ServerStatusAreaServerStatusLabel.Name = "ServerStatusAreaServerStatusLabel"
        Me.ServerStatusAreaServerStatusLabel.Size = New System.Drawing.Size(89, 17)
        Me.ServerStatusAreaServerStatusLabel.TabIndex = 5
        Me.ServerStatusAreaServerStatusLabel.Text = "Server Status:"
        '
        'MainResetPasswordWindowPanel
        '
        Me.MainResetPasswordWindowPanel.BackgroundImage = CType(resources.GetObject("MainResetPasswordWindowPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainResetPasswordWindowPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainResetPasswordWindowPanel.Controls.Add(Me.ResetPassword2Panel)
        Me.MainResetPasswordWindowPanel.Controls.Add(Me.ResetPassword1Panel)
        Me.MainResetPasswordWindowPanel.Controls.Add(Me.ResetBackButton)
        Me.MainResetPasswordWindowPanel.Controls.Add(Me.ResetSubmitButton)
        Me.MainResetPasswordWindowPanel.Controls.Add(Me.CodePanel)
        Me.MainResetPasswordWindowPanel.Controls.Add(Me.ResetPassHeader)
        Me.MainResetPasswordWindowPanel.Location = New System.Drawing.Point(355, 425)
        Me.MainResetPasswordWindowPanel.Name = "MainResetPasswordWindowPanel"
        Me.MainResetPasswordWindowPanel.Size = New System.Drawing.Size(452, 158)
        Me.MainResetPasswordWindowPanel.TabIndex = 22
        Me.MainResetPasswordWindowPanel.Visible = False
        '
        'ResetPassword2Panel
        '
        Me.ResetPassword2Panel.BackColor = System.Drawing.Color.Transparent
        Me.ResetPassword2Panel.BackgroundImage = CType(resources.GetObject("ResetPassword2Panel.BackgroundImage"), System.Drawing.Image)
        Me.ResetPassword2Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ResetPassword2Panel.Controls.Add(Me.ResetPassword2Field)
        Me.ResetPassword2Panel.Controls.Add(Me.ResetPassword2Label)
        Me.ResetPassword2Panel.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.ResetPassword2Panel.Location = New System.Drawing.Point(14, 126)
        Me.ResetPassword2Panel.Name = "ResetPassword2Panel"
        Me.ResetPassword2Panel.Size = New System.Drawing.Size(308, 28)
        Me.ResetPassword2Panel.TabIndex = 12
        '
        'ResetPassword2Field
        '
        Me.ResetPassword2Field.BackgroundImage = CType(resources.GetObject("ResetPassword2Field.BackgroundImage"), System.Drawing.Image)
        Me.ResetPassword2Field.Location = New System.Drawing.Point(4, 10)
        Me.ResetPassword2Field.Name = "ResetPassword2Field"
        Me.ResetPassword2Field.Size = New System.Drawing.Size(302, 16)
        Me.ResetPassword2Field.TabIndex = 0
        Me.ResetPassword2Field.TabStop = False
        '
        'ResetPassword2Label
        '
        Me.ResetPassword2Label.AutoSize = True
        Me.ResetPassword2Label.BackColor = System.Drawing.Color.Transparent
        Me.ResetPassword2Label.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetPassword2Label.ForeColor = System.Drawing.Color.White
        Me.ResetPassword2Label.Location = New System.Drawing.Point(0, -4)
        Me.ResetPassword2Label.Name = "ResetPassword2Label"
        Me.ResetPassword2Label.Size = New System.Drawing.Size(109, 17)
        Me.ResetPassword2Label.TabIndex = 4
        Me.ResetPassword2Label.Text = "Confirm Password:"
        '
        'ResetPassword1Panel
        '
        Me.ResetPassword1Panel.BackColor = System.Drawing.Color.Transparent
        Me.ResetPassword1Panel.BackgroundImage = CType(resources.GetObject("ResetPassword1Panel.BackgroundImage"), System.Drawing.Image)
        Me.ResetPassword1Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ResetPassword1Panel.Controls.Add(Me.ResetPassword1Field)
        Me.ResetPassword1Panel.Controls.Add(Me.ResetPassword1Label)
        Me.ResetPassword1Panel.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.ResetPassword1Panel.Location = New System.Drawing.Point(14, 90)
        Me.ResetPassword1Panel.Name = "ResetPassword1Panel"
        Me.ResetPassword1Panel.Size = New System.Drawing.Size(308, 28)
        Me.ResetPassword1Panel.TabIndex = 11
        '
        'ResetPassword1Field
        '
        Me.ResetPassword1Field.BackgroundImage = CType(resources.GetObject("ResetPassword1Field.BackgroundImage"), System.Drawing.Image)
        Me.ResetPassword1Field.Location = New System.Drawing.Point(4, 10)
        Me.ResetPassword1Field.Name = "ResetPassword1Field"
        Me.ResetPassword1Field.Size = New System.Drawing.Size(302, 16)
        Me.ResetPassword1Field.TabIndex = 0
        Me.ResetPassword1Field.TabStop = False
        '
        'ResetPassword1Label
        '
        Me.ResetPassword1Label.AutoSize = True
        Me.ResetPassword1Label.BackColor = System.Drawing.Color.Transparent
        Me.ResetPassword1Label.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetPassword1Label.ForeColor = System.Drawing.Color.White
        Me.ResetPassword1Label.Location = New System.Drawing.Point(0, -4)
        Me.ResetPassword1Label.Name = "ResetPassword1Label"
        Me.ResetPassword1Label.Size = New System.Drawing.Size(62, 17)
        Me.ResetPassword1Label.TabIndex = 4
        Me.ResetPassword1Label.Text = "Password:"
        '
        'ResetBackButton
        '
        Me.ResetBackButton.BackColor = System.Drawing.Color.Transparent
        Me.ResetBackButton.BackgroundImage = CType(resources.GetObject("ResetBackButton.BackgroundImage"), System.Drawing.Image)
        Me.ResetBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ResetBackButton.Location = New System.Drawing.Point(338, 89)
        Me.ResetBackButton.Name = "ResetBackButton"
        Me.ResetBackButton.Size = New System.Drawing.Size(96, 35)
        Me.ResetBackButton.TabIndex = 10
        Me.ResetBackButton.TabStop = False
        '
        'ResetSubmitButton
        '
        Me.ResetSubmitButton.BackColor = System.Drawing.Color.Transparent
        Me.ResetSubmitButton.BackgroundImage = CType(resources.GetObject("ResetSubmitButton.BackgroundImage"), System.Drawing.Image)
        Me.ResetSubmitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ResetSubmitButton.Location = New System.Drawing.Point(338, 54)
        Me.ResetSubmitButton.Name = "ResetSubmitButton"
        Me.ResetSubmitButton.Size = New System.Drawing.Size(96, 35)
        Me.ResetSubmitButton.TabIndex = 9
        Me.ResetSubmitButton.TabStop = False
        '
        'CodePanel
        '
        Me.CodePanel.BackColor = System.Drawing.Color.Transparent
        Me.CodePanel.BackgroundImage = CType(resources.GetObject("CodePanel.BackgroundImage"), System.Drawing.Image)
        Me.CodePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CodePanel.Controls.Add(Me.CodeField)
        Me.CodePanel.Controls.Add(Me.CodeLabel)
        Me.CodePanel.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.CodePanel.Location = New System.Drawing.Point(14, 54)
        Me.CodePanel.Name = "CodePanel"
        Me.CodePanel.Size = New System.Drawing.Size(308, 28)
        Me.CodePanel.TabIndex = 5
        '
        'CodeField
        '
        Me.CodeField.BackgroundImage = CType(resources.GetObject("CodeField.BackgroundImage"), System.Drawing.Image)
        Me.CodeField.Location = New System.Drawing.Point(4, 10)
        Me.CodeField.Name = "CodeField"
        Me.CodeField.Size = New System.Drawing.Size(302, 16)
        Me.CodeField.TabIndex = 0
        Me.CodeField.TabStop = False
        '
        'CodeLabel
        '
        Me.CodeLabel.AutoSize = True
        Me.CodeLabel.BackColor = System.Drawing.Color.Transparent
        Me.CodeLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodeLabel.ForeColor = System.Drawing.Color.White
        Me.CodeLabel.Location = New System.Drawing.Point(0, -4)
        Me.CodeLabel.Name = "CodeLabel"
        Me.CodeLabel.Size = New System.Drawing.Size(69, 17)
        Me.CodeLabel.TabIndex = 4
        Me.CodeLabel.Text = "Reset Code:"
        '
        'ResetPassHeader
        '
        Me.ResetPassHeader.AutoSize = True
        Me.ResetPassHeader.BackColor = System.Drawing.Color.Transparent
        Me.ResetPassHeader.Font = New System.Drawing.Font("Source Sans Pro SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetPassHeader.ForeColor = System.Drawing.Color.White
        Me.ResetPassHeader.Location = New System.Drawing.Point(25, 9)
        Me.ResetPassHeader.Name = "ResetPassHeader"
        Me.ResetPassHeader.Size = New System.Drawing.Size(116, 20)
        Me.ResetPassHeader.TabIndex = 3
        Me.ResetPassHeader.Text = "Reset Password"
        '
        'MainRegistrationWindowPanel
        '
        Me.MainRegistrationWindowPanel.BackgroundImage = CType(resources.GetObject("MainRegistrationWindowPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainRegistrationWindowPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainRegistrationWindowPanel.Controls.Add(Me.Password2Panel)
        Me.MainRegistrationWindowPanel.Controls.Add(Me.Password1Panel)
        Me.MainRegistrationWindowPanel.Controls.Add(Me.RegistrationLabel)
        Me.MainRegistrationWindowPanel.Controls.Add(Me.RegistrationBackButton)
        Me.MainRegistrationWindowPanel.Controls.Add(Me.RegistrationUsernamePanel)
        Me.MainRegistrationWindowPanel.Controls.Add(Me.RegistrationRegisterButton)
        Me.MainRegistrationWindowPanel.Controls.Add(Me.EmailPanel)
        Me.MainRegistrationWindowPanel.Location = New System.Drawing.Point(355, 219)
        Me.MainRegistrationWindowPanel.Name = "MainRegistrationWindowPanel"
        Me.MainRegistrationWindowPanel.Size = New System.Drawing.Size(452, 198)
        Me.MainRegistrationWindowPanel.TabIndex = 21
        Me.MainRegistrationWindowPanel.Visible = False
        '
        'Password2Panel
        '
        Me.Password2Panel.BackColor = System.Drawing.Color.Transparent
        Me.Password2Panel.BackgroundImage = CType(resources.GetObject("Password2Panel.BackgroundImage"), System.Drawing.Image)
        Me.Password2Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Password2Panel.Controls.Add(Me.Password2Field)
        Me.Password2Panel.Controls.Add(Me.Password2Label)
        Me.Password2Panel.Location = New System.Drawing.Point(14, 162)
        Me.Password2Panel.Name = "Password2Panel"
        Me.Password2Panel.Size = New System.Drawing.Size(308, 28)
        Me.Password2Panel.TabIndex = 20
        '
        'Password2Field
        '
        Me.Password2Field.BackgroundImage = CType(resources.GetObject("Password2Field.BackgroundImage"), System.Drawing.Image)
        Me.Password2Field.Location = New System.Drawing.Point(4, 10)
        Me.Password2Field.Name = "Password2Field"
        Me.Password2Field.Size = New System.Drawing.Size(302, 16)
        Me.Password2Field.TabIndex = 9
        Me.Password2Field.TabStop = False
        '
        'Password2Label
        '
        Me.Password2Label.AutoSize = True
        Me.Password2Label.BackColor = System.Drawing.Color.Transparent
        Me.Password2Label.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password2Label.ForeColor = System.Drawing.Color.White
        Me.Password2Label.Location = New System.Drawing.Point(0, -4)
        Me.Password2Label.Name = "Password2Label"
        Me.Password2Label.Size = New System.Drawing.Size(109, 17)
        Me.Password2Label.TabIndex = 5
        Me.Password2Label.Text = "Confirm Password:"
        '
        'Password1Panel
        '
        Me.Password1Panel.BackColor = System.Drawing.Color.Transparent
        Me.Password1Panel.BackgroundImage = CType(resources.GetObject("Password1Panel.BackgroundImage"), System.Drawing.Image)
        Me.Password1Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Password1Panel.Controls.Add(Me.Password1Field)
        Me.Password1Panel.Controls.Add(Me.Password1Label)
        Me.Password1Panel.Location = New System.Drawing.Point(14, 126)
        Me.Password1Panel.Name = "Password1Panel"
        Me.Password1Panel.Size = New System.Drawing.Size(308, 28)
        Me.Password1Panel.TabIndex = 19
        '
        'Password1Field
        '
        Me.Password1Field.BackgroundImage = CType(resources.GetObject("Password1Field.BackgroundImage"), System.Drawing.Image)
        Me.Password1Field.Location = New System.Drawing.Point(4, 10)
        Me.Password1Field.Name = "Password1Field"
        Me.Password1Field.Size = New System.Drawing.Size(302, 16)
        Me.Password1Field.TabIndex = 9
        Me.Password1Field.TabStop = False
        '
        'Password1Label
        '
        Me.Password1Label.AutoSize = True
        Me.Password1Label.BackColor = System.Drawing.Color.Transparent
        Me.Password1Label.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password1Label.ForeColor = System.Drawing.Color.White
        Me.Password1Label.Location = New System.Drawing.Point(0, -4)
        Me.Password1Label.Name = "Password1Label"
        Me.Password1Label.Size = New System.Drawing.Size(62, 17)
        Me.Password1Label.TabIndex = 5
        Me.Password1Label.Text = "Password:"
        '
        'RegistrationLabel
        '
        Me.RegistrationLabel.AutoSize = True
        Me.RegistrationLabel.BackColor = System.Drawing.Color.Transparent
        Me.RegistrationLabel.Font = New System.Drawing.Font("Source Sans Pro SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistrationLabel.ForeColor = System.Drawing.Color.White
        Me.RegistrationLabel.Location = New System.Drawing.Point(25, 9)
        Me.RegistrationLabel.Name = "RegistrationLabel"
        Me.RegistrationLabel.Size = New System.Drawing.Size(65, 20)
        Me.RegistrationLabel.TabIndex = 3
        Me.RegistrationLabel.Text = "Register"
        '
        'RegistrationBackButton
        '
        Me.RegistrationBackButton.BackColor = System.Drawing.Color.Transparent
        Me.RegistrationBackButton.BackgroundImage = CType(resources.GetObject("RegistrationBackButton.BackgroundImage"), System.Drawing.Image)
        Me.RegistrationBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RegistrationBackButton.Location = New System.Drawing.Point(338, 89)
        Me.RegistrationBackButton.Name = "RegistrationBackButton"
        Me.RegistrationBackButton.Size = New System.Drawing.Size(96, 35)
        Me.RegistrationBackButton.TabIndex = 18
        Me.RegistrationBackButton.TabStop = False
        '
        'RegistrationUsernamePanel
        '
        Me.RegistrationUsernamePanel.BackColor = System.Drawing.Color.Transparent
        Me.RegistrationUsernamePanel.BackgroundImage = CType(resources.GetObject("RegistrationUsernamePanel.BackgroundImage"), System.Drawing.Image)
        Me.RegistrationUsernamePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RegistrationUsernamePanel.Controls.Add(Me.RegistrationUsernameField)
        Me.RegistrationUsernamePanel.Controls.Add(Me.RegistrationUsernameLabel)
        Me.RegistrationUsernamePanel.Location = New System.Drawing.Point(14, 54)
        Me.RegistrationUsernamePanel.Name = "RegistrationUsernamePanel"
        Me.RegistrationUsernamePanel.Size = New System.Drawing.Size(308, 28)
        Me.RegistrationUsernamePanel.TabIndex = 8
        '
        'RegistrationUsernameField
        '
        Me.RegistrationUsernameField.BackgroundImage = CType(resources.GetObject("RegistrationUsernameField.BackgroundImage"), System.Drawing.Image)
        Me.RegistrationUsernameField.Location = New System.Drawing.Point(4, 10)
        Me.RegistrationUsernameField.Name = "RegistrationUsernameField"
        Me.RegistrationUsernameField.Size = New System.Drawing.Size(302, 16)
        Me.RegistrationUsernameField.TabIndex = 9
        Me.RegistrationUsernameField.TabStop = False
        '
        'RegistrationUsernameLabel
        '
        Me.RegistrationUsernameLabel.AutoSize = True
        Me.RegistrationUsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.RegistrationUsernameLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistrationUsernameLabel.ForeColor = System.Drawing.Color.White
        Me.RegistrationUsernameLabel.Location = New System.Drawing.Point(0, -4)
        Me.RegistrationUsernameLabel.Name = "RegistrationUsernameLabel"
        Me.RegistrationUsernameLabel.Size = New System.Drawing.Size(66, 17)
        Me.RegistrationUsernameLabel.TabIndex = 5
        Me.RegistrationUsernameLabel.Text = "Username:"
        '
        'RegistrationRegisterButton
        '
        Me.RegistrationRegisterButton.BackColor = System.Drawing.Color.Transparent
        Me.RegistrationRegisterButton.BackgroundImage = CType(resources.GetObject("RegistrationRegisterButton.BackgroundImage"), System.Drawing.Image)
        Me.RegistrationRegisterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RegistrationRegisterButton.Location = New System.Drawing.Point(338, 54)
        Me.RegistrationRegisterButton.Name = "RegistrationRegisterButton"
        Me.RegistrationRegisterButton.Size = New System.Drawing.Size(96, 35)
        Me.RegistrationRegisterButton.TabIndex = 17
        Me.RegistrationRegisterButton.TabStop = False
        '
        'EmailPanel
        '
        Me.EmailPanel.BackColor = System.Drawing.Color.Transparent
        Me.EmailPanel.BackgroundImage = CType(resources.GetObject("EmailPanel.BackgroundImage"), System.Drawing.Image)
        Me.EmailPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EmailPanel.Controls.Add(Me.EmailField)
        Me.EmailPanel.Controls.Add(Me.EmailLabel)
        Me.EmailPanel.Location = New System.Drawing.Point(14, 90)
        Me.EmailPanel.Name = "EmailPanel"
        Me.EmailPanel.Size = New System.Drawing.Size(308, 28)
        Me.EmailPanel.TabIndex = 9
        '
        'EmailField
        '
        Me.EmailField.BackgroundImage = CType(resources.GetObject("EmailField.BackgroundImage"), System.Drawing.Image)
        Me.EmailField.Location = New System.Drawing.Point(4, 10)
        Me.EmailField.Name = "EmailField"
        Me.EmailField.Size = New System.Drawing.Size(302, 16)
        Me.EmailField.TabIndex = 9
        Me.EmailField.TabStop = False
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.BackColor = System.Drawing.Color.Transparent
        Me.EmailLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailLabel.ForeColor = System.Drawing.Color.White
        Me.EmailLabel.Location = New System.Drawing.Point(0, -4)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(42, 17)
        Me.EmailLabel.TabIndex = 5
        Me.EmailLabel.Text = "Email:"
        '
        'MainOptionsWindowPanel
        '
        Me.MainOptionsWindowPanel.BackgroundImage = CType(resources.GetObject("MainOptionsWindowPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainOptionsWindowPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainOptionsWindowPanel.Controls.Add(Me.OptionsContainer)
        Me.MainOptionsWindowPanel.Controls.Add(Me.OptionsHeader)
        Me.MainOptionsWindowPanel.Location = New System.Drawing.Point(354, 0)
        Me.MainOptionsWindowPanel.Name = "MainOptionsWindowPanel"
        Me.MainOptionsWindowPanel.Size = New System.Drawing.Size(452, 213)
        Me.MainOptionsWindowPanel.TabIndex = 20
        Me.MainOptionsWindowPanel.Visible = False
        '
        'OptionsContainer
        '
        Me.OptionsContainer.BackColor = System.Drawing.Color.Transparent
        Me.OptionsContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OptionsContainer.Controls.Add(Me.OptionsCancelButton)
        Me.OptionsContainer.Controls.Add(Me.OptionsApplyButton)
        Me.OptionsContainer.Controls.Add(Me.MusicSlider)
        Me.OptionsContainer.Controls.Add(Me.MusicLabel)
        Me.OptionsContainer.Controls.Add(Me.SoundSlider)
        Me.OptionsContainer.Controls.Add(Me.SoundLabel)
        Me.OptionsContainer.Controls.Add(Me.KeybindingsButton)
        Me.OptionsContainer.Controls.Add(Me.AutocloseWindowsCheckboxPanel)
        Me.OptionsContainer.Controls.Add(Me.FullscreenCheckboxPanel)
        Me.OptionsContainer.Controls.Add(Me.FPSPanel)
        Me.OptionsContainer.Controls.Add(Me.ResolutionPanel)
        Me.OptionsContainer.Location = New System.Drawing.Point(0, 34)
        Me.OptionsContainer.Name = "OptionsContainer"
        Me.OptionsContainer.Size = New System.Drawing.Size(452, 179)
        Me.OptionsContainer.TabIndex = 7
        '
        'OptionsCancelButton
        '
        Me.OptionsCancelButton.BackColor = System.Drawing.Color.Transparent
        Me.OptionsCancelButton.BackgroundImage = CType(resources.GetObject("OptionsCancelButton.BackgroundImage"), System.Drawing.Image)
        Me.OptionsCancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OptionsCancelButton.Location = New System.Drawing.Point(342, 140)
        Me.OptionsCancelButton.Name = "OptionsCancelButton"
        Me.OptionsCancelButton.Size = New System.Drawing.Size(96, 35)
        Me.OptionsCancelButton.TabIndex = 18
        Me.OptionsCancelButton.TabStop = False
        '
        'OptionsApplyButton
        '
        Me.OptionsApplyButton.BackColor = System.Drawing.Color.Transparent
        Me.OptionsApplyButton.BackgroundImage = CType(resources.GetObject("OptionsApplyButton.BackgroundImage"), System.Drawing.Image)
        Me.OptionsApplyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OptionsApplyButton.Location = New System.Drawing.Point(238, 140)
        Me.OptionsApplyButton.Name = "OptionsApplyButton"
        Me.OptionsApplyButton.Size = New System.Drawing.Size(96, 35)
        Me.OptionsApplyButton.TabIndex = 17
        Me.OptionsApplyButton.TabStop = False
        '
        'MusicSlider
        '
        Me.MusicSlider.BackColor = System.Drawing.Color.Transparent
        Me.MusicSlider.BackgroundImage = CType(resources.GetObject("MusicSlider.BackgroundImage"), System.Drawing.Image)
        Me.MusicSlider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MusicSlider.Controls.Add(Me.MusicSliderBar)
        Me.MusicSlider.Location = New System.Drawing.Point(238, 62)
        Me.MusicSlider.Name = "MusicSlider"
        Me.MusicSlider.Size = New System.Drawing.Size(200, 35)
        Me.MusicSlider.TabIndex = 16
        '
        'MusicSliderBar
        '
        Me.MusicSliderBar.BackgroundImage = CType(resources.GetObject("MusicSliderBar.BackgroundImage"), System.Drawing.Image)
        Me.MusicSliderBar.Location = New System.Drawing.Point(0, 0)
        Me.MusicSliderBar.Name = "MusicSliderBar"
        Me.MusicSliderBar.Size = New System.Drawing.Size(9, 35)
        Me.MusicSliderBar.TabIndex = 0
        Me.MusicSliderBar.TabStop = False
        '
        'MusicLabel
        '
        Me.MusicLabel.AutoSize = True
        Me.MusicLabel.BackColor = System.Drawing.Color.Transparent
        Me.MusicLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MusicLabel.ForeColor = System.Drawing.Color.White
        Me.MusicLabel.Location = New System.Drawing.Point(238, 56)
        Me.MusicLabel.Name = "MusicLabel"
        Me.MusicLabel.Size = New System.Drawing.Size(85, 17)
        Me.MusicLabel.TabIndex = 15
        Me.MusicLabel.Text = "Music Volume:"
        '
        'SoundSlider
        '
        Me.SoundSlider.BackColor = System.Drawing.Color.Transparent
        Me.SoundSlider.BackgroundImage = CType(resources.GetObject("SoundSlider.BackgroundImage"), System.Drawing.Image)
        Me.SoundSlider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SoundSlider.Controls.Add(Me.SoundSliderBar)
        Me.SoundSlider.Location = New System.Drawing.Point(14, 62)
        Me.SoundSlider.Name = "SoundSlider"
        Me.SoundSlider.Size = New System.Drawing.Size(200, 35)
        Me.SoundSlider.TabIndex = 14
        '
        'SoundSliderBar
        '
        Me.SoundSliderBar.BackgroundImage = CType(resources.GetObject("SoundSliderBar.BackgroundImage"), System.Drawing.Image)
        Me.SoundSliderBar.Location = New System.Drawing.Point(0, 0)
        Me.SoundSliderBar.Name = "SoundSliderBar"
        Me.SoundSliderBar.Size = New System.Drawing.Size(9, 35)
        Me.SoundSliderBar.TabIndex = 0
        Me.SoundSliderBar.TabStop = False
        '
        'SoundLabel
        '
        Me.SoundLabel.AutoSize = True
        Me.SoundLabel.BackColor = System.Drawing.Color.Transparent
        Me.SoundLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoundLabel.ForeColor = System.Drawing.Color.White
        Me.SoundLabel.Location = New System.Drawing.Point(14, 56)
        Me.SoundLabel.Name = "SoundLabel"
        Me.SoundLabel.Size = New System.Drawing.Size(90, 17)
        Me.SoundLabel.TabIndex = 13
        Me.SoundLabel.Text = "Sound Volume:"
        '
        'KeybindingsButton
        '
        Me.KeybindingsButton.BackgroundImage = CType(resources.GetObject("KeybindingsButton.BackgroundImage"), System.Drawing.Image)
        Me.KeybindingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.KeybindingsButton.Location = New System.Drawing.Point(238, 102)
        Me.KeybindingsButton.Name = "KeybindingsButton"
        Me.KeybindingsButton.Size = New System.Drawing.Size(200, 26)
        Me.KeybindingsButton.TabIndex = 12
        Me.KeybindingsButton.TabStop = False
        '
        'AutocloseWindowsCheckboxPanel
        '
        Me.AutocloseWindowsCheckboxPanel.BackColor = System.Drawing.Color.Transparent
        Me.AutocloseWindowsCheckboxPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AutocloseWindowsCheckboxPanel.Controls.Add(Me.AutocloseWindowsCheckboxCheckbox)
        Me.AutocloseWindowsCheckboxPanel.Controls.Add(Me.AutocloseWindowsCheckboxLabel)
        Me.AutocloseWindowsCheckboxPanel.Location = New System.Drawing.Point(14, 125)
        Me.AutocloseWindowsCheckboxPanel.Name = "AutocloseWindowsCheckboxPanel"
        Me.AutocloseWindowsCheckboxPanel.Size = New System.Drawing.Size(200, 24)
        Me.AutocloseWindowsCheckboxPanel.TabIndex = 11
        '
        'AutocloseWindowsCheckboxCheckbox
        '
        Me.AutocloseWindowsCheckboxCheckbox.BackgroundImage = CType(resources.GetObject("AutocloseWindowsCheckboxCheckbox.BackgroundImage"), System.Drawing.Image)
        Me.AutocloseWindowsCheckboxCheckbox.Location = New System.Drawing.Point(179, 0)
        Me.AutocloseWindowsCheckboxCheckbox.Name = "AutocloseWindowsCheckboxCheckbox"
        Me.AutocloseWindowsCheckboxCheckbox.Size = New System.Drawing.Size(24, 25)
        Me.AutocloseWindowsCheckboxCheckbox.TabIndex = 9
        Me.AutocloseWindowsCheckboxCheckbox.TabStop = False
        '
        'AutocloseWindowsCheckboxLabel
        '
        Me.AutocloseWindowsCheckboxLabel.AutoSize = True
        Me.AutocloseWindowsCheckboxLabel.BackColor = System.Drawing.Color.Transparent
        Me.AutocloseWindowsCheckboxLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutocloseWindowsCheckboxLabel.ForeColor = System.Drawing.Color.White
        Me.AutocloseWindowsCheckboxLabel.Location = New System.Drawing.Point(0, 6)
        Me.AutocloseWindowsCheckboxLabel.Name = "AutocloseWindowsCheckboxLabel"
        Me.AutocloseWindowsCheckboxLabel.Size = New System.Drawing.Size(114, 17)
        Me.AutocloseWindowsCheckboxLabel.TabIndex = 5
        Me.AutocloseWindowsCheckboxLabel.Text = "Auto-close windows"
        '
        'FullscreenCheckboxPanel
        '
        Me.FullscreenCheckboxPanel.BackColor = System.Drawing.Color.Transparent
        Me.FullscreenCheckboxPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FullscreenCheckboxPanel.Controls.Add(Me.FullscreenCheckboxCheckbox)
        Me.FullscreenCheckboxPanel.Controls.Add(Me.FullscreenCheckboxLabel)
        Me.FullscreenCheckboxPanel.Location = New System.Drawing.Point(14, 99)
        Me.FullscreenCheckboxPanel.Name = "FullscreenCheckboxPanel"
        Me.FullscreenCheckboxPanel.Size = New System.Drawing.Size(200, 24)
        Me.FullscreenCheckboxPanel.TabIndex = 10
        '
        'FullscreenCheckboxCheckbox
        '
        Me.FullscreenCheckboxCheckbox.BackgroundImage = CType(resources.GetObject("FullscreenCheckboxCheckbox.BackgroundImage"), System.Drawing.Image)
        Me.FullscreenCheckboxCheckbox.Location = New System.Drawing.Point(179, 0)
        Me.FullscreenCheckboxCheckbox.Name = "FullscreenCheckboxCheckbox"
        Me.FullscreenCheckboxCheckbox.Size = New System.Drawing.Size(24, 25)
        Me.FullscreenCheckboxCheckbox.TabIndex = 9
        Me.FullscreenCheckboxCheckbox.TabStop = False
        '
        'FullscreenCheckboxLabel
        '
        Me.FullscreenCheckboxLabel.AutoSize = True
        Me.FullscreenCheckboxLabel.BackColor = System.Drawing.Color.Transparent
        Me.FullscreenCheckboxLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullscreenCheckboxLabel.ForeColor = System.Drawing.Color.White
        Me.FullscreenCheckboxLabel.Location = New System.Drawing.Point(0, 6)
        Me.FullscreenCheckboxLabel.Name = "FullscreenCheckboxLabel"
        Me.FullscreenCheckboxLabel.Size = New System.Drawing.Size(62, 17)
        Me.FullscreenCheckboxLabel.TabIndex = 5
        Me.FullscreenCheckboxLabel.Text = "Fullscreen"
        '
        'FPSPanel
        '
        Me.FPSPanel.BackColor = System.Drawing.Color.Transparent
        Me.FPSPanel.BackgroundImage = CType(resources.GetObject("FPSPanel.BackgroundImage"), System.Drawing.Image)
        Me.FPSPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FPSPanel.Controls.Add(Me.FPSCombobox)
        Me.FPSPanel.Controls.Add(Me.FPSLabel)
        Me.FPSPanel.Location = New System.Drawing.Point(238, 20)
        Me.FPSPanel.Name = "FPSPanel"
        Me.FPSPanel.Size = New System.Drawing.Size(200, 29)
        Me.FPSPanel.TabIndex = 9
        '
        'FPSCombobox
        '
        Me.FPSCombobox.BackgroundImage = CType(resources.GetObject("FPSCombobox.BackgroundImage"), System.Drawing.Image)
        Me.FPSCombobox.Location = New System.Drawing.Point(0, 10)
        Me.FPSCombobox.Name = "FPSCombobox"
        Me.FPSCombobox.Size = New System.Drawing.Size(200, 16)
        Me.FPSCombobox.TabIndex = 9
        Me.FPSCombobox.TabStop = False
        '
        'FPSLabel
        '
        Me.FPSLabel.AutoSize = True
        Me.FPSLabel.BackColor = System.Drawing.Color.Transparent
        Me.FPSLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FPSLabel.ForeColor = System.Drawing.Color.White
        Me.FPSLabel.Location = New System.Drawing.Point(0, -4)
        Me.FPSLabel.Name = "FPSLabel"
        Me.FPSLabel.Size = New System.Drawing.Size(69, 17)
        Me.FPSLabel.TabIndex = 5
        Me.FPSLabel.Text = "Target FPS:"
        '
        'ResolutionPanel
        '
        Me.ResolutionPanel.BackColor = System.Drawing.Color.Transparent
        Me.ResolutionPanel.BackgroundImage = CType(resources.GetObject("ResolutionPanel.BackgroundImage"), System.Drawing.Image)
        Me.ResolutionPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ResolutionPanel.Controls.Add(Me.ResolutionCombobox)
        Me.ResolutionPanel.Controls.Add(Me.ResolutionLabel)
        Me.ResolutionPanel.Location = New System.Drawing.Point(14, 20)
        Me.ResolutionPanel.Name = "ResolutionPanel"
        Me.ResolutionPanel.Size = New System.Drawing.Size(200, 29)
        Me.ResolutionPanel.TabIndex = 8
        '
        'ResolutionCombobox
        '
        Me.ResolutionCombobox.BackgroundImage = CType(resources.GetObject("ResolutionCombobox.BackgroundImage"), System.Drawing.Image)
        Me.ResolutionCombobox.Location = New System.Drawing.Point(0, 10)
        Me.ResolutionCombobox.Name = "ResolutionCombobox"
        Me.ResolutionCombobox.Size = New System.Drawing.Size(200, 16)
        Me.ResolutionCombobox.TabIndex = 9
        Me.ResolutionCombobox.TabStop = False
        '
        'ResolutionLabel
        '
        Me.ResolutionLabel.AutoSize = True
        Me.ResolutionLabel.BackColor = System.Drawing.Color.Transparent
        Me.ResolutionLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResolutionLabel.ForeColor = System.Drawing.Color.White
        Me.ResolutionLabel.Location = New System.Drawing.Point(0, -4)
        Me.ResolutionLabel.Name = "ResolutionLabel"
        Me.ResolutionLabel.Size = New System.Drawing.Size(67, 17)
        Me.ResolutionLabel.TabIndex = 5
        Me.ResolutionLabel.Text = "Resolution:"
        '
        'OptionsHeader
        '
        Me.OptionsHeader.AutoSize = True
        Me.OptionsHeader.BackColor = System.Drawing.Color.Transparent
        Me.OptionsHeader.Font = New System.Drawing.Font("Source Sans Pro SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionsHeader.ForeColor = System.Drawing.Color.White
        Me.OptionsHeader.Location = New System.Drawing.Point(25, 9)
        Me.OptionsHeader.Name = "OptionsHeader"
        Me.OptionsHeader.Size = New System.Drawing.Size(64, 20)
        Me.OptionsHeader.TabIndex = 3
        Me.OptionsHeader.Text = "Options"
        '
        'MainMenuWindowPanel
        '
        Me.MainMenuWindowPanel.BackgroundImage = CType(resources.GetObject("MainMenuWindowPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainMenuWindowPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainMenuWindowPanel.Controls.Add(Me.MainMenuOptionsButton)
        Me.MainMenuWindowPanel.Controls.Add(Me.MainMenuExitButton)
        Me.MainMenuWindowPanel.Controls.Add(Me.MainMenuCreditsButton)
        Me.MainMenuWindowPanel.Controls.Add(Me.MainMenuRegisterButton)
        Me.MainMenuWindowPanel.Controls.Add(Me.MainMenuLoginButton)
        Me.MainMenuWindowPanel.Controls.Add(Me.MainMenuTitle)
        Me.MainMenuWindowPanel.Location = New System.Drawing.Point(-103, 199)
        Me.MainMenuWindowPanel.Name = "MainMenuWindowPanel"
        Me.MainMenuWindowPanel.Size = New System.Drawing.Size(452, 213)
        Me.MainMenuWindowPanel.TabIndex = 19
        Me.MainMenuWindowPanel.Visible = False
        '
        'MainMenuOptionsButton
        '
        Me.MainMenuOptionsButton.BackColor = System.Drawing.Color.Transparent
        Me.MainMenuOptionsButton.BackgroundImage = CType(resources.GetObject("MainMenuOptionsButton.BackgroundImage"), System.Drawing.Image)
        Me.MainMenuOptionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainMenuOptionsButton.Location = New System.Drawing.Point(182, 48)
        Me.MainMenuOptionsButton.Name = "MainMenuOptionsButton"
        Me.MainMenuOptionsButton.Size = New System.Drawing.Size(87, 154)
        Me.MainMenuOptionsButton.TabIndex = 14
        Me.MainMenuOptionsButton.TabStop = False
        '
        'MainMenuExitButton
        '
        Me.MainMenuExitButton.BackColor = System.Drawing.Color.Transparent
        Me.MainMenuExitButton.BackgroundImage = CType(resources.GetObject("MainMenuExitButton.BackgroundImage"), System.Drawing.Image)
        Me.MainMenuExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainMenuExitButton.Location = New System.Drawing.Point(358, 48)
        Me.MainMenuExitButton.Name = "MainMenuExitButton"
        Me.MainMenuExitButton.Size = New System.Drawing.Size(87, 154)
        Me.MainMenuExitButton.TabIndex = 13
        Me.MainMenuExitButton.TabStop = False
        '
        'MainMenuCreditsButton
        '
        Me.MainMenuCreditsButton.BackColor = System.Drawing.Color.Transparent
        Me.MainMenuCreditsButton.BackgroundImage = CType(resources.GetObject("MainMenuCreditsButton.BackgroundImage"), System.Drawing.Image)
        Me.MainMenuCreditsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainMenuCreditsButton.Location = New System.Drawing.Point(270, 48)
        Me.MainMenuCreditsButton.Name = "MainMenuCreditsButton"
        Me.MainMenuCreditsButton.Size = New System.Drawing.Size(87, 154)
        Me.MainMenuCreditsButton.TabIndex = 12
        Me.MainMenuCreditsButton.TabStop = False
        '
        'MainMenuRegisterButton
        '
        Me.MainMenuRegisterButton.BackColor = System.Drawing.Color.Transparent
        Me.MainMenuRegisterButton.BackgroundImage = CType(resources.GetObject("MainMenuRegisterButton.BackgroundImage"), System.Drawing.Image)
        Me.MainMenuRegisterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainMenuRegisterButton.Location = New System.Drawing.Point(94, 48)
        Me.MainMenuRegisterButton.Name = "MainMenuRegisterButton"
        Me.MainMenuRegisterButton.Size = New System.Drawing.Size(87, 154)
        Me.MainMenuRegisterButton.TabIndex = 11
        Me.MainMenuRegisterButton.TabStop = False
        '
        'MainMenuLoginButton
        '
        Me.MainMenuLoginButton.BackColor = System.Drawing.Color.Transparent
        Me.MainMenuLoginButton.BackgroundImage = CType(resources.GetObject("MainMenuLoginButton.BackgroundImage"), System.Drawing.Image)
        Me.MainMenuLoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainMenuLoginButton.Location = New System.Drawing.Point(7, 48)
        Me.MainMenuLoginButton.Name = "MainMenuLoginButton"
        Me.MainMenuLoginButton.Size = New System.Drawing.Size(87, 154)
        Me.MainMenuLoginButton.TabIndex = 10
        Me.MainMenuLoginButton.TabStop = False
        '
        'MainMenuTitle
        '
        Me.MainMenuTitle.AutoSize = True
        Me.MainMenuTitle.BackColor = System.Drawing.Color.Transparent
        Me.MainMenuTitle.Font = New System.Drawing.Font("Source Sans Pro SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuTitle.ForeColor = System.Drawing.Color.White
        Me.MainMenuTitle.Location = New System.Drawing.Point(25, 9)
        Me.MainMenuTitle.Name = "MainMenuTitle"
        Me.MainMenuTitle.Size = New System.Drawing.Size(83, 20)
        Me.MainMenuTitle.TabIndex = 3
        Me.MainMenuTitle.Text = "Main Menu"
        '
        'MainLogoPanel
        '
        Me.MainLogoPanel.BackColor = System.Drawing.Color.Transparent
        Me.MainLogoPanel.BackgroundImage = CType(resources.GetObject("MainLogoPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainLogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainLogoPanel.Location = New System.Drawing.Point(-714, 525)
        Me.MainLogoPanel.Name = "MainLogoPanel"
        Me.MainLogoPanel.Size = New System.Drawing.Size(580, 186)
        Me.MainLogoPanel.TabIndex = 18
        Me.MainLogoPanel.TabStop = False
        Me.MainLogoPanel.Visible = False
        '
        'MainInputBoxPanel
        '
        Me.MainInputBoxPanel.BackgroundImage = CType(resources.GetObject("MainInputBoxPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainInputBoxPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainInputBoxPanel.Controls.Add(Me.InputBoxInnerPanel)
        Me.MainInputBoxPanel.Controls.Add(Me.InputBoxCloseButton)
        Me.MainInputBoxPanel.Controls.Add(Me.InputBoxTitle)
        Me.MainInputBoxPanel.Location = New System.Drawing.Point(-122, 418)
        Me.MainInputBoxPanel.Name = "MainInputBoxPanel"
        Me.MainInputBoxPanel.Size = New System.Drawing.Size(452, 198)
        Me.MainInputBoxPanel.TabIndex = 17
        Me.MainInputBoxPanel.Visible = False
        '
        'InputBoxInnerPanel
        '
        Me.InputBoxInnerPanel.BackColor = System.Drawing.Color.Transparent
        Me.InputBoxInnerPanel.Controls.Add(Me.OkayButton)
        Me.InputBoxInnerPanel.Controls.Add(Me.InputBoxTextBox)
        Me.InputBoxInnerPanel.Controls.Add(Me.NoButton)
        Me.InputBoxInnerPanel.Controls.Add(Me.PromptLabel)
        Me.InputBoxInnerPanel.Controls.Add(Me.YesButton)
        Me.InputBoxInnerPanel.Location = New System.Drawing.Point(3, 39)
        Me.InputBoxInnerPanel.Name = "InputBoxInnerPanel"
        Me.InputBoxInnerPanel.Size = New System.Drawing.Size(449, 156)
        Me.InputBoxInnerPanel.TabIndex = 12
        '
        'OkayButton
        '
        Me.OkayButton.BackColor = System.Drawing.Color.Transparent
        Me.OkayButton.BackgroundImage = CType(resources.GetObject("OkayButton.BackgroundImage"), System.Drawing.Image)
        Me.OkayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OkayButton.Location = New System.Drawing.Point(174, 94)
        Me.OkayButton.Name = "OkayButton"
        Me.OkayButton.Size = New System.Drawing.Size(96, 35)
        Me.OkayButton.TabIndex = 14
        Me.OkayButton.TabStop = False
        '
        'InputBoxTextBox
        '
        Me.InputBoxTextBox.BackColor = System.Drawing.Color.Transparent
        Me.InputBoxTextBox.BackgroundImage = CType(resources.GetObject("InputBoxTextBox.BackgroundImage"), System.Drawing.Image)
        Me.InputBoxTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.InputBoxTextBox.Controls.Add(Me.InputBoxTextboxText)
        Me.InputBoxTextBox.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.InputBoxTextBox.Location = New System.Drawing.Point(76, 60)
        Me.InputBoxTextBox.Name = "InputBoxTextBox"
        Me.InputBoxTextBox.Size = New System.Drawing.Size(308, 22)
        Me.InputBoxTextBox.TabIndex = 5
        '
        'InputBoxTextboxText
        '
        Me.InputBoxTextboxText.BackgroundImage = CType(resources.GetObject("InputBoxTextboxText.BackgroundImage"), System.Drawing.Image)
        Me.InputBoxTextboxText.Location = New System.Drawing.Point(0, 2)
        Me.InputBoxTextboxText.Name = "InputBoxTextboxText"
        Me.InputBoxTextboxText.Size = New System.Drawing.Size(308, 20)
        Me.InputBoxTextboxText.TabIndex = 0
        Me.InputBoxTextboxText.TabStop = False
        '
        'NoButton
        '
        Me.NoButton.BackColor = System.Drawing.Color.Transparent
        Me.NoButton.BackgroundImage = CType(resources.GetObject("NoButton.BackgroundImage"), System.Drawing.Image)
        Me.NoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NoButton.Location = New System.Drawing.Point(266, 100)
        Me.NoButton.Name = "NoButton"
        Me.NoButton.Size = New System.Drawing.Size(96, 35)
        Me.NoButton.TabIndex = 13
        Me.NoButton.TabStop = False
        '
        'PromptLabel
        '
        Me.PromptLabel.AutoSize = True
        Me.PromptLabel.BackColor = System.Drawing.Color.Transparent
        Me.PromptLabel.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PromptLabel.ForeColor = System.Drawing.Color.White
        Me.PromptLabel.Location = New System.Drawing.Point(36, 12)
        Me.PromptLabel.Name = "PromptLabel"
        Me.PromptLabel.Size = New System.Drawing.Size(91, 17)
        Me.PromptLabel.TabIndex = 4
        Me.PromptLabel.Text = "PROMPT LABEL"
        '
        'YesButton
        '
        Me.YesButton.BackColor = System.Drawing.Color.Transparent
        Me.YesButton.BackgroundImage = CType(resources.GetObject("YesButton.BackgroundImage"), System.Drawing.Image)
        Me.YesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.YesButton.Location = New System.Drawing.Point(90, 100)
        Me.YesButton.Name = "YesButton"
        Me.YesButton.Size = New System.Drawing.Size(96, 35)
        Me.YesButton.TabIndex = 10
        Me.YesButton.TabStop = False
        '
        'InputBoxCloseButton
        '
        Me.InputBoxCloseButton.BackColor = System.Drawing.Color.Transparent
        Me.InputBoxCloseButton.BackgroundImage = CType(resources.GetObject("InputBoxCloseButton.BackgroundImage"), System.Drawing.Image)
        Me.InputBoxCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.InputBoxCloseButton.InitialImage = Nothing
        Me.InputBoxCloseButton.Location = New System.Drawing.Point(432, 0)
        Me.InputBoxCloseButton.Name = "InputBoxCloseButton"
        Me.InputBoxCloseButton.Size = New System.Drawing.Size(20, 20)
        Me.InputBoxCloseButton.TabIndex = 9
        Me.InputBoxCloseButton.TabStop = False
        '
        'InputBoxTitle
        '
        Me.InputBoxTitle.AutoSize = True
        Me.InputBoxTitle.BackColor = System.Drawing.Color.Transparent
        Me.InputBoxTitle.Font = New System.Drawing.Font("Source Sans Pro SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputBoxTitle.ForeColor = System.Drawing.Color.White
        Me.InputBoxTitle.Location = New System.Drawing.Point(25, 9)
        Me.InputBoxTitle.Name = "InputBoxTitle"
        Me.InputBoxTitle.Size = New System.Drawing.Size(129, 20)
        Me.InputBoxTitle.TabIndex = 3
        Me.InputBoxTitle.Text = "INPUT BOX TITLE"
        '
        'MainForgotPasswordWindowPanel
        '
        Me.MainForgotPasswordWindowPanel.BackgroundImage = CType(resources.GetObject("MainForgotPasswordWindowPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainForgotPasswordWindowPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainForgotPasswordWindowPanel.Controls.Add(Me.ForgotPasswordHintLabel)
        Me.MainForgotPasswordWindowPanel.Controls.Add(Me.ForgotPasswordBackButton)
        Me.MainForgotPasswordWindowPanel.Controls.Add(Me.ForgotPasswordSubmitButton)
        Me.MainForgotPasswordWindowPanel.Controls.Add(Me.ForgotPasswordInputPanel)
        Me.MainForgotPasswordWindowPanel.Controls.Add(Me.ForgotPasswordHeader)
        Me.MainForgotPasswordWindowPanel.Location = New System.Drawing.Point(-120, 35)
        Me.MainForgotPasswordWindowPanel.Name = "MainForgotPasswordWindowPanel"
        Me.MainForgotPasswordWindowPanel.Size = New System.Drawing.Size(452, 158)
        Me.MainForgotPasswordWindowPanel.TabIndex = 16
        Me.MainForgotPasswordWindowPanel.Visible = False
        '
        'ForgotPasswordHintLabel
        '
        Me.ForgotPasswordHintLabel.AutoSize = True
        Me.ForgotPasswordHintLabel.BackColor = System.Drawing.Color.Transparent
        Me.ForgotPasswordHintLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForgotPasswordHintLabel.ForeColor = System.Drawing.Color.White
        Me.ForgotPasswordHintLabel.Location = New System.Drawing.Point(14, 90)
        Me.ForgotPasswordHintLabel.Name = "ForgotPasswordHintLabel"
        Me.ForgotPasswordHintLabel.Size = New System.Drawing.Size(84, 16)
        Me.ForgotPasswordHintLabel.TabIndex = 4
        Me.ForgotPasswordHintLabel.Text = "HINT LABEL"
        '
        'ForgotPasswordBackButton
        '
        Me.ForgotPasswordBackButton.BackColor = System.Drawing.Color.Transparent
        Me.ForgotPasswordBackButton.BackgroundImage = CType(resources.GetObject("ForgotPasswordBackButton.BackgroundImage"), System.Drawing.Image)
        Me.ForgotPasswordBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ForgotPasswordBackButton.Location = New System.Drawing.Point(338, 89)
        Me.ForgotPasswordBackButton.Name = "ForgotPasswordBackButton"
        Me.ForgotPasswordBackButton.Size = New System.Drawing.Size(96, 35)
        Me.ForgotPasswordBackButton.TabIndex = 10
        Me.ForgotPasswordBackButton.TabStop = False
        '
        'ForgotPasswordSubmitButton
        '
        Me.ForgotPasswordSubmitButton.BackColor = System.Drawing.Color.Transparent
        Me.ForgotPasswordSubmitButton.BackgroundImage = CType(resources.GetObject("ForgotPasswordSubmitButton.BackgroundImage"), System.Drawing.Image)
        Me.ForgotPasswordSubmitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ForgotPasswordSubmitButton.Location = New System.Drawing.Point(338, 54)
        Me.ForgotPasswordSubmitButton.Name = "ForgotPasswordSubmitButton"
        Me.ForgotPasswordSubmitButton.Size = New System.Drawing.Size(96, 35)
        Me.ForgotPasswordSubmitButton.TabIndex = 9
        Me.ForgotPasswordSubmitButton.TabStop = False
        '
        'ForgotPasswordInputPanel
        '
        Me.ForgotPasswordInputPanel.BackColor = System.Drawing.Color.Transparent
        Me.ForgotPasswordInputPanel.BackgroundImage = CType(resources.GetObject("ForgotPasswordInputPanel.BackgroundImage"), System.Drawing.Image)
        Me.ForgotPasswordInputPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ForgotPasswordInputPanel.Controls.Add(Me.ForgotPasswordInputField)
        Me.ForgotPasswordInputPanel.Controls.Add(Me.ForgotPasswordInputLabel)
        Me.ForgotPasswordInputPanel.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.ForgotPasswordInputPanel.Location = New System.Drawing.Point(14, 54)
        Me.ForgotPasswordInputPanel.Name = "ForgotPasswordInputPanel"
        Me.ForgotPasswordInputPanel.Size = New System.Drawing.Size(308, 28)
        Me.ForgotPasswordInputPanel.TabIndex = 5
        '
        'ForgotPasswordInputField
        '
        Me.ForgotPasswordInputField.BackgroundImage = CType(resources.GetObject("ForgotPasswordInputField.BackgroundImage"), System.Drawing.Image)
        Me.ForgotPasswordInputField.Location = New System.Drawing.Point(4, 10)
        Me.ForgotPasswordInputField.Name = "ForgotPasswordInputField"
        Me.ForgotPasswordInputField.Size = New System.Drawing.Size(302, 16)
        Me.ForgotPasswordInputField.TabIndex = 0
        Me.ForgotPasswordInputField.TabStop = False
        '
        'ForgotPasswordInputLabel
        '
        Me.ForgotPasswordInputLabel.AutoSize = True
        Me.ForgotPasswordInputLabel.BackColor = System.Drawing.Color.Transparent
        Me.ForgotPasswordInputLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForgotPasswordInputLabel.ForeColor = System.Drawing.Color.White
        Me.ForgotPasswordInputLabel.Location = New System.Drawing.Point(0, -4)
        Me.ForgotPasswordInputLabel.Name = "ForgotPasswordInputLabel"
        Me.ForgotPasswordInputLabel.Size = New System.Drawing.Size(74, 16)
        Me.ForgotPasswordInputLabel.TabIndex = 4
        Me.ForgotPasswordInputLabel.Text = "Username:"
        '
        'ForgotPasswordHeader
        '
        Me.ForgotPasswordHeader.AutoSize = True
        Me.ForgotPasswordHeader.BackColor = System.Drawing.Color.Transparent
        Me.ForgotPasswordHeader.Font = New System.Drawing.Font("Source Sans Pro SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForgotPasswordHeader.ForeColor = System.Drawing.Color.White
        Me.ForgotPasswordHeader.Location = New System.Drawing.Point(25, 9)
        Me.ForgotPasswordHeader.Name = "ForgotPasswordHeader"
        Me.ForgotPasswordHeader.Size = New System.Drawing.Size(124, 20)
        Me.ForgotPasswordHeader.TabIndex = 3
        Me.ForgotPasswordHeader.Text = "Forgot Password"
        '
        'MainCreditsPanel
        '
        Me.MainCreditsPanel.BackgroundImage = CType(resources.GetObject("MainCreditsPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainCreditsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainCreditsPanel.Controls.Add(Me.CreditsBackButton)
        Me.MainCreditsPanel.Controls.Add(Me.CreditsScrollview)
        Me.MainCreditsPanel.Controls.Add(Me.CreditsHeader)
        Me.MainCreditsPanel.Location = New System.Drawing.Point(-120, -233)
        Me.MainCreditsPanel.Name = "MainCreditsPanel"
        Me.MainCreditsPanel.Size = New System.Drawing.Size(452, 262)
        Me.MainCreditsPanel.TabIndex = 15
        Me.MainCreditsPanel.Visible = False
        '
        'CreditsBackButton
        '
        Me.CreditsBackButton.BackColor = System.Drawing.Color.Transparent
        Me.CreditsBackButton.BackgroundImage = CType(resources.GetObject("CreditsBackButton.BackgroundImage"), System.Drawing.Image)
        Me.CreditsBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CreditsBackButton.Location = New System.Drawing.Point(166, 228)
        Me.CreditsBackButton.Name = "CreditsBackButton"
        Me.CreditsBackButton.Size = New System.Drawing.Size(120, 28)
        Me.CreditsBackButton.TabIndex = 14
        Me.CreditsBackButton.TabStop = False
        '
        'CreditsScrollview
        '
        Me.CreditsScrollview.BackColor = System.Drawing.Color.Transparent
        Me.CreditsScrollview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CreditsScrollview.Controls.Add(Me.CreditsInnerPanel)
        Me.CreditsScrollview.Location = New System.Drawing.Point(0, 40)
        Me.CreditsScrollview.Name = "CreditsScrollview"
        Me.CreditsScrollview.Size = New System.Drawing.Size(451, 169)
        Me.CreditsScrollview.TabIndex = 7
        '
        'CreditsInnerPanel
        '
        Me.CreditsInnerPanel.BackColor = System.Drawing.Color.Transparent
        Me.CreditsInnerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CreditsInnerPanel.Controls.Add(Me.CreditsLabel)
        Me.CreditsInnerPanel.Location = New System.Drawing.Point(0, 0)
        Me.CreditsInnerPanel.Name = "CreditsInnerPanel"
        Me.CreditsInnerPanel.Size = New System.Drawing.Size(10, 10)
        Me.CreditsInnerPanel.TabIndex = 8
        '
        'CreditsLabel
        '
        Me.CreditsLabel.AutoSize = True
        Me.CreditsLabel.BackColor = System.Drawing.Color.Transparent
        Me.CreditsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreditsLabel.ForeColor = System.Drawing.Color.White
        Me.CreditsLabel.Location = New System.Drawing.Point(14, 4)
        Me.CreditsLabel.Name = "CreditsLabel"
        Me.CreditsLabel.Size = New System.Drawing.Size(98, 20)
        Me.CreditsLabel.TabIndex = 4
        Me.CreditsLabel.Text = "CreditsLabel"
        '
        'CreditsHeader
        '
        Me.CreditsHeader.AutoSize = True
        Me.CreditsHeader.BackColor = System.Drawing.Color.Transparent
        Me.CreditsHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreditsHeader.ForeColor = System.Drawing.Color.White
        Me.CreditsHeader.Location = New System.Drawing.Point(25, 9)
        Me.CreditsHeader.Name = "CreditsHeader"
        Me.CreditsHeader.Size = New System.Drawing.Size(59, 20)
        Me.CreditsHeader.TabIndex = 3
        Me.CreditsHeader.Text = "Credits"
        '
        'MainCharSelectionPanel
        '
        Me.MainCharSelectionPanel.BackgroundImage = CType(resources.GetObject("MainCharSelectionPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainCharSelectionPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainCharSelectionPanel.Controls.Add(Me.LogoutButton)
        Me.MainCharSelectionPanel.Controls.Add(Me.NewButton)
        Me.MainCharSelectionPanel.Controls.Add(Me.CharacterInfoLabel)
        Me.MainCharSelectionPanel.Controls.Add(Me.SelectCharCharacterNameLabel)
        Me.MainCharSelectionPanel.Controls.Add(Me.DeleteButton)
        Me.MainCharSelectionPanel.Controls.Add(Me.PlayButton)
        Me.MainCharSelectionPanel.Controls.Add(Me.SelectCharCharacterContainer)
        Me.MainCharSelectionPanel.Controls.Add(Me.CharacterSelectionHeader)
        Me.MainCharSelectionPanel.Location = New System.Drawing.Point(-578, 132)
        Me.MainCharSelectionPanel.Name = "MainCharSelectionPanel"
        Me.MainCharSelectionPanel.Size = New System.Drawing.Size(452, 198)
        Me.MainCharSelectionPanel.TabIndex = 12
        Me.MainCharSelectionPanel.Visible = False
        '
        'LogoutButton
        '
        Me.LogoutButton.BackColor = System.Drawing.Color.Transparent
        Me.LogoutButton.BackgroundImage = CType(resources.GetObject("LogoutButton.BackgroundImage"), System.Drawing.Image)
        Me.LogoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoutButton.Location = New System.Drawing.Point(288, 142)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(96, 35)
        Me.LogoutButton.TabIndex = 14
        Me.LogoutButton.TabStop = False
        '
        'NewButton
        '
        Me.NewButton.BackColor = System.Drawing.Color.Transparent
        Me.NewButton.BackgroundImage = CType(resources.GetObject("NewButton.BackgroundImage"), System.Drawing.Image)
        Me.NewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NewButton.Location = New System.Drawing.Point(288, 56)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(96, 35)
        Me.NewButton.TabIndex = 13
        Me.NewButton.TabStop = False
        '
        'CharacterInfoLabel
        '
        Me.CharacterInfoLabel.AutoSize = True
        Me.CharacterInfoLabel.BackColor = System.Drawing.Color.Transparent
        Me.CharacterInfoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CharacterInfoLabel.ForeColor = System.Drawing.Color.White
        Me.CharacterInfoLabel.Location = New System.Drawing.Point(68, 70)
        Me.CharacterInfoLabel.Name = "CharacterInfoLabel"
        Me.CharacterInfoLabel.Size = New System.Drawing.Size(105, 16)
        Me.CharacterInfoLabel.TabIndex = 12
        Me.CharacterInfoLabel.Text = "Level 99 Warrior"
        '
        'SelectCharCharacterNameLabel
        '
        Me.SelectCharCharacterNameLabel.AutoSize = True
        Me.SelectCharCharacterNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.SelectCharCharacterNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectCharCharacterNameLabel.ForeColor = System.Drawing.Color.White
        Me.SelectCharCharacterNameLabel.Location = New System.Drawing.Point(68, 56)
        Me.SelectCharCharacterNameLabel.Name = "SelectCharCharacterNameLabel"
        Me.SelectCharCharacterNameLabel.Size = New System.Drawing.Size(103, 16)
        Me.SelectCharCharacterNameLabel.TabIndex = 11
        Me.SelectCharCharacterNameLabel.Text = "CharacterName"
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.Transparent
        Me.DeleteButton.BackgroundImage = CType(resources.GetObject("DeleteButton.BackgroundImage"), System.Drawing.Image)
        Me.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DeleteButton.Location = New System.Drawing.Point(288, 99)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(96, 35)
        Me.DeleteButton.TabIndex = 10
        Me.DeleteButton.TabStop = False
        '
        'PlayButton
        '
        Me.PlayButton.BackColor = System.Drawing.Color.Transparent
        Me.PlayButton.BackgroundImage = CType(resources.GetObject("PlayButton.BackgroundImage"), System.Drawing.Image)
        Me.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlayButton.Location = New System.Drawing.Point(288, 56)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(96, 35)
        Me.PlayButton.TabIndex = 9
        Me.PlayButton.TabStop = False
        '
        'SelectCharCharacterContainer
        '
        Me.SelectCharCharacterContainer.BackColor = System.Drawing.Color.Transparent
        Me.SelectCharCharacterContainer.BackgroundImage = CType(resources.GetObject("SelectCharCharacterContainer.BackgroundImage"), System.Drawing.Image)
        Me.SelectCharCharacterContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SelectCharCharacterContainer.Controls.Add(Me.PreviousCharacterButton)
        Me.SelectCharCharacterContainer.Controls.Add(Me.NextCharacterButton)
        Me.SelectCharCharacterContainer.Controls.Add(Me.SelectCharCharacterPortrait)
        Me.SelectCharCharacterContainer.Location = New System.Drawing.Point(68, 94)
        Me.SelectCharCharacterContainer.Name = "SelectCharCharacterContainer"
        Me.SelectCharCharacterContainer.Size = New System.Drawing.Size(178, 79)
        Me.SelectCharCharacterContainer.TabIndex = 7
        '
        'PreviousCharacterButton
        '
        Me.PreviousCharacterButton.BackgroundImage = CType(resources.GetObject("PreviousCharacterButton.BackgroundImage"), System.Drawing.Image)
        Me.PreviousCharacterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PreviousCharacterButton.Location = New System.Drawing.Point(0, 22)
        Me.PreviousCharacterButton.Name = "PreviousCharacterButton"
        Me.PreviousCharacterButton.Size = New System.Drawing.Size(30, 25)
        Me.PreviousCharacterButton.TabIndex = 2
        Me.PreviousCharacterButton.TabStop = False
        '
        'NextCharacterButton
        '
        Me.NextCharacterButton.BackgroundImage = CType(resources.GetObject("NextCharacterButton.BackgroundImage"), System.Drawing.Image)
        Me.NextCharacterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NextCharacterButton.Location = New System.Drawing.Point(148, 22)
        Me.NextCharacterButton.Name = "NextCharacterButton"
        Me.NextCharacterButton.Size = New System.Drawing.Size(30, 25)
        Me.NextCharacterButton.TabIndex = 1
        Me.NextCharacterButton.TabStop = False
        '
        'SelectCharCharacterPortrait
        '
        Me.SelectCharCharacterPortrait.BackgroundImage = CType(resources.GetObject("SelectCharCharacterPortrait.BackgroundImage"), System.Drawing.Image)
        Me.SelectCharCharacterPortrait.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SelectCharCharacterPortrait.Location = New System.Drawing.Point(65, 15)
        Me.SelectCharCharacterPortrait.Name = "SelectCharCharacterPortrait"
        Me.SelectCharCharacterPortrait.Size = New System.Drawing.Size(48, 48)
        Me.SelectCharCharacterPortrait.TabIndex = 0
        Me.SelectCharCharacterPortrait.TabStop = False
        '
        'CharacterSelectionHeader
        '
        Me.CharacterSelectionHeader.AutoSize = True
        Me.CharacterSelectionHeader.BackColor = System.Drawing.Color.Transparent
        Me.CharacterSelectionHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CharacterSelectionHeader.ForeColor = System.Drawing.Color.White
        Me.CharacterSelectionHeader.Location = New System.Drawing.Point(25, 9)
        Me.CharacterSelectionHeader.Name = "CharacterSelectionHeader"
        Me.CharacterSelectionHeader.Size = New System.Drawing.Size(141, 20)
        Me.CharacterSelectionHeader.TabIndex = 3
        Me.CharacterSelectionHeader.Text = "Select a Character"
        '
        'MainCharacterCreationPanel
        '
        Me.MainCharacterCreationPanel.BackgroundImage = CType(resources.GetObject("MainCharacterCreationPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainCharacterCreationPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainCharacterCreationPanel.Controls.Add(Me.GenderPanel)
        Me.MainCharacterCreationPanel.Controls.Add(Me.Hint2Label)
        Me.MainCharacterCreationPanel.Controls.Add(Me.HintLabel)
        Me.MainCharacterCreationPanel.Controls.Add(Me.CharCreateBackButton)
        Me.MainCharacterCreationPanel.Controls.Add(Me.CreateButton)
        Me.MainCharacterCreationPanel.Controls.Add(Me.CharacterContainer)
        Me.MainCharacterCreationPanel.Controls.Add(Me.ClassPanel)
        Me.MainCharacterCreationPanel.Controls.Add(Me.CharacterNamePanel)
        Me.MainCharacterCreationPanel.Controls.Add(Me.CharacterCreationHeader)
        Me.MainCharacterCreationPanel.Location = New System.Drawing.Point(-578, -72)
        Me.MainCharacterCreationPanel.Name = "MainCharacterCreationPanel"
        Me.MainCharacterCreationPanel.Size = New System.Drawing.Size(452, 198)
        Me.MainCharacterCreationPanel.TabIndex = 11
        Me.MainCharacterCreationPanel.Visible = False
        '
        'GenderPanel
        '
        Me.GenderPanel.BackColor = System.Drawing.Color.Transparent
        Me.GenderPanel.Controls.Add(Me.FemaleCheckboxPanel)
        Me.GenderPanel.Controls.Add(Me.MaleCheckboxPanel)
        Me.GenderPanel.Controls.Add(Me.GenderLabel)
        Me.GenderPanel.Location = New System.Drawing.Point(228, 124)
        Me.GenderPanel.Name = "GenderPanel"
        Me.GenderPanel.Size = New System.Drawing.Size(459, 30)
        Me.GenderPanel.TabIndex = 13
        '
        'FemaleCheckboxPanel
        '
        Me.FemaleCheckboxPanel.BackColor = System.Drawing.Color.Transparent
        Me.FemaleCheckboxPanel.Controls.Add(Me.FemaleCheckboxLabel)
        Me.FemaleCheckboxPanel.Controls.Add(Me.FemaleCheckbox)
        Me.FemaleCheckboxPanel.Location = New System.Drawing.Point(146, 0)
        Me.FemaleCheckboxPanel.Name = "FemaleCheckboxPanel"
        Me.FemaleCheckboxPanel.Size = New System.Drawing.Size(100, 24)
        Me.FemaleCheckboxPanel.TabIndex = 15
        '
        'FemaleCheckboxLabel
        '
        Me.FemaleCheckboxLabel.AutoSize = True
        Me.FemaleCheckboxLabel.BackColor = System.Drawing.Color.Transparent
        Me.FemaleCheckboxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FemaleCheckboxLabel.ForeColor = System.Drawing.Color.White
        Me.FemaleCheckboxLabel.Location = New System.Drawing.Point(0, 6)
        Me.FemaleCheckboxLabel.Name = "FemaleCheckboxLabel"
        Me.FemaleCheckboxLabel.Size = New System.Drawing.Size(44, 13)
        Me.FemaleCheckboxLabel.TabIndex = 6
        Me.FemaleCheckboxLabel.Text = "Female:"
        '
        'FemaleCheckbox
        '
        Me.FemaleCheckbox.BackgroundImage = CType(resources.GetObject("FemaleCheckbox.BackgroundImage"), System.Drawing.Image)
        Me.FemaleCheckbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FemaleCheckbox.Location = New System.Drawing.Point(48, 0)
        Me.FemaleCheckbox.Name = "FemaleCheckbox"
        Me.FemaleCheckbox.Size = New System.Drawing.Size(24, 25)
        Me.FemaleCheckbox.TabIndex = 0
        Me.FemaleCheckbox.TabStop = False
        '
        'MaleCheckboxPanel
        '
        Me.MaleCheckboxPanel.BackColor = System.Drawing.Color.Transparent
        Me.MaleCheckboxPanel.Controls.Add(Me.MaleCheckboxLabel)
        Me.MaleCheckboxPanel.Controls.Add(Me.MaleCheckbox)
        Me.MaleCheckboxPanel.Location = New System.Drawing.Point(74, 0)
        Me.MaleCheckboxPanel.Name = "MaleCheckboxPanel"
        Me.MaleCheckboxPanel.Size = New System.Drawing.Size(80, 24)
        Me.MaleCheckboxPanel.TabIndex = 14
        '
        'MaleCheckboxLabel
        '
        Me.MaleCheckboxLabel.AutoSize = True
        Me.MaleCheckboxLabel.BackColor = System.Drawing.Color.Transparent
        Me.MaleCheckboxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaleCheckboxLabel.ForeColor = System.Drawing.Color.White
        Me.MaleCheckboxLabel.Location = New System.Drawing.Point(0, 6)
        Me.MaleCheckboxLabel.Name = "MaleCheckboxLabel"
        Me.MaleCheckboxLabel.Size = New System.Drawing.Size(33, 13)
        Me.MaleCheckboxLabel.TabIndex = 6
        Me.MaleCheckboxLabel.Text = "Male:"
        '
        'MaleCheckbox
        '
        Me.MaleCheckbox.BackgroundImage = CType(resources.GetObject("MaleCheckbox.BackgroundImage"), System.Drawing.Image)
        Me.MaleCheckbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MaleCheckbox.Location = New System.Drawing.Point(32, 0)
        Me.MaleCheckbox.Name = "MaleCheckbox"
        Me.MaleCheckbox.Size = New System.Drawing.Size(24, 25)
        Me.MaleCheckbox.TabIndex = 0
        Me.MaleCheckbox.TabStop = False
        '
        'GenderLabel
        '
        Me.GenderLabel.AutoSize = True
        Me.GenderLabel.BackColor = System.Drawing.Color.Transparent
        Me.GenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderLabel.ForeColor = System.Drawing.Color.White
        Me.GenderLabel.Location = New System.Drawing.Point(0, 6)
        Me.GenderLabel.Name = "GenderLabel"
        Me.GenderLabel.Size = New System.Drawing.Size(45, 13)
        Me.GenderLabel.TabIndex = 5
        Me.GenderLabel.Text = "Gender:"
        '
        'Hint2Label
        '
        Me.Hint2Label.AutoSize = True
        Me.Hint2Label.BackColor = System.Drawing.Color.Transparent
        Me.Hint2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hint2Label.ForeColor = System.Drawing.Color.White
        Me.Hint2Label.Location = New System.Drawing.Point(16, 70)
        Me.Hint2Label.Name = "Hint2Label"
        Me.Hint2Label.Size = New System.Drawing.Size(97, 16)
        Me.Hint2Label.TabIndex = 12
        Me.Hint2Label.Text = "Your Character"
        '
        'HintLabel
        '
        Me.HintLabel.AutoSize = True
        Me.HintLabel.BackColor = System.Drawing.Color.Transparent
        Me.HintLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HintLabel.ForeColor = System.Drawing.Color.White
        Me.HintLabel.Location = New System.Drawing.Point(16, 56)
        Me.HintLabel.Name = "HintLabel"
        Me.HintLabel.Size = New System.Drawing.Size(70, 16)
        Me.HintLabel.TabIndex = 11
        Me.HintLabel.Text = "Customize"
        '
        'CharCreateBackButton
        '
        Me.CharCreateBackButton.BackColor = System.Drawing.Color.Transparent
        Me.CharCreateBackButton.BackgroundImage = CType(resources.GetObject("CharCreateBackButton.BackgroundImage"), System.Drawing.Image)
        Me.CharCreateBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CharCreateBackButton.Location = New System.Drawing.Point(353, 158)
        Me.CharCreateBackButton.Name = "CharCreateBackButton"
        Me.CharCreateBackButton.Size = New System.Drawing.Size(96, 35)
        Me.CharCreateBackButton.TabIndex = 10
        Me.CharCreateBackButton.TabStop = False
        '
        'CreateButton
        '
        Me.CreateButton.BackColor = System.Drawing.Color.Transparent
        Me.CreateButton.BackgroundImage = CType(resources.GetObject("CreateButton.BackgroundImage"), System.Drawing.Image)
        Me.CreateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CreateButton.Location = New System.Drawing.Point(223, 158)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(96, 35)
        Me.CreateButton.TabIndex = 9
        Me.CreateButton.TabStop = False
        '
        'CharacterContainer
        '
        Me.CharacterContainer.BackColor = System.Drawing.Color.Transparent
        Me.CharacterContainer.BackgroundImage = CType(resources.GetObject("CharacterContainer.BackgroundImage"), System.Drawing.Image)
        Me.CharacterContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CharacterContainer.Controls.Add(Me.PreviousSpriteButton)
        Me.CharacterContainer.Controls.Add(Me.NextSpriteButton)
        Me.CharacterContainer.Controls.Add(Me.CharacterPortait)
        Me.CharacterContainer.Location = New System.Drawing.Point(16, 100)
        Me.CharacterContainer.Name = "CharacterContainer"
        Me.CharacterContainer.Size = New System.Drawing.Size(178, 79)
        Me.CharacterContainer.TabIndex = 7
        '
        'PreviousSpriteButton
        '
        Me.PreviousSpriteButton.BackgroundImage = CType(resources.GetObject("PreviousSpriteButton.BackgroundImage"), System.Drawing.Image)
        Me.PreviousSpriteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PreviousSpriteButton.Location = New System.Drawing.Point(0, 22)
        Me.PreviousSpriteButton.Name = "PreviousSpriteButton"
        Me.PreviousSpriteButton.Size = New System.Drawing.Size(30, 25)
        Me.PreviousSpriteButton.TabIndex = 2
        Me.PreviousSpriteButton.TabStop = False
        '
        'NextSpriteButton
        '
        Me.NextSpriteButton.BackgroundImage = CType(resources.GetObject("NextSpriteButton.BackgroundImage"), System.Drawing.Image)
        Me.NextSpriteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NextSpriteButton.Location = New System.Drawing.Point(148, 22)
        Me.NextSpriteButton.Name = "NextSpriteButton"
        Me.NextSpriteButton.Size = New System.Drawing.Size(30, 25)
        Me.NextSpriteButton.TabIndex = 1
        Me.NextSpriteButton.TabStop = False
        '
        'CharacterPortait
        '
        Me.CharacterPortait.BackgroundImage = CType(resources.GetObject("CharacterPortait.BackgroundImage"), System.Drawing.Image)
        Me.CharacterPortait.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CharacterPortait.Location = New System.Drawing.Point(65, 15)
        Me.CharacterPortait.Name = "CharacterPortait"
        Me.CharacterPortait.Size = New System.Drawing.Size(48, 48)
        Me.CharacterPortait.TabIndex = 0
        Me.CharacterPortait.TabStop = False
        '
        'ClassPanel
        '
        Me.ClassPanel.BackColor = System.Drawing.Color.Transparent
        Me.ClassPanel.BackgroundImage = CType(resources.GetObject("ClassPanel.BackgroundImage"), System.Drawing.Image)
        Me.ClassPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClassPanel.Controls.Add(Me.ClassCombobox)
        Me.ClassPanel.Controls.Add(Me.ClassLabel)
        Me.ClassPanel.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.ClassPanel.Location = New System.Drawing.Point(228, 92)
        Me.ClassPanel.Name = "ClassPanel"
        Me.ClassPanel.Size = New System.Drawing.Size(216, 28)
        Me.ClassPanel.TabIndex = 6
        '
        'ClassCombobox
        '
        Me.ClassCombobox.BackgroundImage = CType(resources.GetObject("ClassCombobox.BackgroundImage"), System.Drawing.Image)
        Me.ClassCombobox.Location = New System.Drawing.Point(4, 10)
        Me.ClassCombobox.Name = "ClassCombobox"
        Me.ClassCombobox.Size = New System.Drawing.Size(216, 16)
        Me.ClassCombobox.TabIndex = 0
        Me.ClassCombobox.TabStop = False
        '
        'ClassLabel
        '
        Me.ClassLabel.AutoSize = True
        Me.ClassLabel.BackColor = System.Drawing.Color.Transparent
        Me.ClassLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassLabel.ForeColor = System.Drawing.Color.White
        Me.ClassLabel.Location = New System.Drawing.Point(0, -4)
        Me.ClassLabel.Name = "ClassLabel"
        Me.ClassLabel.Size = New System.Drawing.Size(45, 16)
        Me.ClassLabel.TabIndex = 4
        Me.ClassLabel.Text = "Class:"
        '
        'CharacterNamePanel
        '
        Me.CharacterNamePanel.BackColor = System.Drawing.Color.Transparent
        Me.CharacterNamePanel.BackgroundImage = CType(resources.GetObject("CharacterNamePanel.BackgroundImage"), System.Drawing.Image)
        Me.CharacterNamePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CharacterNamePanel.Controls.Add(Me.CharacterNameField)
        Me.CharacterNamePanel.Controls.Add(Me.CharacterNameLabel)
        Me.CharacterNamePanel.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.CharacterNamePanel.Location = New System.Drawing.Point(228, 56)
        Me.CharacterNamePanel.Name = "CharacterNamePanel"
        Me.CharacterNamePanel.Size = New System.Drawing.Size(216, 28)
        Me.CharacterNamePanel.TabIndex = 5
        '
        'CharacterNameField
        '
        Me.CharacterNameField.BackgroundImage = CType(resources.GetObject("CharacterNameField.BackgroundImage"), System.Drawing.Image)
        Me.CharacterNameField.Location = New System.Drawing.Point(4, 10)
        Me.CharacterNameField.Name = "CharacterNameField"
        Me.CharacterNameField.Size = New System.Drawing.Size(216, 16)
        Me.CharacterNameField.TabIndex = 0
        Me.CharacterNameField.TabStop = False
        '
        'CharacterNameLabel
        '
        Me.CharacterNameLabel.AutoSize = True
        Me.CharacterNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.CharacterNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CharacterNameLabel.ForeColor = System.Drawing.Color.White
        Me.CharacterNameLabel.Location = New System.Drawing.Point(0, -4)
        Me.CharacterNameLabel.Name = "CharacterNameLabel"
        Me.CharacterNameLabel.Size = New System.Drawing.Size(79, 16)
        Me.CharacterNameLabel.TabIndex = 4
        Me.CharacterNameLabel.Text = "Char Name:"
        '
        'CharacterCreationHeader
        '
        Me.CharacterCreationHeader.AutoSize = True
        Me.CharacterCreationHeader.BackColor = System.Drawing.Color.Transparent
        Me.CharacterCreationHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CharacterCreationHeader.ForeColor = System.Drawing.Color.White
        Me.CharacterCreationHeader.Location = New System.Drawing.Point(25, 9)
        Me.CharacterCreationHeader.Name = "CharacterCreationHeader"
        Me.CharacterCreationHeader.Size = New System.Drawing.Size(131, 20)
        Me.CharacterCreationHeader.TabIndex = 3
        Me.CharacterCreationHeader.Text = "Create Character"
        '
        'MainLoginWindowPanel
        '
        Me.MainLoginWindowPanel.BackgroundImage = CType(resources.GetObject("MainLoginWindowPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainLoginWindowPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainLoginWindowPanel.Controls.Add(Me.BackButton)
        Me.MainLoginWindowPanel.Controls.Add(Me.LoginButton)
        Me.MainLoginWindowPanel.Controls.Add(Me.SavePassPanel)
        Me.MainLoginWindowPanel.Controls.Add(Me.PasswordPanel)
        Me.MainLoginWindowPanel.Controls.Add(Me.UsernamePanel)
        Me.MainLoginWindowPanel.Controls.Add(Me.LoginHeaderLabel)
        Me.MainLoginWindowPanel.Location = New System.Drawing.Point(-578, -233)
        Me.MainLoginWindowPanel.Name = "MainLoginWindowPanel"
        Me.MainLoginWindowPanel.Size = New System.Drawing.Size(452, 158)
        Me.MainLoginWindowPanel.TabIndex = 3
        Me.MainLoginWindowPanel.Visible = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.Transparent
        Me.BackButton.BackgroundImage = CType(resources.GetObject("BackButton.BackgroundImage"), System.Drawing.Image)
        Me.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BackButton.Location = New System.Drawing.Point(338, 89)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(96, 35)
        Me.BackButton.TabIndex = 10
        Me.BackButton.TabStop = False
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.Color.Transparent
        Me.LoginButton.BackgroundImage = CType(resources.GetObject("LoginButton.BackgroundImage"), System.Drawing.Image)
        Me.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LoginButton.Location = New System.Drawing.Point(338, 54)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(96, 35)
        Me.LoginButton.TabIndex = 9
        Me.LoginButton.TabStop = False
        '
        'SavePassPanel
        '
        Me.SavePassPanel.BackColor = System.Drawing.Color.Transparent
        Me.SavePassPanel.Controls.Add(Me.SavePassLabel)
        Me.SavePassPanel.Controls.Add(Me.SavePassCheckbox)
        Me.SavePassPanel.Location = New System.Drawing.Point(13, 124)
        Me.SavePassPanel.Name = "SavePassPanel"
        Me.SavePassPanel.Size = New System.Drawing.Size(160, 24)
        Me.SavePassPanel.TabIndex = 7
        '
        'SavePassLabel
        '
        Me.SavePassLabel.AutoSize = True
        Me.SavePassLabel.BackColor = System.Drawing.Color.Transparent
        Me.SavePassLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SavePassLabel.ForeColor = System.Drawing.Color.White
        Me.SavePassLabel.Location = New System.Drawing.Point(0, 6)
        Me.SavePassLabel.Name = "SavePassLabel"
        Me.SavePassLabel.Size = New System.Drawing.Size(81, 13)
        Me.SavePassLabel.TabIndex = 5
        Me.SavePassLabel.Text = "Save Password"
        '
        'SavePassCheckbox
        '
        Me.SavePassCheckbox.BackgroundImage = CType(resources.GetObject("SavePassCheckbox.BackgroundImage"), System.Drawing.Image)
        Me.SavePassCheckbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SavePassCheckbox.Location = New System.Drawing.Point(92, 0)
        Me.SavePassCheckbox.Name = "SavePassCheckbox"
        Me.SavePassCheckbox.Size = New System.Drawing.Size(24, 25)
        Me.SavePassCheckbox.TabIndex = 0
        Me.SavePassCheckbox.TabStop = False
        '
        'PasswordPanel
        '
        Me.PasswordPanel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordPanel.BackgroundImage = CType(resources.GetObject("PasswordPanel.BackgroundImage"), System.Drawing.Image)
        Me.PasswordPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PasswordPanel.Controls.Add(Me.PasswordField)
        Me.PasswordPanel.Controls.Add(Me.PasswordLabel)
        Me.PasswordPanel.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.PasswordPanel.Location = New System.Drawing.Point(14, 90)
        Me.PasswordPanel.Name = "PasswordPanel"
        Me.PasswordPanel.Size = New System.Drawing.Size(308, 28)
        Me.PasswordPanel.TabIndex = 6
        '
        'PasswordField
        '
        Me.PasswordField.BackgroundImage = CType(resources.GetObject("PasswordField.BackgroundImage"), System.Drawing.Image)
        Me.PasswordField.Location = New System.Drawing.Point(4, 10)
        Me.PasswordField.Name = "PasswordField"
        Me.PasswordField.Size = New System.Drawing.Size(302, 16)
        Me.PasswordField.TabIndex = 0
        Me.PasswordField.TabStop = False
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.Color.White
        Me.PasswordLabel.Location = New System.Drawing.Point(0, -4)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(71, 16)
        Me.PasswordLabel.TabIndex = 4
        Me.PasswordLabel.Text = "Password:"
        '
        'UsernamePanel
        '
        Me.UsernamePanel.BackColor = System.Drawing.Color.Transparent
        Me.UsernamePanel.BackgroundImage = CType(resources.GetObject("UsernamePanel.BackgroundImage"), System.Drawing.Image)
        Me.UsernamePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UsernamePanel.Controls.Add(Me.UsernameFieldPB)
        Me.UsernamePanel.Controls.Add(Me.UsernameLabel)
        Me.UsernamePanel.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.UsernamePanel.Location = New System.Drawing.Point(14, 54)
        Me.UsernamePanel.Name = "UsernamePanel"
        Me.UsernamePanel.Size = New System.Drawing.Size(308, 28)
        Me.UsernamePanel.TabIndex = 5
        '
        'UsernameFieldPB
        '
        Me.UsernameFieldPB.BackgroundImage = CType(resources.GetObject("UsernameFieldPB.BackgroundImage"), System.Drawing.Image)
        Me.UsernameFieldPB.Location = New System.Drawing.Point(4, 10)
        Me.UsernameFieldPB.Name = "UsernameFieldPB"
        Me.UsernameFieldPB.Size = New System.Drawing.Size(302, 16)
        Me.UsernameFieldPB.TabIndex = 0
        Me.UsernameFieldPB.TabStop = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.White
        Me.UsernameLabel.Location = New System.Drawing.Point(0, -4)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(74, 16)
        Me.UsernameLabel.TabIndex = 4
        Me.UsernameLabel.Text = "Username:"
        '
        'LoginHeaderLabel
        '
        Me.LoginHeaderLabel.AutoSize = True
        Me.LoginHeaderLabel.BackColor = System.Drawing.Color.Transparent
        Me.LoginHeaderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginHeaderLabel.ForeColor = System.Drawing.Color.White
        Me.LoginHeaderLabel.Location = New System.Drawing.Point(25, 9)
        Me.LoginHeaderLabel.Name = "LoginHeaderLabel"
        Me.LoginHeaderLabel.Size = New System.Drawing.Size(48, 20)
        Me.LoginHeaderLabel.TabIndex = 3
        Me.LoginHeaderLabel.Text = "Login"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusTxtBox})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1125, 26)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statusTxtBox
        '
        Me.statusTxtBox.Name = "statusTxtBox"
        Me.statusTxtBox.Size = New System.Drawing.Size(51, 21)
        Me.statusTxtBox.Text = "Ready...."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SaveToolStripMenuItem, Me.RefreshBtn, Me.gridToggle, Me.AppSettings})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1125, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameToolStripMenuItem, Me.MenuToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.FileToolStripMenuItem.Text = "Open"
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BagItemToolStripMenuItem, Me.BagWindowToolStripMenuItem, Me.BankItemToolStripMenuItem, Me.BankWindowToolStripMenuItem, Me.CharacterWindowToolStripMenuItem, Me.ChatboxWindowToolStripMenuItem, Me.CraftedItemToolStripMenuItem, Me.CraftingIngredientToolStripMenuItem, Me.CraftingWindowToolStripMenuItem, Me.DraggableToolStripMenuItem, Me.EquipmentItemToolStripMenuItem, Me.EscapeMenuToolStripMenuItem, Me.EventDialogWindow1ResponseToolStripMenuItem, Me.EventDialogWindow2ResponseToolStripMenuItem, Me.EventDialogWindow3ResponseToolStripMenuItem, Me.EventDialogWindow4ResponseToolStripMenuItem, Me.FriendsWindowToolStripMenuItem, Me.HotbarWindowToolStripMenuItem, Me.InputBoxToolStripMenuItem1, Me.InventoryItemToolStripMenuItem, Me.InventoryWindowToolStripMenuItem, Me.ItemDescWindowToolStripMenuItem, Me.ItemDescWindowExpandedToolStripMenuItem, Me.MenuContainerToolStripMenuItem, Me.OptionsWindowToolStripMenuItem1, Me.PartyWindowToolStripMenuItem, Me.PlayerBoxToolStripMenuItem, Me.PlayerStatusIconToolStripMenuItem, Me.QuestOfferWindowToolStripMenuItem, Me.QuestWindowToolStripMenuItem, Me.ShopItemToolStripMenuItem, Me.ShopWindowToolStripMenuItem, Me.SpellMenuItem, Me.SpellDescWindowMenuItem, Me.SpellDescWindowExpandedMenuItem, Me.SpellsWindowMenuItem, Me.TargetBoxMenuItem, Me.TargetStatusIconMenuItem, Me.TheirTradeItemMenuItem, Me.TradeWindowMenuItem, Me.YourTradeItemMenuItem})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.GameToolStripMenuItem.Text = "game"
        '
        'BagItemToolStripMenuItem
        '
        Me.BagItemToolStripMenuItem.Name = "BagItemToolStripMenuItem"
        Me.BagItemToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.BagItemToolStripMenuItem.Text = "BagItem"
        '
        'BagWindowToolStripMenuItem
        '
        Me.BagWindowToolStripMenuItem.Name = "BagWindowToolStripMenuItem"
        Me.BagWindowToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.BagWindowToolStripMenuItem.Text = "BagWindow"
        '
        'BankItemToolStripMenuItem
        '
        Me.BankItemToolStripMenuItem.Name = "BankItemToolStripMenuItem"
        Me.BankItemToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.BankItemToolStripMenuItem.Text = "BankItem"
        '
        'BankWindowToolStripMenuItem
        '
        Me.BankWindowToolStripMenuItem.Name = "BankWindowToolStripMenuItem"
        Me.BankWindowToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.BankWindowToolStripMenuItem.Text = "BankWindow"
        '
        'CharacterWindowToolStripMenuItem
        '
        Me.CharacterWindowToolStripMenuItem.Name = "CharacterWindowToolStripMenuItem"
        Me.CharacterWindowToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.CharacterWindowToolStripMenuItem.Text = "CharacterWindow"
        '
        'ChatboxWindowToolStripMenuItem
        '
        Me.ChatboxWindowToolStripMenuItem.Name = "ChatboxWindowToolStripMenuItem"
        Me.ChatboxWindowToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.ChatboxWindowToolStripMenuItem.Text = "ChatboxWindow"
        '
        'CraftedItemToolStripMenuItem
        '
        Me.CraftedItemToolStripMenuItem.Name = "CraftedItemToolStripMenuItem"
        Me.CraftedItemToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.CraftedItemToolStripMenuItem.Text = "CraftedItem"
        '
        'CraftingIngredientToolStripMenuItem
        '
        Me.CraftingIngredientToolStripMenuItem.Name = "CraftingIngredientToolStripMenuItem"
        Me.CraftingIngredientToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.CraftingIngredientToolStripMenuItem.Text = "CraftingIngredient"
        '
        'CraftingWindowToolStripMenuItem
        '
        Me.CraftingWindowToolStripMenuItem.Name = "CraftingWindowToolStripMenuItem"
        Me.CraftingWindowToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.CraftingWindowToolStripMenuItem.Text = "CraftingWindow"
        '
        'DraggableToolStripMenuItem
        '
        Me.DraggableToolStripMenuItem.Name = "DraggableToolStripMenuItem"
        Me.DraggableToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.DraggableToolStripMenuItem.Text = "Draggable"
        '
        'EquipmentItemToolStripMenuItem
        '
        Me.EquipmentItemToolStripMenuItem.Name = "EquipmentItemToolStripMenuItem"
        Me.EquipmentItemToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.EquipmentItemToolStripMenuItem.Text = "EquipmentItem"
        '
        'EscapeMenuToolStripMenuItem
        '
        Me.EscapeMenuToolStripMenuItem.Name = "EscapeMenuToolStripMenuItem"
        Me.EscapeMenuToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.EscapeMenuToolStripMenuItem.Text = "EscapeMenu"
        '
        'EventDialogWindow1ResponseToolStripMenuItem
        '
        Me.EventDialogWindow1ResponseToolStripMenuItem.Name = "EventDialogWindow1ResponseToolStripMenuItem"
        Me.EventDialogWindow1ResponseToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.EventDialogWindow1ResponseToolStripMenuItem.Text = "EventDialogWindow_1Response"
        '
        'EventDialogWindow2ResponseToolStripMenuItem
        '
        Me.EventDialogWindow2ResponseToolStripMenuItem.Name = "EventDialogWindow2ResponseToolStripMenuItem"
        Me.EventDialogWindow2ResponseToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.EventDialogWindow2ResponseToolStripMenuItem.Text = "EventDialogWindow_2Responses"
        '
        'EventDialogWindow3ResponseToolStripMenuItem
        '
        Me.EventDialogWindow3ResponseToolStripMenuItem.Name = "EventDialogWindow3ResponseToolStripMenuItem"
        Me.EventDialogWindow3ResponseToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.EventDialogWindow3ResponseToolStripMenuItem.Text = "EventDialogWindow_3Responses"
        '
        'EventDialogWindow4ResponseToolStripMenuItem
        '
        Me.EventDialogWindow4ResponseToolStripMenuItem.Name = "EventDialogWindow4ResponseToolStripMenuItem"
        Me.EventDialogWindow4ResponseToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.EventDialogWindow4ResponseToolStripMenuItem.Text = "EventDialogWindow_4Responses"
        '
        'FriendsWindowToolStripMenuItem
        '
        Me.FriendsWindowToolStripMenuItem.Name = "FriendsWindowToolStripMenuItem"
        Me.FriendsWindowToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.FriendsWindowToolStripMenuItem.Text = "FriendsWindow"
        '
        'HotbarWindowToolStripMenuItem
        '
        Me.HotbarWindowToolStripMenuItem.Name = "HotbarWindowToolStripMenuItem"
        Me.HotbarWindowToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.HotbarWindowToolStripMenuItem.Text = "HotbarWindow"
        '
        'InputBoxToolStripMenuItem1
        '
        Me.InputBoxToolStripMenuItem1.Name = "InputBoxToolStripMenuItem1"
        Me.InputBoxToolStripMenuItem1.Size = New System.Drawing.Size(247, 22)
        Me.InputBoxToolStripMenuItem1.Text = "InputBox"
        '
        'InventoryItemToolStripMenuItem
        '
        Me.InventoryItemToolStripMenuItem.Name = "InventoryItemToolStripMenuItem"
        Me.InventoryItemToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.InventoryItemToolStripMenuItem.Text = "InventoryItem"
        '
        'InventoryWindowToolStripMenuItem
        '
        Me.InventoryWindowToolStripMenuItem.Name = "InventoryWindowToolStripMenuItem"
        Me.InventoryWindowToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.InventoryWindowToolStripMenuItem.Text = "InventoryWindow"
        '
        'ItemDescWindowToolStripMenuItem
        '
        Me.ItemDescWindowToolStripMenuItem.Name = "ItemDescWindowToolStripMenuItem"
        Me.ItemDescWindowToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.ItemDescWindowToolStripMenuItem.Text = "ItemDescWindow"
        '
        'ItemDescWindowExpandedToolStripMenuItem
        '
        Me.ItemDescWindowExpandedToolStripMenuItem.Name = "ItemDescWindowExpandedToolStripMenuItem"
        Me.ItemDescWindowExpandedToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.ItemDescWindowExpandedToolStripMenuItem.Text = "ItemDescWindowExpanded"
        '
        'MenuContainerToolStripMenuItem
        '
        Me.MenuContainerToolStripMenuItem.Name = "MenuContainerToolStripMenuItem"
        Me.MenuContainerToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.MenuContainerToolStripMenuItem.Text = "MenuContainer"
        '
        'OptionsWindowToolStripMenuItem1
        '
        Me.OptionsWindowToolStripMenuItem1.Name = "OptionsWindowToolStripMenuItem1"
        Me.OptionsWindowToolStripMenuItem1.Size = New System.Drawing.Size(247, 22)
        Me.OptionsWindowToolStripMenuItem1.Text = "OptionsWindow"
        '
        'PartyWindowToolStripMenuItem
        '
        Me.PartyWindowToolStripMenuItem.Name = "PartyWindowToolStripMenuItem"
        Me.PartyWindowToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.PartyWindowToolStripMenuItem.Text = "PartyWindow"
        '
        'PlayerBoxToolStripMenuItem
        '
        Me.PlayerBoxToolStripMenuItem.Name = "PlayerBoxToolStripMenuItem"
        Me.PlayerBoxToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.PlayerBoxToolStripMenuItem.Text = "PlayerBox"
        '
        'PlayerStatusIconToolStripMenuItem
        '
        Me.PlayerStatusIconToolStripMenuItem.Name = "PlayerStatusIconToolStripMenuItem"
        Me.PlayerStatusIconToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.PlayerStatusIconToolStripMenuItem.Text = "PlayerStatusIcon"
        '
        'QuestOfferWindowToolStripMenuItem
        '
        Me.QuestOfferWindowToolStripMenuItem.Name = "QuestOfferWindowToolStripMenuItem"
        Me.QuestOfferWindowToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.QuestOfferWindowToolStripMenuItem.Text = "QuestOfferWindow"
        '
        'QuestWindowToolStripMenuItem
        '
        Me.QuestWindowToolStripMenuItem.Name = "QuestWindowToolStripMenuItem"
        Me.QuestWindowToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.QuestWindowToolStripMenuItem.Text = "QuestWindow"
        '
        'ShopItemToolStripMenuItem
        '
        Me.ShopItemToolStripMenuItem.Name = "ShopItemToolStripMenuItem"
        Me.ShopItemToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.ShopItemToolStripMenuItem.Text = "ShopItem"
        '
        'ShopWindowToolStripMenuItem
        '
        Me.ShopWindowToolStripMenuItem.Name = "ShopWindowToolStripMenuItem"
        Me.ShopWindowToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.ShopWindowToolStripMenuItem.Text = "ShopWindow"
        '
        'SpellMenuItem
        '
        Me.SpellMenuItem.Name = "SpellMenuItem"
        Me.SpellMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.SpellMenuItem.Text = "Spell"
        '
        'SpellDescWindowMenuItem
        '
        Me.SpellDescWindowMenuItem.Name = "SpellDescWindowMenuItem"
        Me.SpellDescWindowMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.SpellDescWindowMenuItem.Text = "SpellDescWindow"
        '
        'SpellDescWindowExpandedMenuItem
        '
        Me.SpellDescWindowExpandedMenuItem.Name = "SpellDescWindowExpandedMenuItem"
        Me.SpellDescWindowExpandedMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.SpellDescWindowExpandedMenuItem.Text = "SpellDescWindowExpanded"
        '
        'SpellsWindowMenuItem
        '
        Me.SpellsWindowMenuItem.Name = "SpellsWindowMenuItem"
        Me.SpellsWindowMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.SpellsWindowMenuItem.Text = "SpellsWindow"
        '
        'TargetBoxMenuItem
        '
        Me.TargetBoxMenuItem.Name = "TargetBoxMenuItem"
        Me.TargetBoxMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.TargetBoxMenuItem.Text = "TargetBox"
        '
        'TargetStatusIconMenuItem
        '
        Me.TargetStatusIconMenuItem.Name = "TargetStatusIconMenuItem"
        Me.TargetStatusIconMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.TargetStatusIconMenuItem.Text = "TargetStatusIcon"
        '
        'TheirTradeItemMenuItem
        '
        Me.TheirTradeItemMenuItem.Name = "TheirTradeItemMenuItem"
        Me.TheirTradeItemMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.TheirTradeItemMenuItem.Text = "TheirTradeItem"
        '
        'TradeWindowMenuItem
        '
        Me.TradeWindowMenuItem.Name = "TradeWindowMenuItem"
        Me.TradeWindowMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.TradeWindowMenuItem.Text = "TradeWindow"
        '
        'YourTradeItemMenuItem
        '
        Me.YourTradeItemMenuItem.Name = "YourTradeItemMenuItem"
        Me.YourTradeItemMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.YourTradeItemMenuItem.Text = "YourTradeItem"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CharacterCreationWindowToolStripMenuItem, Me.CharacterSelectionWindowToolStripMenuItem, Me.CreditsWindowToolStripMenuItem, Me.ForgotPasswordWindowToolStripMenuItem, Me.InputBoxToolStripMenuItem, Me.LoginWindowToolStripMenuItem, Me.LogoToolStripMenuItem, Me.MenuWindowToolStripMenuItem, Me.OptionsWindowToolStripMenuItem, Me.RegistrationWindowToolStripMenuItem, Me.ResetPasswordWindowToolStripMenuItem, Me.ServerStatusAreaToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.MenuToolStripMenuItem.Text = "menu"
        '
        'CharacterCreationWindowToolStripMenuItem
        '
        Me.CharacterCreationWindowToolStripMenuItem.Name = "CharacterCreationWindowToolStripMenuItem"
        Me.CharacterCreationWindowToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.CharacterCreationWindowToolStripMenuItem.Text = "CharacterCreationWindow"
        '
        'CharacterSelectionWindowToolStripMenuItem
        '
        Me.CharacterSelectionWindowToolStripMenuItem.Name = "CharacterSelectionWindowToolStripMenuItem"
        Me.CharacterSelectionWindowToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.CharacterSelectionWindowToolStripMenuItem.Text = "CharacterSelectionWindow"
        '
        'CreditsWindowToolStripMenuItem
        '
        Me.CreditsWindowToolStripMenuItem.Name = "CreditsWindowToolStripMenuItem"
        Me.CreditsWindowToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.CreditsWindowToolStripMenuItem.Text = "CreditsWindow"
        '
        'ForgotPasswordWindowToolStripMenuItem
        '
        Me.ForgotPasswordWindowToolStripMenuItem.Name = "ForgotPasswordWindowToolStripMenuItem"
        Me.ForgotPasswordWindowToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.ForgotPasswordWindowToolStripMenuItem.Text = "ForgotPasswordWindow"
        '
        'InputBoxToolStripMenuItem
        '
        Me.InputBoxToolStripMenuItem.Name = "InputBoxToolStripMenuItem"
        Me.InputBoxToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.InputBoxToolStripMenuItem.Text = "InputBox"
        '
        'LoginWindowToolStripMenuItem
        '
        Me.LoginWindowToolStripMenuItem.Name = "LoginWindowToolStripMenuItem"
        Me.LoginWindowToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.LoginWindowToolStripMenuItem.Text = "LoginWindow"
        '
        'LogoToolStripMenuItem
        '
        Me.LogoToolStripMenuItem.Name = "LogoToolStripMenuItem"
        Me.LogoToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.LogoToolStripMenuItem.Text = "Logo"
        '
        'MenuWindowToolStripMenuItem
        '
        Me.MenuWindowToolStripMenuItem.Name = "MenuWindowToolStripMenuItem"
        Me.MenuWindowToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.MenuWindowToolStripMenuItem.Text = "MenuWindow"
        '
        'OptionsWindowToolStripMenuItem
        '
        Me.OptionsWindowToolStripMenuItem.Name = "OptionsWindowToolStripMenuItem"
        Me.OptionsWindowToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.OptionsWindowToolStripMenuItem.Text = "OptionsWindow"
        '
        'RegistrationWindowToolStripMenuItem
        '
        Me.RegistrationWindowToolStripMenuItem.Name = "RegistrationWindowToolStripMenuItem"
        Me.RegistrationWindowToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.RegistrationWindowToolStripMenuItem.Text = "RegistrationWindow"
        '
        'ResetPasswordWindowToolStripMenuItem
        '
        Me.ResetPasswordWindowToolStripMenuItem.Name = "ResetPasswordWindowToolStripMenuItem"
        Me.ResetPasswordWindowToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.ResetPasswordWindowToolStripMenuItem.Text = "ResetPasswordWindow"
        '
        'ServerStatusAreaToolStripMenuItem
        '
        Me.ServerStatusAreaToolStripMenuItem.Name = "ServerStatusAreaToolStripMenuItem"
        Me.ServerStatusAreaToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.ServerStatusAreaToolStripMenuItem.Text = "ServerStatusArea"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.SaveToolStripMenuItem.Text = "Save"
        Me.SaveToolStripMenuItem.Visible = False
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.RefreshBtn.Image = CType(resources.GetObject("RefreshBtn.Image"), System.Drawing.Image)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(28, 20)
        Me.RefreshBtn.Visible = False
        '
        'gridToggle
        '
        Me.gridToggle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.gridToggle.Image = CType(resources.GetObject("gridToggle.Image"), System.Drawing.Image)
        Me.gridToggle.Name = "gridToggle"
        Me.gridToggle.Size = New System.Drawing.Size(28, 20)
        Me.gridToggle.Visible = False
        '
        'AppSettings
        '
        Me.AppSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AppSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AppSettings.Image = CType(resources.GetObject("AppSettings.Image"), System.Drawing.Image)
        Me.AppSettings.Name = "AppSettings"
        Me.AppSettings.Size = New System.Drawing.Size(28, 20)
        '
        'MainSpellDescWindowPanel
        '
        Me.MainSpellDescWindowPanel.BackgroundImage = CType(resources.GetObject("MainSpellDescWindowPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainSpellDescWindowPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainSpellDescWindowPanel.Controls.Add(Me.SpellDescSpellType)
        Me.MainSpellDescWindowPanel.Controls.Add(Me.SpellDescSpellName)
        Me.MainSpellDescWindowPanel.Controls.Add(Me.SpellDescSpellIcon)
        Me.MainSpellDescWindowPanel.Controls.Add(Me.SpellDescSpellDesc)
        Me.MainSpellDescWindowPanel.Location = New System.Drawing.Point(1283, 1039)
        Me.MainSpellDescWindowPanel.Name = "MainSpellDescWindowPanel"
        Me.MainSpellDescWindowPanel.Size = New System.Drawing.Size(185, 244)
        Me.MainSpellDescWindowPanel.TabIndex = 52
        Me.MainSpellDescWindowPanel.Visible = False
        '
        'SpellDescSpellDescText
        '
        Me.SpellDescSpellDescText.AutoSize = True
        Me.SpellDescSpellDescText.BackColor = System.Drawing.Color.Transparent
        Me.SpellDescSpellDescText.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpellDescSpellDescText.ForeColor = System.Drawing.Color.White
        Me.SpellDescSpellDescText.Location = New System.Drawing.Point(88, 0)
        Me.SpellDescSpellDescText.Name = "SpellDescSpellDescText"
        Me.SpellDescSpellDescText.Size = New System.Drawing.Size(172, 17)
        Me.SpellDescSpellDescText.TabIndex = 26
        Me.SpellDescSpellDescText.Text = "Rains down arrows in an area."
        '
        'SpellDescSpellType
        '
        Me.SpellDescSpellType.AutoSize = True
        Me.SpellDescSpellType.BackColor = System.Drawing.Color.Transparent
        Me.SpellDescSpellType.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpellDescSpellType.ForeColor = System.Drawing.Color.White
        Me.SpellDescSpellType.Location = New System.Drawing.Point(4, 92)
        Me.SpellDescSpellType.Name = "SpellDescSpellType"
        Me.SpellDescSpellType.Size = New System.Drawing.Size(31, 17)
        Me.SpellDescSpellType.TabIndex = 24
        Me.SpellDescSpellType.Text = "AOE"
        '
        'SpellDescSpellName
        '
        Me.SpellDescSpellName.AutoSize = True
        Me.SpellDescSpellName.BackColor = System.Drawing.Color.Transparent
        Me.SpellDescSpellName.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpellDescSpellName.ForeColor = System.Drawing.Color.White
        Me.SpellDescSpellName.Location = New System.Drawing.Point(4, 8)
        Me.SpellDescSpellName.Name = "SpellDescSpellName"
        Me.SpellDescSpellName.Size = New System.Drawing.Size(90, 20)
        Me.SpellDescSpellName.TabIndex = 23
        Me.SpellDescSpellName.Text = "Rain Arrows"
        '
        'SpellDescSpellIcon
        '
        Me.SpellDescSpellIcon.BackColor = System.Drawing.Color.Transparent
        Me.SpellDescSpellIcon.BackgroundImage = CType(resources.GetObject("SpellDescSpellIcon.BackgroundImage"), System.Drawing.Image)
        Me.SpellDescSpellIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpellDescSpellIcon.Location = New System.Drawing.Point(68, 38)
        Me.SpellDescSpellIcon.Name = "SpellDescSpellIcon"
        Me.SpellDescSpellIcon.Size = New System.Drawing.Size(48, 48)
        Me.SpellDescSpellIcon.TabIndex = 19
        Me.SpellDescSpellIcon.TabStop = False
        '
        'SpellDescSpellDesc
        '
        Me.SpellDescSpellDesc.BackColor = System.Drawing.Color.Transparent
        Me.SpellDescSpellDesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SpellDescSpellDesc.Controls.Add(Me.SpellDescSpellDescText)
        Me.SpellDescSpellDesc.Location = New System.Drawing.Point(4, 120)
        Me.SpellDescSpellDesc.Name = "SpellDescSpellDesc"
        Me.SpellDescSpellDesc.Size = New System.Drawing.Size(177, 130)
        Me.SpellDescSpellDesc.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 661)
        Me.Controls.Add(Me.mainSplitContainer)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "IGE"
        Me.mainSplitContainer.Panel1.ResumeLayout(False)
        Me.mainSplitContainer.Panel2.ResumeLayout(False)
        Me.mainSplitContainer.Panel2.PerformLayout
        CType(Me.mainSplitContainer, System.ComponentModel.ISupportInitialize).EndInit
        Me.mainSplitContainer.ResumeLayout(False)
        Me.toolSplitContainer.Panel1.ResumeLayout(False)
        Me.toolSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.toolSplitContainer, System.ComponentModel.ISupportInitialize).EndInit
        Me.toolSplitContainer.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.MainSpellPanel.ResumeLayout(False)
        Me.MainSpellPanel.PerformLayout
        CType(Me.SpellIcon, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainShopWindowPanel.ResumeLayout(False)
        Me.MainShopWindowPanel.PerformLayout
        CType(Me.ShopWindowCloseButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainShopItemPanel.ResumeLayout(False)
        CType(Me.ShopItemIcon, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainQuestsWindowPanel.ResumeLayout(False)
        Me.MainQuestsWindowPanel.PerformLayout
        Me.QuestsWindowQuestList.ResumeLayout(False)
        Me.QuestsWindowQuestList.PerformLayout
        CType(Me.QuestsWindowAbandonQuestButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.QuestsWindowQuestDescription.ResumeLayout(False)
        Me.QuestsWindowQuestDescription.PerformLayout
        CType(Me.QuestsWindowBackButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.QuestsWindowCloseButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainQuestOfferWindowPanel.ResumeLayout(False)
        Me.MainQuestOfferWindowPanel.PerformLayout
        CType(Me.QuestOfferCloseButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.QuestOfferInnerPanel.ResumeLayout(False)
        Me.QuestOfferInnerPanel.PerformLayout
        Me.QuestOfferArea.ResumeLayout(False)
        Me.QuestOfferArea.PerformLayout
        CType(Me.QuestOfferDeclineButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.QuestOfferAcceptButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainPlayerStatusIconPanel.ResumeLayout(False)
        Me.MainPlayerStatusIconPanel.PerformLayout
        CType(Me.StatusIcon, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainPlayerBoxPanel.ResumeLayout(False)
        CType(Me.PlayerBoxFriendButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PlayerBoxPartyButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PlayerBoxTradeButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.EntityInfoPanel.ResumeLayout(False)
        Me.EntityInfoPanel.PerformLayout
        CType(Me.EXPBar, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.EXPBackground, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MPBar, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MPBackground, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ShieldBar, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.HPBar, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.HPBarBackground, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.EntityGraphicContainer, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainPartyWindowPanel.ResumeLayout(False)
        Me.MainPartyWindowPanel.PerformLayout
        Me.PartyInnerPanel.ResumeLayout(False)
        Me.PartyInnerPanel.PerformLayout
        CType(Me.KickButton3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.KickButton2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.KickButton1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LeavePartyButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.ManaBarContainer3.ResumeLayout(False)
        CType(Me.ManaBar3, System.ComponentModel.ISupportInitialize).EndInit
        Me.HealthBarContainer3.ResumeLayout(False)
        CType(Me.HealthBar3, System.ComponentModel.ISupportInitialize).EndInit
        Me.ManaBarContainer2.ResumeLayout(False)
        CType(Me.ManaBar2, System.ComponentModel.ISupportInitialize).EndInit
        Me.HealthBarContainer2.ResumeLayout(False)
        CType(Me.HealthBar2, System.ComponentModel.ISupportInitialize).EndInit
        Me.ManaBarContainer1.ResumeLayout(False)
        CType(Me.ManaBar1, System.ComponentModel.ISupportInitialize).EndInit
        Me.HealthBarContainer1.ResumeLayout(False)
        CType(Me.HealthBar1, System.ComponentModel.ISupportInitialize).EndInit
        Me.ManaBarContainer0.ResumeLayout(False)
        CType(Me.ManaBar0, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LeaderIcon, System.ComponentModel.ISupportInitialize).EndInit
        Me.HealthBarContainer0.ResumeLayout(False)
        CType(Me.HealthBar0, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PartyCloseButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainMenuContainerPanel.ResumeLayout(False)
        Me.MenuContainer.ResumeLayout(False)
        CType(Me.MenuButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.PartyContainer.ResumeLayout(False)
        CType(Me.PartyButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.FriendsContainer.ResumeLayout(False)
        CType(Me.FriendsButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.QuestsContainer.ResumeLayout(False)
        CType(Me.QuestsButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.MenuCharacterContainer.ResumeLayout(False)
        CType(Me.CharacterButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.SpellsContainer.ResumeLayout(False)
        CType(Me.SpellsButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.InventoryContainer.ResumeLayout(False)
        CType(Me.InventoryButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainItemDescWindowExpandedPanel.ResumeLayout(False)
        Me.MainItemDescWindowExpandedPanel.PerformLayout
        Me.ItemDescExpandedItemStats.ResumeLayout(False)
        Me.ItemDescExpandedItemStats.PerformLayout
        CType(Me.ItemDescExpandedItemIcon, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainItemDescWindowPanel.ResumeLayout(False)
        Me.MainItemDescWindowPanel.PerformLayout
        CType(Me.ItemDescItemIcon, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainInventoryWindowPanel.ResumeLayout(False)
        Me.MainInventoryWindowPanel.PerformLayout
        CType(Me.InventoryWindowCloseButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainInventoryItemPanel.ResumeLayout(False)
        Me.MainInventoryItemPanel.PerformLayout
        CType(Me.InventoryItemIcon, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainGameInputBoxPanel.ResumeLayout(False)
        Me.MainGameInputBoxPanel.PerformLayout
        Me.GameInputBoxInnerPanel.ResumeLayout(False)
        Me.GameInputBoxInnerPanel.PerformLayout
        CType(Me.GameInputOkayButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.GameInputBoxTextBox.ResumeLayout(False)
        CType(Me.GameInputBoxTextboxText, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GameInputNoButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GameInputYesButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GameInputBoxCloseButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainHotbarWindowPanel.ResumeLayout(False)
        Me.HotbarContainer9.ResumeLayout(False)
        Me.HotbarContainer9.PerformLayout
        CType(Me.HotbarIcon9, System.ComponentModel.ISupportInitialize).EndInit
        Me.HotbarContainer8.ResumeLayout(False)
        Me.HotbarContainer8.PerformLayout
        CType(Me.HotbarIcon8, System.ComponentModel.ISupportInitialize).EndInit
        Me.HotbarContainer7.ResumeLayout(False)
        Me.HotbarContainer7.PerformLayout
        CType(Me.HotbarIcon7, System.ComponentModel.ISupportInitialize).EndInit
        Me.HotbarContainer6.ResumeLayout(False)
        Me.HotbarContainer6.PerformLayout
        CType(Me.HotbarIcon6, System.ComponentModel.ISupportInitialize).EndInit
        Me.HotbarContainer5.ResumeLayout(False)
        Me.HotbarContainer5.PerformLayout
        CType(Me.HotbarIcon5, System.ComponentModel.ISupportInitialize).EndInit
        Me.HotbarContainer4.ResumeLayout(False)
        Me.HotbarContainer4.PerformLayout
        CType(Me.HotbarIcon4, System.ComponentModel.ISupportInitialize).EndInit
        Me.HotbarContainer3.ResumeLayout(False)
        Me.HotbarContainer3.PerformLayout
        CType(Me.HotbarIcon3, System.ComponentModel.ISupportInitialize).EndInit
        Me.HotbarContainer2.ResumeLayout(False)
        Me.HotbarContainer2.PerformLayout
        CType(Me.HotbarIcon2, System.ComponentModel.ISupportInitialize).EndInit
        Me.HotbarContainer1.ResumeLayout(False)
        Me.HotbarContainer1.PerformLayout
        CType(Me.HotbarIcon1, System.ComponentModel.ISupportInitialize).EndInit
        Me.HotbarContainer0.ResumeLayout(False)
        Me.HotbarContainer0.PerformLayout
        CType(Me.HotbarIcon0, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainFriendsWindowPanel.ResumeLayout(False)
        Me.MainFriendsWindowPanel.PerformLayout
        CType(Me.AddFriendPopupButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.FriendsWindowCloseButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainEventDialogWindow4ResponsePanel.ResumeLayout(False)
        CType(Me.Dialog4Response4Button, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Dialog4Response3Button, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Dialog4Response2Button, System.ComponentModel.ISupportInitialize).EndInit
        Me.Dialog4EventDialogArea.ResumeLayout(False)
        Me.Dialog4EventDialogAreaInnerPanel.ResumeLayout(False)
        Me.Dialog4EventDialogAreaInnerPanel.PerformLayout
        CType(Me.Dialog4Response1Button, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainEventDialogWindow3ResponsePanel.ResumeLayout(False)
        CType(Me.Dialog3Response3Button, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Dialog3Response2Button, System.ComponentModel.ISupportInitialize).EndInit
        Me.Dialog3EventDialogArea.ResumeLayout(False)
        Me.Dialog3EventDialogAreaInnerPanel.ResumeLayout(False)
        Me.Dialog3EventDialogAreaInnerPanel.PerformLayout
        CType(Me.Dialog3Response1Button, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainEventDialogWindow2ResponsePanel.ResumeLayout(False)
        CType(Me.Dialog2Response2Button, System.ComponentModel.ISupportInitialize).EndInit
        Me.Dialog2EventDialogArea.ResumeLayout(False)
        Me.Dialog2EventDialogAreaInnerPanel.ResumeLayout(False)
        Me.Dialog2EventDialogAreaInnerPanel.PerformLayout
        CType(Me.Dialog2Response1Button, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainEventDialogWindow1ResponsePanel.ResumeLayout(False)
        Me.Dialog1EventDialogArea.ResumeLayout(False)
        Me.Dialog1EventDialogAreaInnerPanel.ResumeLayout(False)
        Me.Dialog1EventDialogAreaInnerPanel.PerformLayout
        CType(Me.Dialog1Response1Button, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainEscapeMenuPanel.ResumeLayout(False)
        Me.MainEscapeMenuPanel.PerformLayout
        CType(Me.EscapeMenuLogoutButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.EscapeMenuCloseButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.EscapeMenuExitToDesktopButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.EscapeMenuCharacterSelectButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.EscapeMenuOptionsButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainEquipmentItemPanel.ResumeLayout(False)
        CType(Me.EquipmentIcon, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainCraftingWindowPanel.ResumeLayout(False)
        Me.MainCraftingWindowPanel.PerformLayout
        CType(Me.CraftButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CraftingWindowCloseButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainCraftingIngredientPanel.ResumeLayout(False)
        Me.MainCraftingIngredientPanel.PerformLayout
        CType(Me.IngredientItemIcon, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainCraftedItemPanel.ResumeLayout(False)
        Me.MainCraftedItemPanel.PerformLayout
        CType(Me.CraftedItemIcon, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainChatboxWindowPanel.ResumeLayout(False)
        Me.MainChatboxWindowPanel.PerformLayout
        CType(Me.ChatboxInputField, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainCharacterWindowPanel.ResumeLayout(False)
        Me.MainCharacterWindowPanel.PerformLayout
        Me.CharacterWindowInnerPanel.ResumeLayout(False)
        Me.CharacterWindowInnerPanel.PerformLayout
        Me.EquipmentItem4.ResumeLayout(False)
        CType(Me.Equipment4Icon, System.ComponentModel.ISupportInitialize).EndInit
        Me.EquipmentItem3.ResumeLayout(False)
        CType(Me.Equipment3Icon, System.ComponentModel.ISupportInitialize).EndInit
        Me.EquipmentItem2.ResumeLayout(False)
        CType(Me.Equipment2Icon, System.ComponentModel.ISupportInitialize).EndInit
        Me.EquipmentItem1.ResumeLayout(False)
        CType(Me.Equipment1Icon, System.ComponentModel.ISupportInitialize).EndInit
        Me.EquipmentItem0.ResumeLayout(False)
        CType(Me.Equipment0Icon, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.IncreaseMagicResistButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.IncreaseAbilityPowerButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.IncreaseSpeedButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.IncreaseDefenseButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.IncreaseAttackButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CharacterWindowCharacterContainer, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CharacterWindowCloseButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainBankWindowPanel.ResumeLayout(False)
        Me.MainBankWindowPanel.PerformLayout
        CType(Me.BankWindowCloseButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainBankItemPanel.ResumeLayout(False)
        Me.MainBankItemPanel.PerformLayout
        CType(Me.BankItemIcon, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainBagWindowPanel.ResumeLayout(False)
        Me.MainBagWindowPanel.PerformLayout
        CType(Me.BagWindowCloseButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainBagItemPanel.ResumeLayout(False)
        Me.MainBagItemPanel.PerformLayout
        CType(Me.BagItemIcon, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainControlPanelsWindow.ResumeLayout(False)
        Me.MainControlPanelsWindow.PerformLayout
        CType(Me.RestoreControlsButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ExitControlsButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CancelControlsButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainServerStatusAreaPanel.ResumeLayout(False)
        Me.MainServerStatusAreaPanel.PerformLayout
        Me.MainResetPasswordWindowPanel.ResumeLayout(False)
        Me.MainResetPasswordWindowPanel.PerformLayout
        Me.ResetPassword2Panel.ResumeLayout(False)
        Me.ResetPassword2Panel.PerformLayout
        CType(Me.ResetPassword2Field, System.ComponentModel.ISupportInitialize).EndInit
        Me.ResetPassword1Panel.ResumeLayout(False)
        Me.ResetPassword1Panel.PerformLayout
        CType(Me.ResetPassword1Field, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ResetBackButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ResetSubmitButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.CodePanel.ResumeLayout(False)
        Me.CodePanel.PerformLayout
        CType(Me.CodeField, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainRegistrationWindowPanel.ResumeLayout(False)
        Me.MainRegistrationWindowPanel.PerformLayout
        Me.Password2Panel.ResumeLayout(False)
        Me.Password2Panel.PerformLayout
        CType(Me.Password2Field, System.ComponentModel.ISupportInitialize).EndInit
        Me.Password1Panel.ResumeLayout(False)
        Me.Password1Panel.PerformLayout
        CType(Me.Password1Field, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RegistrationBackButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.RegistrationUsernamePanel.ResumeLayout(False)
        Me.RegistrationUsernamePanel.PerformLayout
        CType(Me.RegistrationUsernameField, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RegistrationRegisterButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.EmailPanel.ResumeLayout(False)
        Me.EmailPanel.PerformLayout
        CType(Me.EmailField, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainOptionsWindowPanel.ResumeLayout(False)
        Me.MainOptionsWindowPanel.PerformLayout
        Me.OptionsContainer.ResumeLayout(False)
        Me.OptionsContainer.PerformLayout
        CType(Me.OptionsCancelButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.OptionsApplyButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.MusicSlider.ResumeLayout(False)
        CType(Me.MusicSliderBar, System.ComponentModel.ISupportInitialize).EndInit
        Me.SoundSlider.ResumeLayout(False)
        CType(Me.SoundSliderBar, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.KeybindingsButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.AutocloseWindowsCheckboxPanel.ResumeLayout(False)
        Me.AutocloseWindowsCheckboxPanel.PerformLayout
        CType(Me.AutocloseWindowsCheckboxCheckbox, System.ComponentModel.ISupportInitialize).EndInit
        Me.FullscreenCheckboxPanel.ResumeLayout(False)
        Me.FullscreenCheckboxPanel.PerformLayout
        CType(Me.FullscreenCheckboxCheckbox, System.ComponentModel.ISupportInitialize).EndInit
        Me.FPSPanel.ResumeLayout(False)
        Me.FPSPanel.PerformLayout
        CType(Me.FPSCombobox, System.ComponentModel.ISupportInitialize).EndInit
        Me.ResolutionPanel.ResumeLayout(False)
        Me.ResolutionPanel.PerformLayout
        CType(Me.ResolutionCombobox, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainMenuWindowPanel.ResumeLayout(False)
        Me.MainMenuWindowPanel.PerformLayout
        CType(Me.MainMenuOptionsButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MainMenuExitButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MainMenuCreditsButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MainMenuRegisterButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MainMenuLoginButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MainLogoPanel, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainInputBoxPanel.ResumeLayout(False)
        Me.MainInputBoxPanel.PerformLayout
        Me.InputBoxInnerPanel.ResumeLayout(False)
        Me.InputBoxInnerPanel.PerformLayout
        CType(Me.OkayButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.InputBoxTextBox.ResumeLayout(False)
        CType(Me.InputBoxTextboxText, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.NoButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.YesButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.InputBoxCloseButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainForgotPasswordWindowPanel.ResumeLayout(False)
        Me.MainForgotPasswordWindowPanel.PerformLayout
        CType(Me.ForgotPasswordBackButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ForgotPasswordSubmitButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.ForgotPasswordInputPanel.ResumeLayout(False)
        Me.ForgotPasswordInputPanel.PerformLayout
        CType(Me.ForgotPasswordInputField, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainCreditsPanel.ResumeLayout(False)
        Me.MainCreditsPanel.PerformLayout
        CType(Me.CreditsBackButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.CreditsScrollview.ResumeLayout(False)
        Me.CreditsInnerPanel.ResumeLayout(False)
        Me.CreditsInnerPanel.PerformLayout
        Me.MainCharSelectionPanel.ResumeLayout(False)
        Me.MainCharSelectionPanel.PerformLayout
        CType(Me.LogoutButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.NewButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DeleteButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PlayButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.SelectCharCharacterContainer.ResumeLayout(False)
        CType(Me.PreviousCharacterButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.NextCharacterButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SelectCharCharacterPortrait, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainCharacterCreationPanel.ResumeLayout(False)
        Me.MainCharacterCreationPanel.PerformLayout
        Me.GenderPanel.ResumeLayout(False)
        Me.GenderPanel.PerformLayout
        Me.FemaleCheckboxPanel.ResumeLayout(False)
        Me.FemaleCheckboxPanel.PerformLayout
        CType(Me.FemaleCheckbox, System.ComponentModel.ISupportInitialize).EndInit
        Me.MaleCheckboxPanel.ResumeLayout(False)
        Me.MaleCheckboxPanel.PerformLayout
        CType(Me.MaleCheckbox, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CharCreateBackButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CreateButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.CharacterContainer.ResumeLayout(False)
        CType(Me.PreviousSpriteButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.NextSpriteButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CharacterPortait, System.ComponentModel.ISupportInitialize).EndInit
        Me.ClassPanel.ResumeLayout(False)
        Me.ClassPanel.PerformLayout
        CType(Me.ClassCombobox, System.ComponentModel.ISupportInitialize).EndInit
        Me.CharacterNamePanel.ResumeLayout(False)
        Me.CharacterNamePanel.PerformLayout
        CType(Me.CharacterNameField, System.ComponentModel.ISupportInitialize).EndInit
        Me.MainLoginWindowPanel.ResumeLayout(False)
        Me.MainLoginWindowPanel.PerformLayout
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LoginButton, System.ComponentModel.ISupportInitialize).EndInit
        Me.SavePassPanel.ResumeLayout(False)
        Me.SavePassPanel.PerformLayout
        CType(Me.SavePassCheckbox, System.ComponentModel.ISupportInitialize).EndInit
        Me.PasswordPanel.ResumeLayout(False)
        Me.PasswordPanel.PerformLayout
        CType(Me.PasswordField, System.ComponentModel.ISupportInitialize).EndInit
        Me.UsernamePanel.ResumeLayout(False)
        Me.UsernamePanel.PerformLayout
        CType(Me.UsernameFieldPB, System.ComponentModel.ISupportInitialize).EndInit
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout
        Me.MainSpellDescWindowPanel.ResumeLayout(False)
        Me.MainSpellDescWindowPanel.PerformLayout
        CType(Me.SpellDescSpellIcon, System.ComponentModel.ISupportInitialize).EndInit
        Me.SpellDescSpellDesc.ResumeLayout(False)
        Me.SpellDescSpellDesc.PerformLayout
        Me.ResumeLayout(False)
        Me.PerformLayout

    End Sub

    Friend WithEvents mainSplitContainer As SplitContainer
    Friend WithEvents toolSplitContainer As SplitContainer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainLoginWindowPanel As Panel
    Friend WithEvents LoginHeaderLabel As Label
    Friend WithEvents UsernamePanel As Panel
    Friend WithEvents UsernameFieldPB As PictureBox
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents PasswordPanel As Panel
    Friend WithEvents PasswordField As PictureBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents LoginButton As PictureBox
    Friend WithEvents SavePassPanel As Panel
    Friend WithEvents SavePassLabel As Label
    Friend WithEvents SavePassCheckbox As PictureBox
    Friend WithEvents BackButton As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BagItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BagWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BankItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CharacterWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChatboxWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CraftedItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CraftingIngredientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CraftingWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DraggableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EquipmentItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EscapeMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EventDialogWindow1ResponseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EventDialogWindow2ResponseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EventDialogWindow3ResponseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EventDialogWindow4ResponseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FriendsWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HotbarWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InputBoxToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InventoryItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemDescWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemDescWindowExpandedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuContainerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsWindowToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PartyWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlayerBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlayerStatusIconToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuestOfferWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuestWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShopItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShopWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpellMenuItem As ToolStripMenuItem
    Friend WithEvents SpellDescWindowMenuItem As ToolStripMenuItem
    Friend WithEvents SpellDescWindowExpandedMenuItem As ToolStripMenuItem
    Friend WithEvents SpellsWindowMenuItem As ToolStripMenuItem
    Friend WithEvents TargetBoxMenuItem As ToolStripMenuItem
    Friend WithEvents TargetStatusIconMenuItem As ToolStripMenuItem
    Friend WithEvents TheirTradeItemMenuItem As ToolStripMenuItem
    Friend WithEvents TradeWindowMenuItem As ToolStripMenuItem
    Friend WithEvents YourTradeItemMenuItem As ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CharacterCreationWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CharacterSelectionWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreditsWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ForgotPasswordWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InputBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrationWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetPasswordWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServerStatusAreaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JTokenTreeUserControl1 As ZTn.Json.JsonTreeView.Controls.JTokenTreeUserControl
    Friend WithEvents jsonValue As RichTextBox
    Friend WithEvents jsonTypeCombo As ComboBox
    Friend WithEvents jsonType As TextBox
    Friend WithEvents fullJson As RichTextBox
    Friend WithEvents updateBtn As Button
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainCharacterCreationPanel As Panel
    Friend WithEvents GenderPanel As Panel
    Friend WithEvents FemaleCheckboxPanel As Panel
    Friend WithEvents FemaleCheckboxLabel As Label
    Friend WithEvents FemaleCheckbox As PictureBox
    Friend WithEvents MaleCheckboxPanel As Panel
    Friend WithEvents MaleCheckboxLabel As Label
    Friend WithEvents MaleCheckbox As PictureBox
    Friend WithEvents GenderLabel As Label
    Friend WithEvents Hint2Label As Label
    Friend WithEvents HintLabel As Label
    Friend WithEvents CharCreateBackButton As PictureBox
    Friend WithEvents CreateButton As PictureBox
    Friend WithEvents CharacterContainer As Panel
    Friend WithEvents PreviousSpriteButton As PictureBox
    Friend WithEvents NextSpriteButton As PictureBox
    Friend WithEvents CharacterPortait As PictureBox
    Friend WithEvents ClassPanel As Panel
    Friend WithEvents ClassCombobox As PictureBox
    Friend WithEvents ClassLabel As Label
    Friend WithEvents CharacterNamePanel As Panel
    Friend WithEvents CharacterNameField As PictureBox
    Friend WithEvents CharacterNameLabel As Label
    Friend WithEvents CharacterCreationHeader As Label
    Friend WithEvents RefreshBtn As ToolStripMenuItem
    Friend WithEvents gridToggle As ToolStripMenuItem
    Friend WithEvents MainCharSelectionPanel As Panel
    Friend WithEvents LogoutButton As PictureBox
    Friend WithEvents NewButton As PictureBox
    Friend WithEvents CharacterInfoLabel As Label
    Friend WithEvents SelectCharCharacterNameLabel As Label
    Friend WithEvents DeleteButton As PictureBox
    Friend WithEvents PlayButton As PictureBox
    Friend WithEvents SelectCharCharacterContainer As Panel
    Friend WithEvents PreviousCharacterButton As PictureBox
    Friend WithEvents NextCharacterButton As PictureBox
    Friend WithEvents SelectCharCharacterPortrait As PictureBox
    Friend WithEvents CharacterSelectionHeader As Label
    Friend WithEvents MainCreditsPanel As Panel
    Friend WithEvents CreditsBackButton As PictureBox
    Friend WithEvents CreditsHeader As Label
    Friend WithEvents CreditsScrollview As Panel
    Friend WithEvents CreditsInnerPanel As Panel
    Friend WithEvents CreditsLabel As Label
    Friend WithEvents MainForgotPasswordWindowPanel As Panel
    Friend WithEvents ForgotPasswordHintLabel As Label
    Friend WithEvents ForgotPasswordBackButton As PictureBox
    Friend WithEvents ForgotPasswordSubmitButton As PictureBox
    Friend WithEvents ForgotPasswordInputPanel As Panel
    Friend WithEvents ForgotPasswordInputField As PictureBox
    Friend WithEvents ForgotPasswordInputLabel As Label
    Friend WithEvents ForgotPasswordHeader As Label
    Friend WithEvents MainInputBoxPanel As Panel
    Friend WithEvents InputBoxInnerPanel As Panel
    Friend WithEvents OkayButton As PictureBox
    Friend WithEvents InputBoxTextBox As Panel
    Friend WithEvents InputBoxTextboxText As PictureBox
    Friend WithEvents NoButton As PictureBox
    Friend WithEvents PromptLabel As Label
    Friend WithEvents YesButton As PictureBox
    Friend WithEvents InputBoxCloseButton As PictureBox
    Friend WithEvents InputBoxTitle As Label
    Friend WithEvents MainLogoPanel As PictureBox
    Friend WithEvents MainMenuWindowPanel As Panel
    Friend WithEvents MainMenuOptionsButton As PictureBox
    Friend WithEvents MainMenuExitButton As PictureBox
    Friend WithEvents MainMenuCreditsButton As PictureBox
    Friend WithEvents MainMenuRegisterButton As PictureBox
    Friend WithEvents MainMenuLoginButton As PictureBox
    Friend WithEvents MainMenuTitle As Label
    Friend WithEvents MainOptionsWindowPanel As Panel
    Friend WithEvents OptionsContainer As Panel
    Friend WithEvents OptionsCancelButton As PictureBox
    Friend WithEvents OptionsApplyButton As PictureBox
    Friend WithEvents MusicSlider As Panel
    Friend WithEvents MusicSliderBar As PictureBox
    Friend WithEvents MusicLabel As Label
    Friend WithEvents SoundSlider As Panel
    Friend WithEvents SoundSliderBar As PictureBox
    Friend WithEvents SoundLabel As Label
    Friend WithEvents KeybindingsButton As PictureBox
    Friend WithEvents AutocloseWindowsCheckboxPanel As Panel
    Friend WithEvents AutocloseWindowsCheckboxCheckbox As PictureBox
    Friend WithEvents AutocloseWindowsCheckboxLabel As Label
    Friend WithEvents FullscreenCheckboxPanel As Panel
    Friend WithEvents FullscreenCheckboxCheckbox As PictureBox
    Friend WithEvents FullscreenCheckboxLabel As Label
    Friend WithEvents FPSPanel As Panel
    Friend WithEvents FPSCombobox As PictureBox
    Friend WithEvents FPSLabel As Label
    Friend WithEvents ResolutionPanel As Panel
    Friend WithEvents ResolutionCombobox As PictureBox
    Friend WithEvents ResolutionLabel As Label
    Friend WithEvents OptionsHeader As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents statusTxtBox As ToolStripStatusLabel
    Friend WithEvents MainRegistrationWindowPanel As Panel
    Friend WithEvents Password2Panel As Panel
    Friend WithEvents Password2Field As PictureBox
    Friend WithEvents Password2Label As Label
    Friend WithEvents Password1Panel As Panel
    Friend WithEvents Password1Field As PictureBox
    Friend WithEvents Password1Label As Label
    Friend WithEvents RegistrationBackButton As PictureBox
    Friend WithEvents RegistrationRegisterButton As PictureBox
    Friend WithEvents EmailPanel As Panel
    Friend WithEvents EmailField As PictureBox
    Friend WithEvents EmailLabel As Label
    Friend WithEvents RegistrationUsernamePanel As Panel
    Friend WithEvents RegistrationUsernameField As PictureBox
    Friend WithEvents RegistrationUsernameLabel As Label
    Friend WithEvents RegistrationLabel As Label
    Friend WithEvents MainResetPasswordWindowPanel As Panel
    Friend WithEvents ResetPassword2Panel As Panel
    Friend WithEvents ResetPassword2Field As PictureBox
    Friend WithEvents ResetPassword2Label As Label
    Friend WithEvents ResetPassword1Panel As Panel
    Friend WithEvents ResetPassword1Field As PictureBox
    Friend WithEvents ResetPassword1Label As Label
    Friend WithEvents ResetBackButton As PictureBox
    Friend WithEvents ResetSubmitButton As PictureBox
    Friend WithEvents CodePanel As Panel
    Friend WithEvents CodeField As PictureBox
    Friend WithEvents CodeLabel As Label
    Friend WithEvents ResetPassHeader As Label
    Friend WithEvents MainServerStatusAreaPanel As Panel
    Friend WithEvents ServerStatusAreaServerStatusLabel As Label
    Friend WithEvents MainControlPanelsWindow As Panel
    Friend WithEvents ControlsPanelInnerPanel As Panel
    Friend WithEvents CancelControlsButton As PictureBox
    Friend WithEvents ExitControlsButton As PictureBox
    Friend WithEvents ControlsHeader As Label
    Friend WithEvents RestoreControlsButton As PictureBox
    Friend WithEvents MainBagItemPanel As Panel
    Friend WithEvents BagItemValue As Label
    Friend WithEvents BagItemIcon As PictureBox
    Friend WithEvents MainBagWindowPanel As Panel
    Friend WithEvents BagWindowCloseButton As PictureBox
    Friend WithEvents BagWindowTitle As Label
    Friend WithEvents MainBankItemPanel As Panel
    Friend WithEvents BankItemValue As Label
    Friend WithEvents BankItemIcon As PictureBox
    Friend WithEvents MainBankWindowPanel As Panel
    Friend WithEvents BankWindowCloseButton As PictureBox
    Friend WithEvents BankWindowTitle As Label
    Friend WithEvents BankWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainCharacterWindowPanel As Panel
    Friend WithEvents CharacterWindowInnerPanel As Panel
    Friend WithEvents IncreaseSpeedButton As PictureBox
    Friend WithEvents SpeedLabel As Label
    Friend WithEvents IncreaseDefenseButton As PictureBox
    Friend WithEvents IncreaseAttackButton As PictureBox
    Friend WithEvents CharacterWindowDefenseLabel As Label
    Friend WithEvents CharacterWindowAttackLabel As Label
    Friend WithEvents CharacterWindowStatsLabel As Label
    Friend WithEvents CharacterWindowEquipmentLabel As Label
    Friend WithEvents CharacterWindowCharacterContainer As PictureBox
    Friend WithEvents ChatacterInfoLabel As Label
    Friend WithEvents CharacterWindowCharacterNameLabel As Label
    Friend WithEvents CharacterWindowCloseButton As PictureBox
    Friend WithEvents CharacterWindowTitle As Label
    Friend WithEvents EquipmentItem4 As Panel
    Friend WithEvents Equipment4Icon As PictureBox
    Friend WithEvents EquipmentItem3 As Panel
    Friend WithEvents Equipment3Icon As PictureBox
    Friend WithEvents EquipmentItem2 As Panel
    Friend WithEvents Equipment2Icon As PictureBox
    Friend WithEvents EquipmentItem1 As Panel
    Friend WithEvents Equipment1Icon As PictureBox
    Friend WithEvents EquipmentItem0 As Panel
    Friend WithEvents Equipment0Icon As PictureBox
    Friend WithEvents PointsLabel As Label
    Friend WithEvents IncreaseMagicResistButton As PictureBox
    Friend WithEvents MagicResistLabel As Label
    Friend WithEvents IncreaseAbilityPowerButton As PictureBox
    Friend WithEvents AbilityPowerLabel As Label
    Friend WithEvents AppSettings As ToolStripMenuItem
    Friend WithEvents MainChatboxWindowPanel As Panel
    Friend WithEvents ChatboxInputField As PictureBox
    Friend WithEvents Chatbar As Panel
    Friend WithEvents ChatboxTitle As Label
    Friend WithEvents MainCraftedItemPanel As Panel
    Friend WithEvents CraftedItemQuantity As Label
    Friend WithEvents CraftedItemIcon As PictureBox
    Friend WithEvents MainCraftingIngredientPanel As Panel
    Friend WithEvents IngredientItemValue As Label
    Friend WithEvents IngredientItemIcon As PictureBox
    Friend WithEvents MainCraftingWindowPanel As Panel
    Friend WithEvents CraftButton As PictureBox
    Friend WithEvents CraftingWindowProgressBar As Panel
    Friend WithEvents ProductLabel As Label
    Friend WithEvents IngredientsTitle As Label
    Friend WithEvents RecipesTitle As Label
    Friend WithEvents IngredientsContainer As Panel
    Friend WithEvents CraftingWindowCloseButton As PictureBox
    Friend WithEvents CraftingWindowTitle As Label
    Friend WithEvents MainEquipmentItemPanel As Panel
    Friend WithEvents EquipmentIcon As PictureBox
    Friend WithEvents MainEscapeMenuPanel As Panel
    Friend WithEvents EscapeMenuLogoutButton As PictureBox
    Friend WithEvents EscapeMenuCloseButton As PictureBox
    Friend WithEvents EscapeMenuExitToDesktopButton As PictureBox
    Friend WithEvents EscapeMenuCharacterSelectButton As PictureBox
    Friend WithEvents EscapeMenuOptionsButton As PictureBox
    Friend WithEvents EscapeMenuTitleLabel As Label
    Friend WithEvents MainEventDialogWindow1ResponsePanel As Panel
    Friend WithEvents Dialog1EventDialogArea As Panel
    Friend WithEvents Dialog1EventDialogAreaInnerPanel As Panel
    Friend WithEvents Dialog1EventDialogLabel As Label
    Friend WithEvents Dialog1Response1Button As PictureBox
    Friend WithEvents Dialog1EventFacePanel As Panel
    Friend WithEvents MainEventDialogWindow2ResponsePanel As Panel
    Friend WithEvents Dialog2Response2Button As PictureBox
    Friend WithEvents Dialog2EventDialogArea As Panel
    Friend WithEvents Dialog2EventDialogAreaInnerPanel As Panel
    Friend WithEvents Dialog2EventDialogLabel As Label
    Friend WithEvents Dialog2Response1Button As PictureBox
    Friend WithEvents Dialog2EventFacePanel As Panel
    Friend WithEvents MainEventDialogWindow3ResponsePanel As Panel
    Friend WithEvents Dialog3Response3Button As PictureBox
    Friend WithEvents Dialog3Response2Button As PictureBox
    Friend WithEvents Dialog3EventDialogArea As Panel
    Friend WithEvents Dialog3EventDialogAreaInnerPanel As Panel
    Friend WithEvents Dialog3EventDialogLabel As Label
    Friend WithEvents Dialog3Response1Button As PictureBox
    Friend WithEvents Dialog3EventFacePanel As Panel
    Friend WithEvents MainEventDialogWindow4ResponsePanel As Panel
    Friend WithEvents Dialog4Response4Button As PictureBox
    Friend WithEvents Dialog4Response3Button As PictureBox
    Friend WithEvents Dialog4Response2Button As PictureBox
    Friend WithEvents Dialog4EventDialogArea As Panel
    Friend WithEvents Dialog4EventDialogAreaInnerPanel As Panel
    Friend WithEvents Dialog4EventDialogLabel As Label
    Friend WithEvents Dialog4Response1Button As PictureBox
    Friend WithEvents Dialog4EventFacePanel As Panel
    Friend WithEvents MainFriendsWindowPanel As Panel
    Friend WithEvents AddFriendPopupButton As PictureBox
    Friend WithEvents FriendsWindowCloseButton As PictureBox
    Friend WithEvents FriendsWindowTitle As Label
    Friend WithEvents MainHotbarWindowPanel As Panel
    Friend WithEvents HotbarContainer9 As Panel
    Friend WithEvents HotbarLabel9 As Label
    Friend WithEvents HotbarCooldownLabel9 As Label
    Friend WithEvents HotbarEquippedLabel9 As Label
    Friend WithEvents HotbarIcon9 As PictureBox
    Friend WithEvents HotbarContainer8 As Panel
    Friend WithEvents HotbarLabel8 As Label
    Friend WithEvents HotbarCooldownLabel8 As Label
    Friend WithEvents HotbarEquippedLabel8 As Label
    Friend WithEvents HotbarIcon8 As PictureBox
    Friend WithEvents HotbarContainer7 As Panel
    Friend WithEvents HotbarLabel7 As Label
    Friend WithEvents HotbarCooldownLabel7 As Label
    Friend WithEvents HotbarEquippedLabel7 As Label
    Friend WithEvents HotbarIcon7 As PictureBox
    Friend WithEvents HotbarContainer6 As Panel
    Friend WithEvents HotbarLabel6 As Label
    Friend WithEvents HotbarCooldownLabel6 As Label
    Friend WithEvents HotbarEquippedLabel6 As Label
    Friend WithEvents HotbarIcon6 As PictureBox
    Friend WithEvents HotbarContainer5 As Panel
    Friend WithEvents HotbarLabel5 As Label
    Friend WithEvents HotbarCooldownLabel5 As Label
    Friend WithEvents HotbarEquippedLabel5 As Label
    Friend WithEvents HotbarIcon5 As PictureBox
    Friend WithEvents HotbarContainer4 As Panel
    Friend WithEvents HotbarLabel4 As Label
    Friend WithEvents HotbarCooldownLabel4 As Label
    Friend WithEvents HotbarEquippedLabel4 As Label
    Friend WithEvents HotbarIcon4 As PictureBox
    Friend WithEvents HotbarContainer3 As Panel
    Friend WithEvents HotbarLabel3 As Label
    Friend WithEvents HotbarCooldownLabel3 As Label
    Friend WithEvents HotbarEquippedLabel3 As Label
    Friend WithEvents HotbarIcon3 As PictureBox
    Friend WithEvents HotbarContainer2 As Panel
    Friend WithEvents HotbarLabel2 As Label
    Friend WithEvents HotbarCooldownLabel2 As Label
    Friend WithEvents HotbarEquippedLabel2 As Label
    Friend WithEvents HotbarIcon2 As PictureBox
    Friend WithEvents HotbarContainer1 As Panel
    Friend WithEvents HotbarLabel1 As Label
    Friend WithEvents HotbarCooldownLabel1 As Label
    Friend WithEvents HotbarEquippedLabel1 As Label
    Friend WithEvents HotbarIcon1 As PictureBox
    Friend WithEvents HotbarContainer0 As Panel
    Friend WithEvents HotbarLabel0 As Label
    Friend WithEvents HotbarCooldownLabel0 As Label
    Friend WithEvents HotbarEquippedLabel0 As Label
    Friend WithEvents HotbarIcon0 As PictureBox
    Friend WithEvents MainGameInputBoxPanel As Panel
    Friend WithEvents GameInputBoxInnerPanel As Panel
    Friend WithEvents GameInputOkayButton As PictureBox
    Friend WithEvents GameInputBoxTextBox As Panel
    Friend WithEvents GameInputBoxTextboxText As PictureBox
    Friend WithEvents GameInputNoButton As PictureBox
    Friend WithEvents GameInputPromptLabel As Label
    Friend WithEvents GameInputYesButton As PictureBox
    Friend WithEvents GameInputBoxCloseButton As PictureBox
    Friend WithEvents GameInputboxTitle As Label
    Friend WithEvents MainInventoryItemPanel As Panel
    Friend WithEvents InventoryItemValue As Label
    Friend WithEvents InventoryItemIcon As PictureBox
    Friend WithEvents InventoryItemCooldownLabel As Label
    Friend WithEvents InventoryItemEquippedLabel As Label
    Friend WithEvents MainInventoryWindowPanel As Panel
    Friend WithEvents InventoryWindowCloseButton As PictureBox
    Friend WithEvents InventoryWindowTitle As Label
    Friend WithEvents MainItemDescWindowPanel As Panel
    Friend WithEvents ItemDescItemValueLabel As Label
    Friend WithEvents ItemDescItemTypeLabel As Label
    Friend WithEvents ItemDescItemQantityLabel As Label
    Friend WithEvents ItemDescItemNameLabel As Label
    Friend WithEvents ItemDescItemIcon As PictureBox
    Friend WithEvents ItemDescItemDescription As Panel
    Friend WithEvents MainItemDescWindowExpandedPanel As Panel
    Friend WithEvents ItemDescExpandedItemStats As Panel
    Friend WithEvents ItemDescItemStatsText As Label
    Friend WithEvents ItemDescExpandedItemValueLabel As Label
    Friend WithEvents ItemDescExpandedItemTypeLabel As Label
    Friend WithEvents ItemDescExpandedItemQuantity As Label
    Friend WithEvents ItemDescExpandedItemNameLabel As Label
    Friend WithEvents ItemDescExpandedItemIcon As PictureBox
    Friend WithEvents ItemDescExpandedItemDescription As Panel
    Friend WithEvents MainMenuContainerPanel As Panel
    Friend WithEvents MenuContainer As Panel
    Friend WithEvents MenuButton As PictureBox
    Friend WithEvents PartyContainer As Panel
    Friend WithEvents PartyButton As PictureBox
    Friend WithEvents FriendsContainer As Panel
    Friend WithEvents FriendsButton As PictureBox
    Friend WithEvents QuestsContainer As Panel
    Friend WithEvents QuestsButton As PictureBox
    Friend WithEvents MenuCharacterContainer As Panel
    Friend WithEvents CharacterButton As PictureBox
    Friend WithEvents SpellsContainer As Panel
    Friend WithEvents SpellsButton As PictureBox
    Friend WithEvents InventoryContainer As Panel
    Friend WithEvents InventoryButton As PictureBox
    Friend WithEvents MainPartyWindowPanel As Panel
    Friend WithEvents PartyInnerPanel As Panel
    Friend WithEvents LeavePartyButton As PictureBox
    Friend WithEvents ManaValue3 As Label
    Friend WithEvents ManaLabel3 As Label
    Friend WithEvents ManaBarContainer3 As Panel
    Friend WithEvents ManaBar3 As PictureBox
    Friend WithEvents HealthValue3 As Label
    Friend WithEvents HealthLabel3 As Label
    Friend WithEvents HealthBarContainer3 As Panel
    Friend WithEvents HealthBar3 As PictureBox
    Friend WithEvents MemberName3 As Label
    Friend WithEvents ManaValue2 As Label
    Friend WithEvents ManaLabel2 As Label
    Friend WithEvents ManaBarContainer2 As Panel
    Friend WithEvents ManaBar2 As PictureBox
    Friend WithEvents HealthValue2 As Label
    Friend WithEvents HealthLabel2 As Label
    Friend WithEvents HealthBarContainer2 As Panel
    Friend WithEvents HealthBar2 As PictureBox
    Friend WithEvents MemberName2 As Label
    Friend WithEvents ManaValue1 As Label
    Friend WithEvents ManaLabel1 As Label
    Friend WithEvents ManaBarContainer1 As Panel
    Friend WithEvents ManaBar1 As PictureBox
    Friend WithEvents HealthValue1 As Label
    Friend WithEvents HealthLabel1 As Label
    Friend WithEvents HealthBarContainer1 As Panel
    Friend WithEvents HealthBar1 As PictureBox
    Friend WithEvents MemberName1 As Label
    Friend WithEvents ManaValue0 As Label
    Friend WithEvents ManaLabel0 As Label
    Friend WithEvents ManaBarContainer0 As Panel
    Friend WithEvents ManaBar0 As PictureBox
    Friend WithEvents HealthValue0 As Label
    Friend WithEvents HealthLabel0 As Label
    Friend WithEvents LeaderText As Label
    Friend WithEvents LeaderIcon As PictureBox
    Friend WithEvents HealthBarContainer0 As Panel
    Friend WithEvents HealthBar0 As PictureBox
    Friend WithEvents MemberName0 As Label
    Friend WithEvents PartyCloseButton As PictureBox
    Friend WithEvents PartyTitle As Label
    Friend WithEvents KickButton3 As PictureBox
    Friend WithEvents KickButton2 As PictureBox
    Friend WithEvents KickButton1 As PictureBox
    Friend WithEvents MainPlayerBoxPanel As Panel
    Friend WithEvents PlayerBoxFriendButton As PictureBox
    Friend WithEvents PlayerBoxPartyButton As PictureBox
    Friend WithEvents PlayerBoxTradeButton As PictureBox
    Friend WithEvents EntityInfoPanel As Panel
    Friend WithEvents EXPLabel As Label
    Friend WithEvents EXPTitle As Label
    Friend WithEvents EXPBar As PictureBox
    Friend WithEvents EXPBackground As PictureBox
    Friend WithEvents MPLabel As Label
    Friend WithEvents MPTitle As Label
    Friend WithEvents MPBar As PictureBox
    Friend WithEvents MPBackground As PictureBox
    Friend WithEvents HPLabel As Label
    Friend WithEvents HPTitle As Label
    Friend WithEvents ShieldBar As PictureBox
    Friend WithEvents HPBar As PictureBox
    Friend WithEvents HPBarBackground As PictureBox
    Friend WithEvents EntityGraphicContainer As PictureBox
    Friend WithEvents EntityMapLabel As Label
    Friend WithEvents NameAndLevelLabel As Label
    Friend WithEvents EntityLevelLabel As Label
    Friend WithEvents EntityNameLabel As Label
    Friend WithEvents MainPlayerStatusIconPanel As Panel
    Friend WithEvents DurationLabel As Label
    Friend WithEvents StatusIcon As PictureBox
    Friend WithEvents QuestOfferInnerPanel As Panel
    Friend WithEvents QuestOfferAcceptButton As PictureBox
    Friend WithEvents QuestTitle As Label
    Friend WithEvents MainQuestOfferWindowPanel As Panel
    Friend WithEvents QuestOfferCloseButton As PictureBox
    Friend WithEvents QuestOfferTitle As Label
    Friend WithEvents QuestOfferArea As Panel
    Friend WithEvents QuestOfferTemplate As Label
    Friend WithEvents QuestOfferDeclineButton As PictureBox
    Friend WithEvents MainQuestsWindowPanel As Panel
    Friend WithEvents QuestsWindowAbandonQuestButton As PictureBox
    Friend WithEvents QuestsWindowBackButton As PictureBox
    Friend WithEvents QuestsWindowQuestDescription As Panel
    Friend WithEvents QuestsWindowQuestDescriptionTemplate As Label
    Friend WithEvents QuestsWindowQuestStatus As Label
    Friend WithEvents QuestsWindowQuestTitle As Label
    Friend WithEvents QuestsWindowCloseButton As PictureBox
    Friend WithEvents QuestsWindowTitle As Label
    Friend WithEvents QuestsWindowQuestList As Panel
    Friend WithEvents MainShopItemPanel As Panel
    Friend WithEvents ShopItemIcon As PictureBox
    Friend WithEvents MainShopWindowPanel As Panel
    Friend WithEvents ShopWindowCloseButton As PictureBox
    Friend WithEvents ShopWindowTitle As Label
    Friend WithEvents MainSpellPanel As Panel
    Friend WithEvents SpellCooldownLabel As Label
    Friend WithEvents SpellIcon As PictureBox
    Friend WithEvents MainSpellDescWindowPanel As Panel
    Friend WithEvents SpellDescSpellType As Label
    Friend WithEvents SpellDescSpellName As Label
    Friend WithEvents SpellDescSpellIcon As PictureBox
    Friend WithEvents SpellDescSpellDesc As Panel
    Friend WithEvents SpellDescSpellDescText As Label
End Class
