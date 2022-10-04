Public Class CustomerFormCreate
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Save" Then
            If (MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion, "Sample") = vbYes) Then
                cn.Open()
                cm = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO customer (name,address,contact,user_id,date_created) VALUES (@name,@address,@contact,@user_id,@date_created);", cn)
                cm.Parameters.AddWithValue("@name", TextBox1.Text)
                cm.Parameters.AddWithValue("@address", TextBox2.Text)
                cm.Parameters.AddWithValue("@contact", TextBox3.Text)
                cm.Parameters.AddWithValue("@user_id", 1)
                cm.Parameters.AddWithValue("@date_created", DateAndTime.Now.ToString("yyyy-MM-dd hh:mm:ss"))
                cm.ExecuteNonQuery()
                cn.Close()
                Button2.Text = "Please Wait ..."
                Button2.Enabled = False
                With CustomerFormView
                    .loadrecord()
                End With
                Button2.Enabled = True
                Button2.Text = "Save"
                MsgBox("Record has been successfully saved.", vbInformation, "Sample")

                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox1.Select()


            End If
        Else
            'If (MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion, "Sample") = vbYes) Then
            '    cn.Open()
            '    cm = New MySql.Data.MySqlClient.MySqlCommand("UPDATE category SET category = @category WHERE id = @id;", cn)
            '    cm.Parameters.AddWithValue("@category", TextBox1.Text)
            '    cm.Parameters.AddWithValue("@id", uid)
            '    cm.ExecuteNonQuery()
            '    cn.Close()
            '    MsgBox("Record has been successfully updated.", vbInformation, "Sample")
            '    Me.Hide()

            'End If
        End If
    End Sub
End Class