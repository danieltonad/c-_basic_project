Public Class Form2
    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim d As Integer
        Dim f As Integer
        Dim g As Double
        Dim T As Double
        Dim grand_t As Double


        If (ComboBox1.Text = "Corolla") Then
            a = 290000

        ElseIf (ComboBox1.Text = "Allex") Then
            a = 380000

        ElseIf (ComboBox1.Text = "Camry") Then
            a = 202000

        ElseIf (ComboBox1.Text = "Corona") Then
            a = 2000400

        ElseIf (ComboBox1.Text = "Avenza") Then
            a = 300400

        ElseIf (ComboBox1.Text = "Belta") Then
            a = 150000

        ElseIf (ComboBox1.Text = "Auris") Then
            a = 310400

        ElseIf (ComboBox1.Text = "Alphard") Then
            a = 290400

        ElseIf (ComboBox1.Text = "Avallon") Then
            a = 249000

        ElseIf (ComboBox1.Text = "Land Crusier") Then
            a = 590400

        ElseIf (ComboBox1.Text = "Highlander") Then
            a = 250000

        ElseIf (ComboBox1.Text = "4runner") Then
            a = 210000

        ElseIf (ComboBox1.Text = "Yaris") Then
            a = 99000

        ElseIf (ComboBox1.Text = "Sienna") Then
            a = 470000
        ElseIf (ComboBox1.Text = "Prado") Then
            a = 980670

        Else
            a = 0

        End If


        If (ComboBox2.Text = "V6") Then
            b = 490000
        ElseIf (ComboBox2.Text = "V4") Then
            b = 230000
        ElseIf (ComboBox2.Text = "V8") Then
            b = 670000
        ElseIf (ComboBox2.Text = "V12") Then
            b = 930000
        Else
            b = 0
        End If

        If (ComboBox3.Text = "BLACK") Then
            c = 35000
        ElseIf (ComboBox3.Text = "WHITE") Then
            c = 39000
        ElseIf (ComboBox3.Text = "GOLD") Then
            c = 70000
        ElseIf (ComboBox3.Text = "GREEN") Then
            c = 28000
        ElseIf (ComboBox3.Text = "YELLOW") Then
            c = 47000
        ElseIf (ComboBox3.Text = "BLUE") Then
            c = 36000
        ElseIf (ComboBox3.Text = "SILVER") Then
            c = 60000
        ElseIf (ComboBox3.Text = "RED") Then
            c = 40000
        Else
            c = 0

        End If


        If (ComboBox4.Text = "2000") Then
            d = 100000
        ElseIf (ComboBox4.Text = "2001") Then
            d = 150000
        ElseIf (ComboBox4.Text = "2002") Then
            d = 170000
        ElseIf (ComboBox4.Text = "2003") Then
            d = 200000
        ElseIf (ComboBox4.Text = "2004") Then
            d = 250000
        ElseIf (ComboBox4.Text = "2005") Then
            d = 350000
        ElseIf (ComboBox4.Text = "2006") Then
            d = 400000
        ElseIf (ComboBox4.Text = "2007") Then
            d = 470000
        ElseIf (ComboBox4.Text = "2008") Then
            d = 500000
        ElseIf (ComboBox4.Text = "2009") Then
            d = 550000
        ElseIf (ComboBox4.Text = "2010") Then
            d = 600000
        ElseIf (ComboBox4.Text = "2001") Then
            d = 650000
        ElseIf (ComboBox4.Text = "2001") Then
            d = 700000
        ElseIf (ComboBox4.Text = "2011") Then
            d = 800000
        ElseIf (ComboBox4.Text = "2012") Then
            d = 870000
        ElseIf (ComboBox4.Text = "2013") Then
            d = 930000
        ElseIf (ComboBox4.Text = "2014") Then
            d = 997000
        ElseIf (ComboBox4.Text = "2015") Then
            d = 1000000
        ElseIf (ComboBox4.Text = "2016") Then
            d = 1500000
        ElseIf (ComboBox4.Text = "2017") Then
            d = 2000000
        ElseIf (ComboBox4.Text = "2018") Then
            d = 2500000
        ElseIf (ComboBox4.Text = "2019") Then
            d = 5500000
        ElseIf (ComboBox4.Text = "2020") Then
            d = 7500000
        Else
            d = 0
        End If


        If (ComboBox5.Text = "0.5hp") Then
            f = 40000
        ElseIf (ComboBox5.Text = "1hp") Then
            f = 75000
        ElseIf (ComboBox5.Text = "1.5hp") Then
            f = 95000
        ElseIf (ComboBox5.Text = "2hp") Then
            f = 120000
        Else
            f = 0

        End If

        T = a + b + c + d + f
        If (ComboBox6.Text = "Used") Then
            g = T * 0.7
        ElseIf (ComboBox6.Text = "Foreign") Then
            g = T * 2.5
        Else
            g = 0
        End If




        If (ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Or ComboBox4.Text = "" Or ComboBox5.Text = "" Or ComboBox6.Text = "") Then

            MsgBox("Please Select All Car Features", vbExclamation)
        Else



            grand_t = g


            TextBox1.Text = grand_t
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim RESPONSE = MsgBox("ARE YOU SURE YOU TO CLOSE THIS APP", vbInformation + vbYesNo, "INFORMATION")
        If (RESPONSE = vbYes) Then
            Form1.Close()
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub
End Class