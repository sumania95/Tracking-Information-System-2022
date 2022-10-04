﻿Public Class LoginFormView
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim found As Boolean = False
            Dim username As String = ""
            cn.Open()
            cm = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM login WHERE username = @username AND password = @password;", cn)

            cm.Parameters.AddWithValue("@username", txUser.Text)
            cm.Parameters.AddWithValue("@password", txPass.Text)
            dr = cm.ExecuteReader

            If dr.Read = True Then
                found = True
                username = dr.Item("username").ToString
                'user_id = dr.Item("id").ToString
                'user_password = dr.Item("password").ToString
                'user_type = dr.Item("type").ToString
            End If
            dr.Close()
            cn.Close()
            If found = True Then
                MsgBox("Access Granted. Welcome : " & UppercaseFirstLetter(username.ToString), vbInformation, title_app)
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