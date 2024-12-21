Public Class FormPendaftaranPasien

    ' Event yang dipicu saat Form dimuat
    Private Sub FormPendaftaranPasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menambahkan jenis pendaftaran ke ComboBox cbJenisPendaftaran
        cbJenisPendaftaran.Items.Add("Pasien Baru")
        cbJenisPendaftaran.Items.Add("Pasien Lama")

        ' Menambahkan tipe pembayaran ke ComboBox cbTipeBayar
        cbTipePembayaran.Items.Add("Umum")
        cbTipePembayaran.Items.Add("BPJS")
        cbTipePembayaran.Items.Add("Asuransi Lainnya")


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

        'Warna font judul pendaftaran pasien
        lbPendaftaranPasien.ForeColor = ColorTranslator.FromHtml("#19456B")

    End Sub

    Private Sub FormDataDaftarPasien_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' Menjaga agar panel tetap berada di tengah ketika form diresize
        pnlKontenDaftarPasien.Left = (Me.ClientSize.Width - pnlKontenDaftarPasien.Width) / 2
        pnlKontenDaftarPasien.Top = (Me.ClientSize.Height - pnlKontenDaftarPasien.Height) / 2
    End Sub

    'Menyimpan data dari form pendaftaran pasien ke DataTable
    Private Sub btnSimpan_Click_1(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' Validasi inputan kosong (opsional)
        If txtNamaPasien.Text = "" OrElse txtNIK.Text = "" OrElse txtNoRekamMedis.Text = "" Then
            MessageBox.Show("Harap isi semua kolom yang wajib.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ambil data dari kontrol di form
        Dim jenisKelamin = If(rbLakiLaki.Checked, "Laki-laki", "Perempuan") ' RadioButton
        Dim tanggalLahir = dtpTanggalLahir.Value                             ' DateTimePicker

        ' Tambahkan data ke DataTable
        FormUtama.DataPasien.Rows.Add(
            txtNamaPasien.Text,            ' Nama Pasien
            txtNoRekamMedis.Text,          ' Nomor Rekam Medis
            txtNIK.Text,                   ' NIK
            tanggalLahir,                  ' Tanggal Lahir
            jenisKelamin,                  ' Jenis Kelamin
            CInt(txtUsia.Text),            ' Usia
            txtAlamat.Text,                ' Alamat
            txtNoTelepon.Text,             ' Nomor Telepon
            txtRiwayatPenyakit.Text,       ' Riwayat Penyakit
            cbJenisPendaftaran.Text,       ' Jenis Pendaftaran (ComboBox)
            cbTipePembayaran.Text          ' Tipe Pembayaran (ComboBox)
        )

        ' Konfirmasi data berhasil disimpan
        MessageBox.Show("Data pasien berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Bersihkan form setelah menyimpan
        ClearForm()
    End Sub

    ' Fungsi untuk membersihkan semua inputan
    Private Sub ClearForm()
        txtNamaPasien.Clear()
        txtNoRekamMedis.Clear()
        txtNIK.Clear()
        txtUsia.Clear()
        txtAlamat.Clear()
        txtNoTelepon.Clear()
        txtRiwayatPenyakit.Clear()
        rbLakiLaki.Checked = False
        rbPerempuan.Checked = False
        cbJenisPendaftaran.SelectedIndex = -1
        cbTipePembayaran.SelectedIndex = -1
        dtpTanggalLahir.Value = DateTime.Now
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        ' Custom dialog untuk konfirmasi
        Dim dialog As New FormCustomDialog()
        dialog.Pesan = "Apakah Anda yakin ingin menghapus data inputan?"
        Dim result As DialogResult = dialog.ShowDialog()

        If result = DialogResult.Yes Then
            ' Reset semua inputan
            txtNamaPasien.Text = String.Empty
            txtNoRekamMedis.Text = String.Empty
            txtNIK.Text = String.Empty
            dtpTanggalLahir.Value = DateTime.Now ' Reset ke tanggal hari ini
            txtUsia.Text = String.Empty
            txtAlamat.Text = String.Empty
            txtNoTelepon.Text = String.Empty
            txtRiwayatPenyakit.Text = String.Empty
            cbJenisPendaftaran.SelectedIndex = -1 ' Reset ComboBox ke kondisi kosong
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
