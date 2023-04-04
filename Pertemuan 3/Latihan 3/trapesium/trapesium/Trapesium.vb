Public Class Trapesium
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub B_Hitung_Click(sender As Object, e As EventArgs) Handles B_Hitung.Click
        Dim Alas, SisiAlas, Tinggi, Sisi1, Sisi2, Sisi3, Sisi4, Luas, Keliling As Integer

        Alas = Val(TextAlas.Text)
        SisiAlas = Val(TextSisiAlas.Text)
        Tinggi = Val(TextTinggi.Text)
        Sisi1 = Val(TextSisi1.Text)
        Sisi2 = Val(TextSisi2.Text)
        Sisi3 = Val(TextSisi3.Text)
        Sisi4 = Val(TextSisi4.Text)

        Luas = 0.5 * (Alas + SisiAlas) * Tinggi
        Keliling = Sisi1 + Sisi2 + Sisi3 + Sisi4

        TextLuas.Text = Str(Luas)
        TextKeliling.Text = Str(Keliling)

    End Sub
End Class
