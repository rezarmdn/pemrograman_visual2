Public Class Segitiga

    Private Function HitungLuas(Alas As Integer, Tinggi As Integer) As Integer
        Dim Luas As Integer
        Luas = 0.5 * Alas * Tinggi
        Return Luas
    End Function

    Private Function HitungKeliling(Sisi1 As Integer, Sisi2 As Integer, Sisi3 As Integer) As Integer
        Dim Keliling As Integer
        Keliling = Sisi1 + Sisi2 + Sisi3
        Return Keliling
    End Function

    Private Sub B_Hitung_Click(sender As Object, e As EventArgs) Handles B_Hitung.Click
        Dim Alas, Tinggi, Sisi1, Sisi2, Sisi3, Luas, Keliling As Integer

        Alas = Val(TextAlas.Text)
        Tinggi = Val(TextTinggi.Text)
        Sisi1 = Val(TextSisi1.Text)
        Sisi2 = Val(TextSisi2.Text)
        Sisi3 = Val(TextSisi3.Text)

        Luas = HitungLuas(Alas, Tinggi)
        Keliling = HitungKeliling(Sisi1, Sisi2, Sisi3)

        TextLuas.Text = Str(Luas)
        TextKeliling.Text = Str(Keliling)


    End Sub
End Class
