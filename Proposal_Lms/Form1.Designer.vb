<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Password_staff = New Label()
        Username_staff = New Label()
        PictureBox1 = New PictureBox()
        Login_staff = New Button()
        TextBox_staff2 = New TextBox()
        TextBox_staff1 = New TextBox()
        TabPage2 = New TabPage()
        Login_member = New Button()
        TextBox_member2 = New TextBox()
        Password_member = New Label()
        TextBox_member1 = New TextBox()
        Username_member = New Label()
        PictureBox2 = New PictureBox()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(226, 39)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(302, 328)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.White
        TabPage1.Controls.Add(Password_staff)
        TabPage1.Controls.Add(TextBox_staff1)
        TabPage1.Controls.Add(Username_staff)
        TabPage1.Controls.Add(PictureBox1)
        TabPage1.Controls.Add(Login_staff)
        TabPage1.Controls.Add(TextBox_staff2)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(294, 300)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Staff"
        ' 
        ' Password_staff
        ' 
        Password_staff.AutoSize = True
        Password_staff.Location = New Point(47, 175)
        Password_staff.Name = "Password_staff"
        Password_staff.Size = New Size(57, 15)
        Password_staff.TabIndex = 5
        Password_staff.Text = "Password"
        ' 
        ' Username_staff
        ' 
        Username_staff.AutoSize = True
        Username_staff.Location = New Point(47, 124)
        Username_staff.Name = "Username_staff"
        Username_staff.Size = New Size(60, 15)
        Username_staff.TabIndex = 4
        Username_staff.Text = "Username"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(116, 50)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(62, 57)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Login_staff
        ' 
        Login_staff.ForeColor = Color.Black
        Login_staff.Location = New Point(76, 239)
        Login_staff.Name = "Login_staff"
        Login_staff.Size = New Size(138, 29)
        Login_staff.TabIndex = 2
        Login_staff.Text = "Login"
        Login_staff.UseVisualStyleBackColor = True
        ' 
        ' TextBox_staff2
        ' 
        TextBox_staff2.Location = New Point(47, 142)
        TextBox_staff2.Name = "TextBox_staff2"
        TextBox_staff2.Size = New Size(196, 23)
        TextBox_staff2.TabIndex = 1
        ' 
        ' TextBox_staff1
        ' 
        TextBox_staff1.Location = New Point(47, 193)
        TextBox_staff1.Name = "TextBox_staff1"
        TextBox_staff1.Size = New Size(196, 23)
        TextBox_staff1.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Login_member)
        TabPage2.Controls.Add(TextBox_member2)
        TabPage2.Controls.Add(Password_member)
        TabPage2.Controls.Add(TextBox_member1)
        TabPage2.Controls.Add(Username_member)
        TabPage2.Controls.Add(PictureBox2)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(294, 300)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Member"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Login_member
        ' 
        Login_member.ForeColor = Color.Black
        Login_member.Location = New Point(82, 240)
        Login_member.Name = "Login_member"
        Login_member.Size = New Size(138, 29)
        Login_member.TabIndex = 9
        Login_member.Text = "Login"
        Login_member.UseVisualStyleBackColor = True
        ' 
        ' TextBox_member2
        ' 
        TextBox_member2.Location = New Point(54, 194)
        TextBox_member2.Name = "TextBox_member2"
        TextBox_member2.Size = New Size(196, 23)
        TextBox_member2.TabIndex = 8
        ' 
        ' Password_member
        ' 
        Password_member.AutoSize = True
        Password_member.Location = New Point(54, 176)
        Password_member.Name = "Password_member"
        Password_member.Size = New Size(57, 15)
        Password_member.TabIndex = 7
        Password_member.Text = "Password"
        ' 
        ' TextBox_member1
        ' 
        TextBox_member1.Location = New Point(54, 137)
        TextBox_member1.Name = "TextBox_member1"
        TextBox_member1.Size = New Size(196, 23)
        TextBox_member1.TabIndex = 6
        ' 
        ' Username_member
        ' 
        Username_member.AutoSize = True
        Username_member.Location = New Point(54, 119)
        Username_member.Name = "Username_member"
        Username_member.Size = New Size(60, 15)
        Username_member.TabIndex = 5
        Username_member.Text = "Username"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(116, 49)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(62, 57)
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Login_staff As Button
    Friend WithEvents TextBox_staff2 As TextBox
    Friend WithEvents TextBox_staff1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Username_staff As Label
    Friend WithEvents Password_staff As Label
    Friend WithEvents Login_member As Button
    Friend WithEvents TextBox_member2 As TextBox
    Friend WithEvents Password_member As Label
    Friend WithEvents TextBox_member1 As TextBox
    Friend WithEvents Username_member As Label

End Class
