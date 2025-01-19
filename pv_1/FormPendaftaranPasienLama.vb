Imports System.IO
Imports MySql.Data.MySqlClient
Imports pv_1.FormPendaftaranPasienBaru

Public Class FormPendaftaranPasienLama
    ' Koneksi ke database
    Dim conn As MySqlConnection = DBConnection.GetConnection()

    ' Array untuk tipe pembayaran
    Dim tipePembayaranArray() As String = {"Umum", "BPJS", "Asuransi Lainnya"}

    'Jenis Pendaftaran triger dari button
    Private _jenisPendaftaran As Integer ' 0 = Pasien Baru, 1 = Pasien Lama

    ' Konstruktor baru untuk menerima jenis pendaftaran dari Form Pilih Pasien
    Public Sub New(jenisPendaftaran As Integer)
        InitializeComponent()
        _jenisPendaftaran = jenisPendaftaran
    End Sub

    Private Sub FormPendaftaranPasienLama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Label pendaftaran pasien
        lbPendaftaranPasienLama.Text = "PENDAFTARAN PASIEN LAMA"
        lbPendaftaranPasienLama.Font = New Font("Arial", 14, FontStyle.Bold)
        lbPendaftaranPasienLama.TextAlign = ContentAlignment.MiddleCenter

        ' Menambahkan tipe pembayaran ke ComboBox cbTipeBayar
        For Each tipePembayaran As String In tipePembayaranArray 
            cbTipePembayaran.Items.Add(tipePembayaran) 
        Next

    End Sub

    ' Custom dialog 
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        'Custom dialog untuk konfirmasi
        Dim dialog As New FormCustomDialog()
        dialog.Pesan = "Apakah Anda yakin ingin menghapus data inputan?"
        Dim result As DialogResult = dialog.ShowDialog()

        If result = DialogResult.Yes Then
            ' Reset semua inputan
            txtKeluhan.Text = String.Empty
            cbTipePembayaran.SelectedIndex = -1 ' Reset ComboBox ke kondisi kosong

            ' Tampilkan pesan bahwa inputan telah dihapus
            MessageBox.Show("Data inputan berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Jika tidak jadi menghapus
            MessageBox.Show("Data inputan tidak jadi dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Mencari Data Pasien Berdasarkan Nomor Rekam Medis
    Private Sub SearchPatientByRM(nomorRekamMedis As String)
        Try
            ' Membuka koneksi ke database
            conn.Open()

            ' Query untuk mencari data pasien berdasarkan nomor rekam medis
            Dim query As String = "SELECT * FROM patients WHERE mr_no = @mr_no"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@mr_no", nomorRekamMedis)

            ' Menjalankan query dan mengambil data
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Jika data ditemukan
            If reader.HasRows Then
                While reader.Read()
                    ' Menampilkan data ke kontrol inputan
                    txtTanggalDaftar.Text = reader("created_at").ToString()
                    txtNamaPasien.Text = reader("name").ToString()
                    txtNIK.Text = reader("nik").ToString()
                    txtTempatLahir.Text = reader("birth_place").ToString()

                    ' Mengatur tanggal lahir
                    dtpTanggalLahir.Value = Convert.ToDateTime(reader("birth_date"))

                    ' Mengatur jenis kelamin
                    If reader("gender").ToString() = "M" Then
                        rbLakiLaki.Checked = True
                        rbPerempuan.Checked = False
                    Else
                        rbPerempuan.Checked = True
                        rbLakiLaki.Checked = False
                    End If

                    txtUsia.Text = reader("age").ToString()
                    txtAlamat.Text = reader("address").ToString()
                    txtNoTelepon.Text = reader("phone_number").ToString()
                End While
            Else
                MessageBox.Show("Data pasien tidak ditemukan.")
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Button Cari Nomer Rekam Medis
    Private Sub btnCariNomerRekamMedis_Click(sender As Object, e As EventArgs) Handles btnCariNomerRekamMedis.Click
        Dim nomorRekamMedis As String = txtbNomerRekamMedis.Text ' Ambil nomor rekam medis dari TextBox
        If String.IsNullOrEmpty(nomorRekamMedis) Then
            MessageBox.Show("Silakan masukkan nomor rekam medis.")
        Else
            SearchPatientByRM(nomorRekamMedis)
        End If
    End Sub

    'Update Jenis Pendaftaran Keluahan dan Tipe pembayaran
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        ' Ambil data dari kontrol inputan
        Dim nomorRekamMedis As String = txtbNomerRekamMedis.Text
        Dim keluhan As String = txtKeluhan.Text
        Dim tipePembayaran As String = cbTipePembayaran.SelectedItem?.ToString()

        ' Validasi inputan
        If String.IsNullOrEmpty(nomorRekamMedis) Then
            MessageBox.Show("Nomor rekam medis tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrEmpty(keluhan) AndAlso String.IsNullOrEmpty(tipePembayaran) Then
            MessageBox.Show("Keluhan atau tipe pembayaran harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

       ' Konversi tipe pembayaran menjadi integer 
        Dim paymentType As Integer = -1 ' Default jika tidak dipilih 
        If Not String.IsNullOrEmpty(tipePembayaran) Then 
        ' Cari indeks tipe pembayaran dalam array 
            Dim index As Integer = Array.IndexOf(tipePembayaranArray, tipePembayaran) 
            If index >= 0 Then
                paymentType = index + 1 
            End If 
        End If

        Try
            ' Membuka koneksi ke database
            conn.Open()

            ' Ambil data lama sebelum update
            Dim keluhanLama As String = GetKeluhanFromDatabase(nomorRekamMedis)
            Dim tipePembayaranLama As Integer = GetTipePembayaranFromDatabase(nomorRekamMedis)

            ' Query untuk memperbarui jenis pendfataran  keluhan dan tipe pembayaran di tabel registrations
            Dim query As String = "UPDATE registrations SET complaint = @keluhan, payment_type = @payment_type, type = @jenis_pendaftaran WHERE patient_id = (SELECT id FROM patients WHERE mr_no = @mr_no)"
            Dim cmd As New MySqlCommand(query, conn)

            ' Parameter query
            cmd.Parameters.AddWithValue("@mr_no", nomorRekamMedis)
            cmd.Parameters.AddWithValue("@keluhan", If(String.IsNullOrEmpty(keluhan), DBNull.Value, keluhan))
            cmd.Parameters.AddWithValue("@payment_type", If(paymentType = -1, DBNull.Value, paymentType))
            cmd.Parameters.AddWithValue("@jenis_pendaftaran", _jenisPendaftaran)

            ' Menjalankan query
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            ' Catete Log Perubahan
            If rowsAffected > 0 Then
                ' Cek jika ada perubahan pada keluhan dan tipe pembayaran
                If keluhanLama <> keluhan Then
                    CatatLog($"Keluhan diubah: {keluhanLama} -> {keluhan}")
                End If

                If tipePembayaranLama <> paymentType Then
                    CatatLog($"Tipe Pembayaran diubah: {tipePembayaranLama} -> {paymentType}")
                End If

                MessageBox.Show("Data berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Menampilkan path log di MessageBox
                Dim logPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DataPasien\log_perubahan.txt")
                MessageBox.Show("Log perubahan dapat dilihat di lokasi berikut:\n" & logPath, "Path Log Perubahan", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearForm()
            Else
                MessageBox.Show("Tidak ada data yang diperbarui. Periksa kembali nomor rekam medis.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Menutup koneksi ke database
            conn.Close()
        End Try

    End Sub

    ' Fungsi untuk mendapatkan keluhan dari database berdasarkan nomor rekam medis
    Private Function GetKeluhanFromDatabase(nomorRekamMedis As String) As String
        ' Query untuk mengambil data keluhan lama
       Dim query As String = "SELECT complaint FROM registrations " & _
                          "WHERE patient_id = (SELECT id FROM patients WHERE mr_no = @mr_no) " & _
                          "ORDER BY created_at DESC LIMIT 1"
        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@mr_no", nomorRekamMedis)
            Return cmd.ExecuteScalar()?.ToString()
        End Using
    End Function

    ' Fungsi untuk mendapatkan tipe pembayaran dari database berdasarkan nomor rekam medis
    Private Function GetTipePembayaranFromDatabase(nomorRekamMedis As String) As Integer
        Dim query As String = "SELECT payment_type FROM registrations " & _
                          "WHERE patient_id = (SELECT id FROM patients WHERE mr_no = @mr_no) " & _
                          "ORDER BY created_at DESC LIMIT 1"
        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@mr_no", nomorRekamMedis)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    ' File Log Perbahan Menambahkan File Dates and Times 
    Private Sub CatatLog(pesan As String)
        ' Path folder Documents dan folder DataPasien
        Dim documentsPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim folderPath As String = System.IO.Path.Combine(documentsPath, "DataPasien")

        ' Path untuk file log
        Dim logPath As String = System.IO.Path.Combine(folderPath, "log_perubahan_DataPasien.txt")

        ' Pesan log dengan tanggal dan waktu
        Dim logMessage As String = $"[{DateTime.Now:dd-MM-yyyy HH:mm:ss}] {pesan}"
        System.IO.File.AppendAllText(logPath, logMessage & Environment.NewLine)
    End Sub

    ' Fungsi untuk membersihkan semua inputan
    Private Sub ClearForm()
        ' Reset inputan setelah berhasil diperbarui
        txtbNomerRekamMedis.Clear()
        txtKeluhan.Clear()
        cbTipePembayaran.SelectedIndex = -1 ' Reset ComboBox ke kondisi kosong
        rbLakiLaki.Checked = False
        rbPerempuan.Checked = False
        txtNamaPasien.Clear()
        txtNIK.Clear()
        txtTempatLahir.Clear()
        txtUsia.Clear()
        txtAlamat.Clear()
        txtNoTelepon.Clear()
        dtpTanggalLahir.Value = DateTime.Now ' Reset tanggal lahir ke default
    End Sub

End Class
