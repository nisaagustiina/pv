Imports pv_1.FormPendaftaranPasienBaru

Public Class FormPilihPasien


    Private Sub FormPendaftaranPasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mengubah warna latar belakang Form 
        Me.BackColor = ColorTranslator.FromHtml("#BBE2EC")

        ' Mengubah warna warna button btnPilihPasienBaru
        btnPilihPasienBaru.BackColor = ColorTranslator.FromHtml("#19456B")
        btnPilihPasienBaru.ForeColor = ColorTranslator.FromHtml("#FFF6E9")
        btnPilihPasienBaru.FlatAppearance.BorderSize = 0  ' Menghilangkan border

        ' Mengubah warna warna button btnPilihPasienLama
        btnPilihPasienLama.BackColor = ColorTranslator.FromHtml("#19456B")
        btnPilihPasienLama.ForeColor = ColorTranslator.FromHtml("#FFF6E9")
        btnPilihPasienLama.FlatAppearance.BorderSize = 0  ' Menghilangkan border



    End Sub

    Private Sub btnPilihPasienBaru_Click(sender As Object, e As EventArgs) Handles btnPilihPasienBaru.Click
        Dim formPendaftaranPasienBaru As New FormPendaftaranPasienBaru(0) ' 0 untuk pasien baru
        FormUtama.TampilkanForm(formPendaftaranPasienBaru) ' Panggil method untuk mengganti konten panel di FormUtama
    End Sub

    Private Sub btnPilihPasienLama_Click(sender As Object, e As EventArgs) Handles btnPilihPasienLama.Click
        Dim formPendaftaranPasienLama As New FormPendaftaranPasienLama(1) ' 1 untuk pasien lama
        FormUtama.TampilkanForm(formPendaftaranPasienLama) ' Panggil method untuk mengganti konten panel di FormUtama
    End Sub






End Class