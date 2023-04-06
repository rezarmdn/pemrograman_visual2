Public Class Konversi_Reamur_ke_Kelvin

    Private Function HitungKonversiReanurkeKelvin(Reamur As Integer) As Integer
        Dim Kelvin As Integer
        Kelvin = (5 / 4 * Reamur) + 273
        Return Kelvin
    End Function

    Private Sub B_Hitung_Click(sender As Object, e As EventArgs) Handles B_Hitung.Click
        Dim Reamur, Kelvin As Integer

        Reamur = Val(TextReamur.Text)

        Kelvin = HitungKonversiReanurkeKelvin(Reamur)

        TextKelvin.Text = Str(Kelvin)

    End Sub
End Class
