Public Class Persegi_bujur_sangkar

    Private Function HitungLuas(Panjang As Integer) As Integer
        Dim Luas As Integer
        Luas = Panjang * Panjang
        Return Luas
    End Function

    Private Function HitungKeliling(Panjang As Integer) As Integer
        Dim Keliling As Integer
        Keliling = 4 * Panjang
        Return Keliling
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Panjang, Luas, Keliling As Integer

        Panjang = Val(TextPanjang.Text)

        Luas = HitungLuas(Panjang)
        Keliling = HitungKeliling(Panjang)

        TextLuas.Text = Str(Luas)
        TextKeliling.Text = Str(Keliling)

    End Sub
End Class
