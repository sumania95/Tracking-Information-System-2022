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
            cm = New MySql.Data.MySqlClient.MySqlCommand("SELECT Count(customer.id) AS counter_table FROM customer WHERE name like @name AND branch_id=@branch_id;", cn)
            cm.Parameters.AddWithValue("@name", "%" + MetroTextBox1.Text + "%")
            cm.Parameters.AddWithValue("@branch_id", user_branch_id)
            dr = cm.ExecuteReader
            While dr.Read
                pagination_counter = dr.Item("counter_table").ToString
            End While
            dr.Close()
            cn.Close()

            Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM customer WHERE name like @name AND branch_id=@branch_id ORDER BY name;", cn)
            cm.Parameters.AddWithValue("@name", "%" + MetroTextBox1.Text + "%")
            cm.Parameters.AddWithValue("@branch_id", user_branch_id)

            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                Dim ddate As Date
                ddate = dr.Item("date_created").ToString
                DataGridView1.Rows.Add(i, dr.Item("id").ToString, dr.Item("name").ToString.ToUpper, dr.Item("address").ToString.ToUpper, dr.Item("contact").ToString, "UPDATE", "VIEW INFO")
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
            .Text = "NEW CUSTOMER"
            .Button2.Text = "SAVE"
            .TextBox1.Clear()
            .TextBox2.Clear()
            .TextBox3.Clear()
            .TextBox1.Focus()
            .ShowDialog()
        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "Column1" Then
            With CustomerFormCreate
                .Text = "UPDATE CUSTOMER"
                uid = DataGridView1.CurrentRow.Cells(1).Value.ToString
                .Customer_AutoFill(uid)
                .ShowDialog()
            End With
        ElseIf colName = "Column3" Then
            With CustomerFormDetailView
                uid = DataGridView1.CurrentRow.Cells(1).Value.ToString
                uid_customer = DataGridView1.CurrentRow.Cells(1).Value.ToString

                .Size = New Point(Convert.ToInt32(ClientSize.Width - 0), Convert.ToInt32(ClientSize.Height - 0))
                .StartPosition = FormStartPosition.CenterScreen
                .Text = "CUSTOMER SUMMARY INFORMATION"
                .Customer_AutoFill(uid_customer)
                .TabControl1.SelectedIndex = 0

                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub MetroTextBox1_Click(sender As Object, e As EventArgs) Handles MetroTextBox1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class