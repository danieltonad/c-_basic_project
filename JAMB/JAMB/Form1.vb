Public Class Form1
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub close_MouseHover(sender As Object, e As EventArgs) Handles close.MouseHover
        close.BackColor = Color.Red
    End Sub

    Private Sub close_MouseLeave(sender As Object, e As EventArgs) Handles close.MouseLeave
        close.BackColor = head.BackColor
    End Sub

    Private Sub mini_MouseHover(sender As Object, e As EventArgs) Handles mini.MouseHover
        mini.BackColor = Color.FromArgb(249, 159, 69)
    End Sub

    Private Sub mini_MouseLeave(sender As Object, e As EventArgs) Handles mini.MouseLeave
        mini.BackColor = head.BackColor
    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles close.Click
        Environment.Exit(0)
    End Sub

    Private Sub proceed_MouseHover(sender As Object, e As EventArgs) Handles proceed.MouseHover
        proceed.ForeColor = Color.Black

    End Sub

    Private Sub proceed_MouseLeave(sender As Object, e As EventArgs) Handles proceed.MouseLeave
        proceed.ForeColor = Color.White

    End Sub

    Private Sub proceed_Click(sender As Object, e As EventArgs) Handles proceed.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub mini_Click(sender As Object, e As EventArgs) Handles mini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
