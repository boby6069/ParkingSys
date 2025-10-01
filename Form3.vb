Public Class form3


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        ' Simple hardcoded login check
        Dim username As String = usernamebtn.Text
        Dim password As String = passwordbtn.Text

        If username = "admin" And password = "1234" Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Dim mainForm As New Form2()
            mainForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passwordbtn.UseSystemPasswordChar = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub usernamebtn_TextChanged(sender As Object, e As EventArgs) Handles usernamebtn.TextChanged

    End Sub

    Private Sub passwordbtn_TextChanged(sender As Object, e As EventArgs) Handles passwordbtn.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class