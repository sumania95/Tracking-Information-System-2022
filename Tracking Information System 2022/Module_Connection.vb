Imports MySql.Data.MySqlClient


Module Module_Connection
    Public cn As New MySqlConnection
    Public cm As New MySqlCommand
    Public dr As MySqlDataReader

    Public development = True

    Public Sub connection()

        Try
            With cn
                .ConnectionString = "Server='sql6.freesqldatabase.com';Port=3306;Database=sql6523876;Uid=sql6523876;Pwd=KSmi3mJ4f3"
            End With
        Catch ex As Exception

        End Try

    End Sub
End Module
