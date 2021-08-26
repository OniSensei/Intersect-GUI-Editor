Imports System.IO

Module Functions
    Private _rnd As New Random()

    Function RandomNumber(ByVal low As Integer, ByVal high As Integer) As Integer
        Return _rnd.Next(low, high)
    End Function

    Public Sub ReloadText(ByVal windowname As String, ByVal type As String)
        Dim tempPath As String = Application.StartupPath & "\temp\"
        Dim tempFileName As String

        tempFileName = RandomNumber(10000, 10000000)

        Directory.CreateDirectory(tempPath)

        Select Case type
            Case "treeview"
                Using writer = New FileStream(tempPath & "tmp_" & tempFileName & ".json", FileMode.Create)
                    Form1.JTokenTreeUserControl1.SaveJson(writer)
                End Using
            Case "text"
                My.Computer.FileSystem.WriteAllText(tempPath & "tmp_" & tempFileName & ".json", Form1.fullJson.Text,
                                                    False)
                Form1.JTokenTreeUserControl1.SetJsonSource(Form1.fullJson.Text)
        End Select


        Using reader = New StreamReader(tempPath & "tmp_" & tempFileName & ".json")
            If windowname.Contains("LoginWindow.json") Then
                UpdateLoginGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("CharacterCreationWindow.json") Then
                UpdateCharacterCreationGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("CharacterSelectionWindow.json") Then
                UpdateCharacterSelectionGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("CreditsWindow.json") Then
                UpdateCreditsGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("ForgotPasswordWindow.json") Then
                UpdateForgotPasswordGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("InputBox.json") Then
                UpdateInputBoxGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("Logo.json") Then
                UpdateLogoGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("MenuWindow.json") Then
                UpdateMenuWindow(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("OptionsWindow.json") Then
                UpdateOptionsWindowGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("RegistrationWindow.json") Then
                UpdateRegistrationWindowGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("ResetPasswordWindow.json") Then
                UpdateResetPasswordWindowGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("ServerStatusArea.json") Then
                UpdateServerStatusAreaGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("BagItem.json") Then
                UpdateBagItemGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("BagWindow.json") Then
                UpdateBagWindowGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("BankItem.json") Then
                UpdateBankItemGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("BankWindow.json") Then
                UpdateBankWindowGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("CharacterWindow.json") Then
                UpdateCharacterWindowGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("ChatboxWindow.json") Then
                UpdateChatboxWindowGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("CraftedItem.json") Then
                UpdateCraftedItemGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("CraftingIngredient.json") Then
                UpdateCraftingIngredientGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("CraftingWindow.json") Then
                UpdateCraftingWindowGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("EquipmentItem.json") Then
                UpdateEquipmentItemGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("EscapeMenu.json") Then
                UpdateEscapeMenuGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("EventDialogWindow_1Response.json") Then
                UpdateEventDialogWindow1ResponseGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("EventDialogWindow_2Responses.json") Then
                UpdateEventDialogWindow2ResponseGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("EventDialogWindow_3Responses.json") Then
                UpdateEventDialogWindow3ResponseGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("EventDialogWindow_4Responses.json") Then
                UpdateEventDialogWindow4ResponseGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("FriendsWindow.json") Then
                UpdateFriendsWindowGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("HotbarWindow.json") Then
                UpdateHotbarWindowGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("InputBox.json") Then
                UpdateGameInputBoxGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("InventoryItem.json") Then
                UpdateInventoryItemGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("InventoryWindow.json") Then
                UpdateInventoryWindowGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("ItemDescWindow.json") Then
                UpdateItemDescWindowGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("ItemDescWindowExpanded.json") Then
                UpdateItemDescWindowExpandedGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("MenuContainer.json") Then
                UpdateMenuContainerGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("PartyWindow.json") Then
                UpdatePartyWindowGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("PlayerBox.json") Then
                UpdatePlayerBoxGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("PlayerStatusIcon.json") Then
                UpdatePlayerStatusIconGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("QuestOfferWindow.json") Then
                UpdateQuestOfferWindowGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("QuestsWindow.json") Then
                UpdateQuestsWindowGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("ShopItem.json") Then
                UpdateShopItemGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("ShopWindow.json") Then
                UpdateShopWindowGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("Spell.json") Then
                UpdateSpellGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("SpellDescWindow.json") Then
                UpdateSpellDescWindowGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("SpellDescWindowExpanded.json") Then
                UpdateSpellDescWindowExpandedGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("SpellsWindow.json") Then
                UpdateSpellsWindowGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("TargetBox.json") Then
                UpdatePlayerBoxGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("TargetStatusIcon.json") Then
                UpdateTargetStatusIconGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("TheirTradeItem.json") Then
                UpdateTheirTradeItemGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("TradeWindow.json") Then
                UpdateTradeWindowGUI(tempPath & "tmp_" & tempFileName & ".json")
            ElseIf windowname.Contains("YourTradeItem.json") Then
                UpdateYourTradeItemGUI(tempPath & "tmp_" & tempFileName & ".json")
            End If
        End Using

        My.Computer.FileSystem.DeleteFile(tempPath & "tmp_" & tempFileName & ".json")
    End Sub
End Module
