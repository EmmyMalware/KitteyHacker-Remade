Imports System.Media
Imports Microsoft.Win32

Public Class AdminPanel
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim CatsSound As SoundPlayer = New SoundPlayer(KitteyHacker.My.Resources.TombstoneCatsShortVersion)
        CatsSound.Stop()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim CatsSound As SoundPlayer = New SoundPlayer(KitteyHacker.My.Resources.TombstoneCatsShortVersion)
        CatsSound.PlayLooping()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim KittyCat As SoundPlayer = New SoundPlayer(KitteyHacker.My.Resources.eAANcDPlFie1nb4etVzg_G_major__bpm_133)
        KittyCat.PlayLooping()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim Protogent As SoundPlayer = New SoundPlayer(KitteyHacker.My.Resources.y2mate_com___Protegent_complete_security_full_rap)
        Protogent.PlayLooping()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Process.Start("explorer.exe")
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim key As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\System")
        key.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord)
        Process.Start("taskmgr.exe")
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Process.Start("regedit.exe")
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Process.Start("cmd.exe")
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Dim key As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\System")
        key.DeleteValue("DisableTaskMgr")
        Process.Start("explorer.exe")
        Application.Exit()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        'resets all text to og 
        TextBox1.ResetText()
        TextBox2.ResetText()
        TextBox3.ResetText()
        TextBox4.ResetText()
        TextBox5.ResetText()
        TextBox6.ResetText()
        TextBox7.ResetText()
        TextBox8.ResetText()
        TextBox9.ResetText()
        TextBox10.ResetText()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Dim PanelTextBoxChangeForm As MainForm = New MainForm()
        PanelTextBoxChangeForm.Label1.Text = TextBox1.Text
        PanelTextBoxChangeForm.Label2.Text = TextBox2.Text
        PanelTextBoxChangeForm.Button2.Text = TextBox3.Text
        PanelTextBoxChangeForm.Button3.Text = TextBox4.Text
        PanelTextBoxChangeForm.Button4.Text = TextBox5.Text
        PanelTextBoxChangeForm.Button5.Text = TextBox6.Text
        PanelTextBoxChangeForm.Button6.Text = TextBox8.Text
        PanelTextBoxChangeForm.Button7.Text = TextBox7.Text
        PanelTextBoxChangeForm.Button8.Text = TextBox9.Text
        PanelTextBoxChangeForm.Button9.Text = TextBox10.Text
    End Sub
End Class