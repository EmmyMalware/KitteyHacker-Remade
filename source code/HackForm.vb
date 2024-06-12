Imports Microsoft.Win32
Public Class HackForm
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim key As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\System")
        key.DeleteValue("DisableTaskMgr")
        Process.Start("explorer.exe")
        Application.Exit()
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.Text = "You Rock!"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mainfrom As MainForm = New MainForm()
        Dim adpanel As AdminPanel = New AdminPanel()
        Me.Hide()
        mainfrom.Hide()
        adpanel.Show()
    End Sub
End Class