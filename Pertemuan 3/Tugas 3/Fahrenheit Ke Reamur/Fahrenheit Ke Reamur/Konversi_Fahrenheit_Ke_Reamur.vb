Public Class Konversi_Fahrenheit_Ke_Reamur
    Private Function HitungKonversiFahrenheitKereamur(Fahrenheit As Integer) As Integer
        Dim Reamur As Integer
        Reamur = 4 / 9 * (Fahrenheit - 32)
        Return Reamur
    End Function

    Private Sub B_Hitung_Click(sender As Object, e As EventArgs) Handles B_Hitung.Click
        Dim Fahrenheit, Reamur As Integer

        Fahrenheit = Val(TextFahrenheit.Text)

        Reamur = HitungKonversiFahrenheitKereamur(Fahrenheit)

        TextReamur.Text = Str(Reamur)
    End Sub
End Class
