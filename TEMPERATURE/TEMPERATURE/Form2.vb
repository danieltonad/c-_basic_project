
Imports Microsoft.VisualBasic
Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim C As Double = TextBox1.Text
        Dim F As Double = C * 1.8 + 32
        Dim ans As Double = Math.Round(F, 2)

        TextBox2.Text = ans




    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.ResetText()
        TextBox2.ResetText()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 44 Or Asc(e.KeyChar) = 47 Or Asc(e.KeyChar) < 43 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True

            MsgBox("ONLY NUMBERS ARE ALLOWED IN THE BOX ", vbExclamation, "INFORMATION")

        End If
    End Sub
End Class