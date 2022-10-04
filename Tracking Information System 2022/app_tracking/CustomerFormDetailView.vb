Public Class CustomerFormDetailView
    Public Sub Customer_AutoFill(uid As Integer)
        Try
            cn.Open()
            cm = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM customer WHERE id = @id;", cn)
            cm.Parameters.AddWithValue("@id", uid)
            dr = cm.ExecuteReader
            While dr.Read
                Label1.Text = dr.Item("name").ToString.ToUpper
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical, title_app)

        End Try
    End Sub

    Public Sub tabcontroller()
        If TabControl1.SelectedIndex = 0 Then
            Customer_Detail_Tab1_View()
        ElseIf TabControl1.SelectedIndex = 1 Then
            Customer_Detail_Tab2_View()
        End If
    End Sub

    Private Sub CustomerFormDetailView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Customer_Detail_Tab1_View()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        tabcontroller()
    End Sub
End Class