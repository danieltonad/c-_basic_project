Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim RESPONSE As Integer
        RESPONSE = MsgBox("ARE YOU SURE YOU WANT TO EXIT?", vbYesNo + vbQuestion, "WARNING")
        If RESPONSE = vbNo Then
            Exit Sub
        Else
            Me.Close()
            Form1.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button1.Click

        Dim W As Double = Val(TextBox2.Text)
        Dim H As Double = Val(TextBox1.Text)
        Dim bmi As Double

        bmi = W / H ^ 2



        If (bmi >= 30) Then
            MsgBox("OBESITY", vbInformation)
        Else
            TextBox3.Text = Math.Round(bmi, 4)
        End If






    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("YOU CAN ONLY INPUT NUMBERS", vbExclamation, "INFORMATION")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("YOU CAN ONLY INPUT NUMBERS", vbExclamation, "INFORMATION")
        End If
    End Sub
End Class