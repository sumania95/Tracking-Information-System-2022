Module Main_Module
    Public Sub Main_View()
        With Main
            .TopLevel = False
            Base.Panel2.Controls.Add(Main)
            .BringToFront()
            .Show()
        End With
    End Sub
End Module
