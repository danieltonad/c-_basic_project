Public Class wages
    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles period.TextChanged, week_hours.TextChanged, earn.TextChanged
        solution.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim earning As Double = Val(earn.Text)
        Dim wwh As Double = Val(week_hours.Text)
        Dim _year, _day, _hour, _month As Double


        If (week_hours.Text = "") Or (period.Text = "") Or (earn.Text = "") Then
            MsgBox("Please Fill All Required Information", +vbExclamation)
        Else
            If (period.Text = "Year") Then

                _year = earning
                _month = earning / 12
                _day = _month / 20
                _hour = _day / (wwh / 5)

            ElseIf (period.Text = "Month") Then
                _year = earning * 12
                _month = earning
                _day = _month / 20
                _hour = _day / (wwh / 5)
            End If

            year.Text = Math.Round(_year, 2)
            month.Text = Math.Round(_month, 2)
            day.Text = Math.Round(_day, 2)
            hour.Text = Math.Round(_hour, 2)
            solution.Visible = True
        End If


    End Sub

    Private Sub week_hours_KeyPress(sender As Object, e As KeyPressEventArgs) Handles week_hours.KeyPress, earn.KeyPress

        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("YOU CAN ONLY INPUT NUMBERS", vbExclamation, "*INFORMATION*")
        End If
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover

        Button1.ForeColor = Color.White
        Button1.BackColor = Color.Black

    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Gold
        Button1.ForeColor = Color.Black
    End Sub
End Class
