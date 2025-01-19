Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class FormPendaftaranPasienBaru
    ' Koneksi ke database
    Dim conn As MySqlConnection = DBConnection.GetConnection()

    ' Array untuk tipe pembayaran
    Dim tipePembayaranArray() As String = {"Umum", "BPJS", "Asuransi Lainnya"}

    Dim kuota As Integer
    Dim sisaKuota As Integer
    Dim limitHour As Integer
    Dim lastReset As DateTime
    Dim mrCode As String

    'Jenis Pendaftaran triger dari button
    Private _jenisPendaftaran As Integer ' 0 = Pasien Baru, 1 = Pasien Lama

    ' Konstruktor baru untuk menerima jenis pendaftaran dari Form Pilih Pasien
    Public Sub New(jenisPendaftaran As Integer)
        InitializeComponent()
        _jenisPendaftaran = jenisPendaftaran
    End Sub

    ' Buat Direktori untuk Menyimpan File
    Private Sub BuatDirektori()
        ' Path folder Documents
        Dim documentsPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        ' Gabung dengan nama folder yang ingin dibuat
        Dim folderPath As String = System.IO.Path.Combine(documentsPath, "DataPasien")

        ' Cek apakah folder sudah ada
        If Not System.IO.Directory.Exists(folderPath) Then
            System.IO.Directory.CreateDirectory(folderPath)

        End If
    End Sub

    Private Sub FormPendaftaranPasienBaru_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Panggil buat direktori
        BuatDirektori()

        ' Menambahkan tipe pembayaran ke ComboBox cbTipeBayar
        For Each tipePembayaran As String In tipePembayaranArray 
            cbTipePembayaran.Items.Add(tipePembayaran) 
        Next

        ' Label pendaftaran pasien
        lbPendaftaranPasienBaru.Text = "PENDAFTARAN PASIEN BARU"
        lbPendaftaranPasienBaru.Font = New Font("Arial", 14, FontStyle.Bold)
        lbPendaftaranPasienBaru.TextAlign = ContentAlignment.MiddleCenter

        ' Mengatur posisi panel agar berada di tengah form
        pnlKontenDaftarPasien.Left = (Me.ClientSize.Width - pnlKontenDaftarPasien.Width) / 2
        pnlKontenDaftarPasien.Top = (Me.ClientSize.Height - pnlKontenDaftarPasien.Height) / 2

        ' Mengubah warna latar belakang Panel 
        pnlKontenDaftarPasien.BackColor = ColorTranslator.FromHtml("#19456B")

        ' Mengubah warna latar belakang Form 
        Me.BackColor = ColorTranslator.FromHtml("#BBE2EC")

        ' Mengubah warna warna button SIMPAN
        btnSimpan.BackColor = ColorTranslator.FromHtml("#0D9276")
        btnSimpan.ForeColor = ColorTranslator.FromHtml("#FFF6E9")
        btnSimpan.FlatAppearance.BorderSize = 0  ' Menghilangkan border

        ' Mengubah warna warna button HAPUS
        btnHapus.BackColor = ColorTranslator.FromHtml("#0D9276")
        btnHapus.ForeColor = ColorTranslator.FromHtml("#FFF6E9")
        btnHapus.FlatAppearance.BorderSize = 0  ' Menghilangkan border

        'Set tanggal pendaftaran secara otomatis ke TextBox
        Dim tanggalSekarang As String = DateTime.Now.ToString("dddd, dd MMMM yyyy", New CultureInfo("id-ID"))
        txtTanggalDaftar.Text = tanggalSekarang

        kuota = CInt(GetConfigValue("config_antrian", "kuota"))
        sisaKuota = CInt(GetConfigValue("config_antrian", "sisa_kuota"))
        limitHour = CInt(GetConfigValue("config_antrian", "limit"))
        mrCode = GetConfigValue("config_antrian", "mr_code")
        lastReset = If(String.IsNullOrEmpty(GetConfigValue("config_antrian", "last_reset")), DateTime.Now, CDate(GetConfigValue("config_antrian", "last_reset")))

        ' Cek Kuota
        If lastReset = DateTime.MinValue OrElse DateTime.Now.Subtract(lastReset).TotalHours >= limitHour Then
            ResetKuota()
            sisaKuota = kuota
        End If

    End Sub

    Private Sub FormDataDaftarPasien_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' Menjaga agar panel tetap berada di tengah ketika form diresize
        pnlKontenDaftarPasien.Left = (Me.ClientSize.Width - pnlKontenDaftarPasien.Width) / 2
        pnlKontenDaftarPasien.Top = (Me.ClientSize.Height - pnlKontenDaftarPasien.Height) / 2
    End Sub

    ' Function to get config data
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

    ' Function to reset kuota and update last reset timestamp
    Private Sub ResetKuota()
        Dim query1 As String = "UPDATE config SET value = @SisaKuota WHERE `group` = 'config_antrian' AND `key` = 'sisa_kuota';"
        Dim query2 As String = "UPDATE config SET value = @TanggalUpdate WHERE `group` = 'config_antrian' AND `key` = 'last_reset';"

        Using cmd1 As New MySqlCommand(query1, conn),
          cmd2 As New MySqlCommand(query2, conn)

            cmd1.Parameters.AddWithValue("@SisaKuota", kuota)
            cmd2.Parameters.AddWithValue("@TanggalUpdate", DateTime.Now)

            Try
                conn.Open()
                cmd1.ExecuteNonQuery()
                cmd2.ExecuteNonQuery()

            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    'Funcion untuk mr_code
    Function GenerateMedicalRecordNumber(format As String) As String
        ' Mendapatkan angka acak
        Dim random As New Random()
        Dim randomNumber As Integer = random.Next(10000, 99999) ' Angka acak 5 digit

        ' Mengganti placeholder {{No}} dengan angka acak
        Dim medicalRecordNumber As String = format.Replace("{{NO}}", randomNumber.ToString())
        Return medicalRecordNumber
    End Function

    ' Menyimpan data ke database
    Private Sub btnSimpan_Click_1(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' Validasi inputan kosong (opsional)
        If txtNamaPasien.Text = "" OrElse txtNIK.Text = "" Then
            MessageBox.Show("Harap isi semua kolom yang wajib.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validasi apakah masih ada kuota yang tersisa
        If sisaKuota <= 0 Then
            MessageBox.Show("Kuota untuk hari ini telah habis.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Jika masih ada kuota, lanjutkan
        If sisaKuota > 0 Then

            Dim nomorAntrian As Integer = kuota - sisaKuota + 1

            ' Ambil data dari kontrol di form
            Dim jenisKelamin As String = If(rbLakiLaki.Checked, "M", "F")
            Dim tanggalLahir As DateTime = dtpTanggalLahir.Value
            Dim usia As Integer = CInt(txtUsia.Text)
            Dim jenisPendaftaran As Integer = _jenisPendaftaran
           Dim tipePembayaran As String = cbTipePembayaran.SelectedItem?.ToString()

       ' Konversi tipe pembayaran menjadi integer 
        Dim paymentType As Integer = -1 ' Default jika tidak dipilih 
        If Not String.IsNullOrEmpty(tipePembayaran) Then 
        ' Cari indeks tipe pembayaran dalam array 
            Dim index As Integer = Array.IndexOf(tipePembayaranArray, tipePembayaran) 
            If index >= 0 Then
                paymentType = index + 1 
            End If 
        End If

            If usia <= 0 Then
                MessageBox.Show("Usia tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim randCode = GenerateMedicalRecordNumber(mrCode)

            ' Query insert data pasien
            Dim query As String = "INSERT INTO patients (name, mr_no, nik, birth_place, birth_date, gender, age, address, phone_number) " &
                "VALUES (@NamaPasien, @NoRekamMedis, @NIK, @TempatLahir, @TanggalLahir, @JenisKelamin, @Usia, @Alamat, @NoTelepon); " &
                "SELECT LAST_INSERT_ID();"

            Using conn
                Try
                    conn.Open()

                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@NamaPasien", txtNamaPasien.Text)
                    cmd.Parameters.AddWithValue("@NoRekamMedis", randCode)
                    cmd.Parameters.AddWithValue("@NIK", txtNIK.Text)
                    cmd.Parameters.AddWithValue("@TanggalLahir", tanggalLahir)
                    cmd.Parameters.AddWithValue("@TempatLahir", txtTempatLahir.Text)
                    cmd.Parameters.AddWithValue("@JenisKelamin", jenisKelamin)
                    cmd.Parameters.AddWithValue("@Usia", usia)
                    cmd.Parameters.AddWithValue("@Alamat", txtAlamat.Text)
                    cmd.Parameters.AddWithValue("@NoTelepon", txtNoTelepon.Text)

                    Dim pasienId As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    ' Menambah pendaftaran
                    Dim queryPendaftaran As String = "INSERT INTO registrations (registration_date, patient_id, complaint, queue_no, type, payment_type) " &
                        "VALUES (@TanggalRegistrasi, @PasienId, @Keluhan, @NoAntrian, @JenisPendaftaran, @TipePembayaran)"

                    Dim cmdPendaftaran As New MySqlCommand(queryPendaftaran, conn)
                    cmdPendaftaran.Parameters.AddWithValue("@TanggalRegistrasi", DateTime.Now)
                    cmdPendaftaran.Parameters.AddWithValue("@PasienId", pasienId)
                    cmdPendaftaran.Parameters.AddWithValue("@Keluhan", txtKeluhan.Text)
                    cmdPendaftaran.Parameters.AddWithValue("@JenisPendaftaran", _jenisPendaftaran)
                    cmdPendaftaran.Parameters.AddWithValue("@TipePembayaran", paymentType)
                    cmdPendaftaran.Parameters.AddWithValue("@NoAntrian", nomorAntrian)
                    cmdPendaftaran.ExecuteNonQuery()

                    ' Menambah rekam medis
                    Dim queryRM As String = "INSERT INTO medical_records (patient_id) VALUES (@PasienId)"
                    Dim cmdRM As New MySqlCommand(queryRM, conn)
                    cmdRM.Parameters.AddWithValue("@PasienId", pasienId)
                    cmdRM.ExecuteNonQuery()

                    ' Update sisa kuota
                    UpdateSisaKuota(sisaKuota - 1)

                    ' Menampilkan pesan sukses
                    MessageBox.Show("Data pasien berhasil ditambahkan! Nomor Antrian: " & nomorAntrian, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As MySqlException
                    MessageBox.Show("Terjadi kesalahan saat menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As Exception
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using

        End If

        ' Panggil fungsi untuk menyimpan File  Data pasien
        SimpanDataPasienKeFile()

        ' Clear form setelah sukses
        ClearForm()

    End Sub

    ' Update sisa kuota
    Private Sub UpdateSisaKuota(sisaKuota As Integer)
        Dim query As String = "UPDATE config SET value = @SisaKuota WHERE `group` = 'config_antrian' AND `key` = 'sisa_kuota'"

        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@SisaKuota", sisaKuota)

            Try
                cmd.ExecuteNonQuery()
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Menyimpan Data Pasien ke dalam File
    Private Sub SimpanDataPasienKeFile()
        Try

            ' Path folder Documents dan folder DataPasien
            Dim documentsPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            Dim folderPath As String = System.IO.Path.Combine(documentsPath, "DataPasien")
            ' Nama file yang ingin disimpan
            Dim fileName As String = "FileDataPasien.txt"
            Dim filePath As String = System.IO.Path.Combine(folderPath, fileName)
            ' Buat folder DataPasien jika belum ada
            If Not System.IO.Directory.Exists(folderPath) Then
                System.IO.Directory.CreateDirectory(folderPath)
            End If


            ' Data pasien
            Dim dataPasien As String = $"Tanggal Pendaftaran: {txtTanggalDaftar.Text}" & Environment.NewLine &
                                $"Nama Pasien: {txtNamaPasien.Text}" & Environment.NewLine &
                                 $"NIK: {txtNIK.Text}" & Environment.NewLine &
                                 $"Tempat Lahir: {txtTempatLahir.Text}" & Environment.NewLine &
                                 $"Tanggal Lahir: {dtpTanggalLahir.Value.ToShortDateString()}" & Environment.NewLine &
                                 $"Jenis Kelamin: {(If(rbLakiLaki.Checked, "Laki-laki", "Perempuan"))}" & Environment.NewLine &
                                 $"Usia: {txtUsia.Text}" & Environment.NewLine &
                                 $"Alamat: {txtAlamat.Text}" & Environment.NewLine &
                                 $"Nomor Telepon: {txtNoTelepon.Text}" & Environment.NewLine &
                                 $"Riwayat Penyakit: {txtKeluhan.Text}" & Environment.NewLine &
                                 $"Tipe Pembayaran: {cbTipePembayaran.SelectedItem}" & Environment.NewLine &
                                 "--------------------------------------------"

            ' Menulis data pasien ke file teks
            System.IO.File.AppendAllText(filePath, dataPasien)

            ' Menampilkan pesan log untuk menunjukkan lokasi file
            MessageBox.Show($"Data pasien berhasil disimpan! File dapat dilihat di lokasi berikut:{Environment.NewLine}{filePath}",
                        "Data Disimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Catat log
            CatatLog("Data pasien berhasil disimpan.")
        Catch ex As Exception
            MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ' File Log Perbahan Menambahkan File Dates and Times 
    Private Sub CatatLog(pesan As String)
        Try
            ' Path folder Documents dan folder DataPasien
            Dim documentsPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            Dim folderPath As String = System.IO.Path.Combine(documentsPath, "DataPasien")

            ' Path untuk file log
            Dim logPath As String = System.IO.Path.Combine(folderPath, "log_perubahan_DataPasien.txt")

            ' Pesan log dengan tanggal dan waktu
            Dim logMessage As String = $"[{DateTime.Now:dd-MM-yyyy HH:mm:ss}] {pesan}"

            ' Menambahkan log ke file
            System.IO.File.AppendAllText(logPath, logMessage & Environment.NewLine)
        Catch ex As Exception
            MessageBox.Show($"Terjadi kesalahan saat mencatat log: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Fungsi untuk membersihkan semua inputan
    Private Sub ClearForm()
        txtNamaPasien.Clear()
        txtTempatLahir.Clear()
        txtNIK.Clear()
        txtUsia.Clear()
        txtAlamat.Clear()
        txtNoTelepon.Clear()
        txtKeluhan.Clear()
        rbLakiLaki.Checked = False
        rbPerempuan.Checked = False
        cbTipePembayaran.SelectedIndex = -1
        dtpTanggalLahir.Value = DateTime.Now
    End Sub


    ' Custom dialog 
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        'Custom dialog untuk konfirmasi
        Dim dialog As New FormCustomDialog()
        dialog.Pesan = "Apakah Anda yakin ingin menghapus data inputan?"
        Dim result As DialogResult = dialog.ShowDialog()

        If result = DialogResult.Yes Then
            ' Reset semua inputan
            txtNamaPasien.Text = String.Empty
            txtTempatLahir.Text = String.Empty
            txtNIK.Text = String.Empty
            dtpTanggalLahir.Value = DateTime.Now ' Reset ke tanggal hari ini
            txtUsia.Text = String.Empty
            txtAlamat.Text = String.Empty
            txtNoTelepon.Text = String.Empty
            txtKeluhan.Text = String.Empty
            cbTipePembayaran.SelectedIndex = -1 ' Reset ComboBox ke kondisi kosong
            rbLakiLaki.Checked = False ' Reset RadioButton jenis kelamin
            rbPerempuan.Checked = False ' Reset RadioButton jenis kelamin

            ' Tampilkan pesan bahwa inputan telah dihapus
            MessageBox.Show("Data inputan berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Jika tidak jadi menghapus
            MessageBox.Show("Data inputan tidak jadi dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class
