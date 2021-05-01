Imports System.IO
Imports Newtonsoft.Json

Module EquipmentItemGUI
    Public Class EquipmentItem
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
        Public Property Texture As String
        Public Property Children As Children
    End Class

    Public Class Children
        Public Property EquipmentIcon As IntersectIcon
    End Class

    Public Sub LoadEquipmentItemGUI(ByVal jsonfile As String)
        Form1.StatusText("[MAIN]     Opening " & jsonfile)
        Form1.jsonValue.Text = ""
        Form1.jsonType.Text = ""
        Form1.jsonTypeCombo.Text = ""
        Form1.MainEquipmentItemPanel.Visible = True
        Form1.RefreshBtn.Visible = True
        Form1.gridToggle.Visible = True
        Form1.toolSplitContainer.Panel2.BackColor = Color.Gray
        Form1.toolSplitContainer.Panel2.BackgroundImage = Nothing

        Dim sr As StreamReader = New StreamReader(jsonfile)
        Form1.fullJson.Text = sr.ReadToEnd()
        Form1.JTokenTreeUserControl1.SetJsonSource(Form1.fullJson.Text)
        sr.Close()
        Dim imgResources As String = Application.StartupPath & "\gui\"
        Dim infoPull As New EquipmentItem
        infoPull = JsonConvert.DeserializeObject(Of EquipmentItem)(Form1.fullJson.Text)
        Form1.StatusText("[MAIN]     EquipmentItem.json Deserialized")

        Dim mainwindowbounds As String() = infoPull.Bounds.Split(",")
        Dim EquipmentIconBounds As String() = infoPull.Children.EquipmentIcon.Bounds.Split(",")

        Form1.MainEquipmentItemPanel.Location = New Point(mainwindowbounds(0), mainwindowbounds(1))
        Form1.MainEquipmentItemPanel.Width = mainwindowbounds(2)
        Form1.MainEquipmentItemPanel.Height = mainwindowbounds(3)
        Form1.MainEquipmentItemPanel.BackgroundImage = Image.FromFile(imgResources & infoPull.Texture)
        Form1.EquipmentIcon.Location = New Point(EquipmentIconBounds(0), EquipmentIconBounds(1))
        Form1.EquipmentIcon.Width = EquipmentIconBounds(2)
        Form1.EquipmentIcon.Height = EquipmentIconBounds(3)
        Form1.EquipmentIcon.BackgroundImage = Image.FromFile(Application.StartupPath & "\resources\weapon.png")

        Form1.StatusText("[MAIN]     Visual Window Updated")
    End Sub
End Module
