Public Class invoice
    Private Sub invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        total_t.Text = main.total_t.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        main.Show()
    End Sub
End Class