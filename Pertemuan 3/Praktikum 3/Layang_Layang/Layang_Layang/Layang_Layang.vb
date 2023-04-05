Public Class Layang_Layang
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Function HitungLuas(Diagonal1 As Integer, Diagonal2 As Integer, Sisi As Integer) As Integer
        Dim Luas As Integer
        Luas = 0.5 * (Diagonal1 * Diagonal2)
        Return Luas
    End Function

    Private Function HitungKeliling(Diagonal1 As Integer, Diagonal2 As Integer, Sisi1 As Integer, Sisi2 As Integer) As Integer
        Dim Keliling As Integer
        Keliling = 2 * (Sisi1 + Sisi2)
        Return Keliling
    End Function

    Private Sub b_Hitung_Click(sender As Object, e As EventArgs) Handles b_Hitung.Click
        Dim Diagonal1, Diagonal2, Sisi1, Sisi2, Luas, Keliling As Integer

        Diagonal1 = Val(TextDiagonal1.Text)
        Diagonal2 = Val(TextDiagonal2.Text)
        Sisi1 = Val(TextSisi1.Text)
        Sisi2 = Val(TextSisi2.Text)

        Luas = HitungLuas(Diagonal1, Diagonal2, Sisi1)
        Keliling = HitungKeliling(Diagonal1, Diagonal2, Sisi1, Sisi2)

        TextLuas.Text = Str(Luas)
        TextKeliling.Text = Str(Keliling)


    End Sub
End Class
