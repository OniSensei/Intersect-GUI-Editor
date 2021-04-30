Public Class SettingsForm
    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.ApplicationFont
        Form1.StatusText("[MAIN]     Settings Window Loaded.")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.ApplicationFont = TextBox1.Text
        My.Settings.Save()

        Dim privateFonts As New Text.PrivateFontCollection()
        privateFonts.AddFontFile(Application.StartupPath & "\font\" & My.Settings.ApplicationFont)
        Dim sysfont As New Font(privateFonts.Families(0), 10)
        For Each objCtrl As Control In Form1.Controls
            If TypeOf objCtrl Is Label Then
                objCtrl.Font = sysfont
            End If
        Next

        Form1.StatusText("[MAIN]     Settings Saved.")
    End Sub
End Class