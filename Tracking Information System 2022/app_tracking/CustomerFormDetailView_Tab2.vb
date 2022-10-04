Public Class CustomerFormDetailView_Tab2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With CustomerFormDetailView_Tab2_Create
            .Brand()
            .Text = "NEW UNIT OWNED"
            .cleartx()
            .ShowDialog()
        End With
    End Sub

    Private Sub MetroTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles MetroTextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                loadrecord()
        End Select
    End Sub
    Public Sub loadrecord()
        Try
            cn.Open()
            cm = New MySql.Data.MySqlClient.MySqlCommand("SELECT Count(unit_owned.id) AS counter_table FROM unit_owned WHERE serial_no like @serial_no AND customer_id = @customer_id;", cn)
            cm.Parameters.AddWithValue("@serial_no", "%" + MetroTextBox1.Text + "%")
            cm.Parameters.AddWithValue("@customer_id", uid_customer)
            dr = cm.ExecuteReader
            While dr.Read
                pagination_counter = dr.Item("counter_table").ToString
            End While
            dr.Close()
            cn.Close()

            Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM unit_owned LEFT JOIN brand ON unit_owned.brand_id = brand.id LEFT JOIN login ON unit_owned.user_id = login.id WHERE serial_no like @serial_no AND customer_id = @customer_id ORDER BY date_delivered;", cn)
            cm.Parameters.AddWithValue("@serial_no", "%" + MetroTextBox1.Text + "%")
            cm.Parameters.AddWithValue("@customer_id", uid_customer)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                Dim ddate As Date
                ddate = dr.Item("date_created").ToString
                DataGridView1.Rows.Add(i, dr.Item("id").ToString, dr.Item("brand").ToString.ToUpper, dr.Item("model").ToString.ToUpper, dr.Item("serial_no").ToString.ToUpper, ddate.ToString("MMMM dd, yyyy"), dr.Item("location").ToString.ToUpper, dr.Item("username").ToString.ToUpper, "UPDATE", "PRINT")
            End While
            dr.Close()
            cn.Close()
            Label1.Text = "" & pagination_counter & " record(s) found."

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbExclamation, title_app)
        End Try

    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "Column1" Then
            With BrandFormCreate
                .Text = "UPDATE UNIT OWNED"
                uid = DataGridView1.CurrentRow.Cells(1).Value.ToString
                .Brand_AutoFill(uid)
                .ShowDialog()
            End With
        End If
    End Sub
End Class