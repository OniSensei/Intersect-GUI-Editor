Imports System.IO
Imports Newtonsoft.Json

Module TradeWindowGUI
    Public Class TradeWindow
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
        Public Property InnerPanel As TradeWindowInnerPanel
    End Class

    Public Class TradeWindowInnerPanel
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
        Public Property Children As TradeWindowInnerPanelChildren
    End Class

    Public Class TradeWindowInnerPanelChildren
        Public Property YourOfferLabel As IntersectLabel
        Public Property TheirOfferLabel As IntersectLabel
        Public Property TradeButton As IntersectButton
        Public Property YourItemContainer As IntersectContainer
        Public Property YourGoldValue As IntersectLabel
        Public Property TheirItemContainer As IntersectContainer
        Public Property TheirGoldValue As IntersectLabel
    End Class

    Public Sub LoadTradeWindowGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainTradeWindowPanel.Visible = True
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
        Dim infoPull As New TradeWindow
        infoPull = JsonConvert.DeserializeObject(Of TradeWindow)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     TradeWindow.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim TitleBounds As String() = infoPull.Title.Padding.Split(",")
        Dim CloseButtonBounds As String() = infoPull.CloseButton.Bounds.Split(",")
        Dim YourOfferLabelBounds As String() = infoPull.InnerPanel.Children.YourOfferLabel.Bounds.Split(",")
        Dim TheirOfferLabelBounds As String() = infoPull.InnerPanel.Children.TheirOfferLabel.Bounds.Split(",")
        Dim TradeButtonBounds As String() = infoPull.InnerPanel.Children.TradeButton.Bounds.Split(",")
        Dim YourItemContainerBounds As String() = infoPull.InnerPanel.Children.YourItemContainer.Bounds.Split(",")
        Dim YourGoldValueBounds As String() = infoPull.InnerPanel.Children.YourGoldValue.Bounds.Split(",")
        Dim TheirItemContainerBounds As String() = infoPull.InnerPanel.Children.TheirItemContainer.Bounds.Split(",")
        Dim TheirGoldValueBounds As String() = infoPull.InnerPanel.Children.TheirGoldValue.Bounds.Split(",")

        Form1.MainTradeWindowPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainTradeWindowPanel.Width = mainwindowbounds(2)
        Form1.MainTradeWindowPanel.Height = mainwindowbounds(3)
        Form1.MainTradeWindowPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.ActiveImage)
        Form1.TradeWindowTitle.Location = New Point(TitleBounds(0), TitleBounds(1))
        Form1.TradeWindowCloseButton.Location = New Point(CloseButtonBounds(0), CloseButtonBounds(1))
        Form1.TradeWindowCloseButton.Width = CloseButtonBounds(2)
        Form1.TradeWindowCloseButton.Height = CloseButtonBounds(3)
        Form1.TradeWindowCloseButton.BackgroundImage = Image.FromFile(imgResources & infoPull.CloseButton.NormalImage)
        Form1.TradeWindowYourOfferLabel.Location = New Point(YourOfferLabelBounds(0), YourOfferLabelBounds(1))
        Form1.TradeWindowTheirOfferLabel.Location = New Point(TheirOfferLabelBounds(0), TheirOfferLabelBounds(1))
        Form1.TradeWindowTradeButton.Location = New Point(TradeButtonBounds(0), TradeButtonBounds(1))
        Form1.TradeWindowTradeButton.Width = TradeButtonBounds(2)
        Form1.TradeWindowTradeButton.Height = TradeButtonBounds(3)
        Form1.TradeWindowTradeButton.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.TradeButton.NormalImage)
        Form1.TradeWindowYourItemContainer.Location = New Point(YourItemContainerBounds(0), YourItemContainerBounds(1))
        Form1.TradeWindowYourItemContainer.Width = YourItemContainerBounds(2)
        Form1.TradeWindowYourItemContainer.Height = YourItemContainerBounds(3)
        Form1.TradeWindowYourGoldValue.Location = New Point(YourGoldValueBounds(0), YourGoldValueBounds(1))
        Form1.TradeWindowTheirItemContainer.Location = New Point(TheirItemContainerBounds(0), TheirItemContainerBounds(1))
        Form1.TradeWindowTheirItemContainer.Width = TheirItemContainerBounds(2)
        Form1.TradeWindowTheirItemContainer.Height = TheirItemContainerBounds(3)
        Form1.TradeWindowTheirGoldValue.Location = New Point(TheirGoldValueBounds(0), TheirGoldValueBounds(1))
    End Sub

    Public Sub UpdateTradeWindowGUI(ByVal jsonfile As String)
        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New TradeWindow
        infoPull = JsonConvert.DeserializeObject(Of TradeWindow)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     TradeWindow.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim TitleBounds As String() = infoPull.Title.Padding.Split(",")
        Dim CloseButtonBounds As String() = infoPull.CloseButton.Bounds.Split(",")
        Dim YourOfferLabelBounds As String() = infoPull.InnerPanel.Children.YourOfferLabel.Bounds.Split(",")
        Dim TheirOfferLabelBounds As String() = infoPull.InnerPanel.Children.TheirOfferLabel.Bounds.Split(",")
        Dim TradeButtonBounds As String() = infoPull.InnerPanel.Children.TradeButton.Bounds.Split(",")
        Dim YourItemContainerBounds As String() = infoPull.InnerPanel.Children.YourItemContainer.Bounds.Split(",")
        Dim YourGoldValueBounds As String() = infoPull.InnerPanel.Children.YourGoldValue.Bounds.Split(",")
        Dim TheirItemContainerBounds As String() = infoPull.InnerPanel.Children.TheirItemContainer.Bounds.Split(",")
        Dim TheirGoldValueBounds As String() = infoPull.InnerPanel.Children.TheirGoldValue.Bounds.Split(",")

        Form1.MainTradeWindowPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainTradeWindowPanel.Width = mainwindowbounds(2)
        Form1.MainTradeWindowPanel.Height = mainwindowbounds(3)
        Form1.MainTradeWindowPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.ActiveImage)
        Form1.TradeWindowTitle.Location = New Point(TitleBounds(0), TitleBounds(1))
        Form1.TradeWindowCloseButton.Location = New Point(CloseButtonBounds(0), CloseButtonBounds(1))
        Form1.TradeWindowCloseButton.Width = CloseButtonBounds(2)
        Form1.TradeWindowCloseButton.Height = CloseButtonBounds(3)
        Form1.TradeWindowCloseButton.BackgroundImage = Image.FromFile(imgResources & infoPull.CloseButton.NormalImage)
        Form1.TradeWindowYourOfferLabel.Location = New Point(YourOfferLabelBounds(0), YourOfferLabelBounds(1))
        Form1.TradeWindowTheirOfferLabel.Location = New Point(TheirOfferLabelBounds(0), TheirOfferLabelBounds(1))
        Form1.TradeWindowTradeButton.Location = New Point(TradeButtonBounds(0), TradeButtonBounds(1))
        Form1.TradeWindowTradeButton.Width = TradeButtonBounds(2)
        Form1.TradeWindowTradeButton.Height = TradeButtonBounds(3)
        Form1.TradeWindowTradeButton.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.TradeButton.NormalImage)
        Form1.TradeWindowYourItemContainer.Location = New Point(YourItemContainerBounds(0), YourItemContainerBounds(1))
        Form1.TradeWindowYourItemContainer.Width = YourItemContainerBounds(2)
        Form1.TradeWindowYourItemContainer.Height = YourItemContainerBounds(3)
        Form1.TradeWindowYourGoldValue.Location = New Point(YourGoldValueBounds(0), YourGoldValueBounds(1))
        Form1.TradeWindowTheirItemContainer.Location = New Point(TheirItemContainerBounds(0), TheirItemContainerBounds(1))
        Form1.TradeWindowTheirItemContainer.Width = TheirItemContainerBounds(2)
        Form1.TradeWindowTheirItemContainer.Height = TheirItemContainerBounds(3)
        Form1.TradeWindowTheirGoldValue.Location = New Point(TheirGoldValueBounds(0), TheirGoldValueBounds(1))
    End Sub
End Module
