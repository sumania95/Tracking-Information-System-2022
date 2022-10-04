Module Module_LoginFormView
    Public Sub Login_View()
        With LoginFormView
            .TopLevel = False
            Base.Panel2.Controls.Add(LoginFormView)
            .Panel1.Location = New Point(Convert.ToInt32(.ClientSize.Width / 2 - .Panel1.Width / 2),
                                   Convert.ToInt32(.ClientSize.Height / 2 - .Panel1.Height / 2))
            .BringToFront()
            .Show()
        End With
    End Sub
End Module
