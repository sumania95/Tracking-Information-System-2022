Module Dashboard_Module
    Public Sub Dashboard_View()
        With DashboardFormView
            .TopLevel = False
            Main.Panel2.Controls.Add(DashboardFormView)
            .BringToFront()
            .Show()
        End With
    End Sub
End Module
