Public Class Persegi_bujur_sangkar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Panjang, Luas, Keliling As Integer

        Panjang = Val(TextPanjang.Text)

        Luas = Panjang * Panjang
        Keliling = 4 * Panjang

        TextLuas.Text = Str(Luas)
        TextKeliling.Text = Str(Keliling)

    End Sub
End Class
