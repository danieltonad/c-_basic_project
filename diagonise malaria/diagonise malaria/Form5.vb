Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result1 As Integer = Val(TextBox1.Text)

        Me.Hide()
        Form6.Show()

        TextBox1.Text = 20
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result1 As Integer = Val(TextBox1.Text)

        Me.Hide()
        Form6.Show()

        TextBox1.Text = 0
    End Sub
End Class