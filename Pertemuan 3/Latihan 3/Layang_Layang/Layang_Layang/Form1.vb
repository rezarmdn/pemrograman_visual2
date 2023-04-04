Public Class Layang_Layang
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub b_Hitung_Click(sender As Object, e As EventArgs) Handles b_Hitung.Click
        Dim Diagonal1, Diagonal2, Sisi1, Sisi2, Luas, Keliling As Integer

        Diagonal1 = Val(TextDiagonal1.Text)
        Diagonal2 = Val(TextDiagonal2.Text)
        Sisi1 = Val(TextSisi1.Text)
        Sisi2 = Val(TextSisi2.Text)

        Luas = 0.5 * (Diagonal1 * Diagonal2)
        Keliling = 2 * (Sisi1 + Sisi2)

        TextLuas.Text = Str(Luas)
        TextKeliling.Text = Str(Keliling)


    End Sub
End Class
