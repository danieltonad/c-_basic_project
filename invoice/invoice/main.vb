
Public Class main

    Dim count As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim price As Decimal = Decimal.Parse(item_price.Text)
        Dim item_name As String = name.Text
        Dim qty As Integer = Decimal.Parse(item_quantity.Text)
        Dim total As Decimal = qty * price

        If (item_price Is Nothing Or name Is Nothing Or item_quantity Is Nothing) Then
            MsgBox("Input Valid Item Info ")
        Else
            count = count + 1
            datagrid.Rows.Add(item_name, qty, price.ToString("n"), total.ToString("n"))
            invoice.datagrid.Rows.Add(count, item_name, price.ToString("n"), qty, total.ToString("n"))
            item_price.Clear()
            name.Clear()
            item_quantity.Clear()

            total_t.Text = (total + Decimal.Parse(total_t.Text)).ToString("n")
        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        datagrid.Rows.Clear()
        invoice.datagrid.Rows.Clear()
        total_t.Text = (0).ToString("n")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        invoice.Show()

    End Sub
End Class
