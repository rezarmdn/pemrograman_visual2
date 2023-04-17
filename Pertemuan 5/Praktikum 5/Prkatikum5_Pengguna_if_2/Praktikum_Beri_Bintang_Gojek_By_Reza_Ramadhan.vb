Public Class Praktikum_Beri_Bintang_Gojek_By_Reza_Ramadhan
    Private Sub B_Submit_Click(sender As Object, e As EventArgs) Handles B_Submit.Click
        If (Val(txtBeriBintang.Text) >= 5) Then
            txtKeterangan.Text = "sangat Puas"

        ElseIf (txtBeriBintang.Text >= 4) Then
            txtKeterangan.Text = "Puas"

        ElseIf (txtBeriBintang.Text >= 3) Then
            txtKeterangan.Text = "Biasa aja"

        ElseIf (txtBeriBintang.Text >= 2) Then
            txtKeterangan.Text = "Gak Puas"

        Else
            txtKeterangan.Text = "Sangat Gak Puas"
        End If
    End Sub
End Class
