<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginFormView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginFormView))
        Me.txPass = New MetroFramework.Controls.MetroTextBox()
        Me.txUser = New MetroFramework.Controls.MetroTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txPass
        '
        '
        '
        '
        Me.txPass.CustomButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txPass.CustomButton.Image = Nothing
        Me.txPass.CustomButton.Location = New System.Drawing.Point(320, 1)
        Me.txPass.CustomButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txPass.CustomButton.Name = ""
        Me.txPass.CustomButton.Size = New System.Drawing.Size(43, 43)
        Me.txPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txPass.CustomButton.TabIndex = 1
        Me.txPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txPass.CustomButton.UseSelectable = True
        Me.txPass.CustomButton.Visible = False
        Me.txPass.DisplayIcon = True
        Me.txPass.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txPass.Lines = New String(-1) {}
        Me.txPass.Location = New System.Drawing.Point(20, 293)
        Me.txPass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txPass.MaxLength = 32767
        Me.txPass.Name = "txPass"
        Me.txPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txPass.PromptText = "Password"
        Me.txPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txPass.SelectedText = ""
        Me.txPass.SelectionLength = 0
        Me.txPass.SelectionStart = 0
        Me.txPass.ShortcutsEnabled = True
        Me.txPass.Size = New System.Drawing.Size(364, 45)
        Me.txPass.TabIndex = 1
        Me.txPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txPass.UseSelectable = True
        Me.txPass.WaterMark = "Password"
        Me.txPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txPass.WaterMarkFont = New System.Drawing.Font("Bahnschrift", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txUser
        '
        '
        '
        '
        Me.txUser.CustomButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txUser.CustomButton.Image = Nothing
        Me.txUser.CustomButton.Location = New System.Drawing.Point(320, 1)
        Me.txUser.CustomButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txUser.CustomButton.Name = ""
        Me.txUser.CustomButton.Size = New System.Drawing.Size(43, 43)
        Me.txUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txUser.CustomButton.TabIndex = 1
        Me.txUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txUser.CustomButton.UseSelectable = True
        Me.txUser.CustomButton.Visible = False
        Me.txUser.DisplayIcon = True
        Me.txUser.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txUser.Lines = New String(-1) {}
        Me.txUser.Location = New System.Drawing.Point(20, 238)
        Me.txUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txUser.MaxLength = 32767
        Me.txUser.Name = "txUser"
        Me.txUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txUser.PromptText = "Username"
        Me.txUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txUser.SelectedText = ""
        Me.txUser.SelectionLength = 0
        Me.txUser.SelectionStart = 0
        Me.txUser.ShortcutsEnabled = True
        Me.txUser.Size = New System.Drawing.Size(364, 45)
        Me.txUser.TabIndex = 0
        Me.txUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txUser.UseSelectable = True
        Me.txUser.WaterMark = "Username"
        Me.txUser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txUser.WaterMarkFont = New System.Drawing.Font("Bahnschrift", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Orange
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(20, 403)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(364, 45)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SlateGray
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(20, 348)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(364, 45)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "LOGIN"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txUser)
        Me.Panel1.Controls.Add(Me.txPass)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(22, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(412, 471)
        Me.Panel1.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SlateGray
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(20, 19)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(364, 203)
        Me.Panel2.TabIndex = 21
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(73, 35)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(277, 141)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'LoginFormView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 521)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginFormView"
        Me.Text = "LoginFormView"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txPass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txUser As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
End Class
