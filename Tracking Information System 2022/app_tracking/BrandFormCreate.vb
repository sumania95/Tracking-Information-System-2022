Public Class BrandFormCreate
    Public Sub Brand_AutoFill(uid As Integer)
        Try

            Button2.Text = "UPDATE"
            cn.Open()
            cm = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM brand WHERE id = @id;", cn)
            cm.Parameters.AddWithValue("@id", uid)
            dr = cm.ExecuteReader
            While dr.Read
                TextBox1.Text = dr.Item("brand").ToString
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical, title_app)

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "SAVE" Then
            If TextBox1.Text = String.Empty Then
                MsgBox("Warning : Brand field required!", vbCritical, title_app)
                Return
            End If
            If (MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion, title_app) = vbYes) Then
                cn.Open()
                cm = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO brand (brand) VALUES (@brand);", cn)
                cm.Parameters.AddWithValue("@brand", TextBox1.Text)
                cm.ExecuteNonQuery()
                cn.Close()
                Button2.Text = "Please Wait ..."
                Button2.Enabled = False
                With BrandFormView
                    .loadrecord()
                End With
                Button2.Enabled = True
                Button2.Text = "Save"
                MsgBox("Record has been successfully saved.", vbInformation, title_app)

                TextBox1.Clear()
                TextBox1.Select()


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