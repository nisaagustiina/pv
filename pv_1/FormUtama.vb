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
            .Add("Tempat Lahir", GetType(String))
            .Add("Tanggal Lahir", GetType(Date))
            .Add("Jenis Kelamin", GetType(String))
            .Add("Usia", GetType(Integer))
            .Add("Alamat", GetType(String))
            .Add("Nomor Telepon", GetType(String))
        End With

        ' Mengubah warna latar belakang Panel 
        plnNavigasi.BackColor = ColorTranslator.FromHtml("#0D9276")




    End Sub



    ' Method untuk menampilkan form di tengah dan menyesuaikan ukuran panel konten
    Public Sub TampilkanForm(form As Form)
        ' Bersihkan panel konten sebelum menampilkan form baru
        pnlKonten.Controls.Clear()

        ' Atur form sebagai child control dari panel
        form.TopLevel = False

        ' Sesuaikan ukuran form dengan ukuran panel
        form.Width = pnlKonten.Width - (2)
        form.Height = pnlKonten.Height - (2)

        ' Hitung posisi tengah form di dalam panel
        Dim posX As Integer = (pnlKonten.Width - form.Width) \ 2
        Dim posY As Integer = (pnlKonten.Height - form.Height) \ 2
        form.Location = New Point(posX, posY)

        ' Tambahkan form ke panel dan tampilkan
        pnlKonten.Controls.Add(form)
        form.Show()
    End Sub


    ' Event untuk tombol navigasi Pendaftaran Pasien
    Private Sub btnPendaftaran_Click(sender As Object, e As EventArgs) Handles btnPendaftaran.Click
        Dim formPilihPasien As New FormPilihPasien()
        TampilkanForm(formPilihPasien)
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

    ' Event untuk tombol navigasi Data Pasien
    Private Sub btnDataPasien_Click(sender As Object, e As EventArgs) Handles btnDataPasien.Click
        Dim formDataDaftarPasien As New FormDataPasien()
        TampilkanForm(formDataDaftarPasien)
    End Sub

    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        Dim formConfig As New FormConfig()
        TampilkanForm(formConfig)
    End Sub

    Private Sub btnDataPendaftaran_Click(sender As Object, e As EventArgs) Handles btnDataPendaftaran.Click
        Dim formDataPendaftaran As New FormDataPendaftaran()
        TampilkanForm(formDataPendaftaran)
    End Sub

    Private Sub lbSelamatDatang_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbDeskripsi.Click

    End Sub

    Private Sub lbNamaMedicaEntry_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
