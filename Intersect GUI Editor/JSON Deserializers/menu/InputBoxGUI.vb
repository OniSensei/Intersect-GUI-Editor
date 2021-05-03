Imports System.IO
Imports Newtonsoft.Json

Module InputBoxGUI
    Public Class InputBox
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
        Public Property ActiveImage As String
        Public Property InactiveImage As String
        Public Property ActiveColor As String
        Public Property InactiveColor As String
        Public Property Closeable As Boolean
        Public Property Titlebar As Titlebar
        Public Property Title As IntersectLabel
        Public Property Closebutton As IntersectButton
        Public Property InnerPanel As InnerPanel
    End Class

    Public Class Titlebar
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

    Public Class InnerPanel
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
        Public Property Children As InnerPanelChildren
    End Class

    Public Class InnerPanelChildren
        Public Property Textbox As InputBoxInnerPanelTextBox
        Public Property YesButton As IntersectButton
        Public Property NoButton As IntersectButton
        Public Property OkayButton As IntersectButton
        Public Property PromptLabel As IntersectLabel
    End Class

    Public Class InputBoxInnerPanelTextBox
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
        Public Property Children As InputFieldTextboxChildren
    End Class

    Public Class InputFieldTextboxChildren
        Public Property TextboxText As IntersectField
    End Class


    Public Sub LoadInputBoxGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainInputBoxPanel.Visible = True
        Form1.RefreshBtn.Visible = True
        Form1.gridToggle.Visible = True
        Form1.SaveToolStripMenuItem.Visible = True
        Form1.toolSplitContainer.Panel2.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\background.png")

        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        Form1.JTokenTreeUserControl1.SetJsonSource(Form1.fullJson.Text)
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New InputBox
        infoPull = JsonConvert.DeserializeObject(Of InputBox)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     InputBox.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim InputBoxTitleBounds As String() = infoPull.Title.TextPadding.Split(",")
        Dim InputBoxCloseButtonBounds As String() = infoPull.Closebutton.Bounds.Split(",")
        Dim InputBoxInnerPanelBounds As String() = infoPull.InnerPanel.Bounds.Split(",")
        Dim InputBoxInnerPanelTextboxBounds As String() = infoPull.InnerPanel.Children.Textbox.Bounds.Split(",")
        Dim InputBoxInnerPanelTextboxTextBounds As String() = infoPull.InnerPanel.Children.Textbox.Children.TextboxText.Bounds.Split(",")
        Dim InputBoxInnerPanelYesButtonBounds As String() = infoPull.InnerPanel.Children.YesButton.Bounds.Split(",")
        Dim InputBoxInnerPanelNoButtonBounds As String() = infoPull.InnerPanel.Children.NoButton.Bounds.Split(",")
        Dim InputBoxInnerPanelOkayButtonBounds As String() = infoPull.InnerPanel.Children.OkayButton.Bounds.Split(",")
        Dim InputBoxInnerPanelPromptLabelBounds As String() = infoPull.InnerPanel.Children.PromptLabel.Bounds.Split(",")

        Form1.MainInputBoxPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainInputBoxPanel.Width = mainwindowbounds(2)
        Form1.MainInputBoxPanel.Height = mainwindowbounds(3)
        Form1.MainInputBoxPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.ActiveImage)
        Form1.InputBoxTitle.Location = New Point(InputBoxTitleBounds(0), InputBoxTitleBounds(1))
        Form1.InputBoxCloseButton.Location = New Point(InputBoxCloseButtonBounds(0), InputBoxCloseButtonBounds(1))
        Form1.InputBoxCloseButton.Width = InputBoxCloseButtonBounds(2)
        Form1.InputBoxCloseButton.Height = InputBoxCloseButtonBounds(3)
        Form1.InputBoxCloseButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Closebutton.NormalImage)
        Form1.InputBoxInnerPanel.Location = New Point(InputBoxInnerPanelBounds(0), InputBoxInnerPanelBounds(1))
        Form1.InputBoxInnerPanel.Width = InputBoxInnerPanelBounds(2)
        Form1.InputBoxInnerPanel.Height = InputBoxInnerPanelBounds(3)
        Form1.InputBoxTextBox.Location = New Point(InputBoxInnerPanelTextboxBounds(0), InputBoxInnerPanelTextboxBounds(1))
        Form1.InputBoxTextBox.Width = InputBoxInnerPanelTextboxBounds(2)
        Form1.InputBoxTextBox.Height = InputBoxInnerPanelTextboxBounds(3)
        Form1.InputBoxTextBox.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.Textbox.Texture)
        Form1.InputBoxTextboxText.Location = New Point(InputBoxInnerPanelTextboxTextBounds(0), InputBoxInnerPanelTextboxTextBounds(1))
        Form1.InputBoxTextboxText.Width = InputBoxInnerPanelTextboxTextBounds(2)
        Form1.InputBoxTextboxText.Height = InputBoxInnerPanelTextboxTextBounds(3)
        Form1.YesButton.Location = New Point(InputBoxInnerPanelYesButtonBounds(0), InputBoxInnerPanelYesButtonBounds(1))
        Form1.YesButton.Width = InputBoxInnerPanelYesButtonBounds(2)
        Form1.YesButton.Height = InputBoxInnerPanelYesButtonBounds(3)
        Form1.YesButton.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.YesButton.NormalImage)
        Form1.NoButton.Location = New Point(InputBoxInnerPanelNoButtonBounds(0), InputBoxInnerPanelNoButtonBounds(1))
        Form1.NoButton.Width = InputBoxInnerPanelNoButtonBounds(2)
        Form1.NoButton.Height = InputBoxInnerPanelNoButtonBounds(3)
        Form1.NoButton.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.NoButton.NormalImage)
        Form1.OkayButton.Location = New Point(InputBoxInnerPanelOkayButtonBounds(0), InputBoxInnerPanelOkayButtonBounds(1))
        Form1.OkayButton.Width = InputBoxInnerPanelOkayButtonBounds(2)
        Form1.OkayButton.Height = InputBoxInnerPanelOkayButtonBounds(3)
        Form1.OkayButton.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.OkayButton.NormalImage)
        Form1.PromptLabel.Location = New Point(InputBoxInnerPanelPromptLabelBounds(0), InputBoxInnerPanelPromptLabelBounds(1))
        Form1.PromptLabel.Width = InputBoxInnerPanelPromptLabelBounds(2)
        Form1.PromptLabel.Height = InputBoxInnerPanelPromptLabelBounds(3)
    End Sub
End Module
