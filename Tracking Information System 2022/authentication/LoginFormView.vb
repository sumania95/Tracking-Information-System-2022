Public Class LoginFormView
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim found As Boolean = False
            Dim username As String = ""
            cn.Open()
            cm = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM user WHERE username = @username AND password = @password;", cn)

            cm.Parameters.AddWithValue("@username", txUser.Text)
            cm.Parameters.AddWithValue("@password", txPass.Text)
            dr = cm.ExecuteReader

            If dr.Read = True Then
                found = True
                username = dr.Item("username").ToString
                uid_user = dr.Item("id").ToString
                user_name = dr.Item("name").ToString
                user_branch_id = dr.Item("branch_id").ToString
            End If
            dr.Close()
            cn.Close()
            If found = True Then
                MsgBox("Access Granted. Welcome : " & UppercaseFirstLetter(user_name.ToString), vbInformation, title_app)
                Main_View()
                Dashboard_View()
            Else
                MsgBox("Access Denied. Invalid username or password.", vbCritical, title_app)
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical, title_app)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (MsgBox("Are you sure do you want to exit?", vbYesNo + vbQuestion, title_app) = vbYes) Then
            Base.Dispose()
        End If
    End Sub
End Class