﻿
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
            thread = New System.Threading.Thread(AddressOf .loadrecord)
            thread.Start()
            .Show()
        End With
    End Sub

End Module
