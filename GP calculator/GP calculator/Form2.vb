Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim tcp As Integer
        Dim tnu As Integer
        If (ComboBox14.Text = " ") Or (ComboBox12.Text = " ") Or (ComboBox10.Text = " ") Or (ComboBox8.Text = " ") Or (ComboBox6.Text = " ") Or (ComboBox4.Text = " ") Or (ComboBox1.Text = " ") Or (TextBox1.Text = " ") Or (TextBox2.Text = " ") Or (TextBox3.Text = " ") Or (TextBox4.Text = " ") Or (TextBox5.Text = " ") Or (TextBox9.Text = "") Or (TextBox10.Text = " ") Or (ComboBox2.Text = " ") Or (ComboBox3.Text = " ") Or (ComboBox5.Text = " ") Or (ComboBox7.Text = "") Or (ComboBox9.Text = " ") Or (ComboBox11.Text = " ") Or (ComboBox13.Text = " ") Then
            MsgBox("Fill all Boxes ", vbExclamation, "information")
        Else

            Dim u1 As Integer = ComboBox2.Text
        Dim u2 As Integer = ComboBox3.Text
        Dim u3 As Integer = ComboBox5.Text
            Dim u4 As Integer = ComboBox7.Text
            Dim u5 As Integer = ComboBox9.Text
            Dim u6 As Integer = ComboBox11.Text
            Dim u7 As Integer = ComboBox13.Text
            tnu = u1 + u2 + u3 + u4 + u5 + u6 + u7


            Dim s1 As Integer = ComboBox1.Text
            Dim s2 As Integer = ComboBox4.Text
            Dim s3 As Integer = ComboBox6.Text
            Dim s4 As Integer = ComboBox8.Text
            Dim s5 As Integer = ComboBox10.Text
            Dim s6 As Integer = ComboBox12.Text
            Dim s7 As Integer = ComboBox14.Text
            tcp = (s1 * u1) + (s2 * u2) + (s3 * u3) + (s4 * u4) + (s5 * u5) + (s6 * u6) + (s7 * u7)

        End If

        If (tnu < 18) Then
            MsgBox("Total Number Of Unit Is Less Than Minimum ", vbExclamation, "information")
            TextBox6.Text = " "
            TextBox7.Text = " "
            TextBox8.Text = " "
        ElseIf (tnu > 24) Then
            MsgBox("Total Number Of Unit Is Greater Than Maximum ", vbExclamation, "information")
            TextBox6.Text = " "
            TextBox7.Text = " "
            TextBox8.Text = " "
        Else
            TextBox6.Text = tnu
            TextBox7.Text = tcp
            Dim gp As Single = tcp / tnu
            TextBox8.Text = Math.Round(gp, 2)
        End If




    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub ComboBox11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox11.SelectedIndexChanged

    End Sub

    Private Sub ComboBox10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox10.SelectedIndexChanged

    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox9.SelectedIndexChanged

    End Sub

    Private Sub ComboBox12_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox12.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim response As String
        response = MsgBox("ARE YOU SURE YOU WANT TO EXIT THIS APP", vbYesNo, "INFORMATION")
        If (response = vbNo) Then
            Exit Sub
        Else
            Me.Close()
            Form1.Close()
        End If
    End Sub
End Class