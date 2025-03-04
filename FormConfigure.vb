Imports System.Configuration

Public Class FormConfigure
    Private Sub LoadConfig()
        LabelName.Text = ConfigurationManager.AppSettings("Name")
    End Sub

    Private Sub SaveConfig()
        Dim config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

        config.AppSettings.Settings("Name").Value = TextBoxName.Text

        config.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection("appSettings")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadConfig()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        SaveConfig()
        LoadConfig()
    End Sub
End Class
