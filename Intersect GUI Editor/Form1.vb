Imports System.IO
Imports System.Text
Imports Newtonsoft.Json

Public Class Form1
    Private _rnd As New Random()
    Function RandomNumber(ByVal low As Integer, ByVal high As Integer) As Integer
        Return _rnd.Next(low, high)
    End Function

    Public tempPath As String = Application.StartupPath & "\temp\"
    Public menuGuiPath As String = Application.StartupPath & "\gui\layouts\menu\"
    Public gameGuiPath As String = Application.StartupPath & "\gui\layouts\game\"
    Public tempFileName As String
    Public openFile As String
    Dim loginchecked As Boolean = False
    Dim malechecked As Boolean = False
    Dim femalechecked As Boolean = False
    Dim gridoverlay As Boolean = False

    Private Sub statusTxtBox_TextChanged(sender As Object, e As EventArgs) Handles statusTxtBox.TextChanged
        statusTxtBox.ScrollToCaret()
        statusTxtBox.Refresh()
    End Sub

    Public Sub StatusText(ByVal text As String)
        Dim sb As StringBuilder = New StringBuilder
        sb.Append(statusTxtBox.Text)
        sb.Append(text).AppendLine()
        statusTxtBox.Text = sb.ToString
    End Sub

    Private Sub LoginWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginWindowToolStripMenuItem.Click
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False

        LoadLoginGUI(menuGuiPath & "LoginWindow.json")
        openFile = menuGuiPath & "LoginWindow.json"
    End Sub

    Private Sub CharacterCreationWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CharacterCreationWindowToolStripMenuItem.Click
        MainLoginWindowPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False

        LoadCharacterCreationGUI(menuGuiPath & "CharacterCreationWindow.json")
        openFile = menuGuiPath & "CharacterCreationWindow.json"
    End Sub

    Private Sub CharacterSelectionWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CharacterSelectionWindowToolStripMenuItem.Click
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False

        LoadCharacterSelectionGUI(menuGuiPath & "CharacterSelectionWindow.json")
        openFile = menuGuiPath & "CharacterSelectionWindow.json"
    End Sub

    Private Sub CreditsWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditsWindowToolStripMenuItem.Click
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False
        MainInputBoxPanel.Visible = False

        LoadCreditsGUI(menuGuiPath & "CreditsWindow.json")
        openFile = menuGuiPath & "CreditsWindow.json"
    End Sub

    Private Sub ForgotPasswordWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForgotPasswordWindowToolStripMenuItem.Click
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainInputBoxPanel.Visible = False

        LoadForgotPasswordGUI(menuGuiPath & "ForgotPasswordWindow.json")
        openFile = menuGuiPath & "ForgotPasswordWindow.json"
    End Sub

    Private Sub InputBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputBoxToolStripMenuItem.Click
        MainLoginWindowPanel.Visible = False
        MainCharacterCreationPanel.Visible = False
        MainCharSelectionPanel.Visible = False
        MainCreditsPanel.Visible = False
        MainForgotPasswordWindowPanel.Visible = False

        LoadInputBoxGUI(menuGuiPath & "InputBox.json")
        openFile = menuGuiPath & "InputBox.json"
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
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        If jsonType.Text <> "Object" AndAlso jsonType.Text <> "Property" Then
            StatusText("[MAIN]     Updating TreeView")
            JTokenTreeUserControl1.UpdateSelected(jsonValue.Text)
            jsonValue.Text = JsonConvert.SerializeObject(
                JsonConvert.DeserializeObject(jsonValue.Text),
                Formatting.Indented)

            tempFileName = RandomNumber(10000, 10000000)

            Using writer = New FileStream(tempPath & "tmp_" & tempFileName & ".json", FileMode.Create)
                JTokenTreeUserControl1.SaveJson(writer)
            End Using

            Using reader = New StreamReader(tempPath & "tmp_" & tempFileName & ".json")
                If openFile.Contains("LoginWindow") Then
                    LoadLoginGUI(tempPath & "tmp_" & tempFileName & ".json")
                ElseIf openFile.Contains("CharacterCreationWindow") Then
                    LoadCharacterCreationGUI(tempPath & "tmp_" & tempFileName & ".json")
                ElseIf openFile.Contains("CharacterSelectionWindow") Then
                    LoadCharacterSelectionGUI(tempPath & "tmp_" & tempFileName & ".json")
                ElseIf openFile.Contains("CreditsWindow") Then
                    LoadCreditsGUI(tempPath & "tmp_" & tempFileName & ".json")
                ElseIf openFile.Contains("ForgotPasswordWindow") Then
                    LoadForgotPasswordGUI(tempPath & "tmp_" & tempFileName & ".json")
                ElseIf openFile.Contains("InputBox") Then
                    LoadInputBoxGUI(tempPath & "tmp_" & tempFileName & ".json")
                End If
            End Using

            My.Computer.FileSystem.DeleteFile(tempPath & "tmp_" & tempFileName & ".json")
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Using writer = New FileStream(openFile, FileMode.Open)
            JTokenTreeUserControl1.SaveJson(writer)
            StatusText("[MAIN]     Saving " & openFile)
        End Using
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

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        StatusText("[MAIN]     Refreshing")
        If openFile.Contains("LoginWindow") Then
            LoadLoginGUI(openFile)
        ElseIf openFile.Contains("CharacterCreationWindow") Then
            LoadCharacterCreationGUI(openFile)
        ElseIf openFile.Contains("CharacterSelectionWindow") Then
            LoadCharacterSelectionGUI(openFile)
        ElseIf openFile.Contains("CreditsWindow") Then
            LoadCreditsGUI(openFile)
        ElseIf openFile.Contains("ForgotPasswordWindow") Then
            LoadForgotPasswordGUI(openFile)
        ElseIf openFile.Contains("InputBox") Then
            LoadInputBoxGUI(openFile)
        End If
    End Sub

    Private Sub MeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles gridToggle.Click
        If gridoverlay Then
            gridoverlay = False
            toolSplitContainer.Panel2.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\background.png")
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
End Class
