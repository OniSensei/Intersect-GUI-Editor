﻿Imports System.IO
Imports Newtonsoft.Json

Public Class Form1
    Private _rnd As New Random()
    Function RandomNumber(ByVal low As Integer, ByVal high As Integer) As Integer
        Return _rnd.Next(low, high)
    End Function

    Public menuGuiPath As String = Application.StartupPath & "\gui\layouts\menu\"
    Public gameGuiPath As String = Application.StartupPath & "\gui\layouts\game\"
    Public openFile As String
    Dim loginchecked As Boolean = False
    Dim malechecked As Boolean = False
    Dim femalechecked As Boolean = False
    Dim fullscreenchecked As Boolean = False
    Dim autoclosewindowschecked As Boolean = True
    Dim gridoverlay As Boolean = False
    Public guitype As String = "game"

    Public Sub StatusText(ByVal text As String)
        statusTxtBox.Text = text
    End Sub

    Private Sub LoginWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginWindowToolStripMenuItem.Click
        gridoverlay = False
        guitype = "menu"
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainLogoPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingIngredientPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadLoginGUI(menuGuiPath & "LoginWindow.json")
        openFile = menuGuiPath & "LoginWindow.json"
    End Sub

    Private Sub CharacterCreationWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CharacterCreationWindowToolStripMenuItem.Click
        gridoverlay = False
        guitype = "menu"
        MainLoginWindowPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainLogoPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingIngredientPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadCharacterCreationGUI(menuGuiPath & "CharacterCreationWindow.json")
        openFile = menuGuiPath & "CharacterCreationWindow.json"
    End Sub

    Private Sub CharacterSelectionWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CharacterSelectionWindowToolStripMenuItem.Click
        gridoverlay = False
        guitype = "menu"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainLogoPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingIngredientPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadCharacterSelectionGUI(menuGuiPath & "CharacterSelectionWindow.json")
        openFile = menuGuiPath & "CharacterSelectionWindow.json"
    End Sub

    Private Sub CreditsWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditsWindowToolStripMenuItem.Click
        gridoverlay = False
        guitype = "menu"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainLogoPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingIngredientPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadCreditsGUI(menuGuiPath & "CreditsWindow.json")
        openFile = menuGuiPath & "CreditsWindow.json"
    End Sub

    Private Sub ForgotPasswordWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForgotPasswordWindowToolStripMenuItem.Click
        gridoverlay = False
        guitype = "menu"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainLogoPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingIngredientPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadForgotPasswordGUI(menuGuiPath & "ForgotPasswordWindow.json")
        openFile = menuGuiPath & "ForgotPasswordWindow.json"
    End Sub

    Private Sub InputBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputBoxToolStripMenuItem.Click
        gridoverlay = False
        guitype = "menu"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingIngredientPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadInputBoxGUI(menuGuiPath & "InputBox.json")
        openFile = menuGuiPath & "InputBox.json"
    End Sub

    Private Sub LogoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoToolStripMenuItem.Click
        gridoverlay = False
        guitype = "menu"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingIngredientPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadLogoGUI(menuGuiPath & "Logo.json")
        openFile = menuGuiPath & "Logo.json"
    End Sub

    Private Sub MenuWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuWindowToolStripMenuItem.Click
        gridoverlay = False
        guitype = "menu"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingIngredientPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadMenuWindow(menuGuiPath & "MenuWindow.json")
        openFile = menuGuiPath & "MenuWindow.json"
    End Sub

    Private Sub OptionsWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsWindowToolStripMenuItem.Click
        gridoverlay = False
        guitype = "menu"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingIngredientPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadOptionsWindowGUI(menuGuiPath & "OptionsWindow.json")
        openFile = menuGuiPath & "OptionsWindow.json"
    End Sub

    Private Sub RegistrationWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrationWindowToolStripMenuItem.Click
        gridoverlay = False
        guitype = "menu"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingIngredientPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadRegistrationWindowGUI(menuGuiPath & "RegistrationWindow.json")
        openFile = menuGuiPath & "RegistrationWindow.json"
    End Sub

    Private Sub ResetPasswordWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetPasswordWindowToolStripMenuItem.Click
        gridoverlay = False
        guitype = "menu"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingIngredientPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadResetPasswordWindowGUI(menuGuiPath & "ResetPasswordWindow.json")
        openFile = menuGuiPath & "ResetPasswordWindow.json"
    End Sub

    Private Sub ServerStatusAreaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServerStatusAreaToolStripMenuItem.Click
        gridoverlay = False
        guitype = "menu"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingIngredientPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadServerStatusAreaGUI(menuGuiPath & "ServerStatusArea.json")
        openFile = menuGuiPath & "ServerStatusArea.json"
    End Sub

    Private Sub BagItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BagItemToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingIngredientPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadBagItemGUI(gameGuiPath & "BagItem.json")
        openFile = gameGuiPath & "BagItem.json"
    End Sub

    Private Sub BagWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BagWindowToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingIngredientPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadBagWindowGUI(gameGuiPath & "BagWindow.json")
        openFile = gameGuiPath & "BagWindow.json"
    End Sub

    Private Sub BankItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BankItemToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingIngredientPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadBankItemGUI(gameGuiPath & "BankItem.json")
        openFile = gameGuiPath & "BankItem.json"
    End Sub

    Private Sub BankWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BankWindowToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingIngredientPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadBankWindowGUI(gameGuiPath & "BankWindow.json")
        openFile = gameGuiPath & "BankWindow.json"
    End Sub

    Private Sub CharacterWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CharacterWindowToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingIngredientPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadCharacterWindowGUI(gameGuiPath & "CharacterWindow.json")
        openFile = gameGuiPath & "CharacterWindow.json"
    End Sub

    Private Sub ChatboxWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChatboxWindowToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingIngredientPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadChatboxWindowGUI(gameGuiPath & "ChatboxWindow.json")
        openFile = gameGuiPath & "ChatboxWindow.json"
    End Sub

    Private Sub CraftedItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CraftedItemToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftingIngredientPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadCraftedItemGUI(gameGuiPath & "CraftedItem.json")
        openFile = gameGuiPath & "CraftedItem.json"
    End Sub

    Private Sub CraftingIngredientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CraftingIngredientToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadCraftingIngredientGUI(gameGuiPath & "CraftingIngredient.json")
        openFile = gameGuiPath & "CraftingIngredient.json"
    End Sub

    Private Sub CraftingWindowToolStripMenuItemm_Click(sender As Object, e As EventArgs) Handles CraftingWindowToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadCraftingWindowGUI(gameGuiPath & "CraftingWindow.json")
        openFile = gameGuiPath & "CraftingWindow.json"
    End Sub

    Private Sub EquipmentItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EquipmentItemToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadEquipmentItemGUI(gameGuiPath & "EquipmentItem.json")
        openFile = gameGuiPath & "EquipmentItem.json"
    End Sub

    Private Sub EscapeMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EscapeMenuToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadEscapeMenuGUI(gameGuiPath & "EscapeMenu.json")
        openFile = gameGuiPath & "EscapeMenu.json"
    End Sub

    Private Sub EventDialogWindow1ResponseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EventDialogWindow1ResponseToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadEventDialogWindow1ResponseGUI(gameGuiPath & "EventDialogWindow_1Response.json")
        openFile = gameGuiPath & "EventDialogWindow_1Response.json"
    End Sub

    Private Sub EventDialogWindow2ResponseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EventDialogWindow2ResponseToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadEventDialogWindow2ResponseGUI(gameGuiPath & "EventDialogWindow_2Responses.json")
        openFile = gameGuiPath & "EventDialogWindow_2Responses.json"
    End Sub

    Private Sub EventDialogWindow3ResponseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EventDialogWindow3ResponseToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadEventDialogWindow3ResponseGUI(gameGuiPath & "EventDialogWindow_3Responses.json")
        openFile = gameGuiPath & "EventDialogWindow_3Responses.json"
    End Sub

    Private Sub EventDialogWindow4ResponseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EventDialogWindow4ResponseToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadEventDialogWindow4ResponseGUI(gameGuiPath & "EventDialogWindow_4Responses.json")
        openFile = gameGuiPath & "EventDialogWindow_4Responses.json"
    End Sub

    Private Sub FriendsWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FriendsWindowToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadFriendsWindowGUI(gameGuiPath & "FriendsWindow.json")
        openFile = gameGuiPath & "FriendsWindow.json"
    End Sub

    Private Sub HotbarWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HotbarWindowToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainGameInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadHotbarWindowGUI(gameGuiPath & "HotbarWindow.json")
        openFile = gameGuiPath & "HotbarWindow.json"
    End Sub

    Private Sub InputBoxToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InputBoxToolStripMenuItem1.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadGameInputBoxGUI(gameGuiPath & "InputBox.json")
        openFile = gameGuiPath & "InputBox.json"
    End Sub

    Private Sub InventoryItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryItemToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainInventoryWindowPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadInventoryItemGUI(gameGuiPath & "InventoryItem.json")
        openFile = gameGuiPath & "InventoryItem.json"
    End Sub

    Private Sub InventoryWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryWindowToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadInventoryWindowGUI(gameGuiPath & "InventoryWindow.json")
        openFile = gameGuiPath & "InventoryWindow.json"
    End Sub

    Private Sub ItemDescWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemDescWindowToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadItemDescWindowGUI(gameGuiPath & "ItemDescWindow.json")
        openFile = gameGuiPath & "ItemDescWindow.json"
    End Sub

    Private Sub ItemDescWindowExpandedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemDescWindowExpandedToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadItemDescWindowExpandedGUI(gameGuiPath & "ItemDescWindowExpanded.json")
        openFile = gameGuiPath & "ItemDescWindowExpanded.json"
    End Sub

    Private Sub MenuContainerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuContainerToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadMenuContainerGUI(gameGuiPath & "MenuContainer.json")
        openFile = gameGuiPath & "MenuContainer.json"
    End Sub

    Private Sub OptionsWindowToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OptionsWindowToolStripMenuItem1.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadOptionsWindowGUI(gameGuiPath & "OptionsWindow.json")
        openFile = gameGuiPath & "OptionsWindow.json"
    End Sub

    Private Sub PartyWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartyWindowToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadPartyWindowGUI(gameGuiPath & "PartyWindow.json")
        openFile = gameGuiPath & "PartyWindow.json"
    End Sub

    Private Sub PlayerBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayerBoxToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadPlayerBoxGUI(gameGuiPath & "PlayerBox.json")
        openFile = gameGuiPath & "PlayerBox.json"
    End Sub

    Private Sub PlayerStatusIconToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayerStatusIconToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadPlayerStatusIconGUI(gameGuiPath & "PlayerStatusIcon.json")
        openFile = gameGuiPath & "PlayerStatusIcon.json"
    End Sub

    Private Sub QuestOfferWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuestOfferWindowToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadQuestOfferWindowGUI(gameGuiPath & "QuestOfferWindow.json")
        openFile = gameGuiPath & "QuestOfferWindow.json"
    End Sub

    Private Sub QuestWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuestWindowToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadQuestsWindowGUI(gameGuiPath & "QuestsWindow.json")
        openFile = gameGuiPath & "QuestsWindow.json"
    End Sub

    Private Sub ShopItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShopItemToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadShopItemGUI(gameGuiPath & "ShopItem.json")
        openFile = gameGuiPath & "ShopItem.json"
    End Sub

    Private Sub ShopWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShopWindowToolStripMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadShopWindowGUI(gameGuiPath & "ShopWindow.json")
        openFile = gameGuiPath & "ShopWindow.json"
    End Sub

    Private Sub SpellMenuItem_Click(sender As Object, e As EventArgs) Handles SpellMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadSpellGUI(gameGuiPath & "Spell.json")
        openFile = gameGuiPath & "Spell.json"
    End Sub

    Private Sub SpellDescWindowMenuItem_Click(sender As Object, e As EventArgs) Handles SpellDescWindowMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadSpellDescWindowGUI(gameGuiPath & "SpellDescWindow.json")
        openFile = gameGuiPath & "SpellDescWindow.json"
    End Sub

    Private Sub SpellDescWindowExpandedMenuItem_Click(sender As Object, e As EventArgs) Handles SpellDescWindowExpandedMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadSpellDescWindowExpandedGUI(gameGuiPath & "SpellDescWindowExpanded.json")
        openFile = gameGuiPath & "SpellDescWindowExpanded.json"
    End Sub

    Private Sub SpellsWindowMenuItem_Click(sender As Object, e As EventArgs) Handles SpellsWindowMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainPlayerBoxPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadSpellsWindowGUI(gameGuiPath & "SpellsWindow.json")
        openFile = gameGuiPath & "SpellsWindow.json"
    End Sub

    Private Sub TargetBoxMenuItem_Click(sender As Object, e As EventArgs) Handles TargetBoxMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadPlayerBoxGUI(gameGuiPath & "TargetBox.json")
        openFile = gameGuiPath & "TargetBox.json"
    End Sub

    Private Sub TargetStatusIconMenuItem_Click(sender As Object, e As EventArgs) Handles TargetStatusIconMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadTargetStatusIconGUI(gameGuiPath & "TargetStatusIcon.json")
        openFile = gameGuiPath & "TargetStatusIcon.json"
    End Sub

    Private Sub TheirTradeItemMenuItem_Click(sender As Object, e As EventArgs) Handles TheirTradeItemMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTradeWindowPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadTheirTradeItemGUI(gameGuiPath & "TheirTradeItem.json")
        openFile = gameGuiPath & "TheirTradeItem.json"
    End Sub

    Private Sub TradeWindowMenuItem_Click(sender As Object, e As EventArgs) Handles TradeWindowMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainYourTradeItem.Visible = False

        LoadTradeWindowGUI(gameGuiPath & "TradeWindow.json")
        openFile = gameGuiPath & "TradeWindow.json"
    End Sub

    Private Sub YourTradeItemMenuItem_Click(sender As Object, e As EventArgs) Handles YourTradeItemMenuItem.Click
        gridoverlay = False
        guitype = "game"
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainLogoPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainMenuWindowPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainRegistrationWindowPanel.Visible = False
        MainResetPasswordWindowPanel.Visible = False
        MainServerStatusAreaPanel.Visible = False
        MainBagItemPanel.Visible = False
        MainBagWindowPanel.Visible = False
        MainBankItemPanel.Visible = False
        MainBankWindowPanel.Visible = False
        MainCharacterWindowPanel.Visible = False
        MainChatboxWindowPanel.Visible = False
        MainCraftedItemPanel.Visible = False
        MainCraftingWindowPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEquipmentItemPanel.Visible = False
        MainEscapeMenuPanel.Visible = False
        MainEventDialogWindow1ResponsePanel.Visible = False
        MainEventDialogWindow2ResponsePanel.Visible = False
        MainEventDialogWindow3ResponsePanel.Visible = False
        MainEventDialogWindow4ResponsePanel.Visible = False
        MainFriendsWindowPanel.Visible = False
        MainHotbarWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False
        MainInventoryItemPanel.Visible = False
        MainItemDescWindowPanel.Visible = False
        MainMenuContainerPanel.Visible = False
        MainOptionsWindowPanel.Visible = False
        MainPartyWindowPanel.Visible = False
        MainItemDescWindowExpandedPanel.Visible = False
        MainSpellsWindowPanel.Visible = False
        MainPlayerStatusIconPanel.Visible = False
        MainQuestOfferWindowPanel.Visible = False
        MainQuestsWindowPanel.Visible = False
        MainShopItemPanel.Visible = False
        MainShopWindowPanel.Visible = False
        MainSpellPanel.Visible = False
        MainSpellDescWindowPanel.Visible = False
        MainSpellDescWindowExpandedPanel.Visible = False
        MainTargetStatusIconPanel.Visible = False
        MainTheirTradeItemPanel.Visible = False
        MainTradeWindowPanel.Visible = False

        LoadYourTradeItemGUI(gameGuiPath & "YourTradeItem.json")
        openFile = gameGuiPath & "YourTradeItem.json"
    End Sub

    Private Sub JTokenTreeUserControl1_AfterSelect(sender As Object, e As ZTn.Json.JsonTreeView.AfterSelectEventArgs) Handles JTokenTreeUserControl1.AfterSelect
        jsonType.Text = e.TypeName
        jsonTypeCombo.Text = e.JTokenTypeName
        If Not jsonValue.Focused Then
            If JTokenTreeUserControl1.jsonTreeView.SelectedNode.Text.Contains("""") Then
                jsonValue.Text = JTokenTreeUserControl1.jsonTreeView.SelectedNode.Text
            Else
                jsonValue.Text = """" & JTokenTreeUserControl1.jsonTreeView.SelectedNode.Text & """"
            End If

            If JTokenTreeUserControl1.jsonTreeView.SelectedNode.Text.Contains("Bounds") Then
                StatusText("Bounds: 'Position X, Position Y, Width, Height'")
            ElseIf JTokenTreeUserControl1.jsonTreeView.SelectedNode.Text.Contains("Padding") Then
                StatusText("Padding: 'X1, Y1, X2, Y2'")
            ElseIf JTokenTreeUserControl1.jsonTreeView.SelectedNode.Text.Contains("AlignmentEdgeDistances") Then
                StatusText("AlignmentEdgeDistances: 'X1, Y1, X2, Y2'")
            ElseIf JTokenTreeUserControl1.jsonTreeView.SelectedNode.Text.Contains("Margin") Then
                StatusText("Margin: 'X1, Y1, X2, Y2'")
            ElseIf JTokenTreeUserControl1.jsonTreeView.SelectedNode.Text.Contains("AlignmentTransform") Then
                StatusText("Margin: 'X, Y'")
            ElseIf JTokenTreeUserControl1.jsonTreeView.SelectedNode.Text.Contains("RenderColor") Then
                StatusText("RenderColor: 'RED, BLUE, GREEN, ALPHA'")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        If jsonType.Text <> "Object" Then
            JTokenTreeUserControl1.UpdateSelected(jsonValue.Text)

            gridoverlay = False
            StatusText("[MAIN]     Updating TreeView")

            ReloadText(openFile, "treeview")
        End If
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        StatusText("[MAIN]     Refreshing")
        gridoverlay = False
        If openFile.Contains("LoginWindow.json") Then
            LoadLoginGUI(openFile)
        ElseIf openFile.Contains("CharacterCreationWindow.json") Then
            LoadCharacterCreationGUI(openFile)
        ElseIf openFile.Contains("CharacterSelectionWindow.json") Then
            LoadCharacterSelectionGUI(openFile)
        ElseIf openFile.Contains("CreditsWindow.json") Then
            LoadCreditsGUI(openFile)
        ElseIf openFile.Contains("ForgotPasswordWindow.json") Then
            LoadForgotPasswordGUI(openFile)
        ElseIf openFile.Contains("InputBox.json") Then
            LoadInputBoxGUI(openFile)
        ElseIf openFile.Contains("Logo.json") Then
            LoadLogoGUI(openFile)
        ElseIf openFile.Contains("MenuWindow.json") Then
            LoadMenuWindow(openFile)
        ElseIf openFile.Contains("OptionsWindow.json") Then
            LoadOptionsWindowGUI(openFile)
        ElseIf openFile.Contains("RegistrationWindow.json") Then
            LoadRegistrationWindowGUI(openFile)
        ElseIf openFile.Contains("ResetPasswordWindow.json") Then
            LoadResetPasswordWindowGUI(openFile)
        ElseIf openFile.Contains("ServerStatusArea.json") Then
            LoadServerStatusAreaGUI(openFile)
        ElseIf openFile.Contains("BagItem.json") Then
            LoadBagItemGUI(openFile)
        ElseIf openFile.Contains("BagWindow.json") Then
            LoadBagWindowGUI(openFile)
        ElseIf openFile.Contains("BankItem.json") Then
            LoadBankItemGUI(openFile)
        ElseIf openFile.Contains("BankWindow.json") Then
            LoadBankWindowGUI(openFile)
        ElseIf openFile.Contains("CharacterWindow.json") Then
            LoadCharacterWindowGUI(openFile)
        ElseIf openFile.Contains("ChatboxWindow.json") Then
            LoadChatboxWindowGUI(openFile)
        ElseIf openFile.Contains("CraftedItem.json") Then
            LoadCraftedItemGUI(openFile)
        ElseIf openFile.Contains("CraftingIngredient.json") Then
            LoadCraftingIngredientGUI(openFile)
        ElseIf openFile.Contains("CraftingWindow.json") Then
            LoadCraftingWindowGUI(openFile)
        ElseIf openFile.Contains("EquipmentItem.json") Then
            LoadEquipmentItemGUI(openFile)
        ElseIf openFile.Contains("EscapeMenu.json") Then
            LoadEscapeMenuGUI(openFile)
        ElseIf openFile.Contains("EventDialogWindow_1Response.json") Then
            LoadEventDialogWindow1ResponseGUI(openFile)
        ElseIf openFile.Contains("EventDialogWindow_2Responses.json") Then
            LoadEventDialogWindow2ResponseGUI(openFile)
        ElseIf openFile.Contains("EventDialogWindow_3Responses.json") Then
            LoadEventDialogWindow3ResponseGUI(openFile)
        ElseIf openFile.Contains("EventDialogWindow_4Responses.json") Then
            LoadEventDialogWindow4ResponseGUI(openFile)
        ElseIf openFile.Contains("FriendsWindow.json") Then
            LoadFriendsWindowGUI(openFile)
        ElseIf openFile.Contains("HotbarWindow.json") Then
            LoadHotbarWindowGUI(openFile)
        ElseIf openFile.Contains("InputBox.json") Then
            LoadGameInputBoxGUI(openFile)
        ElseIf openFile.Contains("InventoryItem.json") Then
            LoadInventoryItemGUI(openFile)
        ElseIf openFile.Contains("InventoryWindow.json") Then
            LoadInventoryWindowGUI(openFile)
        ElseIf openFile.Contains("ItemDescWindow.json") Then
            LoadItemDescWindowGUI(openFile)
        ElseIf openFile.Contains("ItemDescWindowExpanded.json") Then
            LoadItemDescWindowExpandedGUI(openFile)
        ElseIf openFile.Contains("MenuContainer.json") Then
            LoadMenuContainerGUI(openFile)
        ElseIf openFile.Contains("PartyWindow.json") Then
            LoadPartyWindowGUI(openFile)
        ElseIf openFile.Contains("PlayerBox.json") Then
            LoadPlayerBoxGUI(openFile)
        ElseIf openFile.Contains("PlayerStatusIcon.json") Then
            LoadPlayerStatusIconGUI(openFile)
        ElseIf openFile.Contains("QuestOfferWindow.json") Then
            LoadQuestOfferWindowGUI(openFile)
        ElseIf openFile.Contains("QuestsWindow.json") Then
            LoadQuestsWindowGUI(openFile)
        ElseIf openFile.Contains("ShopItem.json") Then
            LoadShopItemGUI(openFile)
        ElseIf openFile.Contains("ShopWindow.json") Then
            LoadShopWindowGUI(openFile)
        ElseIf openFile.Contains("Spell.json") Then
            LoadSpellGUI(openFile)
        ElseIf openFile.Contains("SpellDescWindow.json") Then
            LoadSpellDescWindowGUI(openFile)
        ElseIf openFile.Contains("SpellDescWindowExpanded.json") Then
            LoadSpellDescWindowExpandedGUI(openFile)
        ElseIf openFile.Contains("SpellsWindow.json") Then
            LoadSpellsWindowGUI(openFile)
        ElseIf openFile.Contains("TargetBox.json") Then
            LoadPlayerBoxGUI(openFile)
        ElseIf openFile.Contains("TargetStatusIcon.json") Then
            LoadTargetStatusIconGUI(openFile)
        ElseIf openFile.Contains("TheirTradeItem.json") Then
            LoadTheirTradeItemGUI(openFile)
        ElseIf openFile.Contains("TradeWindow.json") Then
            LoadTradeWindowGUI(openFile)
        ElseIf openFile.Contains("YourTradeItem.json") Then
            LoadYourTradeItemGUI(openFile)
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Using writer = New FileStream(openFile, FileMode.Open)
            JTokenTreeUserControl1.SaveJson(writer)
            StatusText("[MAIN]     Saving " & openFile)
        End Using
        StatusText("[MAIN]     Save Complete.")
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim infoPull As LoginWindow
        infoPull = JsonConvert.DeserializeObject(Of LoginWindow)(fullJson.Text)
        LoginButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.LoginButton.ClickedImage)
    End Sub

    Private Sub LoginButton_MouseDown(sender As Object, e As MouseEventArgs) Handles LoginButton.MouseDown
        Dim infoPull As LoginWindow
        infoPull = JsonConvert.DeserializeObject(Of LoginWindow)(fullJson.Text)
        LoginButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.LoginButton.ClickedImage)
    End Sub

    Private Sub LoginButton_MouseHover(sender As Object, e As EventArgs) Handles LoginButton.MouseHover
        Dim infoPull As LoginWindow
        infoPull = JsonConvert.DeserializeObject(Of LoginWindow)(fullJson.Text)
        LoginButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.LoginButton.HoveredImage)
    End Sub

    Private Sub LoginButton_MouseLeave(sender As Object, e As EventArgs) Handles LoginButton.MouseLeave
        Dim infoPull As LoginWindow
        infoPull = JsonConvert.DeserializeObject(Of LoginWindow)(fullJson.Text)
        LoginButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.LoginButton.NormalImage)
    End Sub

    Private Sub LoginButton_MouseUp(sender As Object, e As MouseEventArgs) Handles LoginButton.MouseUp
        Dim infoPull As LoginWindow
        infoPull = JsonConvert.DeserializeObject(Of LoginWindow)(fullJson.Text)
        LoginButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.LoginButton.HoveredImage)
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Dim infoPull As LoginWindow
        infoPull = JsonConvert.DeserializeObject(Of LoginWindow)(fullJson.Text)
        BackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.ClickedImage)
    End Sub

    Private Sub BackButton_MouseDown(sender As Object, e As MouseEventArgs) Handles BackButton.MouseDown
        Dim infoPull As LoginWindow
        infoPull = JsonConvert.DeserializeObject(Of LoginWindow)(fullJson.Text)
        BackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.ClickedImage)
    End Sub

    Private Sub BackButton_MouseHover(sender As Object, e As EventArgs) Handles BackButton.MouseHover
        Dim infoPull As LoginWindow
        infoPull = JsonConvert.DeserializeObject(Of LoginWindow)(fullJson.Text)
        BackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.HoveredImage)
    End Sub

    Private Sub BackButton_MouseUp(sender As Object, e As MouseEventArgs) Handles BackButton.MouseUp
        Dim infoPull As LoginWindow
        infoPull = JsonConvert.DeserializeObject(Of LoginWindow)(fullJson.Text)
        BackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.HoveredImage)
    End Sub

    Private Sub BackButton_MouseLeave(sender As Object, e As EventArgs) Handles BackButton.MouseLeave
        Dim infoPull As LoginWindow
        infoPull = JsonConvert.DeserializeObject(Of LoginWindow)(fullJson.Text)
        BackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.NormalImage)
    End Sub

    Private Sub SavePassCheckbox_Click(sender As Object, e As EventArgs) Handles SavePassCheckbox.Click
        Dim infoPull As LoginWindow
        infoPull = JsonConvert.DeserializeObject(Of LoginWindow)(fullJson.Text)
        If loginchecked Then
            SavePassCheckbox.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.SavePassCheckbox.Checkbox.NormalImage)
            loginchecked = False
        Else
            SavePassCheckbox.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.SavePassCheckbox.Checkbox.CheckedImage)
            loginchecked = True
        End If
    End Sub

    Private Sub MaleCheckbox_Click(sender As Object, e As EventArgs) Handles MaleCheckbox.Click
        Dim infoPull As CharacterCreationWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterCreationWindow)(fullJson.Text)
        If malechecked Then
            MaleCheckbox.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.GenderPanel.Children.MaleCheckbox.Checkbox.NormalImage)
            malechecked = False
        Else
            MaleCheckbox.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.GenderPanel.Children.MaleCheckbox.Checkbox.CheckedImage)
            malechecked = True
        End If
    End Sub

    Private Sub FemaleCheckbox_Click(sender As Object, e As EventArgs) Handles FemaleCheckbox.Click
        Dim infoPull As CharacterCreationWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterCreationWindow)(fullJson.Text)
        If femalechecked Then
            FemaleCheckbox.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.GenderPanel.Children.FemaleCheckBox.Checkbox.NormalImage)
            femalechecked = False
        Else
            FemaleCheckbox.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.GenderPanel.Children.FemaleCheckBox.Checkbox.CheckedImage)
            femalechecked = True
        End If
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        Dim infoPull As CharacterCreationWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterCreationWindow)(fullJson.Text)
        CreateButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CreateButton.ClickedImage)
    End Sub

    Private Sub CreateButton_MouseDown(sender As Object, e As MouseEventArgs) Handles CreateButton.MouseDown
        Dim infoPull As CharacterCreationWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterCreationWindow)(fullJson.Text)
        CreateButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CreateButton.ClickedImage)
    End Sub

    Private Sub CreateButton_MouseHover(sender As Object, e As EventArgs) Handles CreateButton.MouseHover
        Dim infoPull As CharacterCreationWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterCreationWindow)(fullJson.Text)
        CreateButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CreateButton.HoveredImage)
    End Sub

    Private Sub CreateButton_MouseUp(sender As Object, e As MouseEventArgs) Handles CreateButton.MouseUp
        Dim infoPull As CharacterCreationWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterCreationWindow)(fullJson.Text)
        CreateButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CreateButton.HoveredImage)
    End Sub

    Private Sub CreateButton_MouseLeave(sender As Object, e As EventArgs) Handles CreateButton.MouseLeave
        Dim infoPull As CharacterCreationWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterCreationWindow)(fullJson.Text)
        CreateButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CreateButton.NormalImage)
    End Sub

    Private Sub CharCreateBackButton_Click(sender As Object, e As EventArgs) Handles CharCreateBackButton.Click
        Dim infoPull As CharacterCreationWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterCreationWindow)(fullJson.Text)
        CharCreateBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.ClickedImage)
    End Sub

    Private Sub CharCreateBackButton_MouseDown(sender As Object, e As MouseEventArgs) Handles CharCreateBackButton.MouseDown
        Dim infoPull As CharacterCreationWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterCreationWindow)(fullJson.Text)
        CharCreateBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.ClickedImage)
    End Sub

    Private Sub CharCreateBackButton_MouseHover(sender As Object, e As EventArgs) Handles CharCreateBackButton.MouseHover
        Dim infoPull As CharacterCreationWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterCreationWindow)(fullJson.Text)
        CharCreateBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.HoveredImage)
    End Sub

    Private Sub CharCreateBackButton_MouseUp(sender As Object, e As MouseEventArgs) Handles CharCreateBackButton.MouseUp
        Dim infoPull As CharacterCreationWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterCreationWindow)(fullJson.Text)
        CharCreateBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.HoveredImage)
    End Sub

    Private Sub CharCreateBackButton_MouseLeave(sender As Object, e As EventArgs) Handles CharCreateBackButton.MouseLeave
        Dim infoPull As CharacterCreationWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterCreationWindow)(fullJson.Text)
        CharCreateBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.NormalImage)
    End Sub

    Private Sub NextSpriteButton_Click(sender As Object, e As EventArgs) Handles NextSpriteButton.Click
        Dim infoPull As CharacterCreationWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterCreationWindow)(fullJson.Text)
        NextSpriteButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CharacterContainer.Children.NextSpriteButton.ClickedImage)
    End Sub

    Private Sub NextSpriteButton_MouseDown(sender As Object, e As MouseEventArgs) Handles NextSpriteButton.MouseDown
        Dim infoPull As CharacterCreationWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterCreationWindow)(fullJson.Text)
        NextSpriteButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CharacterContainer.Children.NextSpriteButton.ClickedImage)
    End Sub

    Private Sub NextSpriteButton_MouseHover(sender As Object, e As EventArgs) Handles NextSpriteButton.MouseHover
        Dim infoPull As CharacterCreationWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterCreationWindow)(fullJson.Text)
        NextSpriteButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CharacterContainer.Children.NextSpriteButton.HoveredImage)
    End Sub

    Private Sub NextSpriteButton_MouseUp(sender As Object, e As MouseEventArgs) Handles NextSpriteButton.MouseUp
        Dim infoPull As CharacterCreationWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterCreationWindow)(fullJson.Text)
        NextSpriteButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CharacterContainer.Children.NextSpriteButton.HoveredImage)
    End Sub

    Private Sub NextSpriteButton_MouseLeave(sender As Object, e As EventArgs) Handles NextSpriteButton.MouseLeave
        Dim infoPull As CharacterCreationWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterCreationWindow)(fullJson.Text)
        NextSpriteButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CharacterContainer.Children.NextSpriteButton.NormalImage)
    End Sub

    Private Sub PreviousSpriteButton_Click(sender As Object, e As EventArgs) Handles PreviousSpriteButton.Click
        Dim infoPull As CharacterCreationWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterCreationWindow)(fullJson.Text)
        PreviousSpriteButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CharacterContainer.Children.PreviousSpriteButton.ClickedImage)
    End Sub

    Private Sub PreviousSpriteButton_MouseDown(sender As Object, e As MouseEventArgs) Handles PreviousSpriteButton.MouseDown
        Dim infoPull As CharacterCreationWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterCreationWindow)(fullJson.Text)
        PreviousSpriteButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CharacterContainer.Children.PreviousSpriteButton.ClickedImage)
    End Sub

    Private Sub PreviousSpriteButton_MouseHover(sender As Object, e As EventArgs) Handles PreviousSpriteButton.MouseHover
        Dim infoPull As CharacterCreationWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterCreationWindow)(fullJson.Text)
        PreviousSpriteButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CharacterContainer.Children.PreviousSpriteButton.HoveredImage)
    End Sub

    Private Sub PreviousSpriteButton_MouseUp(sender As Object, e As MouseEventArgs) Handles PreviousSpriteButton.MouseUp
        Dim infoPull As CharacterCreationWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterCreationWindow)(fullJson.Text)
        PreviousSpriteButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CharacterContainer.Children.PreviousSpriteButton.HoveredImage)
    End Sub

    Private Sub PreviousSpriteButton_MouseLeave(sender As Object, e As EventArgs) Handles PreviousSpriteButton.MouseLeave
        Dim infoPull As CharacterCreationWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterCreationWindow)(fullJson.Text)
        PreviousSpriteButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CharacterContainer.Children.PreviousSpriteButton.NormalImage)
    End Sub

    Private Sub MeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles gridToggle.Click
        If gridoverlay Then
            gridoverlay = False
            Select Case guitype
                Case "menu"
                    toolSplitContainer.Panel2.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\background.png")
                Case "game"
                    toolSplitContainer.Panel2.BackColor = Color.Gray
                    toolSplitContainer.Panel2.BackgroundImage = Nothing
            End Select
        Else
            gridoverlay = True
            toolSplitContainer.Panel2.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\grid_overlay.png")
        End If
    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        NewButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.NewButton.ClickedImage)
    End Sub

    Private Sub NewButton_MouseDown(sender As Object, e As MouseEventArgs) Handles NewButton.MouseDown
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        NewButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.NewButton.ClickedImage)
    End Sub

    Private Sub NewButton_MouseUp(sender As Object, e As MouseEventArgs) Handles NewButton.MouseUp
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        NewButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.NewButton.HoveredImage)
    End Sub

    Private Sub NewButton_MouseHover(sender As Object, e As EventArgs) Handles NewButton.MouseHover
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        NewButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.NewButton.HoveredImage)
    End Sub

    Private Sub NewButton_MouseLeave(sender As Object, e As EventArgs) Handles NewButton.MouseLeave
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        NewButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.NewButton.NormalImage)
    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        PlayButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.PlayButton.ClickedImage)
    End Sub

    Private Sub PlayButton_MouseDown(sender As Object, e As MouseEventArgs) Handles PlayButton.MouseDown
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        PlayButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.PlayButton.ClickedImage)
    End Sub

    Private Sub PlayButton_MouseUp(sender As Object, e As MouseEventArgs) Handles PlayButton.MouseUp
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        PlayButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.PlayButton.HoveredImage)
    End Sub

    Private Sub PlayButton_MouseHover(sender As Object, e As EventArgs) Handles PlayButton.MouseHover
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        PlayButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.PlayButton.HoveredImage)
    End Sub

    Private Sub PlayButton_MouseLeave(sender As Object, e As EventArgs) Handles PlayButton.MouseLeave
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        PlayButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.PlayButton.NormalImage)
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        DeleteButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.DeleteButton.ClickedImage)
    End Sub

    Private Sub DeleteButton_MouseDown(sender As Object, e As MouseEventArgs) Handles DeleteButton.MouseDown
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        DeleteButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.DeleteButton.ClickedImage)
    End Sub

    Private Sub DeleteButton_MouseUp(sender As Object, e As MouseEventArgs) Handles DeleteButton.MouseUp
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        DeleteButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.DeleteButton.HoveredImage)
    End Sub

    Private Sub DeleteButton_MouseHover(sender As Object, e As EventArgs) Handles DeleteButton.MouseHover
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        DeleteButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.DeleteButton.HoveredImage)
    End Sub

    Private Sub DeleteButton_MouseLeave(sender As Object, e As EventArgs) Handles DeleteButton.MouseLeave
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        DeleteButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.DeleteButton.NormalImage)
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        LogoutButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.LogoutButton.ClickedImage)
    End Sub

    Private Sub LogoutButton_MouseDown(sender As Object, e As MouseEventArgs) Handles LogoutButton.MouseDown
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        LogoutButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.LogoutButton.ClickedImage)
    End Sub

    Private Sub LogoutButton_MouseUp(sender As Object, e As MouseEventArgs) Handles LogoutButton.MouseUp
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        LogoutButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.LogoutButton.HoveredImage)
    End Sub

    Private Sub LogoutButton_MouseHover(sender As Object, e As EventArgs) Handles LogoutButton.MouseHover
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        LogoutButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.LogoutButton.HoveredImage)
    End Sub

    Private Sub LogoutButton_MouseLeave(sender As Object, e As EventArgs) Handles LogoutButton.MouseLeave
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        LogoutButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.LogoutButton.NormalImage)
    End Sub

    Private Sub NextCharacterButton_Click(sender As Object, e As EventArgs) Handles NextCharacterButton.Click
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        NextCharacterButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CharacterContainer.Children.NextCharacterButton.ClickedImage)
    End Sub

    Private Sub NextCharacterButton_MouseDown(sender As Object, e As MouseEventArgs) Handles NextCharacterButton.MouseDown
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        NextCharacterButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CharacterContainer.Children.NextCharacterButton.ClickedImage)
    End Sub

    Private Sub NextCharacterButton_MouseUp(sender As Object, e As MouseEventArgs) Handles NextCharacterButton.MouseUp
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        NextCharacterButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CharacterContainer.Children.NextCharacterButton.HoveredImage)
    End Sub

    Private Sub NextCharacterButton_MouseHover(sender As Object, e As EventArgs) Handles NextCharacterButton.MouseHover
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        NextCharacterButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CharacterContainer.Children.NextCharacterButton.HoveredImage)
    End Sub

    Private Sub NextCharacterButton_MouseLeave(sender As Object, e As EventArgs) Handles NextCharacterButton.MouseLeave
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        NextCharacterButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CharacterContainer.Children.NextCharacterButton.NormalImage)
    End Sub

    Private Sub PreviousCharacterButton_Click(sender As Object, e As EventArgs) Handles PreviousCharacterButton.Click
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        PreviousCharacterButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CharacterContainer.Children.PreviousCharacterButton.ClickedImage)
    End Sub

    Private Sub PreviousCharacterButton_MouseDown(sender As Object, e As MouseEventArgs) Handles PreviousCharacterButton.MouseDown
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        PreviousCharacterButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CharacterContainer.Children.PreviousCharacterButton.ClickedImage)
    End Sub

    Private Sub PreviousCharacterButton_MouseUp(sender As Object, e As MouseEventArgs) Handles PreviousCharacterButton.MouseUp
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        PreviousCharacterButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CharacterContainer.Children.PreviousCharacterButton.HoveredImage)
    End Sub

    Private Sub PreviousCharacterButton_MouseHover(sender As Object, e As EventArgs) Handles PreviousCharacterButton.MouseHover
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        PreviousCharacterButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CharacterContainer.Children.PreviousCharacterButton.HoveredImage)
    End Sub

    Private Sub PreviousCharacterButton_MouseLeave(sender As Object, e As EventArgs) Handles PreviousCharacterButton.MouseLeave
        Dim infoPull As CharacterSelectionWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterSelectionWindow)(fullJson.Text)
        PreviousCharacterButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CharacterContainer.Children.PreviousCharacterButton.NormalImage)
    End Sub

    Private Sub CreditsBackButton_Click(sender As Object, e As EventArgs) Handles CreditsBackButton.Click
        Dim infoPull As CreditsWindow
        infoPull = JsonConvert.DeserializeObject(Of CreditsWindow)(fullJson.Text)
        CreditsBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.ClickedImage)
    End Sub

    Private Sub CreditsBackButton_MouseDown(sender As Object, e As MouseEventArgs) Handles CreditsBackButton.MouseDown
        Dim infoPull As CreditsWindow
        infoPull = JsonConvert.DeserializeObject(Of CreditsWindow)(fullJson.Text)
        CreditsBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.ClickedImage)
    End Sub

    Private Sub CreditsBackButton_MouseUp(sender As Object, e As MouseEventArgs) Handles CreditsBackButton.MouseUp
        Dim infoPull As CreditsWindow
        infoPull = JsonConvert.DeserializeObject(Of CreditsWindow)(fullJson.Text)
        CreditsBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.HoveredImage)
    End Sub

    Private Sub CreditsBackButton_MouseHover(sender As Object, e As EventArgs) Handles CreditsBackButton.MouseHover
        Dim infoPull As CreditsWindow
        infoPull = JsonConvert.DeserializeObject(Of CreditsWindow)(fullJson.Text)
        CreditsBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.HoveredImage)
    End Sub

    Private Sub CreditsBackButton_MouseLeave(sender As Object, e As EventArgs) Handles CreditsBackButton.MouseLeave
        Dim infoPull As CreditsWindow
        infoPull = JsonConvert.DeserializeObject(Of CreditsWindow)(fullJson.Text)
        CreditsBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.NormalImage)
    End Sub

    Private Sub ForgotPasswordSubmitButton_Click(sender As Object, e As EventArgs) Handles ForgotPasswordSubmitButton.Click
        Dim infoPull As ForgotPasswordWindow
        infoPull = JsonConvert.DeserializeObject(Of ForgotPasswordWindow)(fullJson.Text)
        ForgotPasswordSubmitButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.SubmitButton.ClickedImage)
    End Sub

    Private Sub ForgotPasswordSubmitButton_MouseDown(sender As Object, e As MouseEventArgs) Handles ForgotPasswordSubmitButton.MouseDown
        Dim infoPull As ForgotPasswordWindow
        infoPull = JsonConvert.DeserializeObject(Of ForgotPasswordWindow)(fullJson.Text)
        ForgotPasswordSubmitButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.SubmitButton.ClickedImage)
    End Sub

    Private Sub ForgotPasswordSubmitButton_MouseUp(sender As Object, e As MouseEventArgs) Handles ForgotPasswordSubmitButton.MouseUp
        Dim infoPull As ForgotPasswordWindow
        infoPull = JsonConvert.DeserializeObject(Of ForgotPasswordWindow)(fullJson.Text)
        ForgotPasswordSubmitButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.SubmitButton.HoveredImage)
    End Sub

    Private Sub ForgotPasswordSubmitButton_MouseHover(sender As Object, e As EventArgs) Handles ForgotPasswordSubmitButton.MouseHover
        Dim infoPull As ForgotPasswordWindow
        infoPull = JsonConvert.DeserializeObject(Of ForgotPasswordWindow)(fullJson.Text)
        ForgotPasswordSubmitButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.SubmitButton.HoveredImage)
    End Sub

    Private Sub ForgotPasswordSubmitButton_MouseLeave(sender As Object, e As EventArgs) Handles ForgotPasswordSubmitButton.MouseLeave
        Dim infoPull As ForgotPasswordWindow
        infoPull = JsonConvert.DeserializeObject(Of ForgotPasswordWindow)(fullJson.Text)
        ForgotPasswordSubmitButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.SubmitButton.NormalImage)
    End Sub

    Private Sub ForgotPasswordBackButton_Click(sender As Object, e As EventArgs) Handles ForgotPasswordBackButton.Click
        Dim infoPull As ForgotPasswordWindow
        infoPull = JsonConvert.DeserializeObject(Of ForgotPasswordWindow)(fullJson.Text)
        ForgotPasswordBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.ClickedImage)
    End Sub

    Private Sub ForgotPasswordBackButton_MouseDown(sender As Object, e As MouseEventArgs) Handles ForgotPasswordBackButton.MouseDown
        Dim infoPull As ForgotPasswordWindow
        infoPull = JsonConvert.DeserializeObject(Of ForgotPasswordWindow)(fullJson.Text)
        ForgotPasswordBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.ClickedImage)
    End Sub

    Private Sub ForgotPasswordBackButton_MouseUp(sender As Object, e As MouseEventArgs) Handles ForgotPasswordBackButton.MouseUp
        Dim infoPull As ForgotPasswordWindow
        infoPull = JsonConvert.DeserializeObject(Of ForgotPasswordWindow)(fullJson.Text)
        ForgotPasswordBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.HoveredImage)
    End Sub

    Private Sub ForgotPasswordBackButton_MouseHover(sender As Object, e As EventArgs) Handles ForgotPasswordBackButton.MouseHover
        Dim infoPull As ForgotPasswordWindow
        infoPull = JsonConvert.DeserializeObject(Of ForgotPasswordWindow)(fullJson.Text)
        ForgotPasswordBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.HoveredImage)
    End Sub

    Private Sub ForgotPasswordBackButton_MouseLeave(sender As Object, e As EventArgs) Handles ForgotPasswordBackButton.MouseLeave
        Dim infoPull As ForgotPasswordWindow
        infoPull = JsonConvert.DeserializeObject(Of ForgotPasswordWindow)(fullJson.Text)
        ForgotPasswordBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.NormalImage)
    End Sub

    Private Sub MainMenuLoginButton_Click(sender As Object, e As EventArgs) Handles MainMenuLoginButton.Click
        Dim infoPull As MenuWindow
        infoPull = JsonConvert.DeserializeObject(Of MenuWindow)(fullJson.Text)
        MainMenuLoginButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.LoginButton.ClickedImage)
    End Sub

    Private Sub MainMenuLoginButton_MouseDown(sender As Object, e As MouseEventArgs) Handles MainMenuLoginButton.MouseDown
        Dim infoPull As MenuWindow
        infoPull = JsonConvert.DeserializeObject(Of MenuWindow)(fullJson.Text)
        MainMenuLoginButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.LoginButton.ClickedImage)
    End Sub

    Private Sub MainMenuLoginButton_MouseUp(sender As Object, e As MouseEventArgs) Handles MainMenuLoginButton.MouseUp
        Dim infoPull As MenuWindow
        infoPull = JsonConvert.DeserializeObject(Of MenuWindow)(fullJson.Text)
        MainMenuLoginButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.LoginButton.HoveredImage)
    End Sub

    Private Sub MainMenuLoginButton_MouseHover(sender As Object, e As EventArgs) Handles MainMenuLoginButton.MouseHover
        Dim infoPull As MenuWindow
        infoPull = JsonConvert.DeserializeObject(Of MenuWindow)(fullJson.Text)
        MainMenuLoginButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.LoginButton.HoveredImage)
    End Sub

    Private Sub MainMenuLoginButton_MouseLeave(sender As Object, e As EventArgs) Handles MainMenuLoginButton.MouseLeave
        Dim infoPull As MenuWindow
        infoPull = JsonConvert.DeserializeObject(Of MenuWindow)(fullJson.Text)
        MainMenuLoginButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.LoginButton.NormalImage)
    End Sub

    Private Sub MainMenuRegisterButton_Click(sender As Object, e As EventArgs) Handles MainMenuRegisterButton.Click
        Dim infoPull As MenuWindow
        infoPull = JsonConvert.DeserializeObject(Of MenuWindow)(fullJson.Text)
        MainMenuRegisterButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.RegisterButton.ClickedImage)
    End Sub

    Private Sub MainMenuRegisterButton_MouseDown(sender As Object, e As MouseEventArgs) Handles MainMenuRegisterButton.MouseDown
        Dim infoPull As MenuWindow
        infoPull = JsonConvert.DeserializeObject(Of MenuWindow)(fullJson.Text)
        MainMenuRegisterButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.RegisterButton.ClickedImage)
    End Sub

    Private Sub MainMenuRegisterButton_MouseUp(sender As Object, e As MouseEventArgs) Handles MainMenuRegisterButton.MouseUp
        Dim infoPull As MenuWindow
        infoPull = JsonConvert.DeserializeObject(Of MenuWindow)(fullJson.Text)
        MainMenuRegisterButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.RegisterButton.HoveredImage)
    End Sub

    Private Sub MainMenuRegisterButton_MouseHover(sender As Object, e As EventArgs) Handles MainMenuRegisterButton.MouseHover
        Dim infoPull As MenuWindow
        infoPull = JsonConvert.DeserializeObject(Of MenuWindow)(fullJson.Text)
        MainMenuRegisterButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.RegisterButton.HoveredImage)
    End Sub

    Private Sub MainMenuRegisterButton_MouseLeave(sender As Object, e As EventArgs) Handles MainMenuRegisterButton.MouseLeave
        Dim infoPull As MenuWindow
        infoPull = JsonConvert.DeserializeObject(Of MenuWindow)(fullJson.Text)
        MainMenuRegisterButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.RegisterButton.NormalImage)
    End Sub

    Private Sub MainMenuOptionsButton_Click(sender As Object, e As EventArgs) Handles MainMenuOptionsButton.Click
        Dim infoPull As MenuWindow
        infoPull = JsonConvert.DeserializeObject(Of MenuWindow)(fullJson.Text)
        MainMenuOptionsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsButton.ClickedImage)
    End Sub

    Private Sub MainMenuOptionsButton_MouseDown(sender As Object, e As MouseEventArgs) Handles MainMenuOptionsButton.MouseDown
        Dim infoPull As MenuWindow
        infoPull = JsonConvert.DeserializeObject(Of MenuWindow)(fullJson.Text)
        MainMenuOptionsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsButton.ClickedImage)
    End Sub

    Private Sub MainMenuOptionsButton_MouseUp(sender As Object, e As MouseEventArgs) Handles MainMenuOptionsButton.MouseUp
        Dim infoPull As MenuWindow
        infoPull = JsonConvert.DeserializeObject(Of MenuWindow)(fullJson.Text)
        MainMenuOptionsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsButton.HoveredImage)
    End Sub

    Private Sub MainMenuOptionsButton_MouseHover(sender As Object, e As EventArgs) Handles MainMenuOptionsButton.MouseHover
        Dim infoPull As MenuWindow
        infoPull = JsonConvert.DeserializeObject(Of MenuWindow)(fullJson.Text)
        MainMenuOptionsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsButton.HoveredImage)
    End Sub

    Private Sub MainMenuOptionsButton_MouseLeave(sender As Object, e As EventArgs) Handles MainMenuOptionsButton.MouseLeave
        Dim infoPull As MenuWindow
        infoPull = JsonConvert.DeserializeObject(Of MenuWindow)(fullJson.Text)
        MainMenuOptionsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsButton.NormalImage)
    End Sub

    Private Sub MainMenuCreditsButton_Click(sender As Object, e As EventArgs) Handles MainMenuCreditsButton.Click
        Dim infoPull As MenuWindow
        infoPull = JsonConvert.DeserializeObject(Of MenuWindow)(fullJson.Text)
        MainMenuCreditsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CreditsButton.ClickedImage)
    End Sub

    Private Sub MainMenuCreditsButton_MouseDown(sender As Object, e As MouseEventArgs) Handles MainMenuCreditsButton.MouseDown
        Dim infoPull As MenuWindow
        infoPull = JsonConvert.DeserializeObject(Of MenuWindow)(fullJson.Text)
        MainMenuCreditsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CreditsButton.ClickedImage)
    End Sub

    Private Sub MainMenuCreditsButton_MouseUp(sender As Object, e As MouseEventArgs) Handles MainMenuCreditsButton.MouseUp
        Dim infoPull As MenuWindow
        infoPull = JsonConvert.DeserializeObject(Of MenuWindow)(fullJson.Text)
        MainMenuCreditsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CreditsButton.HoveredImage)
    End Sub

    Private Sub MainMenuCreditsButton_MouseHover(sender As Object, e As EventArgs) Handles MainMenuCreditsButton.MouseHover
        Dim infoPull As MenuWindow
        infoPull = JsonConvert.DeserializeObject(Of MenuWindow)(fullJson.Text)
        MainMenuCreditsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CreditsButton.HoveredImage)
    End Sub

    Private Sub MainMenuCreditsButton_MouseLeave(sender As Object, e As EventArgs) Handles MainMenuCreditsButton.MouseLeave
        Dim infoPull As MenuWindow
        infoPull = JsonConvert.DeserializeObject(Of MenuWindow)(fullJson.Text)
        MainMenuCreditsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CreditsButton.NormalImage)
    End Sub

    Private Sub MainMenuExitButton_Click(sender As Object, e As EventArgs) Handles MainMenuExitButton.Click
        Dim infoPull As MenuWindow
        infoPull = JsonConvert.DeserializeObject(Of MenuWindow)(fullJson.Text)
        MainMenuExitButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.ExitButton.ClickedImage)
    End Sub

    Private Sub MainMenuExitButton_MouseDown(sender As Object, e As MouseEventArgs) Handles MainMenuExitButton.MouseDown
        Dim infoPull As MenuWindow
        infoPull = JsonConvert.DeserializeObject(Of MenuWindow)(fullJson.Text)
        MainMenuExitButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.ExitButton.ClickedImage)
    End Sub

    Private Sub MainMenuExitButton_MouseUp(sender As Object, e As MouseEventArgs) Handles MainMenuExitButton.MouseUp
        Dim infoPull As MenuWindow
        infoPull = JsonConvert.DeserializeObject(Of MenuWindow)(fullJson.Text)
        MainMenuExitButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.ExitButton.HoveredImage)
    End Sub

    Private Sub MainMenuExitButton_MouseHover(sender As Object, e As EventArgs) Handles MainMenuExitButton.MouseHover
        Dim infoPull As MenuWindow
        infoPull = JsonConvert.DeserializeObject(Of MenuWindow)(fullJson.Text)
        MainMenuExitButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.ExitButton.HoveredImage)
    End Sub

    Private Sub MainMenuExitButton_MouseLeave(sender As Object, e As EventArgs) Handles MainMenuExitButton.MouseLeave
        Dim infoPull As MenuWindow
        infoPull = JsonConvert.DeserializeObject(Of MenuWindow)(fullJson.Text)
        MainMenuExitButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.ExitButton.NormalImage)
    End Sub

    Private Sub SoundSliderBar_Click(sender As Object, e As EventArgs) Handles SoundSliderBar.Click
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        SoundSliderBar.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.SoundSlider.SliderBar.ClickedImage)
    End Sub

    Private Sub SoundSliderBar_MouseDown(sender As Object, e As MouseEventArgs) Handles SoundSliderBar.MouseDown
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        SoundSliderBar.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.SoundSlider.SliderBar.ClickedImage)
    End Sub

    Private Sub SoundSliderBar_MouseUp(sender As Object, e As MouseEventArgs) Handles SoundSliderBar.MouseUp
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        SoundSliderBar.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.SoundSlider.SliderBar.HoveredImage)
    End Sub

    Private Sub SoundSliderBar_MouseHover(sender As Object, e As EventArgs) Handles SoundSliderBar.MouseHover
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        SoundSliderBar.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.SoundSlider.SliderBar.HoveredImage)
    End Sub

    Private Sub SoundSliderBar_MouseLeave(sender As Object, e As EventArgs) Handles SoundSliderBar.MouseLeave
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        SoundSliderBar.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.SoundSlider.SliderBar.NormalImage)
    End Sub

    Private Sub MusicSliderBar_Click(sender As Object, e As EventArgs) Handles MusicSliderBar.Click
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        MusicSliderBar.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.MusicSlider.SliderBar.ClickedImage)
    End Sub

    Private Sub MusicSliderBar_MouseDown(sender As Object, e As MouseEventArgs) Handles MusicSliderBar.MouseDown
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        MusicSliderBar.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.MusicSlider.SliderBar.ClickedImage)
    End Sub

    Private Sub MusicSliderBar_MouseUp(sender As Object, e As MouseEventArgs) Handles MusicSliderBar.MouseUp
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        MusicSliderBar.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.MusicSlider.SliderBar.HoveredImage)
    End Sub

    Private Sub MusicSliderBar_MouseHover(sender As Object, e As EventArgs) Handles MusicSliderBar.MouseHover
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        MusicSliderBar.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.MusicSlider.SliderBar.HoveredImage)
    End Sub

    Private Sub MusicSliderBar_MouseLeave(sender As Object, e As EventArgs) Handles MusicSliderBar.MouseLeave
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        MusicSliderBar.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.MusicSlider.SliderBar.NormalImage)
    End Sub

    Private Sub KeybindingsButton_Click(sender As Object, e As EventArgs) Handles KeybindingsButton.Click
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        KeybindingsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.KeybindingsButton.ClickedImage)
        MainControlPanelsWindow.Visible = True
    End Sub

    Private Sub KeybindingsButton_MouseDown(sender As Object, e As MouseEventArgs) Handles KeybindingsButton.MouseDown
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        KeybindingsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.KeybindingsButton.ClickedImage)
    End Sub

    Private Sub KeybindingsButton_MouseUp(sender As Object, e As MouseEventArgs) Handles KeybindingsButton.MouseUp
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        KeybindingsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.KeybindingsButton.HoveredImage)
    End Sub

    Private Sub KeybindingsButton_MouseHover(sender As Object, e As EventArgs) Handles KeybindingsButton.MouseHover
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        KeybindingsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.KeybindingsButton.HoveredImage)
    End Sub

    Private Sub KeybindingsButton_MouseLeave(sender As Object, e As EventArgs) Handles KeybindingsButton.MouseLeave
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        KeybindingsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.KeybindingsButton.NormalImage)
    End Sub

    Private Sub OptionsApplyButton_Click(sender As Object, e As EventArgs) Handles OptionsApplyButton.Click
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        OptionsApplyButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.ApplyButton.ClickedImage)
    End Sub

    Private Sub OptionsApplyButton_MouseDown(sender As Object, e As MouseEventArgs) Handles OptionsApplyButton.MouseDown
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        OptionsApplyButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.ApplyButton.ClickedImage)
    End Sub

    Private Sub OptionsApplyButton_MouseUp(sender As Object, e As MouseEventArgs) Handles OptionsApplyButton.MouseUp
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        OptionsApplyButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.ApplyButton.HoveredImage)
    End Sub

    Private Sub OptionsApplyButton_MouseHover(sender As Object, e As EventArgs) Handles OptionsApplyButton.MouseHover
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        OptionsApplyButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.ApplyButton.HoveredImage)
    End Sub

    Private Sub OptionsApplyButton_MouseLeave(sender As Object, e As EventArgs) Handles OptionsApplyButton.MouseLeave
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        OptionsApplyButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.ApplyButton.NormalImage)
    End Sub

    Private Sub OptionsCancelButton_Click(sender As Object, e As EventArgs) Handles OptionsCancelButton.Click
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        OptionsCancelButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.CancelButton.ClickedImage)
    End Sub

    Private Sub OptionsCancelButton_MouseDown(sender As Object, e As MouseEventArgs) Handles OptionsCancelButton.MouseDown
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        OptionsCancelButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.CancelButton.ClickedImage)
    End Sub

    Private Sub OptionsCancelButton_MouseUp(sender As Object, e As MouseEventArgs) Handles OptionsCancelButton.MouseUp
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        OptionsCancelButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.CancelButton.HoveredImage)
    End Sub

    Private Sub OptionsCancelButton_MouseHover(sender As Object, e As EventArgs) Handles OptionsCancelButton.MouseHover
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        OptionsCancelButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.CancelButton.HoveredImage)
    End Sub

    Private Sub OptionsCancelButton_MouseLeave(sender As Object, e As EventArgs) Handles OptionsCancelButton.MouseLeave
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        OptionsCancelButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.CancelButton.NormalImage)
    End Sub

    Private Sub FullscreenCheckboxCheckbox_Click(sender As Object, e As EventArgs) Handles FullscreenCheckboxCheckbox.Click
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        If fullscreenchecked Then
            FullscreenCheckboxCheckbox.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.FullscreenCheckbox.Checkbox.NormalImage)
            fullscreenchecked = False
        Else
            FullscreenCheckboxCheckbox.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.FullscreenCheckbox.Checkbox.CheckedImage)
            fullscreenchecked = True
        End If
    End Sub

    Private Sub AutocloseWindowsCheckboxCheckbox_Click(sender As Object, e As EventArgs) Handles AutocloseWindowsCheckboxCheckbox.Click
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        If autoclosewindowschecked Then
            AutocloseWindowsCheckboxCheckbox.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.AutocloseWindowsCheckbox.Checkbox.NormalImage)
            autoclosewindowschecked = False
        Else
            AutocloseWindowsCheckboxCheckbox.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsContainer.InnerPanel.Children.AutocloseWindowsCheckbox.Checkbox.CheckedImage)
            autoclosewindowschecked = True
        End If
    End Sub

    Private Sub RegistrationRegisterButton_Click(sender As Object, e As EventArgs) Handles RegistrationRegisterButton.Click
        Dim infoPull As RegistrationWindow
        infoPull = JsonConvert.DeserializeObject(Of RegistrationWindow)(fullJson.Text)
        RegistrationRegisterButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.RegisterButton.ClickedImage)
    End Sub

    Private Sub RegistrationRegisterButton_MouseDown(sender As Object, e As MouseEventArgs) Handles RegistrationRegisterButton.MouseDown
        Dim infoPull As RegistrationWindow
        infoPull = JsonConvert.DeserializeObject(Of RegistrationWindow)(fullJson.Text)
        RegistrationRegisterButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.RegisterButton.ClickedImage)
    End Sub

    Private Sub RegistrationRegisterButton_MouseUp(sender As Object, e As MouseEventArgs) Handles RegistrationRegisterButton.MouseUp
        Dim infoPull As RegistrationWindow
        infoPull = JsonConvert.DeserializeObject(Of RegistrationWindow)(fullJson.Text)
        RegistrationRegisterButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.RegisterButton.HoveredImage)
    End Sub

    Private Sub RegistrationRegisterButton_MouseHover(sender As Object, e As EventArgs) Handles RegistrationRegisterButton.MouseHover
        Dim infoPull As RegistrationWindow
        infoPull = JsonConvert.DeserializeObject(Of RegistrationWindow)(fullJson.Text)
        RegistrationRegisterButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.RegisterButton.HoveredImage)
    End Sub

    Private Sub RegistrationRegisterButton_MouseLeave(sender As Object, e As EventArgs) Handles RegistrationRegisterButton.MouseLeave
        Dim infoPull As RegistrationWindow
        infoPull = JsonConvert.DeserializeObject(Of RegistrationWindow)(fullJson.Text)
        RegistrationRegisterButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.RegisterButton.NormalImage)
    End Sub

    Private Sub RegistrationBackButton_Click(sender As Object, e As EventArgs) Handles RegistrationBackButton.Click
        Dim infoPull As RegistrationWindow
        infoPull = JsonConvert.DeserializeObject(Of RegistrationWindow)(fullJson.Text)
        RegistrationBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.ClickedImage)
    End Sub

    Private Sub RegistrationBackButton_MouseDown(sender As Object, e As MouseEventArgs) Handles RegistrationBackButton.MouseDown
        Dim infoPull As RegistrationWindow
        infoPull = JsonConvert.DeserializeObject(Of RegistrationWindow)(fullJson.Text)
        RegistrationBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.ClickedImage)
    End Sub

    Private Sub RegistrationBackButton_MouseUp(sender As Object, e As MouseEventArgs) Handles RegistrationBackButton.MouseUp
        Dim infoPull As RegistrationWindow
        infoPull = JsonConvert.DeserializeObject(Of RegistrationWindow)(fullJson.Text)
        RegistrationBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.HoveredImage)
    End Sub

    Private Sub RegistrationBackButton_MouseHover(sender As Object, e As EventArgs) Handles RegistrationBackButton.MouseHover
        Dim infoPull As RegistrationWindow
        infoPull = JsonConvert.DeserializeObject(Of RegistrationWindow)(fullJson.Text)
        RegistrationBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.HoveredImage)
    End Sub

    Private Sub RegistrationBackButton_MouseLeave(sender As Object, e As EventArgs) Handles RegistrationBackButton.MouseLeave
        Dim infoPull As RegistrationWindow
        infoPull = JsonConvert.DeserializeObject(Of RegistrationWindow)(fullJson.Text)
        RegistrationBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.NormalImage)
    End Sub

    Private Sub ResetSubmitButton_Click(sender As Object, e As EventArgs) Handles ResetSubmitButton.Click
        Dim infoPull As ResetPasswordWindow
        infoPull = JsonConvert.DeserializeObject(Of ResetPasswordWindow)(fullJson.Text)
        ResetSubmitButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.SubmitButton.ClickedImage)
    End Sub

    Private Sub ResetSubmitButton_MouseDown(sender As Object, e As MouseEventArgs) Handles ResetSubmitButton.MouseDown
        Dim infoPull As ResetPasswordWindow
        infoPull = JsonConvert.DeserializeObject(Of ResetPasswordWindow)(fullJson.Text)
        ResetSubmitButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.SubmitButton.ClickedImage)
    End Sub

    Private Sub ResetSubmitButton_MouseUp(sender As Object, e As MouseEventArgs) Handles ResetSubmitButton.MouseUp
        Dim infoPull As ResetPasswordWindow
        infoPull = JsonConvert.DeserializeObject(Of ResetPasswordWindow)(fullJson.Text)
        ResetSubmitButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.SubmitButton.HoveredImage)
    End Sub

    Private Sub ResetSubmitButton_MouseHover(sender As Object, e As EventArgs) Handles ResetSubmitButton.MouseHover
        Dim infoPull As ResetPasswordWindow
        infoPull = JsonConvert.DeserializeObject(Of ResetPasswordWindow)(fullJson.Text)
        ResetSubmitButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.SubmitButton.HoveredImage)
    End Sub

    Private Sub ResetSubmitButton_MouseLeave(sender As Object, e As EventArgs) Handles ResetSubmitButton.MouseLeave
        Dim infoPull As ResetPasswordWindow
        infoPull = JsonConvert.DeserializeObject(Of ResetPasswordWindow)(fullJson.Text)
        ResetSubmitButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.SubmitButton.NormalImage)
    End Sub

    Private Sub ResetBackButton_Click(sender As Object, e As EventArgs) Handles ResetBackButton.Click
        Dim infoPull As ResetPasswordWindow
        infoPull = JsonConvert.DeserializeObject(Of ResetPasswordWindow)(fullJson.Text)
        ResetBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.ClickedImage)
    End Sub

    Private Sub ResetBackButton_MouseDown(sender As Object, e As MouseEventArgs) Handles ResetBackButton.MouseDown
        Dim infoPull As ResetPasswordWindow
        infoPull = JsonConvert.DeserializeObject(Of ResetPasswordWindow)(fullJson.Text)
        ResetBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.ClickedImage)
    End Sub

    Private Sub ResetBackButton_MouseUp(sender As Object, e As MouseEventArgs) Handles ResetBackButton.MouseUp
        Dim infoPull As ResetPasswordWindow
        infoPull = JsonConvert.DeserializeObject(Of ResetPasswordWindow)(fullJson.Text)
        ResetBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.HoveredImage)
    End Sub

    Private Sub ResetBackButton_MouseHover(sender As Object, e As EventArgs) Handles ResetBackButton.MouseHover
        Dim infoPull As ResetPasswordWindow
        infoPull = JsonConvert.DeserializeObject(Of ResetPasswordWindow)(fullJson.Text)
        ResetBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.HoveredImage)
    End Sub

    Private Sub ResetBackButton_MouseLeave(sender As Object, e As EventArgs) Handles ResetBackButton.MouseLeave
        Dim infoPull As ResetPasswordWindow
        infoPull = JsonConvert.DeserializeObject(Of ResetPasswordWindow)(fullJson.Text)
        ResetBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.BackButton.NormalImage)
    End Sub

    Private Sub CancelControlsButton_Click(sender As Object, e As EventArgs) Handles CancelControlsButton.Click
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        CancelControlsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CancelControlsButton.ClickedImage)
        MainControlPanelsWindow.Visible = False
    End Sub

    Private Sub CancelControlsButton_MouseDown(sender As Object, e As MouseEventArgs) Handles CancelControlsButton.MouseDown
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        CancelControlsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CancelControlsButton.ClickedImage)
    End Sub

    Private Sub CancelControlsButton_MouseUp(sender As Object, e As MouseEventArgs) Handles CancelControlsButton.MouseUp
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        CancelControlsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CancelControlsButton.HoveredImage)
    End Sub

    Private Sub CancelControlsButton_MouseHover(sender As Object, e As EventArgs) Handles CancelControlsButton.MouseHover
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        CancelControlsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CancelControlsButton.HoveredImage)
    End Sub

    Private Sub CancelControlsButton_MouseLeave(sender As Object, e As EventArgs) Handles CancelControlsButton.MouseLeave
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        CancelControlsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CancelControlsButton.NormalImage)
    End Sub

    Private Sub ExitControlsButton_Click(sender As Object, e As EventArgs) Handles ExitControlsButton.Click
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        ExitControlsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.ExitControlsButton.ClickedImage)
    End Sub

    Private Sub ExitControlsButton_MouseDown(sender As Object, e As MouseEventArgs) Handles ExitControlsButton.MouseDown
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        ExitControlsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.ExitControlsButton.ClickedImage)
    End Sub

    Private Sub ExitControlsButton_MouseUp(sender As Object, e As MouseEventArgs) Handles ExitControlsButton.MouseUp
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        ExitControlsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.ExitControlsButton.HoveredImage)
    End Sub

    Private Sub ExitControlsButton_MouseHover(sender As Object, e As EventArgs) Handles ExitControlsButton.MouseHover
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        ExitControlsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.ExitControlsButton.HoveredImage)
    End Sub

    Private Sub ExitControlsButton_MouseLeave(sender As Object, e As EventArgs) Handles ExitControlsButton.MouseLeave
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        ExitControlsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.ExitControlsButton.NormalImage)
    End Sub

    Private Sub RestoreControlsButton_Click(sender As Object, e As EventArgs) Handles RestoreControlsButton.Click
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        RestoreControlsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.RestoreControlsButton.ClickedImage)
    End Sub

    Private Sub RestoreControlsButton_MouseDown(sender As Object, e As MouseEventArgs) Handles RestoreControlsButton.MouseDown
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        RestoreControlsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.RestoreControlsButton.ClickedImage)
    End Sub

    Private Sub RestoreControlsButton_MouseUp(sender As Object, e As MouseEventArgs) Handles RestoreControlsButton.MouseUp
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        RestoreControlsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.RestoreControlsButton.HoveredImage)
    End Sub

    Private Sub RestoreControlsButton_MouseHover(sender As Object, e As EventArgs) Handles RestoreControlsButton.MouseHover
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        RestoreControlsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.RestoreControlsButton.HoveredImage)
    End Sub

    Private Sub RestoreControlsButton_MouseLeave(sender As Object, e As EventArgs) Handles RestoreControlsButton.MouseLeave
        Dim infoPull As OptionsWindow
        infoPull = JsonConvert.DeserializeObject(Of OptionsWindow)(fullJson.Text)
        RestoreControlsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.RestoreControlsButton.NormalImage)
    End Sub

    Private Sub InputBoxCloseButton_Click(sender As Object, e As EventArgs) Handles InputBoxCloseButton.Click
        Dim infoPull As InputBox
        infoPull = JsonConvert.DeserializeObject(Of InputBox)(fullJson.Text)
        InputBoxCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Closebutton.ClickedImage)
    End Sub

    Private Sub InputBoxCloseButton_MouseDown(sender As Object, e As MouseEventArgs) Handles InputBoxCloseButton.MouseDown
        Dim infoPull As InputBox
        infoPull = JsonConvert.DeserializeObject(Of InputBox)(fullJson.Text)
        InputBoxCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Closebutton.ClickedImage)
    End Sub

    Private Sub InputBoxCloseButton_MouseUp(sender As Object, e As MouseEventArgs) Handles InputBoxCloseButton.MouseUp
        Dim infoPull As InputBox
        infoPull = JsonConvert.DeserializeObject(Of InputBox)(fullJson.Text)
        InputBoxCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Closebutton.HoveredImage)
    End Sub

    Private Sub InputBoxCloseButton_MouseHover(sender As Object, e As EventArgs) Handles InputBoxCloseButton.MouseHover
        Dim infoPull As InputBox
        infoPull = JsonConvert.DeserializeObject(Of InputBox)(fullJson.Text)
        InputBoxCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Closebutton.HoveredImage)
    End Sub

    Private Sub InputBoxCloseButton_MouseLeave(sender As Object, e As EventArgs) Handles InputBoxCloseButton.MouseLeave
        Dim infoPull As InputBox
        infoPull = JsonConvert.DeserializeObject(Of InputBox)(fullJson.Text)
        InputBoxCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Closebutton.NormalImage)
    End Sub

    Private Sub BagWindowCloseButton_Click(sender As Object, e As EventArgs) Handles BagWindowCloseButton.Click
        Dim infoPull As BagWindow
        infoPull = JsonConvert.DeserializeObject(Of BagWindow)(fullJson.Text)
        BagWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.ClickedImage)
    End Sub

    Private Sub BagWindowCloseButton_MouseDown(sender As Object, e As MouseEventArgs) Handles BagWindowCloseButton.MouseDown
        Dim infoPull As BagWindow
        infoPull = JsonConvert.DeserializeObject(Of BagWindow)(fullJson.Text)
        BagWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.ClickedImage)
    End Sub

    Private Sub BagWindowCloseButton_MouseUp(sender As Object, e As MouseEventArgs) Handles BagWindowCloseButton.MouseUp
        Dim infoPull As BagWindow
        infoPull = JsonConvert.DeserializeObject(Of BagWindow)(fullJson.Text)
        BagWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.HoveredImage)
    End Sub

    Private Sub BagWindowCloseButton_MouseHover(sender As Object, e As EventArgs) Handles BagWindowCloseButton.MouseHover
        Dim infoPull As BagWindow
        infoPull = JsonConvert.DeserializeObject(Of BagWindow)(fullJson.Text)
        BagWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.HoveredImage)
    End Sub

    Private Sub BagWindowCloseButton_MouseLeave(sender As Object, e As EventArgs) Handles BagWindowCloseButton.MouseLeave
        Dim infoPull As BagWindow
        infoPull = JsonConvert.DeserializeObject(Of BagWindow)(fullJson.Text)
        BagWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.NormalImage)
    End Sub

    Private Sub CharacterWindowCloseButton_Click(sender As Object, e As EventArgs) Handles CharacterWindowCloseButton.Click
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        CharacterWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.ClickedImage)
    End Sub

    Private Sub CharacterWindowCloseButton_MouseDown(sender As Object, e As MouseEventArgs) Handles CharacterWindowCloseButton.MouseDown
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        CharacterWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.ClickedImage)
    End Sub

    Private Sub CharacterWindowCloseButton_MouseUp(sender As Object, e As MouseEventArgs) Handles CharacterWindowCloseButton.MouseUp
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        CharacterWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.HoveredImage)
    End Sub

    Private Sub CharacterWindowCloseButton_MouseHover(sender As Object, e As EventArgs) Handles CharacterWindowCloseButton.MouseHover
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        CharacterWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.HoveredImage)
    End Sub

    Private Sub CharacterWindowCloseButton_MouseLeave(sender As Object, e As EventArgs) Handles CharacterWindowCloseButton.MouseLeave
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        CharacterWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.NormalImage)
    End Sub

    Private Sub IncreaseAttackButton_Click(sender As Object, e As EventArgs) Handles IncreaseAttackButton.Click
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        IncreaseAttackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.IncreaseAttackButton.ClickedImage)
    End Sub

    Private Sub IncreaseAttackButton_MouseDown(sender As Object, e As MouseEventArgs) Handles IncreaseAttackButton.MouseDown
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        IncreaseAttackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.IncreaseAttackButton.ClickedImage)
    End Sub

    Private Sub IncreaseAttackButton_MouseUp(sender As Object, e As MouseEventArgs) Handles IncreaseAttackButton.MouseUp
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        IncreaseAttackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.IncreaseAttackButton.HoveredImage)
    End Sub

    Private Sub IncreaseAttackButton_MouseHover(sender As Object, e As EventArgs) Handles IncreaseAttackButton.MouseHover
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        IncreaseAttackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.IncreaseAttackButton.HoveredImage)
    End Sub

    Private Sub IncreaseAttackButton_MouseLeave(sender As Object, e As EventArgs) Handles IncreaseAttackButton.MouseLeave
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        IncreaseAttackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.IncreaseAttackButton.NormalImage)
    End Sub

    Private Sub IncreaseDefenseButton_Click(sender As Object, e As EventArgs) Handles IncreaseDefenseButton.Click
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        IncreaseDefenseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.IncreaseDefenseButton.ClickedImage)
    End Sub

    Private Sub IncreaseDefenseButton_MouseDown(sender As Object, e As MouseEventArgs) Handles IncreaseDefenseButton.MouseDown
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        IncreaseDefenseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.IncreaseDefenseButton.ClickedImage)
    End Sub

    Private Sub IncreaseDefenseButton_MouseUp(sender As Object, e As MouseEventArgs) Handles IncreaseDefenseButton.MouseUp
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        IncreaseDefenseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.IncreaseDefenseButton.HoveredImage)
    End Sub

    Private Sub IncreaseDefenseButton_MouseHover(sender As Object, e As EventArgs) Handles IncreaseDefenseButton.MouseHover
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        IncreaseDefenseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.IncreaseDefenseButton.HoveredImage)
    End Sub

    Private Sub IncreaseDefenseButton_MouseLeave(sender As Object, e As EventArgs) Handles IncreaseDefenseButton.MouseLeave
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        IncreaseDefenseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.IncreaseDefenseButton.NormalImage)
    End Sub

    Private Sub IncreaseSpeedButton_Click(sender As Object, e As EventArgs) Handles IncreaseSpeedButton.Click
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        IncreaseSpeedButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.IncreaseSpeedButton.ClickedImage)
    End Sub

    Private Sub IncreaseSpeedButton_MouseDown(sender As Object, e As MouseEventArgs) Handles IncreaseSpeedButton.MouseDown
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        IncreaseSpeedButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.IncreaseSpeedButton.ClickedImage)
    End Sub

    Private Sub IncreaseSpeedButton_MouseUp(sender As Object, e As MouseEventArgs) Handles IncreaseSpeedButton.MouseUp
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        IncreaseSpeedButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.IncreaseSpeedButton.HoveredImage)
    End Sub

    Private Sub IncreaseSpeedButton_MouseHover(sender As Object, e As EventArgs) Handles IncreaseSpeedButton.MouseHover
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        IncreaseSpeedButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.IncreaseSpeedButton.HoveredImage)
    End Sub

    Private Sub IncreaseSpeedButton_MouseLeave(sender As Object, e As EventArgs) Handles IncreaseSpeedButton.MouseLeave
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        IncreaseSpeedButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.IncreaseSpeedButton.NormalImage)
    End Sub

    Private Sub IncreaseAbilityPowerButton_Click(sender As Object, e As EventArgs) Handles IncreaseAbilityPowerButton.Click
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        IncreaseAbilityPowerButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.IncreaseAbilityPowerButton.ClickedImage)
    End Sub

    Private Sub IncreaseAbilityPowerButton_MouseDown(sender As Object, e As MouseEventArgs) Handles IncreaseAbilityPowerButton.MouseDown
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        IncreaseAbilityPowerButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.IncreaseAbilityPowerButton.ClickedImage)
    End Sub

    Private Sub IncreaseAbilityPowerButton_MouseUp(sender As Object, e As MouseEventArgs) Handles IncreaseAbilityPowerButton.MouseUp
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        IncreaseAbilityPowerButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.IncreaseAbilityPowerButton.HoveredImage)
    End Sub

    Private Sub IncreaseAbilityPowerButton_MouseHover(sender As Object, e As EventArgs) Handles IncreaseAbilityPowerButton.MouseHover
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        IncreaseAbilityPowerButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.IncreaseAbilityPowerButton.HoveredImage)
    End Sub

    Private Sub IncreaseAbilityPowerButton_MouseLeave(sender As Object, e As EventArgs) Handles IncreaseAbilityPowerButton.MouseLeave
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        IncreaseAbilityPowerButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.IncreaseAbilityPowerButton.NormalImage)
    End Sub

    Private Sub IncreaseMagicResistButton_Click(sender As Object, e As EventArgs) Handles IncreaseMagicResistButton.Click
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        IncreaseMagicResistButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.IncreaseMagicResistButton.ClickedImage)
    End Sub

    Private Sub IncreaseMagicResistButton_MouseDown(sender As Object, e As MouseEventArgs) Handles IncreaseMagicResistButton.MouseDown
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        IncreaseMagicResistButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.IncreaseMagicResistButton.ClickedImage)
    End Sub

    Private Sub IncreaseMagicResistButton_MouseUp(sender As Object, e As MouseEventArgs) Handles IncreaseMagicResistButton.MouseUp
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        IncreaseMagicResistButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.IncreaseMagicResistButton.HoveredImage)
    End Sub

    Private Sub IncreaseMagicResistButton_MouseHover(sender As Object, e As EventArgs) Handles IncreaseMagicResistButton.MouseHover
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        IncreaseMagicResistButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.IncreaseMagicResistButton.HoveredImage)
    End Sub

    Private Sub IncreaseMagicResistButton_MouseLeave(sender As Object, e As EventArgs) Handles IncreaseMagicResistButton.MouseLeave
        Dim infoPull As CharacterWindow
        infoPull = JsonConvert.DeserializeObject(Of CharacterWindow)(fullJson.Text)
        IncreaseMagicResistButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.IncreaseMagicResistButton.NormalImage)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim privateFonts As New Text.PrivateFontCollection()
        privateFonts.AddFontFile(Application.StartupPath & "\font\" & My.Settings.ApplicationFont)
        Dim sysfont As New Font(privateFonts.Families(0), 10)
        For Each objCtrl As Control In Me.Controls
            If TypeOf objCtrl Is Label Then
                objCtrl.Font = sysfont
            End If
        Next
    End Sub

    Private Sub AppSettings_Click(sender As Object, e As EventArgs) Handles AppSettings.Click
        SettingsForm.Show()
    End Sub

    Private Sub CraftButton_Click(sender As Object, e As EventArgs) Handles CraftButton.Click
        Dim infoPull As CraftingWindow
        infoPull = JsonConvert.DeserializeObject(Of CraftingWindow)(fullJson.Text)
        CraftButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.CraftButton.ClickedImage)
    End Sub

    Private Sub CraftButton_MouseDown(sender As Object, e As MouseEventArgs) Handles CraftButton.MouseDown
        Dim infoPull As CraftingWindow
        infoPull = JsonConvert.DeserializeObject(Of CraftingWindow)(fullJson.Text)
        CraftButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.CraftButton.ClickedImage)
    End Sub

    Private Sub CraftButton_MouseUp(sender As Object, e As MouseEventArgs) Handles CraftButton.MouseUp
        Dim infoPull As CraftingWindow
        infoPull = JsonConvert.DeserializeObject(Of CraftingWindow)(fullJson.Text)
        CraftButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.CraftButton.HoveredImage)
    End Sub

    Private Sub CraftButton_MouseHover(sender As Object, e As EventArgs) Handles CraftButton.MouseHover
        Dim infoPull As CraftingWindow
        infoPull = JsonConvert.DeserializeObject(Of CraftingWindow)(fullJson.Text)
        CraftButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.CraftButton.HoveredImage)
    End Sub

    Private Sub CraftButton_MouseLeave(sender As Object, e As EventArgs) Handles CraftButton.MouseLeave
        Dim infoPull As CraftingWindow
        infoPull = JsonConvert.DeserializeObject(Of CraftingWindow)(fullJson.Text)
        CraftButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.CraftButton.NormalImage)
    End Sub

    Private Sub EscapeMenuOptionsButton_Click(sender As Object, e As EventArgs) Handles EscapeMenuOptionsButton.Click
        Dim infoPull As EscapeMenu
        infoPull = JsonConvert.DeserializeObject(Of EscapeMenu)(fullJson.Text)
        EscapeMenuOptionsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsButton.ClickedImage)
    End Sub

    Private Sub EscapeMenuOptionsButton_MouseDown(sender As Object, e As MouseEventArgs) Handles EscapeMenuOptionsButton.MouseDown
        Dim infoPull As EscapeMenu
        infoPull = JsonConvert.DeserializeObject(Of EscapeMenu)(fullJson.Text)
        EscapeMenuOptionsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsButton.ClickedImage)
    End Sub

    Private Sub EscapeMenuOptionsButton_MouseUp(sender As Object, e As MouseEventArgs) Handles EscapeMenuOptionsButton.MouseUp
        Dim infoPull As EscapeMenu
        infoPull = JsonConvert.DeserializeObject(Of EscapeMenu)(fullJson.Text)
        EscapeMenuOptionsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsButton.HoveredImage)
    End Sub

    Private Sub EscapeMenuOptionsButton_MouseHover(sender As Object, e As EventArgs) Handles EscapeMenuOptionsButton.MouseHover
        Dim infoPull As EscapeMenu
        infoPull = JsonConvert.DeserializeObject(Of EscapeMenu)(fullJson.Text)
        EscapeMenuOptionsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsButton.HoveredImage)
    End Sub

    Private Sub EscapeMenuOptionsButton_MouseLeave(sender As Object, e As EventArgs) Handles EscapeMenuOptionsButton.MouseLeave
        Dim infoPull As EscapeMenu
        infoPull = JsonConvert.DeserializeObject(Of EscapeMenu)(fullJson.Text)
        EscapeMenuOptionsButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.OptionsButton.NormalImage)
    End Sub

    Private Sub EscapeMenuCharacterSelectButton_Click(sender As Object, e As EventArgs) Handles EscapeMenuCharacterSelectButton.Click
        Dim infoPull As EscapeMenu
        infoPull = JsonConvert.DeserializeObject(Of EscapeMenu)(fullJson.Text)
        EscapeMenuCharacterSelectButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CharacterSelectButton.ClickedImage)
    End Sub

    Private Sub EscapeMenuCharacterSelectButton_MouseDown(sender As Object, e As MouseEventArgs) Handles EscapeMenuCharacterSelectButton.MouseDown
        Dim infoPull As EscapeMenu
        infoPull = JsonConvert.DeserializeObject(Of EscapeMenu)(fullJson.Text)
        EscapeMenuCharacterSelectButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CharacterSelectButton.ClickedImage)
    End Sub

    Private Sub EscapeMenuCharacterSelectButton_MouseUp(sender As Object, e As MouseEventArgs) Handles EscapeMenuCharacterSelectButton.MouseUp
        Dim infoPull As EscapeMenu
        infoPull = JsonConvert.DeserializeObject(Of EscapeMenu)(fullJson.Text)
        EscapeMenuCharacterSelectButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CharacterSelectButton.HoveredImage)
    End Sub

    Private Sub EscapeMenuCharacterSelectButton_MouseHover(sender As Object, e As EventArgs) Handles EscapeMenuCharacterSelectButton.MouseHover
        Dim infoPull As EscapeMenu
        infoPull = JsonConvert.DeserializeObject(Of EscapeMenu)(fullJson.Text)
        EscapeMenuCharacterSelectButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CharacterSelectButton.HoveredImage)
    End Sub

    Private Sub EscapeMenuCharacterSelectButton_MouseLeave(sender As Object, e As EventArgs) Handles EscapeMenuCharacterSelectButton.MouseLeave
        Dim infoPull As EscapeMenu
        infoPull = JsonConvert.DeserializeObject(Of EscapeMenu)(fullJson.Text)
        EscapeMenuCharacterSelectButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CharacterSelectButton.NormalImage)
    End Sub

    Private Sub EscapeMenuLogoutButton_Click(sender As Object, e As EventArgs) Handles EscapeMenuLogoutButton.Click
        Dim infoPull As EscapeMenu
        infoPull = JsonConvert.DeserializeObject(Of EscapeMenu)(fullJson.Text)
        EscapeMenuLogoutButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.LogoutButton.ClickedImage)
    End Sub

    Private Sub EscapeMenuLogoutButton_MouseDown(sender As Object, e As MouseEventArgs) Handles EscapeMenuLogoutButton.MouseDown
        Dim infoPull As EscapeMenu
        infoPull = JsonConvert.DeserializeObject(Of EscapeMenu)(fullJson.Text)
        EscapeMenuLogoutButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.LogoutButton.ClickedImage)
    End Sub

    Private Sub EscapeMenuLogoutButton_MouseUp(sender As Object, e As MouseEventArgs) Handles EscapeMenuLogoutButton.MouseUp
        Dim infoPull As EscapeMenu
        infoPull = JsonConvert.DeserializeObject(Of EscapeMenu)(fullJson.Text)
        EscapeMenuLogoutButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.LogoutButton.HoveredImage)
    End Sub

    Private Sub EscapeMenuLogoutButton_MouseHover(sender As Object, e As EventArgs) Handles EscapeMenuLogoutButton.MouseHover
        Dim infoPull As EscapeMenu
        infoPull = JsonConvert.DeserializeObject(Of EscapeMenu)(fullJson.Text)
        EscapeMenuLogoutButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.LogoutButton.HoveredImage)
    End Sub

    Private Sub EscapeMenuLogoutButton_MouseLeave(sender As Object, e As EventArgs) Handles EscapeMenuLogoutButton.MouseLeave
        Dim infoPull As EscapeMenu
        infoPull = JsonConvert.DeserializeObject(Of EscapeMenu)(fullJson.Text)
        EscapeMenuLogoutButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.LogoutButton.NormalImage)
    End Sub

    Private Sub EscapeMenuExitToDesktopButton_Click(sender As Object, e As EventArgs) Handles EscapeMenuExitToDesktopButton.Click
        Dim infoPull As EscapeMenu
        infoPull = JsonConvert.DeserializeObject(Of EscapeMenu)(fullJson.Text)
        EscapeMenuExitToDesktopButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.ExitToDesktopButton.ClickedImage)
    End Sub

    Private Sub EscapeMenuExitToDesktopButton_MouseDown(sender As Object, e As MouseEventArgs) Handles EscapeMenuExitToDesktopButton.MouseDown
        Dim infoPull As EscapeMenu
        infoPull = JsonConvert.DeserializeObject(Of EscapeMenu)(fullJson.Text)
        EscapeMenuExitToDesktopButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.ExitToDesktopButton.ClickedImage)
    End Sub

    Private Sub EscapeMenuExitToDesktopButton_MouseUp(sender As Object, e As MouseEventArgs) Handles EscapeMenuExitToDesktopButton.MouseUp
        Dim infoPull As EscapeMenu
        infoPull = JsonConvert.DeserializeObject(Of EscapeMenu)(fullJson.Text)
        EscapeMenuExitToDesktopButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.ExitToDesktopButton.HoveredImage)
    End Sub

    Private Sub EscapeMenuExitToDesktopButton_MouseHover(sender As Object, e As EventArgs) Handles EscapeMenuExitToDesktopButton.MouseHover
        Dim infoPull As EscapeMenu
        infoPull = JsonConvert.DeserializeObject(Of EscapeMenu)(fullJson.Text)
        EscapeMenuExitToDesktopButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.ExitToDesktopButton.HoveredImage)
    End Sub

    Private Sub EscapeMenuExitToDesktopButton_MouseLeave(sender As Object, e As EventArgs) Handles EscapeMenuExitToDesktopButton.MouseLeave
        Dim infoPull As EscapeMenu
        infoPull = JsonConvert.DeserializeObject(Of EscapeMenu)(fullJson.Text)
        EscapeMenuExitToDesktopButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.ExitToDesktopButton.NormalImage)
    End Sub

    Private Sub EscapeMenuCloseButton_Click(sender As Object, e As EventArgs) Handles EscapeMenuCloseButton.Click
        Dim infoPull As EscapeMenu
        infoPull = JsonConvert.DeserializeObject(Of EscapeMenu)(fullJson.Text)
        EscapeMenuCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CloseButton.ClickedImage)
    End Sub

    Private Sub EscapeMenuCloseButton_MouseDown(sender As Object, e As MouseEventArgs) Handles EscapeMenuCloseButton.MouseDown
        Dim infoPull As EscapeMenu
        infoPull = JsonConvert.DeserializeObject(Of EscapeMenu)(fullJson.Text)
        EscapeMenuCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CloseButton.ClickedImage)
    End Sub

    Private Sub EscapeMenuCloseButton_MouseUp(sender As Object, e As MouseEventArgs) Handles EscapeMenuCloseButton.MouseUp
        Dim infoPull As EscapeMenu
        infoPull = JsonConvert.DeserializeObject(Of EscapeMenu)(fullJson.Text)
        EscapeMenuCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CloseButton.HoveredImage)
    End Sub

    Private Sub EscapeMenuCloseButton_MouseHover(sender As Object, e As EventArgs) Handles EscapeMenuCloseButton.MouseHover
        Dim infoPull As EscapeMenu
        infoPull = JsonConvert.DeserializeObject(Of EscapeMenu)(fullJson.Text)
        EscapeMenuCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CloseButton.HoveredImage)
    End Sub

    Private Sub EscapeMenuCloseButton_MouseLeave(sender As Object, e As EventArgs) Handles EscapeMenuCloseButton.MouseLeave
        Dim infoPull As EscapeMenu
        infoPull = JsonConvert.DeserializeObject(Of EscapeMenu)(fullJson.Text)
        EscapeMenuCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.CloseButton.NormalImage)
    End Sub

    Private Sub Dialog1Response1Button_Click(sender As Object, e As EventArgs) Handles Dialog1Response1Button.Click
        Dim infoPull As EventDialogWindow1Resonse
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow1Resonse)(fullJson.Text)
        Dialog1Response1Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response1Button.ClickedImage)
    End Sub

    Private Sub Dialog1Response1Button_MouseDown(sender As Object, e As MouseEventArgs) Handles Dialog1Response1Button.MouseDown
        Dim infoPull As EventDialogWindow1Resonse
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow1Resonse)(fullJson.Text)
        Dialog1Response1Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response1Button.ClickedImage)
    End Sub

    Private Sub Dialog1Response1Button_MouseUp(sender As Object, e As MouseEventArgs) Handles Dialog1Response1Button.MouseUp
        Dim infoPull As EventDialogWindow1Resonse
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow1Resonse)(fullJson.Text)
        Dialog1Response1Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response1Button.HoveredImage)
    End Sub

    Private Sub Dialog1Response1Button_MouseHover(sender As Object, e As EventArgs) Handles Dialog1Response1Button.MouseHover
        Dim infoPull As EventDialogWindow1Resonse
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow1Resonse)(fullJson.Text)
        Dialog1Response1Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response1Button.HoveredImage)
    End Sub

    Private Sub Dialog1Response1Button_MouseLeave(sender As Object, e As EventArgs) Handles Dialog1Response1Button.MouseLeave
        Dim infoPull As EventDialogWindow1Resonse
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow1Resonse)(fullJson.Text)
        Dialog1Response1Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response1Button.NormalImage)
    End Sub

    Private Sub Dialog2Response1Button_Click(sender As Object, e As EventArgs) Handles Dialog2Response1Button.Click
        Dim infoPull As EventDialogWindow2Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow2Resonses)(fullJson.Text)
        Dialog2Response1Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response1Button.ClickedImage)
    End Sub

    Private Sub Dialog2Response1Button_MouseDown(sender As Object, e As MouseEventArgs) Handles Dialog2Response1Button.MouseDown
        Dim infoPull As EventDialogWindow2Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow2Resonses)(fullJson.Text)
        Dialog2Response1Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response1Button.ClickedImage)
    End Sub

    Private Sub Dialog2Response1Button_MouseUp(sender As Object, e As MouseEventArgs) Handles Dialog2Response1Button.MouseUp
        Dim infoPull As EventDialogWindow2Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow2Resonses)(fullJson.Text)
        Dialog2Response1Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response1Button.HoveredImage)
    End Sub

    Private Sub Dialog2Response1Button_MouseHover(sender As Object, e As EventArgs) Handles Dialog2Response1Button.MouseHover
        Dim infoPull As EventDialogWindow2Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow2Resonses)(fullJson.Text)
        Dialog2Response1Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response1Button.HoveredImage)
    End Sub

    Private Sub Dialog2Response1Button_MouseLeave(sender As Object, e As EventArgs) Handles Dialog2Response1Button.MouseLeave
        Dim infoPull As EventDialogWindow2Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow2Resonses)(fullJson.Text)
        Dialog2Response1Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response1Button.NormalImage)
    End Sub

    Private Sub Dialog2Response2Button_Click(sender As Object, e As EventArgs) Handles Dialog2Response2Button.Click
        Dim infoPull As EventDialogWindow2Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow2Resonses)(fullJson.Text)
        Dialog2Response2Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response2Button.ClickedImage)
    End Sub

    Private Sub Dialog2Response2Button_MouseDown(sender As Object, e As MouseEventArgs) Handles Dialog2Response2Button.MouseDown
        Dim infoPull As EventDialogWindow2Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow2Resonses)(fullJson.Text)
        Dialog2Response2Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response2Button.ClickedImage)
    End Sub

    Private Sub Dialog2Response2Button_MouseUp(sender As Object, e As MouseEventArgs) Handles Dialog2Response2Button.MouseUp
        Dim infoPull As EventDialogWindow2Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow2Resonses)(fullJson.Text)
        Dialog2Response2Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response2Button.HoveredImage)
    End Sub

    Private Sub Dialog2Response2Button_MouseHover(sender As Object, e As EventArgs) Handles Dialog2Response2Button.MouseHover
        Dim infoPull As EventDialogWindow2Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow2Resonses)(fullJson.Text)
        Dialog2Response2Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response2Button.HoveredImage)
    End Sub

    Private Sub Dialog2Response2Button_MouseLeave(sender As Object, e As EventArgs) Handles Dialog2Response2Button.MouseLeave
        Dim infoPull As EventDialogWindow2Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow2Resonses)(fullJson.Text)
        Dialog2Response2Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response2Button.NormalImage)
    End Sub

    Private Sub Dialog3Response1Button_Click(sender As Object, e As EventArgs) Handles Dialog3Response1Button.Click
        Dim infoPull As EventDialogWindow3Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow3Resonses)(fullJson.Text)
        Dialog3Response1Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response1Button.ClickedImage)
    End Sub

    Private Sub Dialog3Response1Button_MouseDown(sender As Object, e As MouseEventArgs) Handles Dialog3Response1Button.MouseDown
        Dim infoPull As EventDialogWindow3Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow3Resonses)(fullJson.Text)
        Dialog3Response1Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response1Button.ClickedImage)
    End Sub

    Private Sub Dialog3Response1Button_MouseUp(sender As Object, e As MouseEventArgs) Handles Dialog3Response1Button.MouseUp
        Dim infoPull As EventDialogWindow3Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow3Resonses)(fullJson.Text)
        Dialog3Response1Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response1Button.HoveredImage)
    End Sub

    Private Sub Dialog3Response1Button_MouseHover(sender As Object, e As EventArgs) Handles Dialog3Response1Button.MouseHover
        Dim infoPull As EventDialogWindow3Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow3Resonses)(fullJson.Text)
        Dialog3Response1Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response1Button.HoveredImage)
    End Sub

    Private Sub Dialog3Response1Button_MouseLeave(sender As Object, e As EventArgs) Handles Dialog3Response1Button.MouseLeave
        Dim infoPull As EventDialogWindow3Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow3Resonses)(fullJson.Text)
        Dialog3Response1Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response1Button.NormalImage)
    End Sub

    Private Sub Dialog3Response2Button_Click(sender As Object, e As EventArgs) Handles Dialog3Response2Button.Click
        Dim infoPull As EventDialogWindow3Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow3Resonses)(fullJson.Text)
        Dialog3Response2Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response2Button.ClickedImage)
    End Sub

    Private Sub Dialog3Response2Button_MouseDown(sender As Object, e As MouseEventArgs) Handles Dialog3Response2Button.MouseDown
        Dim infoPull As EventDialogWindow3Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow3Resonses)(fullJson.Text)
        Dialog3Response2Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response2Button.ClickedImage)
    End Sub

    Private Sub Dialog3Response2Button_MouseUp(sender As Object, e As MouseEventArgs) Handles Dialog3Response2Button.MouseUp
        Dim infoPull As EventDialogWindow3Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow3Resonses)(fullJson.Text)
        Dialog3Response2Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response2Button.HoveredImage)
    End Sub

    Private Sub Dialog3Response2Button_MouseHover(sender As Object, e As EventArgs) Handles Dialog3Response2Button.MouseHover
        Dim infoPull As EventDialogWindow3Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow3Resonses)(fullJson.Text)
        Dialog3Response2Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response2Button.HoveredImage)
    End Sub

    Private Sub Dialog3Response2Button_MouseLeave(sender As Object, e As EventArgs) Handles Dialog3Response2Button.MouseLeave
        Dim infoPull As EventDialogWindow3Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow3Resonses)(fullJson.Text)
        Dialog3Response2Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response2Button.NormalImage)
    End Sub

    Private Sub Dialog3Response3Button_Click(sender As Object, e As EventArgs) Handles Dialog3Response3Button.Click
        Dim infoPull As EventDialogWindow3Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow3Resonses)(fullJson.Text)
        Dialog3Response3Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response3Button.ClickedImage)
    End Sub

    Private Sub Dialog3Response3Button_MouseDown(sender As Object, e As MouseEventArgs) Handles Dialog3Response3Button.MouseDown
        Dim infoPull As EventDialogWindow3Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow3Resonses)(fullJson.Text)
        Dialog3Response3Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response3Button.ClickedImage)
    End Sub

    Private Sub Dialog3Response3Button_MouseUp(sender As Object, e As MouseEventArgs) Handles Dialog3Response3Button.MouseUp
        Dim infoPull As EventDialogWindow3Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow3Resonses)(fullJson.Text)
        Dialog3Response3Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response3Button.HoveredImage)
    End Sub

    Private Sub Dialog3Response3Button_MouseHover(sender As Object, e As EventArgs) Handles Dialog3Response3Button.MouseHover
        Dim infoPull As EventDialogWindow3Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow3Resonses)(fullJson.Text)
        Dialog3Response3Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response3Button.HoveredImage)
    End Sub

    Private Sub Dialog3Response3Button_MouseLeave(sender As Object, e As EventArgs) Handles Dialog3Response3Button.MouseLeave
        Dim infoPull As EventDialogWindow3Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow3Resonses)(fullJson.Text)
        Dialog3Response3Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response3Button.NormalImage)
    End Sub

    Private Sub Dialog4Response1Button_Click(sender As Object, e As EventArgs) Handles Dialog4Response1Button.Click
        Dim infoPull As EventDialogWindow4Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow4Resonses)(fullJson.Text)
        Dialog4Response1Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response1Button.NormalImage)
    End Sub

    Private Sub Dialog4Response1Button_MouseDown(sender As Object, e As MouseEventArgs) Handles Dialog4Response1Button.MouseDown
        Dim infoPull As EventDialogWindow4Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow4Resonses)(fullJson.Text)
        Dialog4Response1Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response1Button.NormalImage)
    End Sub

    Private Sub Dialog4Response1Button_MouseUp(sender As Object, e As MouseEventArgs) Handles Dialog4Response1Button.MouseUp
        Dim infoPull As EventDialogWindow4Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow4Resonses)(fullJson.Text)
        Dialog4Response1Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response1Button.NormalImage)
    End Sub

    Private Sub Dialog4Response1Button_MouseHover(sender As Object, e As EventArgs) Handles Dialog4Response1Button.MouseHover
        Dim infoPull As EventDialogWindow4Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow4Resonses)(fullJson.Text)
        Dialog4Response1Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response1Button.NormalImage)
    End Sub

    Private Sub Dialog4Response1Button_MouseLeave(sender As Object, e As EventArgs) Handles Dialog4Response1Button.MouseLeave
        Dim infoPull As EventDialogWindow4Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow4Resonses)(fullJson.Text)
        Dialog4Response1Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response1Button.NormalImage)
    End Sub

    Private Sub Dialog4Response2Button_Click(sender As Object, e As EventArgs) Handles Dialog4Response2Button.Click
        Dim infoPull As EventDialogWindow4Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow4Resonses)(fullJson.Text)
        Dialog4Response2Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response2Button.ClickedImage)
    End Sub

    Private Sub Dialog4Response2Button_MouseDown(sender As Object, e As MouseEventArgs) Handles Dialog4Response2Button.MouseDown
        Dim infoPull As EventDialogWindow4Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow4Resonses)(fullJson.Text)
        Dialog4Response2Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response2Button.ClickedImage)
    End Sub

    Private Sub Dialog4Response2Button_MouseUp(sender As Object, e As MouseEventArgs) Handles Dialog4Response2Button.MouseUp
        Dim infoPull As EventDialogWindow4Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow4Resonses)(fullJson.Text)
        Dialog4Response2Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response2Button.HoveredImage)
    End Sub

    Private Sub Dialog4Response2Button_MouseHover(sender As Object, e As EventArgs) Handles Dialog4Response2Button.MouseHover
        Dim infoPull As EventDialogWindow4Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow4Resonses)(fullJson.Text)
        Dialog4Response2Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response2Button.HoveredImage)
    End Sub

    Private Sub Dialog4Response2Button_MouseLeave(sender As Object, e As EventArgs) Handles Dialog4Response2Button.MouseLeave
        Dim infoPull As EventDialogWindow4Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow4Resonses)(fullJson.Text)
        Dialog4Response2Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response2Button.NormalImage)
    End Sub

    Private Sub Dialog4Response3Button_Click(sender As Object, e As EventArgs) Handles Dialog4Response3Button.Click
        Dim infoPull As EventDialogWindow4Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow4Resonses)(fullJson.Text)
        Dialog4Response3Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response3Button.ClickedImage)
    End Sub

    Private Sub Dialog4Response3Button_MouseDown(sender As Object, e As MouseEventArgs) Handles Dialog4Response3Button.MouseDown
        Dim infoPull As EventDialogWindow4Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow4Resonses)(fullJson.Text)
        Dialog4Response3Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response3Button.ClickedImage)
    End Sub

    Private Sub Dialog4Response3Button_MouseUp(sender As Object, e As MouseEventArgs) Handles Dialog4Response3Button.MouseUp
        Dim infoPull As EventDialogWindow4Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow4Resonses)(fullJson.Text)
        Dialog4Response3Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response3Button.HoveredImage)
    End Sub

    Private Sub Dialog4Response3Button_MouseHover(sender As Object, e As EventArgs) Handles Dialog4Response3Button.MouseHover
        Dim infoPull As EventDialogWindow4Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow4Resonses)(fullJson.Text)
        Dialog4Response3Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response3Button.HoveredImage)
    End Sub

    Private Sub Dialog4Response3Button_MouseLeave(sender As Object, e As EventArgs) Handles Dialog4Response3Button.MouseLeave
        Dim infoPull As EventDialogWindow4Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow4Resonses)(fullJson.Text)
        Dialog4Response3Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response3Button.NormalImage)
    End Sub

    Private Sub Dialog4Response4Button_Click(sender As Object, e As EventArgs) Handles Dialog4Response4Button.Click
        Dim infoPull As EventDialogWindow4Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow4Resonses)(fullJson.Text)
        Dialog4Response4Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response4Button.ClickedImage)
    End Sub

    Private Sub Dialog4Response4Button_MouseDown(sender As Object, e As MouseEventArgs) Handles Dialog4Response4Button.MouseDown
        Dim infoPull As EventDialogWindow4Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow4Resonses)(fullJson.Text)
        Dialog4Response4Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response4Button.ClickedImage)
    End Sub

    Private Sub Dialog4Response4Button_MouseUp(sender As Object, e As MouseEventArgs) Handles Dialog4Response4Button.MouseUp
        Dim infoPull As EventDialogWindow4Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow4Resonses)(fullJson.Text)
        Dialog4Response4Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response4Button.HoveredImage)
    End Sub

    Private Sub Dialog4Response4Button_MouseHover(sender As Object, e As EventArgs) Handles Dialog4Response4Button.MouseHover
        Dim infoPull As EventDialogWindow4Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow4Resonses)(fullJson.Text)
        Dialog4Response4Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response4Button.HoveredImage)
    End Sub

    Private Sub Dialog4Response4Button_MouseLeave(sender As Object, e As EventArgs) Handles Dialog4Response4Button.MouseLeave
        Dim infoPull As EventDialogWindow4Resonses
        infoPull = JsonConvert.DeserializeObject(Of EventDialogWindow4Resonses)(fullJson.Text)
        Dialog4Response4Button.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.Children.Response4Button.NormalImage)
    End Sub

    Private Sub AddFriendPopupButton_Click(sender As Object, e As EventArgs) Handles AddFriendPopupButton.Click
        Dim infoPull As FriendsWindow
        infoPull = JsonConvert.DeserializeObject(Of FriendsWindow)(fullJson.Text)
        AddFriendPopupButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.AddFriendPopupButton.ClickedImage)
    End Sub

    Private Sub AddFriendPopupButton_MouseDown(sender As Object, e As MouseEventArgs) Handles AddFriendPopupButton.MouseDown
        Dim infoPull As FriendsWindow
        infoPull = JsonConvert.DeserializeObject(Of FriendsWindow)(fullJson.Text)
        AddFriendPopupButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.AddFriendPopupButton.ClickedImage)
    End Sub

    Private Sub AddFriendPopupButton_MouseUp(sender As Object, e As MouseEventArgs) Handles AddFriendPopupButton.MouseUp
        Dim infoPull As FriendsWindow
        infoPull = JsonConvert.DeserializeObject(Of FriendsWindow)(fullJson.Text)
        AddFriendPopupButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.AddFriendPopupButton.HoveredImage)
    End Sub

    Private Sub AddFriendPopupButton_MouseHover(sender As Object, e As EventArgs) Handles AddFriendPopupButton.MouseHover
        Dim infoPull As FriendsWindow
        infoPull = JsonConvert.DeserializeObject(Of FriendsWindow)(fullJson.Text)
        AddFriendPopupButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.AddFriendPopupButton.HoveredImage)
    End Sub

    Private Sub AddFriendPopupButton_MouseLeave(sender As Object, e As EventArgs) Handles AddFriendPopupButton.MouseLeave
        Dim infoPull As FriendsWindow
        infoPull = JsonConvert.DeserializeObject(Of FriendsWindow)(fullJson.Text)
        AddFriendPopupButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.AddFriendPopupButton.NormalImage)
    End Sub

    Private Sub FriendsWindowCloseButton_Click(sender As Object, e As EventArgs) Handles FriendsWindowCloseButton.Click
        Dim infoPull As FriendsWindow
        infoPull = JsonConvert.DeserializeObject(Of FriendsWindow)(fullJson.Text)
        FriendsWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.ClickedImage)
    End Sub

    Private Sub FriendsWindowCloseButton_MouseDown(sender As Object, e As MouseEventArgs) Handles FriendsWindowCloseButton.MouseDown
        Dim infoPull As FriendsWindow
        infoPull = JsonConvert.DeserializeObject(Of FriendsWindow)(fullJson.Text)
        FriendsWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.ClickedImage)
    End Sub

    Private Sub FriendsWindowCloseButton_MouseUp(sender As Object, e As MouseEventArgs) Handles FriendsWindowCloseButton.MouseUp
        Dim infoPull As FriendsWindow
        infoPull = JsonConvert.DeserializeObject(Of FriendsWindow)(fullJson.Text)
        FriendsWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.HoveredImage)
    End Sub

    Private Sub FriendsWindowCloseButton_MouseHover(sender As Object, e As EventArgs) Handles FriendsWindowCloseButton.MouseHover
        Dim infoPull As FriendsWindow
        infoPull = JsonConvert.DeserializeObject(Of FriendsWindow)(fullJson.Text)
        FriendsWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.HoveredImage)
    End Sub

    Private Sub FriendsWindowCloseButton_MouseLeave(sender As Object, e As EventArgs) Handles FriendsWindowCloseButton.MouseLeave
        Dim infoPull As FriendsWindow
        infoPull = JsonConvert.DeserializeObject(Of FriendsWindow)(fullJson.Text)
        FriendsWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.NormalImage)
    End Sub

    Private Sub GameInputNoButton_Click(sender As Object, e As EventArgs) Handles GameInputNoButton.Click
        Dim infoPull As GameInputBox
        infoPull = JsonConvert.DeserializeObject(Of GameInputBox)(fullJson.Text)
        GameInputNoButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.NoButton.ClickedImage)
    End Sub

    Private Sub GameInputNoButton_MouseDown(sender As Object, e As MouseEventArgs) Handles GameInputNoButton.MouseDown
        Dim infoPull As GameInputBox
        infoPull = JsonConvert.DeserializeObject(Of GameInputBox)(fullJson.Text)
        GameInputNoButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.NoButton.ClickedImage)
    End Sub

    Private Sub GameInputNoButton_MouseUp(sender As Object, e As MouseEventArgs) Handles GameInputNoButton.MouseUp
        Dim infoPull As GameInputBox
        infoPull = JsonConvert.DeserializeObject(Of GameInputBox)(fullJson.Text)
        GameInputNoButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.NoButton.HoveredImage)
    End Sub

    Private Sub GameInputNoButton_MouseHover(sender As Object, e As EventArgs) Handles GameInputNoButton.MouseHover
        Dim infoPull As GameInputBox
        infoPull = JsonConvert.DeserializeObject(Of GameInputBox)(fullJson.Text)
        GameInputNoButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.NoButton.HoveredImage)
    End Sub

    Private Sub GameInputNoButton_MouseLeave(sender As Object, e As EventArgs) Handles GameInputNoButton.MouseLeave
        Dim infoPull As GameInputBox
        infoPull = JsonConvert.DeserializeObject(Of GameInputBox)(fullJson.Text)
        GameInputNoButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.NoButton.NormalImage)
    End Sub

    Private Sub GameInputOkayButton_Click(sender As Object, e As EventArgs) Handles GameInputOkayButton.Click
        Dim infoPull As GameInputBox
        infoPull = JsonConvert.DeserializeObject(Of GameInputBox)(fullJson.Text)
        GameInputOkayButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.OkayButton.ClickedImage)
    End Sub

    Private Sub GameInputOkayButton_MouseDown(sender As Object, e As MouseEventArgs) Handles GameInputOkayButton.MouseDown
        Dim infoPull As GameInputBox
        infoPull = JsonConvert.DeserializeObject(Of GameInputBox)(fullJson.Text)
        GameInputOkayButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.OkayButton.ClickedImage)
    End Sub

    Private Sub GameInputOkayButton_MouseUp(sender As Object, e As MouseEventArgs) Handles GameInputOkayButton.MouseUp
        Dim infoPull As GameInputBox
        infoPull = JsonConvert.DeserializeObject(Of GameInputBox)(fullJson.Text)
        GameInputOkayButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.OkayButton.HoveredImage)
    End Sub

    Private Sub GameInputOkayButton_MouseHover(sender As Object, e As EventArgs) Handles GameInputOkayButton.MouseHover
        Dim infoPull As GameInputBox
        infoPull = JsonConvert.DeserializeObject(Of GameInputBox)(fullJson.Text)
        GameInputOkayButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.OkayButton.HoveredImage)
    End Sub

    Private Sub GameInputOkayButton_MouseLeave(sender As Object, e As EventArgs) Handles GameInputOkayButton.MouseLeave
        Dim infoPull As GameInputBox
        infoPull = JsonConvert.DeserializeObject(Of GameInputBox)(fullJson.Text)
        GameInputOkayButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.OkayButton.NormalImage)
    End Sub

    Private Sub GameInputYesButton_Click(sender As Object, e As EventArgs) Handles GameInputYesButton.Click
        Dim infoPull As GameInputBox
        infoPull = JsonConvert.DeserializeObject(Of GameInputBox)(fullJson.Text)
        GameInputYesButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.YesButton.ClickedImage)
    End Sub

    Private Sub GameInputYesButton_MouseDown(sender As Object, e As MouseEventArgs) Handles GameInputYesButton.MouseDown
        Dim infoPull As GameInputBox
        infoPull = JsonConvert.DeserializeObject(Of GameInputBox)(fullJson.Text)
        GameInputYesButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.YesButton.ClickedImage)
    End Sub

    Private Sub GameInputYesButton_MouseUp(sender As Object, e As MouseEventArgs) Handles GameInputYesButton.MouseUp
        Dim infoPull As GameInputBox
        infoPull = JsonConvert.DeserializeObject(Of GameInputBox)(fullJson.Text)
        GameInputYesButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.YesButton.HoveredImage)
    End Sub

    Private Sub GameInputYesButton_MouseHover(sender As Object, e As EventArgs) Handles GameInputYesButton.MouseHover
        Dim infoPull As GameInputBox
        infoPull = JsonConvert.DeserializeObject(Of GameInputBox)(fullJson.Text)
        GameInputYesButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.YesButton.HoveredImage)
    End Sub

    Private Sub GameInputYesButton_MouseLeave(sender As Object, e As EventArgs) Handles GameInputYesButton.MouseLeave
        Dim infoPull As GameInputBox
        infoPull = JsonConvert.DeserializeObject(Of GameInputBox)(fullJson.Text)
        GameInputYesButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.YesButton.NormalImage)
    End Sub

    Private Sub GameInputBoxCloseButton_Click(sender As Object, e As EventArgs) Handles GameInputBoxCloseButton.Click
        Dim infoPull As GameInputBox
        infoPull = JsonConvert.DeserializeObject(Of GameInputBox)(fullJson.Text)
        GameInputBoxCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.ClickedImage)
    End Sub

    Private Sub GameInputBoxCloseButton_MouseDown(sender As Object, e As MouseEventArgs) Handles GameInputBoxCloseButton.MouseDown
        Dim infoPull As GameInputBox
        infoPull = JsonConvert.DeserializeObject(Of GameInputBox)(fullJson.Text)
        GameInputBoxCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.ClickedImage)
    End Sub

    Private Sub GameInputBoxCloseButton_MouseUp(sender As Object, e As MouseEventArgs) Handles GameInputBoxCloseButton.MouseUp
        Dim infoPull As GameInputBox
        infoPull = JsonConvert.DeserializeObject(Of GameInputBox)(fullJson.Text)
        GameInputBoxCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.HoveredImage)
    End Sub

    Private Sub GameInputBoxCloseButton_MouseHover(sender As Object, e As EventArgs) Handles GameInputBoxCloseButton.MouseHover
        Dim infoPull As GameInputBox
        infoPull = JsonConvert.DeserializeObject(Of GameInputBox)(fullJson.Text)
        GameInputBoxCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.HoveredImage)
    End Sub

    Private Sub GameInputBoxCloseButton_MouseLeave(sender As Object, e As EventArgs) Handles GameInputBoxCloseButton.MouseLeave
        Dim infoPull As GameInputBox
        infoPull = JsonConvert.DeserializeObject(Of GameInputBox)(fullJson.Text)
        GameInputBoxCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.NormalImage)
    End Sub

    Private Sub InventoryWindowCloseButton_Click(sender As Object, e As EventArgs) Handles InventoryWindowCloseButton.Click
        Dim infoPull As InventoryWindow
        infoPull = JsonConvert.DeserializeObject(Of InventoryWindow)(fullJson.Text)
        InventoryWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.ClickedImage)
    End Sub

    Private Sub InventoryWindowCloseButton_MouseDown(sender As Object, e As MouseEventArgs) Handles InventoryWindowCloseButton.MouseDown
        Dim infoPull As InventoryWindow
        infoPull = JsonConvert.DeserializeObject(Of InventoryWindow)(fullJson.Text)
        InventoryWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.ClickedImage)
    End Sub

    Private Sub InventoryWindowCloseButton_MouseUp(sender As Object, e As MouseEventArgs) Handles InventoryWindowCloseButton.MouseUp
        Dim infoPull As InventoryWindow
        infoPull = JsonConvert.DeserializeObject(Of InventoryWindow)(fullJson.Text)
        InventoryWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.HoveredImage)
    End Sub

    Private Sub InventoryWindowCloseButton_MouseHover(sender As Object, e As EventArgs) Handles InventoryWindowCloseButton.MouseHover
        Dim infoPull As InventoryWindow
        infoPull = JsonConvert.DeserializeObject(Of InventoryWindow)(fullJson.Text)
        InventoryWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.HoveredImage)
    End Sub

    Private Sub InventoryWindowCloseButton_MouseLeave(sender As Object, e As EventArgs) Handles InventoryWindowCloseButton.MouseLeave
        Dim infoPull As InventoryWindow
        infoPull = JsonConvert.DeserializeObject(Of InventoryWindow)(fullJson.Text)
        InventoryWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.NormalImage)
    End Sub

    Private Sub PartyCloseButton_Click(sender As Object, e As EventArgs) Handles PartyCloseButton.Click
        Dim infoPull As PartyWindow
        infoPull = JsonConvert.DeserializeObject(Of PartyWindow)(fullJson.Text)
        PartyCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.ClickedImage)
    End Sub

    Private Sub PartyCloseButton_MouseDown(sender As Object, e As MouseEventArgs) Handles PartyCloseButton.MouseDown
        Dim infoPull As PartyWindow
        infoPull = JsonConvert.DeserializeObject(Of PartyWindow)(fullJson.Text)
        PartyCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.ClickedImage)
    End Sub

    Private Sub PartyCloseButton_MouseUp(sender As Object, e As MouseEventArgs) Handles PartyCloseButton.MouseUp
        Dim infoPull As PartyWindow
        infoPull = JsonConvert.DeserializeObject(Of PartyWindow)(fullJson.Text)
        PartyCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.HoveredImage)
    End Sub

    Private Sub PartyCloseButton_MouseHover(sender As Object, e As EventArgs) Handles PartyCloseButton.MouseHover
        Dim infoPull As PartyWindow
        infoPull = JsonConvert.DeserializeObject(Of PartyWindow)(fullJson.Text)
        PartyCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.HoveredImage)
    End Sub

    Private Sub PartyCloseButton_MouseLeave(sender As Object, e As EventArgs) Handles PartyCloseButton.MouseLeave
        Dim infoPull As PartyWindow
        infoPull = JsonConvert.DeserializeObject(Of PartyWindow)(fullJson.Text)
        PartyCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.NormalImage)
    End Sub

    Private Sub LeavePartyButton_Click(sender As Object, e As EventArgs) Handles LeavePartyButton.Click
        Dim infoPull As PartyWindow
        infoPull = JsonConvert.DeserializeObject(Of PartyWindow)(fullJson.Text)
        LeavePartyButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.LeavePartyButton.ClickedImage)
    End Sub

    Private Sub LeavePartyButton_MouseDown(sender As Object, e As MouseEventArgs) Handles LeavePartyButton.MouseDown
        Dim infoPull As PartyWindow
        infoPull = JsonConvert.DeserializeObject(Of PartyWindow)(fullJson.Text)
        LeavePartyButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.LeavePartyButton.ClickedImage)
    End Sub

    Private Sub LeavePartyButton_MouseUp(sender As Object, e As MouseEventArgs) Handles LeavePartyButton.MouseUp
        Dim infoPull As PartyWindow
        infoPull = JsonConvert.DeserializeObject(Of PartyWindow)(fullJson.Text)
        LeavePartyButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.LeavePartyButton.HoveredImage)
    End Sub

    Private Sub LeavePartyButton_MouseHover(sender As Object, e As EventArgs) Handles LeavePartyButton.MouseHover
        Dim infoPull As PartyWindow
        infoPull = JsonConvert.DeserializeObject(Of PartyWindow)(fullJson.Text)
        LeavePartyButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.LeavePartyButton.HoveredImage)
    End Sub

    Private Sub LeavePartyButton_MouseLeave(sender As Object, e As EventArgs) Handles LeavePartyButton.MouseLeave
        Dim infoPull As PartyWindow
        infoPull = JsonConvert.DeserializeObject(Of PartyWindow)(fullJson.Text)
        LeavePartyButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.LeavePartyButton.NormalImage)
    End Sub

    Private Sub QuestOfferAcceptButton_Click(sender As Object, e As EventArgs) Handles QuestOfferAcceptButton.Click
        Dim infoPull As QuestOfferWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestOfferWindow)(fullJson.Text)
        QuestOfferAcceptButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.AcceptButton.ClickedImage)
    End Sub

    Private Sub QuestOfferAcceptButton_MouseDown(sender As Object, e As MouseEventArgs) Handles QuestOfferAcceptButton.MouseDown
        Dim infoPull As QuestOfferWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestOfferWindow)(fullJson.Text)
        QuestOfferAcceptButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.AcceptButton.ClickedImage)
    End Sub

    Private Sub QuestOfferAcceptButton_MouseUp(sender As Object, e As MouseEventArgs) Handles QuestOfferAcceptButton.MouseUp
        Dim infoPull As QuestOfferWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestOfferWindow)(fullJson.Text)
        QuestOfferAcceptButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.AcceptButton.HoveredImage)
    End Sub

    Private Sub QuestOfferAcceptButton_MouseHover(sender As Object, e As EventArgs) Handles QuestOfferAcceptButton.MouseHover
        Dim infoPull As QuestOfferWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestOfferWindow)(fullJson.Text)
        QuestOfferAcceptButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.AcceptButton.HoveredImage)
    End Sub

    Private Sub QuestOfferAcceptButton_MouseLeave(sender As Object, e As EventArgs) Handles QuestOfferAcceptButton.MouseLeave
        Dim infoPull As QuestOfferWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestOfferWindow)(fullJson.Text)
        QuestOfferAcceptButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.AcceptButton.NormalImage)
    End Sub

    Private Sub QuestOfferDeclineButton_Click(sender As Object, e As EventArgs) Handles QuestOfferDeclineButton.Click
        Dim infoPull As QuestOfferWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestOfferWindow)(fullJson.Text)
        QuestOfferDeclineButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.DeclineButton.ClickedImage)
    End Sub

    Private Sub QuestOfferDeclineButton_MouseDown(sender As Object, e As MouseEventArgs) Handles QuestOfferDeclineButton.MouseDown
        Dim infoPull As QuestOfferWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestOfferWindow)(fullJson.Text)
        QuestOfferDeclineButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.DeclineButton.ClickedImage)
    End Sub

    Private Sub QuestOfferDeclineButton_MouseUp(sender As Object, e As MouseEventArgs) Handles QuestOfferDeclineButton.MouseUp
        Dim infoPull As QuestOfferWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestOfferWindow)(fullJson.Text)
        QuestOfferDeclineButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.DeclineButton.HoveredImage)
    End Sub

    Private Sub QuestOfferDeclineButton_MouseHover(sender As Object, e As EventArgs) Handles QuestOfferDeclineButton.MouseHover
        Dim infoPull As QuestOfferWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestOfferWindow)(fullJson.Text)
        QuestOfferDeclineButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.DeclineButton.HoveredImage)
    End Sub

    Private Sub QuestOfferDeclineButton_MouseLeave(sender As Object, e As EventArgs) Handles QuestOfferDeclineButton.MouseLeave
        Dim infoPull As QuestOfferWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestOfferWindow)(fullJson.Text)
        QuestOfferDeclineButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.DeclineButton.NormalImage)
    End Sub

    Private Sub QuestOfferCloseButton_Click(sender As Object, e As EventArgs) Handles QuestOfferCloseButton.Click
        Dim infoPull As QuestOfferWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestOfferWindow)(fullJson.Text)
        QuestOfferCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.ClickedImage)
    End Sub

    Private Sub QuestOfferCloseButton_MouseDown(sender As Object, e As MouseEventArgs) Handles QuestOfferCloseButton.MouseDown
        Dim infoPull As QuestOfferWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestOfferWindow)(fullJson.Text)
        QuestOfferCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.ClickedImage)
    End Sub

    Private Sub QuestOfferCloseButton_MouseUp(sender As Object, e As MouseEventArgs) Handles QuestOfferCloseButton.MouseUp
        Dim infoPull As QuestOfferWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestOfferWindow)(fullJson.Text)
        QuestOfferCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.HoveredImage)
    End Sub

    Private Sub QuestOfferCloseButton_MouseHover(sender As Object, e As EventArgs) Handles QuestOfferCloseButton.MouseHover
        Dim infoPull As QuestOfferWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestOfferWindow)(fullJson.Text)
        QuestOfferCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.HoveredImage)
    End Sub

    Private Sub QuestOfferCloseButton_MouseLeave(sender As Object, e As EventArgs) Handles QuestOfferCloseButton.MouseLeave
        Dim infoPull As QuestOfferWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestOfferWindow)(fullJson.Text)
        QuestOfferCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.NormalImage)
    End Sub

    Private Sub QuestsWindowCloseButton_Click(sender As Object, e As EventArgs) Handles QuestsWindowCloseButton.Click
        Dim infoPull As QuestsWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestsWindow)(fullJson.Text)
        QuestsWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.ClickedImage)
    End Sub

    Private Sub QuestsWindowCloseButton_MouseCaptureChanged(sender As Object, e As EventArgs) Handles QuestsWindowCloseButton.MouseCaptureChanged
        Dim infoPull As QuestsWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestsWindow)(fullJson.Text)
        QuestsWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.ClickedImage)
    End Sub

    Private Sub QuestsWindowCloseButton_MouseUp(sender As Object, e As MouseEventArgs) Handles QuestsWindowCloseButton.MouseUp
        Dim infoPull As QuestsWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestsWindow)(fullJson.Text)
        QuestsWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.HoveredImage)
    End Sub

    Private Sub QuestsWindowCloseButton_MouseHover(sender As Object, e As EventArgs) Handles QuestsWindowCloseButton.MouseHover
        Dim infoPull As QuestsWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestsWindow)(fullJson.Text)
        QuestsWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.HoveredImage)
    End Sub

    Private Sub QuestsWindowCloseButton_MouseLeave(sender As Object, e As EventArgs) Handles QuestsWindowCloseButton.MouseLeave
        Dim infoPull As QuestsWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestsWindow)(fullJson.Text)
        QuestsWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.NormalImage)
    End Sub

    Private Sub QuestsWindowAbandonQuestButton_Click(sender As Object, e As EventArgs) Handles QuestsWindowAbandonQuestButton.Click
        Dim infoPull As QuestsWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestsWindow)(fullJson.Text)
        QuestsWindowAbandonQuestButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.AbandonQuestButton.ClickedImage)
    End Sub

    Private Sub QuestsWindowAbandonQuestButton_MouseDown(sender As Object, e As MouseEventArgs) Handles QuestsWindowAbandonQuestButton.MouseDown
        Dim infoPull As QuestsWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestsWindow)(fullJson.Text)
        QuestsWindowAbandonQuestButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.AbandonQuestButton.ClickedImage)
    End Sub

    Private Sub QuestsWindowAbandonQuestButton_MouseUp(sender As Object, e As MouseEventArgs) Handles QuestsWindowAbandonQuestButton.MouseUp
        Dim infoPull As QuestsWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestsWindow)(fullJson.Text)
        QuestsWindowAbandonQuestButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.AbandonQuestButton.HoveredImage)
    End Sub

    Private Sub QuestsWindowAbandonQuestButton_MouseHover(sender As Object, e As EventArgs) Handles QuestsWindowAbandonQuestButton.MouseHover
        Dim infoPull As QuestsWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestsWindow)(fullJson.Text)
        QuestsWindowAbandonQuestButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.AbandonQuestButton.HoveredImage)
    End Sub

    Private Sub QuestsWindowAbandonQuestButton_MouseLeave(sender As Object, e As EventArgs) Handles QuestsWindowAbandonQuestButton.MouseLeave
        Dim infoPull As QuestsWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestsWindow)(fullJson.Text)
        QuestsWindowAbandonQuestButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.AbandonQuestButton.NormalImage)
    End Sub

    Private Sub QuestsWindowBackButton_Click(sender As Object, e As EventArgs) Handles QuestsWindowBackButton.Click
        Dim infoPull As QuestsWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestsWindow)(fullJson.Text)
        QuestsWindowBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.BackButton.ClickedImage)
    End Sub

    Private Sub QuestsWindowBackButton_MouseDown(sender As Object, e As MouseEventArgs) Handles QuestsWindowBackButton.MouseDown
        Dim infoPull As QuestsWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestsWindow)(fullJson.Text)
        QuestsWindowBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.BackButton.ClickedImage)
    End Sub

    Private Sub QuestsWindowBackButton_MouseUp(sender As Object, e As MouseEventArgs) Handles QuestsWindowBackButton.MouseUp
        Dim infoPull As QuestsWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestsWindow)(fullJson.Text)
        QuestsWindowBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.BackButton.HoveredImage)
    End Sub

    Private Sub QuestsWindowBackButton_MouseHover(sender As Object, e As EventArgs) Handles QuestsWindowBackButton.MouseHover
        Dim infoPull As QuestsWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestsWindow)(fullJson.Text)
        QuestsWindowBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.BackButton.HoveredImage)
    End Sub

    Private Sub QuestsWindowBackButton_MouseLeave(sender As Object, e As EventArgs) Handles QuestsWindowBackButton.MouseLeave
        Dim infoPull As QuestsWindow
        infoPull = JsonConvert.DeserializeObject(Of QuestsWindow)(fullJson.Text)
        QuestsWindowBackButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.BackButton.NormalImage)
    End Sub

    Private Sub ShopWindowCloseButton_Click(sender As Object, e As EventArgs) Handles ShopWindowCloseButton.Click
        Dim infoPull As ShopWindow
        infoPull = JsonConvert.DeserializeObject(Of ShopWindow)(fullJson.Text)
        ShopWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.ClickedImage)
    End Sub

    Private Sub ShopWindowCloseButton_MouseDown(sender As Object, e As MouseEventArgs) Handles ShopWindowCloseButton.MouseDown
        Dim infoPull As ShopWindow
        infoPull = JsonConvert.DeserializeObject(Of ShopWindow)(fullJson.Text)
        ShopWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.ClickedImage)
    End Sub

    Private Sub ShopWindowCloseButton_MouseUp(sender As Object, e As MouseEventArgs) Handles ShopWindowCloseButton.MouseUp
        Dim infoPull As ShopWindow
        infoPull = JsonConvert.DeserializeObject(Of ShopWindow)(fullJson.Text)
        ShopWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.HoveredImage)
    End Sub

    Private Sub ShopWindowCloseButton_MouseHover(sender As Object, e As EventArgs) Handles ShopWindowCloseButton.MouseHover
        Dim infoPull As ShopWindow
        infoPull = JsonConvert.DeserializeObject(Of ShopWindow)(fullJson.Text)
        ShopWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.HoveredImage)
    End Sub

    Private Sub ShopWindowCloseButton_MouseLeave(sender As Object, e As EventArgs) Handles ShopWindowCloseButton.MouseLeave
        Dim infoPull As ShopWindow
        infoPull = JsonConvert.DeserializeObject(Of ShopWindow)(fullJson.Text)
        ShopWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.NormalImage)
    End Sub

    Private Sub SpellsWindowCloseButton_Click(sender As Object, e As EventArgs) Handles SpellsWindowCloseButton.Click
        Dim infoPull As SpellsWindow
        infoPull = JsonConvert.DeserializeObject(Of SpellsWindow)(fullJson.Text)
        SpellsWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.ClickedImage)
    End Sub

    Private Sub SpellsWindowCloseButton_MouseDown(sender As Object, e As MouseEventArgs) Handles SpellsWindowCloseButton.MouseDown
        Dim infoPull As SpellsWindow
        infoPull = JsonConvert.DeserializeObject(Of SpellsWindow)(fullJson.Text)
        SpellsWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.ClickedImage)
    End Sub

    Private Sub SpellsWindowCloseButton_MouseUp(sender As Object, e As MouseEventArgs) Handles SpellsWindowCloseButton.MouseUp
        Dim infoPull As SpellsWindow
        infoPull = JsonConvert.DeserializeObject(Of SpellsWindow)(fullJson.Text)
        SpellsWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.HoveredImage)
    End Sub

    Private Sub SpellsWindowCloseButton_MouseHover(sender As Object, e As EventArgs) Handles SpellsWindowCloseButton.MouseHover
        Dim infoPull As SpellsWindow
        infoPull = JsonConvert.DeserializeObject(Of SpellsWindow)(fullJson.Text)
        SpellsWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.HoveredImage)
    End Sub

    Private Sub SpellsWindowCloseButton_MouseLeave(sender As Object, e As EventArgs) Handles SpellsWindowCloseButton.MouseLeave
        Dim infoPull As SpellsWindow
        infoPull = JsonConvert.DeserializeObject(Of SpellsWindow)(fullJson.Text)
        SpellsWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.NormalImage)
    End Sub

    Private Sub TradeWindowTradeButton_Click(sender As Object, e As EventArgs) Handles TradeWindowTradeButton.Click
        Dim infoPull As TradeWindow
        infoPull = JsonConvert.DeserializeObject(Of TradeWindow)(fullJson.Text)
        TradeWindowTradeButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.TradeButton.ClickedImage)
    End Sub

    Private Sub TradeWindowTradeButton_MouseDown(sender As Object, e As MouseEventArgs) Handles TradeWindowTradeButton.MouseDown
        Dim infoPull As TradeWindow
        infoPull = JsonConvert.DeserializeObject(Of TradeWindow)(fullJson.Text)
        TradeWindowTradeButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.TradeButton.ClickedImage)
    End Sub

    Private Sub TradeWindowTradeButton_MouseUp(sender As Object, e As MouseEventArgs) Handles TradeWindowTradeButton.MouseUp
        Dim infoPull As TradeWindow
        infoPull = JsonConvert.DeserializeObject(Of TradeWindow)(fullJson.Text)
        TradeWindowTradeButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.TradeButton.HoveredImage)
    End Sub

    Private Sub TradeWindowTradeButton_MouseHover(sender As Object, e As EventArgs) Handles TradeWindowTradeButton.MouseHover
        Dim infoPull As TradeWindow
        infoPull = JsonConvert.DeserializeObject(Of TradeWindow)(fullJson.Text)
        TradeWindowTradeButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.TradeButton.HoveredImage)
    End Sub

    Private Sub TradeWindowTradeButton_MouseLeave(sender As Object, e As EventArgs) Handles TradeWindowTradeButton.MouseLeave
        Dim infoPull As TradeWindow
        infoPull = JsonConvert.DeserializeObject(Of TradeWindow)(fullJson.Text)
        TradeWindowTradeButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.InnerPanel.Children.TradeButton.NormalImage)
    End Sub

    Private Sub TradeWindowCloseButton_Click(sender As Object, e As EventArgs) Handles TradeWindowCloseButton.Click
        Dim infoPull As TradeWindow
        infoPull = JsonConvert.DeserializeObject(Of TradeWindow)(fullJson.Text)
        TradeWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.ClickedImage)
    End Sub

    Private Sub TradeWindowCloseButton_MouseDown(sender As Object, e As MouseEventArgs) Handles TradeWindowCloseButton.MouseDown
        Dim infoPull As TradeWindow
        infoPull = JsonConvert.DeserializeObject(Of TradeWindow)(fullJson.Text)
        TradeWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.ClickedImage)
    End Sub

    Private Sub TradeWindowCloseButton_MouseUp(sender As Object, e As MouseEventArgs) Handles TradeWindowCloseButton.MouseUp
        Dim infoPull As TradeWindow
        infoPull = JsonConvert.DeserializeObject(Of TradeWindow)(fullJson.Text)
        TradeWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.HoveredImage)
    End Sub

    Private Sub TradeWindowCloseButton_MouseHover(sender As Object, e As EventArgs) Handles TradeWindowCloseButton.MouseHover
        Dim infoPull As TradeWindow
        infoPull = JsonConvert.DeserializeObject(Of TradeWindow)(fullJson.Text)
        TradeWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.HoveredImage)
    End Sub

    Private Sub TradeWindowCloseButton_MouseLeave(sender As Object, e As EventArgs) Handles TradeWindowCloseButton.MouseLeave
        Dim infoPull As TradeWindow
        infoPull = JsonConvert.DeserializeObject(Of TradeWindow)(fullJson.Text)
        TradeWindowCloseButton.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\" & infoPull.CloseButton.NormalImage)
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If openFile <> "" Then
            ReloadText(openFile, "text")
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If jsonType.Text <> "Object" Then
            gridoverlay = False
            ReloadText(openFile, "text")
        End If
    End Sub
End Class
