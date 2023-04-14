Public Class Nilai_Akhir_By_Reza_Ramadhan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Val(txtNilaiAkhir.Text) >= 60) Then
            txtKeterangan.Text = "Anda Lulus"
        Else
            txtKeterangan.Text = "Anda tidak Lulus, Silahkan mengulang tahun depan"
        End If
    End Sub
End Class
