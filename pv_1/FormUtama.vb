Public Class FormUtama

    ' Deklarasi DataTable untuk menyimpan data pasien
    Public Shared DataPasien As New DataTable

    ' Event Load saat Form Utama dijalankan
    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inisialisasi DataTable
        With DataPasien.Columns
            .Add("Nama Pasien", GetType(String))
            .Add("Nomor Rekam Medis", GetType(String))
            .Add("NIK", GetType(String))
            .Add("Tanggal Lahir", GetType(Date))
            .Add("Jenis Kelamin", GetType(String))
            .Add("Usia", GetType(Integer))
            .Add("Alamat", GetType(String))
            .Add("Nomor Telepon", GetType(String))
            .Add("Riwayat Penyakit", GetType(String))
            .Add("Jenis Pendaftaran", GetType(String))
            .Add("Tipe Pembayaran", GetType(String))
        End With

        'Saat aplikasi pertama kali dijalankan, tampilkan FormDataDaftarPasien
        'TampilkanForm(New FormDataDaftarPasien())

        ' Mengubah warna latar belakang Panel 
        plnNavigasi.BackColor = ColorTranslator.FromHtml("#0D9276")



    End Sub




    ' Method untuk menampilkan form di panel konten
    Private Sub TampilkanForm(form As Form)
        ' Bersihkan panel konten sebelum menampilkan form baru
        pnlKonten.Controls.Clear()

        ' Atur form sebagai child control dari panel
        form.TopLevel = False
        form.Dock = DockStyle.Fill

        ' Tambahkan form ke panel dan tampilkan
        pnlKonten.Controls.Add(form)
        form.Show()
    End Sub

    ' Event untuk tombol navigasi Pendaftaran Pasien
    Private Sub btnPendaftaran_Click(sender As Object, e As EventArgs) Handles btnPendaftaran.Click
        Dim formPendaftaran As New FormPendaftaranPasien()
        TampilkanForm(formPendaftaran)
    End Sub

    ' Event untuk tombol navigasi Perhitungan BMI
    Private Sub btnBMI_Click(sender As Object, e As EventArgs) Handles btnBMI.Click
        Dim formBMI As New FormBmi()
        TampilkanForm(formBMI)
    End Sub

    ' Event untuk tombol navigasi Perhitungan Tekanan Darah
    Private Sub btnTekanan_Click(sender As Object, e As EventArgs) Handles btnTekanan.Click
        Dim formTekanan As New FormTekananDarah()
        TampilkanForm(formTekanan)
    End Sub

    Private Sub btnDataDaftarPasien_Click(sender As Object, e As EventArgs) Handles btnDataDaftarPasien.Click
        Dim formDataDaftarPasien As New FormDataDaftarPasien()
        TampilkanForm(formDataDaftarPasien)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
