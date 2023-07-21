Public Class Form1

    Private Sub MatikanSemuaMenu()
        MenuPendataan.Visible = False
        LoginBar.Visible = True
        LogoutBar.Visible = False
    End Sub

    Private Sub LoginBar_Click(sender As Object, e As EventArgs) Handles LoginBar.Click
        LoginForm.ShowDialog()
    End Sub


    Private Sub LogoutBar_Click(sender As Object, e As EventArgs) Handles LogoutBar.Click
        MatikanSemuaMenu()

    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Jika user login adalah Admin
        If (admin_role = True) Then
            MenuPendataan.Visible = False
            LoginBar.Visible = False
            LogoutBar.Visible = True
        End If

        'Jika user login adalah Dosen
        If (dosen_role = True) Then
            MenuPendataan.Visible = True
            LoginBar.Visible = False
            LogoutBar.Visible = True
        End If

        'Jika user login adalah mahasiswa
        If (mahasiswa_role = True) Then
            MenuPendataan.Visible = False
            LoginBar.Visible = False
            LogoutBar.Visible = True
        End If
    End Sub

    Private Sub Kendaraan_Click(sender As Object, e As EventArgs) Handles Kendaraan.Click
        Kendaraan1.ShowDialog()
    End Sub

    Private Sub pemesanan_Click(sender As Object, e As EventArgs) Handles PemesananToolStripMenuItem.Click
        Formpemesanan.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
