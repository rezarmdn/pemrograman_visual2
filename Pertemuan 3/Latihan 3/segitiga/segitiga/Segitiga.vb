Public Class Segitiga

    Private Sub B_Hitung_Click(sender As Object, e As EventArgs) Handles B_Hitung.Click
        Dim Alas, Tinggi, Sisi1, Sisi2, Sisi3, Luas, Keliling As Integer

        Alas = Val(TextAlas.Text)
        Tinggi = Val(TextTinggi.Text)
        Sisi1 = Val(TextSisi1.Text)
        Sisi2 = Val(TextSisi2.Text)
        Sisi3 = Val(TextSisi3.Text)

        Luas = 0.5 * Alas * Tinggi
        Keliling = Sisi1 + Sisi2 + Sisi3

        TextLuas.Text = Str(Luas)
        TextKeliling.Text = Str(Keliling)


    End Sub
End Class
