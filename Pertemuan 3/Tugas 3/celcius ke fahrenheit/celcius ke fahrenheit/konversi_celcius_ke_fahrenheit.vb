Public Class konversi_celcius_ke_fahrenheit

    Private Function HitungKonversiCelciusKeFahrenheit(Celcius As Integer) As Integer
        Dim Fahrenheit As Integer
        Fahrenheit = (Celcius * 9 / 5) + 32
        Return Fahrenheit
    End Function


    Private Sub B_Hitung_Click(sender As Object, e As EventArgs) Handles B_Hitung.Click
        Dim Celcius, CelciusFarenheit As Integer

        Celcius = Val(TextCelciusFahrenheit.Text)

        CelciusFarenheit = HitungKonversiCelciusKeFahrenheit(Celcius)

        TextKonversiFahrenheit.Text = Str(CelciusFarenheit)

    End Sub
End Class
