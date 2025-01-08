Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports Mysqlx.Expect.Open.Types.Condition.Types

Public Class FormTekananDarah
    ' Koneksi ke database
    Dim conn As MySqlConnection = DBConnection.GetConnection()
    Enum KategoriTekananDarah
        Normal
        Tinggi
        Rendah
        TidakTahu
    End Enum

    Const TekananNormalMaxSistolik As Integer = 120
    Const TekananNormalMaxDiastolik As Integer = 80
    Const TekananTinggiSistolik As Integer = 140
    Const TekananTinggiDiastolik As Integer = 90

    Dim sistolik As Integer
    Dim diastolik As Integer
    Dim kategori As KategoriTekananDarah

    Private Function GetPasien(mrCode As String) As Integer
        Dim query As String = "SELECT id FROM patients WHERE `mr_no` = @mrCode"

        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@mrCode", mrCode)

            Try
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Return reader("id")
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

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        If String.IsNullOrWhiteSpace(txtMrCode.Text) Then
            MessageBox.Show("Masukkan no rekam medis Anda.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim pasienId = GetPasien(txtMrCode.Text)

        If Integer.TryParse(txtSistolik.Text, sistolik) AndAlso Integer.TryParse(txtDiastolik.Text, diastolik) Then
            kategori = TentukanKategoriTekananDarah(sistolik, diastolik)

            Dim query As String = "UPDATE medical_records SET systolic_pressure = @tekananSistolik, diastolic_pressure = @tekananDiastolik WHERE `patient_id` = @pasienId"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@tekananSistolik", sistolik)
                cmd.Parameters.AddWithValue("@tekananDiastolik", diastolik)
                cmd.Parameters.AddWithValue("@pasienId", pasienId)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                Catch ex As MySqlException
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    conn.Close()
                End Try
            End Using

            MessageBox.Show("Kategori Tekanan Darah: " & kategori.ToString(), "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Input nilai sistolik dan diastolik dengan benar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        ClearForm()
    End Sub
    Private Function TentukanKategoriTekananDarah(sistolik As Integer, diastolik As Integer) As KategoriTekananDarah
        If sistolik <= TekananNormalMaxSistolik And diastolik <= TekananNormalMaxDiastolik Then
            Return KategoriTekananDarah.Normal
        ElseIf sistolik >= TekananTinggiSistolik Or diastolik >= TekananTinggiDiastolik Then
            Return KategoriTekananDarah.Tinggi
        Else
            Return KategoriTekananDarah.Rendah
        End If
    End Function

    Private Sub ClearForm()
        txtDiastolik.Clear()
        txtSistolik.Clear()
        txtMrCode.Clear()
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearForm()
    End Sub
End Class
