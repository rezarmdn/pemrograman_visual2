Public Class Kode_Jabatan_By_Reza_Ramadhan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case txtKodeJabatan.Text
            Case "MGR" : txtKeterangan.Text = "Manager"

            Case "SKR" : txtKeterangan.Text = "Sekretaris"

            Case "BDH" : txtKeterangan.Text = "Bendahara"

            Case Else : txtKeterangan.Text = "Staff"
        End Select
    End Sub
End Class