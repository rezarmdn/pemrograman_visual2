Module MyMod
    Public api_folder As String = "appakademik"
    Public users_api As String = "http://localhost/" & api_folder & "/users_api.php"
    Public pemesanan_api As String = "http://localhost/" & api_folder & "/pemesanan_api.php"
    Public kendaraan_api As String = "http://localhost/" & api_folder & "/kendaraan_api.php"

    Public Dashboard As New Form1
    Public kendaraan1Form As New kendaraan2
    Public Formpemesanan As New pemesanan1
    Public LoginForm As New Login
    Public kendaraan_baru As Boolean = False
    Public pemesanan_baru As Boolean = False
    Public admin_role As Boolean = False
    Public dosen_role As Boolean = False
    Public mahasiswa_role As Boolean = False
    Public login_valid As Boolean = False

End Module
