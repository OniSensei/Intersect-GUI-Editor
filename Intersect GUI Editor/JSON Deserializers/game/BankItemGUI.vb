Imports System.IO
Imports Newtonsoft.Json

Module BankItemGUI
    Public Class BankItem
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
        Public Property BankItemIcon As IntersectIcon
        Public Property BankItemValue As IntersectLabel
    End Class

    Public Sub LoadBankItemGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainBankItemPanel.Visible = True
        Form1.RefreshBtn.Visible = True
        Form1.gridToggle.Visible = True
        Form1.toolSplitContainer.Panel2.BackColor = Color.Gray
        Form1.toolSplitContainer.Panel2.BackgroundImage = Nothing

        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        Form1.JTokenTreeUserControl1.SetJsonSource(Form1.fullJson.Text)
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New BankItem
        infoPull = JsonConvert.DeserializeObject(Of BankItem)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     BankItem.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim BankItemIconBounds As String() = infoPull.Children.BankItemIcon.Bounds.Split(",")
        Dim BankItemValueBounds As String() = infoPull.Children.BankItemValue.Bounds.Split(",")

        Form1.MainBankItemPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainBankItemPanel.Width = mainwindowbounds(2)
        Form1.MainBankItemPanel.Height = mainwindowbounds(3)
        Form1.MainBankItemPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.BankItemIcon.Location = New Point(BankItemIconBounds(0), BankItemIconBounds(1))
        Form1.BankItemIcon.Width = BankItemIconBounds(2)
        Form1.BankItemIcon.Height = BankItemIconBounds(3)
        Form1.BankItemIcon.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\itemIcon.png")
        Form1.BankItemValue.Location = New Point(BankItemValueBounds(0), BankItemValueBounds(1))

        
    End Sub
End Module
