Public Class Form1
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim RESPONSE As Integer
        RESPONSE = MsgBox("ARE YOU SURE YOU WANT TO EXIT?", vbYesNo + vbQuestion, "WARNING")
        If RESPONSE = vbNo Then
            Exit Sub
        Else
            End
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class
