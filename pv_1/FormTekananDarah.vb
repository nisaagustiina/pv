﻿Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports Mysqlx.Expect.Open.Types.Condition.Types
Imports Mysqlx.XDevAPI.Common

Public Class FormTekananDarah
    ' Koneksi ke database
    Dim conn As MySqlConnection = DBConnection.GetConnection()

    ' Array kategori tekanan darah
    Dim KategoriTekananDarah() As String = {"Normal", "Tinggi", "Rendah"}

    Const TekananNormalMaxSistolik As Integer = 120
    Const TekananNormalMaxDiastolik As Integer = 80
    Const TekananTinggiSistolik As Integer = 140
    Const TekananTinggiDiastolik As Integer = 90

    Dim sistolik As Integer
    Dim diastolik As Integer
    Dim kategori As String
    Dim noRekamMedis As String

    Private Function GetPasien(mrCode As String) As (Integer, String)
        Dim query As String = "SELECT id, name FROM patients WHERE `mr_no` = @mrCode"

        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@mrCode", mrCode)

            Try
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim id As Integer = reader("id")
                        Dim name As String = reader("name").ToString()
                        Return (id, name)
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
        Return (0, String.Empty)
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        noRekamMedis = txtMrCode.Text

        If String.IsNullOrWhiteSpace(noRekamMedis) Then
            MessageBox.Show("Masukkan no rekam medis Anda.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim result = GetPasien(noRekamMedis)
        Dim pasienId As Integer = result.Item1
        Dim pasienNama As String = result.Item2

        If pasienId = 0 Then
            MessageBox.Show("Nomor rekam medis tidak ditemukan. Silakan periksa kembali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

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

            MessageBox.Show("Nama: " & pasienNama & Environment.NewLine & "Kategori Tekanan Darah: " & kategori, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("Input nilai sistolik dan diastolik dengan benar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        ClearForm()
    End Sub

    Private Function TentukanKategoriTekananDarah(sistolik As Integer, diastolik As Integer) As String
        If sistolik <= TekananNormalMaxSistolik And diastolik <= TekananNormalMaxDiastolik Then
            Return KategoriTekananDarah(0) ' Normal
        ElseIf sistolik >= TekananTinggiSistolik Or diastolik >= TekananTinggiDiastolik Then
            Return KategoriTekananDarah(1) ' Tinggi
        Else
            Return KategoriTekananDarah(2) ' Rendah
        End If
    End Function

    Private Sub ClearForm()
        txtDiastolik.Clear()
        txtSistolik.Clear()
        txtMrCode.Clear()
    End Sub

    Private Sub FormTekananDarah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Label Hitung BMI pasien
        lblPerhitunganTekanan.Text = "PERHITUNGAN TEKANAN DARAH"
        lblPerhitunganTekanan.Font = New Font("Arial", 14, FontStyle.Bold)
        lblPerhitunganTekanan.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    'Hapus inputan data BMI
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Custom dialog untuk konfirmasi
        Dim dialog As New FormCustomDialog()
        dialog.Pesan = "Apakah Anda yakin ingin menghapus data inputan?"
        Dim result As DialogResult = dialog.ShowDialog()

        If result = DialogResult.Yes Then
            ' Reset semua inputan
            txtMrCode.Text = String.Empty
            txtSistolik.Text = String.Empty
            txtDiastolik.Text = String.Empty

            ' Tampilkan pesan bahwa inputan telah dihapus
            MessageBox.Show("Data inputan berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Jika tidak jadi menghapus
            MessageBox.Show("Data inputan tidak jadi dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class
