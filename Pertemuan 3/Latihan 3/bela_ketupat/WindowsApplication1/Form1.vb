Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextDiagonal2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextDiagonal1.TextChanged

    End Sub

    Private Sub b_hitung_Click(sender As Object, e As EventArgs) Handles b_hitung.Click
        Dim Diagonal1, Diagonal2, Luas, sisi, Keliling As Integer

        Diagonal1 = Val(TextDiagonal1.Text)
        Diagonal2 = Val(TextDiagonal2.Text)
        sisi = Val(Textsisi.Text)

        Luas = 0.5 * (Diagonal1 * Diagonal2)
        Keliling = 4 * sisi

        TextLuas.Text = Str(Luas)
        TextKeliling.Text = Str(Keliling)

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles Textsisi.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
