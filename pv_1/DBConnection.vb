Imports MySql.Data.MySqlClient

Public Class DBConnection
    Private Shared connString As String = "Server=localhost;Database=medica_entry;Uid=root;Pwd=;"
    Public Shared Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connString)
    End Function
End Class
