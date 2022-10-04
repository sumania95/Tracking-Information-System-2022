Public Class CustomerFormDetailView_Tab2_Create

    Public Sub cleartx()
        TextBox1.Clear()
        TextBox2.Clear()
        ComboBox1.SelectedIndex = 0
        DateTimePicker1.Value = Date.Now.ToString

    End Sub
    Public Sub Brand()
        ComboBox1.Items.Clear()
        Try
            cn.Open()
            cm = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM brand ORDER BY brand;", cn)
            dr = cm.ExecuteReader
            While dr.Read
                Dim brand = dr.Item("brand").ToString
                ComboBox1.Items.Add(brand)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical, title_app)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (ComboBox1.SelectedIndex = -1) Then
            MsgBox("Warning: Brand field required or invalid!", vbCritical, title_app)
            Return
        Else
            Try
                cn.Open()
                cm = New MySql.Data.MySqlClient.MySqlCommand("SELECT id FROM brand WHERE brand = @brand;", cn)
                cm.Parameters.AddWithValue("@brand", ComboBox1.Text)
                dr = cm.ExecuteReader
                While dr.Read
                    uid_brand = dr.Item("id").ToString()
                End While
                dr.Close()
                cn.Close()
            Catch ex As Exception
                MsgBox("Warning: Brand field invalid!", vbCritical, title_app)
                Return
            End Try

        End If
        If TextBox1.Text = String.Empty Then
            MsgBox("Warning: Model field required!", vbCritical, title_app)
            Return
        End If
        If TextBox2.Text = String.Empty Then
            MsgBox("Warning: Serial No field required!", vbCritical, title_app)
            Return
        End If

        If Button2.Text = "SAVE" Then
            If (MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion, title_app) = vbYes) Then
                cn.Open()
                cm = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO unit_owned (brand_id,model,serial_no,date_delivered,date_created,customer_id,user_id,location) VALUES (@brand_id,@model,@serial_no,@date_delivered,@date_created,@customer_id,@user_id,@location);", cn)
                cm.Parameters.AddWithValue("@brand_id", uid_brand)
                cm.Parameters.AddWithValue("@model", TextBox1.Text)
                cm.Parameters.AddWithValue("@serial_no", TextBox2.Text)
                cm.Parameters.AddWithValue("@location", TextBox3.Text)
                cm.Parameters.AddWithValue("@date_delivered", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
                cm.Parameters.AddWithValue("@date_created", DateAndTime.Now.ToString("yyyy-MM-dd hh:mm:ss"))
                cm.Parameters.AddWithValue("@customer_id", uid_customer)
                cm.Parameters.AddWithValue("@user_id", uid_user)
                cm.ExecuteNonQuery()
                cn.Close()
                Button2.Text = "Please Wait ..."
                Button2.Enabled = False
                With CustomerFormDetailView_Tab2
                    .loadrecord()
                End With
                Button2.Enabled = True
                Button2.Text = "Save"
                MsgBox("Record has been successfully saved.", vbInformation, title_app)

                cleartx()


            End If
        Else
            If (MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion, title_app) = vbYes) Then
                cn.Open()
                cm = New MySql.Data.MySqlClient.MySqlCommand("UPDATE brand SET brand = @brand WHERE id = @id;", cn)
                cm.Parameters.AddWithValue("@brand", TextBox1.Text)
                cm.Parameters.AddWithValue("@id", uid)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been successfully updated.", vbInformation, title_app)
                With BrandFormView
                    .loadrecord()
                End With

            End If
        End If
    End Sub
End Class