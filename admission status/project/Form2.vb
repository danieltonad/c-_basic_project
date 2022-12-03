Public Class Form2
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Name As String
        Dim jamb As Double
        Dim a1 As Integer = 10
        Dim b2 As Integer = 9
        Dim b3 As Integer = 8
        Dim c4 As Integer = 7
        Dim c5 As Integer = 6
        Dim c6 As Integer = 5
        Dim eng As Integer = Val(ComboBox2.Text)
        Dim math As Integer = Val(ComboBox5.Text)
        Dim chem As Integer = Val(ComboBox4.Text)
        Dim phy As Integer = Val(ComboBox3.Text)
        Dim total As Integer = math + eng + phy + chem


        Name = TextBox1.Text
        jamb = total / 8
        TextBox2.Text = total


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()
        TextBox5.Text = OpenFileDialog1.FileName
        PictureBox1.Image = Image.FromFile(TextBox5.Text)
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox1.Checked = True) Then
            CheckBox1.Checked = False
            TableLayoutPanel3.Visible = True
        Else 
            CheckBox1.Checked = True
            TableLayoutPanel3.Visible = False
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox2.Checked = True) Then
            CheckBox1.Checked = False
            TableLayoutPanel3.Visible = False
        ElseIf (CheckBox1.Checked = False) Then
            CheckBox1.Checked = True
            TableLayoutPanel3.Visible = False
        ElseIf (CheckBox1.Checked = True) Then
            CheckBox2.Checked = False
            TableLayoutPanel3.Visible = False
        End If
    End Sub
End Class
