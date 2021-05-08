Imports System.IO
Imports Newtonsoft.Json

Module RegistrationWindowGUI
    Public Class RegistrationWindow
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
        Public Property RegistrationLabel As IntersectLabel
        Public Property UsernamePanel As RegistrationUsernamePanel
        Public Property EmailPanel As EmailPanel
        Public Property Password1Panel As Password1Panel
        Public Property Password2Panel As Password2Panel
        Public Property RegisterButton As IntersectButton
        Public Property BackButton As IntersectButton
    End Class

    Public Class RegistrationUsernamePanel
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
        Public Property Children As RegistrationUsernamePanelChildren
    End Class

    Public Class RegistrationUsernamePanelChildren
        Public Property UsernameLabel As IntersectLabel
        Public Property UsernameField As IntersectField
    End Class

    Public Class EmailPanel
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
        Public Property Children As EmailPanelChildren
    End Class

    Public Class EmailPanelChildren
        Public Property EmailLabel As IntersectLabel
        Public Property EmailField As IntersectField
    End Class

    Public Class Password1Panel
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
        Public Property Children As Password1PanelChildren
    End Class

    Public Class Password1PanelChildren
        Public Property Password1Label As IntersectLabel
        Public Property Password1Field As IntersectField
    End Class

    Public Class Password2Panel
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
        Public Property Children As Password2PanelChildren
    End Class

    Public Class Password2PanelChildren
        Public Property Password2Label As IntersectLabel
        Public Property Password2Field As IntersectField
    End Class

    Public Sub LoadRegistrationWindowGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainRegistrationWindowPanel.Visible = True
        Form1.RefreshBtn.Visible = True
        Form1.gridToggle.Visible = True
        Form1.SaveToolStripMenuItem.Visible = True
        Form1.toolSplitContainer.Panel2.BackgroundImage = Image.FromFile(Application.StartupPath & "\gui\background.png")

        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        Form1.JTokenTreeUserControl1.SetJsonSource(Form1.fullJson.Text)
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New RegistrationWindow
        infoPull = JsonConvert.DeserializeObject(Of RegistrationWindow)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     RegistrationWindow.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim RegistrationLabelBounds As String() = infoPull.Children.RegistrationLabel.TextPadding.Split(",")
        Dim UsernamePanelBounds As String() = infoPull.Children.UsernamePanel.Bounds.Split(",")
        Dim UsernameLabelBounds As String() = infoPull.Children.UsernamePanel.Children.UsernameLabel.Bounds.Split(",")
        Dim UsernameFieldBounds As String() = infoPull.Children.UsernamePanel.Children.UsernameField.Bounds.Split(",")
        Dim EmailPanelBounds As String() = infoPull.Children.EmailPanel.Bounds.Split(",")
        Dim EmailLabelBounds As String() = infoPull.Children.EmailPanel.Children.EmailLabel.Bounds.Split(",")
        Dim EmailFieldBounds As String() = infoPull.Children.EmailPanel.Children.EmailField.Bounds.Split(",")
        Dim Password1PanelBounds As String() = infoPull.Children.Password1Panel.Bounds.Split(",")
        Dim Password1LabelBounds As String() = infoPull.Children.Password1Panel.Children.Password1Label.Bounds.Split(",")
        Dim Password1FieldBounds As String() = infoPull.Children.Password1Panel.Children.Password1Field.Bounds.Split(",")
        Dim Password2PanelBounds As String() = infoPull.Children.Password2Panel.Bounds.Split(",")
        Dim Password2LabelBounds As String() = infoPull.Children.Password2Panel.Children.Password2Label.Bounds.Split(",")
        Dim Password2FieldBounds As String() = infoPull.Children.Password2Panel.Children.Password2Field.Bounds.Split(",")
        Dim RegisterButtonBounds As String() = infoPull.Children.RegisterButton.Bounds.Split(",")
        Dim BackButtonBounds As String() = infoPull.Children.BackButton.Bounds.Split(",")

        Form1.MainRegistrationWindowPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainRegistrationWindowPanel.Width = mainwindowbounds(2)
        Form1.MainRegistrationWindowPanel.Height = mainwindowbounds(3)
        Form1.MainRegistrationWindowPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.RegistrationLabel.Location = New Point(RegistrationLabelBounds(0), RegistrationLabelBounds(1))
        Form1.RegistrationUsernamePanel.Location = New Point(UsernamePanelBounds(0), UsernamePanelBounds(1))
        Form1.RegistrationUsernamePanel.Width = UsernamePanelBounds(2)
        Form1.RegistrationUsernamePanel.Height = UsernamePanelBounds(3)
        Form1.RegistrationUsernamePanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.UsernamePanel.Texture)
        Form1.RegistrationUsernameLabel.Location = New Point(UsernameLabelBounds(0), UsernameLabelBounds(1))
        Form1.RegistrationUsernameField.Location = New Point(UsernameFieldBounds(0), UsernameFieldBounds(1))
        Form1.RegistrationUsernameField.Width = UsernameFieldBounds(2)
        Form1.RegistrationUsernameField.Height = UsernameFieldBounds(3)
        Form1.EmailPanel.Location = New Point(EmailPanelBounds(0), EmailPanelBounds(1))
        Form1.EmailPanel.Width = EmailPanelBounds(2)
        Form1.EmailPanel.Height = EmailPanelBounds(3)
        Form1.EmailPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.EmailPanel.Texture)
        Form1.EmailLabel.Location = New Point(EmailLabelBounds(0), EmailLabelBounds(1))
        Form1.EmailField.Location = New Point(EmailFieldBounds(0), EmailFieldBounds(1))
        Form1.EmailField.Width = EmailFieldBounds(2)
        Form1.EmailField.Height = EmailFieldBounds(3)
        Form1.Password1Panel.Location = New Point(Password1PanelBounds(0), Password1PanelBounds(1))
        Form1.Password1Panel.Width = Password1PanelBounds(2)
        Form1.Password1Panel.Height = Password1PanelBounds(3)
        Form1.Password1Panel.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.Password1Panel.Texture)
        Form1.Password1Label.Location = New Point(Password1LabelBounds(0), Password1LabelBounds(1))
        Form1.Password1Field.Location = New Point(Password1FieldBounds(0), Password1FieldBounds(1))
        Form1.Password1Field.Width = Password1FieldBounds(2)
        Form1.Password1Field.Height = Password1FieldBounds(3)
        Form1.Password2Panel.Location = New Point(Password2PanelBounds(0), Password2PanelBounds(1))
        Form1.Password2Panel.Width = Password2PanelBounds(2)
        Form1.Password2Panel.Height = Password2PanelBounds(3)
        Form1.Password2Panel.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.Password2Panel.Texture)
        Form1.Password2Label.Location = New Point(Password2LabelBounds(0), Password2LabelBounds(1))
        Form1.Password2Field.Location = New Point(Password2FieldBounds(0), Password2FieldBounds(1))
        Form1.Password2Field.Width = Password2FieldBounds(2)
        Form1.Password2Field.Height = Password2FieldBounds(3)
        Form1.RegistrationRegisterButton.Location = New Point(RegisterButtonBounds(0), RegisterButtonBounds(1))
        Form1.RegistrationRegisterButton.Width = RegisterButtonBounds(2)
        Form1.RegistrationRegisterButton.Height = RegisterButtonBounds(3)
        Form1.RegistrationRegisterButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.RegisterButton.NormalImage)
        Form1.BackButton.Location = New Point(BackButtonBounds(0), BackButtonBounds(1))
        Form1.BackButton.Width = BackButtonBounds(2)
        Form1.BackButton.Height = BackButtonBounds(3)
        Form1.BackButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.BackButton.NormalImage)
    End Sub

    Public Sub UpdateRegistrationWindowGUI(ByVal jsonfile As String)
        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New RegistrationWindow
        infoPull = JsonConvert.DeserializeObject(Of RegistrationWindow)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     RegistrationWindow.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim RegistrationLabelBounds As String() = infoPull.Children.RegistrationLabel.TextPadding.Split(",")
        Dim UsernamePanelBounds As String() = infoPull.Children.UsernamePanel.Bounds.Split(",")
        Dim UsernameLabelBounds As String() = infoPull.Children.UsernamePanel.Children.UsernameLabel.Bounds.Split(",")
        Dim UsernameFieldBounds As String() = infoPull.Children.UsernamePanel.Children.UsernameField.Bounds.Split(",")
        Dim EmailPanelBounds As String() = infoPull.Children.EmailPanel.Bounds.Split(",")
        Dim EmailLabelBounds As String() = infoPull.Children.EmailPanel.Children.EmailLabel.Bounds.Split(",")
        Dim EmailFieldBounds As String() = infoPull.Children.EmailPanel.Children.EmailField.Bounds.Split(",")
        Dim Password1PanelBounds As String() = infoPull.Children.Password1Panel.Bounds.Split(",")
        Dim Password1LabelBounds As String() = infoPull.Children.Password1Panel.Children.Password1Label.Bounds.Split(",")
        Dim Password1FieldBounds As String() = infoPull.Children.Password1Panel.Children.Password1Field.Bounds.Split(",")
        Dim Password2PanelBounds As String() = infoPull.Children.Password2Panel.Bounds.Split(",")
        Dim Password2LabelBounds As String() = infoPull.Children.Password2Panel.Children.Password2Label.Bounds.Split(",")
        Dim Password2FieldBounds As String() = infoPull.Children.Password2Panel.Children.Password2Field.Bounds.Split(",")
        Dim RegisterButtonBounds As String() = infoPull.Children.RegisterButton.Bounds.Split(",")
        Dim BackButtonBounds As String() = infoPull.Children.BackButton.Bounds.Split(",")

        Form1.MainRegistrationWindowPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainRegistrationWindowPanel.Width = mainwindowbounds(2)
        Form1.MainRegistrationWindowPanel.Height = mainwindowbounds(3)
        Form1.MainRegistrationWindowPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.RegistrationLabel.Location = New Point(RegistrationLabelBounds(0), RegistrationLabelBounds(1))
        Form1.RegistrationUsernamePanel.Location = New Point(UsernamePanelBounds(0), UsernamePanelBounds(1))
        Form1.RegistrationUsernamePanel.Width = UsernamePanelBounds(2)
        Form1.RegistrationUsernamePanel.Height = UsernamePanelBounds(3)
        Form1.RegistrationUsernamePanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.UsernamePanel.Texture)
        Form1.RegistrationUsernameLabel.Location = New Point(UsernameLabelBounds(0), UsernameLabelBounds(1))
        Form1.RegistrationUsernameField.Location = New Point(UsernameFieldBounds(0), UsernameFieldBounds(1))
        Form1.RegistrationUsernameField.Width = UsernameFieldBounds(2)
        Form1.RegistrationUsernameField.Height = UsernameFieldBounds(3)
        Form1.EmailPanel.Location = New Point(EmailPanelBounds(0), EmailPanelBounds(1))
        Form1.EmailPanel.Width = EmailPanelBounds(2)
        Form1.EmailPanel.Height = EmailPanelBounds(3)
        Form1.EmailPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.EmailPanel.Texture)
        Form1.EmailLabel.Location = New Point(EmailLabelBounds(0), EmailLabelBounds(1))
        Form1.EmailField.Location = New Point(EmailFieldBounds(0), EmailFieldBounds(1))
        Form1.EmailField.Width = EmailFieldBounds(2)
        Form1.EmailField.Height = EmailFieldBounds(3)
        Form1.Password1Panel.Location = New Point(Password1PanelBounds(0), Password1PanelBounds(1))
        Form1.Password1Panel.Width = Password1PanelBounds(2)
        Form1.Password1Panel.Height = Password1PanelBounds(3)
        Form1.Password1Panel.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.Password1Panel.Texture)
        Form1.Password1Label.Location = New Point(Password1LabelBounds(0), Password1LabelBounds(1))
        Form1.Password1Field.Location = New Point(Password1FieldBounds(0), Password1FieldBounds(1))
        Form1.Password1Field.Width = Password1FieldBounds(2)
        Form1.Password1Field.Height = Password1FieldBounds(3)
        Form1.Password2Panel.Location = New Point(Password2PanelBounds(0), Password2PanelBounds(1))
        Form1.Password2Panel.Width = Password2PanelBounds(2)
        Form1.Password2Panel.Height = Password2PanelBounds(3)
        Form1.Password2Panel.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.Password2Panel.Texture)
        Form1.Password2Label.Location = New Point(Password2LabelBounds(0), Password2LabelBounds(1))
        Form1.Password2Field.Location = New Point(Password2FieldBounds(0), Password2FieldBounds(1))
        Form1.Password2Field.Width = Password2FieldBounds(2)
        Form1.Password2Field.Height = Password2FieldBounds(3)
        Form1.RegistrationRegisterButton.Location = New Point(RegisterButtonBounds(0), RegisterButtonBounds(1))
        Form1.RegistrationRegisterButton.Width = RegisterButtonBounds(2)
        Form1.RegistrationRegisterButton.Height = RegisterButtonBounds(3)
        Form1.RegistrationRegisterButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.RegisterButton.NormalImage)
        Form1.BackButton.Location = New Point(BackButtonBounds(0), BackButtonBounds(1))
        Form1.BackButton.Width = BackButtonBounds(2)
        Form1.BackButton.Height = BackButtonBounds(3)
        Form1.BackButton.BackgroundImage = Image.FromFile(imgResources & infoPull.Children.BackButton.NormalImage)
    End Sub
End Module
