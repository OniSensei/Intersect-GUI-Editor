Imports System.IO
Imports Newtonsoft.Json

Module MenuContainerGUI
    Public Class MenuContainer
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
        Public Property InventoryContainer As IntersectMenuContainer
        Public Property SpellsContainer As IntersectMenuContainer
        Public Property CharacterContainer As IntersectMenuContainer
        Public Property QuestsContainer As IntersectMenuContainer
        Public Property FriendsContainer As IntersectMenuContainer
        Public Property PartyContainer As IntersectMenuContainer
        Public Property MenuContainer As IntersectMenuContainer
    End Class

    Public Sub LoadMenuContainerGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainMenuContainerPanel.Visible = True
        Form1.RefreshBtn.Visible = True
        Form1.gridToggle.Visible = True
        Form1.toolSplitContainer.Panel2.BackColor = Color.Gray
        Form1.toolSplitContainer.Panel2.BackgroundImage = Nothing

        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        Form1.JTokenTreeUserControl1.SetJsonSource(Form1.fullJson.Text)
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New MenuContainer
        infoPull = JsonConvert.DeserializeObject(Of MenuContainer)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     MenuContainer.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim InventoryContainerBounds As String() = infoPull.Children.InventoryContainer.Bounds.Split(",")
        Dim SpellsContainerBounds As String() = infoPull.Children.SpellsContainer.Bounds.Split(",")
        Dim CharacterContainerBounds As String() = infoPull.Children.CharacterContainer.Bounds.Split(",")
        Dim QuestsContainerBounds As String() = infoPull.Children.QuestsContainer.Bounds.Split(",")
        Dim FriendsContainerBounds As String() = infoPull.Children.FriendsContainer.Bounds.Split(",")
        Dim PartyContainerBounds As String() = infoPull.Children.PartyContainer.Bounds.Split(",")
        Dim MenuContainerBounds As String() = infoPull.Children.MenuContainer.Bounds.Split(",")
        Dim InventoryButtonBounds As String() = infoPull.Children.InventoryContainer.Children.InventoryButton.Bounds.Split(",")
        Dim SpellsButtonBounds As String() = infoPull.Children.SpellsContainer.Children.SpellsButton.Bounds.Split(",")
        Dim CharacterButtonBounds As String() = infoPull.Children.CharacterContainer.Children.CharacterButton.Bounds.Split(",")
        Dim QuestsButtonBounds As String() = infoPull.Children.QuestsContainer.Children.QuestsButton.Bounds.Split(",")
        Dim FriendsButtonBounds As String() = infoPull.Children.FriendsContainer.Children.FriendsButton.Bounds.Split(",")
        Dim PartyButtonBounds As String() = infoPull.Children.PartyContainer.Children.PartyButton.Bounds.Split(",")
        Dim MenuButtonBounds As String() = infoPull.Children.MenuContainer.Children.MenuButton.Bounds.Split(",")

        Form1.MainMenuContainerPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainMenuContainerPanel.Width = mainwindowbounds(2)
        Form1.MainMenuContainerPanel.Height = mainwindowbounds(3)
        Form1.MainMenuContainerPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.InventoryContainer.Location = New Point(InventoryContainerBounds(0), InventoryContainerBounds(1))
        Form1.InventoryContainer.Width = InventoryContainerBounds(2)
        Form1.InventoryContainer.Height = InventoryContainerBounds(3)
        Form1.InventoryContainer.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.InventoryContainer.Texture)
        Form1.InventoryButton.Location = New Point(InventoryButtonBounds(0), InventoryButtonBounds(1))
        Form1.InventoryButton.Width = InventoryButtonBounds(2)
        Form1.InventoryButton.Height = InventoryButtonBounds(3)
        Form1.InventoryButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.InventoryContainer.Children.InventoryButton.NormalImage)
        Form1.SpellsContainer.Location = New Point(SpellsContainerBounds(0), SpellsContainerBounds(1))
        Form1.SpellsContainer.Width = SpellsContainerBounds(2)
        Form1.SpellsContainer.Height = SpellsContainerBounds(3)
        Form1.SpellsContainer.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.SpellsContainer.Texture)
        Form1.SpellsButton.Location = New Point(SpellsButtonBounds(0), SpellsButtonBounds(1))
        Form1.SpellsButton.Width = SpellsButtonBounds(2)
        Form1.SpellsButton.Height = SpellsButtonBounds(3)
        Form1.SpellsButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.SpellsContainer.Children.SpellsButton.NormalImage)
        Form1.MenuCharacterContainer.Location = New Point(CharacterContainerBounds(0), CharacterContainerBounds(1))
        Form1.MenuCharacterContainer.Width = CharacterContainerBounds(2)
        Form1.MenuCharacterContainer.Height = CharacterContainerBounds(3)
        Form1.MenuCharacterContainer.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.CharacterContainer.Texture)
        Form1.CharacterButton.Location = New Point(CharacterButtonBounds(0), CharacterButtonBounds(1))
        Form1.CharacterButton.Width = CharacterButtonBounds(2)
        Form1.CharacterButton.Height = CharacterButtonBounds(3)
        Form1.CharacterButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.CharacterContainer.Children.CharacterButton.NormalImage)
        Form1.QuestsContainer.Location = New Point(QuestsContainerBounds(0), QuestsContainerBounds(1))
        Form1.QuestsContainer.Width = QuestsContainerBounds(2)
        Form1.QuestsContainer.Height = QuestsContainerBounds(3)
        Form1.QuestsContainer.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.QuestsContainer.Texture)
        Form1.QuestsButton.Location = New Point(QuestsButtonBounds(0), QuestsButtonBounds(1))
        Form1.QuestsButton.Width = QuestsButtonBounds(2)
        Form1.QuestsButton.Height = QuestsButtonBounds(3)
        Form1.QuestsButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.QuestsContainer.Children.QuestsButton.NormalImage)
        Form1.FriendsContainer.Location = New Point(FriendsContainerBounds(0), FriendsContainerBounds(1))
        Form1.FriendsContainer.Width = FriendsContainerBounds(2)
        Form1.FriendsContainer.Height = FriendsContainerBounds(3)
        Form1.FriendsContainer.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.FriendsContainer.Texture)
        Form1.FriendsButton.Location = New Point(FriendsButtonBounds(0), FriendsButtonBounds(1))
        Form1.FriendsButton.Width = FriendsButtonBounds(2)
        Form1.FriendsButton.Height = FriendsButtonBounds(3)
        Form1.FriendsButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.FriendsContainer.Children.FriendsButton.NormalImage)
        Form1.PartyContainer.Location = New Point(PartyContainerBounds(0), PartyContainerBounds(1))
        Form1.PartyContainer.Width = PartyContainerBounds(2)
        Form1.PartyContainer.Height = PartyContainerBounds(3)
        Form1.PartyContainer.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.PartyContainer.Texture)
        Form1.PartyButton.Location = New Point(PartyButtonBounds(0), PartyButtonBounds(1))
        Form1.PartyButton.Width = PartyButtonBounds(2)
        Form1.PartyButton.Height = PartyButtonBounds(3)
        Form1.PartyButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.PartyContainer.Children.PartyButton.NormalImage)
        Form1.MenuContainer.Location = New Point(MenuContainerBounds(0), MenuContainerBounds(1))
        Form1.MenuContainer.Width = MenuContainerBounds(2)
        Form1.MenuContainer.Height = MenuContainerBounds(3)
        Form1.MenuContainer.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.MenuContainer.Texture)
        Form1.MenuButton.Location = New Point(MenuButtonBounds(0), MenuButtonBounds(1))
        Form1.MenuButton.Width = MenuButtonBounds(2)
        Form1.MenuButton.Height = MenuButtonBounds(3)
        Form1.MenuButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.MenuContainer.Children.MenuButton.NormalImage)
    End Sub
End Module
