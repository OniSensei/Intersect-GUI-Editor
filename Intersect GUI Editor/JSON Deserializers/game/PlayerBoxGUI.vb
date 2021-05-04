Imports System.IO
Imports Newtonsoft.Json

Module PlayerBoxGUI
    Public Class PlayerBox
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
        Public Property EntityInfoPanel As EntityInfoPanel
        Public Property StatusArea As IntersectIcon
    End Class

    Public Class EntityInfoPanel
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
        Public Property Children As EntityInfoPanelChildren
    End Class

    Public Class EntityInfoPanelChildren
        Public Property EntityNameLabel As IntersectLabel
        Public Property EntityLevelLabel As IntersectLabel
        Public Property NameAndLevelLabel As IntersectLabel
        Public Property EntityMapLabel As IntersectLabel
        Public Property EntityGraphicContainer As IntersectIcon
        Public Property EventDescLabel As IntersectLabel
        Public Property HPBarBackground As IntersectIcon
        Public Property HPBar As IntersectIcon
        Public Property ShieldBar As IntersectIcon
        Public Property HPTitle As IntersectLabel
        Public Property HPLabel As IntersectLabel
        Public Property MPBackground As IntersectIcon
        Public Property MPBar As IntersectIcon
        Public Property MPTitle As IntersectLabel
        Public Property MPLabel As IntersectLabel
        Public Property EXPBackground As IntersectIcon
        Public Property EXPBar As IntersectIcon
        Public Property EXPTitle As IntersectLabel
        Public Property EXPLabel As IntersectLabel
        Public Property TradeButton As IntersectButton
        Public Property PartyButton As IntersectButton
        Public Property FriendButton As IntersectButton
    End Class

    Public Sub LoadPlayerBoxGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainPlayerBoxPanel.Visible = True
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
        Dim infoPull As New PlayerBox
        infoPull = JsonConvert.DeserializeObject(Of PlayerBox)(Form1.fullJson.Text)
        If jsonfile.Contains("TargetBox.json") Then
            Form1.StatusText("[MAIN]     TargetBox.json Deserialized")
        Else
            Form1.StatusText("[MAIN]     PlayerBox.json Deserialized")
        End If

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim EntityInfoPanelBounds As String() = infoPull.Children.EntityInfoPanel.Bounds.Split(",")
        Dim EntityNameLabelBounds As String() = infoPull.Children.EntityInfoPanel.Children.EntityNameLabel.Bounds.Split(",")
        Dim EntityLevelLabelBounds As String() = infoPull.Children.EntityInfoPanel.Children.EntityLevelLabel.Bounds.Split(",")
        Dim NameAndLevelLabelBounds As String() = infoPull.Children.EntityInfoPanel.Children.NameAndLevelLabel.Bounds.Split(",")
        Dim EntityMapLabelBounds As String() = infoPull.Children.EntityInfoPanel.Children.EntityMapLabel.Bounds.Split(",")
        Dim EntityGraphicContainerBounds As String() = infoPull.Children.EntityInfoPanel.Children.EntityGraphicContainer.Bounds.Split(",")
        Dim HPBarBackgroundBounds As String() = infoPull.Children.EntityInfoPanel.Children.HPBarBackground.Bounds.Split(",")
        Dim HPBarBounds As String() = infoPull.Children.EntityInfoPanel.Children.HPBar.Bounds.Split(",")
        Dim ShieldBarBounds As String() = infoPull.Children.EntityInfoPanel.Children.ShieldBar.Bounds.Split(",")
        Dim HPTitleBounds As String() = infoPull.Children.EntityInfoPanel.Children.HPTitle.Bounds.Split(",")
        Dim HPLabelBounds As String() = infoPull.Children.EntityInfoPanel.Children.HPLabel.Bounds.Split(",")
        Dim MPBackgroundBounds As String() = infoPull.Children.EntityInfoPanel.Children.MPBackground.Bounds.Split(",")
        Dim MPBarBounds As String() = infoPull.Children.EntityInfoPanel.Children.MPBar.Bounds.Split(",")
        Dim MPTitleBounds As String() = infoPull.Children.EntityInfoPanel.Children.MPTitle.Bounds.Split(",")
        Dim MPLabelBounds As String() = infoPull.Children.EntityInfoPanel.Children.MPLabel.Bounds.Split(",")
        Dim EXPBackgroundBounds As String() = infoPull.Children.EntityInfoPanel.Children.EXPBackground.Bounds.Split(",")
        Dim EXPBarBounds As String() = infoPull.Children.EntityInfoPanel.Children.EXPBar.Bounds.Split(",")
        Dim EXPTitleBounds As String() = infoPull.Children.EntityInfoPanel.Children.EXPTitle.Bounds.Split(",")
        Dim EXPLabelBounds As String() = infoPull.Children.EntityInfoPanel.Children.EXPLabel.Bounds.Split(",")
        Dim TradeButtonBounds As String() = infoPull.Children.EntityInfoPanel.Children.TradeButton.Bounds.Split(",")
        Dim PartyButtonBounds As String() = infoPull.Children.EntityInfoPanel.Children.PartyButton.Bounds.Split(",")
        Dim FriendButtonBounds As String() = infoPull.Children.EntityInfoPanel.Children.FriendButton.Bounds.Split(",")

        Form1.MainPlayerBoxPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainPlayerBoxPanel.Width = mainwindowbounds(2)
        Form1.MainPlayerBoxPanel.Height = mainwindowbounds(3)
        Form1.EntityInfoPanel.Location = New Point(EntityInfoPanelBounds(0), EntityInfoPanelBounds(1))
        Form1.EntityInfoPanel.Width = EntityInfoPanelBounds(2)
        Form1.EntityInfoPanel.Height = EntityInfoPanelBounds(3)
        Form1.EntityInfoPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.EntityInfoPanel.Texture)
        Form1.EntityNameLabel.Location = New Point(EntityNameLabelBounds(0), EntityNameLabelBounds(1))
        Form1.EntityLevelLabel.Location = New Point(EntityLevelLabelBounds(0), EntityLevelLabelBounds(1))
        Form1.NameAndLevelLabel.Location = New Point(NameAndLevelLabelBounds(0), NameAndLevelLabelBounds(1))
        Form1.EntityMapLabel.Location = New Point(EntityMapLabelBounds(0), EntityMapLabelBounds(1))
        Form1.EntityGraphicContainer.Location = New Point(EntityGraphicContainerBounds(0), EntityGraphicContainerBounds(1))
        Form1.EntityGraphicContainer.Width = EntityGraphicContainerBounds(2)
        Form1.EntityGraphicContainer.Height = EntityGraphicContainerBounds(3)
        Form1.HPBarBackground.Location = New Point(HPBarBackgroundBounds(0), HPBarBackgroundBounds(1))
        Form1.HPBarBackground.Width = HPBarBackgroundBounds(2)
        Form1.HPBarBackground.Height = HPBarBackgroundBounds(3)
        Form1.HPBarBackground.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.EntityInfoPanel.Children.HPBarBackground.Texture)
        Form1.HPBar.Location = New Point(HPBarBounds(0), HPBarBounds(1))
        Form1.HPBar.Width = HPBarBounds(2)
        Form1.HPBar.Height = HPBarBounds(3)
        Form1.HPBar.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.EntityInfoPanel.Children.HPBar.Texture)
        Form1.ShieldBar.Location = New Point(ShieldBarBounds(0), ShieldBarBounds(1))
        Form1.ShieldBar.Width = ShieldBarBounds(2)
        Form1.ShieldBar.Height = ShieldBarBounds(3)
        Form1.ShieldBar.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.EntityInfoPanel.Children.ShieldBar.Texture)
        Form1.HPTitle.Location = New Point(HPTitleBounds(0), HPTitleBounds(1))
        Form1.HPLabel.Location = New Point(HPLabelBounds(0), HPLabelBounds(1))
        Form1.MPBackground.Location = New Point(MPBackgroundBounds(0), MPBackgroundBounds(1))
        Form1.MPBackground.Width = MPBackgroundBounds(2)
        Form1.MPBackground.Height = MPBackgroundBounds(3)
        Form1.MPBackground.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.EntityInfoPanel.Children.MPBackground.Texture)
        Form1.MPBar.Location = New Point(MPBarBounds(0), MPBarBounds(1))
        Form1.MPBar.Width = MPBarBounds(2)
        Form1.MPBar.Height = MPBarBounds(3)
        Form1.MPBar.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.EntityInfoPanel.Children.MPBar.Texture)
        Form1.MPTitle.Location = New Point(MPTitleBounds(0), MPTitleBounds(1))
        Form1.MPLabel.Location = New Point(MPLabelBounds(0), MPLabelBounds(1))
        Form1.EXPBackground.Location = New Point(EXPBackgroundBounds(0), EXPBackgroundBounds(1))
        Form1.EXPBackground.Width = EXPBackgroundBounds(2)
        Form1.EXPBackground.Height = EXPBackgroundBounds(3)
        Form1.EXPBackground.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.EntityInfoPanel.Children.EXPBackground.Texture)
        Form1.EXPBar.Location = New Point(EXPBarBounds(0), EXPBarBounds(1))
        Form1.EXPBar.Width = EXPBarBounds(2)
        Form1.EXPBar.Height = EXPBarBounds(3)
        Form1.EXPBar.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.EntityInfoPanel.Children.EXPBar.Texture)
        Form1.EXPTitle.Location = New Point(EXPTitleBounds(0), EXPTitleBounds(1))
        Form1.EXPLabel.Location = New Point(EXPLabelBounds(0), EXPLabelBounds(1))
        Form1.PlayerBoxTradeButton.Location = New Point(TradeButtonBounds(0), TradeButtonBounds(1))
        Form1.PlayerBoxTradeButton.Width = TradeButtonBounds(2)
        Form1.PlayerBoxTradeButton.Height = TradeButtonBounds(3)
        Form1.PlayerBoxPartyButton.Location = New Point(PartyButtonBounds(0), PartyButtonBounds(1))
        Form1.PlayerBoxPartyButton.Width = PartyButtonBounds(2)
        Form1.PlayerBoxPartyButton.Height = PartyButtonBounds(3)
        Form1.PlayerBoxFriendButton.Location = New Point(FriendButtonBounds(0), FriendButtonBounds(1))
        Form1.PlayerBoxFriendButton.Width = FriendButtonBounds(2)
        Form1.PlayerBoxFriendButton.Height = FriendButtonBounds(3)
    End Sub
End Module
