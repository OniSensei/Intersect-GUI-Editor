Imports System.IO
Imports Newtonsoft.Json

Module GameInputBoxGUI
    Public Class GameInputBox
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
        Public Property InnerPanel As GameInputBoxInnerPanel
    End Class

    Public Class GameInputBoxInnerPanel
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
        Public Property Children As GameInputBoxInnerPanelChildren
    End Class

    Public Class GameInputBoxInnerPanelChildren
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

    Public Sub LoadGameInputBoxGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainGameInputBoxPanel.Visible = True
        Form1.RefreshBtn.Visible = True
        Form1.gridToggle.Visible = True
        Form1.SaveToolStripMenuItem.Visible = True
        Form1.toolSplitContainer.Panel2.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\background.png")

        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        Form1.JTokenTreeUserControl1.SetJsonSource(Form1.fullJson.Text)
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New GameInputBox
        infoPull = JsonConvert.DeserializeObject(Of GameInputBox)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     InputBox.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim InputBoxTitleBounds As String() = infoPull.Title.TextPadding.Split(",")
        Dim InputBoxCloseButtonBounds As String() = infoPull.CloseButton.Bounds.Split(",")
        Dim InputBoxInnerPanelTextboxBounds As String() = infoPull.InnerPanel.Children.Textbox.Bounds.Split(",")
        Dim InputBoxInnerPanelTextboxTextBounds As String() = infoPull.InnerPanel.Children.Textbox.Children.TextboxText.Bounds.Split(",")
        Dim InputBoxInnerPanelYesButtonBounds As String() = infoPull.InnerPanel.Children.YesButton.Bounds.Split(",")
        Dim InputBoxInnerPanelNoButtonBounds As String() = infoPull.InnerPanel.Children.NoButton.Bounds.Split(",")
        Dim InputBoxInnerPanelOkayButtonBounds As String() = infoPull.InnerPanel.Children.OkayButton.Bounds.Split(",")
        Dim InputBoxInnerPanelPromptLabelBounds As String() = infoPull.InnerPanel.Children.PromptLabel.Bounds.Split(",")

        Form1.MainGameInputBoxPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainGameInputBoxPanel.Width = mainwindowbounds(2)
        Form1.MainGameInputBoxPanel.Height = mainwindowbounds(3)
        Form1.MainGameInputBoxPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.ActiveImage)
        Form1.GameInputboxTitle.Location = New Point(InputBoxTitleBounds(0), InputBoxTitleBounds(1))
        Form1.GameInputBoxCloseButton.Location = New Point(InputBoxCloseButtonBounds(0), InputBoxCloseButtonBounds(1))
        Form1.GameInputBoxCloseButton.Width = InputBoxCloseButtonBounds(2)
        Form1.GameInputBoxCloseButton.Height = InputBoxCloseButtonBounds(3)
        Form1.GameInputBoxCloseButton.BackgroundImage = Image.FromFile(imgResources & infoPull.CloseButton.NormalImage)
        Form1.GameInputBoxTextBox.Location = New Point(InputBoxInnerPanelTextboxBounds(0), InputBoxInnerPanelTextboxBounds(1))
        Form1.GameInputBoxTextBox.Width = InputBoxInnerPanelTextboxBounds(2)
        Form1.GameInputBoxTextBox.Height = InputBoxInnerPanelTextboxBounds(3)
        Form1.GameInputBoxTextBox.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.Textbox.Texture)
        Form1.GameInputBoxTextboxText.Location = New Point(InputBoxInnerPanelTextboxTextBounds(0), InputBoxInnerPanelTextboxTextBounds(1))
        Form1.GameInputBoxTextboxText.Width = InputBoxInnerPanelTextboxTextBounds(2)
        Form1.GameInputBoxTextboxText.Height = InputBoxInnerPanelTextboxTextBounds(3)
        Form1.GameInputYesButton.Location = New Point(InputBoxInnerPanelYesButtonBounds(0), InputBoxInnerPanelYesButtonBounds(1))
        Form1.GameInputYesButton.Width = InputBoxInnerPanelYesButtonBounds(2)
        Form1.GameInputYesButton.Height = InputBoxInnerPanelYesButtonBounds(3)
        Form1.GameInputYesButton.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.YesButton.NormalImage)
        Form1.GameInputNoButton.Location = New Point(InputBoxInnerPanelNoButtonBounds(0), InputBoxInnerPanelNoButtonBounds(1))
        Form1.GameInputNoButton.Width = InputBoxInnerPanelNoButtonBounds(2)
        Form1.GameInputNoButton.Height = InputBoxInnerPanelNoButtonBounds(3)
        Form1.GameInputNoButton.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.NoButton.NormalImage)
        Form1.GameInputOkayButton.Location = New Point(InputBoxInnerPanelOkayButtonBounds(0), InputBoxInnerPanelOkayButtonBounds(1))
        Form1.GameInputOkayButton.Width = InputBoxInnerPanelOkayButtonBounds(2)
        Form1.GameInputOkayButton.Height = InputBoxInnerPanelOkayButtonBounds(3)
        Form1.GameInputOkayButton.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.OkayButton.NormalImage)
        Form1.GameInputPromptLabel.Location = New Point(InputBoxInnerPanelPromptLabelBounds(0), InputBoxInnerPanelPromptLabelBounds(1))
        Form1.GameInputPromptLabel.Width = InputBoxInnerPanelPromptLabelBounds(2)
        Form1.GameInputPromptLabel.Height = InputBoxInnerPanelPromptLabelBounds(3)
    End Sub

    Public Sub UpdateGameInputBoxGUI(ByVal jsonfile As String)
        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New GameInputBox
        infoPull = JsonConvert.DeserializeObject(Of GameInputBox)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     InputBox.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim InputBoxTitleBounds As String() = infoPull.Title.TextPadding.Split(",")
        Dim InputBoxCloseButtonBounds As String() = infoPull.CloseButton.Bounds.Split(",")
        Dim InputBoxInnerPanelTextboxBounds As String() = infoPull.InnerPanel.Children.Textbox.Bounds.Split(",")
        Dim InputBoxInnerPanelTextboxTextBounds As String() = infoPull.InnerPanel.Children.Textbox.Children.TextboxText.Bounds.Split(",")
        Dim InputBoxInnerPanelYesButtonBounds As String() = infoPull.InnerPanel.Children.YesButton.Bounds.Split(",")
        Dim InputBoxInnerPanelNoButtonBounds As String() = infoPull.InnerPanel.Children.NoButton.Bounds.Split(",")
        Dim InputBoxInnerPanelOkayButtonBounds As String() = infoPull.InnerPanel.Children.OkayButton.Bounds.Split(",")
        Dim InputBoxInnerPanelPromptLabelBounds As String() = infoPull.InnerPanel.Children.PromptLabel.Bounds.Split(",")

        Form1.MainGameInputBoxPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainGameInputBoxPanel.Width = mainwindowbounds(2)
        Form1.MainGameInputBoxPanel.Height = mainwindowbounds(3)
        Form1.MainGameInputBoxPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.ActiveImage)
        Form1.GameInputboxTitle.Location = New Point(InputBoxTitleBounds(0), InputBoxTitleBounds(1))
        Form1.GameInputBoxCloseButton.Location = New Point(InputBoxCloseButtonBounds(0), InputBoxCloseButtonBounds(1))
        Form1.GameInputBoxCloseButton.Width = InputBoxCloseButtonBounds(2)
        Form1.GameInputBoxCloseButton.Height = InputBoxCloseButtonBounds(3)
        Form1.GameInputBoxCloseButton.BackgroundImage = Image.FromFile(imgResources & infoPull.CloseButton.NormalImage)
        Form1.GameInputBoxTextBox.Location = New Point(InputBoxInnerPanelTextboxBounds(0), InputBoxInnerPanelTextboxBounds(1))
        Form1.GameInputBoxTextBox.Width = InputBoxInnerPanelTextboxBounds(2)
        Form1.GameInputBoxTextBox.Height = InputBoxInnerPanelTextboxBounds(3)
        Form1.GameInputBoxTextBox.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.Textbox.Texture)
        Form1.GameInputBoxTextboxText.Location = New Point(InputBoxInnerPanelTextboxTextBounds(0), InputBoxInnerPanelTextboxTextBounds(1))
        Form1.GameInputBoxTextboxText.Width = InputBoxInnerPanelTextboxTextBounds(2)
        Form1.GameInputBoxTextboxText.Height = InputBoxInnerPanelTextboxTextBounds(3)
        Form1.GameInputYesButton.Location = New Point(InputBoxInnerPanelYesButtonBounds(0), InputBoxInnerPanelYesButtonBounds(1))
        Form1.GameInputYesButton.Width = InputBoxInnerPanelYesButtonBounds(2)
        Form1.GameInputYesButton.Height = InputBoxInnerPanelYesButtonBounds(3)
        Form1.GameInputYesButton.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.YesButton.NormalImage)
        Form1.GameInputNoButton.Location = New Point(InputBoxInnerPanelNoButtonBounds(0), InputBoxInnerPanelNoButtonBounds(1))
        Form1.GameInputNoButton.Width = InputBoxInnerPanelNoButtonBounds(2)
        Form1.GameInputNoButton.Height = InputBoxInnerPanelNoButtonBounds(3)
        Form1.GameInputNoButton.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.NoButton.NormalImage)
        Form1.GameInputOkayButton.Location = New Point(InputBoxInnerPanelOkayButtonBounds(0), InputBoxInnerPanelOkayButtonBounds(1))
        Form1.GameInputOkayButton.Width = InputBoxInnerPanelOkayButtonBounds(2)
        Form1.GameInputOkayButton.Height = InputBoxInnerPanelOkayButtonBounds(3)
        Form1.GameInputOkayButton.BackgroundImage = Image.FromFile(imgResources & infoPull.InnerPanel.Children.OkayButton.NormalImage)
        Form1.GameInputPromptLabel.Location = New Point(InputBoxInnerPanelPromptLabelBounds(0), InputBoxInnerPanelPromptLabelBounds(1))
        Form1.GameInputPromptLabel.Width = InputBoxInnerPanelPromptLabelBounds(2)
        Form1.GameInputPromptLabel.Height = InputBoxInnerPanelPromptLabelBounds(3)
    End Sub
End Module
