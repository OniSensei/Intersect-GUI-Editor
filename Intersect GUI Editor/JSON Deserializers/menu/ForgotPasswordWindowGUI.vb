Imports System.IO
Imports Newtonsoft.Json

Module ForgotPasswordWindowGUI
    Public Class ForgotPasswordWindow
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
        Public Property Header As IntersectLabel
        Public Property InputPanel As ForgotPasswordInputPanel
        Public Property HintLabel As IntersectLabel
        Public Property SubmitButton As IntersectButton
        Public Property BackButton As IntersectButton
    End Class

    Public Class ForgotPasswordInputPanel
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
        Public Property Children As ForgotPasswordInputPanelChildren
    End Class

    Public Class ForgotPasswordInputPanelChildren
        Public Property InputLabel As IntersectLabel
        Public Property InputField As IntersectField
    End Class

    Public Sub LoadForgotPasswordGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainForgotPasswordWindowPanel.Visible = True
        Form1.RefreshBtn.Visible = True
        Form1.gridToggle.Visible = True
        Form1.SaveToolStripMenuItem.Visible = True
        Form1.toolSplitContainer.Panel2.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\background.png")

        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        Form1.JTokenTreeUserControl1.SetJsonSource(Form1.fullJson.Text)
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New ForgotPasswordWindow
        infoPull = JsonConvert.DeserializeObject(Of ForgotPasswordWindow)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     ForgotPasswordWindow.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim ForgotPasswordWindowHeaderBounds As String() = infoPull.Children.Header.TextPadding.Split(",")
        Dim ForgotPasswordWindowInputPanelBounds As String() = infoPull.Children.InputPanel.Bounds.Split(",")
        Dim ForgotPasswordWindowInputLabelBounds As String() = infoPull.Children.InputPanel.Children.InputLabel.Bounds.Split(",")
        Dim ForgotPasswordWindowInputFieldBounds As String() = infoPull.Children.InputPanel.Children.InputField.Bounds.Split(",")
        Dim ForgotPasswordWindowHintLabelBounds As String() = infoPull.Children.HintLabel.Bounds.Split(",")
        Dim ForgotPasswordWindowSubmitButtonBounds As String() = infoPull.Children.SubmitButton.Bounds.Split(",")
        Dim ForgotPasswordWindowBackButtonBounds As String() = infoPull.Children.BackButton.Bounds.Split(",")

        Form1.MainForgotPasswordWindowPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainForgotPasswordWindowPanel.Width = mainwindowbounds(2)
        Form1.MainForgotPasswordWindowPanel.Height = mainwindowbounds(3)
        Form1.MainForgotPasswordWindowPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.ForgotPasswordHeader.Location = New Point(ForgotPasswordWindowHeaderBounds(0), ForgotPasswordWindowHeaderBounds(1))
        Form1.ForgotPasswordInputPanel.Location = New Point(ForgotPasswordWindowInputPanelBounds(0), ForgotPasswordWindowInputPanelBounds(1))
        Form1.ForgotPasswordInputPanel.Width = ForgotPasswordWindowInputPanelBounds(2)
        Form1.ForgotPasswordInputPanel.Height = ForgotPasswordWindowInputPanelBounds(3)
        Form1.ForgotPasswordInputPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.InputPanel.Texture)
        Form1.ForgotPasswordInputLabel.Location = New Point(ForgotPasswordWindowInputLabelBounds(0), ForgotPasswordWindowInputLabelBounds(1))
        Form1.ForgotPasswordInputField.Location = New Point(ForgotPasswordWindowInputFieldBounds(0), ForgotPasswordWindowInputFieldBounds(1))
        Form1.ForgotPasswordInputField.Width = ForgotPasswordWindowInputFieldBounds(2)
        Form1.ForgotPasswordInputField.Height = ForgotPasswordWindowInputFieldBounds(3)
        Form1.ForgotPasswordHintLabel.Location = New Point(ForgotPasswordWindowHintLabelBounds(0), ForgotPasswordWindowHintLabelBounds(1))
        Form1.ForgotPasswordSubmitButton.Location = New Point(ForgotPasswordWindowSubmitButtonBounds(0), ForgotPasswordWindowSubmitButtonBounds(1))
        Form1.ForgotPasswordSubmitButton.Width = ForgotPasswordWindowSubmitButtonBounds(2)
        Form1.ForgotPasswordSubmitButton.Height = ForgotPasswordWindowSubmitButtonBounds(3)
        Form1.ForgotPasswordSubmitButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.SubmitButton.NormalImage)
        Form1.ForgotPasswordBackButton.Location = New Point(ForgotPasswordWindowBackButtonBounds(0), ForgotPasswordWindowBackButtonBounds(1))
        Form1.ForgotPasswordBackButton.Width = ForgotPasswordWindowBackButtonBounds(2)
        Form1.ForgotPasswordBackButton.Height = ForgotPasswordWindowBackButtonBounds(3)
        Form1.ForgotPasswordBackButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.BackButton.NormalImage)
    End Sub
End Module
