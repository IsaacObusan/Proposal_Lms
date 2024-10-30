Public Class Form1
    ' Handles the text change event for the staff username TextBox.
    Private Sub TextBox_staff2_TextChanged(sender As Object, e As EventArgs) Handles TextBox_staff2.TextChanged
        ' Additional logic for staff username input can be added here if needed.
    End Sub

    ' Handles the text change event for the staff password TextBox.
    Private Sub TextBox_staff1_TextChanged(sender As Object, e As EventArgs) Handles TextBox_staff1.TextChanged
        ' Mask the password with asterisks.
        TextBox_staff1.PasswordChar = "*"c
    End Sub

    ' Handles the click event for the staff login button.
    Private Sub Login_staff_Click(sender As Object, e As EventArgs) Handles Login_staff.Click
        ' Define hardcoded credentials for the staff login.
        Dim username As String = "staff"
        Dim password As String = "staff"

        ' Check if entered credentials match.
        If TextBox_staff2.Text = username AndAlso TextBox_staff1.Text = password Then
            ' If login is successful, open Form2.
            Dim form2 As New Form2
            form2.Show()
            Me.Hide() ' Optionally hide Form1.
        Else
            ' Show an error message if credentials are incorrect.
            MessageBox.Show("Invalid staff username or password.")
        End If
    End Sub

    ' Handles the text change event for the member username TextBox.
    Private Sub TextBox_member1_TextChanged(sender As Object, e As EventArgs) Handles TextBox_member1.TextChanged
        ' Additional logic for member username input can be added here if needed.
    End Sub

    ' Handles the text change event for the member password TextBox.
    Private Sub TextBox_member2_TextChanged(sender As Object, e As EventArgs) Handles TextBox_member2.TextChanged
        ' Mask the password with asterisks.
        TextBox_member2.PasswordChar = "*"c
    End Sub

    ' Handles the click event for the member login button.
    Private Sub Login_member_Click(sender As Object, e As EventArgs) Handles Login_member.Click
        ' Define hardcoded credentials for the member login.
        Dim username As String = "member"
        Dim password As String = "member"

        ' Check if entered credentials match.
        If TextBox_member1.Text = username AndAlso TextBox_member2.Text = password Then
            ' If login is successful, open Form3.
            Dim form3 As New Form3
            form3.Show()
            Me.Hide() ' Optionally hide Form1.
        Else
            ' Show an error message if credentials are incorrect.
            MessageBox.Show("Invalid member username or password.")
        End If
    End Sub
End Class
