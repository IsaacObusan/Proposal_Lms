<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Panel1 = New Panel()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Button8 = New Button()
        Button9 = New Button()
        Button10 = New Button()
        Button11 = New Button()
        Button12 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Maroon
        Panel1.Controls.Add(Button12)
        Panel1.Controls.Add(Button11)
        Panel1.Controls.Add(Button10)
        Panel1.Controls.Add(Button9)
        Panel1.Controls.Add(Button8)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 450)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(200, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(600, 42)
        Panel2.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(63, 29)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(66, 50)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Button8
        ' 
        Button8.FlatAppearance.BorderColor = Color.Maroon
        Button8.FlatAppearance.BorderSize = 0
        Button8.FlatAppearance.MouseDownBackColor = Color.IndianRed
        Button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button8.FlatStyle = FlatStyle.Flat
        Button8.ForeColor = SystemColors.ControlLightLight
        Button8.Image = CType(resources.GetObject("Button8.Image"), Image)
        Button8.ImageAlign = ContentAlignment.MiddleLeft
        Button8.Location = New Point(0, 140)
        Button8.Name = "Button8"
        Button8.Size = New Size(200, 37)
        Button8.TabIndex = 8
        Button8.Text = "Dashboard"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.FlatAppearance.BorderColor = Color.Maroon
        Button9.FlatAppearance.BorderSize = 0
        Button9.FlatAppearance.MouseDownBackColor = Color.IndianRed
        Button9.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button9.FlatStyle = FlatStyle.Flat
        Button9.ForeColor = SystemColors.ControlLightLight
        Button9.Image = CType(resources.GetObject("Button9.Image"), Image)
        Button9.ImageAlign = ContentAlignment.MiddleLeft
        Button9.Location = New Point(0, 183)
        Button9.Name = "Button9"
        Button9.Size = New Size(200, 37)
        Button9.TabIndex = 9
        Button9.Text = "Reservation"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.FlatAppearance.BorderColor = Color.Maroon
        Button10.FlatAppearance.BorderSize = 0
        Button10.FlatAppearance.MouseDownBackColor = Color.IndianRed
        Button10.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button10.FlatStyle = FlatStyle.Flat
        Button10.ForeColor = SystemColors.ControlLightLight
        Button10.Image = CType(resources.GetObject("Button10.Image"), Image)
        Button10.ImageAlign = ContentAlignment.MiddleLeft
        Button10.Location = New Point(0, 226)
        Button10.Name = "Button10"
        Button10.Size = New Size(200, 37)
        Button10.TabIndex = 10
        Button10.Text = "Fines"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Button11
        ' 
        Button11.FlatAppearance.BorderColor = Color.Maroon
        Button11.FlatAppearance.BorderSize = 0
        Button11.FlatAppearance.MouseDownBackColor = Color.IndianRed
        Button11.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button11.FlatStyle = FlatStyle.Flat
        Button11.ForeColor = SystemColors.ControlLightLight
        Button11.Image = CType(resources.GetObject("Button11.Image"), Image)
        Button11.ImageAlign = ContentAlignment.MiddleLeft
        Button11.Location = New Point(0, 269)
        Button11.Name = "Button11"
        Button11.Size = New Size(200, 37)
        Button11.TabIndex = 11
        Button11.Text = "Books"
        Button11.UseVisualStyleBackColor = True
        ' 
        ' Button12
        ' 
        Button12.FlatAppearance.BorderColor = Color.Maroon
        Button12.FlatAppearance.BorderSize = 0
        Button12.FlatAppearance.MouseDownBackColor = Color.IndianRed
        Button12.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button12.FlatStyle = FlatStyle.Flat
        Button12.ForeColor = SystemColors.ControlLightLight
        Button12.Image = CType(resources.GetObject("Button12.Image"), Image)
        Button12.ImageAlign = ContentAlignment.MiddleLeft
        Button12.Location = New Point(0, 312)
        Button12.Name = "Button12"
        Button12.Size = New Size(200, 37)
        Button12.TabIndex = 12
        Button12.Text = "Contact Librarian"
        Button12.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form3"
        Text = "Form3"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
End Class
