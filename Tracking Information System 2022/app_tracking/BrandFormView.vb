Public Class BrandFormView
    Private Sub MetroTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles MetroTextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                loadrecord()
        End Select
    End Sub
    Public Sub loadrecord()
        Try
            cn.Open()
            cm = New MySql.Data.MySqlClient.MySqlCommand("SELECT Count(brand.id) AS counter_table FROM brand WHERE brand like @brand;", cn)
            cm.Parameters.AddWithValue("@brand", "%" + MetroTextBox1.Text + "%")
            dr = cm.ExecuteReader
            While dr.Read
                pagination_counter = dr.Item("counter_table").ToString
            End While
            dr.Close()
            cn.Close()

            Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM brand WHERE brand like @brand ORDER BY brand;", cn)
            cm.Parameters.AddWithValue("@brand", "%" + MetroTextBox1.Text + "%")
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("id").ToString, dr.Item("brand").ToString.ToUpper, "UPDATE", "VIEW INFO")
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
                .Text = "UPDATE BRAND"
                uid = DataGridView1.CurrentRow.Cells(1).Value.ToString
                .Brand_AutoFill(uid)
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With BrandFormCreate
            .Text = "NEW BRAND"
            .Button2.Text = "SAVE"
            .TextBox1.Clear()
            .TextBox1.Focus()
            .ShowDialog()
        End With
    End Sub
End Class