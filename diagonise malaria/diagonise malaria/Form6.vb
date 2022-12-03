Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result1 As Integer = Val(TextBox1.Text)

        TextBox1.Text = 20

        Me.Hide()
        Form7.Show()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim result1 As Integer = Val(TextBox1.Text)

        TextBox1.Text = 0
        Me.Hide()
        Form7.Show()


    End Sub
End Class