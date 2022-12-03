Public Class Form1

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Environment.Exit(0)
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles about.Click
        slide.Height = about.Height
        slide.Left = about.Left
        slide.Visible = True
        About2.BringToFront()
        back.Visible = True
    End Sub

    Private Sub grp_Click(sender As Object, e As EventArgs) Handles grp.Click
        slide.Height = grp.Height
        slide.Left = grp.Left
        slide.Visible = True
        Members1.BringToFront()
        back.Visible = True

    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        slide.Visible = False
        Wages2.BringToFront()
        back.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Wages2.BringToFront()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
