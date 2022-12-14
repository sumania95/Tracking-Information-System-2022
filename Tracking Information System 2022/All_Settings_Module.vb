Module All_Settings_Module
    Public pagination_counter As Integer = 0
    Public title_app = "MANAGEMENT & INVENTORY SYSTEM 2022"
    Public uid As Integer
    Public uid_customer As Integer
    Public uid_user As Integer
    Public uid_brand As Integer
    Public user_name As String
    Public user_branch As String
    Public user_branch_id As Integer

    Function UppercaseFirstLetter(ByVal val As String) As String
        ' Test for nothing or empty.
        If String.IsNullOrEmpty(val) Then
            Return val
        End If

        ' Convert to character array.
        Dim array() As Char = val.ToCharArray

        ' Uppercase first character.
        array(0) = Char.ToUpper(array(0))

        ' Return new string.
        Return New String(array)
    End Function
End Module
