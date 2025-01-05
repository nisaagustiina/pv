Imports MySql.Data.MySqlClient

Public Class FormConfig
    ' Koneksi ke database
    Dim conn As MySqlConnection = DBConnection.GetConnection()

    ' Helper get data
    Private Function GetConfigValue(group As String, key As String) As String
        Dim query As String = "SELECT value FROM config WHERE `group` = @group AND `key` = @key"

        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@group", group)
            cmd.Parameters.AddWithValue("@key", key)

            Try
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Return reader("value").ToString()
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
        Return String.Empty
    End Function

    ' Helper update
    Private Sub UpdateConfigValue(group As String, key As String, value As String)
        Dim query As String = "UPDATE config SET value = @value WHERE `group` = @group AND `key` = @key"

        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@value", value)
            cmd.Parameters.AddWithValue("@group", group)
            cmd.Parameters.AddWithValue("@key", key)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    ' Event saat form pertama kali dimuat
    Private Sub FormConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Mengambil nilai kuota dan limit dari database
            txtKuota.Text = GetConfigValue("config_antrian", "kuota")
            txtLimit.Text = GetConfigValue("config_antrian", "limit")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Event saat tombol Save diklik
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Deklarasi variabel untuk kuota dan limit
        Dim kuota As Integer
        Dim limitAntrian As Integer

        ' Memastikan input adalah angka yang valid
        If Not Integer.TryParse(txtKuota.Text, kuota) OrElse Not Integer.TryParse(txtLimit.Text, limitAntrian) Then
            MessageBox.Show("Harap masukkan angka yang valid untuk kuota dan limit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Update data
            UpdateConfigValue("config_antrian", "kuota", kuota.ToString())
            UpdateConfigValue("config_antrian", "limit", limitAntrian.ToString())

            ' Menampilkan pesan setelah berhasil memperbarui data
            MessageBox.Show("Data berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class
