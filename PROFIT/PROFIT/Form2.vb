Imports Microsoft.VisualBasic
Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim T As Double = Val(TextBox1.Text)
        Dim C As Double = Val(TextBox2.Text)
        Dim EX As Double = Val(TextBox3.Text)
        Dim P As Double

        If (T < C Or T < EX) Then
            MsgBox("TOTAL SALES CANNOT BE LESS THAN EXPENSES OR COST OF SOLD GOODS ", vbInformation)
        ElseIf (EX > T) Then
            MsgBox("Total Expenses Cannot Be Greater Than Total Sales")
        Else
            P = T - C - EX
            TextBox4.Text = P
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("ONLY NUMBERS ARE ALLOWED IN THE BOX ", vbExclamation, "INFORMATION")
        End If


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("ONLY NUMBERS ARE ALLOWED IN THE BOX ", vbExclamation, "INFORMATION")
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("ONLY NUMBERS ARE ALLOWED IN THE BOX ", vbExclamation, "INFORMATION")
        End If
    End Sub
End Class