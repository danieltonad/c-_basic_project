Imports Microsoft.VisualBasic
Public Class Form2
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox5.TextChanged, TextBox4.TextChanged, TextBox3.TextChanged, TextBox2.TextChanged
        Label7.Visible = False
        Label8.Visible = False
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim A As Double = Val(TextBox1.Text)
        Dim B As Double = Val(TextBox2.Text)
        Dim C As Double = Val(TextBox3.Text)
        Dim D As Double = Val(TextBox4.Text)
        Dim F As Double = Val(TextBox5.Text)

        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Or (TextBox5.Text = "") Then

            MsgBox("FIll ALL TEXT FIELDS", vbExclamation, "INFORMATION")

            Label7.Visible = False
            Label8.Visible = False

        ElseIf (A >= B) And (A >= C) And (A >= D) And (A >= F) Then
            Label8.Text = A
            Label7.Visible = True
            Label8.Visible = True

        ElseIf (B >= A) And (B >= C) And (B >= D) And (B >= F) Then
            Label8.Text = B
            Label7.Visible = True
            Label8.Visible = True

        ElseIf (C >= A) And (C >= B) And (C >= D) And (C >= F) Then
            Label8.Text = C
            Label7.Visible = True
            Label8.Visible = True

        ElseIf (D >= A) And (D >= B) And (D >= C) And (D >= F) Then
            Label8.Text = D
            Label7.Visible = True
            Label8.Visible = True

        ElseIf (F >= A) And (F >= B) And (F >= C) And (F >= D) Then
            Label8.Text = F
            Label7.Visible = True
            Label8.Visible = True

        End If





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Dim RESPONSE As Integer
        RESPONSE = MsgBox("ARE YOU SURE YOU WANT TO EXIT?", vbYesNo + vbQuestion, "WARNING")
        If RESPONSE = vbNo Then
            Exit Sub
        Else
            Me.Close()
            Form1.Close()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("YOU CAN ONLY INPUT NUMBERS", vbExclamation, "INFORMATION")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("YOU CAN ONLY INPUT NUMBERS", vbExclamation, "INFORMATION")
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("YOU CAN ONLY INPUT NUMBERS", vbExclamation, "INFORMATION")
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("YOU CAN ONLY INPUT NUMBERS", vbExclamation, "INFORMATION")
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("YOU CAN ONLY INPUT NUMBERS", vbExclamation, "INFORMATION")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        Label7.Visible = False
        Label8.Visible = False
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class