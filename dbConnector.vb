Imports MySql.Data.MySqlClient

Module dbConnector
    Public cn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public sql As String

    Public Sub Connect()
        Try
            cn.Close()
            'Change localhost to the server LAN IP (e.g. 192.168.1.x) when deploying to client machines
            cn.ConnectionString = "server=localhost;user=root;password=;database=library_db"
            cn.Open()
        Catch ex As Exception
            MsgBox("Database connection failed: " & ex.Message, MsgBoxStyle.Critical, "Connection Error")
        End Try
    End Sub
End Module