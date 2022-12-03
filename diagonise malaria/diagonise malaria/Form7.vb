Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As Integer = Val(Form2.TextBox1.Text)
        Dim b As Integer = Val(Form3.TextBox1.Text)
        Dim c As Integer = Val(Form4.TextBox1.Text)
        Dim d As Integer = Val(Form5.TextBox1.Text)
        Dim f As Integer = Val(Form6.TextBox1.Text)

        Dim Tresult As Integer = a + b + c + d + f
        If (Tresult = 100) Then

        End If
        Label19.Text = Tresult
        Label19.Text = Label19.Text + "%"


        If (a = 20) Then
            Label9.Visible = True
        Else
            Label8.Visible = True
        End If

        If (b = 20) Then
            Label11.Visible = True
        Else
            Label10.Visible = True
        End If

        If (c = 20) Then
            Label13.Visible = True
        Else
            Label12.Visible = True
        End If

        If (d = 20) Then
            Label15.Visible = True
        Else
            Label14.Visible = True
        End If

        If (f = 20) Then
            Label17.Visible = True
        Else
            Label16.Visible = True
        End If



    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Restart()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        Dim RESPONE = MsgBox("Are you sure you want to exit this APP ", vbYesNo + vbInformation, "WARNING")


        If (RESPONE = vbNo) Then
            Exit Sub
        Else
            Application.Exit()

        End If







    End Sub

    Private Sub Label20_Click_1(sender As Object, e As EventArgs) Handles Label20.Click
        Dim RESPONE = MsgBox("Are you sure you want to exit this Application ", vbYesNo + vbInformation, "WARNING")


        If (RESPONE = vbNo) Then
            Exit Sub
        Else
            Environment.Exit(0)

        End If
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class