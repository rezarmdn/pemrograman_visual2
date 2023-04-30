Public Class Biaya_Registrasi_Prodi_By_Reza_Ramadhan
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbProdi.Items.Clear()
        cmbProdi.Items.Add("Manajemen")
        cmbProdi.Items.Add("Akuntansi")
        cmbProdi.Items.Add("Ilmu Komunikasi")
        cmbProdi.Items.Add("Peternakan")
        cmbProdi.Items.Add("Teknik Industri")
        cmbProdi.Items.Add("Teknik Informatika")
    End Sub
    Private Sub cmbProdi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProdi.SelectedIndexChanged
        If cmbProdi.Text = "Manajemen" Then
            txtRegistrasi.Text = "Rp 4.500.000,-"
        ElseIf cmbProdi.Text = "Akuntansi" Then
            txtRegistrasi.Text = "Rp 5.800.000,-"
        ElseIf cmbProdi.Text = "Ilmu Komunikasi" Then
            txtRegistrasi.Text = "Rp 6.800.000,-"
        ElseIf cmbProdi.Text = "Peternakan" Then
            txtRegistrasi.Text = "Rp 7.800.000,-"
        ElseIf cmbProdi.Text = "Teknik Industri" Then
            txtRegistrasi.Text = "Rp 8.000.000,-"
        ElseIf cmbProdi.Text = "Teknik Informatika" Then
            txtRegistrasi.Text = "Rp 9.800.000,-"
        End If

    End Sub

End Class
