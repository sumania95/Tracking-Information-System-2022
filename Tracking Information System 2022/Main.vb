Public Class Main
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (MsgBox("Are you sure do you want to logout?", vbYesNo + vbQuestion, title_app) = vbYes) Then
            Me.Hide()
            LoginFormView.txPass.Text = String.Empty
            Login_View()
        End If
    End Sub
End Class