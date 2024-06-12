Public Class InfoForm
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Process.Start("www.bitview.net/user/emmyrain")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Label2.Text = "Please Friend Me!"
    End Sub

    Private Sub Label2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.MouseHover
        Label2.Text = "Please Friend Me!"
    End Sub
End Class