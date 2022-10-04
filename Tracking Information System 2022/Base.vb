Imports System.Deployment.Application
Imports System.Reflection

Public Class Base
    Private Sub Base_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Bounds = Screen.GetWorkingArea(Me)
        If ApplicationDeployment.IsNetworkDeployed Then
            ToolStripLabel1.Text = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString
        Else
            ToolStripLabel1.Text = Application.ProductVersion.ToString
        End If
    End Sub
End Class
