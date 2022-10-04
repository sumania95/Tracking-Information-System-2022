Public Class Main
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (MsgBox("Are you sure do you want to logout?", vbYesNo + vbQuestion, title_app) = vbYes) Then
            Me.Hide()
            LoginFormView.txPass.Text = String.Empty
            Login_View()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dashboard_View()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Customer_View()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Brand_View()
    End Sub
End Class