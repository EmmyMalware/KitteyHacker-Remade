Public Class ServerForm
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
            Dim hfrom As HackForm = New HackForm()
            hfrom.Show()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        MessageBox.Show("Tough Shit I Ain't Helping You", "Kittey Server Gaurds", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ServerForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
    End Sub
End Class