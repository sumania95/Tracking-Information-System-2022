
Module Navigation_Panel_Module
    Dim thread As System.Threading.Thread
    'SteelBlue
    'SlateGray
    'Teal
    'DarkSlateBlue
    'MediumVioletRed
    'Goldenrod
    'Sienna
    Public background_color = Color.SlateGray
    Public background_color_active = Color.SteelBlue

    Public Sub Button_Color_Reset()
        Main.Button1.ForeColor = Color.White
        Main.Button2.ForeColor = Color.White
        Main.Button3.ForeColor = Color.White
        Main.Button4.ForeColor = Color.White
        Main.Button5.ForeColor = Color.White
        Main.Button6.ForeColor = Color.White
        Main.Button7.ForeColor = Color.White
        Main.Button8.ForeColor = Color.White
        'Main.Button9.ForeColor = Color.White
        'Main.Button10.ForeColor = Color.White
        'Main.Button11.ForeColor = Color.White
        CustomerFormView.Hide()
        DashboardFormView.Hide()
    End Sub

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

    Public Sub Main_View()
        With Main
            .TopLevel = False
            Base.Panel2.Controls.Add(Main)
            .BringToFront()
            .Show()
        End With
    End Sub

    Public Sub Dashboard_View()

        Button_Color_Reset()
        Main.Button1.ForeColor = background_color_active
        With DashboardFormView
            .TopLevel = False
            Main.Panel2.Controls.Add(DashboardFormView)
            .BringToFront()
            .Show()
        End With
    End Sub

    Public Sub Customer_View()
        Button_Color_Reset()
        Main.Button2.ForeColor = background_color_active
        With CustomerFormView
            .DataGridView1.Rows.Clear()
            .TopLevel = False
            Main.Panel2.Controls.Add(CustomerFormView)
            .BringToFront()
            .Show()
            .MetroTextBox1.Text = String.Empty
            .loadrecord()
            .DataGridView1.Refresh()

        End With
    End Sub
    Public Sub Brand_View()
        Button_Color_Reset()
        Main.Button3.ForeColor = background_color_active
        With BrandFormView
            .DataGridView1.Rows.Clear()
            .TopLevel = False
            Main.Panel2.Controls.Add(BrandFormView)
            .BringToFront()
            .Show()
            .MetroTextBox1.Text = String.Empty
            .loadrecord()
            .DataGridView1.Refresh()

        End With
    End Sub


    Public Sub Customer_Detail_Tab1_View()
        With CustomerFormDetailView_Tab1
            .TopLevel = False
            CustomerFormDetailView.TabPage1.Controls.Add(CustomerFormDetailView_Tab1)
            .BringToFront()
            .Show()
        End With
    End Sub

    Public Sub Customer_Detail_Tab2_View()
        With CustomerFormDetailView_Tab2
            .TopLevel = False
            CustomerFormDetailView.TabPage2.Controls.Add(CustomerFormDetailView_Tab2)
            .BringToFront()
            .loadrecord()
            .Show()
        End With
    End Sub

End Module
