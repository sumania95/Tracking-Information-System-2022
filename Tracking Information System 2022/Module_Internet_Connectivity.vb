Imports System.Net

Module Module_Internet_Connectivity
    Public Function CheckForInternetConnection() As Boolean
        Try
            If My.Computer.Network.Ping("8.8.8.8") Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
End Module
