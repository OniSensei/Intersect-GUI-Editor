Imports System.IO
Imports Newtonsoft.Json

Module ResetPasswordWindowGUI
    Public Class ResetPasswordWindow
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
        Public Property CodePanel As CodePanel
        Public Property Password1Panel As ResetPassword1Panel
        Public Property Password2Panel As ResetPassword2Panel
        Public Property SubmitButton As IntersectButton
        Public Property BackButton As IntersectButton
    End Class

    Public Class CodePanel
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
        Public Property Children As CodePanelChildren
    End Class

    Public Class CodePanelChildren
        Public Property CodeLabel As IntersectLabel
        Public Property CodeField As IntersectField
    End Class

    Public Class ResetPassword1Panel
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
        Public Property Children As ResetPassword1PanelChildren
    End Class

    Public Class ResetPassword1PanelChildren
        Public Property Password1Label As IntersectLabel
        Public Property Password1Field As IntersectField
    End Class

    Public Class ResetPassword2Panel
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
        Public Property Children As ResetPassword2PanelChildren
    End Class

    Public Class ResetPassword2PanelChildren
        Public Property Password2Label As IntersectLabel
        Public Property Password2Field As IntersectField
    End Class

    Public Sub LoadResetPasswordWindowGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainResetPasswordWindowPanel.Visible = True
        Form1.RefreshBtn.Visible = True
        Form1.gridToggle.Visible = True
        Form1.SaveToolStripMenuItem.Visible = True
        Form1.toolSplitContainer.Panel2.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\background.png")

        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        Form1.JTokenTreeUserControl1.SetJsonSource(Form1.fullJson.Text)
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New ResetPasswordWindow
        infoPull = JsonConvert.DeserializeObject(Of ResetPasswordWindow)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     ResetPasswordWindow.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim HeaderBounds As String() = infoPull.Children.Header.TextPadding.Split(",")
        Dim CodePanelBounds As String() = infoPull.Children.CodePanel.Bounds.Split(",")
        Dim CodeLabelBounds As String() = infoPull.Children.CodePanel.Children.CodeLabel.Bounds.Split(",")
        Dim CodeFieldBounds As String() = infoPull.Children.CodePanel.Children.CodeField.Bounds.Split(",")
        Dim Password1PanelBounds As String() = infoPull.Children.Password1Panel.Bounds.Split(",")
        Dim Password1LabelBounds As String() = infoPull.Children.Password1Panel.Children.Password1Field.Bounds.Split(",")
        Dim Password1FieldBounds As String() = infoPull.Children.Password1Panel.Children.Password1Field.Bounds.Split(",")
        Dim Password2PanelBounds As String() = infoPull.Children.Password2Panel.Bounds.Split(",")
        Dim Password2LabelBounds As String() = infoPull.Children.Password2Panel.Children.Password2Label.Bounds.Split(",")
        Dim Password2FieldBounds As String() = infoPull.Children.Password2Panel.Children.Password2Field.Bounds.Split(",")
        Dim SubmitButtonBounds As String() = infoPull.Children.SubmitButton.Bounds.Split(",")
        Dim BackButtonBounds As String() = infoPull.Children.BackButton.Bounds.Split(",")

        Form1.MainResetPasswordWindowPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainResetPasswordWindowPanel.Width = mainwindowbounds(2)
        Form1.MainResetPasswordWindowPanel.Height = mainwindowbounds(3)
        Form1.MainResetPasswordWindowPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.ResetPassHeader.Location = New Point(HeaderBounds(0), HeaderBounds(1))
        Form1.CodePanel.Location = New Point(CodePanelBounds(0), CodePanelBounds(1))
        Form1.CodePanel.Width = CodePanelBounds(2)
        Form1.CodePanel.Height = CodePanelBounds(3)
        Form1.CodePanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.CodePanel.Texture)
        Form1.CodeLabel.Location = New Point(CodeLabelBounds(0), CodeLabelBounds(1))
        Form1.CodeField.Location = New Point(CodeFieldBounds(0), CodeFieldBounds(1))
        Form1.CodeField.Width = CodeFieldBounds(2)
        Form1.CodeField.Height = CodeFieldBounds(3)
        Form1.Password1Panel.Location = New Point(Password1PanelBounds(0), Password1PanelBounds(1))
        Form1.Password1Panel.Width = Password1PanelBounds(2)
        Form1.Password1Panel.Height = Password1PanelBounds(3)
        Form1.Password1Panel.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.Password1Panel.Texture)
        Form1.ResetPassword1Label.Location = New Point(Password1LabelBounds(0), Password1LabelBounds(1))
        Form1.ResetPassword1Field.Location = New Point(Password1FieldBounds(0), Password1FieldBounds(1))
        Form1.ResetPassword1Field.Width = Password1FieldBounds(2)
        Form1.ResetPassword1Field.Height = Password1FieldBounds(3)
        Form1.ResetPassword2Panel.Location = New Point(Password2PanelBounds(0), Password2PanelBounds(1))
        Form1.ResetPassword2Panel.Width = Password2PanelBounds(2)
        Form1.ResetPassword2Panel.Height = Password2PanelBounds(3)
        Form1.ResetPassword2Panel.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.Password2Panel.Texture)
        Form1.ResetPassword2Label.Location = New Point(Password2LabelBounds(0), Password2LabelBounds(1))
        Form1.ResetPassword2Field.Location = New Point(Password2FieldBounds(0), Password2FieldBounds(1))
        Form1.ResetPassword2Field.Width = Password2FieldBounds(2)
        Form1.ResetPassword2Field.Height = Password2FieldBounds(3)
        Form1.ResetSubmitButton.Location = New Point(SubmitButtonBounds(0), SubmitButtonBounds(1))
        Form1.ResetSubmitButton.Width = SubmitButtonBounds(2)
        Form1.ResetSubmitButton.Height = SubmitButtonBounds(3)
        Form1.ResetSubmitButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.SubmitButton.NormalImage)
        Form1.BackButton.Location = New Point(BackButtonBounds(0), BackButtonBounds(1))
        Form1.BackButton.Width = BackButtonBounds(2)
        Form1.BackButton.Height = BackButtonBounds(3)
        Form1.BackButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.BackButton.NormalImage)
    End Sub
End Module
