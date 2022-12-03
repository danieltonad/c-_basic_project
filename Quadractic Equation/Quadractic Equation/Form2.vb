Imports Microsoft.VisualBasic
Public Class Form2

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

        Form1.Close()
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)









    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click


        Dim a As Integer = Val(TextBox1.Text)
        Dim b As Integer = Val(TextBox2.Text)
        Dim c As Integer = Val(TextBox3.Text)
        Dim d As Single
        Dim f As Single
        Dim x1 As Single
        Dim x2 As Single



        If Val(TextBox1.Text = "") Or Val(TextBox2.Text = "") Or Val(TextBox3.Text = "") Then
            Label6.Visible = True

        ElseIf Val(TextBox1.Text = Text) Or Val(TextBox2.Text = Text) Or Val(TextBox3.Text = Text) Then
            Label6.Visible = True


        Else


            d = Math.Sqrt((b * b) - 4 * a * c)
            f = d / (2 * a)
            x1 = -b + d
            x2 = -b - d

            TextBox4.Text = x1
            TextBox5.Text = x2

            Label6.Visible = False

        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox3.Text = String.Empty
        TextBox4.Text = String.Empty
        TextBox5.Text = String.Empty

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 44 Or Asc(e.KeyChar) = 47 Or Asc(e.KeyChar) < 43 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            Label1.Visible = True

        Else
            Label1.Visible = False
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) = 44 Or Asc(e.KeyChar) = 47 Or Asc(e.KeyChar) < 43 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            Label1.Visible = True

        Else
            Label1.Visible = False
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) = 44 Or Asc(e.KeyChar) = 47 Or Asc(e.KeyChar) < 43 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            Label1.Visible = True

        Else
            Label1.Visible = False
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class