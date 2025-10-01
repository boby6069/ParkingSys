Public Class Form2


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.ForeColor = Color.White
    End Sub

    Private Sub btnin_Click(sender As Object, e As EventArgs) Handles btnin.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Application.Exit()
    End Sub

    Private Sub btnout_Click(sender As Object, e As EventArgs) Handles btnout.Click
        Me.Hide()
        Form4.Show()
    End Sub
End Class