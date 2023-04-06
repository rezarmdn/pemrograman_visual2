Public Class konversi_celcius_ke_fahrenheit
    Private Sub B_Hitung_Click(sender As Object, e As EventArgs) Handles B_Hitung.Click
        Dim Celcius, CelciusFarenheit As Integer

        Celcius = Val(TextCelciusFahrenheit.Text)

        CelciusFarenheit = (Celcius * 9 / 5) + 32

        TextKonversiFahrenheit.Text = Str(CelciusFarenheit)

    End Sub
End Class
