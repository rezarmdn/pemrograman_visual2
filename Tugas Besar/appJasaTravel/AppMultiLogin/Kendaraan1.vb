Imports System.Text
Imports Newtonsoft.Json
Imports System.Net
Imports System.Net.Http
Public Class Kendaraan1

    Private selectedUserId As String = ""

    Private Sub TambahData()

        ' Set the data you want to send as key-value pairs
        Dim nama As String = Text_Kendaraan.Text
        Dim daya_angkut As String = Text_daya_angkut.Text
        Dim harga As String = Text_Harga.Text
        Dim rute As String = Text_rute.Text

        Dim postData As String = $"nama={nama}&daya_angkut={daya_angkut}&id_rute={rute}&harga={harga}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the POST request and get the response
            Dim responseBytes As Byte() = client.UploadData(kendaraan_api, "POST", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub UpdateData()

        ' Set the data you want to send as key-value pairs
        Dim nama As String = Text_Kendaraan.Text
        Dim daya_angkut As String = Text_daya_angkut.Text
        Dim harga As String = Text_Harga.Text
        Dim rute As String = Text_rute.Text


        Dim postData As String = $"nama={nama}&daya_angkut={daya_angkut}&id_rute={rute}&harga={harga}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(kendaraan_api & "?nama=" & Text_Kendaraan.Text, "PUT", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub DeleteData()

        ' Set the data you want to send as key-value pairs
        Dim nama As String = Text_Kendaraan.Text
        Dim daya_angkut As String = Text_daya_angkut.Text
        Dim harga As String = Text_Harga.Text
        Dim rute As String = Text_rute.Text


        Dim postData As String = $"nama={nama}&daya_angkut={daya_angkut}&id_rute={rute}&harga={harga}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(kendaraan_api & "?nama=" & Text_Kendaraan.Text, "DELETE", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub GetData()
        Using client As New HttpClient()
            ' Send a GET request to the API endpoint
            Dim response As HttpResponseMessage = client.GetAsync(kendaraan_api & "?nama=" & Text_Kendaraan.Text).Result

            ' Check if the request was successful
            If response.IsSuccessStatusCode Then
                ' Read the response content as a string
                Dim jsonString As String = response.Content.ReadAsStringAsync().Result
                Try
                    If (jsonString = "[]") Then
                        kendaraan_baru = True
                        MessageBox.Show("Data Not Found")
                        Exit Sub
                    Else
                        kendaraan_baru = False
                        Exit Sub
                    End If
                Catch ex As Exception

                Finally
                    If (kendaraan_baru = False) Then
                        ' Deserialize the JSON into objects
                        Dim data As List(Of kendaraan2) = JsonConvert.DeserializeObject(Of List(Of kendaraan2))(jsonString)

                        ' Create textboxes dynamically and set their values
                        For Each mydata As kendaraan2 In data
                            Text_Kendaraan.Text = mydata.nama
                            Text_daya_angkut.Text = mydata.daya_angkut
                            Text_Harga.Text = mydata.harga
                            Text_rute.Text = mydata.id_rute
                        Next
                    End If

                End Try
            Else
                ' Request failed, handle the error
                MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}")

            End If
        End Using
    End Sub

    Private Sub GetClear()
        Text_Kendaraan.Clear()
        Text_daya_angkut.Clear()
        Text_Harga.Clear()
        Text_rute.Clear()
        Reloaded()
        Text_Kendaraan.Focus()
    End Sub





    Private Sub B_simpan_Click(sender As Object, e As EventArgs) Handles B_simpan.Click
        If (kendaraan_baru = True) Then
            TambahData()
        Else
            UpdateData()
        End If
    End Sub
    Private Sub B_Clear_Click(sender As Object, e As EventArgs) Handles B_Clear.Click
        GetClear()
    End Sub


    Private Sub B_delete_Click(sender As Object, e As EventArgs) Handles B_delete.Click
        If (kendaraan_baru = False) Then
            Dim result As DialogResult = MessageBox.Show("Apakah data akan dihapus?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DeleteData()
            Else
                MessageBox.Show("Data batal dihapus.")
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloaded()
    End Sub



    Private Async Sub Reloaded()
        Try
            Using client As New HttpClient()
                ' Make the GET request and retrieve the response asynchronously
                Dim response As String = Await client.GetStringAsync(kendaraan_api)

                ' Deserialize the JSON into a list of objects
                Dim data As List(Of kendaraan2) = JsonConvert.DeserializeObject(Of List(Of kendaraan2))(response)

                ' Bind the data to the DataGridView
                DataGridView1.DataSource = data
            End Using
        Catch ex As HttpRequestException
            ' Handle HTTP request errors
            MessageBox.Show("An HTTP request error occurred: " & ex.Message, "Error")
        Catch ex As Exception
            ' Handle any other errors that occur during the request or deserialization
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
    End Sub



    Private Sub Text_Kendaraan_KeyDown(sender As Object, e As KeyEventArgs) Handles Text_Kendaraan.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            GetData()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < DataGridView1.Rows.Count Then
            selectedUserId = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
        End If
    End Sub

End Class