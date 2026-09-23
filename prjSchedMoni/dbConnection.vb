Imports MySql.Data.MySqlClient

Module dbConnection
    Public conn As New MySqlConnection("Server=127.0.0.1; Port=3306; Database=csta_sched_db; Uid=csta_user; Pwd=12345; SslMode=None;")

    Public Sub OpenConnection()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Public Sub CloseConnection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

End Module