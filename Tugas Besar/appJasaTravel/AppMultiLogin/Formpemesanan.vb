Imports System.Text
Imports Newtonsoft.Json
Imports System.Net
Imports System.Net.Http
Public Class Formpemesanan

    Private selectedUserId As String = ""

    Private Sub TambahData()

        ' Set the data you want to send as key-value pairs
        Dim nama As String = Text_Nama_Pemesan.Text
        Dim email As String = Text_Email.Text
        Dim no_hp As String = Text_No_Hp.Text
        Dim Tanggal_Lahir As String = Text_Tanggal_Lahir.Text
        Dim bayar As String = Text_Bayar.Text

        Dim postData As String = $"nama_pemesanan={nama}&email={email}&no_hp={no_hp}&tanggal_lahir={Tanggal_Lahir}&bayar={bayar}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the POST request and get the response
            Dim responseBytes As Byte() = client.UploadData(pemesanan_api, "POST", byteArray)

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
        Dim nama As String = Text_Nama_Pemesan.Text
        Dim email As String = Text_Email.Text
        Dim no_hp As String = Text_No_Hp.Text
        Dim Tanggal_Lahir As String = Text_Tanggal_Lahir.Text
        Dim bayar As String = Text_Bayar.Text


        Dim postData As String = $"nama_pemesanan={nama}&email={email}&no_hp={no_hp}&tanggal_lahir={Tanggal_Lahir}&bayar={bayar}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(pemesanan_api & "?nama_pemesanan=" & Text_Nama_Pemesan.Text, "PUT", byteArray)

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

        Dim nama As String = Text_Nama_Pemesan.Text
        Dim email As String = Text_Email.Text
        Dim no_hp As String = Text_No_Hp.Text
        Dim Tanggal_Lahir As String = Text_Tanggal_Lahir.Text
        Dim bayar As String = Text_Bayar.Text


        Dim postData As String = $"nama_pemesanan={nama}&email={email}&no_hp={no_hp}&tanggal_lahir={Tanggal_Lahir}&bayar={bayar}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(pemesanan_api & "?nama_pemesanan=" & Text_Nama_Pemesan.Text, "DELETE", byteArray)

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
            Dim response As HttpResponseMessage = client.GetAsync(pemesanan_api & "?nama_pemesanan=" & Text_Nama_Pemesan.Text).Result

            ' Check if the request was successful
            If response.IsSuccessStatusCode Then
                ' Read the response content as a string
                Dim jsonString As String = response.Content.ReadAsStringAsync().Result
                Try
                    If (jsonString = "[]") Then
                        pemesanan_baru = True
                        MessageBox.Show("Data Not Found")
                        Exit Sub
                    Else
                        pemesanan_baru = False
                        Exit Sub
                    End If
                Catch ex As Exception

                Finally
                    If (pemesanan_baru = False) Then
                        ' Deserialize the JSON into objects
                        Dim data As List(Of pemesanan1) = JsonConvert.DeserializeObject(Of List(Of pemesanan1))(jsonString)

                        ' Create textboxes dynamically and set their values
                        For Each mydata As pemesanan1 In data
                            Text_Nama_Pemesan.Text = mydata.nama_pemesanan
                            Text_Email.Text = mydata.email
                            Text_No_Hp.Text = mydata.no_hp
                            Text_Tanggal_Lahir.Text = mydata.tanggal_lahir
                            Text_Bayar.Text = mydata.bayar
                        Next
                    End If

                End Try
            Else
                ' Request failed, handle the error
                MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}")

            End If
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloaded()
    End Sub

    Private Async Sub Reloaded()
        Try
            Using client As New HttpClient()
                ' Make the GET request and retrieve the response asynchronously
                Dim response As String = Await client.GetStringAsync(pemesanan_api)

                ' Deserialize the JSON into a list of objects
                Dim data As List(Of pemesanan1) = JsonConvert.DeserializeObject(Of List(Of pemesanan1))(response)

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

    Private Sub GetClear()
        Text_Nama_Pemesan.Clear()
        Text_Email.Clear()
        Text_No_Hp.Clear()
        Text_Tanggal_Lahir.Clear()
        Text_Bayar.Clear()
        Reloaded()
        Text_Nama_Pemesan.Focus()
    End Sub

    Private Sub B_Submit_Click(sender As Object, e As EventArgs) Handles B_Submit.Click
        If (pemesanan_baru = True) Then
            TambahData()
        Else
            UpdateData()
        End If
    End Sub

    Private Sub B_Clear_Click(sender As Object, e As EventArgs) Handles B_Clear.Click
        GetClear()
    End Sub

    Private Sub B_Hapus_Click(sender As Object, e As EventArgs) Handles B_Hapus.Click
        If (pemesanan_baru = False) Then
            Dim result As DialogResult = MessageBox.Show("Apakah data akan dihapus?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DeleteData()
            Else
                MessageBox.Show("Data batal dihapus.")
            End If
        End If
    End Sub




    Private Sub Text_Nama_Pemesan_KeyDown(sender As Object, e As KeyEventArgs) Handles Text_Nama_Pemesan.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            GetData()
        End If
    End Sub



End Class