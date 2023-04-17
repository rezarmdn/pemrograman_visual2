Public Class Form1
    Private Sub B_Submit_Click(sender As Object, e As EventArgs) Handles B_Submit.Click
        If (Val(txtBeratBadan.Text) >= 75) Then
            txtKeterangan.Text = "Mending Diet AJa Berat Badan Udah Terlalu Besar"

        ElseIf (txtBeratBadan.Text >= 67) Then
            txtKeterangan.Text = "Berat Badan Besar"

        ElseIf (txtBeratBadan.Text >= 62) Then
            txtKeterangan.Text = "Berat Badan Sedang"

        ElseIf (txtBeratBadan.Text >= 57) Then
            txtKeterangan.Text = "Berat Badan Kecil"

        Else
            txtKeterangan.Text = "Maaf Berat Badan Terlalu Kecil"
        End If
    End Sub
End Class
