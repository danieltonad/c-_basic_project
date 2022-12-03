Public Class Form2
    Dim count As Integer = 1
    Private Sub close_Click(sender As Object, e As EventArgs) Handles close.Click
        Environment.Exit(0)
    End Sub

    Private Sub close_MouseHover(sender As Object, e As EventArgs) Handles close.MouseHover
        close.BackColor = Color.Red
    End Sub

    Private Sub close_MouseLeave(sender As Object, e As EventArgs) Handles close.MouseLeave
        close.BackColor = head.BackColor
    End Sub

    Private Sub mini_MouseHover(sender As Object, e As EventArgs) Handles mini.MouseHover
        mini.BackColor = Color.FromArgb(249, 159, 69)
    End Sub

    Private Sub mini_MouseLeave(sender As Object, e As EventArgs) Handles mini.MouseLeave
        mini.BackColor = head.BackColor
    End Sub

    Private Sub mini_Click(sender As Object, e As EventArgs) Handles mini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub generate_MouseHover(sender As Object, e As EventArgs) Handles generate.MouseHover
        generate.ForeColor = Color.Black
    End Sub

    Private Sub generate_MouseLeave(sender As Object, e As EventArgs) Handles generate.MouseLeave
        generate.ForeColor = Color.White
    End Sub

    Private Sub eng_CheckStateChanged(sender As Object, e As EventArgs) Handles eng.CheckedChanged

        If (eng.Checked = False) Then
            MsgBox("ENGLISH IS COMPULSORY", vbOKOnly + vbInformation, "INFORMATON")
            eng.CheckState = CheckState.Checked
        End If
        subPanel.Visible = False
        BtnPanel.Visible = True
    End Sub

    Private Sub geo_CheckedChanged(sender As Object, e As EventArgs) Handles geo.Click

        If (geo.Checked) Then
            If (count < 4) Then
                count += 1
            Else
                MsgBox("MINIMUM AND MAXIMUM OF 4 SUBJECT", vbOKOnly + vbInformation, "INFORMATON")
                geo.Checked = False
            End If

        Else
            count -= 1
        End If
        subPanel.Visible = False
        BtnPanel.Visible = True
    End Sub

    Private Sub math_CheckedChanged(sender As Object, e As EventArgs) Handles math.Click
        If (math.Checked) Then
            If (count < 4) Then
                count += 1
            Else
                MsgBox("MINIMUM AND MAXIMUM OF 4 SUBJECT", vbOKOnly + vbInformation, "INFORMATON")
                math.Checked = False
            End If

        Else
            count -= 1
        End If
        subPanel.Visible = False
        BtnPanel.Visible = True
    End Sub

    Private Sub chem_CheckedChanged(sender As Object, e As EventArgs) Handles chem.Click
        If (chem.Checked) Then
            If (count < 4) Then
                count += 1
            Else
                MsgBox("MINIMUM AND MAXIMUM OF 4 SUBJECT", vbOKOnly + vbInformation, "INFORMATON")
                chem.Checked = False
            End If

        Else
            count -= 1
        End If
        subPanel.Visible = False
        BtnPanel.Visible = True
    End Sub

    Private Sub phy_CheckedChanged(sender As Object, e As EventArgs) Handles phy.Click
        If (phy.Checked) Then
            If (count < 4) Then
                count += 1
            Else
                MsgBox("MINIMUM AND MAXIMUM OF 4 SUBJECT", vbOKOnly + vbInformation, "INFORMATON")
                phy.Checked = False
            End If

        Else
            count -= 1
        End If
        subPanel.Visible = False
        BtnPanel.Visible = True
    End Sub

    Private Sub agric_Click(sender As Object, e As EventArgs) Handles agric.Click
        If (agric.Checked) Then
            If (count < 4) Then
                count += 1
            Else
                MsgBox("MINIMUM AND MAXIMUM OF 4 SUBJECT", vbOKOnly + vbInformation, "INFORMATON")
                agric.Checked = False
            End If

        Else
            count -= 1
        End If
        subPanel.Visible = False
        BtnPanel.Visible = True
    End Sub

    Private Sub bio_Click(sender As Object, e As EventArgs) Handles bio.Click
        If (bio.Checked) Then
            If (count < 4) Then
                count += 1
            Else
                MsgBox("MINIMUM AND MAXIMUM OF 4 SUBJECT", vbOKOnly + vbInformation, "INFORMATON")
                bio.Checked = False
            End If

        Else
            count -= 1
        End If
        subPanel.Visible = False
        BtnPanel.Visible = True
    End Sub

    Private Sub generate_Click(sender As Object, e As EventArgs) Handles generate.Click
        If (count = 4) Then
            BtnPanel.Visible = False
            If (eng.Checked) And (geo.Checked) And (math.Checked) And (phy.Checked) Then
                subject.Text = "1. Computer Science
2. Geology
3. Geography
4. Building
5. Pure and Applied Mathematics
6. Surveying & Geoinformatics
                                "
                subPanel.Visible = True

            ElseIf (eng.Checked) And (bio.Checked) And (chem.Checked) And (phy.Checked) Then

                subject.Text = "1.   Medicine and Surgery
2.   Biochemistry
3.   Chemistry
4.   Biological Science
5.   Nursing
6.   Geology
7.   Micro Biology
8.   Botany
9.   Zoology
10. Pharmacy
11. Fisheries
12. Agricultural Science                                "
                subPanel.Visible = True


            ElseIf (eng.Checked) And (math.Checked) And (chem.Checked) And (phy.Checked) Then

                subject.Text = "1.   Computer Science
2.   Agricultural Engineering
3.   Mathematics
4.   Industrial Chemistry
5.   Geology
6.   Surveying and Geoinformatics
7.   Statistics
8.   Building
9.   Pure and Applied Mathematics
10. Chemistry
11. Physics
12. Computer Engineering
13. Mechanical Engineering
14. Electrical Engineering
15. Electronics Engineering
15. Chemical and Polymer Engineering
16. Civil Engineering
"
                subPanel.Visible = True

            ElseIf (eng.Checked) And (bio.Checked) And (math.Checked) And (phy.Checked) Then

                subject.Text = "1.   Computer Science
2.   Physics
3.   Mathematics
4.   Statistics
5.   Building
6.   Geology
7.   Surveying and Geoinformatics
8.   Pured and Applied Mathematics
"
                subPanel.Visible = True

            ElseIf (eng.Checked) And (agric.Checked) And (chem.Checked) And (math.Checked) Then

                subject.Text = "1.   Agricultural Science
2.   Food Science and Technology
3.   Mathematics
4.   Industrial Chemistry
5.   Fisheries
6.   Geology
7.   Statistics
"
                subPanel.Visible = True

            ElseIf (eng.Checked) And (bio.Checked) And (chem.Checked) And (math.Checked) Then

                subject.Text = "1.   Bilogical Science
2.   Chemistry
3.   Mathematics
4.   Industrial Chemistry
5.   Fisheries
6.   Geology
7.   Micro Biology
8.   Botany
9.   Zoology
"
                subPanel.Visible = True

            ElseIf (eng.Checked) And (math.Checked) And (phy.Checked) And (agric.Checked) Then

                subject.Text = "1.   Computer Science
2.   Mathematics
3.   Statistics
4.   Pured and Applied Mathematics
"
                subPanel.Visible = True

            ElseIf (eng.Checked) And (geo.Checked) And (math.Checked) And (chem.Checked) Then

                subject.Text = "1.   Geography
2.   Urban & Regional Planning 
3.   Geology
"
                subPanel.Visible = True

            ElseIf (eng.Checked) And (geo.Checked) And (math.Checked) And (agric.Checked) Then

                subject.Text = "1.   Geography
2.   Geology
"
                subPanel.Visible = True


            ElseIf (eng.Checked) And (geo.Checked) And (math.Checked) And (bio.Checked) Then

                subject.Text = "1.   Geography
2.   Geology
"
                subPanel.Visible = True


            ElseIf (eng.Checked) And (chem.Checked) And (phy.Checked) And (agric.Checked) Then

                subject.Text = "1.   Fisheries
2.   Agricultural Extension
"
                subPanel.Visible = True


            ElseIf (eng.Checked) And (geo.Checked) And (phy.Checked) And (agric.Checked) Then

                subject.Text = "1.   Geography
"
                subPanel.Visible = True


            ElseIf (eng.Checked) And (geo.Checked) And (bio.Checked) And (agric.Checked) Then

                subject.Text = "1.   Geography
2.   Geology
"
                subPanel.Visible = True


            ElseIf (eng.Checked) And (geo.Checked) And (chem.Checked) And (agric.Checked) Then

                subject.Text = "1.   Geography
2.   Fisheries
"
                subPanel.Visible = True



            ElseIf (eng.Checked) And (geo.Checked) And (phy.Checked) And (bio.Checked) Then

                subject.Text = "1.   Geography
2.   Geology
"
                subPanel.Visible = True


            End If
        Else
            MsgBox("PLEASE SELECT TOTAL OF 4 SUBJECTS", vbOKOnly + vbInformation, "INFORMATON")
            BtnPanel.Visible = True
        End If
    End Sub
End Class