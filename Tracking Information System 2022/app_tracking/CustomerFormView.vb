Public Class CustomerFormView
    Private Sub MetroTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles MetroTextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                loadrecord()
        End Select
    End Sub
    Public Sub loadrecord()
        Try
            cn.Open()
            cm = New MySql.Data.MySqlClient.MySqlCommand("SELECT Count(customer.id) AS counter_table FROM customer WHERE name like @name;", cn)
            cm.Parameters.AddWithValue("@name", "%" + MetroTextBox1.Text + "%")
            dr = cm.ExecuteReader
            While dr.Read
                pagination_counter = dr.Item("counter_table").ToString
            End While
            dr.Close()
            cn.Close()

            Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM customer WHERE name like @name ORDER BY name;", cn)
            cm.Parameters.AddWithValue("@name", "%" + MetroTextBox1.Text + "%")
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                Dim ddate As Date
                ddate = dr.Item("date_created").ToString
                DataGridView1.Rows.Add(i, dr.Item("id").ToString, dr.Item("name").ToString.ToUpper, dr.Item("address").ToString.ToUpper, dr.Item("contact").ToString, "Update", "Remove")
            End While
            dr.Close()
            cn.Close()
            Label1.Text = "" & pagination_counter & " record(s) found."

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbExclamation, title_app)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With CustomerFormCreate
            .TextBox1.Clear()
            .TextBox2.Clear()
            .TextBox3.Clear()
            .TextBox1.Focus()
            .ShowDialog()
        End With
    End Sub
End Class