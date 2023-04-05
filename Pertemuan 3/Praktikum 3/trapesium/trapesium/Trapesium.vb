Public Class Trapesium
    Private Function HitungLuas(Alas As Integer, SIsiAlas As Integer, Tinggi As Integer) As Integer
        Dim Luas As Integer
        Luas = 0.5 * (Alas + SIsiAlas) * Tinggi
        Return Luas
    End Function

    Private Function HitungKeliling(Sisi1 As Integer, Sisi2 As Integer, Sisi3 As Integer, Sisi4 As Integer) As Integer
        Dim Keliling As Integer
        Keliling = Sisi1 + Sisi2 + Sisi3 + Sisi4
        Return Keliling
    End Function

    Private Sub B_Hitung_Click(sender As Object, e As EventArgs) Handles B_Hitung.Click
        Dim Alas, SisiAlas, Tinggi, Sisi1, Sisi2, Sisi3, Sisi4, Luas, Keliling As Integer

        Alas = Val(TextAlas.Text)
        SisiAlas = Val(TextSisiAlas.Text)
        Tinggi = Val(TextTinggi.Text)
        Sisi1 = Val(TextSisi1.Text)
        Sisi2 = Val(TextSisi2.Text)
        Sisi3 = Val(TextSisi3.Text)
        Sisi4 = Val(TextSisi4.Text)

        Luas = HitungLuas(Alas, SisiAlas, Tinggi)
        Keliling = HitungKeliling(Sisi1, Sisi2, Sisi3, Sisi4)

        TextLuas.Text = Str(Luas)
        TextKeliling.Text = Str(Keliling)

    End Sub
End Class
