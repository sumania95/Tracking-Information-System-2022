Public Class CustomerFormCreate
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "SAVE" Then
            If TextBox1.Text = String.Empty Then
                MsgBox("Warning : Name field required!", vbCritical, title_app)
                Return
            End If
            If (MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion, title_app) = vbYes) Then
                cn.Open()
                cm = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO customer (name,address,contact,user_id,date_created,branch_id) VALUES (@name,@address,@contact,@user_id,@date_created,@branch_id);", cn)
                cm.Parameters.AddWithValue("@name", TextBox1.Text)
                cm.Parameters.AddWithValue("@address", TextBox2.Text)
                cm.Parameters.AddWithValue("@contact", TextBox3.Text)
                cm.Parameters.AddWithValue("@user_id", 1)
                cm.Parameters.AddWithValue("@branch_id", user_branch_id)
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
                MsgBox("Record has been successfully saved.", vbInformation, title_app)

                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox1.Select()


            End If
        Else
            If (MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion, title_app) = vbYes) Then
                cn.Open()
                cm = New MySql.Data.MySqlClient.MySqlCommand("UPDATE customer SET name = @name,address = @address, contact = @contact WHERE id = @id;", cn)
                cm.Parameters.AddWithValue("@name", TextBox1.Text)
                cm.Parameters.AddWithValue("@address", TextBox2.Text)
                cm.Parameters.AddWithValue("@contact", TextBox3.Text)
                cm.Parameters.AddWithValue("@id", uid)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been successfully updated.", vbInformation, title_app)
                With CustomerFormView
                    .loadrecord()
                End With

            End If
        End If
    End Sub

    Public Sub Customer_AutoFill(uid As Integer)
        Try
            Button2.Text = "UPDATE"
            cn.Open()
            cm = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM customer WHERE id = @id;", cn)
            cm.Parameters.AddWithValue("@id", uid)
            dr = cm.ExecuteReader
            While dr.Read
                TextBox1.Text = dr.Item("name").ToString
                TextBox2.Text = dr.Item("address").ToString
                TextBox3.Text = dr.Item("contact").ToString
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical, title_app)

        End Try
    End Sub
End Class