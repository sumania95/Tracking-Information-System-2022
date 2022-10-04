Imports System.Deployment.Application
Imports System.Reflection

Public Class Base
    Private Sub Base_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        Me.Bounds = Screen.GetWorkingArea(Me)
        Login_View()
        connection()

        If ApplicationDeployment.IsNetworkDeployed Then
            ToolStripLabel2.Text = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString
        Else
            ToolStripLabel2.Text = Application.ProductVersion.ToString
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If CheckForInternetConnection() Then
            ToolStripLabel6.ForeColor = Color.Green
            ToolStripLabel6.Text = "CONNECTED"
        Else
            ToolStripLabel6.ForeColor = Color.Red

            ToolStripLabel6.Text = "DISCONNECTED"
        End If

    End Sub
End Class
